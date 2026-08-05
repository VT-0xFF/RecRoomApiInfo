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
using RecNet.Discovery;
using RecNet.Lists;
using RecNet.Rooms;
using RecRoom.Analytics.Statsig;
using RecRoom.Avatars;
using RecRoom.Core;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82E9100", Offset = "0x82E7F00", VA = "0x1882E9100")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x82FE4B0", Offset = "0x82FD2B0", VA = "0x1882FE4B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2963E60", Offset = "0x2962C60", VA = "0x182963E60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecNet.Rooms
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class KMAAPDOCODL
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
			private ZAWMEKUKSAF <roomsClient>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0x82F1160", Offset = "0x82EFF60", VA = "0x1882F1160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x82F1740", Offset = "0x82F0540", VA = "0x1882F1740", Slot = "5")]
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
			private ZAWMEKUKSAF <roomsClient>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0x82F5150", Offset = "0x82F3F50", VA = "0x1882F5150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x82F5780", Offset = "0x82F4580", VA = "0x1882F5780", Slot = "5")]
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
			public ZAWMEKUKSAF roomsClient;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x82FD9C0", Offset = "0x82FC7C0", VA = "0x1882FD9C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x82FDDF0", Offset = "0x82FCBF0", VA = "0x1882FDDF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82E8EE0", Offset = "0x82E7CE0", VA = "0x1882E8EE0")]
		[AsyncStateMachine(typeof(<GetRoomValidity>d__0))]
		public static Task<List<bool>> TNNERNADZVO(List<SubRoomDataSaveDTO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82E8FF0", Offset = "0x82E7DF0", VA = "0x1882E8FF0")]
		[AsyncStateMachine(typeof(<GetFirstValidSave>d__1))]
		public static Task<SubRoomDataSaveDTO> VPYMPHQQPVW(List<SubRoomDataSaveDTO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82E8DD0", Offset = "0x82E7BD0", VA = "0x1882E8DD0")]
		[AsyncStateMachine(typeof(<StudioRoomHasAllUnityAssets>d__2))]
		private static Task<bool> PCMGDREHXDB(ZAWMEKUKSAF a, SubRoomDataSaveDTO b)
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
		private struct <GetAccountListForQueryData>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncTaskMethodBuilder<List<int>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public AccountListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public AccountQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private TaskAwaiter<List<int>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x82EE980", Offset = "0x82ED780", VA = "0x1882EE980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x82EEFD0", Offset = "0x82EDDD0", VA = "0x1882EEFD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct <GetAccountsFromCuratedList>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public AsyncTaskMethodBuilder<List<int>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AccountListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<CuratedListDTO?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x82EF040", Offset = "0x82EDE40", VA = "0x1882EF040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x82EF550", Offset = "0x82EE350", VA = "0x1882EF550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct <GetIsInfluencerAsync>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x82F17B0", Offset = "0x82F05B0", VA = "0x1882F17B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x82F19C0", Offset = "0x82F07C0", VA = "0x1882F19C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <GetProgressionAsync>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Progression> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<Progression> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x82F2AF0", Offset = "0x82F18F0", VA = "0x1882F2AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x82F2D00", Offset = "0x82F1B00", VA = "0x1882F2D00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct <GetReputationAsync>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public AsyncTaskMethodBuilder<Reputation> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private TaskAwaiter<Reputation> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x82F2D70", Offset = "0x82F1B70", VA = "0x1882F2D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x82F2F80", Offset = "0x82F1D80", VA = "0x1882F2F80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<Action> onlineFriendsChangedSubscribers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<Action> nearbyPlayersUpdatedSubscribers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private List<Action> playerPresenceUpdatedSubscribers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IRRUIvNextAccountBridge _vNextAccountBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly IRRUIvNextSocialBridge _vNextSocialBridge;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly List<int> ImmediateIds;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int LocalPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x82E4900", Offset = "0x82E3700", VA = "0x1882E4900", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x82E3600", Offset = "0x82E2400", VA = "0x1882E3600")]
		[FDNTPBIGLET.Root.GameOnly]
		internal static void DIBind(FDTRVDFSBYT container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82E4640", Offset = "0x82E3440", VA = "0x1882E4640")]
		[RecRoom.NoEngine.Common.Preserve]
		public AccountQueryManager([Inject(null)] IRRUIvNextAccountBridge vNextAccountBridge, [Inject(null)] IRRUIvNextSocialBridge vNextSocialBridge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82E3670", Offset = "0x82E2470", VA = "0x1882E3670", Slot = "5")]
		public Task<Account> GetAccountAsync(int accountId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82E36F0", Offset = "0x82E24F0", VA = "0x1882E36F0", Slot = "6")]
		[AsyncStateMachine(typeof(<GetAccountListForQueryData>d__10))]
		public Task<List<int>> GetAccountListForQueryData(AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82E44A0", Offset = "0x82E32A0", VA = "0x1882E44A0", Slot = "7")]
		public void SubscribeToAccountListUpdates(AccountListQueryData queryData, Action onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82E4540", Offset = "0x82E3340", VA = "0x1882E4540", Slot = "8")]
		public void UnsubscribeFromAccountListUpdates(AccountListQueryData queryData, Action onUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x82E38F0", Offset = "0x82E26F0", VA = "0x1882E38F0")]
		private List<int> GetFriendListForQueryData(AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82E3E60", Offset = "0x82E2C60", VA = "0x1882E3E60")]
		private List<int> GetRecentAccountsForQueryData(AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82E3B90", Offset = "0x82E2990", VA = "0x1882E3B90")]
		private List<int> GetNearbyAccountsForQueryData(AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82E3800", Offset = "0x82E2600", VA = "0x1882E3800")]
		[AsyncStateMachine(typeof(<GetAccountsFromCuratedList>d__17))]
		private Task<List<int>> GetAccountsFromCuratedList(AccountListQueryData queryData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82E40E0", Offset = "0x82E2EE0", VA = "0x1882E40E0")]
		private List<int> LimitResults(AccountListQueryData queryData, List<int> ids)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82E3D60", Offset = "0x82E2B60", VA = "0x1882E3D60", Slot = "9")]
		[AsyncStateMachine(typeof(<GetProgressionAsync>d__19))]
		public Task<Progression> GetProgressionAsync(int accountId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82E3FE0", Offset = "0x82E2DE0", VA = "0x1882E3FE0", Slot = "10")]
		[AsyncStateMachine(typeof(<GetReputationAsync>d__20))]
		public Task<Reputation> GetReputationAsync(int accountId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x82E3A90", Offset = "0x82E2890", VA = "0x1882E3A90", Slot = "11")]
		[AsyncStateMachine(typeof(<GetIsInfluencerAsync>d__21))]
		public Task<bool> GetIsInfluencerAsync(int accountId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82E42A0", Offset = "0x82E30A0", VA = "0x1882E42A0")]
		private void OnOnlineFriendsListUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82E41A0", Offset = "0x82E2FA0", VA = "0x1882E41A0")]
		private void OnNearbyPlayersUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82E43A0", Offset = "0x82E31A0", VA = "0x1882E43A0")]
		private void OnPlayerPresenceUpdated(int accountId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AppNavDataManager : IAppNavDataManager, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <CanWidgetBeShownInContext>d__53 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public string widgetId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private WidgetConfig <widget>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x82ED700", Offset = "0x82EC500", VA = "0x1882ED700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x82EE270", Offset = "0x82ED070", VA = "0x1882EE270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct <DoPeriodicContextCheck>d__61 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private int <oneMinMs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x82EE620", Offset = "0x82ED420", VA = "0x1882EE620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x82EE920", Offset = "0x82ED720", VA = "0x1882EE920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct <GetCuratedListSections>d__52 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public AsyncTaskMethodBuilder<IReadOnlyList<SectionDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string listName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private TaskAwaiter<CuratedListDTO?> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x82F0370", Offset = "0x82EF170", VA = "0x1882F0370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x82F06D0", Offset = "0x82EF4D0", VA = "0x1882F06D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct <GetDiscoverySection>d__50 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AsyncTaskMethodBuilder<List<SectionDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public PageSource source;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private List<SectionDTO> <sections>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private TaskAwaiter<List<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x82F0740", Offset = "0x82EF540", VA = "0x1882F0740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x82F0AA0", Offset = "0x82EF8A0", VA = "0x1882F0AA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct <GetDiscoverySection>d__51 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AsyncTaskMethodBuilder<List<SectionDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public string pageSourceName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private List<SectionDTO> <sections>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private TaskAwaiter<List<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x82F0B10", Offset = "0x82EF910", VA = "0x1882F0B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x82F0E40", Offset = "0x82EFC40", VA = "0x1882F0E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct <GetPortalPanelConfig>d__45 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AsyncTaskMethodBuilder<PortalPanelConfig> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private PortalPanelConfig <panelConfig>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private TaskAwaiter<List<SectionDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private List<SectionDTO>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private TaskAwaiter<PortalButtonGroupConfig> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x82F21C0", Offset = "0x82F0FC0", VA = "0x1882F21C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x82F2A80", Offset = "0x82F1880", VA = "0x1882F2A80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <GetWidgetListForPanel>d__42 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AsyncTaskMethodBuilder<List<string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public string panelId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private AppNavWidgetConfig <config>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private List<string> <widgetIds>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter<AppNavWidgetConfig> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private List<WidgetPanelConfig>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private List<string>.Enumerator <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private string <widgetId>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private TaskAwaiter<bool> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x82F6EC0", Offset = "0x82F5CC0", VA = "0x1882F6EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x82F7A50", Offset = "0x82F6850", VA = "0x1882F7A50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <GetWidgetPanelConfig>d__47 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<AppNavWidgetConfig> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private AppNavWidgetConfig <config>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TaskAwaiter<List<SectionDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private List<SectionDTO>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private TaskAwaiter<WidgetPanelConfig> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x82F7AC0", Offset = "0x82F68C0", VA = "0x1882F7AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x82F8510", Offset = "0x82F7310", VA = "0x1882F8510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private struct <GetWidgetPanelIds>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public AsyncTaskMethodBuilder<List<string>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private TaskAwaiter<AppNavWidgetConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x82F8580", Offset = "0x82F7380", VA = "0x1882F8580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x82F8980", Offset = "0x82F7780", VA = "0x1882F8980", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private struct <RefreshContextAsync>d__55 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private bool <contextChanged>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private TaskAwaiter<Commerce.RRPlusSignUpBonusDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x82FB9E0", Offset = "0x82FA7E0", VA = "0x1882FB9E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x82FC460", Offset = "0x82FB260", VA = "0x1882FC460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private struct <ResolvePortalSection>d__46 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public AsyncTaskMethodBuilder<PortalButtonGroupConfig> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public SectionDTO section;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private PortalButtonGroupConfig <sectionConfig>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x82FC4C0", Offset = "0x82FB2C0", VA = "0x1882FC4C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x82FCAB0", Offset = "0x82FB8B0", VA = "0x1882FCAB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private struct <ResolveWidgetPanel>d__48 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public AsyncTaskMethodBuilder<WidgetPanelConfig> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public SectionDTO dto;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private WidgetPanelConfig <panel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private TaskAwaiter<IReadOnlyList<SectionDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			private TaskAwaiter<List<SectionDTO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x82FCB20", Offset = "0x82FB920", VA = "0x1882FCB20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x82FD390", Offset = "0x82FC190", VA = "0x1882FD390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct <StartPeriodicContextCheck>d__60 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AppNavDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x82FD690", Offset = "0x82FC490", VA = "0x1882FD690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x82FD960", Offset = "0x82FC760", VA = "0x1882FD960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly IRRUIvNextUIDataBridge vNextDataBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly IRRUIvNextSocialBridge vNextSocialBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly UDXPTWWACGU roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly IRecRoomPlusDataManager rrPlusDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private PortalPanelConfig fallbackPortalPanelConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private AppNavWidgetConfig fallbackWidgetConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private PortalPanelConfig cachedPortalConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private AppNavWidgetConfig cachedConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private Dictionary<string, WidgetConfig> widgetConfigLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private HashSet<string> activeContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Dictionary<string, int> activeContextValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private float lastRoomJoinTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private CancellationTokenSource periodicContextCheckCancellationToken;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public DQHMEXLDKHB WidgetContextChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string> WidgetListForPanelChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x82E7E90", Offset = "0x82E6C90", VA = "0x1882E7E90", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x82E7F50", Offset = "0x82E6D50", VA = "0x1882E7F50", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82E6380", Offset = "0x82E5180", VA = "0x1882E6380")]
		[FDNTPBIGLET.Session.GameOnly]
		internal static void DIBind(FDTRVDFSBYT container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82E7B00", Offset = "0x82E6900", VA = "0x1882E7B00")]
		[RecRoom.NoEngine.Common.Preserve]
		public AppNavDataManager([Inject(null)] IRRUIvNextUIDataBridge vNextBridge, [Inject(null)] IRRUIvNextSocialBridge socialBridge, [Inject(null)] UDXPTWWACGU roomManager, [Inject(null)] IRecRoomPlusDataManager rrPlusDataManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82E63F0", Offset = "0x82E51F0", VA = "0x1882E63F0", Slot = "13")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x82E6E00", Offset = "0x82E5C00", VA = "0x1882E6E00", Slot = "7")]
		[AsyncStateMachine(typeof(<GetWidgetPanelIds>d__40))]
		public Task<List<string>> GetWidgetPanelIds(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82E7610", Offset = "0x82E6410", VA = "0x1882E7610", Slot = "8")]
		public bool TryGetWidgetPanelIcon(string panelId, [Out] string iconId, [Out] bool useProfilePicture)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82E6B80", Offset = "0x82E5980", VA = "0x1882E6B80", Slot = "9")]
		[AsyncStateMachine(typeof(<GetWidgetListForPanel>d__42))]
		public Task<List<string>> GetWidgetListForPanel(string panelId, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82E78A0", Offset = "0x82E66A0", VA = "0x1882E78A0", Slot = "10")]
		public bool TryGetWidgetTypeId(string widgetId, [Out] string widgetTypeId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82E77F0", Offset = "0x82E65F0", VA = "0x1882E77F0", Slot = "11")]
		public bool TryGetWidgetSourceData(string widgetId, [Out] WidgetSourceData sourceData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82E6A50", Offset = "0x82E5850", VA = "0x1882E6A50", Slot = "12")]
		[AsyncStateMachine(typeof(<GetPortalPanelConfig>d__45))]
		public Task<PortalPanelConfig> GetPortalPanelConfig(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x82E7180", Offset = "0x82E5F80", VA = "0x1882E7180")]
		[AsyncStateMachine(typeof(<ResolvePortalSection>d__46))]
		private Task<PortalButtonGroupConfig> ResolvePortalSection(SectionDTO section, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82E6CD0", Offset = "0x82E5AD0", VA = "0x1882E6CD0")]
		[AsyncStateMachine(typeof(<GetWidgetPanelConfig>d__47))]
		private Task<AppNavWidgetConfig> GetWidgetPanelConfig(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x82E72C0", Offset = "0x82E60C0", VA = "0x1882E72C0")]
		[AsyncStateMachine(typeof(<ResolveWidgetPanel>d__48))]
		private Task<WidgetPanelConfig> ResolveWidgetPanel(SectionDTO dto, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82E7400", Offset = "0x82E6200", VA = "0x1882E7400")]
		private WidgetConfig ResolveWidget(SectionDTO section)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82E6940", Offset = "0x82E5740", VA = "0x1882E6940")]
		[AsyncStateMachine(typeof(<GetDiscoverySection>d__50))]
		private Task<List<SectionDTO>> GetDiscoverySection(PageSource source, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82E6820", Offset = "0x82E5620", VA = "0x1882E6820")]
		[AsyncStateMachine(typeof(<GetDiscoverySection>d__51))]
		private Task<List<SectionDTO>> GetDiscoverySection(string pageSourceName, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82E6700", Offset = "0x82E5500", VA = "0x1882E6700")]
		[AsyncStateMachine(typeof(<GetCuratedListSections>d__52))]
		private Task<IReadOnlyList<SectionDTO>> GetCuratedListSections(string listName, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82E4940", Offset = "0x82E3740", VA = "0x1882E4940")]
		[AsyncStateMachine(typeof(<CanWidgetBeShownInContext>d__53))]
		private Task<bool> CanWidgetBeShownInContext(string widgetId, AppNavWidgetConfig appNavConfig)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x82E7120", Offset = "0x82E5F20", VA = "0x1882E7120")]
		private void RefreshContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82E7050", Offset = "0x82E5E50", VA = "0x1882E7050")]
		[AsyncStateMachine(typeof(<RefreshContextAsync>d__55))]
		private Task RefreshContextAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x82E7A20", Offset = "0x82E6820", VA = "0x1882E7A20")]
		private bool UpdateActiveContext(string context, bool currentState)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82E7960", Offset = "0x82E6760", VA = "0x1882E7960")]
		private bool UpdateActiveContextValue(string context, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xE72F70", Offset = "0xE71D70", VA = "0x180E72F70")]
		private void OnContextChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x82E6F10", Offset = "0x82E5D10", VA = "0x1882E6F10")]
		private void OnRoomEventSucceeded(RoomEvent roomEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x82E7540", Offset = "0x82E6340", VA = "0x1882E7540")]
		[AsyncStateMachine(typeof(<StartPeriodicContextCheck>d__60))]
		private Task StartPeriodicContextCheck()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x82E6610", Offset = "0x82E5410", VA = "0x1882E6610")]
		[AsyncStateMachine(typeof(<DoPeriodicContextCheck>d__61))]
		private Task DoPeriodicContextCheck(CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x82E5750", Offset = "0x82E4550", VA = "0x1882E5750")]
		private AppNavWidgetConfig CreateFallbackWidgetPanelConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x82E4B20", Offset = "0x82E3920", VA = "0x1882E4B20")]
		private WidgetCondition CreateCondition(string rawData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x82E4BB0", Offset = "0x82E39B0", VA = "0x1882E4BB0")]
		private PortalPanelConfig CreateFallbackPortalPanelConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x82E4A60", Offset = "0x82E3860", VA = "0x1882E4A60")]
		private PortalButtonConfig CreateButtonConfig(string name, string icon, string route, bool excludeJuniors = false, [Optional] string[] unsupportedPlatforms)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ClubQueryManager : IClubQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private class ClubhouseSummaryData : IEquatable<ClubhouseSummaryData>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public long ClubId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public long ClubhouseId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public int MemberCount;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			[CompilerGenerated]
			protected virtual Type EqualityContract
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x82E8CE0", Offset = "0x82E7AE0", VA = "0x1882E8CE0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x82E8C90", Offset = "0x82E7A90", VA = "0x1882E8C90")]
			public ClubhouseSummaryData(long clubId, long clubhouseId, int memberCount)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x82E8BA0", Offset = "0x82E79A0", VA = "0x1882E8BA0", Slot = "3")]
			[CompilerGenerated]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x82E8AB0", Offset = "0x82E78B0", VA = "0x1882E8AB0", Slot = "6")]
			[CompilerGenerated]
			protected virtual bool PrintMembers(StringBuilder builder)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x82E8870", Offset = "0x82E7670", VA = "0x1882E8870", Slot = "2")]
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x82E8660", Offset = "0x82E7460", VA = "0x1882E8660", Slot = "0")]
			[CompilerGenerated]
			public override bool Equals(object? obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x82E86F0", Offset = "0x82E74F0", VA = "0x1882E86F0", Slot = "7")]
			[CompilerGenerated]
			public virtual bool Equals(ClubhouseSummaryData? other)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private struct <GetClubhouseIdsForMyClubs>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public AsyncTaskMethodBuilder<List<long>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ClubQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public bool sortByClubMemberCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public int maxQuerySize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private List<Club> <myClubs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private TaskAwaiter<List<Club>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x82EFB60", Offset = "0x82EE960", VA = "0x1882EFB60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x82F0300", Offset = "0x82EF100", VA = "0x1882F0300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <PopulateClubhouseRoomSummaryData>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public ClubQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private TaskAwaiter<IReadOnlyList<ClubhouseRoomSummaryDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x82F8C80", Offset = "0x82F7A80", VA = "0x1882F8C80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x82F9150", Offset = "0x82F7F50", VA = "0x1882F9150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TBDOKCNPZCW onlineRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<Club> clubWithClubhouses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private Dictionary<long, ClubhouseSummaryData> clubhouseRoomSummaryLookup;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x82E8010", Offset = "0x82E6E10", VA = "0x1882E8010")]
		[FDNTPBIGLET.Session.GameOnly]
		internal static void DIBind(FDTRVDFSBYT container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x82E85A0", Offset = "0x82E73A0", VA = "0x1882E85A0")]
		[RecRoom.NoEngine.Common.Preserve]
		public ClubQueryManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x82E8180", Offset = "0x82E6F80", VA = "0x1882E8180", Slot = "4")]
		[AsyncStateMachine(typeof(<GetClubhouseIdsForMyClubs>d__6))]
		public Task<List<long>> GetClubhouseIdsForMyClubs(bool sortByClubMemberCount, int maxQuerySize, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x82E82D0", Offset = "0x82E70D0", VA = "0x1882E82D0")]
		[AsyncStateMachine(typeof(<PopulateClubhouseRoomSummaryData>d__7))]
		private Task PopulateClubhouseRoomSummaryData(CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x82E8080", Offset = "0x82E6E80", VA = "0x1882E8080")]
		private void FilterOutClubsWithoutClubhouse(List<Club> clubList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x82E83C0", Offset = "0x82E71C0", VA = "0x1882E83C0")]
		private int SortClubsByMemberCount(Club lhs, Club rhs)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class OutfitManager : IOutfitDataManager
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <GetLocalPlayerOutfits>d__15 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<List<WTXRZVUFAOZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public OutfitManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public int maxResultCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public bool publicOnly;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public bool excludeCurrentlyEquipped;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter<IReadOnlyDictionary<int, OutfitDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x82F1A30", Offset = "0x82F0830", VA = "0x1882F1A30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x82F2150", Offset = "0x82F0F50", VA = "0x1882F2150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private struct <GetTotalSavedOutfitCount>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public OutfitManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private TaskAwaiter<IReadOnlyDictionary<int, OutfitDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x82F6680", Offset = "0x82F5480", VA = "0x1882F6680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x82F68A0", Offset = "0x82F56A0", VA = "0x1882F68A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <LoadOutfitAsync>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public OutfitManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public WTXRZVUFAOZ outfitData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x82F89F0", Offset = "0x82F77F0", VA = "0x1882F89F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x82F8C20", Offset = "0x82F7A20", VA = "0x1882F8C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private struct <SaveOutfitAsync>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public OutfitManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public int slotIdx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x82FD400", Offset = "0x82FC200", VA = "0x1882FD400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x82FD630", Offset = "0x82FC430", VA = "0x1882FD630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly IRRUIvNextUIDataBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly SZFXHMPWSLL recNetOutfits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly WFOMRPEQSIK avatarDataManager;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public DQHMEXLDKHB LocalPlayerOutfitChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public DQHMEXLDKHB OutfitsUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x82E9180", Offset = "0x82E7F80", VA = "0x1882E9180")]
		[FDNTPBIGLET.Session.GameOnly]
		internal static void DIBind(FDTRVDFSBYT container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x82E9B00", Offset = "0x82E8900", VA = "0x1882E9B00")]
		[RecRoom.NoEngine.Common.Preserve]
		public OutfitManager([Inject(null)] IRRUIvNextUIDataBridge vNextBridge, [Inject(null)] SZFXHMPWSLL recNetOutfits, [Inject(null)] WFOMRPEQSIK avatarDataManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x82E91F0", Offset = "0x82E7FF0", VA = "0x1882E91F0", Slot = "1")]
		~OutfitManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x82E9500", Offset = "0x82E8300", VA = "0x1882E9500", Slot = "6")]
		[AsyncStateMachine(typeof(<GetTotalSavedOutfitCount>d__14))]
		public Task<int> GetTotalSavedOutfitCount(CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x82E93E0", Offset = "0x82E81E0", VA = "0x1882E93E0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetLocalPlayerOutfits>d__15))]
		public Task<List<WTXRZVUFAOZ>> GetLocalPlayerOutfits(CancellationToken token, bool publicOnly = false, int maxResultCount = -1, bool excludeCurrentlyEquipped = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x82E95F0", Offset = "0x82E83F0", VA = "0x1882E95F0", Slot = "8")]
		[AsyncStateMachine(typeof(<LoadOutfitAsync>d__17))]
		public Task LoadOutfitAsync(WTXRZVUFAOZ outfitData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x82E9A20", Offset = "0x82E8820", VA = "0x1882E9A20", Slot = "9")]
		[AsyncStateMachine(typeof(<SaveOutfitAsync>d__18))]
		public Task SaveOutfitAsync(int slotIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x82E9870", Offset = "0x82E8670", VA = "0x1882E9870")]
		private void OnLocalPlayerCreated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x10903B0", Offset = "0x108F1B0", VA = "0x1810903B0")]
		private void OnLocalPlayerOutfitLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x82E9940", Offset = "0x82E8740", VA = "0x1882E9940")]
		private void OnLocalPlayerDestroying()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x82E9A00", Offset = "0x82E8800", VA = "0x1882E9A00")]
		private void OnOutfitUpdated(int accountId, int slot, OutfitDTO? outfit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x82E96E0", Offset = "0x82E84E0", VA = "0x1882E96E0")]
		private bool Matches(WTXRZVUFAOZ lhs, WTXRZVUFAOZ rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x82E9840", Offset = "0x82E8640", VA = "0x1882E9840")]
		private bool MeetsDesiredPermissionLevel(OutfitDTO outfitDto, bool publicOnly)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RecRoomPlusDataManager : IRecRoomPlusDataManager
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct <CheckFreeItemSignOnBonusEligibility>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public AsyncTaskMethodBuilder<Commerce.RRPlusSignUpBonusDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public RecRoomPlusDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private TaskAwaiter<Commerce.RRPlusSignUpBonusDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x82EE2E0", Offset = "0x82ED0E0", VA = "0x1882EE2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x82EE5B0", Offset = "0x82ED3B0", VA = "0x1882EE5B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private struct <GetBenefits>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public AsyncTaskMethodBuilder<List<RecRoomPlusBenefitData>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public RecRoomPlusDataManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private TaskAwaiter<List<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x82EF5C0", Offset = "0x82EE3C0", VA = "0x1882EF5C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x82EFAF0", Offset = "0x82EE8F0", VA = "0x1882EFAF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private struct <GetDiscoverySection>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public AsyncTaskMethodBuilder<List<SectionDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public PageSource source;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private List<SectionDTO> <sections>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<List<SectionDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x82F0EB0", Offset = "0x82EFCB0", VA = "0x1882F0EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x82F10F0", Offset = "0x82EFEF0", VA = "0x1882F10F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private IRRUIvNextUIDataBridge dataBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HasRecRoomPlusSubscription
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x82EA100", Offset = "0x82E8F00", VA = "0x1882EA100", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x82E9E70", Offset = "0x82E8C70", VA = "0x1882E9E70")]
		[FDNTPBIGLET.Session.GameOnly]
		internal static void DIBind(FDTRVDFSBYT container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xABFA30", Offset = "0xABE830", VA = "0x180ABFA30")]
		[RecRoom.NoEngine.Common.Preserve]
		public RecRoomPlusDataManager([Inject(null)] IRRUIvNextUIDataBridge dataBridge, [Inject(null)] IRRUIvNextStoreItemBridge storeBridge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x82E9EE0", Offset = "0x82E8CE0", VA = "0x1882E9EE0", Slot = "5")]
		[AsyncStateMachine(typeof(<GetBenefits>d__6))]
		public Task<List<RecRoomPlusBenefitData>> GetBenefits(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x82E9D60", Offset = "0x82E8B60", VA = "0x1882E9D60", Slot = "6")]
		[AsyncStateMachine(typeof(<CheckFreeItemSignOnBonusEligibility>d__7))]
		public Task<Commerce.RRPlusSignUpBonusDTO> CheckFreeItemSignOnBonusEligibility(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x82E9FF0", Offset = "0x82E8DF0", VA = "0x1882E9FF0")]
		[AsyncStateMachine(typeof(<GetDiscoverySection>d__8))]
		private Task<List<SectionDTO>> GetDiscoverySection(PageSource source, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class RoomieQueryManager : IRoomieQueryManager
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private struct <GetUserFacts>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public AsyncTaskMethodBuilder<RoomieUserFactQueryData.IContext> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public RoomieUserFactQueryData.IContext roomieUserFactQueryDataContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public RoomieQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public RoomieUserFactQueryData roomieUserFactQueryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private RoomieUserFactQueryData.Context <context>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private RoomieUserFactQueryData.Context <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private TaskAwaiter<RoomieUserFactsDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x82F6910", Offset = "0x82F5710", VA = "0x1882F6910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x82F6E50", Offset = "0x82F5C50", VA = "0x1882F6E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly ERHONSLNWDT _recNetAI;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x82ED530", Offset = "0x82EC330", VA = "0x1882ED530")]
		[FDNTPBIGLET.Root.GameOnly]
		internal static void DIBind(FDTRVDFSBYT container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		[RecRoom.NoEngine.Common.Preserve]
		public RoomieQueryManager([Inject(null)] ERHONSLNWDT recNetAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x82ED5A0", Offset = "0x82EC3A0", VA = "0x1882ED5A0", Slot = "4")]
		[AsyncStateMachine(typeof(<GetUserFacts>d__3))]
		public Task<RoomieUserFactQueryData.IContext> GetUserFacts(RoomieUserFactQueryData roomieUserFactQueryData, [Optional] RoomieUserFactQueryData.IContext roomieUserFactQueryDataContext, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x82ED150", Offset = "0x82EBF50", VA = "0x1882ED150")]
		private void ApplySearchQueryFilter(RoomieUserFactQueryData queryData, RoomieUserFactQueryData.Context context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x82ED2D0", Offset = "0x82EC0D0", VA = "0x1882ED2D0")]
		private void ApplySort(RoomieUserFactQueryData queryData, RoomieUserFactQueryData.Context context)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class RoomLoadManager : IRoomLoadManager
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly BUGFICUUZII activitySwitcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private readonly UDXPTWWACGU roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[CompilerGenerated]
		private Action RoomLoadActiveChanged;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool RoomLoadActive
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FD0", Offset = "0xABFDD0", VA = "0x180AC0FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x82EA180", Offset = "0x82E8F80", VA = "0x1882EA180")]
		[FDNTPBIGLET.Session.GameOnly]
		internal static void DIBind(FDTRVDFSBYT container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xABFA30", Offset = "0xABE830", VA = "0x180ABFA30")]
		[RecRoom.NoEngine.Common.Preserve]
		public RoomLoadManager([Inject(null)] BUGFICUUZII activitySwitcher, [Inject(null)] UDXPTWWACGU roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x82EA1F0", Offset = "0x82E8FF0", VA = "0x1882EA1F0", Slot = "4")]
		public void GoToDorm()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x82EA330", Offset = "0x82E9130", VA = "0x1882EA330", Slot = "5")]
		public void GoToWellKnownRoom(FXTCJGHNAXH room, [Optional] Action<JoinRoomResult> onResponseCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x82EA4A0", Offset = "0x82E92A0", VA = "0x1882EA4A0", Slot = "6")]
		public bool HasSufficientVersionToLoadRoom(RoomDTO room)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x82EA4F0", Offset = "0x82E92F0", VA = "0x1882EA4F0", Slot = "7")]
		public void TryJoinRoom(RoomDetailsDTO roomDetails, SubRoomDTO subRoom, bool privateInstance, LoadSceneSourceData loadSourceData, [Optional] SubRoomDataSaveDTO versionTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x82EA4D0", Offset = "0x82E92D0", VA = "0x1882EA4D0")]
		private void OnRunJoinRoomResponseCallback(JoinRoomResult result)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class RoomQueryManager : IRoomQueryManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		internal class DisplayedRoomListData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public string ListId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public HashSet<long> DisplayRoomIds;

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x82E8D30", Offset = "0x82E7B30", VA = "0x1882E8D30")]
			public DisplayedRoomListData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass29_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public List<long> idList;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public Dictionary<long, RoomDTO> roomsDictionary;

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public <>c__DisplayClass29_0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private struct <GetRoom>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public AsyncTaskMethodBuilder<RoomDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private TaskAwaiter<RoomDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x82F4EC0", Offset = "0x82F3CC0", VA = "0x1882F4EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x82F50E0", Offset = "0x82F3EE0", VA = "0x1882F50E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private struct <GetRoomDetails>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public AsyncTaskMethodBuilder<RoomDetailsDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x82F2FF0", Offset = "0x82F1DF0", VA = "0x1882F2FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x82F3220", Offset = "0x82F2020", VA = "0x1882F3220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct <GetRoomList>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public Func<bool> waitToContinueFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private List<RoomDTO> <roomList>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private TaskAwaiter<List<RoomDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private object <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x82F3290", Offset = "0x82F2090", VA = "0x1882F3290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x82F4E50", Offset = "0x82F3C50", VA = "0x1882F4E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct <GetRoomsFromAlgorithmicListDto>d__30 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public AlgorithmicListDTO algorithmicList;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public int skip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public int take;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public Dictionary<long, string> rankingContextMap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x82F57F0", Offset = "0x82F45F0", VA = "0x1882F57F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x82F5F10", Offset = "0x82F4D10", VA = "0x1882F5F10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private struct <GetRoomsFromIdList>d__29 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public List<long> idList;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private <>c__DisplayClass29_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x82F5F80", Offset = "0x82F4D80", VA = "0x1882F5F80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x82F6610", Offset = "0x82F5410", VA = "0x1882F6610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private struct <QueryClubhouseSource>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			private Task<IReadOnlyList<RoomDTO>> <myOwnedRoomsTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			private Task<IReadOnlyList<RoomDTO>> <clubhouseTemplateRoomsTask>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>[]> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x82F91B0", Offset = "0x82F7FB0", VA = "0x1882F91B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x82F98C0", Offset = "0x82F86C0", VA = "0x1882F98C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private struct <QueryDynamicAlgorithmicSource>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private TaskAwaiter<AlgorithmicListDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private TaskAwaiter<List<RoomDTO>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			private TaskAwaiter<IReadOnlyList<RoomRecommendationGroupDTO>> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			private Task<RoomDTO> <recCenterTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private Task<IReadOnlyList<RoomDTO>> <recentRoomsTask>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private Task<IReadOnlyList<RoomDTO>> <creatorsISubscribeToRoomTask>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private TaskAwaiter <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private TaskAwaiter<RoomRecommendationGroupDTO> <>u__6;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x82F9930", Offset = "0x82F8730", VA = "0x1882F9930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x82FB970", Offset = "0x82FA770", VA = "0x1882FB970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private struct <QueryKeepsakeRoomSource>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private TaskAwaiter<List<RoomDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8308FA0", Offset = "0x8307DA0", VA = "0x188308FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8309430", Offset = "0x8308230", VA = "0x188309430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private struct <QueryMySource>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private TaskAwaiter<List<long>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private TaskAwaiter<List<RoomDTO>> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x83094A0", Offset = "0x83082A0", VA = "0x1883094A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x830A060", Offset = "0x8308E60", VA = "0x18830A060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct <QueryPlayerSource>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x830A0D0", Offset = "0x8308ED0", VA = "0x18830A0D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x830AD60", Offset = "0x8309B60", VA = "0x18830AD60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct <QueryRecRoomCreatorAcademySource>d__27 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private TaskAwaiter<List<RoomDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x830ADD0", Offset = "0x8309BD0", VA = "0x18830ADD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x830B1A0", Offset = "0x8309FA0", VA = "0x18830B1A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private struct <QueryRoomsByCreatorsISubscribeTo>d__31 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public AsyncTaskMethodBuilder<IReadOnlyList<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public int skip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public int take;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private TaskAwaiter<List<int>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x830B210", Offset = "0x830A010", VA = "0x18830B210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x830B5E0", Offset = "0x830A3E0", VA = "0x18830B5E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private struct <QueryStaticListSource>d__24 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public AsyncTaskMethodBuilder<List<RoomDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public RoomListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public RoomQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			private Task<FeaturedRoomGroupDTO> <queryTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			private TaskAwaiter<FeaturedRoomGroupDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			private TaskAwaiter<List<RoomDTO>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			private TaskAwaiter<CuratedListDTO> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			private TaskAwaiter<IReadOnlyList<RoomDTO>> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x830B650", Offset = "0x830A450", VA = "0x18830B650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x830D090", Offset = "0x830BE90", VA = "0x18830D090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private DINTWZBUUTH statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TBDOKCNPZCW onlineRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private IClubQueryManager clubQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private YEADHGPVUSS gameConfigsProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private VWCXBUJVYSO keepsakeManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private DUNZSOMMSPV progressionEventsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IRRUIvNextUIDataBridge vNextDataBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private Dictionary<string, List<DisplayedRoomListData>> deduplicationTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private HashSet<long> dedupeExceptionRoomIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private StringBuilder builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private Dictionary<long, int> ccuCountLookup;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x82EA830", Offset = "0x82E9630", VA = "0x1882EA830")]
		[FDNTPBIGLET.Session.GameOnly]
		internal static void DIBind(FDTRVDFSBYT container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x82ECFE0", Offset = "0x82EBDE0", VA = "0x1882ECFE0")]
		[RecRoom.NoEngine.Common.Preserve]
		public RoomQueryManager([Inject(null)] DINTWZBUUTH statsig, [Inject(null)] TBDOKCNPZCW onlineRestrictions, [Inject(null)] IClubQueryManager clubQueryManager, [Inject(null)] YEADHGPVUSS gameConfigsProvider, [Inject(null)] IRRUIvNextUIDataBridge vNextBridge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x82EB570", Offset = "0x82EA370", VA = "0x1882EB570", Slot = "4")]
		[AsyncStateMachine(typeof(<GetRoomList>d__18))]
		public Task<List<RoomDTO>> GetRoomList(RoomListQueryData queryData, CancellationToken token, [Optional] Func<bool> waitToContinueFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x82EB6D0", Offset = "0x82EA4D0", VA = "0x1882EB6D0", Slot = "5")]
		[AsyncStateMachine(typeof(<GetRoom>d__19))]
		public Task<RoomDTO> GetRoom(long roomId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x82EB440", Offset = "0x82EA240", VA = "0x1882EB440", Slot = "6")]
		[AsyncStateMachine(typeof(<GetRoomDetails>d__20))]
		public Task<RoomDetailsDTO> GetRoomDetails(long roomId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x82ECF70", Offset = "0x82EBD70", VA = "0x1882ECF70", Slot = "7")]
		public bool TryGetCCUCount(long roomId, [Out] int ccuCount)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x82EC260", Offset = "0x82EB060", VA = "0x1882EC260")]
		[AsyncStateMachine(typeof(<QueryMySource>d__22))]
		private Task<List<RoomDTO>> QueryMySource(RoomListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x82EC3B0", Offset = "0x82EB1B0", VA = "0x1882EC3B0")]
		[AsyncStateMachine(typeof(<QueryPlayerSource>d__23))]
		private Task<List<RoomDTO>> QueryPlayerSource(RoomListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x82EC770", Offset = "0x82EB570", VA = "0x1882EC770")]
		[AsyncStateMachine(typeof(<QueryStaticListSource>d__24))]
		private Task<List<RoomDTO>> QueryStaticListSource(RoomListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x82EBFC0", Offset = "0x82EADC0", VA = "0x1882EBFC0")]
		[AsyncStateMachine(typeof(<QueryDynamicAlgorithmicSource>d__25))]
		private Task<List<RoomDTO>> QueryDynamicAlgorithmicSource(RoomListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x82EBE80", Offset = "0x82EAC80", VA = "0x1882EBE80")]
		[AsyncStateMachine(typeof(<QueryClubhouseSource>d__26))]
		private Task<List<RoomDTO>> QueryClubhouseSource(RoomListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x82EC4F0", Offset = "0x82EB2F0", VA = "0x1882EC4F0")]
		[AsyncStateMachine(typeof(<QueryRecRoomCreatorAcademySource>d__27))]
		private Task<List<RoomDTO>> QueryRecRoomCreatorAcademySource(RoomListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x82EC120", Offset = "0x82EAF20", VA = "0x1882EC120")]
		[AsyncStateMachine(typeof(<QueryKeepsakeRoomSource>d__28))]
		private Task<List<RoomDTO>> QueryKeepsakeRoomSource(RoomListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x82EB960", Offset = "0x82EA760", VA = "0x1882EB960")]
		[AsyncStateMachine(typeof(<GetRoomsFromIdList>d__29))]
		private Task<List<RoomDTO>> GetRoomsFromIdList(List<long> idList, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x82EB800", Offset = "0x82EA600", VA = "0x1882EB800")]
		[AsyncStateMachine(typeof(<GetRoomsFromAlgorithmicListDto>d__30))]
		private Task<List<RoomDTO>> GetRoomsFromAlgorithmicListDto(AlgorithmicListDTO algorithmicList, int skip, int take, Dictionary<long, string> rankingContextMap, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x82EC630", Offset = "0x82EB430", VA = "0x1882EC630")]
		[AsyncStateMachine(typeof(<QueryRoomsByCreatorsISubscribeTo>d__31))]
		private Task<IReadOnlyList<RoomDTO>> QueryRoomsByCreatorsISubscribeTo(int skip, int take, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x82EAB10", Offset = "0x82E9910", VA = "0x1882EAB10")]
		private void FilterByLocalPlayerCanJoin(List<RoomDTO> roomList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x82EA7D0", Offset = "0x82E95D0", VA = "0x1882EA7D0")]
		private bool CanLocalPlayerJoin(RoomDTO room)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x82EA8A0", Offset = "0x82E96A0", VA = "0x1882EA8A0")]
		private void FilterByAccessibility(List<RoomDTO> roomList, Accessibility access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x82EB070", Offset = "0x82E9E70", VA = "0x1882EB070")]
		private void FilterOutIfMatchesAccessibility(List<RoomDTO> roomList, Accessibility access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x82EB120", Offset = "0x82E9F20", VA = "0x1882EB120")]
		private void FilterOutUnapprovedRoomsIfNeeded(List<RoomDTO> roomList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x82EBB70", Offset = "0x82EA970", VA = "0x1882EBB70")]
		private bool IsRoomApproved(RoomDTO room)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x18F9880", Offset = "0x18F8680", VA = "0x1818F9880")]
		private bool IsExcludedFromLists(RoomDTO room)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x82EAA60", Offset = "0x82E9860", VA = "0x1882EAA60")]
		private void FilterByDorm(List<RoomDTO> roomList, bool isDorm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x82EAEF0", Offset = "0x82E9CF0", VA = "0x1882EAEF0")]
		private void FilterOutDormOrWellKnownRooms(List<RoomDTO> roomList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x82EBA80", Offset = "0x82EA880", VA = "0x1882EBA80")]
		private bool IsDormOrWellKnownRoom(RoomDTO room)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x82EABF0", Offset = "0x82E99F0", VA = "0x1882EABF0")]
		private void FilterByPlayerCreatedRoomOwnership(List<RoomDTO> roomList, int accountId, RoomListQueryData.PlayerCreatedRoomsFilterType filterType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x82EA950", Offset = "0x82E9750", VA = "0x1882EA950")]
		private void FilterByClonable(List<RoomDTO> roomList, bool isClonable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x82EAD90", Offset = "0x82E9B90", VA = "0x1882EAD90")]
		private void FilterByRoomCapacity(List<RoomDTO> roomList, (int, int)? capacityBounds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x82EC8C0", Offset = "0x82EB6C0", VA = "0x1882EC8C0")]
		private string RemoveAnyDuplicates(List<RoomDTO> roomList, string deduplicationKey, string listId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x82EBBB0", Offset = "0x82EA9B0", VA = "0x1882EBBB0")]
		private void PopulateDeduplicationExceptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x82ECD50", Offset = "0x82EBB50", VA = "0x1882ECD50")]
		private void ShortenResultsToMaxDisplayCount(List<RoomDTO> roomList, int maxDisplayCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x82ECDC0", Offset = "0x82EBBC0", VA = "0x1882ECDC0")]
		private int SortRoomsByRoom2ExperimentOrder(RoomDTO lhs, RoomDTO rhs)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x82EB1D0", Offset = "0x82E9FD0", VA = "0x1882EB1D0")]
		private int GetRoom2ExperimentPrioritization(RoomDTO room)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x82ECE30", Offset = "0x82EBC30", VA = "0x1882ECE30")]
		private void TryCacheDIObjects()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class RoomSaveManager : IRoomSaveManager
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct <GetLatestPublishedSaveForSubRoom>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public AsyncTaskMethodBuilder<SubRoomDataSaveDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public RoomSaveManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public SubRoomDTO subRoom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			private TaskAwaiter<SubRoomDataSavePagedResultsDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8301980", Offset = "0x8300780", VA = "0x188301980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8301E70", Offset = "0x8300C70", VA = "0x188301E70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct <GetLatestValidSaveForSubRoom>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public AsyncTaskMethodBuilder<SubRoomDataSaveDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public RoomSaveManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public SubRoomDTO subRoom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			private TaskAwaiter<SubRoomDataSavePagedResultsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			private TaskAwaiter<SubRoomDataSaveDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8301EE0", Offset = "0x8300CE0", VA = "0x188301EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8302300", Offset = "0x8301100", VA = "0x188302300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private List<SubRoomDataSaveDTO> subRoomSaves;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x82FEAB0", Offset = "0x82FD8B0", VA = "0x1882FEAB0")]
		[FDNTPBIGLET.Session.GameOnly]
		internal static void DIBind(FDTRVDFSBYT container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x82FEDA0", Offset = "0x82FDBA0", VA = "0x1882FEDA0")]
		[RecRoom.NoEngine.Common.Preserve]
		public RoomSaveManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x82FEC60", Offset = "0x82FDA60", VA = "0x1882FEC60", Slot = "4")]
		[AsyncStateMachine(typeof(<GetLatestValidSaveForSubRoom>d__3))]
		public Task<SubRoomDataSaveDTO> GetLatestValidSaveForSubRoom(SubRoomDTO subRoom, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x82FEB20", Offset = "0x82FD920", VA = "0x1882FEB20", Slot = "5")]
		[AsyncStateMachine(typeof(<GetLatestPublishedSaveForSubRoom>d__4))]
		public Task<SubRoomDataSaveDTO> GetLatestPublishedSaveForSubRoom(SubRoomDTO subRoom, CancellationToken token)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class StoreItemQueryManager : IStoreItemQueryManager
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct <GetStoreItem>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public AsyncTaskMethodBuilder<NSVNCQQULFO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public UnifiedItemId unifiedItemId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			private TaskAwaiter<List<NSVNCQQULFO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8303080", Offset = "0x8301E80", VA = "0x188303080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x83033B0", Offset = "0x83021B0", VA = "0x1883033B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct <GetStoreItemIdsForCrossTypeSimilarEntities>d__37 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public AsyncTaskMethodBuilder<List<NSVNCQQULFO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public EntityType seedEntityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public string seedId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private TaskAwaiter<List<UnifiedItemId>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private TaskAwaiter<List<NSVNCQQULFO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8302370", Offset = "0x8301170", VA = "0x188302370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x83027D0", Offset = "0x83015D0", VA = "0x1883027D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct <GetStoreItemList>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public AsyncTaskMethodBuilder<IReadOnlyList<NSVNCQQULFO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public StoreItemListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			private TaskAwaiter<List<NSVNCQQULFO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8302840", Offset = "0x8301640", VA = "0x188302840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8303010", Offset = "0x8301E10", VA = "0x188303010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromCustomAvatarFeatured>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public AsyncTaskMethodBuilder<List<NSVNCQQULFO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			private TaskAwaiter<List<CustomAvatarItem>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8303420", Offset = "0x8302220", VA = "0x188303420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x8303730", Offset = "0x8302530", VA = "0x188303730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromCustomAvatarItemAlgorithmicList>d__29 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public AsyncTaskMethodBuilder<List<NSVNCQQULFO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public string carouselName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public Dictionary<string, string> rankingContextDictionary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private TaskAwaiter<List<UnifiedItemId>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			private TaskAwaiter<List<NSVNCQQULFO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x83037A0", Offset = "0x83025A0", VA = "0x1883037A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8303C00", Offset = "0x8302A00", VA = "0x188303C00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromCustomAvatarItemCuratedList>d__31 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public AsyncTaskMethodBuilder<List<NSVNCQQULFO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public string carouselName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private TaskAwaiter<List<UnifiedItemId>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			private TaskAwaiter<List<NSVNCQQULFO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8303C70", Offset = "0x8302A70", VA = "0x188303C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x83040C0", Offset = "0x8302EC0", VA = "0x1883040C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromCustomAvatarPortfolio>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public AsyncTaskMethodBuilder<List<NSVNCQQULFO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			private TaskAwaiter<IReadOnlyList<CustomAvatarItem>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			private TaskAwaiter<List<CustomAvatarItem>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8304130", Offset = "0x8302F30", VA = "0x188304130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x83046D0", Offset = "0x83034D0", VA = "0x1883046D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromPurchasableAlgorithmicList>d__27 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public AsyncTaskMethodBuilder<List<NSVNCQQULFO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public string carouselName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public Dictionary<string, string> rankingContextDictionary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			private TaskAwaiter<List<UnifiedItemId>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			private TaskAwaiter<List<NSVNCQQULFO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8304740", Offset = "0x8303540", VA = "0x188304740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8304BA0", Offset = "0x83039A0", VA = "0x188304BA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromSearch>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public AsyncTaskMethodBuilder<List<NSVNCQQULFO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public string searchQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			private TaskAwaiter<List<CustomAvatarItem>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8304C10", Offset = "0x8303A10", VA = "0x188304C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8304F80", Offset = "0x8303D80", VA = "0x188304F80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromStorefront>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public AsyncTaskMethodBuilder<List<NSVNCQQULFO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public StoreItemListQueryData queryData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private TaskAwaiter<GiftDropStorefront> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private TaskAwaiter<List<NSVNCQQULFO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8304FF0", Offset = "0x8303DF0", VA = "0x188304FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x83056C0", Offset = "0x83044C0", VA = "0x1883056C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromUnifiedAlgorithmicList>d__33 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public AsyncTaskMethodBuilder<List<NSVNCQQULFO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public string carouselName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public Dictionary<string, string> rankingContextDictionary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			private TaskAwaiter<List<UnifiedItemId>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			private TaskAwaiter<List<NSVNCQQULFO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8305730", Offset = "0x8304530", VA = "0x188305730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8305B90", Offset = "0x8304990", VA = "0x188305B90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromUnifiedCuratedList>d__35 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public AsyncTaskMethodBuilder<List<NSVNCQQULFO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public string carouselName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			private TaskAwaiter<List<UnifiedItemId>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private TaskAwaiter<List<NSVNCQQULFO>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8305C00", Offset = "0x8304A00", VA = "0x188305C00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8306050", Offset = "0x8304E50", VA = "0x188306050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private struct <GetStoreItemsFromWishlist>d__24 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public AsyncTaskMethodBuilder<List<NSVNCQQULFO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public StoreItemQueryManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			private List<int> <purchasableItemIds>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			private TaskAwaiter<List<ItemWishlistEntry>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private TaskAwaiter<List<PurchasableGiftDrop>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			private TaskAwaiter<List<NSVNCQQULFO>> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x83060C0", Offset = "0x8304EC0", VA = "0x1883060C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x8306C20", Offset = "0x8305A20", VA = "0x188306C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct <GetUnifiedItemIdsForCrossTypeSimilarEntities>d__38 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public AsyncTaskMethodBuilder<List<UnifiedItemId>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public EntityType seedEntityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public string seedId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			private TaskAwaiter<AlgorithmicListDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x8306C90", Offset = "0x8305A90", VA = "0x188306C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x8307120", Offset = "0x8305F20", VA = "0x188307120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private struct <GetUnifiedItemIdsFromCustomAvatarItemAlgorithmicList>d__30 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public AsyncTaskMethodBuilder<List<UnifiedItemId>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public string servingEndpoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public Dictionary<string, string> rankingContextDictionary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			private TaskAwaiter<AlgorithmicListDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8307190", Offset = "0x8305F90", VA = "0x188307190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x8307770", Offset = "0x8306570", VA = "0x188307770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private struct <GetUnifiedItemIdsFromCustomAvatarItemCuratedList>d__32 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public AsyncTaskMethodBuilder<List<UnifiedItemId>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public string servingEndpoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			private TaskAwaiter<CuratedListDTO?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x83077E0", Offset = "0x83065E0", VA = "0x1883077E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8307DA0", Offset = "0x8306BA0", VA = "0x188307DA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private struct <GetUnifiedItemIdsFromPurchasableAlgorithmicList>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public AsyncTaskMethodBuilder<List<UnifiedItemId>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public string servingEndpoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public Dictionary<string, string> rankingContextDictionary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			private TaskAwaiter<AlgorithmicListDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8307E10", Offset = "0x8306C10", VA = "0x188307E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8308390", Offset = "0x8307190", VA = "0x188308390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private struct <GetUnifiedItemIdsFromUnifiedAlgorithmicList>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public AsyncTaskMethodBuilder<List<UnifiedItemId>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			public string servingEndpoint;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public Dictionary<string, string> rankingContextDictionary;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			private TaskAwaiter<AlgorithmicListDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x8308400", Offset = "0x8307200", VA = "0x188308400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x8308970", Offset = "0x8307770", VA = "0x188308970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private struct <GetUnifiedItemIdsFromUnifiedCuratedList>d__36 : IAsyncStateMachine
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
			private TaskAwaiter<CuratedListDTO?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x83089E0", Offset = "0x83077E0", VA = "0x1883089E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x8308F30", Offset = "0x8307D30", VA = "0x188308F30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly DINTWZBUUTH _statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private readonly TBDOKCNPZCW _onlineRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private readonly IRRUIvNextStoreItemBridge _vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private readonly VHELIJUXLCE _outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private readonly XGSQIMTNZVC _purchaseManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private readonly UOLJTZWNVKH _recNetCustomAvatarItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private readonly NREGPJIAXTX _storefrontManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly SHDIMMQKFWM _recNetStorefronts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly NSRZAGUZBGB _storeItemFilteringManager;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x82FEE20", Offset = "0x82FDC20", VA = "0x1882FEE20")]
		[FDNTPBIGLET.Session.GameOnly]
		internal static void DIBind(FDTRVDFSBYT container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x83018A0", Offset = "0x83006A0", VA = "0x1883018A0")]
		[RecRoom.NoEngine.Common.Preserve]
		public StoreItemQueryManager([Inject(null)] DINTWZBUUTH statsig, [Inject(null)] TBDOKCNPZCW onlineRestrictions, [Inject(null)] IRRUIvNextStoreItemBridge vNextStoreItemBridge, [Inject(null)] VHELIJUXLCE outfitManager, [Inject(null)] XGSQIMTNZVC purchaseManager, [Inject(null)] UOLJTZWNVKH recNetCustomAvatarItems, [Inject(null)] SHDIMMQKFWM recNetStorefronts, [Inject(null)] NSRZAGUZBGB storeItemFilteringManager, [Inject(null)] NREGPJIAXTX storefrontManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x82FF0E0", Offset = "0x82FDEE0", VA = "0x1882FF0E0", Slot = "4")]
		[AsyncStateMachine(typeof(<GetStoreItemList>d__12))]
		public Task<IReadOnlyList<NSVNCQQULFO>> GetStoreItemList(StoreItemListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x82FEE90", Offset = "0x82FDC90", VA = "0x1882FEE90")]
		public IReadOnlyList<NSVNCQQULFO> FilterStoreItemList(StoreItemListQueryData queryData, IReadOnlyList<NSVNCQQULFO> storeItems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x82FF220", Offset = "0x82FE020", VA = "0x1882FF220", Slot = "5")]
		[AsyncStateMachine(typeof(<GetStoreItem>d__14))]
		public Task<NSVNCQQULFO> GetStoreItem(UnifiedItemId unifiedItemId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8300AA0", Offset = "0x82FF8A0", VA = "0x188300AA0", Slot = "6")]
		public bool IsOwnedByLocalPlayer(StorefrontGiftDrop giftDrop)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8301510", Offset = "0x8300310", VA = "0x188301510")]
		private Task<List<NSVNCQQULFO>> QueryStaticSource(StoreItemListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8300D80", Offset = "0x82FFB80", VA = "0x188300D80")]
		private Task<List<NSVNCQQULFO>> QueryDynamicSource(StoreItemListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x82FFD00", Offset = "0x82FEB00", VA = "0x1882FFD00")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromSearch>d__21))]
		private Task<List<NSVNCQQULFO>> GetStoreItemsFromSearch(string searchQuery, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x82FFE10", Offset = "0x82FEC10", VA = "0x1882FFE10")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromStorefront>d__22))]
		private Task<List<NSVNCQQULFO>> GetStoreItemsFromStorefront(StoreItemListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x82FF340", Offset = "0x82FE140", VA = "0x1882FF340")]
		private Task<List<NSVNCQQULFO>> GetStoreItemsFromAdCarousel(StoreItemListQueryData queryData, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8300250", Offset = "0x82FF050", VA = "0x188300250")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromWishlist>d__24))]
		private Task<List<NSVNCQQULFO>> GetStoreItemsFromWishlist(int accountId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x82FF700", Offset = "0x82FE500", VA = "0x1882FF700")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromCustomAvatarFeatured>d__25))]
		private Task<List<NSVNCQQULFO>> GetStoreItemsFromCustomAvatarFeatured()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x82FFA90", Offset = "0x82FE890", VA = "0x1882FFA90")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromCustomAvatarPortfolio>d__26))]
		private Task<List<NSVNCQQULFO>> GetStoreItemsFromCustomAvatarPortfolio(int accountId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x82FFBA0", Offset = "0x82FE9A0", VA = "0x1882FFBA0")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromPurchasableAlgorithmicList>d__27))]
		private Task<List<NSVNCQQULFO>> GetStoreItemsFromPurchasableAlgorithmicList(string carouselName, [CanBeNull] Dictionary<string, string> rankingContextDictionary, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8300710", Offset = "0x82FF510", VA = "0x188300710")]
		[AsyncStateMachine(typeof(<GetUnifiedItemIdsFromPurchasableAlgorithmicList>d__28))]
		private Task<List<UnifiedItemId>> GetUnifiedItemIdsFromPurchasableAlgorithmicList(string servingEndpoint, [CanBeNull] Dictionary<string, string> rankingContextDictionary, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x82FF7F0", Offset = "0x82FE5F0", VA = "0x1882FF7F0")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromCustomAvatarItemAlgorithmicList>d__29))]
		private Task<List<NSVNCQQULFO>> GetStoreItemsFromCustomAvatarItemAlgorithmicList(string carouselName, [CanBeNull] Dictionary<string, string> rankingContextDictionary, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x83004C0", Offset = "0x82FF2C0", VA = "0x1883004C0")]
		[AsyncStateMachine(typeof(<GetUnifiedItemIdsFromCustomAvatarItemAlgorithmicList>d__30))]
		private Task<List<UnifiedItemId>> GetUnifiedItemIdsFromCustomAvatarItemAlgorithmicList(string servingEndpoint, [CanBeNull] Dictionary<string, string> rankingContextDictionary, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x82FF950", Offset = "0x82FE750", VA = "0x1882FF950")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromCustomAvatarItemCuratedList>d__31))]
		private Task<List<NSVNCQQULFO>> GetStoreItemsFromCustomAvatarItemCuratedList(string carouselName, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8300600", Offset = "0x82FF400", VA = "0x188300600")]
		[AsyncStateMachine(typeof(<GetUnifiedItemIdsFromCustomAvatarItemCuratedList>d__32))]
		private Task<List<UnifiedItemId>> GetUnifiedItemIdsFromCustomAvatarItemCuratedList(string servingEndpoint, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x82FFF50", Offset = "0x82FED50", VA = "0x1882FFF50")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromUnifiedAlgorithmicList>d__33))]
		private Task<List<NSVNCQQULFO>> GetStoreItemsFromUnifiedAlgorithmicList(string carouselName, [CanBeNull] Dictionary<string, string> rankingContextDictionary, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8300850", Offset = "0x82FF650", VA = "0x188300850")]
		[AsyncStateMachine(typeof(<GetUnifiedItemIdsFromUnifiedAlgorithmicList>d__34))]
		private Task<List<UnifiedItemId>> GetUnifiedItemIdsFromUnifiedAlgorithmicList(string servingEndpoint, [CanBeNull] Dictionary<string, string> rankingContextDictionary, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x83000B0", Offset = "0x82FEEB0", VA = "0x1883000B0")]
		[AsyncStateMachine(typeof(<GetStoreItemsFromUnifiedCuratedList>d__35))]
		private Task<List<NSVNCQQULFO>> GetStoreItemsFromUnifiedCuratedList(string carouselName, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8300990", Offset = "0x82FF790", VA = "0x188300990")]
		[AsyncStateMachine(typeof(<GetUnifiedItemIdsFromUnifiedCuratedList>d__36))]
		private Task<List<UnifiedItemId>> GetUnifiedItemIdsFromUnifiedCuratedList(string servingEndpoint, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x82FEF90", Offset = "0x82FDD90", VA = "0x1882FEF90")]
		[AsyncStateMachine(typeof(<GetStoreItemIdsForCrossTypeSimilarEntities>d__37))]
		private Task<List<NSVNCQQULFO>> GetStoreItemIdsForCrossTypeSimilarEntities(EntityType seedEntityType, string seedId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8300390", Offset = "0x82FF190", VA = "0x188300390")]
		[AsyncStateMachine(typeof(<GetUnifiedItemIdsForCrossTypeSimilarEntities>d__38))]
		private Task<List<UnifiedItemId>> GetUnifiedItemIdsForCrossTypeSimilarEntities(EntityType seedEntityType, string seedId, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x83001F0", Offset = "0x82FEFF0", VA = "0x1883001F0")]
		private Task<List<NSVNCQQULFO>> GetStoreItemsFromUnifiedItemIds(IReadOnlyList<UnifiedItemId> unifiedItemIds, CancellationToken token)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8300B70", Offset = "0x82FF970", VA = "0x188300B70")]
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
