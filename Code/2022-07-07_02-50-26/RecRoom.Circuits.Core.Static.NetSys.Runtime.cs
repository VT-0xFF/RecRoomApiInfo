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
public interface PJEOHFHFCGK<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HCHLHNCHJHK(in TAction GIFFKCDDBCP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction CFFFGDPMKKD(in TAction GIFFKCDDBCP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction PGOIPEHAOEB(in TAction GIFFKCDDBCP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> MFMIJHEFBDF(in TAction GIFFKCDDBCP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NJODBLKICGM(in TAction GIFFKCDDBCP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KDMBBGEFDKG(in TAction GIFFKCDDBCP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LJMNJCPPDBC(in TAction GIFFKCDDBCP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool AIKDDJJCONI(in TAction GIFFKCDDBCP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HFKMOHBCDHM<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::PJGCMECOCNN<JNPOCKEGPNP> JLOAIMJNEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMHKNKDHCOM();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FPAMKMHAFJP(in global::PJGCMECOCNN<BPEOCGJKGME> CIIOFMJICNC, in TAction GIFFKCDDBCP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class JNPOCKEGPNP
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class BPEOCGJKGME
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IAKMEFCMMAD<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> : global::HLGNLPNFECK<TAction, Task<global::MPJGMBLJCNG<object, IMDMFPNHAJP>>, TActionReceiver> where TActionReceiver : global::GMLGDKGGCHE<TAction, Task<global::MPJGMBLJCNG<object, IMDMFPNHAJP>>> where TActionDeps : global::PJEOHFHFCGK<TAction> where TStaticNetSysDeps : global::HFKMOHBCDHM<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface MLEALFFBIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CJABODFKIFN(in global::MPJGMBLJCNG<object, IMDMFPNHAJP> KCKMKGJDDEH);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JLBNBFPFLLA();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::MPJGMBLJCNG<object, IMDMFPNHAJP> FKEIIPJEIFI();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LOHICFNNLJF(Exception AOKIHNBMBND);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class FLHAIJCLNGD : MLEALFFBIAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> CJGBAOKHPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> ONAJFHJCLGI;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x39EDEE0", Offset = "0x39ED0E0", VA = "0x1839EDEE0")]
		private FLHAIJCLNGD(TaskCompletionSource<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> PDDGIJJEEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x39EDE10", Offset = "0x39ED010", VA = "0x1839EDE10")]
		public static FLHAIJCLNGD NPLCOEOMBMO(TaskCompletionSource<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> PDDGIJJEEEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x39EDBC0", Offset = "0x39ECDC0", VA = "0x1839EDBC0")]
		public void CJABODFKIFN(in global::MPJGMBLJCNG<object, IMDMFPNHAJP> KCKMKGJDDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x39EDCF0", Offset = "0x39ECEF0", VA = "0x1839EDCF0", Slot = "5")]
		public void JLBNBFPFLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x39EDC50", Offset = "0x39ECE50", VA = "0x1839EDC50", Slot = "6")]
		public global::MPJGMBLJCNG<object, IMDMFPNHAJP> FKEIIPJEIFI()
		{
			return default(global::MPJGMBLJCNG<object, IMDMFPNHAJP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x39EDDB0", Offset = "0x39ECFB0", VA = "0x1839EDDB0", Slot = "7")]
		public void LOHICFNNLJF(Exception AOKIHNBMBND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x39EDC20", Offset = "0x39ECE20", VA = "0x1839EDC20", Slot = "4")]
		private void DNMOBNOFMGM(in global::MPJGMBLJCNG<object, IMDMFPNHAJP> KCKMKGJDDEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class KDHLBPOIBAK : MLEALFFBIAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> CJGBAOKHPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::MPJGMBLJCNG<object, IMDMFPNHAJP> HDJGPJANIOO;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1E5DB50", Offset = "0x1E5CD50", VA = "0x181E5DB50")]
		private KDHLBPOIBAK(TaskCompletionSource<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> PDDGIJJEEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x39EDE10", Offset = "0x39ED010", VA = "0x1839EDE10")]
		public static KDHLBPOIBAK NPLCOEOMBMO(TaskCompletionSource<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> PDDGIJJEEEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B0CEF0", Offset = "0x2B0C0F0", VA = "0x182B0CEF0")]
		public void CJABODFKIFN(in global::MPJGMBLJCNG<object, IMDMFPNHAJP> KCKMKGJDDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x39FA220", Offset = "0x39F9420", VA = "0x1839FA220", Slot = "5")]
		public void JLBNBFPFLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x58B000", Offset = "0x58A200", VA = "0x18058B000", Slot = "6")]
		public global::MPJGMBLJCNG<object, IMDMFPNHAJP> FKEIIPJEIFI()
		{
			return default(global::MPJGMBLJCNG<object, IMDMFPNHAJP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x39FA280", Offset = "0x39F9480", VA = "0x1839FA280", Slot = "7")]
		public void LOHICFNNLJF(Exception AOKIHNBMBND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x39EDC20", Offset = "0x39ECE20", VA = "0x1839EDC20", Slot = "4")]
		private void DNMOBNOFMGM(in global::MPJGMBLJCNG<object, IMDMFPNHAJP> KCKMKGJDDEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class LKLFJJDBPMA : MLEALFFBIAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> ONAJFHJCLGI;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x39FAA40", Offset = "0x39F9C40", VA = "0x1839FAA40")]
		private LKLFJJDBPMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x39FA980", Offset = "0x39F9B80", VA = "0x1839FA980")]
		public static LKLFJJDBPMA NPLCOEOMBMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x39FA8C0", Offset = "0x39F9AC0", VA = "0x1839FA8C0")]
		public void CJABODFKIFN(in global::MPJGMBLJCNG<object, IMDMFPNHAJP> KCKMKGJDDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
		public void JLBNBFPFLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x39FA920", Offset = "0x39F9B20", VA = "0x1839FA920", Slot = "6")]
		public global::MPJGMBLJCNG<object, IMDMFPNHAJP> FKEIIPJEIFI()
		{
			return default(global::MPJGMBLJCNG<object, IMDMFPNHAJP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "7")]
		public void LOHICFNNLJF(Exception AOKIHNBMBND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x39EDC20", Offset = "0x39ECE20", VA = "0x1839EDC20", Slot = "4")]
		private void DNMOBNOFMGM(in global::MPJGMBLJCNG<object, IMDMFPNHAJP> KCKMKGJDDEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class NMPHIOBCJNL : MLEALFFBIAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::MPJGMBLJCNG<object, IMDMFPNHAJP> HDJGPJANIOO;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		private NMPHIOBCJNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x39FA980", Offset = "0x39F9B80", VA = "0x1839FA980")]
		public static NMPHIOBCJNL NPLCOEOMBMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1417950", Offset = "0x1416B50", VA = "0x181417950")]
		public void CJABODFKIFN(in global::MPJGMBLJCNG<object, IMDMFPNHAJP> KCKMKGJDDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
		public void JLBNBFPFLLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x89B740", Offset = "0x89A940", VA = "0x18089B740", Slot = "6")]
		public global::MPJGMBLJCNG<object, IMDMFPNHAJP> FKEIIPJEIFI()
		{
			return default(global::MPJGMBLJCNG<object, IMDMFPNHAJP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "7")]
		public void LOHICFNNLJF(Exception AOKIHNBMBND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x39EDC20", Offset = "0x39ECE20", VA = "0x1839EDC20", Slot = "4")]
		private void DNMOBNOFMGM(in global::MPJGMBLJCNG<object, IMDMFPNHAJP> KCKMKGJDDEH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct PHLOKKIDFNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::IAKMEFCMMAD<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::PJGCMECOCNN<JNPOCKEGPNP> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::PJGCMECOCNN<BPEOCGJKGME> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x39FAD00", Offset = "0x39F9F00", VA = "0x1839FAD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x39FAF30", Offset = "0x39FA130", VA = "0x1839FAF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct IICGEHGAPJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::IAKMEFCMMAD<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::PJGCMECOCNN<JNPOCKEGPNP> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::PJGCMECOCNN<BPEOCGJKGME> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private MLEALFFBIAK <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x39F99C0", Offset = "0x39F8BC0", VA = "0x1839F99C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x39FA150", Offset = "0x39F9350", VA = "0x1839FA150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct GPHCNMPALNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::IAKMEFCMMAD<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public MLEALFFBIAK completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private MLEALFFBIAK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x39EDF90", Offset = "0x39ED190", VA = "0x1839EDF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFE0", Offset = "0x7EB1E0", VA = "0x1807EBFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver AAAADMNGEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps DACIJNGCCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps CGLCHNEBNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int DPOKKCPMFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int KCENEIMKODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::PJGCMECOCNN<BPEOCGJKGME>, TaskCompletionSource<global::MPJGMBLJCNG<object, IMDMFPNHAJP>>> FBDMPACMFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::KKLPDCNLPFM<BPEOCGJKGME> LFLFBEONNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool MGGIPFIDAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int OBJHHHPDFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task GEAMNACJCFG;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x39EF2E0", Offset = "0x39EE4E0", VA = "0x1839EF2E0")]
	protected IAKMEFCMMAD(TActionDeps GNNGIOOCPFB, TStaticNetSysDeps HCEDJHFOHIC, int NOMOAJKEDKL, int HKGEDOAHALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x39EF1B0", Offset = "0x39EE3B0", VA = "0x1839EF1B0")]
	public static global::IAKMEFCMMAD<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> NPLCOEOMBMO(TActionDeps GNNGIOOCPFB, TStaticNetSysDeps HCEDJHFOHIC, [Optional] int? NOMOAJKEDKL, [Optional] int? HKGEDOAHALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x39EEBE0", Offset = "0x39EDDE0", VA = "0x1839EEBE0")]
	public Task<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> FPAMKMHAFJP(in TAction GIFFKCDDBCP, bool CBKHJHPHMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x39EEBD0", Offset = "0x39EDDD0", VA = "0x1839EEBD0")]
	public void FFKABDCCFMJ(in TActionReceiver ACDICPLCGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x39EEA80", Offset = "0x39EDC80", VA = "0x1839EEA80")]
	[AsyncStateMachine(typeof(global::IAKMEFCMMAD<, , , >.PHLOKKIDFNF))]
	public Task<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> BEBHELJAAIM(global::PJGCMECOCNN<JNPOCKEGPNP> DDELCAECMNG, global::PJGCMECOCNN<BPEOCGJKGME> CIIOFMJICNC, TAction GIFFKCDDBCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x39EE930", Offset = "0x39EDB30", VA = "0x1839EE930")]
	[AsyncStateMachine(typeof(global::IAKMEFCMMAD<, , , >.IICGEHGAPJK))]
	private Task<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> ABHFAFGMKOO(global::PJGCMECOCNN<JNPOCKEGPNP> DDELCAECMNG, global::PJGCMECOCNN<BPEOCGJKGME> CIIOFMJICNC, TAction GIFFKCDDBCP, Task OHOBCCPPOEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x39EEEE0", Offset = "0x39EE0E0", VA = "0x1839EEEE0")]
	[AsyncStateMachine(typeof(global::IAKMEFCMMAD<, , , >.GPHCNMPALNG))]
	private Task JBJOJFJGDNM(TAction GIFFKCDDBCP, MLEALFFBIAK BMPGKCDLJHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x39EF030", Offset = "0x39EE230", VA = "0x1839EF030")]
	private void LHMPLJOLKCI(TAction GIFFKCDDBCP, bool CBIHKJGEMNM, bool BCDPDMHCNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2D79560", Offset = "0x2D78760", VA = "0x182D79560", Slot = "4")]
	private Task<global::MPJGMBLJCNG<object, IMDMFPNHAJP>> FFJMFBODPKD(in TAction GIFFKCDDBCP, bool CBKHJHPHMNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class JOONDBFAMJL : IMDMFPNHAJP
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xDDBA70", Offset = "0xDDAC70", VA = "0x180DDBA70", Slot = "4")]
	public override string KFBDDGNNIGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xDDBAA0", Offset = "0xDDACA0", VA = "0x180DDBAA0")]
	private JOONDBFAMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x22E51D0", Offset = "0x22E43D0", VA = "0x1822E51D0")]
	public static global::MPJGMBLJCNG<TOk, IMDMFPNHAJP> NPLCOEOMBMO<TOk>()
	{
		return default(global::MPJGMBLJCNG<TOk, IMDMFPNHAJP>);
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
