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
public struct LBCKJEKINCO<TPartialAction, TFullAction, TDeps> where TDeps : PILCKIPCACO.EBGKDLPBCGE<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] KKJNNPJNNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int OBHIIMKDAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps PIBJMGMHGME;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3DA7460", Offset = "0x3DA6260", VA = "0x183DA7460")]
	internal LBCKJEKINCO(TPartialAction[] NFJGAPHEMLO, int CMEHNKGMAPG, TDeps GLJEJHKFIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3DA7400", Offset = "0x3DA6200", VA = "0x183DA7400")]
	public static LBCKJEKINCO<TPartialAction, TFullAction, TDeps> KHDJPNLCMFA(TDeps GLJEJHKFIBB)
	{
		return default(LBCKJEKINCO<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PILCKIPCACO
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface EBGKDLPBCGE<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ODGBHLIEIPO([In] TPartialAction DFKIOEPDPGL);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction KJLKCDAKNLA(TPartialAction[] BEMGKHDGBHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A546B0", Offset = "0x2A534B0", VA = "0x182A546B0")]
	public static BOEJMFJFKMA<TFullAction> JAMKGFGLELM<TFullAction, TPartialAction, TDeps>(this LBCKJEKINCO<TPartialAction, TFullAction, TDeps> ILACEKALGJH, TPartialAction DFKIOEPDPGL) where TDeps : EBGKDLPBCGE<TPartialAction, TFullAction>
	{
		return default(BOEJMFJFKMA<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct PCLMPPHGIAC<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : KLNBDHABOBM.EFINHECOPEB<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] HIKBDFHDOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int CHEMMMDDDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps PIBJMGMHGME;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3DA7460", Offset = "0x3DA6260", VA = "0x183DA7460")]
	internal PCLMPPHGIAC(TPartialSnapshot[] DCLFLLBGCOO, int FLIPBDIMHMB, TDeps GLJEJHKFIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3DA7400", Offset = "0x3DA6200", VA = "0x183DA7400")]
	public static PCLMPPHGIAC<TPartialSnapshot, TFullSnapshot, TDeps> KHDJPNLCMFA(TDeps GLJEJHKFIBB)
	{
		return default(PCLMPPHGIAC<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KLNBDHABOBM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface EFINHECOPEB<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FFIMOODAAJF([In] TPartialSnapshot GJDHHECFDLK);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot IIDPGEFNMAH(TPartialSnapshot[] LNLCGOLDOKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x294E5D0", Offset = "0x294D3D0", VA = "0x18294E5D0")]
	public static BOEJMFJFKMA<TFullSnapshot> JAMKGFGLELM<TFullSnapshot, TPartialSnapshot, TDeps>(this PCLMPPHGIAC<TPartialSnapshot, TFullSnapshot, TDeps> ILACEKALGJH, TPartialSnapshot GJDHHECFDLK) where TDeps : EFINHECOPEB<TPartialSnapshot, TFullSnapshot>
	{
		return default(BOEJMFJFKMA<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x294E490", Offset = "0x294D290", VA = "0x18294E490")]
	public static bool CNEKDLAILPP<TPartialSnapshot, TFullSnapshot, TDeps>(this PCLMPPHGIAC<TPartialSnapshot, TFullSnapshot, TDeps> ILACEKALGJH, TPartialSnapshot GJDHHECFDLK) where TDeps : EFINHECOPEB<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class DBANGCFJHPM : IPEMGGHMFOC
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E40DF0", Offset = "0x1E3FBF0", VA = "0x181E40DF0", Slot = "7")]
	public override string AGPNECGLHAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E40E20", Offset = "0x1E3FC20", VA = "0x181E40E20")]
	public DBANGCFJHPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MFOOAHOCEEH<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : BOKDBOHMDNE.GHDBNOAJGEF<TAction, TNetSys> where TReceiverDeps : BOKDBOHMDNE.JDHFOBOKNAK<TAction, TReceiver> where TRootDeps : BOKDBOHMDNE.GBOGAGBINHI<TMRequest, TAction, TRoot> where TDeps : BOKDBOHMDNE.AJNABLOGHDE<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface NMDACIIFBGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CCDDPDDCBHA([In] PJPNKGNAEHO<object, IIPPAHIAEHC> FJMMLPMLLGC);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NOGEAPKPLHG();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PJPNKGNAEHO<object, IIPPAHIAEHC> FFELCEEFMGJ();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KEOHPKKIEPJ(Exception MCKOJGJOINA);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class AOFNIMGEBID : NMDACIIFBGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<PJPNKGNAEHO<object, IIPPAHIAEHC>> DDAPKPOPEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<PJPNKGNAEHO<object, KFOBAHPPIAN>> DJCNNHFOFCJ;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3924380", Offset = "0x3923180", VA = "0x183924380")]
		private AOFNIMGEBID(TaskCompletionSource<PJPNKGNAEHO<object, IIPPAHIAEHC>> FFLBEEOPLEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3924100", Offset = "0x3922F00", VA = "0x183924100")]
		public static AOFNIMGEBID KHDJPNLCMFA(TaskCompletionSource<PJPNKGNAEHO<object, IIPPAHIAEHC>> FFLBEEOPLEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3923DC0", Offset = "0x3922BC0", VA = "0x183923DC0")]
		public void CCDDPDDCBHA([In] PJPNKGNAEHO<object, IIPPAHIAEHC> FJMMLPMLLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x39241C0", Offset = "0x3922FC0", VA = "0x1839241C0", Slot = "5")]
		public void NOGEAPKPLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3923EE0", Offset = "0x3922CE0", VA = "0x183923EE0", Slot = "6")]
		public PJPNKGNAEHO<object, IIPPAHIAEHC> FFELCEEFMGJ()
		{
			return default(PJPNKGNAEHO<object, IIPPAHIAEHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3924040", Offset = "0x3922E40", VA = "0x183924040", Slot = "7")]
		public void KEOHPKKIEPJ(Exception MCKOJGJOINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3923EC0", Offset = "0x3922CC0", VA = "0x183923EC0", Slot = "4")]
		private void DEPMLMGJDLP([In] PJPNKGNAEHO<object, IIPPAHIAEHC> FJMMLPMLLGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class IHOIBPONNJL : NMDACIIFBGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<PJPNKGNAEHO<object, IIPPAHIAEHC>> DDAPKPOPEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private PJPNKGNAEHO<object, IIPPAHIAEHC> MAAHFCFJCED;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
		private IHOIBPONNJL(TaskCompletionSource<PJPNKGNAEHO<object, IIPPAHIAEHC>> FFLBEEOPLEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3924100", Offset = "0x3922F00", VA = "0x183924100")]
		public static IHOIBPONNJL KHDJPNLCMFA(TaskCompletionSource<PJPNKGNAEHO<object, IIPPAHIAEHC>> FFLBEEOPLEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3A81AE0", Offset = "0x3A808E0", VA = "0x183A81AE0")]
		public void CCDDPDDCBHA([In] PJPNKGNAEHO<object, IIPPAHIAEHC> FJMMLPMLLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3A81C20", Offset = "0x3A80A20", VA = "0x183A81C20", Slot = "5")]
		public void NOGEAPKPLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAD5DB0", Offset = "0xAD4BB0", VA = "0x180AD5DB0", Slot = "6")]
		public PJPNKGNAEHO<object, IIPPAHIAEHC> FFELCEEFMGJ()
		{
			return default(PJPNKGNAEHO<object, IIPPAHIAEHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3A81B60", Offset = "0x3A80960", VA = "0x183A81B60", Slot = "7")]
		public void KEOHPKKIEPJ(Exception MCKOJGJOINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3923EC0", Offset = "0x3922CC0", VA = "0x183923EC0", Slot = "4")]
		private void DEPMLMGJDLP([In] PJPNKGNAEHO<object, IIPPAHIAEHC> FJMMLPMLLGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class DJJMGGLDJJG : NMDACIIFBGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<PJPNKGNAEHO<object, IIPPAHIAEHC>> DJCNNHFOFCJ;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5153ED0", Offset = "0x5152CD0", VA = "0x185153ED0")]
		private DJJMGGLDJJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3C322A0", Offset = "0x3C310A0", VA = "0x183C322A0")]
		public static DJJMGGLDJJG KHDJPNLCMFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5153B40", Offset = "0x5152940", VA = "0x185153B40")]
		public void CCDDPDDCBHA([In] PJPNKGNAEHO<object, IIPPAHIAEHC> FJMMLPMLLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		public void NOGEAPKPLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5153CE0", Offset = "0x5152AE0", VA = "0x185153CE0", Slot = "6")]
		public PJPNKGNAEHO<object, IIPPAHIAEHC> FFELCEEFMGJ()
		{
			return default(PJPNKGNAEHO<object, IIPPAHIAEHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5153DA0", Offset = "0x5152BA0", VA = "0x185153DA0", Slot = "7")]
		[AHPJOKJFFLN("This may be terminal and should probably do more than discarding the exception.")]
		public void KEOHPKKIEPJ(Exception MCKOJGJOINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3923EC0", Offset = "0x3922CC0", VA = "0x183923EC0", Slot = "4")]
		private void DEPMLMGJDLP([In] PJPNKGNAEHO<object, IIPPAHIAEHC> FJMMLPMLLGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class JIBBHMDMFDB : NMDACIIFBGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private PJPNKGNAEHO<object, IIPPAHIAEHC> MAAHFCFJCED;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		private JIBBHMDMFDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3C322A0", Offset = "0x3C310A0", VA = "0x183C322A0")]
		public static JIBBHMDMFDB KHDJPNLCMFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1553DB0", Offset = "0x1552BB0", VA = "0x181553DB0")]
		public void CCDDPDDCBHA([In] PJPNKGNAEHO<object, IIPPAHIAEHC> FJMMLPMLLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		public void NOGEAPKPLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83F660", Offset = "0x83E460", VA = "0x18083F660", Slot = "6")]
		public PJPNKGNAEHO<object, IIPPAHIAEHC> FFELCEEFMGJ()
		{
			return default(PJPNKGNAEHO<object, IIPPAHIAEHC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3C32200", Offset = "0x3C31000", VA = "0x183C32200", Slot = "7")]
		[AHPJOKJFFLN("This may be terminal and should probably do more than discarding the exception.")]
		public void KEOHPKKIEPJ(Exception MCKOJGJOINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3923EC0", Offset = "0x3922CC0", VA = "0x183923EC0", Slot = "4")]
		private void DEPMLMGJDLP([In] PJPNKGNAEHO<object, IIPPAHIAEHC> FJMMLPMLLGC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HBGDFLBMHMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public MFOOAHOCEEH<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public FCLFMGJFDHI<EEINONMICME> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<PJPNKGNAEHO<object, IIPPAHIAEHC>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x39A73D0", Offset = "0x39A61D0", VA = "0x1839A73D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x39A7880", Offset = "0x39A6680", VA = "0x1839A7880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct JGGFDJODKHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public MFOOAHOCEEH<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public FCLFMGJFDHI<EEINONMICME> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3C28EB0", Offset = "0x3C27CB0", VA = "0x183C28EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3C29780", Offset = "0x3C28580", VA = "0x183C29780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct EJCNMHHGHOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public MFOOAHOCEEH<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public FCLFMGJFDHI<EEINONMICME> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public FCLFMGJFDHI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3491370", Offset = "0x3490170", VA = "0x183491370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x34916C0", Offset = "0x34904C0", VA = "0x1834916C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct BKEHMGHCADI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public MFOOAHOCEEH<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public FCLFMGJFDHI<EEINONMICME> senderId;

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
		public FCLFMGJFDHI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private NMDACIIFBGL <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4859AB0", Offset = "0x48588B0", VA = "0x184859AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x485A640", Offset = "0x4859440", VA = "0x18485A640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct EFONDOECIPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public MFOOAHOCEEH<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public NMDACIIFBGL completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private NMDACIIFBGL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<PJPNKGNAEHO<object, IIPPAHIAEHC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x347E810", Offset = "0x347D610", VA = "0x18347E810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3482510", Offset = "0x3481310", VA = "0x183482510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps PIBJMGMHGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<FCLFMGJFDHI<TMRequest>, TaskCompletionSource<PJPNKGNAEHO<object, IIPPAHIAEHC>>> ECJLHADIMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private OMANJOINCBJ<TMRequest> CHNAEDMLADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int ACNJKEAFOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task NHFMNODLJJG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps FLJFJLFPCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B940", Offset = "0x3F8A740", VA = "0x183F8B940")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps KDNIPHBCEGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3F8BCA0", Offset = "0x3F8AAA0", VA = "0x183F8BCA0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps LPAIFDJFEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3F8B970", Offset = "0x3F8A770", VA = "0x183F8B970")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BCJBENDCAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDE69B0", Offset = "0xDE57B0", VA = "0x180DE69B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x11DB670", Offset = "0x11DA470", VA = "0x1811DB670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MFCEFDKFNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDD8A50", Offset = "0xDD7850", VA = "0x180DD8A50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1D09DC0", Offset = "0x1D08BC0", VA = "0x181D09DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int INOMCHMLNHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B5040", Offset = "0x7B3E40", VA = "0x1807B5040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C720", Offset = "0x3F8B520", VA = "0x183F8C720")]
	public MFOOAHOCEEH(TDeps GLJEJHKFIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3F8AE80", Offset = "0x3F89C80", VA = "0x183F8AE80")]
	public Task<PJPNKGNAEHO<object, IIPPAHIAEHC>> DENKDDOCPML(TRoot GDOPFEEANMP, TNetSys NLKGLJFPOON, FCLFMGJFDHI<EEINONMICME> HLJBHMIHLEB, TAction GOECALGCLOK, bool MGHJNOEIHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3F8B790", Offset = "0x3F8A590", VA = "0x183F8B790")]
	[AsyncStateMachine(typeof(MFOOAHOCEEH<, , , , , , , , >.HBGDFLBMHMA))]
	private Task<PJPNKGNAEHO<object, IIPPAHIAEHC>> DENKDDOCPML(TRoot GDOPFEEANMP, FCLFMGJFDHI<EEINONMICME> HLJBHMIHLEB, TAction GOECALGCLOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C030", Offset = "0x3F8AE30", VA = "0x183F8C030")]
	[AsyncStateMachine(typeof(MFOOAHOCEEH<, , , , , , , , >.JGGFDJODKHB))]
	private Task<PJPNKGNAEHO<object, IIPPAHIAEHC>> OJJMECMEEGE(TRoot GDOPFEEANMP, FCLFMGJFDHI<EEINONMICME> HLJBHMIHLEB, TAction[] LCADENKALAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C2F0", Offset = "0x3F8B0F0", VA = "0x183F8C2F0")]
	[AsyncStateMachine(typeof(MFOOAHOCEEH<, , , , , , , , >.EJCNMHHGHOA))]
	public Task<PJPNKGNAEHO<object, IIPPAHIAEHC>> OPMKJBCNHBL(TRoot GDOPFEEANMP, TNetSys DHNBAKEOPEO, TReceiver EEBGPMOCPBC, FCLFMGJFDHI<EEINONMICME> HLJBHMIHLEB, FCLFMGJFDHI<TMRequest> KOFEJGJFCPD, TAction GOECALGCLOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3F8BEB0", Offset = "0x3F8ACB0", VA = "0x183F8BEB0")]
	[AsyncStateMachine(typeof(MFOOAHOCEEH<, , , , , , , , >.BKEHMGHCADI))]
	private Task<PJPNKGNAEHO<object, IIPPAHIAEHC>> OEPEIPFEEKK(TRoot GDOPFEEANMP, TNetSys DHNBAKEOPEO, TReceiver EEBGPMOCPBC, FCLFMGJFDHI<EEINONMICME> HLJBHMIHLEB, FCLFMGJFDHI<TMRequest> KOFEJGJFCPD, TAction GOECALGCLOK, Task DKGIIEAJADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3F8B9F0", Offset = "0x3F8A7F0", VA = "0x183F8B9F0")]
	[AsyncStateMachine(typeof(MFOOAHOCEEH<, , , , , , , , >.EFONDOECIPG))]
	private Task LGNIAAGMGIH(TRoot GDOPFEEANMP, TNetSys DHNBAKEOPEO, TReceiver EEBGPMOCPBC, TAction GOECALGCLOK, NMDACIIFBGL GEPIAIMMHFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3F8A860", Offset = "0x3F89660", VA = "0x183F8A860")]
	private void BGJOLGGOFBG(TRoot GDOPFEEANMP, TNetSys DHNBAKEOPEO, TReceiver EEBGPMOCPBC, FCLFMGJFDHI<EEINONMICME> HLJBHMIHLEB, TAction GOECALGCLOK, bool DHBCOIKFCMO, bool FOFPBKBEAAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BOKDBOHMDNE
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface GHDBNOAJGEF<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GFCKCMFCMJC(TNetSys KGLNIBCAFHH, TAction GOECALGCLOK);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction AMFMIGPKKPH(TNetSys KGLNIBCAFHH, TAction GOECALGCLOK);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction CKJNGFJLHGD(TNetSys KGLNIBCAFHH, TAction GOECALGCLOK);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> GJPMCFMAJAB(TNetSys KGLNIBCAFHH, TAction GOECALGCLOK);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] HPOPKBLLOCM(TNetSys KGLNIBCAFHH, TAction GOECALGCLOK, int NAFBKGOLGHC);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool JMCAJLIDKPK(TNetSys KGLNIBCAFHH, TAction GOECALGCLOK);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool HBHAIJNJLJP(TNetSys KGLNIBCAFHH, TAction GOECALGCLOK);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool HDPOGHFDBCL(TNetSys KGLNIBCAFHH, TAction GOECALGCLOK);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool GOEEIBMCFJB(TNetSys KGLNIBCAFHH, TAction GOECALGCLOK);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool EAMNBDNHKMC(TNetSys KGLNIBCAFHH, TAction GOECALGCLOK);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool MICFLLPKLIL(TNetSys KGLNIBCAFHH, TAction GOECALGCLOK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface AJNABLOGHDE<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps FLJFJLFPCNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps LPAIFDJFEFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps KDNIPHBCEGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface JDHFOBOKNAK<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		FCLFMGJFDHI<EEINONMICME> ABLNIDHKOJK(TReceiver EEBGPMOCPBC);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<PJPNKGNAEHO<object, IIPPAHIAEHC>> OPMKJBCNHBL(TReceiver EEBGPMOCPBC, TAction GOECALGCLOK);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] MKKIDLIFJLG(TReceiver EEBGPMOCPBC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface GBOGAGBINHI<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PALBBCPDHHC(TRoot GDOPFEEANMP);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int BOEALMKLAGC(TRoot GDOPFEEANMP);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int EEPNAHNHPPF(TRoot GDOPFEEANMP);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int KIJLGFPJEBE(TRoot GDOPFEEANMP);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KDFNLLDCLAN(TRoot GDOPFEEANMP);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task DENKDDOCPML(TRoot GDOPFEEANMP, FCLFMGJFDHI<EEINONMICME> HLJBHMIHLEB, FCLFMGJFDHI<TMRequest> KOFEJGJFCPD, TAction GOECALGCLOK, bool BNMFKAFLIID = true);
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
