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
	public interface VZVYRIFALVM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KZSYOSAMMQY([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PTHQWZETVBJ([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool UEDHLHPOFGP([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ZCBNOIRQDHF([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool VFVKLZCEMFJ([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool UGAPWDCTGEU(PlayerRelationships a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool ZVPUNFYXXXL([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool DTWTHQAEWPS([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool DYTZNHUFNPZ([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool IYGUPWZIRSY([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool VFVDPHTJJUK([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool QCMLZYEZECZ([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool STYHNQEDAXH([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool YOMRTHZBHTM([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool XTJTADTXJPT([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool XUOMFMUHOHJ([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool YRQZHCGYJJM(CreationRooms a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool VKZXFSVAAIN(DrawingRooms a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool DYPUCLJGVGC([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool MVHLFYIRGXM([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "20")]
		bool MYYHWFJXVCL([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool EHZNUIRCQHD([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool KBJXFWSIBRS([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool JGETYTSROWI([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "24")]
		bool YPMEWUYBQLD(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool AGBHDIFYQMH([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		bool JWCWLJMJUCE([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool LFSHSHYONZM([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		bool UKGRCOZMWFD([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		bool CDAFVKRQYKX(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool ZKITWTRVZAW([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "31")]
		bool FTUKLEPRXFY([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		bool OWYXPKADEKZ([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "33")]
		bool YLHGRPZRZLO([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool GIXJQMHAYYD([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "35")]
		string ZZFQUBSIBGX(OnlineRestrictionsSources a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class CLWCRPWZFTL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x870ADE0", Offset = "0x87097E0", VA = "0x18870ADE0")]
		public static bool WUHBDVEWMVT(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8709AE0", Offset = "0x87084E0", VA = "0x188709AE0")]
		public static bool BBMTWAGQEIM(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x870A400", Offset = "0x8708E00", VA = "0x18870A400")]
		public static bool KZSYOSAMMQY(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x870A770", Offset = "0x8709170", VA = "0x18870A770")]
		public static bool PTHQWZETVBJ(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x870A980", Offset = "0x8709380", VA = "0x18870A980")]
		public static bool UEDHLHPOFGP(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x870B3B0", Offset = "0x8709DB0", VA = "0x18870B3B0")]
		public static bool ZCBNOIRQDHF(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x870AC60", Offset = "0x8709660", VA = "0x18870AC60")]
		public static bool VFVKLZCEMFJ(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x870AA30", Offset = "0x8709430", VA = "0x18870AA30")]
		public static bool UGAPWDCTGEU(this VZVYRIFALVM a, PlayerRelationships b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x870B510", Offset = "0x8709F10", VA = "0x18870B510")]
		public static bool ZVPUNFYXXXL(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8709D20", Offset = "0x8708720", VA = "0x188709D20")]
		public static bool DTWTHQAEWPS(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8709E80", Offset = "0x8708880", VA = "0x188709E80")]
		public static bool DYTZNHUFNPZ(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x870A140", Offset = "0x8708B40", VA = "0x18870A140")]
		public static bool IYGUPWZIRSY(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x870ABB0", Offset = "0x87095B0", VA = "0x18870ABB0")]
		public static bool VFVDPHTJJUK(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x870A820", Offset = "0x8709220", VA = "0x18870A820")]
		public static bool QCMLZYEZECZ(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x870A8D0", Offset = "0x87092D0", VA = "0x18870A8D0")]
		public static bool STYHNQEDAXH(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x870B160", Offset = "0x8709B60", VA = "0x18870B160")]
		public static bool YOMRTHZBHTM(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x870AF50", Offset = "0x8709950", VA = "0x18870AF50")]
		public static bool XTJTADTXJPT(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x870B000", Offset = "0x8709A00", VA = "0x18870B000")]
		public static bool XUOMFMUHOHJ(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x870B2E0", Offset = "0x8709CE0", VA = "0x18870B2E0")]
		public static bool YRQZHCGYJJM(this VZVYRIFALVM a, CreationRooms b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x870AD10", Offset = "0x8709710", VA = "0x18870AD10")]
		public static bool VKZXFSVAAIN(this VZVYRIFALVM a, DrawingRooms b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8709DD0", Offset = "0x87087D0", VA = "0x188709DD0")]
		public static bool DYPUCLJGVGC(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x870A560", Offset = "0x8708F60", VA = "0x18870A560")]
		public static bool MVHLFYIRGXM(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x870A610", Offset = "0x8709010", VA = "0x18870A610")]
		public static bool MYYHWFJXVCL(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8709F30", Offset = "0x8708930", VA = "0x188709F30")]
		public static bool EHZNUIRCQHD(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x870A350", Offset = "0x8708D50", VA = "0x18870A350")]
		public static bool KBJXFWSIBRS(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x870A1F0", Offset = "0x8708BF0", VA = "0x18870A1F0")]
		public static bool JGETYTSROWI(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x870B210", Offset = "0x8709C10", VA = "0x18870B210")]
		public static bool YPMEWUYBQLD(this VZVYRIFALVM a, SharecamVisibleObjects b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8709A30", Offset = "0x8708430", VA = "0x188709A30")]
		public static bool AGBHDIFYQMH(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x870A2A0", Offset = "0x8708CA0", VA = "0x18870A2A0")]
		public static bool JWCWLJMJUCE(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x870A4B0", Offset = "0x8708EB0", VA = "0x18870A4B0")]
		public static bool LFSHSHYONZM(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x870AB00", Offset = "0x8709500", VA = "0x18870AB00")]
		public static bool UKGRCOZMWFD(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8709C50", Offset = "0x8708650", VA = "0x188709C50")]
		public static bool CDAFVKRQYKX(this VZVYRIFALVM a, UGCPublishedClubAnnouncements b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x870B460", Offset = "0x8709E60", VA = "0x18870B460")]
		public static bool ZKITWTRVZAW(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8709FE0", Offset = "0x87089E0", VA = "0x188709FE0")]
		public static bool FTUKLEPRXFY(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x870A6C0", Offset = "0x87090C0", VA = "0x18870A6C0")]
		public static bool OWYXPKADEKZ(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x870B0B0", Offset = "0x8709AB0", VA = "0x18870B0B0")]
		public static bool YLHGRPZRZLO(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x870A090", Offset = "0x8708A90", VA = "0x18870A090")]
		public static bool GIXJQMHAYYD(this VZVYRIFALVM a)
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
	public interface TUMPDAGUHBR
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		OnlineRestrictionsSources QJCJQZPQAVU
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool KZSYOSAMMQY
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool PTHQWZETVBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool UEDHLHPOFGP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool ZCBNOIRQDHF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		AllowedPlayerRelationships CPHLLFWCAWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool ZVPUNFYXXXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool DTWTHQAEWPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool DYTZNHUFNPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool IYGUPWZIRSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool VFVDPHTJJUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool QCMLZYEZECZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool STYHNQEDAXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool YOMRTHZBHTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool XTJTADTXJPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		bool XUOMFMUHOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		CreationRooms NJMDMJGCOLA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		DrawingRooms NRPBJIICMAR
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		bool DYPUCLJGVGC
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool MVHLFYIRGXM
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool MYYHWFJXVCL
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool EHZNUIRCQHD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool KBJXFWSIBRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool JGETYTSROWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		SharecamVisibleObjects PNRNHCCJXLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		bool AGBHDIFYQMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool JWCWLJMJUCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool LFSHSHYONZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool UKGRCOZMWFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		UGCPublishedClubAnnouncements RXAPNLNJBME
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool ZKITWTRVZAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool FTUKLEPRXFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool OWYXPKADEKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool YLHGRPZRZLO
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool GIXJQMHAYYD
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
		[Cpp2IlInjected.Address(RVA = "0x870B5C0", Offset = "0x8709FC0", VA = "0x18870B5C0")]
		public static string WXALJCWMHBN(OnlineRestrictionsSources a)
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
