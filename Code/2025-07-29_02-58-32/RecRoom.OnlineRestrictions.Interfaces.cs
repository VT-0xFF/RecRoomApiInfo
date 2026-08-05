using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum OLCPIMLEPBP : byte
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
public enum IMHGCMEMMBE : byte
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
public interface IALEJHMEBGG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HKDJDFKALBC([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MBOKDBLMEEK([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JGJIIFFDMON([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CKFBDDAFOPI([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PLNKNPCHIFD([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ANHHOALEIEI(IMHGCMEMMBE NCOKPLPLKMF, [Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OACPBEBCGFO([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool AEBDKECNIDG([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ECKFACOANOK([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JCDEOCEGKKM([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MLGKGHBAAFJ([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AOGKCAIJCDE([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool EAGIENBJMIA([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool KOJJCMOFAEG([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool PIBAIHBOIJH([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PKGLDCNONOC([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool CEJOGJDEECA(DNAOHDHFFPP LGMFIEJPEAB, [Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool FLGMGNLFHCD(ALINGJFEAOB LGMFIEJPEAB, [Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool GADJKKAEAOA([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool JNDGKLKFDJA([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool OEBBDDJKOCP([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool DDFIOPEOFEG([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool IDAEIBDDPAA([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool GPBNMDHFKHN([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool EGDFMOAJMDH(KDMMLJEJFNI IMEMANHPBAO, [Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool IDADAENLEHJ([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool EJIODMJACLA([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool MFIHFKHAFEC([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool BCIHHNGONJL([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool DNPDAABEKFA(DLGPPEIJAFD IMDFMNODPFM, [Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool ODOGPDJILKN([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool FPAHMHJJNHN([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool DPBIOGMMICJ([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool COOACLNBGAO([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool EJNFINPALAB([Out] OLCPIMLEPBP JPIJCLFODLI);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	string PIPMBHMEPEP(OLCPIMLEPBP NKBPBCPIOLD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FLKOODLMBNE
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x86BCE90", Offset = "0x86BB890", VA = "0x1886BCE90")]
	public static bool BCEDKIEEBNK(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x86BD8A0", Offset = "0x86BC2A0", VA = "0x1886BD8A0")]
	public static bool FEAJJPOCIIA(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x86BDCF0", Offset = "0x86BC6F0", VA = "0x1886BDCF0")]
	public static bool HKDJDFKALBC(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x86BE1C0", Offset = "0x86BCBC0", VA = "0x1886BE1C0")]
	public static bool MBOKDBLMEEK(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x86BDFB0", Offset = "0x86BC9B0", VA = "0x1886BDFB0")]
	public static bool JGJIIFFDMON(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x86BD180", Offset = "0x86BBB80", VA = "0x1886BD180")]
	public static bool CKFBDDAFOPI(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x86BE740", Offset = "0x86BD140", VA = "0x1886BE740")]
	public static bool PLNKNPCHIFD(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x86BCD10", Offset = "0x86BB710", VA = "0x1886BCD10")]
	public static bool ANHHOALEIEI(this IALEJHMEBGG JGNJOAAKFKE, IMHGCMEMMBE NCOKPLPLKMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x86BE3D0", Offset = "0x86BCDD0", VA = "0x1886BE3D0")]
	public static bool OACPBEBCGFO(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x86BCC60", Offset = "0x86BB660", VA = "0x1886BCC60")]
	public static bool AEBDKECNIDG(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x86BD5C0", Offset = "0x86BBFC0", VA = "0x1886BD5C0")]
	public static bool ECKFACOANOK(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x86BDF00", Offset = "0x86BC900", VA = "0x1886BDF00")]
	public static bool JCDEOCEGKKM(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x86BE320", Offset = "0x86BCD20", VA = "0x1886BE320")]
	public static bool MLGKGHBAAFJ(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x86BCDE0", Offset = "0x86BB7E0", VA = "0x1886BCDE0")]
	public static bool AOGKCAIJCDE(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x86BD510", Offset = "0x86BBF10", VA = "0x1886BD510")]
	public static bool EAGIENBJMIA(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86BE110", Offset = "0x86BCB10", VA = "0x1886BE110")]
	public static bool KOJJCMOFAEG(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x86BE5E0", Offset = "0x86BCFE0", VA = "0x1886BE5E0")]
	public static bool PIBAIHBOIJH(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x86BE690", Offset = "0x86BD090", VA = "0x1886BE690")]
	public static bool PKGLDCNONOC(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x86BD0B0", Offset = "0x86BBAB0", VA = "0x1886BD0B0")]
	public static bool CEJOGJDEECA(this IALEJHMEBGG JGNJOAAKFKE, DNAOHDHFFPP LGMFIEJPEAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x86BDA10", Offset = "0x86BC410", VA = "0x1886BDA10")]
	public static bool FLGMGNLFHCD(this IALEJHMEBGG JGNJOAAKFKE, ALINGJFEAOB LGMFIEJPEAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x86BDB90", Offset = "0x86BC590", VA = "0x1886BDB90")]
	public static bool GADJKKAEAOA(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x86BE060", Offset = "0x86BCA60", VA = "0x1886BE060")]
	public static bool JNDGKLKFDJA(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x86BE530", Offset = "0x86BCF30", VA = "0x1886BE530")]
	public static bool OEBBDDJKOCP(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x86BD2E0", Offset = "0x86BBCE0", VA = "0x1886BD2E0")]
	public static bool DDFIOPEOFEG(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x86BDE50", Offset = "0x86BC850", VA = "0x1886BDE50")]
	public static bool IDAEIBDDPAA(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x86BDC40", Offset = "0x86BC640", VA = "0x1886BDC40")]
	public static bool GPBNMDHFKHN(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x86BD670", Offset = "0x86BC070", VA = "0x1886BD670")]
	public static bool EGDFMOAJMDH(this IALEJHMEBGG JGNJOAAKFKE, KDMMLJEJFNI IMEMANHPBAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x86BDDA0", Offset = "0x86BC7A0", VA = "0x1886BDDA0")]
	public static bool IDADAENLEHJ(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x86BD740", Offset = "0x86BC140", VA = "0x1886BD740")]
	public static bool EJIODMJACLA(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x86BE270", Offset = "0x86BCC70", VA = "0x1886BE270")]
	public static bool MFIHFKHAFEC(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x86BD000", Offset = "0x86BBA00", VA = "0x1886BD000")]
	public static bool BCIHHNGONJL(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x86BD390", Offset = "0x86BBD90", VA = "0x1886BD390")]
	public static bool DNPDAABEKFA(this IALEJHMEBGG JGNJOAAKFKE, DLGPPEIJAFD IMDFMNODPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x86BE480", Offset = "0x86BCE80", VA = "0x1886BE480")]
	public static bool ODOGPDJILKN(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x86BDAE0", Offset = "0x86BC4E0", VA = "0x1886BDAE0")]
	public static bool FPAHMHJJNHN(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x86BD460", Offset = "0x86BBE60", VA = "0x1886BD460")]
	public static bool DPBIOGMMICJ(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x86BD230", Offset = "0x86BBC30", VA = "0x1886BD230")]
	public static bool COOACLNBGAO(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x86BD7F0", Offset = "0x86BC1F0", VA = "0x1886BD7F0")]
	public static bool EJNFINPALAB(this IALEJHMEBGG JGNJOAAKFKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum GILICJANJME : byte
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
public enum ABFDFLHBNLF : byte
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
public enum DNAOHDHFFPP : byte
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
public enum ALINGJFEAOB : byte
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
public enum KDMMLJEJFNI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	RegularObjects = 2,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConditionallyRestrictedObjects = 6
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
public enum DLGPPEIJAFD
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	UnblockedCreators = 2,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	All = 6
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BOJNEDPCEMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OLCPIMLEPBP HNHPJACBLDD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HKDJDFKALBC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MBOKDBLMEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JGJIIFFDMON
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool CKFBDDAFOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	ABFDFLHBNLF BCHFKEEDNDD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool OACPBEBCGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool AEBDKECNIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool ECKFACOANOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JCDEOCEGKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool MLGKGHBAAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool AOGKCAIJCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool EAGIENBJMIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool KOJJCMOFAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool PIBAIHBOIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool PKGLDCNONOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DNAOHDHFFPP HLFMEEPGGMO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	ALINGJFEAOB IMIKLJCHNIK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool GADJKKAEAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool JNDGKLKFDJA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool OEBBDDJKOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool DDFIOPEOFEG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool IDAEIBDDPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool GPBNMDHFKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	KDMMLJEJFNI MIOEJDLOMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool IDADAENLEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool EJIODMJACLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool MFIHFKHAFEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool BCIHHNGONJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	DLGPPEIJAFD BFCJCNOJMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool ODOGPDJILKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool FPAHMHJJNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool DPBIOGMMICJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool COOACLNBGAO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool EJNFINPALAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FBJDALBNIDL
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x86BCBF0", Offset = "0x86BB5F0", VA = "0x1886BCBF0")]
	public static string JNGGCIBGBNG(OLCPIMLEPBP PEIDNFHKHFH)
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
