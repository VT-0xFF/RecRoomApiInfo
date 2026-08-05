using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;
using RecRoom.Networking.DataTypes;
using RecRoom.NoEngine.DataStructures;
using RecRoom.RendererV1;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class HFEHDULRWXM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly PlayerRoomInventoryOperationResult JXQUNSAPXOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly long MAXRYHRIEQH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int NBKIBRXHVQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8CEDD20", Offset = "0x8CEC320", VA = "0x188CEDD20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8CEDD30", Offset = "0x8CEC330", VA = "0x188CEDD30")]
		public HFEHDULRWXM(PlayerRoomInventoryOperationResult a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum RoomInventoryItemVisibility
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		HiddenWhenNone,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Hidden,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		AlwaysVisibleOnceOwned,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		AlwaysVisible
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface PYUZBYGKVAL
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		ENIVEIKFIDY QBSMYQOCZYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		YQBTYEHUFCJ<RoomInventoryItem> VJTCGTHWLIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		YQBTYEHUFCJ<Guid> SICTLHCGZSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		YPLZGKACCUI<PlayerRoomInventoryItem, int> ATULKRAWSVY
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		YQBTYEHUFCJ<XVAYDDNJQZB> PNTWKXDDSKP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		YQBTYEHUFCJ<long> KPRAQXNWIGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ENIVEIKFIDY IEDNFCFQQIE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		ENIVEIKFIDY VYUJSCXVQJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "15")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task<Result<RoomInventoryItem, string>> CreateRoomInventoryItem(Guid? originId, long roomId, string name, string description, string imageName, RoomInventoryItemProperties properties, byte shape, int color, [Optional] List<long> tagIds, [Optional] List<RoomInventoryItemTagDTO> newTags, bool allowRename = false);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task<Result<RoomInventoryItem, string>> UpdateRoomInventoryItem(Guid roomInventoryItemId, long roomId, [Optional] string name, [Optional] string description, [Optional] string imageName, [Optional] List<long> tagIds, [Optional] Dictionary<string, RoomInventoryTagClientProperties> newTags, [Optional] RoomInventoryItemProperties properties, [Optional] byte? shape, [Optional] int? color);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task<Result<bool, string>> QEZBOFTKGAH(Guid a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "19")]
		IReadOnlyList<RoomInventoryItem> VWOHONGSSIY();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "20")]
		IReadOnlyList<RoomInventoryItem> RCELBTBTFXE();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool GKESLZACCBJ();

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool VHVTGARIVXN(Guid a, [Out] RoomInventoryItem b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool SVDURKFEXYV(string a, [Out] RoomInventoryItem b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		IReadOnlyList<PlayerRoomInventoryItem> QADGAPWLAZH();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool VMQZUWXHOAE(Guid a, [Out] PlayerRoomInventoryItem b);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		long? RPJFGYUQQLP(Guid a);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		Task<int> LANUGZEYVFZ(LRIABUPBGVB a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		Task<HFEHDULRWXM> RUKLLCPZKFI(LRIABUPBGVB a, Guid b, int c);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "29")]
		string ZUINHRMOGNJ(PlayerRoomInventoryOperationResult a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool BEYLLWXLKAW();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "31")]
		RoomInventoryItemDTO DehydrateRoomInventoryItemToDTO(RoomInventoryItem inventoryItem);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "32")]
		RoomInventoryItemProperties DeserializeRoomInventoryItemProperties(string serializedRoomInventoryItemPropertyString);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "34")]
		Task<Result<XVAYDDNJQZB, string>> QYTYLXCWDEW(long a, RoomInventoryTagClientProperties b);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task<Result<bool, string>> GZCFQPQMQPK(long a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task<Result<bool, string>> XJXQDIDVNTK(long a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "37")]
		bool MEQCFWJXDQU();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "38")]
		List<(long, int)> JDMLMSPCLNN(long a, int b);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "39")]
		bool UFGVUBOGJVH(long a, [Out] XVAYDDNJQZB b);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "40")]
		bool TMFDGYSGOFZ(string a, [Out] XVAYDDNJQZB b);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "41")]
		bool QVJNQIPPUZA(long a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "42")]
		IReadOnlyList<XVAYDDNJQZB> NUFRONXPRSO();

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "43")]
		List<XVAYDDNJQZB> IAQRHNDBNQY();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "44")]
		IReadOnlyList<XVAYDDNJQZB> OHYMNDDDRJL();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "45")]
		IReadOnlyList<RoomInventoryItem> ZJWAASOZEIZ(long a);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "46")]
		bool KENKPRZXORF(string a, [Out] IReadOnlyList<RoomInventoryItem> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface WXADRAQRQHI : PYUZBYGKVAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UMZEDAFEATD(IEnumerable<PlayerRoomInventoryItemDTO> a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task RHMOWUNNMLZ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class PlayerRoomInventoryItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly Guid NLAOQRYUICX;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long MAXRYHRIEQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8CEDDD0", Offset = "0x8CEC3D0", VA = "0x188CEDDD0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int NBKIBRXHVQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8CEDDE0", Offset = "0x8CEC3E0", VA = "0x188CEDDE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long NFDWWYJBFSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAB14F0", Offset = "0xAAFAF0", VA = "0x180AB14F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public long AGZHMGROJUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAB0760", Offset = "0xAAED60", VA = "0x180AB0760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Guid? FWNLUHQRUTI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAA76E0", Offset = "0xAA5CE0", VA = "0x180AA76E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A80", Offset = "0xAA6080", VA = "0x180AA7A80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool ZEBUYPZJGBF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x167D460", Offset = "0x167BA60", VA = "0x18167D460")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x167D470", Offset = "0x167BA70", VA = "0x18167D470")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8CEDFF0", Offset = "0x8CEC5F0", VA = "0x188CEDFF0")]
		public PlayerRoomInventoryItem(PlayerRoomInventoryItemDTO dto, bool hasEverBeenOwned)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x11625E0", Offset = "0x1160BE0", VA = "0x1811625E0")]
		public PlayerRoomInventoryItem(Guid roomInventoryItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8CEDE00", Offset = "0x8CEC400", VA = "0x188CEDE00")]
		internal bool Update(PlayerRoomInventoryItemDTO dto, long unsavedCountToRemove, Action<PlayerRoomInventoryItem, int> onUpdateCallback)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8CEDD70", Offset = "0x8CEC370", VA = "0x188CEDD70")]
		internal void CPWMFRQIBJA(long a, Action<PlayerRoomInventoryItem, int> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class RoomInventoryItem : IEquatable<RoomInventoryItem>
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public const int MXZQBVLXLET = 3;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public const int ETECNGVTEPP = 40;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public const int AOBHOHEUXQA = 180;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const int GTPOTLUSLRO = 1000;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public const int IXBBIVXRFJK = 10;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Guid NLAOQRYUICX
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xF396D0", Offset = "0xF37CD0", VA = "0x180F396D0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xF396F0", Offset = "0xF37CF0", VA = "0x180F396F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public long FKYOVSPGEAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xE9B380", Offset = "0xE99980", VA = "0x180E9B380")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string CJNFRMHQECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9B0", Offset = "0xAA8FB0", VA = "0x180AAA9B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string ZITZQPTDVBA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAB0F10", Offset = "0xAAF510", VA = "0x180AB0F10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public DateTime TEVOMLILOAN
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x102B5C0", Offset = "0x1029BC0", VA = "0x18102B5C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DateTime ZQEGNAALXRE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x145E270", Offset = "0x145C870", VA = "0x18145E270")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HashSet<long> QNHDTPSVFYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAACAB0", Offset = "0xAAB0B0", VA = "0x180AACAB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public RoomInventoryItemProperties WNAALRPFZAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB080", VA = "0x180AACA80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAACAA0", Offset = "0xAAB0A0", VA = "0x180AACAA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public byte EDITPNQYEUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAB3040", Offset = "0xAB1640", VA = "0x180AB3040")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAB31B0", Offset = "0xAB17B0", VA = "0x180AB31B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ShapeColor HHPEXJZUJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x107F910", Offset = "0x107DF10", VA = "0x18107F910")]
			[CompilerGenerated]
			get
			{
				return default(ShapeColor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x30B2EF0", Offset = "0x30B14F0", VA = "0x1830B2EF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RoomInventoryItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8CEEA90", Offset = "0x8CED090", VA = "0x188CEEA90")]
		public RoomInventoryItem(RoomInventoryItemDTO dto, [Optional] RoomInventoryItemProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE370", Offset = "0x8CEC970", VA = "0x188CEE370", Slot = "4")]
		public bool Equals(RoomInventoryItem other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE4F0", Offset = "0x8CECAF0", VA = "0x188CEE4F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE9B0", Offset = "0x8CECFB0", VA = "0x188CEE9B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE6D0", Offset = "0x8CECCD0", VA = "0x188CEE6D0")]
		private HashSet<long> GGCRZZXVFTF(RoomInventoryItemDTO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class TQOMZDJDNCW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private PlayerRoomInventoryItem NIFLKMZDRRP;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RoomInventoryItem ZRODRVGYEYD
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public PlayerRoomInventoryItem SEWQWABGKLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8CEEE50", Offset = "0x8CED450", VA = "0x188CEEE50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8CEEEE0", Offset = "0x8CED4E0", VA = "0x188CEEEE0")]
		public TQOMZDJDNCW(RoomInventoryItem a, [Optional] PlayerRoomInventoryItem b)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public const int MAX_ACTION_BUTTON_TEXT_LENGTH = 12;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const int QPZLKVQUYDM = 1;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE320", Offset = "0x8CEC920", VA = "0x188CEE320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		internal int QKLWEKEWKXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xAA7720", Offset = "0xAA5D20", VA = "0x180AA7720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x138D000", Offset = "0x138B600", VA = "0x18138D000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x16B4200", Offset = "0x16B2800", VA = "0x1816B4200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RoomInventoryItemVisibility Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9D0", Offset = "0xAA8FD0", VA = "0x180AAA9D0")]
			[CompilerGenerated]
			get
			{
				return default(RoomInventoryItemVisibility);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6A0", Offset = "0xAA9CA0", VA = "0x180AAB6A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBDF360", Offset = "0xBDD960", VA = "0x180BDF360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xF38CA0", Offset = "0xF372A0", VA = "0x180F38CA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xCB5800", Offset = "0xCB3E00", VA = "0x180CB5800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xCB5810", Offset = "0xCB3E10", VA = "0x180CB5810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xFDDEA0", Offset = "0xFDC4A0", VA = "0x180FDDEA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xFDDE90", Offset = "0xFDC490", VA = "0x180FDDE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE180", Offset = "0x8CEC780", VA = "0x188CEE180", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE0A0", Offset = "0x8CEC6A0", VA = "0x188CEE0A0")]
		public static RoomInventoryItemProperties Clone(RoomInventoryItemProperties properties)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE2C0", Offset = "0x8CEC8C0", VA = "0x188CEE2C0")]
		public RoomInventoryItemProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class XVAYDDNJQZB
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public const int UMCNWISVRHI = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private string XXGCTXHYPPE;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static StringBuilder WTFCDJSTPMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private string HBITFAIIGJL;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long KIROQJOHPAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xF20A80", Offset = "0xF1F080", VA = "0x180F20A80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8CEF530", Offset = "0x8CEDB30", VA = "0x188CEF530")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string YHRYJBCAKUU
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8CEF300", Offset = "0x8CED900", VA = "0x188CEF300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public RoomInventoryTagClientProperties WNAALRPFZAR
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool RINZSMTEZVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8CEF560", Offset = "0x8CEDB60", VA = "0x188CEF560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public XVAYDDNJQZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8CEF5F0", Offset = "0x8CEDBF0", VA = "0x188CEF5F0")]
		public XVAYDDNJQZB(RoomInventoryItemTagDTO a, [Optional] RoomInventoryTagClientProperties b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8CEF240", Offset = "0x8CED840", VA = "0x188CEF240")]
		public RoomInventoryItemTagDTO Deyhdrate()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RoomInventoryTagClientProperties
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static RoomInventoryTagClientProperties DefaultNonSortingTab
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8CEEE00", Offset = "0x8CED400", VA = "0x188CEEE00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAA7720", Offset = "0xAA5D20", VA = "0x180AA7720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8CEEBF0", Offset = "0x8CED1F0", VA = "0x188CEEBF0")]
		public void DeserializeFromJson(Dictionary<string, object> json)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RoomInventoryTagClientProperties()
		{
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
