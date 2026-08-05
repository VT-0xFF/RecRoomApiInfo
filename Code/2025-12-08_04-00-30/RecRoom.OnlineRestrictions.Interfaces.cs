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
		[Cpp2IlInjected.Address(RVA = "0x8608680", Offset = "0x8606E80", VA = "0x188608680")]
		public static bool WUHBDVEWMVT(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8607390", Offset = "0x8605B90", VA = "0x188607390")]
		public static bool BBMTWAGQEIM(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8607CA0", Offset = "0x86064A0", VA = "0x188607CA0")]
		public static bool KZSYOSAMMQY(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8608010", Offset = "0x8606810", VA = "0x188608010")]
		public static bool PTHQWZETVBJ(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8608220", Offset = "0x8606A20", VA = "0x188608220")]
		public static bool UEDHLHPOFGP(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8608C50", Offset = "0x8607450", VA = "0x188608C50")]
		public static bool ZCBNOIRQDHF(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8608500", Offset = "0x8606D00", VA = "0x188608500")]
		public static bool VFVKLZCEMFJ(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x86082D0", Offset = "0x8606AD0", VA = "0x1886082D0")]
		public static bool UGAPWDCTGEU(this VZVYRIFALVM a, PlayerRelationships b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8608DB0", Offset = "0x86075B0", VA = "0x188608DB0")]
		public static bool ZVPUNFYXXXL(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86075C0", Offset = "0x8605DC0", VA = "0x1886075C0")]
		public static bool DTWTHQAEWPS(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8607720", Offset = "0x8605F20", VA = "0x188607720")]
		public static bool DYTZNHUFNPZ(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x86079E0", Offset = "0x86061E0", VA = "0x1886079E0")]
		public static bool IYGUPWZIRSY(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8608450", Offset = "0x8606C50", VA = "0x188608450")]
		public static bool VFVDPHTJJUK(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x86080C0", Offset = "0x86068C0", VA = "0x1886080C0")]
		public static bool QCMLZYEZECZ(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8608170", Offset = "0x8606970", VA = "0x188608170")]
		public static bool STYHNQEDAXH(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8608A00", Offset = "0x8607200", VA = "0x188608A00")]
		public static bool YOMRTHZBHTM(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86087F0", Offset = "0x8606FF0", VA = "0x1886087F0")]
		public static bool XTJTADTXJPT(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86088A0", Offset = "0x86070A0", VA = "0x1886088A0")]
		public static bool XUOMFMUHOHJ(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8608B80", Offset = "0x8607380", VA = "0x188608B80")]
		public static bool YRQZHCGYJJM(this VZVYRIFALVM a, CreationRooms b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86085B0", Offset = "0x8606DB0", VA = "0x1886085B0")]
		public static bool VKZXFSVAAIN(this VZVYRIFALVM a, DrawingRooms b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8607670", Offset = "0x8605E70", VA = "0x188607670")]
		public static bool DYPUCLJGVGC(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8607E00", Offset = "0x8606600", VA = "0x188607E00")]
		public static bool MVHLFYIRGXM(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8607EB0", Offset = "0x86066B0", VA = "0x188607EB0")]
		public static bool MYYHWFJXVCL(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86077D0", Offset = "0x8605FD0", VA = "0x1886077D0")]
		public static bool EHZNUIRCQHD(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8607BF0", Offset = "0x86063F0", VA = "0x188607BF0")]
		public static bool KBJXFWSIBRS(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8607A90", Offset = "0x8606290", VA = "0x188607A90")]
		public static bool JGETYTSROWI(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8608AB0", Offset = "0x86072B0", VA = "0x188608AB0")]
		public static bool YPMEWUYBQLD(this VZVYRIFALVM a, SharecamVisibleObjects b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x86072E0", Offset = "0x8605AE0", VA = "0x1886072E0")]
		public static bool AGBHDIFYQMH(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8607B40", Offset = "0x8606340", VA = "0x188607B40")]
		public static bool JWCWLJMJUCE(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8607D50", Offset = "0x8606550", VA = "0x188607D50")]
		public static bool LFSHSHYONZM(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x86083A0", Offset = "0x8606BA0", VA = "0x1886083A0")]
		public static bool UKGRCOZMWFD(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8607500", Offset = "0x8605D00", VA = "0x188607500")]
		public static bool CDAFVKRQYKX(this VZVYRIFALVM a, UGCPublishedClubAnnouncements b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8608D00", Offset = "0x8607500", VA = "0x188608D00")]
		public static bool ZKITWTRVZAW(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8607880", Offset = "0x8606080", VA = "0x188607880")]
		public static bool FTUKLEPRXFY(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8607F60", Offset = "0x8606760", VA = "0x188607F60")]
		public static bool OWYXPKADEKZ(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8608950", Offset = "0x8607150", VA = "0x188608950")]
		public static bool YLHGRPZRZLO(this VZVYRIFALVM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8607930", Offset = "0x8606130", VA = "0x188607930")]
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
		[Cpp2IlInjected.Address(RVA = "0x8608E60", Offset = "0x8607660", VA = "0x188608E60")]
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
