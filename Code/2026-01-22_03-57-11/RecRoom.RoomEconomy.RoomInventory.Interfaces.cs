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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class PSIKYYPKWKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly PlayerRoomInventoryOperationResult XUALJKXXDTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly long UHDSQPYTSJQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int KYMDPCRYMUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8ADD720", Offset = "0x8ADBF20", VA = "0x188ADD720")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD730", Offset = "0x8ADBF30", VA = "0x188ADD730")]
		public PSIKYYPKWKF(PlayerRoomInventoryOperationResult a, long b)
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
	public static class ENNGIPGQQWC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD660", Offset = "0x8ADBE60", VA = "0x188ADD660")]
		public static bool OYFNENGYWFP(this RoomInventoryItemVisibility a, PlayerRoomInventoryItem b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface OBTFAPMXTAK
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		XOOCNKBZGKP GHDDWUQIBTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		WXSKNELZHVC<RoomInventoryItem> MOPFEPWCXET
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		WXSKNELZHVC<Guid> DXCPRQNAQEY
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		WYIFEYTRKDD<PlayerRoomInventoryItem, int> UGGMEDJRDNL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		WXSKNELZHVC<AEGIGCUQYIY> OFVQSZKJMAY
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		WXSKNELZHVC<long> JJXOPMCCIVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		XOOCNKBZGKP PQOWZKKQDXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		XOOCNKBZGKP JBNHMSNVYBK
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
		Task<Result<bool, string>> UDPYAMHTPLE(Guid a, long b);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "19")]
		IReadOnlyList<RoomInventoryItem> OPKVJSERVOF();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		IReadOnlyList<RoomInventoryItem> PONJSKVZOMD();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool QRIMZEERFZC();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool ECCNUSEXIUS(Guid a, [Out] RoomInventoryItem b);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool RBQLQIINQUM(string a, [Out] RoomInventoryItem b);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		IReadOnlyList<PlayerRoomInventoryItem> IQLOEACCZHK();

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool BCBRJHAZPXP(Guid a, [Out] PlayerRoomInventoryItem b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "26")]
		long? GKLSHVFLBWM(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "27")]
		Task<int> FJBBGGAUHFC(MNBQIABPYXS a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "28")]
		Task<PSIKYYPKWKF> MVTMCSSWVLZ(MNBQIABPYXS a, Guid b, int c);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "29")]
		string NGGADXZAHCS(PlayerRoomInventoryOperationResult a);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool QNFJOWKJTGN();

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
		Task<Result<AEGIGCUQYIY, string>> VJPZDYROBLX(long a, RoomInventoryTagClientProperties b);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task<Result<bool, string>> XGANYQKBABR(long a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task<Result<bool, string>> UVDVXZYPTIZ(long a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "37")]
		bool RSYATAGSSQJ();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "38")]
		List<(long, int)> DNJXGRBSKAS(long a, int b);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "39")]
		bool FZFSIETMUTC(long a, [Out] AEGIGCUQYIY b);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "40")]
		bool ZSIKINQWKNM(string a, [Out] AEGIGCUQYIY b);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "41")]
		bool VIRDRAIVYTP(long a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "42")]
		IReadOnlyList<AEGIGCUQYIY> KJXFJJYPINB();

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "43")]
		List<AEGIGCUQYIY> KEJJPRUJQFP();

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "44")]
		IReadOnlyList<AEGIGCUQYIY> GXOUCQLPVWQ();

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "45")]
		IReadOnlyList<RoomInventoryItem> XTWLQVIKBVA(long a);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "46")]
		bool MELYSGZYKSC(string a, [Out] IReadOnlyList<RoomInventoryItem> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface SSPDTZUDRVF : OBTFAPMXTAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ICCSGDRHTXU(IEnumerable<PlayerRoomInventoryItemDTO> a);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task ZJAUCELQTNC();
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PlayerRoomInventoryItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly Guid XZZFZGABXDY;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public long UHDSQPYTSJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8ADD7F0", Offset = "0x8ADBFF0", VA = "0x188ADD7F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int KYMDPCRYMUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8ADD7D0", Offset = "0x8ADBFD0", VA = "0x188ADD7D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public long JWYGPQJGVHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAAD110", Offset = "0xAAB910", VA = "0x180AAD110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public long MHCFKNELCWC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8F10", Offset = "0xAB7710", VA = "0x180AB8F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Guid? VQVMFOAMMWL
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAB2590", Offset = "0xAB0D90", VA = "0x180AB2590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xAB2580", Offset = "0xAB0D80", VA = "0x180AB2580")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool JNYWOTOCFTW
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x13CB7B0", Offset = "0x13C9FB0", VA = "0x1813CB7B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x13CB7C0", Offset = "0x13C9FC0", VA = "0x1813CB7C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD9F0", Offset = "0x8ADC1F0", VA = "0x188ADD9F0")]
		public PlayerRoomInventoryItem(PlayerRoomInventoryItemDTO dto, bool hasEverBeenOwned)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE72FA0", Offset = "0xE717A0", VA = "0x180E72FA0")]
		public PlayerRoomInventoryItem(Guid roomInventoryItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD800", Offset = "0x8ADC000", VA = "0x188ADD800")]
		internal bool Update(PlayerRoomInventoryItemDTO dto, long unsavedCountToRemove, Action<PlayerRoomInventoryItem, int> onUpdateCallback)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD770", Offset = "0x8ADBF70", VA = "0x188ADD770")]
		internal void HSTUPLMBUBR(long a, Action<PlayerRoomInventoryItem, int> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class RoomInventoryItem : IEquatable<RoomInventoryItem>
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public const int HMACFYPHYJY = 3;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public const int UONIBYFAKDG = 40;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const int UNPBICGGQGP = 180;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public const int JDEBZZNXVFF = 1000;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public const int SVIBIVBVZWF = 10;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Guid XZZFZGABXDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xC7C0A0", Offset = "0xC7A8A0", VA = "0x180C7C0A0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xC7C0C0", Offset = "0xC7A8C0", VA = "0x180C7C0C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public long SYTLQGXLXCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xBA94B0", Offset = "0xBA7CB0", VA = "0x180BA94B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAB0170", Offset = "0xAAE970", VA = "0x180AB0170")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string SLQAVUNZHSH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xAB1230", Offset = "0xAAFA30", VA = "0x180AB1230")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string WPCIHJHVSOH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAACAB0", Offset = "0xAAB2B0", VA = "0x180AACAB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public DateTime RFVMAONELLW
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xD40E30", Offset = "0xD3F630", VA = "0x180D40E30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DateTime TTYROUYMYSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x1180CC0", Offset = "0x117F4C0", VA = "0x181180CC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HashSet<long> VWGIHFCSIVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAB3470", Offset = "0xAB1C70", VA = "0x180AB3470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAB3290", Offset = "0xAB1A90", VA = "0x180AB3290")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public RoomInventoryItemProperties SISXIIKSZKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAB3280", Offset = "0xAB1A80", VA = "0x180AB3280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAB32A0", Offset = "0xAB1AA0", VA = "0x180AB32A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public byte EYOLGCVLQFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAB4110", Offset = "0xAB2910", VA = "0x180AB4110")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAB4150", Offset = "0xAB2950", VA = "0x180AB4150")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ShapeColor MWUYGRPPWGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD7CAF0", Offset = "0xD7B2F0", VA = "0x180D7CAF0")]
			[CompilerGenerated]
			get
			{
				return default(ShapeColor);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2EA4C30", Offset = "0x2EA3430", VA = "0x182EA4C30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public RoomInventoryItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE480", Offset = "0x8ADCC80", VA = "0x188ADE480")]
		public RoomInventoryItem(RoomInventoryItemDTO dto, [Optional] RoomInventoryItemProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE050", Offset = "0x8ADC850", VA = "0x188ADE050", Slot = "4")]
		public bool Equals(RoomInventoryItem other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE1D0", Offset = "0x8ADC9D0", VA = "0x188ADE1D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE3A0", Offset = "0x8ADCBA0", VA = "0x188ADE3A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8ADDD70", Offset = "0x8ADC570", VA = "0x188ADDD70")]
		private HashSet<long> DHNEBKUPHAM(RoomInventoryItemDTO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class UHRSBDPMIXZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private PlayerRoomInventoryItem RPZSPZZXZRW;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RoomInventoryItem LDLEFNRGFBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public PlayerRoomInventoryItem FQMIZACPNYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8ADE890", Offset = "0x8ADD090", VA = "0x188ADE890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xAACB10", Offset = "0xAAB310", VA = "0x180AACB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE920", Offset = "0x8ADD120", VA = "0x188ADE920")]
		public UHRSBDPMIXZ(RoomInventoryItem a, [Optional] PlayerRoomInventoryItem b)
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
		private const int EENXXETCFAH = 1;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8ADDD20", Offset = "0x8ADC520", VA = "0x188ADDD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		internal int GIOWEMQBGCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAAC110", Offset = "0xAAA910", VA = "0x180AAC110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAB2560", Offset = "0xAB0D60", VA = "0x180AB2560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x10A36B0", Offset = "0x10A1EB0", VA = "0x1810A36B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D47F0", VA = "0x1813D5FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public RoomInventoryItemVisibility Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAB1200", Offset = "0xAAFA00", VA = "0x180AB1200")]
			[CompilerGenerated]
			get
			{
				return default(RoomInventoryItemVisibility);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAB1220", Offset = "0xAAFA20", VA = "0x180AB1220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xC2B730", Offset = "0xC29F30", VA = "0x180C2B730")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xC2B2F0", Offset = "0xC29AF0", VA = "0x180C2B2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xAB0160", Offset = "0xAAE960", VA = "0x180AB0160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xCD7980", Offset = "0xCD6180", VA = "0x180CD7980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xCD79B0", Offset = "0xCD61B0", VA = "0x180CD79B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCD7970", Offset = "0xCD6170", VA = "0x180CD7970")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCD7960", Offset = "0xCD6160", VA = "0x180CD7960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8ADDB80", Offset = "0x8ADC380", VA = "0x188ADDB80", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8ADDAA0", Offset = "0x8ADC2A0", VA = "0x188ADDAA0")]
		public static RoomInventoryItemProperties Clone(RoomInventoryItemProperties properties)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8ADDCC0", Offset = "0x8ADC4C0", VA = "0x188ADDCC0")]
		public RoomInventoryItemProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AEGIGCUQYIY
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public const int UDEHGLQZHEB = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string DNVIRFVNZZR;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static StringBuilder CUKQJCRUUKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string QKWCNKMTPYE;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public long RJZXPDOWLUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xC022A0", Offset = "0xC00AA0", VA = "0x180C022A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8ADD1C0", Offset = "0x8ADB9C0", VA = "0x188ADD1C0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string UCUOZKDHPBF
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8ADD2B0", Offset = "0x8ADBAB0", VA = "0x188ADD2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public RoomInventoryTagClientProperties SISXIIKSZKK
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAB0170", Offset = "0xAAE970", VA = "0x180AB0170")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool LVPLJTMYWWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8ADD4E0", Offset = "0x8ADBCE0", VA = "0x188ADD4E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public AEGIGCUQYIY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD570", Offset = "0x8ADBD70", VA = "0x188ADD570")]
		public AEGIGCUQYIY(RoomInventoryItemTagDTO a, [Optional] RoomInventoryTagClientProperties b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD1F0", Offset = "0x8ADB9F0", VA = "0x188ADD1F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8ADE7F0", Offset = "0x8ADCFF0", VA = "0x188ADE7F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAC110", Offset = "0xAAA910", VA = "0x180AAC110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAB2560", Offset = "0xAB0D60", VA = "0x180AB2560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE5E0", Offset = "0x8ADCDE0", VA = "0x188ADE5E0")]
		public void DeserializeFromJson(Dictionary<string, object> json)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
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
