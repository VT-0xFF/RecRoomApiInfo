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
public class BBBMIAPLLMP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x576690", Offset = "0x574E90", VA = "0x180576690")]
	public BBBMIAPLLMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class HCIOICBPFPC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x576690", Offset = "0x574E90", VA = "0x180576690")]
	public HCIOICBPFPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class KNNLAIHFDDF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x576690", Offset = "0x574E90", VA = "0x180576690")]
	public KNNLAIHFDDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class ONMEGGPDJIF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x576690", Offset = "0x574E90", VA = "0x180576690")]
	public ONMEGGPDJIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class ACEDMAKHBDF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3795470", Offset = "0x3793C70", VA = "0x183795470")]
	public static bool EILLOACINIE(this TypeInfo LIBGCFIILKM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface)]
public class PGIFLCHMPLG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type BDFLLECDNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5DDA30", Offset = "0x5DC230", VA = "0x1805DDA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public object[] CJKDDELFDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x9138F0", Offset = "0x9120F0", VA = "0x1809138F0")]
	public PGIFLCHMPLG(Type PDFJACFBCIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Constructor)]
public class BELDDFJMFCN : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public delegate void PIJOLNNEIFE<T>(ref KKHNLIPNMHK PJJBCJIGKFL, T HKJMLEKHILN, PCBNCCNNPBE GJEDPGEKLIK);
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate T GGBGKFKCALO<T>(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE GJEDPGEKLIK);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MAIGLFCCAEJ
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KAKKFHPFHDD<T> : MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, T HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MLEINHMADLI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, T HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum GPJFFKPKHLA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	OverwriteReplace
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::KAKKFHPFHDD<T> JEEANJHLNBK<T>();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BNNAIELHILL
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x29AAC10", Offset = "0x29A9410", VA = "0x1829AAC10")]
	public static global::KAKKFHPFHDD<T> GPJGPKHMNPE<T>(this PCBNCCNNPBE GJEDPGEKLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x379A380", Offset = "0x3798B80", VA = "0x18379A380")]
	public static object DGKHGBCFHML(this PCBNCCNNPBE GJEDPGEKLIK, Type LIBGCFIILKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MNDAMHELBJA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2B86A40", Offset = "0x2B85240", VA = "0x182B86A40")]
	public MNDAMHELBJA(string BOBNBIKICDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FGKANONAPNL
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal static class KBDNFNKNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[ThreadStatic]
		private static byte[] AFIAMHMLMFM;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[ThreadStatic]
		private static char[] ODDKJDIFOGH;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x37ACC90", Offset = "0x37AB490", VA = "0x1837ACC90")]
		public static byte[] BMMCNOMJGIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x37ACD10", Offset = "0x37AB510", VA = "0x1837ACD10")]
		public static char[] ONLKBLKJKDD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ArraySegment<byte> IBECPONEDGH;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly byte[] EFEDCHEGENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly byte[] IFAOIOLKGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int FHLPLLKMCOH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool BIMCOEBNONL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x37A48F0", Offset = "0x37A30F0", VA = "0x1837A48F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x37A5930", Offset = "0x37A4130", VA = "0x1837A5930")]
	public FGKANONAPNL(byte[] IFAOIOLKGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x37A5940", Offset = "0x37A4140", VA = "0x1837A5940")]
	public FGKANONAPNL(byte[] IFAOIOLKGMC, int FHLPLLKMCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x37A2F60", Offset = "0x37A1760", VA = "0x1837A2F60")]
	private MBPKLAEHFHJ AGKGHILOHEE(string MLCOPFDJOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x37A5080", Offset = "0x37A3880", VA = "0x1837A5080")]
	private MBPKLAEHFHJ NMDHLCCNLAA(string BOBNBIKICDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EED0", Offset = "0x2B7D6D0", VA = "0x182B7EED0")]
	public void OKFFBNCIJFB(int FHLPLLKMCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60DD50", Offset = "0x60C550", VA = "0x18060DD50")]
	public byte[] PGMJMJIHPJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6EE570", Offset = "0x6ECD70", VA = "0x1806EE570")]
	public int BPNFCHOOLME()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x37A4EF0", Offset = "0x37A36F0", VA = "0x1837A4EF0")]
	public HLHPAPKBDDM NJJFFDMGIEB()
	{
		return default(HLHPAPKBDDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x37A5430", Offset = "0x37A3C30", VA = "0x1837A5430")]
	public void OGEDLJEGICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x37A4D60", Offset = "0x37A3560", VA = "0x1837A4D60")]
	public bool NAMNKBLNLAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x37A4760", Offset = "0x37A2F60", VA = "0x1837A4760")]
	public bool LAEHCODHIAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x37A42C0", Offset = "0x37A2AC0", VA = "0x1837A42C0")]
	public void GOKMDMPLAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x37A4530", Offset = "0x37A2D30", VA = "0x1837A4530")]
	public bool JCEBKMNNPPC(ref int NLKMJJJPIDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x37A5160", Offset = "0x37A3960", VA = "0x1837A5160")]
	public bool NONGCKMLAAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x37A57B0", Offset = "0x37A3FB0", VA = "0x1837A57B0")]
	public void PNJKMGODPEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x37A37F0", Offset = "0x37A1FF0", VA = "0x1837A37F0")]
	public bool BMENPHJFMFP(ref int NLKMJJJPIDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x37A38E0", Offset = "0x37A20E0", VA = "0x1837A38E0")]
	public bool DABAKKBHKHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x37A5570", Offset = "0x37A3D70", VA = "0x1837A5570")]
	public void OKBFHALHGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x37A4970", Offset = "0x37A3170", VA = "0x1837A4970")]
	public bool MDEKCMHAFFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x37A2EC0", Offset = "0x37A16C0", VA = "0x1837A2EC0")]
	public void AGFCPMEAGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x37A3A00", Offset = "0x37A2200", VA = "0x1837A3A00")]
	private void EINCPBKAKCL(out byte[] AJACEIBJLIJ, out int JEOMCHOIODF, out int HLJJEIDDGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x37A46B0", Offset = "0x37A2EB0", VA = "0x1837A46B0")]
	private static int KHOFFMPKPAM(char FCCDOLKCOHD, char EOEFACHALFF, char NBFCFFGLCPM, char NAIPFDPNHDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x37A4820", Offset = "0x37A3020", VA = "0x1837A4820")]
	private static int LIMCIFPILLP(char FNGOAMCGAPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x37A45C0", Offset = "0x37A2DC0", VA = "0x1837A45C0")]
	public ArraySegment<byte> KCPIGENIHAP()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x37A4360", Offset = "0x37A2B60", VA = "0x1837A4360")]
	public string HCMJCHKEIEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x37A3950", Offset = "0x37A2150", VA = "0x1837A3950")]
	public string DCDNKLIPCEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x37A49E0", Offset = "0x37A31E0", VA = "0x1837A49E0")]
	public ArraySegment<byte> MEIAEOKNIPM()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x37A37B0", Offset = "0x37A1FB0", VA = "0x1837A37B0")]
	public ArraySegment<byte> BKFGILODKLL()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x37A51D0", Offset = "0x37A39D0", VA = "0x1837A51D0")]
	public bool NONJHAGJMLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x37A36F0", Offset = "0x37A1EF0", VA = "0x1837A36F0")]
	private static bool BCKLHDIDLMJ(byte NBFCFFGLCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x37A4B90", Offset = "0x37A3390", VA = "0x1837A4B90")]
	private void MJHGDDFONEB(HLHPAPKBDDM FIGDHHNIEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x37A4EE0", Offset = "0x37A36E0", VA = "0x1837A4EE0")]
	public void NJCNBBMGCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x37A4400", Offset = "0x37A2C00", VA = "0x1837A4400")]
	private void HFJNDAIKFPE(int ABKDEGGBIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x37A47D0", Offset = "0x37A2FD0", VA = "0x1837A47D0")]
	public sbyte LDFJIJIJFLL()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x37A44D0", Offset = "0x37A2CD0", VA = "0x1837A44D0")]
	public short IJKFACLMHMH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x37A3880", Offset = "0x37A2080", VA = "0x1837A3880")]
	public int CJOEAOIMDFH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x37A3670", Offset = "0x37A1E70", VA = "0x1837A3670")]
	public long BCAEBHGAJLF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x37A5750", Offset = "0x37A3F50", VA = "0x1837A5750")]
	public byte PIADJCBMAEG()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x37A4E80", Offset = "0x37A3680", VA = "0x1837A4E80")]
	public ushort NFNAJODNOAL()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x37A4910", Offset = "0x37A3110", VA = "0x1837A4910")]
	public uint MBNGBCINGEO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x37A3980", Offset = "0x37A2180", VA = "0x1837A3980")]
	public ulong DFAJCKOAJJC()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x37A5610", Offset = "0x37A3E10", VA = "0x1837A5610")]
	public float OKIJIGFBEMF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x37A4190", Offset = "0x37A2990", VA = "0x1837A4190")]
	public double EJLDPOPGGLL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x37A3400", Offset = "0x37A1C00", VA = "0x1837A3400")]
	public ArraySegment<byte> AICEKMONOHF()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x37A34F0", Offset = "0x37A1CF0", VA = "0x1837A34F0")]
	private static int BBEHGHOGNLK(byte[] IFAOIOLKGMC, int FHLPLLKMCOH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MBPKLAEHFHJ : Exception
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private WeakReference FGODLJKIDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int HHJNMEOGIKH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int LKBPBEBJPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x19BE280", Offset = "0x19BCA80", VA = "0x1819BE280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string LDJKEOMBAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6A6DB0", Offset = "0x6A55B0", VA = "0x1806A6DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2B82950", Offset = "0x2B81150", VA = "0x182B82950")]
	public MBPKLAEHFHJ(string BOBNBIKICDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2B829C0", Offset = "0x2B811C0", VA = "0x182B829C0")]
	public MBPKLAEHFHJ(string BOBNBIKICDK, byte[] BPCHBBGBBPB, int FHLPLLKMCOH, int HHJNMEOGIKH, string LBDIOLLLJGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JIOOCPEGPJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class CJPJNDFMHHK
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private delegate void GKJOOIGKALG(ref KKHNLIPNMHK PJJBCJIGKFL, object HKJMLEKHILN, PCBNCCNNPBE GJEDPGEKLIK);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private delegate object FABJCAEGBJF(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE GJEDPGEKLIK);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class MEJDDBHHIIL
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			[CompilerGenerated]
			private sealed class LBELMKCPIJO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public Type[] arguments;

				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
				public LBELMKCPIJO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2B805D0", Offset = "0x2B7EDD0", VA = "0x182B805D0")]
				internal bool <GetMethod>b__0(MethodInfo x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x2B80610", Offset = "0x2B7EE10", VA = "0x182B80610")]
				internal bool <GetMethod>b__1(MethodInfo x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Func<object, PCBNCCNNPBE, byte[]> EBOOCAFGJBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly Action<Stream, object, PCBNCCNNPBE> HHLJOPGODOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly GKJOOIGKALG ECABENJKNMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly Func<object, PCBNCCNNPBE, ArraySegment<byte>> LNGHCEJBDJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly Func<object, PCBNCCNNPBE, string> DMEPFKLJBOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly Func<string, PCBNCCNNPBE, object> HLDCOJJMOFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly Func<byte[], int, PCBNCCNNPBE, object> OBBJPGJHCNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly Func<Stream, PCBNCCNNPBE, object> CIIMBLNKOOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly FABJCAEGBJF HBGPCCMBOHO;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2B82E90", Offset = "0x2B81690", VA = "0x182B82E90")]
			public MEJDDBHHIIL(Type LIBGCFIILKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x239E160", Offset = "0x239C960", VA = "0x18239E160")]
			private static T DJMNGIDCINA<T>(DynamicMethod PIJIKLIHKDJ)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2B82CA0", Offset = "0x2B814A0", VA = "0x182B82CA0")]
			private static MethodInfo NBKCNMDMOID(Type LIBGCFIILKM, string CGCECGHBEEN, Type[] DLIAMCEIIDM)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly Func<Type, MEJDDBHHIIL> IPKMACMGEAI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly global::FHAOIIHIFOM<MEJDDBHHIIL> BCDOOPPIIBA;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2B77740", Offset = "0x2B75F40", VA = "0x182B77740")]
		static CJPJNDFMHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2B776C0", Offset = "0x2B75EC0", VA = "0x182B776C0")]
		private static MEJDDBHHIIL JLHEHMNBADA(Type LIBGCFIILKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2B77550", Offset = "0x2B75D50", VA = "0x182B77550")]
		public static void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, object HKJMLEKHILN, PCBNCCNNPBE GJEDPGEKLIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B77440", Offset = "0x2B75C40", VA = "0x182B77440")]
		public static void IICNIKFAIFP(Type LIBGCFIILKM, ref KKHNLIPNMHK PJJBCJIGKFL, object HKJMLEKHILN, PCBNCCNNPBE GJEDPGEKLIK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private static class BFAOPMIFNHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[ThreadStatic]
		private static byte[] AFIAMHMLMFM;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B773C0", Offset = "0x2B75BC0", VA = "0x182B773C0")]
		public static byte[] BMMCNOMJGIG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static PCBNCCNNPBE FFKLFFJKDML;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly byte[][] CFBNJGDGBGB;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly byte[] DACONILELEC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static PCBNCCNNPBE DOPKDIDKHNE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2B7CBA0", Offset = "0x2B7B3A0", VA = "0x182B7CBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2B7CB40", Offset = "0x2B7B340", VA = "0x182B7CB40")]
	public static void FMPNPPAGALG(PCBNCCNNPBE GJEDPGEKLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3260", Offset = "0x2BC1A60", VA = "0x182BC3260")]
	public static string LLNECEJJGKN<T>(T HKJMLEKHILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2BC32E0", Offset = "0x2BC1AE0", VA = "0x182BC32E0")]
	public static string LLNECEJJGKN<T>(T HKJMLEKHILN, PCBNCCNNPBE GJEDPGEKLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2398F70", Offset = "0x2397770", VA = "0x182398F70")]
	public static T DMAKMKNNBAJ<T>(string BAPBPICAGJC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2398CD0", Offset = "0x23974D0", VA = "0x182398CD0")]
	public static T DMAKMKNNBAJ<T>(string BAPBPICAGJC, PCBNCCNNPBE GJEDPGEKLIK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2398EF0", Offset = "0x23976F0", VA = "0x182398EF0")]
	public static T DMAKMKNNBAJ<T>(byte[] IFAOIOLKGMC, PCBNCCNNPBE GJEDPGEKLIK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2398DA0", Offset = "0x23975A0", VA = "0x182398DA0")]
	public static T DMAKMKNNBAJ<T>(byte[] IFAOIOLKGMC, int FHLPLLKMCOH, PCBNCCNNPBE GJEDPGEKLIK)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum HLHPAPKBDDM : byte
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
public struct KKHNLIPNMHK
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly byte[] GCIKMKOMJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private byte[] AFIAMHMLMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int FHLPLLKMCOH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int COBLFLFOALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6EE570", Offset = "0x6ECD70", VA = "0x1806EE570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EED0", Offset = "0x2B7D6D0", VA = "0x182B7EED0")]
	public void OKFFBNCIJFB(int FHLPLLKMCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E2E0", Offset = "0x2B7CAE0", VA = "0x182B7E2E0")]
	public static byte[] IBPFHOLDHJJ(string DNIDPEBFMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E000", Offset = "0x2B7C800", VA = "0x182B7E000")]
	public static byte[] FGMHPBBIIAF(string DNIDPEBFMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DD30", Offset = "0x2B7C530", VA = "0x182B7DD30")]
	public static byte[] DCICEFIBLNP(string DNIDPEBFMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E6B0", Offset = "0x2B7CEB0", VA = "0x182B7E6B0")]
	public static byte[] LFDPADMLMPG(string DNIDPEBFMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EFF0", Offset = "0x2B7D7F0", VA = "0x182B7EFF0")]
	public KKHNLIPNMHK(byte[] DEEFKFGJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DBD0", Offset = "0x2B7C3D0", VA = "0x182B7DBD0")]
	public ArraySegment<byte> BMMCNOMJGIG()
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DCB0", Offset = "0x2B7C4B0", VA = "0x182B7DCB0")]
	public byte[] DBEELBOKJCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EF40", Offset = "0x2B7D740", VA = "0x182B7EF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EE80", Offset = "0x2B7D680", VA = "0x182B7EE80")]
	public void OFBJOOCPCKO(int NPIJMJGAPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DF50", Offset = "0x2B7C750", VA = "0x182B7DF50")]
	public void ECMGFMMAMPH(byte[] AADJGPLLOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EE90", Offset = "0x2B7D690", VA = "0x182B7EE90")]
	public void OHMCNCOIMPE(byte AADJGPLLOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DE60", Offset = "0x2B7C660", VA = "0x182B7DE60")]
	public void DDEODOEHLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EA60", Offset = "0x2B7D260", VA = "0x182B7EA60")]
	public void NOOCKGDNADH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DFB0", Offset = "0x2B7C7B0", VA = "0x182B7DFB0")]
	public void FFHEJOKGAGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DB80", Offset = "0x2B7C380", VA = "0x182B7DB80")]
	public void ACFGEJKONGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DEB0", Offset = "0x2B7C6B0", VA = "0x182B7DEB0")]
	public void DEHAJCGGDFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DF00", Offset = "0x2B7C700", VA = "0x182B7DF00")]
	public void DGLIDJADAFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EEE0", Offset = "0x2B7D6E0", VA = "0x182B7EEE0")]
	public void PEEPMMBOPGG(string DNIDPEBFMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E190", Offset = "0x2B7C990", VA = "0x182B7E190")]
	public void GKHADCJMNID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E210", Offset = "0x2B7CA10", VA = "0x182B7E210")]
	public void HALKIIOEIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E810", Offset = "0x2B7D010", VA = "0x182B7E810")]
	public void MBBAGHBMBMO(bool HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E530", Offset = "0x2B7CD30", VA = "0x182B7E530")]
	public void JNLHIKIFMLM(float HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E3F0", Offset = "0x2B7CBF0", VA = "0x182B7E3F0")]
	public void IGFLCKHGDPM(double HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DC80", Offset = "0x2B7C480", VA = "0x182B7DC80")]
	public void CAPOJGBLOAP(byte HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EA30", Offset = "0x2B7D230", VA = "0x182B7EA30")]
	public void NCNHIOFLBPM(ushort HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E3C0", Offset = "0x2B7CBC0", VA = "0x182B7E3C0")]
	public void IDJCGBGJNIC(uint HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E1E0", Offset = "0x2B7C9E0", VA = "0x182B7E1E0")]
	public void GLGONCCPCON(ulong HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EA00", Offset = "0x2B7D200", VA = "0x182B7EA00")]
	public void MOIDJEPICMD(sbyte HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E160", Offset = "0x2B7C960", VA = "0x182B7E160")]
	public void GDNGGNIFENL(short HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E680", Offset = "0x2B7CE80", VA = "0x182B7E680")]
	public void JOJPNILHCCG(int HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E130", Offset = "0x2B7C930", VA = "0x182B7E130")]
	public void GAIFDNAJGKG(long HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2B7EAB0", Offset = "0x2B7D2B0", VA = "0x182B7EAB0")]
	public void ODJAGAHEMIF(string HKJMLEKHILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ONJLIDBNFIE : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private static class JKFCJGCAJGG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x27F1890", Offset = "0x27F0090", VA = "0x1827F1890")]
		static JKFCJGCAJGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private ONJLIDBNFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class ACHHMLBCMKI
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly Dictionary<Type, int> JMALJOAJIAM;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3795A00", Offset = "0x3794200", VA = "0x183795A00")]
	static ACHHMLBCMKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x37954A0", Offset = "0x3793CA0", VA = "0x1837954A0")]
	internal static object JEEANJHLNBK(Type AELOFOBLNEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FGAGCCEMGEH : global::KAKKFHPFHDD<Vector2>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KMCEDPABCDB PIOGPHPJPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly byte[][] OIKHBKFDECG;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x37A2CF0", Offset = "0x37A14F0", VA = "0x1837A2CF0")]
	public FGAGCCEMGEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x37A2C40", Offset = "0x37A1440", VA = "0x1837A2C40", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, Vector2 HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x37A29A0", Offset = "0x37A11A0", VA = "0x1837A29A0", Slot = "5")]
	public Vector2 DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class IDPIHIECPBK : global::KAKKFHPFHDD<Vector3>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly KMCEDPABCDB PIOGPHPJPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly byte[][] OIKHBKFDECG;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2B78D80", Offset = "0x2B77580", VA = "0x182B78D80")]
	public IDPIHIECPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2B78B70", Offset = "0x2B77370", VA = "0x182B78B70", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, Vector3 HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2B78930", Offset = "0x2B77130", VA = "0x182B78930", Slot = "5")]
	public Vector3 DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class AFCMDCAPKII : global::KAKKFHPFHDD<Vector4>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly KMCEDPABCDB PIOGPHPJPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly byte[][] OIKHBKFDECG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3796250", Offset = "0x3794A50", VA = "0x183796250")]
	public AFCMDCAPKII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3796100", Offset = "0x3794900", VA = "0x183796100", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, Vector4 HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3795DC0", Offset = "0x37945C0", VA = "0x183795DC0", Slot = "5")]
	public Vector4 DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class EBPLGGEDDCI : global::KAKKFHPFHDD<Quaternion>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly KMCEDPABCDB PIOGPHPJPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly byte[][] OIKHBKFDECG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x37A0E90", Offset = "0x379F690", VA = "0x1837A0E90")]
	public EBPLGGEDDCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3796100", Offset = "0x3794900", VA = "0x183796100", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, Quaternion HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x37A0B50", Offset = "0x379F350", VA = "0x1837A0B50", Slot = "5")]
	public Quaternion DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class FBBBGNDJFCM : global::KAKKFHPFHDD<Color>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly KMCEDPABCDB PIOGPHPJPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly byte[][] OIKHBKFDECG;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x37A2230", Offset = "0x37A0A30", VA = "0x1837A2230")]
	public FBBBGNDJFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3796100", Offset = "0x3794900", VA = "0x183796100", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, Color HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x37A1EF0", Offset = "0x37A06F0", VA = "0x1837A1EF0", Slot = "5")]
	public Color DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class BNCFEKEAMBH : global::KAKKFHPFHDD<Bounds>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly KMCEDPABCDB PIOGPHPJPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly byte[][] OIKHBKFDECG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x379A1B0", Offset = "0x37989B0", VA = "0x18379A1B0")]
	public BNCFEKEAMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3799F40", Offset = "0x3798740", VA = "0x183799F40", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, Bounds HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3799B90", Offset = "0x3798390", VA = "0x183799B90", Slot = "5")]
	public Bounds DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(Bounds);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class JEHNDJMEDBH : global::KAKKFHPFHDD<Rect>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly KMCEDPABCDB PIOGPHPJPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly byte[][] OIKHBKFDECG;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2B7C460", Offset = "0x2B7AC60", VA = "0x182B7C460")]
	public JEHNDJMEDBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2B7C1D0", Offset = "0x2B7A9D0", VA = "0x182B7C1D0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, Rect HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BF20", Offset = "0x2B7A720", VA = "0x182B7BF20", Slot = "5")]
	public Rect DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class BJBJBMKNKMO : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private static class BOJKJKIKOBF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x42DAEE0", Offset = "0x42D96E0", VA = "0x1842DAEE0")]
		static BOJKJKIKOBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private BJBJBMKNKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class PLNFMBBBALB : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private static class FONJEDMDHEF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E2BC40", Offset = "0x3E2A440", VA = "0x183E2BC40")]
		static FONJEDMDHEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class DPHCGBBCDMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly Dictionary<Type, object> JOFDKGGGKMF;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4F4C9F0", Offset = "0x4F4B1F0", VA = "0x184F4C9F0")]
		internal static object JEEANJHLNBK(Type AELOFOBLNEI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private PLNFMBBBALB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class OFBDAANILKI : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private static class MLEGGDOGBDP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x27F82D0", Offset = "0x27F6AD0", VA = "0x1827F82D0")]
		static MLEGGDOGBDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly OFBDAANILKI JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static bool FFJJFEAPOKN;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static MAIGLFCCAEJ[] NBHCEPEPHDA;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static PCBNCCNNPBE[] HLDLCDKFDKN;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private OFBDAANILKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4F51790", Offset = "0x4F4FF90", VA = "0x184F51790")]
	public static void FONLBDNLOBN(params PCBNCCNNPBE[] HLDLCDKFDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4F51850", Offset = "0x4F50050", VA = "0x184F51850")]
	public static void FONLBDNLOBN(params MAIGLFCCAEJ[] NBHCEPEPHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4F51540", Offset = "0x4F4FD40", VA = "0x184F51540")]
	public static void COCMNNOJCLH(MAIGLFCCAEJ[] NBHCEPEPHDA, PCBNCCNNPBE[] HLDLCDKFDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class IDFMOAAPKCF : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private static class GNGKFMPPGAJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2A36B20", Offset = "0x2A35320", VA = "0x182A36B20")]
		static GNGKFMPPGAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private IDFMOAAPKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OKDGHMLHBED
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly PCBNCCNNPBE GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly PCBNCCNNPBE JLIOGMPEONH;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly PCBNCCNNPBE APJPNDLNBGL;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly PCBNCCNNPBE LLFJCMCGJEB;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly PCBNCCNNPBE LHJFGIDOEBK;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly PCBNCCNNPBE ONJGAGHHDPF;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly PCBNCCNNPBE BHKHJBJPKKB;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly PCBNCCNNPBE POGHGOHLLCJ;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly PCBNCCNNPBE CBMLNGBPMOD;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly PCBNCCNNPBE IFBHJPNMBIL;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly PCBNCCNNPBE OKLPKFAKHMJ;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly PCBNCCNNPBE IJJEBCFJGNJ;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class NDOIFOGNCCL
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly PCBNCCNNPBE GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly PCBNCCNNPBE OOMPKDOLMIN;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class AGEIGDOMHFG
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly PCBNCCNNPBE GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly PCBNCCNNPBE JLIOGMPEONH;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly PCBNCCNNPBE APJPNDLNBGL;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly PCBNCCNNPBE LLFJCMCGJEB;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly PCBNCCNNPBE LHJFGIDOEBK;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly PCBNCCNNPBE ONJGAGHHDPF;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly PCBNCCNNPBE BHKHJBJPKKB;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly PCBNCCNNPBE POGHGOHLLCJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly PCBNCCNNPBE CBMLNGBPMOD;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly PCBNCCNNPBE IFBHJPNMBIL;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly PCBNCCNNPBE OKLPKFAKHMJ;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly PCBNCCNNPBE IJJEBCFJGNJ;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class AMEHKBOEFLD
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly Dictionary<Type, Type> JOFDKGGGKMF;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3796C60", Offset = "0x3795460", VA = "0x183796C60")]
	internal static object JEEANJHLNBK(Type AELOFOBLNEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3798280", Offset = "0x3796A80", VA = "0x183798280")]
	private static object KMHBLPCEJJO(Type FHFIABMMIJK, Type[] ADGHPAOIAFO, params object[] DLIAMCEIIDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class BFKFBPKDEHK : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private static class FLALLBNEEJJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xF50760", Offset = "0xF4EF60", VA = "0x180F50760")]
		static FLALLBNEEJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly Func<string, string> KHNAOCBFPLL;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly bool OKFEKIDIEIH;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly AGEHFBIGEHC KOJEIGMHKFG;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3798E90", Offset = "0x3797690", VA = "0x183798E90")]
	static BFKFBPKDEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private BFKFBPKDEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class BLLFBLIDPMF : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private static class ACKMCLOKPAB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x23C67B0", Offset = "0x23C4FB0", VA = "0x1823C67B0")]
		static ACKMCLOKPAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Func<string, string> KHNAOCBFPLL;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly bool OKFEKIDIEIH;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly AGEHFBIGEHC KOJEIGMHKFG;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3799770", Offset = "0x3797F70", VA = "0x183799770")]
	static BLLFBLIDPMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private BLLFBLIDPMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class CMNELCNJMPF : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class IHGFMJKGHGA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x32DCCC0", Offset = "0x32DB4C0", VA = "0x1832DCCC0")]
		static IHGFMJKGHGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly Func<string, string> KHNAOCBFPLL;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly bool OKFEKIDIEIH;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly AGEHFBIGEHC KOJEIGMHKFG;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x379D600", Offset = "0x379BE00", VA = "0x18379D600")]
	static CMNELCNJMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private CMNELCNJMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class JLOIGEEAFGO : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private static class IFGOBNOMCFI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2CEDA60", Offset = "0x2CEC260", VA = "0x182CEDA60")]
		static IFGOBNOMCFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly Func<string, string> KHNAOCBFPLL;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly bool OKFEKIDIEIH;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly AGEHFBIGEHC KOJEIGMHKFG;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2B7CDE0", Offset = "0x2B7B5E0", VA = "0x182B7CDE0")]
	static JLOIGEEAFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private JLOIGEEAFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class JDLEOCPIDFI : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class CFFMEFGJNLH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x428E640", Offset = "0x428CE40", VA = "0x18428E640")]
		static CFFMEFGJNLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly Func<string, string> KHNAOCBFPLL;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly bool OKFEKIDIEIH;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly AGEHFBIGEHC KOJEIGMHKFG;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BE30", Offset = "0x2B7A630", VA = "0x182B7BE30")]
	static JDLEOCPIDFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private JDLEOCPIDFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class PJBAHBGHMLP : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private static class PIAKFEOGADM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2CAE3B0", Offset = "0x2CACBB0", VA = "0x182CAE3B0")]
		static PIAKFEOGADM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly Func<string, string> KHNAOCBFPLL;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly bool OKFEKIDIEIH;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly AGEHFBIGEHC KOJEIGMHKFG;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4F54C00", Offset = "0x4F53400", VA = "0x184F54C00")]
	static PJBAHBGHMLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private PJBAHBGHMLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class EIMAOIGJBCD : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private static class FLCCFMMMAPK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3828DD0", Offset = "0x38275D0", VA = "0x183828DD0")]
		static FLCCFMMMAPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly Func<string, string> KHNAOCBFPLL;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly bool OKFEKIDIEIH;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public EIMAOIGJBCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class KMNGNDKMPOA : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private static class PLGNIIGPPAB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x386F640", Offset = "0x386DE40", VA = "0x18386F640")]
		static PLGNIIGPPAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly Func<string, string> KHNAOCBFPLL;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly bool OKFEKIDIEIH;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public KMNGNDKMPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class JDBMODPGCJK : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private static class BCAGHNGNNNL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x428A940", Offset = "0x4289140", VA = "0x18428A940")]
		static BCAGHNGNNNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Func<string, string> KHNAOCBFPLL;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly bool OKFEKIDIEIH;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public JDBMODPGCJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal sealed class GAFGOAAPLNF : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private static class MANDPEBLPLG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3C6DC80", Offset = "0x3C6C480", VA = "0x183C6DC80")]
		static MANDPEBLPLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly Func<string, string> KHNAOCBFPLL;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly bool OKFEKIDIEIH;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public GAFGOAAPLNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class LGNANMNFKNO : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private static class HALOAJIPMFE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x414B730", Offset = "0x4149F30", VA = "0x18414B730")]
		static HALOAJIPMFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static readonly Func<string, string> KHNAOCBFPLL;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static readonly bool OKFEKIDIEIH;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public LGNANMNFKNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class HLDKEHAAEGF : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private static class KEKEIJNFPLH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x42FF4D0", Offset = "0x42FDCD0", VA = "0x1842FF4D0")]
		static KEKEIJNFPLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly Func<string, string> KHNAOCBFPLL;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly bool OKFEKIDIEIH;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public HLDKEHAAEGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class NNMJNLPGJNA
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct LBMCDGIABMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public EOAIIGIMKIK BOINLJMDFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LocalBuilder CFGAJJDBJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LocalBuilder HLEKCDLHFPC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class HKLCIAFHHIL
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		internal static class OHAGPBACKPN
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly MethodInfo DCICEFIBLNP;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly MethodInfo FGMHPBBIIAF;

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly MethodInfo LFDPADMLMPG;

			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public static readonly MethodInfo IBPFHOLDHJJ;

			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MethodInfo HALKIIOEIPA;

			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly MethodInfo ECMGFMMAMPH;

			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly MethodInfo FFHEJOKGAGO;

			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public static readonly MethodInfo ACFGEJKONGK;

			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public static readonly MethodInfo DEHAJCGGDFH;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4F519D0", Offset = "0x4F501D0", VA = "0x184F519D0")]
			static OHAGPBACKPN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		internal static class NBONFCLBIPL
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MethodInfo NAMNKBLNLAD;

			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly MethodInfo PNJKMGODPEB;

			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public static readonly MethodInfo BMENPHJFMFP;

			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public static readonly MethodInfo MKPOJCCAEBO;

			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public static readonly MethodInfo NJCNBBMGCPD;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MethodInfo PGMJMJIHPJE;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly MethodInfo BPNFCHOOLME;

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x4F50610", Offset = "0x4F4EE10", VA = "0x184F50610")]
			static NBONFCLBIPL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		internal static class AADBCMNEOCN
		{
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			internal static readonly MethodInfo BDFLLECDNGN;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			internal static readonly MethodInfo CJKDDELFDAG;
		}

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public static readonly ConstructorInfo CHNEENLKCKB;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly MethodInfo GPJGPKHMNPE;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly ConstructorInfo POLHGEAINBM;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly MethodInfo BEDMPFECAON;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public static readonly MethodInfo HJKKMFEBAAM;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly MethodInfo PMLKOEHFKGA;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public static readonly MethodInfo KCPDLHDKMDO;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly MethodInfo JEHBFFBLGIO;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo MOIIGHCCHHO;

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public static readonly MethodInfo ALMBJFJOABI;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static readonly MethodInfo ADAGAFNIJEC;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static readonly MethodInfo BLDDMMPCEGN;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4F4EB20", Offset = "0x4F4D320", VA = "0x184F4EB20")]
		public static MethodInfo IICNIKFAIFP(Type LIBGCFIILKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4F4E7D0", Offset = "0x4F4CFD0", VA = "0x184F4E7D0")]
		public static MethodInfo DMAKMKNNBAJ(Type LIBGCFIILKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4F4EA00", Offset = "0x4F4D200", VA = "0x184F4EA00")]
		public static MethodInfo FLBOMBHMDMK(Type LIBGCFIILKM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class HEILPLPOPPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public FieldBuilder stringByteKeysField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Dictionary<EOAIIGIMKIK, FieldInfo> customFormatterLookup;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public HEILPLPOPPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KLOIFEKJDDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public HEILPLPOPPD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public KLOIFEKJDDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4F503B0", Offset = "0x4F4EBB0", VA = "0x184F503B0")]
		internal void <BuildType>b__1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4F503F0", Offset = "0x4F4EBF0", VA = "0x184F503F0")]
		internal bool <BuildType>b__2(int index, EOAIIGIMKIK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class OHJCMMOPKHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public HEILPLPOPPD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public OHJCMMOPKHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4F52710", Offset = "0x4F50F10", VA = "0x184F52710")]
		internal bool <BuildType>b__3(int index, EOAIIGIMKIK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class CJKAEBKBLHD
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

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public CJKAEBKBLHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4F4C990", Offset = "0x4F4B190", VA = "0x184F4C990")]
		internal string <BuildAnonymousFormatter>b__1(string x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class OPOFCMPJFCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public HashSet<string> ignoreSet;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public OPOFCMPJFCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4F54180", Offset = "0x4F52980", VA = "0x184F54180")]
		internal bool <BuildAnonymousFormatter>b__2(EOAIIGIMKIK x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class IGCNBKFMBCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public CJKAEBKBLHD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public IGCNBKFMBCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x4F50200", Offset = "0x4F4EA00", VA = "0x184F50200")]
		internal void <BuildAnonymousFormatter>b__5()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4F50210", Offset = "0x4F4EA10", VA = "0x184F50210")]
		internal bool <BuildAnonymousFormatter>b__6(int index, EOAIIGIMKIK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GFMCJEMJHBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public CJKAEBKBLHD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public GFMCJEMJHBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4F4E630", Offset = "0x4F4CE30", VA = "0x184F4E630")]
		internal bool <BuildAnonymousFormatter>b__7(int index, EOAIIGIMKIK member)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class BHMGFACECGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ILGenerator il;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public BHMGFACECGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x59E450", Offset = "0x59CC50", VA = "0x18059E450")]
		internal Label <BuildSerialize>b__1(EOAIIGIMKIK _)
		{
			return default(Label);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class FPNACJOAPNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public ILGenerator il;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool isSideEffectFreeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public LBMCDGIABMF[] infoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Func<int, EOAIIGIMKIK, bool> tryEmitLoadCustomFormatter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public PGNGMEFBAIP argReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public PGNGMEFBAIP argResolver;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public FPNACJOAPNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4F4E1B0", Offset = "0x4F4C9B0", VA = "0x184F4E1B0")]
		internal LBMCDGIABMF <BuildDeserialize>b__0(EOAIIGIMKIK item)
		{
			return default(LBMCDGIABMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class GBLLAHODDMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Label continueWhile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Label readNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public FPNACJOAPNG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public GBLLAHODDMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4F4E2E0", Offset = "0x4F4CAE0", VA = "0x184F4E2E0")]
		internal void <BuildDeserialize>b__2(KeyValuePair<string, int> x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4F4E590", Offset = "0x4F4CD90", VA = "0x184F4E590")]
		internal void <BuildDeserialize>b__3()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class FHAPANPBBOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public EOAIIGIMKIK item;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public FHAPANPBBOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1D695C0", Offset = "0x1D67DC0", VA = "0x181D695C0")]
		internal bool <EmitNewObject>b__0(LBMCDGIABMF x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class NHLBJJIAMIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public EOAIIGIMKIK item;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public NHLBJJIAMIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1D695C0", Offset = "0x1D67DC0", VA = "0x181D695C0")]
		internal bool <EmitNewObject>b__2(LBMCDGIABMF x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static readonly Regex GLBNOLFPEFM;

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static int KNKOFKPEOOM;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static HashSet<Type> FKNFJABNLGB;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static HashSet<Type> FNCLABLGMFN;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2BA9540", Offset = "0x2BA7D40", VA = "0x182BA9540")]
	public static object IJMNKDJFGJA<T>(AGEHFBIGEHC KOJEIGMHKFG, PCBNCCNNPBE EDCFDLDEBAE, Func<string, string> KHNAOCBFPLL, bool OKFEKIDIEIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2BD52F0", Offset = "0x2BD3AF0", VA = "0x182BD52F0")]
	public static object OJJKFFHDDLA<T>(PCBNCCNNPBE EDCFDLDEBAE, Func<string, string> KHNAOCBFPLL, bool OKFEKIDIEIH, bool GOILGNKHGBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2B91A70", Offset = "0x2B90270", VA = "0x182B91A70")]
	private static TypeInfo MHNENINKLLH(AGEHFBIGEHC KOJEIGMHKFG, Type LIBGCFIILKM, Func<string, string> KHNAOCBFPLL, bool OKFEKIDIEIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2B8E300", Offset = "0x2B8CB00", VA = "0x182B8E300")]
	public static object DCJFCOJFCFP(Type LIBGCFIILKM, Func<string, string> KHNAOCBFPLL, bool OKFEKIDIEIH, bool GOILGNKHGBL, bool PLAOEEMKCLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2B900C0", Offset = "0x2B8E8C0", VA = "0x182B900C0")]
	private static Dictionary<EOAIIGIMKIK, FieldInfo> JDPFEJDJMBB(TypeBuilder MLEDMBAJPOO, NIPFGLOKGCJ JFGBMPDGMJF, ConstructorInfo IBHLPLDNCBD, FieldBuilder IBJMPFDLPIN, ILGenerator OMJNMOMELNA, bool OKFEKIDIEIH, bool FOOMLBFHINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2B914A0", Offset = "0x2B8FCA0", VA = "0x182B914A0")]
	private static Dictionary<EOAIIGIMKIK, FieldInfo> LNLHJIHPFGH(TypeBuilder MLEDMBAJPOO, NIPFGLOKGCJ JFGBMPDGMJF, ILGenerator OMJNMOMELNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2B8CD50", Offset = "0x2B8B550", VA = "0x182B8CD50")]
	private static void CPKOEEDBNBG(Type LIBGCFIILKM, NIPFGLOKGCJ JFGBMPDGMJF, ILGenerator OMJNMOMELNA, Action GBLIEMBKMIP, Func<int, EOAIIGIMKIK, bool> AMNDONPOLKI, bool OKFEKIDIEIH, bool FOOMLBFHINO, int FBFOBCAEIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2B92BE0", Offset = "0x2B913E0", VA = "0x182B92BE0")]
	private static void MNKJPJEBEBJ(TypeInfo LIBGCFIILKM, EOAIIGIMKIK AJKFJAIOLKC, ILGenerator OMJNMOMELNA, int EDBBKGCLEJF, Func<int, EOAIIGIMKIK, bool> AMNDONPOLKI, PGNGMEFBAIP PJJBCJIGKFL, PGNGMEFBAIP MBKGDIMKDKM, PGNGMEFBAIP OFCECAPPPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2B93190", Offset = "0x2B91990", VA = "0x182B93190")]
	private static void NNNCJPNACFC(Type LIBGCFIILKM, NIPFGLOKGCJ JFGBMPDGMJF, ILGenerator OMJNMOMELNA, Func<int, EOAIIGIMKIK, bool> AMNDONPOLKI, bool OEEOMJILDJJ, int FBFOBCAEIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2B8FCA0", Offset = "0x2B8E4A0", VA = "0x182B8FCA0")]
	private static void FNALKFDBJIP(ILGenerator OMJNMOMELNA, LBMCDGIABMF JFGBMPDGMJF, int EDBBKGCLEJF, Func<int, EOAIIGIMKIK, bool> AMNDONPOLKI, PGNGMEFBAIP FNJMAPENAJC, PGNGMEFBAIP OFCECAPPPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2B907C0", Offset = "0x2B8EFC0", VA = "0x182B907C0")]
	private static LocalBuilder KJBEHOHDHMG(ILGenerator OMJNMOMELNA, Type LIBGCFIILKM, NIPFGLOKGCJ JFGBMPDGMJF, LBMCDGIABMF[] FNAAGABOIPN, bool NIKIOGEHNNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2B92510", Offset = "0x2B90D10", VA = "0x182B92510")]
	private static bool MLPNMHINMBJ(ConstructorInfo FFAIOJADKOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2B94570", Offset = "0x2B92D70", VA = "0x182B94570")]
	private static bool PPHHGHHPFJD(Type LIBGCFIILKM, out Type HOAEFIOIJAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal delegate void OFANNAJAPND<T>(byte[][] IBJMPFDLPIN, object[] DKMHJDGNBKN, ref KKHNLIPNMHK PJJBCJIGKFL, T HKJMLEKHILN, PCBNCCNNPBE GJEDPGEKLIK);
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal delegate T EJBDJNLBJIC<T>(object[] DKMHJDGNBKN, ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE GJEDPGEKLIK);
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class NEPHKENIJJO<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class HJFPPPBNBGB : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private static class DCMNBFFGHPB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x42EE490", Offset = "0x42ECC90", VA = "0x1842EE490")]
		static DCMNBFFGHPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private HJFPPPBNBGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class GBADCGKLGFC : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private static class JFLHNDGCPCN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A680", Offset = "0x3C68E80", VA = "0x183C6A680")]
		static JFLHNDGCPCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private GBADCGKLGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal static class KDKMFJNNMNA
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	internal static readonly PCBNCCNNPBE[] OBMEMIDMPBH;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class HCGHEDOPMCF : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private static class OBFKBFGDJPD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x43FD1F0", Offset = "0x43FB9F0", VA = "0x1843FD1F0")]
		static OBFKBFGDJPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class BANEHGBNBDG : PCBNCCNNPBE
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		private static class PJEMJGHEAEH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x427A180", Offset = "0x4278980", VA = "0x18427A180")]
			static PJEMJGHEAEH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public static readonly PCBNCCNNPBE JNLINCDFKKC;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly PCBNCCNNPBE[] HLDLCDKFDKN;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		private BANEHGBNBDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
		public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly global::KAKKFHPFHDD<object> CJMCPNHEKAE;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private HCGHEDOPMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class EJEBGBGONDD : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private static class KEIPNDPMIKP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x38319A0", Offset = "0x38301A0", VA = "0x1838319A0")]
		static KEIPNDPMIKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private sealed class AFHPEPIOFGE : PCBNCCNNPBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		private static class GECEIPDMMIM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x382ABC0", Offset = "0x38293C0", VA = "0x18382ABC0")]
			static GECEIPDMMIM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public static readonly PCBNCCNNPBE JNLINCDFKKC;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly PCBNCCNNPBE[] HLDLCDKFDKN;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		private AFHPEPIOFGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
		public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::KAKKFHPFHDD<object> CJMCPNHEKAE;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private EJEBGBGONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class HMDDLOPIJBF : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private static class NKJBFOMGAPD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3D9F560", Offset = "0x3D9DD60", VA = "0x183D9F560")]
		static NKJBFOMGAPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private sealed class HPOHCHBHKLF : PCBNCCNNPBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		private static class EPGCOOCHMLH<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x42F0050", Offset = "0x42EE850", VA = "0x1842F0050")]
			static EPGCOOCHMLH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly PCBNCCNNPBE JNLINCDFKKC;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly PCBNCCNNPBE[] HLDLCDKFDKN;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		private HPOHCHBHKLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
		public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly global::KAKKFHPFHDD<object> CJMCPNHEKAE;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private HMDDLOPIJBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class MNGMPLDCIHE : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private static class FOFPEHDDGPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2633F70", Offset = "0x2632770", VA = "0x182633F70")]
		static FOFPEHDDGPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class MMBCLBLJAMA : PCBNCCNNPBE
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private static class AONGJKCIKCO<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x262DBD0", Offset = "0x262C3D0", VA = "0x18262DBD0")]
			static AONGJKCIKCO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly PCBNCCNNPBE JNLINCDFKKC;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly PCBNCCNNPBE[] HLDLCDKFDKN;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		private MMBCLBLJAMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
		public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly global::KAKKFHPFHDD<object> CJMCPNHEKAE;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private MNGMPLDCIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class IDLDADAHIGJ : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private static class ACMPCIPNAJJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2A31E90", Offset = "0x2A30690", VA = "0x182A31E90")]
		static ACMPCIPNAJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class MLFKABBFEKM : PCBNCCNNPBE
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private static class MBECLPCLGED<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2A43A20", Offset = "0x2A42220", VA = "0x182A43A20")]
			static MBECLPCLGED()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly PCBNCCNNPBE JNLINCDFKKC;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly PCBNCCNNPBE[] HLDLCDKFDKN;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		private MLFKABBFEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
		public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly global::KAKKFHPFHDD<object> CJMCPNHEKAE;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private IDLDADAHIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal sealed class EMAEBOIBEIJ : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private static class JLFFLBCOOGB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x350D150", Offset = "0x350B950", VA = "0x18350D150")]
		static JLFFLBCOOGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private sealed class FDJBMEHDOFP : PCBNCCNNPBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		private static class GLHJHENMGGJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x350B520", Offset = "0x3509D20", VA = "0x18350B520")]
			static GLHJHENMGGJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly PCBNCCNNPBE JNLINCDFKKC;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly PCBNCCNNPBE[] HLDLCDKFDKN;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		private FDJBMEHDOFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
		public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly global::KAKKFHPFHDD<object> CJMCPNHEKAE;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private EMAEBOIBEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal sealed class IPKACMMEEIL : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private static class NDFMIDICCDP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4299020", Offset = "0x4297820", VA = "0x184299020")]
		static NDFMIDICCDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private sealed class JMCBABCMDMH : PCBNCCNNPBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private static class BHGIHDGLNNF<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x428DB00", Offset = "0x428C300", VA = "0x18428DB00")]
			static BHGIHDGLNNF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly PCBNCCNNPBE JNLINCDFKKC;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly PCBNCCNNPBE[] HLDLCDKFDKN;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		private JMCBABCMDMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
		public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly global::KAKKFHPFHDD<object> CJMCPNHEKAE;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private IPKACMMEEIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal sealed class DFINNNPHKGO : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	private static class EFBIJKCHJBP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1B80", Offset = "0x3FF0380", VA = "0x183FF1B80")]
		static EFBIJKCHJBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private sealed class LHJLMPILOCM : PCBNCCNNPBE
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private static class LPBLKNPENNK<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6830", Offset = "0x3FF5030", VA = "0x183FF6830")]
			static LPBLKNPENNK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly PCBNCCNNPBE JNLINCDFKKC;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly PCBNCCNNPBE[] HLDLCDKFDKN;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		private LHJLMPILOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
		public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly global::KAKKFHPFHDD<object> CJMCPNHEKAE;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private DFINNNPHKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal sealed class GDOOPKDBGGB : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private static class GEJAKCKAKKN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3C5D1C0", Offset = "0x3C5B9C0", VA = "0x183C5D1C0")]
		static GEJAKCKAKKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private sealed class FMFDPMGAFCA : PCBNCCNNPBE
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		private static class GFALBCPNKDM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3C60010", Offset = "0x3C5E810", VA = "0x183C60010")]
			static GFALBCPNKDM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly PCBNCCNNPBE JNLINCDFKKC;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly PCBNCCNNPBE[] HLDLCDKFDKN;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		private FMFDPMGAFCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
		public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly global::KAKKFHPFHDD<object> CJMCPNHEKAE;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private GDOOPKDBGGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal sealed class LNDKAMFPDKA : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private static class FNHDIDCPCFG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x41497E0", Offset = "0x4147FE0", VA = "0x1841497E0")]
		static FNHDIDCPCFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private sealed class DHDDOCMNHEO : PCBNCCNNPBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private static class BHMGGJGGOGA<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x4148040", Offset = "0x4146840", VA = "0x184148040")]
			static BHMGGJGGOGA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly PCBNCCNNPBE JNLINCDFKKC;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly PCBNCCNNPBE[] HLDLCDKFDKN;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		private DHDDOCMNHEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
		public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly global::KAKKFHPFHDD<object> CJMCPNHEKAE;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private LNDKAMFPDKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal sealed class GIFAODMJENG : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private static class GNPJPPFHLIH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F37730", Offset = "0x3F35F30", VA = "0x183F37730")]
		static GNPJPPFHLIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private sealed class LKAHEPBPEGE : PCBNCCNNPBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		private static class EKAPNDLEDBJ<T>
		{
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3F29480", Offset = "0x3F27C80", VA = "0x183F29480")]
			static EKAPNDLEDBJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly PCBNCCNNPBE JNLINCDFKKC;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private static readonly PCBNCCNNPBE[] HLDLCDKFDKN;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		private LKAHEPBPEGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
		public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly global::KAKKFHPFHDD<object> CJMCPNHEKAE;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private GIFAODMJENG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal sealed class PDMIJIJBGJA : PCBNCCNNPBE
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private static class IJLHEOJPGON<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1FA0", Offset = "0x2CA07A0", VA = "0x182CA1FA0")]
		static IJLHEOJPGON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private sealed class MHKEAMMMDLP : PCBNCCNNPBE
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		private static class MDMKIBAOFMM<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly global::KAKKFHPFHDD<T> PHDNPGENOND;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x2CA58C0", Offset = "0x2CA40C0", VA = "0x182CA58C0")]
			static MDMKIBAOFMM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly PCBNCCNNPBE JNLINCDFKKC;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private static readonly PCBNCCNNPBE[] HLDLCDKFDKN;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		private MHKEAMMMDLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
		public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public static readonly PCBNCCNNPBE JNLINCDFKKC;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly global::KAKKFHPFHDD<object> CJMCPNHEKAE;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	private PDMIJIJBGJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x222BF90", Offset = "0x222A790", VA = "0x18222BF90", Slot = "4")]
	public global::KAKKFHPFHDD<T> JEEANJHLNBK<T>()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct ONEOHBJAPFA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public T[] DGCFKBLAFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public int KNCNKJJPBPG;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x2806F30", Offset = "0x2805730", VA = "0x182806F30")]
	public ONEOHBJAPFA(int OBKDNJJMMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x2806D00", Offset = "0x2805500", VA = "0x182806D00")]
	public void DEOBKNOOHMB(T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2806EA0", Offset = "0x28056A0", VA = "0x182806EA0")]
	public T[] JLNEILJALPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal sealed class NMPNKBBFBDG : global::DOOALKNCCHC<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly NMPNKBBFBDG GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2B8BD40", Offset = "0x2B8A540", VA = "0x182B8BD40")]
	public NMPNKBBFBDG(int EHFJHBBNBNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class DOOALKNCCHC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly int EHFJHBBNBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly object LEKIDLKBBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int EDBBKGCLEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private T[][] CFOILFIMFEA;

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x341B510", Offset = "0x3419D10", VA = "0x18341B510")]
	public DOOALKNCCHC(int EHFJHBBNBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x341A010", Offset = "0x3418810", VA = "0x18341A010")]
	public T[] IJMJDMBMCEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x341AB50", Offset = "0x3419350", VA = "0x18341AB50")]
	public void JDOOOPPAMPG(T[] FOLGEBPFFME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class KMCEDPABCDB : IEnumerable<KeyValuePair<string, int>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class ABOMFMLMMNG : IComparable<ABOMFMLMMNG>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class HLBGCPKCOAH : IEnumerable<ABOMFMLMMNG>, IEnumerable, IEnumerator<ABOMFMLMMNG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private ABOMFMLMMNG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public ABOMFMLMMNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private ABOMFMLMMNG System.Collections.Generic.IEnumerator<Utf8Json.Internal.AutomataDictionary.AutomataNode>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x7B2A20", Offset = "0x7B1220", VA = "0x1807B2A20")]
			[DebuggerHidden]
			public HLBGCPKCOAH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x2B78010", Offset = "0x2B76810", VA = "0x182B78010", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2B78140", Offset = "0x2B76940", VA = "0x182B78140", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2B780A0", Offset = "0x2B768A0", VA = "0x182B780A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ABOMFMLMMNG> System.Collections.Generic.IEnumerable<Utf8Json.Internal.AutomataDictionary.AutomataNode>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2B780A0", Offset = "0x2B768A0", VA = "0x182B780A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class FMHFEBCJMDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public ILGenerator il;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
			public FMHFEBCJMDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x59E450", Offset = "0x59CC50", VA = "0x18059E450")]
			internal Label <EmitSearchNextCore>b__3(int _)
			{
				return default(Label);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x59E450", Offset = "0x59CC50", VA = "0x18059E450")]
			internal Label <EmitSearchNextCore>b__2(int _)
			{
				return default(Label);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly ABOMFMLMMNG[] FJIAMGDFECA;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly ulong[] PGCIGHGGPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ulong CNJCNJLJNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public int MKOCEBDLMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string ELCFKIHJEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private ABOMFMLMMNG[] BNIHFPKJPNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private ulong[] BMEHNFFBFIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private int NLKMJJJPIDG;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool EOGKNDIPODK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xCC2F50", Offset = "0xCC1750", VA = "0x180CC2F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B77300", Offset = "0x2B75B00", VA = "0x182B77300")]
		public ABOMFMLMMNG(ulong HJCJKDOGPGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B761D0", Offset = "0x2B749D0", VA = "0x182B761D0")]
		public ABOMFMLMMNG DEOBKNOOHMB(ulong HJCJKDOGPGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B76180", Offset = "0x2B74980", VA = "0x182B76180")]
		public ABOMFMLMMNG DEOBKNOOHMB(ulong HJCJKDOGPGK, int HKJMLEKHILN, string ELCFKIHJEHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B763C0", Offset = "0x2B74BC0", VA = "0x182B763C0")]
		public ABOMFMLMMNG FOBEHLNNNCL(byte[] BNLGOIPIEIN, ref int FHLPLLKMCOH, ref int PHMAPPNHPCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B77200", Offset = "0x2B75A00", VA = "0x182B77200")]
		internal static int JIGNPIFIBFD(ulong[] FOLGEBPFFME, int EDBBKGCLEJF, int EKOLDJKMDKB, ulong HKJMLEKHILN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B76150", Offset = "0x2B74950", VA = "0x182B76150", Slot = "4")]
		public int CompareTo(ABOMFMLMMNG EFDJFLPIKFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B77190", Offset = "0x2B75990", VA = "0x182B77190")]
		[IteratorStateMachine(typeof(HLBGCPKCOAH))]
		public IEnumerable<ABOMFMLMMNG> JADCMKDMOKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2B76000", Offset = "0x2B74800", VA = "0x182B76000")]
		public void CGIPOKECBCI(ILGenerator OMJNMOMELNA, LocalBuilder BNLGOIPIEIN, LocalBuilder PHMAPPNHPCN, LocalBuilder HJCJKDOGPGK, Action<KeyValuePair<string, int>> HKODAEBLAPJ, Action CLOCOELFLNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2B76570", Offset = "0x2B74D70", VA = "0x182B76570")]
		private static void IDAHPFHNDOM(ILGenerator OMJNMOMELNA, LocalBuilder BNLGOIPIEIN, LocalBuilder PHMAPPNHPCN, LocalBuilder HJCJKDOGPGK, Action<KeyValuePair<string, int>> HKODAEBLAPJ, Action CLOCOELFLNK, ABOMFMLMMNG[] BNIHFPKJPNP, int NLKMJJJPIDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class PKHKIIOFMCI : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private KeyValuePair<string, int> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private IEnumerable<ABOMFMLMMNG> nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public IEnumerable<ABOMFMLMMNG> <>3__nexts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private IEnumerator<ABOMFMLMMNG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private ABOMFMLMMNG <item>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IEnumerator<KeyValuePair<string, int>> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KeyValuePair<string, int> IEnumerator<KeyValuePair<string, int>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x5EB790", Offset = "0x5E9F90", VA = "0x1805EB790", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2B95090", Offset = "0x2B93890", VA = "0x182B95090", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA97C20", Offset = "0xA96420", VA = "0x180A97C20")]
		[DebuggerHidden]
		public PKHKIIOFMCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2B950E0", Offset = "0x2B938E0", VA = "0x182B950E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2B94C20", Offset = "0x2B93420", VA = "0x182B94C20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2B951E0", Offset = "0x2B939E0", VA = "0x182B951E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2B95230", Offset = "0x2B93A30", VA = "0x182B95230")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B95040", Offset = "0x2B93840", VA = "0x182B95040", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B94FA0", Offset = "0x2B937A0", VA = "0x182B94FA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<KeyValuePair<string, int>> IEnumerable<KeyValuePair<string, int>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2B94FA0", Offset = "0x2B937A0", VA = "0x182B94FA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly ABOMFMLMMNG JMNKBNCDHOH;

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F6F0", Offset = "0x2B7DEF0", VA = "0x182B7F6F0")]
	public KMCEDPABCDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F0B0", Offset = "0x2B7D8B0", VA = "0x182B7F0B0")]
	public void DEOBKNOOHMB(byte[] IFAOIOLKGMC, int HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F450", Offset = "0x2B7DC50", VA = "0x182B7F450")]
	public bool FFAICDCFGIL(ArraySegment<byte> HJCJKDOGPGK, out int HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F600", Offset = "0x2B7DE00", VA = "0x182B7F600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F1D0", Offset = "0x2B7D9D0", VA = "0x182B7F1D0")]
	private static void FAAIGDMNBPL(IEnumerable<ABOMFMLMMNG> BNIHFPKJPNP, StringBuilder CAECEPHJAMF, int GFBINNEGMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F500", Offset = "0x2B7DD00", VA = "0x182B7F500", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F500", Offset = "0x2B7DD00", VA = "0x182B7F500", Slot = "4")]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F010", Offset = "0x2B7D810", VA = "0x182B7F010")]
	[IteratorStateMachine(typeof(PKHKIIOFMCI))]
	private static IEnumerable<KeyValuePair<string, int>> BPEBMHILCEM(IEnumerable<ABOMFMLMMNG> BNIHFPKJPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F080", Offset = "0x2B7D880", VA = "0x182B7F080")]
	public void CNAFCECPNEB(ILGenerator OMJNMOMELNA, LocalBuilder BNLGOIPIEIN, LocalBuilder PHMAPPNHPCN, LocalBuilder HJCJKDOGPGK, Action<KeyValuePair<string, int>> HKODAEBLAPJ, Action CLOCOELFLNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class FMBAPKGJPOF
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly MethodInfo OPEMDFLANND;

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x37A6070", Offset = "0x37A4870", VA = "0x1837A6070")]
	public static ulong ILADOLMGBFL(byte[] IFAOIOLKGMC, ref int FHLPLLKMCOH, ref int PHMAPPNHPCN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class FBCJPDOPOGK
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x37A2610", Offset = "0x37A0E10", VA = "0x1837A2610")]
	public static void OFBJOOCPCKO(ref byte[] IFAOIOLKGMC, int FHLPLLKMCOH, int NPIJMJGAPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x37A2520", Offset = "0x37A0D20", VA = "0x1837A2520")]
	public static void BKDJCCJEKCH(ref byte[] FOLGEBPFFME, int KNDIHNKCKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x37A2730", Offset = "0x37A0F30", VA = "0x1837A2730")]
	public static byte[] OFMOBFLDLAB(byte[] HLNNMHFMONM, int KNDIHNKCKJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class JHFGCPIPHJE
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2B7CAB0", Offset = "0x2B7B2B0", VA = "0x182B7CAB0")]
	public static bool ANFHIHCOHAE(byte[] AKPJKGFJNLO, int FENHCNCNCBM, int HBHMCGEIHCD, byte[] HGAFOGDINFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class ANFKIEOEKIN<T> : IEnumerable<KeyValuePair<string, T>>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private struct CNAMPHNNDEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public byte[] CNJCNJLJNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T MKOCEBDLMLE;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3708B80", Offset = "0x3707380", VA = "0x183708B80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class HLBDKMJDNNG : IEnumerator<KeyValuePair<string, T>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private KeyValuePair<string, T> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public global::ANFKIEOEKIN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private CNAMPHNNDEH[][] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private CNAMPHNNDEH[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KeyValuePair<string, T> IEnumerator<KeyValuePair<string, T>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x1125920", Offset = "0x1124120", VA = "0x181125920", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<string, T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x3710030", Offset = "0x370E830", VA = "0x183710030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xF51650", Offset = "0xF4FE50", VA = "0x180F51650")]
		[DebuggerHidden]
		public HLBDKMJDNNG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x370DB80", Offset = "0x370C380", VA = "0x18370DB80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x370F6D0", Offset = "0x370DED0", VA = "0x18370F6D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly CNAMPHNNDEH[][] FKAKHAMLHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ulong GOLHFFNGDEA;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3707A70", Offset = "0x3706270", VA = "0x183707A70")]
	public ANFKIEOEKIN(int LJMMIINDJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x37079B0", Offset = "0x37061B0", VA = "0x1837079B0")]
	public ANFKIEOEKIN(int LJMMIINDJEO, float DLGFELNPDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x3702ED0", Offset = "0x37016D0", VA = "0x183702ED0")]
	public void DEOBKNOOHMB(byte[] HJCJKDOGPGK, T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3705BB0", Offset = "0x37043B0", VA = "0x183705BB0")]
	private bool IBMEHKJPADP(byte[] HJCJKDOGPGK, T HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3703A40", Offset = "0x3702240", VA = "0x183703A40")]
	public bool DHIHCKAPBED(ArraySegment<byte> HJCJKDOGPGK, out T HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3707950", Offset = "0x3706150", VA = "0x183707950")]
	private static ulong IEOBEELNGHA(byte[] FNGOAMCGAPH, int FHLPLLKMCOH, int NLKMJJJPIDG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x327FA70", Offset = "0x327E270", VA = "0x18327FA70")]
	private static int OCNDAADCKMJ(int LLJANMLHBAE, float DLGFELNPDII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3704A00", Offset = "0x3703200", VA = "0x183704A00", Slot = "4")]
	[IteratorStateMachine(typeof(global::ANFKIEOEKIN<>.HLBDKMJDNNG))]
	public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2970B50", Offset = "0x296F350", VA = "0x182970B50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class BDEBEBELCGJ : BinaryReader
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly OpCode[] PJMJDOGIDEB;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly OpCode[] IOPPMELOGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int COCALPKNMHO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool COHHEMHPOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3798B70", Offset = "0x3797370", VA = "0x183798B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3798BC0", Offset = "0x37973C0", VA = "0x183798BC0")]
	static BDEBEBELCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3798E10", Offset = "0x3797610", VA = "0x183798E10")]
	public BDEBEBELCGJ(byte[] FPIGGABIGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3798A60", Offset = "0x3797260", VA = "0x183798A60")]
	public OpCode GKDDJMJNKPC()
	{
		return default(OpCode);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct HFDACDGAFLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public readonly Guid MKOCEBDLMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public readonly byte PJDCICBCCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public readonly byte AKDIDOPDICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public readonly byte NLNCINBJFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public readonly byte HLPFILFHLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	public readonly byte PMENDOALOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public readonly byte AEJANKKFJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public readonly byte GKMEONCOPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public readonly byte LKMDMKNJJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public readonly byte HOIJPHBAJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public readonly byte HOCKNJAAHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public readonly byte ECGPGKKFHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public readonly byte MOCBMHDOPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public readonly byte KNOFPEALDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public readonly byte OKBANHCEEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public readonly byte NPHGFHGLOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public readonly byte BHANEDGNCMP;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static byte[] DJNEOMGBBNE;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static byte[] HLIJIEFFKPE;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x37AB2D0", Offset = "0x37A9AD0", VA = "0x1837AB2D0")]
	public HFDACDGAFLE(ref Guid HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x37AB2E0", Offset = "0x37A9AE0", VA = "0x1837AB2E0")]
	public HFDACDGAFLE(ref ArraySegment<byte> EIPMDKIALPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x37A9E20", Offset = "0x37A8620", VA = "0x1837A9E20")]
	private static byte HFLCMJDELKE(byte[] IFAOIOLKGMC, int OBAEJEDODLJ)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x37A9D10", Offset = "0x37A8510", VA = "0x1837A9D10")]
	private static byte GDDONPEOIGF(byte EOEFACHALFF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x37A9EE0", Offset = "0x37A86E0", VA = "0x1837A9EE0")]
	public void ILHFFDAAPGK(byte[] AFIAMHMLMFM, int FHLPLLKMCOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class JBDKFHAGFGA
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BC80", Offset = "0x2B7A480", VA = "0x182B7BC80")]
	public static bool OJIDONFIBAB(byte NBFCFFGLCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B860", Offset = "0x2B7A060", VA = "0x182B7B860")]
	public static bool JMJJBJMFFNI(byte NBFCFFGLCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B8D0", Offset = "0x2B7A0D0", VA = "0x182B7B8D0")]
	public static sbyte LDFJIJIJFLL(byte[] IFAOIOLKGMC, int FHLPLLKMCOH, out int HCFBDPKAIEF)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B7F0", Offset = "0x2B79FF0", VA = "0x182B7B7F0")]
	public static short IJKFACLMHMH(byte[] IFAOIOLKGMC, int FHLPLLKMCOH, out int HCFBDPKAIEF)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A1F0", Offset = "0x2B789F0", VA = "0x182B7A1F0")]
	public static int CJOEAOIMDFH(byte[] IFAOIOLKGMC, int FHLPLLKMCOH, out int HCFBDPKAIEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A140", Offset = "0x2B78940", VA = "0x182B7A140")]
	public static long BCAEBHGAJLF(byte[] IFAOIOLKGMC, int FHLPLLKMCOH, out int HCFBDPKAIEF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BD00", Offset = "0x2B7A500", VA = "0x182B7BD00")]
	public static byte PIADJCBMAEG(byte[] IFAOIOLKGMC, int FHLPLLKMCOH, out int HCFBDPKAIEF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B9C0", Offset = "0x2B7A1C0", VA = "0x182B7B9C0")]
	public static ushort NFNAJODNOAL(byte[] IFAOIOLKGMC, int FHLPLLKMCOH, out int HCFBDPKAIEF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B940", Offset = "0x2B7A140", VA = "0x182B7B940")]
	public static uint MBNGBCINGEO(byte[] IFAOIOLKGMC, int FHLPLLKMCOH, out int HCFBDPKAIEF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A260", Offset = "0x2B78A60", VA = "0x182B7A260")]
	public static ulong DFAJCKOAJJC(byte[] IFAOIOLKGMC, int FHLPLLKMCOH, out int HCFBDPKAIEF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BC90", Offset = "0x2B7A490", VA = "0x182B7BC90")]
	public static float OKIJIGFBEMF(byte[] IFAOIOLKGMC, int FHLPLLKMCOH, out int HCFBDPKAIEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A370", Offset = "0x2B78B70", VA = "0x182B7A370")]
	public static double EJLDPOPGGLL(byte[] IFAOIOLKGMC, int FHLPLLKMCOH, out int HCFBDPKAIEF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B020", Offset = "0x2B79820", VA = "0x182B7B020")]
	public static int GLGONCCPCON(ref byte[] AFIAMHMLMFM, int FHLPLLKMCOH, ulong HKJMLEKHILN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A3E0", Offset = "0x2B78BE0", VA = "0x182B7A3E0")]
	public static int GAIFDNAJGKG(ref byte[] AFIAMHMLMFM, int FHLPLLKMCOH, long HKJMLEKHILN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BA30", Offset = "0x2B7A230", VA = "0x182B7BA30")]
	public static bool NONJHAGJMLE(byte[] IFAOIOLKGMC, int FHLPLLKMCOH, out int HCFBDPKAIEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class IJAPNFBJLDO
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class MOHNCMFIJJP : IEnumerable<PropertyInfo>, IEnumerable, IEnumerator<PropertyInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private PropertyInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private IEnumerator<PropertyInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		PropertyInfo IEnumerator<PropertyInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7B2A20", Offset = "0x7B1220", VA = "0x1807B2A20")]
		[DebuggerHidden]
		public MOHNCMFIJJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2B87050", Offset = "0x2B85850", VA = "0x182B87050", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2B86BF0", Offset = "0x2B853F0", VA = "0x182B86BF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2B87170", Offset = "0x2B85970", VA = "0x182B87170")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2B871C0", Offset = "0x2B859C0", VA = "0x182B871C0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2B87000", Offset = "0x2B85800", VA = "0x182B87000", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x2B86F50", Offset = "0x2B85750", VA = "0x182B86F50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2B86F50", Offset = "0x2B85750", VA = "0x182B86F50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class KANMMFGKKNM : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private FieldInfo <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public Type <>3__type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private HashSet<string> nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public HashSet<string> <>3__nameCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private IEnumerator<FieldInfo> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		FieldInfo IEnumerator<FieldInfo>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7B2A20", Offset = "0x7B1220", VA = "0x1807B2A20")]
		[DebuggerHidden]
		public KANMMFGKKNM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D4B0", Offset = "0x2B7BCB0", VA = "0x182B7D4B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D050", Offset = "0x2B7B850", VA = "0x182B7D050", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D5D0", Offset = "0x2B7BDD0", VA = "0x182B7D5D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D620", Offset = "0x2B7BE20", VA = "0x182B7D620")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D460", Offset = "0x2B7BC60", VA = "0x182B7D460", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D3B0", Offset = "0x2B7BBB0", VA = "0x182B7D3B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D3B0", Offset = "0x2B7BBB0", VA = "0x182B7D3B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2B79680", Offset = "0x2B77E80", VA = "0x182B79680")]
	public static bool PLHONOFIKMM(this TypeInfo LIBGCFIILKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2B79490", Offset = "0x2B77C90", VA = "0x182B79490")]
	public static bool KMBJFJGHBEM(this TypeInfo LIBGCFIILKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2B79590", Offset = "0x2B77D90", VA = "0x182B79590")]
	public static IEnumerable<PropertyInfo> MDAALPAODEN(this Type LIBGCFIILKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2B793A0", Offset = "0x2B77BA0", VA = "0x182B793A0")]
	[IteratorStateMachine(typeof(MOHNCMFIJJP))]
	private static IEnumerable<PropertyInfo> AAOPFIBJNNO(Type LIBGCFIILKM, HashSet<string> EMMKNMBNNMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2B79430", Offset = "0x2B77C30", VA = "0x182B79430")]
	public static IEnumerable<FieldInfo> CAEHBBPNGAA(this Type LIBGCFIILKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2B795F0", Offset = "0x2B77DF0", VA = "0x182B795F0")]
	[IteratorStateMachine(typeof(KANMMFGKKNM))]
	private static IEnumerable<FieldInfo> PEJAHEGODJB(Type LIBGCFIILKM, HashSet<string> EMMKNMBNNMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal static class HFCGEFHCBBK
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public static readonly Encoding HPJEMDBMIBI;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal static class IKIPLJEIHOD
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x621ED0", Offset = "0x6206D0", VA = "0x180621ED0")]
	public static string EDLJOCPAGBN(string MOFEGIBBJBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2B79990", Offset = "0x2B78190", VA = "0x182B79990")]
	public static string IIMDHFJPMHM(string MOFEGIBBJBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2B797C0", Offset = "0x2B77FC0", VA = "0x182B797C0")]
	public static string EPPHBDHDHAG(string MOFEGIBBJBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class FHAOIIHIFOM<TValue>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class AMPLEDPGCNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Type CNJCNJLJNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public TValue MKOCEBDLMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int EGGGEHHKDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AMPLEDPGCNP OJCDEMLLCNI;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3278A60", Offset = "0x3277260", VA = "0x183278A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3278800", Offset = "0x3277000", VA = "0x183278800")]
		private int MPKAKPNFLIB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public AMPLEDPGCNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class EPLBICAOILO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public TValue value;

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public EPLBICAOILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x60DD70", Offset = "0x60C570", VA = "0x18060DD70")]
		internal TValue <TryAdd>b__0(Type _)
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private AMPLEDPGCNP[] FKAKHAMLHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int NBGGIOPLKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly object OAFPNEOIIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly float DLGFELNPDII;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x327FAA0", Offset = "0x327E2A0", VA = "0x18327FAA0")]
	public FHAOIIHIFOM(int LJMMIINDJEO = 4, float DLGFELNPDII = 0.75f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x327F080", Offset = "0x327D880", VA = "0x18327F080")]
	public bool KMHCKOBLAGL(Type HJCJKDOGPGK, TValue HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x327F2A0", Offset = "0x327DAA0", VA = "0x18327F2A0")]
	public bool KMHCKOBLAGL(Type HJCJKDOGPGK, Func<Type, TValue> MMAKMJMEICG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x327E8F0", Offset = "0x327D0F0", VA = "0x18327E8F0")]
	private bool IBMEHKJPADP(Type HJCJKDOGPGK, Func<Type, TValue> MMAKMJMEICG, out TValue AOBCKDBAPLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x327F310", Offset = "0x327DB10", VA = "0x18327F310")]
	private bool NKPANGEFKLK(AMPLEDPGCNP[] FKAKHAMLHPH, Type POCMHKOKPAA, AMPLEDPGCNP DAPBJHBCAPI, Func<Type, TValue> MMAKMJMEICG, out TValue AOBCKDBAPLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x327E650", Offset = "0x327CE50", VA = "0x18327E650")]
	public bool DHIHCKAPBED(Type HJCJKDOGPGK, out TValue HKJMLEKHILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x327EEF0", Offset = "0x327D6F0", VA = "0x18327EEF0")]
	public TValue JLHEHMNBADA(Type HJCJKDOGPGK, Func<Type, TValue> MMAKMJMEICG)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x327FA70", Offset = "0x327E270", VA = "0x18327FA70")]
	private static int OCNDAADCKMJ(int LLJANMLHBAE, float DLGFELNPDII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x327F2E0", Offset = "0x327DAE0", VA = "0x18327F2E0")]
	private static void NBELHJAOGFI(ref AMPLEDPGCNP EFJFBLCPDFF, AMPLEDPGCNP HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x327F2E0", Offset = "0x327DAE0", VA = "0x18327F2E0")]
	private static void NBELHJAOGFI(ref AMPLEDPGCNP[] EFJFBLCPDFF, AMPLEDPGCNP[] HKJMLEKHILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class AGEHFBIGEHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly AssemblyBuilder POFCMNOACJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly ModuleBuilder MGDJJAPNLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly object LEKIDLKBBNA;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x37966C0", Offset = "0x3794EC0", VA = "0x1837966C0")]
	public TypeBuilder CFGKEJLOHBM(string CGCECGHBEEN, TypeAttributes KMIFLHDJJKD, Type BNOBPGHCIOL, Type[] AFGNPOFKMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x37967B0", Offset = "0x3794FB0", VA = "0x1837967B0")]
	public AGEHFBIGEHC(string DHHKKCKMGFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal static class PAINBBGLCCH
{
	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x4F541E0", Offset = "0x4F529E0", VA = "0x184F541E0")]
	private static MethodInfo KABKOBMLGJO(LambdaExpression HNDANAHNBLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8A70", Offset = "0x2BD7270", VA = "0x182BD8A70")]
	public static MethodInfo HDKAHOLONKL<T>(Expression<Func<T>> HNDANAHNBLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8A70", Offset = "0x2BD7270", VA = "0x182BD8A70")]
	public static MethodInfo HDKAHOLONKL<T, TR>(Expression<Func<T, TR>> HNDANAHNBLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8A70", Offset = "0x2BD7270", VA = "0x182BD8A70")]
	public static MethodInfo HDKAHOLONKL<T>(Expression<Action<T>> HNDANAHNBLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8A70", Offset = "0x2BD7270", VA = "0x182BD8A70")]
	public static MethodInfo HDKAHOLONKL<T, TArg1, TR>(Expression<Func<T, TArg1, TR>> HNDANAHNBLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8970", Offset = "0x2BD7170", VA = "0x182BD8970")]
	private static MemberInfo AAPLFMKHPIA<T>(Expression<T> MBEGPEONCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x2BD8A10", Offset = "0x2BD7210", VA = "0x182BD8A10")]
	public static PropertyInfo BBMJBKOLCAA<T, TR>(Expression<Func<T, TR>> HNDANAHNBLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct PGNGMEFBAIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int HPENCEMKHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly bool PFNPMEGMHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly ILGenerator OMJNMOMELNA;

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x4F54B30", Offset = "0x4F53330", VA = "0x184F54B30")]
	public PGNGMEFBAIP(ILGenerator OMJNMOMELNA, int HPENCEMKHKB, bool PFNPMEGMHOB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x4F54B70", Offset = "0x4F53370", VA = "0x184F54B70")]
	public PGNGMEFBAIP(ILGenerator OMJNMOMELNA, int HPENCEMKHKB, Type LIBGCFIILKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x4F54B10", Offset = "0x4F53310", VA = "0x184F54B10")]
	public void BNAHILADHEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal static class MLKOJKACBLN
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x2B852A0", Offset = "0x2B83AA0", VA = "0x182B852A0")]
	public static void BMOFJOJKFFF(this ILGenerator OMJNMOMELNA, int EDBBKGCLEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x2B85260", Offset = "0x2B83A60", VA = "0x182B85260")]
	public static void BMOFJOJKFFF(this ILGenerator OMJNMOMELNA, LocalBuilder GBCMACHDILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x2B85EE0", Offset = "0x2B846E0", VA = "0x182B85EE0")]
	public static void KPBOCCHEBLH(this ILGenerator OMJNMOMELNA, int EDBBKGCLEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x2B86110", Offset = "0x2B84910", VA = "0x182B86110")]
	public static void KPBOCCHEBLH(this ILGenerator OMJNMOMELNA, LocalBuilder GBCMACHDILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x2B859C0", Offset = "0x2B841C0", VA = "0x182B859C0")]
	public static void FPDKGGPLBFF(this ILGenerator OMJNMOMELNA, int EDBBKGCLEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x2B85AB0", Offset = "0x2B842B0", VA = "0x182B85AB0")]
	public static void FPDKGGPLBFF(this ILGenerator OMJNMOMELNA, LocalBuilder GBCMACHDILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2B85D50", Offset = "0x2B84550", VA = "0x182B85D50")]
	public static void JGJLBBOLLKN(this ILGenerator OMJNMOMELNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2B85D40", Offset = "0x2B84540", VA = "0x182B85D40")]
	public static void JAEOGFKCHLP(this ILGenerator OMJNMOMELNA, bool HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2B854D0", Offset = "0x2B83CD0", VA = "0x182B854D0")]
	public static void CKNGLEIFNCA(this ILGenerator OMJNMOMELNA, int HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2B85D60", Offset = "0x2B84560", VA = "0x182B85D60")]
	public static void JLODJBOPJFE(this ILGenerator OMJNMOMELNA, Type LIBGCFIILKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2B85920", Offset = "0x2B84120", VA = "0x182B85920")]
	public static void CPOGDKLLJOK(this ILGenerator OMJNMOMELNA, Type LIBGCFIILKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2B86150", Offset = "0x2B84950", VA = "0x182B86150")]
	public static void MCLALMAEHIP(this ILGenerator OMJNMOMELNA, int EDBBKGCLEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x2B85BC0", Offset = "0x2B843C0", VA = "0x182B85BC0")]
	public static void HDPLMDCAKDG(this ILGenerator OMJNMOMELNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x2B85170", Offset = "0x2B83970", VA = "0x182B85170")]
	public static void BIOAMHGJDPK(this ILGenerator OMJNMOMELNA, int EDBBKGCLEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x2B85C40", Offset = "0x2B84440", VA = "0x182B85C40")]
	public static void HNADANOFDLO(this ILGenerator OMJNMOMELNA, MethodInfo GCEDCELPEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2B85E50", Offset = "0x2B84650", VA = "0x182B85E50")]
	public static void KHBLHAKENJB(this ILGenerator OMJNMOMELNA, FieldInfo ADEDKMPOMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x2B86380", Offset = "0x2B84B80", VA = "0x182B86380")]
	public static void PJMJEOBOINE(this ILGenerator OMJNMOMELNA, ulong HKJMLEKHILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class EOAIIGIMKIK
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class NBBJFJNPNEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public string shouldSerialize;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public NBBJFJNPNEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x37AD0A0", Offset = "0x37AB8A0", VA = "0x1837AD0A0")]
		internal bool <GetShouldSerialize>b__0(MethodInfo x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private MethodInfo GECGCAPLELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MethodInfo FGNGFAJMCLG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string POGAANJDOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5DDA30", Offset = "0x5DC230", VA = "0x1805DDA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string JMCOLFIIGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x575980", Offset = "0x574180", VA = "0x180575980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KNLBJIOHNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x37A15D0", Offset = "0x379FDD0", VA = "0x1837A15D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ENAHPBFKOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x5D5130", Offset = "0x5D3930", VA = "0x1805D5130")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5D5120", Offset = "0x5D3920", VA = "0x1805D5120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool FMFKFIOLDOM
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x734BC0", Offset = "0x7333C0", VA = "0x180734BC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x734BE0", Offset = "0x7333E0", VA = "0x180734BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Type JJJIFGKFLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5749E0", Offset = "0x5731E0", VA = "0x1805749E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x5D51A0", Offset = "0x5D39A0", VA = "0x1805D51A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FieldInfo DBCAOMJKCID
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x574330", Offset = "0x572B30", VA = "0x180574330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6155C0", Offset = "0x613DC0", VA = "0x1806155C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PropertyInfo MBPHCEEHDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x573EE0", Offset = "0x5726E0", VA = "0x180573EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5B5120", Offset = "0x5B3920", VA = "0x1805B5120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MethodInfo HOGNAIEOAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x574F30", Offset = "0x573730", VA = "0x180574F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5D50F0", Offset = "0x5D38F0", VA = "0x1805D50F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x37A1910", Offset = "0x37A0110", VA = "0x1837A1910")]
	protected EOAIIGIMKIK(Type LIBGCFIILKM, string CGCECGHBEEN, string CDLIPOPLLIL, bool CMMDAFBBKDH, bool LLNOHADLMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x37A1990", Offset = "0x37A0190", VA = "0x1837A1990")]
	public EOAIIGIMKIK(FieldInfo JFGBMPDGMJF, string CGCECGHBEEN, bool GOILGNKHGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x37A1760", Offset = "0x379FF60", VA = "0x1837A1760")]
	public EOAIIGIMKIK(PropertyInfo JFGBMPDGMJF, string CGCECGHBEEN, bool GOILGNKHGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x37A14B0", Offset = "0x379FCB0", VA = "0x1837A14B0")]
	private static MethodInfo DMBNGJIPBBJ(MemberInfo JFGBMPDGMJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x23904A0", Offset = "0x238ECA0", VA = "0x1823904A0")]
	public T AODKHPIFHCC<T>(bool CGKFJDOOJGO) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x37A16A0", Offset = "0x379FEA0", VA = "0x1837A16A0", Slot = "4")]
	public virtual void LHNLHHJMJNP(ILGenerator OMJNMOMELNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x37A15E0", Offset = "0x379FDE0", VA = "0x1837A15E0", Slot = "5")]
	public virtual void LHHHEBMJLMM(ILGenerator OMJNMOMELNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal class CACCGGAAGBC : EOAIIGIMKIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly string AENHFJLBGDK;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x379A860", Offset = "0x3799060", VA = "0x18379A860")]
	public CACCGGAAGBC(string CGCECGHBEEN, string AENHFJLBGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x379A7A0", Offset = "0x3798FA0", VA = "0x18379A7A0", Slot = "4")]
	public override void LHNLHHJMJNP(ILGenerator OMJNMOMELNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x379A750", Offset = "0x3798F50", VA = "0x18379A750", Slot = "5")]
	public override void LHHHEBMJLMM(ILGenerator OMJNMOMELNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class NDPMIPMIDCI : EOAIIGIMKIK
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly MethodInfo APJNHCINFED;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly MethodInfo NKEENCMBKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	internal PGNGMEFBAIP MELKJEKGLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	internal PGNGMEFBAIP MBKGDIMKDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	internal PGNGMEFBAIP OFCECAPPPED;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x2B888F0", Offset = "0x2B870F0", VA = "0x182B888F0")]
	public NDPMIPMIDCI(string CGCECGHBEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2B88390", Offset = "0x2B86B90", VA = "0x182B88390", Slot = "4")]
	public override void LHNLHHJMJNP(ILGenerator OMJNMOMELNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2B88340", Offset = "0x2B86B40", VA = "0x182B88340", Slot = "5")]
	public override void LHHHEBMJLMM(ILGenerator OMJNMOMELNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2B88230", Offset = "0x2B86A30", VA = "0x182B88230")]
	public void DCAJIIILOOM(ILGenerator OMJNMOMELNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal class NIPFGLOKGCJ
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Type JJJIFGKFLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5DDA30", Offset = "0x5DC230", VA = "0x1805DDA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool ALOGGMDMCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x739330", Offset = "0x737B30", VA = "0x180739330")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x739910", Offset = "0x738110", VA = "0x180739910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GJALOCABKCF
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7C6250", Offset = "0x7C4A50", VA = "0x1807C6250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7C6260", Offset = "0x7C4A60", VA = "0x1807C6260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ConstructorInfo NJPENLHPLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x574E70", Offset = "0x573670", VA = "0x180574E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x574F10", VA = "0x180576710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public EOAIIGIMKIK[] PPFPFAFCNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5749E0", Offset = "0x5731E0", VA = "0x1805749E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x5D51A0", Offset = "0x5D39A0", VA = "0x1805D51A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EOAIIGIMKIK[] GEKCHKAFKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x574330", Offset = "0x572B30", VA = "0x180574330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6155C0", Offset = "0x613DC0", VA = "0x1806155C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x2B8AAA0", Offset = "0x2B892A0", VA = "0x182B8AAA0")]
	public NIPFGLOKGCJ(Type LIBGCFIILKM, Func<string, string> KECFDDPOIDK, bool GOILGNKHGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A9D0", Offset = "0x2B891D0", VA = "0x182B8A9D0")]
	private static bool NDHKJIBCKLA(IEnumerator<ConstructorInfo> BNKBHOLOPDG, ref ConstructorInfo NAIKMJJENBN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
internal struct IPDHHJHIELC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ulong BDAEDLHKBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public int AEAEPNFFAPK;

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2984200", Offset = "0x2982A00", VA = "0x182984200")]
	public IPDHHJHIELC(ulong CPNLFHPCPJM, int MDNMECLLBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x2B79DE0", Offset = "0x2B785E0", VA = "0x182B79DE0")]
	public void DGFOGCENOGP(ref IPDHHJHIELC EFDJFLPIKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x2B79DF0", Offset = "0x2B785F0", VA = "0x182B79DF0")]
	public static IPDHHJHIELC FBODDPFMELI(ref IPDHHJHIELC FCCDOLKCOHD, ref IPDHHJHIELC EOEFACHALFF)
	{
		return default(IPDHHJHIELC);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2B79EC0", Offset = "0x2B786C0", VA = "0x182B79EC0")]
	public void JBOGLJNLHCB(ref IPDHHJHIELC EFDJFLPIKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B79F50", Offset = "0x2B78750", VA = "0x182B79F50")]
	public static IPDHHJHIELC KLOMLMMDEKE(ref IPDHHJHIELC FCCDOLKCOHD, ref IPDHHJHIELC EOEFACHALFF)
	{
		return default(IPDHHJHIELC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B79E20", Offset = "0x2B78620", VA = "0x182B79E20")]
	public void IPEOFAOJEML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B79E60", Offset = "0x2B78660", VA = "0x182B79E60")]
	public static IPDHHJHIELC IPEOFAOJEML(ref IPDHHJHIELC FCCDOLKCOHD)
	{
		return default(IPDHHJHIELC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal struct GLGDDJMFHCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public byte[] AFIAMHMLMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public int FHLPLLKMCOH;

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0xA2DC80", Offset = "0xA2C480", VA = "0x180A2DC80")]
	public GLGDDJMFHCB(byte[] AFIAMHMLMFM, int MGHDMPNEKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x37A93D0", Offset = "0x37A7BD0", VA = "0x1837A93D0")]
	public void OJCFLMPKEIE(byte CMNNFMDFJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x37A9330", Offset = "0x37A7B30", VA = "0x1837A9330")]
	public void NIGJEJMJEMJ(byte[] CMNNFMDFJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x37A90E0", Offset = "0x37A78E0", VA = "0x1837A90E0")]
	public void AMOGACLFPLK(byte[] CMNNFMDFJBF, int EKOLDJKMDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x37A9180", Offset = "0x37A7980", VA = "0x1837A9180")]
	public void AMOGACLFPLK(byte[] CMNNFMDFJBF, int EDGNDOFMPJJ, int EKOLDJKMDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x37A9430", Offset = "0x37A7C30", VA = "0x1837A9430")]
	public void PBJLCIHEFNF(byte NBFCFFGLCPM, int NLKMJJJPIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x37A9230", Offset = "0x37A7A30", VA = "0x1837A9230")]
	public void DMHNPGGLAMO(string CMNNFMDFJBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal static class NGHNBNICBEG
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private enum KFBOMPBDFJN
	{
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		FAST_DTOA_SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		FAST_DTOA_SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum OFPKEGEAHPE
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		SHORTEST,
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		SHORTEST_SINGLE
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private enum FNECMANFDFL
	{
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		NO_FLAGS = 0,
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		EMIT_POSITIVE_EXPONENT_SIGN = 1,
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		EMIT_TRAILING_DECIMAL_POINT = 2,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		EMIT_TRAILING_ZERO_AFTER_POINT = 4,
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		UNIQUE_ZERO = 8
	}

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	[ThreadStatic]
	private static byte[] GOJOKKBEIKA;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[ThreadStatic]
	private static byte[] EEEENFLELCC;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static readonly byte[] AKAFAGDEGFH;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static readonly byte[] CKEMEGLBPKJ;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static readonly FNECMANFDFL EGOPONIAENA;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static readonly char JKKCCKLPJHK;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static readonly int BAKEBNIKHEB;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static readonly int KIOBJEGPBAK;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static readonly uint[] OAJECMPOEAN;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B89E10", Offset = "0x2B88610", VA = "0x182B89E10")]
	private static byte[] NNLNHONKKMJ(int NBGGIOPLKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x2B899B0", Offset = "0x2B881B0", VA = "0x182B899B0")]
	private static byte[] FAFOBIBOFDL(int NBGGIOPLKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2B89790", Offset = "0x2B87F90", VA = "0x182B89790")]
	public static int EIGDPHCHDJM(ref byte[] AFIAMHMLMFM, int FHLPLLKMCOH, float HKJMLEKHILN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2B898A0", Offset = "0x2B880A0", VA = "0x182B898A0")]
	public static int EIGDPHCHDJM(ref byte[] AFIAMHMLMFM, int FHLPLLKMCOH, double HKJMLEKHILN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2B89A90", Offset = "0x2B88290", VA = "0x182B89A90")]
	private static bool GKLGMNNBEPC(byte[] AFIAMHMLMFM, int EKOLDJKMDKB, ulong EDEFAEIAJLC, ulong NBEIPHMJKAO, ulong PHMAPPNHPCN, ulong ECOIEMJJCHD, ulong PCDPHBDNDOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A510", Offset = "0x2B88D10", VA = "0x182B8A510")]
	private static void PCHALBMEHJD(uint LLODKGEMNMP, int OPOBIPKLCEJ, out uint MGLHDHBDHJN, out int ILFCBMPKIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2B893C0", Offset = "0x2B87BC0", VA = "0x182B893C0")]
	private static bool DJFFLLMFGLM(IPDHHJHIELC LGBBEHBKCHB, IPDHHJHIELC JOBBLOMPKMF, IPDHHJHIELC HOJLCIIGBDP, byte[] AFIAMHMLMFM, out int EKOLDJKMDKB, out int FJDOLMLBKHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2B89040", Offset = "0x2B87840", VA = "0x182B89040")]
	private static bool CNKPLJPKEDN(double KDMLNPNMPPG, KFBOMPBDFJN LLMKIKMAMMP, byte[] AFIAMHMLMFM, out int EKOLDJKMDKB, out int MEBKCPLOPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2B89B90", Offset = "0x2B88390", VA = "0x182B89B90")]
	private static bool JCBLNCDLAJE(double KDMLNPNMPPG, KFBOMPBDFJN LLMKIKMAMMP, byte[] AFIAMHMLMFM, out int EKOLDJKMDKB, out int GMDNLLIIHCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2B89C80", Offset = "0x2B88480", VA = "0x182B89C80")]
	private static bool NDNJGKBOKIG(double HKJMLEKHILN, ref GLGDDJMFHCB LNOMFCEGPNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2B89EE0", Offset = "0x2B886E0", VA = "0x182B89EE0")]
	private static bool OLLODCGNJCN(double HKJMLEKHILN, ref GLGDDJMFHCB LNOMFCEGPNP, OFPKEGEAHPE LLMKIKMAMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2B88B90", Offset = "0x2B87390", VA = "0x182B88B90")]
	private static void CCENKFBDNIE(byte[] BGKAEFNOABL, int EKOLDJKMDKB, int GMDNLLIIHCB, int ECJKCMJKMJE, ref GLGDDJMFHCB LNOMFCEGPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2B88D50", Offset = "0x2B87550", VA = "0x182B88D50")]
	private static void CNDCMKCBLCO(byte[] BGKAEFNOABL, int EKOLDJKMDKB, int MDNMECLLBMJ, ref GLGDDJMFHCB LNOMFCEGPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2B8A630", Offset = "0x2B88E30", VA = "0x182B8A630")]
	private static bool PMAGCJELADM(double KDMLNPNMPPG, OFPKEGEAHPE LLMKIKMAMMP, int MEKIFAJEFAA, byte[] EMKOJLIGIIL, out bool AHEIIJLBHHP, out int EKOLDJKMDKB, out int BFLKNHJAHLJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal struct MOHEECOCELO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public double NAIPFDPNHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ulong LJFDDEOFKCF;
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal struct AKKOCFDHJPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public float BDAEDLHKBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public uint MDCAECKLINO;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal struct EBHBNKPIKHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private ulong OLBAGLIDKKK;

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x10F9970", Offset = "0x10F8170", VA = "0x1810F9970")]
	public EBHBNKPIKHN(double NAIPFDPNHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x37A0AB0", Offset = "0x379F2B0", VA = "0x1837A0AB0")]
	public EBHBNKPIKHN(IPDHHJHIELC NAIPFDPNHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x37A0710", Offset = "0x379EF10", VA = "0x1837A0710")]
	public IPDHHJHIELC EEGCNHCDCHL()
	{
		return default(IPDHHJHIELC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x37A0600", Offset = "0x379EE00", VA = "0x1837A0600")]
	public IPDHHJHIELC CEGJPKKIHAL()
	{
		return default(IPDHHJHIELC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x60DD50", Offset = "0x60C550", VA = "0x18060DD50")]
	public ulong EGNBAJLGMGF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x37A0590", Offset = "0x379ED90", VA = "0x1837A0590")]
	public double AKJGLBCECLO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x37A0790", Offset = "0x379EF90", VA = "0x1837A0790")]
	public double FGCPNAEDAPD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x37A0A80", Offset = "0x379F280", VA = "0x1837A0A80")]
	public int PHPMMMABFNC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x37A0560", Offset = "0x379ED60", VA = "0x1837A0560")]
	public ulong AHOMFMOHAGN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x37A0A10", Offset = "0x379F210", VA = "0x1837A0A10")]
	public bool LPAHPIGMDMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x37A0850", Offset = "0x379F050", VA = "0x1837A0850")]
	public bool KBPMDCHMGCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x37A0820", Offset = "0x379F020", VA = "0x1837A0820")]
	public bool INLJNAFKFIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x37A0A30", Offset = "0x379F230", VA = "0x1837A0A30")]
	public bool NOEHNCJLGPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x37A06A0", Offset = "0x379EEA0", VA = "0x1837A06A0")]
	public int CHDGFGBGOEN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x37A0880", Offset = "0x379F080", VA = "0x1837A0880")]
	public void LIMNNGNCDHO(out IPDHHJHIELC CHLMNEEEPFB, out IPDHHJHIELC EPLLGGILDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x37A06C0", Offset = "0x379EEC0", VA = "0x1837A06C0")]
	public bool EAGOPJANANA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x37A0810", Offset = "0x379F010", VA = "0x1837A0810")]
	public double HKJMLEKHILN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x37A0A60", Offset = "0x379F260", VA = "0x1837A0A60")]
	public static int PDPIJLCBNCA(int MFBMLIPLHCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x37A0870", Offset = "0x379F070", VA = "0x1837A0870")]
	public static double KLCFIHMBGEC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x37A04C0", Offset = "0x379ECC0", VA = "0x1837A04C0")]
	public static ulong AEEOGMILFKB(IPDHHJHIELC LBNECAKCOCE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal struct LHGILLNFAPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private uint BLCDECJIAJK;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x72A2F0", Offset = "0x728AF0", VA = "0x18072A2F0")]
	public LHGILLNFAPI(float BDAEDLHKBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x2B80C60", Offset = "0x2B7F460", VA = "0x182B80C60")]
	public IPDHHJHIELC EEGCNHCDCHL()
	{
		return default(IPDHHJHIELC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x60DDA0", Offset = "0x60C5A0", VA = "0x18060DDA0")]
	public uint MNEEHMMPPKB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2B80DF0", Offset = "0x2B7F5F0", VA = "0x182B80DF0")]
	public int PHPMMMABFNC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2B80C00", Offset = "0x2B7F400", VA = "0x182B80C00")]
	public uint AHOMFMOHAGN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2B80DE0", Offset = "0x2B7F5E0", VA = "0x182B80DE0")]
	public bool LPAHPIGMDMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2B80CB0", Offset = "0x2B7F4B0", VA = "0x182B80CB0")]
	public void LIMNNGNCDHO(out IPDHHJHIELC CHLMNEEEPFB, out IPDHHJHIELC EPLLGGILDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2B80C20", Offset = "0x2B7F420", VA = "0x182B80C20")]
	public bool EAGOPJANANA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal struct JCCNHAFDPLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public readonly ulong CPNLFHPCPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public readonly short DLOJPKNNLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public readonly short MEBKCPLOPLK;

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BD70", Offset = "0x2B7A570", VA = "0x182B7BD70")]
	public JCCNHAFDPLM(ulong CPNLFHPCPJM, short DLOJPKNNLCL, short MEBKCPLOPLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal static class DPFBPDDNGJH
{
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly JCCNHAFDPLM[] NJGKHLAJJEK;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x379E310", Offset = "0x379CB10", VA = "0x18379E310")]
	public static void DDDHFGKGLPD(int PHLACCDCDAN, int JFIOMIBNEMO, out IPDHHJHIELC MGLHDHBDHJN, out int MEBKCPLOPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x379E440", Offset = "0x379CC40", VA = "0x18379E440")]
	public static void OAANFACGINP(int HCKHBOAJJME, out IPDHHJHIELC MGLHDHBDHJN, out int PKIOCLFNPNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DefaultMember("Item")]
internal struct BMAGCFDILKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly byte[] IFAOIOLKGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public readonly int EDGNDOFMPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public readonly int KPFBDIECKNP;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte KJIAGDJOCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x37998C0", Offset = "0x37980C0", VA = "0x1837998C0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x28D27F0", Offset = "0x28D0FF0", VA = "0x1828D27F0")]
	public BMAGCFDILKB(byte[] IFAOIOLKGMC, int EDGNDOFMPJJ, int EKOLDJKMDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xA286E0", Offset = "0xA26EE0", VA = "0x180A286E0")]
	public int EKOLDJKMDKB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x3799860", Offset = "0x3798060", VA = "0x183799860")]
	public BMAGCFDILKB ICEHPLLOFEA(int FHFEHODFOLN, int JNFAFPIELPD)
	{
		return default(BMAGCFDILKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class LOMHIBJFJJP
{
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	[ThreadStatic]
	private static byte[] LCNOHNNPDIB;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly double[] GEDHEBMCDIL;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly int LCMBEDLCMCK;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2B81CF0", Offset = "0x2B804F0", VA = "0x182B81CF0")]
	private static byte[] KKHKEPBFGGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2B824E0", Offset = "0x2B80CE0", VA = "0x182B824E0")]
	private static BMAGCFDILKB PENJEFAHDJI(BMAGCFDILKB AFIAMHMLMFM)
	{
		return default(BMAGCFDILKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2B81C40", Offset = "0x2B80440", VA = "0x182B81C40")]
	private static BMAGCFDILKB HJFHDFIGMMM(BMAGCFDILKB AFIAMHMLMFM)
	{
		return default(BMAGCFDILKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2B821B0", Offset = "0x2B809B0", VA = "0x182B821B0")]
	private static void NEMHHNFAIML(BMAGCFDILKB AFIAMHMLMFM, int MDNMECLLBMJ, byte[] NCNOOJJECGA, out int PJCJKOFLGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2B81F00", Offset = "0x2B80700", VA = "0x182B81F00")]
	private static void MAHNCFEJHCA(BMAGCFDILKB AFIAMHMLMFM, int MDNMECLLBMJ, byte[] CAFPEGFDPNE, int ODNCIKMAPJF, out BMAGCFDILKB DLBCFPKCLIM, out int KLMEJAPPBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2B82270", Offset = "0x2B80A70", VA = "0x182B82270")]
	private static ulong OBAOKAJAEFI(BMAGCFDILKB AFIAMHMLMFM, out int MMFLDNDMAJA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2B81DD0", Offset = "0x2B805D0", VA = "0x182B81DD0")]
	private static void LAGCCNEHPBM(BMAGCFDILKB AFIAMHMLMFM, out IPDHHJHIELC JOPBNPIPIOF, out int KMNNIHOPCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2B811C0", Offset = "0x2B7F9C0", VA = "0x182B811C0")]
	private static bool CALMKADGAAK(BMAGCFDILKB DLBCFPKCLIM, int MDNMECLLBMJ, out double JOPBNPIPIOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2B81AA0", Offset = "0x2B802A0", VA = "0x182B81AA0")]
	private static IPDHHJHIELC HEHAHIOMICO(int MDNMECLLBMJ)
	{
		return default(IPDHHJHIELC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B81570", Offset = "0x2B7FD70", VA = "0x182B81570")]
	private static bool FDGPNHDMNCG(BMAGCFDILKB AFIAMHMLMFM, int MDNMECLLBMJ, out double JOPBNPIPIOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2B81080", Offset = "0x2B7F880", VA = "0x182B81080")]
	private static bool BNCMCOFKLNO(BMAGCFDILKB DLBCFPKCLIM, int MDNMECLLBMJ, out double MNKHIMBPINA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2B80F50", Offset = "0x2B7F750", VA = "0x182B80F50")]
	public static double? AGNMKKIMFJF(BMAGCFDILKB AFIAMHMLMFM, int MDNMECLLBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2B82300", Offset = "0x2B80B00", VA = "0x182B82300")]
	public static float? OJDGLIGICGP(BMAGCFDILKB AFIAMHMLMFM, int MDNMECLLBMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal struct BMNIFCENPHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private byte[] AFIAMHMLMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private int FHLPLLKMCOH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public byte MKOCEBDLMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x37999C0", Offset = "0x37981C0", VA = "0x1837999C0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0xA2DC80", Offset = "0xA2C480", VA = "0x180A2DC80")]
	public BMNIFCENPHC(byte[] AFIAMHMLMFM, int FHLPLLKMCOH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x3799A80", Offset = "0x3798280", VA = "0x183799A80")]
	public static BMNIFCENPHC JDKNJGLOBIL(BMNIFCENPHC MHKBKFBCDKB)
	{
		return default(BMNIFCENPHC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x3799900", Offset = "0x3798100", VA = "0x183799900")]
	public static BMNIFCENPHC DNNHMNKHDPN(BMNIFCENPHC MHKBKFBCDKB, int EKOLDJKMDKB)
	{
		return default(BMNIFCENPHC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x3799AD0", Offset = "0x37982D0", VA = "0x183799AD0")]
	public static int JHLNBHPJLDA(BMNIFCENPHC BPMLEJCIOKJ, BMNIFCENPHC HPMKMLPAGEM)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x37999A0", Offset = "0x37981A0", VA = "0x1837999A0")]
	public static bool FDENDFOHHOL(BMNIFCENPHC BPMLEJCIOKJ, BMNIFCENPHC HPMKMLPAGEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x3799B30", Offset = "0x3798330", VA = "0x183799B30")]
	public static bool OGBHFPKCJDL(BMNIFCENPHC BPMLEJCIOKJ, BMNIFCENPHC HPMKMLPAGEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x3799960", Offset = "0x3798160", VA = "0x183799960")]
	public static bool FDENDFOHHOL(BMNIFCENPHC BPMLEJCIOKJ, char HPMKMLPAGEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x3799B50", Offset = "0x3798350", VA = "0x183799B50")]
	public static bool OGBHFPKCJDL(BMNIFCENPHC BPMLEJCIOKJ, char HPMKMLPAGEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x3799B50", Offset = "0x3798350", VA = "0x183799B50")]
	public static bool OGBHFPKCJDL(BMNIFCENPHC BPMLEJCIOKJ, byte HPMKMLPAGEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x3799A90", Offset = "0x3798290", VA = "0x183799A90")]
	public static bool JGJMBBFAKGO(BMNIFCENPHC BPMLEJCIOKJ, char HPMKMLPAGEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x3799A00", Offset = "0x3798200", VA = "0x183799A00")]
	public static bool GHHEBCFBJMO(BMNIFCENPHC BPMLEJCIOKJ, char HPMKMLPAGEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x3799A40", Offset = "0x3798240", VA = "0x183799A40")]
	public static bool IEKMDAFENID(BMNIFCENPHC BPMLEJCIOKJ, char HPMKMLPAGEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x3799AF0", Offset = "0x37982F0", VA = "0x183799AF0")]
	public static bool MGKLPCIPNPD(BMNIFCENPHC BPMLEJCIOKJ, char HPMKMLPAGEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal static class CJIHAONFOHF
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	[ThreadStatic]
	private static byte[] IPIFOCOGPOF;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[ThreadStatic]
	private static byte[] GOLALLBEHIA;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly byte[] AKAFAGDEGFH;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly byte[] CKEMEGLBPKJ;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly byte[] CGFMLJPGJGH;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly int EBIMAALFDBB;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ushort[] FJPFBKOMBGD;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly int OKADLANDPOL;

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x379BC30", Offset = "0x379A430", VA = "0x18379BC30")]
	private static byte[] BMMCNOMJGIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x379BDD0", Offset = "0x379A5D0", VA = "0x18379BDD0")]
	private static byte[] GDDLNPBIJDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x379BD10", Offset = "0x379A510", VA = "0x18379BD10")]
	public static double EJCLBBMAGHK(byte[] AFIAMHMLMFM, int FHLPLLKMCOH, out int HCFBDPKAIEF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x379BFE0", Offset = "0x379A7E0", VA = "0x18379BFE0")]
	public static float JAPJIANJJCD(byte[] AFIAMHMLMFM, int FHLPLLKMCOH, out int HCFBDPKAIEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x379D140", Offset = "0x379B940", VA = "0x18379D140")]
	private static bool NOCLMDELFIB(int FNGOAMCGAPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x379BEB0", Offset = "0x379A6B0", VA = "0x18379BEB0")]
	private static bool JAMGCEDCJCF(ref BMNIFCENPHC OAFEKMOHHGG, BMNIFCENPHC KLPHHCIKKJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x379D2C0", Offset = "0x379BAC0", VA = "0x18379D2C0")]
	private static bool PIABFPNHIMO(ref BMNIFCENPHC OAFEKMOHHGG, BMNIFCENPHC KLPHHCIKKJA, byte[] PNKPJEPCNFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x379C0A0", Offset = "0x379A8A0", VA = "0x18379C0A0")]
	private static bool KPAMJPEINIP(ref BMNIFCENPHC PCNNKBEBPEH, byte[] CMNNFMDFJBF, int FHLPLLKMCOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x86B010", Offset = "0x869810", VA = "0x18086B010")]
	private static double MPAMKMKJMCG(bool AHEIIJLBHHP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x379C100", Offset = "0x379A900", VA = "0x18379C100")]
	private static double LNHJLCJJLPC(BMNIFCENPHC FNLFJKKGAHO, int EKOLDJKMDKB, bool OKDMJNLMCNF, out int KDIHBDPEDOM)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class CPDPOLCGIFC<T> : global::KAKKFHPFHDD<T[]>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly global::DOOALKNCCHC<T> CIIOKLMIOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly GPJFFKPKHLA BIABJIGEFBN;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3892040", Offset = "0x3890840", VA = "0x183892040")]
	public CPDPOLCGIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xF51650", Offset = "0xF4FE50", VA = "0x180F51650")]
	public CPDPOLCGIFC(GPJFFKPKHLA BIABJIGEFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x4209EF0", Offset = "0x42086F0", VA = "0x184209EF0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, T[] HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x4208360", Offset = "0x4206B60", VA = "0x184208360", Slot = "5")]
	public T[] DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class DINEIAPPEMC<T>
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly global::DOOALKNCCHC<T> CIIOKLMIOID;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class MDEBDAKDOEB<T> : global::KAKKFHPFHDD<List<T>>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly GPJFFKPKHLA BIABJIGEFBN;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3892040", Offset = "0x3890840", VA = "0x183892040")]
	public MDEBDAKDOEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xF51650", Offset = "0xF4FE50", VA = "0x180F51650")]
	public MDEBDAKDOEB(GPJFFKPKHLA BIABJIGEFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3891E20", Offset = "0x3890620", VA = "0x183891E20", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, List<T> HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3890A20", Offset = "0x388F220", VA = "0x183890A20", Slot = "5")]
	public List<T> DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public abstract class FDNBCGNOFKL<TElement, TIntermediate, TEnumerator, TCollection> : global::KAKKFHPFHDD<TCollection>, MAIGLFCCAEJ where TEnumerator : IEnumerator<TElement> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x390B920", Offset = "0x390A120", VA = "0x18390B920", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, TCollection HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x390B500", Offset = "0x3909D00", VA = "0x18390B500", Slot = "5")]
	public TCollection DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator JNBKMLHOAFA(TCollection MBEGPEONCCJ);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate DIFMOOHBFDA();

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void DEOBKNOOHMB(ref TIntermediate ACAOFABICDI, int EDBBKGCLEJF, TElement HKJMLEKHILN);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TCollection GINAAGHMPKK(ref TIntermediate FMKBFGIFIJA);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
	protected FDNBCGNOFKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public abstract class GMJLLEKFAJE<TElement, TIntermediate, TCollection> : global::FDNBCGNOFKL<TElement, TIntermediate, IEnumerator<TElement>, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3197B70", Offset = "0x3196370", VA = "0x183197B70", Slot = "6")]
	protected override IEnumerator<TElement> JNBKMLHOAFA(TCollection MBEGPEONCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2310E40", Offset = "0x230F640", VA = "0x182310E40")]
	protected GMJLLEKFAJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public abstract class JAAEJGPDNMF<TElement, TCollection> : global::GMJLLEKFAJE<TElement, TCollection, TCollection> where TCollection : class, IEnumerable<TElement>
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xF4D780", Offset = "0xF4BF80", VA = "0x180F4D780", Slot = "9")]
	protected sealed override TCollection GINAAGHMPKK(ref TCollection FMKBFGIFIJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class GINALHEHBFK<TElement, TCollection> : global::JAAEJGPDNMF<TElement, TCollection> where TCollection : class, ICollection<TElement>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3F32A50", Offset = "0x3F31250", VA = "0x183F32A50", Slot = "7")]
	protected override TCollection DIFMOOHBFDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3F32970", Offset = "0x3F31170", VA = "0x183F32970", Slot = "8")]
	protected override void DEOBKNOOHMB(ref TCollection ACAOFABICDI, int EDBBKGCLEJF, TElement HKJMLEKHILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public sealed class CGLACCHCCPD<T> : global::FDNBCGNOFKL<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x23D2BE0", Offset = "0x23D13E0", VA = "0x1823D2BE0", Slot = "8")]
	protected override void DEOBKNOOHMB(ref LinkedList<T> ACAOFABICDI, int EDBBKGCLEJF, T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xF4D780", Offset = "0xF4BF80", VA = "0x180F4D780", Slot = "9")]
	protected override LinkedList<T> GINAAGHMPKK(ref LinkedList<T> FMKBFGIFIJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0xF4D720", Offset = "0xF4BF20", VA = "0x180F4D720", Slot = "7")]
	protected override LinkedList<T> DIFMOOHBFDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x23D2C20", Offset = "0x23D1420", VA = "0x1823D2C20", Slot = "6")]
	protected override LinkedList<T>.Enumerator JNBKMLHOAFA(LinkedList<T> MBEGPEONCCJ)
	{
		return default(LinkedList<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public sealed class LNCFPDPAGAD<T> : global::FDNBCGNOFKL<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x23D2BE0", Offset = "0x23D13E0", VA = "0x1823D2BE0", Slot = "8")]
	protected override void DEOBKNOOHMB(ref Queue<T> ACAOFABICDI, int EDBBKGCLEJF, T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0xF4D720", Offset = "0xF4BF20", VA = "0x180F4D720", Slot = "7")]
	protected override Queue<T> DIFMOOHBFDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C790", Offset = "0x2A3AF90", VA = "0x182A3C790", Slot = "6")]
	protected override Queue<T>.Enumerator JNBKMLHOAFA(Queue<T> MBEGPEONCCJ)
	{
		return default(Queue<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0xF4D780", Offset = "0xF4BF80", VA = "0x180F4D780", Slot = "9")]
	protected override Queue<T> GINAAGHMPKK(ref Queue<T> FMKBFGIFIJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class AFOMIFOKDMC<T> : global::FDNBCGNOFKL<T, global::ONEOHBJAPFA<T>, Stack<T>.Enumerator, Stack<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3642020", Offset = "0x3640820", VA = "0x183642020", Slot = "8")]
	protected override void DEOBKNOOHMB(ref global::ONEOHBJAPFA<T> ACAOFABICDI, int EDBBKGCLEJF, T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x383B4A0", Offset = "0x3839CA0", VA = "0x18383B4A0", Slot = "7")]
	protected override global::ONEOHBJAPFA<T> DIFMOOHBFDA()
	{
		return default(global::ONEOHBJAPFA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C790", Offset = "0x2A3AF90", VA = "0x182A3C790", Slot = "6")]
	protected override Stack<T>.Enumerator JNBKMLHOAFA(Stack<T> MBEGPEONCCJ)
	{
		return default(Stack<T>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x383B4F0", Offset = "0x3839CF0", VA = "0x18383B4F0", Slot = "9")]
	protected override Stack<T> GINAAGHMPKK(ref global::ONEOHBJAPFA<T> FMKBFGIFIJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public sealed class IDGJKLDDIGF<T> : global::FDNBCGNOFKL<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x23D2BE0", Offset = "0x23D13E0", VA = "0x1823D2BE0", Slot = "8")]
	protected override void DEOBKNOOHMB(ref HashSet<T> ACAOFABICDI, int EDBBKGCLEJF, T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xF4D780", Offset = "0xF4BF80", VA = "0x180F4D780", Slot = "9")]
	protected override HashSet<T> GINAAGHMPKK(ref HashSet<T> FMKBFGIFIJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0xF4D720", Offset = "0xF4BF20", VA = "0x180F4D720", Slot = "7")]
	protected override HashSet<T> DIFMOOHBFDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C790", Offset = "0x2A3AF90", VA = "0x182A3C790", Slot = "6")]
	protected override HashSet<T>.Enumerator JNBKMLHOAFA(HashSet<T> MBEGPEONCCJ)
	{
		return default(HashSet<T>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public sealed class FKMBLBHDKNO<T> : global::GMJLLEKFAJE<T, global::ONEOHBJAPFA<T>, ReadOnlyCollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3642020", Offset = "0x3640820", VA = "0x183642020", Slot = "8")]
	protected override void DEOBKNOOHMB(ref global::ONEOHBJAPFA<T> ACAOFABICDI, int EDBBKGCLEJF, T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x36420A0", Offset = "0x36408A0", VA = "0x1836420A0", Slot = "9")]
	protected override ReadOnlyCollection<T> GINAAGHMPKK(ref global::ONEOHBJAPFA<T> FMKBFGIFIJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3642050", Offset = "0x3640850", VA = "0x183642050", Slot = "7")]
	protected override global::ONEOHBJAPFA<T> DIFMOOHBFDA()
	{
		return default(global::ONEOHBJAPFA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public sealed class GFGJNNOJEAO<T> : global::GMJLLEKFAJE<T, List<T>, IList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x23D2BE0", Offset = "0x23D13E0", VA = "0x1823D2BE0", Slot = "8")]
	protected override void DEOBKNOOHMB(ref List<T> ACAOFABICDI, int EDBBKGCLEJF, T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0xF4D720", Offset = "0xF4BF20", VA = "0x180F4D720", Slot = "7")]
	protected override List<T> DIFMOOHBFDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xF4D780", Offset = "0xF4BF80", VA = "0x180F4D780", Slot = "9")]
	protected override IList<T> GINAAGHMPKK(ref List<T> FMKBFGIFIJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class MPEJGDDNECA<T> : global::GMJLLEKFAJE<T, List<T>, ICollection<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x23D2BE0", Offset = "0x23D13E0", VA = "0x1823D2BE0", Slot = "8")]
	protected override void DEOBKNOOHMB(ref List<T> ACAOFABICDI, int EDBBKGCLEJF, T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0xF4D720", Offset = "0xF4BF20", VA = "0x180F4D720", Slot = "7")]
	protected override List<T> DIFMOOHBFDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xF4D780", Offset = "0xF4BF80", VA = "0x180F4D780", Slot = "9")]
	protected override ICollection<T> GINAAGHMPKK(ref List<T> FMKBFGIFIJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class HDELDPIPEGN<T> : global::GMJLLEKFAJE<T, global::ONEOHBJAPFA<T>, IEnumerable<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x3642020", Offset = "0x3640820", VA = "0x183642020", Slot = "8")]
	protected override void DEOBKNOOHMB(ref global::ONEOHBJAPFA<T> ACAOFABICDI, int EDBBKGCLEJF, T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x383B4A0", Offset = "0x3839CA0", VA = "0x18383B4A0", Slot = "7")]
	protected override global::ONEOHBJAPFA<T> DIFMOOHBFDA()
	{
		return default(global::ONEOHBJAPFA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x43EA8A0", Offset = "0x43E90A0", VA = "0x1843EA8A0", Slot = "9")]
	protected override IEnumerable<T> GINAAGHMPKK(ref global::ONEOHBJAPFA<T> FMKBFGIFIJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public sealed class DAJJDGCBPIL<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public sealed class GIEKOCFAEEA<TKey, TElement>
{
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class LONBAIAINKF<T> where T : class, IList, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public sealed class HLLAJIADFDA : global::KAKKFHPFHDD<IEnumerable>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly global::KAKKFHPFHDD<IEnumerable> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x37ACA40", Offset = "0x37AB240", VA = "0x1837ACA40", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, IEnumerable HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x37AC850", Offset = "0x37AB050", VA = "0x1837AC850", Slot = "5")]
	public IEnumerable DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public HLLAJIADFDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public sealed class GPBEOOCPKPI : global::KAKKFHPFHDD<ICollection>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public static readonly global::KAKKFHPFHDD<ICollection> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x37A96A0", Offset = "0x37A7EA0", VA = "0x1837A96A0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, ICollection HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x37A94B0", Offset = "0x37A7CB0", VA = "0x1837A94B0", Slot = "5")]
	public ICollection DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public GPBEOOCPKPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class BJBKCBPNADB : global::KAKKFHPFHDD<IList>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public static readonly global::KAKKFHPFHDD<IList> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x3799470", Offset = "0x3797C70", VA = "0x183799470", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, IList HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x3799280", Offset = "0x3797A80", VA = "0x183799280", Slot = "5")]
	public IList DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public BJBKCBPNADB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public sealed class NPLIHEINADO<T> : global::GMJLLEKFAJE<T, global::ONEOHBJAPFA<T>, IReadOnlyList<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3F80920", Offset = "0x3F7F120", VA = "0x183F80920", Slot = "8")]
	protected override void DEOBKNOOHMB(ref global::ONEOHBJAPFA<T> ACAOFABICDI, int EDBBKGCLEJF, T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x383B4A0", Offset = "0x3839CA0", VA = "0x18383B4A0", Slot = "7")]
	protected override global::ONEOHBJAPFA<T> DIFMOOHBFDA()
	{
		return default(global::ONEOHBJAPFA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3F80950", Offset = "0x3F7F150", VA = "0x183F80950", Slot = "9")]
	protected override IReadOnlyList<T> GINAAGHMPKK(ref global::ONEOHBJAPFA<T> FMKBFGIFIJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x21899A0", Offset = "0x21881A0", VA = "0x1821899A0")]
	public NPLIHEINADO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class HAEDDNDCDKA
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x37A99A0", Offset = "0x37A81A0", VA = "0x1837A99A0")]
	public static DateTime KLEDBMMKKBH(DateTime OAINODLFCKM)
	{
		return default(DateTime);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public sealed class GJGAPDBOKIN : global::KAKKFHPFHDD<DateTime>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly global::KAKKFHPFHDD<DateTime> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x37A8C30", Offset = "0x37A7430", VA = "0x1837A8C30", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, DateTime HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x37A7CA0", Offset = "0x37A64A0", VA = "0x1837A7CA0", Slot = "5")]
	public DateTime DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public GJGAPDBOKIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public sealed class OMIJICLPLLB : global::KAKKFHPFHDD<DateTimeOffset>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public static readonly global::KAKKFHPFHDD<DateTimeOffset> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x4F53CF0", Offset = "0x4F524F0", VA = "0x184F53CF0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, DateTimeOffset HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x4F52D50", Offset = "0x4F51550", VA = "0x184F52D50", Slot = "5")]
	public DateTimeOffset DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(DateTimeOffset);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public OMIJICLPLLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public sealed class CFHNLDNINIM : global::KAKKFHPFHDD<TimeSpan>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly global::KAKKFHPFHDD<TimeSpan> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static byte[] EIJBAODGKHG;

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x379B840", Offset = "0x379A040", VA = "0x18379B840", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, TimeSpan HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x379AE40", Offset = "0x3799640", VA = "0x18379AE40", Slot = "5")]
	public TimeSpan DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public CFHNLDNINIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public abstract class OKHEHIAPFOH<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : global::KAKKFHPFHDD<TDictionary>, MAIGLFCCAEJ where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x28050C0", Offset = "0x28038C0", VA = "0x1828050C0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, TDictionary HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2802F30", Offset = "0x2801730", VA = "0x182802F30", Slot = "5")]
	public TDictionary DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TEnumerator JNBKMLHOAFA(TDictionary MBEGPEONCCJ);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract TIntermediate DIFMOOHBFDA();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void DEOBKNOOHMB(ref TIntermediate ACAOFABICDI, int EDBBKGCLEJF, TKey HJCJKDOGPGK, TValue HKJMLEKHILN);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract TDictionary GINAAGHMPKK(ref TIntermediate FMKBFGIFIJA);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
	protected OKHEHIAPFOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public abstract class EKBOGOGENHB<TKey, TValue, TIntermediate, TDictionary> : global::OKHEHIAPFOH<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary> where TDictionary : class, IEnumerable<KeyValuePair<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3197B70", Offset = "0x3196370", VA = "0x183197B70", Slot = "6")]
	protected override IEnumerator<KeyValuePair<TKey, TValue>> JNBKMLHOAFA(TDictionary MBEGPEONCCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class CFLIJJMCLHB<TKey, TValue, TDictionary> : global::EKBOGOGENHB<TKey, TValue, TDictionary, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>
{
	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xF4D780", Offset = "0xF4BF80", VA = "0x180F4D780", Slot = "9")]
	protected override TDictionary GINAAGHMPKK(ref TDictionary FMKBFGIFIJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public sealed class KOEBJOAPMMI<TKey, TValue> : global::OKHEHIAPFOH<TKey, TValue, Dictionary<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator, Dictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3865720", Offset = "0x3863F20", VA = "0x183865720", Slot = "8")]
	protected override void DEOBKNOOHMB(ref Dictionary<TKey, TValue> ACAOFABICDI, int EDBBKGCLEJF, TKey HJCJKDOGPGK, TValue HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xF4D780", Offset = "0xF4BF80", VA = "0x180F4D780", Slot = "9")]
	protected override Dictionary<TKey, TValue> GINAAGHMPKK(ref Dictionary<TKey, TValue> FMKBFGIFIJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0xF4D720", Offset = "0xF4BF20", VA = "0x180F4D720", Slot = "7")]
	protected override Dictionary<TKey, TValue> DIFMOOHBFDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x3865760", Offset = "0x3863F60", VA = "0x183865760", Slot = "6")]
	protected override Dictionary<TKey, TValue>.Enumerator JNBKMLHOAFA(Dictionary<TKey, TValue> MBEGPEONCCJ)
	{
		return default(Dictionary<TKey, TValue>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2313730", Offset = "0x2311F30", VA = "0x182313730")]
	public KOEBJOAPMMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class CMOJNJLLOFO<TKey, TValue, TDictionary> : global::CFLIJJMCLHB<TKey, TValue, TDictionary> where TDictionary : class, IDictionary<TKey, TValue>, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x32D8020", Offset = "0x32D6820", VA = "0x1832D8020", Slot = "8")]
	protected override void DEOBKNOOHMB(ref TDictionary ACAOFABICDI, int EDBBKGCLEJF, TKey HJCJKDOGPGK, TValue HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x2D7EAC0", Offset = "0x2D7D2C0", VA = "0x182D7EAC0", Slot = "7")]
	protected override TDictionary DIFMOOHBFDA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class EILAHKEFCKA<TKey, TValue> : global::EKBOGOGENHB<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0xF4D6E0", Offset = "0xF4BEE0", VA = "0x180F4D6E0", Slot = "8")]
	protected override void DEOBKNOOHMB(ref Dictionary<TKey, TValue> ACAOFABICDI, int EDBBKGCLEJF, TKey HJCJKDOGPGK, TValue HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0xF4D720", Offset = "0xF4BF20", VA = "0x180F4D720", Slot = "7")]
	protected override Dictionary<TKey, TValue> DIFMOOHBFDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0xF4D780", Offset = "0xF4BF80", VA = "0x180F4D780", Slot = "9")]
	protected override IDictionary<TKey, TValue> GINAAGHMPKK(ref Dictionary<TKey, TValue> FMKBFGIFIJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public sealed class FJGGIMLLFOH<TKey, TValue> : global::CFLIJJMCLHB<TKey, TValue, SortedList<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0xF4D6E0", Offset = "0xF4BEE0", VA = "0x180F4D6E0", Slot = "8")]
	protected override void DEOBKNOOHMB(ref SortedList<TKey, TValue> ACAOFABICDI, int EDBBKGCLEJF, TKey HJCJKDOGPGK, TValue HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0xF4D720", Offset = "0xF4BF20", VA = "0x180F4D720", Slot = "7")]
	protected override SortedList<TKey, TValue> DIFMOOHBFDA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public sealed class BEMAKGHJBIN<TKey, TValue> : global::OKHEHIAPFOH<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
{
	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0xF4D6E0", Offset = "0xF4BEE0", VA = "0x180F4D6E0", Slot = "8")]
	protected override void DEOBKNOOHMB(ref SortedDictionary<TKey, TValue> ACAOFABICDI, int EDBBKGCLEJF, TKey HJCJKDOGPGK, TValue HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xF4D780", Offset = "0xF4BF80", VA = "0x180F4D780", Slot = "9")]
	protected override SortedDictionary<TKey, TValue> GINAAGHMPKK(ref SortedDictionary<TKey, TValue> FMKBFGIFIJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0xF4D720", Offset = "0xF4BF20", VA = "0x180F4D720", Slot = "7")]
	protected override SortedDictionary<TKey, TValue> DIFMOOHBFDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0xF4D790", Offset = "0xF4BF90", VA = "0x180F4D790", Slot = "6")]
	protected override SortedDictionary<TKey, TValue>.Enumerator JNBKMLHOAFA(SortedDictionary<TKey, TValue> MBEGPEONCCJ)
	{
		return default(SortedDictionary<TKey, TValue>.Enumerator);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class DFMPEFCFECM<T> where T : class, IDictionary, new()
{
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public sealed class HFEMNELLNJI : global::KAKKFHPFHDD<IDictionary>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly global::KAKKFHPFHDD<IDictionary> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x37ABCB0", Offset = "0x37AA4B0", VA = "0x1837ABCB0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, IDictionary HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x37AB990", Offset = "0x37AA190", VA = "0x1837AB990", Slot = "5")]
	public IDictionary DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public HFEMNELLNJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public sealed class KOFOJKNOMBC : global::KAKKFHPFHDD<object>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private delegate void GOBOKJODPLL(object GAINFLKOACP, ref KKHNLIPNMHK PJJBCJIGKFL, object HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly global::FHAOIIHIFOM<KeyValuePair<object, GOBOKJODPLL>> HHPJLDOPPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly PCBNCCNNPBE[] DOCCFKFJPHC;

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2B801F0", Offset = "0x2B7E9F0", VA = "0x182B801F0")]
	public KOFOJKNOMBC(params PCBNCCNNPBE[] DOCCFKFJPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F8A0", Offset = "0x2B7E0A0", VA = "0x182B7F8A0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, object HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F810", Offset = "0x2B7E010", VA = "0x182B7F810", Slot = "5")]
	public object DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public static class NNIDEAAFGBN
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2B8BD90", Offset = "0x2B8A590", VA = "0x182B8BD90")]
	public static object EHGAIKKFOOI(Type LIBGCFIILKM, out bool LPCGFNHOIHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2B8C570", Offset = "0x2B8AD70", VA = "0x182B8C570")]
	public static object GKLNNMBHBKB(Type LIBGCFIILKM, out bool LPCGFNHOIHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class FPNGNAAPFHI<T> : global::KAKKFHPFHDD<T>, MAIGLFCCAEJ, global::MLEINHMADLI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class GILDDPNACGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public Func<FieldInfo, bool> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public GILDDPNACGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x364C910", Offset = "0x364B110", VA = "0x18364C910")]
		internal bool <.cctor>b__0(FieldInfo fi)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class PKBIMCKACAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public global::PIJOLNNEIFE<object> boxSerialize;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public PKBIMCKACAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3654D80", Offset = "0x3653580", VA = "0x183654D80")]
		internal void <.cctor>b__1(ref KKHNLIPNMHK writer, T value, PCBNCCNNPBE _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private sealed class JCPFJIGLLBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public global::GGBGKFKCALO<object> boxDeserialize;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		public JCPFJIGLLBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x364D820", Offset = "0x364C020", VA = "0x18364D820")]
		internal T <.cctor>b__2(ref FGKANONAPNL reader, PCBNCCNNPBE _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static readonly global::ANFKIEOEKIN<T> EINCFIOPOFN;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private static readonly Dictionary<T, string> KOLCHDHKIKB;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private static readonly global::PIJOLNNEIFE<T> PAHANLKICOC;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly global::GGBGKFKCALO<T> IHPLMHKMMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private readonly bool JJEAEIKKCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private readonly global::PIJOLNNEIFE<T> MKCJONGBOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly global::GGBGKFKCALO<T> OBPMNLIEHIK;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3648840", Offset = "0x3647040", VA = "0x183648840")]
	static FPNGNAAPFHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x364C240", Offset = "0x364AA40", VA = "0x18364C240")]
	public FPNGNAAPFHI(bool JJEAEIKKCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x3646CE0", Offset = "0x36454E0", VA = "0x183646CE0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, T HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x3645C90", Offset = "0x3644490", VA = "0x183645C90", Slot = "5")]
	public T DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x3646A80", Offset = "0x3645280", VA = "0x183646A80", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, T HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x3647500", Offset = "0x3645D00", VA = "0x183647500", Slot = "7")]
	public T IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public sealed class IEKJHEKBLAB<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public sealed class NCJDHDNODMB<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public sealed class IJIHIBODFJP<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public sealed class NKKDIDGIBLA<T> : global::KAKKFHPFHDD<T?>, MAIGLFCCAEJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2EFEB40", Offset = "0x2EFD340", VA = "0x182EFEB40", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, T? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2EFE710", Offset = "0x2EFCF10", VA = "0x182EFE710", Slot = "5")]
	public T? DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
	public NKKDIDGIBLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public sealed class KIJGHFCANED<T> : global::KAKKFHPFHDD<T?>, MAIGLFCCAEJ where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private readonly global::KAKKFHPFHDD<T> LNMNBCOLCJH;

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2806BE0", Offset = "0x28053E0", VA = "0x182806BE0")]
	public KIJGHFCANED(global::KAKKFHPFHDD<T> LNMNBCOLCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x34FDE20", Offset = "0x34FC620", VA = "0x1834FDE20", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, T? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x34FD1C0", Offset = "0x34FB9C0", VA = "0x1834FD1C0", Slot = "5")]
	public T? DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public sealed class BPGOMCPAMFC : global::KAKKFHPFHDD<sbyte>, MAIGLFCCAEJ, global::MLEINHMADLI<sbyte>
{
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public static readonly BPGOMCPAMFC GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x379A660", Offset = "0x3798E60", VA = "0x18379A660", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, sbyte HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x379A5D0", Offset = "0x3798DD0", VA = "0x18379A5D0", Slot = "5")]
	public sbyte DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x379A620", Offset = "0x3798E20", VA = "0x18379A620", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, sbyte HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x379A680", Offset = "0x3798E80", VA = "0x18379A680", Slot = "7")]
	public sbyte IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public BPGOMCPAMFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public sealed class FGPBCJOPHAB : global::KAKKFHPFHDD<sbyte?>, MAIGLFCCAEJ, global::MLEINHMADLI<sbyte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public static readonly FGPBCJOPHAB GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x37A5C50", Offset = "0x37A4450", VA = "0x1837A5C50", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, sbyte? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x37A5B20", Offset = "0x37A4320", VA = "0x1837A5B20", Slot = "5")]
	public sbyte? DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x37A5BD0", Offset = "0x37A43D0", VA = "0x1837A5BD0", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, sbyte? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x37A5CC0", Offset = "0x37A44C0", VA = "0x1837A5CC0", Slot = "7")]
	public sbyte? IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public FGPBCJOPHAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public sealed class HMHEKBGJKAF : global::KAKKFHPFHDD<sbyte[]>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public static readonly HMHEKBGJKAF GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x2B78410", Offset = "0x2B76C10", VA = "0x182B78410", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, sbyte[] HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x2B782D0", Offset = "0x2B76AD0", VA = "0x182B782D0", Slot = "5")]
	public sbyte[] DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public HMHEKBGJKAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public sealed class MBPPFCHCHML : global::KAKKFHPFHDD<short>, MAIGLFCCAEJ, global::MLEINHMADLI<short>
{
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public static readonly MBPPFCHCHML GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2B82B60", Offset = "0x2B81360", VA = "0x182B82B60", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, short HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x2B82A90", Offset = "0x2B81290", VA = "0x182B82A90", Slot = "5")]
	public short DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x2B82AA0", Offset = "0x2B812A0", VA = "0x182B82AA0", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, short HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2B82BA0", Offset = "0x2B813A0", VA = "0x182B82BA0", Slot = "7")]
	public short IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public MBPPFCHCHML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public sealed class DGLEBIFDPAJ : global::KAKKFHPFHDD<short?>, MAIGLFCCAEJ, global::MLEINHMADLI<short?>
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public static readonly DGLEBIFDPAJ GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x379E1A0", Offset = "0x379C9A0", VA = "0x18379E1A0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, short? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x379E070", Offset = "0x379C870", VA = "0x18379E070", Slot = "5")]
	public short? DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x379E120", Offset = "0x379C920", VA = "0x18379E120", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, short? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x379E210", Offset = "0x379CA10", VA = "0x18379E210", Slot = "7")]
	public short? IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public DGLEBIFDPAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public sealed class IPBHIPIFLOI : global::KAKKFHPFHDD<short[]>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public static readonly IPBHIPIFLOI GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x2B79BE0", Offset = "0x2B783E0", VA = "0x182B79BE0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, short[] HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x2B79AA0", Offset = "0x2B782A0", VA = "0x182B79AA0", Slot = "5")]
	public short[] DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public IPBHIPIFLOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public sealed class NECFNBJKMKJ : global::KAKKFHPFHDD<int>, MAIGLFCCAEJ, global::MLEINHMADLI<int>
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public static readonly NECFNBJKMKJ GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2B88A60", Offset = "0x2B87260", VA = "0x182B88A60", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, int HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2B88990", Offset = "0x2B87190", VA = "0x182B88990", Slot = "5")]
	public int DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B889A0", Offset = "0x2B871A0", VA = "0x182B889A0", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, int HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2B88A90", Offset = "0x2B87290", VA = "0x182B88A90", Slot = "7")]
	public int IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public NECFNBJKMKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class FLKEKJLDOLG : global::KAKKFHPFHDD<int?>, MAIGLFCCAEJ, global::MLEINHMADLI<int?>
{
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly FLKEKJLDOLG GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x37A5F00", Offset = "0x37A4700", VA = "0x1837A5F00", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, int? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x37A5DD0", Offset = "0x37A45D0", VA = "0x1837A5DD0", Slot = "5")]
	public int? DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x37A5E80", Offset = "0x37A4680", VA = "0x1837A5E80", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, int? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x37A5F70", Offset = "0x37A4770", VA = "0x1837A5F70", Slot = "7")]
	public int? IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public FLKEKJLDOLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public sealed class MMINHHIHJJL : global::KAKKFHPFHDD<int[]>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public static readonly MMINHHIHJJL GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2B86840", Offset = "0x2B85040", VA = "0x182B86840", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, int[] HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2B86700", Offset = "0x2B84F00", VA = "0x182B86700", Slot = "5")]
	public int[] DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public MMINHHIHJJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public sealed class MLEPLLIFMLG : global::KAKKFHPFHDD<long>, MAIGLFCCAEJ, global::MLEINHMADLI<long>
{
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public static readonly MLEPLLIFMLG GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2B84E80", Offset = "0x2B83680", VA = "0x182B84E80", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, long HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2B84DB0", Offset = "0x2B835B0", VA = "0x182B84DB0", Slot = "5")]
	public long DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2B84DC0", Offset = "0x2B835C0", VA = "0x182B84DC0", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, long HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x2B84EB0", Offset = "0x2B836B0", VA = "0x182B84EB0", Slot = "7")]
	public long IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public MLEPLLIFMLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public sealed class PENAMAHHGIF : global::KAKKFHPFHDD<long?>, MAIGLFCCAEJ, global::MLEINHMADLI<long?>
{
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public static readonly PENAMAHHGIF GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F54660", Offset = "0x4F52E60", VA = "0x184F54660", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, long? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x4F54550", Offset = "0x4F52D50", VA = "0x184F54550", Slot = "5")]
	public long? DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F545E0", Offset = "0x4F52DE0", VA = "0x184F545E0", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, long? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x4F546D0", Offset = "0x4F52ED0", VA = "0x184F546D0", Slot = "7")]
	public long? IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public PENAMAHHGIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public sealed class LAHEBANHGFA : global::KAKKFHPFHDD<long[]>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public static readonly LAHEBANHGFA GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2B803D0", Offset = "0x2B7EBD0", VA = "0x182B803D0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, long[] HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2B80290", Offset = "0x2B7EA90", VA = "0x182B80290", Slot = "5")]
	public long[] DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public LAHEBANHGFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public sealed class PANIMLMANFE : global::KAKKFHPFHDD<byte>, MAIGLFCCAEJ, global::MLEINHMADLI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public static readonly PANIMLMANFE GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x4F54320", Offset = "0x4F52B20", VA = "0x184F54320", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, byte HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x4F542D0", Offset = "0x4F52AD0", VA = "0x184F542D0", Slot = "5")]
	public byte DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x4F542E0", Offset = "0x4F52AE0", VA = "0x184F542E0", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, byte HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x4F54340", Offset = "0x4F52B40", VA = "0x184F54340", Slot = "7")]
	public byte IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public PANIMLMANFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class DFADADFCDCE : global::KAKKFHPFHDD<byte?>, MAIGLFCCAEJ, global::MLEINHMADLI<byte?>
{
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public static readonly DFADADFCDCE GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x379DAE0", Offset = "0x379C2E0", VA = "0x18379DAE0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, byte? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x379D9B0", Offset = "0x379C1B0", VA = "0x18379D9B0", Slot = "5")]
	public byte? DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x379DA60", Offset = "0x379C260", VA = "0x18379DA60", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, byte? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x379DB50", Offset = "0x379C350", VA = "0x18379DB50", Slot = "7")]
	public byte? IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public DFADADFCDCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public sealed class EOKPNLJHKLG : global::KAKKFHPFHDD<ushort>, MAIGLFCCAEJ, global::MLEINHMADLI<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public static readonly EOKPNLJHKLG GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x37A1B40", Offset = "0x37A0340", VA = "0x1837A1B40", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, ushort HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x37A1AA0", Offset = "0x37A02A0", VA = "0x1837A1AA0", Slot = "5")]
	public ushort DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x37A1B00", Offset = "0x37A0300", VA = "0x1837A1B00", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, ushort HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x37A1B60", Offset = "0x37A0360", VA = "0x1837A1B60", Slot = "7")]
	public ushort IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public EOKPNLJHKLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public sealed class GJFIPGNCMGG : global::KAKKFHPFHDD<ushort?>, MAIGLFCCAEJ, global::MLEINHMADLI<ushort?>
{
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public static readonly GJFIPGNCMGG GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x37A7B30", Offset = "0x37A6330", VA = "0x1837A7B30", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, ushort? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x37A7A00", Offset = "0x37A6200", VA = "0x1837A7A00", Slot = "5")]
	public ushort? DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x37A7AB0", Offset = "0x37A62B0", VA = "0x1837A7AB0", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, ushort? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x37A7BA0", Offset = "0x37A63A0", VA = "0x1837A7BA0", Slot = "7")]
	public ushort? IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public GJFIPGNCMGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public sealed class LGEHGIAEOAD : global::KAKKFHPFHDD<ushort[]>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public static readonly LGEHGIAEOAD GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2B80950", Offset = "0x2B7F150", VA = "0x182B80950", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, ushort[] HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2B80810", Offset = "0x2B7F010", VA = "0x182B80810", Slot = "5")]
	public ushort[] DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public LGEHGIAEOAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public sealed class KFNMPIBLBIG : global::KAKKFHPFHDD<uint>, MAIGLFCCAEJ, global::MLEINHMADLI<uint>
{
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public static readonly KFNMPIBLBIG GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DA50", Offset = "0x2B7C250", VA = "0x182B7DA50", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, uint HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D980", Offset = "0x2B7C180", VA = "0x182B7D980", Slot = "5")]
	public uint DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D990", Offset = "0x2B7C190", VA = "0x182B7D990", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, uint HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DA80", Offset = "0x2B7C280", VA = "0x182B7DA80", Slot = "7")]
	public uint IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public KFNMPIBLBIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public sealed class JHEJFGMCKGH : global::KAKKFHPFHDD<uint?>, MAIGLFCCAEJ, global::MLEINHMADLI<uint?>
{
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	public static readonly JHEJFGMCKGH GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2B7C8F0", Offset = "0x2B7B0F0", VA = "0x182B7C8F0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, uint? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2B7C780", Offset = "0x2B7AF80", VA = "0x182B7C780", Slot = "5")]
	public uint? DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x2B7C7F0", Offset = "0x2B7AFF0", VA = "0x182B7C7F0", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, uint? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2B7C970", Offset = "0x2B7B170", VA = "0x182B7C970", Slot = "7")]
	public uint? IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public JHEJFGMCKGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public sealed class DDLMLKJKCLI : global::KAKKFHPFHDD<uint[]>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public static readonly DDLMLKJKCLI GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x379D890", Offset = "0x379C090", VA = "0x18379D890", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, uint[] HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x379D6F0", Offset = "0x379BEF0", VA = "0x18379D6F0", Slot = "5")]
	public uint[] DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public DDLMLKJKCLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public sealed class HIALEEDLJAO : global::KAKKFHPFHDD<ulong>, MAIGLFCCAEJ, global::MLEINHMADLI<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public static readonly HIALEEDLJAO GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x37AC650", Offset = "0x37AAE50", VA = "0x1837AC650", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, ulong HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x37AC600", Offset = "0x37AAE00", VA = "0x1837AC600", Slot = "5")]
	public ulong DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x37AC610", Offset = "0x37AAE10", VA = "0x1837AC610", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, ulong HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x37AC670", Offset = "0x37AAE70", VA = "0x1837AC670", Slot = "7")]
	public ulong IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public HIALEEDLJAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public sealed class LONGKHKKBCL : global::KAKKFHPFHDD<ulong?>, MAIGLFCCAEJ, global::MLEINHMADLI<ulong?>
{
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public static readonly LONGKHKKBCL GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2B827B0", Offset = "0x2B80FB0", VA = "0x182B827B0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, ulong? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2B82620", Offset = "0x2B80E20", VA = "0x182B82620", Slot = "5")]
	public ulong? DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x2B826B0", Offset = "0x2B80EB0", VA = "0x182B826B0", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, ulong? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2B82830", Offset = "0x2B81030", VA = "0x182B82830", Slot = "7")]
	public ulong? IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public LONGKHKKBCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public sealed class EPGEOKODHLI : global::KAKKFHPFHDD<ulong[]>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public static readonly EPGEOKODHLI GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x37A1DD0", Offset = "0x37A05D0", VA = "0x1837A1DD0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, ulong[] HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x37A1C30", Offset = "0x37A0430", VA = "0x1837A1C30", Slot = "5")]
	public ulong[] DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public EPGEOKODHLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public sealed class HCOOFPBHNHE : global::KAKKFHPFHDD<float>, MAIGLFCCAEJ, global::MLEINHMADLI<float>
{
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public static readonly HCOOFPBHNHE GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x37A9BD0", Offset = "0x37A83D0", VA = "0x1837A9BD0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, float HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x37A9B80", Offset = "0x37A8380", VA = "0x1837A9B80", Slot = "5")]
	public float DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x37A9B90", Offset = "0x37A8390", VA = "0x1837A9B90", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, float HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x37A9BE0", Offset = "0x37A83E0", VA = "0x1837A9BE0", Slot = "7")]
	public float IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public HCOOFPBHNHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public sealed class FMGFDCECJML : global::KAKKFHPFHDD<float?>, MAIGLFCCAEJ, global::MLEINHMADLI<float?>
{
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public static readonly FMGFDCECJML GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x37A7370", Offset = "0x37A5B70", VA = "0x1837A7370", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, float? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x37A7280", Offset = "0x37A5A80", VA = "0x1837A7280", Slot = "5")]
	public float? DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x37A72F0", Offset = "0x37A5AF0", VA = "0x1837A72F0", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, float? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x37A73E0", Offset = "0x37A5BE0", VA = "0x1837A73E0", Slot = "7")]
	public float? IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public FMGFDCECJML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public sealed class PPPMKMCCKKI : global::KAKKFHPFHDD<float[]>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public static readonly PPPMKMCCKKI GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x4F55360", Offset = "0x4F53B60", VA = "0x184F55360", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, float[] HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x4F55220", Offset = "0x4F53A20", VA = "0x184F55220", Slot = "5")]
	public float[] DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public PPPMKMCCKKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public sealed class POOMPJMGNMG : global::KAKKFHPFHDD<double>, MAIGLFCCAEJ, global::MLEINHMADLI<double>
{
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public static readonly POOMPJMGNMG GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x4F55140", Offset = "0x4F53940", VA = "0x184F55140", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, double HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x4F550F0", Offset = "0x4F538F0", VA = "0x184F550F0", Slot = "5")]
	public double DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x4F55100", Offset = "0x4F53900", VA = "0x184F55100", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, double HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x4F55150", Offset = "0x4F53950", VA = "0x184F55150", Slot = "7")]
	public double IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public POOMPJMGNMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public sealed class BHCAFOEMJNA : global::KAKKFHPFHDD<double?>, MAIGLFCCAEJ, global::MLEINHMADLI<double?>
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	public static readonly BHCAFOEMJNA GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x3799090", Offset = "0x3797890", VA = "0x183799090", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, double? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x3798F80", Offset = "0x3797780", VA = "0x183798F80", Slot = "5")]
	public double? DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x3799010", Offset = "0x3797810", VA = "0x183799010", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, double? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x3799100", Offset = "0x3797900", VA = "0x183799100", Slot = "7")]
	public double? IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public BHCAFOEMJNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public sealed class PJMEBCOFGBC : global::KAKKFHPFHDD<double[]>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public static readonly PJMEBCOFGBC GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x4F54E30", Offset = "0x4F53630", VA = "0x184F54E30", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, double[] HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x4F54CF0", Offset = "0x4F534F0", VA = "0x184F54CF0", Slot = "5")]
	public double[] DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public PJMEBCOFGBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public sealed class PLIAICDNJHA : global::KAKKFHPFHDD<bool>, MAIGLFCCAEJ, global::MLEINHMADLI<bool>
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public static readonly PLIAICDNJHA GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x4F54FA0", Offset = "0x4F537A0", VA = "0x184F54FA0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, bool HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x4F54F50", Offset = "0x4F53750", VA = "0x184F54F50", Slot = "5")]
	public bool DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x4F54F60", Offset = "0x4F53760", VA = "0x184F54F60", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, bool HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x4F54FC0", Offset = "0x4F537C0", VA = "0x184F54FC0", Slot = "7")]
	public bool IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public PLIAICDNJHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public sealed class BBOOLHLBBFM : global::KAKKFHPFHDD<bool?>, MAIGLFCCAEJ, global::MLEINHMADLI<bool?>
{
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public static readonly BBOOLHLBBFM GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x37988E0", Offset = "0x37970E0", VA = "0x1837988E0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, bool? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x37987F0", Offset = "0x3796FF0", VA = "0x1837987F0", Slot = "5")]
	public bool? DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x3798860", Offset = "0x3797060", VA = "0x183798860", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, bool? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x3798950", Offset = "0x3797150", VA = "0x183798950", Slot = "7")]
	public bool? IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public BBOOLHLBBFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public sealed class DFECGJDPDOI : global::KAKKFHPFHDD<bool[]>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public static readonly DFECGJDPDOI GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x379DE00", Offset = "0x379C600", VA = "0x18379DE00", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, bool[] HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x379DC60", Offset = "0x379C460", VA = "0x18379DC60", Slot = "5")]
	public bool[] DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public DFECGJDPDOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public sealed class NBJJIGELNEN : global::KAKKFHPFHDD<object>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly global::KAKKFHPFHDD<object> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly Dictionary<Type, int> AGNLBFEMHGH;

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2B874B0", Offset = "0x2B85CB0", VA = "0x182B874B0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, object HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2B87210", Offset = "0x2B85A10", VA = "0x182B87210", Slot = "5")]
	public object DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public NBJJIGELNEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public sealed class MMDNBNHCDMD : global::KAKKFHPFHDD<byte[]>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly global::KAKKFHPFHDD<byte[]> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2B86610", Offset = "0x2B84E10", VA = "0x182B86610", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, byte[] HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2B86590", Offset = "0x2B84D90", VA = "0x182B86590", Slot = "5")]
	public byte[] DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public MMDNBNHCDMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public sealed class ODBDIABKFIP : global::KAKKFHPFHDD<ArraySegment<byte>>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly global::KAKKFHPFHDD<ArraySegment<byte>> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x4F511E0", Offset = "0x4F4F9E0", VA = "0x184F511E0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, ArraySegment<byte> HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x4F51110", Offset = "0x4F4F910", VA = "0x184F51110", Slot = "5")]
	public ArraySegment<byte> DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public ODBDIABKFIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public sealed class IJNBAIKACKF : global::KAKKFHPFHDD<string>, MAIGLFCCAEJ, global::MLEINHMADLI<string>
{
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly global::KAKKFHPFHDD<string> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2B79740", Offset = "0x2B77F40", VA = "0x182B79740", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, string HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2B79730", Offset = "0x2B77F30", VA = "0x182B79730", Slot = "5")]
	public string DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2B79740", Offset = "0x2B77F40", VA = "0x182B79740", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, string HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2B79730", Offset = "0x2B77F30", VA = "0x182B79730", Slot = "7")]
	public string IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public IJNBAIKACKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public sealed class ODDFPPALKHO : global::KAKKFHPFHDD<string[]>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly ODDFPPALKHO GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x4F51420", Offset = "0x4F4FC20", VA = "0x184F51420", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, string[] HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x4F512E0", Offset = "0x4F4FAE0", VA = "0x184F512E0", Slot = "5")]
	public string[] DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public ODDFPPALKHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public sealed class BONLMONILKB : global::KAKKFHPFHDD<char>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly BONLMONILKB GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x379A4F0", Offset = "0x3798CF0", VA = "0x18379A4F0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, char HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x379A4C0", Offset = "0x3798CC0", VA = "0x18379A4C0", Slot = "5")]
	public char DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public BONLMONILKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public sealed class OIGLKNCCCGJ : global::KAKKFHPFHDD<char?>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly OIGLKNCCCGJ GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x4F52870", Offset = "0x4F51070", VA = "0x184F52870", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, char? HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x4F527B0", Offset = "0x4F50FB0", VA = "0x184F527B0", Slot = "5")]
	public char? DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public OIGLKNCCCGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public sealed class HFPBJDFKINA : global::KAKKFHPFHDD<char[]>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly HFPBJDFKINA GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x37AC280", Offset = "0x37AAA80", VA = "0x1837AC280", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, char[] HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x37AC090", Offset = "0x37AA890", VA = "0x1837AC090", Slot = "5")]
	public char[] DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public HFPBJDFKINA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public sealed class HGIEHNDONAJ : global::KAKKFHPFHDD<Guid>, MAIGLFCCAEJ, global::MLEINHMADLI<Guid>
{
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly global::KAKKFHPFHDD<Guid> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x37AC4B0", Offset = "0x37AACB0", VA = "0x1837AC4B0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, Guid HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x37AC460", Offset = "0x37AAC60", VA = "0x1837AC460", Slot = "5")]
	public Guid DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x37AC4B0", Offset = "0x37AACB0", VA = "0x1837AC4B0", Slot = "6")]
	public void IHIJCOMKCHM(ref KKHNLIPNMHK PJJBCJIGKFL, Guid HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x37AC550", Offset = "0x37AAD50", VA = "0x1837AC550", Slot = "7")]
	public Guid IJMHJBMKBLN(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public HGIEHNDONAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public sealed class IIHOHIEDKFF : global::KAKKFHPFHDD<decimal>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly global::KAKKFHPFHDD<decimal> GJCBCFPBGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly bool GDLGHNLLPKD;

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xD9C8A0", Offset = "0xD9B0A0", VA = "0x180D9C8A0")]
	public IIHOHIEDKFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x9F5460", Offset = "0x9F3C60", VA = "0x1809F5460")]
	public IIHOHIEDKFF(bool GDLGHNLLPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x2B791D0", Offset = "0x2B779D0", VA = "0x182B791D0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, decimal HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x2B79020", Offset = "0x2B77820", VA = "0x182B79020", Slot = "5")]
	public decimal DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return default(decimal);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public sealed class CAIPBOBMNMN : global::KAKKFHPFHDD<Uri>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly global::KAKKFHPFHDD<Uri> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x379AAE0", Offset = "0x37992E0", VA = "0x18379AAE0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, Uri HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x379AA60", Offset = "0x3799260", VA = "0x18379AA60", Slot = "5")]
	public Uri DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public CAIPBOBMNMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public sealed class FPGHEGLBKEL : global::KAKKFHPFHDD<Version>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly global::KAKKFHPFHDD<Version> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x37A7560", Offset = "0x37A5D60", VA = "0x1837A7560", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, Version HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x37A74E0", Offset = "0x37A5CE0", VA = "0x1837A74E0", Slot = "5")]
	public Version DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public FPGHEGLBKEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public sealed class BJPDHJFMDGN<TKey, TValue>
{
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public sealed class CAENHMNALGP : global::KAKKFHPFHDD<StringBuilder>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public static readonly global::KAKKFHPFHDD<StringBuilder> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x379A9B0", Offset = "0x37991B0", VA = "0x18379A9B0", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, StringBuilder HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x379A930", Offset = "0x3799130", VA = "0x18379A930", Slot = "5")]
	public StringBuilder DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public CAENHMNALGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public sealed class CBMHIGAKLEJ : global::KAKKFHPFHDD<BitArray>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public static readonly global::KAKKFHPFHDD<BitArray> GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x379AD50", Offset = "0x3799550", VA = "0x18379AD50", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, BitArray HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x379ABF0", Offset = "0x37993F0", VA = "0x18379ABF0", Slot = "5")]
	public BitArray DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public CBMHIGAKLEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public sealed class PFBAJPFBEHF : global::KAKKFHPFHDD<Type>, MAIGLFCCAEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public static readonly PFBAJPFBEHF GJCBCFPBGOE;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly Regex GLBNOLFPEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private bool AMDKMCFDDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool BMNLJMLDIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private bool CHIDJNCEANJ;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x4F54AF0", Offset = "0x4F532F0", VA = "0x184F54AF0")]
	public PFBAJPFBEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x4F54AA0", Offset = "0x4F532A0", VA = "0x184F54AA0")]
	public PFBAJPFBEHF(bool AMDKMCFDDOF, bool BMNLJMLDIIK, bool CHIDJNCEANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x4F54910", Offset = "0x4F53110", VA = "0x184F54910", Slot = "4")]
	public void IICNIKFAIFP(ref KKHNLIPNMHK PJJBCJIGKFL, Type HKJMLEKHILN, PCBNCCNNPBE ICPNLLNNKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x4F547F0", Offset = "0x4F52FF0", VA = "0x184F547F0", Slot = "5")]
	public Type DMAKMKNNBAJ(ref FGKANONAPNL FNJMAPENAJC, PCBNCCNNPBE ICPNLLNNKEA)
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
