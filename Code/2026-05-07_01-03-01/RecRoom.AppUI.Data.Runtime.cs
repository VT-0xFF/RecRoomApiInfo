using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecNet.AI;
using RecNet.Common;
using RecNet.Discovery;
using RecNet.Interfaces.IDs;
using RecNet.Lists;
using RecNet.Rooms;
using RecRoom.Analytics.Statsig;
using RecRoom.Avatars;
using RecRoom.Core;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.FuzzySearch;
using RecRoom.Initialization;
using RecRoom.Keepsakes;
using RecRoom.NoEngine.Common;
using RecRoom.OnlineRestrictions;
using RecRoom.ProgressionEvents;
using RecRoom.Protobuf;
using RecRoom.RoomEconomy.Store;
using RecRoom.RoomLoading;
using RecRoom.Storefronts;
using UJect;
using UJect.Injection;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x95511E0", Offset = "0x954FBE0", VA = "0x1895511E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AppUI_Data_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9566170", Offset = "0x9564B70", VA = "0x189566170", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29F5EA0", Offset = "0x29F48A0", VA = "0x1829F5EA0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecNet.Rooms
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class CJNZVAHRGXY
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct <GetFirstValidSave>d__1 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public AsyncTaskMethodBuilder<SubRoomDataSaveDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public List<SubRoomDataSaveDTO> roomSaves;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private NFIQEQJDFAG <roomsClient>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private List<SubRoomDataSaveDTO>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private SubRoomDataSaveDTO <roomSave>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9559580", Offset = "0x9557F80", VA = "0x189559580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9559B60", Offset = "0x9558560", VA = "0x189559B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private struct <GetRoomValidity>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public AsyncTaskMethodBuilder<List<bool>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public List<SubRoomDataSaveDTO> roomSaves;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private NFIQEQJDFAG <roomsClient>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private List<bool> <results>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private List<SubRoomDataSaveDTO>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x955D4D0", Offset = "0x955BED0", VA = "0x18955D4D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x955DB00", Offset = "0x955C500", VA = "0x18955DB00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct <StudioRoomHasAllUnityAssets>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public SubRoomDataSaveDTO roomSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public NFIQEQJDFAG roomsClient;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9565AC0", Offset = "0x95644C0", VA = "0x189565AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9565EF0", Offset = "0x95648F0", VA = "0x189565EF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x95501D0", Offset = "0x954EBD0", VA = "0x1895501D0")]
		[AsyncStateMachine(typeof(<GetRoomValidity>d__0))]
		public static Task<List<bool>> KSCGHRINSMZ(List<SubRoomDataSaveDTO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x95502E0", Offset = "0x954ECE0", VA = "0x1895502E0")]
		[AsyncStateMachine(typeof(<GetFirstValidSave>d__1))]
		public static Task<SubRoomDataSaveDTO> OBFTWMVTOBD(List<SubRoomDataSaveDTO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x95503F0", Offset = "0x954EDF0", VA = "0x1895503F0")]
		[AsyncStateMachine(typeof(<StudioRoomHasAllUnityAssets>d__2))]
		private static Task<bool> ZKXZVGJDFAC(NFIQEQJDFAG a, SubRoomDataSaveDTO b)
		{
			return null;
		}
	}
}
namespace RecRoom.AppUI.Data
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AccountQueryManager : IAccountQueryManager
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct <GetAccountListForQueryData>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public AsyncTaskMethodBuilder<List<int>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public AccountListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AccountQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private TaskAwaiter<List<int>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9556CC0", Offset = "0x95556C0", VA = "0x189556CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x95571B0", Offset = "0x9555BB0", VA = "0x1895571B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct <GetAccountOrNullByIdAsync>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public AsyncTaskMethodBuilder<Account> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TaskAwaiter<Account?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9557220", Offset = "0x9555C20", VA = "0x189557220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9557400", Offset = "0x9555E00", VA = "0x189557400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct <GetAccountsFromCuratedList>d__24 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AsyncTaskMethodBuilder<List<int>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AccountListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<CuratedListDTO?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9557470", Offset = "0x9555E70", VA = "0x189557470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9557980", Offset = "0x9556380", VA = "0x189557980", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <GetIsInfluencerAsync>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9559BD0", Offset = "0x95585D0", VA = "0x189559BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9559DE0", Offset = "0x95587E0", VA = "0x189559DE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct <GetProgressionAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public AsyncTaskMethodBuilder<Progression> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private TaskAwaiter<Progression> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x955AEF0", Offset = "0x95598F0", VA = "0x18955AEF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x955B100", Offset = "0x9559B00", VA = "0x18955B100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <GetReputationAsync>d__27 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public AsyncTaskMethodBuilder<Reputation> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private TaskAwaiter<Reputation> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x955B170", Offset = "0x9559B70", VA = "0x18955B170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x955B380", Offset = "0x9559D80", VA = "0x18955B380", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <SearchAccountsByDisplayNameAsync>d__15 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public AsyncTaskMethodBuilder<List<int>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public string searchQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private TaskAwaiter<List<Account>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x95653A0", Offset = "0x9563DA0", VA = "0x1895653A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9565720", Offset = "0x9564120", VA = "0x189565720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<Action> allFriendsChangedSubscribers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<Action> onlineFriendsChangedSubscribers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private List<Action> nearbyPlayersUpdatedSubscribers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<Action> playerPresenceUpdatedSubscribers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<AccountListQueryType, AccountSearchContext> _searchContextCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly IRRUIvNextAccountBridge _vNextAccountBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly IRRUIvNextSocialBridge _vNextSocialBridge;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly List<int> ImmediateIds;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int LocalPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x954BB60", Offset = "0x954A560", VA = "0x18954BB60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9549F00", Offset = "0x9548900", VA = "0x189549F00")]
		[ONTQUCAGRJW.Root.GameOnly]
		internal static void DIBind(KLUMUBWDFVY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x954B780", Offset = "0x954A180", VA = "0x18954B780")]
		[RecRoom.NoEngine.Common.Preserve]
		public AccountQueryManager([Inject(null)] IRRUIvNextAccountBridge vNextAccountBridge, [Inject(null)] IRRUIvNextSocialBridge vNextSocialBridge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x954A0A0", Offset = "0x9548AA0", VA = "0x18954A0A0", Slot = "5")]
		public Task<Account> GetAccountAsync(int accountId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x954A230", Offset = "0x9548C30", VA = "0x18954A230", Slot = "7")]
		[AsyncStateMachine(typeof(<GetAccountOrNullByIdAsync>d__12))]
		public Task<Account> GetAccountOrNullByIdAsync(int accountId, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x954A330", Offset = "0x9548D30", VA = "0x18954A330", Slot = "6")]
		public Task<List<Account>> GetAccountsBulkAsync(IReadOnlyList<int> accountIds, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x954A120", Offset = "0x9548B20", VA = "0x18954A120", Slot = "8")]
		[AsyncStateMachine(typeof(<GetAccountListForQueryData>d__14))]
		public Task<List<int>> GetAccountListForQueryData(AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x954B480", Offset = "0x9549E80", VA = "0x18954B480", Slot = "14")]
		[AsyncStateMachine(typeof(<SearchAccountsByDisplayNameAsync>d__15))]
		public Task<List<int>> SearchAccountsByDisplayNameAsync(string searchQuery, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x954AB60", Offset = "0x9549560", VA = "0x18954AB60", Slot = "15")]
		public IAccountSearchContext GetOrCreateSearchContext(AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9549F70", Offset = "0x9548970", VA = "0x189549F70", Slot = "16")]
		public void DisposeSearchContext(AccountListQueryData queryData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x954B590", Offset = "0x9549F90", VA = "0x18954B590", Slot = "9")]
		public void SubscribeToAccountListUpdates(AccountListQueryData queryData, Action onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x954B640", Offset = "0x954A040", VA = "0x18954B640", Slot = "10")]
		public void UnsubscribeFromAccountListUpdates(AccountListQueryData queryData, Action onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x954A4A0", Offset = "0x9548EA0", VA = "0x18954A4A0")]
		private List<int> GetFriendListForQueryData(AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x954AD40", Offset = "0x9549740", VA = "0x18954AD40")]
		private List<int> GetRecentAccountsForQueryData(AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x954A9A0", Offset = "0x95493A0", VA = "0x18954A9A0")]
		private List<int> GetNearbyAccountsForQueryData(AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x954A3B0", Offset = "0x9548DB0", VA = "0x18954A3B0")]
		[AsyncStateMachine(typeof(<GetAccountsFromCuratedList>d__24))]
		private Task<List<int>> GetAccountsFromCuratedList(AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x954AFC0", Offset = "0x95499C0", VA = "0x18954AFC0")]
		private List<int> LimitResults(AccountListQueryData queryData, List<int> ids)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x954AC40", Offset = "0x9549640", VA = "0x18954AC40", Slot = "11")]
		[AsyncStateMachine(typeof(<GetProgressionAsync>d__26))]
		public Task<Progression> GetProgressionAsync(int accountId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x954AEC0", Offset = "0x95498C0", VA = "0x18954AEC0", Slot = "12")]
		[AsyncStateMachine(typeof(<GetReputationAsync>d__27))]
		public Task<Reputation> GetReputationAsync(int accountId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x954A8A0", Offset = "0x95492A0", VA = "0x18954A8A0", Slot = "13")]
		[AsyncStateMachine(typeof(<GetIsInfluencerAsync>d__28))]
		public Task<bool> GetIsInfluencerAsync(int accountId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x954B380", Offset = "0x9549D80", VA = "0x18954B380")]
		private void OnRelationshipUpdated(int? playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x954B180", Offset = "0x9549B80", VA = "0x18954B180")]
		private void OnOnlineFriendsListUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x954B080", Offset = "0x9549A80", VA = "0x18954B080")]
		private void OnNearbyPlayersUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x954B280", Offset = "0x9549C80", VA = "0x18954B280")]
		private void OnPlayerPresenceUpdated(int accountId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class AccountSearchContext : IAccountSearchContext, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private EBLOFGIMQJW _fuzzySearchContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private IReadOnlyList<Account> _accounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IReadOnlyList<int> _stringIndexToAccountIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int[] _resultBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool[] _seenBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Action<IReadOnlyList<int>> _pendingCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private string _currentQuery;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x954C7D0", Offset = "0x954B1D0", VA = "0x18954C7D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x954BFF0", Offset = "0x954A9F0", VA = "0x18954BFF0", Slot = "5")]
		public void Initialize(IReadOnlyList<Account> accounts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x954BBA0", Offset = "0x954A5A0", VA = "0x18954BBA0", Slot = "6")]
		public void BeginSearch(string query, Action<IReadOnlyList<int>> onComplete)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x954BED0", Offset = "0x954A8D0", VA = "0x18954BED0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x954C4E0", Offset = "0x954AEE0", VA = "0x18954C4E0")]
		private void OnFuzzySearchComplete(IReadOnlyList<FuzzySearchStringScored> results, IReadOnlyList<bool> charMatches)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x954BF60", Offset = "0x954A960", VA = "0x18954BF60")]
		private static int ExactUsernameSearchHeuristic(ReadOnlySpan<char> searchString, ReadOnlySpan<char> targetString, int targetIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public AccountSearchContext()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AppNavDataManager : IAppNavDataManager, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct <CanWidgetBeShownInContext>d__53 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public string widgetId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private WidgetConfig <widget>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9555A50", Offset = "0x9554450", VA = "0x189555A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x95565B0", Offset = "0x9554FB0", VA = "0x1895565B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct <DoPeriodicContextCheck>d__61 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int <oneMinMs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9556960", Offset = "0x9555360", VA = "0x189556960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9556C60", Offset = "0x9555660", VA = "0x189556C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct <GetCuratedListSections>d__52 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public AsyncTaskMethodBuilder<IReadOnlyList<SectionDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public string listName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private TaskAwaiter<CuratedListDTO?> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x95587A0", Offset = "0x95571A0", VA = "0x1895587A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9558B00", Offset = "0x9557500", VA = "0x189558B00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <GetDiscoverySection>d__50 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AsyncTaskMethodBuilder<List<SectionDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public PageSource source;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private List<SectionDTO> <sections>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private TaskAwaiter<List<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x9558B70", Offset = "0x9557570", VA = "0x189558B70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9558EC0", Offset = "0x95578C0", VA = "0x189558EC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <GetDiscoverySection>d__51 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<List<SectionDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public string pageSourceName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private List<SectionDTO> <sections>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private TaskAwaiter<List<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9558F30", Offset = "0x9557930", VA = "0x189558F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9559260", Offset = "0x9557C60", VA = "0x189559260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private struct <GetPortalPanelConfig>d__45 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AsyncTaskMethodBuilder<PortalPanelConfig> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private PortalPanelConfig <panelConfig>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<List<SectionDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private List<SectionDTO>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TaskAwaiter<PortalButtonGroupConfig> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x955A5D0", Offset = "0x9558FD0", VA = "0x18955A5D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x955AE80", Offset = "0x9559880", VA = "0x18955AE80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private struct <GetWidgetListForPanel>d__42 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public AsyncTaskMethodBuilder<List<string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public string panelId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private AppNavWidgetConfig <config>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private List<string> <widgetIds>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private TaskAwaiter<AppNavWidgetConfig> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private List<WidgetPanelConfig>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private List<string>.Enumerator <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private string <widgetId>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private TaskAwaiter<bool> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x955EDC0", Offset = "0x955D7C0", VA = "0x18955EDC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x955F940", Offset = "0x955E340", VA = "0x18955F940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private struct <GetWidgetPanelConfig>d__47 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public AsyncTaskMethodBuilder<AppNavWidgetConfig> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private AppNavWidgetConfig <config>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<List<SectionDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private List<SectionDTO>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private TaskAwaiter<WidgetPanelConfig> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x955F9B0", Offset = "0x955E3B0", VA = "0x18955F9B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9560400", Offset = "0x955EE00", VA = "0x189560400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private struct <GetWidgetPanelIds>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public AsyncTaskMethodBuilder<List<string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private TaskAwaiter<AppNavWidgetConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9560470", Offset = "0x955EE70", VA = "0x189560470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9560870", Offset = "0x955F270", VA = "0x189560870", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct <RefreshContextAsync>d__55 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private bool <contextChanged>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private TaskAwaiter<Commerce.RRPlusSignUpBonusDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9563770", Offset = "0x9562170", VA = "0x189563770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x95641A0", Offset = "0x9562BA0", VA = "0x1895641A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private struct <ResolvePortalSection>d__46 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AsyncTaskMethodBuilder<PortalButtonGroupConfig> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public SectionDTO section;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private PortalButtonGroupConfig <sectionConfig>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9564200", Offset = "0x9562C00", VA = "0x189564200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x95647E0", Offset = "0x95631E0", VA = "0x1895647E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private struct <ResolveWidgetPanel>d__48 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<WidgetPanelConfig> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public SectionDTO dto;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private WidgetPanelConfig <panel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private TaskAwaiter<List<SectionDTO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9564850", Offset = "0x9563250", VA = "0x189564850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x95650B0", Offset = "0x9563AB0", VA = "0x1895650B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private struct <StartPeriodicContextCheck>d__60 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9565790", Offset = "0x9564190", VA = "0x189565790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9565A60", Offset = "0x9564460", VA = "0x189565A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly IRRUIvNextUIDataBridge vNextDataBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly IRRUIvNextSocialBridge vNextSocialBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly FGNKODXRVEL roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly IRecRoomPlusDataManager rrPlusDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private PortalPanelConfig fallbackPortalPanelConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private AppNavWidgetConfig fallbackWidgetConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private PortalPanelConfig cachedPortalConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private AppNavWidgetConfig cachedConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Dictionary<string, WidgetConfig> widgetConfigLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private HashSet<string> activeContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Dictionary<string, int> activeContextValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float lastRoomJoinTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private CancellationTokenSource periodicContextCheckCancellationToken;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public BQUYOYJDJCS WidgetContextChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xCD75F0", Offset = "0xCD5FF0", VA = "0x180CD75F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string> WidgetListForPanelChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9550050", Offset = "0x954EA50", VA = "0x189550050", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x9550110", Offset = "0x954EB10", VA = "0x189550110", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x954E530", Offset = "0x954CF30", VA = "0x18954E530")]
		[ONTQUCAGRJW.Session.GameOnly]
		internal static void DIBind(KLUMUBWDFVY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x954FCC0", Offset = "0x954E6C0", VA = "0x18954FCC0")]
		[RecRoom.NoEngine.Common.Preserve]
		public AppNavDataManager([Inject(null)] IRRUIvNextUIDataBridge vNextBridge, [Inject(null)] IRRUIvNextSocialBridge socialBridge, [Inject(null)] FGNKODXRVEL roomManager, [Inject(null)] IRecRoomPlusDataManager rrPlusDataManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x954E5A0", Offset = "0x954CFA0", VA = "0x18954E5A0", Slot = "13")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x954EFC0", Offset = "0x954D9C0", VA = "0x18954EFC0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetWidgetPanelIds>d__40))]
		public Task<List<string>> GetWidgetPanelIds(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x954F7D0", Offset = "0x954E1D0", VA = "0x18954F7D0", Slot = "8")]
		public bool TryGetWidgetPanelIcon(string panelId, [Out] string iconId, [Out] bool useProfilePicture)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x954ED40", Offset = "0x954D740", VA = "0x18954ED40", Slot = "9")]
		[AsyncStateMachine(typeof(<GetWidgetListForPanel>d__42))]
		public Task<List<string>> GetWidgetListForPanel(string panelId, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x954FA60", Offset = "0x954E460", VA = "0x18954FA60", Slot = "10")]
		public bool TryGetWidgetTypeId(string widgetId, [Out] string widgetTypeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x954F9B0", Offset = "0x954E3B0", VA = "0x18954F9B0", Slot = "11")]
		public bool TryGetWidgetSourceData(string widgetId, [Out] WidgetSourceData sourceData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x954EC10", Offset = "0x954D610", VA = "0x18954EC10", Slot = "12")]
		[AsyncStateMachine(typeof(<GetPortalPanelConfig>d__45))]
		public Task<PortalPanelConfig> GetPortalPanelConfig(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x954F340", Offset = "0x954DD40", VA = "0x18954F340")]
		[AsyncStateMachine(typeof(<ResolvePortalSection>d__46))]
		private Task<PortalButtonGroupConfig> ResolvePortalSection(SectionDTO section, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x954EE90", Offset = "0x954D890", VA = "0x18954EE90")]
		[AsyncStateMachine(typeof(<GetWidgetPanelConfig>d__47))]
		private Task<AppNavWidgetConfig> GetWidgetPanelConfig(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x954F480", Offset = "0x954DE80", VA = "0x18954F480")]
		[AsyncStateMachine(typeof(<ResolveWidgetPanel>d__48))]
		private Task<WidgetPanelConfig> ResolveWidgetPanel(SectionDTO dto, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x954F5C0", Offset = "0x954DFC0", VA = "0x18954F5C0")]
		private WidgetConfig ResolveWidget(SectionDTO section)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x954EB00", Offset = "0x954D500", VA = "0x18954EB00")]
		[AsyncStateMachine(typeof(<GetDiscoverySection>d__50))]
		private Task<List<SectionDTO>> GetDiscoverySection(PageSource source, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x954E9E0", Offset = "0x954D3E0", VA = "0x18954E9E0")]
		[AsyncStateMachine(typeof(<GetDiscoverySection>d__51))]
		private Task<List<SectionDTO>> GetDiscoverySection(string pageSourceName, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x954E8C0", Offset = "0x954D2C0", VA = "0x18954E8C0")]
		[AsyncStateMachine(typeof(<GetCuratedListSections>d__52))]
		private Task<IReadOnlyList<SectionDTO>> GetCuratedListSections(string listName, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x954C7F0", Offset = "0x954B1F0", VA = "0x18954C7F0")]
		[AsyncStateMachine(typeof(<CanWidgetBeShownInContext>d__53))]
		private Task<bool> CanWidgetBeShownInContext(string widgetId, AppNavWidgetConfig appNavConfig)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x954F2E0", Offset = "0x954DCE0", VA = "0x18954F2E0")]
		private void RefreshContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x954F210", Offset = "0x954DC10", VA = "0x18954F210")]
		[AsyncStateMachine(typeof(<RefreshContextAsync>d__55))]
		private Task RefreshContextAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x954FBE0", Offset = "0x954E5E0", VA = "0x18954FBE0")]
		private bool UpdateActiveContext(string context, bool currentState)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x954FB20", Offset = "0x954E520", VA = "0x18954FB20")]
		private bool UpdateActiveContextValue(string context, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xE4D7F0", Offset = "0xE4C1F0", VA = "0x180E4D7F0")]
		private void OnContextChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x954F0D0", Offset = "0x954DAD0", VA = "0x18954F0D0")]
		private void OnRoomEventSucceeded(RoomEvent roomEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x954F700", Offset = "0x954E100", VA = "0x18954F700")]
		[AsyncStateMachine(typeof(<StartPeriodicContextCheck>d__60))]
		private Task StartPeriodicContextCheck()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x954E7D0", Offset = "0x954D1D0", VA = "0x18954E7D0")]
		[AsyncStateMachine(typeof(<DoPeriodicContextCheck>d__61))]
		private Task DoPeriodicContextCheck(CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x954D930", Offset = "0x954C330", VA = "0x18954D930")]
		private AppNavWidgetConfig CreateFallbackWidgetPanelConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x954C9D0", Offset = "0x954B3D0", VA = "0x18954C9D0")]
		private WidgetCondition CreateCondition(string rawData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x954CA60", Offset = "0x954B460", VA = "0x18954CA60")]
		private PortalPanelConfig CreateFallbackPortalPanelConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x954C910", Offset = "0x954B310", VA = "0x18954C910")]
		private PortalButtonConfig CreateButtonConfig(string name, string icon, string route, bool excludeJuniors = false, [Optional] string[] unsupportedPlatforms)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class ClubQueryManager : IClubQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private class ClubhouseSummaryData : IEquatable<ClubhouseSummaryData>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public long ClubId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public long ClubhouseId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public int MemberCount;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			[CompilerGenerated]
			protected virtual Type EqualityContract
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x95510F0", Offset = "0x954FAF0", VA = "0x1895510F0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x95510A0", Offset = "0x954FAA0", VA = "0x1895510A0")]
			public ClubhouseSummaryData(long clubId, long clubhouseId, int memberCount)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x9550FB0", Offset = "0x954F9B0", VA = "0x189550FB0", Slot = "3")]
			[CompilerGenerated]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9550EC0", Offset = "0x954F8C0", VA = "0x189550EC0", Slot = "6")]
			[CompilerGenerated]
			protected virtual bool PrintMembers(StringBuilder builder)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x9550C90", Offset = "0x954F690", VA = "0x189550C90", Slot = "2")]
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9550A80", Offset = "0x954F480", VA = "0x189550A80", Slot = "0")]
			[CompilerGenerated]
			public override bool Equals(object? obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9550B10", Offset = "0x954F510", VA = "0x189550B10", Slot = "7")]
			[CompilerGenerated]
			public virtual bool Equals(ClubhouseSummaryData? other)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <GetClubhouseIdsForMyClubs>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<List<long>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public ClubQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public bool sortByClubMemberCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int maxQuerySize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private List<Club> <myClubs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private TaskAwaiter<List<Club>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9557F90", Offset = "0x9556990", VA = "0x189557F90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9558730", Offset = "0x9557130", VA = "0x189558730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private struct <PopulateClubhouseRoomSummaryData>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public ClubQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private TaskAwaiter<IReadOnlyList<ClubhouseRoomSummaryDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9560B60", Offset = "0x955F560", VA = "0x189560B60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9561030", Offset = "0x955FA30", VA = "0x189561030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private LWCSZZPQTXV onlineRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private List<Club> clubWithClubhouses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Dictionary<long, ClubhouseSummaryData> clubhouseRoomSummaryLookup;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9550500", Offset = "0x954EF00", VA = "0x189550500")]
		[ONTQUCAGRJW.Session.GameOnly]
		internal static void DIBind(KLUMUBWDFVY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x95509C0", Offset = "0x954F3C0", VA = "0x1895509C0")]
		[RecRoom.NoEngine.Common.Preserve]
		public ClubQueryManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9550670", Offset = "0x954F070", VA = "0x189550670", Slot = "4")]
		[AsyncStateMachine(typeof(<GetClubhouseIdsForMyClubs>d__6))]
		public Task<List<long>> GetClubhouseIdsForMyClubs(bool sortByClubMemberCount, int maxQuerySize, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x95507C0", Offset = "0x954F1C0", VA = "0x1895507C0")]
		[AsyncStateMachine(typeof(<PopulateClubhouseRoomSummaryData>d__7))]
		private Task PopulateClubhouseRoomSummaryData(CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9550570", Offset = "0x954EF70", VA = "0x189550570")]
		private void FilterOutClubsWithoutClubhouse(List<Club> clubList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x95508B0", Offset = "0x954F2B0", VA = "0x1895508B0")]
		private int SortClubsByMemberCount(Club lhs, Club rhs)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class OutfitManager : IOutfitDataManager
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private struct <GetLocalPlayerOutfits>d__15 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public AsyncTaskMethodBuilder<List<XEFFPEITNXG>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public OutfitManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public int maxResultCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public bool publicOnly;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public bool excludeCurrentlyEquipped;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private TaskAwaiter<IReadOnlyDictionary<int, OutfitDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9559E50", Offset = "0x9558850", VA = "0x189559E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x955A560", Offset = "0x9558F60", VA = "0x18955A560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct <GetTotalSavedOutfitCount>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public OutfitManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter<IReadOnlyDictionary<int, OutfitDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x955E580", Offset = "0x955CF80", VA = "0x18955E580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x955E7A0", Offset = "0x955D1A0", VA = "0x18955E7A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct <LoadOutfitAsync>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public OutfitManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public XEFFPEITNXG outfitData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x95608E0", Offset = "0x955F2E0", VA = "0x1895608E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9560B00", Offset = "0x955F500", VA = "0x189560B00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private struct <SaveOutfitAsync>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public OutfitManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public int slotIdx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9565120", Offset = "0x9563B20", VA = "0x189565120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x9565340", Offset = "0x9563D40", VA = "0x189565340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly IRRUIvNextUIDataBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly WEPKKZZGWWO recNetOutfits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly KTQYDSNFVHL avatarDataManager;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public BQUYOYJDJCS LocalPlayerOutfitChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public BQUYOYJDJCS OutfitsUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9551260", Offset = "0x954FC60", VA = "0x189551260")]
		[ONTQUCAGRJW.Session.GameOnly]
		internal static void DIBind(KLUMUBWDFVY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9551BE0", Offset = "0x95505E0", VA = "0x189551BE0")]
		[RecRoom.NoEngine.Common.Preserve]
		public OutfitManager([Inject(null)] IRRUIvNextUIDataBridge vNextBridge, [Inject(null)] WEPKKZZGWWO recNetOutfits, [Inject(null)] KTQYDSNFVHL avatarDataManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x95512D0", Offset = "0x954FCD0", VA = "0x1895512D0", Slot = "1")]
		~OutfitManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x95515E0", Offset = "0x954FFE0", VA = "0x1895515E0", Slot = "6")]
		[AsyncStateMachine(typeof(<GetTotalSavedOutfitCount>d__14))]
		public Task<int> GetTotalSavedOutfitCount(CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x95514C0", Offset = "0x954FEC0", VA = "0x1895514C0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetLocalPlayerOutfits>d__15))]
		public Task<List<XEFFPEITNXG>> GetLocalPlayerOutfits(CancellationToken token, bool publicOnly = false, int maxResultCount = -1, bool excludeCurrentlyEquipped = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x95516D0", Offset = "0x95500D0", VA = "0x1895516D0", Slot = "8")]
		[AsyncStateMachine(typeof(<LoadOutfitAsync>d__17))]
		public Task LoadOutfitAsync(XEFFPEITNXG outfitData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9551B00", Offset = "0x9550500", VA = "0x189551B00", Slot = "9")]
		[AsyncStateMachine(typeof(<SaveOutfitAsync>d__18))]
		public Task SaveOutfitAsync(int slotIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9551950", Offset = "0x9550350", VA = "0x189551950")]
		private void OnLocalPlayerCreated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x107BB00", Offset = "0x107A500", VA = "0x18107BB00")]
		private void OnLocalPlayerOutfitLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9551A20", Offset = "0x9550420", VA = "0x189551A20")]
		private void OnLocalPlayerDestroying()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9551AE0", Offset = "0x95504E0", VA = "0x189551AE0")]
		private void OnOutfitUpdated(int accountId, int slot, OutfitDTO? outfit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x95517C0", Offset = "0x95501C0", VA = "0x1895517C0")]
		private bool Matches(XEFFPEITNXG lhs, XEFFPEITNXG rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9551920", Offset = "0x9550320", VA = "0x189551920")]
		private bool MeetsDesiredPermissionLevel(OutfitDTO outfitDto, bool publicOnly)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class RecRoomPlusDataManager : IRecRoomPlusDataManager
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private struct <CheckFreeItemSignOnBonusEligibility>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public AsyncTaskMethodBuilder<Commerce.RRPlusSignUpBonusDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public RecRoomPlusDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private TaskAwaiter<Commerce.RRPlusSignUpBonusDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9556620", Offset = "0x9555020", VA = "0x189556620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x95568F0", Offset = "0x95552F0", VA = "0x1895568F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct <GetBenefits>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public AsyncTaskMethodBuilder<List<RecRoomPlusBenefitData>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public RecRoomPlusDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private TaskAwaiter<List<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x95579F0", Offset = "0x95563F0", VA = "0x1895579F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9557F20", Offset = "0x9556920", VA = "0x189557F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct <GetDiscoverySection>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public AsyncTaskMethodBuilder<List<SectionDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public PageSource source;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private List<SectionDTO> <sections>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private TaskAwaiter<List<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x95592D0", Offset = "0x9557CD0", VA = "0x1895592D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9559510", Offset = "0x9557F10", VA = "0x189559510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private IRRUIvNextUIDataBridge dataBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool HasRecRoomPlusSubscription
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x95521E0", Offset = "0x9550BE0", VA = "0x1895521E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9551F50", Offset = "0x9550950", VA = "0x189551F50")]
		[ONTQUCAGRJW.Session.GameOnly]
		internal static void DIBind(KLUMUBWDFVY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xCD4A70", Offset = "0xCD3470", VA = "0x180CD4A70")]
		[RecRoom.NoEngine.Common.Preserve]
		public RecRoomPlusDataManager([Inject(null)] IRRUIvNextUIDataBridge dataBridge, [Inject(null)] IRRUIvNextStoreItemBridge storeBridge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9551FC0", Offset = "0x95509C0", VA = "0x189551FC0", Slot = "5")]
		[AsyncStateMachine(typeof(<GetBenefits>d__6))]
		public Task<List<RecRoomPlusBenefitData>> GetBenefits(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9551E40", Offset = "0x9550840", VA = "0x189551E40", Slot = "6")]
		[AsyncStateMachine(typeof(<CheckFreeItemSignOnBonusEligibility>d__7))]
		public Task<Commerce.RRPlusSignUpBonusDTO> CheckFreeItemSignOnBonusEligibility(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x95520D0", Offset = "0x9550AD0", VA = "0x1895520D0")]
		[AsyncStateMachine(typeof(<GetDiscoverySection>d__8))]
		private Task<List<SectionDTO>> GetDiscoverySection(PageSource source, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class RoomieQueryManager : IRoomieQueryManager
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private struct <GetUserFacts>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public AsyncTaskMethodBuilder<RoomieUserFactQueryData.IContext> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public RoomieUserFactQueryData.IContext roomieUserFactQueryDataContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public RoomieQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public RoomieUserFactQueryData roomieUserFactQueryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private RoomieUserFactQueryData.Context <context>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private RoomieUserFactQueryData.Context <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private TaskAwaiter<RoomieUserFactsDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x955E810", Offset = "0x955D210", VA = "0x18955E810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x955ED50", Offset = "0x955D750", VA = "0x18955ED50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly VHQGUMFBXCA _recNetAI;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9555880", Offset = "0x9554280", VA = "0x189555880")]
		[ONTQUCAGRJW.Root.GameOnly]
		internal static void DIBind(KLUMUBWDFVY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		[RecRoom.NoEngine.Common.Preserve]
		public RoomieQueryManager([Inject(null)] VHQGUMFBXCA recNetAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x95558F0", Offset = "0x95542F0", VA = "0x1895558F0", Slot = "4")]
		[AsyncStateMachine(typeof(<GetUserFacts>d__3))]
		public Task<RoomieUserFactQueryData.IContext> GetUserFacts(RoomieUserFactQueryData roomieUserFactQueryData, [Optional] RoomieUserFactQueryData.IContext roomieUserFactQueryDataContext, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9555480", Offset = "0x9553E80", VA = "0x189555480")]
		private void ApplySearchQueryFilter(RoomieUserFactQueryData queryData, RoomieUserFactQueryData.Context context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9555600", Offset = "0x9554000", VA = "0x189555600")]
		private void ApplySort(RoomieUserFactQueryData queryData, RoomieUserFactQueryData.Context context)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class RoomLoadManager : IRoomLoadManager
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly VKGUNLFZZZT activitySwitcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly FGNKODXRVEL roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[CompilerGenerated]
		private Action RoomLoadActiveChanged;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private bool RoomLoadActive
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xCDB290", Offset = "0xCD9C90", VA = "0x180CDB290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9552260", Offset = "0x9550C60", VA = "0x189552260")]
		[ONTQUCAGRJW.Session.GameOnly]
		internal static void DIBind(KLUMUBWDFVY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xCD4A70", Offset = "0xCD3470", VA = "0x180CD4A70")]
		[RecRoom.NoEngine.Common.Preserve]
		public RoomLoadManager([Inject(null)] VKGUNLFZZZT activitySwitcher, [Inject(null)] FGNKODXRVEL roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x95522D0", Offset = "0x9550CD0", VA = "0x1895522D0", Slot = "4")]
		public void GoToDorm()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9552410", Offset = "0x9550E10", VA = "0x189552410", Slot = "5")]
		public void GoToWellKnownRoom(MSBQRZWCTYA room, [Optional] Action<JoinRoomResult> onResponseCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9552580", Offset = "0x9550F80", VA = "0x189552580", Slot = "6")]
		public bool HasSufficientVersionToLoadRoom(RoomDTO room)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x95525D0", Offset = "0x9550FD0", VA = "0x1895525D0", Slot = "7")]
		public void TryJoinRoom(RoomDetailsDTO roomDetails, SubRoomDTO subRoom, bool privateInstance, LoadSceneSourceData loadSourceData, [Optional] SubRoomDataSaveDTO versionTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x95525B0", Offset = "0x9550FB0", VA = "0x1895525B0")]
		private void OnRunJoinRoomResponseCallback(JoinRoomResult result)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class RoomQueryManager : IRoomQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		internal class DisplayedRoomListData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public string ListId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public HashSet<long> DisplayRoomIds;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9551140", Offset = "0x954FB40", VA = "0x189551140")]
			public DisplayedRoomListData()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private struct <GetRoom>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public AsyncTaskMethodBuilder<RoomDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private TaskAwaiter<RoomDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x955D240", Offset = "0x955BC40", VA = "0x18955D240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x955D460", Offset = "0x955BE60", VA = "0x18955D460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct <GetRoomDetails>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public AsyncTaskMethodBuilder<RoomDetailsDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x955B3F0", Offset = "0x9559DF0", VA = "0x18955B3F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x955B620", Offset = "0x955A020", VA = "0x18955B620", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct <GetRoomList>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public Func<bool> waitToContinueFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private List<RoomDTO> <roomList>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private TaskAwaiter<List<RoomDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private object <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x955B690", Offset = "0x955A090", VA = "0x18955B690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x955D1D0", Offset = "0x955BBD0", VA = "0x18955D1D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private struct <GetRoomsFromAlgorithmicListDto>d__31 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public AlgorithmicListDTO algorithmicList;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public int skip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public int take;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public Dictionary<long, string> rankingContextMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			private List<long> <idList>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x955DB70", Offset = "0x955C570", VA = "0x18955DB70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x955E280", Offset = "0x955CC80", VA = "0x18955E280", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private struct <GetRoomsFromIdList>d__30 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public List<long> idList;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x955E2F0", Offset = "0x955CCF0", VA = "0x18955E2F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x955E510", Offset = "0x955CF10", VA = "0x18955E510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private struct <QueryClubhouseSource>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			private Task<IReadOnlyList<RoomDTO>> <myOwnedRoomsTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private Task<IReadOnlyList<RoomDTO>> <clubhouseTemplateRoomsTask>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>[]> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x9561090", Offset = "0x955FA90", VA = "0x189561090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x9561750", Offset = "0x9560150", VA = "0x189561750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private struct <QueryDynamicAlgorithmicSource>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private TaskAwaiter<AlgorithmicListDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private TaskAwaiter<List<RoomDTO>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private TaskAwaiter<IReadOnlyList<RoomRecommendationGroupDTO>> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			private Task<RoomDTO> <recCenterTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			private Task<IReadOnlyList<RoomDTO>> <recentRoomsTask>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private Task<IReadOnlyList<RoomDTO>> <creatorsISubscribeToRoomTask>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private TaskAwaiter <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private TaskAwaiter<RoomRecommendationGroupDTO> <>u__6;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x95617C0", Offset = "0x95601C0", VA = "0x1895617C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x9563700", Offset = "0x9562100", VA = "0x189563700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private struct <QueryKeepsakeRoomSource>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private TaskAwaiter<List<RoomDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x9570C30", Offset = "0x956F630", VA = "0x189570C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x95710C0", Offset = "0x956FAC0", VA = "0x1895710C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct <QueryMySource>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private TaskAwaiter<List<long>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private TaskAwaiter<List<RoomDTO>> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9571130", Offset = "0x956FB30", VA = "0x189571130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x9571CF0", Offset = "0x95706F0", VA = "0x189571CF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct <QueryPlayerSource>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x9571D60", Offset = "0x9570760", VA = "0x189571D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x9572A10", Offset = "0x9571410", VA = "0x189572A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private struct <QueryRecRoomCreatorAcademySource>d__27 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			private TaskAwaiter<List<RoomDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x9572A80", Offset = "0x9571480", VA = "0x189572A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9572E40", Offset = "0x9571840", VA = "0x189572E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private struct <QueryRoomsByCreatorsISubscribeTo>d__32 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			public AsyncTaskMethodBuilder<IReadOnlyList<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			public int skip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public int take;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			private TaskAwaiter<List<int>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x9572EB0", Offset = "0x95718B0", VA = "0x189572EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9573290", Offset = "0x9571C90", VA = "0x189573290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private struct <QueryStaticListSource>d__24 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			private Task<FeaturedRoomGroupDTO> <queryTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			private TaskAwaiter<FeaturedRoomGroupDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			private TaskAwaiter<List<RoomDTO>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			private TaskAwaiter<CuratedListDTO> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x9573300", Offset = "0x9571D00", VA = "0x189573300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x9574D60", Offset = "0x9573760", VA = "0x189574D60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private XYNTEJINREW statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private LWCSZZPQTXV onlineRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private IClubQueryManager clubQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private LGHEBYOBKGV gameConfigsProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private JPDSEFSZZXX keepsakeManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private RCSWNUGOUJA progressionEventsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private IRRUIvNextUIDataBridge vNextDataBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private Dictionary<string, List<DisplayedRoomListData>> deduplicationTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private HashSet<long> dedupeExceptionRoomIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private StringBuilder builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private Dictionary<long, int> ccuCountLookup;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9552910", Offset = "0x9551310", VA = "0x189552910")]
		[ONTQUCAGRJW.Session.GameOnly]
		internal static void DIBind(KLUMUBWDFVY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9555310", Offset = "0x9553D10", VA = "0x189555310")]
		[RecRoom.NoEngine.Common.Preserve]
		public RoomQueryManager([Inject(null)] XYNTEJINREW statsig, [Inject(null)] LWCSZZPQTXV onlineRestrictions, [Inject(null)] IClubQueryManager clubQueryManager, [Inject(null)] LGHEBYOBKGV gameConfigsProvider, [Inject(null)] IRRUIvNextUIDataBridge vNextBridge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9553580", Offset = "0x9551F80", VA = "0x189553580", Slot = "4")]
		[AsyncStateMachine(typeof(<GetRoomList>d__18))]
		public Task<List<RoomDTO>> GetRoomList(RoomListQueryData queryData, CancellationToken token, [Optional] Func<bool> waitToContinueFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x95536E0", Offset = "0x95520E0", VA = "0x1895536E0", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoom>d__19))]
		public Task<RoomDTO> GetRoom(long roomId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9553450", Offset = "0x9551E50", VA = "0x189553450", Slot = "6")]
		[AsyncStateMachine(typeof(<GetRoomDetails>d__20))]
		public Task<RoomDetailsDTO> GetRoomDetails(long roomId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x95552A0", Offset = "0x9553CA0", VA = "0x1895552A0", Slot = "7")]
		public bool TryGetCCUCount(long roomId, [Out] int ccuCount)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9554250", Offset = "0x9552C50", VA = "0x189554250")]
		[AsyncStateMachine(typeof(<QueryMySource>d__22))]
		private Task<List<RoomDTO>> QueryMySource(RoomListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x95543A0", Offset = "0x9552DA0", VA = "0x1895543A0")]
		[AsyncStateMachine(typeof(<QueryPlayerSource>d__23))]
		private Task<List<RoomDTO>> QueryPlayerSource(RoomListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9554760", Offset = "0x9553160", VA = "0x189554760")]
		[AsyncStateMachine(typeof(<QueryStaticListSource>d__24))]
		private Task<List<RoomDTO>> QueryStaticListSource(RoomListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9553FB0", Offset = "0x95529B0", VA = "0x189553FB0")]
		[AsyncStateMachine(typeof(<QueryDynamicAlgorithmicSource>d__25))]
		private Task<List<RoomDTO>> QueryDynamicAlgorithmicSource(RoomListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9553E70", Offset = "0x9552870", VA = "0x189553E70")]
		[AsyncStateMachine(typeof(<QueryClubhouseSource>d__26))]
		private Task<List<RoomDTO>> QueryClubhouseSource(RoomListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x95544E0", Offset = "0x9552EE0", VA = "0x1895544E0")]
		[AsyncStateMachine(typeof(<QueryRecRoomCreatorAcademySource>d__27))]
		private Task<List<RoomDTO>> QueryRecRoomCreatorAcademySource(RoomListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9554110", Offset = "0x9552B10", VA = "0x189554110")]
		[AsyncStateMachine(typeof(<QueryKeepsakeRoomSource>d__28))]
		private Task<List<RoomDTO>> QueryKeepsakeRoomSource(RoomListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9554C50", Offset = "0x9553650", VA = "0x189554C50")]
		private static List<RoomDTO> ReorderRoomsToMatchIdList(IEnumerable<RoomDTO> rooms, List<long> idList)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9553970", Offset = "0x9552370", VA = "0x189553970")]
		[AsyncStateMachine(typeof(<GetRoomsFromIdList>d__30))]
		private Task<List<RoomDTO>> GetRoomsFromIdList(List<long> idList, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9553810", Offset = "0x9552210", VA = "0x189553810")]
		[AsyncStateMachine(typeof(<GetRoomsFromAlgorithmicListDto>d__31))]
		private Task<List<RoomDTO>> GetRoomsFromAlgorithmicListDto(AlgorithmicListDTO algorithmicList, int skip, int take, Dictionary<long, string> rankingContextMap, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9554620", Offset = "0x9553020", VA = "0x189554620")]
		[AsyncStateMachine(typeof(<QueryRoomsByCreatorsISubscribeTo>d__32))]
		private Task<IReadOnlyList<RoomDTO>> QueryRoomsByCreatorsISubscribeTo(int skip, int take, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9552BA0", Offset = "0x95515A0", VA = "0x189552BA0")]
		private void FilterByLocalPlayerCanJoin(List<RoomDTO> roomList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x95528B0", Offset = "0x95512B0", VA = "0x1895528B0")]
		private bool CanLocalPlayerJoin(RoomDTO room)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9552980", Offset = "0x9551380", VA = "0x189552980")]
		private void FilterByAccessibility(List<RoomDTO> roomList, Accessibility access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9553080", Offset = "0x9551A80", VA = "0x189553080")]
		private void FilterOutIfMatchesAccessibility(List<RoomDTO> roomList, Accessibility access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9553130", Offset = "0x9551B30", VA = "0x189553130")]
		private void FilterOutUnapprovedRoomsIfNeeded(List<RoomDTO> roomList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9553B80", Offset = "0x9552580", VA = "0x189553B80")]
		private bool IsRoomApproved(RoomDTO room)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1B22A00", Offset = "0x1B21400", VA = "0x181B22A00")]
		private bool IsExcludedFromLists(RoomDTO room)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9552AF0", Offset = "0x95514F0", VA = "0x189552AF0")]
		private void FilterByDorm(List<RoomDTO> roomList, bool isDorm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9552F00", Offset = "0x9551900", VA = "0x189552F00")]
		private void FilterOutDormOrWellKnownRooms(List<RoomDTO> roomList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9553A80", Offset = "0x9552480", VA = "0x189553A80")]
		private bool IsDormOrWellKnownRoom(RoomDTO room)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9552C80", Offset = "0x9551680", VA = "0x189552C80")]
		private void FilterByPlayerCreatedRoomOwnership(List<RoomDTO> roomList, int accountId, RoomListQueryData.PlayerCreatedRoomsFilterType filterType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9552A30", Offset = "0x9551430", VA = "0x189552A30")]
		private void FilterByClonable(List<RoomDTO> roomList, bool isClonable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9552DA0", Offset = "0x95517A0", VA = "0x189552DA0")]
		private void FilterByRoomCapacity(List<RoomDTO> roomList, (int, int)? capacityBounds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x95548B0", Offset = "0x95532B0", VA = "0x1895548B0")]
		private string RemoveAnyDuplicates(List<RoomDTO> roomList, string deduplicationKey, string listId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9553BC0", Offset = "0x95525C0", VA = "0x189553BC0")]
		private void PopulateDeduplicationExceptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9555080", Offset = "0x9553A80", VA = "0x189555080")]
		private void ShortenResultsToMaxDisplayCount(List<RoomDTO> roomList, int maxDisplayCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x95550F0", Offset = "0x9553AF0", VA = "0x1895550F0")]
		private int SortRoomsByRoom2ExperimentOrder(RoomDTO lhs, RoomDTO rhs)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x95531E0", Offset = "0x9551BE0", VA = "0x1895531E0")]
		private int GetRoom2ExperimentPrioritization(RoomDTO room)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9555160", Offset = "0x9553B60", VA = "0x189555160")]
		private void TryCacheDIObjects()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class RoomSaveManager : IRoomSaveManager
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct <GetLatestPublishedSaveForSubRoom>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public AsyncTaskMethodBuilder<SubRoomDataSaveDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public RoomSaveManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public SubRoomDTO subRoom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			private TaskAwaiter<ODFPVNYWDAJ<SubRoomDataSaveDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x95695E0", Offset = "0x9567FE0", VA = "0x1895695E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x9569AD0", Offset = "0x95684D0", VA = "0x189569AD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct <GetLatestValidSaveForSubRoom>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public AsyncTaskMethodBuilder<SubRoomDataSaveDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public RoomSaveManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public SubRoomDTO subRoom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private TaskAwaiter<ODFPVNYWDAJ<SubRoomDataSaveDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			private TaskAwaiter<SubRoomDataSaveDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x9569B40", Offset = "0x9568540", VA = "0x189569B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x9569F60", Offset = "0x9568960", VA = "0x189569F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private List<SubRoomDataSaveDTO> subRoomSaves;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9566750", Offset = "0x9565150", VA = "0x189566750")]
		[ONTQUCAGRJW.Session.GameOnly]
		internal static void DIBind(KLUMUBWDFVY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9566A40", Offset = "0x9565440", VA = "0x189566A40")]
		[RecRoom.NoEngine.Common.Preserve]
		public RoomSaveManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9566900", Offset = "0x9565300", VA = "0x189566900", Slot = "4")]
		[AsyncStateMachine(typeof(<GetLatestValidSaveForSubRoom>d__3))]
		public Task<SubRoomDataSaveDTO> GetLatestValidSaveForSubRoom(SubRoomDTO subRoom, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x95667C0", Offset = "0x95651C0", VA = "0x1895667C0", Slot = "5")]
		[AsyncStateMachine(typeof(<GetLatestPublishedSaveForSubRoom>d__4))]
		public Task<SubRoomDataSaveDTO> GetLatestPublishedSaveForSubRoom(SubRoomDTO subRoom, CancellationToken token)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class StoreItemQueryManager : IStoreItemQueryManager
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct <GetStoreItem>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public AsyncTaskMethodBuilder<BRRULFGEELR> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public UnifiedItemId unifiedItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			private TaskAwaiter<List<BRRULFGEELR>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x956ACD0", Offset = "0x95696D0", VA = "0x18956ACD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x956B000", Offset = "0x9569A00", VA = "0x18956B000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct <GetStoreItemIdsForCrossTypeSimilarEntities>d__37 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public AsyncTaskMethodBuilder<List<BRRULFGEELR>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public EntityType seedEntityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public string seedId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			private TaskAwaiter<List<UnifiedItemId>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			private TaskAwaiter<List<BRRULFGEELR>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x9569FD0", Offset = "0x95689D0", VA = "0x189569FD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x956A430", Offset = "0x9568E30", VA = "0x18956A430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct <GetStoreItemList>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public AsyncTaskMethodBuilder<IReadOnlyList<BRRULFGEELR>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public StoreItemListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			private TaskAwaiter<List<BRRULFGEELR>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x956A4A0", Offset = "0x9568EA0", VA = "0x18956A4A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x956AC60", Offset = "0x9569660", VA = "0x18956AC60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromCustomAvatarFeatured>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public AsyncTaskMethodBuilder<List<BRRULFGEELR>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private TaskAwaiter<List<CustomAvatarItem>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x956B070", Offset = "0x9569A70", VA = "0x18956B070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x956B390", Offset = "0x9569D90", VA = "0x18956B390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromCustomAvatarItemAlgorithmicList>d__29 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public AsyncTaskMethodBuilder<List<BRRULFGEELR>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public string carouselName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public Dictionary<string, string> rankingContextDictionary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			private TaskAwaiter<List<UnifiedItemId>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			private TaskAwaiter<List<BRRULFGEELR>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x956B400", Offset = "0x9569E00", VA = "0x18956B400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x956B860", Offset = "0x956A260", VA = "0x18956B860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromCustomAvatarItemCuratedList>d__31 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public AsyncTaskMethodBuilder<List<BRRULFGEELR>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public string carouselName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private TaskAwaiter<List<UnifiedItemId>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private TaskAwaiter<List<BRRULFGEELR>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x956B8D0", Offset = "0x956A2D0", VA = "0x18956B8D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x956BD20", Offset = "0x956A720", VA = "0x18956BD20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromCustomAvatarPortfolio>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public AsyncTaskMethodBuilder<List<BRRULFGEELR>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			private TaskAwaiter<IReadOnlyList<CustomAvatarItem>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<List<CustomAvatarItem>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x956BD90", Offset = "0x956A790", VA = "0x18956BD90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x956C340", Offset = "0x956AD40", VA = "0x18956C340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromPurchasableAlgorithmicList>d__27 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public AsyncTaskMethodBuilder<List<BRRULFGEELR>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public string carouselName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Dictionary<string, string> rankingContextDictionary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private TaskAwaiter<List<UnifiedItemId>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private TaskAwaiter<List<BRRULFGEELR>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x956C3B0", Offset = "0x956ADB0", VA = "0x18956C3B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x956C810", Offset = "0x956B210", VA = "0x18956C810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromSearch>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public AsyncTaskMethodBuilder<List<BRRULFGEELR>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public string searchQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			private TaskAwaiter<List<CustomAvatarItem>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x956C880", Offset = "0x956B280", VA = "0x18956C880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x956CC00", Offset = "0x956B600", VA = "0x18956CC00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromStorefront>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public AsyncTaskMethodBuilder<List<BRRULFGEELR>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public StoreItemListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			private TaskAwaiter<GiftDropStorefront> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			private TaskAwaiter<List<BRRULFGEELR>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x956CC70", Offset = "0x956B670", VA = "0x18956CC70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x956D340", Offset = "0x956BD40", VA = "0x18956D340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromUnifiedAlgorithmicList>d__33 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public AsyncTaskMethodBuilder<List<BRRULFGEELR>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public string carouselName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public Dictionary<string, string> rankingContextDictionary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			private TaskAwaiter<List<UnifiedItemId>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			private TaskAwaiter<List<BRRULFGEELR>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x956D3B0", Offset = "0x956BDB0", VA = "0x18956D3B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x956D810", Offset = "0x956C210", VA = "0x18956D810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromUnifiedCuratedList>d__35 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public AsyncTaskMethodBuilder<List<BRRULFGEELR>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public string carouselName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			private TaskAwaiter<List<UnifiedItemId>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			private TaskAwaiter<List<BRRULFGEELR>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x956D880", Offset = "0x956C280", VA = "0x18956D880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x956DCD0", Offset = "0x956C6D0", VA = "0x18956DCD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromWishlist>d__24 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public AsyncTaskMethodBuilder<List<BRRULFGEELR>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			private List<PurchasableItemId> <purchasableItemIds>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			private TaskAwaiter<List<ItemWishlistEntry>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			private TaskAwaiter<List<PurchasableGiftDrop>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			private TaskAwaiter<List<BRRULFGEELR>> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x956DD40", Offset = "0x956C740", VA = "0x18956DD40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x956E8C0", Offset = "0x956D2C0", VA = "0x18956E8C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private struct <GetUnifiedItemIdsForCrossTypeSimilarEntities>d__38 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public AsyncTaskMethodBuilder<List<UnifiedItemId>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public EntityType seedEntityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public string seedId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			private TaskAwaiter<AlgorithmicListDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x956E930", Offset = "0x956D330", VA = "0x18956E930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x956EDC0", Offset = "0x956D7C0", VA = "0x18956EDC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private struct <GetUnifiedItemIdsFromCustomAvatarItemAlgorithmicList>d__30 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public AsyncTaskMethodBuilder<List<UnifiedItemId>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public string servingEndpoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public Dictionary<string, string> rankingContextDictionary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			private TaskAwaiter<AlgorithmicListDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x956EE30", Offset = "0x956D830", VA = "0x18956EE30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x956F410", Offset = "0x956DE10", VA = "0x18956F410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private struct <GetUnifiedItemIdsFromCustomAvatarItemCuratedList>d__32 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			public AsyncTaskMethodBuilder<List<UnifiedItemId>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public string servingEndpoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			private TaskAwaiter<CuratedListDTO?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x956F480", Offset = "0x956DE80", VA = "0x18956F480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x956FA40", Offset = "0x956E440", VA = "0x18956FA40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private struct <GetUnifiedItemIdsFromPurchasableAlgorithmicList>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public AsyncTaskMethodBuilder<List<UnifiedItemId>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public string servingEndpoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public Dictionary<string, string> rankingContextDictionary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			private TaskAwaiter<AlgorithmicListDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x956FAB0", Offset = "0x956E4B0", VA = "0x18956FAB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x9570020", Offset = "0x956EA20", VA = "0x189570020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private struct <GetUnifiedItemIdsFromUnifiedAlgorithmicList>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public AsyncTaskMethodBuilder<List<UnifiedItemId>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			public string servingEndpoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public Dictionary<string, string> rankingContextDictionary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private TaskAwaiter<AlgorithmicListDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x9570090", Offset = "0x956EA90", VA = "0x189570090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x9570600", Offset = "0x956F000", VA = "0x189570600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private struct <GetUnifiedItemIdsFromUnifiedCuratedList>d__36 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			public AsyncTaskMethodBuilder<List<UnifiedItemId>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			public string servingEndpoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			private TaskAwaiter<CuratedListDTO?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x9570670", Offset = "0x956F070", VA = "0x189570670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x9570BC0", Offset = "0x956F5C0", VA = "0x189570BC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly XYNTEJINREW _statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly LWCSZZPQTXV _onlineRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private readonly IRRUIvNextStoreItemBridge _vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private readonly ZYZKVIZKJNR _outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private readonly PRJHEOOIRTF _purchaseManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly LNAABYIASSY _recNetCustomAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly QVTYUHUQZYK _storefrontManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly ZTRLAKMWPAP _recNetStorefronts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly XXRJFKPPUHA _storeItemFilteringManager;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9566AC0", Offset = "0x95654C0", VA = "0x189566AC0")]
		[ONTQUCAGRJW.Session.GameOnly]
		internal static void DIBind(KLUMUBWDFVY container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9569500", Offset = "0x9567F00", VA = "0x189569500")]
		[RecRoom.NoEngine.Common.Preserve]
		public StoreItemQueryManager([Inject(null)] XYNTEJINREW statsig, [Inject(null)] LWCSZZPQTXV onlineRestrictions, [Inject(null)] IRRUIvNextStoreItemBridge vNextStoreItemBridge, [Inject(null)] ZYZKVIZKJNR outfitManager, [Inject(null)] PRJHEOOIRTF purchaseManager, [Inject(null)] LNAABYIASSY recNetCustomAvatarItems, [Inject(null)] ZTRLAKMWPAP recNetStorefronts, [Inject(null)] XXRJFKPPUHA storeItemFilteringManager, [Inject(null)] QVTYUHUQZYK storefrontManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9566D70", Offset = "0x9565770", VA = "0x189566D70", Slot = "4")]
		[AsyncStateMachine(typeof(<GetStoreItemList>d__12))]
		public Task<IReadOnlyList<BRRULFGEELR>> GetStoreItemList(StoreItemListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9566B30", Offset = "0x9565530", VA = "0x189566B30")]
		public IReadOnlyList<BRRULFGEELR> FilterStoreItemList(StoreItemListQueryData queryData, IReadOnlyList<BRRULFGEELR> storeItems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x9566EB0", Offset = "0x95658B0", VA = "0x189566EB0", Slot = "5")]
		[AsyncStateMachine(typeof(<GetStoreItem>d__14))]
		public Task<BRRULFGEELR> GetStoreItem(UnifiedItemId unifiedItemId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9568730", Offset = "0x9567130", VA = "0x189568730", Slot = "6")]
		public bool IsOwnedByLocalPlayer(StorefrontGiftDrop giftDrop)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9569170", Offset = "0x9567B70", VA = "0x189569170")]
		private Task<List<BRRULFGEELR>> QueryStaticSource(StoreItemListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x95689E0", Offset = "0x95673E0", VA = "0x1895689E0")]
		private Task<List<BRRULFGEELR>> QueryDynamicSource(StoreItemListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9567990", Offset = "0x9566390", VA = "0x189567990")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromSearch>d__21))]
		private Task<List<BRRULFGEELR>> GetStoreItemsFromSearch(string searchQuery, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9567AA0", Offset = "0x95664A0", VA = "0x189567AA0")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromStorefront>d__22))]
		private Task<List<BRRULFGEELR>> GetStoreItemsFromStorefront(StoreItemListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9566FD0", Offset = "0x95659D0", VA = "0x189566FD0")]
		private Task<List<BRRULFGEELR>> GetStoreItemsFromAdCarousel(StoreItemListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9567EE0", Offset = "0x95668E0", VA = "0x189567EE0")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromWishlist>d__24))]
		private Task<List<BRRULFGEELR>> GetStoreItemsFromWishlist(int accountId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9567390", Offset = "0x9565D90", VA = "0x189567390")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromCustomAvatarFeatured>d__25))]
		private Task<List<BRRULFGEELR>> GetStoreItemsFromCustomAvatarFeatured()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9567720", Offset = "0x9566120", VA = "0x189567720")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromCustomAvatarPortfolio>d__26))]
		private Task<List<BRRULFGEELR>> GetStoreItemsFromCustomAvatarPortfolio(int accountId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9567830", Offset = "0x9566230", VA = "0x189567830")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromPurchasableAlgorithmicList>d__27))]
		private Task<List<BRRULFGEELR>> GetStoreItemsFromPurchasableAlgorithmicList(string carouselName, [CanBeNull] Dictionary<string, string> rankingContextDictionary, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x95683A0", Offset = "0x9566DA0", VA = "0x1895683A0")]
		[AsyncStateMachine(typeof(<GetUnifiedItemIdsFromPurchasableAlgorithmicList>d__28))]
		private Task<List<UnifiedItemId>> GetUnifiedItemIdsFromPurchasableAlgorithmicList(string servingEndpoint, [CanBeNull] Dictionary<string, string> rankingContextDictionary, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9567480", Offset = "0x9565E80", VA = "0x189567480")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromCustomAvatarItemAlgorithmicList>d__29))]
		private Task<List<BRRULFGEELR>> GetStoreItemsFromCustomAvatarItemAlgorithmicList(string carouselName, [CanBeNull] Dictionary<string, string> rankingContextDictionary, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9568150", Offset = "0x9566B50", VA = "0x189568150")]
		[AsyncStateMachine(typeof(<GetUnifiedItemIdsFromCustomAvatarItemAlgorithmicList>d__30))]
		private Task<List<UnifiedItemId>> GetUnifiedItemIdsFromCustomAvatarItemAlgorithmicList(string servingEndpoint, [CanBeNull] Dictionary<string, string> rankingContextDictionary, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x95675E0", Offset = "0x9565FE0", VA = "0x1895675E0")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromCustomAvatarItemCuratedList>d__31))]
		private Task<List<BRRULFGEELR>> GetStoreItemsFromCustomAvatarItemCuratedList(string carouselName, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9568290", Offset = "0x9566C90", VA = "0x189568290")]
		[AsyncStateMachine(typeof(<GetUnifiedItemIdsFromCustomAvatarItemCuratedList>d__32))]
		private Task<List<UnifiedItemId>> GetUnifiedItemIdsFromCustomAvatarItemCuratedList(string servingEndpoint, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9567BE0", Offset = "0x95665E0", VA = "0x189567BE0")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromUnifiedAlgorithmicList>d__33))]
		private Task<List<BRRULFGEELR>> GetStoreItemsFromUnifiedAlgorithmicList(string carouselName, [CanBeNull] Dictionary<string, string> rankingContextDictionary, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x95684E0", Offset = "0x9566EE0", VA = "0x1895684E0")]
		[AsyncStateMachine(typeof(<GetUnifiedItemIdsFromUnifiedAlgorithmicList>d__34))]
		private Task<List<UnifiedItemId>> GetUnifiedItemIdsFromUnifiedAlgorithmicList(string servingEndpoint, [CanBeNull] Dictionary<string, string> rankingContextDictionary, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9567D40", Offset = "0x9566740", VA = "0x189567D40")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromUnifiedCuratedList>d__35))]
		private Task<List<BRRULFGEELR>> GetStoreItemsFromUnifiedCuratedList(string carouselName, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9568620", Offset = "0x9567020", VA = "0x189568620")]
		[AsyncStateMachine(typeof(<GetUnifiedItemIdsFromUnifiedCuratedList>d__36))]
		private Task<List<UnifiedItemId>> GetUnifiedItemIdsFromUnifiedCuratedList(string servingEndpoint, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9566C20", Offset = "0x9565620", VA = "0x189566C20")]
		[AsyncStateMachine(typeof(<GetStoreItemIdsForCrossTypeSimilarEntities>d__37))]
		private Task<List<BRRULFGEELR>> GetStoreItemIdsForCrossTypeSimilarEntities(EntityType seedEntityType, string seedId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9568020", Offset = "0x9566A20", VA = "0x189568020")]
		[AsyncStateMachine(typeof(<GetUnifiedItemIdsForCrossTypeSimilarEntities>d__38))]
		private Task<List<UnifiedItemId>> GetUnifiedItemIdsForCrossTypeSimilarEntities(EntityType seedEntityType, string seedId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9567E80", Offset = "0x9566880", VA = "0x189567E80")]
		private Task<List<BRRULFGEELR>> GetStoreItemsFromUnifiedItemIds(IReadOnlyList<UnifiedItemId> unifiedItemIds, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x95687F0", Offset = "0x95671F0", VA = "0x1895687F0")]
		private static void PopulateRankingContextDictionary(AlgorithmicListDTO algorithmicList, Dictionary<string, string> rankingContextDictionary)
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
