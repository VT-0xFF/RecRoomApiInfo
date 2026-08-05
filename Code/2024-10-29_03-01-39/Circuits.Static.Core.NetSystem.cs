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
public struct POHJBOLIAMD<TPartialAction, TFullAction, TDeps> where TDeps : EKJGJANFMMG.IEIKKJCOLGF<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] GBIDJOLPOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int BKOOEHPKMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps PBAEBCPCIME;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4094AE0", Offset = "0x4093AE0", VA = "0x184094AE0")]
	internal POHJBOLIAMD(TPartialAction[] HENJOCCNJBK, int BLNLLIIBCEK, TDeps IKBDGBPPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x40949C0", Offset = "0x40939C0", VA = "0x1840949C0")]
	public static POHJBOLIAMD<TPartialAction, TFullAction, TDeps> EJLELCHFLID(TDeps IKBDGBPPCAB)
	{
		return default(POHJBOLIAMD<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EKJGJANFMMG
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface IEIKKJCOLGF<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DMMOFIFBLPP([In] TPartialAction CFEHMMIHPBN);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction FDCMNALNFDH(TPartialAction[] LPJKFNAKNCL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2DED6E0", Offset = "0x2DEC6E0", VA = "0x182DED6E0")]
	public static BHNGMIADPIG<TFullAction> OPEKKKGNIGO<TFullAction, TPartialAction, TDeps>(this POHJBOLIAMD<TPartialAction, TFullAction, TDeps> GFJPFDOHONG, TPartialAction CFEHMMIHPBN) where TDeps : IEIKKJCOLGF<TPartialAction, TFullAction>
	{
		return default(BHNGMIADPIG<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct AENABONOLMA<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : ICDEKEFHGBC.PGKJNNAGGLM<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] ECBMGMPMBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int HIJLKGGCJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps PBAEBCPCIME;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4094AE0", Offset = "0x4093AE0", VA = "0x184094AE0")]
	internal AENABONOLMA(TPartialSnapshot[] JJHLBEKBPFH, int JMFFEOKEMOC, TDeps IKBDGBPPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x40949C0", Offset = "0x40939C0", VA = "0x1840949C0")]
	public static AENABONOLMA<TPartialSnapshot, TFullSnapshot, TDeps> EJLELCHFLID(TDeps IKBDGBPPCAB)
	{
		return default(AENABONOLMA<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ICDEKEFHGBC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface PGKJNNAGGLM<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FBLNDGBIBLD([In] TPartialSnapshot OOBOPPMIJBE);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot FHFFMHCMFIB(TPartialSnapshot[] IHHIMAHPALO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2FA77B0", Offset = "0x2FA67B0", VA = "0x182FA77B0")]
	public static BHNGMIADPIG<TFullSnapshot> OPEKKKGNIGO<TFullSnapshot, TPartialSnapshot, TDeps>(this AENABONOLMA<TPartialSnapshot, TFullSnapshot, TDeps> GFJPFDOHONG, TPartialSnapshot OOBOPPMIJBE) where TDeps : PGKJNNAGGLM<TPartialSnapshot, TFullSnapshot>
	{
		return default(BHNGMIADPIG<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7670", Offset = "0x2FA6670", VA = "0x182FA7670")]
	public static bool ANHMFIHIBPH<TPartialSnapshot, TFullSnapshot, TDeps>(this AENABONOLMA<TPartialSnapshot, TFullSnapshot, TDeps> GFJPFDOHONG, TPartialSnapshot OOBOPPMIJBE) where TDeps : PGKJNNAGGLM<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class JOBJAJPJHNE : DCDJFOHHJCP
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2318C20", Offset = "0x2317C20", VA = "0x182318C20", Slot = "7")]
	public override string DOJAIBMDODD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2318C50", Offset = "0x2317C50", VA = "0x182318C50")]
	public JOBJAJPJHNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class NPCJDAJGEGA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : LONMEFHAMIO.CNDBABGKLBM<TAction, TNetSys> where TReceiverDeps : LONMEFHAMIO.HDIGBLCADNP<TAction, TReceiver> where TRootDeps : LONMEFHAMIO.PIBBLFPPIGE<TMRequest, TAction, TRoot> where TDeps : LONMEFHAMIO.OGCLICJPMLJ<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface LODJLMJJDPL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ACODIDIHCAJ([In] OBFFLKDLIBJ<object, FGHJECBDJBN> POCKBMKNJHC);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GKJEEBOBHAO();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		OBFFLKDLIBJ<object, FGHJECBDJBN> DMGJOHLGCEA();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KEOLMFFDFGM(Exception BKFPPGLJAII);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class NDOHKBPHGAE : LODJLMJJDPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<OBFFLKDLIBJ<object, FGHJECBDJBN>> HKHFIPHNAPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<OBFFLKDLIBJ<object, HJOFKELFHOB>> ICAONJLIPMD;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x49C6140", Offset = "0x49C5140", VA = "0x1849C6140")]
		private NDOHKBPHGAE(TaskCompletionSource<OBFFLKDLIBJ<object, FGHJECBDJBN>> MEEPBDOOLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x419CFA0", Offset = "0x419BFA0", VA = "0x18419CFA0")]
		public static NDOHKBPHGAE EJLELCHFLID(TaskCompletionSource<OBFFLKDLIBJ<object, FGHJECBDJBN>> MEEPBDOOLIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x49C5A80", Offset = "0x49C4A80", VA = "0x1849C5A80")]
		public void ACODIDIHCAJ([In] OBFFLKDLIBJ<object, FGHJECBDJBN> POCKBMKNJHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x49C5F00", Offset = "0x49C4F00", VA = "0x1849C5F00", Slot = "5")]
		public void GKJEEBOBHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x49C5CC0", Offset = "0x49C4CC0", VA = "0x1849C5CC0", Slot = "6")]
		public OBFFLKDLIBJ<object, FGHJECBDJBN> DMGJOHLGCEA()
		{
			return default(OBFFLKDLIBJ<object, FGHJECBDJBN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x49C6040", Offset = "0x49C5040", VA = "0x1849C6040", Slot = "7")]
		public void KEOLMFFDFGM(Exception BKFPPGLJAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x419D140", Offset = "0x419C140", VA = "0x18419D140", Slot = "4")]
		private void HEJIOPFCBEN([In] OBFFLKDLIBJ<object, FGHJECBDJBN> POCKBMKNJHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class AFEELBOJFOP : LODJLMJJDPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<OBFFLKDLIBJ<object, FGHJECBDJBN>> HKHFIPHNAPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private OBFFLKDLIBJ<object, FGHJECBDJBN> CBCOMKEOFHJ;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
		private AFEELBOJFOP(TaskCompletionSource<OBFFLKDLIBJ<object, FGHJECBDJBN>> MEEPBDOOLIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x419CFA0", Offset = "0x419BFA0", VA = "0x18419CFA0")]
		public static AFEELBOJFOP EJLELCHFLID(TaskCompletionSource<OBFFLKDLIBJ<object, FGHJECBDJBN>> MEEPBDOOLIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x419CF80", Offset = "0x419BF80", VA = "0x18419CF80")]
		public void ACODIDIHCAJ([In] OBFFLKDLIBJ<object, FGHJECBDJBN> POCKBMKNJHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x419D080", Offset = "0x419C080", VA = "0x18419D080", Slot = "5")]
		public void GKJEEBOBHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA17190", Offset = "0xA16190", VA = "0x180A17190", Slot = "6")]
		public OBFFLKDLIBJ<object, FGHJECBDJBN> DMGJOHLGCEA()
		{
			return default(OBFFLKDLIBJ<object, FGHJECBDJBN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x419D1E0", Offset = "0x419C1E0", VA = "0x18419D1E0", Slot = "7")]
		public void KEOLMFFDFGM(Exception BKFPPGLJAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x419D140", Offset = "0x419C140", VA = "0x18419D140", Slot = "4")]
		private void HEJIOPFCBEN([In] OBFFLKDLIBJ<object, FGHJECBDJBN> POCKBMKNJHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class MHAAEBBKEIK : LODJLMJJDPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<OBFFLKDLIBJ<object, FGHJECBDJBN>> ICAONJLIPMD;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x494A5D0", Offset = "0x49495D0", VA = "0x18494A5D0")]
		private MHAAEBBKEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x494A460", Offset = "0x4949460", VA = "0x18494A460")]
		public static MHAAEBBKEIK EJLELCHFLID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x494A2C0", Offset = "0x49492C0", VA = "0x18494A2C0")]
		public void ACODIDIHCAJ([In] OBFFLKDLIBJ<object, FGHJECBDJBN> POCKBMKNJHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		public void GKJEEBOBHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x494A3A0", Offset = "0x49493A0", VA = "0x18494A3A0", Slot = "6")]
		public OBFFLKDLIBJ<object, FGHJECBDJBN> DMGJOHLGCEA()
		{
			return default(OBFFLKDLIBJ<object, FGHJECBDJBN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x494A530", Offset = "0x4949530", VA = "0x18494A530", Slot = "7")]
		[GKFAPCOLABH("This may be terminal and should probably do more than discarding the exception.")]
		public void KEOLMFFDFGM(Exception BKFPPGLJAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x419D140", Offset = "0x419C140", VA = "0x18419D140", Slot = "4")]
		private void HEJIOPFCBEN([In] OBFFLKDLIBJ<object, FGHJECBDJBN> POCKBMKNJHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class DGIOHIILKOC : LODJLMJJDPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private OBFFLKDLIBJ<object, FGHJECBDJBN> CBCOMKEOFHJ;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		private DGIOHIILKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x494A460", Offset = "0x4949460", VA = "0x18494A460")]
		public static DGIOHIILKOC EJLELCHFLID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7B30", Offset = "0x1CE6B30", VA = "0x181CE7B30")]
		public void ACODIDIHCAJ([In] OBFFLKDLIBJ<object, FGHJECBDJBN> POCKBMKNJHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		public void GKJEEBOBHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB885E0", Offset = "0xB875E0", VA = "0x180B885E0", Slot = "6")]
		public OBFFLKDLIBJ<object, FGHJECBDJBN> DMGJOHLGCEA()
		{
			return default(OBFFLKDLIBJ<object, FGHJECBDJBN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5D7A130", Offset = "0x5D79130", VA = "0x185D7A130", Slot = "7")]
		[GKFAPCOLABH("This may be terminal and should probably do more than discarding the exception.")]
		public void KEOLMFFDFGM(Exception BKFPPGLJAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x419D140", Offset = "0x419C140", VA = "0x18419D140", Slot = "4")]
		private void HEJIOPFCBEN([In] OBFFLKDLIBJ<object, FGHJECBDJBN> POCKBMKNJHC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct KNLHGNELHNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NPCJDAJGEGA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public FCEODKAEDJI<FIEOABOJMBC> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<OBFFLKDLIBJ<object, FGHJECBDJBN>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x46A8B10", Offset = "0x46A7B10", VA = "0x1846A8B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x46A9630", Offset = "0x46A8630", VA = "0x1846A9630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct ALFEMIFBJAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public NPCJDAJGEGA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public FCEODKAEDJI<FIEOABOJMBC> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x41AE330", Offset = "0x41AD330", VA = "0x1841AE330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x41AE820", Offset = "0x41AD820", VA = "0x1841AE820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DKLEFMEJCNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public NPCJDAJGEGA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public FCEODKAEDJI<FIEOABOJMBC> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public FCEODKAEDJI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE200", Offset = "0x5DBD200", VA = "0x185DBE200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5DBE5E0", Offset = "0x5DBD5E0", VA = "0x185DBE5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct KOMOAGPIHDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NPCJDAJGEGA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public FCEODKAEDJI<FIEOABOJMBC> senderId;

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
		public FCEODKAEDJI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private LODJLMJJDPL <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x46AB0B0", Offset = "0x46AA0B0", VA = "0x1846AB0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x46ABD50", Offset = "0x46AAD50", VA = "0x1846ABD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct GHOJDGHMPBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NPCJDAJGEGA<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public LODJLMJJDPL completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private LODJLMJJDPL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x416E1A0", Offset = "0x416D1A0", VA = "0x18416E1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x41701A0", Offset = "0x416F1A0", VA = "0x1841701A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps PBAEBCPCIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<FCEODKAEDJI<TMRequest>, TaskCompletionSource<OBFFLKDLIBJ<object, FGHJECBDJBN>>> BIPOCJGDDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private IEKDEDCKJFP<TMRequest> NDMEFGJCFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int JBGIKACHCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task JBAPHDPADDK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps LKGKDKNMINI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4A021C0", Offset = "0x4A011C0", VA = "0x184A021C0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps AKLHCCHDKIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4A02240", Offset = "0x4A01240", VA = "0x184A02240")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps DGAOCCJILCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4A02140", Offset = "0x4A01140", VA = "0x184A02140")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BJNCLAKPHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xCF4AF0", Offset = "0xCF3AF0", VA = "0x180CF4AF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x192A010", Offset = "0x1929010", VA = "0x18192A010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IBNHAIFHBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1358490", Offset = "0x1357490", VA = "0x181358490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x21BE980", Offset = "0x21BD980", VA = "0x1821BE980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BFNIEBGEKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8B6660", Offset = "0x8B5660", VA = "0x1808B6660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4A02400", Offset = "0x4A01400", VA = "0x184A02400")]
	public NPCJDAJGEGA(TDeps IKBDGBPPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4A009A0", Offset = "0x49FF9A0", VA = "0x184A009A0")]
	public Task<OBFFLKDLIBJ<object, FGHJECBDJBN>> BLBAFJMAICP(TRoot BAOAKGNNKEP, TNetSys DHPLHDCEOHM, FCEODKAEDJI<FIEOABOJMBC> KABGFMFIEPA, TAction NDLMGANFCBJ, bool PADNGJCAHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4A00D20", Offset = "0x49FFD20", VA = "0x184A00D20")]
	[AsyncStateMachine(typeof(NPCJDAJGEGA<, , , , , , , , >.KNLHGNELHNN))]
	private Task<OBFFLKDLIBJ<object, FGHJECBDJBN>> BLBAFJMAICP(TRoot BAOAKGNNKEP, FCEODKAEDJI<FIEOABOJMBC> KABGFMFIEPA, TAction NDLMGANFCBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4A01E30", Offset = "0x4A00E30", VA = "0x184A01E30")]
	[AsyncStateMachine(typeof(NPCJDAJGEGA<, , , , , , , , >.ALFEMIFBJAB))]
	private Task<OBFFLKDLIBJ<object, FGHJECBDJBN>> IMAHCPKJFPA(TRoot BAOAKGNNKEP, FCEODKAEDJI<FIEOABOJMBC> KABGFMFIEPA, TAction[] DGAJIBMPJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4A00E80", Offset = "0x49FFE80", VA = "0x184A00E80")]
	[AsyncStateMachine(typeof(NPCJDAJGEGA<, , , , , , , , >.DKLEFMEJCNK))]
	public Task<OBFFLKDLIBJ<object, FGHJECBDJBN>> DJACEGEOFCI(TRoot BAOAKGNNKEP, TNetSys MCJGDBFCKIL, TReceiver BGLJKFHLJGM, FCEODKAEDJI<FIEOABOJMBC> KABGFMFIEPA, FCEODKAEDJI<TMRequest> ODCLBFGKODG, TAction NDLMGANFCBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4A01420", Offset = "0x4A00420", VA = "0x184A01420")]
	[AsyncStateMachine(typeof(NPCJDAJGEGA<, , , , , , , , >.KOMOAGPIHDJ))]
	private Task<OBFFLKDLIBJ<object, FGHJECBDJBN>> ELFEFLHENNP(TRoot BAOAKGNNKEP, TNetSys MCJGDBFCKIL, TReceiver BGLJKFHLJGM, FCEODKAEDJI<FIEOABOJMBC> KABGFMFIEPA, FCEODKAEDJI<TMRequest> ODCLBFGKODG, TAction NDLMGANFCBJ, Task LMGJPDMLPMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4A01170", Offset = "0x4A00170", VA = "0x184A01170")]
	[AsyncStateMachine(typeof(NPCJDAJGEGA<, , , , , , , , >.GHOJDGHMPBK))]
	private Task EJMAHLPAKDM(TRoot BAOAKGNNKEP, TNetSys MCJGDBFCKIL, TReceiver BGLJKFHLJGM, TAction NDLMGANFCBJ, LODJLMJJDPL DAFFKHADFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4A01730", Offset = "0x4A00730", VA = "0x184A01730")]
	private void GPMJADIEJJO(TRoot BAOAKGNNKEP, TNetSys MCJGDBFCKIL, TReceiver BGLJKFHLJGM, FCEODKAEDJI<FIEOABOJMBC> KABGFMFIEPA, TAction NDLMGANFCBJ, bool IBIHOIDGBKB, bool FDGEANOLKFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LONMEFHAMIO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface CNDBABGKLBM<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OEAJMMOEJAL(TNetSys JNIANPFJBBA, TAction NDLMGANFCBJ);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction JLEFOKIJIHL(TNetSys JNIANPFJBBA, TAction NDLMGANFCBJ);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction FEHPIKDKNMG(TNetSys JNIANPFJBBA, TAction NDLMGANFCBJ);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> IKHCGLACIEG(TNetSys JNIANPFJBBA, TAction NDLMGANFCBJ);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] BLIJMGPDNOO(TNetSys JNIANPFJBBA, TAction NDLMGANFCBJ, int ONLJKJKOGEK);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LFEOICJOKPA(TNetSys JNIANPFJBBA, TAction NDLMGANFCBJ);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool IOECBJCMBFN(TNetSys JNIANPFJBBA, TAction NDLMGANFCBJ);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool LJOBGAMPMGI(TNetSys JNIANPFJBBA, TAction NDLMGANFCBJ);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool IBMPDNCMIFD(TNetSys JNIANPFJBBA, TAction NDLMGANFCBJ);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool OIJICBKNBPH(TNetSys JNIANPFJBBA, TAction NDLMGANFCBJ);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool HBCKCDCJMAL(TNetSys JNIANPFJBBA, TAction NDLMGANFCBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface OGCLICJPMLJ<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps LKGKDKNMINI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps DGAOCCJILCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps AKLHCCHDKIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface HDIGBLCADNP<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		FCEODKAEDJI<FIEOABOJMBC> HFMMBMBBEOF(TReceiver BGLJKFHLJGM);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<OBFFLKDLIBJ<object, FGHJECBDJBN>> DJACEGEOFCI(TReceiver BGLJKFHLJGM, TAction NDLMGANFCBJ);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] BPIAEHNEPMA(TReceiver BGLJKFHLJGM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface PIBBLFPPIGE<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GMNJLKHFAHC(TRoot BAOAKGNNKEP);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int JLKMEMPBMBF(TRoot BAOAKGNNKEP);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int BONGEOFJPAJ(TRoot BAOAKGNNKEP);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int JBDPLOFAKIE(TRoot BAOAKGNNKEP);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GAHDAGJDIPJ(TRoot BAOAKGNNKEP);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task BLBAFJMAICP(TRoot BAOAKGNNKEP, FCEODKAEDJI<FIEOABOJMBC> KABGFMFIEPA, FCEODKAEDJI<TMRequest> ODCLBFGKODG, TAction NDLMGANFCBJ, bool BIEHAOCEKHC = true);
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
