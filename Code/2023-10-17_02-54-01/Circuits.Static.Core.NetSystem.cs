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
public struct PHHJBEJCNGM<TPartialAction, TFullAction, TDeps> where TDeps : KKIDBIAFFND.EIFHKGBGGJG<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] JLELAKDJMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int JHBLBMNGOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps DDBMMBAAAPM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3423570", Offset = "0x3421D70", VA = "0x183423570")]
	internal PHHJBEJCNGM(TPartialAction[] PJMFFLJCKPB, int CDPFJKMGLGA, TDeps JOGDKLBFLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3423510", Offset = "0x3421D10", VA = "0x183423510")]
	public static PHHJBEJCNGM<TPartialAction, TFullAction, TDeps> KKMBICLNKPK(TDeps JOGDKLBFLFJ)
	{
		return default(PHHJBEJCNGM<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KKIDBIAFFND
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface EIFHKGBGGJG<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FDCIOPONKNM([In] TPartialAction BNFDBGHADLF);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction JPFOGFMPHDH(TPartialAction[] KNOPIFNOHFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2405410", Offset = "0x2403C10", VA = "0x182405410")]
	public static KMLMHBDHBHH<TFullAction> FLICBENMHIC<TFullAction, TPartialAction, TDeps>(this PHHJBEJCNGM<TPartialAction, TFullAction, TDeps> AFFJMIFONEM, TPartialAction BNFDBGHADLF) where TDeps : EIFHKGBGGJG<TPartialAction, TFullAction>
	{
		return default(KMLMHBDHBHH<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FKLNAHCNMEL<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : FDPHGNLLDNL.MDILGELDEMC<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] IFPGHBEJGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int OIGIIPANOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps DDBMMBAAAPM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3423570", Offset = "0x3421D70", VA = "0x183423570")]
	internal FKLNAHCNMEL(TPartialSnapshot[] PAICLKGIKEE, int EKNFJPCJMIF, TDeps JOGDKLBFLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3423510", Offset = "0x3421D10", VA = "0x183423510")]
	public static FKLNAHCNMEL<TPartialSnapshot, TFullSnapshot, TDeps> KKMBICLNKPK(TDeps JOGDKLBFLFJ)
	{
		return default(FKLNAHCNMEL<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FDPHGNLLDNL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface MDILGELDEMC<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GCPIIOIGPHE([In] TPartialSnapshot LLMJAANBHOG);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot AJPFCPGKAHH(TPartialSnapshot[] DPELOCLANGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x234F2E0", Offset = "0x234DAE0", VA = "0x18234F2E0")]
	public static KMLMHBDHBHH<TFullSnapshot> FLICBENMHIC<TFullSnapshot, TPartialSnapshot, TDeps>(this FKLNAHCNMEL<TPartialSnapshot, TFullSnapshot, TDeps> AFFJMIFONEM, TPartialSnapshot LLMJAANBHOG) where TDeps : MDILGELDEMC<TPartialSnapshot, TFullSnapshot>
	{
		return default(KMLMHBDHBHH<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x234F690", Offset = "0x234DE90", VA = "0x18234F690")]
	public static bool INNOLHLFCDP<TPartialSnapshot, TFullSnapshot, TDeps>(this FKLNAHCNMEL<TPartialSnapshot, TFullSnapshot, TDeps> AFFJMIFONEM, TPartialSnapshot LLMJAANBHOG) where TDeps : MDILGELDEMC<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class EJAOGHLCICH : HIMCMICGGGI
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1C31CE0", Offset = "0x1C304E0", VA = "0x181C31CE0", Slot = "7")]
	public override string DGMFKNHADKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1C31D10", Offset = "0x1C30510", VA = "0x181C31D10")]
	public EJAOGHLCICH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GLBJHOHDFIP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : OAGEFHGOAGE.FEONKILMDED<TAction, TNetSys> where TReceiverDeps : OAGEFHGOAGE.EHONACAFGBI<TMActor, TAction, TReceiver> where TRootDeps : OAGEFHGOAGE.JHHGMGOHHEA<TMRequest, TMActor, TAction, TRoot> where TDeps : OAGEFHGOAGE.HMNCFPNDHOH<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface GODCJABIJAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CLBJPNEKDOD([In] EOPMGLNDIOA<object, NHKNMEADEEO> KMHAEDONIKI);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DFNBGFIJLIO();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		EOPMGLNDIOA<object, NHKNMEADEEO> EBCFPMFAMLI();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ECFOMPPBOJM(Exception KPCACGLGOPI);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class EOPNKMHFPAI : GODCJABIJAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<EOPMGLNDIOA<object, NHKNMEADEEO>> DFLCNDHAINH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<EOPMGLNDIOA<object, HNHFFBALMII>> ANMOMGDGGPI;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x30AC0A0", Offset = "0x30AA8A0", VA = "0x1830AC0A0")]
		private EOPNKMHFPAI(TaskCompletionSource<EOPMGLNDIOA<object, NHKNMEADEEO>> LPGJFJPDIDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x30ABF30", Offset = "0x30AA730", VA = "0x1830ABF30")]
		public static EOPNKMHFPAI KKMBICLNKPK(TaskCompletionSource<EOPMGLNDIOA<object, NHKNMEADEEO>> LPGJFJPDIDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x30AB930", Offset = "0x30AA130", VA = "0x1830AB930")]
		public void CLBJPNEKDOD([In] EOPMGLNDIOA<object, NHKNMEADEEO> KMHAEDONIKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x30ABB50", Offset = "0x30AA350", VA = "0x1830ABB50", Slot = "5")]
		public void DFNBGFIJLIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x30ABDC0", Offset = "0x30AA5C0", VA = "0x1830ABDC0", Slot = "6")]
		public EOPMGLNDIOA<object, NHKNMEADEEO> EBCFPMFAMLI()
		{
			return default(EOPMGLNDIOA<object, NHKNMEADEEO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x30ABED0", Offset = "0x30AA6D0", VA = "0x1830ABED0", Slot = "7")]
		public void ECFOMPPBOJM(Exception KPCACGLGOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x30ABB30", Offset = "0x30AA330", VA = "0x1830ABB30", Slot = "4")]
		private void DFCJIJLPHAP([In] EOPMGLNDIOA<object, NHKNMEADEEO> KMHAEDONIKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class MAOEAPGCBHL : GODCJABIJAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<EOPMGLNDIOA<object, NHKNMEADEEO>> DFLCNDHAINH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EOPMGLNDIOA<object, NHKNMEADEEO> MOONKOGNHAP;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
		private MAOEAPGCBHL(TaskCompletionSource<EOPMGLNDIOA<object, NHKNMEADEEO>> LPGJFJPDIDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x30ABF30", Offset = "0x30AA730", VA = "0x1830ABF30")]
		public static MAOEAPGCBHL KKMBICLNKPK(TaskCompletionSource<EOPMGLNDIOA<object, NHKNMEADEEO>> LPGJFJPDIDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x347D470", Offset = "0x347BC70", VA = "0x18347D470")]
		public void CLBJPNEKDOD([In] EOPMGLNDIOA<object, NHKNMEADEEO> KMHAEDONIKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0230", Offset = "0x3ADEA30", VA = "0x183AE0230", Slot = "5")]
		public void DFNBGFIJLIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x955E20", Offset = "0x954620", VA = "0x180955E20", Slot = "6")]
		public EOPMGLNDIOA<object, NHKNMEADEEO> EBCFPMFAMLI()
		{
			return default(EOPMGLNDIOA<object, NHKNMEADEEO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE02F0", Offset = "0x3ADEAF0", VA = "0x183AE02F0", Slot = "7")]
		public void ECFOMPPBOJM(Exception KPCACGLGOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x30ABB30", Offset = "0x30AA330", VA = "0x1830ABB30", Slot = "4")]
		private void DFCJIJLPHAP([In] EOPMGLNDIOA<object, NHKNMEADEEO> KMHAEDONIKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class JDGFOBAOPHJ : GODCJABIJAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<EOPMGLNDIOA<object, NHKNMEADEEO>> ANMOMGDGGPI;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x37E7080", Offset = "0x37E5880", VA = "0x1837E7080")]
		private JDGFOBAOPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x37E6F30", Offset = "0x37E5730", VA = "0x1837E6F30")]
		public static JDGFOBAOPHJ KKMBICLNKPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x37E6DA0", Offset = "0x37E55A0", VA = "0x1837E6DA0")]
		public void CLBJPNEKDOD([In] EOPMGLNDIOA<object, NHKNMEADEEO> KMHAEDONIKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		public void DFNBGFIJLIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37E6E70", Offset = "0x37E5670", VA = "0x1837E6E70", Slot = "6")]
		public EOPMGLNDIOA<object, NHKNMEADEEO> EBCFPMFAMLI()
		{
			return default(EOPMGLNDIOA<object, NHKNMEADEEO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
		public void ECFOMPPBOJM(Exception KPCACGLGOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x30ABB30", Offset = "0x30AA330", VA = "0x1830ABB30", Slot = "4")]
		private void DFCJIJLPHAP([In] EOPMGLNDIOA<object, NHKNMEADEEO> KMHAEDONIKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class NGMLAHGOGPG : GODCJABIJAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EOPMGLNDIOA<object, NHKNMEADEEO> MOONKOGNHAP;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		private NGMLAHGOGPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37E6F30", Offset = "0x37E5730", VA = "0x1837E6F30")]
		public static NGMLAHGOGPG KKMBICLNKPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3BBF4A0", Offset = "0x3BBDCA0", VA = "0x183BBF4A0")]
		public void CLBJPNEKDOD([In] EOPMGLNDIOA<object, NHKNMEADEEO> KMHAEDONIKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		public void DFNBGFIJLIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40", Slot = "6")]
		public EOPMGLNDIOA<object, NHKNMEADEEO> EBCFPMFAMLI()
		{
			return default(EOPMGLNDIOA<object, NHKNMEADEEO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
		public void ECFOMPPBOJM(Exception KPCACGLGOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x30ABB30", Offset = "0x30AA330", VA = "0x1830ABB30", Slot = "4")]
		private void DFCJIJLPHAP([In] EOPMGLNDIOA<object, NHKNMEADEEO> KMHAEDONIKI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct CENGLILCJHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<object, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::GLBJHOHDFIP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public CJFFNAOEMIF<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<EOPMGLNDIOA<object, NHKNMEADEEO>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<EOPMGLNDIOA<object, NHKNMEADEEO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4AB2C10", Offset = "0x4AB1410", VA = "0x184AB2C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4AB3150", Offset = "0x4AB1950", VA = "0x184AB3150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NNNFBHJGHCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<object, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::GLBJHOHDFIP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CJFFNAOEMIF<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<EOPMGLNDIOA<object, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE1D0", Offset = "0x3BFC9D0", VA = "0x183BFE1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE680", Offset = "0x3BFCE80", VA = "0x183BFE680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct KCGMGPFGAGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<object, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::GLBJHOHDFIP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public CJFFNAOEMIF<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CJFFNAOEMIF<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<EOPMGLNDIOA<object, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x38552D0", Offset = "0x3853AD0", VA = "0x1838552D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x38559F0", Offset = "0x38541F0", VA = "0x1838559F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct LPIPBCEDGFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<object, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::GLBJHOHDFIP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CJFFNAOEMIF<TMActor> senderId;

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
		public CJFFNAOEMIF<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private GODCJABIJAE <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3932590", Offset = "0x3930D90", VA = "0x183932590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3933150", Offset = "0x3931950", VA = "0x183933150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct GPJABOIPNMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::GLBJHOHDFIP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public GODCJABIJAE completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private GODCJABIJAE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<EOPMGLNDIOA<object, NHKNMEADEEO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x350BE10", Offset = "0x350A610", VA = "0x18350BE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x350FAD0", Offset = "0x350E2D0", VA = "0x18350FAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps DDBMMBAAAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<CJFFNAOEMIF<TMRequest>, TaskCompletionSource<EOPMGLNDIOA<object, NHKNMEADEEO>>> GMCEGBMOIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private FHHHAFAMKBA<TMRequest> OLFBINIKMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int PLAFKEJCIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task GIDCIKKLAEK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps EMADDHLBKOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x34EE540", Offset = "0x34ECD40", VA = "0x1834EE540")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps GFCGIBIMFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x34EC8D0", Offset = "0x34EB0D0", VA = "0x1834EC8D0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps DGANDHBIHJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x34EE570", Offset = "0x34ECD70", VA = "0x1834EE570")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MEDHEDLPOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x10092D0", Offset = "0x1007AD0", VA = "0x1810092D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x10092E0", Offset = "0x1007AE0", VA = "0x1810092E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CLIALJFIJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1B1F7A0", Offset = "0x1B1DFA0", VA = "0x181B1F7A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1B1FA80", Offset = "0x1B1E280", VA = "0x181B1FA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FBKLCPHCPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x76A240", Offset = "0x768A40", VA = "0x18076A240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x34EE5F0", Offset = "0x34ECDF0", VA = "0x1834EE5F0")]
	public GLBJHOHDFIP(TDeps JOGDKLBFLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x34EDF20", Offset = "0x34EC720", VA = "0x1834EDF20")]
	public Task<EOPMGLNDIOA<object, NHKNMEADEEO>> MGKIFOBIFBC(TRoot DIPDOFGLHFF, TNetSys IKENCLNIIFL, CJFFNAOEMIF<TMActor> NOEJIEGJBEK, TAction OONIIOMBHJI, bool MBFIBHOAEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x34EDC60", Offset = "0x34EC460", VA = "0x1834EDC60")]
	[AsyncStateMachine(typeof(global::GLBJHOHDFIP<, , , , , , , , , >.CENGLILCJHP))]
	private Task<EOPMGLNDIOA<object, NHKNMEADEEO>> MGKIFOBIFBC(TRoot DIPDOFGLHFF, CJFFNAOEMIF<TMActor> NOEJIEGJBEK, TAction OONIIOMBHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x34ED3B0", Offset = "0x34EBBB0", VA = "0x1834ED3B0")]
	[AsyncStateMachine(typeof(global::GLBJHOHDFIP<, , , , , , , , , >.NNNFBHJGHCL))]
	private Task<EOPMGLNDIOA<object, NHKNMEADEEO>> IGOKGKDLBDJ(TRoot DIPDOFGLHFF, CJFFNAOEMIF<TMActor> NOEJIEGJBEK, TAction[] CLEMKBFECGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x34ECF60", Offset = "0x34EB760", VA = "0x1834ECF60")]
	[AsyncStateMachine(typeof(global::GLBJHOHDFIP<, , , , , , , , , >.KCGMGPFGAGJ))]
	public Task<EOPMGLNDIOA<object, NHKNMEADEEO>> EPMLBNCCMNN(TRoot DIPDOFGLHFF, TNetSys EPNCFEBNLFN, TReceiver PPKFMHJLLNO, CJFFNAOEMIF<TMActor> NOEJIEGJBEK, CJFFNAOEMIF<TMRequest> DBNIOAJECGO, TAction OONIIOMBHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x34ED6A0", Offset = "0x34EBEA0", VA = "0x1834ED6A0")]
	[AsyncStateMachine(typeof(global::GLBJHOHDFIP<, , , , , , , , , >.LPIPBCEDGFL))]
	private Task<EOPMGLNDIOA<object, NHKNMEADEEO>> KCNBFOHCMKA(TRoot DIPDOFGLHFF, TNetSys EPNCFEBNLFN, TReceiver PPKFMHJLLNO, CJFFNAOEMIF<TMActor> NOEJIEGJBEK, CJFFNAOEMIF<TMRequest> DBNIOAJECGO, TAction OONIIOMBHJI, Task FNEHDDNOIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x34EE240", Offset = "0x34ECA40", VA = "0x1834EE240")]
	[AsyncStateMachine(typeof(global::GLBJHOHDFIP<, , , , , , , , , >.GPJABOIPNMK))]
	private Task NGFJBOIGBAC(TRoot DIPDOFGLHFF, TNetSys EPNCFEBNLFN, TReceiver PPKFMHJLLNO, TAction OONIIOMBHJI, GODCJABIJAE IOOHCKPEHAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x34ECCC0", Offset = "0x34EB4C0", VA = "0x1834ECCC0")]
	private void CPPGDMKLJGB(TRoot DIPDOFGLHFF, TNetSys EPNCFEBNLFN, TReceiver PPKFMHJLLNO, CJFFNAOEMIF<TMActor> NOEJIEGJBEK, TAction OONIIOMBHJI, bool BEJEILGPBNC, bool LEDBJFOPALA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OAGEFHGOAGE
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface FEONKILMDED<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PKJNOGONKFL(TNetSys MEAOIIOHJDC, TAction OONIIOMBHJI);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction MFGIFMHBLPI(TNetSys MEAOIIOHJDC, TAction OONIIOMBHJI);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction HFOENLPAEHM(TNetSys MEAOIIOHJDC, TAction OONIIOMBHJI);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> BAGNPMINFJB(TNetSys MEAOIIOHJDC, TAction OONIIOMBHJI);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] MILHIICPBEO(TNetSys MEAOIIOHJDC, TAction OONIIOMBHJI, int LPFPKBOEAKK);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool CIIIOFFPFJB(TNetSys MEAOIIOHJDC, TAction OONIIOMBHJI);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool EAEAANECEOD(TNetSys MEAOIIOHJDC, TAction OONIIOMBHJI);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool NJELFPNOHNE(TNetSys MEAOIIOHJDC, TAction OONIIOMBHJI);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool KNHBOOJLMCG(TNetSys MEAOIIOHJDC, TAction OONIIOMBHJI);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool KJCBIDNELHJ(TNetSys MEAOIIOHJDC, TAction OONIIOMBHJI);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool EICBHCOKNOE(TNetSys MEAOIIOHJDC, TAction OONIIOMBHJI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface HMNCFPNDHOH<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps EMADDHLBKOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps DGANDHBIHJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps GFCGIBIMFJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface EHONACAFGBI<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CJFFNAOEMIF<TMActor> LBLCNPLBMBJ(TReceiver PPKFMHJLLNO);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<EOPMGLNDIOA<object, NHKNMEADEEO>> EPMLBNCCMNN(TReceiver PPKFMHJLLNO, TAction OONIIOMBHJI);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] ODHGNIDNEPO(TReceiver PPKFMHJLLNO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface JHHGMGOHHEA<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LCBLKCFKHOA(TRoot DIPDOFGLHFF);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int ABOEPGIDGOB(TRoot DIPDOFGLHFF);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int PFDICPIAOBP(TRoot DIPDOFGLHFF);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int MPNIMBJPAKE(TRoot DIPDOFGLHFF);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IAIOEKOKIME(TRoot DIPDOFGLHFF);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task MGKIFOBIFBC(TRoot DIPDOFGLHFF, CJFFNAOEMIF<TMActor> NOEJIEGJBEK, CJFFNAOEMIF<TMRequest> DBNIOAJECGO, TAction OONIIOMBHJI, bool EIFNDELCCDI = true);
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
