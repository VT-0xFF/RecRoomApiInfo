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
public struct NHMIIPPBAIH<TPartialAction, TFullAction, TDeps> where TDeps : DIBDOAHCJLI.PNBPICICCMP<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] MFDGJNNAGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int NBAAIKEDGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps KJMCLGOJKLB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4494670", Offset = "0x4493270", VA = "0x184494670")]
	internal NHMIIPPBAIH(TPartialAction[] HHEKHMDMLEL, int DPIBCDKHDMA, TDeps CFCALMONEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4494550", Offset = "0x4493150", VA = "0x184494550")]
	public static NHMIIPPBAIH<TPartialAction, TFullAction, TDeps> PPOPBMPFEOP(TDeps CFCALMONEJL)
	{
		return default(NHMIIPPBAIH<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DIBDOAHCJLI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface PNBPICICCMP<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GKJEPICCCEP([In] TPartialAction BDBALIFAMNH);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction PLELAFPPJIP(TPartialAction[] DFOHJLIAOCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x292EB50", Offset = "0x292D750", VA = "0x18292EB50")]
	public static IJOGPJMNLNP<TFullAction> NDCBGKMAEHM<TFullAction, TPartialAction, TDeps>(this NHMIIPPBAIH<TPartialAction, TFullAction, TDeps> HNFMOHFACKF, TPartialAction BDBALIFAMNH) where TDeps : PNBPICICCMP<TPartialAction, TFullAction>
	{
		return default(IJOGPJMNLNP<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BBFAHDBGJDO<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : GMNPOAJBCBK.ODEBCOFGGBP<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] MOMPNGNKKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int FALMBBMONIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps KJMCLGOJKLB;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4494670", Offset = "0x4493270", VA = "0x184494670")]
	internal BBFAHDBGJDO(TPartialSnapshot[] HKNEKMLOHOE, int HAKMOJLLAIP, TDeps CFCALMONEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4494550", Offset = "0x4493150", VA = "0x184494550")]
	public static BBFAHDBGJDO<TPartialSnapshot, TFullSnapshot, TDeps> PPOPBMPFEOP(TDeps CFCALMONEJL)
	{
		return default(BBFAHDBGJDO<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GMNPOAJBCBK
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface ODEBCOFGGBP<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ALFFDBGNLIL([In] TPartialSnapshot CDFHKOPLKOP);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot HGCLNJHPCGM(TPartialSnapshot[] IMFNIEPDAOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B14880", Offset = "0x2B13480", VA = "0x182B14880")]
	public static IJOGPJMNLNP<TFullSnapshot> NDCBGKMAEHM<TFullSnapshot, TPartialSnapshot, TDeps>(this BBFAHDBGJDO<TPartialSnapshot, TFullSnapshot, TDeps> HNFMOHFACKF, TPartialSnapshot CDFHKOPLKOP) where TDeps : ODEBCOFGGBP<TPartialSnapshot, TFullSnapshot>
	{
		return default(IJOGPJMNLNP<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2B14740", Offset = "0x2B13340", VA = "0x182B14740")]
	public static bool LBGNLECKKCE<TPartialSnapshot, TFullSnapshot, TDeps>(this BBFAHDBGJDO<TPartialSnapshot, TFullSnapshot, TDeps> HNFMOHFACKF, TPartialSnapshot CDFHKOPLKOP) where TDeps : ODEBCOFGGBP<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class DGIEFLDDIHL : GCLPBJOMDAE
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5FD0", Offset = "0x1FA4BD0", VA = "0x181FA5FD0", Slot = "7")]
	public override string BKHNKMBHNFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6000", Offset = "0x1FA4C00", VA = "0x181FA6000")]
	public DGIEFLDDIHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GAODIOBGCGN<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : FJHOKOIKACF.DGGHPGHNPGN<TAction, TNetSys> where TReceiverDeps : FJHOKOIKACF.ECBIIFJABHC<TAction, TReceiver> where TRootDeps : FJHOKOIKACF.JFJNHJBCDAJ<TMRequest, TAction, TRoot> where TDeps : FJHOKOIKACF.KJFLCEDCFCN<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface DMPHIKNMJMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PCJBHCGAJBL([In] GFFELLBKJIA<object, DCMKOJFPDPC> JFBAIGMLPKE);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BMEJKEFCICB();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GFFELLBKJIA<object, DCMKOJFPDPC> GLJOPHOEJBM();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void COBKNCLOMIE(Exception JNLFEIJKPEF);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class CGABJMCFCDC : DMPHIKNMJMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<GFFELLBKJIA<object, DCMKOJFPDPC>> NGNPBACCKBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<GFFELLBKJIA<object, NKGCJHELBDN>> DJHCOEGLAEN;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x51B4380", Offset = "0x51B2F80", VA = "0x1851B4380")]
		private CGABJMCFCDC(TaskCompletionSource<GFFELLBKJIA<object, DCMKOJFPDPC>> CNBGHAGBAKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3D3A400", Offset = "0x3D39000", VA = "0x183D3A400")]
		public static CGABJMCFCDC PPOPBMPFEOP(TaskCompletionSource<GFFELLBKJIA<object, DCMKOJFPDPC>> CNBGHAGBAKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x51B41C0", Offset = "0x51B2DC0", VA = "0x1851B41C0")]
		public void PCJBHCGAJBL([In] GFFELLBKJIA<object, DCMKOJFPDPC> JFBAIGMLPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x51B3CC0", Offset = "0x51B28C0", VA = "0x1851B3CC0", Slot = "5")]
		public void BMEJKEFCICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x51B3FF0", Offset = "0x51B2BF0", VA = "0x1851B3FF0", Slot = "6")]
		public GFFELLBKJIA<object, DCMKOJFPDPC> GLJOPHOEJBM()
		{
			return default(GFFELLBKJIA<object, DCMKOJFPDPC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x51B3EE0", Offset = "0x51B2AE0", VA = "0x1851B3EE0", Slot = "7")]
		public void COBKNCLOMIE(Exception JNLFEIJKPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x412F860", Offset = "0x412E460", VA = "0x18412F860", Slot = "4")]
		private void MGBDMBJDOME([In] GFFELLBKJIA<object, DCMKOJFPDPC> JFBAIGMLPKE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class KCIJJGKHOJG : DMPHIKNMJMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<GFFELLBKJIA<object, DCMKOJFPDPC>> NGNPBACCKBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private GFFELLBKJIA<object, DCMKOJFPDPC> INGOIHFGOOK;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
		private KCIJJGKHOJG(TaskCompletionSource<GFFELLBKJIA<object, DCMKOJFPDPC>> CNBGHAGBAKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3D3A400", Offset = "0x3D39000", VA = "0x183D3A400")]
		public static KCIJJGKHOJG PPOPBMPFEOP(TaskCompletionSource<GFFELLBKJIA<object, DCMKOJFPDPC>> CNBGHAGBAKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D9C0", Offset = "0x3E6C5C0", VA = "0x183E6D9C0")]
		public void PCJBHCGAJBL([In] GFFELLBKJIA<object, DCMKOJFPDPC> JFBAIGMLPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x412F740", Offset = "0x412E340", VA = "0x18412F740", Slot = "5")]
		public void BMEJKEFCICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xC225E0", Offset = "0xC211E0", VA = "0x180C225E0", Slot = "6")]
		public GFFELLBKJIA<object, DCMKOJFPDPC> GLJOPHOEJBM()
		{
			return default(GFFELLBKJIA<object, DCMKOJFPDPC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x412F800", Offset = "0x412E400", VA = "0x18412F800", Slot = "7")]
		public void COBKNCLOMIE(Exception JNLFEIJKPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x412F860", Offset = "0x412E460", VA = "0x18412F860", Slot = "4")]
		private void MGBDMBJDOME([In] GFFELLBKJIA<object, DCMKOJFPDPC> JFBAIGMLPKE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class NKCKOOADPCD : DMPHIKNMJMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<GFFELLBKJIA<object, DCMKOJFPDPC>> DJHCOEGLAEN;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4499960", Offset = "0x4498560", VA = "0x184499960")]
		private NKCKOOADPCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4499810", Offset = "0x4498410", VA = "0x184499810")]
		public static NKCKOOADPCD PPOPBMPFEOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4499730", Offset = "0x4498330", VA = "0x184499730")]
		public void PCJBHCGAJBL([In] GFFELLBKJIA<object, DCMKOJFPDPC> JFBAIGMLPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		public void BMEJKEFCICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x44995F0", Offset = "0x44981F0", VA = "0x1844995F0", Slot = "6")]
		public GFFELLBKJIA<object, DCMKOJFPDPC> GLJOPHOEJBM()
		{
			return default(GFFELLBKJIA<object, DCMKOJFPDPC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4499540", Offset = "0x4498140", VA = "0x184499540", Slot = "7")]
		[DKPEDCBOHDB("This may be terminal and should probably do more than discarding the exception.")]
		public void COBKNCLOMIE(Exception JNLFEIJKPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x412F860", Offset = "0x412E460", VA = "0x18412F860", Slot = "4")]
		private void MGBDMBJDOME([In] GFFELLBKJIA<object, DCMKOJFPDPC> JFBAIGMLPKE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class PHONJLPCPOC : DMPHIKNMJMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GFFELLBKJIA<object, DCMKOJFPDPC> INGOIHFGOOK;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		private PHONJLPCPOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4499810", Offset = "0x4498410", VA = "0x184499810")]
		public static PHONJLPCPOC PPOPBMPFEOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x16E9E90", Offset = "0x16E8A90", VA = "0x1816E9E90")]
		public void PCJBHCGAJBL([In] GFFELLBKJIA<object, DCMKOJFPDPC> JFBAIGMLPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		public void BMEJKEFCICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8B92D0", Offset = "0x8B7ED0", VA = "0x1808B92D0", Slot = "6")]
		public GFFELLBKJIA<object, DCMKOJFPDPC> GLJOPHOEJBM()
		{
			return default(GFFELLBKJIA<object, DCMKOJFPDPC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4767100", Offset = "0x4765D00", VA = "0x184767100", Slot = "7")]
		[DKPEDCBOHDB("This may be terminal and should probably do more than discarding the exception.")]
		public void COBKNCLOMIE(Exception JNLFEIJKPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x412F860", Offset = "0x412E460", VA = "0x18412F860", Slot = "4")]
		private void MGBDMBJDOME([In] GFFELLBKJIA<object, DCMKOJFPDPC> JFBAIGMLPKE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct IGMNFMFDLJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<object, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public GAODIOBGCGN<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public DCECDLKENED<KLBJPBJKDCO> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<GFFELLBKJIA<object, DCMKOJFPDPC>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<GFFELLBKJIA<object, DCMKOJFPDPC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3E28BD0", Offset = "0x3E277D0", VA = "0x183E28BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3E290B0", Offset = "0x3E27CB0", VA = "0x183E290B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MMODHBEAFDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<object, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public GAODIOBGCGN<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DCECDLKENED<KLBJPBJKDCO> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<GFFELLBKJIA<object, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x441DEF0", Offset = "0x441CAF0", VA = "0x18441DEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x441E820", Offset = "0x441D420", VA = "0x18441E820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LGNKAMKGPEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<object, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public GAODIOBGCGN<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public DCECDLKENED<KLBJPBJKDCO> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public DCECDLKENED<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<GFFELLBKJIA<object, DCMKOJFPDPC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x41F70D0", Offset = "0x41F5CD0", VA = "0x1841F70D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x41F74B0", Offset = "0x41F60B0", VA = "0x1841F74B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CFPBEKKPOAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<GFFELLBKJIA<object, DCMKOJFPDPC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public GAODIOBGCGN<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public DCECDLKENED<KLBJPBJKDCO> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public DCECDLKENED<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private DMPHIKNMJMF <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x51B2210", Offset = "0x51B0E10", VA = "0x1851B2210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x51B3C50", Offset = "0x51B2850", VA = "0x1851B3C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct JAOOCOAADCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public GAODIOBGCGN<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public DMPHIKNMJMF completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private DMPHIKNMJMF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<GFFELLBKJIA<object, DCMKOJFPDPC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x400B5F0", Offset = "0x400A1F0", VA = "0x18400B5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x400F680", Offset = "0x400E280", VA = "0x18400F680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps KJMCLGOJKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<DCECDLKENED<TMRequest>, TaskCompletionSource<GFFELLBKJIA<object, DCMKOJFPDPC>>> FHBIELACJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private NMGEBJCIOOF<TMRequest> NJGIPLFNMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int AAGACCCMEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task NNFLMPCPBLH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps FLOAOFBDMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F4C0", Offset = "0x3C6E0C0", VA = "0x183C6F4C0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps EBCKHPKFMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F490", Offset = "0x3C6E090", VA = "0x183C6F490")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps IIBNNDLCECI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E690", Offset = "0x3C6D290", VA = "0x183C6E690")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool PGHGBGMOFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x90B6B0", Offset = "0x90A2B0", VA = "0x18090B6B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x136CFD0", Offset = "0x136BBD0", VA = "0x18136CFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CIPKOBBJGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xF112C0", Offset = "0xF0FEC0", VA = "0x180F112C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1E54070", Offset = "0x1E52C70", VA = "0x181E54070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FJMIPANHLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x844560", Offset = "0x843160", VA = "0x180844560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3C6FC00", Offset = "0x3C6E800", VA = "0x183C6FC00")]
	public GAODIOBGCGN(TDeps CFCALMONEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3C6EC30", Offset = "0x3C6D830", VA = "0x183C6EC30")]
	public Task<GFFELLBKJIA<object, DCMKOJFPDPC>> FOCDEKCLCLP(TRoot BLPDMPJLPPJ, TNetSys BDBKEEMILOF, DCECDLKENED<KLBJPBJKDCO> DCAKCMKMNFC, TAction FIPNCHEIGMJ, bool ADIMHKJHMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3C6EAD0", Offset = "0x3C6D6D0", VA = "0x183C6EAD0")]
	[AsyncStateMachine(typeof(GAODIOBGCGN<, , , , , , , , >.IGMNFMFDLJD))]
	private Task<GFFELLBKJIA<object, DCMKOJFPDPC>> FOCDEKCLCLP(TRoot BLPDMPJLPPJ, DCECDLKENED<KLBJPBJKDCO> DCAKCMKMNFC, TAction FIPNCHEIGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E070", Offset = "0x3C6CC70", VA = "0x183C6E070")]
	[AsyncStateMachine(typeof(GAODIOBGCGN<, , , , , , , , >.MMODHBEAFDL))]
	private Task<GFFELLBKJIA<object, DCMKOJFPDPC>> AHOCIIOOHAI(TRoot BLPDMPJLPPJ, DCECDLKENED<KLBJPBJKDCO> DCAKCMKMNFC, TAction[] FOLFFNCNEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3C6DD90", Offset = "0x3C6C990", VA = "0x183C6DD90")]
	[AsyncStateMachine(typeof(GAODIOBGCGN<, , , , , , , , >.LGNKAMKGPEG))]
	public Task<GFFELLBKJIA<object, DCMKOJFPDPC>> ADGJIKPMKGF(TRoot BLPDMPJLPPJ, TNetSys MLJDJGLPJAG, TReceiver PPFPKNPFHFN, DCECDLKENED<KLBJPBJKDCO> DCAKCMKMNFC, DCECDLKENED<TMRequest> OMLBMJPOGDN, TAction FIPNCHEIGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E4C0", Offset = "0x3C6D0C0", VA = "0x183C6E4C0")]
	[AsyncStateMachine(typeof(GAODIOBGCGN<, , , , , , , , >.CFPBEKKPOAM))]
	private Task<GFFELLBKJIA<object, DCMKOJFPDPC>> BBEFNPEOLPB(TRoot BLPDMPJLPPJ, TNetSys MLJDJGLPJAG, TReceiver PPFPKNPFHFN, DCECDLKENED<KLBJPBJKDCO> DCAKCMKMNFC, DCECDLKENED<TMRequest> OMLBMJPOGDN, TAction FIPNCHEIGMJ, Task KFDNDBIBDJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E6C0", Offset = "0x3C6D2C0", VA = "0x183C6E6C0")]
	[AsyncStateMachine(typeof(GAODIOBGCGN<, , , , , , , , >.JAOOCOAADCH))]
	private Task BEAOIODODMD(TRoot BLPDMPJLPPJ, TNetSys MLJDJGLPJAG, TReceiver PPFPKNPFHFN, TAction FIPNCHEIGMJ, DMPHIKNMJMF IKGCELAGFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F8F0", Offset = "0x3C6E4F0", VA = "0x183C6F8F0")]
	private void PHHJAMBEBEF(TRoot BLPDMPJLPPJ, TNetSys MLJDJGLPJAG, TReceiver PPFPKNPFHFN, DCECDLKENED<KLBJPBJKDCO> DCAKCMKMNFC, TAction FIPNCHEIGMJ, bool CBKGDLMPBPC, bool HMKLFPKMKOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FJHOKOIKACF
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface DGGHPGHNPGN<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GKLKBIANJDP(TNetSys NJLGKJNKHDJ, TAction FIPNCHEIGMJ);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction BCEOEMFCEBH(TNetSys NJLGKJNKHDJ, TAction FIPNCHEIGMJ);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction LPHDEHDAMMI(TNetSys NJLGKJNKHDJ, TAction FIPNCHEIGMJ);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> OCAGLLPEHLD(TNetSys NJLGKJNKHDJ, TAction FIPNCHEIGMJ);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] EPANFMNPGLC(TNetSys NJLGKJNKHDJ, TAction FIPNCHEIGMJ, int IBOMMGNPJEP);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool JFPBOHHLJHF(TNetSys NJLGKJNKHDJ, TAction FIPNCHEIGMJ);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool HKCEFIMINBJ(TNetSys NJLGKJNKHDJ, TAction FIPNCHEIGMJ);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool MFODPKHHHAL(TNetSys NJLGKJNKHDJ, TAction FIPNCHEIGMJ);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool KHBEBGOOEMI(TNetSys NJLGKJNKHDJ, TAction FIPNCHEIGMJ);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HLOLEENAPNA(TNetSys NJLGKJNKHDJ, TAction FIPNCHEIGMJ);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool LOGLHOEAJCA(TNetSys NJLGKJNKHDJ, TAction FIPNCHEIGMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface KJFLCEDCFCN<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps FLOAOFBDMNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps IIBNNDLCECI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps EBCKHPKFMLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface ECBIIFJABHC<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		DCECDLKENED<KLBJPBJKDCO> BOAEAGHPAEH(TReceiver PPFPKNPFHFN);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<GFFELLBKJIA<object, DCMKOJFPDPC>> ADGJIKPMKGF(TReceiver PPFPKNPFHFN, TAction FIPNCHEIGMJ);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] BIBENPJDHNB(TReceiver PPFPKNPFHFN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface JFJNHJBCDAJ<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HFGNOJKNACB(TRoot BLPDMPJLPPJ);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int JGEMFPAEIDM(TRoot BLPDMPJLPPJ);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int CIPDMFJNPDB(TRoot BLPDMPJLPPJ);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int NDCCKAJLBDH(TRoot BLPDMPJLPPJ);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AFKLBBCEGJI(TRoot BLPDMPJLPPJ);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task FOCDEKCLCLP(TRoot BLPDMPJLPPJ, DCECDLKENED<KLBJPBJKDCO> DCAKCMKMNFC, DCECDLKENED<TMRequest> OMLBMJPOGDN, TAction FIPNCHEIGMJ, bool HGEKEOBAHDF = true);
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
