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
	public interface NOWXTHPZPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BTMRMKBYTVS([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SWPGHYNQTQL([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KSBMTCPHFBB([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool CDYGERBCOYX([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool UXQKUKKHWVR([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool APIZHQWBWNC(PlayerRelationships a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool HDFCPVBJEZL([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool KFENJNAHMQA([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool VIHJXTTKDNV([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool UMLRACJNFVK([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool CTMSULXLVPU([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool LWOTWVXYOKR([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool DTTVLVDVYNT([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool VLQJUPCORWW([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool FGDFVDVUTZX([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool QBGXVRLLQDB([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool BUEXAYSKSDM(CreationRooms a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool HYFQTGYTGVT(DrawingRooms a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool PYQHLZWOYXE([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool XMGCJYXMFDY([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "20")]
		bool WGOUZPFWBZF([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool PGFSAYQZIDL([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool VXSMPQAUWLS([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool DSWTHXELRGE([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "24")]
		bool TLCGXKFNJUN(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool INORNJPOHJB([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		bool XAFPNLUEISE([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool CCVYLXLTWFQ([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		bool SEFSFQNCXXT([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		bool JKGVPPCWGXV(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool KFWLRZRLHLY([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "31")]
		bool YFUUSEMQRTU([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		bool BETPBZFPHVH([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "33")]
		bool FQNJNGSCNHW([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool SPYEUBXSXLB([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "35")]
		string TNEUQHGSQFN(OnlineRestrictionsSources a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class IBYPANWEWQV
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86C42F0", Offset = "0x86C2AF0", VA = "0x1886C42F0")]
		public static bool VFOKIFZCVVX(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86C3570", Offset = "0x86C1D70", VA = "0x1886C3570")]
		public static bool FSLDDHHYALW(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x86C2F20", Offset = "0x86C1720", VA = "0x1886C2F20")]
		public static bool BTMRMKBYTVS(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86C4010", Offset = "0x86C2810", VA = "0x1886C4010")]
		public static bool SWPGHYNQTQL(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86C3B40", Offset = "0x86C2340", VA = "0x1886C3B40")]
		public static bool KSBMTCPHFBB(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86C3150", Offset = "0x86C1950", VA = "0x1886C3150")]
		public static bool CDYGERBCOYX(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86C4240", Offset = "0x86C2A40", VA = "0x1886C4240")]
		public static bool UXQKUKKHWVR(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x86C2DA0", Offset = "0x86C15A0", VA = "0x1886C2DA0")]
		public static bool APIZHQWBWNC(this NOWXTHPZPLA a, PlayerRelationships b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86C36E0", Offset = "0x86C1EE0", VA = "0x1886C36E0")]
		public static bool HDFCPVBJEZL(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86C39E0", Offset = "0x86C21E0", VA = "0x1886C39E0")]
		public static bool KFENJNAHMQA(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x86C4460", Offset = "0x86C2C60", VA = "0x1886C4460")]
		public static bool VIHJXTTKDNV(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x86C4190", Offset = "0x86C2990", VA = "0x1886C4190")]
		public static bool UMLRACJNFVK(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x86C3200", Offset = "0x86C1A00", VA = "0x1886C3200")]
		public static bool CTMSULXLVPU(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x86C3BF0", Offset = "0x86C23F0", VA = "0x1886C3BF0")]
		public static bool LWOTWVXYOKR(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x86C3360", Offset = "0x86C1B60", VA = "0x1886C3360")]
		public static bool DTTVLVDVYNT(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x86C4510", Offset = "0x86C2D10", VA = "0x1886C4510")]
		public static bool VLQJUPCORWW(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86C3410", Offset = "0x86C1C10", VA = "0x1886C3410")]
		public static bool FGDFVDVUTZX(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86C3E00", Offset = "0x86C2600", VA = "0x1886C3E00")]
		public static bool QBGXVRLLQDB(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86C2FD0", Offset = "0x86C17D0", VA = "0x1886C2FD0")]
		public static bool BUEXAYSKSDM(this NOWXTHPZPLA a, CreationRooms b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86C3790", Offset = "0x86C1F90", VA = "0x1886C3790")]
		public static bool HYFQTGYTGVT(this NOWXTHPZPLA a, DrawingRooms b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86C3D50", Offset = "0x86C2550", VA = "0x1886C3D50")]
		public static bool PYQHLZWOYXE(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x86C47D0", Offset = "0x86C2FD0", VA = "0x1886C47D0")]
		public static bool XMGCJYXMFDY(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x86C4670", Offset = "0x86C2E70", VA = "0x1886C4670")]
		public static bool WGOUZPFWBZF(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86C3CA0", Offset = "0x86C24A0", VA = "0x1886C3CA0")]
		public static bool PGFSAYQZIDL(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x86C45C0", Offset = "0x86C2DC0", VA = "0x1886C45C0")]
		public static bool VXSMPQAUWLS(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x86C32B0", Offset = "0x86C1AB0", VA = "0x1886C32B0")]
		public static bool DSWTHXELRGE(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x86C40C0", Offset = "0x86C28C0", VA = "0x1886C40C0")]
		public static bool TLCGXKFNJUN(this NOWXTHPZPLA a, SharecamVisibleObjects b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x86C3860", Offset = "0x86C2060", VA = "0x1886C3860")]
		public static bool INORNJPOHJB(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x86C4720", Offset = "0x86C2F20", VA = "0x1886C4720")]
		public static bool XAFPNLUEISE(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x86C30A0", Offset = "0x86C18A0", VA = "0x1886C30A0")]
		public static bool CCVYLXLTWFQ(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x86C3EB0", Offset = "0x86C26B0", VA = "0x1886C3EB0")]
		public static bool SEFSFQNCXXT(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86C3910", Offset = "0x86C2110", VA = "0x1886C3910")]
		public static bool JKGVPPCWGXV(this NOWXTHPZPLA a, UGCPublishedClubAnnouncements b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86C3A90", Offset = "0x86C2290", VA = "0x1886C3A90")]
		public static bool KFWLRZRLHLY(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86C4880", Offset = "0x86C3080", VA = "0x1886C4880")]
		public static bool YFUUSEMQRTU(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x86C2E70", Offset = "0x86C1670", VA = "0x1886C2E70")]
		public static bool BETPBZFPHVH(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x86C34C0", Offset = "0x86C1CC0", VA = "0x1886C34C0")]
		public static bool FQNJNGSCNHW(this NOWXTHPZPLA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x86C3F60", Offset = "0x86C2760", VA = "0x1886C3F60")]
		public static bool SPYEUBXSXLB(this NOWXTHPZPLA a)
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
	public interface LAXFXHTLWBV
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		OnlineRestrictionsSources ZIRLVQYXIOK
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool BTMRMKBYTVS
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool SWPGHYNQTQL
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool KSBMTCPHFBB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool CDYGERBCOYX
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		AllowedPlayerRelationships GHHBTFQKLZX
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool HDFCPVBJEZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool KFENJNAHMQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool VIHJXTTKDNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool UMLRACJNFVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool CTMSULXLVPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool LWOTWVXYOKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool DTTVLVDVYNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool VLQJUPCORWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool FGDFVDVUTZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		bool QBGXVRLLQDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		CreationRooms PAOSUIJTIKC
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		DrawingRooms GDTBGBOLICN
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		bool PYQHLZWOYXE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool XMGCJYXMFDY
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool WGOUZPFWBZF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool PGFSAYQZIDL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool VXSMPQAUWLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool DSWTHXELRGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		SharecamVisibleObjects JERXKQXLTPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		bool INORNJPOHJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool XAFPNLUEISE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool CCVYLXLTWFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool SEFSFQNCXXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		UGCPublishedClubAnnouncements LXAWUQNFXUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool KFWLRZRLHLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool YFUUSEMQRTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool BETPBZFPHVH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool FQNJNGSCNHW
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool SPYEUBXSXLB
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
		[Cpp2IlInjected.Address(RVA = "0x86C4930", Offset = "0x86C3130", VA = "0x1886C4930")]
		public static string WWAJTOSIQZR(OnlineRestrictionsSources a)
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
