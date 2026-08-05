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
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class OCDIAEBNBIP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
	public OCDIAEBNBIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class BEELDHPJJGE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
	public BEELDHPJJGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class OKPAEBHCKNP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
	public OKPAEBHCKNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class GPJOGOPLCHO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
	public GPJOGOPLCHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class AAHOGNFPGKE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C3A0", Offset = "0x4A7B7A0", VA = "0x184A7C3A0")]
	public static bool EGOOMOEHPLH(this TypeInfo FPPBLNEEHBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class GJBAPFOBCNP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type GJCGLEBJLEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x697530", VA = "0x180698130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] GANBMAFDEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6936F0", Offset = "0x692AF0", VA = "0x1806936F0")]
	public GJBAPFOBCNP(Type HFOIODKNGLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class HIOCBFJODKD : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void LEOPHDIOCPG<T>(ref MJKLEAPCGEK MPHPGBJPKDG, T IGDJJEECDAF, EBGILPKEKAA CNJODEMPCDA);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T HAPKCNEFMFM<T>(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA CNJODEMPCDA);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PFBBNCPHAMF
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AHKHKGPFFMH<T> : PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, T IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LEKLEHOHALI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, T IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum JDJHGEIJFIG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DMCPBBIKEOM
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x26CA2C0", Offset = "0x26C96C0", VA = "0x1826CA2C0")]
	public static global::AHKHKGPFFMH<T> JCDGOICIBCK<T>(this EBGILPKEKAA CNJODEMPCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4A882D0", Offset = "0x4A876D0", VA = "0x184A882D0")]
	public static object POEBKIJDGKE(this EBGILPKEKAA CNJODEMPCDA, Type FPPBLNEEHBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EJGICAJJGEP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4A88FD0", Offset = "0x4A883D0", VA = "0x184A88FD0")]
	public EJGICAJJGEP(string KAKCNEMJMJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct ABAAKBCDNKD
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class GDDJJBOOLFI
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] CCBBJEPJPEO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] NPFCKPJBMME;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4F91100", Offset = "0x4F90500", VA = "0x184F91100")]
		public static byte[] COIOHHFAGII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4F91190", Offset = "0x4F90590", VA = "0x184F91190")]
		public static char[] JAFBKMPCPNN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> EPAOIBGCELL;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] PHPPBACBMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] EEMDNKKFCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int FHAPAHAAKAH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool ALFEHOJNEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4A7EEC0", Offset = "0x4A7E2C0", VA = "0x184A7EEC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4A7F2C0", Offset = "0x4A7E6C0", VA = "0x184A7F2C0")]
	public ABAAKBCDNKD(byte[] EEMDNKKFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4A7F0D0", Offset = "0x4A7E4D0", VA = "0x184A7F0D0")]
	public ABAAKBCDNKD(byte[] EEMDNKKFCBK, int FHAPAHAAKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4A7E1B0", Offset = "0x4A7D5B0", VA = "0x184A7E1B0")]
	private CBDOLIPIPPM LPPFHBIMOIC(string GONKEOOFGON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4A7E0D0", Offset = "0x4A7D4D0", VA = "0x184A7E0D0")]
	private CBDOLIPIPPM LHGBNADAHFB(string KAKCNEMJMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4A7E040", Offset = "0x4A7D440", VA = "0x184A7E040")]
	public void KMCDBHCFEMN(int FHAPAHAAKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000")]
	public byte[] FFANCPDCFFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7775E0", Offset = "0x7769E0", VA = "0x1807775E0")]
	public int NBACFGJFMKD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4A7DA70", Offset = "0x4A7CE70", VA = "0x184A7DA70")]
	public CANLDOMODNB JBECILHEEJM()
	{
		return default(CANLDOMODNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D0C0", Offset = "0x4A7C4C0", VA = "0x184A7D0C0")]
	public void EALCAJMKAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D200", Offset = "0x4A7C600", VA = "0x184A7D200")]
	public bool EFGIHFHGHON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4A7DBF0", Offset = "0x4A7CFF0", VA = "0x184A7DBF0")]
	public bool JGLNGHJJLHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D560", Offset = "0x4A7C960", VA = "0x184A7D560")]
	public void GIDBBGMIKBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C820", Offset = "0x4A7BC20", VA = "0x184A7C820")]
	public bool DFIPEBIMAJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C880", Offset = "0x4A7BC80", VA = "0x184A7C880")]
	public bool DHEBDMONLHO(ref int LKJCGNNPEOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D9B0", Offset = "0x4A7CDB0", VA = "0x184A7D9B0")]
	public bool INFMIGNIGIK(ref int LKJCGNNPEOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D680", Offset = "0x4A7CA80", VA = "0x184A7D680")]
	public bool HEBPDBPJJBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4A7E8A0", Offset = "0x4A7DCA0", VA = "0x184A7E8A0")]
	public void MFAMENEEKBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C3D0", Offset = "0x4A7B7D0", VA = "0x184A7C3D0")]
	public bool ABMCBGGKMEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D8B0", Offset = "0x4A7CCB0", VA = "0x184A7D8B0")]
	public bool IDMKMHHNKOG(ref int LKJCGNNPEOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D410", Offset = "0x4A7C810", VA = "0x184A7D410")]
	public bool FMNLHLCOGKF(ref int LKJCGNNPEOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D3B0", Offset = "0x4A7C7B0", VA = "0x184A7D3B0")]
	public bool FJIBEECBKKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D4D0", Offset = "0x4A7C8D0", VA = "0x184A7D4D0")]
	public void GBPGALPOKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4A7EEE0", Offset = "0x4A7E2E0", VA = "0x184A7EEE0")]
	public bool PBMAHPPAINC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4A7DFB0", Offset = "0x4A7D3B0", VA = "0x184A7DFB0")]
	public void KGJCCAEAGBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C900", Offset = "0x4A7BD00", VA = "0x184A7C900")]
	private void DHNAJKOBPHM(out byte[] ILBIOOHBEPD, out int MLMHCLLJJBJ, out int GHKCNBFFMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D300", Offset = "0x4A7C700", VA = "0x184A7D300")]
	private static int FFECOEGAJIN(char GHJDMBPGMHF, char IKDBBHHKFLJ, char LAPNDBKJOMI, char BNEELLCBKDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C590", Offset = "0x4A7B990", VA = "0x184A7C590")]
	private static int DBFFJCOLDPA(char BCJCIOLMPPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C660", Offset = "0x4A7BA60", VA = "0x184A7C660")]
	public ArraySegment<byte> DBGNHFJDBIC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C4F0", Offset = "0x4A7B8F0", VA = "0x184A7C4F0")]
	public string COPHCEOHHBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4A7EF40", Offset = "0x4A7E340", VA = "0x184A7EF40")]
	public string PHDGNPJBCLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D6E0", Offset = "0x4A7CAE0", VA = "0x184A7D6E0")]
	public ArraySegment<byte> HKMDNFHLINA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D5F0", Offset = "0x4A7C9F0", VA = "0x184A7D5F0")]
	public ArraySegment<byte> HBJDJMGFIFC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4A7EA90", Offset = "0x4A7DE90", VA = "0x184A7EA90")]
	public bool NOHEBOOFNGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C760", Offset = "0x4A7BB60", VA = "0x184A7C760")]
	private static bool DBNHMCNGKIG(byte LAPNDBKJOMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4A7E6C0", Offset = "0x4A7DAC0", VA = "0x184A7E6C0")]
	private void MDKPEBPKKPJ(CANLDOMODNB MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4A7EA80", Offset = "0x4A7DE80", VA = "0x184A7EA80")]
	public void NEMFCOPLHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4A7DC50", Offset = "0x4A7D050", VA = "0x184A7DC50")]
	private void JJGBGLIPDJL(int IFGHAFPHBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D630", Offset = "0x4A7CA30", VA = "0x184A7D630")]
	public sbyte HCCKHLFJAIE()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C490", Offset = "0x4A7B890", VA = "0x184A7C490")]
	public short BGDLNLHPNCC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4A7DF50", Offset = "0x4A7D350", VA = "0x184A7DF50")]
	public int KCKENFLPDCP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D930", Offset = "0x4A7CD30", VA = "0x184A7D930")]
	public long IEODFGKIPIH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C430", Offset = "0x4A7B830", VA = "0x184A7C430")]
	public byte AELANOKCOCE()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4A7EE60", Offset = "0x4A7E260", VA = "0x184A7EE60")]
	public ushort OHHNFPPLEOD()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4A7EF70", Offset = "0x4A7E370", VA = "0x184A7EF70")]
	public uint PPCFNIENEMK()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4A7E050", Offset = "0x4A7D450", VA = "0x184A7E050")]
	public ulong KMKHDGADMBE()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4A7E930", Offset = "0x4A7DD30", VA = "0x184A7E930")]
	public float NAHPHGKPEOD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4A7DE10", Offset = "0x4A7D210", VA = "0x184A7DE10")]
	public double JLLGIDGELBB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4A7DD20", Offset = "0x4A7D120", VA = "0x184A7DD20")]
	public ArraySegment<byte> JLEDDEIBJAA()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4A7ECD0", Offset = "0x4A7E0D0", VA = "0x184A7ECD0")]
	private static int OFFNCCPOHJN(byte[] EEMDNKKFCBK, int FHAPAHAAKAH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CBDOLIPIPPM : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference BHCGBJIIDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int OPDNJMHAPPL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int CPIONFGJCHN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1A71500", Offset = "0x1A70900", VA = "0x181A71500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string ENOCNDHMLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x914EA0", Offset = "0x9142A0", VA = "0x180914EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4A83FF0", Offset = "0x4A833F0", VA = "0x184A83FF0")]
	public CBDOLIPIPPM(string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4A83F10", Offset = "0x4A83310", VA = "0x184A83F10")]
	public CBDOLIPIPPM(string KAKCNEMJMJL, byte[] ANEMFJEGFMO, int FHAPAHAAKAH, int OPDNJMHAPPL, string OACFOJALJHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OIEMJKKAHJL
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class KCMKFJEHLIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void ELCIHDFLLHA(ref MJKLEAPCGEK MPHPGBJPKDG, object IGDJJEECDAF, EBGILPKEKAA CNJODEMPCDA);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object KFKGALKLIBP(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA CNJODEMPCDA);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class PKLNKBCBHEF
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class PCDCMLCEOMA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
				public PCDCMLCEOMA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x380B740", Offset = "0x380AB40", VA = "0x18380B740")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x4F9C700", Offset = "0x4F9BB00", VA = "0x184F9C700")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, EBGILPKEKAA, byte[]> MNIJIECFCCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, EBGILPKEKAA> AFPAOKHEADO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly ELCIHDFLLHA HAOLPCKIBBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, EBGILPKEKAA, ArraySegment<byte>> BLLAEJLDNBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, EBGILPKEKAA, string> ODNLDPBAKEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, EBGILPKEKAA, object> OCAJBCHJFCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, EBGILPKEKAA, object> HJONDDKMJDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, EBGILPKEKAA, object> LHFGAHLEGBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly KFKGALKLIBP BAHEFNHABPG;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x4F9D160", Offset = "0x4F9C560", VA = "0x184F9D160")]
			public PKLNKBCBHEF(Type FPPBLNEEHBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x60AB380", Offset = "0x60AA780", VA = "0x1860AB380")]
			private static T OGGPHJPJKEF<T>(DynamicMethod PAFECEHODKI)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4F9CF10", Offset = "0x4F9C310", VA = "0x184F9CF10")]
			private static MethodInfo OIJAAGHIJFN(Type FPPBLNEEHBP, string DHKKANIEGMN, Type[] JDOOKIHJKAJ)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, PKLNKBCBHEF> HGCFMPLADOL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::ELLGFIBEPCN<PKLNKBCBHEF> DILGKENGFLL;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4F93AB0", Offset = "0x4F92EB0", VA = "0x184F93AB0")]
		static KCMKFJEHLIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4F93A20", Offset = "0x4F92E20", VA = "0x184F93A20")]
		private static PKLNKBCBHEF NLBKHCCPJFB(Type FPPBLNEEHBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4F93770", Offset = "0x4F92B70", VA = "0x184F93770")]
		public static void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, object IGDJJEECDAF, EBGILPKEKAA CNJODEMPCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4F93900", Offset = "0x4F92D00", VA = "0x184F93900")]
		public static void FBLBIDAIACI(Type FPPBLNEEHBP, ref MJKLEAPCGEK MPHPGBJPKDG, object IGDJJEECDAF, EBGILPKEKAA CNJODEMPCDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class DKFOLHKNKFL
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] CCBBJEPJPEO;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4F8D890", Offset = "0x4F8CC90", VA = "0x184F8D890")]
		public static byte[] COIOHHFAGII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static EBGILPKEKAA POHGCGADEGG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] HNIIBGLILAO;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] NHGKMCMOPCA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static EBGILPKEKAA OBFBAFBPPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4F989D0", Offset = "0x4F97DD0", VA = "0x184F989D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MMIGCPEOPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4F983E0", Offset = "0x4F977E0", VA = "0x184F983E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4F98110", Offset = "0x4F97510", VA = "0x184F98110")]
	public static void HAHEOHMBPKE(EBGILPKEKAA CNJODEMPCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FB96D0", Offset = "0x1FB8AD0", VA = "0x181FB96D0")]
	public static byte[] FBLBIDAIACI<T>(T JLBINKLPHKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FB94E0", Offset = "0x1FB88E0", VA = "0x181FB94E0")]
	public static byte[] FBLBIDAIACI<T>(T IGDJJEECDAF, EBGILPKEKAA CNJODEMPCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9640", Offset = "0x1FB8A40", VA = "0x181FB9640")]
	public static void FBLBIDAIACI<T>(ref MJKLEAPCGEK MPHPGBJPKDG, T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9900", Offset = "0x1FB8D00", VA = "0x181FB9900")]
	public static void FBLBIDAIACI<T>(ref MJKLEAPCGEK MPHPGBJPKDG, T IGDJJEECDAF, EBGILPKEKAA CNJODEMPCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9870", Offset = "0x1FB8C70", VA = "0x181FB9870")]
	public static void FBLBIDAIACI<T>(Stream DJGPEPEBOGE, T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9750", Offset = "0x1FB8B50", VA = "0x181FB9750")]
	public static void FBLBIDAIACI<T>(Stream DJGPEPEBOGE, T IGDJJEECDAF, EBGILPKEKAA CNJODEMPCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB92C0", Offset = "0x1FB86C0", VA = "0x181FB92C0")]
	public static ArraySegment<byte> APBMBDMPNGK<T>(T JLBINKLPHKJ)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9360", Offset = "0x1FB8760", VA = "0x181FB9360")]
	public static ArraySegment<byte> APBMBDMPNGK<T>(T IGDJJEECDAF, EBGILPKEKAA CNJODEMPCDA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB90E0", Offset = "0x1FB84E0", VA = "0x181FB90E0")]
	public static string AIPACAPGBJJ<T>(T IGDJJEECDAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB9160", Offset = "0x1FB8560", VA = "0x181FB9160")]
	public static string AIPACAPGBJJ<T>(T IGDJJEECDAF, EBGILPKEKAA CNJODEMPCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA4D0", Offset = "0x1FB98D0", VA = "0x181FBA4D0")]
	public static T LOHKEOMODAB<T>(string GOBJDFAKNMG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA3E0", Offset = "0x1FB97E0", VA = "0x181FBA3E0")]
	public static T LOHKEOMODAB<T>(string GOBJDFAKNMG, EBGILPKEKAA CNJODEMPCDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FBAB40", Offset = "0x1FB9F40", VA = "0x181FBAB40")]
	public static T LOHKEOMODAB<T>(byte[] EEMDNKKFCBK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA340", Offset = "0x1FB9740", VA = "0x181FBA340")]
	public static T LOHKEOMODAB<T>(byte[] EEMDNKKFCBK, EBGILPKEKAA CNJODEMPCDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA7B0", Offset = "0x1FB9BB0", VA = "0x181FBA7B0")]
	public static T LOHKEOMODAB<T>(byte[] EEMDNKKFCBK, int FHAPAHAAKAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA570", Offset = "0x1FB9970", VA = "0x181FBA570")]
	public static T LOHKEOMODAB<T>(byte[] EEMDNKKFCBK, int FHAPAHAAKAH, EBGILPKEKAA CNJODEMPCDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA910", Offset = "0x1FB9D10", VA = "0x181FBA910")]
	public static T LOHKEOMODAB<T>(ref ABAAKBCDNKD HMLGAEKBLFL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA840", Offset = "0x1FB9C40", VA = "0x181FBA840")]
	public static T LOHKEOMODAB<T>(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA CNJODEMPCDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1FBAD80", Offset = "0x1FBA180", VA = "0x181FBAD80")]
	public static T LOHKEOMODAB<T>(Stream DJGPEPEBOGE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA990", Offset = "0x1FB9D90", VA = "0x181FBA990")]
	public static T LOHKEOMODAB<T>(Stream DJGPEPEBOGE, EBGILPKEKAA CNJODEMPCDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4F97EB0", Offset = "0x4F972B0", VA = "0x184F97EB0")]
	public static string AOLIGKLGEKH(byte[] GOBJDFAKNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4F97F90", Offset = "0x4F97390", VA = "0x184F97F90")]
	public static string AOLIGKLGEKH(byte[] GOBJDFAKNMG, int FHAPAHAAKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4F98040", Offset = "0x4F97440", VA = "0x184F98040")]
	public static string AOLIGKLGEKH(string GOBJDFAKNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4F98180", Offset = "0x4F97580", VA = "0x184F98180")]
	public static byte[] HCIIMLKPOJJ(byte[] GOBJDFAKNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4F98330", Offset = "0x4F97730", VA = "0x184F98330")]
	public static byte[] HCIIMLKPOJJ(byte[] GOBJDFAKNMG, int FHAPAHAAKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4F98260", Offset = "0x4F97660", VA = "0x184F98260")]
	public static byte[] HCIIMLKPOJJ(string GOBJDFAKNMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4F984E0", Offset = "0x4F978E0", VA = "0x184F984E0")]
	private static void JJNMPBFIJJL(ref ABAAKBCDNKD HMLGAEKBLFL, ref MJKLEAPCGEK MPHPGBJPKDG, int FGINFGKNAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4F98440", Offset = "0x4F97840", VA = "0x184F98440")]
	private static int JGJCNFLMCNA(Stream PHGHFOGNNLI, ref byte[] CCBBJEPJPEO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum CANLDOMODNB : byte
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
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct MJKLEAPCGEK
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] FCKJFAFLLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] CCBBJEPJPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int FHAPAHAAKAH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KIJKIJOMGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7775E0", Offset = "0x7769E0", VA = "0x1807775E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4A7E040", Offset = "0x4A7D440", VA = "0x184A7E040")]
	public void KMCDBHCFEMN(int FHAPAHAAKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4500", Offset = "0x4EE3900", VA = "0x184EE4500")]
	public static byte[] HGMACMPKDGJ(string JLNILGJAKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4180", Offset = "0x4EE3580", VA = "0x184EE4180")]
	public static byte[] FJNBHCJAENM(string JLNILGJAKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3F30", Offset = "0x4EE3330", VA = "0x184EE3F30")]
	public static byte[] DKGKEJIFOJH(string JLNILGJAKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3DB0", Offset = "0x4EE31B0", VA = "0x184EE3DB0")]
	public static byte[] DDBEMDPKCON(string JLNILGJAKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xCCBE70", Offset = "0xCCB270", VA = "0x180CCBE70")]
	public MJKLEAPCGEK(byte[] IJFAOIEFNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3D00", Offset = "0x4EE3100", VA = "0x184EE3D00")]
	public ArraySegment<byte> COIOHHFAGII()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4AD0", Offset = "0x4EE3ED0", VA = "0x184EE4AD0")]
	public byte[] KHIBOLCJICO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5010", Offset = "0x4EE4410", VA = "0x184EE5010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4070", Offset = "0x4EE3470", VA = "0x184EE4070")]
	public void ECNINJLKKPH(int NJFNJAECHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4A887C0", Offset = "0x4A87BC0", VA = "0x184A887C0")]
	public void ANFPCHHIAGK(byte GMMHICDKCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3C50", Offset = "0x4EE3050", VA = "0x184EE3C50")]
	public void ANFPCHHIAGK(byte[] GMMHICDKCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4B50", Offset = "0x4EE3F50", VA = "0x184EE4B50")]
	public void LALMEDCMLIF(byte GMMHICDKCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4A00", Offset = "0x4EE3E00", VA = "0x184EE4A00")]
	public void IIHLFEHIOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4A50", Offset = "0x4EE3E50", VA = "0x184EE4A50")]
	public void JJIKEAMEEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4450", Offset = "0x4EE3850", VA = "0x184EE4450")]
	public void GIKNKEIFANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4EE49B0", Offset = "0x4EE3DB0", VA = "0x184EE49B0")]
	public void HLADJFFNEAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3CB0", Offset = "0x4EE30B0", VA = "0x184EE3CB0")]
	public void AOMLKFKJKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4BC0", Offset = "0x4EE3FC0", VA = "0x184EE4BC0")]
	public void MAEGKFFLLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4EE44A0", Offset = "0x4EE38A0", VA = "0x184EE44A0")]
	public void GPEAPKDIGPP(string JLNILGJAKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4F90", Offset = "0x4EE4390", VA = "0x184EE4F90")]
	public void PGLEIDPNAKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4EE40B0", Offset = "0x4EE34B0", VA = "0x184EE40B0")]
	public void FINMOMAIFAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4D70", Offset = "0x4EE4170", VA = "0x184EE4D70")]
	public void NKODFEGNGIL(bool IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4EE42F0", Offset = "0x4EE36F0", VA = "0x184EE42F0")]
	public void GFPBGOMOJNI(float IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4C10", Offset = "0x4EE4010", VA = "0x184EE4C10")]
	public void MOKGAHEEODB(double IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3F00", Offset = "0x4EE3300", VA = "0x184EE3F00")]
	public void DHKHHDPCGEB(byte IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4FE0", Offset = "0x4EE43E0", VA = "0x184EE4FE0")]
	public void PKBNGAMLJDD(ushort IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4F60", Offset = "0x4EE4360", VA = "0x184EE4F60")]
	public void PCILJOEKPNI(uint IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4080", Offset = "0x4EE3480", VA = "0x184EE4080")]
	public void ENHPBNIMKEK(ulong IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4EE42C0", Offset = "0x4EE36C0", VA = "0x184EE42C0")]
	public void FMJMIBNHPJJ(sbyte IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4AA0", Offset = "0x4EE3EA0", VA = "0x184EE4AA0")]
	public void JJKEKNDPEPD(short IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4EE4B90", Offset = "0x4EE3F90", VA = "0x184EE4B90")]
	public void LBDFDFALNAL(int IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3C20", Offset = "0x4EE3020", VA = "0x184EE3C20")]
	public void AEKOGICGJEA(long IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4EE45E0", Offset = "0x4EE39E0", VA = "0x184EE45E0")]
	public void HJOJFOHDDCN(string IGDJJEECDAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CMICNELOBEF : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class GAJJGBGLKKO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D33D40", Offset = "0x2D33140", VA = "0x182D33D40")]
		static GAJJGBGLKKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private CMICNELOBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class KLEEALPELGC
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> DCOKKHPDGPH;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4ED8C80", Offset = "0x4ED8080", VA = "0x184ED8C80")]
	static KLEEALPELGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4ED8570", Offset = "0x4ED7970", VA = "0x184ED8570")]
	internal static object IFGBJAAEBLJ(Type BJKDLBIJMNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class GKHPFAJDBMP : global::AHKHKGPFFMH<Vector2>, PFBBNCPHAMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IHFGIEKMHON MKMHPDKLGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] INCMKDKBBCJ;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4ECEA70", Offset = "0x4ECDE70", VA = "0x184ECEA70")]
	public GKHPFAJDBMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4ECE700", Offset = "0x4ECDB00", VA = "0x184ECE700", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, Vector2 IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4ECE870", Offset = "0x4ECDC70", VA = "0x184ECE870", Slot = "5")]
	public Vector2 LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class KFDMGNIMDAA : global::AHKHKGPFFMH<Vector3>, PFBBNCPHAMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IHFGIEKMHON MKMHPDKLGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] INCMKDKBBCJ;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4ED8200", Offset = "0x4ED7600", VA = "0x184ED8200")]
	public KFDMGNIMDAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4ED7DD0", Offset = "0x4ED71D0", VA = "0x184ED7DD0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, Vector3 IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4ED7FD0", Offset = "0x4ED73D0", VA = "0x184ED7FD0", Slot = "5")]
	public Vector3 LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class HAJENBKCDJK : global::AHKHKGPFFMH<Vector4>, PFBBNCPHAMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IHFGIEKMHON MKMHPDKLGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] INCMKDKBBCJ;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4ECFF10", Offset = "0x4ECF310", VA = "0x184ECFF10")]
	public HAJENBKCDJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4ECECB0", Offset = "0x4ECE0B0", VA = "0x184ECECB0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, Vector4 IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4ECFC80", Offset = "0x4ECF080", VA = "0x184ECFC80", Slot = "5")]
	public Vector4 LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class GOEHHELIFFD : global::AHKHKGPFFMH<Quaternion>, PFBBNCPHAMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly IHFGIEKMHON MKMHPDKLGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] INCMKDKBBCJ;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4ECF910", Offset = "0x4ECED10", VA = "0x184ECF910")]
	public GOEHHELIFFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4ECECB0", Offset = "0x4ECE0B0", VA = "0x184ECECB0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, Quaternion IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4ECF680", Offset = "0x4ECEA80", VA = "0x184ECF680", Slot = "5")]
	public Quaternion LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class GLEAMMGCAOB : global::AHKHKGPFFMH<Color>, PFBBNCPHAMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IHFGIEKMHON MKMHPDKLGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] INCMKDKBBCJ;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4ECF1B0", Offset = "0x4ECE5B0", VA = "0x184ECF1B0")]
	public GLEAMMGCAOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4ECECB0", Offset = "0x4ECE0B0", VA = "0x184ECECB0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, Color IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4ECEF20", Offset = "0x4ECE320", VA = "0x184ECEF20", Slot = "5")]
	public Color LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class EPGDMFJFFBL : global::AHKHKGPFFMH<Bounds>, PFBBNCPHAMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly IHFGIEKMHON MKMHPDKLGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] INCMKDKBBCJ;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4A89C40", Offset = "0x4A89040", VA = "0x184A89C40")]
	public EPGDMFJFFBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4A89680", Offset = "0x4A88A80", VA = "0x184A89680", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, Bounds IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4A89820", Offset = "0x4A88C20", VA = "0x184A89820", Slot = "5")]
	public Bounds LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class NFAMKALCMPK : global::AHKHKGPFFMH<Rect>, PFBBNCPHAMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly IHFGIEKMHON MKMHPDKLGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] INCMKDKBBCJ;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4EE6510", Offset = "0x4EE5910", VA = "0x184EE6510")]
	public NFAMKALCMPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5FD0", Offset = "0x4EE53D0", VA = "0x184EE5FD0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, Rect IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4EE6260", Offset = "0x4EE5660", VA = "0x184EE6260", Slot = "5")]
	public Rect LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class IDMNNNCPKJA : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class HHGHEJGLCIM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A35B70", Offset = "0x2A34F70", VA = "0x182A35B70")]
		static HHGHEJGLCIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private IDMNNNCPKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class LCOLACJBFBA : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class AIKKAHFPOGK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x38C7200", Offset = "0x38C6600", VA = "0x1838C7200")]
		static AIKKAHFPOGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class NELJHNJBPLG
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> MKDHPDNCLAA;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4F949C0", Offset = "0x4F93DC0", VA = "0x184F949C0")]
		internal static object IFGBJAAEBLJ(Type BJKDLBIJMNC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private LCOLACJBFBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class OKLGNDJLNNC : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class NCPDEAKGKCK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2F91D50", Offset = "0x2F91150", VA = "0x182F91D50")]
		static NCPDEAKGKCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly OKLGNDJLNNC KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool AMODHIEHHMD;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static PFBBNCPHAMF[] DGKCPCIDDDP;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static EBGILPKEKAA[] PHEMDKICCKF;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private OKLGNDJLNNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F99840", Offset = "0x4F98C40", VA = "0x184F99840")]
	public static void JGOJGDHNHPP(params EBGILPKEKAA[] PHEMDKICCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4F99760", Offset = "0x4F98B60", VA = "0x184F99760")]
	public static void JGOJGDHNHPP(params PFBBNCPHAMF[] DGKCPCIDDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F994D0", Offset = "0x4F988D0", VA = "0x184F994D0")]
	public static void DOBHFKEEADP(PFBBNCPHAMF[] DGKCPCIDDDP, EBGILPKEKAA[] PHEMDKICCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class BEGLNJEMKGK : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class PKBAJGONLNH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2DB5170", Offset = "0x2DB4570", VA = "0x182DB5170")]
		static PKBAJGONLNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private BEGLNJEMKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PBFLPPKGOPD
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly EBGILPKEKAA BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly EBGILPKEKAA NLOBOBGONID;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly EBGILPKEKAA IKGELKEFHGE;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly EBGILPKEKAA AEEOEFIPFBM;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly EBGILPKEKAA FFNFOMKBCCG;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly EBGILPKEKAA CEEBMLIGEDO;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly EBGILPKEKAA BBPCGLJNCFC;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly EBGILPKEKAA FOMPBLCJKDM;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly EBGILPKEKAA IFEOEBDAJAP;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly EBGILPKEKAA OOBIPEFCOHP;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly EBGILPKEKAA ILGCGHHKJNF;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly EBGILPKEKAA EOIPOLNHKFG;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class NIKKHLJKONP
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly EBGILPKEKAA BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly EBGILPKEKAA MJCNDOFCBGF;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class MLFHHEMCJNB
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly EBGILPKEKAA BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly EBGILPKEKAA NLOBOBGONID;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly EBGILPKEKAA IKGELKEFHGE;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly EBGILPKEKAA AEEOEFIPFBM;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly EBGILPKEKAA FFNFOMKBCCG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly EBGILPKEKAA CEEBMLIGEDO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly EBGILPKEKAA BBPCGLJNCFC;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly EBGILPKEKAA FOMPBLCJKDM;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly EBGILPKEKAA IFEOEBDAJAP;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly EBGILPKEKAA OOBIPEFCOHP;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly EBGILPKEKAA ILGCGHHKJNF;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly EBGILPKEKAA EOIPOLNHKFG;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class MAPAHEPHCHN
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> MKDHPDNCLAA;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4EE1380", Offset = "0x4EE0780", VA = "0x184EE1380")]
	internal static object IFGBJAAEBLJ(Type BJKDLBIJMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4EE2CE0", Offset = "0x4EE20E0", VA = "0x184EE2CE0")]
	private static object NNOKGLKCELC(Type JHJDMHLIIBP, Type[] KNANABPIIDE, params object[] JDOOKIHJKAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class KCGLPKNNCFA : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class COPPEAIMBGN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2786CF0", Offset = "0x27860F0", VA = "0x182786CF0")]
		static COPPEAIMBGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> PAENNLMFJMO;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool EAKKHIIJGOM;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly PMHALKLFNPF PFGJMMBICGO;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4ED7CA0", Offset = "0x4ED70A0", VA = "0x184ED7CA0")]
	static KCGLPKNNCFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private KCGLPKNNCFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class EMFGJFPHPME : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class HHMKHBGACPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2A38530", Offset = "0x2A37930", VA = "0x182A38530")]
		static HHMKHBGACPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> PAENNLMFJMO;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool EAKKHIIJGOM;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly PMHALKLFNPF PFGJMMBICGO;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4A89400", Offset = "0x4A88800", VA = "0x184A89400")]
	static EMFGJFPHPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private EMFGJFPHPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class PJBJKKBMAEP : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class OEECFLNJOED<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3A54D10", Offset = "0x3A54110", VA = "0x183A54D10")]
		static OEECFLNJOED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> PAENNLMFJMO;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool EAKKHIIJGOM;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly PMHALKLFNPF PFGJMMBICGO;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4F9CD00", Offset = "0x4F9C100", VA = "0x184F9CD00")]
	static PJBJKKBMAEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private PJBJKKBMAEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class HNAPKNBAFJN : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class APNKLBILFOM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x31099D0", Offset = "0x3108DD0", VA = "0x1831099D0")]
		static APNKLBILFOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> PAENNLMFJMO;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool EAKKHIIJGOM;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly PMHALKLFNPF PFGJMMBICGO;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4ED20F0", Offset = "0x4ED14F0", VA = "0x184ED20F0")]
	static HNAPKNBAFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private HNAPKNBAFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class IHANHNOEIOM : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class FJCKHOPHMJE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x25D1450", Offset = "0x25D0850", VA = "0x1825D1450")]
		static FJCKHOPHMJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> PAENNLMFJMO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool EAKKHIIJGOM;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly PMHALKLFNPF PFGJMMBICGO;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4ED25C0", Offset = "0x4ED19C0", VA = "0x184ED25C0")]
	static IHANHNOEIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private IHANHNOEIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class CCMPPFCOFON : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class AMPDPEGDIGG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3100DE0", Offset = "0x31001E0", VA = "0x183100DE0")]
		static AMPDPEGDIGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> PAENNLMFJMO;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool EAKKHIIJGOM;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly PMHALKLFNPF PFGJMMBICGO;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4A84060", Offset = "0x4A83460", VA = "0x184A84060")]
	static CCMPPFCOFON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private CCMPPFCOFON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class ELHBJDPEDAM : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class HJDJAEHBKJO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2A3D760", Offset = "0x2A3CB60", VA = "0x182A3D760")]
		static HJDJAEHBKJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> PAENNLMFJMO;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool EAKKHIIJGOM;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public ELHBJDPEDAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class CFDMMMFDKAI : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class GHJFELHHBJD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2792B80", Offset = "0x2791F80", VA = "0x182792B80")]
		static GHJFELHHBJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> PAENNLMFJMO;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool EAKKHIIJGOM;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public CFDMMMFDKAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class HCGDLIBOPKF : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class LHCEEGHEMIM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3890AC0", Offset = "0x388FEC0", VA = "0x183890AC0")]
		static LHCEEGHEMIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> PAENNLMFJMO;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool EAKKHIIJGOM;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HCGDLIBOPKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class PDDLPCIEFAA : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class KJFPOFMPPIK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x29643C0", Offset = "0x29637C0", VA = "0x1829643C0")]
		static KJFPOFMPPIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> PAENNLMFJMO;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool EAKKHIIJGOM;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public PDDLPCIEFAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class JOHAOELIAMK : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class GONJHGCFHNM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x41826D0", Offset = "0x4181AD0", VA = "0x1841826D0")]
		static GONJHGCFHNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> PAENNLMFJMO;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool EAKKHIIJGOM;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public JOHAOELIAMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class NFJJCKHPNLH : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class HKPIDHBHJGF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2A48830", Offset = "0x2A47C30", VA = "0x182A48830")]
		static HKPIDHBHJGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> PAENNLMFJMO;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool EAKKHIIJGOM;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NFJJCKHPNLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class FHGIMDCOACJ
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct EHNPIHOENLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public OCJJGALKMFE OBABKEMNBAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder EJKMFGHDHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder HEMKAIFCAMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class IBBPCEOBLBF
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class DHMLEKFAHMK
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo DKGKEJIFOJH;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo FJNBHCJAENM;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo DDBEMDPKCON;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo HGMACMPKDGJ;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo FINMOMAIFAD;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo ANFPCHHIAGK;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo GIKNKEIFANN;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo HLADJFFNEAP;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo AOMLKFKJKOD;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x4F8C7D0", Offset = "0x4F8BBD0", VA = "0x184F8C7D0")]
			static DHMLEKFAHMK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class EKNAEHMFOIE
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo EFGIHFHGHON;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo MFAMENEEKBH;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo IDMKMHHNKOG;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo GGMKENNJAAG;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo NEMFCOPLHIG;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo FFANCPDCFFH;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo NBACFGJFMKD;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x4F8E620", Offset = "0x4F8DA20", VA = "0x184F8E620")]
			static EKNAEHMFOIE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class EHOOKKNPFNF
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo GJCGLEBJLEF;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo GANBMAFDEFP;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo OLAPJGNOHHP;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo JCDGOICIBCK;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo NJKIKPNDDON;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo GFHDIEIIDMN;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo IIEJBGIJBKI;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo KKMGLMJCEMK;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo GCMENBMDAPD;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo BHAMNLDJBKF;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo LCMPBFHGGNA;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo MJCICKNMGGE;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo GOFCENOLPBP;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo PEFNIPFKJFC;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4F91710", Offset = "0x4F90B10", VA = "0x184F91710")]
		public static MethodInfo FBLBIDAIACI(Type FPPBLNEEHBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4F91B20", Offset = "0x4F90F20", VA = "0x184F91B20")]
		public static MethodInfo LOHKEOMODAB(Type FPPBLNEEHBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4F919E0", Offset = "0x4F90DE0", VA = "0x184F919E0")]
		public static MethodInfo LIGGFEPKNPL(Type FPPBLNEEHBP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class LHHAKOKGIKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<OCJJGALKMFE, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public LHHAKOKGIKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class AOHFEOCHFHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public LHHAKOKGIKI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public AOHFEOCHFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4F8C320", Offset = "0x4F8B720", VA = "0x184F8C320")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4F8C360", Offset = "0x4F8B760", VA = "0x184F8C360")]
		internal bool <BuildType>b__2(int index, OCJJGALKMFE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class NOHLGLAFHLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public LHHAKOKGIKI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public NOHLGLAFHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4F96BD0", Offset = "0x4F95FD0", VA = "0x184F96BD0")]
		internal bool <BuildType>b__3(int index, OCJJGALKMFE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class AOOOGGDBGBN
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

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public AOOOGGDBGBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4F8C400", Offset = "0x4F8B800", VA = "0x184F8C400")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class MCFAIAPIBFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public MCFAIAPIBFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4F94550", Offset = "0x4F93950", VA = "0x184F94550")]
		internal bool <BuildAnonymousFormatter>b__2(OCJJGALKMFE x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class DFAKFDJDLCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AOOOGGDBGBN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public DFAKFDJDLCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x4F8C620", Offset = "0x4F8BA20", VA = "0x184F8C620")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4F8C630", Offset = "0x4F8BA30", VA = "0x184F8C630")]
		internal bool <BuildAnonymousFormatter>b__6(int index, OCJJGALKMFE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class NADFJLONFNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public AOOOGGDBGBN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public NADFJLONFNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4F94820", Offset = "0x4F93C20", VA = "0x184F94820")]
		internal bool <BuildAnonymousFormatter>b__7(int index, OCJJGALKMFE member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class NCAEJCODKEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public NCAEJCODKEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6A2FD0", Offset = "0x6A23D0", VA = "0x1806A2FD0")]
		internal Label <BuildSerialize>b__1(OCJJGALKMFE _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class DKCOCMCDHON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public EHNPIHOENLH[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, OCJJGALKMFE, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public FALFCLBOBIO argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public FALFCLBOBIO argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public DKCOCMCDHON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x4F8D770", Offset = "0x4F8CB70", VA = "0x184F8D770")]
		internal EHNPIHOENLH <BuildDeserialize>b__0(OCJJGALKMFE item)
		{
			return default(EHNPIHOENLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class EDPHBJAENEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public DKCOCMCDHON CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public EDPHBJAENEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4F8DF10", Offset = "0x4F8D310", VA = "0x184F8DF10")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4F8E1C0", Offset = "0x4F8D5C0", VA = "0x184F8E1C0")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class NIEFGKHPGBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public OCJJGALKMFE item;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public NIEFGKHPGBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x116B420", Offset = "0x116A820", VA = "0x18116B420")]
		internal bool <EmitNewObject>b__0(EHNPIHOENLH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class KJKMCKPJPMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public OCJJGALKMFE item;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public KJKMCKPJPMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x116B420", Offset = "0x116A820", VA = "0x18116B420")]
		internal bool <EmitNewObject>b__2(EHNPIHOENLH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex KLMMHMKAJDB;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int LGHLLOFMCAA;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> DLJHLDDAGIA;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> DFCHJNDEDGH;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2E95280", Offset = "0x2E94680", VA = "0x182E95280")]
	public static object LACCIOBFBNI<T>(PMHALKLFNPF PFGJMMBICGO, EBGILPKEKAA EBMAGGEIGHA, Func<string, string> PAENNLMFJMO, bool EAKKHIIJGOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2C83E30", Offset = "0x2C83230", VA = "0x182C83E30")]
	public static object NECCKJLCADN<T>(EBGILPKEKAA EBMAGGEIGHA, Func<string, string> PAENNLMFJMO, bool EAKKHIIJGOM, bool JFGBJMGHJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4A90FA0", Offset = "0x4A903A0", VA = "0x184A90FA0")]
	private static TypeInfo NHGNFAIOAHO(PMHALKLFNPF PFGJMMBICGO, Type FPPBLNEEHBP, Func<string, string> PAENNLMFJMO, bool EAKKHIIJGOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4A8BD50", Offset = "0x4A8B150", VA = "0x184A8BD50")]
	public static object CGJFBCEDGFH(Type FPPBLNEEHBP, Func<string, string> PAENNLMFJMO, bool EAKKHIIJGOM, bool JFGBJMGHJBA, bool MOKPDLNHAHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4A8B670", Offset = "0x4A8AA70", VA = "0x184A8B670")]
	private static Dictionary<OCJJGALKMFE, FieldInfo> CGFMLBLKIGD(TypeBuilder APGKJDEANDG, FBPIMAEAPCI CCCEIMBNION, ConstructorInfo ABOMHDGKLEJ, FieldBuilder BFJEBAMBCJL, ILGenerator BMLHEKEEGGP, bool EAKKHIIJGOM, bool FJJDBIEPJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4A8D950", Offset = "0x4A8CD50", VA = "0x184A8D950")]
	private static Dictionary<OCJJGALKMFE, FieldInfo> EJFKBIGFEPB(TypeBuilder APGKJDEANDG, FBPIMAEAPCI CCCEIMBNION, ILGenerator BMLHEKEEGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4A91F80", Offset = "0x4A91380", VA = "0x184A91F80")]
	private static void OOCNJOABIKA(Type FPPBLNEEHBP, FBPIMAEAPCI CCCEIMBNION, ILGenerator BMLHEKEEGGP, Action HMPMJLHNHLP, Func<int, OCJJGALKMFE, bool> PHPOEMGLLLD, bool EAKKHIIJGOM, bool FJJDBIEPJJD, int HMMKPGBJPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4A900C0", Offset = "0x4A8F4C0", VA = "0x184A900C0")]
	private static void GMIPEJIIBFH(TypeInfo FPPBLNEEHBP, OCJJGALKMFE POBAPLGJMDE, ILGenerator BMLHEKEEGGP, int HMJKJGLHFKE, Func<int, OCJJGALKMFE, bool> PHPOEMGLLLD, FALFCLBOBIO MPHPGBJPKDG, FALFCLBOBIO FJIEJEHEDOH, FALFCLBOBIO BAIPJNGPBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4A8EC80", Offset = "0x4A8E080", VA = "0x184A8EC80")]
	private static void FAOKNHFKBOO(Type FPPBLNEEHBP, FBPIMAEAPCI CCCEIMBNION, ILGenerator BMLHEKEEGGP, Func<int, OCJJGALKMFE, bool> PHPOEMGLLLD, bool FGOMCEEBBBK, int HMMKPGBJPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4A91A30", Offset = "0x4A90E30", VA = "0x184A91A30")]
	private static void OGEAAIKPFEM(ILGenerator BMLHEKEEGGP, EHNPIHOENLH CCCEIMBNION, int HMJKJGLHFKE, Func<int, OCJJGALKMFE, bool> PHPOEMGLLLD, FALFCLBOBIO HMLGAEKBLFL, FALFCLBOBIO BAIPJNGPBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4A8DFD0", Offset = "0x4A8D3D0", VA = "0x184A8DFD0")]
	private static LocalBuilder ELDMALHABPC(ILGenerator BMLHEKEEGGP, Type FPPBLNEEHBP, FBPIMAEAPCI CCCEIMBNION, EHNPIHOENLH[] ACLIIFLKBCL, bool PCIDPKDCIDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4A908A0", Offset = "0x4A8FCA0", VA = "0x184A908A0")]
	private static bool MPMDCEIFKHI(ConstructorInfo MGKMNEDCOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4A906F0", Offset = "0x4A8FAF0", VA = "0x184A906F0")]
	private static bool LIMKGJGLMMJ(Type FPPBLNEEHBP, out Type KMOIPKIFIMA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void CHHIIGDGDED<T>(byte[][] BFJEBAMBCJL, object[] BAOIONLGHNC, ref MJKLEAPCGEK MPHPGBJPKDG, T IGDJJEECDAF, EBGILPKEKAA CNJODEMPCDA);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T EAFCOBNIELE<T>(object[] BAOIONLGHNC, ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA CNJODEMPCDA);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class GICPAPOJCGF<T> : global::AHKHKGPFFMH<T>, PFBBNCPHAMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] BFJEBAMBCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] PFEKELNEFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] PMDONGDFBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly global::CHHIIGDGDED<T> EAGCMHBCBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly global::EAFCOBNIELE<T> MIPKBJHHLOO;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x279BEF0", Offset = "0x279B2F0", VA = "0x18279BEF0")]
	public GICPAPOJCGF(byte[][] BFJEBAMBCJL, object[] PFEKELNEFOD, object[] PMDONGDFBDI, global::CHHIIGDGDED<T> EAGCMHBCBKG, global::EAFCOBNIELE<T> MIPKBJHHLOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x279BD40", Offset = "0x279B140", VA = "0x18279BD40", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, T IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x279BE20", Offset = "0x279B220", VA = "0x18279BE20", Slot = "5")]
	public T LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class IDHNHLPHLJM : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class DEEEMNOFJLN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x27F71C0", Offset = "0x27F65C0", VA = "0x1827F71C0")]
		static DEEEMNOFJLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private IDHNHLPHLJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class FEKNFBEIEBK : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class MELKGGNKGCH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x29BED90", Offset = "0x29BE190", VA = "0x1829BED90")]
		static MELKGGNKGCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private FEKNFBEIEBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class FONFCHIAPJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly EBGILPKEKAA[] NHOBLCHGFAC;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class DLDKKNIAIMB : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class FIOKHNJLGIG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x25CACC0", Offset = "0x25CA0C0", VA = "0x1825CACC0")]
		static FIOKHNJLGIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class BFNLKNKOHDL : EBGILPKEKAA
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class NNNNLBGFOGJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x39D42A0", Offset = "0x39D36A0", VA = "0x1839D42A0")]
			static NNNNLBGFOGJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly EBGILPKEKAA KGKEDLDKCKD;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly EBGILPKEKAA[] PHEMDKICCKF;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		private BFNLKNKOHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
		public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly global::AHKHKGPFFMH<object> OOFDMDFPMKH;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private DLDKKNIAIMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class DLNADOGBONA : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class GOLDGEHIFOH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x417A8A0", Offset = "0x4179CA0", VA = "0x18417A8A0")]
		static GOLDGEHIFOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class NIMOAEJLNPH : EBGILPKEKAA
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class HELJGAPDODO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x2FC9A60", Offset = "0x2FC8E60", VA = "0x182FC9A60")]
			static HELJGAPDODO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly EBGILPKEKAA KGKEDLDKCKD;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly EBGILPKEKAA[] PHEMDKICCKF;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		private NIMOAEJLNPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
		public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly global::AHKHKGPFFMH<object> OOFDMDFPMKH;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private DLNADOGBONA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class OFMIMGAGMOA : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class FDLJDGHHNEN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2532590", Offset = "0x2531990", VA = "0x182532590")]
		static FDLJDGHHNEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class MKMALILEOON : EBGILPKEKAA
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class BPGIFEJLJJB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x2396290", Offset = "0x2395690", VA = "0x182396290")]
			static BPGIFEJLJJB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly EBGILPKEKAA KGKEDLDKCKD;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly EBGILPKEKAA[] PHEMDKICCKF;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		private MKMALILEOON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
		public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly global::AHKHKGPFFMH<object> OOFDMDFPMKH;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private OFMIMGAGMOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class PPBPMHLEICP : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class HOFCPHJJDBD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2A54E00", Offset = "0x2A54200", VA = "0x182A54E00")]
		static HOFCPHJJDBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class POKGIENJCMD : EBGILPKEKAA
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class IPFFFNCOOKF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x1F031B0", Offset = "0x1F025B0", VA = "0x181F031B0")]
			static IPFFFNCOOKF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly EBGILPKEKAA KGKEDLDKCKD;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly EBGILPKEKAA[] PHEMDKICCKF;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		private POKGIENJCMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
		public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::AHKHKGPFFMH<object> OOFDMDFPMKH;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private PPBPMHLEICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class OLMJFPGOOEE : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class OLKMEOPJHPK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x37BC440", Offset = "0x37BB840", VA = "0x1837BC440")]
		static OLKMEOPJHPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class DJOEKMIGPDO : EBGILPKEKAA
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class AKGCJOMMJKL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x30FBC00", Offset = "0x30FB000", VA = "0x1830FBC00")]
			static AKGCJOMMJKL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly EBGILPKEKAA KGKEDLDKCKD;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly EBGILPKEKAA[] PHEMDKICCKF;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		private DJOEKMIGPDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
		public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly global::AHKHKGPFFMH<object> OOFDMDFPMKH;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private OLMJFPGOOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class GMKFLDNMEIC : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class HKMHJLOEHLM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A44090", Offset = "0x2A43490", VA = "0x182A44090")]
		static HKMHJLOEHLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class LJAEPCHDAIC : EBGILPKEKAA
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class AINNLDDHGDM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x38C9890", Offset = "0x38C8C90", VA = "0x1838C9890")]
			static AINNLDDHGDM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly EBGILPKEKAA KGKEDLDKCKD;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly EBGILPKEKAA[] PHEMDKICCKF;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		private LJAEPCHDAIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
		public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly global::AHKHKGPFFMH<object> OOFDMDFPMKH;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private GMKFLDNMEIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class NFFFCHPIICH : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class PKMPNBPCAGI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2DBC640", Offset = "0x2DBBA40", VA = "0x182DBC640")]
		static PKMPNBPCAGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class IMCKKKEOMNN : EBGILPKEKAA
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class EKCJNEEKIHO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2444800", Offset = "0x2443C00", VA = "0x182444800")]
			static EKCJNEEKIHO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly EBGILPKEKAA KGKEDLDKCKD;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly EBGILPKEKAA[] PHEMDKICCKF;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		private IMCKKKEOMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
		public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly global::AHKHKGPFFMH<object> OOFDMDFPMKH;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private NFFFCHPIICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class PGKPGKCADFL : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class OEPDOEMDMII<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3A56BA0", Offset = "0x3A55FA0", VA = "0x183A56BA0")]
		static OEPDOEMDMII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class HLMMEDMLOKK : EBGILPKEKAA
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class CLOAAFJLGAN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x277E6F0", Offset = "0x277DAF0", VA = "0x18277E6F0")]
			static CLOAAFJLGAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly EBGILPKEKAA KGKEDLDKCKD;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly EBGILPKEKAA[] PHEMDKICCKF;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		private HLMMEDMLOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
		public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly global::AHKHKGPFFMH<object> OOFDMDFPMKH;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private PGKPGKCADFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class GIDPOIPHEFO : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class KIAJBHAIPCE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x32BA7D0", Offset = "0x32B9BD0", VA = "0x1832BA7D0")]
		static KIAJBHAIPCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class PDAIBCEJFBG : EBGILPKEKAA
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class HNAFEKBBOPE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x2A4DDD0", Offset = "0x2A4D1D0", VA = "0x182A4DDD0")]
			static HNAFEKBBOPE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly EBGILPKEKAA KGKEDLDKCKD;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly EBGILPKEKAA[] PHEMDKICCKF;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		private PDAIBCEJFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
		public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly global::AHKHKGPFFMH<object> OOFDMDFPMKH;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private GIDPOIPHEFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class LFGENHEIJEM : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class FPMFHHNNCPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x25E1800", Offset = "0x25E0C00", VA = "0x1825E1800")]
		static FPMFHHNNCPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class IBLNPGFEGOI : EBGILPKEKAA
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class IDFNEODALGI<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x1BAEDE0", Offset = "0x1BAE1E0", VA = "0x181BAEDE0")]
			static IDFNEODALGI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly EBGILPKEKAA KGKEDLDKCKD;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly EBGILPKEKAA[] PHEMDKICCKF;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		private IBLNPGFEGOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
		public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::AHKHKGPFFMH<object> OOFDMDFPMKH;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private LFGENHEIJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class INCAPDELEHG : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class PNGEOBPBNPI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2DC8100", Offset = "0x2DC7500", VA = "0x182DC8100")]
		static PNGEOBPBNPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class AAJEKMCNGLB : EBGILPKEKAA
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class NMLPJILBNIG<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x39CFD30", Offset = "0x39CF130", VA = "0x1839CFD30")]
			static NMLPJILBNIG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly EBGILPKEKAA KGKEDLDKCKD;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly EBGILPKEKAA[] PHEMDKICCKF;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		private AAJEKMCNGLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
		public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly global::AHKHKGPFFMH<object> OOFDMDFPMKH;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private INCAPDELEHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class MMNDOMCCBIN : EBGILPKEKAA
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class GHLBJGEICGI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2798A30", Offset = "0x2797E30", VA = "0x182798A30")]
		static GHLBJGEICGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class GHDFLONPJAJ : EBGILPKEKAA
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class JFNCCBNDGLJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly global::AHKHKGPFFMH<T> EMOCOPNKKEA;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x345F260", Offset = "0x345E660", VA = "0x18345F260")]
			static JFNCCBNDGLJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly EBGILPKEKAA KGKEDLDKCKD;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly EBGILPKEKAA[] PHEMDKICCKF;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		private GHDFLONPJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
		public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly EBGILPKEKAA KGKEDLDKCKD;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly global::AHKHKGPFFMH<object> OOFDMDFPMKH;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	private MMNDOMCCBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBC0", Offset = "0x1F6DFC0", VA = "0x181F6EBC0", Slot = "4")]
	public global::AHKHKGPFFMH<T> IFGBJAAEBLJ<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct AAHDMFINCEK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] HNJABHOFNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int HEHPNMDAHOP;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x43A6380", Offset = "0x43A5780", VA = "0x1843A6380")]
	public AAHDMFINCEK(int FFBFONPNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x43A5F80", Offset = "0x43A5380", VA = "0x1843A5F80")]
	public void AKBMAMDKLNI(T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x43A62F0", Offset = "0x43A56F0", VA = "0x1843A62F0")]
	public T[] DGKKAOADICN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class OEBHIPCLJLB : global::FLIGIBMLBJO<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly OEBHIPCLJLB BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F97D00", Offset = "0x4F97100", VA = "0x184F97D00")]
	public OEBHIPCLJLB(int OKGHFKPIMNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class FLIGIBMLBJO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int OKGHFKPIMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object PNDFPPLAMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int HMJKJGLHFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] AMKIKCCAJHK;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x25D7D20", Offset = "0x25D7120", VA = "0x1825D7D20")]
	public FLIGIBMLBJO(int OKGHFKPIMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x25D6AE0", Offset = "0x25D5EE0", VA = "0x1825D6AE0")]
	public T[] GNJFENKNKOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x25D74B0", Offset = "0x25D68B0", VA = "0x1825D74B0")]
	public void OEDKEPNLCGN(T[] ICPECNGAFCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class IHFGIEKMHON : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class FGNPDDANGMO : IComparable<FGNPDDANGMO>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class GDDOBDCIFGN : IEnumerable<FGNPDDANGMO>, IEnumerable, IEnumerator<FGNPDDANGMO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private FGNPDDANGMO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public FGNPDDANGMO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private FGNPDDANGMO System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F4")]
				[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F6")]
				[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8EA410", Offset = "0x8E9810", VA = "0x1808EA410")]
			[DebuggerHidden]
			public GDDOBDCIFGN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x4F91220", Offset = "0x4F90620", VA = "0x184F91220", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x4F91350", Offset = "0x4F90750", VA = "0x184F91350", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x4F912B0", Offset = "0x4F906B0", VA = "0x184F912B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FGNPDDANGMO> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x4F912B0", Offset = "0x4F906B0", VA = "0x184F912B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class MFKFOFOJLJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public MFKFOFOJLJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x6A2FD0", Offset = "0x6A23D0", VA = "0x1806A2FD0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x6A2FD0", Offset = "0x6A23D0", VA = "0x1806A2FD0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly FGNPDDANGMO[] GNACONJBPHH;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] EHPHMNOEAAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong HJIIJNBEIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int KGOGAJOHGBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string LKAFDHIECNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private FGNPDDANGMO[] AEJHBGPNACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] BBHICJBKMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int LKJCGNNPEOE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool ELMNMIECKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xD83750", Offset = "0xD82B50", VA = "0x180D83750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4F91040", Offset = "0x4F90440", VA = "0x184F91040")]
		public FGNPDDANGMO(ulong FOJIGKKHICE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4F8FBA0", Offset = "0x4F8EFA0", VA = "0x184F8FBA0")]
		public FGNPDDANGMO AKBMAMDKLNI(ulong FOJIGKKHICE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4F8FE60", Offset = "0x4F8F260", VA = "0x184F8FE60")]
		public FGNPDDANGMO AKBMAMDKLNI(ulong FOJIGKKHICE, int IGDJJEECDAF, string LKAFDHIECNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4F90E00", Offset = "0x4F90200", VA = "0x184F90E00")]
		public FGNPDDANGMO NEKDJKDICGO(byte[] ENPADDIHOCB, ref int FHAPAHAAKAH, ref int HGHLPFKGGOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x4F90D80", Offset = "0x4F90180", VA = "0x184F90D80")]
		internal static int MDJNIPGIKIC(ulong[] ICPECNGAFCL, int HMJKJGLHFKE, int BFFLFOJBLOH, ulong IGDJJEECDAF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4F8FEB0", Offset = "0x4F8F2B0", VA = "0x184F8FEB0", Slot = "4")]
		public int CompareTo(FGNPDDANGMO EPJIAIAEMFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4F90D10", Offset = "0x4F90110", VA = "0x184F90D10")]
		[IteratorStateMachine(typeof(GDDOBDCIFGN))]
		public IEnumerable<FGNPDDANGMO> LPPKJPJFBCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4F8FEE0", Offset = "0x4F8F2E0", VA = "0x184F8FEE0")]
		public void EIPICIKGDPL(ILGenerator BMLHEKEEGGP, LocalBuilder ENPADDIHOCB, LocalBuilder HGHLPFKGGOF, LocalBuilder FOJIGKKHICE, Action<KeyValuePair<string, int>> HIILNCPDINH, Action NLFKBEIEBFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4F90020", Offset = "0x4F8F420", VA = "0x184F90020")]
		private static void JBOHNFOKBLC(ILGenerator BMLHEKEEGGP, LocalBuilder ENPADDIHOCB, LocalBuilder HGHLPFKGGOF, LocalBuilder FOJIGKKHICE, Action<KeyValuePair<string, int>> HIILNCPDINH, Action NLFKBEIEBFJ, FGNPDDANGMO[] AEJHBGPNACE, int LKJCGNNPEOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class LMCMEJMEKAH : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<FGNPDDANGMO> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<FGNPDDANGMO> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<FGNPDDANGMO> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private FGNPDDANGMO <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x699040", Offset = "0x698440", VA = "0x180699040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x4F94380", Offset = "0x4F93780", VA = "0x184F94380", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97F60", VA = "0x180A98B60")]
		[DebuggerHidden]
		public LMCMEJMEKAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x4F943D0", Offset = "0x4F937D0", VA = "0x184F943D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4F93E40", Offset = "0x4F93240", VA = "0x184F93E40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x4F944B0", Offset = "0x4F938B0", VA = "0x184F944B0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x4F94500", Offset = "0x4F93900", VA = "0x184F94500")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x4F94340", Offset = "0x4F93740", VA = "0x184F94340", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x4F942A0", Offset = "0x4F936A0", VA = "0x184F942A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x4F942A0", Offset = "0x4F936A0", VA = "0x184F942A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly FGNPDDANGMO NMIIAOIKHMI;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2D50", Offset = "0x4ED2150", VA = "0x184ED2D50")]
	public IHFGIEKMHON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4ED26F0", Offset = "0x4ED1AF0", VA = "0x184ED26F0")]
	public void AKBMAMDKLNI(byte[] EEMDNKKFCBK, int IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2BD0", Offset = "0x4ED1FD0", VA = "0x184ED2BD0")]
	public bool KHODPPPPMCC(ArraySegment<byte> FOJIGKKHICE, out int IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2CC0", Offset = "0x4ED20C0", VA = "0x184ED2CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2930", Offset = "0x4ED1D30", VA = "0x184ED2930")]
	private static void IKLOMFKBFNG(IEnumerable<FGNPDDANGMO> AEJHBGPNACE, StringBuilder BIOJHMCHAFL, int FGINFGKNAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2880", Offset = "0x4ED1C80", VA = "0x184ED2880", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2880", Offset = "0x4ED1C80", VA = "0x184ED2880", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2810", Offset = "0x4ED1C10", VA = "0x184ED2810")]
	[IteratorStateMachine(typeof(LMCMEJMEKAH))]
	private static IEnumerable<KeyValuePair<string, int>> GNFMNLOOPGD(IEnumerable<FGNPDDANGMO> AEJHBGPNACE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2C90", Offset = "0x4ED2090", VA = "0x184ED2C90")]
	public void OAENCIKEKDB(ILGenerator BMLHEKEEGGP, LocalBuilder ENPADDIHOCB, LocalBuilder HGHLPFKGGOF, LocalBuilder FOJIGKKHICE, Action<KeyValuePair<string, int>> HIILNCPDINH, Action NLFKBEIEBFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class COAKKMPNNHE
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo BPBLICJLHNF;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4A86D20", Offset = "0x4A86120", VA = "0x184A86D20")]
	public static ulong HHBLPCCHJKI(byte[] EEMDNKKFCBK, ref int FHAPAHAAKAH, ref int HGHLPFKGGOF)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class AMMNPMANMMM
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4A81D00", Offset = "0x4A81100", VA = "0x184A81D00")]
	public static void ECNINJLKKPH(ref byte[] EEMDNKKFCBK, int FHAPAHAAKAH, int NJFNJAECHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4A81BF0", Offset = "0x4A80FF0", VA = "0x184A81BF0")]
	public static void BDPBEMJFEAA(ref byte[] ICPECNGAFCL, int OOJCGOEDBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4A81AD0", Offset = "0x4A80ED0", VA = "0x184A81AD0")]
	public static byte[] ACGELPJNDFO(byte[] OHCPCHAKDAC, int OOJCGOEDBOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class KGJKHEDKNJN
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4ED84E0", Offset = "0x4ED78E0", VA = "0x184ED84E0")]
	public static bool PNCPEDMHILH(byte[] JBOIMFHDANH, int EIIOCEEHHMB, int ILJDALFDBEI, byte[] BNBLOPBGKJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class LENMDHIFIHL<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct LIHEEPLDODC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] HJIIJNBEIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T KGOGAJOHGBC;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3898060", Offset = "0x3897460", VA = "0x183898060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class AKBPPJCJCML : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public global::LENMDHIFIHL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private LIHEEPLDODC[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private LIHEEPLDODC[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x699040", Offset = "0x698440", VA = "0x180699040", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x30F9D30", Offset = "0x30F9130", VA = "0x1830F9D30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1BB2500", Offset = "0x1BB1900", VA = "0x181BB2500")]
		[DebuggerHidden]
		public AKBPPJCJCML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x38CD5F0", Offset = "0x38CC9F0", VA = "0x1838CD5F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x38CDC10", Offset = "0x38CD010", VA = "0x1838CDC10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly LIHEEPLDODC[][] KEGEMJPHLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong MKNCFEOFJGP;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x43478A0", Offset = "0x4346CA0", VA = "0x1843478A0")]
	public LENMDHIFIHL(int OAKAJHNNELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x43477E0", Offset = "0x4346BE0", VA = "0x1843477E0")]
	public LENMDHIFIHL(int OAKAJHNNELN, float HKDEMBJCIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x4341F10", Offset = "0x4341310", VA = "0x184341F10")]
	public void AKBMAMDKLNI(byte[] FOJIGKKHICE, T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x433AAE0", Offset = "0x4339EE0", VA = "0x18433AAE0")]
	private bool ADNMAIDDHHC(byte[] FOJIGKKHICE, T IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4345680", Offset = "0x4344A80", VA = "0x184345680")]
	public bool GAMCGCGFADK(ArraySegment<byte> FOJIGKKHICE, out T IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4343450", Offset = "0x4342850", VA = "0x184343450")]
	private static ulong CLELKDBOCOO(byte[] BCJCIOLMPPL, int FHAPAHAAKAH, int LKJCGNNPEOE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x24488B0", Offset = "0x2447CB0", VA = "0x1824488B0")]
	private static int HADFIOOPDNC(int MGKPENFOKHG, float HKDEMBJCIMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x43475A0", Offset = "0x43469A0", VA = "0x1843475A0", Slot = "4")]
	[IteratorStateMachine(typeof(global::LENMDHIFIHL<>.AKBPPJCJCML))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C870", Offset = "0x1D5BC70", VA = "0x181D5C870", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class MIDHJPBJPAE : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] KIJEDMANHKK;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] DGDPINKHDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int PMBJFOKHDAM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool JICOFBPAJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4EE37B0", Offset = "0x4EE2BB0", VA = "0x184EE37B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3920", Offset = "0x4EE2D20", VA = "0x184EE3920")]
	static MIDHJPBJPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3BA0", Offset = "0x4EE2FA0", VA = "0x184EE3BA0")]
	public MIDHJPBJPAE(byte[] LMLPPEBFMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3800", Offset = "0x4EE2C00", VA = "0x184EE3800")]
	public OpCode KOMPIOIGKBA()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct CJEFOBLNGJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid KGOGAJOHGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte JOJDJDOPMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte HDEJEOMKMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte KHEMAFABIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte EAGKJEDLNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte MBKADOHEFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte GKOCFMAGNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte BHNBACDNJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte DGGKPEPEACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte JCGEEJIIOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte CMBGGFNMDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte KGHBCPHEHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte OFLAMFJLALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte AEFPCCFELDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte ODPEJNNPJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte BKFEDBOKKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte CFFBEEENDJC;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] NLLKAIMOBNN;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] GCGENBFKAOF;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4A85860", Offset = "0x4A84C60", VA = "0x184A85860")]
	public CJEFOBLNGJP(ref Guid IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4A85870", Offset = "0x4A84C70", VA = "0x184A85870")]
	public CJEFOBLNGJP(ref ArraySegment<byte> NDKLIDLCGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4A855C0", Offset = "0x4A849C0", VA = "0x184A855C0")]
	private static byte DGCIGPCEOGA(byte[] EEMDNKKFCBK, int OODKHBEIFAM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4A85680", Offset = "0x4A84A80", VA = "0x184A85680")]
	private static byte LOFNOCMIOIM(byte IKDBBHHKFLJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4A84270", Offset = "0x4A83670", VA = "0x184A84270")]
	public void DDHKDCKBDDF(byte[] CCBBJEPJPEO, int FHAPAHAAKAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class NHHLHFPCHCO
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8670", Offset = "0x4EE7A70", VA = "0x184EE8670")]
	public static bool PJIPBOBBEMB(byte LAPNDBKJOMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8010", Offset = "0x4EE7410", VA = "0x184EE8010")]
	public static bool HIKHHMAAIIL(byte LAPNDBKJOMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x4EE7FA0", Offset = "0x4EE73A0", VA = "0x184EE7FA0")]
	public static sbyte HCCKHLFJAIE(byte[] EEMDNKKFCBK, int FHAPAHAAKAH, out int MFEIEIPNBLG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x4EE7760", Offset = "0x4EE6B60", VA = "0x184EE7760")]
	public static short BGDLNLHPNCC(byte[] EEMDNKKFCBK, int FHAPAHAAKAH, out int MFEIEIPNBLG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x4EE81A0", Offset = "0x4EE75A0", VA = "0x184EE81A0")]
	public static int KCKENFLPDCP(byte[] EEMDNKKFCBK, int FHAPAHAAKAH, out int MFEIEIPNBLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8080", Offset = "0x4EE7480", VA = "0x184EE8080")]
	public static long IEODFGKIPIH(byte[] EEMDNKKFCBK, int FHAPAHAAKAH, out int MFEIEIPNBLG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x4EE76F0", Offset = "0x4EE6AF0", VA = "0x184EE76F0")]
	public static byte AELANOKCOCE(byte[] EEMDNKKFCBK, int FHAPAHAAKAH, out int MFEIEIPNBLG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8600", Offset = "0x4EE7A00", VA = "0x184EE8600")]
	public static ushort OHHNFPPLEOD(byte[] EEMDNKKFCBK, int FHAPAHAAKAH, out int MFEIEIPNBLG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8680", Offset = "0x4EE7A80", VA = "0x184EE8680")]
	public static uint PPCFNIENEMK(byte[] EEMDNKKFCBK, int FHAPAHAAKAH, out int MFEIEIPNBLG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8210", Offset = "0x4EE7610", VA = "0x184EE8210")]
	public static ulong KMKHDGADMBE(byte[] EEMDNKKFCBK, int FHAPAHAAKAH, out int MFEIEIPNBLG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8320", Offset = "0x4EE7720", VA = "0x184EE8320")]
	public static float NAHPHGKPEOD(byte[] EEMDNKKFCBK, int FHAPAHAAKAH, out int MFEIEIPNBLG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8130", Offset = "0x4EE7530", VA = "0x184EE8130")]
	public static double JLLGIDGELBB(byte[] EEMDNKKFCBK, int FHAPAHAAKAH, out int MFEIEIPNBLG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x4EE77D0", Offset = "0x4EE6BD0", VA = "0x184EE77D0")]
	public static int ENHPBNIMKEK(ref byte[] CCBBJEPJPEO, int FHAPAHAAKAH, ulong IGDJJEECDAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x4EE6AC0", Offset = "0x4EE5EC0", VA = "0x184EE6AC0")]
	public static int AEKOGICGJEA(ref byte[] CCBBJEPJPEO, int FHAPAHAAKAH, long IGDJJEECDAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x4EE8390", Offset = "0x4EE7790", VA = "0x184EE8390")]
	public static bool NOHEBOOFNGA(byte[] EEMDNKKFCBK, int FHAPAHAAKAH, out int MFEIEIPNBLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class BKIBJKGHMGA
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class FGCGFDKLEHC : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8EA410", Offset = "0x8E9810", VA = "0x1808EA410")]
		[DebuggerHidden]
		public FGCGFDKLEHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x4F8F900", Offset = "0x4F8ED00", VA = "0x184F8F900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x4F8F4A0", Offset = "0x4F8E8A0", VA = "0x184F8F4A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x4F8F9F0", Offset = "0x4F8EDF0", VA = "0x184F8F9F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x4F8FA40", Offset = "0x4F8EE40", VA = "0x184F8FA40")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x4F8F8C0", Offset = "0x4F8ECC0", VA = "0x184F8F8C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x4F8F810", Offset = "0x4F8EC10", VA = "0x184F8F810", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x4F8F810", Offset = "0x4F8EC10", VA = "0x184F8F810", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class DNACMMPOFAM : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8EA410", Offset = "0x8E9810", VA = "0x1808EA410")]
		[DebuggerHidden]
		public DNACMMPOFAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x4F8DD80", Offset = "0x4F8D180", VA = "0x184F8DD80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x4F8D920", Offset = "0x4F8CD20", VA = "0x184F8D920", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4F8DE70", Offset = "0x4F8D270", VA = "0x184F8DE70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4F8DEC0", Offset = "0x4F8D2C0", VA = "0x184F8DEC0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x4F8DD40", Offset = "0x4F8D140", VA = "0x184F8DD40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x4F8DC90", Offset = "0x4F8D090", VA = "0x184F8DC90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x4F8DC90", Offset = "0x4F8D090", VA = "0x184F8DC90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x4A83640", Offset = "0x4A82A40", VA = "0x184A83640")]
	public static bool EEGPFDLEINP(this TypeInfo FPPBLNEEHBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x4A83820", Offset = "0x4A82C20", VA = "0x184A83820")]
	public static bool LPHJJNBEBJJ(this TypeInfo FPPBLNEEHBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x4A83940", Offset = "0x4A82D40", VA = "0x184A83940")]
	public static IEnumerable<PropertyInfo> PDEONKGOEDJ(this Type FPPBLNEEHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x4A83790", Offset = "0x4A82B90", VA = "0x184A83790")]
	[IteratorStateMachine(typeof(FGCGFDKLEHC))]
	private static IEnumerable<PropertyInfo> LNANNBFBCDC(Type FPPBLNEEHBP, HashSet<string> LAMDLPLJFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x4A83A10", Offset = "0x4A82E10", VA = "0x184A83A10")]
	public static IEnumerable<FieldInfo> PLHCBMKEOKL(this Type FPPBLNEEHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x4A83700", Offset = "0x4A82B00", VA = "0x184A83700")]
	[IteratorStateMachine(typeof(DNACMMPOFAM))]
	private static IEnumerable<FieldInfo> EKLIBNJCOAM(Type FPPBLNEEHBP, HashSet<string> LAMDLPLJFMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class HMAEADKOLMI
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding INJBHIGFIHO;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class BICHNOLGIKE
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x775500", Offset = "0x774900", VA = "0x180775500")]
	public static string NDOINAADPDK(string JLNFONKAKOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4A83220", Offset = "0x4A82620", VA = "0x184A83220")]
	public static string HILLAHECDNI(string JLNFONKAKOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4A83030", Offset = "0x4A82430", VA = "0x184A83030")]
	public static string DOCOCNENHGH(string JLNFONKAKOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class ELLGFIBEPCN<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class DCDOEMGDPCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type HJIIJNBEIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue KGOGAJOHGBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int DIAAECBBMDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public DCDOEMGDPCP KEADCECDCJB;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x27F2000", Offset = "0x27F1400", VA = "0x1827F2000", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x27F1EC0", Offset = "0x27F12C0", VA = "0x1827F1EC0")]
		private int IGGNICCPKKG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public DCDOEMGDPCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class ONDGJHAAFDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public ONDGJHAAFDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xD85780", Offset = "0xD84B80", VA = "0x180D85780")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private DCDOEMGDPCP[] KEGEMJPHLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int DEBAMGFBJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object CCOFMGMJFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float HKDEMBJCIMA;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x2449460", Offset = "0x2448860", VA = "0x182449460")]
	public ELLGFIBEPCN(int OAKAJHNNELN = 4, float HKDEMBJCIMA = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x24488E0", Offset = "0x2447CE0", VA = "0x1824488E0")]
	public bool INCCOKIDJLO(Type FOJIGKKHICE, TValue IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2448A30", Offset = "0x2447E30", VA = "0x182448A30")]
	public bool INCCOKIDJLO(Type FOJIGKKHICE, Func<Type, TValue> NOIGANCJPHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2448340", Offset = "0x2447740", VA = "0x182448340")]
	private bool ADNMAIDDHHC(Type FOJIGKKHICE, Func<Type, TValue> NOIGANCJPHG, out TValue DGIHPJBALBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2448D00", Offset = "0x2448100", VA = "0x182448D00")]
	private bool PJPJCEENKOE(DCDOEMGDPCP[] KEGEMJPHLGB, Type IAEOMJHHLDA, DCDOEMGDPCP MCJMKJAMCPA, Func<Type, TValue> NOIGANCJPHG, out TValue DGIHPJBALBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2448760", Offset = "0x2447B60", VA = "0x182448760")]
	public bool GAMCGCGFADK(Type FOJIGKKHICE, out TValue IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2448C20", Offset = "0x2448020", VA = "0x182448C20")]
	public TValue NLBKHCCPJFB(Type FOJIGKKHICE, Func<Type, TValue> NOIGANCJPHG)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x24488B0", Offset = "0x2447CB0", VA = "0x1824488B0")]
	private static int HADFIOOPDNC(int MGKPENFOKHG, float HKDEMBJCIMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2448CD0", Offset = "0x24480D0", VA = "0x182448CD0")]
	private static void NNDNOJGGAMD(ref DCDOEMGDPCP EBOIMGDKAHA, DCDOEMGDPCP IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2448CD0", Offset = "0x24480D0", VA = "0x182448CD0")]
	private static void NNDNOJGGAMD(ref DCDOEMGDPCP[] EBOIMGDKAHA, DCDOEMGDPCP[] IGDJJEECDAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class PMHALKLFNPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder JAKLEFOIDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder PGPGAOOHECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object PNDFPPLAMGJ;

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x4F9EE60", Offset = "0x4F9E260", VA = "0x184F9EE60")]
	public TypeBuilder EOIILGPOMBJ(string DHKKANIEGMN, TypeAttributes NJCJHHDIGIB, Type JFCNGAACNEO, Type[] NJKBHNKHJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x4F9EF30", Offset = "0x4F9E330", VA = "0x184F9EF30")]
	public PMHALKLFNPF(string HIDCDNLDAEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class KANAFCDGFHD
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x4ED7BD0", Offset = "0x4ED6FD0", VA = "0x184ED7BD0")]
	private static MethodInfo LKLJCNGIMGC(LambdaExpression INHLNOMCBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x25AC620", Offset = "0x25ABA20", VA = "0x1825AC620")]
	public static MethodInfo LLKDPIMACMM<T>(Expression<Func<T>> INHLNOMCBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x25AC620", Offset = "0x25ABA20", VA = "0x1825AC620")]
	public static MethodInfo LLKDPIMACMM<T, TR>(Expression<Func<T, TR>> INHLNOMCBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x25AC620", Offset = "0x25ABA20", VA = "0x1825AC620")]
	public static MethodInfo LLKDPIMACMM<T>(Expression<Action<T>> INHLNOMCBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x25AC620", Offset = "0x25ABA20", VA = "0x1825AC620")]
	public static MethodInfo LLKDPIMACMM<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> INHLNOMCBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x25AC570", Offset = "0x25AB970", VA = "0x1825AC570")]
	private static MemberInfo JIGPPCJCMFL<T>(Expression<T> KOEICPMBJFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x25AC630", Offset = "0x25ABA30", VA = "0x1825AC630")]
	public static PropertyInfo OJEPDKHKACO<T, TR>(Expression<Func<T, TR>> INHLNOMCBDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct FALFCLBOBIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int FNHGJOONKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool EGOJBHMHNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator BMLHEKEEGGP;

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4A89EF0", Offset = "0x4A892F0", VA = "0x184A89EF0")]
	public FALFCLBOBIO(ILGenerator BMLHEKEEGGP, int FNHGJOONKOH, bool EGOJBHMHNOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4A89E60", Offset = "0x4A89260", VA = "0x184A89E60")]
	public FALFCLBOBIO(ILGenerator BMLHEKEEGGP, int FNHGJOONKOH, Type FPPBLNEEHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x4A89E40", Offset = "0x4A89240", VA = "0x184A89E40")]
	public void BFEEFIJJEPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class IHKIMDJIHPG
{
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x4ED3820", Offset = "0x4ED2C20", VA = "0x184ED3820")]
	public static void IHHINOINOGA(this ILGenerator BMLHEKEEGGP, int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x4ED37E0", Offset = "0x4ED2BE0", VA = "0x184ED37E0")]
	public static void IHHINOINOGA(this ILGenerator BMLHEKEEGGP, LocalBuilder IBIKJNCLFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x4ED3C70", Offset = "0x4ED3070", VA = "0x184ED3C70")]
	public static void KFKAIMDFEFA(this ILGenerator BMLHEKEEGGP, int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x4ED3C30", Offset = "0x4ED3030", VA = "0x184ED3C30")]
	public static void KFKAIMDFEFA(this ILGenerator BMLHEKEEGGP, LocalBuilder IBIKJNCLFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2ED0", Offset = "0x4ED22D0", VA = "0x184ED2ED0")]
	public static void ABKBFIEMCHE(this ILGenerator BMLHEKEEGGP, int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2DC0", Offset = "0x4ED21C0", VA = "0x184ED2DC0")]
	public static void ABKBFIEMCHE(this ILGenerator BMLHEKEEGGP, LocalBuilder IBIKJNCLFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x4ED3640", Offset = "0x4ED2A40", VA = "0x184ED3640")]
	public static void EKLEHKFFGND(this ILGenerator BMLHEKEEGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4ED3650", Offset = "0x4ED2A50", VA = "0x184ED3650")]
	public static void FAFNOAEGGDF(this ILGenerator BMLHEKEEGGP, bool IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2FC0", Offset = "0x4ED23C0", VA = "0x184ED2FC0")]
	public static void AJMPLKAAIOH(this ILGenerator BMLHEKEEGGP, int IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4ED3B40", Offset = "0x4ED2F40", VA = "0x184ED3B40")]
	public static void JFPBMLOEIAC(this ILGenerator BMLHEKEEGGP, Type FPPBLNEEHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4ED3F30", Offset = "0x4ED3330", VA = "0x184ED3F30")]
	public static void OLPGCKCOGPF(this ILGenerator BMLHEKEEGGP, Type FPPBLNEEHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x4ED3410", Offset = "0x4ED2810", VA = "0x184ED3410")]
	public static void BFIDHMBMNEO(this ILGenerator BMLHEKEEGGP, int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x4ED3660", Offset = "0x4ED2A60", VA = "0x184ED3660")]
	public static void GDAKACPOLOA(this ILGenerator BMLHEKEEGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x4ED3A50", Offset = "0x4ED2E50", VA = "0x184ED3A50")]
	public static void JEDDNKLBBCC(this ILGenerator BMLHEKEEGGP, int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x4ED36E0", Offset = "0x4ED2AE0", VA = "0x184ED36E0")]
	public static void HCIPJAAMGGA(this ILGenerator BMLHEKEEGGP, MethodInfo EAJICJBAIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x4ED3EA0", Offset = "0x4ED32A0", VA = "0x184ED3EA0")]
	public static void NKPNMJDIAHI(this ILGenerator BMLHEKEEGGP, FieldInfo LDBBAOLNODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x4ED3FE0", Offset = "0x4ED33E0", VA = "0x184ED3FE0")]
	public static void OMONBJOFJDE(this ILGenerator BMLHEKEEGGP, ulong IGDJJEECDAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class OCJJGALKMFE
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class FGIAGIIDNAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public FGIAGIIDNAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x4F8FA90", Offset = "0x4F8EE90", VA = "0x184F8FA90")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo OHOHGCPBPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo GILMLIDAMBO;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string GAELEJJHLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x697530", VA = "0x180698130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string MJBKADKPBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x697540", VA = "0x180698140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DJJJODABKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x4F96EC0", Offset = "0x4F962C0", VA = "0x184F96EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ABNODLOGBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6933D0", Offset = "0x6927D0", VA = "0x1806933D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x784640", Offset = "0x783A40", VA = "0x180784640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool AEFOFOEEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6933E0", Offset = "0x6927E0", VA = "0x1806933E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xD0F1B0", Offset = "0xD0E5B0", VA = "0x180D0F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type AKDIGOBFKOF
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6BA1C0", Offset = "0x6B95C0", VA = "0x1806BA1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo DHGCHGJIDJF
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x710AE0", Offset = "0x70FEE0", VA = "0x180710AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo JEJMHDKFDAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x67F570", Offset = "0x67E970", VA = "0x18067F570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x67F590", Offset = "0x67E990", VA = "0x18067F590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo GJPCJILGJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x67F580", Offset = "0x67E980", VA = "0x18067F580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x67F5A0", Offset = "0x67E9A0", VA = "0x18067F5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4F972B0", Offset = "0x4F966B0", VA = "0x184F972B0")]
	protected OCJJGALKMFE(Type FPPBLNEEHBP, string DHKKANIEGMN, string DJJLKKBGDFN, bool BHJNOKKCBFA, bool GOGFKGDLNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x4F97330", Offset = "0x4F96730", VA = "0x184F97330")]
	public OCJJGALKMFE(FieldInfo CCCEIMBNION, string DHKKANIEGMN, bool JFGBJMGHJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x4F97100", Offset = "0x4F96500", VA = "0x184F97100")]
	public OCJJGALKMFE(PropertyInfo CCCEIMBNION, string DHKKANIEGMN, bool JFGBJMGHJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x4F96F90", Offset = "0x4F96390", VA = "0x184F96F90")]
	private static MethodInfo NGOHCFNMIBJ(MemberInfo CCCEIMBNION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4C70", Offset = "0x1FB4070", VA = "0x181FB4C70")]
	public T LJHAGBAFBCD<T>(bool NMGJAPDCLDP) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x4F96E00", Offset = "0x4F96200", VA = "0x184F96E00", Slot = "4")]
	public virtual void EFOHIKMDANL(ILGenerator BMLHEKEEGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x4F96ED0", Offset = "0x4F962D0", VA = "0x184F96ED0", Slot = "5")]
	public virtual void ILLMEILCNFN(ILGenerator BMLHEKEEGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class AMBMGHOPGMI : OCJJGALKMFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string ONIJDMPCFDD;

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x4A81A10", Offset = "0x4A80E10", VA = "0x184A81A10")]
	public AMBMGHOPGMI(string DHKKANIEGMN, string ONIJDMPCFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x4A81910", Offset = "0x4A80D10", VA = "0x184A81910", Slot = "4")]
	public override void EFOHIKMDANL(ILGenerator BMLHEKEEGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x4A819D0", Offset = "0x4A80DD0", VA = "0x184A819D0", Slot = "5")]
	public override void ILLMEILCNFN(ILGenerator BMLHEKEEGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class ODFIDKCBBNP : OCJJGALKMFE
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo FGBMKJGAPJG;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo INFAANOHNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal FALFCLBOBIO NILHCCGCGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal FALFCLBOBIO FJIEJEHEDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal FALFCLBOBIO BAIPJNGPBIK;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x4F97BC0", Offset = "0x4F96FC0", VA = "0x184F97BC0")]
	public ODFIDKCBBNP(string DHKKANIEGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x4F97560", Offset = "0x4F96960", VA = "0x184F97560", Slot = "4")]
	public override void EFOHIKMDANL(ILGenerator BMLHEKEEGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x4F97630", Offset = "0x4F96A30", VA = "0x184F97630", Slot = "5")]
	public override void ILLMEILCNFN(ILGenerator BMLHEKEEGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x4F97440", Offset = "0x4F96840", VA = "0x184F97440")]
	public void CAILCLFAGEN(ILGenerator BMLHEKEEGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class FBPIMAEAPCI
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type AKDIGOBFKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x697530", VA = "0x180698130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool LCFJNIHECNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6928D0", Offset = "0x691CD0", VA = "0x1806928D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6B4000", Offset = "0x6B3400", VA = "0x1806B4000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool GNAHKOFKHEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x80FFB0", Offset = "0x80F3B0", VA = "0x18080FFB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xCDE6A0", Offset = "0xCDDAA0", VA = "0x180CDE6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo NPHLAAFHDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x679130", Offset = "0x678530", VA = "0x180679130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public OCJJGALKMFE[] JHIGMEDHLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6BA1C0", Offset = "0x6B95C0", VA = "0x1806BA1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public OCJJGALKMFE[] NFNBEMELKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x710AE0", Offset = "0x70FEE0", VA = "0x180710AE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A8A020", Offset = "0x4A89420", VA = "0x184A8A020")]
	public FBPIMAEAPCI(Type FPPBLNEEHBP, Func<string, string> KOLNBEBCJAN, bool JFGBJMGHJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x4A89F30", Offset = "0x4A89330", VA = "0x184A89F30")]
	private static bool GOEPJHPDIHM(IEnumerator<ConstructorInfo> KHEJIHIPOGJ, ref ConstructorInfo OOAJDNIGMFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct NDBBCDKMADF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong GBBIKLIFAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int PNJNNEOHMAF;

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x1D57F80", Offset = "0x1D57380", VA = "0x181D57F80")]
	public NDBBCDKMADF(ulong EJIJGPIDNGH, int FKGJOBDCLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5FC0", Offset = "0x4EE53C0", VA = "0x184EE5FC0")]
	public void JJFLNBCBAPP(ref NDBBCDKMADF EPJIAIAEMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5E90", Offset = "0x4EE5290", VA = "0x184EE5E90")]
	public static NDBBCDKMADF CCGCOBDHOCA(ref NDBBCDKMADF GHJDMBPGMHF, ref NDBBCDKMADF IKDBBHHKFLJ)
	{
		return default(NDBBCDKMADF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5EA0", Offset = "0x4EE52A0", VA = "0x184EE5EA0")]
	public void FPEBOLJHNDD(ref NDBBCDKMADF EPJIAIAEMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5DF0", Offset = "0x4EE51F0", VA = "0x184EE5DF0")]
	public static NDBBCDKMADF BBDOIGKAFMI(ref NDBBCDKMADF GHJDMBPGMHF, ref NDBBCDKMADF IKDBBHHKFLJ)
	{
		return default(NDBBCDKMADF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5F80", Offset = "0x4EE5380", VA = "0x184EE5F80")]
	public void HELHBBPBMOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5F30", Offset = "0x4EE5330", VA = "0x184EE5F30")]
	public static NDBBCDKMADF HELHBBPBMOJ(ref NDBBCDKMADF GHJDMBPGMHF)
	{
		return default(NDBBCDKMADF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct DNBHLKOOHDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] CCBBJEPJPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int FHAPAHAAKAH;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7775B0", Offset = "0x7769B0", VA = "0x1807775B0")]
	public DNBHLKOOHDF(byte[] CCBBJEPJPEO, int EFKMIDDCAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4A887C0", Offset = "0x4A87BC0", VA = "0x184A887C0")]
	public void KOJJNLJMAMK(byte IFGCPKEMIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4A886A0", Offset = "0x4A87AA0", VA = "0x184A886A0")]
	public void ANHINHOBHPG(byte[] IFGCPKEMIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x4A889D0", Offset = "0x4A87DD0", VA = "0x184A889D0")]
	public void MGHIECCGPAP(byte[] IFGCPKEMIBB, int BFFLFOJBLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x4A88920", Offset = "0x4A87D20", VA = "0x184A88920")]
	public void MGHIECCGPAP(byte[] IFGCPKEMIBB, int BKLFOLNGODN, int BFFLFOJBLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x4A88740", Offset = "0x4A87B40", VA = "0x184A88740")]
	public void BNLPKAAJMGO(byte LAPNDBKJOMI, int LKJCGNNPEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x4A88820", Offset = "0x4A87C20", VA = "0x184A88820")]
	public void KPCPONNMCGH(string IFGCPKEMIBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class LMBNFCKAEOF
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum HPPPDNJCEDI
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum JACNFGKHKJG
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum HLFAMGFKLKJ
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
	private static byte[] BGFLELEKDLJ;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] FPEOHILPCAL;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] LAIOOOCOLLA;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] OHKHGFDLLPG;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly HLFAMGFKLKJ KNKJKCJLMKI;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char NLOFDGHBPHB;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int JKJGAKMBCHI;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int AJFBCDILJJE;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] BMICAIHFHNG;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x4EDEFA0", Offset = "0x4EDE3A0", VA = "0x184EDEFA0")]
	private static byte[] GOJJAHNLIJE(int DEBAMGFBJEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x4EDF7C0", Offset = "0x4EDEBC0", VA = "0x184EDF7C0")]
	private static byte[] IOHHLDMLCEO(int DEBAMGFBJEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x4EE02A0", Offset = "0x4EDF6A0", VA = "0x184EE02A0")]
	public static int ONGENMBNOAE(ref byte[] CCBBJEPJPEO, int FHAPAHAAKAH, float IGDJJEECDAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x4EE0180", Offset = "0x4EDF580", VA = "0x184EE0180")]
	public static int ONGENMBNOAE(ref byte[] CCBBJEPJPEO, int FHAPAHAAKAH, double IGDJJEECDAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x4EDF080", Offset = "0x4EDE480", VA = "0x184EDF080")]
	private static bool HMECCBLBPKP(byte[] CCBBJEPJPEO, int BFFLFOJBLOH, ulong HECKLJPCGDP, ulong KIBGFMGGABE, ulong HGHLPFKGGOF, ulong LANDEAEPNBF, ulong IHFIOOAENEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x4EDFBC0", Offset = "0x4EDEFC0", VA = "0x184EDFBC0")]
	private static void LGKNPMCFIDE(uint NKCDFHIBFFM, int HKAADLGGAME, out uint NLKONPCEMBJ, out int NDPEIMBPBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x4EDE7E0", Offset = "0x4EDDBE0", VA = "0x184EDE7E0")]
	private static bool DNCNFBGCBFF(NDBBCDKMADF AAEBHDCPNMH, NDBBCDKMADF NBBEJJDNGHM, NDBBCDKMADF LAIHOOPMPOM, byte[] CCBBJEPJPEO, out int BFFLFOJBLOH, out int PFBAPKJNNHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x4EDFCE0", Offset = "0x4EDF0E0", VA = "0x184EDFCE0")]
	private static bool NMAMCIFHPBI(double FHHDDMKIIBK, HPPPDNJCEDI JHDOIDGIHDG, byte[] CCBBJEPJPEO, out int BFFLFOJBLOH, out int HMGJGKLDIFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x4EDE6D0", Offset = "0x4EDDAD0", VA = "0x184EDE6D0")]
	private static bool DBKHPMBOGPL(double FHHDDMKIIBK, HPPPDNJCEDI JHDOIDGIHDG, byte[] CCBBJEPJPEO, out int BFFLFOJBLOH, out int FEONLPNDKGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4EDFA30", Offset = "0x4EDEE30", VA = "0x184EDFA30")]
	private static bool LFANALPKAAC(double IGDJJEECDAF, ref DNBHLKOOHDF FGJHMKMAPKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x4EDF180", Offset = "0x4EDE580", VA = "0x184EDF180")]
	private static bool ICKANBLMFNM(double IGDJJEECDAF, ref DNBHLKOOHDF FGJHMKMAPKO, JACNFGKHKJG JHDOIDGIHDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4EDE4F0", Offset = "0x4EDD8F0", VA = "0x184EDE4F0")]
	private static void BMOEDMGIKON(byte[] KHAPPKBEMMP, int BFFLFOJBLOH, int FEONLPNDKGN, int BBBHCHBKDCG, ref DNBHLKOOHDF FGJHMKMAPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4EDECA0", Offset = "0x4EDE0A0", VA = "0x184EDECA0")]
	private static void EOCPJFKACCL(byte[] KHAPPKBEMMP, int BFFLFOJBLOH, int FKGJOBDCLCG, ref DNBHLKOOHDF FGJHMKMAPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4EDF8A0", Offset = "0x4EDECA0", VA = "0x184EDF8A0")]
	private static bool KPJKEHCLABG(double FHHDDMKIIBK, JACNFGKHKJG JHDOIDGIHDG, int IEOGGNBPDID, byte[] HPAJAGFKHEO, out bool LMPFJIBGBDG, out int BFFLFOJBLOH, out int COCHOPELBHG)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct PILGOCIIFMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double BNEELLCBKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong HIECCHMMFFP;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct FCGIDKEBKEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float GBBIKLIFAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint LMBNCJAFHAG;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct HBCLKDJAIBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong FENHCCGGFAF;

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0E40", Offset = "0x4ED0240", VA = "0x184ED0E40")]
	public HBCLKDJAIBE(double BNEELLCBKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0DA0", Offset = "0x4ED01A0", VA = "0x184ED0DA0")]
	public HBCLKDJAIBE(NDBBCDKMADF BNEELLCBKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4ED07F0", Offset = "0x4ECFBF0", VA = "0x184ED07F0")]
	public NDBBCDKMADF AJNMCAFNGJE()
	{
		return default(NDBBCDKMADF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0870", Offset = "0x4ECFC70", VA = "0x184ED0870")]
	public NDBBCDKMADF AKGGMCMMMBH()
	{
		return default(NDBBCDKMADF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000")]
	public ulong JILEPOKMCNL()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0CA0", Offset = "0x4ED00A0", VA = "0x184ED0CA0")]
	public double OGKFDDCIBDB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0950", Offset = "0x4ECFD50", VA = "0x184ED0950")]
	public double DPOANGKLKEK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0C70", Offset = "0x4ED0070", VA = "0x184ED0C70")]
	public int OADLOKCNAMC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0C40", Offset = "0x4ED0040", VA = "0x184ED0C40")]
	public ulong NFCIAHGJANJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0A10", Offset = "0x4ECFE10", VA = "0x184ED0A10")]
	public bool GECCEEMAFGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0D80", Offset = "0x4ED0180", VA = "0x184ED0D80")]
	public bool OJOGJLINADB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x4ED09E0", Offset = "0x4ECFDE0", VA = "0x184ED09E0")]
	public bool EOANGGDIPLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0920", Offset = "0x4ECFD20", VA = "0x184ED0920")]
	public bool DGHAHBIEDLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x4ED07D0", Offset = "0x4ECFBD0", VA = "0x184ED07D0")]
	public int AELOFBHNEBJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0A50", Offset = "0x4ECFE50", VA = "0x184ED0A50")]
	public void LKHCEHONFEH(out NDBBCDKMADF MDKKGENEJNA, out NDBBCDKMADF GCLDBBEAPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0D30", Offset = "0x4ED0130", VA = "0x184ED0D30")]
	public bool OJLNACFICEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0A40", Offset = "0x4ECFE40", VA = "0x184ED0A40")]
	public double IGDJJEECDAF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0900", Offset = "0x4ECFD00", VA = "0x184ED0900")]
	public static int COKCNHMDION(int MLCOIKLDGAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0A30", Offset = "0x4ECFE30", VA = "0x184ED0A30")]
	public static double IDEPJMBPOLJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0BA0", Offset = "0x4ECFFA0", VA = "0x184ED0BA0")]
	public static ulong NAFBIGHAIMO(NDBBCDKMADF NCGBNHCPDCI)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct DNANIJECBIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint CLHEKFPCFEL;

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2CD3D50", Offset = "0x2CD3150", VA = "0x182CD3D50")]
	public DNANIJECBIP(float GBBIKLIFAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4A88440", Offset = "0x4A87840", VA = "0x184A88440")]
	public NDBBCDKMADF AJNMCAFNGJE()
	{
		return default(NDBBCDKMADF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x729E20", Offset = "0x729220", VA = "0x180729E20")]
	public uint AKOMBGHLJHA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4A88640", Offset = "0x4A87A40", VA = "0x184A88640")]
	public int OADLOKCNAMC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x4A88620", Offset = "0x4A87A20", VA = "0x184A88620")]
	public uint NFCIAHGJANJ()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x4A884B0", Offset = "0x4A878B0", VA = "0x184A884B0")]
	public bool GECCEEMAFGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4A884C0", Offset = "0x4A878C0", VA = "0x184A884C0")]
	public void LKHCEHONFEH(out NDBBCDKMADF MDKKGENEJNA, out NDBBCDKMADF GCLDBBEAPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x4A88660", Offset = "0x4A87A60", VA = "0x184A88660")]
	public bool OJLNACFICEE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct NNKLHGFNACM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong EJIJGPIDNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short DCFJLLINMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short HMGJGKLDIFI;

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x4F96BC0", Offset = "0x4F95FC0", VA = "0x184F96BC0")]
	public NNKLHGFNACM(ulong EJIJGPIDNGH, short DCFJLLINMCA, short HMGJGKLDIFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class LHMKLEPJBIG
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly NNKLHGFNACM[] GPPNDBGKCLL;

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x4EDC600", Offset = "0x4EDBA00", VA = "0x184EDC600")]
	public static void PIJOIGFLPBJ(int OACBHLDINBB, int PAKFLNPAPLG, out NDBBCDKMADF NLKONPCEMBJ, out int HMGJGKLDIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x4EDC510", Offset = "0x4EDB910", VA = "0x184EDC510")]
	public static void LJLKFGKNKGD(int JPADGFJMAAB, out NDBBCDKMADF NLKONPCEMBJ, out int NLBFAFKMDJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct LOPLFPCEKEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] EEMDNKKFCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int BKLFOLNGODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int CIFDNAKEGDN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x4EE1090", Offset = "0x4EE0490", VA = "0x184EE1090")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xCCCD80", Offset = "0xCCC180", VA = "0x180CCCD80")]
	public LOPLFPCEKEB(byte[] EEMDNKKFCBK, int BKLFOLNGODN, int BFFLFOJBLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x770A40", Offset = "0x76FE40", VA = "0x180770A40")]
	public int BFFLFOJBLOH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4EE1030", Offset = "0x4EE0430", VA = "0x184EE1030")]
	public LOPLFPCEKEB DOHIALIJIPI(int JOEHIOLFBGJ, int IJAPHJMEHJM)
	{
		return default(LOPLFPCEKEB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class IOOGPEKIBIK
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] BFADPNADGGC;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] HPDLOPDFJLM;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int MFPAHODLOPH;

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4ED5090", Offset = "0x4ED4490", VA = "0x184ED5090")]
	private static byte[] ACLLKGAPPPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4ED6A30", Offset = "0x4ED5E30", VA = "0x184ED6A30")]
	private static LOPLFPCEKEB NPMCLMFPCCA(LOPLFPCEKEB CCBBJEPJPEO)
	{
		return default(LOPLFPCEKEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4ED5A90", Offset = "0x4ED4E90", VA = "0x184ED5A90")]
	private static LOPLFPCEKEB DKBIHOKKIAO(LOPLFPCEKEB CCBBJEPJPEO)
	{
		return default(LOPLFPCEKEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4ED6980", Offset = "0x4ED5D80", VA = "0x184ED6980")]
	private static void HJLADHLCALA(LOPLFPCEKEB CCBBJEPJPEO, int FKGJOBDCLCG, byte[] NEJGNJFJLGO, out int JOPFPPHCPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4ED64F0", Offset = "0x4ED58F0", VA = "0x184ED64F0")]
	private static void GILIPCPMIKM(LOPLFPCEKEB CCBBJEPJPEO, int FKGJOBDCLCG, byte[] EBKFICHAEEM, int PNPNNNDAPOJ, out LOPLFPCEKEB PLODFOKFJHH, out int HOAGDEMOHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x4ED6180", Offset = "0x4ED5580", VA = "0x184ED6180")]
	private static ulong FBILLIODNJG(LOPLFPCEKEB CCBBJEPJPEO, out int HNGGNECFNGF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4ED6810", Offset = "0x4ED5C10", VA = "0x184ED6810")]
	private static void HDPPHBIEGCB(LOPLFPCEKEB CCBBJEPJPEO, out NDBBCDKMADF MHKNFNJAIIH, out int KBBFGPCIHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x4ED5B70", Offset = "0x4ED4F70", VA = "0x184ED5B70")]
	private static bool EIOIJGMAPOF(LOPLFPCEKEB PLODFOKFJHH, int FKGJOBDCLCG, out double MHKNFNJAIIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x4ED5FF0", Offset = "0x4ED53F0", VA = "0x184ED5FF0")]
	private static NDBBCDKMADF ELPKAKMNFEN(int FKGJOBDCLCG)
	{
		return default(NDBBCDKMADF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x4ED52C0", Offset = "0x4ED46C0", VA = "0x184ED52C0")]
	private static bool BDMHLNHFIND(LOPLFPCEKEB CCBBJEPJPEO, int FKGJOBDCLCG, out double MHKNFNJAIIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x4ED5180", Offset = "0x4ED4580", VA = "0x184ED5180")]
	private static bool AHNKGFLOPFN(LOPLFPCEKEB PLODFOKFJHH, int FKGJOBDCLCG, out double GGPOBONIKEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x4ED5970", Offset = "0x4ED4D70", VA = "0x184ED5970")]
	public static double? DHFCHMKKJCG(LOPLFPCEKEB CCBBJEPJPEO, int FKGJOBDCLCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x4ED6210", Offset = "0x4ED5610", VA = "0x184ED6210")]
	public static float? FEIOAKDKLML(LOPLFPCEKEB CCBBJEPJPEO, int FKGJOBDCLCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct IBPOLIDDJPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] CCBBJEPJPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int FHAPAHAAKAH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte KGOGAJOHGBC
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x4ED2290", Offset = "0x4ED1690", VA = "0x184ED2290")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7775B0", Offset = "0x7769B0", VA = "0x1807775B0")]
	public IBPOLIDDJPJ(byte[] CCBBJEPJPEO, int FHAPAHAAKAH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x4ED23C0", Offset = "0x4ED17C0", VA = "0x184ED23C0")]
	public static IBPOLIDDJPJ HGELCKEHIJP(IBPOLIDDJPJ LKINCHDLDIG)
	{
		return default(IBPOLIDDJPJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x4ED22D0", Offset = "0x4ED16D0", VA = "0x184ED22D0")]
	public static IBPOLIDDJPJ CJKGECOCJLM(IBPOLIDDJPJ LKINCHDLDIG, int BFFLFOJBLOH)
	{
		return default(IBPOLIDDJPJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x4ED24E0", Offset = "0x4ED18E0", VA = "0x184ED24E0")]
	public static int OKEHOEDNOBN(IBPOLIDDJPJ LBABLKMFGKM, IBPOLIDDJPJ MGCAIGBBIIM)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2470", Offset = "0x4ED1870", VA = "0x184ED2470")]
	public static bool LPAHFDMKICD(IBPOLIDDJPJ LBABLKMFGKM, IBPOLIDDJPJ MGCAIGBBIIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2270", Offset = "0x4ED1670", VA = "0x184ED2270")]
	public static bool AFMDFHOMNJI(IBPOLIDDJPJ LBABLKMFGKM, IBPOLIDDJPJ MGCAIGBBIIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2420", Offset = "0x4ED1820", VA = "0x184ED2420")]
	public static bool LPAHFDMKICD(IBPOLIDDJPJ LBABLKMFGKM, char MGCAIGBBIIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2220", Offset = "0x4ED1620", VA = "0x184ED2220")]
	public static bool AFMDFHOMNJI(IBPOLIDDJPJ LBABLKMFGKM, char MGCAIGBBIIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2220", Offset = "0x4ED1620", VA = "0x184ED2220")]
	public static bool AFMDFHOMNJI(IBPOLIDDJPJ LBABLKMFGKM, byte MGCAIGBBIIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x4ED23D0", Offset = "0x4ED17D0", VA = "0x184ED23D0")]
	public static bool KBOBGOAKGEM(IBPOLIDDJPJ LBABLKMFGKM, char MGCAIGBBIIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2320", Offset = "0x4ED1720", VA = "0x184ED2320")]
	public static bool DHJECDPIOKB(IBPOLIDDJPJ LBABLKMFGKM, char MGCAIGBBIIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2370", Offset = "0x4ED1770", VA = "0x184ED2370")]
	public static bool FAMFKFKDJNO(IBPOLIDDJPJ LBABLKMFGKM, char MGCAIGBBIIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2490", Offset = "0x4ED1890", VA = "0x184ED2490")]
	public static bool NDAHMAOHMEM(IBPOLIDDJPJ LBABLKMFGKM, char MGCAIGBBIIM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class AFEFNKLDIKB
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] ONCPBKNAFBK;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] FOFBOMJHPFN;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] LAIOOOCOLLA;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] OHKHGFDLLPG;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] EPILBJPIDKO;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int EEOCGKFIJEN;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] HPLCMPBMOBG;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int JCHOAINKENC;

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x4A7FD80", Offset = "0x4A7F180", VA = "0x184A7FD80")]
	private static byte[] COIOHHFAGII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x4A7FC90", Offset = "0x4A7F090", VA = "0x184A7FC90")]
	private static byte[] BOLKPENEOAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x4A81020", Offset = "0x4A80420", VA = "0x184A81020")]
	public static double JLENJEMEMKO(byte[] CCBBJEPJPEO, int FHAPAHAAKAH, out int MFEIEIPNBLG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x4A811E0", Offset = "0x4A805E0", VA = "0x184A811E0")]
	public static float KFDDBPNKOBE(byte[] CCBBJEPJPEO, int FHAPAHAAKAH, out int MFEIEIPNBLG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x4A813D0", Offset = "0x4A807D0", VA = "0x184A813D0")]
	private static bool LHGEOMOMJNB(int BCJCIOLMPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x4A812C0", Offset = "0x4A806C0", VA = "0x184A812C0")]
	private static bool LBMNOHFECND(ref IBPOLIDDJPJ NDIBANACJCD, IBPOLIDDJPJ AJIMECHHNCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x4A810D0", Offset = "0x4A804D0", VA = "0x184A810D0")]
	private static bool KAOBFBEGKKH(ref IBPOLIDDJPJ NDIBANACJCD, IBPOLIDDJPJ AJIMECHHNCA, byte[] MFLBLCHAMAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x4A80FD0", Offset = "0x4A803D0", VA = "0x184A80FD0")]
	private static bool GNFEIBKNJDJ(ref IBPOLIDDJPJ EGCEDOEPFOP, byte[] IFGCPKEMIBB, int FHAPAHAAKAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x4A812A0", Offset = "0x4A806A0", VA = "0x184A812A0")]
	private static double KPPJELAALPA(bool LMPFJIBGBDG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x4A7FE70", Offset = "0x4A7F270", VA = "0x184A7FE70")]
	private static double EKLAONPAFBG(IBPOLIDDJPJ PHGHFOGNNLI, int BFFLFOJBLOH, bool FMIKOANFJKI, out int MODLHKKBLHE)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class IHJDFIHAMED<T> : global::AHKHKGPFFMH<T[]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly global::FLIGIBMLBJO<T> AIBPDGIFCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly JDJHGEIJFIG BHHDOLKPHEC;

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x1BB2530", Offset = "0x1BB1930", VA = "0x181BB2530")]
	public IHJDFIHAMED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1BB2500", Offset = "0x1BB1900", VA = "0x181BB2500")]
	public IHJDFIHAMED(JDJHGEIJFIG BHHDOLKPHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x1BB1760", Offset = "0x1BB0B60", VA = "0x181BB1760", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, T[] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x1BB1BB0", Offset = "0x1BB0FB0", VA = "0x181BB1BB0", Slot = "5")]
	public T[] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class DPJOBFAKPGG<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly global::FLIGIBMLBJO<T> AIBPDGIFCJN;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class LGHEBEIBDLO<T> : global::AHKHKGPFFMH<List<T>>, PFBBNCPHAMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly JDJHGEIJFIG BHHDOLKPHEC;

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x1BB2530", Offset = "0x1BB1930", VA = "0x181BB2530")]
	public LGHEBEIBDLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x1BB2500", Offset = "0x1BB1900", VA = "0x181BB2500")]
	public LGHEBEIBDLO(JDJHGEIJFIG BHHDOLKPHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x388B950", Offset = "0x388AD50", VA = "0x18388B950", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, List<T> IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x388C7E0", Offset = "0x388BBE0", VA = "0x18388C7E0", Slot = "5")]
	public List<T> LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class JHHPNILABHG<TElement, TIntermediate, TEnumerator, TCollection> : global::AHKHKGPFFMH<TCollection>, PFBBNCPHAMF where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x20AB480", Offset = "0x20AA880", VA = "0x1820AB480", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, TCollection IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x20ACC80", Offset = "0x20AC080", VA = "0x1820ACC80", Slot = "5")]
	public TCollection LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator IMHABFLDKCI(TCollection KOEICPMBJFP);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate FNICMNFMKAL();

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void AKBMAMDKLNI(ref TIntermediate NMDCGDFABNI, int HMJKJGLHFKE, TElement IGDJJEECDAF);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection OBGGPPJCKMP(ref TIntermediate GPHFMANFHEE);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
	protected JHHPNILABHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class DEIEEAMNDED<TElement, TIntermediate, TCollection> : global::JHHPNILABHG<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x27FE120", Offset = "0x27FD520", VA = "0x1827FE120", Slot = "6")]
	protected override IEnumerator<TElement> IMHABFLDKCI(TCollection KOEICPMBJFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x20AD520", Offset = "0x20AC920", VA = "0x1820AD520")]
	protected DEIEEAMNDED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class ALHJMCLDNKA<TElement, TCollection> : global::DEIEEAMNDED<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x1173420", Offset = "0x1172820", VA = "0x181173420", Slot = "9")]
	protected sealed override TCollection OBGGPPJCKMP(ref TCollection GPHFMANFHEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class DEBOGIDIJPG<TElement, TCollection> : global::ALHJMCLDNKA<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x27F2F40", Offset = "0x27F2340", VA = "0x1827F2F40", Slot = "7")]
	protected override TCollection FNICMNFMKAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x27F2ED0", Offset = "0x27F22D0", VA = "0x1827F2ED0", Slot = "8")]
	protected override void AKBMAMDKLNI(ref TCollection NMDCGDFABNI, int HMJKJGLHFKE, TElement IGDJJEECDAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class KMOOGBOJDAF<T> : global::JHHPNILABHG<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2528800", Offset = "0x2527C00", VA = "0x182528800", Slot = "8")]
	protected override void AKBMAMDKLNI(ref LinkedList<T> NMDCGDFABNI, int HMJKJGLHFKE, T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1173420", Offset = "0x1172820", VA = "0x181173420", Slot = "9")]
	protected override LinkedList<T> OBGGPPJCKMP(ref LinkedList<T> GPHFMANFHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x20AF600", Offset = "0x20AEA00", VA = "0x1820AF600", Slot = "7")]
	protected override LinkedList<T> FNICMNFMKAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x296A650", Offset = "0x2969A50", VA = "0x18296A650", Slot = "6")]
	protected override LinkedList<T>.Enumerator IMHABFLDKCI(LinkedList<T> KOEICPMBJFP)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class AAIOKBFALJP<T> : global::JHHPNILABHG<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2528800", Offset = "0x2527C00", VA = "0x182528800", Slot = "8")]
	protected override void AKBMAMDKLNI(ref Queue<T> NMDCGDFABNI, int HMJKJGLHFKE, T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x20AF600", Offset = "0x20AEA00", VA = "0x1820AF600", Slot = "7")]
	protected override Queue<T> FNICMNFMKAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3270", Offset = "0x3CE2670", VA = "0x183CE3270", Slot = "6")]
	protected override Queue<T>.Enumerator IMHABFLDKCI(Queue<T> KOEICPMBJFP)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x1173420", Offset = "0x1172820", VA = "0x181173420", Slot = "9")]
	protected override Queue<T> OBGGPPJCKMP(ref Queue<T> GPHFMANFHEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class BFFDHOHLLFI<T> : global::JHHPNILABHG<T, global::AAHDMFINCEK<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x28D8670", Offset = "0x28D7A70", VA = "0x1828D8670", Slot = "8")]
	protected override void AKBMAMDKLNI(ref global::AAHDMFINCEK<T> NMDCGDFABNI, int HMJKJGLHFKE, T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2A4F030", Offset = "0x2A4E430", VA = "0x182A4F030", Slot = "7")]
	protected override global::AAHDMFINCEK<T> FNICMNFMKAL()
	{
		return default(global::AAHDMFINCEK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3270", Offset = "0x3CE2670", VA = "0x183CE3270", Slot = "6")]
	protected override Stack<T>.Enumerator IMHABFLDKCI(Stack<T> KOEICPMBJFP)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3CE32C0", Offset = "0x3CE26C0", VA = "0x183CE32C0", Slot = "9")]
	protected override Stack<T> OBGGPPJCKMP(ref global::AAHDMFINCEK<T> GPHFMANFHEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class AAOOEJBHGME<T> : global::JHHPNILABHG<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2528800", Offset = "0x2527C00", VA = "0x182528800", Slot = "8")]
	protected override void AKBMAMDKLNI(ref HashSet<T> NMDCGDFABNI, int HMJKJGLHFKE, T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1173420", Offset = "0x1172820", VA = "0x181173420", Slot = "9")]
	protected override HashSet<T> OBGGPPJCKMP(ref HashSet<T> GPHFMANFHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x20AF600", Offset = "0x20AEA00", VA = "0x1820AF600", Slot = "7")]
	protected override HashSet<T> FNICMNFMKAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3270", Offset = "0x3CE2670", VA = "0x183CE3270", Slot = "6")]
	protected override HashSet<T>.Enumerator IMHABFLDKCI(HashSet<T> KOEICPMBJFP)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class PDFAEBLMNLL<T> : global::DEIEEAMNDED<T, global::AAHDMFINCEK<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x28D8670", Offset = "0x28D7A70", VA = "0x1828D8670", Slot = "8")]
	protected override void AKBMAMDKLNI(ref global::AAHDMFINCEK<T> NMDCGDFABNI, int HMJKJGLHFKE, T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x28D86E0", Offset = "0x28D7AE0", VA = "0x1828D86E0", Slot = "9")]
	protected override ReadOnlyCollection<T> OBGGPPJCKMP(ref global::AAHDMFINCEK<T> GPHFMANFHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x28D86A0", Offset = "0x28D7AA0", VA = "0x1828D86A0", Slot = "7")]
	protected override global::AAHDMFINCEK<T> FNICMNFMKAL()
	{
		return default(global::AAHDMFINCEK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class FAELEMGIGPA<T> : global::DEIEEAMNDED<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x2528800", Offset = "0x2527C00", VA = "0x182528800", Slot = "8")]
	protected override void AKBMAMDKLNI(ref List<T> NMDCGDFABNI, int HMJKJGLHFKE, T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x20AF600", Offset = "0x20AEA00", VA = "0x1820AF600", Slot = "7")]
	protected override List<T> FNICMNFMKAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x1173420", Offset = "0x1172820", VA = "0x181173420", Slot = "9")]
	protected override IList<T> OBGGPPJCKMP(ref List<T> GPHFMANFHEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class OFGCEJDFNHK<T> : global::DEIEEAMNDED<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2528800", Offset = "0x2527C00", VA = "0x182528800", Slot = "8")]
	protected override void AKBMAMDKLNI(ref List<T> NMDCGDFABNI, int HMJKJGLHFKE, T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x20AF600", Offset = "0x20AEA00", VA = "0x1820AF600", Slot = "7")]
	protected override List<T> FNICMNFMKAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x1173420", Offset = "0x1172820", VA = "0x181173420", Slot = "9")]
	protected override ICollection<T> OBGGPPJCKMP(ref List<T> GPHFMANFHEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class HNGDPGKGEJE<T> : global::DEIEEAMNDED<T, global::AAHDMFINCEK<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x28D8670", Offset = "0x28D7A70", VA = "0x1828D8670", Slot = "8")]
	protected override void AKBMAMDKLNI(ref global::AAHDMFINCEK<T> NMDCGDFABNI, int HMJKJGLHFKE, T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2A4F030", Offset = "0x2A4E430", VA = "0x182A4F030", Slot = "7")]
	protected override global::AAHDMFINCEK<T> FNICMNFMKAL()
	{
		return default(global::AAHDMFINCEK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2A4F070", Offset = "0x2A4E470", VA = "0x182A4F070", Slot = "9")]
	protected override IEnumerable<T> OBGGPPJCKMP(ref global::AAHDMFINCEK<T> GPHFMANFHEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class BMKJNMGHKGJ<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class JOFCCOMKAPM<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class DDBJMBFLKEN<T> : global::AHKHKGPFFMH<T>, PFBBNCPHAMF where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x27F20C0", Offset = "0x27F14C0", VA = "0x1827F20C0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, T IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x27F2380", Offset = "0x27F1780", VA = "0x1827F2380", Slot = "5")]
	public T LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
	public DDBJMBFLKEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class APMKGIPKDCA : global::AHKHKGPFFMH<IEnumerable>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::AHKHKGPFFMH<IEnumerable> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x4A82190", Offset = "0x4A81590", VA = "0x184A82190", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, IEnumerable IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x4A82380", Offset = "0x4A81780", VA = "0x184A82380", Slot = "5")]
	public IEnumerable LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public APMKGIPKDCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class NALBLIKEBBA : global::AHKHKGPFFMH<ICollection>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public static readonly global::AHKHKGPFFMH<ICollection> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5680", Offset = "0x4EE4A80", VA = "0x184EE5680", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, ICollection IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5A00", Offset = "0x4EE4E00", VA = "0x184EE5A00", Slot = "5")]
	public ICollection LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NALBLIKEBBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class JLLMDIGIAEA : global::AHKHKGPFFMH<IList>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::AHKHKGPFFMH<IList> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x4ED6F00", Offset = "0x4ED6300", VA = "0x184ED6F00", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, IList IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x4ED7270", Offset = "0x4ED6670", VA = "0x184ED7270", Slot = "5")]
	public IList LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public JLLMDIGIAEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class GBIBMHHGKJB<T> : global::DEIEEAMNDED<T, global::AAHDMFINCEK<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x2D38610", Offset = "0x2D37A10", VA = "0x182D38610", Slot = "8")]
	protected override void AKBMAMDKLNI(ref global::AAHDMFINCEK<T> NMDCGDFABNI, int HMJKJGLHFKE, T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2A4F030", Offset = "0x2A4E430", VA = "0x182A4F030", Slot = "7")]
	protected override global::AAHDMFINCEK<T> FNICMNFMKAL()
	{
		return default(global::AAHDMFINCEK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x2D38670", Offset = "0x2D37A70", VA = "0x182D38670", Slot = "9")]
	protected override IReadOnlyList<T> OBGGPPJCKMP(ref global::AAHDMFINCEK<T> GPHFMANFHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x20A8860", Offset = "0x20A7C60", VA = "0x1820A8860")]
	public GBIBMHHGKJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class EDNBILDGIBD
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x4A88F30", Offset = "0x4A88330", VA = "0x184A88F30")]
	public static DateTime IKIMAGECNBD(DateTime AOGPLCANPLO)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class PCAKIBDAOEP : global::AHKHKGPFFMH<DateTime>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly global::AHKHKGPFFMH<DateTime> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x4F9B2E0", Offset = "0x4F9A6E0", VA = "0x184F9B2E0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, DateTime IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x4F9B740", Offset = "0x4F9AB40", VA = "0x184F9B740", Slot = "5")]
	public DateTime LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public PCAKIBDAOEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class LHANEFDGPPE : global::AHKHKGPFFMH<DateTimeOffset>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly global::AHKHKGPFFMH<DateTimeOffset> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x4EDAA20", Offset = "0x4ED9E20", VA = "0x184EDAA20", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, DateTimeOffset IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x4EDB5E0", Offset = "0x4EDA9E0", VA = "0x184EDB5E0", Slot = "5")]
	public DateTimeOffset LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public LHANEFDGPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class IKLGJAOJGPB : global::AHKHKGPFFMH<TimeSpan>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly global::AHKHKGPFFMH<TimeSpan> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static byte[] LCAGOJLBKLK;

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x4ED4070", Offset = "0x4ED3470", VA = "0x184ED4070", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, TimeSpan IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x4ED4520", Offset = "0x4ED3920", VA = "0x184ED4520", Slot = "5")]
	public TimeSpan LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public IKLGJAOJGPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class NCLBBNNENBK<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::AHKHKGPFFMH<TDictionary>, PFBBNCPHAMF where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E100", Offset = "0x2F8D500", VA = "0x182F8E100", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, TDictionary IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x2F8F530", Offset = "0x2F8E930", VA = "0x182F8F530", Slot = "5")]
	public TDictionary LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator IMHABFLDKCI(TDictionary KOEICPMBJFP);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate FNICMNFMKAL();

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void AKBMAMDKLNI(ref TIntermediate NMDCGDFABNI, int HMJKJGLHFKE, TKey FOJIGKKHICE, TValue IGDJJEECDAF);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary OBGGPPJCKMP(ref TIntermediate GPHFMANFHEE);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
	protected NCLBBNNENBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class CBNCLOHCJIO<TKey, TValue, TIntermediate, TDictionary> : global::NCLBBNNENBK<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x27FE120", Offset = "0x27FD520", VA = "0x1827FE120", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> IMHABFLDKCI(TDictionary KOEICPMBJFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class EGELOLJGLBI<TKey, TValue, TDictionary> : global::CBNCLOHCJIO<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x1173420", Offset = "0x1172820", VA = "0x181173420", Slot = "9")]
	protected override TDictionary OBGGPPJCKMP(ref TDictionary GPHFMANFHEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class HMHNJCDFHOL<TKey, TValue> : global::NCLBBNNENBK<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C080", Offset = "0x2A4B480", VA = "0x182A4C080", Slot = "8")]
	protected override void AKBMAMDKLNI(ref Dictionary<TKey, TValue> NMDCGDFABNI, int HMJKJGLHFKE, TKey FOJIGKKHICE, TValue IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x1173420", Offset = "0x1172820", VA = "0x181173420", Slot = "9")]
	protected override Dictionary<TKey, TValue> OBGGPPJCKMP(ref Dictionary<TKey, TValue> GPHFMANFHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x20AF600", Offset = "0x20AEA00", VA = "0x1820AF600", Slot = "7")]
	protected override Dictionary<TKey, TValue> FNICMNFMKAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C0C0", Offset = "0x2A4B4C0", VA = "0x182A4C0C0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator IMHABFLDKCI(Dictionary<TKey, TValue> KOEICPMBJFP)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x1B9E100", Offset = "0x1B9D500", VA = "0x181B9E100")]
	public HMHNJCDFHOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class EIPPEODLOBD<TKey, TValue, TDictionary> : global::EGELOLJGLBI<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x24429B0", Offset = "0x2441DB0", VA = "0x1824429B0", Slot = "8")]
	protected override void AKBMAMDKLNI(ref TDictionary NMDCGDFABNI, int HMJKJGLHFKE, TKey FOJIGKKHICE, TValue IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4860", Offset = "0x1FA3C60", VA = "0x181FA4860", Slot = "7")]
	protected override TDictionary FNICMNFMKAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class FLKAMEGAKDL<TKey, TValue> : global::CBNCLOHCJIO<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x20AF5C0", Offset = "0x20AE9C0", VA = "0x1820AF5C0", Slot = "8")]
	protected override void AKBMAMDKLNI(ref Dictionary<TKey, TValue> NMDCGDFABNI, int HMJKJGLHFKE, TKey FOJIGKKHICE, TValue IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x20AF600", Offset = "0x20AEA00", VA = "0x1820AF600", Slot = "7")]
	protected override Dictionary<TKey, TValue> FNICMNFMKAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x1173420", Offset = "0x1172820", VA = "0x181173420", Slot = "9")]
	protected override IDictionary<TKey, TValue> OBGGPPJCKMP(ref Dictionary<TKey, TValue> GPHFMANFHEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class NGDAMGFFJDA<TKey, TValue> : global::EGELOLJGLBI<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x20AF5C0", Offset = "0x20AE9C0", VA = "0x1820AF5C0", Slot = "8")]
	protected override void AKBMAMDKLNI(ref SortedList<TKey, TValue> NMDCGDFABNI, int HMJKJGLHFKE, TKey FOJIGKKHICE, TValue IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x20AF600", Offset = "0x20AEA00", VA = "0x1820AF600", Slot = "7")]
	protected override SortedList<TKey, TValue> FNICMNFMKAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class JJOOKAAGLPH<TKey, TValue> : global::NCLBBNNENBK<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x20AF5C0", Offset = "0x20AE9C0", VA = "0x1820AF5C0", Slot = "8")]
	protected override void AKBMAMDKLNI(ref SortedDictionary<TKey, TValue> NMDCGDFABNI, int HMJKJGLHFKE, TKey FOJIGKKHICE, TValue IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x1173420", Offset = "0x1172820", VA = "0x181173420", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> OBGGPPJCKMP(ref SortedDictionary<TKey, TValue> GPHFMANFHEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x20AF600", Offset = "0x20AEA00", VA = "0x1820AF600", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> FNICMNFMKAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x20AF660", Offset = "0x20AEA60", VA = "0x1820AF660", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator IMHABFLDKCI(SortedDictionary<TKey, TValue> KOEICPMBJFP)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class HGGGBAJIPAK<T> : global::AHKHKGPFFMH<T>, PFBBNCPHAMF where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2FCEC10", Offset = "0x2FCE010", VA = "0x182FCEC10", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, T IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2FCEFC0", Offset = "0x2FCE3C0", VA = "0x182FCEFC0", Slot = "5")]
	public T LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
	public HGGGBAJIPAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class OIFNCLLOAAG : global::AHKHKGPFFMH<IDictionary>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly global::AHKHKGPFFMH<IDictionary> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x4F98C70", Offset = "0x4F98070", VA = "0x184F98C70", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, IDictionary IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x4F99020", Offset = "0x4F98420", VA = "0x184F99020", Slot = "5")]
	public IDictionary LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public OIFNCLLOAAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class LFLNFGEHONF : global::AHKHKGPFFMH<object>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void MGCALKNCIJP(object AINFEMIBLDF, ref MJKLEAPCGEK MPHPGBJPKDG, object IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly global::ELLGFIBEPCN<KeyValuePair<object, MGCALKNCIJP>> EALIDBKEJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly EBGILPKEKAA[] IJLNAIKCFME;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x4EDA980", Offset = "0x4ED9D80", VA = "0x184EDA980")]
	public LFLNFGEHONF(params EBGILPKEKAA[] IJLNAIKCFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x4ED9BA0", Offset = "0x4ED8FA0", VA = "0x184ED9BA0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, object IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x4EDA8E0", Offset = "0x4ED9CE0", VA = "0x184EDA8E0", Slot = "5")]
	public object LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class FIJGHIKEEIJ
{
	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x4A94570", Offset = "0x4A93970", VA = "0x184A94570")]
	public static object MOFOIHEKIAK(Type FPPBLNEEHBP, out bool NKBNELBDKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x4A93C50", Offset = "0x4A93050", VA = "0x184A93C50")]
	public static object FIBGOCGELPP(Type FPPBLNEEHBP, out bool NKBNELBDKCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class JBCILOBKMCO<T> : global::AHKHKGPFFMH<T>, PFBBNCPHAMF, global::LEKLEHOHALI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class ICGCOGNIKHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public ICGCOGNIKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1BAB680", Offset = "0x1BAAA80", VA = "0x181BAB680")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class GNDDHFBNPKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public global::LEOPHDIOCPG<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public GNDDHFBNPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x27A3CB0", Offset = "0x27A30B0", VA = "0x1827A3CB0")]
		internal void <.cctor>b__1(ref MJKLEAPCGEK writer, T value, EBGILPKEKAA _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class LFBOCNEJNHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public global::HAPKCNEFMFM<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public LFBOCNEJNHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x3884C80", Offset = "0x3884080", VA = "0x183884C80")]
		internal T <.cctor>b__2(ref ABAAKBCDNKD reader, EBGILPKEKAA _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly global::LENMDHIFIHL<T> BOGGKCLFEEF;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static readonly Dictionary<T, string> JMKJINGIHKJ;

	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private static readonly global::LEOPHDIOCPG<T> HNLBKPAHHLC;

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly global::HAPKCNEFMFM<T> EIIOLKPMJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly bool COPDFMIPAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly global::LEOPHDIOCPG<T> MLMLIAGGEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::HAPKCNEFMFM<T> AIEBBAHPEMH;

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x4035610", Offset = "0x4034A10", VA = "0x184035610")]
	static JBCILOBKMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x34512F0", Offset = "0x34506F0", VA = "0x1834512F0")]
	public JBCILOBKMCO(bool COPDFMIPAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x401A550", Offset = "0x4019950", VA = "0x18401A550", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, T IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x401F790", Offset = "0x401EB90", VA = "0x18401F790", Slot = "5")]
	public T LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x401D560", Offset = "0x401C960", VA = "0x18401D560", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, T IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x401CDB0", Offset = "0x401C1B0", VA = "0x18401CDB0", Slot = "7")]
	public T GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class OCBCKMJEJAM<T> : global::AHKHKGPFFMH<T[,]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A49CB0", Offset = "0x3A490B0", VA = "0x183A49CB0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, T[,] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3A49E60", Offset = "0x3A49260", VA = "0x183A49E60", Slot = "5")]
	public T[,] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
	public OCBCKMJEJAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class DJEJLGGBGGB<T> : global::AHKHKGPFFMH<T[,,]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x356F880", Offset = "0x356EC80", VA = "0x18356F880", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, T[,,] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x356FA90", Offset = "0x356EE90", VA = "0x18356FA90", Slot = "5")]
	public T[,,] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
	public DJEJLGGBGGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class NHCADFFMFCH<T> : global::AHKHKGPFFMH<T[,,,]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x3438620", Offset = "0x3437A20", VA = "0x183438620", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, T[,,,] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x34388C0", Offset = "0x3437CC0", VA = "0x1834388C0", Slot = "5")]
	public T[,,,] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
	public NHCADFFMFCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class OABKEIGFOFC<T> : global::AHKHKGPFFMH<T?>, PFBBNCPHAMF where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2895920", Offset = "0x2894D20", VA = "0x182895920", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, T? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2895BD0", Offset = "0x2894FD0", VA = "0x182895BD0", Slot = "5")]
	public T? LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
	public OABKEIGFOFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class BGHGCCIOPCD<T> : global::AHKHKGPFFMH<T?>, PFBBNCPHAMF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private readonly global::AHKHKGPFFMH<T> KNONBLHMLBO;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x1D528D0", Offset = "0x1D51CD0", VA = "0x181D528D0")]
	public BGHGCCIOPCD(global::AHKHKGPFFMH<T> KNONBLHMLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x3CEFC10", Offset = "0x3CEF010", VA = "0x183CEFC10")]
	public BGHGCCIOPCD(Type HFOIODKNGLG, object[] FHINECFAPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3CEDF40", Offset = "0x3CED340", VA = "0x183CEDF40", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, T? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3CEE650", Offset = "0x3CEDA50", VA = "0x183CEE650", Slot = "5")]
	public T? LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class HLOEMANEDCL : global::AHKHKGPFFMH<sbyte>, PFBBNCPHAMF, global::LEKLEHOHALI<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly HLOEMANEDCL BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1E60", Offset = "0x4ED1260", VA = "0x184ED1E60", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, sbyte IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x4ED2010", Offset = "0x4ED1410", VA = "0x184ED2010", Slot = "5")]
	public sbyte LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1F50", Offset = "0x4ED1350", VA = "0x184ED1F50", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, sbyte IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1EA0", Offset = "0x4ED12A0", VA = "0x184ED1EA0", Slot = "7")]
	public sbyte GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HLOEMANEDCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class LNDAIJPEODN : global::AHKHKGPFFMH<sbyte?>, PFBBNCPHAMF, global::LEKLEHOHALI<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly LNDAIJPEODN BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x4EE0980", Offset = "0x4EDFD80", VA = "0x184EE0980", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, sbyte? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x4EE0C20", Offset = "0x4EE0020", VA = "0x184EE0C20", Slot = "5")]
	public sbyte? LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x4EE0B10", Offset = "0x4EDFF10", VA = "0x184EE0B10", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, sbyte? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x4EE0A10", Offset = "0x4EDFE10", VA = "0x184EE0A10", Slot = "7")]
	public sbyte? GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public LNDAIJPEODN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class JGHLAEHCIKA : global::AHKHKGPFFMH<sbyte[]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly JGHLAEHCIKA BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x4ED6BC0", Offset = "0x4ED5FC0", VA = "0x184ED6BC0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, sbyte[] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4ED6D60", Offset = "0x4ED6160", VA = "0x184ED6D60", Slot = "5")]
	public sbyte[] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public JGHLAEHCIKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class BGCLJILDBOC : global::AHKHKGPFFMH<short>, PFBBNCPHAMF, global::LEKLEHOHALI<short>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly BGCLJILDBOC BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x4A82E90", Offset = "0x4A82290", VA = "0x184A82E90", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, short IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x4A82F70", Offset = "0x4A82370", VA = "0x184A82F70", Slot = "5")]
	public short LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x4A82F30", Offset = "0x4A82330", VA = "0x184A82F30", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, short IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x4A82EB0", Offset = "0x4A822B0", VA = "0x184A82EB0", Slot = "7")]
	public short GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public BGCLJILDBOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class LCECGALLLLJ : global::AHKHKGPFFMH<short?>, PFBBNCPHAMF, global::LEKLEHOHALI<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly LCECGALLLLJ BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x4ED9680", Offset = "0x4ED8A80", VA = "0x184ED9680", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, short? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x4ED9910", Offset = "0x4ED8D10", VA = "0x184ED9910", Slot = "5")]
	public short? LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x4ED9800", Offset = "0x4ED8C00", VA = "0x184ED9800", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, short? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x4ED9710", Offset = "0x4ED8B10", VA = "0x184ED9710", Slot = "7")]
	public short? GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public LCECGALLLLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class MFKCPHMBKBJ : global::AHKHKGPFFMH<short[]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly MFKCPHMBKBJ BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3260", Offset = "0x4EE2660", VA = "0x184EE3260", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, short[] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3400", Offset = "0x4EE2800", VA = "0x184EE3400", Slot = "5")]
	public short[] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public MFKCPHMBKBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class MHOEAKBDABM : global::AHKHKGPFFMH<int>, PFBBNCPHAMF, global::LEKLEHOHALI<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly MHOEAKBDABM BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x4EE35A0", Offset = "0x4EE29A0", VA = "0x184EE35A0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, int IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3740", Offset = "0x4EE2B40", VA = "0x184EE3740", Slot = "5")]
	public int LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x4EE3680", Offset = "0x4EE2A80", VA = "0x184EE3680", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, int IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x4EE35D0", Offset = "0x4EE29D0", VA = "0x184EE35D0", Slot = "7")]
	public int GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public MHOEAKBDABM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class OINILMOEEAO : global::AHKHKGPFFMH<int?>, PFBBNCPHAMF, global::LEKLEHOHALI<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly OINILMOEEAO BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x4F99250", Offset = "0x4F98650", VA = "0x184F99250", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, int? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x4F99400", Offset = "0x4F98800", VA = "0x184F99400", Slot = "5")]
	public int? LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x4F99380", Offset = "0x4F98780", VA = "0x184F99380", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, int? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4F992C0", Offset = "0x4F986C0", VA = "0x184F992C0", Slot = "7")]
	public int? GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public OINILMOEEAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class LONKFNPCHEH : global::AHKHKGPFFMH<int[]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly LONKFNPCHEH BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x4EE0CF0", Offset = "0x4EE00F0", VA = "0x184EE0CF0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, int[] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x4EE0E90", Offset = "0x4EE0290", VA = "0x184EE0E90", Slot = "5")]
	public int[] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public LONKFNPCHEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class EMONNOFIICC : global::AHKHKGPFFMH<long>, PFBBNCPHAMF, global::LEKLEHOHALI<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly EMONNOFIICC BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x4A89530", Offset = "0x4A88930", VA = "0x184A89530", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, long IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x4A89610", Offset = "0x4A88A10", VA = "0x184A89610", Slot = "5")]
	public long LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x4A895D0", Offset = "0x4A889D0", VA = "0x184A895D0", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, long IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x4A89550", Offset = "0x4A88950", VA = "0x184A89550", Slot = "7")]
	public long GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public EMONNOFIICC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class LBPBKPIOHFA : global::AHKHKGPFFMH<long?>, PFBBNCPHAMF, global::LEKLEHOHALI<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly LBPBKPIOHFA BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x4ED92A0", Offset = "0x4ED86A0", VA = "0x184ED92A0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, long? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x4ED9590", Offset = "0x4ED8990", VA = "0x184ED9590", Slot = "5")]
	public long? LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x4ED9480", Offset = "0x4ED8880", VA = "0x184ED9480", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, long? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x4ED9330", Offset = "0x4ED8730", VA = "0x184ED9330", Slot = "7")]
	public long? GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public LBPBKPIOHFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class BDGGLPFGJNB : global::AHKHKGPFFMH<long[]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly BDGGLPFGJNB BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x4A82810", Offset = "0x4A81C10", VA = "0x184A82810", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, long[] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x4A828D0", Offset = "0x4A81CD0", VA = "0x184A828D0", Slot = "5")]
	public long[] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public BDGGLPFGJNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class HBMAGLGNAHN : global::AHKHKGPFFMH<byte>, PFBBNCPHAMF, global::LEKLEHOHALI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly HBMAGLGNAHN BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0E50", Offset = "0x4ED0250", VA = "0x184ED0E50", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, byte IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1000", Offset = "0x4ED0400", VA = "0x184ED1000", Slot = "5")]
	public byte LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0F40", Offset = "0x4ED0340", VA = "0x184ED0F40", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, byte IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0E90", Offset = "0x4ED0290", VA = "0x184ED0E90", Slot = "7")]
	public byte GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HBMAGLGNAHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class BFCNNDJKHNP : global::AHKHKGPFFMH<byte?>, PFBBNCPHAMF, global::LEKLEHOHALI<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly BFCNNDJKHNP BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4A82BC0", Offset = "0x4A81FC0", VA = "0x184A82BC0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, byte? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x4A82D80", Offset = "0x4A82180", VA = "0x184A82D80", Slot = "5")]
	public byte? LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x4A82D00", Offset = "0x4A82100", VA = "0x184A82D00", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, byte? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x4A82C40", Offset = "0x4A82040", VA = "0x184A82C40", Slot = "7")]
	public byte? GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public BFCNNDJKHNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class BCLKOCJMNFG : global::AHKHKGPFFMH<ushort>, PFBBNCPHAMF, global::LEKLEHOHALI<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly BCLKOCJMNFG BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x4A82670", Offset = "0x4A81A70", VA = "0x184A82670", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, ushort IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x4A82750", Offset = "0x4A81B50", VA = "0x184A82750", Slot = "5")]
	public ushort LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x4A82710", Offset = "0x4A81B10", VA = "0x184A82710", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, ushort IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x4A82690", Offset = "0x4A81A90", VA = "0x184A82690", Slot = "7")]
	public ushort GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public BCLKOCJMNFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class HGBKHMDBEED : global::AHKHKGPFFMH<ushort?>, PFBBNCPHAMF, global::LEKLEHOHALI<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly HGBKHMDBEED BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1490", Offset = "0x4ED0890", VA = "0x184ED1490", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, ushort? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1720", Offset = "0x4ED0B20", VA = "0x184ED1720", Slot = "5")]
	public ushort? LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1610", Offset = "0x4ED0A10", VA = "0x184ED1610", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, ushort? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1520", Offset = "0x4ED0920", VA = "0x184ED1520", Slot = "7")]
	public ushort? GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HGBKHMDBEED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class ACNGAGMCFPJ : global::AHKHKGPFFMH<ushort[]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly ACNGAGMCFPJ BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x4A7F940", Offset = "0x4A7ED40", VA = "0x184A7F940", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, ushort[] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x4A7FA00", Offset = "0x4A7EE00", VA = "0x184A7FA00", Slot = "5")]
	public ushort[] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public ACNGAGMCFPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class HALCNFJDBIE : global::AHKHKGPFFMH<uint>, PFBBNCPHAMF, global::LEKLEHOHALI<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly HALCNFJDBIE BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0280", Offset = "0x4ECF680", VA = "0x184ED0280", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, uint IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0420", Offset = "0x4ECF820", VA = "0x184ED0420", Slot = "5")]
	public uint LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0360", Offset = "0x4ECF760", VA = "0x184ED0360", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, uint IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x4ED02B0", Offset = "0x4ECF6B0", VA = "0x184ED02B0", Slot = "7")]
	public uint GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HALCNFJDBIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class HKEBDFPPEHE : global::AHKHKGPFFMH<uint?>, PFBBNCPHAMF, global::LEKLEHOHALI<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly HKEBDFPPEHE BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1B00", Offset = "0x4ED0F00", VA = "0x184ED1B00", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, uint? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1D90", Offset = "0x4ED1190", VA = "0x184ED1D90", Slot = "5")]
	public uint? LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1C80", Offset = "0x4ED1080", VA = "0x184ED1C80", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, uint? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1B90", Offset = "0x4ED0F90", VA = "0x184ED1B90", Slot = "7")]
	public uint? GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HKEBDFPPEHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class HFMIHEJBPDG : global::AHKHKGPFFMH<uint[]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly HFMIHEJBPDG BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1150", Offset = "0x4ED0550", VA = "0x184ED1150", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, uint[] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x4ED12F0", Offset = "0x4ED06F0", VA = "0x184ED12F0", Slot = "5")]
	public uint[] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HFMIHEJBPDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class NAMIGGOAEGO : global::AHKHKGPFFMH<ulong>, PFBBNCPHAMF, global::LEKLEHOHALI<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly NAMIGGOAEGO BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5C10", Offset = "0x4EE5010", VA = "0x184EE5C10", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, ulong IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5D80", Offset = "0x4EE5180", VA = "0x184EE5D80", Slot = "5")]
	public ulong LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5CC0", Offset = "0x4EE50C0", VA = "0x184EE5CC0", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, ulong IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x4EE5C40", Offset = "0x4EE5040", VA = "0x184EE5C40", Slot = "7")]
	public ulong GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NAMIGGOAEGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class ELFCGJIJNLD : global::AHKHKGPFFMH<ulong?>, PFBBNCPHAMF, global::LEKLEHOHALI<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly ELFCGJIJNLD BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x4A89040", Offset = "0x4A88440", VA = "0x184A89040", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, ulong? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x4A89230", Offset = "0x4A88630", VA = "0x184A89230", Slot = "5")]
	public ulong? LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x4A891A0", Offset = "0x4A885A0", VA = "0x184A891A0", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, ulong? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x4A890C0", Offset = "0x4A884C0", VA = "0x184A890C0", Slot = "7")]
	public ulong? GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public ELFCGJIJNLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class ECPKPNMIBNA : global::AHKHKGPFFMH<ulong[]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly ECPKPNMIBNA BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x4A88BE0", Offset = "0x4A87FE0", VA = "0x184A88BE0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, ulong[] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x4A88CA0", Offset = "0x4A880A0", VA = "0x184A88CA0", Slot = "5")]
	public ulong[] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public ECPKPNMIBNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class FKJDFBGEEMI : global::AHKHKGPFFMH<float>, PFBBNCPHAMF, global::LEKLEHOHALI<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly FKJDFBGEEMI BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x4A95260", Offset = "0x4A94660", VA = "0x184A95260", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, float IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x4A95330", Offset = "0x4A94730", VA = "0x184A95330", Slot = "5")]
	public float LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x4A952F0", Offset = "0x4A946F0", VA = "0x184A952F0", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, float IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x4A95270", Offset = "0x4A94670", VA = "0x184A95270", Slot = "7")]
	public float GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public FKJDFBGEEMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class DDFDGOLPBLC : global::AHKHKGPFFMH<float?>, PFBBNCPHAMF, global::LEKLEHOHALI<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly DDFDGOLPBLC BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x4A87D80", Offset = "0x4A87180", VA = "0x184A87D80", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, float? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x4A87F40", Offset = "0x4A87340", VA = "0x184A87F40", Slot = "5")]
	public float? LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x4A87EC0", Offset = "0x4A872C0", VA = "0x184A87EC0", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, float? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x4A87E00", Offset = "0x4A87200", VA = "0x184A87E00", Slot = "7")]
	public float? GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public DDFDGOLPBLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class AOBGHKOOBCM : global::AHKHKGPFFMH<float[]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly AOBGHKOOBCM BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x4A81E40", Offset = "0x4A81240", VA = "0x184A81E40", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, float[] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x4A81F00", Offset = "0x4A81300", VA = "0x184A81F00", Slot = "5")]
	public float[] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public AOBGHKOOBCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class BLBEKBKMDMF : global::AHKHKGPFFMH<double>, PFBBNCPHAMF, global::LEKLEHOHALI<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly BLBEKBKMDMF BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x4A83AE0", Offset = "0x4A82EE0", VA = "0x184A83AE0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, double IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x4A83BB0", Offset = "0x4A82FB0", VA = "0x184A83BB0", Slot = "5")]
	public double LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x4A83B70", Offset = "0x4A82F70", VA = "0x184A83B70", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, double IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x4A83AF0", Offset = "0x4A82EF0", VA = "0x184A83AF0", Slot = "7")]
	public double GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public BLBEKBKMDMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class LMEDGPFCCBM : global::AHKHKGPFFMH<double?>, PFBBNCPHAMF, global::LEKLEHOHALI<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly LMEDGPFCCBM BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x4EE05F0", Offset = "0x4EDF9F0", VA = "0x184EE05F0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, double? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x4EE0890", Offset = "0x4EDFC90", VA = "0x184EE0890", Slot = "5")]
	public double? LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x4EE0780", Offset = "0x4EDFB80", VA = "0x184EE0780", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, double? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x4EE0670", Offset = "0x4EDFA70", VA = "0x184EE0670", Slot = "7")]
	public double? GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public LMEDGPFCCBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class HJJBKBIGNJF : global::AHKHKGPFFMH<double[]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly HJJBKBIGNJF BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x4ED17F0", Offset = "0x4ED0BF0", VA = "0x184ED17F0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, double[] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1960", Offset = "0x4ED0D60", VA = "0x184ED1960", Slot = "5")]
	public double[] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HJJBKBIGNJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class AGJGJKMDKIP : global::AHKHKGPFFMH<bool>, PFBBNCPHAMF, global::LEKLEHOHALI<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly AGJGJKMDKIP BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x4A817C0", Offset = "0x4A80BC0", VA = "0x184A817C0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, bool IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x4A818A0", Offset = "0x4A80CA0", VA = "0x184A818A0", Slot = "5")]
	public bool LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x4A81860", Offset = "0x4A80C60", VA = "0x184A81860", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, bool IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x4A817E0", Offset = "0x4A80BE0", VA = "0x184A817E0", Slot = "7")]
	public bool GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public AGJGJKMDKIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class ABPECDHLNNC : global::AHKHKGPFFMH<bool?>, PFBBNCPHAMF, global::LEKLEHOHALI<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly ABPECDHLNNC BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x4A7F6B0", Offset = "0x4A7EAB0", VA = "0x184A7F6B0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, bool? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x4A7F870", Offset = "0x4A7EC70", VA = "0x184A7F870", Slot = "5")]
	public bool? LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x4A7F7F0", Offset = "0x4A7EBF0", VA = "0x184A7F7F0", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, bool? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x4A7F730", Offset = "0x4A7EB30", VA = "0x184A7F730", Slot = "7")]
	public bool? GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public ABPECDHLNNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class JLNHLONBGHI : global::AHKHKGPFFMH<bool[]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly JLNHLONBGHI BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x4ED7480", Offset = "0x4ED6880", VA = "0x184ED7480", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, bool[] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x4ED7600", Offset = "0x4ED6A00", VA = "0x184ED7600", Slot = "5")]
	public bool[] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public JLNHLONBGHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class OPPBEGFFGMA : global::AHKHKGPFFMH<object>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::AHKHKGPFFMH<object> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly Dictionary<Type, int> KFIOOEILKIE;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x4F99CF0", Offset = "0x4F990F0", VA = "0x184F99CF0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, object IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x4F9A770", Offset = "0x4F99B70", VA = "0x184F9A770", Slot = "5")]
	public object LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public OPPBEGFFGMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class EBNMDJPPGEG : global::AHKHKGPFFMH<byte[]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::AHKHKGPFFMH<byte[]> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x4A88A70", Offset = "0x4A87E70", VA = "0x184A88A70", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, byte[] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x4A88B00", Offset = "0x4A87F00", VA = "0x184A88B00", Slot = "5")]
	public byte[] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public EBNMDJPPGEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class BIDJIJFLAED : global::AHKHKGPFFMH<ArraySegment<byte>>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::AHKHKGPFFMH<ArraySegment<byte>> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x4A83330", Offset = "0x4A82730", VA = "0x184A83330", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, ArraySegment<byte> IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x4A833F0", Offset = "0x4A827F0", VA = "0x184A833F0", Slot = "5")]
	public ArraySegment<byte> LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public BIDJIJFLAED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class MAKDLIODJNL : global::AHKHKGPFFMH<string>, PFBBNCPHAMF, global::LEKLEHOHALI<string>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::AHKHKGPFFMH<string> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x4EE12F0", Offset = "0x4EE06F0", VA = "0x184EE12F0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, string IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x4EE1310", Offset = "0x4EE0710", VA = "0x184EE1310", Slot = "5")]
	public string LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x4EE12F0", Offset = "0x4EE06F0", VA = "0x184EE12F0", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, string IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x4EE1310", Offset = "0x4EE0710", VA = "0x184EE1310", Slot = "7")]
	public string GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public MAKDLIODJNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class HAMLLELLADA : global::AHKHKGPFFMH<string[]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly HAMLLELLADA BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0490", Offset = "0x4ECF890", VA = "0x184ED0490", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, string[] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0600", Offset = "0x4ECFA00", VA = "0x184ED0600", Slot = "5")]
	public string[] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HAMLLELLADA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class BKBDPKBMHDH : global::AHKHKGPFFMH<char>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly BKBDPKBMHDH BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x4A83530", Offset = "0x4A82930", VA = "0x184A83530", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, char IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4A835B0", Offset = "0x4A829B0", VA = "0x184A835B0", Slot = "5")]
	public char LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public BKBDPKBMHDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class MAHBCKIGFPO : global::AHKHKGPFFMH<char?>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly MAHBCKIGFPO BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x4EE10D0", Offset = "0x4EE04D0", VA = "0x184EE10D0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, char? IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x4EE11C0", Offset = "0x4EE05C0", VA = "0x184EE11C0", Slot = "5")]
	public char? LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public MAHBCKIGFPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class FKEHHGCBGLL : global::AHKHKGPFFMH<char[]>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly FKEHHGCBGLL BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x4A94E90", Offset = "0x4A94290", VA = "0x184A94E90", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, char[] IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x4A95010", Offset = "0x4A94410", VA = "0x184A95010", Slot = "5")]
	public char[] LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public FKEHHGCBGLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class GACJOBHMBMN : global::AHKHKGPFFMH<Guid>, PFBBNCPHAMF, global::LEKLEHOHALI<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::AHKHKGPFFMH<Guid> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x4ECE340", Offset = "0x4ECD740", VA = "0x184ECE340", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, Guid IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x4ECE4C0", Offset = "0x4ECD8C0", VA = "0x184ECE4C0", Slot = "5")]
	public Guid LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x4ECE510", Offset = "0x4ECD910", VA = "0x184ECE510", Slot = "6")]
	public void ICBLKGDCMOC(ref MJKLEAPCGEK MPHPGBJPKDG, Guid IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x4ECE4C0", Offset = "0x4ECD8C0", VA = "0x184ECE4C0", Slot = "7")]
	public Guid GHMIGPCHAJI(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public GACJOBHMBMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class ABJMDLDJPNM : global::AHKHKGPFFMH<decimal>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::AHKHKGPFFMH<decimal> BKIMHMJINMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly bool LFGEGOGBKMG;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x8DC980", Offset = "0x8DBD80", VA = "0x1808DC980")]
	public ABJMDLDJPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x1255520", Offset = "0x1254920", VA = "0x181255520")]
	public ABJMDLDJPNM(bool LFGEGOGBKMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x4A7F2D0", Offset = "0x4A7E6D0", VA = "0x184A7F2D0", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, decimal IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x4A7F420", Offset = "0x4A7E820", VA = "0x184A7F420", Slot = "5")]
	public decimal LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class OOOKIIFEAJC : global::AHKHKGPFFMH<Uri>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly global::AHKHKGPFFMH<Uri> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x4F99B60", Offset = "0x4F98F60", VA = "0x184F99B60", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, Uri IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x4F99C10", Offset = "0x4F99010", VA = "0x184F99C10", Slot = "5")]
	public Uri LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public OOOKIIFEAJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class NPCDFAGALCL : global::AHKHKGPFFMH<Version>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly global::AHKHKGPFFMH<Version> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x4F96C70", Offset = "0x4F96070", VA = "0x184F96C70", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, Version IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x4F96D20", Offset = "0x4F96120", VA = "0x184F96D20", Slot = "5")]
	public Version LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NPCDFAGALCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class LJGICPGCKJE<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class LBLDHOFFHKG : global::AHKHKGPFFMH<StringBuilder>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly global::AHKHKGPFFMH<StringBuilder> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x4ED9170", Offset = "0x4ED8570", VA = "0x184ED9170", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, StringBuilder IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x4ED91C0", Offset = "0x4ED85C0", VA = "0x184ED91C0", Slot = "5")]
	public StringBuilder LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public LBLDHOFFHKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class BPEKIOKOKPL : global::AHKHKGPFFMH<BitArray>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly global::AHKHKGPFFMH<BitArray> BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x4A83C20", Offset = "0x4A83020", VA = "0x184A83C20", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, BitArray IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x4A83CB0", Offset = "0x4A830B0", VA = "0x184A83CB0", Slot = "5")]
	public BitArray LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public BPEKIOKOKPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class KABILBJHPCG : global::AHKHKGPFFMH<Type>, PFBBNCPHAMF
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly KABILBJHPCG BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly Regex KLMMHMKAJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool NBNKEDMLPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private bool EMNPBMBICBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private bool FCNHMBCIPIO;

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x4ED7B60", Offset = "0x4ED6F60", VA = "0x184ED7B60")]
	public KABILBJHPCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x4ED7B80", Offset = "0x4ED6F80", VA = "0x184ED7B80")]
	public KABILBJHPCG(bool NBNKEDMLPOD, bool EMNPBMBICBO, bool FCNHMBCIPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x4ED7880", Offset = "0x4ED6C80", VA = "0x184ED7880", Slot = "4")]
	public void FBLBIDAIACI(ref MJKLEAPCGEK MPHPGBJPKDG, Type IGDJJEECDAF, EBGILPKEKAA NDMKGIOEBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x4ED7970", Offset = "0x4ED6D70", VA = "0x184ED7970", Slot = "5")]
	public Type LOHKEOMODAB(ref ABAAKBCDNKD HMLGAEKBLFL, EBGILPKEKAA NDMKGIOEBOJ)
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
