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
	public interface HNOFUIUXRAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XCCDQAVEOSQ([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool WHHRARMYVCT([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool XFYLKDUNPXJ([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool YLHFJYTGYTN([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool ZNTJKDYLFET([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HIWWCVFLPSA(PlayerRelationships a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool ZIVDBLRADVT([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool LWBTTLVMQRC([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool LGXEUHZPMJV([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool GHMNJTSGKUM([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool KKGCKKBSKLU([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool RWQBHKCJWKF([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool KDYRDENKUCF([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool XJLSAWGHRDQ([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool MVDUJAETDAN([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool FGSWULHSTIP([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool QDXDBTQLHLU(CreationRooms a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool FJNZMQQKOQJ(DrawingRooms a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool ESQXJJHXMEG([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool PCQDJWYBWBU([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "20")]
		bool CZRCIPQOPPN([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool ZZPPNRCLEIV([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool IIOHVORBBMA([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool FBSKDFFOFNK([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "24")]
		bool XRTMBBGNEXP(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool FSJXMRXXAWP([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		bool VGTEWENKAVS([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool ONMBJYHYLLE([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		bool OIROFRDHXWJ([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		bool KWQFKHAUOMX(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool OZRNBXEJKOS([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "31")]
		bool EPDOQBOTVMG([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "32")]
		bool XCFIHTUMMPL([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "33")]
		bool IYOCFBBFMTG([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool LJOUGSOCYUX([Out] OnlineRestrictionsSources a);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "35")]
		string WNIIEWYVWNJ(OnlineRestrictionsSources a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class LXCVGXCNNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8596030", Offset = "0x8594C30", VA = "0x188596030")]
		public static bool EMCJWLNKDMN(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8596690", Offset = "0x8595290", VA = "0x188596690")]
		public static bool GIZLDSBFLPO(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85974C0", Offset = "0x85960C0", VA = "0x1885974C0")]
		public static bool XCCDQAVEOSQ(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8597410", Offset = "0x8596010", VA = "0x188597410")]
		public static bool WHHRARMYVCT(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8597620", Offset = "0x8596220", VA = "0x188597620")]
		public static bool XFYLKDUNPXJ(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8597850", Offset = "0x8596450", VA = "0x188597850")]
		public static bool YLHFJYTGYTN(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85979B0", Offset = "0x85965B0", VA = "0x1885979B0")]
		public static bool ZNTJKDYLFET(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8596800", Offset = "0x8595400", VA = "0x188596800")]
		public static bool HIWWCVFLPSA(this HNOFUIUXRAK a, PlayerRelationships b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8597900", Offset = "0x8596500", VA = "0x188597900")]
		public static bool ZIVDBLRADVT(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8596DC0", Offset = "0x85959C0", VA = "0x188596DC0")]
		public static bool LWBTTLVMQRC(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8596C60", Offset = "0x8595860", VA = "0x188596C60")]
		public static bool LGXEUHZPMJV(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85965E0", Offset = "0x85951E0", VA = "0x1885965E0")]
		public static bool GHMNJTSGKUM(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8596AE0", Offset = "0x85956E0", VA = "0x188596AE0")]
		public static bool KKGCKKBSKLU(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85972B0", Offset = "0x8595EB0", VA = "0x1885972B0")]
		public static bool RWQBHKCJWKF(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8596A30", Offset = "0x8595630", VA = "0x188596A30")]
		public static bool KDYRDENKUCF(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85976D0", Offset = "0x85962D0", VA = "0x1885976D0")]
		public static bool XJLSAWGHRDQ(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8596E70", Offset = "0x8595A70", VA = "0x188596E70")]
		public static bool MVDUJAETDAN(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85963B0", Offset = "0x8594FB0", VA = "0x1885963B0")]
		public static bool FGSWULHSTIP(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85971E0", Offset = "0x8595DE0", VA = "0x1885971E0")]
		public static bool QDXDBTQLHLU(this HNOFUIUXRAK a, CreationRooms b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8596460", Offset = "0x8595060", VA = "0x188596460")]
		public static bool FJNZMQQKOQJ(this HNOFUIUXRAK a, DrawingRooms b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8596250", Offset = "0x8594E50", VA = "0x188596250")]
		public static bool ESQXJJHXMEG(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8597130", Offset = "0x8595D30", VA = "0x188597130")]
		public static bool PCQDJWYBWBU(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8595F80", Offset = "0x8594B80", VA = "0x188595F80")]
		public static bool CZRCIPQOPPN(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8597A60", Offset = "0x8596660", VA = "0x188597A60")]
		public static bool ZZPPNRCLEIV(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85968D0", Offset = "0x85954D0", VA = "0x1885968D0")]
		public static bool IIOHVORBBMA(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8596300", Offset = "0x8594F00", VA = "0x188596300")]
		public static bool FBSKDFFOFNK(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8597780", Offset = "0x8596380", VA = "0x188597780")]
		public static bool XRTMBBGNEXP(this HNOFUIUXRAK a, SharecamVisibleObjects b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8596530", Offset = "0x8595130", VA = "0x188596530")]
		public static bool FSJXMRXXAWP(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8597360", Offset = "0x8595F60", VA = "0x188597360")]
		public static bool VGTEWENKAVS(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8596FD0", Offset = "0x8595BD0", VA = "0x188596FD0")]
		public static bool ONMBJYHYLLE(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8596F20", Offset = "0x8595B20", VA = "0x188596F20")]
		public static bool OIROFRDHXWJ(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8596B90", Offset = "0x8595790", VA = "0x188596B90")]
		public static bool KWQFKHAUOMX(this HNOFUIUXRAK a, UGCPublishedClubAnnouncements b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8597080", Offset = "0x8595C80", VA = "0x188597080")]
		public static bool OZRNBXEJKOS(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85961A0", Offset = "0x8594DA0", VA = "0x1885961A0")]
		public static bool EPDOQBOTVMG(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8597570", Offset = "0x8596170", VA = "0x188597570")]
		public static bool XCFIHTUMMPL(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8596980", Offset = "0x8595580", VA = "0x188596980")]
		public static bool IYOCFBBFMTG(this HNOFUIUXRAK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8596D10", Offset = "0x8595910", VA = "0x188596D10")]
		public static bool LJOUGSOCYUX(this HNOFUIUXRAK a)
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
	public interface LGFJXHSVAPV
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		OnlineRestrictionsSources KBDGUUKJAKG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool XCCDQAVEOSQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool WHHRARMYVCT
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool XFYLKDUNPXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool YLHFJYTGYTN
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		AllowedPlayerRelationships SDXDXQNEGXT
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool ZIVDBLRADVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool LWBTTLVMQRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool LGXEUHZPMJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool GHMNJTSGKUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool KKGCKKBSKLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool RWQBHKCJWKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool KDYRDENKUCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool XJLSAWGHRDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool MVDUJAETDAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		bool FGSWULHSTIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		CreationRooms GQAXYMEVIIS
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		DrawingRooms XQXMOFLQSBL
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		bool ESQXJJHXMEG
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool PCQDJWYBWBU
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool CZRCIPQOPPN
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool ZZPPNRCLEIV
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool IIOHVORBBMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool FBSKDFFOFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		SharecamVisibleObjects QRJXSETYTUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		bool FSJXMRXXAWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool VGTEWENKAVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool ONMBJYHYLLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool OIROFRDHXWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		UGCPublishedClubAnnouncements XDNXZUMLOJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		bool OZRNBXEJKOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool EPDOQBOTVMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool XCFIHTUMMPL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IYOCFBBFMTG
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool LJOUGSOCYUX
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
		[Cpp2IlInjected.Address(RVA = "0x8597B10", Offset = "0x8596710", VA = "0x188597B10")]
		public static string AWLDTLORQTZ(OnlineRestrictionsSources a)
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
