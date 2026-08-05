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
		[Cpp2IlInjected.Address(RVA = "0x8A31970", Offset = "0x8A30170", VA = "0x188A31970", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2735A30", Offset = "0x2734230", VA = "0x182735A30")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA7DE0", Offset = "0xAA65E0", VA = "0x180AA7DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public KVTDFPAGHTN this[Guid index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8A26EF0", Offset = "0x8A256F0", VA = "0x188A26EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A25E90", Offset = "0x8A24690", VA = "0x188A25E90")]
		public void NewRoom(long roomId, IEnumerable<RoomInventoryItem> roomInventoryItems, IEnumerable<PlayerRoomInventoryItem> playerRoomInventoryItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8A26DC0", Offset = "0x8A255C0", VA = "0x188A26DC0")]
		public bool XKLKRGTBXGB(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A26840", Offset = "0x8A25040", VA = "0x188A26840")]
		public bool Remove(Guid roomInventoryItemId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8A257B0", Offset = "0x8A23FB0", VA = "0x188A257B0")]
		public bool AZBYPRFQIKL(RoomInventoryItem a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A26D70", Offset = "0x8A25570", VA = "0x188A26D70")]
		public IEnumerable<KVTDFPAGHTN> XHICTZTCXRS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8A25C10", Offset = "0x8A24410", VA = "0x188A25C10")]
		public IEnumerable<RoomInventoryItem> HXWMDXOQRKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A25D50", Offset = "0x8A24550", VA = "0x188A25D50")]
		public IEnumerable<PlayerRoomInventoryItem> IYYOGXDVOIW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8A26710", Offset = "0x8A24F10", VA = "0x188A26710")]
		public bool QQOGTHLASDU(Guid a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8A259E0", Offset = "0x8A241E0", VA = "0x188A259E0")]
		public bool CQDQILZVMHW(string a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A25A80", Offset = "0x8A24280", VA = "0x188A25A80")]
		public bool DQZNCNLHQSV(Guid a, [Out] PlayerRoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A25B70", Offset = "0x8A24370", VA = "0x188A25B70")]
		public bool GJOSRGUPYHO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8A267C0", Offset = "0x8A24FC0", VA = "0x188A267C0")]
		private bool QROEPJJKAAD(RoomInventoryItem a, RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8A26B30", Offset = "0x8A25330", VA = "0x188A26B30")]
		private void VNAKGDZTHCN(Guid a, KVTDFPAGHTN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A264D0", Offset = "0x8A24CD0", VA = "0x188A264D0")]
		private bool OEMQYYLCEIC(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8A26A40", Offset = "0x8A25240", VA = "0x188A26A40")]
		private void VKGXHTLFRJA(RoomInventoryItem a, [Optional] RoomInventoryItem b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8A26860", Offset = "0x8A25060", VA = "0x188A26860")]
		private bool UKYTOBKYYVM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8A25B30", Offset = "0x8A24330", VA = "0x188A25B30")]
		private static bool FOYHKGYOJDX(RoomInventoryItem a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8A26E20", Offset = "0x8A25620", VA = "0x188A26E20")]
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
			[Cpp2IlInjected.Address(RVA = "0x52FAB40", Offset = "0x52F9340", VA = "0x1852FAB40")]
			public RoomInventoryItemUniqueId(long roomId, Guid roomInventoryItemId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8A273A0", Offset = "0x8A25BA0", VA = "0x188A273A0", Slot = "4")]
			public bool Equals(RoomInventoryItemUniqueId other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8A27250", Offset = "0x8A25A50", VA = "0x188A27250", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8A274A0", Offset = "0x8A25CA0", VA = "0x188A274A0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public TGQZOCWQIMR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8A27520", Offset = "0x8A25D20", VA = "0x188A27520")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A27580", Offset = "0x8A25D80", VA = "0x188A27580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8A279A0", Offset = "0x8A261A0", VA = "0x188A279A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A27A10", Offset = "0x8A26210", VA = "0x188A27A10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8A28490", Offset = "0x8A26C90", VA = "0x188A28490", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A28500", Offset = "0x8A26D00", VA = "0x188A28500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8A288D0", Offset = "0x8A270D0", VA = "0x188A288D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A28940", Offset = "0x8A27140", VA = "0x188A28940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8A28EA0", Offset = "0x8A276A0", VA = "0x188A28EA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A28F10", Offset = "0x8A27710", VA = "0x188A28F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8A298F0", Offset = "0x8A280F0", VA = "0x188A298F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A29950", Offset = "0x8A28150", VA = "0x188A29950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8A29DB0", Offset = "0x8A285B0", VA = "0x188A29DB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A29E20", Offset = "0x8A28620", VA = "0x188A29E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8A2A5F0", Offset = "0x8A28DF0", VA = "0x188A2A5F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A2A660", Offset = "0x8A28E60", VA = "0x188A2A660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8A2B270", Offset = "0x8A29A70", VA = "0x188A2B270", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A2B2E0", Offset = "0x8A29AE0", VA = "0x188A2B2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8A2C530", Offset = "0x8A2AD30", VA = "0x188A2C530", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A2C590", Offset = "0x8A2AD90", VA = "0x188A2C590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8A2CC20", Offset = "0x8A2B420", VA = "0x188A2CC20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A2CC80", Offset = "0x8A2B480", VA = "0x188A2CC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8A2D170", Offset = "0x8A2B970", VA = "0x188A2D170", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A2D1E0", Offset = "0x8A2B9E0", VA = "0x188A2D1E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8A2D6C0", Offset = "0x8A2BEC0", VA = "0x188A2D6C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A2D730", Offset = "0x8A2BF30", VA = "0x188A2D730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8A2E650", Offset = "0x8A2CE50", VA = "0x188A2E650", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A2E6C0", Offset = "0x8A2CEC0", VA = "0x188A2E6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8A2EC10", Offset = "0x8A2D410", VA = "0x188A2EC10", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A2EED0", Offset = "0x8A2D6D0", VA = "0x188A2EED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8A2F760", Offset = "0x8A2DF60", VA = "0x188A2F760", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A30240", Offset = "0x8A2EA40", VA = "0x188A30240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8A30710", Offset = "0x8A2EF10", VA = "0x188A30710", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A2F7D0", Offset = "0x8A2DFD0", VA = "0x188A2F7D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8A301D0", Offset = "0x8A2E9D0", VA = "0x188A301D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A1F290", Offset = "0x8A1DA90", VA = "0x188A1F290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public MWKYWAOJZRV QNCCBUDTBZM
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xC11710", Offset = "0xC0FF10", VA = "0x180C11710", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x144B510", Offset = "0x1449D10", VA = "0x18144B510", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IXZHGEZUADS<RoomInventoryItem> LHCZIQFZKAP
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xBF6EC0", Offset = "0xBF56C0", VA = "0x180BF6EC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xBF6ED0", Offset = "0xBF56D0", VA = "0x180BF6ED0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IXZHGEZUADS<Guid> PMUETFEWKTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB9D440", Offset = "0xB9BC40", VA = "0x180B9D440", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x109B880", Offset = "0x109A080", VA = "0x18109B880", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IYPBXZHMCLT<PlayerRoomInventoryItem, int> HZAXAWFQWNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xB86160", Offset = "0xB84960", VA = "0x180B86160", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB189A0", Offset = "0xB171A0", VA = "0x180B189A0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IXZHGEZUADS<AUYEBSREHQE> PHLDUYUXWHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA8830", VA = "0x180AAA030", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAA9D30", Offset = "0xAA8530", VA = "0x180AA9D30", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IXZHGEZUADS<long> LFLQHEYIRMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xC98330", Offset = "0xC96B30", VA = "0x180C98330", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xE217C0", Offset = "0xE1FFC0", VA = "0x180E217C0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MWKYWAOJZRV BRLQILUZMAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xC98310", Offset = "0xC96B10", VA = "0x180C98310", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x144C710", Offset = "0x144AF10", VA = "0x18144C710", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MWKYWAOJZRV QXOADTKHVPC
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xC98320", Offset = "0xC96B20", VA = "0x180C98320", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x144C2C0", Offset = "0x144AAC0", VA = "0x18144C2C0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8A22810", Offset = "0x8A21010", VA = "0x188A22810")]
		[UKOBXVXKPZF.Session.GameOnly]
		internal static void SWMNZJEUWLS(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8A24CE0", Offset = "0x8A234E0", VA = "0x188A24CE0")]
		[RecRoom.NoEngine.Common.Preserve]
		public AUUIGJAEHZJ([Inject(null)] DOMNRDONAKM recNetRoomInventory, [Inject(null)] SIOBNEMWEOV recNetRoomInventoryTags, [Inject(null)] SYFDLCQHKGU recNetRoomEconConfigs, [Inject(null)] AXMQLGQBSBH matchmakingProvider, [Inject(null)] MXHAAQVHJOK roomLoader, [Inject(null)] KAWLYJYMFUG taskDelay, [Inject(null)] URMDQZJLZQY rpcForwarder, [Inject(null)] DRYMHQJXVYT recNetPhotonAccess, [Inject(null)] NPBYLIDRIFF cacheFactory, [Inject(null)] XXWNNZHXIHL statsig, [Inject(null)] UMRQDCZPWJK platformManager, [Inject(null)] MMTKFEAGWJH sessionManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8A1ED40", Offset = "0x8A1D540", VA = "0x188A1ED40", Slot = "53")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8A24150", Offset = "0x8A22950", VA = "0x188A24150", Slot = "52")]
		public Task XFMWHYISVEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E480", Offset = "0x8A1CC80", VA = "0x188A1E480", Slot = "20")]
		[AsyncStateMachine(typeof(<CreateRoomInventoryItem>d__66))]
		public Task<Result<RoomInventoryItem, string>> CreateRoomInventoryItem(Guid? originId, long roomId, string name, string description, string imageName, RoomInventoryItemProperties properties, byte shape, int color, [Optional] List<long> tagIds, [Optional] List<RoomInventoryItemTagDTO> newTags, bool allowRename = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A23130", Offset = "0x8A21930", VA = "0x188A23130", Slot = "21")]
		[AsyncStateMachine(typeof(<UpdateRoomInventoryItem>d__67))]
		public Task<Result<RoomInventoryItem, string>> UpdateRoomInventoryItem(Guid roomInventoryItemId, long roomId, [Optional] string name, [Optional] string description, [Optional] string imageName, [Optional] List<long> tagIds, [Optional] Dictionary<string, RoomInventoryTagClientProperties> newTags, [Optional] RoomInventoryItemProperties properties, [Optional] byte? shape, [Optional] int? color)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8A20AE0", Offset = "0x8A1F2E0", VA = "0x188A20AE0", Slot = "22")]
		[AsyncStateMachine(typeof(<DeleteRoomInventoryItem>d__68))]
		public Task<Result<bool, string>> MYOMZOJCLMK(Guid a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8A213E0", Offset = "0x8A1FBE0", VA = "0x188A213E0", Slot = "23")]
		public IReadOnlyList<RoomInventoryItem> OLDJKNEHZTL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8A21B40", Offset = "0x8A20340", VA = "0x188A21B40")]
		private List<RoomInventoryItem> QRTBCFKUVKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8A218E0", Offset = "0x8A200E0", VA = "0x188A218E0", Slot = "24")]
		public IReadOnlyList<RoomInventoryItem> PTKIXHGDBOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F440", Offset = "0x8A1DC40", VA = "0x188A1F440", Slot = "25")]
		public bool HTLLUDTTHTO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8A21A20", Offset = "0x8A20220", VA = "0x188A21A20", Slot = "26")]
		public bool QQOGTHLASDU(Guid a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E370", Offset = "0x8A1CB70", VA = "0x188A1E370", Slot = "27")]
		public bool CQDQILZVMHW(string a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8A23A10", Offset = "0x8A22210", VA = "0x188A23A10", Slot = "28")]
		public IReadOnlyList<PlayerRoomInventoryItem> VMUNEKANCWQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E6B0", Offset = "0x8A1CEB0", VA = "0x188A1E6B0", Slot = "29")]
		public bool DQZNCNLHQSV(Guid a, [Out] PlayerRoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8A241F0", Offset = "0x8A229F0", VA = "0x188A241F0", Slot = "30")]
		public long? XPATTBPXHWM(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8A1EF50", Offset = "0x8A1D750", VA = "0x188A1EF50", Slot = "51")]
		public void EDRLNUNMXXU(IEnumerable<PlayerRoomInventoryItemDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A24540", Offset = "0x8A22D40", VA = "0x188A24540", Slot = "31")]
		[AsyncStateMachine(typeof(<CV2GetPlayerRoomInventoryItemCount>d__80))]
		public Task<int> YKSQUAOMPKI(RHIZVYSCBOY a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8A20D40", Offset = "0x8A1F540", VA = "0x188A20D40", Slot = "32")]
		[AsyncStateMachine(typeof(<Cv2AddOrRemovePlayerRoomInventoryItem>d__81))]
		public Task<GOGSUWECEMR> NVXKZWZGDLZ(RHIZVYSCBOY a, Guid b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F950", Offset = "0x8A1E150", VA = "0x188A1F950", Slot = "33")]
		public string IYLYXKNVAHM(PlayerRoomInventoryOperationResult a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A24370", Offset = "0x8A22B70", VA = "0x188A24370", Slot = "34")]
		public bool XQJVPDCSRMJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8A218F0", Offset = "0x8A200F0", VA = "0x188A218F0", Slot = "38")]
		[AsyncStateMachine(typeof(<UpdateRoomInventoryTag>d__84))]
		public Task<Result<AUYEBSREHQE, string>> PUBBARXUBXX(long a, RoomInventoryTagClientProperties b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8A20030", Offset = "0x8A1E830", VA = "0x188A20030", Slot = "39")]
		[AsyncStateMachine(typeof(<DeleteRoomInventoryTag>d__85))]
		public Task<Result<bool, string>> KMIDTQKDPHB(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8A247E0", Offset = "0x8A22FE0", VA = "0x188A247E0", Slot = "42")]
		public List<(long, int)> ZAWYMDZPEMS(long a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8A24BF0", Offset = "0x8A233F0", VA = "0x188A24BF0", Slot = "43")]
		public bool ZPWBIPOORIU(long a, [Out] AUYEBSREHQE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8A22630", Offset = "0x8A20E30", VA = "0x188A22630", Slot = "44")]
		public bool SAFMHRNXTOO(string a, [Out] AUYEBSREHQE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8A22D60", Offset = "0x8A21560", VA = "0x188A22D60", Slot = "45")]
		public bool TXBXNPNXPEB(long a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E120", Offset = "0x8A1C920", VA = "0x188A1E120", Slot = "46")]
		public IReadOnlyList<AUYEBSREHQE> ATBDZVFYEOX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8A21DE0", Offset = "0x8A205E0", VA = "0x188A21DE0", Slot = "47")]
		public List<AUYEBSREHQE> RNBQFQAJGQB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8A203D0", Offset = "0x8A1EBD0", VA = "0x188A203D0", Slot = "48")]
		public IReadOnlyList<AUYEBSREHQE> LNHRNYOLNRK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8A20780", Offset = "0x8A1EF80", VA = "0x188A20780", Slot = "41")]
		public bool MCODPSWYQFX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8A22AA0", Offset = "0x8A212A0", VA = "0x188A22AA0", Slot = "49")]
		public IReadOnlyList<RoomInventoryItem> TUMUHHQYJES(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8A1FD80", Offset = "0x8A1E580", VA = "0x188A1FD80", Slot = "40")]
		[AsyncStateMachine(typeof(<SetSortingTabIsEnabledForRoom>d__95))]
		public Task<Result<bool, string>> KDIFBSAPRIZ(long a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E640", Offset = "0x8A1CE40", VA = "0x188A1E640", Slot = "54")]
		public bool DKMDLNDIDNE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8A20F40", Offset = "0x8A1F740", VA = "0x188A20F40", Slot = "50")]
		public bool OFFYIJQWQXQ(string a, [Out] IReadOnlyList<RoomInventoryItem> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8A232F0", Offset = "0x8A21AF0", VA = "0x188A232F0")]
		[AsyncStateMachine(typeof(<UpdateRoomInventoryTagServiceCall>d__98))]
		private Task<Dictionary<long, RoomInventoryItemTagDTO>> UpdateRoomInventoryTagServiceCall(Dictionary<long, int> requests, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8A1FB20", Offset = "0x8A1E320", VA = "0x188A1FB20")]
		[AsyncStateMachine(typeof(<AddOrRemovePlayerRoomInventoryItemToLocalPlayer>d__99))]
		private Task<GOGSUWECEMR> JDMQDXHYCUB(Guid a, int b, [Optional] Guid c, [Optional] RHIZVYSCBOY d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8A20220", Offset = "0x8A1EA20", VA = "0x188A20220")]
		[AsyncStateMachine(typeof(<AddOrRemovePlayerRoomInventoryServiceCall>d__100))]
		private Task<Dictionary<RoomInventoryItemUniqueId, AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> LHJKDEWXYFE(Dictionary<RoomInventoryItemUniqueId, int> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F2E0", Offset = "0x8A1DAE0", VA = "0x188A1F2E0")]
		[AsyncStateMachine(typeof(<SendRecNetAwardRequestAndRetryOnConcurrencyMismatch>d__101))]
		private Task<List<AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> FPXDBOXKZON(Dictionary<RoomInventoryItemUniqueId, int> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8A20C10", Offset = "0x8A1F410", VA = "0x188A20C10")]
		[AsyncStateMachine(typeof(<DownloadRoomInventory>d__102))]
		private Task NVMHTRDNSWY(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8A21490", Offset = "0x8A1FC90", VA = "0x188A21490")]
		private Task OnRoomLoadStarted(KQLCQATBHLS args, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8A20150", Offset = "0x8A1E950", VA = "0x188A20150")]
		[AsyncStateMachine(typeof(<OnRoomLoadComplete>d__104))]
		private Task KRMYNGFIOJE(KQLCQATBHLS a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E1E0", Offset = "0x8A1C9E0", VA = "0x188A1E1E0")]
		private void BNRABQNDSSB(RoomInventoryItemDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8A22180", Offset = "0x8A20980", VA = "0x188A22180")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string serializedRoomInventoryItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8A243E0", Offset = "0x8A22BE0", VA = "0x188A243E0")]
		private void YHDSSRFBUBI(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8A222C0", Offset = "0x8A20AC0", VA = "0x188A222C0")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid roomInventoryItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8A1DED0", Offset = "0x8A1C6D0", VA = "0x188A1DED0")]
		[AsyncStateMachine(typeof(<SendGetPlayerRoomInventoryCountRequest>d__109))]
		private Task<int> ACXNIJUOTRN(RHIZVYSCBOY a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8A21FB0", Offset = "0x8A207B0", VA = "0x188A21FB0")]
		[RPCMethod]
		internal void RpcGetPlayerRoomInventoryCount(Guid operationId, Guid roomInventoryItemId, RPCInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8A21F30", Offset = "0x8A20730", VA = "0x188A21F30")]
		[RPCMethod]
		internal void RpcGetPlayerRoomInventoryCountResponse(Guid operationId, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8A20920", Offset = "0x8A1F120", VA = "0x188A20920")]
		[AsyncStateMachine(typeof(<SendAddOrRemovePlayerRoomInventoryRequestToPlayer>d__112))]
		private Task<GOGSUWECEMR> MKMORJIDBJU(RHIZVYSCBOY a, Guid b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8A21E60", Offset = "0x8A20660", VA = "0x188A21E60")]
		[RPCMethod]
		internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid operationId, Guid roomInventoryItemId, int quantity, RPCInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8A1FEA0", Offset = "0x8A1E6A0", VA = "0x188A1FEA0")]
		private void KIZEXRITBSU(RHIZVYSCBOY a, Guid b, PlayerRoomInventoryOperationResult c, long d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8A22570", Offset = "0x8A20D70", VA = "0x188A22570")]
		[RPCMethod]
		internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid operationId, int result, long playerOwnedCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8A226B0", Offset = "0x8A20EB0", VA = "0x188A226B0")]
		private void SAOFPMYBROQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8A22510", Offset = "0x8A20D10", VA = "0x188A22510")]
		[RPCMethod]
		private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool isEnabledBool)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8A20800", Offset = "0x8A1F000", VA = "0x188A20800")]
		private void MJSSJHVFFJO(List<RoomInventoryItemTagDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8A22360", Offset = "0x8A20B60", VA = "0x188A22360")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryTagUpdates(string serializedTags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8A24680", Offset = "0x8A22E80", VA = "0x188A24680")]
		private void YZSYORMJXLN(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8A222F0", Offset = "0x8A20AF0", VA = "0x188A222F0")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryTagDeleted(long tagId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8A22880", Offset = "0x8A21080", VA = "0x188A22880")]
		private RoomInventoryItem TPHQWAFXFBI(RoomInventoryItemDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8A22F60", Offset = "0x8A21760", VA = "0x188A22F60")]
		private List<AUYEBSREHQE> UWZIJYWZSZX(List<RoomInventoryItemTagDTO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8A23D90", Offset = "0x8A22590", VA = "0x188A23D90")]
		private List<AUYEBSREHQE> VXGIWMGSEBX(IEnumerable<RoomInventoryItemTagDTO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E910", Offset = "0x8A1D110", VA = "0x188A1E910", Slot = "36")]
		public RoomInventoryItemProperties DeserializeRoomInventoryItemProperties(string serializedRoomInventoryItemPropertyString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8A23870", Offset = "0x8A22070", VA = "0x188A23870")]
		private RoomInventoryItem VDPOSDGZMPH(RoomInventoryItemDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E7D0", Offset = "0x8A1CFD0", VA = "0x188A1E7D0", Slot = "35")]
		public RoomInventoryItemDTO DehydrateRoomInventoryItemToDTO(RoomInventoryItem inventoryItem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F540", Offset = "0x8A1DD40", VA = "0x188A1F540")]
		private AUYEBSREHQE HydrateRoomInventoryTagFromDTO(RoomInventoryItemTagDTO dto)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8A20A70", Offset = "0x8A1F270", VA = "0x188A20A70")]
		private void MQCGGEZHKLX(PlayerRoomInventoryItem a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8A20360", Offset = "0x8A1EB60", VA = "0x188A20360")]
		private void LICNMYLXJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F7C0", Offset = "0x8A1DFC0", VA = "0x188A1F7C0")]
		private Task IPHTNUZGAKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E300", Offset = "0x8A1CB00", VA = "0x188A1E300")]
		private void CGRCISDZNSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8A20E90", Offset = "0x8A1F690", VA = "0x188A20E90")]
		private void NWJYLAQIUBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8A1FC70", Offset = "0x8A1E470", VA = "0x188A1FC70")]
		private void JMTAHWGONKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E010", Offset = "0x8A1C810", VA = "0x188A1E010")]
		[AsyncStateMachine(typeof(<CullTagsOnDelete>d__135))]
		private Task ADGEXMKXEFO(RoomInventoryItem a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F420", Offset = "0x8A1DC20", VA = "0x188A1F420")]
		[CompilerGenerated]
		private void GIGKFNJLLAF(Task<TaskStatus> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8A23430", Offset = "0x8A21C30", VA = "0x188A23430")]
		[CompilerGenerated]
		private Task<PlayerRoomInventoryOperationResult> VASVHVYTKOS(<>c__DisplayClass99_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8A23BE0", Offset = "0x8A223E0", VA = "0x188A23BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A27210", Offset = "0x8A25A10", VA = "0x188A27210")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A270C0", Offset = "0x8A258C0", VA = "0x188A270C0")]
		[UKOBXVXKPZF.Session.GameOnly]
		internal static void SWMNZJEUWLS(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		[RecRoom.NoEngine.Common.Preserve]
		public QQWPFHAIWVF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8A26FC0", Offset = "0x8A257C0", VA = "0x188A26FC0", Slot = "4")]
		public JKQOUQREHUH OFBFRCKKAVZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8A26F50", Offset = "0x8A25750", VA = "0x188A26F50", Slot = "5")]
		public RoomInventoryItemPropertiesCache JJPLMVGSLRC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8A27130", Offset = "0x8A25930", VA = "0x188A27130", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xAF3180", Offset = "0xAF1980", VA = "0x180AF3180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xB39DA0", Offset = "0xB385A0", VA = "0x180B39DA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int MLGJFWQNYDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x8A315D0", Offset = "0x8A2FDD0", VA = "0x188A315D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private long GXMKUYFUACX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAA7DE0", Offset = "0xAA65E0", VA = "0x180AA7DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8A30D50", Offset = "0x8A2F550", VA = "0x188A30D50")]
		public void NewRoom(long roomId, IEnumerable<AUYEBSREHQE> tags, bool sortingTabIsEnabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8A30BA0", Offset = "0x8A2F3A0", VA = "0x188A30BA0")]
		public IReadOnlyList<AUYEBSREHQE> MDECUJYLROX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xB39DA0", Offset = "0xB385A0", VA = "0x180B39DA0")]
		public void VRSJDBIFPRY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8A31200", Offset = "0x8A2FA00", VA = "0x188A31200")]
		public bool ODXYUNSCEZL(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8A31630", Offset = "0x8A2FE30", VA = "0x188A31630")]
		public bool ZSGBIWVFFXM(AUYEBSREHQE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8A30880", Offset = "0x8A2F080", VA = "0x188A30880")]
		public bool JBFUKJCVYCW(List<AUYEBSREHQE> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8A307E0", Offset = "0x8A2EFE0", VA = "0x188A307E0")]
		public bool FQXJLBASVCD(long a, [Out] AUYEBSREHQE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8A31420", Offset = "0x8A2FC20", VA = "0x188A31420")]
		public bool VOANURTVYJD(string a, [Out] AUYEBSREHQE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8A317F0", Offset = "0x8A2FFF0", VA = "0x188A317F0")]
		public List<AUYEBSREHQE> ZWBSFWQUHON(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8A312E0", Offset = "0x8A2FAE0", VA = "0x188A312E0")]
		public List<AUYEBSREHQE> QBMVECUPDRJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x84E7C40", Offset = "0x84E6440", VA = "0x1884E7C40")]
		public AUYEBSREHQE KDTUMHABQUX(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8A30780", Offset = "0x8A2EF80", VA = "0x188A30780")]
		public IReadOnlyList<AUYEBSREHQE> ASDKDNXFUMV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8A318C0", Offset = "0x8A300C0", VA = "0x188A318C0")]
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
