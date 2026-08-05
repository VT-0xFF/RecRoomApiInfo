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
using ExitGames.Client.Photon;
using Google.Protobuf;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D1D200", Offset = "0x8D1B800", VA = "0x188D1D200")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class RRWPZJUWVEY
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal Task<RoomLoadDetails> WTTHQZSBRBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal Task HMVYXJHUYFS;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal UWDFKAULHCP KSDRDVLGJQO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
	public RRWPZJUWVEY()
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
		[Cpp2IlInjected.Address(RVA = "0x8D1CBE0", Offset = "0x8D1B1E0", VA = "0x188D1CBE0", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D38FC0", Offset = "0x8D375C0", VA = "0x188D38FC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2980B40", Offset = "0x297F140", VA = "0x182980B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D1EC00", Offset = "0x8D1D200", VA = "0x188D1EC00")]
		public RecoverableRoomOperationException(string message, Exception innerException)
		{
		}
	}
}
namespace RoomOperation.OperationLogic.Restore
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal class JTIOBBTIUIQ : RWMACKNQYZX
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
			[Cpp2IlInjected.Address(RVA = "0x8D2EA40", Offset = "0x8D2D040", VA = "0x188D2EA40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8D2EC50", Offset = "0x8D2D250", VA = "0x188D2EC50", Slot = "5")]
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
			private TaskAwaiter<SubRoomDataSavePagedResultsDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8D2FB70", Offset = "0x8D2E170", VA = "0x188D2FB70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8D2FDB0", Offset = "0x8D2E3B0", VA = "0x188D2FDB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		[UnityEngine.Scripting.Preserve]
		public JTIOBBTIUIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ACE0", Offset = "0x8D192E0", VA = "0x188D1ACE0", Slot = "4")]
		[AsyncStateMachine(typeof(<GetSubRoomDataHistory>d__1))]
		public Task<IReadOnlyList<SubRoomDataSaveDTO>> RTHQOVSSEPB(long a, long b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ABD0", Offset = "0x8D191D0", VA = "0x188D1ABD0", Slot = "5")]
		[AsyncStateMachine(typeof(<GetAccountsBulk>d__2))]
		public Task<IReadOnlyList<Account>> FNKSOXSHJVW(IReadOnlyList<int> a, [Optional] CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface QSIXHZNRTBA : IEquatable<QSIXHZNRTBA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int AJCGFULBSHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[CanBeNull]
		Account HVTLGLMHAON
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		DateTime SUUEJSTUAOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		PlatformType? PYDTCMFJTNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		DeviceClass? YNJZEUFTZTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		[CanBeNull]
		RestoreOptionTypes ZZEFJYISERN
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<EARYEWOAMEK> HYVHFZBJPSC();
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
	public interface RWMACKNQYZX
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<SubRoomDataSaveDTO>> RTHQOVSSEPB(long a, long b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<IReadOnlyList<Account>> FNKSOXSHJVW(IReadOnlyList<int> a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class TTSAMIBGSYZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private sealed class PENKVCRPVCG : QSIXHZNRTBA, IEquatable<QSIXHZNRTBA>
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
				public AsyncTaskMethodBuilder<EARYEWOAMEK> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public PENKVCRPVCG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				private EUHMRSURXFV <roomManager>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				private TaskAwaiter<RoomDetailsDTO> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				private TaskAwaiter<EARYEWOAMEK> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x8D303A0", Offset = "0x8D2E9A0", VA = "0x188D303A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x8D30920", Offset = "0x8D2EF20", VA = "0x188D30920", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly SubRoomDataSaveDTO GUIFKSBTZIC;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int AJCGFULBSHO
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0xAAA9D0", Offset = "0xAA8FD0", VA = "0x180AAA9D0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public Account HVTLGLMHAON
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private DateTime LXCFRDDLPXL
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x8D1DC10", Offset = "0x8D1C210", VA = "0x188D1DC10", Slot = "6")]
				get
				{
					return default(DateTime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public PlatformType? PYDTCMFJTNH
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2D93D20", Offset = "0x2D92320", VA = "0x182D93D20", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public DeviceClass? YNJZEUFTZTO
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x8D1DBB0", Offset = "0x8D1C1B0", VA = "0x188D1DBB0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public RestoreOptionTypes ZZEFJYISERN
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "10")]
				get
				{
					return default(RestoreOptionTypes);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8D1DAB0", Offset = "0x8D1C0B0", VA = "0x188D1DAB0", Slot = "9")]
			[AsyncStateMachine(typeof(<Restore>d__13))]
			public Task<EARYEWOAMEK> HYVHFZBJPSC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8D1DC30", Offset = "0x8D1C230", VA = "0x188D1DC30")]
			public PENKVCRPVCG(int a, Account b, SubRoomDataSaveDTO c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8D1D900", Offset = "0x8D1BF00", VA = "0x188D1D900", Slot = "11")]
			public bool Equals(QSIXHZNRTBA other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8D1D990", Offset = "0x8D1BF90", VA = "0x188D1D990", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8D1DBD0", Offset = "0x8D1C1D0", VA = "0x188D1DBD0")]
			private bool QLDQQTOJNOE(PENKVCRPVCG a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8D1DA30", Offset = "0x8D1C030", VA = "0x188D1DA30", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private sealed class VSHKAYINKIJ : QSIXHZNRTBA, IEquatable<QSIXHZNRTBA>
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
				public AsyncTaskMethodBuilder<EARYEWOAMEK> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public VSHKAYINKIJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				private TaskAwaiter<EARYEWOAMEK> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x8D30BF0", Offset = "0x8D2F1F0", VA = "0x188D30BF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x8D30E40", Offset = "0x8D2F440", VA = "0x188D30E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly NJHMYSMXXYI PCDXOOPECMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly PlatformType YNFIZNGEPAW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly DeviceClass BMAIQVUKXKF;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int AJCGFULBSHO
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x8D38860", Offset = "0x8D36E60", VA = "0x188D38860", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Account HVTLGLMHAON
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x8D38900", Offset = "0x8D36F00", VA = "0x188D38900", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private DateTime LXCFRDDLPXL
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x8D38990", Offset = "0x8D36F90", VA = "0x188D38990", Slot = "6")]
				get
				{
					return default(DateTime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public PlatformType? PYDTCMFJTNH
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x8D38810", Offset = "0x8D36E10", VA = "0x188D38810", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public DeviceClass? YNJZEUFTZTO
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x8D387C0", Offset = "0x8D36DC0", VA = "0x188D387C0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public RestoreOptionTypes ZZEFJYISERN
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0xB02440", Offset = "0xB00A40", VA = "0x180B02440", Slot = "10")]
				get
				{
					return default(RestoreOptionTypes);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2203B40", Offset = "0x2202140", VA = "0x182203B40")]
			public VSHKAYINKIJ(NJHMYSMXXYI a, PlatformType b, DeviceClass c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8D386D0", Offset = "0x8D36CD0", VA = "0x188D386D0", Slot = "9")]
			[AsyncStateMachine(typeof(<Restore>d__14))]
			public Task<EARYEWOAMEK> HYVHFZBJPSC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8D385B0", Offset = "0x8D36BB0", VA = "0x188D385B0", Slot = "11")]
			public bool Equals(QSIXHZNRTBA other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8D38500", Offset = "0x8D36B00", VA = "0x188D38500", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8D388A0", Offset = "0x8D36EA0", VA = "0x188D388A0")]
			private bool QLDQQTOJNOE(VSHKAYINKIJ a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8D38650", Offset = "0x8D36C50", VA = "0x188D38650", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private sealed class GRJZAGRCVCA : QSIXHZNRTBA, IEquatable<QSIXHZNRTBA>
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
				public AsyncTaskMethodBuilder<EARYEWOAMEK> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				private TaskAwaiter<EARYEWOAMEK> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x8D30990", Offset = "0x8D2EF90", VA = "0x188D30990", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x8D30EB0", Offset = "0x8D2F4B0", VA = "0x188D30EB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly Account ESEXRVTSCHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private readonly PlatformType YNFIZNGEPAW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private readonly DeviceClass BMAIQVUKXKF;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public int AJCGFULBSHO
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x8D1A420", Offset = "0x8D18A20", VA = "0x188D1A420", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			[NotNull]
			public Account HVTLGLMHAON
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private DateTime LXCFRDDLPXL
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "6")]
				get
				{
					return default(DateTime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public PlatformType? PYDTCMFJTNH
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x8D1A3D0", Offset = "0x8D189D0", VA = "0x188D1A3D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public DeviceClass? YNJZEUFTZTO
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x8D1A380", Offset = "0x8D18980", VA = "0x188D1A380", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public RestoreOptionTypes ZZEFJYISERN
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "10")]
				get
				{
					return default(RestoreOptionTypes);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x2203B40", Offset = "0x2202140", VA = "0x182203B40")]
			public GRJZAGRCVCA(Account a, PlatformType b, DeviceClass c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A2B0", Offset = "0x8D188B0", VA = "0x188D1A2B0", Slot = "9")]
			[AsyncStateMachine(typeof(<Restore>d__14))]
			public Task<EARYEWOAMEK> HYVHFZBJPSC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A1B0", Offset = "0x8D187B0", VA = "0x188D1A1B0", Slot = "11")]
			public bool Equals(QSIXHZNRTBA other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A130", Offset = "0x8D18730", VA = "0x188D1A130", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A220", Offset = "0x8D18820", VA = "0x188D1A220", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A440", Offset = "0x8D18A40", VA = "0x188D1A440")]
			private bool QLDQQTOJNOE(GRJZAGRCVCA a)
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
			public TTSAMIBGSYZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private TaskAwaiter<IReadOnlyList<Account>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8D27920", Offset = "0x8D25F20", VA = "0x188D27920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8D282A0", Offset = "0x8D268A0", VA = "0x188D282A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<IList<QSIXHZNRTBA>> <>t__builder;

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
			public TTSAMIBGSYZ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8D2ECC0", Offset = "0x8D2D2C0", VA = "0x188D2ECC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8D2FB00", Offset = "0x8D2E100", VA = "0x188D2FB00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly BJYGVRYEECX SWVGBUUMBSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly RWMACKNQYZX CQJSDGRUIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly KWATABQIYOJ YKEHBHKBHUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly MHKRYWDBQXB<(long, long), IReadOnlyList<SubRoomDataSaveDTO>> DHGDPWXNFQH;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8D265F0", Offset = "0x8D24BF0", VA = "0x188D265F0")]
		[UnityEngine.Scripting.Preserve]
		public TTSAMIBGSYZ([Inject(null)] RWMACKNQYZX roomHistoryProvider, [Inject(null)] KWATABQIYOJ roomAutosaveService, [Inject(null)] BJYGVRYEECX platformAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8D264A0", Offset = "0x8D24AA0", VA = "0x188D264A0")]
		[AsyncStateMachine(typeof(<GetOrderedRestoreOptions>d__5))]
		public Task<IList<QSIXHZNRTBA>> XFNVXKKKILD(long a, long b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8D26300", Offset = "0x8D24900", VA = "0x188D26300")]
		private bool RUXSSBXCXFG(DateTime? a, long b, long c, [Out] NJHMYSMXXYI d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8D261F0", Offset = "0x8D247F0", VA = "0x188D261F0")]
		[AsyncStateMachine(typeof(<CombineHistoryWithAccounts>d__7))]
		private Task<IReadOnlyList<(int, Account, SubRoomDataSaveDTO)>> QLSGBSECGUX(IReadOnlyList<SubRoomDataSaveDTO> a)
		{
			return null;
		}
	}
}
namespace AutoSaves
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface KWATABQIYOJ
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<NJHMYSMXXYI> XJHPRHAENPX;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ZSFEVTGEGHQ(long a, long b, RoomSerializedData c, AutosaveType d);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool LLTIQZMJMPE(long a, long b, [Out] NJHMYSMXXYI c);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool DHYXDHRMJHL(long a, long b, AutosaveType c, [Out] NJHMYSMXXYI d);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void WQJSZYUEZTK(long a, long b);
	}
}
namespace RecRoom.RoomLoading
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal interface FCNDFENYFYI : JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool ZANERWONFZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		Task PZZNOPHSOPY
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OHTKIRBRATH(Task a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal interface DIBPULMATLA : JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<EARYEWOAMEK> RequestRestoreAutosave(NJHMYSMXXYI autosaveRecordInfo);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task VKSOUGJPJSU(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal interface FTYIAWFEMJP : JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		VDQCZZZDVQV VDQCZZZDVQV
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ERKVRSXRYYI();

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UIAUITIQVYW();
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal interface JZTTLQQFTLE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(NIJQVUPMTTA roomManager);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal interface LBYYQBWWZWZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		TimeSpan EOQOCSZSBOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		TimeSpan XJYGQKZTYKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		TimeSpan HTQMKHTYEMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		TimeSpan GCLFNVEUKIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool THJGWPQUOWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool RBCQTYZTVHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool LJOBCKHTQJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		int ZAQVQMUUUZK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool XMIGJGJKZBR
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool JLKMMNFENEY
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool ZLNOUDOBKFO
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
		[Cpp2IlInjected.Address(RVA = "0x8D1F4B0", Offset = "0x8D1DAB0", VA = "0x188D1F4B0")]
		public RoomEvent(long superRoomId, long subRoomId, RoomEventType type, [CanBeNull] Exception eventException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F460", Offset = "0x8D1DA60", VA = "0x188D1F460")]
		public static RoomEvent From(RoomInstance room, RoomEventType type, [Optional] Exception eventException)
		{
			return default(RoomEvent);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void RoomEventHandler(RoomEvent roomEvent);
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal interface KBAJLOBLNBY : JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event RoomEventHandler JLYNMNCKNPA;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event RoomEventHandler EBVAOVWBLZQ;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event RoomEventHandler AIOQZMMRWIY;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<RequestOperationType, bool> ASFXNJWPEUO;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void AINFLVIDTKC(RoomEvent a);

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void GXIBKVNULUK(RoomEvent a);

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void PFDBDZGOKVO(RoomEvent a);

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void XXEHFZQGMSK(RequestOperationType a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal interface ROJOGVWMYHA : JZTTLQQFTLE, IDisposable, UEKNYOFIAKP
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool EQKDWIJQURI
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PWWACFKVPQS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal interface LCVPVCCAVNQ : JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		TaskStatus MYSSRGMCGJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task JoinRoomInstance(RoomInstance targetInstance, VAIYLWQXDVQ customRoomLoadPayload, CancellationToken externalToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class SSXJYVZJXTC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8D25D10", Offset = "0x8D24310", VA = "0x188D25D10")]
		public static bool AVYPGIHFTKI(this LCVPVCCAVNQ a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate Task InLoadedRoomTaskBuilder(CancellationToken token, int roomTotalVersion, AccountRoleType localPlayerAccountRoleType);
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal interface BYXYINOYSGX : JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ANNZNRHFJRB(InLoadedRoomTaskBuilder a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface NIJQVUPMTTA : EUHMRSURXFV, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		CancellationToken FUINONMOAPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		KUXAUVMITFU WXXFAUTLLAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		LRJLKNGLINT NVPECQVZKQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		GGJMWGKBHJH OOUGPDUSRBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		TPICXMNKDPD TUDUSUBOTJK
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		XNTVLDKBPBW RFQAGKRZMCD
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		XYQALRWHLAK WMUJYGELNHP
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		FXIAJRDWWMG LXJMAGNWWUF
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		TGHUEWOZHWI TGHUEWOZHWI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		FCNDFENYFYI SIAGGFHISOL
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		DIBPULMATLA PZPWMAXKEXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		KBAJLOBLNBY SGABYGXHOTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		ROJOGVWMYHA FTLBHRAOXPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		LCVPVCCAVNQ HJOQDRIAEWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		BYXYINOYSGX UXKPZODUVYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		AXARZMWEGGY GNSEVLBZGPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CNMXIHSKTKR LCBUPRCZEKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		MNIGGUQIBYU MRXBBPYNFLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		DMXHYWHBOPH JXWHBMXJIRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		JUUVKXCVYPT QOTIYKUXOJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		LHYKYYCLXTH SQYKRXVIZWM
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		XZQIURVFMKK TUKWAXGXUDP
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		AZGXKHQUXAQ DATYEDHHTCD
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		QVNBXSXIMUU MOMOIKWPQVP
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		JSTLAQOJGMG YZLENRIANUH
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		FTYIAWFEMJP PCBJLKIZGJM
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		LBYYQBWWZWZ TGOEJGVMXTM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		THVASARWEQV BDEMAFBSBBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		KWATABQIYOJ PGXCIQVRXGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		WAXSPKDXFTI HWRVLQNIQDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		DWBHSWWZGAF ZOAJTXPZIDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		SLGKQDZWFPJ MRDHVQONLIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		QUKMHXOZAMV GLAJFGKSNMW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		new bool TOSJWYOJFPL
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
		void QMGTBHZJRWE(VAIYLWQXDVQ a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal interface AXARZMWEGGY : JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PendingRequest Add(Guid operationId);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool Remove(Guid operationId);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool BHPHLKCNPQG(Guid a, Task b);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ISQHLSCJIWE(Guid a, EARYEWOAMEK b);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<(EARYEWOAMEK, Task)> MOPNYLZEBJP(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface GUBYKULAKSE : JZTTLQQFTLE, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal interface CNMXIHSKTKR : JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ACBYAPOEYTJ(NVFUFUSEYRF a);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QQSRLRGWPJA(NVFUFUSEYRF a);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RoomOperationType> ACNIVBSTODF(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal interface MNIGGUQIBYU : JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PendingRequest YTDWBMTVLFO(NVFUFUSEYRF a);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LJSRKRVAFIH(Guid a, Task b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal interface DMXHYWHBOPH : JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<EARYEWOAMEK> JXWHBMXJIRY(NVFUFUSEYRF a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface JUUVKXCVYPT : JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RoomLoadRequestPayload> BTXNAEGEAMO(StackTimer<string>.ERYHZSBUWXZ a, RoomInstance b, CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal interface XZQIURVFMKK : JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		EARYEWOAMEK TSKEADJNFVA(LRIABUPBGVB a);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task RequestSaveRoomToDisk(string path);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal interface LHYKYYCLXTH : JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<NVFUFUSEYRF> LSNAGKNRHBX(NVFUFUSEYRF a, ZTDIGAYZRAK b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<NVFUFUSEYRF> CSEHBPHJQMD(CancellationToken a, ZTDIGAYZRAK b);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TRMFSAPCCPK MJGXYAYSJKU(YARKOAWAUMF a, StackTimer<string>.ERYHZSBUWXZ b);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TRMFSAPCCPK BODVSIDAEGP(YARKOAWAUMF a, StackTimer<string>.ERYHZSBUWXZ b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface AZGXKHQUXAQ : JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		EARYEWOAMEK VSBHYHNOOLW(LRIABUPBGVB a, RoomOperationType b);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		EARYEWOAMEK TYGDUTTHEXZ(LRIABUPBGVB a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public interface MLMFYQLNVYI
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		const int XFSXVUCWCLG = 1000;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		IReadOnlyDictionary<Guid, RoomAssetDTO> WTFSOWQLPFU
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		Action XSRYJPITQMJ
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
		IReadOnlyList<Guid> JROZILDUYCZ();

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task RUDUBAAYIAZ([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task VETIVYPBLUX([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface QVNBXSXIMUU
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CDAKAHAQBHK(KFZZFBZWMFW a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CALDFYIJKZR(KFZZFBZWMFW a);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SSIFXRNYNMP(KFZZFBZWMFW a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CAAPWODILKN(KFZZFBZWMFW a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class KFZZFBZWMFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly RoomInstance GUYPTCKSKVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Dictionary<string, string> JZIXTSNSRXL;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public StackTimer<string> OJZFCAVCNIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public KFZZFBZWMFW(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8D1AE00", Offset = "0x8D19400", VA = "0x188D1AE00")]
		public KFZZFBZWMFW OISIMQELGRO(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8D1AED0", Offset = "0x8D194D0", VA = "0x188D1AED0")]
		public bool ZKBYQDEAXAE([Out] IEnumerable<KeyValuePair<string, string>> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7C7E3F0", Offset = "0x7C7C9F0", VA = "0x187C7E3F0")]
		public KFZZFBZWMFW QIQDGGWMRPX(StackTimer<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface THVASARWEQV
	{
		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		bool PXPTTOCDMPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		string FJTURKHWYDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool XXMIJGKPGHS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CNPMLGXSWHK();

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ZFJSMTGXQWR OWLBCNXHHVT(long a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		GPORBEJBVKL<FilenameWithHash, SuperRoomData> CTMEGKHNIOZ(long a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		GPORBEJBVKL<FilenameWithHash, PersistedRoomData> JFMNOQMJOID(long a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		GPORBEJBVKL<long, UFGPJUQJOWM> NVETBQYDRHP();

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<IReadOnlyCollection<BakedUnitySubAssetDTO>> ZQUHUUFOSQF(long a, IReadOnlyCollection<BakedUnitySubAssetDTO> b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool KFJLIVUDYQS(long a, [Out] bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<bool> APKSSBDTLOQ(byte[] a, byte[] b, IReadOnlyCollection<Guid> c, CancellationToken d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface HWQFGVTKLKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RoomLoadRequestPayload Create(long superRoomId, long subRoomId, string studioSessionId);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RoomLoadRequestPayload Create(long superRoomId, long subRoomId, FilenameWithHash superRoomData, Guid? snapshotId, long subRoomDataSaveId, bool loadUsedCompatibility);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RoomLoadRequestPayload Create(SaveSubRoomResponseDTO saveSubRoomResponseDTO);

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		RoomLoadRequestPayload Create(RoomDetailsDTO superRoom, SubRoomDataSaveDTO subRoomSave);
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface EUHMRSURXFV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		bool AVYPGIHFTKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool GDJABJDPHBF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool TOSJWYOJFPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		HWQFGVTKLKB OVHOZNPDEGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		VAIYLWQXDVQ ITIBQIVIOIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event RoomEventHandler JLYNMNCKNPA;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event RoomEventHandler EBVAOVWBLZQ;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RoomEventHandler AIOQZMMRWIY;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<RequestOperationType, bool> ASFXNJWPEUO;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void PWWACFKVPQS();

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		GLVGLZIHBMB JDGGUHWSSBR();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "13")]
		GYJHUCWYCEK SCCHBCUXTAX();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Task UYAIWDXTLDZ(int a, RoomSaveRequestPayload b, Func<RoomSerializedData, RoomSerializedData> c);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task<EARYEWOAMEK> RequestRestoreAutosave(NJHMYSMXXYI autosaveRecord);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task VKSOUGJPJSU(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface XNTVLDKBPBW
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		bool YXYARLVHKPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		bool ZNZIPOTOOHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		Guid? IDLZYMCBKIU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JYQXAVKCTEN(Scene a);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task WLWYTZFQKCL(MLACGLUPKXC a, IReadOnlyList<MLACGLUPKXC> b, IReadOnlyList<MLACGLUPKXC> c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void VKRTKTPVLHK(Guid a, IReadOnlyList<Guid> b, UnitySubAssetKind c, [Optional] object d);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task DMZBDFDKPKM(IReadOnlyList<Guid> a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		JSCJRQBGZIO KMIXIOGYCUG();

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task GPZGGZNKPEX();

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void GOJEIFQSHBI(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task UTQDBSYRXPN();
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface TPICXMNKDPD
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		KEWSLRECSSV VXTOLEXPLIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		bool RWYCPNUZGYS
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		bool MDDVHJZKJCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		bool LFYWJIJYNVA
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		bool YSJUEVSTYOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		int YSBEPXOOUKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		bool GLEAKZSTAQA
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(Slot = "50")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		bool LHSEXAYYTAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(Slot = "58")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		int PCVPBXAXHPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "59")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		int PDLJTRIPJXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(Slot = "60")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		bool BEMCMFULFEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(Slot = "61")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		bool QQYFAPKENCS
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "66")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		bool QQSYDIQHDRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "67")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		float OFCYNLALGFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "70")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action<float> YNFKVMMHSEF;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		KUXAUVMITFU BGXYRHMWQGW(KUXAUVMITFU a);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NNUCYKWSQIV(KUXAUVMITFU a);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SICWAOFWYZR();

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task ShowLoadingScreen(StackTimer<string>.ERYHZSBUWXZ loadingScreenScope, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void BVKGWFCSGPV(float a);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void HACVKJPLKBU(string a);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IReadOnlyList<MZFDYAVRXCT> KQPFJEDVLDI();

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IDisposable OMHETRSAPFI(object a, MZFDYAVRXCT b);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "10")]
		IReadOnlyList<EmptySceneHandler> JGSUVYCLEFA();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "11")]
		SuperRoomData BQOREBQBAZQ(IEnumerable<UMNTAHYOPJM> a);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void AMWMGQCZWVI(int a);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task GOSKUIZTFLD();

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void YUNKVQGYAIF();

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool NMHDLIUWXUG();

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		Task BAETHYQRZWX(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task FVXGOCMWXFP(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "21")]
		Task<LoadRecoveryAutosaveResponse> NAKDMQXTNDV(DateTime a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Task<bool> BHEGNPGKRVM(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void OAIXVMCLDER(string a = "", float b = 3f);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "25")]
		RoomSerializedMetadata LSYNABJAFXS(RoomSaveOptions a, SerializeType b, PersistedRoomData c, IEnumerable<PersistenceView> d, CXLQYBJVKVP e);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void XOEXEUHFCCS(PersistedRoomData a);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void LUJXAHMRCRF(UMNTAHYOPJM a, [In] RoomSerializedMetadata metadata);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "28")]
		Task IITBLDVHFIZ(PersistedRoomData a, bool b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "29")]
		Task ZBXMVHCEQLW(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void BVCSASSBRGV(long a, long b, RoomDetailsDTO c, SubRoomDataSaveDTO d, RoomSerializedData e, RoomSaveRequestPayload? roomSaveRequestPayload, RoomSaveAnalyticsInfo? f);

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void CNFHUYHCXNY(long a, long b, RoomSaveAnalyticsInfo? c);

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void EHWCILVXIQZ(PersistenceView a);

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void COKZNQFOYMK(string a, RoomInstance b, RoomDTO c, [Optional] string? fallbackReason, [Optional] string? fallbackFailureReason, [Optional] string? subReason);

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool EUJQYDOANWC(PersistenceView a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		bool GEGFZNWHRWY(UMNTAHYOPJM a, DEPRECATED_RoomPersistenceVersion b, [Out] QKRWEEKVSVZ c);

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task CRMOAAXOSLC(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void ZSCNRIKXRTI();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "38")]
		IDisposable CSEGUFVQAUY();

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "39")]
		void LNSHYMJUQXY(PersistedRoomData a, DEPRECATED_RoomPersistenceVersion b);

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task<bool> RequestMasterSpawnNewLocalPlayer(LRJLKNGLINT networking, CancellationToken cancellationToken, StackTimer<string>.ERYHZSBUWXZ stackTimer);

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "41")]
		void ECOVPDEEYAJ(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task<SaveSubRoomResponseDTO> RHRLEYDVMAS(SaveSubRoomRequest a);

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task<RoomDetailsDTO> UCPUCEZOXNR(long a, bool b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<SubRoomDataSaveWithUnityAssetsDTO> QKEZSLIKEHK(long a, long b, long c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "45")]
		Task<SubRoomDataSaveDTO> YIKBEAKBSAT(long a, long b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task<RoomLoadDTO> FZEWGXBEFZV(long a, Guid b, long? c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "47")]
		GPORBEJBVKL<RoomLoadDTO, IEnumerable<RoomAssetData>> OLCWLQOAMAH();

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "48")]
		Task<RemoteRunDTO> KBVAZWOIVZQ(string a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "49")]
		Task<RemoteRunDTO> NNFMNRITHXJ(string a, long b, long c, Guid? d, Storage.UploadFileResponseDTO e, Storage.UploadFileResponseDTO f, int g);

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "51")]
		bool KFKCHGZLITT();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "52")]
		bool XZPCQGIHPSZ();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "53")]
		bool ENSFZVFNWTN(IEnumerable<QKRWEEKVSVZ> a);

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void BulkDestroy(List<GameObject> objectsToDestroy);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "55")]
		float YMZRYPUBVMK();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "56")]
		Task<bool> ARPTVFAELUU(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "57")]
		Task<Scene> JWVFBUBNFDG(string a, LoadSceneMode b, bool c, StackTimer<string>.ERYHZSBUWXZ d);

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "62")]
		void EnableDisableObjectModel(bool enabled);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "63")]
		void BeginLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void EndLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "65")]
		void PWABWCOULQW(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "71")]
		Task<Storage.UploadFileResponseDTO> MDMUHGQZHCH(byte[] a, Storage.FileType b, MimeType c, [Optional] IReadOnlyCollection<string>? referencedFilenames, [Optional] string? filenameOverride);

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "72")]
		void XYNGEBXUPNQ(RoomInstance a);

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "73")]
		Task FJWRJRPVLRB(StackTimer<string>.ERYHZSBUWXZ a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "74")]
		Task TriggerMClusterManager(StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "75")]
		Task TriggerScalabilityManager(StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "76")]
		Task TriggerClusterLodManager(StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "77")]
		IDisposable WFIOPUQJKYM();

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "78")]
		OFIREKWSVXS THSJMEFMSTR();

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "79")]
		Task HideLoadingScreen(CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface OFIREKWSVXS
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task QRTIJAHWHOK(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600014C")]
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
	public interface KEWSLRECSSV
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		RoomInstance QLKKXRREVAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		RoomDetailsDTO YFHFIOAYXFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		SubRoomDTO PGSDRNFJSUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		bool JVMFTWYCRMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		bool ZAZNAHDDRYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		int FOKGJMKBSJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action UIUNAUBZSYT;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<int> VESISJZTTDC;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void MWVHTUWDTJJ();

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<Matchmaking.ServerConnectionInfoDTO> GetServerConnectionInfo(long roomInstanceId, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<MatchmakingErrorCode> IXBXXPFZSHM(RoomInstance a, [Optional] VAIYLWQXDVQ b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task<MatchmakingErrorCode> LTRCBRDYRJG();

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Task EHLYYTHHVAJ();

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		(RoomInstance, VAIYLWQXDVQ) QWOEZNOPFZK();

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		PlayerPresence IOAVGXFAUGH();

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void IVHRJYWLVHS(long a);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void VVIGJKTRIUJ(RoomInstance a, Matchmaking.GameJoinResult b, (int Major, int? Minor)? errorCode);
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface JSTLAQOJGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VGEEIPRXJCL([Out] IEnumerable<int> a);

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GMEQTJAIXUT(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TPRNRFXMCYA(Token a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface YVFQVUUMWWT
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string OORODVKGSYU(EARYEWOAMEK a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface PNTVQUBKEHD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TOVQIESRBJX(LCMFJDZYGDA.ValidateOperation a);

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CPHFVOBZHWU(LCMFJDZYGDA.ValidateOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface XYQALRWHLAK : PNTVQUBKEHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "0")]
		EARYEWOAMEK SFXGRMYYGYS(LRIABUPBGVB a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public interface FXIAJRDWWMG : PNTVQUBKEHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		EARYEWOAMEK TSKEADJNFVA(LRIABUPBGVB a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public interface ZFJSMTGXQWR
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<MNDWJRWMSJX, VMQHICPCFYT>> PFBKOFBUGTD(Guid? a, IReadOnlyCollection<BakedUnitySubAssetDTO> b, IReadOnlyCollection<BakedUnitySubAssetDTO> c, AssetBundleLoadSource d, long? e, long? f, RecNet.Core.OnDownloadProgressDelegate g, CancellationToken h, bool i = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class MNDWJRWMSJX
	{
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public MLACGLUPKXC TZKKIQUUYVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public IReadOnlyList<MLACGLUPKXC> SZNIMAAYKWA
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public IReadOnlyList<MLACGLUPKXC> YEZLXXEJBVU
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xE38300", Offset = "0xE36900", VA = "0x180E38300")]
		public MNDWJRWMSJX(MLACGLUPKXC a, IReadOnlyList<MLACGLUPKXC> b, IReadOnlyList<MLACGLUPKXC> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface GPORBEJBVKL<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<ParseResult<b>, VMQHICPCFYT>> EAMICSOWRGQ(a a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal sealed class RoomManager : NIJQVUPMTTA, EUHMRSURXFV, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class TVGQGWWBGXG : IEnumerable<JZTTLQQFTLE>, IEnumerable, IEnumerator<JZTTLQQFTLE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private JZTTLQQFTLE MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public RoomManager CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			private JZTTLQQFTLE LAEPMKIGOMB
			{
				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xB597F0", Offset = "0xB57DF0", VA = "0x180B597F0")]
			[DebuggerHidden]
			public TVGQGWWBGXG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x8D267B0", Offset = "0x8D24DB0", VA = "0x188D267B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8D26B60", Offset = "0x8D25160", VA = "0x188D26B60", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x8D26710", Offset = "0x8D24D10", VA = "0x188D26710", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JZTTLQQFTLE> YNMTDYEKWHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8D26710", Offset = "0x8D24D10", VA = "0x188D26710", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
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
			public AsyncTaskMethodBuilder<EARYEWOAMEK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public RoomManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public NJHMYSMXXYI autosaveRecordInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private TaskAwaiter<EARYEWOAMEK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x8D2FE20", Offset = "0x8D2E420", VA = "0x188D2FE20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8D300A0", Offset = "0x8D2E6A0", VA = "0x188D300A0", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8D30110", Offset = "0x8D2E710", VA = "0x188D30110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8D30340", Offset = "0x8D2E940", VA = "0x188D30340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly CancellationTokenSource EBEDNPJSAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly KUXAUVMITFU container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool MFRVCTFDCZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private LogFlagsToken ZRDTFRKYICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private bool JXAVTSEPAWW;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public LRJLKNGLINT NVPECQVZKQC
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xAACAB0", Offset = "0xAAB0B0", VA = "0x180AACAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public GGJMWGKBHJH OOUGPDUSRBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB080", VA = "0x180AACA80", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAACAA0", Offset = "0xAAB0A0", VA = "0x180AACAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public TPICXMNKDPD TUDUSUBOTJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xAACD50", Offset = "0xAAB350", VA = "0x180AACD50", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB070", VA = "0x180AACA70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public XNTVLDKBPBW RFQAGKRZMCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xAACA50", Offset = "0xAAB050", VA = "0x180AACA50", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xAACD30", Offset = "0xAAB330", VA = "0x180AACD30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public XYQALRWHLAK WMUJYGELNHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB090", VA = "0x180AACA90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAACA60", Offset = "0xAAB060", VA = "0x180AACA60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public FXIAJRDWWMG LXJMAGNWWUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xAB4A90", Offset = "0xAB3090", VA = "0x180AB4A90", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAB50B0", Offset = "0xAB36B0", VA = "0x180AB50B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public HWQFGVTKLKB OVHOZNPDEGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xAB49F0", Offset = "0xAB2FF0", VA = "0x180AB49F0", Slot = "54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xAB50A0", Offset = "0xAB36A0", VA = "0x180AB50A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public TGHUEWOZHWI TGHUEWOZHWI
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xAB4960", Offset = "0xAB2F60", VA = "0x180AB4960", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xAB50D0", Offset = "0xAB36D0", VA = "0x180AB50D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public FCNDFENYFYI SIAGGFHISOL
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xAD5EB0", Offset = "0xAD44B0", VA = "0x180AD5EB0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xBD1340", Offset = "0xBCF940", VA = "0x180BD1340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public DIBPULMATLA PZPWMAXKEXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xAB4A30", Offset = "0xAB3030", VA = "0x180AB4A30", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAB4A50", Offset = "0xAB3050", VA = "0x180AB4A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public KBAJLOBLNBY SGABYGXHOTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xBD1370", Offset = "0xBCF970", VA = "0x180BD1370", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xBD1270", Offset = "0xBCF870", VA = "0x180BD1270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public ROJOGVWMYHA FTLBHRAOXPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAA9E40", Offset = "0xAA8440", VA = "0x180AA9E40", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAAA150", Offset = "0xAA8750", VA = "0x180AAA150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public LCVPVCCAVNQ HJOQDRIAEWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xBD1290", Offset = "0xBCF890", VA = "0x180BD1290", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xBD1390", Offset = "0xBCF990", VA = "0x180BD1390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public BYXYINOYSGX UXKPZODUVYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xF66510", Offset = "0xF64B10", VA = "0x180F66510", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xCB9290", Offset = "0xCB7890", VA = "0x180CB9290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public AXARZMWEGGY GNSEVLBZGPX
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xBD1240", Offset = "0xBCF840", VA = "0x180BD1240", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xF4C980", Offset = "0xF4AF80", VA = "0x180F4C980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public GUBYKULAKSE PKHPUEBAVWF
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xBD1670", Offset = "0xBCFC70", VA = "0x180BD1670", Slot = "60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xBD12A0", Offset = "0xBCF8A0", VA = "0x180BD12A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public CNMXIHSKTKR LCBUPRCZEKK
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xBD1360", Offset = "0xBCF960", VA = "0x180BD1360", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xC07180", Offset = "0xC05780", VA = "0x180C07180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public MNIGGUQIBYU MRXBBPYNFLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xAA9E90", Offset = "0xAA8490", VA = "0x180AA9E90", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xAA9E70", Offset = "0xAA8470", VA = "0x180AA9E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public DMXHYWHBOPH JXWHBMXJIRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xB0E990", Offset = "0xB0CF90", VA = "0x180B0E990", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xB99060", Offset = "0xB97660", VA = "0x180B99060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public JUUVKXCVYPT QOTIYKUXOJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xB10300", Offset = "0xB0E900", VA = "0x180B10300", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xB10E30", Offset = "0xB0F430", VA = "0x180B10E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public LHYKYYCLXTH SQYKRXVIZWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xB0E9A0", Offset = "0xB0CFA0", VA = "0x180B0E9A0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xB0E7E0", Offset = "0xB0CDE0", VA = "0x180B0E7E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public XZQIURVFMKK TUKWAXGXUDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xB95B50", Offset = "0xB94150", VA = "0x180B95B50", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xB95B00", Offset = "0xB94100", VA = "0x180B95B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public AZGXKHQUXAQ DATYEDHHTCD
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xB14AC0", Offset = "0xB130C0", VA = "0x180B14AC0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xB9D6C0", Offset = "0xB9BCC0", VA = "0x180B9D6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public QVNBXSXIMUU MOMOIKWPQVP
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xB102F0", Offset = "0xB0E8F0", VA = "0x180B102F0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xB10350", Offset = "0xB0E950", VA = "0x180B10350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public JSTLAQOJGMG YZLENRIANUH
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xB97D70", Offset = "0xB96370", VA = "0x180B97D70", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xB963E0", Offset = "0xB949E0", VA = "0x180B963E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public FTYIAWFEMJP PCBJLKIZGJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB10260", Offset = "0xB0E860", VA = "0x180B10260", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xB97260", Offset = "0xB95860", VA = "0x180B97260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public LBYYQBWWZWZ TGOEJGVMXTM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xB97E60", Offset = "0xB96460", VA = "0x180B97E60", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xB98070", Offset = "0xB96670", VA = "0x180B98070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public THVASARWEQV BDEMAFBSBBM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xC35AE0", Offset = "0xC340E0", VA = "0x180C35AE0", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xC2E5A0", Offset = "0xC2CBA0", VA = "0x180C2E5A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public KWATABQIYOJ PGXCIQVRXGM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xCB11E0", Offset = "0xCAF7E0", VA = "0x180CB11E0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public WAXSPKDXFTI HWRVLQNIQDL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xBF70D0", Offset = "0xBF56D0", VA = "0x180BF70D0", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public DWBHSWWZGAF ZOAJTXPZIDH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xBF6D80", Offset = "0xBF5380", VA = "0x180BF6D80", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public SLGKQDZWFPJ MRDHVQONLIA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xCAFF30", Offset = "0xCAE530", VA = "0x180CAFF30", Slot = "35")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public QUKMHXOZAMV GLAJFGKSNMW
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xCAFF40", Offset = "0xCAE540", VA = "0x180CAFF40", Slot = "36")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public VAIYLWQXDVQ ITIBQIVIOIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xCAFEA0", Offset = "0xCAE4A0", VA = "0x180CAFEA0", Slot = "58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xCB7AA0", Offset = "0xCB60A0", VA = "0x180CB7AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private bool UQAPKBLHLER
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x8D25800", Offset = "0x8D23E00", VA = "0x188D25800", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private bool ZHMWWJLXMLO
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x8D24AE0", Offset = "0x8D230E0", VA = "0x188D24AE0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool AICWYZZFRKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1CA4820", Offset = "0x1CA2E20", VA = "0x181CA4820", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private CancellationToken MMFWDQGNRXE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x8D257E0", Offset = "0x8D23DE0", VA = "0x188D257E0", Slot = "4")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private KUXAUVMITFU JFUMPTKQRML
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private bool CGBDWQZNGNT
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1CA4820", Offset = "0x1CA2E20", VA = "0x181CA4820", Slot = "37")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1CA9EE0", Offset = "0x1CA84E0", VA = "0x181CA9EE0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		private event RoomEventHandler QSXKIKABEXL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8D25040", Offset = "0x8D23640", VA = "0x188D25040", Slot = "40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8D24A80", Offset = "0x8D23080", VA = "0x188D24A80", Slot = "41")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event RoomEventHandler YFVQEATYGZH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8D25170", Offset = "0x8D23770", VA = "0x188D25170", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8D251D0", Offset = "0x8D237D0", VA = "0x188D251D0", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		private event RoomEventHandler IYICHQXOQRP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8D25780", Offset = "0x8D23D80", VA = "0x188D25780", Slot = "44")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8D24FE0", Offset = "0x8D235E0", VA = "0x188D24FE0", Slot = "45")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		private event Action<RequestOperationType, bool> UENJKLEHXKZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x8D24E60", Offset = "0x8D23460", VA = "0x188D24E60", Slot = "46")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x8D25520", Offset = "0x8D23B20", VA = "0x188D25520", Slot = "47")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xCB7AA0", Offset = "0xCB60A0", VA = "0x180CB7AA0", Slot = "39")]
		public void QMGTBHZJRWE(VAIYLWQXDVQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8D25860", Offset = "0x8D23E60", VA = "0x188D25860")]
		[UnityEngine.Scripting.Preserve]
		internal RoomManager([Inject(null)] KUXAUVMITFU container, [Inject(null)] LRJLKNGLINT networking, [Inject(null)] GGJMWGKBHJH photonClient, [Inject(null)] TPICXMNKDPD callbacks, [Inject(null)] XNTVLDKBPBW assetBundleManager, [Inject(null)] XYQALRWHLAK roomReloadValidation, [Inject(null)] FXIAJRDWWMG roomSaveValidation, [Inject(null)] TGHUEWOZHWI debugRoomLoadInfo, [Inject(null)] FCNDFENYFYI activeTask, [Inject(null)] DIBPULMATLA autosaves, [Inject(null)] KBAJLOBLNBY events, [Inject(null)] ROJOGVWMYHA fallbacks, [Inject(null)] LCVPVCCAVNQ initialRoomLoad, [Inject(null)] BYXYINOYSGX inRoomTasks, [Inject(null)] AXARZMWEGGY pendingRequests, [Inject(null)] GUBYKULAKSE presenceUpdates, [Inject(null)] CNMXIHSKTKR receiveOperation, [Inject(null)] MNIGGUQIBYU requestHandler, [Inject(null)] DMXHYWHBOPH requestOperation, [Inject(null)] JUUVKXCVYPT roomLoadRequest, [Inject(null)] XZQIURVFMKK save, [Inject(null)] LHYKYYCLXTH synchronization, [Inject(null)] AZGXKHQUXAQ validation, [Inject(null)] QVNBXSXIMUU roomJoinAnalytics, [Inject(null)] JSTLAQOJGMG playerSynchronization, [Inject(null)] LBYYQBWWZWZ config, [Inject(null)] THVASARWEQV roomLoadDataProviderOverride, [Inject(null)] KWATABQIYOJ autosaveService, [Inject(null)] WAXSPKDXFTI cameraFade, [Inject(null)] DWBHSWWZGAF errorRegistry, [Inject(null)] SLGKQDZWFPJ onlineRestrictions, [Inject(null)] QUKMHXOZAMV preEmptySceneHandler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8D24EC0", Offset = "0x8D234C0", VA = "0x188D24EC0")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8D24B60", Offset = "0x8D23160", VA = "0x188D24B60", Slot = "59")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8D250A0", Offset = "0x8D236A0", VA = "0x188D250A0", Slot = "51")]
		private void PFVHMFGKNQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8D24F60", Offset = "0x8D23560", VA = "0x188D24F60", Slot = "52")]
		private GLVGLZIHBMB JULQTUUEURM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8D24DE0", Offset = "0x8D233E0", VA = "0x188D24DE0", Slot = "53")]
		private GYJHUCWYCEK FGLHKVFUNPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8D25230", Offset = "0x8D23830", VA = "0x188D25230", Slot = "55")]
		public Task UYAIWDXTLDZ(int a, RoomSaveRequestPayload b, Func<RoomSerializedData, RoomSerializedData> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8D24CF0", Offset = "0x8D232F0", VA = "0x188D24CF0")]
		private PTTBGPAAMAY EWCFBZFDIDH(int a, RoomSaveRequestPayload b, Func<RoomSerializedData, RoomSerializedData> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8D25670", Offset = "0x8D23C70", VA = "0x188D25670", Slot = "56")]
		[AsyncStateMachine(typeof(<RecRoom-RoomLoading-IRoomManager-RequestRestoreAutosave>d__165))]
		private Task<EARYEWOAMEK> WZEJFTEGIWY(NJHMYSMXXYI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8D25580", Offset = "0x8D23B80", VA = "0x188D25580", Slot = "57")]
		[AsyncStateMachine(typeof(<RecRoom-RoomLoading-IRoomManager-RunRecoveryAutosave>d__166))]
		private Task VYEPUZBNMDP(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8D250F0", Offset = "0x8D236F0", VA = "0x188D250F0")]
		[IteratorStateMachine(typeof(TVGQGWWBGXG))]
		private IEnumerable<JZTTLQQFTLE> RZRBIQEXMUQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8D24A20", Offset = "0x8D23020", VA = "0x188D24A20")]
		[CompilerGenerated]
		private void ASJNIHYLELM(JZTTLQQFTLE a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class CameraFadeTimeoutException : TimeoutException
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1B46E70", Offset = "0x1B45470", VA = "0x181B46E70")]
		public CameraFadeTimeoutException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal class FallbackToBootScene : DUPNPOGBOFO
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
			public AsyncTaskMethodBuilder<DUPNPOGBOFO.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public HashSet<UEKNYOFIAKP.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public FallbackToBootScene <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8D33F30", Offset = "0x8D32530", VA = "0x188D33F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8D34230", Offset = "0x8D32830", VA = "0x188D34230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly NIJQVUPMTTA VHJCBTPFZBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly TPICXMNKDPD FZDXDPPJXPG;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		private string UIXIAAISBHV
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8D19430", Offset = "0x8D17A30", VA = "0x188D19430", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xAAC450", Offset = "0xAAAA50", VA = "0x180AAC450")]
		public FallbackToBootScene(NIJQVUPMTTA roomManager, TPICXMNKDPD callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8D19460", Offset = "0x8D17A60", VA = "0x188D19460", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__6))]
		public Task<DUPNPOGBOFO.Result> ZEMLTIQWPVV(HashSet<UEKNYOFIAKP.Reason> a, CancellationToken b, UEKNYOFIAKP.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal class FallbackToOfflineDormRoom : NFGEGJHIOIV, DUPNPOGBOFO
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
			public AsyncTaskMethodBuilder<DUPNPOGBOFO.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public FallbackToOfflineDormRoom <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public HashSet<UEKNYOFIAKP.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public UEKNYOFIAKP.Reason reason;

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
			private TaskAwaiter<DUPNPOGBOFO.Result> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8D32820", Offset = "0x8D30E20", VA = "0x188D32820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8D33E50", Offset = "0x8D32450", VA = "0x188D33E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly XUVMDMZQVTP ISSBWSUMWLK;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		private string UIXIAAISBHV
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x8D195F0", Offset = "0x8D17BF0", VA = "0x188D195F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8D197F0", Offset = "0x8D17DF0", VA = "0x188D197F0")]
		public FallbackToOfflineDormRoom([Inject(null)] NIJQVUPMTTA roomManager, [Inject(null)] TPICXMNKDPD callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8D19620", Offset = "0x8D17C20", VA = "0x188D19620", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__5))]
		public Task<DUPNPOGBOFO.Result> ZEMLTIQWPVV(HashSet<UEKNYOFIAKP.Reason> a, CancellationToken b, UEKNYOFIAKP.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal class FallbackToOfflineMultiplayerOrientationSubRoom : NFGEGJHIOIV, DUPNPOGBOFO
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
			public AsyncTaskMethodBuilder<DUPNPOGBOFO.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public FallbackToOfflineMultiplayerOrientationSubRoom <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public HashSet<UEKNYOFIAKP.Reason> fallbackTriggersToIgnore;

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
			private TaskAwaiter<DUPNPOGBOFO.Result> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8D31DC0", Offset = "0x8D303C0", VA = "0x188D31DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x8D327B0", Offset = "0x8D30DB0", VA = "0x188D327B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		private string UIXIAAISBHV
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8D198C0", Offset = "0x8D17EC0", VA = "0x188D198C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xAAC450", Offset = "0xAAAA50", VA = "0x180AAC450")]
		public FallbackToOfflineMultiplayerOrientationSubRoom(NIJQVUPMTTA roomManager, TPICXMNKDPD callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8D198F0", Offset = "0x8D17EF0", VA = "0x188D198F0", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__4))]
		public Task<DUPNPOGBOFO.Result> ZEMLTIQWPVV(HashSet<UEKNYOFIAKP.Reason> a, CancellationToken b, UEKNYOFIAKP.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal class FallbackToOnlineDormRoom : NFGEGJHIOIV, DUPNPOGBOFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class XMEHEWGCGRP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public MatchmakingErrorCode RYUIPMSDBQT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public RoomInstance IOBPWBMSJDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public long FWGKXUBSXUY;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public XMEHEWGCGRP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8D38BF0", Offset = "0x8D371F0", VA = "0x188D38BF0")]
			internal object BVLMHKJVSGP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8D38B30", Offset = "0x8D37130", VA = "0x188D38B30")]
			internal object BVGFKDPYIVG()
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
			public AsyncTaskMethodBuilder<DUPNPOGBOFO.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public FallbackToOnlineDormRoom <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public HashSet<UEKNYOFIAKP.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private XMEHEWGCGRP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public UEKNYOFIAKP.Reason reason;

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
			private TaskAwaiter<DUPNPOGBOFO.Result> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8D331F0", Offset = "0x8D317F0", VA = "0x188D331F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x8D33EC0", Offset = "0x8D324C0", VA = "0x188D33EC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly XUVMDMZQVTP ISSBWSUMWLK;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		private string UIXIAAISBHV
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8D19AC0", Offset = "0x8D180C0", VA = "0x188D19AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8D19CC0", Offset = "0x8D182C0", VA = "0x188D19CC0")]
		public FallbackToOnlineDormRoom([Inject(null)] NIJQVUPMTTA roomManager, [Inject(null)] TPICXMNKDPD callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8D19AF0", Offset = "0x8D180F0", VA = "0x188D19AF0", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__5))]
		public Task<DUPNPOGBOFO.Result> ZEMLTIQWPVV(HashSet<UEKNYOFIAKP.Reason> a, CancellationToken b, UEKNYOFIAKP.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal abstract class NFGEGJHIOIV
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
			public HashSet<UEKNYOFIAKP.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public NFGEGJHIOIV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private List<UEKNYOFIAKP.Reason> <newDisconnectTriggers>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x8D2E4C0", Offset = "0x8D2CAC0", VA = "0x188D2E4C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x8D2E9E0", Offset = "0x8D2CFE0", VA = "0x188D2E9E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		protected readonly NIJQVUPMTTA VHJCBTPFZBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		protected readonly TPICXMNKDPD FZDXDPPJXPG;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected KEWSLRECSSV VXTOLEXPLIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x8D1D1B0", Offset = "0x8D1B7B0", VA = "0x188D1D1B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC450", Offset = "0xAAAA50", VA = "0x180AAC450")]
		public NFGEGJHIOIV(NIJQVUPMTTA a, TPICXMNKDPD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D080", Offset = "0x8D1B680", VA = "0x188D1D080")]
		[AsyncStateMachine(typeof(<DisconnectFromRoomInstance>d__5))]
		protected Task DisconnectFromRoomInstance(Log log, HashSet<UEKNYOFIAKP.Reason> fallbackTriggersToIgnore, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class GKJMXJHLCSW
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class XIPYLIIUTHZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public string VJXCLDAGNTL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public NIJQVUPMTTA VHJCBTPFZBE;

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public XIPYLIIUTHZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x8D38A30", Offset = "0x8D37030", VA = "0x188D38A30")]
			internal object TOUKRDAROAY()
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
			public AsyncTaskMethodBuilder<DUPNPOGBOFO.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public TPICXMNKDPD callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private float <timeoutTime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x8D37CD0", Offset = "0x8D362D0", VA = "0x188D37CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x8D38050", Offset = "0x8D36650", VA = "0x188D38050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static readonly float KCTKDVSWRXO;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		internal static readonly HashSet<UEKNYOFIAKP.Reason> MPDCKJMRHYJ;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8D19D90", Offset = "0x8D18390", VA = "0x188D19D90")]
		[AsyncStateMachine(typeof(<WaitForPlayerToSpawn>d__2))]
		internal static Task<DUPNPOGBOFO.Result> GFQIIUDKKCD(TPICXMNKDPD a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8D19EA0", Offset = "0x8D184A0", VA = "0x188D19EA0")]
		internal static void QFEQMQCWWDI(NIJQVUPMTTA a, Log b, string c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal interface DUPNPOGBOFO
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public struct Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public bool success;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public UEKNYOFIAKP.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public Enum? subReason;

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x8D1F450", Offset = "0x8D1DA50", VA = "0x188D1F450")]
			public static Result Success()
			{
				return default(Result);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x8D1F420", Offset = "0x8D1DA20", VA = "0x188D1F420")]
			public static Result Failure(UEKNYOFIAKP.Reason reason, [Optional] Enum? subReason)
			{
				return default(Result);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		string FUBJEMEFIKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<Result> ZEMLTIQWPVV(HashSet<UEKNYOFIAKP.Reason> a, CancellationToken b, UEKNYOFIAKP.Reason c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal struct RestoreRecoveryAutosaveInRoomTask
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class XIPYLIIUTHZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public NIJQVUPMTTA TKPCNEHSYAX;

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public XIPYLIIUTHZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x8D389E0", Offset = "0x8D36FE0", VA = "0x188D389E0")]
			internal Task PLNGVHKFIDX(CancellationToken a, int b, AccountRoleType c)
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
			private NJHMYSMXXYI <autosaveInfo>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private TaskAwaiter<LoadRecoveryAutosaveResponse> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private TaskAwaiter<EARYEWOAMEK> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x8D342A0", Offset = "0x8D328A0", VA = "0x188D342A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x8D34830", Offset = "0x8D32E30", VA = "0x188D34830", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x8D380C0", Offset = "0x8D366C0", VA = "0x188D380C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x8D383D0", Offset = "0x8D369D0", VA = "0x188D383D0", Slot = "5")]
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
		private readonly NIJQVUPMTTA manager;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private LRJLKNGLINT NVPECQVZKQC
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x8D1EF30", Offset = "0x8D1D530", VA = "0x188D1EF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		private TPICXMNKDPD TUDUSUBOTJK
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x8D1F3D0", Offset = "0x8D1D9D0", VA = "0x188D1F3D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		private KEWSLRECSSV VXTOLEXPLIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x8D1EEB0", Offset = "0x8D1D4B0", VA = "0x188D1EEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private DIBPULMATLA PZPWMAXKEXV
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x8D1EC70", Offset = "0x8D1D270", VA = "0x188D1EC70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2B092C0", Offset = "0x2B078C0", VA = "0x182B092C0")]
		public RestoreRecoveryAutosaveInRoomTask(CancellationToken cancellationToken, NIJQVUPMTTA manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED90", Offset = "0x8D1D390", VA = "0x188D1ED90")]
		public static InLoadedRoomTaskBuilder PLZFGPLWDAN(NIJQVUPMTTA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8D1EF80", Offset = "0x8D1D580", VA = "0x188D1EF80")]
		[AsyncStateMachine(typeof(<Run>d__4))]
		public Task<bool> Run()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F1C0", Offset = "0x8D1D7C0", VA = "0x188D1F1C0")]
		private bool VLSIBZTXXVE([Out] NJHMYSMXXYI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ECC0", Offset = "0x8D1D2C0", VA = "0x188D1ECC0")]
		[AsyncStateMachine(typeof(<WaitUntilWatchMenuIsReady>d__6))]
		private Task HMRQOLQCNYY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F090", Offset = "0x8D1D690", VA = "0x188D1F090")]
		private Task<LoadRecoveryAutosaveResponse> TLZMOBXFFXD(NJHMYSMXXYI a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal struct PendingRequest : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly AXARZMWEGGY pendingRequests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private Task<(EARYEWOAMEK, Task)> MIOKXDHTHBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x8D1E120", Offset = "0x8D1C720", VA = "0x188D1E120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x51F21B0", Offset = "0x51F07B0", VA = "0x1851F21B0")]
		public PendingRequest(AXARZMWEGGY pendingRequests, Guid operationId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8D1E1F0", Offset = "0x8D1C7F0", VA = "0x188D1E1F0")]
		public TaskAwaiter<(EARYEWOAMEK, Task)> RKOJMYXYBOB()
		{
			return default(TaskAwaiter<(EARYEWOAMEK, Task)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x8D1E050", Offset = "0x8D1C650", VA = "0x188D1E050", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal struct PendingRequestData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly TaskCompletionSource<(EARYEWOAMEK, Task)> taskCompletion;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Task<(EARYEWOAMEK, Task)> MIOKXDHTHBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x8D1DD20", Offset = "0x8D1C320", VA = "0x188D1DD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8D1DEE0", Offset = "0x8D1C4E0", VA = "0x188D1DEE0")]
		public PendingRequestData(TimeSpan timeout)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8D1DE40", Offset = "0x8D1C440", VA = "0x188D1DE40")]
		public void ZYIEYZELEEB(Task a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8D1DC90", Offset = "0x8D1C290", VA = "0x188D1DC90")]
		public void HNWFPCNNKGB(EARYEWOAMEK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x8D1DDF0", Offset = "0x8D1C3F0", VA = "0x188D1DDF0")]
		public void YDWFUWNLKMT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8D1DD60", Offset = "0x8D1C360", VA = "0x188D1DD60")]
		internal void RTUBQFWRJHH(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class YUGTXJYGTZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8D38CA0", Offset = "0x8D372A0", VA = "0x188D38CA0")]
		public static RoomLoadRequestPayload AKGGXIUWIEM(this RoomLoadRequestPayload a, RoomDetailsDTO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8D38DD0", Offset = "0x8D373D0", VA = "0x188D38DD0")]
		public static RoomLoadRequestPayload IAHHLRZRJLS(this RoomLoadRequestPayload a, SubRoomDataSaveDTO b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal sealed class OVHOZNPDEGQ : HWQFGVTKLKB
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class XMEHEWGCGRP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public SubRoomDataSaveDTO FYDVYATIPWE;

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public XMEHEWGCGRP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x8D38C70", Offset = "0x8D37270", VA = "0x188D38C70")]
			internal bool EQBQAMNNNHQ(SubRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly LBYYQBWWZWZ QIGQVWAVODJ;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public OVHOZNPDEGQ(LBYYQBWWZWZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D7C0", Offset = "0x8D1BDC0", VA = "0x188D1D7C0", Slot = "4")]
		public RoomLoadRequestPayload Create(long superRoomId, long subRoomId, string studioSessionId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D280", Offset = "0x8D1B880", VA = "0x188D1D280", Slot = "5")]
		public RoomLoadRequestPayload Create(long superRoomId, long subRoomId, FilenameWithHash superRoomData, Guid? snapshotId, long subRoomDataSaveId, bool loadUsedCompatibility)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D650", Offset = "0x8D1BC50", VA = "0x188D1D650", Slot = "6")]
		public RoomLoadRequestPayload Create(SaveSubRoomResponseDTO saveSubRoomResponseDTO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D3E0", Offset = "0x8D1B9E0", VA = "0x188D1D3E0", Slot = "7")]
		public RoomLoadRequestPayload Create(RoomDetailsDTO superRoom, SubRoomDataSaveDTO subRoomSave)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D850", Offset = "0x8D1BE50", VA = "0x188D1D850")]
		private Guid? VFUTOPZQZUA(RoomDetailsDTO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerActiveTask : FCNDFENYFYI, JZTTLQQFTLE, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x8D30F20", Offset = "0x8D2F520", VA = "0x188D30F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x8D31580", Offset = "0x8D2FB80", VA = "0x188D31580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly Token DQHNRVFVCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private string AAQJEIJKCNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private Task VMMQTBGSALW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private NIJQVUPMTTA VHJCBTPFZBE;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public bool ZANERWONFZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x8D1F750", Offset = "0x8D1DD50", VA = "0x188D1F750", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public Task PZZNOPHSOPY
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x8D1F780", Offset = "0x8D1DD80", VA = "0x188D1F780", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690", Slot = "7")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F5F0", Offset = "0x8D1DBF0", VA = "0x188D1F5F0", Slot = "6")]
		public void OHTKIRBRATH(Task a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F4D0", Offset = "0x8D1DAD0", VA = "0x188D1F4D0")]
		[AsyncStateMachine(typeof(<RunAndSetCurrentTask>d__11))]
		private Task BSXXOXIYJBY(Task a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F810", Offset = "0x8D1DE10", VA = "0x188D1F810")]
		public RoomManagerActiveTask()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	internal class TSTXLPAHWDW : FTYIAWFEMJP, JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool LFMIOHWKCXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private VDQCZZZDVQV FEPFHQEIDXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private LRJLKNGLINT IXSJEENOFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private LBYYQBWWZWZ PRCZNZUSLCW;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public VDQCZZZDVQV VDQCZZZDVQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x8D26180", Offset = "0x8D24780", VA = "0x188D26180", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8D25F50", Offset = "0x8D24550", VA = "0x188D25F50", Slot = "7")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8D25DA0", Offset = "0x8D243A0", VA = "0x188D25DA0", Slot = "5")]
		public void ERKVRSXRYYI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8D25D60", Offset = "0x8D24360", VA = "0x188D25D60", Slot = "6")]
		public void UIAUITIQVYW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8D260C0", Offset = "0x8D246C0", VA = "0x188D260C0")]
		private Task QRHBEKQRHZD(DisconnectCause a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8D25D60", Offset = "0x8D24360", VA = "0x188D25D60", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public TSTXLPAHWDW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal class QBUHVHCNBKE : LBYYQBWWZWZ
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		private class Config<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly SGWOUGLKKLH YSURAZNUYBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly string PYMENAUFSNV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly T SHIETRXPSKW;

			[Cpp2IlInjected.Token(Token = "0x170000B4")]
			public T HOYELULZOXT
			{
				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0xAFA810", Offset = "0xAF8E10", VA = "0x180AFA810")]
				[CompilerGenerated]
				get
				{
					return (T)null;
				}
				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0xBE49C0", Offset = "0xBE2FC0", VA = "0x180BE49C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x42F1420", Offset = "0x42EFA20", VA = "0x1842F1420")]
			public Config(SGWOUGLKKLH gameConfigsProvider, string key, T defaultValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x42F0A20", Offset = "0x42EF020", VA = "0x1842F0A20")]
			private void YCBLWUTZWRS()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly SGWOUGLKKLH YSURAZNUYBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly Config<TimeSpan> GUZMMXNUKFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly Config<TimeSpan> ICWZOVSAVIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly Config<TimeSpan> JROVWPFFMPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly Config<TimeSpan> JUHJFEFZGFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly Config<bool> ONVDSYBNTSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly Config<bool> PUYFKVMIIBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Config<bool> KMNGJJAKPNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Config<int> JUAWWZBJNOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private readonly Config<bool> MPYRMMGELVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly Config<bool> VVYFKIISVLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly Config<PlatformMask> ZZBAXMLQYBX;

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public TimeSpan EOQOCSZSBOT
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8D1E440", Offset = "0x8D1CA40", VA = "0x188D1E440", Slot = "4")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public TimeSpan XJYGQKZTYKL
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x8D1E480", Offset = "0x8D1CA80", VA = "0x188D1E480", Slot = "5")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public TimeSpan HTQMKHTYEMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x8D1E400", Offset = "0x8D1CA00", VA = "0x188D1E400", Slot = "6")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public TimeSpan GCLFNVEUKIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x8D1E3C0", Offset = "0x8D1C9C0", VA = "0x188D1E3C0", Slot = "7")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool THJGWPQUOWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x8D1E280", Offset = "0x8D1C880", VA = "0x188D1E280", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool RBCQTYZTVHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8D1E300", Offset = "0x8D1C900", VA = "0x188D1E300", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool LJOBCKHTQJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x8D1E2C0", Offset = "0x8D1C8C0", VA = "0x188D1E2C0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public int ZAQVQMUUUZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x8D1E340", Offset = "0x8D1C940", VA = "0x188D1E340", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool XMIGJGJKZBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x8D1E380", Offset = "0x8D1C980", VA = "0x188D1E380", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public bool JLKMMNFENEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x8D1E240", Offset = "0x8D1C840", VA = "0x188D1E240", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public bool ZLNOUDOBKFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8D1E4C0", Offset = "0x8D1CAC0", VA = "0x188D1E4C0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8D1E510", Offset = "0x8D1CB10", VA = "0x188D1E510")]
		[UnityEngine.Scripting.Preserve]
		public QBUHVHCNBKE([Inject(null)] SGWOUGLKKLH gameConfigsProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomManagerEvents : KBAJLOBLNBY, JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private sealed class UKANPKCKOFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public RoomEvent HCMKRUGBLYF;

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public UKANPKCKOFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x8D38430", Offset = "0x8D36A30", VA = "0x188D38430")]
			internal object YEQBYDRCPVI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event RoomEventHandler JLYNMNCKNPA
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x8D1F890", Offset = "0x8D1DE90", VA = "0x188D1F890", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x8D1FDE0", Offset = "0x8D1E3E0", VA = "0x188D1FDE0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event RoomEventHandler EBVAOVWBLZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x8D1FAD0", Offset = "0x8D1E0D0", VA = "0x188D1FAD0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x8D1FF60", Offset = "0x8D1E560", VA = "0x188D1FF60", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event RoomEventHandler AIOQZMMRWIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x8D1FA00", Offset = "0x8D1E000", VA = "0x188D1FA00", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x8D1F960", Offset = "0x8D1DF60", VA = "0x188D1F960", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<RequestOperationType, bool> ASFXNJWPEUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x8D1FD30", Offset = "0x8D1E330", VA = "0x188D1FD30", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x8D1FEB0", Offset = "0x8D1E4B0", VA = "0x188D1FEB0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "16")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F930", Offset = "0x8D1DF30", VA = "0x188D1F930", Slot = "12")]
		public void AINFLVIDTKC(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8D1FAA0", Offset = "0x8D1E0A0", VA = "0x188D1FAA0", Slot = "13")]
		public void GXIBKVNULUK(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8D1FE80", Offset = "0x8D1E480", VA = "0x188D1FE80", Slot = "14")]
		public void PFDBDZGOKVO(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8D20000", Offset = "0x8D1E600", VA = "0x188D20000", Slot = "15")]
		public void XXEHFZQGMSK(RequestOperationType a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8D1FB70", Offset = "0x8D1E170", VA = "0x188D1FB70")]
		private void Invoke(RoomEventHandler handler, RoomEvent roomEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RoomManagerEvents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomManagerFallbacks : ROJOGVWMYHA, JZTTLQQFTLE, IDisposable, UEKNYOFIAKP
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		private class LKMBUJKBHJP : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class QEFUBVWJVIW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				public UEKNYOFIAKP.FallbackReason KILHYQGEVQQ;

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public QEFUBVWJVIW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x8D1E980", Offset = "0x8D1CF80", VA = "0x188D1E980")]
				internal object FDORIIQHOWG((UEKNYOFIAKP.Reason fallbackReason, RoomDTO roomDto, JDBJUTDTILH state, string subReason) x)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000074")]
			[CompilerGenerated]
			private sealed class ZUMQVGTFOYO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public DUPNPOGBOFO URICTIUWGTF;

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public ZUMQVGTFOYO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x8D38F40", Offset = "0x8D37540", VA = "0x188D38F40")]
				internal object WTLBYGALSVD()
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
				public LKMBUJKBHJP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				public UEKNYOFIAKP.FallbackReason reason;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				private LogRangeScope <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				private DUPNPOGBOFO[] <>7__wrap2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				private int <>7__wrap3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				private TaskAwaiter<DUPNPOGBOFO.Result> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x8D315E0", Offset = "0x8D2FBE0", VA = "0x188D315E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x8D31D60", Offset = "0x8D30360", VA = "0x188D31D60", Slot = "5")]
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
				public AsyncTaskMethodBuilder<DUPNPOGBOFO.Result> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400013B")]
				public DUPNPOGBOFO fallbackProvider;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public LKMBUJKBHJP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				public UEKNYOFIAKP.FallbackReason reason;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				private LogRangeScope <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				private JDBJUTDTILH <individualFallbackTaskState>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				private TaskAwaiter<DUPNPOGBOFO.Result> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x8D361A0", Offset = "0x8D347A0", VA = "0x188D361A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x8D36E10", Offset = "0x8D35410", VA = "0x188D36E10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Task NFTCNHNNPYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public CancellationTokenSource EYQGTLUBPSM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public JDBJUTDTILH UGILUTQMNJV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public TPICXMNKDPD FZDXDPPJXPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public RoomDTO PFJYVWVERWM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public RoomInstance TINWUFWFZDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public DUPNPOGBOFO[] XDUTCCJITBC;

			[Cpp2IlInjected.Token(Token = "0x170000B8")]
			public bool WFQPOOLMCWV
			{
				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x8D1A910", Offset = "0x8D18F10", VA = "0x188D1A910")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B9")]
			public bool OMEXKGGTYDX
			{
				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x8D1A8F0", Offset = "0x8D18EF0", VA = "0x188D1A8F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x8D1CAC0", Offset = "0x8D1B0C0", VA = "0x188D1CAC0")]
			public LKMBUJKBHJP(TPICXMNKDPD a, RoomDTO b, RoomInstance c, DUPNPOGBOFO[] d, CancellationToken e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x8D1BCA0", Offset = "0x8D1A2A0", VA = "0x188D1BCA0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x8D1C780", Offset = "0x8D1AD80", VA = "0x188D1C780")]
			public void XFYVEPJQNRO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x8D1B8C0", Offset = "0x8D19EC0", VA = "0x188D1B8C0")]
			public void DBEROTEPHNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8D1B260", Offset = "0x8D19860", VA = "0x188D1B260")]
			public void BNSQOITGBZL(UEKNYOFIAKP.Reason a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x8D1C060", Offset = "0x8D1A660", VA = "0x188D1C060")]
			[AsyncStateMachine(typeof(<RunFallbackSequence>d__16))]
			public Task MTOFZPPNAYK(UEKNYOFIAKP.FallbackReason a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x8D1C170", Offset = "0x8D1A770", VA = "0x188D1C170")]
			[AsyncStateMachine(typeof(<TryRunFallback>d__17))]
			private Task<DUPNPOGBOFO.Result> PRVLDSBSSXG(UEKNYOFIAKP.FallbackReason a, DUPNPOGBOFO b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x8D1BB80", Offset = "0x8D1A180", VA = "0x188D1BB80")]
			private void DYRHDEUEGCX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8D1BE20", Offset = "0x8D1A420", VA = "0x188D1BE20")]
			public bool FDOTKGARKMG(UEKNYOFIAKP.Reason a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x8D1C4F0", Offset = "0x8D1AAF0", VA = "0x188D1C4F0")]
			private void VHZXHZPFXRG(JDBJUTDTILH a, UEKNYOFIAKP.FallbackReason b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8D1C7F0", Offset = "0x8D1ADF0", VA = "0x188D1C7F0")]
			private void XIDFHRLOBVL(JDBJUTDTILH a, DUPNPOGBOFO.Result b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8D1BED0", Offset = "0x8D1A4D0", VA = "0x188D1BED0")]
			private void KPFSWECMOOX(JDBJUTDTILH a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x8D1B500", Offset = "0x8D19B00", VA = "0x188D1B500")]
			private void CFCLPQTFMZY(JDBJUTDTILH a, DUPNPOGBOFO.Result b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8D1BA20", Offset = "0x8D1A020", VA = "0x188D1BA20")]
			private void DBYXWJDQLVL(JDBJUTDTILH a, Exception b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8D1B150", Offset = "0x8D19750", VA = "0x188D1B150")]
			private void AHWGQFWEUBY(DUPNPOGBOFO a, UEKNYOFIAKP.FallbackReason b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8D1C9B0", Offset = "0x8D1AFB0", VA = "0x188D1C9B0")]
			private void ZEQUJPOICAM(DUPNPOGBOFO a, UEKNYOFIAKP.Reason b, string c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x8D1C2C0", Offset = "0x8D1A8C0", VA = "0x188D1C2C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public class JDBJUTDTILH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Task<DUPNPOGBOFO.Result> NFTCNHNNPYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public CancellationTokenSource EYQGTLUBPSM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public DUPNPOGBOFO URICTIUWGTF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public UEKNYOFIAKP.Reason OOANRZCRVTV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public HashSet<UEKNYOFIAKP.Reason> MXHYDJCQEBC;

			[Cpp2IlInjected.Token(Token = "0x170000BA")]
			public bool WFQPOOLMCWV
			{
				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x8D1A910", Offset = "0x8D18F10", VA = "0x188D1A910")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BB")]
			public bool OMEXKGGTYDX
			{
				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x8D1A8F0", Offset = "0x8D18EF0", VA = "0x188D1A8F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A770", Offset = "0x8D18D70", VA = "0x188D1A770")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A8D0", Offset = "0x8D18ED0", VA = "0x188D1A8D0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A930", Offset = "0x8D18F30", VA = "0x188D1A930", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x8D1AB50", Offset = "0x8D19150", VA = "0x188D1AB50")]
			public JDBJUTDTILH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class IKYMTVTNISZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public UEKNYOFIAKP.Reason KILHYQGEVQQ;

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public IKYMTVTNISZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A570", Offset = "0x8D18B70", VA = "0x188D1A570")]
			internal object CPSOIOZJBBZ(JDBJUTDTILH a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A5E0", Offset = "0x8D18BE0", VA = "0x188D1A5E0")]
			internal object CPXVFVTGKNI(LKMBUJKBHJP a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A650", Offset = "0x8D18C50", VA = "0x188D1A650")]
			internal object CQDCDCNDTYR()
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

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x8D26BA0", Offset = "0x8D251A0", VA = "0x188D26BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8D270F0", Offset = "0x8D256F0", VA = "0x188D270F0", Slot = "5")]
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
			public UEKNYOFIAKP.FallbackReason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private LKMBUJKBHJP <localTaskState>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8D348A0", Offset = "0x8D32EA0", VA = "0x188D348A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x8D35510", Offset = "0x8D33B10", VA = "0x188D35510", Slot = "5")]
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
			public UEKNYOFIAKP.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public RoomManagerFallbacks <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			private IKYMTVTNISZ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public Exception exception;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8D35570", Offset = "0x8D33B70", VA = "0x188D35570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8D36140", Offset = "0x8D34740", VA = "0x188D36140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		internal static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		internal static readonly Log NRLIHGMMAQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private NIJQVUPMTTA VHJCBTPFZBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private TPICXMNKDPD FZDXDPPJXPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private LKMBUJKBHJP IYVZVINXNHL;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private KEWSLRECSSV VXTOLEXPLIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x8D20880", Offset = "0x8D1EE80", VA = "0x188D20880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public bool EQKDWIJQURI
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x23882C0", Offset = "0x23868C0", VA = "0x1823882C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		private bool LOISPGSZMLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x8D202F0", Offset = "0x8D1E8F0", VA = "0x188D202F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8D20800", Offset = "0x8D1EE00", VA = "0x188D20800", Slot = "6")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8D202E0", Offset = "0x8D1E8E0", VA = "0x188D202E0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8D20170", Offset = "0x8D1E770", VA = "0x188D20170", Slot = "9")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8D20720", Offset = "0x8D1ED20", VA = "0x188D20720")]
		private bool FLJSAFNYPYQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8D20E70", Offset = "0x8D1F470", VA = "0x188D20E70", Slot = "5")]
		private void YNMORBNSMTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8D20050", Offset = "0x8D1E650", VA = "0x188D20050", Slot = "8")]
		[AsyncStateMachine(typeof(<TriggerFallback>d__14))]
		public Task AOCCLUROOVI(UEKNYOFIAKP.Reason a, [Optional] Exception b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8D20430", Offset = "0x8D1EA30", VA = "0x188D20430")]
		private bool FJHFRSLMSRM(UEKNYOFIAKP.FallbackReason a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8D209F0", Offset = "0x8D1EFF0", VA = "0x188D209F0")]
		private DUPNPOGBOFO[] UTFEINCSIPY(RoomInstance a, RoomDTO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8D208D0", Offset = "0x8D1EED0", VA = "0x188D208D0")]
		[AsyncStateMachine(typeof(<StartRunningFallbacks>d__19))]
		private Task StartRunningFallbacks(UEKNYOFIAKP.FallbackReason reason, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8D20360", Offset = "0x8D1E960", VA = "0x188D20360")]
		[AsyncStateMachine(typeof(<BlockWhilePreviousFallbackSequenceIsPendingCancellation>d__20))]
		private Task FFZECBYSQRO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RoomManagerFallbacks()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerInitialRoomLoad : LCVPVCCAVNQ, JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class DGWFRGWFTEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public Matchmaking.GameJoinResult GIFPSKZVKYB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public ErrorCode VNCHYDCGUKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public Exception DPJLVPQRCSZ;

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public DGWFRGWFTEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8D192F0", Offset = "0x8D178F0", VA = "0x188D192F0")]
			internal object PDFEUCTDLTV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private sealed class NUCXBFCPWAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public Task<RoomLoadRequestPayload> VAZSMDKFGOT;

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public NUCXBFCPWAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			internal Task<RoomLoadRequestPayload> GAGPQORJQFE(StackTimer<string>.ERYHZSBUWXZ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class JDPERVANSRK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public Task<RoomLoadRequestPayload> VAZSMDKFGOT;

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public JDPERVANSRK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			internal Task<RoomLoadRequestPayload> LOQMXSEUNVK(StackTimer<string>.ERYHZSBUWXZ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class LAZVWXPPIEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public Task URHHGUKRGEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public RoomInstance IOBPWBMSJDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public bool FIPJAONYEJV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public Task VUEABLGGRDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public Task XHCRCQNYVKM;

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public LAZVWXPPIEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x8D1AF60", Offset = "0x8D19560", VA = "0x188D1AF60")]
			internal object PCNXYKAKRSS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x8D1B060", Offset = "0x8D19660", VA = "0x188D1B060")]
			internal string PCTEVQUIBEB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class AAXMMZLWMBT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public RoomInstance IOBPWBMSJDM;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public AAXMMZLWMBT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x8D19130", Offset = "0x8D17730", VA = "0x188D19130")]
			internal object CYPKYPIPAFO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class ENWWCVQRCBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public long AGDIEYTGPOL;

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ENWWCVQRCBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x8D193A0", Offset = "0x8D179A0", VA = "0x188D193A0")]
			internal void VMENOTSNCWJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class GROVLUIYBWG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public RoomInstance IOBPWBMSJDM;

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public GROVLUIYBWG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A500", Offset = "0x8D18B00", VA = "0x188D1A500")]
			internal object KCCKXJAUUOG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class MOMYYUWUHAV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public RoomInstance IOBPWBMSJDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public Task XHCRCQNYVKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public Task URHHGUKRGEC;

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public MOMYYUWUHAV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x8D1CF90", Offset = "0x8D1B590", VA = "0x188D1CF90")]
			internal string IUKYMBDHWCS()
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
			private TaskAwaiter<EARYEWOAMEK> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x8D27150", Offset = "0x8D25750", VA = "0x188D27150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x8D278C0", Offset = "0x8D25EC0", VA = "0x188D278C0", Slot = "5")]
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
			public StackTimer<string>.ERYHZSBUWXZ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public Matchmaking.ServerConnectionInfoDTO serverConnectionInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public ZTDIGAYZRAK joinRoomInstancePauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public CancellationToken roomCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private TaskAwaiter<QAACXUSOGPL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x8D28310", Offset = "0x8D26910", VA = "0x188D28310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8D28A00", Offset = "0x8D27000", VA = "0x188D28A00", Slot = "5")]
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
			public StackTimer<string>.ERYHZSBUWXZ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public VAIYLWQXDVQ customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public ZTDIGAYZRAK joinRoomInstancePauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			private NUCXBFCPWAP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private ZSEHKOFSPKO <multiProgressTracker>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			private IDisposable <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			private StackTimer<string>.ERYHZSBUWXZ <connectToRoomAndRunLoadLogicTimer>5__5;

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
			private IHSTJJNLZKT <preOperationProgressTracker>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private Task<Matchmaking.ServerConnectionInfoDTO> <serverConnectionInfoTask>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private PZIOLCAUYLT <>7__wrap10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private CancellationTokenSource <cameraFadeCts>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap12;

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

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x8D28A60", Offset = "0x8D27060", VA = "0x188D28A60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x8D2E460", Offset = "0x8D2CA60", VA = "0x188D2E460", Slot = "5")]
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
			private KUXAUVMITFU <roomContainer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x8D42380", Offset = "0x8D40980", VA = "0x188D42380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x8D42800", Offset = "0x8D40E00", VA = "0x188D42800", Slot = "5")]
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
			public StackTimer<string>.ERYHZSBUWXZ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public VAIYLWQXDVQ customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public ZTDIGAYZRAK joinRoomInstancePauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			private ZSEHKOFSPKO <multiProgressTracker>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private IDisposable <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			private StackTimer<string>.ERYHZSBUWXZ <connectToRoomAndRunLoadLogicTimer>5__5;

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
			private IHSTJJNLZKT <preOperationProgressTracker>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			private Task<Matchmaking.ServerConnectionInfoDTO> <serverConnectionInfoTask>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			private RoomLoadRequestPayload <initialRoomLoadPayload>5__11;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			private RRWPZJUWVEY <preloadContext>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			private TaskAwaiter<RoomLoadRequestPayload> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			private PZIOLCAUYLT <>7__wrap12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			private Task <loadEmptySceneTask>5__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			private WMLSAZACNDX <sceneManagementService>5__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private UWDFKAULHCP <scenePreloadRequest>5__16;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			private CancellationTokenSource <cameraFadeCts>5__17;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap17;

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

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x8D42860", Offset = "0x8D40E60", VA = "0x188D42860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8D47D80", Offset = "0x8D46380", VA = "0x188D47D80", Slot = "5")]
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
			public StackTimer<string>.ERYHZSBUWXZ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			private TaskAwaiter<Matchmaking.ServerConnectionInfoDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x8D4A640", Offset = "0x8D48C40", VA = "0x188D4A640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8D4AB10", Offset = "0x8D49110", VA = "0x188D4AB10", Slot = "5")]
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
			public VAIYLWQXDVQ customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x8D4AB80", Offset = "0x8D49180", VA = "0x188D4AB80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x8D4B130", Offset = "0x8D49730", VA = "0x188D4B130", Slot = "5")]
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
			private LAZVWXPPIEM <>8__1;

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

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x8D4B190", Offset = "0x8D49790", VA = "0x188D4B190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8D4BD00", Offset = "0x8D4A300", VA = "0x188D4BD00", Slot = "5")]
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
			public StackTimer<string>.ERYHZSBUWXZ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public ZTDIGAYZRAK joinRoomInstanceToken;

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
			public RRWPZJUWVEY preloadContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public ZSEHKOFSPKO progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			private StackTimer<string>.ERYHZSBUWXZ <roomLoadLogicTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8D52380", Offset = "0x8D50980", VA = "0x188D52380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8D52B70", Offset = "0x8D51170", VA = "0x188D52B70", Slot = "5")]
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
			public StackTimer<string>.ERYHZSBUWXZ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private StackTimer<string>.ERYHZSBUWXZ <spawnLocalPlayerTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			private LogRangeScope <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap3;

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

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x8D52BD0", Offset = "0x8D511D0", VA = "0x188D52BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8D543B0", Offset = "0x8D529B0", VA = "0x188D543B0", Slot = "5")]
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
			public StackTimer<string>.ERYHZSBUWXZ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private StackTimer<string>.ERYHZSBUWXZ <disconnectTimerScope>5__3;

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
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap5;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x8D54CA0", Offset = "0x8D532A0", VA = "0x188D54CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x8D55710", Offset = "0x8D53D10", VA = "0x188D55710", Slot = "5")]
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
			public VAIYLWQXDVQ customRoomLoadPayload;

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
			private ZTDIGAYZRAK <joinRoomInstancePauseToken>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			private KFZZFBZWMFW <analyticsData>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x8D56720", Offset = "0x8D54D20", VA = "0x188D56720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x8D57580", Offset = "0x8D55B80", VA = "0x188D57580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly Log TDPXJZBIBTP;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly Log DNRTANOEUIP;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly Log ENOJTOXYRUX;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly string KXIQXSMOGSO;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly string YXKGAMRVSPY;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly string XFNCJSWYXDL;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly Guid KEWDQHVAPVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TGHUEWOZHWI IBCDEJQDNOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private GGJMWGKBHJH BIDVTMXYVOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private LRJLKNGLINT IXSJEENOFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private NIJQVUPMTTA VHJCBTPFZBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private TPICXMNKDPD FZDXDPPJXPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private ROJOGVWMYHA FUJECTDIDTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private FCNDFENYFYI CVJFRYMBCOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private KBAJLOBLNBY XYCDJVVMZAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private DWBHSWWZGAF TSCVOBDXOGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private WAXSPKDXFTI WEGFANSAJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private IDisposable OPYLYDIJDEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private QUKMHXOZAMV RDFRDLUXACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private readonly Token AWHBFOSMYYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private PZIOLCAUYLT MGGLQZGCSHK;

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public TaskStatus MYSSRGMCGJY
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x12D5420", Offset = "0x12D3A20", VA = "0x1812D5420", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TaskStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x1866DB0", Offset = "0x18653B0", VA = "0x181866DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private KEWSLRECSSV VXTOLEXPLIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x8D228D0", Offset = "0x8D20ED0", VA = "0x188D228D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8D21DC0", Offset = "0x8D203C0", VA = "0x188D21DC0", Slot = "6")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D216F0", Offset = "0x8D1FCF0", VA = "0x188D216F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x8D22210", Offset = "0x8D20810", VA = "0x188D22210", Slot = "5")]
		[AsyncStateMachine(typeof(<JoinRoomInstance>d__30))]
		public Task JoinRoomInstance(RoomInstance targetInstance, VAIYLWQXDVQ customRoomLoadPayload, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8D21C70", Offset = "0x8D20270", VA = "0x188D21C70")]
		[AsyncStateMachine(typeof(<TryJoinRoomInstance>d__31))]
		private Task IGANXKIDNGN(RoomInstance a, VAIYLWQXDVQ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8D23630", Offset = "0x8D21C30", VA = "0x188D23630")]
		private void SXHYLQQZABV(DWBHSWWZGAF a, RoomInstance b, Exception c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8D23D60", Offset = "0x8D22360", VA = "0x188D23D60")]
		private static void UITOOTHCCRJ(KFZZFBZWMFW a, Exception b, [Optional] List<int> c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8D21220", Offset = "0x8D1F820", VA = "0x188D21220")]
		[AsyncStateMachine(typeof(<ConnectToRoomAndRunLoadLogic>d__34))]
		private Task ConnectToRoomAndRunLoadLogic(StackTimer<string>.ERYHZSBUWXZ timer, RoomInstance targetInstance, VAIYLWQXDVQ customRoomLoadPayload, ZTDIGAYZRAK joinRoomInstancePauseToken, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8D21740", Offset = "0x8D1FD40", VA = "0x188D21740")]
		[AsyncStateMachine(typeof(<FastPath_ConnectToRoomAndRunLoadLogic>d__35))]
		private Task FastPath_ConnectToRoomAndRunLoadLogic(StackTimer<string>.ERYHZSBUWXZ timer, RoomInstance targetInstance, VAIYLWQXDVQ customRoomLoadPayload, ZTDIGAYZRAK joinRoomInstancePauseToken, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8D232A0", Offset = "0x8D218A0", VA = "0x188D232A0")]
		private void STDNAEZDRLZ([CallerMemberName] string caller = "<unknown>")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8D225D0", Offset = "0x8D20BD0", VA = "0x188D225D0")]
		[AsyncStateMachine(typeof(<TryDisconnectFromCurrentRoomInstance>d__37))]
		private Task MZINSQGKIQM(StackTimer<string>.ERYHZSBUWXZ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x8D22B90", Offset = "0x8D21190", VA = "0x188D22B90")]
		private void RYNLHVGTMTI(RoomInstance a, CancellationToken b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8D23040", Offset = "0x8D21640", VA = "0x188D23040")]
		private void SNMDSYXZPRS(RoomInstance a, TaskStatus b, string c, ZTDIGAYZRAK d, Exception e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8D21380", Offset = "0x8D1F980", VA = "0x188D21380")]
		private void DJMVHBURAAR(RoomInstance a, ZTDIGAYZRAK b, OperationCanceledException c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8D22850", Offset = "0x8D20E50", VA = "0x188D22850")]
		private void OOVOISDWZUD(RoomInstance a, ZTDIGAYZRAK b, Exception c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8D23420", Offset = "0x8D21A20", VA = "0x188D23420")]
		private void SWJMGHOOZEN(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8D21090", Offset = "0x8D1F690", VA = "0x188D21090")]
		private static RoomEvent AVHAQJAQTVH(RoomInstance a)
		{
			return default(RoomEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8D24580", Offset = "0x8D22B80", VA = "0x188D24580")]
		[AsyncStateMachine(typeof(<CreateRoomDiContainer>d__44))]
		private Task VLZCTMGSAYH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8D218A0", Offset = "0x8D1FEA0", VA = "0x188D218A0")]
		[AsyncStateMachine(typeof(<GetServerConnectionInfo>d__45))]
		private Task<Matchmaking.ServerConnectionInfoDTO> GetServerConnectionInfo(RoomInstance targetInstance, StackTimer<string>.ERYHZSBUWXZ timer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8D21A00", Offset = "0x8D20000", VA = "0x188D21A00")]
		private static QAACXUSOGPL HIBZVYVSYAN(Matchmaking.ServerConnectionInfoDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8D22700", Offset = "0x8D20D00", VA = "0x188D22700")]
		[AsyncStateMachine(typeof(<ConnectToPhoton>d__47))]
		private Task NLBPCDFQMFH(Matchmaking.ServerConnectionInfoDTO a, ZTDIGAYZRAK b, StackTimer<string>.ERYHZSBUWXZ c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D24650", Offset = "0x8D22C50", VA = "0x188D24650")]
		[AsyncStateMachine(typeof(<JoinRoomLoadWithPhoton>d__48))]
		private Task XKBHPUUXOMR(RoomInstance a, CancellationTokenSource b, Task c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D22EC0", Offset = "0x8D214C0", VA = "0x188D22EC0")]
		[AsyncStateMachine(typeof(<RunRoomLoadLogic>d__49))]
		private Task RunRoomLoadLogic(RoomLoadRequestPayload initialRoomLoadPayload, ZSEHKOFSPKO progressTracker, RoomInstance targetRoomInstance, ZTDIGAYZRAK joinRoomInstanceToken, StackTimer<string>.ERYHZSBUWXZ timer, CancellationToken roomJoinCancellationToken, [Optional] RRWPZJUWVEY preloadContext)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8D229B0", Offset = "0x8D20FB0", VA = "0x188D229B0")]
		private ZTDIGAYZRAK RWQJAUKMNEA(ZTDIGAYZRAK a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8D23A90", Offset = "0x8D22090", VA = "0x188D23A90")]
		[AsyncStateMachine(typeof(<SpawnLocalPlayer>d__51))]
		private Task SpawnLocalPlayer(StackTimer<string>.ERYHZSBUWXZ timer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8D210F0", Offset = "0x8D1F6F0", VA = "0x188D210F0")]
		[AsyncStateMachine(typeof(<CheckForRoomDataOutOfDate>d__52))]
		private Task CYZZVOUJOPD(CancellationToken a, int b, AccountRoleType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8D21B10", Offset = "0x8D20110", VA = "0x188D21B10")]
		private static void HIUPJHZZJNG(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8D22350", Offset = "0x8D20950", VA = "0x188D22350")]
		private void KITWUYFNTXT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8D23BD0", Offset = "0x8D221D0", VA = "0x188D23BD0")]
		private void TDFMHVOQQFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8D21000", Offset = "0x8D1F600", VA = "0x188D21000")]
		private void AIXNBWOFNQF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8D22920", Offset = "0x8D20F20", VA = "0x188D22920")]
		private void RUOJAENKZDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D22130", Offset = "0x8D20730", VA = "0x188D22130")]
		private static void JXOMKPNXKNE(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8D23C60", Offset = "0x8D22260", VA = "0x188D23C60")]
		private static CancellationTokenRegistration TFVHGQJUZKB(RoomInstance a, CancellationToken b)
		{
			return default(CancellationTokenRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8D21400", Offset = "0x8D1FA00", VA = "0x188D21400")]
		private static void DLDXMJFMRMY(RoomInstance a, Exception b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8D214F0", Offset = "0x8D1FAF0", VA = "0x188D214F0")]
		private void DOTWAAFMKBO(RoomInstance a, Task b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8D22570", Offset = "0x8D20B70", VA = "0x188D22570")]
		private static void Log(Func<string> msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x8D24990", Offset = "0x8D22F90", VA = "0x188D24990")]
		public RoomManagerInitialRoomLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8D21690", Offset = "0x8D1FC90", VA = "0x188D21690")]
		[CompilerGenerated]
		internal static (int, int?) DXQOOHBHIAP(ErrorCode a)
		{
			return default((int, int?));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerInRoomTasks : BYXYINOYSGX, JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class SXOZHASCAVJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public RoomManagerInRoomTasks CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			public int BFPVGZFPBQZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000238")]
			public AccountRoleType RXSRMOCDALD;

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SXOZHASCAVJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x8D420B0", Offset = "0x8D406B0", VA = "0x188D420B0")]
			internal List<Task> NFVALCBWGXA(CancellationToken a)
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

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x8D50300", Offset = "0x8D4E900", VA = "0x188D50300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x8D507D0", Offset = "0x8D4EDD0", VA = "0x188D507D0", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x8D57A20", Offset = "0x8D56020", VA = "0x188D57A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x8D57DC0", Offset = "0x8D563C0", VA = "0x188D57DC0", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x8D57E20", Offset = "0x8D56420", VA = "0x188D57E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x8D58100", Offset = "0x8D56700", VA = "0x188D58100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private readonly HashSet<InLoadedRoomTaskBuilder> VNZQRLDHINO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private GGJMWGKBHJH BIDVTMXYVOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private NIJQVUPMTTA VHJCBTPFZBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private MZFDYAVRXCT IWLJVNLNZJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskRunner NMATEWAPMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private IDisposable OPYLYDIJDEF;

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AE10", Offset = "0x8D39410", VA = "0x188D3AE10", Slot = "5")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8D3ACC0", Offset = "0x8D392C0", VA = "0x188D3ACC0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A9F0", Offset = "0x8D38FF0", VA = "0x188D3A9F0", Slot = "4")]
		public bool ANNZNRHFJRB(InLoadedRoomTaskBuilder a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8D3ABF0", Offset = "0x8D391F0", VA = "0x188D3ABF0")]
		private void DICZSROOYAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B280", Offset = "0x8D39880", VA = "0x188D3B280")]
		private void SWWBKZVSFFE(BCQRNRKFWAN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AD20", Offset = "0x8D39320", VA = "0x188D3AD20")]
		[AsyncStateMachine(typeof(<RunInRoomTaskAsync>d__15))]
		private Task HSZJSQIXVHG(int a, AccountRoleType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B1B0", Offset = "0x8D397B0", VA = "0x188D3B1B0")]
		private Func<CancellationToken, List<Task>> QQWRFRKJXAE(int a, AccountRoleType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A4E0", Offset = "0x8D38AE0", VA = "0x188D3A4E0")]
		private List<Task> AABNPHZHAAI(int a, AccountRoleType b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AA50", Offset = "0x8D39050", VA = "0x188D3AA50")]
		[AsyncStateMachine(typeof(<WaitAndLog>d__18))]
		private Task ARURZPABNSY(InLoadedRoomTaskBuilder a, CancellationToken b, int c, AccountRoleType d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B0E0", Offset = "0x8D396E0", VA = "0x188D3B0E0")]
		[AsyncStateMachine(typeof(<WaitForPhotonAndCancel>d__19))]
		private Task NRPUXCMCTXL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AB70", Offset = "0x8D39170", VA = "0x188D3AB70")]
		private void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B4A0", Offset = "0x8D39AA0", VA = "0x188D3B4A0")]
		public RoomManagerInRoomTasks()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerPendingRequests : AXARZMWEGGY, JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class RPGDRVSGBNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			public Guid OZZPRBWJRPS;

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public RPGDRVSGBNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8D3A2F0", Offset = "0x8D388F0", VA = "0x188D3A2F0")]
			internal object IKRXTJBLBDB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[CompilerGenerated]
		private sealed class XMEHEWGCGRP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400024E")]
			public Guid OZZPRBWJRPS;

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public XMEHEWGCGRP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8D58220", Offset = "0x8D56820", VA = "0x188D58220")]
			internal object CFJYIARKIDY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class SSSKYROOASY
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SSSKYROOASY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class OGOKSBBDBET
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			public Guid OZZPRBWJRPS;

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OGOKSBBDBET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x8D39B50", Offset = "0x8D38150", VA = "0x188D39B50")]
			internal object ZOLNEAHXVWM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class TYGMGLNVTBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			public Guid OZZPRBWJRPS;

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TYGMGLNVTBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x8D42320", Offset = "0x8D40920", VA = "0x188D42320")]
			internal object YXBWNHFTCJE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly Dictionary<Guid, PendingRequestData> YTZXMPXBXYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private readonly TimeSpan CJZGJQBTYJC;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "9")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BA60", Offset = "0x8D3A060", VA = "0x188D3BA60", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B520", Offset = "0x8D39B20", VA = "0x188D3B520", Slot = "4")]
		public PendingRequest Add(Guid operationId)
		{
			return default(PendingRequest);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BCB0", Offset = "0x8D3A2B0", VA = "0x188D3BCB0", Slot = "5")]
		public bool Remove(Guid operationId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B730", Offset = "0x8D39D30", VA = "0x188D3B730", Slot = "6")]
		public bool BHPHLKCNPQG(Guid a, Task b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BA70", Offset = "0x8D3A070", VA = "0x188D3BA70", Slot = "7")]
		public bool ISQHLSCJIWE(Guid a, EARYEWOAMEK b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BC40", Offset = "0x8D3A240", VA = "0x188D3BC40", Slot = "8")]
		public Task<(EARYEWOAMEK, Task)> MOPNYLZEBJP(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BEB0", Offset = "0x8D3A4B0", VA = "0x188D3BEB0")]
		private void WKVNUANNCYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C0E0", Offset = "0x8D3A6E0", VA = "0x188D3C0E0")]
		public RoomManagerPendingRequests()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerPresenceUpdates : GUBYKULAKSE, JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		private class PNQJOTHFGOO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			private readonly RoomInstance GJOBSZXZIAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			private readonly CancellationTokenSource ERMOUZTPHRP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			public readonly CancellationToken XYYIWYZAGLX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			private bool IYKPWANEYNZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			private bool ADKFKWBUFYD;

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8D3A020", Offset = "0x8D38620", VA = "0x188D3A020")]
			public PNQJOTHFGOO(RoomInstance a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x8D39EB0", Offset = "0x8D384B0", VA = "0x188D39EB0")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x8D39FF0", Offset = "0x8D385F0", VA = "0x188D39FF0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class QEFUBVWJVIW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public DisconnectCause XPHLILIYZNL;

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public QEFUBVWJVIW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x8D3A0C0", Offset = "0x8D386C0", VA = "0x188D3A0C0")]
			internal object ZOMCNGWSKES()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class QOWUILOGJLS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			public int KZQERIYTTQE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			public RoomManagerPresenceUpdates CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public QOWUILOGJLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x8D3A150", Offset = "0x8D38750", VA = "0x188D3A150")]
			internal object DQPOSEOZOPM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class QPCBFSIDSXB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026A")]
			public RoomInstance GJOBSZXZIAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400026B")]
			public QOWUILOGJLS GOOXOIYUWOV;

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public QPCBFSIDSXB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x8D3A1B0", Offset = "0x8D387B0", VA = "0x188D3A1B0")]
			internal object DQKHUXVCFED((RoomInstance lastLocalPlayerRoomInstance, RoomInstance newRoomInstance, ROJOGVWMYHA fallbacks) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class EDWAHUFUCKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026C")]
			public RoomInstance GJOBSZXZIAS;

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public EDWAHUFUCKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x8D39800", Offset = "0x8D37E00", VA = "0x188D39800")]
			internal object YWAOCXRLCHL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x8D39780", Offset = "0x8D37D80", VA = "0x188D39780")]
			internal void YVVHFQXNSWC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x8D39740", Offset = "0x8D37D40", VA = "0x188D39740")]
			internal object YVQAIKDQJKT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x8D39700", Offset = "0x8D37D00", VA = "0x188D39700")]
			internal object YVKTLDJSZZK()
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

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x8D4CFE0", Offset = "0x8D4B5E0", VA = "0x188D4CFE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x8D4D420", Offset = "0x8D4BA20", VA = "0x188D4D420", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x8D4D480", Offset = "0x8D4BA80", VA = "0x188D4D480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
			public VAIYLWQXDVQ customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000281")]
			private EDWAHUFUCKX <>8__1;

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

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x8D55770", Offset = "0x8D53D70", VA = "0x188D55770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x8D566C0", Offset = "0x8D54CC0", VA = "0x188D566C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private static readonly UXRGCJTXILI.PCQUEUKYBYS EYLHQMJFIRT;

		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private static readonly LogFlags YIQUNNFXRSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private GGJMWGKBHJH BIDVTMXYVOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private NIJQVUPMTTA VHJCBTPFZBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private ROJOGVWMYHA FUJECTDIDTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private TPICXMNKDPD FZDXDPPJXPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private LBYYQBWWZWZ PRCZNZUSLCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private LCVPVCCAVNQ EGPJMIODNOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private RoomInstance ZDWRDLUDXKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private PNQJOTHFGOO BWQWECDJIBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private bool ZTSONAZPJBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private Task UHOAIVFZBJX;

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private KEWSLRECSSV VXTOLEXPLIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x8D3CF40", Offset = "0x8D3B540", VA = "0x188D3CF40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public bool OYRTXUUARUP
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xB9A660", Offset = "0xB98C60", VA = "0x180B9A660")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x8D3C740", Offset = "0x8D3AD40", VA = "0x188D3C740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C750", Offset = "0x8D3AD50", VA = "0x188D3C750", Slot = "4")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C190", Offset = "0x8D3A790", VA = "0x188D3C190", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CE50", Offset = "0x8D3B450", VA = "0x188D3CE50")]
		[AsyncStateMachine(typeof(<OnDisconnectedFromPhotonWhileConnected>d__20))]
		private Task RASMIRCWIRS(DisconnectCause a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CF90", Offset = "0x8D3B590", VA = "0x188D3CF90")]
		private void UIUNAUBZSYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C490", Offset = "0x8D3AA90", VA = "0x188D3C490")]
		private void HFXNRIBVWJT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C320", Offset = "0x8D3A920", VA = "0x188D3C320")]
		private void FDPXZIEMHJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CB50", Offset = "0x8D3B150", VA = "0x188D3CB50")]
		private bool PBRRTMHBTWZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D120", Offset = "0x8D3B720", VA = "0x188D3D120")]
		[AsyncStateMachine(typeof(<OnPlayerPresenceUpdated>d__26))]
		private void VESISJZTTDC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CBC0", Offset = "0x8D3B1C0", VA = "0x188D3CBC0")]
		private void QPIYVZXHQZR([Out] IDisposable a, [Out] IDisposable b, [Out] IDisposable c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CA00", Offset = "0x8D3B000", VA = "0x188D3CA00")]
		private bool KFTFAXMEBLN(RoomInstance a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CB00", Offset = "0x8D3B100", VA = "0x188D3CB00")]
		private void KRBQHBWBDFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C610", Offset = "0x8D3AC10", VA = "0x188D3C610")]
		[AsyncStateMachine(typeof(<TryJoinRoomInstance>d__30))]
		private Task IGANXKIDNGN(RoomInstance a, VAIYLWQXDVQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D580", Offset = "0x8D3BB80", VA = "0x188D3D580")]
		public RoomManagerPresenceUpdates()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerReceiveOperation : CNMXIHSKTKR, JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class TBDIAOPJOEZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400028D")]
			public NVFUFUSEYRF WKWIIRJKGXD;

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TBDIAOPJOEZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x8D42150", Offset = "0x8D40750", VA = "0x188D42150")]
			internal object CUKKIZTMZAE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		[CompilerGenerated]
		private sealed class NEFENOBNJAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400028E")]
			public NVFUFUSEYRF IPZSVHKCSSN;

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public NEFENOBNJAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x8D39900", Offset = "0x8D37F00", VA = "0x188D39900")]
			internal object NIEQAFJATWP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class JVNLNTKKISD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400028F")]
			public NVFUFUSEYRF GHXWDVBWKQC;

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public JVNLNTKKISD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x8D398A0", Offset = "0x8D37EA0", VA = "0x188D398A0")]
			internal object UCIERDTJLPU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		[CompilerGenerated]
		private sealed class RBIUPPLHNXI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000290")]
			public YARKOAWAUMF CQHOTXKMPVT;

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public RBIUPPLHNXI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x8D3A270", Offset = "0x8D38870", VA = "0x188D3A270")]
			internal object JMKXZUYQNJS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		[CompilerGenerated]
		private sealed class SXOZHASCAVJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000291")]
			public NVFUFUSEYRF IPZSVHKCSSN;

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SXOZHASCAVJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x8D420F0", Offset = "0x8D406F0", VA = "0x188D420F0")]
			internal object ZVYXBWVCLQY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		[CompilerGenerated]
		private sealed class UKANPKCKOFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000292")]
			public NVFUFUSEYRF IPZSVHKCSSN;

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public UKANPKCKOFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x8D58160", Offset = "0x8D56760", VA = "0x188D58160")]
			internal object ADRCROBJTTP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class PMCLZVAKTMZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			public NVFUFUSEYRF MPZKLQFYNSH;

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public PMCLZVAKTMZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x8D39CB0", Offset = "0x8D382B0", VA = "0x188D39CB0")]
			internal object ICTRBKZBCHJ()
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
			public YARKOAWAUMF operation;

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

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x8D51D00", Offset = "0x8D50300", VA = "0x188D51D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x8D52320", Offset = "0x8D50920", VA = "0x188D52320", Slot = "5")]
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
			public NVFUFUSEYRF operationStartMessage;

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
			private ZTDIGAYZRAK <pauseToken>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			private TaskAwaiter<NVFUFUSEYRF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002A4")]
			private IDisposable <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002A5")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x8D50830", Offset = "0x8D4EE30", VA = "0x188D50830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x8D51380", Offset = "0x8D4F980", VA = "0x188D51380", Slot = "5")]
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
			public NVFUFUSEYRF request;

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
			private TaskAwaiter<YARKOAWAUMF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x8D513E0", Offset = "0x8D4F9E0", VA = "0x188D513E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x8D51CA0", Offset = "0x8D502A0", VA = "0x188D51CA0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<YARKOAWAUMF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public RoomManagerReceiveOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			public NVFUFUSEYRF request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			private RTFVAWFMFZN.LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			private ZTDIGAYZRAK <pauseToken>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			private TaskAwaiter<NVFUFUSEYRF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x8D54410", Offset = "0x8D52A10", VA = "0x188D54410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x8D54940", Offset = "0x8D52F40", VA = "0x188D54940", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8D549B0", Offset = "0x8D52FB0", VA = "0x188D549B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x8D54C30", Offset = "0x8D53230", VA = "0x188D54C30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private NIJQVUPMTTA VHJCBTPFZBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private FCNDFENYFYI CVJFRYMBCOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private MNIGGUQIBYU EGTPZURXDHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private LHYKYYCLXTH IOCBFPWDUPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private LRJLKNGLINT IXSJEENOFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskCompletionSource<RoomOperationType> RCKVQZXFIWC;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DFE0", Offset = "0x8D3C5E0", VA = "0x188D3DFE0", Slot = "7")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D950", Offset = "0x8D3BF50", VA = "0x188D3D950", Slot = "6")]
		[AsyncStateMachine(typeof(<ThrowOnRequestTask>d__8))]
		public Task<RoomOperationType> ACNIVBSTODF(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D5F0", Offset = "0x8D3BBF0", VA = "0x188D3D5F0", Slot = "4")]
		public void ACBYAPOEYTJ(NVFUFUSEYRF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E350", Offset = "0x8D3C950", VA = "0x188D3E350", Slot = "5")]
		public void QQSRLRGWPJA(NVFUFUSEYRF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E680", Offset = "0x8D3CC80", VA = "0x188D3E680")]
		[AsyncStateMachine(typeof(<RunOperationFromRequest>d__11))]
		private Task VBAFUPQKMDZ(NVFUFUSEYRF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DA60", Offset = "0x8D3C060", VA = "0x188D3DA60")]
		[AsyncStateMachine(typeof(<RunOperationFromMaster>d__12))]
		private Task EJOFKALRUUI(NVFUFUSEYRF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E790", Offset = "0x8D3CD90", VA = "0x188D3E790")]
		[AsyncStateMachine(typeof(<SyncAndCreateOperation>d__13))]
		private Task<YARKOAWAUMF> ZXAIABALQCN(NVFUFUSEYRF a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E0D0", Offset = "0x8D3C6D0", VA = "0x188D3E0D0")]
		private ZTDIGAYZRAK KHMINVZLKTM(NVFUFUSEYRF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DB70", Offset = "0x8D3C170", VA = "0x188D3DB70")]
		[AsyncStateMachine(typeof(<RunOperation>d__15))]
		private Task ESNINFDUZCG(YARKOAWAUMF a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E150", Offset = "0x8D3C750", VA = "0x188D3E150")]
		private YARKOAWAUMF NFDGVQJZBHQ(NVFUFUSEYRF a, ZTDIGAYZRAK b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x3D100F0", Offset = "0x3D0E6F0", VA = "0x183D100F0")]
		private a QGJYPSUMPLC<a>(a a) where a : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DC90", Offset = "0x8D3C290", VA = "0x188D3DC90")]
		private YARKOAWAUMF GVKXMQSITGN(NVFUFUSEYRF a, ZTDIGAYZRAK b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RoomManagerReceiveOperation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerRequestHandler : MNIGGUQIBYU, JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		[CompilerGenerated]
		private sealed class WJVBAJGMONG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			public byte EPAIYJERPCN;

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public WJVBAJGMONG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x8D581C0", Offset = "0x8D567C0", VA = "0x188D581C0")]
			internal object SLURYFLCEOW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		[CompilerGenerated]
		private sealed class TYGMGLNVTBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			public Guid OZZPRBWJRPS;

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TYGMGLNVTBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x8D422B0", Offset = "0x8D408B0", VA = "0x188D422B0")]
			internal object EKXSTCFPGRB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private LRJLKNGLINT IXSJEENOFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private AZGXKHQUXAQ HPROUHKSIVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private CNMXIHSKTKR DNNJHAFLRES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private AXARZMWEGGY YTZXMPXBXYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private JSTLAQOJGMG ARRNHALSYWH;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EEC0", Offset = "0x8D3D4C0", VA = "0x188D3EEC0", Slot = "6")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EB10", Offset = "0x8D3D110", VA = "0x188D3EB10", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FFD0", Offset = "0x8D3E5D0", VA = "0x188D3FFD0", Slot = "4")]
		public PendingRequest YTDWBMTVLFO(NVFUFUSEYRF a)
		{
			return default(PendingRequest);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F030", Offset = "0x8D3D630", VA = "0x188D3F030", Slot = "5")]
		public void LJSRKRVAFIH(Guid a, Task b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EBB0", Offset = "0x8D3D1B0", VA = "0x188D3EBB0")]
		private void EFDVNTPAGXB(KMNYUBYLMOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F230", Offset = "0x8D3D830", VA = "0x188D3F230")]
		private void PECDVNHNSOG(OperationEventData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FB80", Offset = "0x8D3E180", VA = "0x188D3FB80")]
		private void UPPFEYJPBMC(OperationEventData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F780", Offset = "0x8D3DD80", VA = "0x188D3F780")]
		private void PIULHQSTJCD(OperationEventData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E8E0", Offset = "0x8D3CEE0", VA = "0x188D3E8E0")]
		private EARYEWOAMEK DKLONOZYEOO(NVFUFUSEYRF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FDE0", Offset = "0x8D3E3E0", VA = "0x188D3FDE0")]
		private void XSKSYLGHIJM(NVFUFUSEYRF a, EARYEWOAMEK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F9B0", Offset = "0x8D3DFB0", VA = "0x188D3F9B0")]
		private bool UGLVDZLEJXX(NVFUFUSEYRF a, EARYEWOAMEK b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8D3ECC0", Offset = "0x8D3D2C0", VA = "0x188D3ECC0")]
		private bool EVGFYKZURPD(NVFUFUSEYRF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x8D403C0", Offset = "0x8D3E9C0", VA = "0x188D403C0")]
		private bool ZEBOACKGUNS(byte a, ExitGames.Client.Photon.Hashtable b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RoomManagerRequestHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerRequestOperation : DMXHYWHBOPH, JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		[CompilerGenerated]
		private sealed class RPGDRVSGBNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D0")]
			public RoomOperationType XPCCPHBCRDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002D1")]
			public RoomManagerRequestOperation CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			public NVFUFUSEYRF YMIVCZSFZTF;

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public RPGDRVSGBNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x8D3A470", Offset = "0x8D38A70", VA = "0x188D3A470")]
			internal object TTLVLOWVTDN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x8D3A350", Offset = "0x8D38950", VA = "0x188D3A350")]
			internal object TTGOOICYJSE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		[CompilerGenerated]
		private sealed class SSSKYROOASY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			public RoomOperationType XPCCPHBCRDH;

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SSSKYROOASY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x8D42040", Offset = "0x8D40640", VA = "0x188D42040")]
			internal object HJVNUETXGAI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private sealed class OGOKSBBDBET
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public NVFUFUSEYRF IPZSVHKCSSN;

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OGOKSBBDBET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x8D39A70", Offset = "0x8D38070", VA = "0x188D39A70")]
			internal object TDBTGUGNNGH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x8D39A00", Offset = "0x8D38000", VA = "0x188D39A00")]
			internal object TCWMJNMQDUY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x8D39AE0", Offset = "0x8D380E0", VA = "0x188D39AE0")]
			internal object TDMHBHUIGCZ()
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
			public AsyncTaskMethodBuilder<EARYEWOAMEK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			public RoomManagerRequestOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			public NVFUFUSEYRF roomOperationMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			private TaskAwaiter<EARYEWOAMEK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x8D4F1F0", Offset = "0x8D4D7F0", VA = "0x188D4F1F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x8D4F870", Offset = "0x8D4DE70", VA = "0x188D4F870", Slot = "5")]
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
			public AsyncTaskMethodBuilder<EARYEWOAMEK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public NVFUFUSEYRF request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			public RoomManagerRequestOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			private OGOKSBBDBET <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private PendingRequest <pendingRequest>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			private EARYEWOAMEK <result>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			private TaskAwaiter<(EARYEWOAMEK validationResult, Task operation)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x8D4F8E0", Offset = "0x8D4DEE0", VA = "0x188D4F8E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x8D50290", Offset = "0x8D4E890", VA = "0x188D50290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private LRJLKNGLINT IXSJEENOFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private AZGXKHQUXAQ HPROUHKSIVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private MNIGGUQIBYU EGTPZURXDHV;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8D40600", Offset = "0x8D3EC00", VA = "0x188D40600", Slot = "5")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x8D409D0", Offset = "0x8D3EFD0", VA = "0x188D409D0", Slot = "4")]
		[AsyncStateMachine(typeof(<RecRoom-RoomLoading-IRoomManagerRequestOperation-RequestOperation>d__4))]
		private Task<EARYEWOAMEK> XDCGWNSXWXZ(NVFUFUSEYRF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x8D407F0", Offset = "0x8D3EDF0", VA = "0x188D407F0")]
		private bool ODYVASLKVAS(RoomOperationType a, [Out] EARYEWOAMEK b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8D406B0", Offset = "0x8D3ECB0", VA = "0x188D406B0")]
		[AsyncStateMachine(typeof(<RequestOperationInternal>d__7))]
		private Task<EARYEWOAMEK> MDVSDDTRXXN(NVFUFUSEYRF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RoomManagerRequestOperation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal sealed class RoomManagerRoomLoadRequest : JUUVKXCVYPT, JZTTLQQFTLE, IDisposable
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
		private sealed class TBDIAOPJOEZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public Stopwatch VESZOCIBSRY;

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TBDIAOPJOEZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x8D42210", Offset = "0x8D40810", VA = "0x188D42210")]
			internal object LCXQTTXXUBH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		[CompilerGenerated]
		private sealed class OGOKSBBDBET
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public Stopwatch VESZOCIBSRY;

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OGOKSBBDBET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x8D39960", Offset = "0x8D37F60", VA = "0x188D39960")]
			internal object NSBLNDHKIOT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C4")]
		[CompilerGenerated]
		private sealed class PMCLZVAKTMZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public long ZXDMIWAEXTS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			public RoomDetailsDTO NWYNBYUIUJC;

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public PMCLZVAKTMZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x13BC090", Offset = "0x13BA690", VA = "0x1813BC090")]
			internal bool OZOCICTLGIQ(SubRoomDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x8D39DF0", Offset = "0x8D383F0", VA = "0x188D39DF0")]
			internal object PAJDXDVASCA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x8D39D10", Offset = "0x8D38310", VA = "0x188D39D10")]
			internal object OZTJFJNIPTZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x8D39D80", Offset = "0x8D38380", VA = "0x188D39D80")]
			internal object OZYQCQHFZFI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		[CompilerGenerated]
		private sealed class PLXFCOGNKBQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			public bool TXVGKNVVPPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			public PMCLZVAKTMZ GOOXOIYUWOV;

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public PLXFCOGNKBQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x8D39BB0", Offset = "0x8D381B0", VA = "0x188D39BB0")]
			internal object PADWZXBDIQR()
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
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

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
			private TBDIAOPJOEZ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			private TaskAwaiter<SubRoomDataSaveDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x8D47DE0", Offset = "0x8D463E0", VA = "0x188D47DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x8D484A0", Offset = "0x8D46AA0", VA = "0x188D484A0", Slot = "5")]
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
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			private PLXFCOGNKBQ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			private TaskAwaiter<ResolvedLoadParameters> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			private TaskAwaiter<RoomLoadDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x8D48510", Offset = "0x8D46B10", VA = "0x188D48510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x8D49400", Offset = "0x8D47A00", VA = "0x188D49400", Slot = "5")]
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
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

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
			private OGOKSBBDBET <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x8D49470", Offset = "0x8D47A70", VA = "0x188D49470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x8D49A50", Offset = "0x8D48050", VA = "0x188D49A50", Slot = "5")]
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
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

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

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x8D4A000", Offset = "0x8D48600", VA = "0x188D4A000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x8D4A5D0", Offset = "0x8D48BD0", VA = "0x188D4A5D0", Slot = "5")]
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
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			private TaskAwaiter<ResolvedLoadParameters> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x8D49AC0", Offset = "0x8D480C0", VA = "0x188D49AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x8D49F90", Offset = "0x8D48590", VA = "0x188D49F90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private TPICXMNKDPD FZDXDPPJXPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private LBYYQBWWZWZ PRCZNZUSLCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private SLGKQDZWFPJ NNEAWPHHSGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private HWQFGVTKLKB CCJYTRMKWUY;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x8D40F30", Offset = "0x8D3F530", VA = "0x188D40F30", Slot = "5")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D40AF0", Offset = "0x8D3F0F0", VA = "0x188D40AF0", Slot = "4")]
		[AsyncStateMachine(typeof(<GetRoomLoadRequestPayload>d__6))]
		public Task<RoomLoadRequestPayload> BTXNAEGEAMO(StackTimer<string>.ERYHZSBUWXZ a, RoomInstance b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x8D41020", Offset = "0x8D3F620", VA = "0x188D41020")]
		[AsyncStateMachine(typeof(<GetRoomDetails>d__7))]
		private Task<RoomDetailsDTO> JSFKOBRASHZ(RoomInstance a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8D41180", Offset = "0x8D3F780", VA = "0x188D41180")]
		[AsyncStateMachine(typeof(<GetRoomLoadRequestPayloadFromDetailsAndSubroom>d__8))]
		private Task<RoomLoadRequestPayload> UPXTFHKTLKO(RoomInstance a, RoomDetailsDTO b, long c, StackTimer<string>.ERYHZSBUWXZ d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x8D40C50", Offset = "0x8D3F250", VA = "0x188D40C50")]
		[AsyncStateMachine(typeof(<GetRoomDataBlobWithHashForRoomDetails>d__9))]
		private Task<ResolvedLoadParameters> FWEKUWJKZNA(RoomInstance a, RoomDetailsDTO b, long c, StackTimer<string>.ERYHZSBUWXZ d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x8D40DC0", Offset = "0x8D3F3C0", VA = "0x188D40DC0")]
		[AsyncStateMachine(typeof(<GetDefaultRoomDataBlobWithHashForDorms>d__10))]
		private Task<ResolvedLoadParameters> HZEJQMTEVWN(RoomInstance a, SubRoomDTO b, long c, StackTimer<string>.ERYHZSBUWXZ d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RoomManagerRoomLoadRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerSynchronization : LHYKYYCLXTH, JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class TBDIAOPJOEZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public NVFUFUSEYRF IPZSVHKCSSN;

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TBDIAOPJOEZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x8D421B0", Offset = "0x8D407B0", VA = "0x188D421B0")]
			internal object JXRALVBPBPO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		[CompilerGenerated]
		private sealed class SSSKYROOASY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			public NVFUFUSEYRF IPZSVHKCSSN;

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SSSKYROOASY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x8D41FE0", Offset = "0x8D405E0", VA = "0x188D41FE0")]
			internal object ARGCQMULKTD()
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
			public AsyncTaskMethodBuilder<NVFUFUSEYRF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public NVFUFUSEYRF request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public RoomManagerSynchronization <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public ZTDIGAYZRAK pauseToken;

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
			private HKSUWPOFRQX <masterSwitchCancellationScope>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x8D4BD60", Offset = "0x8D4A360", VA = "0x188D4BD60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x8D4C900", Offset = "0x8D4AF00", VA = "0x188D4C900", Slot = "5")]
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
			public AsyncTaskMethodBuilder<NVFUFUSEYRF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public NVFUFUSEYRF request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public RoomManagerSynchronization <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public ZTDIGAYZRAK pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private TaskAwaiter<NVFUFUSEYRF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x8D4C970", Offset = "0x8D4AF70", VA = "0x188D4C970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x8D4CF70", Offset = "0x8D4B570", VA = "0x188D4CF70", Slot = "5")]
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
			public AsyncTaskMethodBuilder<NVFUFUSEYRF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public RoomManagerSynchronization <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public ZTDIGAYZRAK pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x8D4EBB0", Offset = "0x8D4D1B0", VA = "0x188D4EBB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x8D4F180", Offset = "0x8D4D780", VA = "0x188D4F180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private LRJLKNGLINT IXSJEENOFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private FTYIAWFEMJP QWKBPIJABIS;

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		private VDQCZZZDVQV VDQCZZZDVQV
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x8D41950", Offset = "0x8D3FF50", VA = "0x188D41950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8D416C0", Offset = "0x8D3FCC0", VA = "0x188D416C0", Slot = "8")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8D41750", Offset = "0x8D3FD50", VA = "0x188D41750", Slot = "4")]
		[AsyncStateMachine(typeof(<MasterSynchronizeRequest>d__6))]
		public Task<NVFUFUSEYRF> LSNAGKNRHBX(NVFUFUSEYRF a, ZTDIGAYZRAK b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x8D41410", Offset = "0x8D3FA10", VA = "0x188D41410", Slot = "5")]
		[AsyncStateMachine(typeof(<PopNextBufferedEvent>d__7))]
		public Task<NVFUFUSEYRF> CSEHBPHJQMD(CancellationToken a, ZTDIGAYZRAK b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x8D418B0", Offset = "0x8D3FEB0", VA = "0x188D418B0", Slot = "6")]
		public TRMFSAPCCPK MJGXYAYSJKU(YARKOAWAUMF a, StackTimer<string>.ERYHZSBUWXZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8D412F0", Offset = "0x8D3F8F0", VA = "0x188D412F0", Slot = "7")]
		public TRMFSAPCCPK BODVSIDAEGP(YARKOAWAUMF a, StackTimer<string>.ERYHZSBUWXZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D41560", Offset = "0x8D3FB60", VA = "0x188D41560")]
		[AsyncStateMachine(typeof(<MasterSyncRequestAndValidateResponse>d__10))]
		private Task<NVFUFUSEYRF> IKNBGTYQQXY(NVFUFUSEYRF a, ZTDIGAYZRAK b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x3D61780", Offset = "0x3D5FD80", VA = "0x183D61780")]
		private static byte[] TSRSWAWUXRH(NVFUFUSEYRF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RoomManagerSynchronization()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerValidation : AZGXKHQUXAQ, JZTTLQQFTLE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private XYQALRWHLAK WLZWFLRGQRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private LRJLKNGLINT IXSJEENOFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private FCNDFENYFYI CVJFRYMBCOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private XZQIURVFMKK KUMYIEKPRKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private TPICXMNKDPD FZDXDPPJXPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private LCVPVCCAVNQ EGPJMIODNOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private BYXYINOYSGX ZQNBJHCBRSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private LBYYQBWWZWZ PRCZNZUSLCW;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private KEWSLRECSSV VXTOLEXPLIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x8D41B90", Offset = "0x8D40190", VA = "0x188D41B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private static EARYEWOAMEK YOJOGJEJSGP
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x8D41FD0", Offset = "0x8D405D0", VA = "0x188D41FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x8D41A10", Offset = "0x8D40010", VA = "0x188D41A10", Slot = "6")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x8D41E60", Offset = "0x8D40460", VA = "0x188D41E60", Slot = "4")]
		public EARYEWOAMEK VSBHYHNOOLW(LRIABUPBGVB a, RoomOperationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D41BE0", Offset = "0x8D401E0", VA = "0x188D41BE0", Slot = "5")]
		public EARYEWOAMEK TYGDUTTHEXZ(LRIABUPBGVB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8D41B80", Offset = "0x8D40180", VA = "0x188D41B80")]
		private static EARYEWOAMEK PRSWFUPMRIE(ValidationReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RoomManagerValidation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class RoomOperationAlreadyInProgressException : InvalidOperationException
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x8D625F0", Offset = "0x8D60BF0", VA = "0x188D625F0")]
		public RoomOperationAlreadyInProgressException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7EAAF00", Offset = "0x7EA9500", VA = "0x187EAAF00")]
		public RoomOperationAlreadyInProgressException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerAutosaves : DIBPULMATLA, JZTTLQQFTLE, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x8D65A70", Offset = "0x8D64070", VA = "0x188D65A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x8D65EE0", Offset = "0x8D644E0", VA = "0x188D65EE0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<EARYEWOAMEK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public NJHMYSMXXYI autosaveRecordInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private StackTimer<string> <timer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private StackTimer<string>.ERYHZSBUWXZ <timerScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			private VQZKCNJSKSK <operation>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			private TaskAwaiter<EARYEWOAMEK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x8D68500", Offset = "0x8D66B00", VA = "0x188D68500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x8D68EC0", Offset = "0x8D674C0", VA = "0x188D68EC0", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x8D6EAD0", Offset = "0x8D6D0D0", VA = "0x188D6EAD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x8D6F040", Offset = "0x8D6D640", VA = "0x188D6F040", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E580", Offset = "0x8D6CB80", VA = "0x188D6E580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x8D6EA70", Offset = "0x8D6D070", VA = "0x188D6EA70", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x8D6DD70", Offset = "0x8D6C370", VA = "0x188D6DD70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E520", Offset = "0x8D6CB20", VA = "0x188D6E520", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x8D6F660", Offset = "0x8D6DC60", VA = "0x188D6F660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x8D6FD90", Offset = "0x8D6E390", VA = "0x188D6FD90", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x8D6F460", Offset = "0x8D6DA60", VA = "0x188D6F460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x8D6F600", Offset = "0x8D6DC00", VA = "0x188D6F600", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x8D72A00", Offset = "0x8D71000", VA = "0x188D72A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x8D73100", Offset = "0x8D71700", VA = "0x188D73100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private LRJLKNGLINT IXSJEENOFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private NIJQVUPMTTA VHJCBTPFZBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private TPICXMNKDPD FZDXDPPJXPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private LHYKYYCLXTH IOCBFPWDUPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private FCNDFENYFYI CVJFRYMBCOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private BYXYINOYSGX ZQNBJHCBRSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private CancellationTokenSource VZDGGYIVQVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private Task OXEPBIFGORG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private TaskCompletionSource<int> IHACBKWEJKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private int KCJPUQQDAHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private int ZRWCQOHSTAP;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x8D61220", Offset = "0x8D5F820", VA = "0x188D61220", Slot = "6")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x15FB840", Offset = "0x15F9E40", VA = "0x1815FB840", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x8D615C0", Offset = "0x8D5FBC0", VA = "0x188D615C0")]
		private void PEZXNQEEWCG(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x8D616A0", Offset = "0x8D5FCA0", VA = "0x188D616A0", Slot = "4")]
		[AsyncStateMachine(typeof(<RequestRestoreAutosave>d__14))]
		public Task<EARYEWOAMEK> RequestRestoreAutosave(NJHMYSMXXYI autosaveRecordInfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x8D61C40", Offset = "0x8D60240", VA = "0x188D61C40", Slot = "5")]
		[AsyncStateMachine(typeof(<RunRecoveryAutosave>d__15))]
		public Task VKSOUGJPJSU([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x15FB840", Offset = "0x15F9E40", VA = "0x1815FB840")]
		public void EWSDGVMMRHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x8D61E30", Offset = "0x8D60430", VA = "0x188D61E30")]
		private VQZKCNJSKSK ZCYFAXLJQUF(NJHMYSMXXYI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x8D61B50", Offset = "0x8D60150", VA = "0x188D61B50")]
		[AsyncStateMachine(typeof(<RunAutosaveRoutine>d__18))]
		private Task UQELIVLSGTD(CancellationToken a, int b, AccountRoleType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x8D61D30", Offset = "0x8D60330", VA = "0x188D61D30")]
		[AsyncStateMachine(typeof(<RunAutosaveRoutineInternal>d__19))]
		private Task WKQJXITUUHW(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x8D613D0", Offset = "0x8D5F9D0", VA = "0x188D613D0")]
		[AsyncStateMachine(typeof(<RunRecoveryAutosaveInternal>d__20))]
		private Task KBIOUKLHIGZ([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x8D60FA0", Offset = "0x8D5F5A0", VA = "0x188D60FA0")]
		[AsyncStateMachine(typeof(<ScheduleIncrementalAutosave>d__21))]
		private Task DMSHBWJIYLH(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x8D614C0", Offset = "0x8D5FAC0", VA = "0x188D614C0")]
		[AsyncStateMachine(typeof(<AwaitAutosaveInterval>d__22))]
		private Task MTSNSRGXJOR(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x8D61090", Offset = "0x8D5F690", VA = "0x188D61090")]
		private Task HSRGCOLQNOE(AutosaveType a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x8D617D0", Offset = "0x8D5FDD0", VA = "0x188D617D0")]
		[AsyncStateMachine(typeof(<RunAutosave>d__24))]
		private Task RunAutosave(AutosaveType autosaveType, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x8D618E0", Offset = "0x8D5FEE0", VA = "0x188D618E0")]
		private bool TSKEADJNFVA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RoomManagerAutosaves()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomManagerSave : XZQIURVFMKK, JZTTLQQFTLE, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x8D68F30", Offset = "0x8D67530", VA = "0x188D68F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x8D694B0", Offset = "0x8D67AB0", VA = "0x188D694B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private FXIAJRDWWMG IXJLZJQRBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private NIJQVUPMTTA VHJCBTPFZBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private AZGXKHQUXAQ HPROUHKSIVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private LHYKYYCLXTH IOCBFPWDUPO;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x8D620A0", Offset = "0x8D606A0", VA = "0x188D620A0", Slot = "6")]
		public void Initialize(NIJQVUPMTTA roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x8D62050", Offset = "0x8D60650", VA = "0x188D62050", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x8D62370", Offset = "0x8D60970", VA = "0x188D62370", Slot = "5")]
		[AsyncStateMachine(typeof(<RequestSaveRoomToDisk>d__6))]
		public Task RequestSaveRoomToDisk(string path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x8D62470", Offset = "0x8D60A70", VA = "0x188D62470", Slot = "4")]
		public EARYEWOAMEK TSKEADJNFVA(LRIABUPBGVB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x8D624D0", Offset = "0x8D60AD0", VA = "0x188D624D0")]
		private EHOJCCBZYUH TZRSCYWWLTM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RoomManagerSave()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public static class TEILEWXIWAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x8D631A0", Offset = "0x8D617A0", VA = "0x188D631A0")]
		public static void KIDKGIBTHYE(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x8D633E0", Offset = "0x8D619E0", VA = "0x188D633E0")]
		internal static void NYNVAFYPMML(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x8D63540", Offset = "0x8D61B40", VA = "0x188D63540")]
		internal static void UEBWIXGXWYA(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x8D62D70", Offset = "0x8D61370", VA = "0x188D62D70")]
		internal static void JHWMLSZWHXI(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x3D5E280", Offset = "0x3D5C880", VA = "0x183D5E280")]
		private static void UKURLQQTDMO<a, b, a>(KUXAUVMITFU a) where b : a
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	internal class IVIAUTMYYPN : LTMODIKDDFX<NVFUFUSEYRF>
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class XMEHEWGCGRP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public NVFUFUSEYRF MPZKLQFYNSH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public string PQCOQGBRCRV;

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public XMEHEWGCGRP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x8D74310", Offset = "0x8D72910", VA = "0x188D74310")]
			internal object EQCIVLNPSOY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly IVIAUTMYYPN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x8D5C5E0", Offset = "0x8D5ABE0", VA = "0x188D5C5E0")]
		public ExitGames.Client.Photon.Hashtable Serialize(NVFUFUSEYRF message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8D5C900", Offset = "0x8D5AF00", VA = "0x188D5C900", Slot = "5")]
		protected override void XINWQEWELQG(NVFUFUSEYRF a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x8D5C2B0", Offset = "0x8D5A8B0", VA = "0x188D5C2B0", Slot = "6")]
		public override NVFUFUSEYRF Deserialize(IDictionary<object, object> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x8D5C4E0", Offset = "0x8D5AAE0", VA = "0x188D5C4E0")]
		private static void Log(string op, NVFUFUSEYRF message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x8D5CAC0", Offset = "0x8D5B0C0", VA = "0x188D5CAC0")]
		public IVIAUTMYYPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x8D5C660", Offset = "0x8D5AC60", VA = "0x188D5C660")]
		[CompilerGenerated]
		internal static string VQCTXLSDQAV(RoomLoadRequestPayload a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public static class JBELYXZBTXP
	{
		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public static EARYEWOAMEK YOJOGJEJSGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x8D5D560", Offset = "0x8D5BB60", VA = "0x188D5D560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x8D5D4E0", Offset = "0x8D5BAE0", VA = "0x188D5D4E0")]
		public static bool CXVGOWKLFVV(this EARYEWOAMEK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x8D5D500", Offset = "0x8D5BB00", VA = "0x188D5D500")]
		public static EARYEWOAMEK PRSWFUPMRIE(ValidationReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x8D5D5C0", Offset = "0x8D5BBC0", VA = "0x188D5D5C0")]
		public static EARYEWOAMEK YLJILFEJVHZ(IEnumerable<EARYEWOAMEK> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x8D5D2A0", Offset = "0x8D5B8A0", VA = "0x188D5D2A0")]
		public static string BKGSCRPOBEG(this EARYEWOAMEK a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public abstract class LCMFJDZYGDA : PNTVQUBKEHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		public delegate EARYEWOAMEK ValidateOperation([NotNull] LRIABUPBGVB networkPlayer);

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class SSSKYROOASY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public LRIABUPBGVB IZHYAZJLBJZ;

			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SSSKYROOASY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x18E2A80", Offset = "0x18E1080", VA = "0x1818E2A80")]
			internal EARYEWOAMEK ZGLDSVXANUU(ValidateOperation a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private bool MFRVCTFDCZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		protected readonly HashSet<ValidateOperation> NCXATZJGPLF;

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x8D5F960", Offset = "0x8D5DF60", VA = "0x188D5F960", Slot = "4")]
		public void TOVQIESRBJX(ValidateOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x8D5F630", Offset = "0x8D5DC30", VA = "0x188D5F630", Slot = "5")]
		public void CPHFVOBZHWU(ValidateOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x8D5F690", Offset = "0x8D5DC90", VA = "0x188D5F690", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x8D5F6E0", Offset = "0x8D5DCE0", VA = "0x188D5F6E0")]
		protected EARYEWOAMEK HVKCTUNFHKG(LRIABUPBGVB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x8D5F9C0", Offset = "0x8D5DFC0", VA = "0x188D5F9C0")]
		protected LCMFJDZYGDA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public class WMUJYGELNHP : LCMFJDZYGDA, XYQALRWHLAK, PNTVQUBKEHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class MVZLYDKGBFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public EARYEWOAMEK GIFPSKZVKYB;

			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public MVZLYDKGBFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x8D5FE00", Offset = "0x8D5E400", VA = "0x188D5FE00")]
			internal object DUCEQAPRVRO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x8D5FD90", Offset = "0x8D5E390", VA = "0x188D5FD90")]
		[UnityEngine.Scripting.Preserve]
		public WMUJYGELNHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x8D74210", Offset = "0x8D72810", VA = "0x188D74210", Slot = "8")]
		public EARYEWOAMEK SFXGRMYYGYS(LRIABUPBGVB a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public class LXJMAGNWWUF : LCMFJDZYGDA, FXIAJRDWWMG, PNTVQUBKEHD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		[CompilerGenerated]
		private sealed class MVZLYDKGBFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public EARYEWOAMEK GIFPSKZVKYB;

			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public MVZLYDKGBFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x8D5FE60", Offset = "0x8D5E460", VA = "0x188D5FE60")]
			internal object WNMOTKQMOWE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x8D5FD90", Offset = "0x8D5E390", VA = "0x188D5FD90")]
		[UnityEngine.Scripting.Preserve]
		public LXJMAGNWWUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x8D5FC90", Offset = "0x8D5E290", VA = "0x188D5FC90", Slot = "8")]
		public EARYEWOAMEK TSKEADJNFVA(LRIABUPBGVB a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	internal static class LKSTQJZWWJL
	{
		[Cpp2IlInjected.Token(Token = "0x20000EE")]
		[CompilerGenerated]
		private sealed class SSSKYROOASY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public StackTimer<string> TYIPCZXJUDT;

			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SSSKYROOASY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0x8D62BB0", Offset = "0x8D611B0", VA = "0x188D62BB0")]
			internal object CRMLDZCUKTU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x8D5FA40", Offset = "0x8D5E040", VA = "0x188D5FA40")]
		public static StackTimer<string> ERYHZSBUWXZ(Log a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x8D5FBD0", Offset = "0x8D5E1D0", VA = "0x188D5FBD0")]
		public static void ORFIZYVZJHC(StackTimer<string> a, Log b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x8D5FB10", Offset = "0x8D5E110", VA = "0x188D5FB10")]
		public static string KWENPZCQXRD(NVFUFUSEYRF a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	internal static class SWYQQJDGKQY
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x8D62D50", Offset = "0x8D61350", VA = "0x188D62D50")]
		public static void NKXIPKGBUTN(this LRJLKNGLINT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x8D62D60", Offset = "0x8D61360", VA = "0x188D62D60")]
		public static void PCRBWBYBAXO(this LRJLKNGLINT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x8D62C30", Offset = "0x8D61230", VA = "0x188D62C30")]
		private static void MGEPKCIBNXS(this LRJLKNGLINT a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public class DGXDSPXINWB : QEFSHYPRWFN, HICUPWZNCRO, YYJRECEXABT, JXTMYJLBPME
	{
		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		private class NLFACTEAJXD : KMNYUBYLMOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			private readonly byte UUHAAUCGUXX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			private readonly int IPALOQFUWKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			private readonly object DNFUXQOZHLJ;

			[Cpp2IlInjected.Token(Token = "0x170000CC")]
			public byte JCAQGEWAOFT
			{
				[Cpp2IlInjected.Token(Token = "0x600046B")]
				[Cpp2IlInjected.Address(RVA = "0xAFA810", Offset = "0xAF8E10", VA = "0x180AFA810", Slot = "4")]
				get
				{
					return default(byte);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CD")]
			public int MELQJXGPJAV
			{
				[Cpp2IlInjected.Token(Token = "0x600046C")]
				[Cpp2IlInjected.Address(RVA = "0xC071B0", Offset = "0xC057B0", VA = "0x180C071B0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CE")]
			public object RDOUNCXBMRJ
			{
				[Cpp2IlInjected.Token(Token = "0x600046D")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			public object this[byte key]
			{
				[Cpp2IlInjected.Token(Token = "0x600046E")]
				[Cpp2IlInjected.Address(RVA = "0x8D60040", Offset = "0x8D5E640", VA = "0x188D60040", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x7EB23F0", Offset = "0x7EB09F0", VA = "0x187EB23F0")]
			public NLFACTEAJXD(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x8D60000", Offset = "0x8D5E600", VA = "0x188D60000", Slot = "8")]
			public bool ZKJFYFPTSEI(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private readonly HICUPWZNCRO CVJGKVMYRZI;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public LRIABUPBGVB MWFWHJISHRM
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x8D59720", Offset = "0x8D57D20", VA = "0x188D59720", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public int CEQSIFBJLUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x8D59770", Offset = "0x8D57D70", VA = "0x188D59770", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public int NKGCJSYPLDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x8D597C0", Offset = "0x8D57DC0", VA = "0x188D597C0", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public LRIABUPBGVB OJYVFBFKHGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x8D59810", Offset = "0x8D57E10", VA = "0x188D59810", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool SQPIDTYDNKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public int FSLGJJKUOVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string VFFMJFAUHPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x8D59350", Offset = "0x8D57950", VA = "0x188D59350", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Func<string, string> TWHAMMEMUFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x8D591F0", Offset = "0x8D577F0", VA = "0x188D591F0", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<string, long> EXUPCMEPHGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<KMNYUBYLMOF> JADLUJHYKBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x8D59670", Offset = "0x8D57C70", VA = "0x188D59670", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x8D59B70", Offset = "0x8D58170", VA = "0x188D59B70", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<bool> GFNIWAZSETB
		{
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "26")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "27")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<LRIABUPBGVB> AOECWXLSHVX
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "9")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action HVLIAXACQNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x8D593B0", Offset = "0x8D579B0", VA = "0x188D593B0", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x8D59A80", Offset = "0x8D58080", VA = "0x188D59A80", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x8D59610", Offset = "0x8D57C10", VA = "0x188D59610", Slot = "19")]
		public void OIWJOOSVADD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xF190C0", Offset = "0xF176C0", VA = "0x180F190C0")]
		public DGXDSPXINWB(HICUPWZNCRO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x8D59860", Offset = "0x8D57E60", VA = "0x188D59860", Slot = "8")]
		public bool RaiseEvent(byte eventCode, object eventContent, KAUBEGREKJA raiseEventOptions, RRNetworkDelivery networkDelivery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x8D592B0", Offset = "0x8D578B0", VA = "0x188D592B0", Slot = "20")]
		public LRIABUPBGVB DNCAMOEVDPX(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x8D599A0", Offset = "0x8D57FA0", VA = "0x188D599A0", Slot = "21")]
		public LRIABUPBGVB SFXJGGUGRGT(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x8D59530", Offset = "0x8D57B30", VA = "0x188D59530", Slot = "22")]
		public LRIABUPBGVB NFVPIIQPSWR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x8D59450", Offset = "0x8D57A50", VA = "0x188D59450", Slot = "23")]
		public IReadOnlyList<LRIABUPBGVB> JHFUMHTVXIR(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x8D59960", Offset = "0x8D57F60", VA = "0x188D59960", Slot = "24")]
		public IReadOnlyList<LRIABUPBGVB> SCHANGSOPCC(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "25")]
		public bool EYHVMJXQPTD(LRIABUPBGVB a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "28")]
		public void ESPPUDNRXWU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "29")]
		public void YSYMROYVZSD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "30")]
		public void WPFPYICZCPR(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x8D59B20", Offset = "0x8D58120", VA = "0x188D59B20", Slot = "31")]
		public IDisposable UNFJHZGXGQE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "32")]
		private bool VRNWVOECNGT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "33")]
		public void GGVVZGHSXWT(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x115F670", Offset = "0x115DC70", VA = "0x18115F670", Slot = "34")]
		public bool JPBOSRAIWOW(bool a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x10F93C0", Offset = "0x10F79C0", VA = "0x1810F93C0", Slot = "37")]
		public void AHOKYVLRRAH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	internal struct OperationEventData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private readonly IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
		public OperationEventData(IDictionary<object, object> eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x8D60430", Offset = "0x8D5EA30", VA = "0x188D60430")]
		public bool ETBTNEQMRKP([Out] NVFUFUSEYRF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x8D604E0", Offset = "0x8D5EAE0", VA = "0x188D604E0")]
		public Guid UHGTBBEHAGE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x8D60590", Offset = "0x8D5EB90", VA = "0x188D60590")]
		public EARYEWOAMEK WRNWOVPRRUK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x8D60340", Offset = "0x8D5E940", VA = "0x188D60340")]
		public static ExitGames.Client.Photon.Hashtable Create(NVFUFUSEYRF message, EARYEWOAMEK validationResult)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	internal static class CTIRUBSCZOS
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x8D58770", Offset = "0x8D56D70", VA = "0x188D58770")]
		public static bool SOLSTZDAKJJ(this RoomInstance a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	internal struct TaskRunner : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		[CompilerGenerated]
		private struct <RunTasks>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public Func<CancellationToken, List<Task>> taskGenerator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public TaskRunner <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0x8D6FDF0", Offset = "0x8D6E3F0", VA = "0x188D6FDF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0x8D6FFD0", Offset = "0x8D6E5D0", VA = "0x188D6FFD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private readonly CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private bool isDisposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private Task task;

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public bool HFYUEIOIRYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x8D65910", Offset = "0x8D63F10", VA = "0x188D65910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x8D65940", Offset = "0x8D63F40", VA = "0x188D65940")]
		public TaskRunner(CancellationToken cancellationToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x8D657B0", Offset = "0x8D63DB0", VA = "0x188D657B0")]
		[AsyncStateMachine(typeof(<RunTasks>d__8))]
		public Task DZAXRJTJWPP(Func<CancellationToken, List<Task>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x8D658C0", Offset = "0x8D63EC0", VA = "0x188D658C0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public readonly struct VersionedDataGetter<TGetDataArg, TData>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		[CompilerGenerated]
		private struct <DownloadAndParse>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			public AsyncTaskMethodBuilder<Result<ParseResult<TData>, VMQHICPCFYT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public StackTimer<string>.ERYHZSBUWXZ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public string timerName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public VersionedDataGetter<TGetDataArg, TData> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public TGetDataArg arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			private TaskAwaiter<Result<ParseResult<TData>, VMQHICPCFYT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0x5021E10", Offset = "0x5020410", VA = "0x185021E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0x50224D0", Offset = "0x5020AD0", VA = "0x1850224D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private readonly GPORBEJBVKL<TGetDataArg, TData> _deps;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
		internal VersionedDataGetter(GPORBEJBVKL<TGetDataArg, TData> deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x6843B10", Offset = "0x6842110", VA = "0x186843B10")]
		[AsyncStateMachine(typeof(VersionedDataGetter<, >.<DownloadAndParse>d__2))]
		public Task<Result<ParseResult<TData>, VMQHICPCFYT>> OOROQMKGOPK(TGetDataArg a, string b, StackTimer<string>.ERYHZSBUWXZ c, CancellationToken d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public static class MXXJAZUXSUK
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x38F35A0", Offset = "0x38F1BA0", VA = "0x1838F35A0")]
		public static VersionedDataGetter<TGetDataArg, TData> New<TGetDataArg, TData>(GPORBEJBVKL<TGetDataArg, TData> deps)
		{
			return default(VersionedDataGetter<TGetDataArg, TData>);
		}
	}
}
namespace RecRoom.RoomLoading.Errors
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public struct ErrorCode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public readonly int Code;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public readonly int? SubCode;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x5457510", Offset = "0x5455B10", VA = "0x185457510")]
		public ErrorCode(int code, [Optional] int? subCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A800", Offset = "0x8D58E00", VA = "0x188D5A800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public interface NMPALTAPESF<a> where a : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FABJXNCTMXY();

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NMPALTAPESF<a> NVZELUMXPWV(string a);

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NMPALTAPESF<a> QSJMBQODXZC(UserFriendlyErrorMessageBuilder<a> a);

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(Slot = "3")]
		NMPALTAPESF<a> KEHPMCSUSOH(int a);

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NMPALTAPESF<a> UWPFSQRNOZQ(int a, GetSubCode<a> b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public interface DWBHSWWZGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NMPALTAPESF<a> IVDICBKGJRE<a>() where a : Exception;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(Slot = "1")]
		UserFriendlyErrorInfo CBKZHJORNDZ(Exception a);

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ErrorCode QSJPXTCPVGD(Exception a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public delegate string UserFriendlyErrorMessageBuilder<in T>(T ex) where T : Exception;
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public delegate int GetSubCode<in T>(T ex) where T : Exception;
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	internal class HMPYVCJCGNQ : DWBHSWWZGAF
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		private delegate string UserFriendlyErrorMessageBuilder(Exception ex);

		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private delegate int GetSubCodeInternal(Exception ex);

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		private class Registration<T> : NMPALTAPESF<T> where T : notnull, Exception
		{
			[Cpp2IlInjected.Token(Token = "0x2000102")]
			[CompilerGenerated]
			private sealed class RPGDRVSGBNA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003CB")]
				public string FKEDKQHYVFH;

				[Cpp2IlInjected.Token(Token = "0x60004A8")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public RPGDRVSGBNA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004A9")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
				internal string AZDXIBSJZBT(Exception a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000103")]
			[CompilerGenerated]
			private sealed class XMEHEWGCGRP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003CC")]
				public UserFriendlyErrorMessageBuilder<T> UPNOGLPZIOU;

				[Cpp2IlInjected.Token(Token = "0x60004AA")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public XMEHEWGCGRP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004AB")]
				[Cpp2IlInjected.Address(RVA = "0x4088EF0", Offset = "0x40874F0", VA = "0x184088EF0")]
				internal string DWRAOMAOVRI(Exception a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[CompilerGenerated]
			private sealed class TYGMGLNVTBE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003CD")]
				public GetSubCode<T> SRKWTRUCZKT;

				[Cpp2IlInjected.Token(Token = "0x60004AC")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public TYGMGLNVTBE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004AD")]
				[Cpp2IlInjected.Address(RVA = "0x4088EF0", Offset = "0x40874F0", VA = "0x184088EF0")]
				internal int JGJQMWMIGJK(Exception a)
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			private readonly HMPYVCJCGNQ TSCVOBDXOGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			private readonly Type IVLSRHUCFCJ;

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x5F23E50", Offset = "0x5F22450", VA = "0x185F23E50")]
			internal Registration(HMPYVCJCGNQ errorRegistry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x5F23AD0", Offset = "0x5F220D0", VA = "0x185F23AD0", Slot = "4")]
			public void FABJXNCTMXY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x5F23B40", Offset = "0x5F22140", VA = "0x185F23B40", Slot = "5")]
			public NMPALTAPESF<T> NVZELUMXPWV(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x5F23C40", Offset = "0x5F22240", VA = "0x185F23C40", Slot = "6")]
			public NMPALTAPESF<T> QSJMBQODXZC(UserFriendlyErrorMessageBuilder<T> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x5F23B00", Offset = "0x5F22100", VA = "0x185F23B00", Slot = "7")]
			public NMPALTAPESF<T> KEHPMCSUSOH(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x5F23D40", Offset = "0x5F22340", VA = "0x185F23D40", Slot = "8")]
			public NMPALTAPESF<T> UWPFSQRNOZQ(int a, GetSubCode<T> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000105")]
		private class HNSLLEPHZBT<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private bool CUVNQDYRNBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private readonly List<Type> YYNMUMANUVT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			private readonly Dictionary<Type, a> WTYGWIDKXPW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			private readonly Dictionary<Type, int> CPUMNENEXKJ;

			[Cpp2IlInjected.Token(Token = "0x170000D1")]
			public IReadOnlyList<Type> UAURVNHSJRD
			{
				[Cpp2IlInjected.Token(Token = "0x60004B0")]
				[Cpp2IlInjected.Address(RVA = "0x511FA00", Offset = "0x511E000", VA = "0x18511FA00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x5120200", Offset = "0x511E800", VA = "0x185120200")]
			public HNSLLEPHZBT(Dictionary<Type, int> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x511F770", Offset = "0x511DD70", VA = "0x18511F770")]
			public void Add(Type key, a val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x511FC70", Offset = "0x511E270", VA = "0x18511FC70")]
			public bool HBGKLJJPGVG(Type a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x511FE10", Offset = "0x511E410", VA = "0x18511FE10")]
			public bool RCFYMJCVLYK(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x511FC40", Offset = "0x511E240", VA = "0x18511FC40")]
			public a Get(Type type)
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x511FEE0", Offset = "0x511E4E0", VA = "0x18511FEE0")]
			[CompilerGenerated]
			private int SBAIRWGXMOW(Type a, Type b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000107")]
		[CompilerGenerated]
		private sealed class DCAJRJVIQOI : IEnumerable<ErrorCode>, IEnumerable, IEnumerator<ErrorCode>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private ErrorCode MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public HMPYVCJCGNQ CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			private Exception DPJLVPQRCSZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public Exception WZYEVVSQNSI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			private IEnumerator<Exception> TPFONUYPLCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			private IEnumerator<ErrorCode> TPVJFPGHNKB;

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			private ErrorCode MKNTYPKUVYB
			{
				[Cpp2IlInjected.Token(Token = "0x60004BE")]
				[Cpp2IlInjected.Address(RVA = "0x1A080E0", Offset = "0x1A066E0", VA = "0x181A080E0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ErrorCode);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D3")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x8D58940", Offset = "0x8D56F40", VA = "0x188D58940", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0xB597F0", Offset = "0xB57DF0", VA = "0x180B597F0")]
			[DebuggerHidden]
			public DCAJRJVIQOI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x8D587F0", Offset = "0x8D56DF0", VA = "0x188D587F0", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x8D58AE0", Offset = "0x8D570E0", VA = "0x188D58AE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x8D589E0", Offset = "0x8D56FE0", VA = "0x188D589E0")]
			private void KPIRURCCWVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x8D58990", Offset = "0x8D56F90", VA = "0x188D58990")]
			private void KOSXCWUKUNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x8D58F90", Offset = "0x8D57590", VA = "0x188D58F90", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x8D58A30", Offset = "0x8D57030", VA = "0x188D58A30", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ErrorCode> SXBIHRXETLM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x8D58A30", Offset = "0x8D57030", VA = "0x188D58A30", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly ErrorCode PPIJGKAGGEK;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private static readonly Dictionary<Type, int> KXQFZDHIPPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private readonly HashSet<Type> FVJNGXOBICP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private readonly HNSLLEPHZBT<int> YCDRKOMERNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private readonly HNSLLEPHZBT<GetSubCodeInternal> LZIVAIQIOTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private readonly HNSLLEPHZBT<UserFriendlyErrorMessageBuilder> LFYRZJOBZQX;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B720", Offset = "0x8D59D20", VA = "0x188D5B720")]
		[ZOKCDQOPSGU.Root.GameOnly]
		internal static void ZOKCDQOPSGU(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x8D5BBB0", Offset = "0x8D5A1B0", VA = "0x188D5BBB0")]
		[RecRoom.NoEngine.Common.Preserve]
		public HMPYVCJCGNQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x38FF030", Offset = "0x38FD630", VA = "0x1838FF030", Slot = "4")]
		public NMPALTAPESF<T> IVDICBKGJRE<T>() where T : notnull, Exception
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x8D5ABB0", Offset = "0x8D591B0", VA = "0x188D5ABB0", Slot = "5")]
		public UserFriendlyErrorInfo CBKZHJORNDZ(Exception a)
		{
			return default(UserFriendlyErrorInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x8D5AF90", Offset = "0x8D59590", VA = "0x188D5AF90", Slot = "6")]
		public ErrorCode QSJPXTCPVGD(Exception? a)
		{
			return default(ErrorCode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x8D5AD90", Offset = "0x8D59390", VA = "0x188D5AD90", Slot = "7")]
		[IteratorStateMachine(typeof(DCAJRJVIQOI))]
		public IEnumerable<ErrorCode> OCHJUWYHXPN(Exception a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x8D5AC40", Offset = "0x8D59240", VA = "0x188D5AC40", Slot = "8")]
		public string MZDTNSFVXQV(Exception? ex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A8D0", Offset = "0x8D58ED0", VA = "0x188D5A8D0")]
		private string BNPHKYCJFVV(AggregateException a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B790", Offset = "0x8D59D90", VA = "0x188D5B790")]
		private void ZQNXUSJTYOT(Type a, int b, GetSubCodeInternal? getSubCodeInternal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B190", Offset = "0x8D59790", VA = "0x188D5B190")]
		private void UIXGVGJWUHV(Type a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B3B0", Offset = "0x8D599B0", VA = "0x188D5B3B0")]
		private void WQISZHQKJJO(Type a, UserFriendlyErrorMessageBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x8D5AE20", Offset = "0x8D59420", VA = "0x188D5AE20")]
		private static int OUOUWMLEYIC(Type a, Dictionary<Type, int> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x38FF320", Offset = "0x38FD920", VA = "0x1838FF320")]
		private static bool TTJEFZBKDLP<TVal>(HNSLLEPHZBT<TVal> a, Type b, [Out] TVal c) where TVal : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x8D5B650", Offset = "0x8D59C50", VA = "0x188D5B650")]
		[CompilerGenerated]
		internal static int WURXCQYMGMV(Type a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public struct UserFriendlyErrorInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public readonly ErrorCode ErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public readonly string UserFriendlyMessage;

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x8D73F30", Offset = "0x8D72530", VA = "0x188D73F30")]
		public UserFriendlyErrorInfo(string userFriendlyMessage, ErrorCode errorCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D73E90", Offset = "0x8D72490", VA = "0x188D73E90")]
		public string PTDXBILFWAJ()
		{
			return null;
		}
	}
}
namespace RecRoom.RoomLoading.RoomOperation
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public class TGHUEWOZHWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private readonly WQEISMLFQPB ZYHWZOECQCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private string VBFAGHNIKVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private long? FRQMKFIIMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private long? DRNIBOTNMGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private long? FYGIXRJHCCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private string PUHLUQISFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private RoomOperationState JFBKZEHWRQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private long? TLDDMMMKUWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private bool YAUAYENKQAO;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public string CMQBQRAYRVL
		{
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public long TQSIVLWOJTF
		{
			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x8D642E0", Offset = "0x8D628E0", VA = "0x188D642E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public long SUAVNSAYLBR
		{
			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x8D63680", Offset = "0x8D61C80", VA = "0x188D63680")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public long NEWEBOQYRPG
		{
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x8D63780", Offset = "0x8D61D80", VA = "0x188D63780")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public string YXZBRVJLAAZ
		{
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x8D63AB0", Offset = "0x8D620B0", VA = "0x188D63AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public RoomOperationState ZWPZOEJAENO
		{
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0xF7F290", Offset = "0xF7D890", VA = "0x180F7F290")]
			get
			{
				return default(RoomOperationState);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0x8D64340", Offset = "0x8D62940", VA = "0x188D64340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public long IFBKRRLALEM
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0x8D63620", Offset = "0x8D61C20", VA = "0x188D63620")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x8D64430", Offset = "0x8D62A30", VA = "0x188D64430")]
		[UnityEngine.Scripting.Preserve]
		public TGHUEWOZHWI([Inject(null)] WQEISMLFQPB playerPreferences)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D63860", Offset = "0x8D61E60", VA = "0x188D63860")]
		private void OACVOWZXBFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x8D63E50", Offset = "0x8D62450", VA = "0x188D63E50")]
		public void VNNVQDUJRQB(long a, long b, [Optional] long? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x8D636E0", Offset = "0x8D61CE0", VA = "0x188D636E0")]
		public void GGNVYBAUUGJ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x8D637E0", Offset = "0x8D61DE0", VA = "0x188D637E0")]
		public void NOQJBELEVCI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x8D63AF0", Offset = "0x8D620F0", VA = "0x188D63AF0")]
		public void UWELNIYEDNX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	internal class TRMFSAPCCPK : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010E")]
		[CompilerGenerated]
		private struct <>c__DisplayClass13_0<T> where T : IMessage<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public byte[] message;
		}

		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[CompilerGenerated]
		private sealed class IKYMTVTNISZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public NVFUFUSEYRF YMIVCZSFZTF;

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public IKYMTVTNISZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x8D5C1D0", Offset = "0x8D5A7D0", VA = "0x188D5C1D0")]
			internal NVFUFUSEYRF XUYWVZJTOZW(byte[] a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000110")]
		[CompilerGenerated]
		private sealed class ZQYIBSVYBOY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public Func<Guid, bool> WXWSDZEEQUR;

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ZQYIBSVYBOY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x8D75400", Offset = "0x8D73A00", VA = "0x188D75400")]
			internal object HICTXQROBSZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x8D75460", Offset = "0x8D73A60", VA = "0x188D75460")]
			internal bool PULHCPAHVQB(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000111")]
		[CompilerGenerated]
		private sealed class MPBOLSSNFBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Func<Guid, bool> DBXJIWOKMPU;

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public MPBOLSSNFBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x8D5FDA0", Offset = "0x8D5E3A0", VA = "0x188D5FDA0")]
			internal object KXGVAGNDXVX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[CompilerGenerated]
		private sealed class ZUMQVGTFOYO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Guid XDQLMBIPVNZ;

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ZUMQVGTFOYO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x8D75520", Offset = "0x8D73B20", VA = "0x188D75520")]
			internal object PSSQJCXLMWD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000113")]
		[CompilerGenerated]
		private sealed class VBAUPCBRIZX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Guid XDQLMBIPVNZ;

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public VBAUPCBRIZX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0x8D73F50", Offset = "0x8D72550", VA = "0x188D73F50")]
			internal object RBTEJBVMRTY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000114")]
		[CompilerGenerated]
		private sealed class ENTIOZBFPFZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public TRMFSAPCCPK CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			public string MVNOLRCXBND;

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ENTIOZBFPFZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0x8D5A5D0", Offset = "0x8D58BD0", VA = "0x188D5A5D0")]
			internal object EQCIVLNPSOY()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		[CompilerGenerated]
		private struct <MasterLockedBlock>d__15<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public TRMFSAPCCPK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public int maxAttempts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0x52004B0", Offset = "0x51FEAB0", VA = "0x1852004B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(RVA = "0x50224D0", Offset = "0x5020AD0", VA = "0x1850224D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		[CompilerGenerated]
		private struct <MasterLockedBlock>d__16 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			public TRMFSAPCCPK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Func<CancellationToken, Task> masterLockedCodeBlock;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public int maxAttempts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0x8D675C0", Offset = "0x8D65BC0", VA = "0x188D675C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0x8D67890", Offset = "0x8D65E90", VA = "0x188D67890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000117")]
		[CompilerGenerated]
		private struct <MasterSendAllReceive>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			public AsyncTaskMethodBuilder<NVFUFUSEYRF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public NVFUFUSEYRF roomOperationMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public TRMFSAPCCPK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<VDQCZZZDVQV.BufferedMessage<NVFUFUSEYRF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0x8D67F50", Offset = "0x8D66550", VA = "0x188D67F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0x8D68490", Offset = "0x8D66A90", VA = "0x188D68490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000118")]
		[CompilerGenerated]
		private struct <MasterSendAllReceiveBufferedMessage>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000413")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000414")]
			public AsyncTaskMethodBuilder<VDQCZZZDVQV.BufferedMessage<NVFUFUSEYRF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public NVFUFUSEYRF roomOperationMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public TRMFSAPCCPK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			private MessageKind <expectedMessageKind>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			private ByteString <expectedOperationId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<VDQCZZZDVQV.BufferedMessage<NVFUFUSEYRF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0x8D678F0", Offset = "0x8D65EF0", VA = "0x188D678F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x8D67EE0", Offset = "0x8D664E0", VA = "0x188D67EE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private static readonly Guid AXMPGQDTWPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public readonly YARKOAWAUMF GUFWKIXWKMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private readonly VDQCZZZDVQV PMMFOHBDLYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private readonly YYJRECEXABT IXSJEENOFTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private readonly JXTMYJLBPME EOVVFQOINAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private bool MXXEAKALSQT;

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x8D655A0", Offset = "0x8D63BA0", VA = "0x188D655A0")]
		public TRMFSAPCCPK(YARKOAWAUMF a, VDQCZZZDVQV b, YYJRECEXABT c, JXTMYJLBPME d, StackTimer<string>.ERYHZSBUWXZ e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x8D64BA0", Offset = "0x8D631A0", VA = "0x188D64BA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x8D65420", Offset = "0x8D63A20", VA = "0x188D65420")]
		public void YYDHBUFUWSR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x8D64DB0", Offset = "0x8D633B0", VA = "0x188D64DB0")]
		public void IOVPFYMAOLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x8D64470", Offset = "0x8D62A70", VA = "0x188D64470")]
		public void ABCWBLNEBDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x8D647C0", Offset = "0x8D62DC0", VA = "0x188D647C0")]
		[AsyncStateMachine(typeof(<MasterSendAllReceive>d__11))]
		internal Task<NVFUFUSEYRF> CGMSKPKHUHW(StackTimer<string>.ERYHZSBUWXZ a, NVFUFUSEYRF b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x3D61780", Offset = "0x3D5FD80", VA = "0x183D61780")]
		private static byte[] VWPDAUCEZSB<a>(a a) where a : IMessage<a>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D615A0", Offset = "0x3D5FBA0", VA = "0x183D615A0")]
		private static b TMAGPKVYATW<b>(MessageParser<b> a, byte[] b, b c) where b : IMessage<b>
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x8D652E0", Offset = "0x8D638E0", VA = "0x188D652E0")]
		[AsyncStateMachine(typeof(<MasterSendAllReceiveBufferedMessage>d__14))]
		private Task<VDQCZZZDVQV.BufferedMessage<NVFUFUSEYRF>> YRZYLSCAFVY(NVFUFUSEYRF a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x3D60D80", Offset = "0x3D5F380", VA = "0x183D60D80")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__15<>))]
		internal Task<c> BUEANKLPESV<c>(CancellationToken a, Func<CancellationToken, Task<c>> b, int c = 3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x8D64580", Offset = "0x8D62B80", VA = "0x188D64580")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__16))]
		internal Task BUEANKLPESV(CancellationToken a, Func<CancellationToken, Task> b, int c = 3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x8D64D40", Offset = "0x8D63340", VA = "0x188D64D40")]
		public RoomUploadLogic IISBKFXSBTW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x8D64CC0", Offset = "0x8D632C0", VA = "0x188D64CC0")]
		public JBOHOUIZSFN GNPSAWIUQFR([Optional] RRWPZJUWVEY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x8D64F70", Offset = "0x8D63570", VA = "0x188D64F70")]
		public OXXVJLEFDRW TBENBDIIMLC([Optional] Log? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x8D64A50", Offset = "0x8D63050", VA = "0x188D64A50")]
		public void DIVISCZVWKR(Func<Guid, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D646B0", Offset = "0x8D62CB0", VA = "0x188D646B0")]
		public void BXMZXGBVADL(Func<Guid, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x8D65160", Offset = "0x8D63760", VA = "0x188D65160")]
		public Guid WBRAZDFWQKD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8D64BB0", Offset = "0x8D631B0", VA = "0x188D64BB0")]
		public void FFPZWXOMQNK(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x8D64920", Offset = "0x8D62F20", VA = "0x188D64920")]
		public void CZGZLLYDCUI(NVFUFUSEYRF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x8D64E70", Offset = "0x8D63470", VA = "0x188D64E70")]
		public void Log(string stepMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x3D61020", Offset = "0x3D5F620", VA = "0x183D61020")]
		private d QGJYPSUMPLC<d>(d a) where d : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x8D64530", Offset = "0x8D62B30", VA = "0x188D64530")]
		public void BPZXJZAVTVT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D61100", Offset = "0x3D5F700", VA = "0x183D61100")]
		[CompilerGenerated]
		internal static string RBUCZEJQVIE<e>(byte[] a, int b = 15, <>c__DisplayClass13_0<e> c) where e : IMessage<e>
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	internal sealed class InitialRoomLoadOperation : YARKOAWAUMF
	{
		[Cpp2IlInjected.Token(Token = "0x200011A")]
		[CompilerGenerated]
		private sealed class NEFENOBNJAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			public PlayerPresence AXMLJZWKUCR;

			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public NEFENOBNJAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x8D5FEC0", Offset = "0x8D5E4C0", VA = "0x188D5FEC0")]
			internal object ESNLRXRIEPV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011B")]
		[CompilerGenerated]
		private sealed class OGOKSBBDBET
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			public Guid OZZPRBWJRPS;

			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OGOKSBBDBET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x8D60080", Offset = "0x8D5E680", VA = "0x188D60080")]
			internal object LZNYXWZVGYS()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011C")]
		[CompilerGenerated]
		private struct <EnableDisableObjectModel>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000423")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public InitialRoomLoadOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			private bool <omShouldBeEnabled>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			private TaskAwaiter<int> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x8D66A40", Offset = "0x8D65040", VA = "0x188D66A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x8D671E0", Offset = "0x8D657E0", VA = "0x188D671E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011D")]
		[CompilerGenerated]
		private struct <GetSubroomSaveOMVersion>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public InitialRoomLoadOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			private TaskAwaiter<SubRoomDataSaveWithUnityAssetsDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x8D67240", Offset = "0x8D65840", VA = "0x188D67240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x8D67550", Offset = "0x8D65B50", VA = "0x188D67550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		[CompilerGenerated]
		private struct <RunAsync>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			public InitialRoomLoadOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public TRMFSAPCCPK operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			private PlayerPresence <presence>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			private JBOHOUIZSFN <loadLogic>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			private TaskAwaiter<Scene> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			private TaskAwaiter<HTUWLWBGCKI> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x8D6C410", Offset = "0x8D6AA10", VA = "0x188D6C410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x8D6D310", Offset = "0x8D6B910", VA = "0x188D6D310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private static readonly Log MRNLEIUSFDU;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private static readonly Log PFIXKOAAGNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private readonly RoomLoadRequestPayload IELWRVMOIXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private readonly RoomInstance HFPQDAYZTZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private readonly RRWPZJUWVEY VYYWRHTGTHC;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x8D5D100", Offset = "0x8D5B700", VA = "0x188D5D100")]
		public InitialRoomLoadOperation(RoomLoadRequestPayload initialRoomLoadPayload, RoomInstance originalTargetRoomInstance, Guid operationId, NIJQVUPMTTA roomManager, ZTDIGAYZRAK operationPauseToken, RRWPZJUWVEY preloadContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x8D5CEE0", Offset = "0x8D5B4E0", VA = "0x188D5CEE0", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__8))]
		protected override Task WQILFNULVNZ(TRMFSAPCCPK a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x8D5CB00", Offset = "0x8D5B100", VA = "0x188D5CB00")]
		[AsyncStateMachine(typeof(<EnableDisableObjectModel>d__9))]
		private Task EnableDisableObjectModel(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x8D5CDD0", Offset = "0x8D5B3D0", VA = "0x188D5CDD0")]
		[AsyncStateMachine(typeof(<GetSubroomSaveOMVersion>d__10))]
		private Task<int> JYFAKFEQFWM(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x8D5CC00", Offset = "0x8D5B200", VA = "0x188D5CC00")]
		private PlayerPresence IOAVGXFAUGH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	internal class VQZKCNJSKSK : YARKOAWAUMF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000120")]
		[CompilerGenerated]
		private struct <RunAsync>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public VQZKCNJSKSK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public TRMFSAPCCPK operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x8D6D370", Offset = "0x8D6B970", VA = "0x188D6D370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x8D6DD10", Offset = "0x8D6C310", VA = "0x188D6DD10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private readonly int SXWUKYSADGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private readonly NJHMYSMXXYI IPUUAMMUXML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public readonly long FKYOVSPGEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public readonly long SUOABBHXOGA;

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public SaveSubRoomResponseDTO GTYFXBBCQCK
		{
			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0xAB4960", Offset = "0xAB2F60", VA = "0x180AB4960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0xAB50D0", Offset = "0xAB36D0", VA = "0x180AB50D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x8D740E0", Offset = "0x8D726E0", VA = "0x188D740E0")]
		public VQZKCNJSKSK(Guid a, NIJQVUPMTTA b, ZTDIGAYZRAK c, int d, NJHMYSMXXYI e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x8D73FC0", Offset = "0x8D725C0", VA = "0x188D73FC0", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__9))]
		protected override Task WQILFNULVNZ(TRMFSAPCCPK a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	internal abstract class UBTUPXUDGZE : YARKOAWAUMF
	{
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[CompilerGenerated]
		private sealed class AUWAEQXFGZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public UBTUPXUDGZE CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public IDisposable SVMDJJXJURU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public OFIREKWSVXS ZFJYHXBQAFP;

			[Cpp2IlInjected.Token(Token = "0x6000525")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public AUWAEQXFGZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0x8D58730", Offset = "0x8D56D30", VA = "0x188D58730")]
			internal Task PLRBHEWAYLJ(StackTimer<string>.ERYHZSBUWXZ a, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x8D586A0", Offset = "0x8D56CA0", VA = "0x188D586A0")]
			internal object PLLUJYCDPAA()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[CompilerGenerated]
		private struct <RespawnPlayer>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public StackTimer<string>.ERYHZSBUWXZ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public IDisposable freezePlayerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public OFIREKWSVXS playerDespawn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public UBTUPXUDGZE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x8D69510", Offset = "0x8D67B10", VA = "0x188D69510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0x8D69AD0", Offset = "0x8D680D0", VA = "0x188D69AD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000124")]
		[CompilerGenerated]
		private struct <RunAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public UBTUPXUDGZE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			public TRMFSAPCCPK operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			private AUWAEQXFGZW <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0x8D69FB0", Offset = "0x8D685B0", VA = "0x188D69FB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0x8D6A890", Offset = "0x8D68E90", VA = "0x188D6A890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x8D73E40", Offset = "0x8D72440", VA = "0x188D73E40")]
		public UBTUPXUDGZE(Guid a, NIJQVUPMTTA b, ZTDIGAYZRAK c, string d, RequestOperationType e, bool f = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x8D73C90", Offset = "0x8D72290", VA = "0x188D73C90", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__2))]
		protected override Task WQILFNULVNZ(TRMFSAPCCPK a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract Task JKUHKPCXBHU(TRMFSAPCCPK a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x8D73B50", Offset = "0x8D72150", VA = "0x188D73B50")]
		[AsyncStateMachine(typeof(<RespawnPlayer>d__4))]
		private Task HGCYCANYSBP(IDisposable a, OFIREKWSVXS b, StackTimer<string>.ERYHZSBUWXZ c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	internal class IHNVSNMHTBQ : YARKOAWAUMF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[CompilerGenerated]
		private struct <RunAsync>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			public IHNVSNMHTBQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public TRMFSAPCCPK operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			private long <roomId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private long <subroomId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			private TaskAwaiter<RoomSerializedData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x8D6A950", Offset = "0x8D68F50", VA = "0x188D6A950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0x8D6AF40", Offset = "0x8D69540", VA = "0x188D6AF40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private readonly AutosaveType DPKMTBMGQOO;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x8D5C130", Offset = "0x8D5A730", VA = "0x188D5C130")]
		public IHNVSNMHTBQ(Guid a, NIJQVUPMTTA b, ZTDIGAYZRAK c, AutosaveType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x8D5BF30", Offset = "0x8D5A530", VA = "0x188D5BF30", Slot = "6")]
		protected override string KPEJBVNXINY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x8D5C010", Offset = "0x8D5A610", VA = "0x188D5C010", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__3))]
		protected override Task WQILFNULVNZ(TRMFSAPCCPK a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	internal abstract class YARKOAWAUMF : VLYMLWBLEIM
	{
		[Cpp2IlInjected.Token(Token = "0x2000128")]
		public delegate Task PostOperationTaskBuilder(StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000129")]
		[CompilerGenerated]
		private sealed class EDWAHUFUCKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public StackTimer<string>.ERYHZSBUWXZ GNFLMBHXBOX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public YARKOAWAUMF CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public EDWAHUFUCKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0x8D5A2E0", Offset = "0x8D588E0", VA = "0x188D5A2E0")]
			internal Task BQDXFVTCCBU(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012A")]
		[CompilerGenerated]
		private sealed class EDQTKNLWSZO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public Exception DPJLVPQRCSZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public EDWAHUFUCKX GOOXOIYUWOV;

			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public EDQTKNLWSZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x8D5A220", Offset = "0x8D58820", VA = "0x188D5A220")]
			internal object BPYQIOZESQL()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private struct <DriverCombinedTask>d__31 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			public Func<CancellationToken, Task> createDriverTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			public Func<CancellationToken, Task> originalTaskBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			private CancellationTokenSource <driverCancellationTokenSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			private Task <driverTask>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			private Task <originalTask>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			private TaskAwaiter<Task> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x8D65F40", Offset = "0x8D64540", VA = "0x188D65F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x8D669E0", Offset = "0x8D64FE0", VA = "0x188D669E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012C")]
		[CompilerGenerated]
		private struct <Run>d__30 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			public YARKOAWAUMF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public Func<YARKOAWAUMF, StackTimer<string>.ERYHZSBUWXZ, TRMFSAPCCPK> operationContextBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private EDWAHUFUCKX <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			private bool <success>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			private TRMFSAPCCPK <operationContext>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private TaskAwaiter<NVFUFUSEYRF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x8D70030", Offset = "0x8D6E630", VA = "0x188D70030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054D")]
			[Cpp2IlInjected.Address(RVA = "0x8D712D0", Offset = "0x8D6F8D0", VA = "0x188D712D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		[CompilerGenerated]
		private struct <RunPostOperationTasks>d__35 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public YARKOAWAUMF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0x8D6F0A0", Offset = "0x8D6D6A0", VA = "0x188D6F0A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054F")]
			[Cpp2IlInjected.Address(RVA = "0x8D6F400", Offset = "0x8D6DA00", VA = "0x188D6F400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public readonly Guid QRNAXMCMCEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public readonly ByteString UHCRRHKKJHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public readonly ZTDIGAYZRAK ZTDIGAYZRAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		protected readonly string LZDWBJQXIOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private readonly NIJQVUPMTTA VHJCBTPFZBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private readonly bool JJTOCQVODYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly Queue<PostOperationTaskBuilder> MXCROGMQJBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private readonly IHSTJJNLZKT CYYZYJBUUML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private readonly RequestOperationType XPCCPHBCRDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private bool GRZNXLATFUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public RoomOperationState ZFKODAIQTHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public RoomOperationState HWKMTEOVWGH;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public NIJQVUPMTTA TCZAJMILSXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public TPICXMNKDPD TUDUSUBOTJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x8D74F20", Offset = "0x8D73520", VA = "0x188D74F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public XNTVLDKBPBW RFQAGKRZMCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x8D74C10", Offset = "0x8D73210", VA = "0x188D74C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public KEWSLRECSSV VXTOLEXPLIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0x8D74B90", Offset = "0x8D73190", VA = "0x188D74B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event ProgressUpdate PZTAHXEMCUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0x8D74860", Offset = "0x8D72E60", VA = "0x188D74860", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x8D74B30", Offset = "0x8D73130", VA = "0x188D74B30", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x8D752C0", Offset = "0x8D738C0", VA = "0x188D752C0")]
		protected YARKOAWAUMF(Guid a, NIJQVUPMTTA b, ZTDIGAYZRAK c, string d, RequestOperationType e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x8D74B50", Offset = "0x8D73150", VA = "0x188D74B50", Slot = "6")]
		protected virtual string KPEJBVNXINY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x8D74780", Offset = "0x8D72D80", VA = "0x188D74780")]
		public void AEOKXEFQTDC(PostOperationTaskBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x8D749F0", Offset = "0x8D72FF0", VA = "0x188D749F0")]
		protected void DYPSFNQVRLR(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x8D74C60", Offset = "0x8D73260", VA = "0x188D74C60")]
		[AsyncStateMachine(typeof(<Run>d__30))]
		public Task Run(CancellationToken cancellationToken, StackTimer<string>.ERYHZSBUWXZ stackTimer, [Optional] Func<YARKOAWAUMF, StackTimer<string>.ERYHZSBUWXZ, TRMFSAPCCPK> operationContextBuilder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x8D75190", Offset = "0x8D73790", VA = "0x188D75190")]
		[AsyncStateMachine(typeof(<DriverCombinedTask>d__31))]
		private static Task ZZQOCYVMXAA(Func<CancellationToken, Task> a, Func<CancellationToken, Task> b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x8D74DB0", Offset = "0x8D733B0", VA = "0x188D74DB0")]
		private void VLUKQRHDWER(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x8D74F70", Offset = "0x8D73570", VA = "0x188D74F70")]
		private void YDSWQNEYUQA(TRMFSAPCCPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract Task WQILFNULVNZ(TRMFSAPCCPK a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x8D74A10", Offset = "0x8D73010", VA = "0x188D74A10")]
		[AsyncStateMachine(typeof(<RunPostOperationTasks>d__35))]
		private Task HYCYYSBXQHA(StackTimer<string>.ERYHZSBUWXZ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x8D747E0", Offset = "0x8D72DE0", VA = "0x188D747E0")]
		public NVFUFUSEYRF AUMYDFDVGMD(MessageKind a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x8D74880", Offset = "0x8D72E80", VA = "0x188D74880")]
		[CompilerGenerated]
		private Task CIAVXFEBMMX(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x8D74970", Offset = "0x8D72F70", VA = "0x188D74970")]
		[CompilerGenerated]
		private object CIGCULXYVYG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	internal sealed class DFQNTLIGAJN : UBTUPXUDGZE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012F")]
		[CompilerGenerated]
		private struct <RunWhilePlayerDespawnedAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public DFQNTLIGAJN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public TRMFSAPCCPK operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private RoomEvent <roomEvent>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			private JBOHOUIZSFN <loadLogic>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x8D71330", Offset = "0x8D6F930", VA = "0x188D71330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x8D71A80", Offset = "0x8D70080", VA = "0x188D71A80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private readonly RoomLoadRequestPayload QKOVMTYFPRU;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x8D59120", Offset = "0x8D57720", VA = "0x188D59120")]
		public DFQNTLIGAJN(Guid a, NIJQVUPMTTA b, RoomLoadRequestPayload c, ZTDIGAYZRAK d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x8D58FD0", Offset = "0x8D575D0", VA = "0x188D58FD0", Slot = "8")]
		[AsyncStateMachine(typeof(<RunWhilePlayerDespawnedAsync>d__2))]
		protected override Task JKUHKPCXBHU(TRMFSAPCCPK a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	internal class EHOJCCBZYUH : YARKOAWAUMF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000131")]
		[CompilerGenerated]
		private struct <RunAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			public EHOJCCBZYUH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			public TRMFSAPCCPK operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			private TaskAwaiter<RoomSerializedData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x8D69B30", Offset = "0x8D68130", VA = "0x188D69B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0x8D6A8F0", Offset = "0x8D68EF0", VA = "0x188D6A8F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private readonly string EANEVJCMHAZ;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A520", Offset = "0x8D58B20", VA = "0x188D5A520")]
		public EHOJCCBZYUH(Guid a, NIJQVUPMTTA b, ZTDIGAYZRAK c, string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A410", Offset = "0x8D58A10", VA = "0x188D5A410", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__2))]
		protected override Task WQILFNULVNZ(TRMFSAPCCPK a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	internal class RoomSaveToRecNetOperation : UBTUPXUDGZE
	{
		[Cpp2IlInjected.Token(Token = "0x2000133")]
		[CompilerGenerated]
		private sealed class XMEHEWGCGRP
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000134")]
			private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004AF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40004B0")]
				public AsyncTaskMethodBuilder<NVFUFUSEYRF> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40004B1")]
				public XMEHEWGCGRP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40004B2")]
				public CancellationToken masterLockedCodeBlockCancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40004B3")]
				private TaskAwaiter<RoomSerializedData> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40004B4")]
				private TaskAwaiter<NVFUFUSEYRF> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x8D73160", Offset = "0x8D71760", VA = "0x188D73160", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x8D73640", Offset = "0x8D71C40", VA = "0x188D73640", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			public RoomSaveToRecNetOperation CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public OXXVJLEFDRW DRMXJAYMDTS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public long SGAXFWVIGFS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004AA")]
			public RoomSaveOptions ANVLEWJEGIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004AB")]
			public RoomUploadLogic EHCKQIDAYGZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004AC")]
			public long IKSKUZJHEUJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004AD")]
			public RoomSaveAnalyticsInfo RYOTCLSVHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004AE")]
			public StackTimer<string>.ERYHZSBUWXZ KLYBBBDLWPL;

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public XMEHEWGCGRP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0x8D74660", Offset = "0x8D72C60", VA = "0x188D74660")]
			[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
			internal Task<NVFUFUSEYRF> GPNDBQRANQM(CancellationToken a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000135")]
		[CompilerGenerated]
		private struct <RunWhilePlayerDespawnedAsync>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			public RoomSaveToRecNetOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B8")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B9")]
			public TRMFSAPCCPK operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			private XMEHEWGCGRP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004BC")]
			private RoomEvent <roomEvent>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004BD")]
			private JBOHOUIZSFN <loadLogic>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40004BE")]
			private NVFUFUSEYRF <saveReloadMessage>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			private TaskAwaiter<NVFUFUSEYRF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x8D71AE0", Offset = "0x8D700E0", VA = "0x188D71AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x8D729A0", Offset = "0x8D70FA0", VA = "0x188D729A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private static readonly Log MRNLEIUSFDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private readonly int ZZPZQBRGDBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		[CanBeNull]
		private readonly RoomSaveRequestPayload HUFPTNWKMKH;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x8D62AE0", Offset = "0x8D610E0", VA = "0x188D62AE0")]
		public RoomSaveToRecNetOperation(Guid operationId, NIJQVUPMTTA roomManager, int savingPlayerAccountId, RoomSaveRequestPayload roomSaveRequestPayload, ZTDIGAYZRAK operationPauseToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8D62800", Offset = "0x8D60E00", VA = "0x188D62800", Slot = "8")]
		[AsyncStateMachine(typeof(<RunWhilePlayerDespawnedAsync>d__5))]
		protected override Task JKUHKPCXBHU(TRMFSAPCCPK a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x8D62940", Offset = "0x8D60F40", VA = "0x188D62940")]
		private void TIQQHBUTOSM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x8D62630", Offset = "0x8D60C30", VA = "0x188D62630")]
		private void BPBVGKWJJRO(StackTimer<string>.ERYHZSBUWXZ a, RoomEvent b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	internal class PTTBGPAAMAY : YARKOAWAUMF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000137")]
		[CompilerGenerated]
		private struct <RunAsync>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			public PTTBGPAAMAY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C7")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C8")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004C9")]
			private RoomEvent <roomEvent>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004CA")]
			private long <superRoomId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			private long <subRoomId>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004CC")]
			private SubRoomDataSaveWithUnityAssetsDTO <currentRoomSave>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			private XJCVXUISJRI<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			private TaskAwaiter<SubRoomDataSaveWithUnityAssetsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			private TaskAwaiter <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0x8D6AFA0", Offset = "0x8D695A0", VA = "0x188D6AFA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x8D6C3B0", Offset = "0x8D6A9B0", VA = "0x188D6C3B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private readonly int ZZPZQBRGDBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private readonly RoomSaveRequestPayload HUFPTNWKMKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private Func<RoomSerializedData, RoomSerializedData> KDFWRFNBVWM;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x8D607F0", Offset = "0x8D5EDF0", VA = "0x188D607F0")]
		public PTTBGPAAMAY(Guid a, NIJQVUPMTTA b, int c, RoomSaveRequestPayload d, Func<RoomSerializedData, RoomSerializedData> e, ZTDIGAYZRAK f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x8D606C0", Offset = "0x8D5ECC0", VA = "0x188D606C0", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__4))]
		protected override Task WQILFNULVNZ(TRMFSAPCCPK a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	internal abstract class ORSJLKFOEMV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public readonly YARKOAWAUMF GUFWKIXWKMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public readonly TRMFSAPCCPK TRMFSAPCCPK;

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public TPICXMNKDPD TUDUSUBOTJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x8D60290", Offset = "0x8D5E890", VA = "0x188D60290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public KEWSLRECSSV VXTOLEXPLIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x8D60200", Offset = "0x8D5E800", VA = "0x188D60200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x8D602E0", Offset = "0x8D5E8E0", VA = "0x188D602E0")]
		protected ORSJLKFOEMV(TRMFSAPCCPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x8D600F0", Offset = "0x8D5E6F0", VA = "0x188D600F0")]
		protected void Log(string stepMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	internal struct DeserializationHandlerLists
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public Dictionary<Guid, List<DeserializationPhaseHandler>> AuthorityHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public Dictionary<Guid, List<DeserializationPhaseHandler>> AllHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public Dictionary<Guid, List<DeserializationPhaseHandler>> NonAuthorityHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public List<Guid> IDList;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x8D59C20", Offset = "0x8D58220", VA = "0x188D59C20")]
		public static DeserializationHandlerLists Get(TPICXMNKDPD callbacks, RoomOperationState operationState, BCQRNRKFWAN deserializationData)
		{
			return default(DeserializationHandlerLists);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	internal struct LogRoomLoadMetrics
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0")]
		public static LogRoomLoadMetrics Create()
		{
			return default(LogRoomLoadMetrics);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	internal struct RoomLoadDetails
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public readonly RoomDetailsDTO roomDetails;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public readonly SubRoomDTO subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public readonly Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public readonly IReadOnlyCollection<BakedUnitySubAssetDTO> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public readonly IReadOnlyCollection<BakedUnitySubAssetDTO> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public readonly FilenameWithHash superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public readonly FilenameWithHash subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public readonly RoomLoadDTO roomLoad;

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public bool SMFRHQRQRCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x8D609D0", Offset = "0x8D5EFD0", VA = "0x188D609D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x8D60A60", Offset = "0x8D5F060", VA = "0x188D60A60")]
		public RoomLoadDetails(RoomDetailsDTO roomDetails, SubRoomDTO subRoom, Guid? unityAssetId, IReadOnlyList<BakedUnitySubAssetDTO> unitySubAssets, IReadOnlyCollection<BakedUnitySubAssetDTO> referencedUnityAssets, FilenameWithHash superRoomData, FilenameWithHash subRoomData, RoomLoadDTO roomLoad)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	internal struct RoomLoadLifetime : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private readonly TRMFSAPCCPK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private readonly Guid sliceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private bool success;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x8D60DE0", Offset = "0x8D5F3E0", VA = "0x188D60DE0")]
		public static RoomLoadLifetime WBRAZDFWQKD(TRMFSAPCCPK a)
		{
			return default(RoomLoadLifetime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x1433530", Offset = "0x1431B30", VA = "0x181433530")]
		public void DRTAZSPJGXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x8D60BB0", Offset = "0x8D5F1B0", VA = "0x188D60BB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x8D60E10", Offset = "0x8D5F410", VA = "0x188D60E10")]
		private RoomLoadLifetime(TRMFSAPCCPK operationContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x8D60BC0", Offset = "0x8D5F1C0", VA = "0x188D60BC0")]
		private void FFPZWXOMQNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x8D60B10", Offset = "0x8D5F110", VA = "0x188D60B10")]
		private Func<Guid, bool> CTQSYZBZMLV()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	internal class JBOHOUIZSFN : ORSJLKFOEMV, VLYMLWBLEIM
	{
		[Cpp2IlInjected.Token(Token = "0x200013F")]
		public delegate Task<RoomOperationState> RoomLoadFunction(BCQRNRKFWAN data, QOPPARWDDEP yielder, IHSTJJNLZKT progressTracker, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000141")]
		[CompilerGenerated]
		private sealed class QEFUBVWJVIW
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000142")]
			private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004FC")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40004FD")]
				public AsyncTaskMethodBuilder<RoomLoadDetails> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40004FE")]
				public QEFUBVWJVIW <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40004FF")]
				public CancellationToken innerCancellation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000500")]
				private RoomLoadDetails <innerData>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
				[Cpp2IlInjected.Token(Token = "0x4000501")]
				private TaskAwaiter<RoomOperationState> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
				[Cpp2IlInjected.Token(Token = "0x4000502")]
				private TaskAwaiter<RoomLoadDetails> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60005AD")]
				[Cpp2IlInjected.Address(RVA = "0x8D8AB20", Offset = "0x8D89120", VA = "0x188D8AB20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0x8D8B3E0", Offset = "0x8D899E0", VA = "0x188D8B3E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000143")]
			private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000503")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000504")]
				public AsyncTaskMethodBuilder<BCQRNRKFWAN> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000505")]
				public QEFUBVWJVIW <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000506")]
				public CancellationToken innerCancellation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000507")]
				private BCQRNRKFWAN <innerPhaseArgs>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000508")]
				private TaskAwaiter<RoomOperationState> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000509")]
				private TaskAwaiter<BCQRNRKFWAN> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x8D8B450", Offset = "0x8D89A50", VA = "0x188D8B450", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x8D8BA90", Offset = "0x8D8A090", VA = "0x188D8BA90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public JBOHOUIZSFN CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public RoomLoadRequestPayload IPZSVHKCSSN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public IHSTJJNLZKT VEURPKNJBBY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public StackTimer<string>.ERYHZSBUWXZ KLYBBBDLWPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public IHSTJJNLZKT UVTDRFQNRHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			public RoomLoadDetails QHPHTAHQMYA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			public IHSTJJNLZKT NMLVKIJORBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			public BCQRNRKFWAN FYCLTUMMTOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public RecNet.Core.OnDownloadProgressDelegate LHMKQEBDWVY;

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public QEFUBVWJVIW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x8D79450", Offset = "0x8D77A50", VA = "0x188D79450")]
			[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
			internal Task<RoomLoadDetails> FGINIAKINAX(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x8D795A0", Offset = "0x8D77BA0", VA = "0x188D795A0")]
			[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
			internal Task<BCQRNRKFWAN> FGTBCNYDFXP(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0x8D796C0", Offset = "0x8D77CC0", VA = "0x188D796C0")]
			internal void FHDOXBLXYUH(long a, long b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x8D79700", Offset = "0x8D77D00", VA = "0x188D79700")]
			internal Task FHIVUIFVIFQ(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x8D79740", Offset = "0x8D77D40", VA = "0x188D79740")]
			internal Task FHOCROZSRQZ(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000144")]
		[CompilerGenerated]
		private sealed class OVIONAJIVIG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000145")]
			private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000511")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000512")]
				public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000513")]
				public OVIONAJIVIG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000514")]
				public CancellationToken mlToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000515")]
				private LogRangeScope <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000516")]
				private TaskAwaiter<RoomOperationState> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60005B3")]
				[Cpp2IlInjected.Address(RVA = "0x8D8BB00", Offset = "0x8D8A100", VA = "0x188D8BB00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B4")]
				[Cpp2IlInjected.Address(RVA = "0x8D8BFB0", Offset = "0x8D8A5B0", VA = "0x188D8BFB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			public JBOHOUIZSFN CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400050B")]
			public RoomLoadFunction NRUDSVAMCXH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public BCQRNRKFWAN QHPHTAHQMYA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public QOPPARWDDEP UPTDOPHSTVN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public IHSTJJNLZKT ORODLXPHDTL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			public StackTimer<string>.ERYHZSBUWXZ KLYBBBDLWPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public RoomOperationState XIMGSUHNYSV;

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OVIONAJIVIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0x8D79330", Offset = "0x8D77930", VA = "0x188D79330")]
			[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
			internal Task<RoomOperationState> NUKTIIHXBLI(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000146")]
		[CompilerGenerated]
		private sealed class MGNXEROXAMS
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000147")]
			private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000519")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400051A")]
				public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400051B")]
				public MGNXEROXAMS <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400051C")]
				public BCQRNRKFWAN data;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400051D")]
				public IHSTJJNLZKT progressTracker;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400051E")]
				public StackTimer<string>.ERYHZSBUWXZ stackTimer;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400051F")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000520")]
				private TaskAwaiter<RoomOperationState> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000521")]
				private TaskAwaiter <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000522")]
				private TaskAwaiter<RRSceneLoadOperation> <>u__3;

				[Cpp2IlInjected.Token(Token = "0x60005B7")]
				[Cpp2IlInjected.Address(RVA = "0x8D8C020", Offset = "0x8D8A620", VA = "0x188D8C020", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B8")]
				[Cpp2IlInjected.Address(RVA = "0x8D8CAE0", Offset = "0x8D8B0E0", VA = "0x188D8CAE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			public JBOHOUIZSFN CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			public QKSJPMFGORP TWIEBEHWNKA;

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public MGNXEROXAMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x8D789F0", Offset = "0x8D76FF0", VA = "0x188D789F0")]
			[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
			internal Task<RoomOperationState> RELGYLANRMX(BCQRNRKFWAN a, QOPPARWDDEP b, IHSTJJNLZKT c, StackTimer<string>.ERYHZSBUWXZ d, CancellationToken e)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000148")]
		[CompilerGenerated]
		private struct <CreateCV1Mappings>d__35 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000524")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000525")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x8D799D0", Offset = "0x8D77FD0", VA = "0x188D799D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x8D79BF0", Offset = "0x8D781F0", VA = "0x188D79BF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000149")]
		[CompilerGenerated]
		private struct <DeserializeAllObjects>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public IHSTJJNLZKT progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public QOPPARWDDEP timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			private StackTimer<string>.ERYHZSBUWXZ <deserializeAllObjectsTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x8D7A2E0", Offset = "0x8D788E0", VA = "0x188D7A2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x8D7B3F0", Offset = "0x8D799F0", VA = "0x188D7B3F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014A")]
		[CompilerGenerated]
		private struct <DeserializeAllObjectsR2>d__49 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			public IHSTJJNLZKT progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private StackTimer<string>.ERYHZSBUWXZ <deserializeAllObjectsTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400053C")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x8D79C50", Offset = "0x8D78250", VA = "0x188D79C50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x8D7A270", Offset = "0x8D78870", VA = "0x188D7A270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014B")]
		[CompilerGenerated]
		private struct <DestroyOldObjects>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400053D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400053F")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			public bool useCompletionMark;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x8D7B460", Offset = "0x8D79A60", VA = "0x188D7B460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x8D7B750", Offset = "0x8D79D50", VA = "0x188D7B750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014C")]
		[CompilerGenerated]
		private struct <DestroyR1Objects>d__47 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0x8D7B7B0", Offset = "0x8D79DB0", VA = "0x188D7B7B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x8D7BBB0", Offset = "0x8D7A1B0", VA = "0x188D7BBB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014D")]
		[CompilerGenerated]
		private struct <GetSyncedRoomLoadPayload>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			public AsyncTaskMethodBuilder<NVFUFUSEYRF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private StackTimer<string>.ERYHZSBUWXZ <syncTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			private TaskAwaiter<NVFUFUSEYRF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x8D7D7D0", Offset = "0x8D7BDD0", VA = "0x188D7D7D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x8D7DC00", Offset = "0x8D7C200", VA = "0x188D7DC00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014E")]
		[CompilerGenerated]
		private struct <LegacyLoadRoomData>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			public IHSTJJNLZKT progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			private StackTimer<string>.ERYHZSBUWXZ <legacyLoadRoomDataTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x8D7DC70", Offset = "0x8D7C270", VA = "0x188D7DC70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x8D7E4B0", Offset = "0x8D7CAB0", VA = "0x188D7E4B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014F")]
		[CompilerGenerated]
		private struct <LoadRoomLocal>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			public CancellationToken externalCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			private QEFUBVWJVIW <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			private TaskAwaiter<RoomLoadDetails> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			private TaskAwaiter<BCQRNRKFWAN> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x8D7EA30", Offset = "0x8D7D030", VA = "0x188D7EA30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x8D7F670", Offset = "0x8D7DC70", VA = "0x188D7F670", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000150")]
		[CompilerGenerated]
		private struct <LoadRoomLocalTimed>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			private StackTimer<string>.ERYHZSBUWXZ <loadRoomLocalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x8D7E510", Offset = "0x8D7CB10", VA = "0x188D7E510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x8D7E9D0", Offset = "0x8D7CFD0", VA = "0x188D7E9D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		[CompilerGenerated]
		private struct <MasterLockedPhaseChangeBlock>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			public RoomLoadFunction masterLockedCode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			public QOPPARWDDEP timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000576")]
			public IHSTJJNLZKT progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000578")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000579")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400057A")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x8D7F6D0", Offset = "0x8D7DCD0", VA = "0x188D7F6D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x8D7FBE0", Offset = "0x8D7E1E0", VA = "0x188D7FBE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000152")]
		[CompilerGenerated]
		private struct <MoveThroughRemainingPhases>d__29 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public IHSTJJNLZKT progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private RoomOperationState <legacyEndPhase>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private IEnumerator<RoomOperationState> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x8D7FC50", Offset = "0x8D7E250", VA = "0x188D7FC50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x8D801A0", Offset = "0x8D7E7A0", VA = "0x188D801A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000153")]
		[CompilerGenerated]
		private struct <MoveToPhase>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			public RoomOperationState operationState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			public IHSTJJNLZKT progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400058A")]
			public BCQRNRKFWAN deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			public bool skipHandlers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x8D80200", Offset = "0x8D7E800", VA = "0x188D80200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x8D80450", Offset = "0x8D7EA50", VA = "0x188D80450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[CompilerGenerated]
		private struct <RoomV1DestroyAndRebuildObjects>d__24 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400058F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000590")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public IHSTJJNLZKT progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			private StackTimer<string>.ERYHZSBUWXZ <destroyAndRebuildObjectsTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x8D804C0", Offset = "0x8D7EAC0", VA = "0x188D804C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x8D81480", Offset = "0x8D7FA80", VA = "0x188D81480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000155")]
		[CompilerGenerated]
		private struct <RoomV1LoadLogic>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400059B")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			public BCQRNRKFWAN phaseArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			public IHSTJJNLZKT postDownloadProgress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005A1")]
			private TaskAwaiter<RoomOperationState> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			private QOPPARWDDEP <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x8D814F0", Offset = "0x8D7FAF0", VA = "0x188D814F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x8D82320", Offset = "0x8D80920", VA = "0x188D82320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000156")]
		[CompilerGenerated]
		private struct <RoomV2LoadLogic>d__46 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005A4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A5")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			public BCQRNRKFWAN phaseArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public IHSTJJNLZKT postDownloadProgress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			private MGNXEROXAMS <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005AB")]
			private QOPPARWDDEP <timedYielder>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005AC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005AD")]
			private TaskAwaiter<RoomOperationState> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x8D82380", Offset = "0x8D80980", VA = "0x188D82380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0x8D83190", Offset = "0x8D81790", VA = "0x188D83190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000157")]
		[CompilerGenerated]
		private struct <SyncLoadRoom>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005AE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005AF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005B2")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005B3")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005B4")]
			private RoomLoadLifetime <lifetime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			private TaskAwaiter<NVFUFUSEYRF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x8D89140", Offset = "0x8D87740", VA = "0x188D89140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x8D89880", Offset = "0x8D87E80", VA = "0x188D89880", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000158")]
		[CompilerGenerated]
		private struct <TriggerBigDataNetworkManager>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005B9")]
			public JBOHOUIZSFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005BA")]
			public StackTimer<string>.ERYHZSBUWXZ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005BB")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005BC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x8D898E0", Offset = "0x8D87EE0", VA = "0x188D898E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x8D8A0C0", Offset = "0x8D886C0", VA = "0x188D8A0C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private readonly Token XKEURZLPAHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private readonly Token KRQTHEJQFKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private readonly TGHUEWOZHWI IBCDEJQDNOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private readonly LWSUKBSGQIG CFDLQOMUGUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private readonly MoveToPhaseTask XCXWFKFGTQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private ProfilerCounterValue<int> GYOURIYZERP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private readonly ZSEHKOFSPKO TWYFGWQMQZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private readonly RRWPZJUWVEY VYYWRHTGTHC;

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		private NIJQVUPMTTA TCZAJMILSXE
		{
			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0x8D5F090", Offset = "0x8D5D690", VA = "0x188D5F090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event ProgressUpdate PZTAHXEMCUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x8D5D7F0", Offset = "0x8D5BDF0", VA = "0x188D5D7F0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0x8D5E2B0", Offset = "0x8D5C8B0", VA = "0x188D5E2B0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x8D5F370", Offset = "0x8D5D970", VA = "0x188D5F370")]
		public JBOHOUIZSFN(TRMFSAPCCPK a, RRWPZJUWVEY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E160", Offset = "0x8D5C760", VA = "0x188D5E160")]
		[AsyncStateMachine(typeof(<SyncLoadRoom>d__17))]
		public Task JDCCWVGYOEU(RoomLoadRequestPayload a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E740", Offset = "0x8D5CD40", VA = "0x188D5E740")]
		[AsyncStateMachine(typeof(<GetSyncedRoomLoadPayload>d__18))]
		private Task<NVFUFUSEYRF> NPBFAIUWCSF(RoomLoadRequestPayload a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x8D5D900", Offset = "0x8D5BF00", VA = "0x188D5D900")]
		[AsyncStateMachine(typeof(<LoadRoomLocalTimed>d__19))]
		private Task CLHCHHMCGRH(RoomLoadRequestPayload a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E420", Offset = "0x8D5CA20", VA = "0x188D5E420")]
		[AsyncStateMachine(typeof(<LoadRoomLocal>d__20))]
		private Task LoadRoomLocal(RoomLoadRequestPayload request, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken externalCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x8D5F220", Offset = "0x8D5D820", VA = "0x188D5F220")]
		[AsyncStateMachine(typeof(<RoomV1LoadLogic>d__21))]
		private Task ZDNZWBZUTUU(BCQRNRKFWAN a, IHSTJJNLZKT b, StackTimer<string>.ERYHZSBUWXZ c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DD90", Offset = "0x8D5C390", VA = "0x188D5DD90")]
		[AsyncStateMachine(typeof(<TriggerBigDataNetworkManager>d__22))]
		private Task FJWRJRPVLRB(StackTimer<string>.ERYHZSBUWXZ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E2D0", Offset = "0x8D5C8D0", VA = "0x188D5E2D0")]
		[AsyncStateMachine(typeof(<LegacyLoadRoomData>d__23))]
		private Task LegacyLoadRoomData(BCQRNRKFWAN data, IHSTJJNLZKT progressTracker, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x8D5EB50", Offset = "0x8D5D150", VA = "0x188D5EB50")]
		[AsyncStateMachine(typeof(<RoomV1DestroyAndRebuildObjects>d__24))]
		private Task<RoomOperationState> UBJWRRPUPKE(BCQRNRKFWAN a, QOPPARWDDEP b, IHSTJJNLZKT c, StackTimer<string>.ERYHZSBUWXZ d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DA40", Offset = "0x8D5C040", VA = "0x188D5DA40")]
		[AsyncStateMachine(typeof(<DeserializeAllObjects>d__25))]
		private Task<RoomOperationState> DeserializeAllObjects(BCQRNRKFWAN data, QOPPARWDDEP timedYielder, IHSTJJNLZKT progressTracker, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x8D5ECF0", Offset = "0x8D5D2F0", VA = "0x188D5ECF0")]
		[AsyncStateMachine(typeof(<MoveToPhase>d__26))]
		private Task<RoomOperationState> UHVJCTSLKLN(RoomOperationState a, BCQRNRKFWAN b, IHSTJJNLZKT c, StackTimer<string>.ERYHZSBUWXZ d, CancellationToken e, bool f = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x8D5EA20", Offset = "0x8D5D020", VA = "0x188D5EA20")]
		private bool SMFCZAPFCQU(BCQRNRKFWAN a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E560", Offset = "0x8D5CB60", VA = "0x188D5E560")]
		[AsyncStateMachine(typeof(<MasterLockedPhaseChangeBlock>d__28))]
		protected Task<RoomOperationState> MasterLockedPhaseChangeBlock(BCQRNRKFWAN data, QOPPARWDDEP timedYielder, IHSTJJNLZKT progressTracker, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken, RoomLoadFunction masterLockedCode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DFF0", Offset = "0x8D5C5F0", VA = "0x188D5DFF0")]
		[AsyncStateMachine(typeof(<MoveThroughRemainingPhases>d__29))]
		private Task HVTPTVPAZBI(BCQRNRKFWAN a, IHSTJJNLZKT b, StackTimer<string>.ERYHZSBUWXZ c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x8D5EE70", Offset = "0x8D5D470", VA = "0x188D5EE70")]
		private void VAAFDZACSHN(RoomOperationState a, IHSTJJNLZKT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x8D5D7B0", Offset = "0x8D5BDB0", VA = "0x188D5D7B0")]
		private void AZXAQHKLAXC(RoomOperationState a, [Out] RoomOperationState b, [Out] RoomOperationState c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x8D5EB10", Offset = "0x8D5D110", VA = "0x188D5EB10")]
		private Task<RoomLoadDetails> TJTTYJABLLR(RoomLoadRequestPayload a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x8D5ECB0", Offset = "0x8D5D2B0", VA = "0x188D5ECB0")]
		private Task<BCQRNRKFWAN> UHMOCODCMDX(RoomLoadDetails a, RecNet.Core.OnDownloadProgressDelegate b, StackTimer<string>.ERYHZSBUWXZ c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DC40", Offset = "0x8D5C240", VA = "0x188D5DC40")]
		[AsyncStateMachine(typeof(<DestroyOldObjects>d__34))]
		private Task DestroyOldObjects(BCQRNRKFWAN data, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken, bool useCompletionMark = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x8D5D810", Offset = "0x8D5BE10", VA = "0x188D5D810")]
		[AsyncStateMachine(typeof(<CreateCV1Mappings>d__35))]
		private Task CIKGFMKZTLV(BCQRNRKFWAN a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DC10", Offset = "0x8D5C210", VA = "0x188D5DC10")]
		private Task DeserializeSettings(BCQRNRKFWAN data, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E140", Offset = "0x8D5C740", VA = "0x188D5E140")]
		private Task InstantiateObjects(BCQRNRKFWAN data, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E8C0", Offset = "0x8D5CEC0", VA = "0x188D5E8C0")]
		private Task PreDeserializeObjects(BCQRNRKFWAN data, QOPPARWDDEP timedYielder, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DBF0", Offset = "0x8D5C1F0", VA = "0x188D5DBF0")]
		private Task DeserializeObjects(BCQRNRKFWAN data, QOPPARWDDEP timedYielder, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DBC0", Offset = "0x8D5C1C0", VA = "0x188D5DBC0")]
		private static Task DeserializeConnectables(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E8A0", Offset = "0x8D5CEA0", VA = "0x188D5E8A0")]
		private Task PostDeserializeObjects(BCQRNRKFWAN data, QOPPARWDDEP timedYielder, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DBD0", Offset = "0x8D5C1D0", VA = "0x188D5DBD0")]
		private Task DeserializeObjectsComplete(BCQRNRKFWAN data, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E6F0", Offset = "0x8D5CCF0", VA = "0x188D5E6F0")]
		private void NODHRBOZDOA(RoomLoadRequestPayload a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x8D5EEC0", Offset = "0x8D5D4C0", VA = "0x188D5EEC0")]
		public void WRGMAPHGQFU(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private static void JGTOGZNKFVL(RoomDetailsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DEA0", Offset = "0x8D5C4A0", VA = "0x188D5DEA0")]
		[AsyncStateMachine(typeof(<RoomV2LoadLogic>d__46))]
		private Task HRLVJFFVOKH(BCQRNRKFWAN a, IHSTJJNLZKT b, StackTimer<string>.ERYHZSBUWXZ c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E8E0", Offset = "0x8D5CEE0", VA = "0x188D5E8E0")]
		[AsyncStateMachine(typeof(<DestroyR1Objects>d__47))]
		private Task RVLALLJYLCB(BCQRNRKFWAN a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x8D5EF70", Offset = "0x8D5D570", VA = "0x188D5EF70")]
		private static SerializedDataWrapper WUINUGUGJLY(BCQRNRKFWAN a)
		{
			return default(SerializedDataWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x8D5F0C0", Offset = "0x8D5D6C0", VA = "0x188D5F0C0")]
		[AsyncStateMachine(typeof(<DeserializeAllObjectsR2>d__49))]
		private Task<RoomOperationState> YMWPUQBVHCS(BCQRNRKFWAN a, QOPPARWDDEP b, IHSTJJNLZKT c, StackTimer<string>.ERYHZSBUWXZ d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private void IDDFUSXEPNH(RoomOperationState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	internal struct CreateCV1MappingsTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private NIJQVUPMTTA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private BCQRNRKFWAN data;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		private TPICXMNKDPD TUDUSUBOTJK
		{
			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x8D75A00", Offset = "0x8D74000", VA = "0x188D75A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x8D75710", Offset = "0x8D73D10", VA = "0x188D75710")]
		public static Task Run(NIJQVUPMTTA roomManager, BCQRNRKFWAN data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x8D757F0", Offset = "0x8D73DF0", VA = "0x188D757F0")]
		private void Run()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	internal struct DeserializeConnectablesTask
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x8D75A50", Offset = "0x8D74050", VA = "0x188D75A50")]
		public static Task Run(CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	internal struct DeserializeObjectsCompleteTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200015C")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005C0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005C1")]
			public TRMFSAPCCPK operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005C2")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005C3")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005C4")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			private StackTimer<string>.ERYHZSBUWXZ <outboundTrafficTimer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x8D83EB0", Offset = "0x8D824B0", VA = "0x188D83EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0x8D85310", Offset = "0x8D83910", VA = "0x188D85310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8D75B30", Offset = "0x8D74130", VA = "0x188D75B30")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(TRMFSAPCCPK operationContext, BCQRNRKFWAN data, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	internal struct DeserializeObjectsTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200015F")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public TRMFSAPCCPK operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005CE")]
			public QOPPARWDDEP timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005CF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005D0")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005D1")]
			private NIJQVUPMTTA <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005D2")]
			private TPICXMNKDPD <callbacks>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005D3")]
			private RoomOperationState <operationState>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x40005D4")]
			private bool <isMaster>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005D5")]
			private LogRangeScope <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			private IDisposable <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			private List<(PersistenceView, UMNTAHYOPJM)>.Enumerator <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			private PersistenceView <view>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			private UMNTAHYOPJM <viewData>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x8D831F0", Offset = "0x8D817F0", VA = "0x188D831F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x8D851F0", Offset = "0x8D837F0", VA = "0x188D851F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D75C70", Offset = "0x8D74270", VA = "0x188D75C70")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(TRMFSAPCCPK operationContext, BCQRNRKFWAN data, QOPPARWDDEP timedYielder, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x8D75DC0", Offset = "0x8D743C0", VA = "0x188D75DC0")]
		private static void VHTCSYYWTHY(PersistenceView a, UMNTAHYOPJM b, BCQRNRKFWAN c, RoomOperationState d, bool e)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	internal struct DeserializeSettingsTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000161")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005DC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005DD")]
			public NIJQVUPMTTA roomManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005DF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005E0")]
			private LogRangeScope <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005E1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x8D843E0", Offset = "0x8D829E0", VA = "0x188D843E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x8D85250", Offset = "0x8D83850", VA = "0x188D85250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x8D75FA0", Offset = "0x8D745A0", VA = "0x188D75FA0")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(NIJQVUPMTTA roomManager, BCQRNRKFWAN data, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	internal struct DestroyOldObjectsTask
	{
		[Cpp2IlInjected.Token(Token = "0x2000163")]
		[CompilerGenerated]
		private sealed class TBDIAOPJOEZ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000164")]
			private struct <<Run>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40005E8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40005E9")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40005EA")]
				public StackTimer<string>.ERYHZSBUWXZ timer;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40005EB")]
				public CancellationToken token;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40005EC")]
				public TBDIAOPJOEZ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40005ED")]
				private StackTimer<string>.ERYHZSBUWXZ <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40005EE")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60005F5")]
				[Cpp2IlInjected.Address(RVA = "0x8D8CB50", Offset = "0x8D8B150", VA = "0x188D8CB50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005F6")]
				[Cpp2IlInjected.Address(RVA = "0x8D8CEE0", Offset = "0x8D8B4E0", VA = "0x188D8CEE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005E7")]
			public Task PHUYPMQBXVC;

			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TBDIAOPJOEZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x8D798B0", Offset = "0x8D77EB0", VA = "0x188D798B0")]
			[AsyncStateMachine(typeof(<<Run>b__0>d))]
			internal Task BQJEDCMZLND(StackTimer<string>.ERYHZSBUWXZ a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000165")]
		[CompilerGenerated]
		private sealed class NEFENOBNJAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005EF")]
			public DEPRECATED_RoomPersistenceVersion version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40005F0")]
			public bool NIKXKLVTFNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005F1")]
			public List<PersistenceView> BAVVSBPYZGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F2")]
			public List<GameObject> HEOYPYJRASR;

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public NEFENOBNJAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x8D78F90", Offset = "0x8D77590", VA = "0x188D78F90")]
			internal object SWACJJNSSDR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x8D78EE0", Offset = "0x8D774E0", VA = "0x188D78EE0")]
			internal object SVUVMCTVISI()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000166")]
		[CompilerGenerated]
		private struct <Run>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005F3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005F4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			public DestroyOldObjectsTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005F8")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005F9")]
			private object <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40005FA")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40005FB")]
			private LogRangeScope <_>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40005FC")]
			private TaskAwaiter<NVFUFUSEYRF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x8D85370", Offset = "0x8D83970", VA = "0x188D85370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x8D85F60", Offset = "0x8D84560", VA = "0x188D85F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		[CompilerGenerated]
		private struct <Run>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005FE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005FF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000600")]
			public NIJQVUPMTTA roomManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000601")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000602")]
			public TRMFSAPCCPK operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000603")]
			public bool useCompletionMark;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000604")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000605")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000606")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x8D87EC0", Offset = "0x8D864C0", VA = "0x188D87EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x8D880D0", Offset = "0x8D866D0", VA = "0x188D880D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private NIJQVUPMTTA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private BCQRNRKFWAN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private TRMFSAPCCPK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private bool useCompletionMark;

		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private static readonly ByteString destroyObjectsGuid;

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		private TPICXMNKDPD TUDUSUBOTJK
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x8D76BC0", Offset = "0x8D751C0", VA = "0x188D76BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		private KEWSLRECSSV VXTOLEXPLIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x8D76860", Offset = "0x8D74E60", VA = "0x188D76860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x8D76940", Offset = "0x8D74F40", VA = "0x188D76940")]
		[AsyncStateMachine(typeof(<Run>d__5))]
		public static Task Run(NIJQVUPMTTA roomManager, BCQRNRKFWAN data, TRMFSAPCCPK operationContext, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken, bool useCompletionMark)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x8D76A90", Offset = "0x8D75090", VA = "0x188D76A90")]
		[AsyncStateMachine(typeof(<Run>d__10))]
		private Task Run(StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x8D760C0", Offset = "0x8D746C0", VA = "0x188D760C0")]
		private void DestroyActivePersistenceViews([NotNull] PersistedRoomData downloadedRoomData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x8D76900", Offset = "0x8D74F00", VA = "0x188D76900")]
		private bool RJDTJYZFWKS(DEPRECATED_RoomPersistenceVersion a, PersistedRoomData b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	internal struct FetchDeserializationDataTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000169")]
		[CompilerGenerated]
		private struct <DownloadAssetBundles>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000616")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			public AsyncTaskMethodBuilder<Result<MNDWJRWMSJX, VMQHICPCFYT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			public StackTimer<string>.ERYHZSBUWXZ downloadTimerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			public FetchDeserializationDataTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400061A")]
			public Guid? unityAssetId;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400061B")]
			public IReadOnlyCollection<BakedUnitySubAssetDTO> unitySubAssets;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			public IReadOnlyCollection<BakedUnitySubAssetDTO> referencedUnityAssets;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			public long? roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x400061E")]
			public long? subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x400061F")]
			public RecNet.Core.OnDownloadProgressDelegate downloadProgressCallback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000620")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x4000621")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x4000622")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000623")]
			private TaskAwaiter<Result<MNDWJRWMSJX, VMQHICPCFYT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x8D7BC10", Offset = "0x8D7A210", VA = "0x188D7BC10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x8D7C270", Offset = "0x8D7A870", VA = "0x188D7C270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016A")]
		[CompilerGenerated]
		private struct <Run>d__16 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000624")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000625")]
			public AsyncTaskMethodBuilder<BCQRNRKFWAN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000626")]
			public FetchDeserializationDataTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000627")]
			public RecNet.Core.OnDownloadProgressDelegate downloadProgressCallback;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000628")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000629")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400062A")]
			private StackTimer<string>.ERYHZSBUWXZ <downloadTimerScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400062B")]
			private TaskAwaiter<IReadOnlyCollection<BakedUnitySubAssetDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400062C")]
			private TaskAwaiter<(Result<MNDWJRWMSJX, VMQHICPCFYT>, Result<ParseResult<PersistedRoomData>, VMQHICPCFYT>, Result<ParseResult<SuperRoomData>, VMQHICPCFYT>, Result<ParseResult<IEnumerable<RoomAssetData>>, VMQHICPCFYT>, Result<ParseResult<UFGPJUQJOWM>, VMQHICPCFYT>)> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x8D86480", Offset = "0x8D84A80", VA = "0x188D86480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x8D87190", Offset = "0x8D85790", VA = "0x188D87190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private VersionedDataGetter<FilenameWithHash, SuperRoomData> superRoomGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private VersionedDataGetter<FilenameWithHash, PersistedRoomData> subRoomGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		private VersionedDataGetter<RoomLoadDTO, IEnumerable<RoomAssetData>> roomAssetGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private VersionedDataGetter<long, UFGPJUQJOWM> playerSaveGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private ZFJSMTGXQWR subRoomAssetBundleProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private RoomDetailsDTO roomDetails;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private SubRoomDTO subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private IReadOnlyCollection<BakedUnitySubAssetDTO> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private Task<IReadOnlyCollection<BakedUnitySubAssetDTO>> referencedUnityAssetsTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private FilenameWithHash superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private FilenameWithHash subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private FilenameWithHash? roomAssetData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private RoomLoadDTO roomLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private StackTimer<string>.ERYHZSBUWXZ timer;

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x8D76CA0", Offset = "0x8D752A0", VA = "0x188D76CA0")]
		public static Task<BCQRNRKFWAN> FQSTKWZAHCQ(NIJQVUPMTTA a, [In] RoomLoadDetails data, RecNet.Core.OnDownloadProgressDelegate b, StackTimer<string>.ERYHZSBUWXZ c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x8D77370", Offset = "0x8D75970", VA = "0x188D77370")]
		[AsyncStateMachine(typeof(<Run>d__16))]
		private Task<BCQRNRKFWAN> Run(RecNet.Core.OnDownloadProgressDelegate downloadProgressCallback, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x8D77140", Offset = "0x8D75740", VA = "0x188D77140")]
		[AsyncStateMachine(typeof(<DownloadAssetBundles>d__17))]
		private Task<Result<MNDWJRWMSJX, VMQHICPCFYT>> HVVLIZHWOWF(Guid? a, IReadOnlyCollection<BakedUnitySubAssetDTO> b, IReadOnlyCollection<BakedUnitySubAssetDTO> c, long? d, long? e, RecNet.Core.OnDownloadProgressDelegate f, StackTimer<string>.ERYHZSBUWXZ g, CancellationToken h)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	internal struct FetchRoomLoadDetailsTask
	{
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		[CompilerGenerated]
		private sealed class OHRLUJXVIGI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200016D")]
			private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000646")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000647")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000648")]
				public OHRLUJXVIGI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000649")]
				private StackTimer<string>.ERYHZSBUWXZ <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400064A")]
				private TaskAwaiter<RemoteRunDTO> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400064B")]
				private TaskAwaiter<SubRoomDataSaveWithUnityAssetsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600060E")]
				[Cpp2IlInjected.Address(RVA = "0x8D8A120", Offset = "0x8D88720", VA = "0x188D8A120", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600060F")]
				[Cpp2IlInjected.Address(RVA = "0x8D8AAC0", Offset = "0x8D890C0", VA = "0x188D8AAC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000637")]
			public long ZXDMIWAEXTS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000638")]
			public string CFPUYXGMMBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			public THVASARWEQV SHHJKVVDLHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			public StackTimer<string>.ERYHZSBUWXZ KLYBBBDLWPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			public TPICXMNKDPD FZDXDPPJXPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			public CancellationToken YBWQEIOLJEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			public Guid? QNGIVKXMZTM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400063E")]
			public FilenameWithHash ZEFZSURADLS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400063F")]
			public FilenameWithHash XMFKFOLMBQV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			public long RVZKRFZHZDX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			public long RWUYOLZUSTQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			public IReadOnlyList<BakedUnitySubAssetDTO> SCROEUAAHEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000643")]
			public IReadOnlyList<BakedUnitySubAssetDTO> AKZDKKDQDJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000644")]
			public Guid ERASXYOLLZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			public RoomDetailsDTO MNSDUFUZKED;

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OHRLUJXVIGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x13BC090", Offset = "0x13BA690", VA = "0x1813BC090")]
			internal bool ZKILDKOIWQR(SubRoomDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x8D79260", Offset = "0x8D77860", VA = "0x188D79260")]
			[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
			internal Task YYGUUFGCNDK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x8D79060", Offset = "0x8D77660", VA = "0x188D79060")]
			internal Task<RoomLoadDTO> GXBHDDZBWBA()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		[CompilerGenerated]
		private struct <FetchRoomLoadDetails>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400064C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400064D")]
			public AsyncTaskMethodBuilder<RoomLoadDetails> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400064E")]
			public FetchRoomLoadDetailsTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400064F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			private TaskAwaiter<RoomLoadDetails> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x8D7C2E0", Offset = "0x8D7A8E0", VA = "0x188D7C2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x8D7C760", Offset = "0x8D7AD60", VA = "0x188D7C760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016F")]
		[CompilerGenerated]
		private struct <FetchRoomLoadDetails>d__13 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000652")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000653")]
			public AsyncTaskMethodBuilder<RoomLoadDetails> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			public long subroomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			public string studioSessionId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000656")]
			public THVASARWEQV roomLoadDataProviderOverride;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000657")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000658")]
			public TPICXMNKDPD callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000659")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400065A")]
			public long subRoomDataSaveId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400065B")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400065C")]
			public Guid roomAssetsSnapshotId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400065D")]
			public FilenameWithHash superRoomBlobName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400065E")]
			private OHRLUJXVIGI <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400065F")]
			private SubRoomDTO <subroom>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000660")]
			private Task<RoomLoadDTO> <getRoomLoadDTOTask>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000661")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000662")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000663")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000664")]
			private TaskAwaiter<RoomLoadDTO> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x8D7C7D0", Offset = "0x8D7ADD0", VA = "0x188D7C7D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x8D7D760", Offset = "0x8D7BD60", VA = "0x188D7D760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		[CompilerGenerated]
		private struct <Run>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000665")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000666")]
			public AsyncTaskMethodBuilder<RoomLoadDetails> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000667")]
			public FetchRoomLoadDetailsTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000668")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000669")]
			private StackTimer<string>.ERYHZSBUWXZ <subTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400066A")]
			private TaskAwaiter<RoomLoadDetails> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x8D85FC0", Offset = "0x8D845C0", VA = "0x188D85FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0x8D86410", Offset = "0x8D84A10", VA = "0x188D86410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private TPICXMNKDPD callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private TGHUEWOZHWI debugRoomLoadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private THVASARWEQV roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private StackTimer<string>.ERYHZSBUWXZ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private FilenameWithHash superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x8D77550", Offset = "0x8D75B50", VA = "0x188D77550")]
		public static Task<RoomLoadDetails> FQSTKWZAHCQ(NIJQVUPMTTA a, RoomLoadRequestPayload b, StackTimer<string>.ERYHZSBUWXZ c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x8D777A0", Offset = "0x8D75DA0", VA = "0x188D777A0")]
		[AsyncStateMachine(typeof(<Run>d__11))]
		private Task<RoomLoadDetails> Run(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x8D77AC0", Offset = "0x8D760C0", VA = "0x188D77AC0")]
		[AsyncStateMachine(typeof(<FetchRoomLoadDetails>d__12))]
		private Task<RoomLoadDetails> TJTTYJABLLR(StackTimer<string>.ERYHZSBUWXZ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8D778F0", Offset = "0x8D75EF0", VA = "0x188D778F0")]
		[AsyncStateMachine(typeof(<FetchRoomLoadDetails>d__13))]
		private static Task<RoomLoadDetails> TJTTYJABLLR(TPICXMNKDPD a, THVASARWEQV b, long c, long d, long e, string f, FilenameWithHash g, Guid h, CancellationToken i, StackTimer<string>.ERYHZSBUWXZ j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x8D77520", Offset = "0x8D75B20", VA = "0x188D77520")]
		private void ESRUILGWHDH(RoomDetailsDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	internal struct FlushCommandsSlowlyTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000173")]
		[CompilerGenerated]
		private struct <Run>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000673")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000674")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000675")]
			public FlushCommandsSlowlyTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000676")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000677")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000678")]
			private float <nextResendTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x8D88190", Offset = "0x8D86790", VA = "0x188D88190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0x8D88720", Offset = "0x8D86D20", VA = "0x188D88720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private TPICXMNKDPD callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private BCQRNRKFWAN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private StackTimer<string>.ERYHZSBUWXZ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private float resendInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private float maxWaitEndTime;

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x8D780B0", Offset = "0x8D766B0", VA = "0x188D780B0")]
		public static Task VANXZYEHBXM(NIJQVUPMTTA a, BCQRNRKFWAN b, StackTimer<string>.ERYHZSBUWXZ c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x8D77F90", Offset = "0x8D76590", VA = "0x188D77F90")]
		[AsyncStateMachine(typeof(<Run>d__8))]
		public Task Run(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x8D77C30", Offset = "0x8D76230", VA = "0x188D77C30")]
		private static void CKLBXTIGZKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x8D77E40", Offset = "0x8D76440", VA = "0x188D77E40")]
		private void NWOYXZTENND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x8D77D60", Offset = "0x8D76360", VA = "0x188D77D60")]
		private static float FANLVPWZNUC(TPICXMNKDPD a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8D77E20", Offset = "0x8D76420", VA = "0x188D77E20")]
		private static float KYHBVSFSNFX()
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	internal struct InstantiateObjectsTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000175")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400067A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400067B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400067C")]
			public TRMFSAPCCPK operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400067D")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000680")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			private YARKOAWAUMF <operation>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000682")]
			private NIJQVUPMTTA <roomManager>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000683")]
			private PreInstantiateObjectsTask.Results <instantiations>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000684")]
			private TaskAwaiter<NVFUFUSEYRF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000685")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x8D84A00", Offset = "0x8D83000", VA = "0x188D84A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x8D852B0", Offset = "0x8D838B0", VA = "0x188D852B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000176")]
		[CompilerGenerated]
		private struct <WaitForInstantiatedObjectsToInitialize>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000686")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000687")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000688")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000689")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0x8D8D2F0", Offset = "0x8D8B8F0", VA = "0x188D8D2F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x8D8D620", Offset = "0x8D8BC20", VA = "0x188D8D620", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x8D78250", Offset = "0x8D76850", VA = "0x188D78250")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(TRMFSAPCCPK operationContext, BCQRNRKFWAN data, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x8D78390", Offset = "0x8D76990", VA = "0x188D78390")]
		private static Task<NVFUFUSEYRF> VDGJBIMGOFS(TRMFSAPCCPK a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x8D78400", Offset = "0x8D76A00", VA = "0x188D78400")]
		[AsyncStateMachine(typeof(<WaitForInstantiatedObjectsToInitialize>d__2))]
		private static Task WaitForInstantiatedObjectsToInitialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	internal struct LoadEmptySceneTask
	{
		[Cpp2IlInjected.Token(Token = "0x2000178")]
		[CompilerGenerated]
		private sealed class SSSKYROOASY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400068E")]
			public string VHQFUGBZKUL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400068F")]
			public bool UJQUAHMVCRY;

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SSSKYROOASY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062E")]
			[Cpp2IlInjected.Address(RVA = "0x8D79840", Offset = "0x8D77E40", VA = "0x188D79840")]
			internal object OXDDDEUERJH()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000179")]
		[CompilerGenerated]
		private struct <Run>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000690")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000691")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000692")]
			public LoadEmptySceneTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000693")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000694")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000695")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x8D87730", Offset = "0x8D85D30", VA = "0x188D87730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x8D88130", Offset = "0x8D86730", VA = "0x188D88130", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200017A")]
		[CompilerGenerated]
		private struct <SafeLoadSceneAsync>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000696")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000697")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000698")]
			public string sceneName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000699")]
			public bool stopOnEmptyScene;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400069A")]
			public LoadEmptySceneTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400069B")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400069C")]
			private TaskAwaiter<Scene> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x8D88C70", Offset = "0x8D87270", VA = "0x188D88C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x8D890E0", Offset = "0x8D876E0", VA = "0x188D890E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private bool isOffline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private StackTimer<string>.ERYHZSBUWXZ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private NIJQVUPMTTA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x8D784C0", Offset = "0x8D76AC0", VA = "0x188D784C0")]
		public static Task LoadEmptyScene(NIJQVUPMTTA roomManager, bool isOffline, StackTimer<string>.ERYHZSBUWXZ timer, CancellationToken roomCancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x8D78530", Offset = "0x8D76B30", VA = "0x188D78530")]
		[AsyncStateMachine(typeof(<Run>d__5))]
		private Task Run()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x8D78620", Offset = "0x8D76C20", VA = "0x188D78620")]
		[AsyncStateMachine(typeof(<SafeLoadSceneAsync>d__6))]
		private Task VLVYOSFCAQJ(bool a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0")]
		private bool CRZMHKOZJXH(bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal struct LoadSceneTask
	{
		[Cpp2IlInjected.Token(Token = "0x200017C")]
		[CompilerGenerated]
		private sealed class XMEHEWGCGRP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006A0")]
			public string VHQFUGBZKUL;

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public XMEHEWGCGRP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x8D8D680", Offset = "0x8D8BC80", VA = "0x188D8D680")]
			internal object OXDDDEUERJH()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200017D")]
		[CompilerGenerated]
		private struct <Run>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006A2")]
			public AsyncTaskMethodBuilder<Scene> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006A3")]
			public LoadSceneTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006A4")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006A5")]
			private TaskAwaiter<Scene> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0x8D87200", Offset = "0x8D85800", VA = "0x188D87200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x8D876C0", Offset = "0x8D85CC0", VA = "0x188D876C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200017E")]
		[CompilerGenerated]
		private struct <SafeLoadSceneAsync>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006A6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006A7")]
			public AsyncTaskMethodBuilder<Scene> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006A8")]
			public string sceneName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006A9")]
			public LoadSceneTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006AA")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006AB")]
			private TaskAwaiter<Scene> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x8D88780", Offset = "0x8D86D80", VA = "0x188D88780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x8D88C00", Offset = "0x8D87200", VA = "0x188D88C00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private RoomSceneLocations roomLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private StackTimer<string>.ERYHZSBUWXZ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private NIJQVUPMTTA roomManager;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x8D789A0", Offset = "0x8D76FA0", VA = "0x188D789A0")]
		public static Task<Scene> WWDXTOCRSEY(NIJQVUPMTTA a, RoomSceneLocations b, StackTimer<string>.ERYHZSBUWXZ c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x8D78750", Offset = "0x8D76D50", VA = "0x188D78750")]
		[AsyncStateMachine(typeof(<Run>d__4))]
		private Task<Scene> Run()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x8D78860", Offset = "0x8D76E60", VA = "0x188D78860")]
		[AsyncStateMachine(typeof(<SafeLoadSceneAsync>d__5))]
		private Task<Scene> VLVYOSFCAQJ(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	internal struct MoveToPhaseTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000180")]
		[CompilerGenerated]
		private struct <MoveTo>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006B0")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006B1")]
			public MoveToPhaseTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006B2")]
			public RoomOperationState nextPhase;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006B3")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006B4")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006B5")]
			public bool skipHandlers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40006B6")]
			public BCQRNRKFWAN deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40006B7")]
			private StackTimer<string>.ERYHZSBUWXZ <moveToPhaseTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40006B8")]
			private Guid <handlersGuid>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40006B9")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40006BA")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x8D99180", Offset = "0x8D97780", VA = "0x188D99180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x8D99C20", Offset = "0x8D98220", VA = "0x188D99C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000181")]
		[CompilerGenerated]
		private struct <SendStateChangeMessage>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006BC")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006BD")]
			public MoveToPhaseTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006BE")]
			public RoomOperationState state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006BF")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006C0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C1")]
			private TaskAwaiter<NVFUFUSEYRF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x8D9ED00", Offset = "0x8D9D300", VA = "0x188D9ED00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x8D9EFD0", Offset = "0x8D9D5D0", VA = "0x188D9EFD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private readonly TRMFSAPCCPK operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private readonly TGHUEWOZHWI debugRoomLoadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private readonly LWSUKBSGQIG handlers;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		private YARKOAWAUMF GUFWKIXWKMR
		{
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x407DE10", Offset = "0x407C410", VA = "0x18407DE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x8D78E80", Offset = "0x8D77480", VA = "0x188D78E80")]
		public MoveToPhaseTask(TRMFSAPCCPK operationContext, TGHUEWOZHWI debugRoomLoadInfo, LWSUKBSGQIG handlers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x8D78D00", Offset = "0x8D77300", VA = "0x188D78D00")]
		[AsyncStateMachine(typeof(<MoveTo>d__6))]
		public Task<RoomOperationState> MoveTo(RoomOperationState nextPhase, BCQRNRKFWAN deserializationData, StackTimer<string>.ERYHZSBUWXZ stackTimer, CancellationToken cancellationToken, bool skipHandlers)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x8D78B80", Offset = "0x8D77180", VA = "0x188D78B80")]
		[AsyncStateMachine(typeof(<SendStateChangeMessage>d__7))]
		private Task<RoomOperationState> LSKBDMYKDJY(StackTimer<string>.ERYHZSBUWXZ a, RoomOperationState b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x8D78B50", Offset = "0x8D77150", VA = "0x188D78B50")]
		private bool APVSHTBYVML(RoomOperationState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x8D78CE0", Offset = "0x8D772E0", VA = "0x188D78CE0")]
		private void Log(string msg)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	internal struct PostDeserializeObjectsTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000183")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			public YARKOAWAUMF operation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			public QOPPARWDDEP timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006C7")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			private bool <isMaster>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			private LogRangeScope <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			private List<(PersistenceView, UMNTAHYOPJM)>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			private (PersistenceView, UMNTAHYOPJM) <pair>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x8D9C420", Offset = "0x8D9AA20", VA = "0x188D9C420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x8D9D420", Offset = "0x8D9BA20", VA = "0x188D9D420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x8D94DA0", Offset = "0x8D933A0", VA = "0x188D94DA0")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(YARKOAWAUMF operation, BCQRNRKFWAN data, QOPPARWDDEP timedYielder, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	internal struct PreDeserializeObjectsTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006CE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006CF")]
			public YARKOAWAUMF operation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006D0")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006D1")]
			public QOPPARWDDEP timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006D2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006D3")]
			private bool <isMaster>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40006D4")]
			private DEPRECATED_RoomPersistenceVersion <DEPRECATED_version>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006D5")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40006D6")]
			private IDisposable <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40006D7")]
			private List<(PersistenceView, UMNTAHYOPJM)>.Enumerator <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40006D8")]
			private PersistenceView <view>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40006D9")]
			private UMNTAHYOPJM <viewData>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40006DA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x8D9CAE0", Offset = "0x8D9B0E0", VA = "0x188D9CAE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x8D9D3C0", Offset = "0x8D9B9C0", VA = "0x188D9D3C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x8D94EE0", Offset = "0x8D934E0", VA = "0x188D94EE0")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(YARKOAWAUMF operation, BCQRNRKFWAN data, QOPPARWDDEP timedYielder, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	public struct PrefetchAssetBundlesTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000187")]
		[CompilerGenerated]
		private struct <Run>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006E2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006E3")]
			public AsyncTaskMethodBuilder<Result<MNDWJRWMSJX, VMQHICPCFYT>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006E4")]
			public PrefetchAssetBundlesTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40006E5")]
			public RecNet.Core.OnDownloadProgressDelegate preloadProgressCallback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40006E6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40006E7")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40006E8")]
			private TaskAwaiter<Result<MNDWJRWMSJX, VMQHICPCFYT>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x8D9E620", Offset = "0x8D9CC20", VA = "0x188D9E620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x8D9EC90", Offset = "0x8D9D290", VA = "0x188D9EC90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		private long _roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		private long _subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		private Guid? _unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		private IReadOnlyCollection<BakedUnitySubAssetDTO> _unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private IReadOnlyCollection<BakedUnitySubAssetDTO> _referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		private ZFJSMTGXQWR _subRoomAssetBundleProvider;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x8D95A90", Offset = "0x8D94090", VA = "0x188D95A90")]
		public static Task<Result<MNDWJRWMSJX, VMQHICPCFYT>> FQSTKWZAHCQ(long a, long b, SubRoomDataSaveWithUnityAssetsDTO c, RecNet.Core.OnDownloadProgressDelegate d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x8D95BF0", Offset = "0x8D941F0", VA = "0x188D95BF0")]
		[AsyncStateMachine(typeof(<Run>d__8))]
		private Task<Result<MNDWJRWMSJX, VMQHICPCFYT>> Run(RecNet.Core.OnDownloadProgressDelegate preloadProgressCallback, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	internal struct PreInstantiateObjectsTask
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		public struct Results
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			public List<QKRWEEKVSVZ> instantiationRequests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			public List<UMNTAHYOPJM> requestDatas;

			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xCD7A50", Offset = "0xCD6050", VA = "0x180CD7A50")]
			public Results(List<QKRWEEKVSVZ> instantiationRequests, List<UMNTAHYOPJM> requestDatas)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018A")]
		[CompilerGenerated]
		private sealed class TYGMGLNVTBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			public IEnumerable<QKRWEEKVSVZ> UKQUEEFCVZV;

			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TYGMGLNVTBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0x8D97A20", Offset = "0x8D96020", VA = "0x188D97A20")]
			internal object EMXZCYQTRGZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private NIJQVUPMTTA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private BCQRNRKFWAN data;

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		private TPICXMNKDPD TUDUSUBOTJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0x8D95A40", Offset = "0x8D94040", VA = "0x188D95A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x8D959E0", Offset = "0x8D93FE0", VA = "0x188D959E0")]
		public static Results Run(NIJQVUPMTTA roomManager, BCQRNRKFWAN data)
		{
			return default(Results);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x8D95780", Offset = "0x8D93D80", VA = "0x188D95780")]
		private Results Run()
		{
			return default(Results);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x8D95020", Offset = "0x8D93620", VA = "0x188D95020")]
		private Results JRQLAWMKPSJ(PersistedRoomData a, DEPRECATED_RoomPersistenceVersion b)
		{
			return default(Results);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x8D955C0", Offset = "0x8D93BC0", VA = "0x188D955C0")]
		private bool KTUAXQDJYIN(IEnumerable<QKRWEEKVSVZ> a)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	internal struct RegisterInstantiatedObjectsTask
	{
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[CompilerGenerated]
		private sealed class SPJGRQAUTAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			public PreInstantiateObjectsTask.Results YAIMUDGKMMK;

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SPJGRQAUTAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0x8D97590", Offset = "0x8D95B90", VA = "0x188D97590")]
			internal object BQJEDCMZLND()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018D")]
		[CompilerGenerated]
		private sealed class SPONOWUSCLX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006EF")]
			public PersistenceView CUSZKDRNPEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006F0")]
			public Guid BQQUKCGTEGU;

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SPONOWUSCLX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0x8D97640", Offset = "0x8D95C40", VA = "0x188D97640")]
			internal object BQDXFVTCCBU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x8D95E50", Offset = "0x8D94450", VA = "0x188D95E50")]
		public static void Run(YARKOAWAUMF operation, BCQRNRKFWAN data, PreInstantiateObjectsTask.Results instantiations)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	internal class LWSUKBSGQIG
	{
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		[CompilerGenerated]
		private sealed class NEFENOBNJAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F6")]
			public Guid WDMUPZBCWEN;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public NEFENOBNJAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x8D92890", Offset = "0x8D90E90", VA = "0x188D92890")]
			internal object ERXQWOWYPCO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000191")]
		[CompilerGenerated]
		private sealed class JVNLNTKKISD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F7")]
			public Guid WDMUPZBCWEN;

			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public JVNLNTKKISD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(RVA = "0x8D90AC0", Offset = "0x8D8F0C0", VA = "0x188D90AC0")]
			internal object QQYJBYAKPTY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000192")]
		[CompilerGenerated]
		private sealed class OHRLUJXVIGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F8")]
			public Guid WDMUPZBCWEN;

			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OHRLUJXVIGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(RVA = "0x8D92950", Offset = "0x8D90F50", VA = "0x188D92950")]
			internal object FCKVLCMABJJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[CompilerGenerated]
		private sealed class SSSKYROOASY
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000194")]
			private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40006FD")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40006FE")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40006FF")]
				public SSSKYROOASY <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000700")]
				public CancellationToken mlbToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000701")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000678")]
				[Cpp2IlInjected.Address(RVA = "0x8DA0000", Offset = "0x8D9E600", VA = "0x188DA0000", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000679")]
				[Cpp2IlInjected.Address(RVA = "0x8DA02C0", Offset = "0x8D9E8C0", VA = "0x188DA02C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F9")]
			public LWSUKBSGQIG CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006FA")]
			public BCQRNRKFWAN QHPHTAHQMYA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			public StackTimer<string>.ERYHZSBUWXZ KAAXPXPGRWV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			public Func<CancellationToken, Task> LGWPYJTLUNX;

			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SSSKYROOASY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(RVA = "0x8D976D0", Offset = "0x8D95CD0", VA = "0x188D976D0")]
			[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
			internal Task ADHIBBMVBVC(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[CompilerGenerated]
		private sealed class PMCLZVAKTMZ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000196")]
			private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000707")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000708")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000709")]
				public DeserializationPhaseHandler handler;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400070A")]
				public PMCLZVAKTMZ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400070B")]
				private LogRangeScope <_>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400070C")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600067E")]
				[Cpp2IlInjected.Address(RVA = "0x8D9FB40", Offset = "0x8D9E140", VA = "0x188D9FB40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600067F")]
				[Cpp2IlInjected.Address(RVA = "0x8D9FFA0", Offset = "0x8D9E5A0", VA = "0x188D9FFA0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000702")]
			public RunFor RZHPKKHBKBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000703")]
			public Guid RLTBBCDDSZP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000704")]
			public List<DeserializationPhaseHandler> ZPHEGABAAUG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000705")]
			public BCQRNRKFWAN QHPHTAHQMYA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000706")]
			public CancellationToken YABTGEYHGAN;

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public PMCLZVAKTMZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x8D94AE0", Offset = "0x8D930E0", VA = "0x188D94AE0")]
			internal object XENVBPWOQTS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x8D94CA0", Offset = "0x8D932A0", VA = "0x188D94CA0")]
			[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
			internal Task XEYIWDKJJQK(DeserializationPhaseHandler a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x8D94BC0", Offset = "0x8D931C0", VA = "0x188D94BC0")]
			internal object XETBYWQMAFB()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000197")]
		[CompilerGenerated]
		private struct <InvokeMethodsInParallel>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400070D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400070E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400070F")]
			public RunFor runFor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000710")]
			public Guid handlerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000711")]
			public List<DeserializationPhaseHandler> methods;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000712")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000713")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000714")]
			private PMCLZVAKTMZ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000715")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0x8D97AF0", Offset = "0x8D960F0", VA = "0x188D97AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x8D97F80", Offset = "0x8D96580", VA = "0x188D97F80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[CompilerGenerated]
		private struct <MasterInvokeHandlerMethods>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000716")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000717")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000718")]
			public Guid handlerIdToRun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000719")]
			public LWSUKBSGQIG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400071A")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400071B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400071C")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400071D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x8D97FE0", Offset = "0x8D965E0", VA = "0x188D97FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x8D98490", Offset = "0x8D96A90", VA = "0x188D98490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		[CompilerGenerated]
		private struct <MasterLockedHandler>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400071E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400071F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000720")]
			public LWSUKBSGQIG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000721")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000722")]
			public StackTimer<string>.ERYHZSBUWXZ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000723")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000724")]
			private Guid <handlerIdToRun>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000725")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x8D984F0", Offset = "0x8D96AF0", VA = "0x188D984F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x8D98AA0", Offset = "0x8D970A0", VA = "0x188D98AA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019A")]
		[CompilerGenerated]
		private struct <MasterSyncSendCompletionMark>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000726")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000727")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000728")]
			public Guid handlerIdToRun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000729")]
			public LWSUKBSGQIG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400072A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400072B")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400072C")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400072D")]
			private ByteString <completionMark>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400072E")]
			private TaskAwaiter<NVFUFUSEYRF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0x8D98B00", Offset = "0x8D97100", VA = "0x188D98B00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000687")]
			[Cpp2IlInjected.Address(RVA = "0x8D99120", Offset = "0x8D97720", VA = "0x188D99120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019B")]
		[CompilerGenerated]
		private struct <Run>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400072F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000730")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000731")]
			public LWSUKBSGQIG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000732")]
			public RoomOperationState operationState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000733")]
			public BCQRNRKFWAN deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000734")]
			public StackTimer<string>.ERYHZSBUWXZ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000735")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000736")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0x8D9DB70", Offset = "0x8D9C170", VA = "0x188D9DB70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0x8D9E2D0", Offset = "0x8D9C8D0", VA = "0x188D9E2D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019C")]
		[CompilerGenerated]
		private struct <RunAllHandlers>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000737")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000738")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000739")]
			public LWSUKBSGQIG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400073A")]
			public StackTimer<string>.ERYHZSBUWXZ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400073B")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400073C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400073D")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400073E")]
			private Dictionary<Guid, List<DeserializationPhaseHandler>>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400073F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0x8D9AC40", Offset = "0x8D99240", VA = "0x188D9AC40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0x8D9B250", Offset = "0x8D99850", VA = "0x188D9B250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		[CompilerGenerated]
		private struct <RunAuthorityHandler>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000740")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000741")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000742")]
			public LWSUKBSGQIG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000743")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000744")]
			public StackTimer<string>.ERYHZSBUWXZ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000745")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000746")]
			private SSSKYROOASY <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000747")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0x8D9B2B0", Offset = "0x8D998B0", VA = "0x188D9B2B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068D")]
			[Cpp2IlInjected.Address(RVA = "0x8D9B7C0", Offset = "0x8D99DC0", VA = "0x188D9B7C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019E")]
		[CompilerGenerated]
		private struct <RunNonAuthorityHandlers>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000748")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000749")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400074A")]
			public LWSUKBSGQIG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400074B")]
			public StackTimer<string>.ERYHZSBUWXZ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400074C")]
			public BCQRNRKFWAN data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400074D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400074E")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400074F")]
			private Dictionary<Guid, List<DeserializationPhaseHandler>>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000750")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0x8D9BD20", Offset = "0x8D9A320", VA = "0x188D9BD20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068F")]
			[Cpp2IlInjected.Address(RVA = "0x8D9C3C0", Offset = "0x8D9A9C0", VA = "0x188D9C3C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private readonly TRMFSAPCCPK VZOSNLCYVMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private DeserializationHandlerLists CFDLQOMUGUV;

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		private YARKOAWAUMF GUFWKIXWKMR
		{
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x134A510", Offset = "0x1348B10", VA = "0x18134A510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public LWSUKBSGQIG(TRMFSAPCCPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x8D91EA0", Offset = "0x8D904A0", VA = "0x188D91EA0")]
		[AsyncStateMachine(typeof(<Run>d__5))]
		public Task Run(RoomOperationState operationState, BCQRNRKFWAN deserializationData, StackTimer<string>.ERYHZSBUWXZ timer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x8D91680", Offset = "0x8D8FC80", VA = "0x188D91680")]
		[AsyncStateMachine(typeof(<RunAuthorityHandler>d__6))]
		private Task HOFZPNIAZHE(BCQRNRKFWAN a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x8D91540", Offset = "0x8D8FB40", VA = "0x188D91540")]
		[AsyncStateMachine(typeof(<RunAllHandlers>d__7))]
		private Task EOXOMIRILDP(BCQRNRKFWAN a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x8D91400", Offset = "0x8D8FA00", VA = "0x188D91400")]
		[AsyncStateMachine(typeof(<RunNonAuthorityHandlers>d__8))]
		private Task ELWWHVXMAUU(BCQRNRKFWAN a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x8D91BF0", Offset = "0x8D901F0", VA = "0x188D91BF0")]
		[AsyncStateMachine(typeof(<InvokeMethodsInParallel>d__9))]
		private Task NLWJDDGBLRQ(Guid a, List<DeserializationPhaseHandler> b, RunFor c, BCQRNRKFWAN d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x8D917C0", Offset = "0x8D8FDC0", VA = "0x188D917C0")]
		[AsyncStateMachine(typeof(<MasterLockedHandler>d__10))]
		private Task IURLDHVLRTS(BCQRNRKFWAN a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x8D912C0", Offset = "0x8D8F8C0", VA = "0x188D912C0")]
		[AsyncStateMachine(typeof(<MasterInvokeHandlerMethods>d__11))]
		private Task CKLGYJBDRSA(Guid a, BCQRNRKFWAN b, StackTimer<string>.ERYHZSBUWXZ c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x8D91900", Offset = "0x8D8FF00", VA = "0x188D91900")]
		[AsyncStateMachine(typeof(<MasterSyncSendCompletionMark>d__12))]
		private Task MSGNSDLTCHG(Guid a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x8D91AE0", Offset = "0x8D900E0", VA = "0x188D91AE0")]
		private void MXNJOKJAGEP(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x8D91A40", Offset = "0x8D90040", VA = "0x188D91A40")]
		private void MURFQHBNDES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x8D91D40", Offset = "0x8D90340", VA = "0x188D91D40")]
		public Guid PFCVZNUYTVJ(RoomOperationState a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x8D91110", Offset = "0x8D8F710", VA = "0x188D91110")]
		[CompilerGenerated]
		private object AUKGBVWJMYS()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	internal struct RunEmptySceneTasksTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		[CompilerGenerated]
		private struct <Run>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000754")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000755")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000756")]
			public RunEmptySceneTasksTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000757")]
			private StackTimer<string>.ERYHZSBUWXZ <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000758")]
			private IEnumerator<EmptySceneHandler> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000759")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x8D9D480", Offset = "0x8D9BA80", VA = "0x188D9D480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x8D9DB10", Offset = "0x8D9C110", VA = "0x188D9DB10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private TPICXMNKDPD callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		private StackTimer<string>.ERYHZSBUWXZ timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x8D97430", Offset = "0x8D95A30", VA = "0x188D97430")]
		public static Task DZAXRJTJWPP(TPICXMNKDPD a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x8D974A0", Offset = "0x8D95AA0", VA = "0x188D974A0")]
		[AsyncStateMachine(typeof(<Run>d__4))]
		private Task Run()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	public readonly struct RoomSaveAnalyticsInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		public readonly bool LastLoadedSaveWasPublished;

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2D56040", Offset = "0x2D54640", VA = "0x182D56040")]
		public RoomSaveAnalyticsInfo(bool lastLoadedSaveWasPublished)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	public readonly struct RoomSerializedData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400075B")]
		public readonly PersistedRoomData? RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400075C")]
		public readonly PersistedRoomDataReferences RoomDataReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400075D")]
		public readonly Guid? UnityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400075E")]
		public readonly IReadOnlyList<Guid> RoomAssets;

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public IReadOnlyCollection<string> WBCDZYIMUIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000695")]
			[Cpp2IlInjected.Address(RVA = "0x8D96710", Offset = "0x8D94D10", VA = "0x188D96710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public IReadOnlyDictionary<long, int> WHMOHLFIROG
		{
			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0x8D96730", Offset = "0x8D94D30", VA = "0x188D96730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x8D96750", Offset = "0x8D94D50", VA = "0x188D96750")]
		public RoomSerializedData(PersistedRoomData? roomData, PersistedRoomDataReferences roomDataReferences, Guid? unityAssetId, [Optional] IReadOnlyList<Guid>? roomAssets)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	internal class OXXVJLEFDRW : ORSJLKFOEMV
	{
		[Cpp2IlInjected.Token(Token = "0x20001A5")]
		[CompilerGenerated]
		private sealed class TYGMGLNVTBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000765")]
			public float RKBUCJXUHFT;

			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TYGMGLNVTBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0x8D97A90", Offset = "0x8D96090", VA = "0x188D97A90")]
			internal object HEOKYQCEYYN()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001A6")]
		[CompilerGenerated]
		private struct <PreserializeViews>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000766")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000767")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000768")]
			public OXXVJLEFDRW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000769")]
			public PersistenceView[] activePersistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400076A")]
			public StringBuilder outputBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400076B")]
			public SerializeType serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400076C")]
			private TYGMGLNVTBE <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400076D")]
			private LogRangeScope <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400076E")]
			private CancellationTokenSource <cts>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400076F")]
			private IMEKMSZAYDL<Task> <tasks>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000770")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006A6")]
			[Cpp2IlInjected.Address(RVA = "0x8D99C90", Offset = "0x8D98290", VA = "0x188D99C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0x8D9A6C0", Offset = "0x8D98CC0", VA = "0x188D9A6C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001A7")]
		[CompilerGenerated]
		private struct <Serialize>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000771")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000772")]
			public AsyncTaskMethodBuilder<RoomSerializedData> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000773")]
			public OXXVJLEFDRW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000774")]
			public long subroomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000775")]
			public SerializeType serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000776")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000777")]
			public RoomSaveOptions roomSaveOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000778")]
			private PersistenceView[] <activePersistenceViews>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000779")]
			private StringBuilder <outputBuilder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400077A")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400077B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0x8D9F040", Offset = "0x8D9D640", VA = "0x188D9F040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0x8D9F6C0", Offset = "0x8D9DCC0", VA = "0x188D9F6C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		private readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private static readonly TimeSpan TYJMKZUOQWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private readonly NZKMJNOINZQ TMXDHUVIPLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private readonly MLMFYQLNVYI UMUAGADTOFP;

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x8D93F00", Offset = "0x8D92500", VA = "0x188D93F00")]
		public OXXVJLEFDRW(TRMFSAPCCPK a, NZKMJNOINZQ b, MLMFYQLNVYI c, Log d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x8D93A50", Offset = "0x8D92050", VA = "0x188D93A50")]
		[AsyncStateMachine(typeof(<Serialize>d__6))]
		public Task<RoomSerializedData> Serialize(long subroomId, RoomSaveOptions roomSaveOptions, SerializeType serializeType, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x8D93960", Offset = "0x8D91F60", VA = "0x188D93960")]
		private static bool SEMVAGUDCTY(PersistenceView a, [Out] RRObjectPolicy b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x8D93D50", Offset = "0x8D92350", VA = "0x188D93D50")]
		[AsyncStateMachine(typeof(<PreserializeViews>d__8))]
		private Task ZDFASVQJBWR(SerializeType a, PersistenceView[] b, StringBuilder c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x8D93150", Offset = "0x8D91750", VA = "0x188D93150")]
		private RoomSerializedData LLQJUVLMRGU(long a, RoomSaveOptions b, SerializeType c, IEnumerable<PersistenceView> d, StringBuilder e)
		{
			return default(RoomSerializedData);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x8D93BA0", Offset = "0x8D921A0", VA = "0x188D93BA0")]
		private PersistedRoomData WZUYUSGRZMW(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x8D93710", Offset = "0x8D91D10", VA = "0x188D93710")]
		private void OITDCBUYUBZ(PersistedRoomData a, StringBuilder b, IEnumerable<PersistenceView> c, [In] RoomSerializedMetadata metadata, CXLQYBJVKVP d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x8D92CE0", Offset = "0x8D912E0", VA = "0x188D92CE0")]
		private void CUNWTWOGZKY(PersistedRoomData a, StringBuilder b, PersistenceView c, CXLQYBJVKVP d, [In] RoomSerializedMetadata metadata)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	internal class RoomUploadLogic : ORSJLKFOEMV
	{
		[Cpp2IlInjected.Token(Token = "0x20001A9")]
		[CompilerGenerated]
		private sealed class JVNLNTKKISD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20001AA")]
			private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000787")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000788")]
				public AsyncTaskMethodBuilder<NVFUFUSEYRF> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000789")]
				public JVNLNTKKISD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400078A")]
				public CancellationToken masterLockedBlockCancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400078B")]
				private NVFUFUSEYRF <reloadMessage>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400078C")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400078D")]
				private TaskAwaiter<RemoteRunDTO> <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x400078E")]
				private TaskAwaiter<SaveSubRoomResponseDTO> <>u__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x400078F")]
				private TaskAwaiter<NVFUFUSEYRF> <>u__4;

				[Cpp2IlInjected.Token(Token = "0x60006B5")]
				[Cpp2IlInjected.Address(RVA = "0x8DA0320", Offset = "0x8D9E920", VA = "0x188DA0320", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006B6")]
				[Cpp2IlInjected.Address(RVA = "0x8DA1530", Offset = "0x8D9FB30", VA = "0x188DA1530", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400077F")]
			public RoomUploadLogic CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000780")]
			public RoomSerializedData IRTQNUXLAPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000781")]
			public int ZZPZQBRGDBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000782")]
			public long RWUYOLZUSTQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000783")]
			public long SGAXFWVIGFS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000784")]
			public RoomSaveRequestPayload HUFPTNWKMKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000785")]
			public RoomSaveAnalyticsInfo RYOTCLSVHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000786")]
			public StackTimer<string>.ERYHZSBUWXZ KLYBBBDLWPL;

			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public JVNLNTKKISD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B4")]
			[Cpp2IlInjected.Address(RVA = "0x8D90990", Offset = "0x8D8EF90", VA = "0x188D90990")]
			[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
			internal Task<NVFUFUSEYRF> JOSLNLAKAOO(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AB")]
		[CompilerGenerated]
		private sealed class OGOKSBBDBET
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000790")]
			public Storage.UploadFileResponseDTO SCUILOHSXIK;

			[Cpp2IlInjected.Token(Token = "0x60006B7")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OGOKSBBDBET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B8")]
			[Cpp2IlInjected.Address(RVA = "0x8D92900", Offset = "0x8D90F00", VA = "0x188D92900")]
			internal object SFIUWCVWKZE()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AC")]
		[CompilerGenerated]
		private struct <PushRoomDataBlobToStudio>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000791")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000792")]
			public AsyncTaskMethodBuilder<RemoteRunDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000793")]
			public RoomUploadLogic <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000794")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000795")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000796")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000797")]
			public string studioSessionId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000798")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000799")]
			private TaskAwaiter<(Storage.UploadFileResponseDTO roomDataUpload, Storage.UploadFileResponseDTO subRoomDataUpload)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400079A")]
			private TaskAwaiter<RemoteRunDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006B9")]
			[Cpp2IlInjected.Address(RVA = "0x8D9A720", Offset = "0x8D98D20", VA = "0x188D9A720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BA")]
			[Cpp2IlInjected.Address(RVA = "0x8D9ABD0", Offset = "0x8D991D0", VA = "0x188D9ABD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AD")]
		[CompilerGenerated]
		private struct <UploadRoomDataBlob>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400079B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400079C")]
			public AsyncTaskMethodBuilder<SaveSubRoomResponseDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400079D")]
			public TPICXMNKDPD callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400079E")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400079F")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			public UgcVersionInfo ugcVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007A2")]
			public RoomSaveRequestPayload roomSaveRequestPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007A3")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007A4")]
			private TaskAwaiter<(Storage.UploadFileResponseDTO roomDataUpload, Storage.UploadFileResponseDTO subRoomDataUpload)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007A5")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006BB")]
			[Cpp2IlInjected.Address(RVA = "0x8DA1E80", Offset = "0x8DA0480", VA = "0x188DA1E80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BC")]
			[Cpp2IlInjected.Address(RVA = "0x8DA24E0", Offset = "0x8DA0AE0", VA = "0x188DA24E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AE")]
		[CompilerGenerated]
		private struct <UploadRoomDataBlob>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007A6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007A7")]
			public AsyncTaskMethodBuilder<SaveSubRoomResponseDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007A8")]
			public RoomUploadLogic <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007A9")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007AA")]
			public RoomSaveRequestPayload roomSaveRequestPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007AB")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0x8DA2550", Offset = "0x8DA0B50", VA = "0x188DA2550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0x8DA27F0", Offset = "0x8DA0DF0", VA = "0x188DA27F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		[CompilerGenerated]
		private struct <UploadRoomDataBlobAndSyncReload>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			public AsyncTaskMethodBuilder<NVFUFUSEYRF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			public RoomUploadLogic <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			public RoomSaveRequestPayload roomSaveRequestPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007B7")]
			public RoomSaveAnalyticsInfo roomSaveAnalyticsInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007B8")]
			public StackTimer<string>.ERYHZSBUWXZ stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007B9")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007BA")]
			private TaskAwaiter<NVFUFUSEYRF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x8DA1AF0", Offset = "0x8DA00F0", VA = "0x188DA1AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0x8DA1E10", Offset = "0x8DA0410", VA = "0x188DA1E10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001B0")]
		[CompilerGenerated]
		private struct <UploadRoomDataToStorage>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007BC")]
			public AsyncTaskMethodBuilder<(Storage.UploadFileResponseDTO roomDataUpload, Storage.UploadFileResponseDTO subRoomDataUpload)> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007BD")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007BE")]
			public TPICXMNKDPD callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007BF")]
			private OGOKSBBDBET <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007C0")]
			private byte[] <data>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007C1")]
			private float <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40007C2")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007C3")]
			private TaskAwaiter<Storage.UploadFileResponseDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x8DA2860", Offset = "0x8DA0E60", VA = "0x188DA2860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0x8DA30A0", Offset = "0x8DA16A0", VA = "0x188DA30A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400077C")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x400077D")]
		private static readonly Log MRNLEIUSFDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		private readonly JUUVKXCVYPT HIJFVBKQQQE;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		private NIJQVUPMTTA TCZAJMILSXE
		{
			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0x8D5F090", Offset = "0x8D5D690", VA = "0x188D5F090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x8D973A0", Offset = "0x8D959A0", VA = "0x188D973A0")]
		public RoomUploadLogic(TRMFSAPCCPK operationContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D96840", Offset = "0x8D94E40", VA = "0x188D96840")]
		[AsyncStateMachine(typeof(<UploadRoomDataToStorage>d__7))]
		private static Task<(Storage.UploadFileResponseDTO, Storage.UploadFileResponseDTO)> GRHXJIHIHBC(TPICXMNKDPD a, RoomSerializedData b, long c, long d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x8D96FF0", Offset = "0x8D955F0", VA = "0x188D96FF0")]
		[AsyncStateMachine(typeof(<UploadRoomDataBlob>d__8))]
		public Task<SaveSubRoomResponseDTO> RIULJVVOHQR(int a, [CanBeNull] RoomSaveRequestPayload roomSaveRequestPayload, RoomSerializedData b, long c, long d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x8D96B10", Offset = "0x8D95110", VA = "0x188D96B10")]
		public static Task<SaveSubRoomResponseDTO> RIULJVVOHQR(TPICXMNKDPD a, int b, [CanBeNull] RoomSaveRequestPayload roomSaveRequestPayload, RoomSerializedData c, long d, long e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x8D96E60", Offset = "0x8D95460", VA = "0x188D96E60")]
		[AsyncStateMachine(typeof(<UploadRoomDataBlob>d__10))]
		public static Task<SaveSubRoomResponseDTO> RIULJVVOHQR(TPICXMNKDPD a, int b, [CanBeNull] RoomSaveRequestPayload roomSaveRequestPayload, RoomSerializedData c, long d, long e, UgcVersionInfo f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x8D96990", Offset = "0x8D94F90", VA = "0x188D96990")]
		[AsyncStateMachine(typeof(<PushRoomDataBlobToStudio>d__11))]
		private Task<RemoteRunDTO> NWOPVMLMLWH(string a, int b, RoomSerializedData c, long d, long e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D97160", Offset = "0x8D95760", VA = "0x188D97160")]
		[AsyncStateMachine(typeof(<UploadRoomDataBlobAndSyncReload>d__12))]
		public Task<NVFUFUSEYRF> ZVCBFMQNEOQ(int a, RoomSaveRequestPayload? roomSaveRequestPayload, RoomSerializedData b, long c, long d, RoomSaveAnalyticsInfo e, StackTimer<string>.ERYHZSBUWXZ f, CancellationToken g)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B1")]
	public abstract class WEJNWEHZZDE<a> where a : WEJNWEHZZDE<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		internal readonly NIJQVUPMTTA SUZVOHOMDUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		private int? CVLYATALFHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		protected readonly Guid QRNAXMCMCEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		protected readonly RoomOperationType MDBRNEJKSSE;

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		protected a SKSHYJAMOVY
		{
			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0x685A1C0", Offset = "0x68587C0", VA = "0x18685A1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x685A4B0", Offset = "0x6858AB0", VA = "0x18685A4B0")]
		internal WEJNWEHZZDE(NIJQVUPMTTA a, RoomOperationType b, [Optional] Guid? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x685A030", Offset = "0x6858630", VA = "0x18685A030")]
		private NVFUFUSEYRF FAILVKZGZJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
		protected virtual void HEZJYOJIYHF(NVFUFUSEYRF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x685A220", Offset = "0x6858820", VA = "0x18685A220")]
		public a OALEVDFFITY(LRIABUPBGVB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x685A110", Offset = "0x6858710", VA = "0x18685A110")]
		public a LHHPKSQKBTS(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x685A320", Offset = "0x6858920", VA = "0x18685A320", Slot = "5")]
		public virtual Task<EARYEWOAMEK> Submit()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	public class GLVGLZIHBMB : WEJNWEHZZDE<GLVGLZIHBMB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		private RoomLoadRequestPayload NILXQWWEBZI;

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x8D8DA20", Offset = "0x8D8C020", VA = "0x188D8DA20")]
		internal GLVGLZIHBMB(NIJQVUPMTTA a, RoomOperationType b, [Optional] Guid? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F61350", Offset = "0x7F5F950", VA = "0x187F61350")]
		public GLVGLZIHBMB BFCPOBUHDXU(RoomLoadRequestPayload a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x8D8D950", Offset = "0x8D8BF50", VA = "0x188D8D950", Slot = "4")]
		protected override void HEZJYOJIYHF(NVFUFUSEYRF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	public class GYJHUCWYCEK : WEJNWEHZZDE<GYJHUCWYCEK>
	{
		[Cpp2IlInjected.Token(Token = "0x20001B4")]
		internal enum SaveTarget
		{
			[Cpp2IlInjected.Token(Token = "0x40007CD")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40007CE")]
			Disk,
			[Cpp2IlInjected.Token(Token = "0x40007CF")]
			RecNet
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001B5")]
		[CompilerGenerated]
		private struct <Submit>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007D0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007D1")]
			public AsyncTaskMethodBuilder<EARYEWOAMEK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007D2")]
			public GYJHUCWYCEK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007D4")]
			private TaskAwaiter<EARYEWOAMEK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006D5")]
			[Cpp2IlInjected.Address(RVA = "0x8D9F730", Offset = "0x8D9DD30", VA = "0x188D9F730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0x8D9FAD0", Offset = "0x8D9E0D0", VA = "0x188D9FAD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		private SaveTarget ERXYGDLOQKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		private string ZZHVMLIJQGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		private RoomSaveRequestPayload NILXQWWEBZI;

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x8D8FDC0", Offset = "0x8D8E3C0", VA = "0x188D8FDC0")]
		internal GYJHUCWYCEK(NIJQVUPMTTA a, RoomOperationType b, [Optional] Guid? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D8FC50", Offset = "0x8D8E250", VA = "0x188D8FC50")]
		public GYJHUCWYCEK MRTYUTCHGSG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x8D8FA90", Offset = "0x8D8E090", VA = "0x188D8FA90")]
		public GYJHUCWYCEK ENUOVWPTGZE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x8D8FC80", Offset = "0x8D8E280", VA = "0x188D8FC80")]
		public GYJHUCWYCEK OMMOAAAJCOW(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x8D8FD90", Offset = "0x8D8E390", VA = "0x188D8FD90")]
		public GYJHUCWYCEK TIPQXMFHMDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x8D8FAB0", Offset = "0x8D8E0B0", VA = "0x188D8FAB0", Slot = "4")]
		protected override void HEZJYOJIYHF(NVFUFUSEYRF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x8D8FCA0", Offset = "0x8D8E2A0", VA = "0x188D8FCA0", Slot = "5")]
		[AsyncStateMachine(typeof(<Submit>d__11))]
		public override Task<EARYEWOAMEK> Submit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x8D8FC10", Offset = "0x8D8E210", VA = "0x188D8FC10")]
		[CompilerGenerated]
		[DebuggerHidden]
		private Task<EARYEWOAMEK> KNZOQXWETEG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	internal static class EJINODJPOSJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x8D8D810", Offset = "0x8D8BE10", VA = "0x188D8D810")]
		public static void PUZHZEDRVST(this PlayerPresence a, RoomInstance b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x8D8D790", Offset = "0x8D8BD90", VA = "0x188D8D790")]
		public static void HIUPJHZZJNG(this RoomInstance a, [Optional] string b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	public static class TUZAXEGOPMR
	{
		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D97980", Offset = "0x8D95F80", VA = "0x188D97980")]
		public static FilenameWithHash UFRYRNDEZSQ(this BCVECZWOXTJ a)
		{
			return default(FilenameWithHash);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x8D978D0", Offset = "0x8D95ED0", VA = "0x188D978D0")]
		public static BCVECZWOXTJ DORCDLVFWXH(this FilenameWithHash a)
		{
			return null;
		}
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001B9")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007D8")]
			public ValidationReason ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public ValidationReason HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		private static ValidationReason[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		private Dictionary<ValidationReason, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4130", Offset = "0x8DA2730", VA = "0x188DA4130")]
		public bool TryGetConfig(ValidationReason validationReason, [Out] ResultConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x8DA38D0", Offset = "0x8DA1ED0", VA = "0x188DA38D0")]
		public ResultConfig GetConfigForResult(ValidationReason reason, [Optional] HashSet<ValidationReason> visited)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3F60", Offset = "0x8DA2560", VA = "0x188DA3F60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3A00", Offset = "0x8DA2000", VA = "0x188DA3A00", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xDB5160", Offset = "0xDB3760", VA = "0x180DB5160")]
		public ValidationResultConfig()
		{
		}
	}
}
namespace RecRoom.RoomLoading.PreEmptyScene
{
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	public class RoomManagerPreEmptyScene : QUKMHXOZAMV
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001BC")]
		[CompilerGenerated]
		private struct <Run>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007E6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007E7")]
			public RoomManagerPreEmptyScene <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007E8")]
			public StackTimer<string>.ERYHZSBUWXZ timerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007E9")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007EA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x8D9E330", Offset = "0x8D9C930", VA = "0x188D9E330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x8D9E5C0", Offset = "0x8D9CBC0", VA = "0x188D9E5C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001BD")]
		[CompilerGenerated]
		private struct <RunHandlerWithCancellationForwarding>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007EC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007ED")]
			public StackTimer<string>.ERYHZSBUWXZ timerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007EE")]
			public QUKMHXOZAMV preEmptySceneHandler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007EF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007F0")]
			private StackTimer<string>.ERYHZSBUWXZ <ts>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007F1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x8D9B820", Offset = "0x8D99E20", VA = "0x188D9B820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x8D9BCC0", Offset = "0x8D9A2C0", VA = "0x188D9BCC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		private readonly DPARNIXCTIT AZCXMJNFMQC;

		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public string FCCGISMXNLK
		{
			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x8D963D0", Offset = "0x8D949D0", VA = "0x188D963D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x8D96400", Offset = "0x8D94A00", VA = "0x188D96400")]
		[ZOKCDQOPSGU.Root.GameOnly]
		internal static void RHSGAVCKHMM(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		[RecRoom.NoEngine.Common.Preserve]
		public RoomManagerPreEmptyScene([Inject(null)] DPARNIXCTIT assetBundlePreEmptySceneHandler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x8D96590", Offset = "0x8D94B90", VA = "0x188D96590", Slot = "5")]
		[AsyncStateMachine(typeof(<Run>d__6))]
		public Task Run(StackTimer<string>.ERYHZSBUWXZ timerScope, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x8D96470", Offset = "0x8D94A70", VA = "0x188D96470")]
		[AsyncStateMachine(typeof(<RunHandlerWithCancellationForwarding>d__7))]
		private Task RYCPIDNOQBJ(QUKMHXOZAMV a, StackTimer<string>.ERYHZSBUWXZ b, CancellationToken c)
		{
			return null;
		}
	}
}
namespace RecRoom.RoomLoading.Interfaces.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20001BE")]
	public interface DPARNIXCTIT : QUKMHXOZAMV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	public interface QUKMHXOZAMV
	{
		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		string FCCGISMXNLK
		{
			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task Run(StackTimer<string>.ERYHZSBUWXZ timerScope, CancellationToken cancellationToken);
	}
}
namespace RecRoom.RoomLoading.AutoSaves
{
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	public static class XNFTZOBBXHG
	{
		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x8DA42C0", Offset = "0x8DA28C0", VA = "0x188DA42C0")]
		[ZOKCDQOPSGU.Root.GameOnly]
		internal static void LSGYJXLQNAB(KUXAUVMITFU a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	public interface NJHMYSMXXYI : IEquatable<NJHMYSMXXYI>
	{
		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		DateTime YIAQLLKDXZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Delete();

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KRURKQIYPPJ(long a, long b, [Out] RoomSerializedData c);
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	internal class PGXCIQVRXGM : KWATABQIYOJ
	{
		[Cpp2IlInjected.Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class SSSKYROOASY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007F6")]
			public AutosaveType DPKMTBMGQOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007F7")]
			public Exception DPJLVPQRCSZ;

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SSSKYROOASY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x8D977C0", Offset = "0x8D95DC0", VA = "0x188D977C0")]
			internal object OAMQFEWEPFC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private readonly SENRWMYMRHD QPVVYXMUGYK;

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<NJHMYSMXXYI> XJHPRHAENPX
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x8D94A30", Offset = "0x8D93030", VA = "0x188D94A30", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0x8D94370", Offset = "0x8D92970", VA = "0x188D94370", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		[UnityEngine.Scripting.Preserve]
		public PGXCIQVRXGM([Inject(null)] SENRWMYMRHD autosaveStorageService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x8D94750", Offset = "0x8D92D50", VA = "0x188D94750", Slot = "6")]
		public bool ZSFEVTGEGHQ(long a, long b, RoomSerializedData c, AutosaveType d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xFCEC30", Offset = "0xFCD230", VA = "0x180FCEC30")]
		private void NUYDOFWJQVT(NJHMYSMXXYI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x8D944D0", Offset = "0x8D92AD0", VA = "0x188D944D0", Slot = "7")]
		public bool LLTIQZMJMPE(long a, long b, [Out] NJHMYSMXXYI c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x8D94420", Offset = "0x8D92A20", VA = "0x188D94420", Slot = "8")]
		public bool DHYXDHRMJHL(long a, long b, AutosaveType c, [Out] NJHMYSMXXYI d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x8D93F60", Offset = "0x8D92560", VA = "0x188D93F60")]
		private void APCNPVCRQRA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x8D94640", Offset = "0x8D92C40", VA = "0x188D94640", Slot = "9")]
		public void WQJSZYUEZTK(long a, long b)
		{
		}
	}
}
namespace RecRoom.RoomLoading.AutoSaves.Versions
{
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	internal abstract class JKVRUJRCCWN : SENRWMYMRHD
	{
		[Cpp2IlInjected.Token(Token = "0x20001C6")]
		protected enum DirectoryAccessMode : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40007FA")]
			Read,
			[Cpp2IlInjected.Token(Token = "0x40007FB")]
			Write
		}

		[Cpp2IlInjected.Token(Token = "0x20001C7")]
		[CompilerGenerated]
		private sealed class TBDIAOPJOEZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007FC")]
			public AutosaveType DPKMTBMGQOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007FD")]
			public FileInfo FTXISWMWJDO;

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TBDIAOPJOEZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x8D97830", Offset = "0x8D95E30", VA = "0x188D97830")]
			internal object NPUEQXBYDHB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001C8")]
		[CompilerGenerated]
		private sealed class RBIUPPLHNXI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007FE")]
			public JKVRUJRCCWN CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007FF")]
			public FileInfo ZNXYZKBHSGS;

			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public RBIUPPLHNXI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0x8D95DD0", Offset = "0x8D943D0", VA = "0x188D95DD0")]
			internal void YUQONGSJSJT(PlayerReporting.HileType a, string b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001C9")]
		[CompilerGenerated]
		private sealed class VRZMOYTAOOQ : IEnumerable<NJHMYSMXXYI>, IEnumerable, IEnumerator<NJHMYSMXXYI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000800")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000801")]
			private NJHMYSMXXYI MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000802")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000803")]
			public JKVRUJRCCWN CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000804")]
			private AutosaveType DPKMTBMGQOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000805")]
			public AutosaveType XXPNAXJLTRV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000806")]
			private FileInfo[] TPFONUYPLCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			private int TPVJFPGHNKB;

			[Cpp2IlInjected.Token(Token = "0x170000F3")]
			private NJHMYSMXXYI XFVWGOPEPFO
			{
				[Cpp2IlInjected.Token(Token = "0x600071A")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F4")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600071C")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0xB597F0", Offset = "0xB57DF0", VA = "0x180B597F0")]
			[DebuggerHidden]
			public VRZMOYTAOOQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0x8DA3350", Offset = "0x8DA1950", VA = "0x188DA3350", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x8DA3890", Offset = "0x8DA1E90", VA = "0x188DA3890", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x8DA3250", Offset = "0x8DA1850", VA = "0x188DA3250", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NJHMYSMXXYI> HBONJJIAJLN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x8DA3250", Offset = "0x8DA1850", VA = "0x188DA3250", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		private readonly object AFREBWLCRTT;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		protected string KKNDJJOFSDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x8D90330", Offset = "0x8D8E930", VA = "0x188D90330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract AutosaveVersion CLCZMSOFCGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x8D90920", Offset = "0x8D8EF20", VA = "0x188D90920")]
		protected JKVRUJRCCWN([CanBeNull] string persistentDataDir)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x8D90340", Offset = "0x8D8E940", VA = "0x188D90340", Slot = "5")]
		public bool KCTTJHUNLDT(long a, long b, AutosaveType c, [Out] NJHMYSMXXYI d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x8D908A0", Offset = "0x8D8EEA0", VA = "0x188D908A0", Slot = "6")]
		[IteratorStateMachine(typeof(VRZMOYTAOOQ))]
		public IEnumerable<NJHMYSMXXYI> UQLMUXDIYID(AutosaveType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		internal abstract void WNRJTOIPQUI(Stream a, long b, long c, RoomSerializedData d);

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		internal abstract bool OHTZIVWWORF(Stream a, long b, long c, HileFunc d, [Out] RoomSerializedData e);

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x8D90530", Offset = "0x8D8EB30", VA = "0x188D90530", Slot = "7")]
		public NJHMYSMXXYI PFLYIBJNAMD(long a, long b, RoomSerializedData c, AutosaveType d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		[NotNull]
		protected abstract FileInfo YJZOQTCPEKI(long a, long b, AutosaveType c, DirectoryAccessMode d);

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		[NotNull]
		protected abstract DirectoryInfo HXFZVSDIQMO(AutosaveType a, DirectoryAccessMode b);

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x8D8FF30", Offset = "0x8D8E530", VA = "0x188D8FF30")]
		protected void AVSSLKJGPUM(PlayerReporting.HileType a, string b, FileInfo c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x8D8FFA0", Offset = "0x8D8E5A0", VA = "0x188D8FFA0")]
		internal bool EKKJPMGWTJT(FileInfo a, long b, long c, [Out] RoomSerializedData d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private void ZEHXCREIRWX(Exception a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	internal class GXFTUSPJRBW : JKVRUJRCCWN
	{
		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public override AutosaveVersion CLCZMSOFCGK
		{
			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x10864F0", Offset = "0x1084AF0", VA = "0x1810864F0", Slot = "8")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E6E0", Offset = "0x8D8CCE0", VA = "0x188D8E6E0")]
		public GXFTUSPJRBW([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x8D8DBF0", Offset = "0x8D8C1F0", VA = "0x188D8DBF0")]
		private void MNMVVGAHFDQ(AutosaveType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E370", Offset = "0x8D8C970", VA = "0x188D8E370", Slot = "9")]
		internal override void WNRJTOIPQUI(Stream a, long b, long c, RoomSerializedData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x8D8DC70", Offset = "0x8D8C270", VA = "0x188D8DC70", Slot = "10")]
		internal override bool OHTZIVWWORF(Stream a, long b, long c, HileFunc d, [Out] RoomSerializedData e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E600", Offset = "0x8D8CC00", VA = "0x188D8E600", Slot = "11")]
		protected override FileInfo YJZOQTCPEKI(long a, long b, AutosaveType c, DirectoryAccessMode d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x8D8DAF0", Offset = "0x8D8C0F0", VA = "0x188D8DAF0", Slot = "12")]
		protected override DirectoryInfo HXFZVSDIQMO(AutosaveType a, DirectoryAccessMode b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	internal sealed class GXLARZJHANF : JKVRUJRCCWN
	{
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		private static readonly byte[] PYMENAUFSNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000809")]
		private readonly byte[] QGNPDYWYRSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400080A")]
		private readonly byte[] NKMEDLJBURQ;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public override AutosaveVersion CLCZMSOFCGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x77A24C0", Offset = "0x77A0AC0", VA = "0x1877A24C0", Slot = "8")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x8D8F960", Offset = "0x8D8DF60", VA = "0x188D8F960")]
		public GXLARZJHANF([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x8D8F2F0", Offset = "0x8D8D8F0", VA = "0x188D8F2F0", Slot = "9")]
		internal override void WNRJTOIPQUI(Stream a, long b, long c, RoomSerializedData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E880", Offset = "0x8D8CE80", VA = "0x188D8E880", Slot = "10")]
		internal override bool OHTZIVWWORF(Stream a, long b, long c, HileFunc d, [Out] RoomSerializedData e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x8D8F810", Offset = "0x8D8DE10", VA = "0x188D8F810")]
		private void ZADMISVZGPO(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x8D8F6F0", Offset = "0x8D8DCF0", VA = "0x188D8F6F0", Slot = "11")]
		protected override FileInfo YJZOQTCPEKI(long a, long b, AutosaveType c, DirectoryAccessMode d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E770", Offset = "0x8D8CD70", VA = "0x188D8E770", Slot = "12")]
		protected override DirectoryInfo HXFZVSDIQMO(AutosaveType a, DirectoryAccessMode b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CD")]
	public enum AutosaveVersion : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400080E")]
		INVALID = 0,
		[Cpp2IlInjected.Token(Token = "0x400080F")]
		CHECKSUM = 2,
		[Cpp2IlInjected.Token(Token = "0x4000810")]
		BETTER_FILE_LAYOUT = 3
	}
}
namespace RecRoom.RoomLoading.AutoSaves.Storage
{
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	internal class MNSRRPCJFNE : SENRWMYMRHD
	{
		[Cpp2IlInjected.Token(Token = "0x20001D0")]
		[CompilerGenerated]
		private sealed class VRZMOYTAOOQ : IEnumerable<NJHMYSMXXYI>, IEnumerable, IEnumerator<NJHMYSMXXYI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000817")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000818")]
			private NJHMYSMXXYI MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000819")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400081A")]
			public MNSRRPCJFNE CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400081B")]
			private AutosaveType DPKMTBMGQOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400081C")]
			public AutosaveType XXPNAXJLTRV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400081D")]
			private AutosaveVersion[] TPFONUYPLCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400081E")]
			private int TPVJFPGHNKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400081F")]
			private IEnumerator<NJHMYSMXXYI> TPQCIIMKDYS;

			[Cpp2IlInjected.Token(Token = "0x170000F8")]
			private NJHMYSMXXYI XFVWGOPEPFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000740")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F9")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000742")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0xB597F0", Offset = "0xB57DF0", VA = "0x180B597F0")]
			[DebuggerHidden]
			public VRZMOYTAOOQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x8DA3110", Offset = "0x8DA1710", VA = "0x188DA3110", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x8DA3570", Offset = "0x8DA1B70", VA = "0x188DA3570", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x8DA3300", Offset = "0x8DA1900", VA = "0x188DA3300")]
			private void KPIRURCCWVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x8DA3850", Offset = "0x8DA1E50", VA = "0x188DA3850", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(RVA = "0x8DA31A0", Offset = "0x8DA17A0", VA = "0x188DA31A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NJHMYSMXXYI> HBONJJIAJLN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x8DA31A0", Offset = "0x8DA17A0", VA = "0x188DA31A0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000811")]
		private readonly AutosaveVersion[] RKYJKHZHWBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		private readonly Dictionary<AutosaveVersion, SENRWMYMRHD> UNCDXGADOVX;

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public AutosaveVersion CLCZMSOFCGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x8D924D0", Offset = "0x8D90AD0", VA = "0x188D924D0", Slot = "4")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x8D92580", Offset = "0x8D90B80", VA = "0x188D92580")]
		[UnityEngine.Scripting.Preserve]
		public MNSRRPCJFNE(params SENRWMYMRHD[] versionImpls)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x8D92220", Offset = "0x8D90820", VA = "0x188D92220", Slot = "5")]
		public bool KCTTJHUNLDT(long a, long b, AutosaveType c, [Out] NJHMYSMXXYI d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x8D91FF0", Offset = "0x8D905F0", VA = "0x188D91FF0")]
		private void CDOSBFERXCB(int a, long b, long c, AutosaveType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x8D92500", Offset = "0x8D90B00", VA = "0x188D92500", Slot = "6")]
		[IteratorStateMachine(typeof(VRZMOYTAOOQ))]
		public IEnumerable<NJHMYSMXXYI> UQLMUXDIYID(AutosaveType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x8D92370", Offset = "0x8D90970", VA = "0x188D92370", Slot = "7")]
		public NJHMYSMXXYI PFLYIBJNAMD(long a, long b, RoomSerializedData c, AutosaveType d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	internal static class OMLUSGYYHVI
	{
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x8D92BA0", Offset = "0x8D911A0", VA = "0x188D92BA0")]
		internal static byte[] ComputeHash(byte[] bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x8D92C60", Offset = "0x8D91260", VA = "0x188D92C60")]
		public static void URKSTUJQILL(Stream a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x8D929C0", Offset = "0x8D90FC0", VA = "0x188D929C0")]
		public static bool BDGMQSHIXDA(Stream a, long b, HileFunc c, [Out] byte[] d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D2")]
	internal sealed class KUSPAVMMTEN : NJHMYSMXXYI, IEquatable<NJHMYSMXXYI>, IEquatable<KUSPAVMMTEN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		private readonly JKVRUJRCCWN YIZLHYRCFQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		public readonly FileInfo TRFATOFJOZE;

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public AutosaveVersion CLCZMSOFCGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x8657AC0", Offset = "0x86560C0", VA = "0x188657AC0", Slot = "9")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		public DateTime YIAQLLKDXZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x8D90ED0", Offset = "0x8D8F4D0", VA = "0x188D90ED0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x8D91010", Offset = "0x8D8F610", VA = "0x188D91010")]
		public KUSPAVMMTEN(JKVRUJRCCWN a, FileInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x8D90F60", Offset = "0x8D8F560", VA = "0x188D90F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x8D90B30", Offset = "0x8D8F130", VA = "0x188D90B30", Slot = "5")]
		public void Delete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x8D90E90", Offset = "0x8D8F490", VA = "0x188D90E90", Slot = "6")]
		public bool KRURKQIYPPJ(long a, long b, [Out] RoomSerializedData c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x8D90BF0", Offset = "0x8D8F1F0", VA = "0x188D90BF0", Slot = "7")]
		public bool Equals(NJHMYSMXXYI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x8D90C60", Offset = "0x8D8F260", VA = "0x188D90C60", Slot = "8")]
		public bool Equals(KUSPAVMMTEN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x8D90D20", Offset = "0x8D8F320", VA = "0x188D90D20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x8D90E00", Offset = "0x8D8F400", VA = "0x188D90E00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D3")]
	public delegate void HileFunc(PlayerReporting.HileType hileType, string message);
	[Cpp2IlInjected.Token(Token = "0x20001D4")]
	internal interface SENRWMYMRHD
	{
		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		AutosaveVersion CLCZMSOFCGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool KCTTJHUNLDT(long a, long b, AutosaveType c, [Out] NJHMYSMXXYI d);

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IEnumerable<NJHMYSMXXYI> UQLMUXDIYID(AutosaveType a);

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(Slot = "3")]
		NJHMYSMXXYI PFLYIBJNAMD(long a, long b, RoomSerializedData c, AutosaveType d);
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
