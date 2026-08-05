using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.Networking.DataTypes;
using RecRoom.NoEngine.DataStructures;
using RecRoom.RendererV1;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class BBDHVXPTRNS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly PlayerRoomInventoryOperationResult EQMIYNLIKMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly long XKLXOHCJQTX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int URBXLBTIEQG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA1AF550", Offset = "0xA1AE550", VA = "0x18A1AF550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1AF560", Offset = "0xA1AE560", VA = "0x18A1AF560")]
		public BBDHVXPTRNS(PlayerRoomInventoryOperationResult a, long b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum RoomInventoryItemVisibility
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		HiddenWhenNone,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		Hidden,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		AlwaysVisibleOnceOwned,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		AlwaysVisible
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class HGNSYEBICQX
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA1AFA70", Offset = "0xA1AEA70", VA = "0x18A1AFA70")]
		public static bool CPFGOVXGTZI(this RoomInventoryItemVisibility a, PlayerRoomInventoryItem b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface RIOMKQYFAJL
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		FYRDCSIKYKI TEWBWETMFAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		BQFVKUSIMFN<RoomInventoryItem> SCUNTJVFSBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		BQFVKUSIMFN<Guid> ORPUDBGBVHT
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		BQLCIBMFVQW<PlayerRoomInventoryItem, int> YCNIAEFQNCY
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		BQFVKUSIMFN<FYVWDLQIVIR> WTXFAZISEVT
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		BQFVKUSIMFN<long> TYIBGIZJABI
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		FYRDCSIKYKI THPJXQKKXKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		FYRDCSIKYKI MSTQCIRSAHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "15")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task<Result<RoomInventoryItem, string>> CreateRoomInventoryItem(Guid? originId, long roomId, string name, string description, string imageName, RoomInventoryItemProperties properties, byte shape, int color, [Optional] List<long> tagIds, [Optional] List<RoomInventoryItemTagDTO> newTags, bool allowRename = false);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task<Result<RoomInventoryItem, string>> UpdateRoomInventoryItem(Guid roomInventoryItemId, long roomId, [Optional] string name, [Optional] string description, [Optional] string imageName, [Optional] List<long> tagIds, [Optional] Dictionary<string, RoomInventoryTagClientProperties> newTags, [Optional] RoomInventoryItemProperties properties, [Optional] byte? shape, [Optional] int? color);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task<Result<bool, string>> GHZYCUHDGXT(Guid a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "19")]
		IReadOnlyList<RoomInventoryItem> OJQUVFNFFSS();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		IReadOnlyList<RoomInventoryItem> IRKVHBOVTCA();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool VMAGDKFNSTX();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool SJBFQSDHRTD(Guid a, [Out] RoomInventoryItem b);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool QQIOVARGXVF(string a, [Out] RoomInventoryItem b);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		IReadOnlyList<PlayerRoomInventoryItem> TYSXSVUIPAD();

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool FZJXPJCOUYW(Guid a, [Out] PlayerRoomInventoryItem b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "26")]
		long? EIVYJMHUJPZ(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "27")]
		Task<int> IXRDQLAEESR(QCTMRFTYWMB a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "28")]
		Task<BBDHVXPTRNS> EXVKAFVPXGQ(QCTMRFTYWMB a, Guid b, int c);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "29")]
		string DHZDWDRVHHX(PlayerRoomInventoryOperationResult a);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool HSVZMUBJDWA();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "31")]
		RoomInventoryItemDTO DehydrateRoomInventoryItemToDTO(RoomInventoryItem inventoryItem);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "32")]
		RoomInventoryItemProperties DeserializeRoomInventoryItemProperties(string serializedRoomInventoryItemPropertyString);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void Dispose();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "34")]
		Task<Result<FYVWDLQIVIR, string>> SGMDYGRCQZC(long a, RoomInventoryTagClientProperties b);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task<Result<bool, string>> QWKOOBDKUSG(long a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task<Result<bool, string>> OJARSDIIKBM(long a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "37")]
		bool IFPIWPVWFRM();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "38")]
		List<(long, int)> QCYDWXSWRZP(long a, int b);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "39")]
		bool SAKSTFKEVPV(long a, [Out] FYVWDLQIVIR b);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "40")]
		bool NWZOXYSABGJ(string a, [Out] FYVWDLQIVIR b);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "41")]
		bool KIKTSAPKOLC(long a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "42")]
		IReadOnlyList<FYVWDLQIVIR> XUIVNRMMMGI();

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "43")]
		List<FYVWDLQIVIR> XODIDFBRVLE();

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "44")]
		IReadOnlyList<FYVWDLQIVIR> AJJSGNUDEDR();

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "45")]
		IReadOnlyList<RoomInventoryItem> FHQHOAMTCOL(long a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "46")]
		bool MNXRCHUICCV(string a, [Out] IReadOnlyList<RoomInventoryItem> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface CWHQSKKDGRO : RIOMKQYFAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GTORQWAEYYD(IEnumerable<PlayerRoomInventoryItemDTO> a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task JPKSJNIXHZP();
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PlayerRoomInventoryItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly Guid DWRQONBOHLL;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long XKLXOHCJQTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA1AFF40", Offset = "0xA1AEF40", VA = "0x18A1AFF40")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int URBXLBTIEQG
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA1AFF20", Offset = "0xA1AEF20", VA = "0x18A1AFF20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long NMEXYTAMOBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCFC430", Offset = "0xCFB430", VA = "0x180CFC430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public long YQIVOMPNOZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4140", Offset = "0xCF3140", VA = "0x180CF4140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Guid? BLUAKYDTFVK
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCFBA10", Offset = "0xCFAA10", VA = "0x180CFBA10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xCFBA00", Offset = "0xCFAA00", VA = "0x180CFBA00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DPNODMHIWMN
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x166C530", Offset = "0x166B530", VA = "0x18166C530")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x166C540", Offset = "0x166B540", VA = "0x18166C540")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA1B01A0", Offset = "0xA1AF1A0", VA = "0x18A1B01A0")]
		public PlayerRoomInventoryItem(PlayerRoomInventoryItemDTO dto, bool hasEverBeenOwned)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1128C30", Offset = "0x1127C30", VA = "0x181128C30")]
		public PlayerRoomInventoryItem(Guid roomInventoryItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA1AFFB0", Offset = "0xA1AEFB0", VA = "0x18A1AFFB0")]
		internal bool Update(PlayerRoomInventoryItemDTO dto, long unsavedCountToRemove, Action<PlayerRoomInventoryItem, int> onUpdateCallback)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA1AFF50", Offset = "0xA1AEF50", VA = "0x18A1AFF50")]
		internal void KOKWBUDMVAU(long a, Action<PlayerRoomInventoryItem, int> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class RoomInventoryItem : IEquatable<RoomInventoryItem>
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public const int AOWRQOLQIVP = 3;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public const int PPQNXCWTXKD = 40;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const int GKODVQYKPGG = 180;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public const int MDYDXRNQUZA = 1000;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public const int DPHKCHWKSAC = 10;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Guid DWRQONBOHLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xF07D00", Offset = "0xF06D00", VA = "0x180F07D00")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xF07D20", Offset = "0xF06D20", VA = "0x180F07D20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public long MFLRLLFNHBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xE32720", Offset = "0xE31720", VA = "0x180E32720")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string VETBDCDGWNG
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xD02500", Offset = "0xD01500", VA = "0x180D02500")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string VLWKAUJWJKA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xCFC360", Offset = "0xCFB360", VA = "0x180CFC360")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public DateTime TRNIHFSWLSP
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xFC9E90", Offset = "0xFC8E90", VA = "0x180FC9E90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DateTime JHCDFFOVJGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x1405290", Offset = "0x1404290", VA = "0x181405290")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HashSet<long> JSMDPEOXGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BC0", Offset = "0xCF6BC0", VA = "0x180CF7BC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public RoomInventoryItemProperties YVFFJRZFCRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6BB0", VA = "0x180CF7BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCF7E60", Offset = "0xCF6E60", VA = "0x180CF7E60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public byte VRFDWJCJYDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCFC310", Offset = "0xCFB310", VA = "0x180CFC310")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCFC300", Offset = "0xCFB300", VA = "0x180CFC300")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ShapeColor OCTDXXQMYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1021F90", Offset = "0x1020F90", VA = "0x181021F90")]
			[CompilerGenerated]
			get
			{
				return default(ShapeColor);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3142660", Offset = "0x3141660", VA = "0x183142660")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public RoomInventoryItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA1B0C40", Offset = "0xA1AFC40", VA = "0x18A1B0C40")]
		public RoomInventoryItem(RoomInventoryItemDTO dto, [Optional] RoomInventoryItemProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA1B0520", Offset = "0xA1AF520", VA = "0x18A1B0520", Slot = "4")]
		public bool Equals(RoomInventoryItem other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA1B06A0", Offset = "0xA1AF6A0", VA = "0x18A1B06A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA1B0880", Offset = "0xA1AF880", VA = "0x18A1B0880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA1B0960", Offset = "0xA1AF960", VA = "0x18A1B0960")]
		private HashSet<long> HXMXUOFCZIN(RoomInventoryItemDTO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class KBRCHUSDEOU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private PlayerRoomInventoryItem ESCTCWUQJAX;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RoomInventoryItem OQTENLBFJEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public PlayerRoomInventoryItem ECUGEPLKFNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xA1AFB30", Offset = "0xA1AEB30", VA = "0x18A1AFB30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA1AFBC0", Offset = "0xA1AEBC0", VA = "0x18A1AFBC0")]
		public KBRCHUSDEOU(RoomInventoryItem a, [Optional] PlayerRoomInventoryItem b)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public const int MAX_ACTION_BUTTON_TEXT_LENGTH = 12;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private const int KEUMCZHFDFO = 1;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA1B04D0", Offset = "0xA1AF4D0", VA = "0x18A1B04D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		internal int WZQEDLFLMPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xCF4110", Offset = "0xCF3110", VA = "0x180CF4110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xCFBA30", Offset = "0xCFAA30", VA = "0x180CFBA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x132CAF0", Offset = "0x132BAF0", VA = "0x18132CAF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x16751B0", Offset = "0x16741B0", VA = "0x1816751B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RoomInventoryItemVisibility Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
			[CompilerGenerated]
			get
			{
				return default(RoomInventoryItemVisibility);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xD031D0", Offset = "0xD021D0", VA = "0x180D031D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xE9D7B0", Offset = "0xE9C7B0", VA = "0x180E9D7B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xED4590", Offset = "0xED3590", VA = "0x180ED4590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xD8C020", Offset = "0xD8B020", VA = "0x180D8C020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xD8C030", Offset = "0xD8B030", VA = "0x180D8C030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xF56C20", Offset = "0xF55C20", VA = "0x180F56C20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xF56C30", Offset = "0xF55C30", VA = "0x180F56C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA1B0330", Offset = "0xA1AF330", VA = "0x18A1B0330", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA1B0250", Offset = "0xA1AF250", VA = "0x18A1B0250")]
		public static RoomInventoryItemProperties Clone(RoomInventoryItemProperties properties)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA1B0470", Offset = "0xA1AF470", VA = "0x18A1B0470")]
		public RoomInventoryItemProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class FYVWDLQIVIR
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const int YRVRZSAMPMY = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string SLAOVMJMRPO;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static StringBuilder XAODNACXPXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string CIJVQTVBQNR;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long KWFLVQFAPBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xE8FE60", Offset = "0xE8EE60", VA = "0x180E8FE60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA1AF8C0", Offset = "0xA1AE8C0", VA = "0x18A1AF8C0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string JNNLUASEFCS
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA1AF660", Offset = "0xA1AE660", VA = "0x18A1AF660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public RoomInventoryTagClientProperties YVFFJRZFCRB
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool GBBRJNMHSLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA1AF8A0", Offset = "0xA1AE8A0", VA = "0x18A1AF8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public FYVWDLQIVIR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA1AF970", Offset = "0xA1AE970", VA = "0x18A1AF970")]
		public FYVWDLQIVIR(RoomInventoryItemTagDTO a, [Optional] RoomInventoryTagClientProperties b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA1AF5A0", Offset = "0xA1AE5A0", VA = "0x18A1AF5A0")]
		public RoomInventoryItemTagDTO Deyhdrate()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class RoomInventoryTagClientProperties
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static RoomInventoryTagClientProperties DefaultNonSortingTab
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA1B0FB0", Offset = "0xA1AFFB0", VA = "0x18A1B0FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xCF4110", Offset = "0xCF3110", VA = "0x180CF4110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xCFBA30", Offset = "0xCFAA30", VA = "0x180CFBA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA1B0DA0", Offset = "0xA1AFDA0", VA = "0x18A1B0DA0")]
		public void DeserializeFromJson(Dictionary<string, object> json)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
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
