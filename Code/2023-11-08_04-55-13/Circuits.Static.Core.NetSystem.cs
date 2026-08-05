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
public struct CCJCJCKPCEM<TPartialAction, TFullAction, TDeps> where TDeps : ECCKFNKMNKK.JPHKCLADEDK<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] MNIMNOFCDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int GGMIEIBGKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps OFCAAKMDICP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x379CFE0", Offset = "0x379BDE0", VA = "0x18379CFE0")]
	internal CCJCJCKPCEM(TPartialAction[] AJCABDCFOEG, int OANOKMEEMGK, TDeps IFPKGKPDGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x379CF80", Offset = "0x379BD80", VA = "0x18379CF80")]
	public static CCJCJCKPCEM<TPartialAction, TFullAction, TDeps> FMIHPEHEFKO(TDeps IFPKGKPDGBH)
	{
		return default(CCJCJCKPCEM<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ECCKFNKMNKK
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface JPHKCLADEDK<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FAGFELNNIND([In] TPartialAction ILHMAPEOGND);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction CCFHNALPKFP(TPartialAction[] OLBHJJGFBGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23A2780", Offset = "0x23A1580", VA = "0x1823A2780")]
	public static FGFONOFPPEN<TFullAction> BHMECBGICMA<TFullAction, TPartialAction, TDeps>(this CCJCJCKPCEM<TPartialAction, TFullAction, TDeps> HLCOOGAGOEK, TPartialAction ILHMAPEOGND) where TDeps : JPHKCLADEDK<TPartialAction, TFullAction>
	{
		return default(FGFONOFPPEN<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct ACKCOIBFPMC<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : CCPDMGHOCKH.FNMFDKHNHGP<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] JDDPKHEFIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int GPMEANNENCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps OFCAAKMDICP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x379CFE0", Offset = "0x379BDE0", VA = "0x18379CFE0")]
	internal ACKCOIBFPMC(TPartialSnapshot[] KFFHEJIFCEF, int BECNOADOPIN, TDeps IFPKGKPDGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x379CF80", Offset = "0x379BD80", VA = "0x18379CF80")]
	public static ACKCOIBFPMC<TPartialSnapshot, TFullSnapshot, TDeps> FMIHPEHEFKO(TDeps IFPKGKPDGBH)
	{
		return default(ACKCOIBFPMC<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CCPDMGHOCKH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface FNMFDKHNHGP<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KJPIDHJFGBA([In] TPartialSnapshot ANKNALCPMGM);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot HOPCHPHAJPA(TPartialSnapshot[] JPANKKDAMMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2312500", Offset = "0x2311300", VA = "0x182312500")]
	public static FGFONOFPPEN<TFullSnapshot> BHMECBGICMA<TFullSnapshot, TPartialSnapshot, TDeps>(this ACKCOIBFPMC<TPartialSnapshot, TFullSnapshot, TDeps> HLCOOGAGOEK, TPartialSnapshot ANKNALCPMGM) where TDeps : FNMFDKHNHGP<TPartialSnapshot, TFullSnapshot>
	{
		return default(FGFONOFPPEN<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x23128B0", Offset = "0x23116B0", VA = "0x1823128B0")]
	public static bool KOMNEEGNGID<TPartialSnapshot, TFullSnapshot, TDeps>(this ACKCOIBFPMC<TPartialSnapshot, TFullSnapshot, TDeps> HLCOOGAGOEK, TPartialSnapshot ANKNALCPMGM) where TDeps : FNMFDKHNHGP<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class CEFJIMECGGN : JLMPFOOAOBO
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1CBC580", Offset = "0x1CBB380", VA = "0x181CBC580", Slot = "7")]
	public override string BCJNMAHEGJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1CBC5B0", Offset = "0x1CBB3B0", VA = "0x181CBC5B0")]
	public CEFJIMECGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class OKBHFOCELKM<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : KJPMCEAMKON.MDFHIHJLGEH<TAction, TNetSys> where TReceiverDeps : KJPMCEAMKON.PAHELDENMKD<TMActor, TAction, TReceiver> where TRootDeps : KJPMCEAMKON.OBBBJJGOPEB<TMRequest, TMActor, TAction, TRoot> where TDeps : KJPMCEAMKON.JPFLHEDAICC<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface AAKLFKJKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KNEGABEEECI([In] EFFPFBGFCJB<object, FCBFPODNPBP> OKONIBAEEBP);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NLNEBELPOLD();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		EFFPFBGFCJB<object, FCBFPODNPBP> BGJEICLGEJB();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NMEINNLCELL(Exception OLGCAAMGCBK);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class GKGPJKDNODB : AAKLFKJKJBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<EFFPFBGFCJB<object, FCBFPODNPBP>> JGIFCDLFIPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<EFFPFBGFCJB<object, PILBJIJHFMF>> CHBJHBLKHFE;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x35E6EE0", Offset = "0x35E5CE0", VA = "0x1835E6EE0")]
		private GKGPJKDNODB(TaskCompletionSource<EFFPFBGFCJB<object, FCBFPODNPBP>> MEFJIINLLLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x342E650", Offset = "0x342D450", VA = "0x18342E650")]
		public static GKGPJKDNODB FMIHPEHEFKO(TaskCompletionSource<EFFPFBGFCJB<object, FCBFPODNPBP>> MEFJIINLLLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x35E6A60", Offset = "0x35E5860", VA = "0x1835E6A60")]
		public void KNEGABEEECI([In] EFFPFBGFCJB<object, FCBFPODNPBP> OKONIBAEEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x35E6C60", Offset = "0x35E5A60", VA = "0x1835E6C60", Slot = "5")]
		public void NLNEBELPOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x35E68E0", Offset = "0x35E56E0", VA = "0x1835E68E0", Slot = "6")]
		public EFFPFBGFCJB<object, FCBFPODNPBP> BGJEICLGEJB()
		{
			return default(EFFPFBGFCJB<object, FCBFPODNPBP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x35E6E80", Offset = "0x35E5C80", VA = "0x1835E6E80", Slot = "7")]
		public void NMEINNLCELL(Exception OLGCAAMGCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x35E6A40", Offset = "0x35E5840", VA = "0x1835E6A40", Slot = "4")]
		private void CKCMPHDGBBD([In] EFFPFBGFCJB<object, FCBFPODNPBP> OKONIBAEEBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class IKIGIBMIAJC : AAKLFKJKJBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<EFFPFBGFCJB<object, FCBFPODNPBP>> JGIFCDLFIPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EFFPFBGFCJB<object, FCBFPODNPBP> HMPNJDFPDEK;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76FDF0", VA = "0x180770FF0")]
		private IKIGIBMIAJC(TaskCompletionSource<EFFPFBGFCJB<object, FCBFPODNPBP>> MEFJIINLLLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x342E650", Offset = "0x342D450", VA = "0x18342E650")]
		public static IKIGIBMIAJC FMIHPEHEFKO(TaskCompletionSource<EFFPFBGFCJB<object, FCBFPODNPBP>> MEFJIINLLLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x375EBC0", Offset = "0x375D9C0", VA = "0x18375EBC0")]
		public void KNEGABEEECI([In] EFFPFBGFCJB<object, FCBFPODNPBP> OKONIBAEEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x375EBE0", Offset = "0x375D9E0", VA = "0x18375EBE0", Slot = "5")]
		public void NLNEBELPOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C95C0", Offset = "0x9C83C0", VA = "0x1809C95C0", Slot = "6")]
		public EFFPFBGFCJB<object, FCBFPODNPBP> BGJEICLGEJB()
		{
			return default(EFFPFBGFCJB<object, FCBFPODNPBP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x375ED00", Offset = "0x375DB00", VA = "0x18375ED00", Slot = "7")]
		public void NMEINNLCELL(Exception OLGCAAMGCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x35E6A40", Offset = "0x35E5840", VA = "0x1835E6A40", Slot = "4")]
		private void CKCMPHDGBBD([In] EFFPFBGFCJB<object, FCBFPODNPBP> OKONIBAEEBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class NMGJEBFMHBI : AAKLFKJKJBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<EFFPFBGFCJB<object, FCBFPODNPBP>> CHBJHBLKHFE;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D24DC0", Offset = "0x3D23BC0", VA = "0x183D24DC0")]
		private NMGJEBFMHBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x35EB710", Offset = "0x35EA510", VA = "0x1835EB710")]
		public static NMGJEBFMHBI FMIHPEHEFKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3D24AF0", Offset = "0x3D238F0", VA = "0x183D24AF0")]
		public void KNEGABEEECI([In] EFFPFBGFCJB<object, FCBFPODNPBP> OKONIBAEEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		public void NLNEBELPOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3D24A30", Offset = "0x3D23830", VA = "0x183D24A30", Slot = "6")]
		public EFFPFBGFCJB<object, FCBFPODNPBP> BGJEICLGEJB()
		{
			return default(EFFPFBGFCJB<object, FCBFPODNPBP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3D24CE0", Offset = "0x3D23AE0", VA = "0x183D24CE0", Slot = "7")]
		[DLHFDGJCDNB("This may be terminal and should probably do more than discarding the exception.")]
		public void NMEINNLCELL(Exception OLGCAAMGCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x35E6A40", Offset = "0x35E5840", VA = "0x1835E6A40", Slot = "4")]
		private void CKCMPHDGBBD([In] EFFPFBGFCJB<object, FCBFPODNPBP> OKONIBAEEBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class GMLNHDJOIIN : AAKLFKJKJBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EFFPFBGFCJB<object, FCBFPODNPBP> HMPNJDFPDEK;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		private GMLNHDJOIIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x35EB710", Offset = "0x35EA510", VA = "0x1835EB710")]
		public static GMLNHDJOIIN FMIHPEHEFKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x35EB7D0", Offset = "0x35EA5D0", VA = "0x1835EB7D0")]
		public void KNEGABEEECI([In] EFFPFBGFCJB<object, FCBFPODNPBP> OKONIBAEEBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
		public void NLNEBELPOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAFA210", Offset = "0xAF9010", VA = "0x180AFA210", Slot = "6")]
		public EFFPFBGFCJB<object, FCBFPODNPBP> BGJEICLGEJB()
		{
			return default(EFFPFBGFCJB<object, FCBFPODNPBP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x35EB7F0", Offset = "0x35EA5F0", VA = "0x1835EB7F0", Slot = "7")]
		[DLHFDGJCDNB("This may be terminal and should probably do more than discarding the exception.")]
		public void NMEINNLCELL(Exception OLGCAAMGCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x35E6A40", Offset = "0x35E5840", VA = "0x1835E6A40", Slot = "4")]
		private void CKCMPHDGBBD([In] EFFPFBGFCJB<object, FCBFPODNPBP> OKONIBAEEBP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct CIAKAMFMEGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<EFFPFBGFCJB<object, FCBFPODNPBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::OKBHFOCELKM<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public MLOCHKHLPON<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<EFFPFBGFCJB<object, FCBFPODNPBP>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<EFFPFBGFCJB<object, FCBFPODNPBP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x49B8BC0", Offset = "0x49B79C0", VA = "0x1849B8BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x49B9670", Offset = "0x49B8470", VA = "0x1849B9670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PKFIIPBJIFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<EFFPFBGFCJB<object, FCBFPODNPBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::OKBHFOCELKM<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MLOCHKHLPON<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<EFFPFBGFCJB<object, FCBFPODNPBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3EFD4B0", Offset = "0x3EFC2B0", VA = "0x183EFD4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3EFDD30", Offset = "0x3EFCB30", VA = "0x183EFDD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct NILDMNAEJPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<EFFPFBGFCJB<object, FCBFPODNPBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::OKBHFOCELKM<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public MLOCHKHLPON<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public MLOCHKHLPON<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<EFFPFBGFCJB<object, FCBFPODNPBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3D19870", Offset = "0x3D18670", VA = "0x183D19870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3D19F90", Offset = "0x3D18D90", VA = "0x183D19F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct BDDEJHOKAHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<EFFPFBGFCJB<object, FCBFPODNPBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::OKBHFOCELKM<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public MLOCHKHLPON<TMActor> senderId;

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
		public MLOCHKHLPON<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private AAKLFKJKJBP <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4561B90", Offset = "0x4560990", VA = "0x184561B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4562750", Offset = "0x4561550", VA = "0x184562750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct HJHMJICOLLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::OKBHFOCELKM<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public AAKLFKJKJBP completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private AAKLFKJKJBP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<EFFPFBGFCJB<object, FCBFPODNPBP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3654CF0", Offset = "0x3653AF0", VA = "0x183654CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3656AA0", Offset = "0x36558A0", VA = "0x183656AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps OFCAAKMDICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<MLOCHKHLPON<TMRequest>, TaskCompletionSource<EFFPFBGFCJB<object, FCBFPODNPBP>>> LIKGACMIKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KEAPKEIMMOG<TMRequest> PJMHNKDFFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int EBLEFPPGFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task FIDHKCAHEOF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps IBHJOFJLIDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3E07B00", Offset = "0x3E06900", VA = "0x183E07B00")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps ABPKLEOKPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3E07A30", Offset = "0x3E06830", VA = "0x183E07A30")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps NBDKPJMJEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3E067D0", Offset = "0x3E055D0", VA = "0x183E067D0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BFDDAMFGOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1095230", Offset = "0x1094030", VA = "0x181095230")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1095240", Offset = "0x1094040", VA = "0x181095240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OEPNLDKLMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1BA71A0", Offset = "0x1BA5FA0", VA = "0x181BA71A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1BA7480", Offset = "0x1BA6280", VA = "0x181BA7480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OFPMAMMPCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x775E40", Offset = "0x774C40", VA = "0x180775E40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3E08630", Offset = "0x3E07430", VA = "0x183E08630")]
	public OKBHFOCELKM(TDeps IFPKGKPDGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3E08310", Offset = "0x3E07110", VA = "0x183E08310")]
	public Task<EFFPFBGFCJB<object, FCBFPODNPBP>> OLMIIOMKEEH(TRoot NANDDCHCAEB, TNetSys BBJFNABJNCL, MLOCHKHLPON<TMActor> FCHDABJLAPO, TAction CBNAIFNPGEI, bool LIKFPADOMED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3E07B30", Offset = "0x3E06930", VA = "0x183E07B30")]
	[AsyncStateMachine(typeof(global::OKBHFOCELKM<, , , , , , , , , >.CIAKAMFMEGE))]
	private Task<EFFPFBGFCJB<object, FCBFPODNPBP>> OLMIIOMKEEH(TRoot NANDDCHCAEB, MLOCHKHLPON<TMActor> FCHDABJLAPO, TAction CBNAIFNPGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3E06CA0", Offset = "0x3E05AA0", VA = "0x183E06CA0")]
	[AsyncStateMachine(typeof(global::OKBHFOCELKM<, , , , , , , , , >.PKFIIPBJIFF))]
	private Task<EFFPFBGFCJB<object, FCBFPODNPBP>> HBIHLIEDCMK(TRoot NANDDCHCAEB, MLOCHKHLPON<TMActor> FCHDABJLAPO, TAction[] FIILECCPHMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3E069D0", Offset = "0x3E057D0", VA = "0x183E069D0")]
	[AsyncStateMachine(typeof(global::OKBHFOCELKM<, , , , , , , , , >.NILDMNAEJPE))]
	public Task<EFFPFBGFCJB<object, FCBFPODNPBP>> FBGFJLJFFFM(TRoot NANDDCHCAEB, TNetSys NKOHPFLPNLD, TReceiver IOKGEJINEJL, MLOCHKHLPON<TMActor> FCHDABJLAPO, MLOCHKHLPON<TMRequest> ALCCPEOPNBP, TAction CBNAIFNPGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3E070B0", Offset = "0x3E05EB0", VA = "0x183E070B0")]
	[AsyncStateMachine(typeof(global::OKBHFOCELKM<, , , , , , , , , >.BDDEJHOKAHJ))]
	private Task<EFFPFBGFCJB<object, FCBFPODNPBP>> JJHGGJGPBCI(TRoot NANDDCHCAEB, TNetSys NKOHPFLPNLD, TReceiver IOKGEJINEJL, MLOCHKHLPON<TMActor> FCHDABJLAPO, MLOCHKHLPON<TMRequest> ALCCPEOPNBP, TAction CBNAIFNPGEI, Task JJPCHIFBJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3E06E00", Offset = "0x3E05C00", VA = "0x183E06E00")]
	[AsyncStateMachine(typeof(global::OKBHFOCELKM<, , , , , , , , , >.HJHMJICOLLA))]
	private Task INPHEJEONLO(TRoot NANDDCHCAEB, TNetSys NKOHPFLPNLD, TReceiver IOKGEJINEJL, TAction CBNAIFNPGEI, AAKLFKJKJBP PBMHAAIIBJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3E07750", Offset = "0x3E06550", VA = "0x183E07750")]
	private void LOJGBLPLOHK(TRoot NANDDCHCAEB, TNetSys NKOHPFLPNLD, TReceiver IOKGEJINEJL, MLOCHKHLPON<TMActor> FCHDABJLAPO, TAction CBNAIFNPGEI, bool BGBGKOGJIHH, bool DCHNHJDJELC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KJPMCEAMKON
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface MDFHIHJLGEH<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LIBKIBIHNBJ(TNetSys AEIDGNLPNDP, TAction CBNAIFNPGEI);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction DJJMKIJODMI(TNetSys AEIDGNLPNDP, TAction CBNAIFNPGEI);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction LCEJAHFIKLG(TNetSys AEIDGNLPNDP, TAction CBNAIFNPGEI);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> CFKFGGAPOPP(TNetSys AEIDGNLPNDP, TAction CBNAIFNPGEI);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] GNOGPAKFPGL(TNetSys AEIDGNLPNDP, TAction CBNAIFNPGEI, int EMNFOINGDGP);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool EBBPEEKDMJE(TNetSys AEIDGNLPNDP, TAction CBNAIFNPGEI);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool IDDILEOCCON(TNetSys AEIDGNLPNDP, TAction CBNAIFNPGEI);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool PPDCKCCFEML(TNetSys AEIDGNLPNDP, TAction CBNAIFNPGEI);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool LDMMOGNJMFN(TNetSys AEIDGNLPNDP, TAction CBNAIFNPGEI);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool OOPDDEGKMKN(TNetSys AEIDGNLPNDP, TAction CBNAIFNPGEI);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool BAEIHHMBMNG(TNetSys AEIDGNLPNDP, TAction CBNAIFNPGEI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface JPFLHEDAICC<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps IBHJOFJLIDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps NBDKPJMJEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps ABPKLEOKPGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface PAHELDENMKD<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MLOCHKHLPON<TMActor> FEKPPCOIENH(TReceiver IOKGEJINEJL);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<EFFPFBGFCJB<object, FCBFPODNPBP>> FBGFJLJFFFM(TReceiver IOKGEJINEJL, TAction CBNAIFNPGEI);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] LAKICCHLHNA(TReceiver IOKGEJINEJL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface OBBBJJGOPEB<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LJIDCCENLDE(TRoot NANDDCHCAEB);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int LAAMBCCPNLL(TRoot NANDDCHCAEB);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int MKAAHNCOOKF(TRoot NANDDCHCAEB);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int JAIIAPGJKPC(TRoot NANDDCHCAEB);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HOJAMODCJFA(TRoot NANDDCHCAEB);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task OLMIIOMKEEH(TRoot NANDDCHCAEB, MLOCHKHLPON<TMActor> FCHDABJLAPO, MLOCHKHLPON<TMRequest> ALCCPEOPNBP, TAction CBNAIFNPGEI, bool NGCOBBNFEAE = true);
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
