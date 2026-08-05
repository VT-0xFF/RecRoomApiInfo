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
public interface PHMKONECFLF<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CJOKEPOKAHN(in TAction MOOMHHEHKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction BPELAOJFEDC(in TAction MOOMHHEHKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction JCAIADNKPDI(in TAction MOOMHHEHKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> AIFNOLKEINK(in TAction MOOMHHEHKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HIPIFNHONJF(in TAction MOOMHHEHKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NOEGOJHLIHG(in TAction MOOMHHEHKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BBJCPGHLKGC(in TAction MOOMHHEHKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool IJNIJJHLEMD(in TAction MOOMHHEHKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IAAPOMOLEIP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::CBOPPAHLFPF<PMFPIGBKCDH> KPAFFGPAPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBOFCKAAMON();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKNLOLJAKIE(in global::CBOPPAHLFPF<BCKNNHEHKEO> GOAJODAPPPB, in TAction MOOMHHEHKEJ);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct PMFPIGBKCDH
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct BCKNNHEHKEO
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class POKNFMCPGCI<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> : global::AIMDOPBJJEG<TAction, Task<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>>, TActionReceiver> where TActionReceiver : global::CMIMIFNKEII<TAction, Task<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>>> where TActionDeps : global::PHMKONECFLF<TAction> where TNetSysStaticDeps : global::IAAPOMOLEIP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface OKLNMCIGEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FIHAOOLDLFN(in global::BKNEKIBPGAJ<object, DPIMBLNCLCM> BLBGKFGAFHM);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BODHMNDGBHA();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::BKNEKIBPGAJ<object, DPIMBLNCLCM> OPPGPFMPPCJ();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BEGJMJPHAMI(Exception EJKLNJEENEI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class ABFBNAFFNAG : OKLNMCIGEGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> CELLELBMAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> MMNPDDBPHPI;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D410", Offset = "0x3F5C810", VA = "0x183F5D410")]
		private ABFBNAFFNAG(TaskCompletionSource<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> PEKKBNNGEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2FAD8F0", Offset = "0x2FACCF0", VA = "0x182FAD8F0")]
		public static ABFBNAFFNAG HFCEOLCNMNF(TaskCompletionSource<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> PEKKBNNGEKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D310", Offset = "0x3F5C710", VA = "0x183F5D310")]
		public void FIHAOOLDLFN(in global::BKNEKIBPGAJ<object, DPIMBLNCLCM> BLBGKFGAFHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D250", Offset = "0x3F5C650", VA = "0x183F5D250", Slot = "5")]
		public void BODHMNDGBHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D370", Offset = "0x3F5C770", VA = "0x183F5D370", Slot = "6")]
		public global::BKNEKIBPGAJ<object, DPIMBLNCLCM> OPPGPFMPPCJ()
		{
			return default(global::BKNEKIBPGAJ<object, DPIMBLNCLCM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D1F0", Offset = "0x3F5C5F0", VA = "0x183F5D1F0", Slot = "7")]
		public void BEGJMJPHAMI(Exception EJKLNJEENEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x34B4F60", Offset = "0x34B4360", VA = "0x1834B4F60", Slot = "4")]
		private void EHNGEEMCCBM(in global::BKNEKIBPGAJ<object, DPIMBLNCLCM> BLBGKFGAFHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class CPMJKGMEDMN : OKLNMCIGEGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> CELLELBMAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::BKNEKIBPGAJ<object, DPIMBLNCLCM> PJFDOJMDKGP;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1F3BAC0", Offset = "0x1F3AEC0", VA = "0x181F3BAC0")]
		private CPMJKGMEDMN(TaskCompletionSource<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> PEKKBNNGEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2FAD8F0", Offset = "0x2FACCF0", VA = "0x182FAD8F0")]
		public static CPMJKGMEDMN HFCEOLCNMNF(TaskCompletionSource<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> PEKKBNNGEKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2EABEB0", Offset = "0x2EAB2B0", VA = "0x182EABEB0")]
		public void FIHAOOLDLFN(in global::BKNEKIBPGAJ<object, DPIMBLNCLCM> BLBGKFGAFHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3F6AF00", Offset = "0x3F6A300", VA = "0x183F6AF00", Slot = "5")]
		public void BODHMNDGBHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x553000", Offset = "0x552400", VA = "0x180553000", Slot = "6")]
		public global::BKNEKIBPGAJ<object, DPIMBLNCLCM> OPPGPFMPPCJ()
		{
			return default(global::BKNEKIBPGAJ<object, DPIMBLNCLCM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3F6AEA0", Offset = "0x3F6A2A0", VA = "0x183F6AEA0", Slot = "7")]
		public void BEGJMJPHAMI(Exception EJKLNJEENEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x34B4F60", Offset = "0x34B4360", VA = "0x1834B4F60", Slot = "4")]
		private void EHNGEEMCCBM(in global::BKNEKIBPGAJ<object, DPIMBLNCLCM> BLBGKFGAFHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class EKDHBNFPDNP : OKLNMCIGEGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> MMNPDDBPHPI;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3F6B0E0", Offset = "0x3F6A4E0", VA = "0x183F6B0E0")]
		private EKDHBNFPDNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3F6AFC0", Offset = "0x3F6A3C0", VA = "0x183F6AFC0")]
		public static EKDHBNFPDNP HFCEOLCNMNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3F6AF60", Offset = "0x3F6A360", VA = "0x183F6AF60")]
		public void FIHAOOLDLFN(in global::BKNEKIBPGAJ<object, DPIMBLNCLCM> BLBGKFGAFHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
		public void BODHMNDGBHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3F6B080", Offset = "0x3F6A480", VA = "0x183F6B080", Slot = "6")]
		public global::BKNEKIBPGAJ<object, DPIMBLNCLCM> OPPGPFMPPCJ()
		{
			return default(global::BKNEKIBPGAJ<object, DPIMBLNCLCM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "7")]
		public void BEGJMJPHAMI(Exception EJKLNJEENEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x34B4F60", Offset = "0x34B4360", VA = "0x1834B4F60", Slot = "4")]
		private void EHNGEEMCCBM(in global::BKNEKIBPGAJ<object, DPIMBLNCLCM> BLBGKFGAFHM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class PBNMMGAMDJH : OKLNMCIGEGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::BKNEKIBPGAJ<object, DPIMBLNCLCM> PJFDOJMDKGP;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		private PBNMMGAMDJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F6AFC0", Offset = "0x3F6A3C0", VA = "0x183F6AFC0")]
		public static PBNMMGAMDJH HFCEOLCNMNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xF522F0", Offset = "0xF516F0", VA = "0x180F522F0")]
		public void FIHAOOLDLFN(in global::BKNEKIBPGAJ<object, DPIMBLNCLCM> BLBGKFGAFHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
		public void BODHMNDGBHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8864E0", Offset = "0x8858E0", VA = "0x1808864E0", Slot = "6")]
		public global::BKNEKIBPGAJ<object, DPIMBLNCLCM> OPPGPFMPPCJ()
		{
			return default(global::BKNEKIBPGAJ<object, DPIMBLNCLCM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "7")]
		public void BEGJMJPHAMI(Exception EJKLNJEENEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x34B4F60", Offset = "0x34B4360", VA = "0x1834B4F60", Slot = "4")]
		private void EHNGEEMCCBM(in global::BKNEKIBPGAJ<object, DPIMBLNCLCM> BLBGKFGAFHM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NNKIPFMANPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::POKNFMCPGCI<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::CBOPPAHLFPF<PMFPIGBKCDH> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::CBOPPAHLFPF<BCKNNHEHKEO> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F170", Offset = "0x3F6E570", VA = "0x183F6F170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F3A0", Offset = "0x3F6E7A0", VA = "0x183F6F3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HBAIJONNMDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::POKNFMCPGCI<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::CBOPPAHLFPF<PMFPIGBKCDH> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::CBOPPAHLFPF<BCKNNHEHKEO> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OKLNMCIGEGG <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3F6B5F0", Offset = "0x3F6A9F0", VA = "0x183F6B5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3F6BD80", Offset = "0x3F6B180", VA = "0x183F6BD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct JJCIKOHNNBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::POKNFMCPGCI<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public OKLNMCIGEGG completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private OKLNMCIGEGG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3F6BDD0", Offset = "0x3F6B1D0", VA = "0x183F6BDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x714190", Offset = "0x713590", VA = "0x180714190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver AGAGHBIDCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps IKHADMLPJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TNetSysStaticDeps LFGOJBLBCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int EDKBICCNCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int JBGPJGGGMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::CBOPPAHLFPF<BCKNNHEHKEO>, TaskCompletionSource<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>>> KCMKDMIFIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::ECFHLCGFNFN<BCKNNHEHKEO> GNAGFFOOAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool HEALABOHMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int GNMPPDOBDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task HKFNAJEEEOM;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3F742F0", Offset = "0x3F736F0", VA = "0x183F742F0")]
	protected POKNFMCPGCI(TActionDeps BLOIFCFPPLO, TNetSysStaticDeps KCNCCGGIOMO, int DANABLOAGJH, int PBNHNCNMPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3F73EF0", Offset = "0x3F732F0", VA = "0x183F73EF0")]
	public static global::POKNFMCPGCI<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> HFCEOLCNMNF(TActionDeps BLOIFCFPPLO, TNetSysStaticDeps KCNCCGGIOMO, [Optional] int? DANABLOAGJH, [Optional] int? PBNHNCNMPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3F73940", Offset = "0x3F72D40", VA = "0x183F73940")]
	public Task<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> AKNLOLJAKIE(in TAction MOOMHHEHKEJ, bool GFKGIPAPDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3F73D90", Offset = "0x3F73190", VA = "0x183F73D90")]
	public void BNLFJIGMNAN(in TActionReceiver DDPMLLHENHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3F73DA0", Offset = "0x3F731A0", VA = "0x183F73DA0")]
	[AsyncStateMachine(typeof(global::POKNFMCPGCI<, , , >.NNKIPFMANPM))]
	public Task<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> GMCPDMFCNFA(global::CBOPPAHLFPF<PMFPIGBKCDH> GCNBPOLLEGI, global::CBOPPAHLFPF<BCKNNHEHKEO> GOAJODAPPPB, TAction MOOMHHEHKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3F73C40", Offset = "0x3F73040", VA = "0x183F73C40")]
	[AsyncStateMachine(typeof(global::POKNFMCPGCI<, , , >.HBAIJONNMDB))]
	private Task<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> BJNNOFJMDDK(global::CBOPPAHLFPF<PMFPIGBKCDH> GCNBPOLLEGI, global::CBOPPAHLFPF<BCKNNHEHKEO> GOAJODAPPPB, TAction MOOMHHEHKEJ, Task CODENJLFDAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3F741A0", Offset = "0x3F735A0", VA = "0x183F741A0")]
	[AsyncStateMachine(typeof(global::POKNFMCPGCI<, , , >.JJCIKOHNNBC))]
	private Task PIGHOPLCMLD(TAction MOOMHHEHKEJ, OKLNMCIGEGG DEMMDAIEAJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3F74020", Offset = "0x3F73420", VA = "0x183F74020")]
	private void LNBLBMJHJFC(TAction MOOMHHEHKEJ, bool NPHOIALMFHG, bool LFLPOCDFFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1EF8070", Offset = "0x1EF7470", VA = "0x181EF8070", Slot = "4")]
	private Task<global::BKNEKIBPGAJ<object, DPIMBLNCLCM>> CNNENMFGAKF(in TAction MOOMHHEHKEJ, bool GFKGIPAPDHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class HGLCIAEBINH : DPIMBLNCLCM
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xDA1340", Offset = "0xDA0740", VA = "0x180DA1340", Slot = "4")]
	public override string CEHHFNLEJNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xDA1370", Offset = "0xDA0770", VA = "0x180DA1370")]
	private HGLCIAEBINH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x21D4A90", Offset = "0x21D3E90", VA = "0x1821D4A90")]
	public static global::BKNEKIBPGAJ<TOk, DPIMBLNCLCM> HFCEOLCNMNF<TOk>()
	{
		return default(global::BKNEKIBPGAJ<TOk, DPIMBLNCLCM>);
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
