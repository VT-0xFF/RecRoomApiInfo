using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.OnlineRestrictions
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[Flags]
	public enum OnlineRestrictionsSources : byte
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
	public enum PlayerRelationships : byte
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
	public interface BEXQCYIXEDV
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ZUICRIERSND([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SIYUKQPRAAI([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool TYKBNLXUQEO([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool JGGVLSQLJAC([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool WJWUTMHHZWA([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool RFYEJMGRTHT(PlayerRelationships a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool EKHCDSFIIAC([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool CFYBRIGYPXZ([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool BOZLBMPAQZU([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HQZIGVCJQTV([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool DAIJARSNKFT([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool GUZUNZEUKAY([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool HGLPPPUZDDM([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool ENKLJBSLOXZ([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool UYJHHJLGRWS([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool JDBLHVMNFTU([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool CCYINPMPKPB(CreationRooms a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool OQNGBOZRCYK(DrawingRooms a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool OJOEZAEVAXH([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool BJTAGDAMBGN([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "20")]
		bool HIYRQBUHPAE([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool YXSLJITIGZK([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool KMMLDTZMIVP([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool SWTPKHYFBEV([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "24")]
		bool HXDYNQCERSU(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool CHCYRGWSOEY([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		bool DDHSLFOECCH([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool RYXVHPSQMTN([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		bool ROLYLIRKIZC([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		bool PDDVINBBLBA(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool IXMPFMDSOOT([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "31")]
		bool HBPSWVKAJGD([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		bool WDFUJOEOEFG([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "33")]
		bool IPNHCGZKSLZ([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool UQBSBZLMISC([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "35")]
		string ZPWBXRKALNA(OnlineRestrictionsSources a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class APFFPLWMOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1850", Offset = "0x9DD0850", VA = "0x189DD1850")]
		public static bool TJHXPYIOIGS(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9DD06A0", Offset = "0x9DCF6A0", VA = "0x189DD06A0")]
		public static bool CRTXRZUYERR(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1DE0", Offset = "0x9DD0DE0", VA = "0x189DD1DE0")]
		public static bool ZUICRIERSND(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DD16F0", Offset = "0x9DD06F0", VA = "0x189DD16F0")]
		public static bool SIYUKQPRAAI(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9DD19C0", Offset = "0x9DD09C0", VA = "0x189DD19C0")]
		public static bool TYKBNLXUQEO(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1120", Offset = "0x9DD0120", VA = "0x189DD1120")]
		public static bool JGGVLSQLJAC(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1C80", Offset = "0x9DD0C80", VA = "0x189DD1C80")]
		public static bool WJWUTMHHZWA(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9DD14C0", Offset = "0x9DD04C0", VA = "0x189DD14C0")]
		public static bool RFYEJMGRTHT(this BEXQCYIXEDV a, PlayerRelationships b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD0970", Offset = "0x9DCF970", VA = "0x189DD0970")]
		public static bool EKHCDSFIIAC(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9DD0540", Offset = "0x9DCF540", VA = "0x189DD0540")]
		public static bool CFYBRIGYPXZ(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9DD03C0", Offset = "0x9DCF3C0", VA = "0x189DD03C0")]
		public static bool BOZLBMPAQZU(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9DD0D90", Offset = "0x9DCFD90", VA = "0x189DD0D90")]
		public static bool HQZIGVCJQTV(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9DD0810", Offset = "0x9DCF810", VA = "0x189DD0810")]
		public static bool DAIJARSNKFT(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9DD0AD0", Offset = "0x9DCFAD0", VA = "0x189DD0AD0")]
		public static bool GUZUNZEUKAY(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9DD0C30", Offset = "0x9DCFC30", VA = "0x189DD0C30")]
		public static bool HGLPPPUZDDM(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9DD0A20", Offset = "0x9DCFA20", VA = "0x189DD0A20")]
		public static bool ENKLJBSLOXZ(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1B20", Offset = "0x9DD0B20", VA = "0x189DD1B20")]
		public static bool UYJHHJLGRWS(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1070", Offset = "0x9DD0070", VA = "0x189DD1070")]
		public static bool JDBLHVMNFTU(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9DD0470", Offset = "0x9DCF470", VA = "0x189DD0470")]
		public static bool CCYINPMPKPB(this BEXQCYIXEDV a, CreationRooms b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1330", Offset = "0x9DD0330", VA = "0x189DD1330")]
		public static bool OQNGBOZRCYK(this BEXQCYIXEDV a, DrawingRooms b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1280", Offset = "0x9DD0280", VA = "0x189DD1280")]
		public static bool OJOEZAEVAXH(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9DD0310", Offset = "0x9DCF310", VA = "0x189DD0310")]
		public static bool BJTAGDAMBGN(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9DD0CE0", Offset = "0x9DCFCE0", VA = "0x189DD0CE0")]
		public static bool HIYRQBUHPAE(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1D30", Offset = "0x9DD0D30", VA = "0x189DD1D30")]
		public static bool YXSLJITIGZK(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD11D0", Offset = "0x9DD01D0", VA = "0x189DD11D0")]
		public static bool KMMLDTZMIVP(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9DD17A0", Offset = "0x9DD07A0", VA = "0x189DD17A0")]
		public static bool SWTPKHYFBEV(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9DD0E40", Offset = "0x9DCFE40", VA = "0x189DD0E40")]
		public static bool HXDYNQCERSU(this BEXQCYIXEDV a, SharecamVisibleObjects b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9DD05F0", Offset = "0x9DCF5F0", VA = "0x189DD05F0")]
		public static bool CHCYRGWSOEY(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9DD08C0", Offset = "0x9DCF8C0", VA = "0x189DD08C0")]
		public static bool DDHSLFOECCH(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1640", Offset = "0x9DD0640", VA = "0x189DD1640")]
		public static bool RYXVHPSQMTN(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1590", Offset = "0x9DD0590", VA = "0x189DD1590")]
		public static bool ROLYLIRKIZC(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1400", Offset = "0x9DD0400", VA = "0x189DD1400")]
		public static bool PDDVINBBLBA(this BEXQCYIXEDV a, UGCPublishedClubAnnouncements b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9DD0FC0", Offset = "0x9DCFFC0", VA = "0x189DD0FC0")]
		public static bool IXMPFMDSOOT(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9DD0B80", Offset = "0x9DCFB80", VA = "0x189DD0B80")]
		public static bool HBPSWVKAJGD(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1BD0", Offset = "0x9DD0BD0", VA = "0x189DD1BD0")]
		public static bool WDFUJOEOEFG(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9DD0F10", Offset = "0x9DCFF10", VA = "0x189DD0F10")]
		public static bool IPNHCGZKSLZ(this BEXQCYIXEDV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A70", Offset = "0x9DD0A70", VA = "0x189DD1A70")]
		public static bool UQBSBZLMISC(this BEXQCYIXEDV a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum PlayerRelationshipsFlags : byte
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
	public enum AllowedPlayerRelationships : byte
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
	public enum CreationRooms : byte
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
	public enum DrawingRooms : byte
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
	public enum SharecamVisibleObjects : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		RegularObjects = 2,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		ConditionallyRestrictedObjects = 6
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum UGCPublishedClubAnnouncements
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		UnblockedCreators = 2,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		All = 6
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface HZJYCFMSXGS
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		OnlineRestrictionsSources GBJCTTUXSMN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool ZUICRIERSND
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool SIYUKQPRAAI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool TYKBNLXUQEO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool JGGVLSQLJAC
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		AllowedPlayerRelationships DBKQJNJHIHE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool EKHCDSFIIAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool CFYBRIGYPXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool BOZLBMPAQZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool HQZIGVCJQTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool DAIJARSNKFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool GUZUNZEUKAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool HGLPPPUZDDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool ENKLJBSLOXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool UYJHHJLGRWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		bool JDBLHVMNFTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		CreationRooms TARUFPKXFFR
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		DrawingRooms LNEFZKYOSRA
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		bool OJOEZAEVAXH
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool BJTAGDAMBGN
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool HIYRQBUHPAE
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool YXSLJITIGZK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool KMMLDTZMIVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool SWTPKHYFBEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		SharecamVisibleObjects KUDHYNXVOKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		bool CHCYRGWSOEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool DDHSLFOECCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool RYXVHPSQMTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool ROLYLIRKIZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		UGCPublishedClubAnnouncements WNJCNCKKTDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool IXMPFMDSOOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool HBPSWVKAJGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool WDFUJOEOEFG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IPNHCGZKSLZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool UQBSBZLMISC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class OnlineRestrictionsProvider
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1E90", Offset = "0x9DD0E90", VA = "0x189DD1E90")]
		public static string QTCZTVPWPFC(OnlineRestrictionsSources a)
		{
			return null;
		}
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
