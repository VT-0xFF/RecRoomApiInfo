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
public struct EJOHLFBKMKN<TPartialAction, TFullAction, TDeps> where TDeps : LJMGAPLNLLJ.OKNFBMBIILO<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] LCDAHICCNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int AHHMLMNAGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps IMCLEPLPDAM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3854370", Offset = "0x3852970", VA = "0x183854370")]
	internal EJOHLFBKMKN(TPartialAction[] ODHGHCHPLPJ, int JMPHIIJPPMM, TDeps BPGHBBHBELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3854310", Offset = "0x3852910", VA = "0x183854310")]
	public static EJOHLFBKMKN<TPartialAction, TFullAction, TDeps> ENFOKLPNHAF(TDeps BPGHBBHBELB)
	{
		return default(EJOHLFBKMKN<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LJMGAPLNLLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface OKNFBMBIILO<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OIICCGCLLCF([In] TPartialAction LNPJFMEOKLF);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction HJKMCKHECCI(TPartialAction[] IAFLPPNCLIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2C58760", Offset = "0x2C56D60", VA = "0x182C58760")]
	public static MADCGGOAHGO<TFullAction> AADLBJGMJAI<TFullAction, TPartialAction, TDeps>(this EJOHLFBKMKN<TPartialAction, TFullAction, TDeps> HLIDMKMINHN, TPartialAction LNPJFMEOKLF) where TDeps : OKNFBMBIILO<TPartialAction, TFullAction>
	{
		return default(MADCGGOAHGO<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EAEIAEHPNFO<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : KLCKLHMBIKJ.OKJPNPJHNMP<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] FEIIPONKEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int FLOCINBELLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps IMCLEPLPDAM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3854370", Offset = "0x3852970", VA = "0x183854370")]
	internal EAEIAEHPNFO(TPartialSnapshot[] ELGKDGCPKIN, int PMILDLECJKL, TDeps BPGHBBHBELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3854310", Offset = "0x3852910", VA = "0x183854310")]
	public static EAEIAEHPNFO<TPartialSnapshot, TFullSnapshot, TDeps> ENFOKLPNHAF(TDeps BPGHBBHBELB)
	{
		return default(EAEIAEHPNFO<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KLCKLHMBIKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface OKJPNPJHNMP<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IDPKOJJDIHA([In] TPartialSnapshot CMJJGMHOKHM);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot APKAENDOFIG(TPartialSnapshot[] LIPCPMOBIAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C39790", Offset = "0x2C37D90", VA = "0x182C39790")]
	public static MADCGGOAHGO<TFullSnapshot> AADLBJGMJAI<TFullSnapshot, TPartialSnapshot, TDeps>(this EAEIAEHPNFO<TPartialSnapshot, TFullSnapshot, TDeps> HLIDMKMINHN, TPartialSnapshot CMJJGMHOKHM) where TDeps : OKJPNPJHNMP<TPartialSnapshot, TFullSnapshot>
	{
		return default(MADCGGOAHGO<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2C39B90", Offset = "0x2C38190", VA = "0x182C39B90")]
	public static bool ILALKMBMKNN<TPartialSnapshot, TFullSnapshot, TDeps>(this EAEIAEHPNFO<TPartialSnapshot, TFullSnapshot, TDeps> HLIDMKMINHN, TPartialSnapshot CMJJGMHOKHM) where TDeps : OKJPNPJHNMP<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class NIOLBFKDFII : IFONDHBKBCD
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2016480", Offset = "0x2014A80", VA = "0x182016480", Slot = "7")]
	public override string AFLHKEIDPKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x20164B0", Offset = "0x2014AB0", VA = "0x1820164B0")]
	public NIOLBFKDFII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class EHAMLGILMPC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : KLDPKNMOOBM.NIFGKHGODDN<TAction, TNetSys> where TReceiverDeps : KLDPKNMOOBM.MHEKMDGDJBP<TAction, TReceiver> where TRootDeps : KLDPKNMOOBM.EAJBCNJANOA<TMRequest, TAction, TRoot> where TDeps : KLDPKNMOOBM.IFMPIBELOKH<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface MBDLCBNCAIC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OLPHHNMGIIE([In] CBDPDIPONCF<object, FBDDJIHDMAI> IAFCFGOKEAK);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BHFPJIKCLFF();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CBDPDIPONCF<object, FBDDJIHDMAI> EPMHKOAJNBK();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KKAELDFNPCD(Exception LPFKIAHEHEL);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class APGEBKHCPCH : MBDLCBNCAIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<CBDPDIPONCF<object, FBDDJIHDMAI>> OCFAMJEIFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<CBDPDIPONCF<object, GJMJCOBOHDO>> BHPDCOEPOLA;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3ECEC50", Offset = "0x3ECD250", VA = "0x183ECEC50")]
		private APGEBKHCPCH(TaskCompletionSource<CBDPDIPONCF<object, FBDDJIHDMAI>> MAJHLODNNLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E87020", Offset = "0x3E85620", VA = "0x183E87020")]
		public static APGEBKHCPCH ENFOKLPNHAF(TaskCompletionSource<CBDPDIPONCF<object, FBDDJIHDMAI>> MAJHLODNNLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3ECEA50", Offset = "0x3ECD050", VA = "0x183ECEA50")]
		public void OLPHHNMGIIE([In] CBDPDIPONCF<object, FBDDJIHDMAI> IAFCFGOKEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE550", Offset = "0x3ECCB50", VA = "0x183ECE550", Slot = "5")]
		public void BHFPJIKCLFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE710", Offset = "0x3ECCD10", VA = "0x183ECE710", Slot = "6")]
		public CBDPDIPONCF<object, FBDDJIHDMAI> EPMHKOAJNBK()
		{
			return default(CBDPDIPONCF<object, FBDDJIHDMAI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE8D0", Offset = "0x3ECCED0", VA = "0x183ECE8D0", Slot = "7")]
		public void KKAELDFNPCD(Exception LPFKIAHEHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3ECEB70", Offset = "0x3ECD170", VA = "0x183ECEB70", Slot = "4")]
		private void OOOFPHFDDJB([In] CBDPDIPONCF<object, FBDDJIHDMAI> IAFCFGOKEAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class OCAHDFMFOLM : MBDLCBNCAIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<CBDPDIPONCF<object, FBDDJIHDMAI>> OCFAMJEIFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private CBDPDIPONCF<object, FBDDJIHDMAI> KBHLNJEIOLF;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
		private OCAHDFMFOLM(TaskCompletionSource<CBDPDIPONCF<object, FBDDJIHDMAI>> MAJHLODNNLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3E87020", Offset = "0x3E85620", VA = "0x183E87020")]
		public static OCAHDFMFOLM ENFOKLPNHAF(TaskCompletionSource<CBDPDIPONCF<object, FBDDJIHDMAI>> MAJHLODNNLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x46BF110", Offset = "0x46BD710", VA = "0x1846BF110")]
		public void OLPHHNMGIIE([In] CBDPDIPONCF<object, FBDDJIHDMAI> IAFCFGOKEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x46BEFF0", Offset = "0x46BD5F0", VA = "0x1846BEFF0", Slot = "5")]
		public void BHFPJIKCLFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xC70640", Offset = "0xC6EC40", VA = "0x180C70640", Slot = "6")]
		public CBDPDIPONCF<object, FBDDJIHDMAI> EPMHKOAJNBK()
		{
			return default(CBDPDIPONCF<object, FBDDJIHDMAI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x46BF0B0", Offset = "0x46BD6B0", VA = "0x1846BF0B0", Slot = "7")]
		public void KKAELDFNPCD(Exception LPFKIAHEHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3ECEB70", Offset = "0x3ECD170", VA = "0x183ECEB70", Slot = "4")]
		private void OOOFPHFDDJB([In] CBDPDIPONCF<object, FBDDJIHDMAI> IAFCFGOKEAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class LMHHABHDFCN : MBDLCBNCAIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<CBDPDIPONCF<object, FBDDJIHDMAI>> BHPDCOEPOLA;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x42EB340", Offset = "0x42E9940", VA = "0x1842EB340")]
		private LMHHABHDFCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x42EAF50", Offset = "0x42E9550", VA = "0x1842EAF50")]
		public static LMHHABHDFCN ENFOKLPNHAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x42EB260", Offset = "0x42E9860", VA = "0x1842EB260")]
		public void OLPHHNMGIIE([In] CBDPDIPONCF<object, FBDDJIHDMAI> IAFCFGOKEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		public void BHFPJIKCLFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x42EB080", Offset = "0x42E9680", VA = "0x1842EB080", Slot = "6")]
		public CBDPDIPONCF<object, FBDDJIHDMAI> EPMHKOAJNBK()
		{
			return default(CBDPDIPONCF<object, FBDDJIHDMAI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x42EB130", Offset = "0x42E9730", VA = "0x1842EB130", Slot = "7")]
		[DFMFJMBJIGJ("This may be terminal and should probably do more than discarding the exception.")]
		public void KKAELDFNPCD(Exception LPFKIAHEHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3ECEB70", Offset = "0x3ECD170", VA = "0x183ECEB70", Slot = "4")]
		private void OOOFPHFDDJB([In] CBDPDIPONCF<object, FBDDJIHDMAI> IAFCFGOKEAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class LMIEOJPFCLF : MBDLCBNCAIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CBDPDIPONCF<object, FBDDJIHDMAI> KBHLNJEIOLF;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		private LMIEOJPFCLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x42EAF50", Offset = "0x42E9550", VA = "0x1842EAF50")]
		public static LMIEOJPFCLF ENFOKLPNHAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1733590", Offset = "0x1731B90", VA = "0x181733590")]
		public void OLPHHNMGIIE([In] CBDPDIPONCF<object, FBDDJIHDMAI> IAFCFGOKEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		public void BHFPJIKCLFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA60", Offset = "0x8FA060", VA = "0x1808FBA60", Slot = "6")]
		public CBDPDIPONCF<object, FBDDJIHDMAI> EPMHKOAJNBK()
		{
			return default(CBDPDIPONCF<object, FBDDJIHDMAI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x42EB4B0", Offset = "0x42E9AB0", VA = "0x1842EB4B0", Slot = "7")]
		[DFMFJMBJIGJ("This may be terminal and should probably do more than discarding the exception.")]
		public void KKAELDFNPCD(Exception LPFKIAHEHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3ECEB70", Offset = "0x3ECD170", VA = "0x183ECEB70", Slot = "4")]
		private void OOOFPHFDDJB([In] CBDPDIPONCF<object, FBDDJIHDMAI> IAFCFGOKEAK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct JJPELOBFKHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<object, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public EHAMLGILMPC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public CGBGMGFBCKF<LCNEPMDCCCO> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<CBDPDIPONCF<object, FBDDJIHDMAI>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<CBDPDIPONCF<object, FBDDJIHDMAI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4093440", Offset = "0x4091A40", VA = "0x184093440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4093940", Offset = "0x4091F40", VA = "0x184093940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct ADDPPNNPDKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<object, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public EHAMLGILMPC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CGBGMGFBCKF<LCNEPMDCCCO> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<CBDPDIPONCF<object, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3CADC20", Offset = "0x3CAC220", VA = "0x183CADC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE110", Offset = "0x3CAC710", VA = "0x183CAE110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct OECJAPMAECF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<object, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public EHAMLGILMPC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public CGBGMGFBCKF<LCNEPMDCCCO> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CGBGMGFBCKF<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<CBDPDIPONCF<object, FBDDJIHDMAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x46C8C90", Offset = "0x46C7290", VA = "0x1846C8C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x46C9080", Offset = "0x46C7680", VA = "0x1846C9080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct BENCAHENIPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<CBDPDIPONCF<object, FBDDJIHDMAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public EHAMLGILMPC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CGBGMGFBCKF<LCNEPMDCCCO> senderId;

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
		public CGBGMGFBCKF<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private MBDLCBNCAIC <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4EC6E70", Offset = "0x4EC5470", VA = "0x184EC6E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4EC7B80", Offset = "0x4EC6180", VA = "0x184EC7B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct LIBDFFNPDHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public EHAMLGILMPC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public MBDLCBNCAIC completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private MBDLCBNCAIC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<CBDPDIPONCF<object, FBDDJIHDMAI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x42D82B0", Offset = "0x42D68B0", VA = "0x1842D82B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x42DC340", Offset = "0x42DA940", VA = "0x1842DC340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps IMCLEPLPDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<CGBGMGFBCKF<TMRequest>, TaskCompletionSource<CBDPDIPONCF<object, FBDDJIHDMAI>>> AOEFKNMHJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HPCINOCMGCO<TMRequest> CHCGNNJFHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int GEABKKEKDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task JHGMPHBBCDI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps MFMFPALONPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x38672A0", Offset = "0x38658A0", VA = "0x1838672A0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps ELNNLMOKFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3865750", Offset = "0x3863D50", VA = "0x183865750")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps GEHJJCDNIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3865390", Offset = "0x3863990", VA = "0x183865390")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool DHIHBJFGFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9504A0", Offset = "0x94EAA0", VA = "0x1809504A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x13CB2D0", Offset = "0x13C98D0", VA = "0x1813CB2D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PELKOFALILF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xF6C2C0", Offset = "0xF6A8C0", VA = "0x180F6C2C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1EBBFF0", Offset = "0x1EBA5F0", VA = "0x181EBBFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LIHFCKPIEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x86E900", Offset = "0x86CF00", VA = "0x18086E900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x38672D0", Offset = "0x38658D0", VA = "0x1838672D0")]
	public EHAMLGILMPC(TDeps BPGHBBHBELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3865A90", Offset = "0x3864090", VA = "0x183865A90")]
	public Task<CBDPDIPONCF<object, FBDDJIHDMAI>> FMLFFEDJMGK(TRoot OPJBDKMKMOF, TNetSys KPBGAILHHNK, CGBGMGFBCKF<LCNEPMDCCCO> HCJJKKIJPBP, TAction PEMICEIPPPL, bool FINFIEKODAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3865F70", Offset = "0x3864570", VA = "0x183865F70")]
	[AsyncStateMachine(typeof(EHAMLGILMPC<, , , , , , , , >.JJPELOBFKHK))]
	private Task<CBDPDIPONCF<object, FBDDJIHDMAI>> FMLFFEDJMGK(TRoot OPJBDKMKMOF, CGBGMGFBCKF<LCNEPMDCCCO> HCJJKKIJPBP, TAction PEMICEIPPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3866F90", Offset = "0x3865590", VA = "0x183866F90")]
	[AsyncStateMachine(typeof(EHAMLGILMPC<, , , , , , , , >.ADDPPNNPDKJ))]
	private Task<CBDPDIPONCF<object, FBDDJIHDMAI>> KMDIDLKNPFC(TRoot OPJBDKMKMOF, CGBGMGFBCKF<LCNEPMDCCCO> HCJJKKIJPBP, TAction[] EPOBEFECONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3865410", Offset = "0x3863A10", VA = "0x183865410")]
	[AsyncStateMachine(typeof(EHAMLGILMPC<, , , , , , , , >.OECJAPMAECF))]
	public Task<CBDPDIPONCF<object, FBDDJIHDMAI>> DKJMJKFDAJG(TRoot OPJBDKMKMOF, TNetSys DIGDLELNFJB, TReceiver DOCMHCDNIBE, CGBGMGFBCKF<LCNEPMDCCCO> HCJJKKIJPBP, CGBGMGFBCKF<TMRequest> OJCFKEIELKK, TAction PEMICEIPPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3865910", Offset = "0x3863F10", VA = "0x183865910")]
	[AsyncStateMachine(typeof(EHAMLGILMPC<, , , , , , , , >.BENCAHENIPL))]
	private Task<CBDPDIPONCF<object, FBDDJIHDMAI>> FBBBDBAPGPM(TRoot OPJBDKMKMOF, TNetSys DIGDLELNFJB, TReceiver DOCMHCDNIBE, CGBGMGFBCKF<LCNEPMDCCCO> HCJJKKIJPBP, CGBGMGFBCKF<TMRequest> OJCFKEIELKK, TAction PEMICEIPPPL, Task DDJFKIGJNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3866CE0", Offset = "0x38652E0", VA = "0x183866CE0")]
	[AsyncStateMachine(typeof(EHAMLGILMPC<, , , , , , , , >.LIBDFFNPDHF))]
	private Task KBOAEFFKLJB(TRoot OPJBDKMKMOF, TNetSys DIGDLELNFJB, TReceiver DOCMHCDNIBE, TAction PEMICEIPPPL, MBDLCBNCAIC HHBLLFICAIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x38665D0", Offset = "0x3864BD0", VA = "0x1838665D0")]
	private void HEIFDNGCJBJ(TRoot OPJBDKMKMOF, TNetSys DIGDLELNFJB, TReceiver DOCMHCDNIBE, CGBGMGFBCKF<LCNEPMDCCCO> HCJJKKIJPBP, TAction PEMICEIPPPL, bool PDKAPCFDEOM, bool DMEDNAFEJPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KLDPKNMOOBM
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface NIFGKHGODDN<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FNJMBIPMFCO(TNetSys GFJBHGCNBIH, TAction PEMICEIPPPL);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction FEFOHEGJEHA(TNetSys GFJBHGCNBIH, TAction PEMICEIPPPL);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction FBNKFLLMFIF(TNetSys GFJBHGCNBIH, TAction PEMICEIPPPL);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> BIAIIFEFFJH(TNetSys GFJBHGCNBIH, TAction PEMICEIPPPL);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] LDPGKLFGEGP(TNetSys GFJBHGCNBIH, TAction PEMICEIPPPL, int LHIGNCKHLPA);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool GIEMFMLBFIN(TNetSys GFJBHGCNBIH, TAction PEMICEIPPPL);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool FIILPFELPJE(TNetSys GFJBHGCNBIH, TAction PEMICEIPPPL);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool FENFDJFDHAJ(TNetSys GFJBHGCNBIH, TAction PEMICEIPPPL);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool KDFAJDEJOGK(TNetSys GFJBHGCNBIH, TAction PEMICEIPPPL);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool EBACHLLAIKJ(TNetSys GFJBHGCNBIH, TAction PEMICEIPPPL);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool GBDOALHBCBB(TNetSys GFJBHGCNBIH, TAction PEMICEIPPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface IFMPIBELOKH<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps MFMFPALONPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps GEHJJCDNIDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps ELNNLMOKFJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface MHEKMDGDJBP<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CGBGMGFBCKF<LCNEPMDCCCO> DHGDPFDPCLM(TReceiver DOCMHCDNIBE);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<CBDPDIPONCF<object, FBDDJIHDMAI>> DKJMJKFDAJG(TReceiver DOCMHCDNIBE, TAction PEMICEIPPPL);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] KHBMNFAHNMD(TReceiver DOCMHCDNIBE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface EAJBCNJANOA<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IEAJLEHNFKP(TRoot OPJBDKMKMOF);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int CGPOIKINFLM(TRoot OPJBDKMKMOF);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int DBAHAKACJGA(TRoot OPJBDKMKMOF);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int JBNKLDKNDJI(TRoot OPJBDKMKMOF);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LBKHNJHBNEC(TRoot OPJBDKMKMOF);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task FMLFFEDJMGK(TRoot OPJBDKMKMOF, CGBGMGFBCKF<LCNEPMDCCCO> HCJJKKIJPBP, CGBGMGFBCKF<TMRequest> OJCFKEIELKK, TAction PEMICEIPPPL, bool DJLOKCCPMPE = true);
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
