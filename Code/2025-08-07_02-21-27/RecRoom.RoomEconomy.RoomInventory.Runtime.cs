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
		[Cpp2IlInjected.Address(RVA = "0x923DB30", Offset = "0x923C730", VA = "0x18923DB30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface UXJAXFHNBKW : IVFXULJJDPU
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		ROMNUXMCNIZ ROMNUXMCNIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class PUIZNPTYJVH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly Dictionary<Guid, PTTEAMYEJDL> TFSYNOJQXBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly Dictionary<string, PTTEAMYEJDL> CRVBWLEUMYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private bool? AKIKCMBTSHM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private long IKDXOFHMFAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xB13130", Offset = "0xB11D30", VA = "0x180B13130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public PTTEAMYEJDL this[Guid index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x922CB80", Offset = "0x922B780", VA = "0x18922CB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x922B4E0", Offset = "0x922A0E0", VA = "0x18922B4E0")]
		public void NewRoom(long roomId, IEnumerable<XMBVVYPKIUV> roomInventoryItems, IEnumerable<PlayerRoomInventoryItem> playerRoomInventoryItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x922BC80", Offset = "0x922A880", VA = "0x18922BC80")]
		public bool QFXJZFZKLIP(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x922BFA0", Offset = "0x922ABA0", VA = "0x18922BFA0")]
		public bool Remove(Guid roomInventoryItemId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x922C530", Offset = "0x922B130", VA = "0x18922C530")]
		public bool WWYYDMZJOUN(XMBVVYPKIUV a, [Out] XMBVVYPKIUV b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x922CA60", Offset = "0x922B660", VA = "0x18922CA60")]
		public IEnumerable<PTTEAMYEJDL> YUAUILRNBIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x922BFC0", Offset = "0x922ABC0", VA = "0x18922BFC0")]
		public IEnumerable<XMBVVYPKIUV> TOQDJTINRSF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x922BE50", Offset = "0x922AA50", VA = "0x18922BE50")]
		public IEnumerable<PlayerRoomInventoryItem> RPNLKDUMUGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x922BB30", Offset = "0x922A730", VA = "0x18922BB30")]
		public bool PCFIVEAIGDG(Guid a, [Out] XMBVVYPKIUV b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x922BBE0", Offset = "0x922A7E0", VA = "0x18922BBE0")]
		public bool PSZOUVYJCTE(string a, [Out] XMBVVYPKIUV b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x922C760", Offset = "0x922B360", VA = "0x18922C760")]
		public bool XACUKRSMDPV(Guid a, [Out] PlayerRoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x922B400", Offset = "0x922A000", VA = "0x18922B400")]
		public bool EXMXPYUAJBU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x922BCE0", Offset = "0x922A8E0", VA = "0x18922BCE0")]
		private bool RGQVOMUOCGV(XMBVVYPKIUV a, XMBVVYPKIUV b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x922C810", Offset = "0x922B410", VA = "0x18922C810")]
		private void XKGBOFNGFZJ(Guid a, PTTEAMYEJDL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x922C2F0", Offset = "0x922AEF0", VA = "0x18922C2F0")]
		private bool VMSHDCEZMDG(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x922BD60", Offset = "0x922A960", VA = "0x18922BD60")]
		private void ROXNYXGXYJO(XMBVVYPKIUV a, [Optional] XMBVVYPKIUV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x922C110", Offset = "0x922AD10", VA = "0x18922C110")]
		private bool UWBECNSPLBW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x922B4A0", Offset = "0x922A0A0", VA = "0x18922B4A0")]
		private static bool NPNTDYIZTKT(XMBVVYPKIUV a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x922CAB0", Offset = "0x922B6B0", VA = "0x18922CAB0")]
		public PUIZNPTYJVH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ROMNUXMCNIZ : BXCWGANPNTW, YTPTNXUVKKN, IDisposable, MPSKMBLLYLT
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

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x596EE40", Offset = "0x596DA40", VA = "0x18596EE40")]
			public RoomInventoryItemUniqueId(long roomId, Guid roomInventoryItemId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x9234560", Offset = "0x9233160", VA = "0x189234560", Slot = "4")]
			public bool Equals(RoomInventoryItemUniqueId other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9234660", Offset = "0x9233260", VA = "0x189234660", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x92347B0", Offset = "0x92333B0", VA = "0x1892347B0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct <>c__DisplayClass97_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public ROMNUXMCNIZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public PlayerRoomInventoryItem playerRoomInventoryItem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public int quantity;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct <>c__DisplayClass98_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Dictionary<RoomInventoryItemUniqueId, int> idsAndQuantities;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class XZPPVQYCNCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public PlayerRoomInventoryOperationResult OZQWNDVSENS;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XZPPVQYCNCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x923DAD0", Offset = "0x923C6D0", VA = "0x18923DAD0")]
			internal AddOrRemovePlayerRoomInventoryItemCountResponseDTO OYILFJFEWBO(RoomInventoryItemUniqueId a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct <AddOrRemovePlayerRoomInventoryItemToLocalPlayer>d__97 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public AsyncTaskMethodBuilder<WWLNAFSIAVR> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public ROMNUXMCNIZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private <>c__DisplayClass97_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public WJBKOLNRRJE awardingPlayer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public Guid remoteOperationId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private TaskAwaiter<PlayerRoomInventoryOperationResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9234830", Offset = "0x9233430", VA = "0x189234830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9234C50", Offset = "0x9233850", VA = "0x189234C50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct <AddOrRemovePlayerRoomInventoryServiceCall>d__98 : IAsyncStateMachine
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
			public ROMNUXMCNIZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private <>c__DisplayClass98_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private TaskAwaiter<List<AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x9234CC0", Offset = "0x92338C0", VA = "0x189234CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9235760", Offset = "0x9234360", VA = "0x189235760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <CV2GetPlayerRoomInventoryItemCount>d__78 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public ROMNUXMCNIZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public WJBKOLNRRJE player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x92357D0", Offset = "0x92343D0", VA = "0x1892357D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x9235BA0", Offset = "0x92347A0", VA = "0x189235BA0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<XMBVVYPKIUV, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public ROMNUXMCNIZ <>4__this;

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

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9235C10", Offset = "0x9234810", VA = "0x189235C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9236170", Offset = "0x9234D70", VA = "0x189236170", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <CullTagsOnDelete>d__133 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public XMBVVYPKIUV itemToDelete;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public ROMNUXMCNIZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private Dictionary<long, bool>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private TaskAwaiter<Result<bool, string>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x92361E0", Offset = "0x9234DE0", VA = "0x1892361E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9236BC0", Offset = "0x92357C0", VA = "0x189236BC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <Cv2AddOrRemovePlayerRoomInventoryItem>d__79 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public AsyncTaskMethodBuilder<WWLNAFSIAVR> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public ROMNUXMCNIZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public WJBKOLNRRJE recipient;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private TaskAwaiter<WWLNAFSIAVR> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9236C20", Offset = "0x9235820", VA = "0x189236C20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9237080", Offset = "0x9235C80", VA = "0x189237080", Slot = "5")]
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
			public ROMNUXMCNIZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private XMBVVYPKIUV <itemToDelete>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private RecNetResult <result>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<RecNetResult> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x92370F0", Offset = "0x9235CF0", VA = "0x1892370F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x92378C0", Offset = "0x92364C0", VA = "0x1892378C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct <DeleteRoomInventoryTag>d__83 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<Result<bool, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public ROMNUXMCNIZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public long tagId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private List<AQMMKJORJTE>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TaskAwaiter<Result<AQMMKJORJTE, string>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<RecNetResult> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9237930", Offset = "0x9236530", VA = "0x189237930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9238540", Offset = "0x9237140", VA = "0x189238540", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct <DownloadRoomInventory>d__100 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public ROMNUXMCNIZ <>4__this;

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
			private IEnumerable<XMBVVYPKIUV> <roomInventoryItems>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private IEnumerable<PlayerRoomInventoryItem> <playerRoomInventoryItems>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private List<AQMMKJORJTE> <roomInventoryTags>5__8;

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

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x92385B0", Offset = "0x92371B0", VA = "0x1892385B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x9239840", Offset = "0x9238440", VA = "0x189239840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct <OnRoomLoadComplete>d__102 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public ROMNUXMCNIZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private TaskAwaiter<Task> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x92398A0", Offset = "0x92384A0", VA = "0x1892398A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x9239F30", Offset = "0x9238B30", VA = "0x189239F30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct <SendAddOrRemovePlayerRoomInventoryRequestToPlayer>d__110 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public AsyncTaskMethodBuilder<WWLNAFSIAVR> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public ROMNUXMCNIZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public WJBKOLNRRJE player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private TaskAwaiter<WWLNAFSIAVR> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9239F90", Offset = "0x9238B90", VA = "0x189239F90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x923A490", Offset = "0x9239090", VA = "0x18923A490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <SendGetPlayerRoomInventoryCountRequest>d__107 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public ROMNUXMCNIZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public WJBKOLNRRJE player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Guid roomInventoryItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x923A500", Offset = "0x9239100", VA = "0x18923A500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x923A9F0", Offset = "0x92395F0", VA = "0x18923A9F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <SendRecNetAwardRequestAndRetryOnConcurrencyMismatch>d__99 : IAsyncStateMachine
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
			public ROMNUXMCNIZ <>4__this;

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

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x923AA60", Offset = "0x9239660", VA = "0x18923AA60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x923B990", Offset = "0x923A590", VA = "0x18923B990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private struct <SetSortingTabIsEnabledForRoom>d__93 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder<Result<bool, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public ROMNUXMCNIZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public bool isEnabled;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<RecNetResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x923BA00", Offset = "0x923A600", VA = "0x18923BA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x923BF50", Offset = "0x923AB50", VA = "0x18923BF50", Slot = "5")]
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
			public AsyncTaskMethodBuilder<Result<XMBVVYPKIUV, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public ROMNUXMCNIZ <>4__this;

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

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x923C210", Offset = "0x923AE10", VA = "0x18923C210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x923CAB0", Offset = "0x923B6B0", VA = "0x18923CAB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private struct <UpdateRoomInventoryTag>d__82 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AsyncTaskMethodBuilder<Result<AQMMKJORJTE, string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public ROMNUXMCNIZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public long tagId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public RoomInventoryTagClientProperties properties;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private AQMMKJORJTE <newTag>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private TaskAwaiter<TaskStatus> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x923D590", Offset = "0x923C190", VA = "0x18923D590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x923DA60", Offset = "0x923C660", VA = "0x18923DA60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private struct <UpdateRoomInventoryTagServiceCall>d__96 : IAsyncStateMachine
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
			public ROMNUXMCNIZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private TaskAwaiter<RecNetResult<List<RoomInventoryItemTagDTO>>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x923CB20", Offset = "0x923B720", VA = "0x18923CB20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x923D520", Offset = "0x923C120", VA = "0x18923D520", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly TimeSpan ZFQWEYKVVQZ;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float OOZILKASXOK = 10f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const float ZLKQRSOJGOZ = 3f;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal const int TULULVLBKKK = 3;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal const string BPOFNUERNNL = "econ_room_inventory_gate";

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal const string FKFUYGZBJVT = "experiences_room_inventory_tags_gate";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly NSZCHKOOCLY IIVPOSKMUUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly PPJXRBZWPUD LUWDKMSYIWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly BCMSTYQFZBQ GWCJWJYAZEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly VDCIXCLHTKX VHXNYSMFVGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly XPBIEDXVVOM IEMNZYFJVZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly UXJAXFHNBKW WEZNICUGWMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly NADKVDSFRLV ODWNDRWWAAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly WKXAFXNYBNI EBCUWTRTZEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly ASVHLEOBLHF BZXEPCYGBRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly PUIZNPTYJVH TNMSADNDBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly IYARTNDOVUP YDVPOMQKJFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly RoomInventoryItemPropertiesCache FNBXYPOJLTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly CancellationTokenSource PZEIBPMUNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly KeyValueRequestBatcher<RoomInventoryItemUniqueId, AddOrRemovePlayerRoomInventoryItemCountResponseDTO> EXESXFHONES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly KeyValueRequestBatcher<long, RoomInventoryItemTagDTO> GNPJSQSTONV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly DEJFTPCSMYM NAZWYORCISI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly IDisposable RWPXGFVFSYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Task WXOHMFULYTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private CancellationTokenSource LGLVOAZEWDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private long HZRUXTLTYBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool JDQGFFMCCEG;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private ERXFZSGLFIW YGBLVICOHRH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9230E90", Offset = "0x922FA90", VA = "0x189230E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AQWXMNIFQIV YGKPZPZAFUA
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xF48A30", Offset = "0xF47630", VA = "0x180F48A30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x15B4DF0", Offset = "0x15B39F0", VA = "0x1815B4DF0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public HWNZTWGRXOC<XMBVVYPKIUV> UJSTABQVZTT
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xBD41A0", Offset = "0xBD2DA0", VA = "0x180BD41A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xC13AE0", Offset = "0xC126E0", VA = "0x180C13AE0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public HWNZTWGRXOC<Guid> GNQWECSXPTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xBD4160", Offset = "0xBD2D60", VA = "0x180BD4160", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xBD4380", Offset = "0xBD2F80", VA = "0x180BD4380", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HWISWPMUOCT<PlayerRoomInventoryItem, int> WOZXYIFPPZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xBD4140", Offset = "0xBD2D40", VA = "0x180BD4140", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xC13B10", Offset = "0xC12710", VA = "0x180C13B10", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public HWNZTWGRXOC<AQMMKJORJTE> BIZAQNOBENM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB1B7A0", Offset = "0xB1A3A0", VA = "0x180B1B7A0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xB1B720", Offset = "0xB1A320", VA = "0x180B1B720", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HWNZTWGRXOC<long> ZOQSMEPTUMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xBA7EA0", Offset = "0xBA6AA0", VA = "0x180BA7EA0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xBA75B0", Offset = "0xBA61B0", VA = "0x180BA75B0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public AQWXMNIFQIV BMYKJAZRUTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xBA7EC0", Offset = "0xBA6AC0", VA = "0x180BA7EC0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xBA7E00", Offset = "0xBA6A00", VA = "0x180BA7E00", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AQWXMNIFQIV FOEQHTIAWWS
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xBA7EB0", Offset = "0xBA6AB0", VA = "0x180BA7EB0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xBA74A0", Offset = "0xBA60A0", VA = "0x180BA74A0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x92314A0", Offset = "0x92300A0", VA = "0x1892314A0")]
		[IFIZWETSKCB.Session.GameOnly]
		internal static void RIWNJSDCBRY(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9233A50", Offset = "0x9232650", VA = "0x189233A50")]
		[RecRoom.NoEngine.Common.Preserve]
		public ROMNUXMCNIZ([Inject(null)] NSZCHKOOCLY recNetRoomInventory, [Inject(null)] PPJXRBZWPUD recNetRoomInventoryTags, [Inject(null)] BCMSTYQFZBQ recNetRoomEconConfigs, [Inject(null)] VDCIXCLHTKX matchmakingProvider, [Inject(null)] BFGWYOYOWEM roomLoader, [Inject(null)] XPBIEDXVVOM taskDelay, [Inject(null)] UXJAXFHNBKW rpcForwarder, [Inject(null)] TYHVAMYFASJ recNetPhotonAccess, [Inject(null)] GXOVITQLELT cacheFactory, [Inject(null)] NADKVDSFRLV statsig, [Inject(null)] WKXAFXNYBNI platformManager, [Inject(null)] ASVHLEOBLHF sessionManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x922D9D0", Offset = "0x922C5D0", VA = "0x18922D9D0", Slot = "53")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9233100", Offset = "0x9231D00", VA = "0x189233100", Slot = "52")]
		public Task XJBNQGWQRPQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x922CFD0", Offset = "0x922BBD0", VA = "0x18922CFD0", Slot = "20")]
		[AsyncStateMachine(typeof(<CreateRoomInventoryItem>d__66))]
		public Task<Result<XMBVVYPKIUV, string>> CreateRoomInventoryItem(Guid? originId, long roomId, string name, string description, string imageName, RoomInventoryItemProperties properties, byte shape, int color, [Optional] List<long> tagIds, [Optional] List<RoomInventoryItemTagDTO> newTags, bool allowRename = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x92323C0", Offset = "0x9230FC0", VA = "0x1892323C0", Slot = "21")]
		[AsyncStateMachine(typeof(<UpdateRoomInventoryItem>d__67))]
		public Task<Result<XMBVVYPKIUV, string>> UpdateRoomInventoryItem(Guid roomInventoryItemId, long roomId, [Optional] string name, [Optional] string description, [Optional] string imageName, [Optional] List<long> tagIds, [Optional] Dictionary<string, RoomInventoryTagClientProperties> newTags, [Optional] RoomInventoryItemProperties properties, [Optional] byte? shape, [Optional] int? color)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x922FC20", Offset = "0x922E820", VA = "0x18922FC20", Slot = "22")]
		[AsyncStateMachine(typeof(<DeleteRoomInventoryItem>d__68))]
		public Task<Result<bool, string>> JTXPCGGPCZS(Guid a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x922EC10", Offset = "0x922D810", VA = "0x18922EC10", Slot = "23")]
		public IReadOnlyList<XMBVVYPKIUV> GIRLDENGBCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x92303D0", Offset = "0x922EFD0", VA = "0x1892303D0", Slot = "24")]
		public IReadOnlyList<XMBVVYPKIUV> MOZTWMWZFAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x922DBE0", Offset = "0x922C7E0", VA = "0x18922DBE0", Slot = "25")]
		public bool EIHMCZACPBA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9230BD0", Offset = "0x922F7D0", VA = "0x189230BD0", Slot = "26")]
		public bool PCFIVEAIGDG(Guid a, [Out] XMBVVYPKIUV b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9230F60", Offset = "0x922FB60", VA = "0x189230F60", Slot = "27")]
		public bool PSZOUVYJCTE(string a, [Out] XMBVVYPKIUV b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x922FEE0", Offset = "0x922EAE0", VA = "0x18922FEE0", Slot = "28")]
		public IReadOnlyList<PlayerRoomInventoryItem> KUJXHXMNMWC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9232FE0", Offset = "0x9231BE0", VA = "0x189232FE0", Slot = "29")]
		public bool XACUKRSMDPV(Guid a, [Out] PlayerRoomInventoryItem b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x922F670", Offset = "0x922E270", VA = "0x18922F670", Slot = "30")]
		public long? JBLTOAVMKEW(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x922E8D0", Offset = "0x922D4D0", VA = "0x18922E8D0", Slot = "51")]
		public void GFRJGLGGMXO(IEnumerable<PlayerRoomInventoryItemDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9232280", Offset = "0x9230E80", VA = "0x189232280", Slot = "31")]
		[AsyncStateMachine(typeof(<CV2GetPlayerRoomInventoryItemCount>d__78))]
		public Task<int> UOOCHWUKNGC(WJBKOLNRRJE a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x922ECC0", Offset = "0x922D8C0", VA = "0x18922ECC0", Slot = "32")]
		[AsyncStateMachine(typeof(<Cv2AddOrRemovePlayerRoomInventoryItem>d__79))]
		public Task<WWLNAFSIAVR> GSNSHKJYGND(WJBKOLNRRJE a, Guid b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x922DCE0", Offset = "0x922C8E0", VA = "0x18922DCE0", Slot = "33")]
		public string ELIBUUFMZYA(PlayerRoomInventoryOperationResult a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9230700", Offset = "0x922F300", VA = "0x189230700", Slot = "34")]
		public bool OAPBJEIAACX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x922E130", Offset = "0x922CD30", VA = "0x18922E130", Slot = "38")]
		[AsyncStateMachine(typeof(<UpdateRoomInventoryTag>d__82))]
		public Task<Result<AQMMKJORJTE, string>> FCXFHOKFNJR(long a, RoomInventoryTagClientProperties b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x922DEB0", Offset = "0x922CAB0", VA = "0x18922DEB0", Slot = "39")]
		[AsyncStateMachine(typeof(<DeleteRoomInventoryTag>d__83))]
		public Task<Result<bool, string>> EQYUJVPZBVL(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9233410", Offset = "0x9232010", VA = "0x189233410", Slot = "42")]
		public List<(long, int)> XVFMAVZLMPK(long a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9232200", Offset = "0x9230E00", VA = "0x189232200", Slot = "43")]
		public bool UHNEXTASHJQ(long a, [Out] AQMMKJORJTE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9230EE0", Offset = "0x922FAE0", VA = "0x189230EE0", Slot = "44")]
		public bool PPQOULIEODK(string a, [Out] AQMMKJORJTE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9231E40", Offset = "0x9230A40", VA = "0x189231E40", Slot = "45")]
		public bool SMFDDQKVTZZ(long a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9232F20", Offset = "0x9231B20", VA = "0x189232F20", Slot = "46")]
		public IReadOnlyList<AQMMKJORJTE> WXNYYMVPIWB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9230680", Offset = "0x922F280", VA = "0x189230680", Slot = "47")]
		public List<AQMMKJORJTE> NGXSIYGPPFR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x922F2C0", Offset = "0x922DEC0", VA = "0x18922F2C0", Slot = "48")]
		public IReadOnlyList<AQMMKJORJTE> IDUAIRDZZVU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9233890", Offset = "0x9232490", VA = "0x189233890", Slot = "41")]
		public bool YEICWLLCNJZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9231070", Offset = "0x922FC70", VA = "0x189231070", Slot = "49")]
		public IReadOnlyList<XMBVVYPKIUV> QOOUXURHAAY(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x922FD50", Offset = "0x922E950", VA = "0x18922FD50", Slot = "40")]
		[AsyncStateMachine(typeof(<SetSortingTabIsEnabledForRoom>d__93))]
		public Task<Result<bool, string>> JYFDIXHCRPR(long a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x922F7F0", Offset = "0x922E3F0", VA = "0x18922F7F0", Slot = "54")]
		public bool JFHGMBJIQSI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9232A80", Offset = "0x9231680", VA = "0x189232A80", Slot = "50")]
		public bool WPJXJGEEBSM(string a, [Out] IReadOnlyList<XMBVVYPKIUV> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9232580", Offset = "0x9231180", VA = "0x189232580")]
		[AsyncStateMachine(typeof(<UpdateRoomInventoryTagServiceCall>d__96))]
		private Task<Dictionary<long, RoomInventoryItemTagDTO>> UpdateRoomInventoryTagServiceCall(Dictionary<long, int> requests, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x922CBE0", Offset = "0x922B7E0", VA = "0x18922CBE0")]
		[AsyncStateMachine(typeof(<AddOrRemovePlayerRoomInventoryItemToLocalPlayer>d__97))]
		private Task<WWLNAFSIAVR> APTHGVYSMHB(Guid a, int b, [Optional] Guid c, [Optional] WJBKOLNRRJE d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x922DFD0", Offset = "0x922CBD0", VA = "0x18922DFD0")]
		[AsyncStateMachine(typeof(<AddOrRemovePlayerRoomInventoryServiceCall>d__98))]
		private Task<Dictionary<RoomInventoryItemUniqueId, AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> EXEPCMQIXHO(Dictionary<RoomInventoryItemUniqueId, int> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x92332D0", Offset = "0x9231ED0", VA = "0x1892332D0")]
		[AsyncStateMachine(typeof(<SendRecNetAwardRequestAndRetryOnConcurrencyMismatch>d__99))]
		private Task<List<AddOrRemovePlayerRoomInventoryItemCountResponseDTO>> XTOBFUNEXEX(Dictionary<RoomInventoryItemUniqueId, int> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x92331A0", Offset = "0x9231DA0", VA = "0x1892331A0")]
		[AsyncStateMachine(typeof(<DownloadRoomInventory>d__100))]
		private Task XPTWBJNGOZA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9230770", Offset = "0x922F370", VA = "0x189230770")]
		private Task OnRoomLoadStarted(APQTHAEMUEW args, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9233910", Offset = "0x9232510", VA = "0x189233910")]
		[AsyncStateMachine(typeof(<OnRoomLoadComplete>d__102))]
		private Task YSCEXAIKOZO(APQTHAEMUEW a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x922EE10", Offset = "0x922DA10", VA = "0x18922EE10")]
		private void HCCYNXAZKNZ(RoomInventoryItemDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9231840", Offset = "0x9230440", VA = "0x189231840")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryItemCreatedOrUpdated(string serializedRoomInventoryItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9231330", Offset = "0x922FF30", VA = "0x189231330")]
		private void RBQMBPOZZWM(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9231980", Offset = "0x9230580", VA = "0x189231980")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryItemDeleted(Guid roomInventoryItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x92326C0", Offset = "0x92312C0", VA = "0x1892326C0")]
		[AsyncStateMachine(typeof(<SendGetPlayerRoomInventoryCountRequest>d__107))]
		private Task<int> VNUTBMRCAKF(WJBKOLNRRJE a, Guid b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9231660", Offset = "0x9230260", VA = "0x189231660")]
		[RPCMethod]
		internal void RpcGetPlayerRoomInventoryCount(Guid operationId, Guid roomInventoryItemId, RPCInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x92315E0", Offset = "0x92301E0", VA = "0x1892315E0")]
		[RPCMethod]
		internal void RpcGetPlayerRoomInventoryCountResponse(Guid operationId, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9231CF0", Offset = "0x92308F0", VA = "0x189231CF0")]
		[AsyncStateMachine(typeof(<SendAddOrRemovePlayerRoomInventoryRequestToPlayer>d__110))]
		private Task<WWLNAFSIAVR> SCQNNMEDZPG(WJBKOLNRRJE a, Guid b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9231510", Offset = "0x9230110", VA = "0x189231510")]
		[RPCMethod]
		internal void RpcAddOrRemovePlayerRoomInventoryRequest(Guid operationId, Guid roomInventoryItemId, int quantity, RPCInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9230240", Offset = "0x922EE40", VA = "0x189230240")]
		private void MKORXWLDGXQ(WJBKOLNRRJE a, Guid b, PlayerRoomInventoryOperationResult c, long d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9231C30", Offset = "0x9230830", VA = "0x189231C30")]
		[RPCMethod]
		internal void RpcSendAddOrRemovePlayerRoomInventoryResultToPlayer(Guid operationId, int result, long playerOwnedCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x922D2F0", Offset = "0x922BEF0", VA = "0x18922D2F0")]
		private void DWULHEXQCAS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9231BD0", Offset = "0x92307D0", VA = "0x189231BD0")]
		[RPCMethod]
		private void RpcOnNotifiedOfSortingTabIsEnabledToggled(bool isEnabledBool)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x922CD30", Offset = "0x922B930", VA = "0x18922CD30")]
		private void AXWQQFFKTRE(List<RoomInventoryItemTagDTO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9231A20", Offset = "0x9230620", VA = "0x189231A20")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryTagUpdates(string serializedTags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x922D190", Offset = "0x922BD90", VA = "0x18922D190")]
		private void DPYLVCJFBAN(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x92319B0", Offset = "0x92305B0", VA = "0x1892319B0")]
		[RPCMethod]
		private void RpcOnNotifiedOfRoomInventoryTagDeleted(long tagId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x922E260", Offset = "0x922CE60", VA = "0x18922E260")]
		private XMBVVYPKIUV FGNRZIGPIGE(RoomInventoryItemDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9232800", Offset = "0x9231400", VA = "0x189232800")]
		private List<AQMMKJORJTE> VPRKTIGCKQT(List<RoomInventoryItemTagDTO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x922F860", Offset = "0x922E460", VA = "0x18922F860")]
		private List<AQMMKJORJTE> JRJYIPMCUEL(IEnumerable<RoomInventoryItemTagDTO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x922D590", Offset = "0x922C190", VA = "0x18922D590", Slot = "36")]
		public RoomInventoryItemProperties DeserializeRoomInventoryItemProperties(string serializedRoomInventoryItemPropertyString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9230CF0", Offset = "0x922F8F0", VA = "0x189230CF0")]
		private XMBVVYPKIUV PEAMPJTAXSX(RoomInventoryItemDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x922D450", Offset = "0x922C050", VA = "0x18922D450", Slot = "35")]
		public RoomInventoryItemDTO DehydrateRoomInventoryItemToDTO(XMBVVYPKIUV inventoryItem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x922F040", Offset = "0x922DC40", VA = "0x18922F040")]
		private AQMMKJORJTE HydrateRoomInventoryTagFromDTO(RoomInventoryItemTagDTO dto)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x922FE70", Offset = "0x922EA70", VA = "0x18922FE70")]
		private void KTJYAQOKUFF(PlayerRoomInventoryItem a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x922CE50", Offset = "0x922BA50", VA = "0x18922CE50")]
		private void BCXTCHETZSS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x92300B0", Offset = "0x922ECB0", VA = "0x1892300B0")]
		private Task LXSMXTNKYSC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9233820", Offset = "0x9232420", VA = "0x189233820")]
		private void YBQMIUPSKTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x92329D0", Offset = "0x92315D0", VA = "0x1892329D0")]
		private void WKCHWJCPHQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x922CEC0", Offset = "0x922BAC0", VA = "0x18922CEC0")]
		private void CMULVJZRABB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x922EF30", Offset = "0x922DB30", VA = "0x18922EF30")]
		[AsyncStateMachine(typeof(<CullTagsOnDelete>d__133))]
		private Task HVUADCXUYWS(XMBVVYPKIUV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x922E110", Offset = "0x922CD10", VA = "0x18922E110")]
		[CompilerGenerated]
		private void EYHFYQWQXDV(Task<TaskStatus> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x922E480", Offset = "0x922D080", VA = "0x18922E480")]
		[CompilerGenerated]
		private Task<PlayerRoomInventoryOperationResult> FUIVHMEIOAG(<>c__DisplayClass97_0 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9232040", Offset = "0x9230C40", VA = "0x189232040")]
		[CompilerGenerated]
		internal static Dictionary<RoomInventoryItemUniqueId, AddOrRemovePlayerRoomInventoryItemCountResponseDTO> TNWMRYEYPFG(PlayerRoomInventoryOperationResult a, <>c__DisplayClass98_0 b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RoomInventoryItemPropertiesCache : Dictionary<string, RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9234520", Offset = "0x9233120", VA = "0x189234520")]
		public RoomInventoryItemPropertiesCache()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface GXOVITQLELT
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PUIZNPTYJVH SXZWFLGZDSN();

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RoomInventoryItemPropertiesCache DHBSHDCFCPI();

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IYARTNDOVUP BSZEMQMEVGD();
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class IAFXTMRHXUJ : GXOVITQLELT
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x922A0A0", Offset = "0x9228CA0", VA = "0x18922A0A0")]
		[IFIZWETSKCB.Session.GameOnly]
		internal static void RIWNJSDCBRY(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		[RecRoom.NoEngine.Common.Preserve]
		public IAFXTMRHXUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x922A110", Offset = "0x9228D10", VA = "0x18922A110", Slot = "4")]
		public PUIZNPTYJVH SXZWFLGZDSN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x922A030", Offset = "0x9228C30", VA = "0x18922A030", Slot = "5")]
		public RoomInventoryItemPropertiesCache DHBSHDCFCPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9229F50", Offset = "0x9228B50", VA = "0x189229F50", Slot = "6")]
		public IYARTNDOVUP BSZEMQMEVGD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class IYARTNDOVUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly Dictionary<long, AQMMKJORJTE> VODTTZZNMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly AQMMKJORJTE[] PPQMIJRZEMA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool CITSZQKEPMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xBF7030", Offset = "0xBF5C30", VA = "0x180BF7030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xBF7010", Offset = "0xBF5C10", VA = "0x180BF7010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int DXXTXCFQSDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x922A3C0", Offset = "0x9228FC0", VA = "0x18922A3C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private long FLCUVNVHNYN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xB13130", Offset = "0xB11D30", VA = "0x180B13130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x922AB10", Offset = "0x9229710", VA = "0x18922AB10")]
		public void NewRoom(long roomId, IEnumerable<AQMMKJORJTE> tags, bool sortingTabIsEnabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x922A210", Offset = "0x9228E10", VA = "0x18922A210")]
		public IReadOnlyList<AQMMKJORJTE> BQWLKYLQMAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xBF7010", Offset = "0xBF5C10", VA = "0x180BF7010")]
		public void LNVCJOTQQMI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x922A420", Offset = "0x9229020", VA = "0x18922A420")]
		public bool FPMKDVCEJXR(long a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x922B190", Offset = "0x9229D90", VA = "0x18922B190")]
		public bool ZZOVQMPNAFC(AQMMKJORJTE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x922A7F0", Offset = "0x92293F0", VA = "0x18922A7F0")]
		public bool NKEHEGLKSBG(List<AQMMKJORJTE> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x922B0F0", Offset = "0x9229CF0", VA = "0x18922B0F0")]
		public bool WUPAIVNJMXX(long a, [Out] AQMMKJORJTE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x922A500", Offset = "0x9229100", VA = "0x18922A500")]
		public bool HLVQVFGYCZZ(string a, [Out] AQMMKJORJTE b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x922B020", Offset = "0x9229C20", VA = "0x18922B020")]
		public List<AQMMKJORJTE> VXNGOSNSHNF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x922A6B0", Offset = "0x92292B0", VA = "0x18922A6B0")]
		public List<AQMMKJORJTE> LUVAHYBHREF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8CF3520", Offset = "0x8CF2120", VA = "0x188CF3520")]
		public AQMMKJORJTE CYQDJSMYQQB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x922AFC0", Offset = "0x9229BC0", VA = "0x18922AFC0")]
		public IReadOnlyList<AQMMKJORJTE> UQBHAVEXCAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x922B350", Offset = "0x9229F50", VA = "0x18922B350")]
		public IYARTNDOVUP()
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
