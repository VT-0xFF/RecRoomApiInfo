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
public interface ENKGGCLDLDO<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CCGOGDNOFAJ(in TAction PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction HFMHHHAJJNB(in TAction PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction MAEKKABOGPB(in TAction PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> DMLOFBMDIHF(in TAction PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KJNOPLAANPM(in TAction PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JNKBNCHHIBM(in TAction PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HPDGDJJHDKH(in TAction PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PAMMPJAPDPA(in TAction PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PFLBPIGBCOA(in TAction PBOHOIMMGFG);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HDCIICIDGGM<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::GFOJEHCBKMK<BNHJKKFKABK> OEBHMFJBOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMKOINPOIMB();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OAJINOHIBOB(global::GFOJEHCBKMK<FLFBOMKKKAC> CAEOMKLPFEI, in TAction PBOHOIMMGFG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LPEKEIDKFFK<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult OLGHBIFFALO(in TAction PBOHOIMMGFG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction[] FCAKEEJGGKG();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EFJNMNDIENG<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HKFCKLDANAI(TPartialSnapshot CKDAFOKPEMH);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot PJENBJALGFL(TPartialSnapshot[] APOJKDHJANJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class BNHJKKFKABK
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class FLFBOMKKKAC
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BDDFPCMILEM<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> where TActionReceiver : global::LPEKEIDKFFK<TAction, Task<global::IKEELLNFFOM<object, IHHGNGPIMCG>>> where TActionDeps : global::ENKGGCLDLDO<TAction> where TStaticNetSysDeps : global::HDCIICIDGGM<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private interface NGIBPBFAOAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MFBPPDIAJPI(in global::IKEELLNFFOM<object, IHHGNGPIMCG> BIDLMNEFHJM);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FNDGJANPHNN();

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::IKEELLNFFOM<object, IHHGNGPIMCG> DGLJCBAIOHG();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DODFCBFPNON(Exception PEAJABIJNDI);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class OPHPCKKMDDD : NGIBPBFAOAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::IKEELLNFFOM<object, IHHGNGPIMCG>> CPCNPEKAIAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::IKEELLNFFOM<object, IHHGNGPIMCG>> EMGOLCFDGMG;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x442D360", Offset = "0x442B960", VA = "0x18442D360")]
		private OPHPCKKMDDD(TaskCompletionSource<global::IKEELLNFFOM<object, IHHGNGPIMCG>> EJKKCMBAOLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2FED9C0", Offset = "0x2FEBFC0", VA = "0x182FED9C0")]
		public static OPHPCKKMDDD OJKIKDBCCPC(TaskCompletionSource<global::IKEELLNFFOM<object, IHHGNGPIMCG>> EJKKCMBAOLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x442D300", Offset = "0x442B900", VA = "0x18442D300")]
		public void MFBPPDIAJPI(in global::IKEELLNFFOM<object, IHHGNGPIMCG> BIDLMNEFHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x442D220", Offset = "0x442B820", VA = "0x18442D220", Slot = "5")]
		public void FNDGJANPHNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x442D110", Offset = "0x442B710", VA = "0x18442D110", Slot = "6")]
		public global::IKEELLNFFOM<object, IHHGNGPIMCG> DGLJCBAIOHG()
		{
			return default(global::IKEELLNFFOM<object, IHHGNGPIMCG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x442D1C0", Offset = "0x442B7C0", VA = "0x18442D1C0", Slot = "7")]
		public void DODFCBFPNON(Exception PEAJABIJNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x33486F0", Offset = "0x3346CF0", VA = "0x1833486F0", Slot = "4")]
		private void CEMIFMMMJDN(in global::IKEELLNFFOM<object, IHHGNGPIMCG> BIDLMNEFHJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class EPBNOECHCKJ : NGIBPBFAOAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::IKEELLNFFOM<object, IHHGNGPIMCG>> CPCNPEKAIAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::IKEELLNFFOM<object, IHHGNGPIMCG> MMHAMCIPPHH;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x33487E0", Offset = "0x3346DE0", VA = "0x1833487E0")]
		private EPBNOECHCKJ(TaskCompletionSource<global::IKEELLNFFOM<object, IHHGNGPIMCG>> EJKKCMBAOLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2FED9C0", Offset = "0x2FEBFC0", VA = "0x182FED9C0")]
		public static EPBNOECHCKJ OJKIKDBCCPC(TaskCompletionSource<global::IKEELLNFFOM<object, IHHGNGPIMCG>> EJKKCMBAOLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8B65C0", Offset = "0x8B4BC0", VA = "0x1808B65C0")]
		public void MFBPPDIAJPI(in global::IKEELLNFFOM<object, IHHGNGPIMCG> BIDLMNEFHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3348780", Offset = "0x3346D80", VA = "0x183348780", Slot = "5")]
		public void FNDGJANPHNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x776CA0", Offset = "0x7752A0", VA = "0x180776CA0", Slot = "6")]
		public global::IKEELLNFFOM<object, IHHGNGPIMCG> DGLJCBAIOHG()
		{
			return default(global::IKEELLNFFOM<object, IHHGNGPIMCG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3348720", Offset = "0x3346D20", VA = "0x183348720", Slot = "7")]
		public void DODFCBFPNON(Exception PEAJABIJNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x33486F0", Offset = "0x3346CF0", VA = "0x1833486F0", Slot = "4")]
		private void CEMIFMMMJDN(in global::IKEELLNFFOM<object, IHHGNGPIMCG> BIDLMNEFHJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class HPLHIJAAKCJ : NGIBPBFAOAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::IKEELLNFFOM<object, IHHGNGPIMCG>> EMGOLCFDGMG;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x498B5A0", Offset = "0x4989BA0", VA = "0x18498B5A0")]
		private HPLHIJAAKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA5E0", Offset = "0x3DF8BE0", VA = "0x183DFA5E0")]
		public static HPLHIJAAKCJ OJKIKDBCCPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x498B540", Offset = "0x4989B40", VA = "0x18498B540")]
		public void MFBPPDIAJPI(in global::IKEELLNFFOM<object, IHHGNGPIMCG> BIDLMNEFHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		public void FNDGJANPHNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x498B4E0", Offset = "0x4989AE0", VA = "0x18498B4E0", Slot = "6")]
		public global::IKEELLNFFOM<object, IHHGNGPIMCG> DGLJCBAIOHG()
		{
			return default(global::IKEELLNFFOM<object, IHHGNGPIMCG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "7")]
		public void DODFCBFPNON(Exception PEAJABIJNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x33486F0", Offset = "0x3346CF0", VA = "0x1833486F0", Slot = "4")]
		private void CEMIFMMMJDN(in global::IKEELLNFFOM<object, IHHGNGPIMCG> BIDLMNEFHJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class FKOHPMNBEAH : NGIBPBFAOAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::IKEELLNFFOM<object, IHHGNGPIMCG> MMHAMCIPPHH;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
		private FKOHPMNBEAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA5E0", Offset = "0x3DF8BE0", VA = "0x183DFA5E0")]
		public static FKOHPMNBEAH OJKIKDBCCPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7E5CA0", Offset = "0x7E42A0", VA = "0x1807E5CA0")]
		public void MFBPPDIAJPI(in global::IKEELLNFFOM<object, IHHGNGPIMCG> BIDLMNEFHJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "5")]
		public void FNDGJANPHNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x792CB0", Offset = "0x7912B0", VA = "0x180792CB0", Slot = "6")]
		public global::IKEELLNFFOM<object, IHHGNGPIMCG> DGLJCBAIOHG()
		{
			return default(global::IKEELLNFFOM<object, IHHGNGPIMCG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "7")]
		public void DODFCBFPNON(Exception PEAJABIJNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x33486F0", Offset = "0x3346CF0", VA = "0x1833486F0", Slot = "4")]
		private void CEMIFMMMJDN(in global::IKEELLNFFOM<object, IHHGNGPIMCG> BIDLMNEFHJM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct ICHPBAACHAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::IKEELLNFFOM<object, IHHGNGPIMCG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::BDDFPCMILEM<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::GFOJEHCBKMK<BNHJKKFKABK> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::GFOJEHCBKMK<FLFBOMKKKAC> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::IKEELLNFFOM<object, IHHGNGPIMCG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3555A80", Offset = "0x3554080", VA = "0x183555A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3555D30", Offset = "0x3554330", VA = "0x183555D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct NGOLDMNANAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::IKEELLNFFOM<object, IHHGNGPIMCG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::BDDFPCMILEM<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::GFOJEHCBKMK<BNHJKKFKABK> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::GFOJEHCBKMK<FLFBOMKKKAC> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NGIBPBFAOAB <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x394B670", Offset = "0x3949C70", VA = "0x18394B670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x394BEC0", Offset = "0x394A4C0", VA = "0x18394BEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NMJFEGKHMIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::BDDFPCMILEM<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public NGIBPBFAOAB completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private NGIBPBFAOAB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::IKEELLNFFOM<object, IHHGNGPIMCG>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x395A200", Offset = "0x3958800", VA = "0x18395A200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85A5F0", Offset = "0x858BF0", VA = "0x18085A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver KLBCLLAACFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps HDINDNDKEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps PEGGPILLGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int JLDFIKKJNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int CMHKKFDAPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::GFOJEHCBKMK<FLFBOMKKKAC>, TaskCompletionSource<global::IKEELLNFFOM<object, IHHGNGPIMCG>>> ENLCKOLEDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private global::BDLOPDIOLAE<FLFBOMKKKAC> HFIJNPBBNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int FIOECCNGGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task NEOLMMBIEIN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AANAOPDLJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77C680", Offset = "0x77AC80", VA = "0x18077C680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x70C3B0", Offset = "0x70A9B0", VA = "0x18070C3B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4BC8750", Offset = "0x4BC6D50", VA = "0x184BC8750")]
	protected BDDFPCMILEM(TActionDeps BOOFAKJMFNF, TStaticNetSysDeps LBFLOAKHLIO, int JLELKFPKCCO, int ECKHDMNIIIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4BC8340", Offset = "0x4BC6940", VA = "0x184BC8340")]
	public static global::BDDFPCMILEM<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> OJKIKDBCCPC(TActionDeps BOOFAKJMFNF, TStaticNetSysDeps LBFLOAKHLIO, [Optional] int? JLELKFPKCCO, [Optional] int? ECKHDMNIIIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4BC8030", Offset = "0x4BC6630", VA = "0x184BC8030")]
	public Task<global::IKEELLNFFOM<object, IHHGNGPIMCG>> OAJINOHIBOB(in TAction PBOHOIMMGFG, bool EEEGNGIMIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4BC8020", Offset = "0x4BC6620", VA = "0x184BC8020")]
	public void LCPFJNMBJAF(in TActionReceiver LCFDFEFIJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4BC8480", Offset = "0x4BC6A80", VA = "0x184BC8480")]
	[AsyncStateMachine(typeof(global::BDDFPCMILEM<, , , >.ICHPBAACHAG))]
	public Task<global::IKEELLNFFOM<object, IHHGNGPIMCG>> OLGHBIFFALO(global::GFOJEHCBKMK<BNHJKKFKABK> BDKOHAFBNID, global::GFOJEHCBKMK<FLFBOMKKKAC> CAEOMKLPFEI, TAction PBOHOIMMGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4BC85E0", Offset = "0x4BC6BE0", VA = "0x184BC85E0")]
	[AsyncStateMachine(typeof(global::BDDFPCMILEM<, , , >.NGOLDMNANAA))]
	private Task<global::IKEELLNFFOM<object, IHHGNGPIMCG>> PGKJCDLMHOB(global::GFOJEHCBKMK<BNHJKKFKABK> BDKOHAFBNID, global::GFOJEHCBKMK<FLFBOMKKKAC> CAEOMKLPFEI, TAction PBOHOIMMGFG, Task DAMHJCBBMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4BC7CE0", Offset = "0x4BC62E0", VA = "0x184BC7CE0")]
	[AsyncStateMachine(typeof(global::BDDFPCMILEM<, , , >.NMJFEGKHMIC))]
	private Task DDFLAODPCJO(TAction PBOHOIMMGFG, NGIBPBFAOAB OAHAHCPCGDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4BC7E20", Offset = "0x4BC6420", VA = "0x184BC7E20")]
	private void JGOFBJJFIIC(TAction PBOHOIMMGFG, bool FKIEKLGEFKF, bool GHFHFHKEGIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NMMEFHGFNHB<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::EFJNMNDIENG<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private TPartialSnapshot[] DOHAJEPOPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int BOKGJLDFAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private TDeps CLMOOCMNIOA;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x395B900", Offset = "0x3959F00", VA = "0x18395B900")]
	internal NMMEFHGFNHB(TPartialSnapshot[] AGGOCLONLCG, int GKEJHHGNEPP, TDeps LCOMIHDGHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x395B660", Offset = "0x3959C60", VA = "0x18395B660")]
	public global::IICAPBLJHHK<TFullSnapshot> IEJKCLFMBBJ(TPartialSnapshot CKDAFOKPEMH)
	{
		return default(global::IICAPBLJHHK<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x395B2B0", Offset = "0x39598B0", VA = "0x18395B2B0")]
	public bool AINKPBJIHEO(TPartialSnapshot CKDAFOKPEMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x395B830", Offset = "0x3959E30", VA = "0x18395B830")]
	public static global::NMMEFHGFNHB<TPartialSnapshot, TFullSnapshot, TDeps> OJKIKDBCCPC(TDeps LCOMIHDGHCD)
	{
		return default(global::NMMEFHGFNHB<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class FJCLIMIGJDB : IHHGNGPIMCG
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x60A4C00", Offset = "0x60A3200", VA = "0x1860A4C00", Slot = "5")]
	public override string CNNOKHADNMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1D1B510", Offset = "0x1D19B10", VA = "0x181D1B510")]
	public FJCLIMIGJDB()
	{
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
