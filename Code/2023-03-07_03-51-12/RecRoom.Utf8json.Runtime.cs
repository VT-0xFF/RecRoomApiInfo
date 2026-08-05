using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class KBFOKINGPMB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xBD8CF0", Offset = "0xBD80F0", VA = "0x180BD8CF0")]
	public static bool EHONLGHCMNA(this TypeInfo BKGBGEHNCAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class JAINAHPBENG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type PEAPHOICMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x773890", Offset = "0x772C90", VA = "0x180773890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] MFHOFBPGEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x778380", Offset = "0x777780", VA = "0x180778380")]
	public JAINAHPBENG(Type CHHHBLOMODB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor)]
public class DJMPOCNOHJE : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void JGCGHJLCHBB<T>(ref OCIPHIDCELE CDLKNDDFOPH, T FPLJCBGEJAP, BOIAJJMDENO NBILJDMEMDM);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T PEEKHHBOLAN<T>(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO NBILJDMEMDM);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GKNPAAIBGAM
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PDLGFBEOKBE<T> : GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, T FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PBGPIEICANJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, T FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum EBDLNHAEHAP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::PDLGFBEOKBE<T> NOBELMGICPC<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CDGBPLDAIJP
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x32AFD60", Offset = "0x32AF160", VA = "0x1832AFD60")]
	public static global::PDLGFBEOKBE<T> CODJJMALKBA<T>(this BOIAJJMDENO NBILJDMEMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x14B8140", Offset = "0x14B7540", VA = "0x1814B8140")]
	public static object BBIDALMMKBG(this BOIAJJMDENO NBILJDMEMDM, Type BKGBGEHNCAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LLDJAMCAMMA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xBDEF00", Offset = "0xBDE300", VA = "0x180BDEF00")]
	public LLDJAMCAMMA(string CIBBLLOHCGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct PLOHLCGPGAB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal static class AILCLPLDOMO
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] DGPBECDNOKK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] CMBGGBBMJHE;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x180F200", Offset = "0x180E600", VA = "0x18180F200")]
		public static byte[] FKIGDBLEEFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x180F290", Offset = "0x180E690", VA = "0x18180F290")]
		public static char[] LLHHLNMFCAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> LFBDCADCDFB;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] MIPINCNBFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] GJDBLJLIDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int BPNKPMGDGFM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool CEADPCPMMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xBEAAD0", Offset = "0xBE9ED0", VA = "0x180BEAAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xBEC680", Offset = "0xBEBA80", VA = "0x180BEC680")]
	public PLOHLCGPGAB(byte[] GJDBLJLIDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xBEC490", Offset = "0xBEB890", VA = "0x180BEC490")]
	public PLOHLCGPGAB(byte[] GJDBLJLIDDI, int BPNKPMGDGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xBE9C20", Offset = "0xBE9020", VA = "0x180BE9C20")]
	private JDAIPGOMDCE BPILHJFMFCB(string NBFEHKAOJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xBEA5C0", Offset = "0xBE99C0", VA = "0x180BEA5C0")]
	private JDAIPGOMDCE EMABHAIMODD(string CIBBLLOHCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xBE76B0", Offset = "0xBE6AB0", VA = "0x180BE76B0")]
	public void NCPIDHFHNKP(int BPNKPMGDGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900")]
	public byte[] LLGAMFGCEBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C6E20", Offset = "0x6C6220", VA = "0x1806C6E20")]
	public int LAPBEANFHKA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xBEB060", Offset = "0xBEA460", VA = "0x180BEB060")]
	public IDOJLOLJAPH KIOKEGLBIGI()
	{
		return default(IDOJLOLJAPH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xBEA700", Offset = "0xBE9B00", VA = "0x180BEA700")]
	public void FHBDBOMJNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xBEA8A0", Offset = "0xBE9CA0", VA = "0x180BEA8A0")]
	public bool GGPPEBJMJMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xBEBB70", Offset = "0xBEAF70", VA = "0x180BEBB70")]
	public bool OOJKMJNDCDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xBEB560", Offset = "0xBEA960", VA = "0x180BEB560")]
	public void LMPAACJJEKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xBEB1E0", Offset = "0xBEA5E0", VA = "0x180BEB1E0")]
	public bool KMHPEHMOHAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xBE98C0", Offset = "0xBE8CC0", VA = "0x180BE98C0")]
	public bool ADCCOGDPPLD(ref int NDNADCNCIGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xBE9B60", Offset = "0xBE8F60", VA = "0x180BE9B60")]
	public bool BOKEABNOKKG(ref int NDNADCNCIGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xBEB700", Offset = "0xBEAB00", VA = "0x180BEB700")]
	public bool NGNDHIEGNIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xBEAAF0", Offset = "0xBE9EF0", VA = "0x180BEAAF0")]
	public void HNCNGBAEAIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xBEA210", Offset = "0xBE9610", VA = "0x180BEA210")]
	public bool DAMIJEEJFKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xBE9AE0", Offset = "0xBE8EE0", VA = "0x180BE9AE0")]
	public bool BNOCANEFPKJ(ref int NDNADCNCIGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xBEA500", Offset = "0xBE9900", VA = "0x180BEA500")]
	public bool EFHALGLGDGK(ref int NDNADCNCIGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xBEA1B0", Offset = "0xBE95B0", VA = "0x180BEA1B0")]
	public bool CPMFHNKIJGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xBEA270", Offset = "0xBE9670", VA = "0x180BEA270")]
	public void DCCMNKHIKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xBEA310", Offset = "0xBE9710", VA = "0x180BEA310")]
	public bool EEMDEIGLMIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xBEB9A0", Offset = "0xBEADA0", VA = "0x180BEB9A0")]
	public void NLKCGPOLOIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xBEBBD0", Offset = "0xBEAFD0", VA = "0x180BEBBD0")]
	private void PNBFEKCDJHK(out byte[] FFBOIMBDOMP, out int HLNAAJAEKNB, out int PGFMIEGKBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xBEB5F0", Offset = "0xBEA9F0", VA = "0x180BEB5F0")]
	private static int MPMFIILMGKE(char KEPOHMNFLGL, char CFEKEMJOJGA, char JJJCLNDDKAD, char LNJIJCHAAFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xBEAD50", Offset = "0xBEA150", VA = "0x180BEAD50")]
	private static int IDDEAANNPEG(char IMDGNLLHHDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xBEB420", Offset = "0xBEA820", VA = "0x180BEB420")]
	public ArraySegment<byte> LDFALBGHJOP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xBEAF60", Offset = "0xBEA360", VA = "0x180BEAF60")]
	public string KFHDOJIIAKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xBE9890", Offset = "0xBE8C90", VA = "0x180BE9890")]
	public string AAJKHBALECL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xBEAB80", Offset = "0xBE9F80", VA = "0x180BEAB80")]
	public ArraySegment<byte> HNOJPAFINDB()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xBEB520", Offset = "0xBEA920", VA = "0x180BEB520")]
	public ArraySegment<byte> LKLGPBDCNPM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xBEB760", Offset = "0xBEAB60", VA = "0x180BEB760")]
	public bool NJAELPCDHHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xBEAEA0", Offset = "0xBEA2A0", VA = "0x180BEAEA0")]
	private static bool KDOHOLNLBNG(byte JJJCLNDDKAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xBEB240", Offset = "0xBEA640", VA = "0x180BEB240")]
	private void KODEMAKGBBO(IDOJLOLJAPH JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xBEA300", Offset = "0xBE9700", VA = "0x180BEA300")]
	public void DMBGJFFCKOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xBE9940", Offset = "0xBE8D40", VA = "0x180BE9940")]
	private void BCPDELKEDIO(int KHCKGNKPFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xBEBB20", Offset = "0xBEAF20", VA = "0x180BEBB20")]
	public sbyte OEKMIAHBOBA()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xBEA6A0", Offset = "0xBE9AA0", VA = "0x180BEA6A0")]
	public short EMEAADBLHDP()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xBEA840", Offset = "0xBE9C40", VA = "0x180BEA840")]
	public int FOIIMDFDPBH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xBEAE20", Offset = "0xBEA220", VA = "0x180BEAE20")]
	public long JKIAPEFPDPO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xBEB6A0", Offset = "0xBEAAA0", VA = "0x180BEB6A0")]
	public byte NCOOKIOLMHG()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xBEB000", Offset = "0xBEA400", VA = "0x180BEB000")]
	public ushort KGOOIBOEDKN()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xBEAA70", Offset = "0xBE9E70", VA = "0x180BEAA70")]
	public uint HAKJOBFICMD()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xBEA130", Offset = "0xBE9530", VA = "0x180BEA130")]
	public ulong CIENIAALIAP()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xBE9A10", Offset = "0xBE8E10", VA = "0x180BE9A10")]
	public float BHGKINPHMIA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xBEA9A0", Offset = "0xBE9DA0", VA = "0x180BEA9A0")]
	public double GNIECHKMHKJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xBEBA30", Offset = "0xBEAE30", VA = "0x180BEBA30")]
	public ArraySegment<byte> NMLCBAADIPN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0xBEA370", Offset = "0xBE9770", VA = "0x180BEA370")]
	private static int EFGCJKFDJAC(byte[] GJDBLJLIDDI, int BPNKPMGDGFM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JDAIPGOMDCE : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference DOICCKGEEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int ENENGFDNBAM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int CJNDDGPADCL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x81B510", Offset = "0x81A910", VA = "0x18081B510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string MKBLPHGOBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x795C80", Offset = "0x795080", VA = "0x180795C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xBD49C0", Offset = "0xBD3DC0", VA = "0x180BD49C0")]
	public JDAIPGOMDCE(string CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xBD48E0", Offset = "0xBD3CE0", VA = "0x180BD48E0")]
	public JDAIPGOMDCE(string CIBBLLOHCGM, byte[] EIGCOBIEDMN, int BPNKPMGDGFM, int ENENGFDNBAM, string JIBIFFHACHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KBMNKKAHMJN
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class EJKACMPGCKP
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private delegate void OCDILNBAKLO(ref OCIPHIDCELE CDLKNDDFOPH, object FPLJCBGEJAP, BOIAJJMDENO NBILJDMEMDM);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private delegate object BGOGJFOHFBL(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO NBILJDMEMDM);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class BGOBMMFBOAM
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			[CompilerGenerated]
			private sealed class ACNFKOBOBPK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
				public ACNFKOBOBPK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xAB3CF0", Offset = "0xAB30F0", VA = "0x180AB3CF0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x180F000", Offset = "0x180E400", VA = "0x18180F000")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, BOIAJJMDENO, byte[]> MHMIOFPBILA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, BOIAJJMDENO> DNBPMAODAKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly OCDILNBAKLO KMJEPJIKHNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, BOIAJJMDENO, ArraySegment<byte>> DDKBEIHNADC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, BOIAJJMDENO, string> HOMKLOKGMGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, BOIAJJMDENO, object> OBNLLCBADNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, BOIAJJMDENO, object> KMKEDPNCJHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, BOIAJJMDENO, object> BODLBCOKKAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly BGOGJFOHFBL GDGIGDCFCMK;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x180FBC0", Offset = "0x180EFC0", VA = "0x18180FBC0")]
			public BGOBMMFBOAM(Type BKGBGEHNCAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x40768C0", Offset = "0x4075CC0", VA = "0x1840768C0")]
			private static T MPCHKPNEGAC<T>(DynamicMethod GAKNPFHAOJI)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x180F970", Offset = "0x180ED70", VA = "0x18180F970")]
			private static MethodInfo OFMEGLIAIJM(Type BKGBGEHNCAE, string LBEPPIIBMPA, Type[] GOFMOOHNBKB)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, BGOBMMFBOAM> OJJNECCMLCJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::HOAJMPMNBDM<BGOBMMFBOAM> KAFEDNGDBOJ;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x18146A0", Offset = "0x1813AA0", VA = "0x1818146A0")]
		static EJKACMPGCKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1814360", Offset = "0x1813760", VA = "0x181814360")]
		private static BGOBMMFBOAM DEHBMNIIEEG(Type BKGBGEHNCAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x18143F0", Offset = "0x18137F0", VA = "0x1818143F0")]
		public static void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, object FPLJCBGEJAP, BOIAJJMDENO NBILJDMEMDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1814580", Offset = "0x1813980", VA = "0x181814580")]
		public static void DGECGJPLFOM(Type BKGBGEHNCAE, ref OCIPHIDCELE CDLKNDDFOPH, object FPLJCBGEJAP, BOIAJJMDENO NBILJDMEMDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class LOJAAHBKGMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] DGPBECDNOKK;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x181B400", Offset = "0x181A800", VA = "0x18181B400")]
		public static byte[] FKIGDBLEEFG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static BOIAJJMDENO OPONLMLPEBP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] BCEBCJCKNFO;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] ANJAJHHKJHM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static BOIAJJMDENO IJGBGHIEBNL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xBD8D90", Offset = "0xBD8190", VA = "0x180BD8D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool BFCALEBFFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xBD9200", Offset = "0xBD8600", VA = "0x180BD9200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xBD8D20", Offset = "0xBD8120", VA = "0x180BD8D20")]
	public static void DDIPDPMBLEK(BOIAJJMDENO NBILJDMEMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2964F80", Offset = "0x2964380", VA = "0x182964F80")]
	public static byte[] DGECGJPLFOM<T>(T JGHFLANLLNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2964C70", Offset = "0x2964070", VA = "0x182964C70")]
	public static byte[] DGECGJPLFOM<T>(T FPLJCBGEJAP, BOIAJJMDENO NBILJDMEMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2964BE0", Offset = "0x2963FE0", VA = "0x182964BE0")]
	public static void DGECGJPLFOM<T>(ref OCIPHIDCELE CDLKNDDFOPH, T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2965000", Offset = "0x2964400", VA = "0x182965000")]
	public static void DGECGJPLFOM<T>(ref OCIPHIDCELE CDLKNDDFOPH, T FPLJCBGEJAP, BOIAJJMDENO NBILJDMEMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2964EF0", Offset = "0x29642F0", VA = "0x182964EF0")]
	public static void DGECGJPLFOM<T>(Stream LBMMCNGMDLI, T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2964DD0", Offset = "0x29641D0", VA = "0x182964DD0")]
	public static void DGECGJPLFOM<T>(Stream LBMMCNGMDLI, T FPLJCBGEJAP, BOIAJJMDENO NBILJDMEMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2965260", Offset = "0x2964660", VA = "0x182965260")]
	public static ArraySegment<byte> FCMJBLBJNMJ<T>(T JGHFLANLLNE)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x29650E0", Offset = "0x29644E0", VA = "0x1829650E0")]
	public static ArraySegment<byte> FCMJBLBJNMJ<T>(T FPLJCBGEJAP, BOIAJJMDENO NBILJDMEMDM)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2965460", Offset = "0x2964860", VA = "0x182965460")]
	public static string NCEENJGHMFB<T>(T FPLJCBGEJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2965300", Offset = "0x2964700", VA = "0x182965300")]
	public static string NCEENJGHMFB<T>(T FPLJCBGEJAP, BOIAJJMDENO NBILJDMEMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x29641C0", Offset = "0x29635C0", VA = "0x1829641C0")]
	public static T AHLFMBEKFNG<T>(string GGPDCIOBBOB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2964260", Offset = "0x2963660", VA = "0x182964260")]
	public static T AHLFMBEKFNG<T>(string GGPDCIOBBOB, BOIAJJMDENO NBILJDMEMDM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x29645B0", Offset = "0x29639B0", VA = "0x1829645B0")]
	public static T AHLFMBEKFNG<T>(byte[] GJDBLJLIDDI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2964120", Offset = "0x2963520", VA = "0x182964120")]
	public static T AHLFMBEKFNG<T>(byte[] GJDBLJLIDDI, BOIAJJMDENO NBILJDMEMDM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x29649A0", Offset = "0x2963DA0", VA = "0x1829649A0")]
	public static T AHLFMBEKFNG<T>(byte[] GJDBLJLIDDI, int BPNKPMGDGFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2964350", Offset = "0x2963750", VA = "0x182964350")]
	public static T AHLFMBEKFNG<T>(byte[] GJDBLJLIDDI, int BPNKPMGDGFM, BOIAJJMDENO NBILJDMEMDM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29648A0", Offset = "0x2963CA0", VA = "0x1829648A0")]
	public static T AHLFMBEKFNG<T>(ref PLOHLCGPGAB LGIEPMOBDDP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2964B10", Offset = "0x2963F10", VA = "0x182964B10")]
	public static T AHLFMBEKFNG<T>(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO NBILJDMEMDM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2964920", Offset = "0x2963D20", VA = "0x182964920")]
	public static T AHLFMBEKFNG<T>(Stream LBMMCNGMDLI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2964770", Offset = "0x2963B70", VA = "0x182964770")]
	public static T AHLFMBEKFNG<T>(Stream LBMMCNGMDLI, BOIAJJMDENO NBILJDMEMDM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xBD8FB0", Offset = "0xBD83B0", VA = "0x180BD8FB0")]
	public static string ELOKIOPAAHG(byte[] GGPDCIOBBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xBD8EB0", Offset = "0xBD82B0", VA = "0x180BD8EB0")]
	public static string ELOKIOPAAHG(byte[] GGPDCIOBBOB, int BPNKPMGDGFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xBD90E0", Offset = "0xBD84E0", VA = "0x180BD90E0")]
	public static string ELOKIOPAAHG(string GGPDCIOBBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xBD9D20", Offset = "0xBD9120", VA = "0x180BD9D20")]
	public static byte[] LLNLFJBKOBG(byte[] GGPDCIOBBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xBD9E70", Offset = "0xBD9270", VA = "0x180BD9E70")]
	public static byte[] LLNLFJBKOBG(byte[] GGPDCIOBBOB, int BPNKPMGDGFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xBD9BE0", Offset = "0xBD8FE0", VA = "0x180BD9BE0")]
	public static byte[] LLNLFJBKOBG(string GGPDCIOBBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xBD9300", Offset = "0xBD8700", VA = "0x180BD9300")]
	private static void LKEKDEICGGF(ref PLOHLCGPGAB LGIEPMOBDDP, ref OCIPHIDCELE CDLKNDDFOPH, int CLPHJECJKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xBD9260", Offset = "0xBD8660", VA = "0x180BD9260")]
	private static int IMDMAHKGPCI(Stream LEPPMEPJHOI, ref byte[] DGPBECDNOKK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum IDOJLOLJAPH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	BeginObject,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	EndObject,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	BeginArray,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	EndArray,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Number,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	String,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	True,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	False,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Null,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ValueSeparator,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NameSeparator
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OCIPHIDCELE
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] HAFEAJFKDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] DGPBECDNOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int BPNKPMGDGFM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KBBAEKGDIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6C6E20", Offset = "0x6C6220", VA = "0x1806C6E20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xBE76B0", Offset = "0xBE6AB0", VA = "0x180BE76B0")]
	public void NCPIDHFHNKP(int BPNKPMGDGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xBE6AF0", Offset = "0xBE5EF0", VA = "0x180BE6AF0")]
	public static byte[] GBEHAKIAMHH(string MLBMAJEOEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xBE70D0", Offset = "0xBE64D0", VA = "0x180BE70D0")]
	public static byte[] LOJLDMAKGHO(string MLBMAJEOEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xBE6700", Offset = "0xBE5B00", VA = "0x180BE6700")]
	public static byte[] DHJMNDCECON(string MLBMAJEOEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xBE68F0", Offset = "0xBE5CF0", VA = "0x180BE68F0")]
	public static byte[] EPDPJIFMKPD(string MLBMAJEOEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xBE7B80", Offset = "0xBE6F80", VA = "0x180BE7B80")]
	public OCIPHIDCELE(byte[] HCGEMHMGCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xBE6A40", Offset = "0xBE5E40", VA = "0x180BE6A40")]
	public ArraySegment<byte> FKIGDBLEEFG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xBE6870", Offset = "0xBE5C70", VA = "0x180BE6870")]
	public byte[] EMBBDCDLAAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xBE7AC0", Offset = "0xBE6EC0", VA = "0x180BE7AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xBE76A0", Offset = "0xBE6AA0", VA = "0x180BE76A0")]
	public void NAGBAKDBAJB(int LCFPHMBMMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xBE7640", Offset = "0xBE6A40", VA = "0x180BE7640")]
	public void MJOINOEKKMP(byte NFENOPOGACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xBE75E0", Offset = "0xBE69E0", VA = "0x180BE75E0")]
	public void MJOINOEKKMP(byte[] NFENOPOGACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xBE6EE0", Offset = "0xBE62E0", VA = "0x180BE6EE0")]
	public void HANCCKBJPKK(byte NFENOPOGACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xBE66B0", Offset = "0xBE5AB0", VA = "0x180BE66B0")]
	public void BFKBJADOCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xBE6D60", Offset = "0xBE6160", VA = "0x180BE6D60")]
	public void GHMENAFLFNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xBE6F20", Offset = "0xBE6320", VA = "0x180BE6F20")]
	public void HOPOPKLKCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xBE7A10", Offset = "0xBE6E10", VA = "0x180BE7A10")]
	public void OKINBAPNIED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xBE6FC0", Offset = "0xBE63C0", VA = "0x180BE6FC0")]
	public void JNNJIFFLBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xBE6660", Offset = "0xBE5A60", VA = "0x180BE6660")]
	public void AEDMIFKHABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xBE7A60", Offset = "0xBE6E60", VA = "0x180BE7A60")]
	public void PAHOPLGBPJF(string MLBMAJEOEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xBE6F70", Offset = "0xBE6370", VA = "0x180BE6F70")]
	public void IKKDFEJJBHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xBE6DB0", Offset = "0xBE61B0", VA = "0x180BE6DB0")]
	public void GHPOJIEOFAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xBE7820", Offset = "0xBE6C20", VA = "0x180BE7820")]
	public void OJBELFMJJMD(bool FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xBE76C0", Offset = "0xBE6AC0", VA = "0x180BE76C0")]
	public void NOIBOPEICFM(float FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xBE6BD0", Offset = "0xBE5FD0", VA = "0x180BE6BD0")]
	public void GCAJPIKLPFI(double FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xBE6E80", Offset = "0xBE6280", VA = "0x180BE6E80")]
	public void GKNBHJKKLKH(byte FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xBE70A0", Offset = "0xBE64A0", VA = "0x180BE70A0")]
	public void LGEKAOPBKNK(ushort FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xBE7040", Offset = "0xBE6440", VA = "0x180BE7040")]
	public void JPKLCLOBBMG(uint FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0xBE6EB0", Offset = "0xBE62B0", VA = "0x180BE6EB0")]
	public void GOLEKAHFLPB(ulong FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xBE7010", Offset = "0xBE6410", VA = "0x180BE7010")]
	public void JPINLBELFNI(sbyte FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xBE6D30", Offset = "0xBE6130", VA = "0x180BE6D30")]
	public void GHIIHLBHDEG(short FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xBE6840", Offset = "0xBE5C40", VA = "0x180BE6840")]
	public void EHLFOFPLMJP(int FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xBE7070", Offset = "0xBE6470", VA = "0x180BE7070")]
	public void KEIHPMBDCIC(long FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0xBE7210", Offset = "0xBE6610", VA = "0x180BE7210")]
	public void MFOODBNCIHP(string FPLJCBGEJAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GHKCIFFAHIG : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private static class ECKMOPIJKFD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3ADAD40", Offset = "0x3ADA140", VA = "0x183ADAD40")]
		static ECKMOPIJKFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private GHKCIFFAHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class MPBBAAPDPEF
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> OPLCOBLCBEA;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0xBE1BB0", Offset = "0xBE0FB0", VA = "0x180BE1BB0")]
	static MPBBAAPDPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xBE14A0", Offset = "0xBE08A0", VA = "0x180BE14A0")]
	internal static object NOBELMGICPC(Type MOGPOAHNFIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class KGOBLKDLMHP : global::PDLGFBEOKBE<Vector2>, GKNPAAIBGAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FHKECKDGJBC GEFCDPNCPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] LGHNGPGJLDH;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xBDC9B0", Offset = "0xBDBDB0", VA = "0x180BDC9B0")]
	public KGOBLKDLMHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xBDC840", Offset = "0xBDBC40", VA = "0x180BDC840", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, Vector2 FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xBDC560", Offset = "0xBDB960", VA = "0x180BDC560", Slot = "5")]
	public Vector2 AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class AEBDOGMBNPL : global::PDLGFBEOKBE<Vector3>, GKNPAAIBGAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly FHKECKDGJBC GEFCDPNCPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] LGHNGPGJLDH;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x14B0DD0", Offset = "0x14B01D0", VA = "0x1814B0DD0")]
	public AEBDOGMBNPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x14B0CB0", Offset = "0x14B00B0", VA = "0x1814B0CB0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, Vector3 FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x14B0A80", Offset = "0x14AFE80", VA = "0x1814B0A80", Slot = "5")]
	public Vector3 AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class AGJIOBPMFLA : global::PDLGFBEOKBE<Vector4>, GKNPAAIBGAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly FHKECKDGJBC GEFCDPNCPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] LGHNGPGJLDH;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x14B16A0", Offset = "0x14B0AA0", VA = "0x1814B16A0")]
	public AGJIOBPMFLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x14B1550", Offset = "0x14B0950", VA = "0x1814B1550", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, Vector4 FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x14B12C0", Offset = "0x14B06C0", VA = "0x1814B12C0", Slot = "5")]
	public Vector4 AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class KKGMENGLKIA : global::PDLGFBEOKBE<Quaternion>, GKNPAAIBGAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly FHKECKDGJBC GEFCDPNCPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] LGHNGPGJLDH;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0xBDD1A0", Offset = "0xBDC5A0", VA = "0x180BDD1A0")]
	public KKGMENGLKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0xBDCF30", Offset = "0xBDC330", VA = "0x180BDCF30", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, Quaternion FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xBDCBB0", Offset = "0xBDBFB0", VA = "0x180BDCBB0", Slot = "5")]
	public Quaternion AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PHMGDMBDBAH : global::PDLGFBEOKBE<Color>, GKNPAAIBGAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly FHKECKDGJBC GEFCDPNCPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] LGHNGPGJLDH;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xBE9560", Offset = "0xBE8960", VA = "0x180BE9560")]
	public PHMGDMBDBAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xBDCF30", Offset = "0xBDC330", VA = "0x180BDCF30", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, Color FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0xBE91E0", Offset = "0xBE85E0", VA = "0x180BE91E0", Slot = "5")]
	public Color AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class AOCJOLIKJMO : global::PDLGFBEOKBE<Bounds>, GKNPAAIBGAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly FHKECKDGJBC GEFCDPNCPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] LGHNGPGJLDH;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x14B1EE0", Offset = "0x14B12E0", VA = "0x1814B1EE0")]
	public AOCJOLIKJMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x14B1D40", Offset = "0x14B1140", VA = "0x1814B1D40", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, Bounds FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x14B1A10", Offset = "0x14B0E10", VA = "0x1814B1A10", Slot = "5")]
	public Bounds AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class BJCDHAGFIEG : global::PDLGFBEOKBE<Rect>, GKNPAAIBGAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly FHKECKDGJBC GEFCDPNCPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] LGHNGPGJLDH;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x14B2DB0", Offset = "0x14B21B0", VA = "0x1814B2DB0")]
	public BJCDHAGFIEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x14B2C40", Offset = "0x14B2040", VA = "0x1814B2C40", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, Rect FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x14B2990", Offset = "0x14B1D90", VA = "0x1814B2990", Slot = "5")]
	public Rect AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class FKGKAOJJNDB : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private static class DKLMAFAHJOM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3706360", Offset = "0x3705760", VA = "0x183706360")]
		static DKLMAFAHJOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private FKGKAOJJNDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class MGOGLCIGHNA : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private static class GCKHCCFMNPN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3392570", Offset = "0x3391970", VA = "0x183392570")]
		static GCKHCCFMNPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class ICKHHADJPMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> LGFPLPDKBBF;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1814C10", Offset = "0x1814010", VA = "0x181814C10")]
		internal static object NOBELMGICPC(Type MOGPOAHNFIM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private MGOGLCIGHNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class FBCIKCIKBJI : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class PINHPJLKJDC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x434EF70", Offset = "0x434E370", VA = "0x18434EF70")]
		static PINHPJLKJDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly FBCIKCIKBJI KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool AIBFEHLNLFJ;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static GKNPAAIBGAM[] MFNMNKBNGCA;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static BOIAJJMDENO[] MAHNIOKMCPP;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private FBCIKCIKBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x14BF830", Offset = "0x14BEC30", VA = "0x1814BF830")]
	public static void MHBAMOAJPNP(params BOIAJJMDENO[] MAHNIOKMCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x14BF910", Offset = "0x14BED10", VA = "0x1814BF910")]
	public static void MHBAMOAJPNP(params GKNPAAIBGAM[] MFNMNKBNGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x14BF5A0", Offset = "0x14BE9A0", VA = "0x1814BF5A0")]
	public static void GPJPIPKBFBO(GKNPAAIBGAM[] MFNMNKBNGCA, BOIAJJMDENO[] MAHNIOKMCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class JBHKPNFEDPM : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class LLNHMBEFCGC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3BEC060", Offset = "0x3BEB460", VA = "0x183BEC060")]
		static LLNHMBEFCGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private JBHKPNFEDPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class EHKPLLGMKCC
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly BOIAJJMDENO OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly BOIAJJMDENO GEMBKDLPOKK;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly BOIAJJMDENO KDHCNAGLNJN;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly BOIAJJMDENO MLAKLPGDPGK;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly BOIAJJMDENO EJNBPHNEBEK;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly BOIAJJMDENO DGCDLJOGIDD;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly BOIAJJMDENO EEHEPLNKMDH;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly BOIAJJMDENO BBJHIACDOML;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly BOIAJJMDENO FFCIGDNKHCD;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly BOIAJJMDENO HLPIMAJLGKK;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly BOIAJJMDENO IJCPMKBPNPE;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly BOIAJJMDENO FFGMJIDOEDF;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class JHHOBNPOFBL
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly BOIAJJMDENO OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly BOIAJJMDENO PMOCIKEBLFH;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class JDKGPLGGMNO
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly BOIAJJMDENO OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly BOIAJJMDENO GEMBKDLPOKK;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly BOIAJJMDENO KDHCNAGLNJN;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly BOIAJJMDENO MLAKLPGDPGK;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly BOIAJJMDENO EJNBPHNEBEK;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly BOIAJJMDENO DGCDLJOGIDD;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly BOIAJJMDENO EEHEPLNKMDH;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly BOIAJJMDENO BBJHIACDOML;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly BOIAJJMDENO FFCIGDNKHCD;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly BOIAJJMDENO HLPIMAJLGKK;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly BOIAJJMDENO IJCPMKBPNPE;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly BOIAJJMDENO FFGMJIDOEDF;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class KEDECCILPFH
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> LGFPLPDKBBF;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0xBDA4C0", Offset = "0xBD98C0", VA = "0x180BDA4C0")]
	internal static object NOBELMGICPC(Type MOGPOAHNFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0xBDA480", Offset = "0xBD9880", VA = "0x180BDA480")]
	private static object IOIAKCKAKDB(Type AHMBBHLACOF, Type[] DNMILMLIHOE, params object[] GOFMOOHNBKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class MCCKBKMDACL : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private static class DFHMBCFEGMH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x351C5D0", Offset = "0x351B9D0", VA = "0x18351C5D0")]
		static DFHMBCFEGMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> PNDOFEODHKG;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool CDPKDPCIAEN;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly KGLEEGENLLO FJBFLDFIKKC;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0xBDF2A0", Offset = "0xBDE6A0", VA = "0x180BDF2A0")]
	static MCCKBKMDACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private MCCKBKMDACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class OPEHEKFAJGG : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private static class HOKIFCNCEBP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x41A2BF0", Offset = "0x41A1FF0", VA = "0x1841A2BF0")]
		static HOKIFCNCEBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> PNDOFEODHKG;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool CDPKDPCIAEN;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly KGLEEGENLLO FJBFLDFIKKC;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0xBE8820", Offset = "0xBE7C20", VA = "0x180BE8820")]
	static OPEHEKFAJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private OPEHEKFAJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class LNMBFOIKBAI : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class GFFIJACNBJA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3398E20", Offset = "0x3398220", VA = "0x183398E20")]
		static GFFIJACNBJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> PNDOFEODHKG;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool CDPKDPCIAEN;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly KGLEEGENLLO FJBFLDFIKKC;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0xBDEF70", Offset = "0xBDE370", VA = "0x180BDEF70")]
	static LNMBFOIKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private LNMBFOIKBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class CNBBDDENNMB : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class FBLCLLKCCGP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3730E90", Offset = "0x3730290", VA = "0x183730E90")]
		static FBLCLLKCCGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> PNDOFEODHKG;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool CDPKDPCIAEN;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly KGLEEGENLLO FJBFLDFIKKC;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x14B9370", Offset = "0x14B8770", VA = "0x1814B9370")]
	static CNBBDDENNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private CNBBDDENNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class LKOAFOIAFGG : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class JMJCBMNECHP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x37A0290", Offset = "0x379F690", VA = "0x1837A0290")]
		static JMJCBMNECHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> PNDOFEODHKG;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool CDPKDPCIAEN;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly KGLEEGENLLO FJBFLDFIKKC;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xBDEDD0", Offset = "0xBDE1D0", VA = "0x180BDEDD0")]
	static LKOAFOIAFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private LKOAFOIAFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class EAIOCLFJMGO : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class MOGBOOBBCBL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x35FD940", Offset = "0x35FCD40", VA = "0x1835FD940")]
		static MOGBOOBBCBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> PNDOFEODHKG;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool CDPKDPCIAEN;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly KGLEEGENLLO FJBFLDFIKKC;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x14BD530", Offset = "0x14BC930", VA = "0x1814BD530")]
	static EAIOCLFJMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private EAIOCLFJMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class IHKCMCDKCON : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class GPCCDAPKGOA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x33ADAD0", Offset = "0x33ACED0", VA = "0x1833ADAD0")]
		static GPCCDAPKGOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> PNDOFEODHKG;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool CDPKDPCIAEN;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public IHKCMCDKCON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class DPENHAEOFKC : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class CIFNGOLDHKJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4065D50", Offset = "0x4065150", VA = "0x184065D50")]
		static CIFNGOLDHKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> PNDOFEODHKG;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool CDPKDPCIAEN;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public DPENHAEOFKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class FOCBMCKFNLO : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class CICEMJNNKBD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4060D80", Offset = "0x4060180", VA = "0x184060D80")]
		static CICEMJNNKBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> PNDOFEODHKG;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool CDPKDPCIAEN;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public FOCBMCKFNLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class ACPJDMMHCPD : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class HNANKKPIENO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x419AC80", Offset = "0x419A080", VA = "0x18419AC80")]
		static HNANKKPIENO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> PNDOFEODHKG;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool CDPKDPCIAEN;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ACPJDMMHCPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class GECGDCEICPO : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class EBIDKHLCMEF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4A70", Offset = "0x3AD3E70", VA = "0x183AD4A70")]
		static EBIDKHLCMEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> PNDOFEODHKG;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool CDPKDPCIAEN;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public GECGDCEICPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class NBMGPLPKPCD : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class BGCCPEEPCGL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x31D4080", Offset = "0x31D3480", VA = "0x1831D4080")]
		static BGCCPEEPCGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> PNDOFEODHKG;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool CDPKDPCIAEN;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public NBMGPLPKPCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal static class PPHCEPFEKPF
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private struct ABDIFHOBCDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public GHJICNHNAMA NFPFFAGMHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder MLOIIOLGODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder OMKHNHLIEHP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class JDFOFHBBDDO
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		internal static class KFEPDPBEGLF
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo DHJMNDCECON;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo LOJLDMAKGHO;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo EPDPJIFMKPD;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo GBEHAKIAMHH;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo GHPOJIEOFAE;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo MJOINOEKKMP;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo HOPOPKLKCPL;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo OKINBAPNIED;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo JNNJIFFLBKI;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x18196A0", Offset = "0x1818AA0", VA = "0x1818196A0")]
			static KFEPDPBEGLF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class LNOAABOCABF
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo GGPPEBJMJMO;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo HNCNGBAEAIH;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo BNOCANEFPKJ;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo ICMPANOJGLO;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo DMBGJFFCKOE;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo LLGAMFGCEBB;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo LAPBEANFHKA;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x181A810", Offset = "0x1819C10", VA = "0x18181A810")]
			static LNOAABOCABF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class CICLICIAOGA
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo PEAPHOICMAL;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo MFHOFBPGEML;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo FMLJBMFMOKM;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo CODJJMALKBA;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo KODKGDHCIOP;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo PMADHBCNOFE;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo GKDBLAKAGJJ;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo GCEKFBGNIIO;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo DABLNNJLABH;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo EPAEGCGOCGN;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo EEPPKCFJJAC;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo JPMHDLMOKFC;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo DHILJCOCNLG;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo LNDJBNOGCJA;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x1817B90", Offset = "0x1816F90", VA = "0x181817B90")]
		public static MethodInfo DGECGJPLFOM(Type BKGBGEHNCAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1817920", Offset = "0x1816D20", VA = "0x181817920")]
		public static MethodInfo AHLFMBEKFNG(Type BKGBGEHNCAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1817E60", Offset = "0x1817260", VA = "0x181817E60")]
		public static MethodInfo OOBGMJMGABH(Type BKGBGEHNCAE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class EFBAGGCLJMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<GHJICNHNAMA, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public EFBAGGCLJMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class OGABHNLPJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public EFBAGGCLJMK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public OGABHNLPJGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x181BC60", Offset = "0x181B060", VA = "0x18181BC60")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x181BCA0", Offset = "0x181B0A0", VA = "0x18181BCA0")]
		internal bool <BuildType>b__2(int index, GHJICNHNAMA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class JHPDNBINNON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public EFBAGGCLJMK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JHPDNBINNON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1819600", Offset = "0x1818A00", VA = "0x181819600")]
		internal bool <BuildType>b__3(int index, GHJICNHNAMA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class BFPAAPCLHAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Func<string, string> nameMutator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public List<object> serializeCustomFormatters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public List<object> deserializeCustomFormatters;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public BFPAAPCLHAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x180F910", Offset = "0x180ED10", VA = "0x18180F910")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class LKNDBBLACNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public LKNDBBLACNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x181A7B0", Offset = "0x1819BB0", VA = "0x18181A7B0")]
		internal bool <BuildAnonymousFormatter>b__2(GHJICNHNAMA x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class IIAGPNEMKBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public BFPAAPCLHAH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public IIAGPNEMKBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x1816B80", Offset = "0x1815F80", VA = "0x181816B80")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x1816B90", Offset = "0x1815F90", VA = "0x181816B90")]
		internal bool <BuildAnonymousFormatter>b__6(int index, GHJICNHNAMA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class JAOKMNOHPIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public BFPAAPCLHAH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JAOKMNOHPIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x1816D30", Offset = "0x1816130", VA = "0x181816D30")]
		internal bool <BuildAnonymousFormatter>b__7(int index, GHJICNHNAMA member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class HJHFDHOECHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public HJHFDHOECHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x92B380", Offset = "0x92A780", VA = "0x18092B380")]
		internal Label <BuildSerialize>b__1(GHJICNHNAMA _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class OOPKBOKCDKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public ABDIFHOBCDO[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, GHJICNHNAMA, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public KALJKAHGEJB argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public KALJKAHGEJB argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public OOPKBOKCDKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x181BD40", Offset = "0x181B140", VA = "0x18181BD40")]
		internal ABDIFHOBCDO <BuildDeserialize>b__0(GHJICNHNAMA item)
		{
			return default(ABDIFHOBCDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class JCOJDEAODIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public OOPKBOKCDKL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JCOJDEAODIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1816FE0", Offset = "0x18163E0", VA = "0x181816FE0")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x1817290", Offset = "0x1816690", VA = "0x181817290")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class BLHADDLEDOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public GHJICNHNAMA item;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public BLHADDLEDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x18124F0", Offset = "0x18118F0", VA = "0x1818124F0")]
		internal bool <EmitNewObject>b__0(ABDIFHOBCDO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class OKBEANNKAGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GHJICNHNAMA item;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public OKBEANNKAGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x18124F0", Offset = "0x18118F0", VA = "0x1818124F0")]
		internal bool <EmitNewObject>b__2(ABDIFHOBCDO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex DADJIKHIPJP;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int GPKNDAOHGLF;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> BMGMLLNFJEJ;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> AGFLDAOGIHD;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3B98450", Offset = "0x3B97850", VA = "0x183B98450")]
	public static object FBJOEIPAEIE<T>(KGLEEGENLLO FJBFLDFIKKC, BOIAJJMDENO LEDENOHPACN, Func<string, string> PNDOFEODHKG, bool CDPKDPCIAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3890", Offset = "0x3BA2C90", VA = "0x183BA3890")]
	public static object LDMNNHJODOE<T>(BOIAJJMDENO LEDENOHPACN, Func<string, string> PNDOFEODHKG, bool CDPKDPCIAEN, bool GNEECIPIAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xBECD00", Offset = "0xBEC100", VA = "0x180BECD00")]
	private static TypeInfo AJEGGOAOOFP(KGLEEGENLLO FJBFLDFIKKC, Type BKGBGEHNCAE, Func<string, string> PNDOFEODHKG, bool CDPKDPCIAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xBF2680", Offset = "0xBF1A80", VA = "0x180BF2680")]
	public static object OEHBLNIBIAH(Type BKGBGEHNCAE, Func<string, string> PNDOFEODHKG, bool CDPKDPCIAEN, bool GNEECIPIAAI, bool CDJMCJGHLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xBF1310", Offset = "0xBF0710", VA = "0x180BF1310")]
	private static Dictionary<GHJICNHNAMA, FieldInfo> IBCEAAGEMPE(TypeBuilder GCEKBLLJCCA, HKLEBEKANAN NOENCABPBHG, ConstructorInfo JPFHNIBFEJN, FieldBuilder NGLLMCEEDCC, ILGenerator OAKLIGPKAHD, bool CDPKDPCIAEN, bool NBEKLNACNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0xBF0260", Offset = "0xBEF660", VA = "0x180BF0260")]
	private static Dictionary<GHJICNHNAMA, FieldInfo> FEALOMBKJGD(TypeBuilder GCEKBLLJCCA, HKLEBEKANAN NOENCABPBHG, ILGenerator OAKLIGPKAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xBEEBD0", Offset = "0xBEDFD0", VA = "0x180BEEBD0")]
	private static void AOCFINOECPJ(Type BKGBGEHNCAE, HKLEBEKANAN NOENCABPBHG, ILGenerator OAKLIGPKAHD, Action IOHIEJBBMPF, Func<int, GHJICNHNAMA, bool> HKFCEGANDPP, bool CDPKDPCIAEN, bool NBEKLNACNNG, int PGNLFOHMACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xBF19F0", Offset = "0xBF0DF0", VA = "0x180BF19F0")]
	private static void KAEOKLKKPCC(TypeInfo BKGBGEHNCAE, GHJICNHNAMA HDGAEKOFBJL, ILGenerator OAKLIGPKAHD, int GABJOMFFJAI, Func<int, GHJICNHNAMA, bool> HKFCEGANDPP, KALJKAHGEJB CDLKNDDFOPH, KALJKAHGEJB DOAHMAJOGLH, KALJKAHGEJB CBDJGKENDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xBED790", Offset = "0xBECB90", VA = "0x180BED790")]
	private static void AKPNACHIBGN(Type BKGBGEHNCAE, HKLEBEKANAN NOENCABPBHG, ILGenerator OAKLIGPKAHD, Func<int, GHJICNHNAMA, bool> HKFCEGANDPP, bool IGLPOBLFGGG, int PGNLFOHMACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0xBF2130", Offset = "0xBF1530", VA = "0x180BF2130")]
	private static void LCBHDJNCPDC(ILGenerator OAKLIGPKAHD, ABDIFHOBCDO NOENCABPBHG, int GABJOMFFJAI, Func<int, GHJICNHNAMA, bool> HKFCEGANDPP, KALJKAHGEJB LGIEPMOBDDP, KALJKAHGEJB CBDJGKENDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xBF4270", Offset = "0xBF3670", VA = "0x180BF4270")]
	private static LocalBuilder OMAIBNHCAGD(ILGenerator OAKLIGPKAHD, Type BKGBGEHNCAE, HKLEBEKANAN NOENCABPBHG, ABDIFHOBCDO[] PMEIOHMAEHL, bool MNHFDPAPEHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xBF08E0", Offset = "0xBEFCE0", VA = "0x180BF08E0")]
	private static bool FOEOJKFGIKL(ConstructorInfo NOHOIDIOCHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xBF1160", Offset = "0xBF0560", VA = "0x180BF1160")]
	private static bool GEKIMDBKADE(Type BKGBGEHNCAE, out Type NMOOGJKPJKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal delegate void EPBIIKNBNLP<T>(byte[][] NGLLMCEEDCC, object[] JPOLILOLNAD, ref OCIPHIDCELE CDLKNDDFOPH, T FPLJCBGEJAP, BOIAJJMDENO NBILJDMEMDM);
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate T AHDJKBMHKCP<T>(object[] JPOLILOLNAD, ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO NBILJDMEMDM);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class DJOMODJFFKG<T> : global::PDLGFBEOKBE<T>, GKNPAAIBGAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] NGLLMCEEDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] NMDAPOEMICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] KHLOGPBIPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly global::EPBIIKNBNLP<T> BGJGBACCLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly global::AHDJKBMHKCP<T> MBMJEPEFJPJ;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x36FC540", Offset = "0x36FB940", VA = "0x1836FC540")]
	public DJOMODJFFKG(byte[][] NGLLMCEEDCC, object[] NMDAPOEMICE, object[] KHLOGPBIPBG, global::EPBIIKNBNLP<T> BGJGBACCLEC, global::AHDJKBMHKCP<T> MBMJEPEFJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x36FC460", Offset = "0x36FB860", VA = "0x1836FC460", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, T FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x36FC390", Offset = "0x36FB790", VA = "0x1836FC390", Slot = "5")]
	public T AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class NMMPOCFBPOG : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class IGCIFEEKHAA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x27FF940", Offset = "0x27FED40", VA = "0x1827FF940")]
		static IGCIFEEKHAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private NMMPOCFBPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class JNMLJLMHLHF : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	private static class PLHIPHLECEL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3D67620", Offset = "0x3D66A20", VA = "0x183D67620")]
		static PLHIPHLECEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private JNMLJLMHLHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal static class FEJMKFEFNII
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly BOIAJJMDENO[] GNALBAKHNJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal sealed class IPDMHOJHBLE : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private static class AEIPHDKBHHI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x49479B0", Offset = "0x4946DB0", VA = "0x1849479B0")]
		static AEIPHDKBHHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private sealed class CIKIIIOFJNM : BOIAJJMDENO
	{
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		private static class JEKPNGGCJPM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x327A4C0", Offset = "0x32798C0", VA = "0x18327A4C0")]
			static JEKPNGGCJPM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly BOIAJJMDENO KGGJIHLJBIH;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly BOIAJJMDENO[] MAHNIOKMCPP;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		private CIKIIIOFJNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
		public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly global::PDLGFBEOKBE<object> PLEKIPADOMC;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private IPDMHOJHBLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class JPOHNNDNADN : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class JAPMHLHKJAG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3F49ED0", Offset = "0x3F492D0", VA = "0x183F49ED0")]
		static JAPMHLHKJAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class EPNDFJNCCEK : BOIAJJMDENO
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class BAHKGMODOFH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x31CC3A0", Offset = "0x31CB7A0", VA = "0x1831CC3A0")]
			static BAHKGMODOFH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly BOIAJJMDENO KGGJIHLJBIH;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly BOIAJJMDENO[] MAHNIOKMCPP;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		private EPNDFJNCCEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
		public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly global::PDLGFBEOKBE<object> PLEKIPADOMC;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private JPOHNNDNADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class MBBGMGCBOOC : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class MEGBNOOFMKM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3E67190", Offset = "0x3E66590", VA = "0x183E67190")]
		static MEGBNOOFMKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class DGKACMHJFLL : BOIAJJMDENO
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class ENKMCJCHJFO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x2527D10", Offset = "0x2527110", VA = "0x182527D10")]
			static ENKMCJCHJFO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly BOIAJJMDENO KGGJIHLJBIH;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly BOIAJJMDENO[] MAHNIOKMCPP;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		private DGKACMHJFLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
		public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly global::PDLGFBEOKBE<object> PLEKIPADOMC;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private MBBGMGCBOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class DFDPHKABJFD : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class LGOBPBEOGBA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2EA0CB0", Offset = "0x2EA00B0", VA = "0x182EA0CB0")]
		static LGOBPBEOGBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class NGJDOAKDOIN : BOIAJJMDENO
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class MHGACLBNDOE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x3800B90", Offset = "0x37FFF90", VA = "0x183800B90")]
			static MHGACLBNDOE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly BOIAJJMDENO KGGJIHLJBIH;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly BOIAJJMDENO[] MAHNIOKMCPP;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		private NGJDOAKDOIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
		public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::PDLGFBEOKBE<object> PLEKIPADOMC;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private DFDPHKABJFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class EBDKFLOLCHM : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class AHKFDONGNJM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3225970", Offset = "0x3224D70", VA = "0x183225970")]
		static AHKFDONGNJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class POJHJGKKIBH : BOIAJJMDENO
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class EKOILBENEDN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x3B40620", Offset = "0x3B3FA20", VA = "0x183B40620")]
			static EKOILBENEDN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly BOIAJJMDENO KGGJIHLJBIH;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly BOIAJJMDENO[] MAHNIOKMCPP;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		private POJHJGKKIBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
		public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly global::PDLGFBEOKBE<object> PLEKIPADOMC;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private EBDKFLOLCHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class DENDIDHJBOK : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class BPFHPKAAJPF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x31EE3F0", Offset = "0x31ED7F0", VA = "0x1831EE3F0")]
		static BPFHPKAAJPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class OPOIGOANPCH : BOIAJJMDENO
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class LKLAMAIMPMI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3BE6110", Offset = "0x3BE5510", VA = "0x183BE6110")]
			static LKLAMAIMPMI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly BOIAJJMDENO KGGJIHLJBIH;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly BOIAJJMDENO[] MAHNIOKMCPP;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		private OPOIGOANPCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
		public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly global::PDLGFBEOKBE<object> PLEKIPADOMC;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private DENDIDHJBOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class BAOHEJFIHDA : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class INGCMACMJDL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x33C2A90", Offset = "0x33C1E90", VA = "0x1833C2A90")]
		static INGCMACMJDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class CDFPONICGEG : BOIAJJMDENO
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class GHKALEDNNON<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x339C900", Offset = "0x339BD00", VA = "0x18339C900")]
			static GHKALEDNNON()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly BOIAJJMDENO KGGJIHLJBIH;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly BOIAJJMDENO[] MAHNIOKMCPP;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		private CDFPONICGEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
		public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly global::PDLGFBEOKBE<object> PLEKIPADOMC;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private BAOHEJFIHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class CDPJLBCKIHM : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class JGFFLDJKCHE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3285490", Offset = "0x3284890", VA = "0x183285490")]
		static JGFFLDJKCHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class GHPNEDCNKCG : BOIAJJMDENO
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class OOCFFAINDKF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2CCEEB0", Offset = "0x2CCE2B0", VA = "0x182CCEEB0")]
			static OOCFFAINDKF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly BOIAJJMDENO KGGJIHLJBIH;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly BOIAJJMDENO[] MAHNIOKMCPP;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		private GHPNEDCNKCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
		public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly global::PDLGFBEOKBE<object> PLEKIPADOMC;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private CDPJLBCKIHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class KBDJEEAJBDA : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class MBFBKBPBGMF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3E5D500", Offset = "0x3E5C900", VA = "0x183E5D500")]
		static MBFBKBPBGMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class NCOPLPFLGCF : BOIAJJMDENO
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class DCODIPHCKED<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x350D550", Offset = "0x350C950", VA = "0x18350D550")]
			static DCODIPHCKED()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly BOIAJJMDENO KGGJIHLJBIH;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly BOIAJJMDENO[] MAHNIOKMCPP;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		private NCOPLPFLGCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
		public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly global::PDLGFBEOKBE<object> PLEKIPADOMC;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private KBDJEEAJBDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class IJDKMLOAKIG : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class HIKJGIOJBGI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x39D1CD0", Offset = "0x39D10D0", VA = "0x1839D1CD0")]
		static HIKJGIOJBGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class NADPELGNLDN : BOIAJJMDENO
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class OBMFOIBIOCO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x2C13A40", Offset = "0x2C12E40", VA = "0x182C13A40")]
			static OBMFOIBIOCO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly BOIAJJMDENO KGGJIHLJBIH;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly BOIAJJMDENO[] MAHNIOKMCPP;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		private NADPELGNLDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
		public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::PDLGFBEOKBE<object> PLEKIPADOMC;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private IJDKMLOAKIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class IKCMKFCPBBE : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class LLPHJLMHJNB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3BF08D0", Offset = "0x3BEFCD0", VA = "0x183BF08D0")]
		static LLPHJLMHJNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class BHDPJBCLOFE : BOIAJJMDENO
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class EOOLLMCEBDA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x252D6B0", Offset = "0x252CAB0", VA = "0x18252D6B0")]
			static EOOLLMCEBDA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly BOIAJJMDENO KGGJIHLJBIH;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly BOIAJJMDENO[] MAHNIOKMCPP;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		private BHDPJBCLOFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
		public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly global::PDLGFBEOKBE<object> PLEKIPADOMC;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private IKCMKFCPBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class GOAJMMHBBGM : BOIAJJMDENO
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class ABDPMIDFDMP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x493F880", Offset = "0x493EC80", VA = "0x18493F880")]
		static ABDPMIDFDMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class LHOJIKHMDJG : BOIAJJMDENO
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class EJKGBCMBBPI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly global::PDLGFBEOKBE<T> ANBIOLPOAPD;

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x3B39110", Offset = "0x3B38510", VA = "0x183B39110")]
			static EJKGBCMBBPI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly BOIAJJMDENO KGGJIHLJBIH;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly BOIAJJMDENO[] MAHNIOKMCPP;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		private LHOJIKHMDJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
		public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly BOIAJJMDENO KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly global::PDLGFBEOKBE<object> PLEKIPADOMC;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	private GOAJMMHBBGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2957960", Offset = "0x2956D60", VA = "0x182957960", Slot = "4")]
	public global::PDLGFBEOKBE<T> NOBELMGICPC<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct FJPIKGFHOEB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] MGJJNPLBGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int NEINKDNDOKH;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3E94740", Offset = "0x3E93B40", VA = "0x183E94740")]
	public FJPIKGFHOEB(int NKILFKIIOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3E94300", Offset = "0x3E93700", VA = "0x183E94300")]
	public void BKCAAEBNAMB(T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3E94270", Offset = "0x3E93670", VA = "0x183E94270")]
	public T[] BJNJCKGMKBA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
internal sealed class MDFKHHOJFLK : global::EGOPAGKOPFJ<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly MDFKHHOJFLK OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0xBDF450", Offset = "0xBDE850", VA = "0x180BDF450")]
	public MDFKHHOJFLK(int BACKAFGKMBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal class EGOPAGKOPFJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int BACKAFGKMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object HKEBFOKPDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int GABJOMFFJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] OLOJGFOEHFA;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3B31440", Offset = "0x3B30840", VA = "0x183B31440")]
	public EGOPAGKOPFJ(int BACKAFGKMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3B30E90", Offset = "0x3B30290", VA = "0x183B30E90")]
	public T[] MACDEEGAMPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3B30BF0", Offset = "0x3B2FFF0", VA = "0x183B30BF0")]
	public void FCLEDONOACJ(T[] OGMMNHCCDJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class FHKECKDGJBC : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class DLFBKLMMEIJ : IComparable<DLFBKLMMEIJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class KLDOBEGOGDP : IEnumerable<DLFBKLMMEIJ>, IEnumerable, IEnumerator<DLFBKLMMEIJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private DLFBKLMMEIJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public DLFBKLMMEIJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private DLFBKLMMEIJ System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F0")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F2")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
			[DebuggerHidden]
			public KLDOBEGOGDP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x181A480", Offset = "0x1819880", VA = "0x18181A480", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x181A5B0", Offset = "0x18199B0", VA = "0x18181A5B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x181A510", Offset = "0x1819910", VA = "0x18181A510", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<DLFBKLMMEIJ> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x181A510", Offset = "0x1819910", VA = "0x18181A510", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class PMIABBOCLEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public PMIABBOCLEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x92B380", Offset = "0x92A780", VA = "0x18092B380")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x92B380", Offset = "0x92A780", VA = "0x18092B380")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly DLFBKLMMEIJ[] KNEBHKOBGPJ;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] DEGMFNJHHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong BBKANMJFKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int EJBPMDLBLGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string OICPOCGIFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private DLFBKLMMEIJ[] FKJGDHIPEIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] GPALCHCFCGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int NDNADCNCIGM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool EEMOOACNIMH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x166B9C0", Offset = "0x166ADC0", VA = "0x18166B9C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x18142A0", Offset = "0x18136A0", VA = "0x1818142A0")]
		public DLFBKLMMEIJ(ulong NPBDKCONLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x1812E80", Offset = "0x1812280", VA = "0x181812E80")]
		public DLFBKLMMEIJ BKCAAEBNAMB(ulong NPBDKCONLNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x1813140", Offset = "0x1812540", VA = "0x181813140")]
		public DLFBKLMMEIJ BKCAAEBNAMB(ulong NPBDKCONLNC, int FPLJCBGEJAP, string OICPOCGIFLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1813FF0", Offset = "0x18133F0", VA = "0x181813FF0")]
		public DLFBKLMMEIJ JIGOCGDIGHI(byte[] KONDPAFENHO, ref int BPNKPMGDGFM, ref int HGDCANNJPGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x1812E00", Offset = "0x1812200", VA = "0x181812E00")]
		internal static int AJJIAALLCPA(ulong[] OGMMNHCCDJE, int GABJOMFFJAI, int DMFMCPNNNLJ, ulong FPLJCBGEJAP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1813190", Offset = "0x1812590", VA = "0x181813190", Slot = "4")]
		public int CompareTo(DLFBKLMMEIJ FJLHJLAMLMA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x18141A0", Offset = "0x18135A0", VA = "0x1818141A0")]
		[IteratorStateMachine(typeof(KLDOBEGOGDP))]
		public IEnumerable<DLFBKLMMEIJ> LLGEFCPCEAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x1813EB0", Offset = "0x18132B0", VA = "0x181813EB0")]
		public void IBKPDDCMGMF(ILGenerator OAKLIGPKAHD, LocalBuilder KONDPAFENHO, LocalBuilder HGDCANNJPGF, LocalBuilder NPBDKCONLNC, Action<KeyValuePair<string, int>> IHJOIDDGHPJ, Action HODIFKLDNMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x18131C0", Offset = "0x18125C0", VA = "0x1818131C0")]
		private static void FEHPNLPGPMA(ILGenerator OAKLIGPKAHD, LocalBuilder KONDPAFENHO, LocalBuilder HGDCANNJPGF, LocalBuilder NPBDKCONLNC, Action<KeyValuePair<string, int>> IHJOIDDGHPJ, Action HODIFKLDNMJ, DLFBKLMMEIJ[] FKJGDHIPEIC, int NDNADCNCIGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class BHKMACMLEBM : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private IEnumerable<DLFBKLMMEIJ> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<DLFBKLMMEIJ> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<DLFBKLMMEIJ> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private DLFBKLMMEIJ <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x8291E0", Offset = "0x8285E0", VA = "0x1808291E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x1812320", Offset = "0x1811720", VA = "0x181812320", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x829280", Offset = "0x828680", VA = "0x180829280")]
		[DebuggerHidden]
		public BHKMACMLEBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1812370", Offset = "0x1811770", VA = "0x181812370", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1811DE0", Offset = "0x18111E0", VA = "0x181811DE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x1812450", Offset = "0x1811850", VA = "0x181812450")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x18124A0", Offset = "0x18118A0", VA = "0x1818124A0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x18122E0", Offset = "0x18116E0", VA = "0x1818122E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1812240", Offset = "0x1811640", VA = "0x181812240", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1812240", Offset = "0x1811640", VA = "0x181812240", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly DLFBKLMMEIJ ALLJDBGIIHH;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x14C0600", Offset = "0x14BFA00", VA = "0x1814C0600")]
	public FHKECKDGJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x14C0020", Offset = "0x14BF420", VA = "0x1814C0020")]
	public void BKCAAEBNAMB(byte[] GJDBLJLIDDI, int FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x14C0130", Offset = "0x14BF530", VA = "0x1814C0130")]
	public bool GCJIMOBDNDG(ArraySegment<byte> NPBDKCONLNC, out int FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x14C0570", Offset = "0x14BF970", VA = "0x1814C0570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x14C02D0", Offset = "0x14BF6D0", VA = "0x1814C02D0")]
	private static void NMDBJAAHLCI(IEnumerable<DLFBKLMMEIJ> FKJGDHIPEIC, StringBuilder LKPFCMFGBCE, int CLPHJECJKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x14C01F0", Offset = "0x14BF5F0", VA = "0x1814C01F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x14C01F0", Offset = "0x14BF5F0", VA = "0x1814C01F0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x14BFFB0", Offset = "0x14BF3B0", VA = "0x1814BFFB0")]
	[IteratorStateMachine(typeof(BHKMACMLEBM))]
	private static IEnumerable<KeyValuePair<string, int>> BEAKGBAIPKO(IEnumerable<DLFBKLMMEIJ> FKJGDHIPEIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x14C02A0", Offset = "0x14BF6A0", VA = "0x1814C02A0")]
	public void HMFOCEFIPGP(ILGenerator OAKLIGPKAHD, LocalBuilder KONDPAFENHO, LocalBuilder HGDCANNJPGF, LocalBuilder NPBDKCONLNC, Action<KeyValuePair<string, int>> IHJOIDDGHPJ, Action HODIFKLDNMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public static class BLLAOFPAJGC
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo MBDKDICAJJO;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x14B3340", Offset = "0x14B2740", VA = "0x1814B3340")]
	public static ulong ENELAHKPEEH(byte[] GJDBLJLIDDI, ref int BPNKPMGDGFM, ref int HGDCANNJPGF)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class AAMDKCGFJGF
{
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x14B06F0", Offset = "0x14AFAF0", VA = "0x1814B06F0")]
	public static void NAGBAKDBAJB(ref byte[] GJDBLJLIDDI, int BPNKPMGDGFM, int LCFPHMBMMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x14B04C0", Offset = "0x14AF8C0", VA = "0x1814B04C0")]
	public static void KFPPBFAGLLM(ref byte[] OGMMNHCCDJE, int IPFOAOPHDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x14B05D0", Offset = "0x14AF9D0", VA = "0x1814B05D0")]
	public static byte[] LCLFJOCKOFA(byte[] KEPPKNDIOGA, int IPFOAOPHDFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class DCLOJGCJJNG
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x14B9A80", Offset = "0x14B8E80", VA = "0x1814B9A80")]
	public static bool LNPLILOIFFP(byte[] FAJMDJANAIH, int IHHGIDNEJBP, int ILGNBIAOBKC, byte[] ANIFJBKFGEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class CNIAMNBBAFD<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private struct DBNIAOFCKKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] BBKANMJFKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T EJBPMDLBLGL;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3505540", Offset = "0x3504940", VA = "0x183505540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class HDMEDDKDDHD : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public global::CNIAMNBBAFD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private DBNIAOFCKKE[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private DBNIAOFCKKE[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x8291E0", Offset = "0x8285E0", VA = "0x1808291E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x39C6E00", Offset = "0x39C6200", VA = "0x1839C6E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E910", Offset = "0x2A3DD10", VA = "0x182A3E910")]
		[DebuggerHidden]
		public HDMEDDKDDHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x4393D50", Offset = "0x4393150", VA = "0x184393D50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x43940B0", Offset = "0x43934B0", VA = "0x1843940B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly DBNIAOFCKKE[][] CHHIFKCOGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong JJEGGNEKCDA;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3D8C330", Offset = "0x3D8B730", VA = "0x183D8C330")]
	public CNIAMNBBAFD(int NANBMPFBPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3D8C270", Offset = "0x3D8B670", VA = "0x183D8C270")]
	public CNIAMNBBAFD(int NANBMPFBPOK, float BFNFLCNGECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4072BF0", Offset = "0x4071FF0", VA = "0x184072BF0")]
	public void BKCAAEBNAMB(byte[] NPBDKCONLNC, T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x406FAC0", Offset = "0x406EEC0", VA = "0x18406FAC0")]
	private bool BBHNGEOFANJ(byte[] NPBDKCONLNC, T FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x4076280", Offset = "0x4075680", VA = "0x184076280")]
	public bool MPHIBFICBKB(ArraySegment<byte> NPBDKCONLNC, out T FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3D8C210", Offset = "0x3D8B610", VA = "0x183D8C210")]
	private static ulong OLHPFKHEAGK(byte[] IMDGNLLHHDC, int BPNKPMGDGFM, int NDNADCNCIGM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3D8B500", Offset = "0x3D8A900", VA = "0x183D8B500")]
	private static int KDDMDPNDFDP(int NIKEJOEBHBI, float BFNFLCNGECA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3D8B3E0", Offset = "0x3D8A7E0", VA = "0x183D8B3E0", Slot = "4")]
	[IteratorStateMachine(typeof(global::CNIAMNBBAFD<>.HDMEDDKDDHD))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x27F06D0", Offset = "0x27EFAD0", VA = "0x1827F06D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal class OJCPMPHAHBF : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] JNPPBKPJGNK;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] IDPBBJOLANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int ADPMOBDOFMO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool NNPNABNCELJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xBE81F0", Offset = "0xBE75F0", VA = "0x180BE81F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xBE8240", Offset = "0xBE7640", VA = "0x180BE8240")]
	static OJCPMPHAHBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xBE84C0", Offset = "0xBE78C0", VA = "0x180BE84C0")]
	public OJCPMPHAHBF(byte[] CPDOILIABKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0xBE80D0", Offset = "0xBE74D0", VA = "0x180BE80D0")]
	public OpCode AHKJDPDINMB()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal struct JHPKJCODNOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid EJBPMDLBLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte NMAKHHCNJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte EDHLPIJBJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte DEKBGLKEHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte MJKIEMDBPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte DDPHPIIPBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte EONNGJICIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte OFFJOAGOGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte PKMJBLJGAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte BBAMJMMBJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte JDFHKDKDHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte CIEHJPCMEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte ACHNENBEGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte ICDJKKBEMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte NOCOPKMKDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte HOMCKMDFNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte CCNJBHJJGNL;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] GCDPLMOPJLP;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] BCKLPABIKMO;

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0xBD7AC0", Offset = "0xBD6EC0", VA = "0x180BD7AC0")]
	public JHPKJCODNOJ(ref Guid FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xBD6670", Offset = "0xBD5A70", VA = "0x180BD6670")]
	public JHPKJCODNOJ(ref ArraySegment<byte> OCIACCBONNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0xBD64E0", Offset = "0xBD58E0", VA = "0x180BD64E0")]
	private static byte KAMMJDDIEOK(byte[] GJDBLJLIDDI, int FCCNDLHIPIO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xBD63D0", Offset = "0xBD57D0", VA = "0x180BD63D0")]
	private static byte HJGODDFILJD(byte CFEKEMJOJGA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0xBD5080", Offset = "0xBD4480", VA = "0x180BD5080")]
	public void DCPECBLCMDK(byte[] DGPBECDNOKK, int BPNKPMGDGFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class DPONFOMAKKN
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x14BD080", Offset = "0x14BC480", VA = "0x1814BD080")]
	public static bool OENMKMPMHHB(byte JJJCLNDDKAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x14BBF70", Offset = "0x14BB370", VA = "0x1814BBF70")]
	public static bool JJKCBCCDOCI(byte JJJCLNDDKAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x14BD010", Offset = "0x14BC410", VA = "0x1814BD010")]
	public static sbyte OEKMIAHBOBA(byte[] GJDBLJLIDDI, int BPNKPMGDGFM, out int HOFJBGAALGC)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x14BB550", Offset = "0x14BA950", VA = "0x1814BB550")]
	public static short EMEAADBLHDP(byte[] GJDBLJLIDDI, int BPNKPMGDGFM, out int HOFJBGAALGC)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x14BB5C0", Offset = "0x14BA9C0", VA = "0x1814BB5C0")]
	public static int FOIIMDFDPBH(byte[] GJDBLJLIDDI, int BPNKPMGDGFM, out int HOFJBGAALGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x14BBFE0", Offset = "0x14BB3E0", VA = "0x1814BBFE0")]
	public static long JKIAPEFPDPO(byte[] GJDBLJLIDDI, int BPNKPMGDGFM, out int HOFJBGAALGC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x14BCD30", Offset = "0x14BC130", VA = "0x1814BCD30")]
	public static byte NCOOKIOLMHG(byte[] GJDBLJLIDDI, int BPNKPMGDGFM, out int HOFJBGAALGC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x14BCCC0", Offset = "0x14BC0C0", VA = "0x1814BCCC0")]
	public static ushort KGOOIBOEDKN(byte[] GJDBLJLIDDI, int BPNKPMGDGFM, out int HOFJBGAALGC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x14BBEF0", Offset = "0x14BB2F0", VA = "0x1814BBEF0")]
	public static uint HAKJOBFICMD(byte[] GJDBLJLIDDI, int BPNKPMGDGFM, out int HOFJBGAALGC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x14BB440", Offset = "0x14BA840", VA = "0x1814BB440")]
	public static ulong CIENIAALIAP(byte[] GJDBLJLIDDI, int BPNKPMGDGFM, out int HOFJBGAALGC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x14BB350", Offset = "0x14BA750", VA = "0x1814BB350")]
	public static float BHGKINPHMIA(byte[] GJDBLJLIDDI, int BPNKPMGDGFM, out int HOFJBGAALGC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x14BB630", Offset = "0x14BAA30", VA = "0x1814BB630")]
	public static double GNIECHKMHKJ(byte[] GJDBLJLIDDI, int BPNKPMGDGFM, out int HOFJBGAALGC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x14BB720", Offset = "0x14BAB20", VA = "0x1814BB720")]
	public static int GOLEKAHFLPB(ref byte[] DGPBECDNOKK, int BPNKPMGDGFM, ulong FPLJCBGEJAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x14BC090", Offset = "0x14BB490", VA = "0x1814BC090")]
	public static int KEIHPMBDCIC(ref byte[] DGPBECDNOKK, int BPNKPMGDGFM, long FPLJCBGEJAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x14BCDA0", Offset = "0x14BC1A0", VA = "0x1814BCDA0")]
	public static bool NJAELPCDHHC(byte[] GJDBLJLIDDI, int BPNKPMGDGFM, out int HOFJBGAALGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class EADIJIPDGIJ
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class AJICEKBDLIN : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
		[DebuggerHidden]
		public AJICEKBDLIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x180F780", Offset = "0x180EB80", VA = "0x18180F780", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x180F320", Offset = "0x180E720", VA = "0x18180F320", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x180F870", Offset = "0x180EC70", VA = "0x18180F870")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x180F8C0", Offset = "0x180ECC0", VA = "0x18180F8C0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x180F740", Offset = "0x180EB40", VA = "0x18180F740", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x180F690", Offset = "0x180EA90", VA = "0x18180F690", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x180F690", Offset = "0x180EA90", VA = "0x18180F690", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class JDDAAKMJACE : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7A4530", Offset = "0x7A3930", VA = "0x1807A4530")]
		[DebuggerHidden]
		public JDDAAKMJACE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1817790", Offset = "0x1816B90", VA = "0x181817790", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1817330", Offset = "0x1816730", VA = "0x181817330", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1817880", Offset = "0x1816C80", VA = "0x181817880")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x18178D0", Offset = "0x1816CD0", VA = "0x1818178D0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1817750", Offset = "0x1816B50", VA = "0x181817750", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x18176A0", Offset = "0x1816AA0", VA = "0x1818176A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x18176A0", Offset = "0x1816AA0", VA = "0x1818176A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x14BD310", Offset = "0x14BC710", VA = "0x1814BD310")]
	public static bool IKODCCGPHPL(this TypeInfo BKGBGEHNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x14BD090", Offset = "0x14BC490", VA = "0x1814BD090")]
	public static bool CACPFFNLIJJ(this TypeInfo BKGBGEHNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x14BD460", Offset = "0x14BC860", VA = "0x1814BD460")]
	public static IEnumerable<PropertyInfo> NIPHCIBMLFO(this Type BKGBGEHNCAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x14BD3D0", Offset = "0x14BC7D0", VA = "0x1814BD3D0")]
	[IteratorStateMachine(typeof(AJICEKBDLIN))]
	private static IEnumerable<PropertyInfo> JAHNJMAHMBO(Type BKGBGEHNCAE, HashSet<string> AJGDOLPDLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x14BD240", Offset = "0x14BC640", VA = "0x1814BD240")]
	public static IEnumerable<FieldInfo> EOCCCGDNEPK(this Type BKGBGEHNCAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x14BD1B0", Offset = "0x14BC5B0", VA = "0x1814BD1B0")]
	[IteratorStateMachine(typeof(JDDAAKMJACE))]
	private static IEnumerable<FieldInfo> DDHBEHOLNHB(Type BKGBGEHNCAE, HashSet<string> AJGDOLPDLBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal static class LHCLFFDGCLD
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding BHLFDAGIOLK;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class IGIMLKBPHMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0")]
	public static string GOJPKCABMFH(string BIKOMANFOPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0xBD2C00", Offset = "0xBD2000", VA = "0x180BD2C00")]
	public static string NAONHIIDJPC(string BIKOMANFOPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0xBD2D10", Offset = "0xBD2110", VA = "0x180BD2D10")]
	public static string PKMAJGLOFFD(string BIKOMANFOPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class HOAJMPMNBDM<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class HNOGPFJBFCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type BBKANMJFKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue EJBPMDLBLGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int BBJPFOEGJGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public HNOGPFJBFCI DPHLGAHHPHJ;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x41A0C60", Offset = "0x41A0060", VA = "0x1841A0C60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x41A0C20", Offset = "0x41A0020", VA = "0x1841A0C20")]
		private int HMGCLIBMMBB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public HNOGPFJBFCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class EJOEDNPPFKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public EJOEDNPPFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2A0", Offset = "0x7ED6A0", VA = "0x1807EE2A0")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private HNOGPFJBFCI[] CHHIFKCOGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int OLGJFEONMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object ELPNLFDLKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float BFNFLCNGECA;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x41A23D0", Offset = "0x41A17D0", VA = "0x1841A23D0")]
	public HOAJMPMNBDM(int NANBMPFBPOK = 4, float BFNFLCNGECA = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x41A2040", Offset = "0x41A1440", VA = "0x1841A2040")]
	public bool PPNDICAMACE(Type NPBDKCONLNC, TValue FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x41A22A0", Offset = "0x41A16A0", VA = "0x1841A22A0")]
	public bool PPNDICAMACE(Type NPBDKCONLNC, Func<Type, TValue> JEINBKJJFID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x41A0F20", Offset = "0x41A0320", VA = "0x1841A0F20")]
	private bool BBHNGEOFANJ(Type NPBDKCONLNC, Func<Type, TValue> JEINBKJJFID, out TValue PFFGFMDBEHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x41A1640", Offset = "0x41A0A40", VA = "0x1841A1640")]
	private bool GCDPLDFOAOE(HNOGPFJBFCI[] CHHIFKCOGEN, Type KDIELPDBDOH, HNOGPFJBFCI ECACLMDDNBF, Func<Type, TValue> JEINBKJJFID, out TValue PFFGFMDBEHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x41A1DA0", Offset = "0x41A11A0", VA = "0x1841A1DA0")]
	public bool MPHIBFICBKB(Type NPBDKCONLNC, out TValue FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x41A14F0", Offset = "0x41A08F0", VA = "0x1841A14F0")]
	public TValue DEHBMNIIEEG(Type NPBDKCONLNC, Func<Type, TValue> JEINBKJJFID)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x3D8B500", Offset = "0x3D8A900", VA = "0x183D8B500")]
	private static int KDDMDPNDFDP(int NIKEJOEBHBI, float BFNFLCNGECA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x41A14C0", Offset = "0x41A08C0", VA = "0x1841A14C0")]
	private static void BLCGBJEGDCC(ref HNOGPFJBFCI IBPLPONFJOL, HNOGPFJBFCI FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x41A14C0", Offset = "0x41A08C0", VA = "0x1841A14C0")]
	private static void BLCGBJEGDCC(ref HNOGPFJBFCI[] IBPLPONFJOL, HNOGPFJBFCI[] FPLJCBGEJAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class KGLEEGENLLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder IHGGJEBFMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder NJAJMHDAIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object HKEBFOKPDII;

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0xBDC390", Offset = "0xBDB790", VA = "0x180BDC390")]
	public TypeBuilder BFKOBHLDMIE(string LBEPPIIBMPA, TypeAttributes KDDDENOJJDK, Type CNDFBGEJOLI, Type[] FKDJHKAFDIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0xBDC460", Offset = "0xBDB860", VA = "0x180BDC460")]
	public KGLEEGENLLO(string GELFBNAAHCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal static class NMGAABNCNFO
{
	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0xBE6530", Offset = "0xBE5930", VA = "0x180BE6530")]
	private static MethodInfo LALHMEFEHPG(LambdaExpression NLEJOABDEJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x320CC50", Offset = "0x320C050", VA = "0x18320CC50")]
	public static MethodInfo IMNDNALLNMB<T>(Expression<Func<T>> NLEJOABDEJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x320CC50", Offset = "0x320C050", VA = "0x18320CC50")]
	public static MethodInfo IMNDNALLNMB<T, TR>(Expression<Func<T, TR>> NLEJOABDEJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x320CC50", Offset = "0x320C050", VA = "0x18320CC50")]
	public static MethodInfo IMNDNALLNMB<T>(Expression<Action<T>> NLEJOABDEJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x320CC50", Offset = "0x320C050", VA = "0x18320CC50")]
	public static MethodInfo IMNDNALLNMB<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> NLEJOABDEJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x320CC60", Offset = "0x320C060", VA = "0x18320CC60")]
	private static MemberInfo NHKKHEPMMFM<T>(Expression<T> HNJNABPJHCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x320CBF0", Offset = "0x320BFF0", VA = "0x18320CBF0")]
	public static PropertyInfo CLBOMEGGDGJ<T, TR>(Expression<Func<T, TR>> NLEJOABDEJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct KALJKAHGEJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int MDFMPEMHONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool DGBNJNDKHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator OAKLIGPKAHD;

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0xBD8AC0", Offset = "0xBD7EC0", VA = "0x180BD8AC0")]
	public KALJKAHGEJB(ILGenerator OAKLIGPKAHD, int MDFMPEMHONH, bool DGBNJNDKHLP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0xBD8B00", Offset = "0xBD7F00", VA = "0x180BD8B00")]
	public KALJKAHGEJB(ILGenerator OAKLIGPKAHD, int MDFMPEMHONH, Type BKGBGEHNCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xBD8AA0", Offset = "0xBD7EA0", VA = "0x180BD8AA0")]
	public void KPPGPLHALDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class FAKEDPOMKDJ
{
	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x14BF330", Offset = "0x14BE730", VA = "0x1814BF330")]
	public static void PNCMEFDBNMN(this ILGenerator OAKLIGPKAHD, int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x14BF560", Offset = "0x14BE960", VA = "0x1814BF560")]
	public static void PNCMEFDBNMN(this ILGenerator OAKLIGPKAHD, LocalBuilder OLGFKBFILHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x14BED00", Offset = "0x14BE100", VA = "0x1814BED00")]
	public static void LAHDEHOJPFA(this ILGenerator OAKLIGPKAHD, int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x14BEF30", Offset = "0x14BE330", VA = "0x1814BEF30")]
	public static void LAHDEHOJPFA(this ILGenerator OAKLIGPKAHD, LocalBuilder OLGFKBFILHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x14BF080", Offset = "0x14BE480", VA = "0x1814BF080")]
	public static void LFFPLJBKAKE(this ILGenerator OAKLIGPKAHD, int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x14BEF70", Offset = "0x14BE370", VA = "0x1814BEF70")]
	public static void LFFPLJBKAKE(this ILGenerator OAKLIGPKAHD, LocalBuilder OLGFKBFILHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x14BF290", Offset = "0x14BE690", VA = "0x1814BF290")]
	public static void OHJBPEPCAOD(this ILGenerator OAKLIGPKAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x14BF1F0", Offset = "0x14BE5F0", VA = "0x1814BF1F0")]
	public static void MIKJEPGPLJM(this ILGenerator OAKLIGPKAHD, bool FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x14BE3F0", Offset = "0x14BD7F0", VA = "0x1814BE3F0")]
	public static void BFFNPLFFDHF(this ILGenerator OAKLIGPKAHD, int FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x14BE840", Offset = "0x14BDC40", VA = "0x1814BE840")]
	public static void CGEDEPGKHIG(this ILGenerator OAKLIGPKAHD, Type BKGBGEHNCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x14BEC50", Offset = "0x14BE050", VA = "0x1814BEC50")]
	public static void KMAGBJICBGN(this ILGenerator OAKLIGPKAHD, Type BKGBGEHNCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x14BEA20", Offset = "0x14BDE20", VA = "0x1814BEA20")]
	public static void JKEIBIDNAMO(this ILGenerator OAKLIGPKAHD, int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x14BF170", Offset = "0x14BE570", VA = "0x1814BF170")]
	public static void MIHMGMFJBDL(this ILGenerator OAKLIGPKAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x14BE930", Offset = "0x14BDD30", VA = "0x1814BE930")]
	public static void JIEOIIHNPEJ(this ILGenerator OAKLIGPKAHD, int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x14BE2F0", Offset = "0x14BD6F0", VA = "0x1814BE2F0")]
	public static void AGKPGAOLDLO(this ILGenerator OAKLIGPKAHD, MethodInfo MOJEAALGNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x14BF200", Offset = "0x14BE600", VA = "0x1814BF200")]
	public static void OHFEPNEJECL(this ILGenerator OAKLIGPKAHD, FieldInfo OEIKAEAEGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x14BF2A0", Offset = "0x14BE6A0", VA = "0x1814BF2A0")]
	public static void OPCAFAOHJCE(this ILGenerator OAKLIGPKAHD, ulong FPLJCBGEJAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class GHJICNHNAMA
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class JBNBGKABJAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JBNBGKABJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1816ED0", Offset = "0x18162D0", VA = "0x181816ED0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo GKFEFMPBODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo EFLAHBFDKJC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string LJDFOHKOPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x773890", Offset = "0x772C90", VA = "0x180773890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string OOIFLNCMDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x77DF40", Offset = "0x77D340", VA = "0x18077DF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool NICGLPPKKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x14C1570", Offset = "0x14C0970", VA = "0x1814C1570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CJGOFFOGAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x91B8C0", Offset = "0x91ACC0", VA = "0x18091B8C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xAACD20", Offset = "0xAAC120", VA = "0x180AACD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool GFFEHGBMAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x91B8D0", Offset = "0x91ACD0", VA = "0x18091B8D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xB05B20", Offset = "0xB04F20", VA = "0x180B05B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type NKDMIECPEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x963B10", Offset = "0x962F10", VA = "0x180963B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo BENELAJHKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x81B670", Offset = "0x81AA70", VA = "0x18081B670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo DECEOLBMIOC
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6C72D0", Offset = "0x6C66D0", VA = "0x1806C72D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7776A0", Offset = "0x776AA0", VA = "0x1807776A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo INNLBMHFHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6D2590", Offset = "0x6D1990", VA = "0x1806D2590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x782E50", Offset = "0x782250", VA = "0x180782E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x14C17B0", Offset = "0x14C0BB0", VA = "0x1814C17B0")]
	protected GHJICNHNAMA(Type BKGBGEHNCAE, string LBEPPIIBMPA, string FNONJLMLJIE, bool GCPPEFLLLLB, bool AGDOMFDMPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x14C1830", Offset = "0x14C0C30", VA = "0x1814C1830")]
	public GHJICNHNAMA(FieldInfo NOENCABPBHG, string LBEPPIIBMPA, bool GNEECIPIAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x14C1940", Offset = "0x14C0D40", VA = "0x1814C1940")]
	public GHJICNHNAMA(PropertyInfo NOENCABPBHG, string LBEPPIIBMPA, bool GNEECIPIAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x14C1640", Offset = "0x14C0A40", VA = "0x1814C1640")]
	private static MethodInfo PDFKOAAOGDL(MemberInfo NOENCABPBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x2DB97D0", Offset = "0x2DB8BD0", VA = "0x182DB97D0")]
	public T KEMAEBCEPOL<T>(bool ENDPADHMDAN) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x14C14B0", Offset = "0x14C08B0", VA = "0x1814C14B0", Slot = "4")]
	public virtual void EGMMJEIBCBL(ILGenerator OAKLIGPKAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x14C1580", Offset = "0x14C0980", VA = "0x1814C1580", Slot = "5")]
	public virtual void LPJFGEIOJDE(ILGenerator OAKLIGPKAHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class EDMIEBFOIMA : GHJICNHNAMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string PDCPNGFMGKN;

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x14BDAE0", Offset = "0x14BCEE0", VA = "0x1814BDAE0")]
	public EDMIEBFOIMA(string LBEPPIIBMPA, string PDCPNGFMGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x14BD9E0", Offset = "0x14BCDE0", VA = "0x1814BD9E0", Slot = "4")]
	public override void EGMMJEIBCBL(ILGenerator OAKLIGPKAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x14BDAA0", Offset = "0x14BCEA0", VA = "0x1814BDAA0", Slot = "5")]
	public override void LPJFGEIOJDE(ILGenerator OAKLIGPKAHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class JMJCOGGFHMG : GHJICNHNAMA
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo HJEINHEIHPM;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo KECCNFFKNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal KALJKAHGEJB LEOJPGLDMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal KALJKAHGEJB DOAHMAJOGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal KALJKAHGEJB CBDJGKENDMJ;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0xBD8840", Offset = "0xBD7C40", VA = "0x180BD8840")]
	public JMJCOGGFHMG(string LBEPPIIBMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0xBD81E0", Offset = "0xBD75E0", VA = "0x180BD81E0", Slot = "4")]
	public override void EGMMJEIBCBL(ILGenerator OAKLIGPKAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0xBD82B0", Offset = "0xBD76B0", VA = "0x180BD82B0", Slot = "5")]
	public override void LPJFGEIOJDE(ILGenerator OAKLIGPKAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0xBD8090", Offset = "0xBD7490", VA = "0x180BD8090")]
	public void DNANIIGJALA(ILGenerator OAKLIGPKAHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class HKLEBEKANAN
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type NKDMIECPEPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x773890", Offset = "0x772C90", VA = "0x180773890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GFHFBHMMCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x85F6B0", Offset = "0x85EAB0", VA = "0x18085F6B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x85F6C0", Offset = "0x85EAC0", VA = "0x18085F6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool NNNHKGDDDLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xABCD00", Offset = "0xABC100", VA = "0x180ABCD00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xABCD10", Offset = "0xABC110", VA = "0x180ABCD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo LKHPCKHCLFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x762090", VA = "0x180762C90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public GHJICNHNAMA[] DPCIBGDCJGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x963B10", Offset = "0x962F10", VA = "0x180963B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public GHJICNHNAMA[] CDNGBGJEGGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x81B670", Offset = "0x81AA70", VA = "0x18081B670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x14C28B0", Offset = "0x14C1CB0", VA = "0x1814C28B0")]
	public HKLEBEKANAN(Type BKGBGEHNCAE, Func<string, string> DBLPMJNGFCA, bool GNEECIPIAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x14C27C0", Offset = "0x14C1BC0", VA = "0x1814C27C0")]
	private static bool HFFCMPMIPGM(IEnumerator<ConstructorInfo> AJKNKOAJKNJ, ref ConstructorInfo OCMDCKNCPEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct AACLDDFJDED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong POMOGMGJPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int EPPMCIFCHBF;

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x14B04B0", Offset = "0x14AF8B0", VA = "0x1814B04B0")]
	public AACLDDFJDED(ulong CDJLADOIIKD, int OIEJCPFBPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x14B02D0", Offset = "0x14AF6D0", VA = "0x1814B02D0")]
	public void DMALMFCDAGA(ref AACLDDFJDED FJLHJLAMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x14B0380", Offset = "0x14AF780", VA = "0x1814B0380")]
	public static AACLDDFJDED HLOGCIICJJN(ref AACLDDFJDED KEPOHMNFLGL, ref AACLDDFJDED CFEKEMJOJGA)
	{
		return default(AACLDDFJDED);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x14B0420", Offset = "0x14AF820", VA = "0x1814B0420")]
	public void OCLECMGIPDI(ref AACLDDFJDED FJLHJLAMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x14B02E0", Offset = "0x14AF6E0", VA = "0x1814B02E0")]
	public static AACLDDFJDED EBJAGHBHKLN(ref AACLDDFJDED KEPOHMNFLGL, ref AACLDDFJDED CFEKEMJOJGA)
	{
		return default(AACLDDFJDED);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x14B0390", Offset = "0x14AF790", VA = "0x1814B0390")]
	public void IFOGOMLBOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x14B03D0", Offset = "0x14AF7D0", VA = "0x1814B03D0")]
	public static AACLDDFJDED IFOGOMLBOFF(ref AACLDDFJDED KEPOHMNFLGL)
	{
		return default(AACLDDFJDED);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct BOECPGGNFLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] DGPBECDNOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int BPNKPMGDGFM;

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8A79B0", Offset = "0x8A6DB0", VA = "0x1808A79B0")]
	public BOECPGGNFLP(byte[] DGPBECDNOKK, int KGJPEGOHADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0xBE7640", Offset = "0xBE6A40", VA = "0x180BE7640")]
	public void MHCKPDILKHK(byte IEMIGHHOOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x14B47D0", Offset = "0x14B3BD0", VA = "0x1814B47D0")]
	public void HIHJPMBECDO(byte[] IEMIGHHOOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x14B4680", Offset = "0x14B3A80", VA = "0x1814B4680")]
	public void EJPDLDLCAFK(byte[] IEMIGHHOOAK, int DMFMCPNNNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x14B4720", Offset = "0x14B3B20", VA = "0x1814B4720")]
	public void EJPDLDLCAFK(byte[] IEMIGHHOOAK, int GJOFJPHNEOA, int DMFMCPNNNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x14B4600", Offset = "0x14B3A00", VA = "0x1814B4600")]
	public void AFCMOIJEGIK(byte JJJCLNDDKAD, int NDNADCNCIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x14B4870", Offset = "0x14B3C70", VA = "0x1814B4870")]
	public void IOMEAMMLHOO(string IEMIGHHOOAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class MEAJDAMHBHN
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private enum IJEFMHHBJDM
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum HBBPCPCGAIH
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum GIKPLHGABLF
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	[ThreadStatic]
	private static byte[] OBGEMEPOCLC;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] NNFLALNALNL;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] FNPBLFMNPLI;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] LCLIEALNGPN;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly GIKPLHGABLF BJBDIIKFENK;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char OHBMPIOOOFJ;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int BLICOGNCCBI;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int CBHOMPOPKNG;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] MDALGAKLPCD;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0xBE0D10", Offset = "0xBE0110", VA = "0x180BE0D10")]
	private static byte[] OPBBGFEIEMI(int OLGJFEONMLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0xBE05F0", Offset = "0xBDF9F0", VA = "0x180BE05F0")]
	private static byte[] NAJCCKMGNLF(int OLGJFEONMLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0xBE10F0", Offset = "0xBE04F0", VA = "0x180BE10F0")]
	public static int PJNCOLJDLBF(ref byte[] DGPBECDNOKK, int BPNKPMGDGFM, float FPLJCBGEJAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0xBE0FD0", Offset = "0xBE03D0", VA = "0x180BE0FD0")]
	public static int PJNCOLJDLBF(ref byte[] DGPBECDNOKK, int BPNKPMGDGFM, double FPLJCBGEJAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0xBDFA00", Offset = "0xBDEE00", VA = "0x180BDFA00")]
	private static bool GEPFGMCBJLC(byte[] DGPBECDNOKK, int DMFMCPNNNLJ, ulong GHNMPDKABOA, ulong GGEPJPDOPAB, ulong HGDCANNJPGF, ulong AIICNKNHDLO, ulong KHAIOPMOFDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xBE06D0", Offset = "0xBDFAD0", VA = "0x180BE06D0")]
	private static void NOFKGAAALDF(uint PDBOAEOBBEL, int DLKJENNCBCJ, out uint HNPOGDCMGML, out int HAGLBCBPHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0xBE07F0", Offset = "0xBDFBF0", VA = "0x180BE07F0")]
	private static bool NOLONEEDMNH(AACLDDFJDED JNOGCFHEEJN, AACLDDFJDED MIIKBFLPBBF, AACLDDFJDED FKIGAIALKFA, byte[] DGPBECDNOKK, out int DMFMCPNNNLJ, out int BKJBAEPNPIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0xBDF4A0", Offset = "0xBDE8A0", VA = "0x180BDF4A0")]
	private static bool AADCEMNKNCL(double OLMDMLKDJGG, IJEFMHHBJDM CMBMANJMAFC, byte[] DGPBECDNOKK, out int DMFMCPNNNLJ, out int GELAPIOIKFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xBDF740", Offset = "0xBDEB40", VA = "0x180BDF740")]
	private static bool BEBBBAKDGKN(double OLMDMLKDJGG, IJEFMHHBJDM CMBMANJMAFC, byte[] DGPBECDNOKK, out int DMFMCPNNNLJ, out int FBILJJNHNAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xBE0160", Offset = "0xBDF560", VA = "0x180BE0160")]
	private static bool JGANFLPLMPO(double FPLJCBGEJAP, ref BOECPGGNFLP KLJJOJIOEDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xBDFB00", Offset = "0xBDEF00", VA = "0x180BDFB00")]
	private static bool ICOCLCNIHHJ(double FPLJCBGEJAP, ref BOECPGGNFLP KLJJOJIOEDA, HBBPCPCGAIH CMBMANJMAFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0xBE0DF0", Offset = "0xBE01F0", VA = "0x180BE0DF0")]
	private static void PCMPONBCPOJ(byte[] BILLECJCBKC, int DMFMCPNNNLJ, int FBILJJNHNAB, int LIDPLJAPIKA, ref BOECPGGNFLP KLJJOJIOEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0xBE02F0", Offset = "0xBDF6F0", VA = "0x180BE02F0")]
	private static void MAFPJMDAKJK(byte[] BILLECJCBKC, int DMFMCPNNNLJ, int OIEJCPFBPCF, ref BOECPGGNFLP KLJJOJIOEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0xBDF850", Offset = "0xBDEC50", VA = "0x180BDF850")]
	private static bool CIMDKBHKHKI(double OLMDMLKDJGG, HBBPCPCGAIH CMBMANJMAFC, int KBIMHIKHEGO, byte[] NMGKHFEMDHE, out bool KDECFFCJAAK, out int DMFMCPNNNLJ, out int MAPPOODMLLL)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal struct GJHCKBIDPDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double LNJIJCHAAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong IJPJKCLFBDF;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct KOIEJOKAOFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float POMOGMGJPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint GNOJNIFFBIN;
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct DEFEOCELBOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong NGKNLCMFCGF;

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x14BA0E0", Offset = "0x14B94E0", VA = "0x1814BA0E0")]
	public DEFEOCELBOL(double LNJIJCHAAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x14BA0F0", Offset = "0x14B94F0", VA = "0x1814BA0F0")]
	public DEFEOCELBOL(AACLDDFJDED LNJIJCHAAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x14BA060", Offset = "0x14B9460", VA = "0x1814BA060")]
	public AACLDDFJDED PDENDGOKKMB()
	{
		return default(AACLDDFJDED);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x14B9E80", Offset = "0x14B9280", VA = "0x1814B9E80")]
	public AACLDDFJDED OFDCCBJDCCD()
	{
		return default(AACLDDFJDED);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x780900", Offset = "0x77FD00", VA = "0x180780900")]
	public ulong BNCDPGEMKIA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x14B9B30", Offset = "0x14B8F30", VA = "0x1814B9B30")]
	public double DPHLDHFNDGJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x14B9D50", Offset = "0x14B9150", VA = "0x1814B9D50")]
	public double NDPMLADCOJB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x14B9BC0", Offset = "0x14B8FC0", VA = "0x1814B9BC0")]
	public int FBHKFFNGGJM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x14B9C00", Offset = "0x14B9000", VA = "0x1814B9C00")]
	public ulong GOLJDLMNGJD()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x14B9C40", Offset = "0x14B9040", VA = "0x1814B9C40")]
	public bool JAHPMJHLCIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x14B9CB0", Offset = "0x14B90B0", VA = "0x1814B9CB0")]
	public bool LGOAECNJCJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x14B9CD0", Offset = "0x14B90D0", VA = "0x1814B9CD0")]
	public bool MDMBMKDFKOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x14B9C80", Offset = "0x14B9080", VA = "0x1814B9C80")]
	public bool LBNLKCDECGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x14B9C60", Offset = "0x14B9060", VA = "0x1814B9C60")]
	public int JHIOENAKPFA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x14B9F10", Offset = "0x14B9310", VA = "0x1814B9F10")]
	public void OHHMNOBKKDF(out AACLDDFJDED AFIDFLGJBNE, out AACLDDFJDED PMLNBAILOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x14B9D00", Offset = "0x14B9100", VA = "0x1814B9D00")]
	public bool MGENEEJOLHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x14B9BF0", Offset = "0x14B8FF0", VA = "0x1814B9BF0")]
	public double FPLJCBGEJAP()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x14B9B10", Offset = "0x14B8F10", VA = "0x1814B9B10")]
	public static int BKAHMDBGKPA(int HDAJNMPBNIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x14B9C30", Offset = "0x14B9030", VA = "0x1814B9C30")]
	public static double IDFMOALBGEM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x14B9DE0", Offset = "0x14B91E0", VA = "0x1814B9DE0")]
	public static ulong NJGBMJFEKOJ(AACLDDFJDED LLNJBGKNHIN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct BKCIIFHNODG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint JEDJNADIKIJ;

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F90", Offset = "0x7C6390", VA = "0x1807C6F90")]
	public BKCIIFHNODG(float POMOGMGJPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x14B32E0", Offset = "0x14B26E0", VA = "0x1814B32E0")]
	public AACLDDFJDED PDENDGOKKMB()
	{
		return default(AACLDDFJDED);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8A60", VA = "0x1807B9660")]
	public uint OIOOLJHJMKB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x14B3120", Offset = "0x14B2520", VA = "0x1814B3120")]
	public int FBHKFFNGGJM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x14B3140", Offset = "0x14B2540", VA = "0x1814B3140")]
	public uint GOLJDLMNGJD()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x14B3160", Offset = "0x14B2560", VA = "0x1814B3160")]
	public bool JAHPMJHLCIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x14B31B0", Offset = "0x14B25B0", VA = "0x1814B31B0")]
	public void OHHMNOBKKDF(out AACLDDFJDED AFIDFLGJBNE, out AACLDDFJDED PMLNBAILOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x14B3170", Offset = "0x14B2570", VA = "0x1814B3170")]
	public bool MGENEEJOLHO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct ENJLNKCNDNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong CDJLADOIIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short LJLNDBAGPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short GELAPIOIKFD;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x14BE2E0", Offset = "0x14BD6E0", VA = "0x1814BE2E0")]
	public ENJLNKCNDNG(ulong CDJLADOIIKD, short LJLNDBAGPEK, short GELAPIOIKFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal static class AABPANFELFF
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly ENJLNKCNDNG[] GJFAPACBDCM;

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x14AECF0", Offset = "0x14AE0F0", VA = "0x1814AECF0")]
	public static void GODPGCNDFGO(int MDGOKEPHHLE, int GCALKEHDPKG, out AACLDDFJDED HNPOGDCMGML, out int GELAPIOIKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x14AEC00", Offset = "0x14AE000", VA = "0x1814AEC00")]
	public static void BCNJMBHGGNE(int JDIDKHFODDN, out AACLDDFJDED HNPOGDCMGML, out int FFFJMHCJAPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[DefaultMember("Item")]
internal struct IEMHMMEBCHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] GJDBLJLIDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int GJOFJPHNEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int LAEKHLAODBN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xBD2B60", Offset = "0xBD1F60", VA = "0x180BD2B60")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0xB8BF10", Offset = "0xB8B310", VA = "0x180B8BF10")]
	public IEMHMMEBCHC(byte[] GJDBLJLIDDI, int GJOFJPHNEOA, int DMFMCPNNNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x7EE2C0", Offset = "0x7ED6C0", VA = "0x1807EE2C0")]
	public int DMFMCPNNNLJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0xBD2BA0", Offset = "0xBD1FA0", VA = "0x180BD2BA0")]
	public IEMHMMEBCHC INFMIIGHHIF(int EAGKIPIDCMM, int MKNAKGGPFHI)
	{
		return default(IEMHMMEBCHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal static class BOHHHMPHHLD
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] ACEBAADADGA;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] ICOFBBCBOJI;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int KEIAAHJMNPC;

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x14B4ED0", Offset = "0x14B42D0", VA = "0x1814B4ED0")]
	private static byte[] JPPEHIFIIAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x14B4A30", Offset = "0x14B3E30", VA = "0x1814B4A30")]
	private static IEMHMMEBCHC EJBFJLIFHLH(IEMHMMEBCHC DGPBECDNOKK)
	{
		return default(IEMHMMEBCHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x14B5800", Offset = "0x14B4C00", VA = "0x1814B5800")]
	private static IEMHMMEBCHC MGCMBKIOKEE(IEMHMMEBCHC DGPBECDNOKK)
	{
		return default(IEMHMMEBCHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x14B4970", Offset = "0x14B3D70", VA = "0x1814B4970")]
	private static void AHBCOHLHPAC(IEMHMMEBCHC DGPBECDNOKK, int OIEJCPFBPCF, byte[] FNBAJBHNAJB, out int DGEDMPDAOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x14B4FC0", Offset = "0x14B43C0", VA = "0x1814B4FC0")]
	private static void LFFDBICIPBA(IEMHMMEBCHC DGPBECDNOKK, int OIEJCPFBPCF, byte[] HOEDANJFOJF, int FONPOAIBOEF, out IEMHMMEBCHC JOIKPBMHKGK, out int CPLCBBAKCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x14B58B0", Offset = "0x14B4CB0", VA = "0x1814B58B0")]
	private static ulong NNPFOLPCCFO(IEMHMMEBCHC DGPBECDNOKK, out int HKIFLAJBKBG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x14B56D0", Offset = "0x14B4AD0", VA = "0x1814B56D0")]
	private static void MACLCEGDNBI(IEMHMMEBCHC DGPBECDNOKK, out AACLDDFJDED CGKNIAMFPAO, out int LKDCBFJIDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x14B4AE0", Offset = "0x14B3EE0", VA = "0x1814B4AE0")]
	private static bool JGPPGFNDLCJ(IEMHMMEBCHC JOIKPBMHKGK, int OIEJCPFBPCF, out double CGKNIAMFPAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x14B5540", Offset = "0x14B4940", VA = "0x1814B5540")]
	private static AACLDDFJDED LPAONNLOOPB(int OIEJCPFBPCF)
	{
		return default(AACLDDFJDED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x14B5940", Offset = "0x14B4D40", VA = "0x1814B5940")]
	private static bool OFJNKHBKMKL(IEMHMMEBCHC DGPBECDNOKK, int OIEJCPFBPCF, out double CGKNIAMFPAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x14B6090", Offset = "0x14B5490", VA = "0x1814B6090")]
	private static bool PNKDDMCBGMB(IEMHMMEBCHC JOIKPBMHKGK, int OIEJCPFBPCF, out double BEAAJLGOBEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x14B5F70", Offset = "0x14B5370", VA = "0x1814B5F70")]
	public static double? PMFONADOMKA(IEMHMMEBCHC DGPBECDNOKK, int OIEJCPFBPCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x14B5260", Offset = "0x14B4660", VA = "0x1814B5260")]
	public static float? LOLPGCDIPOA(IEMHMMEBCHC DGPBECDNOKK, int OIEJCPFBPCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct OPCBBNIFJJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] DGPBECDNOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int BPNKPMGDGFM;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte EJBPMDLBLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xBE8540", Offset = "0xBE7940", VA = "0x180BE8540")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8A79B0", Offset = "0x8A6DB0", VA = "0x1808A79B0")]
	public OPCBBNIFJJL(byte[] DGPBECDNOKK, int BPNKPMGDGFM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0xBE8810", Offset = "0xBE7C10", VA = "0x180BE8810")]
	public static OPCBBNIFJJL PGDHBJIGCIM(OPCBBNIFJJL COBPFFJEBON)
	{
		return default(OPCBBNIFJJL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0xBE8620", Offset = "0xBE7A20", VA = "0x180BE8620")]
	public static OPCBBNIFJJL FONHFAPECDI(OPCBBNIFJJL COBPFFJEBON, int DMFMCPNNNLJ)
	{
		return default(OPCBBNIFJJL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0xBE8710", Offset = "0xBE7B10", VA = "0x180BE8710")]
	public static int NPIIEEFEKIN(OPCBBNIFJJL BEOAJHMDOLI, OPCBBNIFJJL CEKIIBILJFE)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xBE8780", Offset = "0xBE7B80", VA = "0x180BE8780")]
	public static bool OACFLELFBPC(OPCBBNIFJJL BEOAJHMDOLI, OPCBBNIFJJL CEKIIBILJFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xBE87F0", Offset = "0xBE7BF0", VA = "0x180BE87F0")]
	public static bool OFLJMIEJHAG(OPCBBNIFJJL BEOAJHMDOLI, OPCBBNIFJJL CEKIIBILJFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0xBE8730", Offset = "0xBE7B30", VA = "0x180BE8730")]
	public static bool OACFLELFBPC(OPCBBNIFJJL BEOAJHMDOLI, char CEKIIBILJFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0xBE87A0", Offset = "0xBE7BA0", VA = "0x180BE87A0")]
	public static bool OFLJMIEJHAG(OPCBBNIFJJL BEOAJHMDOLI, char CEKIIBILJFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0xBE87A0", Offset = "0xBE7BA0", VA = "0x180BE87A0")]
	public static bool OFLJMIEJHAG(OPCBBNIFJJL BEOAJHMDOLI, byte CEKIIBILJFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0xBE85D0", Offset = "0xBE79D0", VA = "0x180BE85D0")]
	public static bool BHOALKCIJAM(OPCBBNIFJJL BEOAJHMDOLI, char CEKIIBILJFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0xBE86C0", Offset = "0xBE7AC0", VA = "0x180BE86C0")]
	public static bool NOPJKJNMBAL(OPCBBNIFJJL BEOAJHMDOLI, char CEKIIBILJFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0xBE8580", Offset = "0xBE7980", VA = "0x180BE8580")]
	public static bool AIOLEFNGDME(OPCBBNIFJJL BEOAJHMDOLI, char CEKIIBILJFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0xBE8670", Offset = "0xBE7A70", VA = "0x180BE8670")]
	public static bool LNJJCIHOAML(OPCBBNIFJJL BEOAJHMDOLI, char CEKIIBILJFE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class CCKGCHNJDNJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] EGBCLIFCOJH;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] PHCFPHDICFN;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] FNPBLFMNPLI;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] LCLIEALNGPN;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] HGEJFOCPCDC;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int HLOEICBOJKD;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] OBCMGGPMPPP;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int OJMKHOKJDGJ;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x14B6700", Offset = "0x14B5B00", VA = "0x1814B6700")]
	private static byte[] FKIGDBLEEFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x14B65F0", Offset = "0x14B59F0", VA = "0x1814B65F0")]
	private static byte[] BGPEGLEJGPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x14B6B90", Offset = "0x14B5F90", VA = "0x1814B6B90")]
	public static double NEGCFAEBJGL(byte[] DGPBECDNOKK, int BPNKPMGDGFM, out int HOFJBGAALGC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x14B6AD0", Offset = "0x14B5ED0", VA = "0x1814B6AD0")]
	public static float MFIGDOJNGDH(byte[] DGPBECDNOKK, int BPNKPMGDGFM, out int HOFJBGAALGC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x14B6840", Offset = "0x14B5C40", VA = "0x1814B6840")]
	private static bool HFMOOOPKIOC(int IMDGNLLHHDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x14B69C0", Offset = "0x14B5DC0", VA = "0x1814B69C0")]
	private static bool LMPBJINLBGJ(ref OPCBBNIFJJL OGHKGHLKPIH, OPCBBNIFJJL AFEDLJDCGDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x14B64E0", Offset = "0x14B58E0", VA = "0x1814B64E0")]
	private static bool AAEOHBKAAAC(ref OPCBBNIFJJL OGHKGHLKPIH, OPCBBNIFJJL AFEDLJDCGDB, byte[] HCGFCOIMAFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x14B67F0", Offset = "0x14B5BF0", VA = "0x1814B67F0")]
	private static bool HDGANDDKDAB(ref OPCBBNIFJJL INJJOEJKOHA, byte[] IEMIGHHOOAK, int BPNKPMGDGFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x14B66E0", Offset = "0x14B5AE0", VA = "0x1814B66E0")]
	private static double CINDNNMEFLD(bool KDECFFCJAAK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x14B6C40", Offset = "0x14B6040", VA = "0x1814B6C40")]
	private static double NHEFEBJLKGA(OPCBBNIFJJL LEPPMEPJHOI, int DMFMCPNNNLJ, bool LPBJMLEMJHN, out int IADPDJOAPGH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class MGOHGCHMGLN<T> : global::PDLGFBEOKBE<T[]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly global::EGOPAGKOPFJ<T> AGCMEBEEHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly EBDLNHAEHAP DKGLBLLOPFB;

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x3278120", Offset = "0x3277520", VA = "0x183278120")]
	public MGOHGCHMGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2A3E910", Offset = "0x2A3DD10", VA = "0x182A3E910")]
	public MGOHGCHMGLN(EBDLNHAEHAP DKGLBLLOPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x37FC790", Offset = "0x37FBB90", VA = "0x1837FC790", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, T[] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x37FB700", Offset = "0x37FAB00", VA = "0x1837FB700", Slot = "5")]
	public T[] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class MAKHEELDODD<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly global::EGOPAGKOPFJ<T> AGCMEBEEHAN;
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class JEKPMJBBEOM<T> : global::PDLGFBEOKBE<List<T>>, GKNPAAIBGAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly EBDLNHAEHAP DKGLBLLOPFB;

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3278120", Offset = "0x3277520", VA = "0x183278120")]
	public JEKPMJBBEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2A3E910", Offset = "0x2A3DD10", VA = "0x182A3E910")]
	public JEKPMJBBEOM(EBDLNHAEHAP DKGLBLLOPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3277000", Offset = "0x3276400", VA = "0x183277000", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, List<T> FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x32766C0", Offset = "0x3275AC0", VA = "0x1832766C0", Slot = "5")]
	public List<T> AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public abstract class GHMAOLJJHBL<TElement, TIntermediate, TEnumerator, TCollection> : global::PDLGFBEOKBE<TCollection>, GKNPAAIBGAM where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x339F380", Offset = "0x339E780", VA = "0x18339F380", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, TCollection FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x339DD50", Offset = "0x339D150", VA = "0x18339DD50", Slot = "5")]
	public TCollection AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator CHGOJNCNDJD(TCollection HNJNABPJHCC);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate PELCFOCODBC();

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void BKCAAEBNAMB(ref TIntermediate NBEDLAKOFBD, int GABJOMFFJAI, TElement FPLJCBGEJAP);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection ENDFAGEBOAN(ref TIntermediate EOJNOELGBGL);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
	protected GHMAOLJJHBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class CNNGEBIBIKM<TElement, TIntermediate, TCollection> : global::GHMAOLJJHBL<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x33C7E90", Offset = "0x33C7290", VA = "0x1833C7E90", Slot = "6")]
	protected override IEnumerator<TElement> CHGOJNCNDJD(TCollection HNJNABPJHCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3044320", Offset = "0x3043720", VA = "0x183044320")]
	protected CNNGEBIBIKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class GEFPEPEGALE<TElement, TCollection> : global::CNNGEBIBIKM<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x1B98870", Offset = "0x1B97C70", VA = "0x181B98870", Slot = "9")]
	protected sealed override TCollection ENDFAGEBOAN(ref TCollection EOJNOELGBGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class LBIHPKEDNOA<TElement, TCollection> : global::GEFPEPEGALE<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2E8D950", Offset = "0x2E8CD50", VA = "0x182E8D950", Slot = "7")]
	protected override TCollection PELCFOCODBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2E8D8E0", Offset = "0x2E8CCE0", VA = "0x182E8D8E0", Slot = "8")]
	protected override void BKCAAEBNAMB(ref TCollection NBEDLAKOFBD, int GABJOMFFJAI, TElement FPLJCBGEJAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class NHNKPNNFKOJ<T> : global::GHMAOLJJHBL<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x31CFB40", Offset = "0x31CEF40", VA = "0x1831CFB40", Slot = "8")]
	protected override void BKCAAEBNAMB(ref LinkedList<T> NBEDLAKOFBD, int GABJOMFFJAI, T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1B98870", Offset = "0x1B97C70", VA = "0x181B98870", Slot = "9")]
	protected override LinkedList<T> ENDFAGEBOAN(ref LinkedList<T> EOJNOELGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B800", Offset = "0x2E8AC00", VA = "0x182E8B800", Slot = "7")]
	protected override LinkedList<T> PELCFOCODBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x3347710", Offset = "0x3346B10", VA = "0x183347710", Slot = "6")]
	protected override LinkedList<T>.Enumerator CHGOJNCNDJD(LinkedList<T> HNJNABPJHCC)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class MDAKABMNOEO<T> : global::GHMAOLJJHBL<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x31CFB40", Offset = "0x31CEF40", VA = "0x1831CFB40", Slot = "8")]
	protected override void BKCAAEBNAMB(ref Queue<T> NBEDLAKOFBD, int GABJOMFFJAI, T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B800", Offset = "0x2E8AC00", VA = "0x182E8B800", Slot = "7")]
	protected override Queue<T> PELCFOCODBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x31CFB80", Offset = "0x31CEF80", VA = "0x1831CFB80", Slot = "6")]
	protected override Queue<T>.Enumerator CHGOJNCNDJD(Queue<T> HNJNABPJHCC)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x1B98870", Offset = "0x1B97C70", VA = "0x181B98870", Slot = "9")]
	protected override Queue<T> ENDFAGEBOAN(ref Queue<T> EOJNOELGBGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class GDNFIOOLOHJ<T> : global::GHMAOLJJHBL<T, global::FJPIKGFHOEB<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x3347630", Offset = "0x3346A30", VA = "0x183347630", Slot = "8")]
	protected override void BKCAAEBNAMB(ref global::FJPIKGFHOEB<T> NBEDLAKOFBD, int GABJOMFFJAI, T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x33476D0", Offset = "0x3346AD0", VA = "0x1833476D0", Slot = "7")]
	protected override global::FJPIKGFHOEB<T> PELCFOCODBC()
	{
		return default(global::FJPIKGFHOEB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x31CFB80", Offset = "0x31CEF80", VA = "0x1831CFB80", Slot = "6")]
	protected override Stack<T>.Enumerator CHGOJNCNDJD(Stack<T> HNJNABPJHCC)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x3393C30", Offset = "0x3393030", VA = "0x183393C30", Slot = "9")]
	protected override Stack<T> ENDFAGEBOAN(ref global::FJPIKGFHOEB<T> EOJNOELGBGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class BDEKEDCCBIH<T> : global::GHMAOLJJHBL<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x31CFB40", Offset = "0x31CEF40", VA = "0x1831CFB40", Slot = "8")]
	protected override void BKCAAEBNAMB(ref HashSet<T> NBEDLAKOFBD, int GABJOMFFJAI, T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x1B98870", Offset = "0x1B97C70", VA = "0x181B98870", Slot = "9")]
	protected override HashSet<T> ENDFAGEBOAN(ref HashSet<T> EOJNOELGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B800", Offset = "0x2E8AC00", VA = "0x182E8B800", Slot = "7")]
	protected override HashSet<T> PELCFOCODBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x31CFB80", Offset = "0x31CEF80", VA = "0x1831CFB80", Slot = "6")]
	protected override HashSet<T>.Enumerator CHGOJNCNDJD(HashSet<T> HNJNABPJHCC)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class GPFIEGKJDKH<T> : global::CNNGEBIBIKM<T, global::FJPIKGFHOEB<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x3347630", Offset = "0x3346A30", VA = "0x183347630", Slot = "8")]
	protected override void BKCAAEBNAMB(ref global::FJPIKGFHOEB<T> NBEDLAKOFBD, int GABJOMFFJAI, T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x33AE640", Offset = "0x33ADA40", VA = "0x1833AE640", Slot = "9")]
	protected override ReadOnlyCollection<T> ENDFAGEBOAN(ref global::FJPIKGFHOEB<T> EOJNOELGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x33AE6D0", Offset = "0x33ADAD0", VA = "0x1833AE6D0", Slot = "7")]
	protected override global::FJPIKGFHOEB<T> PELCFOCODBC()
	{
		return default(global::FJPIKGFHOEB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class AKEEGJADOCL<T> : global::CNNGEBIBIKM<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x31CFB40", Offset = "0x31CEF40", VA = "0x1831CFB40", Slot = "8")]
	protected override void BKCAAEBNAMB(ref List<T> NBEDLAKOFBD, int GABJOMFFJAI, T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B800", Offset = "0x2E8AC00", VA = "0x182E8B800", Slot = "7")]
	protected override List<T> PELCFOCODBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x1B98870", Offset = "0x1B97C70", VA = "0x181B98870", Slot = "9")]
	protected override IList<T> ENDFAGEBOAN(ref List<T> EOJNOELGBGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class KCOABGKJJFL<T> : global::CNNGEBIBIKM<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x31CFB40", Offset = "0x31CEF40", VA = "0x1831CFB40", Slot = "8")]
	protected override void BKCAAEBNAMB(ref List<T> NBEDLAKOFBD, int GABJOMFFJAI, T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B800", Offset = "0x2E8AC00", VA = "0x182E8B800", Slot = "7")]
	protected override List<T> PELCFOCODBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x1B98870", Offset = "0x1B97C70", VA = "0x181B98870", Slot = "9")]
	protected override ICollection<T> ENDFAGEBOAN(ref List<T> EOJNOELGBGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class LPGKPEBKPFB<T> : global::CNNGEBIBIKM<T, global::FJPIKGFHOEB<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x3347630", Offset = "0x3346A30", VA = "0x183347630", Slot = "8")]
	protected override void BKCAAEBNAMB(ref global::FJPIKGFHOEB<T> NBEDLAKOFBD, int GABJOMFFJAI, T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x33476D0", Offset = "0x3346AD0", VA = "0x1833476D0", Slot = "7")]
	protected override global::FJPIKGFHOEB<T> PELCFOCODBC()
	{
		return default(global::FJPIKGFHOEB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3BF6030", Offset = "0x3BF5430", VA = "0x183BF6030", Slot = "9")]
	protected override IEnumerable<T> ENDFAGEBOAN(ref global::FJPIKGFHOEB<T> EOJNOELGBGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class GLGHAICGBOO<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class JLFEFMKKHKI<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class LDLHLILENAA<T> : global::PDLGFBEOKBE<T>, GKNPAAIBGAM where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2E9B380", Offset = "0x2E9A780", VA = "0x182E9B380", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, T FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2E9B170", Offset = "0x2E9A570", VA = "0x182E9B170", Slot = "5")]
	public T AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
	public LDLHLILENAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class LBBPGHCFEMH : global::PDLGFBEOKBE<IEnumerable>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::PDLGFBEOKBE<IEnumerable> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0xBDEA90", Offset = "0xBDDE90", VA = "0x180BDEA90", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, IEnumerable FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0xBDE800", Offset = "0xBDDC00", VA = "0x180BDE800", Slot = "5")]
	public IEnumerable AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public LBBPGHCFEMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class POEKKOHNIIA : global::PDLGFBEOKBE<ICollection>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public static readonly global::PDLGFBEOKBE<ICollection> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0xBEC920", Offset = "0xBEBD20", VA = "0x180BEC920", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, ICollection FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0xBEC690", Offset = "0xBEBA90", VA = "0x180BEC690", Slot = "5")]
	public ICollection AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public POEKKOHNIIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class NBEPGDIIPMF : global::PDLGFBEOKBE<IList>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::PDLGFBEOKBE<IList> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0xBE4290", Offset = "0xBE3690", VA = "0x180BE4290", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, IList FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xBE4000", Offset = "0xBE3400", VA = "0x180BE4000", Slot = "5")]
	public IList AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public NBEPGDIIPMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class NHNCPANFFJB<T> : global::CNNGEBIBIKM<T, global::FJPIKGFHOEB<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x3347600", Offset = "0x3346A00", VA = "0x183347600", Slot = "8")]
	protected override void BKCAAEBNAMB(ref global::FJPIKGFHOEB<T> NBEDLAKOFBD, int GABJOMFFJAI, T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x33476D0", Offset = "0x3346AD0", VA = "0x1833476D0", Slot = "7")]
	protected override global::FJPIKGFHOEB<T> PELCFOCODBC()
	{
		return default(global::FJPIKGFHOEB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3347690", Offset = "0x3346A90", VA = "0x183347690", Slot = "9")]
	protected override IReadOnlyList<T> ENDFAGEBOAN(ref global::FJPIKGFHOEB<T> EOJNOELGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x31D6D20", Offset = "0x31D6120", VA = "0x1831D6D20")]
	public NHNCPANFFJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public static class MBCAGMDBIMN
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0xBDF200", Offset = "0xBDE600", VA = "0x180BDF200")]
	public static DateTime IIPHHINKHHG(DateTime CDNEBKOBPAD)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class HPIFDNLBFJD : global::PDLGFBEOKBE<DateTime>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly global::PDLGFBEOKBE<DateTime> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x14C4CF0", Offset = "0x14C40F0", VA = "0x1814C4CF0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, DateTime FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x14C3EA0", Offset = "0x14C32A0", VA = "0x1814C3EA0", Slot = "5")]
	public DateTime AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public HPIFDNLBFJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class NBCGLPCAFKJ : global::PDLGFBEOKBE<DateTimeOffset>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly global::PDLGFBEOKBE<DateTimeOffset> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xBE33E0", Offset = "0xBE27E0", VA = "0x180BE33E0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, DateTimeOffset FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0xBE24A0", Offset = "0xBE18A0", VA = "0x180BE24A0", Slot = "5")]
	public DateTimeOffset AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public NBCGLPCAFKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class CMMBDFHMFKD : global::PDLGFBEOKBE<TimeSpan>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly global::PDLGFBEOKBE<TimeSpan> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static byte[] ILJCHHDFPMM;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x14B8F50", Offset = "0x14B8350", VA = "0x1814B8F50", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, TimeSpan FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x14B8690", Offset = "0x14B7A90", VA = "0x1814B8690", Slot = "5")]
	public TimeSpan AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public CMMBDFHMFKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public abstract class OGPLINHNJCH<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::PDLGFBEOKBE<TDictionary>, GKNPAAIBGAM where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2CC26A0", Offset = "0x2CC1AA0", VA = "0x182CC26A0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, TDictionary FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2CBFC80", Offset = "0x2CBF080", VA = "0x182CBFC80", Slot = "5")]
	public TDictionary AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator CHGOJNCNDJD(TDictionary HNJNABPJHCC);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate PELCFOCODBC();

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void BKCAAEBNAMB(ref TIntermediate NBEDLAKOFBD, int GABJOMFFJAI, TKey NPBDKCONLNC, TValue FPLJCBGEJAP);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary ENDFAGEBOAN(ref TIntermediate EOJNOELGBGL);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
	protected OGPLINHNJCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public abstract class INJGAJKDCAE<TKey, TValue, TIntermediate, TDictionary> : global::OGPLINHNJCH<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x33C7E90", Offset = "0x33C7290", VA = "0x1833C7E90", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> CHGOJNCNDJD(TDictionary HNJNABPJHCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public abstract class KACAJDIPHDD<TKey, TValue, TDictionary> : global::INJGAJKDCAE<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x1B98870", Offset = "0x1B97C70", VA = "0x181B98870", Slot = "9")]
	protected override TDictionary ENDFAGEBOAN(ref TDictionary EOJNOELGBGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class DJGICBIPMCI<TKey, TValue> : global::OGPLINHNJCH<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x36F2920", Offset = "0x36F1D20", VA = "0x1836F2920", Slot = "8")]
	protected override void BKCAAEBNAMB(ref Dictionary<TKey, TValue> NBEDLAKOFBD, int GABJOMFFJAI, TKey NPBDKCONLNC, TValue FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x1B98870", Offset = "0x1B97C70", VA = "0x181B98870", Slot = "9")]
	protected override Dictionary<TKey, TValue> ENDFAGEBOAN(ref Dictionary<TKey, TValue> EOJNOELGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B800", Offset = "0x2E8AC00", VA = "0x182E8B800", Slot = "7")]
	protected override Dictionary<TKey, TValue> PELCFOCODBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x36F2960", Offset = "0x36F1D60", VA = "0x1836F2960", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator CHGOJNCNDJD(Dictionary<TKey, TValue> HNJNABPJHCC)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2525000", Offset = "0x2524400", VA = "0x182525000")]
	public DJGICBIPMCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public sealed class HPOFKBPHGKJ<TKey, TValue, TDictionary> : global::KACAJDIPHDD<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x41AD380", Offset = "0x41AC780", VA = "0x1841AD380", Slot = "8")]
	protected override void BKCAAEBNAMB(ref TDictionary NBEDLAKOFBD, int GABJOMFFJAI, TKey NPBDKCONLNC, TValue FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2A44790", Offset = "0x2A43B90", VA = "0x182A44790", Slot = "7")]
	protected override TDictionary PELCFOCODBC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public sealed class NCMAOGOMJJE<TKey, TValue> : global::INJGAJKDCAE<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B7C0", Offset = "0x2E8ABC0", VA = "0x182E8B7C0", Slot = "8")]
	protected override void BKCAAEBNAMB(ref Dictionary<TKey, TValue> NBEDLAKOFBD, int GABJOMFFJAI, TKey NPBDKCONLNC, TValue FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B800", Offset = "0x2E8AC00", VA = "0x182E8B800", Slot = "7")]
	protected override Dictionary<TKey, TValue> PELCFOCODBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x1B98870", Offset = "0x1B97C70", VA = "0x181B98870", Slot = "9")]
	protected override IDictionary<TKey, TValue> ENDFAGEBOAN(ref Dictionary<TKey, TValue> EOJNOELGBGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class LAHHNHBHEPM<TKey, TValue> : global::KACAJDIPHDD<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B7C0", Offset = "0x2E8ABC0", VA = "0x182E8B7C0", Slot = "8")]
	protected override void BKCAAEBNAMB(ref SortedList<TKey, TValue> NBEDLAKOFBD, int GABJOMFFJAI, TKey NPBDKCONLNC, TValue FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B800", Offset = "0x2E8AC00", VA = "0x182E8B800", Slot = "7")]
	protected override SortedList<TKey, TValue> PELCFOCODBC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class CPKPJOPHAIH<TKey, TValue> : global::OGPLINHNJCH<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B7C0", Offset = "0x2E8ABC0", VA = "0x182E8B7C0", Slot = "8")]
	protected override void BKCAAEBNAMB(ref SortedDictionary<TKey, TValue> NBEDLAKOFBD, int GABJOMFFJAI, TKey NPBDKCONLNC, TValue FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x1B98870", Offset = "0x1B97C70", VA = "0x181B98870", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> ENDFAGEBOAN(ref SortedDictionary<TKey, TValue> EOJNOELGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B800", Offset = "0x2E8AC00", VA = "0x182E8B800", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> PELCFOCODBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3D95C70", Offset = "0x3D95070", VA = "0x183D95C70", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator CHGOJNCNDJD(SortedDictionary<TKey, TValue> HNJNABPJHCC)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class HOCDNKOGNOE<T> : global::PDLGFBEOKBE<T>, GKNPAAIBGAM where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x41A26F0", Offset = "0x41A1AF0", VA = "0x1841A26F0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, T FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x41A24C0", Offset = "0x41A18C0", VA = "0x1841A24C0", Slot = "5")]
	public T AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
	public HOCDNKOGNOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class GDGOJANBKDK : global::PDLGFBEOKBE<IDictionary>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly global::PDLGFBEOKBE<IDictionary> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x14C0E50", Offset = "0x14C0250", VA = "0x1814C0E50", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, IDictionary FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x14C0C80", Offset = "0x14C0080", VA = "0x1814C0C80", Slot = "5")]
	public IDictionary AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public GDGOJANBKDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class NIBHPAAILED : global::PDLGFBEOKBE<object>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private delegate void HIGGCOGCILA(object NJMAGACCKLM, ref OCIPHIDCELE CDLKNDDFOPH, object FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly global::HOAJMPMNBDM<KeyValuePair<object, HIGGCOGCILA>> DJINGHENHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly BOIAJJMDENO[] CDKPLBGIFAH;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0xBE6060", Offset = "0xBE5460", VA = "0x180BE6060")]
	public NIBHPAAILED(params BOIAJJMDENO[] CDKPLBGIFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0xBE5600", Offset = "0xBE4A00", VA = "0x180BE5600", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, object FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0xBE5560", Offset = "0xBE4960", VA = "0x180BE5560", Slot = "5")]
	public object AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public static class IMKEMCDLIPO
{
	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0xBD3E00", Offset = "0xBD3200", VA = "0x180BD3E00")]
	public static object HJNIHECOAPL(Type BKGBGEHNCAE, out bool PGGKAJBIDPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0xBD34E0", Offset = "0xBD28E0", VA = "0x180BD34E0")]
	public static object CCGILJACLEJ(Type BKGBGEHNCAE, out bool PGGKAJBIDPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public class HLDDLKBLCEO<T> : global::PDLGFBEOKBE<T>, GKNPAAIBGAM, global::PBGPIEICANJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class IACEFEHFLIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public IACEFEHFLIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x4A6F9D0", Offset = "0x4A6EDD0", VA = "0x184A6F9D0")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class MNLHLDMKGAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public global::JGCGHJLCHBB<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public MNLHLDMKGAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x35F7A20", Offset = "0x35F6E20", VA = "0x1835F7A20")]
		internal void <.cctor>b__1(ref OCIPHIDCELE writer, T value, BOIAJJMDENO _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class OECNHLHCGMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public global::PEEKHHBOLAN<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public OECNHLHCGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA160", Offset = "0x2CB9560", VA = "0x182CBA160")]
		internal T <.cctor>b__2(ref PLOHLCGPGAB reader, BOIAJJMDENO _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly global::CNIAMNBBAFD<T> BKPPICDNOFP;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static readonly Dictionary<T, string> DPJGGEIOCCL;

	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private static readonly global::JGCGHJLCHBB<T> FDHBGCPLBFH;

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly global::PEEKHHBOLAN<T> GFHBOKHMAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly bool IHPGFHKAKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly global::JGCGHJLCHBB<T> ICAKLPGDDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::PEEKHHBOLAN<T> EMNOLCBCLDC;

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x39E0310", Offset = "0x39DF710", VA = "0x1839E0310")]
	static HLDDLKBLCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x39E2210", Offset = "0x39E1610", VA = "0x1839E2210")]
	public HLDDLKBLCEO(bool IHPGFHKAKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x39D8680", Offset = "0x39D7A80", VA = "0x1839D8680", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, T FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x39D5E90", Offset = "0x39D5290", VA = "0x1839D5E90", Slot = "5")]
	public T AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x39D8AB0", Offset = "0x39D7EB0", VA = "0x1839D8AB0", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, T FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x39D9120", Offset = "0x39D8520", VA = "0x1839D9120", Slot = "7")]
	public T PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class EBNFNCOPKCF<T> : global::PDLGFBEOKBE<T[,]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x3AD7AD0", Offset = "0x3AD6ED0", VA = "0x183AD7AD0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, T[,] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x3AD7800", Offset = "0x3AD6C00", VA = "0x183AD7800", Slot = "5")]
	public T[,] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
	public EBNFNCOPKCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class MLCILPHMCGO<T> : global::PDLGFBEOKBE<T[,,]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x35F13B0", Offset = "0x35F07B0", VA = "0x1835F13B0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, T[,,] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x35F0FD0", Offset = "0x35F03D0", VA = "0x1835F0FD0", Slot = "5")]
	public T[,,] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
	public MLCILPHMCGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class JBBFKFLCBFK<T> : global::PDLGFBEOKBE<T[,,,]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3F4AB20", Offset = "0x3F49F20", VA = "0x183F4AB20", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, T[,,,] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x3F4A620", Offset = "0x3F49A20", VA = "0x183F4A620", Slot = "5")]
	public T[,,,] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
	public JBBFKFLCBFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class PKJBILNFJCA<T> : global::PDLGFBEOKBE<T?>, GKNPAAIBGAM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3D5D530", Offset = "0x3D5C930", VA = "0x183D5D530", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, T? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x3D5D280", Offset = "0x3D5C680", VA = "0x183D5D280", Slot = "5")]
	public T? AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
	public PKJBILNFJCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class IKLOFFANGKA<T> : global::PDLGFBEOKBE<T?>, GKNPAAIBGAM where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private readonly global::PDLGFBEOKBE<T> GBBIDGNDNMP;

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x280B190", Offset = "0x280A590", VA = "0x18280B190")]
	public IKLOFFANGKA(global::PDLGFBEOKBE<T> GBBIDGNDNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x280B1D0", Offset = "0x280A5D0", VA = "0x18280B1D0")]
	public IKLOFFANGKA(Type CHHHBLOMODB, object[] KKHAMMMBCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x280AB90", Offset = "0x2809F90", VA = "0x18280AB90", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, T? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x280AA30", Offset = "0x2809E30", VA = "0x18280AA30", Slot = "5")]
	public T? AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class DBLIEPPDDEA : global::PDLGFBEOKBE<sbyte>, GKNPAAIBGAM, global::PBGPIEICANJ<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly DBLIEPPDDEA OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x14B9910", Offset = "0x14B8D10", VA = "0x1814B9910", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, sbyte FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x14B9900", Offset = "0x14B8D00", VA = "0x1814B9900", Slot = "5")]
	public sbyte AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x14B9930", Offset = "0x14B8D30", VA = "0x1814B9930", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, sbyte FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x14B9970", Offset = "0x14B8D70", VA = "0x1814B9970", Slot = "7")]
	public sbyte PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public DBLIEPPDDEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class EHLLMECFAKO : global::PDLGFBEOKBE<sbyte?>, GKNPAAIBGAM, global::PBGPIEICANJ<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly EHLLMECFAKO OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x14BE080", Offset = "0x14BD480", VA = "0x1814BE080", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, sbyte? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x14BE010", Offset = "0x14BD410", VA = "0x1814BE010", Slot = "5")]
	public sbyte? AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x14BE100", Offset = "0x14BD500", VA = "0x1814BE100", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, sbyte? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x14BE180", Offset = "0x14BD580", VA = "0x1814BE180", Slot = "7")]
	public sbyte? PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public EHLLMECFAKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class NILFEHJEDGL : global::PDLGFBEOKBE<sbyte[]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly NILFEHJEDGL OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0xBE6330", Offset = "0xBE5730", VA = "0x180BE6330", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, sbyte[] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0xBE6100", Offset = "0xBE5500", VA = "0x180BE6100", Slot = "5")]
	public sbyte[] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public NILFEHJEDGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class FDKJGDIAPEL : global::PDLGFBEOKBE<short>, GKNPAAIBGAM, global::PBGPIEICANJ<short>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly FDKJGDIAPEL OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x14BFAE0", Offset = "0x14BEEE0", VA = "0x1814BFAE0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, short FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x14BFAD0", Offset = "0x14BEED0", VA = "0x1814BFAD0", Slot = "5")]
	public short AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x14BFB00", Offset = "0x14BEF00", VA = "0x1814BFB00", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, short FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x14BFB40", Offset = "0x14BEF40", VA = "0x1814BFB40", Slot = "7")]
	public short PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public FDKJGDIAPEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class NEMAPKCBKMA : global::PDLGFBEOKBE<short?>, GKNPAAIBGAM, global::PBGPIEICANJ<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly NEMAPKCBKMA OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0xBE4B00", Offset = "0xBE3F00", VA = "0x180BE4B00", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, short? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0xBE4A50", Offset = "0xBE3E50", VA = "0x180BE4A50", Slot = "5")]
	public short? AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0xBE4B90", Offset = "0xBE3F90", VA = "0x180BE4B90", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, short? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0xBE4CA0", Offset = "0xBE40A0", VA = "0x180BE4CA0", Slot = "7")]
	public short? PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public NEMAPKCBKMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class JMGJLHJHFFN : global::PDLGFBEOKBE<short[]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly JMGJLHJHFFN OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0xBD7E90", Offset = "0xBD7290", VA = "0x180BD7E90", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, short[] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0xBD7C60", Offset = "0xBD7060", VA = "0x180BD7C60", Slot = "5")]
	public short[] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public JMGJLHJHFFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class ABCKBPAJKHL : global::PDLGFBEOKBE<int>, GKNPAAIBGAM, global::PBGPIEICANJ<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly ABCKBPAJKHL OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x14B0840", Offset = "0x14AFC40", VA = "0x1814B0840", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, int FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x14B0830", Offset = "0x14AFC30", VA = "0x1814B0830", Slot = "5")]
	public int AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x14B0850", Offset = "0x14AFC50", VA = "0x1814B0850", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, int FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x14B0890", Offset = "0x14AFC90", VA = "0x1814B0890", Slot = "7")]
	public int PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABCKBPAJKHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class KDJKBGGJHCH : global::PDLGFBEOKBE<int?>, GKNPAAIBGAM, global::PBGPIEICANJ<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly KDJKBGGJHCH OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0xBDA1C0", Offset = "0xBD95C0", VA = "0x180BDA1C0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, int? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0xBDA110", Offset = "0xBD9510", VA = "0x180BDA110", Slot = "5")]
	public int? AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0xBDA250", Offset = "0xBD9650", VA = "0x180BDA250", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, int? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0xBDA360", Offset = "0xBD9760", VA = "0x180BDA360", Slot = "7")]
	public int? PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public KDJKBGGJHCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class BHHFHDEKOOO : global::PDLGFBEOKBE<int[]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly BHHFHDEKOOO OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x14B2870", Offset = "0x14B1C70", VA = "0x1814B2870", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, int[] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x14B2730", Offset = "0x14B1B30", VA = "0x1814B2730", Slot = "5")]
	public int[] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public BHHFHDEKOOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class BENBKHOJBBA : global::PDLGFBEOKBE<long>, GKNPAAIBGAM, global::PBGPIEICANJ<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly BENBKHOJBBA OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x14B2590", Offset = "0x14B1990", VA = "0x1814B2590", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, long FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x14B2580", Offset = "0x14B1980", VA = "0x1814B2580", Slot = "5")]
	public long AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x14B25B0", Offset = "0x14B19B0", VA = "0x1814B25B0", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, long FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x14B25F0", Offset = "0x14B19F0", VA = "0x1814B25F0", Slot = "7")]
	public long PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public BENBKHOJBBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class GLKCLCDKIPN : global::PDLGFBEOKBE<long?>, GKNPAAIBGAM, global::PBGPIEICANJ<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly GLKCLCDKIPN OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x14C1BE0", Offset = "0x14C0FE0", VA = "0x1814C1BE0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, long? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x14C1B50", Offset = "0x14C0F50", VA = "0x1814C1B50", Slot = "5")]
	public long? AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x14C1C60", Offset = "0x14C1060", VA = "0x1814C1C60", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, long? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x14C1CF0", Offset = "0x14C10F0", VA = "0x1814C1CF0", Slot = "7")]
	public long? PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public GLKCLCDKIPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class DANLIKALIEL : global::PDLGFBEOKBE<long[]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly DANLIKALIEL OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x14B97E0", Offset = "0x14B8BE0", VA = "0x1814B97E0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, long[] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x14B96A0", Offset = "0x14B8AA0", VA = "0x1814B96A0", Slot = "5")]
	public long[] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public DANLIKALIEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class IHFDKCBDEDK : global::PDLGFBEOKBE<byte>, GKNPAAIBGAM, global::PBGPIEICANJ<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly IHFDKCBDEDK OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0xBD2F60", Offset = "0xBD2360", VA = "0x180BD2F60", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, byte FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0xBD2F00", Offset = "0xBD2300", VA = "0x180BD2F00", Slot = "5")]
	public byte AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0xBD2FA0", Offset = "0xBD23A0", VA = "0x180BD2FA0", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, byte FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0xBD3060", Offset = "0xBD2460", VA = "0x180BD3060", Slot = "7")]
	public byte PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public IHFDKCBDEDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class NHALMCONFHP : global::PDLGFBEOKBE<byte?>, GKNPAAIBGAM, global::PBGPIEICANJ<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly NHALMCONFHP OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xBE52A0", Offset = "0xBE46A0", VA = "0x180BE52A0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, byte? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0xBE51F0", Offset = "0xBE45F0", VA = "0x180BE51F0", Slot = "5")]
	public byte? AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0xBE5330", Offset = "0xBE4730", VA = "0x180BE5330", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, byte? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0xBE5440", Offset = "0xBE4840", VA = "0x180BE5440", Slot = "7")]
	public byte? PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public NHALMCONFHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class HIFFJGFGPLK : global::PDLGFBEOKBE<ushort>, GKNPAAIBGAM, global::PBGPIEICANJ<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly HIFFJGFGPLK OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x14C2650", Offset = "0x14C1A50", VA = "0x1814C2650", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, ushort FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x14C2640", Offset = "0x14C1A40", VA = "0x1814C2640", Slot = "5")]
	public ushort AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x14C2670", Offset = "0x14C1A70", VA = "0x1814C2670", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, ushort FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x14C26B0", Offset = "0x14C1AB0", VA = "0x1814C26B0", Slot = "7")]
	public ushort PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public HIFFJGFGPLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class DPJIEPMIBAF : global::PDLGFBEOKBE<ushort?>, GKNPAAIBGAM, global::PBGPIEICANJ<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly DPJIEPMIBAF OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x14BB100", Offset = "0x14BA500", VA = "0x1814BB100", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, ushort? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x14BB090", Offset = "0x14BA490", VA = "0x1814BB090", Slot = "5")]
	public ushort? AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x14BB180", Offset = "0x14BA580", VA = "0x1814BB180", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, ushort? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x14BB200", Offset = "0x14BA600", VA = "0x1814BB200", Slot = "7")]
	public ushort? PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public DPJIEPMIBAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class FMPBBCKLJJE : global::PDLGFBEOKBE<ushort[]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly FMPBBCKLJJE OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x14C0A80", Offset = "0x14BFE80", VA = "0x1814C0A80", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, ushort[] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x14C0940", Offset = "0x14BFD40", VA = "0x1814C0940", Slot = "5")]
	public ushort[] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public FMPBBCKLJJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class PFIJCAFJNLE : global::PDLGFBEOKBE<uint>, GKNPAAIBGAM, global::PBGPIEICANJ<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly PFIJCAFJNLE OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0xBE9010", Offset = "0xBE8410", VA = "0x180BE9010", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, uint FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0xBE8FB0", Offset = "0xBE83B0", VA = "0x180BE8FB0", Slot = "5")]
	public uint AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0xBE9040", Offset = "0xBE8440", VA = "0x180BE9040", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, uint FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0xBE9100", Offset = "0xBE8500", VA = "0x180BE9100", Slot = "7")]
	public uint PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public PFIJCAFJNLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class DJFIGMLBBEE : global::PDLGFBEOKBE<uint?>, GKNPAAIBGAM, global::PBGPIEICANJ<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly DJFIGMLBBEE OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x14BAD70", Offset = "0x14BA170", VA = "0x1814BAD70", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, uint? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x14BAD00", Offset = "0x14BA100", VA = "0x1814BAD00", Slot = "5")]
	public uint? AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x14BADE0", Offset = "0x14BA1E0", VA = "0x1814BADE0", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, uint? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x14BAE60", Offset = "0x14BA260", VA = "0x1814BAE60", Slot = "7")]
	public uint? PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public DJFIGMLBBEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class HBPBBHDAIJD : global::PDLGFBEOKBE<uint[]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly HBPBBHDAIJD OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x14C2520", Offset = "0x14C1920", VA = "0x1814C2520", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, uint[] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x14C23E0", Offset = "0x14C17E0", VA = "0x1814C23E0", Slot = "5")]
	public uint[] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public HBPBBHDAIJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class OHECIPGCJLJ : global::PDLGFBEOKBE<ulong>, GKNPAAIBGAM, global::PBGPIEICANJ<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly OHECIPGCJLJ OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0xBE7BB0", Offset = "0xBE6FB0", VA = "0x180BE7BB0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, ulong FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0xBE7BA0", Offset = "0xBE6FA0", VA = "0x180BE7BA0", Slot = "5")]
	public ulong AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0xBE7BE0", Offset = "0xBE6FE0", VA = "0x180BE7BE0", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, ulong FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0xBE7CA0", Offset = "0xBE70A0", VA = "0x180BE7CA0", Slot = "7")]
	public ulong PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public OHECIPGCJLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class IBPELOIAGII : global::PDLGFBEOKBE<ulong?>, GKNPAAIBGAM, global::PBGPIEICANJ<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly IBPELOIAGII OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x14C5240", Offset = "0x14C4640", VA = "0x1814C5240", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, ulong? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x14C51B0", Offset = "0x14C45B0", VA = "0x1814C51B0", Slot = "5")]
	public ulong? AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x14C52C0", Offset = "0x14C46C0", VA = "0x1814C52C0", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, ulong? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x14C5350", Offset = "0x14C4750", VA = "0x1814C5350", Slot = "7")]
	public ulong? PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public IBPELOIAGII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class CAGDIIIBIJL : global::PDLGFBEOKBE<ulong[]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly CAGDIIIBIJL OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x14B63C0", Offset = "0x14B57C0", VA = "0x1814B63C0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, ulong[] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x14B6280", Offset = "0x14B5680", VA = "0x1814B6280", Slot = "5")]
	public ulong[] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public CAGDIIIBIJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class CMBFGNEGEJI : global::PDLGFBEOKBE<float>, GKNPAAIBGAM, global::PBGPIEICANJ<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly CMBFGNEGEJI OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x14B84B0", Offset = "0x14B78B0", VA = "0x1814B84B0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, float FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x14B84A0", Offset = "0x14B78A0", VA = "0x1814B84A0", Slot = "5")]
	public float AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x14B84C0", Offset = "0x14B78C0", VA = "0x1814B84C0", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, float FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x14B8500", Offset = "0x14B7900", VA = "0x1814B8500", Slot = "7")]
	public float PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public CMBFGNEGEJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class PBPFOKNBGAM : global::PDLGFBEOKBE<float?>, GKNPAAIBGAM, global::PBGPIEICANJ<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly PBPFOKNBGAM OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0xBE8B50", Offset = "0xBE7F50", VA = "0x180BE8B50", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, float? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0xBE8AE0", Offset = "0xBE7EE0", VA = "0x180BE8AE0", Slot = "5")]
	public float? AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0xBE8BD0", Offset = "0xBE7FD0", VA = "0x180BE8BD0", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, float? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xBE8CD0", Offset = "0xBE80D0", VA = "0x180BE8CD0", Slot = "7")]
	public float? PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public PBPFOKNBGAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class NABIEDLMPHK : global::PDLGFBEOKBE<float[]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly NABIEDLMPHK OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0xBE22D0", Offset = "0xBE16D0", VA = "0x180BE22D0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, float[] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0xBE20A0", Offset = "0xBE14A0", VA = "0x180BE20A0", Slot = "5")]
	public float[] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public NABIEDLMPHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class BBAMOCJJDNH : global::PDLGFBEOKBE<double>, GKNPAAIBGAM, global::PBGPIEICANJ<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly BBAMOCJJDNH OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x14B2290", Offset = "0x14B1690", VA = "0x1814B2290", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, double FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x14B2280", Offset = "0x14B1680", VA = "0x1814B2280", Slot = "5")]
	public double AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x14B22A0", Offset = "0x14B16A0", VA = "0x1814B22A0", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, double FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x14B22E0", Offset = "0x14B16E0", VA = "0x1814B22E0", Slot = "7")]
	public double PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public BBAMOCJJDNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class DGHMOCDGKLI : global::PDLGFBEOKBE<double?>, GKNPAAIBGAM, global::PBGPIEICANJ<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly DGHMOCDGKLI OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x14BA4E0", Offset = "0x14B98E0", VA = "0x1814BA4E0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, double? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x14BA450", Offset = "0x14B9850", VA = "0x1814BA450", Slot = "5")]
	public double? AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x14BA560", Offset = "0x14B9960", VA = "0x1814BA560", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, double? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x14BA5F0", Offset = "0x14B99F0", VA = "0x1814BA5F0", Slot = "7")]
	public double? PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public DGHMOCDGKLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class BNGACBNNHGB : global::PDLGFBEOKBE<double[]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly BNGACBNNHGB OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x14B44E0", Offset = "0x14B38E0", VA = "0x1814B44E0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, double[] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x14B43A0", Offset = "0x14B37A0", VA = "0x1814B43A0", Slot = "5")]
	public double[] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public BNGACBNNHGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class PDAGFBOPELM : global::PDLGFBEOKBE<bool>, GKNPAAIBGAM, global::PBGPIEICANJ<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly PDAGFBOPELM OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0xBE8E00", Offset = "0xBE8200", VA = "0x180BE8E00", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, bool FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xBE8DF0", Offset = "0xBE81F0", VA = "0x180BE8DF0", Slot = "5")]
	public bool AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0xBE8E20", Offset = "0xBE8220", VA = "0x180BE8E20", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, bool FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0xBE8ED0", Offset = "0xBE82D0", VA = "0x180BE8ED0", Slot = "7")]
	public bool PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public PDAGFBOPELM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class NCHDHLLIAOO : global::PDLGFBEOKBE<bool?>, GKNPAAIBGAM, global::PBGPIEICANJ<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly NCHDHLLIAOO OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0xBE47B0", Offset = "0xBE3BB0", VA = "0x180BE47B0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, bool? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0xBE4740", Offset = "0xBE3B40", VA = "0x180BE4740", Slot = "5")]
	public bool? AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0xBE4830", Offset = "0xBE3C30", VA = "0x180BE4830", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, bool? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0xBE4930", Offset = "0xBE3D30", VA = "0x180BE4930", Slot = "7")]
	public bool? PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public NCHDHLLIAOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class FIEPFKNCADB : global::PDLGFBEOKBE<bool[]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly FIEPFKNCADB OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x14C07B0", Offset = "0x14BFBB0", VA = "0x1814C07B0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, bool[] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x14C0670", Offset = "0x14BFA70", VA = "0x1814C0670", Slot = "5")]
	public bool[] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public FIEPFKNCADB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class KMDHEOPEMHN : global::PDLGFBEOKBE<object>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::PDLGFBEOKBE<object> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly Dictionary<Type, int> GOLLFPJJHNK;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0xBDD940", Offset = "0xBDCD40", VA = "0x180BDD940", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, object FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0xBDD4D0", Offset = "0xBDC8D0", VA = "0x180BDD4D0", Slot = "5")]
	public object AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public KMDHEOPEMHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class GGCLBJIOOPJ : global::PDLGFBEOKBE<byte[]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::PDLGFBEOKBE<byte[]> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x14C13C0", Offset = "0x14C07C0", VA = "0x1814C13C0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, byte[] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x14C1340", Offset = "0x14C0740", VA = "0x1814C1340", Slot = "5")]
	public byte[] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public GGCLBJIOOPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class CNCMNJIBEND : global::PDLGFBEOKBE<ArraySegment<byte>>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::PDLGFBEOKBE<ArraySegment<byte>> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x14B9580", Offset = "0x14B8980", VA = "0x1814B9580", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, ArraySegment<byte> FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x14B94A0", Offset = "0x14B88A0", VA = "0x1814B94A0", Slot = "5")]
	public ArraySegment<byte> AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public CNCMNJIBEND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class CFIIHLMJFFE : global::PDLGFBEOKBE<string>, GKNPAAIBGAM, global::PBGPIEICANJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::PDLGFBEOKBE<string> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x14B8420", Offset = "0x14B7820", VA = "0x1814B8420", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, string FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x14B8410", Offset = "0x14B7810", VA = "0x1814B8410", Slot = "5")]
	public string AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x14B8420", Offset = "0x14B7820", VA = "0x1814B8420", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, string FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x14B8410", Offset = "0x14B7810", VA = "0x1814B8410", Slot = "7")]
	public string PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public CFIIHLMJFFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class NGHAJAPFHMM : global::PDLGFBEOKBE<string[]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly NGHAJAPFHMM OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0xBE5020", Offset = "0xBE4420", VA = "0x180BE5020", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, string[] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0xBE4DC0", Offset = "0xBE41C0", VA = "0x180BE4DC0", Slot = "5")]
	public string[] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public NGHAJAPFHMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class BCLCKHDEFLO : global::PDLGFBEOKBE<char>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly BCLCKHDEFLO OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x14B24A0", Offset = "0x14B18A0", VA = "0x1814B24A0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, char FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x14B2470", Offset = "0x14B1870", VA = "0x1814B2470", Slot = "5")]
	public char AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public BCLCKHDEFLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class EDEFPJCMANI : global::PDLGFBEOKBE<char?>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly EDEFPJCMANI OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x14BD890", Offset = "0x14BCC90", VA = "0x1814BD890", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, char? FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x14BD7C0", Offset = "0x14BCBC0", VA = "0x1814BD7C0", Slot = "5")]
	public char? AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public EDEFPJCMANI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class DHDKJLIPAPE : global::PDLGFBEOKBE<char[]>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly DHDKJLIPAPE OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x14BA8D0", Offset = "0x14B9CD0", VA = "0x1814BA8D0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, char[] FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x14BA730", Offset = "0x14B9B30", VA = "0x1814BA730", Slot = "5")]
	public char[] AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public DHDKJLIPAPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class DIMFGGHODCM : global::PDLGFBEOKBE<Guid>, GKNPAAIBGAM, global::PBGPIEICANJ<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::PDLGFBEOKBE<Guid> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x14BAB00", Offset = "0x14B9F00", VA = "0x1814BAB00", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, Guid FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x14BAAB0", Offset = "0x14B9EB0", VA = "0x1814BAAB0", Slot = "5")]
	public Guid AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x14BABD0", Offset = "0x14B9FD0", VA = "0x1814BABD0", Slot = "6")]
	public void IGHCKCLLHAD(ref OCIPHIDCELE CDLKNDDFOPH, Guid FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x14BAAB0", Offset = "0x14B9EB0", VA = "0x1814BAAB0", Slot = "7")]
	public Guid PFCKIHDPFOO(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public DIMFGGHODCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class HAPHAJJJHMA : global::PDLGFBEOKBE<decimal>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::PDLGFBEOKBE<decimal> OKLBJLNFLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly bool HANHCEGFHHK;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0xE8E9D0", Offset = "0xE8DDD0", VA = "0x180E8E9D0")]
	public HAPHAJJJHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0xA9F170", Offset = "0xA9E570", VA = "0x180A9F170")]
	public HAPHAJJJHMA(bool HANHCEGFHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x14C2230", Offset = "0x14C1630", VA = "0x1814C2230", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, decimal FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x14C2000", Offset = "0x14C1400", VA = "0x1814C2000", Slot = "5")]
	public decimal AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class JLJMOGDKOPK : global::PDLGFBEOKBE<Uri>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly global::PDLGFBEOKBE<Uri> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0xBD7B50", Offset = "0xBD6F50", VA = "0x180BD7B50", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, Uri FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0xBD7AD0", Offset = "0xBD6ED0", VA = "0x180BD7AD0", Slot = "5")]
	public Uri AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public JLJMOGDKOPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class OPEPLFNBGCD : global::PDLGFBEOKBE<Version>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly global::PDLGFBEOKBE<Version> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0xBE89D0", Offset = "0xBE7DD0", VA = "0x180BE89D0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, Version FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0xBE8950", Offset = "0xBE7D50", VA = "0x180BE8950", Slot = "5")]
	public Version AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public OPEPLFNBGCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class KMABPPPAHJB<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class JEMNJMGMKPO : global::PDLGFBEOKBE<StringBuilder>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly global::PDLGFBEOKBE<StringBuilder> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0xBD4F00", Offset = "0xBD4300", VA = "0x180BD4F00", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, StringBuilder FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0xBD4E80", Offset = "0xBD4280", VA = "0x180BD4E80", Slot = "5")]
	public StringBuilder AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public JEMNJMGMKPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class AFEAPJJGIJP : global::PDLGFBEOKBE<BitArray>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly global::PDLGFBEOKBE<BitArray> OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x14B11D0", Offset = "0x14B05D0", VA = "0x1814B11D0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, BitArray FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x14B10B0", Offset = "0x14B04B0", VA = "0x1814B10B0", Slot = "5")]
	public BitArray AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public AFEAPJJGIJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class OIGPJAOEPEI : global::PDLGFBEOKBE<Type>, GKNPAAIBGAM
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly OIGPJAOEPEI OKLBJLNFLNK;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly Regex DADJIKHIPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool MMMDGDDAMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private bool KHIMAJDBEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private bool IBEALJPEOBG;

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0xBE80B0", Offset = "0xBE74B0", VA = "0x180BE80B0")]
	public OIGPJAOEPEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0xBE8060", Offset = "0xBE7460", VA = "0x180BE8060")]
	public OIGPJAOEPEI(bool MMMDGDDAMOO, bool KHIMAJDBEDM, bool IBEALJPEOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0xBE7EB0", Offset = "0xBE72B0", VA = "0x180BE7EB0", Slot = "4")]
	public void DGECGJPLFOM(ref OCIPHIDCELE CDLKNDDFOPH, Type FPLJCBGEJAP, BOIAJJMDENO LFBLMBMFJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0xBE7D80", Offset = "0xBE7180", VA = "0x180BE7D80", Slot = "5")]
	public Type AHLFMBEKFNG(ref PLOHLCGPGAB LGIEPMOBDDP, BOIAJJMDENO LFBLMBMFJOJ)
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
