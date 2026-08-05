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
public struct DLNFBHFOFBP<TPartialAction, TFullAction, TDeps> where TDeps : JBAIHNPKJMN.IHABGCJPLNP<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] LJNECCALEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int PBDICMBBKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps EDMEOLOBLFJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3A48CC0", Offset = "0x3A47AC0", VA = "0x183A48CC0")]
	internal DLNFBHFOFBP(TPartialAction[] FAHDPJJAOOI, int BPBLCACNEGO, TDeps BKBOLGJILHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3A48BA0", Offset = "0x3A479A0", VA = "0x183A48BA0")]
	public static DLNFBHFOFBP<TPartialAction, TFullAction, TDeps> DCPHPAHCOGO(TDeps BKBOLGJILHG)
	{
		return default(DLNFBHFOFBP<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JBAIHNPKJMN
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface IHABGCJPLNP<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HMGJDPAGLHJ([In] TPartialAction MKMHDDMMJLF);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction JAKPGLDNFBC(TPartialAction[] ODELFKFCJAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x25FE7E0", Offset = "0x25FD5E0", VA = "0x1825FE7E0")]
	public static PPACJILLJDO<TFullAction> KOMGPOJKOKJ<TFullAction, TPartialAction, TDeps>(this DLNFBHFOFBP<TPartialAction, TFullAction, TDeps> OJFDNDCDDBK, TPartialAction MKMHDDMMJLF) where TDeps : IHABGCJPLNP<TPartialAction, TFullAction>
	{
		return default(PPACJILLJDO<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JOCMLJAECND<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : LIPEBJMOHJK.JHBBJPLEGBG<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] FIAEHDNFBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int JCFKHOPNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps EDMEOLOBLFJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3A48CC0", Offset = "0x3A47AC0", VA = "0x183A48CC0")]
	internal JOCMLJAECND(TPartialSnapshot[] HGLMJDOJLAB, int LJNFOGNLILD, TDeps BKBOLGJILHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3A48BA0", Offset = "0x3A479A0", VA = "0x183A48BA0")]
	public static JOCMLJAECND<TPartialSnapshot, TFullSnapshot, TDeps> DCPHPAHCOGO(TDeps BKBOLGJILHG)
	{
		return default(JOCMLJAECND<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LIPEBJMOHJK
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface JHBBJPLEGBG<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EGLKMBAMENG([In] TPartialSnapshot IAOAHOGMPAG);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot EEOBDMJOHPK(TPartialSnapshot[] MFALJFKOAGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x262FFA0", Offset = "0x262EDA0", VA = "0x18262FFA0")]
	public static PPACJILLJDO<TFullSnapshot> KOMGPOJKOKJ<TFullSnapshot, TPartialSnapshot, TDeps>(this JOCMLJAECND<TPartialSnapshot, TFullSnapshot, TDeps> OJFDNDCDDBK, TPartialSnapshot IAOAHOGMPAG) where TDeps : JHBBJPLEGBG<TPartialSnapshot, TFullSnapshot>
	{
		return default(PPACJILLJDO<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x262FE50", Offset = "0x262EC50", VA = "0x18262FE50")]
	public static bool IGGPIKKIHAO<TPartialSnapshot, TFullSnapshot, TDeps>(this JOCMLJAECND<TPartialSnapshot, TFullSnapshot, TDeps> OJFDNDCDDBK, TPartialSnapshot IAOAHOGMPAG) where TDeps : JHBBJPLEGBG<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class IGLONFHOAGC : CPLGHNODHNJ
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D1AAE0", Offset = "0x1D198E0", VA = "0x181D1AAE0", Slot = "7")]
	public override string EFDGLBEJKDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D1AB10", Offset = "0x1D19910", VA = "0x181D1AB10")]
	public IGLONFHOAGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MDLLIOKOFPG<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : GLJONLHEAAL.ADGGPFNDBGH<TAction, TNetSys> where TReceiverDeps : GLJONLHEAAL.EGIOCBHICEP<TMActor, TAction, TReceiver> where TRootDeps : GLJONLHEAAL.NNLHDENKEPF<TMRequest, TMActor, TAction, TRoot> where TDeps : GLJONLHEAAL.AKGEDJIPNAO<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface IPEIKDANIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DJAFAONLGGL([In] CGKJAMMICEF<object, EPHFBGIJLJH> ADPBDOHMAGP);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JKJECHFEKKH();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CGKJAMMICEF<object, EPHFBGIJLJH> PLMJHNOFCBH();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NFABLENBLLE(Exception ANBLKCIIIFD);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class LEMCKPALHGL : IPEIKDANIFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<CGKJAMMICEF<object, EPHFBGIJLJH>> NJCBOJHNPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<CGKJAMMICEF<object, KPPOPJKBMGO>> HKMCPFGOBEA;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3B42B30", Offset = "0x3B41930", VA = "0x183B42B30")]
		private LEMCKPALHGL(TaskCompletionSource<CGKJAMMICEF<object, EPHFBGIJLJH>> GMPCAFNHKHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3730F70", Offset = "0x372FD70", VA = "0x183730F70")]
		public static LEMCKPALHGL DCPHPAHCOGO(TaskCompletionSource<CGKJAMMICEF<object, EPHFBGIJLJH>> GMPCAFNHKHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3B42650", Offset = "0x3B41450", VA = "0x183B42650")]
		public void DJAFAONLGGL([In] CGKJAMMICEF<object, EPHFBGIJLJH> ADPBDOHMAGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3B42750", Offset = "0x3B41550", VA = "0x183B42750", Slot = "5")]
		public void JKJECHFEKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3B429D0", Offset = "0x3B417D0", VA = "0x183B429D0", Slot = "6")]
		public CGKJAMMICEF<object, EPHFBGIJLJH> PLMJHNOFCBH()
		{
			return default(CGKJAMMICEF<object, EPHFBGIJLJH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3B42910", Offset = "0x3B41710", VA = "0x183B42910", Slot = "7")]
		public void NFABLENBLLE(Exception ANBLKCIIIFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3731040", Offset = "0x372FE40", VA = "0x183731040", Slot = "4")]
		private void HBBPBAHDGIH([In] CGKJAMMICEF<object, EPHFBGIJLJH> ADPBDOHMAGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class HAIIMAGPCDK : IPEIKDANIFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<CGKJAMMICEF<object, EPHFBGIJLJH>> NJCBOJHNPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private CGKJAMMICEF<object, EPHFBGIJLJH> LGGCJLEIEON;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x791D40", Offset = "0x790B40", VA = "0x180791D40")]
		private HAIIMAGPCDK(TaskCompletionSource<CGKJAMMICEF<object, EPHFBGIJLJH>> GMPCAFNHKHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3730F70", Offset = "0x372FD70", VA = "0x183730F70")]
		public static HAIIMAGPCDK DCPHPAHCOGO(TaskCompletionSource<CGKJAMMICEF<object, EPHFBGIJLJH>> GMPCAFNHKHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3678F50", Offset = "0x3677D50", VA = "0x183678F50")]
		public void DJAFAONLGGL([In] CGKJAMMICEF<object, EPHFBGIJLJH> ADPBDOHMAGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x37310C0", Offset = "0x372FEC0", VA = "0x1837310C0", Slot = "5")]
		public void JKJECHFEKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA302A0", Offset = "0xA2F0A0", VA = "0x180A302A0", Slot = "6")]
		public CGKJAMMICEF<object, EPHFBGIJLJH> PLMJHNOFCBH()
		{
			return default(CGKJAMMICEF<object, EPHFBGIJLJH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3731120", Offset = "0x372FF20", VA = "0x183731120", Slot = "7")]
		public void NFABLENBLLE(Exception ANBLKCIIIFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3731040", Offset = "0x372FE40", VA = "0x183731040", Slot = "4")]
		private void HBBPBAHDGIH([In] CGKJAMMICEF<object, EPHFBGIJLJH> ADPBDOHMAGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class NLMAGAMNJEJ : IPEIKDANIFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<CGKJAMMICEF<object, EPHFBGIJLJH>> HKMCPFGOBEA;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF450", Offset = "0x3DFE250", VA = "0x183DFF450")]
		private NLMAGAMNJEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF000", Offset = "0x3DFDE00", VA = "0x183DFF000")]
		public static NLMAGAMNJEJ DCPHPAHCOGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF190", Offset = "0x3DFDF90", VA = "0x183DFF190")]
		public void DJAFAONLGGL([In] CGKJAMMICEF<object, EPHFBGIJLJH> ADPBDOHMAGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		public void JKJECHFEKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF360", Offset = "0x3DFE160", VA = "0x183DFF360", Slot = "6")]
		public CGKJAMMICEF<object, EPHFBGIJLJH> PLMJHNOFCBH()
		{
			return default(CGKJAMMICEF<object, EPHFBGIJLJH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF260", Offset = "0x3DFE060", VA = "0x183DFF260", Slot = "7")]
		[GEKBGODLFAH("This may be terminal and should probably do more than discarding the exception.")]
		public void NFABLENBLLE(Exception ANBLKCIIIFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3731040", Offset = "0x372FE40", VA = "0x183731040", Slot = "4")]
		private void HBBPBAHDGIH([In] CGKJAMMICEF<object, EPHFBGIJLJH> ADPBDOHMAGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class BEDGNILKPOA : IPEIKDANIFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CGKJAMMICEF<object, EPHFBGIJLJH> LGGCJLEIEON;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		private BEDGNILKPOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF000", Offset = "0x3DFDE00", VA = "0x183DFF000")]
		public static BEDGNILKPOA DCPHPAHCOGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x14578A0", Offset = "0x14566A0", VA = "0x1814578A0")]
		public void DJAFAONLGGL([In] CGKJAMMICEF<object, EPHFBGIJLJH> ADPBDOHMAGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		public void JKJECHFEKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB5EDE0", Offset = "0xB5DBE0", VA = "0x180B5EDE0", Slot = "6")]
		public CGKJAMMICEF<object, EPHFBGIJLJH> PLMJHNOFCBH()
		{
			return default(CGKJAMMICEF<object, EPHFBGIJLJH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x468B6C0", Offset = "0x468A4C0", VA = "0x18468B6C0", Slot = "7")]
		[GEKBGODLFAH("This may be terminal and should probably do more than discarding the exception.")]
		public void NFABLENBLLE(Exception ANBLKCIIIFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3731040", Offset = "0x372FE40", VA = "0x183731040", Slot = "4")]
		private void HBBPBAHDGIH([In] CGKJAMMICEF<object, EPHFBGIJLJH> ADPBDOHMAGP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LIPJCDNHDAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<CGKJAMMICEF<object, EPHFBGIJLJH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::MDLLIOKOFPG<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public APKOFFGFFFK<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<CGKJAMMICEF<object, EPHFBGIJLJH>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<CGKJAMMICEF<object, EPHFBGIJLJH>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3B4E5C0", Offset = "0x3B4D3C0", VA = "0x183B4E5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3B4F070", Offset = "0x3B4DE70", VA = "0x183B4F070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HMFNGMIGDJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<CGKJAMMICEF<object, EPHFBGIJLJH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::MDLLIOKOFPG<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public APKOFFGFFFK<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<CGKJAMMICEF<object, EPHFBGIJLJH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x375A620", Offset = "0x3759420", VA = "0x18375A620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x375AA60", Offset = "0x3759860", VA = "0x18375AA60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct GMHFBMLBMGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<CGKJAMMICEF<object, EPHFBGIJLJH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::MDLLIOKOFPG<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public APKOFFGFFFK<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public APKOFFGFFFK<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<CGKJAMMICEF<object, EPHFBGIJLJH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x36F3910", Offset = "0x36F2710", VA = "0x1836F3910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x36F3FC0", Offset = "0x36F2DC0", VA = "0x1836F3FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct AONNHDIFMEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<CGKJAMMICEF<object, EPHFBGIJLJH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::MDLLIOKOFPG<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public APKOFFGFFFK<TMActor> senderId;

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
		public APKOFFGFFFK<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IPEIKDANIFM <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x36B5E70", Offset = "0x36B4C70", VA = "0x1836B5E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x36B7760", Offset = "0x36B6560", VA = "0x1836B7760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct IBFJGKDMEEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::MDLLIOKOFPG<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public IPEIKDANIFM completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private IPEIKDANIFM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<CGKJAMMICEF<object, EPHFBGIJLJH>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x37EE670", Offset = "0x37ED470", VA = "0x1837EE670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x37F03C0", Offset = "0x37EF1C0", VA = "0x1837F03C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps EDMEOLOBLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<APKOFFGFFFK<TMRequest>, TaskCompletionSource<CGKJAMMICEF<object, EPHFBGIJLJH>>> IEBFGGNBGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EGOBPNAPGDF<TMRequest> EKJIJJKEPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int MANCNEFBPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task FHLDGONBADE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps JBGJIMCPLLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3D465B0", Offset = "0x3D453B0", VA = "0x183D465B0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps LHLFEJMNPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D469F0", Offset = "0x3D457F0", VA = "0x183D469F0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps OAHEMANLKML
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3D46970", Offset = "0x3D45770", VA = "0x183D46970")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool IDPJNCJFAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1108140", Offset = "0x1106F40", VA = "0x181108140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1108150", Offset = "0x1106F50", VA = "0x181108150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool EDBPBLHCOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1C00B60", Offset = "0x1BFF960", VA = "0x181C00B60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1C00E40", Offset = "0x1BFFC40", VA = "0x181C00E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MKMKFOJKAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7944C0", Offset = "0x7932C0", VA = "0x1807944C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D47F90", Offset = "0x3D46D90", VA = "0x183D47F90")]
	public MDLLIOKOFPG(TDeps BKBOLGJILHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3D473A0", Offset = "0x3D461A0", VA = "0x183D473A0")]
	public Task<CGKJAMMICEF<object, EPHFBGIJLJH>> PBLODKLAMLE(TRoot BPBPHOELENB, TNetSys AFHPJDNOLCC, APKOFFGFFFK<TMActor> MJKBPBKFKDB, TAction APDAGBKMGMB, bool DAAFKFDHCNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3D47820", Offset = "0x3D46620", VA = "0x183D47820")]
	[AsyncStateMachine(typeof(global::MDLLIOKOFPG<, , , , , , , , , >.LIPJCDNHDAO))]
	private Task<CGKJAMMICEF<object, EPHFBGIJLJH>> PBLODKLAMLE(TRoot BPBPHOELENB, APKOFFGFFFK<TMActor> MJKBPBKFKDB, TAction APDAGBKMGMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3D461A0", Offset = "0x3D44FA0", VA = "0x183D461A0")]
	[AsyncStateMachine(typeof(global::MDLLIOKOFPG<, , , , , , , , , >.HMFNGMIGDJN))]
	private Task<CGKJAMMICEF<object, EPHFBGIJLJH>> GAOCFJEOKHF(TRoot BPBPHOELENB, APKOFFGFFFK<TMActor> MJKBPBKFKDB, TAction[] AAHLEEALLHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3D467B0", Offset = "0x3D455B0", VA = "0x183D467B0")]
	[AsyncStateMachine(typeof(global::MDLLIOKOFPG<, , , , , , , , , >.GMHFBMLBMGP))]
	public Task<CGKJAMMICEF<object, EPHFBGIJLJH>> MJMOJFCKNGG(TRoot BPBPHOELENB, TNetSys EOFCFNEGJJP, TReceiver COLDMGBKDHN, APKOFFGFFFK<TMActor> MJKBPBKFKDB, APKOFFGFFFK<TMRequest> AEKEDGJHFDK, TAction APDAGBKMGMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3D47090", Offset = "0x3D45E90", VA = "0x183D47090")]
	[AsyncStateMachine(typeof(global::MDLLIOKOFPG<, , , , , , , , , >.AONNHDIFMEO))]
	private Task<CGKJAMMICEF<object, EPHFBGIJLJH>> PBBGJLAPHPD(TRoot BPBPHOELENB, TNetSys EOFCFNEGJJP, TReceiver COLDMGBKDHN, APKOFFGFFFK<TMActor> MJKBPBKFKDB, APKOFFGFFFK<TMRequest> AEKEDGJHFDK, TAction APDAGBKMGMB, Task FMMGOKCKGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3D46300", Offset = "0x3D45100", VA = "0x183D46300")]
	[AsyncStateMachine(typeof(global::MDLLIOKOFPG<, , , , , , , , , >.IBFJGKDMEEC))]
	private Task JCAFODHCJJE(TRoot BPBPHOELENB, TNetSys EOFCFNEGJJP, TReceiver COLDMGBKDHN, TAction APDAGBKMGMB, IPEIKDANIFM NNJNFNBMKEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3D46A20", Offset = "0x3D45820", VA = "0x183D46A20")]
	private void OJKHLPHOOPF(TRoot BPBPHOELENB, TNetSys EOFCFNEGJJP, TReceiver COLDMGBKDHN, APKOFFGFFFK<TMActor> MJKBPBKFKDB, TAction APDAGBKMGMB, bool MHHGJNAPEFB, bool APHCELKBLKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GLJONLHEAAL
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface ADGGPFNDBGH<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MAGKCMMACIE(TNetSys MIPDNEAPFKH, TAction APDAGBKMGMB);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction EGFPJOPLGFE(TNetSys MIPDNEAPFKH, TAction APDAGBKMGMB);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction JBJHPHGHCLK(TNetSys MIPDNEAPFKH, TAction APDAGBKMGMB);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> DOOHIGNGEKB(TNetSys MIPDNEAPFKH, TAction APDAGBKMGMB);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] JMKCGKIPKAN(TNetSys MIPDNEAPFKH, TAction APDAGBKMGMB, int APKDHJBFNBF);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool FDEHAIMLJJF(TNetSys MIPDNEAPFKH, TAction APDAGBKMGMB);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool LOIBHCLENFM(TNetSys MIPDNEAPFKH, TAction APDAGBKMGMB);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IJPKLBIOGCN(TNetSys MIPDNEAPFKH, TAction APDAGBKMGMB);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool BKAHNJDDKHB(TNetSys MIPDNEAPFKH, TAction APDAGBKMGMB);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool MJBOACHKPMM(TNetSys MIPDNEAPFKH, TAction APDAGBKMGMB);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool HKFJEJJILMG(TNetSys MIPDNEAPFKH, TAction APDAGBKMGMB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface AKGEDJIPNAO<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps JBGJIMCPLLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps OAHEMANLKML
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps LHLFEJMNPMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface EGIOCBHICEP<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		APKOFFGFFFK<TMActor> CBOPBDBBAPM(TReceiver COLDMGBKDHN);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<CGKJAMMICEF<object, EPHFBGIJLJH>> MJMOJFCKNGG(TReceiver COLDMGBKDHN, TAction APDAGBKMGMB);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] GFMFLCBOBBP(TReceiver COLDMGBKDHN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface NNLHDENKEPF<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BMBIGHOEECE(TRoot BPBPHOELENB);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int JBHCBAEEEMP(TRoot BPBPHOELENB);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int ACGOBNDKPEM(TRoot BPBPHOELENB);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int GMPDHBPHNHO(TRoot BPBPHOELENB);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JODKHJJKAEG(TRoot BPBPHOELENB);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task PBLODKLAMLE(TRoot BPBPHOELENB, APKOFFGFFFK<TMActor> MJKBPBKFKDB, APKOFFGFFFK<TMRequest> AEKEDGJHFDK, TAction APDAGBKMGMB, bool AHBCDPAGKBK = true);
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
