using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class LLMLKCOLGLP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A85690", Offset = "0x6A84690", VA = "0x186A85690")]
	public static bool LMLMFMOGFID(this TypeInfo IKHOLAJCJOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class OONJKGOKPEK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type DDDCAJAGOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BC250", Offset = "0x7BB250", VA = "0x1807BC250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] MKFFFCABJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E62B0", Offset = "0x7E52B0", VA = "0x1807E62B0")]
	public OONJKGOKPEK(Type NMAMOJBFAMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class JHLOJJPEJNL : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void DDHGDMPLPDO<T>(KCGIPMDKOPA HKMKHKLNOHE, T CFJDHAGGAJO, NONFMIGJIBJ GNHNCNIOALD);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T ENDAIOEHMGF<T>(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ GNHNCNIOALD);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BGMCLJEKLLA
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GBPBACCCJGH<T> : BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, T CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IGCFOJAHFAN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, T CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JONLHIEOKLA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class FHEFCLCEGOM
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2783570", Offset = "0x2782570", VA = "0x182783570")]
	public static string JAICAJHACDF<T>(this GBPBACCCJGH<T> AGPJDGEEBPG, T CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GBPBACCCJGH<T> HJFCLLBKDIF<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class EDMMGAICCGI
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x266B0F0", Offset = "0x266A0F0", VA = "0x18266B0F0")]
	public static GBPBACCCJGH<T> NEBPHBNIIPB<T>(this NONFMIGJIBJ GNHNCNIOALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A7EFD0", Offset = "0x6A7DFD0", VA = "0x186A7EFD0")]
	public static object BIGNJJBKAGA(this NONFMIGJIBJ GNHNCNIOALD, Type IKHOLAJCJOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EPGFKOMMBFE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F2B0", Offset = "0x6A7E2B0", VA = "0x186A7F2B0")]
	public EPGFKOMMBFE(string DFJKCKBFLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct OOEOKDFPEDP
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class DMCCKHDBBGH
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] EOOJCJAHOCJ;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] CNIMNEPMDPG;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6A74A60", Offset = "0x6A73A60", VA = "0x186A74A60")]
		public static byte[] HOHNAHAPBBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A749C0", Offset = "0x6A739C0", VA = "0x186A749C0")]
		public static char[] EFCGPFMOADH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> GMGAOGACHFH;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] KAJDFHDDPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] EOMNNFHDHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int CNHEAECNOFO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool HOGPHJDENFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A865F0", Offset = "0x6A855F0", VA = "0x186A865F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A89600", Offset = "0x6A88600", VA = "0x186A89600")]
	public OOEOKDFPEDP(byte[] EOMNNFHDHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A89660", Offset = "0x6A88660", VA = "0x186A89660")]
	public OOEOKDFPEDP(byte[] EOMNNFHDHII, int CNHEAECNOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A888E0", Offset = "0x6A878E0", VA = "0x186A888E0")]
	private KOBKNLGBIFL MMINJLBDCAF(string FGAHAIJGBCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A868B0", Offset = "0x6A858B0", VA = "0x186A868B0")]
	private KOBKNLGBIFL DHAJJKALOLP(string DFJKCKBFLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A82B10", Offset = "0x6A81B10", VA = "0x186A82B10")]
	public void GFAOFKMBHLO(int CNHEAECNOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x889EF0", Offset = "0x888EF0", VA = "0x180889EF0")]
	public byte[] IAKOCDHGCEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160")]
	public int KDHKHJOBECP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A88260", Offset = "0x6A87260", VA = "0x186A88260")]
	public FIIKDNGNKAL KPJLCLIIBGI()
	{
		return default(FIIKDNGNKAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A86A10", Offset = "0x6A85A10", VA = "0x186A86A10")]
	public void DMDMBNHEHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A86DB0", Offset = "0x6A85DB0", VA = "0x186A86DB0")]
	public bool ENABHKGNOKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A866A0", Offset = "0x6A856A0", VA = "0x186A866A0")]
	public bool CFCBNGBLOFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A86D10", Offset = "0x6A85D10", VA = "0x186A86D10")]
	public void EHHKLBABPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A88150", Offset = "0x6A87150", VA = "0x186A88150")]
	public bool ILHIDKIGGBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A86C40", Offset = "0x6A85C40", VA = "0x186A86C40")]
	public bool EDHHOFPFPDF(int FBDNKGNOEFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A89410", Offset = "0x6A88410", VA = "0x186A89410")]
	public bool PMJDJPEIDPA(int FBDNKGNOEFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A86610", Offset = "0x6A85610", VA = "0x186A86610")]
	public bool CEDNDDDMPNG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A89270", Offset = "0x6A88270", VA = "0x186A89270")]
	public void PGPAHMJNGHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A886E0", Offset = "0x6A876E0", VA = "0x186A886E0")]
	public bool LGEJDLNKOLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A89060", Offset = "0x6A88060", VA = "0x186A89060")]
	public bool NNMEFPMOCEB(int FBDNKGNOEFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A88E30", Offset = "0x6A87E30", VA = "0x186A88E30")]
	public bool NBDCFEAFFKD(int FBDNKGNOEFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A87D70", Offset = "0x6A86D70", VA = "0x186A87D70")]
	public bool HJAOBAHJKPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A87F60", Offset = "0x6A86F60", VA = "0x186A87F60")]
	public void IFFBCGJHJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A86330", Offset = "0x6A85330", VA = "0x186A86330")]
	public bool ADHPALCAEPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A863C0", Offset = "0x6A853C0", VA = "0x186A863C0")]
	public void AHEMDAGHPBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A87000", Offset = "0x6A86000", VA = "0x186A87000")]
	private void FOBKBNBBLJF([Out] byte[] LIFOGPGIPHO, [Out] int ICJDGNDANJO, [Out] int LONPCJPJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A86F50", Offset = "0x6A85F50", VA = "0x186A86F50")]
	private static int FJCOKHDJFKI(char ABLMDKMDGNE, char AMHEHNHOGFM, char BKPEEMPJCKD, char MCPFEGADMJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A87E80", Offset = "0x6A86E80", VA = "0x186A87E80")]
	private static int IFCFJEJNJCK(char GDALFMOOMGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A86460", Offset = "0x6A85460", VA = "0x186A86460")]
	public ArraySegment<byte> BBKPODKMEBH()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A877A0", Offset = "0x6A867A0", VA = "0x186A877A0")]
	public string GALBJDLLGLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A86580", Offset = "0x6A85580", VA = "0x186A86580")]
	public string BEKCGHLKFHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A87AD0", Offset = "0x6A86AD0", VA = "0x186A87AD0")]
	public ArraySegment<byte> GPDJAPODJHE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A869A0", Offset = "0x6A859A0", VA = "0x186A869A0")]
	public ArraySegment<byte> DKKAPFPJAPJ()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A87880", Offset = "0x6A86880", VA = "0x186A87880")]
	public bool GLIKNFHOAOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A867F0", Offset = "0x6A857F0", VA = "0x186A867F0")]
	private static bool CICDEPCGGAD(byte BKPEEMPJCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A88490", Offset = "0x6A87490", VA = "0x186A88490")]
	private void LCCPJDMAEPI(FIIKDNGNKAL OGACLNNOKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A88100", Offset = "0x6A87100", VA = "0x186A88100")]
	public void IJEOEDACJGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A88F00", Offset = "0x6A87F00", VA = "0x186A88F00")]
	private void NCBDBHJLAJE(int FOOJCMEKDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A86ED0", Offset = "0x6A85ED0", VA = "0x186A86ED0")]
	public sbyte ENKABHFHDHH()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A881E0", Offset = "0x6A871E0", VA = "0x186A881E0")]
	public short JIKHGKEJAFJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A88410", Offset = "0x6A87410", VA = "0x186A88410")]
	public int LAJPEOBGCNB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A891B0", Offset = "0x6A881B0", VA = "0x186A891B0")]
	public long PEGBGEIBBEO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A87E00", Offset = "0x6A86E00", VA = "0x186A87E00")]
	public byte IBGKCHEGBIK()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A87CF0", Offset = "0x6A86CF0", VA = "0x186A87CF0")]
	public ushort HCGNAHMCLOG()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A89130", Offset = "0x6A88130", VA = "0x186A89130")]
	public uint OCPHMHOELJK()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6A86730", Offset = "0x6A85730", VA = "0x186A86730")]
	public ulong CIAGBPDBANK()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A89310", Offset = "0x6A88310", VA = "0x186A89310")]
	public float PHIAONANKJD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A86B40", Offset = "0x6A85B40", VA = "0x186A86B40")]
	public double DPFNCANGFNB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6A88000", Offset = "0x6A87000", VA = "0x186A88000")]
	public ArraySegment<byte> IIJDANGLNLN()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A88770", Offset = "0x6A87770", VA = "0x186A88770")]
	private static int LOFOMEKAILH(byte[] EOMNNFHDHII, int CNHEAECNOFO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KOBKNLGBIFL : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference MFKMCLNMEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int BPNMDBKJDHK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int GGCHNCJELKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC6E090", Offset = "0xC6D090", VA = "0x180C6E090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string EMDAEOGAKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x882A10", Offset = "0x881A10", VA = "0x180882A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A837A0", Offset = "0x6A827A0", VA = "0x186A837A0")]
	public KOBKNLGBIFL(string DFJKCKBFLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A836B0", Offset = "0x6A826B0", VA = "0x186A836B0")]
	public KOBKNLGBIFL(string DFJKCKBFLAD, byte[] BBBCIGOEAOJ, int CNHEAECNOFO, int BPNMDBKJDHK, string OHHFHJHGJEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LBDMDCPOEGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class LCCLBDCOOLD
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] EOOJCJAHOCJ;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A85460", Offset = "0x6A84460", VA = "0x186A85460")]
		public static byte[] HOHNAHAPBBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class FCGIGGPLANC
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void KOOOJBDIIBO(KCGIPMDKOPA HKMKHKLNOHE, object CFJDHAGGAJO, NONFMIGJIBJ GNHNCNIOALD);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object ODKNAPPJLPO(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ GNHNCNIOALD);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class DPLBPBLPDCP
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class GKBHKELNIJM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
				public GKBHKELNIJM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x3C23BD0", Offset = "0x3C22BD0", VA = "0x183C23BD0")]
				internal bool KGNAHKDJJLF(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x6A7FE10", Offset = "0x6A7EE10", VA = "0x186A7FE10")]
				internal bool GJEPEGMFGGO(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, NONFMIGJIBJ, byte[]> INCKKIEDNEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, NONFMIGJIBJ> ILNPEACOKPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly KOOOJBDIIBO HNILFAIKPJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, NONFMIGJIBJ, ArraySegment<byte>> KDNLPDHIICM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, NONFMIGJIBJ, string> ALMGEDHFCCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, NONFMIGJIBJ, object> MLBLEKOBECM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, NONFMIGJIBJ, object> ICLBAICAFIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, NONFMIGJIBJ, object> EOGGCHGBGCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly ODKNAPPJLPO MNCMMHBFNHM;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6A7D250", Offset = "0x6A7C250", VA = "0x186A7D250")]
			public DPLBPBLPDCP(Type IKHOLAJCJOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2D43B70", Offset = "0x2D42B70", VA = "0x182D43B70")]
			private static T GFLNEGFJMJF<T>(DynamicMethod DKLPLDIGAOJ)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6A7D000", Offset = "0x6A7C000", VA = "0x186A7D000")]
			private static MethodInfo PFKGHOKBLGP(Type IKHOLAJCJOG, string GCMHJLFFDHO, Type[] CDHPKLAEGCM)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, DPLBPBLPDCP> INEMIIEKCDC;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly AOLGEKAGBEO<DPLBPBLPDCP> KLGJIMFPEOE;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F720", Offset = "0x6A7E720", VA = "0x186A7F720")]
		static FCGIGGPLANC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F410", Offset = "0x6A7E410", VA = "0x186A7F410")]
		private static DPLBPBLPDCP KFEHOFHILDH(Type IKHOLAJCJOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F5A0", Offset = "0x6A7E5A0", VA = "0x186A7F5A0")]
		public static void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, object CFJDHAGGAJO, NONFMIGJIBJ GNHNCNIOALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F490", Offset = "0x6A7E490", VA = "0x186A7F490")]
		public static void PAKOMNGHIKD(Type IKHOLAJCJOG, KCGIPMDKOPA HKMKHKLNOHE, object CFJDHAGGAJO, NONFMIGJIBJ GNHNCNIOALD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static NONFMIGJIBJ BFHFABLOFGC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] ACCMPLBKBJO;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] OPJHJOFLEKF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NONFMIGJIBJ OHCEJCACFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6A83D70", Offset = "0x6A82D70", VA = "0x186A83D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool BKDIPLKNCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6A83F10", Offset = "0x6A82F10", VA = "0x186A83F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A84820", Offset = "0x6A83820", VA = "0x186A84820")]
	public static void NKEBCKLKMLE(NONFMIGJIBJ GNHNCNIOALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2837EE0", Offset = "0x2836EE0", VA = "0x182837EE0")]
	public static byte[] PAKOMNGHIKD<T>(T FGOCJODIEMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2837D70", Offset = "0x2836D70", VA = "0x182837D70")]
	public static byte[] PAKOMNGHIKD<T>(T CFJDHAGGAJO, NONFMIGJIBJ GNHNCNIOALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2838160", Offset = "0x2837160", VA = "0x182838160")]
	public static void PAKOMNGHIKD<T>(KCGIPMDKOPA HKMKHKLNOHE, T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x28383C0", Offset = "0x28373C0", VA = "0x1828383C0")]
	public static void PAKOMNGHIKD<T>(KCGIPMDKOPA HKMKHKLNOHE, T CFJDHAGGAJO, NONFMIGJIBJ GNHNCNIOALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2838330", Offset = "0x2837330", VA = "0x182838330")]
	public static void PAKOMNGHIKD<T>(Stream OEHHIKFPHHD, T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x28381F0", Offset = "0x28371F0", VA = "0x1828381F0")]
	public static void PAKOMNGHIKD<T>(Stream OEHHIKFPHHD, T CFJDHAGGAJO, NONFMIGJIBJ GNHNCNIOALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2837CE0", Offset = "0x2836CE0", VA = "0x182837CE0")]
	public static ArraySegment<byte> NFNMMEAGGHA<T>(T FGOCJODIEMI)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2837B50", Offset = "0x2836B50", VA = "0x182837B50")]
	public static ArraySegment<byte> NFNMMEAGGHA<T>(T CFJDHAGGAJO, NONFMIGJIBJ GNHNCNIOALD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2836490", Offset = "0x2835490", VA = "0x182836490")]
	public static string JAICAJHACDF<T>(T CFJDHAGGAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2836510", Offset = "0x2835510", VA = "0x182836510")]
	public static string JAICAJHACDF<T>(T CFJDHAGGAJO, NONFMIGJIBJ GNHNCNIOALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2837360", Offset = "0x2836360", VA = "0x182837360")]
	public static T MPIEPNPHGIA<T>(string OMGDFOAKJIJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2837270", Offset = "0x2836270", VA = "0x182837270")]
	public static T MPIEPNPHGIA<T>(string OMGDFOAKJIJ, NONFMIGJIBJ GNHNCNIOALD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x28378E0", Offset = "0x28368E0", VA = "0x1828378E0")]
	public static T MPIEPNPHGIA<T>(byte[] EOMNNFHDHII)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2837050", Offset = "0x2836050", VA = "0x182837050")]
	public static T MPIEPNPHGIA<T>(byte[] EOMNNFHDHII, NONFMIGJIBJ GNHNCNIOALD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2837700", Offset = "0x2836700", VA = "0x182837700")]
	public static T MPIEPNPHGIA<T>(byte[] EOMNNFHDHII, int CNHEAECNOFO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x28370E0", Offset = "0x28360E0", VA = "0x1828370E0")]
	public static T MPIEPNPHGIA<T>(byte[] EOMNNFHDHII, int CNHEAECNOFO, NONFMIGJIBJ GNHNCNIOALD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2837960", Offset = "0x2836960", VA = "0x182837960")]
	public static T MPIEPNPHGIA<T>(OOEOKDFPEDP PCOFGFPALLL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x28375B0", Offset = "0x28365B0", VA = "0x1828375B0")]
	public static T MPIEPNPHGIA<T>(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ GNHNCNIOALD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2837790", Offset = "0x2836790", VA = "0x182837790")]
	public static T MPIEPNPHGIA<T>(Stream OEHHIKFPHHD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28373F0", Offset = "0x28363F0", VA = "0x1828373F0")]
	public static T MPIEPNPHGIA<T>(Stream OEHHIKFPHHD, NONFMIGJIBJ GNHNCNIOALD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A84240", Offset = "0x6A83240", VA = "0x186A84240")]
	public static string JMAHLHEOHFN(byte[] OMGDFOAKJIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A83F70", Offset = "0x6A82F70", VA = "0x186A83F70")]
	public static string JMAHLHEOHFN(byte[] OMGDFOAKJIJ, int CNHEAECNOFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A840B0", Offset = "0x6A830B0", VA = "0x186A840B0")]
	public static string JMAHLHEOHFN(string OMGDFOAKJIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A846A0", Offset = "0x6A836A0", VA = "0x186A846A0")]
	public static byte[] MMFAMJAEGAG(byte[] OMGDFOAKJIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A843A0", Offset = "0x6A833A0", VA = "0x186A843A0")]
	public static byte[] MMFAMJAEGAG(byte[] OMGDFOAKJIJ, int CNHEAECNOFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6A844F0", Offset = "0x6A834F0", VA = "0x186A844F0")]
	public static byte[] MMFAMJAEGAG(string OMGDFOAKJIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6A84890", Offset = "0x6A83890", VA = "0x186A84890")]
	private static void NMFHBMNPMMK(OOEOKDFPEDP PCOFGFPALLL, KCGIPMDKOPA HKMKHKLNOHE, int CJOODCGGDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A83E70", Offset = "0x6A82E70", VA = "0x186A83E70")]
	private static int BOMCDAIEENO(Stream IIBDJBFNFJM, byte[] EOOJCJAHOCJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum FIIKDNGNKAL : byte
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
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct KCGIPMDKOPA
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] BOFGCMNLCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] EOOJCJAHOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int CNHEAECNOFO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HIDBJPKKKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1DC4160", Offset = "0x1DC3160", VA = "0x181DC4160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A82B10", Offset = "0x6A81B10", VA = "0x186A82B10")]
	public void GFAOFKMBHLO(int CNHEAECNOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A82760", Offset = "0x6A81760", VA = "0x186A82760")]
	public static byte[] EFBKNEPGMLC(string PKHLAIKJKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6A82930", Offset = "0x6A81930", VA = "0x186A82930")]
	public static byte[] FBNALHIGCAD(string PKHLAIKJKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6A83310", Offset = "0x6A82310", VA = "0x186A83310")]
	public static byte[] NJBIAMHGEMH(string PKHLAIKJKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A82F40", Offset = "0x6A81F40", VA = "0x186A82F40")]
	public static byte[] LKBFOOEGHEE(string PKHLAIKJKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x566C700", Offset = "0x566B700", VA = "0x18566C700")]
	public KCGIPMDKOPA(byte[] CBLBODIGJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6A82C10", Offset = "0x6A81C10", VA = "0x186A82C10")]
	public ArraySegment<byte> HOHNAHAPBBG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D30", Offset = "0x6A81D30", VA = "0x186A82D30")]
	public byte[] JLGBLOCDIDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A834E0", Offset = "0x6A824E0", VA = "0x186A834E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A83480", Offset = "0x6A82480", VA = "0x186A83480")]
	public void OCJNNEHLECK(int DGBCPLJLLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A83280", Offset = "0x6A82280", VA = "0x186A83280")]
	public void NFKOHLCPELH(byte LJIGEGLNGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A83220", Offset = "0x6A82220", VA = "0x186A83220")]
	public void NFKOHLCPELH(byte[] LJIGEGLNGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A826D0", Offset = "0x6A816D0", VA = "0x186A826D0")]
	public void DEENJDMABIA(byte LJIGEGLNGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82890", Offset = "0x6A81890", VA = "0x186A82890")]
	public void EJHCKGIFMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6A82CE0", Offset = "0x6A81CE0", VA = "0x186A82CE0")]
	public void IIGOAHCGOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A828E0", Offset = "0x6A818E0", VA = "0x186A828E0")]
	public void EOHDAHPJAEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A83490", Offset = "0x6A82490", VA = "0x186A83490")]
	public void OIELOHCKKKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A82E80", Offset = "0x6A81E80", VA = "0x186A82E80")]
	public void KGJLJOMBKLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6A82BC0", Offset = "0x6A81BC0", VA = "0x186A82BC0")]
	public void HNODGEMNCEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6A82230", Offset = "0x6A81230", VA = "0x186A82230")]
	public void CAKMOPNDAJG(string PKHLAIKJKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6A82710", Offset = "0x6A81710", VA = "0x186A82710")]
	public void DKEBEMGGCPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6A82B20", Offset = "0x6A81B20", VA = "0x186A82B20")]
	public void GFDKJHBDAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6A830C0", Offset = "0x6A820C0", VA = "0x186A830C0")]
	public void NANBOBEOKLL(bool CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6A821B0", Offset = "0x6A811B0", VA = "0x186A821B0")]
	public void AOJJGPMMKJP(float CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A820C0", Offset = "0x6A810C0", VA = "0x186A820C0")]
	public void ABBGOEBPKNC(double CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A822D0", Offset = "0x6A812D0", VA = "0x186A822D0")]
	public void CIAADCEJMKB(byte CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A82ED0", Offset = "0x6A81ED0", VA = "0x186A82ED0")]
	public void LJNGAEMPCGH(ushort CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A82DA0", Offset = "0x6A81DA0", VA = "0x186A82DA0")]
	public void KEKMFACAEAN(uint CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6A832E0", Offset = "0x6A822E0", VA = "0x186A832E0")]
	public void NHIEAODPHAK(ulong CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6A82AA0", Offset = "0x6A81AA0", VA = "0x186A82AA0")]
	public void FDMANCHAGCF(sbyte CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A82E10", Offset = "0x6A81E10", VA = "0x186A82E10")]
	public void KGFOLGFPIMB(short CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A82140", Offset = "0x6A81140", VA = "0x186A82140")]
	public void AOECBAFAFCA(int CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A82CB0", Offset = "0x6A81CB0", VA = "0x186A82CB0")]
	public void IGLPFMBMJBJ(long CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A82340", Offset = "0x6A81340", VA = "0x186A82340")]
	public void CIEMKJLOIBD(string CFJDHAGGAJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class PNDOPCFMFHM : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class ICNGPEOEEPF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x391E480", Offset = "0x391D480", VA = "0x18391E480")]
		static ICNGPEOEEPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private PNDOPCFMFHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class JHNIOLOMGLK : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private static class IBCANLIPDAP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3888E30", Offset = "0x3887E30", VA = "0x183888E30")]
		static IBCANLIPDAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal static class CEEGHANGGDF
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly Dictionary<Type, object> ILCJJBFPPEI;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6A729B0", Offset = "0x6A719B0", VA = "0x186A729B0")]
		internal static object HJFCLLBKDIF(Type MPLEEKHPBJH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private JHNIOLOMGLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class LAEJBKKHGBB : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private static class BNIJCNHCBPD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x47E2650", Offset = "0x47E1650", VA = "0x1847E2650")]
		static BNIJCNHCBPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly LAEJBKKHGBB GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static bool LNJDDLGKNAA;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static BGMCLJEKLLA[] ECIDMHOIGJK;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static NONFMIGJIBJ[] EKNPFMOGGNJ;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private LAEJBKKHGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A83A90", Offset = "0x6A82A90", VA = "0x186A83A90")]
	public static void PCEAKBMIBLF(params NONFMIGJIBJ[] EKNPFMOGGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A83B70", Offset = "0x6A82B70", VA = "0x186A83B70")]
	public static void PCEAKBMIBLF(params BGMCLJEKLLA[] ECIDMHOIGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A83800", Offset = "0x6A82800", VA = "0x186A83800")]
	public static void OAHHOGFJDII(BGMCLJEKLLA[] ECIDMHOIGJK, NONFMIGJIBJ[] EKNPFMOGGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class DPFEOOKMEOC : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private static class NJGGKFFJBMD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3F86080", Offset = "0x3F85080", VA = "0x183F86080")]
		static NJGGKFFJBMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private DPFEOOKMEOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class MBKDLJPFMPF
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly NONFMIGJIBJ KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly NONFMIGJIBJ EDFBGFAKEMJ;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly NONFMIGJIBJ FJHKMAFELDO;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly NONFMIGJIBJ GALBDNMILHG;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly NONFMIGJIBJ NJBFFJHHLMA;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly NONFMIGJIBJ HAMPFFFPAMC;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly NONFMIGJIBJ DFPDOHBKLFH;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly NONFMIGJIBJ BGCBIOFCNAN;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly NONFMIGJIBJ DJELKJKPKFK;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly NONFMIGJIBJ IGMHKICOLGO;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly NONFMIGJIBJ IOMEGAFLBMA;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly NONFMIGJIBJ LOOBHDHOMFN;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class CLNBOHDMFMN
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly NONFMIGJIBJ KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly NONFMIGJIBJ MADLGHDPEOM;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class ADNEEDENPKL
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly NONFMIGJIBJ KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly NONFMIGJIBJ EDFBGFAKEMJ;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly NONFMIGJIBJ FJHKMAFELDO;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly NONFMIGJIBJ GALBDNMILHG;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly NONFMIGJIBJ NJBFFJHHLMA;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly NONFMIGJIBJ HAMPFFFPAMC;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly NONFMIGJIBJ DFPDOHBKLFH;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly NONFMIGJIBJ BGCBIOFCNAN;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly NONFMIGJIBJ DJELKJKPKFK;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly NONFMIGJIBJ IGMHKICOLGO;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly NONFMIGJIBJ IOMEGAFLBMA;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly NONFMIGJIBJ LOOBHDHOMFN;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class BPOJMHOMGNC
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly Dictionary<Type, Type> ILCJJBFPPEI;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A70D00", Offset = "0x6A6FD00", VA = "0x186A70D00")]
	internal static object HJFCLLBKDIF(Type MPLEEKHPBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A70CC0", Offset = "0x6A6FCC0", VA = "0x186A70CC0")]
	private static object AKFKNOPJLDN(Type KKBANHINNDM, Type[] EEFALEEJFIG, params object[] CDHPKLAEGCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class LCACMKAHCLN : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private static class PEMJMDHLAKF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4143960", Offset = "0x4142960", VA = "0x184143960")]
		static PEMJMDHLAKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly Func<string, string> CIEGPIHHFIE;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly bool GAAEKJCDNJO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly AMOOLLKAPMP KMIBMEEIFFK;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A852F0", Offset = "0x6A842F0", VA = "0x186A852F0")]
	static LCACMKAHCLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private LCACMKAHCLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class JBHNNJABCMP : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private static class ODIMJHNEJML<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x406C750", Offset = "0x406B750", VA = "0x18406C750")]
		static ODIMJHNEJML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Func<string, string> CIEGPIHHFIE;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly bool GAAEKJCDNJO;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly AMOOLLKAPMP KMIBMEEIFFK;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A81310", Offset = "0x6A80310", VA = "0x186A81310")]
	static JBHNNJABCMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private JBHNNJABCMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class BPLIEKBLFOC : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class LNBDLKLMPGJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3CFFF90", Offset = "0x3CFEF90", VA = "0x183CFFF90")]
		static LNBDLKLMPGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly Func<string, string> CIEGPIHHFIE;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly bool GAAEKJCDNJO;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly AMOOLLKAPMP KMIBMEEIFFK;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A70B50", Offset = "0x6A6FB50", VA = "0x186A70B50")]
	static BPLIEKBLFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private BPLIEKBLFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class FHNFOHFLEAJ : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class CHENENBPBAH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4C94E00", Offset = "0x4C93E00", VA = "0x184C94E00")]
		static CHENENBPBAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly Func<string, string> CIEGPIHHFIE;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly bool GAAEKJCDNJO;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly AMOOLLKAPMP KMIBMEEIFFK;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A7F870", Offset = "0x6A7E870", VA = "0x186A7F870")]
	static FHNFOHFLEAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private FHNFOHFLEAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class HBDNCPDKGOC : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private static class ADNLIFLEAKF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x37984B0", Offset = "0x37974B0", VA = "0x1837984B0")]
		static ADNLIFLEAKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly Func<string, string> CIEGPIHHFIE;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly bool GAAEKJCDNJO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly AMOOLLKAPMP KMIBMEEIFFK;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A7FFD0", Offset = "0x6A7EFD0", VA = "0x186A7FFD0")]
	static HBDNCPDKGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private HBDNCPDKGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class PKJAKLKDDLC : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class HOCHCNOCCBC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3801000", Offset = "0x3800000", VA = "0x183801000")]
		static HOCHCNOCCBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Func<string, string> CIEGPIHHFIE;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly bool GAAEKJCDNJO;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly AMOOLLKAPMP KMIBMEEIFFK;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A897C0", Offset = "0x6A887C0", VA = "0x186A897C0")]
	static PKJAKLKDDLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private PKJAKLKDDLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class FBHAPJPIKCC : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class GCBOKBNGLFF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x373AE20", Offset = "0x3739E20", VA = "0x18373AE20")]
		static GCBOKBNGLFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static readonly Func<string, string> CIEGPIHHFIE;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly bool GAAEKJCDNJO;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public FBHAPJPIKCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class GBCMGCKOMBB : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class KGJJNDHGIIK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3C19510", Offset = "0x3C18510", VA = "0x183C19510")]
		static KGJJNDHGIIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly Func<string, string> CIEGPIHHFIE;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly bool GAAEKJCDNJO;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public GBCMGCKOMBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class CIDPMLCDGBL : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class BMPGONCIHMA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x47DAC40", Offset = "0x47D9C40", VA = "0x1847DAC40")]
		static BMPGONCIHMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly Func<string, string> CIEGPIHHFIE;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly bool GAAEKJCDNJO;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public CIDPMLCDGBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class AGFPCHJNEMC : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class ANGBFIMOPMA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x38D7430", Offset = "0x38D6430", VA = "0x1838D7430")]
		static ANGBFIMOPMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> CIEGPIHHFIE;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool GAAEKJCDNJO;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public AGFPCHJNEMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class KFIJOGGJEDC : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class PJJMEIEOPHF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4150790", Offset = "0x414F790", VA = "0x184150790")]
		static PJJMEIEOPHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly Func<string, string> CIEGPIHHFIE;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly bool GAAEKJCDNJO;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public KFIJOGGJEDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class HDCDAKFINFK : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class BHAPCPJGDGF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x47B69B0", Offset = "0x47B59B0", VA = "0x1847B69B0")]
		static BHAPCPJGDGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Func<string, string> CIEGPIHHFIE;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly bool GAAEKJCDNJO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public HDCDAKFINFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal static class DOAGCAOFCLL
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct PLBLJBJBIOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public CPBONNDALAG EGKCCGLEMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LocalBuilder IAODLOECMJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LocalBuilder PCIDMMLDBEB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal static class PLFKDPLCNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		internal static class ILGPLIBOJBN
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public static readonly MethodInfo NJBIAMHGEMH;

			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly MethodInfo FBNALHIGCAD;

			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public static readonly MethodInfo LKBFOOEGHEE;

			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public static readonly MethodInfo EFBKNEPGMLC;

			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public static readonly MethodInfo GFDKJHBDAKM;

			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public static readonly MethodInfo NFKOHLCPELH;

			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public static readonly MethodInfo EOHDAHPJAEP;

			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public static readonly MethodInfo OIELOHCKKKF;

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly MethodInfo KGJLJOMBKLK;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6A803E0", Offset = "0x6A7F3E0", VA = "0x186A803E0")]
			static ILGPLIBOJBN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		internal static class JOECMAINNDG
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public static readonly MethodInfo ENABHKGNOKG;

			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly MethodInfo PGPAHMJNGHF;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly MethodInfo NNMEFPMOCEB;

			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly MethodInfo ALFDKJKPDOK;

			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public static readonly MethodInfo IJEOEDACJGE;

			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public static readonly MethodInfo IAKOCDHGCEM;

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly MethodInfo KDHKHJOBECP;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6A81500", Offset = "0x6A80500", VA = "0x186A81500")]
			static JOECMAINNDG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		internal static class NNGFJNGGCEF
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			internal static readonly MethodInfo DDDCAJAGOEN;

			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			internal static readonly MethodInfo MKFFFCABJDM;
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly ConstructorInfo EBBFIKCAJNM;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly MethodInfo NEBPHBNIIPB;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly ConstructorInfo BAFJOGMJKGG;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public static readonly MethodInfo OFBAMEHPGAJ;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly MethodInfo ABJKBLDJPFI;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly MethodInfo HBBLBCFHLIC;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly MethodInfo FOMJNCHAELD;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly MethodInfo BGLNOOFNBPH;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly MethodInfo BFJJLKLEIPO;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly MethodInfo FPMCIGJCEJP;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly MethodInfo LJPLIEGJEPJ;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly MethodInfo ACDGAKCFMEN;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6A89CA0", Offset = "0x6A88CA0", VA = "0x186A89CA0")]
		public static MethodInfo PAKOMNGHIKD(Type IKHOLAJCJOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6A89A60", Offset = "0x6A88A60", VA = "0x186A89A60")]
		public static MethodInfo MPIEPNPHGIA(Type IKHOLAJCJOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6A89930", Offset = "0x6A88930", VA = "0x186A89930")]
		public static MethodInfo BJCPFPDJMAL(Type IKHOLAJCJOG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class CJKHPLLMGKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Dictionary<CPBONNDALAG, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public CJKHPLLMGKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class BAGOABPKLOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CJKHPLLMGKM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public BAGOABPKLOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6A70B10", Offset = "0x6A6FB10", VA = "0x186A70B10")]
		internal void GMLPCMACJOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6A70A70", Offset = "0x6A6FA70", VA = "0x186A70A70")]
		internal bool FEBPOIDHJJE(int index, CPBONNDALAG member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class AEJDBMBJHBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public CJKHPLLMGKM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public AEJDBMBJHBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6A708D0", Offset = "0x6A6F8D0", VA = "0x186A708D0")]
		internal bool EEBDNMFHFJH(int index, CPBONNDALAG member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class MALCBLHNNBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Func<string, string> nameMutator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public List<object> serializeCustomFormatters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<object> deserializeCustomFormatters;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public MALCBLHNNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4154A80", Offset = "0x4153A80", VA = "0x184154A80")]
		internal string LNCECOMHCNO(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class MPCBLPBKOGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public MPCBLPBKOGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6A85CD0", Offset = "0x6A84CD0", VA = "0x186A85CD0")]
		internal bool KNIMPDMHGLK(CPBONNDALAG x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class LGEBCCCGFEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public MALCBLHNNBK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public LGEBCCCGFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6A85500", Offset = "0x6A84500", VA = "0x186A85500")]
		internal void DOMGGMHEDNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6A85510", Offset = "0x6A84510", VA = "0x186A85510")]
		internal bool GHPAAHOEPMK(int index, CPBONNDALAG member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class MJBJONHLOFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public MALCBLHNNBK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public MJBJONHLOFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6A85B50", Offset = "0x6A84B50", VA = "0x186A85B50")]
		internal bool DGMDCFHMKBE(int index, CPBONNDALAG member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class DMMGDHENJFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public DMMGDHENJFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6A74B00", Offset = "0x6A73B00", VA = "0x186A74B00")]
		internal Label DGNHOCCACBH(CPBONNDALAG _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class HBMICLGHGIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public PLBLJBJBIOD[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Func<int, CPBONNDALAG, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public ICJIEIMLFCF argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public ICJIEIMLFCF argResolver;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public HBMICLGHGIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6A80140", Offset = "0x6A7F140", VA = "0x186A80140")]
		internal PLBLJBJBIOD CAHGIIHFKEJ(CPBONNDALAG item)
		{
			return default(PLBLJBJBIOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class FNLEOPGHPIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public HBMICLGHGIP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public FNLEOPGHPIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6A7FA80", Offset = "0x6A7EA80", VA = "0x186A7FA80")]
		internal void JGBOKJKCEHG(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6A7F9E0", Offset = "0x6A7E9E0", VA = "0x186A7F9E0")]
		internal void EOFMOPBEOAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class EOBMFIBMLOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public CPBONNDALAG item;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public EOBMFIBMLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xBC2FB0", Offset = "0xBC1FB0", VA = "0x180BC2FB0")]
		internal bool KCCMGBKPBEC(PLBLJBJBIOD x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class GAKBAECFGGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public CPBONNDALAG item;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public GAKBAECFGGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xBC2FB0", Offset = "0xBC1FB0", VA = "0x180BC2FB0")]
		internal bool MDBFGOLMFIL(PLBLJBJBIOD x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly Regex PHEPIEKDCHG;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int DJGMHIGOMFD;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static HashSet<Type> OGEDCMCKGLM;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static HashSet<Type> JEOPBCLJHLK;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2648B50", Offset = "0x2647B50", VA = "0x182648B50")]
	public static object HBGADPIHIKH<T>(AMOOLLKAPMP KMIBMEEIFFK, NONFMIGJIBJ GLFIFCNDGMD, Func<string, string> CIEGPIHHFIE, bool GAAEKJCDNJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x26520B0", Offset = "0x26510B0", VA = "0x1826520B0")]
	public static object JJECMECAIJP<T>(NONFMIGJIBJ GLFIFCNDGMD, Func<string, string> CIEGPIHHFIE, bool GAAEKJCDNJO, bool LIHKNLHKDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A764E0", Offset = "0x6A754E0", VA = "0x186A764E0")]
	private static TypeInfo DOOHFAKCBID(AMOOLLKAPMP KMIBMEEIFFK, Type IKHOLAJCJOG, Func<string, string> CIEGPIHHFIE, bool GAAEKJCDNJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A7ADE0", Offset = "0x6A79DE0", VA = "0x186A7ADE0")]
	public static object PHKACNBJAPO(Type IKHOLAJCJOG, Func<string, string> CIEGPIHHFIE, bool GAAEKJCDNJO, bool LIHKNLHKDOI, bool JPOEHAIGGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A76F00", Offset = "0x6A75F00", VA = "0x186A76F00")]
	private static Dictionary<CPBONNDALAG, FieldInfo> EDMNOCIOPOH(TypeBuilder KKCAHMOCEHJ, HIPNGILKJDC LCONILKDJAG, ConstructorInfo EAIHOEJOEIA, FieldBuilder KEFCFOBPDMN, ILGenerator EDKMIGCJBGJ, bool GAAEKJCDNJO, bool FGAGLBFIALH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A75E00", Offset = "0x6A74E00", VA = "0x186A75E00")]
	private static Dictionary<CPBONNDALAG, FieldInfo> BHGGIKCJIIM(TypeBuilder KKCAHMOCEHJ, HIPNGILKJDC LCONILKDJAG, ILGenerator EDKMIGCJBGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A77630", Offset = "0x6A76630", VA = "0x186A77630")]
	private static void IOMPHFICNJL(Type IKHOLAJCJOG, HIPNGILKJDC LCONILKDJAG, ILGenerator EDKMIGCJBGJ, Action KFJOOMHMNCB, Func<int, CPBONNDALAG, bool> FIAEDILDAGO, bool GAAEKJCDNJO, bool FGAGLBFIALH, int HGIFBNEIGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A758C0", Offset = "0x6A748C0", VA = "0x186A758C0")]
	private static void APHDLFDAKEI(TypeInfo IKHOLAJCJOG, CPBONNDALAG FJOIPLDMLDO, ILGenerator EDKMIGCJBGJ, int GCDIELAOHNA, Func<int, CPBONNDALAG, bool> FIAEDILDAGO, ICJIEIMLFCF HKMKHKLNOHE, ICJIEIMLFCF ECIHGJCAHBB, ICJIEIMLFCF MDMNCMMKBBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6A79940", Offset = "0x6A78940", VA = "0x186A79940")]
	private static void OLKJKPIHBLG(Type IKHOLAJCJOG, HIPNGILKJDC LCONILKDJAG, ILGenerator EDKMIGCJBGJ, Func<int, CPBONNDALAG, bool> FIAEDILDAGO, bool ENJGGDONDLD, int HGIFBNEIGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A79350", Offset = "0x6A78350", VA = "0x186A79350")]
	private static void ODJOPCOIKCE(ILGenerator EDKMIGCJBGJ, PLBLJBJBIOD LCONILKDJAG, int GCDIELAOHNA, Func<int, CPBONNDALAG, bool> FIAEDILDAGO, ICJIEIMLFCF PCOFGFPALLL, ICJIEIMLFCF MDMNCMMKBBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6A74B30", Offset = "0x6A73B30", VA = "0x186A74B30")]
	private static LocalBuilder AKMBOHNNEME(ILGenerator EDKMIGCJBGJ, Type IKHOLAJCJOG, HIPNGILKJDC LCONILKDJAG, PLBLJBJBIOD[] LNFFDJJMINO, bool MLCEPEFIFHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A78C70", Offset = "0x6A77C70", VA = "0x186A78C70")]
	private static bool KEIHLFCLNLH(ConstructorInfo GIGIPJLLOHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6A797C0", Offset = "0x6A787C0", VA = "0x186A797C0")]
	private static bool OGLLFNJGOIB(Type IKHOLAJCJOG, [Out] Type KBPPJCDNAMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal delegate void NIPMEPBFHHP<T>(byte[][] KEFCFOBPDMN, object[] GNKHJAFEDIM, KCGIPMDKOPA HKMKHKLNOHE, T CFJDHAGGAJO, NONFMIGJIBJ GNHNCNIOALD);
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal delegate T LFBMLMBGFAI<T>(object[] GNKHJAFEDIM, OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ GNHNCNIOALD);
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class JKCLJMKGGLA<T> : GBPBACCCJGH<T>, BGMCLJEKLLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly byte[][] KEFCFOBPDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly object[] CGABCKBHKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly object[] GIFIPPCNIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly NIPMEPBFHHP<T> PIHOOGNJFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly LFBMLMBGFAI<T> OONNEDNHBGE;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1DA48C0", Offset = "0x1DA38C0", VA = "0x181DA48C0")]
	public JKCLJMKGGLA(byte[][] KEFCFOBPDMN, object[] CGABCKBHKBF, object[] GIFIPPCNIGH, NIPMEPBFHHP<T> PIHOOGNJFDG, LFBMLMBGFAI<T> OONNEDNHBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3B439E0", Offset = "0x3B429E0", VA = "0x183B439E0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, T CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3B438F0", Offset = "0x3B428F0", VA = "0x183B438F0", Slot = "5")]
	public T MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class IFGCFHNFOOK : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private static class HNPFLGLAKFM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x37F7310", Offset = "0x37F6310", VA = "0x1837F7310")]
		static HNPFLGLAKFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private IFGCFHNFOOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class OFHJGEFBLGF : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private static class NNBPAGDCOMC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3F9AE10", Offset = "0x3F99E10", VA = "0x183F9AE10")]
		static NNBPAGDCOMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private OFHJGEFBLGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal static class ECLHPHFGHFH
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	internal static readonly NONFMIGJIBJ[] JKBGPELMMCF;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal sealed class EPDBGNLICEL : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private static class GHFKEPAECEL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x374B860", Offset = "0x374A860", VA = "0x18374B860")]
		static GHFKEPAECEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private sealed class OIKBAHMCIEE : NONFMIGJIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private static class HMKDEBKDLIE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x37EDA30", Offset = "0x37ECA30", VA = "0x1837EDA30")]
			static HMKDEBKDLIE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly NONFMIGJIBJ GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private static readonly NONFMIGJIBJ[] EKNPFMOGGNJ;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private OIKBAHMCIEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
		public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly GBPBACCCJGH<object> KGKGHKCCONC;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private EPDBGNLICEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal sealed class JAACJLJPNAN : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private static class GHEPJOFOMEL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x37466A0", Offset = "0x37456A0", VA = "0x1837466A0")]
		static GHEPJOFOMEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private sealed class MECAJHOMAFD : NONFMIGJIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		private static class IGDNDHNFAMN<T>
		{
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x392E7A0", Offset = "0x392D7A0", VA = "0x18392E7A0")]
			static IGDNDHNFAMN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly NONFMIGJIBJ GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly NONFMIGJIBJ[] EKNPFMOGGNJ;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private MECAJHOMAFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
		public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly GBPBACCCJGH<object> KGKGHKCCONC;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private JAACJLJPNAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class LDFBLBLCMJH : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class PBLBJELPHPK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4135D20", Offset = "0x4134D20", VA = "0x184135D20")]
		static PBLBJELPHPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class BHKOGGOKOOF : NONFMIGJIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		private static class LMMPFBPMJGE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3CFA590", Offset = "0x3CF9590", VA = "0x183CFA590")]
			static LMMPFBPMJGE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly NONFMIGJIBJ GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly NONFMIGJIBJ[] EKNPFMOGGNJ;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private BHKOGGOKOOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
		public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly GBPBACCCJGH<object> KGKGHKCCONC;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private LDFBLBLCMJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class NNBJCALMLEE : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private static class FBPPKNJFJGM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3660C50", Offset = "0x365FC50", VA = "0x183660C50")]
		static FBPPKNJFJGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private sealed class LFMCNBPMOFJ : NONFMIGJIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		private static class DNAMMAFJEJJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x50D2580", Offset = "0x50D1580", VA = "0x1850D2580")]
			static DNAMMAFJEJJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly NONFMIGJIBJ GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly NONFMIGJIBJ[] EKNPFMOGGNJ;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private LFMCNBPMOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
		public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly GBPBACCCJGH<object> KGKGHKCCONC;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private NNBJCALMLEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class CHCHPENOAPA : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private static class AJOPLDLDDKI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x37AAAF0", Offset = "0x37A9AF0", VA = "0x1837AAAF0")]
		static AJOPLDLDDKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private sealed class MHNBFJPFDMK : NONFMIGJIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		private static class LNJHOHHNJNK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3D016D0", Offset = "0x3D006D0", VA = "0x183D016D0")]
			static LNJHOHHNJNK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly NONFMIGJIBJ GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly NONFMIGJIBJ[] EKNPFMOGGNJ;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private MHNBFJPFDMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
		public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly GBPBACCCJGH<object> KGKGHKCCONC;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private CHCHPENOAPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal sealed class FDFALKLNDPD : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	private static class ICKAHNGDGKO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x390D310", Offset = "0x390C310", VA = "0x18390D310")]
		static ICKAHNGDGKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class JMBACOHDNML : NONFMIGJIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		private static class HKAALDALLGL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x37DDD70", Offset = "0x37DCD70", VA = "0x1837DDD70")]
			static HKAALDALLGL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly NONFMIGJIBJ GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly NONFMIGJIBJ[] EKNPFMOGGNJ;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private JMBACOHDNML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
		public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly GBPBACCCJGH<object> KGKGHKCCONC;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private FDFALKLNDPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class CLOMDHKMANK : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private static class BAMPOJAGOHL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x478ACF0", Offset = "0x4789CF0", VA = "0x18478ACF0")]
		static BAMPOJAGOHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class BDJAIIJPOLK : NONFMIGJIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		private static class MELPAPEPDCK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3EC7CF0", Offset = "0x3EC6CF0", VA = "0x183EC7CF0")]
			static MELPAPEPDCK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly NONFMIGJIBJ GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly NONFMIGJIBJ[] EKNPFMOGGNJ;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private BDJAIIJPOLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
		public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly GBPBACCCJGH<object> KGKGHKCCONC;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private CLOMDHKMANK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class NPIPIIMNLAK : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private static class KPGBPHCGDGO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3C4EF00", Offset = "0x3C4DF00", VA = "0x183C4EF00")]
		static KPGBPHCGDGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class BHIAOIKMGLE : NONFMIGJIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		private static class JHCGAOOHAEC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3B3CBC0", Offset = "0x3B3BBC0", VA = "0x183B3CBC0")]
			static JHCGAOOHAEC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly NONFMIGJIBJ GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly NONFMIGJIBJ[] EKNPFMOGGNJ;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private BHIAOIKMGLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
		public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly GBPBACCCJGH<object> KGKGHKCCONC;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private NPIPIIMNLAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class FAPAGEAEDCF : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private static class EKDNHCEOFPA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3322900", Offset = "0x3321900", VA = "0x183322900")]
		static EKDNHCEOFPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private sealed class DCOHKJMDEBF : NONFMIGJIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		private static class HOACDCJBCCJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x37FD9B0", Offset = "0x37FC9B0", VA = "0x1837FD9B0")]
			static HOACDCJBCCJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly NONFMIGJIBJ GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly NONFMIGJIBJ[] EKNPFMOGGNJ;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private DCOHKJMDEBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
		public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly GBPBACCCJGH<object> KGKGHKCCONC;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private FAPAGEAEDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal sealed class AHEEAFHALEA : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private static class OCNABHBDKKE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x40693E0", Offset = "0x40683E0", VA = "0x1840693E0")]
		static OCNABHBDKKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private sealed class LBPBEMFPIEL : NONFMIGJIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		private static class EPEIDOCKLNP<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x33305C0", Offset = "0x332F5C0", VA = "0x1833305C0")]
			static EPEIDOCKLNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly NONFMIGJIBJ GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly NONFMIGJIBJ[] EKNPFMOGGNJ;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private LBPBEMFPIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
		public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly GBPBACCCJGH<object> KGKGHKCCONC;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private AHEEAFHALEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal sealed class LFIBBHDOKAH : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private static class NPNAOEGPDFL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3FA8340", Offset = "0x3FA7340", VA = "0x183FA8340")]
		static NPNAOEGPDFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private sealed class PNFIPFFMBBO : NONFMIGJIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private static class KNKKFEGGHBB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3C41200", Offset = "0x3C40200", VA = "0x183C41200")]
			static KNKKFEGGHBB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly NONFMIGJIBJ GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly NONFMIGJIBJ[] EKNPFMOGGNJ;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private PNFIPFFMBBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
		public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly GBPBACCCJGH<object> KGKGHKCCONC;

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private LFIBBHDOKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal sealed class DHLPGPMNEPN : NONFMIGJIBJ
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private static class GHLOPKACHJF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3755740", Offset = "0x3754740", VA = "0x183755740")]
		static GHLOPKACHJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private sealed class GCKEDPLCMLL : NONFMIGJIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		private static class MKMCAFELMGF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly GBPBACCCJGH<T> AGPJDGEEBPG;

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3ED4290", Offset = "0x3ED3290", VA = "0x183ED4290")]
			static MKMCAFELMGF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly NONFMIGJIBJ GDAKEGIGEFB;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly NONFMIGJIBJ[] EKNPFMOGGNJ;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private GCKEDPLCMLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
		public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly NONFMIGJIBJ GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly GBPBACCCJGH<object> KGKGHKCCONC;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	private DHLPGPMNEPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	public GBPBACCCJGH<T> HJFCLLBKDIF<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct LJLDMNBAIMP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public T[] FOBFGOMKEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public int DAPBPFEGNDN;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3CF1B40", Offset = "0x3CF0B40", VA = "0x183CF1B40")]
	public LJLDMNBAIMP(int HHLNLOJCFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3CF1820", Offset = "0x3CF0820", VA = "0x183CF1820")]
	public void EMJMPPLJJNE(T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3CF1AB0", Offset = "0x3CF0AB0", VA = "0x183CF1AB0")]
	public T[] HLEOFBNNKCK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class PEBIEAMCNCK : GCJNBCCAJAK<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public static readonly PEBIEAMCNCK KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6AA01B0", Offset = "0x6A9F1B0", VA = "0x186AA01B0")]
	public PEBIEAMCNCK(int MICILDGHLDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal class GCJNBCCAJAK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly int MICILDGHLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly object NDANAGBOEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int GCDIELAOHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private T[][] APAFBIPMBNF;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x373C9E0", Offset = "0x373B9E0", VA = "0x18373C9E0")]
	public GCJNBCCAJAK(int MICILDGHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x373C7A0", Offset = "0x373B7A0", VA = "0x18373C7A0")]
	public T[] NDICAHDMEGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x373C620", Offset = "0x373B620", VA = "0x18373C620")]
	public void MGNPPPMBAEB(T[] IJPOMPNGBEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class PAPICJCMCHK : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class PCFDMFLLPNI : IComparable<PCFDMFLLPNI>
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class NNPKLCKDAAP : IEnumerable<PCFDMFLLPNI>, IEnumerable, IEnumerator<PCFDMFLLPNI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private PCFDMFLLPNI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public PCFDMFLLPNI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private PCFDMFLLPNI System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x80FF60", Offset = "0x80EF60", VA = "0x18080FF60")]
			[DebuggerHidden]
			public NNPKLCKDAAP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6A9DE20", Offset = "0x6A9CE20", VA = "0x186A9DE20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6A9DF50", Offset = "0x6A9CF50", VA = "0x186A9DF50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x6A9DEA0", Offset = "0x6A9CEA0", VA = "0x186A9DEA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PCFDMFLLPNI> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x6A9DEA0", Offset = "0x6A9CEA0", VA = "0x186A9DEA0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class LPFJGKIBEHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public LPFJGKIBEHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x6A74B00", Offset = "0x6A73B00", VA = "0x186A74B00")]
			internal Label EEIPPOOEJFL(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x6A74B00", Offset = "0x6A73B00", VA = "0x186A74B00")]
			internal Label DNFKBMEICID(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private static readonly PCFDMFLLPNI[] MIGFMFKJDLO;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly ulong[] KHKNNHOPMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public ulong KHCGDDAFALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int ADACBBLDADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public string MKMPGNAJDAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private PCFDMFLLPNI[] BOJBFEGNJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private ulong[] ICLJEHPEJLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int FBDNKGNOEFD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool POHMGJOIDEO
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5381F20", Offset = "0x5380F20", VA = "0x185381F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6AA0050", Offset = "0x6A9F050", VA = "0x186AA0050")]
		public PCFDMFLLPNI(ulong IPAJBJLLPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A9EB40", Offset = "0x6A9DB40", VA = "0x186A9EB40")]
		public PCFDMFLLPNI EMJMPPLJJNE(ulong IPAJBJLLPIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6A9EAE0", Offset = "0x6A9DAE0", VA = "0x186A9EAE0")]
		public PCFDMFLLPNI EMJMPPLJJNE(ulong IPAJBJLLPIJ, int CFJDHAGGAJO, string MKMPGNAJDAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6A9FDA0", Offset = "0x6A9EDA0", VA = "0x186A9FDA0")]
		public PCFDMFLLPNI KOPJFOODNIO(byte[] GAAEMIDPEHO, int CNHEAECNOFO, int GGMAKGGENHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A9EA20", Offset = "0x6A9DA20", VA = "0x186A9EA20")]
		internal static int ADMHFFMEKCD(ulong[] IJPOMPNGBEF, int GCDIELAOHNA, int NAHHNFGPNAE, ulong CFJDHAGGAJO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A9EAB0", Offset = "0x6A9DAB0", VA = "0x186A9EAB0", Slot = "4")]
		public int CompareTo(PCFDMFLLPNI PJNBIAFGNNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A9FF20", Offset = "0x6A9EF20", VA = "0x186A9FF20")]
		[IteratorStateMachine(typeof(NNPKLCKDAAP))]
		public IEnumerable<PCFDMFLLPNI> PCINACAJMBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A9ED40", Offset = "0x6A9DD40", VA = "0x186A9ED40")]
		public void IDNBFOBGAKI(ILGenerator EDKMIGCJBGJ, LocalBuilder GAAEMIDPEHO, LocalBuilder GGMAKGGENHH, LocalBuilder IPAJBJLLPIJ, Action<KeyValuePair<string, int>> HKMANEFIPDM, Action LGFPEONHGDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A9F0C0", Offset = "0x6A9E0C0", VA = "0x186A9F0C0")]
		private static void IJKHNMMOKND(ILGenerator EDKMIGCJBGJ, LocalBuilder GAAEMIDPEHO, LocalBuilder GGMAKGGENHH, LocalBuilder IPAJBJLLPIJ, Action<KeyValuePair<string, int>> HKMANEFIPDM, Action LGFPEONHGDE, PCFDMFLLPNI[] BOJBFEGNJIL, int FBDNKGNOEFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class AGOHJADIOBN : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private IEnumerable<PCFDMFLLPNI> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public IEnumerable<PCFDMFLLPNI> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private IEnumerator<PCFDMFLLPNI> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private PCFDMFLLPNI <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xAE3DA0", Offset = "0xAE2DA0", VA = "0x180AE3DA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6A8DEA0", Offset = "0x6A8CEA0", VA = "0x186A8DEA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1CC8BF0", Offset = "0x1CC7BF0", VA = "0x181CC8BF0")]
		[DebuggerHidden]
		public AGOHJADIOBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6A8DEF0", Offset = "0x6A8CEF0", VA = "0x186A8DEF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D940", Offset = "0x6A8C940", VA = "0x186A8D940", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D8F0", Offset = "0x6A8C8F0", VA = "0x186A8D8F0")]
		private void GFMFCNEFFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D8A0", Offset = "0x6A8C8A0", VA = "0x186A8D8A0")]
		private void FIEDEKGMCFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6A8DE50", Offset = "0x6A8CE50", VA = "0x186A8DE50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6A8DDA0", Offset = "0x6A8CDA0", VA = "0x186A8DDA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6A8DDA0", Offset = "0x6A8CDA0", VA = "0x186A8DDA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly PCFDMFLLPNI HLMIIECLDOF;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E9A0", Offset = "0x6A9D9A0", VA = "0x186A9E9A0")]
	public PAPICJCMCHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E3B0", Offset = "0x6A9D3B0", VA = "0x186A9E3B0")]
	public void EMJMPPLJJNE(byte[] EOMNNFHDHII, int CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E550", Offset = "0x6A9D550", VA = "0x186A9E550")]
	public bool NPNAMBDPFKH(ArraySegment<byte> IPAJBJLLPIJ, [Out] int CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E910", Offset = "0x6A9D910", VA = "0x186A9E910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E630", Offset = "0x6A9D630", VA = "0x186A9E630")]
	private static void PGOPPAGJDGE(IEnumerable<PCFDMFLLPNI> BOJBFEGNJIL, StringBuilder CKFPFJILKGN, int CJOODCGGDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E4C0", Offset = "0x6A9D4C0", VA = "0x186A9E4C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E4C0", Offset = "0x6A9D4C0", VA = "0x186A9E4C0", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E330", Offset = "0x6A9D330", VA = "0x186A9E330")]
	[IteratorStateMachine(typeof(AGOHJADIOBN))]
	private static IEnumerable<KeyValuePair<string, int>> AFGKOJIGMON(IEnumerable<PCFDMFLLPNI> BOJBFEGNJIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E520", Offset = "0x6A9D520", VA = "0x186A9E520")]
	public void MLNCKKNJCIO(ILGenerator EDKMIGCJBGJ, LocalBuilder GAAEMIDPEHO, LocalBuilder GGMAKGGENHH, LocalBuilder IPAJBJLLPIJ, Action<KeyValuePair<string, int>> HKMANEFIPDM, Action LGFPEONHGDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class AONGNLALIJE
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static readonly MethodInfo CPDFGJNLPNN;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E3D0", Offset = "0x6A8D3D0", VA = "0x186A8E3D0")]
	public static ulong GELPDEDPFIB(byte[] EOMNNFHDHII, int CNHEAECNOFO, int GGMAKGGENHH)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class NFAHLPIFOPE
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DA30", Offset = "0x6A9CA30", VA = "0x186A9DA30")]
	public static void OCJNNEHLECK(byte[] EOMNNFHDHII, int CNHEAECNOFO, int DGBCPLJLLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D910", Offset = "0x6A9C910", VA = "0x186A9D910")]
	public static void GGOIMJMBGPC(byte[] IJPOMPNGBEF, int HNBEOBKGOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DB70", Offset = "0x6A9CB70", VA = "0x186A9DB70")]
	public static byte[] OLPHDJMKBGA(byte[] KDCCNGJCKFD, int HNBEOBKGOEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class MKGFPPLFCJN
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C760", Offset = "0x6A9B760", VA = "0x186A9C760")]
	public static bool NOHFBBIDGHB(byte[] EAHMJDPICDD, int JNLPPFPMAOA, int LBFKHHMBJDO, byte[] JOIGNPAABIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class HGKHCLJFLPJ<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private struct BPIJIAPEOHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public byte[] KHCGDDAFALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public T ADACBBLDADO;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x47F0110", Offset = "0x47EF110", VA = "0x1847F0110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class GBILHENPCJM : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public HGKHCLJFLPJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private BPIJIAPEOHE[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private BPIJIAPEOHE[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xAE3DA0", Offset = "0xAE2DA0", VA = "0x180AE3DA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x36D7850", Offset = "0x36D6850", VA = "0x1836D7850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
		[DebuggerHidden]
		public GBILHENPCJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3735CD0", Offset = "0x3734CD0", VA = "0x183735CD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3736CA0", Offset = "0x3735CA0", VA = "0x183736CA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly BPIJIAPEOHE[][] HBEJCADGFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly ulong NGEIFPHFLOO;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x37CE410", Offset = "0x37CD410", VA = "0x1837CE410")]
	public HGKHCLJFLPJ(int CCPFDJOINBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x37CE430", Offset = "0x37CD430", VA = "0x1837CE430")]
	public HGKHCLJFLPJ(int CCPFDJOINBO, float LBEHOMHIHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x37CA240", Offset = "0x37C9240", VA = "0x1837CA240")]
	public void EMJMPPLJJNE(byte[] IPAJBJLLPIJ, T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x37CD9C0", Offset = "0x37CC9C0", VA = "0x1837CD9C0")]
	private bool JOBBBFFPDKF(byte[] IPAJBJLLPIJ, T CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x37CAFF0", Offset = "0x37C9FF0", VA = "0x1837CAFF0")]
	public bool IJFOADKACJF(ArraySegment<byte> IPAJBJLLPIJ, [Out] T CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x37CA980", Offset = "0x37C9980", VA = "0x1837CA980")]
	private static ulong EPAHGKMPLHP(byte[] GDALFMOOMGE, int CNHEAECNOFO, int FBDNKGNOEFD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x37CAB80", Offset = "0x37C9B80", VA = "0x1837CAB80")]
	private static int HPEGFDDKGMN(int PIOGGIIDPIG, float LBEHOMHIHNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x37CA9D0", Offset = "0x37C99D0", VA = "0x1837CA9D0", Slot = "4")]
	[IteratorStateMachine(typeof(HGKHCLJFLPJ<>.GBILHENPCJM))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3684E30", Offset = "0x3683E30", VA = "0x183684E30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class DOFEBJOBNHI : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly OpCode[] FLIDFPJEANP;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly OpCode[] HAKHMCGLEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int LNEDPPMBEBG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool EJNPFMOOIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A95730", Offset = "0x6A94730", VA = "0x186A95730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A95780", Offset = "0x6A94780", VA = "0x186A95780")]
	static DOFEBJOBNHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6A959E0", Offset = "0x6A949E0", VA = "0x186A959E0")]
	public DOFEBJOBNHI(byte[] CAMGIOAJMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6A95630", Offset = "0x6A94630", VA = "0x186A95630")]
	public OpCode DEOGCPOEMKC()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal struct PHAFGJBDFDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public readonly Guid ADACBBLDADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public readonly byte DEJBLPPPDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public readonly byte CKAKIPODBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public readonly byte JMOBOOBMGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public readonly byte PGIDNJHHODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public readonly byte KHLGIJIAHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public readonly byte IOHJPEBAJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public readonly byte CEDOCMJBPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public readonly byte MHPDLJBGJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public readonly byte APFMEIJOFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public readonly byte MACFJIMFKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public readonly byte PMECIKHBHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly byte LHKHBNDPEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte ECOIBPOLFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte JOCIDMLJKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte DJMOFFICJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte PCJIEHHAMGM;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static byte[] EIGEFFPGCKI;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static byte[] AJJKOMPPEDB;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6AA28B0", Offset = "0x6AA18B0", VA = "0x186AA28B0")]
	public PHAFGJBDFDK(Guid CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6AA1160", Offset = "0x6AA0160", VA = "0x186AA1160")]
	public PHAFGJBDFDK(ArraySegment<byte> LAGCFGPHOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6AA0EB0", Offset = "0x6A9FEB0", VA = "0x186AA0EB0")]
	private static byte EBDBEELDJOK(byte[] EOMNNFHDHII, int DCKBCKHPLFG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6AA0F50", Offset = "0x6A9FF50", VA = "0x186AA0F50")]
	private static byte PGKOBOOKBCK(byte AMHEHNHOGFM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6AA0200", Offset = "0x6A9F200", VA = "0x186AA0200")]
	public void CCBGBBLBEMM(byte[] EOOJCJAHOCJ, int CNHEAECNOFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class HIKJLMBHHII
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6A974F0", Offset = "0x6A964F0", VA = "0x186A974F0")]
	public static bool CLEAHBKMEDJ(byte BKPEEMPJCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6A98590", Offset = "0x6A97590", VA = "0x186A98590")]
	public static bool LGCEMKCOMKO(byte BKPEEMPJCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6A975E0", Offset = "0x6A965E0", VA = "0x186A975E0")]
	public static sbyte ENKABHFHDHH(byte[] EOMNNFHDHII, int CNHEAECNOFO, [Out] int KLMPKHNMNID)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6A983B0", Offset = "0x6A973B0", VA = "0x186A983B0")]
	public static short JIKHGKEJAFJ(byte[] EOMNNFHDHII, int CNHEAECNOFO, [Out] int KLMPKHNMNID)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6A984A0", Offset = "0x6A974A0", VA = "0x186A984A0")]
	public static int LAJPEOBGCNB(byte[] EOMNNFHDHII, int CNHEAECNOFO, [Out] int KLMPKHNMNID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6A98D20", Offset = "0x6A97D20", VA = "0x186A98D20")]
	public static long PEGBGEIBBEO(byte[] EOMNNFHDHII, int CNHEAECNOFO, [Out] int KLMPKHNMNID)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6A97970", Offset = "0x6A96970", VA = "0x186A97970")]
	public static byte IBGKCHEGBIK(byte[] EOMNNFHDHII, int CNHEAECNOFO, [Out] int KLMPKHNMNID)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6A978F0", Offset = "0x6A968F0", VA = "0x186A978F0")]
	public static ushort HCGNAHMCLOG(byte[] EOMNNFHDHII, int CNHEAECNOFO, [Out] int KLMPKHNMNID)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6A98CA0", Offset = "0x6A97CA0", VA = "0x186A98CA0")]
	public static uint OCPHMHOELJK(byte[] EOMNNFHDHII, int CNHEAECNOFO, [Out] int KLMPKHNMNID)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6A973E0", Offset = "0x6A963E0", VA = "0x186A973E0")]
	public static ulong CIAGBPDBANK(byte[] EOMNNFHDHII, int CNHEAECNOFO, [Out] int KLMPKHNMNID)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6A98DC0", Offset = "0x6A97DC0", VA = "0x186A98DC0")]
	public static float PHIAONANKJD(byte[] EOMNNFHDHII, int CNHEAECNOFO, [Out] int KLMPKHNMNID)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6A97500", Offset = "0x6A96500", VA = "0x186A97500")]
	public static double DPFNCANGFNB(byte[] EOMNNFHDHII, int CNHEAECNOFO, [Out] int KLMPKHNMNID)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6A98600", Offset = "0x6A97600", VA = "0x186A98600")]
	public static int NHIEAODPHAK(byte[] EOOJCJAHOCJ, int CNHEAECNOFO, ulong CFJDHAGGAJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6A979F0", Offset = "0x6A969F0", VA = "0x186A979F0")]
	public static int IGLPFMBMJBJ(byte[] EOOJCJAHOCJ, int CNHEAECNOFO, long CFJDHAGGAJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6A976C0", Offset = "0x6A966C0", VA = "0x186A976C0")]
	public static bool GLIKNFHOAOP(byte[] EOMNNFHDHII, int CNHEAECNOFO, [Out] int KLMPKHNMNID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal static class DOECEJEOJJG
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class LHEDNMDBNKK : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x80FF60", Offset = "0x80EF60", VA = "0x18080FF60")]
		[DebuggerHidden]
		public LHEDNMDBNKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6A9C0B0", Offset = "0x6A9B0B0", VA = "0x186A9C0B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6A9BB70", Offset = "0x6A9AB70", VA = "0x186A9BB70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6A9BB20", Offset = "0x6A9AB20", VA = "0x186A9BB20")]
		private void GFMFCNEFFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6A9BAD0", Offset = "0x6A9AAD0", VA = "0x186A9BAD0")]
		private void FIEDEKGMCFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6A9C060", Offset = "0x6A9B060", VA = "0x186A9C060", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6A9BFA0", Offset = "0x6A9AFA0", VA = "0x186A9BFA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6A9BFA0", Offset = "0x6A9AFA0", VA = "0x186A9BFA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class KEHFHPGGHFB : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x80FF60", Offset = "0x80EF60", VA = "0x18080FF60")]
		[DebuggerHidden]
		public KEHFHPGGHFB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6A9B210", Offset = "0x6A9A210", VA = "0x186A9B210", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6A9ACD0", Offset = "0x6A99CD0", VA = "0x186A9ACD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6A9AC80", Offset = "0x6A99C80", VA = "0x186A9AC80")]
		private void GFMFCNEFFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6A9AC30", Offset = "0x6A99C30", VA = "0x186A9AC30")]
		private void FIEDEKGMCFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6A9B1C0", Offset = "0x6A9A1C0", VA = "0x186A9B1C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6A9B100", Offset = "0x6A9A100", VA = "0x186A9B100", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6A9B100", Offset = "0x6A9A100", VA = "0x186A9B100", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6A95200", Offset = "0x6A94200", VA = "0x186A95200")]
	public static bool BKHJBAHMDGO(this TypeInfo IKHOLAJCJOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6A95480", Offset = "0x6A94480", VA = "0x186A95480")]
	public static bool LCILBNGMEAB(this TypeInfo IKHOLAJCJOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6A955B0", Offset = "0x6A945B0", VA = "0x186A955B0")]
	public static IEnumerable<PropertyInfo> PKFPPHNNOLF(this Type IKHOLAJCJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6A953E0", Offset = "0x6A943E0", VA = "0x186A953E0")]
	[IteratorStateMachine(typeof(LHEDNMDBNKK))]
	private static IEnumerable<PropertyInfo> HOEEACPFLLN(Type IKHOLAJCJOG, HashSet<string> GBPIEBGFMMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6A95360", Offset = "0x6A94360", VA = "0x186A95360")]
	public static IEnumerable<FieldInfo> HBHKFOMNPOH(this Type IKHOLAJCJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6A952C0", Offset = "0x6A942C0", VA = "0x186A952C0")]
	[IteratorStateMachine(typeof(KEHFHPGGHFB))]
	private static IEnumerable<FieldInfo> EPNOJMKJBDE(Type IKHOLAJCJOG, HashSet<string> GBPIEBGFMMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class EFDFMEMOJKF
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public static readonly Encoding CIGLOBJBIGN;
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal static class IJIGPKILBOB
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
	public static string NLNGEPHJOCJ(string HHMGHNBINBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A7F0", Offset = "0x6A997F0", VA = "0x186A9A7F0")]
	public static string FDPGBJMECLD(string HHMGHNBINBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A8D0", Offset = "0x6A998D0", VA = "0x186A9A8D0")]
	public static string KGEKAOMAMFA(string HHMGHNBINBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class AOLGEKAGBEO<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class JAODDJFGCMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public Type KHCGDDAFALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public TValue ADACBBLDADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int DKEHHNDOBFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public JAODDJFGCMH GMLEKMDNCFA;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3AFBE90", Offset = "0x3AFAE90", VA = "0x183AFBE90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3AFBD40", Offset = "0x3AFAD40", VA = "0x183AFBD40")]
		private int BIBAPHNHGKH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public JAODDJFGCMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class AAIDGGKFBIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public AAIDGGKFBIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x844EC0", Offset = "0x843EC0", VA = "0x180844EC0")]
		internal TValue LMHBBKBENDB(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private JAODDJFGCMH[] HBEJCADGFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private int BEELDCKKFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly object AJHCEILPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly float LBEHOMHIHNF;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x38E0BA0", Offset = "0x38DFBA0", VA = "0x1838E0BA0")]
	public AOLGEKAGBEO(int CCPFDJOINBO = 4, float LBEHOMHIHNF = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x38DF6B0", Offset = "0x38DE6B0", VA = "0x1838DF6B0")]
	public bool FJICIMHALFB(Type IPAJBJLLPIJ, TValue CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x38DF670", Offset = "0x38DE670", VA = "0x1838DF670")]
	public bool FJICIMHALFB(Type IPAJBJLLPIJ, Func<Type, TValue> PJACHMFBJBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x38E0280", Offset = "0x38DF280", VA = "0x1838E0280")]
	private bool JOBBBFFPDKF(Type IPAJBJLLPIJ, Func<Type, TValue> PJACHMFBJBB, [Out] TValue LMGKLJJHAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x38DF860", Offset = "0x38DE860", VA = "0x1838DF860")]
	private bool HDEPPNCAEOF(JAODDJFGCMH[] HBEJCADGFHL, Type GMDDPHDHGFB, JAODDJFGCMH AHDHHLIAJHE, Func<Type, TValue> PJACHMFBJBB, [Out] TValue LMGKLJJHAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x38E0010", Offset = "0x38DF010", VA = "0x1838E0010")]
	public bool IJFOADKACJF(Type IPAJBJLLPIJ, [Out] TValue CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x38E0940", Offset = "0x38DF940", VA = "0x1838E0940")]
	public TValue KFEHOFHILDH(Type IPAJBJLLPIJ, Func<Type, TValue> PJACHMFBJBB)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x37CAB80", Offset = "0x37C9B80", VA = "0x1837CAB80")]
	private static int HPEGFDDKGMN(int PIOGGIIDPIG, float LBEHOMHIHNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x38DF830", Offset = "0x38DE830", VA = "0x1838DF830")]
	private static void GFLAFCLHNOD(JAODDJFGCMH OCDONGOMPGP, JAODDJFGCMH CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x38DF830", Offset = "0x38DE830", VA = "0x1838DF830")]
	private static void GFLAFCLHNOD(JAODDJFGCMH[] OCDONGOMPGP, JAODDJFGCMH[] CFJDHAGGAJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class AMOOLLKAPMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly AssemblyBuilder KIPIHPPJGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly ModuleBuilder OGGEKEOBADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly object NDANAGBOEBF;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E1C0", Offset = "0x6A8D1C0", VA = "0x186A8E1C0")]
	public TypeBuilder ELLNAPEDCBE(string GCMHJLFFDHO, TypeAttributes KKMFBDBKLLO, Type MMPNPJILHCD, Type[] EDFPHCJFLGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E2C0", Offset = "0x6A8D2C0", VA = "0x186A8E2C0")]
	public AMOOLLKAPMP(string FIKKJCBGKKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class LDBEDNAEGBF
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B520", Offset = "0x6A9A520", VA = "0x186A9B520")]
	private static MethodInfo FBAAELMMFPO(LambdaExpression MCGCOMABIHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2838CE0", Offset = "0x2837CE0", VA = "0x182838CE0")]
	public static MethodInfo CALMCDJCHBK<T>(Expression<Func<T>> MCGCOMABIHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2838CE0", Offset = "0x2837CE0", VA = "0x182838CE0")]
	public static MethodInfo CALMCDJCHBK<T, TR>(Expression<Func<T, TR>> MCGCOMABIHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2838CE0", Offset = "0x2837CE0", VA = "0x182838CE0")]
	public static MethodInfo CALMCDJCHBK<T>(Expression<Action<T>> MCGCOMABIHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x2838CE0", Offset = "0x2837CE0", VA = "0x182838CE0")]
	public static MethodInfo CALMCDJCHBK<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> MCGCOMABIHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2838CF0", Offset = "0x2837CF0", VA = "0x182838CF0")]
	private static MemberInfo ENGEOBCOAJI<T>(Expression<T> HLPKKPNOMHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2838C40", Offset = "0x2837C40", VA = "0x182838C40")]
	public static PropertyInfo BOFGDBIPJGC<T, TR>(Expression<Func<T, TR>> MCGCOMABIHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct ICJIEIMLFCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly int BFOKHFCOJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly bool MJHDNDMMJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly ILGenerator EDKMIGCJBGJ;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A540", Offset = "0x6A99540", VA = "0x186A9A540")]
	public ICJIEIMLFCF(ILGenerator EDKMIGCJBGJ, int BFOKHFCOJAP, bool MJHDNDMMJIG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A580", Offset = "0x6A99580", VA = "0x186A9A580")]
	public ICJIEIMLFCF(ILGenerator EDKMIGCJBGJ, int BFOKHFCOJAP, Type IKHOLAJCJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A440", Offset = "0x6A99440", VA = "0x186A9A440")]
	public void BPBDCBAAFBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal static class HFOHHKNOLJE
{
	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6A96300", Offset = "0x6A95300", VA = "0x186A96300")]
	public static void AAHBCLIKFBH(this ILGenerator EDKMIGCJBGJ, int GCDIELAOHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6A962C0", Offset = "0x6A952C0", VA = "0x186A962C0")]
	public static void AAHBCLIKFBH(this ILGenerator EDKMIGCJBGJ, LocalBuilder CIPNPFCNKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6A971B0", Offset = "0x6A961B0", VA = "0x186A971B0")]
	public static void PGNKHGLPECD(this ILGenerator EDKMIGCJBGJ, int GCDIELAOHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6A973A0", Offset = "0x6A963A0", VA = "0x186A973A0")]
	public static void PGNKHGLPECD(this ILGenerator EDKMIGCJBGJ, LocalBuilder CIPNPFCNKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6A96870", Offset = "0x6A95870", VA = "0x186A96870")]
	public static void EFICJBHOEJE(this ILGenerator EDKMIGCJBGJ, int GCDIELAOHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6A96770", Offset = "0x6A95770", VA = "0x186A96770")]
	public static void EFICJBHOEJE(this ILGenerator EDKMIGCJBGJ, LocalBuilder CIPNPFCNKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6A97010", Offset = "0x6A96010", VA = "0x186A97010")]
	public static void JBGENJJHPIM(this ILGenerator EDKMIGCJBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6A97000", Offset = "0x6A96000", VA = "0x186A97000")]
	public static void ILPEKAEFOGB(this ILGenerator EDKMIGCJBGJ, bool CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6A96950", Offset = "0x6A95950", VA = "0x186A96950")]
	public static void EJJFPFPNBEH(this ILGenerator EDKMIGCJBGJ, int CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6A96F20", Offset = "0x6A95F20", VA = "0x186A96F20")]
	public static void HLLIBLOHAGA(this ILGenerator EDKMIGCJBGJ, Type IKHOLAJCJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6A97110", Offset = "0x6A96110", VA = "0x186A97110")]
	public static void PFOMHIBEGBN(this ILGenerator EDKMIGCJBGJ, Type IKHOLAJCJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6A96580", Offset = "0x6A95580", VA = "0x186A96580")]
	public static void CPBCBONLAKN(this ILGenerator EDKMIGCJBGJ, int GCDIELAOHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6A96E10", Offset = "0x6A95E10", VA = "0x186A96E10")]
	public static void FGBIOMEEIGO(this ILGenerator EDKMIGCJBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6A96D30", Offset = "0x6A95D30", VA = "0x186A96D30")]
	public static void FBIAONGNJIF(this ILGenerator EDKMIGCJBGJ, int GCDIELAOHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6A97020", Offset = "0x6A96020", VA = "0x186A97020")]
	public static void KELPBEBGGDE(this ILGenerator EDKMIGCJBGJ, MethodInfo FGPKHHHEOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6A96E90", Offset = "0x6A95E90", VA = "0x186A96E90")]
	public static void FPPKLFIADMN(this ILGenerator EDKMIGCJBGJ, FieldInfo NKJNLBKELGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6A964F0", Offset = "0x6A954F0", VA = "0x186A964F0")]
	public static void BODJEPELDOM(this ILGenerator EDKMIGCJBGJ, ulong CFJDHAGGAJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal class CPBONNDALAG
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class FPJHGHJHPPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public FPJHGHJHPPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6A95E00", Offset = "0x6A94E00", VA = "0x186A95E00")]
		internal bool PEEMHFIKMGG(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private MethodInfo JDABCDMOMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private MethodInfo EHGLKEPOCEA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string JJGLPFPAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC250", Offset = "0x7BB250", VA = "0x1807BC250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string OPJHIGKPPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC240", Offset = "0x7BB240", VA = "0x1807BC240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DBCHCBFLNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6A921C0", Offset = "0x6A911C0", VA = "0x186A921C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ILDCEIPEODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC460", Offset = "0x7BB460", VA = "0x1807BC460")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC200", Offset = "0x7BB200", VA = "0x1807BC200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool EBKNILLKBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x935EB0", Offset = "0x934EB0", VA = "0x180935EB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9359F0", Offset = "0x9349F0", VA = "0x1809359F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type MJIJAFEKHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7BC220", Offset = "0x7BB220", VA = "0x1807BC220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7C21C0", Offset = "0x7C11C0", VA = "0x1807C21C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo IAPJOCIMPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7BD940", Offset = "0x7BC940", VA = "0x1807BD940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo KNCBBANCOFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7BC440", Offset = "0x7BB440", VA = "0x1807BC440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo NHLOMPNJGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7C3310", Offset = "0x7C2310", VA = "0x1807C3310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1D0", Offset = "0x7BB1D0", VA = "0x1807BC1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6A92750", Offset = "0x6A91750", VA = "0x186A92750")]
	protected CPBONNDALAG(Type IKHOLAJCJOG, string GCMHJLFFDHO, string CHMBPFKKPCP, bool HEEPPLFHOHP, bool LJNIFCMLEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6A92640", Offset = "0x6A91640", VA = "0x186A92640")]
	public CPBONNDALAG(FieldInfo LCONILKDJAG, string GCMHJLFFDHO, bool LIHKNLHKDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6A927D0", Offset = "0x6A917D0", VA = "0x186A927D0")]
	public CPBONNDALAG(PropertyInfo LCONILKDJAG, string GCMHJLFFDHO, bool LIHKNLHKDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6A924D0", Offset = "0x6A914D0", VA = "0x186A924D0")]
	private static MethodInfo HGOCKEPAGEK(MemberInfo LCONILKDJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x260D5F0", Offset = "0x260C5F0", VA = "0x18260D5F0")]
	public T FJCKJCLCCMP<T>(bool NPJOJBGGFKH) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x6A921D0", Offset = "0x6A911D0", VA = "0x186A921D0", Slot = "4")]
	public virtual void EPGJBEGCOPN(ILGenerator EDKMIGCJBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6A92350", Offset = "0x6A91350", VA = "0x186A92350", Slot = "5")]
	public virtual void FFHLAAIJAKK(ILGenerator EDKMIGCJBGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class HCHPOLIJILE : CPBONNDALAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly string FNCMDOKJIGI;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x6A961E0", Offset = "0x6A951E0", VA = "0x186A961E0")]
	public HCHPOLIJILE(string GCMHJLFFDHO, string FNCMDOKJIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x6A960E0", Offset = "0x6A950E0", VA = "0x186A960E0", Slot = "4")]
	public override void EPGJBEGCOPN(ILGenerator EDKMIGCJBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x6A96190", Offset = "0x6A95190", VA = "0x186A96190", Slot = "5")]
	public override void FFHLAAIJAKK(ILGenerator EDKMIGCJBGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class BEBBJPMELLP : CPBONNDALAG
{
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly MethodInfo PDLDGGKIGLG;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly MethodInfo KLCIMENMLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	internal ICJIEIMLFCF MCGPOOECHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	internal ICJIEIMLFCF ECIHGJCAHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	internal ICJIEIMLFCF MDMNCMMKBBH;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F9A0", Offset = "0x6A8E9A0", VA = "0x186A8F9A0")]
	public BEBBJPMELLP(string GCMHJLFFDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F1C0", Offset = "0x6A8E1C0", VA = "0x186A8F1C0", Slot = "4")]
	public override void EPGJBEGCOPN(ILGenerator EDKMIGCJBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F280", Offset = "0x6A8E280", VA = "0x186A8F280", Slot = "5")]
	public override void FFHLAAIJAKK(ILGenerator EDKMIGCJBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F2D0", Offset = "0x6A8E2D0", VA = "0x186A8F2D0")]
	public void NBKDCNEOEHM(ILGenerator EDKMIGCJBGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class HIPNGILKJDC
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type MJIJAFEKHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC250", Offset = "0x7BB250", VA = "0x1807BC250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IPNIIKCAAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x835210", Offset = "0x834210", VA = "0x180835210")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7BFAC0", Offset = "0x7BEAC0", VA = "0x1807BFAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool MMKGFPJNCNF
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x835220", Offset = "0x834220", VA = "0x180835220")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x934220", Offset = "0x933220", VA = "0x180934220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo OEAKPNODPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1D0", Offset = "0x7BC1D0", VA = "0x1807BD1D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public CPBONNDALAG[] LBGEKKMGKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7BC220", Offset = "0x7BB220", VA = "0x1807BC220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7C21C0", Offset = "0x7C11C0", VA = "0x1807C21C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public CPBONNDALAG[] LLPNFDOEEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7BD940", Offset = "0x7BC940", VA = "0x1807BD940")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6A98F80", Offset = "0x6A97F80", VA = "0x186A98F80")]
	public HIPNGILKJDC(Type IKHOLAJCJOG, Func<string, string> LOBMLFAKKDD, bool LIHKNLHKDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6A98EA0", Offset = "0x6A97EA0", VA = "0x186A98EA0")]
	private static bool JGEHGINAKKB(IEnumerator<ConstructorInfo> JJCCJGFGHND, ConstructorInfo LPCPJELHHCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct IHNIECFGMED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public ulong OMEEAADDEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public int LPBJFENAMEF;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1E14DF0", Offset = "0x1E13DF0", VA = "0x181E14DF0")]
	public IHNIECFGMED(ulong OKGIFEAIDAP, int BPGCPNIMDBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A740", Offset = "0x6A99740", VA = "0x186A9A740")]
	public void LAOADMHLMPJ(IHNIECFGMED PJNBIAFGNNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A730", Offset = "0x6A99730", VA = "0x186A9A730")]
	public static IHNIECFGMED KJMFKOOBICI(IHNIECFGMED ABLMDKMDGNE, IHNIECFGMED AMHEHNHOGFM)
	{
		return default(IHNIECFGMED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A6A0", Offset = "0x6A996A0", VA = "0x186A9A6A0")]
	public void KIPAMKFFCIM(IHNIECFGMED PJNBIAFGNNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A750", Offset = "0x6A99750", VA = "0x186A9A750")]
	public static IHNIECFGMED LBAGNJGBAJN(IHNIECFGMED ABLMDKMDGNE, IHNIECFGMED AMHEHNHOGFM)
	{
		return default(IHNIECFGMED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A660", Offset = "0x6A99660", VA = "0x186A9A660")]
	public void CJGPLCBEGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A610", Offset = "0x6A99610", VA = "0x186A9A610")]
	public static IHNIECFGMED CJGPLCBEGPM(IHNIECFGMED ABLMDKMDGNE)
	{
		return default(IHNIECFGMED);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal struct DKAJCHNGDJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public byte[] EOOJCJAHOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public int CNHEAECNOFO;

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x18A4B00", Offset = "0x18A3B00", VA = "0x1818A4B00")]
	public DKAJCHNGDJB(byte[] EOOJCJAHOCJ, int PKDBIHBDKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6A83280", Offset = "0x6A82280", VA = "0x186A83280")]
	public void LHJOCPPBDIC(byte BBECBJENJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6A92E00", Offset = "0x6A91E00", VA = "0x186A92E00")]
	public void JABCDLFGNLH(byte[] BBECBJENJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x6A92CE0", Offset = "0x6A91CE0", VA = "0x186A92CE0")]
	public void FMDPIJEEKCB(byte[] BBECBJENJIE, int NAHHNFGPNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6A92D60", Offset = "0x6A91D60", VA = "0x186A92D60")]
	public void FMDPIJEEKCB(byte[] BBECBJENJIE, int CGJCOMADABC, int NAHHNFGPNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6A92F80", Offset = "0x6A91F80", VA = "0x186A92F80")]
	public void NLGJFDHBECJ(byte BKPEEMPJCKD, int FBDNKGNOEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6A92E80", Offset = "0x6A91E80", VA = "0x186A92E80")]
	public void JHJIFBGCIGI(string BBECBJENJIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal static class DLGJKMMKDCF
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private enum HOPIGCOMDIA
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private enum PIPCDEEOHKN
	{
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private enum MPNFJEDPGEA
	{
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[ThreadStatic]
	private static byte[] GDNOHHJFABI;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[ThreadStatic]
	private static byte[] FNLEOPEMBAC;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly byte[] PFOIFLPEIDI;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly byte[] NGIMPDOHING;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly MPNFJEDPGEA CNBPPMAPJEL;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly char DJDOFBOFNBK;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly int POJGDPFIMFP;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly int IDAHNLMHFEJ;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly uint[] LAFMIHBCBOD;

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6A938B0", Offset = "0x6A928B0", VA = "0x186A938B0")]
	private static byte[] DNLGHCMMMCC(int BEELDCKKFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A93D70", Offset = "0x6A92D70", VA = "0x186A93D70")]
	private static byte[] FKBGCLEKINO(int BEELDCKKFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A93120", Offset = "0x6A92120", VA = "0x186A93120")]
	public static int AEICPDLMOAD(byte[] EOOJCJAHOCJ, int CNHEAECNOFO, float CFJDHAGGAJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A93000", Offset = "0x6A92000", VA = "0x186A93000")]
	public static int AEICPDLMOAD(byte[] EOOJCJAHOCJ, int CNHEAECNOFO, double CFJDHAGGAJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A947B0", Offset = "0x6A937B0", VA = "0x186A947B0")]
	private static bool MHBIKKOCDHL(byte[] EOOJCJAHOCJ, int NAHHNFGPNAE, ulong FEBIFBOCOED, ulong EGMMIDHONAD, ulong GGMAKGGENHH, ulong LHOJNLGKHBG, ulong BEGIMHGHAIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A948A0", Offset = "0x6A938A0", VA = "0x186A948A0")]
	private static void OJACJPIMEJL(uint FJMKENKLHGI, int KAMLKAKKDOA, [Out] uint OEDPALKACOO, [Out] int NGODINAFPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A93980", Offset = "0x6A92980", VA = "0x186A93980")]
	private static bool DPPHLEOHLLK(IHNIECFGMED MGIKODCNGJB, IHNIECFGMED HCFPNEAOOMC, IHNIECFGMED IGGFGIHPFJL, byte[] EOOJCJAHOCJ, [Out] int NAHHNFGPNAE, [Out] int HMILBOKOPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A93E50", Offset = "0x6A92E50", VA = "0x186A93E50")]
	private static bool GONGELMALIL(double IFEDOEKJDOP, HOPIGCOMDIA AHPNAMMDGCF, byte[] EOOJCJAHOCJ, [Out] int NAHHNFGPNAE, [Out] int KCEEADMKKDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A937A0", Offset = "0x6A927A0", VA = "0x186A937A0")]
	private static bool DEBMIFLMCDK(double IFEDOEKJDOP, HOPIGCOMDIA AHPNAMMDGCF, byte[] EOOJCJAHOCJ, [Out] int NAHHNFGPNAE, [Out] int MKABKEPLGOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A93240", Offset = "0x6A92240", VA = "0x186A93240")]
	private static bool BDLFDHFJOPG(double CFJDHAGGAJO, DKAJCHNGDJB JLNJIAGOPBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A942D0", Offset = "0x6A932D0", VA = "0x186A942D0")]
	private static bool MCIANPDBFKN(double CFJDHAGGAJO, DKAJCHNGDJB JLNJIAGOPBL, PIPCDEEOHKN AHPNAMMDGCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A93410", Offset = "0x6A92410", VA = "0x186A93410")]
	private static void CJIGOFJPIJM(byte[] CKJDCFGMMFI, int NAHHNFGPNAE, int MKABKEPLGOE, int JOFPEMHCCLO, DKAJCHNGDJB JLNJIAGOPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A94990", Offset = "0x6A93990", VA = "0x186A94990")]
	private static void PCOPBBMIIBC(byte[] CKJDCFGMMFI, int NAHHNFGPNAE, int BPGCPNIMDBJ, DKAJCHNGDJB JLNJIAGOPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A94DC0", Offset = "0x6A93DC0", VA = "0x186A94DC0")]
	private static bool PJEGCNEALKG(double IFEDOEKJDOP, PIPCDEEOHKN AHPNAMMDGCF, int ANKEPAHLJHP, byte[] GLCNHOPAEMN, [Out] bool BCFPHPNPPEH, [Out] int NAHHNFGPNAE, [Out] int HLCDMCNCOBO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal struct CEEMICOLNOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public double MCPFEGADMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public ulong GGMNMFPMIJE;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct KNNEOFEMCJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public float OMEEAADDEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public uint JEIGMFIHDFP;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal struct CBLHPNPILGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private ulong JGCHGLFAKIH;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A91D70", Offset = "0x6A90D70", VA = "0x186A91D70")]
	public CBLHPNPILGH(double MCPFEGADMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A91D80", Offset = "0x6A90D80", VA = "0x186A91D80")]
	public CBLHPNPILGH(IHNIECFGMED MCPFEGADMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A91AE0", Offset = "0x6A90AE0", VA = "0x186A91AE0")]
	public IHNIECFGMED HJFOJIDAJGG()
	{
		return default(IHNIECFGMED);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A91BF0", Offset = "0x6A90BF0", VA = "0x186A91BF0")]
	public IHNIECFGMED LKKHLHNCKPF()
	{
		return default(IHNIECFGMED);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x889EF0", Offset = "0x888EF0", VA = "0x180889EF0")]
	public ulong LEPCNKKIPGP()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A917E0", Offset = "0x6A907E0", VA = "0x186A917E0")]
	public double BBALLKNALMF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A91CC0", Offset = "0x6A90CC0", VA = "0x186A91CC0")]
	public double PHLFKCEGGOK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A91860", Offset = "0x6A90860", VA = "0x186A91860")]
	public int BJFFOKMNLCI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A91BA0", Offset = "0x6A90BA0", VA = "0x186A91BA0")]
	public ulong JCHPJOLCCPF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A91890", Offset = "0x6A90890", VA = "0x186A91890")]
	public bool BNKFNFFAOHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A91BD0", Offset = "0x6A90BD0", VA = "0x186A91BD0")]
	public bool JFNBFFPJKHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A91A90", Offset = "0x6A90A90", VA = "0x186A91A90")]
	public bool FMEBJAAMOAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A91B50", Offset = "0x6A90B50", VA = "0x186A91B50")]
	public bool IOHPAJBJJBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A91AC0", Offset = "0x6A90AC0", VA = "0x186A91AC0")]
	public int HGKLAPOHKAM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A918B0", Offset = "0x6A908B0", VA = "0x186A918B0")]
	public void CEPOEDJNPBE([Out] IHNIECFGMED KEKBILJNBLP, [Out] IHNIECFGMED PGAPIFHLLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A91C70", Offset = "0x6A90C70", VA = "0x186A91C70")]
	public bool NDEEAAKNHMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2D1E810", Offset = "0x2D1D810", VA = "0x182D1E810")]
	public double CFJDHAGGAJO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A91B80", Offset = "0x6A90B80", VA = "0x186A91B80")]
	public static int IPJNOHMAOCM(int IFIDAHKOCON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A91D60", Offset = "0x6A90D60", VA = "0x186A91D60")]
	public static double PPOAGKEFEKH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x6A91A00", Offset = "0x6A90A00", VA = "0x186A91A00")]
	public static ulong EOPPCFGEHKK(IHNIECFGMED MAOCBGOLHFD)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct NPEEEJLNFIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private uint FAHMMEPFCHI;

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F53A20", Offset = "0x1F52A20", VA = "0x181F53A20")]
	public NPEEEJLNFIC(float OMEEAADDEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E100", Offset = "0x6A9D100", VA = "0x186A9E100")]
	public IHNIECFGMED HJFOJIDAJGG()
	{
		return default(IHNIECFGMED);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x90D4A0", Offset = "0x90C4A0", VA = "0x18090D4A0")]
	public uint DDDHBKOHNBP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DFA0", Offset = "0x6A9CFA0", VA = "0x186A9DFA0")]
	public int BJFFOKMNLCI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E150", Offset = "0x6A9D150", VA = "0x186A9E150")]
	public uint JCHPJOLCCPF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DFC0", Offset = "0x6A9CFC0", VA = "0x186A9DFC0")]
	public bool BNKFNFFAOHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DFD0", Offset = "0x6A9CFD0", VA = "0x186A9DFD0")]
	public void CEPOEDJNPBE([Out] IHNIECFGMED KEKBILJNBLP, [Out] IHNIECFGMED PGAPIFHLLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E170", Offset = "0x6A9D170", VA = "0x186A9E170")]
	public bool NDEEAAKNHMD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct KIBNHCGLBLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public readonly ulong OKGIFEAIDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public readonly short INPPGIAIDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public readonly short KCEEADMKKDN;

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A9B340", Offset = "0x6A9A340", VA = "0x186A9B340")]
	public KIBNHCGLBLD(ulong OKGIFEAIDAP, short INPPGIAIDJL, short KCEEADMKKDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal static class NAHIDJDJKIG
{
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly KIBNHCGLBLD[] DNKABMHLGCO;

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C8A0", Offset = "0x6A9B8A0", VA = "0x186A9C8A0")]
	public static void KMEBDCCEEKG(int JDEGPFDDDJK, int MIPFJEDAINA, [Out] IHNIECFGMED OEDPALKACOO, [Out] int KCEEADMKKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C7D0", Offset = "0x6A9B7D0", VA = "0x186A9C7D0")]
	public static void CBBEEIGLCEJ(int MADCLEDAKLA, [Out] IHNIECFGMED OEDPALKACOO, [Out] int DOHLAFKOANH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[DefaultMember("Item")]
internal struct CDCIDIEJGFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public readonly byte[] EOMNNFHDHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public readonly int CGJCOMADABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public readonly int KGCLAPBEIJN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte EIFMNNJBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6A91E80", Offset = "0x6A90E80", VA = "0x186A91E80")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3925150", Offset = "0x3924150", VA = "0x183925150")]
	public CDCIDIEJGFB(byte[] EOMNNFHDHII, int CGJCOMADABC, int NAHHNFGPNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F892F0", Offset = "0x1F882F0", VA = "0x181F892F0")]
	public int NAHHNFGPNAE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A91E20", Offset = "0x6A90E20", VA = "0x186A91E20")]
	public CDCIDIEJGFB ENCEEIGLIOI(int KDHDAOEHKNF, int IIGDCCOFNDC)
	{
		return default(CDCIDIEJGFB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal static class ACJGBONBFKN
{
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[ThreadStatic]
	private static byte[] NJOGBCLDMNM;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static readonly double[] EJCMLGOIOEE;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly int EPMOJAGCGMA;

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C270", Offset = "0x6A8B270", VA = "0x186A8C270")]
	private static byte[] BFCLLMEIJNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C840", Offset = "0x6A8B840", VA = "0x186A8C840")]
	private static CDCIDIEJGFB IFMJJEHBFIL(CDCIDIEJGFB EOOJCJAHOCJ)
	{
		return default(CDCIDIEJGFB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C760", Offset = "0x6A8B760", VA = "0x186A8C760")]
	private static CDCIDIEJGFB HHEALMGEGBI(CDCIDIEJGFB EOOJCJAHOCJ)
	{
		return default(CDCIDIEJGFB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C1E0", Offset = "0x6A8B1E0", VA = "0x186A8C1E0")]
	private static void AHKHDPHKKMB(CDCIDIEJGFB EOOJCJAHOCJ, int BPGCPNIMDBJ, byte[] ICNFPJLDIFO, [Out] int MDHLHMMGGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C470", Offset = "0x6A8B470", VA = "0x186A8C470")]
	private static void GOIIEOHCMKM(CDCIDIEJGFB EOOJCJAHOCJ, int BPGCPNIMDBJ, byte[] KGBKINDKHJF, int BPMCDHDMFMB, [Out] CDCIDIEJGFB CBNENLEKMPH, [Out] int EPOFEADPHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D750", Offset = "0x6A8C750", VA = "0x186A8D750")]
	private static ulong PFAPAKOLLAG(CDCIDIEJGFB EOOJCJAHOCJ, [Out] int EDGGBKECCOG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A8CFC0", Offset = "0x6A8BFC0", VA = "0x186A8CFC0")]
	private static void LOAHHOMFHKF(CDCIDIEJGFB EOOJCJAHOCJ, [Out] IHNIECFGMED HEOGODCLBDD, [Out] int FIEJPOMHKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A8CBF0", Offset = "0x6A8BBF0", VA = "0x186A8CBF0")]
	private static bool LHDNMOGFPDK(CDCIDIEJGFB CBNENLEKMPH, int BPGCPNIMDBJ, [Out] double HEOGODCLBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C040", Offset = "0x6A8B040", VA = "0x186A8C040")]
	private static IHNIECFGMED AFFIJNMCFCG(int BPGCPNIMDBJ)
	{
		return default(IHNIECFGMED);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D100", Offset = "0x6A8C100", VA = "0x186A8D100")]
	private static bool NKMFEIHNINB(CDCIDIEJGFB EOOJCJAHOCJ, int BPGCPNIMDBJ, [Out] double HEOGODCLBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A8BF20", Offset = "0x6A8AF20", VA = "0x186A8BF20")]
	private static bool AEBGBFFLGKM(CDCIDIEJGFB CBNENLEKMPH, int BPGCPNIMDBJ, [Out] double HHEHLIPKGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C350", Offset = "0x6A8B350", VA = "0x186A8C350")]
	public static double? BHHJGJJLBOP(CDCIDIEJGFB EOOJCJAHOCJ, int BPGCPNIMDBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C920", Offset = "0x6A8B920", VA = "0x186A8C920")]
	public static float? LEKEKPHHHHG(CDCIDIEJGFB EOOJCJAHOCJ, int BPGCPNIMDBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct LKPHKILPNFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private byte[] EOOJCJAHOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private int CNHEAECNOFO;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte ADACBBLDADO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6A9C350", Offset = "0x6A9B350", VA = "0x186A9C350")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x18A4B00", Offset = "0x18A3B00", VA = "0x1818A4B00")]
	public LKPHKILPNFF(byte[] EOOJCJAHOCJ, int CNHEAECNOFO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C380", Offset = "0x6A9B380", VA = "0x186A9C380")]
	public static LKPHKILPNFF OJBFJFADHBG(LKPHKILPNFF AOFEPADBPDL)
	{
		return default(LKPHKILPNFF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C1E0", Offset = "0x6A9B1E0", VA = "0x186A9C1E0")]
	public static LKPHKILPNFF BGAMHHCLDBC(LKPHKILPNFF AOFEPADBPDL, int NAHHNFGPNAE)
	{
		return default(LKPHKILPNFF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C340", Offset = "0x6A9B340", VA = "0x186A9C340")]
	public static int NFCDBIJILIM(LKPHKILPNFF JAIIDLBPFND, LKPHKILPNFF ECFHNKKEKBJ)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C2D0", Offset = "0x6A9B2D0", VA = "0x186A9C2D0")]
	public static bool INAKJEGDKIC(LKPHKILPNFF JAIIDLBPFND, LKPHKILPNFF ECFHNKKEKBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C2C0", Offset = "0x6A9B2C0", VA = "0x186A9C2C0")]
	public static bool HNKADOHNPFO(LKPHKILPNFF JAIIDLBPFND, LKPHKILPNFF ECFHNKKEKBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C2E0", Offset = "0x6A9B2E0", VA = "0x186A9C2E0")]
	public static bool INAKJEGDKIC(LKPHKILPNFF JAIIDLBPFND, char ECFHNKKEKBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C290", Offset = "0x6A9B290", VA = "0x186A9C290")]
	public static bool HNKADOHNPFO(LKPHKILPNFF JAIIDLBPFND, char ECFHNKKEKBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C290", Offset = "0x6A9B290", VA = "0x186A9C290")]
	public static bool HNKADOHNPFO(LKPHKILPNFF JAIIDLBPFND, byte ECFHNKKEKBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C390", Offset = "0x6A9B390", VA = "0x186A9C390")]
	public static bool PDGHAJEKOKN(LKPHKILPNFF JAIIDLBPFND, char ECFHNKKEKBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C260", Offset = "0x6A9B260", VA = "0x186A9C260")]
	public static bool HIAAEFJHKDC(LKPHKILPNFF JAIIDLBPFND, char ECFHNKKEKBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C230", Offset = "0x6A9B230", VA = "0x186A9C230")]
	public static bool BHLEPIFAEDH(LKPHKILPNFF JAIIDLBPFND, char ECFHNKKEKBJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C310", Offset = "0x6A9B310", VA = "0x186A9C310")]
	public static bool KNBHDOAADBF(LKPHKILPNFF JAIIDLBPFND, char ECFHNKKEKBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class BIMGBDHBNIN
{
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[ThreadStatic]
	private static byte[] GCGNNFEGMGJ;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[ThreadStatic]
	private static byte[] ELBBNCGPNMK;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly byte[] PFOIFLPEIDI;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly byte[] NGIMPDOHING;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly byte[] GEIECGIKACI;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly int NFLCNHPFOAA;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ushort[] OONLOOGLAJP;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly int KHDNBDAEGPL;

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FF90", Offset = "0x6A8EF90", VA = "0x186A8FF90")]
	private static byte[] HOHNAHAPBBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FE00", Offset = "0x6A8EE00", VA = "0x186A8FE00")]
	private static byte[] DIOJLFLJBIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FEE0", Offset = "0x6A8EEE0", VA = "0x186A8FEE0")]
	public static double HNHFHJILODH(byte[] EOOJCJAHOCJ, int CNHEAECNOFO, [Out] int KLMPKHNMNID)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6A900C0", Offset = "0x6A8F0C0", VA = "0x186A900C0")]
	public static float KBJDCMGCBOO(byte[] EOOJCJAHOCJ, int CNHEAECNOFO, [Out] int KLMPKHNMNID)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6A913F0", Offset = "0x6A903F0", VA = "0x186A913F0")]
	private static bool ONNPAOADNDB(int GDALFMOOMGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6A90170", Offset = "0x6A8F170", VA = "0x186A90170")]
	private static bool KMHPIFJABLE(LKPHKILPNFF GMAICFHLBBK, LKPHKILPNFF KOKNIBHCDLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A91300", Offset = "0x6A90300", VA = "0x186A91300")]
	private static bool MJCLGGEAFOB(LKPHKILPNFF GMAICFHLBBK, LKPHKILPNFF KOKNIBHCDLN, byte[] IAOONIFHIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A90070", Offset = "0x6A8F070", VA = "0x186A90070")]
	private static bool JBFLEPAMCMF(LKPHKILPNFF APHNJDMDEJD, byte[] BBECBJENJIE, int CNHEAECNOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6A913D0", Offset = "0x6A903D0", VA = "0x186A913D0")]
	private static double OJPOHCKJKHD(bool BCFPHPNPPEH)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6A90360", Offset = "0x6A8F360", VA = "0x186A90360")]
	private static double MHGIKENEJLB(LKPHKILPNFF IIBDJBFNFJM, int NAHHNFGPNAE, bool ENKCJHBFDOJ, [Out] int NFLCBFDCEFH)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class JAAHCLDFIMP<T> : GBPBACCCJGH<T[]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly GCJNBCCAJAK<T> GKPPABDADGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly JONLHIEOKLA BPPKBEFPKHP;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x367CA10", Offset = "0x367BA10", VA = "0x18367CA10")]
	public JAAHCLDFIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
	public JAAHCLDFIMP(JONLHIEOKLA BPPKBEFPKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x3AF93D0", Offset = "0x3AF83D0", VA = "0x183AF93D0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, T[] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9000", Offset = "0x3AF8000", VA = "0x183AF9000", Slot = "5")]
	public T[] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public class PHLMHDBKBIO<T> : GBPBACCCJGH<ArraySegment<T>>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly GCJNBCCAJAK<T> GKPPABDADGC;

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x414A630", Offset = "0x4149630", VA = "0x18414A630", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, ArraySegment<T> CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x414A210", Offset = "0x4149210", VA = "0x18414A210", Slot = "5")]
	public ArraySegment<T> MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public class AABDCDBMKJK<T> : GBPBACCCJGH<List<T>>, BGMCLJEKLLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly JONLHIEOKLA BPPKBEFPKHP;

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x367CA10", Offset = "0x367BA10", VA = "0x18367CA10")]
	public AABDCDBMKJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
	public AABDCDBMKJK(JONLHIEOKLA BPPKBEFPKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x370A530", Offset = "0x3709530", VA = "0x18370A530", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, List<T> CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3708520", Offset = "0x3707520", VA = "0x183708520", Slot = "5")]
	public List<T> MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class PJFPKHMGPPI<TElement, TIntermediate, TEnumerator, TCollection> : GBPBACCCJGH<TCollection>, BGMCLJEKLLA where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x414DA70", Offset = "0x414CA70", VA = "0x18414DA70", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, TCollection CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x414D370", Offset = "0x414C370", VA = "0x18414D370", Slot = "5")]
	public TCollection MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator HEPJLIAACBF(TCollection HLPKKPNOMHG);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate OOGKEDOOOJC();

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void EMJMPPLJJNE(TIntermediate DKPNELDIPIB, int GCDIELAOHNA, TElement CFJDHAGGAJO);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection NCCDMBKHFGE(TIntermediate OJBIELCKBAD);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	protected PJFPKHMGPPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public abstract class MHJPLPOAPAC<TElement, TIntermediate, TCollection> : PJFPKHMGPPI<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x37A0440", Offset = "0x379F440", VA = "0x1837A0440", Slot = "6")]
	protected override IEnumerator<TElement> HEPJLIAACBF(TCollection HLPKKPNOMHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x32EF420", Offset = "0x32EE420", VA = "0x1832EF420")]
	protected MHJPLPOAPAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public abstract class IACHPFFJFJG<TElement, TCollection> : MHJPLPOAPAC<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8BE0A0", Offset = "0x8BD0A0", VA = "0x1808BE0A0", Slot = "9")]
	protected sealed override TCollection NCCDMBKHFGE(TCollection OJBIELCKBAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class EGGMFGEEALJ<TElement, TCollection> : IACHPFFJFJG<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x33173F0", Offset = "0x33163F0", VA = "0x1833173F0", Slot = "7")]
	protected override TCollection OOGKEDOOOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3317390", Offset = "0x3316390", VA = "0x183317390", Slot = "8")]
	protected override void EMJMPPLJJNE(TCollection DKPNELDIPIB, int GCDIELAOHNA, TElement CFJDHAGGAJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class KICNPOICMIA<T> : PJFPKHMGPPI<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3C21600", Offset = "0x3C20600", VA = "0x183C21600", Slot = "8")]
	protected override void EMJMPPLJJNE(LinkedList<T> DKPNELDIPIB, int GCDIELAOHNA, T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8BE0A0", Offset = "0x8BD0A0", VA = "0x1808BE0A0", Slot = "9")]
	protected override LinkedList<T> NCCDMBKHFGE(LinkedList<T> OJBIELCKBAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x3314F20", Offset = "0x3313F20", VA = "0x183314F20", Slot = "7")]
	protected override LinkedList<T> OOGKEDOOOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3314D70", Offset = "0x3313D70", VA = "0x183314D70", Slot = "6")]
	protected override LinkedList<T>.Enumerator HEPJLIAACBF(LinkedList<T> HLPKKPNOMHG)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class MAAEJBBIEDI<T> : PJFPKHMGPPI<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3C21600", Offset = "0x3C20600", VA = "0x183C21600", Slot = "8")]
	protected override void EMJMPPLJJNE(Queue<T> DKPNELDIPIB, int GCDIELAOHNA, T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3314F20", Offset = "0x3313F20", VA = "0x183314F20", Slot = "7")]
	protected override Queue<T> OOGKEDOOOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9C70", Offset = "0x3EB8C70", VA = "0x183EB9C70", Slot = "6")]
	protected override Queue<T>.Enumerator HEPJLIAACBF(Queue<T> HLPKKPNOMHG)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x8BE0A0", Offset = "0x8BD0A0", VA = "0x1808BE0A0", Slot = "9")]
	protected override Queue<T> NCCDMBKHFGE(Queue<T> OJBIELCKBAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class KCGDFEDIIPP<T> : PJFPKHMGPPI<T, LJLDMNBAIMP<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3B37150", Offset = "0x3B36150", VA = "0x183B37150", Slot = "8")]
	protected override void EMJMPPLJJNE(LJLDMNBAIMP<T> DKPNELDIPIB, int GCDIELAOHNA, T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3B371A0", Offset = "0x3B361A0", VA = "0x183B371A0", Slot = "7")]
	protected override LJLDMNBAIMP<T> OOGKEDOOOJC()
	{
		return default(LJLDMNBAIMP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3BE9650", Offset = "0x3BE8650", VA = "0x183BE9650", Slot = "6")]
	protected override Stack<T>.Enumerator HEPJLIAACBF(Stack<T> HLPKKPNOMHG)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3BE96B0", Offset = "0x3BE86B0", VA = "0x183BE96B0", Slot = "9")]
	protected override Stack<T> NCCDMBKHFGE(LJLDMNBAIMP<T> OJBIELCKBAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public sealed class MODNKFAIHMM<T> : PJFPKHMGPPI<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x3C21600", Offset = "0x3C20600", VA = "0x183C21600", Slot = "8")]
	protected override void EMJMPPLJJNE(HashSet<T> DKPNELDIPIB, int GCDIELAOHNA, T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x8BE0A0", Offset = "0x8BD0A0", VA = "0x1808BE0A0", Slot = "9")]
	protected override HashSet<T> NCCDMBKHFGE(HashSet<T> OJBIELCKBAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x3314F20", Offset = "0x3313F20", VA = "0x183314F20", Slot = "7")]
	protected override HashSet<T> OOGKEDOOOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9C70", Offset = "0x3EB8C70", VA = "0x183EB9C70", Slot = "6")]
	protected override HashSet<T>.Enumerator HEPJLIAACBF(HashSet<T> HLPKKPNOMHG)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class MAECBHHOHCB<T> : MHJPLPOAPAC<T, LJLDMNBAIMP<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3B37150", Offset = "0x3B36150", VA = "0x183B37150", Slot = "8")]
	protected override void EMJMPPLJJNE(LJLDMNBAIMP<T> DKPNELDIPIB, int GCDIELAOHNA, T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9CD0", Offset = "0x3EB8CD0", VA = "0x183EB9CD0", Slot = "9")]
	protected override ReadOnlyCollection<T> NCCDMBKHFGE(LJLDMNBAIMP<T> OJBIELCKBAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9D70", Offset = "0x3EB8D70", VA = "0x183EB9D70", Slot = "7")]
	protected override LJLDMNBAIMP<T> OOGKEDOOOJC()
	{
		return default(LJLDMNBAIMP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class CONGKKJCMGE<T> : MHJPLPOAPAC<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x3C21600", Offset = "0x3C20600", VA = "0x183C21600", Slot = "8")]
	protected override void EMJMPPLJJNE(List<T> DKPNELDIPIB, int GCDIELAOHNA, T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3314F20", Offset = "0x3313F20", VA = "0x183314F20", Slot = "7")]
	protected override List<T> OOGKEDOOOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8BE0A0", Offset = "0x8BD0A0", VA = "0x1808BE0A0", Slot = "9")]
	protected override IList<T> NCCDMBKHFGE(List<T> OJBIELCKBAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class BGCPHAHFFGC<T> : MHJPLPOAPAC<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3C21600", Offset = "0x3C20600", VA = "0x183C21600", Slot = "8")]
	protected override void EMJMPPLJJNE(List<T> DKPNELDIPIB, int GCDIELAOHNA, T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x3314F20", Offset = "0x3313F20", VA = "0x183314F20", Slot = "7")]
	protected override List<T> OOGKEDOOOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8BE0A0", Offset = "0x8BD0A0", VA = "0x1808BE0A0", Slot = "9")]
	protected override ICollection<T> NCCDMBKHFGE(List<T> OJBIELCKBAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public sealed class JENGGDMIHGI<T> : MHJPLPOAPAC<T, LJLDMNBAIMP<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3B37150", Offset = "0x3B36150", VA = "0x183B37150", Slot = "8")]
	protected override void EMJMPPLJJNE(LJLDMNBAIMP<T> DKPNELDIPIB, int GCDIELAOHNA, T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3B371A0", Offset = "0x3B361A0", VA = "0x183B371A0", Slot = "7")]
	protected override LJLDMNBAIMP<T> OOGKEDOOOJC()
	{
		return default(LJLDMNBAIMP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3B37180", Offset = "0x3B36180", VA = "0x183B37180", Slot = "9")]
	protected override IEnumerable<T> NCCDMBKHFGE(LJLDMNBAIMP<T> OJBIELCKBAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x32FCE70", Offset = "0x32FBE70", VA = "0x1832FCE70")]
	public JENGGDMIHGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public sealed class PKCAACDJKPH<TKey, TElement> : GBPBACCCJGH<IGrouping<TKey, TElement>>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x4153DF0", Offset = "0x4152DF0", VA = "0x184153DF0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, IGrouping<TKey, TElement> CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x4153AF0", Offset = "0x4152AF0", VA = "0x184153AF0", Slot = "5")]
	public IGrouping<TKey, TElement> MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class DCDBCDECANG<TKey, TElement> : GBPBACCCJGH<ILookup<TKey, TElement>>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x50AA7B0", Offset = "0x50A97B0", VA = "0x1850AA7B0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, ILookup<TKey, TElement> CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x50AA460", Offset = "0x50A9460", VA = "0x1850AA460", Slot = "5")]
	public ILookup<TKey, TElement> MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class CLGNMELMIDF<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly TKey IPAJBJLLPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly IEnumerable<TElement> JOGMOPACDKH;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey KHCGDDAFALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7C8740", Offset = "0x7C7740", VA = "0x1807C8740")]
	public CLGNMELMIDF(TKey IPAJBJLLPIJ, IEnumerable<TElement> JOGMOPACDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x4C9AC40", Offset = "0x4C99C40", VA = "0x184C9AC40", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x33767A0", Offset = "0x33757A0", VA = "0x1833767A0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[DefaultMember("Item")]
internal class APNHLNDGEOH<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> CCHHCLJIJKC;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> EIFMNNJBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x37A1B10", Offset = "0x37A0B10", VA = "0x1837A1B10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public APNHLNDGEOH(Dictionary<TKey, IGrouping<TKey, TElement>> CCHHCLJIJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x37EB720", Offset = "0x37EA720", VA = "0x1837EB720", Slot = "5")]
	public bool Contains(TKey IPAJBJLLPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x39F4F50", Offset = "0x39F3F50", VA = "0x1839F4F50", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x39F4F50", Offset = "0x39F3F50", VA = "0x1839F4F50", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class PCJGCNLCAEJ<T> : GBPBACCCJGH<T>, BGMCLJEKLLA where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x413C9B0", Offset = "0x413B9B0", VA = "0x18413C9B0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, T CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x413C730", Offset = "0x413B730", VA = "0x18413C730", Slot = "5")]
	public T MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public PCJGCNLCAEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class JKDIOEALEEM : GBPBACCCJGH<IEnumerable>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly GBPBACCCJGH<IEnumerable> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC040", Offset = "0x6AAB040", VA = "0x186AAC040", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, IEnumerable CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6AABDF0", Offset = "0x6AAADF0", VA = "0x186AABDF0", Slot = "5")]
	public IEnumerable MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public JKDIOEALEEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class IPJGMDJABCH : GBPBACCCJGH<ICollection>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public static readonly GBPBACCCJGH<ICollection> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA620", Offset = "0x6AA9620", VA = "0x186AAA620", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, ICollection CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA3D0", Offset = "0x6AA93D0", VA = "0x186AAA3D0", Slot = "5")]
	public ICollection MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public IPJGMDJABCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class HGKMJFAEIJF : GBPBACCCJGH<IList>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public static readonly GBPBACCCJGH<IList> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7990", Offset = "0x6AA6990", VA = "0x186AA7990", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, IList CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7740", Offset = "0x6AA6740", VA = "0x186AA7740", Slot = "5")]
	public IList MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public HGKMJFAEIJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class KBHEMJIKCCJ<T> : MHJPLPOAPAC<T, LJLDMNBAIMP<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7410", Offset = "0x3BE6410", VA = "0x183BE7410", Slot = "8")]
	protected override void EMJMPPLJJNE(LJLDMNBAIMP<T> DKPNELDIPIB, int GCDIELAOHNA, T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3B371A0", Offset = "0x3B361A0", VA = "0x183B371A0", Slot = "7")]
	protected override LJLDMNBAIMP<T> OOGKEDOOOJC()
	{
		return default(LJLDMNBAIMP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3BE7470", Offset = "0x3BE6470", VA = "0x183BE7470", Slot = "9")]
	protected override IReadOnlyList<T> NCCDMBKHFGE(LJLDMNBAIMP<T> OJBIELCKBAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x32FC7A0", Offset = "0x32FB7A0", VA = "0x1832FC7A0")]
	public KBHEMJIKCCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class NNLANEJKJAC
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0860", Offset = "0x6AAF860", VA = "0x186AB0860")]
	public static DateTime IFJIJEAFNLI(DateTime APALGCMJLCN)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class PELKNHKPMHA : GBPBACCCJGH<DateTime>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public static readonly GBPBACCCJGH<DateTime> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB2160", Offset = "0x6AB1160", VA = "0x186AB2160", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, DateTime CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6AB1450", Offset = "0x6AB0450", VA = "0x186AB1450", Slot = "5")]
	public DateTime MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public PELKNHKPMHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class LDKMMMDHIKB : GBPBACCCJGH<DateTimeOffset>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public static readonly GBPBACCCJGH<DateTimeOffset> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD880", Offset = "0x6AAC880", VA = "0x186AAD880", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, DateTimeOffset CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6AACC60", Offset = "0x6AABC60", VA = "0x186AACC60", Slot = "5")]
	public DateTimeOffset MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public LDKMMMDHIKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class JBNFPDIAKDG : GBPBACCCJGH<TimeSpan>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly GBPBACCCJGH<TimeSpan> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static byte[] FOFIFNOAPNH;

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6AAB350", Offset = "0x6AAA350", VA = "0x186AAB350", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, TimeSpan CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6AAAA40", Offset = "0x6AA9A40", VA = "0x186AAAA40", Slot = "5")]
	public TimeSpan MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public JBNFPDIAKDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public abstract class AAJBGGPAIJK<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : GBPBACCCJGH<TDictionary>, BGMCLJEKLLA where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x37142D0", Offset = "0x37132D0", VA = "0x1837142D0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, TDictionary CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3710590", Offset = "0x370F590", VA = "0x183710590", Slot = "5")]
	public TDictionary MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator HEPJLIAACBF(TDictionary HLPKKPNOMHG);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate OOGKEDOOOJC();

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void EMJMPPLJJNE(TIntermediate DKPNELDIPIB, int GCDIELAOHNA, TKey IPAJBJLLPIJ, TValue CFJDHAGGAJO);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary NCCDMBKHFGE(TIntermediate OJBIELCKBAD);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	protected AAJBGGPAIJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public abstract class AFMFPENJKNA<TKey, TValue, TIntermediate, TDictionary> : AAJBGGPAIJK<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x37A0440", Offset = "0x379F440", VA = "0x1837A0440", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> HEPJLIAACBF(TDictionary HLPKKPNOMHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public abstract class POJLEEPNBKI<TKey, TValue, TDictionary> : AFMFPENJKNA<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x8BE0A0", Offset = "0x8BD0A0", VA = "0x1808BE0A0", Slot = "9")]
	protected override TDictionary NCCDMBKHFGE(TDictionary OJBIELCKBAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class EENPHNCEFEK<TKey, TValue> : AAJBGGPAIJK<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3314C90", Offset = "0x3313C90", VA = "0x183314C90", Slot = "8")]
	protected override void EMJMPPLJJNE(Dictionary<TKey, TValue> DKPNELDIPIB, int GCDIELAOHNA, TKey IPAJBJLLPIJ, TValue CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x8BE0A0", Offset = "0x8BD0A0", VA = "0x1808BE0A0", Slot = "9")]
	protected override Dictionary<TKey, TValue> NCCDMBKHFGE(Dictionary<TKey, TValue> OJBIELCKBAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3314F20", Offset = "0x3313F20", VA = "0x183314F20", Slot = "7")]
	protected override Dictionary<TKey, TValue> OOGKEDOOOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3314EB0", Offset = "0x3313EB0", VA = "0x183314EB0", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator HEPJLIAACBF(Dictionary<TKey, TValue> HLPKKPNOMHG)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x32EE710", Offset = "0x32ED710", VA = "0x1832EE710")]
	public EENPHNCEFEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class AFMIKIGHDLP<TKey, TValue, TDictionary> : POJLEEPNBKI<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x37A0490", Offset = "0x379F490", VA = "0x1837A0490", Slot = "8")]
	protected override void EMJMPPLJJNE(TDictionary DKPNELDIPIB, int GCDIELAOHNA, TKey IPAJBJLLPIJ, TValue CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x3107AA0", Offset = "0x3106AA0", VA = "0x183107AA0", Slot = "7")]
	protected override TDictionary OOGKEDOOOJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class CHJIOOKHBOE<TKey, TValue> : AFMFPENJKNA<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3314CF0", Offset = "0x3313CF0", VA = "0x183314CF0", Slot = "8")]
	protected override void EMJMPPLJJNE(Dictionary<TKey, TValue> DKPNELDIPIB, int GCDIELAOHNA, TKey IPAJBJLLPIJ, TValue CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x3314F20", Offset = "0x3313F20", VA = "0x183314F20", Slot = "7")]
	protected override Dictionary<TKey, TValue> OOGKEDOOOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x8BE0A0", Offset = "0x8BD0A0", VA = "0x1808BE0A0", Slot = "9")]
	protected override IDictionary<TKey, TValue> NCCDMBKHFGE(Dictionary<TKey, TValue> OJBIELCKBAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class DPBDJALOOKD<TKey, TValue> : POJLEEPNBKI<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x3314CF0", Offset = "0x3313CF0", VA = "0x183314CF0", Slot = "8")]
	protected override void EMJMPPLJJNE(SortedList<TKey, TValue> DKPNELDIPIB, int GCDIELAOHNA, TKey IPAJBJLLPIJ, TValue CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x3314F20", Offset = "0x3313F20", VA = "0x183314F20", Slot = "7")]
	protected override SortedList<TKey, TValue> OOGKEDOOOJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class ELCNDGKGMLO<TKey, TValue> : AAJBGGPAIJK<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x3314CF0", Offset = "0x3313CF0", VA = "0x183314CF0", Slot = "8")]
	protected override void EMJMPPLJJNE(SortedDictionary<TKey, TValue> DKPNELDIPIB, int GCDIELAOHNA, TKey IPAJBJLLPIJ, TValue CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x8BE0A0", Offset = "0x8BD0A0", VA = "0x1808BE0A0", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> NCCDMBKHFGE(SortedDictionary<TKey, TValue> OJBIELCKBAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x3314F20", Offset = "0x3313F20", VA = "0x183314F20", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> OOGKEDOOOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x3314DE0", Offset = "0x3313DE0", VA = "0x183314DE0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator HEPJLIAACBF(SortedDictionary<TKey, TValue> HLPKKPNOMHG)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class EEEKAGKKAPP<T> : GBPBACCCJGH<T>, BGMCLJEKLLA where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x3313110", Offset = "0x3312110", VA = "0x183313110", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, T CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3312E70", Offset = "0x3311E70", VA = "0x183312E70", Slot = "5")]
	public T MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public EEEKAGKKAPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class DLGFFBCNHIA : GBPBACCCJGH<IDictionary>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public static readonly GBPBACCCJGH<IDictionary> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5390", Offset = "0x6AA4390", VA = "0x186AA5390", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, IDictionary CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5160", Offset = "0x6AA4160", VA = "0x186AA5160", Slot = "5")]
	public IDictionary MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public DLGFFBCNHIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class IPEAKHIBPNP : GBPBACCCJGH<object>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private delegate void FFBDAMNNMOJ(object KBJEAHGOEDC, KCGIPMDKOPA HKMKHKLNOHE, object CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly AOLGEKAGBEO<KeyValuePair<object, FFBDAMNNMOJ>> HIJAIDOJPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private readonly NONFMIGJIBJ[] JABCNAOBKIB;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA320", Offset = "0x6AA9320", VA = "0x186AAA320")]
	public IPEAKHIBPNP(params NONFMIGJIBJ[] JABCNAOBKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9960", Offset = "0x6AA8960", VA = "0x186AA9960", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, object CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA98D0", Offset = "0x6AA88D0", VA = "0x186AA98D0", Slot = "5")]
	public object MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class LFPBNKFLJHH
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x6AAE890", Offset = "0x6AAD890", VA = "0x186AAE890")]
	public static object FIOGLACAKHF(Type IKHOLAJCJOG, [Out] bool HKCKEAHKHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6AADFA0", Offset = "0x6AACFA0", VA = "0x186AADFA0")]
	public static object BNHPMKCFCDD(Type IKHOLAJCJOG, [Out] bool HKCKEAHKHGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class NHGDMCMIIDC<T> : GBPBACCCJGH<T>, BGMCLJEKLLA, IGCFOJAHFAN<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class LBJFALDPDCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public LBJFALDPDCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9DA0", Offset = "0x3CD8DA0", VA = "0x183CD9DA0")]
		internal bool OEPEDHFINGN(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private sealed class KIKNAMHBMBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public KIKNAMHBMBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C23BD0", Offset = "0x3C22BD0", VA = "0x183C23BD0")]
		internal bool ABOJKLCJLEP(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class FCFDFJPJPJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public DDHGDMPLPDO<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public FCFDFJPJPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x3666D90", Offset = "0x3665D90", VA = "0x183666D90")]
		internal void LDECCCIDKNK(KCGIPMDKOPA writer, T value, NONFMIGJIBJ _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class HLLCBNHEFCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public ENDAIOEHMGF<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public HLLCBNHEFCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x37EA800", Offset = "0x37E9800", VA = "0x1837EA800")]
		internal T JHOMJBHLJCG(OOEOKDFPEDP reader, NONFMIGJIBJ _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private static readonly HGKHCLJFLPJ<T> APPGAEJBDGL;

	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private static readonly Dictionary<T, string> AIEJOJPJIHG;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private static readonly DDHGDMPLPDO<T> KLMBDDBIMOI;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private static readonly ENDAIOEHMGF<T> IJPIIMBKKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private readonly bool MINJIMFIOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private readonly DDHGDMPLPDO<T> EIGPLFGDHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private readonly ENDAIOEHMGF<T> NBMEHANKOPC;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x3F5C080", Offset = "0x3F5B080", VA = "0x183F5C080")]
	static NHGDMCMIIDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x3F640F0", Offset = "0x3F630F0", VA = "0x183F640F0")]
	public NHGDMCMIIDC(bool MINJIMFIOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3F506F0", Offset = "0x3F4F6F0", VA = "0x183F506F0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, T CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3F4D060", Offset = "0x3F4C060", VA = "0x183F4D060", Slot = "5")]
	public T MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3F4AA40", Offset = "0x3F49A40", VA = "0x183F4AA40", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, T CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x3F48C60", Offset = "0x3F47C60", VA = "0x183F48C60", Slot = "7")]
	public T DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class JEDHCOJIICG<T> : GBPBACCCJGH<T[,]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3B36750", Offset = "0x3B35750", VA = "0x183B36750", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, T[,] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3B36420", Offset = "0x3B35420", VA = "0x183B36420", Slot = "5")]
	public T[,] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public JEDHCOJIICG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class DOIPKJDEMLJ<T> : GBPBACCCJGH<T[,,]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x50EB270", Offset = "0x50EA270", VA = "0x1850EB270", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, T[,,] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x50EAE30", Offset = "0x50E9E30", VA = "0x1850EAE30", Slot = "5")]
	public T[,,] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public DOIPKJDEMLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public sealed class CGDPKFPGBGE<T> : GBPBACCCJGH<T[,,,]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x4C908F0", Offset = "0x4C8F8F0", VA = "0x184C908F0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, T[,,,] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x4C903A0", Offset = "0x4C8F3A0", VA = "0x184C903A0", Slot = "5")]
	public T[,,,] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public CGDPKFPGBGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public sealed class DAPCOBBMKPF<T> : GBPBACCCJGH<T?>, BGMCLJEKLLA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x50A6E40", Offset = "0x50A5E40", VA = "0x1850A6E40", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, T? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x50A6B10", Offset = "0x50A5B10", VA = "0x1850A6B10", Slot = "5")]
	public T? MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public DAPCOBBMKPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public sealed class IIOHGMDBEAP<T> : GBPBACCCJGH<T?>, BGMCLJEKLLA where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private readonly GBPBACCCJGH<T> MFHGNLKNJDB;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public IIOHGMDBEAP(GBPBACCCJGH<T> MFHGNLKNJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x3937A00", Offset = "0x3936A00", VA = "0x183937A00", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, T? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x3936FD0", Offset = "0x3935FD0", VA = "0x183936FD0", Slot = "5")]
	public T? MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public sealed class ANCIMNBIGFO : GBPBACCCJGH<sbyte>, BGMCLJEKLLA, IGCFOJAHFAN<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public static readonly ANCIMNBIGFO KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3A80", Offset = "0x6AA2A80", VA = "0x186AA3A80", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, sbyte CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3A30", Offset = "0x6AA2A30", VA = "0x186AA3A30", Slot = "5")]
	public sbyte MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6AA39C0", Offset = "0x6AA29C0", VA = "0x186AA39C0", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, sbyte CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3900", Offset = "0x6AA2900", VA = "0x186AA3900", Slot = "7")]
	public sbyte DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public ANCIMNBIGFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public sealed class IFFAMOAHHPL : GBPBACCCJGH<sbyte?>, BGMCLJEKLLA, IGCFOJAHFAN<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public static readonly IFFAMOAHHPL KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x6AA93C0", Offset = "0x6AA83C0", VA = "0x186AA93C0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, sbyte? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9310", Offset = "0x6AA8310", VA = "0x186AA9310", Slot = "5")]
	public sbyte? MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9250", Offset = "0x6AA8250", VA = "0x186AA9250", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, sbyte? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9130", Offset = "0x6AA8130", VA = "0x186AA9130", Slot = "7")]
	public sbyte? DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public IFFAMOAHHPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public sealed class LKFBKCOFEFN : GBPBACCCJGH<sbyte[]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public static readonly LKFBKCOFEFN KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6AAFAE0", Offset = "0x6AAEAE0", VA = "0x186AAFAE0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, sbyte[] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF950", Offset = "0x6AAE950", VA = "0x186AAF950", Slot = "5")]
	public sbyte[] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public LKFBKCOFEFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class AKAPKMFNKOH : GBPBACCCJGH<short>, BGMCLJEKLLA, IGCFOJAHFAN<short>
{
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public static readonly AKAPKMFNKOH KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6AA34E0", Offset = "0x6AA24E0", VA = "0x186AA34E0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, short CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3490", Offset = "0x6AA2490", VA = "0x186AA3490", Slot = "5")]
	public short MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3420", Offset = "0x6AA2420", VA = "0x186AA3420", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, short CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3360", Offset = "0x6AA2360", VA = "0x186AA3360", Slot = "7")]
	public short DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public AKAPKMFNKOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public sealed class OKPIDONCGCF : GBPBACCCJGH<short?>, BGMCLJEKLLA, IGCFOJAHFAN<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public static readonly OKPIDONCGCF KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0FC0", Offset = "0x6AAFFC0", VA = "0x186AB0FC0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, short? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0F10", Offset = "0x6AAFF10", VA = "0x186AB0F10", Slot = "5")]
	public short? MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0E50", Offset = "0x6AAFE50", VA = "0x186AB0E50", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, short? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0D30", Offset = "0x6AAFD30", VA = "0x186AB0D30", Slot = "7")]
	public short? DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public OKPIDONCGCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class AKJKIJMMDDL : GBPBACCCJGH<short[]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public static readonly AKJKIJMMDDL KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3750", Offset = "0x6AA2750", VA = "0x186AA3750", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, short[] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6AA35C0", Offset = "0x6AA25C0", VA = "0x186AA35C0", Slot = "5")]
	public short[] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public AKJKIJMMDDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class ACIBEGNIGGN : GBPBACCCJGH<int>, BGMCLJEKLLA, IGCFOJAHFAN<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public static readonly ACIBEGNIGGN KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6AA2E60", Offset = "0x6AA1E60", VA = "0x186AA2E60", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, int CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6AA2E10", Offset = "0x6AA1E10", VA = "0x186AA2E10", Slot = "5")]
	public int MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6AA2DA0", Offset = "0x6AA1DA0", VA = "0x186AA2DA0", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, int CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6AA2CE0", Offset = "0x6AA1CE0", VA = "0x186AA2CE0", Slot = "7")]
	public int DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public ACIBEGNIGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class LHDJNDGFCJI : GBPBACCCJGH<int?>, BGMCLJEKLLA, IGCFOJAHFAN<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public static readonly LHDJNDGFCJI KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF810", Offset = "0x6AAE810", VA = "0x186AAF810", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, int? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF760", Offset = "0x6AAE760", VA = "0x186AAF760", Slot = "5")]
	public int? MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF6A0", Offset = "0x6AAE6A0", VA = "0x186AAF6A0", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, int? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF580", Offset = "0x6AAE580", VA = "0x186AAF580", Slot = "7")]
	public int? DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public LHDJNDGFCJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class HFEIDKLADAP : GBPBACCCJGH<int[]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public static readonly HFEIDKLADAP KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6AA73B0", Offset = "0x6AA63B0", VA = "0x186AA73B0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, int[] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7220", Offset = "0x6AA6220", VA = "0x186AA7220", Slot = "5")]
	public int[] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public HFEIDKLADAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class IBLFOFNMABN : GBPBACCCJGH<long>, BGMCLJEKLLA, IGCFOJAHFAN<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly IBLFOFNMABN KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8A40", Offset = "0x6AA7A40", VA = "0x186AA8A40", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, long CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6AA89F0", Offset = "0x6AA79F0", VA = "0x186AA89F0", Slot = "5")]
	public long MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8980", Offset = "0x6AA7980", VA = "0x186AA8980", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, long CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x6AA88C0", Offset = "0x6AA78C0", VA = "0x186AA88C0", Slot = "7")]
	public long DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public IBLFOFNMABN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class AOJCGKANKJM : GBPBACCCJGH<long?>, BGMCLJEKLLA, IGCFOJAHFAN<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly AOJCGKANKJM KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3E20", Offset = "0x6AA2E20", VA = "0x186AA3E20", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, long? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3D60", Offset = "0x6AA2D60", VA = "0x186AA3D60", Slot = "5")]
	public long? MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3CA0", Offset = "0x6AA2CA0", VA = "0x186AA3CA0", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, long? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3B60", Offset = "0x6AA2B60", VA = "0x186AA3B60", Slot = "7")]
	public long? DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public AOJCGKANKJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class HJDCEOBIGJJ : GBPBACCCJGH<long[]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly HJDCEOBIGJJ KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7ED0", Offset = "0x6AA6ED0", VA = "0x186AA7ED0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, long[] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7D40", Offset = "0x6AA6D40", VA = "0x186AA7D40", Slot = "5")]
	public long[] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public HJDCEOBIGJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class NCJIFMAGKAK : GBPBACCCJGH<byte>, BGMCLJEKLLA, IGCFOJAHFAN<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly NCJIFMAGKAK KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x6AB03B0", Offset = "0x6AAF3B0", VA = "0x186AB03B0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, byte CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0360", Offset = "0x6AAF360", VA = "0x186AB0360", Slot = "5")]
	public byte MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x6AB02F0", Offset = "0x6AAF2F0", VA = "0x186AB02F0", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, byte CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0230", Offset = "0x6AAF230", VA = "0x186AB0230", Slot = "7")]
	public byte DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public NCJIFMAGKAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class IBBKJKCJOMA : GBPBACCCJGH<byte?>, BGMCLJEKLLA, IGCFOJAHFAN<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly IBBKJKCJOMA KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8780", Offset = "0x6AA7780", VA = "0x186AA8780", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, byte? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x6AA86D0", Offset = "0x6AA76D0", VA = "0x186AA86D0", Slot = "5")]
	public byte? MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8610", Offset = "0x6AA7610", VA = "0x186AA8610", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, byte? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6AA84F0", Offset = "0x6AA74F0", VA = "0x186AA84F0", Slot = "7")]
	public byte? DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public IBBKJKCJOMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class MIPGFENJCPF : GBPBACCCJGH<ushort>, BGMCLJEKLLA, IGCFOJAHFAN<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly MIPGFENJCPF KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x6AAFE10", Offset = "0x6AAEE10", VA = "0x186AAFE10", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, ushort CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x6AAFDC0", Offset = "0x6AAEDC0", VA = "0x186AAFDC0", Slot = "5")]
	public ushort MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x6AAFD50", Offset = "0x6AAED50", VA = "0x186AAFD50", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, ushort CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x6AAFC90", Offset = "0x6AAEC90", VA = "0x186AAFC90", Slot = "7")]
	public ushort DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public MIPGFENJCPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class INKKIOBFHHD : GBPBACCCJGH<ushort?>, BGMCLJEKLLA, IGCFOJAHFAN<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly INKKIOBFHHD KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9790", Offset = "0x6AA8790", VA = "0x186AA9790", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, ushort? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x6AA96E0", Offset = "0x6AA86E0", VA = "0x186AA96E0", Slot = "5")]
	public ushort? MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9620", Offset = "0x6AA8620", VA = "0x186AA9620", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, ushort? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9500", Offset = "0x6AA8500", VA = "0x186AA9500", Slot = "7")]
	public ushort? DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public INKKIOBFHHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class GOPOLLFIFIG : GBPBACCCJGH<ushort[]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly GOPOLLFIFIG KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA64F0", Offset = "0x6AA54F0", VA = "0x186AA64F0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, ushort[] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6360", Offset = "0x6AA5360", VA = "0x186AA6360", Slot = "5")]
	public ushort[] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public GOPOLLFIFIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class HLGJMMAGMLP : GBPBACCCJGH<uint>, BGMCLJEKLLA, IGCFOJAHFAN<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly HLGJMMAGMLP KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8200", Offset = "0x6AA7200", VA = "0x186AA8200", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, uint CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6AA81B0", Offset = "0x6AA71B0", VA = "0x186AA81B0", Slot = "5")]
	public uint MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8140", Offset = "0x6AA7140", VA = "0x186AA8140", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, uint CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8080", Offset = "0x6AA7080", VA = "0x186AA8080", Slot = "7")]
	public uint DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public HLGJMMAGMLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class JLBGJNDHKEB : GBPBACCCJGH<uint?>, BGMCLJEKLLA, IGCFOJAHFAN<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly JLBGJNDHKEB KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC600", Offset = "0x6AAB600", VA = "0x186AAC600", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, uint? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC550", Offset = "0x6AAB550", VA = "0x186AAC550", Slot = "5")]
	public uint? MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC490", Offset = "0x6AAB490", VA = "0x186AAC490", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, uint? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC370", Offset = "0x6AAB370", VA = "0x186AAC370", Slot = "7")]
	public uint? DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public JLBGJNDHKEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class NAEFJNJGJMD : GBPBACCCJGH<uint[]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly NAEFJNJGJMD KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0080", Offset = "0x6AAF080", VA = "0x186AB0080", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, uint[] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x6AAFEF0", Offset = "0x6AAEEF0", VA = "0x186AAFEF0", Slot = "5")]
	public uint[] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public NAEFJNJGJMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class HBCHMJOCEBM : GBPBACCCJGH<ulong>, BGMCLJEKLLA, IGCFOJAHFAN<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly HBCHMJOCEBM KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6AE0", Offset = "0x6AA5AE0", VA = "0x186AA6AE0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, ulong CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6A90", Offset = "0x6AA5A90", VA = "0x186AA6A90", Slot = "5")]
	public ulong MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6A20", Offset = "0x6AA5A20", VA = "0x186AA6A20", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, ulong CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6960", Offset = "0x6AA5960", VA = "0x186AA6960", Slot = "7")]
	public ulong DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public HBCHMJOCEBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class LHCLCPLLCFG : GBPBACCCJGH<ulong?>, BGMCLJEKLLA, IGCFOJAHFAN<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly LHCLCPLLCFG KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF440", Offset = "0x6AAE440", VA = "0x186AAF440", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, ulong? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF380", Offset = "0x6AAE380", VA = "0x186AAF380", Slot = "5")]
	public ulong? MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF2C0", Offset = "0x6AAE2C0", VA = "0x186AAF2C0", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, ulong? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF180", Offset = "0x6AAE180", VA = "0x186AAF180", Slot = "7")]
	public ulong? DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public LHCLCPLLCFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class DFGKDKFAPLE : GBPBACCCJGH<ulong[]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly DFGKDKFAPLE KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4FB0", Offset = "0x6AA3FB0", VA = "0x186AA4FB0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, ulong[] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4E20", Offset = "0x6AA3E20", VA = "0x186AA4E20", Slot = "5")]
	public ulong[] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public DFGKDKFAPLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class NPHHPGIMFBF : GBPBACCCJGH<float>, BGMCLJEKLLA, IGCFOJAHFAN<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly NPHHPGIMFBF KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0C50", Offset = "0x6AAFC50", VA = "0x186AB0C50", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, float CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0C00", Offset = "0x6AAFC00", VA = "0x186AB0C00", Slot = "5")]
	public float MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0B90", Offset = "0x6AAFB90", VA = "0x186AB0B90", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, float CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0AD0", Offset = "0x6AAFAD0", VA = "0x186AB0AD0", Slot = "7")]
	public float DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public NPHHPGIMFBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class NNDGBBDMOBL : GBPBACCCJGH<float?>, BGMCLJEKLLA, IGCFOJAHFAN<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly NNDGBBDMOBL KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0720", Offset = "0x6AAF720", VA = "0x186AB0720", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, float? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0670", Offset = "0x6AAF670", VA = "0x186AB0670", Slot = "5")]
	public float? MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x6AB05B0", Offset = "0x6AAF5B0", VA = "0x186AB05B0", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, float? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0490", Offset = "0x6AAF490", VA = "0x186AB0490", Slot = "7")]
	public float? DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public NNDGBBDMOBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class JFIFLHFAAAL : GBPBACCCJGH<float[]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly JFIFLHFAAAL KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6AABC30", Offset = "0x6AAAC30", VA = "0x186AABC30", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, float[] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6AABAA0", Offset = "0x6AAAAA0", VA = "0x186AABAA0", Slot = "5")]
	public float[] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public JFIFLHFAAAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class HDLJFALKHPF : GBPBACCCJGH<double>, BGMCLJEKLLA, IGCFOJAHFAN<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly HDLJFALKHPF KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6D40", Offset = "0x6AA5D40", VA = "0x186AA6D40", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, double CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6CF0", Offset = "0x6AA5CF0", VA = "0x186AA6CF0", Slot = "5")]
	public double MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6C80", Offset = "0x6AA5C80", VA = "0x186AA6C80", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, double CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6BC0", Offset = "0x6AA5BC0", VA = "0x186AA6BC0", Slot = "7")]
	public double DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public HDLJFALKHPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class HEDLMCJGLLP : GBPBACCCJGH<double?>, BGMCLJEKLLA, IGCFOJAHFAN<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly HEDLMCJGLLP KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x6AA70E0", Offset = "0x6AA60E0", VA = "0x186AA70E0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, double? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7020", Offset = "0x6AA6020", VA = "0x186AA7020", Slot = "5")]
	public double? MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6F60", Offset = "0x6AA5F60", VA = "0x186AA6F60", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, double? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6E20", Offset = "0x6AA5E20", VA = "0x186AA6E20", Slot = "7")]
	public double? DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public HEDLMCJGLLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class FAGEALBCFNJ : GBPBACCCJGH<double[]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly FAGEALBCFNJ KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6050", Offset = "0x6AA5050", VA = "0x186AA6050", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, double[] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5EC0", Offset = "0x6AA4EC0", VA = "0x186AA5EC0", Slot = "5")]
	public double[] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public FAGEALBCFNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class ELAGEAACOKK : GBPBACCCJGH<bool>, BGMCLJEKLLA, IGCFOJAHFAN<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly ELAGEAACOKK KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5A70", Offset = "0x6AA4A70", VA = "0x186AA5A70", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, bool CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5A20", Offset = "0x6AA4A20", VA = "0x186AA5A20", Slot = "5")]
	public bool MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x6AA59B0", Offset = "0x6AA49B0", VA = "0x186AA59B0", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, bool CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x6AA58F0", Offset = "0x6AA48F0", VA = "0x186AA58F0", Slot = "7")]
	public bool DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public ELAGEAACOKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class PFPECJOLBKF : GBPBACCCJGH<bool?>, BGMCLJEKLLA, IGCFOJAHFAN<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly PFPECJOLBKF KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x6AB2C20", Offset = "0x6AB1C20", VA = "0x186AB2C20", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, bool? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6AB2B70", Offset = "0x6AB1B70", VA = "0x186AB2B70", Slot = "5")]
	public bool? MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6AB2AB0", Offset = "0x6AB1AB0", VA = "0x186AB2AB0", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, bool? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6AB2990", Offset = "0x6AB1990", VA = "0x186AB2990", Slot = "7")]
	public bool? DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public PFPECJOLBKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class PDEGBIBMDLL : GBPBACCCJGH<bool[]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly PDEGBIBMDLL KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB1290", Offset = "0x6AB0290", VA = "0x186AB1290", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, bool[] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB1100", Offset = "0x6AB0100", VA = "0x186AB1100", Slot = "5")]
	public bool[] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public PDEGBIBMDLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class PHOJCMCCIIK : GBPBACCCJGH<object>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly GBPBACCCJGH<object> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly Dictionary<Type, int> ABMJKLHJJBF;

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6AB31A0", Offset = "0x6AB21A0", VA = "0x186AB31A0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, object CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6AB2D60", Offset = "0x6AB1D60", VA = "0x186AB2D60", Slot = "5")]
	public object MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public PHOJCMCCIIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class CNLIAHOOAGD : GBPBACCCJGH<byte[]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly GBPBACCCJGH<byte[]> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4CE0", Offset = "0x6AA3CE0", VA = "0x186AA4CE0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, byte[] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4C30", Offset = "0x6AA3C30", VA = "0x186AA4C30", Slot = "5")]
	public byte[] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public CNLIAHOOAGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class HAECHOCKCGF : GBPBACCCJGH<ArraySegment<byte>>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly GBPBACCCJGH<ArraySegment<byte>> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6AA67B0", Offset = "0x6AA57B0", VA = "0x186AA67B0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, ArraySegment<byte> CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6AA66A0", Offset = "0x6AA56A0", VA = "0x186AA66A0", Slot = "5")]
	public ArraySegment<byte> MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public HAECHOCKCGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class HFOLODKNMBK : GBPBACCCJGH<string>, BGMCLJEKLLA, IGCFOJAHFAN<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly GBPBACCCJGH<string> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7660", Offset = "0x6AA6660", VA = "0x186AA7660", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, string CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7610", Offset = "0x6AA6610", VA = "0x186AA7610", Slot = "5")]
	public string MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA75B0", Offset = "0x6AA65B0", VA = "0x186AA75B0", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, string CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7560", Offset = "0x6AA6560", VA = "0x186AA7560", Slot = "7")]
	public string DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public HFOLODKNMBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class CDNPHBLAABB : GBPBACCCJGH<string[]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly CDNPHBLAABB KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4A80", Offset = "0x6AA3A80", VA = "0x186AA4A80", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, string[] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6AA48B0", Offset = "0x6AA38B0", VA = "0x186AA48B0", Slot = "5")]
	public string[] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public CDNPHBLAABB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class NPGIEAGMJPM : GBPBACCCJGH<char>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly NPGIEAGMJPM KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0990", Offset = "0x6AAF990", VA = "0x186AB0990", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, char CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0920", Offset = "0x6AAF920", VA = "0x186AB0920", Slot = "5")]
	public char MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public NPGIEAGMJPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class BHAGDFJEDFD : GBPBACCCJGH<char?>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly BHAGDFJEDFD KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4260", Offset = "0x6AA3260", VA = "0x186AA4260", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, char? CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4140", Offset = "0x6AA3140", VA = "0x186AA4140", Slot = "5")]
	public char? MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public BHAGDFJEDFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class IBMAHELEDFF : GBPBACCCJGH<char[]>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly IBMAHELEDFF KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8CE0", Offset = "0x6AA7CE0", VA = "0x186AA8CE0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, char[] CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8B20", Offset = "0x6AA7B20", VA = "0x186AA8B20", Slot = "5")]
	public char[] MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public IBMAHELEDFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class AGGEHFKHPOA : GBPBACCCJGH<Guid>, BGMCLJEKLLA, IGCFOJAHFAN<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly GBPBACCCJGH<Guid> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6AA31B0", Offset = "0x6AA21B0", VA = "0x186AA31B0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, Guid CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3120", Offset = "0x6AA2120", VA = "0x186AA3120", Slot = "5")]
	public Guid MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6AA2FE0", Offset = "0x6AA1FE0", VA = "0x186AA2FE0", Slot = "6")]
	public void JOIMHFHBALP(KCGIPMDKOPA HKMKHKLNOHE, Guid CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x6AA2F40", Offset = "0x6AA1F40", VA = "0x186AA2F40", Slot = "7")]
	public Guid DINJGEFPIDI(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public AGGEHFKHPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class CAIPCJBBEDA : GBPBACCCJGH<decimal>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly GBPBACCCJGH<decimal> KOOHNFGMCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly bool JHEFHBCIIBL;

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x52F1710", Offset = "0x52F0710", VA = "0x1852F1710")]
	public CAIPCJBBEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x17FEFB0", Offset = "0x17FDFB0", VA = "0x1817FEFB0")]
	public CAIPCJBBEDA(bool JHEFHBCIIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4680", Offset = "0x6AA3680", VA = "0x186AA4680", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, decimal CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA43E0", Offset = "0x6AA33E0", VA = "0x186AA43E0", Slot = "5")]
	public decimal MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class ICIJICOMOMN : GBPBACCCJGH<Uri>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly GBPBACCCJGH<Uri> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8FD0", Offset = "0x6AA7FD0", VA = "0x186AA8FD0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, Uri CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8F10", Offset = "0x6AA7F10", VA = "0x186AA8F10", Slot = "5")]
	public Uri MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public ICIJICOMOMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class LAEBDMCDICP : GBPBACCCJGH<Version>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly GBPBACCCJGH<Version> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6AACB20", Offset = "0x6AABB20", VA = "0x186AACB20", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, Version CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6AACA60", Offset = "0x6AABA60", VA = "0x186AACA60", Slot = "5")]
	public Version MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public LAEBDMCDICP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class BNPJFIOLFCD<TKey, TValue> : GBPBACCCJGH<KeyValuePair<TKey, TValue>>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x47E84E0", Offset = "0x47E74E0", VA = "0x1847E84E0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, KeyValuePair<TKey, TValue> CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x47E81B0", Offset = "0x47E71B0", VA = "0x1847E81B0", Slot = "5")]
	public KeyValuePair<TKey, TValue> MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class BDMCKJJPDFP : GBPBACCCJGH<StringBuilder>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly GBPBACCCJGH<StringBuilder> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4020", Offset = "0x6AA3020", VA = "0x186AA4020", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, StringBuilder CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3F60", Offset = "0x6AA2F60", VA = "0x186AA3F60", Slot = "5")]
	public StringBuilder MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public BDMCKJJPDFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class KDDBAJDPKLB : GBPBACCCJGH<BitArray>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly GBPBACCCJGH<BitArray> KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC8C0", Offset = "0x6AAB8C0", VA = "0x186AAC8C0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, BitArray CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC740", Offset = "0x6AAB740", VA = "0x186AAC740", Slot = "5")]
	public BitArray MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public KDDBAJDPKLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class ELFOLNOAJAB : GBPBACCCJGH<Type>, BGMCLJEKLLA
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly ELFOLNOAJAB KOOHNFGMCMF;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static readonly Regex PHEPIEKDCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private bool BAGOFPPLAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private bool KONJBHEIPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool HDMFLFEPFBM;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5EA0", Offset = "0x6AA4EA0", VA = "0x186AA5EA0")]
	public ELFOLNOAJAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x6097380", Offset = "0x6096380", VA = "0x186097380")]
	public ELFOLNOAJAB(bool BAGOFPPLAOJ, bool KONJBHEIPOP, bool HDMFLFEPFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5CA0", Offset = "0x6AA4CA0", VA = "0x186AA5CA0", Slot = "4")]
	public void PAKOMNGHIKD(KCGIPMDKOPA HKMKHKLNOHE, Type CFJDHAGGAJO, NONFMIGJIBJ MLOFBCDAJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5B50", Offset = "0x6AA4B50", VA = "0x186AA5B50", Slot = "5")]
	public Type MPIEPNPHGIA(OOEOKDFPEDP PCOFGFPALLL, NONFMIGJIBJ MLOFBCDAJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal static class JCMNKONHEAO
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal static readonly byte[][] NLAIGIJLCGA;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal static readonly PAPICJCMCHK PCLLMOFHOBG;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x6AAB890", Offset = "0x6AAA890", VA = "0x186AAB890")]
	static JCMNKONHEAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
internal static class IAOAIHJFFEI
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal static readonly byte[][] FBBCGIDJBCD;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal static readonly PAPICJCMCHK BHJGLKCDMHP;

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x6AA82E0", Offset = "0x6AA72E0", VA = "0x186AA82E0")]
	static IAOAIHJFFEI()
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
