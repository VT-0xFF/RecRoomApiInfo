using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.ObjectModel.ConfigUI;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal abstract class NJFJCGDODCK : global::HLODLMKGFGK<Enum>, JHHLFIDIJIH, EGJEAELIIPF, GDLCMNAECNL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool PHAJFGFMCPG(Type DDJDPMGLPAE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x63F7310", Offset = "0x63F6710", VA = "0x1863F7310")]
	protected NJFJCGDODCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class HLODLMKGFGK<T> : EGJEAELIIPF, GDLCMNAECNL where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void CIMKEBPIMIG(Func<T> KPOLIFAAICN, Action<T> HNCPDLIBBAB, string IGHJIHNAPBA, FNOOJMKBHOH LKAENGEIFGG, Func<bool> JJHIIAHJFDM);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void PHFIMPFHIDI(Func<int> KPOLIFAAICN, Action<int> HNCPDLIBBAB, string IGHJIHNAPBA, FNOOJMKBHOH LKAENGEIFGG, Func<bool> JJHIIAHJFDM);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class HFNHDHIHHAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public KAANBEDLICJ targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public FNOOJMKBHOH property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public HFNHDHIHHAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x31C3B10", Offset = "0x31C2F10", VA = "0x1831C3B10")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x31C3BB0", Offset = "0x31C2FB0", VA = "0x1831C3BB0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x77F530", Offset = "0x77E930", VA = "0x18077F530")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class EAIHODOFHFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::HLODLMKGFGK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public IDCFEKNBOPC ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public EAIHODOFHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3B79310", Offset = "0x3B78710", VA = "0x183B79310")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, FNOOJMKBHOH property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class IMEALIPOMPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public IMEALIPOMPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DF60", Offset = "0x2B8D360", VA = "0x182B8DF60")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E150", Offset = "0x2B8D550", VA = "0x182B8E150")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x31CB4F0", Offset = "0x31CA8F0", VA = "0x1831CB4F0")]
	protected HLODLMKGFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x31CABD0", Offset = "0x31C9FD0", VA = "0x1831CABD0", Slot = "5")]
	public virtual void ABCONAOMHCF(KAANBEDLICJ ONBEDFCJOLM, FNOOJMKBHOH LKAENGEIFGG, IDCFEKNBOPC FIHFDFEAFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x31CB210", Offset = "0x31CA610", VA = "0x1831CB210", Slot = "6")]
	protected virtual CIMKEBPIMIG HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x31CB1C0", Offset = "0x31CA5C0", VA = "0x1831CB1C0", Slot = "7")]
	protected virtual PHFIMPFHIDI GKAKPOAGNGK(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x31CB0F0", Offset = "0x31CA4F0", VA = "0x1831CB0F0")]
	private static Enum EJNLJDDKNND(KAANBEDLICJ ONBEDFCJOLM, FNOOJMKBHOH LKAENGEIFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x31CB310", Offset = "0x31CA710", VA = "0x1831CB310")]
	private static void OIOOFMFJBBN(KAANBEDLICJ ONBEDFCJOLM, FNOOJMKBHOH LKAENGEIFGG, Enum JFBPNBNBHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class HEEBHLAABND : PPPPFPIPEID, GDLCMNAECNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private FNOOJMKBHOH[] LONDAJLDJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private FNOOJMKBHOH[] MIICOAIOJNF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FNOOJMKBHOH[] JDDHPPJAIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public FNOOJMKBHOH[] PIBMFBIAIAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract CNFMDAKFLAB[] AEEIOHCOKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract CNFMDAKFLAB[] BICLBDADHMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x63F6650", Offset = "0x63F5A50", VA = "0x1863F6650", Slot = "6")]
	public void HBGEMGCKMHE(PMEGIOPIHFM MEGLNFKLOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void ABCONAOMHCF(KAANBEDLICJ ONBEDFCJOLM, IDCFEKNBOPC FIHFDFEAFPA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x35C6790", Offset = "0x35C5B90", VA = "0x1835C6790")]
	protected static T BDBHAMAMNEF<T>(KAANBEDLICJ ONBEDFCJOLM, FNOOJMKBHOH LKAENGEIFGG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x35C67E0", Offset = "0x35C5BE0", VA = "0x1835C67E0")]
	protected static void FAOKIKBFOPE<T>(KAANBEDLICJ ONBEDFCJOLM, FNOOJMKBHOH LKAENGEIFGG, T JFBPNBNBHOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	protected HEEBHLAABND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class LFKIGBJBPJG<T> : EGJEAELIIPF, GDLCMNAECNL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void MEONAMHMNCP(Func<T> KPOLIFAAICN, Action<T> HNCPDLIBBAB, string IGHJIHNAPBA, FNOOJMKBHOH LKAENGEIFGG, Func<bool> JJHIIAHJFDM);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LGOOCBFGKPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public KAANBEDLICJ targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public FNOOJMKBHOH property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1B71870", Offset = "0x1B70C70", VA = "0x181B71870")]
		public LGOOCBFGKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x469BBF0", Offset = "0x469AFF0", VA = "0x18469BBF0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x469BEF0", Offset = "0x469B2F0", VA = "0x18469BEF0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x77F530", Offset = "0x77E930", VA = "0x18077F530")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2DA0260", Offset = "0x2D9F660", VA = "0x182DA0260")]
	protected LFKIGBJBPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F250", Offset = "0x2D9E650", VA = "0x182D9F250", Slot = "4")]
	public void ABCONAOMHCF(KAANBEDLICJ ONBEDFCJOLM, FNOOJMKBHOH LKAENGEIFGG, IDCFEKNBOPC FIHFDFEAFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2D9F6F0", Offset = "0x2D9EAF0", VA = "0x182D9F6F0")]
	private static T BDBHAMAMNEF(KAANBEDLICJ ONBEDFCJOLM, FNOOJMKBHOH LKAENGEIFGG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2D9FD30", Offset = "0x2D9F130", VA = "0x182D9FD30")]
	private static void FAOKIKBFOPE(KAANBEDLICJ ONBEDFCJOLM, FNOOJMKBHOH LKAENGEIFGG, T JFBPNBNBHOE)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[MBALNPKLAGP(FOFKCKDBIPD.ConfigUI)]
	[LOJIIDJFKAI(typeof(IKKODJHDIHF), new string[] { })]
	internal class ConfigUIService : IKKODJHDIHF, DPDCPMNGBKH, FPHKGEBJIKC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[IMNMHIBEIDL]
		private PMEGIOPIHFM MEGLNFKLOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[IMNMHIBEIDL]
		private LFJAPFGLCMI JGGECCOPCHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[IMNMHIBEIDL]
		private IDCFEKNBOPC OMEEDAMKMLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private ENDIFNDHFFO HIBHLNPKKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private KAANBEDLICJ ONBEDFCJOLM;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x63F4620", Offset = "0x63F3A20", VA = "0x1863F4620", Slot = "5")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x63F3DB0", Offset = "0x63F31B0", VA = "0x1863F3DB0", Slot = "6")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x63F3C00", Offset = "0x63F3000", VA = "0x1863F3C00", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63F40B0", Offset = "0x63F34B0", VA = "0x1863F40B0", Slot = "4")]
		public void LFAFPOAPPID(KAANBEDLICJ KLBPBOPEBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x63F3CF0", Offset = "0x63F30F0", VA = "0x1863F3CF0")]
		private void GAAPFLMMONL(KAANBEDLICJ KLBPBOPEBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x63F3D80", Offset = "0x63F3180", VA = "0x1863F3D80")]
		private void IEOJIMLADCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63F3980", Offset = "0x63F2D80", VA = "0x1863F3980")]
		private void ABCONAOMHCF(BPBAEMLPBMC DGLMNJAIEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[PBBADOKAJLN(0)]
internal class IHJOGPHPBKC : NJFJCGDODCK
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x63F7260", Offset = "0x63F6660", VA = "0x1863F7260", Slot = "9")]
	public override bool PHAJFGFMCPG(Type DDJDPMGLPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x63F7170", Offset = "0x63F6570", VA = "0x1863F7170", Slot = "6")]
	protected override CIMKEBPIMIG HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x63F7310", Offset = "0x63F6710", VA = "0x1863F7310")]
	public IHJOGPHPBKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[PBBADOKAJLN(0)]
internal class KMMGDPLLPFM : NJFJCGDODCK
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x63F7C10", Offset = "0x63F7010", VA = "0x1863F7C10", Slot = "9")]
	public override bool PHAJFGFMCPG(Type DDJDPMGLPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x63F7B20", Offset = "0x63F6F20", VA = "0x1863F7B20", Slot = "6")]
	protected override CIMKEBPIMIG HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x63F7310", Offset = "0x63F6710", VA = "0x1863F7310")]
	public KMMGDPLLPFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[CPCHDIGKIKP(typeof(IMELIOLJHMF), 1)]
internal class AFGKFLGHHPO : global::HLODLMKGFGK<IMELIOLJHMF>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x63F28A0", Offset = "0x63F1CA0", VA = "0x1863F28A0", Slot = "7")]
	protected override PHFIMPFHIDI GKAKPOAGNGK(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63F2990", Offset = "0x63F1D90", VA = "0x1863F2990")]
	public AFGKFLGHHPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FLADAGGEJLD
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x63F6350", Offset = "0x63F5750", VA = "0x1863F6350")]
	public static bool PHCPKLBPEBN(this FNOOJMKBHOH LKAENGEIFGG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[AKGCNJABNNJ(2)]
internal class HNOHNMAAFOC : HEEBHLAABND
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class GLOFOMDLPBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public KAANBEDLICJ targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public HNOHNMAAFOC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public GLOFOMDLPBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x63F6490", Offset = "0x63F5890", VA = "0x1863F6490")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x63F65C0", Offset = "0x63F59C0", VA = "0x1863F65C0")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x77F530", Offset = "0x77E930", VA = "0x18077F530")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override CNFMDAKFLAB[] BICLBDADHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x63F6FB0", Offset = "0x63F63B0", VA = "0x1863F6FB0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override CNFMDAKFLAB[] AEEIOHCOKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x63F7090", Offset = "0x63F6490", VA = "0x1863F7090", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x63F6BF0", Offset = "0x63F5FF0", VA = "0x1863F6BF0", Slot = "10")]
	public override void ABCONAOMHCF(KAANBEDLICJ ONBEDFCJOLM, IDCFEKNBOPC FIHFDFEAFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public HNOHNMAAFOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[CPCHDIGKIKP(typeof(bool))]
internal class EFALBIECNBD : global::LFKIGBJBPJG<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x63F5060", Offset = "0x63F4460", VA = "0x1863F5060", Slot = "5")]
	protected override MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x63F5150", Offset = "0x63F4550", VA = "0x1863F5150")]
	public EFALBIECNBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[CPCHDIGKIKP(typeof(FixedString32))]
internal class DAGAAPLCACP : global::LFKIGBJBPJG<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class PAEEEKKDMLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public IDCFEKNBOPC ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PAEEEKKDMLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x63F8830", Offset = "0x63F7C30", VA = "0x1863F8830")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, FNOOJMKBHOH property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PFJINEOELAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PFJINEOELAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x63F89C0", Offset = "0x63F7DC0", VA = "0x1863F89C0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x63F8A30", Offset = "0x63F7E30", VA = "0x1863F8A30")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x63F4700", Offset = "0x63F3B00", VA = "0x1863F4700", Slot = "5")]
	protected override MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x63F47C0", Offset = "0x63F3BC0", VA = "0x1863F47C0")]
	public DAGAAPLCACP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[CPCHDIGKIKP(typeof(FixedString64))]
internal class OBICAEGLGIE : global::LFKIGBJBPJG<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class HFBIDMKIMDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public IDCFEKNBOPC ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public HFBIDMKIMDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x63F6A60", Offset = "0x63F5E60", VA = "0x1863F6A60")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, FNOOJMKBHOH property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class COPPIPJDEFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public COPPIPJDEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x63F3850", Offset = "0x63F2C50", VA = "0x1863F3850")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x63F38E0", Offset = "0x63F2CE0", VA = "0x1863F38E0")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x63F8730", Offset = "0x63F7B30", VA = "0x1863F8730", Slot = "5")]
	protected override MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x63F87F0", Offset = "0x63F7BF0", VA = "0x1863F87F0")]
	public OBICAEGLGIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[CPCHDIGKIKP(typeof(float))]
internal class LDPGIHGDPEL : global::LFKIGBJBPJG<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x63F8010", Offset = "0x63F7410", VA = "0x1863F8010", Slot = "5")]
	protected override MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x63F8100", Offset = "0x63F7500", VA = "0x1863F8100")]
	public LDPGIHGDPEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[CPCHDIGKIKP(typeof(int))]
internal class NBPINCCPPJD : global::LFKIGBJBPJG<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x63F8500", Offset = "0x63F7900", VA = "0x1863F8500", Slot = "5")]
	protected override MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x63F85F0", Offset = "0x63F79F0", VA = "0x1863F85F0")]
	public NBPINCCPPJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[CPCHDIGKIKP(typeof(uint))]
internal class MIHPPBDIABL : global::LFKIGBJBPJG<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MJIOJLMOIMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public IDCFEKNBOPC ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public MJIOJLMOIMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x63F8320", Offset = "0x63F7720", VA = "0x1863F8320")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, FNOOJMKBHOH property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DFNMNFDJOEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public DFNMNFDJOEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x63F4800", Offset = "0x63F3C00", VA = "0x1863F4800")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x63F4850", Offset = "0x63F3C50", VA = "0x1863F4850")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x63F8220", Offset = "0x63F7620", VA = "0x1863F8220", Slot = "5")]
	protected override MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x63F82E0", Offset = "0x63F76E0", VA = "0x1863F82E0")]
	public MIHPPBDIABL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[CPCHDIGKIKP(typeof(Vector3))]
internal class NOPAHCIIKKO : global::LFKIGBJBPJG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class KOHAPMEENKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public IDCFEKNBOPC ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public KOHAPMEENKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x63F7CC0", Offset = "0x63F70C0", VA = "0x1863F7CC0")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, FNOOJMKBHOH property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class PMCKHJDAJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
		public PMCKHJDAJLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x63F8AB0", Offset = "0x63F7EB0", VA = "0x1863F8AB0")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x63F8B10", Offset = "0x63F7F10", VA = "0x1863F8B10")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63F8B20", Offset = "0x63F7F20", VA = "0x1863F8B20")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63F8B80", Offset = "0x63F7F80", VA = "0x1863F8B80")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x63F8B90", Offset = "0x63F7F90", VA = "0x1863F8B90")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63F8BF0", Offset = "0x63F7FF0", VA = "0x1863F8BF0")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x63F8630", Offset = "0x63F7A30", VA = "0x1863F8630", Slot = "5")]
	protected override MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x63F86F0", Offset = "0x63F7AF0", VA = "0x1863F86F0")]
	public NOPAHCIIKKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct BPBAEMLPBMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int HOLAFBIFFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int EBCKCEOICIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int GPAIJDKOODN;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class MFOEHHGADHL
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x63F8140", Offset = "0x63F7540", VA = "0x1863F8140")]
	public static void HENPCIGDNOG(Type LOAFDOAOLMJ, Type IDEHHLECMGB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct JLLCMPHECCL
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x63F7760", Offset = "0x63F6B60", VA = "0x1863F7760")]
	public static NativeList<int> HDOONOBLMAE(KAANBEDLICJ ONBEDFCJOLM, LFJAPFGLCMI JGGECCOPCHM)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x63F7940", Offset = "0x63F6D40", VA = "0x1863F7940")]
	private static bool OOKHECLABOA(FNOOJMKBHOH LKAENGEIFGG, KAANBEDLICJ ONBEDFCJOLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class CFJBJGMADCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly LFJAPFGLCMI JGGECCOPCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly PMEGIOPIHFM MEGLNFKLOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IDCFEKNBOPC FIHFDFEAFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<BPBAEMLPBMC> ILIGIHFOHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<JDGJMEJMAJC> EKIEEGGFPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<JDGJMEJMAJC, List<BPBAEMLPBMC>> MNJIMEIAFNJ;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x63F3730", Offset = "0x63F2B30", VA = "0x1863F3730")]
	public CFJBJGMADCA(LFJAPFGLCMI JGGECCOPCHM, PMEGIOPIHFM MEGLNFKLOHK, IDCFEKNBOPC FIHFDFEAFPA, Action<BPBAEMLPBMC> ILIGIHFOHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x63F2E10", Offset = "0x63F2210", VA = "0x1863F2E10")]
	public void HEOGMCKFOCH(NativeList<BPBAEMLPBMC> IGAIMKPCPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x63F3610", Offset = "0x63F2A10", VA = "0x1863F3610")]
	private void KOEDICDKAED(JDGJMEJMAJC HMGHGFKHJGL, BPBAEMLPBMC DGLMNJAIEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x63F2D10", Offset = "0x63F2110", VA = "0x1863F2D10")]
	public void EAIKDONFGFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x63F3190", Offset = "0x63F2590", VA = "0x1863F3190")]
	private void HOHBEEJOCAO(JDGJMEJMAJC HMGHGFKHJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x63F2D70", Offset = "0x63F2170", VA = "0x1863F2D70")]
	private void GFMPDOMKNLJ(JDGJMEJMAJC HMGHGFKHJGL)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[MBALNPKLAGP(FOFKCKDBIPD.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class IHMMDDPIFCG : IEnumerable<FNOOJMKBHOH>, IEnumerable, IEnumerator<FNOOJMKBHOH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private FNOOJMKBHOH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public PropertiesByType <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private Type type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Type <>3__type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private NativeMultiHashMap<long, int>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private FNOOJMKBHOH System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x75EDA0", Offset = "0x75E1A0", VA = "0x18075EDA0")]
			[DebuggerHidden]
			public IHMMDDPIFCG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x63F7690", Offset = "0x63F6A90", VA = "0x1863F7690", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x63F7350", Offset = "0x63F6750", VA = "0x1863F7350", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x63F7710", Offset = "0x63F6B10", VA = "0x1863F7710")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x63F7650", Offset = "0x63F6A50", VA = "0x1863F7650", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x63F75A0", Offset = "0x63F69A0", VA = "0x1863F75A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FNOOJMKBHOH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x63F75A0", Offset = "0x63F69A0", VA = "0x1863F75A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly FADHLPPNOEF ICGADBEDOKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly PMEGIOPIHFM MEGLNFKLOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> MFPNLBILABB;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x63F8EB0", Offset = "0x63F82B0", VA = "0x1863F8EB0")]
		public PropertiesByType(PMEGIOPIHFM MEGLNFKLOHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x63F8DD0", Offset = "0x63F81D0", VA = "0x1863F8DD0")]
		[IteratorStateMachine(typeof(IHMMDDPIFCG))]
		public IEnumerable<FNOOJMKBHOH> LAALHPNABIN(Type DDJDPMGLPAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x63F8CD0", Offset = "0x63F80D0", VA = "0x1863F8CD0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x63F8D50", Offset = "0x63F8150", VA = "0x1863F8D50")]
		private long GOGJAFAMJPA(FNOOJMKBHOH LKAENGEIFGG)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x63F8D10", Offset = "0x63F8110", VA = "0x1863F8D10")]
		private long GOGJAFAMJPA(Type DDJDPMGLPAE)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct AKFKIHFELLO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray BLBCGMMCIBH;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x63F2CD0", Offset = "0x63F20D0", VA = "0x1863F2CD0")]
	public AKFKIHFELLO(int OCCKKIPCFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x63F2AA0", Offset = "0x63F1EA0", VA = "0x1863F2AA0")]
	public static AKFKIHFELLO FBKELCNOIFO(int DOMGBHGFPFL, NativeArray<int> ELCMIPNJFNP)
	{
		return default(AKFKIHFELLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x63F2CC0", Offset = "0x63F20C0", VA = "0x1863F2CC0")]
	public bool OGNHIEBNHGO(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x63F2CB0", Offset = "0x63F20B0", VA = "0x1863F2CB0")]
	public void HDECKBNAIGA(int BELCAJFDAHD, bool JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x63F2BF0", Offset = "0x63F1FF0", VA = "0x1863F2BF0")]
	public bool FLLOOBLNKCA(FNOOJMKBHOH[] ELCMIPNJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x63F29E0", Offset = "0x63F1DE0", VA = "0x1863F29E0")]
	public bool EAAEOIDJNNH(FNOOJMKBHOH[] ELCMIPNJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x63F29D0", Offset = "0x63F1DD0", VA = "0x1863F29D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class ENDIFNDHFFO
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly FADHLPPNOEF ICGADBEDOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly LFJAPFGLCMI JGGECCOPCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly PMEGIOPIHFM MEGLNFKLOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<GDLCMNAECNL> BONHKPJIEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType MFPNLBILABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> BBIFLHENLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> BGLCBLGDHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool LKMIDCEHKGL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<GDLCMNAECNL> JOEAIHAPEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x63F6200", Offset = "0x63F5600", VA = "0x1863F6200")]
	public ENDIFNDHFFO(LFJAPFGLCMI JGGECCOPCHM, PMEGIOPIHFM MEGLNFKLOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x63F5F40", Offset = "0x63F5340", VA = "0x1863F5F40")]
	public void MEDMFBCNDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x63F5190", Offset = "0x63F4590", VA = "0x1863F5190")]
	public void BPJOKKIEEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x63F55F0", Offset = "0x63F49F0", VA = "0x1863F55F0")]
	public NativeList<BPBAEMLPBMC> HMLDDJGMMLA(NativeArray<int> ELCMIPNJFNP)
	{
		return default(NativeList<BPBAEMLPBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x63F60E0", Offset = "0x63F54E0", VA = "0x1863F60E0")]
	private bool ONEMPNOLCJE(GDLCMNAECNL DBNCHFECAAC, AKFKIHFELLO BPOELCDIHGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x27C9780", Offset = "0x27C8B80", VA = "0x1827C9780")]
	private void CBEJKGHKNCB<TInterface, TAttribute>(Action<TInterface, TAttribute> IKCFBOJHGBB) where TInterface : GDLCMNAECNL where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x63F55C0", Offset = "0x63F49C0", VA = "0x1863F55C0")]
	private void EONBAEKHBLE(Type DDJDPMGLPAE, Type KOPMGCCEJEF, Type OEDFGJFPLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x27C9A20", Offset = "0x27C8E20", VA = "0x1827C9A20")]
	private TInterface HPBEAKIBINN<TInterface>(Type DDJDPMGLPAE)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x63F6010", Offset = "0x63F5410", VA = "0x1863F6010")]
	private void NCDGGPJLGGD(GDLCMNAECNL DBNCHFECAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x63F5EA0", Offset = "0x63F52A0", VA = "0x1863F5EA0")]
	private int KLNBACMPOFF(GDLCMNAECNL HBNLNEKDJID, int GPAIJDKOODN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x63F5BF0", Offset = "0x63F4FF0", VA = "0x1863F5BF0")]
	private void KKMLENCNBBB(EGJEAELIIPF DBNCHFECAAC, CPCHDIGKIKP CDFBDDJKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x63F5300", Offset = "0x63F4700", VA = "0x1863F5300")]
	private void CMBJJGJEEAP(JHHLFIDIJIH DBNCHFECAAC, PBBADOKAJLN CDFBDDJKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x63F5A50", Offset = "0x63F4E50", VA = "0x1863F5A50")]
	private void IPCPFDFEAAM(PPPPFPIPEID DBNCHFECAAC, AKGCNJABNNJ CDFBDDJKFNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct DKFNOIMGAPG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly PMEGIOPIHFM MEGLNFKLOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<GDLCMNAECNL> BONHKPJIEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<BPBAEMLPBMC> IIOFMGLCFEI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<BPBAEMLPBMC> LIOABMHDFEG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x725C90", Offset = "0x725090", VA = "0x180725C90")]
		get
		{
			return default(NativeList<BPBAEMLPBMC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x63F4F80", Offset = "0x63F4380", VA = "0x1863F4F80")]
	public DKFNOIMGAPG(PMEGIOPIHFM MEGLNFKLOHK, List<GDLCMNAECNL> BONHKPJIEHD, NativeArray<BPBAEMLPBMC> IGAIMKPCPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x63F4CB0", Offset = "0x63F40B0", VA = "0x1863F4CB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x63F48B0", Offset = "0x63F3CB0", VA = "0x1863F48B0")]
	private NativeList<BPBAEMLPBMC> BKEHLPGPLDE(NativeArray<BPBAEMLPBMC> MBFKEBAHPFG)
	{
		return default(NativeList<BPBAEMLPBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x63F4CF0", Offset = "0x63F40F0", VA = "0x1863F4CF0")]
	private bool FBKBEFKPKFB(GDLCMNAECNL DBNCHFECAAC, AKFKIHFELLO FODMLKHNBAH, int EBCKCEOICIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x63F4DC0", Offset = "0x63F41C0", VA = "0x1863F4DC0")]
	private void JCODCIPILMC(GDLCMNAECNL DBNCHFECAAC, AKFKIHFELLO BLBCGMMCIBH, int EBCKCEOICIK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct DLEJNLLGMAL : IComparer<BPBAEMLPBMC>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x63F5000", Offset = "0x63F4400", VA = "0x1863F5000", Slot = "4")]
	public int Compare(BPBAEMLPBMC FAMKPEGNHFC, BPBAEMLPBMC GPHMIGDKMEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x63F5010", Offset = "0x63F4410", VA = "0x1863F5010")]
	public static void POJEELMDDHA(NativeList<BPBAEMLPBMC> IGAIMKPCPBN)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : IIPLPEOFAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x702780", Offset = "0x701B80", VA = "0x180702780")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x63F91B0", Offset = "0x63F85B0", VA = "0x1863F91B0", Slot = "6")]
		public sealed override void ABDNPPIKLOH(FJJGEPPJBDA IGAMPECHIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x63F92B0", Offset = "0x63F86B0", VA = "0x1863F92B0", Slot = "4")]
		public sealed override void FKBDNONAKOB()
		{
		}
	}
}
namespace Cpp2IlInjected
{
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
}
