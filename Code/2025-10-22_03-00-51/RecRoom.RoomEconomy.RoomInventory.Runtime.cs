using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;
using RecRoom.Analytics.Statsig;
using RecRoom.Core;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.RPC;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Persistence;
using RecRoom.RoomEconomy.Core;
using UJect;
using UJect.Injection;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RoomEconomy_RoomInventory_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D03190", Offset = "0x8D01790", VA = "0x188D03190", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2980B40", Offset = "0x297F140", VA = "0x182980B40")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface GKCEJFJCUTR : VHRRDEXIDIZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		ZHLYOYVFADW ZHLYOYVFADW
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class SBARPXHYFMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly Dictionary<Guid, TQOMZDJDNCW> CHJKVSXGDMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly Dictionary<string, TQOMZDJDNCW> IDQHNRZIGZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private bool? RIDAHVOHHYZ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private long FKYOVSPGEAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EF0", Offset = "0xAAF4F0", VA = "0x180AB0EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TQOMZDJDNCW this[Guid index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8CF2640", Offset = "0x8CF0C40", VA = "0x188CF2640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8CF18F0", Offset = "0x8CEFEF0", VA = "0x188CF18F0")]
		public void NewRoom(long roomId, IEnumerable<RoomInventoryItem> roomInventoryItems, IEnumerable<PlayerRoomInventoryItem> playerRoomInventoryItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8CF14F0", Offset = "0x8CEFAF0", VA = "0x188CF14F0")]
		public bool DMFCNFDQGQM(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1FD0", Offset = "0x8CF05D0", VA = "0x188CF1FD0")]
		public bool Remove(Guid roomInventoryItemId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1140", Offset = "0x8CEF740", VA = "0x188CF1140")]
		public bool BOXYWLKETTS(RoomInventoryItem a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1550", Offset = "0x8CEFB50", VA = "0x188CF1550")]
		public IEnumerable<TQOMZDJDNCW> HMOXZBDPGEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8CF2430", Offset = "0x8CF0A30", VA = "0x188CF2430")]
		public IEnumerable<RoomInventoryItem> XTIXWVZJUIY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1370", Offset = "0x8CEF970", VA = "0x188CF1370")]
		public IEnumerable<PlayerRoomInventoryItem> CGOZCPOUITD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8CF22D0", Offset = "0x8CF08D0", VA = "0x188CF22D0")]
		public bool VHVTGARIVXN(Guid a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1FF0", Offset = "0x8CF05F0", VA = "0x188CF1FF0")]
		public bool SVDURKFEXYV(string a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8CF2380", Offset = "0x8CF0980", VA = "0x188CF2380")]
		public bool VMQZUWXHOAE(Guid a, [Out] PlayerRoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1F30", Offset = "0x8CF0530", VA = "0x188CF1F30")]
		public bool RKODCEGESEN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1690", Offset = "0x8CEFC90", VA = "0x188CF1690")]
		private bool MHWPUJPTJFE(RoomInventoryItem a, RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0F00", Offset = "0x8CEF500", VA = "0x188CF0F00")]
		private void BIFMLYWLTVQ(Guid a, TQOMZDJDNCW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8CF2090", Offset = "0x8CF0690", VA = "0x188CF2090")]
		private bool TILBJYDHTCT(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8CF15A0", Offset = "0x8CEFBA0", VA = "0x188CF15A0")]
		private void IZVBHJIDSOF(RoomInventoryItem a, [Optional] RoomInventoryItem b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1710", Offset = "0x8CEFD10", VA = "0x188CF1710")]
		private bool MUIBFSRMGKL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8CF14B0", Offset = "0x8CEFAB0", VA = "0x188CF14B0")]
		private static bool CPBBVLGXSPY(RoomInventoryItem a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8CF2570", Offset = "0x8CF0B70", VA = "0x188CF2570")]
		public SBARPXHYFMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ZHLYOYVFADW : PYUZBYGKVAL, WXADRAQRQHI, IDisposable, IMZUMQLTLNY
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private struct RoomInventoryItemUniqueId : IEquatable<RoomInventoryItemUniqueId>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public long RoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Guid RoomInventoryItemId;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5457880", Offset = "0x5455E80", VA = "0x185457880")]
			public RoomInventoryItemUniqueId(long roomId, Guid roomInventoryItemId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8CF0D80", Offset = "0x8CEF380", VA = "0x188CF0D80", Slot = "4")]
			public bool Equals(RoomInventoryItemUniqueId other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8CF0C30", Offset = "0x8CEF230", VA = "0x188CF0C30", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8CF0E80", Offset = "0x8CEF480", VA = "0x188CF0E80", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct <>c__DisplayClass100_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public Dictionary<RoomInventoryItemUniqueId, int> idsAndQuantities;
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class JWZNJUPNBAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public PlayerRoomInventoryOperationResult GIFPSKZVKYB;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public JWZNJUPNBAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8CEF9A0", Offset = "0x8CEDFA0", VA = "0x188CEF9A0")]
			internal AddOrRemovePlayerRoomInventoryItemCountResponseDTO MSSKEGOIBTZ(RoomInventoryItemUniqueId a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct <>c__DisplayClass99_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public PlayerRoomInventoryItem playerRoomInventoryItem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public int quantity;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct <AddOrRemovePlayerRoomInventoryItemToLocalPlayer>d__99 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public AsyncTaskMethodBuilder<HFEHDULRWXM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private <>c__DisplayClass99_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public LRIABUPBGVB awardingPlayer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public Guid remoteOperationId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private TaskAwaiter<PlayerRoomInventoryOperationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8CF26A0", Offset = "0x8CF0CA0", VA = "0x188CF26A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8CF2AC0", Offset = "0x8CF10C0", VA = "0x188CF2AC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct <AddOrRemovePlayerRoomInventoryServiceCall>d__100 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public AsyncTaskMethodBuilder<Dictionary<RoomInventoryItemUniqueId, AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public Dictionary<RoomInventoryItemUniqueId, int> idsAndQuantities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private <>c__DisplayClass100_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private TaskAwaiter<List<AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8CF2B30", Offset = "0x8CF1130", VA = "0x188CF2B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8CF35B0", Offset = "0x8CF1BB0", VA = "0x188CF35B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <CV2GetPlayerRoomInventoryItemCount>d__80 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public LRIABUPBGVB player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8CF3620", Offset = "0x8CF1C20", VA = "0x188CF3620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8CF39F0", Offset = "0x8CF1FF0", VA = "0x188CF39F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct <CreateRoomInventoryItem>d__66 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public AsyncTaskMethodBuilder<Result<RoomInventoryItem, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public RoomInventoryItemProperties properties;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Guid? originId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public string description;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public string imageName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public byte shape;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public int color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public List<long> tagIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public List<RoomInventoryItemTagDTO> newTags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public bool allowRename;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private TaskAwaiter<RecNetResult<RoomInventoryItemDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8CF3A60", Offset = "0x8CF2060", VA = "0x188CF3A60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8CF3FC0", Offset = "0x8CF25C0", VA = "0x188CF3FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <CullTagsOnDelete>d__135 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public RoomInventoryItem itemToDelete;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private Dictionary<long, bool>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private TaskAwaiter<Result<bool, string>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4030", Offset = "0x8CF2630", VA = "0x188CF4030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4A10", Offset = "0x8CF3010", VA = "0x188CF4A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <Cv2AddOrRemovePlayerRoomInventoryItem>d__81 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public AsyncTaskMethodBuilder<HFEHDULRWXM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public LRIABUPBGVB recipient;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private TaskAwaiter<HFEHDULRWXM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4A70", Offset = "0x8CF3070", VA = "0x188CF4A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4ED0", Offset = "0x8CF34D0", VA = "0x188CF4ED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct <DeleteRoomInventoryItem>d__68 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AsyncTaskMethodBuilder<Result<bool, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private RoomInventoryItem <itemToDelete>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private RecNetResult <result>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<RecNetResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4F40", Offset = "0x8CF3540", VA = "0x188CF4F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8CF5710", Offset = "0x8CF3D10", VA = "0x188CF5710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct <DeleteRoomInventoryTag>d__85 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<Result<bool, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public long tagId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private List<XVAYDDNJQZB>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TaskAwaiter<Result<XVAYDDNJQZB, string>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<RecNetResult> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8CF5780", Offset = "0x8CF3D80", VA = "0x188CF5780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8CF6390", Offset = "0x8CF4990", VA = "0x188CF6390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct <DownloadRoomInventory>d__102 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private Task<List<RoomInventoryItemDTO>> <roomInventoryTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private Task<List<PlayerRoomInventoryItemDTO>> <playerRoomInventoryTask>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private Task<List<RoomInventoryItemTagDTO>> <roomInventoryTagsTask>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private Task<RoomEconConfigDTO> <roomConfigsTask>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private IEnumerable<RoomInventoryItem> <roomInventoryItems>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private IEnumerable<PlayerRoomInventoryItem> <playerRoomInventoryItems>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private List<XVAYDDNJQZB> <roomInventoryTags>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter<List<RoomInventoryItemDTO>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter<List<PlayerRoomInventoryItemDTO>> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private TaskAwaiter<List<RoomInventoryItemTagDTO>> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<RoomEconConfigDTO> <>u__5;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8CF6400", Offset = "0x8CF4A00", VA = "0x188CF6400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8CF7650", Offset = "0x8CF5C50", VA = "0x188CF7650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct <OnRoomLoadComplete>d__104 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private TaskAwaiter<Task> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8CF76B0", Offset = "0x8CF5CB0", VA = "0x188CF76B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8CF7D40", Offset = "0x8CF6340", VA = "0x188CF7D40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct <SendAddOrRemovePlayerRoomInventoryRequestToPlayer>d__112 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public AsyncTaskMethodBuilder<HFEHDULRWXM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public LRIABUPBGVB player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private TaskAwaiter<HFEHDULRWXM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8CF7DA0", Offset = "0x8CF63A0", VA = "0x188CF7DA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8CF8290", Offset = "0x8CF6890", VA = "0x188CF8290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <SendGetPlayerRoomInventoryCountRequest>d__109 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public LRIABUPBGVB player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8CF8300", Offset = "0x8CF6900", VA = "0x188CF8300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8CF87E0", Offset = "0x8CF6DE0", VA = "0x188CF87E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <SendRecNetAwardRequestAndRetryOnConcurrencyMismatch>d__101 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AsyncTaskMethodBuilder<List<AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public Dictionary<RoomInventoryItemUniqueId, int> idsAndQuantities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private List<AddOrRemovePlayerRoomInventoryItemCountResponseDTO> <results>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private int <attemptNumber>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<List<AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8CF8850", Offset = "0x8CF6E50", VA = "0x188CF8850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9770", Offset = "0x8CF7D70", VA = "0x188CF9770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private struct <SetSortingTabIsEnabledForRoom>d__95 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder<Result<bool, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public bool isEnabled;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<RecNetResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8CF97E0", Offset = "0x8CF7DE0", VA = "0x188CF97E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9D30", Offset = "0x8CF8330", VA = "0x188CF9D30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private struct <UpdateRoomInventoryItem>d__67 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public AsyncTaskMethodBuilder<Result<RoomInventoryItem, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public Dictionary<string, RoomInventoryTagClientProperties> newTags;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public RoomInventoryItemProperties properties;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public string description;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public string imageName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public List<long> tagIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public byte? shape;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int? color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter<RecNetResult<RoomInventoryItemDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9FF0", Offset = "0x8CF85F0", VA = "0x188CF9FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA880", Offset = "0x8CF8E80", VA = "0x188CFA880", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private struct <UpdateRoomInventoryTag>d__84 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AsyncTaskMethodBuilder<Result<XVAYDDNJQZB, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public long tagId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public RoomInventoryTagClientProperties properties;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private XVAYDDNJQZB <newTag>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private TaskAwaiter<TaskStatus> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB360", Offset = "0x8CF9960", VA = "0x188CFB360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB830", Offset = "0x8CF9E30", VA = "0x188CFB830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private struct <UpdateRoomInventoryTagServiceCall>d__98 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public AsyncTaskMethodBuilder<Dictionary<long, RoomInventoryItemTagDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public Dictionary<long, int> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public ZHLYOYVFADW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private TaskAwaiter<RecNetResult<List<RoomInventoryItemTagDTO>>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA8F0", Offset = "0x8CF8EF0", VA = "0x188CFA8F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB2F0", Offset = "0x8CF98F0", VA = "0x188CFB2F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly TimeSpan VURRCGXLOIW;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float SPPMRYINGPL = 10f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const float PTWYRIMBYMO = 3f;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal const int AZDFYSIFGYX = 3;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal const string ROPWOFODIIY = "econ_room_inventory_gate";

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal const string TEZDQFLNBWK = "experiences_room_inventory_tags_gate";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly YKDOLJLMTET CWSDNHCCHTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly OZQFSXCSQJQ EVDISUTGFNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly ZJPJLCQSKDV KWZXZWSDCOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly NVQTRAMEOXY NVKBXRFGSER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly NVIGOXZYHON XPGKGSOLWSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly GKCEJFJCUTR HMGUHQVFGLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly YAEPLJOWYUO IRYXGQYJBFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly JPJBRXWFENJ USMQKSNTYVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly JATKMQNWILW RMQOBZLDIXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly SBARPXHYFMI YARIHUKTEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly PWHDAFNMSVQ LTOCTITRDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly RoomInventoryItemPropertiesCache DTEWQFIKMWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly CancellationTokenSource WLFXOUQMALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly KeyValueRequestBatcher<RoomInventoryItemUniqueId, AddOrRemovePlayerRoomInventoryItemCountResponseDTO> ZFVIHHCUXWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly KeyValueRequestBatcher<long, RoomInventoryItemTagDTO> BIKZGLXJYEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly GIIVEMWQQRL FHJNATYCSZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly IDisposable OPYLYDIJDEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Task XBKDGNRKAGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private CancellationTokenSource WTSHMIVXJVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private long OCHORKAQAHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool MFRVCTFDCZV;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private KLYGLTRGWBR KFCRGPAXIUO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8D01F50", Offset = "0x8D00550", VA = "0x188D01F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ENIVEIKFIDY QBSMYQOCZYV
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xF66510", Offset = "0xF64B10", VA = "0x180F66510", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xCB9290", Offset = "0xCB7890", VA = "0x180CB9290", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public YQBTYEHUFCJ<RoomInventoryItem> VJTCGTHWLIC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xBD1240", Offset = "0xBCF840", VA = "0x180BD1240", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xF4C980", Offset = "0xF4AF80", VA = "0x180F4C980", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public YQBTYEHUFCJ<Guid> SICTLHCGZSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xBD1670", Offset = "0xBCFC70", VA = "0x180BD1670", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xBD12A0", Offset = "0xBCF8A0", VA = "0x180BD12A0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public YPLZGKACCUI<PlayerRoomInventoryItem, int> ATULKRAWSVY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xBD1360", Offset = "0xBCF960", VA = "0x180BD1360", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xC07180", Offset = "0xC05780", VA = "0x180C07180", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public YQBTYEHUFCJ<XVAYDDNJQZB> PNTWKXDDSKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAA9E90", Offset = "0xAA8490", VA = "0x180AA9E90", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAA9E70", Offset = "0xAA8470", VA = "0x180AA9E70", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public YQBTYEHUFCJ<long> KPRAQXNWIGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xB0E990", Offset = "0xB0CF90", VA = "0x180B0E990", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xB99060", Offset = "0xB97660", VA = "0x180B99060", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ENIVEIKFIDY IEDNFCFQQIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB10300", Offset = "0xB0E900", VA = "0x180B10300", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB10E30", Offset = "0xB0F430", VA = "0x180B10E30", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ENIVEIKFIDY VYUJSCXVQJB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xB0E9A0", Offset = "0xB0CFA0", VA = "0x180B0E9A0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xB0E7E0", Offset = "0xB0CDE0", VA = "0x180B0E7E0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8CFD370", Offset = "0x8CFB970", VA = "0x188CFD370")]
		[ZOKCDQOPSGU.Session.GameOnly]
		internal static void GVEUOOVHRBJ(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8D026C0", Offset = "0x8D00CC0", VA = "0x188D026C0")]
		[RecRoom.NoEngine.Common.Preserve]
		public ZHLYOYVFADW([Inject(null)] YKDOLJLMTET recNetRoomInventory, [Inject(null)] OZQFSXCSQJQ recNetRoomInventoryTags, [Inject(null)] ZJPJLCQSKDV recNetRoomEconConfigs, [Inject(null)] NVQTRAMEOXY matchmakingProvider, [Inject(null)] QXNZJJETUHB roomLoader, [Inject(null)] NVIGOXZYHON taskDelay, [Inject(null)] GKCEJFJCUTR rpcForwarder, [Inject(null)] ZLJRSQTACFI recNetPhotonAccess, [Inject(null)] EQOGMVRWBIY cacheFactory, [Inject(null)] YAEPLJOWYUO statsig, [Inject(null)] JPJBRXWFENJ platformManager, [Inject(null)] JATKMQNWILW sessionManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8CFCDB0", Offset = "0x8CFB3B0", VA = "0x188CFCDB0", Slot = "53")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8D001C0", Offset = "0x8CFE7C0", VA = "0x188D001C0", Slot = "52")]
		public Task RHMOWUNNMLZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC1F0", Offset = "0x8CFA7F0", VA = "0x188CFC1F0", Slot = "20")]
		[AsyncStateMachine(typeof(<CreateRoomInventoryItem>d__66))]
		public Task<Result<RoomInventoryItem, string>> CreateRoomInventoryItem(Guid? originId, long roomId, string name, string description, string imageName, RoomInventoryItemProperties properties, byte shape, int color, [Optional] List<long> tagIds, [Optional] List<RoomInventoryItemTagDTO> newTags, bool allowRename = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8D012C0", Offset = "0x8CFF8C0", VA = "0x188D012C0", Slot = "21")]
		[AsyncStateMachine(typeof(<UpdateRoomInventoryItem>d__67))]
		public Task<Result<RoomInventoryItem, string>> UpdateRoomInventoryItem(Guid roomInventoryItemId, long roomId, [Optional] string name, [Optional] string description, [Optional] string imageName, [Optional] List<long> tagIds, [Optional] Dictionary<string, RoomInventoryTagClientProperties> newTags, [Optional] RoomInventoryItemProperties properties, [Optional] byte? shape, [Optional] int? color)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8CFFD50", Offset = "0x8CFE350", VA = "0x188CFFD50", Slot = "22")]
		[AsyncStateMachine(typeof(<DeleteRoomInventoryItem>d__68))]
		public Task<Result<bool, string>> QEZBOFTKGAH(Guid a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8D01AA0", Offset = "0x8D000A0", VA = "0x188D01AA0", Slot = "23")]
		public IReadOnlyList<RoomInventoryItem> VWOHONGSSIY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8D015C0", Offset = "0x8CFFBC0", VA = "0x188D015C0")]
		private List<RoomInventoryItem> VHCIYNMFHMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8D001B0", Offset = "0x8CFE7B0", VA = "0x188D001B0", Slot = "24")]
		public IReadOnlyList<RoomInventoryItem> RCELBTBTFXE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8CFD270", Offset = "0x8CFB870", VA = "0x188CFD270", Slot = "25")]
		public bool GKESLZACCBJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8D01860", Offset = "0x8CFFE60", VA = "0x188D01860", Slot = "26")]
		public bool VHVTGARIVXN(Guid a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8D00D00", Offset = "0x8CFF300", VA = "0x188D00D00", Slot = "27")]
		public bool SVDURKFEXYV(string a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8CFFA60", Offset = "0x8CFE060", VA = "0x188CFFA60", Slot = "28")]
		public IReadOnlyList<PlayerRoomInventoryItem> QADGAPWLAZH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8D01980", Offset = "0x8CFFF80", VA = "0x188D01980", Slot = "29")]
		public bool VMQZUWXHOAE(Guid a, [Out] PlayerRoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8D00260", Offset = "0x8CFE860", VA = "0x188D00260", Slot = "30")]
		public long? RPJFGYUQQLP(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8D00F80", Offset = "0x8CFF580", VA = "0x188D00F80", Slot = "51")]
		public void UMZEDAFEATD(IEnumerable<PlayerRoomInventoryItemDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8CFE930", Offset = "0x8CFCF30", VA = "0x188CFE930", Slot = "31")]
		[AsyncStateMachine(typeof(<CV2GetPlayerRoomInventoryItemCount>d__80))]
		public Task<int> LANUGZEYVFZ(LRIABUPBGVB a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8D003E0", Offset = "0x8CFE9E0", VA = "0x188D003E0", Slot = "32")]
		[AsyncStateMachine(typeof(<Cv2AddOrRemovePlayerRoomInventoryItem>d__81))]
		public Task<HFEHDULRWXM> RUKLLCPZKFI(LRIABUPBGVB a, Guid b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8D02480", Offset = "0x8D00A80", VA = "0x188D02480", Slot = "33")]
		public string ZUINHRMOGNJ(PlayerRoomInventoryOperationResult a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBA90", Offset = "0x8CFA090", VA = "0x188CFBA90", Slot = "34")]
		public bool BEYLLWXLKAW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8D00080", Offset = "0x8CFE680", VA = "0x188D00080", Slot = "38")]
		[AsyncStateMachine(typeof(<UpdateRoomInventoryTag>d__84))]
		public Task<Result<XVAYDDNJQZB, string>> QYTYLXCWDEW(long a, RoomInventoryTagClientProperties b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8CFD3E0", Offset = "0x8CFB9E0", VA = "0x188CFD3E0", Slot = "39")]
		[AsyncStateMachine(typeof(<DeleteRoomInventoryTag>d__85))]
		public Task<Result<bool, string>> GZCFQPQMQPK(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8CFDEB0", Offset = "0x8CFC4B0", VA = "0x188CFDEB0", Slot = "42")]
		public List<(long, int)> JDMLMSPCLNN(long a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8D00F00", Offset = "0x8CFF500", VA = "0x188D00F00", Slot = "43")]
		public bool UFGVUBOGJVH(long a, [Out] XVAYDDNJQZB b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8D00E10", Offset = "0x8CFF410", VA = "0x188D00E10", Slot = "44")]
		public bool TMFDGYSGOFZ(string a, [Out] XVAYDDNJQZB b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8CFFE80", Offset = "0x8CFE480", VA = "0x188CFFE80", Slot = "45")]
		public bool QVJNQIPPUZA(long a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8CFEE10", Offset = "0x8CFD410", VA = "0x188CFEE10", Slot = "46")]
		public IReadOnlyList<XVAYDDNJQZB> NUFRONXPRSO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8CFDD20", Offset = "0x8CFC320", VA = "0x188CFDD20", Slot = "47")]
		public List<XVAYDDNJQZB> IAQRHNDBNQY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8CFEEF0", Offset = "0x8CFD4F0", VA = "0x188CFEEF0", Slot = "48")]
		public IReadOnlyList<XVAYDDNJQZB> OHYMNDDDRJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8CFEA70", Offset = "0x8CFD070", VA = "0x188CFEA70", Slot = "41")]
		public bool MEQCFWJXDQU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8D021C0", Offset = "0x8D007C0", VA = "0x188D021C0", Slot = "49")]
		public IReadOnlyList<RoomInventoryItem> ZJWAASOZEIZ(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8D01CF0", Offset = "0x8D002F0", VA = "0x188D01CF0", Slot = "40")]
		[AsyncStateMachine(typeof(<SetSortingTabIsEnabledForRoom>d__95))]
		public Task<Result<bool, string>> XJXQDIDVNTK(long a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBA20", Offset = "0x8CFA020", VA = "0x188CFBA20", Slot = "54")]
		public bool BAEPBEXQKPZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8CFE330", Offset = "0x8CFC930", VA = "0x188CFE330", Slot = "50")]
		public bool KENKPRZXORF(string a, [Out] IReadOnlyList<RoomInventoryItem> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8D01480", Offset = "0x8CFFA80", VA = "0x188D01480")]
		[AsyncStateMachine(typeof(<UpdateRoomInventoryTagServiceCall>d__98))]
		private Task<Dictionary<long, RoomInventoryItemTagDTO>> UpdateRoomInventoryTagServiceCall(Dictionary<long, int> requests, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8CFEAF0", Offset = "0x8CFD0F0", VA = "0x188CFEAF0")]
		[AsyncStateMachine(typeof(<AddOrRemovePlayerRoomInventoryItemToLocalPlayer>d__99))]
		private Task<HFEHDULRWXM> MZFMZTERPUM(Guid a, int b, [Optional] Guid c, [Optional] LRIABUPBGVB d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF920", Offset = "0x8CFDF20", VA = "0x188CFF920")]
		[AsyncStateMachine(typeof(<AddOrRemovePlayerRoomInventoryServiceCall>d__100))]
		private Task<Dictionary<RoomInventoryItemUniqueId, AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> PQEERFRVHEL(Dictionary<RoomInventoryItemUniqueId, int> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC540", Offset = "0x8CFAB40", VA = "0x188CFC540")]
		[AsyncStateMachine(typeof(<SendRecNetAwardRequestAndRetryOnConcurrencyMismatch>d__101))]
		private Task<List<AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> DVZCQQZWSPS(Dictionary<RoomInventoryItemUniqueId, int> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC0C0", Offset = "0x8CFA6C0", VA = "0x188CFC0C0")]
		[AsyncStateMachine(typeof(<DownloadRoomInventory>d__102))]
		private Task CTZSRXRKOVL(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF3B0", Offset = "0x8CFD9B0", VA = "0x188CFF3B0")]
		private Task OnRoomLoadStarted(BCQRNRKFWAN args, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB8A0", Offset = "0x8CF9EA0", VA = "0x188CFB8A0")]
		[AsyncStateMachine(typeof(<OnRoomLoadComplete>d__104))]
		private Task ADEPAJQFTAB(BCQRNRKFWAN a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF800", Offset = "0x8CFDE00", VA = "0x188CFF800")]
		private void PNCUGQLHOVE(RoomInventoryItemDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8D00850", Offset = "0x8CFEE50", VA = "0x188D00850")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string serializedRoomInventoryItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8CFCFC0", Offset = "0x8CFB5C0", VA = "0x188CFCFC0")]
		private void EBKJBZDKFEL(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8D00990", Offset = "0x8CFEF90", VA = "0x188D00990")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid roomInventoryItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8D01E10", Offset = "0x8D00410", VA = "0x188D01E10")]
		[AsyncStateMachine(typeof(<SendGetPlayerRoomInventoryCountRequest>d__109))]
		private Task<int> XVKBFOOUOXK(LRIABUPBGVB a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8D00680", Offset = "0x8CFEC80", VA = "0x188D00680")]
		[RPCMethod]
		internal void RpcGetPlayerRoomInventoryCount(Guid operationId, Guid roomInventoryItemId, RPCInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8D00600", Offset = "0x8CFEC00", VA = "0x188D00600")]
		[RPCMethod]
		internal void RpcGetPlayerRoomInventoryCountResponse(Guid operationId, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8CFD120", Offset = "0x8CFB720", VA = "0x188CFD120")]
		[AsyncStateMachine(typeof(<SendAddOrRemovePlayerRoomInventoryRequestToPlayer>d__112))]
		private Task<HFEHDULRWXM> ERHOPBHQADV(LRIABUPBGVB a, Guid b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8D00530", Offset = "0x8CFEB30", VA = "0x188D00530")]
		[RPCMethod]
		internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid operationId, Guid roomInventoryItemId, int quantity, RPCInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC3B0", Offset = "0x8CFA9B0", VA = "0x188CFC3B0")]
		private void DDZEJYUOATR(LRIABUPBGVB a, Guid b, PlayerRoomInventoryOperationResult c, long d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8D00C40", Offset = "0x8CFF240", VA = "0x188D00C40")]
		[RPCMethod]
		internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid operationId, int result, long playerOwnedCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8CFE7D0", Offset = "0x8CFCDD0", VA = "0x188CFE7D0")]
		private void KLLDTUHBKDR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8D00BE0", Offset = "0x8CFF1E0", VA = "0x188D00BE0")]
		[RPCMethod]
		private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool isEnabledBool)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8CFFC30", Offset = "0x8CFE230", VA = "0x188CFFC30")]
		private void QCWBFZFHSMT(List<RoomInventoryItemTagDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8D00A30", Offset = "0x8CFF030", VA = "0x188D00A30")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryTagUpdates(string serializedTags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8CFD940", Offset = "0x8CFBF40", VA = "0x188CFD940")]
		private void HNFDNDWBKVC(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8D009C0", Offset = "0x8CFEFC0", VA = "0x188D009C0")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryTagDeleted(long tagId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8D01FA0", Offset = "0x8D005A0", VA = "0x188D01FA0")]
		private RoomInventoryItem ZEJQWEGDQDD(RoomInventoryItemDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8CFEC40", Offset = "0x8CFD240", VA = "0x188CFEC40")]
		private List<XVAYDDNJQZB> NOBJBVMSZFC(List<RoomInventoryItemTagDTO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBC90", Offset = "0x8CFA290", VA = "0x188CFBC90")]
		private List<XVAYDDNJQZB> CQWTMRWAMUU(IEnumerable<RoomInventoryItemTagDTO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC970", Offset = "0x8CFAF70", VA = "0x188CFC970", Slot = "36")]
		public RoomInventoryItemProperties DeserializeRoomInventoryItemProperties(string serializedRoomInventoryItemPropertyString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8D01B50", Offset = "0x8D00150", VA = "0x188D01B50")]
		private RoomInventoryItem VZGTCAOTTHG(RoomInventoryItemDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC830", Offset = "0x8CFAE30", VA = "0x188CFC830", Slot = "35")]
		public RoomInventoryItemDTO DehydrateRoomInventoryItemToDTO(RoomInventoryItem inventoryItem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8CFDAA0", Offset = "0x8CFC0A0", VA = "0x188CFDAA0")]
		private XVAYDDNJQZB HydrateRoomInventoryTagFromDTO(RoomInventoryItemTagDTO dto)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC050", Offset = "0x8CFA650", VA = "0x188CFC050")]
		private void CSYSNZZHAAA(PlayerRoomInventoryItem a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8D00E90", Offset = "0x8CFF490", VA = "0x188D00E90")]
		private void UCLVXYTJVIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBB00", Offset = "0x8CFA100", VA = "0x188CFBB00")]
		private Task BINHWPGHBNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8CFE2C0", Offset = "0x8CFC8C0", VA = "0x188CFE2C0")]
		private void JSPFXXMFOWY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB970", Offset = "0x8CF9F70", VA = "0x188CFB970")]
		private void ALLOZGQTXHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF2A0", Offset = "0x8CFD8A0", VA = "0x188CFF2A0")]
		private void OZMPAWFPLCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8CFDDA0", Offset = "0x8CFC3A0", VA = "0x188CFDDA0")]
		[AsyncStateMachine(typeof(<CullTagsOnDelete>d__135))]
		private Task JDHVNDEQIDV(RoomInventoryItem a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8CFEED0", Offset = "0x8CFD4D0", VA = "0x188CFEED0")]
		[CompilerGenerated]
		private void NYDUUGPBIAK(Task<TaskStatus> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8CFD500", Offset = "0x8CFBB00", VA = "0x188CFD500")]
		[CompilerGenerated]
		private Task<PlayerRoomInventoryOperationResult> HJKWPKBWRBJ(<>c__DisplayClass99_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8CFC680", Offset = "0x8CFAC80", VA = "0x188CFC680")]
		[CompilerGenerated]
		internal static Dictionary<RoomInventoryItemUniqueId, AddOrRemovePlayerRoomInventoryItemCountResponseDTO> DYMEFZRYDSB(PlayerRoomInventoryOperationResult a, <>c__DisplayClass100_0 b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RoomInventoryItemPropertiesCache : Dictionary<string, RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0BF0", Offset = "0x8CEF1F0", VA = "0x188CF0BF0")]
		public RoomInventoryItemPropertiesCache()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface EQOGMVRWBIY
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		SBARPXHYFMI NOJSXCRWARW();

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RoomInventoryItemPropertiesCache RAKXWBXOMYB();

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PWHDAFNMSVQ OWSMRQZUIEG();
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class GKNRJIGNLXI : EQOGMVRWBIY
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8CEF6E0", Offset = "0x8CEDCE0", VA = "0x188CEF6E0")]
		[ZOKCDQOPSGU.Session.GameOnly]
		internal static void GVEUOOVHRBJ(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		[RecRoom.NoEngine.Common.Preserve]
		public GKNRJIGNLXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8CEF750", Offset = "0x8CEDD50", VA = "0x188CEF750", Slot = "4")]
		public SBARPXHYFMI NOJSXCRWARW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8CEF930", Offset = "0x8CEDF30", VA = "0x188CEF930", Slot = "5")]
		public RoomInventoryItemPropertiesCache RAKXWBXOMYB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8CEF850", Offset = "0x8CEDE50", VA = "0x188CEF850", Slot = "6")]
		public PWHDAFNMSVQ OWSMRQZUIEG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class PWHDAFNMSVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly Dictionary<long, XVAYDDNJQZB> TDOZHZNTKCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly XVAYDDNJQZB[] EUDLVKGHUWB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool SKGYMUBRADW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAFA810", Offset = "0xAF8E10", VA = "0x180AFA810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xBE49C0", Offset = "0xBE2FC0", VA = "0x180BE49C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int JMVRTAZSPIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x8CF00A0", Offset = "0x8CEE6A0", VA = "0x188CF00A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private long JGUHYJBOFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EF0", Offset = "0xAAF4F0", VA = "0x180AB0EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8CF01E0", Offset = "0x8CEE7E0", VA = "0x188CF01E0")]
		public void NewRoom(long roomId, IEnumerable<XVAYDDNJQZB> tags, bool sortingTabIsEnabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFA60", Offset = "0x8CEE060", VA = "0x188CEFA60")]
		public IReadOnlyList<XVAYDDNJQZB> GJNMTSDHDXO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xBE49C0", Offset = "0xBE2FC0", VA = "0x180BE49C0")]
		public void NYYDOFZBRSD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0100", Offset = "0x8CEE700", VA = "0x188CF0100")]
		public bool NZYHJFUJOUI(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0980", Offset = "0x8CEEF80", VA = "0x188CF0980")]
		public bool VGDMCEWSBAX(XVAYDDNJQZB a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFCE0", Offset = "0x8CEE2E0", VA = "0x188CEFCE0")]
		public bool KOGHBDLVMKH(List<XVAYDDNJQZB> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0000", Offset = "0x8CEE600", VA = "0x188CF0000")]
		public bool LLTWQFYDDEM(long a, [Out] XVAYDDNJQZB b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8CF07D0", Offset = "0x8CEEDD0", VA = "0x188CF07D0")]
		public bool RDHSUTBSESK(string a, [Out] XVAYDDNJQZB b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFC10", Offset = "0x8CEE210", VA = "0x188CEFC10")]
		public List<XVAYDDNJQZB> KIERSXREGBY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0690", Offset = "0x8CEEC90", VA = "0x188CF0690")]
		public List<XVAYDDNJQZB> OXRAFQPACWI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x87B8210", Offset = "0x87B6810", VA = "0x1887B8210")]
		public XVAYDDNJQZB GLPHYCROFCO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFA00", Offset = "0x8CEE000", VA = "0x188CEFA00")]
		public IReadOnlyList<XVAYDDNJQZB> EYYVTMWPVYG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0B40", Offset = "0x8CEF140", VA = "0x188CF0B40")]
		public PWHDAFNMSVQ()
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
