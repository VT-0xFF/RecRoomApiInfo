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
public struct LKCPLCKPKOO<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : OIEBAPIAINO.JPCAMOLGLFK<TPartialSnapshot, TFullSnapshot>
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

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2A64B50", Offset = "0x2A63F50", VA = "0x182A64B50")]
	internal LKCPLCKPKOO(TPartialSnapshot[] PJFADLIPFPB, int KCKDKMMLKEN, TDeps EFNLEFOGALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A64AF0", Offset = "0x2A63EF0", VA = "0x182A64AF0")]
	public static global::LKCPLCKPKOO<TPartialSnapshot, TFullSnapshot, TDeps> CCFMECMIHDM(TDeps EFNLEFOGALP)
	{
		return default(global::LKCPLCKPKOO<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OIEBAPIAINO
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface JPCAMOLGLFK<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IPLMMLNHMML(in TPartialSnapshot EJOBAEDDHAI);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot FOBICINJDLK(TPartialSnapshot[] ADGJDLIDLOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A45360", Offset = "0x2A44760", VA = "0x182A45360")]
	public static global::AHICIJODGBD<TFullSnapshot> NECLNKAMCIF<TFullSnapshot, TPartialSnapshot, TDeps>(this ref global::LKCPLCKPKOO<TPartialSnapshot, TFullSnapshot, TDeps> AOFCPKBHFEM, TPartialSnapshot EJOBAEDDHAI) where TDeps : JPCAMOLGLFK<TPartialSnapshot, TFullSnapshot>
	{
		return default(global::AHICIJODGBD<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A45280", Offset = "0x2A44680", VA = "0x182A45280")]
	public static bool EOHLCGKIAIG<TPartialSnapshot, TFullSnapshot, TDeps>(this ref global::LKCPLCKPKOO<TPartialSnapshot, TFullSnapshot, TDeps> AOFCPKBHFEM, TPartialSnapshot EJOBAEDDHAI) where TDeps : JPCAMOLGLFK<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class LIOEEOPFEMO : AFKOMGPKGOP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xEA5AE0", Offset = "0xEA4EE0", VA = "0x180EA5AE0", Slot = "5")]
	public override string IGONAKBOEBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xEA5B10", Offset = "0xEA4F10", VA = "0x180EA5B10")]
	public LIOEEOPFEMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NKBPONGKAEI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface HGHINBFDELF<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DPAHMMMODID(TNetSys GEGLNKIHOJH, TAction FFBLFKDINEA);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction JFABJFDKDEI(TNetSys GEGLNKIHOJH, TAction FFBLFKDINEA);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction AHKOAMMFMOE(TNetSys GEGLNKIHOJH, TAction FFBLFKDINEA);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> PBLJANDPNJE(TNetSys GEGLNKIHOJH, TAction FFBLFKDINEA);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool PKCMOGIJCFO(TNetSys GEGLNKIHOJH, TAction FFBLFKDINEA);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool JNDMPLELJOL(TNetSys GEGLNKIHOJH, TAction FFBLFKDINEA);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool JOJEMFHLGGB(TNetSys GEGLNKIHOJH, TAction FFBLFKDINEA);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool FLKJBJFLDMG(TNetSys GEGLNKIHOJH, TAction FFBLFKDINEA);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool BNKIJJNACBB(TNetSys GEGLNKIHOJH, TAction FFBLFKDINEA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface BMICOOIHIFE<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TActionDeps NLEAJEODGIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		TReceiverDeps EDILCDKGNHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		TRootDeps IEBLEIOHHNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface EJNIPKNAPBD<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		global::KIKDNMNMFCL<TMActor> FMIEGCGAJKF(TReceiver OICNAHPNIJJ);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<global::APICMLLNCKG<object, AFKOMGPKGOP>> KAAPPDGOBMB(TReceiver OICNAHPNIJJ, TAction FFBLFKDINEA);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] GDLFIMPAHEI(TReceiver OICNAHPNIJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface NDDBMGNGADP<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JAEKAFEJHBH(TRoot IGJDJDNFANI);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int EBGIHCCKILJ(TRoot IGJDJDNFANI);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int BLMLBCAPCHA(TRoot IGJDJDNFANI);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NKFDAKNELFK(TRoot IGJDJDNFANI);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task ECCODLFMPHD(TRoot IGJDJDNFANI, global::KIKDNMNMFCL<TMActor> BEBIFELFGPB, global::KIKDNMNMFCL<TMRequest> ONBCMLEDAKN, TAction FFBLFKDINEA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class NOEKLDDBFLH<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : NKBPONGKAEI.HGHINBFDELF<TAction, TNetSys> where TReceiverDeps : NKBPONGKAEI.EJNIPKNAPBD<TMActor, TAction, TReceiver> where TRootDeps : NKBPONGKAEI.NDDBMGNGADP<TMRequest, TMActor, TAction, TRoot> where TDeps : NKBPONGKAEI.BMICOOIHIFE<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private interface HHHOIFJJMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PNLCPMHNLLK(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AFJDOPBKEHC();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::APICMLLNCKG<object, AFKOMGPKGOP> OGLDCNIHAKP();

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CCMEOINDBFN(Exception BAKJIDCJBCF);
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class IKMFOLGOPHP : HHHOIFJJMOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly TaskCompletionSource<global::APICMLLNCKG<object, AFKOMGPKGOP>> OPNJFDFLJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly List<global::APICMLLNCKG<object, NAHHJACPAFG>> ILAKGODFGOH;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2268060", Offset = "0x2267460", VA = "0x182268060")]
		private IKMFOLGOPHP(TaskCompletionSource<global::APICMLLNCKG<object, AFKOMGPKGOP>> IKIEHFEHHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x22679B0", Offset = "0x2266DB0", VA = "0x1822679B0")]
		public static IKMFOLGOPHP CCFMECMIHDM(TaskCompletionSource<global::APICMLLNCKG<object, AFKOMGPKGOP>> IKIEHFEHHEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2267E80", Offset = "0x2267280", VA = "0x182267E80")]
		public void PNLCPMHNLLK(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x22677F0", Offset = "0x2266BF0", VA = "0x1822677F0", Slot = "5")]
		public void AFJDOPBKEHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2267C80", Offset = "0x2267080", VA = "0x182267C80", Slot = "6")]
		public global::APICMLLNCKG<object, AFKOMGPKGOP> OGLDCNIHAKP()
		{
			return default(global::APICMLLNCKG<object, AFKOMGPKGOP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2267A80", Offset = "0x2266E80", VA = "0x182267A80", Slot = "7")]
		public void CCMEOINDBFN(Exception BAKJIDCJBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2267BA0", Offset = "0x2266FA0", VA = "0x182267BA0", Slot = "4")]
		private void IOKGDGBCAHJ(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class FFFIGGJPBDG : HHHOIFJJMOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly TaskCompletionSource<global::APICMLLNCKG<object, AFKOMGPKGOP>> OPNJFDFLJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private global::APICMLLNCKG<object, AFKOMGPKGOP> KIAMDDMAGLE;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1F8F3E0", Offset = "0x1F8E7E0", VA = "0x181F8F3E0")]
		private FFFIGGJPBDG(TaskCompletionSource<global::APICMLLNCKG<object, AFKOMGPKGOP>> IKIEHFEHHEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x22679B0", Offset = "0x2266DB0", VA = "0x1822679B0")]
		public static FFFIGGJPBDG CCFMECMIHDM(TaskCompletionSource<global::APICMLLNCKG<object, AFKOMGPKGOP>> IKIEHFEHHEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8DE0", Offset = "0x2AA81E0", VA = "0x182AA8DE0")]
		public void PNLCPMHNLLK(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8C60", Offset = "0x2AA8060", VA = "0x182AA8C60", Slot = "5")]
		public void AFJDOPBKEHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x701040", Offset = "0x700440", VA = "0x180701040", Slot = "6")]
		public global::APICMLLNCKG<object, AFKOMGPKGOP> OGLDCNIHAKP()
		{
			return default(global::APICMLLNCKG<object, AFKOMGPKGOP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8D80", Offset = "0x2AA8180", VA = "0x182AA8D80", Slot = "7")]
		public void CCMEOINDBFN(Exception BAKJIDCJBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2267BA0", Offset = "0x2266FA0", VA = "0x182267BA0", Slot = "4")]
		private void IOKGDGBCAHJ(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class LGBIOCIODAF : HHHOIFJJMOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly List<global::APICMLLNCKG<object, AFKOMGPKGOP>> ILAKGODFGOH;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2A50360", Offset = "0x2A4F760", VA = "0x182A50360")]
		private LGBIOCIODAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FF60", Offset = "0x2A4F360", VA = "0x182A4FF60")]
		public static LGBIOCIODAF CCFMECMIHDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2A50200", Offset = "0x2A4F600", VA = "0x182A50200")]
		public void PNLCPMHNLLK(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		public void AFJDOPBKEHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2A50080", Offset = "0x2A4F480", VA = "0x182A50080", Slot = "6")]
		public global::APICMLLNCKG<object, AFKOMGPKGOP> OGLDCNIHAKP()
		{
			return default(global::APICMLLNCKG<object, AFKOMGPKGOP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "7")]
		public void CCMEOINDBFN(Exception BAKJIDCJBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2267BA0", Offset = "0x2266FA0", VA = "0x182267BA0", Slot = "4")]
		private void IOKGDGBCAHJ(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class OMAMEHPPLHN : HHHOIFJJMOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::APICMLLNCKG<object, AFKOMGPKGOP> KIAMDDMAGLE;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		private OMAMEHPPLHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FF60", Offset = "0x2A4F360", VA = "0x182A4FF60")]
		public static OMAMEHPPLHN CCFMECMIHDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x168F0B0", Offset = "0x168E4B0", VA = "0x18168F0B0")]
		public void PNLCPMHNLLK(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		public void AFJDOPBKEHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xCE63C0", Offset = "0xCE57C0", VA = "0x180CE63C0", Slot = "6")]
		public global::APICMLLNCKG<object, AFKOMGPKGOP> OGLDCNIHAKP()
		{
			return default(global::APICMLLNCKG<object, AFKOMGPKGOP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "7")]
		public void CCMEOINDBFN(Exception BAKJIDCJBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2267BA0", Offset = "0x2266FA0", VA = "0x182267BA0", Slot = "4")]
		private void IOKGDGBCAHJ(in global::APICMLLNCKG<object, AFKOMGPKGOP> GPPHCPBMODE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct ONOLKKBNJPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<global::APICMLLNCKG<object, AFKOMGPKGOP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public global::NOEKLDDBFLH<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::KIKDNMNMFCL<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::KIKDNMNMFCL<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter<global::APICMLLNCKG<object, AFKOMGPKGOP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x453BFE0", Offset = "0x453B3E0", VA = "0x18453BFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x453C8F0", Offset = "0x453BCF0", VA = "0x18453C8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct ALJBNGNDPCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<global::APICMLLNCKG<object, AFKOMGPKGOP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::NOEKLDDBFLH<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public global::KIKDNMNMFCL<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public global::KIKDNMNMFCL<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private HHHOIFJJMOE <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3B45160", Offset = "0x3B44560", VA = "0x183B45160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3B45DA0", Offset = "0x3B451A0", VA = "0x183B45DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct GECLBFFGKBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public global::NOEKLDDBFLH<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public HHHOIFJJMOE completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private HHHOIFJJMOE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<global::APICMLLNCKG<object, AFKOMGPKGOP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x32EA870", Offset = "0x32E9C70", VA = "0x1832EA870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct FNBDLEBBCGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<global::APICMLLNCKG<object, AFKOMGPKGOP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Task sendTask_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task<global::APICMLLNCKG<object, AFKOMGPKGOP>> tcsTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<global::APICMLLNCKG<object, AFKOMGPKGOP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC130", Offset = "0x2ABB530", VA = "0x182ABC130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC570", Offset = "0x2ABB970", VA = "0x182ABC570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly TDeps JGNODFDDAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<global::KIKDNMNMFCL<TMRequest>, TaskCompletionSource<global::APICMLLNCKG<object, AFKOMGPKGOP>>> CNKDKHEGMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private global::LGPJBOHCPPN<TMRequest> HHLICMHKGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private int CLHMNNEJAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task ILEFEPHNFKE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TActionDeps NLEAJEODGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3325720", Offset = "0x3324B20", VA = "0x183325720")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private TRootDeps IEBLEIOHHNG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3325800", Offset = "0x3324C00", VA = "0x183325800")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private TReceiverDeps EDILCDKGNHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x33267A0", Offset = "0x3325BA0", VA = "0x1833267A0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LNDHELAPLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7D1010", Offset = "0x7D0410", VA = "0x1807D1010")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x14515C0", Offset = "0x14509C0", VA = "0x1814515C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int FGCMLICADCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7021B0", Offset = "0x7015B0", VA = "0x1807021B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3327270", Offset = "0x3326670", VA = "0x183327270")]
	public NOEKLDDBFLH(TDeps EFNLEFOGALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x33258E0", Offset = "0x3324CE0", VA = "0x1833258E0")]
	public Task<global::APICMLLNCKG<object, AFKOMGPKGOP>> ECCODLFMPHD(TRoot IGJDJDNFANI, TNetSys CHEOIKNJJOH, global::KIKDNMNMFCL<TMActor> BEBIFELFGPB, TAction FFBLFKDINEA, bool EAIMJIDAPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3326A10", Offset = "0x3325E10", VA = "0x183326A10")]
	[AsyncStateMachine(typeof(global::NOEKLDDBFLH<, , , , , , , , , >.ONOLKKBNJPF))]
	public Task<global::APICMLLNCKG<object, AFKOMGPKGOP>> KAAPPDGOBMB(TRoot IGJDJDNFANI, TNetSys MGGGMPIPKCO, TReceiver OICNAHPNIJJ, global::KIKDNMNMFCL<TMActor> BEBIFELFGPB, global::KIKDNMNMFCL<TMRequest> ONBCMLEDAKN, TAction FFBLFKDINEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3326E30", Offset = "0x3326230", VA = "0x183326E30")]
	[AsyncStateMachine(typeof(global::NOEKLDDBFLH<, , , , , , , , , >.ALJBNGNDPCA))]
	private Task<global::APICMLLNCKG<object, AFKOMGPKGOP>> NJBMOIAFFFH(TRoot IGJDJDNFANI, TNetSys MGGGMPIPKCO, TReceiver OICNAHPNIJJ, global::KIKDNMNMFCL<TMActor> BEBIFELFGPB, global::KIKDNMNMFCL<TMRequest> ONBCMLEDAKN, TAction FFBLFKDINEA, Task KHHICOKICMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x33264C0", Offset = "0x33258C0", VA = "0x1833264C0")]
	[AsyncStateMachine(typeof(global::NOEKLDDBFLH<, , , , , , , , , >.GECLBFFGKBE))]
	private Task HJJEDBBOKHG(TRoot IGJDJDNFANI, TNetSys MGGGMPIPKCO, TReceiver OICNAHPNIJJ, TAction FFBLFKDINEA, HHHOIFJJMOE KEFJJIEPEEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3326BA0", Offset = "0x3325FA0", VA = "0x183326BA0")]
	private void KEIGMDJKJFJ(TRoot IGJDJDNFANI, TNetSys MGGGMPIPKCO, TReceiver OICNAHPNIJJ, global::KIKDNMNMFCL<TMActor> BEBIFELFGPB, TAction FFBLFKDINEA, bool FBJNLJJKEKL, bool OBOHJEHKAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3326200", Offset = "0x3325600", VA = "0x183326200")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(global::NOEKLDDBFLH<, , , , , , , , , >.FNBDLEBBCGI))]
	internal static Task<global::APICMLLNCKG<object, AFKOMGPKGOP>> FGADLGKCOAE(Task EDNMOIDHAGP, Task<global::APICMLLNCKG<object, AFKOMGPKGOP>> DHGIPCGCNML)
	{
		return null;
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
