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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A9D620", Offset = "0x8A9CA20", VA = "0x188A9D620")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class DBSTIRSNXRY
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal Task<RoomLoadDetails> SCUWRYFLRTW;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal Task HPGDDJAMODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal BMOYDOHYHMN LMMPYZXAWHS;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
	public DBSTIRSNXRY()
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
		[Cpp2IlInjected.Address(RVA = "0x8A9CEC0", Offset = "0x8A9C2C0", VA = "0x188A9CEC0", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AB94B0", Offset = "0x8AB88B0", VA = "0x188AB94B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x26F2710", Offset = "0x26F1B10", VA = "0x1826F2710")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A9DFC0", Offset = "0x8A9D3C0", VA = "0x188A9DFC0")]
		public RecoverableRoomOperationException(string message, Exception innerException)
		{
		}
	}
}
namespace RoomOperation.OperationLogic.Restore
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal class IUAIFJCFUEG : FKWQANIQBEL
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
			[Cpp2IlInjected.Address(RVA = "0x8AAEB10", Offset = "0x8AADF10", VA = "0x188AAEB10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8AAED20", Offset = "0x8AAE120", VA = "0x188AAED20", Slot = "5")]
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
			private TaskAwaiter<PPCJEJRUUPJ<SubRoomDataSaveDTO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC40", Offset = "0x8AAF040", VA = "0x188AAFC40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFE80", Offset = "0x8AAF280", VA = "0x188AAFE80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		[UnityEngine.Scripting.Preserve]
		public IUAIFJCFUEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9BF80", Offset = "0x8A9B380", VA = "0x188A9BF80", Slot = "4")]
		[AsyncStateMachine(typeof(<GetSubRoomDataHistory>d__1))]
		public Task<IReadOnlyList<SubRoomDataSaveDTO>> PEUJDRYLLHT(long a, long b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9C0A0", Offset = "0x8A9B4A0", VA = "0x188A9C0A0", Slot = "5")]
		[AsyncStateMachine(typeof(<GetAccountsBulk>d__2))]
		public Task<IReadOnlyList<Account>> XMGRCLTAFDE(IReadOnlyList<int> a, [Optional] CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface EMKYYJHXJLG : IEquatable<EMKYYJHXJLG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int OARUQDQXIDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[CanBeNull]
		Account DBNVMBWUOXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		DateTime ARAUHPHICWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		PlatformType? XJEKVETHOBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		DeviceClass? PZKJUAGYVRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		[CanBeNull]
		RestoreOptionTypes AEEWWHDGGIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<WIIGEWEAFFO> CAOYVISOWMM();
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
	public interface FKWQANIQBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<SubRoomDataSaveDTO>> PEUJDRYLLHT(long a, long b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<IReadOnlyList<Account>> XMGRCLTAFDE(IReadOnlyList<int> a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class XXZFDILCYXJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private sealed class EGYCPBDIXOI : EMKYYJHXJLG, IEquatable<EMKYYJHXJLG>
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
				public AsyncTaskMethodBuilder<WIIGEWEAFFO> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public EGYCPBDIXOI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				private ADRAPIPQYMJ <roomManager>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				private TaskAwaiter<RoomDetailsDTO> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				private TaskAwaiter<WIIGEWEAFFO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x8AB0470", Offset = "0x8AAF870", VA = "0x188AB0470", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x8AB09F0", Offset = "0x8AAFDF0", VA = "0x188AB09F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly SubRoomDataSaveDTO YTCTSLDALIQ;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int OARUQDQXIDI
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public Account DBNVMBWUOXV
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private DateTime HCVXRXURQFZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x8A9A980", Offset = "0x8A99D80", VA = "0x188A9A980", Slot = "6")]
				get
				{
					return default(DateTime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public PlatformType? XJEKVETHOBZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2AF5C90", Offset = "0x2AF5090", VA = "0x182AF5C90", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public DeviceClass? PZKJUAGYVRU
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x8A9AA60", Offset = "0x8A99E60", VA = "0x188A9AA60", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public RestoreOptionTypes AEEWWHDGGIV
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "10")]
				get
				{
					return default(RestoreOptionTypes);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8A9A750", Offset = "0x8A99B50", VA = "0x188A9A750", Slot = "9")]
			[AsyncStateMachine(typeof(<Restore>d__13))]
			public Task<WIIGEWEAFFO> CAOYVISOWMM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8A9AA80", Offset = "0x8A99E80", VA = "0x188A9AA80")]
			public EGYCPBDIXOI(int a, Account b, SubRoomDataSaveDTO c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8A9A850", Offset = "0x8A99C50", VA = "0x188A9A850", Slot = "11")]
			public bool Equals(EMKYYJHXJLG other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8A9A8E0", Offset = "0x8A99CE0", VA = "0x188A9A8E0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8A9AA20", Offset = "0x8A99E20", VA = "0x188A9AA20")]
			private bool TJYHLCUVZKC(EGYCPBDIXOI a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8A9A9A0", Offset = "0x8A99DA0", VA = "0x188A9A9A0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private sealed class XLXTRYALOLV : EMKYYJHXJLG, IEquatable<EMKYYJHXJLG>
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
				public AsyncTaskMethodBuilder<WIIGEWEAFFO> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public XLXTRYALOLV <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				private TaskAwaiter<WIIGEWEAFFO> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x8AB0CC0", Offset = "0x8AB00C0", VA = "0x188AB0CC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x8AB0F10", Offset = "0x8AB0310", VA = "0x188AB0F10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly KCPWVXKRWZI WCCJDWKOPXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly PlatformType ONWIVHYXOKQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly DeviceClass JVJEWAWEZLB;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int OARUQDQXIDI
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x8AB8E50", Offset = "0x8AB8250", VA = "0x188AB8E50", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Account DBNVMBWUOXV
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x8AB8D60", Offset = "0x8AB8160", VA = "0x188AB8D60", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private DateTime HCVXRXURQFZ
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x8AB8C40", Offset = "0x8AB8040", VA = "0x188AB8C40", Slot = "6")]
				get
				{
					return default(DateTime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public PlatformType? XJEKVETHOBZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x8AB8D10", Offset = "0x8AB8110", VA = "0x188AB8D10", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public DeviceClass? PZKJUAGYVRU
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x8AB8E90", Offset = "0x8AB8290", VA = "0x188AB8E90", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public RestoreOptionTypes AEEWWHDGGIV
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0xAFEDD0", Offset = "0xAFE1D0", VA = "0x180AFEDD0", Slot = "10")]
				get
				{
					return default(RestoreOptionTypes);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1A7F350", Offset = "0x1A7E750", VA = "0x181A7F350")]
			public XLXTRYALOLV(KCPWVXKRWZI a, PlatformType b, DeviceClass c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8AB8A00", Offset = "0x8AB7E00", VA = "0x188AB8A00", Slot = "9")]
			[AsyncStateMachine(typeof(<Restore>d__14))]
			public Task<WIIGEWEAFFO> CAOYVISOWMM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8AB8BA0", Offset = "0x8AB7FA0", VA = "0x188AB8BA0", Slot = "11")]
			public bool Equals(EMKYYJHXJLG other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8AB8AF0", Offset = "0x8AB7EF0", VA = "0x188AB8AF0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8AB8DF0", Offset = "0x8AB81F0", VA = "0x188AB8DF0")]
			private bool TJYHLCUVZKC(XLXTRYALOLV a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8AB8C90", Offset = "0x8AB8090", VA = "0x188AB8C90", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private sealed class KAOQBRRXKAO : EMKYYJHXJLG, IEquatable<EMKYYJHXJLG>
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
				public AsyncTaskMethodBuilder<WIIGEWEAFFO> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				private TaskAwaiter<WIIGEWEAFFO> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x8AB0A60", Offset = "0x8AAFE60", VA = "0x188AB0A60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x8AB0F80", Offset = "0x8AB0380", VA = "0x188AB0F80", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly Account IXLRGTDQDFU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private readonly PlatformType ONWIVHYXOKQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private readonly DeviceClass JVJEWAWEZLB;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public int OARUQDQXIDI
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x8A9C710", Offset = "0x8A9BB10", VA = "0x188A9C710", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			[NotNull]
			public Account DBNVMBWUOXV
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private DateTime HCVXRXURQFZ
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "6")]
				get
				{
					return default(DateTime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public PlatformType? XJEKVETHOBZ
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x8A9C600", Offset = "0x8A9BA00", VA = "0x188A9C600", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public DeviceClass? PZKJUAGYVRU
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x8A9C730", Offset = "0x8A9BB30", VA = "0x188A9C730", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public RestoreOptionTypes AEEWWHDGGIV
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "10")]
				get
				{
					return default(RestoreOptionTypes);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x1A7F350", Offset = "0x1A7E750", VA = "0x181A7F350")]
			public KAOQBRRXKAO(Account a, PlatformType b, DeviceClass c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C3B0", Offset = "0x8A9B7B0", VA = "0x188A9C3B0", Slot = "9")]
			[AsyncStateMachine(typeof(<Restore>d__14))]
			public Task<WIIGEWEAFFO> CAOYVISOWMM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C500", Offset = "0x8A9B900", VA = "0x188A9C500", Slot = "11")]
			public bool Equals(EMKYYJHXJLG other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C480", Offset = "0x8A9B880", VA = "0x188A9C480", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C570", Offset = "0x8A9B970", VA = "0x188A9C570", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C650", Offset = "0x8A9BA50", VA = "0x188A9C650")]
			private bool TJYHLCUVZKC(KAOQBRRXKAO a)
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
			public XXZFDILCYXJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private TaskAwaiter<IReadOnlyList<Account>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8AA79F0", Offset = "0x8AA6DF0", VA = "0x188AA79F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8AA8370", Offset = "0x8AA7770", VA = "0x188AA8370", Slot = "5")]
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
			public AsyncTaskMethodBuilder<IList<EMKYYJHXJLG>> <>t__builder;

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
			public XXZFDILCYXJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8AAED90", Offset = "0x8AAE190", VA = "0x188AAED90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFBD0", Offset = "0x8AAEFD0", VA = "0x188AAFBD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly RIWMWKYZVIR XEVKVUPOFQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly FKWQANIQBEL BKFAFUFMIYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly BLPDIKJBTAX UJTTDLIEIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly KOULCFUNFMJ<(long, long), IReadOnlyList<SubRoomDataSaveDTO>> UNIRUTKHWKR;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8AB92E0", Offset = "0x8AB86E0", VA = "0x188AB92E0")]
		[UnityEngine.Scripting.Preserve]
		public XXZFDILCYXJ([Inject(null)] FKWQANIQBEL roomHistoryProvider, [Inject(null)] BLPDIKJBTAX roomAutosaveService, [Inject(null)] RIWMWKYZVIR platformAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9080", Offset = "0x8AB8480", VA = "0x188AB9080")]
		[AsyncStateMachine(typeof(<GetOrderedRestoreOptions>d__5))]
		public Task<IList<EMKYYJHXJLG>> DVFSKKYVADB(long a, long b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8AB8EE0", Offset = "0x8AB82E0", VA = "0x188AB8EE0")]
		private bool DAHKBLRPGBY(DateTime? a, long b, long c, [Out] KCPWVXKRWZI d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8AB91D0", Offset = "0x8AB85D0", VA = "0x188AB91D0")]
		[AsyncStateMachine(typeof(<CombineHistoryWithAccounts>d__7))]
		private Task<IReadOnlyList<(int, Account, SubRoomDataSaveDTO)>> VCGWKPPTCEZ(IReadOnlyList<SubRoomDataSaveDTO> a)
		{
			return null;
		}
	}
}
namespace AutoSaves
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface BLPDIKJBTAX
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<KCPWVXKRWZI> SRIWDIRHMIX;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool QGUMXUBVGDK(long a, long b, RoomSerializedData c, AutosaveType d);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool PPAAKFHMXFS(long a, long b, [Out] KCPWVXKRWZI c);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool KNITFLVWRJV(long a, long b, AutosaveType c, [Out] KCPWVXKRWZI d);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ORTPLZQKPYS(long a, long b);
	}
}
namespace RecRoom.RoomLoading
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal interface AEOKRKYITOK : VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool UPIDIBGRWCA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		Task QNBSVVFMDOE
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SBIGYGCFVZV(Task a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal interface YDVAPVGWKHO : VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<WIIGEWEAFFO> RequestRestoreAutosave(KCPWVXKRWZI autosaveRecordInfo);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task YTAJJGSGWEW(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal interface ICXFHWXUHPB : VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		WGTOKMZHNDN WGTOKMZHNDN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LSJXRWXJMYC();

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void QGSPCYEKKJO();
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal interface VRXVJDMHIYE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(MVWEOVUCDOM roomManager);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal interface PIYWXEEYHLZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		TimeSpan IYZNPETHBBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		TimeSpan SKKSPLPMCOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		TimeSpan HTJWQLKBFEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		TimeSpan ZRUJTPBNUCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool XXRASIMZOKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool OUFPXMXSKJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool ZIFQNJTKLOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		int XJDDSZXDUSO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool YUQZKSVDXIF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool BUUNQYVEKXE
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool FUAWLXWHEZQ
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
		[Cpp2IlInjected.Address(RVA = "0x8A9E870", Offset = "0x8A9DC70", VA = "0x188A9E870")]
		public RoomEvent(long superRoomId, long subRoomId, RoomEventType type, [CanBeNull] Exception eventException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9E820", Offset = "0x8A9DC20", VA = "0x188A9E820")]
		public static RoomEvent From(RoomInstance room, RoomEventType type, [Optional] Exception eventException)
		{
			return default(RoomEvent);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void RoomEventHandler(RoomEvent roomEvent);
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal interface WDIEJYQAOTC : VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event RoomEventHandler XPYTYQHLPWM;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event RoomEventHandler HCNGKMLRXNW;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event RoomEventHandler ARBHTPXISAC;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<RequestOperationType, bool> GYQDDCHOSUM;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void MPXEFVHTNXK(RoomEvent a);

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void CLIAIBYJSPW(RoomEvent a);

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void IJFVGNUMEDM(RoomEvent a);

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void ARVDCKCSSVS(RequestOperationType a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal interface XJYONDZRBRO : VRXVJDMHIYE, IDisposable, RPPCBTZSYTD
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool RXZHZUENVJK
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GUKSIVLXEMQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal interface CFVVXENXKIU : VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		TaskStatus LZSOVBBOCYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task JoinRoomInstance(RoomInstance targetInstance, QPEPMFBJVFS customRoomLoadPayload, CancellationToken externalToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class DJMIWEHIMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8A9A270", Offset = "0x8A99670", VA = "0x188A9A270")]
		public static bool MLCCTUCXHIG(this CFVVXENXKIU a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate Task InLoadedRoomTaskBuilder(CancellationToken token, int roomTotalVersion, AccountRoleType localPlayerAccountRoleType);
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal interface NTXWNCDUYQJ : VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool PLWLDLMCTNT(InLoadedRoomTaskBuilder a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface MVWEOVUCDOM : ADRAPIPQYMJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		CancellationToken NYRVFXEJBDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		XRSJVGYQFTW QODWXULLMIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		HFLLGBMWIHF EGFOQSVFQXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		UYGOTJQHPYH IKASHGLDQKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		MVZYDDMAODN OJXQDUAJVPU
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		GBQCQYLDPKW RZUUXIUJREV
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		DAQZLJHROXK XTWCRVXITQT
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		RJVDARAWJUM TGOPYCQSXZF
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		SJYCKVQRDLU SJYCKVQRDLU
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		AEOKRKYITOK TJNNVAWKCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		YDVAPVGWKHO JJKTDLUGNSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		WDIEJYQAOTC DKHHOJRBOMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		XJYONDZRBRO FOQKLDFPAPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		CFVVXENXKIU WQCNKUYTZKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		NTXWNCDUYQJ WZZOGQKHDRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		XQTTFYUWSSS PVOBZSSGYOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		MJXMMBCQHCL EXBVKUSFDIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		CWKKMCQNDCO JAXDRQHPGMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		BSMMJIHFQGX XYHYOUOPZWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		FNMSXOSALFV OLMDRALOLPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		NPDGWTKDDKX INIFKHUGILM
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		MLQYKKHTWKA BUZYFFFNMKP
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		CJGHBXBZXEK WJIXZDMREBL
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		EIZRSISINPE XCOOHSJZWJF
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		NIIEZGNLYUY SUYBKJUESRL
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		ICXFHWXUHPB ABCOTGHCMAA
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		PIYWXEEYHLZ BWOFSSDPPGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		PITYKGBNJVB CRWUXWSDSLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		BLPDIKJBTAX XAFLKKXKUOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		MXQCDMJQSQQ RVOHSYRVRYP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		OPLTLPPSEIP KYYEYMYAQPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		GTOTEIGPFPL KXWRIWIRDCS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		WTLPGQTVEHV IKWDRFAHJRK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		new bool BVSWQUBVXPV
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
		void CKVHVFUKQDY(QPEPMFBJVFS a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal interface XQTTFYUWSSS : VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PendingRequest Add(Guid operationId);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool Remove(Guid operationId);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ISTHBRMLTIY(Guid a, Task b);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KSEWLXKLPBM(Guid a, WIIGEWEAFFO b);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<(WIIGEWEAFFO, Task)> GXLXDRMMKOD(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface JBTMEWGPJAK : VRXVJDMHIYE, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal interface MJXMMBCQHCL : VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TPNDPLFASVL(PKIHHHDXEKZ a);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GBPOSLPQRDG(PKIHHHDXEKZ a);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RoomOperationType> YUMYLFIEUQN(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal interface CWKKMCQNDCO : VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PendingRequest SVQKAVHZAQC(PKIHHHDXEKZ a);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void POCTRIIUIHT(Guid a, Task b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal interface BSMMJIHFQGX : VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<WIIGEWEAFFO> XYHYOUOPZWY(PKIHHHDXEKZ a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface FNMSXOSALFV : VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RoomLoadRequestPayload> LIWZMYAFZXW(StackTimer<string>.UBFOGWXCCTH a, RoomInstance b, CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal interface MLQYKKHTWKA : VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WIIGEWEAFFO BAJWMNSYXMI(JCSDFORPEFX a);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task RequestSaveRoomToDisk(string path);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal interface NPDGWTKDDKX : VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PKIHHHDXEKZ> LZRTUADVLEL(PKIHHHDXEKZ a, UMTYTQWPZHG b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<PKIHHHDXEKZ> UUJKHAPQKEZ(CancellationToken a, UMTYTQWPZHG b);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TNRXJFRDOMC KUBMAAZFKXA(YHYCZYSLLNF a, StackTimer<string>.UBFOGWXCCTH b);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TNRXJFRDOMC VVCRDJECDUN(YHYCZYSLLNF a, StackTimer<string>.UBFOGWXCCTH b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface CJGHBXBZXEK : VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WIIGEWEAFFO XOZCMEDRRJI(JCSDFORPEFX a, RoomOperationType b);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		WIIGEWEAFFO KABNJBFBYDX(JCSDFORPEFX a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public interface WRQUDMFGTPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		const int YDMILDGTSUO = 1000;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		IReadOnlyDictionary<Guid, RoomAssetDTO> OZCRUGMCROI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		Action OUINILMBEMH
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
		IReadOnlyList<Guid> XXIJLIDKJMX();

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task GGQNDFNYTWH([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task WZKYRXKUBHP([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface EIZRSISINPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ADYSKLUVBUC(HEERFGNWXTM a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void YHWXOTDXGDT(HEERFGNWXTM a);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WZLYSQYNGXL(HEERFGNWXTM a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BEWTKHMQHHF(HEERFGNWXTM a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class HEERFGNWXTM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly RoomInstance UAEGSSIIZEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Dictionary<string, string> JFCPIFQSMST;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public StackTimer<string> NERSMEFHTXV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public HEERFGNWXTM(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B830", Offset = "0x8A9AC30", VA = "0x188A9B830")]
		public HEERFGNWXTM YPDVECUPPPQ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B7A0", Offset = "0x8A9ABA0", VA = "0x188A9B7A0")]
		public bool NSENZGVEDVQ([Out] IEnumerable<KeyValuePair<string, string>> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x79E1830", Offset = "0x79E0C30", VA = "0x1879E1830")]
		public HEERFGNWXTM BDZSLGYBKDV(StackTimer<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface PITYKGBNJVB
	{
		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		bool TSJQCVPGRPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		string GWHCJTJIGSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool QYSMHYRKYMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LTITWBMILOK();

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TQVYXWPXNJF WVJBZYNODWT(long a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		QSAZZMJIOWN<FilenameWithHash, SuperRoomData> SAFSQCFHHUD(long a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		QSAZZMJIOWN<FilenameWithHash, PersistedRoomData> YIPUDKODKXD(long a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		QSAZZMJIOWN<long, YVWXGRBPFFE> KEMYTLBANOX();

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<IReadOnlyCollection<BakedUnitySubAssetDTO>> NOHHZBYOBRF(long a, IReadOnlyCollection<BakedUnitySubAssetDTO> b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool WTTESUPVEEA(long a, [Out] bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<bool> GITXUITQLBA(byte[] a, byte[] b, IReadOnlyCollection<Guid> c, CancellationToken d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface ZMJYUQZMWBJ
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
	public interface ADRAPIPQYMJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		bool MLCCTUCXHIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool VCGXWXKHHEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool BVSWQUBVXPV
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		ZMJYUQZMWBJ HQQPDODIKPU
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		QPEPMFBJVFS BMRXWMPLALY
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event RoomEventHandler XPYTYQHLPWM;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event RoomEventHandler HCNGKMLRXNW;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RoomEventHandler ARBHTPXISAC;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<RequestOperationType, bool> GYQDDCHOSUM;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void GUKSIVLXEMQ();

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		OEHTXSFHHXB ABAHAIWJOBP();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "13")]
		HHIEEUBOKJK LRBENHBQASN();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Task QGUTCXBZCON(int a, RoomSaveRequestPayload b, Func<RoomSerializedData, RoomSerializedData> c);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task<WIIGEWEAFFO> RequestRestoreAutosave(KCPWVXKRWZI autosaveRecord);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task YTAJJGSGWEW(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface GBQCQYLDPKW
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		bool YCHZPDEHFRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		bool OJDQIDEINCR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		Guid? NDAQXJJLNQW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BPPKLGXYBJF(Scene a);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task WSUUDIDDIQZ(UIRAGANDEUO a, IReadOnlyList<UIRAGANDEUO> b, IReadOnlyList<UIRAGANDEUO> c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IYJCTSPNVWO(Guid a, IReadOnlyList<Guid> b, UnitySubAssetKind c, [Optional] object d);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task XJOZXDWDTTY(IReadOnlyList<Guid> a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		YQJNLLJILSE XPPFQQXIGIA();

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task LTMQGACKBCJ();

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void CWDJPPLQMDC(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task GFRYFJCKFUZ();
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface MVZYDDMAODN
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		INKPZSVDXUP KYYXCPGOJZA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		bool QNMRQNZDWSA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		bool VAVEEBOWQBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		bool GAAHTOFNQBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		bool EBUDMTQRUJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		int YBNEXGWCZME
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		bool ZZIASLAHIEO
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(Slot = "50")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		bool MZDWDYDPTBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(Slot = "58")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		int HYIKMSGJYMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "59")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		int HYDDPLMMPAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(Slot = "60")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		bool MGQTVBCAECS
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(Slot = "61")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		bool ZUEMWFYIQPG
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "66")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		bool ZUUHOAGASXH
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "67")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		float BCTJHDWABEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "70")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action<float> WBPQODEKPXJ;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		XRSJVGYQFTW OIPNZWTWLXK(XRSJVGYQFTW a);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CQGIWTYTMVN(XRSJVGYQFTW a);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LOFQGQJPXCN();

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task ShowLoadingScreen(StackTimer<string>.UBFOGWXCCTH loadingScreenScope, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void MLVCVETQOVP(float a);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void ZSKVXHENUSQ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IReadOnlyList<KEDJVRQIRCF> DDMFDRRGSPO();

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IDisposable KCCIKPCFYDC(object a, KEDJVRQIRCF b);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "10")]
		IReadOnlyList<EmptySceneHandler> AVIVCKODNYU();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "11")]
		SuperRoomData HBLPYIKDHAM(IEnumerable<BMALMPEIUXS> a);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void HPFGITRYJDG(int a);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task SZILOIKCYGL();

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void PLKLFHGSIRZ();

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool ZFDFSVOSGSE();

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		Task EZWXEBAAYGV(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task SKLFKLVCZLR(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "21")]
		Task<LoadRecoveryAutosaveResponse> NDQOEXZVKKJ(DateTime a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Task<bool> DHRSWLHAUPG(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void RMNFHZYXUTB(string a = "", float b = 3f);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "25")]
		RoomSerializedMetadata YMUNVGTXSQW(RoomSaveOptions a, SerializeType b, PersistedRoomData c, IEnumerable<PersistenceView> d, GJXTXQLJSRV e);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void TXVCTEMLKAI(PersistedRoomData a);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void QXQZJLDKPOZ(BMALMPEIUXS a, [In] RoomSerializedMetadata metadata);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "28")]
		Task SLMXXGIFYUH(PersistedRoomData a, bool b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "29")]
		Task FJRPCSYXKGK(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void UJBETODIRXR(long a, long b, RoomDetailsDTO c, SubRoomDataSaveDTO d, RoomSerializedData e, RoomSaveRequestPayload? roomSaveRequestPayload, RoomSaveAnalyticsInfo? f);

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void LLYHFLEVASQ(long a, long b, RoomSaveAnalyticsInfo? c);

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void CNOIDYTYKCH(PersistenceView a);

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void PSGYFSEBCIE(string a, RoomInstance b, RoomDTO c, [Optional] string? fallbackReason, [Optional] string? fallbackFailureReason, [Optional] string? subReason);

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool ZTIZTPWAFCU(PersistenceView a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		bool YCHMUGAATHI(BMALMPEIUXS a, DEPRECATED_RoomPersistenceVersion b, [Out] EQBJETEWMWJ c);

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task NKRQKKVZPIK(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void RISYAVQUUUU();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "38")]
		IDisposable FOLGUBRMDKS();

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "39")]
		void QJQLVHGGAIU(PersistedRoomData a, DEPRECATED_RoomPersistenceVersion b);

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task<bool> RequestMasterSpawnNewLocalPlayer(HFLLGBMWIHF networking, CancellationToken cancellationToken, StackTimer<string>.UBFOGWXCCTH stackTimer);

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "41")]
		void XMDDSXOMRST(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task<SaveSubRoomResponseDTO> WCHVSVLILQU(SaveSubRoomRequest a);

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task<RoomDetailsDTO> BDVQWNFGOWZ(long a, bool b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<SubRoomDataSaveWithUnityAssetsDTO> UPSDPHMCJMC(long a, long b, long c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "45")]
		Task<SubRoomDataSaveDTO> MSSGLRCCPXX(long a, long b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task<RoomLoadDTO> UDSUOKXHJXD(long a, Guid b, long? c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "47")]
		QSAZZMJIOWN<RoomLoadDTO, IEnumerable<RoomAssetData>> DUZVMZNAWNX();

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "48")]
		Task<RemoteRunDTO> QLNDGERHJVW(string a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "49")]
		Task<RemoteRunDTO> ZDOWRIEIYJX(string a, long b, long c, Guid? d, Storage.UploadFileResponseDTO e, Storage.UploadFileResponseDTO f, int g);

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "51")]
		bool PNVHEKUVZRR();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "52")]
		bool VIVORCELJZZ();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "53")]
		bool VQPLTCMJRRT(IEnumerable<EQBJETEWMWJ> a);

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void BulkDestroy(List<GameObject> objectsToDestroy);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "55")]
		float LMVCLTGAJRK();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "56")]
		Task<bool> TSHFFPBHRUC(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "57")]
		Task<Scene> RDMJOJQOINA(string a, LoadSceneMode b, bool c, StackTimer<string>.UBFOGWXCCTH d);

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
		void LEUGLDKSFKM(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "71")]
		Task<Storage.UploadFileResponseDTO> BVSQTGTROSJ(byte[] a, Storage.FileType b, MimeType c, [Optional] IReadOnlyCollection<string>? referencedFilenames, [Optional] string? filenameOverride);

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "72")]
		void GEJEMFHCOAY(RoomInstance a);

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "73")]
		Task PYNWKUNHWYF(StackTimer<string>.UBFOGWXCCTH a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "74")]
		Task TriggerMClusterManager(StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "75")]
		Task TriggerScalabilityManager(StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "76")]
		Task TriggerClusterLodManager(StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "77")]
		IDisposable OOTUJUIOUIG();

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "78")]
		VYSMBECYISG EDPBAYDIXDD();

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "79")]
		Task HideLoadingScreen(CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface VYSMBECYISG
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task QOIDPSPMRZG(CancellationToken a);

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
	public interface INKPZSVDXUP
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		RoomInstance VKSERIDBURD
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		RoomDetailsDTO JWXGJGTWNSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		SubRoomDTO FKSPLSBDUTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		bool QNDVCMCXUNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		bool ZMFXKKWEHRV
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		int PNMOCZLKHSB
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action XAYWHQGTCUR;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<int> FDCMPLYFMTE;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void RTGIYWUMRRX();

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<Matchmaking.ServerConnectionInfoDTO> GetServerConnectionInfo(long roomInstanceId, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<MatchmakingErrorCode> KDCCFCGICFC(RoomInstance a, [Optional] QPEPMFBJVFS b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task<MatchmakingErrorCode> BSBMYWQPBYW();

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Task TAHTLCVXCRJ();

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		(RoomInstance, QPEPMFBJVFS) RBGIOSKBGUW();

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		PlayerPresence BDUGSSQVRKJ();

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void NGRNXHSDALE(long a);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void TYIVOEDPLDJ(RoomInstance a, Matchmaking.GameJoinResult b, (int Major, int? Minor)? errorCode);
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface NIIEZGNLYUY
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BMWATCYYCJP([Out] IEnumerable<int> a);

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FZDKFZZIHTT(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void INVZQOFMMIC(Token a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface UIKCBNUJXSZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string CNEQTUBVGRA(WIIGEWEAFFO a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface BQPZCKTDPNN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KVFLRZTLUXN(ATOTXALSPWU.ValidateOperation a);

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HCAMVXYVTQS(ATOTXALSPWU.ValidateOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface DAQZLJHROXK : BQPZCKTDPNN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WIIGEWEAFFO RMBEBQHOKYY(JCSDFORPEFX a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public interface RJVDARAWJUM : BQPZCKTDPNN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WIIGEWEAFFO BAJWMNSYXMI(JCSDFORPEFX a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public interface TQVYXWPXNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<CQILIXUWHJF, GKLIEWNFSHL>> KHPBFYONPHV(Guid? a, IReadOnlyCollection<BakedUnitySubAssetDTO> b, IReadOnlyCollection<BakedUnitySubAssetDTO> c, AssetBundleLoadSource d, long? e, long? f, RecNet.Core.OnDownloadProgressDelegate g, CancellationToken h);
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class CQILIXUWHJF
	{
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public UIRAGANDEUO KEDLWQLEHLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public IReadOnlyList<UIRAGANDEUO> DHTCEOEYLXI
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public IReadOnlyList<UIRAGANDEUO> UZWKZZXTRQE
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xD92220", Offset = "0xD91620", VA = "0x180D92220")]
		public CQILIXUWHJF(UIRAGANDEUO a, IReadOnlyList<UIRAGANDEUO> b, IReadOnlyList<UIRAGANDEUO> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface QSAZZMJIOWN<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<ParseResult<b>, GKLIEWNFSHL>> DSDZKQQTCAC(a a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal sealed class RoomManager : MVWEOVUCDOM, ADRAPIPQYMJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class AVNLOVCBPHI : IEnumerable<VRXVJDMHIYE>, IEnumerable, IEnumerator<VRXVJDMHIYE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private VRXVJDMHIYE JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public RoomManager MXVWDMPVVWS;

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			private VRXVJDMHIYE GACJZXQRERF
			{
				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xD06FE0", Offset = "0xD063E0", VA = "0x180D06FE0")]
			[DebuggerHidden]
			public AVNLOVCBPHI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x8A997A0", Offset = "0x8A98BA0", VA = "0x188A997A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8A99760", Offset = "0x8A98B60", VA = "0x188A99760", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x8A996C0", Offset = "0x8A98AC0", VA = "0x188A996C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<VRXVJDMHIYE> ZIQLYHJUMYA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8A996C0", Offset = "0x8A98AC0", VA = "0x188A996C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
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
			public AsyncTaskMethodBuilder<WIIGEWEAFFO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public RoomManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public KCPWVXKRWZI autosaveRecordInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private TaskAwaiter<WIIGEWEAFFO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFEF0", Offset = "0x8AAF2F0", VA = "0x188AAFEF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8AB0170", Offset = "0x8AAF570", VA = "0x188AB0170", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AB01E0", Offset = "0x8AAF5E0", VA = "0x188AB01E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8AB0410", Offset = "0x8AAF810", VA = "0x188AB0410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly CancellationTokenSource JQPYBFLQPRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly XRSJVGYQFTW container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool GQSAKQHYXLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private LogFlagsToken TEGIOIBPNML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private bool WLBSXENLNGU;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public HFLLGBMWIHF EGFOQSVFQXO
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public UYGOTJQHPYH IKASHGLDQKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public MVZYDDMAODN OJXQDUAJVPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAA3130", Offset = "0xAA2530", VA = "0x180AA3130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public GBQCQYLDPKW RZUUXIUJREV
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA2520", VA = "0x180AA3120", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public DAQZLJHROXK XTWCRVXITQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA4790", VA = "0x180AA5390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public RJVDARAWJUM TGOPYCQSXZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xAAD010", Offset = "0xAAC410", VA = "0x180AAD010", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAAD050", Offset = "0xAAC450", VA = "0x180AAD050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public ZMJYUQZMWBJ HQQPDODIKPU
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xAAD040", Offset = "0xAAC440", VA = "0x180AAD040", Slot = "54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9D0", Offset = "0xAABDD0", VA = "0x180AAC9D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public SJYCKVQRDLU SJYCKVQRDLU
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9A0", Offset = "0xAABDA0", VA = "0x180AAC9A0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9F0", Offset = "0xAABDF0", VA = "0x180AAC9F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public AEOKRKYITOK TJNNVAWKCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xAD3CC0", Offset = "0xAD30C0", VA = "0x180AD3CC0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xCA6670", Offset = "0xCA5A70", VA = "0x180CA6670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public YDVAPVGWKHO JJKTDLUGNSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9C0", Offset = "0xAABDC0", VA = "0x180AAC9C0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAAC960", Offset = "0xAABD60", VA = "0x180AAC960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public WDIEJYQAOTC DKHHOJRBOMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xB9E4B0", Offset = "0xB9D8B0", VA = "0x180B9E4B0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xB9D910", Offset = "0xB9CD10", VA = "0x180B9D910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public XJYONDZRBRO FOQKLDFPAPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A40", Offset = "0xAA5E40", VA = "0x180AA6A40", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A70", Offset = "0xAA5E70", VA = "0x180AA6A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public CFVVXENXKIU WQCNKUYTZKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xC24EE0", Offset = "0xC242E0", VA = "0x180C24EE0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xCE6C10", Offset = "0xCE6010", VA = "0x180CE6C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public NTXWNCDUYQJ WZZOGQKHDRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xBDEAA0", Offset = "0xBDDEA0", VA = "0x180BDEAA0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x1208F70", Offset = "0x1208370", VA = "0x181208F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public XQTTFYUWSSS PVOBZSSGYOD
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xBC4FA0", Offset = "0xBC43A0", VA = "0x180BC4FA0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xBC4FB0", Offset = "0xBC43B0", VA = "0x180BC4FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public JBTMEWGPJAK HFKLVMQKYAT
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xB688E0", Offset = "0xB67CE0", VA = "0x180B688E0", Slot = "60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1064470", Offset = "0x1063870", VA = "0x181064470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public MJXMMBCQHCL EXBVKUSFDIU
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xB52030", Offset = "0xB51430", VA = "0x180B52030", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xBF3230", Offset = "0xBF2630", VA = "0x180BF3230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public CWKKMCQNDCO JAXDRQHPGMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xAA6AB0", Offset = "0xAA5EB0", VA = "0x180AA6AB0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xAA6D60", Offset = "0xAA6160", VA = "0x180AA6D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public BSMMJIHFQGX XYHYOUOPZWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xC666E0", Offset = "0xC65AE0", VA = "0x180C666E0", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xDEC850", Offset = "0xDEBC50", VA = "0x180DEC850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public FNMSXOSALFV OLMDRALOLPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xC666C0", Offset = "0xC65AC0", VA = "0x180C666C0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x1416090", Offset = "0x1415490", VA = "0x181416090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public NPDGWTKDDKX INIFKHUGILM
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xC666D0", Offset = "0xC65AD0", VA = "0x180C666D0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x1418530", Offset = "0x1417930", VA = "0x181418530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public MLQYKKHTWKA BUZYFFFNMKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xB688D0", Offset = "0xB67CD0", VA = "0x180B688D0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x1207780", Offset = "0x1206B80", VA = "0x181207780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public CJGHBXBZXEK WJIXZDMREBL
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xBF1FE0", Offset = "0xBF13E0", VA = "0x180BF1FE0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xBF2A40", Offset = "0xBF1E40", VA = "0x180BF2A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public EIZRSISINPE XCOOHSJZWJF
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xC66690", Offset = "0xC65A90", VA = "0x180C66690", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1418550", Offset = "0x1417950", VA = "0x181418550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public NIIEZGNLYUY SUYBKJUESRL
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xB80490", Offset = "0xB7F890", VA = "0x180B80490", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xCD1560", Offset = "0xCD0960", VA = "0x180CD1560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public ICXFHWXUHPB ABCOTGHCMAA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xC66650", Offset = "0xC65A50", VA = "0x180C66650", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x1208A40", Offset = "0x1207E40", VA = "0x181208A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public PIYWXEEYHLZ BWOFSSDPPGI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xBBD580", Offset = "0xBBC980", VA = "0x180BBD580", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xBBA400", Offset = "0xBB9800", VA = "0x180BBA400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public PITYKGBNJVB CRWUXWSDSLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xBBDEF0", Offset = "0xBBD2F0", VA = "0x180BBDEF0", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xBBC470", Offset = "0xBBB870", VA = "0x180BBC470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public BLPDIKJBTAX XAFLKKXKUOK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xC66660", Offset = "0xC65A60", VA = "0x180C66660", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public MXQCDMJQSQQ RVOHSYRVRYP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xB13E50", Offset = "0xB13250", VA = "0x180B13E50", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public OPLTLPPSEIP KYYEYMYAQPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xC66670", Offset = "0xC65A70", VA = "0x180C66670", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public GTOTEIGPFPL KXWRIWIRDCS
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xB13EE0", Offset = "0xB132E0", VA = "0x180B13EE0", Slot = "35")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public WTLPGQTVEHV IKWDRFAHJRK
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xBCE960", Offset = "0xBCDD60", VA = "0x180BCE960", Slot = "36")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public QPEPMFBJVFS BMRXWMPLALY
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xC667C0", Offset = "0xC65BC0", VA = "0x180C667C0", Slot = "58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xDD1030", Offset = "0xDD0430", VA = "0x180DD1030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private bool KPENCNLRQRR
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x8AA4530", Offset = "0x8AA3930", VA = "0x188AA4530", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private bool ORFPHNQPYIC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x8AA4B20", Offset = "0x8AA3F20", VA = "0x188AA4B20", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool KZLPEYQKNDY
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1987B80", Offset = "0x1986F80", VA = "0x181987B80", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private CancellationToken GHIIRWDGNKM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x8AA4B00", Offset = "0x8AA3F00", VA = "0x188AA4B00", Slot = "4")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private XRSJVGYQFTW CBVHRPKCNKN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private bool KUBHEOIGPQL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1987B80", Offset = "0x1986F80", VA = "0x181987B80", Slot = "37")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x198F690", Offset = "0x198EA90", VA = "0x18198F690", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		private event RoomEventHandler YLDIFRJOZWH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8AA3DE0", Offset = "0x8AA31E0", VA = "0x188AA3DE0", Slot = "40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8AA4930", Offset = "0x8AA3D30", VA = "0x188AA4930", Slot = "41")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event RoomEventHandler BTQTZZSAIFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8AA4170", Offset = "0x8AA3570", VA = "0x188AA4170", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8AA3E40", Offset = "0x8AA3240", VA = "0x188AA3E40", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		private event RoomEventHandler VUCYRCCXWVV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8AA3EA0", Offset = "0x8AA32A0", VA = "0x188AA3EA0", Slot = "44")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8AA4470", Offset = "0x8AA3870", VA = "0x188AA4470", Slot = "45")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		private event Action<RequestOperationType, bool> OCDITUOTULF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x8AA44D0", Offset = "0x8AA38D0", VA = "0x188AA44D0", Slot = "46")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x8AA45E0", Offset = "0x8AA39E0", VA = "0x188AA45E0", Slot = "47")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xDD1030", Offset = "0xDD0430", VA = "0x180DD1030", Slot = "39")]
		public void CKVHVFUKQDY(QPEPMFBJVFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8AA4C20", Offset = "0x8AA4020", VA = "0x188AA4C20")]
		[UnityEngine.Scripting.Preserve]
		internal RoomManager([Inject(null)] XRSJVGYQFTW container, [Inject(null)] HFLLGBMWIHF networking, [Inject(null)] UYGOTJQHPYH photonClient, [Inject(null)] MVZYDDMAODN callbacks, [Inject(null)] GBQCQYLDPKW assetBundleManager, [Inject(null)] DAQZLJHROXK roomReloadValidation, [Inject(null)] RJVDARAWJUM roomSaveValidation, [Inject(null)] SJYCKVQRDLU debugRoomLoadInfo, [Inject(null)] AEOKRKYITOK activeTask, [Inject(null)] YDVAPVGWKHO autosaves, [Inject(null)] WDIEJYQAOTC events, [Inject(null)] XJYONDZRBRO fallbacks, [Inject(null)] CFVVXENXKIU initialRoomLoad, [Inject(null)] NTXWNCDUYQJ inRoomTasks, [Inject(null)] XQTTFYUWSSS pendingRequests, [Inject(null)] JBTMEWGPJAK presenceUpdates, [Inject(null)] MJXMMBCQHCL receiveOperation, [Inject(null)] CWKKMCQNDCO requestHandler, [Inject(null)] BSMMJIHFQGX requestOperation, [Inject(null)] FNMSXOSALFV roomLoadRequest, [Inject(null)] MLQYKKHTWKA save, [Inject(null)] NPDGWTKDDKX synchronization, [Inject(null)] CJGHBXBZXEK validation, [Inject(null)] EIZRSISINPE roomJoinAnalytics, [Inject(null)] NIIEZGNLYUY playerSynchronization, [Inject(null)] PIYWXEEYHLZ config, [Inject(null)] PITYKGBNJVB roomLoadDataProviderOverride, [Inject(null)] BLPDIKJBTAX autosaveService, [Inject(null)] MXQCDMJQSQQ cameraFade, [Inject(null)] OPLTLPPSEIP errorRegistry, [Inject(null)] GTOTEIGPFPL onlineRestrictions, [Inject(null)] WTLPGQTVEHV preEmptySceneHandler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8AA43D0", Offset = "0x8AA37D0", VA = "0x188AA43D0")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8AA3F80", Offset = "0x8AA3380", VA = "0x188AA3F80", Slot = "59")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8AA4590", Offset = "0x8AA3990", VA = "0x188AA4590", Slot = "51")]
		private void PDXCJKIILOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8AA4A80", Offset = "0x8AA3E80", VA = "0x188AA4A80", Slot = "52")]
		private OEHTXSFHHXB UURXPBYLGQA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8AA3F00", Offset = "0x8AA3300", VA = "0x188AA3F00", Slot = "53")]
		private HHIEEUBOKJK CPNGXXFLZRG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8AA4640", Offset = "0x8AA3A40", VA = "0x188AA4640", Slot = "55")]
		public Task QGUTCXBZCON(int a, RoomSaveRequestPayload b, Func<RoomSerializedData, RoomSerializedData> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8AA4990", Offset = "0x8AA3D90", VA = "0x188AA4990")]
		private XTPTPGMIUHE SXMGMJLLDUH(int a, RoomSaveRequestPayload b, Func<RoomSerializedData, RoomSerializedData> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8AA41D0", Offset = "0x8AA35D0", VA = "0x188AA41D0", Slot = "56")]
		[AsyncStateMachine(typeof(<RecRoom-RoomLoading-IRoomManager-RequestRestoreAutosave>d__165))]
		private Task<WIIGEWEAFFO> GUJXZDWATCK(KCPWVXKRWZI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8AA42E0", Offset = "0x8AA36E0", VA = "0x188AA42E0", Slot = "57")]
		[AsyncStateMachine(typeof(<RecRoom-RoomLoading-IRoomManager-RunRecoveryAutosave>d__166))]
		private Task HXCTSSYWQID(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8AA4BA0", Offset = "0x8AA3FA0", VA = "0x188AA4BA0")]
		[IteratorStateMachine(typeof(AVNLOVCBPHI))]
		private IEnumerable<VRXVJDMHIYE> YTNHWCSMHGW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8AA4110", Offset = "0x8AA3510", VA = "0x188AA4110")]
		[CompilerGenerated]
		private void EYFHQJYWDEA(VRXVJDMHIYE a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class CameraFadeTimeoutException : TimeoutException
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x17FB670", Offset = "0x17FAA70", VA = "0x1817FB670")]
		public CameraFadeTimeoutException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal class FallbackToBootScene : WDCHJYTZKRA
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
			public AsyncTaskMethodBuilder<WDCHJYTZKRA.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public HashSet<RPPCBTZSYTD.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public FallbackToBootScene <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8AB4000", Offset = "0x8AB3400", VA = "0x188AB4000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8AB4300", Offset = "0x8AB3700", VA = "0x188AB4300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly MVWEOVUCDOM ITQPEIGRZZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly MVZYDDMAODN GTVBHFZJJCG;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		private string VMZDRPSQYAZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8A9AD50", Offset = "0x8A9A150", VA = "0x188A9AD50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xAA8230", Offset = "0xAA7630", VA = "0x180AA8230")]
		public FallbackToBootScene(MVWEOVUCDOM roomManager, MVZYDDMAODN callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8A9AD80", Offset = "0x8A9A180", VA = "0x188A9AD80", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__6))]
		public Task<WDCHJYTZKRA.Result> VQAZLYQXMPX(HashSet<RPPCBTZSYTD.Reason> a, CancellationToken b, RPPCBTZSYTD.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal class FallbackToOfflineDormRoom : VYFWOMWWWQL, WDCHJYTZKRA
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
			public AsyncTaskMethodBuilder<WDCHJYTZKRA.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public FallbackToOfflineDormRoom <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public HashSet<RPPCBTZSYTD.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public RPPCBTZSYTD.Reason reason;

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
			private TaskAwaiter<WDCHJYTZKRA.Result> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8AB28F0", Offset = "0x8AB1CF0", VA = "0x188AB28F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8AB3F20", Offset = "0x8AB3320", VA = "0x188AB3F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly BYDTMGIEZRR PSGBMNCTOFA;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		private string VMZDRPSQYAZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x8A9AF10", Offset = "0x8A9A310", VA = "0x188A9AF10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B110", Offset = "0x8A9A510", VA = "0x188A9B110")]
		public FallbackToOfflineDormRoom([Inject(null)] MVWEOVUCDOM roomManager, [Inject(null)] MVZYDDMAODN callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8A9AF40", Offset = "0x8A9A340", VA = "0x188A9AF40", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__5))]
		public Task<WDCHJYTZKRA.Result> VQAZLYQXMPX(HashSet<RPPCBTZSYTD.Reason> a, CancellationToken b, RPPCBTZSYTD.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal class FallbackToOfflineMultiplayerOrientationSubRoom : VYFWOMWWWQL, WDCHJYTZKRA
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
			public AsyncTaskMethodBuilder<WDCHJYTZKRA.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public FallbackToOfflineMultiplayerOrientationSubRoom <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public HashSet<RPPCBTZSYTD.Reason> fallbackTriggersToIgnore;

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
			private TaskAwaiter<WDCHJYTZKRA.Result> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1E90", Offset = "0x8AB1290", VA = "0x188AB1E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x8AB2880", Offset = "0x8AB1C80", VA = "0x188AB2880", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		private string VMZDRPSQYAZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8A9B1E0", Offset = "0x8A9A5E0", VA = "0x188A9B1E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xAA8230", Offset = "0xAA7630", VA = "0x180AA8230")]
		public FallbackToOfflineMultiplayerOrientationSubRoom(MVWEOVUCDOM roomManager, MVZYDDMAODN callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B210", Offset = "0x8A9A610", VA = "0x188A9B210", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__4))]
		public Task<WDCHJYTZKRA.Result> VQAZLYQXMPX(HashSet<RPPCBTZSYTD.Reason> a, CancellationToken b, RPPCBTZSYTD.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal class FallbackToOnlineDormRoom : VYFWOMWWWQL, WDCHJYTZKRA
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class AZSYQXSOVDR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public MatchmakingErrorCode XDNQUBXGUXH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public RoomInstance EYLHAJXPJWE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public long UPMTUQERDHI;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public AZSYQXSOVDR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8A99C10", Offset = "0x8A99010", VA = "0x188A99C10")]
			internal object APQSVSVSINL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A99B50", Offset = "0x8A98F50", VA = "0x188A99B50")]
			internal object APLLYMBUZCC()
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
			public AsyncTaskMethodBuilder<WDCHJYTZKRA.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public FallbackToOnlineDormRoom <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public HashSet<RPPCBTZSYTD.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private AZSYQXSOVDR <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public RPPCBTZSYTD.Reason reason;

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
			private TaskAwaiter<WDCHJYTZKRA.Result> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8AB32C0", Offset = "0x8AB26C0", VA = "0x188AB32C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x8AB3F90", Offset = "0x8AB3390", VA = "0x188AB3F90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly BYDTMGIEZRR PSGBMNCTOFA;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		private string VMZDRPSQYAZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8A9B3E0", Offset = "0x8A9A7E0", VA = "0x188A9B3E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B5E0", Offset = "0x8A9A9E0", VA = "0x188A9B5E0")]
		public FallbackToOnlineDormRoom([Inject(null)] MVWEOVUCDOM roomManager, [Inject(null)] MVZYDDMAODN callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B410", Offset = "0x8A9A810", VA = "0x188A9B410", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__5))]
		public Task<WDCHJYTZKRA.Result> VQAZLYQXMPX(HashSet<RPPCBTZSYTD.Reason> a, CancellationToken b, RPPCBTZSYTD.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal abstract class VYFWOMWWWQL
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
			public HashSet<RPPCBTZSYTD.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public VYFWOMWWWQL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private List<RPPCBTZSYTD.Reason> <newDisconnectTriggers>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x8AAE590", Offset = "0x8AAD990", VA = "0x188AAE590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x8AAEAB0", Offset = "0x8AADEB0", VA = "0x188AAEAB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		protected readonly MVWEOVUCDOM ITQPEIGRZZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		protected readonly MVZYDDMAODN GTVBHFZJJCG;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected INKPZSVDXUP KYYXCPGOJZA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x8AB89B0", Offset = "0x8AB7DB0", VA = "0x188AB89B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xAA8230", Offset = "0xAA7630", VA = "0x180AA8230")]
		public VYFWOMWWWQL(MVWEOVUCDOM a, MVZYDDMAODN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8AB8880", Offset = "0x8AB7C80", VA = "0x188AB8880")]
		[AsyncStateMachine(typeof(<DisconnectFromRoomInstance>d__5))]
		protected Task DisconnectFromRoomInstance(Log log, HashSet<RPPCBTZSYTD.Reason> fallbackTriggersToIgnore, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class UOVWLUJYZQM
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class JLSEUHBSZCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public string AQJCUAZSKAX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public MVWEOVUCDOM ITQPEIGRZZG;

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public JLSEUHBSZCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C2B0", Offset = "0x8A9B6B0", VA = "0x188A9C2B0")]
			internal object VNVWLLWMMVY()
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
			public AsyncTaskMethodBuilder<WDCHJYTZKRA.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public MVZYDDMAODN callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private float <timeoutTime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x8AB7D80", Offset = "0x8AB7180", VA = "0x188AB7D80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x8AB8100", Offset = "0x8AB7500", VA = "0x188AB8100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static readonly float RVDBKHTDNLM;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		internal static readonly HashSet<RPPCBTZSYTD.Reason> VLGMWIBSUIH;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8AB84E0", Offset = "0x8AB78E0", VA = "0x188AB84E0")]
		[AsyncStateMachine(typeof(<WaitForPlayerToSpawn>d__2))]
		internal static Task<WDCHJYTZKRA.Result> EIOICPNJNVT(MVZYDDMAODN a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8AB85F0", Offset = "0x8AB79F0", VA = "0x188AB85F0")]
		internal static void SGYXJSTLKFG(MVWEOVUCDOM a, Log b, string c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal interface WDCHJYTZKRA
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public struct Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public bool success;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public RPPCBTZSYTD.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public Enum? subReason;

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x8A9E810", Offset = "0x8A9DC10", VA = "0x188A9E810")]
			public static Result Success()
			{
				return default(Result);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x8A9E7E0", Offset = "0x8A9DBE0", VA = "0x188A9E7E0")]
			public static Result Failure(RPPCBTZSYTD.Reason reason, [Optional] Enum? subReason)
			{
				return default(Result);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		string PFGOXGMIBNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<Result> VQAZLYQXMPX(HashSet<RPPCBTZSYTD.Reason> a, CancellationToken b, RPPCBTZSYTD.Reason c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal struct RestoreRecoveryAutosaveInRoomTask
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class JLSEUHBSZCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public MVWEOVUCDOM KYSGMPHMQKZ;

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public JLSEUHBSZCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C260", Offset = "0x8A9B660", VA = "0x188A9C260")]
			internal Task TMBSYOPSNWT(CancellationToken a, int b, AccountRoleType c)
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
			private KCPWVXKRWZI <autosaveInfo>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private TaskAwaiter<LoadRecoveryAutosaveResponse> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private TaskAwaiter<WIIGEWEAFFO> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x8AB4370", Offset = "0x8AB3770", VA = "0x188AB4370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x8AB4900", Offset = "0x8AB3D00", VA = "0x188AB4900", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AB8170", Offset = "0x8AB7570", VA = "0x188AB8170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x8AB8480", Offset = "0x8AB7880", VA = "0x188AB8480", Slot = "5")]
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
		private readonly MVWEOVUCDOM manager;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private HFLLGBMWIHF EGFOQSVFQXO
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x8A9E790", Offset = "0x8A9DB90", VA = "0x188A9E790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		private MVZYDDMAODN OJXQDUAJVPU
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x8A9E080", Offset = "0x8A9D480", VA = "0x188A9E080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		private INKPZSVDXUP KYYXCPGOJZA
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x8A9E2D0", Offset = "0x8A9D6D0", VA = "0x188A9E2D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private YDVAPVGWKHO JJKTDLUGNSN
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x8A9E030", Offset = "0x8A9D430", VA = "0x188A9E030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x287AB50", Offset = "0x2879F50", VA = "0x18287AB50")]
		public RestoreRecoveryAutosaveInRoomTask(CancellationToken cancellationToken, MVWEOVUCDOM manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8A9E560", Offset = "0x8A9D960", VA = "0x188A9E560")]
		public static InLoadedRoomTaskBuilder OXKQQVBTALR(MVWEOVUCDOM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8A9E680", Offset = "0x8A9DA80", VA = "0x188A9E680")]
		[AsyncStateMachine(typeof(<Run>d__4))]
		public Task<bool> Run()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8A9E350", Offset = "0x8A9D750", VA = "0x188A9E350")]
		private bool MCOHRDQXQXS([Out] KCPWVXKRWZI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8A9E200", Offset = "0x8A9D600", VA = "0x188A9E200")]
		[AsyncStateMachine(typeof(<WaitUntilWatchMenuIsReady>d__6))]
		private Task LNKOGYFDHPQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8A9E0D0", Offset = "0x8A9D4D0", VA = "0x188A9E0D0")]
		private Task<LoadRecoveryAutosaveResponse> KKIKYHPQMVB(KCPWVXKRWZI a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal struct PendingRequest : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly XQTTFYUWSSS pendingRequests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private Task<(WIIGEWEAFFO, Task)> HYDORYQLSAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x8A9DEA0", Offset = "0x8A9D2A0", VA = "0x188A9DEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x5051FC0", Offset = "0x50513C0", VA = "0x185051FC0")]
		public PendingRequest(XQTTFYUWSSS pendingRequests, Guid operationId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8A9DF70", Offset = "0x8A9D370", VA = "0x188A9DF70")]
		public TaskAwaiter<(WIIGEWEAFFO, Task)> VUUHDRRTNGT()
		{
			return default(TaskAwaiter<(WIIGEWEAFFO, Task)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x8A9DDD0", Offset = "0x8A9D1D0", VA = "0x188A9DDD0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal struct PendingRequestData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly TaskCompletionSource<(WIIGEWEAFFO, Task)> taskCompletion;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Task<(WIIGEWEAFFO, Task)> HYDORYQLSAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x8A9DBD0", Offset = "0x8A9CFD0", VA = "0x188A9DBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8A9DC60", Offset = "0x8A9D060", VA = "0x188A9DC60")]
		public PendingRequestData(TimeSpan timeout)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9DAA0", Offset = "0x8A9CEA0", VA = "0x188A9DAA0")]
		public void IXJEFVLZGZB(Task a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9DA10", Offset = "0x8A9CE10", VA = "0x188A9DA10")]
		public void EFKAELOXDFB(WIIGEWEAFFO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9DC10", Offset = "0x8A9D010", VA = "0x188A9DC10")]
		public void TXGOLGGFIUB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9DB40", Offset = "0x8A9CF40", VA = "0x188A9DB40")]
		internal void NEAYTUBVGRF(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class PHJZTHILUTI
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D8E0", Offset = "0x8A9CCE0", VA = "0x188A9D8E0")]
		public static RoomLoadRequestPayload JUKARZBRDXY(this RoomLoadRequestPayload a, RoomDetailsDTO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D770", Offset = "0x8A9CB70", VA = "0x188A9D770")]
		public static RoomLoadRequestPayload BTRETCAHDSS(this RoomLoadRequestPayload a, SubRoomDataSaveDTO b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal sealed class HQQPDODIKPU : ZMJYUQZMWBJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class AZSYQXSOVDR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public SubRoomDataSaveDTO VRXVHYCQZRE;

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public AZSYQXSOVDR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x8A99C90", Offset = "0x8A99090", VA = "0x188A99C90")]
			internal bool ZBDLZNQEEPS(SubRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly PIYWXEEYHLZ IRXAQRPRJAV;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public HQQPDODIKPU(PIYWXEEYHLZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8A9BD90", Offset = "0x8A9B190", VA = "0x188A9BD90", Slot = "4")]
		public RoomLoadRequestPayload Create(long superRoomId, long subRoomId, string studioSessionId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8A9BE20", Offset = "0x8A9B220", VA = "0x188A9BE20", Slot = "5")]
		public RoomLoadRequestPayload Create(long superRoomId, long subRoomId, FilenameWithHash superRoomData, Guid? snapshotId, long subRoomDataSaveId, bool loadUsedCompatibility)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B9B0", Offset = "0x8A9ADB0", VA = "0x188A9B9B0", Slot = "6")]
		public RoomLoadRequestPayload Create(SaveSubRoomResponseDTO saveSubRoomResponseDTO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8A9BB20", Offset = "0x8A9AF20", VA = "0x188A9BB20", Slot = "7")]
		public RoomLoadRequestPayload Create(RoomDetailsDTO superRoom, SubRoomDataSaveDTO subRoomSave)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8A9B900", Offset = "0x8A9AD00", VA = "0x188A9B900")]
		private Guid? AHJHDNITPQO(RoomDetailsDTO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerActiveTask : AEOKRKYITOK, VRXVJDMHIYE, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x8AB0FF0", Offset = "0x8AB03F0", VA = "0x188AB0FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x8AB1650", Offset = "0x8AB0A50", VA = "0x188AB1650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly Token ZBEMXPRQBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private string YKOXELVEYYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private Task HPSTWKXJVOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private MVWEOVUCDOM ITQPEIGRZZG;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public bool UPIDIBGRWCA
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x8A9E890", Offset = "0x8A9DC90", VA = "0x188A9E890", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public Task QNBSVVFMDOE
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x8A9E9E0", Offset = "0x8A9DDE0", VA = "0x188A9E9E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0", Slot = "7")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EA70", Offset = "0x8A9DE70", VA = "0x188A9EA70", Slot = "6")]
		public void SBIGYGCFVZV(Task a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8A9E8C0", Offset = "0x8A9DCC0", VA = "0x188A9E8C0")]
		[AsyncStateMachine(typeof(<RunAndSetCurrentTask>d__11))]
		private Task KIBXGOPHNWE(Task a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EBD0", Offset = "0x8A9DFD0", VA = "0x188A9EBD0")]
		public RoomManagerActiveTask()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	internal class DNPPSDTYCTM : ICXFHWXUHPB, VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool NNWWHSSXFCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private WGTOKMZHNDN ICYYZXXDFDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private HFLLGBMWIHF UGOVYLDDXNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private PIYWXEEYHLZ FLZKNZEKBWY;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public WGTOKMZHNDN WGTOKMZHNDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x8A9A470", Offset = "0x8A99870", VA = "0x188A9A470", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8A9A300", Offset = "0x8A99700", VA = "0x188A9A300", Slot = "7")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8A9A4E0", Offset = "0x8A998E0", VA = "0x188A9A4E0", Slot = "5")]
		public void LSJXRWXJMYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9A2C0", Offset = "0x8A996C0", VA = "0x188A9A2C0", Slot = "6")]
		public void QGSPCYEKKJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9A690", Offset = "0x8A99A90", VA = "0x188A9A690")]
		private Task YVKWAYRVMGX(DisconnectCause a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9A2C0", Offset = "0x8A996C0", VA = "0x188A9A2C0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public DNPPSDTYCTM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal class LZBLCRUSOJY : PIYWXEEYHLZ
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		private class Config<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly GMLPBIHOWQX CXBLQZUIQVA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly string RJWUJQXIPUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly T CSYDDAGUDKQ;

			[Cpp2IlInjected.Token(Token = "0x170000B4")]
			public T QEMSNQIEONV
			{
				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0xAF8E00", Offset = "0xAF8200", VA = "0x180AF8E00")]
				[CompilerGenerated]
				get
				{
					return (T)null;
				}
				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0xB22470", Offset = "0xB21870", VA = "0x180B22470")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x411BC00", Offset = "0x411B000", VA = "0x18411BC00")]
			public Config(GMLPBIHOWQX gameConfigsProvider, string key, T defaultValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x411B1E0", Offset = "0x411A5E0", VA = "0x18411B1E0")]
			private void JFOTCVLLRRY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly GMLPBIHOWQX CXBLQZUIQVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly Config<TimeSpan> XKENNPYFLBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly Config<TimeSpan> LTCMHVKBROA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly Config<TimeSpan> DIZWNJQCGCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly Config<TimeSpan> VWLLZBGRWOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly Config<bool> MXNDEXMZUOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly Config<bool> FFSGTHEVMUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Config<bool> AUSOWESAKNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Config<int> XABLHTESBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private readonly Config<bool> TLGHJULGDJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly Config<bool> PHVEUDGONSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly Config<PlatformMask> MEKWKRHOGOH;

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public TimeSpan IYZNPETHBBH
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C950", Offset = "0x8A9BD50", VA = "0x188A9C950", Slot = "4")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public TimeSpan SKKSPLPMCOZ
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C7C0", Offset = "0x8A9BBC0", VA = "0x188A9C7C0", Slot = "5")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public TimeSpan HTJWQLKBFEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C840", Offset = "0x8A9BC40", VA = "0x188A9C840", Slot = "6")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public TimeSpan ZRUJTPBNUCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C800", Offset = "0x8A9BC00", VA = "0x188A9C800", Slot = "7")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool XXRASIMZOKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C990", Offset = "0x8A9BD90", VA = "0x188A9C990", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool OUFPXMXSKJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C910", Offset = "0x8A9BD10", VA = "0x188A9C910", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool ZIFQNJTKLOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C9D0", Offset = "0x8A9BDD0", VA = "0x188A9C9D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public int XJDDSZXDUSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C8D0", Offset = "0x8A9BCD0", VA = "0x188A9C8D0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool YUQZKSVDXIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x8A9CA10", Offset = "0x8A9BE10", VA = "0x188A9CA10", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public bool BUUNQYVEKXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C780", Offset = "0x8A9BB80", VA = "0x188A9C780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public bool FUAWLXWHEZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8A9C880", Offset = "0x8A9BC80", VA = "0x188A9C880", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8A9CA50", Offset = "0x8A9BE50", VA = "0x188A9CA50")]
		[UnityEngine.Scripting.Preserve]
		public LZBLCRUSOJY([Inject(null)] GMLPBIHOWQX gameConfigsProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomManagerEvents : WDIEJYQAOTC, VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private sealed class OKOPEPOQFBZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public RoomEvent ACICKBVOEZV;

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OKOPEPOQFBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x8A9D6A0", Offset = "0x8A9CAA0", VA = "0x188A9D6A0")]
			internal object VJXFLVIQTHK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event RoomEventHandler XPYTYQHLPWM
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F190", Offset = "0x8A9E590", VA = "0x188A9F190", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x8A9ECD0", Offset = "0x8A9E0D0", VA = "0x188A9ECD0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event RoomEventHandler HCNGKMLRXNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F2D0", Offset = "0x8A9E6D0", VA = "0x188A9F2D0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F370", Offset = "0x8A9E770", VA = "0x188A9F370", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event RoomEventHandler ARBHTPXISAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F230", Offset = "0x8A9E630", VA = "0x188A9F230", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F0F0", Offset = "0x8A9E4F0", VA = "0x188A9F0F0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<RequestOperationType, bool> GYQDDCHOSUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F010", Offset = "0x8A9E410", VA = "0x188A9F010", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x8A9EF60", Offset = "0x8A9E360", VA = "0x188A9EF60", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "16")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F0C0", Offset = "0x8A9E4C0", VA = "0x188A9F0C0", Slot = "12")]
		public void MPXEFVHTNXK(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8A9ECA0", Offset = "0x8A9E0A0", VA = "0x188A9ECA0", Slot = "13")]
		public void CLIAIBYJSPW(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9ED70", Offset = "0x8A9E170", VA = "0x188A9ED70", Slot = "14")]
		public void IJFVGNUMEDM(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EC50", Offset = "0x8A9E050", VA = "0x188A9EC50", Slot = "15")]
		public void ARVDCKCSSVS(RequestOperationType a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EDA0", Offset = "0x8A9E1A0", VA = "0x188A9EDA0")]
		private void Invoke(RoomEventHandler handler, RoomEvent roomEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomManagerEvents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomManagerFallbacks : XJYONDZRBRO, VRXVJDMHIYE, IDisposable, RPPCBTZSYTD
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		private class TEECCABDIHB : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class EMQMBTNNLSE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				public RPPCBTZSYTD.FallbackReason FGTRALMAFMO;

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public EMQMBTNNLSE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x8A9AAE0", Offset = "0x8A99EE0", VA = "0x188A9AAE0")]
				internal object KJYUMQMDRXW((RPPCBTZSYTD.Reason fallbackReason, RoomDTO roomDto, BEWIAZUUSKP state, string subReason) x)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000074")]
			[CompilerGenerated]
			private sealed class TWLQVARRGGE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public WDCHJYTZKRA XWZCXOJYWBP;

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public TWLQVARRGGE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x8AA6BF0", Offset = "0x8AA5FF0", VA = "0x188AA6BF0")]
				internal object BQAJWROOJML()
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
				public TEECCABDIHB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				public RPPCBTZSYTD.FallbackReason reason;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				private LogRangeScope <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				private WDCHJYTZKRA[] <>7__wrap2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				private int <>7__wrap3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				private TaskAwaiter<WDCHJYTZKRA.Result> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x8AB16B0", Offset = "0x8AB0AB0", VA = "0x188AB16B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x8AB1E30", Offset = "0x8AB1230", VA = "0x188AB1E30", Slot = "5")]
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
				public AsyncTaskMethodBuilder<WDCHJYTZKRA.Result> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400013B")]
				public WDCHJYTZKRA fallbackProvider;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public TEECCABDIHB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				public RPPCBTZSYTD.FallbackReason reason;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				private LogRangeScope <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				private BEWIAZUUSKP <individualFallbackTaskState>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				private TaskAwaiter<WDCHJYTZKRA.Result> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x8AB6270", Offset = "0x8AB5670", VA = "0x188AB6270", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x8AB6EE0", Offset = "0x8AB62E0", VA = "0x188AB6EE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Task WFXEXJKFLHZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public CancellationTokenSource WYAUYZULPRA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public BEWIAZUUSKP NXMAPKJRGLX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public MVZYDDMAODN GTVBHFZJJCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public RoomDTO HFQEGNMCAZU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public RoomInstance OPPZVZSRPUW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public WDCHJYTZKRA[] ENGKQTDLPZY;

			[Cpp2IlInjected.Token(Token = "0x170000B8")]
			public bool NDERTCEYITZ
			{
				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x8A99E40", Offset = "0x8A99240", VA = "0x188A99E40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B9")]
			public bool GTGDVZHYPDN
			{
				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x8A9A080", Offset = "0x8A99480", VA = "0x188A9A080")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x8AA6AD0", Offset = "0x8AA5ED0", VA = "0x188AA6AD0")]
			public TEECCABDIHB(MVZYDDMAODN a, RoomDTO b, RoomInstance c, WDCHJYTZKRA[] d, CancellationToken e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5320", Offset = "0x8AA4720", VA = "0x188AA5320", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5FC0", Offset = "0x8AA53C0", VA = "0x188AA5FC0")]
			public void PKMZFULNNES()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x8AA6860", Offset = "0x8AA5C60", VA = "0x188AA6860")]
			public void WDUOWEEKAHU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8AA6460", Offset = "0x8AA5860", VA = "0x188AA6460")]
			public void VIVGFERHYSD(RPPCBTZSYTD.Reason a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5860", Offset = "0x8AA4C60", VA = "0x188AA5860")]
			[AsyncStateMachine(typeof(<RunFallbackSequence>d__16))]
			public Task LGTJPMWKOXK(RPPCBTZSYTD.FallbackReason a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x8AA6310", Offset = "0x8AA5710", VA = "0x188AA6310")]
			[AsyncStateMachine(typeof(<TryRunFallback>d__17))]
			private Task<WDCHJYTZKRA.Result> UNRFARQVPDU(RPPCBTZSYTD.FallbackReason a, WDCHJYTZKRA b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x8AA54A0", Offset = "0x8AA48A0", VA = "0x188AA54A0")]
			private void GXRLMZJNQHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8AA6030", Offset = "0x8AA5430", VA = "0x188AA6030")]
			public bool QVQBWLKSMLS(RPPCBTZSYTD.Reason a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5970", Offset = "0x8AA4D70", VA = "0x188AA5970")]
			private void MKRATKYNXCS(BEWIAZUUSKP a, RPPCBTZSYTD.FallbackReason b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5160", Offset = "0x8AA4560", VA = "0x188AA5160")]
			private void ARSBXZSDWTN(BEWIAZUUSKP a, WDCHJYTZKRA.Result b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8AA55C0", Offset = "0x8AA49C0", VA = "0x188AA55C0")]
			private void IICUOHWOOJD(BEWIAZUUSKP a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5C00", Offset = "0x8AA5000", VA = "0x188AA5C00")]
			private void NVBLPXAEJOA(BEWIAZUUSKP a, WDCHJYTZKRA.Result b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8AA6700", Offset = "0x8AA5B00", VA = "0x188AA6700")]
			private void WCXRWAPJUAT(BEWIAZUUSKP a, Exception b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8AA69C0", Offset = "0x8AA5DC0", VA = "0x188AA69C0")]
			private void XNZGANZSVDG(WDCHJYTZKRA a, RPPCBTZSYTD.FallbackReason b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8AA5750", Offset = "0x8AA4B50", VA = "0x188AA5750")]
			private void JMYBEIBHYQK(WDCHJYTZKRA a, RPPCBTZSYTD.Reason b, string c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x8AA60E0", Offset = "0x8AA54E0", VA = "0x188AA60E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public class BEWIAZUUSKP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Task<WDCHJYTZKRA.Result> WFXEXJKFLHZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public CancellationTokenSource WYAUYZULPRA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public WDCHJYTZKRA XWZCXOJYWBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public RPPCBTZSYTD.Reason FRWPCHKDXUN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public HashSet<RPPCBTZSYTD.Reason> SLVKICBAJCK;

			[Cpp2IlInjected.Token(Token = "0x170000BA")]
			public bool NDERTCEYITZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x8A99E40", Offset = "0x8A99240", VA = "0x188A99E40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BB")]
			public bool GTGDVZHYPDN
			{
				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x8A9A080", Offset = "0x8A99480", VA = "0x188A9A080")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x8A99CC0", Offset = "0x8A990C0", VA = "0x188A99CC0")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x8A99E20", Offset = "0x8A99220", VA = "0x188A99E20", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x8A99E60", Offset = "0x8A99260", VA = "0x188A99E60", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x8A9A0A0", Offset = "0x8A994A0", VA = "0x188A9A0A0")]
			public BEWIAZUUSKP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class DGZUGYUZOOX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public RPPCBTZSYTD.Reason FGTRALMAFMO;

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public DGZUGYUZOOX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8A9A200", Offset = "0x8A99600", VA = "0x188A9A200")]
			internal object PAPZZPDPPIN(BEWIAZUUSKP a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x8A9A120", Offset = "0x8A99520", VA = "0x188A9A120")]
			internal object PAAFHUVXNAM(TEECCABDIHB a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x8A9A190", Offset = "0x8A99590", VA = "0x188A9A190")]
			internal object PAFMFBPUWLV()
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
			[Cpp2IlInjected.Address(RVA = "0x8AA6C70", Offset = "0x8AA6070", VA = "0x188AA6C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8AA71C0", Offset = "0x8AA65C0", VA = "0x188AA71C0", Slot = "5")]
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
			public RPPCBTZSYTD.FallbackReason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private TEECCABDIHB <localTaskState>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8AB4970", Offset = "0x8AB3D70", VA = "0x188AB4970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x8AB55E0", Offset = "0x8AB49E0", VA = "0x188AB55E0", Slot = "5")]
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
			public RPPCBTZSYTD.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public RoomManagerFallbacks <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			private DGZUGYUZOOX <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x8AB5640", Offset = "0x8AB4A40", VA = "0x188AB5640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8AB6210", Offset = "0x8AB5610", VA = "0x188AB6210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		internal static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		internal static readonly Log NBKBUTSXOLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private MVWEOVUCDOM ITQPEIGRZZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private MVZYDDMAODN GTVBHFZJJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private TEECCABDIHB GEXBGZKFPIL;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private INKPZSVDXUP KYYXCPGOJZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F9D0", Offset = "0x8A9EDD0", VA = "0x188A9F9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public bool RXZHZUENVJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x1E231F0", Offset = "0x1E225F0", VA = "0x181E231F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		private bool HKCFTZPHZNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x8A9FB40", Offset = "0x8A9EF40", VA = "0x188A9FB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F950", Offset = "0x8A9ED50", VA = "0x188A9F950", Slot = "6")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F580", Offset = "0x8A9E980", VA = "0x188A9F580", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F410", Offset = "0x8A9E810", VA = "0x188A9F410", Slot = "9")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8AA0210", Offset = "0x8A9F610", VA = "0x188AA0210")]
		private bool ZYKJUZMQCGW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F590", Offset = "0x8A9E990", VA = "0x188A9F590", Slot = "5")]
		private void FGFVUBYRLSA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8A9FA20", Offset = "0x8A9EE20", VA = "0x188A9FA20", Slot = "8")]
		[AsyncStateMachine(typeof(<TriggerFallback>d__14))]
		public Task MBHTSAEGCGI(RPPCBTZSYTD.Reason a, [Optional] Exception b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F660", Offset = "0x8A9EA60", VA = "0x188A9F660")]
		private bool IZVINTWNVIU(RPPCBTZSYTD.FallbackReason a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9FDA0", Offset = "0x8A9F1A0", VA = "0x188A9FDA0")]
		private WDCHJYTZKRA[] ZQOEVJJTPDG(RoomInstance a, RoomDTO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9FBB0", Offset = "0x8A9EFB0", VA = "0x188A9FBB0")]
		[AsyncStateMachine(typeof(<StartRunningFallbacks>d__19))]
		private Task StartRunningFallbacks(RPPCBTZSYTD.FallbackReason reason, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9FCD0", Offset = "0x8A9F0D0", VA = "0x188A9FCD0")]
		[AsyncStateMachine(typeof(<BlockWhilePreviousFallbackSequenceIsPendingCancellation>d__20))]
		private Task WDQNXMOLYHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomManagerFallbacks()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerInitialRoomLoad : CFVVXENXKIU, VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class ZXABQVGZVDZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public Matchmaking.GameJoinResult LSMVWTWXCVV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public ErrorCode YJPDROEYOLX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public Exception HCWNUUPSPGD;

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ZXABQVGZVDZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8AB9400", Offset = "0x8AB8800", VA = "0x188AB9400")]
			internal object RSAPYAGMTXP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private sealed class IIZHUEQDZCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public Task<RoomLoadRequestPayload> XQXMQXVYFKJ;

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public IIZHUEQDZCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			internal Task<RoomLoadRequestPayload> VPSWOTVOUWI(StackTimer<string>.UBFOGWXCCTH a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class UKCTNRDETIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public Task<RoomLoadRequestPayload> XQXMQXVYFKJ;

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public UKCTNRDETIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			internal Task<RoomLoadRequestPayload> JHGFHEEMNUS(StackTimer<string>.UBFOGWXCCTH a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class NIUIYVRLMAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public Task DJRMNYNPLLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public RoomInstance EYLHAJXPJWE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public bool YGQLMTSGYAZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public Task YACVNPBVFQQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public Task LBSXLSDLSLE;

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public NIUIYVRLMAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x8A9D430", Offset = "0x8A9C830", VA = "0x188A9D430")]
			internal object KGXZHEFEQAE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x8A9D530", Offset = "0x8A9C930", VA = "0x188A9D530")]
			internal string KHDGEKZBZLN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class NGKMSZCLBFV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public RoomInstance EYLHAJXPJWE;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public NGKMSZCLBFV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x8A9D270", Offset = "0x8A9C670", VA = "0x188A9D270")]
			internal object SXOLDOBFGKK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class SZUHMLSZTAU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public long WQEBBPDCIAB;

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public SZUHMLSZTAU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x8AA50D0", Offset = "0x8AA44D0", VA = "0x188AA50D0")]
			internal void MZYXQXMYTST()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class ATETVWYMNCQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public RoomInstance EYLHAJXPJWE;

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ATETVWYMNCQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8A99650", Offset = "0x8A98A50", VA = "0x188A99650")]
			internal object QHCDIABORUU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class GJQKSOZPCID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public RoomInstance EYLHAJXPJWE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public Task LBSXLSDLSLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public Task DJRMNYNPLLG;

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public GJQKSOZPCID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x8A9B6B0", Offset = "0x8A9AAB0", VA = "0x188A9B6B0")]
			internal string IJEUBVYGHSY()
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
			private TaskAwaiter<WIIGEWEAFFO> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x8AA7220", Offset = "0x8AA6620", VA = "0x188AA7220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x8AA7990", Offset = "0x8AA6D90", VA = "0x188AA7990", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public Matchmaking.ServerConnectionInfoDTO serverConnectionInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public UMTYTQWPZHG joinRoomInstancePauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public CancellationToken roomCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private TaskAwaiter<CZRWPLOLQQH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x8AA83E0", Offset = "0x8AA77E0", VA = "0x188AA83E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8AA8AD0", Offset = "0x8AA7ED0", VA = "0x188AA8AD0", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public QPEPMFBJVFS customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public UMTYTQWPZHG joinRoomInstancePauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			private IIZHUEQDZCJ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private BZOAUXCEPQY <multiProgressTracker>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			private IDisposable <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			private StackTimer<string>.UBFOGWXCCTH <connectToRoomAndRunLoadLogicTimer>5__5;

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
			private QXWZURHKUNH <preOperationProgressTracker>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private Task<Matchmaking.ServerConnectionInfoDTO> <serverConnectionInfoTask>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private TGFKVJKQJJJ <>7__wrap10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private CancellationTokenSource <cameraFadeCts>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap12;

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
			[Cpp2IlInjected.Address(RVA = "0x8AA8B30", Offset = "0x8AA7F30", VA = "0x188AA8B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x8AAE530", Offset = "0x8AAD930", VA = "0x188AAE530", Slot = "5")]
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
			private XRSJVGYQFTW <roomContainer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x8AC2230", Offset = "0x8AC1630", VA = "0x188AC2230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x8AC26C0", Offset = "0x8AC1AC0", VA = "0x188AC26C0", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public QPEPMFBJVFS customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public UMTYTQWPZHG joinRoomInstancePauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			private BZOAUXCEPQY <multiProgressTracker>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private IDisposable <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			private StackTimer<string>.UBFOGWXCCTH <connectToRoomAndRunLoadLogicTimer>5__5;

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
			private QXWZURHKUNH <preOperationProgressTracker>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			private Task<Matchmaking.ServerConnectionInfoDTO> <serverConnectionInfoTask>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			private RoomLoadRequestPayload <initialRoomLoadPayload>5__11;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			private DBSTIRSNXRY <preloadContext>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			private TaskAwaiter<RoomLoadRequestPayload> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			private TGFKVJKQJJJ <>7__wrap12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			private Task <loadEmptySceneTask>5__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			private TYIAYRIVJNN <sceneManagementService>5__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private BMOYDOHYHMN <scenePreloadRequest>5__16;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			private CancellationTokenSource <cameraFadeCts>5__17;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap17;

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
			[Cpp2IlInjected.Address(RVA = "0x8AC2720", Offset = "0x8AC1B20", VA = "0x188AC2720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7C30", Offset = "0x8AC7030", VA = "0x188AC7C30", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			private TaskAwaiter<Matchmaking.ServerConnectionInfoDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA500", Offset = "0x8AC9900", VA = "0x188ACA500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA9E0", Offset = "0x8AC9DE0", VA = "0x188ACA9E0", Slot = "5")]
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
			public QPEPMFBJVFS customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x8ACAA50", Offset = "0x8AC9E50", VA = "0x188ACAA50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x8ACB000", Offset = "0x8ACA400", VA = "0x188ACB000", Slot = "5")]
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
			private NIUIYVRLMAK <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x8ACB060", Offset = "0x8ACA460", VA = "0x188ACB060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8ACBBD0", Offset = "0x8ACAFD0", VA = "0x188ACBBD0", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public UMTYTQWPZHG joinRoomInstanceToken;

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
			public DBSTIRSNXRY preloadContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public BZOAUXCEPQY progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			private StackTimer<string>.UBFOGWXCCTH <roomLoadLogicTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8AD2270", Offset = "0x8AD1670", VA = "0x188AD2270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8AD2A60", Offset = "0x8AD1E60", VA = "0x188AD2A60", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private StackTimer<string>.UBFOGWXCCTH <spawnLocalPlayerTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			private LogRangeScope <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap3;

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
			[Cpp2IlInjected.Address(RVA = "0x8AD2AC0", Offset = "0x8AD1EC0", VA = "0x188AD2AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8AD42A0", Offset = "0x8AD36A0", VA = "0x188AD42A0", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private StackTimer<string>.UBFOGWXCCTH <disconnectTimerScope>5__3;

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
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap5;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x8AD4B90", Offset = "0x8AD3F90", VA = "0x188AD4B90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x8AD5600", Offset = "0x8AD4A00", VA = "0x188AD5600", Slot = "5")]
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
			public QPEPMFBJVFS customRoomLoadPayload;

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
			private UMTYTQWPZHG <joinRoomInstancePauseToken>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			private HEERFGNWXTM <analyticsData>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x8AD6610", Offset = "0x8AD5A10", VA = "0x188AD6610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x8AD7470", Offset = "0x8AD6870", VA = "0x188AD7470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly Log TGZIVAMQVPR;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly Log FFHGXMICQLP;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly Log RHNHMGMOJLX;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly string HHQSGQBGIRW;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly string TPYGNQFKUUY;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly string ISDQGFUCQWP;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly Guid YYPOAVRRYOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private SJYCKVQRDLU PHGJRPPYMWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private UYGOTJQHPYH KEBAJGXONIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private HFLLGBMWIHF UGOVYLDDXNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private MVWEOVUCDOM ITQPEIGRZZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private MVZYDDMAODN GTVBHFZJJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private XJYONDZRBRO YLFOUCVYAQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private AEOKRKYITOK XTHUHXRMJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private WDIEJYQAOTC UGHAPRNKCGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private OPLTLPPSEIP NFNMUGTIVAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private MXQCDMJQSQQ ILTABSXOBXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private IDisposable ZDNGFRKVWFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private WTLPGQTVEHV KVFABPMNZTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private readonly Token JMWNVNJXSTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TGFKVJKQJJJ CMCJWSJYEMS;

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public TaskStatus LZSOVBBOCYI
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xF76410", Offset = "0xF75810", VA = "0x180F76410", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TaskStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x15292A0", Offset = "0x15286A0", VA = "0x1815292A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private INKPZSVDXUP KYYXCPGOJZA
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x8AA1A40", Offset = "0x8AA0E40", VA = "0x188AA1A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8AA1300", Offset = "0x8AA0700", VA = "0x188AA1300", Slot = "6")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8AA0AB0", Offset = "0x8A9FEB0", VA = "0x188AA0AB0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x8AA1680", Offset = "0x8AA0A80", VA = "0x188AA1680", Slot = "5")]
		[AsyncStateMachine(typeof(<JoinRoomInstance>d__30))]
		public Task JoinRoomInstance(RoomInstance targetInstance, QPEPMFBJVFS customRoomLoadPayload, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8AA17C0", Offset = "0x8AA0BC0", VA = "0x188AA17C0")]
		[AsyncStateMachine(typeof(<TryJoinRoomInstance>d__31))]
		private Task KNKBTHKWELN(RoomInstance a, QPEPMFBJVFS b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8AA28F0", Offset = "0x8AA1CF0", VA = "0x188AA28F0")]
		private void VCMUSXCTEEZ(OPLTLPPSEIP a, RoomInstance b, Exception c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8AA30F0", Offset = "0x8AA24F0", VA = "0x188AA30F0")]
		private static void XJKBKXBHPZT(HEERFGNWXTM a, Exception b, [Optional] List<int> c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8AA03B0", Offset = "0x8A9F7B0", VA = "0x188AA03B0")]
		[AsyncStateMachine(typeof(<ConnectToRoomAndRunLoadLogic>d__34))]
		private Task ConnectToRoomAndRunLoadLogic(StackTimer<string>.UBFOGWXCCTH timer, RoomInstance targetInstance, QPEPMFBJVFS customRoomLoadPayload, UMTYTQWPZHG joinRoomInstancePauseToken, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8AA1040", Offset = "0x8AA0440", VA = "0x188AA1040")]
		[AsyncStateMachine(typeof(<FastPath_ConnectToRoomAndRunLoadLogic>d__35))]
		private Task FastPath_ConnectToRoomAndRunLoadLogic(StackTimer<string>.UBFOGWXCCTH timer, RoomInstance targetInstance, QPEPMFBJVFS customRoomLoadPayload, UMTYTQWPZHG joinRoomInstancePauseToken, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8AA0930", Offset = "0x8A9FD30", VA = "0x188AA0930")]
		private void DQTPWLPAXFT([CallerMemberName] string caller = "<unknown>")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8AA1910", Offset = "0x8AA0D10", VA = "0x188AA1910")]
		[AsyncStateMachine(typeof(<TryDisconnectFromCurrentRoomInstance>d__37))]
		private Task LUXDXXTQQQO(StackTimer<string>.UBFOGWXCCTH a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x8AA0510", Offset = "0x8A9F910", VA = "0x188AA0510")]
		private void DCZDMYROROA(RoomInstance a, CancellationToken b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8AA2E90", Offset = "0x8AA2290", VA = "0x188AA2E90")]
		private void WKWPOOXCXDE(RoomInstance a, TaskStatus b, string c, UMTYTQWPZHG d, Exception e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8AA21D0", Offset = "0x8AA15D0", VA = "0x188AA21D0")]
		private void POEQPWPFGGL(RoomInstance a, UMTYTQWPZHG b, OperationCanceledException c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8AA0FC0", Offset = "0x8AA03C0", VA = "0x188AA0FC0")]
		private void FRBNMJULUFH(RoomInstance a, UMTYTQWPZHG b, Exception c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8AA0DB0", Offset = "0x8AA01B0", VA = "0x188AA0DB0")]
		private void FDODBCVJOLJ(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8AA1FB0", Offset = "0x8AA13B0", VA = "0x188AA1FB0")]
		private static RoomEvent ORBSHCMRGOH(RoomInstance a)
		{
			return default(RoomEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8AA0CE0", Offset = "0x8AA00E0", VA = "0x188AA0CE0")]
		[AsyncStateMachine(typeof(<CreateRoomDiContainer>d__44))]
		private Task ELEDJRYACFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8AA11A0", Offset = "0x8AA05A0", VA = "0x188AA11A0")]
		[AsyncStateMachine(typeof(<GetServerConnectionInfo>d__45))]
		private Task<Matchmaking.ServerConnectionInfoDTO> GetServerConnectionInfo(RoomInstance targetInstance, StackTimer<string>.UBFOGWXCCTH timer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8AA22B0", Offset = "0x8AA16B0", VA = "0x188AA22B0")]
		private static CZRWPLOLQQH RVOONKYDHRV(Matchmaking.ServerConnectionInfoDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8AA27A0", Offset = "0x8AA1BA0", VA = "0x188AA27A0")]
		[AsyncStateMachine(typeof(<ConnectToPhoton>d__47))]
		private Task UFNHHFZFAYP(Matchmaking.ServerConnectionInfoDTO a, UMTYTQWPZHG b, StackTimer<string>.UBFOGWXCCTH c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8AA2D50", Offset = "0x8AA2150", VA = "0x188AA2D50")]
		[AsyncStateMachine(typeof(<JoinRoomLoadWithPhoton>d__48))]
		private Task VKXQCTWAFAX(RoomInstance a, CancellationTokenSource b, Task c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x8AA23C0", Offset = "0x8AA17C0", VA = "0x188AA23C0")]
		[AsyncStateMachine(typeof(<RunRoomLoadLogic>d__49))]
		private Task RunRoomLoadLogic(RoomLoadRequestPayload initialRoomLoadPayload, BZOAUXCEPQY progressTracker, RoomInstance targetRoomInstance, UMTYTQWPZHG joinRoomInstanceToken, StackTimer<string>.UBFOGWXCCTH timer, CancellationToken roomJoinCancellationToken, [Optional] DBSTIRSNXRY preloadContext)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8AA0B00", Offset = "0x8A9FF00", VA = "0x188AA0B00")]
		private UMTYTQWPZHG EKQQSHUUVZE(UMTYTQWPZHG a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8AA2540", Offset = "0x8AA1940", VA = "0x188AA2540")]
		[AsyncStateMachine(typeof(<SpawnLocalPlayer>d__51))]
		private Task SpawnLocalPlayer(StackTimer<string>.UBFOGWXCCTH timer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8AA2010", Offset = "0x8AA1410", VA = "0x188AA2010")]
		[AsyncStateMachine(typeof(<CheckForRoomDataOutOfDate>d__52))]
		private Task PANCMKJLRPJ(CancellationToken a, int b, AccountRoleType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8AA39F0", Offset = "0x8AA2DF0", VA = "0x188AA39F0")]
		private static void YPFBKQWWTHY(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8AA1D90", Offset = "0x8AA1190", VA = "0x188AA1D90")]
		private void ODGCDNBWPWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8AA2710", Offset = "0x8AA1B10", VA = "0x188AA2710")]
		private void TRBNHPCVZDQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8AA2680", Offset = "0x8AA1A80", VA = "0x188AA2680")]
		private void TQEWOUMTSDR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8AA2140", Offset = "0x8AA1540", VA = "0x188AA2140")]
		private void PFJXOPUHXDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8AA3910", Offset = "0x8AA2D10", VA = "0x188AA3910")]
		private static void XTTSKIYEJKE(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8AA1C90", Offset = "0x8AA1090", VA = "0x188AA1C90")]
		private static CancellationTokenRegistration NHMPOKSUMKT(RoomInstance a, CancellationToken b)
		{
			return default(CancellationTokenRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8AA0840", Offset = "0x8A9FC40", VA = "0x188AA0840")]
		private static void DHCIYYJIHSS(RoomInstance a, Exception b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8AA1AF0", Offset = "0x8AA0EF0", VA = "0x188AA1AF0")]
		private void MNCHUJJBCBA(RoomInstance a, Task b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8AA1A90", Offset = "0x8AA0E90", VA = "0x188AA1A90")]
		private static void Log(Func<string> msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x8AA3D50", Offset = "0x8AA3150", VA = "0x188AA3D50")]
		public RoomManagerInitialRoomLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8AA2250", Offset = "0x8AA1650", VA = "0x188AA2250")]
		[CompilerGenerated]
		internal static (int, int?) QFQJJSMVSTX(ErrorCode a)
		{
			return default((int, int?));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerInRoomTasks : NTXWNCDUYQJ, VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class MTCDKCMSKAV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public RoomManagerInRoomTasks MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			public int CMJHZFQDWUH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000238")]
			public AccountRoleType BWJOTNATSOH;

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public MTCDKCMSKAV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA270", Offset = "0x8AB9670", VA = "0x188ABA270")]
			internal List<Task> KBKIPTOONUU(CancellationToken a)
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
			[Cpp2IlInjected.Address(RVA = "0x8AD01F0", Offset = "0x8ACF5F0", VA = "0x188AD01F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x8AD06C0", Offset = "0x8ACFAC0", VA = "0x188AD06C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD7910", Offset = "0x8AD6D10", VA = "0x188AD7910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x8AD7CB0", Offset = "0x8AD70B0", VA = "0x188AD7CB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD7D10", Offset = "0x8AD7110", VA = "0x188AD7D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x8AD7FF0", Offset = "0x8AD73F0", VA = "0x188AD7FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private readonly HashSet<InLoadedRoomTaskBuilder> ORGLBDNXJRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private UYGOTJQHPYH KEBAJGXONIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private MVWEOVUCDOM ITQPEIGRZZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private KEDJVRQIRCF RWKRYWAXMUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskRunner NDGYXNQNDAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private IDisposable ZDNGFRKVWFZ;

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8ABAF30", Offset = "0x8ABA330", VA = "0x188ABAF30", Slot = "5")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8ABACB0", Offset = "0x8ABA0B0", VA = "0x188ABACB0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB2F0", Offset = "0x8ABA6F0", VA = "0x188ABB2F0", Slot = "4")]
		public bool PLWLDLMCTNT(InLoadedRoomTaskBuilder a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB470", Offset = "0x8ABA870", VA = "0x188ABB470")]
		private void WKHLNXVKGTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8ABAD10", Offset = "0x8ABA110", VA = "0x188ABAD10")]
		private void GZAUYFIXDAY(IWGQTFVVOBJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB200", Offset = "0x8ABA600", VA = "0x188ABB200")]
		[AsyncStateMachine(typeof(<RunInRoomTaskAsync>d__15))]
		private Task LCNITEMBFKS(int a, AccountRoleType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB610", Offset = "0x8ABAA10", VA = "0x188ABB610")]
		private Func<CancellationToken, List<Task>> YUTHPZBJQKW(int a, AccountRoleType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8ABA7A0", Offset = "0x8AB9BA0", VA = "0x188ABA7A0")]
		private List<Task> DFLPSDQFKBE(int a, AccountRoleType b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB350", Offset = "0x8ABA750", VA = "0x188ABB350")]
		[AsyncStateMachine(typeof(<WaitAndLog>d__18))]
		private Task QWJXEOLJAGC(InLoadedRoomTaskBuilder a, CancellationToken b, int c, AccountRoleType d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB540", Offset = "0x8ABA940", VA = "0x188ABB540")]
		[AsyncStateMachine(typeof(<WaitForPhotonAndCancel>d__19))]
		private Task XRTLPHINSZN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABA720", Offset = "0x8AB9B20", VA = "0x188ABA720")]
		private void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB6E0", Offset = "0x8ABAAE0", VA = "0x188ABB6E0")]
		public RoomManagerInRoomTasks()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerPendingRequests : XQTTFYUWSSS, VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class OBPSGXVZRRC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			public Guid ZKWAGILEUSK;

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OBPSGXVZRRC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA470", Offset = "0x8AB9870", VA = "0x188ABA470")]
			internal object IGQXJWULLUJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[CompilerGenerated]
		private sealed class AZSYQXSOVDR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400024E")]
			public Guid ZKWAGILEUSK;

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public AZSYQXSOVDR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8AB9E50", Offset = "0x8AB9250", VA = "0x188AB9E50")]
			internal object NXSZIMRPNQM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class EOXEHAWLLLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EOXEHAWLLLA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class ACTEAKJALWV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			public Guid ZKWAGILEUSK;

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ACTEAKJALWV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x8AB9C00", Offset = "0x8AB9000", VA = "0x188AB9C00")]
			internal object APLHLCJLIEO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class YYSAOGCWSFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			public Guid ZKWAGILEUSK;

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public YYSAOGCWSFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8560", Offset = "0x8AD7960", VA = "0x188AD8560")]
			internal object AYWAQURASVO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly Dictionary<Guid, PendingRequestData> YTGDZKVLLBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private readonly TimeSpan TMCOQLHSDUK;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "9")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8ABBBA0", Offset = "0x8ABAFA0", VA = "0x188ABBBA0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB760", Offset = "0x8ABAB60", VA = "0x188ABB760", Slot = "4")]
		public PendingRequest Add(Guid operationId)
		{
			return default(PendingRequest);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC120", Offset = "0x8ABB520", VA = "0x188ABC120", Slot = "5")]
		public bool Remove(Guid operationId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8ABBC20", Offset = "0x8ABB020", VA = "0x188ABBC20", Slot = "6")]
		public bool ISTHBRMLTIY(Guid a, Task b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8ABBF50", Offset = "0x8ABB350", VA = "0x188ABBF50", Slot = "7")]
		public bool KSEWLXKLPBM(Guid a, WIIGEWEAFFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABBBB0", Offset = "0x8ABAFB0", VA = "0x188ABBBB0", Slot = "8")]
		public Task<(WIIGEWEAFFO, Task)> GXLXDRMMKOD(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB970", Offset = "0x8ABAD70", VA = "0x188ABB970")]
		private void CBWPBIHNOGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC320", Offset = "0x8ABB720", VA = "0x188ABC320")]
		public RoomManagerPendingRequests()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerPresenceUpdates : JBTMEWGPJAK, VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		private class VNPBMOTNEAI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			private readonly RoomInstance RQDIZXOPCXS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			private readonly CancellationTokenSource QXPJXJNSDID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			public readonly CancellationToken SPHJVOAGGSP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			private bool XNDBXSIYVIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			private bool HLFKHWGNBJD;

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8AD84C0", Offset = "0x8AD78C0", VA = "0x188AD84C0")]
			public VNPBMOTNEAI(RoomInstance a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8350", Offset = "0x8AD7750", VA = "0x188AD8350")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8490", Offset = "0x8AD7890", VA = "0x188AD8490", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class EMQMBTNNLSE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public DisconnectCause JONIXJBSWZZ;

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EMQMBTNNLSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x8AB9EB0", Offset = "0x8AB92B0", VA = "0x188AB9EB0")]
			internal object LDPBYILKQMI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class LQYXHZVGSGW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			public int CVEANGSMIFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			public RoomManagerPresenceUpdates MXVWDMPVVWS;

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public LQYXHZVGSGW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA0F0", Offset = "0x8AB94F0", VA = "0x188ABA0F0")]
			internal object ZYXGPVKRLOY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class LREEFGPEBSF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026A")]
			public RoomInstance RQDIZXOPCXS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400026B")]
			public LQYXHZVGSGW AAFJFKGKTGT;

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public LREEFGPEBSF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA150", Offset = "0x8AB9550", VA = "0x188ABA150")]
			internal object ZZNBHPSJNWZ((RoomInstance lastLocalPlayerRoomInstance, RoomInstance newRoomInstance, XJYONDZRBRO fallbacks) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class ZAAHAHXLLXD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026C")]
			public RoomInstance RQDIZXOPCXS;

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ZAAHAHXLLXD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x8AD86B0", Offset = "0x8AD7AB0", VA = "0x188AD86B0")]
			internal object HPIFVDNAAAH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8630", Offset = "0x8AD7A30", VA = "0x188AD8630")]
			internal void HPCYXWTCQOY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8790", Offset = "0x8AD7B90", VA = "0x188AD8790")]
			internal object HPSTPRAUSWZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8750", Offset = "0x8AD7B50", VA = "0x188AD8750")]
			internal object HPNMSKGXJLQ()
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
			[Cpp2IlInjected.Address(RVA = "0x8ACCEB0", Offset = "0x8ACC2B0", VA = "0x188ACCEB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x8ACD2F0", Offset = "0x8ACC6F0", VA = "0x188ACD2F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8ACD350", Offset = "0x8ACC750", VA = "0x188ACD350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xB02E70", Offset = "0xB02270", VA = "0x180B02E70", Slot = "5")]
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
			public QPEPMFBJVFS customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000281")]
			private ZAAHAHXLLXD <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x8AD5660", Offset = "0x8AD4A60", VA = "0x188AD5660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x8AD65B0", Offset = "0x8AD59B0", VA = "0x188AD65B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private static readonly YZFTJIOIWCE.WYGCVRGPHVO AMNHSUKFTRB;

		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private static readonly LogFlags OPPGRFPSEHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private UYGOTJQHPYH KEBAJGXONIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private MVWEOVUCDOM ITQPEIGRZZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private XJYONDZRBRO YLFOUCVYAQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private MVZYDDMAODN GTVBHFZJJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private PIYWXEEYHLZ FLZKNZEKBWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private CFVVXENXKIU IZTOKUPUXXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private RoomInstance ZGHGEYDOHZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private VNPBMOTNEAI ZLWSZEWLDLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private bool GBYLRJBPABT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private Task SOWEQZYYYGL;

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private INKPZSVDXUP KYYXCPGOJZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x8ABCF50", Offset = "0x8ABC350", VA = "0x188ABCF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public bool OJVVCHUCAVD
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xB175E0", Offset = "0xB169E0", VA = "0x180B175E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x8ABCFA0", Offset = "0x8ABC3A0", VA = "0x188ABCFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCB70", Offset = "0x8ABBF70", VA = "0x188ABCB70", Slot = "4")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC630", Offset = "0x8ABBA30", VA = "0x188ABC630", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC540", Offset = "0x8ABB940", VA = "0x188ABC540")]
		[AsyncStateMachine(typeof(<OnDisconnectedFromPhotonWhileConnected>d__20))]
		private Task CLLQCBGWXWK(DisconnectCause a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD1A0", Offset = "0x8ABC5A0", VA = "0x188ABD1A0")]
		private void XAYWHQGTCUR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD020", Offset = "0x8ABC420", VA = "0x188ABD020")]
		private void RSFOTZEXUPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC3D0", Offset = "0x8ABB7D0", VA = "0x188ABC3D0")]
		private void APLBDEEYWTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCFB0", Offset = "0x8ABC3B0", VA = "0x188ABCFB0")]
		private bool QXEPJOKIAHF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC7C0", Offset = "0x8ABBBC0", VA = "0x188ABC7C0")]
		[AsyncStateMachine(typeof(<OnPlayerPresenceUpdated>d__26))]
		private void FDCMPLYFMTE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8ABC890", Offset = "0x8ABBC90", VA = "0x188ABC890")]
		private void FMNYZSQAZMZ([Out] IDisposable a, [Out] IDisposable b, [Out] IDisposable c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD330", Offset = "0x8ABC730", VA = "0x188ABD330")]
		private bool XLUPMHRYFIV(RoomInstance a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCB20", Offset = "0x8ABBF20", VA = "0x188ABCB20")]
		private void IAYRQMXZLTD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8ABCE20", Offset = "0x8ABC220", VA = "0x188ABCE20")]
		[AsyncStateMachine(typeof(<TryJoinRoomInstance>d__30))]
		private Task KNKBTHKWELN(RoomInstance a, QPEPMFBJVFS b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD7C0", Offset = "0x8ABCBC0", VA = "0x188ABD7C0")]
		public RoomManagerPresenceUpdates()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerReceiveOperation : MJXMMBCQHCL, VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class MWLHREALRTF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400028D")]
			public PKIHHHDXEKZ YUUEPJAABNV;

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public MWLHREALRTF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA410", Offset = "0x8AB9810", VA = "0x188ABA410")]
			internal object XHXOPONVWFY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		[CompilerGenerated]
		private sealed class RPXDXIRZXRW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400028E")]
			public PKIHHHDXEKZ TTZFEWZQVQP;

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public RPXDXIRZXRW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA6C0", Offset = "0x8AB9AC0", VA = "0x188ABA6C0")]
			internal object PDQHWXJZXAJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class LSZAKIEDSNH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400028F")]
			public PKIHHHDXEKZ EDKPEATCGMI;

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public LSZAKIEDSNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA210", Offset = "0x8AB9610", VA = "0x188ABA210")]
			internal object MAUDMPISWMY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		[CompilerGenerated]
		private sealed class GZSIQPWDSFW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000290")]
			public YHYCZYSLLNF VOVOMEUEDRN;

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public GZSIQPWDSFW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA070", Offset = "0x8AB9470", VA = "0x188ABA070")]
			internal object KWLBVXQKNGW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		[CompilerGenerated]
		private sealed class MTCDKCMSKAV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000291")]
			public PKIHHHDXEKZ TTZFEWZQVQP;

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public MTCDKCMSKAV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA2B0", Offset = "0x8AB96B0", VA = "0x188ABA2B0")]
			internal object KIYTHMXTBIC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		[CompilerGenerated]
		private sealed class OKOPEPOQFBZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000292")]
			public PKIHHHDXEKZ TTZFEWZQVQP;

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OKOPEPOQFBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA660", Offset = "0x8AB9A60", VA = "0x188ABA660")]
			internal object AQUPFPAIVST()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class UMOAHPPLSQX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			public PKIHHHDXEKZ IOJYWEHVRDT;

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public UMOAHPPLSQX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x8AD82F0", Offset = "0x8AD76F0", VA = "0x188AD82F0")]
			internal object XRQKVJLPEUN()
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
			public YHYCZYSLLNF operation;

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
			[Cpp2IlInjected.Address(RVA = "0x8AD1BF0", Offset = "0x8AD0FF0", VA = "0x188AD1BF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x8AD2210", Offset = "0x8AD1610", VA = "0x188AD2210", Slot = "5")]
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
			public PKIHHHDXEKZ operationStartMessage;

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
			private UMTYTQWPZHG <pauseToken>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			private TaskAwaiter<PKIHHHDXEKZ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002A4")]
			private IDisposable <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002A5")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x8AD0720", Offset = "0x8ACFB20", VA = "0x188AD0720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x8AD1270", Offset = "0x8AD0670", VA = "0x188AD1270", Slot = "5")]
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
			public PKIHHHDXEKZ request;

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
			private TaskAwaiter<YHYCZYSLLNF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x8AD12D0", Offset = "0x8AD06D0", VA = "0x188AD12D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x8AD1B90", Offset = "0x8AD0F90", VA = "0x188AD1B90", Slot = "5")]
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
			public AsyncTaskMethodBuilder<YHYCZYSLLNF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public RoomManagerReceiveOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			public PKIHHHDXEKZ request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			private CAHHKPDUQCB.LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			private UMTYTQWPZHG <pauseToken>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			private TaskAwaiter<PKIHHHDXEKZ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x8AD4300", Offset = "0x8AD3700", VA = "0x188AD4300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x8AD4830", Offset = "0x8AD3C30", VA = "0x188AD4830", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD48A0", Offset = "0x8AD3CA0", VA = "0x188AD48A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x8AD4B20", Offset = "0x8AD3F20", VA = "0x188AD4B20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private MVWEOVUCDOM ITQPEIGRZZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private AEOKRKYITOK XTHUHXRMJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private CWKKMCQNDCO FSGPKNWBZIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private NPDGWTKDDKX RNLTQXVEFEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private HFLLGBMWIHF UGOVYLDDXNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskCompletionSource<RoomOperationType> VXFTFRGKMDS;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE190", Offset = "0x8ABD590", VA = "0x188ABE190", Slot = "7")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8ABEA10", Offset = "0x8ABDE10", VA = "0x188ABEA10", Slot = "6")]
		[AsyncStateMachine(typeof(<ThrowOnRequestTask>d__8))]
		public Task<RoomOperationType> YUMYLFIEUQN(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE6B0", Offset = "0x8ABDAB0", VA = "0x188ABE6B0", Slot = "4")]
		public void TPNDPLFASVL(PKIHHHDXEKZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x8ABDE60", Offset = "0x8ABD260", VA = "0x188ABDE60", Slot = "5")]
		public void GBPOSLPQRDG(PKIHHHDXEKZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE3A0", Offset = "0x8ABD7A0", VA = "0x188ABE3A0")]
		[AsyncStateMachine(typeof(<RunOperationFromRequest>d__11))]
		private Task NFGBDPHLJQJ(PKIHHHDXEKZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8ABDD50", Offset = "0x8ABD150", VA = "0x188ABDD50")]
		[AsyncStateMachine(typeof(<RunOperationFromMaster>d__12))]
		private Task FZUMUXRNSXU(PKIHHHDXEKZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD830", Offset = "0x8ABCC30", VA = "0x188ABD830")]
		[AsyncStateMachine(typeof(<SyncAndCreateOperation>d__13))]
		private Task<YHYCZYSLLNF> CPRQGBIDWZV(PKIHHHDXEKZ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x8ABD980", Offset = "0x8ABCD80", VA = "0x188ABD980")]
		private UMTYTQWPZHG CYSOEZDSUGY(PKIHHHDXEKZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE280", Offset = "0x8ABD680", VA = "0x188ABE280")]
		[AsyncStateMachine(typeof(<RunOperation>d__15))]
		private Task KJUYJGCFJTK(YHYCZYSLLNF a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE4B0", Offset = "0x8ABD8B0", VA = "0x188ABE4B0")]
		private YHYCZYSLLNF TJJGHFZYNRO(PKIHHHDXEKZ a, UMTYTQWPZHG b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x3A4D340", Offset = "0x3A4C740", VA = "0x183A4D340")]
		private a ECMRBAICHCW<a>(a a) where a : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABDA00", Offset = "0x8ABCE00", VA = "0x188ABDA00")]
		private YHYCZYSLLNF DPISSURCBMT(PKIHHHDXEKZ a, UMTYTQWPZHG b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomManagerReceiveOperation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerRequestHandler : CWKKMCQNDCO, VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		[CompilerGenerated]
		private sealed class GWDZXBYWEWG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			public byte XGFTMUFORNR;

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public GWDZXBYWEWG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA010", Offset = "0x8AB9410", VA = "0x188ABA010")]
			internal object FHOTNCMOMPC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		[CompilerGenerated]
		private sealed class YYSAOGCWSFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			public Guid ZKWAGILEUSK;

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public YYSAOGCWSFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x8AD85C0", Offset = "0x8AD79C0", VA = "0x188AD85C0")]
			internal object WFNFWLIOGNH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private HFLLGBMWIHF UGOVYLDDXNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private CJGHBXBZXEK DSMHCUXTNQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private MJXMMBCQHCL LCLJETCYNTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private XQTTFYUWSSS YTGDZKVLLBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private NIIEZGNLYUY LYZKTNMYWLX;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF090", Offset = "0x8ABE490", VA = "0x188ABF090", Slot = "6")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8ABEE20", Offset = "0x8ABE220", VA = "0x188ABEE20", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFE00", Offset = "0x8ABF200", VA = "0x188ABFE00", Slot = "4")]
		public PendingRequest SVQKAVHZAQC(PKIHHHDXEKZ a)
		{
			return default(PendingRequest);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF200", Offset = "0x8ABE600", VA = "0x188ABF200", Slot = "5")]
		public void POCTRIIUIHT(Guid a, Task b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABED10", Offset = "0x8ABE110", VA = "0x188ABED10")]
		private void BXOWQNFUJBT(PTKTLSUVJWP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF8A0", Offset = "0x8ABECA0", VA = "0x188ABF8A0")]
		private void RBGCEVGAKHO(OperationEventData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF400", Offset = "0x8ABE800", VA = "0x188ABF400")]
		private void QGNRAXCQZZC(OperationEventData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0420", Offset = "0x8ABF820", VA = "0x188AC0420")]
		private void XRYLLDLMKMB(OperationEventData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x8AC01F0", Offset = "0x8ABF5F0", VA = "0x188AC01F0")]
		private WIIGEWEAFFO XCHYQTVJKCM(PKIHHHDXEKZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x8ABEB20", Offset = "0x8ABDF20", VA = "0x188ABEB20")]
		private void BWLHVACIEAM(PKIHHHDXEKZ a, WIIGEWEAFFO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8ABEEC0", Offset = "0x8ABE2C0", VA = "0x188ABEEC0")]
		private bool EDEIURVZMOL(PKIHHHDXEKZ a, WIIGEWEAFFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0650", Offset = "0x8ABFA50", VA = "0x188AC0650")]
		private bool YQSSLGGLVSH(PKIHHHDXEKZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF660", Offset = "0x8ABEA60", VA = "0x188ABF660")]
		private bool QOBBGCSFKMS(byte a, ExitGames.Client.Photon.Hashtable b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomManagerRequestHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerRequestOperation : BSMMJIHFQGX, VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		[CompilerGenerated]
		private sealed class OBPSGXVZRRC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D0")]
			public RoomOperationType GEDFPVPRFSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002D1")]
			public RoomManagerRequestOperation MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			public PKIHHHDXEKZ RRASYAVFNCV;

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OBPSGXVZRRC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA5F0", Offset = "0x8AB99F0", VA = "0x188ABA5F0")]
			internal object LGABNTWGGAR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA4D0", Offset = "0x8AB98D0", VA = "0x188ABA4D0")]
			internal object LFUUQNCIWPI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		[CompilerGenerated]
		private sealed class EOXEHAWLLLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			public RoomOperationType GEDFPVPRFSL;

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EOXEHAWLLLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x8AB9F40", Offset = "0x8AB9340", VA = "0x188AB9F40")]
			internal object AVYZQKPKDTI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private sealed class ACTEAKJALWV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public PKIHHHDXEKZ TTZFEWZQVQP;

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ACTEAKJALWV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x8AB9DE0", Offset = "0x8AB91E0", VA = "0x188AB9DE0")]
			internal object VLNUHDNJGCF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x8AB9D70", Offset = "0x8AB9170", VA = "0x188AB9D70")]
			internal object VLINJWTLWQW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x8AB9D00", Offset = "0x8AB9100", VA = "0x188AB9D00")]
			internal object VLDGMPZONFN()
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
			public AsyncTaskMethodBuilder<WIIGEWEAFFO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			public RoomManagerRequestOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			public PKIHHHDXEKZ roomOperationMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			private TaskAwaiter<WIIGEWEAFFO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x8ACF0D0", Offset = "0x8ACE4D0", VA = "0x188ACF0D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x8ACF750", Offset = "0x8ACEB50", VA = "0x188ACF750", Slot = "5")]
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
			public AsyncTaskMethodBuilder<WIIGEWEAFFO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public PKIHHHDXEKZ request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			public RoomManagerRequestOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			private ACTEAKJALWV <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private PendingRequest <pendingRequest>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			private WIIGEWEAFFO <result>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			private TaskAwaiter<(WIIGEWEAFFO validationResult, Task operation)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x8ACF7C0", Offset = "0x8ACEBC0", VA = "0x188ACF7C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x8AD0180", Offset = "0x8ACF580", VA = "0x188AD0180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private HFLLGBMWIHF UGOVYLDDXNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private CJGHBXBZXEK DSMHCUXTNQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private CWKKMCQNDCO FSGPKNWBZIJ;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0B70", Offset = "0x8ABFF70", VA = "0x188AC0B70", Slot = "5")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0C20", Offset = "0x8AC0020", VA = "0x188AC0C20", Slot = "4")]
		[AsyncStateMachine(typeof(<RecRoom-RoomLoading-IRoomManagerRequestOperation-RequestOperation>d__4))]
		private Task<WIIGEWEAFFO> YBOQGPFAXIF(PKIHHHDXEKZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0990", Offset = "0x8ABFD90", VA = "0x188AC0990")]
		private bool BMWNXMDPHRS(RoomOperationType a, [Out] WIIGEWEAFFO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0850", Offset = "0x8ABFC50", VA = "0x188AC0850")]
		[AsyncStateMachine(typeof(<RequestOperationInternal>d__7))]
		private Task<WIIGEWEAFFO> BIVMKHTZCBX(PKIHHHDXEKZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomManagerRequestOperation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal sealed class RoomManagerRoomLoadRequest : FNMSXOSALFV, VRXVJDMHIYE, IDisposable
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
		private sealed class MWLHREALRTF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public Stopwatch RJSDAGCEJDO;

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public MWLHREALRTF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA310", Offset = "0x8AB9710", VA = "0x188ABA310")]
			internal object AZZHZOIKTYT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		[CompilerGenerated]
		private sealed class ACTEAKJALWV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public Stopwatch RJSDAGCEJDO;

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ACTEAKJALWV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x8AB9C60", Offset = "0x8AB9060", VA = "0x188AB9C60")]
			internal object CABGBQBJSNH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C4")]
		[CompilerGenerated]
		private sealed class UMOAHPPLSQX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public long BXBUBHISUKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			public RoomDetailsDTO BWLKCXQNSLA;

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public UMOAHPPLSQX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x1039250", Offset = "0x1038650", VA = "0x181039250")]
			internal bool KSHIRTIAKLU(SubRoomDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8150", Offset = "0x8AD7550", VA = "0x188AD8150")]
			internal object KRMHCSGKYSK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8280", Offset = "0x8AD7680", VA = "0x188AD8280")]
			internal object KSMPPABXTXD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8210", Offset = "0x8AD7610", VA = "0x188AD8210")]
			internal object KRWUXFUFRPC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		[CompilerGenerated]
		private sealed class UMITKIVOJFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			public bool WIAKXBHJYUN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			public UMOAHPPLSQX AAFJFKGKTGT;

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public UMITKIVOJFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8050", Offset = "0x8AD7450", VA = "0x188AD8050")]
			internal object KSCBUMODBAL()
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
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

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
			private MWLHREALRTF <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			private TaskAwaiter<SubRoomDataSaveDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7C90", Offset = "0x8AC7090", VA = "0x188AC7C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x8AC8350", Offset = "0x8AC7750", VA = "0x188AC8350", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			private UMITKIVOJFO <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			private TaskAwaiter<ResolvedLoadParameters> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			private TaskAwaiter<RoomLoadDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x8AC83C0", Offset = "0x8AC77C0", VA = "0x188AC83C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x8AC92B0", Offset = "0x8AC86B0", VA = "0x188AC92B0", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

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
			private ACTEAKJALWV <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x8AC9320", Offset = "0x8AC8720", VA = "0x188AC9320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x8AC9900", Offset = "0x8AC8D00", VA = "0x188AC9900", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

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
			[Cpp2IlInjected.Address(RVA = "0x8AC9EC0", Offset = "0x8AC92C0", VA = "0x188AC9EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA490", Offset = "0x8AC9890", VA = "0x188ACA490", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			private TaskAwaiter<ResolvedLoadParameters> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x8AC9970", Offset = "0x8AC8D70", VA = "0x188AC9970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x8AC9E50", Offset = "0x8AC9250", VA = "0x188AC9E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private MVZYDDMAODN GTVBHFZJJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private PIYWXEEYHLZ FLZKNZEKBWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private GTOTEIGPFPL JPTMOBOXXVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private ZMJYUQZMWBJ WVZBBZEBBLI;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0EB0", Offset = "0x8AC02B0", VA = "0x188AC0EB0", Slot = "5")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0FA0", Offset = "0x8AC03A0", VA = "0x188AC0FA0", Slot = "4")]
		[AsyncStateMachine(typeof(<GetRoomLoadRequestPayload>d__6))]
		public Task<RoomLoadRequestPayload> LIWZMYAFZXW(StackTimer<string>.UBFOGWXCCTH a, RoomInstance b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1270", Offset = "0x8AC0670", VA = "0x188AC1270")]
		[AsyncStateMachine(typeof(<GetRoomDetails>d__7))]
		private Task<RoomDetailsDTO> VFIKOLZFHNL(RoomInstance a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8AC0D40", Offset = "0x8AC0140", VA = "0x188AC0D40")]
		[AsyncStateMachine(typeof(<GetRoomLoadRequestPayloadFromDetailsAndSubroom>d__8))]
		private Task<RoomLoadRequestPayload> DELZZGWCNUQ(RoomInstance a, RoomDetailsDTO b, long c, StackTimer<string>.UBFOGWXCCTH d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x8AC13D0", Offset = "0x8AC07D0", VA = "0x188AC13D0")]
		[AsyncStateMachine(typeof(<GetRoomDataBlobWithHashForRoomDetails>d__9))]
		private Task<ResolvedLoadParameters> WRDBFCARWUA(RoomInstance a, RoomDetailsDTO b, long c, StackTimer<string>.UBFOGWXCCTH d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1100", Offset = "0x8AC0500", VA = "0x188AC1100")]
		[AsyncStateMachine(typeof(<GetDefaultRoomDataBlobWithHashForDorms>d__10))]
		private Task<ResolvedLoadParameters> PFNDIMDSFLR(RoomInstance a, SubRoomDTO b, long c, StackTimer<string>.UBFOGWXCCTH d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomManagerRoomLoadRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerSynchronization : NPDGWTKDDKX, VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class MWLHREALRTF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public PKIHHHDXEKZ TTZFEWZQVQP;

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public MWLHREALRTF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA3B0", Offset = "0x8AB97B0", VA = "0x188ABA3B0")]
			internal object OJPFKRJAAUG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		[CompilerGenerated]
		private sealed class EOXEHAWLLLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			public PKIHHHDXEKZ TTZFEWZQVQP;

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EOXEHAWLLLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x8AB9FB0", Offset = "0x8AB93B0", VA = "0x188AB9FB0")]
			internal object YWUTEVXOJMX()
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
			public AsyncTaskMethodBuilder<PKIHHHDXEKZ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public PKIHHHDXEKZ request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public RoomManagerSynchronization <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public UMTYTQWPZHG pauseToken;

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
			private FNOJIOHIWBH <masterSwitchCancellationScope>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x8ACBC30", Offset = "0x8ACB030", VA = "0x188ACBC30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x8ACC7D0", Offset = "0x8ACBBD0", VA = "0x188ACC7D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<PKIHHHDXEKZ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public PKIHHHDXEKZ request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public RoomManagerSynchronization <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public UMTYTQWPZHG pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private TaskAwaiter<PKIHHHDXEKZ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x8ACC840", Offset = "0x8ACBC40", VA = "0x188ACC840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x8ACCE40", Offset = "0x8ACC240", VA = "0x188ACCE40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<PKIHHHDXEKZ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public RoomManagerSynchronization <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public UMTYTQWPZHG pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x8ACEA90", Offset = "0x8ACDE90", VA = "0x188ACEA90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x8ACF060", Offset = "0x8ACE460", VA = "0x188ACF060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private HFLLGBMWIHF UGOVYLDDXNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private ICXFHWXUHPB AAFFHFRHCEY;

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		private WGTOKMZHNDN WGTOKMZHNDN
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x8AC15D0", Offset = "0x8AC09D0", VA = "0x188AC15D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1540", Offset = "0x8AC0940", VA = "0x188AC1540", Slot = "8")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1730", Offset = "0x8AC0B30", VA = "0x188AC1730", Slot = "4")]
		[AsyncStateMachine(typeof(<MasterSynchronizeRequest>d__6))]
		public Task<PKIHHHDXEKZ> LZRTUADVLEL(PKIHHHDXEKZ a, UMTYTQWPZHG b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x8AC19F0", Offset = "0x8AC0DF0", VA = "0x188AC19F0", Slot = "5")]
		[AsyncStateMachine(typeof(<PopNextBufferedEvent>d__7))]
		public Task<PKIHHHDXEKZ> UUJKHAPQKEZ(CancellationToken a, UMTYTQWPZHG b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1690", Offset = "0x8AC0A90", VA = "0x188AC1690", Slot = "6")]
		public TNRXJFRDOMC KUBMAAZFKXA(YHYCZYSLLNF a, StackTimer<string>.UBFOGWXCCTH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1B40", Offset = "0x8AC0F40", VA = "0x188AC1B40", Slot = "7")]
		public TNRXJFRDOMC VVCRDJECDUN(YHYCZYSLLNF a, StackTimer<string>.UBFOGWXCCTH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1890", Offset = "0x8AC0C90", VA = "0x188AC1890")]
		[AsyncStateMachine(typeof(<MasterSyncRequestAndValidateResponse>d__10))]
		private Task<PKIHHHDXEKZ> PUDPXPSYZUQ(PKIHHHDXEKZ a, UMTYTQWPZHG b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5190", Offset = "0x3AA4590", VA = "0x183AA5190")]
		private static byte[] VYLBKJKYPBF(PKIHHHDXEKZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomManagerSynchronization()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerValidation : CJGHBXBZXEK, VRXVJDMHIYE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private DAQZLJHROXK EEFTGUILBGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private HFLLGBMWIHF UGOVYLDDXNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private AEOKRKYITOK XTHUHXRMJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private MLQYKKHTWKA VPZOCJCHMZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private MVZYDDMAODN GTVBHFZJJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private CFVVXENXKIU IZTOKUPUXXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private NTXWNCDUYQJ KGTDOVLTXAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private PIYWXEEYHLZ FLZKNZEKBWY;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private INKPZSVDXUP KYYXCPGOJZA
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x8AC2060", Offset = "0x8AC1460", VA = "0x188AC2060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private static WIIGEWEAFFO FDCMFEDTMIR
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x8AC2220", Offset = "0x8AC1620", VA = "0x188AC2220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1C60", Offset = "0x8AC1060", VA = "0x188AC1C60", Slot = "6")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x8AC20B0", Offset = "0x8AC14B0", VA = "0x188AC20B0", Slot = "4")]
		public WIIGEWEAFFO XOZCMEDRRJI(JCSDFORPEFX a, RoomOperationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1DD0", Offset = "0x8AC11D0", VA = "0x188AC1DD0", Slot = "5")]
		public WIIGEWEAFFO KABNJBFBYDX(JCSDFORPEFX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2050", Offset = "0x8AC1450", VA = "0x188AC2050")]
		private static WIIGEWEAFFO KTQRQVMHFZA(ValidationReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomManagerValidation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class RoomOperationAlreadyInProgressException : InvalidOperationException
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0E60", Offset = "0x8AE0260", VA = "0x188AE0E60")]
		public RoomOperationAlreadyInProgressException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C1CF60", Offset = "0x7C1C360", VA = "0x187C1CF60")]
		public RoomOperationAlreadyInProgressException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerAutosaves : YDVAPVGWKHO, VRXVJDMHIYE, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x8AE3FC0", Offset = "0x8AE33C0", VA = "0x188AE3FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x8AE4430", Offset = "0x8AE3830", VA = "0x188AE4430", Slot = "5")]
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
			public AsyncTaskMethodBuilder<WIIGEWEAFFO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public KCPWVXKRWZI autosaveRecordInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private StackTimer<string> <timer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private StackTimer<string>.UBFOGWXCCTH <timerScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			private CZLZSQHBSUM <operation>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			private TaskAwaiter<WIIGEWEAFFO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x8AE6A50", Offset = "0x8AE5E50", VA = "0x188AE6A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x8AE7420", Offset = "0x8AE6820", VA = "0x188AE7420", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AED080", Offset = "0x8AEC480", VA = "0x188AED080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x8AED5F0", Offset = "0x8AEC9F0", VA = "0x188AED5F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AECB30", Offset = "0x8AEBF30", VA = "0x188AECB30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x8AED020", Offset = "0x8AEC420", VA = "0x188AED020", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AEC310", Offset = "0x8AEB710", VA = "0x188AEC310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x8AECAD0", Offset = "0x8AEBED0", VA = "0x188AECAD0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AEDC10", Offset = "0x8AED010", VA = "0x188AEDC10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x8AEE340", Offset = "0x8AED740", VA = "0x188AEE340", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AEDA10", Offset = "0x8AECE10", VA = "0x188AEDA10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x8AEDBB0", Offset = "0x8AECFB0", VA = "0x188AEDBB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AF0F60", Offset = "0x8AF0360", VA = "0x188AF0F60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x8AF1660", Offset = "0x8AF0A60", VA = "0x188AF1660", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private HFLLGBMWIHF UGOVYLDDXNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private MVWEOVUCDOM ITQPEIGRZZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private MVZYDDMAODN GTVBHFZJJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private NPDGWTKDDKX RNLTQXVEFEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private AEOKRKYITOK XTHUHXRMJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private NTXWNCDUYQJ KGTDOVLTXAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private CancellationTokenSource SPLAFQPBZSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private Task SCAVZSQRSDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private TaskCompletionSource<int> JVWWWAQXWBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private int KGLQYOEIPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private int CSJGJDRBGOR;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0010", Offset = "0x8ADF410", VA = "0x188AE0010", Slot = "6")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x1297710", Offset = "0x1296B10", VA = "0x181297710", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0500", Offset = "0x8ADF900", VA = "0x188AE0500")]
		private void SJUBPLSJEQU(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x8AE02C0", Offset = "0x8ADF6C0", VA = "0x188AE02C0", Slot = "4")]
		[AsyncStateMachine(typeof(<RequestRestoreAutosave>d__14))]
		public Task<WIIGEWEAFFO> RequestRestoreAutosave(KCPWVXKRWZI autosaveRecordInfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x8AE07D0", Offset = "0x8ADFBD0", VA = "0x188AE07D0", Slot = "5")]
		[AsyncStateMachine(typeof(<RunRecoveryAutosave>d__15))]
		public Task YTAJJGSGWEW([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1297710", Offset = "0x1296B10", VA = "0x181297710")]
		public void JRNDYMGPUJU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x8ADFD00", Offset = "0x8ADF100", VA = "0x188ADFD00")]
		private CZLZSQHBSUM DPTIBQSJTLF(KCPWVXKRWZI a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x8ADFC10", Offset = "0x8ADF010", VA = "0x188ADFC10")]
		[AsyncStateMachine(typeof(<RunAutosaveRoutine>d__18))]
		private Task DDHLSJUAQXJ(CancellationToken a, int b, AccountRoleType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x8AE06D0", Offset = "0x8ADFAD0", VA = "0x188AE06D0")]
		[AsyncStateMachine(typeof(<RunAutosaveRoutineInternal>d__19))]
		private Task WYEZBWFQZIS(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x8AE05E0", Offset = "0x8ADF9E0", VA = "0x188AE05E0")]
		[AsyncStateMachine(typeof(<RunRecoveryAutosaveInternal>d__20))]
		private Task WFMIJYAMUVJ([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x8ADFF20", Offset = "0x8ADF320", VA = "0x188ADFF20")]
		[AsyncStateMachine(typeof(<ScheduleIncrementalAutosave>d__21))]
		private Task EOBSGFZPJNV(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x8AE01C0", Offset = "0x8ADF5C0", VA = "0x188AE01C0")]
		[AsyncStateMachine(typeof(<AwaitAutosaveInterval>d__22))]
		private Task MLUVILVVHPV(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF810", Offset = "0x8ADEC10", VA = "0x188ADF810")]
		private Task AAEAHJYQRUG(AutosaveType a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x8AE03F0", Offset = "0x8ADF7F0", VA = "0x188AE03F0")]
		[AsyncStateMachine(typeof(<RunAutosave>d__24))]
		private Task RunAutosave(AutosaveType autosaveType, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF9A0", Offset = "0x8ADEDA0", VA = "0x188ADF9A0")]
		private bool BAJWMNSYXMI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomManagerAutosaves()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomManagerSave : MLQYKKHTWKA, VRXVJDMHIYE, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x8AE7490", Offset = "0x8AE6890", VA = "0x188AE7490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x8AE7A20", Offset = "0x8AE6E20", VA = "0x188AE7A20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private RJVDARAWJUM RTRTYRMJVHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private MVWEOVUCDOM ITQPEIGRZZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private CJGHBXBZXEK DSMHCUXTNQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private NPDGWTKDDKX RNLTQXVEFEO;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0970", Offset = "0x8ADFD70", VA = "0x188AE0970", Slot = "6")]
		public void Initialize(MVWEOVUCDOM roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0920", Offset = "0x8ADFD20", VA = "0x188AE0920", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0D60", Offset = "0x8AE0160", VA = "0x188AE0D60", Slot = "5")]
		[AsyncStateMachine(typeof(<RequestSaveRoomToDisk>d__6))]
		public Task RequestSaveRoomToDisk(string path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE08C0", Offset = "0x8ADFCC0", VA = "0x188AE08C0", Slot = "4")]
		public WIIGEWEAFFO BAJWMNSYXMI(JCSDFORPEFX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0C40", Offset = "0x8AE0040", VA = "0x188AE0C40")]
		private XHKXZGEAWFX OFYMRGDCUAU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RoomManagerSave()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public static class KTBIGJKSCZS
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBAC0", Offset = "0x8ADAEC0", VA = "0x188ADBAC0")]
		public static void KEUPJCBYWBY(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBDE0", Offset = "0x8ADB1E0", VA = "0x188ADBDE0")]
		internal static void ZPJVJVMCQGR(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBD00", Offset = "0x8ADB100", VA = "0x188ADBD00")]
		internal static void MOPCYDVUDQS(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB690", Offset = "0x8ADAA90", VA = "0x188ADB690")]
		internal static void FAUSFKVCNPO(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x37200A0", Offset = "0x371F4A0", VA = "0x1837200A0")]
		private static void NDVAFVWPSYQ<a, b, a>(XRSJVGYQFTW a) where b : a
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	internal class ZRZMMHHEOQN : COIZHCLNVAT<PKIHHHDXEKZ>
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class AZSYQXSOVDR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public PKIHHHDXEKZ IOJYWEHVRDT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public string RHLJKYHBUIR;

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public AZSYQXSOVDR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x8AD92D0", Offset = "0x8AD86D0", VA = "0x188AD92D0")]
			internal object TMIASPMQMNE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly ZRZMMHHEOQN LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5970", Offset = "0x8AF4D70", VA = "0x188AF5970")]
		public ExitGames.Client.Photon.Hashtable Serialize(PKIHHHDXEKZ message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5280", Offset = "0x8AF4680", VA = "0x188AF5280", Slot = "5")]
		protected override void AJEUUYHXXWQ(PKIHHHDXEKZ a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF53B0", Offset = "0x8AF47B0", VA = "0x188AF53B0", Slot = "6")]
		public override PKIHHHDXEKZ Deserialize(IDictionary<object, object> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF55E0", Offset = "0x8AF49E0", VA = "0x188AF55E0")]
		private static void Log(string op, PKIHHHDXEKZ message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5A80", Offset = "0x8AF4E80", VA = "0x188AF5A80")]
		public ZRZMMHHEOQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF56E0", Offset = "0x8AF4AE0", VA = "0x188AF56E0")]
		[CompilerGenerated]
		internal static string PSKOQKTQMUT(RoomLoadRequestPayload a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public static class SMXLWTIJMFF
	{
		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public static WIIGEWEAFFO FDCMFEDTMIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x8AE2720", Offset = "0x8AE1B20", VA = "0x188AE2720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2270", Offset = "0x8AE1670", VA = "0x188AE2270")]
		public static bool IINYCGRTWJL(this WIIGEWEAFFO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2290", Offset = "0x8AE1690", VA = "0x188AE2290")]
		public static WIIGEWEAFFO KTQRQVMHFZA(ValidationReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2530", Offset = "0x8AE1930", VA = "0x188AE2530")]
		public static WIIGEWEAFFO ZHAKWWGLIUB(IEnumerable<WIIGEWEAFFO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x8AE22F0", Offset = "0x8AE16F0", VA = "0x188AE22F0")]
		public static string OUYRNPTWQBS(this WIIGEWEAFFO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public abstract class ATOTXALSPWU : BQPZCKTDPNN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		public delegate WIIGEWEAFFO ValidateOperation([NotNull] JCSDFORPEFX networkPlayer);

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class EOXEHAWLLLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public JCSDFORPEFX SYZGCFENUEN;

			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EOXEHAWLLLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x15761F0", Offset = "0x15755F0", VA = "0x1815761F0")]
			internal WIIGEWEAFFO QNOUCLWMVHY(ValidateOperation a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private bool GQSAKQHYXLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		protected readonly HashSet<ValidateOperation> VZNALPPOSPX;

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8E50", Offset = "0x8AD8250", VA = "0x188AD8E50", Slot = "4")]
		public void KVFLRZTLUXN(ValidateOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8DF0", Offset = "0x8AD81F0", VA = "0x188AD8DF0", Slot = "5")]
		public void HCAMVXYVTQS(ValidateOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8DA0", Offset = "0x8AD81A0", VA = "0x188AD8DA0", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8EB0", Offset = "0x8AD82B0", VA = "0x188AD8EB0")]
		protected WIIGEWEAFFO ZFSGQEVMZPW(JCSDFORPEFX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9130", Offset = "0x8AD8530", VA = "0x188AD9130")]
		protected ATOTXALSPWU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public class XTWCRVXITQT : ATOTXALSPWU, DAQZLJHROXK, BQPZCKTDPNN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class SYKSUEBHFID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public WIIGEWEAFFO LSMVWTWXCVV;

			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public SYKSUEBHFID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x8AE2780", Offset = "0x8AE1B80", VA = "0x188AE2780")]
			internal object JMIBULLCFAO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2940", Offset = "0x8AE1D40", VA = "0x188AE2940")]
		[UnityEngine.Scripting.Preserve]
		public XTWCRVXITQT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x8AF40F0", Offset = "0x8AF34F0", VA = "0x188AF40F0", Slot = "8")]
		public WIIGEWEAFFO RMBEBQHOKYY(JCSDFORPEFX a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public class TGOPYCQSXZF : ATOTXALSPWU, RJVDARAWJUM, BQPZCKTDPNN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		[CompilerGenerated]
		private sealed class SYKSUEBHFID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public WIIGEWEAFFO LSMVWTWXCVV;

			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public SYKSUEBHFID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x8AE27E0", Offset = "0x8AE1BE0", VA = "0x188AE27E0")]
			internal object ZEUIVXGWJUC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2940", Offset = "0x8AE1D40", VA = "0x188AE2940")]
		[UnityEngine.Scripting.Preserve]
		public TGOPYCQSXZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2840", Offset = "0x8AE1C40", VA = "0x188AE2840", Slot = "8")]
		public WIIGEWEAFFO BAJWMNSYXMI(JCSDFORPEFX a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	internal static class OMXHRNMZYSX
	{
		[Cpp2IlInjected.Token(Token = "0x20000EE")]
		[CompilerGenerated]
		private sealed class EOXEHAWLLLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public StackTimer<string> KBRWMMHEUWD;

			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EOXEHAWLLLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA3A0", Offset = "0x8AD97A0", VA = "0x188ADA3A0")]
			internal object ETJNFODTPYA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE010", Offset = "0x8ADD410", VA = "0x188ADE010")]
		public static StackTimer<string> UBFOGWXCCTH(Log a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x8ADDE90", Offset = "0x8ADD290", VA = "0x188ADDE90")]
		public static void LUPZSPPTQBU(StackTimer<string> a, Log b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x8ADDF50", Offset = "0x8ADD350", VA = "0x188ADDF50")]
		public static string OHFGKEGCIQH(PKIHHHDXEKZ a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	internal static class ABKZRYUBSMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8D20", Offset = "0x8AD8120", VA = "0x188AD8D20")]
		public static void WSAZIGYGGGB(this HFLLGBMWIHF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8BF0", Offset = "0x8AD7FF0", VA = "0x188AD8BF0")]
		public static void AAPJDMQRCLE(this HFLLGBMWIHF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8C00", Offset = "0x8AD8000", VA = "0x188AD8C00")]
		private static void LUTIDOUUZDM(this HFLLGBMWIHF a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public class PXEPPIHHLFZ : UCPYWEKSTPP, OVQHBDANVOS, VMVFFWRLBCX, FRBYIYMCMFU
	{
		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		private class RCSTFLYIFBF : PTKTLSUVJWP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			private readonly byte YVKKQSTSWQL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			private readonly int ZOZQMMCCNHZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			private readonly object HYWNJUMMLWN;

			[Cpp2IlInjected.Token(Token = "0x170000CC")]
			public byte LKVKMZDDSZJ
			{
				[Cpp2IlInjected.Token(Token = "0x600046B")]
				[Cpp2IlInjected.Address(RVA = "0xAF8E00", Offset = "0xAF8200", VA = "0x180AF8E00", Slot = "4")]
				get
				{
					return default(byte);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CD")]
			public int GQNZJUUOZCL
			{
				[Cpp2IlInjected.Token(Token = "0x600046C")]
				[Cpp2IlInjected.Address(RVA = "0xC4E2B0", Offset = "0xC4D6B0", VA = "0x180C4E2B0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CE")]
			public object ZGGPRZOUJQR
			{
				[Cpp2IlInjected.Token(Token = "0x600046D")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			public object this[byte key]
			{
				[Cpp2IlInjected.Token(Token = "0x600046E")]
				[Cpp2IlInjected.Address(RVA = "0x8ADF0C0", Offset = "0x8ADE4C0", VA = "0x188ADF0C0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x7C247C0", Offset = "0x7C23BC0", VA = "0x187C247C0")]
			public RCSTFLYIFBF(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x8ADF080", Offset = "0x8ADE480", VA = "0x188ADF080", Slot = "8")]
			public bool NCIRIRZXKOC(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private readonly OVQHBDANVOS DEGJNZZHLAY;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public JCSDFORPEFX NYHENYQESVW
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x8ADE650", Offset = "0x8ADDA50", VA = "0x188ADE650", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public int GJGTCQYWBXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x8ADE7E0", Offset = "0x8ADDBE0", VA = "0x188ADE7E0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public int WKNGKDGQVXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x8ADEB00", Offset = "0x8ADDF00", VA = "0x188ADEB00", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public JCSDFORPEFX PQXGPXPTXLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x8ADE540", Offset = "0x8ADD940", VA = "0x188ADE540", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool ZCQMDRLXERN
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public int BMLDBTQEMLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string YNADGOKJOIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x8ADE780", Offset = "0x8ADDB80", VA = "0x188ADE780", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Func<string, string> GJGXGVUBWLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x8ADE590", Offset = "0x8ADD990", VA = "0x188ADE590", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<string, long> KFBQOYMPXYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<PTKTLSUVJWP> BEMKGLENBOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x8ADEBF0", Offset = "0x8ADDFF0", VA = "0x188ADEBF0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x8ADEDE0", Offset = "0x8ADE1E0", VA = "0x188ADEDE0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<bool> STHSXVIWFON
		{
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "26")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "27")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<JCSDFORPEFX> FQFOLDMOBXV
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "9")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action ELOCVAQAKZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x8ADEB50", Offset = "0x8ADDF50", VA = "0x188ADEB50", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x8ADED40", Offset = "0x8ADE140", VA = "0x188ADED40", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE830", Offset = "0x8ADDC30", VA = "0x188ADE830", Slot = "19")]
		public void OJJNJISBRRF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xB902E0", Offset = "0xB8F6E0", VA = "0x180B902E0")]
		public PXEPPIHHLFZ(OVQHBDANVOS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE9C0", Offset = "0x8ADDDC0", VA = "0x188ADE9C0", Slot = "8")]
		public bool RaiseEvent(byte eventCode, object eventContent, FRDJWLZNOWA raiseEventOptions, RRNetworkDelivery networkDelivery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x8ADECA0", Offset = "0x8ADE0A0", VA = "0x188ADECA0", Slot = "20")]
		public JCSDFORPEFX VQEGFVAHVPZ(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE8E0", Offset = "0x8ADDCE0", VA = "0x188ADE8E0", Slot = "21")]
		public JCSDFORPEFX RVWUFLTWTDT(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE460", Offset = "0x8ADD860", VA = "0x188ADE460", Slot = "22")]
		public JCSDFORPEFX BIKNLKOXTOH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE6A0", Offset = "0x8ADDAA0", VA = "0x188ADE6A0", Slot = "23")]
		public IReadOnlyList<JCSDFORPEFX> LANSCTINBBF(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x8ADEAC0", Offset = "0x8ADDEC0", VA = "0x188ADEAC0", Slot = "24")]
		public IReadOnlyList<JCSDFORPEFX> SLDKIXECHYQ(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "25")]
		public bool QYBADYZNXZN(JCSDFORPEFX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "28")]
		public void JZHNPAFQYEG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "29")]
		public void EUDSJAUMBQV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "30")]
		public void XROJYPIWMBL(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE890", Offset = "0x8ADDC90", VA = "0x188ADE890", Slot = "31")]
		public IDisposable QOCINTMORAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "32")]
		private bool EINIASDXBCB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "33")]
		public void IMJAYVDJNIB(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xE275F0", Offset = "0xE269F0", VA = "0x180E275F0", Slot = "34")]
		public bool ECHHJLKMUQI(bool a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xD80900", Offset = "0xD7FD00", VA = "0x180D80900", Slot = "37")]
		public void QIXNCLXVKEN()
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
		[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
		public OperationEventData(IDictionary<object, object> eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE1D0", Offset = "0x8ADD5D0", VA = "0x188ADE1D0")]
		public bool MLKKPVWGXPH([Out] PKIHHHDXEKZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE3B0", Offset = "0x8ADD7B0", VA = "0x188ADE3B0")]
		public Guid TFLNWZAZUHE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE280", Offset = "0x8ADD680", VA = "0x188ADE280")]
		public WIIGEWEAFFO RHJXTSYVHVC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x8ADE0E0", Offset = "0x8ADD4E0", VA = "0x188ADE0E0")]
		public static ExitGames.Client.Photon.Hashtable Create(PKIHHHDXEKZ message, WIIGEWEAFFO validationResult)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	internal static class UZRLRSDAZOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2300", Offset = "0x8AF1700", VA = "0x188AF2300")]
		public static bool EZRSGIZVSIJ(this RoomInstance a)
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
			[Cpp2IlInjected.Address(RVA = "0x8AEE3A0", Offset = "0x8AED7A0", VA = "0x188AEE3A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0x8AEE580", Offset = "0x8AED980", VA = "0x188AEE580", Slot = "5")]
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
		public bool TJTYNZBKWRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x8AE3E60", Offset = "0x8AE3260", VA = "0x188AE3E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3E90", Offset = "0x8AE3290", VA = "0x188AE3E90")]
		public TaskRunner(CancellationToken cancellationToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3D50", Offset = "0x8AE3150", VA = "0x188AE3D50")]
		[AsyncStateMachine(typeof(<RunTasks>d__8))]
		public Task ERYRLVYLQLB(Func<CancellationToken, List<Task>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3D00", Offset = "0x8AE3100", VA = "0x188AE3D00", Slot = "4")]
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
			public AsyncTaskMethodBuilder<Result<ParseResult<TData>, GKLIEWNFSHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public StackTimer<string>.UBFOGWXCCTH timer;

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
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			private TaskAwaiter<Result<ParseResult<TData>, GKLIEWNFSHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0x4E98B20", Offset = "0x4E97F20", VA = "0x184E98B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0x4E991E0", Offset = "0x4E985E0", VA = "0x184E991E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private readonly QSAZZMJIOWN<TGetDataArg, TData> _deps;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
		internal VersionedDataGetter(QSAZZMJIOWN<TGetDataArg, TData> deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x657CBD0", Offset = "0x657BFD0", VA = "0x18657CBD0")]
		[AsyncStateMachine(typeof(VersionedDataGetter<, >.<DownloadAndParse>d__2))]
		public Task<Result<ParseResult<TData>, GKLIEWNFSHL>> VIWYKKDXDMG(TGetDataArg a, string b, StackTimer<string>.UBFOGWXCCTH c, CancellationToken d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public static class ZZUPIFQEKWM
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x3002660", Offset = "0x3001A60", VA = "0x183002660")]
		public static VersionedDataGetter<TGetDataArg, TData> New<TGetDataArg, TData>(QSAZZMJIOWN<TGetDataArg, TData> deps)
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
		[Cpp2IlInjected.Address(RVA = "0x52ED5D0", Offset = "0x52EC9D0", VA = "0x1852ED5D0")]
		public ErrorCode(int code, [Optional] int? subCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x8ADAC00", Offset = "0x8ADA000", VA = "0x188ADAC00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public interface IIUUNXMZWUD<a> where a : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZGBBYZTCGTO();

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IIUUNXMZWUD<a> PTYSOQDDUOX(string a);

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IIUUNXMZWUD<a> HFWJNKWCOYS(UserFriendlyErrorMessageBuilder<a> a);

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IIUUNXMZWUD<a> EGDMPBREXLP(int a);

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IIUUNXMZWUD<a> YSMJNVWUDRW(int a, GetSubCode<a> b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public interface OPLTLPPSEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IIUUNXMZWUD<a> OMYBKSMUPSA<a>() where a : Exception;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(Slot = "1")]
		UserFriendlyErrorInfo YCYBUKPUZUJ(Exception a);

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ErrorCode KKMKVVUFVVD(Exception a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public delegate string UserFriendlyErrorMessageBuilder<in T>(T ex) where T : Exception;
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public delegate int GetSubCode<in T>(T ex) where T : Exception;
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	internal class XIBXGYBYHXO : OPLTLPPSEIP
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		private delegate string UserFriendlyErrorMessageBuilder(Exception ex);

		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private delegate int GetSubCodeInternal(Exception ex);

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		private class Registration<T> : IIUUNXMZWUD<T> where T : notnull, Exception
		{
			[Cpp2IlInjected.Token(Token = "0x2000102")]
			[CompilerGenerated]
			private sealed class OBPSGXVZRRC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003CB")]
				public string MBNWXYVVQCT;

				[Cpp2IlInjected.Token(Token = "0x60004A8")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public OBPSGXVZRRC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004A9")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
				internal string TLWDFQSACBF(Exception a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000103")]
			[CompilerGenerated]
			private sealed class AZSYQXSOVDR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003CC")]
				public UserFriendlyErrorMessageBuilder<T> MLGPQSPUAJM;

				[Cpp2IlInjected.Token(Token = "0x60004AA")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public AZSYQXSOVDR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004AB")]
				[Cpp2IlInjected.Address(RVA = "0x3E7EA70", Offset = "0x3E7DE70", VA = "0x183E7EA70")]
				internal string VTQVGKCZXMM(Exception a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[CompilerGenerated]
			private sealed class YYSAOGCWSFC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003CD")]
				public GetSubCode<T> DAZGOTZIYFL;

				[Cpp2IlInjected.Token(Token = "0x60004AC")]
				[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
				public YYSAOGCWSFC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004AD")]
				[Cpp2IlInjected.Address(RVA = "0x3E7EA70", Offset = "0x3E7DE70", VA = "0x183E7EA70")]
				internal int ZTMWBGTTNFA(Exception a)
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			private readonly XIBXGYBYHXO NFNMUGTIVAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			private readonly Type SQMLDFHYTVR;

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x5D5DAC0", Offset = "0x5D5CEC0", VA = "0x185D5DAC0")]
			internal Registration(XIBXGYBYHXO errorRegistry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x5D5DA90", Offset = "0x5D5CE90", VA = "0x185D5DA90", Slot = "4")]
			public void ZGBBYZTCGTO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x5D5D880", Offset = "0x5D5CC80", VA = "0x185D5D880", Slot = "5")]
			public IIUUNXMZWUD<T> PTYSOQDDUOX(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x5D5D780", Offset = "0x5D5CB80", VA = "0x185D5D780", Slot = "6")]
			public IIUUNXMZWUD<T> HFWJNKWCOYS(UserFriendlyErrorMessageBuilder<T> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x5D5D740", Offset = "0x5D5CB40", VA = "0x185D5D740", Slot = "7")]
			public IIUUNXMZWUD<T> EGDMPBREXLP(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x5D5D980", Offset = "0x5D5CD80", VA = "0x185D5D980", Slot = "8")]
			public IIUUNXMZWUD<T> YSMJNVWUDRW(int a, GetSubCode<T> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000105")]
		private class KLNCRTPZHWD<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private bool IGIWRFGWNCX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private readonly List<Type> VVYJDBWDFRZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			private readonly Dictionary<Type, a> IBNTFMMONQO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			private readonly Dictionary<Type, int> LDPYBCOHFXV;

			[Cpp2IlInjected.Token(Token = "0x170000D1")]
			public IReadOnlyList<Type> VSSMOFKHFNJ
			{
				[Cpp2IlInjected.Token(Token = "0x60004B0")]
				[Cpp2IlInjected.Address(RVA = "0x521C680", Offset = "0x521BA80", VA = "0x18521C680")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x521C910", Offset = "0x521BD10", VA = "0x18521C910")]
			public KLNCRTPZHWD(Dictionary<Type, int> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x521BF70", Offset = "0x521B370", VA = "0x18521BF70")]
			public void Add(Type key, a val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x521C060", Offset = "0x521B460", VA = "0x18521C060")]
			public bool GNHQWIZZJDI(Type a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x521C220", Offset = "0x521B620", VA = "0x18521C220")]
			public bool JAEEXXWEINW(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x521C1C0", Offset = "0x521B5C0", VA = "0x18521C1C0")]
			public a Get(Type type)
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x521C3E0", Offset = "0x521B7E0", VA = "0x18521C3E0")]
			[CompilerGenerated]
			private int SMYLOHOIPGQ(Type a, Type b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000107")]
		[CompilerGenerated]
		private sealed class EVOPPRDSHOO : IEnumerable<ErrorCode>, IEnumerable, IEnumerator<ErrorCode>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private ErrorCode JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public XIBXGYBYHXO MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			private Exception HCWNUUPSPGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public Exception EBLDWZBOMQS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			private IEnumerator<Exception> BPMZBLFMONE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			private IEnumerator<ErrorCode> BPHSEELPFBV;

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			private ErrorCode COMNDEVWMHV
			{
				[Cpp2IlInjected.Token(Token = "0x60004BE")]
				[Cpp2IlInjected.Address(RVA = "0x16B9990", Offset = "0x16B8D90", VA = "0x1816B9990", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ErrorCode);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D3")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x8ADAB10", Offset = "0x8AD9F10", VA = "0x188ADAB10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0xD06FE0", Offset = "0xD063E0", VA = "0x180D06FE0")]
			[DebuggerHidden]
			public EVOPPRDSHOO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA420", Offset = "0x8AD9820", VA = "0x188ADA420", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA660", Offset = "0x8AD9A60", VA = "0x188ADA660", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x8ADAB60", Offset = "0x8AD9F60", VA = "0x188ADAB60")]
			private void RYZDNTQONZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x8ADABB0", Offset = "0x8AD9FB0", VA = "0x188ADABB0")]
			private void RZEKLAKLXKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA620", Offset = "0x8AD9A20", VA = "0x188ADA620", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA570", Offset = "0x8AD9970", VA = "0x188ADA570", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ErrorCode> BULRTHTGMZS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA570", Offset = "0x8AD9970", VA = "0x188ADA570", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly ErrorCode EKYJZQWFSIM;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private static readonly Dictionary<Type, int> NUMYLXSMFTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private readonly HashSet<Type> GJJIEZPKSHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private readonly KLNCRTPZHWD<int> UTGGNTLMPTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private readonly KLNCRTPZHWD<GetSubCodeInternal> CPSNZWJRXQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private readonly KLNCRTPZHWD<UserFriendlyErrorMessageBuilder> BPVQMLSCPVT;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2B40", Offset = "0x8AF1F40", VA = "0x188AF2B40")]
		[CVOOPLRRRUK.Root.GameOnly]
		internal static void CVOOPLRRRUK(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3B80", Offset = "0x8AF2F80", VA = "0x188AF3B80")]
		[RecRoom.NoEngine.Common.Preserve]
		public XIBXGYBYHXO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x3C03870", Offset = "0x3C02C70", VA = "0x183C03870", Slot = "4")]
		public IIUUNXMZWUD<T> OMYBKSMUPSA<T>() where T : notnull, Exception
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x8AF38E0", Offset = "0x8AF2CE0", VA = "0x188AF38E0", Slot = "5")]
		public UserFriendlyErrorInfo YCYBUKPUZUJ(Exception a)
		{
			return default(UserFriendlyErrorInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3400", Offset = "0x8AF2800", VA = "0x188AF3400", Slot = "6")]
		public ErrorCode KKMKVVUFVVD(Exception? a)
		{
			return default(ErrorCode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3A40", Offset = "0x8AF2E40", VA = "0x188AF3A40", Slot = "7")]
		[IteratorStateMachine(typeof(EVOPPRDSHOO))]
		public IEnumerable<ErrorCode> ZBPJLDPJZDD(Exception a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x8AF32B0", Offset = "0x8AF26B0", VA = "0x188AF32B0", Slot = "8")]
		public string JSEFIBAJPMP(Exception? ex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3600", Offset = "0x8AF2A00", VA = "0x188AF3600")]
		private string PKPJJWOGNKB(AggregateException a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2DD0", Offset = "0x8AF21D0", VA = "0x188AF2DD0")]
		private void GHYIUHTJMUR(Type a, int b, GetSubCodeInternal? getSubCodeInternal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2BB0", Offset = "0x8AF1FB0", VA = "0x188AF2BB0")]
		private void DLECGWUXGJP(Type a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x8AF28A0", Offset = "0x8AF1CA0", VA = "0x188AF28A0")]
		private void BZRTGECSGXY(Type a, UserFriendlyErrorMessageBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3140", Offset = "0x8AF2540", VA = "0x188AF3140")]
		private static int IFQIHAHBBBO(Type a, Dictionary<Type, int> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x3C03480", Offset = "0x3C02880", VA = "0x183C03480")]
		private static bool KYSSJUADGLJ<TVal>(KLNCRTPZHWD<TVal> a, Type b, [Out] TVal c) where TVal : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3970", Offset = "0x8AF2D70", VA = "0x188AF3970")]
		[CompilerGenerated]
		internal static int YHVCFTLBRXJ(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x8AF2420", Offset = "0x8AF1820", VA = "0x188AF2420")]
		public UserFriendlyErrorInfo(string userFriendlyMessage, ErrorCode errorCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2380", Offset = "0x8AF1780", VA = "0x188AF2380")]
		public string NYWTDASCTNN()
		{
			return null;
		}
	}
}
namespace RecRoom.RoomLoading.RoomOperation
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public class SJYCKVQRDLU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private readonly UQMTYYLRCUF WSKNBHVGEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private string CEQYIIQNKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private long? DKCWOTKQZQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private long? OZDQYZMKLER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private long? CMQURPVQVTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private string WXEVGCHNICX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private RoomOperationState JBBKWZTLNHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private long? ZLKQUCIBTIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private bool YBORQWODKVS;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public string EIHBHMFYWLR
		{
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public long XXECLXYBKBH
		{
			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x8AE1A90", Offset = "0x8AE0E90", VA = "0x188AE1A90")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public long TMGUPBCDPTT
		{
			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x8AE21D0", Offset = "0x8AE15D0", VA = "0x188AE21D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public long DINFGURQNIW
		{
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x8AE1990", Offset = "0x8AE0D90", VA = "0x188AE1990")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public string UCDIWFKIGVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x8AE20A0", Offset = "0x8AE14A0", VA = "0x188AE20A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public RoomOperationState NYAYLQNOIYG
		{
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0xBF7910", Offset = "0xBF6D10", VA = "0x180BF7910")]
			get
			{
				return default(RoomOperationState);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0x8AE20E0", Offset = "0x8AE14E0", VA = "0x188AE20E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public long QBOGOQFMKWC
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0x8AE14A0", Offset = "0x8AE08A0", VA = "0x188AE14A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2230", Offset = "0x8AE1630", VA = "0x188AE2230")]
		[UnityEngine.Scripting.Preserve]
		public SJYCKVQRDLU([Inject(null)] UQMTYYLRCUF playerPreferences)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1E50", Offset = "0x8AE1250", VA = "0x188AE1E50")]
		private void IIIDGKAUHWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1500", Offset = "0x8AE0900", VA = "0x188AE1500")]
		public void BQYJBWZHKWD(long a, long b, [Optional] long? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x8AE19F0", Offset = "0x8AE0DF0", VA = "0x188AE19F0")]
		public void GEAALZJBSPB(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1420", Offset = "0x8AE0820", VA = "0x188AE1420")]
		public void AFIKZPLVJAS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1AF0", Offset = "0x8AE0EF0", VA = "0x188AE1AF0")]
		public void HDBPFXLINHN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	internal class TNRXJFRDOMC : IDisposable
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
		private sealed class DGZUGYUZOOX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public PKIHHHDXEKZ RRASYAVFNCV;

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public DGZUGYUZOOX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x8AD9BA0", Offset = "0x8AD8FA0", VA = "0x188AD9BA0")]
			internal PKIHHHDXEKZ FVIMECRJYGG(byte[] a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000110")]
		[CompilerGenerated]
		private sealed class DJEEUXRFMMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public Func<Guid, bool> SDDPDJXUSBN;

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public DJEEUXRFMMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x8AD9D40", Offset = "0x8AD9140", VA = "0x188AD9D40")]
			internal object FFSVSCMXVYP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x8AD9C80", Offset = "0x8AD9080", VA = "0x188AD9C80")]
			internal bool APDCHHJJZUH(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000111")]
		[CompilerGenerated]
		private sealed class QNTXVGAOFXX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Func<Guid, bool> SQFHXHYBIPK;

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public QNTXVGAOFXX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x8ADF020", Offset = "0x8ADE420", VA = "0x188ADF020")]
			internal object GCBICSYDFVV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[CompilerGenerated]
		private sealed class TWLQVARRGGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Guid SRFICUMGZXX;

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public TWLQVARRGGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x8AE3C90", Offset = "0x8AE3090", VA = "0x188AE3C90")]
			internal object SQMOMPOPBRL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000113")]
		[CompilerGenerated]
		private sealed class QKFPBSDGSOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Guid SRFICUMGZXX;

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public QKFPBSDGSOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0x8ADEFB0", Offset = "0x8ADE3B0", VA = "0x188ADEFB0")]
			internal object VRCFHNFQRWU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000114")]
		[CompilerGenerated]
		private sealed class YPXNBFJFMEV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public TNRXJFRDOMC MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			public string DKWMBOFVRMX;

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public YPXNBFJFMEV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0x8AF4E70", Offset = "0x8AF4270", VA = "0x188AF4E70")]
			internal object TMIASPMQMNE()
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
			public TNRXJFRDOMC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x50B06C0", Offset = "0x50AFAC0", VA = "0x1850B06C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(RVA = "0x4E991E0", Offset = "0x4E985E0", VA = "0x184E991E0", Slot = "5")]
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
			public TNRXJFRDOMC <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8AE5B10", Offset = "0x8AE4F10", VA = "0x188AE5B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0x8AE5DE0", Offset = "0x8AE51E0", VA = "0x188AE5DE0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<PKIHHHDXEKZ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public PKIHHHDXEKZ roomOperationMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public TNRXJFRDOMC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<WGTOKMZHNDN.BufferedMessage<PKIHHHDXEKZ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0x8AE64A0", Offset = "0x8AE58A0", VA = "0x188AE64A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0x8AE69E0", Offset = "0x8AE5DE0", VA = "0x188AE69E0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<WGTOKMZHNDN.BufferedMessage<PKIHHHDXEKZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public PKIHHHDXEKZ roomOperationMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public TNRXJFRDOMC <>4__this;

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
			private TaskAwaiter<WGTOKMZHNDN.BufferedMessage<PKIHHHDXEKZ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0x8AE5E40", Offset = "0x8AE5240", VA = "0x188AE5E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x8AE6430", Offset = "0x8AE5830", VA = "0x188AE6430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private static readonly Guid MDCINEPJDOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public readonly YHYCZYSLLNF NXNEEQBUZMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private readonly WGTOKMZHNDN FQWQDNKFLQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private readonly VMVFFWRLBCX UGOVYLDDXNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private readonly FRBYIYMCMFU OBREAOGRPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private bool AQLZEDOFVXP;

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3A80", Offset = "0x8AE2E80", VA = "0x188AE3A80")]
		public TNRXJFRDOMC(YHYCZYSLLNF a, WGTOKMZHNDN b, VMVFFWRLBCX c, FRBYIYMCMFU d, StackTimer<string>.UBFOGWXCCTH e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2B40", Offset = "0x8AE1F40", VA = "0x188AE2B40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3090", Offset = "0x8AE2490", VA = "0x188AE3090")]
		public void JXFIKAAHQYL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2B50", Offset = "0x8AE1F50", VA = "0x188AE2B50")]
		public void EILPNAIZABQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2950", Offset = "0x8AE1D50", VA = "0x188AE2950")]
		public void BFOZIEVUHWT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2F30", Offset = "0x8AE2330", VA = "0x188AE2F30")]
		[AsyncStateMachine(typeof(<MasterSendAllReceive>d__11))]
		internal Task<PKIHHHDXEKZ> IBGXUDDKUHQ(StackTimer<string>.UBFOGWXCCTH a, PKIHHHDXEKZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5190", Offset = "0x3AA4590", VA = "0x183AA5190")]
		private static byte[] BPPNAHOGQXF<a>(a a) where a : IMessage<a>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5B10", Offset = "0x3AA4F10", VA = "0x183AA5B10")]
		private static b UFHMYARGXZY<b>(MessageParser<b> a, byte[] b, b c) where b : IMessage<b>
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x8AE31B0", Offset = "0x8AE25B0", VA = "0x188AE31B0")]
		[AsyncStateMachine(typeof(<MasterSendAllReceiveBufferedMessage>d__14))]
		private Task<WGTOKMZHNDN.BufferedMessage<PKIHHHDXEKZ>> LDKYTFWNBBS(PKIHHHDXEKZ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x3AA53D0", Offset = "0x3AA47D0", VA = "0x183AA53D0")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__15<>))]
		internal Task<c> HESWPVIJTPF<c>(CancellationToken a, Func<CancellationToken, Task<c>> b, int c = 3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2E00", Offset = "0x8AE2200", VA = "0x188AE2E00")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__16))]
		internal Task HESWPVIJTPF(CancellationToken a, Func<CancellationToken, Task> b, int c = 3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3650", Offset = "0x8AE2A50", VA = "0x188AE3650")]
		public RoomUploadLogic OZZMEBPZVCW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x8AE39A0", Offset = "0x8AE2DA0", VA = "0x188AE39A0")]
		public OFLHOWWQUAV XRRZTAYSTRL([Optional] DBSTIRSNXRY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2C10", Offset = "0x8AE2010", VA = "0x188AE2C10")]
		public TXHNTTILGBE FCZYSKASJSK([Optional] Log? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3500", Offset = "0x8AE2900", VA = "0x188AE3500")]
		public void NAMZZAGZLMT(Func<Guid, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x8AE33F0", Offset = "0x8AE27F0", VA = "0x188AE33F0")]
		public void MJQCVUOROHB(Func<Guid, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x8AE37D0", Offset = "0x8AE2BD0", VA = "0x188AE37D0")]
		public Guid TVOINTCSGHL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8AE36C0", Offset = "0x8AE2AC0", VA = "0x188AE36C0")]
		public void RLEYEVGAQAW(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2A10", Offset = "0x8AE1E10", VA = "0x188AE2A10")]
		public void CCPWANFQWPQ(PKIHHHDXEKZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x8AE32F0", Offset = "0x8AE26F0", VA = "0x188AE32F0")]
		public void Log(string stepMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x3AA51A0", Offset = "0x3AA45A0", VA = "0x183AA51A0")]
		private d ECMRBAICHCW<d>(d a) where d : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3950", Offset = "0x8AE2D50", VA = "0x188AE3950")]
		public void WMLHYJETCXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5670", Offset = "0x3AA4A70", VA = "0x183AA5670")]
		[CompilerGenerated]
		internal static string HWJSQGOSXGW<e>(byte[] a, int b = 15, <>c__DisplayClass13_0<e> c) where e : IMessage<e>
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	internal sealed class InitialRoomLoadOperation : YHYCZYSLLNF
	{
		[Cpp2IlInjected.Token(Token = "0x200011A")]
		[CompilerGenerated]
		private sealed class RPXDXIRZXRW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			public PlayerPresence TBTOLWHBNHB;

			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public RPXDXIRZXRW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x8ADF100", Offset = "0x8ADE500", VA = "0x188ADF100")]
			internal object FYZVOZVQGVH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011B")]
		[CompilerGenerated]
		private sealed class ACTEAKJALWV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			public Guid ZKWAGILEUSK;

			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ACTEAKJALWV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x8AD8D30", Offset = "0x8AD8130", VA = "0x188AD8D30")]
			internal object SUKNQOTQISI()
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
			[Cpp2IlInjected.Address(RVA = "0x8AE4F90", Offset = "0x8AE4390", VA = "0x188AE4F90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x8AE5730", Offset = "0x8AE4B30", VA = "0x188AE5730", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AE5790", Offset = "0x8AE4B90", VA = "0x188AE5790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x8AE5AA0", Offset = "0x8AE4EA0", VA = "0x188AE5AA0", Slot = "5")]
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
			public TNRXJFRDOMC operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			private PlayerPresence <presence>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			private OFLHOWWQUAV <loadLogic>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			private TaskAwaiter<Scene> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			private TaskAwaiter<SIQTORPVPPM> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x8AEA9A0", Offset = "0x8AE9DA0", VA = "0x188AEA9A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB8A0", Offset = "0x8AEACA0", VA = "0x188AEB8A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private static readonly Log LNPYKRNGQSQ;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private static readonly Log ARXUVGEYPTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private readonly RoomLoadRequestPayload FGXGTJCMWHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private readonly RoomInstance LSMFKXQELDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private readonly DBSTIRSNXRY PPSWLAIGZTU;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB4F0", Offset = "0x8ADA8F0", VA = "0x188ADB4F0")]
		public InitialRoomLoadOperation(RoomLoadRequestPayload initialRoomLoadPayload, RoomInstance originalTargetRoomInstance, Guid operationId, MVWEOVUCDOM roomManager, UMTYTQWPZHG operationPauseToken, DBSTIRSNXRY preloadContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB1C0", Offset = "0x8ADA5C0", VA = "0x188ADB1C0", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__8))]
		protected override Task FYLEBLVLNXH(TNRXJFRDOMC a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB0C0", Offset = "0x8ADA4C0", VA = "0x188ADB0C0")]
		[AsyncStateMachine(typeof(<EnableDisableObjectModel>d__9))]
		private Task EnableDisableObjectModel(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB310", Offset = "0x8ADA710", VA = "0x188ADB310")]
		[AsyncStateMachine(typeof(<GetSubroomSaveOMVersion>d__10))]
		private Task<int> RBZDSRYKIUG(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x8ADAEF0", Offset = "0x8ADA2F0", VA = "0x188ADAEF0")]
		private PlayerPresence BDUGSSQVRKJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	internal class CZLZSQHBSUM : YHYCZYSLLNF
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
			public CZLZSQHBSUM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public TNRXJFRDOMC operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB900", Offset = "0x8AEAD00", VA = "0x188AEB900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC2B0", Offset = "0x8AEB6B0", VA = "0x188AEC2B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private readonly int EJOUBAKJFTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private readonly KCPWVXKRWZI JANPOZGHAXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public readonly long QLBYKZXPOPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public readonly long KHQSNYNZPDY;

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public SaveSubRoomResponseDTO KKXXBMLFFRC
		{
			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9A0", Offset = "0xAABDA0", VA = "0x180AAC9A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9F0", Offset = "0xAABDF0", VA = "0x180AAC9F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9A70", Offset = "0x8AD8E70", VA = "0x188AD9A70")]
		public CZLZSQHBSUM(Guid a, MVWEOVUCDOM b, UMTYTQWPZHG c, int d, KCPWVXKRWZI e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9950", Offset = "0x8AD8D50", VA = "0x188AD9950", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__9))]
		protected override Task FYLEBLVLNXH(TNRXJFRDOMC a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	internal abstract class COFOZRBTHIU : YHYCZYSLLNF
	{
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[CompilerGenerated]
		private sealed class OFEBALTHFAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public COFOZRBTHIU MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public IDisposable SVLHAEIPAME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public VYSMBECYISG EFJJFFYRHAH;

			[Cpp2IlInjected.Token(Token = "0x6000525")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OFEBALTHFAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0x8ADBFD0", Offset = "0x8ADB3D0", VA = "0x188ADBFD0")]
			internal Task WUJAJJYMGWN(StackTimer<string>.UBFOGWXCCTH a, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x8ADBF40", Offset = "0x8ADB340", VA = "0x188ADBF40")]
			internal object WUDTMDEOXLE()
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
			public StackTimer<string>.UBFOGWXCCTH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public IDisposable freezePlayerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public VYSMBECYISG playerDespawn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public COFOZRBTHIU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x8AE7A80", Offset = "0x8AE6E80", VA = "0x188AE7A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0x8AE8040", Offset = "0x8AE7440", VA = "0x188AE8040", Slot = "5")]
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
			public COFOZRBTHIU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			public TNRXJFRDOMC operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			private OFEBALTHFAS <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x8AE8530", Offset = "0x8AE7930", VA = "0x188AE8530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0x8AE8E70", Offset = "0x8AE8270", VA = "0x188AE8E70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9900", Offset = "0x8AD8D00", VA = "0x188AD9900")]
		public COFOZRBTHIU(Guid a, MVWEOVUCDOM b, UMTYTQWPZHG c, string d, RequestOperationType e, bool f = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9750", Offset = "0x8AD8B50", VA = "0x188AD9750", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__2))]
		protected override Task FYLEBLVLNXH(TNRXJFRDOMC a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract Task TGLZWOAUBPC(TNRXJFRDOMC a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9610", Offset = "0x8AD8A10", VA = "0x188AD9610")]
		[AsyncStateMachine(typeof(<RespawnPlayer>d__4))]
		private Task CUVAIZIXMKT(IDisposable a, VYSMBECYISG b, StackTimer<string>.UBFOGWXCCTH c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	internal class VFFDNYZJFWY : YHYCZYSLLNF
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
			public VFFDNYZJFWY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public TNRXJFRDOMC operationContext;

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
			[Cpp2IlInjected.Address(RVA = "0x8AE8ED0", Offset = "0x8AE82D0", VA = "0x188AE8ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0x8AE94C0", Offset = "0x8AE88C0", VA = "0x188AE94C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private readonly AutosaveType NGANXIRXXNG;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2640", Offset = "0x8AF1A40", VA = "0x188AF2640")]
		public VFFDNYZJFWY(Guid a, MVWEOVUCDOM b, UMTYTQWPZHG c, AutosaveType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2560", Offset = "0x8AF1960", VA = "0x188AF2560", Slot = "6")]
		protected override string UURUCLRZLWM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2440", Offset = "0x8AF1840", VA = "0x188AF2440", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__3))]
		protected override Task FYLEBLVLNXH(TNRXJFRDOMC a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	internal abstract class YHYCZYSLLNF : DPXMQZFVBRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000128")]
		public delegate Task PostOperationTaskBuilder(StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000129")]
		[CompilerGenerated]
		private sealed class ZAAHAHXLLXD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public StackTimer<string>.UBFOGWXCCTH RFFIUKRWWOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public YHYCZYSLLNF MXVWDMPVVWS;

			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ZAAHAHXLLXD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0x8AF5150", Offset = "0x8AF4550", VA = "0x188AF5150")]
			internal Task LXMVGMIHUJO(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012A")]
		[CompilerGenerated]
		private sealed class YZVADBDOCLU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public Exception HCWNUUPSPGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public ZAAHAHXLLXD AAFJFKGKTGT;

			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public YZVADBDOCLU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x8AF5090", Offset = "0x8AF4490", VA = "0x188AF5090")]
			internal object LYCPYGPZWRP()
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
			[Cpp2IlInjected.Address(RVA = "0x8AE4490", Offset = "0x8AE3890", VA = "0x188AE4490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x8AE4F30", Offset = "0x8AE4330", VA = "0x188AE4F30", Slot = "5")]
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
			public YHYCZYSLLNF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public Func<YHYCZYSLLNF, StackTimer<string>.UBFOGWXCCTH, TNRXJFRDOMC> operationContextBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private ZAAHAHXLLXD <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			private bool <success>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			private TNRXJFRDOMC <operationContext>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private TaskAwaiter<PKIHHHDXEKZ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x8AEE5E0", Offset = "0x8AED9E0", VA = "0x188AEE5E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054D")]
			[Cpp2IlInjected.Address(RVA = "0x8AEF820", Offset = "0x8AEEC20", VA = "0x188AEF820", Slot = "5")]
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
			public YHYCZYSLLNF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0x8AED650", Offset = "0x8AECA50", VA = "0x188AED650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054F")]
			[Cpp2IlInjected.Address(RVA = "0x8AED9B0", Offset = "0x8AECDB0", VA = "0x188AED9B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public readonly Guid AQZOEGFVORU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public readonly ByteString OMPPAEPPZCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public readonly UMTYTQWPZHG UMTYTQWPZHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		protected readonly string XQIKXOPAJHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private readonly MVWEOVUCDOM ITQPEIGRZZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private readonly bool KQVMCSETCFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly Queue<PostOperationTaskBuilder> KVNUMMXYKZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private readonly QXWZURHKUNH JGSMOEZTSDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private readonly RequestOperationType GEDFPVPRFSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private bool TBQGTCAIVIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public RoomOperationState LNXNDEGJQVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public RoomOperationState CIELCYFTKMR;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public MVWEOVUCDOM USCSXKJPLMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public MVZYDDMAODN OJXQDUAJVPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x8AF4380", Offset = "0x8AF3780", VA = "0x188AF4380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public GBQCQYLDPKW RZUUXIUJREV
		{
			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x8AF45F0", Offset = "0x8AF39F0", VA = "0x188AF45F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public INKPZSVDXUP KYYXCPGOJZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0x8AF4550", Offset = "0x8AF3950", VA = "0x188AF4550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event ProgressUpdate PVIPJARHBAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0x8AF4BE0", Offset = "0x8AF3FE0", VA = "0x188AF4BE0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x8AF45D0", Offset = "0x8AF39D0", VA = "0x188AF45D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4D30", Offset = "0x8AF4130", VA = "0x188AF4D30")]
		protected YHYCZYSLLNF(Guid a, MVWEOVUCDOM b, UMTYTQWPZHG c, string d, RequestOperationType e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4810", Offset = "0x8AF3C10", VA = "0x188AF4810", Slot = "6")]
		protected virtual string UURUCLRZLWM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x8AF43D0", Offset = "0x8AF37D0", VA = "0x188AF43D0")]
		public void IDLFLAULLKO(PostOperationTaskBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4360", Offset = "0x8AF3760", VA = "0x188AF4360")]
		protected void FEBPXHBOAAJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF46C0", Offset = "0x8AF3AC0", VA = "0x188AF46C0")]
		[AsyncStateMachine(typeof(<Run>d__30))]
		public Task Run(CancellationToken cancellationToken, StackTimer<string>.UBFOGWXCCTH stackTimer, [Optional] Func<YHYCZYSLLNF, StackTimer<string>.UBFOGWXCCTH, TNRXJFRDOMC> operationContextBuilder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4C00", Offset = "0x8AF4000", VA = "0x188AF4C00")]
		[AsyncStateMachine(typeof(<DriverCombinedTask>d__31))]
		private static Task ZEMPXCXIKZM(Func<CancellationToken, Task> a, Func<CancellationToken, Task> b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF41F0", Offset = "0x8AF35F0", VA = "0x188AF41F0")]
		private void BNTOJSDHMLJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF49C0", Offset = "0x8AF3DC0", VA = "0x188AF49C0")]
		private void WLTKIRQQLVU(TNRXJFRDOMC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract Task FYLEBLVLNXH(TNRXJFRDOMC a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4430", Offset = "0x8AF3830", VA = "0x188AF4430")]
		[AsyncStateMachine(typeof(<RunPostOperationTasks>d__35))]
		private Task KARBNSFMCWI(StackTimer<string>.UBFOGWXCCTH a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4640", Offset = "0x8AF3A40", VA = "0x188AF4640")]
		public PKIHHHDXEKZ QZLDVIDECEB(MessageKind a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x8AF48D0", Offset = "0x8AF3CD0", VA = "0x188AF48D0")]
		[CompilerGenerated]
		private Task WAGUFQRGGNL(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4850", Offset = "0x8AF3C50", VA = "0x188AF4850")]
		[CompilerGenerated]
		private object VZQZNWJOEFK()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	internal sealed class HAQLRVNOEYF : COFOZRBTHIU
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
			public HAQLRVNOEYF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public TNRXJFRDOMC operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private RoomEvent <roomEvent>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			private OFLHOWWQUAV <loadLogic>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x8AEF880", Offset = "0x8AEEC80", VA = "0x188AEF880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x8AEFFE0", Offset = "0x8AEF3E0", VA = "0x188AEFFE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private readonly RoomLoadRequestPayload QMXTCNXZSNC;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x8ADAE20", Offset = "0x8ADA220", VA = "0x188ADAE20")]
		public HAQLRVNOEYF(Guid a, MVWEOVUCDOM b, RoomLoadRequestPayload c, UMTYTQWPZHG d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x8ADACD0", Offset = "0x8ADA0D0", VA = "0x188ADACD0", Slot = "8")]
		[AsyncStateMachine(typeof(<RunWhilePlayerDespawnedAsync>d__2))]
		protected override Task TGLZWOAUBPC(TNRXJFRDOMC a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	internal class XHKXZGEAWFX : YHYCZYSLLNF
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
			public XHKXZGEAWFX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			public TNRXJFRDOMC operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			private TaskAwaiter<RoomSerializedData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x8AE80A0", Offset = "0x8AE74A0", VA = "0x188AE80A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0x8AE8E10", Offset = "0x8AE8210", VA = "0x188AE8E10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private readonly string IBVIRGRDPKH;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x8AF27F0", Offset = "0x8AF1BF0", VA = "0x188AF27F0")]
		public XHKXZGEAWFX(Guid a, MVWEOVUCDOM b, UMTYTQWPZHG c, string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x8AF26E0", Offset = "0x8AF1AE0", VA = "0x188AF26E0", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__2))]
		protected override Task FYLEBLVLNXH(TNRXJFRDOMC a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	internal class RoomSaveToRecNetOperation : COFOZRBTHIU
	{
		[Cpp2IlInjected.Token(Token = "0x2000133")]
		[CompilerGenerated]
		private sealed class AZSYQXSOVDR
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
				public AsyncTaskMethodBuilder<PKIHHHDXEKZ> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40004B1")]
				public AZSYQXSOVDR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40004B2")]
				public CancellationToken masterLockedCodeBlockCancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40004B3")]
				private TaskAwaiter<RoomSerializedData> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40004B4")]
				private TaskAwaiter<PKIHHHDXEKZ> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x8AF16C0", Offset = "0x8AF0AC0", VA = "0x188AF16C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x8AF1BA0", Offset = "0x8AF0FA0", VA = "0x188AF1BA0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			public RoomSaveToRecNetOperation MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public TXHNTTILGBE YYDMLETDYES;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public long FQDOCNUUMMS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004AA")]
			public RoomSaveOptions PKCWSYTECBU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004AB")]
			public RoomUploadLogic YZACSJGLZYL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004AC")]
			public long NNYUMVKIWGT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004AD")]
			public RoomSaveAnalyticsInfo WREASGHAPPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004AE")]
			public StackTimer<string>.UBFOGWXCCTH CKLPRVMXYZN;

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public AZSYQXSOVDR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0x8AD91B0", Offset = "0x8AD85B0", VA = "0x188AD91B0")]
			[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
			internal Task<PKIHHHDXEKZ> JUCKMBJDSLQ(CancellationToken a)
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
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B9")]
			public TNRXJFRDOMC operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			private AZSYQXSOVDR <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004BC")]
			private RoomEvent <roomEvent>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004BD")]
			private OFLHOWWQUAV <loadLogic>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40004BE")]
			private PKIHHHDXEKZ <saveReloadMessage>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			private TaskAwaiter<PKIHHHDXEKZ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x8AF0040", Offset = "0x8AEF440", VA = "0x188AF0040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x8AF0F00", Offset = "0x8AF0300", VA = "0x188AF0F00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private static readonly Log LNPYKRNGQSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private readonly int ORZWTJMMCRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		[CanBeNull]
		private readonly RoomSaveRequestPayload FNIQVCXVIMJ;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1350", Offset = "0x8AE0750", VA = "0x188AE1350")]
		public RoomSaveToRecNetOperation(Guid operationId, MVWEOVUCDOM roomManager, int savingPlayerAccountId, RoomSaveRequestPayload roomSaveRequestPayload, UMTYTQWPZHG operationPauseToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1160", Offset = "0x8AE0560", VA = "0x188AE1160", Slot = "8")]
		[AsyncStateMachine(typeof(<RunWhilePlayerDespawnedAsync>d__5))]
		protected override Task TGLZWOAUBPC(TNRXJFRDOMC a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0EA0", Offset = "0x8AE02A0", VA = "0x188AE0EA0")]
		private void DKVIHGOAGMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0F90", Offset = "0x8AE0390", VA = "0x188AE0F90")]
		private void OGHMFXBBIAS(StackTimer<string>.UBFOGWXCCTH a, RoomEvent b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	internal class XTPTPGMIUHE : YHYCZYSLLNF
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
			public XTPTPGMIUHE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C7")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C8")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

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
			private FSJCTOPLDTG<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

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
			[Cpp2IlInjected.Address(RVA = "0x8AE9520", Offset = "0x8AE8920", VA = "0x188AE9520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x8AEA940", Offset = "0x8AE9D40", VA = "0x188AEA940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private readonly int ORZWTJMMCRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private readonly RoomSaveRequestPayload FNIQVCXVIMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private Func<RoomSerializedData, RoomSerializedData> AJCAHVRPRMW;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4030", Offset = "0x8AF3430", VA = "0x188AF4030")]
		public XTPTPGMIUHE(Guid a, MVWEOVUCDOM b, int c, RoomSaveRequestPayload d, Func<RoomSerializedData, RoomSerializedData> e, UMTYTQWPZHG f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3F00", Offset = "0x8AF3300", VA = "0x188AF3F00", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__4))]
		protected override Task FYLEBLVLNXH(TNRXJFRDOMC a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	internal abstract class UFHENDBPHVR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public readonly YHYCZYSLLNF NXNEEQBUZMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public readonly TNRXJFRDOMC TNRXJFRDOMC;

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public MVZYDDMAODN OJXQDUAJVPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x8AF20B0", Offset = "0x8AF14B0", VA = "0x188AF20B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public INKPZSVDXUP KYYXCPGOJZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x8AF2100", Offset = "0x8AF1500", VA = "0x188AF2100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x8AF22A0", Offset = "0x8AF16A0", VA = "0x188AF22A0")]
		protected UFHENDBPHVR(TNRXJFRDOMC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2190", Offset = "0x8AF1590", VA = "0x188AF2190")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AD9DA0", Offset = "0x8AD91A0", VA = "0x188AD9DA0")]
		public static DeserializationHandlerLists Get(MVZYDDMAODN callbacks, RoomOperationState operationState, IWGQTFVVOBJ deserializationData)
		{
			return default(DeserializationHandlerLists);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	internal struct LogRoomLoadMetrics
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770")]
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
		public bool RMDPOPWBADS
		{
			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x8ADF240", Offset = "0x8ADE640", VA = "0x188ADF240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF2D0", Offset = "0x8ADE6D0", VA = "0x188ADF2D0")]
		public RoomLoadDetails(RoomDetailsDTO roomDetails, SubRoomDTO subRoom, Guid? unityAssetId, IReadOnlyList<BakedUnitySubAssetDTO> unitySubAssets, IReadOnlyCollection<BakedUnitySubAssetDTO> referencedUnityAssets, FilenameWithHash superRoomData, FilenameWithHash subRoomData, RoomLoadDTO roomLoad)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	internal struct RoomLoadLifetime : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private readonly TNRXJFRDOMC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private readonly Guid sliceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private bool success;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF5B0", Offset = "0x8ADE9B0", VA = "0x188ADF5B0")]
		public static RoomLoadLifetime TVOINTCSGHL(TNRXJFRDOMC a)
		{
			return default(RoomLoadLifetime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x10A5EF0", Offset = "0x10A52F0", VA = "0x1810A5EF0")]
		public void IEEEDVTXOME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF380", Offset = "0x8ADE780", VA = "0x188ADF380", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF680", Offset = "0x8ADEA80", VA = "0x188ADF680")]
		private RoomLoadLifetime(TNRXJFRDOMC operationContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF390", Offset = "0x8ADE790", VA = "0x188ADF390")]
		private void RLEYEVGAQAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF5E0", Offset = "0x8ADE9E0", VA = "0x188ADF5E0")]
		private Func<Guid, bool> UGFLBSJKCBT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	internal class OFLHOWWQUAV : UFHENDBPHVR, DPXMQZFVBRE
	{
		[Cpp2IlInjected.Token(Token = "0x200013F")]
		public delegate Task<RoomOperationState> RoomLoadFunction(IWGQTFVVOBJ data, JPVRQJDLBNH yielder, QXWZURHKUNH progressTracker, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000141")]
		[CompilerGenerated]
		private sealed class EMQMBTNNLSE
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
				public EMQMBTNNLSE <>4__this;

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
				[Cpp2IlInjected.Address(RVA = "0x8B0B0C0", Offset = "0x8B0A4C0", VA = "0x188B0B0C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0x8B0B980", Offset = "0x8B0AD80", VA = "0x188B0B980", Slot = "5")]
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
				public AsyncTaskMethodBuilder<IWGQTFVVOBJ> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000505")]
				public EMQMBTNNLSE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000506")]
				public CancellationToken innerCancellation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000507")]
				private IWGQTFVVOBJ <innerPhaseArgs>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000508")]
				private TaskAwaiter<RoomOperationState> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000509")]
				private TaskAwaiter<IWGQTFVVOBJ> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x8B0B9F0", Offset = "0x8B0ADF0", VA = "0x188B0B9F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x8B0C030", Offset = "0x8B0B430", VA = "0x188B0C030", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public OFLHOWWQUAV MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public RoomLoadRequestPayload TTZFEWZQVQP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public QXWZURHKUNH FEKLRKXOSIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public StackTimer<string>.UBFOGWXCCTH CKLPRVMXYZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public QXWZURHKUNH OQGDTPVUFSR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			public RoomLoadDetails LYKVCINIYGS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			public QXWZURHKUNH UKUEQCYQXVF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			public IWGQTFVVOBJ BTEVTRCPBRG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public RecNet.Core.OnDownloadProgressDelegate GRZKAULEUBS;

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EMQMBTNNLSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7400", Offset = "0x8AF6800", VA = "0x188AF7400")]
			[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
			internal Task<RoomLoadDetails> AXCQXXOIEUV(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x8AF72E0", Offset = "0x8AF66E0", VA = "0x188AF72E0")]
			[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
			internal Task<IWGQTFVVOBJ> AWSDDKANLYD(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0x8AF72A0", Offset = "0x8AF66A0", VA = "0x188AF72A0")]
			internal void AWHPIWMSTBL(long a, long b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7220", Offset = "0x8AF6620", VA = "0x188AF7220")]
			internal Task AVRURCFAQTK(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7260", Offset = "0x8AF6660", VA = "0x188AF7260")]
			internal Task AVXBOIYYAET(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000144")]
		[CompilerGenerated]
		private sealed class KNMQBDYYTAY
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
				public KNMQBDYYTAY <>4__this;

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
				[Cpp2IlInjected.Address(RVA = "0x8B0C0A0", Offset = "0x8B0B4A0", VA = "0x188B0C0A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B4")]
				[Cpp2IlInjected.Address(RVA = "0x8B0C550", Offset = "0x8B0B950", VA = "0x188B0C550", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			public OFLHOWWQUAV MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400050B")]
			public RoomLoadFunction GZIVTAMKPWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public IWGQTFVVOBJ LYKVCINIYGS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public JPVRQJDLBNH ZPYJHQAEBIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public QXWZURHKUNH GGDONEXFYHR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			public StackTimer<string>.UBFOGWXCCTH CKLPRVMXYZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public RoomOperationState BERKHSKOFDN;

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public KNMQBDYYTAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0x8AF8F40", Offset = "0x8AF8340", VA = "0x188AF8F40")]
			[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
			internal Task<RoomOperationState> ZSVVZAZXFFW(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000146")]
		[CompilerGenerated]
		private sealed class HSPFGAXWSUM
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
				public HSPFGAXWSUM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400051C")]
				public IWGQTFVVOBJ data;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400051D")]
				public QXWZURHKUNH progressTracker;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400051E")]
				public StackTimer<string>.UBFOGWXCCTH stackTimer;

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
				[Cpp2IlInjected.Address(RVA = "0x8B0C5C0", Offset = "0x8B0B9C0", VA = "0x188B0C5C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B8")]
				[Cpp2IlInjected.Address(RVA = "0x8B0D090", Offset = "0x8B0C490", VA = "0x188B0D090", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			public OFLHOWWQUAV MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			public ZVJVNZNPIPZ XFJPSDQBCMK;

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public HSPFGAXWSUM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x8AF8B70", Offset = "0x8AF7F70", VA = "0x188AF8B70")]
			[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
			internal Task<RoomOperationState> USVHEZMWRPH(IWGQTFVVOBJ a, JPVRQJDLBNH b, QXWZURHKUNH c, StackTimer<string>.UBFOGWXCCTH d, CancellationToken e)
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
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x8AF9F50", Offset = "0x8AF9350", VA = "0x188AF9F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x8AFA170", Offset = "0x8AF9570", VA = "0x188AFA170", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public QXWZURHKUNH progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public JPVRQJDLBNH timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			private StackTimer<string>.UBFOGWXCCTH <deserializeAllObjectsTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x8AFA860", Offset = "0x8AF9C60", VA = "0x188AFA860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x8AFB970", Offset = "0x8AFAD70", VA = "0x188AFB970", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			public QXWZURHKUNH progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private StackTimer<string>.UBFOGWXCCTH <deserializeAllObjectsTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400053C")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x8AFA1D0", Offset = "0x8AF95D0", VA = "0x188AFA1D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x8AFA7F0", Offset = "0x8AF9BF0", VA = "0x188AFA7F0", Slot = "5")]
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
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

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
			[Cpp2IlInjected.Address(RVA = "0x8AFB9E0", Offset = "0x8AFADE0", VA = "0x188AFB9E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x8AFBCD0", Offset = "0x8AFB0D0", VA = "0x188AFBCD0", Slot = "5")]
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
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0x8AFBD30", Offset = "0x8AFB130", VA = "0x188AFBD30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC130", Offset = "0x8AFB530", VA = "0x188AFC130", Slot = "5")]
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
			public AsyncTaskMethodBuilder<PKIHHHDXEKZ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private StackTimer<string>.UBFOGWXCCTH <syncTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			private TaskAwaiter<PKIHHHDXEKZ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x8AFDD40", Offset = "0x8AFD140", VA = "0x188AFDD40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE170", Offset = "0x8AFD570", VA = "0x188AFE170", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			public QXWZURHKUNH progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			private StackTimer<string>.UBFOGWXCCTH <legacyLoadRoomDataTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE1E0", Offset = "0x8AFD5E0", VA = "0x188AFE1E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x8AFEA20", Offset = "0x8AFDE20", VA = "0x188AFEA20", Slot = "5")]
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
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			public CancellationToken externalCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			private EMQMBTNNLSE <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			private TaskAwaiter<RoomLoadDetails> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			private TaskAwaiter<IWGQTFVVOBJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x8AFEFA0", Offset = "0x8AFE3A0", VA = "0x188AFEFA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x8AFFBE0", Offset = "0x8AFEFE0", VA = "0x188AFFBE0", Slot = "5")]
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
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			private StackTimer<string>.UBFOGWXCCTH <loadRoomLocalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x8AFEA80", Offset = "0x8AFDE80", VA = "0x188AFEA80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x8AFEF40", Offset = "0x8AFE340", VA = "0x188AFEF40", Slot = "5")]
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
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			public RoomLoadFunction masterLockedCode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			public JPVRQJDLBNH timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000576")]
			public QXWZURHKUNH progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

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
			[Cpp2IlInjected.Address(RVA = "0x8AFFC40", Offset = "0x8AFF040", VA = "0x188AFFC40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x8B00150", Offset = "0x8AFF550", VA = "0x188B00150", Slot = "5")]
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
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public QXWZURHKUNH progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

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
			[Cpp2IlInjected.Address(RVA = "0x8B001C0", Offset = "0x8AFF5C0", VA = "0x188B001C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x8B00720", Offset = "0x8AFFB20", VA = "0x188B00720", Slot = "5")]
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
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			public RoomOperationState operationState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			public QXWZURHKUNH progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400058A")]
			public IWGQTFVVOBJ deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

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
			[Cpp2IlInjected.Address(RVA = "0x8B00780", Offset = "0x8AFFB80", VA = "0x188B00780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x8B009D0", Offset = "0x8AFFDD0", VA = "0x188B009D0", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public QXWZURHKUNH progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			private StackTimer<string>.UBFOGWXCCTH <destroyAndRebuildObjectsTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x8B00A40", Offset = "0x8AFFE40", VA = "0x188B00A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x8B01A00", Offset = "0x8B00E00", VA = "0x188B01A00", Slot = "5")]
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
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			public IWGQTFVVOBJ phaseArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			public QXWZURHKUNH postDownloadProgress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005A1")]
			private TaskAwaiter<RoomOperationState> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			private JPVRQJDLBNH <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x8B01A70", Offset = "0x8B00E70", VA = "0x188B01A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x8B028A0", Offset = "0x8B01CA0", VA = "0x188B028A0", Slot = "5")]
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
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			public IWGQTFVVOBJ phaseArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public QXWZURHKUNH postDownloadProgress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			private HSPFGAXWSUM <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005AB")]
			private JPVRQJDLBNH <timedYielder>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005AC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005AD")]
			private TaskAwaiter<RoomOperationState> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x8B02900", Offset = "0x8B01D00", VA = "0x188B02900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0x8B03710", Offset = "0x8B02B10", VA = "0x188B03710", Slot = "5")]
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
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005B2")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005B3")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005B4")]
			private RoomLoadLifetime <lifetime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			private TaskAwaiter<PKIHHHDXEKZ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x8B096D0", Offset = "0x8B08AD0", VA = "0x188B096D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x8B09E10", Offset = "0x8B09210", VA = "0x188B09E10", Slot = "5")]
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
			public OFLHOWWQUAV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005BA")]
			public StackTimer<string>.UBFOGWXCCTH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005BB")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005BC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x8B09E70", Offset = "0x8B09270", VA = "0x188B09E70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x8B0A650", Offset = "0x8B09A50", VA = "0x188B0A650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private readonly Token TPPUKVKJVBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private readonly Token PBBWWZOUJZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private readonly SJYCKVQRDLU PHGJRPPYMWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private readonly MVKKMFLHVOM YBCWOJGSEHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private readonly MoveToPhaseTask CTDHQUHZMRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private ProfilerCounterValue<int> KUUBHJUCGRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private readonly BZOAUXCEPQY SCHRVNVQVYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private readonly DBSTIRSNXRY PPSWLAIGZTU;

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		private MVWEOVUCDOM USCSXKJPLMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0x8ADD210", Offset = "0x8ADC610", VA = "0x188ADD210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event ProgressUpdate PVIPJARHBAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x8ADDBB0", Offset = "0x8ADCFB0", VA = "0x188ADDBB0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0x8ADCA20", Offset = "0x8ADBE20", VA = "0x188ADCA20", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x8ADDBD0", Offset = "0x8ADCFD0", VA = "0x188ADDBD0")]
		public OFLHOWWQUAV(TNRXJFRDOMC a, DBSTIRSNXRY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD330", Offset = "0x8ADC730", VA = "0x188ADD330")]
		[AsyncStateMachine(typeof(<SyncLoadRoom>d__17))]
		public Task PTYFGRORDLM(RoomLoadRequestPayload a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD7A0", Offset = "0x8ADCBA0", VA = "0x188ADD7A0")]
		[AsyncStateMachine(typeof(<GetSyncedRoomLoadPayload>d__18))]
		private Task<PKIHHHDXEKZ> WVQMCBMVUIT(RoomLoadRequestPayload a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCF50", Offset = "0x8ADC350", VA = "0x188ADCF50")]
		[AsyncStateMachine(typeof(<LoadRoomLocalTimed>d__19))]
		private Task NREKFPFDPJB(RoomLoadRequestPayload a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCB90", Offset = "0x8ADBF90", VA = "0x188ADCB90")]
		[AsyncStateMachine(typeof(<LoadRoomLocal>d__20))]
		private Task LoadRoomLocal(RoomLoadRequestPayload request, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken externalCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD900", Offset = "0x8ADCD00", VA = "0x188ADD900")]
		[AsyncStateMachine(typeof(<RoomV1LoadLogic>d__21))]
		private Task YBZCCEQYKGW(IWGQTFVVOBJ a, QXWZURHKUNH b, StackTimer<string>.UBFOGWXCCTH c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD4C0", Offset = "0x8ADC8C0", VA = "0x188ADD4C0")]
		[AsyncStateMachine(typeof(<TriggerBigDataNetworkManager>d__22))]
		private Task PYNWKUNHWYF(StackTimer<string>.UBFOGWXCCTH a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCA40", Offset = "0x8ADBE40", VA = "0x188ADCA40")]
		[AsyncStateMachine(typeof(<LegacyLoadRoomData>d__23))]
		private Task LegacyLoadRoomData(IWGQTFVVOBJ data, QXWZURHKUNH progressTracker, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC730", Offset = "0x8ADBB30", VA = "0x188ADC730")]
		[AsyncStateMachine(typeof(<RoomV1DestroyAndRebuildObjects>d__24))]
		private Task<RoomOperationState> GKDVXDMNEBE(IWGQTFVVOBJ a, JPVRQJDLBNH b, QXWZURHKUNH c, StackTimer<string>.UBFOGWXCCTH d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC150", Offset = "0x8ADB550", VA = "0x188ADC150")]
		[AsyncStateMachine(typeof(<DeserializeAllObjects>d__25))]
		private Task<RoomOperationState> DeserializeAllObjects(IWGQTFVVOBJ data, JPVRQJDLBNH timedYielder, QXWZURHKUNH progressTracker, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD090", Offset = "0x8ADC490", VA = "0x188ADD090")]
		[AsyncStateMachine(typeof(<MoveToPhase>d__26))]
		private Task<RoomOperationState> OLZAQBRQSCB(RoomOperationState a, IWGQTFVVOBJ b, QXWZURHKUNH c, StackTimer<string>.UBFOGWXCCTH d, CancellationToken e, bool f = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCCD0", Offset = "0x8ADC0D0", VA = "0x188ADCCD0")]
		private bool MJUUGLSUNWK(IWGQTFVVOBJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCDC0", Offset = "0x8ADC1C0", VA = "0x188ADCDC0")]
		[AsyncStateMachine(typeof(<MasterLockedPhaseChangeBlock>d__28))]
		protected Task<RoomOperationState> MasterLockedPhaseChangeBlock(IWGQTFVVOBJ data, JPVRQJDLBNH timedYielder, QXWZURHKUNH progressTracker, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken, RoomLoadFunction masterLockedCode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD610", Offset = "0x8ADCA10", VA = "0x188ADD610")]
		[AsyncStateMachine(typeof(<MoveThroughRemainingPhases>d__29))]
		private Task QDIJPGPHYCM(IWGQTFVVOBJ a, QXWZURHKUNH b, StackTimer<string>.UBFOGWXCCTH c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC9D0", Offset = "0x8ADBDD0", VA = "0x188ADC9D0")]
		private void LBLUPYQHBXL(RoomOperationState a, QXWZURHKUNH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC110", Offset = "0x8ADB510", VA = "0x188ADC110")]
		private void DSCUPQSSVWC(RoomOperationState a, [Out] RoomOperationState b, [Out] RoomOperationState c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD760", Offset = "0x8ADCB60", VA = "0x188ADD760")]
		private Task<RoomLoadDetails> UTTPNWGPWYN(RoomLoadRequestPayload a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD480", Offset = "0x8ADC880", VA = "0x188ADD480")]
		private Task<IWGQTFVVOBJ> PXVNSBSWEVV(RoomLoadDetails a, RecNet.Core.OnDownloadProgressDelegate b, StackTimer<string>.UBFOGWXCCTH c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC350", Offset = "0x8ADB750", VA = "0x188ADC350")]
		[AsyncStateMachine(typeof(<DestroyOldObjects>d__34))]
		private Task DestroyOldObjects(IWGQTFVVOBJ data, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken, bool useCompletionMark = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD240", Offset = "0x8ADC640", VA = "0x188ADD240")]
		[AsyncStateMachine(typeof(<CreateCV1Mappings>d__35))]
		private Task PSOYASQGTKF(IWGQTFVVOBJ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC320", Offset = "0x8ADB720", VA = "0x188ADC320")]
		private Task DeserializeSettings(IWGQTFVVOBJ data, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC9B0", Offset = "0x8ADBDB0", VA = "0x188ADC9B0")]
		private Task InstantiateObjects(IWGQTFVVOBJ data, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD5F0", Offset = "0x8ADC9F0", VA = "0x188ADD5F0")]
		private Task PreDeserializeObjects(IWGQTFVVOBJ data, JPVRQJDLBNH timedYielder, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC300", Offset = "0x8ADB700", VA = "0x188ADC300")]
		private Task DeserializeObjects(IWGQTFVVOBJ data, JPVRQJDLBNH timedYielder, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC2D0", Offset = "0x8ADB6D0", VA = "0x188ADC2D0")]
		private static Task DeserializeConnectables(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD5D0", Offset = "0x8ADC9D0", VA = "0x188ADD5D0")]
		private Task PostDeserializeObjects(IWGQTFVVOBJ data, JPVRQJDLBNH timedYielder, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC2E0", Offset = "0x8ADB6E0", VA = "0x188ADC2E0")]
		private Task DeserializeObjectsComplete(IWGQTFVVOBJ data, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC010", Offset = "0x8ADB410", VA = "0x188ADC010")]
		private void AQPKFZQWQEG(RoomLoadRequestPayload a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC060", Offset = "0x8ADB460", VA = "0x188ADC060")]
		public void BNEZANTBTMQ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		private static void VWNCQSZVOAX(RoomDetailsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC5E0", Offset = "0x8ADB9E0", VA = "0x188ADC5E0")]
		[AsyncStateMachine(typeof(<RoomV2LoadLogic>d__46))]
		private Task GDGUUBYEQER(IWGQTFVVOBJ a, QXWZURHKUNH b, StackTimer<string>.UBFOGWXCCTH c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC4A0", Offset = "0x8ADB8A0", VA = "0x188ADC4A0")]
		[AsyncStateMachine(typeof(<DestroyR1Objects>d__47))]
		private Task EQSCPDHBXSD(IWGQTFVVOBJ a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC890", Offset = "0x8ADBC90", VA = "0x188ADC890")]
		private static SerializedDataWrapper IQFPYFSRZIQ(IWGQTFVVOBJ a)
		{
			return default(SerializedDataWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADDA50", Offset = "0x8ADCE50", VA = "0x188ADDA50")]
		[AsyncStateMachine(typeof(<DeserializeAllObjectsR2>d__49))]
		private Task<RoomOperationState> YETCTICJHWU(IWGQTFVVOBJ a, JPVRQJDLBNH b, QXWZURHKUNH c, StackTimer<string>.UBFOGWXCCTH d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		private void IHIIKMOKHET(RoomOperationState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	internal struct CreateCV1MappingsTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private MVWEOVUCDOM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private IWGQTFVVOBJ data;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		private MVZYDDMAODN OJXQDUAJVPU
		{
			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x8AF5C90", Offset = "0x8AF5090", VA = "0x188AF5C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5CE0", Offset = "0x8AF50E0", VA = "0x188AF5CE0")]
		public static Task Run(MVWEOVUCDOM roomManager, IWGQTFVVOBJ data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5DC0", Offset = "0x8AF51C0", VA = "0x188AF5DC0")]
		private void Run()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	internal struct DeserializeConnectablesTask
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5FD0", Offset = "0x8AF53D0", VA = "0x188AF5FD0")]
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
			public TNRXJFRDOMC operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005C2")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005C3")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005C4")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			private StackTimer<string>.UBFOGWXCCTH <outboundTrafficTimer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x8B04430", Offset = "0x8B03830", VA = "0x188B04430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0x8B05890", Offset = "0x8B04C90", VA = "0x188B05890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8AF60B0", Offset = "0x8AF54B0", VA = "0x188AF60B0")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(TNRXJFRDOMC operationContext, IWGQTFVVOBJ data, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken)
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
			public TNRXJFRDOMC operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005CE")]
			public JPVRQJDLBNH timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005CF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005D0")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005D1")]
			private MVWEOVUCDOM <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005D2")]
			private MVZYDDMAODN <callbacks>5__3;

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
			private List<(PersistenceView, BMALMPEIUXS)>.Enumerator <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			private PersistenceView <view>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			private BMALMPEIUXS <viewData>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x8B03770", Offset = "0x8B02B70", VA = "0x188B03770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x8B05770", Offset = "0x8B04B70", VA = "0x188B05770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x8AF63D0", Offset = "0x8AF57D0", VA = "0x188AF63D0")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(TNRXJFRDOMC operationContext, IWGQTFVVOBJ data, JPVRQJDLBNH timedYielder, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x8AF61F0", Offset = "0x8AF55F0", VA = "0x188AF61F0")]
		private static void BDJDMAIQCUA(PersistenceView a, BMALMPEIUXS b, IWGQTFVVOBJ c, RoomOperationState d, bool e)
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
			public MVWEOVUCDOM roomManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			public IWGQTFVVOBJ data;

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
			[Cpp2IlInjected.Address(RVA = "0x8B04960", Offset = "0x8B03D60", VA = "0x188B04960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x8B057D0", Offset = "0x8B04BD0", VA = "0x188B057D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6520", Offset = "0x8AF5920", VA = "0x188AF6520")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(MVWEOVUCDOM roomManager, IWGQTFVVOBJ data, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	internal struct DestroyOldObjectsTask
	{
		[Cpp2IlInjected.Token(Token = "0x2000163")]
		[CompilerGenerated]
		private sealed class MWLHREALRTF
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
				public StackTimer<string>.UBFOGWXCCTH timer;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40005EB")]
				public CancellationToken token;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40005EC")]
				public MWLHREALRTF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40005ED")]
				private StackTimer<string>.UBFOGWXCCTH <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40005EE")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60005F5")]
				[Cpp2IlInjected.Address(RVA = "0x8B0D100", Offset = "0x8B0C500", VA = "0x188B0D100", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005F6")]
				[Cpp2IlInjected.Address(RVA = "0x8B0D490", Offset = "0x8B0C890", VA = "0x188B0D490", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005E7")]
			public Task BKFPXHUYBAO;

			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public MWLHREALRTF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x8AF9590", Offset = "0x8AF8990", VA = "0x188AF9590")]
			[AsyncStateMachine(typeof(<<Run>b__0>d))]
			internal Task LXSCDTCFDUX(StackTimer<string>.UBFOGWXCCTH a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000165")]
		[CompilerGenerated]
		private sealed class RPXDXIRZXRW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005EF")]
			public DEPRECATED_RoomPersistenceVersion version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40005F0")]
			public bool PYVCEXFDXLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005F1")]
			public List<PersistenceView> FHGTQEYKNTZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F2")]
			public List<GameObject> JLEUOZSHHQL;

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public RPXDXIRZXRW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x8AF9DC0", Offset = "0x8AF91C0", VA = "0x188AF9DC0")]
			internal object KBBKIRSLYEN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x8AF9D10", Offset = "0x8AF9110", VA = "0x188AF9D10")]
			internal object KAWDLKYOOTE()
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
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

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
			private TaskAwaiter<PKIHHHDXEKZ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x8B058F0", Offset = "0x8B04CF0", VA = "0x188B058F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x8B064E0", Offset = "0x8B058E0", VA = "0x188B064E0", Slot = "5")]
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
			public MVWEOVUCDOM roomManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000601")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000602")]
			public TNRXJFRDOMC operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000603")]
			public bool useCompletionMark;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000604")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000605")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000606")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x8B08450", Offset = "0x8B07850", VA = "0x188B08450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x8B08660", Offset = "0x8B07A60", VA = "0x188B08660", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private MVWEOVUCDOM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private IWGQTFVVOBJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private TNRXJFRDOMC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private bool useCompletionMark;

		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private static readonly ByteString destroyObjectsGuid;

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		private MVZYDDMAODN OJXQDUAJVPU
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6DE0", Offset = "0x8AF61E0", VA = "0x188AF6DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		private INKPZSVDXUP KYYXCPGOJZA
		{
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E70", Offset = "0x8AF6270", VA = "0x188AF6E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6F10", Offset = "0x8AF6310", VA = "0x188AF6F10")]
		[AsyncStateMachine(typeof(<Run>d__5))]
		public static Task Run(MVWEOVUCDOM roomManager, IWGQTFVVOBJ data, TNRXJFRDOMC operationContext, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken, bool useCompletionMark)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7060", Offset = "0x8AF6460", VA = "0x188AF7060")]
		[AsyncStateMachine(typeof(<Run>d__10))]
		private Task Run(StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6640", Offset = "0x8AF5A40", VA = "0x188AF6640")]
		private void DestroyActivePersistenceViews([NotNull] PersistedRoomData downloadedRoomData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E30", Offset = "0x8AF6230", VA = "0x188AF6E30")]
		private bool IYMTOPUQXZC(DEPRECATED_RoomPersistenceVersion a, PersistedRoomData b)
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
			public AsyncTaskMethodBuilder<Result<CQILIXUWHJF, GKLIEWNFSHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			public StackTimer<string>.UBFOGWXCCTH downloadTimerScope;

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
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000623")]
			private TaskAwaiter<Result<CQILIXUWHJF, GKLIEWNFSHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC190", Offset = "0x8AFB590", VA = "0x188AFC190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC7F0", Offset = "0x8AFBBF0", VA = "0x188AFC7F0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<IWGQTFVVOBJ> <>t__builder;

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
			private StackTimer<string>.UBFOGWXCCTH <downloadTimerScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400062B")]
			private TaskAwaiter<IReadOnlyCollection<BakedUnitySubAssetDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400062C")]
			private TaskAwaiter<(Result<CQILIXUWHJF, GKLIEWNFSHL>, Result<ParseResult<PersistedRoomData>, GKLIEWNFSHL>, Result<ParseResult<SuperRoomData>, GKLIEWNFSHL>, Result<ParseResult<IEnumerable<RoomAssetData>>, GKLIEWNFSHL>, Result<ParseResult<YVWXGRBPFFE>, GKLIEWNFSHL>)> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x8B06A00", Offset = "0x8B05E00", VA = "0x188B06A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x8B07710", Offset = "0x8B06B10", VA = "0x188B07710", Slot = "5")]
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
		private VersionedDataGetter<long, YVWXGRBPFFE> playerSaveGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private TQVYXWPXNJF subRoomAssetBundleProvider;

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
		private StackTimer<string>.UBFOGWXCCTH timer;

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x8AF77F0", Offset = "0x8AF6BF0", VA = "0x188AF77F0")]
		public static Task<IWGQTFVVOBJ> JNDJKPZJRQW(MVWEOVUCDOM a, [In] RoomLoadDetails data, RecNet.Core.OnDownloadProgressDelegate b, StackTimer<string>.UBFOGWXCCTH c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7C90", Offset = "0x8AF7090", VA = "0x188AF7C90")]
		[AsyncStateMachine(typeof(<Run>d__16))]
		private Task<IWGQTFVVOBJ> Run(RecNet.Core.OnDownloadProgressDelegate downloadProgressCallback, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x8AF75C0", Offset = "0x8AF69C0", VA = "0x188AF75C0")]
		[AsyncStateMachine(typeof(<DownloadAssetBundles>d__17))]
		private Task<Result<CQILIXUWHJF, GKLIEWNFSHL>> APXXVZNWHPZ(Guid? a, IReadOnlyCollection<BakedUnitySubAssetDTO> b, IReadOnlyCollection<BakedUnitySubAssetDTO> c, long? d, long? e, RecNet.Core.OnDownloadProgressDelegate f, StackTimer<string>.UBFOGWXCCTH g, CancellationToken h)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	internal struct FetchRoomLoadDetailsTask
	{
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		[CompilerGenerated]
		private sealed class RMIVDUUSKIG
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
				public RMIVDUUSKIG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000649")]
				private StackTimer<string>.UBFOGWXCCTH <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400064A")]
				private TaskAwaiter<RemoteRunDTO> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400064B")]
				private TaskAwaiter<SubRoomDataSaveWithUnityAssetsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600060E")]
				[Cpp2IlInjected.Address(RVA = "0x8B0A6B0", Offset = "0x8B09AB0", VA = "0x188B0A6B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600060F")]
				[Cpp2IlInjected.Address(RVA = "0x8B0B060", Offset = "0x8B0A460", VA = "0x188B0B060", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000637")]
			public long BXBUBHISUKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000638")]
			public string HQAKWDULZJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			public PITYKGBNJVB UKZAXWGWQIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			public StackTimer<string>.UBFOGWXCCTH CKLPRVMXYZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			public MVZYDDMAODN GTVBHFZJJCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			public CancellationToken UJYJWIIBMHU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			public Guid? FWVMBNEJLYM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400063E")]
			public FilenameWithHash BYFZGQIXBWC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400063F")]
			public FilenameWithHash WOYJFMHUQXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			public long IZWCUDEEGPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			public long DIVZDKJHDRC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			public IReadOnlyList<BakedUnitySubAssetDTO> KNXHNNZVYDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000643")]
			public IReadOnlyList<BakedUnitySubAssetDTO> CEADWZEYTFR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000644")]
			public Guid UYXTJCREDAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			public RoomDetailsDTO NSTBPZVOYSB;

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public RMIVDUUSKIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x1039250", Offset = "0x1038650", VA = "0x181039250")]
			internal bool NLLXUGCCIUX(SubRoomDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x8AF9C40", Offset = "0x8AF9040", VA = "0x188AF9C40")]
			[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
			internal Task PBPMASJEIGK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x8AF9A40", Offset = "0x8AF8E40", VA = "0x188AF9A40")]
			internal Task<RoomLoadDTO> AMXROSTTMPW()
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
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			private TaskAwaiter<RoomLoadDetails> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC860", Offset = "0x8AFBC60", VA = "0x188AFC860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCCE0", Offset = "0x8AFC0E0", VA = "0x188AFCCE0", Slot = "5")]
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
			public PITYKGBNJVB roomLoadDataProviderOverride;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000657")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000658")]
			public MVZYDDMAODN callbacks;

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
			private RMIVDUUSKIG <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400065F")]
			private SubRoomDTO <subroom>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000660")]
			private Task<RoomLoadDTO> <getRoomLoadDTOTask>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000661")]
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap3;

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
			[Cpp2IlInjected.Address(RVA = "0x8AFCD50", Offset = "0x8AFC150", VA = "0x188AFCD50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x8AFDCD0", Offset = "0x8AFD0D0", VA = "0x188AFDCD0", Slot = "5")]
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
			private StackTimer<string>.UBFOGWXCCTH <subTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400066A")]
			private TaskAwaiter<RoomLoadDetails> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x8B06540", Offset = "0x8B05940", VA = "0x188B06540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0x8B06990", Offset = "0x8B05D90", VA = "0x188B06990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private MVZYDDMAODN callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private SJYCKVQRDLU debugRoomLoadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private PITYKGBNJVB roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private StackTimer<string>.UBFOGWXCCTH timer;

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
		[Cpp2IlInjected.Address(RVA = "0x8AF7E70", Offset = "0x8AF7270", VA = "0x188AF7E70")]
		public static Task<RoomLoadDetails> JNDJKPZJRQW(MVWEOVUCDOM a, RoomLoadRequestPayload b, StackTimer<string>.UBFOGWXCCTH c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x8AF80C0", Offset = "0x8AF74C0", VA = "0x188AF80C0")]
		[AsyncStateMachine(typeof(<Run>d__11))]
		private Task<RoomLoadDetails> Run(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8210", Offset = "0x8AF7610", VA = "0x188AF8210")]
		[AsyncStateMachine(typeof(<FetchRoomLoadDetails>d__12))]
		private Task<RoomLoadDetails> UTTPNWGPWYN(StackTimer<string>.UBFOGWXCCTH a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8380", Offset = "0x8AF7780", VA = "0x188AF8380")]
		[AsyncStateMachine(typeof(<FetchRoomLoadDetails>d__13))]
		private static Task<RoomLoadDetails> UTTPNWGPWYN(MVZYDDMAODN a, PITYKGBNJVB b, long c, long d, long e, string f, FilenameWithHash g, Guid h, CancellationToken i, StackTimer<string>.UBFOGWXCCTH j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7E40", Offset = "0x8AF7240", VA = "0x188AF7E40")]
		private void CTRUJGAKIXV(RoomDetailsDTO a)
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
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000678")]
			private float <nextResendTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x8B08720", Offset = "0x8B07B20", VA = "0x188B08720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0x8B08CB0", Offset = "0x8B080B0", VA = "0x188B08CB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private MVZYDDMAODN callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private IWGQTFVVOBJ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private StackTimer<string>.UBFOGWXCCTH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private float resendInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private float maxWaitEndTime;

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8680", Offset = "0x8AF7A80", VA = "0x188AF8680")]
		public static Task FFJZJMUYJOA(MVWEOVUCDOM a, IWGQTFVVOBJ b, StackTimer<string>.UBFOGWXCCTH c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8A50", Offset = "0x8AF7E50", VA = "0x188AF8A50")]
		[AsyncStateMachine(typeof(<Run>d__8))]
		public Task Run(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8550", Offset = "0x8AF7950", VA = "0x188AF8550")]
		private static void BFLRDXBNSCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x8AF88E0", Offset = "0x8AF7CE0", VA = "0x188AF88E0")]
		private void HWGMZUBYJKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8820", Offset = "0x8AF7C20", VA = "0x188AF8820")]
		private static float HITYNKQCKVG(MVZYDDMAODN a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8A30", Offset = "0x8AF7E30", VA = "0x188AF8A30")]
		private static float LCVOBGCUZRJ()
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
			public TNRXJFRDOMC operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400067D")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000680")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			private YHYCZYSLLNF <operation>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000682")]
			private MVWEOVUCDOM <roomManager>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000683")]
			private PreInstantiateObjectsTask.Results <instantiations>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000684")]
			private TaskAwaiter<PKIHHHDXEKZ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000685")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x8B04F80", Offset = "0x8B04380", VA = "0x188B04F80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x8B05830", Offset = "0x8B04C30", VA = "0x188B05830", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B0D8A0", Offset = "0x8B0CCA0", VA = "0x188B0D8A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x8B0DBD0", Offset = "0x8B0CFD0", VA = "0x188B0DBD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8D40", Offset = "0x8AF8140", VA = "0x188AF8D40")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(TNRXJFRDOMC operationContext, IWGQTFVVOBJ data, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8CD0", Offset = "0x8AF80D0", VA = "0x188AF8CD0")]
		private static Task<PKIHHHDXEKZ> RGIDYBBOPSC(TNRXJFRDOMC a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8E80", Offset = "0x8AF8280", VA = "0x188AF8E80")]
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
		private sealed class EOXEHAWLLLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400068E")]
			public string CFXXASOJHPT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400068F")]
			public bool FIDTNBPBKFC;

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EOXEHAWLLLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062E")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7550", Offset = "0x8AF6950", VA = "0x188AF7550")]
			internal object OVVBHIDABZR()
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
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000694")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000695")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x8B07CC0", Offset = "0x8B070C0", VA = "0x188B07CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x8B086C0", Offset = "0x8B07AC0", VA = "0x188B086C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B09200", Offset = "0x8B08600", VA = "0x188B09200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x8B09670", Offset = "0x8B08A70", VA = "0x188B09670", Slot = "5")]
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
		private StackTimer<string>.UBFOGWXCCTH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private MVWEOVUCDOM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9060", Offset = "0x8AF8460", VA = "0x188AF9060")]
		public static Task LoadEmptyScene(MVWEOVUCDOM roomManager, bool isOffline, StackTimer<string>.UBFOGWXCCTH timer, CancellationToken roomCancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9200", Offset = "0x8AF8600", VA = "0x188AF9200")]
		[AsyncStateMachine(typeof(<Run>d__5))]
		private Task Run()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF90D0", Offset = "0x8AF84D0", VA = "0x188AF90D0")]
		[AsyncStateMachine(typeof(<SafeLoadSceneAsync>d__6))]
		private Task QIRNTTYLNBN(bool a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770")]
		private bool GSYLBJLXRXJ(bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal struct LoadSceneTask
	{
		[Cpp2IlInjected.Token(Token = "0x200017C")]
		[CompilerGenerated]
		private sealed class AZSYQXSOVDR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006A0")]
			public string CFXXASOJHPT;

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public AZSYQXSOVDR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x8AF5C40", Offset = "0x8AF5040", VA = "0x188AF5C40")]
			internal object OVVBHIDABZR()
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
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006A5")]
			private TaskAwaiter<Scene> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0x8B07780", Offset = "0x8B06B80", VA = "0x188B07780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x8B07C50", Offset = "0x8B07050", VA = "0x188B07C50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B08D10", Offset = "0x8B08110", VA = "0x188B08D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x8B09190", Offset = "0x8B08590", VA = "0x188B09190", Slot = "5")]
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
		private StackTimer<string>.UBFOGWXCCTH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private MVWEOVUCDOM roomManager;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x8AF92F0", Offset = "0x8AF86F0", VA = "0x188AF92F0")]
		public static Task<Scene> AAZSWYQAJUS(MVWEOVUCDOM a, RoomSceneLocations b, StackTimer<string>.UBFOGWXCCTH c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9480", Offset = "0x8AF8880", VA = "0x188AF9480")]
		[AsyncStateMachine(typeof(<Run>d__4))]
		private Task<Scene> Run()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9340", Offset = "0x8AF8740", VA = "0x188AF9340")]
		[AsyncStateMachine(typeof(<SafeLoadSceneAsync>d__5))]
		private Task<Scene> QIRNTTYLNBN(string a)
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
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006B4")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006B5")]
			public bool skipHandlers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40006B6")]
			public IWGQTFVVOBJ deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40006B7")]
			private StackTimer<string>.UBFOGWXCCTH <moveToPhaseTimer>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0x8B187A0", Offset = "0x8B17BA0", VA = "0x188B187A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x8B19240", Offset = "0x8B18640", VA = "0x188B19240", Slot = "5")]
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
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006C0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C1")]
			private TaskAwaiter<PKIHHHDXEKZ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x8B1E320", Offset = "0x8B1D720", VA = "0x188B1E320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x8B1E5F0", Offset = "0x8B1D9F0", VA = "0x188B1E5F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private readonly TNRXJFRDOMC operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private readonly SJYCKVQRDLU debugRoomLoadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private readonly MVKKMFLHVOM handlers;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		private YHYCZYSLLNF NXNEEQBUZMH
		{
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x3DA6F60", Offset = "0x3DA6360", VA = "0x183DA6F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF99E0", Offset = "0x8AF8DE0", VA = "0x188AF99E0")]
		public MoveToPhaseTask(TNRXJFRDOMC operationContext, SJYCKVQRDLU debugRoomLoadInfo, MVKKMFLHVOM handlers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF96D0", Offset = "0x8AF8AD0", VA = "0x188AF96D0")]
		[AsyncStateMachine(typeof(<MoveTo>d__6))]
		public Task<RoomOperationState> MoveTo(RoomOperationState nextPhase, IWGQTFVVOBJ deserializationData, StackTimer<string>.UBFOGWXCCTH stackTimer, CancellationToken cancellationToken, bool skipHandlers)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9850", Offset = "0x8AF8C50", VA = "0x188AF9850")]
		[AsyncStateMachine(typeof(<SendStateChangeMessage>d__7))]
		private Task<RoomOperationState> SASUGFFBWMI(StackTimer<string>.UBFOGWXCCTH a, RoomOperationState b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x8AF99B0", Offset = "0x8AF8DB0", VA = "0x188AF99B0")]
		private bool VQFEKFMBJIZ(RoomOperationState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x8AF96B0", Offset = "0x8AF8AB0", VA = "0x188AF96B0")]
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
			public YHYCZYSLLNF operation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			public JPVRQJDLBNH timedYielder;

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
			private List<(PersistenceView, BMALMPEIUXS)>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			private (PersistenceView, BMALMPEIUXS) <pair>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x8B1BA50", Offset = "0x8B1AE50", VA = "0x188B1BA50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x8B1CA50", Offset = "0x8B1BE50", VA = "0x188B1CA50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x8B13620", Offset = "0x8B12A20", VA = "0x188B13620")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(YHYCZYSLLNF operation, IWGQTFVVOBJ data, JPVRQJDLBNH timedYielder, CancellationToken cancellationToken)
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
			public YHYCZYSLLNF operation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006D0")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006D1")]
			public JPVRQJDLBNH timedYielder;

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
			private List<(PersistenceView, BMALMPEIUXS)>.Enumerator <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40006D8")]
			private PersistenceView <view>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40006D9")]
			private BMALMPEIUXS <viewData>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40006DA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x8B1C110", Offset = "0x8B1B510", VA = "0x188B1C110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x8B1C9F0", Offset = "0x8B1BDF0", VA = "0x188B1C9F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x8B13760", Offset = "0x8B12B60", VA = "0x188B13760")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(YHYCZYSLLNF operation, IWGQTFVVOBJ data, JPVRQJDLBNH timedYielder, CancellationToken cancellationToken)
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
			public AsyncTaskMethodBuilder<Result<CQILIXUWHJF, GKLIEWNFSHL>> <>t__builder;

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
			private TaskAwaiter<Result<CQILIXUWHJF, GKLIEWNFSHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x8B1DC50", Offset = "0x8B1D050", VA = "0x188B1DC50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x8B1E2B0", Offset = "0x8B1D6B0", VA = "0x188B1E2B0", Slot = "5")]
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
		private TQVYXWPXNJF _subRoomAssetBundleProvider;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x8B14310", Offset = "0x8B13710", VA = "0x188B14310")]
		public static Task<Result<CQILIXUWHJF, GKLIEWNFSHL>> JNDJKPZJRQW(long a, long b, SubRoomDataSaveWithUnityAssetsDTO c, RecNet.Core.OnDownloadProgressDelegate d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x8B14470", Offset = "0x8B13870", VA = "0x188B14470")]
		[AsyncStateMachine(typeof(<Run>d__8))]
		private Task<Result<CQILIXUWHJF, GKLIEWNFSHL>> Run(RecNet.Core.OnDownloadProgressDelegate preloadProgressCallback, CancellationToken cancellationToken)
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
			public List<EQBJETEWMWJ> instantiationRequests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			public List<BMALMPEIUXS> requestDatas;

			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xDDEE90", Offset = "0xDDE290", VA = "0x180DDEE90")]
			public Results(List<EQBJETEWMWJ> instantiationRequests, List<BMALMPEIUXS> requestDatas)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018A")]
		[CompilerGenerated]
		private sealed class YYSAOGCWSFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			public IEnumerable<EQBJETEWMWJ> RCRZPYBQSIF;

			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public YYSAOGCWSFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0x8B24AA0", Offset = "0x8B23EA0", VA = "0x188B24AA0")]
			internal object QDEYLXZBUQH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private MVWEOVUCDOM roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private IWGQTFVVOBJ data;

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		private MVZYDDMAODN OJXQDUAJVPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0x8B13E40", Offset = "0x8B13240", VA = "0x188B13E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x8B142B0", Offset = "0x8B136B0", VA = "0x188B142B0")]
		public static Results Run(MVWEOVUCDOM roomManager, IWGQTFVVOBJ data)
		{
			return default(Results);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x8B14050", Offset = "0x8B13450", VA = "0x188B14050")]
		private Results Run()
		{
			return default(Results);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x8B138A0", Offset = "0x8B12CA0", VA = "0x188B138A0")]
		private Results DUWQPEQXFKL(PersistedRoomData a, DEPRECATED_RoomPersistenceVersion b)
		{
			return default(Results);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x8B13E90", Offset = "0x8B13290", VA = "0x188B13E90")]
		private bool FVXYWAAJKBZ(IEnumerable<EQBJETEWMWJ> a)
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
		private sealed class EZOENQOHZNW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			public PreInstantiateObjectsTask.Results FWOXDSSYROQ;

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EZOENQOHZNW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0x8B113F0", Offset = "0x8B107F0", VA = "0x188B113F0")]
			internal object LXSCDTCFDUX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018D")]
		[CompilerGenerated]
		private sealed class EZTLKXIFIZF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006EF")]
			public PersistenceView CMTKRFYZSQX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006F0")]
			public Guid SAZTJVSUEHE;

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EZTLKXIFIZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0x8B114A0", Offset = "0x8B108A0", VA = "0x188B114A0")]
			internal object LXMVGMIHUJO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x8B14730", Offset = "0x8B13B30", VA = "0x188B14730")]
		public static void Run(YHYCZYSLLNF operation, IWGQTFVVOBJ data, PreInstantiateObjectsTask.Results instantiations)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	internal class MVKKMFLHVOM
	{
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		[CompilerGenerated]
		private sealed class RPXDXIRZXRW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F6")]
			public Guid UDTSJVYNYFN;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public RPXDXIRZXRW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x8B146C0", Offset = "0x8B13AC0", VA = "0x188B146C0")]
			internal object YOINBGHNPEQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000191")]
		[CompilerGenerated]
		private sealed class LSZAKIEDSNH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F7")]
			public Guid UDTSJVYNYFN;

			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public LSZAKIEDSNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(RVA = "0x8B11BA0", Offset = "0x8B10FA0", VA = "0x188B11BA0")]
			internal object TOCZAXJABXS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000192")]
		[CompilerGenerated]
		private sealed class RMIVDUUSKIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F8")]
			public Guid UDTSJVYNYFN;

			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public RMIVDUUSKIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(RVA = "0x8B14650", Offset = "0x8B13A50", VA = "0x188B14650")]
			internal object PCVGLCNRFOJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[CompilerGenerated]
		private sealed class EOXEHAWLLLA
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
				public EOXEHAWLLLA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000700")]
				public CancellationToken mlbToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000701")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000678")]
				[Cpp2IlInjected.Address(RVA = "0x8B1F630", Offset = "0x8B1EA30", VA = "0x188B1F630", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000679")]
				[Cpp2IlInjected.Address(RVA = "0x8B1F8F0", Offset = "0x8B1ECF0", VA = "0x188B1F8F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F9")]
			public MVKKMFLHVOM MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006FA")]
			public IWGQTFVVOBJ LYKVCINIYGS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			public StackTimer<string>.UBFOGWXCCTH QGFTYNMMPPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			public Func<CancellationToken, Task> GRJPJADMRTR;

			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EOXEHAWLLLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(RVA = "0x8B11300", Offset = "0x8B10700", VA = "0x188B11300")]
			[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
			internal Task XYFWXWBTJKK(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[CompilerGenerated]
		private sealed class UMOAHPPLSQX
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
				public UMOAHPPLSQX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400070B")]
				private LogRangeScope <_>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400070C")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600067E")]
				[Cpp2IlInjected.Address(RVA = "0x8B1F170", Offset = "0x8B1E570", VA = "0x188B1F170", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600067F")]
				[Cpp2IlInjected.Address(RVA = "0x8B1F5D0", Offset = "0x8B1E9D0", VA = "0x188B1F5D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000702")]
			public RunFor EIORIPHHYSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000703")]
			public Guid FKENHTEQHIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000704")]
			public List<DeserializationPhaseHandler> BSTTKWCFXDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000705")]
			public IWGQTFVVOBJ LYKVCINIYGS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000706")]
			public CancellationToken YGSWFUJJLFF;

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public UMOAHPPLSQX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x8B228F0", Offset = "0x8B21CF0", VA = "0x188B228F0")]
			internal object JWOXLDVDJBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x8B227F0", Offset = "0x8B21BF0", VA = "0x188B227F0")]
			[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
			internal Task JWEJQQHIQEM(DeserializationPhaseHandler a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x8B229D0", Offset = "0x8B21DD0", VA = "0x188B229D0")]
			internal object JWUEIKPASMN()
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
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000713")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000714")]
			private UMOAHPPLSQX <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000715")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0x8B17110", Offset = "0x8B16510", VA = "0x188B17110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x8B175A0", Offset = "0x8B169A0", VA = "0x188B175A0", Slot = "5")]
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
			public MVKKMFLHVOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400071A")]
			public IWGQTFVVOBJ data;

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
			[Cpp2IlInjected.Address(RVA = "0x8B17600", Offset = "0x8B16A00", VA = "0x188B17600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x8B17AB0", Offset = "0x8B16EB0", VA = "0x188B17AB0", Slot = "5")]
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
			public MVKKMFLHVOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000721")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000722")]
			public StackTimer<string>.UBFOGWXCCTH timer;

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
			[Cpp2IlInjected.Address(RVA = "0x8B17B10", Offset = "0x8B16F10", VA = "0x188B17B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x8B180C0", Offset = "0x8B174C0", VA = "0x188B180C0", Slot = "5")]
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
			public MVKKMFLHVOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400072A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400072B")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400072C")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400072D")]
			private ByteString <completionMark>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400072E")]
			private TaskAwaiter<PKIHHHDXEKZ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0x8B18120", Offset = "0x8B17520", VA = "0x188B18120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000687")]
			[Cpp2IlInjected.Address(RVA = "0x8B18740", Offset = "0x8B17B40", VA = "0x188B18740", Slot = "5")]
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
			public MVKKMFLHVOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000732")]
			public RoomOperationState operationState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000733")]
			public IWGQTFVVOBJ deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000734")]
			public StackTimer<string>.UBFOGWXCCTH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000735")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000736")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0x8B1D1A0", Offset = "0x8B1C5A0", VA = "0x188B1D1A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0x8B1D900", Offset = "0x8B1CD00", VA = "0x188B1D900", Slot = "5")]
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
			public MVKKMFLHVOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400073A")]
			public StackTimer<string>.UBFOGWXCCTH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400073B")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400073C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400073D")]
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400073E")]
			private Dictionary<Guid, List<DeserializationPhaseHandler>>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400073F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0x8B1A270", Offset = "0x8B19670", VA = "0x188B1A270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0x8B1A880", Offset = "0x8B19C80", VA = "0x188B1A880", Slot = "5")]
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
			public MVKKMFLHVOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000743")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000744")]
			public StackTimer<string>.UBFOGWXCCTH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000745")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000746")]
			private EOXEHAWLLLA <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000747")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0x8B1A8E0", Offset = "0x8B19CE0", VA = "0x188B1A8E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068D")]
			[Cpp2IlInjected.Address(RVA = "0x8B1ADF0", Offset = "0x8B1A1F0", VA = "0x188B1ADF0", Slot = "5")]
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
			public MVKKMFLHVOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400074B")]
			public StackTimer<string>.UBFOGWXCCTH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400074C")]
			public IWGQTFVVOBJ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400074D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400074E")]
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400074F")]
			private Dictionary<Guid, List<DeserializationPhaseHandler>>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000750")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0x8B1B350", Offset = "0x8B1A750", VA = "0x188B1B350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068F")]
			[Cpp2IlInjected.Address(RVA = "0x8B1B9F0", Offset = "0x8B1ADF0", VA = "0x188B1B9F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private readonly TNRXJFRDOMC ZSLNFWTHBZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private DeserializationHandlerLists YBCWOJGSEHR;

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		private YHYCZYSLLNF NXNEEQBUZMH
		{
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x1013410", Offset = "0x1012810", VA = "0x181013410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public MVKKMFLHVOM(TNRXJFRDOMC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x8B12240", Offset = "0x8B11640", VA = "0x188B12240")]
		[AsyncStateMachine(typeof(<Run>d__5))]
		public Task Run(RoomOperationState operationState, IWGQTFVVOBJ deserializationData, StackTimer<string>.UBFOGWXCCTH timer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x8B11D40", Offset = "0x8B11140", VA = "0x188B11D40")]
		[AsyncStateMachine(typeof(<RunAuthorityHandler>d__6))]
		private Task DNHRJPHFISM(IWGQTFVVOBJ a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x8B12100", Offset = "0x8B11500", VA = "0x188B12100")]
		[AsyncStateMachine(typeof(<RunAllHandlers>d__7))]
		private Task PSAPDTFKHWT(IWGQTFVVOBJ a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x8B124F0", Offset = "0x8B118F0", VA = "0x188B124F0")]
		[AsyncStateMachine(typeof(<RunNonAuthorityHandlers>d__8))]
		private Task UZJJXAZKKKK(IWGQTFVVOBJ a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x8B12990", Offset = "0x8B11D90", VA = "0x188B12990")]
		[AsyncStateMachine(typeof(<InvokeMethodsInParallel>d__9))]
		private Task XSSPWKSQFJK(Guid a, List<DeserializationPhaseHandler> b, RunFor c, IWGQTFVVOBJ d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x8B11E80", Offset = "0x8B11280", VA = "0x188B11E80")]
		[AsyncStateMachine(typeof(<MasterLockedHandler>d__10))]
		private Task GFASEXJZAPE(IWGQTFVVOBJ a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x8B12AE0", Offset = "0x8B11EE0", VA = "0x188B12AE0")]
		[AsyncStateMachine(typeof(<MasterInvokeHandlerMethods>d__11))]
		private Task ZXMGTILCMLQ(Guid a, IWGQTFVVOBJ b, StackTimer<string>.UBFOGWXCCTH c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x8B11FC0", Offset = "0x8B113C0", VA = "0x188B11FC0")]
		[AsyncStateMachine(typeof(<MasterSyncSendCompletionMark>d__12))]
		private Task LVAQLSEGAWS(Guid a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x8B12880", Offset = "0x8B11C80", VA = "0x188B12880")]
		private void WRNZBUTXHGJ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x8B127E0", Offset = "0x8B11BE0", VA = "0x188B127E0")]
		private void WKEVLTDBRRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x8B12390", Offset = "0x8B11790", VA = "0x188B12390")]
		public Guid TWWIWJGWOVX(RoomOperationState a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x8B12630", Offset = "0x8B11A30", VA = "0x188B12630")]
		[CompilerGenerated]
		private object VCAXUFAAGLG()
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
			private StackTimer<string>.UBFOGWXCCTH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000758")]
			private IEnumerator<EmptySceneHandler> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000759")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x8B1CAB0", Offset = "0x8B1BEB0", VA = "0x188B1CAB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x8B1D140", Offset = "0x8B1C540", VA = "0x188B1D140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private MVZYDDMAODN callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		private StackTimer<string>.UBFOGWXCCTH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x8B15D10", Offset = "0x8B15110", VA = "0x188B15D10")]
		public static Task ERYRLVYLQLB(MVZYDDMAODN a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x8B15D80", Offset = "0x8B15180", VA = "0x188B15D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AC7A40", Offset = "0x2AC6E40", VA = "0x182AC7A40")]
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
		public IReadOnlyCollection<string> LMLUHHADOVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000695")]
			[Cpp2IlInjected.Address(RVA = "0x8B14FF0", Offset = "0x8B143F0", VA = "0x188B14FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public IReadOnlyDictionary<long, int> JLRCWHRSXHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0x8B15010", Offset = "0x8B14410", VA = "0x188B15010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x8B15030", Offset = "0x8B14430", VA = "0x188B15030")]
		public RoomSerializedData(PersistedRoomData? roomData, PersistedRoomDataReferences roomDataReferences, Guid? unityAssetId, [Optional] IReadOnlyList<Guid>? roomAssets)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	internal class TXHNTTILGBE : UFHENDBPHVR
	{
		[Cpp2IlInjected.Token(Token = "0x20001A5")]
		[CompilerGenerated]
		private sealed class YYSAOGCWSFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000766")]
			public float KLHRBXIQOJV;

			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public YYSAOGCWSFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A6")]
			[Cpp2IlInjected.Address(RVA = "0x8B24B10", Offset = "0x8B23F10", VA = "0x188B24B10")]
			internal object YZZNIWWWTPZ()
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
			[Cpp2IlInjected.Token(Token = "0x4000767")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000768")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000769")]
			public TXHNTTILGBE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400076A")]
			public PersistenceView[] activePersistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400076B")]
			public StringBuilder outputBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400076C")]
			public SerializeType serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400076D")]
			private YYSAOGCWSFC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400076E")]
			private LogRangeScope <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400076F")]
			private CancellationTokenSource <cts>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000770")]
			private PATPBQUPMIT<Task> <tasks>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000771")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0x8B192B0", Offset = "0x8B186B0", VA = "0x188B192B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0x8B19CE0", Offset = "0x8B190E0", VA = "0x188B19CE0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000772")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000773")]
			public AsyncTaskMethodBuilder<RoomSerializedData> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000774")]
			public TXHNTTILGBE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000775")]
			public long subroomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000776")]
			public SerializeType serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000777")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000778")]
			public RoomSaveOptions roomSaveOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000779")]
			private PersistenceView[] <activePersistenceViews>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400077A")]
			private StringBuilder <outputBuilder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400077B")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400077C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0x8B1E660", Offset = "0x8B1DA60", VA = "0x188B1E660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0x8B1ECE0", Offset = "0x8B1E0E0", VA = "0x188B1ECE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		private readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private static readonly TimeSpan EKHJPBSMISK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private readonly KQKIAJSNNOM IFQTTCFTLTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private readonly WRQUDMFGTPM GJDYNYYPBZR;

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x8B170B0", Offset = "0x8B164B0", VA = "0x188B170B0")]
		public TXHNTTILGBE(TNRXJFRDOMC a, KQKIAJSNNOM b, WRQUDMFGTPM c, Log d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x8B16EF0", Offset = "0x8B162F0", VA = "0x188B16EF0")]
		[AsyncStateMachine(typeof(<Serialize>d__6))]
		public Task<RoomSerializedData> Serialize(long subroomId, RoomSaveOptions roomSaveOptions, SerializeType serializeType, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x8B165E0", Offset = "0x8B159E0", VA = "0x188B165E0")]
		private static bool MFVVWTBWIMY(PersistenceView a, [Out] RRObjectPolicy b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x8B16DB0", Offset = "0x8B161B0", VA = "0x188B16DB0")]
		[AsyncStateMachine(typeof(<PreserializeViews>d__8))]
		private Task PRAODZYUCKT(SerializeType a, PersistenceView[] b, StringBuilder c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x8B16020", Offset = "0x8B15420", VA = "0x188B16020")]
		private RoomSerializedData MDOQTGFAAWW(long a, RoomSaveOptions b, SerializeType c, IEnumerable<PersistenceView> d, StringBuilder e)
		{
			return default(RoomSerializedData);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x8B15E70", Offset = "0x8B15270", VA = "0x188B15E70")]
		private PersistedRoomData HUNQXSKPXZC(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x8B16B60", Offset = "0x8B15F60", VA = "0x188B16B60")]
		private void POYCECTPSKV(PersistedRoomData a, StringBuilder b, IEnumerable<PersistenceView> c, [In] RoomSerializedMetadata metadata, GJXTXQLJSRV d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x8B166D0", Offset = "0x8B15AD0", VA = "0x188B166D0")]
		private void NHFLXVMUYMW(PersistedRoomData a, StringBuilder b, PersistenceView c, GJXTXQLJSRV d, [In] RoomSerializedMetadata metadata)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	internal class RoomUploadLogic : UFHENDBPHVR
	{
		[Cpp2IlInjected.Token(Token = "0x20001A9")]
		[CompilerGenerated]
		private sealed class LSZAKIEDSNH
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20001AA")]
			private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000788")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000789")]
				public AsyncTaskMethodBuilder<PKIHHHDXEKZ> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400078A")]
				public LSZAKIEDSNH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400078B")]
				public CancellationToken masterLockedBlockCancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400078C")]
				private PKIHHHDXEKZ <reloadMessage>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400078D")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400078E")]
				private TaskAwaiter<RemoteRunDTO> <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x400078F")]
				private TaskAwaiter<SaveSubRoomResponseDTO> <>u__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000790")]
				private TaskAwaiter<PKIHHHDXEKZ> <>u__4;

				[Cpp2IlInjected.Token(Token = "0x60006B6")]
				[Cpp2IlInjected.Address(RVA = "0x8B1F950", Offset = "0x8B1ED50", VA = "0x188B1F950", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006B7")]
				[Cpp2IlInjected.Address(RVA = "0x8B20B70", Offset = "0x8B1FF70", VA = "0x188B20B70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000780")]
			public RoomUploadLogic MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000781")]
			public RoomSerializedData EDKWXBCRVFZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000782")]
			public int ORZWTJMMCRL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000783")]
			public long DIVZDKJHDRC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000784")]
			public long FQDOCNUUMMS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000785")]
			public RoomSaveRequestPayload FNIQVCXVIMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000786")]
			public RoomSaveAnalyticsInfo WREASGHAPPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000787")]
			public StackTimer<string>.UBFOGWXCCTH CKLPRVMXYZN;

			[Cpp2IlInjected.Token(Token = "0x60006B4")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public LSZAKIEDSNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B5")]
			[Cpp2IlInjected.Address(RVA = "0x8B11C10", Offset = "0x8B11010", VA = "0x188B11C10")]
			[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
			internal Task<PKIHHHDXEKZ> YGGACGTCJDW(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AB")]
		[CompilerGenerated]
		private sealed class ACTEAKJALWV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000791")]
			public Storage.UploadFileResponseDTO TJLFBSWWIBC;

			[Cpp2IlInjected.Token(Token = "0x60006B8")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ACTEAKJALWV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B9")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E520", Offset = "0x8B0D920", VA = "0x188B0E520")]
			internal object UPJGZLAIQTW()
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
			[Cpp2IlInjected.Token(Token = "0x4000792")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000793")]
			public AsyncTaskMethodBuilder<RemoteRunDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000794")]
			public RoomUploadLogic <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000795")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000796")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000797")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000798")]
			public string studioSessionId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000799")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400079A")]
			private TaskAwaiter<(Storage.UploadFileResponseDTO roomDataUpload, Storage.UploadFileResponseDTO subRoomDataUpload)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400079B")]
			private TaskAwaiter<RemoteRunDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006BA")]
			[Cpp2IlInjected.Address(RVA = "0x8B19D40", Offset = "0x8B19140", VA = "0x188B19D40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BB")]
			[Cpp2IlInjected.Address(RVA = "0x8B1A200", Offset = "0x8B19600", VA = "0x188B1A200", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400079C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400079D")]
			public AsyncTaskMethodBuilder<SaveSubRoomResponseDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400079E")]
			public MVZYDDMAODN callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400079F")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007A1")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007A2")]
			public UgcVersionInfo ugcVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007A3")]
			public RoomSaveRequestPayload roomSaveRequestPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007A4")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007A5")]
			private TaskAwaiter<(Storage.UploadFileResponseDTO roomDataUpload, Storage.UploadFileResponseDTO subRoomDataUpload)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007A6")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006BC")]
			[Cpp2IlInjected.Address(RVA = "0x8B21560", Offset = "0x8B20960", VA = "0x188B21560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0x8B21BC0", Offset = "0x8B20FC0", VA = "0x188B21BC0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40007A7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007A8")]
			public AsyncTaskMethodBuilder<SaveSubRoomResponseDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007A9")]
			public RoomUploadLogic <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007AA")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007AB")]
			public RoomSaveRequestPayload roomSaveRequestPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0x8B21C30", Offset = "0x8B21030", VA = "0x188B21C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x8B21ED0", Offset = "0x8B212D0", VA = "0x188B21ED0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			public AsyncTaskMethodBuilder<PKIHHHDXEKZ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			public RoomUploadLogic <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007B7")]
			public RoomSaveRequestPayload roomSaveRequestPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007B8")]
			public RoomSaveAnalyticsInfo roomSaveAnalyticsInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007B9")]
			public StackTimer<string>.UBFOGWXCCTH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007BA")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007BB")]
			private TaskAwaiter<PKIHHHDXEKZ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0x8B211D0", Offset = "0x8B205D0", VA = "0x188B211D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x8B214F0", Offset = "0x8B208F0", VA = "0x188B214F0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40007BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007BD")]
			public AsyncTaskMethodBuilder<(Storage.UploadFileResponseDTO roomDataUpload, Storage.UploadFileResponseDTO subRoomDataUpload)> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007BE")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007BF")]
			public MVZYDDMAODN callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007C0")]
			private ACTEAKJALWV <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007C1")]
			private byte[] <data>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007C2")]
			private float <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40007C3")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007C4")]
			private TaskAwaiter<Storage.UploadFileResponseDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0x8B21F40", Offset = "0x8B21340", VA = "0x188B21F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0x8B22780", Offset = "0x8B21B80", VA = "0x188B22780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400077D")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x400077E")]
		private static readonly Log LNPYKRNGQSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		private readonly FNMSXOSALFV AZWMYWWNHRA;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		private MVWEOVUCDOM USCSXKJPLMQ
		{
			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x8ADD210", Offset = "0x8ADC610", VA = "0x188ADD210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B15C80", Offset = "0x8B15080", VA = "0x188B15C80")]
		public RoomUploadLogic(TNRXJFRDOMC operationContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x8B15120", Offset = "0x8B14520", VA = "0x188B15120")]
		[AsyncStateMachine(typeof(<UploadRoomDataToStorage>d__7))]
		private static Task<(Storage.UploadFileResponseDTO, Storage.UploadFileResponseDTO)> BBBXIKRUODQ(MVZYDDMAODN a, RoomSerializedData b, long c, long d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x8B155C0", Offset = "0x8B149C0", VA = "0x188B155C0")]
		[AsyncStateMachine(typeof(<UploadRoomDataBlob>d__8))]
		public Task<SaveSubRoomResponseDTO> QSMCPITOOKD(int a, [CanBeNull] RoomSaveRequestPayload roomSaveRequestPayload, RoomSerializedData b, long c, long d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B15270", Offset = "0x8B14670", VA = "0x188B15270")]
		public static Task<SaveSubRoomResponseDTO> QSMCPITOOKD(MVZYDDMAODN a, int b, [CanBeNull] RoomSaveRequestPayload roomSaveRequestPayload, RoomSerializedData c, long d, long e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x8B15730", Offset = "0x8B14B30", VA = "0x188B15730")]
		[AsyncStateMachine(typeof(<UploadRoomDataBlob>d__10))]
		public static Task<SaveSubRoomResponseDTO> QSMCPITOOKD(MVZYDDMAODN a, int b, [CanBeNull] RoomSaveRequestPayload roomSaveRequestPayload, RoomSerializedData c, long d, long e, UgcVersionInfo f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B158C0", Offset = "0x8B14CC0", VA = "0x188B158C0")]
		[AsyncStateMachine(typeof(<PushRoomDataBlobToStudio>d__11))]
		private Task<RemoteRunDTO> SLABSSTXDTL(string a, int b, RoomSerializedData c, long d, long e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B15A40", Offset = "0x8B14E40", VA = "0x188B15A40")]
		[AsyncStateMachine(typeof(<UploadRoomDataBlobAndSyncReload>d__12))]
		public Task<PKIHHHDXEKZ> UPWGFKPOVAW(int a, RoomSaveRequestPayload? roomSaveRequestPayload, RoomSerializedData b, long c, long d, RoomSaveAnalyticsInfo e, StackTimer<string>.UBFOGWXCCTH f, CancellationToken g)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B1")]
	public abstract class AVNHJRQNKLC<a> where a : AVNHJRQNKLC<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		internal readonly MVWEOVUCDOM CRNFRKKHJUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		private int? IINZJRJKERF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		protected readonly Guid AQZOEGFVORU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		protected readonly RoomOperationType UGWBBPQOCUG;

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		protected a GPHHDZCRIVO
		{
			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0x5508470", Offset = "0x5507870", VA = "0x185508470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x5508660", Offset = "0x5507A60", VA = "0x185508660")]
		internal AVNHJRQNKLC(MVWEOVUCDOM a, RoomOperationType b, [Optional] Guid? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x5508160", Offset = "0x5507560", VA = "0x185508160")]
		private PKIHHHDXEKZ GBILKLONTVU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
		protected virtual void FURIFMXNNFX(PKIHHHDXEKZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x55082F0", Offset = "0x55076F0", VA = "0x1855082F0")]
		public a OWLNJGIUTQA(JCSDFORPEFX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x5508240", Offset = "0x5507640", VA = "0x185508240")]
		public a LSEZVYWOXSO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x55084D0", Offset = "0x55078D0", VA = "0x1855084D0", Slot = "5")]
		public virtual Task<WIIGEWEAFFO> Submit()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	public class OEHTXSFHHXB : AVNHJRQNKLC<OEHTXSFHHXB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		private RoomLoadRequestPayload ICROIKVKOCI;

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B13550", Offset = "0x8B12950", VA = "0x188B13550")]
		internal OEHTXSFHHXB(MVWEOVUCDOM a, RoomOperationType b, [Optional] Guid? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x7CD21B0", Offset = "0x7CD15B0", VA = "0x187CD21B0")]
		public OEHTXSFHHXB KGDIGSOPZMM(RoomLoadRequestPayload a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B13480", Offset = "0x8B12880", VA = "0x188B13480", Slot = "4")]
		protected override void FURIFMXNNFX(PKIHHHDXEKZ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	public class HHIEEUBOKJK : AVNHJRQNKLC<HHIEEUBOKJK>
	{
		[Cpp2IlInjected.Token(Token = "0x20001B4")]
		internal enum SaveTarget
		{
			[Cpp2IlInjected.Token(Token = "0x40007CE")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40007CF")]
			Disk,
			[Cpp2IlInjected.Token(Token = "0x40007D0")]
			RecNet
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001B5")]
		[CompilerGenerated]
		private struct <Submit>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007D1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007D2")]
			public AsyncTaskMethodBuilder<WIIGEWEAFFO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007D3")]
			public HHIEEUBOKJK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007D4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007D5")]
			private TaskAwaiter<WIIGEWEAFFO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0x8B1ED50", Offset = "0x8B1E150", VA = "0x188B1ED50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(RVA = "0x8B1F100", Offset = "0x8B1E500", VA = "0x188B1F100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		private SaveTarget GBFWVPAUFEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		private string KPZCDNYXGPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007CC")]
		private RoomSaveRequestPayload ICROIKVKOCI;

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B118E0", Offset = "0x8B10CE0", VA = "0x188B118E0")]
		internal HHIEEUBOKJK(MVWEOVUCDOM a, RoomOperationType b, [Optional] Guid? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B11780", Offset = "0x8B10B80", VA = "0x188B11780")]
		public HHIEEUBOKJK PZQWVVPEAXW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x8B115B0", Offset = "0x8B109B0", VA = "0x188B115B0")]
		public HHIEEUBOKJK CWHQWSKJSHS(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B11760", Offset = "0x8B10B60", VA = "0x188B11760")]
		public HHIEEUBOKJK IVKBPXOFDYE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B11730", Offset = "0x8B10B30", VA = "0x188B11730")]
		public HHIEEUBOKJK HLIKCOLZFZE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B115D0", Offset = "0x8B109D0", VA = "0x188B115D0", Slot = "4")]
		protected override void FURIFMXNNFX(PKIHHHDXEKZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B117B0", Offset = "0x8B10BB0", VA = "0x188B117B0", Slot = "5")]
		[AsyncStateMachine(typeof(<Submit>d__11))]
		public override Task<WIIGEWEAFFO> Submit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B118A0", Offset = "0x8B10CA0", VA = "0x188B118A0")]
		[CompilerGenerated]
		[DebuggerHidden]
		private Task<WIIGEWEAFFO> UPSITEIRRBS()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	internal static class ZWPJRHNHBVR
	{
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B24B70", Offset = "0x8B23F70", VA = "0x188B24B70")]
		public static void IJUTVSOMJSB(this PlayerPresence a, RoomInstance b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B24CB0", Offset = "0x8B240B0", VA = "0x188B24CB0")]
		public static void YPFBKQWWTHY(this RoomInstance a, [Optional] string b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	public static class KPJBHUHCGNF
	{
		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x8B11B00", Offset = "0x8B10F00", VA = "0x188B11B00")]
		public static FilenameWithHash VWFHOCABCPQ(this FJPPPHRHJKJ a)
		{
			return default(FilenameWithHash);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B11A50", Offset = "0x8B10E50", VA = "0x188B11A50")]
		public static FJPPPHRHJKJ PLOCKNGHONN(this FilenameWithHash a)
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
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			public ValidationReason ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public ValidationReason HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007DE")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006E2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private static ValidationReason[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		private Dictionary<ValidationReason, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x8B23310", Offset = "0x8B22710", VA = "0x188B23310")]
		public bool TryGetConfig(ValidationReason validationReason, [Out] ResultConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x8B22AB0", Offset = "0x8B21EB0", VA = "0x188B22AB0")]
		public ResultConfig GetConfigForResult(ValidationReason reason, [Optional] HashSet<ValidationReason> visited)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B23140", Offset = "0x8B22540", VA = "0x188B23140", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B22BE0", Offset = "0x8B21FE0", VA = "0x188B22BE0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xBA6820", Offset = "0xBA5C20", VA = "0x180BA6820")]
		public ValidationResultConfig()
		{
		}
	}
}
namespace RecRoom.RoomLoading.PreEmptyScene
{
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	public class RoomManagerPreEmptyScene : WTLPGQTVEHV
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001BC")]
		[CompilerGenerated]
		private struct <Run>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007E6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007E7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007E8")]
			public RoomManagerPreEmptyScene <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007E9")]
			public StackTimer<string>.UBFOGWXCCTH timerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007EA")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007EB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x8B1D960", Offset = "0x8B1CD60", VA = "0x188B1D960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x8B1DBF0", Offset = "0x8B1CFF0", VA = "0x188B1DBF0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40007EC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007ED")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007EE")]
			public StackTimer<string>.UBFOGWXCCTH timerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007EF")]
			public WTLPGQTVEHV preEmptySceneHandler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007F0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007F1")]
			private StackTimer<string>.UBFOGWXCCTH <ts>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007F2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x8B1AE50", Offset = "0x8B1A250", VA = "0x188B1AE50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x8B1B2F0", Offset = "0x8B1A6F0", VA = "0x188B1B2F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		private readonly JGOJQGUBEFL RVRIRFDCRZO;

		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public string JKBMGUCVWXI
		{
			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0x8B14EE0", Offset = "0x8B142E0", VA = "0x188B14EE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B14F10", Offset = "0x8B14310", VA = "0x188B14F10")]
		[CVOOPLRRRUK.Root.GameOnly]
		internal static void VIZGFABUYZU(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		[RecRoom.NoEngine.Common.Preserve]
		public RoomManagerPreEmptyScene([Inject(null)] JGOJQGUBEFL assetBundlePreEmptySceneHandler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B14DD0", Offset = "0x8B141D0", VA = "0x188B14DD0", Slot = "5")]
		[AsyncStateMachine(typeof(<Run>d__6))]
		public Task Run(StackTimer<string>.UBFOGWXCCTH timerScope, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B14CB0", Offset = "0x8B140B0", VA = "0x188B14CB0")]
		[AsyncStateMachine(typeof(<RunHandlerWithCancellationForwarding>d__7))]
		private Task AJLWVPWYQDH(WTLPGQTVEHV a, StackTimer<string>.UBFOGWXCCTH b, CancellationToken c)
		{
			return null;
		}
	}
}
namespace RecRoom.RoomLoading.Interfaces.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20001BE")]
	public interface JGOJQGUBEFL : WTLPGQTVEHV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	public interface WTLPGQTVEHV
	{
		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		string JKBMGUCVWXI
		{
			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task Run(StackTimer<string>.UBFOGWXCCTH timerScope, CancellationToken cancellationToken);
	}
}
namespace RecRoom.RoomLoading.AutoSaves
{
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	public static class YLZUWIMQAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x8B24030", Offset = "0x8B23430", VA = "0x188B24030")]
		[CVOOPLRRRUK.Root.GameOnly]
		internal static void UUDUQLMHCPR(XRSJVGYQFTW a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	public interface KCPWVXKRWZI : IEquatable<KCPWVXKRWZI>
	{
		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		DateTime GQYHLMCVUPW
		{
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Delete();

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool WKADCHLQGHL(long a, long b, [Out] RoomSerializedData c);
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	internal class XAFLKKXKUOK : BLPDIKJBTAX
	{
		[Cpp2IlInjected.Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class EOXEHAWLLLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007F7")]
			public AutosaveType NGANXIRXXNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007F8")]
			public Exception HCWNUUPSPGD;

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EOXEHAWLLLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x8B11290", Offset = "0x8B10690", VA = "0x188B11290")]
			internal object SLSXUQDNOYK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		private readonly AVBJAKTDQNJ VTJAKZVBPPS;

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<KCPWVXKRWZI> SRIWDIRHMIX
		{
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0x8B23F80", Offset = "0x8B23380", VA = "0x188B23F80", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x8B234A0", Offset = "0x8B228A0", VA = "0x188B234A0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		[UnityEngine.Scripting.Preserve]
		public XAFLKKXKUOK([Inject(null)] AVBJAKTDQNJ autosaveStorageService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B23CA0", Offset = "0x8B230A0", VA = "0x188B23CA0", Slot = "6")]
		public bool QGUMXUBVGDK(long a, long b, RoomSerializedData c, AutosaveType d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xC68C70", Offset = "0xC68070", VA = "0x180C68C70")]
		private void SPKCCOTMJFN(KCPWVXKRWZI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x8B23B30", Offset = "0x8B22F30", VA = "0x188B23B30", Slot = "7")]
		public bool PPAAKFHMXFS(long a, long b, [Out] KCPWVXKRWZI c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x8B23550", Offset = "0x8B22950", VA = "0x188B23550", Slot = "8")]
		public bool KNITFLVWRJV(long a, long b, AutosaveType c, [Out] KCPWVXKRWZI d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x8B23600", Offset = "0x8B22A00", VA = "0x188B23600")]
		private void NRGANZBWZMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x8B23A10", Offset = "0x8B22E10", VA = "0x188B23A10", Slot = "9")]
		public void ORTPLZQKPYS(long a, long b)
		{
		}
	}
}
namespace RecRoom.RoomLoading.AutoSaves.Versions
{
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	internal abstract class CWHTLRQOUKD : AVBJAKTDQNJ
	{
		[Cpp2IlInjected.Token(Token = "0x20001C6")]
		protected enum DirectoryAccessMode : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40007FB")]
			Read,
			[Cpp2IlInjected.Token(Token = "0x40007FC")]
			Write
		}

		[Cpp2IlInjected.Token(Token = "0x20001C7")]
		[CompilerGenerated]
		private sealed class MWLHREALRTF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007FD")]
			public AutosaveType NGANXIRXXNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007FE")]
			public FileInfo VADLGSGDUEK;

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public MWLHREALRTF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x8B133E0", Offset = "0x8B127E0", VA = "0x188B133E0")]
			internal object VOGICYEAXNH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001C8")]
		[CompilerGenerated]
		private sealed class GZSIQPWDSFW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007FF")]
			public CWHTLRQOUKD MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000800")]
			public FileInfo YJSWZUVMLEA;

			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public GZSIQPWDSFW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0x8B11530", Offset = "0x8B10930", VA = "0x188B11530")]
			internal void OCBXTWPXJCH(PlayerReporting.HileType a, string b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001C9")]
		[CompilerGenerated]
		private sealed class MWEWTPZLMVY : IEnumerable<KCPWVXKRWZI>, IEnumerable, IEnumerator<KCPWVXKRWZI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000801")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000802")]
			private KCPWVXKRWZI JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000803")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000804")]
			public CWHTLRQOUKD MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000805")]
			private AutosaveType NGANXIRXXNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000806")]
			public AutosaveType KXTYDFWDAWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			private FileInfo[] BPMZBLFMONE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000808")]
			private int BPHSEELPFBV;

			[Cpp2IlInjected.Token(Token = "0x170000F3")]
			private KCPWVXKRWZI TWVFPCEAVQS
			{
				[Cpp2IlInjected.Token(Token = "0x600071B")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F4")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x600071D")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0xD06FE0", Offset = "0xD063E0", VA = "0x180D06FE0")]
			[DebuggerHidden]
			public MWEWTPZLMVY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0x8B12E90", Offset = "0x8B12290", VA = "0x188B12E90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0x8B12E50", Offset = "0x8B12250", VA = "0x188B12E50", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x8B12D60", Offset = "0x8B12160", VA = "0x188B12D60", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KCPWVXKRWZI> BSHZKPFCOQB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x8B12D60", Offset = "0x8B12160", VA = "0x188B12D60", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		private readonly object PFSFWMBAWAT;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		protected string DRPCXYGHMQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0x8B10830", Offset = "0x8B0FC30", VA = "0x188B10830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract AutosaveVersion RINUQJYSXXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x8B11220", Offset = "0x8B10620", VA = "0x188B11220")]
		protected CWHTLRQOUKD([CanBeNull] string persistentDataDir)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x8B108C0", Offset = "0x8B0FCC0", VA = "0x188B108C0", Slot = "5")]
		public bool RMEKRGKTAKL(long a, long b, AutosaveType c, [Out] KCPWVXKRWZI d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x8B10840", Offset = "0x8B0FC40", VA = "0x188B10840", Slot = "6")]
		[IteratorStateMachine(typeof(MWEWTPZLMVY))]
		public IEnumerable<KCPWVXKRWZI> QUHRSVNIYUJ(AutosaveType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		internal abstract void IPQLGQVRIPM(Stream a, long b, long c, RoomSerializedData d);

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		internal abstract bool YZWRPQPQWRL(Stream a, long b, long c, HileFunc d, [Out] RoomSerializedData e);

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x8B10EB0", Offset = "0x8B102B0", VA = "0x188B10EB0", Slot = "7")]
		public KCPWVXKRWZI YBQDVLAQGNT(long a, long b, RoomSerializedData c, AutosaveType d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		[NotNull]
		protected abstract FileInfo VYYQVUQLZYS(long a, long b, AutosaveType c, DirectoryAccessMode d);

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(Slot = "12")]
		[NotNull]
		protected abstract DirectoryInfo JXKZDRPKWLO(AutosaveType a, DirectoryAccessMode b);

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x8B10E40", Offset = "0x8B10240", VA = "0x188B10E40")]
		protected void UXPFKVUTYAW(PlayerReporting.HileType a, string b, FileInfo c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x8B10AB0", Offset = "0x8B0FEB0", VA = "0x188B10AB0")]
		internal bool SXQPOOSEYVJ(FileInfo a, long b, long c, [Out] RoomSerializedData d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		private void PZMWXEDTDPP(Exception a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	internal class AKHQKQYLZHA : CWHTLRQOUKD
	{
		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public override AutosaveVersion RINUQJYSXXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0xCF8820", Offset = "0xCF7C20", VA = "0x180CF8820", Slot = "8")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x8B0F160", Offset = "0x8B0E560", VA = "0x188B0F160")]
		public AKHQKQYLZHA([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E570", Offset = "0x8B0D970", VA = "0x188B0E570")]
		private void BAWRMFFAHUA(AutosaveType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E5F0", Offset = "0x8B0D9F0", VA = "0x188B0E5F0", Slot = "9")]
		internal override void IPQLGQVRIPM(Stream a, long b, long c, RoomSerializedData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x8B0EA60", Offset = "0x8B0DE60", VA = "0x188B0EA60", Slot = "10")]
		internal override bool YZWRPQPQWRL(Stream a, long b, long c, HileFunc d, [Out] RoomSerializedData e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E980", Offset = "0x8B0DD80", VA = "0x188B0E980", Slot = "11")]
		protected override FileInfo VYYQVUQLZYS(long a, long b, AutosaveType c, DirectoryAccessMode d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E880", Offset = "0x8B0DC80", VA = "0x188B0E880", Slot = "12")]
		protected override DirectoryInfo JXKZDRPKWLO(AutosaveType a, DirectoryAccessMode b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	internal sealed class AKMXHXSJISJ : CWHTLRQOUKD
	{
		[Cpp2IlInjected.Token(Token = "0x4000809")]
		private static readonly byte[] RJWUJQXIPUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400080A")]
		private readonly byte[] TZTLLUGEZHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400080B")]
		private readonly byte[] SXDAMLWCJCE;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public override AutosaveVersion RINUQJYSXXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x74F43F0", Offset = "0x74F37F0", VA = "0x1874F43F0", Slot = "8")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x8B103E0", Offset = "0x8B0F7E0", VA = "0x188B103E0")]
		public AKMXHXSJISJ([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x8B0F1F0", Offset = "0x8B0E5F0", VA = "0x188B0F1F0", Slot = "9")]
		internal override void IPQLGQVRIPM(Stream a, long b, long c, RoomSerializedData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x8B0F8E0", Offset = "0x8B0ECE0", VA = "0x188B0F8E0", Slot = "10")]
		internal override bool YZWRPQPQWRL(Stream a, long b, long c, HileFunc d, [Out] RoomSerializedData e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x8B0F700", Offset = "0x8B0EB00", VA = "0x188B0F700")]
		private void LMMPQUWJHIC(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x8B0F7C0", Offset = "0x8B0EBC0", VA = "0x188B0F7C0", Slot = "11")]
		protected override FileInfo VYYQVUQLZYS(long a, long b, AutosaveType c, DirectoryAccessMode d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x8B0F5F0", Offset = "0x8B0E9F0", VA = "0x188B0F5F0", Slot = "12")]
		protected override DirectoryInfo JXKZDRPKWLO(AutosaveType a, DirectoryAccessMode b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CD")]
	public enum AutosaveVersion : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400080F")]
		INVALID = 0,
		[Cpp2IlInjected.Token(Token = "0x4000810")]
		CHECKSUM = 2,
		[Cpp2IlInjected.Token(Token = "0x4000811")]
		BETTER_FILE_LAYOUT = 3
	}
}
namespace RecRoom.RoomLoading.AutoSaves.Storage
{
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	internal class AAQWFNYUXJG : AVBJAKTDQNJ
	{
		[Cpp2IlInjected.Token(Token = "0x20001D0")]
		[CompilerGenerated]
		private sealed class MWEWTPZLMVY : IEnumerable<KCPWVXKRWZI>, IEnumerable, IEnumerator<KCPWVXKRWZI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000818")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000819")]
			private KCPWVXKRWZI JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400081A")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400081B")]
			public AAQWFNYUXJG MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400081C")]
			private AutosaveType NGANXIRXXNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400081D")]
			public AutosaveType KXTYDFWDAWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400081E")]
			private AutosaveVersion[] BPMZBLFMONE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400081F")]
			private int BPHSEELPFBV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000820")]
			private IEnumerator<KCPWVXKRWZI> BPCLGXRRVQM;

			[Cpp2IlInjected.Token(Token = "0x170000F8")]
			private KCPWVXKRWZI TWVFPCEAVQS
			{
				[Cpp2IlInjected.Token(Token = "0x6000741")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F9")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000743")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0xD06FE0", Offset = "0xD063E0", VA = "0x180D06FE0")]
			[DebuggerHidden]
			public MWEWTPZLMVY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x8B12C20", Offset = "0x8B12020", VA = "0x188B12C20", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x8B130B0", Offset = "0x8B124B0", VA = "0x188B130B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x8B13390", Offset = "0x8B12790", VA = "0x188B13390")]
			private void RYZDNTQONZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x8B12E10", Offset = "0x8B12210", VA = "0x188B12E10", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x8B12CB0", Offset = "0x8B120B0", VA = "0x188B12CB0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KCPWVXKRWZI> BSHZKPFCOQB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0x8B12CB0", Offset = "0x8B120B0", VA = "0x188B12CB0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		private readonly AutosaveVersion[] TEXGAEZBGDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		private readonly Dictionary<AutosaveVersion, AVBJAKTDQNJ> ROCQWGXZIWD;

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public AutosaveVersion RINUQJYSXXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x8B0DCF0", Offset = "0x8B0D0F0", VA = "0x188B0DCF0", Slot = "4")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E210", Offset = "0x8B0D610", VA = "0x188B0E210")]
		[UnityEngine.Scripting.Preserve]
		public AAQWFNYUXJG(params AVBJAKTDQNJ[] versionImpls)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x8B0DFD0", Offset = "0x8B0D3D0", VA = "0x188B0DFD0", Slot = "5")]
		public bool RMEKRGKTAKL(long a, long b, AutosaveType c, [Out] KCPWVXKRWZI d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x8B0DD20", Offset = "0x8B0D120", VA = "0x188B0DD20")]
		private void LOWQWBEZROD(int a, long b, long c, AutosaveType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x8B0DF50", Offset = "0x8B0D350", VA = "0x188B0DF50", Slot = "6")]
		[IteratorStateMachine(typeof(MWEWTPZLMVY))]
		public IEnumerable<KCPWVXKRWZI> QUHRSVNIYUJ(AutosaveType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E120", Offset = "0x8B0D520", VA = "0x188B0E120", Slot = "7")]
		public KCPWVXKRWZI YBQDVLAQGNT(long a, long b, RoomSerializedData c, AutosaveType d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	internal static class CCEJQRZLPTS
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x8B10510", Offset = "0x8B0F910", VA = "0x188B10510")]
		internal static byte[] BJWGAQDYJMX(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x8B105D0", Offset = "0x8B0F9D0", VA = "0x188B105D0")]
		public static void JNJIZRVAGOP(Stream a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x8B10650", Offset = "0x8B0FA50", VA = "0x188B10650")]
		public static bool WCWZFSULRFC(Stream a, long b, HileFunc c, [Out] byte[] d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D2")]
	internal sealed class YXHPGRCIPRV : KCPWVXKRWZI, IEquatable<KCPWVXKRWZI>, IEquatable<YXHPGRCIPRV>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		private readonly CWHTLRQOUKD WTBGNEXMQOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		public readonly FileInfo HZWXGXZRIMU;

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public AutosaveVersion RINUQJYSXXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x83D7950", Offset = "0x83D6D50", VA = "0x1883D7950", Slot = "9")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		public DateTime GQYHLMCVUPW
		{
			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x8B24820", Offset = "0x8B23C20", VA = "0x188B24820", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x8B249A0", Offset = "0x8B23DA0", VA = "0x188B249A0")]
		public YXHPGRCIPRV(CWHTLRQOUKD a, FileInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x8B248B0", Offset = "0x8B23CB0", VA = "0x188B248B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x8B244C0", Offset = "0x8B238C0", VA = "0x188B244C0", Slot = "5")]
		public void Delete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x8B24960", Offset = "0x8B23D60", VA = "0x188B24960", Slot = "6")]
		public bool WKADCHLQGHL(long a, long b, [Out] RoomSerializedData c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x8B24640", Offset = "0x8B23A40", VA = "0x188B24640", Slot = "7")]
		public bool Equals(KCPWVXKRWZI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x8B24580", Offset = "0x8B23980", VA = "0x188B24580", Slot = "8")]
		public bool Equals(YXHPGRCIPRV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x8B246B0", Offset = "0x8B23AB0", VA = "0x188B246B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x8B24790", Offset = "0x8B23B90", VA = "0x188B24790", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D3")]
	public delegate void HileFunc(PlayerReporting.HileType hileType, string message);
	[Cpp2IlInjected.Token(Token = "0x20001D4")]
	internal interface AVBJAKTDQNJ
	{
		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		AutosaveVersion RINUQJYSXXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000755")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RMEKRGKTAKL(long a, long b, AutosaveType c, [Out] KCPWVXKRWZI d);

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IEnumerable<KCPWVXKRWZI> QUHRSVNIYUJ(AutosaveType a);

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(Slot = "3")]
		KCPWVXKRWZI YBQDVLAQGNT(long a, long b, RoomSerializedData c, AutosaveType d);
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
