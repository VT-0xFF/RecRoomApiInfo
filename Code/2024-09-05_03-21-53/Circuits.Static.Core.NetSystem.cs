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
public struct EPHCHAFCMJN<TPartialAction, TFullAction, TDeps> where TDeps : GBFHIILLPPM.FHNGFMAJJPP<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] PFIKBINABNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int EPBKCGAOFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps OIIMCPAPNGD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x39B06E0", Offset = "0x39AF0E0", VA = "0x1839B06E0")]
	internal EPHCHAFCMJN(TPartialAction[] AEAGMIKIOOI, int KNCJBECCFFH, TDeps JPDKLLDNBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x39B05C0", Offset = "0x39AEFC0", VA = "0x1839B05C0")]
	public static EPHCHAFCMJN<TPartialAction, TFullAction, TDeps> MMKGNMBHOIH(TDeps JPDKLLDNBGD)
	{
		return default(EPHCHAFCMJN<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GBFHIILLPPM
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface FHNGFMAJJPP<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EHFFPDNMOAK([In] TPartialAction EAPHMCPHHID);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction BJAEMBONFCI(TPartialAction[] OOKFMJBGDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2C806D0", Offset = "0x2C7F0D0", VA = "0x182C806D0")]
	public static MKGNLHEPBHJ<TFullAction> LKLNBMMDNDF<TFullAction, TPartialAction, TDeps>(this EPHCHAFCMJN<TPartialAction, TFullAction, TDeps> PECHDAFMNOO, TPartialAction EAPHMCPHHID) where TDeps : FHNGFMAJJPP<TPartialAction, TFullAction>
	{
		return default(MKGNLHEPBHJ<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BLDJLBDICJP<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : ICPGHKDAIBI.CBBAIOAJAHJ<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] DFBGAAIPDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int NFAEAADGJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps OIIMCPAPNGD;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x39B06E0", Offset = "0x39AF0E0", VA = "0x1839B06E0")]
	internal BLDJLBDICJP(TPartialSnapshot[] HJFDNPMLNOI, int FPNLDNMMBAN, TDeps JPDKLLDNBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x39B05C0", Offset = "0x39AEFC0", VA = "0x1839B05C0")]
	public static BLDJLBDICJP<TPartialSnapshot, TFullSnapshot, TDeps> MMKGNMBHOIH(TDeps JPDKLLDNBGD)
	{
		return default(BLDJLBDICJP<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ICPGHKDAIBI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface CBBAIOAJAHJ<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DKNOOLPMHNK([In] TPartialSnapshot PMGGDOBDIHE);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot DKBHDLBEJGD(TPartialSnapshot[] GGGGOKFIPCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2CCCC10", Offset = "0x2CCB610", VA = "0x182CCCC10")]
	public static MKGNLHEPBHJ<TFullSnapshot> LKLNBMMDNDF<TFullSnapshot, TPartialSnapshot, TDeps>(this BLDJLBDICJP<TPartialSnapshot, TFullSnapshot, TDeps> PECHDAFMNOO, TPartialSnapshot PMGGDOBDIHE) where TDeps : CBBAIOAJAHJ<TPartialSnapshot, TFullSnapshot>
	{
		return default(MKGNLHEPBHJ<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2CCCD90", Offset = "0x2CCB790", VA = "0x182CCCD90")]
	public static bool MNACKDCPJAB<TPartialSnapshot, TFullSnapshot, TDeps>(this BLDJLBDICJP<TPartialSnapshot, TFullSnapshot, TDeps> PECHDAFMNOO, TPartialSnapshot PMGGDOBDIHE) where TDeps : CBBAIOAJAHJ<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class FOPEBKILFFG : LAEJIKKOMKB
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x20CD4A0", Offset = "0x20CBEA0", VA = "0x1820CD4A0", Slot = "7")]
	public override string PDDPMMJGDDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x20CD4D0", Offset = "0x20CBED0", VA = "0x1820CD4D0")]
	public FOPEBKILFFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class ADAEAKENILF<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : ANNAAHFLNJO.DKEFHINECGE<TAction, TNetSys> where TReceiverDeps : ANNAAHFLNJO.MGOCHGGOOOO<TAction, TReceiver> where TRootDeps : ANNAAHFLNJO.HDMJGODHOGD<TMRequest, TAction, TRoot> where TDeps : ANNAAHFLNJO.IKEDBNPOMLG<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface LJLCFEEKCNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MGGHNMGOBNA([In] MOKFKOEPKDB<object, JNDPMGELPNI> DFEFBOIIPKP);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ANKMGCBEANH();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MOKFKOEPKDB<object, JNDPMGELPNI> IAPEPCOFJLB();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CEGMOOHGDDN(Exception PBKGKGDHMFI);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class IFCKCLIPCIC : LJLCFEEKCNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<MOKFKOEPKDB<object, JNDPMGELPNI>> FEJFBJBFIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<MOKFKOEPKDB<object, NLHAIFJDFEL>> COCMMAAHHFI;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4008DF0", Offset = "0x40077F0", VA = "0x184008DF0")]
		private IFCKCLIPCIC(TaskCompletionSource<MOKFKOEPKDB<object, JNDPMGELPNI>> LEENFLIPNGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3D38DB0", Offset = "0x3D377B0", VA = "0x183D38DB0")]
		public static IFCKCLIPCIC MMKGNMBHOIH(TaskCompletionSource<MOKFKOEPKDB<object, JNDPMGELPNI>> LEENFLIPNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4008CD0", Offset = "0x40076D0", VA = "0x184008CD0")]
		public void MGGHNMGOBNA([In] MOKFKOEPKDB<object, JNDPMGELPNI> DFEFBOIIPKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x40087D0", Offset = "0x40071D0", VA = "0x1840087D0", Slot = "5")]
		public void ANKMGCBEANH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4008A50", Offset = "0x4007450", VA = "0x184008A50", Slot = "6")]
		public MOKFKOEPKDB<object, JNDPMGELPNI> IAPEPCOFJLB()
		{
			return default(MOKFKOEPKDB<object, JNDPMGELPNI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x40089F0", Offset = "0x40073F0", VA = "0x1840089F0", Slot = "7")]
		public void CEGMOOHGDDN(Exception PBKGKGDHMFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3952760", Offset = "0x3951160", VA = "0x183952760", Slot = "4")]
		private void CCBIJHAMBHJ([In] MOKFKOEPKDB<object, JNDPMGELPNI> DFEFBOIIPKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class FDMDNBMBMJK : LJLCFEEKCNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<MOKFKOEPKDB<object, JNDPMGELPNI>> FEJFBJBFIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MOKFKOEPKDB<object, JNDPMGELPNI> EGHJEFPJIPE;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
		private FDMDNBMBMJK(TaskCompletionSource<MOKFKOEPKDB<object, JNDPMGELPNI>> LEENFLIPNGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3D38DB0", Offset = "0x3D377B0", VA = "0x183D38DB0")]
		public static FDMDNBMBMJK MMKGNMBHOIH(TaskCompletionSource<MOKFKOEPKDB<object, JNDPMGELPNI>> LEENFLIPNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3D38D90", Offset = "0x3D37790", VA = "0x183D38D90")]
		public void MGGHNMGOBNA([In] MOKFKOEPKDB<object, JNDPMGELPNI> DFEFBOIIPKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3D38C70", Offset = "0x3D37670", VA = "0x183D38C70", Slot = "5")]
		public void ANKMGCBEANH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xDCD700", Offset = "0xDCC100", VA = "0x180DCD700", Slot = "6")]
		public MOKFKOEPKDB<object, JNDPMGELPNI> IAPEPCOFJLB()
		{
			return default(MOKFKOEPKDB<object, JNDPMGELPNI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3D38CD0", Offset = "0x3D376D0", VA = "0x183D38CD0", Slot = "7")]
		public void CEGMOOHGDDN(Exception PBKGKGDHMFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3952760", Offset = "0x3951160", VA = "0x183952760", Slot = "4")]
		private void CCBIJHAMBHJ([In] MOKFKOEPKDB<object, JNDPMGELPNI> DFEFBOIIPKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class EOHBDJIHHPH : LJLCFEEKCNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<MOKFKOEPKDB<object, JNDPMGELPNI>> COCMMAAHHFI;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x39AF6A0", Offset = "0x39AE0A0", VA = "0x1839AF6A0")]
		private EOHBDJIHHPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3952840", Offset = "0x3951240", VA = "0x183952840")]
		public static EOHBDJIHHPH MMKGNMBHOIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x39AF4E0", Offset = "0x39ADEE0", VA = "0x1839AF4E0")]
		public void MGGHNMGOBNA([In] MOKFKOEPKDB<object, JNDPMGELPNI> DFEFBOIIPKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void ANKMGCBEANH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x39AF480", Offset = "0x39ADE80", VA = "0x1839AF480", Slot = "6")]
		public MOKFKOEPKDB<object, JNDPMGELPNI> IAPEPCOFJLB()
		{
			return default(MOKFKOEPKDB<object, JNDPMGELPNI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x39AF3D0", Offset = "0x39ADDD0", VA = "0x1839AF3D0", Slot = "7")]
		[OIGNFCKIMEJ("This may be terminal and should probably do more than discarding the exception.")]
		public void CEGMOOHGDDN(Exception PBKGKGDHMFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3952760", Offset = "0x3951160", VA = "0x183952760", Slot = "4")]
		private void CCBIJHAMBHJ([In] MOKFKOEPKDB<object, JNDPMGELPNI> DFEFBOIIPKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class EBHJIBHKPCH : LJLCFEEKCNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private MOKFKOEPKDB<object, JNDPMGELPNI> EGHJEFPJIPE;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		private EBHJIBHKPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3952840", Offset = "0x3951240", VA = "0x183952840")]
		public static EBHJIBHKPCH MMKGNMBHOIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1940030", Offset = "0x193EA30", VA = "0x181940030")]
		public void MGGHNMGOBNA([In] MOKFKOEPKDB<object, JNDPMGELPNI> DFEFBOIIPKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void ANKMGCBEANH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x94B360", Offset = "0x949D60", VA = "0x18094B360", Slot = "6")]
		public MOKFKOEPKDB<object, JNDPMGELPNI> IAPEPCOFJLB()
		{
			return default(MOKFKOEPKDB<object, JNDPMGELPNI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x39527A0", Offset = "0x39511A0", VA = "0x1839527A0", Slot = "7")]
		[OIGNFCKIMEJ("This may be terminal and should probably do more than discarding the exception.")]
		public void CEGMOOHGDDN(Exception PBKGKGDHMFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3952760", Offset = "0x3951160", VA = "0x183952760", Slot = "4")]
		private void CCBIJHAMBHJ([In] MOKFKOEPKDB<object, JNDPMGELPNI> DFEFBOIIPKP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LAPAAGMBILP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<object, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public ADAEAKENILF<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public MLGFJIHMDCD<COIKDNADKKF> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<MOKFKOEPKDB<object, JNDPMGELPNI>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<MOKFKOEPKDB<object, JNDPMGELPNI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x441AB20", Offset = "0x4419520", VA = "0x18441AB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x441B640", Offset = "0x441A040", VA = "0x18441B640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HIJEHMHLAFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<object, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public ADAEAKENILF<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MLGFJIHMDCD<COIKDNADKKF> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<MOKFKOEPKDB<object, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3EE7EA0", Offset = "0x3EE68A0", VA = "0x183EE7EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3EE8390", Offset = "0x3EE6D90", VA = "0x183EE8390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct ILEGEGBNIHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<object, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ADAEAKENILF<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public MLGFJIHMDCD<COIKDNADKKF> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public MLGFJIHMDCD<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<MOKFKOEPKDB<object, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x401DF30", Offset = "0x401C930", VA = "0x18401DF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x401E600", Offset = "0x401D000", VA = "0x18401E600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct JMNHJKOBHGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<object, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public ADAEAKENILF<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public MLGFJIHMDCD<COIKDNADKKF> senderId;

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
		public MLGFJIHMDCD<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private LJLCFEEKCNC <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4237FE0", Offset = "0x42369E0", VA = "0x184237FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4239AF0", Offset = "0x42384F0", VA = "0x184239AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct KMPAFCMMIJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ADAEAKENILF<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public LJLCFEEKCNC completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private LJLCFEEKCNC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<MOKFKOEPKDB<object, JNDPMGELPNI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x43918F0", Offset = "0x43902F0", VA = "0x1843918F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4393960", Offset = "0x4392360", VA = "0x184393960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps OIIMCPAPNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<MLGFJIHMDCD<TMRequest>, TaskCompletionSource<MOKFKOEPKDB<object, JNDPMGELPNI>>> AHGHBCIKALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private DIACJPLOIIA<TMRequest> GPNILCHEPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int FPAPGNMJDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task IOAGHOHGMGG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps COEPBHCFJON
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2B00", Offset = "0x3DC1500", VA = "0x183DC2B00")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps JEHELGBFFHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2770", Offset = "0x3DC1170", VA = "0x183DC2770")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps BGEHMOPLENO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2740", Offset = "0x3DC1140", VA = "0x183DC2740")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool PGNJFOJMPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xACBCC0", Offset = "0xACA6C0", VA = "0x180ACBCC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1599500", Offset = "0x1597F00", VA = "0x181599500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool ADBPDDONNBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x10BF1E0", Offset = "0x10BDBE0", VA = "0x1810BF1E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1F731F0", Offset = "0x1F71BF0", VA = "0x181F731F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NFNFLMBKJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8893F0", Offset = "0x887DF0", VA = "0x1808893F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3E20", Offset = "0x3DC2820", VA = "0x183DC3E20")]
	public ADAEAKENILF(TDeps JPDKLLDNBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DC2C90", Offset = "0x3DC1690", VA = "0x183DC2C90")]
	public Task<MOKFKOEPKDB<object, JNDPMGELPNI>> NCFIEFNHNBM(TRoot MGPJOGDJPHA, TNetSys GAECMMIFDFD, MLGFJIHMDCD<COIKDNADKKF> OBJEBLBNPFJ, TAction ENNGIICFMFD, bool PCMIMGJBICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3010", Offset = "0x3DC1A10", VA = "0x183DC3010")]
	[AsyncStateMachine(typeof(ADAEAKENILF<, , , , , , , , >.LAPAAGMBILP))]
	private Task<MOKFKOEPKDB<object, JNDPMGELPNI>> NCFIEFNHNBM(TRoot MGPJOGDJPHA, MLGFJIHMDCD<COIKDNADKKF> OBJEBLBNPFJ, TAction ENNGIICFMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3DC27F0", Offset = "0x3DC11F0", VA = "0x183DC27F0")]
	[AsyncStateMachine(typeof(ADAEAKENILF<, , , , , , , , >.HIJEHMHLAFM))]
	private Task<MOKFKOEPKDB<object, JNDPMGELPNI>> JIFLIEOCBEC(TRoot MGPJOGDJPHA, MLGFJIHMDCD<COIKDNADKKF> OBJEBLBNPFJ, TAction[] IKJNEEELGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1D00", Offset = "0x3DC0700", VA = "0x183DC1D00")]
	[AsyncStateMachine(typeof(ADAEAKENILF<, , , , , , , , >.ILEGEGBNIHC))]
	public Task<MOKFKOEPKDB<object, JNDPMGELPNI>> CKFJJMODHAE(TRoot MGPJOGDJPHA, TNetSys EOIGGONEMBN, TReceiver BKEICMBDHGB, MLGFJIHMDCD<COIKDNADKKF> OBJEBLBNPFJ, MLGFJIHMDCD<TMRequest> PDAJMLJLHIO, TAction ENNGIICFMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3B10", Offset = "0x3DC2510", VA = "0x183DC3B10")]
	[AsyncStateMachine(typeof(ADAEAKENILF<, , , , , , , , >.JMNHJKOBHGC))]
	private Task<MOKFKOEPKDB<object, JNDPMGELPNI>> PBNJCCFFHDD(TRoot MGPJOGDJPHA, TNetSys EOIGGONEMBN, TReceiver BKEICMBDHGB, MLGFJIHMDCD<COIKDNADKKF> OBJEBLBNPFJ, MLGFJIHMDCD<TMRequest> PDAJMLJLHIO, TAction ENNGIICFMFD, Task BAMHOCDBLHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3DC36D0", Offset = "0x3DC20D0", VA = "0x183DC36D0")]
	[AsyncStateMachine(typeof(ADAEAKENILF<, , , , , , , , >.KMPAFCMMIJE))]
	private Task OEOBAMBNADL(TRoot MGPJOGDJPHA, TNetSys EOIGGONEMBN, TReceiver BKEICMBDHGB, TAction ENNGIICFMFD, LJLCFEEKCNC OHMOLBCHFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3DC23C0", Offset = "0x3DC0DC0", VA = "0x183DC23C0")]
	private void FGGAMMMLFFI(TRoot MGPJOGDJPHA, TNetSys EOIGGONEMBN, TReceiver BKEICMBDHGB, MLGFJIHMDCD<COIKDNADKKF> OBJEBLBNPFJ, TAction ENNGIICFMFD, bool DBMDLEBKNAD, bool HOMLDDJCFFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ANNAAHFLNJO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface DKEFHINECGE<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JGBFLPLHHLJ(TNetSys MECLDEDDNIH, TAction ENNGIICFMFD);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction CKBJJJGPPEO(TNetSys MECLDEDDNIH, TAction ENNGIICFMFD);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction PJPJEMIDHMD(TNetSys MECLDEDDNIH, TAction ENNGIICFMFD);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> PBNJLJHGIGN(TNetSys MECLDEDDNIH, TAction ENNGIICFMFD);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] AIBIMLDJALO(TNetSys MECLDEDDNIH, TAction ENNGIICFMFD, int LMJFDJEJKKN);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LNFDJKKHEFH(TNetSys MECLDEDDNIH, TAction ENNGIICFMFD);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool BOLIHFNKIFL(TNetSys MECLDEDDNIH, TAction ENNGIICFMFD);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool BPAJHJBADAE(TNetSys MECLDEDDNIH, TAction ENNGIICFMFD);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool AJGJBFPEFBH(TNetSys MECLDEDDNIH, TAction ENNGIICFMFD);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool DBJAJEJAONM(TNetSys MECLDEDDNIH, TAction ENNGIICFMFD);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool FLPCILMLGCE(TNetSys MECLDEDDNIH, TAction ENNGIICFMFD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface IKEDBNPOMLG<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps COEPBHCFJON
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps BGEHMOPLENO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps JEHELGBFFHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface MGOCHGGOOOO<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MLGFJIHMDCD<COIKDNADKKF> NCLOOJOAJEP(TReceiver BKEICMBDHGB);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<MOKFKOEPKDB<object, JNDPMGELPNI>> CKFJJMODHAE(TReceiver BKEICMBDHGB, TAction ENNGIICFMFD);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] PCDILFHJIJL(TReceiver BKEICMBDHGB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface HDMJGODHOGD<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ACOCGGGKCEJ(TRoot MGPJOGDJPHA);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int EDEPNCNGFEC(TRoot MGPJOGDJPHA);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int BKBEEEHCEMG(TRoot MGPJOGDJPHA);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int DDIPHIBBEOF(TRoot MGPJOGDJPHA);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CHMIPOMEAIB(TRoot MGPJOGDJPHA);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task NCFIEFNHNBM(TRoot MGPJOGDJPHA, MLGFJIHMDCD<COIKDNADKKF> OBJEBLBNPFJ, MLGFJIHMDCD<TMRequest> PDAJMLJLHIO, TAction ENNGIICFMFD, bool DALIOIFJNCC = true);
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
