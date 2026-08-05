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
	[Cpp2IlInjected.Address(RVA = "0x63CEFA0", Offset = "0x63CE1A0", VA = "0x1863CEFA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public HFNHDHIHHAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BE54D0", Offset = "0x2BE46D0", VA = "0x182BE54D0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BE5570", Offset = "0x2BE4770", VA = "0x182BE5570")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C7030", Offset = "0x6C6230", VA = "0x1806C7030")]
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
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public EAIHODOFHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3D79100", Offset = "0x3D78300", VA = "0x183D79100")]
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
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public IMEALIPOMPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x27E2980", Offset = "0x27E1B80", VA = "0x1827E2980")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x27E2B70", Offset = "0x27E1D70", VA = "0x1827E2B70")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x361EB70", Offset = "0x361DD70", VA = "0x18361EB70")]
	protected HLODLMKGFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x361E250", Offset = "0x361D450", VA = "0x18361E250", Slot = "5")]
	public virtual void ABCONAOMHCF(KAANBEDLICJ ONBEDFCJOLM, FNOOJMKBHOH LKAENGEIFGG, IDCFEKNBOPC FIHFDFEAFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x361E890", Offset = "0x361DA90", VA = "0x18361E890", Slot = "6")]
	protected virtual CIMKEBPIMIG HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x361E840", Offset = "0x361DA40", VA = "0x18361E840", Slot = "7")]
	protected virtual PHFIMPFHIDI GKAKPOAGNGK(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x361E770", Offset = "0x361D970", VA = "0x18361E770")]
	private static Enum EJNLJDDKNND(KAANBEDLICJ ONBEDFCJOLM, FNOOJMKBHOH LKAENGEIFGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x361E990", Offset = "0x361DB90", VA = "0x18361E990")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public FNOOJMKBHOH[] PIBMFBIAIAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x63CE2E0", Offset = "0x63CD4E0", VA = "0x1863CE2E0", Slot = "6")]
	public void HBGEMGCKMHE(PMEGIOPIHFM MEGLNFKLOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void ABCONAOMHCF(KAANBEDLICJ ONBEDFCJOLM, IDCFEKNBOPC FIHFDFEAFPA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2875E40", Offset = "0x2875040", VA = "0x182875E40")]
	protected static T BDBHAMAMNEF<T>(KAANBEDLICJ ONBEDFCJOLM, FNOOJMKBHOH LKAENGEIFGG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2875E90", Offset = "0x2875090", VA = "0x182875E90")]
	protected static void FAOKIKBFOPE<T>(KAANBEDLICJ ONBEDFCJOLM, FNOOJMKBHOH LKAENGEIFGG, T JFBPNBNBHOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x14F6ED0", Offset = "0x14F60D0", VA = "0x1814F6ED0")]
		public LGOOCBFGKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x37DFE70", Offset = "0x37DF070", VA = "0x1837DFE70")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x37E0170", Offset = "0x37DF370", VA = "0x1837E0170")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C7030", Offset = "0x6C6230", VA = "0x1806C7030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x35EF820", Offset = "0x35EEA20", VA = "0x1835EF820")]
	protected LFKIGBJBPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x35EE810", Offset = "0x35EDA10", VA = "0x1835EE810", Slot = "4")]
	public void ABCONAOMHCF(KAANBEDLICJ ONBEDFCJOLM, FNOOJMKBHOH LKAENGEIFGG, IDCFEKNBOPC FIHFDFEAFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x35EECB0", Offset = "0x35EDEB0", VA = "0x1835EECB0")]
	private static T BDBHAMAMNEF(KAANBEDLICJ ONBEDFCJOLM, FNOOJMKBHOH LKAENGEIFGG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x35EF2F0", Offset = "0x35EE4F0", VA = "0x1835EF2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x63CC2B0", Offset = "0x63CB4B0", VA = "0x1863CC2B0", Slot = "5")]
		public void PEIMLKLDOFJ(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x63CBA40", Offset = "0x63CAC40", VA = "0x1863CBA40", Slot = "6")]
		public void JBIEBACCPLF(JHLNNPKIFCO KOKEGENGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x63CB890", Offset = "0x63CAA90", VA = "0x1863CB890", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63CBD40", Offset = "0x63CAF40", VA = "0x1863CBD40", Slot = "4")]
		public void LFAFPOAPPID(KAANBEDLICJ KLBPBOPEBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x63CB980", Offset = "0x63CAB80", VA = "0x1863CB980")]
		private void GAAPFLMMONL(KAANBEDLICJ KLBPBOPEBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x63CBA10", Offset = "0x63CAC10", VA = "0x1863CBA10")]
		private void IEOJIMLADCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63CB610", Offset = "0x63CA810", VA = "0x1863CB610")]
		private void ABCONAOMHCF(BPBAEMLPBMC DGLMNJAIEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x63CEEF0", Offset = "0x63CE0F0", VA = "0x1863CEEF0", Slot = "9")]
	public override bool PHAJFGFMCPG(Type DDJDPMGLPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x63CEE00", Offset = "0x63CE000", VA = "0x1863CEE00", Slot = "6")]
	protected override CIMKEBPIMIG HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x63CEFA0", Offset = "0x63CE1A0", VA = "0x1863CEFA0")]
	public IHJOGPHPBKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[PBBADOKAJLN(0)]
internal class KMMGDPLLPFM : NJFJCGDODCK
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x63CF8A0", Offset = "0x63CEAA0", VA = "0x1863CF8A0", Slot = "9")]
	public override bool PHAJFGFMCPG(Type DDJDPMGLPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x63CF7B0", Offset = "0x63CE9B0", VA = "0x1863CF7B0", Slot = "6")]
	protected override CIMKEBPIMIG HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x63CEFA0", Offset = "0x63CE1A0", VA = "0x1863CEFA0")]
	public KMMGDPLLPFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[CPCHDIGKIKP(typeof(IMELIOLJHMF), 1)]
internal class AFGKFLGHHPO : global::HLODLMKGFGK<IMELIOLJHMF>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x63CA530", Offset = "0x63C9730", VA = "0x1863CA530", Slot = "7")]
	protected override PHFIMPFHIDI GKAKPOAGNGK(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63CA620", Offset = "0x63C9820", VA = "0x1863CA620")]
	public AFGKFLGHHPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FLADAGGEJLD
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x63CDFE0", Offset = "0x63CD1E0", VA = "0x1863CDFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public GLOFOMDLPBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x63CE120", Offset = "0x63CD320", VA = "0x1863CE120")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x63CE250", Offset = "0x63CD450", VA = "0x1863CE250")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C7030", Offset = "0x6C6230", VA = "0x1806C7030")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override CNFMDAKFLAB[] BICLBDADHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x63CEC40", Offset = "0x63CDE40", VA = "0x1863CEC40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override CNFMDAKFLAB[] AEEIOHCOKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x63CED20", Offset = "0x63CDF20", VA = "0x1863CED20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x63CE880", Offset = "0x63CDA80", VA = "0x1863CE880", Slot = "10")]
	public override void ABCONAOMHCF(KAANBEDLICJ ONBEDFCJOLM, IDCFEKNBOPC FIHFDFEAFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public HNOHNMAAFOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[CPCHDIGKIKP(typeof(bool))]
internal class EFALBIECNBD : global::LFKIGBJBPJG<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x63CCCF0", Offset = "0x63CBEF0", VA = "0x1863CCCF0", Slot = "5")]
	protected override MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x63CCDE0", Offset = "0x63CBFE0", VA = "0x1863CCDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public PAEEEKKDMLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x63D04C0", Offset = "0x63CF6C0", VA = "0x1863D04C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public PFJINEOELAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x63D0650", Offset = "0x63CF850", VA = "0x1863D0650")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x63D06C0", Offset = "0x63CF8C0", VA = "0x1863D06C0")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x63CC390", Offset = "0x63CB590", VA = "0x1863CC390", Slot = "5")]
	protected override MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x63CC450", Offset = "0x63CB650", VA = "0x1863CC450")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public HFBIDMKIMDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x63CE6F0", Offset = "0x63CD8F0", VA = "0x1863CE6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public COPPIPJDEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x63CB4E0", Offset = "0x63CA6E0", VA = "0x1863CB4E0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x63CB570", Offset = "0x63CA770", VA = "0x1863CB570")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x63D03C0", Offset = "0x63CF5C0", VA = "0x1863D03C0", Slot = "5")]
	protected override MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x63D0480", Offset = "0x63CF680", VA = "0x1863D0480")]
	public OBICAEGLGIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[CPCHDIGKIKP(typeof(float))]
internal class LDPGIHGDPEL : global::LFKIGBJBPJG<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x63CFCA0", Offset = "0x63CEEA0", VA = "0x1863CFCA0", Slot = "5")]
	protected override MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x63CFD90", Offset = "0x63CEF90", VA = "0x1863CFD90")]
	public LDPGIHGDPEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[CPCHDIGKIKP(typeof(int))]
internal class NBPINCCPPJD : global::LFKIGBJBPJG<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x63D0190", Offset = "0x63CF390", VA = "0x1863D0190", Slot = "5")]
	protected override MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x63D0280", Offset = "0x63CF480", VA = "0x1863D0280")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public MJIOJLMOIMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x63CFFB0", Offset = "0x63CF1B0", VA = "0x1863CFFB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public DFNMNFDJOEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x63CC490", Offset = "0x63CB690", VA = "0x1863CC490")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x63CC4E0", Offset = "0x63CB6E0", VA = "0x1863CC4E0")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x63CFEB0", Offset = "0x63CF0B0", VA = "0x1863CFEB0", Slot = "5")]
	protected override MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x63CFF70", Offset = "0x63CF170", VA = "0x1863CFF70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public KOHAPMEENKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x63CF950", Offset = "0x63CEB50", VA = "0x1863CF950")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public PMCKHJDAJLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x63D0740", Offset = "0x63CF940", VA = "0x1863D0740")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x63D07A0", Offset = "0x63CF9A0", VA = "0x1863D07A0")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63D07B0", Offset = "0x63CF9B0", VA = "0x1863D07B0")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63D0810", Offset = "0x63CFA10", VA = "0x1863D0810")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x63D0820", Offset = "0x63CFA20", VA = "0x1863D0820")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63D0880", Offset = "0x63CFA80", VA = "0x1863D0880")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x63D02C0", Offset = "0x63CF4C0", VA = "0x1863D02C0", Slot = "5")]
	protected override MEONAMHMNCP HCEGIHFDHKB(IDCFEKNBOPC FIHFDFEAFPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x63D0380", Offset = "0x63CF580", VA = "0x1863D0380")]
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
	[Cpp2IlInjected.Address(RVA = "0x63CFDD0", Offset = "0x63CEFD0", VA = "0x1863CFDD0")]
	public static void HENPCIGDNOG(Type LOAFDOAOLMJ, Type IDEHHLECMGB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct JLLCMPHECCL
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x63CF3F0", Offset = "0x63CE5F0", VA = "0x1863CF3F0")]
	public static NativeList<int> HDOONOBLMAE(KAANBEDLICJ ONBEDFCJOLM, LFJAPFGLCMI JGGECCOPCHM)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x63CF5D0", Offset = "0x63CE7D0", VA = "0x1863CF5D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x63CB3C0", Offset = "0x63CA5C0", VA = "0x1863CB3C0")]
	public CFJBJGMADCA(LFJAPFGLCMI JGGECCOPCHM, PMEGIOPIHFM MEGLNFKLOHK, IDCFEKNBOPC FIHFDFEAFPA, Action<BPBAEMLPBMC> ILIGIHFOHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x63CAAA0", Offset = "0x63C9CA0", VA = "0x1863CAAA0")]
	public void HEOGMCKFOCH(NativeList<BPBAEMLPBMC> IGAIMKPCPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x63CB2A0", Offset = "0x63CA4A0", VA = "0x1863CB2A0")]
	private void KOEDICDKAED(JDGJMEJMAJC HMGHGFKHJGL, BPBAEMLPBMC DGLMNJAIEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x63CA9A0", Offset = "0x63C9BA0", VA = "0x1863CA9A0")]
	public void EAIKDONFGFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x63CAE20", Offset = "0x63CA020", VA = "0x1863CAE20")]
	private void HOHBEEJOCAO(JDGJMEJMAJC HMGHGFKHJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x63CAA00", Offset = "0x63C9C00", VA = "0x1863CAA00")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8A6A90", Offset = "0x8A5C90", VA = "0x1808A6A90")]
			[DebuggerHidden]
			public IHMMDDPIFCG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x63CF320", Offset = "0x63CE520", VA = "0x1863CF320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x63CEFE0", Offset = "0x63CE1E0", VA = "0x1863CEFE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x63CF3A0", Offset = "0x63CE5A0", VA = "0x1863CF3A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x63CF2E0", Offset = "0x63CE4E0", VA = "0x1863CF2E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x63CF230", Offset = "0x63CE430", VA = "0x1863CF230", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FNOOJMKBHOH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x63CF230", Offset = "0x63CE430", VA = "0x1863CF230", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63D0B40", Offset = "0x63CFD40", VA = "0x1863D0B40")]
		public PropertiesByType(PMEGIOPIHFM MEGLNFKLOHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x63D0A60", Offset = "0x63CFC60", VA = "0x1863D0A60")]
		[IteratorStateMachine(typeof(IHMMDDPIFCG))]
		public IEnumerable<FNOOJMKBHOH> LAALHPNABIN(Type DDJDPMGLPAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x63D0960", Offset = "0x63CFB60", VA = "0x1863D0960", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x63D09E0", Offset = "0x63CFBE0", VA = "0x1863D09E0")]
		private long GOGJAFAMJPA(FNOOJMKBHOH LKAENGEIFGG)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x63D09A0", Offset = "0x63CFBA0", VA = "0x1863D09A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x63CA960", Offset = "0x63C9B60", VA = "0x1863CA960")]
	public AKFKIHFELLO(int OCCKKIPCFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x63CA730", Offset = "0x63C9930", VA = "0x1863CA730")]
	public static AKFKIHFELLO FBKELCNOIFO(int DOMGBHGFPFL, NativeArray<int> ELCMIPNJFNP)
	{
		return default(AKFKIHFELLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x63CA950", Offset = "0x63C9B50", VA = "0x1863CA950")]
	public bool OGNHIEBNHGO(int BELCAJFDAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x63CA940", Offset = "0x63C9B40", VA = "0x1863CA940")]
	public void HDECKBNAIGA(int BELCAJFDAHD, bool JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x63CA880", Offset = "0x63C9A80", VA = "0x1863CA880")]
	public bool FLLOOBLNKCA(FNOOJMKBHOH[] ELCMIPNJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x63CA670", Offset = "0x63C9870", VA = "0x1863CA670")]
	public bool EAAEOIDJNNH(FNOOJMKBHOH[] ELCMIPNJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x63CA660", Offset = "0x63C9860", VA = "0x1863CA660", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x63CDE90", Offset = "0x63CD090", VA = "0x1863CDE90")]
	public ENDIFNDHFFO(LFJAPFGLCMI JGGECCOPCHM, PMEGIOPIHFM MEGLNFKLOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x63CDBD0", Offset = "0x63CCDD0", VA = "0x1863CDBD0")]
	public void MEDMFBCNDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x63CCE20", Offset = "0x63CC020", VA = "0x1863CCE20")]
	public void BPJOKKIEEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x63CD280", Offset = "0x63CC480", VA = "0x1863CD280")]
	public NativeList<BPBAEMLPBMC> HMLDDJGMMLA(NativeArray<int> ELCMIPNJFNP)
	{
		return default(NativeList<BPBAEMLPBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x63CDD70", Offset = "0x63CCF70", VA = "0x1863CDD70")]
	private bool ONEMPNOLCJE(GDLCMNAECNL DBNCHFECAAC, AKFKIHFELLO BPOELCDIHGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CDC0", Offset = "0x1F9BFC0", VA = "0x181F9CDC0")]
	private void CBEJKGHKNCB<TInterface, TAttribute>(Action<TInterface, TAttribute> IKCFBOJHGBB) where TInterface : GDLCMNAECNL where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x63CD250", Offset = "0x63CC450", VA = "0x1863CD250")]
	private void EONBAEKHBLE(Type DDJDPMGLPAE, Type KOPMGCCEJEF, Type OEDFGJFPLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D060", Offset = "0x1F9C260", VA = "0x181F9D060")]
	private TInterface HPBEAKIBINN<TInterface>(Type DDJDPMGLPAE)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x63CDCA0", Offset = "0x63CCEA0", VA = "0x1863CDCA0")]
	private void NCDGGPJLGGD(GDLCMNAECNL DBNCHFECAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x63CDB30", Offset = "0x63CCD30", VA = "0x1863CDB30")]
	private int KLNBACMPOFF(GDLCMNAECNL HBNLNEKDJID, int GPAIJDKOODN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x63CD880", Offset = "0x63CCA80", VA = "0x1863CD880")]
	private void KKMLENCNBBB(EGJEAELIIPF DBNCHFECAAC, CPCHDIGKIKP CDFBDDJKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x63CCF90", Offset = "0x63CC190", VA = "0x1863CCF90")]
	private void CMBJJGJEEAP(JHHLFIDIJIH DBNCHFECAAC, PBBADOKAJLN CDFBDDJKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x63CD6E0", Offset = "0x63CC8E0", VA = "0x1863CD6E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCCCFF0", Offset = "0xCCC1F0", VA = "0x180CCCFF0")]
		get
		{
			return default(NativeList<BPBAEMLPBMC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x63CCC10", Offset = "0x63CBE10", VA = "0x1863CCC10")]
	public DKFNOIMGAPG(PMEGIOPIHFM MEGLNFKLOHK, List<GDLCMNAECNL> BONHKPJIEHD, NativeArray<BPBAEMLPBMC> IGAIMKPCPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x63CC940", Offset = "0x63CBB40", VA = "0x1863CC940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x63CC540", Offset = "0x63CB740", VA = "0x1863CC540")]
	private NativeList<BPBAEMLPBMC> BKEHLPGPLDE(NativeArray<BPBAEMLPBMC> MBFKEBAHPFG)
	{
		return default(NativeList<BPBAEMLPBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x63CC980", Offset = "0x63CBB80", VA = "0x1863CC980")]
	private bool FBKBEFKPKFB(GDLCMNAECNL DBNCHFECAAC, AKFKIHFELLO FODMLKHNBAH, int EBCKCEOICIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x63CCA50", Offset = "0x63CBC50", VA = "0x1863CCA50")]
	private void JCODCIPILMC(GDLCMNAECNL DBNCHFECAAC, AKFKIHFELLO BLBCGMMCIBH, int EBCKCEOICIK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct DLEJNLLGMAL : IComparer<BPBAEMLPBMC>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x63CCC90", Offset = "0x63CBE90", VA = "0x1863CCC90", Slot = "4")]
	public int Compare(BPBAEMLPBMC FAMKPEGNHFC, BPBAEMLPBMC GPHMIGDKMEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x63CCCA0", Offset = "0x63CBEA0", VA = "0x1863CCCA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C8B40", Offset = "0x6C7D40", VA = "0x1806C8B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x63D0E40", Offset = "0x63D0040", VA = "0x1863D0E40", Slot = "6")]
		public sealed override void ABDNPPIKLOH(FJJGEPPJBDA IGAMPECHIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x63D0F40", Offset = "0x63D0140", VA = "0x1863D0F40", Slot = "4")]
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
