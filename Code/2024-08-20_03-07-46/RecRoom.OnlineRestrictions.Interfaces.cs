using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum EPNKNKBDIMI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Moderation = 2,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Platform = 4,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	RecNetJunior = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Settings = 0x20
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[Flags]
public enum KPJJDAGOGGN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Party = 0x12,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	FavoriteFriend = 0x1C,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Friend = 0x18,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Any = 0x10
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CJINGDNGAEK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LBMMEIFOJBJ([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NEKDMDJNNBL([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GFGPGJBFNKJ([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BCFNDELOCNC([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NBBFAPKEJLJ([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FLHMKGPOBOM(KPJJDAGOGGN DFKNFPEBFCH, [Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LJFAGBMCOHF([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BPKFLOFKOJP([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KHBMJDFJKGE([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PBBDKPNEEKF([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool HFIBPPNPJKN([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GIOJOEFFJHM([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CFDOIEAPAGP([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool FAICHEHNMHF([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool LCLFOIIAGMC([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool NACFCNGGPIL([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool LLDKBKDDNNA(BEFJAINJIBF EPPEOBDOMFA, [Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool MFEFIJJEEIA(JMMMDJEIFCM EPPEOBDOMFA, [Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool PGICAHMGMED([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool JBELHLNOCHD([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool NOHEPGLEKBC([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool ACCODJJJJAK([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool LMALEOADIIP([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool KOCBEIAPNPM([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool NAKLHBBIFBA(KEBNOKIDJOB AAAODCCDNKB, [Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool MFDLLOCOMAB([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool LDJFCNHINBL([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool ILLDBFABAFH([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool PLILFLKDHDL([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool GDPMBEOKLBP(PMDJPOOBFJG MKGCIIAECFI, [Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool JAOBFNLDNEC([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool EBNKEBAPKPM([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool PNOKHCKCOIO([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool MACBNMLPKJI([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool PCFLGHFHHPB([Out] EPNKNKBDIMI MOCNAGKHJCP);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	string ACDONEHAMAB(EPNKNKBDIMI ENGGANLNDNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KBAKLMDKNIB
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7E10", Offset = "0x6BF6E10", VA = "0x186BF7E10")]
	public static bool BLCHPJMFFOG(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8030", Offset = "0x6BF7030", VA = "0x186BF8030")]
	public static bool CEOJILLBOJB(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8AD0", Offset = "0x6BF7AD0", VA = "0x186BF8AD0")]
	public static bool LBMMEIFOJBJ(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9370", Offset = "0x6BF8370", VA = "0x186BF9370")]
	public static bool NEKDMDJNNBL(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8550", Offset = "0x6BF7550", VA = "0x186BF8550")]
	public static bool GFGPGJBFNKJ(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7D60", Offset = "0x6BF6D60", VA = "0x186BF7D60")]
	public static bool BCFNDELOCNC(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF92C0", Offset = "0x6BF82C0", VA = "0x186BF92C0")]
	public static bool NBBFAPKEJLJ(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6BF83B0", Offset = "0x6BF73B0", VA = "0x186BF83B0")]
	public static bool FLHMKGPOBOM(this CJINGDNGAEK CCCNFPGKIHG, KPJJDAGOGGN DFKNFPEBFCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8CE0", Offset = "0x6BF7CE0", VA = "0x186BF8CE0")]
	public static bool LJFAGBMCOHF(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7F80", Offset = "0x6BF6F80", VA = "0x186BF7F80")]
	public static bool BPKFLOFKOJP(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8970", Offset = "0x6BF7970", VA = "0x186BF8970")]
	public static bool KHBMJDFJKGE(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6BF94D0", Offset = "0x6BF84D0", VA = "0x186BF94D0")]
	public static bool PBBDKPNEEKF(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6BF86B0", Offset = "0x6BF76B0", VA = "0x186BF86B0")]
	public static bool HFIBPPNPJKN(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8600", Offset = "0x6BF7600", VA = "0x186BF8600")]
	public static bool GIOJOEFFJHM(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6BF81A0", Offset = "0x6BF71A0", VA = "0x186BF81A0")]
	public static bool CFDOIEAPAGP(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8300", Offset = "0x6BF7300", VA = "0x186BF8300")]
	public static bool FAICHEHNMHF(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8B80", Offset = "0x6BF7B80", VA = "0x186BF8B80")]
	public static bool LCLFOIIAGMC(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9140", Offset = "0x6BF8140", VA = "0x186BF9140")]
	public static bool NACFCNGGPIL(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8D90", Offset = "0x6BF7D90", VA = "0x186BF8D90")]
	public static bool LLDKBKDDNNA(this CJINGDNGAEK CCCNFPGKIHG, BEFJAINJIBF EPPEOBDOMFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9070", Offset = "0x6BF8070", VA = "0x186BF9070")]
	public static bool MFEFIJJEEIA(this CJINGDNGAEK CCCNFPGKIHG, JMMMDJEIFCM EPPEOBDOMFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9630", Offset = "0x6BF8630", VA = "0x186BF9630")]
	public static bool PGICAHMGMED(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF88C0", Offset = "0x6BF78C0", VA = "0x186BF88C0")]
	public static bool JBELHLNOCHD(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9420", Offset = "0x6BF8420", VA = "0x186BF9420")]
	public static bool NOHEPGLEKBC(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7CB0", Offset = "0x6BF6CB0", VA = "0x186BF7CB0")]
	public static bool ACCODJJJJAK(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8E60", Offset = "0x6BF7E60", VA = "0x186BF8E60")]
	public static bool LMALEOADIIP(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8A20", Offset = "0x6BF7A20", VA = "0x186BF8A20")]
	public static bool KOCBEIAPNPM(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6BF91F0", Offset = "0x6BF81F0", VA = "0x186BF91F0")]
	public static bool NAKLHBBIFBA(this CJINGDNGAEK CCCNFPGKIHG, KEBNOKIDJOB AAAODCCDNKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8FC0", Offset = "0x6BF7FC0", VA = "0x186BF8FC0")]
	public static bool MFDLLOCOMAB(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8C30", Offset = "0x6BF7C30", VA = "0x186BF8C30")]
	public static bool LDJFCNHINBL(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8760", Offset = "0x6BF7760", VA = "0x186BF8760")]
	public static bool ILLDBFABAFH(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6BF96E0", Offset = "0x6BF86E0", VA = "0x186BF96E0")]
	public static bool PLILFLKDHDL(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8480", Offset = "0x6BF7480", VA = "0x186BF8480")]
	public static bool GDPMBEOKLBP(this CJINGDNGAEK CCCNFPGKIHG, PMDJPOOBFJG MKGCIIAECFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8810", Offset = "0x6BF7810", VA = "0x186BF8810")]
	public static bool JAOBFNLDNEC(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8250", Offset = "0x6BF7250", VA = "0x186BF8250")]
	public static bool EBNKEBAPKPM(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9790", Offset = "0x6BF8790", VA = "0x186BF9790")]
	public static bool PNOKHCKCOIO(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8F10", Offset = "0x6BF7F10", VA = "0x186BF8F10")]
	public static bool MACBNMLPKJI(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9580", Offset = "0x6BF8580", VA = "0x186BF9580")]
	public static bool PCFLGHFHHPB(this CJINGDNGAEK CCCNFPGKIHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum AFOEMODJOHJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Party = 2,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	FavoriteFriend = 4,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Friend = 8,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Any = 0x10
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[Flags]
public enum ELJBKDGOBKJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Party = 2,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	FavoriteFriends = 4,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Friends = 0xC,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	PartyAndFavoriteFriends = 6,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	PartyAndFriends = 0xE,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	All = 0x1E
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[Flags]
public enum BEFJAINJIBF : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Dorm = 2,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	All = 0xA
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum JMMMDJEIFCM : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TransientDormOnly = 2,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	SavedDorm = 4,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	All = 0xC
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Flags]
public enum KEBNOKIDJOB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	RegularObjects = 2,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConditionallyRestrictedObjects = 6
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
public enum PMDJPOOBFJG
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	UnblockedCreators = 2,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	All = 6
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FNBEBLBAAHL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EPNKNKBDIMI BONFOCMGOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LBMMEIFOJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NEKDMDJNNBL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GFGPGJBFNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BCFNDELOCNC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	ELJBKDGOBKJ NFIJCJEAJGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool LJFAGBMCOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool BPKFLOFKOJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool KHBMJDFJKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool PBBDKPNEEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool HFIBPPNPJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool GIOJOEFFJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool CFDOIEAPAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool FAICHEHNMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool LCLFOIIAGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool NACFCNGGPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	BEFJAINJIBF ANKHKBEBCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JMMMDJEIFCM CIAOAIOIGON
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool PGICAHMGMED
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool JBELHLNOCHD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool NOHEPGLEKBC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool ACCODJJJJAK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool LMALEOADIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool KOCBEIAPNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	KEBNOKIDJOB LKMMBEDPBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool MFDLLOCOMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool LDJFCNHINBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool ILLDBFABAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool PLILFLKDHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	PMDJPOOBFJG FHDILFOIEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JAOBFNLDNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool EBNKEBAPKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool PNOKHCKCOIO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool MACBNMLPKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool PCFLGHFHHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class CAEIIOCNKDF
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7C40", Offset = "0x6BF6C40", VA = "0x186BF7C40")]
	public static string CEGNHOAEBNK(EPNKNKBDIMI IEJOAHLDAPK)
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
