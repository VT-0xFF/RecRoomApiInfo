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
public interface AHGGIICDBKH<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int DPAHMMMODID(TAction FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction JFABJFDKDEI(TAction FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction AHKOAMMFMOE(TAction FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> PBLJANDPNJE(TAction FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PKCMOGIJCFO(TAction FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JNDMPLELJOL(TAction FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JOJEMFHLGGB(TAction FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FLKJBJFLDMG(TAction FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BNKIJJNACBB(TAction FFBLFKDINEA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FCFCEJDJLJM<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::KIKDNMNMFCL<OHGOKMOJKOG> BFJPNMPJELM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int EDCJMIBLFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKFDAKNELFK();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECCODLFMPHD(global::KIKDNMNMFCL<CCGONMMPPHJ> ONBCMLEDAKN, TAction FFBLFKDINEA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EEKFJPFOKCN<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int IPLMMLNHMML(in TPartialSnapshot EJOBAEDDHAI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot FOBICINJDLK(TPartialSnapshot[] ADGJDLIDLOL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MGNHGHLIBKI<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult KAAPPDGOBMB(TAction FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction[] GDLFIMPAHEI();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class OHGOKMOJKOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class CCGONMMPPHJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct LKCPLCKPKOO<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::EEKFJPFOKCN<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialSnapshot[] OLKOJNBNICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int IPPLEFLLHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps JGNODFDDAJE;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x260C3C0", Offset = "0x260B3C0", VA = "0x18260C3C0")]
	internal LKCPLCKPKOO(TPartialSnapshot[] PJFADLIPFPB, int KCKDKMMLKEN, TDeps EFNLEFOGALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x260C360", Offset = "0x260B360", VA = "0x18260C360")]
	public static global::LKCPLCKPKOO<TPartialSnapshot, TFullSnapshot, TDeps> CCFMECMIHDM(TDeps EFNLEFOGALP)
	{
		return default(global::LKCPLCKPKOO<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OIEBAPIAINO
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2478A60", Offset = "0x2477A60", VA = "0x182478A60")]
	public static global::AHICIJODGBD<TFullSnapshot> NECLNKAMCIF<TFullSnapshot, TPartialSnapshot, TDeps>(this ref global::LKCPLCKPKOO<TPartialSnapshot, TFullSnapshot, TDeps> AOFCPKBHFEM, TPartialSnapshot EJOBAEDDHAI) where TDeps : global::EEKFJPFOKCN<TPartialSnapshot, TFullSnapshot>
	{
		return default(global::AHICIJODGBD<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x261FE70", Offset = "0x261EE70", VA = "0x18261FE70")]
	public static bool EOHLCGKIAIG<TPartialSnapshot, TFullSnapshot, TDeps>(this ref global::LKCPLCKPKOO<TPartialSnapshot, TFullSnapshot, TDeps> AOFCPKBHFEM, TPartialSnapshot EJOBAEDDHAI) where TDeps : global::EEKFJPFOKCN<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class LIOEEOPFEMO : AFKOMGPKGOP
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x66B3190", Offset = "0x66B2190", VA = "0x1866B3190", Slot = "5")]
	public override string IGONAKBOEBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3215820", Offset = "0x3214820", VA = "0x183215820")]
	public LIOEEOPFEMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JNPGKOFILMD<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> where TActionReceiver : global::MGNHGHLIBKI<TAction, Task<global::APICMLLNCKG<object, AFKOMGPKGOP>>> where TActionDeps : global::AHGGIICDBKH<TAction> where TStaticNetSysDeps : global::FCFCEJDJLJM<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private interface DAPPONICOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PNLCPMHNLLK(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AFJDOPBKEHC();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::APICMLLNCKG<object, AFKOMGPKGOP> OGLDCNIHAKP();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CCMEOINDBFN(Exception BAKJIDCJBCF);
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class AKBEEFAODNH : DAPPONICOFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<global::APICMLLNCKG<object, AFKOMGPKGOP>> OPNJFDFLJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::APICMLLNCKG<object, NAHHJACPAFG>> ILAKGODFGOH;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x24EB4A0", Offset = "0x24EA4A0", VA = "0x1824EB4A0")]
		private AKBEEFAODNH(TaskCompletionSource<global::APICMLLNCKG<object, AFKOMGPKGOP>> IKIEHFEHHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x24EB220", Offset = "0x24EA220", VA = "0x1824EB220")]
		public static AKBEEFAODNH CCFMECMIHDM(TaskCompletionSource<global::APICMLLNCKG<object, AFKOMGPKGOP>> IKIEHFEHHEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x24EB400", Offset = "0x24EA400", VA = "0x1824EB400")]
		public void PNLCPMHNLLK(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x24EB140", Offset = "0x24EA140", VA = "0x1824EB140", Slot = "5")]
		public void AFJDOPBKEHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x24EB350", Offset = "0x24EA350", VA = "0x1824EB350", Slot = "6")]
		public global::APICMLLNCKG<object, AFKOMGPKGOP> OGLDCNIHAKP()
		{
			return default(global::APICMLLNCKG<object, AFKOMGPKGOP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x24EB2F0", Offset = "0x24EA2F0", VA = "0x1824EB2F0", Slot = "7")]
		public void CCMEOINDBFN(Exception BAKJIDCJBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x23C13C0", Offset = "0x23C03C0", VA = "0x1823C13C0", Slot = "4")]
		private void APPKGMDEDDB(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class GCFLCAAMELL : DAPPONICOFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<global::APICMLLNCKG<object, AFKOMGPKGOP>> OPNJFDFLJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private global::APICMLLNCKG<object, AFKOMGPKGOP> KIAMDDMAGLE;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x20293C0", Offset = "0x20283C0", VA = "0x1820293C0")]
		private GCFLCAAMELL(TaskCompletionSource<global::APICMLLNCKG<object, AFKOMGPKGOP>> IKIEHFEHHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x24EB220", Offset = "0x24EA220", VA = "0x1824EB220")]
		public static GCFLCAAMELL CCFMECMIHDM(TaskCompletionSource<global::APICMLLNCKG<object, AFKOMGPKGOP>> IKIEHFEHHEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28EBA70", Offset = "0x28EAA70", VA = "0x1828EBA70")]
		public void PNLCPMHNLLK(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x28EB9B0", Offset = "0x28EA9B0", VA = "0x1828EB9B0", Slot = "5")]
		public void AFJDOPBKEHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x700040", Offset = "0x6FF040", VA = "0x180700040", Slot = "6")]
		public global::APICMLLNCKG<object, AFKOMGPKGOP> OGLDCNIHAKP()
		{
			return default(global::APICMLLNCKG<object, AFKOMGPKGOP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28EBA10", Offset = "0x28EAA10", VA = "0x1828EBA10", Slot = "7")]
		public void CCMEOINDBFN(Exception BAKJIDCJBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x23C13C0", Offset = "0x23C03C0", VA = "0x1823C13C0", Slot = "4")]
		private void APPKGMDEDDB(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class NEMHFNLKLHE : DAPPONICOFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<global::APICMLLNCKG<object, AFKOMGPKGOP>> ILAKGODFGOH;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x23C1570", Offset = "0x23C0570", VA = "0x1823C1570")]
		private NEMHFNLKLHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x23C13F0", Offset = "0x23C03F0", VA = "0x1823C13F0")]
		public static NEMHFNLKLHE CCFMECMIHDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x23C1510", Offset = "0x23C0510", VA = "0x1823C1510")]
		public void PNLCPMHNLLK(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		public void AFJDOPBKEHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x23C14B0", Offset = "0x23C04B0", VA = "0x1823C14B0", Slot = "6")]
		public global::APICMLLNCKG<object, AFKOMGPKGOP> OGLDCNIHAKP()
		{
			return default(global::APICMLLNCKG<object, AFKOMGPKGOP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "7")]
		public void CCMEOINDBFN(Exception BAKJIDCJBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x23C13C0", Offset = "0x23C03C0", VA = "0x1823C13C0", Slot = "4")]
		private void APPKGMDEDDB(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class FEJNGMAPNGP : DAPPONICOFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private global::APICMLLNCKG<object, AFKOMGPKGOP> KIAMDDMAGLE;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		private FEJNGMAPNGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x23C13F0", Offset = "0x23C03F0", VA = "0x1823C13F0")]
		public static FEJNGMAPNGP CCFMECMIHDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x19B70B0", Offset = "0x19B60B0", VA = "0x1819B70B0")]
		public void PNLCPMHNLLK(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		public void AFJDOPBKEHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xCE53C0", Offset = "0xCE43C0", VA = "0x180CE53C0", Slot = "6")]
		public global::APICMLLNCKG<object, AFKOMGPKGOP> OGLDCNIHAKP()
		{
			return default(global::APICMLLNCKG<object, AFKOMGPKGOP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "7")]
		public void CCMEOINDBFN(Exception BAKJIDCJBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x23C13C0", Offset = "0x23C03C0", VA = "0x1823C13C0", Slot = "4")]
		private void APPKGMDEDDB(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LDBIMMBEJBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<global::APICMLLNCKG<object, AFKOMGPKGOP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::JNPGKOFILMD<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::KIKDNMNMFCL<OHGOKMOJKOG> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public global::KIKDNMNMFCL<CCGONMMPPHJ> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<global::APICMLLNCKG<object, AFKOMGPKGOP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x20B2FE0", Offset = "0x20B1FE0", VA = "0x1820B2FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x20B3290", Offset = "0x20B2290", VA = "0x1820B3290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CNIPFJHCOLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<global::APICMLLNCKG<object, AFKOMGPKGOP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public global::JNPGKOFILMD<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public global::KIKDNMNMFCL<OHGOKMOJKOG> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public global::KIKDNMNMFCL<CCGONMMPPHJ> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private DAPPONICOFF <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2EED150", Offset = "0x2EEC150", VA = "0x182EED150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2EEDB10", Offset = "0x2EECB10", VA = "0x182EEDB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct PFOOGMKILLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public global::JNPGKOFILMD<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public DAPPONICOFF completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private DAPPONICOFF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<global::APICMLLNCKG<object, AFKOMGPKGOP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2B262C0", Offset = "0x2B252C0", VA = "0x182B262C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6E7320", Offset = "0x6E6320", VA = "0x1806E7320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TActionReceiver MLDDFILJOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TActionDeps DHGCIPDFCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TStaticNetSysDeps OLODNBENJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int HAGEKOIIKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int OPAEABLOOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<global::KIKDNMNMFCL<CCGONMMPPHJ>, TaskCompletionSource<global::APICMLLNCKG<object, AFKOMGPKGOP>>> CNKDKHEGMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private global::LGPJBOHCPPN<CCGONMMPPHJ> HHLICMHKGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int CLHMNNEJAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task ILEFEPHNFKE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NCIIHPJGBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x782D00", Offset = "0x781D00", VA = "0x180782D00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7834B0", Offset = "0x7824B0", VA = "0x1807834B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3FEF8A0", Offset = "0x3FEE8A0", VA = "0x183FEF8A0")]
	protected JNPGKOFILMD(TActionDeps DPMDHKJAEIF, TStaticNetSysDeps AOHAMLECCEP, int KILGJDJGEMH, int FFCKPMGBPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3FEEE70", Offset = "0x3FEDE70", VA = "0x183FEEE70")]
	public static global::JNPGKOFILMD<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> CCFMECMIHDM(TActionDeps DPMDHKJAEIF, TStaticNetSysDeps AOHAMLECCEP, [Optional] int? KILGJDJGEMH, [Optional] int? FFCKPMGBPEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3FEEFB0", Offset = "0x3FEDFB0", VA = "0x183FEEFB0")]
	public Task<global::APICMLLNCKG<object, AFKOMGPKGOP>> ECCODLFMPHD(in TAction FFBLFKDINEA, bool EAIMJIDAPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3FEF890", Offset = "0x3FEE890", VA = "0x183FEF890")]
	public void PHPLEPDDGFL(in TActionReceiver PNHPNPBKGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3FEF3B0", Offset = "0x3FEE3B0", VA = "0x183FEF3B0")]
	[AsyncStateMachine(typeof(global::JNPGKOFILMD<, , , >.LDBIMMBEJBK))]
	public Task<global::APICMLLNCKG<object, AFKOMGPKGOP>> KAAPPDGOBMB(global::KIKDNMNMFCL<OHGOKMOJKOG> EOFJKMCNNHP, global::KIKDNMNMFCL<CCGONMMPPHJ> ONBCMLEDAKN, TAction FFBLFKDINEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3FEF720", Offset = "0x3FEE720", VA = "0x183FEF720")]
	[AsyncStateMachine(typeof(global::JNPGKOFILMD<, , , >.CNIPFJHCOLM))]
	private Task<global::APICMLLNCKG<object, AFKOMGPKGOP>> NJBMOIAFFFH(global::KIKDNMNMFCL<OHGOKMOJKOG> EOFJKMCNNHP, global::KIKDNMNMFCL<CCGONMMPPHJ> ONBCMLEDAKN, TAction FFBLFKDINEA, Task KHHICOKICMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3FEF270", Offset = "0x3FEE270", VA = "0x183FEF270")]
	[AsyncStateMachine(typeof(global::JNPGKOFILMD<, , , >.PFOOGMKILLP))]
	private Task HJJEDBBOKHG(TAction FFBLFKDINEA, DAPPONICOFF KEFJJIEPEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3FEF510", Offset = "0x3FEE510", VA = "0x183FEF510")]
	private void KEIGMDJKJFJ(TAction FFBLFKDINEA, bool FBJNLJJKEKL, bool OBOHJEHKAHA)
	{
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
