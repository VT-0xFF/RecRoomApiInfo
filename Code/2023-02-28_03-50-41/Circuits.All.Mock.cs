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
public sealed class FGKGHNCEHLE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::BKMMPBOFMNP<TRpcParam> where TActionReceiver : global::IBHDFOELJIL<TAction, Task<global::HJJOMCAHDKC<object, EKKNDELMKBB>>> where TActionDeps : global::OJBKFDLMNBG<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class CHIDKBPBMMI
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
			public CHIDKBPBMMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskCompletionSource<global::HJJOMCAHDKC<object, EKKNDELMKBB>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<global::HJJOMCAHDKC<object, EKKNDELMKBB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1D687E0", Offset = "0x1D671E0", VA = "0x181D687E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::FGKGHNCEHLE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::HJJOMCAHDKC<object, EKKNDELMKBB>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public CHIDKBPBMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x37AA120", Offset = "0x37A8B20", VA = "0x1837AA120")]
		[AsyncStateMachine(typeof(global::FGKGHNCEHLE<, , , , , >.CHIDKBPBMMI.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::CMLEMPDLBHK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KCLACGDGMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::GJECEMGANGF<MBMAJMCDNEK>, global::GJECEMGANGF<OAPAPBLKGPM>> DNGFJDPHADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::GJECEMGANGF<MBMAJMCDNEK>> DPAJNAPACFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::POPCPOCKAPJ<int> HHGIEEDEECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::GJECEMGANGF<FNHIAGNKANJ> ActorId, global::GJECEMGANGF<LLBJOCLOEDC> RequestId, TAction Action)> PBEPOACBHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool CAAIBOJABDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> BPHLAKDHNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::JCNHMAGDBOD<NGMPDCMACDK, global::GJECEMGANGF<FNHIAGNKANJ>, TRpcParam, TRpcReceiver, global::CMHNKNDBNII<FNHIAGNKANJ, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::CMLEMPDLBHK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> MPLPBIADGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::IIGJAEKBBOB<TAction, TActionReceiver, TActionDeps, global::CMLEMPDLBHK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> HFCFGBKEEJG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool AGGKKOBCONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x289F280", Offset = "0x289DC80", VA = "0x18289F280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::GJECEMGANGF<FNHIAGNKANJ> NELFCHDFPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x289F0D0", Offset = "0x289DAD0", VA = "0x18289F0D0")]
		get
		{
			return default(global::GJECEMGANGF<FNHIAGNKANJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x289FB40", Offset = "0x289E540", VA = "0x18289FB40")]
	private FGKGHNCEHLE(global::CMLEMPDLBHK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CFFEHCJNLHI, global::JCNHMAGDBOD<NGMPDCMACDK, global::GJECEMGANGF<FNHIAGNKANJ>, TRpcParam, TRpcReceiver, global::CMHNKNDBNII<FNHIAGNKANJ, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::CMLEMPDLBHK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> IPFCCFACPNB, global::IIGJAEKBBOB<TAction, TActionReceiver, TActionDeps, global::CMLEMPDLBHK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> OMOBFKLIGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x289F170", Offset = "0x289DB70", VA = "0x18289F170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x289F1A0", Offset = "0x289DBA0", VA = "0x18289F1A0")]
	internal static global::FGKGHNCEHLE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> EEKKKHPKBPD(global::CMLEMPDLBHK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CFFEHCJNLHI, global::JCNHMAGDBOD<NGMPDCMACDK, global::GJECEMGANGF<FNHIAGNKANJ>, TRpcParam, TRpcReceiver, global::CMHNKNDBNII<FNHIAGNKANJ, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::CMLEMPDLBHK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> IPFCCFACPNB, global::IIGJAEKBBOB<TAction, TActionReceiver, TActionDeps, global::CMLEMPDLBHK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> OMOBFKLIGGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x289F320", Offset = "0x289DD20", VA = "0x18289F320")]
	public global::GJECEMGANGF<OAPAPBLKGPM> GHHILMPIKNI()
	{
		return default(global::GJECEMGANGF<OAPAPBLKGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x289F410", Offset = "0x289DE10", VA = "0x18289F410")]
	internal global::GJECEMGANGF<OAPAPBLKGPM> KJEEDPBFDNP(global::GJECEMGANGF<MBMAJMCDNEK> OGGLMCNMCLJ, in NGMPDCMACDK LAFPICAOEAI)
	{
		return default(global::GJECEMGANGF<OAPAPBLKGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x289FAC0", Offset = "0x289E4C0", VA = "0x18289FAC0")]
	internal void PPEAEJDLKGD(global::GJECEMGANGF<MBMAJMCDNEK> LAFPICAOEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x289F3B0", Offset = "0x289DDB0", VA = "0x18289F3B0")]
	internal void IGALBPKKACM(global::GJECEMGANGF<MBMAJMCDNEK> LAFPICAOEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x289F040", Offset = "0x289DA40", VA = "0x18289F040")]
	internal void AAOMNMKEINI(global::GJECEMGANGF<MBMAJMCDNEK> LAFPICAOEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x289F540", Offset = "0x289DF40", VA = "0x18289F540")]
	internal void MCHOJPOAPEL(global::GJECEMGANGF<MBMAJMCDNEK> LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x289F610", Offset = "0x289E010", VA = "0x18289F610")]
	internal void MPAGEENJGPB(global::GJECEMGANGF<KFOBGHKHPNF> GOLPOBGEKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x289F4B0", Offset = "0x289DEB0", VA = "0x18289F4B0")]
	public global::GJECEMGANGF<OAPAPBLKGPM> LAHGBHMOKMC(global::GJECEMGANGF<MBMAJMCDNEK> LAFPICAOEAI)
	{
		return default(global::GJECEMGANGF<OAPAPBLKGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x289F140", Offset = "0x289DB40", VA = "0x18289F140")]
	public void CAGBBDDMCKK(global::GJECEMGANGF<OAPAPBLKGPM> LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x289FA90", Offset = "0x289E490", VA = "0x18289FA90")]
	public void PPDBCJEKNHK(global::GJECEMGANGF<OAPAPBLKGPM> LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x289F350", Offset = "0x289DD50", VA = "0x18289F350")]
	public void HBGOABCDJMM(global::GJECEMGANGF<OAPAPBLKGPM> LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x289FA30", Offset = "0x289E430", VA = "0x18289FA30")]
	public void PIODCDJDAOJ(global::GJECEMGANGF<OAPAPBLKGPM> LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x289F2F0", Offset = "0x289DCF0", VA = "0x18289F2F0")]
	public void FNFGMMMLJCA(global::GJECEMGANGF<OAPAPBLKGPM> LAFPICAOEAI, in TRpcReceiver OBHINMOIKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x289FA60", Offset = "0x289E460", VA = "0x18289FA60")]
	public global::GJECEMGANGF<FNHIAGNKANJ> POGIKCLLAKG(global::GJECEMGANGF<OAPAPBLKGPM> LAFPICAOEAI)
	{
		return default(global::GJECEMGANGF<FNHIAGNKANJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x289F100", Offset = "0x289DB00", VA = "0x18289F100")]
	public bool BOODGIIKIIH(global::GJECEMGANGF<OAPAPBLKGPM> LAFPICAOEAI, global::GJECEMGANGF<FNHIAGNKANJ> CALNIJNFDFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x289F0A0", Offset = "0x289DAA0", VA = "0x18289F0A0")]
	public global::GJECEMGANGF<KFOBGHKHPNF> ABNPKIAIOFM(global::GJECEMGANGF<OAPAPBLKGPM> LAFPICAOEAI, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) HMDGBADEDKH)
	{
		return default(global::GJECEMGANGF<KFOBGHKHPNF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x289F380", Offset = "0x289DD80", VA = "0x18289F380")]
	public void IBJMHNDAILN(global::GJECEMGANGF<KFOBGHKHPNF> GJHDHFKKAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x289F5E0", Offset = "0x289DFE0", VA = "0x18289F5E0")]
	public void MDCJJKEANKI(global::GJECEMGANGF<KFOBGHKHPNF> GJHDHFKKAMH, in TSyncFieldValue MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x289F860", Offset = "0x289E260", VA = "0x18289F860")]
	public Task<global::HJJOMCAHDKC<object, EKKNDELMKBB>> OOEIPFJIMKK(in TAction CKAPOBIDCEI, bool MCDDLIGDOFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x289F510", Offset = "0x289DF10", VA = "0x18289F510")]
	public void MADLFOKGKNJ(in TActionReceiver IOHPPIFBIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x289F6D0", Offset = "0x289E0D0", VA = "0x18289F6D0")]
	public void NOAJGABDMBK(global::GJECEMGANGF<FNHIAGNKANJ> NHIJJLFOFCH, global::GJECEMGANGF<LLBJOCLOEDC> PLPPGBBMDBN, in TAction CKAPOBIDCEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class CMLEMPDLBHK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::EMAFNDJOPON<NGMPDCMACDK, global::GJECEMGANGF<FNHIAGNKANJ>, TRpcParam, global::CMHNKNDBNII<FNHIAGNKANJ, TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::PIOEPOHJIDI<TAction> where TRpcReceiver : global::BKMMPBOFMNP<TRpcParam> where TActionReceiver : global::IBHDFOELJIL<TAction, Task<global::HJJOMCAHDKC<object, EKKNDELMKBB>>> where TActionDeps : global::OJBKFDLMNBG<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::LKPEBAMLCAJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> JHDBEJOIDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::GJECEMGANGF<FNHIAGNKANJ> FJGFKODKGHI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::GJECEMGANGF<FNHIAGNKANJ> NELFCHDFPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BD0", Offset = "0x6C15D0", VA = "0x1806C2BD0", Slot = "4")]
		get
		{
			return default(global::GJECEMGANGF<FNHIAGNKANJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::GJECEMGANGF<FNHIAGNKANJ> LIFLBJEFAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BD0", Offset = "0x6C15D0", VA = "0x1806C2BD0", Slot = "14")]
		get
		{
			return default(global::GJECEMGANGF<FNHIAGNKANJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JIFLPHGNHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "17")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x24E6C50", Offset = "0x24E5650", VA = "0x1824E6C50")]
	private CMLEMPDLBHK(global::LKPEBAMLCAJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> DLPDJBHFEAB, global::GJECEMGANGF<FNHIAGNKANJ> OGGLMCNMCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x24E67B0", Offset = "0x24E51B0", VA = "0x1824E67B0")]
	public static global::CMLEMPDLBHK<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> EEKKKHPKBPD(global::GJECEMGANGF<FNHIAGNKANJ> OGGLMCNMCLJ, global::LKPEBAMLCAJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> DLPDJBHFEAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x24E68E0", Offset = "0x24E52E0", VA = "0x1824E68E0")]
	public global::GJECEMGANGF<OAPAPBLKGPM> GHHILMPIKNI()
	{
		return default(global::GJECEMGANGF<OAPAPBLKGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E50A0", VA = "0x1824E66A0")]
	public void CAGBBDDMCKK(in NGMPDCMACDK LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x24E6BD0", Offset = "0x24E55D0", VA = "0x1824E6BD0")]
	public void PPDBCJEKNHK(in NGMPDCMACDK LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x24E6920", Offset = "0x24E5320", VA = "0x1824E6920")]
	public void HBGOABCDJMM(in NGMPDCMACDK LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x24E6B10", Offset = "0x24E5510", VA = "0x1824E6B10")]
	public void PIODCDJDAOJ(in NGMPDCMACDK LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x24E6B90", Offset = "0x24E5590", VA = "0x1824E6B90")]
	public global::GJECEMGANGF<FNHIAGNKANJ> POGIKCLLAKG(in NGMPDCMACDK LAFPICAOEAI)
	{
		return default(global::GJECEMGANGF<FNHIAGNKANJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x24E6610", Offset = "0x24E5010", VA = "0x1824E6610")]
	public bool BOODGIIKIIH(in NGMPDCMACDK LAFPICAOEAI, global::GJECEMGANGF<FNHIAGNKANJ> CALNIJNFDFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x24E64A0", Offset = "0x24E4EA0", VA = "0x1824E64A0")]
	public global::CMHNKNDBNII<FNHIAGNKANJ, TSyncFieldValue> ABNPKIAIOFM(global::GJECEMGANGF<KFOBGHKHPNF> GOLPOBGEKAG, in NGMPDCMACDK PAGKANKNAEA, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) HMDGBADEDKH)
	{
		return default(global::CMHNKNDBNII<FNHIAGNKANJ, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x24E69D0", Offset = "0x24E53D0", VA = "0x1824E69D0")]
	public void IBJMHNDAILN(in global::CMHNKNDBNII<FNHIAGNKANJ, TSyncFieldValue> HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x24E6570", Offset = "0x24E4F70", VA = "0x1824E6570")]
	public void ADKIOFLJCFL(in global::CMHNKNDBNII<FNHIAGNKANJ, TSyncFieldValue> GJHDHFKKAMH, in TSyncFieldValue MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x24E6880", Offset = "0x24E5280", VA = "0x1824E6880", Slot = "15")]
	public void FENGNIGFECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x24E6AC0", Offset = "0x24E54C0", VA = "0x1824E6AC0", Slot = "16")]
	public void OOEIPFJIMKK(global::GJECEMGANGF<LLBJOCLOEDC> PLPPGBBMDBN, TAction CKAPOBIDCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x24E69A0", Offset = "0x24E53A0", VA = "0x1824E69A0", Slot = "5")]
	private void IBHFGCKMGON(in NGMPDCMACDK LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x24E6A30", Offset = "0x24E5430", VA = "0x1824E6A30", Slot = "6")]
	private void JMDFDPMKLCF(in NGMPDCMACDK LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x24E68B0", Offset = "0x24E52B0", VA = "0x1824E68B0", Slot = "7")]
	private void GFCPGJJINID(in NGMPDCMACDK LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x24E65E0", Offset = "0x24E4FE0", VA = "0x1824E65E0", Slot = "8")]
	private void AEHNGGKHNCO(in NGMPDCMACDK LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x24E6A90", Offset = "0x24E5490", VA = "0x1824E6A90", Slot = "9")]
	private global::GJECEMGANGF<FNHIAGNKANJ> NPFOGPPKECL(in NGMPDCMACDK LAFPICAOEAI)
	{
		return default(global::GJECEMGANGF<FNHIAGNKANJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x24E6A60", Offset = "0x24E5460", VA = "0x1824E6A60", Slot = "10")]
	private bool NGDGLBHPMNE(in NGMPDCMACDK LAFPICAOEAI, global::GJECEMGANGF<FNHIAGNKANJ> CALNIJNFDFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x24E6710", Offset = "0x24E5110", VA = "0x1824E6710", Slot = "11")]
	private global::CMHNKNDBNII<FNHIAGNKANJ, TSyncFieldValue> CCEALPGMECI(global::GJECEMGANGF<KFOBGHKHPNF> OGGLMCNMCLJ, in NGMPDCMACDK LAFPICAOEAI, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) HMDGBADEDKH)
	{
		return default(global::CMHNKNDBNII<FNHIAGNKANJ, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x24E66E0", Offset = "0x24E50E0", VA = "0x1824E66E0", Slot = "12")]
	private void CAMANLKDNLN(in global::CMHNKNDBNII<FNHIAGNKANJ, TSyncFieldValue> HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x24E6780", Offset = "0x24E5180", VA = "0x1824E6780", Slot = "13")]
	private void DDBOOALGHKD(in global::CMHNKNDBNII<FNHIAGNKANJ, TSyncFieldValue> GJHDHFKKAMH, in TSyncFieldValue MNIAGKNOHEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LKPEBAMLCAJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::BKMMPBOFMNP<TRpcParam> where TActionReceiver : global::IBHDFOELJIL<TAction, Task<global::HJJOMCAHDKC<object, EKKNDELMKBB>>> where TActionDeps : global::OJBKFDLMNBG<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::GJECEMGANGF<FNHIAGNKANJ> LACIFHDPNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::FGFKJAGOBIA<MBMAJMCDNEK, global::HAMOIKFLFKD<FNHIAGNKANJ>> INICNDBADLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Dictionary<string, global::LJNMHFFAJKD<FNHIAGNKANJ, TSyncFieldValue>> HONBIECAHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private global::JJNNBIKOKIP<FNHIAGNKANJ, global::FGKGHNCEHLE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> NJIBNMANAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly TActionDeps NLJICMJMNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly List<(global::GJECEMGANGF<FNHIAGNKANJ> ActorId, global::GJECEMGANGF<LLBJOCLOEDC> RequestId, TAction Action)> LGOJEKLGJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int? NMMICJLGAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? FFKKELJJDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Queue<(global::GJECEMGANGF<FNHIAGNKANJ> ActorId, global::GJECEMGANGF<LLBJOCLOEDC> RequestId, TAction Action)> ECMMGGGLJGD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal global::GJECEMGANGF<FNHIAGNKANJ> JHACOJABLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6C1040", Offset = "0x6BFA40", VA = "0x1806C1040")]
		get
		{
			return default(global::GJECEMGANGF<FNHIAGNKANJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2563340", Offset = "0x2561D40", VA = "0x182563340")]
	protected LKPEBAMLCAJ(TActionDeps HNEGEPPAGIG, int? APIGBHKMPPO, int? JAIBHPKGDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x25618D0", Offset = "0x25602D0", VA = "0x1825618D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x25629A0", Offset = "0x25613A0", VA = "0x1825629A0")]
	public global::FGKGHNCEHLE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> OBGPIJLKDEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2561FC0", Offset = "0x25609C0", VA = "0x182561FC0")]
	internal global::GJECEMGANGF<OAPAPBLKGPM> GHHILMPIKNI(global::GJECEMGANGF<FNHIAGNKANJ> ANPGHBCNJID)
	{
		return default(global::GJECEMGANGF<OAPAPBLKGPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2561D30", Offset = "0x2560730", VA = "0x182561D30")]
	internal void FAKDAIKDHFD(global::GJECEMGANGF<MBMAJMCDNEK> LAFPICAOEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x25632F0", Offset = "0x2561CF0", VA = "0x1825632F0")]
	internal global::GJECEMGANGF<FNHIAGNKANJ> POGIKCLLAKG(global::GJECEMGANGF<MBMAJMCDNEK> LAFPICAOEAI)
	{
		return default(global::GJECEMGANGF<FNHIAGNKANJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x25622C0", Offset = "0x2560CC0", VA = "0x1825622C0")]
	internal void IAJBFKLPJIO(global::GJECEMGANGF<FNHIAGNKANJ> IMPCCNBKGDM, global::GJECEMGANGF<MBMAJMCDNEK> LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2562710", Offset = "0x2561110", VA = "0x182562710")]
	internal void MIHPHIOLCFJ(global::GJECEMGANGF<FNHIAGNKANJ> FCPMCFDJJFJ, global::GJECEMGANGF<MBMAJMCDNEK> LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2562350", Offset = "0x2560D50", VA = "0x182562350")]
	internal void JJCOKLMHANC(global::GJECEMGANGF<FNHIAGNKANJ> IMPCCNBKGDM, global::GJECEMGANGF<MBMAJMCDNEK> LAFPICAOEAI, in TRpcParam HMDGBADEDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2562570", Offset = "0x2560F70", VA = "0x182562570")]
	internal global::CMHNKNDBNII<FNHIAGNKANJ, TSyncFieldValue> LEHBNOGHKOI(global::GJECEMGANGF<FNHIAGNKANJ> MCAHLLGPNLI, global::GJECEMGANGF<KFOBGHKHPNF> GOLPOBGEKAG, string AJPNMLHDHNM, in TSyncFieldValue MNIAGKNOHEJ, Action JOIALDGLEAK, Action<object> NIGBBHLDAKJ, Func<bool> EGEBBGNMENN)
	{
		return default(global::CMHNKNDBNII<FNHIAGNKANJ, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2561C40", Offset = "0x2560640", VA = "0x182561C40")]
	internal void ECFBCFACNOG(global::GJECEMGANGF<FNHIAGNKANJ> MCAHLLGPNLI, string AJPNMLHDHNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2562780", Offset = "0x2561180", VA = "0x182562780")]
	internal void MPAGEENJGPB(global::LJNMHFFAJKD<FNHIAGNKANJ, TSyncFieldValue> GOLPOBGEKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2561F80", Offset = "0x2560980", VA = "0x182561F80")]
	internal void FENGNIGFECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2562E60", Offset = "0x2561860", VA = "0x182562E60")]
	internal void OOEIPFJIMKK(global::GJECEMGANGF<FNHIAGNKANJ> NHIJJLFOFCH, global::GJECEMGANGF<LLBJOCLOEDC> PLPPGBBMDBN, in TAction CKAPOBIDCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2562D90", Offset = "0x2561790", VA = "0x182562D90")]
	[CompilerGenerated]
	private global::FGKGHNCEHLE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> OBKIILJOIEB(global::GJECEMGANGF<FNHIAGNKANJ> ILAOEKIENMD)
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
