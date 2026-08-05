using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoSaves;
using CoordinateBeacons.Interfaces;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecNet.Common;
using RecNet.Rooms;
using RecNet.Studio;
using RecRoom.Analytics.AccessInterfaces;
using RecRoom.Cameras.Effects;
using RecRoom.Core.Creation;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.DataStructures.ResourceHandles;
using RecRoom.DataStructures.Times;
using RecRoom.Debugging;
using RecRoom.Foundation;
using RecRoom.Foundation.Collections;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.Events;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.NoEngine.DataStructures.Caching;
using RecRoom.NoEngine.DataStructures.Progress;
using RecRoom.NoEngine.DataStructures.Tokens;
using RecRoom.NoEngine.Logging;
using RecRoom.ObjectModel;
using RecRoom.OnlineRestrictions;
using RecRoom.Persistence;
using RecRoom.Preferences;
using RecRoom.Protobuf;
using RecRoom.RoomLoad.Protobuf;
using RecRoom.RoomLoading;
using RecRoom.RoomLoading.AutoSaves;
using RecRoom.RoomLoading.AutoSaves.Storage;
using RecRoom.RoomLoading.AutoSaves.Versions;
using RecRoom.RoomLoading.Errors;
using RecRoom.RoomLoading.Interfaces.Internal;
using RecRoom.RoomLoading.PhotonClients;
using RecRoom.RoomLoading.RoomOperation;
using RecRoom.RoomLoadingAbstractions;
using RecRoom.SceneManagement;
using RecRoom.Versioning.Framework;
using UJect;
using UJect.Injection;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x89DF3D0", Offset = "0x89DDFD0", VA = "0x1889DF3D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class AHNXITVISXR
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal Task<RoomLoadDetails> DSQSIZNEVQD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal Task RJAHNHEHOYJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal HCSKYPDPHUA EVKGXDHFBAP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
	public AHNXITVISXR()
	{
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89DEB00", Offset = "0x89DD700", VA = "0x1889DEB00", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89FD330", Offset = "0x89FBF30", VA = "0x1889FD330", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2721D10", Offset = "0x2720910", VA = "0x182721D10")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RoomOperation.Exceptions
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class RecoverableRoomOperationException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89E1930", Offset = "0x89E0530", VA = "0x1889E1930")]
		public RecoverableRoomOperationException(string message, Exception innerException)
		{
		}
	}
}
namespace RoomOperation.OperationLogic.Restore
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal class ZFOSGYLRPWT : VXYOIXJATFM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct <GetAccountsBulk>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public AsyncTaskMethodBuilder<IReadOnlyList<Account>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public IReadOnlyList<int> accountIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private TaskAwaiter<List<Account>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x89F22F0", Offset = "0x89F0EF0", VA = "0x1889F22F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x89F2500", Offset = "0x89F1100", VA = "0x1889F2500", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct <GetSubRoomDataHistory>d__1 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public AsyncTaskMethodBuilder<IReadOnlyList<SubRoomDataSaveDTO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TaskAwaiter<MWKYUJZOBBC<SubRoomDataSaveDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x89F3440", Offset = "0x89F2040", VA = "0x1889F3440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x89F3680", Offset = "0x89F2280", VA = "0x1889F3680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		[UnityEngine.Scripting.Preserve]
		public ZFOSGYLRPWT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89FD1A0", Offset = "0x89FBDA0", VA = "0x1889FD1A0", Slot = "4")]
		[AsyncStateMachine(typeof(<GetSubRoomDataHistory>d__1))]
		public Task<IReadOnlyList<SubRoomDataSaveDTO>> NOKESDIZYIO(long a, long b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x89FD090", Offset = "0x89FBC90", VA = "0x1889FD090", Slot = "5")]
		[AsyncStateMachine(typeof(<GetAccountsBulk>d__2))]
		public Task<IReadOnlyList<Account>> HLKXXBUWUCN(IReadOnlyList<int> a, [Optional] CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface BOCELDCXPSB : IEquatable<BOCELDCXPSB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int NQFGTCSBQKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[CanBeNull]
		Account WSZHJBXUTNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		DateTime HWQCNBYFXSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		PlatformType? HJFFACKMRSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		DeviceClass? WOFZAJGJRWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		[CanBeNull]
		RestoreOptionTypes ODEJBOZTMLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<WLRKHVLXMOD> AQTMWMHEUVN();
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum RestoreOptionTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		Current,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		RecNetSave,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		DiskAutosave
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface VXYOIXJATFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<SubRoomDataSaveDTO>> NOKESDIZYIO(long a, long b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<IReadOnlyList<Account>> HLKXXBUWUCN(IReadOnlyList<int> a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class NATZAGWUJUG
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private sealed class LWJYAZQBAJL : BOCELDCXPSB, IEquatable<BOCELDCXPSB>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			[CompilerGenerated]
			private struct <Restore>d__13 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public AsyncTaskMethodBuilder<WLRKHVLXMOD> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public LWJYAZQBAJL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				private ZVONWTEYZLG <roomManager>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				private TaskAwaiter<RoomDetailsDTO> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				private TaskAwaiter<WLRKHVLXMOD> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x89F3C70", Offset = "0x89F2870", VA = "0x1889F3C70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x89F4200", Offset = "0x89F2E00", VA = "0x1889F4200", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly SubRoomDataSaveDTO FFYOPURFPNR;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int NQFGTCSBQKH
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0xA9D1C0", Offset = "0xA9BDC0", VA = "0x180A9D1C0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public Account WSZHJBXUTNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private DateTime DPQAVXHCLTQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x89DEA40", Offset = "0x89DD640", VA = "0x1889DEA40", Slot = "6")]
				get
				{
					return default(DateTime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public PlatformType? HJFFACKMRSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2B2E650", Offset = "0x2B2D250", VA = "0x182B2E650", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public DeviceClass? WOFZAJGJRWT
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x89DE870", Offset = "0x89DD470", VA = "0x1889DE870", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public RestoreOptionTypes ODEJBOZTMLE
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0xB55810", Offset = "0xB54410", VA = "0x180B55810", Slot = "10")]
				get
				{
					return default(RestoreOptionTypes);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x89DE770", Offset = "0x89DD370", VA = "0x1889DE770", Slot = "9")]
			[AsyncStateMachine(typeof(<Restore>d__13))]
			public Task<WLRKHVLXMOD> AQTMWMHEUVN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x89DEAA0", Offset = "0x89DD6A0", VA = "0x1889DEAA0")]
			public LWJYAZQBAJL(int a, Account b, SubRoomDataSaveDTO c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x89DE890", Offset = "0x89DD490", VA = "0x1889DE890", Slot = "11")]
			public bool Equals(BOCELDCXPSB other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x89DE920", Offset = "0x89DD520", VA = "0x1889DE920", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x89DEA60", Offset = "0x89DD660", VA = "0x1889DEA60")]
			private bool VXJDHLLTLDF(LWJYAZQBAJL a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x89DE9C0", Offset = "0x89DD5C0", VA = "0x1889DE9C0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private sealed class TJWANALQYAU : BOCELDCXPSB, IEquatable<BOCELDCXPSB>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			[CompilerGenerated]
			private struct <Restore>d__14 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public AsyncTaskMethodBuilder<WLRKHVLXMOD> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public TJWANALQYAU <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				private TaskAwaiter<WLRKHVLXMOD> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x89F44D0", Offset = "0x89F30D0", VA = "0x1889F44D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x89F4720", Offset = "0x89F3320", VA = "0x1889F4720", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly QLEODJJBPHT TAJDUMNQWXB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly PlatformType DOFZDSXBSFZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly DeviceClass IVKVFNJSAJI;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int NQFGTCSBQKH
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x89E9840", Offset = "0x89E8440", VA = "0x1889E9840", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Account WSZHJBXUTNA
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x89E9AA0", Offset = "0x89E86A0", VA = "0x1889E9AA0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private DateTime DPQAVXHCLTQ
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x89E9B30", Offset = "0x89E8730", VA = "0x1889E9B30", Slot = "6")]
				get
				{
					return default(DateTime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public PlatformType? HJFFACKMRSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x89E9B80", Offset = "0x89E8780", VA = "0x1889E9B80", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public DeviceClass? WOFZAJGJRWT
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x89E9880", Offset = "0x89E8480", VA = "0x1889E9880", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public RestoreOptionTypes ODEJBOZTMLE
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0xB5A490", Offset = "0xB59090", VA = "0x180B5A490", Slot = "10")]
				get
				{
					return default(RestoreOptionTypes);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1A63C20", Offset = "0x1A62820", VA = "0x181A63C20")]
			public TJWANALQYAU(QLEODJJBPHT a, PlatformType b, DeviceClass c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x89E9750", Offset = "0x89E8350", VA = "0x1889E9750", Slot = "9")]
			[AsyncStateMachine(typeof(<Restore>d__14))]
			public Task<WLRKHVLXMOD> AQTMWMHEUVN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x89E9980", Offset = "0x89E8580", VA = "0x1889E9980", Slot = "11")]
			public bool Equals(BOCELDCXPSB other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x89E98D0", Offset = "0x89E84D0", VA = "0x1889E98D0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x89E9BD0", Offset = "0x89E87D0", VA = "0x1889E9BD0")]
			private bool VXJDHLLTLDF(TJWANALQYAU a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x89E9A20", Offset = "0x89E8620", VA = "0x1889E9A20", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private sealed class CEHQNTZCQLX : BOCELDCXPSB, IEquatable<BOCELDCXPSB>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			[CompilerGenerated]
			private struct <Restore>d__14 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public AsyncTaskMethodBuilder<WLRKHVLXMOD> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				private TaskAwaiter<WLRKHVLXMOD> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x89F4270", Offset = "0x89F2E70", VA = "0x1889F4270", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x89F4790", Offset = "0x89F3390", VA = "0x1889F4790", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly Account FSALRJWJWEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private readonly PlatformType DOFZDSXBSFZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private readonly DeviceClass IVKVFNJSAJI;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public int NQFGTCSBQKH
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x89DD4A0", Offset = "0x89DC0A0", VA = "0x1889DD4A0", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			[NotNull]
			public Account WSZHJBXUTNA
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private DateTime DPQAVXHCLTQ
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "6")]
				get
				{
					return default(DateTime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public PlatformType? HJFFACKMRSM
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x89DD690", Offset = "0x89DC290", VA = "0x1889DD690", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public DeviceClass? WOFZAJGJRWT
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x89DD4C0", Offset = "0x89DC0C0", VA = "0x1889DD4C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public RestoreOptionTypes ODEJBOZTMLE
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "10")]
				get
				{
					return default(RestoreOptionTypes);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x1A63C20", Offset = "0x1A62820", VA = "0x181A63C20")]
			public CEHQNTZCQLX(Account a, PlatformType b, DeviceClass c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x89DD3D0", Offset = "0x89DBFD0", VA = "0x1889DD3D0", Slot = "9")]
			[AsyncStateMachine(typeof(<Restore>d__14))]
			public Task<WLRKHVLXMOD> AQTMWMHEUVN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x89DD590", Offset = "0x89DC190", VA = "0x1889DD590", Slot = "11")]
			public bool Equals(BOCELDCXPSB other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x89DD510", Offset = "0x89DC110", VA = "0x1889DD510", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x89DD600", Offset = "0x89DC200", VA = "0x1889DD600", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x89DD6E0", Offset = "0x89DC2E0", VA = "0x1889DD6E0")]
			private bool VXJDHLLTLDF(CEHQNTZCQLX a)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <CombineHistoryWithAccounts>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, Account account, SubRoomDataSaveDTO roomDataSaveDto)>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public IReadOnlyList<SubRoomDataSaveDTO> history;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public NATZAGWUJUG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private TaskAwaiter<IReadOnlyList<Account>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x89EB1A0", Offset = "0x89E9DA0", VA = "0x1889EB1A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x89EBB60", Offset = "0x89EA760", VA = "0x1889EBB60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <GetOrderedRestoreOptions>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public AsyncTaskMethodBuilder<IList<BOCELDCXPSB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public long subroomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public bool forceRefreshSaveHistoryCache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public NATZAGWUJUG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private (long roomId, long subroomId) <cacheKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private IReadOnlyList<SubRoomDataSaveDTO> <saveHistory>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private TaskAwaiter<IReadOnlyList<SubRoomDataSaveDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private TaskAwaiter<IReadOnlyList<(int accountId, Account account, SubRoomDataSaveDTO roomDataSaveDto)>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x89F2570", Offset = "0x89F1170", VA = "0x1889F2570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x89F33D0", Offset = "0x89F1FD0", VA = "0x1889F33D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly MPOHMTCIBNU GVVIIXHBMYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly VXYOIXJATFM HTXCJJGZPFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly BDVEDVZIGPE OEDMQOLURSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly OROBRNYNQJG<(long, long), IReadOnlyList<SubRoomDataSaveDTO>> TDBZXRNJGZW;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x89DF2B0", Offset = "0x89DDEB0", VA = "0x1889DF2B0")]
		[UnityEngine.Scripting.Preserve]
		public NATZAGWUJUG([Inject(null)] VXYOIXJATFM roomHistoryProvider, [Inject(null)] BDVEDVZIGPE roomAutosaveService, [Inject(null)] MPOHMTCIBNU platformAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x89DF160", Offset = "0x89DDD60", VA = "0x1889DF160")]
		[AsyncStateMachine(typeof(<GetOrderedRestoreOptions>d__5))]
		public Task<IList<BOCELDCXPSB>> ZJGOMPTXLVA(long a, long b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x89DEFC0", Offset = "0x89DDBC0", VA = "0x1889DEFC0")]
		private bool TVKUBNWMVMH(DateTime? a, long b, long c, [Out] QLEODJJBPHT d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x89DEEB0", Offset = "0x89DDAB0", VA = "0x1889DEEB0")]
		[AsyncStateMachine(typeof(<CombineHistoryWithAccounts>d__7))]
		private Task<IReadOnlyList<(int, Account, SubRoomDataSaveDTO)>> PPWOXSJHJNW(IReadOnlyList<SubRoomDataSaveDTO> a)
		{
			return null;
		}
	}
}
namespace AutoSaves
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface BDVEDVZIGPE
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<QLEODJJBPHT> MIXIIFKCBIM;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool VSXZSRWSWLV(long a, long b, RoomSerializedData c, AutosaveType d);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ABPPXSKCJND(long a, long b, [Out] QLEODJJBPHT c);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool UFTMUMEMLMK(long a, long b, AutosaveType c, [Out] QLEODJJBPHT d);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HSFLAFMOXBD(long a, long b);
	}
}
namespace RecRoom.RoomLoading
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal interface OFZVAJIDTWP : BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool XPAUDTWXSON
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		Task JRHJMKSGOIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IRGJSDJMPXS(Task a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal interface DNXBHPVLZPJ : BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<WLRKHVLXMOD> RequestRestoreAutosave(QLEODJJBPHT autosaveRecordInfo);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task SYHQHPBFFQV(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal interface BGKCZVBTBNY : BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		TNKKQUGAVHK TNKKQUGAVHK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GBQLXSZPUNN();

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OAANOHUNGYT();
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal interface BCVKRROGGDB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(IIDBRQOYHQN roomManager);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal interface DJFXWYYSLCW
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		TimeSpan XWSHVFOPKEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		TimeSpan BXXHIVIQFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		TimeSpan DAOEQLVASXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		TimeSpan RXDDBVOOSZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool SRLKBYWJOWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool STUWZFHNLBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool RQRLTWPIHNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		int RYIEXVOGQDX
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool TQUWILRGGXO
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool HRZLIQJNJND
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool TWYAOXRHSIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public enum RoomEventType
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Load,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		SaveAndReload,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Reload
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum RequestOperationType
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		InitialRoomLoad,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		AutoSave,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		SaveToDisk,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		SaveToRecNet,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		RestoreAutoSave,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Reload
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct RoomEvent
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly RoomEventType type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[CanBeNull]
		public readonly Exception eventException;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x89E21E0", Offset = "0x89E0DE0", VA = "0x1889E21E0")]
		public RoomEvent(long superRoomId, long subRoomId, RoomEventType type, [CanBeNull] Exception eventException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x89E2190", Offset = "0x89E0D90", VA = "0x1889E2190")]
		public static RoomEvent From(RoomInstance room, RoomEventType type, [Optional] Exception eventException)
		{
			return default(RoomEvent);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void RoomEventHandler(RoomEvent roomEvent);
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal interface VNLRTNXGPZT : BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event RoomEventHandler BCZPGALIDMB;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event RoomEventHandler IHLEJMHZPVP;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event RoomEventHandler BXOURKVSDUZ;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<RequestOperationType, bool> KDJGWLVLHYZ;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RBXTXFRKOBT(RoomEvent a);

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void ZIXNNDWCZQB(RoomEvent a);

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void XMCMWIQOQXX(RoomEvent a);

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void ENJWDGENTYZ(RequestOperationType a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal interface WVAADYFIYNV : BCVKRROGGDB, IDisposable, ZLMFXGCUQNE
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool VLPJMVGTROH
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CVKDMOZBJBD();
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal interface MWFWDBGDAHR : BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		TaskStatus PQFXGNBDRYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task JoinRoomInstance(RoomInstance targetInstance, FWSYDBCYQHV customRoomLoadPayload, CancellationToken externalToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class GWSPHWOKFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x89DE2C0", Offset = "0x89DCEC0", VA = "0x1889DE2C0")]
		public static bool HRLIJWATALT(this MWFWDBGDAHR a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate Task InLoadedRoomTaskBuilder(CancellationToken token, int roomTotalVersion, AccountRoleType localPlayerAccountRoleType);
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal interface WVULOYQAUQS : BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool WFITHVEBNVA(InLoadedRoomTaskBuilder a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface IIDBRQOYHQN : ZVONWTEYZLG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		CancellationToken TWMMPLUNALH
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		URVRSSRGCJF JEBIODJBCOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		TSOFJGCPTYM WTNOWPRVTWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		TBEXYEJQNFS MQVRXQISCIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		UFFFZRRBPXW SPGVRHHBWNH
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		GCIVRRRUWLZ COPGCDGWBCA
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		NPCOESJCXHR IEXTHHVCKIS
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		BQFGXFTHRDV QQRDKICFSYS
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		JKPIQQXIFJL JKPIQQXIFJL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		OFZVAJIDTWP YVFLOBBPWMA
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		DNXBHPVLZPJ OXRKRFGOLPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		VNLRTNXGPZT CIFRYZLXCPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		WVAADYFIYNV ZETIZBHQFAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		MWFWDBGDAHR ATNQGXHQGSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		WVULOYQAUQS QXCARXYAAXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		XNZVOZBCXUJ CTJVZWCCKFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		JGNQGWSBKSC HBFTOESXKOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		BYTSDAIHWMX RZYOUGJZYIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		NSSLHPLZEAC RUNSAHKCTRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		FEQJSDHNGZK UNQWYFHJONT
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		XSRZAJFGDTC BJOHJHWEEKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		DYZGTIFVZSV IREAOLDZARA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		THVKUDUNAXN OZANVZICTIM
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		XJOGKEYAJMH VDFJIMJUPMU
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		TBZYWRKNUED EDSJUOFCNYO
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		BGKCZVBTBNY QEUCDEMEZKV
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		DJFXWYYSLCW EEPEEYHLFMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		WJWHSKXJPKM XARPMSVCCNX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		BDVEDVZIGPE KDQKKVRSQGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		NEECCIUHZQD APWCBAWDWEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		TLMPALUKRRW UQJBSWHTLYM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		HNOFUIUXRAK NZGIAPAXXYT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		TIKAXYDLCSO TURBAIJDOYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		new bool NUQDIGNPTGY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(Slot = "34")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void NXZFQWGXSUP(FWSYDBCYQHV a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal interface XNZVOZBCXUJ : BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PendingRequest Add(Guid operationId);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool Remove(Guid operationId);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool DYSQJNTTXVV(Guid a, Task b);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ZYMFIQJJJHR(Guid a, WLRKHVLXMOD b);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<(WLRKHVLXMOD, Task)> CLHHHQUEKVC(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface DTFLPTSQVDD : BCVKRROGGDB, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal interface JGNQGWSBKSC : BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KMXSFCNKPGA(RECTXKHRIXS a);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SVNLFBUNKLN(RECTXKHRIXS a);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RoomOperationType> BRJMTNODLLS(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal interface BYTSDAIHWMX : BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PendingRequest TKTQDCRITAD(RECTXKHRIXS a);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZMXZMEUXDIA(Guid a, Task b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal interface NSSLHPLZEAC : BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<WLRKHVLXMOD> RUNSAHKCTRL(RECTXKHRIXS a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface FEQJSDHNGZK : BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RoomLoadRequestPayload> YIFAMAHPIED(StackTimer<string>.USVZTROCTRS a, RoomInstance b, CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal interface DYZGTIFVZSV : BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WLRKHVLXMOD AERSFHTJKCD(HNNNRVHBOIU a);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task RequestSaveRoomToDisk(string path);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal interface XSRZAJFGDTC : BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RECTXKHRIXS> IMLWARTBDLA(RECTXKHRIXS a, AFCWAAKQTIP b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<RECTXKHRIXS> BWGTXKRBOXG(CancellationToken a, AFCWAAKQTIP b);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		VGXLHGZFUHZ HWHXIKZCIPJ(KOQJHZNNMVK a, StackTimer<string>.USVZTROCTRS b);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		VGXLHGZFUHZ MPMJBRIYAYK(KOQJHZNNMVK a, StackTimer<string>.USVZTROCTRS b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface THVKUDUNAXN : BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WLRKHVLXMOD EDKNQAGACQP(HNNNRVHBOIU a, RoomOperationType b);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		WLRKHVLXMOD GOEKSNIRFWG(HNNNRVHBOIU a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public interface BCLSMCOVFKT
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		const int RPBMMUITLPD = 1000;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		IReadOnlyDictionary<Guid, RoomAssetDTO> JNGADZVBPAV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		Action NPKRUXERKSU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyList<Guid> QSUQSJFQFPK();

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task TDVYGWYNCPS([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task ZDGEUJABXQM([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface XJOGKEYAJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NGXWQMBVOEP(PWHWXFVVGJJ a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SKPNGSFZBEU(PWHWXFVVGJJ a);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZDFSINCYTAI(PWHWXFVVGJJ a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JQKJFUSZMCA(PWHWXFVVGJJ a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class PWHWXFVVGJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly RoomInstance CEJWZIFDERZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Dictionary<string, string> MLBEEAZJVNI;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public StackTimer<string> RWQWFEZMISI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xA98370", Offset = "0xA96F70", VA = "0x180A98370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public PWHWXFVVGJJ(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x89DF4E0", Offset = "0x89DE0E0", VA = "0x1889DF4E0")]
		public PWHWXFVVGJJ OTJPEMJSCFZ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x89DF450", Offset = "0x89DE050", VA = "0x1889DF450")]
		public bool CMHXMJSMLQL([Out] IEnumerable<KeyValuePair<string, string>> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x790BAE0", Offset = "0x790A6E0", VA = "0x18790BAE0")]
		public PWHWXFVVGJJ DXZWBINBSBS(StackTimer<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface WJWHSKXJPKM
	{
		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		bool OZSSHGNLWGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		bool FFHJHJBBYAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		string HRQMPGNQHPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		bool JVDHAQGIVKX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UYEZUDGTCBV();

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		WQOVIOFSSRC PHFIJFFOSYO(long a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		XLAGZXHUVSQ<FilenameWithHash, SuperRoomData> LUWVOFMDSXI(long a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		XLAGZXHUVSQ<FilenameWithHash, PersistedRoomData> POUPANWAKKA(long a);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		XLAGZXHUVSQ<long, OHPGYSJVQRZ> RXNVQGTEDSQ();

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Task<IReadOnlyCollection<BakedUnitySubAssetDTO>> TZBWKRLMPSS(long a, IReadOnlyCollection<BakedUnitySubAssetDTO> b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool GSCOWGCZCVH(long a, [Out] bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<bool> SQPAOFAXNHB(byte[] a, byte[] b, IReadOnlyCollection<Guid> c, CancellationToken d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface ACHQKVPRACK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RoomLoadRequestPayload Create(long superRoomId, long subRoomId, long subRoomDataSaveId, string studioSessionId);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RoomLoadRequestPayload Create(long superRoomId, long subRoomId, FilenameWithHash superRoomData, Guid? snapshotId, long subRoomDataSaveId, bool loadUsedCompatibility);

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RoomLoadRequestPayload Create(SaveSubRoomResponseDTO saveSubRoomResponseDTO);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		RoomLoadRequestPayload Create(RoomDetailsDTO superRoom, SubRoomDataSaveDTO subRoomSave);
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface ZVONWTEYZLG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool HRLIJWATALT
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool WJWLVYDDAUY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		bool NUQDIGNPTGY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		ACHQKVPRACK SDFQTTQECJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		FWSYDBCYQHV DSSMAPQJADX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event RoomEventHandler BCZPGALIDMB;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event RoomEventHandler IHLEJMHZPVP;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RoomEventHandler BXOURKVSDUZ;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<RequestOperationType, bool> KDJGWLVLHYZ;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void CVKDMOZBJBD();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "12")]
		XVADGRDCPCQ FJIBUQYNRYO();

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "13")]
		DNDPXJXMLLV HUGWXXDCBZQ();

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Task QOLFVAGDFIY(int a, RoomSaveRequestPayload b, Func<RoomSerializedData, RoomSerializedData> c);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task<WLRKHVLXMOD> RequestRestoreAutosave(QLEODJJBPHT autosaveRecord);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task SYHQHPBFFQV(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface GCIVRRRUWLZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000057")]
		bool WUTKOJBAPQW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool GHQNYQFCNAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		Guid? PIXUKCXXIOT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AXQAGSBLNLS(Scene a);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task SDJIQZPZVRK(DEIBVVDFPUX a, IReadOnlyList<DEIBVVDFPUX> b, IReadOnlyList<DEIBVVDFPUX> c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HGBDGAQZRYJ(Guid a, IReadOnlyList<Guid> b, UnitySubAssetKind c, [Optional] object d);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task YWGOHQDMRLL(IReadOnlyList<Guid> a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		CUKGYQKIYEV TGQUVSTRPZV();

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task IPVTNAGWJLM();

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void CINCKBGSICH(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task GJEISYXMNHW();
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface UFFFZRRBPXW
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		IHOYXZOJIJC RRESXEGEGKR
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		bool PFKHYSCQHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		bool TKQWNGEUHOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		bool KWMWUFWZJIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		bool VNXQETKEVKW
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		int YJMLQGGYMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		bool YFQYCPKHFBH
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(Slot = "50")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool NVXMMIKAICS
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "58")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		int EURHTGUCWQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(Slot = "59")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		int EUBNBMMKUIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(Slot = "60")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		bool PJSBMVIXJHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(Slot = "61")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		bool UZBYMIVWDBX
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "66")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		bool UYMDUOOEATW
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "67")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		float ZCDMAASRRMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "70")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action<float> UOJUETHAUMQ;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		URVRSSRGCJF BFRCRADWJUT(URVRSSRGCJF a);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KVLLRIRBEZU(URVRSSRGCJF a);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EYTEOBWPDPU();

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task ShowLoadingScreen(StackTimer<string>.USVZTROCTRS loadingScreenScope, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void XDILRHGMFSE(float a);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void WVAHJEQUOCP(string a);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IReadOnlyList<WBHGJFMWGKA> OWJXKISUVVR();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IDisposable NLEMEJURZBB(object a, WBHGJFMWGKA b);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "10")]
		IReadOnlyList<EmptySceneHandler> FYFQMHLWHKB();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "11")]
		SuperRoomData LPJJCTAHPLB(IEnumerable<JEXJFGQTHAX> a);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void QLRDZHIOCOZ(int a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task DNBFTKJEPLO();

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void FXBZOYATQSC();

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool UYXABVPPVBZ();

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		Task XFSTJJKMXSY(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task YTVPWOHYGKO(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "21")]
		Task<LoadRecoveryAutosaveResponse> SRPEPJBNGGW(DateTime a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Task<bool> RPIOFMDLCIB(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void CLOGSTWHYQI(string a = "", float b = 3f);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "25")]
		RoomSerializedMetadata JIKMGZFAFGN(RoomSaveOptions a, SerializeType b, PersistedRoomData c, IEnumerable<PersistenceView> d, KBWJHRDTEZE e);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void CJFEORXEVFJ(PersistedRoomData a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void VGIHTTBNAOI(JEXJFGQTHAX a, [In] RoomSerializedMetadata metadata);

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "28")]
		Task BXXZPSBXPSM(PersistedRoomData a, bool b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "29")]
		Task TPNRWSZAHFV(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void JFSNTOMFYYI(long a, long b, RoomDetailsDTO c, SubRoomDataSaveDTO d, RoomSerializedData e, RoomSaveRequestPayload? roomSaveRequestPayload, RoomSaveAnalyticsInfo? f);

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void QSGODPAJLYV(long a, long b, RoomSaveAnalyticsInfo? c);

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void DQPBIGIFVLW(PersistenceView a);

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void GDTIWNDHPGZ(string a, RoomInstance b, RoomDTO c, [Optional] string? fallbackReason, [Optional] string? fallbackFailureReason, [Optional] string? subReason);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool BGYATUGIABZ(PersistenceView a);

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		bool XKOKSCHGZCR(JEXJFGQTHAX a, DEPRECATED_RoomPersistenceVersion b, [Out] VTAQKVPUYNS c);

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task YXTZAWZQJXP(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void AWSLVHFARYJ();

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "38")]
		IDisposable IWEYSPIZATH();

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "39")]
		void NWJMCCZCNFP(PersistedRoomData a, DEPRECATED_RoomPersistenceVersion b);

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task<bool> RequestMasterSpawnNewLocalPlayer(TSOFJGCPTYM networking, CancellationToken cancellationToken, StackTimer<string>.USVZTROCTRS stackTimer);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "41")]
		void KABBPBOUBMG(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task<SaveSubRoomResponseDTO> RBAPXQIBWZR(SaveSubRoomRequest a);

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task<RoomDetailsDTO> OGUESSYWVQU(long a, bool b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<SubRoomDataSaveWithUnityAssetsDTO> OBECCEBFVSL(long a, long b, long c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "45")]
		Task<SubRoomDataSaveDTO> TYZKETUEQXK(long a, long b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task<RoomLoadDTO> XOWQWFJPKIO(long a, Guid b, long? c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "47")]
		XLAGZXHUVSQ<RoomLoadDTO, IEnumerable<RoomAssetData>> EYFLZQXGMSK();

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "48")]
		Task<RemoteRunDTO> TITFCZCOFKB(string a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "49")]
		Task<RemoteRunDTO> RYCBTZDQTIA(string a, long b, long c, Guid? d, Storage.UploadFileResponseDTO e, Storage.UploadFileResponseDTO f, int g);

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "51")]
		bool KQAZARADCEM();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "52")]
		bool HIJHJILCASC();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "53")]
		bool KDQFNCMPDKY(IEnumerable<VTAQKVPUYNS> a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void BulkDestroy(List<GameObject> objectsToDestroy);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "55")]
		float IXHPQIHRHSR();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "56")]
		Task<bool> RCPLKQYYJTF(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "57")]
		Task<Scene> ZCFFFPRJEDB(string a, LoadSceneMode b, bool c, StackTimer<string>.USVZTROCTRS d);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "62")]
		void EnableDisableObjectModel(bool enabled);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "63")]
		void BeginLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void EndLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "65")]
		void XDZSJMREKYH(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "71")]
		Task<Storage.UploadFileResponseDTO> UABZIXWZSGA(byte[] a, Storage.FileType b, MimeType c, [Optional] IReadOnlyCollection<string>? referencedFilenames, [Optional] string? filenameOverride);

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "72")]
		void WSIZETUJPOR(RoomInstance a);

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "73")]
		Task VEQVIMUBMKY(StackTimer<string>.USVZTROCTRS a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "74")]
		Task TriggerMClusterManager(StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "75")]
		Task TriggerScalabilityManager(StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "76")]
		Task TriggerClusterLodManager(StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "77")]
		IDisposable GYZORWHSNPZ();

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "78")]
		LCJSFIUQQGR QJGOCKLPJTU();

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "79")]
		Task HideLoadingScreen(CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface LCJSFIUQQGR
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task SUBAVACBHQV(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task WaitForRespawn(CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct RoomSerializedMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public HashSet<int> serializedCircuitNodeIds;
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum LoadRecoveryAutosaveResponse : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Yes,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		No,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		NoAndDelete
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct RoomSaveOptions
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Guid? UnityAssetId;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public interface IHOYXZOJIJC
	{
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		RoomInstance TYSAIYMWONQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		RoomDetailsDTO IZQTPLIMKVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		SubRoomDTO TNXUKVVQWAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		bool KGBCMAWOGDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		bool PMMDRJUKVPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		int BFATIRTXRKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action WIQBGRWJXUK;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<int> QARZXQBFSTX;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void LKRZHSXQVXK();

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<Matchmaking.ServerConnectionInfoDTO> GetServerConnectionInfo(long roomInstanceId, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<MatchmakingErrorCode> FGOPIWSIXKB(RoomInstance a, [Optional] FWSYDBCYQHV b);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task<MatchmakingErrorCode> BGURMYVXDJN();

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Task NUXVNTZPATA();

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "15")]
		(RoomInstance, FWSYDBCYQHV) KDXFTCKNVJL();

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "16")]
		PlayerPresence WFKBEPTMUGM();

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void DTFQVBFWCKH(long a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void BVSNCKSQVDY(RoomInstance a, Matchmaking.GameJoinResult b, (int Major, int? Minor)? errorCode);
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface TBZYWRKNUED
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SIWGYABAGLW([Out] IEnumerable<int> a);

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LHCTWHYIGSG(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PCSJMOHFYMD(Token a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface BBXLINXDKSK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string OCKYONBNYKD(WLRKHVLXMOD a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface TKQXBWOSSHC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AICPRJYXJMM(XEGHYLYFRUB.ValidateOperation a);

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ELOBPPSFEVT(XEGHYLYFRUB.ValidateOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface NPCOESJCXHR : TKQXBWOSSHC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WLRKHVLXMOD BEAZIOKPCJF(HNNNRVHBOIU a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public interface BQFGXFTHRDV : TKQXBWOSSHC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WLRKHVLXMOD AERSFHTJKCD(HNNNRVHBOIU a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public interface WQOVIOFSSRC
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<LQASPMMHSEM, DOTNMKZGUXE>> GBVEAFLRCWE(Guid? a, IReadOnlyCollection<BakedUnitySubAssetDTO> b, IReadOnlyCollection<BakedUnitySubAssetDTO> c, AssetBundleLoadSource d, long? e, long? f, RecNet.Core.OnDownloadProgressDelegate g, CancellationToken h);
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class LQASPMMHSEM
	{
		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public DEIBVVDFPUX VXTCFZFEETG
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public IReadOnlyList<DEIBVVDFPUX> CLABCBRKOUT
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public IReadOnlyList<DEIBVVDFPUX> QNNTEDIVHLP
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xDA16A0", Offset = "0xDA02A0", VA = "0x180DA16A0")]
		public LQASPMMHSEM(DEIBVVDFPUX a, IReadOnlyList<DEIBVVDFPUX> b, IReadOnlyList<DEIBVVDFPUX> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface XLAGZXHUVSQ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<ParseResult<b>, DOTNMKZGUXE>> BFXIOZQBFTB(a a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal sealed class RoomManager : IIDBRQOYHQN, ZVONWTEYZLG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class SAUREINEKOZ : IEnumerable<BCVKRROGGDB>, IEnumerable, IEnumerator<BCVKRROGGDB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private BCVKRROGGDB VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private int FTPEWITHWYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public RoomManager BIVSZSMQJUR;

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			private BCVKRROGGDB MNWXLCTZYVC
			{
				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xD18690", Offset = "0xD17290", VA = "0x180D18690")]
			[DebuggerHidden]
			public SAUREINEKOZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "7")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x89E8AC0", Offset = "0x89E76C0", VA = "0x1889E8AC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x89E8F10", Offset = "0x89E7B10", VA = "0x1889E8F10", Slot = "10")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x89E8E70", Offset = "0x89E7A70", VA = "0x1889E8E70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<BCVKRROGGDB> YSVORNFLDGX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x89E8E70", Offset = "0x89E7A70", VA = "0x1889E8E70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct <RecRoom-RoomLoading-IRoomManager-RequestRestoreAutosave>d__165 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public AsyncTaskMethodBuilder<WLRKHVLXMOD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public RoomManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public QLEODJJBPHT autosaveRecordInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private TaskAwaiter<WLRKHVLXMOD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x89F36F0", Offset = "0x89F22F0", VA = "0x1889F36F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x89F3970", Offset = "0x89F2570", VA = "0x1889F3970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct <RecRoom-RoomLoading-IRoomManager-RunRecoveryAutosave>d__166 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public RoomManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x89F39E0", Offset = "0x89F25E0", VA = "0x1889F39E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x89F3C10", Offset = "0x89F2810", VA = "0x1889F3C10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly CancellationTokenSource COIWYCEFSAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly URVRSSRGCJF container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool AHBYTLQTEJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private LogFlagsToken MJAJFIMUQNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private bool LUTBLQUQAKJ;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public TSOFJGCPTYM WTNOWPRVTWZ
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5C0", Offset = "0xA991C0", VA = "0x180A9A5C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5B0", Offset = "0xA991B0", VA = "0x180A9A5B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public TBEXYEJQNFS MQVRXQISCIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5A0", Offset = "0xA991A0", VA = "0x180A9A5A0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xA9A580", Offset = "0xA99180", VA = "0x180A9A580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public UFFFZRRBPXW SPGVRHHBWNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xA9A590", Offset = "0xA99190", VA = "0x180A9A590", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xA9A570", Offset = "0xA99170", VA = "0x180A9A570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public GCIVRRRUWLZ COPGCDGWBCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xA9E2F0", Offset = "0xA9CEF0", VA = "0x180A9E2F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xA9E2E0", Offset = "0xA9CEE0", VA = "0x180A9E2E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public NPCOESJCXHR IEXTHHVCKIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xA9EA20", Offset = "0xA9D620", VA = "0x180A9EA20", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xA9EA10", Offset = "0xA9D610", VA = "0x180A9EA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public BQFGXFTHRDV QQRDKICFSYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xA9D870", Offset = "0xA9C470", VA = "0x180A9D870", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA9D130", Offset = "0xA9BD30", VA = "0x180A9D130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public ACHQKVPRACK SDFQTTQECJL
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xA9D860", Offset = "0xA9C460", VA = "0x180A9D860", Slot = "54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xA9D200", Offset = "0xA9BE00", VA = "0x180A9D200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public JKPIQQXIFJL JKPIQQXIFJL
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA9D1D0", Offset = "0xA9BDD0", VA = "0x180A9D1D0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA9D160", Offset = "0xA9BD60", VA = "0x180A9D160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public OFZVAJIDTWP YVFLOBBPWMA
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xAC5C70", Offset = "0xAC4870", VA = "0x180AC5C70", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xCAD0A0", Offset = "0xCABCA0", VA = "0x180CAD0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public DNXBHPVLZPJ OXRKRFGOLPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xA9D810", Offset = "0xA9C410", VA = "0x180A9D810", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xA9D820", Offset = "0xA9C420", VA = "0x180A9D820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public VNLRTNXGPZT CIFRYZLXCPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xB82670", Offset = "0xB81270", VA = "0x180B82670", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xB81D90", Offset = "0xB80990", VA = "0x180B81D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public WVAADYFIYNV ZETIZBHQFAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA96C10", Offset = "0xA95810", VA = "0x180A96C10", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA96EF0", Offset = "0xA95AF0", VA = "0x180A96EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public MWFWDBGDAHR ATNQGXHQGSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xC33090", Offset = "0xC31C90", VA = "0x180C33090", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xCE42B0", Offset = "0xCE2EB0", VA = "0x180CE42B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public WVULOYQAUQS QXCARXYAAXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xBE1070", Offset = "0xBDFC70", VA = "0x180BE1070", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x1210980", Offset = "0x120F580", VA = "0x181210980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public XNZVOZBCXUJ CTJVZWCCKFO
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xBC6F90", Offset = "0xBC5B90", VA = "0x180BC6F90", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xBC6FA0", Offset = "0xBC5BA0", VA = "0x180BC6FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public DTFLPTSQVDD CXSSCACAXPS
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xB6E0C0", Offset = "0xB6CCC0", VA = "0x180B6E0C0", Slot = "60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1070540", Offset = "0x106F140", VA = "0x181070540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public JGNQGWSBKSC HBFTOESXKOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xB56A00", Offset = "0xB55600", VA = "0x180B56A00", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xBF5380", Offset = "0xBF3F80", VA = "0x180BF5380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public BYTSDAIHWMX RZYOUGJZYIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA96BA0", Offset = "0xA957A0", VA = "0x180A96BA0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA96BF0", Offset = "0xA957F0", VA = "0x180A96BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public NSSLHPLZEAC RUNSAHKCTRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xC66670", Offset = "0xC65270", VA = "0x180C66670", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xDF41C0", Offset = "0xDF2DC0", VA = "0x180DF41C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public FEQJSDHNGZK UNQWYFHJONT
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xC66650", Offset = "0xC65250", VA = "0x180C66650", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x141ED70", Offset = "0x141D970", VA = "0x18141ED70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public XSRZAJFGDTC BJOHJHWEEKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xC66660", Offset = "0xC65260", VA = "0x180C66660", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x141E590", Offset = "0x141D190", VA = "0x18141E590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public DYZGTIFVZSV IREAOLDZARA
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xB6E0B0", Offset = "0xB6CCB0", VA = "0x180B6E0B0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x120EB20", Offset = "0x120D720", VA = "0x18120EB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public THVKUDUNAXN OZANVZICTIM
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xBF4E60", Offset = "0xBF3A60", VA = "0x180BF4E60", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xBF5030", Offset = "0xBF3C30", VA = "0x180BF5030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public XJOGKEYAJMH VDFJIMJUPMU
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xC66620", Offset = "0xC65220", VA = "0x180C66620", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x141EE20", Offset = "0x141DA20", VA = "0x18141EE20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public TBZYWRKNUED EDSJUOFCNYO
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xB85C20", Offset = "0xB84820", VA = "0x180B85C20", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xCD7050", Offset = "0xCD5C50", VA = "0x180CD7050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public BGKCZVBTBNY QEUCDEMEZKV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xC665E0", Offset = "0xC651E0", VA = "0x180C665E0", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x1211D30", Offset = "0x1210930", VA = "0x181211D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public DJFXWYYSLCW EEPEEYHLFMR
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xBBC210", Offset = "0xBBAE10", VA = "0x180BBC210", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xBBBA00", Offset = "0xBBA600", VA = "0x180BBBA00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public WJWHSKXJPKM XARPMSVCCNX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xBBEED0", Offset = "0xBBDAD0", VA = "0x180BBEED0", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xBBA7C0", Offset = "0xBB93C0", VA = "0x180BBA7C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public BDVEDVZIGPE KDQKKVRSQGN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xC665F0", Offset = "0xC651F0", VA = "0x180C665F0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public NEECCIUHZQD APWCBAWDWEG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xB0B3A0", Offset = "0xB09FA0", VA = "0x180B0B3A0", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public TLMPALUKRRW UQJBSWHTLYM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xC66600", Offset = "0xC65200", VA = "0x180C66600", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public HNOFUIUXRAK NZGIAPAXXYT
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xB0B430", Offset = "0xB0A030", VA = "0x180B0B430", Slot = "35")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TIKAXYDLCSO TURBAIJDOYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xBD0CD0", Offset = "0xBCF8D0", VA = "0x180BD0CD0", Slot = "36")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public FWSYDBCYQHV DSSMAPQJADX
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xC66750", Offset = "0xC65350", VA = "0x180C66750", Slot = "58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xDC5240", Offset = "0xDC3E40", VA = "0x180DC5240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private bool MUWRTFLXUIO
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x89E8460", Offset = "0x89E7060", VA = "0x1889E8460", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool APFDENJMZUN
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x89E7FE0", Offset = "0x89E6BE0", VA = "0x1889E7FE0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool IPOCAEMSRDR
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x19AB460", Offset = "0x19AA060", VA = "0x1819AB460", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private CancellationToken HLKJLMHSQMD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x89E78A0", Offset = "0x89E64A0", VA = "0x1889E78A0", Slot = "4")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private URVRSSRGCJF VLOGQYDWLWY
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private bool ZKMGULJVZDY
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x19AB460", Offset = "0x19AA060", VA = "0x1819AB460", Slot = "37")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x199EC20", Offset = "0x199D820", VA = "0x18199EC20", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		private event RoomEventHandler WRJEHGOBAZW
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x89E7F80", Offset = "0x89E6B80", VA = "0x1889E7F80", Slot = "40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x89E7840", Offset = "0x89E6440", VA = "0x1889E7840", Slot = "41")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event RoomEventHandler TTNKAPTROHC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x89E7D10", Offset = "0x89E6910", VA = "0x1889E7D10", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x89E7CB0", Offset = "0x89E68B0", VA = "0x1889E7CB0", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		private event RoomEventHandler VBPAHINGSJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x89E8060", Offset = "0x89E6C60", VA = "0x1889E8060", Slot = "44")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x89E8400", Offset = "0x89E7000", VA = "0x1889E8400", Slot = "45")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		private event Action<RequestOperationType, bool> VDYLVAOVEJW
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x89E7C50", Offset = "0x89E6850", VA = "0x1889E7C50", Slot = "46")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x89E7D70", Offset = "0x89E6970", VA = "0x1889E7D70", Slot = "47")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xDC5240", Offset = "0xDC3E40", VA = "0x180DC5240", Slot = "39")]
		public void NXZFQWGXSUP(FWSYDBCYQHV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x89E8610", Offset = "0x89E7210", VA = "0x1889E8610")]
		[UnityEngine.Scripting.Preserve]
		internal RoomManager([Inject(null)] URVRSSRGCJF container, [Inject(null)] TSOFJGCPTYM networking, [Inject(null)] TBEXYEJQNFS networkingClient, [Inject(null)] UFFFZRRBPXW callbacks, [Inject(null)] GCIVRRRUWLZ assetBundleManager, [Inject(null)] NPCOESJCXHR roomReloadValidation, [Inject(null)] BQFGXFTHRDV roomSaveValidation, [Inject(null)] JKPIQQXIFJL debugRoomLoadInfo, [Inject(null)] OFZVAJIDTWP activeTask, [Inject(null)] DNXBHPVLZPJ autosaves, [Inject(null)] VNLRTNXGPZT events, [Inject(null)] WVAADYFIYNV fallbacks, [Inject(null)] MWFWDBGDAHR initialRoomLoad, [Inject(null)] WVULOYQAUQS inRoomTasks, [Inject(null)] XNZVOZBCXUJ pendingRequests, [Inject(null)] DTFLPTSQVDD presenceUpdates, [Inject(null)] JGNQGWSBKSC receiveOperation, [Inject(null)] BYTSDAIHWMX requestHandler, [Inject(null)] NSSLHPLZEAC requestOperation, [Inject(null)] FEQJSDHNGZK roomLoadRequest, [Inject(null)] DYZGTIFVZSV save, [Inject(null)] XSRZAJFGDTC synchronization, [Inject(null)] THVKUDUNAXN validation, [Inject(null)] XJOGKEYAJMH roomJoinAnalytics, [Inject(null)] TBZYWRKNUED playerSynchronization, [Inject(null)] DJFXWYYSLCW config, [Inject(null)] WJWHSKXJPKM roomLoadDataProviderOverride, [Inject(null)] BDVEDVZIGPE autosaveService, [Inject(null)] NEECCIUHZQD cameraFade, [Inject(null)] TLMPALUKRRW errorRegistry, [Inject(null)] HNOFUIUXRAK onlineRestrictions, [Inject(null)] TIKAXYDLCSO preEmptySceneHandler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x89E7EE0", Offset = "0x89E6AE0", VA = "0x1889E7EE0")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x89E78C0", Offset = "0x89E64C0", VA = "0x1889E78C0", Slot = "59")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x89E80C0", Offset = "0x89E6CC0", VA = "0x1889E80C0", Slot = "51")]
		private void QHDWYSNZNDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x89E77C0", Offset = "0x89E63C0", VA = "0x1889E77C0", Slot = "52")]
		private XVADGRDCPCQ AZZUAKEXCSJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x89E7AE0", Offset = "0x89E66E0", VA = "0x1889E7AE0", Slot = "53")]
		private DNDPXJXMLLV FGNXTXOBZTL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x89E8110", Offset = "0x89E6D10", VA = "0x1889E8110", Slot = "55")]
		public Task QOLFVAGDFIY(int a, RoomSaveRequestPayload b, Func<RoomSerializedData, RoomSerializedData> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x89E7B60", Offset = "0x89E6760", VA = "0x1889E7B60")]
		private YNVPMWWTOGB FRLLMWFNGEQ(int a, RoomSaveRequestPayload b, Func<RoomSerializedData, RoomSerializedData> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x89E7DD0", Offset = "0x89E69D0", VA = "0x1889E7DD0", Slot = "56")]
		[AsyncStateMachine(typeof(<RecRoom-RoomLoading-IRoomManager-RequestRestoreAutosave>d__165))]
		private Task<WLRKHVLXMOD> IWVLAVOKVPP(QLEODJJBPHT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x89E8520", Offset = "0x89E7120", VA = "0x1889E8520", Slot = "57")]
		[AsyncStateMachine(typeof(<RecRoom-RoomLoading-IRoomManager-RunRecoveryAutosave>d__166))]
		private Task XKPIKVALFNE(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x89E7A60", Offset = "0x89E6660", VA = "0x1889E7A60")]
		[IteratorStateMachine(typeof(SAUREINEKOZ))]
		private IEnumerable<BCVKRROGGDB> FFZPFSYYTCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x89E84C0", Offset = "0x89E70C0", VA = "0x1889E84C0")]
		[CompilerGenerated]
		private void XCMMRIELFXT(BCVKRROGGDB a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class CameraFadeTimeoutException : TimeoutException
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1813E20", Offset = "0x1812A20", VA = "0x181813E20")]
		public CameraFadeTimeoutException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal class FallbackToBootScene : XXKAYQQDLZH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct <RunFallback>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public AsyncTaskMethodBuilder<XXKAYQQDLZH.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public HashSet<ZLMFXGCUQNE.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public FallbackToBootScene <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x89F7840", Offset = "0x89F6440", VA = "0x1889F7840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x89F7B50", Offset = "0x89F6750", VA = "0x1889F7B50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly IIDBRQOYHQN PNSRTVKXRGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly UFFFZRRBPXW TIDVWLUQWFP;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		private string RDBCQXDHZII
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x89DD960", Offset = "0x89DC560", VA = "0x1889DD960", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA99D10", Offset = "0xA98910", VA = "0x180A99D10")]
		public FallbackToBootScene(IIDBRQOYHQN roomManager, UFFFZRRBPXW callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x89DD990", Offset = "0x89DC590", VA = "0x1889DD990", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__6))]
		public Task<XXKAYQQDLZH.Result> SHHWOTVSNAS(HashSet<ZLMFXGCUQNE.Reason> a, CancellationToken b, ZLMFXGCUQNE.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal class FallbackToOfflineDormRoom : AGTPFQZYFEW, XXKAYQQDLZH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct <RunFallback>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public AsyncTaskMethodBuilder<XXKAYQQDLZH.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public FallbackToOfflineDormRoom <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public HashSet<ZLMFXGCUQNE.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public ZLMFXGCUQNE.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private RoomInstance <localRoomInstance>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private long <preFallbackInstance>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private bool <currentIsOffline>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private TaskAwaiter<XXKAYQQDLZH.Result> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x89F6110", Offset = "0x89F4D10", VA = "0x1889F6110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x89F7760", Offset = "0x89F6360", VA = "0x1889F7760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly HXFXHNYTPOW ECOIXTNYGAV;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		private string RDBCQXDHZII
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x89DDB20", Offset = "0x89DC720", VA = "0x1889DDB20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x89DDD20", Offset = "0x89DC920", VA = "0x1889DDD20")]
		public FallbackToOfflineDormRoom([Inject(null)] IIDBRQOYHQN roomManager, [Inject(null)] UFFFZRRBPXW callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x89DDB50", Offset = "0x89DC750", VA = "0x1889DDB50", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__5))]
		public Task<XXKAYQQDLZH.Result> SHHWOTVSNAS(HashSet<ZLMFXGCUQNE.Reason> a, CancellationToken b, ZLMFXGCUQNE.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal class FallbackToOfflineMultiplayerOrientationSubRoom : AGTPFQZYFEW, XXKAYQQDLZH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct <RunFallback>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public AsyncTaskMethodBuilder<XXKAYQQDLZH.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public FallbackToOfflineMultiplayerOrientationSubRoom <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public HashSet<ZLMFXGCUQNE.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private TaskAwaiter<MatchmakingErrorCode> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private TaskAwaiter<XXKAYQQDLZH.Result> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x89F56B0", Offset = "0x89F42B0", VA = "0x1889F56B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x89F60A0", Offset = "0x89F4CA0", VA = "0x1889F60A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		private string RDBCQXDHZII
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x89DDDF0", Offset = "0x89DC9F0", VA = "0x1889DDDF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA99D10", Offset = "0xA98910", VA = "0x180A99D10")]
		public FallbackToOfflineMultiplayerOrientationSubRoom(IIDBRQOYHQN roomManager, UFFFZRRBPXW callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x89DDE20", Offset = "0x89DCA20", VA = "0x1889DDE20", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__4))]
		public Task<XXKAYQQDLZH.Result> SHHWOTVSNAS(HashSet<ZLMFXGCUQNE.Reason> a, CancellationToken b, ZLMFXGCUQNE.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal class FallbackToOnlineDormRoom : AGTPFQZYFEW, XXKAYQQDLZH
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class TBVOZRUCJVY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public MatchmakingErrorCode VBOHXXLMOUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public RoomInstance NUSLVFMHIDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public long AMPCNOMGVPX;

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public TBVOZRUCJVY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x89E95E0", Offset = "0x89E81E0", VA = "0x1889E95E0")]
			internal object GVDYHMYJSMG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x89E9660", Offset = "0x89E8260", VA = "0x1889E9660")]
			internal object GVJFETSHBXP()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private struct <RunFallback>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AsyncTaskMethodBuilder<XXKAYQQDLZH.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public FallbackToOnlineDormRoom <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public HashSet<ZLMFXGCUQNE.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TBVOZRUCJVY <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public ZLMFXGCUQNE.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private TaskAwaiter<MatchmakingErrorCode> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<XXKAYQQDLZH.Result> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x89F6AE0", Offset = "0x89F56E0", VA = "0x1889F6AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x89F77D0", Offset = "0x89F63D0", VA = "0x1889F77D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly HXFXHNYTPOW ECOIXTNYGAV;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		private string RDBCQXDHZII
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x89DDFF0", Offset = "0x89DCBF0", VA = "0x1889DDFF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x89DE1F0", Offset = "0x89DCDF0", VA = "0x1889DE1F0")]
		public FallbackToOnlineDormRoom([Inject(null)] IIDBRQOYHQN roomManager, [Inject(null)] UFFFZRRBPXW callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x89DE020", Offset = "0x89DCC20", VA = "0x1889DE020", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__5))]
		public Task<XXKAYQQDLZH.Result> SHHWOTVSNAS(HashSet<ZLMFXGCUQNE.Reason> a, CancellationToken b, ZLMFXGCUQNE.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal abstract class AGTPFQZYFEW
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private struct <DisconnectFromRoomInstance>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public Log log;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public HashSet<ZLMFXGCUQNE.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public AGTPFQZYFEW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private List<ZLMFXGCUQNE.Reason> <newDisconnectTriggers>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x89F1D70", Offset = "0x89F0970", VA = "0x1889F1D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x89F2290", Offset = "0x89F0E90", VA = "0x1889F2290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		protected readonly IIDBRQOYHQN PNSRTVKXRGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		protected readonly UFFFZRRBPXW TIDVWLUQWFP;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected IHOYXZOJIJC RRESXEGEGKR
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x89DD250", Offset = "0x89DBE50", VA = "0x1889DD250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA99D10", Offset = "0xA98910", VA = "0x180A99D10")]
		public AGTPFQZYFEW(IIDBRQOYHQN a, UFFFZRRBPXW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x89DD2A0", Offset = "0x89DBEA0", VA = "0x1889DD2A0")]
		[AsyncStateMachine(typeof(<DisconnectFromRoomInstance>d__5))]
		protected Task VKOYZPZEEUV(Log a, HashSet<ZLMFXGCUQNE.Reason> b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class TSDWWVWBIIP
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class VVHTIKYAJVS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public string KHYEFODMPZA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public IIDBRQOYHQN PNSRTVKXRGX;

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public VVHTIKYAJVS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x89FC790", Offset = "0x89FB390", VA = "0x1889FC790")]
			internal object YOHVJXXUEKD()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private struct <WaitForPlayerToSpawn>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public AsyncTaskMethodBuilder<XXKAYQQDLZH.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public UFFFZRRBPXW callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private float <timeoutTime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x89FB650", Offset = "0x89FA250", VA = "0x1889FB650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x89FB9D0", Offset = "0x89FA5D0", VA = "0x1889FB9D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static readonly float QBSAWVLPWHN;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		internal static readonly HashSet<ZLMFXGCUQNE.Reason> OFOWTNYWJQW;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x89EA060", Offset = "0x89E8C60", VA = "0x1889EA060")]
		[AsyncStateMachine(typeof(<WaitForPlayerToSpawn>d__2))]
		internal static Task<XXKAYQQDLZH.Result> EZHPEJDTDBG(UFFFZRRBPXW a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x89EA170", Offset = "0x89E8D70", VA = "0x1889EA170")]
		internal static void YZLRJMTBUND(IIDBRQOYHQN a, Log b, string c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal interface XXKAYQQDLZH
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public struct Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public bool success;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public ZLMFXGCUQNE.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public Enum? subReason;

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x89E2180", Offset = "0x89E0D80", VA = "0x1889E2180")]
			public static Result Success()
			{
				return default(Result);
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x89E2150", Offset = "0x89E0D50", VA = "0x1889E2150")]
			public static Result Failure(ZLMFXGCUQNE.Reason reason, [Optional] Enum? subReason)
			{
				return default(Result);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		string EBRWJPTPSLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<Result> SHHWOTVSNAS(HashSet<ZLMFXGCUQNE.Reason> a, CancellationToken b, ZLMFXGCUQNE.Reason c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal struct RestoreRecoveryAutosaveInRoomTask
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class VVHTIKYAJVS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public IIDBRQOYHQN KKNCQNIOILA;

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public VVHTIKYAJVS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x89FC890", Offset = "0x89FB490", VA = "0x1889FC890")]
			internal Task ZVPBBXVPTDI(CancellationToken a, int b, AccountRoleType c)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private struct <Run>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public RestoreRecoveryAutosaveInRoomTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private long <roomId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private long <subroomId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private QLEODJJBPHT <autosaveInfo>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private TaskAwaiter<LoadRecoveryAutosaveResponse> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private TaskAwaiter<WLRKHVLXMOD> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x89F7BC0", Offset = "0x89F67C0", VA = "0x1889F7BC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x89F8150", Offset = "0x89F6D50", VA = "0x1889F8150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private struct <WaitUntilWatchMenuIsReady>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public RestoreRecoveryAutosaveInRoomTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x89FBA40", Offset = "0x89FA640", VA = "0x1889FBA40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x89FBD50", Offset = "0x89FA950", VA = "0x1889FBD50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly IIDBRQOYHQN manager;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		private TSOFJGCPTYM WTNOWPRVTWZ
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x89E1A70", Offset = "0x89E0670", VA = "0x1889E1A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		private UFFFZRRBPXW SPGVRHHBWNH
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x89E1A20", Offset = "0x89E0620", VA = "0x1889E1A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private IHOYXZOJIJC RRESXEGEGKR
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x89E19A0", Offset = "0x89E05A0", VA = "0x1889E19A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private DNXBHPVLZPJ OXRKRFGOLPU
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x89E2100", Offset = "0x89E0D00", VA = "0x1889E2100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x28ABDA0", Offset = "0x28AA9A0", VA = "0x1828ABDA0")]
		public RestoreRecoveryAutosaveInRoomTask(CancellationToken cancellationToken, IIDBRQOYHQN manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x89E1AC0", Offset = "0x89E06C0", VA = "0x1889E1AC0")]
		public static InLoadedRoomTaskBuilder IWXKOSSKTXU(IIDBRQOYHQN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x89E1DF0", Offset = "0x89E09F0", VA = "0x1889E1DF0")]
		[AsyncStateMachine(typeof(<Run>d__4))]
		public Task<bool> Run()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x89E1BE0", Offset = "0x89E07E0", VA = "0x1889E1BE0")]
		private bool KZSQHAAZOGR([Out] QLEODJJBPHT a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x89E1F00", Offset = "0x89E0B00", VA = "0x1889E1F00")]
		[AsyncStateMachine(typeof(<WaitUntilWatchMenuIsReady>d__6))]
		private Task WZXNRDDIBWV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x89E1FD0", Offset = "0x89E0BD0", VA = "0x1889E1FD0")]
		private Task<LoadRecoveryAutosaveResponse> ZCSZKMZGZHK(QLEODJJBPHT a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal struct PendingRequest : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly XNZVOZBCXUJ pendingRequests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		private Task<(WLRKHVLXMOD, Task)> VEHTDVOTPMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x89DFA50", Offset = "0x89DE650", VA = "0x1889DFA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4FC2990", Offset = "0x4FC1590", VA = "0x184FC2990")]
		public PendingRequest(XNZVOZBCXUJ pendingRequests, Guid operationId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x89DFB20", Offset = "0x89DE720", VA = "0x1889DFB20")]
		public TaskAwaiter<(WLRKHVLXMOD, Task)> UCKUBDUZFPI()
		{
			return default(TaskAwaiter<(WLRKHVLXMOD, Task)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x89DF980", Offset = "0x89DE580", VA = "0x1889DF980", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal struct PendingRequestData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly TaskCompletionSource<(WLRKHVLXMOD, Task)> taskCompletion;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Task<(WLRKHVLXMOD, Task)> VEHTDVOTPMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x89DF7C0", Offset = "0x89DE3C0", VA = "0x1889DF7C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x89DF800", Offset = "0x89DE400", VA = "0x1889DF800")]
		public PendingRequestData(TimeSpan timeout)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x89DF5B0", Offset = "0x89DE1B0", VA = "0x1889DF5B0")]
		public void ANNNQDLCEOO(Task a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x89DF650", Offset = "0x89DE250", VA = "0x1889DF650")]
		public void KYGIFTZOQPG(WLRKHVLXMOD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x89DF770", Offset = "0x89DE370", VA = "0x1889DF770")]
		public void PYZOQXMVSRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x89DF6E0", Offset = "0x89DE2E0", VA = "0x1889DF6E0")]
		internal void OTKJMVRLWDQ(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class UCOKNTTHARZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x89FBF20", Offset = "0x89FAB20", VA = "0x1889FBF20")]
		public static RoomLoadRequestPayload VNXZELMWRKP(this RoomLoadRequestPayload a, RoomDetailsDTO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x89FBDB0", Offset = "0x89FA9B0", VA = "0x1889FBDB0")]
		public static RoomLoadRequestPayload BIUTWSUJVID(this RoomLoadRequestPayload a, SubRoomDataSaveDTO b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal sealed class SDFQTTQECJL : ACHQKVPRACK
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class TBVOZRUCJVY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public SubRoomDataSaveDTO VFMZQZBIVTX;

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public TBVOZRUCJVY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x89E9720", Offset = "0x89E8320", VA = "0x1889E9720")]
			internal bool NFYGVNUOPAV(SubRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly DJFXWYYSLCW RCNNIUYVMOC;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public SDFQTTQECJL(DJFXWYYSLCW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x89E9490", Offset = "0x89E8090", VA = "0x1889E9490", Slot = "4")]
		public RoomLoadRequestPayload Create(long superRoomId, long subRoomId, long subRoomDataSaveId, string studioSessionId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x89E8F50", Offset = "0x89E7B50", VA = "0x1889E8F50", Slot = "5")]
		public RoomLoadRequestPayload Create(long superRoomId, long subRoomId, FilenameWithHash superRoomData, Guid? snapshotId, long subRoomDataSaveId, bool loadUsedCompatibility)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x89E9320", Offset = "0x89E7F20", VA = "0x1889E9320", Slot = "6")]
		public RoomLoadRequestPayload Create(SaveSubRoomResponseDTO saveSubRoomResponseDTO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x89E90B0", Offset = "0x89E7CB0", VA = "0x1889E90B0", Slot = "7")]
		public RoomLoadRequestPayload Create(RoomDetailsDTO superRoom, SubRoomDataSaveDTO subRoomSave)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x89E9530", Offset = "0x89E8130", VA = "0x1889E9530")]
		private Guid? QLYECEBKXOT(RoomDetailsDTO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerActiveTask : OFZVAJIDTWP, BCVKRROGGDB, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private struct <RunAndSetCurrentTask>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public RoomManagerActiveTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string debugInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public Task innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x89F4800", Offset = "0x89F3400", VA = "0x1889F4800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x89F4E70", Offset = "0x89F3A70", VA = "0x1889F4E70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly Token CWMVSJNDWVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private string XMQAUHCVWSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private Task PAPOZRJWUKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private IIDBRQOYHQN PNSRTVKXRGX;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool XPAUDTWXSON
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x89E2510", Offset = "0x89E1110", VA = "0x1889E2510", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public Task JRHJMKSGOIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x89E2320", Offset = "0x89E0F20", VA = "0x1889E2320", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA98380", Offset = "0xA96F80", VA = "0x180A98380", Slot = "7")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x89E23B0", Offset = "0x89E0FB0", VA = "0x1889E23B0", Slot = "6")]
		public void IRGJSDJMPXS(Task a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x89E2200", Offset = "0x89E0E00", VA = "0x1889E2200")]
		[AsyncStateMachine(typeof(<RunAndSetCurrentTask>d__11))]
		private Task GCQKOQVBZMB(Task a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x89E2540", Offset = "0x89E1140", VA = "0x1889E2540")]
		public RoomManagerActiveTask()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	internal class XHDGAOOTOBL : BGKCZVBTBNY, BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool QIAJAMHIJTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private TNKKQUGAVHK RDWAFQOBCTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private TSOFJGCPTYM GWUBCTSVVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private DJFXWYYSLCW WMRFSTLEXNH;

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public TNKKQUGAVHK TNKKQUGAVHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x89FD020", Offset = "0x89FBC20", VA = "0x1889FD020", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x89FCEA0", Offset = "0x89FBAA0", VA = "0x1889FCEA0", Slot = "7")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x89FCCF0", Offset = "0x89FB8F0", VA = "0x1889FCCF0", Slot = "5")]
		public void GBQLXSZPUNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x89FCCB0", Offset = "0x89FB8B0", VA = "0x1889FCCB0", Slot = "6")]
		public void OAANOHUNGYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x89FCBF0", Offset = "0x89FB7F0", VA = "0x1889FCBF0")]
		private Task AHZDRBYCGUO(DisconnectCause a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x89FCCB0", Offset = "0x89FB8B0", VA = "0x1889FCCB0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public XHDGAOOTOBL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal class VFHBEYDDKPH : DJFXWYYSLCW
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		private class Config<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly LKPBYOVSSIG RGEXJSEYBJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly string QDRJQNEVYTI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly T HCVQUWIIBBD;

			[Cpp2IlInjected.Token(Token = "0x170000B5")]
			public T KBCQUAEOSXO
			{
				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0xAE9750", Offset = "0xAE8350", VA = "0x180AE9750")]
				[CompilerGenerated]
				get
				{
					return (T)null;
				}
				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0xAFCD80", Offset = "0xAFB980", VA = "0x180AFCD80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x3FE9D20", Offset = "0x3FE8920", VA = "0x183FE9D20")]
			public Config(LKPBYOVSSIG gameConfigsProvider, string key, T defaultValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x3FE99E0", Offset = "0x3FE85E0", VA = "0x183FE99E0")]
			private void OUEARCGOOWH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly LKPBYOVSSIG RGEXJSEYBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly Config<TimeSpan> QVJWJWYPCGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly Config<TimeSpan> WPLLYFHYZPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly Config<TimeSpan> ZVJFCSHNFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly Config<TimeSpan> GAPVEGUXQIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly Config<bool> HLGAIBMLTJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly Config<bool> IXIKPRHIXAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Config<bool> UGNFIGQDGEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Config<int> IKVETESYSPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private readonly Config<bool> EHSGCLTJKRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly Config<bool> HEPCLMLZABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly Config<PlatformMask> IARPDBLGEJK;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public TimeSpan XWSHVFOPKEA
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x89FC1E0", Offset = "0x89FADE0", VA = "0x1889FC1E0", Slot = "4")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public TimeSpan BXXHIVIQFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x89FC110", Offset = "0x89FAD10", VA = "0x1889FC110", Slot = "5")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public TimeSpan DAOEQLVASXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x89FC150", Offset = "0x89FAD50", VA = "0x1889FC150", Slot = "6")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public TimeSpan RXDDBVOOSZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x89FC0D0", Offset = "0x89FACD0", VA = "0x1889FC0D0", Slot = "7")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool SRLKBYWJOWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x89FC090", Offset = "0x89FAC90", VA = "0x1889FC090", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool STUWZFHNLBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x89FC050", Offset = "0x89FAC50", VA = "0x1889FC050", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool RQRLTWPIHNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x89FC2E0", Offset = "0x89FAEE0", VA = "0x1889FC2E0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public int RYIEXVOGQDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x89FC260", Offset = "0x89FAE60", VA = "0x1889FC260", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public bool TQUWILRGGXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x89FC2A0", Offset = "0x89FAEA0", VA = "0x1889FC2A0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public bool HRZLIQJNJND
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x89FC220", Offset = "0x89FAE20", VA = "0x1889FC220", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public bool TWYAOXRHSIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x89FC190", Offset = "0x89FAD90", VA = "0x1889FC190", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x89FC320", Offset = "0x89FAF20", VA = "0x1889FC320")]
		[UnityEngine.Scripting.Preserve]
		public VFHBEYDDKPH([Inject(null)] LKPBYOVSSIG gameConfigsProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomManagerEvents : VNLRTNXGPZT, BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private sealed class DKHGUFSJRQE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public RoomEvent LWHSLRNJDWY;

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public DKHGUFSJRQE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x89DD7A0", Offset = "0x89DC3A0", VA = "0x1889DD7A0")]
			internal object UAWXEDZZHQV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event RoomEventHandler BCZPGALIDMB
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x89E2760", Offset = "0x89E1360", VA = "0x1889E2760", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x89E2AA0", Offset = "0x89E16A0", VA = "0x1889E2AA0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event RoomEventHandler IHLEJMHZPVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x89E2670", Offset = "0x89E1270", VA = "0x1889E2670", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x89E2B40", Offset = "0x89E1740", VA = "0x1889E2B40", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event RoomEventHandler BXOURKVSDUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x89E2BE0", Offset = "0x89E17E0", VA = "0x1889E2BE0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x89E2CB0", Offset = "0x89E18B0", VA = "0x1889E2CB0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<RequestOperationType, bool> KDJGWLVLHYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x89E29C0", Offset = "0x89E15C0", VA = "0x1889E29C0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x89E25C0", Offset = "0x89E11C0", VA = "0x1889E25C0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "16")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x89E2A70", Offset = "0x89E1670", VA = "0x1889E2A70", Slot = "12")]
		public void RBXTXFRKOBT(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x89E2D50", Offset = "0x89E1950", VA = "0x1889E2D50", Slot = "13")]
		public void ZIXNNDWCZQB(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x89E2C80", Offset = "0x89E1880", VA = "0x1889E2C80", Slot = "14")]
		public void XMCMWIQOQXX(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x89E2710", Offset = "0x89E1310", VA = "0x1889E2710", Slot = "15")]
		public void ENJWDGENTYZ(RequestOperationType a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x89E2800", Offset = "0x89E1400", VA = "0x1889E2800")]
		private void Invoke(RoomEventHandler handler, RoomEvent roomEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public RoomManagerEvents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomManagerFallbacks : WVAADYFIYNV, BCVKRROGGDB, IDisposable, ZLMFXGCUQNE
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		private class RFVRJNPBODQ : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class QDZMHQJBVSL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				public ZLMFXGCUQNE.FallbackReason JHDZJBIHWGH;

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
				public QDZMHQJBVSL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x89DFB70", Offset = "0x89DE770", VA = "0x1889DFB70")]
				internal object RRYMLNTOZTP((ZLMFXGCUQNE.Reason fallbackReason, RoomDTO roomDto, TKCTMBSNACQ state, string subReason) x)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000074")]
			[CompilerGenerated]
			private sealed class IBVXBRAKPLN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public XXKAYQQDLZH GAANBRMKDVO;

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
				public IBVXBRAKPLN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x89DE310", Offset = "0x89DCF10", VA = "0x1889DE310")]
				internal object BMDOIDNZLLU()
				{
					return null;
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000075")]
			[CompilerGenerated]
			private struct <RunFallbackSequence>d__16 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public RFVRJNPBODQ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				public ZLMFXGCUQNE.FallbackReason reason;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				private LogRangeScope <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				private XXKAYQQDLZH[] <>7__wrap2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				private int <>7__wrap3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				private TaskAwaiter<XXKAYQQDLZH.Result> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x89F4ED0", Offset = "0x89F3AD0", VA = "0x1889F4ED0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x89F5650", Offset = "0x89F4250", VA = "0x1889F5650", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private struct <TryRunFallback>d__17 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400013A")]
				public AsyncTaskMethodBuilder<XXKAYQQDLZH.Result> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400013B")]
				public XXKAYQQDLZH fallbackProvider;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public RFVRJNPBODQ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				public ZLMFXGCUQNE.FallbackReason reason;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				private LogRangeScope <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				private TKCTMBSNACQ <individualFallbackTaskState>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				private TaskAwaiter<XXKAYQQDLZH.Result> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x89F9B00", Offset = "0x89F8700", VA = "0x1889F9B00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x89FA790", Offset = "0x89F9390", VA = "0x1889FA790", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Task UHDBNRIZGPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public CancellationTokenSource TZBYEYPXIHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public TKCTMBSNACQ DRBYAXUOQRE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public UFFFZRRBPXW TIDVWLUQWFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public RoomDTO BJYWAMGBLUZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public RoomInstance PQADHRKPQQT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public XXKAYQQDLZH[] YMRAPQUNUCB;

			[Cpp2IlInjected.Token(Token = "0x170000B9")]
			public bool NKEZNUYAGGQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x89E11E0", Offset = "0x89DFDE0", VA = "0x1889E11E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BA")]
			public bool XMZCZCKAJEU
			{
				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x89E0FA0", Offset = "0x89DFBA0", VA = "0x1889E0FA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x89E1810", Offset = "0x89E0410", VA = "0x1889E1810")]
			public RFVRJNPBODQ(UFFFZRRBPXW a, RoomDTO b, RoomInstance c, XXKAYQQDLZH[] d, CancellationToken e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x89E0450", Offset = "0x89DF050", VA = "0x1889E0450", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x89E05E0", Offset = "0x89DF1E0", VA = "0x1889E05E0")]
			public void FHUYEOFNTEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x89E08D0", Offset = "0x89DF4D0", VA = "0x1889E08D0")]
			public void IPNWREDWAST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x89E1200", Offset = "0x89DFE00", VA = "0x1889E1200")]
			public void TNIVPFEDDZW(ZLMFXGCUQNE.Reason a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x89E10D0", Offset = "0x89DFCD0", VA = "0x1889E10D0")]
			[AsyncStateMachine(typeof(<RunFallbackSequence>d__16))]
			public Task SPKVKWNBGDJ(ZLMFXGCUQNE.FallbackReason a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x89E0B50", Offset = "0x89DF750", VA = "0x1889E0B50")]
			[AsyncStateMachine(typeof(<TryRunFallback>d__17))]
			private Task<XXKAYQQDLZH.Result> PFAPJOJEYEL(ZLMFXGCUQNE.FallbackReason a, XXKAYQQDLZH b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x89E16F0", Offset = "0x89E02F0", VA = "0x1889E16F0")]
			private void XUVAJZRHMGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x89E0650", Offset = "0x89DF250", VA = "0x1889E0650")]
			public bool FMJZJZMYVJL(ZLMFXGCUQNE.Reason a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x89E01C0", Offset = "0x89DEDC0", VA = "0x1889E01C0")]
			private void CDHPBWYQAFN(TKCTMBSNACQ a, ZLMFXGCUQNE.FallbackReason b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x89E0700", Offset = "0x89DF300", VA = "0x1889E0700")]
			private void ICTMLYCJEWA(TKCTMBSNACQ a, XXKAYQQDLZH.Result b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x89E0E00", Offset = "0x89DFA00", VA = "0x1889E0E00")]
			private void PYPGIJTWMUI(TKCTMBSNACQ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x89DFDF0", Offset = "0x89DE9F0", VA = "0x1889DFDF0")]
			private void BIXQUZETBAF(TKCTMBSNACQ a, XXKAYQQDLZH.Result b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x89E0CA0", Offset = "0x89DF8A0", VA = "0x1889E0CA0")]
			private void PKACRLJGDKW(TKCTMBSNACQ a, Exception b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x89E0FC0", Offset = "0x89DFBC0", VA = "0x1889E0FC0")]
			private void RXCIBRXBARR(XXKAYQQDLZH a, ZLMFXGCUQNE.FallbackReason b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x89E0A40", Offset = "0x89DF640", VA = "0x1889E0A40")]
			private void JXAGQHPAQNX(XXKAYQQDLZH a, ZLMFXGCUQNE.Reason b, string c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x89E14C0", Offset = "0x89E00C0", VA = "0x1889E14C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public class TKCTMBSNACQ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Task<XXKAYQQDLZH.Result> UHDBNRIZGPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public CancellationTokenSource TZBYEYPXIHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public XXKAYQQDLZH GAANBRMKDVO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public ZLMFXGCUQNE.Reason NAYCMJNMSPS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public HashSet<ZLMFXGCUQNE.Reason> UWPMTPLTMPJ;

			[Cpp2IlInjected.Token(Token = "0x170000BB")]
			public bool NKEZNUYAGGQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x89E11E0", Offset = "0x89DFDE0", VA = "0x1889E11E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BC")]
			public bool XMZCZCKAJEU
			{
				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x89E0FA0", Offset = "0x89DFBA0", VA = "0x1889E0FA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x89E9C30", Offset = "0x89E8830", VA = "0x1889E9C30")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x89E9DA0", Offset = "0x89E89A0", VA = "0x1889E9DA0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x89E9DC0", Offset = "0x89E89C0", VA = "0x1889E9DC0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x89E9FE0", Offset = "0x89E8BE0", VA = "0x1889E9FE0")]
			public TKCTMBSNACQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class WYITCQAWRUI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public ZLMFXGCUQNE.Reason JHDZJBIHWGH;

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public WYITCQAWRUI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x89FC9C0", Offset = "0x89FB5C0", VA = "0x1889FC9C0")]
			internal object EZIFSXWLGRY(TKCTMBSNACQ a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x89FC950", Offset = "0x89FB550", VA = "0x1889FC950")]
			internal object EZCYVRCNXGP(RFVRJNPBODQ a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x89FC8E0", Offset = "0x89FB4E0", VA = "0x1889FC8E0")]
			internal object EYXRYKIQNVG()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private struct <BlockWhilePreviousFallbackSequenceIsPendingCancellation>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public RoomManagerFallbacks <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x89EA400", Offset = "0x89E9000", VA = "0x1889EA400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x89EA970", Offset = "0x89E9570", VA = "0x1889EA970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private struct <StartRunningFallbacks>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public RoomManagerFallbacks <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public ZLMFXGCUQNE.FallbackReason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private RFVRJNPBODQ <localTaskState>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x89F81C0", Offset = "0x89F6DC0", VA = "0x1889F81C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x89F8E50", Offset = "0x89F7A50", VA = "0x1889F8E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private struct <TriggerFallback>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public ZLMFXGCUQNE.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public RoomManagerFallbacks <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			private WYITCQAWRUI <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public Exception exception;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x89F8EB0", Offset = "0x89F7AB0", VA = "0x1889F8EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x89F9AA0", Offset = "0x89F86A0", VA = "0x1889F9AA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		internal static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		internal static readonly Log ABDAYCEPDJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private IIDBRQOYHQN PNSRTVKXRGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private UFFFZRRBPXW TIDVWLUQWFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private RFVRJNPBODQ NXWTFWQYKWK;

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private IHOYXZOJIJC RRESXEGEGKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x89E2D80", Offset = "0x89E1980", VA = "0x1889E2D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public bool VLPJMVGTROH
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x1E47820", Offset = "0x1E46420", VA = "0x181E47820", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool NESGTUZJNMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x89E3800", Offset = "0x89E2400", VA = "0x1889E3800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x89E3230", Offset = "0x89E1E30", VA = "0x1889E3230", Slot = "6")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x89E3020", Offset = "0x89E1C20", VA = "0x1889E3020", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x89E2DD0", Offset = "0x89E19D0", VA = "0x1889E2DD0", Slot = "9")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x89E3150", Offset = "0x89E1D50", VA = "0x1889E3150")]
		private bool IPAJVBRRICB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x89E2F50", Offset = "0x89E1B50", VA = "0x1889E2F50", Slot = "5")]
		private void DCAHMWZLVVX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x89E3030", Offset = "0x89E1C30", VA = "0x1889E3030", Slot = "8")]
		[AsyncStateMachine(typeof(<TriggerFallback>d__14))]
		public Task EEBCBRILQLR(ZLMFXGCUQNE.Reason a, [Optional] Exception b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x89E3870", Offset = "0x89E2470", VA = "0x1889E3870")]
		private bool RCCMVODLFSD(ZLMFXGCUQNE.FallbackReason a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x89E32B0", Offset = "0x89E1EB0", VA = "0x1889E32B0")]
		private XXKAYQQDLZH[] KACYENHCGJB(RoomInstance a, RoomDTO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x89E3B70", Offset = "0x89E2770", VA = "0x1889E3B70")]
		[AsyncStateMachine(typeof(<StartRunningFallbacks>d__19))]
		private Task StartRunningFallbacks(ZLMFXGCUQNE.FallbackReason reason, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x89E3730", Offset = "0x89E2330", VA = "0x1889E3730")]
		[AsyncStateMachine(typeof(<BlockWhilePreviousFallbackSequenceIsPendingCancellation>d__20))]
		private Task OCDTHCWFSJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public RoomManagerFallbacks()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerInitialRoomLoad : MWFWDBGDAHR, BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class KRFKZYGPKGU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public Matchmaking.GameJoinResult XHLRNGOMZSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public ErrorCode HSYKAUVETFY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public Exception WSMDIYHYEOO;

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public KRFKZYGPKGU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x89DE6C0", Offset = "0x89DD2C0", VA = "0x1889DE6C0")]
			internal object NJOMGCGNWMQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private sealed class KUTTTMDWXQK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public Task<RoomLoadRequestPayload> IGFNKWTVQAE;

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public KUTTTMDWXQK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			internal Task<RoomLoadRequestPayload> YZDEHBLIXGV(StackTimer<string>.USVZTROCTRS a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class DLPGKOPGKSV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public Task<RoomLoadRequestPayload> IGFNKWTVQAE;

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public DLPGKOPGKSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			internal Task<RoomLoadRequestPayload> FOEFVDZXTGV(StackTimer<string>.USVZTROCTRS a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class IYUJLYMVERT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public Task RJAMHPHVBJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public RoomInstance NUSLVFMHIDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public bool PGUVRZSNQPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public Task CXIIWJXTODL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public Task EGQZGUXJDPL;

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public IYUJLYMVERT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x89DE510", Offset = "0x89DD110", VA = "0x1889DE510")]
			internal object FWFLRJZNZJP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x89DE420", Offset = "0x89DD020", VA = "0x1889DE420")]
			internal string FWAEUDFQPYG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class XCJSOMENECY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public RoomInstance NUSLVFMHIDP;

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XCJSOMENECY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x89FCA30", Offset = "0x89FB630", VA = "0x1889FCA30")]
			internal object FOLVTTHIMUV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class IEFTSSQGWNV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public long YRNIGZUXGQA;

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public IEFTSSQGWNV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x89DE390", Offset = "0x89DCF90", VA = "0x1889DE390")]
			internal void QPMWYBJDJJK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class ZLIKEMGACVF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public RoomInstance NUSLVFMHIDP;

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public ZLIKEMGACVF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x89FD2C0", Offset = "0x89FBEC0", VA = "0x1889FD2C0")]
			internal object RDFAHMTQQRF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class EEUGKQXOITW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public RoomInstance NUSLVFMHIDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public Task EGQZGUXJDPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public Task RJAMHPHVBJT;

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public EEUGKQXOITW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x89DD870", Offset = "0x89DC470", VA = "0x1889DD870")]
			internal string NMNDBPLGABT()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		[CompilerGenerated]
		private struct <CheckForRoomDataOutOfDate>d__52 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public int roomTotalVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public AccountRoleType localPlayerAccountRoleType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			private TaskAwaiter<WLRKHVLXMOD> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x89EA9D0", Offset = "0x89E95D0", VA = "0x1889EA9D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x89EB140", Offset = "0x89E9D40", VA = "0x1889EB140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private struct <ConnectToPhoton>d__47 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public StackTimer<string>.USVZTROCTRS timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public Matchmaking.ServerConnectionInfoDTO serverConnectionInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public AFCWAAKQTIP joinRoomInstancePauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public CancellationToken roomCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private TaskAwaiter<KDLZAIJIGGQ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x89EBBD0", Offset = "0x89EA7D0", VA = "0x1889EBBD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x89EC2D0", Offset = "0x89EAED0", VA = "0x1889EC2D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private struct <ConnectToRoomAndRunLoadLogic>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public StackTimer<string>.USVZTROCTRS timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public FWSYDBCYQHV customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public AFCWAAKQTIP joinRoomInstancePauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			private KUTTTMDWXQK <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private XIXSZZOTXCN <multiProgressTracker>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			private IDisposable <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			private StackTimer<string>.USVZTROCTRS <connectToRoomAndRunLoadLogicTimer>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			private CancellationTokenSource <roomTokenSource>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			private CancellationTokenRegistration <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private CancellationToken <roomCancellationToken>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private KLHAZPAKHTU <preOperationProgressTracker>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private Task<Matchmaking.ServerConnectionInfoDTO> <serverConnectionInfoTask>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private BVUYRSNDGRM <>7__wrap10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private CancellationTokenSource <cameraFadeCts>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			private int <i>5__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			private TaskAwaiter<Matchmaking.ServerConnectionInfoDTO> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private CancellationToken <photonJoinedToken>5__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			private Task <roomLoadTask>5__16;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			private TaskAwaiter<RoomLoadRequestPayload> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x89EC330", Offset = "0x89EAF30", VA = "0x1889EC330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x89F1D10", Offset = "0x89F0910", VA = "0x1889F1D10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private struct <CreateRoomDiContainer>d__44 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private URVRSSRGCJF <roomContainer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x8A06750", Offset = "0x8A05350", VA = "0x188A06750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x8A06BD0", Offset = "0x8A057D0", VA = "0x188A06BD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct <FastPath_ConnectToRoomAndRunLoadLogic>d__35 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public StackTimer<string>.USVZTROCTRS timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public FWSYDBCYQHV customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public AFCWAAKQTIP joinRoomInstancePauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			private XIXSZZOTXCN <multiProgressTracker>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private IDisposable <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			private StackTimer<string>.USVZTROCTRS <connectToRoomAndRunLoadLogicTimer>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			private CancellationTokenSource <roomTokenSource>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			private CancellationTokenRegistration <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			private CancellationToken <roomCancellationToken>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private KLHAZPAKHTU <preOperationProgressTracker>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			private Task<Matchmaking.ServerConnectionInfoDTO> <serverConnectionInfoTask>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			private RoomLoadRequestPayload <initialRoomLoadPayload>5__11;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			private AHNXITVISXR <preloadContext>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			private TaskAwaiter<RoomLoadRequestPayload> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			private BVUYRSNDGRM <>7__wrap12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			private Task <loadEmptySceneTask>5__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			private ZLKCXKLTDHW <sceneManagementService>5__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private HCSKYPDPHUA <scenePreloadRequest>5__16;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			private CancellationTokenSource <cameraFadeCts>5__17;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap17;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			private TaskAwaiter<RoomLoadDetails> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			private int <i>5__19;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			private YieldAwaitable.YieldAwaiter <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			private TaskAwaiter<Matchmaking.ServerConnectionInfoDTO> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			private CancellationToken <photonJoinedToken>5__20;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			private Task <roomLoadTask>5__21;

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8A06C30", Offset = "0x8A05830", VA = "0x188A06C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x8A0C170", Offset = "0x8A0AD70", VA = "0x188A0C170", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private struct <GetServerConnectionInfo>d__45 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public AsyncTaskMethodBuilder<Matchmaking.ServerConnectionInfoDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public StackTimer<string>.USVZTROCTRS timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			private TaskAwaiter<Matchmaking.ServerConnectionInfoDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8A0EA60", Offset = "0x8A0D660", VA = "0x188A0EA60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x8A0EF30", Offset = "0x8A0DB30", VA = "0x188A0EF30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private struct <JoinRoomInstance>d__30 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public FWSYDBCYQHV customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x8A0EFA0", Offset = "0x8A0DBA0", VA = "0x188A0EFA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x8A0F550", Offset = "0x8A0E150", VA = "0x188A0F550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private struct <JoinRoomLoadWithPhoton>d__48 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public Task roomLoadTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			private IYUJLYMVERT <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public CancellationTokenSource roomLoadTokenSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			private TaskAwaiter<Task> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			private object <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8A0F5B0", Offset = "0x8A0E1B0", VA = "0x188A0F5B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8A10120", Offset = "0x8A0ED20", VA = "0x188A10120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private struct <RunRoomLoadLogic>d__49 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public StackTimer<string>.USVZTROCTRS timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public AFCWAAKQTIP joinRoomInstanceToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public CancellationToken roomJoinCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			public RoomLoadRequestPayload initialRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			public RoomInstance targetRoomInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public AHNXITVISXR preloadContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public XIXSZZOTXCN progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			private StackTimer<string>.USVZTROCTRS <roomLoadLogicTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8A166B0", Offset = "0x8A152B0", VA = "0x188A166B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x8A16EA0", Offset = "0x8A15AA0", VA = "0x188A16EA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private struct <SpawnLocalPlayer>d__51 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public StackTimer<string>.USVZTROCTRS timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private StackTimer<string>.USVZTROCTRS <spawnLocalPlayerTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			private LogRangeScope <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			private int <i>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private LogRangeScope <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			private CancellationTokenSource <timeoutTcs>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			private CancellationToken <timeoutToken>5__8;

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8A16F00", Offset = "0x8A15B00", VA = "0x188A16F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x8A186F0", Offset = "0x8A172F0", VA = "0x188A186F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct <TryDisconnectFromCurrentRoomInstance>d__37 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			public StackTimer<string>.USVZTROCTRS timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private StackTimer<string>.USVZTROCTRS <disconnectTimerScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private object <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private int <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap5;

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x8A18FE0", Offset = "0x8A17BE0", VA = "0x188A18FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x8A19A50", Offset = "0x8A18650", VA = "0x188A19A50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private struct <TryJoinRoomInstance>d__31 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			public FWSYDBCYQHV customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400022B")]
			private StackTimer<string> <timer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			private LogRangeScope <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			private AFCWAAKQTIP <joinRoomInstancePauseToken>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			private PWHWXFVVGJJ <analyticsData>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x8A1AA70", Offset = "0x8A19670", VA = "0x188A1AA70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x8A1B8E0", Offset = "0x8A1A4E0", VA = "0x188A1B8E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly Log URVAOZGLMAK;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly Log IWQVMNUOHVQ;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly Log HQOLYTXCHFI;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly string ICITHTLLNCP;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly string ZLPVEPHMRZB;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly string DAKMJIEDWCU;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly Guid OXKAGCDZRJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private JKPIQQXIFJL LKGEIDUUUVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private TBEXYEJQNFS YKABCEEKPYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private TSOFJGCPTYM GWUBCTSVVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private IIDBRQOYHQN PNSRTVKXRGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private UFFFZRRBPXW TIDVWLUQWFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private WVAADYFIYNV LXGRXYJIXSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private OFZVAJIDTWP WMVAHRTVTQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private VNLRTNXGPZT FXQWUGMRPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TLMPALUKRRW WCRZDYHYTTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private NEECCIUHZQD HGZAHOSBNDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private IDisposable LXRYVTZFTNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private TIKAXYDLCSO WSLPDFLOPJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private readonly Token XSJLIAHJEYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private BVUYRSNDGRM LRSOKKPUBRH;

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public TaskStatus PQFXGNBDRYV
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xF98A30", Offset = "0xF97630", VA = "0x180F98A30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TaskStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x1535020", Offset = "0x1533C20", VA = "0x181535020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private IHOYXZOJIJC RRESXEGEGKR
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x89E3E80", Offset = "0x89E2A80", VA = "0x1889E3E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x89E5020", Offset = "0x89E3C20", VA = "0x1889E5020", Slot = "6")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x89E4030", Offset = "0x89E2C30", VA = "0x1889E4030", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x89E5470", Offset = "0x89E4070", VA = "0x1889E5470", Slot = "5")]
		[AsyncStateMachine(typeof(<JoinRoomInstance>d__30))]
		public Task JoinRoomInstance(RoomInstance targetInstance, FWSYDBCYQHV customRoomLoadPayload, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x89E4540", Offset = "0x89E3140", VA = "0x1889E4540")]
		[AsyncStateMachine(typeof(<TryJoinRoomInstance>d__31))]
		private Task HFFVNPDEGUI(RoomInstance a, FWSYDBCYQHV b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x89E5A00", Offset = "0x89E4600", VA = "0x1889E5A00")]
		private void LBSIMYLWAQE(TLMPALUKRRW a, RoomInstance b, Exception c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x89E4790", Offset = "0x89E3390", VA = "0x1889E4790")]
		private static void HXMZEEKJIHI(PWHWXFVVGJJ a, Exception b, [Optional] List<int> c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x89E3ED0", Offset = "0x89E2AD0", VA = "0x1889E3ED0")]
		[AsyncStateMachine(typeof(<ConnectToRoomAndRunLoadLogic>d__34))]
		private Task ConnectToRoomAndRunLoadLogic(StackTimer<string>.USVZTROCTRS timer, RoomInstance targetInstance, FWSYDBCYQHV customRoomLoadPayload, AFCWAAKQTIP joinRoomInstancePauseToken, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x89E4280", Offset = "0x89E2E80", VA = "0x1889E4280")]
		[AsyncStateMachine(typeof(<FastPath_ConnectToRoomAndRunLoadLogic>d__35))]
		private Task FastPath_ConnectToRoomAndRunLoadLogic(StackTimer<string>.USVZTROCTRS timer, RoomInstance targetInstance, FWSYDBCYQHV customRoomLoadPayload, AFCWAAKQTIP joinRoomInstancePauseToken, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x89E61F0", Offset = "0x89E4DF0", VA = "0x1889E61F0")]
		private void NQQIHRNBZAS([CallerMemberName] string caller = "<unknown>")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x89E6460", Offset = "0x89E5060", VA = "0x1889E6460")]
		[AsyncStateMachine(typeof(<TryDisconnectFromCurrentRoomInstance>d__37))]
		private Task PNWLHEDOUVR(StackTimer<string>.USVZTROCTRS a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x89E71E0", Offset = "0x89E5DE0", VA = "0x1889E71E0")]
		private void XQPOJGAJQDB(RoomInstance a, CancellationToken b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x89E5790", Offset = "0x89E4390", VA = "0x1889E5790")]
		private void LACFZVEKTTV(RoomInstance a, TaskStatus b, string c, AFCWAAKQTIP d, Exception e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x89E6CF0", Offset = "0x89E58F0", VA = "0x1889E6CF0")]
		private void VXZVFMCOPTK(RoomInstance a, AFCWAAKQTIP b, OperationCanceledException c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x89E6170", Offset = "0x89E4D70", VA = "0x1889E6170")]
		private void NQHGDEWKFKU(RoomInstance a, AFCWAAKQTIP b, Exception c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x89E6FD0", Offset = "0x89E5BD0", VA = "0x1889E6FD0")]
		private void XJZPDYCOHWA(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x89E4FC0", Offset = "0x89E3BC0", VA = "0x1889E4FC0")]
		private static RoomEvent HZNOLMQEZOA(RoomInstance a)
		{
			return default(RoomEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x89E53A0", Offset = "0x89E3FA0", VA = "0x1889E53A0")]
		[AsyncStateMachine(typeof(<CreateRoomDiContainer>d__44))]
		private Task JQCWTMGAJHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x89E43E0", Offset = "0x89E2FE0", VA = "0x1889E43E0")]
		[AsyncStateMachine(typeof(<GetServerConnectionInfo>d__45))]
		private Task<Matchmaking.ServerConnectionInfoDTO> GetServerConnectionInfo(RoomInstance targetInstance, StackTimer<string>.USVZTROCTRS timer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x89E6D70", Offset = "0x89E5970", VA = "0x1889E6D70")]
		private static KDLZAIJIGGQ WYZKEPIEIGM(Matchmaking.ServerConnectionInfoDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x89E6E80", Offset = "0x89E5A80", VA = "0x1889E6E80")]
		[AsyncStateMachine(typeof(<ConnectToPhoton>d__47))]
		private Task XDJWRXXAURG(Matchmaking.ServerConnectionInfoDTO a, AFCWAAKQTIP b, StackTimer<string>.USVZTROCTRS c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x89E5FA0", Offset = "0x89E4BA0", VA = "0x1889E5FA0")]
		[AsyncStateMachine(typeof(<JoinRoomLoadWithPhoton>d__48))]
		private Task MOXTSQDENRE(RoomInstance a, CancellationTokenSource b, Task c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x89E6930", Offset = "0x89E5530", VA = "0x1889E6930")]
		[AsyncStateMachine(typeof(<RunRoomLoadLogic>d__49))]
		private Task RunRoomLoadLogic(RoomLoadRequestPayload initialRoomLoadPayload, XIXSZZOTXCN progressTracker, RoomInstance targetRoomInstance, AFCWAAKQTIP joinRoomInstanceToken, StackTimer<string>.USVZTROCTRS timer, CancellationToken roomJoinCancellationToken, [Optional] AHNXITVISXR preloadContext)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x89E55B0", Offset = "0x89E41B0", VA = "0x1889E55B0")]
		private AFCWAAKQTIP KBACPCHCQIF(AFCWAAKQTIP a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x89E6AB0", Offset = "0x89E56B0", VA = "0x1889E6AB0")]
		[AsyncStateMachine(typeof(<SpawnLocalPlayer>d__51))]
		private Task SpawnLocalPlayer(StackTimer<string>.USVZTROCTRS timer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x89E3D50", Offset = "0x89E2950", VA = "0x1889E3D50")]
		[AsyncStateMachine(typeof(<CheckForRoomDataOutOfDate>d__52))]
		private Task ANYIBOUVMEQ(CancellationToken a, int b, AccountRoleType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x89E4080", Offset = "0x89E2C80", VA = "0x1889E4080")]
		private static void EEMIRUKBGEN(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x89E6710", Offset = "0x89E5310", VA = "0x1889E6710")]
		private void QLUDPFOQVEQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x89E41F0", Offset = "0x89E2DF0", VA = "0x1889E41F0")]
		private void EIBIXSLXGZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x89E60E0", Offset = "0x89E4CE0", VA = "0x1889E60E0")]
		private void NIJEABGZPMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x89E63D0", Offset = "0x89E4FD0", VA = "0x1889E63D0")]
		private void PBSMBOGRDWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x89E5E50", Offset = "0x89E4A50", VA = "0x1889E5E50")]
		private static void LZYAVPTPBGD(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x89E4690", Offset = "0x89E3290", VA = "0x1889E4690")]
		private static CancellationTokenRegistration HWUUFIJCTVS(RoomInstance a, CancellationToken b)
		{
			return default(CancellationTokenRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x89E6BF0", Offset = "0x89E57F0", VA = "0x1889E6BF0")]
		private static void VJKDTPWHIKF(RoomInstance a, Exception b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x89E6590", Offset = "0x89E5190", VA = "0x1889E6590")]
		private void QHJQNPJYTSX(RoomInstance a, Task b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x89E5F40", Offset = "0x89E4B40", VA = "0x1889E5F40")]
		private static void Log(Func<string> msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x89E7730", Offset = "0x89E6330", VA = "0x1889E7730")]
		public RoomManagerInitialRoomLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x89E6370", Offset = "0x89E4F70", VA = "0x1889E6370")]
		[CompilerGenerated]
		internal static (int, int?) NRKOORGQZRS(ErrorCode a)
		{
			return default((int, int?));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerInRoomTasks : WVULOYQAUQS, BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class NLQFCTBILOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public RoomManagerInRoomTasks BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			public int RQZEYCCIORE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000238")]
			public AccountRoleType JEQDIHUBHUO;

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public NLQFCTBILOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x89FE4D0", Offset = "0x89FD0D0", VA = "0x1889FE4D0")]
			internal List<Task> AHYZCBUFVAJ(CancellationToken a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private struct <RunInRoomTaskAsync>d__15 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400023A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400023B")]
			public RoomManagerInRoomTasks <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			public int roomTotalVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			public AccountRoleType localPlayerAccountRoleType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400023E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x8A14620", Offset = "0x8A13220", VA = "0x188A14620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x8A14AF0", Offset = "0x8A136F0", VA = "0x188A14AF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private struct <WaitAndLog>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400023F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000240")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public InLoadedRoomTaskBuilder taskBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000242")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000243")]
			public int roomTotalVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000244")]
			public AccountRoleType localPlayerAccountRoleType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000245")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000246")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x8A1BD80", Offset = "0x8A1A980", VA = "0x188A1BD80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x8A1C120", Offset = "0x8A1AD20", VA = "0x188A1C120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private struct <WaitForPhotonAndCancel>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000247")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000248")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000249")]
			public RoomManagerInRoomTasks <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400024A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x8A1C180", Offset = "0x8A1AD80", VA = "0x188A1C180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x8A1C430", Offset = "0x8A1B030", VA = "0x188A1C430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private readonly HashSet<InLoadedRoomTaskBuilder> NTUABCMYJLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private TBEXYEJQNFS YKABCEEKPYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private IIDBRQOYHQN PNSRTVKXRGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private WBHGJFMWGKA CGVELHERLVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskRunner YJRLYFZXNMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private IDisposable LXRYVTZFTNA;

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x89FEC80", Offset = "0x89FD880", VA = "0x1889FEC80", Slot = "5")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x89FEB50", Offset = "0x89FD750", VA = "0x1889FEB50", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x89FF620", Offset = "0x89FE220", VA = "0x1889FF620", Slot = "4")]
		public bool WFITHVEBNVA(InLoadedRoomTaskBuilder a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x89FEA00", Offset = "0x89FD600", VA = "0x1889FEA00")]
		private void CROFOWNEZOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x89FF680", Offset = "0x89FE280", VA = "0x1889FF680")]
		private void WLUTIMOXSEJ(HQPJHIWQEWM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x89FF460", Offset = "0x89FE060", VA = "0x1889FF460")]
		[AsyncStateMachine(typeof(<RunInRoomTaskAsync>d__15))]
		private Task SIQYXBVTOOL(int a, AccountRoleType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x89FF550", Offset = "0x89FE150", VA = "0x1889FF550")]
		private Func<CancellationToken, List<Task>> SOHINZMAXJZ(int a, AccountRoleType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x89FEF50", Offset = "0x89FDB50", VA = "0x1889FEF50")]
		private List<Task> KDECAJROAIH(int a, AccountRoleType b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x89FF8A0", Offset = "0x89FE4A0", VA = "0x1889FF8A0")]
		[AsyncStateMachine(typeof(<WaitAndLog>d__18))]
		private Task XAVKTWLAFML(InLoadedRoomTaskBuilder a, CancellationToken b, int c, AccountRoleType d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x89FEBB0", Offset = "0x89FD7B0", VA = "0x1889FEBB0")]
		[AsyncStateMachine(typeof(<WaitForPhotonAndCancel>d__19))]
		private Task IXTIWTYKJDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x89FEAD0", Offset = "0x89FD6D0", VA = "0x1889FEAD0")]
		private void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x89FF9C0", Offset = "0x89FE5C0", VA = "0x1889FF9C0")]
		public RoomManagerInRoomTasks()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerPendingRequests : XNZVOZBCXUJ, BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class OIJSTNCODXH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			public Guid MZSFQTMTWSV;

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public OIJSTNCODXH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x89FE780", Offset = "0x89FD380", VA = "0x1889FE780")]
			internal object LISDSAPGHPA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[CompilerGenerated]
		private sealed class TBVOZRUCJVY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400024E")]
			public Guid MZSFQTMTWSV;

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public TBVOZRUCJVY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x8A066F0", Offset = "0x8A052F0", VA = "0x188A066F0")]
			internal object WFXZNUKDDPX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class XVCGTKCCKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XVCGTKCCKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class JWFSMWPDEJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			public Guid MZSFQTMTWSV;

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public JWFSMWPDEJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x89FE010", Offset = "0x89FCC10", VA = "0x1889FE010")]
			internal object LLMFIQQAMCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class XYQPMXZJXMZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			public Guid MZSFQTMTWSV;

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XYQPMXZJXMZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x8A1C630", Offset = "0x8A1B230", VA = "0x188A1C630")]
			internal object OYNHMBGZWKV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly Dictionary<Guid, PendingRequestData> SAISMVEVFSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private readonly TimeSpan CRRVUZCCRCD;

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "9")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x89FFFF0", Offset = "0x89FEBF0", VA = "0x1889FFFF0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x89FFA40", Offset = "0x89FE640", VA = "0x1889FFA40", Slot = "4")]
		public PendingRequest Add(Guid operationId)
		{
			return default(PendingRequest);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8A00230", Offset = "0x89FEE30", VA = "0x188A00230", Slot = "5")]
		public bool Remove(Guid operationId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x89FFCC0", Offset = "0x89FE8C0", VA = "0x1889FFCC0", Slot = "6")]
		public bool DYSQJNTTXVV(Guid a, Task b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8A00430", Offset = "0x89FF030", VA = "0x188A00430", Slot = "7")]
		public bool ZYMFIQJJJHR(Guid a, WLRKHVLXMOD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x89FFC50", Offset = "0x89FE850", VA = "0x1889FFC50", Slot = "8")]
		public Task<(WLRKHVLXMOD, Task)> CLHHHQUEKVC(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8A00000", Offset = "0x89FEC00", VA = "0x188A00000")]
		private void FRCSBQEYIXN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8A00600", Offset = "0x89FF200", VA = "0x188A00600")]
		public RoomManagerPendingRequests()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerPresenceUpdates : DTFLPTSQVDD, BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		private class OEDOTINPIVX : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			private readonly RoomInstance VJYOUWDEYKX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			private readonly CancellationTokenSource WNMHKZWJWAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			public readonly CancellationToken PNAJWRRNLTK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			private bool RBSJRAMWOBU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			private bool QGMIBIQZRNW;

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x89FE6E0", Offset = "0x89FD2E0", VA = "0x1889FE6E0")]
			public OEDOTINPIVX(RoomInstance a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x89FE570", Offset = "0x89FD170", VA = "0x1889FE570")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x89FE6B0", Offset = "0x89FD2B0", VA = "0x1889FE6B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class QDZMHQJBVSL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public DisconnectCause YEEEXRULCUQ;

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public QDZMHQJBVSL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x89FE970", Offset = "0x89FD570", VA = "0x1889FE970")]
			internal object ISYNNKNDMAR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class HYHOIDDDCBX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			public int OLXVOTFMZCT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			public RoomManagerPresenceUpdates BIVSZSMQJUR;

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HYHOIDDDCBX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x89FDDC0", Offset = "0x89FC9C0", VA = "0x1889FDDC0")]
			internal object ASLAMKESOGP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class HYCHKWJFSQO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026A")]
			public RoomInstance VJYOUWDEYKX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400026B")]
			public HYHOIDDDCBX CFCUCJZVXTS;

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HYCHKWJFSQO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x89FDD00", Offset = "0x89FC900", VA = "0x1889FDD00")]
			internal object ASQHJQYPXRY((RoomInstance lastLocalPlayerRoomInstance, RoomInstance newRoomInstance, WVAADYFIYNV fallbacks) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class BLUSZPLEKLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026C")]
			public RoomInstance VJYOUWDEYKX;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public BLUSZPLEKLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x89FDB00", Offset = "0x89FC700", VA = "0x1889FDB00")]
			internal object LFXROEONDME()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x89FDBA0", Offset = "0x89FC7A0", VA = "0x1889FDBA0")]
			internal void LGCYLLIKMXN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x89FDC20", Offset = "0x89FC820", VA = "0x1889FDC20")]
			internal object LGIFISCHWIW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x89FDC60", Offset = "0x89FC860", VA = "0x1889FDC60")]
			internal object LGNMFYWFFUF()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private struct <OnDisconnectedFromPhotonWhileConnected>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400026E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400026F")]
			public DisconnectCause disconnectCause;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000270")]
			public RoomManagerPresenceUpdates <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000271")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000272")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x8A11400", Offset = "0x8A10000", VA = "0x188A11400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x8A11840", Offset = "0x8A10440", VA = "0x188A11840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private struct <OnPlayerPresenceUpdated>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000273")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000274")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000275")]
			public int playerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000276")]
			public RoomManagerPresenceUpdates <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000277")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000278")]
			private IDisposable <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000279")]
			private IDisposable <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400027A")]
			private LogRangeScope <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400027B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8A118A0", Offset = "0x8A104A0", VA = "0x188A118A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0xAF5C80", Offset = "0xAF4880", VA = "0x180AF5C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private struct <TryJoinRoomInstance>d__30 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400027C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400027D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400027E")]
			public RoomInstance newRoomInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400027F")]
			public RoomManagerPresenceUpdates <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000280")]
			public FWSYDBCYQHV customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000281")]
			private BLUSZPLEKLE <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000282")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000283")]
			private CancellationTokenRegistration <_>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000284")]
			private object <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000285")]
			private int <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000286")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x8A19AB0", Offset = "0x8A186B0", VA = "0x188A19AB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x8A1AA10", Offset = "0x8A19610", VA = "0x188A1AA10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private static readonly LPXNOOPWSBD.UQMWQOIUYSH YBGHBAUILTS;

		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private static readonly LogFlags ADXXGRMJJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TBEXYEJQNFS YKABCEEKPYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private IIDBRQOYHQN PNSRTVKXRGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private WVAADYFIYNV LXGRXYJIXSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private UFFFZRRBPXW TIDVWLUQWFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private DJFXWYYSLCW WMRFSTLEXNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private MWFWDBGDAHR WVZTOVCLFTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private RoomInstance RTXQEJQYQSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private OEDOTINPIVX YQIDJPHPDOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private bool YDUOGGCCVTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private Task ZWQXRALOSMO;

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		private IHOYXZOJIJC RRESXEGEGKR
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x8A008A0", Offset = "0x89FF4A0", VA = "0x188A008A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public bool MHHGDQRTYZO
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xB0E630", Offset = "0xB0D230", VA = "0x180B0E630")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x8A01060", Offset = "0x89FFC60", VA = "0x188A01060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8A00DB0", Offset = "0x89FF9B0", VA = "0x188A00DB0", Slot = "4")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8A00970", Offset = "0x89FF570", VA = "0x188A00970", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8A007B0", Offset = "0x89FF3B0", VA = "0x188A007B0")]
		[AsyncStateMachine(typeof(<OnDisconnectedFromPhotonWhileConnected>d__20))]
		private Task AIQPEOGBDAL(DisconnectCause a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8A012B0", Offset = "0x89FFEB0", VA = "0x188A012B0")]
		private void WIQBGRWJXUK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8A00B00", Offset = "0x89FF700", VA = "0x188A00B00")]
		private void EPJUCIISFIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8A01070", Offset = "0x89FFC70", VA = "0x188A01070")]
		private void MTYXCQVYHUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8A008F0", Offset = "0x89FF4F0", VA = "0x188A008F0")]
		private bool CXYJXRPGLNY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8A011E0", Offset = "0x89FFDE0", VA = "0x188A011E0")]
		[AsyncStateMachine(typeof(<OnPlayerPresenceUpdated>d__26))]
		private void QARZXQBFSTX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8A01440", Offset = "0x8A00040", VA = "0x188A01440")]
		private void XBYQKGUKYUI([Out] IDisposable a, [Out] IDisposable b, [Out] IDisposable c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8A006B0", Offset = "0x89FF2B0", VA = "0x188A006B0")]
		private bool ADJDBTQAYHW(RoomInstance a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8A016E0", Offset = "0x8A002E0", VA = "0x188A016E0")]
		private void XECRVXZWIYY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8A00C80", Offset = "0x89FF880", VA = "0x188A00C80")]
		[AsyncStateMachine(typeof(<TryJoinRoomInstance>d__30))]
		private Task HFFVNPDEGUI(RoomInstance a, FWSYDBCYQHV b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x8A01AF0", Offset = "0x8A006F0", VA = "0x188A01AF0")]
		public RoomManagerPresenceUpdates()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerReceiveOperation : JGNQGWSBKSC, BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class NIBWJFEAYEQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400028D")]
			public RECTXKHRIXS VGNXCVPPJCA;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public NIBWJFEAYEQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x89FE370", Offset = "0x89FCF70", VA = "0x1889FE370")]
			internal object ALBNMRZRCXD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		[CompilerGenerated]
		private sealed class SYNNFXFDNKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400028E")]
			public RECTXKHRIXS ELIJPWFRWFG;

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SYNNFXFDNKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x8A06690", Offset = "0x8A05290", VA = "0x188A06690")]
			internal object IHTYFNLSRNU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class WNRSWAJADRM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400028F")]
			public RECTXKHRIXS AONAYCTKVET;

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public WNRSWAJADRM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x8A1C490", Offset = "0x8A1B090", VA = "0x188A1C490")]
			internal object VIGTGGJQCWR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		[CompilerGenerated]
		private sealed class SEWWWLJILVR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000290")]
			public KOQJHZNNMVK KIQLHZUDVLK;

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SEWWWLJILVR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x8A06610", Offset = "0x8A05210", VA = "0x188A06610")]
			internal object GFDMJJIICEX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		[CompilerGenerated]
		private sealed class NLQFCTBILOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000291")]
			public RECTXKHRIXS ELIJPWFRWFG;

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public NLQFCTBILOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x89FE510", Offset = "0x89FD110", VA = "0x1889FE510")]
			internal object XKTHHFGHDQD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		[CompilerGenerated]
		private sealed class DKHGUFSJRQE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000292")]
			public RECTXKHRIXS ELIJPWFRWFG;

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public DKHGUFSJRQE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x89FDCA0", Offset = "0x89FC8A0", VA = "0x1889FDCA0")]
			internal object FFJGHPMCTTO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class KZRZTSLLDPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			public RECTXKHRIXS HJECQFCDJVI;

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public KZRZTSLLDPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x89FE210", Offset = "0x89FCE10", VA = "0x1889FE210")]
			internal object UPKXUDIRUKE()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private struct <RunOperation>d__15 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public KOQJHZNNMVK operation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000297")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000298")]
			public RoomManagerReceiveOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000299")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			private StackTimer<string> <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x8A16020", Offset = "0x8A14C20", VA = "0x188A16020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x8A16650", Offset = "0x8A15250", VA = "0x188A16650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private struct <RunOperationFromMaster>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400029C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400029D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400029E")]
			public RECTXKHRIXS operationStartMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400029F")]
			public RoomManagerReceiveOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002A0")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002A1")]
			private CancellationTokenSource <cancellationTokenSource>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			private AFCWAAKQTIP <pauseToken>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			private TaskAwaiter<RECTXKHRIXS> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002A4")]
			private IDisposable <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002A5")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x8A14B50", Offset = "0x8A13750", VA = "0x188A14B50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x8A156A0", Offset = "0x8A142A0", VA = "0x188A156A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private struct <RunOperationFromRequest>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			public RECTXKHRIXS request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			public RoomManagerReceiveOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			private CancellationTokenSource <cancellationTokenSource>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			private TaskAwaiter<KOQJHZNNMVK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x8A15700", Offset = "0x8A14300", VA = "0x188A15700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x8A15FC0", Offset = "0x8A14BC0", VA = "0x188A15FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		[CompilerGenerated]
		private struct <SyncAndCreateOperation>d__13 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public AsyncTaskMethodBuilder<KOQJHZNNMVK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public RoomManagerReceiveOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			public RECTXKHRIXS request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			private YDSWCFIUQIS.LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			private AFCWAAKQTIP <pauseToken>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			private TaskAwaiter<RECTXKHRIXS> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x8A18750", Offset = "0x8A17350", VA = "0x188A18750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8A18C80", Offset = "0x8A17880", VA = "0x188A18C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		[CompilerGenerated]
		private struct <ThrowOnRequestTask>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public AsyncTaskMethodBuilder<RoomOperationType> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			public RoomManagerReceiveOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			public CancellationToken throwOnRequestCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private TaskAwaiter<RoomOperationType> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x8A18CF0", Offset = "0x8A178F0", VA = "0x188A18CF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x8A18F70", Offset = "0x8A17B70", VA = "0x188A18F70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private IIDBRQOYHQN PNSRTVKXRGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private OFZVAJIDTWP WMVAHRTVTQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private BYTSDAIHWMX QPBKOHQYPUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private XSRZAJFGDTC SAHVPNSGYPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TSOFJGCPTYM GWUBCTSVVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskCompletionSource<RoomOperationType> HTQOSHQZRVD;

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x8A01DC0", Offset = "0x8A009C0", VA = "0x188A01DC0", Slot = "7")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8A01B60", Offset = "0x8A00760", VA = "0x188A01B60", Slot = "6")]
		[AsyncStateMachine(typeof(<ThrowOnRequestTask>d__8))]
		public Task<RoomOperationType> BRJMTNODLLS(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x8A01EB0", Offset = "0x8A00AB0", VA = "0x188A01EB0", Slot = "4")]
		public void KMXSFCNKPGA(RECTXKHRIXS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8A024B0", Offset = "0x8A010B0", VA = "0x188A024B0", Slot = "5")]
		public void SVNLFBUNKLN(RECTXKHRIXS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8A02210", Offset = "0x8A00E10", VA = "0x188A02210")]
		[AsyncStateMachine(typeof(<RunOperationFromRequest>d__11))]
		private Task KRSLTRPFMDQ(RECTXKHRIXS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8A02320", Offset = "0x8A00F20", VA = "0x188A02320")]
		[AsyncStateMachine(typeof(<RunOperationFromMaster>d__12))]
		private Task MFMJWLWNKNV(RECTXKHRIXS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x8A01C70", Offset = "0x8A00870", VA = "0x188A01C70")]
		[AsyncStateMachine(typeof(<SyncAndCreateOperation>d__13))]
		private Task<KOQJHZNNMVK> EWQYPTKCWDE(RECTXKHRIXS a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x8A02430", Offset = "0x8A01030", VA = "0x188A02430")]
		private AFCWAAKQTIP NQXXTSEUXKT(RECTXKHRIXS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8A027E0", Offset = "0x8A013E0", VA = "0x188A027E0")]
		[AsyncStateMachine(typeof(<RunOperation>d__15))]
		private Task UCLCIZWEYKV(KOQJHZNNMVK a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8A02900", Offset = "0x8A01500", VA = "0x188A02900")]
		private KOQJHZNNMVK WXPLOBFSBDD(RECTXKHRIXS a, AFCWAAKQTIP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x3A34B90", Offset = "0x3A33790", VA = "0x183A34B90")]
		private a DYTXKTEEJHV<a>(a a) where a : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x8A02B00", Offset = "0x8A01700", VA = "0x188A02B00")]
		private KOQJHZNNMVK XRRUTKXHTAY(RECTXKHRIXS a, AFCWAAKQTIP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public RoomManagerReceiveOperation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerRequestHandler : BYTSDAIHWMX, BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		[CompilerGenerated]
		private sealed class BKMTJGOHRIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			public NetworkEventCode JDMQFMVLQVK;

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public BKMTJGOHRIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x89FDA90", Offset = "0x89FC690", VA = "0x1889FDA90")]
			internal object QSFJFLNVLSH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		[CompilerGenerated]
		private sealed class XYQPMXZJXMZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			public Guid MZSFQTMTWSV;

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XYQPMXZJXMZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x8A1C5C0", Offset = "0x8A1B1C0", VA = "0x188A1C5C0")]
			internal object AHZZGZVEDEA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private TSOFJGCPTYM GWUBCTSVVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private THVKUDUNAXN VZHVEPVLYPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private JGNQGWSBKSC MWIWEYGFMQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private XNZVOZBCXUJ SAISMVEVFSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private TBZYWRKNUED OIOZEPLMNWS;

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8A03330", Offset = "0x8A01F30", VA = "0x188A03330", Slot = "6")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8A03090", Offset = "0x8A01C90", VA = "0x188A03090", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x8A04160", Offset = "0x8A02D60", VA = "0x188A04160", Slot = "4")]
		public PendingRequest TKTQDCRITAD(RECTXKHRIXS a)
		{
			return default(PendingRequest);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8A04A30", Offset = "0x8A03630", VA = "0x188A04A30", Slot = "5")]
		public void ZMXZMEUXDIA(Guid a, Task b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8A036E0", Offset = "0x8A022E0", VA = "0x188A036E0")]
		private void NANHRXRJYCA(PKPJICLPGZO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8A039D0", Offset = "0x8A025D0", VA = "0x188A039D0")]
		private void QOJUKDTLLSF(OperationEventData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8A04570", Offset = "0x8A03170", VA = "0x188A04570")]
		private void WUXYEUCLRJL(OperationEventData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x8A034A0", Offset = "0x8A020A0", VA = "0x188A034A0")]
		private void JXTEERCJFGY(OperationEventData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x8A02E50", Offset = "0x8A01A50", VA = "0x188A02E50")]
		private WLRKHVLXMOD BYYWVDAUQIR(RECTXKHRIXS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8A03130", Offset = "0x8A01D30", VA = "0x188A03130")]
		private void EYCYXVWQSAZ(RECTXKHRIXS a, WLRKHVLXMOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8A037F0", Offset = "0x8A023F0", VA = "0x188A037F0")]
		private bool NCEKAIMJIJK(RECTXKHRIXS a, WLRKHVLXMOD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x8A03F50", Offset = "0x8A02B50", VA = "0x188A03F50")]
		private bool SNCSGKBLTJY(RECTXKHRIXS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x8A047E0", Offset = "0x8A033E0", VA = "0x188A047E0")]
		private bool WVIRDOEJYLL(NetworkEventCode a, Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public RoomManagerRequestHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerRequestOperation : NSSLHPLZEAC, BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		[CompilerGenerated]
		private sealed class OIJSTNCODXH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D0")]
			public RoomOperationType DKBSXUMOMGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002D1")]
			public RoomManagerRequestOperation BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			public RECTXKHRIXS IQBGBQJOSHC;

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public OIJSTNCODXH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x89FE7E0", Offset = "0x89FD3E0", VA = "0x1889FE7E0")]
			internal object NSUFWHFHRNI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x89FE850", Offset = "0x89FD450", VA = "0x1889FE850")]
			internal object NSZMTNZFAYR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		[CompilerGenerated]
		private sealed class XVCGTKCCKDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			public RoomOperationType DKBSXUMOMGA;

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XVCGTKCCKDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x8A1C4F0", Offset = "0x8A1B0F0", VA = "0x188A1C4F0")]
			internal object MXHJMAZXRVJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private sealed class JWFSMWPDEJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public RECTXKHRIXS ELIJPWFRWFG;

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public JWFSMWPDEJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x89FDE20", Offset = "0x89FCA20", VA = "0x1889FDE20")]
			internal object ESEYVECEWYI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x89FDE90", Offset = "0x89FCA90", VA = "0x1889FDE90")]
			internal object ESKFSKWCGJR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x89FDF00", Offset = "0x89FCB00", VA = "0x1889FDF00")]
			internal object ESPMPRPZPVA()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		[CompilerGenerated]
		private struct <RecRoom-RoomLoading-IRoomManagerRequestOperation-RequestOperation>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			public AsyncTaskMethodBuilder<WLRKHVLXMOD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			public RoomManagerRequestOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			public RECTXKHRIXS roomOperationMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			private TaskAwaiter<WLRKHVLXMOD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x8A13500", Offset = "0x8A12100", VA = "0x188A13500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x8A13B80", Offset = "0x8A12780", VA = "0x188A13B80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		[CompilerGenerated]
		private struct <RequestOperationInternal>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			public AsyncTaskMethodBuilder<WLRKHVLXMOD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public RECTXKHRIXS request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			public RoomManagerRequestOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			private JWFSMWPDEJC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private PendingRequest <pendingRequest>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			private WLRKHVLXMOD <result>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			private TaskAwaiter<(WLRKHVLXMOD validationResult, Task operation)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x8A13BF0", Offset = "0x8A127F0", VA = "0x188A13BF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x8A145B0", Offset = "0x8A131B0", VA = "0x188A145B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private TSOFJGCPTYM GWUBCTSVVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private THVKUDUNAXN VZHVEPVLYPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private BYTSDAIHWMX QPBKOHQYPUQ;

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x8A05070", Offset = "0x8A03C70", VA = "0x188A05070", Slot = "5")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x8A04C30", Offset = "0x8A03830", VA = "0x188A04C30", Slot = "4")]
		[AsyncStateMachine(typeof(<RecRoom-RoomLoading-IRoomManagerRequestOperation-RequestOperation>d__4))]
		private Task<WLRKHVLXMOD> AYCCMBVPZVA(RECTXKHRIXS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8A04D50", Offset = "0x8A03950", VA = "0x188A04D50")]
		private bool HXUNYAXOQMN(RoomOperationType a, [Out] WLRKHVLXMOD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x8A04F30", Offset = "0x8A03B30", VA = "0x188A04F30")]
		[AsyncStateMachine(typeof(<RequestOperationInternal>d__7))]
		private Task<WLRKHVLXMOD> IDQWEJNQROE(RECTXKHRIXS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public RoomManagerRequestOperation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal sealed class RoomManagerRoomLoadRequest : FEQJSDHNGZK, BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000C1")]
		private struct ResolvedLoadParameters
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E9")]
			public FilenameWithHash SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002EA")]
			public long SubRoomDataSaveId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002EB")]
			public Guid? RoomLoadSnapshotId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40002EC")]
			public bool LoadUsedCompatibility;
		}

		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		[CompilerGenerated]
		private sealed class NIBWJFEAYEQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public Stopwatch OJKYMBSIDAF;

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public NIBWJFEAYEQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x89FE430", Offset = "0x89FD030", VA = "0x1889FE430")]
			internal object UUJALUYCPRQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		[CompilerGenerated]
		private sealed class JWFSMWPDEJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public Stopwatch OJKYMBSIDAF;

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public JWFSMWPDEJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x89FDF70", Offset = "0x89FCB70", VA = "0x1889FDF70")]
			internal object GZWYHBRXXQU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C4")]
		[CompilerGenerated]
		private sealed class KZRZTSLLDPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public long BEZPQOVRDSJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			public RoomDetailsDTO ZBSQCTMLQQD;

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public KZRZTSLLDPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x104E080", Offset = "0x104CC80", VA = "0x18104E080")]
			internal bool IPEUZXAZKAJ(SubRoomDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x89FE150", Offset = "0x89FCD50", VA = "0x1889FE150")]
			internal object IPZWOYCOVTT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x89FE0E0", Offset = "0x89FCCE0", VA = "0x1889FE0E0")]
			internal object IOZOCQHCAPA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x89FE070", Offset = "0x89FCC70", VA = "0x1889FE070")]
			internal object IOUHFJNERDR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		[CompilerGenerated]
		private sealed class KZXGQZFINAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			public bool XUZHPNNQYDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			public KZRZTSLLDPA CFCUCJZVXTS;

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public KZXGQZFINAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x89FE270", Offset = "0x89FCE70", VA = "0x1889FE270")]
			internal object IOPAICTHHSI()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		[CompilerGenerated]
		private struct <GetDefaultRoomDataBlobWithHashForDorms>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002F4")]
			public AsyncTaskMethodBuilder<ResolvedLoadParameters> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002F5")]
			public SubRoomDTO subroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			public RoomManagerRoomLoadRequest <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			public RoomInstance dormInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			public long subroomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			private NIBWJFEAYEQ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			private TaskAwaiter<SubRoomDataSaveDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x8A0C1D0", Offset = "0x8A0ADD0", VA = "0x188A0C1D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x8A0C890", Offset = "0x8A0B490", VA = "0x188A0C890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C7")]
		[CompilerGenerated]
		private struct <GetRoomDataBlobWithHashForRoomDetails>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002FF")]
			public AsyncTaskMethodBuilder<ResolvedLoadParameters> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			public long subroomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			public RoomDetailsDTO roomDetailsDto;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			public RoomManagerRoomLoadRequest <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000303")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			private KZXGQZFINAJ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			private TaskAwaiter<ResolvedLoadParameters> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			private TaskAwaiter<RoomLoadDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x8A0C900", Offset = "0x8A0B500", VA = "0x188A0C900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x8A0D810", Offset = "0x8A0C410", VA = "0x188A0D810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		[CompilerGenerated]
		private struct <GetRoomDetails>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			public AsyncTaskMethodBuilder<RoomDetailsDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			public RoomManagerRoomLoadRequest <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			private JWFSMWPDEJC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x8A0D880", Offset = "0x8A0C480", VA = "0x188A0D880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x8A0DE60", Offset = "0x8A0CA60", VA = "0x188A0DE60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		[CompilerGenerated]
		private struct <GetRoomLoadRequestPayload>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public AsyncTaskMethodBuilder<RoomLoadRequestPayload> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public RoomManagerRoomLoadRequest <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			private long <subRoomId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			private TaskAwaiter<RoomLoadRequestPayload> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x8A0E420", Offset = "0x8A0D020", VA = "0x188A0E420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x8A0E9F0", Offset = "0x8A0D5F0", VA = "0x188A0E9F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000CA")]
		[CompilerGenerated]
		private struct <GetRoomLoadRequestPayloadFromDetailsAndSubroom>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			public AsyncTaskMethodBuilder<RoomLoadRequestPayload> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			public RoomManagerRoomLoadRequest <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public RoomDetailsDTO roomDetailsDto;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public long subroomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			private TaskAwaiter<ResolvedLoadParameters> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x8A0DED0", Offset = "0x8A0CAD0", VA = "0x188A0DED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x8A0E3B0", Offset = "0x8A0CFB0", VA = "0x188A0E3B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private UFFFZRRBPXW TIDVWLUQWFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private DJFXWYYSLCW WMRFSTLEXNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private HNOFUIUXRAK KUMNPSNHNXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private ACHQKVPRACK QZXQMNVOERJ;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x8A053F0", Offset = "0x8A03FF0", VA = "0x188A053F0", Slot = "5")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x8A057C0", Offset = "0x8A043C0", VA = "0x188A057C0", Slot = "4")]
		[AsyncStateMachine(typeof(<GetRoomLoadRequestPayload>d__6))]
		public Task<RoomLoadRequestPayload> YIFAMAHPIED(StackTimer<string>.USVZTROCTRS a, RoomInstance b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A05120", Offset = "0x8A03D20", VA = "0x188A05120")]
		[AsyncStateMachine(typeof(<GetRoomDetails>d__7))]
		private Task<RoomDetailsDTO> FLFPLSVPUUU(RoomInstance a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x8A054E0", Offset = "0x8A040E0", VA = "0x188A054E0")]
		[AsyncStateMachine(typeof(<GetRoomLoadRequestPayloadFromDetailsAndSubroom>d__8))]
		private Task<RoomLoadRequestPayload> KETLBHFCVLP(RoomInstance a, RoomDetailsDTO b, long c, StackTimer<string>.USVZTROCTRS d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x8A05650", Offset = "0x8A04250", VA = "0x188A05650")]
		[AsyncStateMachine(typeof(<GetRoomDataBlobWithHashForRoomDetails>d__9))]
		private Task<ResolvedLoadParameters> WCXXCUBTOOX(RoomInstance a, RoomDetailsDTO b, long c, StackTimer<string>.USVZTROCTRS d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x8A05280", Offset = "0x8A03E80", VA = "0x188A05280")]
		[AsyncStateMachine(typeof(<GetDefaultRoomDataBlobWithHashForDorms>d__10))]
		private Task<ResolvedLoadParameters> ILTHJBMHPOS(RoomInstance a, SubRoomDTO b, long c, StackTimer<string>.USVZTROCTRS d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public RoomManagerRoomLoadRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerSynchronization : XSRZAJFGDTC, BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class NIBWJFEAYEQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public RECTXKHRIXS ELIJPWFRWFG;

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public NIBWJFEAYEQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x89FE3D0", Offset = "0x89FCFD0", VA = "0x1889FE3D0")]
			internal object PPNPGMMXMXJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		[CompilerGenerated]
		private sealed class XVCGTKCCKDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			public RECTXKHRIXS ELIJPWFRWFG;

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XVCGTKCCKDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x8A1C560", Offset = "0x8A1B160", VA = "0x188A1C560")]
			internal object NXMBHYEEXOC()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		[CompilerGenerated]
		private struct <MasterSyncRequestAndValidateResponse>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public AsyncTaskMethodBuilder<RECTXKHRIXS> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public RECTXKHRIXS request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public RoomManagerSynchronization <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public AFCWAAKQTIP pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private Guid <requestGuid>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private MessageKind <expectMessageKind>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			private ODMCMHKRANU <masterSwitchCancellationScope>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x8A10180", Offset = "0x8A0ED80", VA = "0x188A10180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x8A10D20", Offset = "0x8A0F920", VA = "0x188A10D20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		[CompilerGenerated]
		private struct <MasterSynchronizeRequest>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			public AsyncTaskMethodBuilder<RECTXKHRIXS> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public RECTXKHRIXS request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public RoomManagerSynchronization <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public AFCWAAKQTIP pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private TaskAwaiter<RECTXKHRIXS> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x8A10D90", Offset = "0x8A0F990", VA = "0x188A10D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x8A11390", Offset = "0x8A0FF90", VA = "0x188A11390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private struct <PopNextBufferedEvent>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public AsyncTaskMethodBuilder<RECTXKHRIXS> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public RoomManagerSynchronization <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public AFCWAAKQTIP pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x8A12EB0", Offset = "0x8A11AB0", VA = "0x188A12EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x8A13490", Offset = "0x8A12090", VA = "0x188A13490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TSOFJGCPTYM GWUBCTSVVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private BGKCZVBTBNY PKTYRJXZIWJ;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private TNKKQUGAVHK TNKKQUGAVHK
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x8A05F80", Offset = "0x8A04B80", VA = "0x188A05F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8A05DD0", Offset = "0x8A049D0", VA = "0x188A05DD0", Slot = "8")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x8A05C70", Offset = "0x8A04870", VA = "0x188A05C70", Slot = "4")]
		[AsyncStateMachine(typeof(<MasterSynchronizeRequest>d__6))]
		public Task<RECTXKHRIXS> IMLWARTBDLA(RECTXKHRIXS a, AFCWAAKQTIP b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x8A05A80", Offset = "0x8A04680", VA = "0x188A05A80", Slot = "5")]
		[AsyncStateMachine(typeof(<PopNextBufferedEvent>d__7))]
		public Task<RECTXKHRIXS> BWGTXKRBOXG(CancellationToken a, AFCWAAKQTIP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8A05BD0", Offset = "0x8A047D0", VA = "0x188A05BD0", Slot = "6")]
		public VGXLHGZFUHZ HWHXIKZCIPJ(KOQJHZNNMVK a, StackTimer<string>.USVZTROCTRS b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8A05E60", Offset = "0x8A04A60", VA = "0x188A05E60", Slot = "7")]
		public VGXLHGZFUHZ MPMJBRIYAYK(KOQJHZNNMVK a, StackTimer<string>.USVZTROCTRS b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x8A05920", Offset = "0x8A04520", VA = "0x188A05920")]
		[AsyncStateMachine(typeof(<MasterSyncRequestAndValidateResponse>d__10))]
		private Task<RECTXKHRIXS> BGPELPAADWZ(RECTXKHRIXS a, AFCWAAKQTIP b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x3BCC170", Offset = "0x3BCAD70", VA = "0x183BCC170")]
		private static byte[] HEFAUHQJYSO(RECTXKHRIXS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public RoomManagerSynchronization()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerValidation : THVKUDUNAXN, BCVKRROGGDB, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private NPCOESJCXHR GXEKTTCGESW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private TSOFJGCPTYM GWUBCTSVVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private OFZVAJIDTWP WMVAHRTVTQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private DYZGTIFVZSV OUBLEWZBQBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private UFFFZRRBPXW TIDVWLUQWFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private MWFWDBGDAHR WVZTOVCLFTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private WVULOYQAUQS MJWLHRZNHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private DJFXWYYSLCW WMRFSTLEXNH;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private IHOYXZOJIJC RRESXEGEGKR
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x8A06040", Offset = "0x8A04C40", VA = "0x188A06040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private static WLRKHVLXMOD CRNHFYMPSNI
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x8A065F0", Offset = "0x8A051F0", VA = "0x188A065F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x8A06480", Offset = "0x8A05080", VA = "0x188A06480", Slot = "6")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x8A06090", Offset = "0x8A04C90", VA = "0x188A06090", Slot = "4")]
		public WLRKHVLXMOD EDKNQAGACQP(HNNNRVHBOIU a, RoomOperationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A06200", Offset = "0x8A04E00", VA = "0x188A06200", Slot = "5")]
		public WLRKHVLXMOD GOEKSNIRFWG(HNNNRVHBOIU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x8A06600", Offset = "0x8A05200", VA = "0x188A06600")]
		private static WLRKHVLXMOD WYSUJMBDIGD(ValidationReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public RoomManagerValidation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class RoomOperationAlreadyInProgressException : InvalidOperationException
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x8A267C0", Offset = "0x8A253C0", VA = "0x188A267C0")]
		public RoomOperationAlreadyInProgressException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A830", Offset = "0x7B49430", VA = "0x187B4A830")]
		public RoomOperationAlreadyInProgressException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerAutosaves : DNXBHPVLZPJ, BCVKRROGGDB, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[CompilerGenerated]
		private struct <AwaitAutosaveInterval>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public CancellationToken nextAutosaveToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private Task <delayTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private TaskAwaiter<Task> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x8A275F0", Offset = "0x8A261F0", VA = "0x188A275F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x8A27A60", Offset = "0x8A26660", VA = "0x188A27A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		[CompilerGenerated]
		private struct <RequestRestoreAutosave>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public AsyncTaskMethodBuilder<WLRKHVLXMOD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public QLEODJJBPHT autosaveRecordInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private StackTimer<string> <timer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private StackTimer<string>.USVZTROCTRS <timerScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			private POLKJBXNXXZ <operation>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			private TaskAwaiter<WLRKHVLXMOD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x8A2A090", Offset = "0x8A28C90", VA = "0x188A2A090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x8A2AA50", Offset = "0x8A29650", VA = "0x188A2AA50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		[CompilerGenerated]
		private struct <RunAutosave>d__24 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public AutosaveType autosaveType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			private StackTimer<string> <timer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x8A30530", Offset = "0x8A2F130", VA = "0x188A30530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x8A30AA0", Offset = "0x8A2F6A0", VA = "0x188A30AA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D9")]
		[CompilerGenerated]
		private struct <RunAutosaveRoutine>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x8A2FFE0", Offset = "0x8A2EBE0", VA = "0x188A2FFE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x8A304D0", Offset = "0x8A2F0D0", VA = "0x188A304D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		[CompilerGenerated]
		private struct <RunAutosaveRoutineInternal>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x8A2F7D0", Offset = "0x8A2E3D0", VA = "0x188A2F7D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x8A2FF80", Offset = "0x8A2EB80", VA = "0x188A2FF80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DB")]
		[CompilerGenerated]
		private struct <RunRecoveryAutosave>d__15 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			private CancellationTokenSource <combinedTokenSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x8A310C0", Offset = "0x8A2FCC0", VA = "0x188A310C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x8A31800", Offset = "0x8A30400", VA = "0x188A31800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		[CompilerGenerated]
		private struct <RunRecoveryAutosaveInternal>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x8A30EC0", Offset = "0x8A2FAC0", VA = "0x188A30EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x8A31060", Offset = "0x8A2FC60", VA = "0x188A31060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		[CompilerGenerated]
		private struct <ScheduleIncrementalAutosave>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			private CancellationToken <nextAutosaveToken>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x8A34420", Offset = "0x8A33020", VA = "0x188A34420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x8A34B30", Offset = "0x8A33730", VA = "0x188A34B30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private TSOFJGCPTYM GWUBCTSVVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private IIDBRQOYHQN PNSRTVKXRGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private UFFFZRRBPXW TIDVWLUQWFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private XSRZAJFGDTC SAHVPNSGYPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private OFZVAJIDTWP WMVAHRTVTQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private WVULOYQAUQS MJWLHRZNHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private CancellationTokenSource MZHYHXNBEZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private Task SKWXGRLFJUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private TaskCompletionSource<int> TTQADQRZSQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private int BETFFJJNWZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private int XZYPGCEZFGK;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x8A25750", Offset = "0x8A24350", VA = "0x188A25750", Slot = "6")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x12C8770", Offset = "0x12C7370", VA = "0x1812C8770", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x8A26040", Offset = "0x8A24C40", VA = "0x188A26040")]
		private void VQOMSGMRZYT(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x8A25D10", Offset = "0x8A24910", VA = "0x188A25D10", Slot = "4")]
		[AsyncStateMachine(typeof(<RequestRestoreAutosave>d__14))]
		public Task<WLRKHVLXMOD> RequestRestoreAutosave(QLEODJJBPHT autosaveRecordInfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x8A25F50", Offset = "0x8A24B50", VA = "0x188A25F50", Slot = "5")]
		[AsyncStateMachine(typeof(<RunRecoveryAutosave>d__15))]
		public Task SYHQHPBFFQV([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x12C8770", Offset = "0x12C7370", VA = "0x1812C8770")]
		public void PAXCABJMFNT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x8A25AF0", Offset = "0x8A246F0", VA = "0x188A25AF0")]
		private POLKJBXNXXZ RIDKSRKMXPQ(QLEODJJBPHT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x8A25660", Offset = "0x8A24260", VA = "0x188A25660")]
		[AsyncStateMachine(typeof(<RunAutosaveRoutine>d__18))]
		private Task GTMYZOHCHUW(CancellationToken a, int b, AccountRoleType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x8A25900", Offset = "0x8A24500", VA = "0x188A25900")]
		[AsyncStateMachine(typeof(<RunAutosaveRoutineInternal>d__19))]
		private Task KDEMZLTYXXF(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x8A25570", Offset = "0x8A24170", VA = "0x188A25570")]
		[AsyncStateMachine(typeof(<RunRecoveryAutosaveInternal>d__20))]
		private Task EYDNDWHGBUY([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x8A25A00", Offset = "0x8A24600", VA = "0x188A25A00")]
		[AsyncStateMachine(typeof(<ScheduleIncrementalAutosave>d__21))]
		private Task PFPRSKKGIMA(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x8A26120", Offset = "0x8A24D20", VA = "0x188A26120")]
		[AsyncStateMachine(typeof(<AwaitAutosaveInterval>d__22))]
		private Task YMCMEZLZCHW(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x8A253E0", Offset = "0x8A23FE0", VA = "0x188A253E0")]
		private Task AWZWFCWGHHZ(AutosaveType a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A25E40", Offset = "0x8A24A40", VA = "0x188A25E40")]
		[AsyncStateMachine(typeof(<RunAutosave>d__24))]
		private Task RunAutosave(AutosaveType autosaveType, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x8A25170", Offset = "0x8A23D70", VA = "0x188A25170")]
		private bool AERSFHTJKCD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public RoomManagerAutosaves()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomManagerSave : DYZGTIFVZSV, BCVKRROGGDB, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private struct <RequestSaveRoomToDisk>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public RoomManagerSave <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public string path;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private StackTimer<string> <timer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x8A2AAC0", Offset = "0x8A296C0", VA = "0x188A2AAC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x8A2B040", Offset = "0x8A29C40", VA = "0x188A2B040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private BQFGXFTHRDV KOUIZBLHVJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private IIDBRQOYHQN PNSRTVKXRGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private THVKUDUNAXN VZHVEPVLYPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private XSRZAJFGDTC SAHVPNSGYPX;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x8A262D0", Offset = "0x8A24ED0", VA = "0x188A262D0", Slot = "6")]
		public void Initialize(IIDBRQOYHQN roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x8A26280", Offset = "0x8A24E80", VA = "0x188A26280", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x8A265A0", Offset = "0x8A251A0", VA = "0x188A265A0", Slot = "5")]
		[AsyncStateMachine(typeof(<RequestSaveRoomToDisk>d__6))]
		public Task RequestSaveRoomToDisk(string path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x8A26220", Offset = "0x8A24E20", VA = "0x188A26220", Slot = "4")]
		public WLRKHVLXMOD AERSFHTJKCD(HNNNRVHBOIU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x8A266A0", Offset = "0x8A252A0", VA = "0x188A266A0")]
		private DDRGZFYJKJY VHSVQCERGSP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public RoomManagerSave()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public static class LECQIZZLPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x8A22180", Offset = "0x8A20D80", VA = "0x188A22180")]
		public static void TXQKHIUZSKJ(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x8A21BD0", Offset = "0x8A207D0", VA = "0x188A21BD0")]
		internal static void BCRQZSXWSIS(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x8A21C70", Offset = "0x8A20870", VA = "0x188A21C70")]
		internal static void HCSTVGCHAVF(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x8A21D50", Offset = "0x8A20950", VA = "0x188A21D50")]
		internal static void RTRNKUGRRKJ(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x3786770", Offset = "0x3785370", VA = "0x183786770")]
		private static void RGDZDFNIJSX<a, b, a>(URVRSSRGCJF a) where b : a
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	internal class YOYSAMXUHRE : RHHLOBKWHCA<RECTXKHRIXS>
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class TBVOZRUCJVY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public RECTXKHRIXS HJECQFCDJVI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public string KOMUGDQOJQE;

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public TBVOZRUCJVY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x8A26FE0", Offset = "0x8A25BE0", VA = "0x188A26FE0")]
			internal object IDGYAESOFYJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly YOYSAMXUHRE PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8A39820", Offset = "0x8A38420", VA = "0x188A39820")]
		public Dictionary<object, object> Serialize(RECTXKHRIXS message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x8A398B0", Offset = "0x8A384B0", VA = "0x188A398B0", Slot = "5")]
		protected override void UJLKRWSXGID(RECTXKHRIXS a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x8A394E0", Offset = "0x8A380E0", VA = "0x188A394E0", Slot = "6")]
		public override RECTXKHRIXS Deserialize(IDictionary<object, object> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x8A39710", Offset = "0x8A38310", VA = "0x188A39710")]
		private static void Log(string op, RECTXKHRIXS message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x8A39A70", Offset = "0x8A38670", VA = "0x188A39A70")]
		public YOYSAMXUHRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x8A39240", Offset = "0x8A37E40", VA = "0x188A39240")]
		[CompilerGenerated]
		internal static string AZZLTAZUOKQ(RoomLoadRequestPayload a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public static class LVJKMJNDREW
	{
		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public static WLRKHVLXMOD CRNHFYMPSNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x8A227C0", Offset = "0x8A213C0", VA = "0x188A227C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x8A22820", Offset = "0x8A21420", VA = "0x188A22820")]
		public static bool WTZTRZFOHCW(this WLRKHVLXMOD a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x8A22840", Offset = "0x8A21440", VA = "0x188A22840")]
		public static WLRKHVLXMOD WYSUJMBDIGD(ValidationReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x8A22380", Offset = "0x8A20F80", VA = "0x188A22380")]
		public static WLRKHVLXMOD DHWKZEGCUQY(IEnumerable<WLRKHVLXMOD> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x8A22570", Offset = "0x8A21170", VA = "0x188A22570")]
		public static string SHQZOMWQMNP(this WLRKHVLXMOD a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public abstract class XEGHYLYFRUB : TKQXBWOSSHC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		public delegate WLRKHVLXMOD ValidateOperation([NotNull] HNNNRVHBOIU networkPlayer);

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class XVCGTKCCKDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public HNNNRVHBOIU YVKUSYHYPPW;

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XVCGTKCCKDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x15AD0C0", Offset = "0x15ABCC0", VA = "0x1815AD0C0")]
			internal WLRKHVLXMOD ZBQMPFJMDIX(ValidateOperation a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private bool AHBYTLQTEJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		protected readonly HashSet<ValidateOperation> AZLLMENMPME;

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x8A38B70", Offset = "0x8A37770", VA = "0x188A38B70", Slot = "4")]
		public void AICPRJYXJMM(ValidateOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x8A38C20", Offset = "0x8A37820", VA = "0x188A38C20", Slot = "5")]
		public void ELOBPPSFEVT(ValidateOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x8A38BD0", Offset = "0x8A377D0", VA = "0x188A38BD0", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x8A38C80", Offset = "0x8A37880", VA = "0x188A38C80")]
		protected WLRKHVLXMOD ZSFZYXAZKJP(HNNNRVHBOIU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x8A38F10", Offset = "0x8A37B10", VA = "0x188A38F10")]
		protected XEGHYLYFRUB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public class IEXTHHVCKIS : XEGHYLYFRUB, NPCOESJCXHR, TKQXBWOSSHC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class MIPFINYMDPQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public WLRKHVLXMOD XHLRNGOMZSG;

			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public MIPFINYMDPQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0x8A22900", Offset = "0x8A21500", VA = "0x188A22900")]
			internal object LIBMBPWQFNL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F8A0", Offset = "0x8A1E4A0", VA = "0x188A1F8A0")]
		[UnityEngine.Scripting.Preserve]
		public IEXTHHVCKIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F790", Offset = "0x8A1E390", VA = "0x188A1F790", Slot = "8")]
		public WLRKHVLXMOD BEAZIOKPCJF(HNNNRVHBOIU a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public class QQRDKICFSYS : XEGHYLYFRUB, BQFGXFTHRDV, TKQXBWOSSHC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		[CompilerGenerated]
		private sealed class MIPFINYMDPQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public WLRKHVLXMOD XHLRNGOMZSG;

			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public MIPFINYMDPQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x8A228A0", Offset = "0x8A214A0", VA = "0x188A228A0")]
			internal object HDOIGAEPKKF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F8A0", Offset = "0x8A1E4A0", VA = "0x188A1F8A0")]
		[UnityEngine.Scripting.Preserve]
		public QQRDKICFSYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x8A247E0", Offset = "0x8A233E0", VA = "0x188A247E0", Slot = "8")]
		public WLRKHVLXMOD AERSFHTJKCD(HNNNRVHBOIU a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public class DummyPlayer : HNNNRVHBOIU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private readonly int RPHUAROJYME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private Dictionary<object, object> OKMGOPYHDIG;

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public int YHEZWWSFKEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xA95110", Offset = "0xA93D10", VA = "0x180A95110", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool ABZLTAVDLUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public bool GWHAUTXHNPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public Dictionary<object, object> UNZHJXSLLSB
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public string UYZUNMPYSGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x8A1D840", Offset = "0x8A1C440", VA = "0x188A1D840", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public int UOIRZPCNMNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public bool IGTYQYLOVDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public bool TJEYMMBLZYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public string TMQOZVXYALL
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x8A1D870", Offset = "0x8A1C470", VA = "0x188A1D870", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public bool QNQZCEICRTA
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public object HXUSNRXHZLY
		{
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xA98370", Offset = "0xA96F70", VA = "0x180A98370", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x8A1DA00", Offset = "0x8A1C600", VA = "0x188A1DA00")]
		public DummyPlayer(int actorNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D8A0", Offset = "0x8A1C4A0", VA = "0x188A1D8A0", Slot = "16")]
		public bool IZAUNJNDEHF(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	internal static class UQMILFQNVBO
	{
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private sealed class XVCGTKCCKDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public StackTimer<string> MIHMEFXFBWU;

			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XVCGTKCCKDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x8A38F90", Offset = "0x8A37B90", VA = "0x188A38F90")]
			internal object KXMVVDBVACB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x8A35640", Offset = "0x8A34240", VA = "0x188A35640")]
		public static StackTimer<string> USVZTROCTRS(Log a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x8A35710", Offset = "0x8A34310", VA = "0x188A35710")]
		public static void WHILXSBXKVN(StackTimer<string> a, Log b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x8A35580", Offset = "0x8A34180", VA = "0x188A35580")]
		public static string ONZTFFTTQQA(RECTXKHRIXS a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	internal static class CIUFJKQMZQL
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x8A1CD00", Offset = "0x8A1B900", VA = "0x188A1CD00")]
		public static void EFSBKFLKIZI(this TSOFJGCPTYM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x8A1CD10", Offset = "0x8A1B910", VA = "0x188A1CD10")]
		public static void GWLODTGULBN(this TSOFJGCPTYM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x8A1CD20", Offset = "0x8A1B920", VA = "0x188A1CD20")]
		private static void SRXZVLKHIXL(this TSOFJGCPTYM a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public class QNVGHOEHASI : LSKHNYDIKME, NWTMLNSJWAN, IXYEFTNMGMC, ACVHIHCQSRD
	{
		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		[DefaultMember("Item")]
		private class YHZFZGVLUVI : PKPJICLPGZO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			private readonly byte DEZPTEROMDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			private readonly int IZXEIMWTNXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			private readonly object GFKSUKVOQBC;

			[Cpp2IlInjected.Token(Token = "0x170000D8")]
			public byte EZIXLAANKQW
			{
				[Cpp2IlInjected.Token(Token = "0x600047A")]
				[Cpp2IlInjected.Address(RVA = "0xAE9750", Offset = "0xAE8350", VA = "0x180AE9750", Slot = "4")]
				get
				{
					return default(byte);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D9")]
			public int FKLZNFVZBGS
			{
				[Cpp2IlInjected.Token(Token = "0x600047B")]
				[Cpp2IlInjected.Address(RVA = "0xB0BC00", Offset = "0xB0A800", VA = "0x180B0BC00", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000DA")]
			public object LWPQADDCOXO
			{
				[Cpp2IlInjected.Token(Token = "0x600047C")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x7B51FC0", Offset = "0x7B50BC0", VA = "0x187B51FC0")]
			public YHZFZGVLUVI(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0x8A39010", Offset = "0x8A37C10", VA = "0x188A39010", Slot = "7")]
			public bool CLNAOHYEVON(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly NWTMLNSJWAN YPFHIHZDLFH;

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public HNNNRVHBOIU XLUZORLMXGH
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0x8A23750", Offset = "0x8A22350", VA = "0x188A23750", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public int BIPSHSLRDKF
		{
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x8A23D80", Offset = "0x8A22980", VA = "0x188A23D80", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public int NSFKKCVZMJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0x8A23DD0", Offset = "0x8A229D0", VA = "0x188A23DD0", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public HNNNRVHBOIU ELTNHEYPHNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x8A23B50", Offset = "0x8A22750", VA = "0x188A23B50", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public bool GBDJMNVPWAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public int FTYZPRKLIYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0xB55810", Offset = "0xB54410", VA = "0x180B55810", Slot = "17")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public string UWJBRDGJUEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x8A239F0", Offset = "0x8A225F0", VA = "0x188A239F0", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public Func<string, string> JHZQITBBQVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x8A23930", Offset = "0x8A22530", VA = "0x188A23930", Slot = "19")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<string, long> FJDCNCNFGES
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<PKPJICLPGZO> ORVIZLBYZPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x8A23E70", Offset = "0x8A22A70", VA = "0x188A23E70", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x8A237A0", Offset = "0x8A223A0", VA = "0x188A237A0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<bool> GSKRZTZDEZE
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "27")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "28")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<HNNNRVHBOIU> WBSPSRGUJFI
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "11")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action DHPUYSYHQVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x8A23C00", Offset = "0x8A22800", VA = "0x188A23C00", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x8A23570", Offset = "0x8A22170", VA = "0x188A23570", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x8A23BA0", Offset = "0x8A227A0", VA = "0x188A23BA0", Slot = "20")]
		public void MPACOKPJKNE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xB946A0", Offset = "0xB932A0", VA = "0x180B946A0")]
		public QNVGHOEHASI(NWTMLNSJWAN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x8A23A50", Offset = "0x8A22650", VA = "0x188A23A50", Slot = "9")]
		public bool IGMPHTEKPZF(byte a, object b, QINZOSCQMJF c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x8A23F60", Offset = "0x8A22B60", VA = "0x188A23F60", Slot = "21")]
		public HNNNRVHBOIU ZQLFHJMEOAE(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x8A23CA0", Offset = "0x8A228A0", VA = "0x188A23CA0", Slot = "22")]
		public HNNNRVHBOIU ONFTWYJKCJA(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x8A23610", Offset = "0x8A22210", VA = "0x188A23610", Slot = "23")]
		public HNNNRVHBOIU CBBCUIHOWJO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x8A23850", Offset = "0x8A22450", VA = "0x188A23850", Slot = "24")]
		public IReadOnlyList<HNNNRVHBOIU> FCMCPPHOVVO(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x8A23F20", Offset = "0x8A22B20", VA = "0x188A23F20", Slot = "25")]
		public IReadOnlyList<HNNNRVHBOIU> YUKCINGTHVZ(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "26")]
		public bool YSOBWZHXTVG(HNNNRVHBOIU a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "29")]
		public void AOXVMRFENLB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "30")]
		public void FGBARMVSYBG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "31")]
		public void RJPUKPGZHRE(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x8A23E20", Offset = "0x8A22A20", VA = "0x188A23E20", Slot = "32")]
		public IDisposable WMWTGMQOFQZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "33")]
		private bool IAAFHPOKSHW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "34")]
		public void CXHXADDZDBG(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0xE2BB00", Offset = "0xE2A700", VA = "0x180E2BB00", Slot = "35")]
		public bool XBYCFATXDFV(bool a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0xDAD930", Offset = "0xDAC530", VA = "0x180DAD930", Slot = "38")]
		public void QEIYJJIQGUS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	internal struct OperationEventData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private readonly IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
		public OperationEventData(IDictionary<object, object> eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x8A23010", Offset = "0x8A21C10", VA = "0x188A23010")]
		public bool LILMSHRLTKU([Out] RECTXKHRIXS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x8A22E50", Offset = "0x8A21A50", VA = "0x188A22E50")]
		public Guid AJZVUGVXAKT()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x8A230C0", Offset = "0x8A21CC0", VA = "0x188A230C0")]
		public WLRKHVLXMOD MXIDYWWHKTB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x8A22F00", Offset = "0x8A21B00", VA = "0x188A22F00")]
		public static Dictionary<object, object> Create(RECTXKHRIXS message, WLRKHVLXMOD validationResult)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	internal static class LFGPLCBJHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x8A22300", Offset = "0x8A20F00", VA = "0x188A22300")]
		public static bool THMWHDMLLNE(this RoomInstance a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	internal struct TaskRunner : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F6")]
		[CompilerGenerated]
		private struct <RunTasks>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Func<CancellationToken, List<Task>> taskGenerator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			public TaskRunner <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x8A31860", Offset = "0x8A30460", VA = "0x188A31860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x8A31A40", Offset = "0x8A30640", VA = "0x188A31A40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private readonly CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private bool isDisposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private Task task;

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public bool HYLNHOWUFPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x8A27380", Offset = "0x8A25F80", VA = "0x188A27380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x8A274C0", Offset = "0x8A260C0", VA = "0x188A274C0")]
		public TaskRunner(CancellationToken cancellationToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x8A273B0", Offset = "0x8A25FB0", VA = "0x188A273B0")]
		[AsyncStateMachine(typeof(<RunTasks>d__8))]
		public Task ZJUCNEYCTAW(Func<CancellationToken, List<Task>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x8A27330", Offset = "0x8A25F30", VA = "0x188A27330", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public readonly struct VersionedDataGetter<TGetDataArg, TData>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		[CompilerGenerated]
		private struct <DownloadAndParse>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public AsyncTaskMethodBuilder<Result<ParseResult<TData>, DOTNMKZGUXE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public StackTimer<string>.USVZTROCTRS timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public string timerName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public VersionedDataGetter<TGetDataArg, TData> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public TGetDataArg arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private TaskAwaiter<Result<ParseResult<TData>, DOTNMKZGUXE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x4D6F770", Offset = "0x4D6E370", VA = "0x184D6F770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x4D6FE30", Offset = "0x4D6EA30", VA = "0x184D6FE30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly XLAGZXHUVSQ<TGetDataArg, TData> _deps;

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
		internal VersionedDataGetter(XLAGZXHUVSQ<TGetDataArg, TData> deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x6498CA0", Offset = "0x64978A0", VA = "0x186498CA0")]
		[AsyncStateMachine(typeof(VersionedDataGetter<, >.<DownloadAndParse>d__2))]
		public Task<Result<ParseResult<TData>, DOTNMKZGUXE>> HJARFVBDVAH(TGetDataArg a, string b, StackTimer<string>.USVZTROCTRS c, CancellationToken d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public static class SNTAIIRIHED
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x33A0720", Offset = "0x339F320", VA = "0x1833A0720")]
		public static VersionedDataGetter<TGetDataArg, TData> New<TGetDataArg, TData>(XLAGZXHUVSQ<TGetDataArg, TData> deps)
		{
			return default(VersionedDataGetter<TGetDataArg, TData>);
		}
	}
}
namespace RecRoom.RoomLoading.Errors
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public struct ErrorCode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public readonly int Code;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public readonly int? SubCode;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x523A500", Offset = "0x5239100", VA = "0x18523A500")]
		public ErrorCode(int code, [Optional] int? subCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F460", Offset = "0x8A1E060", VA = "0x188A1F460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public interface XDPGJPYIZOY<a> where a : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JKDCNYADKXB();

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(Slot = "1")]
		XDPGJPYIZOY<a> XXOHYCICPJI(string a);

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(Slot = "2")]
		XDPGJPYIZOY<a> HEKABYJEDDH(UserFriendlyErrorMessageBuilder<a> a);

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "3")]
		XDPGJPYIZOY<a> HQBWYXWHAOK(int a);

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "4")]
		XDPGJPYIZOY<a> QJTFXQJPNOZ(int a, GetSubCode<a> b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public interface TLMPALUKRRW
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(Slot = "0")]
		XDPGJPYIZOY<a> QXDJUGOSULF<a>() where a : Exception;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "1")]
		UserFriendlyErrorInfo GIZXPLNMPGO(Exception a);

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ErrorCode IRKRWZKVXMM(Exception a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public delegate string UserFriendlyErrorMessageBuilder<in T>(T ex) where T : Exception;
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public delegate int GetSubCode<in T>(T ex) where T : Exception;
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal class EWJWNTCJZHP : TLMPALUKRRW
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private delegate string UserFriendlyErrorMessageBuilder(Exception ex);

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		private delegate int GetSubCodeInternal(Exception ex);

		[Cpp2IlInjected.Token(Token = "0x2000102")]
		private class Registration<T> : XDPGJPYIZOY<T> where T : notnull, Exception
		{
			[Cpp2IlInjected.Token(Token = "0x2000103")]
			[CompilerGenerated]
			private sealed class OIJSTNCODXH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003CE")]
				public string DZWSCPNEYMO;

				[Cpp2IlInjected.Token(Token = "0x60004B6")]
				[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
				public OIJSTNCODXH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
				internal string FSMNLEYKVYO(Exception a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[CompilerGenerated]
			private sealed class TBVOZRUCJVY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003CF")]
				public UserFriendlyErrorMessageBuilder<T> YUTFKZTTXWZ;

				[Cpp2IlInjected.Token(Token = "0x60004B8")]
				[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
				public TBVOZRUCJVY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0x3DD31E0", Offset = "0x3DD1DE0", VA = "0x183DD31E0")]
				internal string HYUAWTCLUED(Exception a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000105")]
			[CompilerGenerated]
			private sealed class XYQPMXZJXMZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003D0")]
				public GetSubCode<T> YSESKVBPWXC;

				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
				public XYQPMXZJXMZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0x3DD31E0", Offset = "0x3DD1DE0", VA = "0x183DD31E0")]
				internal int XDMIGCOCYPN(Exception a)
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private readonly EWJWNTCJZHP WCRZDYHYTTG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			private readonly Type YZJJPDFBTQE;

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x5C99C00", Offset = "0x5C98800", VA = "0x185C99C00")]
			internal Registration(EWJWNTCJZHP errorRegistry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x5C999C0", Offset = "0x5C985C0", VA = "0x185C999C0", Slot = "4")]
			public void JKDCNYADKXB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x5C99B00", Offset = "0x5C98700", VA = "0x185C99B00", Slot = "5")]
			public XDPGJPYIZOY<T> XXOHYCICPJI(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x5C99880", Offset = "0x5C98480", VA = "0x185C99880", Slot = "6")]
			public XDPGJPYIZOY<T> HEKABYJEDDH(UserFriendlyErrorMessageBuilder<T> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x5C99980", Offset = "0x5C98580", VA = "0x185C99980", Slot = "7")]
			public XDPGJPYIZOY<T> HQBWYXWHAOK(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x5C999F0", Offset = "0x5C985F0", VA = "0x185C999F0", Slot = "8")]
			public XDPGJPYIZOY<T> QJTFXQJPNOZ(int a, GetSubCode<T> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000106")]
		private class NGGSAHHADWU<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			private bool XKMQLKHACRS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			private readonly List<Type> ZSDABORODBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			private readonly Dictionary<Type, a> YWQFMWEWLMT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			private readonly Dictionary<Type, int> QKIQKKVDDYE;

			[Cpp2IlInjected.Token(Token = "0x170000DC")]
			public IReadOnlyList<Type> YQABHUMKWLO
			{
				[Cpp2IlInjected.Token(Token = "0x60004BE")]
				[Cpp2IlInjected.Address(RVA = "0x57967F0", Offset = "0x57953F0", VA = "0x1857967F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x5797350", Offset = "0x5795F50", VA = "0x185797350")]
			public NGGSAHHADWU(Dictionary<Type, int> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x5796BC0", Offset = "0x57957C0", VA = "0x185796BC0")]
			public void Add(Type key, a val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x57970F0", Offset = "0x5795CF0", VA = "0x1857970F0")]
			public bool QWPMHLHAUVD(Type a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x5796CB0", Offset = "0x57958B0", VA = "0x185796CB0")]
			public bool BEEVCCENWPZ(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x5796EE0", Offset = "0x5795AE0", VA = "0x185796EE0")]
			public a Get(Type type)
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x5796FB0", Offset = "0x5795BB0", VA = "0x185796FB0")]
			[CompilerGenerated]
			private int PEHBBUHNSOL(Type a, Type b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class QOFCCVRSHEJ : IEnumerable<ErrorCode>, IEnumerable, IEnumerator<ErrorCode>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			private ErrorCode VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private int FTPEWITHWYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public EWJWNTCJZHP BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			private Exception WSMDIYHYEOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public Exception ZHFNKAXQBLT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private IEnumerator<Exception> KYBQTQIMGAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			private IEnumerator<ErrorCode> KYGXQXCJPLU;

			[Cpp2IlInjected.Token(Token = "0x170000DD")]
			private ErrorCode YKJSUPZPIBE
			{
				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0x16C46A0", Offset = "0x16C32A0", VA = "0x1816C46A0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ErrorCode);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000DE")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x60004CE")]
				[Cpp2IlInjected.Address(RVA = "0x8A240B0", Offset = "0x8A22CB0", VA = "0x188A240B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0xD18690", Offset = "0xD17290", VA = "0x180D18690")]
			[DebuggerHidden]
			public QOFCCVRSHEJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x8A24690", Offset = "0x8A23290", VA = "0x188A24690", Slot = "7")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x8A241A0", Offset = "0x8A22DA0", VA = "0x188A241A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0x8A24100", Offset = "0x8A22D00", VA = "0x188A24100")]
			private void LSRJDRRKPDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0x8A24150", Offset = "0x8A22D50", VA = "0x188A24150")]
			private void LTHDVLZCRLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x8A24650", Offset = "0x8A23250", VA = "0x188A24650", Slot = "10")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x8A24000", Offset = "0x8A22C00", VA = "0x188A24000", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ErrorCode> DHGAFOHKKUV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x8A24000", Offset = "0x8A22C00", VA = "0x188A24000", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private static readonly ErrorCode OCGOGRREATL;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private static readonly Dictionary<Type, int> FHPWWHIXXKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private readonly HashSet<Type> WKCXTDJCBVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private readonly NGGSAHHADWU<int> KUOEXQCXRDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly NGGSAHHADWU<GetSubCodeInternal> KMHYIRNQZSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private readonly NGGSAHHADWU<UserFriendlyErrorMessageBuilder> AYCKPUPCHMY;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x8A1EFB0", Offset = "0x8A1DBB0", VA = "0x188A1EFB0")]
		[YLZSHGPPZTN.Root.GameOnly]
		internal static void YLZSHGPPZTN(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F0E0", Offset = "0x8A1DCE0", VA = "0x188A1F0E0")]
		[RecRoom.NoEngine.Common.Preserve]
		public EWJWNTCJZHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x35B6CB0", Offset = "0x35B58B0", VA = "0x1835B6CB0", Slot = "4")]
		public XDPGJPYIZOY<T> QXDJUGOSULF<T>() where T : notnull, Exception
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E1D0", Offset = "0x8A1CDD0", VA = "0x188A1E1D0", Slot = "5")]
		public UserFriendlyErrorInfo GIZXPLNMPGO(Exception a)
		{
			return default(UserFriendlyErrorInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E260", Offset = "0x8A1CE60", VA = "0x188A1E260", Slot = "6")]
		public ErrorCode IRKRWZKVXMM(Exception? a)
		{
			return default(ErrorCode);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E140", Offset = "0x8A1CD40", VA = "0x188A1E140", Slot = "7")]
		[IteratorStateMachine(typeof(QOFCCVRSHEJ))]
		public IEnumerable<ErrorCode> FIMJJFXKJCE(Exception a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x8A1EC40", Offset = "0x8A1D840", VA = "0x188A1EC40", Slot = "8")]
		public string SPSBDTASTDK(Exception? ex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E6A0", Offset = "0x8A1D2A0", VA = "0x188A1E6A0")]
		private string MCTBRITGTKW(AggregateException a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x8A1DDD0", Offset = "0x8A1C9D0", VA = "0x188A1DDD0")]
		private void ACMJTACTXLS(Type a, int b, GetSubCodeInternal? getSubCodeInternal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x8A1ED90", Offset = "0x8A1D990", VA = "0x188A1ED90")]
		private void UPHUJGCTSEC(Type a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E9A0", Offset = "0x8A1D5A0", VA = "0x188A1E9A0")]
		private void NZVPOZDERHB(Type a, UserFriendlyErrorMessageBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E460", Offset = "0x8A1D060", VA = "0x188A1E460")]
		private static int LMVVWIPGCHN(Type a, Dictionary<Type, int> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x35B6FA0", Offset = "0x35B5BA0", VA = "0x1835B6FA0")]
		private static bool ZDPQKXHGGWE<TVal>(NGGSAHHADWU<TVal> a, Type b, [Out] TVal c) where TVal : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E5D0", Offset = "0x8A1D1D0", VA = "0x188A1E5D0")]
		[CompilerGenerated]
		internal static int LQTFWJGSXMG(Type a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public struct UserFriendlyErrorInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public readonly ErrorCode ErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public readonly string UserFriendlyMessage;

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x8A376F0", Offset = "0x8A362F0", VA = "0x188A376F0")]
		public UserFriendlyErrorInfo(string userFriendlyMessage, ErrorCode errorCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x8A37650", Offset = "0x8A36250", VA = "0x188A37650")]
		public string CFTSYQZYBEQ()
		{
			return null;
		}
	}
}
namespace RecRoom.RoomLoading.RoomOperation
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public class JKPIQQXIFJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private readonly VNCXHMYABJK GMUYUWRVSRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private string GUQIKDWNVPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private long? FHNGNHAQQLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private long? AIPXDDTTXBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private long? BQBXLQCOVHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private string KTBZEPINCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private RoomOperationState GOHKECDCCTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private long? RVRNODVSFSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private bool BUOFUUCEHAL;

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public string FQDNFPYEHQK
		{
			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public long BBNIZQUSXZK
		{
			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x8A20310", Offset = "0x8A1EF10", VA = "0x188A20310")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public long PYNGLGCYRTY
		{
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x8A20370", Offset = "0x8A1EF70", VA = "0x188A20370")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public long QJJAPPHAUMH
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x8A202B0", Offset = "0x8A1EEB0", VA = "0x188A202B0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public string QJQFBOKTRAK
		{
			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0x8A205A0", Offset = "0x8A1F1A0", VA = "0x188A205A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public RoomOperationState VMRYTZFJOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0xBF9EA0", Offset = "0xBF8AA0", VA = "0x180BF9EA0")]
			get
			{
				return default(RoomOperationState);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0x8A204B0", Offset = "0x8A1F0B0", VA = "0x188A204B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public long MWYADCNTVQN
		{
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x8A203D0", Offset = "0x8A1EFD0", VA = "0x188A203D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x8A20E80", Offset = "0x8A1FA80", VA = "0x188A20E80")]
		[UnityEngine.Scripting.Preserve]
		public JKPIQQXIFJL([Inject(null)] VNCXHMYABJK playerPreferences)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x8A20060", Offset = "0x8A1EC60", VA = "0x188A20060")]
		private void EIMJEFQVVVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x8A209F0", Offset = "0x8A1F5F0", VA = "0x188A209F0")]
		public void YDLOHJVJIJQ(long a, long b, [Optional] long? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x8A205E0", Offset = "0x8A1F1E0", VA = "0x188A205E0")]
		public void VUWRRNXGBAE(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x8A20430", Offset = "0x8A1F030", VA = "0x188A20430")]
		public void PNIWKDJCDRD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x8A20680", Offset = "0x8A1F280", VA = "0x188A20680")]
		public void WOEFHNDGAWI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	internal class VGXLHGZFUHZ : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[CompilerGenerated]
		private struct <>c__DisplayClass13_0<T> where T : IMessage<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public byte[] message;
		}

		[Cpp2IlInjected.Token(Token = "0x2000110")]
		[CompilerGenerated]
		private sealed class WYITCQAWRUI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public RECTXKHRIXS IQBGBQJOSHC;

			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public WYITCQAWRUI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0x8A38A90", Offset = "0x8A37690", VA = "0x188A38A90")]
			internal RECTXKHRIXS IDWZGWTHMER(byte[] a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000111")]
		[CompilerGenerated]
		private sealed class HSAGEGZXRUB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Func<Guid, bool> EPAZUDUIKYG;

			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HSAGEGZXRUB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0x8A1F6C0", Offset = "0x8A1E2C0", VA = "0x188A1F6C0")]
			internal object NMMKJTOEGYC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0x8A1F600", Offset = "0x8A1E200", VA = "0x188A1F600")]
			internal bool GOXUSCXEZGA(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[CompilerGenerated]
		private sealed class CBOPHOYVCOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Func<Guid, bool> SVHWHUPYLVD;

			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public CBOPHOYVCOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x8A1CCA0", Offset = "0x8A1B8A0", VA = "0x188A1CCA0")]
			internal object VLATVTWPGSU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000113")]
		[CompilerGenerated]
		private sealed class IBVXBRAKPLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			public Guid RGXEZKPPCCW;

			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public IBVXBRAKPLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050B")]
			[Cpp2IlInjected.Address(RVA = "0x8A1F720", Offset = "0x8A1E320", VA = "0x188A1F720")]
			internal object NIYDRJEJHDA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000114")]
		[CompilerGenerated]
		private sealed class MOVGRNFFFLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			public Guid RGXEZKPPCCW;

			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public MOVGRNFFFLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050D")]
			[Cpp2IlInjected.Address(RVA = "0x8A22DE0", Offset = "0x8A219E0", VA = "0x188A22DE0")]
			internal object NFZPLAAPBUV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000115")]
		[CompilerGenerated]
		private sealed class MLGXXZHXSBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			public VGXLHGZFUHZ BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public string LUYNQCGDOMM;

			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public MLGXXZHXSBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x8A22960", Offset = "0x8A21560", VA = "0x188A22960")]
			internal object IDGYAESOFYJ()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		[CompilerGenerated]
		private struct <MasterLockedBlock>d__15<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public VGXLHGZFUHZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			public int maxAttempts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x4F733C0", Offset = "0x4F71FC0", VA = "0x184F733C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x4D6FE30", Offset = "0x4D6EA30", VA = "0x184D6FE30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000117")]
		[CompilerGenerated]
		private struct <MasterLockedBlock>d__16 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public VGXLHGZFUHZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			public Func<CancellationToken, Task> masterLockedCodeBlock;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			public int maxAttempts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x8A29140", Offset = "0x8A27D40", VA = "0x188A29140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x8A29420", Offset = "0x8A28020", VA = "0x188A29420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000118")]
		[CompilerGenerated]
		private struct <MasterSendAllReceive>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public AsyncTaskMethodBuilder<RECTXKHRIXS> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public RECTXKHRIXS roomOperationMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			public VGXLHGZFUHZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000413")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000414")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			private TaskAwaiter<TNKKQUGAVHK.BufferedMessage<RECTXKHRIXS>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x8A29AE0", Offset = "0x8A286E0", VA = "0x188A29AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x8A2A020", Offset = "0x8A28C20", VA = "0x188A2A020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		[CompilerGenerated]
		private struct <MasterSendAllReceiveBufferedMessage>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public AsyncTaskMethodBuilder<TNKKQUGAVHK.BufferedMessage<RECTXKHRIXS>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public RECTXKHRIXS roomOperationMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public VGXLHGZFUHZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			private MessageKind <expectedMessageKind>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			private ByteString <expectedOperationId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			private TaskAwaiter<TNKKQUGAVHK.BufferedMessage<RECTXKHRIXS>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x8A29480", Offset = "0x8A28080", VA = "0x188A29480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x8A29A70", Offset = "0x8A28670", VA = "0x188A29A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private static readonly Guid ZCVCSIOFVRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public readonly KOQJHZNNMVK PMFJYKFTXRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private readonly TNKKQUGAVHK OJKZNRXADEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private readonly IXYEFTNMGMC GWUBCTSVVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private readonly ACVHIHCQSRD RYYOJEREOVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private bool JVGYPGBFVJO;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x8A38880", Offset = "0x8A37480", VA = "0x188A38880")]
		public VGXLHGZFUHZ(KOQJHZNNMVK a, TNKKQUGAVHK b, IXYEFTNMGMC c, ACVHIHCQSRD d, StackTimer<string>.USVZTROCTRS e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x8A37AF0", Offset = "0x8A366F0", VA = "0x188A37AF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A38260", Offset = "0x8A36E60", VA = "0x188A38260")]
		public void TTVJJTATDIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8A37B00", Offset = "0x8A36700", VA = "0x188A37B00")]
		public void ENEMVPQXOXD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x8A37890", Offset = "0x8A36490", VA = "0x188A37890")]
		public void CNKLJDAFYQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x8A38080", Offset = "0x8A36C80", VA = "0x188A38080")]
		[AsyncStateMachine(typeof(<MasterSendAllReceive>d__11))]
		internal Task<RECTXKHRIXS> SIKMTRAGJTF(StackTimer<string>.USVZTROCTRS a, RECTXKHRIXS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x3BCC170", Offset = "0x3BCAD70", VA = "0x183BCC170")]
		private static byte[] VAWVLFMFYHC<a>(a a) where a : IMessage<a>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBCF0", Offset = "0x3BCA8F0", VA = "0x183BCBCF0")]
		private static b QJVWKRNOPPL<b>(MessageParser<b> a, byte[] b, b c) where b : IMessage<b>
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x8A37DE0", Offset = "0x8A369E0", VA = "0x188A37DE0")]
		[AsyncStateMachine(typeof(<MasterSendAllReceiveBufferedMessage>d__14))]
		private Task<TNKKQUGAVHK.BufferedMessage<RECTXKHRIXS>> MBQEIQCIEYD(RECTXKHRIXS a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB750", Offset = "0x3BCA350", VA = "0x183BCB750")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__15<>))]
		internal Task<c> DQTCFOVLUUU<c>(CancellationToken a, Func<CancellationToken, Task<c>> b, int c = 3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x8A379C0", Offset = "0x8A365C0", VA = "0x188A379C0")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__16))]
		internal Task DQTCFOVLUUU(CancellationToken a, Func<CancellationToken, Task> b, int c = 3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x8A37950", Offset = "0x8A36550", VA = "0x188A37950")]
		public RoomUploadLogic DJLHTKQCUMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x8A381E0", Offset = "0x8A36DE0", VA = "0x188A381E0")]
		public UWGRWMNHMZQ TSGZWOBZRUG([Optional] AHNXITVISXR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x8A384D0", Offset = "0x8A370D0", VA = "0x188A384D0")]
		public DKLZWTJQBSR YQSINFTPFTH([Optional] Log? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x8A38380", Offset = "0x8A36F80", VA = "0x188A38380")]
		public void UVQWCQXLSYS(Func<Guid, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x8A37F70", Offset = "0x8A36B70", VA = "0x188A37F70")]
		public void NWRSSQZEGEA(Func<Guid, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x8A37710", Offset = "0x8A36310", VA = "0x188A37710")]
		public Guid AQQGIQXDRGC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x8A37BC0", Offset = "0x8A367C0", VA = "0x188A37BC0")]
		public void LVUVTFUHHOD(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x8A386D0", Offset = "0x8A372D0", VA = "0x188A386D0")]
		public void ZSOWJMFEEFJ(RECTXKHRIXS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x8A37CD0", Offset = "0x8A368D0", VA = "0x188A37CD0")]
		public void Log(string stepMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB9F0", Offset = "0x3BCA5F0", VA = "0x183BCB9F0")]
		private d DYTXKTEEJHV<d>(d a) where d : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A37F20", Offset = "0x8A36B20", VA = "0x188A37F20")]
		public void MTFKXONQYEY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x3BCBE20", Offset = "0x3BCAA20", VA = "0x183BCBE20")]
		[CompilerGenerated]
		internal static string RFAZJDZHHBN<e>(byte[] a, int b = 15, <>c__DisplayClass13_0<e> c) where e : IMessage<e>
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	internal sealed class InitialRoomLoadOperation : KOQJHZNNMVK
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		[CompilerGenerated]
		private sealed class SYNNFXFDNKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public PlayerPresence GYYDEGUYNUK;

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SYNNFXFDNKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x8A26D80", Offset = "0x8A25980", VA = "0x188A26D80")]
			internal object XXSVHPJOVWA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011C")]
		[CompilerGenerated]
		private sealed class JWFSMWPDEJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public Guid MZSFQTMTWSV;

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public JWFSMWPDEJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x8A20EC0", Offset = "0x8A1FAC0", VA = "0x188A20EC0")]
			internal object CHEWMOGSMRR()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011D")]
		[CompilerGenerated]
		private struct <EnableDisableObjectModel>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public InitialRoomLoadOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			private bool <omShouldBeEnabled>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			private TaskAwaiter<int> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x8A285C0", Offset = "0x8A271C0", VA = "0x188A285C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(RVA = "0x8A28D60", Offset = "0x8A27960", VA = "0x188A28D60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		[CompilerGenerated]
		private struct <GetSubroomSaveOMVersion>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			public InitialRoomLoadOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			private TaskAwaiter<SubRoomDataSaveWithUnityAssetsDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0x8A28DC0", Offset = "0x8A279C0", VA = "0x188A28DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000525")]
			[Cpp2IlInjected.Address(RVA = "0x8A290D0", Offset = "0x8A27CD0", VA = "0x188A290D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[CompilerGenerated]
		private struct <RunAsync>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public InitialRoomLoadOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public VGXLHGZFUHZ operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			private PlayerPresence <presence>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			private UWGRWMNHMZQ <loadLogic>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			private TaskAwaiter<Scene> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			private TaskAwaiter<DPESCDQGRWJ> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0x8A2DE70", Offset = "0x8A2CA70", VA = "0x188A2DE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x8A2ED70", Offset = "0x8A2D970", VA = "0x188A2ED70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private static readonly Log KXBXUDVNWOT;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private static readonly Log CIGOVNPNFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private readonly RoomLoadRequestPayload VGIIEVLMCLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private readonly RoomInstance OLHLMDJVYUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private readonly AHNXITVISXR UDFPYKGOJGP;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x8A1FEC0", Offset = "0x8A1EAC0", VA = "0x188A1FEC0")]
		public InitialRoomLoadOperation(RoomLoadRequestPayload initialRoomLoadPayload, RoomInstance originalTargetRoomInstance, Guid operationId, IIDBRQOYHQN roomManager, AFCWAAKQTIP operationPauseToken, AHNXITVISXR preloadContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x8A1FAC0", Offset = "0x8A1E6C0", VA = "0x188A1FAC0", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__8))]
		protected override Task UJRVLHQIZMI(VGXLHGZFUHZ a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F8B0", Offset = "0x8A1E4B0", VA = "0x188A1F8B0")]
		[AsyncStateMachine(typeof(<EnableDisableObjectModel>d__9))]
		private Task EnableDisableObjectModel(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F9B0", Offset = "0x8A1E5B0", VA = "0x188A1F9B0")]
		[AsyncStateMachine(typeof(<GetSubroomSaveOMVersion>d__10))]
		private Task<int> THACJKMSQMF(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x8A1FC10", Offset = "0x8A1E810", VA = "0x188A1FC10")]
		private PlayerPresence WFKBEPTMUGM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	internal class POLKJBXNXXZ : KOQJHZNNMVK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		[CompilerGenerated]
		private struct <RunAsync>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public POLKJBXNXXZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public VGXLHGZFUHZ operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0x8A2EDD0", Offset = "0x8A2D9D0", VA = "0x188A2EDD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0x8A2F770", Offset = "0x8A2E370", VA = "0x188A2F770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private readonly int WMLQYOWGTOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private readonly QLEODJJBPHT XAPCMEDJZAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public readonly long DMMXAHIJOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public readonly long VUZFOFGUPSR;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public SaveSubRoomResponseDTO AUJLVVCAXRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0xA9D1D0", Offset = "0xA9BDD0", VA = "0x180A9D1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0xA9D160", Offset = "0xA9BD60", VA = "0x180A9D160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x8A23320", Offset = "0x8A21F20", VA = "0x188A23320")]
		public POLKJBXNXXZ(Guid a, IIDBRQOYHQN b, AFCWAAKQTIP c, int d, QLEODJJBPHT e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x8A23200", Offset = "0x8A21E00", VA = "0x188A23200", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__9))]
		protected override Task UJRVLHQIZMI(VGXLHGZFUHZ a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal abstract class ENMWDUYYZQV : KOQJHZNNMVK
	{
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[CompilerGenerated]
		private sealed class FWKMQDTJZYX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public ENMWDUYYZQV BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public IDisposable LOBGKCQDKQT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public LCJSFIUQQGR WRMEDGDGVXK;

			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public FWKMQDTJZYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0x8A1F530", Offset = "0x8A1E130", VA = "0x188A1F530")]
			internal Task DCNBPDPKRKQ(StackTimer<string>.USVZTROCTRS a, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0x8A1F570", Offset = "0x8A1E170", VA = "0x188A1F570")]
			internal object DCSIMKJIAVZ()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000124")]
		[CompilerGenerated]
		private struct <RespawnPlayer>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public StackTimer<string>.USVZTROCTRS timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public IDisposable freezePlayerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public LCJSFIUQQGR playerDespawn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public ENMWDUYYZQV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x8A2B0A0", Offset = "0x8A29CA0", VA = "0x188A2B0A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x8A2B660", Offset = "0x8A2A260", VA = "0x188A2B660", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000125")]
		[CompilerGenerated]
		private struct <RunAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public ENMWDUYYZQV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public VGXLHGZFUHZ operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			private FWKMQDTJZYX <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x8A2B6C0", Offset = "0x8A2A2C0", VA = "0x188A2B6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0x8A2C350", Offset = "0x8A2AF50", VA = "0x188A2C350", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x8A1DD80", Offset = "0x8A1C980", VA = "0x188A1DD80")]
		public ENMWDUYYZQV(Guid a, IIDBRQOYHQN b, AFCWAAKQTIP c, string d, RequestOperationType e, bool f = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x8A1DBD0", Offset = "0x8A1C7D0", VA = "0x188A1DBD0", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__2))]
		protected override Task UJRVLHQIZMI(VGXLHGZFUHZ a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract Task MFHOBPMOLCB(VGXLHGZFUHZ a, StackTimer<string>.USVZTROCTRS b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x8A1DA90", Offset = "0x8A1C690", VA = "0x188A1DA90")]
		[AsyncStateMachine(typeof(<RespawnPlayer>d__4))]
		private Task EGLLETZLVWA(IDisposable a, LCJSFIUQQGR b, StackTimer<string>.USVZTROCTRS c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	internal class RMKGZDWLCPB : KOQJHZNNMVK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		[CompilerGenerated]
		private struct <RunAsync>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public RMKGZDWLCPB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public VGXLHGZFUHZ operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			private long <roomId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private long <subroomId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private TaskAwaiter<RoomSerializedData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0x8A2C410", Offset = "0x8A2B010", VA = "0x188A2C410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053E")]
			[Cpp2IlInjected.Address(RVA = "0x8A2C9A0", Offset = "0x8A2B5A0", VA = "0x188A2C9A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private readonly AutosaveType AOSXNRGYNFT;

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x8A24AF0", Offset = "0x8A236F0", VA = "0x188A24AF0")]
		public RMKGZDWLCPB(Guid a, IIDBRQOYHQN b, AFCWAAKQTIP c, AutosaveType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x8A248F0", Offset = "0x8A234F0", VA = "0x188A248F0", Slot = "6")]
		protected override string FMRHSTOIJMZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x8A249D0", Offset = "0x8A235D0", VA = "0x188A249D0", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__3))]
		protected override Task UJRVLHQIZMI(VGXLHGZFUHZ a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	internal abstract class KOQJHZNNMVK : EZGITPQOHXD
	{
		[Cpp2IlInjected.Token(Token = "0x2000129")]
		public delegate Task PostOperationTaskBuilder(StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x200012A")]
		[CompilerGenerated]
		private sealed class BLUSZPLEKLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public StackTimer<string>.USVZTROCTRS GUGYDTLKBPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public KOQJHZNNMVK BIVSZSMQJUR;

			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public BLUSZPLEKLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x8A1CAB0", Offset = "0x8A1B6B0", VA = "0x188A1CAB0")]
			internal Task KKQQARYSNEL(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class BLZZWWFBTWN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public Exception WSMDIYHYEOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			public BLUSZPLEKLE CFCUCJZVXTS;

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public BLZZWWFBTWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0x8A1CBE0", Offset = "0x8A1B7E0", VA = "0x188A1CBE0")]
			internal object KKVWXYSPWPU()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012C")]
		[CompilerGenerated]
		private struct <DriverCombinedTask>d__31 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			public Func<CancellationToken, Task> createDriverTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			public Func<CancellationToken, Task> originalTaskBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			private CancellationTokenSource <driverCancellationTokenSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			private Task <driverTask>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			private Task <originalTask>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			private TaskAwaiter<Task> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x8A27AC0", Offset = "0x8A266C0", VA = "0x188A27AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0x8A28560", Offset = "0x8A27160", VA = "0x188A28560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		[CompilerGenerated]
		private struct <Run>d__30 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			public KOQJHZNNMVK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public Func<KOQJHZNNMVK, StackTimer<string>.USVZTROCTRS, VGXLHGZFUHZ> operationContextBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			private BLUSZPLEKLE <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private bool <success>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			private VGXLHGZFUHZ <operationContext>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private TaskAwaiter<RECTXKHRIXS> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x8A31AA0", Offset = "0x8A306A0", VA = "0x188A31AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x8A32D60", Offset = "0x8A31960", VA = "0x188A32D60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[CompilerGenerated]
		private struct <RunPostOperationTasks>d__35 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			public KOQJHZNNMVK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x8A30B00", Offset = "0x8A2F700", VA = "0x188A30B00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x8A30E60", Offset = "0x8A2FA60", VA = "0x188A30E60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public readonly Guid DHODELSEGWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public readonly ByteString OCIXBSWGFSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public readonly AFCWAAKQTIP AFCWAAKQTIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		protected readonly string NYONWMDEKCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private readonly IIDBRQOYHQN PNSRTVKXRGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private readonly bool UWOJTVEMODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private readonly Queue<PostOperationTaskBuilder> KOWUPUPNWCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private readonly KLHAZPAKHTU MSQXEHDSLXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private readonly RequestOperationType DKBSXUMOMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private bool NDPZFZLBNQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public RoomOperationState MCIZLRAVKJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public RoomOperationState KTJRLTDMCXE;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public IIDBRQOYHQN KDKTQYKQZVJ
		{
			[Cpp2IlInjected.Token(Token = "0x600053F")]
			[Cpp2IlInjected.Address(RVA = "0xA98620", Offset = "0xA97220", VA = "0x180A98620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public UFFFZRRBPXW SPGVRHHBWNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0x8A211E0", Offset = "0x8A1FDE0", VA = "0x188A211E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public GCIVRRRUWLZ COPGCDGWBCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000541")]
			[Cpp2IlInjected.Address(RVA = "0x8A21540", Offset = "0x8A20140", VA = "0x188A21540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public IHOYXZOJIJC RRESXEGEGKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000542")]
			[Cpp2IlInjected.Address(RVA = "0x8A20F30", Offset = "0x8A1FB30", VA = "0x188A20F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event ProgressUpdate ZFTZEGDXMTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0x8A21A70", Offset = "0x8A20670", VA = "0x188A21A70", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000544")]
			[Cpp2IlInjected.Address(RVA = "0x8A21400", Offset = "0x8A20000", VA = "0x188A21400", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x8A21A90", Offset = "0x8A20690", VA = "0x188A21A90")]
		protected KOQJHZNNMVK(Guid a, IIDBRQOYHQN b, AFCWAAKQTIP c, string d, RequestOperationType e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x8A21250", Offset = "0x8A1FE50", VA = "0x188A21250", Slot = "6")]
		protected virtual string FMRHSTOIJMZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x8A21A10", Offset = "0x8A20610", VA = "0x188A21A10")]
		public void YDSRJOTQGRF(PostOperationTaskBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x8A21230", Offset = "0x8A1FE30", VA = "0x188A21230")]
		protected void DXZHCCYKWYW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x8A21840", Offset = "0x8A20440", VA = "0x188A21840")]
		[AsyncStateMachine(typeof(<Run>d__30))]
		public Task Run(CancellationToken cancellationToken, StackTimer<string>.USVZTROCTRS stackTimer, [Optional] Func<KOQJHZNNMVK, StackTimer<string>.USVZTROCTRS, VGXLHGZFUHZ> operationContextBuilder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x8A21710", Offset = "0x8A20310", VA = "0x188A21710")]
		[AsyncStateMachine(typeof(<DriverCombinedTask>d__31))]
		private static Task RYBQVKRUWLZ(Func<CancellationToken, Task> a, Func<CancellationToken, Task> b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8A21590", Offset = "0x8A20190", VA = "0x188A21590")]
		private void RPYDGCIETSE(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x8A20FB0", Offset = "0x8A1FBB0", VA = "0x188A20FB0")]
		private void BHPYKHOTVKP(VGXLHGZFUHZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract Task UJRVLHQIZMI(VGXLHGZFUHZ a, StackTimer<string>.USVZTROCTRS b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x8A21420", Offset = "0x8A20020", VA = "0x188A21420")]
		[AsyncStateMachine(typeof(<RunPostOperationTasks>d__35))]
		private Task KKAMILVRDZR(StackTimer<string>.USVZTROCTRS a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x8A21990", Offset = "0x8A20590", VA = "0x188A21990")]
		public RECTXKHRIXS SWOZXNOOQSK(MessageKind a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x8A21290", Offset = "0x8A1FE90", VA = "0x188A21290")]
		[CompilerGenerated]
		private Task IKAZRGYAEMQ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x8A21380", Offset = "0x8A1FF80", VA = "0x188A21380")]
		[CompilerGenerated]
		private object IKQUJBFSGUR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	internal sealed class COTGRDXIIYW : ENMWDUYYZQV
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000130")]
		[CompilerGenerated]
		private struct <RunWhilePlayerDespawnedAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public COTGRDXIIYW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public VGXLHGZFUHZ operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			private RoomEvent <roomEvent>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			private UWGRWMNHMZQ <loadLogic>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0x8A32DC0", Offset = "0x8A319C0", VA = "0x188A32DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x8A33510", Offset = "0x8A32110", VA = "0x188A33510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private readonly RoomLoadRequestPayload EHFVCFDTNAZ;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x8A1CF90", Offset = "0x8A1BB90", VA = "0x188A1CF90")]
		public COTGRDXIIYW(Guid a, IIDBRQOYHQN b, RoomLoadRequestPayload c, AFCWAAKQTIP d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x8A1CE40", Offset = "0x8A1BA40", VA = "0x188A1CE40", Slot = "8")]
		[AsyncStateMachine(typeof(<RunWhilePlayerDespawnedAsync>d__2))]
		protected override Task MFHOBPMOLCB(VGXLHGZFUHZ a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	internal class DDRGZFYJKJY : KOQJHZNNMVK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		[CompilerGenerated]
		private struct <RunAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			public DDRGZFYJKJY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			public VGXLHGZFUHZ operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			private TaskAwaiter<RoomSerializedData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(RVA = "0x8A2BFA0", Offset = "0x8A2ABA0", VA = "0x188A2BFA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0x8A2C3B0", Offset = "0x8A2AFB0", VA = "0x188A2C3B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private readonly string FSNIWVEPOZI;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D170", Offset = "0x8A1BD70", VA = "0x188A1D170")]
		public DDRGZFYJKJY(Guid a, IIDBRQOYHQN b, AFCWAAKQTIP c, string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D060", Offset = "0x8A1BC60", VA = "0x188A1D060", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__2))]
		protected override Task UJRVLHQIZMI(VGXLHGZFUHZ a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	internal class RoomSaveToRecNetOperation : ENMWDUYYZQV
	{
		[Cpp2IlInjected.Token(Token = "0x2000134")]
		[CompilerGenerated]
		private sealed class TBVOZRUCJVY
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000135")]
			private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004B2")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40004B3")]
				public AsyncTaskMethodBuilder<RECTXKHRIXS> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40004B4")]
				public TBVOZRUCJVY <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40004B5")]
				public CancellationToken masterLockedCodeBlockCancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40004B6")]
				private TaskAwaiter<RoomSerializedData> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40004B7")]
				private TaskAwaiter<RECTXKHRIXS> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600056D")]
				[Cpp2IlInjected.Address(RVA = "0x8A34B90", Offset = "0x8A33790", VA = "0x188A34B90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600056E")]
				[Cpp2IlInjected.Address(RVA = "0x8A35070", Offset = "0x8A33C70", VA = "0x188A35070", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004AA")]
			public RoomSaveToRecNetOperation BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004AB")]
			public DKLZWTJQBSR NROLQIDQSOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004AC")]
			public long EYBJRVHSVUF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004AD")]
			public RoomSaveOptions DMIRDGCSHEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004AE")]
			public RoomUploadLogic RFHMCDQYCPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004AF")]
			public long WLWDWVEIKFS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004B0")]
			public RoomSaveAnalyticsInfo AQAXPVIQJNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			public StackTimer<string>.USVZTROCTRS BUREXCMRKUO;

			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public TBVOZRUCJVY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(RVA = "0x8A26EC0", Offset = "0x8A25AC0", VA = "0x188A26EC0")]
			[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
			internal Task<RECTXKHRIXS> FXZFMAQVQDB(CancellationToken a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000136")]
		[CompilerGenerated]
		private struct <RunWhilePlayerDespawnedAsync>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004B9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			public RoomSaveToRecNetOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004BC")]
			public VGXLHGZFUHZ operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004BD")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004BE")]
			private TBVOZRUCJVY <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			private RoomEvent <roomEvent>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			private UWGRWMNHMZQ <loadLogic>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			private RECTXKHRIXS <saveReloadMessage>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			private TaskAwaiter<RECTXKHRIXS> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x8A33570", Offset = "0x8A32170", VA = "0x188A33570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0x8A343C0", Offset = "0x8A32FC0", VA = "0x188A343C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private static readonly Log KXBXUDVNWOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private readonly int VVAWITLZNZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		[CanBeNull]
		private readonly RoomSaveRequestPayload RRJLQVCSANO;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x8A26CB0", Offset = "0x8A258B0", VA = "0x188A26CB0")]
		public RoomSaveToRecNetOperation(Guid operationId, IIDBRQOYHQN roomManager, int savingPlayerAccountId, RoomSaveRequestPayload roomSaveRequestPayload, AFCWAAKQTIP operationPauseToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x8A26800", Offset = "0x8A25400", VA = "0x188A26800", Slot = "8")]
		[AsyncStateMachine(typeof(<RunWhilePlayerDespawnedAsync>d__5))]
		protected override Task MFHOBPMOLCB(VGXLHGZFUHZ a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x8A26940", Offset = "0x8A25540", VA = "0x188A26940")]
		private void QUZGFHJAVEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x8A26A30", Offset = "0x8A25630", VA = "0x188A26A30")]
		private void WNUCECTMXEZ(StackTimer<string>.USVZTROCTRS a, RoomEvent b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	internal class YNVPMWWTOGB : KOQJHZNNMVK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000138")]
		[CompilerGenerated]
		private struct <RunAsync>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C9")]
			public YNVPMWWTOGB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004CA")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004CC")]
			private RoomEvent <roomEvent>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			private long <superRoomId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			private long <subRoomId>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			private SubRoomDataSaveWithUnityAssetsDTO <currentRoomSave>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			private PXOZILLORTN<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			private TaskAwaiter<SubRoomDataSaveWithUnityAssetsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004D2")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40004D3")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004D4")]
			private TaskAwaiter <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x8A2CA00", Offset = "0x8A2B600", VA = "0x188A2CA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x8A2DE10", Offset = "0x8A2CA10", VA = "0x188A2DE10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private readonly int VVAWITLZNZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private readonly RoomSaveRequestPayload RRJLQVCSANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private Func<RoomSerializedData, RoomSerializedData> FFAQWLQZDEJ;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x8A39180", Offset = "0x8A37D80", VA = "0x188A39180")]
		public YNVPMWWTOGB(Guid a, IIDBRQOYHQN b, int c, RoomSaveRequestPayload d, Func<RoomSerializedData, RoomSerializedData> e, AFCWAAKQTIP f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x8A39050", Offset = "0x8A37C50", VA = "0x188A39050", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__4))]
		protected override Task UJRVLHQIZMI(VGXLHGZFUHZ a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	internal abstract class MOCIFKPOHOS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public readonly KOQJHZNNMVK PMFJYKFTXRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public readonly VGXLHGZFUHZ VGXLHGZFUHZ;

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public UFFFZRRBPXW SPGVRHHBWNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x8A22C20", Offset = "0x8A21820", VA = "0x188A22C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public IHOYXZOJIJC RRESXEGEGKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x8A22B90", Offset = "0x8A21790", VA = "0x188A22B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x8A22D80", Offset = "0x8A21980", VA = "0x188A22D80")]
		protected MOCIFKPOHOS(VGXLHGZFUHZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x8A22C70", Offset = "0x8A21870", VA = "0x188A22C70")]
		protected void Log(string stepMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	internal struct DeserializationHandlerLists
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public Dictionary<Guid, List<DeserializationPhaseHandler>> AuthorityHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public Dictionary<Guid, List<DeserializationPhaseHandler>> AllHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public Dictionary<Guid, List<DeserializationPhaseHandler>> NonAuthorityHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public List<Guid> IDList;

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x8A1D220", Offset = "0x8A1BE20", VA = "0x188A1D220")]
		public static DeserializationHandlerLists Get(UFFFZRRBPXW callbacks, RoomOperationState operationState, HQPJHIWQEWM deserializationData)
		{
			return default(DeserializationHandlerLists);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	internal struct LogRoomLoadMetrics
	{
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370")]
		public static LogRoomLoadMetrics Create()
		{
			return default(LogRoomLoadMetrics);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	internal struct RoomLoadDetails
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public readonly RoomDetailsDTO roomDetails;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public readonly SubRoomDTO subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public readonly Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public readonly IReadOnlyCollection<BakedUnitySubAssetDTO> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public readonly IReadOnlyCollection<BakedUnitySubAssetDTO> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public readonly FilenameWithHash superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public readonly FilenameWithHash subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public readonly RoomLoadDTO roomLoad;

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public bool WIOJLUSNLOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x8A24B90", Offset = "0x8A23790", VA = "0x188A24B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x8A24C20", Offset = "0x8A23820", VA = "0x188A24C20")]
		public RoomLoadDetails(RoomDetailsDTO roomDetails, SubRoomDTO subRoom, Guid? unityAssetId, IReadOnlyList<BakedUnitySubAssetDTO> unitySubAssets, IReadOnlyCollection<BakedUnitySubAssetDTO> referencedUnityAssets, FilenameWithHash superRoomData, FilenameWithHash subRoomData, RoomLoadDTO roomLoad)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	internal struct RoomLoadLifetime : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private readonly VGXLHGZFUHZ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private readonly Guid sliceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private bool success;

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x8A24CD0", Offset = "0x8A238D0", VA = "0x188A24CD0")]
		public static RoomLoadLifetime AQQGIQXDRGC(VGXLHGZFUHZ a)
		{
			return default(RoomLoadLifetime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x10BA490", Offset = "0x10B9090", VA = "0x1810BA490")]
		public void AJKRJYFEKCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x8A24D00", Offset = "0x8A23900", VA = "0x188A24D00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x8A24FE0", Offset = "0x8A23BE0", VA = "0x188A24FE0")]
		private RoomLoadLifetime(VGXLHGZFUHZ operationContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x8A24D10", Offset = "0x8A23910", VA = "0x188A24D10")]
		private void LVUVTFUHHOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x8A24F40", Offset = "0x8A23B40", VA = "0x188A24F40")]
		private Func<Guid, bool> WTIHIASDFWA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	internal class UWGRWMNHMZQ : MOCIFKPOHOS, EZGITPQOHXD
	{
		[Cpp2IlInjected.Token(Token = "0x2000140")]
		public delegate Task<RoomOperationState> RoomLoadFunction(HQPJHIWQEWM data, UNZKMWWMNXW yielder, KLHAZPAKHTU progressTracker, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000142")]
		[CompilerGenerated]
		private sealed class QDZMHQJBVSL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000143")]
			private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004FF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000500")]
				public AsyncTaskMethodBuilder<RoomLoadDetails> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000501")]
				public QDZMHQJBVSL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000502")]
				public CancellationToken innerCancellation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000503")]
				private RoomLoadDetails <innerData>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
				[Cpp2IlInjected.Token(Token = "0x4000504")]
				private TaskAwaiter<RoomOperationState> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
				[Cpp2IlInjected.Token(Token = "0x4000505")]
				private TaskAwaiter<RoomLoadDetails> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0x8A4EF00", Offset = "0x8A4DB00", VA = "0x188A4EF00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0x8A4F7C0", Offset = "0x8A4E3C0", VA = "0x188A4F7C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000144")]
			private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000506")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000507")]
				public AsyncTaskMethodBuilder<HQPJHIWQEWM> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000508")]
				public QDZMHQJBVSL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000509")]
				public CancellationToken innerCancellation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400050A")]
				private HQPJHIWQEWM <innerPhaseArgs>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400050B")]
				private TaskAwaiter<RoomOperationState> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400050C")]
				private TaskAwaiter<HQPJHIWQEWM> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x8A4F830", Offset = "0x8A4E430", VA = "0x188A4F830", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x8A4FE70", Offset = "0x8A4EA70", VA = "0x188A4FE70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public UWGRWMNHMZQ BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public RoomLoadRequestPayload ELIJPWFRWFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			public KLHAZPAKHTU DQDBAPYVHDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			public StackTimer<string>.USVZTROCTRS BUREXCMRKUO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			public KLHAZPAKHTU CUJRLCOSKWY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public RoomLoadDetails HIVBQTYRTXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			public KLHAZPAKHTU CEYTGATXNPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			public HQPJHIWQEWM LLRRBDEWWYL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			public RecNet.Core.OnDownloadProgressDelegate HVWDSFHTOAF;

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public QDZMHQJBVSL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x8A3D2F0", Offset = "0x8A3BEF0", VA = "0x188A3D2F0")]
			[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
			internal Task<RoomLoadDetails> CCNZTCJRSAW(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x8A3D1D0", Offset = "0x8A3BDD0", VA = "0x188A3D1D0")]
			[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
			internal Task<HQPJHIWQEWM> CCDLYOVWZEE(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x8A3D4C0", Offset = "0x8A3C0C0", VA = "0x188A3D4C0")]
			internal void CDJBIDLHDUG(long a, long b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x8A3D480", Offset = "0x8A3C080", VA = "0x188A3D480")]
			internal Task CDDUKWRJUIX(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x8A3D440", Offset = "0x8A3C040", VA = "0x188A3D440")]
			internal Task CCYNNPXMKXO(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000145")]
		[CompilerGenerated]
		private sealed class WYHCEAGTYYL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000146")]
			private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000514")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000515")]
				public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000516")]
				public WYHCEAGTYYL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000517")]
				public CancellationToken mlToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000518")]
				private LogRangeScope <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000519")]
				private TaskAwaiter<RoomOperationState> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60005C1")]
				[Cpp2IlInjected.Address(RVA = "0x8A4FEE0", Offset = "0x8A4EAE0", VA = "0x188A4FEE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C2")]
				[Cpp2IlInjected.Address(RVA = "0x8A503A0", Offset = "0x8A4EFA0", VA = "0x188A503A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public UWGRWMNHMZQ BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public RoomLoadFunction NKVKEQEMBMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			public HQPJHIWQEWM HIVBQTYRTXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public UNZKMWWMNXW MHNBUURNCMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public KLHAZPAKHTU GDKHWHBNAIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			public StackTimer<string>.USVZTROCTRS BUREXCMRKUO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			public RoomOperationState VWZZGBHGWLA;

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public WYHCEAGTYYL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x8A51A70", Offset = "0x8A50670", VA = "0x188A51A70")]
			[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
			internal Task<RoomOperationState> RQBMWVQDKPH(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000147")]
		[CompilerGenerated]
		private sealed class IVGASKPNRID
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000148")]
			private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400051C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400051D")]
				public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400051E")]
				public IVGASKPNRID <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400051F")]
				public HQPJHIWQEWM data;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000520")]
				public KLHAZPAKHTU progressTracker;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000521")]
				public StackTimer<string>.USVZTROCTRS stackTimer;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000522")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000523")]
				private TaskAwaiter<RoomOperationState> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000524")]
				private TaskAwaiter <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000525")]
				private TaskAwaiter<RRSceneLoadOperation> <>u__3;

				[Cpp2IlInjected.Token(Token = "0x60005C5")]
				[Cpp2IlInjected.Address(RVA = "0x8A50410", Offset = "0x8A4F010", VA = "0x188A50410", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C6")]
				[Cpp2IlInjected.Address(RVA = "0x8A50ED0", Offset = "0x8A4FAD0", VA = "0x188A50ED0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051A")]
			public UWGRWMNHMZQ BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400051B")]
			public XIPODHIVCEO MXDPMZHQHWV;

			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public IVGASKPNRID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x8A3C7B0", Offset = "0x8A3B3B0", VA = "0x188A3C7B0")]
			[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
			internal Task<RoomOperationState> ASOYOQZJTYS(HQPJHIWQEWM a, UNZKMWWMNXW b, KLHAZPAKHTU c, StackTimer<string>.USVZTROCTRS d, CancellationToken e)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000149")]
		[CompilerGenerated]
		private struct <CreateCV1Mappings>d__35 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x8A3DA60", Offset = "0x8A3C660", VA = "0x188A3DA60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x8A3DC90", Offset = "0x8A3C890", VA = "0x188A3DC90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014A")]
		[CompilerGenerated]
		private struct <DeserializeAllObjects>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			public KLHAZPAKHTU progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			public UNZKMWWMNXW timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private StackTimer<string>.USVZTROCTRS <deserializeAllObjectsTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x8A3E380", Offset = "0x8A3CF80", VA = "0x188A3E380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x8A3F490", Offset = "0x8A3E090", VA = "0x188A3F490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014B")]
		[CompilerGenerated]
		private struct <DeserializeAllObjectsR2>d__49 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			public KLHAZPAKHTU progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400053C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400053D")]
			private StackTimer<string>.USVZTROCTRS <deserializeAllObjectsTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400053F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x8A3DCF0", Offset = "0x8A3C8F0", VA = "0x188A3DCF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x8A3E310", Offset = "0x8A3CF10", VA = "0x188A3E310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014C")]
		[CompilerGenerated]
		private struct <DestroyOldObjects>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			public bool useCompletionMark;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x8A3F500", Offset = "0x8A3E100", VA = "0x188A3F500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x8A3F7F0", Offset = "0x8A3E3F0", VA = "0x188A3F7F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014D")]
		[CompilerGenerated]
		private struct <DestroyR1Objects>d__47 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x8A3F850", Offset = "0x8A3E450", VA = "0x188A3F850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x8A3FC50", Offset = "0x8A3E850", VA = "0x188A3FC50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014E")]
		[CompilerGenerated]
		private struct <GetSyncedRoomLoadPayload>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			public AsyncTaskMethodBuilder<RECTXKHRIXS> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			private StackTimer<string>.USVZTROCTRS <syncTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			private TaskAwaiter<RECTXKHRIXS> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x8A41860", Offset = "0x8A40460", VA = "0x188A41860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x8A41C90", Offset = "0x8A40890", VA = "0x188A41C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014F")]
		[CompilerGenerated]
		private struct <LegacyLoadRoomData>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			public KLHAZPAKHTU progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			private StackTimer<string>.USVZTROCTRS <legacyLoadRoomDataTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x8A41D00", Offset = "0x8A40900", VA = "0x188A41D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x8A42540", Offset = "0x8A41140", VA = "0x188A42540", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000150")]
		[CompilerGenerated]
		private struct <LoadRoomLocal>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			public CancellationToken externalCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			private QDZMHQJBVSL <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			private TaskAwaiter<RoomLoadDetails> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			private TaskAwaiter<HQPJHIWQEWM> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x8A42AC0", Offset = "0x8A416C0", VA = "0x188A42AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0x8A43720", Offset = "0x8A42320", VA = "0x188A43720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		[CompilerGenerated]
		private struct <LoadRoomLocalTimed>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			private StackTimer<string>.USVZTROCTRS <loadRoomLocalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x8A425A0", Offset = "0x8A411A0", VA = "0x188A425A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x8A42A60", Offset = "0x8A41660", VA = "0x188A42A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000152")]
		[CompilerGenerated]
		private struct <MasterLockedPhaseChangeBlock>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000576")]
			public RoomLoadFunction masterLockedCode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000578")]
			public UNZKMWWMNXW timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000579")]
			public KLHAZPAKHTU progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400057A")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x8A43780", Offset = "0x8A42380", VA = "0x188A43780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x8A43C90", Offset = "0x8A42890", VA = "0x188A43C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000153")]
		[CompilerGenerated]
		private struct <MoveThroughRemainingPhases>d__29 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			public KLHAZPAKHTU progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			private RoomOperationState <legacyEndPhase>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			private IEnumerator<RoomOperationState> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0x8A43D00", Offset = "0x8A42900", VA = "0x188A43D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x8A44250", Offset = "0x8A42E50", VA = "0x188A44250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[CompilerGenerated]
		private struct <MoveToPhase>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400058A")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			public RoomOperationState operationState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			public KLHAZPAKHTU progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			public HQPJHIWQEWM deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400058F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000590")]
			public bool skipHandlers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x8A442B0", Offset = "0x8A42EB0", VA = "0x188A442B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0x8A44510", Offset = "0x8A43110", VA = "0x188A44510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000155")]
		[CompilerGenerated]
		private struct <RoomV1DestroyAndRebuildObjects>d__24 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			public KLHAZPAKHTU progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			private StackTimer<string>.USVZTROCTRS <destroyAndRebuildObjectsTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400059B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0x8A44580", Offset = "0x8A43180", VA = "0x188A44580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x8A45540", Offset = "0x8A44140", VA = "0x188A45540", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000156")]
		[CompilerGenerated]
		private struct <RoomV1LoadLogic>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			public HQPJHIWQEWM phaseArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005A1")]
			public KLHAZPAKHTU postDownloadProgress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005A3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005A4")]
			private TaskAwaiter<RoomOperationState> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005A5")]
			private UNZKMWWMNXW <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0x8A455B0", Offset = "0x8A441B0", VA = "0x188A455B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x8A463E0", Offset = "0x8A44FE0", VA = "0x188A463E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000157")]
		[CompilerGenerated]
		private struct <RoomV2LoadLogic>d__46 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public HQPJHIWQEWM phaseArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005AB")]
			public KLHAZPAKHTU postDownloadProgress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005AC")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005AD")]
			private IVGASKPNRID <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005AE")]
			private UNZKMWWMNXW <timedYielder>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005AF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			private TaskAwaiter<RoomOperationState> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x8A46440", Offset = "0x8A45040", VA = "0x188A46440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x8A47250", Offset = "0x8A45E50", VA = "0x188A47250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000158")]
		[CompilerGenerated]
		private struct <SyncLoadRoom>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005B2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005B3")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B4")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			private RoomLoadLifetime <lifetime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			private TaskAwaiter<RECTXKHRIXS> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40005B9")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D240", Offset = "0x8A4BE40", VA = "0x188A4D240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D990", Offset = "0x8A4C590", VA = "0x188A4D990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		[CompilerGenerated]
		private struct <TriggerBigDataNetworkManager>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005BC")]
			public UWGRWMNHMZQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005BD")]
			public StackTimer<string>.USVZTROCTRS timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005BE")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005BF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D9F0", Offset = "0x8A4C5F0", VA = "0x188A4D9F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x8A4E1D0", Offset = "0x8A4CDD0", VA = "0x188A4E1D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private readonly Token IRNACNTVQIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private readonly Token LVPBGXBAJZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private readonly JKPIQQXIFJL LKGEIDUUUVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private readonly HWJKLFSNWJL UGQVCETFGIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private readonly MoveToPhaseTask TUAQSSFHFRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private ProfilerCounterValue<int> FRRVMGFTOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private readonly XIXSZZOTXCN FUNULUAMJTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private readonly AHNXITVISXR UDFPYKGOJGP;

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		private IIDBRQOYHQN KDKTQYKQZVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x8A37120", Offset = "0x8A35D20", VA = "0x188A37120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event ProgressUpdate ZFTZEGDXMTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x8A37370", Offset = "0x8A35F70", VA = "0x188A37370", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x8A361F0", Offset = "0x8A34DF0", VA = "0x188A361F0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x8A37390", Offset = "0x8A35F90", VA = "0x188A37390")]
		public UWGRWMNHMZQ(VGXLHGZFUHZ a, AHNXITVISXR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x8A369A0", Offset = "0x8A355A0", VA = "0x188A369A0")]
		[AsyncStateMachine(typeof(<SyncLoadRoom>d__17))]
		public Task RXDGIDISGGD(RoomLoadRequestPayload a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x8A36070", Offset = "0x8A34C70", VA = "0x188A36070")]
		[AsyncStateMachine(typeof(<GetSyncedRoomLoadPayload>d__18))]
		private Task<RECTXKHRIXS> IUMCUTXBFKC(RoomLoadRequestPayload a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x8A37190", Offset = "0x8A35D90", VA = "0x188A37190")]
		[AsyncStateMachine(typeof(<LoadRoomLocalTimed>d__19))]
		private Task XKGKNSHRPFU(RoomLoadRequestPayload a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x8A364B0", Offset = "0x8A350B0", VA = "0x188A364B0")]
		[AsyncStateMachine(typeof(<LoadRoomLocal>d__20))]
		private Task LoadRoomLocal(RoomLoadRequestPayload request, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken externalCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x8A36210", Offset = "0x8A34E10", VA = "0x188A36210")]
		[AsyncStateMachine(typeof(<RoomV1LoadLogic>d__21))]
		private Task KYALTTJJWIB(HQPJHIWQEWM a, KLHAZPAKHTU b, StackTimer<string>.USVZTROCTRS c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x8A36C50", Offset = "0x8A35850", VA = "0x188A36C50")]
		[AsyncStateMachine(typeof(<TriggerBigDataNetworkManager>d__22))]
		private Task VEQVIMUBMKY(StackTimer<string>.USVZTROCTRS a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x8A36360", Offset = "0x8A34F60", VA = "0x188A36360")]
		[AsyncStateMachine(typeof(<LegacyLoadRoomData>d__23))]
		private Task LegacyLoadRoomData(HQPJHIWQEWM data, KLHAZPAKHTU progressTracker, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x8A36AF0", Offset = "0x8A356F0", VA = "0x188A36AF0")]
		[AsyncStateMachine(typeof(<RoomV1DestroyAndRebuildObjects>d__24))]
		private Task<RoomOperationState> SWEUBMVUYQT(HQPJHIWQEWM a, UNZKMWWMNXW b, KLHAZPAKHTU c, StackTimer<string>.USVZTROCTRS d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x8A35A40", Offset = "0x8A34640", VA = "0x188A35A40")]
		[AsyncStateMachine(typeof(<DeserializeAllObjects>d__25))]
		private Task<RoomOperationState> DeserializeAllObjects(HQPJHIWQEWM data, UNZKMWWMNXW timedYielder, KLHAZPAKHTU progressTracker, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x8A357D0", Offset = "0x8A343D0", VA = "0x188A357D0")]
		[AsyncStateMachine(typeof(<MoveToPhase>d__26))]
		private Task<RoomOperationState> CEOHSJLGZAK(RoomOperationState a, HQPJHIWQEWM b, KLHAZPAKHTU c, StackTimer<string>.USVZTROCTRS d, CancellationToken e, bool f = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x8A36830", Offset = "0x8A35430", VA = "0x188A36830")]
		private bool NVMEEMMKCGV(HQPJHIWQEWM a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x8A366A0", Offset = "0x8A352A0", VA = "0x188A366A0")]
		[AsyncStateMachine(typeof(<MasterLockedPhaseChangeBlock>d__28))]
		protected Task<RoomOperationState> MasterLockedPhaseChangeBlock(HQPJHIWQEWM data, UNZKMWWMNXW timedYielder, KLHAZPAKHTU progressTracker, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken, RoomLoadFunction masterLockedCode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x8A35EE0", Offset = "0x8A34AE0", VA = "0x188A35EE0")]
		[AsyncStateMachine(typeof(<MoveThroughRemainingPhases>d__29))]
		private Task FNZOJLQETAR(HQPJHIWQEWM a, KLHAZPAKHTU b, StackTimer<string>.USVZTROCTRS c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x8A372D0", Offset = "0x8A35ED0", VA = "0x188A372D0")]
		private void XQDFJKAOKYI(RoomOperationState a, KLHAZPAKHTU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x8A36030", Offset = "0x8A34C30", VA = "0x188A36030")]
		private void GOOVZXSIYUF(RoomOperationState a, [Out] RoomOperationState b, [Out] RoomOperationState c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x8A37150", Offset = "0x8A35D50", VA = "0x188A37150")]
		private Task<RoomLoadDetails> XFGSMNEPJLK(RoomLoadRequestPayload a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x8A36960", Offset = "0x8A35560", VA = "0x188A36960")]
		private Task<HQPJHIWQEWM> RESMDVNOAJQ(RoomLoadDetails a, RecNet.Core.OnDownloadProgressDelegate b, StackTimer<string>.USVZTROCTRS c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x8A35C40", Offset = "0x8A34840", VA = "0x188A35C40")]
		[AsyncStateMachine(typeof(<DestroyOldObjects>d__34))]
		private Task DestroyOldObjects(HQPJHIWQEWM data, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken, bool useCompletionMark = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x8A35950", Offset = "0x8A34550", VA = "0x188A35950")]
		[AsyncStateMachine(typeof(<CreateCV1Mappings>d__35))]
		private Task DQRRXPTRSQC(HQPJHIWQEWM a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x8A35C10", Offset = "0x8A34810", VA = "0x188A35C10")]
		private Task DeserializeSettings(HQPJHIWQEWM data, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x8A361D0", Offset = "0x8A34DD0", VA = "0x188A361D0")]
		private Task InstantiateObjects(HQPJHIWQEWM data, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x8A36940", Offset = "0x8A35540", VA = "0x188A36940")]
		private Task PreDeserializeObjects(HQPJHIWQEWM data, UNZKMWWMNXW timedYielder, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x8A35BF0", Offset = "0x8A347F0", VA = "0x188A35BF0")]
		private Task DeserializeObjects(HQPJHIWQEWM data, UNZKMWWMNXW timedYielder, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A35BC0", Offset = "0x8A347C0", VA = "0x188A35BC0")]
		private static Task DeserializeConnectables(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x8A36920", Offset = "0x8A35520", VA = "0x188A36920")]
		private Task PostDeserializeObjects(HQPJHIWQEWM data, UNZKMWWMNXW timedYielder, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x8A35BD0", Offset = "0x8A347D0", VA = "0x188A35BD0")]
		private Task DeserializeObjectsComplete(HQPJHIWQEWM data, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x8A37320", Offset = "0x8A35F20", VA = "0x188A37320")]
		private void YVNNQQWGBUV(RoomLoadRequestPayload a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x8A365F0", Offset = "0x8A351F0", VA = "0x188A365F0")]
		public void MDANSWYMNIP(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private static void XJXHTTWFKKS(RoomDetailsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x8A35D90", Offset = "0x8A34990", VA = "0x188A35D90")]
		[AsyncStateMachine(typeof(<RoomV2LoadLogic>d__46))]
		private Task FFIVDLNFIXU(HQPJHIWQEWM a, KLHAZPAKHTU b, StackTimer<string>.USVZTROCTRS c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x8A36E80", Offset = "0x8A35A80", VA = "0x188A36E80")]
		[AsyncStateMachine(typeof(<DestroyR1Objects>d__47))]
		private Task VOHPJDBDIXI(HQPJHIWQEWM a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x8A36D60", Offset = "0x8A35960", VA = "0x188A36D60")]
		private static SerializedDataWrapper VJXUDSVKSMT(HQPJHIWQEWM a)
		{
			return default(SerializedDataWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x8A36FC0", Offset = "0x8A35BC0", VA = "0x188A36FC0")]
		[AsyncStateMachine(typeof(<DeserializeAllObjectsR2>d__49))]
		private Task<RoomOperationState> WBWVDGSJUSL(HQPJHIWQEWM a, UNZKMWWMNXW b, KLHAZPAKHTU c, StackTimer<string>.USVZTROCTRS d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private void EBHPEIASNZO(RoomOperationState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	internal struct CreateCV1MappingsTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private IIDBRQOYHQN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private HQPJHIWQEWM data;

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		private UFFFZRRBPXW SPGVRHHBWNH
		{
			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x8A39C30", Offset = "0x8A38830", VA = "0x188A39C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x8A39EA0", Offset = "0x8A38AA0", VA = "0x188A39EA0")]
		public static Task Run(IIDBRQOYHQN roomManager, HQPJHIWQEWM data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x8A39C80", Offset = "0x8A38880", VA = "0x188A39C80")]
		private void Run()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	internal struct DeserializeConnectablesTask
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x8A39F80", Offset = "0x8A38B80", VA = "0x188A39F80")]
		public static Task Run(CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	internal struct DeserializeObjectsCompleteTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200015D")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005C3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005C4")]
			public VGXLHGZFUHZ operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005C8")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			private StackTimer<string>.USVZTROCTRS <outboundTrafficTimer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x8A47F80", Offset = "0x8A46B80", VA = "0x188A47F80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x8A493F0", Offset = "0x8A47FF0", VA = "0x188A493F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A060", Offset = "0x8A38C60", VA = "0x188A3A060")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(VGXLHGZFUHZ operationContext, HQPJHIWQEWM data, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	internal struct DeserializeObjectsTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005CF")]
			public VGXLHGZFUHZ operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D0")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D1")]
			public UNZKMWWMNXW timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005D2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005D3")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005D4")]
			private IIDBRQOYHQN <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			private UFFFZRRBPXW <callbacks>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			private RoomOperationState <operationState>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			private bool <isMaster>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			private LogRangeScope <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			private IDisposable <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			private List<(PersistenceView, JEXJFGQTHAX)>.Enumerator <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			private PersistenceView <view>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40005DC")]
			private JEXJFGQTHAX <viewData>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40005DD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x8A472B0", Offset = "0x8A45EB0", VA = "0x188A472B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x8A492D0", Offset = "0x8A47ED0", VA = "0x188A492D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A390", Offset = "0x8A38F90", VA = "0x188A3A390")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(VGXLHGZFUHZ operationContext, HQPJHIWQEWM data, UNZKMWWMNXW timedYielder, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A1A0", Offset = "0x8A38DA0", VA = "0x188A3A1A0")]
		private static void FPMYKSJZFST(PersistenceView a, JEXJFGQTHAX b, HQPJHIWQEWM c, RoomOperationState d, bool e)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	internal struct DeserializeSettingsTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000162")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005DF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005E0")]
			public IIDBRQOYHQN roomManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005E1")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005E2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005E3")]
			private LogRangeScope <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005E4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x8A484B0", Offset = "0x8A470B0", VA = "0x188A484B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x8A49330", Offset = "0x8A47F30", VA = "0x188A49330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A4E0", Offset = "0x8A390E0", VA = "0x188A3A4E0")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(IIDBRQOYHQN roomManager, HQPJHIWQEWM data, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	internal struct DestroyOldObjectsTask
	{
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		[CompilerGenerated]
		private sealed class NIBWJFEAYEQ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000165")]
			private struct <<Run>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40005EB")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40005EC")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40005ED")]
				public StackTimer<string>.USVZTROCTRS timer;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40005EE")]
				public CancellationToken token;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40005EF")]
				public NIBWJFEAYEQ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40005F0")]
				private StackTimer<string>.USVZTROCTRS <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40005F1")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000603")]
				[Cpp2IlInjected.Address(RVA = "0x8A50F40", Offset = "0x8A4FB40", VA = "0x188A50F40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000604")]
				[Cpp2IlInjected.Address(RVA = "0x8A512D0", Offset = "0x8A4FED0", VA = "0x188A512D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005EA")]
			public Task EBKSCIZRFJZ;

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public NIBWJFEAYEQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x8A3D0B0", Offset = "0x8A3BCB0", VA = "0x188A3D0B0")]
			[AsyncStateMachine(typeof(<<Run>b__0>d))]
			internal Task KKLJDLEVDTC(StackTimer<string>.USVZTROCTRS a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000166")]
		[CompilerGenerated]
		private sealed class SYNNFXFDNKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005F2")]
			public DEPRECATED_RoomPersistenceVersion version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40005F3")]
			public bool BWXXUPIKBPY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005F4")]
			public List<PersistenceView> JXKGCQJPETC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			public List<GameObject> PBDVUBFEHJQ;

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SYNNFXFDNKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x8A3D890", Offset = "0x8A3C490", VA = "0x188A3D890")]
			internal object XZVULSKEOLY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0x8A3D960", Offset = "0x8A3C560", VA = "0x188A3D960")]
			internal object YABBIZEBXXH()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		[CompilerGenerated]
		private struct <Run>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F8")]
			public DestroyOldObjectsTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005F9")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005FA")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005FB")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005FC")]
			private object <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40005FE")]
			private LogRangeScope <_>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40005FF")]
			private TaskAwaiter<RECTXKHRIXS> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000600")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0x8A49450", Offset = "0x8A48050", VA = "0x188A49450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A050", Offset = "0x8A48C50", VA = "0x188A4A050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000168")]
		[CompilerGenerated]
		private struct <Run>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000601")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000602")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000603")]
			public IIDBRQOYHQN roomManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000604")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000605")]
			public VGXLHGZFUHZ operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000606")]
			public bool useCompletionMark;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000607")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000608")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000609")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x8A4BFC0", Offset = "0x8A4ABC0", VA = "0x188A4BFC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x8A4C1D0", Offset = "0x8A4ADD0", VA = "0x188A4C1D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private IIDBRQOYHQN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private HQPJHIWQEWM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private VGXLHGZFUHZ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private bool useCompletionMark;

		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private static readonly ByteString destroyObjectsGuid;

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		private UFFFZRRBPXW SPGVRHHBWNH
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x8A3A6A0", Offset = "0x8A392A0", VA = "0x188A3A6A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		private IHOYXZOJIJC RRESXEGEGKR
		{
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x8A3A600", Offset = "0x8A39200", VA = "0x188A3A600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A3AEA0", Offset = "0x8A39AA0", VA = "0x188A3AEA0")]
		[AsyncStateMachine(typeof(<Run>d__5))]
		public static Task Run(IIDBRQOYHQN roomManager, HQPJHIWQEWM data, VGXLHGZFUHZ operationContext, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken, bool useCompletionMark)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A3AFF0", Offset = "0x8A39BF0", VA = "0x188A3AFF0")]
		[AsyncStateMachine(typeof(<Run>d__10))]
		private Task Run(StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A3A6F0", Offset = "0x8A392F0", VA = "0x188A3A6F0")]
		private void DestroyActivePersistenceViews([NotNull] PersistedRoomData downloadedRoomData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B120", Offset = "0x8A39D20", VA = "0x188A3B120")]
		private bool XAUFBSZDMPZ(DEPRECATED_RoomPersistenceVersion a, PersistedRoomData b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	internal struct FetchDeserializationDataTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016A")]
		[CompilerGenerated]
		private struct <DownloadAssetBundles>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400061A")]
			public AsyncTaskMethodBuilder<Result<LQASPMMHSEM, DOTNMKZGUXE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400061B")]
			public StackTimer<string>.USVZTROCTRS downloadTimerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			public FetchDeserializationDataTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			public Guid? unityAssetId;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400061E")]
			public IReadOnlyCollection<BakedUnitySubAssetDTO> unitySubAssets;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400061F")]
			public IReadOnlyCollection<BakedUnitySubAssetDTO> referencedUnityAssets;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000620")]
			public long? roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000621")]
			public long? subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x4000622")]
			public RecNet.Core.OnDownloadProgressDelegate downloadProgressCallback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000623")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x4000624")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x4000625")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000626")]
			private TaskAwaiter<Result<LQASPMMHSEM, DOTNMKZGUXE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x8A3FCB0", Offset = "0x8A3E8B0", VA = "0x188A3FCB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x8A40300", Offset = "0x8A3EF00", VA = "0x188A40300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		[CompilerGenerated]
		private struct <Run>d__16 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000627")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000628")]
			public AsyncTaskMethodBuilder<HQPJHIWQEWM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000629")]
			public FetchDeserializationDataTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400062A")]
			public RecNet.Core.OnDownloadProgressDelegate downloadProgressCallback;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400062B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400062C")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400062D")]
			private StackTimer<string>.USVZTROCTRS <downloadTimerScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400062E")]
			private TaskAwaiter<IReadOnlyCollection<BakedUnitySubAssetDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400062F")]
			private TaskAwaiter<(Result<LQASPMMHSEM, DOTNMKZGUXE>, Result<ParseResult<PersistedRoomData>, DOTNMKZGUXE>, Result<ParseResult<SuperRoomData>, DOTNMKZGUXE>, Result<ParseResult<IEnumerable<RoomAssetData>>, DOTNMKZGUXE>, Result<ParseResult<OHPGYSJVQRZ>, DOTNMKZGUXE>)> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A570", Offset = "0x8A49170", VA = "0x188A4A570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B280", Offset = "0x8A49E80", VA = "0x188A4B280", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private VersionedDataGetter<FilenameWithHash, SuperRoomData> superRoomGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private VersionedDataGetter<FilenameWithHash, PersistedRoomData> subRoomGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private VersionedDataGetter<RoomLoadDTO, IEnumerable<RoomAssetData>> roomAssetGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private VersionedDataGetter<long, OHPGYSJVQRZ> playerSaveGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private WQOVIOFSSRC subRoomAssetBundleProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private RoomDetailsDTO roomDetails;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private SubRoomDTO subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private IReadOnlyCollection<BakedUnitySubAssetDTO> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private Task<IReadOnlyCollection<BakedUnitySubAssetDTO>> referencedUnityAssetsTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private FilenameWithHash superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private FilenameWithHash subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private FilenameWithHash? roomAssetData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private RoomLoadDTO roomLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private StackTimer<string>.USVZTROCTRS timer;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B1F0", Offset = "0x8A39DF0", VA = "0x188A3B1F0")]
		public static Task<HQPJHIWQEWM> PVWYUJRGZSJ(IIDBRQOYHQN a, [In] RoomLoadDetails data, RecNet.Core.OnDownloadProgressDelegate b, StackTimer<string>.USVZTROCTRS c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B8C0", Offset = "0x8A3A4C0", VA = "0x188A3B8C0")]
		[AsyncStateMachine(typeof(<Run>d__16))]
		private Task<HQPJHIWQEWM> Run(RecNet.Core.OnDownloadProgressDelegate downloadProgressCallback, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x8A3B690", Offset = "0x8A3A290", VA = "0x188A3B690")]
		[AsyncStateMachine(typeof(<DownloadAssetBundles>d__17))]
		private Task<Result<LQASPMMHSEM, DOTNMKZGUXE>> PYXUJNENPWC(Guid? a, IReadOnlyCollection<BakedUnitySubAssetDTO> b, IReadOnlyCollection<BakedUnitySubAssetDTO> c, long? d, long? e, RecNet.Core.OnDownloadProgressDelegate f, StackTimer<string>.USVZTROCTRS g, CancellationToken h)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	internal struct FetchRoomLoadDetailsTask
	{
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		[CompilerGenerated]
		private sealed class SBNSPJVPEDH
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200016E")]
			private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000649")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400064A")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400064B")]
				public SBNSPJVPEDH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400064C")]
				private StackTimer<string>.USVZTROCTRS <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400064D")]
				private TaskAwaiter<SubRoomDataSaveWithUnityAssetsDTO> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400064E")]
				private TaskAwaiter<RemoteRunDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600061C")]
				[Cpp2IlInjected.Address(RVA = "0x8A4E230", Offset = "0x8A4CE30", VA = "0x188A4E230", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600061D")]
				[Cpp2IlInjected.Address(RVA = "0x8A4EEA0", Offset = "0x8A4DAA0", VA = "0x188A4EEA0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			public long BEZPQOVRDSJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			public string TJKINEKEVZE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			public WJWHSKXJPKM DUTNGWBYCIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			public long UNIESGMLRWM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063E")]
			public StackTimer<string>.USVZTROCTRS BUREXCMRKUO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400063F")]
			public UFFFZRRBPXW TIDVWLUQWFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			public long JPAUAGQURNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			public CancellationToken HROQVQQIJZL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			public Guid? HVCSCURZYQZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000643")]
			public IReadOnlyList<BakedUnitySubAssetDTO> KSXMPQKKPQX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000644")]
			public IReadOnlyList<BakedUnitySubAssetDTO> FNQTZKKPSNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			public FilenameWithHash IBNYLBDWTHS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000646")]
			public FilenameWithHash BBLIFPITMHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000647")]
			public Guid FARDGXGYELO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000648")]
			public RoomDetailsDTO OKNKMVGXQDA;

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SBNSPJVPEDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x104E080", Offset = "0x104CC80", VA = "0x18104E080")]
			internal bool IISIQOFNNFA(SubRoomDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x8A3D5C0", Offset = "0x8A3C1C0", VA = "0x188A3D5C0")]
			[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
			internal Task BITPUCBHQUH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x8A3D690", Offset = "0x8A3C290", VA = "0x188A3D690")]
			internal Task<RoomLoadDTO> QHFDNAPGVOD()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016F")]
		[CompilerGenerated]
		private struct <FetchRoomLoadDetails>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400064F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			public AsyncTaskMethodBuilder<RoomLoadDetails> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			public FetchRoomLoadDetailsTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000652")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000653")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			private TaskAwaiter<RoomLoadDetails> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x8A40370", Offset = "0x8A3EF70", VA = "0x188A40370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x8A407F0", Offset = "0x8A3F3F0", VA = "0x188A407F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		[CompilerGenerated]
		private struct <FetchRoomLoadDetails>d__13 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000656")]
			public AsyncTaskMethodBuilder<RoomLoadDetails> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000657")]
			public long subroomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000658")]
			public string studioSessionId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000659")]
			public WJWHSKXJPKM roomLoadDataProviderOverride;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400065A")]
			public long subRoomDataSaveId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400065B")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400065C")]
			public UFFFZRRBPXW callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400065D")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400065E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400065F")]
			public Guid roomAssetsSnapshotId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000660")]
			public FilenameWithHash superRoomBlobName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000661")]
			private SBNSPJVPEDH <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000662")]
			private SubRoomDTO <subroom>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000663")]
			private Task<RoomLoadDTO> <getRoomLoadDTOTask>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000664")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000665")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000666")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000667")]
			private TaskAwaiter<RoomLoadDTO> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x8A40860", Offset = "0x8A3F460", VA = "0x188A40860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0x8A417F0", Offset = "0x8A403F0", VA = "0x188A417F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000171")]
		[CompilerGenerated]
		private struct <Run>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000668")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000669")]
			public AsyncTaskMethodBuilder<RoomLoadDetails> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400066A")]
			public FetchRoomLoadDetailsTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400066B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400066C")]
			private StackTimer<string>.USVZTROCTRS <subTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400066D")]
			private TaskAwaiter<RoomLoadDetails> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A0B0", Offset = "0x8A48CB0", VA = "0x188A4A0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x8A4A500", Offset = "0x8A49100", VA = "0x188A4A500", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private UFFFZRRBPXW callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private JKPIQQXIFJL debugRoomLoadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private WJWHSKXJPKM roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private StackTimer<string>.USVZTROCTRS timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private FilenameWithHash superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BAA0", Offset = "0x8A3A6A0", VA = "0x188A3BAA0")]
		public static Task<RoomLoadDetails> PVWYUJRGZSJ(IIDBRQOYHQN a, RoomLoadRequestPayload b, StackTimer<string>.USVZTROCTRS c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BCF0", Offset = "0x8A3A8F0", VA = "0x188A3BCF0")]
		[AsyncStateMachine(typeof(<Run>d__11))]
		private Task<RoomLoadDetails> Run(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C000", Offset = "0x8A3AC00", VA = "0x188A3C000")]
		[AsyncStateMachine(typeof(<FetchRoomLoadDetails>d__12))]
		private Task<RoomLoadDetails> XFGSMNEPJLK(StackTimer<string>.USVZTROCTRS a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BE40", Offset = "0x8A3AA40", VA = "0x188A3BE40")]
		[AsyncStateMachine(typeof(<FetchRoomLoadDetails>d__13))]
		private static Task<RoomLoadDetails> XFGSMNEPJLK(UFFFZRRBPXW a, WJWHSKXJPKM b, long c, long d, long e, string f, FilenameWithHash g, Guid h, CancellationToken i, StackTimer<string>.USVZTROCTRS j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x8A3BA70", Offset = "0x8A3A670", VA = "0x188A3BA70")]
		private void FKTVKVAXWLY(RoomDetailsDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	internal struct FlushCommandsSlowlyTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000174")]
		[CompilerGenerated]
		private struct <Run>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000676")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000677")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000678")]
			public FlushCommandsSlowlyTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400067A")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400067B")]
			private float <nextResendTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400067C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600062E")]
			[Cpp2IlInjected.Address(RVA = "0x8A4C290", Offset = "0x8A4AE90", VA = "0x188A4C290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x8A4C820", Offset = "0x8A4B420", VA = "0x188A4C820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private UFFFZRRBPXW callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private HQPJHIWQEWM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private StackTimer<string>.USVZTROCTRS timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private float resendInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private float maxWaitEndTime;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C610", Offset = "0x8A3B210", VA = "0x188A3C610")]
		public static Task VYQYIJPEHLB(IIDBRQOYHQN a, HQPJHIWQEWM b, StackTimer<string>.USVZTROCTRS c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C4F0", Offset = "0x8A3B0F0", VA = "0x188A3C4F0")]
		[AsyncStateMachine(typeof(<Run>d__8))]
		public Task Run(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C250", Offset = "0x8A3AE50", VA = "0x188A3C250")]
		private static void HXHEWZSGLGV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C390", Offset = "0x8A3AF90", VA = "0x188A3C390")]
		private void MSUAQTPSUEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C190", Offset = "0x8A3AD90", VA = "0x188A3C190")]
		private static float EANVWXPOMZZ(UFFFZRRBPXW a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C170", Offset = "0x8A3AD70", VA = "0x188A3C170")]
		private static float BYIEKOPCYEQ()
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	internal struct InstantiateObjectsTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000176")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400067D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			public VGXLHGZFUHZ operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000680")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000682")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000683")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000684")]
			private KOQJHZNNMVK <operation>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000685")]
			private IIDBRQOYHQN <roomManager>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000686")]
			private PreInstantiateObjectsTask.Results <instantiations>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000687")]
			private TaskAwaiter<RECTXKHRIXS> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000688")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x8A48AD0", Offset = "0x8A476D0", VA = "0x188A48AD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x8A49390", Offset = "0x8A47F90", VA = "0x188A49390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000177")]
		[CompilerGenerated]
		private struct <WaitForInstantiatedObjectsToInitialize>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000689")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400068A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400068B")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400068C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x8A516E0", Offset = "0x8A502E0", VA = "0x188A516E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x8A51A10", Offset = "0x8A50610", VA = "0x188A51A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C910", Offset = "0x8A3B510", VA = "0x188A3C910")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(VGXLHGZFUHZ operationContext, HQPJHIWQEWM data, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x8A3CA50", Offset = "0x8A3B650", VA = "0x188A3CA50")]
		private static Task<RECTXKHRIXS> UVIHRXQLHYB(VGXLHGZFUHZ a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x8A3CAC0", Offset = "0x8A3B6C0", VA = "0x188A3CAC0")]
		[AsyncStateMachine(typeof(<WaitForInstantiatedObjectsToInitialize>d__2))]
		private static Task WaitForInstantiatedObjectsToInitialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	internal struct LoadEmptySceneTask
	{
		[Cpp2IlInjected.Token(Token = "0x2000179")]
		[CompilerGenerated]
		private sealed class XVCGTKCCKDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000691")]
			public string ATQDCETSLYK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000692")]
			public bool QUHRLQAEVMB;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XVCGTKCCKDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x8A51B90", Offset = "0x8A50790", VA = "0x188A51B90")]
			internal object DVRBBAOWSZM()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200017A")]
		[CompilerGenerated]
		private struct <Run>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000693")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000694")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000695")]
			public LoadEmptySceneTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000696")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000697")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000698")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B830", Offset = "0x8A4A430", VA = "0x188A4B830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x8A4C230", Offset = "0x8A4AE30", VA = "0x188A4C230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200017B")]
		[CompilerGenerated]
		private struct <SafeLoadSceneAsync>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000699")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400069A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400069B")]
			public string sceneName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400069C")]
			public bool stopOnEmptyScene;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400069D")]
			public LoadEmptySceneTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400069E")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400069F")]
			private TaskAwaiter<Scene> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x8A4CD70", Offset = "0x8A4B970", VA = "0x188A4CD70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D1E0", Offset = "0x8A4BDE0", VA = "0x188A4D1E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private bool isOffline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private StackTimer<string>.USVZTROCTRS timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		private IIDBRQOYHQN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x8A3CB80", Offset = "0x8A3B780", VA = "0x188A3CB80")]
		public static Task LoadEmptyScene(IIDBRQOYHQN roomManager, bool isOffline, StackTimer<string>.USVZTROCTRS timer, CancellationToken roomCancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x8A3CD20", Offset = "0x8A3B920", VA = "0x188A3CD20")]
		[AsyncStateMachine(typeof(<Run>d__5))]
		private Task Run()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x8A3CBF0", Offset = "0x8A3B7F0", VA = "0x188A3CBF0")]
		[AsyncStateMachine(typeof(<SafeLoadSceneAsync>d__6))]
		private Task NMYKFMGVKXI(bool a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370")]
		private bool POPWTNTOPXM(bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	internal struct LoadSceneTask
	{
		[Cpp2IlInjected.Token(Token = "0x200017D")]
		[CompilerGenerated]
		private sealed class TBVOZRUCJVY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006A3")]
			public string ATQDCETSLYK;

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public TBVOZRUCJVY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x8A3DA10", Offset = "0x8A3C610", VA = "0x188A3DA10")]
			internal object DVRBBAOWSZM()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200017E")]
		[CompilerGenerated]
		private struct <Run>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006A4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006A5")]
			public AsyncTaskMethodBuilder<Scene> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006A6")]
			public LoadSceneTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006A7")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006A8")]
			private TaskAwaiter<Scene> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B2F0", Offset = "0x8A49EF0", VA = "0x188A4B2F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x8A4B7C0", Offset = "0x8A4A3C0", VA = "0x188A4B7C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200017F")]
		[CompilerGenerated]
		private struct <SafeLoadSceneAsync>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006A9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006AA")]
			public AsyncTaskMethodBuilder<Scene> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006AB")]
			public string sceneName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006AC")]
			public LoadSceneTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006AD")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006AE")]
			private TaskAwaiter<Scene> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x8A4C880", Offset = "0x8A4B480", VA = "0x188A4C880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x8A4CD00", Offset = "0x8A4B900", VA = "0x188A4CD00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private RoomSceneLocations roomLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private StackTimer<string>.USVZTROCTRS timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		private IIDBRQOYHQN roomManager;

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D060", Offset = "0x8A3BC60", VA = "0x188A3D060")]
		public static Task<Scene> SVNZOTFMYWD(IIDBRQOYHQN a, RoomSceneLocations b, StackTimer<string>.USVZTROCTRS c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x8A3CF50", Offset = "0x8A3BB50", VA = "0x188A3CF50")]
		[AsyncStateMachine(typeof(<Run>d__4))]
		private Task<Scene> Run()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x8A3CE10", Offset = "0x8A3BA10", VA = "0x188A3CE10")]
		[AsyncStateMachine(typeof(<SafeLoadSceneAsync>d__5))]
		private Task<Scene> NMYKFMGVKXI(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	internal struct MoveToPhaseTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000181")]
		[CompilerGenerated]
		private struct <MoveTo>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006B2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006B3")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006B4")]
			public MoveToPhaseTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006B5")]
			public RoomOperationState nextPhase;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006B6")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006B7")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006B8")]
			public bool skipHandlers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40006B9")]
			public HQPJHIWQEWM deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40006BA")]
			private StackTimer<string>.USVZTROCTRS <moveToPhaseTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40006BB")]
			private Guid <handlersGuid>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40006BC")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40006BD")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x8A5B050", Offset = "0x8A59C50", VA = "0x188A5B050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0x8A5BB20", Offset = "0x8A5A720", VA = "0x188A5BB20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000182")]
		[CompilerGenerated]
		private struct <SendStateChangeMessage>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006BE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006BF")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C0")]
			public MoveToPhaseTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006C1")]
			public RoomOperationState state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006C2")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006C3")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			private TaskAwaiter<RECTXKHRIXS> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0x8A60C40", Offset = "0x8A5F840", VA = "0x188A60C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x8A60F20", Offset = "0x8A5FB20", VA = "0x188A60F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private readonly VGXLHGZFUHZ operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private readonly JKPIQQXIFJL debugRoomLoadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private readonly HWJKLFSNWJL handlers;

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		private KOQJHZNNMVK PMFJYKFTXRW
		{
			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x3DAE270", Offset = "0x3DACE70", VA = "0x183DAE270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x8A56550", Offset = "0x8A55150", VA = "0x188A56550")]
		public MoveToPhaseTask(VGXLHGZFUHZ operationContext, JKPIQQXIFJL debugRoomLoadInfo, HWJKLFSNWJL handlers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x8A56270", Offset = "0x8A54E70", VA = "0x188A56270")]
		[AsyncStateMachine(typeof(<MoveTo>d__6))]
		public Task<RoomOperationState> MoveTo(RoomOperationState nextPhase, HQPJHIWQEWM deserializationData, StackTimer<string>.USVZTROCTRS stackTimer, CancellationToken cancellationToken, bool skipHandlers)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x8A563F0", Offset = "0x8A54FF0", VA = "0x188A563F0")]
		[AsyncStateMachine(typeof(<SendStateChangeMessage>d__7))]
		private Task<RoomOperationState> TCGLXFTXFXD(StackTimer<string>.USVZTROCTRS a, RoomOperationState b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x8A56220", Offset = "0x8A54E20", VA = "0x188A56220")]
		private bool KDOYGNZWPCI(RoomOperationState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x8A56250", Offset = "0x8A54E50", VA = "0x188A56250")]
		private void Log(string msg)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	internal struct PostDeserializeObjectsTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000184")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			public KOQJHZNNMVK operation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			public UNZKMWWMNXW timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			private bool <isMaster>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			private LogRangeScope <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40006CD")]
			private List<(PersistenceView, JEXJFGQTHAX)>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40006CE")]
			private (PersistenceView, JEXJFGQTHAX) <pair>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40006CF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x8A5E340", Offset = "0x8A5CF40", VA = "0x188A5E340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0x8A5F350", Offset = "0x8A5DF50", VA = "0x188A5F350", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x8A570B0", Offset = "0x8A55CB0", VA = "0x188A570B0")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(KOQJHZNNMVK operation, HQPJHIWQEWM data, UNZKMWWMNXW timedYielder, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	internal struct PreDeserializeObjectsTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000186")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006D0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006D1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006D2")]
			public KOQJHZNNMVK operation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006D3")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006D4")]
			public UNZKMWWMNXW timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006D5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006D6")]
			private bool <isMaster>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40006D7")]
			private DEPRECATED_RoomPersistenceVersion <DEPRECATED_version>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006D8")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40006D9")]
			private IDisposable <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40006DA")]
			private List<(PersistenceView, JEXJFGQTHAX)>.Enumerator <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40006DB")]
			private PersistenceView <view>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40006DC")]
			private JEXJFGQTHAX <viewData>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40006DD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0x8A5EA10", Offset = "0x8A5D610", VA = "0x188A5EA10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x8A5F2F0", Offset = "0x8A5DEF0", VA = "0x188A5F2F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x8A571F0", Offset = "0x8A55DF0", VA = "0x188A571F0")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(KOQJHZNNMVK operation, HQPJHIWQEWM data, UNZKMWWMNXW timedYielder, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	public struct PrefetchAssetBundlesTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[CompilerGenerated]
		private struct <Run>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006E6")]
			public AsyncTaskMethodBuilder<Result<LQASPMMHSEM, DOTNMKZGUXE>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006E7")]
			public PrefetchAssetBundlesTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40006E8")]
			public RecNet.Core.OnDownloadProgressDelegate preloadProgressCallback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40006E9")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40006EA")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			private TaskAwaiter<Result<LQASPMMHSEM, DOTNMKZGUXE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0x8A60560", Offset = "0x8A5F160", VA = "0x188A60560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x8A60BD0", Offset = "0x8A5F7D0", VA = "0x188A60BD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		private long _roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private long _subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		private Guid? _unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private IReadOnlyCollection<BakedUnitySubAssetDTO> _unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private IReadOnlyCollection<BakedUnitySubAssetDTO> _referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private WQOVIOFSSRC _subRoomAssetBundleProvider;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x8A57DA0", Offset = "0x8A569A0", VA = "0x188A57DA0")]
		public static Task<Result<LQASPMMHSEM, DOTNMKZGUXE>> PVWYUJRGZSJ(long a, long b, SubRoomDataSaveWithUnityAssetsDTO c, RecNet.Core.OnDownloadProgressDelegate d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x8A57F00", Offset = "0x8A56B00", VA = "0x188A57F00")]
		[AsyncStateMachine(typeof(<Run>d__8))]
		private Task<Result<LQASPMMHSEM, DOTNMKZGUXE>> Run(RecNet.Core.OnDownloadProgressDelegate preloadProgressCallback, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	internal struct PreInstantiateObjectsTask
	{
		[Cpp2IlInjected.Token(Token = "0x200018A")]
		public struct Results
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			public List<VTAQKVPUYNS> instantiationRequests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006EF")]
			public List<JEXJFGQTHAX> requestDatas;

			[Cpp2IlInjected.Token(Token = "0x6000664")]
			[Cpp2IlInjected.Address(RVA = "0xDE2580", Offset = "0xDE1180", VA = "0x180DE2580")]
			public Results(List<VTAQKVPUYNS> instantiationRequests, List<JEXJFGQTHAX> requestDatas)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018B")]
		[CompilerGenerated]
		private sealed class XYQPMXZJXMZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F0")]
			public IEnumerable<VTAQKVPUYNS> DFHFKJXGLBU;

			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XYQPMXZJXMZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000666")]
			[Cpp2IlInjected.Address(RVA = "0x8A66930", Offset = "0x8A65530", VA = "0x188A66930")]
			internal object TDBRPIDPUEI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private IIDBRQOYHQN roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		private HQPJHIWQEWM data;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private UFFFZRRBPXW SPGVRHHBWNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x8A57330", Offset = "0x8A55F30", VA = "0x188A57330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x8A575E0", Offset = "0x8A561E0", VA = "0x188A575E0")]
		public static Results Run(IIDBRQOYHQN roomManager, HQPJHIWQEWM data)
		{
			return default(Results);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x8A57380", Offset = "0x8A55F80", VA = "0x188A57380")]
		private Results Run()
		{
			return default(Results);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x8A57640", Offset = "0x8A56240", VA = "0x188A57640")]
		private Results SGGTBKYSFZM(PersistedRoomData a, DEPRECATED_RoomPersistenceVersion b)
		{
			return default(Results);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x8A57BE0", Offset = "0x8A567E0", VA = "0x188A57BE0")]
		private bool XWJFBULQACU(IEnumerable<VTAQKVPUYNS> a)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	internal struct RegisterInstantiatedObjectsTask
	{
		[Cpp2IlInjected.Token(Token = "0x200018D")]
		[CompilerGenerated]
		private sealed class HWLFBXLBEBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F1")]
			public PreInstantiateObjectsTask.Results ZRLRAICNSQV;

			[Cpp2IlInjected.Token(Token = "0x6000668")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HWLFBXLBEBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0x8A54FA0", Offset = "0x8A53BA0", VA = "0x188A54FA0")]
			internal object KKLJDLEVDTC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018E")]
		[CompilerGenerated]
		private sealed class HWFYEQRDUQC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F2")]
			public PersistenceView ECVAKOUDBZY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006F3")]
			public Guid FRFKBITTCEL;

			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HWFYEQRDUQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x8A54000", Offset = "0x8A52C00", VA = "0x188A54000")]
			internal object KKQQARYSNEL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x8A580F0", Offset = "0x8A56CF0", VA = "0x188A580F0")]
		public static void Run(KOQJHZNNMVK operation, HQPJHIWQEWM data, PreInstantiateObjectsTask.Results instantiations)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	internal class HWJKLFSNWJL
	{
		[Cpp2IlInjected.Token(Token = "0x2000191")]
		[CompilerGenerated]
		private sealed class SYNNFXFDNKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F9")]
			public Guid VLQGDXNVXOC;

			[Cpp2IlInjected.Token(Token = "0x600067E")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SYNNFXFDNKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0x8A59940", Offset = "0x8A58540", VA = "0x188A59940")]
			internal object ZIOHSBNBBFH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000192")]
		[CompilerGenerated]
		private sealed class WNRSWAJADRM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006FA")]
			public Guid VLQGDXNVXOC;

			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public WNRSWAJADRM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x8A66560", Offset = "0x8A65160", VA = "0x188A66560")]
			internal object TGPYDGWSLXT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[CompilerGenerated]
		private sealed class SBNSPJVPEDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			public Guid VLQGDXNVXOC;

			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SBNSPJVPEDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x8A59850", Offset = "0x8A58450", VA = "0x188A59850")]
			internal object HAOHZZKRIOQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000194")]
		[CompilerGenerated]
		private sealed class XVCGTKCCKDJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000195")]
			private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000700")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000701")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000702")]
				public XVCGTKCCKDJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000703")]
				public CancellationToken mlbToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000704")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000686")]
				[Cpp2IlInjected.Address(RVA = "0x8A61F60", Offset = "0x8A60B60", VA = "0x188A61F60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000687")]
				[Cpp2IlInjected.Address(RVA = "0x8A62220", Offset = "0x8A60E20", VA = "0x188A62220", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			public HWJKLFSNWJL BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			public HQPJHIWQEWM HIVBQTYRTXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006FE")]
			public StackTimer<string>.USVZTROCTRS CKWWSMQJPUS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			public Func<CancellationToken, Task> HUVVFXMGSVM;

			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XVCGTKCCKDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x8A667E0", Offset = "0x8A653E0", VA = "0x188A667E0")]
			[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
			internal Task URVKWKVRICN(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000196")]
		[CompilerGenerated]
		private sealed class KZRZTSLLDPA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000197")]
			private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400070A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400070B")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400070C")]
				public DeserializationPhaseHandler handler;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400070D")]
				public KZRZTSLLDPA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400070E")]
				private LogRangeScope <_>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400070F")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600068C")]
				[Cpp2IlInjected.Address(RVA = "0x8A61A90", Offset = "0x8A60690", VA = "0x188A61A90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600068D")]
				[Cpp2IlInjected.Address(RVA = "0x8A61F00", Offset = "0x8A60B00", VA = "0x188A61F00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000705")]
			public RunFor JKJPQDQJHPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000706")]
			public Guid TYQLHKDFHOU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000707")]
			public List<DeserializationPhaseHandler> BQCAVWWFDYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000708")]
			public HQPJHIWQEWM HIVBQTYRTXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000709")]
			public CancellationToken JYQZVSPGEXW;

			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public KZRZTSLLDPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0x8A55E20", Offset = "0x8A54A20", VA = "0x188A55E20")]
			internal object ZRNEZZKNUXD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0x8A55C40", Offset = "0x8A54840", VA = "0x188A55C40")]
			[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
			internal Task ZRCRFLWTCAL(DeserializationPhaseHandler a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0x8A55D40", Offset = "0x8A54940", VA = "0x188A55D40")]
			internal object ZRHYCSQQLLU()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[CompilerGenerated]
		private struct <InvokeMethodsInParallel>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000710")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000711")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000712")]
			public RunFor runFor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000713")]
			public Guid handlerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000714")]
			public List<DeserializationPhaseHandler> methods;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000715")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000716")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000717")]
			private KZRZTSLLDPA <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000718")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0x8A599B0", Offset = "0x8A585B0", VA = "0x188A599B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068F")]
			[Cpp2IlInjected.Address(RVA = "0x8A59E50", Offset = "0x8A58A50", VA = "0x188A59E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		[CompilerGenerated]
		private struct <MasterInvokeHandlerMethods>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000719")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400071A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400071B")]
			public Guid handlerIdToRun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400071C")]
			public HWJKLFSNWJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400071D")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400071E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400071F")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000720")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x8A59EB0", Offset = "0x8A58AB0", VA = "0x188A59EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x8A5A360", Offset = "0x8A58F60", VA = "0x188A5A360", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019A")]
		[CompilerGenerated]
		private struct <MasterLockedHandler>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000721")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000722")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000723")]
			public HWJKLFSNWJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000724")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000725")]
			public StackTimer<string>.USVZTROCTRS timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000726")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000727")]
			private Guid <handlerIdToRun>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000728")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x8A5A3C0", Offset = "0x8A58FC0", VA = "0x188A5A3C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x8A5A970", Offset = "0x8A59570", VA = "0x188A5A970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019B")]
		[CompilerGenerated]
		private struct <MasterSyncSendCompletionMark>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000729")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400072A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400072B")]
			public Guid handlerIdToRun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400072C")]
			public HWJKLFSNWJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400072D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400072E")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400072F")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000730")]
			private ByteString <completionMark>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000731")]
			private TaskAwaiter<RECTXKHRIXS> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x8A5A9D0", Offset = "0x8A595D0", VA = "0x188A5A9D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000695")]
			[Cpp2IlInjected.Address(RVA = "0x8A5AFF0", Offset = "0x8A59BF0", VA = "0x188A5AFF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019C")]
		[CompilerGenerated]
		private struct <Run>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000732")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000733")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000734")]
			public HWJKLFSNWJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000735")]
			public RoomOperationState operationState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000736")]
			public HQPJHIWQEWM deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000737")]
			public StackTimer<string>.USVZTROCTRS timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000738")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000739")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0x8A5FAB0", Offset = "0x8A5E6B0", VA = "0x188A5FAB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000697")]
			[Cpp2IlInjected.Address(RVA = "0x8A60210", Offset = "0x8A5EE10", VA = "0x188A60210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		[CompilerGenerated]
		private struct <RunAllHandlers>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400073A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400073B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400073C")]
			public HWJKLFSNWJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400073D")]
			public StackTimer<string>.USVZTROCTRS timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400073E")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400073F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000740")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000741")]
			private Dictionary<Guid, List<DeserializationPhaseHandler>>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000742")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000698")]
			[Cpp2IlInjected.Address(RVA = "0x8A5CB50", Offset = "0x8A5B750", VA = "0x188A5CB50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0x8A5D160", Offset = "0x8A5BD60", VA = "0x188A5D160", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019E")]
		[CompilerGenerated]
		private struct <RunAuthorityHandler>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000743")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000744")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000745")]
			public HWJKLFSNWJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000746")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000747")]
			public StackTimer<string>.USVZTROCTRS timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000748")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000749")]
			private XVCGTKCCKDJ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400074A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0x8A5D1C0", Offset = "0x8A5BDC0", VA = "0x188A5D1C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x8A5D6D0", Offset = "0x8A5C2D0", VA = "0x188A5D6D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019F")]
		[CompilerGenerated]
		private struct <RunNonAuthorityHandlers>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400074B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400074C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400074D")]
			public HWJKLFSNWJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400074E")]
			public StackTimer<string>.USVZTROCTRS timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400074F")]
			public HQPJHIWQEWM data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000750")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000751")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000752")]
			private Dictionary<Guid, List<DeserializationPhaseHandler>>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000753")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600069C")]
			[Cpp2IlInjected.Address(RVA = "0x8A5DC40", Offset = "0x8A5C840", VA = "0x188A5DC40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0x8A5E2E0", Offset = "0x8A5CEE0", VA = "0x188A5E2E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private readonly VGXLHGZFUHZ HJKNDWUBXQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		private DeserializationHandlerLists UGQVCETFGIW;

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		private KOQJHZNNMVK PMFJYKFTXRW
		{
			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x1033180", Offset = "0x1031D80", VA = "0x181033180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public HWJKLFSNWJL(VGXLHGZFUHZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x8A54D10", Offset = "0x8A53910", VA = "0x188A54D10")]
		[AsyncStateMachine(typeof(<Run>d__5))]
		public Task Run(RoomOperationState operationState, HQPJHIWQEWM deserializationData, StackTimer<string>.USVZTROCTRS timer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x8A54E60", Offset = "0x8A53A60", VA = "0x188A54E60")]
		[AsyncStateMachine(typeof(<RunAuthorityHandler>d__6))]
		private Task THUMTNWNEWP(HQPJHIWQEWM a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x8A541A0", Offset = "0x8A52DA0", VA = "0x188A541A0")]
		[AsyncStateMachine(typeof(<RunAllHandlers>d__7))]
		private Task AJZZEPYJTLQ(HQPJHIWQEWM a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x8A54BD0", Offset = "0x8A537D0", VA = "0x188A54BD0")]
		[AsyncStateMachine(typeof(<RunNonAuthorityHandlers>d__8))]
		private Task RMALPPMSDCV(HQPJHIWQEWM a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x8A54910", Offset = "0x8A53510", VA = "0x188A54910")]
		[AsyncStateMachine(typeof(<InvokeMethodsInParallel>d__9))]
		private Task LADRROHOGSP(Guid a, List<DeserializationPhaseHandler> b, RunFor c, HQPJHIWQEWM d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x8A54610", Offset = "0x8A53210", VA = "0x188A54610")]
		[AsyncStateMachine(typeof(<MasterLockedHandler>d__10))]
		private Task KFKERKBNAEN(HQPJHIWQEWM a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x8A54420", Offset = "0x8A53020", VA = "0x188A54420")]
		[AsyncStateMachine(typeof(<MasterInvokeHandlerMethods>d__11))]
		private Task FMMKLROFXGD(Guid a, HQPJHIWQEWM b, StackTimer<string>.USVZTROCTRS c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x8A542E0", Offset = "0x8A52EE0", VA = "0x188A542E0")]
		[AsyncStateMachine(typeof(<MasterSyncSendCompletionMark>d__12))]
		private Task BHBAFTOWZHV(Guid a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x8A54090", Offset = "0x8A52C90", VA = "0x188A54090")]
		private void ABLTTANECSM(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x8A54560", Offset = "0x8A53160", VA = "0x188A54560")]
		private void IQZBNBKUSSR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x8A54A60", Offset = "0x8A53660", VA = "0x188A54A60")]
		public Guid QNYTUCEMTAA(RoomOperationState a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8A54750", Offset = "0x8A53350", VA = "0x188A54750")]
		[CompilerGenerated]
		private object KNESPLUMCWT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	internal struct RunEmptySceneTasksTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001A1")]
		[CompilerGenerated]
		private struct <Run>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000757")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000758")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000759")]
			public RunEmptySceneTasksTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400075A")]
			private StackTimer<string>.USVZTROCTRS <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400075B")]
			private IEnumerator<EmptySceneHandler> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400075C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006A0")]
			[Cpp2IlInjected.Address(RVA = "0x8A5F3B0", Offset = "0x8A5DFB0", VA = "0x188A5F3B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A1")]
			[Cpp2IlInjected.Address(RVA = "0x8A5FA50", Offset = "0x8A5E650", VA = "0x188A5FA50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		private UFFFZRRBPXW callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private StackTimer<string>.USVZTROCTRS timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		private CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x8A597E0", Offset = "0x8A583E0", VA = "0x188A597E0")]
		public static Task ZJUCNEYCTAW(UFFFZRRBPXW a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x8A596F0", Offset = "0x8A582F0", VA = "0x188A596F0")]
		[AsyncStateMachine(typeof(<Run>d__4))]
		private Task Run()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	public readonly struct RoomSaveAnalyticsInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		public readonly bool LastLoadedSaveWasPublished;

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x23BF0B0", Offset = "0x23BDCB0", VA = "0x1823BF0B0")]
		public RoomSaveAnalyticsInfo(bool lastLoadedSaveWasPublished)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	public readonly struct RoomSerializedData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public readonly PersistedRoomData? RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		public readonly PersistedRoomDataReferences RoomDataReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000760")]
		public readonly Guid? UnityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		public readonly IReadOnlyList<Guid> RoomAssets;

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public IReadOnlyCollection<string> OYESZNTXTOC
		{
			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0x8A589C0", Offset = "0x8A575C0", VA = "0x188A589C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public IReadOnlyDictionary<long, int> POCZAMIYWRF
		{
			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0x8A589E0", Offset = "0x8A575E0", VA = "0x188A589E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x8A58A00", Offset = "0x8A57600", VA = "0x188A58A00")]
		public RoomSerializedData(PersistedRoomData? roomData, PersistedRoomDataReferences roomDataReferences, Guid? unityAssetId, [Optional] IReadOnlyList<Guid>? roomAssets)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	internal class DKLZWTJQBSR : MOCIFKPOHOS
	{
		[Cpp2IlInjected.Token(Token = "0x20001A6")]
		[CompilerGenerated]
		private sealed class XYQPMXZJXMZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000769")]
			public float DDKCRVCMDLM;

			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XYQPMXZJXMZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B4")]
			[Cpp2IlInjected.Address(RVA = "0x8A668D0", Offset = "0x8A654D0", VA = "0x188A668D0")]
			internal object OUBGGZUASFS()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001A7")]
		[CompilerGenerated]
		private struct <PreserializeViews>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400076A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400076B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400076C")]
			public DKLZWTJQBSR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400076D")]
			public PersistenceView[] activePersistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400076E")]
			public StringBuilder outputBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400076F")]
			public SerializeType serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000770")]
			private XYQPMXZJXMZ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000771")]
			private LogRangeScope <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000772")]
			private CancellationTokenSource <cts>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000773")]
			private JLBGYMDGKTI<Task> <tasks>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000774")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006B5")]
			[Cpp2IlInjected.Address(RVA = "0x8A5BB90", Offset = "0x8A5A790", VA = "0x188A5BB90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B6")]
			[Cpp2IlInjected.Address(RVA = "0x8A5C5D0", Offset = "0x8A5B1D0", VA = "0x188A5C5D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001A8")]
		[CompilerGenerated]
		private struct <Serialize>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000775")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000776")]
			public AsyncTaskMethodBuilder<RoomSerializedData> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000777")]
			public DKLZWTJQBSR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000778")]
			public long subroomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000779")]
			public SerializeType serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400077A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400077B")]
			public RoomSaveOptions roomSaveOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400077C")]
			private PersistenceView[] <activePersistenceViews>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400077D")]
			private StringBuilder <outputBuilder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400077E")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400077F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006B7")]
			[Cpp2IlInjected.Address(RVA = "0x8A60F90", Offset = "0x8A5FB90", VA = "0x188A60F90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B8")]
			[Cpp2IlInjected.Address(RVA = "0x8A61610", Offset = "0x8A60210", VA = "0x188A61610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x4000763")]
		private static readonly TimeSpan TIMBICINYIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		private readonly PBYQZFKCAYJ ILBCVLWWBUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		private readonly BCLSMCOVFKT NJEEEUMLLGI;

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x8A53080", Offset = "0x8A51C80", VA = "0x188A53080")]
		public DKLZWTJQBSR(VGXLHGZFUHZ a, PBYQZFKCAYJ b, BCLSMCOVFKT c, Log d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x8A52EC0", Offset = "0x8A51AC0", VA = "0x188A52EC0")]
		[AsyncStateMachine(typeof(<Serialize>d__6))]
		public Task<RoomSerializedData> Serialize(long subroomId, RoomSaveOptions roomSaveOptions, SerializeType serializeType, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x8A51E10", Offset = "0x8A50A10", VA = "0x188A51E10")]
		private static bool AXHEIAYXMBF(PersistenceView a, [Out] RRObjectPolicy b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x8A52150", Offset = "0x8A50D50", VA = "0x188A52150")]
		[AsyncStateMachine(typeof(<PreserializeViews>d__8))]
		private Task BHXKIJFWRLK(SerializeType a, PersistenceView[] b, StringBuilder c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x8A52440", Offset = "0x8A51040", VA = "0x188A52440")]
		private RoomSerializedData QELJAQXAPQD(long a, RoomSaveOptions b, SerializeType c, IEnumerable<PersistenceView> d, StringBuilder e)
		{
			return default(RoomSerializedData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x8A52290", Offset = "0x8A50E90", VA = "0x188A52290")]
		private PersistedRoomData EFYKZUMBJBD(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x8A51F00", Offset = "0x8A50B00", VA = "0x188A51F00")]
		private void BAEGZIBFNDU(PersistedRoomData a, StringBuilder b, IEnumerable<PersistenceView> c, [In] RoomSerializedMetadata metadata, KBWJHRDTEZE d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x8A52A10", Offset = "0x8A51610", VA = "0x188A52A10")]
		private void RQGHOTCKTGP(PersistedRoomData a, StringBuilder b, PersistenceView c, KBWJHRDTEZE d, [In] RoomSerializedMetadata metadata)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	internal class RoomUploadLogic : MOCIFKPOHOS
	{
		[Cpp2IlInjected.Token(Token = "0x20001AA")]
		[CompilerGenerated]
		private sealed class WNRSWAJADRM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20001AB")]
			private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400078B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400078C")]
				public AsyncTaskMethodBuilder<RECTXKHRIXS> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400078D")]
				public WNRSWAJADRM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400078E")]
				public CancellationToken masterLockedBlockCancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400078F")]
				private RECTXKHRIXS <reloadMessage>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000790")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000791")]
				private TaskAwaiter<RemoteRunDTO> <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000792")]
				private TaskAwaiter<SaveSubRoomResponseDTO> <>u__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000793")]
				private TaskAwaiter<RECTXKHRIXS> <>u__4;

				[Cpp2IlInjected.Token(Token = "0x60006C4")]
				[Cpp2IlInjected.Address(RVA = "0x8A62280", Offset = "0x8A60E80", VA = "0x188A62280", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006C5")]
				[Cpp2IlInjected.Address(RVA = "0x8A634A0", Offset = "0x8A620A0", VA = "0x188A634A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000783")]
			public RoomUploadLogic BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000784")]
			public RoomSerializedData NJJYEASWNJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000785")]
			public int VVAWITLZNZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000786")]
			public long JPAUAGQURNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000787")]
			public long EYBJRVHSVUF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000788")]
			public RoomSaveRequestPayload RRJLQVCSANO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000789")]
			public RoomSaveAnalyticsInfo AQAXPVIQJNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400078A")]
			public StackTimer<string>.USVZTROCTRS BUREXCMRKUO;

			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public WNRSWAJADRM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0x8A66430", Offset = "0x8A65030", VA = "0x188A66430")]
			[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
			internal Task<RECTXKHRIXS> BEELIVXMGTF(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AC")]
		[CompilerGenerated]
		private sealed class JWFSMWPDEJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000794")]
			public Storage.UploadFileResponseDTO TVNIDNWBKJP;

			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public JWFSMWPDEJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x8A55050", Offset = "0x8A53C50", VA = "0x188A55050")]
			internal object DZXGTHYEXAD()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AD")]
		[CompilerGenerated]
		private struct <PushRoomDataBlobToStudio>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000795")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000796")]
			public AsyncTaskMethodBuilder<RemoteRunDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000797")]
			public RoomUploadLogic <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000798")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000799")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400079A")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400079B")]
			public string studioSessionId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400079C")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400079D")]
			private TaskAwaiter<(Storage.UploadFileResponseDTO roomDataUpload, Storage.UploadFileResponseDTO subRoomDataUpload)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400079E")]
			private TaskAwaiter<RemoteRunDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x8A5C630", Offset = "0x8A5B230", VA = "0x188A5C630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(RVA = "0x8A5CAE0", Offset = "0x8A5B6E0", VA = "0x188A5CAE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AE")]
		[CompilerGenerated]
		private struct <UploadRoomDataBlob>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400079F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			public AsyncTaskMethodBuilder<SaveSubRoomResponseDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			public UFFFZRRBPXW callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007A2")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007A3")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007A4")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007A5")]
			public UgcVersionInfo ugcVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007A6")]
			public RoomSaveRequestPayload roomSaveRequestPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007A7")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007A8")]
			private TaskAwaiter<(Storage.UploadFileResponseDTO roomDataUpload, Storage.UploadFileResponseDTO subRoomDataUpload)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007A9")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(RVA = "0x8A63E90", Offset = "0x8A62A90", VA = "0x188A63E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CB")]
			[Cpp2IlInjected.Address(RVA = "0x8A644F0", Offset = "0x8A630F0", VA = "0x188A644F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		[CompilerGenerated]
		private struct <UploadRoomDataBlob>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007AA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007AB")]
			public AsyncTaskMethodBuilder<SaveSubRoomResponseDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			public RoomUploadLogic <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			public RoomSaveRequestPayload roomSaveRequestPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0x8A64560", Offset = "0x8A63160", VA = "0x188A64560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CD")]
			[Cpp2IlInjected.Address(RVA = "0x8A64800", Offset = "0x8A63400", VA = "0x188A64800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001B0")]
		[CompilerGenerated]
		private struct <UploadRoomDataBlobAndSyncReload>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			public AsyncTaskMethodBuilder<RECTXKHRIXS> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			public RoomUploadLogic <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007B7")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007B8")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007B9")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007BA")]
			public RoomSaveRequestPayload roomSaveRequestPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007BB")]
			public RoomSaveAnalyticsInfo roomSaveAnalyticsInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007BC")]
			public StackTimer<string>.USVZTROCTRS stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007BD")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007BE")]
			private TaskAwaiter<RECTXKHRIXS> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006CE")]
			[Cpp2IlInjected.Address(RVA = "0x8A63B00", Offset = "0x8A62700", VA = "0x188A63B00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0x8A63E20", Offset = "0x8A62A20", VA = "0x188A63E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001B1")]
		[CompilerGenerated]
		private struct <UploadRoomDataToStorage>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007C0")]
			public AsyncTaskMethodBuilder<(Storage.UploadFileResponseDTO roomDataUpload, Storage.UploadFileResponseDTO subRoomDataUpload)> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007C1")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007C2")]
			public UFFFZRRBPXW callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007C3")]
			private JWFSMWPDEJC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007C4")]
			private byte[] <data>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007C5")]
			private float <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40007C6")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007C7")]
			private TaskAwaiter<Storage.UploadFileResponseDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(RVA = "0x8A64870", Offset = "0x8A63470", VA = "0x188A64870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x8A650C0", Offset = "0x8A63CC0", VA = "0x188A650C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000780")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x4000781")]
		private static readonly Log KXBXUDVNWOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		private readonly FEQJSDHNGZK TWZOONPWFRH;

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		private IIDBRQOYHQN KDKTQYKQZVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006B9")]
			[Cpp2IlInjected.Address(RVA = "0x8A37120", Offset = "0x8A35D20", VA = "0x188A37120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x8A59660", Offset = "0x8A58260", VA = "0x188A59660")]
		public RoomUploadLogic(VGXLHGZFUHZ operationContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x8A59470", Offset = "0x8A58070", VA = "0x188A59470")]
		[AsyncStateMachine(typeof(<UploadRoomDataToStorage>d__7))]
		private static Task<(Storage.UploadFileResponseDTO, Storage.UploadFileResponseDTO)> XUSQPUBWNYF(UFFFZRRBPXW a, RoomSerializedData b, long c, long d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x8A59150", Offset = "0x8A57D50", VA = "0x188A59150")]
		[AsyncStateMachine(typeof(<UploadRoomDataBlob>d__8))]
		public Task<SaveSubRoomResponseDTO> BSMJNATWEOC(int a, [CanBeNull] RoomSaveRequestPayload roomSaveRequestPayload, RoomSerializedData b, long c, long d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x8A58E00", Offset = "0x8A57A00", VA = "0x188A58E00")]
		public static Task<SaveSubRoomResponseDTO> BSMJNATWEOC(UFFFZRRBPXW a, int b, [CanBeNull] RoomSaveRequestPayload roomSaveRequestPayload, RoomSerializedData c, long d, long e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x8A58C70", Offset = "0x8A57870", VA = "0x188A58C70")]
		[AsyncStateMachine(typeof(<UploadRoomDataBlob>d__10))]
		public static Task<SaveSubRoomResponseDTO> BSMJNATWEOC(UFFFZRRBPXW a, int b, [CanBeNull] RoomSaveRequestPayload roomSaveRequestPayload, RoomSerializedData c, long d, long e, UgcVersionInfo f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x8A58AF0", Offset = "0x8A576F0", VA = "0x188A58AF0")]
		[AsyncStateMachine(typeof(<PushRoomDataBlobToStudio>d__11))]
		private Task<RemoteRunDTO> ANUYEPIXAVO(string a, int b, RoomSerializedData c, long d, long e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x8A592C0", Offset = "0x8A57EC0", VA = "0x188A592C0")]
		[AsyncStateMachine(typeof(<UploadRoomDataBlobAndSyncReload>d__12))]
		public Task<RECTXKHRIXS> DAZJBUMRITP(int a, RoomSaveRequestPayload? roomSaveRequestPayload, RoomSerializedData b, long c, long d, RoomSaveAnalyticsInfo e, StackTimer<string>.USVZTROCTRS f, CancellationToken g)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	public abstract class BMBBEHETYBJ<a> where a : BMBBEHETYBJ<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		internal readonly IIDBRQOYHQN SMMMDIRBDNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		private int? LPIOPOUUMGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		protected readonly Guid DHODELSEGWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		protected readonly RoomOperationType ZOYVJOSMAUZ;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		protected a NXZUZIMVKDL
		{
			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x6D93D30", Offset = "0x6D92930", VA = "0x186D93D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x6D940B0", Offset = "0x6D92CB0", VA = "0x186D940B0")]
		internal BMBBEHETYBJ(IIDBRQOYHQN a, RoomOperationType b, [Optional] Guid? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x6D93F20", Offset = "0x6D92B20", VA = "0x186D93F20")]
		private RECTXKHRIXS UZLGJFDBRHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "4")]
		protected virtual void BKDSOKIHHAQ(RECTXKHRIXS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x6D93C30", Offset = "0x6D92830", VA = "0x186D93C30")]
		public a CWDIFVXLCYN(HNNNRVHBOIU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x6D94000", Offset = "0x6D92C00", VA = "0x186D94000")]
		public a VCSHNYZIXCZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x6D93D90", Offset = "0x6D92990", VA = "0x186D93D90", Slot = "5")]
		public virtual Task<WLRKHVLXMOD> Submit()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	public class XVADGRDCPCQ : BMBBEHETYBJ<XVADGRDCPCQ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		private RoomLoadRequestPayload QKPDYIWEYPR;

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x8A666A0", Offset = "0x8A652A0", VA = "0x188A666A0")]
		internal XVADGRDCPCQ(IIDBRQOYHQN a, RoomOperationType b, [Optional] Guid? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C00F20", Offset = "0x7BFFB20", VA = "0x187C00F20")]
		public XVADGRDCPCQ ASZVTSVYFSH(RoomLoadRequestPayload a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x8A665D0", Offset = "0x8A651D0", VA = "0x188A665D0", Slot = "4")]
		protected override void BKDSOKIHHAQ(RECTXKHRIXS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	public class DNDPXJXMLLV : BMBBEHETYBJ<DNDPXJXMLLV>
	{
		[Cpp2IlInjected.Token(Token = "0x20001B5")]
		internal enum SaveTarget
		{
			[Cpp2IlInjected.Token(Token = "0x40007D1")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40007D2")]
			Disk,
			[Cpp2IlInjected.Token(Token = "0x40007D3")]
			RecNet
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001B6")]
		[CompilerGenerated]
		private struct <Submit>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007D4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007D5")]
			public AsyncTaskMethodBuilder<WLRKHVLXMOD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007D6")]
			public DNDPXJXMLLV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007D7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007D8")]
			private TaskAwaiter<WLRKHVLXMOD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006E4")]
			[Cpp2IlInjected.Address(RVA = "0x8A61680", Offset = "0x8A60280", VA = "0x188A61680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0x8A61A20", Offset = "0x8A60620", VA = "0x188A61A20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		private SaveTarget WDKRUBAHAYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		private string FJYOIYZUBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		private RoomSaveRequestPayload QKPDYIWEYPR;

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x8A53410", Offset = "0x8A52010", VA = "0x188A53410")]
		internal DNDPXJXMLLV(IIDBRQOYHQN a, RoomOperationType b, [Optional] Guid? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x8A530E0", Offset = "0x8A51CE0", VA = "0x188A530E0")]
		public DNDPXJXMLLV AAJKXZCGQYD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x8A532A0", Offset = "0x8A51EA0", VA = "0x188A532A0")]
		public DNDPXJXMLLV IRZZIOVTSKL(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x8A533F0", Offset = "0x8A51FF0", VA = "0x188A533F0")]
		public DNDPXJXMLLV ZABIIBISTAL(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x8A53270", Offset = "0x8A51E70", VA = "0x188A53270")]
		public DNDPXJXMLLV HNZZLFORPDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x8A53110", Offset = "0x8A51D10", VA = "0x188A53110", Slot = "4")]
		protected override void BKDSOKIHHAQ(RECTXKHRIXS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x8A532C0", Offset = "0x8A51EC0", VA = "0x188A532C0", Slot = "5")]
		[AsyncStateMachine(typeof(<Submit>d__11))]
		public override Task<WLRKHVLXMOD> Submit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A533B0", Offset = "0x8A51FB0", VA = "0x188A533B0")]
		[CompilerGenerated]
		[DebuggerHidden]
		private Task<WLRKHVLXMOD> VKUMVPDCKKZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	internal static class YRNRSDTCEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x8A69190", Offset = "0x8A67D90", VA = "0x188A69190")]
		public static void EISLVSOFXBW(this PlayerPresence a, RoomInstance b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x8A69110", Offset = "0x8A67D10", VA = "0x188A69110")]
		public static void EEMIRUKBGEN(this RoomInstance a, [Optional] string b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	public static class DBVTQTDJGOQ
	{
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x8A51CC0", Offset = "0x8A508C0", VA = "0x188A51CC0")]
		public static FilenameWithHash ANIMGWELRIT(this DJALRWZMQMG a)
		{
			return default(FilenameWithHash);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x8A51D60", Offset = "0x8A50960", VA = "0x188A51D60")]
		public static DJALRWZMQMG IBUHCYQJIOE(this FilenameWithHash a)
		{
			return null;
		}
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001BA")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			public ValidationReason ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007DE")]
			public ValidationReason HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007DF")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007E0")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007E1")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007D9")]
		private static ValidationReason[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		private Dictionary<ValidationReason, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x8A662A0", Offset = "0x8A64EA0", VA = "0x188A662A0")]
		public bool TryGetConfig(ValidationReason validationReason, [Out] ResultConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x8A65A00", Offset = "0x8A64600", VA = "0x188A65A00")]
		public ResultConfig GetConfigForResult(ValidationReason reason, [Optional] HashSet<ValidationReason> visited)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x8A660C0", Offset = "0x8A64CC0", VA = "0x188A660C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x8A65B30", Offset = "0x8A64730", VA = "0x188A65B30", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xB904D0", Offset = "0xB8F0D0", VA = "0x180B904D0")]
		public ValidationResultConfig()
		{
		}
	}
}
namespace RecRoom.RoomLoading.PreEmptyScene
{
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	public class RoomManagerPreEmptyScene : TIKAXYDLCSO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001BD")]
		[CompilerGenerated]
		private struct <Run>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007E9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007EA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007EB")]
			public RoomManagerPreEmptyScene <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007EC")]
			public StackTimer<string>.USVZTROCTRS timerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007ED")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007EE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x8A60270", Offset = "0x8A5EE70", VA = "0x188A60270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0x8A60500", Offset = "0x8A5F100", VA = "0x188A60500", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001BE")]
		[CompilerGenerated]
		private struct <RunHandlerWithCancellationForwarding>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007F0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007F1")]
			public StackTimer<string>.USVZTROCTRS timerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007F2")]
			public TIKAXYDLCSO preEmptySceneHandler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007F3")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007F4")]
			private StackTimer<string>.USVZTROCTRS <ts>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007F5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006FF")]
			[Cpp2IlInjected.Address(RVA = "0x8A5D730", Offset = "0x8A5C330", VA = "0x188A5D730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000700")]
			[Cpp2IlInjected.Address(RVA = "0x8A5DBE0", Offset = "0x8A5C7E0", VA = "0x188A5DBE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		private readonly XDJWTZTHCGU HSMYDTTWODF;

		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		public string HQPNIRHMMED
		{
			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0x8A588B0", Offset = "0x8A574B0", VA = "0x188A588B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x8A588E0", Offset = "0x8A574E0", VA = "0x188A588E0")]
		[YLZSHGPPZTN.Root.GameOnly]
		internal static void YANVPOGGICD(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		[RecRoom.NoEngine.Common.Preserve]
		public RoomManagerPreEmptyScene([Inject(null)] XDJWTZTHCGU assetBundlePreEmptySceneHandler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A587A0", Offset = "0x8A573A0", VA = "0x188A587A0", Slot = "5")]
		[AsyncStateMachine(typeof(<Run>d__6))]
		public Task Run(StackTimer<string>.USVZTROCTRS timerScope, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x8A58680", Offset = "0x8A57280", VA = "0x188A58680")]
		[AsyncStateMachine(typeof(<RunHandlerWithCancellationForwarding>d__7))]
		private Task NSOHXULNSRS(TIKAXYDLCSO a, StackTimer<string>.USVZTROCTRS b, CancellationToken c)
		{
			return null;
		}
	}
}
namespace RecRoom.RoomLoading.Interfaces.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	public interface XDJWTZTHCGU : TIKAXYDLCSO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	public interface TIKAXYDLCSO
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		string HQPNIRHMMED
		{
			[Cpp2IlInjected.Token(Token = "0x6000701")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task Run(StackTimer<string>.USVZTROCTRS timerScope, CancellationToken cancellationToken);
	}
}
namespace RecRoom.RoomLoading.AutoSaves
{
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	public static class HPLKHJBRAQF
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x8A53B60", Offset = "0x8A52760", VA = "0x188A53B60")]
		[YLZSHGPPZTN.Root.GameOnly]
		internal static void IGQDZAZABEW(URVRSSRGCJF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	public interface QLEODJJBPHT : IEquatable<QLEODJJBPHT>
	{
		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		DateTime JMQPZOCMJEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Delete();

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LKSXBIRHLEA(long a, long b, [Out] RoomSerializedData c);
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	internal class KDQKKVRSQGN : BDVEDVZIGPE
	{
		[Cpp2IlInjected.Token(Token = "0x20001C5")]
		[CompilerGenerated]
		private sealed class XVCGTKCCKDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007FA")]
			public AutosaveType AOSXNRGYNFT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007FB")]
			public Exception WSMDIYHYEOO;

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XVCGTKCCKDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x8A66770", Offset = "0x8A65370", VA = "0x188A66770")]
			internal object FGSCUCIVQUR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		private readonly XANHSYPSKFO ZXSUARPNVVD;

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<QLEODJJBPHT> MIXIIFKCBIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0x8A55210", Offset = "0x8A53E10", VA = "0x188A55210", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0x8A558B0", Offset = "0x8A544B0", VA = "0x188A558B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		[UnityEngine.Scripting.Preserve]
		public KDQKKVRSQGN([Inject(null)] XANHSYPSKFO autosaveStorageService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x8A55960", Offset = "0x8A54560", VA = "0x188A55960", Slot = "6")]
		public bool VSXZSRWSWLV(long a, long b, RoomSerializedData c, AutosaveType d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xC77EF0", Offset = "0xC76AF0", VA = "0x180C77EF0")]
		private void CVCEFHFTIPC(QLEODJJBPHT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x8A550A0", Offset = "0x8A53CA0", VA = "0x188A550A0", Slot = "7")]
		public bool ABPPXSKCJND(long a, long b, [Out] QLEODJJBPHT c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x8A55800", Offset = "0x8A54400", VA = "0x188A55800", Slot = "8")]
		public bool UFTMUMEMLMK(long a, long b, AutosaveType c, [Out] QLEODJJBPHT d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x8A553E0", Offset = "0x8A53FE0", VA = "0x188A553E0")]
		private void SPKZRIYHBTP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x8A552C0", Offset = "0x8A53EC0", VA = "0x188A552C0", Slot = "9")]
		public void HSFLAFMOXBD(long a, long b)
		{
		}
	}
}
namespace RecRoom.RoomLoading.AutoSaves.Versions
{
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	internal abstract class OTUSUTSLBUO : XANHSYPSKFO
	{
		[Cpp2IlInjected.Token(Token = "0x20001C7")]
		protected enum DirectoryAccessMode : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40007FE")]
			Read,
			[Cpp2IlInjected.Token(Token = "0x40007FF")]
			Write
		}

		[Cpp2IlInjected.Token(Token = "0x20001C8")]
		[CompilerGenerated]
		private sealed class NIBWJFEAYEQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000800")]
			public AutosaveType AOSXNRGYNFT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000801")]
			public FileInfo NKWXYMOFCNB;

			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public NIBWJFEAYEQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0x8A565B0", Offset = "0x8A551B0", VA = "0x188A565B0")]
			internal object JFSAVUUWDGM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001C9")]
		[CompilerGenerated]
		private sealed class SEWWWLJILVR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000802")]
			public OTUSUTSLBUO BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000803")]
			public FileInfo GZBVLXBNZKB;

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SEWWWLJILVR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x8A598C0", Offset = "0x8A584C0", VA = "0x188A598C0")]
			internal void ENKDFVRSGMM(PlayerReporting.HileType a, string b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001CA")]
		[CompilerGenerated]
		private sealed class YFOFCAREDAB : IEnumerable<QLEODJJBPHT>, IEnumerable, IEnumerator<QLEODJJBPHT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000804")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000805")]
			private QLEODJJBPHT VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000806")]
			private int FTPEWITHWYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			public OTUSUTSLBUO BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000808")]
			private AutosaveType AOSXNRGYNFT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000809")]
			public AutosaveType CFUSDDMCQJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400080A")]
			private FileInfo[] KYBQTQIMGAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400080B")]
			private int KYGXQXCJPLU;

			[Cpp2IlInjected.Token(Token = "0x170000FE")]
			private QLEODJJBPHT DPXQGNLJPOJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000729")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FF")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x600072B")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0xD18690", Offset = "0xD17290", VA = "0x180D18690")]
			[DebuggerHidden]
			public YFOFCAREDAB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "7")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x8A669F0", Offset = "0x8A655F0", VA = "0x188A669F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x8A67090", Offset = "0x8A65C90", VA = "0x188A67090", Slot = "10")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x8A66EF0", Offset = "0x8A65AF0", VA = "0x188A66EF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<QLEODJJBPHT> WRYRDZVBMYK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x8A66EF0", Offset = "0x8A65AF0", VA = "0x188A66EF0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		private readonly object SCWWIJITTEC;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		protected string QUYNMOOQWZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x8A56CA0", Offset = "0x8A558A0", VA = "0x188A56CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public abstract AutosaveVersion PLWRYYJACUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x8A57040", Offset = "0x8A55C40", VA = "0x188A57040")]
		protected OTUSUTSLBUO([CanBeNull] string persistentDataDir)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x8A56AB0", Offset = "0x8A556B0", VA = "0x188A56AB0", Slot = "5")]
		public bool NWXZNDXUGNU(long a, long b, AutosaveType c, [Out] QLEODJJBPHT d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x8A566C0", Offset = "0x8A552C0", VA = "0x188A566C0", Slot = "6")]
		[IteratorStateMachine(typeof(YFOFCAREDAB))]
		public IEnumerable<QLEODJJBPHT> JUUHPIKPHKG(AutosaveType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		internal abstract void RFKJELMRVDJ(Stream a, long b, long c, RoomSerializedData d);

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		internal abstract bool XAOCJURSPHU(Stream a, long b, long c, HileFunc d, [Out] RoomSerializedData e);

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x8A56740", Offset = "0x8A55340", VA = "0x188A56740", Slot = "7")]
		public QLEODJJBPHT KOECCTCRDRS(long a, long b, RoomSerializedData c, AutosaveType d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		[NotNull]
		protected abstract FileInfo HFZFVJTGYAB(long a, long b, AutosaveType c, DirectoryAccessMode d);

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		[NotNull]
		protected abstract DirectoryInfo VXAMWEXDJDT(AutosaveType a, DirectoryAccessMode b);

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x8A56650", Offset = "0x8A55250", VA = "0x188A56650")]
		protected void HJAHEURJVZD(PlayerReporting.HileType a, string b, FileInfo c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x8A56CB0", Offset = "0x8A558B0", VA = "0x188A56CB0")]
		internal bool XQGGDVDVWDC(FileInfo a, long b, long c, [Out] RoomSerializedData d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private void WANGYDVSJDY(Exception a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	internal class YFXCHFAUEUT : OTUSUTSLBUO
	{
		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public override AutosaveVersion PLWRYYJACUL
		{
			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0xCFB260", Offset = "0xCF9E60", VA = "0x180CFB260", Slot = "8")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x8A69080", Offset = "0x8A67C80", VA = "0x188A69080")]
		public YFXCHFAUEUT([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x8A68570", Offset = "0x8A67170", VA = "0x188A68570")]
		private void KRBQHKOIYYR(AutosaveType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x8A685F0", Offset = "0x8A671F0", VA = "0x188A685F0", Slot = "9")]
		internal override void RFKJELMRVDJ(Stream a, long b, long c, RoomSerializedData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x8A68980", Offset = "0x8A67580", VA = "0x188A68980", Slot = "10")]
		internal override bool XAOCJURSPHU(Stream a, long b, long c, HileFunc d, [Out] RoomSerializedData e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x8A68490", Offset = "0x8A67090", VA = "0x188A68490", Slot = "11")]
		protected override FileInfo HFZFVJTGYAB(long a, long b, AutosaveType c, DirectoryAccessMode d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x8A68880", Offset = "0x8A67480", VA = "0x188A68880", Slot = "12")]
		protected override DirectoryInfo VXAMWEXDJDT(AutosaveType a, DirectoryAccessMode b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	internal sealed class YFRVJYGWVJK : OTUSUTSLBUO
	{
		[Cpp2IlInjected.Token(Token = "0x400080C")]
		private static readonly byte[] QDRJQNEVYTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400080D")]
		private readonly byte[] WNTFIOIQOZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400080E")]
		private readonly byte[] GVRGCCCCBGH;

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public override AutosaveVersion PLWRYYJACUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x74E9240", Offset = "0x74E7E40", VA = "0x1874E9240", Slot = "8")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x8A68360", Offset = "0x8A66F60", VA = "0x188A68360")]
		public YFRVJYGWVJK([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x8A67340", Offset = "0x8A65F40", VA = "0x188A67340", Slot = "9")]
		internal override void RFKJELMRVDJ(Stream a, long b, long c, RoomSerializedData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x8A67860", Offset = "0x8A66460", VA = "0x188A67860", Slot = "10")]
		internal override bool XAOCJURSPHU(Stream a, long b, long c, HileFunc d, [Out] RoomSerializedData e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x8A67160", Offset = "0x8A65D60", VA = "0x188A67160")]
		private void ACLDOXXMIPB(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x8A67220", Offset = "0x8A65E20", VA = "0x188A67220", Slot = "11")]
		protected override FileInfo HFZFVJTGYAB(long a, long b, AutosaveType c, DirectoryAccessMode d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x8A67750", Offset = "0x8A66350", VA = "0x188A67750", Slot = "12")]
		protected override DirectoryInfo VXAMWEXDJDT(AutosaveType a, DirectoryAccessMode b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	public enum AutosaveVersion : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		INVALID = 0,
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		CHECKSUM = 2,
		[Cpp2IlInjected.Token(Token = "0x4000814")]
		BETTER_FILE_LAYOUT = 3
	}
}
namespace RecRoom.RoomLoading.AutoSaves.Storage
{
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	internal class UCEROCSFKOV : XANHSYPSKFO
	{
		[Cpp2IlInjected.Token(Token = "0x20001D1")]
		[CompilerGenerated]
		private sealed class YFOFCAREDAB : IEnumerable<QLEODJJBPHT>, IEnumerable, IEnumerator<QLEODJJBPHT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400081B")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400081C")]
			private QLEODJJBPHT VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400081D")]
			private int FTPEWITHWYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400081E")]
			public UCEROCSFKOV BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400081F")]
			private AutosaveType AOSXNRGYNFT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000820")]
			public AutosaveType CFUSDDMCQJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000821")]
			private AutosaveVersion[] KYBQTQIMGAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000822")]
			private int KYGXQXCJPLU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000823")]
			private IEnumerator<QLEODJJBPHT> KYMEODWGYXD;

			[Cpp2IlInjected.Token(Token = "0x17000103")]
			private QLEODJJBPHT DPXQGNLJPOJ
			{
				[Cpp2IlInjected.Token(Token = "0x600074F")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000104")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000751")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0xD18690", Offset = "0xD17290", VA = "0x180D18690")]
			[DebuggerHidden]
			public YFOFCAREDAB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x8A670D0", Offset = "0x8A65CD0", VA = "0x188A670D0", Slot = "7")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x8A66C10", Offset = "0x8A65810", VA = "0x188A66C10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x8A669A0", Offset = "0x8A655A0", VA = "0x188A669A0")]
			private void LSRJDRRKPDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x8A67050", Offset = "0x8A65C50", VA = "0x188A67050", Slot = "10")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x8A66FA0", Offset = "0x8A65BA0", VA = "0x188A66FA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<QLEODJJBPHT> WRYRDZVBMYK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x8A66FA0", Offset = "0x8A65BA0", VA = "0x188A66FA0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		private readonly AutosaveVersion[] EFDQJWGGVQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		private readonly Dictionary<AutosaveVersion, XANHSYPSKFO> BWLRCSTDEEG;

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		public AutosaveVersion PLWRYYJACUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x8A65130", Offset = "0x8A63D30", VA = "0x188A65130", Slot = "4")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x8A656D0", Offset = "0x8A642D0", VA = "0x188A656D0")]
		[UnityEngine.Scripting.Preserve]
		public UCEROCSFKOV(params XANHSYPSKFO[] versionImpls)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x8A65580", Offset = "0x8A64180", VA = "0x188A65580", Slot = "5")]
		public bool NWXZNDXUGNU(long a, long b, AutosaveType c, [Out] QLEODJJBPHT d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x8A65160", Offset = "0x8A63D60", VA = "0x188A65160")]
		private void JRUMZVGTBYO(int a, long b, long c, AutosaveType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x8A653A0", Offset = "0x8A63FA0", VA = "0x188A653A0", Slot = "6")]
		[IteratorStateMachine(typeof(YFOFCAREDAB))]
		public IEnumerable<QLEODJJBPHT> JUUHPIKPHKG(AutosaveType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x8A65420", Offset = "0x8A64020", VA = "0x188A65420", Slot = "7")]
		public QLEODJJBPHT KOECCTCRDRS(long a, long b, RoomSerializedData c, AutosaveType d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D2")]
	internal static class LCSLEQTNOXD
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x8A560E0", Offset = "0x8A54CE0", VA = "0x188A560E0")]
		internal static byte[] RTRSQTWBEPC(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x8A561A0", Offset = "0x8A54DA0", VA = "0x188A561A0")]
		public static void TOZZJJESKCI(Stream a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x8A55F00", Offset = "0x8A54B00", VA = "0x188A55F00")]
		public static bool MOKPGUXTNAL(Stream a, long b, HileFunc c, [Out] byte[] d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D3")]
	internal sealed class HCKWRLLWHWG : QLEODJJBPHT, IEquatable<QLEODJJBPHT>, IEquatable<HCKWRLLWHWG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private readonly OTUSUTSLBUO FLGCLORXITC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000825")]
		public readonly FileInfo FAOUGPUQJOR;

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public AutosaveVersion PLWRYYJACUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0x8309F80", Offset = "0x8308B80", VA = "0x188309F80", Slot = "9")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public DateTime JMQPZOCMJEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x8A53580", Offset = "0x8A52180", VA = "0x188A53580", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x8A53A60", Offset = "0x8A52660", VA = "0x188A53A60")]
		public HCKWRLLWHWG(OTUSUTSLBUO a, FileInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x8A539B0", Offset = "0x8A525B0", VA = "0x188A539B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x8A53610", Offset = "0x8A52210", VA = "0x188A53610", Slot = "5")]
		public void Delete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x8A53970", Offset = "0x8A52570", VA = "0x188A53970", Slot = "6")]
		public bool LKSXBIRHLEA(long a, long b, [Out] RoomSerializedData c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x8A53870", Offset = "0x8A52470", VA = "0x188A53870", Slot = "7")]
		public bool Equals(QLEODJJBPHT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x8A537B0", Offset = "0x8A523B0", VA = "0x188A537B0", Slot = "8")]
		public bool Equals(HCKWRLLWHWG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x8A536D0", Offset = "0x8A522D0", VA = "0x188A536D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x8A538E0", Offset = "0x8A524E0", VA = "0x188A538E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D4")]
	public delegate void HileFunc(PlayerReporting.HileType hileType, string message);
	[Cpp2IlInjected.Token(Token = "0x20001D5")]
	internal interface XANHSYPSKFO
	{
		[Cpp2IlInjected.Token(Token = "0x17000107")]
		AutosaveVersion PLWRYYJACUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool NWXZNDXUGNU(long a, long b, AutosaveType c, [Out] QLEODJJBPHT d);

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IEnumerable<QLEODJJBPHT> JUUHPIKPHKG(AutosaveType a);

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(Slot = "3")]
		QLEODJJBPHT KOECCTCRDRS(long a, long b, RoomSerializedData c, AutosaveType d);
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
