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
			[Cpp2IlInjected.Address(RVA = "0x27E0CF0", Offset = "0x27E00F0", VA = "0x1827E0CF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7876E0", Offset = "0x786AE0", VA = "0x1807876E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public FOLGEEKDGHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6A10", Offset = "0x3CD5E10", VA = "0x183CD6A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x32EB0D0", Offset = "0x32EA4D0", VA = "0x1832EB0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::IOJDDMIHILI<IBDPOCJOHKG> JIHMNJJIKIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2E09050", Offset = "0x2E08450", VA = "0x182E09050")]
		get
		{
			return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x32EB700", Offset = "0x32EAB00", VA = "0x1832EB700")]
	private DFPCDCNFMHC(global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> IAPGLFJKDEF, global::JDEJCIKLJDE<KIEGPKHNPAI, global::IOJDDMIHILI<IBDPOCJOHKG>, TRpcParam, TRpcReceiver, global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> FAHGNHLMLPK, global::GPHBPBOCDCO<TAction, TActionReceiver, TActionDeps, global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> DLHDPKIEKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E10F50", Offset = "0x2E10350", VA = "0x182E10F50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x32EB140", Offset = "0x32EA540", VA = "0x1832EB140")]
	internal static global::DFPCDCNFMHC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GDHAFJANMPF(global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> IAPGLFJKDEF, global::JDEJCIKLJDE<KIEGPKHNPAI, global::IOJDDMIHILI<IBDPOCJOHKG>, TRpcParam, TRpcReceiver, global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> FAHGNHLMLPK, global::GPHBPBOCDCO<TAction, TActionReceiver, TActionDeps, global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> DLHDPKIEKJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1B6E240", Offset = "0x1B6D640", VA = "0x181B6E240")]
	public global::IOJDDMIHILI<NEIPEEIDEIJ> GHPFGFOBOMB()
	{
		return default(global::IOJDDMIHILI<NEIPEEIDEIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x32EAD50", Offset = "0x32EA150", VA = "0x1832EAD50")]
	internal global::IOJDDMIHILI<NEIPEEIDEIJ> CPIDDLCHGIP(global::IOJDDMIHILI<DADGGCNLMDC> LIKFEBDBPON, in KIEGPKHNPAI ADHHHFDPAPI)
	{
		return default(global::IOJDDMIHILI<NEIPEEIDEIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x32EB350", Offset = "0x32EA750", VA = "0x1832EB350")]
	internal void HAGILDBFPKF(global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x32EB250", Offset = "0x32EA650", VA = "0x1832EB250")]
	internal void GIEHENOAGPE(global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x32EAE20", Offset = "0x32EA220", VA = "0x1832EAE20")]
	internal void DDMHJEFBDCI(global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x32EB2B0", Offset = "0x32EA6B0", VA = "0x1832EB2B0")]
	internal void GKMIABGKFEE(global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x32EAC90", Offset = "0x32EA090", VA = "0x1832EAC90")]
	internal void ABDKCAPGEOF(global::IOJDDMIHILI<OADMPFEFGLH> KBJBPEAKGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x32EB070", Offset = "0x32EA470", VA = "0x1832EB070")]
	public global::IOJDDMIHILI<NEIPEEIDEIJ> GAGENOLJEAL(global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI)
	{
		return default(global::IOJDDMIHILI<NEIPEEIDEIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x32EB3D0", Offset = "0x32EA7D0", VA = "0x1832EB3D0")]
	public void HLLJEIJECBK(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x32EAEB0", Offset = "0x32EA2B0", VA = "0x1832EAEB0")]
	public void EAECIJBDAKL(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x32EB6D0", Offset = "0x32EAAD0", VA = "0x1832EB6D0")]
	public void PHNBJCEMCDJ(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x32EB400", Offset = "0x32EA800", VA = "0x1832EB400")]
	public void JGBIGHCOMEN(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x32EAE80", Offset = "0x32EA280", VA = "0x1832EAE80")]
	public void DNKBICFEOLF(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI, in TRpcReceiver ADGDOKPCBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x32EB670", Offset = "0x32EAA70", VA = "0x1832EB670")]
	public global::IOJDDMIHILI<IBDPOCJOHKG> KNOEGEEMKJN(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI)
	{
		return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x32EB630", Offset = "0x32EAA30", VA = "0x1832EB630")]
	public bool KNIPLHMEFKN(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI, global::IOJDDMIHILI<IBDPOCJOHKG> AKGNOBJJLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x32EB220", Offset = "0x32EA620", VA = "0x1832EB220")]
	public global::IOJDDMIHILI<OADMPFEFGLH> GGCFFHAPFKE(global::IOJDDMIHILI<NEIPEEIDEIJ> ADHHHFDPAPI, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) CFMAPONGMKH)
	{
		return default(global::IOJDDMIHILI<OADMPFEFGLH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x32EB6A0", Offset = "0x32EAAA0", VA = "0x1832EB6A0")]
	public void LPLGCLJNABA(global::IOJDDMIHILI<OADMPFEFGLH> PHLLDEOMGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x32EB600", Offset = "0x32EAA00", VA = "0x1832EB600")]
	public void KHDIAHPDKAH(global::IOJDDMIHILI<OADMPFEFGLH> PHLLDEOMGCD, in TSyncFieldValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x32EB430", Offset = "0x32EA830", VA = "0x1832EB430")]
	public Task<global::OHFECDBHLHC<object, NPKBEKPOKML>> JILLBFEJHGO(in TAction GPNJNMLGIEN, bool HKEPEHPCOPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x32EADF0", Offset = "0x32EA1F0", VA = "0x1832EADF0")]
	public void DCCOMMDGIIL(in TActionReceiver EGIJMPKBLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32EAEE0", Offset = "0x32EA2E0", VA = "0x1832EAEE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x703080", Offset = "0x702480", VA = "0x180703080", Slot = "4")]
		get
		{
			return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::IOJDDMIHILI<IBDPOCJOHKG> GKFEINNKKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x703080", Offset = "0x702480", VA = "0x180703080", Slot = "14")]
		get
		{
			return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ENENLNBCHMI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "17")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x30E1670", Offset = "0x30E0A70", VA = "0x1830E1670")]
	private KLANNKJBBJE(global::AMHHNDLMNIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PICAOCFCGHD, global::IOJDDMIHILI<IBDPOCJOHKG> LIKFEBDBPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x30E10A0", Offset = "0x30E04A0", VA = "0x1830E10A0")]
	public static global::KLANNKJBBJE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GDHAFJANMPF(global::IOJDDMIHILI<IBDPOCJOHKG> LIKFEBDBPON, global::AMHHNDLMNIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PICAOCFCGHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x30E1240", Offset = "0x30E0640", VA = "0x1830E1240")]
	public global::IOJDDMIHILI<NEIPEEIDEIJ> GHPFGFOBOMB()
	{
		return default(global::IOJDDMIHILI<NEIPEEIDEIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x30E12B0", Offset = "0x30E06B0", VA = "0x1830E12B0")]
	public void HLLJEIJECBK(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x30E0FF0", Offset = "0x30E03F0", VA = "0x1830E0FF0")]
	public void EAECIJBDAKL(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x30E15F0", Offset = "0x30E09F0", VA = "0x1830E15F0")]
	public void PHNBJCEMCDJ(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x30E1320", Offset = "0x30E0720", VA = "0x1830E1320")]
	public void JGBIGHCOMEN(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x30E1480", Offset = "0x30E0880", VA = "0x1830E1480")]
	public global::IOJDDMIHILI<IBDPOCJOHKG> KNOEGEEMKJN(in KIEGPKHNPAI ADHHHFDPAPI)
	{
		return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x30E13F0", Offset = "0x30E07F0", VA = "0x1830E13F0")]
	public bool KNIPLHMEFKN(in KIEGPKHNPAI ADHHHFDPAPI, global::IOJDDMIHILI<IBDPOCJOHKG> AKGNOBJJLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x30E1170", Offset = "0x30E0570", VA = "0x1830E1170")]
	public global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue> GGCFFHAPFKE(global::IOJDDMIHILI<OADMPFEFGLH> KBJBPEAKGPP, in KIEGPKHNPAI IGJFJCHKKMF, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) CFMAPONGMKH)
	{
		return default(global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x30E14C0", Offset = "0x30E08C0", VA = "0x1830E14C0")]
	public void LPLGCLJNABA(in global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue> CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x30E1520", Offset = "0x30E0920", VA = "0x1830E1520")]
	public void NCALKIIAKCE(in global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue> PHLLDEOMGCD, in TSyncFieldValue JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x30E0F20", Offset = "0x30E0320", VA = "0x1830E0F20", Slot = "15")]
	public void AJBNHHLKAGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x30E13A0", Offset = "0x30E07A0", VA = "0x1830E13A0", Slot = "16")]
	public void JILLBFEJHGO(global::IOJDDMIHILI<GGICLPCGLOC> DAPJGJIMAOA, TAction GPNJNMLGIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x30E15C0", Offset = "0x30E09C0", VA = "0x1830E15C0", Slot = "5")]
	private void PDNEGFFNOFN(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x30E1590", Offset = "0x30E0990", VA = "0x1830E1590", Slot = "6")]
	private void PCBMHPLCDCI(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2D95FA0", Offset = "0x2D953A0", VA = "0x182D95FA0", Slot = "7")]
	private void BIOJEIAIPHJ(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x30E0F50", Offset = "0x30E0350", VA = "0x1830E0F50", Slot = "8")]
	private void CJOEBLHIOKC(in KIEGPKHNPAI ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x30E1070", Offset = "0x30E0470", VA = "0x1830E1070", Slot = "9")]
	private global::IOJDDMIHILI<IBDPOCJOHKG> GAEHNHHIJNO(in KIEGPKHNPAI ADHHHFDPAPI)
	{
		return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x30E12F0", Offset = "0x30E06F0", VA = "0x1830E12F0", Slot = "10")]
	private bool JCFDHEPECJP(in KIEGPKHNPAI ADHHHFDPAPI, global::IOJDDMIHILI<IBDPOCJOHKG> AKGNOBJJLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x30E0F80", Offset = "0x30E0380", VA = "0x1830E0F80", Slot = "11")]
	private global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue> DEFHADKNNLE(global::IOJDDMIHILI<OADMPFEFGLH> LIKFEBDBPON, in KIEGPKHNPAI ADHHHFDPAPI, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) CFMAPONGMKH)
	{
		return default(global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2D94DC0", Offset = "0x2D941C0", VA = "0x182D94DC0", Slot = "12")]
	private void JNKPAAJFGCJ(in global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue> CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x30E1280", Offset = "0x30E0680", VA = "0x1830E1280", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
		get
		{
			return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E070", Offset = "0x3D8D470", VA = "0x183D8E070")]
	protected AMHHNDLMNIA(TActionDeps MPBKKECLGHP, int? DKEMHCHHINN, int? KPLKGOBDFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3D8CB40", Offset = "0x3D8BF40", VA = "0x183D8CB40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3D8CEB0", Offset = "0x3D8C2B0", VA = "0x183D8CEB0")]
	public global::DFPCDCNFMHC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> FBCBIAOKFMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3D8D2A0", Offset = "0x3D8C6A0", VA = "0x183D8D2A0")]
	internal global::IOJDDMIHILI<NEIPEEIDEIJ> GHPFGFOBOMB(global::IOJDDMIHILI<IBDPOCJOHKG> BBBEPKHMHPD)
	{
		return default(global::IOJDDMIHILI<NEIPEEIDEIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3D8D630", Offset = "0x3D8CA30", VA = "0x183D8D630")]
	internal void IMPGHFMPLKG(global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3D8DD10", Offset = "0x3D8D110", VA = "0x183D8DD10")]
	internal global::IOJDDMIHILI<IBDPOCJOHKG> KNOEGEEMKJN(global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI)
	{
		return default(global::IOJDDMIHILI<IBDPOCJOHKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3D8D5A0", Offset = "0x3D8C9A0", VA = "0x183D8D5A0")]
	internal void GMKFGABKLOM(global::IOJDDMIHILI<IBDPOCJOHKG> AFLJPCGPOEC, global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3D8CA00", Offset = "0x3D8BE00", VA = "0x183D8CA00")]
	internal void CFDBMJEJEEE(global::IOJDDMIHILI<IBDPOCJOHKG> DAACGBFECDE, global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3D8DD60", Offset = "0x3D8D160", VA = "0x183D8DD60")]
	internal void MPJFFGDKILF(global::IOJDDMIHILI<IBDPOCJOHKG> AFLJPCGPOEC, global::IOJDDMIHILI<DADGGCNLMDC> ADHHHFDPAPI, in TRpcParam CFMAPONGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3D8C600", Offset = "0x3D8BA00", VA = "0x183D8C600")]
	internal global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue> ABAKMDBIOJA(global::IOJDDMIHILI<IBDPOCJOHKG> HNCANGJNGFC, global::IOJDDMIHILI<OADMPFEFGLH> KBJBPEAKGPP, string EBOEHIFNNLM, in TSyncFieldValue JFBPNBNBHOE, Action IGAMPECHIKO, Action<object> IFJBPOMDHMJ, Func<bool> MHNADODPMHK)
	{
		return default(global::DOPOCHMLCMF<IBDPOCJOHKG, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3D8DF80", Offset = "0x3D8D380", VA = "0x183D8DF80")]
	internal void NLJILAPKPAC(global::IOJDDMIHILI<IBDPOCJOHKG> HNCANGJNGFC, string EBOEHIFNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3D8C7A0", Offset = "0x3D8BBA0", VA = "0x183D8C7A0")]
	internal void ABDKCAPGEOF(global::AHBCNHEDODP<IBDPOCJOHKG, TSyncFieldValue> KBJBPEAKGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D8C9C0", Offset = "0x3D8BDC0", VA = "0x183D8C9C0")]
	internal void AJBNHHLKAGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D8D880", Offset = "0x3D8CC80", VA = "0x183D8D880")]
	internal void JILLBFEJHGO(global::IOJDDMIHILI<IBDPOCJOHKG> NOJAHDOHDIN, global::IOJDDMIHILI<GGICLPCGLOC> DAPJGJIMAOA, in TAction GPNJNMLGIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3D8CA70", Offset = "0x3D8BE70", VA = "0x183D8CA70")]
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
