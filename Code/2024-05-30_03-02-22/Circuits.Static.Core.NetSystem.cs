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
public struct CNNGLNMMDDE<TPartialAction, TFullAction, TDeps> where TDeps : EFBKGMCBEKM.CBHIDGLBLLL<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] GAFJBEMPAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int KPBFJNDKNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps GJMNJKPIFIO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3A584B0", Offset = "0x3A576B0", VA = "0x183A584B0")]
	internal CNNGLNMMDDE(TPartialAction[] INEOCFEABIN, int DHLKCJJLHDL, TDeps LPEICIFHPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3A58450", Offset = "0x3A57650", VA = "0x183A58450")]
	public static CNNGLNMMDDE<TPartialAction, TFullAction, TDeps> EPPBEPCPNMI(TDeps LPEICIFHPLM)
	{
		return default(CNNGLNMMDDE<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EFBKGMCBEKM
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface CBHIDGLBLLL<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int CNHKCFODGIL([In] TPartialAction MEDLCKOFPJN);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction FDAPEHPOAIL(TPartialAction[] LHCIIGCBJBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2821C20", Offset = "0x2820E20", VA = "0x182821C20")]
	public static CPCJPGBNMLP<TFullAction> INBMDDFNMEM<TFullAction, TPartialAction, TDeps>(this CNNGLNMMDDE<TPartialAction, TFullAction, TDeps> CJKIBFNGPNM, TPartialAction MEDLCKOFPJN) where TDeps : CBHIDGLBLLL<TPartialAction, TFullAction>
	{
		return default(CPCJPGBNMLP<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HOOGKKFDBEN<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : PFAGPHOPEIA.JAGNEBMNBKD<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] FFDIHANKNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int CMGMHNHNBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps GJMNJKPIFIO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3A584F0", Offset = "0x3A576F0", VA = "0x183A584F0")]
	internal HOOGKKFDBEN(TPartialSnapshot[] LFNLBCPJPJJ, int DBMCAIPLMMK, TDeps LPEICIFHPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3A583E0", Offset = "0x3A575E0", VA = "0x183A583E0")]
	public static HOOGKKFDBEN<TPartialSnapshot, TFullSnapshot, TDeps> EPPBEPCPNMI(TDeps LPEICIFHPLM)
	{
		return default(HOOGKKFDBEN<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PFAGPHOPEIA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface JAGNEBMNBKD<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JHIAKLFHHDO([In] TPartialSnapshot JDJGNJCIKCI);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot NELMOEPNBEA(TPartialSnapshot[] MANJEECENMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2821D80", Offset = "0x2820F80", VA = "0x182821D80")]
	public static CPCJPGBNMLP<TFullSnapshot> INBMDDFNMEM<TFullSnapshot, TPartialSnapshot, TDeps>(this HOOGKKFDBEN<TPartialSnapshot, TFullSnapshot, TDeps> CJKIBFNGPNM, TPartialSnapshot JDJGNJCIKCI) where TDeps : JAGNEBMNBKD<TPartialSnapshot, TFullSnapshot>
	{
		return default(CPCJPGBNMLP<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2B120A0", Offset = "0x2B112A0", VA = "0x182B120A0")]
	public static bool JNMIMLMLJEK<TPartialSnapshot, TFullSnapshot, TDeps>(this HOOGKKFDBEN<TPartialSnapshot, TFullSnapshot, TDeps> CJKIBFNGPNM, TPartialSnapshot JDJGNJCIKCI) where TDeps : JAGNEBMNBKD<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class OCDFIKELKNP : GCHIODKACBE
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1D50", Offset = "0x1ED0F50", VA = "0x181ED1D50", Slot = "7")]
	public override string HDHLJKIJNJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1D80", Offset = "0x1ED0F80", VA = "0x181ED1D80")]
	public OCDFIKELKNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class NILBJKGDKJF<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : IEGIHPENLKG.EJEJBJKNIID<TAction, TNetSys> where TReceiverDeps : IEGIHPENLKG.LBPAADNCLIH<TAction, TReceiver> where TRootDeps : IEGIHPENLKG.KKJLCKKAEGM<TMRequest, TAction, TRoot> where TDeps : IEGIHPENLKG.DOEKNPGEAIL<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface DGLKFAGADEL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HGLKMMLCFEE([In] GDHFNIGIAEI<object, HHLFGPMDGJA> JBENFHJBMMN);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HLABKBMAHLH();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GDHFNIGIAEI<object, HHLFGPMDGJA> IDCGLHHBDAG();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EDFMFFPKMOC(Exception ILHGKPBGFDB);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class ABNKNLJACOK : DGLKFAGADEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<GDHFNIGIAEI<object, HHLFGPMDGJA>> HLBIMNCPKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<GDHFNIGIAEI<object, NFEBAOOCHCK>> MADGDFDAACL;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x39AB920", Offset = "0x39AAB20", VA = "0x1839AB920")]
		private ABNKNLJACOK(TaskCompletionSource<GDHFNIGIAEI<object, HHLFGPMDGJA>> GALFCEPCPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x39AB2A0", Offset = "0x39AA4A0", VA = "0x1839AB2A0")]
		public static ABNKNLJACOK EPPBEPCPNMI(TaskCompletionSource<GDHFNIGIAEI<object, HHLFGPMDGJA>> GALFCEPCPEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x39AB460", Offset = "0x39AA660", VA = "0x1839AB460")]
		public void HGLKMMLCFEE([In] GDHFNIGIAEI<object, HHLFGPMDGJA> JBENFHJBMMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x39AB640", Offset = "0x39AA840", VA = "0x1839AB640", Slot = "5")]
		public void HLABKBMAHLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x39AB720", Offset = "0x39AA920", VA = "0x1839AB720", Slot = "6")]
		public GDHFNIGIAEI<object, HHLFGPMDGJA> IDCGLHHBDAG()
		{
			return default(GDHFNIGIAEI<object, HHLFGPMDGJA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x39AB240", Offset = "0x39AA440", VA = "0x1839AB240", Slot = "7")]
		public void EDFMFFPKMOC(Exception ILHGKPBGFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x39AB1C0", Offset = "0x39AA3C0", VA = "0x1839AB1C0", Slot = "4")]
		private void BINMIHJGCMP([In] GDHFNIGIAEI<object, HHLFGPMDGJA> JBENFHJBMMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class APIIJAGJGJB : DGLKFAGADEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<GDHFNIGIAEI<object, HHLFGPMDGJA>> HLBIMNCPKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private GDHFNIGIAEI<object, HHLFGPMDGJA> CLICBPMDNFC;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
		private APIIJAGJGJB(TaskCompletionSource<GDHFNIGIAEI<object, HHLFGPMDGJA>> GALFCEPCPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x39AB2A0", Offset = "0x39AA4A0", VA = "0x1839AB2A0")]
		public static APIIJAGJGJB EPPBEPCPNMI(TaskCompletionSource<GDHFNIGIAEI<object, HHLFGPMDGJA>> GALFCEPCPEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x39A5800", Offset = "0x39A4A00", VA = "0x1839A5800")]
		public void HGLKMMLCFEE([In] GDHFNIGIAEI<object, HHLFGPMDGJA> JBENFHJBMMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3D89380", Offset = "0x3D88580", VA = "0x183D89380", Slot = "5")]
		public void HLABKBMAHLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xB7FD30", Offset = "0xB7EF30", VA = "0x180B7FD30", Slot = "6")]
		public GDHFNIGIAEI<object, HHLFGPMDGJA> IDCGLHHBDAG()
		{
			return default(GDHFNIGIAEI<object, HHLFGPMDGJA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3D89260", Offset = "0x3D88460", VA = "0x183D89260", Slot = "7")]
		public void EDFMFFPKMOC(Exception ILHGKPBGFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x39AB1C0", Offset = "0x39AA3C0", VA = "0x1839AB1C0", Slot = "4")]
		private void BINMIHJGCMP([In] GDHFNIGIAEI<object, HHLFGPMDGJA> JBENFHJBMMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class NDAPJFGMGKC : DGLKFAGADEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<GDHFNIGIAEI<object, HHLFGPMDGJA>> MADGDFDAACL;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4192250", Offset = "0x4191450", VA = "0x184192250")]
		private NDAPJFGMGKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3B1E940", Offset = "0x3B1DB40", VA = "0x183B1E940")]
		public static NDAPJFGMGKC EPPBEPCPNMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4192030", Offset = "0x4191230", VA = "0x184192030")]
		public void HGLKMMLCFEE([In] GDHFNIGIAEI<object, HHLFGPMDGJA> JBENFHJBMMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		public void HLABKBMAHLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4192100", Offset = "0x4191300", VA = "0x184192100", Slot = "6")]
		public GDHFNIGIAEI<object, HHLFGPMDGJA> IDCGLHHBDAG()
		{
			return default(GDHFNIGIAEI<object, HHLFGPMDGJA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4191F10", Offset = "0x4191110", VA = "0x184191F10", Slot = "7")]
		[LCJOOIGDAHJ("This may be terminal and should probably do more than discarding the exception.")]
		public void EDFMFFPKMOC(Exception ILHGKPBGFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x39AB1C0", Offset = "0x39AA3C0", VA = "0x1839AB1C0", Slot = "4")]
		private void BINMIHJGCMP([In] GDHFNIGIAEI<object, HHLFGPMDGJA> JBENFHJBMMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class IKKBNBNJMIG : DGLKFAGADEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GDHFNIGIAEI<object, HHLFGPMDGJA> CLICBPMDNFC;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		private IKKBNBNJMIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3B1E940", Offset = "0x3B1DB40", VA = "0x183B1E940")]
		public static IKKBNBNJMIG EPPBEPCPNMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1632880", Offset = "0x1631A80", VA = "0x181632880")]
		public void HGLKMMLCFEE([In] GDHFNIGIAEI<object, HHLFGPMDGJA> JBENFHJBMMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		public void HLABKBMAHLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83B450", Offset = "0x83A650", VA = "0x18083B450", Slot = "6")]
		public GDHFNIGIAEI<object, HHLFGPMDGJA> IDCGLHHBDAG()
		{
			return default(GDHFNIGIAEI<object, HHLFGPMDGJA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3B1E8F0", Offset = "0x3B1DAF0", VA = "0x183B1E8F0", Slot = "7")]
		[LCJOOIGDAHJ("This may be terminal and should probably do more than discarding the exception.")]
		public void EDFMFFPKMOC(Exception ILHGKPBGFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x39AB1C0", Offset = "0x39AA3C0", VA = "0x1839AB1C0", Slot = "4")]
		private void BINMIHJGCMP([In] GDHFNIGIAEI<object, HHLFGPMDGJA> JBENFHJBMMN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct NBONHAJPBKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NILBJKGDKJF<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public MKMFEDEKPBJ<PPPHCJPAHEM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<GDHFNIGIAEI<object, HHLFGPMDGJA>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x418E830", Offset = "0x418DA30", VA = "0x18418E830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x418F2A0", Offset = "0x418E4A0", VA = "0x18418F2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct OCBJKEGFNEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public NILBJKGDKJF<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MKMFEDEKPBJ<PPPHCJPAHEM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x42825C0", Offset = "0x42817C0", VA = "0x1842825C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4282E20", Offset = "0x4282020", VA = "0x184282E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct KDHFMDPGIMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public NILBJKGDKJF<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public MKMFEDEKPBJ<PPPHCJPAHEM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public MKMFEDEKPBJ<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3E4B620", Offset = "0x3E4A820", VA = "0x183E4B620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3E4BD30", Offset = "0x3E4AF30", VA = "0x183E4BD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FGNFBGIFENP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NILBJKGDKJF<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public MKMFEDEKPBJ<PPPHCJPAHEM> senderId;

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
		public MKMFEDEKPBJ<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private DGLKFAGADEL <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3908CB0", Offset = "0x3907EB0", VA = "0x183908CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x39098D0", Offset = "0x3908AD0", VA = "0x1839098D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct CIFIIJJDPMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NILBJKGDKJF<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public DGLKFAGADEL completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private DGLKFAGADEL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<GDHFNIGIAEI<object, HHLFGPMDGJA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4F91B90", Offset = "0x4F90D90", VA = "0x184F91B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4F93B40", Offset = "0x4F92D40", VA = "0x184F93B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps GJMNJKPIFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<MKMFEDEKPBJ<TMRequest>, TaskCompletionSource<GDHFNIGIAEI<object, HHLFGPMDGJA>>> MLOMMAILKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private MANCCKKMPCC<TMRequest> PIHAEOOBFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int JKEFFKHEEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task HJGJDBAEJKL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps GGOJKGNFIHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x41ADE20", Offset = "0x41AD020", VA = "0x1841ADE20")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps CKKNFCNCICE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x41ADA60", Offset = "0x41ACC60", VA = "0x1841ADA60")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps KDBNLCMLFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x41AD9E0", Offset = "0x41ACBE0", VA = "0x1841AD9E0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool IDHLKMIEBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x865300", Offset = "0x864500", VA = "0x180865300")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x12BB480", Offset = "0x12BA680", VA = "0x1812BB480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GOFAJAPEMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xE83970", Offset = "0xE82B70", VA = "0x180E83970")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1D84C30", Offset = "0x1D83E30", VA = "0x181D84C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FJIHAOKCHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7CDFF0", Offset = "0x7CD1F0", VA = "0x1807CDFF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x41AEE50", Offset = "0x41AE050", VA = "0x1841AEE50")]
	public NILBJKGDKJF(TDeps LPEICIFHPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x41AE290", Offset = "0x41AD490", VA = "0x1841AE290")]
	public Task<GDHFNIGIAEI<object, HHLFGPMDGJA>> NADKBACOIPO(TRoot LNOFAKNEFAA, TNetSys DGANCALIEGA, MKMFEDEKPBJ<PPPHCJPAHEM> GECDOBICLCK, TAction BGMBJALDBDD, bool ELOBKEMEHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x41AEA40", Offset = "0x41ADC40", VA = "0x1841AEA40")]
	[AsyncStateMachine(typeof(NILBJKGDKJF<, , , , , , , , >.NBONHAJPBKA))]
	private Task<GDHFNIGIAEI<object, HHLFGPMDGJA>> NADKBACOIPO(TRoot LNOFAKNEFAA, MKMFEDEKPBJ<PPPHCJPAHEM> GECDOBICLCK, TAction BGMBJALDBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x41ADE70", Offset = "0x41AD070", VA = "0x1841ADE70")]
	[AsyncStateMachine(typeof(NILBJKGDKJF<, , , , , , , , >.OCBJKEGFNEE))]
	private Task<GDHFNIGIAEI<object, HHLFGPMDGJA>> MBHJFONINHL(TRoot LNOFAKNEFAA, MKMFEDEKPBJ<PPPHCJPAHEM> GECDOBICLCK, TAction[] JCAJMHEPJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x41AD870", Offset = "0x41ACA70", VA = "0x1841AD870")]
	[AsyncStateMachine(typeof(NILBJKGDKJF<, , , , , , , , >.KDHFMDPGIMF))]
	public Task<GDHFNIGIAEI<object, HHLFGPMDGJA>> BFONIOELENK(TRoot LNOFAKNEFAA, TNetSys MDEBMCPIEBO, TReceiver LHADPJODGJC, MKMFEDEKPBJ<PPPHCJPAHEM> GECDOBICLCK, MKMFEDEKPBJ<TMRequest> IGLBCBEFGEC, TAction BGMBJALDBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x41ADAE0", Offset = "0x41ACCE0", VA = "0x1841ADAE0")]
	[AsyncStateMachine(typeof(NILBJKGDKJF<, , , , , , , , >.FGNFBGIFENP))]
	private Task<GDHFNIGIAEI<object, HHLFGPMDGJA>> HDFPFOEKCHJ(TRoot LNOFAKNEFAA, TNetSys MDEBMCPIEBO, TReceiver LHADPJODGJC, MKMFEDEKPBJ<PPPHCJPAHEM> GECDOBICLCK, MKMFEDEKPBJ<TMRequest> IGLBCBEFGEC, TAction BGMBJALDBDD, Task JADNLBOLAFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x41AECF0", Offset = "0x41ADEF0", VA = "0x1841AECF0")]
	[AsyncStateMachine(typeof(NILBJKGDKJF<, , , , , , , , >.CIFIIJJDPMO))]
	private Task OEFANDOBEKC(TRoot LNOFAKNEFAA, TNetSys MDEBMCPIEBO, TReceiver LHADPJODGJC, TAction BGMBJALDBDD, DGLKFAGADEL LENILKDAOBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x41AD3A0", Offset = "0x41AC5A0", VA = "0x1841AD3A0")]
	private void AKGJMAIJLBJ(TRoot LNOFAKNEFAA, TNetSys MDEBMCPIEBO, TReceiver LHADPJODGJC, MKMFEDEKPBJ<PPPHCJPAHEM> GECDOBICLCK, TAction BGMBJALDBDD, bool JPJLDCPDOIH, bool NKCPPGNHABE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IEGIHPENLKG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface EJEJBJKNIID<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MPFDMBNCGCG(TNetSys BMGPEHJNJNI, TAction BGMBJALDBDD);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction CLAENALCEDC(TNetSys BMGPEHJNJNI, TAction BGMBJALDBDD);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction BJFNOMFJDGB(TNetSys BMGPEHJNJNI, TAction BGMBJALDBDD);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> AGMBPIPCBAO(TNetSys BMGPEHJNJNI, TAction BGMBJALDBDD);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] JMGIMHCMIBP(TNetSys BMGPEHJNJNI, TAction BGMBJALDBDD, int BAIDADKGBAM);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool KIGNAMHHHNK(TNetSys BMGPEHJNJNI, TAction BGMBJALDBDD);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool FAHBPKFOFAN(TNetSys BMGPEHJNJNI, TAction BGMBJALDBDD);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool PAHEMHCACCF(TNetSys BMGPEHJNJNI, TAction BGMBJALDBDD);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool LHGBDCNNIIP(TNetSys BMGPEHJNJNI, TAction BGMBJALDBDD);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool ANNELCNNBMK(TNetSys BMGPEHJNJNI, TAction BGMBJALDBDD);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool OMAFIPPDBKD(TNetSys BMGPEHJNJNI, TAction BGMBJALDBDD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface DOEKNPGEAIL<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps GGOJKGNFIHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps KDBNLCMLFBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps CKKNFCNCICE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface LBPAADNCLIH<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MKMFEDEKPBJ<PPPHCJPAHEM> BDOCPJLEDLF(TReceiver LHADPJODGJC);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<GDHFNIGIAEI<object, HHLFGPMDGJA>> BFONIOELENK(TReceiver LHADPJODGJC, TAction BGMBJALDBDD);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] AMFNOBPCLBH(TReceiver LHADPJODGJC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface KKJLCKKAEGM<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NEBFKPGHBAG(TRoot LNOFAKNEFAA);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int AODCMKMKOPD(TRoot LNOFAKNEFAA);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int LGMHLIGLNCH(TRoot LNOFAKNEFAA);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int HBJBLNNCCCE(TRoot LNOFAKNEFAA);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MHCHCPMKFEI(TRoot LNOFAKNEFAA);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task NADKBACOIPO(TRoot LNOFAKNEFAA, MKMFEDEKPBJ<PPPHCJPAHEM> GECDOBICLCK, MKMFEDEKPBJ<TMRequest> IGLBCBEFGEC, TAction BGMBJALDBDD, bool IPALJPBJICI = true);
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
