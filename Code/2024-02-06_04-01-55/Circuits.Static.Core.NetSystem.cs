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
public struct ENAHIJCKNCC<TPartialAction, TFullAction, TDeps> where TDeps : PMNEIEPFDBL.IBIMPHAFCAB<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] ACAILJOLFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int MJAKOONLBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps ILLOCOKHCDM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x32C3220", Offset = "0x32C2620", VA = "0x1832C3220")]
	internal ENAHIJCKNCC(TPartialAction[] GJMLPLOAMJF, int JDFKIOKEMEA, TDeps MLLANHDPJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x32C3150", Offset = "0x32C2550", VA = "0x1832C3150")]
	public static ENAHIJCKNCC<TPartialAction, TFullAction, TDeps> CPLKLKACALP(TDeps MLLANHDPJEE)
	{
		return default(ENAHIJCKNCC<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PMNEIEPFDBL
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface IBIMPHAFCAB<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GLEJMEDJGGE([In] TPartialAction DHFJEMLPBBF);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction NLAOJIBIGEH(TPartialAction[] BEIFPMNJCLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2828F80", Offset = "0x2828380", VA = "0x182828F80")]
	public static MEHMHNNDBEN<TFullAction> KJPPJPGPADO<TFullAction, TPartialAction, TDeps>(this ENAHIJCKNCC<TPartialAction, TFullAction, TDeps> LOMPFKEACIP, TPartialAction DHFJEMLPBBF) where TDeps : IBIMPHAFCAB<TPartialAction, TFullAction>
	{
		return default(MEHMHNNDBEN<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LMMLJBEPJHH<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : EBABHJLEOJP.FAALPPMOHHE<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] EFOCLNHJDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int FIEGCMBLOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps ILLOCOKHCDM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x32C3220", Offset = "0x32C2620", VA = "0x1832C3220")]
	internal LMMLJBEPJHH(TPartialSnapshot[] EPKMHFKJIHA, int IDGJJACIBJN, TDeps MLLANHDPJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x32C3150", Offset = "0x32C2550", VA = "0x1832C3150")]
	public static LMMLJBEPJHH<TPartialSnapshot, TFullSnapshot, TDeps> CPLKLKACALP(TDeps MLLANHDPJEE)
	{
		return default(LMMLJBEPJHH<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EBABHJLEOJP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface FAALPPMOHHE<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JIGOGHBAKGB([In] TPartialSnapshot EDMNJHMCIMO);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot LNCBJFGBGFJ(TPartialSnapshot[] KEEMDPCNAAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2537DE0", Offset = "0x25371E0", VA = "0x182537DE0")]
	public static MEHMHNNDBEN<TFullSnapshot> KJPPJPGPADO<TFullSnapshot, TPartialSnapshot, TDeps>(this LMMLJBEPJHH<TPartialSnapshot, TFullSnapshot, TDeps> LOMPFKEACIP, TPartialSnapshot EDMNJHMCIMO) where TDeps : FAALPPMOHHE<TPartialSnapshot, TFullSnapshot>
	{
		return default(MEHMHNNDBEN<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2537C90", Offset = "0x2537090", VA = "0x182537C90")]
	public static bool IJKACNCJLGI<TPartialSnapshot, TFullSnapshot, TDeps>(this LMMLJBEPJHH<TPartialSnapshot, TFullSnapshot, TDeps> LOMPFKEACIP, TPartialSnapshot EDMNJHMCIMO) where TDeps : FAALPPMOHHE<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class LKAMHIGCPCO : MBFBMDOADGG
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D4FA80", Offset = "0x1D4EE80", VA = "0x181D4FA80", Slot = "7")]
	public override string KHCKPFAHKDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D4FAB0", Offset = "0x1D4EEB0", VA = "0x181D4FAB0")]
	public LKAMHIGCPCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class CMFFENGIKEI<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : IHKNFHBFMNG.HIGOGNLDGCK<TAction, TNetSys> where TReceiverDeps : IHKNFHBFMNG.HPMPJEGEOAD<TMActor, TAction, TReceiver> where TRootDeps : IHKNFHBFMNG.FDOCOIBDECJ<TMRequest, TMActor, TAction, TRoot> where TDeps : IHKNFHBFMNG.IKKIOMCOCJI<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface JEPNBGOLKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KMGDGJGANNJ([In] IAPKJCHKLLD<object, HDKPGPNEBBO> ANIEEDIHIEE);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PKPHMFCOBHJ();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IAPKJCHKLLD<object, HDKPGPNEBBO> FJEICKBHFJG();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FNLPDBHHBFF(Exception PPLJOKJMAEA);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class MAPHBHDEBFF : JEPNBGOLKMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<IAPKJCHKLLD<object, HDKPGPNEBBO>> CCGPDCKFODM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<IAPKJCHKLLD<object, LKFFGCCEJDH>> DPJEFHOJIAG;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3DAD560", Offset = "0x3DAC960", VA = "0x183DAD560")]
		private MAPHBHDEBFF(TaskCompletionSource<IAPKJCHKLLD<object, HDKPGPNEBBO>> OGKJLJLOADA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x32C1250", Offset = "0x32C0650", VA = "0x1832C1250")]
		public static MAPHBHDEBFF CPLKLKACALP(TaskCompletionSource<IAPKJCHKLLD<object, HDKPGPNEBBO>> OGKJLJLOADA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3DAD1A0", Offset = "0x3DAC5A0", VA = "0x183DAD1A0")]
		public void KMGDGJGANNJ([In] IAPKJCHKLLD<object, HDKPGPNEBBO> ANIEEDIHIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3DAD3A0", Offset = "0x3DAC7A0", VA = "0x183DAD3A0", Slot = "5")]
		public void PKPHMFCOBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3DAD030", Offset = "0x3DAC430", VA = "0x183DAD030", Slot = "6")]
		public IAPKJCHKLLD<object, HDKPGPNEBBO> FJEICKBHFJG()
		{
			return default(IAPKJCHKLLD<object, HDKPGPNEBBO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3DAD0E0", Offset = "0x3DAC4E0", VA = "0x183DAD0E0", Slot = "7")]
		public void FNLPDBHHBFF(Exception PPLJOKJMAEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x32C13E0", Offset = "0x32C07E0", VA = "0x1832C13E0", Slot = "4")]
		private void IHANCKHMGHD([In] IAPKJCHKLLD<object, HDKPGPNEBBO> ANIEEDIHIEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class ELPHNPHDOJI : JEPNBGOLKMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<IAPKJCHKLLD<object, HDKPGPNEBBO>> CCGPDCKFODM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private IAPKJCHKLLD<object, HDKPGPNEBBO> GOEOODGCNAC;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
		private ELPHNPHDOJI(TaskCompletionSource<IAPKJCHKLLD<object, HDKPGPNEBBO>> OGKJLJLOADA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x32C1250", Offset = "0x32C0650", VA = "0x1832C1250")]
		public static ELPHNPHDOJI CPLKLKACALP(TaskCompletionSource<IAPKJCHKLLD<object, HDKPGPNEBBO>> OGKJLJLOADA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x32C1400", Offset = "0x32C0800", VA = "0x1832C1400")]
		public void KMGDGJGANNJ([In] IAPKJCHKLLD<object, HDKPGPNEBBO> ANIEEDIHIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x32C1480", Offset = "0x32C0880", VA = "0x1832C1480", Slot = "5")]
		public void PKPHMFCOBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA1FB90", Offset = "0xA1EF90", VA = "0x180A1FB90", Slot = "6")]
		public IAPKJCHKLLD<object, HDKPGPNEBBO> FJEICKBHFJG()
		{
			return default(IAPKJCHKLLD<object, HDKPGPNEBBO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x32C1380", Offset = "0x32C0780", VA = "0x1832C1380", Slot = "7")]
		public void FNLPDBHHBFF(Exception PPLJOKJMAEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x32C13E0", Offset = "0x32C07E0", VA = "0x1832C13E0", Slot = "4")]
		private void IHANCKHMGHD([In] IAPKJCHKLLD<object, HDKPGPNEBBO> ANIEEDIHIEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class GJCAGFMKOCC : JEPNBGOLKMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<IAPKJCHKLLD<object, HDKPGPNEBBO>> DPJEFHOJIAG;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x37131A0", Offset = "0x37125A0", VA = "0x1837131A0")]
		private GJCAGFMKOCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3712D50", Offset = "0x3712150", VA = "0x183712D50")]
		public static GJCAGFMKOCC CPLKLKACALP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3713040", Offset = "0x3712440", VA = "0x183713040")]
		public void KMGDGJGANNJ([In] IAPKJCHKLLD<object, HDKPGPNEBBO> ANIEEDIHIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		public void PKPHMFCOBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3712E10", Offset = "0x3712210", VA = "0x183712E10", Slot = "6")]
		public IAPKJCHKLLD<object, HDKPGPNEBBO> FJEICKBHFJG()
		{
			return default(IAPKJCHKLLD<object, HDKPGPNEBBO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3712ED0", Offset = "0x37122D0", VA = "0x183712ED0", Slot = "7")]
		[JOOFHEAGKPO("This may be terminal and should probably do more than discarding the exception.")]
		public void FNLPDBHHBFF(Exception PPLJOKJMAEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x32C13E0", Offset = "0x32C07E0", VA = "0x1832C13E0", Slot = "4")]
		private void IHANCKHMGHD([In] IAPKJCHKLLD<object, HDKPGPNEBBO> ANIEEDIHIEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class PNMBJBDKDAK : JEPNBGOLKMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IAPKJCHKLLD<object, HDKPGPNEBBO> GOEOODGCNAC;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		private PNMBJBDKDAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3712D50", Offset = "0x3712150", VA = "0x183712D50")]
		public static PNMBJBDKDAK CPLKLKACALP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1447B40", Offset = "0x1446F40", VA = "0x181447B40")]
		public void KMGDGJGANNJ([In] IAPKJCHKLLD<object, HDKPGPNEBBO> ANIEEDIHIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		public void PKPHMFCOBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB51610", Offset = "0xB50A10", VA = "0x180B51610", Slot = "6")]
		public IAPKJCHKLLD<object, HDKPGPNEBBO> FJEICKBHFJG()
		{
			return default(IAPKJCHKLLD<object, HDKPGPNEBBO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x40C0D90", Offset = "0x40C0190", VA = "0x1840C0D90", Slot = "7")]
		[JOOFHEAGKPO("This may be terminal and should probably do more than discarding the exception.")]
		public void FNLPDBHHBFF(Exception PPLJOKJMAEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x32C13E0", Offset = "0x32C07E0", VA = "0x1832C13E0", Slot = "4")]
		private void IHANCKHMGHD([In] IAPKJCHKLLD<object, HDKPGPNEBBO> ANIEEDIHIEE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LABMHFANHMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::CMFFENGIKEI<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public LELHOHFMKKF<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<IAPKJCHKLLD<object, HDKPGPNEBBO>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3B53AA0", Offset = "0x3B52EA0", VA = "0x183B53AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3B53FE0", Offset = "0x3B533E0", VA = "0x183B53FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FMECGOPLCKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::CMFFENGIKEI<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public LELHOHFMKKF<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x364D930", Offset = "0x364CD30", VA = "0x18364D930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x364E220", Offset = "0x364D620", VA = "0x18364E220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct EDLJNPFBLKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::CMFFENGIKEI<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public LELHOHFMKKF<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public LELHOHFMKKF<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x32A6FE0", Offset = "0x32A63E0", VA = "0x1832A6FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x32A73B0", Offset = "0x32A67B0", VA = "0x1832A73B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HHDBNIFIHNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::CMFFENGIKEI<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public LELHOHFMKKF<TMActor> senderId;

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
		public LELHOHFMKKF<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private JEPNBGOLKMI <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x375D3C0", Offset = "0x375C7C0", VA = "0x18375D3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x375ECB0", Offset = "0x375E0B0", VA = "0x18375ECB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct KHNGDJBHLFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::CMFFENGIKEI<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public JEPNBGOLKMI completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private JEPNBGOLKMI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<IAPKJCHKLLD<object, HDKPGPNEBBO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3ACBB90", Offset = "0x3ACAF90", VA = "0x183ACBB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD8E0", Offset = "0x3ACCCE0", VA = "0x183ACD8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps ILLOCOKHCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<LELHOHFMKKF<TMRequest>, TaskCompletionSource<IAPKJCHKLLD<object, HDKPGPNEBBO>>> HHFGKKHKLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private NEIMPECBJIP<TMRequest> OPKHLKFOHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int MNHNONHIHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task OABIDCPLENM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps OHAJBHIGOBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4B061C0", Offset = "0x4B055C0", VA = "0x184B061C0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps LGBOEBJOHFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4B078C0", Offset = "0x4B06CC0", VA = "0x184B078C0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps COKHFFGKKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4B06530", Offset = "0x4B05930", VA = "0x184B06530")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool IAJBDHGPBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xD2E3C0", Offset = "0xD2D7C0", VA = "0x180D2E3C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1102530", Offset = "0x1101930", VA = "0x181102530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HPGPFJMLHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD2DDE0", Offset = "0xD2D1E0", VA = "0x180D2DDE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1C288B0", Offset = "0x1C27CB0", VA = "0x181C288B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OEMMJGNKIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7A9520", Offset = "0x7A8920", VA = "0x1807A9520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4B078F0", Offset = "0x4B06CF0", VA = "0x184B078F0")]
	public CMFFENGIKEI(TDeps MLLANHDPJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4B06560", Offset = "0x4B05960", VA = "0x184B06560")]
	public Task<IAPKJCHKLLD<object, HDKPGPNEBBO>> FICNPGIMJNP(TRoot DHHBNGOGOPD, TNetSys PDMFCMDOMHN, LELHOHFMKKF<TMActor> HHILNFJHIPJ, TAction HKJBPIINLDG, bool KJOBCONKJDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4B06D30", Offset = "0x4B06130", VA = "0x184B06D30")]
	[AsyncStateMachine(typeof(global::CMFFENGIKEI<, , , , , , , , , >.LABMHFANHMI))]
	private Task<IAPKJCHKLLD<object, HDKPGPNEBBO>> FICNPGIMJNP(TRoot DHHBNGOGOPD, LELHOHFMKKF<TMActor> HHILNFJHIPJ, TAction HKJBPIINLDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4B07150", Offset = "0x4B06550", VA = "0x184B07150")]
	[AsyncStateMachine(typeof(global::CMFFENGIKEI<, , , , , , , , , >.FMECGOPLCKJ))]
	private Task<IAPKJCHKLLD<object, HDKPGPNEBBO>> GMICKLEACJC(TRoot DHHBNGOGOPD, LELHOHFMKKF<TMActor> HHILNFJHIPJ, TAction[] EFJGOOKKOMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4B061F0", Offset = "0x4B055F0", VA = "0x184B061F0")]
	[AsyncStateMachine(typeof(global::CMFFENGIKEI<, , , , , , , , , >.EDLJNPFBLKM))]
	public Task<IAPKJCHKLLD<object, HDKPGPNEBBO>> ANNLIAEODMB(TRoot DHHBNGOGOPD, TNetSys AOGHFPFODPB, TReceiver KNPJGAEAGFF, LELHOHFMKKF<TMActor> HHILNFJHIPJ, LELHOHFMKKF<TMRequest> PBEMKFFJNCL, TAction HKJBPIINLDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4B07560", Offset = "0x4B06960", VA = "0x184B07560")]
	[AsyncStateMachine(typeof(global::CMFFENGIKEI<, , , , , , , , , >.HHDBNIFIHNC))]
	private Task<IAPKJCHKLLD<object, HDKPGPNEBBO>> LAPKCIMNDNO(TRoot DHHBNGOGOPD, TNetSys AOGHFPFODPB, TReceiver KNPJGAEAGFF, LELHOHFMKKF<TMActor> HHILNFJHIPJ, LELHOHFMKKF<TMRequest> PBEMKFFJNCL, TAction HKJBPIINLDG, Task OPGKMNECFLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4B07410", Offset = "0x4B06810", VA = "0x184B07410")]
	[AsyncStateMachine(typeof(global::CMFFENGIKEI<, , , , , , , , , >.KHNGDJBHLFO))]
	private Task HPMEFNHAKDB(TRoot DHHBNGOGOPD, TNetSys AOGHFPFODPB, TReceiver KNPJGAEAGFF, TAction HKJBPIINLDG, JEPNBGOLKMI LAJBFECIOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4B05E90", Offset = "0x4B05290", VA = "0x184B05E90")]
	private void AALLGHHGEJL(TRoot DHHBNGOGOPD, TNetSys AOGHFPFODPB, TReceiver KNPJGAEAGFF, LELHOHFMKKF<TMActor> HHILNFJHIPJ, TAction HKJBPIINLDG, bool PEFJAIAAABO, bool BMMHANFBMGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IHKNFHBFMNG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface HIGOGNLDGCK<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JOMLHEKKKBF(TNetSys MAFKOGKJLHL, TAction HKJBPIINLDG);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction IACPIOGFJAN(TNetSys MAFKOGKJLHL, TAction HKJBPIINLDG);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction AICKGBOAMBL(TNetSys MAFKOGKJLHL, TAction HKJBPIINLDG);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> MKAFMMHGHAF(TNetSys MAFKOGKJLHL, TAction HKJBPIINLDG);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] BLCJGJPEHDI(TNetSys MAFKOGKJLHL, TAction HKJBPIINLDG, int AACNBCIBKKO);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ILDKKEJIEOL(TNetSys MAFKOGKJLHL, TAction HKJBPIINLDG);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool LPDELGABFDN(TNetSys MAFKOGKJLHL, TAction HKJBPIINLDG);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool LHDBOGNLKEI(TNetSys MAFKOGKJLHL, TAction HKJBPIINLDG);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool DBNLPJFKFCK(TNetSys MAFKOGKJLHL, TAction HKJBPIINLDG);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool OOKDLFANCKC(TNetSys MAFKOGKJLHL, TAction HKJBPIINLDG);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool BBMLNJIDPHM(TNetSys MAFKOGKJLHL, TAction HKJBPIINLDG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface IKKIOMCOCJI<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps OHAJBHIGOBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps COKHFFGKKFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps LGBOEBJOHFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface HPMPJEGEOAD<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LELHOHFMKKF<TMActor> CKBPCLAPHJM(TReceiver KNPJGAEAGFF);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<IAPKJCHKLLD<object, HDKPGPNEBBO>> ANNLIAEODMB(TReceiver KNPJGAEAGFF, TAction HKJBPIINLDG);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] LBNLOBHGPMD(TReceiver KNPJGAEAGFF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface FDOCOIBDECJ<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PLBHFDABNKH(TRoot DHHBNGOGOPD);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int DGACIHDIDIJ(TRoot DHHBNGOGOPD);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int KINMPAKHFDJ(TRoot DHHBNGOGOPD);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int ILCINCHELLP(TRoot DHHBNGOGOPD);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PFGMOPMKHAF(TRoot DHHBNGOGOPD);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task FICNPGIMJNP(TRoot DHHBNGOGOPD, LELHOHFMKKF<TMActor> HHILNFJHIPJ, LELHOHFMKKF<TMRequest> PBEMKFFJNCL, TAction HKJBPIINLDG, bool LCDHLKMDCDK = true);
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
