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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class KNGKXAOANKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly PlayerRoomInventoryOperationResult MNQYCISKHBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly long PUCTPTIOQGU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int OVVHWCTBJNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA1BC1A0", Offset = "0xA1BABA0", VA = "0x18A1BC1A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1BC1B0", Offset = "0xA1BABB0", VA = "0x18A1BC1B0")]
		public KNGKXAOANKP(PlayerRoomInventoryOperationResult a, long b)
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
	public static class QNBLSCIBXLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA1BC520", Offset = "0xA1BAF20", VA = "0x18A1BC520")]
		public static bool JVIVEYBNUDJ(this RoomInventoryItemVisibility a, PlayerRoomInventoryItem b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface IUXGQNIWDWM
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		DYNHRMPGIXT JINNXGBCLTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		ASNKAFBFVVA<RoomInventoryItem> XUGATMIJXPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		ASNKAFBFVVA<Guid> GRTBJCBLSBU
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		ASIDCYHIMJR<PlayerRoomInventoryItem, int> TAQEQFNDZEL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		ASNKAFBFVVA<IVUOPMKGOIS> VRQTNCDZXUG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		ASNKAFBFVVA<long> DWCEDMWHMKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		DYNHRMPGIXT LUWSKATLDXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		DYNHRMPGIXT EDFUKLCHOLU
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
		Task<Result<bool, string>> PKIDKGHYBJK(Guid a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "19")]
		IReadOnlyList<RoomInventoryItem> REPCUNLSQYH();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		IReadOnlyList<RoomInventoryItem> NNRMFCFYAEN();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool QEEFJKFWOIS();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool UYJHULRSKKU(Guid a, [Out] RoomInventoryItem b);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool PWIVBAWBKDI(string a, [Out] RoomInventoryItem b);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		IReadOnlyList<PlayerRoomInventoryItem> FYYUIISUTJM();

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool RGJVPREUNUP(Guid a, [Out] PlayerRoomInventoryItem b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "26")]
		long? SLGTABLHPXY(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "27")]
		Task<int> KEIXVXOKENU(GUPOFWBVNMS a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "28")]
		Task<KNGKXAOANKP> RRPNRZGXKZX(GUPOFWBVNMS a, Guid b, int c);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "29")]
		string NUNBIUZHRDW(PlayerRoomInventoryOperationResult a);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool WQIXXYYAVXV();

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
		Task<Result<IVUOPMKGOIS, string>> OINPSPKZMET(long a, RoomInventoryTagClientProperties b);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task<Result<bool, string>> PNKLOQWWAWZ(long a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task<Result<bool, string>> TTGTYPGWAFN(long a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "37")]
		bool ZWAZIZQUMOH();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "38")]
		List<(long, int)> LKGTDSSVJRW(long a, int b);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "39")]
		bool BAYPTPVTKQK(long a, [Out] IVUOPMKGOIS b);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "40")]
		bool AEWEPOOTWOY(string a, [Out] IVUOPMKGOIS b);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "41")]
		bool UTTPHLZOCJJ(long a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "42")]
		IReadOnlyList<IVUOPMKGOIS> XJPTEWFPRGJ();

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "43")]
		List<IVUOPMKGOIS> QDXYKNKQMHV();

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "44")]
		IReadOnlyList<IVUOPMKGOIS> NDYMOCNJZDE();

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "45")]
		IReadOnlyList<RoomInventoryItem> CFYFZUODEBK(long a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "46")]
		bool TAMXOVPMJSA(string a, [Out] IReadOnlyList<RoomInventoryItem> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface XATGDZDVNBH : IUXGQNIWDWM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XVABZFCMSMQ(IEnumerable<PlayerRoomInventoryItemDTO> a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task MEGSHUVAAPI();
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PlayerRoomInventoryItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly Guid XYBHXOKTNYQ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long PUCTPTIOQGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA1BC1F0", Offset = "0xA1BABF0", VA = "0x18A1BC1F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int OVVHWCTBJNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA1BC200", Offset = "0xA1BAC00", VA = "0x18A1BC200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long RKZQJAXISLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD118E0", Offset = "0xD102E0", VA = "0x180D118E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public long OZUUNCQPMAE
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6D0", Offset = "0xD1A0D0", VA = "0x180D1B6D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Guid? BDZRABBYXRT
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xD12C00", Offset = "0xD11600", VA = "0x180D12C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xD12BD0", Offset = "0xD115D0", VA = "0x180D12BD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool SVUHTTZZICS
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x16947C0", Offset = "0x16931C0", VA = "0x1816947C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x16947D0", Offset = "0x16931D0", VA = "0x1816947D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA1BC470", Offset = "0xA1BAE70", VA = "0x18A1BC470")]
		public PlayerRoomInventoryItem(PlayerRoomInventoryItemDTO dto, bool hasEverBeenOwned)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x111D590", Offset = "0x111BF90", VA = "0x18111D590")]
		public PlayerRoomInventoryItem(Guid roomInventoryItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA1BC220", Offset = "0xA1BAC20", VA = "0x18A1BC220")]
		internal bool Update(PlayerRoomInventoryItemDTO dto, long unsavedCountToRemove, Action<PlayerRoomInventoryItem, int> onUpdateCallback)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA1BC410", Offset = "0xA1BAE10", VA = "0x18A1BC410")]
		internal void YFVFPRTVMDH(long a, Action<PlayerRoomInventoryItem, int> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class RoomInventoryItem : IEquatable<RoomInventoryItem>
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public const int HJZARMBHRPK = 3;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public const int UDPXYIAGFCC = 40;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const int EFRWAMEDIXX = 180;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public const int HMZTQVGXTQV = 1000;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public const int TLXWXLHNNMD = 10;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Guid XYBHXOKTNYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public long JDBDHVXRGQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xE3F130", Offset = "0xE3DB30", VA = "0x180E3F130")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string UZNYKMCUYRT
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string BIBOOIVKMEF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public DateTime GHZNQOXDNSS
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xFFBC20", Offset = "0xFFA620", VA = "0x180FFBC20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DateTime TJOQKOYNURR
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x1440140", Offset = "0x143EB40", VA = "0x181440140")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HashSet<long> GUZZALLAHMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public RoomInventoryItemProperties TJFCEFCBDVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public byte BJXRVAXWVZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD11920", Offset = "0xD10320", VA = "0x180D11920")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xD122C0", Offset = "0xD10CC0", VA = "0x180D122C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ShapeColor RSXWRZLXIIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x103DE50", Offset = "0x103C850", VA = "0x18103DE50")]
			[CompilerGenerated]
			get
			{
				return default(ShapeColor);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x31757E0", Offset = "0x31741E0", VA = "0x1831757E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public RoomInventoryItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA1BCFC0", Offset = "0xA1BB9C0", VA = "0x18A1BCFC0")]
		public RoomInventoryItem(RoomInventoryItemDTO dto, [Optional] RoomInventoryItemProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA1BC8B0", Offset = "0xA1BB2B0", VA = "0x18A1BC8B0", Slot = "4")]
		public bool Equals(RoomInventoryItem other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA1BCA30", Offset = "0xA1BB430", VA = "0x18A1BCA30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA1BCC00", Offset = "0xA1BB600", VA = "0x18A1BCC00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA1BCCE0", Offset = "0xA1BB6E0", VA = "0x18A1BCCE0")]
		private HashSet<long> YCQQYBHKSDM(RoomInventoryItemDTO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class DSVKLFBFXCR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private PlayerRoomInventoryItem IFIFDSQBEAC;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RoomInventoryItem VBFCHIABRWU
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public PlayerRoomInventoryItem WCAEEVWVHZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xA1BB8E0", Offset = "0xA1BA2E0", VA = "0x18A1BB8E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA1BB970", Offset = "0xA1BA370", VA = "0x18A1BB970")]
		public DSVKLFBFXCR(RoomInventoryItem a, [Optional] PlayerRoomInventoryItem b)
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
		private const int TQNGLOHXZTL = 1;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA1BC860", Offset = "0xA1BB260", VA = "0x18A1BC860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		internal int YOEKAAIYPRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x137E3F0", Offset = "0x137CDF0", VA = "0x18137E3F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x16A6180", Offset = "0x16A4B80", VA = "0x1816A6180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RoomInventoryItemVisibility Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(RoomInventoryItemVisibility);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xEAE2D0", Offset = "0xEACCD0", VA = "0x180EAE2D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xED9400", Offset = "0xED7E00", VA = "0x180ED9400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xDA36E0", Offset = "0xDA20E0", VA = "0x180DA36E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xDA36F0", Offset = "0xDA20F0", VA = "0x180DA36F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xF82510", Offset = "0xF80F10", VA = "0x180F82510")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xF82520", Offset = "0xF80F20", VA = "0x180F82520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA1BC6C0", Offset = "0xA1BB0C0", VA = "0x18A1BC6C0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA1BC5E0", Offset = "0xA1BAFE0", VA = "0x18A1BC5E0")]
		public static RoomInventoryItemProperties Clone(RoomInventoryItemProperties properties)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA1BC800", Offset = "0xA1BB200", VA = "0x18A1BC800")]
		public RoomInventoryItemProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IVUOPMKGOIS
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const int DWFBHKLWOWL = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string LVRMURGCZHP;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static StringBuilder NHAWIRLFINR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string UAALNDCQJTM;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long NCUAHUSCYTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xED90B0", Offset = "0xED7AB0", VA = "0x180ED90B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA1BBFF0", Offset = "0xA1BA9F0", VA = "0x18A1BBFF0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string VXUBJNZPMVX
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA1BBDB0", Offset = "0xA1BA7B0", VA = "0x18A1BBDB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public RoomInventoryTagClientProperties TJFCEFCBDVK
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool TZWHYFRXBZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA1BBD90", Offset = "0xA1BA790", VA = "0x18A1BBD90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public IVUOPMKGOIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA1BC0A0", Offset = "0xA1BAAA0", VA = "0x18A1BC0A0")]
		public IVUOPMKGOIS(RoomInventoryItemTagDTO a, [Optional] RoomInventoryTagClientProperties b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA1BBCD0", Offset = "0xA1BA6D0", VA = "0x18A1BBCD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1BD330", Offset = "0xA1BBD30", VA = "0x18A1BD330")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA1BD120", Offset = "0xA1BBB20", VA = "0x18A1BD120")]
		public void DeserializeFromJson(Dictionary<string, object> json)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
