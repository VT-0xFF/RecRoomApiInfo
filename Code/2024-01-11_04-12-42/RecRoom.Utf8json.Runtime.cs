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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class JGMBGCCONFO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x675CDA0", Offset = "0x675B7A0", VA = "0x18675CDA0")]
	public static bool GFGIIKMKNGF(this TypeInfo AKDFFJNHJJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class AGHHJAMKOHI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type FLHCAHLGLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x790420", Offset = "0x78EE20", VA = "0x180790420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] KJPOKJGCILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7BA560", Offset = "0x7B8F60", VA = "0x1807BA560")]
	public AGHHJAMKOHI(Type KACFOFCNEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = true)]
public class FCDPDLFEOIA : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void MKBLAEGMFIG<T>(FDFEMMJJDAL HAMBOEKDHKF, T BEEGCHJLJFC, ANMPFNBLBEK AOENFBDLBDF);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate T DCLFGFAFHHF<T>(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK AOENFBDLBDF);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FBNOOOLMEBG
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DDBEBCOLMLO<T> : FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, T BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PCHGBDGIAGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, T BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum LJJEDJKMJFN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class AFFEMBPIMDB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2C33BC0", Offset = "0x2C325C0", VA = "0x182C33BC0")]
	public static string ADFOKBKMGLE<T>(this DDBEBCOLMLO<T> IGCOCGIIGFD, T BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DDBEBCOLMLO<T> LMPGABMOGAI<T>();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DBHFFPNHAED
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2473C40", Offset = "0x2472640", VA = "0x182473C40")]
	public static DDBEBCOLMLO<T> OFKKDEJPALE<T>(this ANMPFNBLBEK AOENFBDLBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x674F1F0", Offset = "0x674DBF0", VA = "0x18674F1F0")]
	public static object BNAJECDJCMG(this ANMPFNBLBEK AOENFBDLBDF, Type AKDFFJNHJJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LCMGPLKPEGB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6763B90", Offset = "0x6762590", VA = "0x186763B90")]
	public LCMGPLKPEGB(string BKNCBJIACBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct KBBNLCPDBKO
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class BEBPFMFGAID
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] LMJJBGCJLAL;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] EOGPIPFPJFC;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x674EDF0", Offset = "0x674D7F0", VA = "0x18674EDF0")]
		public static byte[] LACBDJIHICE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x674ED50", Offset = "0x674D750", VA = "0x18674ED50")]
		public static char[] BPLOECDKFFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> EDLMNBLBLDD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] GLJALDCONGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] MCPLLDADFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int IACEHNBBCDL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool IPMBHLJEEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6760E10", Offset = "0x675F810", VA = "0x186760E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6762F90", Offset = "0x6761990", VA = "0x186762F90")]
	public KBBNLCPDBKO(byte[] MCPLLDADFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6762FF0", Offset = "0x67619F0", VA = "0x186762FF0")]
	public KBBNLCPDBKO(byte[] MCPLLDADFCM, int IACEHNBBCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67606D0", Offset = "0x675F0D0", VA = "0x1867606D0")]
	private LNLBHAMMIPK BLOLNPOJFOA(string OOBBCNDHGMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6762A90", Offset = "0x6761490", VA = "0x186762A90")]
	private LNLBHAMMIPK OBIJHJAGOKI(string BKNCBJIACBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x674F4C0", Offset = "0x674DEC0", VA = "0x18674F4C0")]
	public void DAPFEOCONKG(int IACEHNBBCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270")]
	public byte[] FPLPBDAHDKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D2A090", Offset = "0x1D28A90", VA = "0x181D2A090")]
	public int NLPOEACOFOA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x67611D0", Offset = "0x675FBD0", VA = "0x1867611D0")]
	public CJDMKJJONJJ EJMGIMJFHHN()
	{
		return default(CJDMKJJONJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6762220", Offset = "0x6760C20", VA = "0x186762220")]
	public void KDJDJBKBJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6761380", Offset = "0x675FD80", VA = "0x186761380")]
	public bool EMBNAAHCENM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x675FD40", Offset = "0x675E740", VA = "0x18675FD40")]
	public bool APKHDHCOBAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6762570", Offset = "0x6760F70", VA = "0x186762570")]
	public void MFFBDNLAJNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6761770", Offset = "0x6760170", VA = "0x186761770")]
	public bool GFPGOEOLECL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6762DA0", Offset = "0x67617A0", VA = "0x186762DA0")]
	public bool PKCLKAGKIBO(int MPNHPMPEEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x67620D0", Offset = "0x6760AD0", VA = "0x1867620D0")]
	public bool IPADHBKDPMN(int MPNHPMPEEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67614A0", Offset = "0x675FEA0", VA = "0x1867614A0")]
	public bool FAAGJGFKBBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6762C40", Offset = "0x6761640", VA = "0x186762C40")]
	public void OMMHDECEIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x67627B0", Offset = "0x67611B0", VA = "0x1867627B0")]
	public bool NJLLPHNBOMP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6760600", Offset = "0x675F000", VA = "0x186760600")]
	public bool BIKFMBMGBEC(int MPNHPMPEEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6761010", Offset = "0x675FA10", VA = "0x186761010")]
	public bool ECPAMFMALMB(int MPNHPMPEEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x675FDD0", Offset = "0x675E7D0", VA = "0x18675FDD0")]
	public bool BEOPCJOLHEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6761530", Offset = "0x675FF30", VA = "0x186761530")]
	public void FDMDHIKKOJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6760C20", Offset = "0x675F620", VA = "0x186760C20")]
	public bool BNHEMBFLGJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67615D0", Offset = "0x675FFD0", VA = "0x1867615D0")]
	public void FMBIGKJCDNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x675FE60", Offset = "0x675E860", VA = "0x18675FE60")]
	private void BGMHIGLDOFN([Out] byte[] ILPLEHOCGPK, [Out] int GBBBAJNBMON, [Out] int OOANPLJLHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6762020", Offset = "0x6760A20", VA = "0x186762020")]
	private static int IGOMGEJEENI(char PJHMDOOMOBI, char OIKFNBPLIOK, char BDAHFBGOEJD, char ACHEPLMFHGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6760F30", Offset = "0x675F930", VA = "0x186760F30")]
	private static int DOBHGMMPNPA(char MGCANBJCGMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6762690", Offset = "0x6761090", VA = "0x186762690")]
	public ArraySegment<byte> NHHDANIEKEK()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6760CB0", Offset = "0x675F6B0", VA = "0x186760CB0")]
	public string BPBFICLIGBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6761160", Offset = "0x675FB60", VA = "0x186761160")]
	public string EJDKBECLNFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6761970", Offset = "0x6760370", VA = "0x186761970")]
	public ArraySegment<byte> HOHBIKOBOAP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6761800", Offset = "0x6760200", VA = "0x186761800")]
	public ArraySegment<byte> HANKPJLGGHD()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6762840", Offset = "0x6761240", VA = "0x186762840")]
	public bool NLCBPJLMCBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6762CE0", Offset = "0x67616E0", VA = "0x186762CE0")]
	private static bool PIEIIGKJGBA(byte BDAHFBGOEJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6761B90", Offset = "0x6760590", VA = "0x186761B90")]
	private void HOMCJMOCDFB(CJDMKJJONJJ BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6761FD0", Offset = "0x67609D0", VA = "0x186761FD0")]
	public void IEKPLLPJPJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6762350", Offset = "0x6760D50", VA = "0x186762350")]
	private void KLMEIEHJEKP(int LGEBJMBANDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x67621A0", Offset = "0x6760BA0", VA = "0x1867621A0")]
	public sbyte JIJHNEAJCHA()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6762610", Offset = "0x6761010", VA = "0x186762610")]
	public short NHCPIDGPGKI()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x675FCC0", Offset = "0x675E6C0", VA = "0x18675FCC0")]
	public int AKJOCKHBLAG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x67624B0", Offset = "0x6760EB0", VA = "0x1867624B0")]
	public long LPPEKNIJNMI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x67610E0", Offset = "0x675FAE0", VA = "0x1867610E0")]
	public byte EHHHKOLIIDJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6761F50", Offset = "0x6760950", VA = "0x186761F50")]
	public ushort IDPGOJFOFHF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6760D90", Offset = "0x675F790", VA = "0x186760D90")]
	public uint CBHNBAAEOOG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6762B80", Offset = "0x6761580", VA = "0x186762B80")]
	public ulong OFDCMCFIEJM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6761670", Offset = "0x6760070", VA = "0x186761670")]
	public float FOPNHOCDDHO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6760E30", Offset = "0x675F830", VA = "0x186760E30")]
	public double DJIBCKINHIH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6761870", Offset = "0x6760270", VA = "0x186761870")]
	public ArraySegment<byte> HJMPEKAEEHC()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6761DE0", Offset = "0x67607E0", VA = "0x186761DE0")]
	private static int IDHAJNPPIDO(byte[] MCPLLDADFCM, int IACEHNBBCDL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class LNLBHAMMIPK : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference JBGABHJLJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int MIFELFNFKCB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int EJGBKLGCLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xBA3DA0", Offset = "0xBA27A0", VA = "0x180BA3DA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string JPNCKGDHHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x863F70", Offset = "0x862970", VA = "0x180863F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6764540", Offset = "0x6762F40", VA = "0x186764540")]
	public LNLBHAMMIPK(string BKNCBJIACBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6764450", Offset = "0x6762E50", VA = "0x186764450")]
	public LNLBHAMMIPK(string BKNCBJIACBJ, byte[] PPIPFKBLOLA, int IACEHNBBCDL, int MIFELFNFKCB, string GLNBGOGIACB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NJICMNMFEDE
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private static class HMGEKCGAEIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[ThreadStatic]
		private static byte[] LMJJBGCJLAL;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x675A3E0", Offset = "0x6758DE0", VA = "0x18675A3E0")]
		public static byte[] LACBDJIHICE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class GLEDPBJJHHK
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private delegate void MBEEKCFMMID(FDFEMMJJDAL HAMBOEKDHKF, object BEEGCHJLJFC, ANMPFNBLBEK AOENFBDLBDF);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private delegate object BPHOFADJJOP(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK AOENFBDLBDF);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private class NNMOOEADFOC
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			[CompilerGenerated]
			private sealed class JHAONNJFLBI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
				public JHAONNJFLBI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x3BEDE50", Offset = "0x3BEC850", VA = "0x183BEDE50")]
				internal bool AGJFONDNKHN(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x675CDD0", Offset = "0x675B7D0", VA = "0x18675CDD0")]
				internal bool PJEIHADLLDL(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Func<object, ANMPFNBLBEK, byte[]> GNIJCCEHEGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly Action<Stream, object, ANMPFNBLBEK> NBDDFDBLCHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly MBEEKCFMMID PHCMPIOCPFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, ANMPFNBLBEK, ArraySegment<byte>> ELBNKCGJLDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<object, ANMPFNBLBEK, string> GBIGIJCHCIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<string, ANMPFNBLBEK, object> CCHOBHDGIAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<byte[], int, ANMPFNBLBEK, object> MMPEENOEHLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly Func<Stream, ANMPFNBLBEK, object> DGJPEONOCLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly BPHOFADJJOP MOOACELAHAM;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6765F70", Offset = "0x6764970", VA = "0x186765F70")]
			public NNMOOEADFOC(Type AKDFFJNHJJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2BF71C0", Offset = "0x2BF5BC0", VA = "0x182BF71C0")]
			private static T NGPGOJAOPNO<T>(DynamicMethod PNAIILBBANF)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6765D20", Offset = "0x6764720", VA = "0x186765D20")]
			private static MethodInfo KCMBJMKIBEK(Type AKDFFJNHJJN, string CDHDOGOGPME, Type[] LLGOHLBKNDO)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Func<Type, NNMOOEADFOC> FEBMACMGIDI;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly JKJGJCADPNG<NNMOOEADFOC> PNBECEPGIHB;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6759FB0", Offset = "0x67589B0", VA = "0x186759FB0")]
		static GLEDPBJJHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6759CA0", Offset = "0x67586A0", VA = "0x186759CA0")]
		private static NNMOOEADFOC AEPBGAAHILM(Type AKDFFJNHJJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6759D20", Offset = "0x6758720", VA = "0x186759D20")]
		public static void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, object BEEGCHJLJFC, ANMPFNBLBEK AOENFBDLBDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6759EA0", Offset = "0x67588A0", VA = "0x186759EA0")]
		public static void JLKDILEIJOC(Type AKDFFJNHJJN, FDFEMMJJDAL HAMBOEKDHKF, object BEEGCHJLJFC, ANMPFNBLBEK AOENFBDLBDF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static ANMPFNBLBEK ONJOPBECHCI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] KCFPPLEPGBL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] LHMELBEPGLJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static ANMPFNBLBEK KONJDHECLMM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x67651C0", Offset = "0x6763BC0", VA = "0x1867651C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool NDGHBLBODDG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6764BD0", Offset = "0x67635D0", VA = "0x186764BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6764CD0", Offset = "0x67636D0", VA = "0x186764CD0")]
	public static void OCJPFLNKINK(ANMPFNBLBEK AOENFBDLBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2747740", Offset = "0x2746140", VA = "0x182747740")]
	public static byte[] JLKDILEIJOC<T>(T GKNPKJAGNGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x27475D0", Offset = "0x2745FD0", VA = "0x1827475D0")]
	public static byte[] JLKDILEIJOC<T>(T BEEGCHJLJFC, ANMPFNBLBEK AOENFBDLBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2747B90", Offset = "0x2746590", VA = "0x182747B90")]
	public static void JLKDILEIJOC<T>(FDFEMMJJDAL HAMBOEKDHKF, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2747C20", Offset = "0x2746620", VA = "0x182747C20")]
	public static void JLKDILEIJOC<T>(FDFEMMJJDAL HAMBOEKDHKF, T BEEGCHJLJFC, ANMPFNBLBEK AOENFBDLBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2747B00", Offset = "0x2746500", VA = "0x182747B00")]
	public static void JLKDILEIJOC<T>(Stream MLLHHPADIME, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2747840", Offset = "0x2746240", VA = "0x182747840")]
	public static void JLKDILEIJOC<T>(Stream MLLHHPADIME, T BEEGCHJLJFC, ANMPFNBLBEK AOENFBDLBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2747D00", Offset = "0x2746700", VA = "0x182747D00")]
	public static ArraySegment<byte> KNANBFGPDKG<T>(T GKNPKJAGNGH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2747D90", Offset = "0x2746790", VA = "0x182747D90")]
	public static ArraySegment<byte> KNANBFGPDKG<T>(T BEEGCHJLJFC, ANMPFNBLBEK AOENFBDLBDF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2746090", Offset = "0x2744A90", VA = "0x182746090")]
	public static string ADFOKBKMGLE<T>(T BEEGCHJLJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2745F10", Offset = "0x2744910", VA = "0x182745F10")]
	public static string ADFOKBKMGLE<T>(T BEEGCHJLJFC, ANMPFNBLBEK AOENFBDLBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2746CF0", Offset = "0x27456F0", VA = "0x182746CF0")]
	public static T DCJJDHFPDEL<T>(string KDGIFLEALKN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2746D80", Offset = "0x2745780", VA = "0x182746D80")]
	public static T DCJJDHFPDEL<T>(string KDGIFLEALKN, ANMPFNBLBEK AOENFBDLBDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2747180", Offset = "0x2745B80", VA = "0x182747180")]
	public static T DCJJDHFPDEL<T>(byte[] MCPLLDADFCM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2746AD0", Offset = "0x27454D0", VA = "0x182746AD0")]
	public static T DCJJDHFPDEL<T>(byte[] MCPLLDADFCM, ANMPFNBLBEK AOENFBDLBDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2747540", Offset = "0x2745F40", VA = "0x182747540")]
	public static T DCJJDHFPDEL<T>(byte[] MCPLLDADFCM, int IACEHNBBCDL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2746B60", Offset = "0x2745560", VA = "0x182746B60")]
	public static T DCJJDHFPDEL<T>(byte[] MCPLLDADFCM, int IACEHNBBCDL, ANMPFNBLBEK AOENFBDLBDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2747100", Offset = "0x2745B00", VA = "0x182747100")]
	public static T DCJJDHFPDEL<T>(KBBNLCPDBKO HPEAJCENMCM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2746E70", Offset = "0x2745870", VA = "0x182746E70")]
	public static T DCJJDHFPDEL<T>(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK AOENFBDLBDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2746F40", Offset = "0x2745940", VA = "0x182746F40")]
	public static T DCJJDHFPDEL<T>(Stream MLLHHPADIME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2746FC0", Offset = "0x27459C0", VA = "0x182746FC0")]
	public static T DCJJDHFPDEL<T>(Stream MLLHHPADIME, ANMPFNBLBEK AOENFBDLBDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x67647A0", Offset = "0x67631A0", VA = "0x1867647A0")]
	public static string AMFHCKPOIAF(byte[] KDGIFLEALKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6764A90", Offset = "0x6763490", VA = "0x186764A90")]
	public static string AMFHCKPOIAF(byte[] KDGIFLEALKN, int IACEHNBBCDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6764900", Offset = "0x6763300", VA = "0x186764900")]
	public static string AMFHCKPOIAF(string KDGIFLEALKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6764D40", Offset = "0x6763740", VA = "0x186764D40")]
	public static byte[] OEAILBONKJH(byte[] KDGIFLEALKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6765070", Offset = "0x6763A70", VA = "0x186765070")]
	public static byte[] OEAILBONKJH(byte[] KDGIFLEALKN, int IACEHNBBCDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6764EC0", Offset = "0x67638C0", VA = "0x186764EC0")]
	public static byte[] OEAILBONKJH(string KDGIFLEALKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x67652C0", Offset = "0x6763CC0", VA = "0x1867652C0")]
	private static void PGAPCPMOCIP(KBBNLCPDBKO HPEAJCENMCM, FDFEMMJJDAL HAMBOEKDHKF, int LADDFEBDKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6764C30", Offset = "0x6763630", VA = "0x186764C30")]
	private static int HNCIKPIFBPN(Stream KIEPLBLJKOI, byte[] LMJJBGCJLAL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum CJDMKJJONJJ : byte
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
public struct FDFEMMJJDAL
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] IGDKDKJICGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] LMJJBGCJLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int IACEHNBBCDL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NFLMDMGPJAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A090", Offset = "0x1D28A90", VA = "0x181D2A090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x674F4C0", Offset = "0x674DEC0", VA = "0x18674F4C0")]
	public void DAPFEOCONKG(int IACEHNBBCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6750230", Offset = "0x674EC30", VA = "0x186750230")]
	public static byte[] MGABBJBMNMC(string JJCBBELMNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x674F670", Offset = "0x674E070", VA = "0x18674F670")]
	public static byte[] FJAGPMNDMJA(string JJCBBELMNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x674FED0", Offset = "0x674E8D0", VA = "0x18674FED0")]
	public static byte[] KAEEFDJNACI(string JJCBBELMNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x674FD50", Offset = "0x674E750", VA = "0x18674FD50")]
	public static byte[] JKKAGMDICJJ(string JJCBBELMNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x54E4930", Offset = "0x54E3330", VA = "0x1854E4930")]
	public FDFEMMJJDAL(byte[] MLIIOOOMOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6750120", Offset = "0x674EB20", VA = "0x186750120")]
	public ArraySegment<byte> LACBDJIHICE()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x67505D0", Offset = "0x674EFD0", VA = "0x1867505D0")]
	public byte[] PGOHLMOOIPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6750770", Offset = "0x674F170", VA = "0x186750770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6750090", Offset = "0x674EA90", VA = "0x186750090")]
	public void KMEDPOMMBKE(int CBNDICJKPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x674F5B0", Offset = "0x674DFB0", VA = "0x18674F5B0")]
	public void FDNNIFBFLJE(byte NGAJEAJOFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x674F610", Offset = "0x674E010", VA = "0x18674F610")]
	public void FDNNIFBFLJE(byte[] NGAJEAJOFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x674F570", Offset = "0x674DF70", VA = "0x18674F570")]
	public void DNOMJHHGIAD(byte NGAJEAJOFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x674F830", Offset = "0x674E230", VA = "0x18674F830")]
	public void FKLHJALCKJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x674FD00", Offset = "0x674E700", VA = "0x18674FD00")]
	public void JJIDGNHEPCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6750040", Offset = "0x674EA40", VA = "0x186750040")]
	public void KJOOPLHGIDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x674F7E0", Offset = "0x674E1E0", VA = "0x18674F7E0")]
	public void FKFNNFCAMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6750640", Offset = "0x674F040", VA = "0x186750640")]
	public void PINDDPCNMJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x674FCB0", Offset = "0x674E6B0", VA = "0x18674FCB0")]
	public void JHPIMGCCINI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x67504C0", Offset = "0x674EEC0", VA = "0x1867504C0")]
	public void OKIEFDILGCP(string JJCBBELMNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x674F470", Offset = "0x674DE70", VA = "0x18674F470")]
	public void CPDNJNHMKPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x674F4D0", Offset = "0x674DED0", VA = "0x18674F4D0")]
	public void DCMKLMGDHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6750360", Offset = "0x674ED60", VA = "0x186750360")]
	public void OCMCJBNPGGE(bool BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x674F380", Offset = "0x674DD80", VA = "0x18674F380")]
	public void BNPBFGPJPJH(float BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x67500A0", Offset = "0x674EAA0", VA = "0x1867500A0")]
	public void KPAHFCGBLCC(double BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x67501C0", Offset = "0x674EBC0", VA = "0x1867501C0")]
	public void LNMAKHFHEOB(byte BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x674F400", Offset = "0x674DE00", VA = "0x18674F400")]
	public void CACKNALJFIB(ushort BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x674FC10", Offset = "0x674E610", VA = "0x18674FC10")]
	public void GGALNIDBFGJ(uint BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x674FC80", Offset = "0x674E680", VA = "0x18674FC80")]
	public void HPKAICELHKJ(ulong BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6750560", Offset = "0x674EF60", VA = "0x186750560")]
	public void PADPPNHLILK(sbyte BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6750700", Offset = "0x674F100", VA = "0x186750700")]
	public void PODOGLGNPPK(short BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6750690", Offset = "0x674F090", VA = "0x186750690")]
	public void PMCCNJEHKEC(int BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x674F350", Offset = "0x674DD50", VA = "0x18674F350")]
	public void AFPFCOHPHNK(long BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x674F880", Offset = "0x674E280", VA = "0x18674F880")]
	public void GDFMBKAMCNL(string BEEGCHJLJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PMMGGOJJKED : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private static class IEKLPMDLGOD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3821600", Offset = "0x3820000", VA = "0x183821600")]
		static IEKLPMDLGOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private PMMGGOJJKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class ALGBFJEOOFP
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> OPLBCNBCKCA;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x674E860", Offset = "0x674D260", VA = "0x18674E860")]
	static ALGBFJEOOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x674E070", Offset = "0x674CA70", VA = "0x18674E070")]
	internal static object LMPGABMOGAI(Type FIGFLJOONIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class GANFBNHNEDI : DDBEBCOLMLO<Vector2>, FBNOOOLMEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly BJBCIHBIFOH HKCNKHDKBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] HHKBMMBNKHG;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x67516E0", Offset = "0x67500E0", VA = "0x1867516E0")]
	public GANFBNHNEDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x67514F0", Offset = "0x674FEF0", VA = "0x1867514F0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, Vector2 BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6751200", Offset = "0x674FC00", VA = "0x186751200", Slot = "5")]
	public Vector2 DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class LFHAMFIHOAM : DDBEBCOLMLO<Vector3>, FBNOOOLMEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly BJBCIHBIFOH HKCNKHDKBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] HHKBMMBNKHG;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x67641E0", Offset = "0x6762BE0", VA = "0x1867641E0")]
	public LFHAMFIHOAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6763F40", Offset = "0x6762940", VA = "0x186763F40", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, Vector3 BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6763BF0", Offset = "0x67625F0", VA = "0x186763BF0", Slot = "5")]
	public Vector3 DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class KGHIPNJNGDM : DDBEBCOLMLO<Vector4>, FBNOOOLMEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly BJBCIHBIFOH HKCNKHDKBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] HHKBMMBNKHG;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x67638A0", Offset = "0x67622A0", VA = "0x1867638A0")]
	public KGHIPNJNGDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6763560", Offset = "0x6761F60", VA = "0x186763560", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, Vector4 BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x67631D0", Offset = "0x6761BD0", VA = "0x1867631D0", Slot = "5")]
	public Vector4 DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class ICHJFMKDOMA : DDBEBCOLMLO<Quaternion>, FBNOOOLMEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly BJBCIHBIFOH HKCNKHDKBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] HHKBMMBNKHG;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x675ADC0", Offset = "0x67597C0", VA = "0x18675ADC0")]
	public ICHJFMKDOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x675AA80", Offset = "0x6759480", VA = "0x18675AA80", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, Quaternion BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x675A6F0", Offset = "0x67590F0", VA = "0x18675A6F0", Slot = "5")]
	public Quaternion DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class FPLPENLNJCL : DDBEBCOLMLO<Color>, FBNOOOLMEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly BJBCIHBIFOH HKCNKHDKBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] HHKBMMBNKHG;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6750F10", Offset = "0x674F910", VA = "0x186750F10")]
	public FPLPENLNJCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6750BD0", Offset = "0x674F5D0", VA = "0x186750BD0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, Color BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6750840", Offset = "0x674F240", VA = "0x186750840", Slot = "5")]
	public Color DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OPGFECGIIIN : DDBEBCOLMLO<Bounds>, FBNOOOLMEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly BJBCIHBIFOH HKCNKHDKBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] HHKBMMBNKHG;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6768850", Offset = "0x6767250", VA = "0x186768850")]
	public OPGFECGIIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6768530", Offset = "0x6766F30", VA = "0x186768530", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, Bounds BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6768150", Offset = "0x6766B50", VA = "0x186768150", Slot = "5")]
	public Bounds DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class JHICMFLCJDH : DDBEBCOLMLO<Rect>, FBNOOOLMEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly BJBCIHBIFOH HKCNKHDKBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] HHKBMMBNKHG;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x675D6F0", Offset = "0x675C0F0", VA = "0x18675D6F0")]
	public JHICMFLCJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x675D380", Offset = "0x675BD80", VA = "0x18675D380", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, Rect BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x675CF90", Offset = "0x675B990", VA = "0x18675CF90", Slot = "5")]
	public Rect DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class KGHEIPNKLED : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private static class BNCLJCHLJFL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x481D460", Offset = "0x481BE60", VA = "0x18481D460")]
		static BNCLJCHLJFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private KGHEIPNKLED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class COJKNOGHDAN : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private static class AFECNIALHFP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3671C80", Offset = "0x3670680", VA = "0x183671C80")]
		static AFECNIALHFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class PBJIDECJMCA
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> OKIOMKACFBK;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6768A30", Offset = "0x6767430", VA = "0x186768A30")]
		internal static object LMPGABMOGAI(Type FIGFLJOONIE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private COJKNOGHDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class JMBGOLGGMEM : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class LIHMODGCKKP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3BDC0B0", Offset = "0x3BDAAB0", VA = "0x183BDC0B0")]
		static LIHMODGCKKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly JMBGOLGGMEM KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool PNCBPFEFFDH;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static FBNOOOLMEBG[] CAKEHDAMFII;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static ANMPFNBLBEK[] LHNDCAEENBB;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private JMBGOLGGMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x675DC40", Offset = "0x675C640", VA = "0x18675DC40")]
	public static void COHNJNIDPMK(params ANMPFNBLBEK[] LHNDCAEENBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x675DB60", Offset = "0x675C560", VA = "0x18675DB60")]
	public static void COHNJNIDPMK(params FBNOOOLMEBG[] CAKEHDAMFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x675DD20", Offset = "0x675C720", VA = "0x18675DD20")]
	public static void GNDBBCAAMKA(FBNOOOLMEBG[] CAKEHDAMFII, ANMPFNBLBEK[] LHNDCAEENBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class JLHLELNKLMG : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private static class HOGOGNGIEDN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x37903D0", Offset = "0x378EDD0", VA = "0x1837903D0")]
		static HOGOGNGIEDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private JLHLELNKLMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class OOFBIIJHJDG
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly ANMPFNBLBEK MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly ANMPFNBLBEK LDNCFAGBFEK;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly ANMPFNBLBEK HKDEKPGCIOL;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly ANMPFNBLBEK OFCBACONBJL;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly ANMPFNBLBEK PAPLCAPALFH;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly ANMPFNBLBEK DIANINIGMGG;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly ANMPFNBLBEK OEHODNIJCEA;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly ANMPFNBLBEK GHHGEBMFHCG;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly ANMPFNBLBEK INFPALGMHPN;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly ANMPFNBLBEK DMEOLEPHMNG;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly ANMPFNBLBEK OCIGPJPKKEE;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly ANMPFNBLBEK NMEJMIAPCJG;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class OKBMMKEKBJJ
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly ANMPFNBLBEK MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly ANMPFNBLBEK HIDAOPEPNBC;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class ADFBKNOCKJL
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly ANMPFNBLBEK MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly ANMPFNBLBEK LDNCFAGBFEK;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly ANMPFNBLBEK HKDEKPGCIOL;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly ANMPFNBLBEK OFCBACONBJL;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly ANMPFNBLBEK PAPLCAPALFH;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly ANMPFNBLBEK DIANINIGMGG;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly ANMPFNBLBEK OEHODNIJCEA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly ANMPFNBLBEK GHHGEBMFHCG;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly ANMPFNBLBEK INFPALGMHPN;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly ANMPFNBLBEK DMEOLEPHMNG;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly ANMPFNBLBEK OCIGPJPKKEE;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly ANMPFNBLBEK NMEJMIAPCJG;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class IEALOMDLGCL
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> OKIOMKACFBK;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x675B0F0", Offset = "0x6759AF0", VA = "0x18675B0F0")]
	internal static object LMPGABMOGAI(Type FIGFLJOONIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x675B0B0", Offset = "0x6759AB0", VA = "0x18675B0B0")]
	private static object ELLGAGCJCEA(Type JNIIIJOPDNL, Type[] EELBNGFIMDH, params object[] LLGOHLBKNDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class HOOLKGDDGAN : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private static class OIECODNKDCI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3F82EC0", Offset = "0x3F818C0", VA = "0x183F82EC0")]
		static OIECODNKDCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> DMAFOAINJEI;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool KLHNACMMOBG;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly KAHAJAMOGMJ COLAIMEIIEG;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x675A480", Offset = "0x6758E80", VA = "0x18675A480")]
	static HOOLKGDDGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private HOOLKGDDGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class HLKOBHLAOKA : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private static class LECJKIBGLDH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3BC5140", Offset = "0x3BC3B40", VA = "0x183BC5140")]
		static LECJKIBGLDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> DMAFOAINJEI;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool KLHNACMMOBG;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly KAHAJAMOGMJ COLAIMEIIEG;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x675A270", Offset = "0x6758C70", VA = "0x18675A270")]
	static HLKOBHLAOKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private HLKOBHLAOKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class BJOLAJBFGLL : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private static class JDOIDLCGEDH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x39F6BF0", Offset = "0x39F55F0", VA = "0x1839F6BF0")]
		static JDOIDLCGEDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> DMAFOAINJEI;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool KLHNACMMOBG;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly KAHAJAMOGMJ COLAIMEIIEG;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x674EE90", Offset = "0x674D890", VA = "0x18674EE90")]
	static BJOLAJBFGLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private BJOLAJBFGLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class HGNKOKDMHCN : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private static class HPIPCBNFCBB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3796F10", Offset = "0x3795910", VA = "0x183796F10")]
		static HPIPCBNFCBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> DMAFOAINJEI;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool KLHNACMMOBG;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly KAHAJAMOGMJ COLAIMEIIEG;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x675A100", Offset = "0x6758B00", VA = "0x18675A100")]
	static HGNKOKDMHCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private HGNKOKDMHCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class OEPJDHOBMPN : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class MFBKKPFLKJG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3DD4C00", Offset = "0x3DD3600", VA = "0x183DD4C00")]
		static MFBKKPFLKJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> DMAFOAINJEI;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool KLHNACMMOBG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly KAHAJAMOGMJ COLAIMEIIEG;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6767A70", Offset = "0x6766470", VA = "0x186767A70")]
	static OEPJDHOBMPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private OEPJDHOBMPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class BOALIIOHLHG : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private static class PELGFGEAJMP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x407DAE0", Offset = "0x407C4E0", VA = "0x18407DAE0")]
		static PELGFGEAJMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> DMAFOAINJEI;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool KLHNACMMOBG;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly KAHAJAMOGMJ COLAIMEIIEG;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x674F000", Offset = "0x674DA00", VA = "0x18674F000")]
	static BOALIIOHLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private BOALIIOHLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class NIDLBCLBNJC : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private static class BLEDNNDMEDD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x480E500", Offset = "0x480CF00", VA = "0x18480E500")]
		static BLEDNNDMEDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> DMAFOAINJEI;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool KLHNACMMOBG;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public NIDLBCLBNJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal sealed class JLEKACBLDKG : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private static class KCIIADBPPBP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3ACAC70", Offset = "0x3AC9670", VA = "0x183ACAC70")]
		static KCIIADBPPBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> DMAFOAINJEI;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool KLHNACMMOBG;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public JLEKACBLDKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal sealed class ABCIIEBFDIE : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private static class BOEDOHAFMHD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4901380", Offset = "0x48FFD80", VA = "0x184901380")]
		static BOEDOHAFMHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> DMAFOAINJEI;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool KLHNACMMOBG;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public ABCIIEBFDIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class IBOJKKNIEFM : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private static class ALOMOBNAJKG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x389F3A0", Offset = "0x389DDA0", VA = "0x18389F3A0")]
		static ALOMOBNAJKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> DMAFOAINJEI;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool KLHNACMMOBG;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public IBOJKKNIEFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class GFBMNGMDLIJ : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private static class LIIPKNIDLDA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3BE96F0", Offset = "0x3BE80F0", VA = "0x183BE96F0")]
		static LIIPKNIDLDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> DMAFOAINJEI;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool KLHNACMMOBG;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public GFBMNGMDLIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class NBOOIAKPLPN : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private static class PCANJAEBGHM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x405DFE0", Offset = "0x405C9E0", VA = "0x18405DFE0")]
		static PCANJAEBGHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> DMAFOAINJEI;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool KLHNACMMOBG;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public NBOOIAKPLPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class GELBJLCJNEN
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct HIJLOIOMMKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public IIBLGMJIKDB FGDCKPGJMML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder DADGKPHIJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder KJJLPIOOLNL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal static class KADILFGIAGG
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		internal static class ADPAAKOBHFM
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo KAEEFDJNACI;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo FJAGPMNDMJA;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo JKKAGMDICJJ;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo MGABBJBMNMC;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo DCMKLMGDHOH;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo FDNNIFBFLJE;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo KJOOPLHGIDA;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo FKFNNFCAMBH;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo PINDDPCNMJN;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x676C950", Offset = "0x676B350", VA = "0x18676C950")]
			static ADPAAKOBHFM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		internal static class CNPKHBDBLIE
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo EMBNAAHCENM;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo OMMHDECEIPC;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo BIKFMBMGBEC;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo AJNLMNHFDID;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo IEKPLLPJPJC;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo FPLPBDAHDKA;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo NLPOEACOFOA;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x6770800", Offset = "0x676F200", VA = "0x186770800")]
			static CNPKHBDBLIE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		internal static class ODIFGGGEKIG
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo FLHCAHLGLNE;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo KJPOKJGCILN;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo LGIABAODCIF;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo OFKKDEJPALE;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo LABKAMHIOEE;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo AFKJNOFMFCP;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo PCBJHGDNALM;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo OPDHGJMMJPH;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo NPGMKLIPHJN;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo OKJHHMDGNDO;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo AMCGDNMKPJP;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo LGFGKCPEKEJ;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo IGAFJAOHNCI;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo DHDLDIGFGOL;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x675E310", Offset = "0x675CD10", VA = "0x18675E310")]
		public static MethodInfo JLKDILEIJOC(Type AKDFFJNHJJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x675E0D0", Offset = "0x675CAD0", VA = "0x18675E0D0")]
		public static MethodInfo DCJJDHFPDEL(Type AKDFFJNHJJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x675E5A0", Offset = "0x675CFA0", VA = "0x18675E5A0")]
		public static MethodInfo NIMOGDPKKAA(Type AKDFFJNHJJN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class JMGFBDHLMED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<IIBLGMJIKDB, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public JMGFBDHLMED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class OGHDOJIDIDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public JMGFBDHLMED CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public OGHDOJIDIDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x677D3E0", Offset = "0x677BDE0", VA = "0x18677D3E0")]
		internal void FHOLOIBLOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x677D4E0", Offset = "0x677BEE0", VA = "0x18677D4E0")]
		internal bool LELKJJCCHKI(int index, IIBLGMJIKDB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class JKOIJEDGLPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public JMGFBDHLMED CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public JKOIJEDGLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6777140", Offset = "0x6775B40", VA = "0x186777140")]
		internal bool DCGEDGBDBIG(int index, IIBLGMJIKDB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class DHJJIBJGHDG
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

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public DHJJIBJGHDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x322ECB0", Offset = "0x322D6B0", VA = "0x18322ECB0")]
		internal string FLFFLOOKMNF(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class BCBCPLNGCFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public BCBCPLNGCFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x676E470", Offset = "0x676CE70", VA = "0x18676E470")]
		internal bool KCPAEIEJBKB(IIBLGMJIKDB x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class MDMBNMFJMBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public DHJJIBJGHDG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public MDMBNMFJMBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x677BD70", Offset = "0x677A770", VA = "0x18677BD70")]
		internal void NJJOKOINPNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x677BB90", Offset = "0x677A590", VA = "0x18677BB90")]
		internal bool KHDOBBNIKIN(int index, IIBLGMJIKDB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class DIPMNDLLPJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public DHJJIBJGHDG CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public DIPMNDLLPJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6771AD0", Offset = "0x67704D0", VA = "0x186771AD0")]
		internal bool BLIHNCBHOEL(int index, IIBLGMJIKDB member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class MALMOPOONPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public MALMOPOONPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x67723A0", Offset = "0x6770DA0", VA = "0x1867723A0")]
		internal Label AGKILNFMHNN(IIBLGMJIKDB _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class JJGGLGLFHFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public HIJLOIOMMKE[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, IIBLGMJIKDB, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public NAANEMKAPGB argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public NAANEMKAPGB argResolver;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public JJGGLGLFHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6777020", Offset = "0x6775A20", VA = "0x186777020")]
		internal HIJLOIOMMKE DKDNKLNKFIM(IIBLGMJIKDB item)
		{
			return default(HIJLOIOMMKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class NCNEEJACPEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public JJGGLGLFHFD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public NCNEEJACPEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x677C7D0", Offset = "0x677B1D0", VA = "0x18677C7D0")]
		internal void CNFCDNEDHII(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x677CA80", Offset = "0x677B480", VA = "0x18677CA80")]
		internal void KJIKAHCJGGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class PNDHILPHPPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public IIBLGMJIKDB item;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public PNDHILPHPPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xB2FCF0", Offset = "0xB2E6F0", VA = "0x180B2FCF0")]
		internal bool HGEIOGPPAAL(HIJLOIOMMKE x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class PDFGMKOPANF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public IIBLGMJIKDB item;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public PDFGMKOPANF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xB2FCF0", Offset = "0xB2E6F0", VA = "0x180B2FCF0")]
		internal bool IPFJOLPIKJG(HIJLOIOMMKE x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex EOCPIKJDLDJ;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int DAMKFBBHJJN;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> LFCBCMJDCDC;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> NGIKADMACFD;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x25F3EB0", Offset = "0x25F28B0", VA = "0x1825F3EB0")]
	public static object GLCLJGOCFKG<T>(KAHAJAMOGMJ COLAIMEIIEG, ANMPFNBLBEK ABEHEMGONNP, Func<string, string> DMAFOAINJEI, bool KLHNACMMOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2603B90", Offset = "0x2602590", VA = "0x182603B90")]
	public static object LBGIIJAFBLA<T>(ANMPFNBLBEK ABEHEMGONNP, Func<string, string> DMAFOAINJEI, bool KLHNACMMOBG, bool BFCNMKNFGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x67518C0", Offset = "0x67502C0", VA = "0x1867518C0")]
	private static TypeInfo AIDKOFHEONE(KAHAJAMOGMJ COLAIMEIIEG, Type AKDFFJNHJJN, Func<string, string> DMAFOAINJEI, bool KLHNACMMOBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x67530F0", Offset = "0x6751AF0", VA = "0x1867530F0")]
	public static object CFNLJPLDOCP(Type AKDFFJNHJJN, Func<string, string> DMAFOAINJEI, bool KLHNACMMOBG, bool BFCNMKNFGKE, bool FDMOLKLNENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x67529C0", Offset = "0x67513C0", VA = "0x1867529C0")]
	private static Dictionary<IIBLGMJIKDB, FieldInfo> BHCENDDFKEE(TypeBuilder MDNCGHAEJJB, KOCLCOELKID PHOANEONLCI, ConstructorInfo HPFAEJLAJGE, FieldBuilder ENIGCHFDMND, ILGenerator ENIFMHFILGH, bool KLHNACMMOBG, bool JKIMEGMLHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x67522E0", Offset = "0x6750CE0", VA = "0x1867522E0")]
	private static Dictionary<IIBLGMJIKDB, FieldInfo> BCFKDNLKOCP(TypeBuilder MDNCGHAEJJB, KOCLCOELKID PHOANEONLCI, ILGenerator ENIFMHFILGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6755EF0", Offset = "0x67548F0", VA = "0x186755EF0")]
	private static void JOBPBHPIJIL(Type AKDFFJNHJJN, KOCLCOELKID PHOANEONLCI, ILGenerator ENIFMHFILGH, Action BEBPGEHKDBL, Func<int, IIBLGMJIKDB, bool> BMFLLOJCHLH, bool KLHNACMMOBG, bool JKIMEGMLHDC, int JAJLIBIEBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x67559B0", Offset = "0x67543B0", VA = "0x1867559B0")]
	private static void JEKKNHGKPLP(TypeInfo AKDFFJNHJJN, IIBLGMJIKDB DLAGGDNDBCJ, ILGenerator ENIFMHFILGH, int BNALCEABILL, Func<int, IIBLGMJIKDB, bool> BMFLLOJCHLH, NAANEMKAPGB HAMBOEKDHKF, NAANEMKAPGB HKIAFBFOHDI, NAANEMKAPGB PHLFKGJBPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x67579A0", Offset = "0x67563A0", VA = "0x1867579A0")]
	private static void MJDHOFLOPKC(Type AKDFFJNHJJN, KOCLCOELKID PHOANEONLCI, ILGenerator ENIFMHFILGH, Func<int, IIBLGMJIKDB, bool> BMFLLOJCHLH, bool LBODMABIJDP, int JAJLIBIEBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6757530", Offset = "0x6755F30", VA = "0x186757530")]
	private static void LIHADOFNFDB(ILGenerator ENIFMHFILGH, HIJLOIOMMKE PHOANEONLCI, int BNALCEABILL, Func<int, IIBLGMJIKDB, bool> BMFLLOJCHLH, NAANEMKAPGB HPEAJCENMCM, NAANEMKAPGB PHLFKGJBPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6754C20", Offset = "0x6753620", VA = "0x186754C20")]
	private static LocalBuilder DEIGCDACOFJ(ILGenerator ENIFMHFILGH, Type AKDFFJNHJJN, KOCLCOELKID PHOANEONLCI, HIJLOIOMMKE[] PIKLNBHDFPI, bool OKDFJMCNDIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6758E50", Offset = "0x6757850", VA = "0x186758E50")]
	private static bool NMMNHPEHBIE(ConstructorInfo JAOLNBCFMIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6758CD0", Offset = "0x67576D0", VA = "0x186758CD0")]
	private static bool NDFBDGPANHF(Type AKDFFJNHJJN, [Out] Type MEGLIPCBHOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal delegate void KEOOLIFFFHL<T>(byte[][] ENIGCHFDMND, object[] OGNADDPEHBG, FDFEMMJJDAL HAMBOEKDHKF, T BEEGCHJLJFC, ANMPFNBLBEK AOENFBDLBDF);
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal delegate T DABLPMNHADC<T>(object[] OGNADDPEHBG, KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK AOENFBDLBDF);
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class ACEDPFFGIDH<T> : DDBEBCOLMLO<T>, FBNOOOLMEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly byte[][] ENIGCHFDMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly object[] EFHEEPKDEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly object[] PFDIEBLCDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly KEOOLIFFFHL<T> LPILABDHKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly DABLPMNHADC<T> LCFOFMCMDPF;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4F90", Offset = "0x1CF3990", VA = "0x181CF4F90")]
	public ACEDPFFGIDH(byte[][] ENIGCHFDMND, object[] EFHEEPKDEEG, object[] PFDIEBLCDMH, KEOOLIFFFHL<T> LPILABDHKEL, DABLPMNHADC<T> LCFOFMCMDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3649F40", Offset = "0x3648940", VA = "0x183649F40", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, T BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3649E50", Offset = "0x3648850", VA = "0x183649E50", Slot = "5")]
	public T DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class AFGCGINNOEC : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private static class IILNMIJKFPN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x383E320", Offset = "0x383CD20", VA = "0x18383E320")]
		static IILNMIJKFPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private AFGCGINNOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class JOBFLBPIJJH : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private static class KCANIBODJCC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD670", Offset = "0x3AAC070", VA = "0x183AAD670")]
		static KCANIBODJCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private JOBFLBPIJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal static class AGFMECDHGKM
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	internal static readonly ANMPFNBLBEK[] INNHEPPEAKB;
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class HIOMHLAPJNI : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class OPKIHPHDEEK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3FCC030", Offset = "0x3FCAA30", VA = "0x183FCC030")]
		static OPKIHPHDEEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class FAAANBFPNEO : ANMPFNBLBEK
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		private static class ICCMDOKADBJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3817F10", Offset = "0x3816910", VA = "0x183817F10")]
			static ICCMDOKADBJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly ANMPFNBLBEK KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly ANMPFNBLBEK[] LHNDCAEENBB;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		private FAAANBFPNEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
		public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly DDBEBCOLMLO<object> DIELAPKECID;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private HIOMHLAPJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class LAFCOJKJIKF : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private static class KDLMMFLBKIJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3ACF190", Offset = "0x3ACDB90", VA = "0x183ACF190")]
		static KDLMMFLBKIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class EIOKHGMAHNG : ANMPFNBLBEK
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		private static class CFKEBMIAIHF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x4AFD080", Offset = "0x4AFBA80", VA = "0x184AFD080")]
			static CFKEBMIAIHF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly ANMPFNBLBEK KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly ANMPFNBLBEK[] LHNDCAEENBB;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		private EIOKHGMAHNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
		public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly DDBEBCOLMLO<object> DIELAPKECID;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private LAFCOJKJIKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal sealed class GFELMMAOBKE : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private static class LPKKDOCNCHH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3BFB350", Offset = "0x3BF9D50", VA = "0x183BFB350")]
		static LPKKDOCNCHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class JPLHMDHIBMO : ANMPFNBLBEK
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private static class EDNJOHFLBLJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x323D570", Offset = "0x323BF70", VA = "0x18323D570")]
			static EDNJOHFLBLJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly ANMPFNBLBEK KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly ANMPFNBLBEK[] LHNDCAEENBB;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		private JPLHMDHIBMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
		public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly DDBEBCOLMLO<object> DIELAPKECID;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private GFELMMAOBKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal sealed class IHOAEHODJMH : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private static class NDPHPAEAICG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3E3DF30", Offset = "0x3E3C930", VA = "0x183E3DF30")]
		static NDPHPAEAICG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class PGKNDKANBJP : ANMPFNBLBEK
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		private static class KCEJEFIDKHC<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3ABB020", Offset = "0x3AB9A20", VA = "0x183ABB020")]
			static KCEJEFIDKHC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly ANMPFNBLBEK KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static readonly ANMPFNBLBEK[] LHNDCAEENBB;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		private PGKNDKANBJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
		public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly DDBEBCOLMLO<object> DIELAPKECID;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private IHOAEHODJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class FBHCGLMCDBO : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private static class FENOANGJGGI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x35B91D0", Offset = "0x35B7BD0", VA = "0x1835B91D0")]
		static FENOANGJGGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class CBBKLDAHKPD : ANMPFNBLBEK
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		private static class IDDBAHOADJA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x381C6A0", Offset = "0x381B0A0", VA = "0x18381C6A0")]
			static IDDBAHOADJA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly ANMPFNBLBEK KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly ANMPFNBLBEK[] LHNDCAEENBB;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		private CBBKLDAHKPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
		public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly DDBEBCOLMLO<object> DIELAPKECID;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private FBHCGLMCDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class BFDBPGIPEPI : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private static class LCIGOGPINDI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3BBEB20", Offset = "0x3BBD520", VA = "0x183BBEB20")]
		static LCIGOGPINDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private sealed class KJJOJPGGIGF : ANMPFNBLBEK
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		private static class BIAANFLPDNF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x4725830", Offset = "0x4724230", VA = "0x184725830")]
			static BIAANFLPDNF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly ANMPFNBLBEK KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly ANMPFNBLBEK[] LHNDCAEENBB;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		private KJJOJPGGIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
		public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly DDBEBCOLMLO<object> DIELAPKECID;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private BFDBPGIPEPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal sealed class PADBKFICEGL : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private static class HCCDEIOIDCE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x36E8940", Offset = "0x36E7340", VA = "0x1836E8940")]
		static HCCDEIOIDCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private sealed class MHDBAIAOGEJ : ANMPFNBLBEK
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		private static class IACJJNJEFKL<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x380FD00", Offset = "0x380E700", VA = "0x18380FD00")]
			static IACJJNJEFKL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly ANMPFNBLBEK KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly ANMPFNBLBEK[] LHNDCAEENBB;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		private MHDBAIAOGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
		public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly DDBEBCOLMLO<object> DIELAPKECID;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private PADBKFICEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal sealed class IJHJFANOODJ : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private static class EDJFFIPJENE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3239730", Offset = "0x3238130", VA = "0x183239730")]
		static EDJFFIPJENE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	private sealed class CFNJBDAPCKK : ANMPFNBLBEK
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private static class PCLDPFGKBLH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x4064600", Offset = "0x4063000", VA = "0x184064600")]
			static PCLDPFGKBLH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly ANMPFNBLBEK KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly ANMPFNBLBEK[] LHNDCAEENBB;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		private CFNJBDAPCKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
		public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly DDBEBCOLMLO<object> DIELAPKECID;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private IJHJFANOODJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal sealed class EFPMJENBJHD : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private static class NEBDLNIAEIO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3E46070", Offset = "0x3E44A70", VA = "0x183E46070")]
		static NEBDLNIAEIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private sealed class DJGCGAAFMPH : ANMPFNBLBEK
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		private static class EKKEMBBEDBB<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x325D2F0", Offset = "0x325BCF0", VA = "0x18325D2F0")]
			static EKKEMBBEDBB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly ANMPFNBLBEK KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static readonly ANMPFNBLBEK[] LHNDCAEENBB;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		private DJGCGAAFMPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
		public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly DDBEBCOLMLO<object> DIELAPKECID;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private EFPMJENBJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal sealed class NHKGBEJKECK : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private static class GGIINKDAAFG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x36A30D0", Offset = "0x36A1AD0", VA = "0x1836A30D0")]
		static GGIINKDAAFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private sealed class BNGCIIHMBNL : ANMPFNBLBEK
	{
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		private static class KJFKLMAOLOJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x3AE7360", Offset = "0x3AE5D60", VA = "0x183AE7360")]
			static KJFKLMAOLOJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly ANMPFNBLBEK KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly ANMPFNBLBEK[] LHNDCAEENBB;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		private BNGCIIHMBNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
		public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly DDBEBCOLMLO<object> DIELAPKECID;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private NHKGBEJKECK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
internal sealed class AMPIMDIBNCA : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private static class FCCNNODIDII<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x35A9E30", Offset = "0x35A8830", VA = "0x1835A9E30")]
		static FCCNNODIDII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private sealed class GCIAJCJBPKG : ANMPFNBLBEK
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		private static class DLKGPELJAHM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x4F70E00", Offset = "0x4F6F800", VA = "0x184F70E00")]
			static DLKGPELJAHM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly ANMPFNBLBEK KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private static readonly ANMPFNBLBEK[] LHNDCAEENBB;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		private GCIAJCJBPKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
		public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly DDBEBCOLMLO<object> DIELAPKECID;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private AMPIMDIBNCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
internal sealed class INKLLLEFEEE : ANMPFNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private static class AEKNPOMLMMB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3667F00", Offset = "0x3666900", VA = "0x183667F00")]
		static AEKNPOMLMMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private sealed class ELIBBMCMHIP : ANMPFNBLBEK
	{
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		private static class KMELPJJJKAE<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public static readonly DDBEBCOLMLO<T> IGCOCGIIGFD;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3B41080", Offset = "0x3B3FA80", VA = "0x183B41080")]
			static KMELPJJJKAE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly ANMPFNBLBEK KHPIFBDMEAA;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly ANMPFNBLBEK[] LHNDCAEENBB;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		private ELIBBMCMHIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
		public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly ANMPFNBLBEK KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly DDBEBCOLMLO<object> DIELAPKECID;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	private INKLLLEFEEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	public DDBEBCOLMLO<T> LMPGABMOGAI<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct AIJEJDOJOPD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public T[] KLMGNBJAMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int DGFKKGBDDGJ;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x367AC00", Offset = "0x3679600", VA = "0x18367AC00")]
	public AIJEJDOJOPD(int DPJNPPKPAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x367A800", Offset = "0x3679200", VA = "0x18367A800")]
	public void DGLLAPEBOKO(T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x367AB70", Offset = "0x3679570", VA = "0x18367AB70")]
	public T[] HPCMCMAADAP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal sealed class GHBGIOPEBOO : IMIDHINJNJM<byte>
{
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly GHBGIOPEBOO MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6773C50", Offset = "0x6772650", VA = "0x186773C50")]
	public GHBGIOPEBOO(int GNDDNLBKAJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class IMIDHINJNJM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly int GNDDNLBKAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly object ABNFGEAMCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int BNALCEABILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private T[][] DAGOFNGOFLA;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x384BC60", Offset = "0x384A660", VA = "0x18384BC60")]
	public IMIDHINJNJM(int GNDDNLBKAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849FA0", VA = "0x18384B5A0")]
	public T[] OADNAIHFJOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x384AFA0", Offset = "0x38499A0", VA = "0x18384AFA0")]
	public void MCNIAAFIKCL(T[] BHNHFMPCKPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class BJBCIHBIFOH : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private class LOIOMFKILEA : IComparable<LOIOMFKILEA>
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class KMHHDKKHFBC : IEnumerable<LOIOMFKILEA>, IEnumerable, IEnumerator<LOIOMFKILEA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private LOIOMFKILEA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public LOIOMFKILEA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private LOIOMFKILEA System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x930310", Offset = "0x92ED10", VA = "0x180930310")]
			[DebuggerHidden]
			public KMHHDKKHFBC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x67784F0", Offset = "0x6776EF0", VA = "0x1867784F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6778620", Offset = "0x6777020", VA = "0x186778620", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x6778570", Offset = "0x6776F70", VA = "0x186778570", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<LOIOMFKILEA> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x6778570", Offset = "0x6776F70", VA = "0x186778570", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class EPCFEAHKJFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public EPCFEAHKJFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x67723A0", Offset = "0x6770DA0", VA = "0x1867723A0")]
			internal Label FAJNJHDLHBP(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x67723A0", Offset = "0x6770DA0", VA = "0x1867723A0")]
			internal Label HPOHFNCEJKL(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly LOIOMFKILEA[] PFNDOPEOBCN;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly ulong[] JHPLLBGDGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public ulong MEIMJOBMJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int BMLGNHJJEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public string AHECEOIIMCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private LOIOMFKILEA[] IGGDIHDNDLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private ulong[] CEAHCMGPKJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int MPNHPMPEEBM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool EDCDLIJNKIG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x52187A0", Offset = "0x52171A0", VA = "0x1852187A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x677BAD0", Offset = "0x677A4D0", VA = "0x18677BAD0")]
		public LOIOMFKILEA(ulong FHLJKJHFEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x677A4D0", Offset = "0x6778ED0", VA = "0x18677A4D0")]
		public LOIOMFKILEA DGLLAPEBOKO(ulong FHLJKJHFEEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x677A6D0", Offset = "0x67790D0", VA = "0x18677A6D0")]
		public LOIOMFKILEA DGLLAPEBOKO(ulong FHLJKJHFEEK, int BEEGCHJLJFC, string AHECEOIIMCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x677A7B0", Offset = "0x67791B0", VA = "0x18677A7B0")]
		public LOIOMFKILEA EJJHDALHOCJ(byte[] PGDPOBPBAKL, int IACEHNBBCDL, int JHPIDPMDDIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x677ACB0", Offset = "0x67796B0", VA = "0x18677ACB0")]
		internal static int HBKDIJHEHOG(ulong[] BHNHFMPCKPL, int BNALCEABILL, int FJADIACPEIM, ulong BEEGCHJLJFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x677A4A0", Offset = "0x6778EA0", VA = "0x18677A4A0", Slot = "4")]
		public int CompareTo(LOIOMFKILEA CGDFJMJIABO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x677A730", Offset = "0x6779130", VA = "0x18677A730")]
		[IteratorStateMachine(typeof(KMHHDKKHFBC))]
		public IEnumerable<LOIOMFKILEA> DJIOMLLGONO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x677A930", Offset = "0x6779330", VA = "0x18677A930")]
		public void GJLKOFGHOKN(ILGenerator ENIFMHFILGH, LocalBuilder PGDPOBPBAKL, LocalBuilder JHPIDPMDDIF, LocalBuilder FHLJKJHFEEK, Action<KeyValuePair<string, int>> LBEDBDNLHFF, Action HDPOOECPJKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x677AD40", Offset = "0x6779740", VA = "0x18677AD40")]
		private static void KEEDAHAOAHG(ILGenerator ENIFMHFILGH, LocalBuilder PGDPOBPBAKL, LocalBuilder JHPIDPMDDIF, LocalBuilder FHLJKJHFEEK, Action<KeyValuePair<string, int>> LBEDBDNLHFF, Action HDPOOECPJKJ, LOIOMFKILEA[] IGGDIHDNDLI, int MPNHPMPEEBM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class JGJMHNLPFDM : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
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
		private IEnumerable<LOIOMFKILEA> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public IEnumerable<LOIOMFKILEA> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IEnumerator<LOIOMFKILEA> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private LOIOMFKILEA <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xA30D40", Offset = "0xA2F740", VA = "0x180A30D40", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x6776E80", Offset = "0x6775880", VA = "0x186776E80", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1C13C70", Offset = "0x1C12670", VA = "0x181C13C70")]
		[DebuggerHidden]
		public JGJMHNLPFDM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6776ED0", Offset = "0x67758D0", VA = "0x186776ED0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x67768D0", Offset = "0x67752D0", VA = "0x1867768D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6776D30", Offset = "0x6775730", VA = "0x186776D30")]
		private void OEKMCAOJCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6776880", Offset = "0x6775280", VA = "0x186776880")]
		private void ILPGDGAIKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6776E30", Offset = "0x6775830", VA = "0x186776E30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6776D80", Offset = "0x6775780", VA = "0x186776D80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6776D80", Offset = "0x6775780", VA = "0x186776D80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly LOIOMFKILEA AJBLHMMPNNM;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x676EDD0", Offset = "0x676D7D0", VA = "0x18676EDD0")]
	public BJBCIHBIFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x676E760", Offset = "0x676D160", VA = "0x18676E760")]
	public void DGLLAPEBOKO(byte[] MCPLLDADFCM, int BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x676E870", Offset = "0x676D270", VA = "0x18676E870")]
	public bool EJNFBAFBKDN(ArraySegment<byte> FHLJKJHFEEK, [Out] int BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x676ED40", Offset = "0x676D740", VA = "0x18676ED40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x676E9B0", Offset = "0x676D3B0", VA = "0x18676E9B0")]
	private static void KJDFCDABOEC(IEnumerable<LOIOMFKILEA> IGGDIHDNDLI, StringBuilder ICAJAMAALEK, int LADDFEBDKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x676E950", Offset = "0x676D350", VA = "0x18676E950", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x676E950", Offset = "0x676D350", VA = "0x18676E950", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x676ECC0", Offset = "0x676D6C0", VA = "0x18676ECC0")]
	[IteratorStateMachine(typeof(JGJMHNLPFDM))]
	private static IEnumerable<KeyValuePair<string, int>> PDCKGAOGKCO(IEnumerable<LOIOMFKILEA> IGGDIHDNDLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x676EC90", Offset = "0x676D690", VA = "0x18676EC90")]
	public void OOEDIGJCCDM(ILGenerator ENIFMHFILGH, LocalBuilder PGDPOBPBAKL, LocalBuilder JHPIDPMDDIF, LocalBuilder FHLJKJHFEEK, Action<KeyValuePair<string, int>> LBEDBDNLHFF, Action HDPOOECPJKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class OPCBOKEDPOO
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly MethodInfo DAHEMDADIDM;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x677D640", Offset = "0x677C040", VA = "0x18677D640")]
	public static ulong PMBGDBCIODA(byte[] MCPLLDADFCM, int IACEHNBBCDL, int JHPIDPMDDIF)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class NDJNHEENJJN
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x677CD70", Offset = "0x677B770", VA = "0x18677CD70")]
	public static void KMEDPOMMBKE(byte[] MCPLLDADFCM, int IACEHNBBCDL, int CBNDICJKPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x677CC50", Offset = "0x677B650", VA = "0x18677CC50")]
	public static void DFDAAMOOGEN(byte[] BHNHFMPCKPL, int CNMCHNAHALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x677CB20", Offset = "0x677B520", VA = "0x18677CB20")]
	public static byte[] DCOMGCKKKIF(byte[] MHLOJABNACB, int CNMCHNAHALL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public static class KLHDICINHDC
{
	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6778480", Offset = "0x6776E80", VA = "0x186778480")]
	public static bool LFJLPCHEDBG(byte[] EKPJHPPBJBI, int PMLIPGLMIKM, int NJKJIKJBJFP, byte[] KPLLKDLPADD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal class BDNCKLJABPP<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private struct AKDDHPCKJIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public byte[] MEIMJOBMJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T BMLGNHJJEIP;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3773260", Offset = "0x3771C60", VA = "0x183773260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class PJPMFKGFGMA : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public BDNCKLJABPP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private AKDDHPCKJIF[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private AKDDHPCKJIF[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xA30D40", Offset = "0xA2F740", VA = "0x180A30D40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x35E78B0", Offset = "0x35E62B0", VA = "0x1835E78B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public PJPMFKGFGMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x409A990", Offset = "0x4099390", VA = "0x18409A990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x409AC30", Offset = "0x4099630", VA = "0x18409AC30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly AKDDHPCKJIF[][] JCGFCHKGAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly ulong PBNHHHPPIKK;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x47076F0", Offset = "0x47060F0", VA = "0x1847076F0")]
	public BDNCKLJABPP(int HCAPAJGPPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4707710", Offset = "0x4706110", VA = "0x184707710")]
	public BDNCKLJABPP(int HCAPAJGPPGD, float CPIEOBHHFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4700E50", Offset = "0x46FF850", VA = "0x184700E50")]
	public void DGLLAPEBOKO(byte[] FHLJKJHFEEK, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x46FC3F0", Offset = "0x46FADF0", VA = "0x1846FC3F0")]
	private bool AHIDOEDLLBL(byte[] FHLJKJHFEEK, T BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4705370", Offset = "0x4703D70", VA = "0x184705370")]
	public bool GFGJHMKHGPD(ArraySegment<byte> FHLJKJHFEEK, [Out] T BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x47076A0", Offset = "0x47060A0", VA = "0x1847076A0")]
	private static ulong ONNDGHHFJCH(byte[] MGCANBJCGMI, int IACEHNBBCDL, int MPNHPMPEEBM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3A4ABD0", Offset = "0x3A495D0", VA = "0x183A4ABD0")]
	private static int LMKKJMAKPME(int KBIHLEOLBHA, float CPIEOBHHFGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4707460", Offset = "0x4705E60", VA = "0x184707460", Slot = "4")]
	[IteratorStateMachine(typeof(BDNCKLJABPP<>.PJPMFKGFGMA))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x334D350", Offset = "0x334BD50", VA = "0x18334D350", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class APHGGNPKKPM : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly OpCode[] CGDICOIMHJL;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly OpCode[] KKMAFFEAGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int EODODGPKJMO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool EEDNKIHCLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x676E030", Offset = "0x676CA30", VA = "0x18676E030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x676E180", Offset = "0x676CB80", VA = "0x18676E180")]
	static APHGGNPKKPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x676E3E0", Offset = "0x676CDE0", VA = "0x18676E3E0")]
	public APHGGNPKKPM(byte[] FDBMKIPGEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x676E080", Offset = "0x676CA80", VA = "0x18676E080")]
	public OpCode KIIPCKADHLK()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct PMPNNDCNFBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly Guid BMLGNHJJEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte HIACMNILLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte NENIAICOAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte MJJNBOMGLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte CPDGOIHFNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte FJEAMBOIAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte PKOFANBKKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte OGAAHNOJAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte FAFJCMFIEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte CPCKNHEGLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte JEJFIAAMMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte CDPEGHBACEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public readonly byte CNHLFLBMOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public readonly byte ILCMINKGBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public readonly byte HPFLFCIEHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public readonly byte BDBBMKBOOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public readonly byte NONGIIDAEBA;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static byte[] LJFOADLPFHG;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static byte[] OIIFINEKHHK;

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6783120", Offset = "0x6781B20", VA = "0x186783120")]
	public PMPNNDCNFBM(Guid BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x67819D0", Offset = "0x67803D0", VA = "0x1867819D0")]
	public PMPNNDCNFBM(ArraySegment<byte> JIMLKMHAHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6780A70", Offset = "0x677F470", VA = "0x186780A70")]
	private static byte CODMCKAHHOE(byte[] MCPLLDADFCM, int OOAMPEDEEOL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6780B10", Offset = "0x677F510", VA = "0x186780B10")]
	private static byte HGIFCCPCEHE(byte OIKFNBPLIOK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6780C30", Offset = "0x677F630", VA = "0x186780C30")]
	public void MEADCPKNNFG(byte[] LMJJBGCJLAL, int IACEHNBBCDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class ACJKKOBLEKF
{
	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x676BC00", Offset = "0x676A600", VA = "0x18676BC00")]
	public static bool HKPDGNPMNDD(byte BDAHFBGOEJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x676C410", Offset = "0x676AE10", VA = "0x18676C410")]
	public static bool JODMLFLCDFE(byte BDAHFBGOEJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x676C330", Offset = "0x676AD30", VA = "0x18676C330")]
	public static sbyte JIJHNEAJCHA(byte[] MCPLLDADFCM, int IACEHNBBCDL, [Out] int GAIKAPABOAG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x676C520", Offset = "0x676AF20", VA = "0x18676C520")]
	public static short NHCPIDGPGKI(byte[] MCPLLDADFCM, int IACEHNBBCDL, [Out] int GAIKAPABOAG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x676B930", Offset = "0x676A330", VA = "0x18676B930")]
	public static int AKJOCKHBLAG(byte[] MCPLLDADFCM, int IACEHNBBCDL, [Out] int GAIKAPABOAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x676C480", Offset = "0x676AE80", VA = "0x18676C480")]
	public static long LPPEKNIJNMI(byte[] MCPLLDADFCM, int IACEHNBBCDL, [Out] int GAIKAPABOAG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x676BB10", Offset = "0x676A510", VA = "0x18676BB10")]
	public static byte EHHHKOLIIDJ(byte[] MCPLLDADFCM, int IACEHNBBCDL, [Out] int GAIKAPABOAG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x676C2B0", Offset = "0x676ACB0", VA = "0x18676C2B0")]
	public static ushort IDPGOJFOFHF(byte[] MCPLLDADFCM, int IACEHNBBCDL, [Out] int GAIKAPABOAG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x676BA20", Offset = "0x676A420", VA = "0x18676BA20")]
	public static uint CBHNBAAEOOG(byte[] MCPLLDADFCM, int IACEHNBBCDL, [Out] int GAIKAPABOAG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x676C840", Offset = "0x676B240", VA = "0x18676C840")]
	public static ulong OFDCMCFIEJM(byte[] MCPLLDADFCM, int IACEHNBBCDL, [Out] int GAIKAPABOAG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x676BB90", Offset = "0x676A590", VA = "0x18676BB90")]
	public static float FOPNHOCDDHO(byte[] MCPLLDADFCM, int IACEHNBBCDL, [Out] int GAIKAPABOAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x676BAA0", Offset = "0x676A4A0", VA = "0x18676BAA0")]
	public static double DJIBCKINHIH(byte[] MCPLLDADFCM, int IACEHNBBCDL, [Out] int GAIKAPABOAG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x676BC10", Offset = "0x676A610", VA = "0x18676BC10")]
	public static int HPKAICELHKJ(byte[] LMJJBGCJLAL, int IACEHNBBCDL, ulong BEEGCHJLJFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x676AF70", Offset = "0x6769970", VA = "0x18676AF70")]
	public static int AFPFCOHPHNK(byte[] LMJJBGCJLAL, int IACEHNBBCDL, long BEEGCHJLJFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x676C610", Offset = "0x676B010", VA = "0x18676C610")]
	public static bool NLCBPJLMCBE(byte[] MCPLLDADFCM, int IACEHNBBCDL, [Out] int GAIKAPABOAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal static class AJCHEEMLAIB
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class KOHNPLKEEPJ : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x930310", Offset = "0x92ED10", VA = "0x180930310")]
		[DebuggerHidden]
		public KOHNPLKEEPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x677A1F0", Offset = "0x6778BF0", VA = "0x18677A1F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6779C60", Offset = "0x6778660", VA = "0x186779C60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x677A090", Offset = "0x6778A90", VA = "0x18677A090")]
		private void OEKMCAOJCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6779C10", Offset = "0x6778610", VA = "0x186779C10")]
		private void ILPGDGAIKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x677A1A0", Offset = "0x6778BA0", VA = "0x18677A1A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x677A0E0", Offset = "0x6778AE0", VA = "0x18677A0E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x677A0E0", Offset = "0x6778AE0", VA = "0x18677A0E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class DCPACBJOEBK : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x930310", Offset = "0x92ED10", VA = "0x180930310")]
		[DebuggerHidden]
		public DCPACBJOEBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x67719A0", Offset = "0x67703A0", VA = "0x1867719A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6771410", Offset = "0x676FE10", VA = "0x186771410", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6771840", Offset = "0x6770240", VA = "0x186771840")]
		private void OEKMCAOJCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x67713C0", Offset = "0x676FDC0", VA = "0x1867713C0")]
		private void ILPGDGAIKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6771950", Offset = "0x6770350", VA = "0x186771950", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6771890", Offset = "0x6770290", VA = "0x186771890", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6771890", Offset = "0x6770290", VA = "0x186771890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x676DB20", Offset = "0x676C520", VA = "0x18676DB20")]
	public static bool DABEPLBPJNH(this TypeInfo AKDFFJNHJJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x676DC80", Offset = "0x676C680", VA = "0x18676DC80")]
	public static bool MHEPLHDCIEP(this TypeInfo AKDFFJNHJJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x676DE30", Offset = "0x676C830", VA = "0x18676DE30")]
	public static IEnumerable<PropertyInfo> PEPLNBIKODP(this Type AKDFFJNHJJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x676DBE0", Offset = "0x676C5E0", VA = "0x18676DBE0")]
	[IteratorStateMachine(typeof(KOHNPLKEEPJ))]
	private static IEnumerable<PropertyInfo> DKLEEEGMMLJ(Type AKDFFJNHJJN, HashSet<string> PDMDJNGEKOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x676DDB0", Offset = "0x676C7B0", VA = "0x18676DDB0")]
	public static IEnumerable<FieldInfo> OIBMIFKCCON(this Type AKDFFJNHJJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x676DA80", Offset = "0x676C480", VA = "0x18676DA80")]
	[IteratorStateMachine(typeof(DCPACBJOEBK))]
	private static IEnumerable<FieldInfo> APNCIDDIHOB(Type AKDFFJNHJJN, HashSet<string> PDMDJNGEKOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class JODJJOMEPPC
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly Encoding MMPBOKFPHBL;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal static class HPLMEMJDOFG
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0")]
	public static string OBEJOALIDDC(string NGDOJIEIDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6775930", Offset = "0x6774330", VA = "0x186775930")]
	public static string DIGGHOFAOBP(string NGDOJIEIDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x67757A0", Offset = "0x67741A0", VA = "0x1867757A0")]
	public static string BOEKHFLECFA(string NGDOJIEIDJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class JKJGJCADPNG<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class MBIGCIFEDDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Type MEIMJOBMJKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public TValue BMLGNHJJEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int MIJNPPKDGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public MBIGCIFEDDA JDJFMHPKACE;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7FC0", Offset = "0x3DC69C0", VA = "0x183DC7FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3DC7F80", Offset = "0x3DC6980", VA = "0x183DC7F80")]
		private int MDLNLAAIONI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public MBIGCIFEDDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class JGHAJEGKGAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public JGHAJEGKGAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xB51900", Offset = "0xB50300", VA = "0x180B51900")]
		internal TValue DIIHFNHNNHN(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private MBIGCIFEDDA[] JCGFCHKGAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private int DDIMFHFNGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly object AJHNDLGLEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly float CPIEOBHHFGN;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3A4B3E0", Offset = "0x3A49DE0", VA = "0x183A4B3E0")]
	public JKJGJCADPNG(int HCAPAJGPPGD = 4, float CPIEOBHHFGN = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x3A4AA50", Offset = "0x3A49450", VA = "0x183A4AA50")]
	public bool LDAOGDIKOCA(Type FHLJKJHFEEK, TValue BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A8E0", Offset = "0x3A492E0", VA = "0x183A4A8E0")]
	public bool LDAOGDIKOCA(Type FHLJKJHFEEK, Func<Type, TValue> JJGPGMEKBNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x3A49FB0", Offset = "0x3A489B0", VA = "0x183A49FB0")]
	private bool AHIDOEDLLBL(Type FHLJKJHFEEK, Func<Type, TValue> JJGPGMEKBNH, [Out] TValue ADCCGJFDMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x3A4AC00", Offset = "0x3A49600", VA = "0x183A4AC00")]
	private bool ONNMFLENCDD(MBIGCIFEDDA[] JCGFCHKGAGA, Type BJEDKFHIAFF, MBIGCIFEDDA HPKHNIGGBLA, Func<Type, TValue> JJGPGMEKBNH, [Out] TValue ADCCGJFDMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A670", Offset = "0x3A49070", VA = "0x183A4A670")]
	public bool GFGJHMKHGPD(Type FHLJKJHFEEK, [Out] TValue BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3A49E60", Offset = "0x3A48860", VA = "0x183A49E60")]
	public TValue AEPBGAAHILM(Type FHLJKJHFEEK, Func<Type, TValue> JJGPGMEKBNH)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3A4ABD0", Offset = "0x3A495D0", VA = "0x183A4ABD0")]
	private static int LMKKJMAKPME(int KBIHLEOLBHA, float CPIEOBHHFGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3A4B3B0", Offset = "0x3A49DB0", VA = "0x183A4B3B0")]
	private static void PJAPKJFBCOM(MBIGCIFEDDA DKFFFJFJNNK, MBIGCIFEDDA BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3A4B3B0", Offset = "0x3A49DB0", VA = "0x183A4B3B0")]
	private static void PJAPKJFBCOM(MBIGCIFEDDA[] DKFFFJFJNNK, MBIGCIFEDDA[] BEEGCHJLJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class KAHAJAMOGMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly AssemblyBuilder PBIKDKEGLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly ModuleBuilder ILKEFIDMJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly object ABNFGEAMCBN;

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6777E20", Offset = "0x6776820", VA = "0x186777E20")]
	public TypeBuilder HPNAKMLKIKA(string CDHDOGOGPME, TypeAttributes HFJDJNEEEKB, Type CDMOGOKIPKH, Type[] MKILLOLLBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6777F20", Offset = "0x6776920", VA = "0x186777F20")]
	public KAHAJAMOGMJ(string KCCPLLMFCAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal static class OPLPJBELNKG
{
	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x677E260", Offset = "0x677CC60", VA = "0x18677E260")]
	private static MethodInfo KNNCAONCIGJ(LambdaExpression KBPODCKIPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2772DC0", Offset = "0x27717C0", VA = "0x182772DC0")]
	public static MethodInfo DMCAFOBPKMC<T>(Expression<Func<T>> KBPODCKIPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2772DC0", Offset = "0x27717C0", VA = "0x182772DC0")]
	public static MethodInfo DMCAFOBPKMC<T, TR>(Expression<Func<T, TR>> KBPODCKIPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2772DC0", Offset = "0x27717C0", VA = "0x182772DC0")]
	public static MethodInfo DMCAFOBPKMC<T>(Expression<Action<T>> KBPODCKIPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2772DC0", Offset = "0x27717C0", VA = "0x182772DC0")]
	public static MethodInfo DMCAFOBPKMC<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> KBPODCKIPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2772CE0", Offset = "0x27716E0", VA = "0x182772CE0")]
	private static MemberInfo COHBPPPDDNN<T>(Expression<T> DMOGDONOGKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2772DD0", Offset = "0x27717D0", VA = "0x182772DD0")]
	public static PropertyInfo LPEEMDOKLKP<T, TR>(Expression<Func<T, TR>> KBPODCKIPIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal struct NAANEMKAPGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly int HLIHAMMEEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly bool JNPAMJBNLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly ILGenerator ENIFMHFILGH;

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x677C700", Offset = "0x677B100", VA = "0x18677C700")]
	public NAANEMKAPGB(ILGenerator ENIFMHFILGH, int HLIHAMMEEIJ, bool JNPAMJBNLLP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x677C740", Offset = "0x677B140", VA = "0x18677C740")]
	public NAANEMKAPGB(ILGenerator ENIFMHFILGH, int HLIHAMMEEIJ, Type AKDFFJNHJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x677C600", Offset = "0x677B000", VA = "0x18677C600")]
	public void FHMGKOKIJNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class CGMGGEDBNEM
{
	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x676FDB0", Offset = "0x676E7B0", VA = "0x18676FDB0")]
	public static void JKHOEJMBIBJ(this ILGenerator ENIFMHFILGH, int BNALCEABILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x676FFA0", Offset = "0x676E9A0", VA = "0x18676FFA0")]
	public static void JKHOEJMBIBJ(this ILGenerator ENIFMHFILGH, LocalBuilder AOBJAHHBBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x67702F0", Offset = "0x676ECF0", VA = "0x1867702F0")]
	public static void MGJGMFHDKNP(this ILGenerator ENIFMHFILGH, int BNALCEABILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x67702B0", Offset = "0x676ECB0", VA = "0x1867702B0")]
	public static void MGJGMFHDKNP(this ILGenerator ENIFMHFILGH, LocalBuilder AOBJAHHBBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x676F610", Offset = "0x676E010", VA = "0x18676F610")]
	public static void GOPKLCACMMB(this ILGenerator ENIFMHFILGH, int BNALCEABILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x676F6F0", Offset = "0x676E0F0", VA = "0x18676F6F0")]
	public static void GOPKLCACMMB(this ILGenerator ENIFMHFILGH, LocalBuilder AOBJAHHBBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x676FDA0", Offset = "0x676E7A0", VA = "0x18676FDA0")]
	public static void IOLCKFBGLHB(this ILGenerator ENIFMHFILGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x676F560", Offset = "0x676DF60", VA = "0x18676F560")]
	public static void FFKAGHKIDNA(this ILGenerator ENIFMHFILGH, bool BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x676F9C0", Offset = "0x676E3C0", VA = "0x18676F9C0")]
	public static void IGDPAMKENBJ(this ILGenerator ENIFMHFILGH, int BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x676F7F0", Offset = "0x676E1F0", VA = "0x18676F7F0")]
	public static void HAEHFNGLMOL(this ILGenerator ENIFMHFILGH, Type AKDFFJNHJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x676F570", Offset = "0x676DF70", VA = "0x18676F570")]
	public static void FLFJNLLKNLE(this ILGenerator ENIFMHFILGH, Type AKDFFJNHJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x67700C0", Offset = "0x676EAC0", VA = "0x1867700C0")]
	public static void LKOEHKABGNJ(this ILGenerator ENIFMHFILGH, int BNALCEABILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x676F450", Offset = "0x676DE50", VA = "0x18676F450")]
	public static void DBKHDKBGEIH(this ILGenerator ENIFMHFILGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x676FFE0", Offset = "0x676E9E0", VA = "0x18676FFE0")]
	public static void KHEEEJPIDKO(this ILGenerator ENIFMHFILGH, int BNALCEABILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x676F8D0", Offset = "0x676E2D0", VA = "0x18676F8D0")]
	public static void IDLNCGELHAG(this ILGenerator ENIFMHFILGH, MethodInfo HGBIKNAGECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x676F3C0", Offset = "0x676DDC0", VA = "0x18676F3C0")]
	public static void AMFKHAMNFDD(this ILGenerator ENIFMHFILGH, FieldInfo MKKNLFEKAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x676F4D0", Offset = "0x676DED0", VA = "0x18676F4D0")]
	public static void EBDEHFGDPAO(this ILGenerator ENIFMHFILGH, ulong BEEGCHJLJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class IIBLGMJIKDB
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class BFFHPDKKOHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public BFFHPDKKOHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x676E650", Offset = "0x676D050", VA = "0x18676E650")]
		internal bool LENFBHJJAPO(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private MethodInfo KPMHEOLFEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private MethodInfo JGLGDFKHKLL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string JHMJHFOLNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x790420", Offset = "0x78EE20", VA = "0x180790420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public string OAPOJBDNNOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x790C90", Offset = "0x78F690", VA = "0x180790C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool KANEJJEOPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6776090", Offset = "0x6774A90", VA = "0x186776090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ILCDFFILLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x799120", Offset = "0x797B20", VA = "0x180799120")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x798F20", Offset = "0x797920", VA = "0x180798F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool BJAOFNEEAFM
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8B11B0", Offset = "0x8AFBB0", VA = "0x1808B11B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8B0EA0", Offset = "0x8AF8A0", VA = "0x1808B0EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Type KBCPOJJINMM
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792310", VA = "0x180793910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x793D30", Offset = "0x792730", VA = "0x180793D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FieldInfo KLPFEPBGJFO
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x79A7B0", Offset = "0x7991B0", VA = "0x18079A7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PropertyInfo KNFGCNFDFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x793B30", Offset = "0x792530", VA = "0x180793B30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x799100", Offset = "0x797B00", VA = "0x180799100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MethodInfo FPGLOEGKCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x793D40", Offset = "0x792740", VA = "0x180793D40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x793900", Offset = "0x792300", VA = "0x180793900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x67764F0", Offset = "0x6774EF0", VA = "0x1867764F0")]
	protected IIBLGMJIKDB(Type AKDFFJNHJJN, string CDHDOGOGPME, string DBOJLDNKOCH, bool GDMKBIHIDGJ, bool BBNLPIMPKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6776220", Offset = "0x6774C20", VA = "0x186776220")]
	public IIBLGMJIKDB(FieldInfo PHOANEONLCI, string CDHDOGOGPME, bool BFCNMKNFGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6776330", Offset = "0x6774D30", VA = "0x186776330")]
	public IIBLGMJIKDB(PropertyInfo PHOANEONLCI, string CDHDOGOGPME, bool BFCNMKNFGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6775DA0", Offset = "0x67747A0", VA = "0x186775DA0")]
	private static MethodInfo EOKMDIDMFJB(MemberInfo PHOANEONLCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2633450", Offset = "0x2631E50", VA = "0x182633450")]
	public T LFEAMMBBPDF<T>(bool DDJIKOMMIOG) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6775F10", Offset = "0x6774910", VA = "0x186775F10", Slot = "4")]
	public virtual void IPENMMEOHCL(ILGenerator ENIFMHFILGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x67760A0", Offset = "0x6774AA0", VA = "0x1867760A0", Slot = "5")]
	public virtual void MOMJIAIMGIK(ILGenerator ENIFMHFILGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class PCDBFAOBOEO : IIBLGMJIKDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly string HGCAPMMNEGH;

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x677E5C0", Offset = "0x677CFC0", VA = "0x18677E5C0")]
	public PCDBFAOBOEO(string CDHDOGOGPME, string HGCAPMMNEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x677E4C0", Offset = "0x677CEC0", VA = "0x18677E4C0", Slot = "4")]
	public override void IPENMMEOHCL(ILGenerator ENIFMHFILGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x677E570", Offset = "0x677CF70", VA = "0x18677E570", Slot = "5")]
	public override void MOMJIAIMGIK(ILGenerator ENIFMHFILGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class JLEBEOCPADE : IIBLGMJIKDB
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly MethodInfo HNOEFDACNHO;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly MethodInfo PGECELLHAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal NAANEMKAPGB NKDGHKIJLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	internal NAANEMKAPGB HKIAFBFOHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal NAANEMKAPGB PHLFKGJBPHD;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6777A80", Offset = "0x6776480", VA = "0x186777A80")]
	public JLEBEOCPADE(string CDHDOGOGPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6777460", Offset = "0x6775E60", VA = "0x186777460", Slot = "4")]
	public override void IPENMMEOHCL(ILGenerator ENIFMHFILGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6777520", Offset = "0x6775F20", VA = "0x186777520", Slot = "5")]
	public override void MOMJIAIMGIK(ILGenerator ENIFMHFILGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x67772A0", Offset = "0x6775CA0", VA = "0x1867772A0")]
	public void CBEAABCPKHN(ILGenerator ENIFMHFILGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class KOCLCOELKID
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Type KBCPOJJINMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x790420", Offset = "0x78EE20", VA = "0x180790420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool LCEIBBDBLEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8113D0", Offset = "0x80FDD0", VA = "0x1808113D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x792750", Offset = "0x791150", VA = "0x180792750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool GADENMPNEDH
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF870", Offset = "0x8AE270", VA = "0x1808AF870")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF100", Offset = "0x8ADB00", VA = "0x1808AF100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ConstructorInfo KLEFNKEEADM
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x790CA0", Offset = "0x78F6A0", VA = "0x180790CA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IIBLGMJIKDB[] ABNGHBMPJIC
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792310", VA = "0x180793910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x793D30", Offset = "0x792730", VA = "0x180793D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public IIBLGMJIKDB[] LOHOPCBJFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x79A7B0", Offset = "0x7991B0", VA = "0x18079A7B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x6778750", Offset = "0x6777150", VA = "0x186778750")]
	public KOCLCOELKID(Type AKDFFJNHJJN, Func<string, string> DEGOBHKKIIM, bool BFCNMKNFGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6778670", Offset = "0x6777070", VA = "0x186778670")]
	private static bool IOAILOGHCEO(IEnumerator<ConstructorInfo> LFFBAOEBEGP, ConstructorInfo AIDEFCOMLPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal struct KKDBIMMGMHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ulong DMPBNKMMGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public int IMCCCAHFJAM;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1D49BB0", Offset = "0x1D485B0", VA = "0x181D49BB0")]
	public KKDBIMMGMHP(ulong MOEFADCBEKO, int HIMBLOEAOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6778290", Offset = "0x6776C90", VA = "0x186778290")]
	public void CJLJIIJHBPA(KKDBIMMGMHP CGDFJMJIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x67782A0", Offset = "0x6776CA0", VA = "0x1867782A0")]
	public static KKDBIMMGMHP HKLKOKFMFMG(KKDBIMMGMHP PJHMDOOMOBI, KKDBIMMGMHP OIKFNBPLIOK)
	{
		return default(KKDBIMMGMHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x67782B0", Offset = "0x6776CB0", VA = "0x1867782B0")]
	public void KNBAKFNAOMG(KKDBIMMGMHP CGDFJMJIABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6778340", Offset = "0x6776D40", VA = "0x186778340")]
	public static KKDBIMMGMHP MECJPANMPLF(KKDBIMMGMHP PJHMDOOMOBI, KKDBIMMGMHP OIKFNBPLIOK)
	{
		return default(KKDBIMMGMHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6778250", Offset = "0x6776C50", VA = "0x186778250")]
	public void BABDPMEHDDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6778200", Offset = "0x6776C00", VA = "0x186778200")]
	public static KKDBIMMGMHP BABDPMEHDDH(KKDBIMMGMHP PJHMDOOMOBI)
	{
		return default(KKDBIMMGMHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct CNICBIEJMGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public byte[] LMJJBGCJLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public int IACEHNBBCDL;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x179EA50", Offset = "0x179D450", VA = "0x18179EA50")]
	public CNICBIEJMGM(byte[] LMJJBGCJLAL, int CJONGNPPIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x674F5B0", Offset = "0x674DFB0", VA = "0x18674F5B0")]
	public void LLMEFANKOOG(byte IKBGKMEDHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6770780", Offset = "0x676F180", VA = "0x186770780")]
	public void PIFANMMNDGO(byte[] IKBGKMEDHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6770700", Offset = "0x676F100", VA = "0x186770700")]
	public void JJEMKKFFIEG(byte[] IKBGKMEDHKI, int FJADIACPEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6770660", Offset = "0x676F060", VA = "0x186770660")]
	public void JJEMKKFFIEG(byte[] IKBGKMEDHKI, int OHBFODPGDGE, int FJADIACPEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x67704E0", Offset = "0x676EEE0", VA = "0x1867704E0")]
	public void DKDKLNOIIGI(byte BDAHFBGOEJD, int MPNHPMPEEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6770560", Offset = "0x676EF60", VA = "0x186770560")]
	public void HDIDBIKEGNI(string IKBGKMEDHKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class PCOKPHHADAP
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private enum OBKEPFEGHKO
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private enum BOCLAJGBGAH
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private enum LKDFIAMJMLE
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
	private static byte[] NEGIJCDLLFB;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[ThreadStatic]
	private static byte[] BJHBDOHKCEA;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly byte[] NAMPNBAIFGH;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly byte[] CPDHDGGENCG;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static readonly LKDFIAMJMLE EMKIMJJMGFC;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static readonly char CPKLNBPOKIE;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static readonly int EBPHPHAIPPK;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static readonly int BHDGIKMLDIO;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static readonly uint[] PNCGLBNHOMA;

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6780470", Offset = "0x677EE70", VA = "0x186780470")]
	private static byte[] JMFMNOMNJFL(int DDIMFHFNGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x677EF40", Offset = "0x677D940", VA = "0x18677EF40")]
	private static byte[] BDPAJIFKDFL(int DDIMFHFNGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x677FA40", Offset = "0x677E440", VA = "0x18677FA40")]
	public static int GFGLBADANKO(byte[] LMJJBGCJLAL, int IACEHNBBCDL, float BEEGCHJLJFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x677F920", Offset = "0x677E320", VA = "0x18677F920")]
	public static int GFGLBADANKO(byte[] LMJJBGCJLAL, int IACEHNBBCDL, double BEEGCHJLJFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x677F3B0", Offset = "0x677DDB0", VA = "0x18677F3B0")]
	private static bool CIFFCKFKDMK(byte[] LMJJBGCJLAL, int FJADIACPEIM, ulong BHMMBEHIJKK, ulong DBPLPHHDJGE, ulong JHPIDPMDDIF, ulong HFPMNOIJMJH, ulong IAEHJEKBBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x677FF90", Offset = "0x677E990", VA = "0x18677FF90")]
	private static void JEGKMPEIPOH(uint PGGNNGJLAEL, int IKCDILEGDIJ, [Out] uint BAPLFOOCCME, [Out] int PMABBCMFNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6780080", Offset = "0x677EA80", VA = "0x186780080")]
	private static bool JMEDLFMFAMH(KKDBIMMGMHP CDMMEHCFEIA, KKDBIMMGMHP JNEGICJFFGC, KKDBIMMGMHP DIAMEFOCBJH, byte[] LMJJBGCJLAL, [Out] int FJADIACPEIM, [Out] int FGHBMEKGBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x677F4A0", Offset = "0x677DEA0", VA = "0x18677F4A0")]
	private static bool FJMMABPAION(double DNGEIAEKKBO, OBKEPFEGHKO GMLCEBAHCFB, byte[] LMJJBGCJLAL, [Out] int FJADIACPEIM, [Out] int HKMFPOEKHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x6780540", Offset = "0x677EF40", VA = "0x186780540")]
	private static bool ONKMIKKDDKM(double DNGEIAEKKBO, OBKEPFEGHKO GMLCEBAHCFB, byte[] LMJJBGCJLAL, [Out] int FJADIACPEIM, [Out] int BBJJCEAMBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x677ED70", Offset = "0x677D770", VA = "0x18677ED70")]
	private static bool BBHBJNEIJMO(double BEEGCHJLJFC, CNICBIEJMGM NCPIGKEIIPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x677E890", Offset = "0x677D290", VA = "0x18677E890")]
	private static bool AJPCNBCAPEE(double BEEGCHJLJFC, CNICBIEJMGM NCPIGKEIIPJ, BOCLAJGBGAH GMLCEBAHCFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x677F020", Offset = "0x677DA20", VA = "0x18677F020")]
	private static void BLPMHGHJJCB(byte[] APJLFEJIEKB, int FJADIACPEIM, int BBJJCEAMBAA, int OOGJBIDCPLG, CNICBIEJMGM NCPIGKEIIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x677FB60", Offset = "0x677E560", VA = "0x18677FB60")]
	private static void HIFKIAAOLJC(byte[] APJLFEJIEKB, int FJADIACPEIM, int HIMBLOEAOIG, CNICBIEJMGM NCPIGKEIIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x677E6A0", Offset = "0x677D0A0", VA = "0x18677E6A0")]
	private static bool ACHCMGBBGPO(double DNGEIAEKKBO, BOCLAJGBGAH GMLCEBAHCFB, int NJCHFAKEKAG, byte[] KDOHLBBAJEN, [Out] bool BAJDPEGNPGE, [Out] int FJADIACPEIM, [Out] int HPCONAOEEAJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal struct EIJLKFCKIEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public double ACHEPLMFHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ulong MJJHMDBFMGH;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal struct OIONEGNOELG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public float DMPBNKMMGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public uint IDJDEIFMFND;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal struct MOPMLKELINB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private ulong NLDOHNINMFI;

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x677C550", Offset = "0x677AF50", VA = "0x18677C550")]
	public MOPMLKELINB(double ACHEPLMFHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x677C560", Offset = "0x677AF60", VA = "0x18677C560")]
	public MOPMLKELINB(KKDBIMMGMHP ACHEPLMFHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x677C070", Offset = "0x677AA70", VA = "0x18677C070")]
	public KKDBIMMGMHP BKBJBNGKFCH()
	{
		return default(KKDBIMMGMHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x677C1D0", Offset = "0x677ABD0", VA = "0x18677C1D0")]
	public KKDBIMMGMHP EGOEFBFBNPP()
	{
		return default(KKDBIMMGMHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270")]
	public ulong NCLKJMPJPGO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x677BFC0", Offset = "0x677A9C0", VA = "0x18677BFC0")]
	public double AEDDFMHCCOG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x677C0E0", Offset = "0x677AAE0", VA = "0x18677C0E0")]
	public double CDCIBAAILCE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x677C180", Offset = "0x677AB80", VA = "0x18677C180")]
	public int CIJJGDPCBNP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x677C040", Offset = "0x677AA40", VA = "0x18677C040")]
	public ulong BIEBBDMFJND()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x677C320", Offset = "0x677AD20", VA = "0x18677C320")]
	public bool MHHJJLGLIEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x677C250", Offset = "0x677AC50", VA = "0x18677C250")]
	public bool ELIMLABMDLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x677C520", Offset = "0x677AF20", VA = "0x18677C520")]
	public bool PCMAILKGPKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x677C2E0", Offset = "0x677ACE0", VA = "0x18677C2E0")]
	public bool FOFPHLNGPIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x677C1B0", Offset = "0x677ABB0", VA = "0x18677C1B0")]
	public int EBLHLPGCCBI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x677C3D0", Offset = "0x677ADD0", VA = "0x18677C3D0")]
	public void OPBHMEGEAIJ([Out] KKDBIMMGMHP AAGPFNJCHLK, [Out] KKDBIMMGMHP LNNELKDCJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x677C290", Offset = "0x677AC90", VA = "0x18677C290")]
	public bool FGKDBBBFKMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0370", Offset = "0x2BCED70", VA = "0x182BD0370")]
	public double BEEGCHJLJFC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x677C270", Offset = "0x677AC70", VA = "0x18677C270")]
	public static int FDPHJOLMAOE(int GPMGFHLOLMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x677C310", Offset = "0x677AD10", VA = "0x18677C310")]
	public static double GOFGBOBDJKJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x677C340", Offset = "0x677AD40", VA = "0x18677C340")]
	public static ulong OEOODOEFBMM(KKDBIMMGMHP CHACBIGKBBH)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct ICCIFGFLOAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private uint PDFHENKGMLD;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x210BCA0", Offset = "0x210A6A0", VA = "0x18210BCA0")]
	public ICCIFGFLOAG(float DMPBNKMMGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6775A30", Offset = "0x6774430", VA = "0x186775A30")]
	public KKDBIMMGMHP BKBJBNGKFCH()
	{
		return default(KKDBIMMGMHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8986C0", Offset = "0x8970C0", VA = "0x1808986C0")]
	public uint DHMONCBCKEF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6775A80", Offset = "0x6774480", VA = "0x186775A80")]
	public int CIJJGDPCBNP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6775A10", Offset = "0x6774410", VA = "0x186775A10")]
	public uint BIEBBDMFJND()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6775AE0", Offset = "0x67744E0", VA = "0x186775AE0")]
	public bool MHHJJLGLIEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6775AF0", Offset = "0x67744F0", VA = "0x186775AF0")]
	public void OPBHMEGEAIJ([Out] KKDBIMMGMHP AAGPFNJCHLK, [Out] KKDBIMMGMHP LNNELKDCJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6775AA0", Offset = "0x67744A0", VA = "0x186775AA0")]
	public bool FGKDBBBFKMN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct IKCFBNOHMCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly ulong MOEFADCBEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly short FLEBPLAOCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public readonly short HKMFPOEKHIG;

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x67766F0", Offset = "0x67750F0", VA = "0x1867766F0")]
	public IKCFBNOHMCF(ulong MOEFADCBEKO, short FLEBPLAOCKL, short HKMFPOEKHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class FPDPHMFGKCC
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly IKCFBNOHMCF[] NPFGEJDADMA;

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x6772720", Offset = "0x6771120", VA = "0x186772720")]
	public static void DLAKKJKCCNE(int GGAHBBJEOKO, int HBPMGHLICAF, [Out] KKDBIMMGMHP BAPLFOOCCME, [Out] int HKMFPOEKHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6772830", Offset = "0x6771230", VA = "0x186772830")]
	public static void PFCOGICKKEB(int EJJLAIEBLBL, [Out] KKDBIMMGMHP BAPLFOOCCME, [Out] int GICGJPHKOBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[DefaultMember("Item")]
internal struct KKLFHEJOIGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public readonly byte[] MCPLLDADFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public readonly int OHBFODPGDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public readonly int HILJGIPOAKJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte OBNEKGFINAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x67783E0", Offset = "0x6776DE0", VA = "0x1867783E0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1D10F70", Offset = "0x1D0F970", VA = "0x181D10F70")]
	public KKLFHEJOIGN(byte[] MCPLLDADFCM, int OHBFODPGDGE, int FJADIACPEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1D10FB0", Offset = "0x1D0F9B0", VA = "0x181D10FB0")]
	public int FJADIACPEIM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6778420", Offset = "0x6776E20", VA = "0x186778420")]
	public KKLFHEJOIGN OPPHGFGJOCJ(int HFLKNOEOMLO, int MKNIMCJLKGN)
	{
		return default(KKLFHEJOIGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal static class GOHNLANDDNF
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] GNPKFJOOEPB;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly double[] KBLFFCDEEBI;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly int PHGIDGJEOIJ;

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x67746E0", Offset = "0x67730E0", VA = "0x1867746E0")]
	private static byte[] DKBCIFDCJBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x6775080", Offset = "0x6773A80", VA = "0x186775080")]
	private static KKLFHEJOIGN INCPDHLJABJ(KKLFHEJOIGN LMJJBGCJLAL)
	{
		return default(KKLFHEJOIGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6774FA0", Offset = "0x67739A0", VA = "0x186774FA0")]
	private static KKLFHEJOIGN HIHOIEJKLDH(KKLFHEJOIGN LMJJBGCJLAL)
	{
		return default(KKLFHEJOIGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6774B90", Offset = "0x6773590", VA = "0x186774B90")]
	private static void DNPJKNEFMCG(KKLFHEJOIGN LMJJBGCJLAL, int HIMBLOEAOIG, byte[] JLKOLEONCFL, [Out] int AIDKPMGFEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6774C20", Offset = "0x6773620", VA = "0x186774C20")]
	private static void EPHGMMKLBJL(KKLFHEJOIGN LMJJBGCJLAL, int HIMBLOEAOIG, byte[] HLFFIJOHBJJ, int NACDPNHNICN, [Out] KKLFHEJOIGN ICNPLAEADOO, [Out] int LBFGNPJNABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6774F10", Offset = "0x6773910", VA = "0x186774F10")]
	private static ulong GDHDHCKCDDB(KKLFHEJOIGN LMJJBGCJLAL, [Out] int HNGCAGACNKB)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6775420", Offset = "0x6773E20", VA = "0x186775420")]
	private static void PFNHJDMKGLB(KKLFHEJOIGN LMJJBGCJLAL, [Out] KKDBIMMGMHP JHJJOGFODKA, [Out] int IJBMDEMLEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x67747C0", Offset = "0x67731C0", VA = "0x1867747C0")]
	private static bool DMBNBPECAPA(KKLFHEJOIGN ICNPLAEADOO, int HIMBLOEAOIG, [Out] double JHJJOGFODKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6775280", Offset = "0x6773C80", VA = "0x186775280")]
	private static KKDBIMMGMHP JIPJNBPPDDK(int HIMBLOEAOIG)
	{
		return default(KKDBIMMGMHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6773CA0", Offset = "0x67726A0", VA = "0x186773CA0")]
	private static bool BELEAKMEBFL(KKLFHEJOIGN LMJJBGCJLAL, int HIMBLOEAOIG, [Out] double JHJJOGFODKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6775160", Offset = "0x6773B60", VA = "0x186775160")]
	private static bool JBALMAIIGAL(KKLFHEJOIGN ICNPLAEADOO, int HIMBLOEAOIG, [Out] double AIHJDOCOAGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x67745C0", Offset = "0x6772FC0", VA = "0x1867745C0")]
	public static double? DENMDHGNEGN(KKLFHEJOIGN LMJJBGCJLAL, int HIMBLOEAOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x67742F0", Offset = "0x6772CF0", VA = "0x1867742F0")]
	public static float? DCMBDJOOJOA(KKLFHEJOIGN LMJJBGCJLAL, int HIMBLOEAOIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal struct FCODCCNJGFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private byte[] LMJJBGCJLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private int IACEHNBBCDL;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public byte BMLGNHJJEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x67893D0", Offset = "0x6787DD0", VA = "0x1867893D0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x179EA50", Offset = "0x179D450", VA = "0x18179EA50")]
	public FCODCCNJGFI(byte[] LMJJBGCJLAL, int IACEHNBBCDL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6789440", Offset = "0x6787E40", VA = "0x186789440")]
	public static FCODCCNJGFI JCPIBDMLCBL(FCODCCNJGFI JFFAAHPEFOB)
	{
		return default(FCODCCNJGFI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x67894F0", Offset = "0x6787EF0", VA = "0x1867894F0")]
	public static FCODCCNJGFI NGPNDCIKIJI(FCODCCNJGFI JFFAAHPEFOB, int FJADIACPEIM)
	{
		return default(FCODCCNJGFI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6789540", Offset = "0x6787F40", VA = "0x186789540")]
	public static int NMOKAJJFOKB(FCODCCNJGFI KKLPBLEHAEB, FCODCCNJGFI MFJBAALKDKH)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6789480", Offset = "0x6787E80", VA = "0x186789480")]
	public static bool JGKBBKJJNFA(FCODCCNJGFI KKLPBLEHAEB, FCODCCNJGFI MFJBAALKDKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6789430", Offset = "0x6787E30", VA = "0x186789430")]
	public static bool GOKPCPODMCO(FCODCCNJGFI KKLPBLEHAEB, FCODCCNJGFI MFJBAALKDKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6789450", Offset = "0x6787E50", VA = "0x186789450")]
	public static bool JGKBBKJJNFA(FCODCCNJGFI KKLPBLEHAEB, char MFJBAALKDKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6789400", Offset = "0x6787E00", VA = "0x186789400")]
	public static bool GOKPCPODMCO(FCODCCNJGFI KKLPBLEHAEB, char MFJBAALKDKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6789400", Offset = "0x6787E00", VA = "0x186789400")]
	public static bool GOKPCPODMCO(FCODCCNJGFI KKLPBLEHAEB, byte MFJBAALKDKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6789550", Offset = "0x6787F50", VA = "0x186789550")]
	public static bool OEANBGJMCMM(FCODCCNJGFI KKLPBLEHAEB, char MFJBAALKDKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6789490", Offset = "0x6787E90", VA = "0x186789490")]
	public static bool KKGFIPMBNKP(FCODCCNJGFI KKLPBLEHAEB, char MFJBAALKDKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x67893A0", Offset = "0x6787DA0", VA = "0x1867893A0")]
	public static bool COAHBACCCGM(FCODCCNJGFI KKLPBLEHAEB, char MFJBAALKDKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x67894C0", Offset = "0x6787EC0", VA = "0x1867894C0")]
	public static bool MCIGCEKCKJB(FCODCCNJGFI KKLPBLEHAEB, char MFJBAALKDKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class DAGKJMIIMKB
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	[ThreadStatic]
	private static byte[] MHFGNOGKFAE;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[ThreadStatic]
	private static byte[] DLEHLOEHFGL;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly byte[] NAMPNBAIFGH;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly byte[] CPDHDGGENCG;

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private static readonly byte[] IGIELMBOCMC;

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly int LGHPBKFMHKO;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ushort[] LJJEJEPDNFH;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly int PONBJNBJNJH;

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6785320", Offset = "0x6783D20", VA = "0x186785320")]
	private static byte[] LACBDJIHICE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6785240", Offset = "0x6783C40", VA = "0x186785240")]
	private static byte[] HLHABEAPBJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6784C70", Offset = "0x6783670", VA = "0x186784C70")]
	public static double BALJJIFBBCB(byte[] LMJJBGCJLAL, int IACEHNBBCDL, [Out] int GAIKAPABOAG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6785190", Offset = "0x6783B90", VA = "0x186785190")]
	public static float HEFJEGINIBO(byte[] LMJJBGCJLAL, int IACEHNBBCDL, [Out] int GAIKAPABOAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6784F10", Offset = "0x6783910", VA = "0x186784F10")]
	private static bool CIIFEBIGKKB(int MGCANBJCGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6784D20", Offset = "0x6783720", VA = "0x186784D20")]
	private static bool BFAGEIOGCNM(FCODCCNJGFI ENBLOMKHKAC, FCODCCNJGFI BFAIICDOEKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x67850C0", Offset = "0x6783AC0", VA = "0x1867850C0")]
	private static bool FNEJDDFLOPI(FCODCCNJGFI ENBLOMKHKAC, FCODCCNJGFI BFAIICDOEKN, byte[] IKEDDEFCCPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x6785070", Offset = "0x6783A70", VA = "0x186785070")]
	private static bool ENGFCMEFGIP(FCODCCNJGFI GIHEDIBILAL, byte[] IKBGKMEDHKI, int IACEHNBBCDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x6785050", Offset = "0x6783A50", VA = "0x186785050")]
	private static double DKHEFGHOHBB(bool BAJDPEGNPGE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6785400", Offset = "0x6783E00", VA = "0x186785400")]
	private static double PFBENEJPLAJ(FCODCCNJGFI KIEPLBLJKOI, int FJADIACPEIM, bool GPMJDJGGJCP, [Out] int KMAEGHPAMNB)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class ACMFKMNPGKO<T> : DDBEBCOLMLO<T[]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly IMIDHINJNJM<T> FKAMFEJEEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private readonly LJJEDJKMJFN CEKKLMCIMAI;

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3254100", Offset = "0x3252B00", VA = "0x183254100")]
	public ACMFKMNPGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
	public ACMFKMNPGKO(LJJEDJKMJFN CEKKLMCIMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3652280", Offset = "0x3650C80", VA = "0x183652280", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, T[] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x364FDD0", Offset = "0x364E7D0", VA = "0x18364FDD0", Slot = "5")]
	public T[] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class LBIENDLBADC<T> : DDBEBCOLMLO<ArraySegment<T>>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly IMIDHINJNJM<T> FKAMFEJEEDM;

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3BB91D0", Offset = "0x3BB7BD0", VA = "0x183BB91D0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, ArraySegment<T> BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8DB0", Offset = "0x3BB77B0", VA = "0x183BB8DB0", Slot = "5")]
	public ArraySegment<T> DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(ArraySegment<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class OKCBGOJFABP<T> : DDBEBCOLMLO<List<T>>, FBNOOOLMEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly LJJEDJKMJFN CEKKLMCIMAI;

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3254100", Offset = "0x3252B00", VA = "0x183254100")]
	public OKCBGOJFABP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
	public OKCBGOJFABP(LJJEDJKMJFN CEKKLMCIMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x3F90DD0", Offset = "0x3F8F7D0", VA = "0x183F90DD0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, List<T> BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x3F8C910", Offset = "0x3F8B310", VA = "0x183F8C910", Slot = "5")]
	public List<T> DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public abstract class PDKDJBABPOG<TElement, TIntermediate, TEnumerator, TCollection> : DDBEBCOLMLO<TCollection>, FBNOOOLMEBG where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x4068940", Offset = "0x4067340", VA = "0x184068940", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, TCollection BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x4067540", Offset = "0x4065F40", VA = "0x184067540", Slot = "5")]
	public TCollection DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator HEPKAEIDFMK(TCollection DMOGDONOGKM);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate CMMJGECCMDN();

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void DGLLAPEBOKO(TIntermediate OJOEBEILHFP, int BNALCEABILL, TElement BEEGCHJLJFC);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection DAFDMKIFLPG(TIntermediate FFGFOPKADPL);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	protected PDKDJBABPOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public abstract class GHFEGCHOOPD<TElement, TIntermediate, TCollection> : PDKDJBABPOG<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3660BF0", Offset = "0x365F5F0", VA = "0x183660BF0", Slot = "6")]
	protected override IEnumerator<TElement> HEPKAEIDFMK(TCollection DMOGDONOGKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x3214C00", Offset = "0x3213600", VA = "0x183214C00")]
	protected GHFEGCHOOPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public abstract class FPFHHLEDMNP<TElement, TCollection> : GHFEGCHOOPD<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x81DA50", Offset = "0x81C450", VA = "0x18081DA50", Slot = "9")]
	protected sealed override TCollection DAFDMKIFLPG(TCollection FFGFOPKADPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class NLGDFBOPEDI<TElement, TCollection> : FPFHHLEDMNP<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3E98A40", Offset = "0x3E97440", VA = "0x183E98A40", Slot = "7")]
	protected override TCollection CMMJGECCMDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3E98A70", Offset = "0x3E97470", VA = "0x183E98A70", Slot = "8")]
	protected override void DGLLAPEBOKO(TCollection OJOEBEILHFP, int BNALCEABILL, TElement BEEGCHJLJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class ADEEOLBFNAF<T> : PDKDJBABPOG<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x35B1EB0", Offset = "0x35B08B0", VA = "0x1835B1EB0", Slot = "8")]
	protected override void DGLLAPEBOKO(LinkedList<T> OJOEBEILHFP, int BNALCEABILL, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x81DA50", Offset = "0x81C450", VA = "0x18081DA50", Slot = "9")]
	protected override LinkedList<T> DAFDMKIFLPG(LinkedList<T> FFGFOPKADPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3261150", Offset = "0x325FB50", VA = "0x183261150", Slot = "7")]
	protected override LinkedList<T> CMMJGECCMDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3654360", Offset = "0x3652D60", VA = "0x183654360", Slot = "6")]
	protected override LinkedList<T>.Enumerator HEPKAEIDFMK(LinkedList<T> DMOGDONOGKM)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public sealed class DHNEGLNCCLK<T> : PDKDJBABPOG<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x35B1EB0", Offset = "0x35B08B0", VA = "0x1835B1EB0", Slot = "8")]
	protected override void DGLLAPEBOKO(Queue<T> OJOEBEILHFP, int BNALCEABILL, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3261150", Offset = "0x325FB50", VA = "0x183261150", Slot = "7")]
	protected override Queue<T> CMMJGECCMDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x35B1EF0", Offset = "0x35B08F0", VA = "0x1835B1EF0", Slot = "6")]
	protected override Queue<T>.Enumerator HEPKAEIDFMK(Queue<T> DMOGDONOGKM)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x81DA50", Offset = "0x81C450", VA = "0x18081DA50", Slot = "9")]
	protected override Queue<T> DAFDMKIFLPG(Queue<T> FFGFOPKADPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class DKGCCNPMEML<T> : PDKDJBABPOG<T, AIJEJDOJOPD<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x369B8E0", Offset = "0x369A2E0", VA = "0x18369B8E0", Slot = "8")]
	protected override void DGLLAPEBOKO(AIJEJDOJOPD<T> OJOEBEILHFP, int BNALCEABILL, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x369B850", Offset = "0x369A250", VA = "0x18369B850", Slot = "7")]
	protected override AIJEJDOJOPD<T> CMMJGECCMDN()
	{
		return default(AIJEJDOJOPD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x4F6ACC0", Offset = "0x4F696C0", VA = "0x184F6ACC0", Slot = "6")]
	protected override Stack<T>.Enumerator HEPKAEIDFMK(Stack<T> DMOGDONOGKM)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x4F6ABE0", Offset = "0x4F695E0", VA = "0x184F6ABE0", Slot = "9")]
	protected override Stack<T> DAFDMKIFLPG(AIJEJDOJOPD<T> FFGFOPKADPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class FDDKCFJMGON<T> : PDKDJBABPOG<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x35B1EB0", Offset = "0x35B08B0", VA = "0x1835B1EB0", Slot = "8")]
	protected override void DGLLAPEBOKO(HashSet<T> OJOEBEILHFP, int BNALCEABILL, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x81DA50", Offset = "0x81C450", VA = "0x18081DA50", Slot = "9")]
	protected override HashSet<T> DAFDMKIFLPG(HashSet<T> FFGFOPKADPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x3261150", Offset = "0x325FB50", VA = "0x183261150", Slot = "7")]
	protected override HashSet<T> CMMJGECCMDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x35B1EF0", Offset = "0x35B08F0", VA = "0x1835B1EF0", Slot = "6")]
	protected override HashSet<T>.Enumerator HEPKAEIDFMK(HashSet<T> DMOGDONOGKM)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class PMBIGBIGBFI<T> : GHFEGCHOOPD<T, AIJEJDOJOPD<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x369B8E0", Offset = "0x369A2E0", VA = "0x18369B8E0", Slot = "8")]
	protected override void DGLLAPEBOKO(AIJEJDOJOPD<T> OJOEBEILHFP, int BNALCEABILL, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x40A1F30", Offset = "0x40A0930", VA = "0x1840A1F30", Slot = "9")]
	protected override ReadOnlyCollection<T> DAFDMKIFLPG(AIJEJDOJOPD<T> FFGFOPKADPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x40A1EF0", Offset = "0x40A08F0", VA = "0x1840A1EF0", Slot = "7")]
	protected override AIJEJDOJOPD<T> CMMJGECCMDN()
	{
		return default(AIJEJDOJOPD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class FFGKBMMECOD<T> : GHFEGCHOOPD<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x35B1EB0", Offset = "0x35B08B0", VA = "0x1835B1EB0", Slot = "8")]
	protected override void DGLLAPEBOKO(List<T> OJOEBEILHFP, int BNALCEABILL, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x3261150", Offset = "0x325FB50", VA = "0x183261150", Slot = "7")]
	protected override List<T> CMMJGECCMDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x81DA50", Offset = "0x81C450", VA = "0x18081DA50", Slot = "9")]
	protected override IList<T> DAFDMKIFLPG(List<T> FFGFOPKADPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class PEMFGOCFOLO<T> : GHFEGCHOOPD<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x35B1EB0", Offset = "0x35B08B0", VA = "0x1835B1EB0", Slot = "8")]
	protected override void DGLLAPEBOKO(List<T> OJOEBEILHFP, int BNALCEABILL, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3261150", Offset = "0x325FB50", VA = "0x183261150", Slot = "7")]
	protected override List<T> CMMJGECCMDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x81DA50", Offset = "0x81C450", VA = "0x18081DA50", Slot = "9")]
	protected override ICollection<T> DAFDMKIFLPG(List<T> FFGFOPKADPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class IHHCBCGCKFN<T> : GHFEGCHOOPD<T, AIJEJDOJOPD<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x369B8E0", Offset = "0x369A2E0", VA = "0x18369B8E0", Slot = "8")]
	protected override void DGLLAPEBOKO(AIJEJDOJOPD<T> OJOEBEILHFP, int BNALCEABILL, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x369B850", Offset = "0x369A250", VA = "0x18369B850", Slot = "7")]
	protected override AIJEJDOJOPD<T> CMMJGECCMDN()
	{
		return default(AIJEJDOJOPD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x3830260", Offset = "0x382EC60", VA = "0x183830260", Slot = "9")]
	protected override IEnumerable<T> DAFDMKIFLPG(AIJEJDOJOPD<T> FFGFOPKADPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x32225C0", Offset = "0x3220FC0", VA = "0x1832225C0")]
	public IHHCBCGCKFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class EHCKNIMOHAL<TKey, TElement> : DDBEBCOLMLO<IGrouping<TKey, TElement>>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x324C0A0", Offset = "0x324AAA0", VA = "0x18324C0A0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, IGrouping<TKey, TElement> BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x324BDA0", Offset = "0x324A7A0", VA = "0x18324BDA0", Slot = "5")]
	public IGrouping<TKey, TElement> DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class NEIOGFFCCFN<TKey, TElement> : DDBEBCOLMLO<ILookup<TKey, TElement>>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3E4A060", Offset = "0x3E48A60", VA = "0x183E4A060", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, ILookup<TKey, TElement> BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3E49D10", Offset = "0x3E48710", VA = "0x183E49D10", Slot = "5")]
	public ILookup<TKey, TElement> DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class ENAJCHJNEEN<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly TKey FHLJKJHFEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly IEnumerable<TElement> HBAGFCLKGMJ;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public TKey MEIMJOBMJKA
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430", Slot = "4")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x797640", Offset = "0x796040", VA = "0x180797640")]
	public ENAJCHJNEEN(TKey FHLJKJHFEEK, IEnumerable<TElement> HBAGFCLKGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x326C9B0", Offset = "0x326B3B0", VA = "0x18326C9B0", Slot = "5")]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x32583C0", Offset = "0x3256DC0", VA = "0x1832583C0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[DefaultMember("Item")]
internal class HNMCOBFJCAN<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly Dictionary<TKey, IGrouping<TKey, TElement>> CHJJNPLCGMA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IEnumerable<TElement> OBNEKGFINAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x35A6E00", Offset = "0x35A5800", VA = "0x1835A6E00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
	public HNMCOBFJCAN(Dictionary<TKey, IGrouping<TKey, TElement>> CHJJNPLCGMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x378F0D0", Offset = "0x378DAD0", VA = "0x18378F0D0", Slot = "5")]
	public bool Contains(TKey FHLJKJHFEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x378F110", Offset = "0x378DB10", VA = "0x18378F110", Slot = "6")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x378F110", Offset = "0x378DB10", VA = "0x18378F110", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class CLCMMJKGLIG<T> : DDBEBCOLMLO<T>, FBNOOOLMEBG where T : class, IList, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x4D84A80", Offset = "0x4D83480", VA = "0x184D84A80", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, T BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x4D84800", Offset = "0x4D83200", VA = "0x184D84800", Slot = "5")]
	public T DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public CLCMMJKGLIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class EGNNEBGHOEG : DDBEBCOLMLO<IEnumerable>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public static readonly DDBEBCOLMLO<IEnumerable> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x6787910", Offset = "0x6786310", VA = "0x186787910", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, IEnumerable BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x67876C0", Offset = "0x67860C0", VA = "0x1867876C0", Slot = "5")]
	public IEnumerable DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public EGNNEBGHOEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class DANKDMBADEK : DDBEBCOLMLO<ICollection>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public static readonly DDBEBCOLMLO<ICollection> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x6786780", Offset = "0x6785180", VA = "0x186786780", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, ICollection BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6786530", Offset = "0x6784F30", VA = "0x186786530", Slot = "5")]
	public ICollection DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public DANKDMBADEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class ENMCLBCCDGN : DDBEBCOLMLO<IList>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly DDBEBCOLMLO<IList> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6788440", Offset = "0x6786E40", VA = "0x186788440", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, IList BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x67881F0", Offset = "0x6786BF0", VA = "0x1867881F0", Slot = "5")]
	public IList DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public ENMCLBCCDGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class GEDHFEELKJD<T> : GHFEGCHOOPD<T, AIJEJDOJOPD<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x369B910", Offset = "0x369A310", VA = "0x18369B910", Slot = "8")]
	protected override void DGLLAPEBOKO(AIJEJDOJOPD<T> OJOEBEILHFP, int BNALCEABILL, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x369B850", Offset = "0x369A250", VA = "0x18369B850", Slot = "7")]
	protected override AIJEJDOJOPD<T> CMMJGECCMDN()
	{
		return default(AIJEJDOJOPD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x369B890", Offset = "0x369A290", VA = "0x18369B890", Slot = "9")]
	protected override IReadOnlyList<T> DAFDMKIFLPG(AIJEJDOJOPD<T> FFGFOPKADPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3221F60", Offset = "0x3220960", VA = "0x183221F60")]
	public GEDHFEELKJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class BNBDAMIGAIF
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6783FE0", Offset = "0x67829E0", VA = "0x186783FE0")]
	public static DateTime MFIKNMDNNGN(DateTime LEGCJIBLGJK)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public sealed class OOHMPDOBMFA : DDBEBCOLMLO<DateTime>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public static readonly DDBEBCOLMLO<DateTime> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6794450", Offset = "0x6792E50", VA = "0x186794450", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, DateTime BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6793740", Offset = "0x6792140", VA = "0x186793740", Slot = "5")]
	public DateTime DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public OOHMPDOBMFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class PNMPPFBIMKF : DDBEBCOLMLO<DateTimeOffset>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public static readonly DDBEBCOLMLO<DateTimeOffset> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6795F60", Offset = "0x6794960", VA = "0x186795F60", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, DateTimeOffset BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6795340", Offset = "0x6793D40", VA = "0x186795340", Slot = "5")]
	public DateTimeOffset DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public PNMPPFBIMKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class IBAAKHLLNEP : DDBEBCOLMLO<TimeSpan>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public static readonly DDBEBCOLMLO<TimeSpan> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static byte[] PIDEDMOGGEP;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x678C940", Offset = "0x678B340", VA = "0x18678C940", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, TimeSpan BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x678C030", Offset = "0x678AA30", VA = "0x18678C030", Slot = "5")]
	public TimeSpan DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public IBAAKHLLNEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public abstract class IICEKEECINJ<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : DDBEBCOLMLO<TDictionary>, FBNOOOLMEBG where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3832D10", Offset = "0x3831710", VA = "0x183832D10", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, TDictionary BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x38317A0", Offset = "0x38301A0", VA = "0x1838317A0", Slot = "5")]
	public TDictionary DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator HEPKAEIDFMK(TDictionary DMOGDONOGKM);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate CMMJGECCMDN();

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void DGLLAPEBOKO(TIntermediate OJOEBEILHFP, int BNALCEABILL, TKey FHLJKJHFEEK, TValue BEEGCHJLJFC);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary DAFDMKIFLPG(TIntermediate FFGFOPKADPL);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	protected IICEKEECINJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class AEGHIADFACD<TKey, TValue, TIntermediate, TDictionary> : IICEKEECINJ<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x3660BF0", Offset = "0x365F5F0", VA = "0x183660BF0", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> HEPKAEIDFMK(TDictionary DMOGDONOGKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class GFNINHNLOLG<TKey, TValue, TDictionary> : AEGHIADFACD<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x81DA50", Offset = "0x81C450", VA = "0x18081DA50", Slot = "9")]
	protected override TDictionary DAFDMKIFLPG(TDictionary FFGFOPKADPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class OEKBDKHAFEP<TKey, TValue> : IICEKEECINJ<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x3F7B0B0", Offset = "0x3F79AB0", VA = "0x183F7B0B0", Slot = "8")]
	protected override void DGLLAPEBOKO(Dictionary<TKey, TValue> OJOEBEILHFP, int BNALCEABILL, TKey FHLJKJHFEEK, TValue BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x81DA50", Offset = "0x81C450", VA = "0x18081DA50", Slot = "9")]
	protected override Dictionary<TKey, TValue> DAFDMKIFLPG(Dictionary<TKey, TValue> FFGFOPKADPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x3261150", Offset = "0x325FB50", VA = "0x183261150", Slot = "7")]
	protected override Dictionary<TKey, TValue> CMMJGECCMDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x3F7B150", Offset = "0x3F79B50", VA = "0x183F7B150", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator HEPKAEIDFMK(Dictionary<TKey, TValue> DMOGDONOGKM)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3213EF0", Offset = "0x32128F0", VA = "0x183213EF0")]
	public OEKBDKHAFEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class IGDHNEFNIOJ<TKey, TValue, TDictionary> : GFNINHNLOLG<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x382E600", Offset = "0x382D000", VA = "0x18382E600", Slot = "8")]
	protected override void DGLLAPEBOKO(TDictionary OJOEBEILHFP, int BNALCEABILL, TKey FHLJKJHFEEK, TValue BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x3053E10", Offset = "0x3052810", VA = "0x183053E10", Slot = "7")]
	protected override TDictionary CMMJGECCMDN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class COFEIMCPCKH<TKey, TValue> : AEGHIADFACD<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x3672C80", Offset = "0x3671680", VA = "0x183672C80", Slot = "8")]
	protected override void DGLLAPEBOKO(Dictionary<TKey, TValue> OJOEBEILHFP, int BNALCEABILL, TKey FHLJKJHFEEK, TValue BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x3261150", Offset = "0x325FB50", VA = "0x183261150", Slot = "7")]
	protected override Dictionary<TKey, TValue> CMMJGECCMDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x81DA50", Offset = "0x81C450", VA = "0x18081DA50", Slot = "9")]
	protected override IDictionary<TKey, TValue> DAFDMKIFLPG(Dictionary<TKey, TValue> FFGFOPKADPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class KCDPAJJBBFE<TKey, TValue> : GFNINHNLOLG<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3672C80", Offset = "0x3671680", VA = "0x183672C80", Slot = "8")]
	protected override void DGLLAPEBOKO(SortedList<TKey, TValue> OJOEBEILHFP, int BNALCEABILL, TKey FHLJKJHFEEK, TValue BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3261150", Offset = "0x325FB50", VA = "0x183261150", Slot = "7")]
	protected override SortedList<TKey, TValue> CMMJGECCMDN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class AFFEDJJKFCO<TKey, TValue> : IICEKEECINJ<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x3672C80", Offset = "0x3671680", VA = "0x183672C80", Slot = "8")]
	protected override void DGLLAPEBOKO(SortedDictionary<TKey, TValue> OJOEBEILHFP, int BNALCEABILL, TKey FHLJKJHFEEK, TValue BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x81DA50", Offset = "0x81C450", VA = "0x18081DA50", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> DAFDMKIFLPG(SortedDictionary<TKey, TValue> FFGFOPKADPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3261150", Offset = "0x325FB50", VA = "0x183261150", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> CMMJGECCMDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3672CC0", Offset = "0x36716C0", VA = "0x183672CC0", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator HEPKAEIDFMK(SortedDictionary<TKey, TValue> DMOGDONOGKM)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class EKANJHOIDBL<T> : DDBEBCOLMLO<T>, FBNOOOLMEBG where T : class, IDictionary, new()
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3258830", Offset = "0x3257230", VA = "0x183258830", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, T BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3258590", Offset = "0x3256F90", VA = "0x183258590", Slot = "5")]
	public T DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public EKANJHOIDBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class FBLOFNKDNGP : DDBEBCOLMLO<IDictionary>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public static readonly DDBEBCOLMLO<IDictionary> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x6788E40", Offset = "0x6787840", VA = "0x186788E40", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, IDictionary BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x6788C10", Offset = "0x6787610", VA = "0x186788C10", Slot = "5")]
	public IDictionary DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public FBLOFNKDNGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class LJLNJCPFCCJ : DDBEBCOLMLO<object>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private delegate void IFBGGEJLPOJ(object FLICGNBIJNL, FDFEMMJJDAL HAMBOEKDHKF, object BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private readonly JKJGJCADPNG<KeyValuePair<object, IFBGGEJLPOJ>> CLOFMFOBOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private readonly ANMPFNBLBEK[] PIMGNKGPJBA;

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x6791990", Offset = "0x6790390", VA = "0x186791990")]
	public LJLNJCPFCCJ(params ANMPFNBLBEK[] PIMGNKGPJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6790FD0", Offset = "0x678F9D0", VA = "0x186790FD0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, object BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x6790F40", Offset = "0x678F940", VA = "0x186790F40", Slot = "5")]
	public object DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class JNINKBKOFOB
{
	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x678E3B0", Offset = "0x678CDB0", VA = "0x18678E3B0")]
	public static object CCFEHHDIMCL(Type AKDFFJNHJJN, [Out] bool OCKNMIJLPNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x678ECA0", Offset = "0x678D6A0", VA = "0x18678ECA0")]
	public static object NKEABPLKBCF(Type AKDFFJNHJJN, [Out] bool OCKNMIJLPNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public class HGHACDGCGKN<T> : DDBEBCOLMLO<T>, FBNOOOLMEBG, PCHGBDGIAGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class LEPMNFBNNKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Type type;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public LEPMNFBNNKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x3BCA6C0", Offset = "0x3BC90C0", VA = "0x183BCA6C0")]
		internal bool LJDDKLLHABP(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class LJNKMLEFAIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public string enumName;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public LJNKMLEFAIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x3BEDE50", Offset = "0x3BEC850", VA = "0x183BEDE50")]
		internal bool IPFMLDDJHOG(FieldInfo f)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class CJKBDJFMMJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public MKBLAEGMFIG<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public CJKBDJFMMJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x4CB0550", Offset = "0x4CAEF50", VA = "0x184CB0550")]
		internal void CNACELMBPPP(FDFEMMJJDAL writer, T value, ANMPFNBLBEK _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class GNGHNPNJHOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public DCLFGFAFHHF<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public GNGHNPNJHOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x36BB6C0", Offset = "0x36BA0C0", VA = "0x1836BB6C0")]
		internal T AHHMEMLLLBG(KBBNLCPDBKO reader, ANMPFNBLBEK _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private static readonly BDNCKLJABPP<T> NJBBCHNJKMN;

	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private static readonly Dictionary<T, string> HOEGHGHFHDO;

	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private static readonly MKBLAEGMFIG<T> OLNFLIPNPHG;

	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private static readonly DCLFGFAFHHF<T> HIKAJHJCLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private readonly bool CBJILACCGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private readonly MKBLAEGMFIG<T> HMPDPCGHONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private readonly DCLFGFAFHHF<T> LJKPBONLCDI;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x370BE80", Offset = "0x370A880", VA = "0x18370BE80")]
	static HGHACDGCGKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x37119E0", Offset = "0x37103E0", VA = "0x1837119E0")]
	public HGHACDGCGKN(bool CBJILACCGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x36FC880", Offset = "0x36FB280", VA = "0x1836FC880", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, T BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x36F84D0", Offset = "0x36F6ED0", VA = "0x1836F84D0", Slot = "5")]
	public T DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x36FA3D0", Offset = "0x36F8DD0", VA = "0x1836FA3D0", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, T BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x36F47C0", Offset = "0x36F31C0", VA = "0x1836F47C0", Slot = "7")]
	public T AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class KLKNPLONEHE<T> : DDBEBCOLMLO<T[,]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3AEB360", Offset = "0x3AE9D60", VA = "0x183AEB360", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, T[,] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3AEB030", Offset = "0x3AE9A30", VA = "0x183AEB030", Slot = "5")]
	public T[,] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public KLKNPLONEHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class KCJAGCBCMAB<T> : DDBEBCOLMLO<T[,,]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3ACC2B0", Offset = "0x3ACACB0", VA = "0x183ACC2B0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, T[,,] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3ACBE70", Offset = "0x3ACA870", VA = "0x183ACBE70", Slot = "5")]
	public T[,,] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public KCJAGCBCMAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class OKOFCPPDBCP<T> : DDBEBCOLMLO<T[,,,]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x3F94C10", Offset = "0x3F93610", VA = "0x183F94C10", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, T[,,,] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x3F946C0", Offset = "0x3F930C0", VA = "0x183F946C0", Slot = "5")]
	public T[,,,] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public OKOFCPPDBCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class MPGHEIGHKKJ<T> : DDBEBCOLMLO<T?>, FBNOOOLMEBG where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x3DFBCF0", Offset = "0x3DFA6F0", VA = "0x183DFBCF0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, T? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x3DFBB70", Offset = "0x3DFA570", VA = "0x183DFBB70", Slot = "5")]
	public T? DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public MPGHEIGHKKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class EENIAIDMBJH<T> : DDBEBCOLMLO<T?>, FBNOOOLMEBG where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private readonly DDBEBCOLMLO<T> PICCINGKGPL;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
	public EENIAIDMBJH(DDBEBCOLMLO<T> PICCINGKGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3244270", Offset = "0x3242C70", VA = "0x183244270", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, T? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3241EE0", Offset = "0x32408E0", VA = "0x183241EE0", Slot = "5")]
	public T? DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class LBCEHJHAJKH : DDBEBCOLMLO<sbyte>, FBNOOOLMEBG, PCHGBDGIAGD<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly LBCEHJHAJKH MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6790390", Offset = "0x678ED90", VA = "0x186790390", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, sbyte BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x67902D0", Offset = "0x678ECD0", VA = "0x1867902D0", Slot = "5")]
	public sbyte DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6790320", Offset = "0x678ED20", VA = "0x186790320", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, sbyte BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6790210", Offset = "0x678EC10", VA = "0x186790210", Slot = "7")]
	public sbyte AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public LBCEHJHAJKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class ADEAKLEPLMB : DDBEBCOLMLO<sbyte?>, FBNOOOLMEBG, PCHGBDGIAGD<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly ADEAKLEPLMB MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6783C40", Offset = "0x6782640", VA = "0x186783C40", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, sbyte? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6783AD0", Offset = "0x67824D0", VA = "0x186783AD0", Slot = "5")]
	public sbyte? DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x6783B80", Offset = "0x6782580", VA = "0x186783B80", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, sbyte? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x67839B0", Offset = "0x67823B0", VA = "0x1867839B0", Slot = "7")]
	public sbyte? AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public ADEAKLEPLMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class GHFFLCGEKOB : DDBEBCOLMLO<sbyte[]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly GHFFLCGEKOB MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x678A000", Offset = "0x6788A00", VA = "0x18678A000", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, sbyte[] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x6789E70", Offset = "0x6788870", VA = "0x186789E70", Slot = "5")]
	public sbyte[] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public GHFFLCGEKOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class LBPNAGLDHMK : DDBEBCOLMLO<short>, FBNOOOLMEBG, PCHGBDGIAGD<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly LBPNAGLDHMK MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x67905F0", Offset = "0x678EFF0", VA = "0x1867905F0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, short BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x6790530", Offset = "0x678EF30", VA = "0x186790530", Slot = "5")]
	public short DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x6790580", Offset = "0x678EF80", VA = "0x186790580", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, short BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x6790470", Offset = "0x678EE70", VA = "0x186790470", Slot = "7")]
	public short AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public LBPNAGLDHMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class KGPEDADIFDC : DDBEBCOLMLO<short?>, FBNOOOLMEBG, PCHGBDGIAGD<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly KGPEDADIFDC MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x678FBF0", Offset = "0x678E5F0", VA = "0x18678FBF0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, short? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x678FA80", Offset = "0x678E480", VA = "0x18678FA80", Slot = "5")]
	public short? DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x678FB30", Offset = "0x678E530", VA = "0x18678FB30", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, short? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x678F960", Offset = "0x678E360", VA = "0x18678F960", Slot = "7")]
	public short? AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public KGPEDADIFDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class ABKNPNKNJML : DDBEBCOLMLO<short[]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly ABKNPNKNJML MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6783800", Offset = "0x6782200", VA = "0x186783800", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, short[] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6783670", Offset = "0x6782070", VA = "0x186783670", Slot = "5")]
	public short[] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public ABKNPNKNJML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class IMGMMFDPEIC : DDBEBCOLMLO<int>, FBNOOOLMEBG, PCHGBDGIAGD<int>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly IMGMMFDPEIC MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x678D730", Offset = "0x678C130", VA = "0x18678D730", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, int BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x678D670", Offset = "0x678C070", VA = "0x18678D670", Slot = "5")]
	public int DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x678D6C0", Offset = "0x678C0C0", VA = "0x18678D6C0", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, int BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x678D5B0", Offset = "0x678BFB0", VA = "0x18678D5B0", Slot = "7")]
	public int AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public IMGMMFDPEIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class JHMGNFOLGAG : DDBEBCOLMLO<int?>, FBNOOOLMEBG, PCHGBDGIAGD<int?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly JHMGNFOLGAG MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x678DE70", Offset = "0x678C870", VA = "0x18678DE70", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, int? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x678DD00", Offset = "0x678C700", VA = "0x18678DD00", Slot = "5")]
	public int? DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x678DDB0", Offset = "0x678C7B0", VA = "0x18678DDB0", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, int? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x678DBE0", Offset = "0x678C5E0", VA = "0x18678DBE0", Slot = "7")]
	public int? AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public JHMGNFOLGAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class MNCJBJBGKDA : DDBEBCOLMLO<int[]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly MNCJBJBGKDA MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x67926E0", Offset = "0x67910E0", VA = "0x1867926E0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, int[] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x6792550", Offset = "0x6790F50", VA = "0x186792550", Slot = "5")]
	public int[] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public MNCJBJBGKDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class AEIKGDMHHOH : DDBEBCOLMLO<long>, FBNOOOLMEBG, PCHGBDGIAGD<long>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly AEIKGDMHHOH MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6783F00", Offset = "0x6782900", VA = "0x186783F00", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, long BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x6783E40", Offset = "0x6782840", VA = "0x186783E40", Slot = "5")]
	public long DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x6783E90", Offset = "0x6782890", VA = "0x186783E90", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, long BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x6783D80", Offset = "0x6782780", VA = "0x186783D80", Slot = "7")]
	public long AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public AEIKGDMHHOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class JINEIDGCOAO : DDBEBCOLMLO<long?>, FBNOOOLMEBG, PCHGBDGIAGD<long?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly JINEIDGCOAO MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x678E270", Offset = "0x678CC70", VA = "0x18678E270", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, long? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x678E0F0", Offset = "0x678CAF0", VA = "0x18678E0F0", Slot = "5")]
	public long? DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x678E1B0", Offset = "0x678CBB0", VA = "0x18678E1B0", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, long? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x678DFB0", Offset = "0x678C9B0", VA = "0x18678DFB0", Slot = "7")]
	public long? AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public JINEIDGCOAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class PMIJCDHGPCK : DDBEBCOLMLO<long[]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly PMIJCDHGPCK MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x6795190", Offset = "0x6793B90", VA = "0x186795190", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, long[] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6795000", Offset = "0x6793A00", VA = "0x186795000", Slot = "5")]
	public long[] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public PMIJCDHGPCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class COGIJILCCPH : DDBEBCOLMLO<byte>, FBNOOOLMEBG, PCHGBDGIAGD<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly COGIJILCCPH MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6784B90", Offset = "0x6783590", VA = "0x186784B90", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, byte BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6784AD0", Offset = "0x67834D0", VA = "0x186784AD0", Slot = "5")]
	public byte DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6784B20", Offset = "0x6783520", VA = "0x186784B20", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, byte BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6784A10", Offset = "0x6783410", VA = "0x186784A10", Slot = "7")]
	public byte AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public COGIJILCCPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class HOILMNCLJJM : DDBEBCOLMLO<byte?>, FBNOOOLMEBG, PCHGBDGIAGD<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly HOILMNCLJJM MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x678BEF0", Offset = "0x678A8F0", VA = "0x18678BEF0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, byte? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x678BD80", Offset = "0x678A780", VA = "0x18678BD80", Slot = "5")]
	public byte? DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x678BE30", Offset = "0x678A830", VA = "0x18678BE30", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, byte? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x678BC60", Offset = "0x678A660", VA = "0x18678BC60", Slot = "7")]
	public byte? AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public HOILMNCLJJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class MKBIJPJFDPG : DDBEBCOLMLO<ushort>, FBNOOOLMEBG, PCHGBDGIAGD<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly MKBIJPJFDPG MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6792270", Offset = "0x6790C70", VA = "0x186792270", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, ushort BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x67921B0", Offset = "0x6790BB0", VA = "0x1867921B0", Slot = "5")]
	public ushort DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x6792200", Offset = "0x6790C00", VA = "0x186792200", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, ushort BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x67920F0", Offset = "0x6790AF0", VA = "0x1867920F0", Slot = "7")]
	public ushort AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public MKBIJPJFDPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class IOKIOEEFBKM : DDBEBCOLMLO<ushort?>, FBNOOOLMEBG, PCHGBDGIAGD<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly IOKIOEEFBKM MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x678DAA0", Offset = "0x678C4A0", VA = "0x18678DAA0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, ushort? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x678D930", Offset = "0x678C330", VA = "0x18678D930", Slot = "5")]
	public ushort? DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x678D9E0", Offset = "0x678C3E0", VA = "0x18678D9E0", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, ushort? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x678D810", Offset = "0x678C210", VA = "0x18678D810", Slot = "7")]
	public ushort? AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public IOKIOEEFBKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class BPEMCKDGMOD : DDBEBCOLMLO<ushort[]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly BPEMCKDGMOD MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6784230", Offset = "0x6782C30", VA = "0x186784230", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, ushort[] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x67840A0", Offset = "0x6782AA0", VA = "0x1867840A0", Slot = "5")]
	public ushort[] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public BPEMCKDGMOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class FIOIPCBHFOP : DDBEBCOLMLO<uint>, FBNOOOLMEBG, PCHGBDGIAGD<uint>
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly FIOIPCBHFOP MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6789700", Offset = "0x6788100", VA = "0x186789700", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, uint BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6789640", Offset = "0x6788040", VA = "0x186789640", Slot = "5")]
	public uint DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6789690", Offset = "0x6788090", VA = "0x186789690", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, uint BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x6789580", Offset = "0x6787F80", VA = "0x186789580", Slot = "7")]
	public uint AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public FIOIPCBHFOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class CGJIOMFMJEB : DDBEBCOLMLO<uint?>, FBNOOOLMEBG, PCHGBDGIAGD<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly CGJIOMFMJEB MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x6784670", Offset = "0x6783070", VA = "0x186784670", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, uint? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x6784500", Offset = "0x6782F00", VA = "0x186784500", Slot = "5")]
	public uint? DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x67845B0", Offset = "0x6782FB0", VA = "0x1867845B0", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, uint? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x67843E0", Offset = "0x6782DE0", VA = "0x1867843E0", Slot = "7")]
	public uint? AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public CGJIOMFMJEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class IFMDKMEFMMF : DDBEBCOLMLO<uint[]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly IFMDKMEFMMF MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x678D160", Offset = "0x678BB60", VA = "0x18678D160", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, uint[] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x678CFD0", Offset = "0x678B9D0", VA = "0x18678CFD0", Slot = "5")]
	public uint[] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public IFMDKMEFMMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class LGDHBBONPHL : DDBEBCOLMLO<ulong>, FBNOOOLMEBG, PCHGBDGIAGD<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly LGDHBBONPHL MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x6790E60", Offset = "0x678F860", VA = "0x186790E60", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, ulong BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6790DA0", Offset = "0x678F7A0", VA = "0x186790DA0", Slot = "5")]
	public ulong DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x6790DF0", Offset = "0x678F7F0", VA = "0x186790DF0", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, ulong BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x6790CE0", Offset = "0x678F6E0", VA = "0x186790CE0", Slot = "7")]
	public ulong AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public LGDHBBONPHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class LCDOIBIJFCN : DDBEBCOLMLO<ulong?>, FBNOOOLMEBG, PCHGBDGIAGD<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly LCDOIBIJFCN MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x6790990", Offset = "0x678F390", VA = "0x186790990", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, ulong? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x6790810", Offset = "0x678F210", VA = "0x186790810", Slot = "5")]
	public ulong? DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x67908D0", Offset = "0x678F2D0", VA = "0x1867908D0", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, ulong? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x67906D0", Offset = "0x678F0D0", VA = "0x1867906D0", Slot = "7")]
	public ulong? AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public LCDOIBIJFCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class FLDDPOPBMIG : DDBEBCOLMLO<ulong[]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly FLDDPOPBMIG MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x6789970", Offset = "0x6788370", VA = "0x186789970", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, ulong[] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x67897E0", Offset = "0x67881E0", VA = "0x1867897E0", Slot = "5")]
	public ulong[] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public FLDDPOPBMIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class EHMMPDKEMFI : DDBEBCOLMLO<float>, FBNOOOLMEBG, PCHGBDGIAGD<float>
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly EHMMPDKEMFI MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x6788110", Offset = "0x6786B10", VA = "0x186788110", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, float BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x6788050", Offset = "0x6786A50", VA = "0x186788050", Slot = "5")]
	public float DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x67880A0", Offset = "0x6786AA0", VA = "0x1867880A0", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, float BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x6787F90", Offset = "0x6786990", VA = "0x186787F90", Slot = "7")]
	public float AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public EHMMPDKEMFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class HLPNAOMAAHL : DDBEBCOLMLO<float?>, FBNOOOLMEBG, PCHGBDGIAGD<float?>
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly HLPNAOMAAHL MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x678B930", Offset = "0x678A330", VA = "0x18678B930", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, float? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x678B7C0", Offset = "0x678A1C0", VA = "0x18678B7C0", Slot = "5")]
	public float? DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x678B870", Offset = "0x678A270", VA = "0x18678B870", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, float? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x678B6A0", Offset = "0x678A0A0", VA = "0x18678B6A0", Slot = "7")]
	public float? AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public HLPNAOMAAHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class FMOBMIJHMKD : DDBEBCOLMLO<float[]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly FMOBMIJHMKD MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x6789CB0", Offset = "0x67886B0", VA = "0x186789CB0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, float[] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6789B20", Offset = "0x6788520", VA = "0x186789B20", Slot = "5")]
	public float[] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public FMOBMIJHMKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class DKPICCLHGLE : DDBEBCOLMLO<double>, FBNOOOLMEBG, PCHGBDGIAGD<double>
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly DKPICCLHGLE MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6786F30", Offset = "0x6785930", VA = "0x186786F30", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, double BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6786E70", Offset = "0x6785870", VA = "0x186786E70", Slot = "5")]
	public double DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6786EC0", Offset = "0x67858C0", VA = "0x186786EC0", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, double BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6786DB0", Offset = "0x67857B0", VA = "0x186786DB0", Slot = "7")]
	public double AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public DKPICCLHGLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class OGCONMEFFDL : DDBEBCOLMLO<double?>, FBNOOOLMEBG, PCHGBDGIAGD<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly OGCONMEFFDL MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6793600", Offset = "0x6792000", VA = "0x186793600", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, double? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6793480", Offset = "0x6791E80", VA = "0x186793480", Slot = "5")]
	public double? DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6793540", Offset = "0x6791F40", VA = "0x186793540", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, double? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6793340", Offset = "0x6791D40", VA = "0x186793340", Slot = "7")]
	public double? AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public OGCONMEFFDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class EGNPLGEFPJJ : DDBEBCOLMLO<double[]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly EGNPLGEFPJJ MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6787DD0", Offset = "0x67867D0", VA = "0x186787DD0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, double[] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6787C40", Offset = "0x6786640", VA = "0x186787C40", Slot = "5")]
	public double[] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public EGNPLGEFPJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class CLAPBFLPKBA : DDBEBCOLMLO<bool>, FBNOOOLMEBG, PCHGBDGIAGD<bool>
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly CLAPBFLPKBA MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6784930", Offset = "0x6783330", VA = "0x186784930", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, bool BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6784870", Offset = "0x6783270", VA = "0x186784870", Slot = "5")]
	public bool DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x67848C0", Offset = "0x67832C0", VA = "0x1867848C0", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, bool BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x67847B0", Offset = "0x67831B0", VA = "0x1867847B0", Slot = "7")]
	public bool AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public CLAPBFLPKBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class JPFOMOBDBCJ : DDBEBCOLMLO<bool?>, FBNOOOLMEBG, PCHGBDGIAGD<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly JPFOMOBDBCJ MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x678F820", Offset = "0x678E220", VA = "0x18678F820", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, bool? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x678F6B0", Offset = "0x678E0B0", VA = "0x18678F6B0", Slot = "5")]
	public bool? DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x678F760", Offset = "0x678E160", VA = "0x18678F760", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, bool? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x678F590", Offset = "0x678DF90", VA = "0x18678F590", Slot = "7")]
	public bool? AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public JPFOMOBDBCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class NBPBALADKGE : DDBEBCOLMLO<bool[]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly NBPBALADKGE MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6792D90", Offset = "0x6791790", VA = "0x186792D90", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, bool[] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6792C00", Offset = "0x6791600", VA = "0x186792C00", Slot = "5")]
	public bool[] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public NBPBALADKGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class GKHLLNAILDK : DDBEBCOLMLO<object>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly DDBEBCOLMLO<object> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static readonly Dictionary<Type, int> CEDMCACIBIC;

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x678A5F0", Offset = "0x6788FF0", VA = "0x18678A5F0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, object BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x678A1B0", Offset = "0x6788BB0", VA = "0x18678A1B0", Slot = "5")]
	public object DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public GKHLLNAILDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class HOICOKDMHBG : DDBEBCOLMLO<byte[]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly DDBEBCOLMLO<byte[]> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x678BB20", Offset = "0x678A520", VA = "0x18678BB20", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, byte[] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x678BA70", Offset = "0x678A470", VA = "0x18678BA70", Slot = "5")]
	public byte[] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public HOICOKDMHBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class KHADDGABFPH : DDBEBCOLMLO<ArraySegment<byte>>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly DDBEBCOLMLO<ArraySegment<byte>> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x678FE40", Offset = "0x678E840", VA = "0x18678FE40", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, ArraySegment<byte> BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x678FD30", Offset = "0x678E730", VA = "0x18678FD30", Slot = "5")]
	public ArraySegment<byte> DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public KHADDGABFPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class MHKMPHNNPOL : DDBEBCOLMLO<string>, FBNOOOLMEBG, PCHGBDGIAGD<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly DDBEBCOLMLO<string> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6792010", Offset = "0x6790A10", VA = "0x186792010", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, string BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x6791F60", Offset = "0x6790960", VA = "0x186791F60", Slot = "5")]
	public string DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x6791FB0", Offset = "0x67909B0", VA = "0x186791FB0", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, string BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6791F10", Offset = "0x6790910", VA = "0x186791F10", Slot = "7")]
	public string AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public MHKMPHNNPOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class PLNGPFNJOHK : DDBEBCOLMLO<string[]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly PLNGPFNJOHK MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6794E50", Offset = "0x6793850", VA = "0x186794E50", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, string[] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6794C80", Offset = "0x6793680", VA = "0x186794C80", Slot = "5")]
	public string[] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public PLNGPFNJOHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class DONKGHBFBCH : DDBEBCOLMLO<char>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly DONKGHBFBCH MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x67873A0", Offset = "0x6785DA0", VA = "0x1867873A0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, char BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x6787330", Offset = "0x6785D30", VA = "0x186787330", Slot = "5")]
	public char DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public DONKGHBFBCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class IKFMLPPAPEI : DDBEBCOLMLO<char?>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly IKFMLPPAPEI MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x678D430", Offset = "0x678BE30", VA = "0x18678D430", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, char? BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x678D310", Offset = "0x678BD10", VA = "0x18678D310", Slot = "5")]
	public char? DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public IKFMLPPAPEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class NOBKFFJNNII : DDBEBCOLMLO<char[]>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly NOBKFFJNNII MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x6793110", Offset = "0x6791B10", VA = "0x186793110", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, char[] BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x6792F50", Offset = "0x6791950", VA = "0x186792F50", Slot = "5")]
	public char[] DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public NOBKFFJNNII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class FADDMPKGCIN : DDBEBCOLMLO<Guid>, FBNOOOLMEBG, PCHGBDGIAGD<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	public static readonly DDBEBCOLMLO<Guid> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x6788A60", Offset = "0x6787460", VA = "0x186788A60", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, Guid BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x6788890", Offset = "0x6787290", VA = "0x186788890", Slot = "5")]
	public Guid DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x6788920", Offset = "0x6787320", VA = "0x186788920", Slot = "6")]
	public void IFLMCKEKFOE(FDFEMMJJDAL HAMBOEKDHKF, Guid BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x67887F0", Offset = "0x67871F0", VA = "0x1867887F0", Slot = "7")]
	public Guid AGBHDHGFDNE(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public FADDMPKGCIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class LLGHINANDFG : DDBEBCOLMLO<decimal>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	public static readonly DDBEBCOLMLO<decimal> MBNAEHMDPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private readonly bool JHHOHLIIHCN;

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5187FB0", Offset = "0x51869B0", VA = "0x185187FB0")]
	public LLGHINANDFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x171E060", Offset = "0x171CA60", VA = "0x18171E060")]
	public LLGHINANDFG(bool JHHOHLIIHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x6791CE0", Offset = "0x67906E0", VA = "0x186791CE0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, decimal BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6791A40", Offset = "0x6790440", VA = "0x186791A40", Slot = "5")]
	public decimal DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class LACBGOBKEPP : DDBEBCOLMLO<Uri>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public static readonly DDBEBCOLMLO<Uri> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x67900B0", Offset = "0x678EAB0", VA = "0x1867900B0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, Uri BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x678FFF0", Offset = "0x678E9F0", VA = "0x18678FFF0", Slot = "5")]
	public Uri DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public LACBGOBKEPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class MKHLDGFBNDE : DDBEBCOLMLO<Version>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public static readonly DDBEBCOLMLO<Version> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x6792410", Offset = "0x6790E10", VA = "0x186792410", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, Version BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x6792350", Offset = "0x6790D50", VA = "0x186792350", Slot = "5")]
	public Version DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public MKHLDGFBNDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class FGLGHHFGLFK<TKey, TValue> : DDBEBCOLMLO<KeyValuePair<TKey, TValue>>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x35BF6C0", Offset = "0x35BE0C0", VA = "0x1835BF6C0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, KeyValuePair<TKey, TValue> BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x35BF390", Offset = "0x35BDD90", VA = "0x1835BF390", Slot = "5")]
	public KeyValuePair<TKey, TValue> DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return default(KeyValuePair<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class EECOIEDJKOO : DDBEBCOLMLO<StringBuilder>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly DDBEBCOLMLO<StringBuilder> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x67875A0", Offset = "0x6785FA0", VA = "0x1867875A0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, StringBuilder BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x67874E0", Offset = "0x6785EE0", VA = "0x1867874E0", Slot = "5")]
	public StringBuilder DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public EECOIEDJKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class DLNPECEOEBH : DDBEBCOLMLO<BitArray>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly DDBEBCOLMLO<BitArray> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x6787190", Offset = "0x6785B90", VA = "0x186787190", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, BitArray BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x6787010", Offset = "0x6785A10", VA = "0x186787010", Slot = "5")]
	public BitArray DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public DLNPECEOEBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class NABKPBOCEHN : DDBEBCOLMLO<Type>, FBNOOOLMEBG
{
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly NABKPBOCEHN MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static readonly Regex EOCPIKJDLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private bool IHAJOFJAKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private bool DKNIHFBALMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private bool DHLAHHKGACN;

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x6792BE0", Offset = "0x67915E0", VA = "0x186792BE0")]
	public NABKPBOCEHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4210", Offset = "0x5EF2C10", VA = "0x185EF4210")]
	public NABKPBOCEHN(bool IHAJOFJAKHG, bool DKNIHFBALMN, bool DHLAHHKGACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x67929E0", Offset = "0x67913E0", VA = "0x1867929E0", Slot = "4")]
	public void JLKDILEIJOC(FDFEMMJJDAL HAMBOEKDHKF, Type BEEGCHJLJFC, ANMPFNBLBEK NLMEKPCHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x6792890", Offset = "0x6791290", VA = "0x186792890", Slot = "5")]
	public Type DCJJDHFPDEL(KBBNLCPDBKO HPEAJCENMCM, ANMPFNBLBEK NLMEKPCHKHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal static class DCEGCLBLPOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal static readonly byte[][] EICFJPGAIPK;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal static readonly BJBCIHBIFOH KHPKMIHPADH;

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6786BA0", Offset = "0x67855A0", VA = "0x186786BA0")]
	static DCEGCLBLPOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class LEGBAEPLALB
{
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal static readonly byte[][] BNPOJIGHKJM;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal static readonly BJBCIHBIFOH OGNMNILEPMH;

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6790AD0", Offset = "0x678F4D0", VA = "0x186790AD0")]
	static LEGBAEPLALB()
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
