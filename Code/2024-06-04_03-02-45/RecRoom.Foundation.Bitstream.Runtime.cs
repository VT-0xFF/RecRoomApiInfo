using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Foundation_Bitstream_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : IFEEDCBNDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x684BD50", Offset = "0x684A550", VA = "0x18684BD50", Slot = "4")]
		public override void MPPLGFJBDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MMJLCDBBDEC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNAIEAEAFJH(LAOEOOKOBMH COHNONCDMOG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKPMANIAHDL(CNEIDIOGAGH PJOJHFLPHKO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void AKLCCDJJDAO<T>(LAOEOOKOBMH COHNONCDMOG, T IPHHABIKCHD) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate T OMMBCIBCGGC<T>(CNEIDIOGAGH PJOJHFLPHKO) where T : struct;
[Cpp2IlInjected.Token(Token = "0x2000006")]
public ref struct CNEIDIOGAGH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate CNEIDIOGAGH DDLGCMEIGKK(CNEIDIOGAGH MPOPMIPMGJI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal readonly ReadOnlySpan<byte> MLKNGAFFKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly DDLGCMEIGKK AOBOPNKOKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal int KLJLENFIEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal int MGPDEBBFEAM;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6848C30", Offset = "0x6847430", VA = "0x186848C30")]
	public CNEIDIOGAGH(ReadOnlySpan<byte> MLKNGAFFKGE, int KLJLENFIEBG = 0, int MGPDEBBFEAM = 0, [Optional] DDLGCMEIGKK AOBOPNKOKFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IHHAKIDIDNG
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA940", Offset = "0x2AC9140", VA = "0x182ACA940")]
	public static T FJPNMKBHKGN<T>(this CNEIDIOGAGH PJOJHFLPHKO) where T : struct, MMJLCDBBDEC
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x684B6C0", Offset = "0x6849EC0", VA = "0x18684B6C0")]
	public static bool HJGLEDKCFML(this CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x684BAA0", Offset = "0x684A2A0", VA = "0x18684BAA0")]
	public static byte NJOAOFMNBJI(this CNEIDIOGAGH MPOPMIPMGJI, byte DLNLLKPAOKI, byte JLGMKEEOCNL)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x684BB40", Offset = "0x684A340", VA = "0x18684BB40")]
	public static sbyte PMPBEHANPBP(this CNEIDIOGAGH MPOPMIPMGJI, sbyte DLNLLKPAOKI, sbyte JLGMKEEOCNL)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x684B8C0", Offset = "0x684A0C0", VA = "0x18684B8C0")]
	public static ushort JJAFKNBMMLC(this CNEIDIOGAGH MPOPMIPMGJI, ushort DLNLLKPAOKI, ushort JLGMKEEOCNL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x684B7D0", Offset = "0x6849FD0", VA = "0x18684B7D0")]
	public static short IEJCMAPKCMM(this CNEIDIOGAGH MPOPMIPMGJI, short DLNLLKPAOKI, short JLGMKEEOCNL)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x684B4C0", Offset = "0x6849CC0", VA = "0x18684B4C0")]
	public static uint CGPHKAAHKEO(this CNEIDIOGAGH MPOPMIPMGJI, uint DLNLLKPAOKI, uint JLGMKEEOCNL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x684B960", Offset = "0x684A160", VA = "0x18684B960")]
	public static int MHMBBDAJJHL(this CNEIDIOGAGH MPOPMIPMGJI, int DLNLLKPAOKI, int JLGMKEEOCNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x684B780", Offset = "0x6849F80", VA = "0x18684B780")]
	public static int IEBJEOLDJME(this CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x684B620", Offset = "0x6849E20", VA = "0x18684B620")]
	public static long EDMDPELKDIH(this CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x684B5A0", Offset = "0x6849DA0", VA = "0x18684B5A0")]
	public static uint DNBKJPEJKPB(this CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x684B870", Offset = "0x684A070", VA = "0x18684B870")]
	public static ulong ILFGAEKOHBG(this CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x684B6B0", Offset = "0x6849EB0", VA = "0x18684B6B0")]
	public static float HEEGGHOKPAM(this CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x684B9D0", Offset = "0x684A1D0", VA = "0x18684B9D0")]
	public static double MPPJKDHNFNA(this CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x684B530", Offset = "0x6849D30", VA = "0x18684B530")]
	public static float3 DKHAHFFKCNL(this CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HLPBGKJDNHE
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x684B170", Offset = "0x6849970", VA = "0x18684B170")]
	public static void HIPGEKILFKK(this LAOEOOKOBMH COHNONCDMOG, uint IPMCEGBFPPC, bool IHLDBCMLAKP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x684B310", Offset = "0x6849B10", VA = "0x18684B310")]
	public static uint JAKOBCPFFMA(this CNEIDIOGAGH PJOJHFLPHKO, bool IHLDBCMLAKP = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MACAHEIHCNB
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private struct OJOJAENEFKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public uint OJPMFPLPDKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public uint EOJMDNBEDFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public double GOPEBOMPNBB;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x684B9D0", Offset = "0x684A1D0", VA = "0x18684B9D0")]
	public static double MPPJKDHNFNA(CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x684BDE0", Offset = "0x684A5E0", VA = "0x18684BDE0")]
	public static void JLCFBLCPAIK(double IPHHABIKCHD, LAOEOOKOBMH MPOPMIPMGJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JCCICANEONH
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NIDBDDAGFGP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		public NIDBDDAGFGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FKMDMAPDLGA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		public FKMDMAPDLGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class FNNCHBJGHKF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		public FNNCHBJGHKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class ENJLCPLJCPF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		public ENJLCPLJCPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class GOECCMDJBGJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		public GOECCMDJBGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class PIBAOMCDPMI<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		public PIBAOMCDPMI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NIJDHJMJJNA
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct GPFMAEFMOPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public uint KNALPNFLHJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public float KHPHDDIEOKI;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x684BE60", Offset = "0x684A660", VA = "0x18684BE60")]
	public static float HEEGGHOKPAM(CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x684BEF0", Offset = "0x684A6F0", VA = "0x18684BEF0")]
	public static void JDNDPEBGLCH(float IPHHABIKCHD, LAOEOOKOBMH MPOPMIPMGJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class PBEHEJDJAIC
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CPIMGAAJOGA
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly int[] CDNMPLEIMNG;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6848C50", Offset = "0x6847450", VA = "0x186848C50")]
	public static int AHLEIOOKFMI(uint OFIHECKAMPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6849FD0", Offset = "0x68487D0", VA = "0x186849FD0")]
	public static uint NOFAJDEDOAF(int MLMAGAPACCG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6849EA0", Offset = "0x68486A0", VA = "0x186849EA0")]
	private static uint LEMCCEPHLFB(int MLMAGAPACCG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6849D70", Offset = "0x6848570", VA = "0x186849D70")]
	public static int INFLELJKNFC(int IPHHABIKCHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6849950", Offset = "0x6848150", VA = "0x186849950")]
	public static bool HJGLEDKCFML(CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6849F60", Offset = "0x6848760", VA = "0x186849F60")]
	public static byte NJOAOFMNBJI(byte DLNLLKPAOKI, byte JLGMKEEOCNL, CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x684A500", Offset = "0x6848D00", VA = "0x18684A500")]
	public static sbyte PMPBEHANPBP(sbyte DLNLLKPAOKI, sbyte JLGMKEEOCNL, CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6849E10", Offset = "0x6848610", VA = "0x186849E10")]
	public static ushort JJAFKNBMMLC(ushort DLNLLKPAOKI, ushort JLGMKEEOCNL, CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6849AF0", Offset = "0x68482F0", VA = "0x186849AF0")]
	public static short IEJCMAPKCMM(short DLNLLKPAOKI, short JLGMKEEOCNL, CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6849A60", Offset = "0x6848260", VA = "0x186849A60")]
	public static int IEBJEOLDJME(CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6849180", Offset = "0x6847980", VA = "0x186849180")]
	public static long EDMDPELKDIH(CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6849050", Offset = "0x6847850", VA = "0x186849050")]
	public static uint DNBKJPEJKPB(CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6849C80", Offset = "0x6848480", VA = "0x186849C80")]
	public static ulong ILFGAEKOHBG(CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6848EF0", Offset = "0x68476F0", VA = "0x186848EF0")]
	public static uint CGPHKAAHKEO(uint DLNLLKPAOKI, uint JLGMKEEOCNL, CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6849EB0", Offset = "0x68486B0", VA = "0x186849EB0")]
	public static int MHMBBDAJJHL(int DLNLLKPAOKI, int JLGMKEEOCNL, CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x68490A0", Offset = "0x68478A0", VA = "0x1868490A0")]
	public static uint EAELIHLMNAH(int MLMAGAPACCG, CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x684A040", Offset = "0x6848840", VA = "0x18684A040")]
	public static uint OCHPIOKPJHK(int GMLJNBPENHG, CNEIDIOGAGH BHFMOMNKABO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6848D00", Offset = "0x6847500", VA = "0x186848D00")]
	private static void BKBBCIAIBGN(CNEIDIOGAGH MPOPMIPMGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6849C20", Offset = "0x6848420", VA = "0x186849C20")]
	public static void IIOLDHCDHMA(bool IPHHABIKCHD, LAOEOOKOBMH BHFMOMNKABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6849100", Offset = "0x6847900", VA = "0x186849100")]
	public static void EAIMCDGIOFG(byte IPHHABIKCHD, byte DLNLLKPAOKI, byte JLGMKEEOCNL, LAOEOOKOBMH BHFMOMNKABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6849610", Offset = "0x6847E10", VA = "0x186849610")]
	public static void EMAOBNOPEHL(sbyte IPHHABIKCHD, sbyte DLNLLKPAOKI, sbyte JLGMKEEOCNL, LAOEOOKOBMH BHFMOMNKABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x68499E0", Offset = "0x68481E0", VA = "0x1868499E0")]
	public static void HOOAACJGMGE(ushort IPHHABIKCHD, ushort DLNLLKPAOKI, ushort JLGMKEEOCNL, LAOEOOKOBMH BHFMOMNKABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6849D90", Offset = "0x6848590", VA = "0x186849D90")]
	public static void JGIDJOGBBBA(short IPHHABIKCHD, short DLNLLKPAOKI, short JLGMKEEOCNL, LAOEOOKOBMH BHFMOMNKABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68498A0", Offset = "0x68480A0", VA = "0x1868498A0")]
	public static void HBMKJADAEHE(uint IPHHABIKCHD, uint DLNLLKPAOKI, uint JLGMKEEOCNL, LAOEOOKOBMH BHFMOMNKABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6849B60", Offset = "0x6848360", VA = "0x186849B60")]
	public static void IIKCMBKGIGD(int IPHHABIKCHD, int DLNLLKPAOKI, int JLGMKEEOCNL, LAOEOOKOBMH BHFMOMNKABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6848DF0", Offset = "0x68475F0", VA = "0x186848DF0")]
	public static void CEFIPFNLMFO(int IPHHABIKCHD, LAOEOOKOBMH BHFMOMNKABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6849820", Offset = "0x6848020", VA = "0x186849820")]
	public static void GFGMPNLECHE(long IPHHABIKCHD, LAOEOOKOBMH BHFMOMNKABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6848E90", Offset = "0x6847690", VA = "0x186848E90")]
	public static void CFBPCEEFOPP(uint IPHHABIKCHD, LAOEOOKOBMH BHFMOMNKABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x68491E0", Offset = "0x68479E0", VA = "0x1868491E0")]
	public static void EHLOFDNHALE(ulong IPHHABIKCHD, LAOEOOKOBMH BHFMOMNKABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x684A230", Offset = "0x6848A30", VA = "0x18684A230")]
	public static void OOPOLNPHFEM(uint IPHHABIKCHD, int MLMAGAPACCG, LAOEOOKOBMH BHFMOMNKABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6849790", Offset = "0x6847F90", VA = "0x186849790")]
	private static void FLEFHDLIBNH(LAOEOOKOBMH MPOPMIPMGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6848FA0", Offset = "0x68477A0", VA = "0x186848FA0")]
	private static ulong DAFINOICHKE(ulong IPHHABIKCHD, LAOEOOKOBMH MPOPMIPMGJI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6849E80", Offset = "0x6848680", VA = "0x186849E80")]
	public static int LBNJGDFLIMJ(LAOEOOKOBMH MPOPMIPMGJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6849520", Offset = "0x6847D20", VA = "0x186849520")]
	public static void ELKHOEHJIOF(CNEIDIOGAGH PJOJHFLPHKO, Span<byte> FALADFAFJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6849690", Offset = "0x6847E90", VA = "0x186849690")]
	public static void ENPFOEEMBDF(LAOEOOKOBMH COHNONCDMOG, ReadOnlySpan<byte> FDJIPPJKNDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal static class AGKLAJKJPNE
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x590BB50", Offset = "0x590A350", VA = "0x18590BB50")]
	public static int DELBPOLEGBL(uint FEGGJAIMAGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6848C20", Offset = "0x6847420", VA = "0x186848C20")]
	public static long MPINCMNHJID(ulong FEGGJAIMAGC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5914CE0", Offset = "0x59134E0", VA = "0x185914CE0")]
	public static uint EBJGKPEBBJG(int FEGGJAIMAGC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6848C10", Offset = "0x6847410", VA = "0x186848C10")]
	public static ulong GGBPFJNCKNF(long FEGGJAIMAGC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public ref struct LAOEOOKOBMH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly string AEEMNNDNOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly Span<byte> MLKNGAFFKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal int KLJLENFIEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int MGPDEBBFEAM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ReadOnlySpan<byte> AHADGAKGJDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x684BBE0", Offset = "0x684A3E0", VA = "0x18684BBE0")]
		get
		{
			return default(ReadOnlySpan<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1EDF0F0", Offset = "0x1EDD8F0", VA = "0x181EDF0F0")]
	public LAOEOOKOBMH(Span<byte> MLKNGAFFKGE, int KLJLENFIEBG = 0, int MGPDEBBFEAM = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class EGPGGKKDAMH
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2917500", Offset = "0x2915D00", VA = "0x182917500")]
	public static void IINHDBGECBD<T>(this LAOEOOKOBMH COHNONCDMOG, T IPHHABIKCHD) where T : struct, MMJLCDBBDEC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x684ADA0", Offset = "0x68495A0", VA = "0x18684ADA0")]
	public static void IIOLDHCDHMA(this LAOEOOKOBMH MPOPMIPMGJI, bool IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x684A750", Offset = "0x6848F50", VA = "0x18684A750")]
	public static void EAIMCDGIOFG(this LAOEOOKOBMH MPOPMIPMGJI, byte IPHHABIKCHD, byte DLNLLKPAOKI, byte JLGMKEEOCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x684A960", Offset = "0x6849160", VA = "0x18684A960")]
	public static void EMAOBNOPEHL(this LAOEOOKOBMH MPOPMIPMGJI, sbyte IPHHABIKCHD, sbyte DLNLLKPAOKI, sbyte JLGMKEEOCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x684AC70", Offset = "0x6849470", VA = "0x18684AC70")]
	public static void HOOAACJGMGE(this LAOEOOKOBMH MPOPMIPMGJI, ushort IPHHABIKCHD, ushort DLNLLKPAOKI, ushort JLGMKEEOCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x684AE90", Offset = "0x6849690", VA = "0x18684AE90")]
	public static void JGIDJOGBBBA(this LAOEOOKOBMH MPOPMIPMGJI, short IPHHABIKCHD, short DLNLLKPAOKI, short JLGMKEEOCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x684ABF0", Offset = "0x68493F0", VA = "0x18684ABF0")]
	public static void HBMKJADAEHE(this LAOEOOKOBMH MPOPMIPMGJI, uint IPHHABIKCHD, uint DLNLLKPAOKI, uint JLGMKEEOCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x684AD20", Offset = "0x6849520", VA = "0x18684AD20")]
	public static void IIKCMBKGIGD(this LAOEOOKOBMH MPOPMIPMGJI, int IPHHABIKCHD, int DLNLLKPAOKI, int JLGMKEEOCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x684A660", Offset = "0x6848E60", VA = "0x18684A660")]
	public static void CEFIPFNLMFO(this LAOEOOKOBMH MPOPMIPMGJI, int IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x684AB40", Offset = "0x6849340", VA = "0x18684AB40")]
	public static void GFGMPNLECHE(this LAOEOOKOBMH MPOPMIPMGJI, long IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x684A6C0", Offset = "0x6848EC0", VA = "0x18684A6C0")]
	public static void CFBPCEEFOPP(this LAOEOOKOBMH MPOPMIPMGJI, uint IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x684A7E0", Offset = "0x6848FE0", VA = "0x18684A7E0")]
	public static void EHLOFDNHALE(this LAOEOOKOBMH MPOPMIPMGJI, ulong IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x684AE30", Offset = "0x6849630", VA = "0x18684AE30")]
	public static void JDNDPEBGLCH(this LAOEOOKOBMH MPOPMIPMGJI, float IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x684AF40", Offset = "0x6849740", VA = "0x18684AF40")]
	public static void JLCFBLCPAIK(this LAOEOOKOBMH MPOPMIPMGJI, double IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x684B020", Offset = "0x6849820", VA = "0x18684B020")]
	public static void OBOIFJIOBAG(this LAOEOOKOBMH MPOPMIPMGJI, [In] float3 IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x684A600", Offset = "0x6848E00", VA = "0x18684A600")]
	public static int BPOGDPLDIEO(this LAOEOOKOBMH MPOPMIPMGJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x684AA10", Offset = "0x6849210", VA = "0x18684AA10")]
	public static void ENPFOEEMBDF(this LAOEOOKOBMH MPOPMIPMGJI, ReadOnlySpan<byte> FDJIPPJKNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x684A840", Offset = "0x6849040", VA = "0x18684A840")]
	public static void ELKHOEHJIOF(this CNEIDIOGAGH MPOPMIPMGJI, Span<byte> FALADFAFJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x684B120", Offset = "0x6849920", VA = "0x18684B120")]
	public static int PEMKKPHGEHH(this CNEIDIOGAGH MPOPMIPMGJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x684AFC0", Offset = "0x68497C0", VA = "0x18684AFC0")]
	public static void KBAHCDAFOFD(this LAOEOOKOBMH MPOPMIPMGJI, int PFMDBCNIBBL)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CBIBAIGKJBN
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public CBIBAIGKJBN()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
