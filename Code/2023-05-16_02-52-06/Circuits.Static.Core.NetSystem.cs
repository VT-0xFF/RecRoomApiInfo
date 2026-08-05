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
public struct GLKEIKPFGHA<TPartialAction, TFullAction, TDeps> where TDeps : BLODMOOGMAI.GMBLNEDGBPD<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] PPKKAMDBDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int KLAHKEPHDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps DDAEJNDNJLK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x26BAFC0", Offset = "0x26B9DC0", VA = "0x1826BAFC0")]
	internal GLKEIKPFGHA(TPartialAction[] NPKCONEPBFA, int PMAJGBLMLIG, TDeps HJHJNAMIAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x26BAF10", Offset = "0x26B9D10", VA = "0x1826BAF10")]
	public static global::GLKEIKPFGHA<TPartialAction, TFullAction, TDeps> AIJMFKKLHCC(TDeps HJHJNAMIAKE)
	{
		return default(global::GLKEIKPFGHA<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BLODMOOGMAI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface GMBLNEDGBPD<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ALNLKGEDOAD(in TPartialAction CKBAHIMFOKC);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction JPBEJPCCNAF(TPartialAction[] DHOCHGJACPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2511410", Offset = "0x2510210", VA = "0x182511410")]
	public static global::POPJPNDPEEI<TFullAction> BOEIIEAOKDH<TFullAction, TPartialAction, TDeps>(this ref global::GLKEIKPFGHA<TPartialAction, TFullAction, TDeps> LCNEHOGIJPK, TPartialAction CKBAHIMFOKC) where TDeps : GMBLNEDGBPD<TPartialAction, TFullAction>
	{
		return default(global::POPJPNDPEEI<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JICJNFCANGE<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : MLJHOGMFFDG.NLODONELJLH<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] FEBFIHKKAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int LEFKDKONOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps DDAEJNDNJLK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x26BAF80", Offset = "0x26B9D80", VA = "0x1826BAF80")]
	internal JICJNFCANGE(TPartialSnapshot[] HOHBLAEKCGA, int JGMILDFKBFE, TDeps HJHJNAMIAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x26BAEB0", Offset = "0x26B9CB0", VA = "0x1826BAEB0")]
	public static global::JICJNFCANGE<TPartialSnapshot, TFullSnapshot, TDeps> AIJMFKKLHCC(TDeps HJHJNAMIAKE)
	{
		return default(global::JICJNFCANGE<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MLJHOGMFFDG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface NLODONELJLH<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BGDONNAIBLJ(in TPartialSnapshot LJHONDNPCGG);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot NNDGEHLBCAK(TPartialSnapshot[] CKIHMCBPNIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x25112C0", Offset = "0x25100C0", VA = "0x1825112C0")]
	public static global::POPJPNDPEEI<TFullSnapshot> BOEIIEAOKDH<TFullSnapshot, TPartialSnapshot, TDeps>(this ref global::JICJNFCANGE<TPartialSnapshot, TFullSnapshot, TDeps> LCNEHOGIJPK, TPartialSnapshot LJHONDNPCGG) where TDeps : NLODONELJLH<TPartialSnapshot, TFullSnapshot>
	{
		return default(global::POPJPNDPEEI<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2511610", Offset = "0x2510410", VA = "0x182511610")]
	public static bool KBMFCLOKJBJ<TPartialSnapshot, TFullSnapshot, TDeps>(this ref global::JICJNFCANGE<TPartialSnapshot, TFullSnapshot, TDeps> LCNEHOGIJPK, TPartialSnapshot LJHONDNPCGG) where TDeps : NLODONELJLH<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class BLPANLBMIBL : LGBLFKJLIPF
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xF0CCE0", Offset = "0xF0BAE0", VA = "0x180F0CCE0", Slot = "7")]
	public override string HKMFFLPHOOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xF0CD10", Offset = "0xF0BB10", VA = "0x180F0CD10")]
	public BLPANLBMIBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JOKEBJJDMPK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface CKFOFINGNEA<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PLFPLGKJGIK(TNetSys IPMHPHKLFGB, TAction JBJAGOLOBKN);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction BENOOEKHMCI(TNetSys IPMHPHKLFGB, TAction JBJAGOLOBKN);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction PANDMDOFMAI(TNetSys IPMHPHKLFGB, TAction JBJAGOLOBKN);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> GFIEFBHHCEP(TNetSys IPMHPHKLFGB, TAction JBJAGOLOBKN);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] CHCAHBBCCIP(TNetSys IPMHPHKLFGB, TAction JBJAGOLOBKN, int NMBMLIFDLLG);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ADECKEMJGOK(TNetSys IPMHPHKLFGB, TAction JBJAGOLOBKN);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool EMGEKADBCKP(TNetSys IPMHPHKLFGB, TAction JBJAGOLOBKN);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool LOLEBCACEOE(TNetSys IPMHPHKLFGB, TAction JBJAGOLOBKN);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool HKDCHICDBMK(TNetSys IPMHPHKLFGB, TAction JBJAGOLOBKN);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool JGMIIJOHEDJ(TNetSys IPMHPHKLFGB, TAction JBJAGOLOBKN);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool FIHLOELDIPD(TNetSys IPMHPHKLFGB, TAction JBJAGOLOBKN);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface MLABLCGPLDG<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TActionDeps FACGNCBEEDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		TReceiverDeps NHOCNCFKLFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		TRootDeps KBELGJPLHGK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface HEMOOPKLBPI<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		global::CNAENJNIHHK<TMActor> EPHKGFFPMNO(TReceiver FCIJEBBDABO);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> IHOCJAKJOEE(TReceiver FCIJEBBDABO, TAction JBJAGOLOBKN);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] BPIPKJANFPF(TReceiver FCIJEBBDABO);
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface CACAFOMFALL<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IDLOODBILGA(TRoot LFLMFMLCFKL);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int GJJMDGEPADG(TRoot LFLMFMLCFKL);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int CAEFJEPJICG(TRoot LFLMFMLCFKL);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int DIHHKFINDJB(TRoot LFLMFMLCFKL);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KCMHEOPPOLN(TRoot LFLMFMLCFKL);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task CFJEFBMHOAD(TRoot LFLMFMLCFKL, global::CNAENJNIHHK<TMActor> PIDNKAJJCDN, global::CNAENJNIHHK<TMRequest> FBEKDMEKGFB, TAction JBJAGOLOBKN, bool MBMJEOPBEKM = true);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class AMAGMOICOFP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : JOKEBJJDMPK.CKFOFINGNEA<TAction, TNetSys> where TReceiverDeps : JOKEBJJDMPK.HEMOOPKLBPI<TMActor, TAction, TReceiver> where TRootDeps : JOKEBJJDMPK.CACAFOMFALL<TMRequest, TMActor, TAction, TRoot> where TDeps : JOKEBJJDMPK.MLABLCGPLDG<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface HGIGGABEPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AGEFIKKFJOP(in global::AEGPCPFJGKN<object, MKFDOIHNKMJ> AJCHMFJLMGE);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KNDGBBCNIOI();

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::AEGPCPFJGKN<object, MKFDOIHNKMJ> JDBKEAOGFNP();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JMCPENJIINH(Exception ADJEGMMBDPA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class DCBDMPOGFEK : HGIGGABEPOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> DOGFGOFDBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::AEGPCPFJGKN<object, CBJABNKIELI>> DPOJLMMLLKP;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2F86B80", Offset = "0x2F85980", VA = "0x182F86B80")]
		private DCBDMPOGFEK(TaskCompletionSource<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> CDMHJAEBELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2353EC0", Offset = "0x2352CC0", VA = "0x182353EC0")]
		public static DCBDMPOGFEK AIJMFKKLHCC(TaskCompletionSource<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> CDMHJAEBELL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2F86660", Offset = "0x2F85460", VA = "0x182F86660")]
		public void AGEFIKKFJOP(in global::AEGPCPFJGKN<object, MKFDOIHNKMJ> AJCHMFJLMGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2F869C0", Offset = "0x2F857C0", VA = "0x182F869C0", Slot = "5")]
		public void KNDGBBCNIOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2F867A0", Offset = "0x2F855A0", VA = "0x182F867A0", Slot = "6")]
		public global::AEGPCPFJGKN<object, MKFDOIHNKMJ> JDBKEAOGFNP()
		{
			return default(global::AEGPCPFJGKN<object, MKFDOIHNKMJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2F86960", Offset = "0x2F85760", VA = "0x182F86960", Slot = "7")]
		public void JMCPENJIINH(Exception ADJEGMMBDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1E00310", Offset = "0x1DFF110", VA = "0x181E00310", Slot = "4")]
		private void CCEOCLBOIED(in global::AEGPCPFJGKN<object, MKFDOIHNKMJ> AJCHMFJLMGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class GKCBLGGGMFJ : HGIGGABEPOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> DOGFGOFDBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private global::AEGPCPFJGKN<object, MKFDOIHNKMJ> DOOHBFFCJOK;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1050770", Offset = "0x104F570", VA = "0x181050770")]
		private GKCBLGGGMFJ(TaskCompletionSource<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> CDMHJAEBELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2353EC0", Offset = "0x2352CC0", VA = "0x182353EC0")]
		public static GKCBLGGGMFJ AIJMFKKLHCC(TaskCompletionSource<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> CDMHJAEBELL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2ECE0F0", Offset = "0x2ECCEF0", VA = "0x182ECE0F0")]
		public void AGEFIKKFJOP(in global::AEGPCPFJGKN<object, MKFDOIHNKMJ> AJCHMFJLMGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x32D37A0", Offset = "0x32D25A0", VA = "0x1832D37A0", Slot = "5")]
		public void KNDGBBCNIOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7621D0", Offset = "0x760FD0", VA = "0x1807621D0", Slot = "6")]
		public global::AEGPCPFJGKN<object, MKFDOIHNKMJ> JDBKEAOGFNP()
		{
			return default(global::AEGPCPFJGKN<object, MKFDOIHNKMJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x32D36E0", Offset = "0x32D24E0", VA = "0x1832D36E0", Slot = "7")]
		public void JMCPENJIINH(Exception ADJEGMMBDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1E00310", Offset = "0x1DFF110", VA = "0x181E00310", Slot = "4")]
		private void CCEOCLBOIED(in global::AEGPCPFJGKN<object, MKFDOIHNKMJ> AJCHMFJLMGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class IEEHKGBMHFO : HGIGGABEPOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> DPOJLMMLLKP;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1E00480", Offset = "0x1DFF280", VA = "0x181E00480")]
		private IEEHKGBMHFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1E00250", Offset = "0x1DFF050", VA = "0x181E00250")]
		public static IEEHKGBMHFO AIJMFKKLHCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1E00190", Offset = "0x1DFEF90", VA = "0x181E00190")]
		public void AGEFIKKFJOP(in global::AEGPCPFJGKN<object, MKFDOIHNKMJ> AJCHMFJLMGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		public void KNDGBBCNIOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1E00340", Offset = "0x1DFF140", VA = "0x181E00340", Slot = "6")]
		public global::AEGPCPFJGKN<object, MKFDOIHNKMJ> JDBKEAOGFNP()
		{
			return default(global::AEGPCPFJGKN<object, MKFDOIHNKMJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
		public void JMCPENJIINH(Exception ADJEGMMBDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1E00310", Offset = "0x1DFF110", VA = "0x181E00310", Slot = "4")]
		private void CCEOCLBOIED(in global::AEGPCPFJGKN<object, MKFDOIHNKMJ> AJCHMFJLMGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class NLOCPPNKJPI : HGIGGABEPOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private global::AEGPCPFJGKN<object, MKFDOIHNKMJ> DOOHBFFCJOK;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		private NLOCPPNKJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1E00250", Offset = "0x1DFF050", VA = "0x181E00250")]
		public static NLOCPPNKJPI AIJMFKKLHCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2FFE2B0", Offset = "0x2FFD0B0", VA = "0x182FFE2B0")]
		public void AGEFIKKFJOP(in global::AEGPCPFJGKN<object, MKFDOIHNKMJ> AJCHMFJLMGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		public void KNDGBBCNIOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xD5A960", Offset = "0xD59760", VA = "0x180D5A960", Slot = "6")]
		public global::AEGPCPFJGKN<object, MKFDOIHNKMJ> JDBKEAOGFNP()
		{
			return default(global::AEGPCPFJGKN<object, MKFDOIHNKMJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
		public void JMCPENJIINH(Exception ADJEGMMBDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1E00310", Offset = "0x1DFF110", VA = "0x181E00310", Slot = "4")]
		private void CCEOCLBOIED(in global::AEGPCPFJGKN<object, MKFDOIHNKMJ> AJCHMFJLMGE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct FMGFADFKHJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::AMAGMOICOFP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public global::CNAENJNIHHK<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2A71A50", Offset = "0x2A70850", VA = "0x182A71A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2A723C0", Offset = "0x2A711C0", VA = "0x182A723C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct EGIKIJGAOOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::AMAGMOICOFP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public global::CNAENJNIHHK<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3229D30", Offset = "0x3228B30", VA = "0x183229D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x322A510", Offset = "0x3229310", VA = "0x18322A510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct AFNDFKMOIMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::AMAGMOICOFP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public global::CNAENJNIHHK<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public global::CNAENJNIHHK<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x33F6160", Offset = "0x33F4F60", VA = "0x1833F6160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x33F6450", Offset = "0x33F5250", VA = "0x1833F6450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct GNCDDLDFPII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::AMAGMOICOFP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public global::CNAENJNIHHK<TMActor> senderId;

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
		public global::CNAENJNIHHK<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private HGIGGABEPOJ <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3AB6410", Offset = "0x3AB5210", VA = "0x183AB6410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3AB6F10", Offset = "0x3AB5D10", VA = "0x183AB6F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PKFEEBGHMNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::AMAGMOICOFP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public HGIGGABEPOJ completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private HGIGGABEPOJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2014250", Offset = "0x2013050", VA = "0x182014250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps DDAEJNDNJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<global::CNAENJNIHHK<TMRequest>, TaskCompletionSource<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>>> BEHJPLLLDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private global::FMGKAJIAIGG<TMRequest> IPBHGJFDGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int PPEOMLOEKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task PJCGOMNMGMK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TActionDeps FACGNCBEEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x24F4280", Offset = "0x24F3080", VA = "0x1824F4280")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private TRootDeps KBELGJPLHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x24F4280", Offset = "0x24F3080", VA = "0x1824F4280")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private TReceiverDeps NHOCNCFKLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x24F4280", Offset = "0x24F3080", VA = "0x1824F4280")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KCMKHJMJFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8496E0", Offset = "0x8484E0", VA = "0x1808496E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x118DC20", Offset = "0x118CA20", VA = "0x18118DC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GHPNEGOKPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x849660", Offset = "0x848460", VA = "0x180849660")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x118DC90", Offset = "0x118CA90", VA = "0x18118DC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int LCPABKKNHBO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x763340", Offset = "0x762140", VA = "0x180763340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x24F4FD0", Offset = "0x24F3DD0", VA = "0x1824F4FD0")]
	public AMAGMOICOFP(TDeps HJHJNAMIAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x24F3580", Offset = "0x24F2380", VA = "0x1824F3580")]
	public Task<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> CFJEFBMHOAD(TRoot LFLMFMLCFKL, TNetSys LEHCJPCDAIB, global::CNAENJNIHHK<TMActor> PIDNKAJJCDN, TAction JBJAGOLOBKN, bool DLNDIDPLEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x24F3410", Offset = "0x24F2210", VA = "0x1824F3410")]
	[AsyncStateMachine(typeof(global::AMAGMOICOFP<, , , , , , , , , >.FMGFADFKHJE))]
	private Task<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> CFJEFBMHOAD(TRoot LFLMFMLCFKL, global::CNAENJNIHHK<TMActor> PIDNKAJJCDN, TAction JBJAGOLOBKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x24F4470", Offset = "0x24F3270", VA = "0x1824F4470")]
	[AsyncStateMachine(typeof(global::AMAGMOICOFP<, , , , , , , , , >.EGIKIJGAOOG))]
	private Task<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> EGKPIKHIGBD(TRoot LFLMFMLCFKL, global::CNAENJNIHHK<TMActor> PIDNKAJJCDN, TAction[] KBBGMCNGHMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x24F4770", Offset = "0x24F3570", VA = "0x1824F4770")]
	[AsyncStateMachine(typeof(global::AMAGMOICOFP<, , , , , , , , , >.AFNDFKMOIMJ))]
	public Task<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> IHOCJAKJOEE(TRoot LFLMFMLCFKL, TNetSys DNFKLBOGNFK, TReceiver FCIJEBBDABO, global::CNAENJNIHHK<TMActor> PIDNKAJJCDN, global::CNAENJNIHHK<TMRequest> FBEKDMEKGFB, TAction JBJAGOLOBKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x24F40E0", Offset = "0x24F2EE0", VA = "0x1824F40E0")]
	[AsyncStateMachine(typeof(global::AMAGMOICOFP<, , , , , , , , , >.GNCDDLDFPII))]
	private Task<global::AEGPCPFJGKN<object, MKFDOIHNKMJ>> DIJNMAPJADG(TRoot LFLMFMLCFKL, TNetSys DNFKLBOGNFK, TReceiver FCIJEBBDABO, global::CNAENJNIHHK<TMActor> PIDNKAJJCDN, global::CNAENJNIHHK<TMRequest> FBEKDMEKGFB, TAction JBJAGOLOBKN, Task DBJNHHKMENO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x24F3DC0", Offset = "0x24F2BC0", VA = "0x1824F3DC0")]
	[AsyncStateMachine(typeof(global::AMAGMOICOFP<, , , , , , , , , >.PKFEEBGHMNK))]
	private Task CPECHGPDPFH(TRoot LFLMFMLCFKL, TNetSys DNFKLBOGNFK, TReceiver FCIJEBBDABO, TAction JBJAGOLOBKN, HGIGGABEPOJ ENPELMOGHNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x24F4BF0", Offset = "0x24F39F0", VA = "0x1824F4BF0")]
	private void KJIJOKFIGJL(TRoot LFLMFMLCFKL, TNetSys DNFKLBOGNFK, TReceiver FCIJEBBDABO, global::CNAENJNIHHK<TMActor> PIDNKAJJCDN, TAction JBJAGOLOBKN, bool HGGGKOGCJIF, bool IGOIOEPNDCC)
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
