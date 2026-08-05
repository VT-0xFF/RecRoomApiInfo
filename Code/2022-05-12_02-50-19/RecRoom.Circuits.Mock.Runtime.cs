using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct FBBPJADJODD
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OIHFJKNOMKJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable, global::AGDLGCHBPFF<global::CBOPPAHLFPF<EDFHKFBHEHN>, global::CBOPPAHLFPF<PMFPIGBKCDH>, TRpcParam, TRpcReceiver, global::CBOPPAHLFPF<AANKPNPBPDK>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::AIMDOPBJJEG<TAction, Task<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>>, TActionReceiver> where TRpcReceiver : global::OPEKCGNFMJN<TRpcParam> where TActionReceiver : global::CMIMIFNKEII<TAction, Task<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>>> where TActionDeps : global::PHMKONECFLF<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class LPHJHHBLBNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::OIHFJKNOMKJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public LPHJHHBLBNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class LMAEJPAEHOM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct <<SendActionToAll>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public LMAEJPAEHOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskCompletionSource<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private TaskAwaiter<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x36FC850", Offset = "0x36FBC50", VA = "0x1836FC850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x714190", Offset = "0x713590", VA = "0x180714190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public LPHJHHBLBNK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public LMAEJPAEHOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x36E6FE0", Offset = "0x36E63E0", VA = "0x1836E6FE0")]
		[AsyncStateMachine(typeof(global::OIHFJKNOMKJ<, , , , , >.LMAEJPAEHOM.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::ICCPKGJBCIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> ICJDHGAABDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::CBOPPAHLFPF<FBBPJADJODD>, global::CBOPPAHLFPF<EDFHKFBHEHN>> JGJDMLLDJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::CBOPPAHLFPF<FBBPJADJODD>> MNKHBGLMOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::JBOCBPCCAFA<int> GGAEFOJNJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::CBOPPAHLFPF<PMFPIGBKCDH> ActorId, global::CBOPPAHLFPF<BCKNNHEHKEO> RequestId, TAction Action)> NBFFOHCLFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool IMCEOBMEEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> GJHEEIMEJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::ODLMPAFPELO<BBNDHBFPOLB, global::CBOPPAHLFPF<PMFPIGBKCDH>, TRpcParam, TRpcReceiver, global::PJOFALFDGMC<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::ICCPKGJBCIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> IJCACFLBMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::POKNFMCPGCI<TAction, TActionReceiver, TActionDeps, global::ICCPKGJBCIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> MJKPMENFNNP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool NBFOBMJAHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x36F1D30", Offset = "0x36F1130", VA = "0x1836F1D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::CBOPPAHLFPF<PMFPIGBKCDH> EIAGIBCAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x36F1890", Offset = "0x36F0C90", VA = "0x1836F1890", Slot = "5")]
		get
		{
			return default(global::CBOPPAHLFPF<PMFPIGBKCDH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x36F2500", Offset = "0x36F1900", VA = "0x1836F2500")]
	protected OIHFJKNOMKJ(global::ICCPKGJBCIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> MKGMINLKDPI, global::ODLMPAFPELO<BBNDHBFPOLB, global::CBOPPAHLFPF<PMFPIGBKCDH>, TRpcParam, TRpcReceiver, global::PJOFALFDGMC<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::ICCPKGJBCIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> EDEKKNNJELL, global::POKNFMCPGCI<TAction, TActionReceiver, TActionDeps, global::ICCPKGJBCIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> DCHCCKJNHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3378120", Offset = "0x3377520", VA = "0x183378120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x36F2010", Offset = "0x36F1410", VA = "0x1836F2010")]
	public static global::OIHFJKNOMKJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> HFCEOLCNMNF(global::ICCPKGJBCIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> MKGMINLKDPI, global::ODLMPAFPELO<BBNDHBFPOLB, global::CBOPPAHLFPF<PMFPIGBKCDH>, TRpcParam, TRpcReceiver, global::PJOFALFDGMC<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::ICCPKGJBCIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> EDEKKNNJELL, global::POKNFMCPGCI<TAction, TActionReceiver, TActionDeps, global::ICCPKGJBCIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> DCHCCKJNHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2EAAFC0", Offset = "0x2EAA3C0", VA = "0x182EAAFC0")]
	public global::CBOPPAHLFPF<EDFHKFBHEHN> GEEEFNDEIHM()
	{
		return default(global::CBOPPAHLFPF<EDFHKFBHEHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x36F21B0", Offset = "0x36F15B0", VA = "0x1836F21B0")]
	internal global::CBOPPAHLFPF<EDFHKFBHEHN> JACOIEOFPKF(in global::CBOPPAHLFPF<FBBPJADJODD> MGMHKIPIHKD, in BBNDHBFPOLB CMGFKLKICHP)
	{
		return default(global::CBOPPAHLFPF<EDFHKFBHEHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x36F1BE0", Offset = "0x36F0FE0", VA = "0x1836F1BE0")]
	internal void DCJEJABKNEB(in global::CBOPPAHLFPF<FBBPJADJODD> CMGFKLKICHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x36F1C70", Offset = "0x36F1070", VA = "0x1836F1C70")]
	internal void DILPBLCJOMB(in global::CBOPPAHLFPF<FBBPJADJODD> CMGFKLKICHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x36F2150", Offset = "0x36F1550", VA = "0x1836F2150")]
	internal void IPKBGHHLGKN(in global::CBOPPAHLFPF<FBBPJADJODD> CMGFKLKICHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x36F2370", Offset = "0x36F1770", VA = "0x1836F2370")]
	internal void NBPDBNLPNHG(in global::CBOPPAHLFPF<FBBPJADJODD> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x36F2280", Offset = "0x36F1680", VA = "0x1836F2280")]
	internal void MECKFJCKGDL(in global::CBOPPAHLFPF<AANKPNPBPDK> HJILKKEIPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x36F1D90", Offset = "0x36F1190", VA = "0x1836F1D90")]
	public global::CBOPPAHLFPF<EDFHKFBHEHN> ENGPMGLMKKL(in global::CBOPPAHLFPF<FBBPJADJODD> CMGFKLKICHP)
	{
		return default(global::CBOPPAHLFPF<EDFHKFBHEHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x36F1DF0", Offset = "0x36F11F0", VA = "0x1836F1DF0")]
	public void FNFDIMFCJOH(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x36F1860", Offset = "0x36F0C60", VA = "0x1836F1860")]
	public void ABIIJOPHMFK(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x36F1AF0", Offset = "0x36F0EF0", VA = "0x1836F1AF0")]
	public void BFIMODMHBNP(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x36F2470", Offset = "0x36F1870", VA = "0x1836F2470")]
	public void OGKPKPOAAKD(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x36F1E20", Offset = "0x36F1220", VA = "0x1836F1E20")]
	public void GANCLPCIBLI(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcReceiver LOAKBMPLLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x36F20F0", Offset = "0x36F14F0", VA = "0x1836F20F0")]
	public global::CBOPPAHLFPF<PMFPIGBKCDH> IEJFLJFANEH(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP)
	{
		return default(global::CBOPPAHLFPF<PMFPIGBKCDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x36F2250", Offset = "0x36F1650", VA = "0x1836F2250")]
	public bool LMIIOPOGJHE(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in global::CBOPPAHLFPF<PMFPIGBKCDH> IHGGHPEPPHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x36F1CD0", Offset = "0x36F10D0", VA = "0x1836F1CD0")]
	public global::CBOPPAHLFPF<AANKPNPBPDK> DMFGEPFADFG(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) DNMFIMLLNDL)
	{
		return default(global::CBOPPAHLFPF<AANKPNPBPDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x36F1B50", Offset = "0x36F0F50", VA = "0x1836F1B50")]
	public void BNEKGOHJJGD(in global::CBOPPAHLFPF<AANKPNPBPDK> GCEJJEHDDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x36F1D00", Offset = "0x36F1100", VA = "0x1836F1D00")]
	public void DPODNKKMIDN(in global::CBOPPAHLFPF<AANKPNPBPDK> GCEJJEHDDEL, in TSyncFieldValue MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x36F18C0", Offset = "0x36F0CC0", VA = "0x1836F18C0")]
	public Task<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> AKNLOLJAKIE(in TAction MOOMHHEHKEJ, bool GFKGIPAPDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x36F1B80", Offset = "0x36F0F80", VA = "0x1836F1B80")]
	public void BNLFJIGMNAN(in TActionReceiver DDPMLLHENHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x36F1E50", Offset = "0x36F1250", VA = "0x1836F1E50")]
	public void GMCPDMFCNFA(in global::CBOPPAHLFPF<PMFPIGBKCDH> GCNBPOLLEGI, in global::CBOPPAHLFPF<BCKNNHEHKEO> GOAJODAPPPB, in TAction MOOMHHEHKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x36F24A0", Offset = "0x36F18A0", VA = "0x1836F24A0", Slot = "6")]
	private void OOMFEJHIAEC(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x36F1AC0", Offset = "0x36F0EC0", VA = "0x1836F1AC0", Slot = "7")]
	private void ALNFCJBCDJF(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x36F1B20", Offset = "0x36F0F20", VA = "0x1836F1B20", Slot = "8")]
	private void BMNGNNANCOF(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x36F2410", Offset = "0x36F1810", VA = "0x1836F2410", Slot = "9")]
	private void NIDMJOOIBNP(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x36F2440", Offset = "0x36F1840", VA = "0x1836F2440", Slot = "10")]
	private void OFKDHBIMIGE(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in TRpcReceiver LOAKBMPLLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3669470", Offset = "0x3668870", VA = "0x183669470", Slot = "11")]
	private global::CBOPPAHLFPF<PMFPIGBKCDH> OJNJPLECIEG(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP)
	{
		return default(global::CBOPPAHLFPF<PMFPIGBKCDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x36F1FE0", Offset = "0x36F13E0", VA = "0x1836F1FE0", Slot = "12")]
	private bool HACBADBKLGP(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in global::CBOPPAHLFPF<PMFPIGBKCDH> IHGGHPEPPHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x36F2340", Offset = "0x36F1740", VA = "0x1836F2340", Slot = "13")]
	private global::CBOPPAHLFPF<AANKPNPBPDK> MHOJDFEJAIO(in global::CBOPPAHLFPF<EDFHKFBHEHN> CMGFKLKICHP, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) DNMFIMLLNDL)
	{
		return default(global::CBOPPAHLFPF<AANKPNPBPDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x36F24D0", Offset = "0x36F18D0", VA = "0x1836F24D0", Slot = "14")]
	private void OOMGHNKIEPD(in global::CBOPPAHLFPF<AANKPNPBPDK> GCEJJEHDDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x36F2120", Offset = "0x36F1520", VA = "0x1836F2120", Slot = "15")]
	private void IKGNFNNBDFK(in global::CBOPPAHLFPF<AANKPNPBPDK> GCEJJEHDDEL, in TSyncFieldValue MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x36F1BB0", Offset = "0x36F0FB0", VA = "0x1836F1BB0", Slot = "16")]
	private Task<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> CNNENMFGAKF(in TAction MOOMHHEHKEJ, bool GFKGIPAPDHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class ICCPKGJBCIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::NGAKHKOJINL<BBNDHBFPOLB, global::CBOPPAHLFPF<PMFPIGBKCDH>, TRpcParam, global::PJOFALFDGMC<TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::IAAPOMOLEIP<TAction> where TRpcReceiver : global::OPEKCGNFMJN<TRpcParam> where TActionReceiver : global::CMIMIFNKEII<TAction, Task<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>>> where TActionDeps : global::PHMKONECFLF<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::CMOKODCLACC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> BEFEPAMEBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly global::CBOPPAHLFPF<PMFPIGBKCDH> HEEGADIEKGJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::CBOPPAHLFPF<PMFPIGBKCDH> EIAGIBCAOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE670", Offset = "0x5DDA70", VA = "0x1805DE670", Slot = "4")]
		get
		{
			return default(global::CBOPPAHLFPF<PMFPIGBKCDH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::CBOPPAHLFPF<PMFPIGBKCDH> KPAFFGPAPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5DE670", Offset = "0x5DDA70", VA = "0x1805DE670", Slot = "14")]
		get
		{
			return default(global::CBOPPAHLFPF<PMFPIGBKCDH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2FACE00", Offset = "0x2FAC200", VA = "0x182FACE00")]
	private ICCPKGJBCIA(global::CMOKODCLACC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> BGOFOMIBOAH, in global::CBOPPAHLFPF<PMFPIGBKCDH> MGMHKIPIHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2FACB20", Offset = "0x2FABF20", VA = "0x182FACB20")]
	public static global::ICCPKGJBCIA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> HFCEOLCNMNF(in global::CBOPPAHLFPF<PMFPIGBKCDH> MGMHKIPIHKD, global::CMOKODCLACC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> BGOFOMIBOAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2FACAB0", Offset = "0x2FABEB0", VA = "0x182FACAB0")]
	public global::CBOPPAHLFPF<EDFHKFBHEHN> GEEEFNDEIHM()
	{
		return default(global::CBOPPAHLFPF<EDFHKFBHEHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2FACA70", Offset = "0x2FABE70", VA = "0x182FACA70")]
	public void FNFDIMFCJOH(in BBNDHBFPOLB CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC690", Offset = "0x2FABA90", VA = "0x182FAC690")]
	public void ABIIJOPHMFK(in BBNDHBFPOLB CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC760", Offset = "0x2FABB60", VA = "0x182FAC760")]
	public void BFIMODMHBNP(in BBNDHBFPOLB CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2FACD80", Offset = "0x2FAC180", VA = "0x182FACD80")]
	public void OGKPKPOAAKD(in BBNDHBFPOLB CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2FACBF0", Offset = "0x2FABFF0", VA = "0x182FACBF0")]
	public global::CBOPPAHLFPF<PMFPIGBKCDH> IEJFLJFANEH(in BBNDHBFPOLB CMGFKLKICHP)
	{
		return default(global::CBOPPAHLFPF<PMFPIGBKCDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2FACC80", Offset = "0x2FAC080", VA = "0x182FACC80")]
	public bool LMIIOPOGJHE(in BBNDHBFPOLB CMGFKLKICHP, in global::CBOPPAHLFPF<PMFPIGBKCDH> IHGGHPEPPHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC960", Offset = "0x2FABD60", VA = "0x182FAC960")]
	public global::PJOFALFDGMC<TSyncFieldValue> DMFGEPFADFG(in global::CBOPPAHLFPF<AANKPNPBPDK> HJILKKEIPIL, in BBNDHBFPOLB PIGDOCJNBFB, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) DNMFIMLLNDL)
	{
		return default(global::PJOFALFDGMC<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC7F0", Offset = "0x2FABBF0", VA = "0x182FAC7F0")]
	public void BNEKGOHJJGD(in global::PJOFALFDGMC<TSyncFieldValue> DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC8F0", Offset = "0x2FABCF0", VA = "0x182FAC8F0")]
	public void DGLLJBGBEIG(in global::PJOFALFDGMC<TSyncFieldValue> GCEJJEHDDEL, in TSyncFieldValue MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x29334B0", Offset = "0x29328B0", VA = "0x1829334B0", Slot = "15")]
	public void CBOFCKAAMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC720", Offset = "0x2FABB20", VA = "0x182FAC720")]
	public void AKNLOLJAKIE(in global::CBOPPAHLFPF<BCKNNHEHKEO> GOAJODAPPPB, in TAction MOOMHHEHKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2FACC20", Offset = "0x2FAC020", VA = "0x182FACC20", Slot = "5")]
	private void IGCNKHAJBCB(in BBNDHBFPOLB CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2FACC50", Offset = "0x2FAC050", VA = "0x182FACC50", Slot = "6")]
	private void IOAFEPNMEKJ(in BBNDHBFPOLB CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1EF8070", Offset = "0x1EF7470", VA = "0x181EF8070", Slot = "7")]
	private void LDANOGCILDK(in BBNDHBFPOLB CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2FACAF0", Offset = "0x2FABEF0", VA = "0x182FACAF0", Slot = "8")]
	private void GMALLOBPAMH(in BBNDHBFPOLB CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2FACD20", Offset = "0x2FAC120", VA = "0x182FACD20", Slot = "9")]
	private global::CBOPPAHLFPF<PMFPIGBKCDH> NPJDOBLMMIP(in BBNDHBFPOLB CMGFKLKICHP)
	{
		return default(global::CBOPPAHLFPF<PMFPIGBKCDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2FACD50", Offset = "0x2FAC150", VA = "0x182FACD50", Slot = "10")]
	private bool OCJCBIJNPOK(in BBNDHBFPOLB CMGFKLKICHP, in global::CBOPPAHLFPF<PMFPIGBKCDH> IHGGHPEPPHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC880", Offset = "0x2FABC80", VA = "0x182FAC880", Slot = "11")]
	private global::PJOFALFDGMC<TSyncFieldValue> CNNJJCCHNIK(in global::CBOPPAHLFPF<AANKPNPBPDK> EGIMPHGOEAK, in BBNDHBFPOLB CMGFKLKICHP, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) DNMFIMLLNDL)
	{
		return default(global::PJOFALFDGMC<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7550", Offset = "0x1EF6950", VA = "0x181EF7550", Slot = "12")]
	private void ALIOIKIONAO(in global::PJOFALFDGMC<TSyncFieldValue> DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2FACA40", Offset = "0x2FABE40", VA = "0x182FACA40", Slot = "13")]
	private void DPFCGDOFAFC(in global::PJOFALFDGMC<TSyncFieldValue> GCEJJEHDDEL, in TSyncFieldValue MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2FAC850", Offset = "0x2FABC50", VA = "0x182FAC850", Slot = "16")]
	private void CFCMOIGNGLL(in global::CBOPPAHLFPF<BCKNNHEHKEO> GOAJODAPPPB, in TAction MOOMHHEHKEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CMOKODCLACC<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::OPEKCGNFMJN<TRpcParam> where TActionReceiver : global::CMIMIFNKEII<TAction, Task<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>>> where TActionDeps : global::PHMKONECFLF<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::CBOPPAHLFPF<PMFPIGBKCDH> DOHCOJABJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly global::CNKLMAGFFHC<FBBPJADJODD, ABBKABKNOJM> EBNFCHPAIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Dictionary<string, global::KMHHEIHBAJJ<TSyncFieldValue>> FDBBOIKNOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly global::HOODOFAEPJL<PMFPIGBKCDH, global::OIHFJKNOMKJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> IOPIDNJBJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly TActionDeps IKHADMLPJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly List<(global::CBOPPAHLFPF<PMFPIGBKCDH> ActorId, global::CBOPPAHLFPF<BCKNNHEHKEO> RequestId, TAction Action)> FALJMDMBHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? EDKBICCNCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly int? JBGPJGGGMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Queue<(global::CBOPPAHLFPF<PMFPIGBKCDH> ActorId, global::CBOPPAHLFPF<BCKNNHEHKEO> RequestId, TAction Action)> MCBMMOKEMBD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal global::CBOPPAHLFPF<PMFPIGBKCDH> PGGBFPCPPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x552ED0", Offset = "0x5522D0", VA = "0x180552ED0")]
		get
		{
			return default(global::CBOPPAHLFPF<PMFPIGBKCDH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x35A0EF0", Offset = "0x35A02F0", VA = "0x1835A0EF0")]
	protected CMOKODCLACC(TActionDeps BLOIFCFPPLO, int? DANABLOAGJH, int? PBNHNCNMPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x359FD10", Offset = "0x359F110", VA = "0x18359FD10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x359F7B0", Offset = "0x359EBB0", VA = "0x18359F7B0")]
	public global::OIHFJKNOMKJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> BGMHCGPACPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x35A0430", Offset = "0x359F830", VA = "0x1835A0430")]
	internal global::CBOPPAHLFPF<EDFHKFBHEHN> GEEEFNDEIHM(in global::CBOPPAHLFPF<PMFPIGBKCDH> HKCOINKLGBP)
	{
		return default(global::CBOPPAHLFPF<EDFHKFBHEHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x35A0D10", Offset = "0x35A0110", VA = "0x1835A0D10")]
	internal void NGHNBIDPBFA(in global::CBOPPAHLFPF<FBBPJADJODD> CMGFKLKICHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x35A0A50", Offset = "0x359FE50", VA = "0x1835A0A50")]
	internal global::CBOPPAHLFPF<PMFPIGBKCDH> IEJFLJFANEH(in global::CBOPPAHLFPF<FBBPJADJODD> CMGFKLKICHP)
	{
		return default(global::CBOPPAHLFPF<PMFPIGBKCDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x35A02B0", Offset = "0x359F6B0", VA = "0x1835A02B0")]
	internal void EBBGFDLGEED(in global::CBOPPAHLFPF<PMFPIGBKCDH> FDCFEJAMCMF, in global::CBOPPAHLFPF<FBBPJADJODD> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x35A0830", Offset = "0x359FC30", VA = "0x1835A0830")]
	internal void GNADGLIPLCE(in global::CBOPPAHLFPF<PMFPIGBKCDH> NJOELJPJHGM, in global::CBOPPAHLFPF<FBBPJADJODD> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x35A0020", Offset = "0x359F420", VA = "0x1835A0020")]
	internal void EAIPGOLLEFF(in global::CBOPPAHLFPF<PMFPIGBKCDH> FDCFEJAMCMF, in global::CBOPPAHLFPF<FBBPJADJODD> CMGFKLKICHP, in TRpcParam DNMFIMLLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x35A08B0", Offset = "0x359FCB0", VA = "0x1835A08B0")]
	internal global::PJOFALFDGMC<TSyncFieldValue> ICIIJAKDEOB(global::CBOPPAHLFPF<PMFPIGBKCDH> KKHKNBLPGEK, global::CBOPPAHLFPF<AANKPNPBPDK> HJILKKEIPIL, string KACNOLACOBJ, in TSyncFieldValue MGNFAPLJAOB, Action BKKOCCDDHJN, Action<object> FJKOJEFCGDL, Func<bool> LMOKFDFLKNC)
	{
		return default(global::PJOFALFDGMC<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x35A0340", Offset = "0x359F740", VA = "0x1835A0340")]
	internal void FBLNPPHAPCO(global::CBOPPAHLFPF<PMFPIGBKCDH> KKHKNBLPGEK, string KACNOLACOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x35A0AC0", Offset = "0x359FEC0", VA = "0x1835A0AC0")]
	internal void MECKFJCKGDL(global::KMHHEIHBAJJ<TSyncFieldValue> HJILKKEIPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x359FCE0", Offset = "0x359F0E0", VA = "0x18359FCE0")]
	internal void CBOFCKAAMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x359F260", Offset = "0x359E660", VA = "0x18359F260")]
	internal void AKNLOLJAKIE(in global::CBOPPAHLFPF<PMFPIGBKCDH> GCNBPOLLEGI, in global::CBOPPAHLFPF<BCKNNHEHKEO> GOAJODAPPPB, in TAction MOOMHHEHKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x359F190", Offset = "0x359E590", VA = "0x18359F190")]
	[CompilerGenerated]
	private global::OIHFJKNOMKJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> ADFEKFJOBOH(in global::CBOPPAHLFPF<PMFPIGBKCDH> MNGIGOINPCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct BBNDHBFPOLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly global::CBOPPAHLFPF<FBBPJADJODD> BGFJACPCLAM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xBB75A0", Offset = "0xBB69A0", VA = "0x180BB75A0")]
	private BBNDHBFPOLB(in global::CBOPPAHLFPF<FBBPJADJODD> CMGFKLKICHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4F0", Offset = "0x7FD8F0", VA = "0x1807FE4F0")]
	public static BBNDHBFPOLB HFCEOLCNMNF(in global::CBOPPAHLFPF<FBBPJADJODD> CMGFKLKICHP)
	{
		return default(BBNDHBFPOLB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct ABBKABKNOJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public global::CBOPPAHLFPF<PMFPIGBKCDH> APLAGICLIPB;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xBB75A0", Offset = "0xBB69A0", VA = "0x180BB75A0")]
	private ABBKABKNOJM(in global::CBOPPAHLFPF<PMFPIGBKCDH> HKCOINKLGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7FE4F0", Offset = "0x7FD8F0", VA = "0x1807FE4F0")]
	public static ABBKABKNOJM HFCEOLCNMNF(in global::CBOPPAHLFPF<PMFPIGBKCDH> HKCOINKLGBP)
	{
		return default(ABBKABKNOJM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct PJOFALFDGMC<TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly IKIHMMBOCHJ OELNABPAAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly global::KMHHEIHBAJJ<TSyncFieldValue> CGAALAPKJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Action FEOHCMMIBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Action<object> CIPKKGAPCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Func<bool> BPHJCBKJCLE;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3665540", Offset = "0x3664940", VA = "0x183665540")]
	private PJOFALFDGMC(IKIHMMBOCHJ EFONNMLBGFB, global::KMHHEIHBAJJ<TSyncFieldValue> LBHLIBAPFIO, Action BKKOCCDDHJN, Action<object> FJKOJEFCGDL, Func<bool> LMOKFDFLKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x36653E0", Offset = "0x36647E0", VA = "0x1836653E0")]
	public static global::PJOFALFDGMC<TSyncFieldValue> HFCEOLCNMNF(global::KMHHEIHBAJJ<TSyncFieldValue> LBHLIBAPFIO, Action BKKOCCDDHJN, Action<object> FJKOJEFCGDL, Func<bool> LMOKFDFLKNC)
	{
		return default(global::PJOFALFDGMC<TSyncFieldValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class KMHHEIHBAJJ<TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly string DCBIHGMJIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public TSyncFieldValue IKGDHNEELOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly Dictionary<global::CBOPPAHLFPF<PMFPIGBKCDH>, global::CBOPPAHLFPF<AANKPNPBPDK>> KBLADEBNMGM;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3063FC0", Offset = "0x30633C0", VA = "0x183063FC0")]
	private KMHHEIHBAJJ(string KACNOLACOBJ, in TSyncFieldValue MGNFAPLJAOB, Dictionary<global::CBOPPAHLFPF<PMFPIGBKCDH>, global::CBOPPAHLFPF<AANKPNPBPDK>> PEOEDDPGKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3063EA0", Offset = "0x30632A0", VA = "0x183063EA0")]
	public static global::KMHHEIHBAJJ<TSyncFieldValue> HFCEOLCNMNF(string KACNOLACOBJ, in TSyncFieldValue MGNFAPLJAOB)
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
