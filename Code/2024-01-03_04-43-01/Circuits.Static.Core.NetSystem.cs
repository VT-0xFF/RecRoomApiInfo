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
public struct PECCBKEOIFB<TPartialAction, TFullAction, TDeps> where TDeps : EIHOAEAPNBK.LLLPKLOEDLM<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] MIMAAFCAMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int MGCMAOLBLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps JDKBNPIOBLG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3E02E90", Offset = "0x3E01A90", VA = "0x183E02E90")]
	internal PECCBKEOIFB(TPartialAction[] LINLFMBJOIL, int MLKAEPBEDEH, TDeps BKGJDHEGAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3E02DC0", Offset = "0x3E019C0", VA = "0x183E02DC0")]
	public static PECCBKEOIFB<TPartialAction, TFullAction, TDeps> OOMHMBNJBCG(TDeps BKGJDHEGAMG)
	{
		return default(PECCBKEOIFB<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EIHOAEAPNBK
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface LLLPKLOEDLM<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EJEHGJIAKKF([In] TPartialAction DHMCELOKMPI);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction IHMLDAAMNDE(TPartialAction[] BKGPKOJCMJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23D0DB0", Offset = "0x23CF9B0", VA = "0x1823D0DB0")]
	public static DICBCILEPFI<TFullAction> PHLJLIPLHFD<TFullAction, TPartialAction, TDeps>(this PECCBKEOIFB<TPartialAction, TFullAction, TDeps> HHHLENOMLMP, TPartialAction DHMCELOKMPI) where TDeps : LLLPKLOEDLM<TPartialAction, TFullAction>
	{
		return default(DICBCILEPFI<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OJELDIBEJEH<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : EKCDDNPGNHI.NAOOEPHMFHB<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] MJLLIGIPAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int PEOABALOOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps JDKBNPIOBLG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3E02E90", Offset = "0x3E01A90", VA = "0x183E02E90")]
	internal OJELDIBEJEH(TPartialSnapshot[] PFEGDLBCJNJ, int NBOCOINKAFD, TDeps BKGJDHEGAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3E02DC0", Offset = "0x3E019C0", VA = "0x183E02DC0")]
	public static OJELDIBEJEH<TPartialSnapshot, TFullSnapshot, TDeps> OOMHMBNJBCG(TDeps BKGJDHEGAMG)
	{
		return default(OJELDIBEJEH<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EKCDDNPGNHI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface NAOOEPHMFHB<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JPEAPPHOBAF([In] TPartialSnapshot NFGBGAIDKPE);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot IPBEKDJPKOF(TPartialSnapshot[] INMIIKOOMOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x23D1D70", Offset = "0x23D0970", VA = "0x1823D1D70")]
	public static DICBCILEPFI<TFullSnapshot> PHLJLIPLHFD<TFullSnapshot, TPartialSnapshot, TDeps>(this OJELDIBEJEH<TPartialSnapshot, TFullSnapshot, TDeps> HHHLENOMLMP, TPartialSnapshot NFGBGAIDKPE) where TDeps : NAOOEPHMFHB<TPartialSnapshot, TFullSnapshot>
	{
		return default(DICBCILEPFI<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x23D1ED0", Offset = "0x23D0AD0", VA = "0x1823D1ED0")]
	public static bool PNHHFNIEKFJ<TPartialSnapshot, TFullSnapshot, TDeps>(this OJELDIBEJEH<TPartialSnapshot, TFullSnapshot, TDeps> HHHLENOMLMP, TPartialSnapshot NFGBGAIDKPE) where TDeps : NAOOEPHMFHB<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class IGCOOAKOHEI : BIDCBADFDJH
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1CCF120", Offset = "0x1CCDD20", VA = "0x181CCF120", Slot = "7")]
	public override string KDELHCHBOAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1CCF150", Offset = "0x1CCDD50", VA = "0x181CCF150")]
	public IGCOOAKOHEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GPPACLMNIGN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : ENCIBNCDPEE.GCEMCMNGOFB<TAction, TNetSys> where TReceiverDeps : ENCIBNCDPEE.FELMALLENBA<TMActor, TAction, TReceiver> where TRootDeps : ENCIBNCDPEE.DBIPLHODOOP<TMRequest, TMActor, TAction, TRoot> where TDeps : ENCIBNCDPEE.NLOPLODMOHB<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface MJGBCLIAHLI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KBAMEBBJICC([In] MEPDFJNPAPE<object, HEHIEEOHMHH> HNCONAMCFGC);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BJPDKEIMFLH();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MEPDFJNPAPE<object, HEHIEEOHMHH> OGGMHHELGAL();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OMPLCBEIGHG(Exception GDDKLHPPIHO);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class FLJAJFMHLAF : MJGBCLIAHLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<MEPDFJNPAPE<object, HEHIEEOHMHH>> MKADOOGIAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<MEPDFJNPAPE<object, KGBAABPCOOC>> BANFAPBHEEJ;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x34EDBB0", Offset = "0x34EC7B0", VA = "0x1834EDBB0")]
		private FLJAJFMHLAF(TaskCompletionSource<MEPDFJNPAPE<object, HEHIEEOHMHH>> PNJKDEENCLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x34EDA40", Offset = "0x34EC640", VA = "0x1834EDA40")]
		public static FLJAJFMHLAF OOMHMBNJBCG(TaskCompletionSource<MEPDFJNPAPE<object, HEHIEEOHMHH>> PNJKDEENCLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x34ED620", Offset = "0x34EC220", VA = "0x1834ED620")]
		public void KBAMEBBJICC([In] MEPDFJNPAPE<object, HEHIEEOHMHH> HNCONAMCFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x34ED540", Offset = "0x34EC140", VA = "0x1834ED540", Slot = "5")]
		public void BJPDKEIMFLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x34ED8D0", Offset = "0x34EC4D0", VA = "0x1834ED8D0", Slot = "6")]
		public MEPDFJNPAPE<object, HEHIEEOHMHH> OGGMHHELGAL()
		{
			return default(MEPDFJNPAPE<object, HEHIEEOHMHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x34ED980", Offset = "0x34EC580", VA = "0x1834ED980", Slot = "7")]
		public void OMPLCBEIGHG(Exception GDDKLHPPIHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x34ED440", Offset = "0x34EC040", VA = "0x1834ED440", Slot = "4")]
		private void ANNGJCKOGHE([In] MEPDFJNPAPE<object, HEHIEEOHMHH> HNCONAMCFGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class DAKOOKKIOII : MJGBCLIAHLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<MEPDFJNPAPE<object, HEHIEEOHMHH>> MKADOOGIAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MEPDFJNPAPE<object, HEHIEEOHMHH> NFJHCLCPCDI;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
		private DAKOOKKIOII(TaskCompletionSource<MEPDFJNPAPE<object, HEHIEEOHMHH>> PNJKDEENCLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x34EDA40", Offset = "0x34EC640", VA = "0x1834EDA40")]
		public static DAKOOKKIOII OOMHMBNJBCG(TaskCompletionSource<MEPDFJNPAPE<object, HEHIEEOHMHH>> PNJKDEENCLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BA10", Offset = "0x3D2A610", VA = "0x183D2BA10")]
		public void KBAMEBBJICC([In] MEPDFJNPAPE<object, HEHIEEOHMHH> HNCONAMCFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4DE47A0", Offset = "0x4DE33A0", VA = "0x184DE47A0", Slot = "5")]
		public void BJPDKEIMFLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9FCA30", Offset = "0x9FB630", VA = "0x1809FCA30", Slot = "6")]
		public MEPDFJNPAPE<object, HEHIEEOHMHH> OGGMHHELGAL()
		{
			return default(MEPDFJNPAPE<object, HEHIEEOHMHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4800", Offset = "0x4DE3400", VA = "0x184DE4800", Slot = "7")]
		public void OMPLCBEIGHG(Exception GDDKLHPPIHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x34ED440", Offset = "0x34EC040", VA = "0x1834ED440", Slot = "4")]
		private void ANNGJCKOGHE([In] MEPDFJNPAPE<object, HEHIEEOHMHH> HNCONAMCFGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class ACHIDGMCBFF : MJGBCLIAHLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<MEPDFJNPAPE<object, HEHIEEOHMHH>> BANFAPBHEEJ;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3548680", Offset = "0x3547280", VA = "0x183548680")]
		private ACHIDGMCBFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x35485C0", Offset = "0x35471C0", VA = "0x1835485C0")]
		public static ACHIDGMCBFF OOMHMBNJBCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3548390", Offset = "0x3546F90", VA = "0x183548390")]
		public void KBAMEBBJICC([In] MEPDFJNPAPE<object, HEHIEEOHMHH> HNCONAMCFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		public void BJPDKEIMFLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x35484C0", Offset = "0x35470C0", VA = "0x1835484C0", Slot = "6")]
		public MEPDFJNPAPE<object, HEHIEEOHMHH> OGGMHHELGAL()
		{
			return default(MEPDFJNPAPE<object, HEHIEEOHMHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3548520", Offset = "0x3547120", VA = "0x183548520", Slot = "7")]
		[HECACKLOION("This may be terminal and should probably do more than discarding the exception.")]
		public void OMPLCBEIGHG(Exception GDDKLHPPIHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x34ED440", Offset = "0x34EC040", VA = "0x1834ED440", Slot = "4")]
		private void ANNGJCKOGHE([In] MEPDFJNPAPE<object, HEHIEEOHMHH> HNCONAMCFGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class IJCOMLFBCHP : MJGBCLIAHLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private MEPDFJNPAPE<object, HEHIEEOHMHH> NFJHCLCPCDI;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		private IJCOMLFBCHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x35485C0", Offset = "0x35471C0", VA = "0x1835485C0")]
		public static IJCOMLFBCHP OOMHMBNJBCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x373D2A0", Offset = "0x373BEA0", VA = "0x18373D2A0")]
		public void KBAMEBBJICC([In] MEPDFJNPAPE<object, HEHIEEOHMHH> HNCONAMCFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		public void BJPDKEIMFLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB2A490", Offset = "0xB29090", VA = "0x180B2A490", Slot = "6")]
		public MEPDFJNPAPE<object, HEHIEEOHMHH> OGGMHHELGAL()
		{
			return default(MEPDFJNPAPE<object, HEHIEEOHMHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x373D310", Offset = "0x373BF10", VA = "0x18373D310", Slot = "7")]
		[HECACKLOION("This may be terminal and should probably do more than discarding the exception.")]
		public void OMPLCBEIGHG(Exception GDDKLHPPIHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x34ED440", Offset = "0x34EC040", VA = "0x1834ED440", Slot = "4")]
		private void ANNGJCKOGHE([In] MEPDFJNPAPE<object, HEHIEEOHMHH> HNCONAMCFGC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HJAIMJCGDNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<MEPDFJNPAPE<object, HEHIEEOHMHH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::GPPACLMNIGN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public LHFCDFCDHLN<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<MEPDFJNPAPE<object, HEHIEEOHMHH>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<MEPDFJNPAPE<object, HEHIEEOHMHH>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x366D1C0", Offset = "0x366BDC0", VA = "0x18366D1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x366DC00", Offset = "0x366C800", VA = "0x18366DC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NHGGMHGKBGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<MEPDFJNPAPE<object, HEHIEEOHMHH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::GPPACLMNIGN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public LHFCDFCDHLN<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<MEPDFJNPAPE<object, HEHIEEOHMHH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E900", Offset = "0x3D1D500", VA = "0x183D1E900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F1F0", Offset = "0x3D1DDF0", VA = "0x183D1F1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct CFIEMPHDFKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<MEPDFJNPAPE<object, HEHIEEOHMHH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::GPPACLMNIGN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public LHFCDFCDHLN<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public LHFCDFCDHLN<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<MEPDFJNPAPE<object, HEHIEEOHMHH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x49683F0", Offset = "0x4966FF0", VA = "0x1849683F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4968AA0", Offset = "0x49676A0", VA = "0x184968AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct AAILFMGCMPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<MEPDFJNPAPE<object, HEHIEEOHMHH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::GPPACLMNIGN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public LHFCDFCDHLN<TMActor> senderId;

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
		public LHFCDFCDHLN<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private MJGBCLIAHLI <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3544010", Offset = "0x3542C10", VA = "0x183544010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3545970", Offset = "0x3544570", VA = "0x183545970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct GAGPEBBGMDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::GPPACLMNIGN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public MJGBCLIAHLI completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private MJGBCLIAHLI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<MEPDFJNPAPE<object, HEHIEEOHMHH>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x358A2F0", Offset = "0x3588EF0", VA = "0x18358A2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x358C0A0", Offset = "0x358ACA0", VA = "0x18358C0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps JDKBNPIOBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<LHFCDFCDHLN<TMRequest>, TaskCompletionSource<MEPDFJNPAPE<object, HEHIEEOHMHH>>> HBJHNMJHNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private OIMDFGHCILK<TMRequest> CCFGIDJIFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int AOHEAKLKDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task NOHBPFDKBHM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps FCHIGEIMHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x35E24C0", Offset = "0x35E10C0", VA = "0x1835E24C0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps EKLOAMNFOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x35E1830", Offset = "0x35E0430", VA = "0x1835E1830")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps AIEGBPKHLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x35E24F0", Offset = "0x35E10F0", VA = "0x1835E24F0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool CDEAEIKJIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x10CE860", Offset = "0x10CD460", VA = "0x1810CE860")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x10CE870", Offset = "0x10CD470", VA = "0x1810CE870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JDLCLFNKHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1BB9D40", Offset = "0x1BB8940", VA = "0x181BB9D40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1BBA020", Offset = "0x1BB8C20", VA = "0x181BBA020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FPDDPDODAFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x77DAF0", Offset = "0x77C6F0", VA = "0x18077DAF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x35E3380", Offset = "0x35E1F80", VA = "0x1835E3380")]
	public GPPACLMNIGN(TDeps BKGJDHEGAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x35E2D50", Offset = "0x35E1950", VA = "0x1835E2D50")]
	public Task<MEPDFJNPAPE<object, HEHIEEOHMHH>> OAOECEIGPNB(TRoot NMHGPHBIAIB, TNetSys DKKKPJCPMEM, LHFCDFCDHLN<TMActor> JLOFEEBANCN, TAction GAFABDCELFL, bool ELKFGPIDBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x35E2A90", Offset = "0x35E1690", VA = "0x1835E2A90")]
	[AsyncStateMachine(typeof(global::GPPACLMNIGN<, , , , , , , , , >.HJAIMJCGDNG))]
	private Task<MEPDFJNPAPE<object, HEHIEEOHMHH>> OAOECEIGPNB(TRoot NMHGPHBIAIB, LHFCDFCDHLN<TMActor> JLOFEEBANCN, TAction GAFABDCELFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x35E1680", Offset = "0x35E0280", VA = "0x1835E1680")]
	[AsyncStateMachine(typeof(global::GPPACLMNIGN<, , , , , , , , , >.NHGGMHGKBGM))]
	private Task<MEPDFJNPAPE<object, HEHIEEOHMHH>> APLGNOHEALF(TRoot NMHGPHBIAIB, LHFCDFCDHLN<TMActor> JLOFEEBANCN, TAction[] CNIOGPBAAJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x35E1B10", Offset = "0x35E0710", VA = "0x1835E1B10")]
	[AsyncStateMachine(typeof(global::GPPACLMNIGN<, , , , , , , , , >.CFIEMPHDFKP))]
	public Task<MEPDFJNPAPE<object, HEHIEEOHMHH>> HMCKANLDBHI(TRoot NMHGPHBIAIB, TNetSys ECEBONPHFLG, TReceiver BHEBCLOMFGA, LHFCDFCDHLN<TMActor> JLOFEEBANCN, LHFCDFCDHLN<TMRequest> CKPPKACNFNF, TAction GAFABDCELFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x35E3070", Offset = "0x35E1C70", VA = "0x1835E3070")]
	[AsyncStateMachine(typeof(global::GPPACLMNIGN<, , , , , , , , , >.AAILFMGCMPD))]
	private Task<MEPDFJNPAPE<object, HEHIEEOHMHH>> OBOIHHKAOIH(TRoot NMHGPHBIAIB, TNetSys ECEBONPHFLG, TReceiver BHEBCLOMFGA, LHFCDFCDHLN<TMActor> JLOFEEBANCN, LHFCDFCDHLN<TMRequest> CKPPKACNFNF, TAction GAFABDCELFL, Task PFDAGLINGKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x35E19C0", Offset = "0x35E05C0", VA = "0x1835E19C0")]
	[AsyncStateMachine(typeof(global::GPPACLMNIGN<, , , , , , , , , >.GAGPEBBGMDD))]
	private Task DCMPLOBMJBO(TRoot NMHGPHBIAIB, TNetSys ECEBONPHFLG, TReceiver BHEBCLOMFGA, TAction GAFABDCELFL, MJGBCLIAHLI HCGABALMBLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x35E2190", Offset = "0x35E0D90", VA = "0x1835E2190")]
	private void IKHIDLJGCKH(TRoot NMHGPHBIAIB, TNetSys ECEBONPHFLG, TReceiver BHEBCLOMFGA, LHFCDFCDHLN<TMActor> JLOFEEBANCN, TAction GAFABDCELFL, bool MMGKLDKNKIH, bool LOMBDJNBICE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ENCIBNCDPEE
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface GCEMCMNGOFB<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int CJACKFHEOGB(TNetSys ONMDLMOBIJP, TAction GAFABDCELFL);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction GILOCMBOBNA(TNetSys ONMDLMOBIJP, TAction GAFABDCELFL);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction BHIHBEDAILB(TNetSys ONMDLMOBIJP, TAction GAFABDCELFL);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> FKIPGBKFINB(TNetSys ONMDLMOBIJP, TAction GAFABDCELFL);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] CMHCCJKAOIH(TNetSys ONMDLMOBIJP, TAction GAFABDCELFL, int EFKFKHNJAIM);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PPFGGLOIHEI(TNetSys ONMDLMOBIJP, TAction GAFABDCELFL);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DILNEBNHEHC(TNetSys ONMDLMOBIJP, TAction GAFABDCELFL);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool LEACENBBNGE(TNetSys ONMDLMOBIJP, TAction GAFABDCELFL);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool PDGCKFNAEJK(TNetSys ONMDLMOBIJP, TAction GAFABDCELFL);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HBBMFNCDADK(TNetSys ONMDLMOBIJP, TAction GAFABDCELFL);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool KKHMJOPFDPM(TNetSys ONMDLMOBIJP, TAction GAFABDCELFL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface NLOPLODMOHB<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps FCHIGEIMHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps AIEGBPKHLEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps EKLOAMNFOJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface FELMALLENBA<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LHFCDFCDHLN<TMActor> ALAPMDKNPPP(TReceiver BHEBCLOMFGA);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<MEPDFJNPAPE<object, HEHIEEOHMHH>> HMCKANLDBHI(TReceiver BHEBCLOMFGA, TAction GAFABDCELFL);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] BLNEIIHGJFK(TReceiver BHEBCLOMFGA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface DBIPLHODOOP<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EAKGLBLGEID(TRoot NMHGPHBIAIB);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int APAECGMEGCJ(TRoot NMHGPHBIAIB);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int NADHOMCAIPN(TRoot NMHGPHBIAIB);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int DHKLHFGDOPB(TRoot NMHGPHBIAIB);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GBBBDFKMNGP(TRoot NMHGPHBIAIB);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task OAOECEIGPNB(TRoot NMHGPHBIAIB, LHFCDFCDHLN<TMActor> JLOFEEBANCN, LHFCDFCDHLN<TMRequest> CKPPKACNFNF, TAction GAFABDCELFL, bool JJAJLPHDJEG = true);
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
