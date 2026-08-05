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
public class KMKKFPPIKMM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64BB40", Offset = "0x64AB40", VA = "0x18064BB40")]
	public KMKKFPPIKMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class ACKAKJNJPCN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64BB40", Offset = "0x64AB40", VA = "0x18064BB40")]
	public ACKAKJNJPCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class MPHMBGNALJB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64BB40", Offset = "0x64AB40", VA = "0x18064BB40")]
	public MPHMBGNALJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class FOAIFPBMDFL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x64BB40", Offset = "0x64AB40", VA = "0x18064BB40")]
	public FOAIFPBMDFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class LBBDKJCEACF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x49DDEC0", Offset = "0x49DCEC0", VA = "0x1849DDEC0")]
	public static bool AAPCJNAOCEM(this TypeInfo BCFKLEGAMEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class NAKNOGOBLMG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type HFNGLDDAIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66A130", Offset = "0x669130", VA = "0x18066A130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] PEDALJFOEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6656F0", Offset = "0x6646F0", VA = "0x1806656F0")]
	public NAKNOGOBLMG(Type NLNGAAILPIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class OHPOKOEEHAP : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void BKKGNGKDABO<T>(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T IKNPCAKNFFF<T>(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF EPCNJMCAAGN);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LOIEEHPBJBK
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HAKOMFHEDCC<T> : LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PEHGKAMCACG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum ENFHMOLIHKA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class INOOENGEAAF
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2496340", Offset = "0x2495340", VA = "0x182496340")]
	public static global::HAKOMFHEDCC<T> NGBFDKMKBBL<T>(this IEIMAIBIIFF EPCNJMCAAGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x49DB910", Offset = "0x49DA910", VA = "0x1849DB910")]
	public static object NAIBINIPFDO(this IEIMAIBIIFF EPCNJMCAAGN, Type BCFKLEGAMEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JGBJFILBOLO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x49DBE60", Offset = "0x49DAE60", VA = "0x1849DBE60")]
	public JGBJFILBOLO(string NJAIIGFCHNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct GOCMFGPNGFE
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class NLBDDPKDIAB
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] NCCOCLJLPFP;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] KLHFOHACFMH;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4D5E670", Offset = "0x4D5D670", VA = "0x184D5E670")]
		public static byte[] MNPKOLKGMCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4D5E5E0", Offset = "0x4D5D5E0", VA = "0x184D5E5E0")]
		public static char[] FKBMJAKPKEO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> KLNOGJCHHCF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] OEEDNOFJGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] CDDAIIMDJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int EGBIMJLECFF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool BCJCCJJNKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x49D54A0", Offset = "0x49D44A0", VA = "0x1849D54A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x49D75C0", Offset = "0x49D65C0", VA = "0x1849D75C0")]
	public GOCMFGPNGFE(byte[] CDDAIIMDJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x49D73D0", Offset = "0x49D63D0", VA = "0x1849D73D0")]
	public GOCMFGPNGFE(byte[] CDDAIIMDJCN, int EGBIMJLECFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x49D4BF0", Offset = "0x49D3BF0", VA = "0x1849D4BF0")]
	private AAADFHNEBBG CFJFEAKGPCO(string MHMMCHLDEKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x49D4B10", Offset = "0x49D3B10", VA = "0x1849D4B10")]
	private AAADFHNEBBG BNFOMOHMAPO(string NJAIIGFCHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x49D58F0", Offset = "0x49D48F0", VA = "0x1849D58F0")]
	public void FBIKDBPLAJE(int EGBIMJLECFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x64A000", Offset = "0x649000", VA = "0x18064A000")]
	public byte[] OADEJILKOJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x764170", Offset = "0x763170", VA = "0x180764170")]
	public int PCEMIJBKLDG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x49D5F30", Offset = "0x49D4F30", VA = "0x1849D5F30")]
	public KIFJOJNEDMC KEICCDCFFKB()
	{
		return default(KIFJOJNEDMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x49D5180", Offset = "0x49D4180", VA = "0x1849D5180")]
	public void CLDFNNMNHNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x49D5C10", Offset = "0x49D4C10", VA = "0x1849D5C10")]
	public bool HKJCECDMGOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x49D6440", Offset = "0x49D5440", VA = "0x1849D6440")]
	public bool MPHOMCDOKPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x49D63B0", Offset = "0x49D53B0", VA = "0x1849D63B0")]
	public void MGHMIJBODKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x49D5A90", Offset = "0x49D4A90", VA = "0x1849D5A90")]
	public bool FMGMGOFOKBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x49D5EB0", Offset = "0x49D4EB0", VA = "0x1849D5EB0")]
	public bool JJIKMBONEIA(ref int LGKBEOCJMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x49D6D20", Offset = "0x49D5D20", VA = "0x1849D6D20")]
	public bool OFOKJKBHMEE(ref int LGKBEOCJMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x49D5840", Offset = "0x49D4840", VA = "0x1849D5840")]
	public bool EKKCKHGNDHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x49D4870", Offset = "0x49D3870", VA = "0x1849D4870")]
	public void BDHGMFNHFCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x49D4740", Offset = "0x49D3740", VA = "0x1849D4740")]
	public bool AGBCHMENDGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x49D46C0", Offset = "0x49D36C0", VA = "0x1849D46C0")]
	public bool AALKAAHAKEI(ref int LGKBEOCJMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x49D5AF0", Offset = "0x49D4AF0", VA = "0x1849D5AF0")]
	public bool GEBPKNOIAGL(ref int LGKBEOCJMLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x49D6350", Offset = "0x49D5350", VA = "0x1849D6350")]
	public bool MCBIFLLMAHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x49D5DC0", Offset = "0x49D4DC0", VA = "0x1849D5DC0")]
	public void JFFGPHKJMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x49D5BB0", Offset = "0x49D4BB0", VA = "0x1849D5BB0")]
	public bool HEJFFAGMNHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x49D64D0", Offset = "0x49D54D0", VA = "0x1849D64D0")]
	public void NBKHCDFFMNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x49D6560", Offset = "0x49D5560", VA = "0x1849D6560")]
	private void OBMFECMGHHB(out byte[] CILJOEKBECL, out int ECMBJPPOFHN, out int LAFCKHKJKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x49D5790", Offset = "0x49D4790", VA = "0x1849D5790")]
	private static int EGBJNLHNPDM(char DOGOAAONBOH, char ENHIJCCJFBF, char ODCENIJJKIC, char BOMCMOAJNIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x49D6DE0", Offset = "0x49D5DE0", VA = "0x1849D6DE0")]
	private static int OHIJCNLGBED(char ODLLFOGPPIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x49D6F30", Offset = "0x49D5F30", VA = "0x1849D6F30")]
	public ArraySegment<byte> PELLMPJALID()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x49D5D10", Offset = "0x49D4D10", VA = "0x1849D5D10")]
	public string IDGKGMLDGCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x49D64A0", Offset = "0x49D54A0", VA = "0x1849D64A0")]
	public string MPJPIAKCGLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x49D5560", Offset = "0x49D4560", VA = "0x1849D5560")]
	public ArraySegment<byte> DNIMPBGAOLH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x49D5520", Offset = "0x49D4520", VA = "0x1849D5520")]
	public ArraySegment<byte> DIDOJCGAJHL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x49D7030", Offset = "0x49D6030", VA = "0x1849D7030")]
	public bool PHHFPHGKEHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x49D4A50", Offset = "0x49D3A50", VA = "0x1849D4A50")]
	private static bool BMNDPKPHBOL(byte ODCENIJJKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x49D52C0", Offset = "0x49D42C0", VA = "0x1849D52C0")]
	private void CPGCGEFDHJH(KIFJOJNEDMC FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x49D5DB0", Offset = "0x49D4DB0", VA = "0x1849D5DB0")]
	public void IDONKGNHIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x49D47A0", Offset = "0x49D37A0", VA = "0x1849D47A0")]
	private void ALPMAHNEAGH(int EMHPFBDHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x49D58A0", Offset = "0x49D48A0", VA = "0x1849D58A0")]
	public sbyte ENIFFBLFONM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x49D61A0", Offset = "0x49D51A0", VA = "0x1849D61A0")]
	public short LJPINJKNAOG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x49D7270", Offset = "0x49D6270", VA = "0x1849D7270")]
	public int PMGMFGBIFDG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x49D6EB0", Offset = "0x49D5EB0", VA = "0x1849D6EB0")]
	public long OKAACLJBNNN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x49D5E50", Offset = "0x49D4E50", VA = "0x1849D5E50")]
	public byte JGDKDGKAPBP()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x49D5730", Offset = "0x49D4730", VA = "0x1849D5730")]
	public ushort EACPFKLCNCF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x49D54C0", Offset = "0x49D44C0", VA = "0x1849D54C0")]
	public uint DDDBNCKOJAF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x49D5100", Offset = "0x49D4100", VA = "0x1849D5100")]
	public ulong CHHDFFDMPBB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x49D6200", Offset = "0x49D5200", VA = "0x1849D6200")]
	public float LOHCAAFDECB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x49D4900", Offset = "0x49D3900", VA = "0x1849D4900")]
	public double BGCLNPNNNGI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x49D60B0", Offset = "0x49D50B0", VA = "0x1849D60B0")]
	public ArraySegment<byte> LAEIFHDKDGG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x49D5900", Offset = "0x49D4900", VA = "0x1849D5900")]
	private static int FLFEGMMINAA(byte[] CDDAIIMDJCN, int EGBIMJLECFF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AAADFHNEBBG : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference CKDHMPCCHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int GCGFDEDCKFE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int EIBPFOJGGLG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1B8A790", Offset = "0x1B89790", VA = "0x181B8A790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string LHDJJLEAMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x901920", Offset = "0x900920", VA = "0x180901920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4C88860", Offset = "0x4C87860", VA = "0x184C88860")]
	public AAADFHNEBBG(string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4C888D0", Offset = "0x4C878D0", VA = "0x184C888D0")]
	public AAADFHNEBBG(string NJAIIGFCHNG, byte[] MNOLNPDECCF, int EGBIMJLECFF, int GCGFDEDCKFE, string IDKDIFOJOBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EMNCNFOPOMA
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class LNGCKHKDIPM
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void LCLIGGEFKKL(ref KNPMIFIKMDA FBNHINKPMEA, object CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object DNBLAKEHKEK(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF EPCNJMCAAGN);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class KJHJNOAGOHM
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class GCEOGANGEMC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
				public GCEOGANGEMC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x36B5270", Offset = "0x36B4270", VA = "0x1836B5270")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x4D53330", Offset = "0x4D52330", VA = "0x184D53330")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, IEIMAIBIIFF, byte[]> LFOKJLAFKAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, IEIMAIBIIFF> MCCBEAFHCKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly LCLIGGEFKKL KOFELLINPJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, IEIMAIBIIFF, ArraySegment<byte>> HFMGDLHKFDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, IEIMAIBIIFF, string> ELIMCHOBDAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, IEIMAIBIIFF, object> HMFOCLJLAGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, IEIMAIBIIFF, object> CAELGPBNHLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, IEIMAIBIIFF, object> IKJKFDIBMOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly DNBLAKEHKEK HGEIBOCJJFP;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x4D589B0", Offset = "0x4D579B0", VA = "0x184D589B0")]
			public KJHJNOAGOHM(Type BCFKLEGAMEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2FCB740", Offset = "0x2FCA740", VA = "0x182FCB740")]
			private static T MNHABAMNCFC<T>(DynamicMethod PJFLEMONMDK)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4D58760", Offset = "0x4D57760", VA = "0x184D58760")]
			private static MethodInfo CPDGOCCCLIG(Type BCFKLEGAMEO, string FOGNBJMCDMG, Type[] OAHJKCAELAJ)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, KJHJNOAGOHM> GAMOADLLPAJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::JMJBDOGCDKP<KJHJNOAGOHM> OPPGCCMLFOA;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4D5D490", Offset = "0x4D5C490", VA = "0x184D5D490")]
		static LNGCKHKDIPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4D5D150", Offset = "0x4D5C150", VA = "0x184D5D150")]
		private static KJHJNOAGOHM FNLIBAGKGPC(Type BCFKLEGAMEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4D5D1E0", Offset = "0x4D5C1E0", VA = "0x184D5D1E0")]
		public static void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, object CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4D5D370", Offset = "0x4D5C370", VA = "0x184D5D370")]
		public static void HHDOHEHKDKI(Type BCFKLEGAMEO, ref KNPMIFIKMDA FBNHINKPMEA, object CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class NEAODCLGCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] NCCOCLJLPFP;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4D5D790", Offset = "0x4D5C790", VA = "0x184D5D790")]
		public static byte[] MNPKOLKGMCE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static IEIMAIBIIFF MHAEGNLIOGK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] KADCFLNKGNA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] NJILKDCLILB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static IEIMAIBIIFF FCJCJLEINOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4C9FFE0", Offset = "0x4C9EFE0", VA = "0x184C9FFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool ELDHHCEEDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4CA08F0", Offset = "0x4C9F8F0", VA = "0x184CA08F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4CA0950", Offset = "0x4C9F950", VA = "0x184CA0950")]
	public static void OCNNNLHNKEP(IEIMAIBIIFF EPCNJMCAAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2924FA0", Offset = "0x2923FA0", VA = "0x182924FA0")]
	public static byte[] HHDOHEHKDKI<T>(T ODMJCJPGHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x29251D0", Offset = "0x29241D0", VA = "0x1829251D0")]
	public static byte[] HHDOHEHKDKI<T>(T CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2925020", Offset = "0x2924020", VA = "0x182925020")]
	public static void HHDOHEHKDKI<T>(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2924E30", Offset = "0x2923E30", VA = "0x182924E30")]
	public static void HHDOHEHKDKI<T>(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2924F10", Offset = "0x2923F10", VA = "0x182924F10")]
	public static void HHDOHEHKDKI<T>(Stream JMJPBBLODJI, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x29250B0", Offset = "0x29240B0", VA = "0x1829250B0")]
	public static void HHDOHEHKDKI<T>(Stream JMJPBBLODJI, T CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2924D90", Offset = "0x2923D90", VA = "0x182924D90")]
	public static ArraySegment<byte> DDFDFIGGKEK<T>(T ODMJCJPGHNI)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2924C10", Offset = "0x2923C10", VA = "0x182924C10")]
	public static ArraySegment<byte> DDFDFIGGKEK<T>(T CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2925330", Offset = "0x2924330", VA = "0x182925330")]
	public static string POJABMFPPIP<T>(T CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x29253B0", Offset = "0x29243B0", VA = "0x1829253B0")]
	public static string POJABMFPPIP<T>(T CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2924150", Offset = "0x2923150", VA = "0x182924150")]
	public static T ADHMOLAJGDE<T>(string OEAPFLDGOAL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2924290", Offset = "0x2923290", VA = "0x182924290")]
	public static T ADHMOLAJGDE<T>(string OEAPFLDGOAL, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29249C0", Offset = "0x29239C0", VA = "0x1829249C0")]
	public static T ADHMOLAJGDE<T>(byte[] CDDAIIMDJCN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29241F0", Offset = "0x29231F0", VA = "0x1829241F0")]
	public static T ADHMOLAJGDE<T>(byte[] CDDAIIMDJCN, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2924620", Offset = "0x2923620", VA = "0x182924620")]
	public static T ADHMOLAJGDE<T>(byte[] CDDAIIMDJCN, int EGBIMJLECFF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2924380", Offset = "0x2923380", VA = "0x182924380")]
	public static T ADHMOLAJGDE<T>(byte[] CDDAIIMDJCN, int EGBIMJLECFF, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2924730", Offset = "0x2923730", VA = "0x182924730")]
	public static T ADHMOLAJGDE<T>(ref GOCMFGPNGFE CLOGDHPGNHC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2924B40", Offset = "0x2923B40", VA = "0x182924B40")]
	public static T ADHMOLAJGDE<T>(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2924A40", Offset = "0x2923A40", VA = "0x182924A40")]
	public static T ADHMOLAJGDE<T>(Stream JMJPBBLODJI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2924890", Offset = "0x2923890", VA = "0x182924890")]
	public static T ADHMOLAJGDE<T>(Stream JMJPBBLODJI, IEIMAIBIIFF EPCNJMCAAGN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4C9FD80", Offset = "0x4C9ED80", VA = "0x184C9FD80")]
	public static string DJKDIHJGAFH(byte[] OEAPFLDGOAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4C9FE60", Offset = "0x4C9EE60", VA = "0x184C9FE60")]
	public static string DJKDIHJGAFH(byte[] OEAPFLDGOAL, int EGBIMJLECFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4C9FF10", Offset = "0x4C9EF10", VA = "0x184C9FF10")]
	public static string DJKDIHJGAFH(string OEAPFLDGOAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4CA0690", Offset = "0x4C9F690", VA = "0x184CA0690")]
	public static byte[] LFCNBDGNIMB(byte[] OEAPFLDGOAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4CA0770", Offset = "0x4C9F770", VA = "0x184CA0770")]
	public static byte[] LFCNBDGNIMB(byte[] OEAPFLDGOAL, int EGBIMJLECFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4CA0820", Offset = "0x4C9F820", VA = "0x184CA0820")]
	public static byte[] LFCNBDGNIMB(string OEAPFLDGOAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4CA01A0", Offset = "0x4C9F1A0", VA = "0x184CA01A0")]
	private static void LDIPLNCKOJB(ref GOCMFGPNGFE CLOGDHPGNHC, ref KNPMIFIKMDA FBNHINKPMEA, int FOCIGJDPHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4CA0100", Offset = "0x4C9F100", VA = "0x184CA0100")]
	private static int HCAAIGCHDPI(Stream KAKCHGJCKMF, ref byte[] NCCOCLJLPFP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum KIFJOJNEDMC : byte
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
public struct KNPMIFIKMDA
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] PFEBFHEGALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] NCCOCLJLPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int EGBIMJLECFF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EIHKBFKLBAM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x764170", Offset = "0x763170", VA = "0x180764170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x49D58F0", Offset = "0x49D48F0", VA = "0x1849D58F0")]
	public void FBIKDBPLAJE(int EGBIMJLECFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x49DDD20", Offset = "0x49DCD20", VA = "0x1849DDD20")]
	public static byte[] PPHIFGDGCBM(string BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x49DD400", Offset = "0x49DC400", VA = "0x1849DD400")]
	public static byte[] IAGKEPPFCHI(string BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x49DD540", Offset = "0x49DC540", VA = "0x1849DD540")]
	public static byte[] IMLBEDMMGJI(string BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x49DDB50", Offset = "0x49DCB50", VA = "0x1849DDB50")]
	public static byte[] OFPEGINFOBI(string BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xCD8B60", Offset = "0xCD7B60", VA = "0x180CD8B60")]
	public KNPMIFIKMDA(byte[] KBMEIMDNMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x49DDA70", Offset = "0x49DCA70", VA = "0x1849DDA70")]
	public ArraySegment<byte> MNPKOLKGMCE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x49DD680", Offset = "0x49DC680", VA = "0x1849DD680")]
	public byte[] IOAKNHHCNFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x49DDE00", Offset = "0x49DCE00", VA = "0x1849DDE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x49DD7E0", Offset = "0x49DC7E0", VA = "0x1849DD7E0")]
	public void LOKAJEFELOL(int ANPLBJOGOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x49DC9B0", Offset = "0x49DB9B0", VA = "0x1849DC9B0")]
	public void BOIJDCIIDIP(byte OHDCIAFGHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x49DCFA0", Offset = "0x49DBFA0", VA = "0x1849DCFA0")]
	public void BOIJDCIIDIP(byte[] OHDCIAFGHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x49DD7A0", Offset = "0x49DC7A0", VA = "0x1849DD7A0")]
	public void LKHHGPBMDFL(byte OHDCIAFGHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x49DD700", Offset = "0x49DC700", VA = "0x1849DD700")]
	public void JFOKLJCCOEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x49DDCD0", Offset = "0x49DCCD0", VA = "0x1849DDCD0")]
	public void OONKAKAHOCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x49DD100", Offset = "0x49DC100", VA = "0x1849DD100")]
	public void DDDNHKIFEDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x49DD750", Offset = "0x49DC750", VA = "0x1849DD750")]
	public void JGEPHLJPNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x49DD310", Offset = "0x49DC310", VA = "0x1849DD310")]
	public void FMNOHHJBEDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x49DD3B0", Offset = "0x49DC3B0", VA = "0x1849DD3B0")]
	public void HNEDCMBJGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x49DD7F0", Offset = "0x49DC7F0", VA = "0x1849DD7F0")]
	public void MDGFIKDFBAO(string BAOKNJFCNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x49DD360", Offset = "0x49DC360", VA = "0x1849DD360")]
	public void HIBIPLNLJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x49DD000", Offset = "0x49DC000", VA = "0x1849DD000")]
	public void CHCKEOGGMPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x49DD880", Offset = "0x49DC880", VA = "0x1849DD880")]
	public void MMEIMNKKAPF(bool CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x49DCE10", Offset = "0x49DBE10", VA = "0x1849DCE10")]
	public void BGBMIBBCKGB(float CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x49DD180", Offset = "0x49DC180", VA = "0x1849DD180")]
	public void EPJAHEIIJBL(double CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x49DDB20", Offset = "0x49DCB20", VA = "0x1849DDB20")]
	public void NGBBCMPIDFB(byte CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x49DCDE0", Offset = "0x49DBDE0", VA = "0x1849DCDE0")]
	public void BBODIKFPFEH(ushort CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x49DDCA0", Offset = "0x49DCCA0", VA = "0x1849DDCA0")]
	public void OJMOPJNGOGB(uint CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x49DD0D0", Offset = "0x49DC0D0", VA = "0x1849DD0D0")]
	public void CKBJNKDOMLF(ulong CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x49DD2E0", Offset = "0x49DC2E0", VA = "0x1849DD2E0")]
	public void FHDHKKFMPDH(sbyte CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x49DCF70", Offset = "0x49DBF70", VA = "0x1849DCF70")]
	public void BJPDNOAEILO(short CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x49DD850", Offset = "0x49DC850", VA = "0x1849DD850")]
	public void MJMGONKKOCE(int CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x49DD150", Offset = "0x49DC150", VA = "0x1849DD150")]
	public void DILLBKEAJFJ(long CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x49DCA10", Offset = "0x49DBA10", VA = "0x1849DCA10")]
	public void AFGLOAGBLKD(string CCIMHDCKHOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NMKEAMCCINB : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class CJHFKGFGDGG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x29FE970", Offset = "0x29FD970", VA = "0x1829FE970")]
		static CJHFKGFGDGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private NMKEAMCCINB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class LOMCGJOGEAM
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> BKCGEPOPLCN;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x49E13D0", Offset = "0x49E03D0", VA = "0x1849E13D0")]
	static LOMCGJOGEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x49E0CC0", Offset = "0x49DFCC0", VA = "0x1849E0CC0")]
	internal static object HOBJBBKLJHM(Type HLNBIKMPIPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class CLLBFNABBJK : global::HAKOMFHEDCC<Vector2>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NHNNFMDDFBM DGKFMKMHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] DLMMLIEICDM;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4C917F0", Offset = "0x4C907F0", VA = "0x184C917F0")]
	public CLLBFNABBJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4C91740", Offset = "0x4C90740", VA = "0x184C91740", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Vector2 CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4C915C0", Offset = "0x4C905C0", VA = "0x184C915C0", Slot = "5")]
	public Vector2 ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class GLENIEAMLCC : global::HAKOMFHEDCC<Vector3>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NHNNFMDDFBM DGKFMKMHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] DLMMLIEICDM;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x49CF590", Offset = "0x49CE590", VA = "0x1849CF590")]
	public GLENIEAMLCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x49CF390", Offset = "0x49CE390", VA = "0x1849CF390", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Vector3 CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x49CF070", Offset = "0x49CE070", VA = "0x1849CF070", Slot = "5")]
	public Vector3 ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class EOBNDLCGGJO : global::HAKOMFHEDCC<Vector4>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly NHNNFMDDFBM DGKFMKMHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] DLMMLIEICDM;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x49CBD10", Offset = "0x49CAD10", VA = "0x1849CBD10")]
	public EOBNDLCGGJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x49CBAA0", Offset = "0x49CAAA0", VA = "0x1849CBAA0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Vector4 CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x49CB720", Offset = "0x49CA720", VA = "0x1849CB720", Slot = "5")]
	public Vector4 ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class GLGPAOGCOJI : global::HAKOMFHEDCC<Quaternion>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly NHNNFMDDFBM DGKFMKMHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] DLMMLIEICDM;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x49CFBB0", Offset = "0x49CEBB0", VA = "0x1849CFBB0")]
	public GLGPAOGCOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x49CBAA0", Offset = "0x49CAAA0", VA = "0x1849CBAA0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Quaternion CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x49CF830", Offset = "0x49CE830", VA = "0x1849CF830", Slot = "5")]
	public Quaternion ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class DDAEGDEDPLG : global::HAKOMFHEDCC<Color>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly NHNNFMDDFBM DGKFMKMHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] DLMMLIEICDM;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4C93590", Offset = "0x4C92590", VA = "0x184C93590")]
	public DDAEGDEDPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4C93440", Offset = "0x4C92440", VA = "0x184C93440", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Color CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4C93220", Offset = "0x4C92220", VA = "0x184C93220", Slot = "5")]
	public Color ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class CHKGNKLOFIE : global::HAKOMFHEDCC<Bounds>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly NHNNFMDDFBM DGKFMKMHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] DLMMLIEICDM;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4C91160", Offset = "0x4C90160", VA = "0x184C91160")]
	public CHKGNKLOFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4C90FC0", Offset = "0x4C8FFC0", VA = "0x184C90FC0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Bounds CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4C90D20", Offset = "0x4C8FD20", VA = "0x184C90D20", Slot = "5")]
	public Bounds ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class DNMIGPLBFDF : global::HAKOMFHEDCC<Rect>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly NHNNFMDDFBM DGKFMKMHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] DLMMLIEICDM;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4C9F4B0", Offset = "0x4C9E4B0", VA = "0x184C9F4B0")]
	public DNMIGPLBFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4C9F340", Offset = "0x4C9E340", VA = "0x184C9F340", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Rect CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4C9F100", Offset = "0x4C9E100", VA = "0x184C9F100", Slot = "5")]
	public Rect ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class EHLLDBKFMEP : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class BPPMMJMLKIE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28B47D0", Offset = "0x28B37D0", VA = "0x1828B47D0")]
		static BPPMMJMLKIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private EHLLDBKFMEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class LPIAJLDAINN : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class JBKGKOEOKDP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x23355D0", Offset = "0x23345D0", VA = "0x1823355D0")]
		static JBKGKOEOKDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class KGBHFJBHLNA
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> FLKCAABPHED;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4D56570", Offset = "0x4D55570", VA = "0x184D56570")]
		internal static object HOBJBBKLJHM(Type HLNBIKMPIPM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private LPIAJLDAINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class DNECPKJPCDJ : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class GGPAELBDIFD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3760E00", Offset = "0x375FE00", VA = "0x183760E00")]
		static GGPAELBDIFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly DNECPKJPCDJ KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool IDPKOAANMPI;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static LOIEEHPBJBK[] DOBAFBLIPMN;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static IEIMAIBIIFF[] MKAFKJIJMOL;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private DNECPKJPCDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4C9ECB0", Offset = "0x4C9DCB0", VA = "0x184C9ECB0")]
	public static void IIGIGLNPDMN(params IEIMAIBIIFF[] MKAFKJIJMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4C9EBD0", Offset = "0x4C9DBD0", VA = "0x184C9EBD0")]
	public static void IIGIGLNPDMN(params LOIEEHPBJBK[] DOBAFBLIPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4C9ED90", Offset = "0x4C9DD90", VA = "0x184C9ED90")]
	public static void NMLBEOPJPJG(LOIEEHPBJBK[] DOBAFBLIPMN, IEIMAIBIIFF[] MKAFKJIJMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class LMADBBGBKMD : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class LLKNIMAFLIF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE470", Offset = "0x2AAD470", VA = "0x182AAE470")]
		static LLKNIMAFLIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private LMADBBGBKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class MEEGDGOHOGB
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly IEIMAIBIIFF PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly IEIMAIBIIFF CPHLMJKMPBE;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly IEIMAIBIIFF BDBNFDGCOMC;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly IEIMAIBIIFF OPCLEFLDHME;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly IEIMAIBIIFF DLFGLICNEAP;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly IEIMAIBIIFF HAEJDAAAPCC;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly IEIMAIBIIFF AOHAIFIHALN;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly IEIMAIBIIFF NLOJNDCMJHA;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly IEIMAIBIIFF FCLJCPMEMGG;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly IEIMAIBIIFF HPHCAHJFBIB;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly IEIMAIBIIFF COLHFPMAILN;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly IEIMAIBIIFF FJNGJHCEFCO;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class GHDJMKMGPLB
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly IEIMAIBIIFF PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly IEIMAIBIIFF EEOMCLNHMEB;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class MJFAHPDHJDF
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly IEIMAIBIIFF PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly IEIMAIBIIFF CPHLMJKMPBE;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IEIMAIBIIFF BDBNFDGCOMC;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly IEIMAIBIIFF OPCLEFLDHME;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IEIMAIBIIFF DLFGLICNEAP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly IEIMAIBIIFF HAEJDAAAPCC;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly IEIMAIBIIFF AOHAIFIHALN;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly IEIMAIBIIFF NLOJNDCMJHA;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly IEIMAIBIIFF FCLJCPMEMGG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly IEIMAIBIIFF HPHCAHJFBIB;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly IEIMAIBIIFF COLHFPMAILN;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly IEIMAIBIIFF FJNGJHCEFCO;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class ANBKKJLDLHP
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> FLKCAABPHED;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4C8B390", Offset = "0x4C8A390", VA = "0x184C8B390")]
	internal static object HOBJBBKLJHM(Type HLNBIKMPIPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4C8CCF0", Offset = "0x4C8BCF0", VA = "0x184C8CCF0")]
	private static object MFCJFNDEDID(Type MINDLJIBHOB, Type[] EGAINPPBHGP, params object[] OAHJKCAELAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class MELIOFJNBOM : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class KMIOCNAOMDG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x30C6C10", Offset = "0x30C5C10", VA = "0x1830C6C10")]
		static KMIOCNAOMDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly OPIGIGGOFGI CBCBKNCBBPP;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x49E1D70", Offset = "0x49E0D70", VA = "0x1849E1D70")]
	static MELIOFJNBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private MELIOFJNBOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class GMNCCKNKOCM : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class ANFHAHFHHAP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x324C510", Offset = "0x324B510", VA = "0x18324C510")]
		static ANFHAHFHHAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly OPIGIGGOFGI CBCBKNCBBPP;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x49D0550", Offset = "0x49CF550", VA = "0x1849D0550")]
	static GMNCCKNKOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private GMNCCKNKOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class PHFJIEHHHDG : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class NNENLJELKHO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2E29550", Offset = "0x2E28550", VA = "0x182E29550")]
		static NNENLJELKHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly OPIGIGGOFGI CBCBKNCBBPP;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4D643D0", Offset = "0x4D633D0", VA = "0x184D643D0")]
	static PHFJIEHHHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private PHFJIEHHHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class ENFHEFGFDAN : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class JNGIJIBLKFE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x31239F0", Offset = "0x31229F0", VA = "0x1831239F0")]
		static JNGIJIBLKFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly OPIGIGGOFGI CBCBKNCBBPP;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4CA0B40", Offset = "0x4C9FB40", VA = "0x184CA0B40")]
	static ENFHEFGFDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private ENFHEFGFDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class FIPAONBGKIL : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class OBGMFLCEEMC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3E0EC70", Offset = "0x3E0DC70", VA = "0x183E0EC70")]
		static OBGMFLCEEMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly OPIGIGGOFGI CBCBKNCBBPP;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x49CDAB0", Offset = "0x49CCAB0", VA = "0x1849CDAB0")]
	static FIPAONBGKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private FIPAONBGKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class NHJMDGFLJIF : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class OCCLLONCPCB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3E10090", Offset = "0x3E0F090", VA = "0x183E10090")]
		static OCCLLONCPCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly OPIGIGGOFGI CBCBKNCBBPP;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4D5DC70", Offset = "0x4D5CC70", VA = "0x184D5DC70")]
	static NHJMDGFLJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private NHJMDGFLJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class MGGHAFIKHNK : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class PHLGOOHCGNO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2D317D0", Offset = "0x2D307D0", VA = "0x182D317D0")]
		static PHLGOOHCGNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public MGGHAFIKHNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class LCMECFEMCPA : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class JIOGCEGNLHM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x39709F0", Offset = "0x396F9F0", VA = "0x1839709F0")]
		static JIOGCEGNLHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public LCMECFEMCPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class JDOPGDBGGIG : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class HBFHCAAHMGF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x267EAE0", Offset = "0x267DAE0", VA = "0x18267EAE0")]
		static HBFHCAAHMGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public JDOPGDBGGIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class HMDOFCMAAHP : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class PKOHLPOLOIH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2D41F50", Offset = "0x2D40F50", VA = "0x182D41F50")]
		static PKOHLPOLOIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public HMDOFCMAAHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class LEIACDBDJOL : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class ADAOMHCDBGM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x26D73F0", Offset = "0x26D63F0", VA = "0x1826D73F0")]
		static ADAOMHCDBGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public LEIACDBDJOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class IOHHHOHLJBI : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class KFBJOJKLEHC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x28FC260", Offset = "0x28FB260", VA = "0x1828FC260")]
		static KFBJOJKLEHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> NGJDAAMHCNP;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool GCDCGODCBAP;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public IOHHHOHLJBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class DLMEBDHBHHE
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct ABHBFJMNGGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CEMNOAKILIM HAJDHCGKNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder LHPBODDOAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder HHBDMIBEBPP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class KNLDKNFKNOP
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class EPBKGDDPLFL
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo IMLBEDMMGJI;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo IAGKEPPFCHI;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo OFPEGINFOBI;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo PPHIFGDGCBM;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo CHCKEOGGMPO;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo BOIJDCIIDIP;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo DDDNHKIFEDM;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo JGEPHLJPNEP;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo FMNOHHJBEDL;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x4D51AE0", Offset = "0x4D50AE0", VA = "0x184D51AE0")]
			static EPBKGDDPLFL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class JMJMNBCCALP
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo HKJCECDMGOH;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo BDHGMFNHFCB;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo AALKAAHAKEI;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo NGPOFMLILJF;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo IDONKGNHIIB;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo OADEJILKOJH;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo PCEMIJBKLDG;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x4D55700", Offset = "0x4D54700", VA = "0x184D55700")]
			static JMJMNBCCALP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class GOKMDHCBMKD
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo HFNGLDDAIMB;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo PEDALJFOEBG;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo MHMPNINKPCH;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo NGBFDKMKBBL;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo EDJFJJJENDJ;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo AELNADGBMNJ;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo AOJHGKCKOPN;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo DBOPOCBKIGH;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo LLOCNOANHGI;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo GLODDADCGMN;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo BPAFAFOHKMJ;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo PJDAENIKLFB;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo FBDNBKOKCOA;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo PPPNJOGDDLD;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4D5B3D0", Offset = "0x4D5A3D0", VA = "0x184D5B3D0")]
		public static MethodInfo HHDOHEHKDKI(Type BCFKLEGAMEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4D5B020", Offset = "0x4D5A020", VA = "0x184D5B020")]
		public static MethodInfo ADHMOLAJGDE(Type BCFKLEGAMEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4D5B290", Offset = "0x4D5A290", VA = "0x184D5B290")]
		public static MethodInfo GJNFJDFGLJO(Type BCFKLEGAMEO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class BEFBIMBABAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<CEMNOAKILIM, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public BEFBIMBABAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KMCGIJOBGNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public BEFBIMBABAI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public KMCGIJOBGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4D5ADA0", Offset = "0x4D59DA0", VA = "0x184D5ADA0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4D5AEB0", Offset = "0x4D59EB0", VA = "0x184D5AEB0")]
		internal bool <BuildType>b__2(int index, CEMNOAKILIM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class KDOFEOJGJPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public BEFBIMBABAI CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public KDOFEOJGJPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4D56400", Offset = "0x4D55400", VA = "0x184D56400")]
		internal bool <BuildType>b__3(int index, CEMNOAKILIM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class BEPGADDCAFK
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
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public BEPGADDCAFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4D51830", Offset = "0x4D50830", VA = "0x184D51830")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class OGJPJJJKCON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public OGJPJJJKCON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4D61D90", Offset = "0x4D60D90", VA = "0x184D61D90")]
		internal bool <BuildAnonymousFormatter>b__2(CEMNOAKILIM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class KIANOPFHPMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public BEPGADDCAFK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public KIANOPFHPMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x4D584E0", Offset = "0x4D574E0", VA = "0x184D584E0")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4D58560", Offset = "0x4D57560", VA = "0x184D58560")]
		internal bool <BuildAnonymousFormatter>b__6(int index, CEMNOAKILIM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class JCNKNOEMLNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public BEPGADDCAFK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public JCNKNOEMLNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4D55500", Offset = "0x4D54500", VA = "0x184D55500")]
		internal bool <BuildAnonymousFormatter>b__7(int index, CEMNOAKILIM member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class CBCPBFKKFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public CBCPBFKKFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x674FD0", Offset = "0x673FD0", VA = "0x180674FD0")]
		internal Label <BuildSerialize>b__1(CEMNOAKILIM _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class ACAJKFFALJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public ABHBFJMNGGO[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, CEMNOAKILIM, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public NMANGJFPHIB argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public NMANGJFPHIB argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public ACAJKFFALJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x4D50BF0", Offset = "0x4D4FBF0", VA = "0x184D50BF0")]
		internal ABHBFJMNGGO <BuildDeserialize>b__0(CEMNOAKILIM item)
		{
			return default(ABHBFJMNGGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class BCPDNMICFFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public ACAJKFFALJA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public BCPDNMICFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4D514C0", Offset = "0x4D504C0", VA = "0x184D514C0")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4D51790", Offset = "0x4D50790", VA = "0x184D51790")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class EFBJBDPPHJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CEMNOAKILIM item;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public EFBJBDPPHJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x1118010", Offset = "0x1117010", VA = "0x181118010")]
		internal bool <EmitNewObject>b__0(ABHBFJMNGGO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class PBCHAGHNHNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public CEMNOAKILIM item;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public PBCHAGHNHNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x1118010", Offset = "0x1117010", VA = "0x181118010")]
		internal bool <EmitNewObject>b__2(ABHBFJMNGGO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex DBHNIPOABDN;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int KKDFFLBADDL;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> JGKMLBPKGAG;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> DIBGGLDAALG;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x27C00A0", Offset = "0x27BF0A0", VA = "0x1827C00A0")]
	public static object KOPMFEKJNEA<T>(OPIGIGGOFGI CBCBKNCBBPP, IEIMAIBIIFF KIPDBODNOFI, Func<string, string> NGJDAAMHCNP, bool GCDCGODCBAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x290DBB0", Offset = "0x290CBB0", VA = "0x18290DBB0")]
	public static object LLKFJBJBAGB<T>(IEIMAIBIIFF KIPDBODNOFI, Func<string, string> NGJDAAMHCNP, bool GCDCGODCBAP, bool PLLOLPEIJDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4C9A6B0", Offset = "0x4C996B0", VA = "0x184C9A6B0")]
	private static TypeInfo MBPKLBDLJCK(OPIGIGGOFGI CBCBKNCBBPP, Type BCFKLEGAMEO, Func<string, string> NGJDAAMHCNP, bool GCDCGODCBAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4C96370", Offset = "0x4C95370", VA = "0x184C96370")]
	public static object DFGGOMEHHEO(Type BCFKLEGAMEO, Func<string, string> NGJDAAMHCNP, bool GCDCGODCBAP, bool PLLOLPEIJDN, bool LJEMAJCBEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4C99FD0", Offset = "0x4C98FD0", VA = "0x184C99FD0")]
	private static Dictionary<CEMNOAKILIM, FieldInfo> LOPNBIBMIPB(TypeBuilder GGONGCHGDNC, LJCJCOJOGPC MGMCENKLKLD, ConstructorInfo KLICPGCIOJL, FieldBuilder HKLDAOEALDJ, ILGenerator JLMHENJMMKI, bool GCDCGODCBAP, bool JJPDCLPKHPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B140", Offset = "0x4C9A140", VA = "0x184C9B140")]
	private static Dictionary<CEMNOAKILIM, FieldInfo> OOJFDGNKDEP(TypeBuilder GGONGCHGDNC, LJCJCOJOGPC MGMCENKLKLD, ILGenerator JLMHENJMMKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4C97EF0", Offset = "0x4C96EF0", VA = "0x184C97EF0")]
	private static void GLDDFNDOOBK(Type BCFKLEGAMEO, LJCJCOJOGPC MGMCENKLKLD, ILGenerator JLMHENJMMKI, Action HNKFJANLNOJ, Func<int, CEMNOAKILIM, bool> ELGGIDGEPCI, bool GCDCGODCBAP, bool JJPDCLPKHPM, int PDAMHCKDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4C94FC0", Offset = "0x4C93FC0", VA = "0x184C94FC0")]
	private static void CAKGPFEAIEG(TypeInfo BCFKLEGAMEO, CEMNOAKILIM KMOCGNMHJJK, ILGenerator JLMHENJMMKI, int MMABPPDCBIB, Func<int, CEMNOAKILIM, bool> ELGGIDGEPCI, NMANGJFPHIB FBNHINKPMEA, NMANGJFPHIB HJKFCOLLMEG, NMANGJFPHIB NLHKGBMJBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4C93BC0", Offset = "0x4C92BC0", VA = "0x184C93BC0")]
	private static void AOKMMMMFCLP(Type BCFKLEGAMEO, LJCJCOJOGPC MGMCENKLKLD, ILGenerator JLMHENJMMKI, Func<int, CEMNOAKILIM, bool> ELGGIDGEPCI, bool GNJCCKPELNE, int PDAMHCKDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4C99410", Offset = "0x4C98410", VA = "0x184C99410")]
	private static void HCOFLEFBMBO(ILGenerator JLMHENJMMKI, ABHBFJMNGGO MGMCENKLKLD, int MMABPPDCBIB, Func<int, CEMNOAKILIM, bool> ELGGIDGEPCI, NMANGJFPHIB CLOGDHPGNHC, NMANGJFPHIB NLHKGBMJBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4C95510", Offset = "0x4C94510", VA = "0x184C95510")]
	private static LocalBuilder CAMMONIPNMJ(ILGenerator JLMHENJMMKI, Type BCFKLEGAMEO, LJCJCOJOGPC MGMCENKLKLD, ABHBFJMNGGO[] FFLKLGKKAGJ, bool HGDPBGGLFKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4C998D0", Offset = "0x4C988D0", VA = "0x184C998D0")]
	private static bool IDLJMEFDIBC(ConstructorInfo PNGHCGPJBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4C961C0", Offset = "0x4C951C0", VA = "0x184C961C0")]
	private static bool CAOGIKIGEAH(Type BCFKLEGAMEO, out Type BCBKNCLAOFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void FCELMBPGBFH<T>(byte[][] HKLDAOEALDJ, object[] KOMJLBADEMB, ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF EPCNJMCAAGN);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T BOELHOAKOJP<T>(object[] KOMJLBADEMB, ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF EPCNJMCAAGN);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class FDHAOCCILDC<T> : global::HAKOMFHEDCC<T>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] HKLDAOEALDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] ILIDBMFFFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] OAJPHMALCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly global::FCELMBPGBFH<T> JAKCIDHCLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly global::BOELHOAKOJP<T> JPBCHOPICMD;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x25AF5B0", Offset = "0x25AE5B0", VA = "0x1825AF5B0")]
	public FDHAOCCILDC(byte[][] HKLDAOEALDJ, object[] ILIDBMFFFLJ, object[] OAJPHMALCGO, global::FCELMBPGBFH<T> JAKCIDHCLFK, global::BOELHOAKOJP<T> JPBCHOPICMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x25AF4D0", Offset = "0x25AE4D0", VA = "0x1825AF4D0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x25AF400", Offset = "0x25AE400", VA = "0x1825AF400", Slot = "5")]
	public T ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class GNNPGIDOLFE : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class NODCPHGCJGN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2E2D540", Offset = "0x2E2C540", VA = "0x182E2D540")]
		static NODCPHGCJGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private GNNPGIDOLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class JIEPFMLFIJO : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class LDEHKGOKDAM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CC30", Offset = "0x2A9BC30", VA = "0x182A9CC30")]
		static LDEHKGOKDAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private JIEPFMLFIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class LNOCEGFBMLC
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly IEIMAIBIIFF[] CCFJBJBMGOP;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class KNCFOECNLPL : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class HFFJHFDJCKN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2690500", Offset = "0x268F500", VA = "0x182690500")]
		static HFFJHFDJCKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class HHNCHLGHEOF : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class CKAEFKDAOGB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x2A05A40", Offset = "0x2A04A40", VA = "0x182A05A40")]
			static CKAEFKDAOGB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		private HHNCHLGHEOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private KNCFOECNLPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class FDKJLDCBAIF : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class OECJOALOIEK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3E189C0", Offset = "0x3E179C0", VA = "0x183E189C0")]
		static OECJOALOIEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class AFMNHBAHEPI : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class FMIEGANEFHP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3882B90", Offset = "0x3881B90", VA = "0x183882B90")]
			static FMIEGANEFHP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		private AFMNHBAHEPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private FDKJLDCBAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class ANFKNMEANDG : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class ENLECKDFGJB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x205AA90", Offset = "0x2059A90", VA = "0x18205AA90")]
		static ENLECKDFGJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class FAEIDJGELGD : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class CIEJJNCBMBO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x3B756A0", Offset = "0x3B746A0", VA = "0x183B756A0")]
			static CIEJJNCBMBO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		private FAEIDJGELGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private ANFKNMEANDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class OAOAJEMLIJK : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class HBMLHFFHAPH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2684310", Offset = "0x2683310", VA = "0x182684310")]
		static HBMLHFFHAPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class LPBADGAEGFD : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class DEPLCPCAPBC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x2E3BDA0", Offset = "0x2E3ADA0", VA = "0x182E3BDA0")]
			static DEPLCPCAPBC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		private LPBADGAEGFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private OAOAJEMLIJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class ONKAJJIHMIA : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class AHAGIIOADFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x26E2A30", Offset = "0x26E1A30", VA = "0x1826E2A30")]
		static AHAGIIOADFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class FNELEBAAHIG : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class AIAINCKJOEE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x323A930", Offset = "0x3239930", VA = "0x18323A930")]
			static AIAINCKJOEE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		private FNELEBAAHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private ONKAJJIHMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class LBOOAMBADNH : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class PFFHFLGNFPG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2D2A370", Offset = "0x2D29370", VA = "0x182D2A370")]
		static PFFHFLGNFPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class NFOLDAHGBJN : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class NMCCLFMPDBK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x2E1E0F0", Offset = "0x2E1D0F0", VA = "0x182E1E0F0")]
			static NMCCLFMPDBK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		private NFOLDAHGBJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private LBOOAMBADNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class FKJAKCEGPBF : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class EIOBCCCIOEN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2054620", Offset = "0x2053620", VA = "0x182054620")]
		static EIOBCCCIOEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class BJBHMKBIAHB : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class IGPPIAGMDOB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1BBAB30", Offset = "0x1BB9B30", VA = "0x181BBAB30")]
			static IGPPIAGMDOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		private BJBHMKBIAHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private FKJAKCEGPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class PLKLKPKOONK : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class EFOLJDFDHMA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x204BF90", Offset = "0x204AF90", VA = "0x18204BF90")]
		static EFOLJDFDHMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class IDJBCCFPABL : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class NBHIGLCHFLL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x2364840", Offset = "0x2363840", VA = "0x182364840")]
			static NBHIGLCHFLL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		private IDJBCCFPABL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private PLKLKPKOONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class GAGGIIHLIPA : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class JPLNDJDJOLP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x28E31B0", Offset = "0x28E21B0", VA = "0x1828E31B0")]
		static JPLNDJDJOLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class NJCMNGMOCHO : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class LFKIAFMCAGO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x2AA35D0", Offset = "0x2AA25D0", VA = "0x182AA35D0")]
			static LFKIAFMCAGO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		private NJCMNGMOCHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private GAGGIIHLIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class ODKLGKKLHFP : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class NMKPLOGNJLF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2E21E90", Offset = "0x2E20E90", VA = "0x182E21E90")]
		static NMKPLOGNJLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class LJJKFCBAKPO : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class DEJLDJKNKHA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x382B460", Offset = "0x382A460", VA = "0x18382B460")]
			static DEJLDJKNKHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		private LJJKFCBAKPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private ODKLGKKLHFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class COAMHBLJGIO : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class OPNDJJGANEG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x42950C0", Offset = "0x42940C0", VA = "0x1842950C0")]
		static OPNDJJGANEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class PAHJLGIGNNN : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class NFNPNFOBPHH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x236CE30", Offset = "0x236BE30", VA = "0x18236CE30")]
			static NFNPNFOBPHH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		private PAHJLGIGNNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private COAMHBLJGIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class DCENOHBMGDL : IEIMAIBIIFF
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class GLHPDCILBHO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x379D930", Offset = "0x379C930", VA = "0x18379D930")]
		static GLHPDCILBHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class GIMEMPHOHIF : IEIMAIBIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class AHODEHDCIEM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly global::HAKOMFHEDCC<T> IJLAHEJMODK;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x3237AA0", Offset = "0x3236AA0", VA = "0x183237AA0")]
			static AHODEHDCIEM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly IEIMAIBIIFF KGCADEGMLJC;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly IEIMAIBIIFF[] MKAFKJIJMOL;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		private GIMEMPHOHIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
		public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly IEIMAIBIIFF KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly global::HAKOMFHEDCC<object> JDLFCDALFMA;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	private DCENOHBMGDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FBA0", Offset = "0x1E9EBA0", VA = "0x181E9FBA0", Slot = "4")]
	public global::HAKOMFHEDCC<T> HOBJBBKLJHM<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct DAFGBDPGAFN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] ELPGOHJDPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int ADODPFDEIHD;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x34A2F60", Offset = "0x34A1F60", VA = "0x1834A2F60")]
	public DAFGBDPGAFN(int DNLGEKMDGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x34A2DE0", Offset = "0x34A1DE0", VA = "0x1834A2DE0")]
	public void CEMPCIEDPMO(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x34A2ED0", Offset = "0x34A1ED0", VA = "0x1834A2ED0")]
	public T[] HHOLENPNECD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class HKJHDFDCLFD : global::IOAKBHOGHOE<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly HKJHDFDCLFD PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x49D9E30", Offset = "0x49D8E30", VA = "0x1849D9E30")]
	public HKJHDFDCLFD(int ICIICBAPACO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class IOAKBHOGHOE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int ICIICBAPACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object IIHNMJCHHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int MMABPPDCBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] HAIEAFBBEJF;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8090", Offset = "0x2DE7090", VA = "0x182DE8090")]
	public IOAKBHOGHOE(int ICIICBAPACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6FD0", Offset = "0x2DE5FD0", VA = "0x182DE6FD0")]
	public T[] BJMFEPDOEII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2DE7C40", Offset = "0x2DE6C40", VA = "0x182DE7C40")]
	public void DIIMFKBAEGA(T[] KPAFOBEJBIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class NHNNFMDDFBM : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class HJHOGHDMJKG : IComparable<HJHOGHDMJKG>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class NOBBKFGCBJM : IEnumerable<HJHOGHDMJKG>, IEnumerable, IEnumerator<HJHOGHDMJKG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private HJHOGHDMJKG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public HJHOGHDMJKG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private HJHOGHDMJKG System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F4")]
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E90", Offset = "0x8D5E90", VA = "0x1808D6E90")]
			[DebuggerHidden]
			public NOBBKFGCBJM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x4D5E950", Offset = "0x4D5D950", VA = "0x184D5E950", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x4D5EA80", Offset = "0x4D5DA80", VA = "0x184D5EA80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x4D5E9E0", Offset = "0x4D5D9E0", VA = "0x184D5E9E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<HJHOGHDMJKG> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x4D5E9E0", Offset = "0x4D5D9E0", VA = "0x184D5E9E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class CGBLMOMJCMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public CGBLMOMJCMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x674FD0", Offset = "0x673FD0", VA = "0x180674FD0")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x674FD0", Offset = "0x673FD0", VA = "0x180674FD0")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly HJHOGHDMJKG[] OOIICPNDAED;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] AGJNHKAEPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong PIDBPEBBCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int FHONEBOCBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string NDAMAGLBMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private HJHOGHDMJKG[] HABCDDBMHNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] ILEKIACLDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int LGKBEOCJMLG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool PDAKCIFKIFL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xD90350", Offset = "0xD8F350", VA = "0x180D90350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4D55280", Offset = "0x4D54280", VA = "0x184D55280")]
		public HJHOGHDMJKG(ulong AGPLDPOAAIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4D54A70", Offset = "0x4D53A70", VA = "0x184D54A70")]
		public HJHOGHDMJKG CEMPCIEDPMO(ulong AGPLDPOAAIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4D54CA0", Offset = "0x4D53CA0", VA = "0x184D54CA0")]
		public HJHOGHDMJKG CEMPCIEDPMO(ulong AGPLDPOAAIC, int CCIMHDCKHOF, string NDAMAGLBMII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4D54F50", Offset = "0x4D53F50", VA = "0x184D54F50")]
		public HJHOGHDMJKG EOHPKLECDBA(byte[] OGGODOHJPHN, ref int EGBIMJLECFF, ref int OILHPMFBCIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x4D55100", Offset = "0x4D54100", VA = "0x184D55100")]
		internal static int FKPLEGPKICI(ulong[] KPAFOBEJBIN, int MMABPPDCBIB, int HOPGLJCPGGA, ulong CCIMHDCKHOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4D54CF0", Offset = "0x4D53CF0", VA = "0x184D54CF0", Slot = "4")]
		public int CompareTo(HJHOGHDMJKG IIKMMJKCGDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4D55180", Offset = "0x4D54180", VA = "0x184D55180")]
		[IteratorStateMachine(typeof(NOBBKFGCBJM))]
		public IEnumerable<HJHOGHDMJKG> LACGBOCNHEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4D54D20", Offset = "0x4D53D20", VA = "0x184D54D20")]
		public void DNCBELJPHCI(ILGenerator JLMHENJMMKI, LocalBuilder OGGODOHJPHN, LocalBuilder OILHPMFBCIA, LocalBuilder AGPLDPOAAIC, Action<KeyValuePair<string, int>> MMJNGDNPFII, Action OJAKMPCENEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4D53C70", Offset = "0x4D52C70", VA = "0x184D53C70")]
		private static void BJAHMEAADAO(ILGenerator JLMHENJMMKI, LocalBuilder OGGODOHJPHN, LocalBuilder OILHPMFBCIA, LocalBuilder AGPLDPOAAIC, Action<KeyValuePair<string, int>> MMJNGDNPFII, Action OJAKMPCENEP, HJHOGHDMJKG[] HABCDDBMHNH, int LGKBEOCJMLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class FGCOBHOKJJC : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<HJHOGHDMJKG> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<HJHOGHDMJKG> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<HJHOGHDMJKG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private HJHOGHDMJKG <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x66B040", Offset = "0x66A040", VA = "0x18066B040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D52EF0", Offset = "0x4D51EF0", VA = "0x184D52EF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xAA5B20", Offset = "0xAA4B20", VA = "0x180AA5B20")]
		[DebuggerHidden]
		public FGCOBHOKJJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x4D52F40", Offset = "0x4D51F40", VA = "0x184D52F40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4D52A80", Offset = "0x4D51A80", VA = "0x184D52A80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x4D53020", Offset = "0x4D52020", VA = "0x184D53020")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x4D53070", Offset = "0x4D52070", VA = "0x184D53070")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x4D52EB0", Offset = "0x4D51EB0", VA = "0x184D52EB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x4D52E10", Offset = "0x4D51E10", VA = "0x184D52E10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x4D52E10", Offset = "0x4D51E10", VA = "0x184D52E10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly HJHOGHDMJKG ODPHCGBINJN;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D5E3B0", Offset = "0x4D5D3B0", VA = "0x184D5E3B0")]
	public NHNNFMDDFBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D5DDA0", Offset = "0x4D5CDA0", VA = "0x184D5DDA0")]
	public void CEMPCIEDPMO(byte[] CDDAIIMDJCN, int CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4D5DF20", Offset = "0x4D5CF20", VA = "0x184D5DF20")]
	public bool HFFJFKHBBCI(ArraySegment<byte> AGPLDPOAAIC, out int CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4D5E320", Offset = "0x4D5D320", VA = "0x184D5E320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4D5E080", Offset = "0x4D5D080", VA = "0x184D5E080")]
	private static void PPCPNNHHCLP(IEnumerable<HJHOGHDMJKG> HABCDDBMHNH, StringBuilder IDIEBAILNNP, int FOCIGJDPHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4D5DEC0", Offset = "0x4D5CEC0", VA = "0x184D5DEC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4D5DEC0", Offset = "0x4D5CEC0", VA = "0x184D5DEC0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4D5DFE0", Offset = "0x4D5CFE0", VA = "0x184D5DFE0")]
	[IteratorStateMachine(typeof(FGCOBHOKJJC))]
	private static IEnumerable<KeyValuePair<string, int>> JFLAPAOFJBJ(IEnumerable<HJHOGHDMJKG> HABCDDBMHNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4D5E050", Offset = "0x4D5D050", VA = "0x184D5E050")]
	public void PBDHIKOIDKD(ILGenerator JLMHENJMMKI, LocalBuilder OGGODOHJPHN, LocalBuilder OILHPMFBCIA, LocalBuilder AGPLDPOAAIC, Action<KeyValuePair<string, int>> MMJNGDNPFII, Action OJAKMPCENEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class FGFGOFFDKCM
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo FDJNPCEAPAC;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x49CC1A0", Offset = "0x49CB1A0", VA = "0x1849CC1A0")]
	public static ulong ALBMBDILJMJ(byte[] CDDAIIMDJCN, ref int EGBIMJLECFF, ref int OILHPMFBCIA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class OABALJGCOHF
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4D5FF30", Offset = "0x4D5EF30", VA = "0x184D5FF30")]
	public static void LOKAJEFELOL(ref byte[] CDDAIIMDJCN, int EGBIMJLECFF, int ANPLBJOGOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4D5FD00", Offset = "0x4D5ED00", VA = "0x184D5FD00")]
	public static void GJDNMKDIPIC(ref byte[] KPAFOBEJBIN, int OFPFHBDEIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4D5FE10", Offset = "0x4D5EE10", VA = "0x184D5FE10")]
	public static byte[] JICICOOHGGE(byte[] EADBNCPOLHD, int OFPFHBDEIHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class MFMAEELPDLD
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x49E22D0", Offset = "0x49E12D0", VA = "0x1849E22D0")]
	public static bool FMLLLJFHODI(byte[] DACJMGLKOIC, int BALJHKLKOHC, int DOHCFGPMBJK, byte[] OCJDBNFNKJF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class GALOOIHPGNA<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct GLBLOMDDEOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] PIDBPEBBCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T FHONEBOCBPE;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3792C20", Offset = "0x3791C20", VA = "0x183792C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class EABGNMBDGPM : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public global::GALOOIHPGNA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private GLBLOMDDEOM[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private GLBLOMDDEOM[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x66B040", Offset = "0x66A040", VA = "0x18066B040", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x298F060", Offset = "0x298E060", VA = "0x18298F060", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2015CB0", Offset = "0x2014CB0", VA = "0x182015CB0")]
		[DebuggerHidden]
		public EABGNMBDGPM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x298E3E0", Offset = "0x298D3E0", VA = "0x18298E3E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x298EA90", Offset = "0x298DA90", VA = "0x18298EA90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly GLBLOMDDEOM[][] DPNCDJHECLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong KBGGJKMDFNL;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB850", Offset = "0x3EDA850", VA = "0x183EDB850")]
	public GALOOIHPGNA(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x3EDB790", Offset = "0x3EDA790", VA = "0x183EDB790")]
	public GALOOIHPGNA(int JAFEKEGLGFD, float KEJIFFLPGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x41B89A0", Offset = "0x41B79A0", VA = "0x1841B89A0")]
	public void CEMPCIEDPMO(byte[] AGPLDPOAAIC, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x41B97D0", Offset = "0x41B87D0", VA = "0x1841B97D0")]
	private bool NBHKAKNIKMG(byte[] AGPLDPOAAIC, T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x41B8B50", Offset = "0x41B7B50", VA = "0x1841B8B50")]
	public bool EPBHELLGDLM(ArraySegment<byte> AGPLDPOAAIC, out T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x3ED4B30", Offset = "0x3ED3B30", VA = "0x183ED4B30")]
	private static ulong MPDIMNOKGAO(byte[] ODLLFOGPPIE, int EGBIMJLECFF, int LGKBEOCJMLG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3120DD0", Offset = "0x311FDD0", VA = "0x183120DD0")]
	private static int BKGCHOKJAIB(int AKICHLKOMJD, float KEJIFFLPGLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x3ED48F0", Offset = "0x3ED38F0", VA = "0x183ED48F0", Slot = "4")]
	[IteratorStateMachine(typeof(global::GALOOIHPGNA<>.EABGNMBDGPM))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2361EB0", Offset = "0x2360EB0", VA = "0x182361EB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class GLPLDCNLFKN : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] KGDPPPOINOH;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] BBFEFLOIDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int EHCNGOCKAMG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool ILOCCBANMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x49D00E0", Offset = "0x49CF0E0", VA = "0x1849D00E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x49D0250", Offset = "0x49CF250", VA = "0x1849D0250")]
	static GLPLDCNLFKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x49D04D0", Offset = "0x49CF4D0", VA = "0x1849D04D0")]
	public GLPLDCNLFKN(byte[] FNGAFOCJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x49D0130", Offset = "0x49CF130", VA = "0x1849D0130")]
	public OpCode PNGPIJBCMBK()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct DLMOJCANJBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid FHONEBOCBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte PHHELBDBJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte JPJLBNFANPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte LIAKCGOPKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte BPOJDDJLJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte ANFLJHICADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte KEDEMILHKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte LCBMOLCBHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte FHGLMDKHKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte FPGELKOEBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte AEKMKLMCHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte HKBLLOHCCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte DAICEIBEBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte MCLALMKKCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte DNIHIAIGAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte MNNFGEJAADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte HJEDDMBJMMM;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] GEICOJKPKPC;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] AOPDEPBKGJI;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4C9D3F0", Offset = "0x4C9C3F0", VA = "0x184C9D3F0")]
	public DLMOJCANJBN(ref Guid CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4C9D400", Offset = "0x4C9C400", VA = "0x184C9D400")]
	public DLMOJCANJBN(ref ArraySegment<byte> BOEBJHAFKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4C9D260", Offset = "0x4C9C260", VA = "0x184C9D260")]
	private static byte HKOGJNEAEBJ(byte[] CDDAIIMDJCN, int GGODGFOCGCB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4C9BE00", Offset = "0x4C9AE00", VA = "0x184C9BE00")]
	private static byte EIINECOGOII(byte ENHIJCCJFBF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4C9BF10", Offset = "0x4C9AF10", VA = "0x184C9BF10")]
	public void EPOIFDELDCH(byte[] NCCOCLJLPFP, int EGBIMJLECFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class ALLDDJCGDNN
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4C8AE30", Offset = "0x4C89E30", VA = "0x184C8AE30")]
	public static bool HKOPBKKOPJL(byte ODCENIJJKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4C8AF90", Offset = "0x4C89F90", VA = "0x184C8AF90")]
	public static bool MIGJJBPLHKH(byte ODCENIJJKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x4C8ADC0", Offset = "0x4C89DC0", VA = "0x184C8ADC0")]
	public static sbyte ENIFFBLFONM(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x4C8AEB0", Offset = "0x4C89EB0", VA = "0x184C8AEB0")]
	public static short LJPINJKNAOG(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x4C8B320", Offset = "0x4C8A320", VA = "0x184C8B320")]
	public static int PMGMFGBIFDG(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x4C8B000", Offset = "0x4C8A000", VA = "0x184C8B000")]
	public static long OKAACLJBNNN(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x4C8AE40", Offset = "0x4C89E40", VA = "0x184C8AE40")]
	public static byte JGDKDGKAPBP(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x4C8AD50", Offset = "0x4C89D50", VA = "0x184C8AD50")]
	public static ushort EACPFKLCNCF(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x4C8A0A0", Offset = "0x4C890A0", VA = "0x184C8A0A0")]
	public static uint DDDBNCKOJAF(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x4C897C0", Offset = "0x4C887C0", VA = "0x184C897C0")]
	public static ulong CHHDFFDMPBB(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x4C8AF20", Offset = "0x4C89F20", VA = "0x184C8AF20")]
	public static float LOHCAAFDECB(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x4C89750", Offset = "0x4C88750", VA = "0x184C89750")]
	public static double BGCLNPNNNGI(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x4C898D0", Offset = "0x4C888D0", VA = "0x184C898D0")]
	public static int CKBJNKDOMLF(ref byte[] NCCOCLJLPFP, int EGBIMJLECFF, ulong CCIMHDCKHOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x4C8A120", Offset = "0x4C89120", VA = "0x184C8A120")]
	public static int DILLBKEAJFJ(ref byte[] NCCOCLJLPFP, int EGBIMJLECFF, long CCIMHDCKHOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x4C8B0B0", Offset = "0x4C8A0B0", VA = "0x184C8B0B0")]
	public static bool PHHFPHGKEHB(byte[] CDDAIIMDJCN, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class FJAHIFDJCMB
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class BBJLLNPEINF : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E90", Offset = "0x8D5E90", VA = "0x1808D6E90")]
		[DebuggerHidden]
		public BBJLLNPEINF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x4D51330", Offset = "0x4D50330", VA = "0x184D51330", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x4D50ED0", Offset = "0x4D4FED0", VA = "0x184D50ED0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x4D51420", Offset = "0x4D50420", VA = "0x184D51420")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x4D51470", Offset = "0x4D50470", VA = "0x184D51470")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x4D512F0", Offset = "0x4D502F0", VA = "0x184D512F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x4D51240", Offset = "0x4D50240", VA = "0x184D51240", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x4D51240", Offset = "0x4D50240", VA = "0x184D51240", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class ODLGIOFKFKA : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E90", Offset = "0x8D5E90", VA = "0x1808D6E90")]
		[DebuggerHidden]
		public ODLGIOFKFKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x4D60790", Offset = "0x4D5F790", VA = "0x184D60790", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x4D60330", Offset = "0x4D5F330", VA = "0x184D60330", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4D60880", Offset = "0x4D5F880", VA = "0x184D60880")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4D608D0", Offset = "0x4D5F8D0", VA = "0x184D608D0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x4D60750", Offset = "0x4D5F750", VA = "0x184D60750", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x4D606A0", Offset = "0x4D5F6A0", VA = "0x184D606A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x4D606A0", Offset = "0x4D5F6A0", VA = "0x184D606A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x49CDFC0", Offset = "0x49CCFC0", VA = "0x1849CDFC0")]
	public static bool NIBNFGICFPI(this TypeInfo BCFKLEGAMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x49CDE10", Offset = "0x49CCE10", VA = "0x1849CDE10")]
	public static bool LHKDPICAABE(this TypeInfo BCFKLEGAMEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x49CDC70", Offset = "0x49CCC70", VA = "0x1849CDC70")]
	public static IEnumerable<PropertyInfo> DOLBJGPMHCB(this Type BCFKLEGAMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x49CDF30", Offset = "0x49CCF30", VA = "0x1849CDF30")]
	[IteratorStateMachine(typeof(BBJLLNPEINF))]
	private static IEnumerable<PropertyInfo> MKPECKBBINM(Type BCFKLEGAMEO, HashSet<string> LKOIPNOFAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x49CDD40", Offset = "0x49CCD40", VA = "0x1849CDD40")]
	public static IEnumerable<FieldInfo> FFCCDHNCLLC(this Type BCFKLEGAMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x49CDBE0", Offset = "0x49CCBE0", VA = "0x1849CDBE0")]
	[IteratorStateMachine(typeof(ODLGIOFKFKA))]
	private static IEnumerable<FieldInfo> BMPHBNCILFM(Type BCFKLEGAMEO, HashSet<string> LKOIPNOFAFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class AIFDPCCCKNB
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding AOAGKAKLGDG;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class DEHNLNAKOFA
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x72A040", Offset = "0x729040", VA = "0x18072A040")]
	public static string OEPHGJDPPML(string OLNLINPGBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4C938C0", Offset = "0x4C928C0", VA = "0x184C938C0")]
	public static string AAFOJFEGMLM(string OLNLINPGBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4C939D0", Offset = "0x4C929D0", VA = "0x184C939D0")]
	public static string LOGHJLKDJGP(string OLNLINPGBEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class JMJBDOGCDKP<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class DDFCINLLBAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type PIDBPEBBCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue FHONEBOCBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int OJICPCDJBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public DDFCINLLBAL ABOGINNEAHO;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3820B20", Offset = "0x381FB20", VA = "0x183820B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3820AA0", Offset = "0x381FAA0", VA = "0x183820AA0")]
		private int CAAMIJFBOBJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public DDFCINLLBAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class ILEGLNCBIAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public ILEGLNCBIAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xD92380", Offset = "0xD91380", VA = "0x180D92380")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private DDFCINLLBAL[] DPNCDJHECLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int FBPAKFCOLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object ACFHOAOMEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float KEJIFFLPGLJ;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x31221C0", Offset = "0x31211C0", VA = "0x1831221C0")]
	public JMJBDOGCDKP(int JAFEKEGLGFD = 4, float KEJIFFLPGLJ = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x3121270", Offset = "0x3120270", VA = "0x183121270")]
	public bool KFCNCOMHECF(Type AGPLDPOAAIC, TValue CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x3121230", Offset = "0x3120230", VA = "0x183121230")]
	public bool KFCNCOMHECF(Type AGPLDPOAAIC, Func<Type, TValue> NANJNKGKLCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x3121BF0", Offset = "0x3120BF0", VA = "0x183121BF0")]
	private bool NBHKAKNIKMG(Type AGPLDPOAAIC, Func<Type, TValue> NANJNKGKLCA, out TValue IMPGIGIMHFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3121490", Offset = "0x3120490", VA = "0x183121490")]
	private bool LBOPEFGIGHA(DDFCINLLBAL[] DPNCDJHECLC, Type JGMDBJEPBGM, DDFCINLLBAL GPILHAMMLDE, Func<Type, TValue> NANJNKGKLCA, out TValue IMPGIGIMHFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3120F50", Offset = "0x311FF50", VA = "0x183120F50")]
	public bool EPBHELLGDLM(Type AGPLDPOAAIC, out TValue CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x3121140", Offset = "0x3120140", VA = "0x183121140")]
	public TValue FNLIBAGKGPC(Type AGPLDPOAAIC, Func<Type, TValue> NANJNKGKLCA)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x3120DD0", Offset = "0x311FDD0", VA = "0x183120DD0")]
	private static int BKGCHOKJAIB(int AKICHLKOMJD, float KEJIFFLPGLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x3122190", Offset = "0x3121190", VA = "0x183122190")]
	private static void OBJBLKLEIFC(ref DDFCINLLBAL HMPMFMHHLJE, DDFCINLLBAL CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x3122190", Offset = "0x3121190", VA = "0x183122190")]
	private static void OBJBLKLEIFC(ref DDFCINLLBAL[] HMPMFMHHLJE, DDFCINLLBAL[] CCIMHDCKHOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class OPIGIGGOFGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder LHDNBHCFDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder MEKNNJPHEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object IIHNMJCHHIL;

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x4D63C50", Offset = "0x4D62C50", VA = "0x184D63C50")]
	public TypeBuilder EFKOOAJBFML(string FOGNBJMCDMG, TypeAttributes KOBIAOOHOMD, Type OJKLIAPCMPJ, Type[] KJIPHEDAENM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x4D63D20", Offset = "0x4D62D20", VA = "0x184D63D20")]
	public OPIGIGGOFGI(string AFPCEBMPCFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class CFJJFDPGKDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F570", Offset = "0x4C8E570", VA = "0x184C8F570")]
	private static MethodInfo NIAFLBCEMPF(LambdaExpression LLJKFCHKLGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2652A80", Offset = "0x2651A80", VA = "0x182652A80")]
	public static MethodInfo JFPDEICILOD<T>(Expression<Func<T>> LLJKFCHKLGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2652A80", Offset = "0x2651A80", VA = "0x182652A80")]
	public static MethodInfo JFPDEICILOD<T, TR>(Expression<Func<T, TR>> LLJKFCHKLGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2652A80", Offset = "0x2651A80", VA = "0x182652A80")]
	public static MethodInfo JFPDEICILOD<T>(Expression<Action<T>> LLJKFCHKLGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x2652A80", Offset = "0x2651A80", VA = "0x182652A80")]
	public static MethodInfo JFPDEICILOD<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> LLJKFCHKLGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x26529D0", Offset = "0x26519D0", VA = "0x1826529D0")]
	private static MemberInfo BFGJIAHLHBF<T>(Expression<T> LENKHFNFMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2652A90", Offset = "0x2651A90", VA = "0x182652A90")]
	public static PropertyInfo LENLBPOFOIG<T, TR>(Expression<Func<T, TR>> LLJKFCHKLGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct NMANGJFPHIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int GBIDHHJLPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool JFDAHDMBGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator JLMHENJMMKI;

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4D5E8B0", Offset = "0x4D5D8B0", VA = "0x184D5E8B0")]
	public NMANGJFPHIB(ILGenerator JLMHENJMMKI, int GBIDHHJLPLE, bool JFDAHDMBGKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4D5E820", Offset = "0x4D5D820", VA = "0x184D5E820")]
	public NMANGJFPHIB(ILGenerator JLMHENJMMKI, int GBIDHHJLPLE, Type BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x4D5E700", Offset = "0x4D5D700", VA = "0x184D5E700")]
	public void BKCKIKOLEEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class OGENDCDLIOP
{
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x4D613E0", Offset = "0x4D603E0", VA = "0x184D613E0")]
	public static void LNNBCCBJNLF(this ILGenerator JLMHENJMMKI, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x4D613A0", Offset = "0x4D603A0", VA = "0x184D613A0")]
	public static void LNNBCCBJNLF(this ILGenerator JLMHENJMMKI, LocalBuilder KGCMFDEFHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x4D61130", Offset = "0x4D60130", VA = "0x184D61130")]
	public static void LMDBNPMIEPI(this ILGenerator JLMHENJMMKI, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x4D61360", Offset = "0x4D60360", VA = "0x184D61360")]
	public static void LMDBNPMIEPI(this ILGenerator JLMHENJMMKI, LocalBuilder KGCMFDEFHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4D60D70", Offset = "0x4D5FD70", VA = "0x184D60D70")]
	public static void EGPKCNOIOAK(this ILGenerator JLMHENJMMKI, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4D60C60", Offset = "0x4D5FC60", VA = "0x184D60C60")]
	public static void EGPKCNOIOAK(this ILGenerator JLMHENJMMKI, LocalBuilder KGCMFDEFHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x4D60BD0", Offset = "0x4D5FBD0", VA = "0x184D60BD0")]
	public static void AKLJKGDJDKL(this ILGenerator JLMHENJMMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4D60E60", Offset = "0x4D5FE60", VA = "0x184D60E60")]
	public static void JEMIIHEMIFH(this ILGenerator JLMHENJMMKI, bool CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4D61710", Offset = "0x4D60710", VA = "0x184D61710")]
	public static void OAFAPENJCAE(this ILGenerator JLMHENJMMKI, int CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4D60AE0", Offset = "0x4D5FAE0", VA = "0x184D60AE0")]
	public static void ADJHPBEDKPC(this ILGenerator JLMHENJMMKI, Type BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4D61CE0", Offset = "0x4D60CE0", VA = "0x184D61CE0")]
	public static void PGCNDHMEMOG(this ILGenerator JLMHENJMMKI, Type BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x4D60E70", Offset = "0x4D5FE70", VA = "0x184D60E70")]
	public static void LAJDDJDALCC(this ILGenerator JLMHENJMMKI, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x4D60BE0", Offset = "0x4D5FBE0", VA = "0x184D60BE0")]
	public static void DHDKAOKDFNF(this ILGenerator JLMHENJMMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x4D61B60", Offset = "0x4D60B60", VA = "0x184D61B60")]
	public static void OIDPGCBNABC(this ILGenerator JLMHENJMMKI, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x4D61610", Offset = "0x4D60610", VA = "0x184D61610")]
	public static void MOHHCFBPDJA(this ILGenerator JLMHENJMMKI, MethodInfo BDEKHACDIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x4D61C50", Offset = "0x4D60C50", VA = "0x184D61C50")]
	public static void OILJIJNPEIF(this ILGenerator JLMHENJMMKI, FieldInfo FHBODNBOFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x4D610A0", Offset = "0x4D600A0", VA = "0x184D610A0")]
	public static void LCBOENJEKMP(this ILGenerator JLMHENJMMKI, ulong CCIMHDCKHOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class CEMNOAKILIM
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class KAKPNDMCGGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public KAKPNDMCGGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x4D562F0", Offset = "0x4D552F0", VA = "0x184D562F0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo NOFHOKMPPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo MCEDEJFOBHJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string AKFKAJPCNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x66A130", Offset = "0x669130", VA = "0x18066A130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string GBNBDHBJGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x66A140", Offset = "0x669140", VA = "0x18066A140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OGOHDJDFOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x4C8EF30", Offset = "0x4C8DF30", VA = "0x184C8EF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LEDOELFIBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6653D0", Offset = "0x6643D0", VA = "0x1806653D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7711D0", Offset = "0x7701D0", VA = "0x1807711D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool HGKMPNOLHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6653E0", Offset = "0x6643E0", VA = "0x1806653E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xD1BDF0", Offset = "0xD1ADF0", VA = "0x180D1BDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type JIDICLJAOHP
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x68C1C0", Offset = "0x68B1C0", VA = "0x18068C1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo FBMDEMBJCAN
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6606F0", Offset = "0x65F6F0", VA = "0x1806606F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6E2AE0", Offset = "0x6E1AE0", VA = "0x1806E2AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo CBOFHNLIFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x651590", Offset = "0x650590", VA = "0x180651590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo DPIEFFAGEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x651580", Offset = "0x650580", VA = "0x180651580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6515A0", Offset = "0x6505A0", VA = "0x1806515A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F4F0", Offset = "0x4C8E4F0", VA = "0x184C8F4F0")]
	protected CEMNOAKILIM(Type BCFKLEGAMEO, string FOGNBJMCDMG, string OFKKNNHOFPP, bool LJMKDJGBOBE, bool NFINBHEMDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F3E0", Offset = "0x4C8E3E0", VA = "0x184C8F3E0")]
	public CEMNOAKILIM(FieldInfo MGMCENKLKLD, string FOGNBJMCDMG, bool PLLOLPEIJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F230", Offset = "0x4C8E230", VA = "0x184C8F230")]
	public CEMNOAKILIM(PropertyInfo MGMCENKLKLD, string FOGNBJMCDMG, bool PLLOLPEIJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EF40", Offset = "0x4C8DF40", VA = "0x184C8EF40")]
	private static MethodInfo GNHIHEPILPD(MemberInfo MGMCENKLKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x26528C0", Offset = "0x26518C0", VA = "0x1826528C0")]
	public T IDCLHHKJIEJ<T>(bool NFBANMIGLAM) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F0B0", Offset = "0x4C8E0B0", VA = "0x184C8F0B0", Slot = "4")]
	public virtual void NBIBPNOIJFM(ILGenerator JLMHENJMMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F170", Offset = "0x4C8E170", VA = "0x184C8F170", Slot = "5")]
	public virtual void OBEHIMGHJMN(ILGenerator JLMHENJMMKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class OGBPIKBNBME : CEMNOAKILIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string ACDKDCCBEEH;

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x4D60A20", Offset = "0x4D5FA20", VA = "0x184D60A20")]
	public OGBPIKBNBME(string FOGNBJMCDMG, string ACDKDCCBEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x4D60920", Offset = "0x4D5F920", VA = "0x184D60920", Slot = "4")]
	public override void NBIBPNOIJFM(ILGenerator JLMHENJMMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x4D609E0", Offset = "0x4D5F9E0", VA = "0x184D609E0", Slot = "5")]
	public override void OBEHIMGHJMN(ILGenerator JLMHENJMMKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class LEFHPDNIMHB : CEMNOAKILIM
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo ALBHBCAFMMC;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo JFOMNJOEECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal NMANGJFPHIB DGIOFPKJJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal NMANGJFPHIB HJKFCOLLMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal NMANGJFPHIB NLHKGBMJBBO;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x49DEAF0", Offset = "0x49DDAF0", VA = "0x1849DEAF0")]
	public LEFHPDNIMHB(string FOGNBJMCDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x49DE490", Offset = "0x49DD490", VA = "0x1849DE490", Slot = "4")]
	public override void NBIBPNOIJFM(ILGenerator JLMHENJMMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x49DE560", Offset = "0x49DD560", VA = "0x1849DE560", Slot = "5")]
	public override void OBEHIMGHJMN(ILGenerator JLMHENJMMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x49DE370", Offset = "0x49DD370", VA = "0x1849DE370")]
	public void FLFCJDDJNAP(ILGenerator JLMHENJMMKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class LJCJCOJOGPC
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type JIDICLJAOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x66A130", Offset = "0x669130", VA = "0x18066A130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool EPKDIGIOIOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6648D0", Offset = "0x6638D0", VA = "0x1806648D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x686000", Offset = "0x685000", VA = "0x180686000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool ILKBPOGLANH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x72E7F0", Offset = "0x72D7F0", VA = "0x18072E7F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x72E800", Offset = "0x72D800", VA = "0x18072E800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo NCMDJJLNNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x64B130", Offset = "0x64A130", VA = "0x18064B130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public CEMNOAKILIM[] IGMNLKLADJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x68C1C0", Offset = "0x68B1C0", VA = "0x18068C1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public CEMNOAKILIM[] BECKPIFBCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6606F0", Offset = "0x65F6F0", VA = "0x1806606F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E2AE0", Offset = "0x6E1AE0", VA = "0x1806E2AE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x49DF0D0", Offset = "0x49DE0D0", VA = "0x1849DF0D0")]
	public LJCJCOJOGPC(Type BCFKLEGAMEO, Func<string, string> JAJHNDJJCAF, bool PLLOLPEIJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x49DEFE0", Offset = "0x49DDFE0", VA = "0x1849DEFE0")]
	private static bool LOJHMHMLDAO(IEnumerator<ConstructorInfo> BNHLHGFLKBK, ref ConstructorInfo MLOFEDGPNAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct FNBMOHMOAFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong BPJEFFCEPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int GHAPGMJOMOM;

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E9A0", Offset = "0x1F7D9A0", VA = "0x181F7E9A0")]
	public FNBMOHMOAFJ(ulong JNPNBGAKPBA, int KMMODGACMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x49CE280", Offset = "0x49CD280", VA = "0x1849CE280")]
	public void EJHJNHLFHBL(ref FNBMOHMOAFJ IIKMMJKCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x49CE1E0", Offset = "0x49CD1E0", VA = "0x1849CE1E0")]
	public static FNBMOHMOAFJ ACPBAPDBJCD(ref FNBMOHMOAFJ DOGOAAONBOH, ref FNBMOHMOAFJ ENHIJCCJFBF)
	{
		return default(FNBMOHMOAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x49CE330", Offset = "0x49CD330", VA = "0x1849CE330")]
	public void LMGOHFAOPGC(ref FNBMOHMOAFJ IIKMMJKCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x49CE290", Offset = "0x49CD290", VA = "0x1849CE290")]
	public static FNBMOHMOAFJ LJMPCEGFMKN(ref FNBMOHMOAFJ DOGOAAONBOH, ref FNBMOHMOAFJ ENHIJCCJFBF)
	{
		return default(FNBMOHMOAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x49CE1F0", Offset = "0x49CD1F0", VA = "0x1849CE1F0")]
	public void DEEJNFKADIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x49CE230", Offset = "0x49CD230", VA = "0x1849CE230")]
	public static FNBMOHMOAFJ DEEJNFKADIF(ref FNBMOHMOAFJ DOGOAAONBOH)
	{
		return default(FNBMOHMOAFJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct KNEAGJOJBNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] NCCOCLJLPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int EGBIMJLECFF;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x764140", Offset = "0x763140", VA = "0x180764140")]
	public KNEAGJOJBNI(byte[] NCCOCLJLPFP, int LPADDFNBONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x49DC9B0", Offset = "0x49DB9B0", VA = "0x1849DC9B0")]
	public void OKDFPDDOKAL(byte LILNHPOEIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x49DC640", Offset = "0x49DB640", VA = "0x1849DC640")]
	public void ALEFCLEKFMP(byte[] LILNHPOEIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x49DC6E0", Offset = "0x49DB6E0", VA = "0x1849DC6E0")]
	public void EPDFDKBCMDJ(byte[] LILNHPOEIJC, int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x49DC780", Offset = "0x49DB780", VA = "0x1849DC780")]
	public void EPDFDKBCMDJ(byte[] LILNHPOEIJC, int OMKHMNIPPGH, int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x49DC930", Offset = "0x49DB930", VA = "0x1849DC930")]
	public void LBNIBHGNGDE(byte ODCENIJJKIC, int LGKBEOCJMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x49DC830", Offset = "0x49DB830", VA = "0x1849DC830")]
	public void HHIONPDEMBM(string LILNHPOEIJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class GNIKPDIHMBC
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum IBLICHDBBLC
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum AABACCGGELH
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum GHPHHGLCACN
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
	private static byte[] ANGGMFKIAIN;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] IPCLFDDCGLA;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] HDAGOMPAPGE;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] AGFHNKDLBGM;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly GHPHHGLCACN MEMLMCLKJIM;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char OJBEDIDDHLI;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int KBFGJODGNJE;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int EAKNKFLJHHD;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] KBCJNBNKHAG;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x49D3C70", Offset = "0x49D2C70", VA = "0x1849D3C70")]
	private static byte[] MDMDPAEKHNI(int FBPAKFCOLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x49D27A0", Offset = "0x49D17A0", VA = "0x1849D27A0")]
	private static byte[] EMJGJOLMMBA(int FBPAKFCOLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x49D2DB0", Offset = "0x49D1DB0", VA = "0x1849D2DB0")]
	public static int KEBHDGIOIOE(ref byte[] NCCOCLJLPFP, int EGBIMJLECFF, float CCIMHDCKHOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x49D2ED0", Offset = "0x49D1ED0", VA = "0x1849D2ED0")]
	public static int KEBHDGIOIOE(ref byte[] NCCOCLJLPFP, int EGBIMJLECFF, double CCIMHDCKHOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x49D4330", Offset = "0x49D3330", VA = "0x1849D4330")]
	private static bool PLOKFEIOOBH(byte[] NCCOCLJLPFP, int HOPGLJCPGGA, ulong LHHKKFCHGFO, ulong LLKGEIPKIOD, ulong OILHPMFBCIA, ulong GIJCAAKDGNL, ulong JILIAOKFEHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x49D2680", Offset = "0x49D1680", VA = "0x1849D2680")]
	private static void DIKGMAHMJHN(uint HEMEFOFCGJG, int LNGMIFEELJP, out uint HHJPAOCLOKI, out int KDPHOEPNOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x49D21C0", Offset = "0x49D11C0", VA = "0x1849D21C0")]
	private static bool BDHFHJNONPD(FNBMOHMOAFJ MGEMJGILCAC, FNBMOHMOAFJ NOMPHPBFLNE, FNBMOHMOAFJ GKHPODHMJGB, byte[] NCCOCLJLPFP, out int HOPGLJCPGGA, out int DKMOINFLGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x49D3180", Offset = "0x49D2180", VA = "0x1849D3180")]
	private static bool LDBIEDGHCJC(double DCNCBDGEKMD, IBLICHDBBLC PDFIDNNGANB, byte[] NCCOCLJLPFP, out int HOPGLJCPGGA, out int FJOPLOGBEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x49D3D50", Offset = "0x49D2D50", VA = "0x1849D3D50")]
	private static bool NJANODHFCOM(double DCNCBDGEKMD, IBLICHDBBLC PDFIDNNGANB, byte[] NCCOCLJLPFP, out int HOPGLJCPGGA, out int MKLHIKMFECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x49D2FF0", Offset = "0x49D1FF0", VA = "0x1849D2FF0")]
	private static bool KIBDJNINPIG(double CCIMHDCKHOF, ref KNEAGJOJBNI HLKCIMHFPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x49D3610", Offset = "0x49D2610", VA = "0x1849D3610")]
	private static bool LMALLFEHBFO(double CCIMHDCKHOF, ref KNEAGJOJBNI HLKCIMHFPMH, AABACCGGELH PDFIDNNGANB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x49D3E60", Offset = "0x49D2E60", VA = "0x1849D3E60")]
	private static void NOEBNOGIHGI(byte[] DEJLILJGEDA, int HOPGLJCPGGA, int MKLHIKMFECN, int AKDJEAOOGBI, ref KNEAGJOJBNI HLKCIMHFPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x49D2880", Offset = "0x49D1880", VA = "0x1849D2880")]
	private static void JMBLEJCDFML(byte[] DEJLILJGEDA, int HOPGLJCPGGA, int KMMODGACMAP, ref KNEAGJOJBNI HLKCIMHFPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x49D2010", Offset = "0x49D1010", VA = "0x1849D2010")]
	private static bool ABNNNLJHDPK(double DCNCBDGEKMD, AABACCGGELH PDFIDNNGANB, int FEKCFBJLCBC, byte[] HNKCOCKDCCG, out bool MHFHNKAADOH, out int HOPGLJCPGGA, out int ADMEPHMBKKP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct GFIDFAMMMJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double BOMCMOAJNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong DIEBPANNGPH;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct PCDAPEIBFEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float BPJEFFCEPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint PLPGFHAABJH;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct OLEEFJKDEHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong OLGGJOLBLMK;

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x4D63A40", Offset = "0x4D62A40", VA = "0x184D63A40")]
	public OLEEFJKDEHG(double BOMCMOAJNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4D63A50", Offset = "0x4D62A50", VA = "0x184D63A50")]
	public OLEEFJKDEHG(FNBMOHMOAFJ BOMCMOAJNIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4D635F0", Offset = "0x4D625F0", VA = "0x184D635F0")]
	public FNBMOHMOAFJ CPPKLDNDKHF()
	{
		return default(FNBMOHMOAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x4D63940", Offset = "0x4D62940", VA = "0x184D63940")]
	public FNBMOHMOAFJ NDICJMPMDAC()
	{
		return default(FNBMOHMOAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x64A000", Offset = "0x649000", VA = "0x18064A000")]
	public ulong GJFIOMAMIJI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D63720", Offset = "0x4D62720", VA = "0x184D63720")]
	public double IKKFEPIJKJF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D63810", Offset = "0x4D62810", VA = "0x184D63810")]
	public double LOKELEODEAC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4D636E0", Offset = "0x4D626E0", VA = "0x184D636E0")]
	public int GHKHECFLDNB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x4D639D0", Offset = "0x4D629D0", VA = "0x184D639D0")]
	public ulong OMMEPPIMAME()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x4D635D0", Offset = "0x4D625D0", VA = "0x184D635D0")]
	public bool CIKAPPHHJPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4D63A00", Offset = "0x4D62A00", VA = "0x184D63A00")]
	public bool PGLIJHJGBFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x4D637E0", Offset = "0x4D627E0", VA = "0x184D637E0")]
	public bool LIBBPKEJION()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x4D637B0", Offset = "0x4D627B0", VA = "0x184D637B0")]
	public bool LEJOJAOACBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x4D63A20", Offset = "0x4D62A20", VA = "0x184D63A20")]
	public int PILKEAEDACP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x4D63450", Offset = "0x4D62450", VA = "0x184D63450")]
	public void ABFNMNAGIOC(out FNBMOHMOAFJ PIEOJPKCCMH, out FNBMOHMOAFJ IMFDCPCHODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x4D63690", Offset = "0x4D62690", VA = "0x184D63690")]
	public bool FKBINABOBNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x4D635C0", Offset = "0x4D625C0", VA = "0x184D635C0")]
	public double CCIMHDCKHOF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x4D63670", Offset = "0x4D62670", VA = "0x184D63670")]
	public static int ENMADHAMLGB(int CAMLMLHFCOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x4D63710", Offset = "0x4D62710", VA = "0x184D63710")]
	public static double HOBGNBEPJHD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x4D638A0", Offset = "0x4D628A0", VA = "0x184D638A0")]
	public static ulong MEHDKADPGBD(FNBMOHMOAFJ PMAKEAALLEO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct OJDBDENBJPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint LADAOHHMGJF;

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x27D65E0", Offset = "0x27D55E0", VA = "0x1827D65E0")]
	public OJDBDENBJPC(float BPJEFFCEPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4D63360", Offset = "0x4D62360", VA = "0x184D63360")]
	public FNBMOHMOAFJ CPPKLDNDKHF()
	{
		return default(FNBMOHMOAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE20", Offset = "0x6FAE20", VA = "0x1806FBE20")]
	public uint KDIKHKFCPNC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4D63410", Offset = "0x4D62410", VA = "0x184D63410")]
	public int GHKHECFLDNB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x4D63430", Offset = "0x4D62430", VA = "0x184D63430")]
	public uint OMMEPPIMAME()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x4D63350", Offset = "0x4D62350", VA = "0x184D63350")]
	public bool CIKAPPHHJPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4D631F0", Offset = "0x4D621F0", VA = "0x184D631F0")]
	public void ABFNMNAGIOC(out FNBMOHMOAFJ PIEOJPKCCMH, out FNBMOHMOAFJ IMFDCPCHODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x4D633D0", Offset = "0x4D623D0", VA = "0x184D633D0")]
	public bool FKBINABOBNM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct LHDKDNLHNEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong JNPNBGAKPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short BFJOAAJAHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short FJOPLOGBEDK;

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x49DEFD0", Offset = "0x49DDFD0", VA = "0x1849DEFD0")]
	public LHDKDNLHNEJ(ulong JNPNBGAKPBA, short BFJOAAJAHEG, short FJOPLOGBEDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class NEMNGBEBJLO
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly LHDKDNLHNEJ[] NLLKDIKLMIO;

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x49E3E40", Offset = "0x49E2E40", VA = "0x1849E3E40")]
	public static void LGJLJFFMMEA(int AKDJDGJOBBJ, int HGMIEPGAGGP, out FNBMOHMOAFJ HHJPAOCLOKI, out int FJOPLOGBEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x49E3D50", Offset = "0x49E2D50", VA = "0x1849E3D50")]
	public static void BGCEKCLPPML(int FNPLGNEGELG, out FNBMOHMOAFJ HHJPAOCLOKI, out int BGHFFKBHDDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct HEPAACAHFJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] CDDAIIMDJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int OMKHMNIPPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int BHDCFOCMAFI;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x49D9A10", Offset = "0x49D8A10", VA = "0x1849D9A10")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xCD9A70", Offset = "0xCD8A70", VA = "0x180CD9A70")]
	public HEPAACAHFJD(byte[] CDDAIIMDJCN, int OMKHMNIPPGH, int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x75D5E0", Offset = "0x75C5E0", VA = "0x18075D5E0")]
	public int HOPGLJCPGGA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x49D99B0", Offset = "0x49D89B0", VA = "0x1849D99B0")]
	public HEPAACAHFJD ICNKJBJJLIG(int PJLFEJFCFBB, int CKCMLJGEIGK)
	{
		return default(HEPAACAHFJD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class CGEEHCEILMH
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] NOMIHPLEAOC;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] FCPGINDDKIP;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int JEPOLPOIKJC;

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4C904E0", Offset = "0x4C8F4E0", VA = "0x184C904E0")]
	private static byte[] KILPFLJGOHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4C90870", Offset = "0x4C8F870", VA = "0x184C90870")]
	private static HEPAACAHFJD LFGHNEGKNGP(HEPAACAHFJD NCCOCLJLPFP)
	{
		return default(HEPAACAHFJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F940", Offset = "0x4C8E940", VA = "0x184C8F940")]
	private static HEPAACAHFJD HMINGPNOAGP(HEPAACAHFJD NCCOCLJLPFP)
	{
		return default(HEPAACAHFJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4C90BB0", Offset = "0x4C8FBB0", VA = "0x184C90BB0")]
	private static void ONNNDPKAPNJ(HEPAACAHFJD NCCOCLJLPFP, int KMMODGACMAP, byte[] BIJICEEAAAG, out int HDNADPFGKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4C905D0", Offset = "0x4C8F5D0", VA = "0x184C905D0")]
	private static void KMEBMNHENOF(HEPAACAHFJD NCCOCLJLPFP, int KMMODGACMAP, byte[] LMLBGGFMJNK, int IKKIEFJBDEG, out HEPAACAHFJD LJLMMLLBADH, out int IDBOIHBGNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x4C8FDE0", Offset = "0x4C8EDE0", VA = "0x184C8FDE0")]
	private static ulong JDJOHAPBAPK(HEPAACAHFJD NCCOCLJLPFP, out int HCPBCIMLDFM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4C90920", Offset = "0x4C8F920", VA = "0x184C90920")]
	private static void MBDAMKOFLFH(HEPAACAHFJD NCCOCLJLPFP, out FNBMOHMOAFJ BBELMPNHPOK, out int GGHMEHIIDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F9F0", Offset = "0x4C8E9F0", VA = "0x184C8F9F0")]
	private static bool ICFPDNFEHBO(HEPAACAHFJD LJLMMLLBADH, int KMMODGACMAP, out double BBELMPNHPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x4C90330", Offset = "0x4C8F330", VA = "0x184C90330")]
	private static FNBMOHMOAFJ KHGMHGMBJDE(int KMMODGACMAP)
	{
		return default(FNBMOHMOAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x4C8FE70", Offset = "0x4C8EE70", VA = "0x184C8FE70")]
	private static bool JGCFILHBBOB(HEPAACAHFJD NCCOCLJLPFP, int KMMODGACMAP, out double BBELMPNHPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x4C90A70", Offset = "0x4C8FA70", VA = "0x184C90A70")]
	private static bool MOLPLEHALGA(HEPAACAHFJD LJLMMLLBADH, int KMMODGACMAP, out double LECOIDHKFLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F820", Offset = "0x4C8E820", VA = "0x184C8F820")]
	public static double? EOLCFLJCNJH(HEPAACAHFJD NCCOCLJLPFP, int KMMODGACMAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F640", Offset = "0x4C8E640", VA = "0x184C8F640")]
	public static float? DKDCHANHAJL(HEPAACAHFJD NCCOCLJLPFP, int KMMODGACMAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct IGFMANGPAHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] NCCOCLJLPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int EGBIMJLECFF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte FHONEBOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x49DB630", Offset = "0x49DA630", VA = "0x1849DB630")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x764140", Offset = "0x763140", VA = "0x180764140")]
	public IGFMANGPAHA(byte[] NCCOCLJLPFP, int EGBIMJLECFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x49DB730", Offset = "0x49DA730", VA = "0x1849DB730")]
	public static IGFMANGPAHA HICLGKMKDEG(IGFMANGPAHA IPNNIJODOPO)
	{
		return default(IGFMANGPAHA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x49DB740", Offset = "0x49DA740", VA = "0x1849DB740")]
	public static IGFMANGPAHA IDPFAKACPID(IGFMANGPAHA IPNNIJODOPO, int HOPGLJCPGGA)
	{
		return default(IGFMANGPAHA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x49DB830", Offset = "0x49DA830", VA = "0x1849DB830")]
	public static int MMBIJLAKMHD(IGFMANGPAHA FEBCAKEBBCL, IGFMANGPAHA EEACLMBPLFE)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x49DB670", Offset = "0x49DA670", VA = "0x1849DB670")]
	public static bool CGFEPDNGNBJ(IGFMANGPAHA FEBCAKEBBCL, IGFMANGPAHA EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x49DB8A0", Offset = "0x49DA8A0", VA = "0x1849DB8A0")]
	public static bool NODBGCCFDAJ(IGFMANGPAHA FEBCAKEBBCL, IGFMANGPAHA EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x49DB690", Offset = "0x49DA690", VA = "0x1849DB690")]
	public static bool CGFEPDNGNBJ(IGFMANGPAHA FEBCAKEBBCL, char EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x49DB850", Offset = "0x49DA850", VA = "0x1849DB850")]
	public static bool NODBGCCFDAJ(IGFMANGPAHA FEBCAKEBBCL, char EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x49DB850", Offset = "0x49DA850", VA = "0x1849DB850")]
	public static bool NODBGCCFDAJ(IGFMANGPAHA FEBCAKEBBCL, byte EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x49DB7E0", Offset = "0x49DA7E0", VA = "0x1849DB7E0")]
	public static bool LMNFBOAPBJP(IGFMANGPAHA FEBCAKEBBCL, char EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x49DB790", Offset = "0x49DA790", VA = "0x1849DB790")]
	public static bool KPJPCENEJGN(IGFMANGPAHA FEBCAKEBBCL, char EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x49DB6E0", Offset = "0x49DA6E0", VA = "0x1849DB6E0")]
	public static bool FCMIAOMFIPH(IGFMANGPAHA FEBCAKEBBCL, char EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x49DB8C0", Offset = "0x49DA8C0", VA = "0x1849DB8C0")]
	public static bool NOEDKDHJHOK(IGFMANGPAHA FEBCAKEBBCL, char EEACLMBPLFE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class GNGOOAJJJLG
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] CKDDALOCELN;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] MCFOKLEGFBL;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] HDAGOMPAPGE;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] AGFHNKDLBGM;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] OFIKBDKAPEK;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int BDJEOFMBOPE;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] IMJIDDENMDN;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int ACMBMCHJJAB;

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x49D1CB0", Offset = "0x49D0CB0", VA = "0x1849D1CB0")]
	private static byte[] MNPKOLKGMCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x49D0940", Offset = "0x49CF940", VA = "0x1849D0940")]
	private static byte[] BEMMOHCPDPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x49D1BF0", Offset = "0x49D0BF0", VA = "0x1849D1BF0")]
	public static double LNFFMLHHPIK(byte[] NCCOCLJLPFP, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x49D1B30", Offset = "0x49D0B30", VA = "0x1849D1B30")]
	public static float JNAHFECIEED(byte[] NCCOCLJLPFP, int EGBIMJLECFF, out int BNJIGHEACCO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x49D07C0", Offset = "0x49CF7C0", VA = "0x1849D07C0")]
	private static bool BCIJPNLDDGE(int ODLLFOGPPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x49D06A0", Offset = "0x49CF6A0", VA = "0x1849D06A0")]
	private static bool AJKCFLJHBOM(ref IGFMANGPAHA IMLJHLOOKFM, IGFMANGPAHA BDPJJHLGMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x49D0A90", Offset = "0x49CFA90", VA = "0x1849D0A90")]
	private static bool HEGAEJMAGIM(ref IGFMANGPAHA IMLJHLOOKFM, IGFMANGPAHA BDPJJHLGMOK, byte[] CGHJGICOJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x49D0A30", Offset = "0x49CFA30", VA = "0x1849D0A30")]
	private static bool EHGAODFAKMK(ref IGFMANGPAHA JLHFEECHHCL, byte[] LILNHPOEIJC, int EGBIMJLECFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x49D0680", Offset = "0x49CF680", VA = "0x1849D0680")]
	private static double AFHCDABFIJC(bool MHFHNKAADOH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x49D0BB0", Offset = "0x49CFBB0", VA = "0x1849D0BB0")]
	private static double HLDIFBBGJKO(IGFMANGPAHA KAKCHGJCKMF, int HOPGLJCPGGA, bool JCHFDOHMAKD, out int EAGBIGIOEKO)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class HCAMFDLELGA<T> : global::HAKOMFHEDCC<T[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly global::IOAKBHOGHOE<T> BJMHJKDBLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly ENFHMOLIHKA MMPLAMJDCGA;

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x268AE50", Offset = "0x2689E50", VA = "0x18268AE50")]
	public HCAMFDLELGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2015CB0", Offset = "0x2014CB0", VA = "0x182015CB0")]
	public HCAMFDLELGA(ENFHMOLIHKA MMPLAMJDCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x268A700", Offset = "0x2689700", VA = "0x18268A700", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x2688E20", Offset = "0x2687E20", VA = "0x182688E20", Slot = "5")]
	public T[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class PKAJOMOJPEC<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly global::IOAKBHOGHOE<T> BJMHJKDBLOI;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class PKHHKMBMIGG<T> : global::HAKOMFHEDCC<List<T>>, LOIEEHPBJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly ENFHMOLIHKA MMPLAMJDCGA;

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x268AE50", Offset = "0x2689E50", VA = "0x18268AE50")]
	public PKHHKMBMIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2015CB0", Offset = "0x2014CB0", VA = "0x182015CB0")]
	public PKHHKMBMIGG(ENFHMOLIHKA MMPLAMJDCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2D39580", Offset = "0x2D38580", VA = "0x182D39580", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, List<T> CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x2D38A20", Offset = "0x2D37A20", VA = "0x182D38A20", Slot = "5")]
	public List<T> ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class FDLEJHFBKJP<TElement, TIntermediate, TEnumerator, TCollection> : global::HAKOMFHEDCC<TCollection>, LOIEEHPBJBK where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x25B02D0", Offset = "0x25AF2D0", VA = "0x1825B02D0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, TCollection CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x25AF760", Offset = "0x25AE760", VA = "0x1825AF760", Slot = "5")]
	public TCollection ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator GCLCCONAGDL(TCollection LENKHFNFMLN);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate MFNJFAEBAIM();

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void CEMPCIEDPMO(ref TIntermediate JBGBCNGIBOP, int MMABPPDCBIB, TElement CCIMHDCKHOF);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection ECFFKMLILHP(ref TIntermediate INHIJMIJKMN);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
	protected FDLEJHFBKJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class PPHKEKFDBAA<TElement, TIntermediate, TCollection> : global::FDLEJHFBKJP<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x25180E0", Offset = "0x25170E0", VA = "0x1825180E0", Slot = "6")]
	protected override IEnumerator<TElement> GCLCCONAGDL(TCollection LENKHFNFMLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x232C390", Offset = "0x232B390", VA = "0x18232C390")]
	protected PPHKEKFDBAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class OJLCAAKCBIE<TElement, TCollection> : global::PPHKEKFDBAA<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x10F4080", Offset = "0x10F3080", VA = "0x1810F4080", Slot = "9")]
	protected sealed override TCollection ECFFKMLILHP(ref TCollection INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class KCFBGMDJCGN<TElement, TCollection> : global::OJLCAAKCBIE<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x28F3770", Offset = "0x28F2770", VA = "0x1828F3770", Slot = "7")]
	protected override TCollection MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x28F3700", Offset = "0x28F2700", VA = "0x1828F3700", Slot = "8")]
	protected override void CEMPCIEDPMO(ref TCollection JBGBCNGIBOP, int MMABPPDCBIB, TElement CCIMHDCKHOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class NFPOKPHKILA<T> : global::FDLEJHFBKJP<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x236DDF0", Offset = "0x236CDF0", VA = "0x18236DDF0", Slot = "8")]
	protected override void CEMPCIEDPMO(ref LinkedList<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x10F4080", Offset = "0x10F3080", VA = "0x1810F4080", Slot = "9")]
	protected override LinkedList<T> ECFFKMLILHP(ref LinkedList<T> INHIJMIJKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x236DE90", Offset = "0x236CE90", VA = "0x18236DE90", Slot = "7")]
	protected override LinkedList<T> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x236DE30", Offset = "0x236CE30", VA = "0x18236DE30", Slot = "6")]
	protected override LinkedList<T>.Enumerator GCLCCONAGDL(LinkedList<T> LENKHFNFMLN)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class JJHNCCIKGHL<T> : global::FDLEJHFBKJP<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x236DDF0", Offset = "0x236CDF0", VA = "0x18236DDF0", Slot = "8")]
	protected override void CEMPCIEDPMO(ref Queue<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x236DE90", Offset = "0x236CE90", VA = "0x18236DE90", Slot = "7")]
	protected override Queue<T> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2D2F260", Offset = "0x2D2E260", VA = "0x182D2F260", Slot = "6")]
	protected override Queue<T>.Enumerator GCLCCONAGDL(Queue<T> LENKHFNFMLN)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x10F4080", Offset = "0x10F3080", VA = "0x1810F4080", Slot = "9")]
	protected override Queue<T> ECFFKMLILHP(ref Queue<T> INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class PHAIIABNPFK<T> : global::FDLEJHFBKJP<T, global::DAFGBDPGAFN<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2688000", Offset = "0x2687000", VA = "0x182688000", Slot = "8")]
	protected override void CEMPCIEDPMO(ref global::DAFGBDPGAFN<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2688050", Offset = "0x2687050", VA = "0x182688050", Slot = "7")]
	protected override global::DAFGBDPGAFN<T> MFNJFAEBAIM()
	{
		return default(global::DAFGBDPGAFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2D2F260", Offset = "0x2D2E260", VA = "0x182D2F260", Slot = "6")]
	protected override Stack<T>.Enumerator GCLCCONAGDL(Stack<T> LENKHFNFMLN)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2D2F180", Offset = "0x2D2E180", VA = "0x182D2F180", Slot = "9")]
	protected override Stack<T> ECFFKMLILHP(ref global::DAFGBDPGAFN<T> INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class DOGKCEMFLKM<T> : global::FDLEJHFBKJP<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x236DDF0", Offset = "0x236CDF0", VA = "0x18236DDF0", Slot = "8")]
	protected override void CEMPCIEDPMO(ref HashSet<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x10F4080", Offset = "0x10F3080", VA = "0x1810F4080", Slot = "9")]
	protected override HashSet<T> ECFFKMLILHP(ref HashSet<T> INHIJMIJKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x236DE90", Offset = "0x236CE90", VA = "0x18236DE90", Slot = "7")]
	protected override HashSet<T> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2D2F260", Offset = "0x2D2E260", VA = "0x182D2F260", Slot = "6")]
	protected override HashSet<T>.Enumerator GCLCCONAGDL(HashSet<T> LENKHFNFMLN)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class OMBFDBGJLFE<T> : global::PPHKEKFDBAA<T, global::DAFGBDPGAFN<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2688000", Offset = "0x2687000", VA = "0x182688000", Slot = "8")]
	protected override void CEMPCIEDPMO(ref global::DAFGBDPGAFN<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x2D8EF10", Offset = "0x2D8DF10", VA = "0x182D8EF10", Slot = "9")]
	protected override ReadOnlyCollection<T> ECFFKMLILHP(ref global::DAFGBDPGAFN<T> INHIJMIJKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x2D8EFA0", Offset = "0x2D8DFA0", VA = "0x182D8EFA0", Slot = "7")]
	protected override global::DAFGBDPGAFN<T> MFNJFAEBAIM()
	{
		return default(global::DAFGBDPGAFN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class HPLMJNILOAH<T> : global::PPHKEKFDBAA<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x236DDF0", Offset = "0x236CDF0", VA = "0x18236DDF0", Slot = "8")]
	protected override void CEMPCIEDPMO(ref List<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x236DE90", Offset = "0x236CE90", VA = "0x18236DE90", Slot = "7")]
	protected override List<T> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x10F4080", Offset = "0x10F3080", VA = "0x1810F4080", Slot = "9")]
	protected override IList<T> ECFFKMLILHP(ref List<T> INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class CEHBEGMHIJG<T> : global::PPHKEKFDBAA<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x236DDF0", Offset = "0x236CDF0", VA = "0x18236DDF0", Slot = "8")]
	protected override void CEMPCIEDPMO(ref List<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x236DE90", Offset = "0x236CE90", VA = "0x18236DE90", Slot = "7")]
	protected override List<T> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x10F4080", Offset = "0x10F3080", VA = "0x1810F4080", Slot = "9")]
	protected override ICollection<T> ECFFKMLILHP(ref List<T> INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class HBPBMNBDEHE<T> : global::PPHKEKFDBAA<T, global::DAFGBDPGAFN<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x2688000", Offset = "0x2687000", VA = "0x182688000", Slot = "8")]
	protected override void CEMPCIEDPMO(ref global::DAFGBDPGAFN<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x2688050", Offset = "0x2687050", VA = "0x182688050", Slot = "7")]
	protected override global::DAFGBDPGAFN<T> MFNJFAEBAIM()
	{
		return default(global::DAFGBDPGAFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2688030", Offset = "0x2687030", VA = "0x182688030", Slot = "9")]
	protected override IEnumerable<T> ECFFKMLILHP(ref global::DAFGBDPGAFN<T> INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class LMLAFMAODMC<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class HBOAODHPJMA<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class PMNDOPKMIFM<T> : global::HAKOMFHEDCC<T>, LOIEEHPBJBK where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2511670", Offset = "0x2510670", VA = "0x182511670", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2511460", Offset = "0x2510460", VA = "0x182511460", Slot = "5")]
	public T ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
	public PMNDOPKMIFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class GBHBNKKAFAG : global::HAKOMFHEDCC<IEnumerable>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::HAKOMFHEDCC<IEnumerable> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x49CE7B0", Offset = "0x49CD7B0", VA = "0x1849CE7B0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, IEnumerable CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x49CE520", Offset = "0x49CD520", VA = "0x1849CE520", Slot = "5")]
	public IEnumerable ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public GBHBNKKAFAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class NDHFDCLFLDD : global::HAKOMFHEDCC<ICollection>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public static readonly global::HAKOMFHEDCC<ICollection> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x49E3970", Offset = "0x49E2970", VA = "0x1849E3970", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ICollection CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x49E36E0", Offset = "0x49E26E0", VA = "0x1849E36E0", Slot = "5")]
	public ICollection ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public NDHFDCLFLDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class AGBGPPPCPJK : global::HAKOMFHEDCC<IList>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::HAKOMFHEDCC<IList> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x4C89160", Offset = "0x4C88160", VA = "0x184C89160", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, IList CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x4C88FB0", Offset = "0x4C87FB0", VA = "0x184C88FB0", Slot = "5")]
	public IList ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public AGBGPPPCPJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class KKINCLPKBIN<T> : global::PPHKEKFDBAA<T, global::DAFGBDPGAFN<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x30C1940", Offset = "0x30C0940", VA = "0x1830C1940", Slot = "8")]
	protected override void CEMPCIEDPMO(ref global::DAFGBDPGAFN<T> JBGBCNGIBOP, int MMABPPDCBIB, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2688050", Offset = "0x2687050", VA = "0x182688050", Slot = "7")]
	protected override global::DAFGBDPGAFN<T> MFNJFAEBAIM()
	{
		return default(global::DAFGBDPGAFN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x30C19A0", Offset = "0x30C09A0", VA = "0x1830C19A0", Slot = "9")]
	protected override IReadOnlyList<T> ECFFKMLILHP(ref global::DAFGBDPGAFN<T> INHIJMIJKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x235F680", Offset = "0x235E680", VA = "0x18235F680")]
	public KKINCLPKBIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class PIELEEOOGBM
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x4D64500", Offset = "0x4D63500", VA = "0x184D64500")]
	public static DateTime GBDGFHAEAHJ(DateTime PJIOPOKFBOO)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class HCBBHNHICEF : global::HAKOMFHEDCC<DateTime>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly global::HAKOMFHEDCC<DateTime> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x49D8AD0", Offset = "0x49D7AD0", VA = "0x1849D8AD0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, DateTime CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x49D7B70", Offset = "0x49D6B70", VA = "0x1849D7B70", Slot = "5")]
	public DateTime ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public HCBBHNHICEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class BCIKDCDOFJC : global::HAKOMFHEDCC<DateTimeOffset>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly global::HAKOMFHEDCC<DateTimeOffset> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E590", Offset = "0x4C8D590", VA = "0x184C8E590", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, DateTimeOffset CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x4C8D6C0", Offset = "0x4C8C6C0", VA = "0x184C8D6C0", Slot = "5")]
	public DateTimeOffset ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public BCIKDCDOFJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class HKKNIBBPEFD : global::HAKOMFHEDCC<TimeSpan>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly global::HAKOMFHEDCC<TimeSpan> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static byte[] DPOGFJHACEA;

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x49DA910", Offset = "0x49D9910", VA = "0x1849DA910", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, TimeSpan CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x49D9E80", Offset = "0x49D8E80", VA = "0x1849D9E80", Slot = "5")]
	public TimeSpan ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public HKKNIBBPEFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class BHALPHLGMCB<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::HAKOMFHEDCC<TDictionary>, LOIEEHPBJBK where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2773820", Offset = "0x2772820", VA = "0x182773820", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, TDictionary CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x27711D0", Offset = "0x27701D0", VA = "0x1827711D0", Slot = "5")]
	public TDictionary ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator GCLCCONAGDL(TDictionary LENKHFNFMLN);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate MFNJFAEBAIM();

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void CEMPCIEDPMO(ref TIntermediate JBGBCNGIBOP, int MMABPPDCBIB, TKey AGPLDPOAAIC, TValue CCIMHDCKHOF);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary ECFFKMLILHP(ref TIntermediate INHIJMIJKMN);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
	protected BHALPHLGMCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class PGCKIGIONHB<TKey, TValue, TIntermediate, TDictionary> : global::BHALPHLGMCB<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x25180E0", Offset = "0x25170E0", VA = "0x1825180E0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> GCLCCONAGDL(TDictionary LENKHFNFMLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class MDOGFDEDGLP<TKey, TValue, TDictionary> : global::PGCKIGIONHB<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x10F4080", Offset = "0x10F3080", VA = "0x1810F4080", Slot = "9")]
	protected override TDictionary ECFFKMLILHP(ref TDictionary INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class KAKFMBCGKJB<TKey, TValue> : global::BHALPHLGMCB<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x28F1AB0", Offset = "0x28F0AB0", VA = "0x1828F1AB0", Slot = "8")]
	protected override void CEMPCIEDPMO(ref Dictionary<TKey, TValue> JBGBCNGIBOP, int MMABPPDCBIB, TKey AGPLDPOAAIC, TValue CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x10F4080", Offset = "0x10F3080", VA = "0x1810F4080", Slot = "9")]
	protected override Dictionary<TKey, TValue> ECFFKMLILHP(ref Dictionary<TKey, TValue> INHIJMIJKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x236DE90", Offset = "0x236CE90", VA = "0x18236DE90", Slot = "7")]
	protected override Dictionary<TKey, TValue> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x28F1AF0", Offset = "0x28F0AF0", VA = "0x1828F1AF0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator GCLCCONAGDL(Dictionary<TKey, TValue> LENKHFNFMLN)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x10B87D0", Offset = "0x10B77D0", VA = "0x1810B87D0")]
	public KAKFMBCGKJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class KOPFCJJDLFG<TKey, TValue, TDictionary> : global::MDOGFDEDGLP<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x30CE600", Offset = "0x30CD600", VA = "0x1830CE600", Slot = "8")]
	protected override void CEMPCIEDPMO(ref TDictionary JBGBCNGIBOP, int MMABPPDCBIB, TKey AGPLDPOAAIC, TValue CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x201A040", Offset = "0x2019040", VA = "0x18201A040", Slot = "7")]
	protected override TDictionary MFNJFAEBAIM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class FGPANOIFBKN<TKey, TValue> : global::PGCKIGIONHB<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2515FE0", Offset = "0x2514FE0", VA = "0x182515FE0", Slot = "8")]
	protected override void CEMPCIEDPMO(ref Dictionary<TKey, TValue> JBGBCNGIBOP, int MMABPPDCBIB, TKey AGPLDPOAAIC, TValue CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x236DE90", Offset = "0x236CE90", VA = "0x18236DE90", Slot = "7")]
	protected override Dictionary<TKey, TValue> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x10F4080", Offset = "0x10F3080", VA = "0x1810F4080", Slot = "9")]
	protected override IDictionary<TKey, TValue> ECFFKMLILHP(ref Dictionary<TKey, TValue> INHIJMIJKMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class DANKCOKBBPJ<TKey, TValue> : global::MDOGFDEDGLP<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2515FE0", Offset = "0x2514FE0", VA = "0x182515FE0", Slot = "8")]
	protected override void CEMPCIEDPMO(ref SortedList<TKey, TValue> JBGBCNGIBOP, int MMABPPDCBIB, TKey AGPLDPOAAIC, TValue CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x236DE90", Offset = "0x236CE90", VA = "0x18236DE90", Slot = "7")]
	protected override SortedList<TKey, TValue> MFNJFAEBAIM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class PODHLHLGKJI<TKey, TValue> : global::BHALPHLGMCB<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2515FE0", Offset = "0x2514FE0", VA = "0x182515FE0", Slot = "8")]
	protected override void CEMPCIEDPMO(ref SortedDictionary<TKey, TValue> JBGBCNGIBOP, int MMABPPDCBIB, TKey AGPLDPOAAIC, TValue CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x10F4080", Offset = "0x10F3080", VA = "0x1810F4080", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> ECFFKMLILHP(ref SortedDictionary<TKey, TValue> INHIJMIJKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x236DE90", Offset = "0x236CE90", VA = "0x18236DE90", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> MFNJFAEBAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2516020", Offset = "0x2515020", VA = "0x182516020", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator GCLCCONAGDL(SortedDictionary<TKey, TValue> LENKHFNFMLN)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class EIJFCDEEFNM<T> : global::HAKOMFHEDCC<T>, LOIEEHPBJBK where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2050F40", Offset = "0x204FF40", VA = "0x182050F40", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2050D10", Offset = "0x204FD10", VA = "0x182050D10", Slot = "5")]
	public T ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
	public EIJFCDEEFNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class FIHPJLCEDGD : global::HAKOMFHEDCC<IDictionary>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly global::HAKOMFHEDCC<IDictionary> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x49CD5A0", Offset = "0x49CC5A0", VA = "0x1849CD5A0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, IDictionary CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x49CD200", Offset = "0x49CC200", VA = "0x1849CD200", Slot = "5")]
	public IDictionary ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public FIHPJLCEDGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class CNMFNILJJCJ : global::HAKOMFHEDCC<object>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void FMEFDKLNLMO(object DNBMLPPLJGA, ref KNPMIFIKMDA FBNHINKPMEA, object CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly global::JMJBDOGCDKP<KeyValuePair<object, FMEFDKLNLMO>> BOPHPJCPNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly IEIMAIBIIFF[] PABOPDBNPMB;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x4C92700", Offset = "0x4C91700", VA = "0x184C92700")]
	public CNMFNILJJCJ(params IEIMAIBIIFF[] PABOPDBNPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x4C91D20", Offset = "0x4C90D20", VA = "0x184C91D20", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, object CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x4C91C80", Offset = "0x4C90C80", VA = "0x184C91C80", Slot = "5")]
	public object ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class NPLDGFPJINE
{
	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x4D5F3E0", Offset = "0x4D5E3E0", VA = "0x184D5F3E0")]
	public static object PILFENOKJPM(Type BCFKLEGAMEO, out bool HKKBCMGAONN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x4D5EAC0", Offset = "0x4D5DAC0", VA = "0x184D5EAC0")]
	public static object LICFHKCBHHA(Type BCFKLEGAMEO, out bool HKKBCMGAONN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class IIABPOLPNAH<T> : global::HAKOMFHEDCC<T>, LOIEEHPBJBK, global::PEHGKAMCACG<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class LPAEILKBILJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public LPAEILKBILJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x2895660", Offset = "0x2894660", VA = "0x182895660")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class LIBOGMCNDLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public global::BKKGNGKDABO<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public LIBOGMCNDLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA9690", Offset = "0x2AA8690", VA = "0x182AA9690")]
		internal void <.cctor>b__1(ref KNPMIFIKMDA writer, T value, IEIMAIBIIFF _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class CBJFNIOKCKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public global::IKNPCAKNFFF<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public CBJFNIOKCKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x35BF2B0", Offset = "0x35BE2B0", VA = "0x1835BF2B0")]
		internal T <.cctor>b__2(ref GOCMFGPNGFE reader, IEIMAIBIIFF _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private static readonly global::GALOOIHPGNA<T> PFDPDENEIOB;

	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private static readonly Dictionary<T, string> BGNOAHGHPPJ;

	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private static readonly global::BKKGNGKDABO<T> GGOFINJAIKF;

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly global::IKNPCAKNFFF<T> NEHGKJBICIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private readonly bool LOJPIBAKOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private readonly global::BKKGNGKDABO<T> GODFCLHOFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::IKNPCAKNFFF<T> BKEJJAMDHCJ;

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3CB0940", Offset = "0x3CAF940", VA = "0x183CB0940")]
	static IIABPOLPNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3330", Offset = "0x2DD2330", VA = "0x182DD3330")]
	public IIABPOLPNAH(bool LOJPIBAKOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2000", Offset = "0x3CA1000", VA = "0x183CA2000", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C0D0", Offset = "0x3C9B0D0", VA = "0x183C9C0D0", Slot = "5")]
	public T ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x3CA6AA0", Offset = "0x3CA5AA0", VA = "0x183CA6AA0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, T CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x3CA50D0", Offset = "0x3CA40D0", VA = "0x183CA50D0", Slot = "7")]
	public T MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class GHJPJEMJKHK<T> : global::HAKOMFHEDCC<T[,]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x376BC70", Offset = "0x376AC70", VA = "0x18376BC70", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T[,] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x376B9A0", Offset = "0x376A9A0", VA = "0x18376B9A0", Slot = "5")]
	public T[,] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
	public GHJPJEMJKHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class DININCPNFKE<T> : global::HAKOMFHEDCC<T[,,]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2E3FA30", Offset = "0x2E3EA30", VA = "0x182E3FA30", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T[,,] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2E3F650", Offset = "0x2E3E650", VA = "0x182E3F650", Slot = "5")]
	public T[,,] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
	public DININCPNFKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class CNDLCIFFLFM<T> : global::HAKOMFHEDCC<T[,,,]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A118B0", Offset = "0x2A108B0", VA = "0x182A118B0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T[,,,] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A113B0", Offset = "0x2A103B0", VA = "0x182A113B0", Slot = "5")]
	public T[,,,] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
	public CNDLCIFFLFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class CJOCGKLADIC<T> : global::HAKOMFHEDCC<T?>, LOIEEHPBJBK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A02C80", Offset = "0x2A01C80", VA = "0x182A02C80", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A02B30", Offset = "0x2A01B30", VA = "0x182A02B30", Slot = "5")]
	public T? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
	public CJOCGKLADIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class JAFFPLMOHOF<T> : global::HAKOMFHEDCC<T?>, LOIEEHPBJBK where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private readonly global::HAKOMFHEDCC<T> LNLANNNHDAI;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x1BB9BB0", Offset = "0x1BB8BB0", VA = "0x181BB9BB0")]
	public JAFFPLMOHOF(global::HAKOMFHEDCC<T> LNLANNNHDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x232EAC0", Offset = "0x232DAC0", VA = "0x18232EAC0")]
	public JAFFPLMOHOF(Type NLNGAAILPIL, object[] JHKOBFCIOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x232D1F0", Offset = "0x232C1F0", VA = "0x18232D1F0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, T? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x232CDC0", Offset = "0x232BDC0", VA = "0x18232CDC0", Slot = "5")]
	public T? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class GOPLJFLGDBE : global::HAKOMFHEDCC<sbyte>, LOIEEHPBJBK, global::PEHGKAMCACG<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly GOPLJFLGDBE PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x49D7620", Offset = "0x49D6620", VA = "0x1849D7620", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, sbyte CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x49D75D0", Offset = "0x49D65D0", VA = "0x1849D75D0", Slot = "5")]
	public sbyte ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x49D76E0", Offset = "0x49D66E0", VA = "0x1849D76E0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, sbyte CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x49D7660", Offset = "0x49D6660", VA = "0x1849D7660", Slot = "7")]
	public sbyte MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public GOPLJFLGDBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class NHBLPMGJJKN : global::HAKOMFHEDCC<sbyte?>, LOIEEHPBJBK, global::PEHGKAMCACG<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly NHBLPMGJJKN PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x4D5DA50", Offset = "0x4D5CA50", VA = "0x184D5DA50", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, sbyte? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x4D5D9E0", Offset = "0x4D5C9E0", VA = "0x184D5D9E0", Slot = "5")]
	public sbyte? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x4D5DB90", Offset = "0x4D5CB90", VA = "0x184D5DB90", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, sbyte? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x4D5DAD0", Offset = "0x4D5CAD0", VA = "0x184D5DAD0", Slot = "7")]
	public sbyte? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public NHBLPMGJJKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class OJCKHGEEHCO : global::HAKOMFHEDCC<sbyte[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly OJCKHGEEHCO PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x4D630D0", Offset = "0x4D620D0", VA = "0x184D630D0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, sbyte[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4D62F90", Offset = "0x4D61F90", VA = "0x184D62F90", Slot = "5")]
	public sbyte[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public OJCKHGEEHCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class LDOJALMDLJH : global::HAKOMFHEDCC<short>, LOIEEHPBJBK, global::PEHGKAMCACG<short>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly LDOJALMDLJH PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x49DE190", Offset = "0x49DD190", VA = "0x1849DE190", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, short CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x49DE130", Offset = "0x49DD130", VA = "0x1849DE130", Slot = "5")]
	public short ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x49DE250", Offset = "0x49DD250", VA = "0x1849DE250", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, short CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x49DE1D0", Offset = "0x49DD1D0", VA = "0x1849DE1D0", Slot = "7")]
	public short MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public LDOJALMDLJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class HAMNKGHEMMM : global::HAKOMFHEDCC<short?>, LOIEEHPBJBK, global::PEHGKAMCACG<short?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly HAMNKGHEMMM PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x49D78B0", Offset = "0x49D68B0", VA = "0x1849D78B0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, short? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x49D7800", Offset = "0x49D6800", VA = "0x1849D7800", Slot = "5")]
	public short? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x49D7A00", Offset = "0x49D6A00", VA = "0x1849D7A00", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, short? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x49D7940", Offset = "0x49D6940", VA = "0x1849D7940", Slot = "7")]
	public short? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public HAMNKGHEMMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class MFDMNFACDHA : global::HAKOMFHEDCC<short[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly MFDMNFACDHA PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x49E20D0", Offset = "0x49E10D0", VA = "0x1849E20D0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, short[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x49E1EA0", Offset = "0x49E0EA0", VA = "0x1849E1EA0", Slot = "5")]
	public short[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public MFDMNFACDHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class IEBIDIHPAEN : global::HAKOMFHEDCC<int>, LOIEEHPBJBK, global::PEHGKAMCACG<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly IEBIDIHPAEN PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x49DB460", Offset = "0x49DA460", VA = "0x1849DB460", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, int CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x49DB400", Offset = "0x49DA400", VA = "0x1849DB400", Slot = "5")]
	public int ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x49DB510", Offset = "0x49DA510", VA = "0x1849DB510", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, int CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x49DB490", Offset = "0x49DA490", VA = "0x1849DB490", Slot = "7")]
	public int MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public IEBIDIHPAEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class AFGPHHDJOAL : global::HAKOMFHEDCC<int?>, LOIEEHPBJBK, global::PEHGKAMCACG<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly AFGPHHDJOAL PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x4C88D70", Offset = "0x4C87D70", VA = "0x184C88D70", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, int? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x4C88D00", Offset = "0x4C87D00", VA = "0x184C88D00", Slot = "5")]
	public int? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x4C88ED0", Offset = "0x4C87ED0", VA = "0x184C88ED0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, int? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4C88DE0", Offset = "0x4C87DE0", VA = "0x184C88DE0", Slot = "7")]
	public int? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public AFGPHHDJOAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class BCAFIGPDGID : global::HAKOMFHEDCC<int[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly BCAFIGPDGID PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x4C8D5A0", Offset = "0x4C8C5A0", VA = "0x184C8D5A0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, int[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x4C8D460", Offset = "0x4C8C460", VA = "0x184C8D460", Slot = "5")]
	public int[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public BCAFIGPDGID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class MNBGGLJBMHB : global::HAKOMFHEDCC<long>, LOIEEHPBJBK, global::PEHGKAMCACG<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly MNBGGLJBMHB PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x49E30E0", Offset = "0x49E20E0", VA = "0x1849E30E0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, long CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x49E30D0", Offset = "0x49E20D0", VA = "0x1849E30D0", Slot = "5")]
	public long ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x49E3190", Offset = "0x49E2190", VA = "0x1849E3190", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, long CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x49E3110", Offset = "0x49E2110", VA = "0x1849E3110", Slot = "7")]
	public long MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public MNBGGLJBMHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class PJOKCCIKJGB : global::HAKOMFHEDCC<long?>, LOIEEHPBJBK, global::PEHGKAMCACG<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly PJOKCCIKJGB PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x4D64B00", Offset = "0x4D63B00", VA = "0x184D64B00", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, long? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x4D64A70", Offset = "0x4D63A70", VA = "0x184D64A70", Slot = "5")]
	public long? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x4D64C60", Offset = "0x4D63C60", VA = "0x184D64C60", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, long? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x4D64B80", Offset = "0x4D63B80", VA = "0x184D64B80", Slot = "7")]
	public long? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public PJOKCCIKJGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class EILIPMAIMIA : global::HAKOMFHEDCC<long[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly EILIPMAIMIA PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x4C9FC60", Offset = "0x4C9EC60", VA = "0x184C9FC60", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, long[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x4C9FB20", Offset = "0x4C9EB20", VA = "0x184C9FB20", Slot = "5")]
	public long[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public EILIPMAIMIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class JNAHGALBCJL : global::HAKOMFHEDCC<byte>, LOIEEHPBJBK, global::PEHGKAMCACG<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly JNAHGALBCJL PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x49DBF90", Offset = "0x49DAF90", VA = "0x1849DBF90", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, byte CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x49DBF30", Offset = "0x49DAF30", VA = "0x1849DBF30", Slot = "5")]
	public byte ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x49DC050", Offset = "0x49DB050", VA = "0x1849DC050", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, byte CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x49DBFD0", Offset = "0x49DAFD0", VA = "0x1849DBFD0", Slot = "7")]
	public byte MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public JNAHGALBCJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class CPBEAPOHNCO : global::HAKOMFHEDCC<byte?>, LOIEEHPBJBK, global::PEHGKAMCACG<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly CPBEAPOHNCO PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x4C92C00", Offset = "0x4C91C00", VA = "0x184C92C00", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, byte? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x4C92B90", Offset = "0x4C91B90", VA = "0x184C92B90", Slot = "5")]
	public byte? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x4C92D80", Offset = "0x4C91D80", VA = "0x184C92D80", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, byte? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x4C92C80", Offset = "0x4C91C80", VA = "0x184C92C80", Slot = "7")]
	public byte? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public CPBEAPOHNCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class LKFLCLKJMHN : global::HAKOMFHEDCC<ushort>, LOIEEHPBJBK, global::PEHGKAMCACG<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly LKFLCLKJMHN PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x49E0720", Offset = "0x49DF720", VA = "0x1849E0720", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ushort CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x49E06C0", Offset = "0x49DF6C0", VA = "0x1849E06C0", Slot = "5")]
	public ushort ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x49E07E0", Offset = "0x49DF7E0", VA = "0x1849E07E0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, ushort CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x49E0760", Offset = "0x49DF760", VA = "0x1849E0760", Slot = "7")]
	public ushort MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public LKFLCLKJMHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class KBNNOCJFOOI : global::HAKOMFHEDCC<ushort?>, LOIEEHPBJBK, global::PEHGKAMCACG<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly KBNNOCJFOOI PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x49DC220", Offset = "0x49DB220", VA = "0x1849DC220", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ushort? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x49DC170", Offset = "0x49DB170", VA = "0x1849DC170", Slot = "5")]
	public ushort? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x49DC370", Offset = "0x49DB370", VA = "0x1849DC370", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, ushort? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x49DC2B0", Offset = "0x49DB2B0", VA = "0x1849DC2B0", Slot = "7")]
	public ushort? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public KBNNOCJFOOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class PEHGGOFBKFD : global::HAKOMFHEDCC<ushort[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly PEHGGOFBKFD PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x4D64120", Offset = "0x4D63120", VA = "0x184D64120", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ushort[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x4D63FE0", Offset = "0x4D62FE0", VA = "0x184D63FE0", Slot = "5")]
	public ushort[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public PEHGGOFBKFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class DPCFGINGCFF : global::HAKOMFHEDCC<uint>, LOIEEHPBJBK, global::PEHGKAMCACG<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly DPCFGINGCFF PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x4C9F7F0", Offset = "0x4C9E7F0", VA = "0x184C9F7F0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, uint CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x4C9F7E0", Offset = "0x4C9E7E0", VA = "0x184C9F7E0", Slot = "5")]
	public uint ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x4C9F8B0", Offset = "0x4C9E8B0", VA = "0x184C9F8B0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, uint CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x4C9F800", Offset = "0x4C9E800", VA = "0x184C9F800", Slot = "7")]
	public uint MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public DPCFGINGCFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class PIFMFBPFEKF : global::HAKOMFHEDCC<uint?>, LOIEEHPBJBK, global::PEHGKAMCACG<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly PIFMFBPFEKF PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x4D64610", Offset = "0x4D63610", VA = "0x184D64610", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, uint? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x4D645A0", Offset = "0x4D635A0", VA = "0x184D645A0", Slot = "5")]
	public uint? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x4D64740", Offset = "0x4D63740", VA = "0x184D64740", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, uint? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x4D64680", Offset = "0x4D63680", VA = "0x184D64680", Slot = "7")]
	public uint? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public PIFMFBPFEKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class MKIPEFIKPDM : global::HAKOMFHEDCC<uint[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly MKIPEFIKPDM PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x49E2ED0", Offset = "0x49E1ED0", VA = "0x1849E2ED0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, uint[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x49E2CA0", Offset = "0x49E1CA0", VA = "0x1849E2CA0", Slot = "5")]
	public uint[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public MKIPEFIKPDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class HCOPHKFFJAB : global::HAKOMFHEDCC<ulong>, LOIEEHPBJBK, global::PEHGKAMCACG<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly HCOPHKFFJAB PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x49D97E0", Offset = "0x49D87E0", VA = "0x1849D97E0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ulong CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x49D97D0", Offset = "0x49D87D0", VA = "0x1849D97D0", Slot = "5")]
	public ulong ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x49D9890", Offset = "0x49D8890", VA = "0x1849D9890", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, ulong CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x49D9810", Offset = "0x49D8810", VA = "0x1849D9810", Slot = "7")]
	public ulong MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public HCOPHKFFJAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class GBIEBECHGJF : global::HAKOMFHEDCC<ulong?>, LOIEEHPBJBK, global::PEHGKAMCACG<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly GBIEBECHGJF PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x49CEB10", Offset = "0x49CDB10", VA = "0x1849CEB10", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ulong? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x49CEA80", Offset = "0x49CDA80", VA = "0x1849CEA80", Slot = "5")]
	public ulong? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x49CEC80", Offset = "0x49CDC80", VA = "0x1849CEC80", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, ulong? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x49CEBA0", Offset = "0x49CDBA0", VA = "0x1849CEBA0", Slot = "7")]
	public ulong? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public GBIEBECHGJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class MOJNNPCBGDC : global::HAKOMFHEDCC<ulong[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly MOJNNPCBGDC PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x49E34E0", Offset = "0x49E24E0", VA = "0x1849E34E0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ulong[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x49E32B0", Offset = "0x49E22B0", VA = "0x1849E32B0", Slot = "5")]
	public ulong[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public MOJNNPCBGDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class CCGBLNNOIAC : global::HAKOMFHEDCC<float>, LOIEEHPBJBK, global::PEHGKAMCACG<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly CCGBLNNOIAC PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EDD0", Offset = "0x4C8DDD0", VA = "0x184C8EDD0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, float CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EDC0", Offset = "0x4C8DDC0", VA = "0x184C8EDC0", Slot = "5")]
	public float ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EE90", Offset = "0x4C8DE90", VA = "0x184C8EE90", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, float CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EDE0", Offset = "0x4C8DDE0", VA = "0x184C8EDE0", Slot = "7")]
	public float MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public CCGBLNNOIAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class CCBCKEFNOAG : global::HAKOMFHEDCC<float?>, LOIEEHPBJBK, global::PEHGKAMCACG<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly CCBCKEFNOAG PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EB70", Offset = "0x4C8DB70", VA = "0x184C8EB70", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, float? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EB00", Offset = "0x4C8DB00", VA = "0x184C8EB00", Slot = "5")]
	public float? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x4C8ECE0", Offset = "0x4C8DCE0", VA = "0x184C8ECE0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, float? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EBF0", Offset = "0x4C8DBF0", VA = "0x184C8EBF0", Slot = "7")]
	public float? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public CCBCKEFNOAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class CKFKFHBGDPO : global::HAKOMFHEDCC<float[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly CKFKFHBGDPO PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x4C914A0", Offset = "0x4C904A0", VA = "0x184C914A0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, float[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x4C91360", Offset = "0x4C90360", VA = "0x184C91360", Slot = "5")]
	public float[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public CKFKFHBGDPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class GFIHEOPJILJ : global::HAKOMFHEDCC<double>, LOIEEHPBJBK, global::PEHGKAMCACG<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly GFIHEOPJILJ PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x49CEE00", Offset = "0x49CDE00", VA = "0x1849CEE00", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, double CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x49CEDF0", Offset = "0x49CDDF0", VA = "0x1849CEDF0", Slot = "5")]
	public double ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x49CEE90", Offset = "0x49CDE90", VA = "0x1849CEE90", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, double CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x49CEE10", Offset = "0x49CDE10", VA = "0x1849CEE10", Slot = "7")]
	public double MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public GFIHEOPJILJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class LFHKEOHCMHC : global::HAKOMFHEDCC<double?>, LOIEEHPBJBK, global::PEHGKAMCACG<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly LFHKEOHCMHC PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x49DED00", Offset = "0x49DDD00", VA = "0x1849DED00", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, double? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x49DEC70", Offset = "0x49DDC70", VA = "0x1849DEC70", Slot = "5")]
	public double? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x49DEE60", Offset = "0x49DDE60", VA = "0x1849DEE60", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, double? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x49DED80", Offset = "0x49DDD80", VA = "0x1849DED80", Slot = "7")]
	public double? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public LFHKEOHCMHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class CPBMBHHNHAO : global::HAKOMFHEDCC<double[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly CPBMBHHNHAO PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x4C92FA0", Offset = "0x4C91FA0", VA = "0x184C92FA0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, double[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x4C92E60", Offset = "0x4C91E60", VA = "0x184C92E60", Slot = "5")]
	public double[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public CPBMBHHNHAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class AHCGJCBHFGC : global::HAKOMFHEDCC<bool>, LOIEEHPBJBK, global::PEHGKAMCACG<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly AHCGJCBHFGC PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x4C89490", Offset = "0x4C88490", VA = "0x184C89490", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, bool CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x4C89480", Offset = "0x4C88480", VA = "0x184C89480", Slot = "5")]
	public bool ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x4C89530", Offset = "0x4C88530", VA = "0x184C89530", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, bool CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x4C894B0", Offset = "0x4C884B0", VA = "0x184C894B0", Slot = "7")]
	public bool MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public AHCGJCBHFGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class COFHJILLEEB : global::HAKOMFHEDCC<bool?>, LOIEEHPBJBK, global::PEHGKAMCACG<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly COFHJILLEEB PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x4C92970", Offset = "0x4C91970", VA = "0x184C92970", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, bool? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x4C92900", Offset = "0x4C91900", VA = "0x184C92900", Slot = "5")]
	public bool? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x4C92AB0", Offset = "0x4C91AB0", VA = "0x184C92AB0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, bool? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x4C929F0", Offset = "0x4C919F0", VA = "0x184C929F0", Slot = "7")]
	public bool? MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public COFHJILLEEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class MKABKCNOAFJ : global::HAKOMFHEDCC<bool[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly MKABKCNOAFJ PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x49E2AC0", Offset = "0x49E1AC0", VA = "0x1849E2AC0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, bool[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x49E2890", Offset = "0x49E1890", VA = "0x1849E2890", Slot = "5")]
	public bool[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public MKABKCNOAFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class OIKCLIJLLOC : global::HAKOMFHEDCC<object>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly global::HAKOMFHEDCC<object> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static readonly Dictionary<Type, int> LHIIFJHHMNP;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x4D62120", Offset = "0x4D61120", VA = "0x184D62120", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, object CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x4D61DF0", Offset = "0x4D60DF0", VA = "0x184D61DF0", Slot = "5")]
	public object ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public OIKCLIJLLOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class EBPACFDNKHC : global::HAKOMFHEDCC<byte[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly global::HAKOMFHEDCC<byte[]> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x4C9F9D0", Offset = "0x4C9E9D0", VA = "0x184C9F9D0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, byte[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x4C9F950", Offset = "0x4C9E950", VA = "0x184C9F950", Slot = "5")]
	public byte[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public EBPACFDNKHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class GLKIAHNNLBP : global::HAKOMFHEDCC<ArraySegment<byte>>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly global::HAKOMFHEDCC<ArraySegment<byte>> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x49CFFC0", Offset = "0x49CEFC0", VA = "0x1849CFFC0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, ArraySegment<byte> CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x49CFEE0", Offset = "0x49CEEE0", VA = "0x1849CFEE0", Slot = "5")]
	public ArraySegment<byte> ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public GLKIAHNNLBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class BALNGJCGFPA : global::HAKOMFHEDCC<string>, LOIEEHPBJBK, global::PEHGKAMCACG<string>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::HAKOMFHEDCC<string> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x4C8D3E0", Offset = "0x4C8C3E0", VA = "0x184C8D3E0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, string CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x4C8D3D0", Offset = "0x4C8C3D0", VA = "0x184C8D3D0", Slot = "5")]
	public string ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x4C8D3E0", Offset = "0x4C8C3E0", VA = "0x184C8D3E0", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, string CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x4C8D3D0", Offset = "0x4C8C3D0", VA = "0x184C8D3D0", Slot = "7")]
	public string MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public BALNGJCGFPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class CMFJPGAJJKI : global::HAKOMFHEDCC<string[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly CMFJPGAJJKI PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x4C91B60", Offset = "0x4C90B60", VA = "0x184C91B60", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, string[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x4C919F0", Offset = "0x4C909F0", VA = "0x184C919F0", Slot = "5")]
	public string[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public CMFJPGAJJKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class AKFLKINCLFL : global::HAKOMFHEDCC<char>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly AKFLKINCLFL PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x4C89670", Offset = "0x4C88670", VA = "0x184C89670", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, char CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4C89640", Offset = "0x4C88640", VA = "0x184C89640", Slot = "5")]
	public char ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public AKFLKINCLFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class JBIPJIKNAOM : global::HAKOMFHEDCC<char?>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly JBIPJIKNAOM PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x49DBC30", Offset = "0x49DAC30", VA = "0x1849DBC30", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, char? CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x49DBB60", Offset = "0x49DAB60", VA = "0x1849DBB60", Slot = "5")]
	public char? ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public JBIPJIKNAOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class DMMNAHAEDKO : global::HAKOMFHEDCC<char[]>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly DMMNAHAEDKO PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x4C9E9F0", Offset = "0x4C9D9F0", VA = "0x184C9E9F0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, char[] CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x4C9E850", Offset = "0x4C9D850", VA = "0x184C9E850", Slot = "5")]
	public char[] ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public DMMNAHAEDKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class PIOKJLHBKAP : global::HAKOMFHEDCC<Guid>, LOIEEHPBJBK, global::PEHGKAMCACG<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::HAKOMFHEDCC<Guid> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x4D64870", Offset = "0x4D63870", VA = "0x184D64870", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Guid CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x4D64820", Offset = "0x4D63820", VA = "0x184D64820", Slot = "5")]
	public Guid ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x4D64940", Offset = "0x4D63940", VA = "0x184D64940", Slot = "6")]
	public void OCNGFKBFDGD(ref KNPMIFIKMDA FBNHINKPMEA, Guid CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x4D64820", Offset = "0x4D63820", VA = "0x184D64820", Slot = "7")]
	public Guid MKMNFNCACHN(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public PIOKJLHBKAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class HLGNHPFLPLN : global::HAKOMFHEDCC<decimal>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::HAKOMFHEDCC<decimal> PJLEDACBOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private readonly bool KMPKBAFLHGA;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x8C9400", Offset = "0x8C8400", VA = "0x1808C9400")]
	public HLGNHPFLPLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x1A4F340", Offset = "0x1A4E340", VA = "0x181A4F340")]
	public HLGNHPFLPLN(bool KMPKBAFLHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x49DB140", Offset = "0x49DA140", VA = "0x1849DB140", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, decimal CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x49DAF10", Offset = "0x49D9F10", VA = "0x1849DAF10", Slot = "5")]
	public decimal ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class PKDAMLCIJAM : global::HAKOMFHEDCC<Uri>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly global::HAKOMFHEDCC<Uri> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x4D64DD0", Offset = "0x4D63DD0", VA = "0x184D64DD0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Uri CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x4D64D50", Offset = "0x4D63D50", VA = "0x184D64D50", Slot = "5")]
	public Uri ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public PKDAMLCIJAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class PGAICMBLBCN : global::HAKOMFHEDCC<Version>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly global::HAKOMFHEDCC<Version> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x4D642C0", Offset = "0x4D632C0", VA = "0x184D642C0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Version CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x4D64240", Offset = "0x4D63240", VA = "0x184D64240", Slot = "5")]
	public Version ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public PGAICMBLBCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class GIOABHNAKEN<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class BOEPLDLDFIG : global::HAKOMFHEDCC<StringBuilder>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	public static readonly global::HAKOMFHEDCC<StringBuilder> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EA50", Offset = "0x4C8DA50", VA = "0x184C8EA50", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, StringBuilder CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x4C8E9D0", Offset = "0x4C8D9D0", VA = "0x184C8E9D0", Slot = "5")]
	public StringBuilder ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public BOEPLDLDFIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class HFBMLEFCPAB : global::HAKOMFHEDCC<BitArray>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly global::HAKOMFHEDCC<BitArray> PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x49D9C50", Offset = "0x49D8C50", VA = "0x1849D9C50", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, BitArray CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x49D9A50", Offset = "0x49D8A50", VA = "0x1849D9A50", Slot = "5")]
	public BitArray ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public HFBMLEFCPAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class ADEMNALPONN : global::HAKOMFHEDCC<Type>, LOIEEHPBJBK
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly ADEMNALPONN PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static readonly Regex DBHNIPOABDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool JBPNJNEJEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private bool DLHLCBKPBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private bool GLKKAIBOEMB;

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x4C88C90", Offset = "0x4C87C90", VA = "0x184C88C90")]
	public ADEMNALPONN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x4C88CB0", Offset = "0x4C87CB0", VA = "0x184C88CB0")]
	public ADEMNALPONN(bool JBPNJNEJEJN, bool DLHLCBKPBKO, bool GLKKAIBOEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x4C88AE0", Offset = "0x4C87AE0", VA = "0x184C88AE0", Slot = "4")]
	public void HHDOHEHKDKI(ref KNPMIFIKMDA FBNHINKPMEA, Type CCIMHDCKHOF, IEIMAIBIIFF KLAJOIJPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x4C889B0", Offset = "0x4C879B0", VA = "0x184C889B0", Slot = "5")]
	public Type ADHMOLAJGDE(ref GOCMFGPNGFE CLOGDHPGNHC, IEIMAIBIIFF KLAJOIJPOEN)
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
