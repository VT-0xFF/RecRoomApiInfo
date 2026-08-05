using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum GCLHGIHCAPM : byte
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
public enum LHKJHALDLIM : byte
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
public interface BOAANLGFGMH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HGIKOPMJDOA([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EIIECLPIDLN([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OGDPDIPDGHP([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HMLNHEPDGFA(LHKJHALDLIM LDJHCEHACCH, [Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HEBAOFHBNAP([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ICPGJKJIMMF([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OBJMAGONBJA([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HJHIKFLPBFD([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AKAEEPOOOOG([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HNBNEDPNAIB([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool JCKJCKOPALC([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DOMDACLJKLB([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ECEGCEGBOAO([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool MEIGNMLEDNA([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool CLOLFIEIBNB(HIFKKPHJKKM PCNAGIAKKAE, [Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LAMKFLNDCJL(CIEDCBNHIKH PCNAGIAKKAE, [Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool AGGLEICGNCC([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool ACJMNFNMFMC([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OCPNKBOKCLN([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool DEHIMGPPBGP([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool MPMBLONKHCI([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool PAADAENCCFI([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool JPBDEHHHJDK(LDPHKDEBOBH NHPJHMKDNHF, [Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool GDAFEHIFIDL([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool PMDHNOBEMFL([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool IFFKJJDOAKF([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool FBCPBPICOPF([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool AJFILIGOOFH(CNEMHGKAEHI HCOAFCACBNM, [Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool MHFDCDPLBFG([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool CGECDEBGIIB([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool LMDODLCKJKP([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool BDBDOEFPCGN([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool DONFFJAHFDK([Out] GCLHGIHCAPM CJPAHHKKKCN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	string HIOHKEPCGEM(GCLHGIHCAPM MGKEMJNCJNN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CAGFNIMEBIK
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDD70", Offset = "0x6BECD70", VA = "0x186BEDD70")]
	public static bool NBDHIAOKKDM(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6BED900", Offset = "0x6BEC900", VA = "0x186BED900")]
	public static bool LDJOGDAENHC(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6BED220", Offset = "0x6BEC220", VA = "0x186BED220")]
	public static bool HGIKOPMJDOA(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6BECF20", Offset = "0x6BEBF20", VA = "0x186BECF20")]
	public static bool EIIECLPIDLN(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE060", Offset = "0x6BED060", VA = "0x186BEE060")]
	public static bool OGDPDIPDGHP(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BED390", Offset = "0x6BEC390", VA = "0x186BED390")]
	public static bool HMLNHEPDGFA(this BOAANLGFGMH EGKEOGBNGFH, LHKJHALDLIM LDJHCEHACCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6BED160", Offset = "0x6BEC160", VA = "0x186BED160")]
	public static bool HEBAOFHBNAP(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BED520", Offset = "0x6BEC520", VA = "0x186BED520")]
	public static bool ICPGJKJIMMF(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDEE0", Offset = "0x6BECEE0", VA = "0x186BEDEE0")]
	public static bool OBJMAGONBJA(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6BED2D0", Offset = "0x6BEC2D0", VA = "0x186BED2D0")]
	public static bool HJHIKFLPBFD(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC910", Offset = "0x6BEB910", VA = "0x186BEC910")]
	public static bool AKAEEPOOOOG(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6BED460", Offset = "0x6BEC460", VA = "0x186BED460")]
	public static bool HNBNEDPNAIB(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6BED6A0", Offset = "0x6BEC6A0", VA = "0x186BED6A0")]
	public static bool JCKJCKOPALC(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6BECCE0", Offset = "0x6BEBCE0", VA = "0x186BECCE0")]
	public static bool DOMDACLJKLB(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE60", Offset = "0x6BEBE60", VA = "0x186BECE60")]
	public static bool ECEGCEGBOAO(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDB30", Offset = "0x6BECB30", VA = "0x186BEDB30")]
	public static bool MEIGNMLEDNA(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6BECB50", Offset = "0x6BEBB50", VA = "0x186BECB50")]
	public static bool CLOLFIEIBNB(this BOAANLGFGMH EGKEOGBNGFH, HIFKKPHJKKM PCNAGIAKKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6BED830", Offset = "0x6BEC830", VA = "0x186BED830")]
	public static bool LAMKFLNDCJL(this BOAANLGFGMH EGKEOGBNGFH, CIEDCBNHIKH PCNAGIAKKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC780", Offset = "0x6BEB780", VA = "0x186BEC780")]
	public static bool AGGLEICGNCC(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC6C0", Offset = "0x6BEB6C0", VA = "0x186BEC6C0")]
	public static bool ACJMNFNMFMC(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDFA0", Offset = "0x6BECFA0", VA = "0x186BEDFA0")]
	public static bool OCPNKBOKCLN(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6BECC20", Offset = "0x6BEBC20", VA = "0x186BECC20")]
	public static bool DEHIMGPPBGP(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDCB0", Offset = "0x6BECCB0", VA = "0x186BEDCB0")]
	public static bool MPMBLONKHCI(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE120", Offset = "0x6BED120", VA = "0x186BEE120")]
	public static bool PAADAENCCFI(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6BED760", Offset = "0x6BEC760", VA = "0x186BED760")]
	public static bool JPBDEHHHJDK(this BOAANLGFGMH EGKEOGBNGFH, LDPHKDEBOBH NHPJHMKDNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6BED0A0", Offset = "0x6BEC0A0", VA = "0x186BED0A0")]
	public static bool GDAFEHIFIDL(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE1E0", Offset = "0x6BED1E0", VA = "0x186BEE1E0")]
	public static bool PMDHNOBEMFL(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6BED5E0", Offset = "0x6BEC5E0", VA = "0x186BED5E0")]
	public static bool IFFKJJDOAKF(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6BECFE0", Offset = "0x6BEBFE0", VA = "0x186BECFE0")]
	public static bool FBCPBPICOPF(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC840", Offset = "0x6BEB840", VA = "0x186BEC840")]
	public static bool AJFILIGOOFH(this BOAANLGFGMH EGKEOGBNGFH, CNEMHGKAEHI HCOAFCACBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDBF0", Offset = "0x6BECBF0", VA = "0x186BEDBF0")]
	public static bool MHFDCDPLBFG(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6BECA90", Offset = "0x6BEBA90", VA = "0x186BECA90")]
	public static bool CGECDEBGIIB(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDA70", Offset = "0x6BECA70", VA = "0x186BEDA70")]
	public static bool LMDODLCKJKP(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC9D0", Offset = "0x6BEB9D0", VA = "0x186BEC9D0")]
	public static bool BDBDOEFPCGN(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6BECDA0", Offset = "0x6BEBDA0", VA = "0x186BECDA0")]
	public static bool DONFFJAHFDK(this BOAANLGFGMH EGKEOGBNGFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum FCEIKOPJCLN : byte
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
public enum CKDMKCALGFE : byte
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
public enum HIFKKPHJKKM : byte
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
public enum CIEDCBNHIKH : byte
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
public enum LDPHKDEBOBH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	RegularObjects = 2,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConditionallyRestrictedObjects = 6
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
public enum CNEMHGKAEHI
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	UnblockedCreators = 2,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	All = 6
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MLEHMDCENAD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GCLHGIHCAPM DHPDJBINGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HGIKOPMJDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EIIECLPIDLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	CKDMKCALGFE MFELDPLPJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HEBAOFHBNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ICPGJKJIMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool OBJMAGONBJA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool HJHIKFLPBFD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool AKAEEPOOOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool HNBNEDPNAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool JCKJCKOPALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool DOMDACLJKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool ECEGCEGBOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool MEIGNMLEDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	HIFKKPHJKKM ECKJGJHBDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	CIEDCBNHIKH JCBKAEBAPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool AGGLEICGNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool ACJMNFNMFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool OCPNKBOKCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool DEHIMGPPBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool MPMBLONKHCI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool PAADAENCCFI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	LDPHKDEBOBH JAHBOAPBIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool GDAFEHIFIDL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool PMDHNOBEMFL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool IFFKJJDOAKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool FBCPBPICOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	CNEMHGKAEHI LAAGCKDLAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool MHFDCDPLBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool CGECDEBGIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool LMDODLCKJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool BDBDOEFPCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool DONFFJAHFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BCOIDHMOHLN
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC650", Offset = "0x6BEB650", VA = "0x186BEC650")]
	public static string HMMIHAPPAFH(GCLHGIHCAPM CHNGFEKJHON)
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
