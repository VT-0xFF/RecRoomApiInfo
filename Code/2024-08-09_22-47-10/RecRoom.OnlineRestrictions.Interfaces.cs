using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum GONLAKFIAMC : byte
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
public enum JBNIEAMAKNC : byte
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
public interface COGJHCPAIGF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BKGLNHGKCDI([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KANPNMAFMCO([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NFHAHLMMILM([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BBCEMLCMPPC([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MNJHNBHJJDO(JBNIEAMAKNC LPBIBEDHHOO, [Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IGPAFHGHBLC([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IPLDEEMDAHF([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BCNLNDCOJGN([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DBHNOLLCCBH([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NIONNIKKGDM([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FGMDGDHLJJF([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DOBIOOMNDFP([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PCFMIEGEKLF([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool EEHPGBKCMEG([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool EDKGKAIIOJI([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool HHOHLHENGDE(FBHKGLIHJLA BKAJANAJCED, [Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool AIDEELKMECD(PPHOLFNHJGN BKAJANAJCED, [Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool PEMEHOLDCAD([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OJGKGBPKOOC([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool BILJHEALMJL([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool LIGPBPOPBBJ([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool GLHDJLMLFEL([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool POFEHPNPBIL([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool GJGKMFIEHCG(MFMNHPHEPIF JFFIJKCJBDG, [Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool PFPLBFHHDFD([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool HKFEJOOBHBF([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool HMHADGBABIF([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool MPJFOJLMOKN([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool JBEMEONOFLP(PNHPJIKHLCK JBHCONGHBOF, [Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool PKIDJALNKNP([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool PAGOLLGKBBO([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool NLKDLMCKNGJ([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool IKKNMNPDKPG([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool NEOKLAFADPA([Out] GONLAKFIAMC PECKEBKCDNB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	string PPLNMJIBLEA(GONLAKFIAMC LOCNMONNJJD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HMLMKOKCACP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6B74E50", Offset = "0x6B74250", VA = "0x186B74E50")]
	public static bool ALFCHPIBJFK(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B75370", Offset = "0x6B74770", VA = "0x186B75370")]
	public static bool DNDFNIOMBNJ(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6B75200", Offset = "0x6B74600", VA = "0x186B75200")]
	public static bool BKGLNHGKCDI(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6B75ED0", Offset = "0x6B752D0", VA = "0x186B75ED0")]
	public static bool KANPNMAFMCO(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B762A0", Offset = "0x6B756A0", VA = "0x186B762A0")]
	public static bool NFHAHLMMILM(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B74FC0", Offset = "0x6B743C0", VA = "0x186B74FC0")]
	public static bool BBCEMLCMPPC(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B76050", Offset = "0x6B75450", VA = "0x186B76050")]
	public static bool MNJHNBHJJDO(this COGJHCPAIGF ENFDNENFMKC, JBNIEAMAKNC LPBIBEDHHOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B75BC0", Offset = "0x6B74FC0", VA = "0x186B75BC0")]
	public static bool IGPAFHGHBLC(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B75D40", Offset = "0x6B75140", VA = "0x186B75D40")]
	public static bool IPLDEEMDAHF(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B75080", Offset = "0x6B74480", VA = "0x186B75080")]
	public static bool BCNLNDCOJGN(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6B752B0", Offset = "0x6B746B0", VA = "0x186B752B0")]
	public static bool DBHNOLLCCBH(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6B76360", Offset = "0x6B75760", VA = "0x186B76360")]
	public static bool NIONNIKKGDM(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B75720", Offset = "0x6B74B20", VA = "0x186B75720")]
	public static bool FGMDGDHLJJF(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6B754E0", Offset = "0x6B748E0", VA = "0x186B754E0")]
	public static bool DOBIOOMNDFP(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6B76660", Offset = "0x6B75A60", VA = "0x186B76660")]
	public static bool PCFMIEGEKLF(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6B75660", Offset = "0x6B74A60", VA = "0x186B75660")]
	public static bool EEHPGBKCMEG(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6B755A0", Offset = "0x6B749A0", VA = "0x186B755A0")]
	public static bool EDKGKAIIOJI(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6B75970", Offset = "0x6B74D70", VA = "0x186B75970")]
	public static bool HHOHLHENGDE(this COGJHCPAIGF ENFDNENFMKC, FBHKGLIHJLA BKAJANAJCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6B74D80", Offset = "0x6B74180", VA = "0x186B74D80")]
	public static bool AIDEELKMECD(this COGJHCPAIGF ENFDNENFMKC, PPHOLFNHJGN BKAJANAJCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B76720", Offset = "0x6B75B20", VA = "0x186B76720")]
	public static bool PEMEHOLDCAD(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6B764E0", Offset = "0x6B758E0", VA = "0x186B764E0")]
	public static bool OJGKGBPKOOC(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6B75140", Offset = "0x6B74540", VA = "0x186B75140")]
	public static bool BILJHEALMJL(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6B75F90", Offset = "0x6B75390", VA = "0x186B75F90")]
	public static bool LIGPBPOPBBJ(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6B758B0", Offset = "0x6B74CB0", VA = "0x186B758B0")]
	public static bool GLHDJLMLFEL(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6B76960", Offset = "0x6B75D60", VA = "0x186B76960")]
	public static bool POFEHPNPBIL(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6B757E0", Offset = "0x6B74BE0", VA = "0x186B757E0")]
	public static bool GJGKMFIEHCG(this COGJHCPAIGF ENFDNENFMKC, MFMNHPHEPIF JFFIJKCJBDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6B767E0", Offset = "0x6B75BE0", VA = "0x186B767E0")]
	public static bool PFPLBFHHDFD(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6B75A40", Offset = "0x6B74E40", VA = "0x186B75A40")]
	public static bool HKFEJOOBHBF(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6B75B00", Offset = "0x6B74F00", VA = "0x186B75B00")]
	public static bool HMHADGBABIF(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6B76120", Offset = "0x6B75520", VA = "0x186B76120")]
	public static bool MPJFOJLMOKN(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6B75E00", Offset = "0x6B75200", VA = "0x186B75E00")]
	public static bool JBEMEONOFLP(this COGJHCPAIGF ENFDNENFMKC, PNHPJIKHLCK JBHCONGHBOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6B768A0", Offset = "0x6B75CA0", VA = "0x186B768A0")]
	public static bool PKIDJALNKNP(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6B765A0", Offset = "0x6B759A0", VA = "0x186B765A0")]
	public static bool PAGOLLGKBBO(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6B76420", Offset = "0x6B75820", VA = "0x186B76420")]
	public static bool NLKDLMCKNGJ(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6B75C80", Offset = "0x6B75080", VA = "0x186B75C80")]
	public static bool IKKNMNPDKPG(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6B761E0", Offset = "0x6B755E0", VA = "0x186B761E0")]
	public static bool NEOKLAFADPA(this COGJHCPAIGF ENFDNENFMKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum CDKHCKILGLD : byte
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
public enum BEEEGFFINJD : byte
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
public enum FBHKGLIHJLA : byte
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
public enum PPHOLFNHJGN : byte
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
public enum MFMNHPHEPIF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	RegularObjects = 2,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConditionallyRestrictedObjects = 6
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
public enum PNHPJIKHLCK
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	UnblockedCreators = 2,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	All = 6
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CPJGLHFALPK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GONLAKFIAMC BAGPMMOAKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BKGLNHGKCDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KANPNMAFMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NFHAHLMMILM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BEEEGFFINJD BDELGNPLJMN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IGPAFHGHBLC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool IPLDEEMDAHF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool BCNLNDCOJGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool DBHNOLLCCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool NIONNIKKGDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool FGMDGDHLJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool DOBIOOMNDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool PCFMIEGEKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool EEHPGBKCMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool EDKGKAIIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	FBHKGLIHJLA DKKOMKIKGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	PPHOLFNHJGN ADNPLIGALPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool PEMEHOLDCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool OJGKGBPKOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool BILJHEALMJL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool LIGPBPOPBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool GLHDJLMLFEL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool POFEHPNPBIL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	MFMNHPHEPIF AONJJJLCFDO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool PFPLBFHHDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool HKFEJOOBHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool HMHADGBABIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool MPJFOJLMOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	PNHPJIKHLCK DLNENOKLJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool PKIDJALNKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool PAGOLLGKBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool NLKDLMCKNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IKKNMNPDKPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool NEOKLAFADPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OFDJGDIJPON
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6B76A20", Offset = "0x6B75E20", VA = "0x186B76A20")]
	public static string NOLFCDEJBPB(GONLAKFIAMC LMADGEINEAF)
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
