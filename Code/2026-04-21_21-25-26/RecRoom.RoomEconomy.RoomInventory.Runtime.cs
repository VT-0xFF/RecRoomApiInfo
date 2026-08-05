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
		[Cpp2IlInjected.Address(RVA = "0xA1D0F60", Offset = "0xA1CF960", VA = "0x18A1D0F60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D0B0", Offset = "0x2A2BAB0", VA = "0x182A2D0B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface ZSMSGSVHWNY : OFEZKORVXFU
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		IXAIPQJTCTL IXAIPQJTCTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class AOVZEDOXYPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly Dictionary<Guid, DSVKLFBFXCR> HCYOTCSKNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly Dictionary<string, DSVKLFBFXCR> JKDZSQBQFDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private bool? UWSZIFYZTNQ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private long JDBDHVXRGQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DSVKLFBFXCR this[Guid index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA1BEB60", Offset = "0xA1BD560", VA = "0x18A1BEB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDBC0", Offset = "0xA1BC5C0", VA = "0x18A1BDBC0")]
		public void NewRoom(long roomId, IEnumerable<RoomInventoryItem> roomInventoryItems, IEnumerable<PlayerRoomInventoryItem> playerRoomInventoryItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDA70", Offset = "0xA1BC470", VA = "0x18A1BDA70")]
		public bool MLCKPGATKTR(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE4C0", Offset = "0xA1BCEC0", VA = "0x18A1BE4C0")]
		public bool Remove(Guid roomInventoryItemId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA1BD840", Offset = "0xA1BC240", VA = "0x18A1BD840")]
		public bool HEGTBTFMMXL(RoomInventoryItem a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE610", Offset = "0xA1BD010", VA = "0x18A1BE610")]
		public IEnumerable<DSVKLFBFXCR> WXLFLUBUGAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA1BD470", Offset = "0xA1BBE70", VA = "0x18A1BD470")]
		public IEnumerable<RoomInventoryItem> DMTZWOQGVIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE370", Offset = "0xA1BCD70", VA = "0x18A1BE370")]
		public IEnumerable<PlayerRoomInventoryItem> RGKWRCVDIUY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE560", Offset = "0xA1BCF60", VA = "0x18A1BE560")]
		public bool UYJHULRSKKU(Guid a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE220", Offset = "0xA1BCC20", VA = "0x18A1BE220")]
		public bool PWIVBAWBKDI(string a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE2C0", Offset = "0xA1BCCC0", VA = "0x18A1BE2C0")]
		public bool RGJVPREUNUP(Guid a, [Out] PlayerRoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA1BD3D0", Offset = "0xA1BBDD0", VA = "0x18A1BD3D0")]
		public bool BDSSSCEBZWO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE4E0", Offset = "0xA1BCEE0", VA = "0x18A1BE4E0")]
		private bool UJXYRMASPRP(RoomInventoryItem a, RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE660", Offset = "0xA1BD060", VA = "0x18A1BE660")]
		private void YSOITTJVTBN(Guid a, DSVKLFBFXCR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA1BD600", Offset = "0xA1BC000", VA = "0x18A1BD600")]
		private bool FAWSBLORTMU(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDAD0", Offset = "0xA1BC4D0", VA = "0x18A1BDAD0")]
		private void NSPKKEKZYVK(RoomInventoryItem a, [Optional] RoomInventoryItem b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE8B0", Offset = "0xA1BD2B0", VA = "0x18A1BE8B0")]
		private bool ZTAQADANTDW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA1BD5C0", Offset = "0xA1BBFC0", VA = "0x18A1BD5C0")]
		private static bool DQNFPGEHKCT(RoomInventoryItem a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA1BEA90", Offset = "0xA1BD490", VA = "0x18A1BEA90")]
		public AOVZEDOXYPL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class IXAIPQJTCTL : IUXGQNIWDWM, XATGDZDVNBH, IDisposable, FOHXRCVJNON
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
			[Cpp2IlInjected.Address(RVA = "0x6937080", Offset = "0x6935A80", VA = "0x186937080")]
			public RoomInventoryItemUniqueId(long roomId, Guid roomInventoryItemId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA1C7A40", Offset = "0xA1C6440", VA = "0x18A1C7A40", Slot = "4")]
			public bool Equals(RoomInventoryItemUniqueId other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA1C7B40", Offset = "0xA1C6540", VA = "0x18A1C7B40", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA1C7C90", Offset = "0xA1C6690", VA = "0x18A1C7C90", Slot = "2")]
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
		private sealed class BXEKMHACAHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public PlayerRoomInventoryOperationResult QDCCXPTETSI;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public BXEKMHACAHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA1BEBC0", Offset = "0xA1BD5C0", VA = "0x18A1BEBC0")]
			internal AddOrRemovePlayerRoomInventoryItemCountResponseDTO WIIWDKXEQBK(RoomInventoryItemUniqueId a)
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
			public IXAIPQJTCTL <>4__this;

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
			public AsyncTaskMethodBuilder<KNGKXAOANKP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public IXAIPQJTCTL <>4__this;

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
			public GUPOFWBVNMS awardingPlayer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public Guid remoteOperationId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private TaskAwaiter<PlayerRoomInventoryOperationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA1C7D10", Offset = "0xA1C6710", VA = "0x18A1C7D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8130", Offset = "0xA1C6B30", VA = "0x18A1C8130", Slot = "5")]
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
			public IXAIPQJTCTL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1C81A0", Offset = "0xA1C6BA0", VA = "0x18A1C81A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8C40", Offset = "0xA1C7640", VA = "0x18A1C8C40", Slot = "5")]
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
			public IXAIPQJTCTL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public GUPOFWBVNMS player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA1C8CB0", Offset = "0xA1C76B0", VA = "0x18A1C8CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA1C9080", Offset = "0xA1C7A80", VA = "0x18A1C9080", Slot = "5")]
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
			public IXAIPQJTCTL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1C90F0", Offset = "0xA1C7AF0", VA = "0x18A1C90F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA1C9650", Offset = "0xA1C8050", VA = "0x18A1C9650", Slot = "5")]
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
			public IXAIPQJTCTL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private Dictionary<long, bool>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private TaskAwaiter<Result<bool, string>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA1C96C0", Offset = "0xA1C80C0", VA = "0x18A1C96C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA1CA0A0", Offset = "0xA1C8AA0", VA = "0x18A1CA0A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<KNGKXAOANKP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public IXAIPQJTCTL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public GUPOFWBVNMS recipient;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private TaskAwaiter<KNGKXAOANKP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA1CA100", Offset = "0xA1C8B00", VA = "0x18A1CA100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA1CA560", Offset = "0xA1C8F60", VA = "0x18A1CA560", Slot = "5")]
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
			public IXAIPQJTCTL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1CA5D0", Offset = "0xA1C8FD0", VA = "0x18A1CA5D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA1CADC0", Offset = "0xA1C97C0", VA = "0x18A1CADC0", Slot = "5")]
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
			public IXAIPQJTCTL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public long tagId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private List<IVUOPMKGOIS>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TaskAwaiter<Result<IVUOPMKGOIS, string>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<RecNetResult> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA1CAE30", Offset = "0xA1C9830", VA = "0x18A1CAE30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA1CBA40", Offset = "0xA1CA440", VA = "0x18A1CBA40", Slot = "5")]
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
			public IXAIPQJTCTL <>4__this;

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
			private List<IVUOPMKGOIS> <roomInventoryTags>5__8;

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
			[Cpp2IlInjected.Address(RVA = "0xA1CBAB0", Offset = "0xA1CA4B0", VA = "0x18A1CBAB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA1CCD30", Offset = "0xA1CB730", VA = "0x18A1CCD30", Slot = "5")]
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
			public IXAIPQJTCTL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private TaskAwaiter<Task> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA1CCD90", Offset = "0xA1CB790", VA = "0x18A1CCD90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xA1CD420", Offset = "0xA1CBE20", VA = "0x18A1CD420", Slot = "5")]
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
			public AsyncTaskMethodBuilder<KNGKXAOANKP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public IXAIPQJTCTL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public GUPOFWBVNMS player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private TaskAwaiter<KNGKXAOANKP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA1CD480", Offset = "0xA1CBE80", VA = "0x18A1CD480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA1CD970", Offset = "0xA1CC370", VA = "0x18A1CD970", Slot = "5")]
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
			public IXAIPQJTCTL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public GUPOFWBVNMS player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA1CD9E0", Offset = "0xA1CC3E0", VA = "0x18A1CD9E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA1CDED0", Offset = "0xA1CC8D0", VA = "0x18A1CDED0", Slot = "5")]
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
			public IXAIPQJTCTL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1CDF40", Offset = "0xA1CC940", VA = "0x18A1CDF40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xA1CEE70", Offset = "0xA1CD870", VA = "0x18A1CEE70", Slot = "5")]
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
			public IXAIPQJTCTL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1CEEE0", Offset = "0xA1CD8E0", VA = "0x18A1CEEE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA1CF450", Offset = "0xA1CDE50", VA = "0x18A1CF450", Slot = "5")]
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
			public IXAIPQJTCTL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1CF6B0", Offset = "0xA1CE0B0", VA = "0x18A1CF6B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA1CFF40", Offset = "0xA1CE940", VA = "0x18A1CFF40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<IVUOPMKGOIS, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public IXAIPQJTCTL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public long tagId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public RoomInventoryTagClientProperties properties;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private IVUOPMKGOIS <newTag>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private TaskAwaiter<TaskStatus> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0A20", Offset = "0xA1CF420", VA = "0x18A1D0A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA1D0EF0", Offset = "0xA1CF8F0", VA = "0x18A1D0EF0", Slot = "5")]
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
			public IXAIPQJTCTL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private TaskAwaiter<RecNetResult<List<RoomInventoryItemTagDTO>>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA1CFFB0", Offset = "0xA1CE9B0", VA = "0x18A1CFFB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA1D09B0", Offset = "0xA1CF3B0", VA = "0x18A1D09B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly TimeSpan MIMOUMMLPSR;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float PJRWGOXYFYC = 10f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const float NIPJBODFNQF = 3f;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal const int RRUQJIECFDQ = 3;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal const string ONXHYPKVHSN = "econ_room_inventory_gate";

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal const string YXPZBQRYMTP = "experiences_room_inventory_tags_gate";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly WQWIBMWFFSK QHNWPIBDPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly LSCQWUNXGLF FSLCNUXCFIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly LEWOARAGHTQ GOHAUNNQXOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly XSLDKTFQYRR XNDVBIKLXUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly BWDZXFMXGGM HBBTEZVFXTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly ZSMSGSVHWNY PPHMWBFGLNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly SOLRGSEENKD HWZGIQVSYVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly VCMJLBTFFDA WOEPBRNICRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly TQXEKBTACVJ YVTZLLXQBYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly AOVZEDOXYPL BUOXCEDFPGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly FYXUNHSMXPN TEAUYIIQXKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly RoomInventoryItemPropertiesCache RKDPQGLEVIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly CancellationTokenSource OYTWPRLWVPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly KeyValueRequestBatcher<RoomInventoryItemUniqueId, AddOrRemovePlayerRoomInventoryItemCountResponseDTO> LIZPYNMCKPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly KeyValueRequestBatcher<long, RoomInventoryItemTagDTO> PPHRFMDGOZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly LLMGCDXPOBG WQLKCVWOAQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly IDisposable JHIGTRSXPEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Task PAKXIPJFKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private CancellationTokenSource RAMZZVDDFFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private long MJVIVYEZIWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool DZPJVTCESGG;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private RRFCPEUOZAC YYMMDPTIBVT
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA1C2F30", Offset = "0xA1C1930", VA = "0x18A1C2F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public DYNHRMPGIXT JINNXGBCLTG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xF1FCA0", Offset = "0xF1E6A0", VA = "0x180F1FCA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x174DFF0", Offset = "0x174C9F0", VA = "0x18174DFF0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ASNKAFBFVVA<RoomInventoryItem> XUGATMIJXPP
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xF04020", Offset = "0xF02A20", VA = "0x180F04020", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xF04030", Offset = "0xF02A30", VA = "0x180F04030", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public ASNKAFBFVVA<Guid> GRTBJCBLSBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xE8FB40", Offset = "0xE8E540", VA = "0x180E8FB40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x13A7EE0", Offset = "0x13A68E0", VA = "0x1813A7EE0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ASIDCYHIMJR<PlayerRoomInventoryItem, int> TAQEQFNDZEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE6BBC0", Offset = "0xE6A5C0", VA = "0x180E6BBC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xE0BC20", Offset = "0xE0A620", VA = "0x180E0BC20", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ASNKAFBFVVA<IVUOPMKGOIS> VRQTNCDZXUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD14140", Offset = "0xD12B40", VA = "0x180D14140", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xD13E40", Offset = "0xD12840", VA = "0x180D13E40", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ASNKAFBFVVA<long> DWCEDMWHMKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xDD6700", Offset = "0xDD5100", VA = "0x180DD6700", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1128AC0", Offset = "0x11274C0", VA = "0x181128AC0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public DYNHRMPGIXT LUWSKATLDXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xF82200", Offset = "0xF80C00", VA = "0x180F82200", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x174EE30", Offset = "0x174D830", VA = "0x18174EE30", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public DYNHRMPGIXT EDFUKLCHOLU
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xF82210", Offset = "0xF80C10", VA = "0x180F82210", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1751A20", Offset = "0x1750420", VA = "0x181751A20", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1520", Offset = "0xA1BFF20", VA = "0x18A1C1520")]
		[CXDXQIFYXBD.Session.GameOnly]
		internal static void EOQBVPFENUW(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6F30", Offset = "0xA1C5930", VA = "0x18A1C6F30")]
		[RecRoom.NoEngine.Common.Preserve]
		public IXAIPQJTCTL([Inject(null)] WQWIBMWFFSK recNetRoomInventory, [Inject(null)] LSCQWUNXGLF recNetRoomInventoryTags, [Inject(null)] LEWOARAGHTQ recNetRoomEconConfigs, [Inject(null)] XSLDKTFQYRR matchmakingProvider, [Inject(null)] UHLWHYEMXQU roomLoader, [Inject(null)] BWDZXFMXGGM taskDelay, [Inject(null)] ZSMSGSVHWNY rpcForwarder, [Inject(null)] VQYNSOIJNAN recNetPhotonAccess, [Inject(null)] CWFCXHZIMNT cacheFactory, [Inject(null)] SOLRGSEENKD statsig, [Inject(null)] VCMJLBTFFDA platformManager, [Inject(null)] TQXEKBTACVJ sessionManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1020", Offset = "0xA1BFA20", VA = "0x18A1C1020", Slot = "53")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2F80", Offset = "0xA1C1980", VA = "0x18A1C2F80", Slot = "52")]
		public Task MEGSHUVAAPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA1C07D0", Offset = "0xA1BF1D0", VA = "0x18A1C07D0", Slot = "20")]
		[AsyncStateMachine(typeof(<CreateRoomInventoryItem>d__66))]
		public Task<Result<RoomInventoryItem, string>> CreateRoomInventoryItem(Guid? originId, long roomId, string name, string description, string imageName, RoomInventoryItemProperties properties, byte shape, int color, [Optional] List<long> tagIds, [Optional] List<RoomInventoryItemTagDTO> newTags, bool allowRename = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5C70", Offset = "0xA1C4670", VA = "0x18A1C5C70", Slot = "21")]
		[AsyncStateMachine(typeof(<UpdateRoomInventoryItem>d__67))]
		public Task<Result<RoomInventoryItem, string>> UpdateRoomInventoryItem(Guid roomInventoryItemId, long roomId, [Optional] string name, [Optional] string description, [Optional] string imageName, [Optional] List<long> tagIds, [Optional] Dictionary<string, RoomInventoryTagClientProperties> newTags, [Optional] RoomInventoryItemProperties properties, [Optional] byte? shape, [Optional] int? color)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3EA0", Offset = "0xA1C28A0", VA = "0x18A1C3EA0", Slot = "22")]
		[AsyncStateMachine(typeof(<DeleteRoomInventoryItem>d__68))]
		public Task<Result<bool, string>> PKIDKGHYBJK(Guid a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA1C44B0", Offset = "0xA1C2EB0", VA = "0x18A1C44B0", Slot = "23")]
		public IReadOnlyList<RoomInventoryItem> REPCUNLSQYH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6270", Offset = "0xA1C4C70", VA = "0x18A1C6270")]
		private List<RoomInventoryItem> XOLRVBZFKXK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3480", Offset = "0xA1C1E80", VA = "0x18A1C3480", Slot = "24")]
		public IReadOnlyList<RoomInventoryItem> NNRMFCFYAEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4280", Offset = "0xA1C2C80", VA = "0x18A1C4280", Slot = "25")]
		public bool QEEFJKFWOIS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5B50", Offset = "0xA1C4550", VA = "0x18A1C5B50", Slot = "26")]
		public bool UYJHULRSKKU(Guid a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA1C40F0", Offset = "0xA1C2AF0", VA = "0x18A1C40F0", Slot = "27")]
		public bool PWIVBAWBKDI(string a, [Out] RoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1AB0", Offset = "0xA1C04B0", VA = "0x18A1C1AB0", Slot = "28")]
		public IReadOnlyList<PlayerRoomInventoryItem> FYYUIISUTJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4560", Offset = "0xA1C2F60", VA = "0x18A1C4560", Slot = "29")]
		public bool RGJVPREUNUP(Guid a, [Out] PlayerRoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4FA0", Offset = "0xA1C39A0", VA = "0x18A1C4FA0", Slot = "30")]
		public long? SLGTABLHPXY(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6520", Offset = "0xA1C4F20", VA = "0x18A1C6520", Slot = "51")]
		public void XVABZFCMSMQ(IEnumerable<PlayerRoomInventoryItemDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2970", Offset = "0xA1C1370", VA = "0x18A1C2970", Slot = "31")]
		[AsyncStateMachine(typeof(<CV2GetPlayerRoomInventoryItemCount>d__80))]
		public Task<int> KEIXVXOKENU(GUPOFWBVNMS a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4680", Offset = "0xA1C3080", VA = "0x18A1C4680", Slot = "32")]
		[AsyncStateMachine(typeof(<Cv2AddOrRemovePlayerRoomInventoryItem>d__81))]
		public Task<KNGKXAOANKP> RRPNRZGXKZX(GUPOFWBVNMS a, Guid b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3490", Offset = "0xA1C1E90", VA = "0x18A1C3490", Slot = "33")]
		public string NUNBIUZHRDW(PlayerRoomInventoryOperationResult a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5F70", Offset = "0xA1C4970", VA = "0x18A1C5F70", Slot = "34")]
		public bool WQIXXYYAVXV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA1C37C0", Offset = "0xA1C21C0", VA = "0x18A1C37C0", Slot = "38")]
		[AsyncStateMachine(typeof(<UpdateRoomInventoryTag>d__84))]
		public Task<Result<IVUOPMKGOIS, string>> OINPSPKZMET(long a, RoomInventoryTagClientProperties b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3FD0", Offset = "0xA1C29D0", VA = "0x18A1C3FD0", Slot = "39")]
		[AsyncStateMachine(typeof(<DeleteRoomInventoryTag>d__85))]
		public Task<Result<bool, string>> PNKLOQWWAWZ(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2B20", Offset = "0xA1C1520", VA = "0x18A1C2B20", Slot = "42")]
		public List<(long, int)> LKGTDSSVJRW(long a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0150", Offset = "0xA1BEB50", VA = "0x18A1C0150", Slot = "43")]
		public bool BAYPTPVTKQK(long a, [Out] IVUOPMKGOIS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA1C00D0", Offset = "0xA1BEAD0", VA = "0x18A1C00D0", Slot = "44")]
		public bool AEWEPOOTWOY(string a, [Out] IVUOPMKGOIS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5950", Offset = "0xA1C4350", VA = "0x18A1C5950", Slot = "45")]
		public bool UTTPHLZOCJJ(long a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA1C61B0", Offset = "0xA1C4BB0", VA = "0x18A1C61B0", Slot = "46")]
		public IReadOnlyList<IVUOPMKGOIS> XJPTEWFPRGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4200", Offset = "0xA1C2C00", VA = "0x18A1C4200", Slot = "47")]
		public List<IVUOPMKGOIS> QDXYKNKQMHV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA1C30D0", Offset = "0xA1C1AD0", VA = "0x18A1C30D0", Slot = "48")]
		public IReadOnlyList<IVUOPMKGOIS> NDYMOCNJZDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6D00", Offset = "0xA1C5700", VA = "0x18A1C6D00", Slot = "41")]
		public bool ZWAZIZQUMOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0500", Offset = "0xA1BEF00", VA = "0x18A1C0500", Slot = "49")]
		public IReadOnlyList<RoomInventoryItem> CFYFZUODEBK(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5690", Offset = "0xA1C4090", VA = "0x18A1C5690", Slot = "40")]
		[AsyncStateMachine(typeof(<SetSortingTabIsEnabledForRoom>d__95))]
		public Task<Result<bool, string>> TTGTYPGWAFN(long a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6860", Offset = "0xA1C5260", VA = "0x18A1C6860", Slot = "54")]
		public bool ZADRSPELWSM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5120", Offset = "0xA1C3B20", VA = "0x18A1C5120", Slot = "50")]
		public bool TAMXOVPMJSA(string a, [Out] IReadOnlyList<RoomInventoryItem> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5E30", Offset = "0xA1C4830", VA = "0x18A1C5E30")]
		[AsyncStateMachine(typeof(<UpdateRoomInventoryTagServiceCall>d__98))]
		private Task<Dictionary<long, RoomInventoryItemTagDTO>> UpdateRoomInventoryTagServiceCall(Dictionary<long, int> requests, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3D50", Offset = "0xA1C2750", VA = "0x18A1C3D50")]
		[AsyncStateMachine(typeof(<AddOrRemovePlayerRoomInventoryItemToLocalPlayer>d__99))]
		private Task<KNGKXAOANKP> PDHAXVHOSNB(Guid a, int b, [Optional] Guid c, [Optional] GUPOFWBVNMS d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2830", Offset = "0xA1C1230", VA = "0x18A1C2830")]
		[AsyncStateMachine(typeof(<AddOrRemovePlayerRoomInventoryServiceCall>d__100))]
		private Task<Dictionary<RoomInventoryItemUniqueId, AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> JNEFCXSSBYI(Dictionary<RoomInventoryItemUniqueId, int> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1950", Offset = "0xA1C0350", VA = "0x18A1C1950")]
		[AsyncStateMachine(typeof(<SendRecNetAwardRequestAndRetryOnConcurrencyMismatch>d__101))]
		private Task<List<AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> FEXURKKHKWD(Dictionary<RoomInventoryItemUniqueId, int> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4380", Offset = "0xA1C2D80", VA = "0x18A1C4380")]
		[AsyncStateMachine(typeof(<DownloadRoomInventory>d__102))]
		private Task QYGKWWUVUCC(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA1C38F0", Offset = "0xA1C22F0", VA = "0x18A1C38F0")]
		private Task OnRoomLoadStarted(TDQXTVJIXNU args, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA1C55C0", Offset = "0xA1C3FC0", VA = "0x18A1C55C0")]
		[AsyncStateMachine(typeof(<OnRoomLoadComplete>d__104))]
		private Task TMSSKJGXROM(TDQXTVJIXNU a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0990", Offset = "0xA1BF390", VA = "0x18A1C0990")]
		private void DLZLNWCZJBJ(RoomInventoryItemDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4AF0", Offset = "0xA1C34F0", VA = "0x18A1C4AF0")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string serializedRoomInventoryItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1EB0", Offset = "0xA1C08B0", VA = "0x18A1C1EB0")]
		private void HMXTTXKIBKA(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4C30", Offset = "0xA1C3630", VA = "0x18A1C4C30")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid roomInventoryItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6D80", Offset = "0xA1C5780", VA = "0x18A1C6D80")]
		[AsyncStateMachine(typeof(<SendGetPlayerRoomInventoryCountRequest>d__109))]
		private Task<int> ZYBUKBRRWFD(GUPOFWBVNMS a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4920", Offset = "0xA1C3320", VA = "0x18A1C4920")]
		[RPCMethod]
		internal void RpcGetPlayerRoomInventoryCount(Guid operationId, Guid roomInventoryItemId, RPCInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C48A0", Offset = "0xA1C32A0", VA = "0x18A1C48A0")]
		[RPCMethod]
		internal void RpcGetPlayerRoomInventoryCountResponse(Guid operationId, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2010", Offset = "0xA1C0A10", VA = "0x18A1C2010")]
		[AsyncStateMachine(typeof(<SendAddOrRemovePlayerRoomInventoryRequestToPlayer>d__112))]
		private Task<KNGKXAOANKP> HTUPNRPOBTS(GUPOFWBVNMS a, Guid b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C47D0", Offset = "0xA1C31D0", VA = "0x18A1C47D0")]
		[RPCMethod]
		internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid operationId, Guid roomInventoryItemId, int quantity, RPCInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA1C68D0", Offset = "0xA1C52D0", VA = "0x18A1C68D0")]
		private void ZEOKRVZKJQW(GUPOFWBVNMS a, Guid b, PlayerRoomInventoryOperationResult c, long d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4EE0", Offset = "0xA1C38E0", VA = "0x18A1C4EE0")]
		[RPCMethod]
		internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid operationId, int result, long playerOwnedCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3660", Offset = "0xA1C2060", VA = "0x18A1C3660")]
		private void NYXWHJIECXI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4E80", Offset = "0xA1C3880", VA = "0x18A1C4E80")]
		[RPCMethod]
		private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool isEnabledBool)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6BE0", Offset = "0xA1C55E0", VA = "0x18A1C6BE0")]
		private void ZNMTMKCQVFQ(List<RoomInventoryItemTagDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4CD0", Offset = "0xA1C36D0", VA = "0x18A1C4CD0")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryTagUpdates(string serializedTags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1230", Offset = "0xA1BFC30", VA = "0x18A1C1230")]
		private void EBDIJOTZLQZ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA1C4C60", Offset = "0xA1C3660", VA = "0x18A1C4C60")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryTagDeleted(long tagId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA1C01D0", Offset = "0xA1BEBD0", VA = "0x18A1C01D0")]
		private RoomInventoryItem BPMFTEUXBFG(RoomInventoryItemDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA1C5FE0", Offset = "0xA1C49E0", VA = "0x18A1C5FE0")]
		private List<IVUOPMKGOIS> WUJGMNHRDNR(List<RoomInventoryItemTagDTO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1590", Offset = "0xA1BFF90", VA = "0x18A1C1590")]
		private List<IVUOPMKGOIS> EYWZIHTQSPR(IEnumerable<RoomInventoryItemTagDTO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0BF0", Offset = "0xA1BF5F0", VA = "0x18A1C0BF0", Slot = "36")]
		public RoomInventoryItemProperties DeserializeRoomInventoryItemProperties(string serializedRoomInventoryItemPropertyString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA1C57B0", Offset = "0xA1C41B0", VA = "0x18A1C57B0")]
		private RoomInventoryItem UNJHYZPTEYT(RoomInventoryItemDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0AB0", Offset = "0xA1BF4B0", VA = "0x18A1C0AB0", Slot = "35")]
		public RoomInventoryItemDTO DehydrateRoomInventoryItemToDTO(RoomInventoryItem inventoryItem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2160", Offset = "0xA1C0B60", VA = "0x18A1C2160")]
		private IVUOPMKGOIS HydrateRoomInventoryTagFromDTO(RoomInventoryItemTagDTO dto)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6A60", Offset = "0xA1C5460", VA = "0x18A1C6A60")]
		private void ZIEIEBKUKOX(PlayerRoomInventoryItem a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA1C2AB0", Offset = "0xA1C14B0", VA = "0x18A1C2AB0")]
		private void LCINBVANNFQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1390", Offset = "0xA1BFD90", VA = "0x18A1C1390")]
		private Task EFNVJJWKPYW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1E40", Offset = "0xA1C0840", VA = "0x18A1C1E40")]
		private void GQHDQDDBDBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA1C3020", Offset = "0xA1C1A20", VA = "0x18A1C3020")]
		private void MTKUZFDDJQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6AD0", Offset = "0xA1C54D0", VA = "0x18A1C6AD0")]
		private void ZIHVFOSTVXF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA1C03F0", Offset = "0xA1BEDF0", VA = "0x18A1C03F0")]
		[AsyncStateMachine(typeof(<CullTagsOnDelete>d__135))]
		private Task CBQFJSQLBGC(RoomInventoryItem a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1A90", Offset = "0xA1C0490", VA = "0x18A1C1A90")]
		[CompilerGenerated]
		private void FKEXBUCVLGT(Task<TaskStatus> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA1C23E0", Offset = "0xA1C0DE0", VA = "0x18A1C23E0")]
		[CompilerGenerated]
		private Task<PlayerRoomInventoryOperationResult> JDDPBAVXSOY(<>c__DisplayClass99_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1C80", Offset = "0xA1C0680", VA = "0x18A1C1C80")]
		[CompilerGenerated]
		internal static Dictionary<RoomInventoryItemUniqueId, AddOrRemovePlayerRoomInventoryItemCountResponseDTO> GLBAQNYYMZI(PlayerRoomInventoryOperationResult a, <>c__DisplayClass100_0 b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RoomInventoryItemPropertiesCache : Dictionary<string, RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA1C7A00", Offset = "0xA1C6400", VA = "0x18A1C7A00")]
		public RoomInventoryItemPropertiesCache()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface CWFCXHZIMNT
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AOVZEDOXYPL KSCZGKNQWIB();

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RoomInventoryItemPropertiesCache LXRBRHFHEJI();

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FYXUNHSMXPN PDWAHANKCSD();
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class DWQXSBNIBJD : CWFCXHZIMNT
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA1BEC20", Offset = "0xA1BD620", VA = "0x18A1BEC20")]
		[CXDXQIFYXBD.Session.GameOnly]
		internal static void EOQBVPFENUW(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		[RecRoom.NoEngine.Common.Preserve]
		public DWQXSBNIBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA1BEC90", Offset = "0xA1BD690", VA = "0x18A1BEC90", Slot = "4")]
		public AOVZEDOXYPL KSCZGKNQWIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA1BED90", Offset = "0xA1BD790", VA = "0x18A1BED90", Slot = "5")]
		public RoomInventoryItemPropertiesCache LXRBRHFHEJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA1BEE00", Offset = "0xA1BD800", VA = "0x18A1BEE00", Slot = "6")]
		public FYXUNHSMXPN PDWAHANKCSD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class FYXUNHSMXPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly Dictionary<long, IVUOPMKGOIS> RMSWMRHEIQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly IVUOPMKGOIS[] BMGPWIARGGI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool IOISKIPLWQD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xE376D0", Offset = "0xE360D0", VA = "0x180E376D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int CMUDVFTJSAW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xA1BF480", Offset = "0xA1BDE80", VA = "0x18A1BF480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private long BCFMOWJYDAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD11960", Offset = "0xD10360", VA = "0x180D11960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA1BF5B0", Offset = "0xA1BDFB0", VA = "0x18A1BF5B0")]
		public void NewRoom(long roomId, IEnumerable<IVUOPMKGOIS> tags, bool sortingTabIsEnabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA1BFDD0", Offset = "0xA1BE7D0", VA = "0x18A1BFDD0")]
		public IReadOnlyList<IVUOPMKGOIS> YZLSJEJYJYV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xE376D0", Offset = "0xE360D0", VA = "0x180E376D0")]
		public void CSPHJFNEWIU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA1BF020", Offset = "0xA1BDA20", VA = "0x18A1BF020")]
		public bool DSJAANTCGFV(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA1BFC10", Offset = "0xA1BE610", VA = "0x18A1BFC10")]
		public bool YMGJURBYXME(IVUOPMKGOIS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA1BF160", Offset = "0xA1BDB60", VA = "0x18A1BF160")]
		public bool INNLZAYEJGE(List<IVUOPMKGOIS> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA1BFF80", Offset = "0xA1BE980", VA = "0x18A1BFF80")]
		public bool ZMTKNOLOTBT(long a, [Out] IVUOPMKGOIS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA1BFA60", Offset = "0xA1BE460", VA = "0x18A1BFA60")]
		public bool PKNYVQDLWVN(string a, [Out] IVUOPMKGOIS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA1BF4E0", Offset = "0xA1BDEE0", VA = "0x18A1BF4E0")]
		public List<IVUOPMKGOIS> MXQFNCFGUPR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA1BEEE0", Offset = "0xA1BD8E0", VA = "0x18A1BEEE0")]
		public List<IVUOPMKGOIS> BVTKPUCHJUZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9C74E20", Offset = "0x9C73820", VA = "0x189C74E20")]
		public IVUOPMKGOIS AEAZYAMUQXH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA1BF100", Offset = "0xA1BDB00", VA = "0x18A1BF100")]
		public IReadOnlyList<IVUOPMKGOIS> FIHAGOTCUBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA1C0020", Offset = "0xA1BEA20", VA = "0x18A1C0020")]
		public FYXUNHSMXPN()
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
