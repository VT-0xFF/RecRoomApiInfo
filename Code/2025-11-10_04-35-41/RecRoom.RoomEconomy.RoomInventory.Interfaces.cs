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
	public class NYBIUOLCZOQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly PlayerRoomInventoryOperationResult PKTGOURPEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly long ULFDSOUXGUF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int QIPSPOOLRIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8A6E4D0", Offset = "0x8A6D8D0", VA = "0x188A6E4D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E4E0", Offset = "0x8A6D8E0", VA = "0x188A6E4E0")]
		public NYBIUOLCZOQ(PlayerRoomInventoryOperationResult a, long b)
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
	public interface UEWAZXBYSSB
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		NHBLQESUHLS WXBUKHEGJLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		KBLPOZGJAAH<RoomInventoryItem> VOLZRJDHQRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		KBLPOZGJAAH<Guid> YZIZAKSFGQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		KBQWMGAGJLQ<PlayerRoomInventoryItem, int> AOBLSNXXGSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		KBLPOZGJAAH<DEOXDCBERUJ> XKIWPMIUFZH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		KBLPOZGJAAH<long> ZZYNMCTYSUK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		NHBLQESUHLS SOEAFHUFACG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		NHBLQESUHLS WRSRXAQPGEB
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
		Task<Result<bool, string>> JSVVVJWGGWV(Guid a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "19")]
		IReadOnlyList<RoomInventoryItem> VKLPEQQHMPU();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "20")]
		IReadOnlyList<RoomInventoryItem> NRSPFYNVSZO();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool MCNDYQQIIOJ();

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool FUJWVQQRBEZ(Guid a, [Out] RoomInventoryItem b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool ESWUVCPJXOT(string a, [Out] RoomInventoryItem b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		IReadOnlyList<PlayerRoomInventoryItem> GQPUPHCLFJZ();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool DBFCERKHGSS(Guid a, [Out] PlayerRoomInventoryItem b);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		long? FNCEZRVZNFV(Guid a);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "27")]
		Task<int> KQSSYUAKCKJ(JCSDFORPEFX a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		Task<NYBIUOLCZOQ> FTWWAZXWMDC(JCSDFORPEFX a, Guid b, int c);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "29")]
		string MGYENKYVVEN(PlayerRoomInventoryOperationResult a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool USHDGJOWDGY();

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
		Task<Result<DEOXDCBERUJ, string>> VTIVEXPOFYY(long a, RoomInventoryTagClientProperties b);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task<Result<bool, string>> FWYGSMSUWYS(long a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task<Result<bool, string>> YYYJORDCYNM(long a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "37")]
		bool BAGOORQIRQG();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "38")]
		List<(long, int)> QZZUDDJZJOV(long a, int b);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "39")]
		bool QAVRDLBNDSH(long a, [Out] DEOXDCBERUJ b);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "40")]
		bool ZMZIPTFIWLT(string a, [Out] DEOXDCBERUJ b);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "41")]
		bool YNOWAZGAWRW(long a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "42")]
		IReadOnlyList<DEOXDCBERUJ> PLQXCBOFOTW();

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "43")]
		List<DEOXDCBERUJ> ZLFHEXXFJXM();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "44")]
		IReadOnlyList<DEOXDCBERUJ> LZMBCLTRYGD();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "45")]
		IReadOnlyList<RoomInventoryItem> NWYOQUNXHNR(long a);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "46")]
		bool EQKTFTPUODL(string a, [Out] IReadOnlyList<RoomInventoryItem> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface SETQHPFBELC : UEWAZXBYSSB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GRUOVWKLKGH(IEnumerable<PlayerRoomInventoryItemDTO> a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task ZCMAHJASQQN();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class PlayerRoomInventoryItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly Guid TCGGBITIKEV;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long ULFDSOUXGUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8A6E580", Offset = "0x8A6D980", VA = "0x188A6E580")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int QIPSPOOLRIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8A6E780", Offset = "0x8A6DB80", VA = "0x188A6E780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long FPNGEVDEDGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAAA860", Offset = "0xAA9C60", VA = "0x180AAA860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public long IANWDMCGLCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAAF810", Offset = "0xAAEC10", VA = "0x180AAF810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Guid? QQDOJXEOTKY
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB200", Offset = "0xAAA600", VA = "0x180AAB200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB180", Offset = "0xAAA580", VA = "0x180AAB180")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool INNRZHIOCNT
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1317310", Offset = "0x1316710", VA = "0x181317310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x1317320", Offset = "0x1316720", VA = "0x181317320")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E7A0", Offset = "0x8A6DBA0", VA = "0x188A6E7A0")]
		public PlayerRoomInventoryItem(PlayerRoomInventoryItemDTO dto, bool hasEverBeenOwned)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xE21890", Offset = "0xE20C90", VA = "0x180E21890")]
		public PlayerRoomInventoryItem(Guid roomInventoryItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E590", Offset = "0x8A6D990", VA = "0x188A6E590")]
		internal bool Update(PlayerRoomInventoryItemDTO dto, long unsavedCountToRemove, Action<PlayerRoomInventoryItem, int> onUpdateCallback)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E520", Offset = "0x8A6D920", VA = "0x188A6E520")]
		internal void BGSLSZHRAZG(long a, Action<PlayerRoomInventoryItem, int> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class RoomInventoryItem : IEquatable<RoomInventoryItem>
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public const int BQBGADBPWMZ = 3;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public const int PZZZSPNPFJF = 40;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public const int YJAICNZUNNI = 180;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const int HDQXVOXQKIS = 1000;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public const int PYMGIOIYZRM = 10;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Guid TCGGBITIKEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xBAF500", Offset = "0xBAE900", VA = "0x180BAF500")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xBAF520", Offset = "0xBAE920", VA = "0x180BAF520")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public long QLBYKZXPOPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xB30430", Offset = "0xB2F830", VA = "0x180B30430")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string GMFMFQRLLWI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public DateTime UDOVAFHSSST
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xCDACA0", Offset = "0xCDA0A0", VA = "0x180CDACA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DateTime UDCYYIRTJHG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x10D7F70", Offset = "0x10D7370", VA = "0x1810D7F70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HashSet<long> MNDMBBVMPDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public RoomInventoryItemProperties OIQYBIQLCLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public byte JNGIBUAPTOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAA9F30", Offset = "0xAA9330", VA = "0x180AA9F30")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAAA040", Offset = "0xAA9440", VA = "0x180AAA040")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ShapeColor BBHCWBJOSMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xD05450", Offset = "0xD04850", VA = "0x180D05450")]
			[CompilerGenerated]
			get
			{
				return default(ShapeColor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2E36D10", Offset = "0x2E36110", VA = "0x182E36D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomInventoryItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8A6F620", Offset = "0x8A6EA20", VA = "0x188A6F620")]
		public RoomInventoryItem(RoomInventoryItemDTO dto, [Optional] RoomInventoryItemProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8A6EF00", Offset = "0x8A6E300", VA = "0x188A6EF00", Slot = "4")]
		public bool Equals(RoomInventoryItem other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8A6F080", Offset = "0x8A6E480", VA = "0x188A6F080", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8A6F260", Offset = "0x8A6E660", VA = "0x188A6F260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8A6F340", Offset = "0x8A6E740", VA = "0x188A6F340")]
		private HashSet<long> SINGCJAMBKJ(RoomInventoryItemDTO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class QVVRRXKYRNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private PlayerRoomInventoryItem EPDUDYDCAMT;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RoomInventoryItem XKWPASHMNYN
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public PlayerRoomInventoryItem VDABSUXDWLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8A6E850", Offset = "0x8A6DC50", VA = "0x188A6E850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E8E0", Offset = "0x8A6DCE0", VA = "0x188A6E8E0")]
		public QVVRRXKYRNC(RoomInventoryItem a, [Optional] PlayerRoomInventoryItem b)
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
		private const int QLWLQQSLSRK = 1;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8A6EEB0", Offset = "0x8A6E2B0", VA = "0x188A6EEB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		internal int ZRFAADGABRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1021B40", Offset = "0x1020F40", VA = "0x181021B40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x134A610", Offset = "0x1349A10", VA = "0x18134A610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RoomInventoryItemVisibility Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(RoomInventoryItemVisibility);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBC0680", Offset = "0xBBFA80", VA = "0x180BC0680")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBC0B60", Offset = "0xBBFF60", VA = "0x180BC0B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xC75520", Offset = "0xC74920", VA = "0x180C75520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xC75550", Offset = "0xC74950", VA = "0x180C75550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xC75540", Offset = "0xC74940", VA = "0x180C75540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xC75530", Offset = "0xC74930", VA = "0x180C75530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8A6ED10", Offset = "0x8A6E110", VA = "0x188A6ED10", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8A6EC30", Offset = "0x8A6E030", VA = "0x188A6EC30")]
		public static RoomInventoryItemProperties Clone(RoomInventoryItemProperties properties)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8A6EE50", Offset = "0x8A6E250", VA = "0x188A6EE50")]
		public RoomInventoryItemProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class DEOXDCBERUJ
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public const int MXIKBXIJOYM = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private string ZMKIMTJCSMY;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static StringBuilder WIFOTUEIVXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private string GZOVHUSLEOX;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long HRCISFQGLBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB96550", Offset = "0xB95950", VA = "0x180B96550")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8A6E0F0", Offset = "0x8A6D4F0", VA = "0x188A6E0F0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string AMXDXJEJKJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8A6E140", Offset = "0x8A6D540", VA = "0x188A6E140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public RoomInventoryTagClientProperties OIQYBIQLCLN
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool MDGGQCDWVTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8A6E120", Offset = "0x8A6D520", VA = "0x188A6E120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public DEOXDCBERUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E3E0", Offset = "0x8A6D7E0", VA = "0x188A6E3E0")]
		public DEOXDCBERUJ(RoomInventoryItemTagDTO a, [Optional] RoomInventoryTagClientProperties b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8A6E030", Offset = "0x8A6D430", VA = "0x188A6E030")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A6F990", Offset = "0x8A6ED90", VA = "0x188A6F990")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8A6F780", Offset = "0x8A6EB80", VA = "0x188A6F780")]
		public void DeserializeFromJson(Dictionary<string, object> json)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
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
