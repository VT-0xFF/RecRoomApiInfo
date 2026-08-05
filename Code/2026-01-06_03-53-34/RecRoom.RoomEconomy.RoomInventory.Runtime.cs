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
		[Cpp2IlInjected.Address(RVA = "0x8B33D20", Offset = "0x8B32720", VA = "0x188B33D20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2748530", Offset = "0x2746F30", VA = "0x182748530")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface URMDQZJLZQY : XINISBPPTIQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		AUUIGJAEHZJ AUUIGJAEHZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class JKQOUQREHUH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly Dictionary<Guid, KVTDFPAGHTN> AMWYMSKVXVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly Dictionary<string, KVTDFPAGHTN> NYXJAVYFVHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private bool? TTJKINKRHVW;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private long NYUETJDFKIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public KVTDFPAGHTN this[Guid index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8B29230", Offset = "0x8B27C30", VA = "0x188B29230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8B281B0", Offset = "0x8B26BB0", VA = "0x188B281B0")]
		public void NewRoom(long roomId, IEnumerable<RoomInventoryItem> roomInventoryItems, IEnumerable<PlayerRoomInventoryItem> playerRoomInventoryItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B29100", Offset = "0x8B27B00", VA = "0x188B29100")]
		public bool XKLKRGTBXGB(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8B28B80", Offset = "0x8B27580", VA = "0x188B28B80")]
		public bool Remove(Guid roomInventoryItemId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8B27AD0", Offset = "0x8B264D0", VA = "0x188B27AD0")]
		public bool AZBYPRFQIKL(RoomInventoryItem a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B290B0", Offset = "0x8B27AB0", VA = "0x188B290B0")]
		public IEnumerable<KVTDFPAGHTN> XHICTZTCXRS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8B27F30", Offset = "0x8B26930", VA = "0x188B27F30")]
		public IEnumerable<RoomInventoryItem> HXWMDXOQRKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8B28070", Offset = "0x8B26A70", VA = "0x188B28070")]
		public IEnumerable<PlayerRoomInventoryItem> IYYOGXDVOIW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8B28A50", Offset = "0x8B27450", VA = "0x188B28A50")]
		public bool QQOGTHLASDU(Guid a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8B27D00", Offset = "0x8B26700", VA = "0x188B27D00")]
		public bool CQDQILZVMHW(string a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8B27DA0", Offset = "0x8B267A0", VA = "0x188B27DA0")]
		public bool DQZNCNLHQSV(Guid a, [Out] PlayerRoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B27E90", Offset = "0x8B26890", VA = "0x188B27E90")]
		public bool GJOSRGUPYHO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8B28B00", Offset = "0x8B27500", VA = "0x188B28B00")]
		private bool QROEPJJKAAD(RoomInventoryItem a, RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8B28E70", Offset = "0x8B27870", VA = "0x188B28E70")]
		private void VNAKGDZTHCN(Guid a, KVTDFPAGHTN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8B28810", Offset = "0x8B27210", VA = "0x188B28810")]
		private bool OEMQYYLCEIC(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8B28D80", Offset = "0x8B27780", VA = "0x188B28D80")]
		private void VKGXHTLFRJA(RoomInventoryItem a, [Optional] RoomInventoryItem b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8B28BA0", Offset = "0x8B275A0", VA = "0x188B28BA0")]
		private bool UKYTOBKYYVM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8B27E50", Offset = "0x8B26850", VA = "0x188B27E50")]
		private static bool FOYHKGYOJDX(RoomInventoryItem a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8B29160", Offset = "0x8B27B60", VA = "0x188B29160")]
		public JKQOUQREHUH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AUUIGJAEHZJ : ZHUMFRVSUKC, PCRMPPJHYZZ, IDisposable, KNRCWYSSSBZ
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
			[Cpp2IlInjected.Address(RVA = "0x538BFF0", Offset = "0x538A9F0", VA = "0x18538BFF0")]
			public RoomInventoryItemUniqueId(long roomId, Guid roomInventoryItemId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8B296E0", Offset = "0x8B280E0", VA = "0x188B296E0", Slot = "4")]
			public bool Equals(RoomInventoryItemUniqueId other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8B29590", Offset = "0x8B27F90", VA = "0x188B29590", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8B297E0", Offset = "0x8B281E0", VA = "0x188B297E0", Slot = "2")]
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
		private sealed class TGQZOCWQIMR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public PlayerRoomInventoryOperationResult QQAGUSXENPQ;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public TGQZOCWQIMR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8B29860", Offset = "0x8B28260", VA = "0x188B29860")]
			internal AddOrRemovePlayerRoomInventoryItemCountResponseDTO TTYPRMHGWTQ(RoomInventoryItemUniqueId a)
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
			public AUUIGJAEHZJ <>4__this;

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
			public AsyncTaskMethodBuilder<GOGSUWECEMR> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public AUUIGJAEHZJ <>4__this;

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
			public RHIZVYSCBOY awardingPlayer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public Guid remoteOperationId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private TaskAwaiter<PlayerRoomInventoryOperationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8B298C0", Offset = "0x8B282C0", VA = "0x188B298C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8B29CE0", Offset = "0x8B286E0", VA = "0x188B29CE0", Slot = "5")]
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
			public AUUIGJAEHZJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8B29D50", Offset = "0x8B28750", VA = "0x188B29D50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8B2A7D0", Offset = "0x8B291D0", VA = "0x188B2A7D0", Slot = "5")]
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
			public AUUIGJAEHZJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public RHIZVYSCBOY player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8B2A840", Offset = "0x8B29240", VA = "0x188B2A840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8B2AC10", Offset = "0x8B29610", VA = "0x188B2AC10", Slot = "5")]
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
			public AUUIGJAEHZJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8B2AC80", Offset = "0x8B29680", VA = "0x188B2AC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8B2B1E0", Offset = "0x8B29BE0", VA = "0x188B2B1E0", Slot = "5")]
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
			public AUUIGJAEHZJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private Dictionary<long, bool>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private TaskAwaiter<Result<bool, string>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8B2B250", Offset = "0x8B29C50", VA = "0x188B2B250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BC30", Offset = "0x8B2A630", VA = "0x188B2BC30", Slot = "5")]
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
			public AsyncTaskMethodBuilder<GOGSUWECEMR> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AUUIGJAEHZJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public RHIZVYSCBOY recipient;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private TaskAwaiter<GOGSUWECEMR> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8B2BC90", Offset = "0x8B2A690", VA = "0x188B2BC90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8B2C0F0", Offset = "0x8B2AAF0", VA = "0x188B2C0F0", Slot = "5")]
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
			public AUUIGJAEHZJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8B2C160", Offset = "0x8B2AB60", VA = "0x188B2C160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8B2C950", Offset = "0x8B2B350", VA = "0x188B2C950", Slot = "5")]
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
			public AUUIGJAEHZJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public long tagId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private List<AUYEBSREHQE>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TaskAwaiter<Result<AUYEBSREHQE, string>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<RecNetResult> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8B2C9C0", Offset = "0x8B2B3C0", VA = "0x188B2C9C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8B2D5D0", Offset = "0x8B2BFD0", VA = "0x188B2D5D0", Slot = "5")]
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
			public AUUIGJAEHZJ <>4__this;

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
			private List<AUYEBSREHQE> <roomInventoryTags>5__8;

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
			[Cpp2IlInjected.Address(RVA = "0x8B2D640", Offset = "0x8B2C040", VA = "0x188B2D640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8B2E8B0", Offset = "0x8B2D2B0", VA = "0x188B2E8B0", Slot = "5")]
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
			public AUUIGJAEHZJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private TaskAwaiter<Task> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8B2E910", Offset = "0x8B2D310", VA = "0x188B2E910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8B2EFA0", Offset = "0x8B2D9A0", VA = "0x188B2EFA0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<GOGSUWECEMR> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public AUUIGJAEHZJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public RHIZVYSCBOY player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private TaskAwaiter<GOGSUWECEMR> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8B2F000", Offset = "0x8B2DA00", VA = "0x188B2F000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8B2F4F0", Offset = "0x8B2DEF0", VA = "0x188B2F4F0", Slot = "5")]
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
			public AUUIGJAEHZJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public RHIZVYSCBOY player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8B2F560", Offset = "0x8B2DF60", VA = "0x188B2F560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8B2FA50", Offset = "0x8B2E450", VA = "0x188B2FA50", Slot = "5")]
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
			public AUUIGJAEHZJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8B2FAC0", Offset = "0x8B2E4C0", VA = "0x188B2FAC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8B309E0", Offset = "0x8B2F3E0", VA = "0x188B309E0", Slot = "5")]
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
			public AUUIGJAEHZJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8B30A50", Offset = "0x8B2F450", VA = "0x188B30A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8B30FC0", Offset = "0x8B2F9C0", VA = "0x188B30FC0", Slot = "5")]
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
			public AUUIGJAEHZJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8B31280", Offset = "0x8B2FC80", VA = "0x188B31280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8B31B10", Offset = "0x8B30510", VA = "0x188B31B10", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<AUYEBSREHQE, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AUUIGJAEHZJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public long tagId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public RoomInventoryTagClientProperties properties;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private AUYEBSREHQE <newTag>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private TaskAwaiter<TaskStatus> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8B325F0", Offset = "0x8B30FF0", VA = "0x188B325F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8B32AC0", Offset = "0x8B314C0", VA = "0x188B32AC0", Slot = "5")]
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
			public AUUIGJAEHZJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private TaskAwaiter<RecNetResult<List<RoomInventoryItemTagDTO>>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8B31B80", Offset = "0x8B30580", VA = "0x188B31B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8B32580", Offset = "0x8B30F80", VA = "0x188B32580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly TimeSpan OLZREAUHIHR;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float KYKTVBHQMHS = 10f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const float BJCXAPWTFIL = 3f;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal const int OTQIPFIFMUE = 3;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal const string LIDQKZEZCKT = "econ_room_inventory_gate";

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal const string WIKGVATRTUT = "experiences_room_inventory_tags_gate";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly DOMNRDONAKM DAXDWIVMCPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly SIOBNEMWEOV IVPZOIBIMUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly SYFDLCQHKGU TVYHAWKYDUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly AXMQLGQBSBH NERWDZTOFKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KAWLYJYMFUG ZQDVNRIFAEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly URMDQZJLZQY WNTNXQSUSPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly XXWNNZHXIHL WYETQWNOSDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly UMRQDCZPWJK KVZFQJOWBUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly MMTKFEAGWJH PCHTZAWTTDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly JKQOUQREHUH KRKHUIJJYDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly XIJDDOLAGJX IRNTFPXWLZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly RoomInventoryItemPropertiesCache HNNKJSIXKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly CancellationTokenSource UVBNWFZQMDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly KeyValueRequestBatcher<RoomInventoryItemUniqueId, AddOrRemovePlayerRoomInventoryItemCountResponseDTO> ZWCLHEJZRHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly KeyValueRequestBatcher<long, RoomInventoryItemTagDTO> RXGBRORLKXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly HXSONKMYTQG RYAHDEWKAFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly IDisposable UGVSNSLRWGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Task OPQIFRGHYLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private CancellationTokenSource IDFXZRPDDQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private long NAXMDTQMXPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool VACBKMVGOGA;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private FTVZVRKLTVG HALNHMPUGJR
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8B215B0", Offset = "0x8B1FFB0", VA = "0x188B215B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public MWKYWAOJZRV QNCCBUDTBZM
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xC28940", Offset = "0xC27340", VA = "0x180C28940", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x14629A0", Offset = "0x14613A0", VA = "0x1814629A0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IXZHGEZUADS<RoomInventoryItem> LHCZIQFZKAP
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xC0E100", Offset = "0xC0CB00", VA = "0x180C0E100", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xC0E110", Offset = "0xC0CB10", VA = "0x180C0E110", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IXZHGEZUADS<Guid> PMUETFEWKTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xBB45E0", Offset = "0xBB2FE0", VA = "0x180BB45E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x10B30B0", Offset = "0x10B1AB0", VA = "0x1810B30B0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IYPBXZHMCLT<PlayerRoomInventoryItem, int> HZAXAWFQWNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xB9D2F0", Offset = "0xB9BCF0", VA = "0x180B9D2F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB2FA60", Offset = "0xB2E460", VA = "0x180B2FA60", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IXZHGEZUADS<AUYEBSREHQE> PHLDUYUXWHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F20", Offset = "0xABF920", VA = "0x180AC0F20", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAC0C30", Offset = "0xABF630", VA = "0x180AC0C30", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IXZHGEZUADS<long> LFLQHEYIRMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCAF650", Offset = "0xCAE050", VA = "0x180CAF650", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xE39090", Offset = "0xE37A90", VA = "0x180E39090", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MWKYWAOJZRV BRLQILUZMAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xCAF630", Offset = "0xCAE030", VA = "0x180CAF630", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1463BA0", Offset = "0x14625A0", VA = "0x181463BA0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MWKYWAOJZRV QXOADTKHVPC
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xCAF640", Offset = "0xCAE040", VA = "0x180CAF640", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1463750", Offset = "0x1462150", VA = "0x181463750", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8B24B20", Offset = "0x8B23520", VA = "0x188B24B20")]
		[UKOBXVXKPZF.Session.GameOnly]
		internal static void SWMNZJEUWLS(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8B27000", Offset = "0x8B25A00", VA = "0x188B27000")]
		[RecRoom.NoEngine.Common.Preserve]
		public AUUIGJAEHZJ([Inject(null)] DOMNRDONAKM recNetRoomInventory, [Inject(null)] SIOBNEMWEOV recNetRoomInventoryTags, [Inject(null)] SYFDLCQHKGU recNetRoomEconConfigs, [Inject(null)] AXMQLGQBSBH matchmakingProvider, [Inject(null)] MXHAAQVHJOK roomLoader, [Inject(null)] KAWLYJYMFUG taskDelay, [Inject(null)] URMDQZJLZQY rpcForwarder, [Inject(null)] DRYMHQJXVYT recNetPhotonAccess, [Inject(null)] NPBYLIDRIFF cacheFactory, [Inject(null)] XXWNNZHXIHL statsig, [Inject(null)] UMRQDCZPWJK platformManager, [Inject(null)] MMTKFEAGWJH sessionManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8B21060", Offset = "0x8B1FA60", VA = "0x188B21060", Slot = "53")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8B26470", Offset = "0x8B24E70", VA = "0x188B26470", Slot = "52")]
		public Task XFMWHYISVEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8B207B0", Offset = "0x8B1F1B0", VA = "0x188B207B0", Slot = "20")]
		[AsyncStateMachine(typeof(<CreateRoomInventoryItem>d__66))]
		public Task<Result<RoomInventoryItem, string>> CreateRoomInventoryItem(Guid? originId, long roomId, string name, string description, string imageName, RoomInventoryItemProperties properties, byte shape, int color, [Optional] List<long> tagIds, [Optional] List<RoomInventoryItemTagDTO> newTags, bool allowRename = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8B25450", Offset = "0x8B23E50", VA = "0x188B25450", Slot = "21")]
		[AsyncStateMachine(typeof(<UpdateRoomInventoryItem>d__67))]
		public Task<Result<RoomInventoryItem, string>> UpdateRoomInventoryItem(Guid roomInventoryItemId, long roomId, [Optional] string name, [Optional] string description, [Optional] string imageName, [Optional] List<long> tagIds, [Optional] Dictionary<string, RoomInventoryTagClientProperties> newTags, [Optional] RoomInventoryItemProperties properties, [Optional] byte? shape, [Optional] int? color)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8B22DF0", Offset = "0x8B217F0", VA = "0x188B22DF0", Slot = "22")]
		[AsyncStateMachine(typeof(<DeleteRoomInventoryItem>d__68))]
		public Task<Result<bool, string>> MYOMZOJCLMK(Guid a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8B236F0", Offset = "0x8B220F0", VA = "0x188B236F0", Slot = "23")]
		public IReadOnlyList<RoomInventoryItem> OLDJKNEHZTL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8B23E50", Offset = "0x8B22850", VA = "0x188B23E50")]
		private List<RoomInventoryItem> QRTBCFKUVKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8B23BF0", Offset = "0x8B225F0", VA = "0x188B23BF0", Slot = "24")]
		public IReadOnlyList<RoomInventoryItem> PTKIXHGDBOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B21760", Offset = "0x8B20160", VA = "0x188B21760", Slot = "25")]
		public bool HTLLUDTTHTO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8B23D30", Offset = "0x8B22730", VA = "0x188B23D30", Slot = "26")]
		public bool QQOGTHLASDU(Guid a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8B206A0", Offset = "0x8B1F0A0", VA = "0x188B206A0", Slot = "27")]
		public bool CQDQILZVMHW(string a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8B25D30", Offset = "0x8B24730", VA = "0x188B25D30", Slot = "28")]
		public IReadOnlyList<PlayerRoomInventoryItem> VMUNEKANCWQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8B209E0", Offset = "0x8B1F3E0", VA = "0x188B209E0", Slot = "29")]
		public bool DQZNCNLHQSV(Guid a, [Out] PlayerRoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8B26510", Offset = "0x8B24F10", VA = "0x188B26510", Slot = "30")]
		public long? XPATTBPXHWM(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8B21270", Offset = "0x8B1FC70", VA = "0x188B21270", Slot = "51")]
		public void EDRLNUNMXXU(IEnumerable<PlayerRoomInventoryItemDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8B26860", Offset = "0x8B25260", VA = "0x188B26860", Slot = "31")]
		[AsyncStateMachine(typeof(<CV2GetPlayerRoomInventoryItemCount>d__80))]
		public Task<int> YKSQUAOMPKI(RHIZVYSCBOY a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8B23050", Offset = "0x8B21A50", VA = "0x188B23050", Slot = "32")]
		[AsyncStateMachine(typeof(<Cv2AddOrRemovePlayerRoomInventoryItem>d__81))]
		public Task<GOGSUWECEMR> NVXKZWZGDLZ(RHIZVYSCBOY a, Guid b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8B21C60", Offset = "0x8B20660", VA = "0x188B21C60", Slot = "33")]
		public string IYLYXKNVAHM(PlayerRoomInventoryOperationResult a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B26690", Offset = "0x8B25090", VA = "0x188B26690", Slot = "34")]
		public bool XQJVPDCSRMJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8B23C00", Offset = "0x8B22600", VA = "0x188B23C00", Slot = "38")]
		[AsyncStateMachine(typeof(<UpdateRoomInventoryTag>d__84))]
		public Task<Result<AUYEBSREHQE, string>> PUBBARXUBXX(long a, RoomInventoryTagClientProperties b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8B22340", Offset = "0x8B20D40", VA = "0x188B22340", Slot = "39")]
		[AsyncStateMachine(typeof(<DeleteRoomInventoryTag>d__85))]
		public Task<Result<bool, string>> KMIDTQKDPHB(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8B26B00", Offset = "0x8B25500", VA = "0x188B26B00", Slot = "42")]
		public List<(long, int)> ZAWYMDZPEMS(long a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B26F10", Offset = "0x8B25910", VA = "0x188B26F10", Slot = "43")]
		public bool ZPWBIPOORIU(long a, [Out] AUYEBSREHQE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8B24940", Offset = "0x8B23340", VA = "0x188B24940", Slot = "44")]
		public bool SAFMHRNXTOO(string a, [Out] AUYEBSREHQE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8B25080", Offset = "0x8B23A80", VA = "0x188B25080", Slot = "45")]
		public bool TXBXNPNXPEB(long a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8B20450", Offset = "0x8B1EE50", VA = "0x188B20450", Slot = "46")]
		public IReadOnlyList<AUYEBSREHQE> ATBDZVFYEOX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8B240F0", Offset = "0x8B22AF0", VA = "0x188B240F0", Slot = "47")]
		public List<AUYEBSREHQE> RNBQFQAJGQB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8B226E0", Offset = "0x8B210E0", VA = "0x188B226E0", Slot = "48")]
		public IReadOnlyList<AUYEBSREHQE> LNHRNYOLNRK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8B22A90", Offset = "0x8B21490", VA = "0x188B22A90", Slot = "41")]
		public bool MCODPSWYQFX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8B24DB0", Offset = "0x8B237B0", VA = "0x188B24DB0", Slot = "49")]
		public IReadOnlyList<RoomInventoryItem> TUMUHHQYJES(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8B22090", Offset = "0x8B20A90", VA = "0x188B22090", Slot = "40")]
		[AsyncStateMachine(typeof(<SetSortingTabIsEnabledForRoom>d__95))]
		public Task<Result<bool, string>> KDIFBSAPRIZ(long a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8B20970", Offset = "0x8B1F370", VA = "0x188B20970", Slot = "54")]
		public bool DKMDLNDIDNE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8B23250", Offset = "0x8B21C50", VA = "0x188B23250", Slot = "50")]
		public bool OFFYIJQWQXQ(string a, [Out] IReadOnlyList<RoomInventoryItem> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8B25610", Offset = "0x8B24010", VA = "0x188B25610")]
		[AsyncStateMachine(typeof(<UpdateRoomInventoryTagServiceCall>d__98))]
		private Task<Dictionary<long, RoomInventoryItemTagDTO>> UpdateRoomInventoryTagServiceCall(Dictionary<long, int> requests, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8B21E30", Offset = "0x8B20830", VA = "0x188B21E30")]
		[AsyncStateMachine(typeof(<AddOrRemovePlayerRoomInventoryItemToLocalPlayer>d__99))]
		private Task<GOGSUWECEMR> JDMQDXHYCUB(Guid a, int b, [Optional] Guid c, [Optional] RHIZVYSCBOY d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B22530", Offset = "0x8B20F30", VA = "0x188B22530")]
		[AsyncStateMachine(typeof(<AddOrRemovePlayerRoomInventoryServiceCall>d__100))]
		private Task<Dictionary<RoomInventoryItemUniqueId, AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> LHJKDEWXYFE(Dictionary<RoomInventoryItemUniqueId, int> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8B21600", Offset = "0x8B20000", VA = "0x188B21600")]
		[AsyncStateMachine(typeof(<SendRecNetAwardRequestAndRetryOnConcurrencyMismatch>d__101))]
		private Task<List<AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> FPXDBOXKZON(Dictionary<RoomInventoryItemUniqueId, int> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8B22F20", Offset = "0x8B21920", VA = "0x188B22F20")]
		[AsyncStateMachine(typeof(<DownloadRoomInventory>d__102))]
		private Task NVMHTRDNSWY(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8B237A0", Offset = "0x8B221A0", VA = "0x188B237A0")]
		private Task OnRoomLoadStarted(KQLCQATBHLS args, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8B22460", Offset = "0x8B20E60", VA = "0x188B22460")]
		[AsyncStateMachine(typeof(<OnRoomLoadComplete>d__104))]
		private Task KRMYNGFIOJE(KQLCQATBHLS a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B20510", Offset = "0x8B1EF10", VA = "0x188B20510")]
		private void BNRABQNDSSB(RoomInventoryItemDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8B24490", Offset = "0x8B22E90", VA = "0x188B24490")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string serializedRoomInventoryItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8B26700", Offset = "0x8B25100", VA = "0x188B26700")]
		private void YHDSSRFBUBI(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8B245D0", Offset = "0x8B22FD0", VA = "0x188B245D0")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid roomInventoryItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8B20200", Offset = "0x8B1EC00", VA = "0x188B20200")]
		[AsyncStateMachine(typeof(<SendGetPlayerRoomInventoryCountRequest>d__109))]
		private Task<int> ACXNIJUOTRN(RHIZVYSCBOY a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8B242C0", Offset = "0x8B22CC0", VA = "0x188B242C0")]
		[RPCMethod]
		internal void RpcGetPlayerRoomInventoryCount(Guid operationId, Guid roomInventoryItemId, RPCInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8B24240", Offset = "0x8B22C40", VA = "0x188B24240")]
		[RPCMethod]
		internal void RpcGetPlayerRoomInventoryCountResponse(Guid operationId, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8B22C30", Offset = "0x8B21630", VA = "0x188B22C30")]
		[AsyncStateMachine(typeof(<SendAddOrRemovePlayerRoomInventoryRequestToPlayer>d__112))]
		private Task<GOGSUWECEMR> MKMORJIDBJU(RHIZVYSCBOY a, Guid b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8B24170", Offset = "0x8B22B70", VA = "0x188B24170")]
		[RPCMethod]
		internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid operationId, Guid roomInventoryItemId, int quantity, RPCInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8B221B0", Offset = "0x8B20BB0", VA = "0x188B221B0")]
		private void KIZEXRITBSU(RHIZVYSCBOY a, Guid b, PlayerRoomInventoryOperationResult c, long d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8B24880", Offset = "0x8B23280", VA = "0x188B24880")]
		[RPCMethod]
		internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid operationId, int result, long playerOwnedCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8B249C0", Offset = "0x8B233C0", VA = "0x188B249C0")]
		private void SAOFPMYBROQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8B24820", Offset = "0x8B23220", VA = "0x188B24820")]
		[RPCMethod]
		private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool isEnabledBool)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8B22B10", Offset = "0x8B21510", VA = "0x188B22B10")]
		private void MJSSJHVFFJO(List<RoomInventoryItemTagDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8B24670", Offset = "0x8B23070", VA = "0x188B24670")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryTagUpdates(string serializedTags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8B269A0", Offset = "0x8B253A0", VA = "0x188B269A0")]
		private void YZSYORMJXLN(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8B24600", Offset = "0x8B23000", VA = "0x188B24600")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryTagDeleted(long tagId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8B24B90", Offset = "0x8B23590", VA = "0x188B24B90")]
		private RoomInventoryItem TPHQWAFXFBI(RoomInventoryItemDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8B25280", Offset = "0x8B23C80", VA = "0x188B25280")]
		private List<AUYEBSREHQE> UWZIJYWZSZX(List<RoomInventoryItemTagDTO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8B260B0", Offset = "0x8B24AB0", VA = "0x188B260B0")]
		private List<AUYEBSREHQE> VXGIWMGSEBX(IEnumerable<RoomInventoryItemTagDTO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8B20C40", Offset = "0x8B1F640", VA = "0x188B20C40", Slot = "36")]
		public RoomInventoryItemProperties DeserializeRoomInventoryItemProperties(string serializedRoomInventoryItemPropertyString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8B25B90", Offset = "0x8B24590", VA = "0x188B25B90")]
		private RoomInventoryItem VDPOSDGZMPH(RoomInventoryItemDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8B20B00", Offset = "0x8B1F500", VA = "0x188B20B00", Slot = "35")]
		public RoomInventoryItemDTO DehydrateRoomInventoryItemToDTO(RoomInventoryItem inventoryItem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8B21860", Offset = "0x8B20260", VA = "0x188B21860")]
		private AUYEBSREHQE HydrateRoomInventoryTagFromDTO(RoomInventoryItemTagDTO dto)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8B22D80", Offset = "0x8B21780", VA = "0x188B22D80")]
		private void MQCGGEZHKLX(PlayerRoomInventoryItem a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8B22670", Offset = "0x8B21070", VA = "0x188B22670")]
		private void LICNMYLXJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8B21AE0", Offset = "0x8B204E0", VA = "0x188B21AE0")]
		private Task IPHTNUZGAKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8B20630", Offset = "0x8B1F030", VA = "0x188B20630")]
		private void CGRCISDZNSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8B231A0", Offset = "0x8B21BA0", VA = "0x188B231A0")]
		private void NWJYLAQIUBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8B21F80", Offset = "0x8B20980", VA = "0x188B21F80")]
		private void JMTAHWGONKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8B20340", Offset = "0x8B1ED40", VA = "0x188B20340")]
		[AsyncStateMachine(typeof(<CullTagsOnDelete>d__135))]
		private Task ADGEXMKXEFO(RoomInventoryItem a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8B21740", Offset = "0x8B20140", VA = "0x188B21740")]
		[CompilerGenerated]
		private void GIGKFNJLLAF(Task<TaskStatus> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8B25750", Offset = "0x8B24150", VA = "0x188B25750")]
		[CompilerGenerated]
		private Task<PlayerRoomInventoryOperationResult> VASVHVYTKOS(<>c__DisplayClass99_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8B25F00", Offset = "0x8B24900", VA = "0x188B25F00")]
		[CompilerGenerated]
		internal static Dictionary<RoomInventoryItemUniqueId, AddOrRemovePlayerRoomInventoryItemCountResponseDTO> VNRCFJBDNZC(PlayerRoomInventoryOperationResult a, <>c__DisplayClass100_0 b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RoomInventoryItemPropertiesCache : Dictionary<string, RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B29550", Offset = "0x8B27F50", VA = "0x188B29550")]
		public RoomInventoryItemPropertiesCache()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface NPBYLIDRIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JKQOUQREHUH OFBFRCKKAVZ();

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RoomInventoryItemPropertiesCache JJPLMVGSLRC();

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		XIJDDOLAGJX XAUPHEHHKVH();
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class QQWPFHAIWVF : NPBYLIDRIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B29400", Offset = "0x8B27E00", VA = "0x188B29400")]
		[UKOBXVXKPZF.Session.GameOnly]
		internal static void SWMNZJEUWLS(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		[RecRoom.NoEngine.Common.Preserve]
		public QQWPFHAIWVF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B29300", Offset = "0x8B27D00", VA = "0x188B29300", Slot = "4")]
		public JKQOUQREHUH OFBFRCKKAVZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B29290", Offset = "0x8B27C90", VA = "0x188B29290", Slot = "5")]
		public RoomInventoryItemPropertiesCache JJPLMVGSLRC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B29470", Offset = "0x8B27E70", VA = "0x188B29470", Slot = "6")]
		public XIJDDOLAGJX XAUPHEHHKVH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class XIJDDOLAGJX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly Dictionary<long, AUYEBSREHQE> MHQVDHKUYGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly AUYEBSREHQE[] MYWUKKSIKYO;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool KBVFEHXBKUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xB0A2C0", Offset = "0xB08CC0", VA = "0x180B0A2C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xB50EF0", Offset = "0xB4F8F0", VA = "0x180B50EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int MLGJFWQNYDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x8B33980", Offset = "0x8B32380", VA = "0x188B33980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private long GXMKUYFUACX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xABED30", Offset = "0xABD730", VA = "0x180ABED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B33100", Offset = "0x8B31B00", VA = "0x188B33100")]
		public void NewRoom(long roomId, IEnumerable<AUYEBSREHQE> tags, bool sortingTabIsEnabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B32F50", Offset = "0x8B31950", VA = "0x188B32F50")]
		public IReadOnlyList<AUYEBSREHQE> MDECUJYLROX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xB50EF0", Offset = "0xB4F8F0", VA = "0x180B50EF0")]
		public void VRSJDBIFPRY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B335B0", Offset = "0x8B31FB0", VA = "0x188B335B0")]
		public bool ODXYUNSCEZL(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B339E0", Offset = "0x8B323E0", VA = "0x188B339E0")]
		public bool ZSGBIWVFFXM(AUYEBSREHQE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B32C30", Offset = "0x8B31630", VA = "0x188B32C30")]
		public bool JBFUKJCVYCW(List<AUYEBSREHQE> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B32B90", Offset = "0x8B31590", VA = "0x188B32B90")]
		public bool FQXJLBASVCD(long a, [Out] AUYEBSREHQE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8B337D0", Offset = "0x8B321D0", VA = "0x188B337D0")]
		public bool VOANURTVYJD(string a, [Out] AUYEBSREHQE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B33BA0", Offset = "0x8B325A0", VA = "0x188B33BA0")]
		public List<AUYEBSREHQE> ZWBSFWQUHON(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8B33690", Offset = "0x8B32090", VA = "0x188B33690")]
		public List<AUYEBSREHQE> QBMVECUPDRJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85EAA00", Offset = "0x85E9400", VA = "0x1885EAA00")]
		public AUYEBSREHQE KDTUMHABQUX(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B32B30", Offset = "0x8B31530", VA = "0x188B32B30")]
		public IReadOnlyList<AUYEBSREHQE> ASDKDNXFUMV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8B33C70", Offset = "0x8B32670", VA = "0x188B33C70")]
		public XIJDDOLAGJX()
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
