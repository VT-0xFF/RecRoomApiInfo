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
		[Cpp2IlInjected.Address(RVA = "0x8DA01B0", Offset = "0x8D9EFB0", VA = "0x188DA01B0")]
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
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class EWFSFOBQSTJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal Task<RoomLoadDetails> RPHNFABAHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal Task HBSPRROWABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal TZSZRJATIYU JXPJQSBMNTJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
	public EWFSFOBQSTJ()
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
		[Cpp2IlInjected.Address(RVA = "0x8D9FD80", Offset = "0x8D9EB80", VA = "0x188D9FD80", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8DBB9C0", Offset = "0x8DBA7C0", VA = "0x188DBB9C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2963E60", Offset = "0x2962C60", VA = "0x182963E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8DA2180", Offset = "0x8DA0F80", VA = "0x188DA2180")]
		public RecoverableRoomOperationException(string message, Exception innerException)
		{
		}
	}
}
namespace RoomOperation.OperationLogic.Restore
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal class COVGZUCTZPR : LMWCZJTHJJE
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
			[Cpp2IlInjected.Address(RVA = "0x8DB1160", Offset = "0x8DAFF60", VA = "0x188DB1160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1370", Offset = "0x8DB0170", VA = "0x188DB1370", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DB22A0", Offset = "0x8DB10A0", VA = "0x188DB22A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8DB24E0", Offset = "0x8DB12E0", VA = "0x188DB24E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		[UnityEngine.Scripting.Preserve]
		public COVGZUCTZPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8D9DB20", Offset = "0x8D9C920", VA = "0x188D9DB20", Slot = "4")]
		[AsyncStateMachine(typeof(<GetSubRoomDataHistory>d__1))]
		public Task<IReadOnlyList<SubRoomDataSaveDTO>> TIJODHKQBGW(long a, long b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8D9DA10", Offset = "0x8D9C810", VA = "0x188D9DA10", Slot = "5")]
		[AsyncStateMachine(typeof(<GetAccountsBulk>d__2))]
		public Task<IReadOnlyList<Account>> NTYDFBOXUMR(IReadOnlyList<int> a, [Optional] CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface VOKEFNRQEUR : IEquatable<VOKEFNRQEUR>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int VRILQOKCCKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[CanBeNull]
		Account YSYVBXZQTFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		DateTime QGCNAMAFUXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		PlatformType? KBFPUMUKCHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		DeviceClass? LNVPZNQBJYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		[CanBeNull]
		RestoreOptionTypes DCFMKZSANFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<MMSSFGQGRLF> MZXKOSBITHN();
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
	public interface LMWCZJTHJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<SubRoomDataSaveDTO>> TIJODHKQBGW(long a, long b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<IReadOnlyList<Account>> NTYDFBOXUMR(IReadOnlyList<int> a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class RKWBYEIBIRA
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private sealed class IUJGUOISVQJ : VOKEFNRQEUR, IEquatable<VOKEFNRQEUR>
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
				public AsyncTaskMethodBuilder<MMSSFGQGRLF> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public IUJGUOISVQJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				private UDXPTWWACGU <roomManager>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				private TaskAwaiter<RoomDetailsDTO> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				private TaskAwaiter<MMSSFGQGRLF> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x8DB2AD0", Offset = "0x8DB18D0", VA = "0x188DB2AD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x8DB3060", Offset = "0x8DB1E60", VA = "0x188DB3060", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly SubRoomDataSaveDTO ZDNZWLDZFET;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int VRILQOKCCKH
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public Account YSYVBXZQTFA
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private DateTime WVZOJKRLQVQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x8D9F8F0", Offset = "0x8D9E6F0", VA = "0x188D9F8F0", Slot = "6")]
				get
				{
					return default(DateTime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public PlatformType? KBFPUMUKCHG
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2D67D20", Offset = "0x2D66B20", VA = "0x182D67D20", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public DeviceClass? LNVPZNQBJYP
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x8D9F7D0", Offset = "0x8D9E5D0", VA = "0x188D9F7D0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public RestoreOptionTypes DCFMKZSANFU
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "10")]
				get
				{
					return default(RestoreOptionTypes);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8D9F7F0", Offset = "0x8D9E5F0", VA = "0x188D9F7F0", Slot = "9")]
			[AsyncStateMachine(typeof(<Restore>d__13))]
			public Task<MMSSFGQGRLF> MZXKOSBITHN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8D9F950", Offset = "0x8D9E750", VA = "0x188D9F950")]
			public IUJGUOISVQJ(int a, Account b, SubRoomDataSaveDTO c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8D9F6C0", Offset = "0x8D9E4C0", VA = "0x188D9F6C0", Slot = "11")]
			public bool Equals(VOKEFNRQEUR other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8D9F620", Offset = "0x8D9E420", VA = "0x188D9F620", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8D9F910", Offset = "0x8D9E710", VA = "0x188D9F910")]
			private bool ZDMQIRUGZJZ(IUJGUOISVQJ a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8D9F750", Offset = "0x8D9E550", VA = "0x188D9F750", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private sealed class HTAHBBVXLTS : VOKEFNRQEUR, IEquatable<VOKEFNRQEUR>
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
				public AsyncTaskMethodBuilder<MMSSFGQGRLF> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public HTAHBBVXLTS <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				private TaskAwaiter<MMSSFGQGRLF> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x8DB3330", Offset = "0x8DB2130", VA = "0x188DB3330", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x8DB35F0", Offset = "0x8DB23F0", VA = "0x188DB35F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly JFLMODKHJZH LZFGJKYORTN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly PlatformType YVLXJRBBMOX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly DeviceClass MXMGVUWPKNQ;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int VRILQOKCCKH
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x8D9ECA0", Offset = "0x8D9DAA0", VA = "0x188D9ECA0", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Account YSYVBXZQTFA
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x8D9EFF0", Offset = "0x8D9DDF0", VA = "0x188D9EFF0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private DateTime WVZOJKRLQVQ
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x8D9F0D0", Offset = "0x8D9DED0", VA = "0x188D9F0D0", Slot = "6")]
				get
				{
					return default(DateTime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public PlatformType? KBFPUMUKCHG
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x8D9F080", Offset = "0x8D9DE80", VA = "0x188D9F080", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public DeviceClass? LNVPZNQBJYP
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x8D9EEB0", Offset = "0x8D9DCB0", VA = "0x188D9EEB0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public RestoreOptionTypes DCFMKZSANFU
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0xB16790", Offset = "0xB15590", VA = "0x180B16790", Slot = "10")]
				get
				{
					return default(RestoreOptionTypes);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x21AA670", Offset = "0x21A9470", VA = "0x1821AA670")]
			public HTAHBBVXLTS(JFLMODKHJZH a, PlatformType b, DeviceClass c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8D9EF00", Offset = "0x8D9DD00", VA = "0x188D9EF00", Slot = "9")]
			[AsyncStateMachine(typeof(<Restore>d__14))]
			public Task<MMSSFGQGRLF> MZXKOSBITHN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8D9ECE0", Offset = "0x8D9DAE0", VA = "0x188D9ECE0", Slot = "11")]
			public bool Equals(VOKEFNRQEUR other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8D9ED80", Offset = "0x8D9DB80", VA = "0x188D9ED80", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8D9F120", Offset = "0x8D9DF20", VA = "0x188D9F120")]
			private bool ZDMQIRUGZJZ(HTAHBBVXLTS a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8D9EE30", Offset = "0x8D9DC30", VA = "0x188D9EE30", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private sealed class UMFHHCQVORL : VOKEFNRQEUR, IEquatable<VOKEFNRQEUR>
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
				public AsyncTaskMethodBuilder<MMSSFGQGRLF> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				private TaskAwaiter<MMSSFGQGRLF> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x8DB30D0", Offset = "0x8DB1ED0", VA = "0x188DB30D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x8DB3580", Offset = "0x8DB2380", VA = "0x188DB3580", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly Account ZHPFEZBBFND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private readonly PlatformType YVLXJRBBMOX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private readonly DeviceClass MXMGVUWPKNQ;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public int VRILQOKCCKH
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x8DBAB70", Offset = "0x8DB9970", VA = "0x188DBAB70", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			[NotNull]
			public Account YSYVBXZQTFA
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private DateTime WVZOJKRLQVQ
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "6")]
				get
				{
					return default(DateTime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public PlatformType? KBFPUMUKCHG
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x8DBAE30", Offset = "0x8DB9C30", VA = "0x188DBAE30", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public DeviceClass? LNVPZNQBJYP
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x8DBAD10", Offset = "0x8DB9B10", VA = "0x188DBAD10", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public RestoreOptionTypes DCFMKZSANFU
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "10")]
				get
				{
					return default(RestoreOptionTypes);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x21AA670", Offset = "0x21A9470", VA = "0x1821AA670")]
			public UMFHHCQVORL(Account a, PlatformType b, DeviceClass c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8DBAD60", Offset = "0x8DB9B60", VA = "0x188DBAD60", Slot = "9")]
			[AsyncStateMachine(typeof(<Restore>d__14))]
			public Task<MMSSFGQGRLF> MZXKOSBITHN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8DBAB90", Offset = "0x8DB9990", VA = "0x188DBAB90", Slot = "11")]
			public bool Equals(VOKEFNRQEUR other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8DBAC00", Offset = "0x8DB9A00", VA = "0x188DBAC00", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8DBAC80", Offset = "0x8DB9A80", VA = "0x188DBAC80", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8DBAE80", Offset = "0x8DB9C80", VA = "0x188DBAE80")]
			private bool ZDMQIRUGZJZ(UMFHHCQVORL a)
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
			public RKWBYEIBIRA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private TaskAwaiter<IReadOnlyList<Account>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8DAA010", Offset = "0x8DA8E10", VA = "0x188DAA010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8DAA9A0", Offset = "0x8DA97A0", VA = "0x188DAA9A0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<IList<VOKEFNRQEUR>> <>t__builder;

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
			public RKWBYEIBIRA <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8DB13E0", Offset = "0x8DB01E0", VA = "0x188DB13E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8DB2230", Offset = "0x8DB1030", VA = "0x188DB2230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly NZNQCQEACIC PIBDFEPANFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly LMWCZJTHJJE YHEFKBNYBNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly NGHBVBJQDMO JQIBKCFBFXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly SUNTVRHFSNW<(long, long), IReadOnlyList<SubRoomDataSaveDTO>> TEYFEKVLOBG;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8DA1C00", Offset = "0x8DA0A00", VA = "0x188DA1C00")]
		[UnityEngine.Scripting.Preserve]
		public RKWBYEIBIRA([Inject(null)] LMWCZJTHJJE roomHistoryProvider, [Inject(null)] NGHBVBJQDMO roomAutosaveService, [Inject(null)] NZNQCQEACIC platformAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8DA1910", Offset = "0x8DA0710", VA = "0x188DA1910")]
		[AsyncStateMachine(typeof(<GetOrderedRestoreOptions>d__5))]
		public Task<IList<VOKEFNRQEUR>> NTLQJSTQVYS(long a, long b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8DA1A60", Offset = "0x8DA0860", VA = "0x188DA1A60")]
		private bool NWHXEWMCZRV(DateTime? a, long b, long c, [Out] JFLMODKHJZH d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8DA1800", Offset = "0x8DA0600", VA = "0x188DA1800")]
		[AsyncStateMachine(typeof(<CombineHistoryWithAccounts>d__7))]
		private Task<IReadOnlyList<(int, Account, SubRoomDataSaveDTO)>> AFFYXJWDZAI(IReadOnlyList<SubRoomDataSaveDTO> a)
		{
			return null;
		}
	}
}
namespace AutoSaves
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface NGHBVBJQDMO
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<JFLMODKHJZH> JZPUVDFLFQE;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KQWZASYFXFF(long a, long b, RoomSerializedData c, AutosaveType d);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KQQVUQOXWQJ(long a, long b, [Out] JFLMODKHJZH c);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool OJHDGLNUOEO(long a, long b, AutosaveType c, [Out] JFLMODKHJZH d);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LIXZIOYATWR(long a, long b);
	}
}
namespace RecRoom.RoomLoading
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal interface TUQBTWGFKKL : ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool CMXOLZTNCNX
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		Task TSSYBJDPVTH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TZDKEVNFSYU(Task a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal interface OVNBCFKHIDF : ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<MMSSFGQGRLF> RequestRestoreAutosave(JFLMODKHJZH autosaveRecordInfo);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task WTVJFGJQDZL(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal interface REGKVZCYSDQ : ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		VEURRDRAUAE VEURRDRAUAE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XMUIGCABVGP();

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZOJGUCJPJDZ();
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal interface ETETUEKLXQT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(ZVTYJEOYACF roomManager);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal interface CUJVBYRHGHA
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		TimeSpan XOTFEOCMAQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		TimeSpan FCAWNMBBNUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		TimeSpan WQDQSVSERFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		TimeSpan VSRSLZJUTKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool CNSMZGYEHRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool SBCXNPSWKCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool GRMYVZKRVQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		int TWNRPTVSWCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool ZFRKHVHRUXO
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool XVGQMMDKPBL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool NQHREHQFLZL
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
		[Cpp2IlInjected.Address(RVA = "0x8DA2A30", Offset = "0x8DA1830", VA = "0x188DA2A30")]
		public RoomEvent(long superRoomId, long subRoomId, RoomEventType type, [CanBeNull] Exception eventException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8DA29E0", Offset = "0x8DA17E0", VA = "0x188DA29E0")]
		public static RoomEvent From(RoomInstance room, RoomEventType type, [Optional] Exception eventException)
		{
			return default(RoomEvent);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void RoomEventHandler(RoomEvent roomEvent);
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal interface TFYHQZUXCEB : ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event RoomEventHandler FHVIXSJFNFX;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event RoomEventHandler GNARHGCSXIZ;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event RoomEventHandler DUYYGEVSLDD;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<RequestOperationType, bool> NNNBRHXLAFT;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void CKJETZNIRXL(RoomEvent a);

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void TLIKBYAYWJD(RoomEvent a);

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void KEXZCTHARFX(RoomEvent a);

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void BEHNOHMAAQN(RequestOperationType a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal interface XXZLGPMZMGT : ETETUEKLXQT, IDisposable, RTWKAVDCMOK
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool ZHEEMJKKXTF
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MZXALJKOVNT();
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal interface FKHXPTFDNYD : ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		TaskStatus HEERWSKRDRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task JoinRoomInstance(RoomInstance targetInstance, AJSGRYSVTDZ customRoomLoadPayload, CancellationToken externalToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class XFQQKOJZUEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8DBB300", Offset = "0x8DBA100", VA = "0x188DBB300")]
		public static bool XKNDLYTGHIN(this FKHXPTFDNYD a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate Task InLoadedRoomTaskBuilder(CancellationToken token, int roomTotalVersion, AccountRoleType localPlayerAccountRoleType);
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal interface PUSBFHUAPQW : ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KUZDJYPTOVM(InLoadedRoomTaskBuilder a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface ZVTYJEOYACF : UDXPTWWACGU, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		CancellationToken HBPQOIXBNGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		FDTRVDFSBYT EAZXUDHGNQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		VJRNQPLOUBG XSFZEBXHMFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		GHGHJRBBUAM TTTDMXCNLDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		OEJGLDFIKZO SNEHNJXCVIV
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		JNHZBTHIEBV SLRMBOKTDYE
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		GFMOTRWDXSL UYMCWOTSOGG
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		LXJOBNOPNUL XDFUUNIYPDY
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		XUVXRPWZBOR XUVXRPWZBOR
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		TUQBTWGFKKL DZFNXHBBGYI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		OVNBCFKHIDF KZKXKSTUOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		TFYHQZUXCEB WGQYKZXWXEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		XXZLGPMZMGT QYBLQJIWQKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		FKHXPTFDNYD FKTZDXOTGLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		PUSBFHUAPQW LGBTPBIMDHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ZGFDMZFGNNX KBNWLAXWGRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		RCRKBERRYIO TWAZRNGMKFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		WYSKBHTHKRF KLPWDCOKBEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		WELOPOYTVLQ RVRGCGAQYOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		DRIWUQXUIFC UMYVAUOAMOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		AYYYDIPYFGM YYYUXIKIAWB
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		JDIJDQHKTNX VWXSZGPBGRY
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		ZEAPVLGZEGH BXXZGRFBPNC
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		LEPSXTEQBZF QGILXNIZDUM
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		FKMBOALBBQX URREWBCHSAC
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		REGKVZCYSDQ ZGBWAPUEUIN
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		CUJVBYRHGHA TGQSZOPSFEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		QSRCFKDQEPO XGYVSXHZAMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		NGHBVBJQDMO FVZKCPDBZGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		SODNCFKUHBZ RJUITVSGTJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		LZGITPOTRPS HMWVUYCZQKU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		TBDOKCNPZCW ASAVYKINMRV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		LONPPRYZMAK TCPEWBPBDWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		new bool TXSCABRXJFK
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
		void FOXZYGNIZYD(AJSGRYSVTDZ a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal interface ZGFDMZFGNNX : ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PendingRequest Add(Guid operationId);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool Remove(Guid operationId);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool RWBVUWEUIWP(Guid a, Task b);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool XUTZXUIDFRN(Guid a, MMSSFGQGRLF b);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<(MMSSFGQGRLF, Task)> TWPVSZHJFZG(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface SJTVCEZJQNL : ETETUEKLXQT, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal interface RCRKBERRYIO : ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BHARPSCGTAM(FJZTCZTAMBW a);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PXMHXMZFXSD(FJZTCZTAMBW a);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RoomOperationType> ZIHZTCYSQLW(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal interface WYSKBHTHKRF : ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PendingRequest WHOOQUGHXHF(FJZTCZTAMBW a);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void TIPJORNDJKU(Guid a, Task b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal interface WELOPOYTVLQ : ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<MMSSFGQGRLF> RVRGCGAQYOF(FJZTCZTAMBW a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface DRIWUQXUIFC : ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RoomLoadRequestPayload> OFRZFJOBHCL(StackTimer<string>.XDYOTKRANGY a, RoomInstance b, CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal interface JDIJDQHKTNX : ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MMSSFGQGRLF WUPJCCBEMFF(XGOJTPBZDNO a);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task RequestSaveRoomToDisk(string path);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal interface AYYYDIPYFGM : ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<FJZTCZTAMBW> VETTTTDUTTI(FJZTCZTAMBW a, WAMQFEAEZXB b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<FJZTCZTAMBW> OXTBLYUEDIA(CancellationToken a, WAMQFEAEZXB b);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IRZBFTNHIIP OMTJXGUOMCL(EKKWWDICQVS a, StackTimer<string>.XDYOTKRANGY b);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IRZBFTNHIIP ZZGXEUPXELU(EKKWWDICQVS a, StackTimer<string>.XDYOTKRANGY b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface ZEAPVLGZEGH : ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MMSSFGQGRLF YKSSMEKWGTR(XGOJTPBZDNO a, RoomOperationType b);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		MMSSFGQGRLF WXELYSRSOFU(XGOJTPBZDNO a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public interface RJTZHSGPMIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		const int QLXVYBUYUKJ = 1000;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		IReadOnlyDictionary<Guid, RoomAssetDTO> IUCCMROXJXH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		Action MLIGAXYAYUA
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
		IReadOnlyList<Guid> JKVSQKVFQPG();

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task TMTJODXIOWU([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task SSWNTZXRGQQ([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface LEPSXTEQBZF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LUBQXDBALOP(IVKLSEJTYXV a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void YNRMYYUALRC(IVKLSEJTYXV a);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZLJPZKLEZFO(IVKLSEJTYXV a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MSMTGJXKFEA(IVKLSEJTYXV a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class IVKLSEJTYXV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly RoomInstance GRXVVTPMWWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Dictionary<string, string> RXYVXTKYDWO;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public StackTimer<string> AHFNHSREMJS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public IVKLSEJTYXV(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8D9F9B0", Offset = "0x8D9E7B0", VA = "0x188D9F9B0")]
		public IVKLSEJTYXV CNEWKQVUSNJ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8D9FA80", Offset = "0x8D9E880", VA = "0x188D9FA80")]
		public bool ZPWKSUECVVB([Out] IEnumerable<KeyValuePair<string, string>> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7D02C70", Offset = "0x7D01A70", VA = "0x187D02C70")]
		public IVKLSEJTYXV XQOIIQEESNC(StackTimer<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface QSRCFKDQEPO
	{
		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		bool FHNRGUCJMRE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		string XYFEJSUMOJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool MPAYOUNGGCT
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IEXNEFEOQEH();

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ULYAFHQAGRC JZLIDGBOCRU(long a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		LIEACBXUCRG<FilenameWithHash, SuperRoomData> NAXNNDXQYLA(long a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		LIEACBXUCRG<FilenameWithHash, PersistedRoomData> JQBZCDBFHNW(long a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		LIEACBXUCRG<long, MMCRDVBAEMD> QOXTNNZUFPG();

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<IReadOnlyCollection<BakedUnitySubAssetDTO>> IAHOVJVPAJQ(long a, IReadOnlyCollection<BakedUnitySubAssetDTO> b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool YZWHZLDMLKJ(long a, [Out] bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<bool> CAHWTEQCPTZ(byte[] a, byte[] b, IReadOnlyCollection<Guid> c, CancellationToken d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface JJUZHWLOPXU
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
	public interface UDXPTWWACGU : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		bool XKNDLYTGHIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool QEAWGDEBUOU
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool TXSCABRXJFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		JJUZHWLOPXU OAAPXBHCZEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		AJSGRYSVTDZ DGIONTLROFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event RoomEventHandler FHVIXSJFNFX;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event RoomEventHandler GNARHGCSXIZ;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RoomEventHandler DUYYGEVSLDD;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<RequestOperationType, bool> NNNBRHXLAFT;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void MZXALJKOVNT();

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		JLTAWNPKWMA MUOZEEASOJI();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "13")]
		UCZTNRMTMIH IJRCLJHHTVY();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Task DSDODHIMCDO(int a, RoomSaveRequestPayload b, Func<RoomSerializedData, RoomSerializedData> c);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task<MMSSFGQGRLF> RequestRestoreAutosave(JFLMODKHJZH autosaveRecord);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task WTVJFGJQDZL(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface JNHZBTHIEBV
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		bool ZPKEFGGBQVI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		bool YZESKPUSDCY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		Guid? LKQJCPZOFML
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ESSQCAMQLWU(Scene a);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task MEJMNZKFMUA(SJTYVQTPKZJ a, IReadOnlyList<SJTYVQTPKZJ> b, IReadOnlyList<SJTYVQTPKZJ> c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NGPDVZJZXCN(Guid a, IReadOnlyList<Guid> b, UnitySubAssetKind c, [Optional] object d);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task AKTYUFMBYIV(IReadOnlyList<Guid> a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		GXPZZIPDOXX ISUKJJGEYSP();

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task QSPEZLKSGGK();

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void LIFYABEUTHZ(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task SBBGRAWEGCU();
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface OEJGLDFIKZO
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		ZZSHRDKMGMU YWWFJNZECIV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		bool UZVBHUHACVB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		bool STPHCBUVAZN
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		bool HHJFBJCZLHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		bool CJTCSULKGMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		int RVZSVECUVXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		bool KFZBVYMRAGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(Slot = "50")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		bool KQEOKQAZELA
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(Slot = "58")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		int FQMCJFJCZIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "59")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		int FPWHRLBKXAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(Slot = "60")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		bool DHKEJKWWFRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(Slot = "61")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		bool ECXONQJXULX
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "66")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		bool ECHTVWCFSDW
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "67")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		float BQYVLNHXKPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "70")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action<float> NQOXRSYKQXS;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FDTRVDFSBYT RZVYHCLFANF(FDTRVDFSBYT a);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void INLXTMPVDUK(FDTRVDFSBYT a);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FLJPNATAAJU();

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task ShowLoadingScreen(StackTimer<string>.XDYOTKRANGY loadingScreenScope, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void FRSKTFVOHHK(float a);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void DINLGPMTUZZ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IReadOnlyList<LZHTVDPEIKI> FFUAOOBVIDR();

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IDisposable DHNDBVTSVSP(object a, LZHTVDPEIKI b);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "10")]
		IReadOnlyList<EmptySceneHandler> BCILFWSABZD();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "11")]
		SuperRoomData OPTWMROLTYP(IEnumerable<LZGZZRSUFGL> a);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void XUUPHOXEORL(int a);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task KCRKMARTNQM();

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void KQNFRUNEPQS();

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool JQBMIGLLCJF();

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		Task PJAHPLWDVVK(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task DJUQRETBSJA(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "21")]
		Task<LoadRecoveryAutosaveResponse> XYIDJZNLYEC(DateTime a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Task<bool> HZBGGHAPSZH(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void IIHFXUDZHZS(string a = "", float b = 3f);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "25")]
		RoomSerializedMetadata PODRVEYSYCZ(RoomSaveOptions a, SerializeType b, PersistedRoomData c, IEnumerable<PersistenceView> d, BTZWHYILXXM e);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void HTGBYILCXCP(PersistedRoomData a);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void PZVHLZOKNII(LZGZZRSUFGL a, [In] RoomSerializedMetadata metadata);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "28")]
		Task MXNGKYSODPS(PersistedRoomData a, bool b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "29")]
		Task RSCYHKQUFSL(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void XZWPKVIMEQA(long a, long b, RoomDetailsDTO c, SubRoomDataSaveDTO d, RoomSerializedData e, RoomSaveRequestPayload? roomSaveRequestPayload, RoomSaveAnalyticsInfo? f);

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void YAGJDGXFREF(long a, long b, RoomSaveAnalyticsInfo? c);

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void APIXJGEDKRG(PersistenceView a);

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void UJZAUZGCDLP(string a, RoomInstance b, RoomDTO c, [Optional] string? fallbackReason, [Optional] string? fallbackFailureReason, [Optional] string? subReason);

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool ZIBRIBVSNVN(PersistenceView a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		bool JWOMPKJFGCV(LZGZZRSUFGL a, DEPRECATED_RoomPersistenceVersion b, [Out] KAVWRHZEEFC c);

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task ESHTJMQAZMN(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void PNVZNWZGVPD();

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "38")]
		IDisposable YNGHNPCWQMF();

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "39")]
		void JYCSSAJSPER(PersistedRoomData a, DEPRECATED_RoomPersistenceVersion b);

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task<bool> RequestMasterSpawnNewLocalPlayer(VJRNQPLOUBG networking, CancellationToken cancellationToken, StackTimer<string>.XDYOTKRANGY stackTimer);

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "41")]
		void AEXIOWXLUES(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task<SaveSubRoomResponseDTO> JUJHTRFTOED(SaveSubRoomRequest a);

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task<RoomDetailsDTO> QMVTTPSGBFS(long a, bool b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<SubRoomDataSaveWithUnityAssetsDTO> HODIKFFEHHZ(long a, long b, long c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "45")]
		Task<SubRoomDataSaveDTO> ZPCDTQTZFRK(long a, long b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task<RoomLoadDTO> NCUDWFUXETI(long a, Guid b, long? c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "47")]
		LIEACBXUCRG<RoomLoadDTO, IEnumerable<RoomAssetData>> WRFSVAQUCJM();

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "48")]
		Task<RemoteRunDTO> KYEJWDSRYIB(string a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "49")]
		Task<RemoteRunDTO> YZRUDGIWQFK(string a, long b, long c, Guid? d, Storage.UploadFileResponseDTO e, Storage.UploadFileResponseDTO f, int g);

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "51")]
		bool SDATCZPUNUY();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "52")]
		bool KJBZLWTSXJA();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "53")]
		bool OHRLNVRNIMA(IEnumerable<KAVWRHZEEFC> a);

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void BulkDestroy(List<GameObject> objectsToDestroy);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "55")]
		float ASUXFXOABOZ();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "56")]
		Task<bool> WHWGAXUIJWH(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "57")]
		Task<Scene> HLUULBJCESD(string a, LoadSceneMode b, bool c, StackTimer<string>.XDYOTKRANGY d);

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
		void EESKJQHFZYT(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "71")]
		Task<Storage.UploadFileResponseDTO> GOJHUJADIDW(byte[] a, Storage.FileType b, MimeType c, [Optional] IReadOnlyCollection<string>? referencedFilenames, [Optional] string? filenameOverride);

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "72")]
		void RQYHTGQOCTL(RoomInstance a);

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "73")]
		Task HMCAKOYEFBW(StackTimer<string>.XDYOTKRANGY a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "74")]
		Task TriggerMClusterManager(StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "75")]
		Task TriggerScalabilityManager(StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "76")]
		Task TriggerClusterLodManager(StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "77")]
		IDisposable ORTEGTXIPPR();

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "78")]
		AHFXFAHTCGR FKPGNASHBMK();

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "79")]
		Task HideLoadingScreen(CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface AHFXFAHTCGR
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task PSANRICGXCJ(CancellationToken a);

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
	public interface ZZSHRDKMGMU
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		RoomInstance UEFZTRLYIGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		RoomDetailsDTO YBJAJXLBRLT
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		SubRoomDTO BBAOXJXEQZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		bool ARJRSAEXGYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		bool UZZONJKQBHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		int TFLJXQBEOKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action YBPDMKKESNM;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<int> ZZBHFJUUYDH;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void XALEBYZUJJW();

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<Matchmaking.ServerConnectionInfoDTO> GetServerConnectionInfo(long roomInstanceId, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<MatchmakingErrorCode> STTALHQUYBX(RoomInstance a, [Optional] AJSGRYSVTDZ b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task<MatchmakingErrorCode> ODJIORXHANB();

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Task UBTAHLZDHHM();

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		(RoomInstance, AJSGRYSVTDZ) TXUDTKLYCFH();

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		PlayerPresence XPVUNSOTRZS();

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void REBOPKYDAGP(long a);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void GILKORUZRNM(RoomInstance a, Matchmaking.GameJoinResult b, (int Major, int? Minor)? errorCode);
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface FKMBOALBBQX
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BDWHUBDLUPO([Out] IEnumerable<int> a);

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EEMCZLYGWJQ(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ASJPDNSTCNR(Token a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface LVYLIFOQRSG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string UPALOQFXWAP(MMSSFGQGRLF a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface KPDSJCCCIBW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BYSRLXJWFJS(CSDDGXBTCKR.ValidateOperation a);

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JVMOHGAEDTD(CSDDGXBTCKR.ValidateOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface GFMOTRWDXSL : KPDSJCCCIBW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MMSSFGQGRLF FNFTJYVJLPV(XGOJTPBZDNO a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public interface LXJOBNOPNUL : KPDSJCCCIBW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MMSSFGQGRLF WUPJCCBEMFF(XGOJTPBZDNO a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public interface ULYAFHQAGRC
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<XTUHIFEWQKQ, RHLDYTPLBXY>> FXIEPBVPPEE(Guid? a, IReadOnlyCollection<BakedUnitySubAssetDTO> b, IReadOnlyCollection<BakedUnitySubAssetDTO> c, AssetBundleLoadSource d, long? e, long? f, RecNet.Core.OnDownloadProgressDelegate g, CancellationToken h, bool i = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class XTUHIFEWQKQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public SJTYVQTPKZJ XOAFYTZJNPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public IReadOnlyList<SJTYVQTPKZJ> PUAWUEPNPWT
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public IReadOnlyList<SJTYVQTPKZJ> UCIVLLYMTDH
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xDF2D50", Offset = "0xDF1B50", VA = "0x180DF2D50")]
		public XTUHIFEWQKQ(SJTYVQTPKZJ a, IReadOnlyList<SJTYVQTPKZJ> b, IReadOnlyList<SJTYVQTPKZJ> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface LIEACBXUCRG<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<ParseResult<b>, RHLDYTPLBXY>> JBKJNRJTORB(a a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal sealed class RoomManager : ZVTYJEOYACF, UDXPTWWACGU, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class AHUCWXRYFRP : IEnumerable<ETETUEKLXQT>, IEnumerable, IEnumerator<ETETUEKLXQT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private ETETUEKLXQT QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private int DQRPPGNAYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public RoomManager WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			private ETETUEKLXQT ESQMWXTFRZG
			{
				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
			[DebuggerHidden]
			public AHUCWXRYFRP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x8D9B9B0", Offset = "0x8D9A7B0", VA = "0x188D9B9B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8D9B970", Offset = "0x8D9A770", VA = "0x188D9B970", Slot = "10")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x8D9BD60", Offset = "0x8D9AB60", VA = "0x188D9BD60", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ETETUEKLXQT> ZXXMFMRGNYT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8D9BD60", Offset = "0x8D9AB60", VA = "0x188D9BD60", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UYQUPSIMXFE()
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
			public AsyncTaskMethodBuilder<MMSSFGQGRLF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public RoomManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public JFLMODKHJZH autosaveRecordInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private TaskAwaiter<MMSSFGQGRLF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x8DB2550", Offset = "0x8DB1350", VA = "0x188DB2550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8DB27D0", Offset = "0x8DB15D0", VA = "0x188DB27D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DB2840", Offset = "0x8DB1640", VA = "0x188DB2840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8DB2A70", Offset = "0x8DB1870", VA = "0x188DB2A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly CancellationTokenSource LWUEFLUVDRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly FDTRVDFSBYT container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool IYRJDGYKKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private LogFlagsToken AYWLSHULWIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private bool GCGOFLLMDMJ;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public VJRNQPLOUBG XSFZEBXHMFP
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public GHGHJRBBUAM TTTDMXCNLDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAC31B0", Offset = "0xAC1FB0", VA = "0x180AC31B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public OEJGLDFIKZO SNEHNJXCVIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xAC31D0", Offset = "0xAC1FD0", VA = "0x180AC31D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAC3420", Offset = "0xAC2220", VA = "0x180AC3420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public JNHZBTHIEBV SLRMBOKTDYE
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xAC3410", Offset = "0xAC2210", VA = "0x180AC3410", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xAC31A0", Offset = "0xAC1FA0", VA = "0x180AC31A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public GFMOTRWDXSL UYMCWOTSOGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAC58D0", Offset = "0xAC46D0", VA = "0x180AC58D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public LXJOBNOPNUL XDFUUNIYPDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xAC8150", Offset = "0xAC6F50", VA = "0x180AC8150", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xAC81C0", Offset = "0xAC6FC0", VA = "0x180AC81C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public JJUZHWLOPXU OAAPXBHCZEB
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xAC8140", Offset = "0xAC6F40", VA = "0x180AC8140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public XUVXRPWZBOR XUVXRPWZBOR
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xAC81D0", Offset = "0xAC6FD0", VA = "0x180AC81D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public TUQBTWGFKKL DZFNXHBBGYI
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xB880F0", Offset = "0xB86EF0", VA = "0x180B880F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public OVNBCFKHIDF KZKXKSTUOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xAC7A60", Offset = "0xAC6860", VA = "0x180AC7A60", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public TFYHQZUXCEB WGQYKZXWXEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xB882D0", Offset = "0xB870D0", VA = "0x180B882D0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xB88330", Offset = "0xB87130", VA = "0x180B88330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public XXZLGPMZMGT QYBLQJIWQKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAC7160", Offset = "0xAC5F60", VA = "0x180AC7160", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAC7450", Offset = "0xAC6250", VA = "0x180AC7450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public FKHXPTFDNYD FKTZDXOTGLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xB88130", Offset = "0xB86F30", VA = "0x180B88130", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xB880C0", Offset = "0xB86EC0", VA = "0x180B880C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public PUSBFHUAPQW LGBTPBIMDHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xEF42F0", Offset = "0xEF30F0", VA = "0x180EF42F0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x151C850", Offset = "0x151B650", VA = "0x18151C850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public ZGFDMZFGNNX KBNWLAXWGRG
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xB880B0", Offset = "0xB86EB0", VA = "0x180B880B0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xBBC320", Offset = "0xBBB120", VA = "0x180BBC320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public SJTVCEZJQNL BUZRCRSJIYM
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xB880E0", Offset = "0xB86EE0", VA = "0x180B880E0", Slot = "60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xB882B0", Offset = "0xB870B0", VA = "0x180B882B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public RCRKBERRYIO TWAZRNGMKFL
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xB88140", Offset = "0xB86F40", VA = "0x180B88140", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xBBC360", Offset = "0xBBB160", VA = "0x180BBC360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public WYSKBHTHKRF KLPWDCOKBEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xAC7170", Offset = "0xAC5F70", VA = "0x180AC7170", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xAC7430", Offset = "0xAC6230", VA = "0x180AC7430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public WELOPOYTVLQ RVRGCGAQYOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xB4EAC0", Offset = "0xB4D8C0", VA = "0x180B4EAC0", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xB4DDE0", Offset = "0xB4CBE0", VA = "0x180B4DDE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public DRIWUQXUIFC UMYVAUOAMOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xB4EAE0", Offset = "0xB4D8E0", VA = "0x180B4EAE0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xB4E1C0", Offset = "0xB4CFC0", VA = "0x180B4E1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public AYYYDIPYFGM YYYUXIKIAWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xB4EAD0", Offset = "0xB4D8D0", VA = "0x180B4EAD0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xB4DF40", Offset = "0xB4CD40", VA = "0x180B4DF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public JDIJDQHKTNX VWXSZGPBGRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xB4A9B0", Offset = "0xB497B0", VA = "0x180B4A9B0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xB4A820", Offset = "0xB49620", VA = "0x180B4A820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public ZEAPVLGZEGH BXXZGRFBPNC
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xB57170", Offset = "0xB55F70", VA = "0x180B57170", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xB51DD0", Offset = "0xB50BD0", VA = "0x180B51DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public LEPSXTEQBZF QGILXNIZDUM
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xB4AE60", Offset = "0xB49C60", VA = "0x180B4AE60", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xB561D0", Offset = "0xB54FD0", VA = "0x180B561D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public FKMBOALBBQX URREWBCHSAC
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xB4CAD0", Offset = "0xB4B8D0", VA = "0x180B4CAD0", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xB4BD90", Offset = "0xB4AB90", VA = "0x180B4BD90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public REGKVZCYSDQ ZGBWAPUEUIN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xB22470", Offset = "0xB21270", VA = "0x180B22470", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xB4B730", Offset = "0xB4A530", VA = "0x180B4B730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public CUJVBYRHGHA TGQSZOPSFEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xB4CBC0", Offset = "0xB4B9C0", VA = "0x180B4CBC0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xB4CDD0", Offset = "0xB4BBD0", VA = "0x180B4CDD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public QSRCFKDQEPO XGYVSXHZAMR
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xC3D410", Offset = "0xC3C210", VA = "0x180C3D410", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xC79990", Offset = "0xC78790", VA = "0x180C79990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public NGHBVBJQDMO FVZKCPDBZGB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xBAF560", Offset = "0xBAE360", VA = "0x180BAF560", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public SODNCFKUHBZ RJUITVSGTJI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xBAF210", Offset = "0xBAE010", VA = "0x180BAF210", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public LZGITPOTRPS HMWVUYCZQKU
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xC3D480", Offset = "0xC3C280", VA = "0x180C3D480", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public TBDOKCNPZCW ASAVYKINMRV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xC3D470", Offset = "0xC3C270", VA = "0x180C3D470", Slot = "35")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public LONPPRYZMAK TCPEWBPBDWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xC3CF20", Offset = "0xC3BD20", VA = "0x180C3CF20", Slot = "36")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public AJSGRYSVTDZ DGIONTLROFL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xC3C160", Offset = "0xC3AF60", VA = "0x180C3C160", Slot = "58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xDA91E0", Offset = "0xDA7FE0", VA = "0x180DA91E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private bool UYEKQPWITYK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x8DA8D20", Offset = "0x8DA7B20", VA = "0x188DA8D20", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private bool IBKNAINSUPD
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x8DA8200", Offset = "0x8DA7000", VA = "0x188DA8200", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool QKTDTONBPMX
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1ADA980", Offset = "0x1AD9780", VA = "0x181ADA980", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private CancellationToken MVOVFFSYEHF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x8DA89E0", Offset = "0x8DA77E0", VA = "0x188DA89E0", Slot = "4")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private FDTRVDFSBYT FDFDKOOVYXS
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private bool UKKEZRTLQJA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1ADA980", Offset = "0x1AD9780", VA = "0x181ADA980", Slot = "37")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x1C832A0", Offset = "0x1C820A0", VA = "0x181C832A0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		private event RoomEventHandler NISBQYPNRCI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8DA8C00", Offset = "0x8DA7A00", VA = "0x188DA8C00", Slot = "40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8DA8860", Offset = "0x8DA7660", VA = "0x188DA8860", Slot = "41")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event RoomEventHandler QVFCJGUTUDC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8DA8D80", Offset = "0x8DA7B80", VA = "0x188DA8D80", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8DA8A00", Offset = "0x8DA7800", VA = "0x188DA8A00", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		private event RoomEventHandler UOMDNSYWHZY
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8DA8C60", Offset = "0x8DA7A60", VA = "0x188DA8C60", Slot = "44")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8DA7FA0", Offset = "0x8DA6DA0", VA = "0x188DA7FA0", Slot = "45")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		private event Action<RequestOperationType, bool> IQZSZTXJMJW
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x8DA8BA0", Offset = "0x8DA79A0", VA = "0x188DA8BA0", Slot = "46")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x8DA8CC0", Offset = "0x8DA7AC0", VA = "0x188DA8CC0", Slot = "47")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xDA91E0", Offset = "0xDA7FE0", VA = "0x180DA91E0", Slot = "39")]
		public void FOXZYGNIZYD(AJSGRYSVTDZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8DE0", Offset = "0x8DA7BE0", VA = "0x188DA8DE0")]
		[UnityEngine.Scripting.Preserve]
		internal RoomManager([Inject(null)] FDTRVDFSBYT container, [Inject(null)] VJRNQPLOUBG networking, [Inject(null)] GHGHJRBBUAM photonClient, [Inject(null)] OEJGLDFIKZO callbacks, [Inject(null)] JNHZBTHIEBV assetBundleManager, [Inject(null)] GFMOTRWDXSL roomReloadValidation, [Inject(null)] LXJOBNOPNUL roomSaveValidation, [Inject(null)] XUVXRPWZBOR debugRoomLoadInfo, [Inject(null)] TUQBTWGFKKL activeTask, [Inject(null)] OVNBCFKHIDF autosaves, [Inject(null)] TFYHQZUXCEB events, [Inject(null)] XXZLGPMZMGT fallbacks, [Inject(null)] FKHXPTFDNYD initialRoomLoad, [Inject(null)] PUSBFHUAPQW inRoomTasks, [Inject(null)] ZGFDMZFGNNX pendingRequests, [Inject(null)] SJTVCEZJQNL presenceUpdates, [Inject(null)] RCRKBERRYIO receiveOperation, [Inject(null)] WYSKBHTHKRF requestHandler, [Inject(null)] WELOPOYTVLQ requestOperation, [Inject(null)] DRIWUQXUIFC roomLoadRequest, [Inject(null)] JDIJDQHKTNX save, [Inject(null)] AYYYDIPYFGM synchronization, [Inject(null)] ZEAPVLGZEGH validation, [Inject(null)] LEPSXTEQBZF roomJoinAnalytics, [Inject(null)] FKMBOALBBQX playerSynchronization, [Inject(null)] CUJVBYRHGHA config, [Inject(null)] QSRCFKDQEPO roomLoadDataProviderOverride, [Inject(null)] NGHBVBJQDMO autosaveService, [Inject(null)] SODNCFKUHBZ cameraFade, [Inject(null)] LZGITPOTRPS errorRegistry, [Inject(null)] TBDOKCNPZCW onlineRestrictions, [Inject(null)] LONPPRYZMAK preEmptySceneHandler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8940", Offset = "0x8DA7740", VA = "0x188DA8940")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8DA85F0", Offset = "0x8DA73F0", VA = "0x188DA85F0", Slot = "59")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8B50", Offset = "0x8DA7950", VA = "0x188DA8B50", Slot = "51")]
		private void RJCPIUIYBEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8DA88C0", Offset = "0x8DA76C0", VA = "0x188DA88C0", Slot = "52")]
		private JLTAWNPKWMA IQTHURQEOWZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8280", Offset = "0x8DA7080", VA = "0x188DA8280", Slot = "53")]
		private UCZTNRMTMIH CWNZWNGRVYJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8300", Offset = "0x8DA7100", VA = "0x188DA8300", Slot = "55")]
		public Task DSDODHIMCDO(int a, RoomSaveRequestPayload b, Func<RoomSerializedData, RoomSerializedData> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8110", Offset = "0x8DA6F10", VA = "0x188DA8110")]
		private SYTSLLHFUJL BMSKQUDJBCI(int a, RoomSaveRequestPayload b, Func<RoomSerializedData, RoomSerializedData> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8000", Offset = "0x8DA6E00", VA = "0x188DA8000", Slot = "56")]
		[AsyncStateMachine(typeof(<RecRoom-RoomLoading-IRoomManager-RequestRestoreAutosave>d__165))]
		private Task<MMSSFGQGRLF> AIMSDTVWAVH(JFLMODKHJZH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8A60", Offset = "0x8DA7860", VA = "0x188DA8A60", Slot = "57")]
		[AsyncStateMachine(typeof(<RecRoom-RoomLoading-IRoomManager-RunRecoveryAutosave>d__166))]
		private Task PAVGORWLODU(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8DA87E0", Offset = "0x8DA75E0", VA = "0x188DA87E0")]
		[IteratorStateMachine(typeof(AHUCWXRYFRP))]
		private IEnumerable<ETETUEKLXQT> EZCZVLVAUIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8780", Offset = "0x8DA7580", VA = "0x188DA8780")]
		[CompilerGenerated]
		private void EPNFMNCISYN(ETETUEKLXQT a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class CameraFadeTimeoutException : TimeoutException
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1AFF6E0", Offset = "0x1AFE4E0", VA = "0x181AFF6E0")]
		public CameraFadeTimeoutException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal class FallbackToBootScene : HKXMBRRJASZ
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
			public AsyncTaskMethodBuilder<HKXMBRRJASZ.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public HashSet<RTWKAVDCMOK.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public FallbackToBootScene <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8DB6670", Offset = "0x8DB5470", VA = "0x188DB6670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8DB6970", Offset = "0x8DB5770", VA = "0x188DB6970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly ZVTYJEOYACF SLBUPCNYZAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly OEJGLDFIKZO FFRQMGYVOAZ;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		private string MYLXUJZQNOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8D9E030", Offset = "0x8D9CE30", VA = "0x188D9E030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xABFA30", Offset = "0xABE830", VA = "0x180ABFA30")]
		public FallbackToBootScene(ZVTYJEOYACF roomManager, OEJGLDFIKZO callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8D9DF20", Offset = "0x8D9CD20", VA = "0x188D9DF20", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__6))]
		public Task<HKXMBRRJASZ.Result> JMHSFAPUDKW(HashSet<RTWKAVDCMOK.Reason> a, CancellationToken b, RTWKAVDCMOK.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal class FallbackToOfflineDormRoom : ZNDUCTONFJM, HKXMBRRJASZ
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
			public AsyncTaskMethodBuilder<HKXMBRRJASZ.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public FallbackToOfflineDormRoom <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public HashSet<RTWKAVDCMOK.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public RTWKAVDCMOK.Reason reason;

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
			private TaskAwaiter<HKXMBRRJASZ.Result> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8DB4F60", Offset = "0x8DB3D60", VA = "0x188DB4F60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8DB6590", Offset = "0x8DB5390", VA = "0x188DB6590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly KGDITIUSTQK TFNECJLJALX;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		private string MYLXUJZQNOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x8D9E230", Offset = "0x8D9D030", VA = "0x188D9E230", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E2E0", Offset = "0x8D9D0E0", VA = "0x188D9E2E0")]
		public FallbackToOfflineDormRoom([Inject(null)] ZVTYJEOYACF roomManager, [Inject(null)] OEJGLDFIKZO callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E0E0", Offset = "0x8D9CEE0", VA = "0x188D9E0E0", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__5))]
		public Task<HKXMBRRJASZ.Result> JMHSFAPUDKW(HashSet<RTWKAVDCMOK.Reason> a, CancellationToken b, RTWKAVDCMOK.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal class FallbackToOfflineMultiplayerOrientationSubRoom : ZNDUCTONFJM, HKXMBRRJASZ
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
			public AsyncTaskMethodBuilder<HKXMBRRJASZ.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public FallbackToOfflineMultiplayerOrientationSubRoom <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public HashSet<RTWKAVDCMOK.Reason> fallbackTriggersToIgnore;

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
			private TaskAwaiter<HKXMBRRJASZ.Result> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x8DB4500", Offset = "0x8DB3300", VA = "0x188DB4500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x8DB4EF0", Offset = "0x8DB3CF0", VA = "0x188DB4EF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		private string MYLXUJZQNOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8D9E500", Offset = "0x8D9D300", VA = "0x188D9E500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xABFA30", Offset = "0xABE830", VA = "0x180ABFA30")]
		public FallbackToOfflineMultiplayerOrientationSubRoom(ZVTYJEOYACF roomManager, OEJGLDFIKZO callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E3B0", Offset = "0x8D9D1B0", VA = "0x188D9E3B0", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__4))]
		public Task<HKXMBRRJASZ.Result> JMHSFAPUDKW(HashSet<RTWKAVDCMOK.Reason> a, CancellationToken b, RTWKAVDCMOK.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal class FallbackToOnlineDormRoom : ZNDUCTONFJM, HKXMBRRJASZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class QFVEKDSMASK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public MatchmakingErrorCode BIPAFEKFNHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public RoomInstance ENDRWMJMDCV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public long CQTIIJYCQMJ;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QFVEKDSMASK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x8DA1690", Offset = "0x8DA0490", VA = "0x188DA1690")]
			internal object RJRVWIXXEVE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8DA1710", Offset = "0x8DA0510", VA = "0x188DA1710")]
			internal object RJXCTPRUOGN()
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
			public AsyncTaskMethodBuilder<HKXMBRRJASZ.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public FallbackToOnlineDormRoom <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public HashSet<RTWKAVDCMOK.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private QFVEKDSMASK <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public RTWKAVDCMOK.Reason reason;

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
			private TaskAwaiter<HKXMBRRJASZ.Result> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8DB5930", Offset = "0x8DB4730", VA = "0x188DB5930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x8DB6600", Offset = "0x8DB5400", VA = "0x188DB6600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly KGDITIUSTQK TFNECJLJALX;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		private string MYLXUJZQNOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8D9E700", Offset = "0x8D9D500", VA = "0x188D9E700", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E7B0", Offset = "0x8D9D5B0", VA = "0x188D9E7B0")]
		public FallbackToOnlineDormRoom([Inject(null)] ZVTYJEOYACF roomManager, [Inject(null)] OEJGLDFIKZO callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E5B0", Offset = "0x8D9D3B0", VA = "0x188D9E5B0", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__5))]
		public Task<HKXMBRRJASZ.Result> JMHSFAPUDKW(HashSet<RTWKAVDCMOK.Reason> a, CancellationToken b, RTWKAVDCMOK.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal abstract class ZNDUCTONFJM
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
			public HashSet<RTWKAVDCMOK.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public ZNDUCTONFJM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private List<RTWKAVDCMOK.Reason> <newDisconnectTriggers>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x8DB0BE0", Offset = "0x8DAF9E0", VA = "0x188DB0BE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1100", Offset = "0x8DAFF00", VA = "0x188DB1100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		protected readonly ZVTYJEOYACF SLBUPCNYZAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		protected readonly OEJGLDFIKZO FFRQMGYVOAZ;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected ZZSHRDKMGMU YWWFJNZECIV
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x8DBB5D0", Offset = "0x8DBA3D0", VA = "0x188DBB5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xABFA30", Offset = "0xABE830", VA = "0x180ABFA30")]
		public ZNDUCTONFJM(ZVTYJEOYACF a, OEJGLDFIKZO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8DBB4A0", Offset = "0x8DBA2A0", VA = "0x188DBB4A0")]
		[AsyncStateMachine(typeof(<DisconnectFromRoomInstance>d__5))]
		protected Task DisconnectFromRoomInstance(Log log, HashSet<RTWKAVDCMOK.Reason> fallbackTriggersToIgnore, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class ZNRPTCXNASL
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class ZLLAWYXLGFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public string IWRAHWMKWBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public ZVTYJEOYACF SLBUPCNYZAL;

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZLLAWYXLGFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x8DBB3A0", Offset = "0x8DBA1A0", VA = "0x188DBB3A0")]
			internal object RXLARBTZRBB()
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
			public AsyncTaskMethodBuilder<HKXMBRRJASZ.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public OEJGLDFIKZO callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private float <timeoutTime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x8DBA410", Offset = "0x8DB9210", VA = "0x188DBA410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x8DBA790", Offset = "0x8DB9590", VA = "0x188DBA790", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public static readonly float FIGZRJNNDGT;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		internal static readonly HashSet<RTWKAVDCMOK.Reason> NFXTXDBJRIO;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8DBB790", Offset = "0x8DBA590", VA = "0x188DBB790")]
		[AsyncStateMachine(typeof(<WaitForPlayerToSpawn>d__2))]
		internal static Task<HKXMBRRJASZ.Result> ZRIIEJXNWJK(OEJGLDFIKZO a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8DBB620", Offset = "0x8DBA420", VA = "0x188DBB620")]
		internal static void MHCTQFINJLD(ZVTYJEOYACF a, Log b, string c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal interface HKXMBRRJASZ
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public struct Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public bool success;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public RTWKAVDCMOK.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public Enum? subReason;

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x8DA29D0", Offset = "0x8DA17D0", VA = "0x188DA29D0")]
			public static Result Success()
			{
				return default(Result);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x8DA29A0", Offset = "0x8DA17A0", VA = "0x188DA29A0")]
			public static Result Failure(RTWKAVDCMOK.Reason reason, [Optional] Enum? subReason)
			{
				return default(Result);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		string KOUFZTHPLQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<Result> JMHSFAPUDKW(HashSet<RTWKAVDCMOK.Reason> a, CancellationToken b, RTWKAVDCMOK.Reason c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal struct RestoreRecoveryAutosaveInRoomTask
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class ZLLAWYXLGFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public ZVTYJEOYACF OHUMEPMNHVY;

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZLLAWYXLGFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x8DBB350", Offset = "0x8DBA150", VA = "0x188DBB350")]
			internal Task MSFXADHKYMC(CancellationToken a, int b, AccountRoleType c)
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
			private JFLMODKHJZH <autosaveInfo>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private TaskAwaiter<LoadRecoveryAutosaveResponse> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private TaskAwaiter<MMSSFGQGRLF> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x8DB69E0", Offset = "0x8DB57E0", VA = "0x188DB69E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x8DB6F70", Offset = "0x8DB5D70", VA = "0x188DB6F70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DBA800", Offset = "0x8DB9600", VA = "0x188DBA800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x8DBAB10", Offset = "0x8DB9910", VA = "0x188DBAB10", Slot = "5")]
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
		private readonly ZVTYJEOYACF manager;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private VJRNQPLOUBG XSFZEBXHMFP
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x8DA2950", Offset = "0x8DA1750", VA = "0x188DA2950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		private OEJGLDFIKZO SNEHNJXCVIV
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x8DA2570", Offset = "0x8DA1370", VA = "0x188DA2570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		private ZZSHRDKMGMU YWWFJNZECIV
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x8DA28D0", Offset = "0x8DA16D0", VA = "0x188DA28D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private OVNBCFKHIDF KZKXKSTUOIO
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x8DA2400", Offset = "0x8DA1200", VA = "0x188DA2400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2AEC300", Offset = "0x2AEB100", VA = "0x182AEC300")]
		public RestoreRecoveryAutosaveInRoomTask(CancellationToken cancellationToken, ZVTYJEOYACF manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8DA2450", Offset = "0x8DA1250", VA = "0x188DA2450")]
		public static InLoadedRoomTaskBuilder IXIQLSPAJBI(ZVTYJEOYACF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8DA27C0", Offset = "0x8DA15C0", VA = "0x188DA27C0")]
		[AsyncStateMachine(typeof(<Run>d__4))]
		public Task<bool> Run()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8DA21F0", Offset = "0x8DA0FF0", VA = "0x188DA21F0")]
		private bool BBEEOQMCOFT([Out] JFLMODKHJZH a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8DA25C0", Offset = "0x8DA13C0", VA = "0x188DA25C0")]
		[AsyncStateMachine(typeof(<WaitUntilWatchMenuIsReady>d__6))]
		private Task JYIYJSHZZZP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8DA2690", Offset = "0x8DA1490", VA = "0x188DA2690")]
		private Task<LoadRecoveryAutosaveResponse> LWASYRYNVXC(JFLMODKHJZH a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal struct PendingRequest : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly ZGFDMZFGNNX pendingRequests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private Task<(MMSSFGQGRLF, Task)> FVLFNKXJJAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x8DA0E30", Offset = "0x8D9FC30", VA = "0x188DA0E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x5306230", Offset = "0x5305030", VA = "0x185306230")]
		public PendingRequest(ZGFDMZFGNNX pendingRequests, Guid operationId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0F00", Offset = "0x8D9FD00", VA = "0x188DA0F00")]
		public TaskAwaiter<(MMSSFGQGRLF, Task)> RMUULWGIHOS()
		{
			return default(TaskAwaiter<(MMSSFGQGRLF, Task)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0D60", Offset = "0x8D9FB60", VA = "0x188DA0D60", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal struct PendingRequestData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly TaskCompletionSource<(MMSSFGQGRLF, Task)> taskCompletion;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Task<(MMSSFGQGRLF, Task)> FVLFNKXJJAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x8DA0AD0", Offset = "0x8D9F8D0", VA = "0x188DA0AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0BF0", Offset = "0x8D9F9F0", VA = "0x188DA0BF0")]
		public PendingRequestData(TimeSpan timeout)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8DA09A0", Offset = "0x8D9F7A0", VA = "0x188DA09A0")]
		public void CQHPRIWUDUG(Task a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0B10", Offset = "0x8D9F910", VA = "0x188DA0B10")]
		public void RMSJCQKJFDS(MMSSFGQGRLF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0BA0", Offset = "0x8D9F9A0", VA = "0x188DA0BA0")]
		public void VXTOMBOPEXG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0A40", Offset = "0x8D9F840", VA = "0x188DA0A40")]
		internal void FBHCEVXBRYC(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class RNLNJKNIEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8DA1D20", Offset = "0x8DA0B20", VA = "0x188DA1D20")]
		public static RoomLoadRequestPayload WAUXSUIYUXR(this RoomLoadRequestPayload a, RoomDetailsDTO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8DA1EC0", Offset = "0x8DA0CC0", VA = "0x188DA1EC0")]
		public static RoomLoadRequestPayload ZHQKOLMCKRN(this RoomLoadRequestPayload a, SubRoomDataSaveDTO b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal sealed class OAAPXBHCZEB : JJUZHWLOPXU
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class QFVEKDSMASK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public SubRoomDataSaveDTO YXLYERCKXOB;

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QFVEKDSMASK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x8DA17D0", Offset = "0x8DA05D0", VA = "0x188DA17D0")]
			internal bool VIIUZUSMIFP(SubRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly CUJVBYRHGHA DMJXIDXOJJI;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public OAAPXBHCZEB(CUJVBYRHGHA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0860", Offset = "0x8D9F660", VA = "0x188DA0860", Slot = "4")]
		public RoomLoadRequestPayload Create(long superRoomId, long subRoomId, string studioSessionId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0230", Offset = "0x8D9F030", VA = "0x188DA0230", Slot = "5")]
		public RoomLoadRequestPayload Create(long superRoomId, long subRoomId, FilenameWithHash superRoomData, Guid? snapshotId, long subRoomDataSaveId, bool loadUsedCompatibility)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0660", Offset = "0x8D9F460", VA = "0x188DA0660", Slot = "6")]
		public RoomLoadRequestPayload Create(SaveSubRoomResponseDTO saveSubRoomResponseDTO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0390", Offset = "0x8D9F190", VA = "0x188DA0390", Slot = "7")]
		public RoomLoadRequestPayload Create(RoomDetailsDTO superRoom, SubRoomDataSaveDTO subRoomSave)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8DA08F0", Offset = "0x8D9F6F0", VA = "0x188DA08F0")]
		private Guid? RSOBYHCFVPJ(RoomDetailsDTO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerActiveTask : TUQBTWGFKKL, ETETUEKLXQT, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x8DB3660", Offset = "0x8DB2460", VA = "0x188DB3660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x8DB3CC0", Offset = "0x8DB2AC0", VA = "0x188DB3CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly Token HMQAQDEQXPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private string LCIYECUQGDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private Task BDMELCENRHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private ZVTYJEOYACF SLBUPCNYZAL;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public bool CMXOLZTNCNX
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x8DA2A50", Offset = "0x8DA1850", VA = "0x188DA2A50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public Task TSSYBJDPVTH
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x8DA2BA0", Offset = "0x8DA19A0", VA = "0x188DA2BA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650", Slot = "7")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8DA2C30", Offset = "0x8DA1A30", VA = "0x188DA2C30", Slot = "6")]
		public void TZDKEVNFSYU(Task a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8DA2A80", Offset = "0x8DA1880", VA = "0x188DA2A80")]
		[AsyncStateMachine(typeof(<RunAndSetCurrentTask>d__11))]
		private Task JICYOZUUETH(Task a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8DA2D90", Offset = "0x8DA1B90", VA = "0x188DA2D90")]
		public RoomManagerActiveTask()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	internal class IOJVSPYTBHT : REGKVZCYSDQ, ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private bool FKDLRAVWDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private VEURRDRAUAE CZGYOSHEZJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private VJRNQPLOUBG FBPQEEAUUKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private CUJVBYRHGHA SARRDALHDLD;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public VEURRDRAUAE VEURRDRAUAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x8D9F400", Offset = "0x8D9E200", VA = "0x188D9F400", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x8D9F1C0", Offset = "0x8D9DFC0", VA = "0x188D9F1C0", Slot = "7")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8D9F470", Offset = "0x8D9E270", VA = "0x188D9F470", Slot = "5")]
		public void XMUIGCABVGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8D9F180", Offset = "0x8D9DF80", VA = "0x188D9F180", Slot = "6")]
		public void ZOJGUCJPJDZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8D9F340", Offset = "0x8D9E140", VA = "0x188D9F340")]
		private Task LVHCREYQSYW(DisconnectCause a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8D9F180", Offset = "0x8D9DF80", VA = "0x188D9F180", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public IOJVSPYTBHT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal class QDSRTWZBCPH : CUJVBYRHGHA
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		private class Config<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly YEADHGPVUSS FOXDZJJKEZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly string NFCNRPBPDKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly T CPLSPWOUGCF;

			[Cpp2IlInjected.Token(Token = "0x170000B4")]
			public T REKHREVTQMM
			{
				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0xB12A00", Offset = "0xB11800", VA = "0x180B12A00")]
				[CompilerGenerated]
				get
				{
					return (T)null;
				}
				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0xBA1650", Offset = "0xBA0450", VA = "0x180BA1650")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x42D5EC0", Offset = "0x42D4CC0", VA = "0x1842D5EC0")]
			public Config(YEADHGPVUSS gameConfigsProvider, string key, T defaultValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x42D5870", Offset = "0x42D4670", VA = "0x1842D5870")]
			private void OMEEQWZHUDV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly YEADHGPVUSS FOXDZJJKEZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly Config<TimeSpan> ACUFVJHOGYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly Config<TimeSpan> CSBGLNYBIMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly Config<TimeSpan> MTBAZTQLICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly Config<TimeSpan> YYAXBLBHLLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly Config<bool> TJKCWIJMYLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly Config<bool> BYFCLXNZPUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Config<bool> ZRHPAPYFOWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Config<int> ADAKKFMEZOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private readonly Config<bool> GDAOGUBWOYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly Config<bool> AEOWIHMQHIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly Config<PlatformMask> XRYLYVQPLUI;

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public TimeSpan XOTFEOCMAQY
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8DA11A0", Offset = "0x8D9FFA0", VA = "0x188DA11A0", Slot = "4")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public TimeSpan FCAWNMBBNUA
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x8DA10E0", Offset = "0x8D9FEE0", VA = "0x188DA10E0", Slot = "5")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public TimeSpan WQDQSVSERFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x8DA0F90", Offset = "0x8D9FD90", VA = "0x188DA0F90", Slot = "6")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public TimeSpan VSRSLZJUTKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x8DA0F50", Offset = "0x8D9FD50", VA = "0x188DA0F50", Slot = "7")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool CNSMZGYEHRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x8DA10A0", Offset = "0x8D9FEA0", VA = "0x188DA10A0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool SBCXNPSWKCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8DA0FD0", Offset = "0x8D9FDD0", VA = "0x188DA0FD0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool GRMYVZKRVQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x8DA11E0", Offset = "0x8D9FFE0", VA = "0x188DA11E0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public int TWNRPTVSWCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x8DA1010", Offset = "0x8D9FE10", VA = "0x188DA1010", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool ZFRKHVHRUXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x8DA1120", Offset = "0x8D9FF20", VA = "0x188DA1120", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public bool XVGQMMDKPBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x8DA1160", Offset = "0x8D9FF60", VA = "0x188DA1160", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public bool NQHREHQFLZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8DA1050", Offset = "0x8D9FE50", VA = "0x188DA1050", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8DA1220", Offset = "0x8DA0020", VA = "0x188DA1220")]
		[UnityEngine.Scripting.Preserve]
		public QDSRTWZBCPH([Inject(null)] YEADHGPVUSS gameConfigsProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomManagerEvents : TFYHQZUXCEB, ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private sealed class BEYJMNWUOVG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public RoomEvent DMPBAPRCRCQ;

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public BEYJMNWUOVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x8D9BE70", Offset = "0x8D9AC70", VA = "0x188D9BE70")]
			internal object DOSXZYVTLRL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event RoomEventHandler FHVIXSJFNFX
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x8DA3270", Offset = "0x8DA2070", VA = "0x188DA3270", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x8DA33B0", Offset = "0x8DA21B0", VA = "0x188DA33B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event RoomEventHandler GNARHGCSXIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x8DA3450", Offset = "0x8DA2250", VA = "0x188DA3450", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x8DA2FE0", Offset = "0x8DA1DE0", VA = "0x188DA2FE0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event RoomEventHandler DUYYGEVSLDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x8DA2E10", Offset = "0x8DA1C10", VA = "0x188DA2E10", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x8DA3310", Offset = "0x8DA2110", VA = "0x188DA3310", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<RequestOperationType, bool> NNNBRHXLAFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x8DA3520", Offset = "0x8DA2320", VA = "0x188DA3520", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x8DA2F00", Offset = "0x8DA1D00", VA = "0x188DA2F00", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "16")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8DA2FB0", Offset = "0x8DA1DB0", VA = "0x188DA2FB0", Slot = "12")]
		public void CKJETZNIRXL(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8DA34F0", Offset = "0x8DA22F0", VA = "0x188DA34F0", Slot = "13")]
		public void TLIKBYAYWJD(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3240", Offset = "0x8DA2040", VA = "0x188DA3240", Slot = "14")]
		public void KEXZCTHARFX(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8DA2EB0", Offset = "0x8DA1CB0", VA = "0x188DA2EB0", Slot = "15")]
		public void BEHNOHMAAQN(RequestOperationType a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3080", Offset = "0x8DA1E80", VA = "0x188DA3080")]
		private void Invoke(RoomEventHandler handler, RoomEvent roomEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomManagerEvents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomManagerFallbacks : XXZLGPMZMGT, ETETUEKLXQT, IDisposable, RTWKAVDCMOK
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		private class CDZETYBXCDA : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class VCNKWXLRMEL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				public RTWKAVDCMOK.FallbackReason LOIITRXDCLV;

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public VCNKWXLRMEL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x8DBAFF0", Offset = "0x8DB9DF0", VA = "0x188DBAFF0")]
				internal object MRANWOSRWZH((RTWKAVDCMOK.Reason fallbackReason, RoomDTO roomDto, GDSSPZZXVGE state, string subReason) x)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000074")]
			[CompilerGenerated]
			private sealed class MALXDQDZUBF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public HKXMBRRJASZ NDEVMCWVVTS;

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public MALXDQDZUBF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x8DA0130", Offset = "0x8D9EF30", VA = "0x188DA0130")]
				internal object GYILZDOXFUS()
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
				public CDZETYBXCDA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				public RTWKAVDCMOK.FallbackReason reason;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				private LogRangeScope <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				private HKXMBRRJASZ[] <>7__wrap2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				private int <>7__wrap3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				private TaskAwaiter<HKXMBRRJASZ.Result> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x8DB3D20", Offset = "0x8DB2B20", VA = "0x188DB3D20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x8DB44A0", Offset = "0x8DB32A0", VA = "0x188DB44A0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<HKXMBRRJASZ.Result> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400013B")]
				public HKXMBRRJASZ fallbackProvider;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public CDZETYBXCDA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				public RTWKAVDCMOK.FallbackReason reason;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				private LogRangeScope <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				private GDSSPZZXVGE <individualFallbackTaskState>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				private TaskAwaiter<HKXMBRRJASZ.Result> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x8DB88E0", Offset = "0x8DB76E0", VA = "0x188DB88E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x8DB9550", Offset = "0x8DB8350", VA = "0x188DB9550", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Task UDEVSVRDCHY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public CancellationTokenSource HRTORHGBPHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public GDSSPZZXVGE DZHZWCGFEFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public OEJGLDFIKZO FFRQMGYVOAZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public RoomDTO LOXHTFXUQTH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public RoomInstance AKEYXJWQXWD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public HKXMBRRJASZ[] USKCSOQTIAF;

			[Cpp2IlInjected.Token(Token = "0x170000B8")]
			public bool ZGWVPPYLWBK
			{
				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x8D9D010", Offset = "0x8D9BE10", VA = "0x188D9D010")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B9")]
			public bool LOGLISBBYNG
			{
				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x8D9C7D0", Offset = "0x8D9B5D0", VA = "0x188D9C7D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x8D9D8F0", Offset = "0x8D9C6F0", VA = "0x188D9D8F0")]
			public CDZETYBXCDA(OEJGLDFIKZO a, RoomDTO b, RoomInstance c, HKXMBRRJASZ[] d, CancellationToken e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x8D9BF40", Offset = "0x8D9AD40", VA = "0x188D9BF40", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x8D9D880", Offset = "0x8D9C680", VA = "0x188D9D880")]
			public void ZLSSBJJMLAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x8D9C0C0", Offset = "0x8D9AEC0", VA = "0x188D9C0C0")]
			public void GHEPQRZVELR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8D9C9B0", Offset = "0x8D9B7B0", VA = "0x188D9C9B0")]
			public void QVLJLFLHTWE(RTWKAVDCMOK.Reason a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x8D9C7F0", Offset = "0x8D9B5F0", VA = "0x188D9C7F0")]
			[AsyncStateMachine(typeof(<RunFallbackSequence>d__16))]
			public Task NTNEERRJEWT(RTWKAVDCMOK.FallbackReason a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x8D9C4C0", Offset = "0x8D9B2C0", VA = "0x188D9C4C0")]
			[AsyncStateMachine(typeof(<TryRunFallback>d__17))]
			private Task<HKXMBRRJASZ.Result> KKQFWVQXNNV(RTWKAVDCMOK.FallbackReason a, HKXMBRRJASZ b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x8D9D760", Offset = "0x8D9C560", VA = "0x188D9D760")]
			private void XWWEKUQXUOY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8D9C900", Offset = "0x8D9B700", VA = "0x188D9C900")]
			public bool OWZFUHQEWOV(RTWKAVDCMOK.Reason a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x8D9D370", Offset = "0x8D9C170", VA = "0x188D9D370")]
			private void VOVJXBNWHOX(GDSSPZZXVGE a, RTWKAVDCMOK.FallbackReason b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8D9C610", Offset = "0x8D9B410", VA = "0x188D9C610")]
			private void KPHLTIBAAOI(GDSSPZZXVGE a, HKXMBRRJASZ.Result b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8D9C220", Offset = "0x8D9B020", VA = "0x188D9C220")]
			private void IDUHNNMHHUU(GDSSPZZXVGE a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x8D9CC50", Offset = "0x8D9BA50", VA = "0x188D9CC50")]
			private void RVRSNWOZQUB(GDSSPZZXVGE a, HKXMBRRJASZ.Result b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8D9D600", Offset = "0x8D9C400", VA = "0x188D9D600")]
			private void XEOEUPTTIQO(GDSSPZZXVGE a, Exception b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8D9D260", Offset = "0x8D9C060", VA = "0x188D9D260")]
			private void UJJSDVBKEYT(HKXMBRRJASZ a, RTWKAVDCMOK.FallbackReason b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8D9C3B0", Offset = "0x8D9B1B0", VA = "0x188D9C3B0")]
			private void JPSUIYRKFGZ(HKXMBRRJASZ a, RTWKAVDCMOK.Reason b, string c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x8D9D030", Offset = "0x8D9BE30", VA = "0x188D9D030", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public class GDSSPZZXVGE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Task<HKXMBRRJASZ.Result> UDEVSVRDCHY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public CancellationTokenSource HRTORHGBPHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public HKXMBRRJASZ NDEVMCWVVTS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public RTWKAVDCMOK.Reason KBYPSNOUXHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public HashSet<RTWKAVDCMOK.Reason> ENPSRVJJMWT;

			[Cpp2IlInjected.Token(Token = "0x170000BA")]
			public bool ZGWVPPYLWBK
			{
				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x8D9D010", Offset = "0x8D9BE10", VA = "0x188D9D010")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BB")]
			public bool LOGLISBBYNG
			{
				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x8D9C7D0", Offset = "0x8D9B5D0", VA = "0x188D9C7D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x8D9E880", Offset = "0x8D9D680", VA = "0x188D9E880")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x8D9E9E0", Offset = "0x8D9D7E0", VA = "0x188D9E9E0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x8D9EA00", Offset = "0x8D9D800", VA = "0x188D9EA00", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x8D9EC20", Offset = "0x8D9DA20", VA = "0x188D9EC20")]
			public GDSSPZZXVGE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class RVDZJLMSLEQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public RTWKAVDCMOK.Reason LOIITRXDCLV;

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public RVDZJLMSLEQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8DA2110", Offset = "0x8DA0F10", VA = "0x188DA2110")]
			internal object QENQVRFSDVE(GDSSPZZXVGE a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x8DA20A0", Offset = "0x8DA0EA0", VA = "0x188DA20A0")]
			internal object QEIJYKLUUJV(CDZETYBXCDA a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x8DA2030", Offset = "0x8DA0E30", VA = "0x188DA2030")]
			internal object QEDDBDRXKYM()
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
			[Cpp2IlInjected.Address(RVA = "0x8DA9290", Offset = "0x8DA8090", VA = "0x188DA9290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8DA97E0", Offset = "0x8DA85E0", VA = "0x188DA97E0", Slot = "5")]
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
			public RTWKAVDCMOK.FallbackReason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private CDZETYBXCDA <localTaskState>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8DB6FE0", Offset = "0x8DB5DE0", VA = "0x188DB6FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x8DB7C50", Offset = "0x8DB6A50", VA = "0x188DB7C50", Slot = "5")]
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
			public RTWKAVDCMOK.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public RoomManagerFallbacks <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			private RVDZJLMSLEQ <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x8DB7CB0", Offset = "0x8DB6AB0", VA = "0x188DB7CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8DB8880", Offset = "0x8DB7680", VA = "0x188DB8880", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		internal static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		internal static readonly Log CSPSJVYUUNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private ZVTYJEOYACF SLBUPCNYZAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private OEJGLDFIKZO FFRQMGYVOAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private CDZETYBXCDA MDBJOFTMAOC;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private ZZSHRDKMGMU YWWFJNZECIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x8DA4330", Offset = "0x8DA3130", VA = "0x188DA4330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public bool ZHEEMJKKXTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x2315670", Offset = "0x2314470", VA = "0x182315670", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		private bool SOOJRBEOEHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x8DA4450", Offset = "0x8DA3250", VA = "0x188DA4450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3D10", Offset = "0x8DA2B10", VA = "0x188DA3D10", Slot = "6")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3C30", Offset = "0x8DA2A30", VA = "0x188DA3C30", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8DA37D0", Offset = "0x8DA25D0", VA = "0x188DA37D0", Slot = "9")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8DA35D0", Offset = "0x8DA23D0", VA = "0x188DA35D0")]
		private bool BFFNPRWBBTD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3C40", Offset = "0x8DA2A40", VA = "0x188DA3C40", Slot = "5")]
		private void EQXNYMFKGVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8DA36B0", Offset = "0x8DA24B0", VA = "0x188DA36B0", Slot = "8")]
		[AsyncStateMachine(typeof(<TriggerFallback>d__14))]
		public Task BKOZQTLYKGD(RTWKAVDCMOK.Reason a, [Optional] Exception b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3940", Offset = "0x8DA2740", VA = "0x188DA3940")]
		private bool DYYBXTZDQOP(RTWKAVDCMOK.FallbackReason a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3D90", Offset = "0x8DA2B90", VA = "0x188DA3D90")]
		private HKXMBRRJASZ[] LUURSDDEUPN(RoomInstance a, RoomDTO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4210", Offset = "0x8DA3010", VA = "0x188DA4210")]
		[AsyncStateMachine(typeof(<StartRunningFallbacks>d__19))]
		private Task StartRunningFallbacks(RTWKAVDCMOK.FallbackReason reason, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4380", Offset = "0x8DA3180", VA = "0x188DA4380")]
		[AsyncStateMachine(typeof(<BlockWhilePreviousFallbackSequenceIsPendingCancellation>d__20))]
		private Task VUMCJGGTKAZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomManagerFallbacks()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerInitialRoomLoad : FKHXPTFDNYD, ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class VBZDFZLFUJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public Matchmaking.GameJoinResult IZSRSIHKIMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public ErrorCode USUWOXRKMKS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public Exception DRNNHSFOJIW;

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public VBZDFZLFUJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8DBAF40", Offset = "0x8DB9D40", VA = "0x188DBAF40")]
			internal object GCGACGLTGMA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private sealed class LWJGTEGGOWS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public Task<RoomLoadRequestPayload> JXAJDBJCKSQ;

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public LWJGTEGGOWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			internal Task<RoomLoadRequestPayload> ZDVQFLCFDDL(StackTimer<string>.XDYOTKRANGY a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class ABSHQAFZKQB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public Task<RoomLoadRequestPayload> JXAJDBJCKSQ;

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ABSHQAFZKQB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			internal Task<RoomLoadRequestPayload> WGHNJUXRGTX(StackTimer<string>.XDYOTKRANGY a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class EWIXPHPBAJT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public Task OIEDVQGZWWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public RoomInstance ENDRWMJMDCV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public bool NHKRYBZSJNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public Task XFVHFSIQQUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public Task BPSOIZTQRFP;

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EWIXPHPBAJT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x8D9DE20", Offset = "0x8D9CC20", VA = "0x188D9DE20")]
			internal object TUJTXJYGGKZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x8D9DD30", Offset = "0x8D9CB30", VA = "0x188D9DD30")]
			internal string TUENADEIWZQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class KRNJHZUWJGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public RoomInstance ENDRWMJMDCV;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public KRNJHZUWJGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x8D9FBC0", Offset = "0x8D9E9C0", VA = "0x188D9FBC0")]
			internal object RVROOKSRYDX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class WPSRERSLAWL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public long ZVBTUBRVWZG;

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WPSRERSLAWL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x8DBB270", Offset = "0x8DBA070", VA = "0x188DBB270")]
			internal void UOBMVNGCIWE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class AMXXEEIJUBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public RoomInstance ENDRWMJMDCV;

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public AMXXEEIJUBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8D9BE00", Offset = "0x8D9AC00", VA = "0x188D9BE00")]
			internal object LTTNQYLJDDN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class EFQLNVJNXSM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public RoomInstance ENDRWMJMDCV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public Task BPSOIZTQRFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public Task OIEDVQGZWWN;

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EFQLNVJNXSM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x8D9DC40", Offset = "0x8D9CA40", VA = "0x188D9DC40")]
			internal string WQSHMPQWSIV()
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
			private TaskAwaiter<MMSSFGQGRLF> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x8DA9840", Offset = "0x8DA8640", VA = "0x188DA9840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x8DA9FB0", Offset = "0x8DA8DB0", VA = "0x188DA9FB0", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public Matchmaking.ServerConnectionInfoDTO serverConnectionInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public WAMQFEAEZXB joinRoomInstancePauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public CancellationToken roomCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			private StackTimer<string>.XDYOTKRANGY <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private TaskAwaiter<NNEOEFZPGZM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x8DAAA10", Offset = "0x8DA9810", VA = "0x188DAAA10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8DAB100", Offset = "0x8DA9F00", VA = "0x188DAB100", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public AJSGRYSVTDZ customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public WAMQFEAEZXB joinRoomInstancePauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			private LWJGTEGGOWS <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private HTPVVHWXJXT <multiProgressTracker>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			private IDisposable <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			private StackTimer<string>.XDYOTKRANGY <connectToRoomAndRunLoadLogicTimer>5__5;

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
			private LKWAXVIJRBY <preOperationProgressTracker>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private Task<Matchmaking.ServerConnectionInfoDTO> <serverConnectionInfoTask>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private PXFQYMDURAC <>7__wrap10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private CancellationTokenSource <cameraFadeCts>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			private StackTimer<string>.XDYOTKRANGY <>7__wrap12;

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
			[Cpp2IlInjected.Address(RVA = "0x8DAB160", Offset = "0x8DA9F60", VA = "0x188DAB160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x8DB0B80", Offset = "0x8DAF980", VA = "0x188DB0B80", Slot = "5")]
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
			private FDTRVDFSBYT <roomContainer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4480", Offset = "0x8DC3280", VA = "0x188DC4480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4910", Offset = "0x8DC3710", VA = "0x188DC4910", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public AJSGRYSVTDZ customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public WAMQFEAEZXB joinRoomInstancePauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			private HTPVVHWXJXT <multiProgressTracker>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private IDisposable <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			private StackTimer<string>.XDYOTKRANGY <connectToRoomAndRunLoadLogicTimer>5__5;

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
			private LKWAXVIJRBY <preOperationProgressTracker>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			private Task<Matchmaking.ServerConnectionInfoDTO> <serverConnectionInfoTask>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			private RoomLoadRequestPayload <initialRoomLoadPayload>5__11;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			private EWFSFOBQSTJ <preloadContext>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			private TaskAwaiter<RoomLoadRequestPayload> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			private PXFQYMDURAC <>7__wrap12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			private Task <loadEmptySceneTask>5__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			private XYPRXHAPUXS <sceneManagementService>5__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private TZSZRJATIYU <scenePreloadRequest>5__16;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			private CancellationTokenSource <cameraFadeCts>5__17;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			private StackTimer<string>.XDYOTKRANGY <>7__wrap17;

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
			[Cpp2IlInjected.Address(RVA = "0x8DC4970", Offset = "0x8DC3770", VA = "0x188DC4970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9EC0", Offset = "0x8DC8CC0", VA = "0x188DC9EC0", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			private StackTimer<string>.XDYOTKRANGY <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			private TaskAwaiter<Matchmaking.ServerConnectionInfoDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x8DCC870", Offset = "0x8DCB670", VA = "0x188DCC870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8DCCD50", Offset = "0x8DCBB50", VA = "0x188DCCD50", Slot = "5")]
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
			public AJSGRYSVTDZ customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x8DCCDC0", Offset = "0x8DCBBC0", VA = "0x188DCCDC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x8DCD370", Offset = "0x8DCC170", VA = "0x188DCD370", Slot = "5")]
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
			private EWIXPHPBAJT <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x8DCD3D0", Offset = "0x8DCC1D0", VA = "0x188DCD3D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8DCDF40", Offset = "0x8DCCD40", VA = "0x188DCDF40", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public WAMQFEAEZXB joinRoomInstanceToken;

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
			public EWFSFOBQSTJ preloadContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public HTPVVHWXJXT progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			private StackTimer<string>.XDYOTKRANGY <roomLoadLogicTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8DD4600", Offset = "0x8DD3400", VA = "0x188DD4600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8DD4DF0", Offset = "0x8DD3BF0", VA = "0x188DD4DF0", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private StackTimer<string>.XDYOTKRANGY <spawnLocalPlayerTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			private LogRangeScope <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			private StackTimer<string>.XDYOTKRANGY <>7__wrap3;

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
			[Cpp2IlInjected.Address(RVA = "0x8DD4E50", Offset = "0x8DD3C50", VA = "0x188DD4E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8DD6630", Offset = "0x8DD5430", VA = "0x188DD6630", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private StackTimer<string>.XDYOTKRANGY <disconnectTimerScope>5__3;

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
			private StackTimer<string>.XDYOTKRANGY <>7__wrap5;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x8DD6F20", Offset = "0x8DD5D20", VA = "0x188DD6F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x8DD7980", Offset = "0x8DD6780", VA = "0x188DD7980", Slot = "5")]
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
			public AJSGRYSVTDZ customRoomLoadPayload;

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
			private WAMQFEAEZXB <joinRoomInstancePauseToken>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			private IVKLSEJTYXV <analyticsData>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x8DD89A0", Offset = "0x8DD77A0", VA = "0x188DD89A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x8DD9800", Offset = "0x8DD8600", VA = "0x188DD9800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly Log YXPVWSZIDTY;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly Log FTJOEUIWRRA;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly Log GBDHFPWEDVI;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly string WYBSZCJOSST;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly string OCJMBWNBXOP;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly string DADWKGYCSUI;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly Guid PRGWYWZXBGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private XUVXRPWZBOR NOYYMXUYDBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private GHGHJRBBUAM LGWILCZUAFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private VJRNQPLOUBG FBPQEEAUUKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private ZVTYJEOYACF SLBUPCNYZAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private OEJGLDFIKZO FFRQMGYVOAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private XXZLGPMZMGT PUEAUCYUUNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private TUQBTWGFKKL EKIBAXZITGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TFYHQZUXCEB BVYAGWWSHNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private LZGITPOTRPS DHCDWYZPKYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private SODNCFKUHBZ ZSBILZDTXQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private IDisposable LHEBHBRZMRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private LONPPRYZMAK ZZOIYCYZPTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private readonly Token TCMNJYSEUDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private PXFQYMDURAC PABCGMQWJVP;

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public TaskStatus HEERWSKRDRT
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x128BCF0", Offset = "0x128AAF0", VA = "0x18128BCF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TaskStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x1817B80", Offset = "0x1816980", VA = "0x181817B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private ZZSHRDKMGMU YWWFJNZECIV
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x8DA7460", Offset = "0x8DA6260", VA = "0x188DA7460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8DA5DD0", Offset = "0x8DA4BD0", VA = "0x188DA5DD0", Slot = "6")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8DA52B0", Offset = "0x8DA40B0", VA = "0x188DA52B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x8DA68E0", Offset = "0x8DA56E0", VA = "0x188DA68E0", Slot = "5")]
		[AsyncStateMachine(typeof(<JoinRoomInstance>d__30))]
		public Task JoinRoomInstance(RoomInstance targetInstance, AJSGRYSVTDZ customRoomLoadPayload, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7BC0", Offset = "0x8DA69C0", VA = "0x188DA7BC0")]
		[AsyncStateMachine(typeof(<TryJoinRoomInstance>d__31))]
		private Task ZJQUOXQMACU(RoomInstance a, AJSGRYSVTDZ b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8DA6150", Offset = "0x8DA4F50", VA = "0x188DA6150")]
		private void JFHGBOYJQXW(LZGITPOTRPS a, RoomInstance b, Exception c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4580", Offset = "0x8DA3380", VA = "0x188DA4580")]
		private static void ASZWDXXRTVQ(IVKLSEJTYXV a, Exception b, [Optional] List<int> c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4E20", Offset = "0x8DA3C20", VA = "0x188DA4E20")]
		[AsyncStateMachine(typeof(<ConnectToRoomAndRunLoadLogic>d__34))]
		private Task ConnectToRoomAndRunLoadLogic(StackTimer<string>.XDYOTKRANGY timer, RoomInstance targetInstance, AJSGRYSVTDZ customRoomLoadPayload, WAMQFEAEZXB joinRoomInstancePauseToken, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8DA5640", Offset = "0x8DA4440", VA = "0x188DA5640")]
		[AsyncStateMachine(typeof(<FastPath_ConnectToRoomAndRunLoadLogic>d__35))]
		private Task FastPath_ConnectToRoomAndRunLoadLogic(StackTimer<string>.XDYOTKRANGY timer, RoomInstance targetInstance, AJSGRYSVTDZ customRoomLoadPayload, WAMQFEAEZXB joinRoomInstancePauseToken, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8DA6E10", Offset = "0x8DA5C10", VA = "0x188DA6E10")]
		private void OHILHAVJPLM([CallerMemberName] string caller = "<unknown>")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8DA6CE0", Offset = "0x8DA5AE0", VA = "0x188DA6CE0")]
		[AsyncStateMachine(typeof(<TryDisconnectFromCurrentRoomInstance>d__37))]
		private Task OGBMROCWWJB(StackTimer<string>.XDYOTKRANGY a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4F80", Offset = "0x8DA3D80", VA = "0x188DA4F80")]
		private void DRWRUEMLNHF(RoomInstance a, CancellationToken b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8DA6A20", Offset = "0x8DA5820", VA = "0x188DA6A20")]
		private void KKTDQGDRWOT(RoomInstance a, TaskStatus b, string c, WAMQFEAEZXB d, Exception e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7120", Offset = "0x8DA5F20", VA = "0x188DA7120")]
		private void RBQHSHWEQSA(RoomInstance a, WAMQFEAEZXB b, OperationCanceledException c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7930", Offset = "0x8DA6730", VA = "0x188DA7930")]
		private void YVWQXCPMSFS(RoomInstance a, WAMQFEAEZXB b, Exception c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8DA79B0", Offset = "0x8DA67B0", VA = "0x188DA79B0")]
		private void ZDSELIFWQFW(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8DA5D70", Offset = "0x8DA4B70", VA = "0x188DA5D70")]
		private static RoomEvent IKFJEUYFPTO(RoomInstance a)
		{
			return default(RoomEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7780", Offset = "0x8DA6580", VA = "0x188DA7780")]
		[AsyncStateMachine(typeof(<CreateRoomDiContainer>d__44))]
		private Task XTHZLQXELZM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8DA58E0", Offset = "0x8DA46E0", VA = "0x188DA58E0")]
		[AsyncStateMachine(typeof(<GetServerConnectionInfo>d__45))]
		private Task<Matchmaking.ServerConnectionInfoDTO> GetServerConnectionInfo(RoomInstance targetInstance, StackTimer<string>.XDYOTKRANGY timer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8DA67D0", Offset = "0x8DA55D0", VA = "0x188DA67D0")]
		private static NNEOEFZPGZM JXZQOUSVBFK(Matchmaking.ServerConnectionInfoDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8DA54F0", Offset = "0x8DA42F0", VA = "0x188DA54F0")]
		[AsyncStateMachine(typeof(<ConnectToPhoton>d__47))]
		private Task FDRQXQLKKNW(Matchmaking.ServerConnectionInfoDTO a, WAMQFEAEZXB b, StackTimer<string>.XDYOTKRANGY c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8DA57A0", Offset = "0x8DA45A0", VA = "0x188DA57A0")]
		[AsyncStateMachine(typeof(<JoinRoomLoadWithPhoton>d__48))]
		private Task GGTTUZFQWCW(RoomInstance a, CancellationTokenSource b, Task c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x8DA71A0", Offset = "0x8DA5FA0", VA = "0x188DA71A0")]
		[AsyncStateMachine(typeof(<RunRoomLoadLogic>d__49))]
		private Task RunRoomLoadLogic(RoomLoadRequestPayload initialRoomLoadPayload, HTPVVHWXJXT progressTracker, RoomInstance targetRoomInstance, WAMQFEAEZXB joinRoomInstanceToken, StackTimer<string>.XDYOTKRANGY timer, CancellationToken roomJoinCancellationToken, [Optional] EWFSFOBQSTJ preloadContext)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8DA5A40", Offset = "0x8DA4840", VA = "0x188DA5A40")]
		private WAMQFEAEZXB HHBASXJYOUV(WAMQFEAEZXB a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7320", Offset = "0x8DA6120", VA = "0x188DA7320")]
		[AsyncStateMachine(typeof(<SpawnLocalPlayer>d__51))]
		private Task SpawnLocalPlayer(StackTimer<string>.XDYOTKRANGY timer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8DA74B0", Offset = "0x8DA62B0", VA = "0x188DA74B0")]
		[AsyncStateMachine(typeof(<CheckForRoomDataOutOfDate>d__52))]
		private Task WAJMGFWUYSM(CancellationToken a, int b, AccountRoleType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8DA5300", Offset = "0x8DA4100", VA = "0x188DA5300")]
		private static void ERRAMURBTNP(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8DA65A0", Offset = "0x8DA53A0", VA = "0x188DA65A0")]
		private void JKYEUZUEDGU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4D90", Offset = "0x8DA3B90", VA = "0x188DA4D90")]
		private void BPQNAXMWOSL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8DA5460", Offset = "0x8DA4260", VA = "0x188DA5460")]
		private void EULDJZIPDRC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8DA6F90", Offset = "0x8DA5D90", VA = "0x188DA6F90")]
		private void OWEHWATBTQC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7850", Offset = "0x8DA6650", VA = "0x188DA7850")]
		private static void YDOURWPYVPR(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7020", Offset = "0x8DA5E20", VA = "0x188DA7020")]
		private static CancellationTokenRegistration PFTAIVMHHRC(RoomInstance a, CancellationToken b)
		{
			return default(CancellationTokenRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8DA5C80", Offset = "0x8DA4A80", VA = "0x188DA5C80")]
		private static void HYZVWISDBAV(RoomInstance a, Exception b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8DA75E0", Offset = "0x8DA63E0", VA = "0x188DA75E0")]
		private void XRWLIPGVWPR(RoomInstance a, Task b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8DA6C80", Offset = "0x8DA5A80", VA = "0x188DA6C80")]
		private static void Log(Func<string> msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7F10", Offset = "0x8DA6D10", VA = "0x188DA7F10")]
		public RoomManagerInitialRoomLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8DA5C20", Offset = "0x8DA4A20", VA = "0x188DA5C20")]
		[CompilerGenerated]
		internal static (int, int?) HMGUHIYOCQI(ErrorCode a)
		{
			return default((int, int?));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerInRoomTasks : PUSBFHUAPQW, ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class IJGUSUENVJY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public RoomManagerInRoomTasks WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			public int YZDKALSSYJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000238")]
			public AccountRoleType CNCQRWWFDTI;

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public IJGUSUENVJY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x8DBC490", Offset = "0x8DBB290", VA = "0x188DBC490")]
			internal List<Task> YGBNIGCKCCJ(CancellationToken a)
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
			[Cpp2IlInjected.Address(RVA = "0x8DD2570", Offset = "0x8DD1370", VA = "0x188DD2570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x8DD2A40", Offset = "0x8DD1840", VA = "0x188DD2A40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DD9CA0", Offset = "0x8DD8AA0", VA = "0x188DD9CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA040", Offset = "0x8DD8E40", VA = "0x188DDA040", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DDA0A0", Offset = "0x8DD8EA0", VA = "0x188DDA0A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA380", Offset = "0x8DD9180", VA = "0x188DDA380", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private readonly HashSet<InLoadedRoomTaskBuilder> KFKOGOAWBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private GHGHJRBBUAM LGWILCZUAFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private ZVTYJEOYACF SLBUPCNYZAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private LZHTVDPEIKI AKLQUJHRKUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskRunner ZKBIEDPLROA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private IDisposable LHEBHBRZMRE;

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8DBCD40", Offset = "0x8DBBB40", VA = "0x188DBCD40", Slot = "5")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC7D0", Offset = "0x8DBB5D0", VA = "0x188DBC7D0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD010", Offset = "0x8DBBE10", VA = "0x188DBD010", Slot = "4")]
		public bool KUZDJYPTOVM(InLoadedRoomTaskBuilder a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD210", Offset = "0x8DBC010", VA = "0x188DBD210")]
		private void NVGRUBAFXCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD2E0", Offset = "0x8DBC0E0", VA = "0x188DBD2E0")]
		private void PKRKSPBJQEB(UREAGQBAIUQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD500", Offset = "0x8DBC300", VA = "0x188DBD500")]
		[AsyncStateMachine(typeof(<RunInRoomTaskAsync>d__15))]
		private Task VDJAELHIZQT(int a, AccountRoleType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD070", Offset = "0x8DBBE70", VA = "0x188DBD070")]
		private Func<CancellationToken, List<Task>> MBOTETOVOPJ(int a, AccountRoleType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC830", Offset = "0x8DBB630", VA = "0x188DBC830")]
		private List<Task> GQVDIBEJNXV(int a, AccountRoleType b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD5F0", Offset = "0x8DBC3F0", VA = "0x188DBD5F0")]
		[AsyncStateMachine(typeof(<WaitAndLog>d__18))]
		private Task WJHBAGUCLBB(InLoadedRoomTaskBuilder a, CancellationToken b, int c, AccountRoleType d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD140", Offset = "0x8DBBF40", VA = "0x188DBD140")]
		[AsyncStateMachine(typeof(<WaitForPhotonAndCancel>d__19))]
		private Task NHKIAMGASUK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC750", Offset = "0x8DBB550", VA = "0x188DBC750")]
		private void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD710", Offset = "0x8DBC510", VA = "0x188DBD710")]
		public RoomManagerInRoomTasks()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerPendingRequests : ZGFDMZFGNNX, ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class EERSQRFLGMR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			public Guid ETHLIPBIQVX;

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EERSQRFLGMR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8DBC300", Offset = "0x8DBB100", VA = "0x188DBC300")]
			internal object DDXDJIYQSBQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[CompilerGenerated]
		private sealed class QFVEKDSMASK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400024E")]
			public Guid ETHLIPBIQVX;

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QFVEKDSMASK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8DBC530", Offset = "0x8DBB330", VA = "0x188DBC530")]
			internal object RYMETQWOGGN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class EIGBKFCSTWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EIGBKFCSTWH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class ZRSJAVAQQNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			public Guid ETHLIPBIQVX;

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZRSJAVAQQNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA980", Offset = "0x8DD9780", VA = "0x188DDA980")]
			internal object PBDZZADLTTX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class WCODKRWUAFT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			public Guid ETHLIPBIQVX;

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WCODKRWUAFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA7A0", Offset = "0x8DD95A0", VA = "0x188DDA7A0")]
			internal object XEADBCEDWNH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private readonly Dictionary<Guid, PendingRequestData> FXMWAYIKOPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private readonly TimeSpan RFBYSGJUZKD;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "9")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD9A0", Offset = "0x8DBC7A0", VA = "0x188DBD9A0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD790", Offset = "0x8DBC590", VA = "0x188DBD790", Slot = "4")]
		public PendingRequest Add(Guid operationId)
		{
			return default(PendingRequest);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8DBDF10", Offset = "0x8DBCD10", VA = "0x188DBDF10", Slot = "5")]
		public bool Remove(Guid operationId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8DBDBE0", Offset = "0x8DBC9E0", VA = "0x188DBDBE0", Slot = "6")]
		public bool RWBVUWEUIWP(Guid a, Task b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE180", Offset = "0x8DBCF80", VA = "0x188DBE180", Slot = "7")]
		public bool XUTZXUIDFRN(Guid a, MMSSFGQGRLF b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE110", Offset = "0x8DBCF10", VA = "0x188DBE110", Slot = "8")]
		public Task<(MMSSFGQGRLF, Task)> TWPVSZHJFZG(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD9B0", Offset = "0x8DBC7B0", VA = "0x188DBD9B0")]
		private void KGHPZGRPUOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE350", Offset = "0x8DBD150", VA = "0x188DBE350")]
		public RoomManagerPendingRequests()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerPresenceUpdates : SJTVCEZJQNL, ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		private class SJKKAHAPGZX : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			private readonly RoomInstance TDYIKOCSLMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			private readonly CancellationTokenSource RALLNVAJZKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			public readonly CancellationToken SLWSKAZDOHW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			private bool TMKUJMYVPNQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			private bool UYCAAIVFHWU;

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8DC43E0", Offset = "0x8DC31E0", VA = "0x188DC43E0")]
			public SJKKAHAPGZX(RoomInstance a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x8DC4270", Offset = "0x8DC3070", VA = "0x188DC4270")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x8DC43B0", Offset = "0x8DC31B0", VA = "0x188DC43B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class VCNKWXLRMEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public DisconnectCause PASQOCHXLKQ;

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public VCNKWXLRMEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA580", Offset = "0x8DD9380", VA = "0x188DDA580")]
			internal object LWMYMZWTZKZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class VGBTQLIYZOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			public int GLBIYYPSKDV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			public RoomManagerPresenceUpdates WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public VGBTQLIYZOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA6D0", Offset = "0x8DD94D0", VA = "0x188DDA6D0")]
			internal object JOHBIMEDHEH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class VFWMTEPBQCS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026A")]
			public RoomInstance TDYIKOCSLMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400026B")]
			public VGBTQLIYZOB YLNIYCOGBOE;

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public VFWMTEPBQCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA610", Offset = "0x8DD9410", VA = "0x188DDA610")]
			internal object JOMIFSYAQPQ((RoomInstance lastLocalPlayerRoomInstance, RoomInstance newRoomInstance, XXZLGPMZMGT fallbacks) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class UEZIPMBRLCS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026C")]
			public RoomInstance TDYIKOCSLMH;

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public UEZIPMBRLCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA3E0", Offset = "0x8DD91E0", VA = "0x188DDA3E0")]
			internal object AAMGRYXYYZG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA480", Offset = "0x8DD9280", VA = "0x188DDA480")]
			internal void AARNPFRWIKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA500", Offset = "0x8DD9300", VA = "0x188DDA500")]
			internal object AAWUMMLTRVY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA540", Offset = "0x8DD9340", VA = "0x188DDA540")]
			internal object ABCBJTFRBHH()
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
			[Cpp2IlInjected.Address(RVA = "0x8DCF220", Offset = "0x8DCE020", VA = "0x188DCF220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x8DCF660", Offset = "0x8DCE460", VA = "0x188DCF660", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DCF6C0", Offset = "0x8DCE4C0", VA = "0x188DCF6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
			public AJSGRYSVTDZ customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000281")]
			private UEZIPMBRLCS <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x8DD79E0", Offset = "0x8DD67E0", VA = "0x188DD79E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x8DD8940", Offset = "0x8DD7740", VA = "0x188DD8940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private static readonly NPKZRMFZZKV.UYLANEJGGPN OOIHCTQBUYU;

		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private static readonly LogFlags UBXBLKSKJIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private GHGHJRBBUAM LGWILCZUAFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private ZVTYJEOYACF SLBUPCNYZAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private XXZLGPMZMGT PUEAUCYUUNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private OEJGLDFIKZO FFRQMGYVOAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private CUJVBYRHGHA SARRDALHDLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private FKHXPTFDNYD PWUEBWQCFZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private RoomInstance NPTDWUIELFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private SJKKAHAPGZX OKPSZZAAOYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private bool KHJXXOLKFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private Task FXSVAOGDAXQ;

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private ZZSHRDKMGMU YWWFJNZECIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x8DBEDF0", Offset = "0x8DBDBF0", VA = "0x188DBEDF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public bool NGUXHBPWSUA
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xB45FE0", Offset = "0xB44DE0", VA = "0x180B45FE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x8DBE860", Offset = "0x8DBD660", VA = "0x188DBE860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE870", Offset = "0x8DBD670", VA = "0x188DBE870", Slot = "4")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE500", Offset = "0x8DBD300", VA = "0x188DBE500", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEB20", Offset = "0x8DBD920", VA = "0x188DBEB20")]
		[AsyncStateMachine(typeof(<OnDisconnectedFromPhotonWhileConnected>d__20))]
		private Task JCKLRNIZVQT(DisconnectCause a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEE40", Offset = "0x8DBDC40", VA = "0x188DBEE40")]
		private void YBPDMKKESNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE6E0", Offset = "0x8DBD4E0", VA = "0x188DBE6E0")]
		private void FQIOFHKNAXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEC80", Offset = "0x8DBDA80", VA = "0x188DBEC80")]
		private void MMGJYDPBFUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEC10", Offset = "0x8DBDA10", VA = "0x188DBEC10")]
		private bool LTIXLSLNXIC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF390", Offset = "0x8DBE190", VA = "0x188DBF390")]
		[AsyncStateMachine(typeof(<OnPlayerPresenceUpdated>d__26))]
		private void ZZBHFJUUYDH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF100", Offset = "0x8DBDF00", VA = "0x188DBF100")]
		private void ZLRQLGYKRZS([Out] IDisposable a, [Out] IDisposable b, [Out] IDisposable c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE400", Offset = "0x8DBD200", VA = "0x188DBE400")]
		private bool DTPWEOLJZBG(RoomInstance a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE690", Offset = "0x8DBD490", VA = "0x188DBE690")]
		private void EXXBRRTKZFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEFD0", Offset = "0x8DBDDD0", VA = "0x188DBEFD0")]
		[AsyncStateMachine(typeof(<TryJoinRoomInstance>d__30))]
		private Task ZJQUOXQMACU(RoomInstance a, AJSGRYSVTDZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF7F0", Offset = "0x8DBE5F0", VA = "0x188DBF7F0")]
		public RoomManagerPresenceUpdates()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerReceiveOperation : RCRKBERRYIO, ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class ROWRFPJNAWU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400028D")]
			public FJZTCZTAMBW YMTARSOVBMM;

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ROWRFPJNAWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x8DBC5F0", Offset = "0x8DBB3F0", VA = "0x188DBC5F0")]
			internal object ELFZXECMKXL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		[CompilerGenerated]
		private sealed class MVKUZKRYUYD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400028E")]
			public FJZTCZTAMBW LTDBLSPDUBW;

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public MVKUZKRYUYD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x8DBC4D0", Offset = "0x8DBB2D0", VA = "0x188DBC4D0")]
			internal object OKBFUKIUWIS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class RLIIMBMFNNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400028F")]
			public FJZTCZTAMBW OGTQZMBXOGD;

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public RLIIMBMFNNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x8DBC590", Offset = "0x8DBB390", VA = "0x188DBC590")]
			internal object OOGTIYUEHKV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		[CompilerGenerated]
		private sealed class WLRRSVOUONV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000290")]
			public EKKWWDICQVS NBRMSLKLXPK;

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WLRRSVOUONV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA860", Offset = "0x8DD9660", VA = "0x188DDA860")]
			internal object LYVVARBBMOD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		[CompilerGenerated]
		private sealed class IJGUSUENVJY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000291")]
			public FJZTCZTAMBW LTDBLSPDUBW;

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public IJGUSUENVJY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x8DBC430", Offset = "0x8DBB230", VA = "0x188DBC430")]
			internal object HXJPBZJJBIL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		[CompilerGenerated]
		private sealed class BEYJMNWUOVG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000292")]
			public FJZTCZTAMBW LTDBLSPDUBW;

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public BEYJMNWUOVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x8DBC110", Offset = "0x8DBAF10", VA = "0x188DBC110")]
			internal object VQHNIVTMCDC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class ZVGRUIXYDWS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			public FJZTCZTAMBW LVFNANVSRTE;

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZVGRUIXYDWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x8DDAD10", Offset = "0x8DD9B10", VA = "0x188DDAD10")]
			internal object JZKOYJKECCU()
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
			public EKKWWDICQVS operation;

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
			[Cpp2IlInjected.Address(RVA = "0x8DD3F80", Offset = "0x8DD2D80", VA = "0x188DD3F80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x8DD45A0", Offset = "0x8DD33A0", VA = "0x188DD45A0", Slot = "5")]
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
			public FJZTCZTAMBW operationStartMessage;

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
			private WAMQFEAEZXB <pauseToken>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			private TaskAwaiter<FJZTCZTAMBW> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002A4")]
			private IDisposable <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002A5")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x8DD2AA0", Offset = "0x8DD18A0", VA = "0x188DD2AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x8DD3600", Offset = "0x8DD2400", VA = "0x188DD3600", Slot = "5")]
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
			public FJZTCZTAMBW request;

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
			private TaskAwaiter<EKKWWDICQVS> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x8DD3660", Offset = "0x8DD2460", VA = "0x188DD3660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x8DD3F20", Offset = "0x8DD2D20", VA = "0x188DD3F20", Slot = "5")]
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
			public AsyncTaskMethodBuilder<EKKWWDICQVS> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public RoomManagerReceiveOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			public FJZTCZTAMBW request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			private OAPJTQRHGVQ.LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			private WAMQFEAEZXB <pauseToken>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			private TaskAwaiter<FJZTCZTAMBW> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x8DD6690", Offset = "0x8DD5490", VA = "0x188DD6690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x8DD6BC0", Offset = "0x8DD59C0", VA = "0x188DD6BC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DD6C30", Offset = "0x8DD5A30", VA = "0x188DD6C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x8DD6EB0", Offset = "0x8DD5CB0", VA = "0x188DD6EB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private ZVTYJEOYACF SLBUPCNYZAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TUQBTWGFKKL EKIBAXZITGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private WYSKBHTHKRF XEETWVXPWIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private AYYYDIPYFGM WJLLMHCZGWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private VJRNQPLOUBG FBPQEEAUUKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskCompletionSource<RoomOperationType> QHURIBBYFZT;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0020", Offset = "0x8DBEE20", VA = "0x188DC0020", Slot = "7")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0920", Offset = "0x8DBF720", VA = "0x188DC0920", Slot = "6")]
		[AsyncStateMachine(typeof(<ThrowOnRequestTask>d__8))]
		public Task<RoomOperationType> ZIHZTCYSQLW(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF860", Offset = "0x8DBE660", VA = "0x188DBF860", Slot = "4")]
		public void BHARPSCGTAM(FJZTCZTAMBW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0460", Offset = "0x8DBF260", VA = "0x188DC0460", Slot = "5")]
		public void PXMHXMZFXSD(FJZTCZTAMBW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0790", Offset = "0x8DBF590", VA = "0x188DC0790")]
		[AsyncStateMachine(typeof(<RunOperationFromRequest>d__11))]
		private Task TYTBHETAMDI(FJZTCZTAMBW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFF10", Offset = "0x8DBED10", VA = "0x188DBFF10")]
		[AsyncStateMachine(typeof(<RunOperationFromMaster>d__12))]
		private Task CIWSGZGLEWD(FJZTCZTAMBW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0110", Offset = "0x8DBEF10", VA = "0x188DC0110")]
		[AsyncStateMachine(typeof(<SyncAndCreateOperation>d__13))]
		private Task<EKKWWDICQVS> MBSDKFQVVUG(FJZTCZTAMBW a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x8DC08A0", Offset = "0x8DBF6A0", VA = "0x188DC08A0")]
		private WAMQFEAEZXB WBTQKWZXGWH(FJZTCZTAMBW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0A30", Offset = "0x8DBF830", VA = "0x188DC0A30")]
		[AsyncStateMachine(typeof(<RunOperation>d__15))]
		private Task ZOCPKZUZNQN(EKKWWDICQVS a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0260", Offset = "0x8DBF060", VA = "0x188DC0260")]
		private EKKWWDICQVS PLJYOALONKN(FJZTCZTAMBW a, WAMQFEAEZXB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x3CE0FB0", Offset = "0x3CDFDB0", VA = "0x183CE0FB0")]
		private a YQHETIODYRN<a>(a a) where a : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFBC0", Offset = "0x8DBE9C0", VA = "0x188DBFBC0")]
		private EKKWWDICQVS BMTUYRUYORK(FJZTCZTAMBW a, WAMQFEAEZXB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomManagerReceiveOperation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerRequestHandler : WYSKBHTHKRF, ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		[CompilerGenerated]
		private sealed class WIDIZHRNBEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			public byte DMUUYJHYYJK;

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WIDIZHRNBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA800", Offset = "0x8DD9600", VA = "0x188DDA800")]
			internal object GIQSUWXFJZJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		[CompilerGenerated]
		private sealed class WCODKRWUAFT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			public Guid ETHLIPBIQVX;

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WCODKRWUAFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA730", Offset = "0x8DD9530", VA = "0x188DDA730")]
			internal object IGOYWUKJMCI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private VJRNQPLOUBG FBPQEEAUUKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private ZEAPVLGZEGH GZGHQOABEBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private RCRKBERRYIO OFMDZADAOZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private ZGFDMZFGNNX FXMWAYIKOPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private FKMBOALBBQX BSSMGJMGJQO;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1600", Offset = "0x8DC0400", VA = "0x188DC1600", Slot = "6")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0B50", Offset = "0x8DBF950", VA = "0x188DC0B50", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2490", Offset = "0x8DC1290", VA = "0x188DC2490", Slot = "4")]
		public PendingRequest WHOOQUGHXHF(FJZTCZTAMBW a)
		{
			return default(PendingRequest);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2290", Offset = "0x8DC1090", VA = "0x188DC2290", Slot = "5")]
		public void TIPJORNDJKU(Guid a, Task b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0E50", Offset = "0x8DBFC50", VA = "0x188DC0E50")]
		private void GBPPPFGNNUY(EREVFMKOODS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1770", Offset = "0x8DC0570", VA = "0x188DC1770")]
		private void JHMZTWHMFNH(OperationEventData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0BF0", Offset = "0x8DBF9F0", VA = "0x188DC0BF0")]
		private void EUMRHFWHBQF(OperationEventData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0F60", Offset = "0x8DBFD60", VA = "0x188DC0F60")]
		private void IEHRHLZDPCI(OperationEventData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x8DC13D0", Offset = "0x8DC01D0", VA = "0x188DC13D0")]
		private MMSSFGQGRLF IXQNVRKMVRD(FJZTCZTAMBW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1CD0", Offset = "0x8DC0AD0", VA = "0x188DC1CD0")]
		private void JKATTPHTSLD(FJZTCZTAMBW a, MMSSFGQGRLF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1EC0", Offset = "0x8DC0CC0", VA = "0x188DC1EC0")]
		private bool LMNLHYYBZIQ(FJZTCZTAMBW a, MMSSFGQGRLF b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2090", Offset = "0x8DC0E90", VA = "0x188DC2090")]
		private bool RIMGRZFDTDE(FJZTCZTAMBW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1190", Offset = "0x8DBFF90", VA = "0x188DC1190")]
		private bool IGNBINFRFYF(byte a, ExitGames.Client.Photon.Hashtable b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomManagerRequestHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerRequestOperation : WELOPOYTVLQ, ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		[CompilerGenerated]
		private sealed class EERSQRFLGMR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D0")]
			public RoomOperationType VEXVJLITQNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002D1")]
			public RoomManagerRequestOperation WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			public FJZTCZTAMBW FRKMKTHXEDK;

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EERSQRFLGMR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x8DBC170", Offset = "0x8DBAF70", VA = "0x188DBC170")]
			internal object CUUAYJFBRYK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x8DBC1E0", Offset = "0x8DBAFE0", VA = "0x188DBC1E0")]
			internal object CUZHVPYZBJT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		[CompilerGenerated]
		private sealed class EIGBKFCSTWH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			public RoomOperationType VEXVJLITQNC;

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EIGBKFCSTWH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x8DBC360", Offset = "0x8DBB160", VA = "0x188DBC360")]
			internal object DBGRBHOWDJB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private sealed class ZRSJAVAQQNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public FJZTCZTAMBW LTDBLSPDUBW;

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZRSJAVAQQNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA9E0", Offset = "0x8DD97E0", VA = "0x188DDA9E0")]
			internal object RNIFHJMHGEI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x8DDAA50", Offset = "0x8DD9850", VA = "0x188DDAA50")]
			internal object RNNMEQGEPPR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x8DDAAC0", Offset = "0x8DD98C0", VA = "0x188DDAAC0")]
			internal object RNSTBXABZBA()
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
			public AsyncTaskMethodBuilder<MMSSFGQGRLF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			public RoomManagerRequestOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			public FJZTCZTAMBW roomOperationMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			private TaskAwaiter<MMSSFGQGRLF> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x8DD1440", Offset = "0x8DD0240", VA = "0x188DD1440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x8DD1AC0", Offset = "0x8DD08C0", VA = "0x188DD1AC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<MMSSFGQGRLF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public FJZTCZTAMBW request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			public RoomManagerRequestOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			private ZRSJAVAQQNC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private PendingRequest <pendingRequest>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			private MMSSFGQGRLF <result>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			private TaskAwaiter<(MMSSFGQGRLF validationResult, Task operation)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x8DD1B30", Offset = "0x8DD0930", VA = "0x188DD1B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x8DD2500", Offset = "0x8DD1300", VA = "0x188DD2500", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private VJRNQPLOUBG FBPQEEAUUKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private ZEAPVLGZEGH GZGHQOABEBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private WYSKBHTHKRF XEETWVXPWIU;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2A70", Offset = "0x8DC1870", VA = "0x188DC2A70", Slot = "5")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2C60", Offset = "0x8DC1A60", VA = "0x188DC2C60", Slot = "4")]
		[AsyncStateMachine(typeof(<RecRoom-RoomLoading-IRoomManagerRequestOperation-RequestOperation>d__4))]
		private Task<MMSSFGQGRLF> QKVERCTCZES(FJZTCZTAMBW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2890", Offset = "0x8DC1690", VA = "0x188DC2890")]
		private bool HNCRBPUBCRL(RoomOperationType a, [Out] MMSSFGQGRLF b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2B20", Offset = "0x8DC1920", VA = "0x188DC2B20")]
		[AsyncStateMachine(typeof(<RequestOperationInternal>d__7))]
		private Task<MMSSFGQGRLF> MHRJJGYMOEU(FJZTCZTAMBW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomManagerRequestOperation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal sealed class RoomManagerRoomLoadRequest : DRIWUQXUIFC, ETETUEKLXQT, IDisposable
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
		private sealed class ROWRFPJNAWU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public Stopwatch NZORWSHKHWJ;

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ROWRFPJNAWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x8DBC6B0", Offset = "0x8DBB4B0", VA = "0x188DBC6B0")]
			internal object YLTYHRKERJY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		[CompilerGenerated]
		private sealed class ZRSJAVAQQNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public Stopwatch NZORWSHKHWJ;

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZRSJAVAQQNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x8DDA8E0", Offset = "0x8DD96E0", VA = "0x188DDA8E0")]
			internal object GMZZOWBJIDC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C4")]
		[CompilerGenerated]
		private sealed class ZVGRUIXYDWS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public long KURFEDKQXZL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			public RoomDetailsDTO CUPCETJVPLZ;

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZVGRUIXYDWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x133C330", Offset = "0x133B130", VA = "0x18133C330")]
			internal bool FYDIVHAGWDT(SubRoomDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x8DDAC50", Offset = "0x8DD9A50", VA = "0x188DDAC50")]
			internal object FYYKKIBWHXD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x8DDABC0", Offset = "0x8DD99C0", VA = "0x188DDABC0")]
			internal object FXYBYAGJMSK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x8DDAB30", Offset = "0x8DD9930", VA = "0x188DDAB30")]
			internal object FXSVATMMDHB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		[CompilerGenerated]
		private sealed class ZVLYRPRVNIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			public bool NQJMCBHENWW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			public ZVGRUIXYDWS YLNIYCOGBOE;

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZVLYRPRVNIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x8DDAD70", Offset = "0x8DD9B70", VA = "0x188DDAD70")]
			internal object FXNODMSOTVS()
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
			public StackTimer<string>.XDYOTKRANGY stackTimer;

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
			private ROWRFPJNAWU <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			private StackTimer<string>.XDYOTKRANGY <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			private TaskAwaiter<SubRoomDataSaveDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9F20", Offset = "0x8DC8D20", VA = "0x188DC9F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x8DCA5E0", Offset = "0x8DC93E0", VA = "0x188DCA5E0", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			private ZVLYRPRVNIB <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			private TaskAwaiter<ResolvedLoadParameters> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			private TaskAwaiter<RoomLoadDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x8DCA650", Offset = "0x8DC9450", VA = "0x188DCA650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x8DCB590", Offset = "0x8DCA390", VA = "0x188DCB590", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY stackTimer;

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
			private ZRSJAVAQQNC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			private StackTimer<string>.XDYOTKRANGY <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x8DCB600", Offset = "0x8DCA400", VA = "0x188DCB600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x8DCBBE0", Offset = "0x8DCA9E0", VA = "0x188DCBBE0", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY stackTimer;

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
			[Cpp2IlInjected.Address(RVA = "0x8DCC230", Offset = "0x8DCB030", VA = "0x188DCC230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x8DCC800", Offset = "0x8DCB600", VA = "0x188DCC800", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			private TaskAwaiter<ResolvedLoadParameters> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x8DCBC50", Offset = "0x8DCAA50", VA = "0x188DCBC50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x8DCC1C0", Offset = "0x8DCAFC0", VA = "0x188DCC1C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private OEJGLDFIKZO FFRQMGYVOAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private CUJVBYRHGHA SARRDALHDLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private TBDOKCNPZCW SNGRLPURGRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private JJUZHWLOPXU KYAZQFRLGNR;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2D80", Offset = "0x8DC1B80", VA = "0x188DC2D80", Slot = "5")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2E70", Offset = "0x8DC1C70", VA = "0x188DC2E70", Slot = "4")]
		[AsyncStateMachine(typeof(<GetRoomLoadRequestPayload>d__6))]
		public Task<RoomLoadRequestPayload> OFRZFJOBHCL(StackTimer<string>.XDYOTKRANGY a, RoomInstance b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3140", Offset = "0x8DC1F40", VA = "0x188DC3140")]
		[AsyncStateMachine(typeof(<GetRoomDetails>d__7))]
		private Task<RoomDetailsDTO> QXBQGQANKJK(RoomInstance a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2FD0", Offset = "0x8DC1DD0", VA = "0x188DC2FD0")]
		[AsyncStateMachine(typeof(<GetRoomLoadRequestPayloadFromDetailsAndSubroom>d__8))]
		private Task<RoomLoadRequestPayload> PKOZPHYOXFD(RoomInstance a, RoomDetailsDTO b, long c, StackTimer<string>.XDYOTKRANGY d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x8DC32A0", Offset = "0x8DC20A0", VA = "0x188DC32A0")]
		[AsyncStateMachine(typeof(<GetRoomDataBlobWithHashForRoomDetails>d__9))]
		private Task<ResolvedLoadParameters> RAJLNUCNLTR(RoomInstance a, RoomDetailsDTO b, long c, StackTimer<string>.XDYOTKRANGY d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3410", Offset = "0x8DC2210", VA = "0x188DC3410")]
		[AsyncStateMachine(typeof(<GetDefaultRoomDataBlobWithHashForDorms>d__10))]
		private Task<ResolvedLoadParameters> RNOPZIZGFFM(RoomInstance a, SubRoomDTO b, long c, StackTimer<string>.XDYOTKRANGY d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomManagerRoomLoadRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerSynchronization : AYYYDIPYFGM, ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class ROWRFPJNAWU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public FJZTCZTAMBW LTDBLSPDUBW;

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ROWRFPJNAWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x8DBC650", Offset = "0x8DBB450", VA = "0x188DBC650")]
			internal object WYTMYQRIZFB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		[CompilerGenerated]
		private sealed class EIGBKFCSTWH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			public FJZTCZTAMBW LTDBLSPDUBW;

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EIGBKFCSTWH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x8DBC3D0", Offset = "0x8DBB1D0", VA = "0x188DBC3D0")]
			internal object KWKUHVAVOZQ()
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
			public AsyncTaskMethodBuilder<FJZTCZTAMBW> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public FJZTCZTAMBW request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public RoomManagerSynchronization <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public WAMQFEAEZXB pauseToken;

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
			private IVOXODIYNLM <masterSwitchCancellationScope>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x8DCDFA0", Offset = "0x8DCCDA0", VA = "0x188DCDFA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x8DCEB40", Offset = "0x8DCD940", VA = "0x188DCEB40", Slot = "5")]
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
			public AsyncTaskMethodBuilder<FJZTCZTAMBW> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public FJZTCZTAMBW request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public RoomManagerSynchronization <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public WAMQFEAEZXB pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private TaskAwaiter<FJZTCZTAMBW> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x8DCEBB0", Offset = "0x8DCD9B0", VA = "0x188DCEBB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x8DCF1B0", Offset = "0x8DCDFB0", VA = "0x188DCF1B0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<FJZTCZTAMBW> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public RoomManagerSynchronization <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public WAMQFEAEZXB pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x8DD0E00", Offset = "0x8DCFC00", VA = "0x188DD0E00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x8DD13D0", Offset = "0x8DD01D0", VA = "0x188DD13D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private VJRNQPLOUBG FBPQEEAUUKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private REGKVZCYSDQ EDHGLRSXJJH;

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		private VEURRDRAUAE VEURRDRAUAE
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x8DC3800", Offset = "0x8DC2600", VA = "0x188DC3800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3580", Offset = "0x8DC2380", VA = "0x188DC3580", Slot = "8")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8DC38C0", Offset = "0x8DC26C0", VA = "0x188DC38C0", Slot = "4")]
		[AsyncStateMachine(typeof(<MasterSynchronizeRequest>d__6))]
		public Task<FJZTCZTAMBW> VETTTTDUTTI(FJZTCZTAMBW a, WAMQFEAEZXB b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x8DC36B0", Offset = "0x8DC24B0", VA = "0x188DC36B0", Slot = "5")]
		[AsyncStateMachine(typeof(<PopNextBufferedEvent>d__7))]
		public Task<FJZTCZTAMBW> OXTBLYUEDIA(CancellationToken a, WAMQFEAEZXB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3610", Offset = "0x8DC2410", VA = "0x188DC3610", Slot = "6")]
		public IRZBFTNHIIP OMTJXGUOMCL(EKKWWDICQVS a, StackTimer<string>.XDYOTKRANGY b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3B80", Offset = "0x8DC2980", VA = "0x188DC3B80", Slot = "7")]
		public IRZBFTNHIIP ZZGXEUPXELU(EKKWWDICQVS a, StackTimer<string>.XDYOTKRANGY b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3A20", Offset = "0x8DC2820", VA = "0x188DC3A20")]
		[AsyncStateMachine(typeof(<MasterSyncRequestAndValidateResponse>d__10))]
		private Task<FJZTCZTAMBW> XYGZQFBDNGZ(FJZTCZTAMBW a, WAMQFEAEZXB b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x3996080", Offset = "0x3994E80", VA = "0x183996080")]
		private static byte[] TQCTZCPBLIG(FJZTCZTAMBW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomManagerSynchronization()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerValidation : ZEAPVLGZEGH, ETETUEKLXQT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private GFMOTRWDXSL YSPFAZRQHHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private VJRNQPLOUBG FBPQEEAUUKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private TUQBTWGFKKL EKIBAXZITGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private JDIJDQHKTNX SCSOGVIBKLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private OEJGLDFIKZO FFRQMGYVOAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private FKHXPTFDNYD PWUEBWQCFZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private PUSBFHUAPQW MIUVFQFHTQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private CUJVBYRHGHA SARRDALHDLD;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private ZZSHRDKMGMU YWWFJNZECIV
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x8DC3E30", Offset = "0x8DC2C30", VA = "0x188DC3E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private static MMSSFGQGRLF UHWNENBQXJU
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x8DC3CA0", Offset = "0x8DC2AA0", VA = "0x188DC3CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3CB0", Offset = "0x8DC2AB0", VA = "0x188DC3CB0", Slot = "6")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4100", Offset = "0x8DC2F00", VA = "0x188DC4100", Slot = "4")]
		public MMSSFGQGRLF YKSSMEKWGTR(XGOJTPBZDNO a, RoomOperationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3E80", Offset = "0x8DC2C80", VA = "0x188DC3E80", Slot = "5")]
		public MMSSFGQGRLF WXELYSRSOFU(XGOJTPBZDNO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3E20", Offset = "0x8DC2C20", VA = "0x188DC3E20")]
		private static MMSSFGQGRLF SRFJJBATKDJ(ValidationReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomManagerValidation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class RoomOperationAlreadyInProgressException : InvalidOperationException
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4B50", Offset = "0x8DE3950", VA = "0x188DE4B50")]
		public RoomOperationAlreadyInProgressException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7F31530", Offset = "0x7F30330", VA = "0x187F31530")]
		public RoomOperationAlreadyInProgressException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerAutosaves : OVNBCFKHIDF, ETETUEKLXQT, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x8DE5810", Offset = "0x8DE4610", VA = "0x188DE5810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x8DE5C80", Offset = "0x8DE4A80", VA = "0x188DE5C80", Slot = "5")]
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
			public AsyncTaskMethodBuilder<MMSSFGQGRLF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public JFLMODKHJZH autosaveRecordInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private StackTimer<string> <timer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private StackTimer<string>.XDYOTKRANGY <timerScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			private TQIAVOAERFN <operation>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			private StackTimer<string>.XDYOTKRANGY <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			private TaskAwaiter<MMSSFGQGRLF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x8DE82A0", Offset = "0x8DE70A0", VA = "0x188DE82A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x8DE8C70", Offset = "0x8DE7A70", VA = "0x188DE8C70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DEE7A0", Offset = "0x8DED5A0", VA = "0x188DEE7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x8DEED10", Offset = "0x8DEDB10", VA = "0x188DEED10", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DEE250", Offset = "0x8DED050", VA = "0x188DEE250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x8DEE740", Offset = "0x8DED540", VA = "0x188DEE740", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DEDA30", Offset = "0x8DEC830", VA = "0x188DEDA30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x8DEE1F0", Offset = "0x8DECFF0", VA = "0x188DEE1F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DEF330", Offset = "0x8DEE130", VA = "0x188DEF330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x8DEFA60", Offset = "0x8DEE860", VA = "0x188DEFA60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DEF130", Offset = "0x8DEDF30", VA = "0x188DEF130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x8DEF2D0", Offset = "0x8DEE0D0", VA = "0x188DEF2D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DF2610", Offset = "0x8DF1410", VA = "0x188DF2610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x8DF2D10", Offset = "0x8DF1B10", VA = "0x188DF2D10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private VJRNQPLOUBG FBPQEEAUUKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private ZVTYJEOYACF SLBUPCNYZAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private OEJGLDFIKZO FFRQMGYVOAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private AYYYDIPYFGM WJLLMHCZGWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private TUQBTWGFKKL EKIBAXZITGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private PUSBFHUAPQW MIUVFQFHTQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private CancellationTokenSource SHRPIHFHIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private Task SKQWTFZHSNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private TaskCompletionSource<int> JIDSRTAGROC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private int HNETJPAPPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private int QDYNKOYRWZI;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3C70", Offset = "0x8DE2A70", VA = "0x188DE3C70", Slot = "6")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x15AEA10", Offset = "0x15AD810", VA = "0x1815AEA10", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3600", Offset = "0x8DE2400", VA = "0x188DE3600")]
		private void BXJXXQQRRWX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3F20", Offset = "0x8DE2D20", VA = "0x188DE3F20", Slot = "4")]
		[AsyncStateMachine(typeof(<RequestRestoreAutosave>d__14))]
		public Task<MMSSFGQGRLF> RequestRestoreAutosave(JFLMODKHJZH autosaveRecordInfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4160", Offset = "0x8DE2F60", VA = "0x188DE4160", Slot = "5")]
		[AsyncStateMachine(typeof(<RunRecoveryAutosave>d__15))]
		public Task WTVJFGJQDZL([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x15AEA10", Offset = "0x15AD810", VA = "0x1815AEA10")]
		public void PNAIAPPDITD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3A50", Offset = "0x8DE2850", VA = "0x188DE3A50")]
		private TQIAVOAERFN GTDPMFJTVAG(JFLMODKHJZH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x8DE44C0", Offset = "0x8DE32C0", VA = "0x188DE44C0")]
		[AsyncStateMachine(typeof(<RunAutosaveRoutine>d__18))]
		private Task XXTZLSKARTY(CancellationToken a, int b, AccountRoleType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3E20", Offset = "0x8DE2C20", VA = "0x188DE3E20")]
		[AsyncStateMachine(typeof(<RunAutosaveRoutineInternal>d__19))]
		private Task LKMGWZREZHN(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x8DE36E0", Offset = "0x8DE24E0", VA = "0x188DE36E0")]
		[AsyncStateMachine(typeof(<RunRecoveryAutosaveInternal>d__20))]
		private Task DRXCQIZXKHO([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3960", Offset = "0x8DE2760", VA = "0x188DE3960")]
		[AsyncStateMachine(typeof(<ScheduleIncrementalAutosave>d__21))]
		private Task EFTGRNRZRUU(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3500", Offset = "0x8DE2300", VA = "0x188DE3500")]
		[AsyncStateMachine(typeof(<AwaitAutosaveInterval>d__22))]
		private Task BKQZBJIZODO(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x8DE37D0", Offset = "0x8DE25D0", VA = "0x188DE37D0")]
		private Task DVMFAALXFHZ(AutosaveType a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4050", Offset = "0x8DE2E50", VA = "0x188DE4050")]
		[AsyncStateMachine(typeof(<RunAutosave>d__24))]
		private Task RunAutosave(AutosaveType autosaveType, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4250", Offset = "0x8DE3050", VA = "0x188DE4250")]
		private bool WUPJCCBEMFF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomManagerAutosaves()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomManagerSave : JDIJDQHKTNX, ETETUEKLXQT, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x8DE8CE0", Offset = "0x8DE7AE0", VA = "0x188DE8CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x8DE9270", Offset = "0x8DE8070", VA = "0x188DE9270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private LXJOBNOPNUL DHXKHYZFTMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		private ZVTYJEOYACF SLBUPCNYZAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private ZEAPVLGZEGH GZGHQOABEBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private AYYYDIPYFGM WJLLMHCZGWB;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4600", Offset = "0x8DE3400", VA = "0x188DE4600", Slot = "6")]
		public void Initialize(ZVTYJEOYACF roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE45B0", Offset = "0x8DE33B0", VA = "0x188DE45B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE48D0", Offset = "0x8DE36D0", VA = "0x188DE48D0", Slot = "5")]
		[AsyncStateMachine(typeof(<RequestSaveRoomToDisk>d__6))]
		public Task RequestSaveRoomToDisk(string path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x8DE49D0", Offset = "0x8DE37D0", VA = "0x188DE49D0", Slot = "4")]
		public MMSSFGQGRLF WUPJCCBEMFF(XGOJTPBZDNO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4A30", Offset = "0x8DE3830", VA = "0x188DE4A30")]
		private LUYNVTAZTOC ZIZORAAYZQP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RoomManagerSave()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public static class XBONRPEMPIX
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4A30", Offset = "0x8DF3830", VA = "0x188DF4A30")]
		public static void JNIFPTBWHMZ(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x8DF50A0", Offset = "0x8DF3EA0", VA = "0x188DF50A0")]
		internal static void ZICKGOTYGWW(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4950", Offset = "0x8DF3750", VA = "0x188DF4950")]
		internal static void GMJAUCSDSAP(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4C70", Offset = "0x8DF3A70", VA = "0x188DF4C70")]
		internal static void XSXUDTEIFCB(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x3E8B940", Offset = "0x3E8A740", VA = "0x183E8B940")]
		private static void KBEXDFHLJVB<a, b, a>(FDTRVDFSBYT a) where b : a
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	internal class VGSHWBYYPGC : RBVRNQXPWUI<FJZTCZTAMBW>
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class QFVEKDSMASK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public FJZTCZTAMBW LVFNANVSRTE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public string TNKBFNMFMDC;

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QFVEKDSMASK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x8DE06B0", Offset = "0x8DDF4B0", VA = "0x188DE06B0")]
			internal object MKBTMFXGKQF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public static readonly VGSHWBYYPGC GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x8DF46D0", Offset = "0x8DF34D0", VA = "0x188DF46D0")]
		public ExitGames.Client.Photon.Hashtable Serialize(FJZTCZTAMBW message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4750", Offset = "0x8DF3550", VA = "0x188DF4750", Slot = "5")]
		protected override void WKXNQMYCAAD(FJZTCZTAMBW a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4100", Offset = "0x8DF2F00", VA = "0x188DF4100", Slot = "6")]
		public override FJZTCZTAMBW Deserialize(IDictionary<object, object> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4330", Offset = "0x8DF3130", VA = "0x188DF4330")]
		private static void Log(string op, FJZTCZTAMBW message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4910", Offset = "0x8DF3710", VA = "0x188DF4910")]
		public VGSHWBYYPGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4430", Offset = "0x8DF3230", VA = "0x188DF4430")]
		[CompilerGenerated]
		internal static string NRKZFFOPJRW(RoomLoadRequestPayload a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public static class UOFOREXHZAO
	{
		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public static MMSSFGQGRLF UHWNENBQXJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x8DF3B90", Offset = "0x8DF2990", VA = "0x188DF3B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3BF0", Offset = "0x8DF29F0", VA = "0x188DF3BF0")]
		public static bool JLZXQQCVRLM(this MMSSFGQGRLF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3E00", Offset = "0x8DF2C00", VA = "0x188DF3E00")]
		public static MMSSFGQGRLF SRFJJBATKDJ(ValidationReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3C10", Offset = "0x8DF2A10", VA = "0x188DF3C10")]
		public static MMSSFGQGRLF NJLBLXFFJWQ(IEnumerable<MMSSFGQGRLF> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3950", Offset = "0x8DF2750", VA = "0x188DF3950")]
		public static string AYEHCCITDEV(this MMSSFGQGRLF a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public abstract class CSDDGXBTCKR : KPDSJCCCIBW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		public delegate MMSSFGQGRLF ValidateOperation([NotNull] XGOJTPBZDNO networkPlayer);

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class EIGBKFCSTWH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public XGOJTPBZDNO QCXQDLCGVQU;

			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EIGBKFCSTWH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x18693C0", Offset = "0x18681C0", VA = "0x1818693C0")]
			internal MMSSFGQGRLF IHPMFDWRBYX(ValidateOperation a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private bool IYRJDGYKKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		protected readonly HashSet<ValidateOperation> BMCJPNPXKRO;

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB5A0", Offset = "0x8DDA3A0", VA = "0x188DDB5A0", Slot = "4")]
		public void BYSRLXJWFJS(ValidateOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB650", Offset = "0x8DDA450", VA = "0x188DDB650", Slot = "5")]
		public void JVMOHGAEDTD(ValidateOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB600", Offset = "0x8DDA400", VA = "0x188DDB600", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB6B0", Offset = "0x8DDA4B0", VA = "0x188DDB6B0")]
		protected MMSSFGQGRLF XZCVPLFVMWV(XGOJTPBZDNO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB930", Offset = "0x8DDA730", VA = "0x188DDB930")]
		protected CSDDGXBTCKR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public class UYMCWOTSOGG : CSDDGXBTCKR, GFMOTRWDXSL, KPDSJCCCIBW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class CEXFFSBJGFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public MMSSFGQGRLF IZSRSIHKIMW;

			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public CEXFFSBJGFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x8DDB4E0", Offset = "0x8DDA2E0", VA = "0x188DDB4E0")]
			internal object PMELAVIDUMB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4030", Offset = "0x8DF2E30", VA = "0x188DF4030")]
		[UnityEngine.Scripting.Preserve]
		public UYMCWOTSOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3F30", Offset = "0x8DF2D30", VA = "0x188DF3F30", Slot = "8")]
		public MMSSFGQGRLF FNFTJYVJLPV(XGOJTPBZDNO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public class XDFUUNIYPDY : CSDDGXBTCKR, LXJOBNOPNUL, KPDSJCCCIBW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		[CompilerGenerated]
		private sealed class CEXFFSBJGFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public MMSSFGQGRLF IZSRSIHKIMW;

			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public CEXFFSBJGFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x8DDB540", Offset = "0x8DDA340", VA = "0x188DDB540")]
			internal object QMSRMZNIHCZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4030", Offset = "0x8DF2E30", VA = "0x188DF4030")]
		[UnityEngine.Scripting.Preserve]
		public XDFUUNIYPDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5200", Offset = "0x8DF4000", VA = "0x188DF5200", Slot = "8")]
		public MMSSFGQGRLF WUPJCCBEMFF(XGOJTPBZDNO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	internal static class ACVXAYSSEQU
	{
		[Cpp2IlInjected.Token(Token = "0x20000EE")]
		[CompilerGenerated]
		private sealed class EIGBKFCSTWH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public StackTimer<string> SHJHFDTVCGA;

			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EIGBKFCSTWH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0x8DDCC10", Offset = "0x8DDBA10", VA = "0x188DDCC10")]
			internal object SUYFHOXEFMB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB350", Offset = "0x8DDA150", VA = "0x188DDB350")]
		public static StackTimer<string> XDYOTKRANGY(Log a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB290", Offset = "0x8DDA090", VA = "0x188DDB290")]
		public static void JPGVRGOCBUT(StackTimer<string> a, Log b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB420", Offset = "0x8DDA220", VA = "0x188DDB420")]
		public static string XGEQPPISPMU(FJZTCZTAMBW a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	internal static class RKSPAHFKAWD
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2D10", Offset = "0x8DE1B10", VA = "0x188DE2D10")]
		public static void FTYBWCVPOLE(this VJRNQPLOUBG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2E40", Offset = "0x8DE1C40", VA = "0x188DE2E40")]
		public static void KXXKXQTFYNZ(this VJRNQPLOUBG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2D20", Offset = "0x8DE1B20", VA = "0x188DE2D20")]
		private static void JOOJTRWRXNT(this VJRNQPLOUBG a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public class EGBNKECCMXO : NBRUWXWOQFS, EQXCCDYYMVL, WWHPPCVYRNM, JKLWLBPNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		private class OICLMXCHKVQ : EREVFMKOODS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			private readonly byte GURVMNCBMMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			private readonly int IURCTXHVDUO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			private readonly object MIORXFGRXCU;

			[Cpp2IlInjected.Token(Token = "0x170000CC")]
			public byte ZUPUUKDUHLM
			{
				[Cpp2IlInjected.Token(Token = "0x600046B")]
				[Cpp2IlInjected.Address(RVA = "0xB12A00", Offset = "0xB11800", VA = "0x180B12A00", Slot = "4")]
				get
				{
					return default(byte);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CD")]
			public int QMPBGCEBLTY
			{
				[Cpp2IlInjected.Token(Token = "0x600046C")]
				[Cpp2IlInjected.Address(RVA = "0xBBC350", Offset = "0xBBB150", VA = "0x180BBC350", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CE")]
			public object ATGJXGHTYWI
			{
				[Cpp2IlInjected.Token(Token = "0x600046D")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			public object this[byte key]
			{
				[Cpp2IlInjected.Token(Token = "0x600046E")]
				[Cpp2IlInjected.Address(RVA = "0x8DDFFB0", Offset = "0x8DDEDB0", VA = "0x188DDFFB0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x7F38940", Offset = "0x7F37740", VA = "0x187F38940")]
			public OICLMXCHKVQ(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x8DDFF70", Offset = "0x8DDED70", VA = "0x188DDFF70", Slot = "8")]
			public bool DBGOVWLVGUF(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private readonly EQXCCDYYMVL YJFSYGLLXXT;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public XGOJTPBZDNO BATNORFFEXB
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x8DDC280", Offset = "0x8DDB080", VA = "0x188DDC280", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public int XFMRSIFQDJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x8DDCB80", Offset = "0x8DDB980", VA = "0x188DDCB80", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public int GPCXEIXJQQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x8DDC680", Offset = "0x8DDB480", VA = "0x188DDC680", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public XGOJTPBZDNO EFVVCJCQKSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x8DDC6D0", Offset = "0x8DDB4D0", VA = "0x188DDC6D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool SCUFOCJJZIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public int ROQRHDMODIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string ICPOJMBRVOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x8DDC4A0", Offset = "0x8DDB2A0", VA = "0x188DDC4A0", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Func<string, string> LLQZNYGPMXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x8DDC920", Offset = "0x8DDB720", VA = "0x188DDC920", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<string, long> KJWEIYDRGKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<EREVFMKOODS> KPHGKGPQPKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x8DDC9F0", Offset = "0x8DDB7F0", VA = "0x188DDC9F0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x8DDC1D0", Offset = "0x8DDAFD0", VA = "0x188DDC1D0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<bool> FIACKLCLGBM
		{
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "26")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "27")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<XGOJTPBZDNO> FDYUBXVVHBQ
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "9")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action TRCFQVJTAXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x8DDC320", Offset = "0x8DDB120", VA = "0x188DDC320", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x8DDC5E0", Offset = "0x8DDB3E0", VA = "0x188DDC5E0", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC720", Offset = "0x8DDB520", VA = "0x188DDC720", Slot = "19")]
		public void RLXZEVYDQEG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xEBA5B0", Offset = "0xEB93B0", VA = "0x180EBA5B0")]
		public EGBNKECCMXO(EQXCCDYYMVL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC780", Offset = "0x8DDB580", VA = "0x188DDC780", Slot = "8")]
		public bool RaiseEvent(byte eventCode, object eventContent, QBWHSXSYUOT raiseEventOptions, RRNetworkDelivery networkDelivery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC880", Offset = "0x8DDB680", VA = "0x188DDC880", Slot = "20")]
		public XGOJTPBZDNO TMCMSHIYMKY(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x8DDCAA0", Offset = "0x8DDB8A0", VA = "0x188DDCAA0", Slot = "21")]
		public XGOJTPBZDNO YBLHDXQBZQW(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC500", Offset = "0x8DDB300", VA = "0x188DDC500", Slot = "22")]
		public XGOJTPBZDNO HZDVDXSQUJG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC3C0", Offset = "0x8DDB1C0", VA = "0x188DDC3C0", Slot = "23")]
		public IReadOnlyList<XGOJTPBZDNO> FTKOFGOJVAY(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x8DDCBD0", Offset = "0x8DDB9D0", VA = "0x188DDCBD0", Slot = "24")]
		public IReadOnlyList<XGOJTPBZDNO> YQTFVEVPURN(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "25")]
		public bool QNKIKGYQPDC(XGOJTPBZDNO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "28")]
		public void HSKSIAQLDLR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "29")]
		public void KIEFSNWOJNK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "30")]
		public void REBTXUYJGLU(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC2D0", Offset = "0x8DDB0D0", VA = "0x188DDC2D0", Slot = "31")]
		public IDisposable BFSRCQOONSV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "32")]
		private bool NMGEYPYZEUU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "33")]
		public void VZXCVFQBDNO(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x111B960", Offset = "0x111A760", VA = "0x18111B960", Slot = "34")]
		public bool HBQXXCFRXWL(bool a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x10AD800", Offset = "0x10AC600", VA = "0x1810AD800", Slot = "37")]
		public void JOIFFJVXEFI()
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
		[Cpp2IlInjected.Address(RVA = "0xECEFD0", Offset = "0xECDDD0", VA = "0x180ECEFD0")]
		public OperationEventData(IDictionary<object, object> eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x8DE02C0", Offset = "0x8DDF0C0", VA = "0x188DE02C0")]
		public bool TWICKWOJYYE([Out] FJZTCZTAMBW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x8DE00E0", Offset = "0x8DDEEE0", VA = "0x188DE00E0")]
		public Guid NPCQZUKFZXN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0190", Offset = "0x8DDEF90", VA = "0x188DE0190")]
		public MMSSFGQGRLF OPWZISBWITR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFFF0", Offset = "0x8DDEDF0", VA = "0x188DDFFF0")]
		public static ExitGames.Client.Photon.Hashtable Create(FJZTCZTAMBW message, MMSSFGQGRLF validationResult)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	internal static class FAOEXOWNPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x8DDD9F0", Offset = "0x8DDC7F0", VA = "0x188DDD9F0")]
		public static bool XYVHCUNDGPE(this RoomInstance a)
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
			[Cpp2IlInjected.Address(RVA = "0x8DEFAC0", Offset = "0x8DEE8C0", VA = "0x188DEFAC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0x8DEFCA0", Offset = "0x8DEEAA0", VA = "0x188DEFCA0", Slot = "5")]
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
		public bool QMJEJQMQHET
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x8DE55A0", Offset = "0x8DE43A0", VA = "0x188DE55A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x8DE56E0", Offset = "0x8DE44E0", VA = "0x188DE56E0")]
		public TaskRunner(CancellationToken cancellationToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x8DE55D0", Offset = "0x8DE43D0", VA = "0x188DE55D0")]
		[AsyncStateMachine(typeof(<RunTasks>d__8))]
		public Task WQEDLQGCUJY(Func<CancellationToken, List<Task>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5550", Offset = "0x8DE4350", VA = "0x188DE5550", Slot = "4")]
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
			public AsyncTaskMethodBuilder<Result<ParseResult<TData>, RHLDYTPLBXY>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public StackTimer<string>.XDYOTKRANGY timer;

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
			private StackTimer<string>.XDYOTKRANGY <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			private TaskAwaiter<Result<ParseResult<TData>, RHLDYTPLBXY>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0x513EC70", Offset = "0x513DA70", VA = "0x18513EC70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0x513F360", Offset = "0x513E160", VA = "0x18513F360", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private readonly LIEACBXUCRG<TGetDataArg, TData> _deps;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xECEFD0", Offset = "0xECDDD0", VA = "0x180ECEFD0")]
		internal VersionedDataGetter(LIEACBXUCRG<TGetDataArg, TData> deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x68B2710", Offset = "0x68B1510", VA = "0x1868B2710")]
		[AsyncStateMachine(typeof(VersionedDataGetter<, >.<DownloadAndParse>d__2))]
		public Task<Result<ParseResult<TData>, RHLDYTPLBXY>> WTVJAGTKATF(TGetDataArg a, string b, StackTimer<string>.XDYOTKRANGY c, CancellationToken d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public static class IUXZOPLKOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x3871D80", Offset = "0x3870B80", VA = "0x183871D80")]
		public static VersionedDataGetter<TGetDataArg, TData> New<TGetDataArg, TData>(LIEACBXUCRG<TGetDataArg, TData> deps)
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
		[Cpp2IlInjected.Address(RVA = "0x55733A0", Offset = "0x55721A0", VA = "0x1855733A0")]
		public ErrorCode(int code, [Optional] int? subCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x8DDD920", Offset = "0x8DDC720", VA = "0x188DDD920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public interface NGDAPINPVHG<a> where a : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LPBDIBNGUCD();

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NGDAPINPVHG<a> HJNMBXADEDY(string a);

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NGDAPINPVHG<a> WWWDWCTUNNL(UserFriendlyErrorMessageBuilder<a> a);

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(Slot = "3")]
		NGDAPINPVHG<a> MREOYCGEROO(int a);

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NGDAPINPVHG<a> SAZHOUHPPRT(int a, GetSubCode<a> b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public interface LZGITPOTRPS
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NGDAPINPVHG<a> RSHKPNCGJHJ<a>() where a : Exception;

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(Slot = "1")]
		UserFriendlyErrorInfo GVTHNADXIWC(Exception a);

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ErrorCode SKFPYURUNGY(Exception a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public delegate string UserFriendlyErrorMessageBuilder<in T>(T ex) where T : Exception;
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public delegate int GetSubCode<in T>(T ex) where T : Exception;
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	internal class YHKWWLPOZBD : LZGITPOTRPS
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		private delegate string UserFriendlyErrorMessageBuilder(Exception ex);

		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private delegate int GetSubCodeInternal(Exception ex);

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		private class Registration<T> : NGDAPINPVHG<T> where T : notnull, Exception
		{
			[Cpp2IlInjected.Token(Token = "0x2000102")]
			[CompilerGenerated]
			private sealed class EERSQRFLGMR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003CB")]
				public string LEVFPSNECLQ;

				[Cpp2IlInjected.Token(Token = "0x60004A8")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public EERSQRFLGMR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004A9")]
				[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
				internal string FIWNCROKJHI(Exception a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000103")]
			[CompilerGenerated]
			private sealed class QFVEKDSMASK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003CC")]
				public UserFriendlyErrorMessageBuilder<T> GVQPJNYPXJL;

				[Cpp2IlInjected.Token(Token = "0x60004AA")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public QFVEKDSMASK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004AB")]
				[Cpp2IlInjected.Address(RVA = "0x5DDAB60", Offset = "0x5DD9960", VA = "0x185DDAB60")]
				internal string XRGHIPCJQVZ(Exception a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[CompilerGenerated]
			private sealed class WCODKRWUAFT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003CD")]
				public GetSubCode<T> XNDTCAZDZUU;

				[Cpp2IlInjected.Token(Token = "0x60004AC")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public WCODKRWUAFT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004AD")]
				[Cpp2IlInjected.Address(RVA = "0x5DDAB60", Offset = "0x5DD9960", VA = "0x185DDAB60")]
				internal int UGKUCUHFJLZ(Exception a)
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			private readonly YHKWWLPOZBD DHCDWYZPKYA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			private readonly Type VLGWWUAEVKA;

			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x6083CC0", Offset = "0x6082AC0", VA = "0x186083CC0")]
			internal Registration(YHKWWLPOZBD errorRegistry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x6083A30", Offset = "0x6082830", VA = "0x186083A30", Slot = "4")]
			public void LPBDIBNGUCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x6083930", Offset = "0x6082730", VA = "0x186083930", Slot = "5")]
			public NGDAPINPVHG<T> HJNMBXADEDY(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x6083BC0", Offset = "0x60829C0", VA = "0x186083BC0", Slot = "6")]
			public NGDAPINPVHG<T> WWWDWCTUNNL(UserFriendlyErrorMessageBuilder<T> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x6083A60", Offset = "0x6082860", VA = "0x186083A60", Slot = "7")]
			public NGDAPINPVHG<T> MREOYCGEROO(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x6083AA0", Offset = "0x60828A0", VA = "0x186083AA0", Slot = "8")]
			public NGDAPINPVHG<T> SAZHOUHPPRT(int a, GetSubCode<T> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000105")]
		private class ICJNGUNMBNW<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private bool HFDPCBUYANC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private readonly List<Type> YLZNWKHXATM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			private readonly Dictionary<Type, a> GIDPEXYUWSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			private readonly Dictionary<Type, int> CFTAIMYUYNG;

			[Cpp2IlInjected.Token(Token = "0x170000D1")]
			public IReadOnlyList<Type> IHQUYAHYSZC
			{
				[Cpp2IlInjected.Token(Token = "0x60004B0")]
				[Cpp2IlInjected.Address(RVA = "0x52CB330", Offset = "0x52CA130", VA = "0x1852CB330")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x52CB890", Offset = "0x52CA690", VA = "0x1852CB890")]
			public ICJNGUNMBNW(Dictionary<Type, int> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0x52CAEE0", Offset = "0x52C9CE0", VA = "0x1852CAEE0")]
			public void Add(Type key, a val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x52CB3E0", Offset = "0x52CA1E0", VA = "0x1852CB3E0")]
			public bool OCEGHBBYZXL(Type a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x52CB460", Offset = "0x52CA260", VA = "0x1852CB460")]
			public bool PMPNFVWPLMT(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x52CB1A0", Offset = "0x52C9FA0", VA = "0x1852CB1A0")]
			public a Get(Type type)
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x52CB6F0", Offset = "0x52CA4F0", VA = "0x1852CB6F0")]
			[CompilerGenerated]
			private int YSZETXMSBGX(Type a, Type b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000107")]
		[CompilerGenerated]
		private sealed class XNEQVVRYJKF : IEnumerable<ErrorCode>, IEnumerable, IEnumerator<ErrorCode>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private ErrorCode QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			private int DQRPPGNAYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public YHKWWLPOZBD WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			private Exception DRNNHSFOJIW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public Exception FYJPANHUVDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			private IEnumerator<Exception> ZQJSAWQBUYL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			private IEnumerator<ErrorCode> ZQOYYDJZEJU;

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			private ErrorCode PSJMKTDPDBI
			{
				[Cpp2IlInjected.Token(Token = "0x60004BE")]
				[Cpp2IlInjected.Address(RVA = "0x19D04A0", Offset = "0x19CF2A0", VA = "0x1819D04A0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ErrorCode);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D3")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60004C0")]
				[Cpp2IlInjected.Address(RVA = "0x8DF5A90", Offset = "0x8DF4890", VA = "0x188DF5A90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
			[DebuggerHidden]
			public XNEQVVRYJKF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x8DF53F0", Offset = "0x8DF41F0", VA = "0x188DF53F0", Slot = "7")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x8DF55E0", Offset = "0x8DF43E0", VA = "0x188DF55E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x8DF5540", Offset = "0x8DF4340", VA = "0x188DF5540")]
			private void LKISUJFCFYE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x8DF5590", Offset = "0x8DF4390", VA = "0x188DF5590")]
			private void LKYNMDMUIGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x8DF53B0", Offset = "0x8DF41B0", VA = "0x188DF53B0", Slot = "10")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x8DF5300", Offset = "0x8DF4100", VA = "0x188DF5300", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ErrorCode> DCVVOPOJPIB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x8DF5300", Offset = "0x8DF4100", VA = "0x188DF5300", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly ErrorCode ZONDANKFDGJ;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private static readonly Dictionary<Type, int> TQQFDBHPDAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private readonly HashSet<Type> ZTCWDCCWOOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private readonly ICJNGUNMBNW<int> HYFJVMXAHSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private readonly ICJNGUNMBNW<GetSubCodeInternal> JEEMMDXONWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private readonly ICJNGUNMBNW<UserFriendlyErrorMessageBuilder> IBCRORFBUTG;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6C70", Offset = "0x8DF5A70", VA = "0x188DF6C70")]
		[FDNTPBIGLET.Root.GameOnly]
		internal static void FDNTPBIGLET(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7C20", Offset = "0x8DF6A20", VA = "0x188DF7C20")]
		[RecRoom.NoEngine.Common.Preserve]
		public YHKWWLPOZBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x3EA0BB0", Offset = "0x3E9F9B0", VA = "0x183EA0BB0", Slot = "4")]
		public NGDAPINPVHG<T> RSHKPNCGJHJ<T>() where T : notnull, Exception
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7050", Offset = "0x8DF5E50", VA = "0x188DF7050", Slot = "5")]
		public UserFriendlyErrorInfo GVTHNADXIWC(Exception a)
		{
			return default(UserFriendlyErrorInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7800", Offset = "0x8DF6600", VA = "0x188DF7800", Slot = "6")]
		public ErrorCode SKFPYURUNGY(Exception? a)
		{
			return default(ErrorCode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6BE0", Offset = "0x8DF59E0", VA = "0x188DF6BE0", Slot = "7")]
		[IteratorStateMachine(typeof(XNEQVVRYJKF))]
		public IEnumerable<ErrorCode> DFHGOAONZIQ(Exception a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x8DF76B0", Offset = "0x8DF64B0", VA = "0x188DF76B0", Slot = "8")]
		public string PDKLSDQIMAU(Exception? ex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x8DF71B0", Offset = "0x8DF5FB0", VA = "0x188DF71B0")]
		private string IUXALVPFEOC(AggregateException a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6CE0", Offset = "0x8DF5AE0", VA = "0x188DF6CE0")]
		private void GMQIKKIPQIM(Type a, int b, GetSubCodeInternal? getSubCodeInternal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7490", Offset = "0x8DF6290", VA = "0x188DF7490")]
		private void OXDSVGXFVQO(Type a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6940", Offset = "0x8DF5740", VA = "0x188DF6940")]
		private void BNOYRRXOHNN(Type a, UserFriendlyErrorMessageBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7A00", Offset = "0x8DF6800", VA = "0x188DF7A00")]
		private static int UGVOITKPDOL(Type a, Dictionary<Type, int> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x3EA07C0", Offset = "0x3E9F5C0", VA = "0x183EA07C0")]
		private static bool EJAOGJMBKTK<TVal>(ICJNGUNMBNW<TVal> a, Type b, [Out] TVal c) where TVal : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x8DF70E0", Offset = "0x8DF5EE0", VA = "0x188DF70E0")]
		[CompilerGenerated]
		internal static int HDZUSAMWRQG(Type a)
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
		[Cpp2IlInjected.Address(RVA = "0x8DF40E0", Offset = "0x8DF2EE0", VA = "0x188DF40E0")]
		public UserFriendlyErrorInfo(string userFriendlyMessage, ErrorCode errorCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4040", Offset = "0x8DF2E40", VA = "0x188DF4040")]
		public string KPLEYOQOSSQ()
		{
			return null;
		}
	}
}
namespace RecRoom.RoomLoading.RoomOperation
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public class XUVXRPWZBOR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private readonly AWJSQTHCCJW GHRQWLOSSBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private string PDSBERPULTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private long? LDRJUYJLMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private long? IOLPLCRLSEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private long? CUZIVXAEWZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private string TMPXQJDCNSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private RoomOperationState INOHIAUWAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private long? KGPFEIEBXAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private bool QCPKZCIUDGP;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public string SQQVDATLMTQ
		{
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public long ZFPMDMWKXXO
		{
			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x8DF5BA0", Offset = "0x8DF49A0", VA = "0x188DF5BA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public long TCYPGDSHSRA
		{
			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x8DF5AE0", Offset = "0x8DF48E0", VA = "0x188DF5AE0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public long VQXWXXLTMSD
		{
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x8DF68A0", Offset = "0x8DF56A0", VA = "0x188DF68A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public string HVKSZLRNXHM
		{
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x8DF6060", Offset = "0x8DF4E60", VA = "0x188DF6060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public RoomOperationState OTYRAROFYAH
		{
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0xF1B7E0", Offset = "0xF1A5E0", VA = "0x180F1B7E0")]
			get
			{
				return default(RoomOperationState);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0x8DF5F70", Offset = "0x8DF4D70", VA = "0x188DF5F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public long KJYQZHCKKDT
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0x8DF5B40", Offset = "0x8DF4940", VA = "0x188DF5B40")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6900", Offset = "0x8DF5700", VA = "0x188DF6900")]
		[UnityEngine.Scripting.Preserve]
		public XUVXRPWZBOR([Inject(null)] AWJSQTHCCJW playerPreferences)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x8DF65B0", Offset = "0x8DF53B0", VA = "0x188DF65B0")]
		private void METYXQNJFLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x8DF60A0", Offset = "0x8DF4EA0", VA = "0x188DF60A0")]
		public void JLZVRDOCTKC(long a, long b, [Optional] long? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6800", Offset = "0x8DF5600", VA = "0x188DF6800")]
		public void OGZPSZJCFWI(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6530", Offset = "0x8DF5330", VA = "0x188DF6530")]
		public void KCTKQSIRFUV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5C00", Offset = "0x8DF4A00", VA = "0x188DF5C00")]
		public void EWUDMYBJZEQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	internal class IRZBFTNHIIP : IDisposable
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
		private sealed class RVDZJLMSLEQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public FJZTCZTAMBW FRKMKTHXEDK;

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public RVDZJLMSLEQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x8DE2E50", Offset = "0x8DE1C50", VA = "0x188DE2E50")]
			internal FJZTCZTAMBW JBCRCHMSVXH(byte[] a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000110")]
		[CompilerGenerated]
		private sealed class KPWYJSNCUCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public Func<Guid, bool> AHUQIGKCZRA;

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public KPWYJSNCUCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x8DDF610", Offset = "0x8DDE410", VA = "0x188DDF610")]
			internal object OYTMSNDZNDA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x8DDF550", Offset = "0x8DDE350", VA = "0x188DDF550")]
			internal bool ESGLVRQQNGQ(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000111")]
		[CompilerGenerated]
		private sealed class QJGTDFDRLXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Func<Guid, bool> JSLBOFNRDGR;

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QJGTDFDRLXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x8DE0B20", Offset = "0x8DDF920", VA = "0x188DE0B20")]
			internal object ZASRCIZNXUM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[CompilerGenerated]
		private sealed class MALXDQDZUBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Guid JKRGDKRMJLY;

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public MALXDQDZUBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x8DDF830", Offset = "0x8DDE630", VA = "0x188DDF830")]
			internal object XAHZWLYBNXQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000113")]
		[CompilerGenerated]
		private sealed class QMPXKGRKTPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Guid JKRGDKRMJLY;

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QMPXKGRKTPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0x8DE0B80", Offset = "0x8DDF980", VA = "0x188DE0B80")]
			internal object IWWCTBFVVNL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000114")]
		[CompilerGenerated]
		private sealed class PJDQDKVCUJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public IRZBFTNHIIP WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			public string SVWBHPEQHWM;

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public PJDQDKVCUJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0x8DE0370", Offset = "0x8DDF170", VA = "0x188DE0370")]
			internal object MKBTMFXGKQF()
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
			public IRZBFTNHIIP <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5314390", Offset = "0x5313190", VA = "0x185314390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(RVA = "0x513F360", Offset = "0x513E160", VA = "0x18513F360", Slot = "5")]
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
			public IRZBFTNHIIP <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8DE7360", Offset = "0x8DE6160", VA = "0x188DE7360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0x8DE7630", Offset = "0x8DE6430", VA = "0x188DE7630", Slot = "5")]
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
			public AsyncTaskMethodBuilder<FJZTCZTAMBW> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public FJZTCZTAMBW roomOperationMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public IRZBFTNHIIP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			private StackTimer<string>.XDYOTKRANGY <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private TaskAwaiter<VEURRDRAUAE.BufferedMessage<FJZTCZTAMBW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0x8DE7CF0", Offset = "0x8DE6AF0", VA = "0x188DE7CF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0x8DE8230", Offset = "0x8DE7030", VA = "0x188DE8230", Slot = "5")]
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
			public AsyncTaskMethodBuilder<VEURRDRAUAE.BufferedMessage<FJZTCZTAMBW>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public FJZTCZTAMBW roomOperationMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public IRZBFTNHIIP <>4__this;

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
			private TaskAwaiter<VEURRDRAUAE.BufferedMessage<FJZTCZTAMBW>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0x8DE7690", Offset = "0x8DE6490", VA = "0x188DE7690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x8DE7C80", Offset = "0x8DE6A80", VA = "0x188DE7C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private static readonly Guid OMHYPFHHVSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public readonly EKKWWDICQVS OWGPXQYHHAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private readonly VEURRDRAUAE BXKHFSKPOLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private readonly WWHPPCVYRNM FBPQEEAUUKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private readonly JKLWLBPNAMF RNSOFYLRLRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private bool VJLZJKYASLO;

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x8DDEBA0", Offset = "0x8DDD9A0", VA = "0x188DDEBA0")]
		public IRZBFTNHIIP(EKKWWDICQVS a, VEURRDRAUAE b, WWHPPCVYRNM c, JKLWLBPNAMF d, StackTimer<string>.XDYOTKRANGY e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x8DDDCE0", Offset = "0x8DDCAE0", VA = "0x188DDDCE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x8DDE060", Offset = "0x8DDCE60", VA = "0x188DDE060")]
		public void GUMVLVPVBKW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x8DDE180", Offset = "0x8DDCF80", VA = "0x188DDE180")]
		public void IXIVYTHEDPX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x8DDDBA0", Offset = "0x8DDC9A0", VA = "0x188DDDBA0")]
		public void BUGPLSLRDMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x8DDE390", Offset = "0x8DDD190", VA = "0x188DDE390")]
		[AsyncStateMachine(typeof(<MasterSendAllReceive>d__11))]
		internal Task<FJZTCZTAMBW> MEBGHGBWZUL(StackTimer<string>.XDYOTKRANGY a, FJZTCZTAMBW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x3996080", Offset = "0x3994E80", VA = "0x183996080")]
		private static byte[] FHLXTSURKOU<a>(a a) where a : IMessage<a>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x3995C10", Offset = "0x3994A10", VA = "0x183995C10")]
		private static b CAKJVQTWSGZ<b>(MessageParser<b> a, byte[] b, b c) where b : IMessage<b>
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x8DDE600", Offset = "0x8DDD400", VA = "0x188DDE600")]
		[AsyncStateMachine(typeof(<MasterSendAllReceiveBufferedMessage>d__14))]
		private Task<VEURRDRAUAE.BufferedMessage<FJZTCZTAMBW>> RVQQZFVPCCP(FJZTCZTAMBW a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x39961E0", Offset = "0x3994FE0", VA = "0x1839961E0")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__15<>))]
		internal Task<c> XTXOZYBKMCA<c>(CancellationToken a, Func<CancellationToken, Task<c>> b, int c = 3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x8DDEA10", Offset = "0x8DDD810", VA = "0x188DDEA10")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__16))]
		internal Task XTXOZYBKMCA(CancellationToken a, Func<CancellationToken, Task> b, int c = 3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x8DDDCF0", Offset = "0x8DDCAF0", VA = "0x188DDDCF0")]
		public RoomUploadLogic FHSGMIJBEVL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x8DDDC60", Offset = "0x8DDCA60", VA = "0x188DDDC60")]
		public QPYRZTNSOAK DKDVALALPMO([Optional] EWFSFOBQSTJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x8DDDE70", Offset = "0x8DDCC70", VA = "0x188DDDE70")]
		public CPMHLDYVALD GJOBZCETOGV([Optional] Log? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x8DDE740", Offset = "0x8DDD540", VA = "0x188DDE740")]
		public void RWFRXZAKGES(Func<Guid, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x8DDDD60", Offset = "0x8DDCB60", VA = "0x188DDDD60")]
		public void GFKEURSLKYQ(Func<Guid, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x8DDE890", Offset = "0x8DDD690", VA = "0x188DDE890")]
		public Guid VTDEYGGHQJY()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8DDE4F0", Offset = "0x8DDD2F0", VA = "0x188DDE4F0")]
		public void MSRQEFOFJQH(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x8DDDA70", Offset = "0x8DDC870", VA = "0x188DDDA70")]
		public void ADKBUMVZKMD(FJZTCZTAMBW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x8DDE290", Offset = "0x8DDD090", VA = "0x188DDE290")]
		public void Log(string stepMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x3996480", Offset = "0x3995280", VA = "0x183996480")]
		private d YQHETIODYRN<d>(d a) where d : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x8DDE240", Offset = "0x8DDD040", VA = "0x188DDE240")]
		public void JHHFGCWLDRC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x3995D40", Offset = "0x3994B40", VA = "0x183995D40")]
		[CompilerGenerated]
		internal static string DOHORAZQRKD<e>(byte[] a, int b = 15, <>c__DisplayClass13_0<e> c) where e : IMessage<e>
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	internal sealed class InitialRoomLoadOperation : EKKWWDICQVS
	{
		[Cpp2IlInjected.Token(Token = "0x200011A")]
		[CompilerGenerated]
		private sealed class MVKUZKRYUYD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			public PlayerPresence GVHWMHVXJMS;

			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public MVKUZKRYUYD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x8DDFBE0", Offset = "0x8DDE9E0", VA = "0x188DDFBE0")]
			internal object UBDBQIOUYCM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011B")]
		[CompilerGenerated]
		private sealed class ZRSJAVAQQNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			public Guid ETHLIPBIQVX;

			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZRSJAVAQQNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x8DF7FA0", Offset = "0x8DF6DA0", VA = "0x188DF7FA0")]
			internal object IQMCBQJUTBF()
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
			[Cpp2IlInjected.Address(RVA = "0x8DE67E0", Offset = "0x8DE55E0", VA = "0x188DE67E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x8DE6F80", Offset = "0x8DE5D80", VA = "0x188DE6F80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8DE6FE0", Offset = "0x8DE5DE0", VA = "0x188DE6FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x8DE72F0", Offset = "0x8DE60F0", VA = "0x188DE72F0", Slot = "5")]
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
			public IRZBFTNHIIP operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			private PlayerPresence <presence>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			private QPYRZTNSOAK <loadLogic>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			private TaskAwaiter<Scene> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			private TaskAwaiter<FVEJJEHJCGN> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x8DEC0C0", Offset = "0x8DEAEC0", VA = "0x188DEC0C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x8DECFC0", Offset = "0x8DEBDC0", VA = "0x188DECFC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private static readonly Log XQOIFOOUJRB;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private static readonly Log FKPHWVCTQDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private readonly RoomLoadRequestPayload FLSESJQYKZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private readonly RoomInstance IBZAXKWOOPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private readonly EWFSFOBQSTJ HJLYHAYZKSL;

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF3B0", Offset = "0x8DDE1B0", VA = "0x188DDF3B0")]
		public InitialRoomLoadOperation(RoomLoadRequestPayload initialRoomLoadPayload, RoomInstance originalTargetRoomInstance, Guid operationId, ZVTYJEOYACF roomManager, WAMQFEAEZXB operationPauseToken, EWFSFOBQSTJ preloadContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x8DDEEB0", Offset = "0x8DDDCB0", VA = "0x188DDEEB0", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__8))]
		protected override Task QPRQXCMTESY(IRZBFTNHIIP a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x8DDEDB0", Offset = "0x8DDDBB0", VA = "0x188DDEDB0")]
		[AsyncStateMachine(typeof(<EnableDisableObjectModel>d__9))]
		private Task EnableDisableObjectModel(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF000", Offset = "0x8DDDE00", VA = "0x188DDF000")]
		[AsyncStateMachine(typeof(<GetSubroomSaveOMVersion>d__10))]
		private Task<int> SLELKBNYWUN(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF110", Offset = "0x8DDDF10", VA = "0x188DDF110")]
		private PlayerPresence XPVUNSOTRZS()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	internal class TQIAVOAERFN : EKKWWDICQVS
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
			public TQIAVOAERFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public IRZBFTNHIIP operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			private StackTimer<string>.XDYOTKRANGY <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x8DED020", Offset = "0x8DEBE20", VA = "0x188DED020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x8DED9D0", Offset = "0x8DEC7D0", VA = "0x188DED9D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private readonly int AGQUMAEYBYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private readonly JFLMODKHJZH SZRSGEQBBIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public readonly long VOQDDKMAYSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public readonly long CGMYETVQDIF;

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public SaveSubRoomResponseDTO VPAMEKKEXNH
		{
			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7B00", Offset = "0xAC6900", VA = "0x180AC7B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0xAC81D0", Offset = "0xAC6FD0", VA = "0x180AC81D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5420", Offset = "0x8DE4220", VA = "0x188DE5420")]
		public TQIAVOAERFN(Guid a, ZVTYJEOYACF b, WAMQFEAEZXB c, int d, JFLMODKHJZH e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5300", Offset = "0x8DE4100", VA = "0x188DE5300", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__9))]
		protected override Task QPRQXCMTESY(IRZBFTNHIIP a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	internal abstract class MVAZLBBJAIB : EKKWWDICQVS
	{
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[CompilerGenerated]
		private sealed class URZEQUFXAGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public MVAZLBBJAIB WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public IDisposable GYNQFWHOJTR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public AHFXFAHTCGR GOUTEJWQQNS;

			[Cpp2IlInjected.Token(Token = "0x6000525")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public URZEQUFXAGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0x8DF3E60", Offset = "0x8DF2C60", VA = "0x188DF3E60")]
			internal Task ORLHIVJJOEQ(StackTimer<string>.XDYOTKRANGY a, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x8DF3EA0", Offset = "0x8DF2CA0", VA = "0x188DF3EA0")]
			internal object ORQOGCDGXPZ()
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
			public StackTimer<string>.XDYOTKRANGY timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public IDisposable freezePlayerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public AHFXFAHTCGR playerDespawn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public MVAZLBBJAIB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			private StackTimer<string>.XDYOTKRANGY <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x8DE92D0", Offset = "0x8DE80D0", VA = "0x188DE92D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0x8DE9890", Offset = "0x8DE8690", VA = "0x188DE9890", Slot = "5")]
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
			public MVAZLBBJAIB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			public IRZBFTNHIIP operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			private URZEQUFXAGP <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x8DE98F0", Offset = "0x8DE86F0", VA = "0x188DE98F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA580", Offset = "0x8DE9380", VA = "0x188DEA580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFB90", Offset = "0x8DDE990", VA = "0x188DDFB90")]
		public MVAZLBBJAIB(Guid a, ZVTYJEOYACF b, WAMQFEAEZXB c, string d, RequestOperationType e, bool f = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF8A0", Offset = "0x8DDE6A0", VA = "0x188DDF8A0", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__2))]
		protected override Task QPRQXCMTESY(IRZBFTNHIIP a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract Task SOBBDEUNCQR(IRZBFTNHIIP a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF9E0", Offset = "0x8DDE7E0", VA = "0x188DDF9E0")]
		[AsyncStateMachine(typeof(<RespawnPlayer>d__4))]
		private Task YPDZDHGPZPG(IDisposable a, AHFXFAHTCGR b, StackTimer<string>.XDYOTKRANGY c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	internal class QTZMACZYJGH : EKKWWDICQVS
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
			public QTZMACZYJGH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public IRZBFTNHIIP operationContext;

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
			[Cpp2IlInjected.Address(RVA = "0x8DEA640", Offset = "0x8DE9440", VA = "0x188DEA640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0x8DEABD0", Offset = "0x8DE99D0", VA = "0x188DEABD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private readonly AutosaveType UOAQWJAFGSF;

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2C70", Offset = "0x8DE1A70", VA = "0x188DE2C70")]
		public QTZMACZYJGH(Guid a, ZVTYJEOYACF b, WAMQFEAEZXB c, AutosaveType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2A70", Offset = "0x8DE1870", VA = "0x188DE2A70", Slot = "6")]
		protected override string JIEZPFPRZNX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2B50", Offset = "0x8DE1950", VA = "0x188DE2B50", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__3))]
		protected override Task QPRQXCMTESY(IRZBFTNHIIP a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	internal abstract class EKKWWDICQVS : EQHDPAIGMIF
	{
		[Cpp2IlInjected.Token(Token = "0x2000128")]
		public delegate Task PostOperationTaskBuilder(StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000129")]
		[CompilerGenerated]
		private sealed class UEZIPMBRLCS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public StackTimer<string>.XDYOTKRANGY ZGEZJXWJWRG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public EKKWWDICQVS WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public UEZIPMBRLCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0x8DF3760", Offset = "0x8DF2560", VA = "0x188DF3760")]
			internal Task OXHODTCMJLF(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012A")]
		[CompilerGenerated]
		private sealed class UFEPMSVOUOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public Exception DRNNHSFOJIW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public UEZIPMBRLCS YLNIYCOGBOE;

			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public UFEPMSVOUOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x8DF3890", Offset = "0x8DF2690", VA = "0x188DF3890")]
			internal object OXMVAZWJSWO()
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
			[Cpp2IlInjected.Address(RVA = "0x8DE5CE0", Offset = "0x8DE4AE0", VA = "0x188DE5CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x8DE6780", Offset = "0x8DE5580", VA = "0x188DE6780", Slot = "5")]
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
			public EKKWWDICQVS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public Func<EKKWWDICQVS, StackTimer<string>.XDYOTKRANGY, IRZBFTNHIIP> operationContextBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private UEZIPMBRLCS <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			private bool <success>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			private IRZBFTNHIIP <operationContext>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private TaskAwaiter<FJZTCZTAMBW> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x8DEFD00", Offset = "0x8DEEB00", VA = "0x188DEFD00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054D")]
			[Cpp2IlInjected.Address(RVA = "0x8DF0F40", Offset = "0x8DEFD40", VA = "0x188DF0F40", Slot = "5")]
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
			public EKKWWDICQVS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0x8DEED70", Offset = "0x8DEDB70", VA = "0x188DEED70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054F")]
			[Cpp2IlInjected.Address(RVA = "0x8DEF0D0", Offset = "0x8DEDED0", VA = "0x188DEF0D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public readonly Guid ZLKFLBCSCQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public readonly ByteString NILLMLRGVBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public readonly WAMQFEAEZXB WAMQFEAEZXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		protected readonly string QTADLYSGWTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private readonly ZVTYJEOYACF SLBUPCNYZAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private readonly bool OCAMTWFPZTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private readonly Queue<PostOperationTaskBuilder> BWZXUYMVGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private readonly LKWAXVIJRBY IHDXDTVEDJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private readonly RequestOperationType VEXVJLITQNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private bool FDEHKAVAREI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public RoomOperationState IYUITHTVQFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public RoomOperationState OUFDOBKADZM;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public ZVTYJEOYACF XBWIUWVJWGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public OEJGLDFIKZO SNEHNJXCVIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x8DDCE30", Offset = "0x8DDBC30", VA = "0x188DDCE30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public JNHZBTHIEBV SLRMBOKTDYE
		{
			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x8DDD390", Offset = "0x8DDC190", VA = "0x188DDD390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public ZZSHRDKMGMU YWWFJNZECIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0x8DDD550", Offset = "0x8DDC350", VA = "0x188DDD550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event ProgressUpdate HGAJECVLNAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0x8DDD530", Offset = "0x8DDC330", VA = "0x188DDD530", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x8DDCDD0", Offset = "0x8DDBBD0", VA = "0x188DDCDD0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x8DDD7E0", Offset = "0x8DDC5E0", VA = "0x188DDD7E0")]
		protected EKKWWDICQVS(Guid a, ZVTYJEOYACF b, WAMQFEAEZXB c, string d, RequestOperationType e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x8DDCDF0", Offset = "0x8DDBBF0", VA = "0x188DDCDF0", Slot = "6")]
		protected virtual string JIEZPFPRZNX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x8DDD780", Offset = "0x8DDC580", VA = "0x188DDD780")]
		public void WZVEDVWPCIH(PostOperationTaskBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x8DDCDB0", Offset = "0x8DDBBB0", VA = "0x188DDCDB0")]
		protected void AHVGYSTBTRA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x8DDD3E0", Offset = "0x8DDC1E0", VA = "0x188DDD3E0")]
		[AsyncStateMachine(typeof(<Run>d__30))]
		public Task Run(CancellationToken cancellationToken, StackTimer<string>.XDYOTKRANGY stackTimer, [Optional] Func<EKKWWDICQVS, StackTimer<string>.XDYOTKRANGY, IRZBFTNHIIP> operationContextBuilder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x8DDD5D0", Offset = "0x8DDC3D0", VA = "0x188DDD5D0")]
		[AsyncStateMachine(typeof(<DriverCombinedTask>d__31))]
		private static Task TJQCGBFZSPJ(Func<CancellationToken, Task> a, Func<CancellationToken, Task> b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x8DDD210", Offset = "0x8DDC010", VA = "0x188DDD210")]
		private void QHOFUTRXLBG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x8DDCE80", Offset = "0x8DDBC80", VA = "0x188DDCE80")]
		private void LVHXFFRKOSD(IRZBFTNHIIP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract Task QPRQXCMTESY(IRZBFTNHIIP a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x8DDCC90", Offset = "0x8DDBA90", VA = "0x188DDCC90")]
		[AsyncStateMachine(typeof(<RunPostOperationTasks>d__35))]
		private Task AFXUIVGUQUH(StackTimer<string>.XDYOTKRANGY a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x8DDD700", Offset = "0x8DDC500", VA = "0x188DDD700")]
		public FJZTCZTAMBW WUERRPEBGDQ(MessageKind a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x8DDD0A0", Offset = "0x8DDBEA0", VA = "0x188DDD0A0")]
		[CompilerGenerated]
		private Task LYKBNYTXSZO(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x8DDD190", Offset = "0x8DDBF90", VA = "0x188DDD190")]
		[CompilerGenerated]
		private object LYZWFTBPVHP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	internal sealed class DOLLKKPJJJA : MVAZLBBJAIB
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
			public DOLLKKPJJJA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public IRZBFTNHIIP operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private RoomEvent <roomEvent>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			private QPYRZTNSOAK <loadLogic>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x8DF0FA0", Offset = "0x8DEFDA0", VA = "0x188DF0FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x8DF1700", Offset = "0x8DF0500", VA = "0x188DF1700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private readonly RoomLoadRequestPayload VGBOURROGUF;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x8DDBB00", Offset = "0x8DDA900", VA = "0x188DDBB00")]
		public DOLLKKPJJJA(Guid a, ZVTYJEOYACF b, RoomLoadRequestPayload c, WAMQFEAEZXB d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB9B0", Offset = "0x8DDA7B0", VA = "0x188DDB9B0", Slot = "8")]
		[AsyncStateMachine(typeof(<RunWhilePlayerDespawnedAsync>d__2))]
		protected override Task SOBBDEUNCQR(IRZBFTNHIIP a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	internal class LUYNVTAZTOC : EKKWWDICQVS
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
			public LUYNVTAZTOC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			public IRZBFTNHIIP operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			private TaskAwaiter<RoomSerializedData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA1D0", Offset = "0x8DE8FD0", VA = "0x188DEA1D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA5E0", Offset = "0x8DE93E0", VA = "0x188DEA5E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private readonly string WTVWVHWXLBU;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF780", Offset = "0x8DDE580", VA = "0x188DDF780")]
		public LUYNVTAZTOC(Guid a, ZVTYJEOYACF b, WAMQFEAEZXB c, string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF670", Offset = "0x8DDE470", VA = "0x188DDF670", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__2))]
		protected override Task QPRQXCMTESY(IRZBFTNHIIP a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	internal class RoomSaveToRecNetOperation : MVAZLBBJAIB
	{
		[Cpp2IlInjected.Token(Token = "0x2000133")]
		[CompilerGenerated]
		private sealed class QFVEKDSMASK
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
				public AsyncTaskMethodBuilder<FJZTCZTAMBW> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40004B1")]
				public QFVEKDSMASK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40004B2")]
				public CancellationToken masterLockedCodeBlockCancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40004B3")]
				private TaskAwaiter<RoomSerializedData> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40004B4")]
				private TaskAwaiter<FJZTCZTAMBW> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x8DF2D70", Offset = "0x8DF1B70", VA = "0x188DF2D70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x8DF3250", Offset = "0x8DF2050", VA = "0x188DF3250", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			public RoomSaveToRecNetOperation WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public CPMHLDYVALD YWUOEKJXQTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public long LBPVDIFAQXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004AA")]
			public RoomSaveOptions PWQYONMEOZL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004AB")]
			public RoomUploadLogic FASHUTKFCNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004AC")]
			public long MCOMOMBGAXW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004AD")]
			public RoomSaveAnalyticsInfo XYOAJHLCRIT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004AE")]
			public StackTimer<string>.XDYOTKRANGY ABYCHQRUDKW;

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QFVEKDSMASK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0x8DE0A00", Offset = "0x8DDF800", VA = "0x188DE0A00")]
			[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
			internal Task<FJZTCZTAMBW> XFBNIODLHJZ(CancellationToken a)
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
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B9")]
			public IRZBFTNHIIP operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			private QFVEKDSMASK <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004BC")]
			private RoomEvent <roomEvent>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004BD")]
			private QPYRZTNSOAK <loadLogic>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40004BE")]
			private FJZTCZTAMBW <saveReloadMessage>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			private TaskAwaiter<FJZTCZTAMBW> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x8DF1760", Offset = "0x8DF0560", VA = "0x188DF1760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x8DF25B0", Offset = "0x8DF13B0", VA = "0x188DF25B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private static readonly Log XQOIFOOUJRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private readonly int HVMIEXWRSYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		[CanBeNull]
		private readonly RoomSaveRequestPayload XGJQBPYPAKE;

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5040", Offset = "0x8DE3E40", VA = "0x188DE5040")]
		public RoomSaveToRecNetOperation(Guid operationId, ZVTYJEOYACF roomManager, int savingPlayerAccountId, RoomSaveRequestPayload roomSaveRequestPayload, WAMQFEAEZXB operationPauseToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4E50", Offset = "0x8DE3C50", VA = "0x188DE4E50", Slot = "8")]
		[AsyncStateMachine(typeof(<RunWhilePlayerDespawnedAsync>d__5))]
		protected override Task SOBBDEUNCQR(IRZBFTNHIIP a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4D60", Offset = "0x8DE3B60", VA = "0x188DE4D60")]
		private void EWDKXXNENNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4B90", Offset = "0x8DE3990", VA = "0x188DE4B90")]
		private void EPYPAGVXTPD(StackTimer<string>.XDYOTKRANGY a, RoomEvent b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	internal class SYTSLLHFUJL : EKKWWDICQVS
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
			public SYTSLLHFUJL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C7")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C8")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

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
			private NMFGCGLVGPZ<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

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
			[Cpp2IlInjected.Address(RVA = "0x8DEAC30", Offset = "0x8DE9A30", VA = "0x188DEAC30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x8DEC060", Offset = "0x8DEAE60", VA = "0x188DEC060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private readonly int HVMIEXWRSYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private readonly RoomSaveRequestPayload XGJQBPYPAKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private Func<RoomSerializedData, RoomSerializedData> UPTYJCAFRVH;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5240", Offset = "0x8DE4040", VA = "0x188DE5240")]
		public SYTSLLHFUJL(Guid a, ZVTYJEOYACF b, int c, RoomSaveRequestPayload d, Func<RoomSerializedData, RoomSerializedData> e, WAMQFEAEZXB f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5110", Offset = "0x8DE3F10", VA = "0x188DE5110", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__4))]
		protected override Task QPRQXCMTESY(IRZBFTNHIIP a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	internal abstract class NLXAQTNBBWS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public readonly EKKWWDICQVS OWGPXQYHHAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public readonly IRZBFTNHIIP IRZBFTNHIIP;

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public OEJGLDFIKZO SNEHNJXCVIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x8DDFD20", Offset = "0x8DDEB20", VA = "0x188DDFD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public ZZSHRDKMGMU YWWFJNZECIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x8DDFE80", Offset = "0x8DDEC80", VA = "0x188DDFE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFF10", Offset = "0x8DDED10", VA = "0x188DDFF10")]
		protected NLXAQTNBBWS(IRZBFTNHIIP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFD70", Offset = "0x8DDEB70", VA = "0x188DDFD70")]
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
		[Cpp2IlInjected.Address(RVA = "0x8DDBBD0", Offset = "0x8DDA9D0", VA = "0x188DDBBD0")]
		public static DeserializationHandlerLists Get(OEJGLDFIKZO callbacks, RoomOperationState operationState, UREAGQBAIUQ deserializationData)
		{
			return default(DeserializationHandlerLists);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	internal struct LogRoomLoadMetrics
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0")]
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
		public bool SLPBYIXAITB
		{
			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x8DE2F30", Offset = "0x8DE1D30", VA = "0x188DE2F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2FC0", Offset = "0x8DE1DC0", VA = "0x188DE2FC0")]
		public RoomLoadDetails(RoomDetailsDTO roomDetails, SubRoomDTO subRoom, Guid? unityAssetId, IReadOnlyList<BakedUnitySubAssetDTO> unitySubAssets, IReadOnlyCollection<BakedUnitySubAssetDTO> referencedUnityAssets, FilenameWithHash superRoomData, FilenameWithHash subRoomData, RoomLoadDTO roomLoad)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	internal struct RoomLoadLifetime : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private readonly IRZBFTNHIIP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private readonly Guid sliceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private bool success;

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3340", Offset = "0x8DE2140", VA = "0x188DE3340")]
		public static RoomLoadLifetime VTDEYGGHQJY(IRZBFTNHIIP a)
		{
			return default(RoomLoadLifetime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x1398AC0", Offset = "0x13978C0", VA = "0x181398AC0")]
		public void YNWBUOVBWPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3070", Offset = "0x8DE1E70", VA = "0x188DE3070", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3370", Offset = "0x8DE2170", VA = "0x188DE3370")]
		private RoomLoadLifetime(IRZBFTNHIIP operationContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3120", Offset = "0x8DE1F20", VA = "0x188DE3120")]
		private void MSRQEFOFJQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3080", Offset = "0x8DE1E80", VA = "0x188DE3080")]
		private Func<Guid, bool> FMIGOIZGBPO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	internal class QPYRZTNSOAK : NLXAQTNBBWS, EQHDPAIGMIF
	{
		[Cpp2IlInjected.Token(Token = "0x200013F")]
		public delegate Task<RoomOperationState> RoomLoadFunction(UREAGQBAIUQ data, HFKTNQXOSAI yielder, LKWAXVIJRBY progressTracker, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000141")]
		[CompilerGenerated]
		private sealed class VCNKWXLRMEL
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
				public VCNKWXLRMEL <>4__this;

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
				[Cpp2IlInjected.Address(RVA = "0x8E0D410", Offset = "0x8E0C210", VA = "0x188E0D410", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0x8E0DCD0", Offset = "0x8E0CAD0", VA = "0x188E0DCD0", Slot = "5")]
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
				public AsyncTaskMethodBuilder<UREAGQBAIUQ> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000505")]
				public VCNKWXLRMEL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000506")]
				public CancellationToken innerCancellation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000507")]
				private UREAGQBAIUQ <innerPhaseArgs>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000508")]
				private TaskAwaiter<RoomOperationState> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000509")]
				private TaskAwaiter<UREAGQBAIUQ> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60005AF")]
				[Cpp2IlInjected.Address(RVA = "0x8E0DD40", Offset = "0x8E0CB40", VA = "0x188E0DD40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x8E0E380", Offset = "0x8E0D180", VA = "0x188E0E380", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public QPYRZTNSOAK WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public RoomLoadRequestPayload LTDBLSPDUBW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public LKWAXVIJRBY UZDNKXPCFMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public StackTimer<string>.XDYOTKRANGY ABYCHQRUDKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public LKWAXVIJRBY YKTVLPVRZLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			public RoomLoadDetails UZOZEZLFZLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			public LKWAXVIJRBY HLUKSYEXXDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			public UREAGQBAIUQ ETWEOVQVXEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public RecNet.Core.OnDownloadProgressDelegate CCAWJGBXKTX;

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public VCNKWXLRMEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x8E100A0", Offset = "0x8E0EEA0", VA = "0x188E100A0")]
			[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
			internal Task<RoomLoadDetails> LVCMOCTQFIS(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x8E0FF80", Offset = "0x8E0ED80", VA = "0x188E0FF80")]
			[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
			internal Task<UREAGQBAIUQ> LURYTPFVMMA(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0x8E10270", Offset = "0x8E0F070", VA = "0x188E10270")]
			internal void LVXODDVFRCC(long a, long b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x8E10230", Offset = "0x8E0F030", VA = "0x188E10230")]
			internal Task LVSHFXBIHQT(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x8E101F0", Offset = "0x8E0EFF0", VA = "0x188E101F0")]
			internal Task LVNAIQHKYFK(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000144")]
		[CompilerGenerated]
		private sealed class LFZFZQLQIGX
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
				public LFZFZQLQIGX <>4__this;

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
				[Cpp2IlInjected.Address(RVA = "0x8E0E3F0", Offset = "0x8E0D1F0", VA = "0x188E0E3F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B4")]
				[Cpp2IlInjected.Address(RVA = "0x8E0E8A0", Offset = "0x8E0D6A0", VA = "0x188E0E8A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			public QPYRZTNSOAK WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400050B")]
			public RoomLoadFunction PJDURUAGOZA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public UREAGQBAIUQ UZOZEZLFZLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public HFKTNQXOSAI BEIHEHKSGGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public LKWAXVIJRBY DBJCKRYMMSA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			public StackTimer<string>.XDYOTKRANGY ABYCHQRUDKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public RoomOperationState JLYMCIFKSDQ;

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public LFZFZQLQIGX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0x8DFAFD0", Offset = "0x8DF9DD0", VA = "0x188DFAFD0")]
			[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
			internal Task<RoomOperationState> VRGFMCKMQUV(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000146")]
		[CompilerGenerated]
		private sealed class PZBIRBWFHJR
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
				public PZBIRBWFHJR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400051C")]
				public UREAGQBAIUQ data;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400051D")]
				public LKWAXVIJRBY progressTracker;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400051E")]
				public StackTimer<string>.XDYOTKRANGY stackTimer;

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
				[Cpp2IlInjected.Address(RVA = "0x8E0E910", Offset = "0x8E0D710", VA = "0x188E0E910", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B8")]
				[Cpp2IlInjected.Address(RVA = "0x8E0F3E0", Offset = "0x8E0E1E0", VA = "0x188E0F3E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			public QPYRZTNSOAK WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			public RICTBNCIKVM OZDQDXUFZCN;

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public PZBIRBWFHJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x8DFBE00", Offset = "0x8DFAC00", VA = "0x188DFBE00")]
			[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
			internal Task<RoomOperationState> ABPTONCPTIC(UREAGQBAIUQ a, HFKTNQXOSAI b, LKWAXVIJRBY c, StackTimer<string>.XDYOTKRANGY d, CancellationToken e)
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
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x8DFC190", Offset = "0x8DFAF90", VA = "0x188DFC190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x8DFC3B0", Offset = "0x8DFB1B0", VA = "0x188DFC3B0", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400052B")]
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			public LKWAXVIJRBY progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public HFKTNQXOSAI timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			private StackTimer<string>.XDYOTKRANGY <deserializeAllObjectsTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0x8DFCAA0", Offset = "0x8DFB8A0", VA = "0x188DFCAA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x8DFDBB0", Offset = "0x8DFC9B0", VA = "0x188DFDBB0", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			public LKWAXVIJRBY progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private StackTimer<string>.XDYOTKRANGY <deserializeAllObjectsTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400053C")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x8DFC410", Offset = "0x8DFB210", VA = "0x188DFC410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x8DFCA30", Offset = "0x8DFB830", VA = "0x188DFCA30", Slot = "5")]
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
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

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
			[Cpp2IlInjected.Address(RVA = "0x8DFDC20", Offset = "0x8DFCA20", VA = "0x188DFDC20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x8DFDF10", Offset = "0x8DFCD10", VA = "0x188DFDF10", Slot = "5")]
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
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0x8DFDF70", Offset = "0x8DFCD70", VA = "0x188DFDF70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x8DFE370", Offset = "0x8DFD170", VA = "0x188DFE370", Slot = "5")]
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
			public AsyncTaskMethodBuilder<FJZTCZTAMBW> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private StackTimer<string>.XDYOTKRANGY <syncTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			private TaskAwaiter<FJZTCZTAMBW> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x8DFFFA0", Offset = "0x8DFEDA0", VA = "0x188DFFFA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x8E003D0", Offset = "0x8DFF1D0", VA = "0x188E003D0", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			public LKWAXVIJRBY progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			private StackTimer<string>.XDYOTKRANGY <legacyLoadRoomDataTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x8E00440", Offset = "0x8DFF240", VA = "0x188E00440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x8E00C80", Offset = "0x8DFFA80", VA = "0x188E00C80", Slot = "5")]
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
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			public CancellationToken externalCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			private VCNKWXLRMEL <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			private TaskAwaiter<RoomLoadDetails> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			private TaskAwaiter<UREAGQBAIUQ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x8E01200", Offset = "0x8E00000", VA = "0x188E01200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x8E01E40", Offset = "0x8E00C40", VA = "0x188E01E40", Slot = "5")]
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
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			private StackTimer<string>.XDYOTKRANGY <loadRoomLocalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x8E00CE0", Offset = "0x8DFFAE0", VA = "0x188E00CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x8E011A0", Offset = "0x8DFFFA0", VA = "0x188E011A0", Slot = "5")]
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
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			public RoomLoadFunction masterLockedCode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			public HFKTNQXOSAI timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000576")]
			public LKWAXVIJRBY progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

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
			[Cpp2IlInjected.Address(RVA = "0x8E01EA0", Offset = "0x8E00CA0", VA = "0x188E01EA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x8E023B0", Offset = "0x8E011B0", VA = "0x188E023B0", Slot = "5")]
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
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public LKWAXVIJRBY progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

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
			[Cpp2IlInjected.Address(RVA = "0x8E02420", Offset = "0x8E01220", VA = "0x188E02420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x8E02980", Offset = "0x8E01780", VA = "0x188E02980", Slot = "5")]
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
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			public RoomOperationState operationState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			public LKWAXVIJRBY progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400058A")]
			public UREAGQBAIUQ deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

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
			[Cpp2IlInjected.Address(RVA = "0x8E029E0", Offset = "0x8E017E0", VA = "0x188E029E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x8E02C30", Offset = "0x8E01A30", VA = "0x188E02C30", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public LKWAXVIJRBY progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			private StackTimer<string>.XDYOTKRANGY <destroyAndRebuildObjectsTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x8E02CA0", Offset = "0x8E01AA0", VA = "0x188E02CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x8E03C60", Offset = "0x8E02A60", VA = "0x188E03C60", Slot = "5")]
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
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			public UREAGQBAIUQ phaseArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			public LKWAXVIJRBY postDownloadProgress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005A1")]
			private TaskAwaiter<RoomOperationState> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			private HFKTNQXOSAI <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x8E03CD0", Offset = "0x8E02AD0", VA = "0x188E03CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x8E04B00", Offset = "0x8E03900", VA = "0x188E04B00", Slot = "5")]
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
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			public UREAGQBAIUQ phaseArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public LKWAXVIJRBY postDownloadProgress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			private PZBIRBWFHJR <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005AB")]
			private HFKTNQXOSAI <timedYielder>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005AC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005AD")]
			private TaskAwaiter<RoomOperationState> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x8E04B60", Offset = "0x8E03960", VA = "0x188E04B60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0x8E05970", Offset = "0x8E04770", VA = "0x188E05970", Slot = "5")]
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
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005B2")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005B3")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005B4")]
			private RoomLoadLifetime <lifetime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			private TaskAwaiter<FJZTCZTAMBW> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x8E0BA00", Offset = "0x8E0A800", VA = "0x188E0BA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x8E0C150", Offset = "0x8E0AF50", VA = "0x188E0C150", Slot = "5")]
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
			public QPYRZTNSOAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005BA")]
			public StackTimer<string>.XDYOTKRANGY timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005BB")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005BC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x8E0C1B0", Offset = "0x8E0AFB0", VA = "0x188E0C1B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x8E0C990", Offset = "0x8E0B790", VA = "0x188E0C990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private readonly Token ACAMMDWVNNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private readonly Token IZQGNJYFREB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private readonly XUVXRPWZBOR NOYYMXUYDBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private readonly TUJCUQQJKPP ATQOTJURZMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private readonly MoveToPhaseTask YEMCXEBBRYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private ProfilerCounterValue<int> OZLWUEETDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private readonly HTPVVHWXJXT CEUPTSLLCLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private readonly EWFSFOBQSTJ HJLYHAYZKSL;

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		private ZVTYJEOYACF XBWIUWVJWGT
		{
			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0x8DE1E30", Offset = "0x8DE0C30", VA = "0x188DE1E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event ProgressUpdate HGAJECVLNAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x8DE2650", Offset = "0x8DE1450", VA = "0x188DE2650", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0x8DE1510", Offset = "0x8DE0310", VA = "0x188DE1510", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE27B0", Offset = "0x8DE15B0", VA = "0x188DE27B0")]
		public QPYRZTNSOAK(IRZBFTNHIIP a, EWFSFOBQSTJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1A70", Offset = "0x8DE0870", VA = "0x188DE1A70")]
		[AsyncStateMachine(typeof(<SyncLoadRoom>d__17))]
		public Task HDNRLQEROTJ(RoomLoadRequestPayload a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE13B0", Offset = "0x8DE01B0", VA = "0x188DE13B0")]
		[AsyncStateMachine(typeof(<GetSyncedRoomLoadPayload>d__18))]
		private Task<FJZTCZTAMBW> EVGLECGNEUC(RoomLoadRequestPayload a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1690", Offset = "0x8DE0490", VA = "0x188DE1690")]
		[AsyncStateMachine(typeof(<LoadRoomLocalTimed>d__19))]
		private Task GQJUMLAXGFI(RoomLoadRequestPayload a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2290", Offset = "0x8DE1090", VA = "0x188DE2290")]
		[AsyncStateMachine(typeof(<LoadRoomLocal>d__20))]
		private Task LoadRoomLocal(RoomLoadRequestPayload request, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken externalCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0D70", Offset = "0x8DDFB70", VA = "0x188DE0D70")]
		[AsyncStateMachine(typeof(<RoomV1LoadLogic>d__21))]
		private Task CTQBYDFJESV(UREAGQBAIUQ a, LKWAXVIJRBY b, StackTimer<string>.XDYOTKRANGY c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1CE0", Offset = "0x8DE0AE0", VA = "0x188DE1CE0")]
		[AsyncStateMachine(typeof(<TriggerBigDataNetworkManager>d__22))]
		private Task HMCAKOYEFBW(StackTimer<string>.XDYOTKRANGY a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2140", Offset = "0x8DE0F40", VA = "0x188DE2140")]
		[AsyncStateMachine(typeof(<LegacyLoadRoomData>d__23))]
		private Task LegacyLoadRoomData(UREAGQBAIUQ data, LKWAXVIJRBY progressTracker, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x8DE17D0", Offset = "0x8DE05D0", VA = "0x188DE17D0")]
		[AsyncStateMachine(typeof(<RoomV1DestroyAndRebuildObjects>d__24))]
		private Task<RoomOperationState> GUFZOYSXOCP(UREAGQBAIUQ a, HFKTNQXOSAI b, LKWAXVIJRBY c, StackTimer<string>.XDYOTKRANGY d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1060", Offset = "0x8DDFE60", VA = "0x188DE1060")]
		[AsyncStateMachine(typeof(<DeserializeAllObjects>d__25))]
		private Task<RoomOperationState> DeserializeAllObjects(UREAGQBAIUQ data, HFKTNQXOSAI timedYielder, LKWAXVIJRBY progressTracker, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0BF0", Offset = "0x8DDF9F0", VA = "0x188DE0BF0")]
		[AsyncStateMachine(typeof(<MoveToPhase>d__26))]
		private Task<RoomOperationState> BHIMFJYZYPQ(RoomOperationState a, UREAGQBAIUQ b, LKWAXVIJRBY c, StackTimer<string>.XDYOTKRANGY d, CancellationToken e, bool f = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x8DE26C0", Offset = "0x8DE14C0", VA = "0x188DE26C0")]
		private bool XGQHFYOPDAV(UREAGQBAIUQ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x8DE23D0", Offset = "0x8DE11D0", VA = "0x188DE23D0")]
		[AsyncStateMachine(typeof(<MasterLockedPhaseChangeBlock>d__28))]
		protected Task<RoomOperationState> MasterLockedPhaseChangeBlock(UREAGQBAIUQ data, HFKTNQXOSAI timedYielder, LKWAXVIJRBY progressTracker, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken, RoomLoadFunction masterLockedCode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1FB0", Offset = "0x8DE0DB0", VA = "0x188DE1FB0")]
		[AsyncStateMachine(typeof(<MoveThroughRemainingPhases>d__29))]
		private Task LTXGAFCRMTH(UREAGQBAIUQ a, LKWAXVIJRBY b, StackTimer<string>.XDYOTKRANGY c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1010", Offset = "0x8DDFE10", VA = "0x188DE1010")]
		private void DJVTIHKEPVC(RoomOperationState a, LKWAXVIJRBY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1DF0", Offset = "0x8DE0BF0", VA = "0x188DE1DF0")]
		private void HTRQEWYECOJ(RoomOperationState a, [Out] RoomOperationState b, [Out] RoomOperationState c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1F70", Offset = "0x8DE0D70", VA = "0x188DE1F70")]
		private Task<RoomLoadDetails> KSZAXVOXDQQ(RoomLoadRequestPayload a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2100", Offset = "0x8DE0F00", VA = "0x188DE2100")]
		private Task<UREAGQBAIUQ> LXUKSHNAHEW(RoomLoadDetails a, RecNet.Core.OnDownloadProgressDelegate b, StackTimer<string>.XDYOTKRANGY c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1260", Offset = "0x8DE0060", VA = "0x188DE1260")]
		[AsyncStateMachine(typeof(<DestroyOldObjects>d__34))]
		private Task DestroyOldObjects(UREAGQBAIUQ data, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken, bool useCompletionMark = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1E60", Offset = "0x8DE0C60", VA = "0x188DE1E60")]
		[AsyncStateMachine(typeof(<CreateCV1Mappings>d__35))]
		private Task IGMRSNJFWGG(UREAGQBAIUQ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1230", Offset = "0x8DE0030", VA = "0x188DE1230")]
		private Task DeserializeSettings(UREAGQBAIUQ data, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1F50", Offset = "0x8DE0D50", VA = "0x188DE1F50")]
		private Task InstantiateObjects(UREAGQBAIUQ data, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2630", Offset = "0x8DE1430", VA = "0x188DE2630")]
		private Task PreDeserializeObjects(UREAGQBAIUQ data, HFKTNQXOSAI timedYielder, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1210", Offset = "0x8DE0010", VA = "0x188DE1210")]
		private Task DeserializeObjects(UREAGQBAIUQ data, HFKTNQXOSAI timedYielder, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x8DE11E0", Offset = "0x8DDFFE0", VA = "0x188DE11E0")]
		private static Task DeserializeConnectables(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2610", Offset = "0x8DE1410", VA = "0x188DE2610")]
		private Task PostDeserializeObjects(UREAGQBAIUQ data, HFKTNQXOSAI timedYielder, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x8DE11F0", Offset = "0x8DDFFF0", VA = "0x188DE11F0")]
		private Task DeserializeObjectsComplete(UREAGQBAIUQ data, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2670", Offset = "0x8DE1470", VA = "0x188DE2670")]
		private void TBRPBVNQKGN(RoomLoadRequestPayload a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2560", Offset = "0x8DE1360", VA = "0x188DE2560")]
		public void OVMMVTSNYBB(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		private static void BEHLIJAZCNU(RoomDetailsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0EC0", Offset = "0x8DDFCC0", VA = "0x188DE0EC0")]
		[AsyncStateMachine(typeof(<RoomV2LoadLogic>d__46))]
		private Task DFNQVSVKZVM(UREAGQBAIUQ a, LKWAXVIJRBY b, StackTimer<string>.XDYOTKRANGY c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1930", Offset = "0x8DE0730", VA = "0x188DE1930")]
		[AsyncStateMachine(typeof(<DestroyR1Objects>d__47))]
		private Task GYEZZYENWPQ(UREAGQBAIUQ a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1BC0", Offset = "0x8DE09C0", VA = "0x188DE1BC0")]
		private static SerializedDataWrapper HDYBEKTGWRR(UREAGQBAIUQ a)
		{
			return default(SerializedDataWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1530", Offset = "0x8DE0330", VA = "0x188DE1530")]
		[AsyncStateMachine(typeof(<DeserializeAllObjectsR2>d__49))]
		private Task<RoomOperationState> FOXNYIBMJPN(UREAGQBAIUQ a, HFKTNQXOSAI b, LKWAXVIJRBY c, StackTimer<string>.XDYOTKRANGY d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		private void TFAORBBPPKE(RoomOperationState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	internal struct CreateCV1MappingsTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private ZVTYJEOYACF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private UREAGQBAIUQ data;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		private OEJGLDFIKZO SNEHNJXCVIV
		{
			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x8DF8190", Offset = "0x8DF6F90", VA = "0x188DF8190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8400", Offset = "0x8DF7200", VA = "0x188DF8400")]
		public static Task Run(ZVTYJEOYACF roomManager, UREAGQBAIUQ data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x8DF81E0", Offset = "0x8DF6FE0", VA = "0x188DF81E0")]
		private void Run()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	internal struct DeserializeConnectablesTask
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x8DF84E0", Offset = "0x8DF72E0", VA = "0x188DF84E0")]
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
			public IRZBFTNHIIP operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005C2")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005C3")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005C4")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			private StackTimer<string>.XDYOTKRANGY <outboundTrafficTimer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x8E06690", Offset = "0x8E05490", VA = "0x188E06690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0x8E07AF0", Offset = "0x8E068F0", VA = "0x188E07AF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x8DF85C0", Offset = "0x8DF73C0", VA = "0x188DF85C0")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(IRZBFTNHIIP operationContext, UREAGQBAIUQ data, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken)
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
			public IRZBFTNHIIP operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005CE")]
			public HFKTNQXOSAI timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005CF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005D0")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005D1")]
			private ZVTYJEOYACF <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005D2")]
			private OEJGLDFIKZO <callbacks>5__3;

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
			private List<(PersistenceView, LZGZZRSUFGL)>.Enumerator <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			private PersistenceView <view>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			private LZGZZRSUFGL <viewData>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x8E059D0", Offset = "0x8E047D0", VA = "0x188E059D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x8E079D0", Offset = "0x8E067D0", VA = "0x188E079D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8700", Offset = "0x8DF7500", VA = "0x188DF8700")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(IRZBFTNHIIP operationContext, UREAGQBAIUQ data, HFKTNQXOSAI timedYielder, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8850", Offset = "0x8DF7650", VA = "0x188DF8850")]
		private static void YUFZQRAFLJF(PersistenceView a, LZGZZRSUFGL b, UREAGQBAIUQ c, RoomOperationState d, bool e)
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
			public ZVTYJEOYACF roomManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			public UREAGQBAIUQ data;

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
			[Cpp2IlInjected.Address(RVA = "0x8E06BC0", Offset = "0x8E059C0", VA = "0x188E06BC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x8E07A30", Offset = "0x8E06830", VA = "0x188E07A30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8A30", Offset = "0x8DF7830", VA = "0x188DF8A30")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(ZVTYJEOYACF roomManager, UREAGQBAIUQ data, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	internal struct DestroyOldObjectsTask
	{
		[Cpp2IlInjected.Token(Token = "0x2000163")]
		[CompilerGenerated]
		private sealed class ROWRFPJNAWU
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
				public StackTimer<string>.XDYOTKRANGY timer;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40005EB")]
				public CancellationToken token;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40005EC")]
				public ROWRFPJNAWU <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40005ED")]
				private StackTimer<string>.XDYOTKRANGY <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40005EE")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60005F5")]
				[Cpp2IlInjected.Address(RVA = "0x8E0F450", Offset = "0x8E0E250", VA = "0x188E0F450", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005F6")]
				[Cpp2IlInjected.Address(RVA = "0x8E0F7E0", Offset = "0x8E0E5E0", VA = "0x188E0F7E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005E7")]
			public Task KFQSKCWSSRN;

			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ROWRFPJNAWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x8DFBFB0", Offset = "0x8DFADB0", VA = "0x188DFBFB0")]
			[AsyncStateMachine(typeof(<<Run>b__0>d))]
			internal Task OXCHGMIOZZW(StackTimer<string>.XDYOTKRANGY a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000165")]
		[CompilerGenerated]
		private sealed class MVKUZKRYUYD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005EF")]
			public DEPRECATED_RoomPersistenceVersion version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40005F0")]
			public bool QFNNSVQSBQO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005F1")]
			public List<PersistenceView> FVCUCFWNKEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F2")]
			public List<GameObject> QWGQMXZJEAO;

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public MVKUZKRYUYD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x8DFB8F0", Offset = "0x8DFA6F0", VA = "0x188DFB8F0")]
			internal object ECMQMKWOAEG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x8DFB9C0", Offset = "0x8DFA7C0", VA = "0x188DFB9C0")]
			internal object ECRXJRQLJPP()
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
			public StackTimer<string>.XDYOTKRANGY stackTimer;

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
			private TaskAwaiter<FJZTCZTAMBW> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x8E07B50", Offset = "0x8E06950", VA = "0x188E07B50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x8E08750", Offset = "0x8E07550", VA = "0x188E08750", Slot = "5")]
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
			public ZVTYJEOYACF roomManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000601")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000602")]
			public IRZBFTNHIIP operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000603")]
			public bool useCompletionMark;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000604")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000605")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000606")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x8E0A780", Offset = "0x8E09580", VA = "0x188E0A780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x8E0A990", Offset = "0x8E09790", VA = "0x188E0A990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private ZVTYJEOYACF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private UREAGQBAIUQ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private IRZBFTNHIIP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private bool useCompletionMark;

		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private static readonly ByteString destroyObjectsGuid;

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		private OEJGLDFIKZO SNEHNJXCVIV
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x8DF9300", Offset = "0x8DF8100", VA = "0x188DF9300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		private ZZSHRDKMGMU YWWFJNZECIV
		{
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x8DF95D0", Offset = "0x8DF83D0", VA = "0x188DF95D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9350", Offset = "0x8DF8150", VA = "0x188DF9350")]
		[AsyncStateMachine(typeof(<Run>d__5))]
		public static Task Run(ZVTYJEOYACF roomManager, UREAGQBAIUQ data, IRZBFTNHIIP operationContext, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken, bool useCompletionMark)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x8DF94A0", Offset = "0x8DF82A0", VA = "0x188DF94A0")]
		[AsyncStateMachine(typeof(<Run>d__10))]
		private Task Run(StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8B50", Offset = "0x8DF7950", VA = "0x188DF8B50")]
		private void DestroyActivePersistenceViews([NotNull] PersistedRoomData downloadedRoomData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9670", Offset = "0x8DF8470", VA = "0x188DF9670")]
		private bool ZFDOKPFPAPZ(DEPRECATED_RoomPersistenceVersion a, PersistedRoomData b)
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
			public AsyncTaskMethodBuilder<Result<XTUHIFEWQKQ, RHLDYTPLBXY>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			public StackTimer<string>.XDYOTKRANGY downloadTimerScope;

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
			private StackTimer<string>.XDYOTKRANGY <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000623")]
			private TaskAwaiter<Result<XTUHIFEWQKQ, RHLDYTPLBXY>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x8DFE3D0", Offset = "0x8DFD1D0", VA = "0x188DFE3D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x8DFEA30", Offset = "0x8DFD830", VA = "0x188DFEA30", Slot = "5")]
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
			public AsyncTaskMethodBuilder<UREAGQBAIUQ> <>t__builder;

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
			private StackTimer<string>.XDYOTKRANGY <downloadTimerScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400062B")]
			private TaskAwaiter<IReadOnlyCollection<BakedUnitySubAssetDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x400062C")]
			private TaskAwaiter<(Result<XTUHIFEWQKQ, RHLDYTPLBXY>, Result<ParseResult<PersistedRoomData>, RHLDYTPLBXY>, Result<ParseResult<SuperRoomData>, RHLDYTPLBXY>, Result<ParseResult<IEnumerable<RoomAssetData>>, RHLDYTPLBXY>, Result<ParseResult<MMCRDVBAEMD>, RHLDYTPLBXY>)> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x8E08C70", Offset = "0x8E07A70", VA = "0x188E08C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x8E09A30", Offset = "0x8E08830", VA = "0x188E09A30", Slot = "5")]
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
		private VersionedDataGetter<long, MMCRDVBAEMD> playerSaveGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private ULYAFHQAGRC subRoomAssetBundleProvider;

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
		private StackTimer<string>.XDYOTKRANGY timer;

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9960", Offset = "0x8DF8760", VA = "0x188DF9960")]
		public static Task<UREAGQBAIUQ> TXLSUPWSILD(ZVTYJEOYACF a, [In] RoomLoadDetails data, RecNet.Core.OnDownloadProgressDelegate b, StackTimer<string>.XDYOTKRANGY c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x8DF97B0", Offset = "0x8DF85B0", VA = "0x188DF97B0")]
		[AsyncStateMachine(typeof(<Run>d__16))]
		private Task<UREAGQBAIUQ> Run(RecNet.Core.OnDownloadProgressDelegate downloadProgressCallback, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9E00", Offset = "0x8DF8C00", VA = "0x188DF9E00")]
		[AsyncStateMachine(typeof(<DownloadAssetBundles>d__17))]
		private Task<Result<XTUHIFEWQKQ, RHLDYTPLBXY>> VSUVLINMSBA(Guid? a, IReadOnlyCollection<BakedUnitySubAssetDTO> b, IReadOnlyCollection<BakedUnitySubAssetDTO> c, long? d, long? e, RecNet.Core.OnDownloadProgressDelegate f, StackTimer<string>.XDYOTKRANGY g, CancellationToken h)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	internal struct FetchRoomLoadDetailsTask
	{
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		[CompilerGenerated]
		private sealed class LYLAIXIKLRH
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
				public LYLAIXIKLRH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000649")]
				private StackTimer<string>.XDYOTKRANGY <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400064A")]
				private TaskAwaiter<RemoteRunDTO> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400064B")]
				private TaskAwaiter<SubRoomDataSaveWithUnityAssetsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600060E")]
				[Cpp2IlInjected.Address(RVA = "0x8E0C9F0", Offset = "0x8E0B7F0", VA = "0x188E0C9F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600060F")]
				[Cpp2IlInjected.Address(RVA = "0x8E0D3B0", Offset = "0x8E0C1B0", VA = "0x188E0D3B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000637")]
			public long KURFEDKQXZL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000638")]
			public string ARCLUFDTZIW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			public QSRCFKDQEPO SMGLJYYJENX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			public StackTimer<string>.XDYOTKRANGY ABYCHQRUDKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			public OEJGLDFIKZO FFRQMGYVOAZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			public CancellationToken QSOIRXWDLAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			public Guid? RLNHBRUSKRP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400063E")]
			public FilenameWithHash YNVPPDKNDFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400063F")]
			public FilenameWithHash TPZSGGIDSDW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			public long FHOXHBSIMSQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			public long IMKDVUXSNUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			public IReadOnlyList<BakedUnitySubAssetDTO> XIDJXSGIHXB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000643")]
			public IReadOnlyList<BakedUnitySubAssetDTO> KNQXYQAUMFW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000644")]
			public Guid YDHYMHAEOLW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			public RoomDetailsDTO QOTXGRFTKSS;

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public LYLAIXIKLRH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x133C330", Offset = "0x133B130", VA = "0x18133C330")]
			internal bool ILQSIBRJNBY(SubRoomDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x8DFB2F0", Offset = "0x8DFA0F0", VA = "0x188DFB2F0")]
			[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
			internal Task PUWGWJWXRNZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x8DFB0F0", Offset = "0x8DF9EF0", VA = "0x188DFB0F0")]
			internal Task<RoomLoadDTO> EHBEMYSPUCX()
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
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			private TaskAwaiter<RoomLoadDetails> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x8DFEAA0", Offset = "0x8DFD8A0", VA = "0x188DFEAA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x8DFEF20", Offset = "0x8DFDD20", VA = "0x188DFEF20", Slot = "5")]
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
			public QSRCFKDQEPO roomLoadDataProviderOverride;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000657")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000658")]
			public OEJGLDFIKZO callbacks;

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
			private LYLAIXIKLRH <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400065F")]
			private SubRoomDTO <subroom>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000660")]
			private Task<RoomLoadDTO> <getRoomLoadDTOTask>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000661")]
			private StackTimer<string>.XDYOTKRANGY <>7__wrap3;

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
			[Cpp2IlInjected.Address(RVA = "0x8DFEF90", Offset = "0x8DFDD90", VA = "0x188DFEF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x8DFFF30", Offset = "0x8DFED30", VA = "0x188DFFF30", Slot = "5")]
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
			private StackTimer<string>.XDYOTKRANGY <subTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400066A")]
			private TaskAwaiter<RoomLoadDetails> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x8E087B0", Offset = "0x8E075B0", VA = "0x188E087B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0x8E08C00", Offset = "0x8E07A00", VA = "0x188E08C00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private OEJGLDFIKZO callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private XUVXRPWZBOR debugRoomLoadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private QSRCFKDQEPO roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private StackTimer<string>.XDYOTKRANGY timer;

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
		[Cpp2IlInjected.Address(RVA = "0x8DFA4C0", Offset = "0x8DF92C0", VA = "0x188DFA4C0")]
		public static Task<RoomLoadDetails> TXLSUPWSILD(ZVTYJEOYACF a, RoomLoadRequestPayload b, StackTimer<string>.XDYOTKRANGY c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA370", Offset = "0x8DF9170", VA = "0x188DFA370")]
		[AsyncStateMachine(typeof(<Run>d__11))]
		private Task<RoomLoadDetails> Run(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA200", Offset = "0x8DF9000", VA = "0x188DFA200")]
		[AsyncStateMachine(typeof(<FetchRoomLoadDetails>d__12))]
		private Task<RoomLoadDetails> KSZAXVOXDQQ(StackTimer<string>.XDYOTKRANGY a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA030", Offset = "0x8DF8E30", VA = "0x188DFA030")]
		[AsyncStateMachine(typeof(<FetchRoomLoadDetails>d__13))]
		private static Task<RoomLoadDetails> KSZAXVOXDQQ(OEJGLDFIKZO a, QSRCFKDQEPO b, long c, long d, long e, string f, FilenameWithHash g, Guid h, CancellationToken i, StackTimer<string>.XDYOTKRANGY j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA710", Offset = "0x8DF9510", VA = "0x188DFA710")]
		private void VKKLLNJPHZI(RoomDetailsDTO a)
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
			private StackTimer<string>.XDYOTKRANGY <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000678")]
			private float <nextResendTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x8E0AA50", Offset = "0x8E09850", VA = "0x188E0AA50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0x8E0AFE0", Offset = "0x8E09DE0", VA = "0x188E0AFE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private OEJGLDFIKZO callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private UREAGQBAIUQ data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private StackTimer<string>.XDYOTKRANGY timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private float resendInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private float maxWaitEndTime;

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x8DFAAA0", Offset = "0x8DF98A0", VA = "0x188DFAAA0")]
		public static Task RELEANNNYLF(ZVTYJEOYACF a, UREAGQBAIUQ b, StackTimer<string>.XDYOTKRANGY c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x8DFAC40", Offset = "0x8DF9A40", VA = "0x188DFAC40")]
		[AsyncStateMachine(typeof(<Run>d__8))]
		public Task Run(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA740", Offset = "0x8DF9540", VA = "0x188DFA740")]
		private static void FVUDNMMLMPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA870", Offset = "0x8DF9670", VA = "0x188DFA870")]
		private void IVPHVTRMOTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA9E0", Offset = "0x8DF97E0", VA = "0x188DFA9E0")]
		private static float LNRYPCLREHF(OEJGLDFIKZO a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA9C0", Offset = "0x8DF97C0", VA = "0x188DFA9C0")]
		private static float KQNCQTCYSYQ()
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
			public IRZBFTNHIIP operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400067D")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000680")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			private EKKWWDICQVS <operation>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000682")]
			private ZVTYJEOYACF <roomManager>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000683")]
			private PreInstantiateObjectsTask.Results <instantiations>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000684")]
			private TaskAwaiter<FJZTCZTAMBW> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000685")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x8E071E0", Offset = "0x8E05FE0", VA = "0x188E071E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x8E07A90", Offset = "0x8E06890", VA = "0x188E07A90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E0FBF0", Offset = "0x8E0E9F0", VA = "0x188E0FBF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x8E0FF20", Offset = "0x8E0ED20", VA = "0x188E0FF20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x8DFADD0", Offset = "0x8DF9BD0", VA = "0x188DFADD0")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(IRZBFTNHIIP operationContext, UREAGQBAIUQ data, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x8DFAD60", Offset = "0x8DF9B60", VA = "0x188DFAD60")]
		private static Task<FJZTCZTAMBW> DHOXXWFZIHH(IRZBFTNHIIP a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x8DFAF10", Offset = "0x8DF9D10", VA = "0x188DFAF10")]
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
		private sealed class EIGBKFCSTWH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400068E")]
			public string MZHAHEVCBIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400068F")]
			public bool SJKXSUFJWXX;

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EIGBKFCSTWH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062E")]
			[Cpp2IlInjected.Address(RVA = "0x8DF9740", Offset = "0x8DF8540", VA = "0x188DF9740")]
			internal object HPCWXXSQXDU()
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
			private StackTimer<string>.XDYOTKRANGY <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000694")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000695")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x8E09FF0", Offset = "0x8E08DF0", VA = "0x188E09FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x8E0A9F0", Offset = "0x8E097F0", VA = "0x188E0A9F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E0B530", Offset = "0x8E0A330", VA = "0x188E0B530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x8E0B9A0", Offset = "0x8E0A7A0", VA = "0x188E0B9A0", Slot = "5")]
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
		private StackTimer<string>.XDYOTKRANGY timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private ZVTYJEOYACF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB3C0", Offset = "0x8DFA1C0", VA = "0x188DFB3C0")]
		public static Task LoadEmptyScene(ZVTYJEOYACF roomManager, bool isOffline, StackTimer<string>.XDYOTKRANGY timer, CancellationToken roomCancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB430", Offset = "0x8DFA230", VA = "0x188DFB430")]
		[AsyncStateMachine(typeof(<Run>d__5))]
		private Task Run()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB520", Offset = "0x8DFA320", VA = "0x188DFB520")]
		[AsyncStateMachine(typeof(<SafeLoadSceneAsync>d__6))]
		private Task TZLIGZIMDFQ(bool a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0")]
		private bool DPFRFHASCCC(bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal struct LoadSceneTask
	{
		[Cpp2IlInjected.Token(Token = "0x200017C")]
		[CompilerGenerated]
		private sealed class QFVEKDSMASK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006A0")]
			public string MZHAHEVCBIC;

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public QFVEKDSMASK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x8DFBF60", Offset = "0x8DFAD60", VA = "0x188DFBF60")]
			internal object HPCWXXSQXDU()
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
			private StackTimer<string>.XDYOTKRANGY <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006A5")]
			private TaskAwaiter<Scene> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0x8E09AA0", Offset = "0x8E088A0", VA = "0x188E09AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x8E09F80", Offset = "0x8E08D80", VA = "0x188E09F80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E0B040", Offset = "0x8E09E40", VA = "0x188E0B040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x8E0B4C0", Offset = "0x8E0A2C0", VA = "0x188E0B4C0", Slot = "5")]
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
		private StackTimer<string>.XDYOTKRANGY timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private ZVTYJEOYACF roomManager;

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB760", Offset = "0x8DFA560", VA = "0x188DFB760")]
		public static Task<Scene> SKKXQVBJWPJ(ZVTYJEOYACF a, RoomSceneLocations b, StackTimer<string>.XDYOTKRANGY c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB650", Offset = "0x8DFA450", VA = "0x188DFB650")]
		[AsyncStateMachine(typeof(<Run>d__4))]
		private Task<Scene> Run()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB7B0", Offset = "0x8DFA5B0", VA = "0x188DFB7B0")]
		[AsyncStateMachine(typeof(<SafeLoadSceneAsync>d__5))]
		private Task<Scene> TZLIGZIMDFQ(string a)
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
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006B4")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006B5")]
			public bool skipHandlers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40006B6")]
			public UREAGQBAIUQ deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40006B7")]
			private StackTimer<string>.XDYOTKRANGY <moveToPhaseTimer>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0x8E1BF60", Offset = "0x8E1AD60", VA = "0x188E1BF60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0x8E1CA00", Offset = "0x8E1B800", VA = "0x188E1CA00", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006C0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C1")]
			private TaskAwaiter<FJZTCZTAMBW> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x8E21B20", Offset = "0x8E20920", VA = "0x188E21B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x8E21DF0", Offset = "0x8E20BF0", VA = "0x188E21DF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private readonly IRZBFTNHIIP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private readonly XUVXRPWZBOR debugRoomLoadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private readonly TUJCUQQJKPP handlers;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		private EKKWWDICQVS OWGPXQYHHAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x406A090", Offset = "0x4068E90", VA = "0x18406A090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x8DFBDA0", Offset = "0x8DFABA0", VA = "0x188DFBDA0")]
		public MoveToPhaseTask(IRZBFTNHIIP operationContext, XUVXRPWZBOR debugRoomLoadInfo, TUJCUQQJKPP handlers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x8DFBA90", Offset = "0x8DFA890", VA = "0x188DFBA90")]
		[AsyncStateMachine(typeof(<MoveTo>d__6))]
		public Task<RoomOperationState> MoveTo(RoomOperationState nextPhase, UREAGQBAIUQ deserializationData, StackTimer<string>.XDYOTKRANGY stackTimer, CancellationToken cancellationToken, bool skipHandlers)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x8DFBC40", Offset = "0x8DFAA40", VA = "0x188DFBC40")]
		[AsyncStateMachine(typeof(<SendStateChangeMessage>d__7))]
		private Task<RoomOperationState> TWXYFFUZBKV(StackTimer<string>.XDYOTKRANGY a, RoomOperationState b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x8DFBC10", Offset = "0x8DFAA10", VA = "0x188DFBC10")]
		private bool PUHJJTKVTJK(RoomOperationState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x8DFBA70", Offset = "0x8DFA870", VA = "0x188DFBA70")]
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
			public EKKWWDICQVS operation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C5")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006C6")]
			public HFKTNQXOSAI timedYielder;

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
			private List<(PersistenceView, LZGZZRSUFGL)>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			private (PersistenceView, LZGZZRSUFGL) <pair>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x8E1F220", Offset = "0x8E1E020", VA = "0x188E1F220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x8E20220", Offset = "0x8E1F020", VA = "0x188E20220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x8E15FF0", Offset = "0x8E14DF0", VA = "0x188E15FF0")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(EKKWWDICQVS operation, UREAGQBAIUQ data, HFKTNQXOSAI timedYielder, CancellationToken cancellationToken)
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
			public EKKWWDICQVS operation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006D0")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006D1")]
			public HFKTNQXOSAI timedYielder;

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
			private List<(PersistenceView, LZGZZRSUFGL)>.Enumerator <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40006D8")]
			private PersistenceView <view>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40006D9")]
			private LZGZZRSUFGL <viewData>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40006DA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x8E1F8E0", Offset = "0x8E1E6E0", VA = "0x188E1F8E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x8E201C0", Offset = "0x8E1EFC0", VA = "0x188E201C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x8E16130", Offset = "0x8E14F30", VA = "0x188E16130")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(EKKWWDICQVS operation, UREAGQBAIUQ data, HFKTNQXOSAI timedYielder, CancellationToken cancellationToken)
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
			public AsyncTaskMethodBuilder<Result<XTUHIFEWQKQ, RHLDYTPLBXY>> <>t__builder;

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
			private TaskAwaiter<Result<XTUHIFEWQKQ, RHLDYTPLBXY>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x8E21430", Offset = "0x8E20230", VA = "0x188E21430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x8E21AB0", Offset = "0x8E208B0", VA = "0x188E21AB0", Slot = "5")]
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
		private ULYAFHQAGRC _subRoomAssetBundleProvider;

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x8E16E50", Offset = "0x8E15C50", VA = "0x188E16E50")]
		public static Task<Result<XTUHIFEWQKQ, RHLDYTPLBXY>> TXLSUPWSILD(long a, long b, SubRoomDataSaveWithUnityAssetsDTO c, RecNet.Core.OnDownloadProgressDelegate d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x8E16CF0", Offset = "0x8E15AF0", VA = "0x188E16CF0")]
		[AsyncStateMachine(typeof(<Run>d__8))]
		private Task<Result<XTUHIFEWQKQ, RHLDYTPLBXY>> Run(RecNet.Core.OnDownloadProgressDelegate preloadProgressCallback, CancellationToken cancellationToken)
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
			public List<KAVWRHZEEFC> instantiationRequests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			public List<LZGZZRSUFGL> requestDatas;

			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xC88220", Offset = "0xC87020", VA = "0x180C88220")]
			public Results(List<KAVWRHZEEFC> instantiationRequests, List<LZGZZRSUFGL> requestDatas)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018A")]
		[CompilerGenerated]
		private sealed class WCODKRWUAFT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			public IEnumerable<KAVWRHZEEFC> PZLRJNCQSZY;

			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WCODKRWUAFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0x8E26DE0", Offset = "0x8E25BE0", VA = "0x188E26DE0")]
			internal object AGJPZHZIIFG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private ZVTYJEOYACF roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private UREAGQBAIUQ data;

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		private OEJGLDFIKZO SNEHNJXCVIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0x8E16820", Offset = "0x8E15620", VA = "0x188E16820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x8E16C90", Offset = "0x8E15A90", VA = "0x188E16C90")]
		public static Results Run(ZVTYJEOYACF roomManager, UREAGQBAIUQ data)
		{
			return default(Results);
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x8E16A30", Offset = "0x8E15830", VA = "0x188E16A30")]
		private Results Run()
		{
			return default(Results);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x8E16270", Offset = "0x8E15070", VA = "0x188E16270")]
		private Results CAYTQQRFFSK(PersistedRoomData a, DEPRECATED_RoomPersistenceVersion b)
		{
			return default(Results);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x8E16870", Offset = "0x8E15670", VA = "0x188E16870")]
		private bool JXAGSJHIMSU(IEnumerable<KAVWRHZEEFC> a)
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
		private sealed class WRZXCNXOEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			public PreInstantiateObjectsTask.Results XQTYMXHTWTH;

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRZXCNXOEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0x8E26FC0", Offset = "0x8E25DC0", VA = "0x188E26FC0")]
			internal object OXCHGMIOZZW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018D")]
		[CompilerGenerated]
		private sealed class WRUQFHDQUXU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006EF")]
			public PersistenceView UIXKAJCOBRA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006F0")]
			public Guid QDNTFTWLABB;

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WRUQFHDQUXU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0x8E26F30", Offset = "0x8E25D30", VA = "0x188E26F30")]
			internal object OXHODTCMJLF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x8E17270", Offset = "0x8E16070", VA = "0x188E17270")]
		public static void Run(EKKWWDICQVS operation, UREAGQBAIUQ data, PreInstantiateObjectsTask.Results instantiations)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	internal class TUJCUQQJKPP
	{
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		[CompilerGenerated]
		private sealed class MVKUZKRYUYD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F6")]
			public Guid YAFFVKBTNKS;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public MVKUZKRYUYD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x8E15600", Offset = "0x8E14400", VA = "0x188E15600")]
			internal object LTZGSIXRGVD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000191")]
		[CompilerGenerated]
		private sealed class RLIIMBMFNNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F7")]
			public Guid YAFFVKBTNKS;

			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public RLIIMBMFNNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(RVA = "0x8E17160", Offset = "0x8E15F60", VA = "0x188E17160")]
			internal object VHWIWPEACAN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000192")]
		[CompilerGenerated]
		private sealed class LYLAIXIKLRH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F8")]
			public Guid YAFFVKBTNKS;

			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public LYLAIXIKLRH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(RVA = "0x8E14D50", Offset = "0x8E13B50", VA = "0x188E14D50")]
			internal object UJQKNOZQBDS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[CompilerGenerated]
		private sealed class EIGBKFCSTWH
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
				public EIGBKFCSTWH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000700")]
				public CancellationToken mlbToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000701")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000678")]
				[Cpp2IlInjected.Address(RVA = "0x8E22E30", Offset = "0x8E21C30", VA = "0x188E22E30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000679")]
				[Cpp2IlInjected.Address(RVA = "0x8E230F0", Offset = "0x8E21EF0", VA = "0x188E230F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006F9")]
			public TUJCUQQJKPP WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006FA")]
			public UREAGQBAIUQ UZOZEZLFZLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			public StackTimer<string>.XDYOTKRANGY PNCQYTLSJBQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			public Func<CancellationToken, Task> CBANWYGKPPE;

			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EIGBKFCSTWH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(RVA = "0x8E11A70", Offset = "0x8E10870", VA = "0x188E11A70")]
			[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
			internal Task BOYGLLQMNZL(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[CompilerGenerated]
		private sealed class ZVGRUIXYDWS
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
				public ZVGRUIXYDWS <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400070B")]
				private LogRangeScope <_>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400070C")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600067E")]
				[Cpp2IlInjected.Address(RVA = "0x8E22970", Offset = "0x8E21770", VA = "0x188E22970", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600067F")]
				[Cpp2IlInjected.Address(RVA = "0x8E22DD0", Offset = "0x8E21BD0", VA = "0x188E22DD0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000702")]
			public RunFor UWBHQUKOHVR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000703")]
			public Guid NAMCUZJHFFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000704")]
			public List<DeserializationPhaseHandler> XJMTYEKJJXV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000705")]
			public UREAGQBAIUQ UZOZEZLFZLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000706")]
			public CancellationToken HKVRIFBUEUE;

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZVGRUIXYDWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x8E272A0", Offset = "0x8E260A0", VA = "0x188E272A0")]
			internal object UFOCHJQZWCN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x8E270C0", Offset = "0x8E25EC0", VA = "0x188E270C0")]
			[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
			internal Task UFDOMWDFDFV(DeserializationPhaseHandler a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x8E271C0", Offset = "0x8E25FC0", VA = "0x188E271C0")]
			internal object UFIVKCXCMRE()
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
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000713")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000714")]
			private ZVGRUIXYDWS <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000715")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0x8E1A8D0", Offset = "0x8E196D0", VA = "0x188E1A8D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x8E1AD60", Offset = "0x8E19B60", VA = "0x188E1AD60", Slot = "5")]
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
			public TUJCUQQJKPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400071A")]
			public UREAGQBAIUQ data;

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
			[Cpp2IlInjected.Address(RVA = "0x8E1ADC0", Offset = "0x8E19BC0", VA = "0x188E1ADC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B270", Offset = "0x8E1A070", VA = "0x188E1B270", Slot = "5")]
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
			public TUJCUQQJKPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000721")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000722")]
			public StackTimer<string>.XDYOTKRANGY timer;

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
			[Cpp2IlInjected.Address(RVA = "0x8E1B2D0", Offset = "0x8E1A0D0", VA = "0x188E1B2D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B880", Offset = "0x8E1A680", VA = "0x188E1B880", Slot = "5")]
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
			public TUJCUQQJKPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400072A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400072B")]
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400072C")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400072D")]
			private ByteString <completionMark>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400072E")]
			private TaskAwaiter<FJZTCZTAMBW> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B8E0", Offset = "0x8E1A6E0", VA = "0x188E1B8E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000687")]
			[Cpp2IlInjected.Address(RVA = "0x8E1BF00", Offset = "0x8E1AD00", VA = "0x188E1BF00", Slot = "5")]
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
			public TUJCUQQJKPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000732")]
			public RoomOperationState operationState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000733")]
			public UREAGQBAIUQ deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000734")]
			public StackTimer<string>.XDYOTKRANGY timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000735")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000736")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0x8E20980", Offset = "0x8E1F780", VA = "0x188E20980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0x8E210E0", Offset = "0x8E1FEE0", VA = "0x188E210E0", Slot = "5")]
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
			public TUJCUQQJKPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400073A")]
			public StackTimer<string>.XDYOTKRANGY timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400073B")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400073C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400073D")]
			private StackTimer<string>.XDYOTKRANGY <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400073E")]
			private Dictionary<Guid, List<DeserializationPhaseHandler>>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400073F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0x8E1DA30", Offset = "0x8E1C830", VA = "0x188E1DA30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0x8E1E040", Offset = "0x8E1CE40", VA = "0x188E1E040", Slot = "5")]
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
			public TUJCUQQJKPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000743")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000744")]
			public StackTimer<string>.XDYOTKRANGY timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000745")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000746")]
			private EIGBKFCSTWH <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000747")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0x8E1E0A0", Offset = "0x8E1CEA0", VA = "0x188E1E0A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068D")]
			[Cpp2IlInjected.Address(RVA = "0x8E1E5B0", Offset = "0x8E1D3B0", VA = "0x188E1E5B0", Slot = "5")]
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
			public TUJCUQQJKPP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400074B")]
			public StackTimer<string>.XDYOTKRANGY timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400074C")]
			public UREAGQBAIUQ data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400074D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400074E")]
			private StackTimer<string>.XDYOTKRANGY <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400074F")]
			private Dictionary<Guid, List<DeserializationPhaseHandler>>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000750")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0x8E1EB20", Offset = "0x8E1D920", VA = "0x188E1EB20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068F")]
			[Cpp2IlInjected.Address(RVA = "0x8E1F1C0", Offset = "0x8E1DFC0", VA = "0x188E1F1C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private readonly IRZBFTNHIIP PVVPKNIOAPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private DeserializationHandlerLists ATQOTJURZMC;

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		private EKKWWDICQVS OWGPXQYHHAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x132AD50", Offset = "0x1329B50", VA = "0x18132AD50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public TUJCUQQJKPP(IRZBFTNHIIP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x8E1A380", Offset = "0x8E19180", VA = "0x188E1A380")]
		[AsyncStateMachine(typeof(<Run>d__5))]
		public Task Run(RoomOperationState operationState, UREAGQBAIUQ deserializationData, StackTimer<string>.XDYOTKRANGY timer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x8E1A060", Offset = "0x8E18E60", VA = "0x188E1A060")]
		[AsyncStateMachine(typeof(<RunAuthorityHandler>d__6))]
		private Task KTOURRBQPYX(UREAGQBAIUQ a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x8E1A4D0", Offset = "0x8E192D0", VA = "0x188E1A4D0")]
		[AsyncStateMachine(typeof(<RunAllHandlers>d__7))]
		private Task SHMNYZKHANI(UREAGQBAIUQ a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x8E199F0", Offset = "0x8E187F0", VA = "0x188E199F0")]
		[AsyncStateMachine(typeof(<RunNonAuthorityHandlers>d__8))]
		private Task BZWQTYSSHWN(UREAGQBAIUQ a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x8E19B30", Offset = "0x8E18930", VA = "0x188E19B30")]
		[AsyncStateMachine(typeof(<InvokeMethodsInParallel>d__9))]
		private Task DYGWBIUROPF(Guid a, List<DeserializationPhaseHandler> b, RunFor c, UREAGQBAIUQ d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x8E19F20", Offset = "0x8E18D20", VA = "0x188E19F20")]
		[AsyncStateMachine(typeof(<MasterLockedHandler>d__10))]
		private Task IVZICFIJFJX(UREAGQBAIUQ a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x8E19C80", Offset = "0x8E18A80", VA = "0x188E19C80")]
		[AsyncStateMachine(typeof(<MasterInvokeHandlerMethods>d__11))]
		private Task ECVXTXBHTBF(Guid a, UREAGQBAIUQ b, StackTimer<string>.XDYOTKRANGY c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x8E1A240", Offset = "0x8E19040", VA = "0x188E1A240")]
		[AsyncStateMachine(typeof(<MasterSyncSendCompletionMark>d__12))]
		private Task NFOZIUPNEVF(Guid a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x8E1A610", Offset = "0x8E19410", VA = "0x188E1A610")]
		private void WVERYTCGLUE(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x8E1A1A0", Offset = "0x8E18FA0", VA = "0x188E1A1A0")]
		private void MSJGCEYETQR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x8E19DC0", Offset = "0x8E18BC0", VA = "0x188E19DC0")]
		public Guid FAKZYWPNHRO(RoomOperationState a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x8E1A720", Offset = "0x8E19520", VA = "0x188E1A720")]
		[CompilerGenerated]
		private object YAAAUWUEDBB()
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
			private StackTimer<string>.XDYOTKRANGY <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000758")]
			private IEnumerator<EmptySceneHandler> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000759")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x8E20280", Offset = "0x8E1F080", VA = "0x188E20280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x8E20920", Offset = "0x8E1F720", VA = "0x188E20920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		private OEJGLDFIKZO callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		private StackTimer<string>.XDYOTKRANGY timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x8E18940", Offset = "0x8E17740", VA = "0x188E18940")]
		public static Task WQEDLQGCUJY(OEJGLDFIKZO a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x8E18850", Offset = "0x8E17650", VA = "0x188E18850")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D38590", Offset = "0x2D37390", VA = "0x182D38590")]
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
		public IReadOnlyCollection<string> VOGUAZRJNIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000695")]
			[Cpp2IlInjected.Address(RVA = "0x8E17B50", Offset = "0x8E16950", VA = "0x188E17B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public IReadOnlyDictionary<long, int> SIELTIIEYST
		{
			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0x8E17B30", Offset = "0x8E16930", VA = "0x188E17B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x8E17B70", Offset = "0x8E16970", VA = "0x188E17B70")]
		public RoomSerializedData(PersistedRoomData? roomData, PersistedRoomDataReferences roomDataReferences, Guid? unityAssetId, [Optional] IReadOnlyList<Guid>? roomAssets)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	internal class CPMHLDYVALD : NLXAQTNBBWS
	{
		[Cpp2IlInjected.Token(Token = "0x20001A5")]
		[CompilerGenerated]
		private sealed class WCODKRWUAFT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000765")]
			public float KIJNLCTDZCG;

			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WCODKRWUAFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0x8E26E50", Offset = "0x8E25C50", VA = "0x188E26E50")]
			internal object QJCHVCKTGXG()
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
			public CPMHLDYVALD <>4__this;

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
			private WCODKRWUAFT <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400076D")]
			private LogRangeScope <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400076E")]
			private CancellationTokenSource <cts>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400076F")]
			private ODUSMGRZXRA<Task> <tasks>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000770")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006A6")]
			[Cpp2IlInjected.Address(RVA = "0x8E1CA70", Offset = "0x8E1B870", VA = "0x188E1CA70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0x8E1D4A0", Offset = "0x8E1C2A0", VA = "0x188E1D4A0", Slot = "5")]
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
			public CPMHLDYVALD <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8E21E60", Offset = "0x8E20C60", VA = "0x188E21E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0x8E224E0", Offset = "0x8E212E0", VA = "0x188E224E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400075F")]
		private readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x4000760")]
		private static readonly TimeSpan SKYAGCGOEUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private readonly GGVBKYTZCIJ PBGTVYIKWFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private readonly RJTZHSGPMIL OTUMVMNGTXW;

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x8E11A10", Offset = "0x8E10810", VA = "0x188E11A10")]
		public CPMHLDYVALD(IRZBFTNHIIP a, GGVBKYTZCIJ b, RJTZHSGPMIL c, Log d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x8E110F0", Offset = "0x8E0FEF0", VA = "0x188E110F0")]
		[AsyncStateMachine(typeof(<Serialize>d__6))]
		public Task<RoomSerializedData> Serialize(long subroomId, RoomSaveOptions roomSaveOptions, SerializeType serializeType, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x8E11000", Offset = "0x8E0FE00", VA = "0x188E11000")]
		private static bool RVGVGHPIKUX(PersistenceView a, [Out] RRObjectPolicy b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x8E116B0", Offset = "0x8E104B0", VA = "0x188E116B0")]
		[AsyncStateMachine(typeof(<PreserializeViews>d__8))]
		private Task UEKAAJFRYGI(SerializeType a, PersistenceView[] b, StringBuilder c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x8E10A30", Offset = "0x8E0F830", VA = "0x188E10A30")]
		private RoomSerializedData MWAVJGUKQEH(long a, RoomSaveOptions b, SerializeType c, IEnumerable<PersistenceView> d, StringBuilder e)
		{
			return default(RoomSerializedData);
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x8E117F0", Offset = "0x8E105F0", VA = "0x188E117F0")]
		private PersistedRoomData YKUXVWSSLGB(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x8E107E0", Offset = "0x8E0F5E0", VA = "0x188E107E0")]
		private void AXNJBEHWVUC(PersistedRoomData a, StringBuilder b, IEnumerable<PersistenceView> c, [In] RoomSerializedMetadata metadata, BTZWHYILXXM d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x8E11240", Offset = "0x8E10040", VA = "0x188E11240")]
		private void TRIGJEPMPFJ(PersistedRoomData a, StringBuilder b, PersistenceView c, BTZWHYILXXM d, [In] RoomSerializedMetadata metadata)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	internal class RoomUploadLogic : NLXAQTNBBWS
	{
		[Cpp2IlInjected.Token(Token = "0x20001A9")]
		[CompilerGenerated]
		private sealed class RLIIMBMFNNE
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
				public AsyncTaskMethodBuilder<FJZTCZTAMBW> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000789")]
				public RLIIMBMFNNE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400078A")]
				public CancellationToken masterLockedBlockCancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400078B")]
				private FJZTCZTAMBW <reloadMessage>5__2;

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
				private TaskAwaiter<FJZTCZTAMBW> <>u__4;

				[Cpp2IlInjected.Token(Token = "0x60006B5")]
				[Cpp2IlInjected.Address(RVA = "0x8E23150", Offset = "0x8E21F50", VA = "0x188E23150", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006B6")]
				[Cpp2IlInjected.Address(RVA = "0x8E24370", Offset = "0x8E23170", VA = "0x188E24370", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400077F")]
			public RoomUploadLogic WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000780")]
			public RoomSerializedData QFGCZKTQVXM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000781")]
			public int HVMIEXWRSYS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000782")]
			public long IMKDVUXSNUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000783")]
			public long LBPVDIFAQXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000784")]
			public RoomSaveRequestPayload XGJQBPYPAKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000785")]
			public RoomSaveAnalyticsInfo XYOAJHLCRIT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000786")]
			public StackTimer<string>.XDYOTKRANGY ABYCHQRUDKW;

			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public RLIIMBMFNNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B4")]
			[Cpp2IlInjected.Address(RVA = "0x8E17030", Offset = "0x8E15E30", VA = "0x188E17030")]
			[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
			internal Task<FJZTCZTAMBW> DCHBGGSVOPF(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AB")]
		[CompilerGenerated]
		private sealed class ZRSJAVAQQNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000790")]
			public Storage.UploadFileResponseDTO MARDUZTFHHP;

			[Cpp2IlInjected.Token(Token = "0x60006B7")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZRSJAVAQQNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B8")]
			[Cpp2IlInjected.Address(RVA = "0x8E27070", Offset = "0x8E25E70", VA = "0x188E27070")]
			internal object RZUNTDWPBDF()
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
			[Cpp2IlInjected.Address(RVA = "0x8E1D500", Offset = "0x8E1C300", VA = "0x188E1D500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BA")]
			[Cpp2IlInjected.Address(RVA = "0x8E1D9C0", Offset = "0x8E1C7C0", VA = "0x188E1D9C0", Slot = "5")]
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
			public OEJGLDFIKZO callbacks;

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
			[Cpp2IlInjected.Address(RVA = "0x8E24CC0", Offset = "0x8E23AC0", VA = "0x188E24CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BC")]
			[Cpp2IlInjected.Address(RVA = "0x8E25320", Offset = "0x8E24120", VA = "0x188E25320", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E25390", Offset = "0x8E24190", VA = "0x188E25390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0x8E25630", Offset = "0x8E24430", VA = "0x188E25630", Slot = "5")]
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
			public AsyncTaskMethodBuilder<FJZTCZTAMBW> <>t__builder;

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
			public StackTimer<string>.XDYOTKRANGY stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007B9")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007BA")]
			private TaskAwaiter<FJZTCZTAMBW> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x8E24930", Offset = "0x8E23730", VA = "0x188E24930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0x8E24C50", Offset = "0x8E23A50", VA = "0x188E24C50", Slot = "5")]
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
			public OEJGLDFIKZO callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007BF")]
			private ZRSJAVAQQNC <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x8E256A0", Offset = "0x8E244A0", VA = "0x188E256A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0x8E25EE0", Offset = "0x8E24CE0", VA = "0x188E25EE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400077C")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x400077D")]
		private static readonly Log XQOIFOOUJRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400077E")]
		private readonly DRIWUQXUIFC JZVXLKSVRDL;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		private ZVTYJEOYACF XBWIUWVJWGT
		{
			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0x8DE1E30", Offset = "0x8DE0C30", VA = "0x188DE1E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x8E187C0", Offset = "0x8E175C0", VA = "0x188E187C0")]
		public RoomUploadLogic(IRZBFTNHIIP operationContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x8E17E10", Offset = "0x8E16C10", VA = "0x188E17E10")]
		[AsyncStateMachine(typeof(<UploadRoomDataToStorage>d__7))]
		private static Task<(Storage.UploadFileResponseDTO, Storage.UploadFileResponseDTO)> SOXJCMNWUBP(OEJGLDFIKZO a, RoomSerializedData b, long c, long d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x8E17F60", Offset = "0x8E16D60", VA = "0x188E17F60")]
		[AsyncStateMachine(typeof(<UploadRoomDataBlob>d__8))]
		public Task<SaveSubRoomResponseDTO> TCDEYGVCWQW(int a, [CanBeNull] RoomSaveRequestPayload roomSaveRequestPayload, RoomSerializedData b, long c, long d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x8E18260", Offset = "0x8E17060", VA = "0x188E18260")]
		public static Task<SaveSubRoomResponseDTO> TCDEYGVCWQW(OEJGLDFIKZO a, int b, [CanBeNull] RoomSaveRequestPayload roomSaveRequestPayload, RoomSerializedData c, long d, long e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x8E180D0", Offset = "0x8E16ED0", VA = "0x188E180D0")]
		[AsyncStateMachine(typeof(<UploadRoomDataBlob>d__10))]
		public static Task<SaveSubRoomResponseDTO> TCDEYGVCWQW(OEJGLDFIKZO a, int b, [CanBeNull] RoomSaveRequestPayload roomSaveRequestPayload, RoomSerializedData c, long d, long e, UgcVersionInfo f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x8E185B0", Offset = "0x8E173B0", VA = "0x188E185B0")]
		[AsyncStateMachine(typeof(<PushRoomDataBlobToStudio>d__11))]
		private Task<RemoteRunDTO> VYYYVNZHZAM(string a, int b, RoomSerializedData c, long d, long e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x8E17C60", Offset = "0x8E16A60", VA = "0x188E17C60")]
		[AsyncStateMachine(typeof(<UploadRoomDataBlobAndSyncReload>d__12))]
		public Task<FJZTCZTAMBW> OIHUKBPBTEJ(int a, RoomSaveRequestPayload? roomSaveRequestPayload, RoomSerializedData b, long c, long d, RoomSaveAnalyticsInfo e, StackTimer<string>.XDYOTKRANGY f, CancellationToken g)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B1")]
	public abstract class KIPAMIPSHEH<a> where a : KIPAMIPSHEH<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		internal readonly ZVTYJEOYACF CMMONUPNHRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C5")]
		private int? MGOYTQXJBAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C6")]
		protected readonly Guid ZLKFLBCSCQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007C7")]
		protected readonly RoomOperationType VQLUWJJIEBX;

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		protected a VSSCZUMCNND
		{
			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0x54C4670", Offset = "0x54C3470", VA = "0x1854C4670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x54C4A00", Offset = "0x54C3800", VA = "0x1854C4A00")]
		internal KIPAMIPSHEH(ZVTYJEOYACF a, RoomOperationType b, [Optional] Guid? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x54C46D0", Offset = "0x54C34D0", VA = "0x1854C46D0")]
		private FJZTCZTAMBW PUEGKQWSAYJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		protected virtual void QKRRWBKJQMU(FJZTCZTAMBW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x54C44F0", Offset = "0x54C32F0", VA = "0x1854C44F0")]
		public a CSPYXMUJXQZ(XGOJTPBZDNO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x54C47B0", Offset = "0x54C35B0", VA = "0x1854C47B0")]
		public a SQGTSCGINZL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x54C4870", Offset = "0x54C3670", VA = "0x1854C4870", Slot = "5")]
		public virtual Task<MMSSFGQGRLF> Submit()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	public class JLTAWNPKWMA : KIPAMIPSHEH<JLTAWNPKWMA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C8")]
		private RoomLoadRequestPayload EQZCXZLFUCL;

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x8E14C80", Offset = "0x8E13A80", VA = "0x188E14C80")]
		internal JLTAWNPKWMA(ZVTYJEOYACF a, RoomOperationType b, [Optional] Guid? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x7FE67D0", Offset = "0x7FE55D0", VA = "0x187FE67D0")]
		public JLTAWNPKWMA GMIVOYGNPKH(RoomLoadRequestPayload a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x8E14BB0", Offset = "0x8E139B0", VA = "0x188E14BB0", Slot = "4")]
		protected override void QKRRWBKJQMU(FJZTCZTAMBW a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	public class UCZTNRMTMIH : KIPAMIPSHEH<UCZTNRMTMIH>
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
			public AsyncTaskMethodBuilder<MMSSFGQGRLF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007D2")]
			public UCZTNRMTMIH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007D4")]
			private TaskAwaiter<MMSSFGQGRLF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006D5")]
			[Cpp2IlInjected.Address(RVA = "0x8E22550", Offset = "0x8E21350", VA = "0x188E22550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0x8E22900", Offset = "0x8E21700", VA = "0x188E22900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007C9")]
		private SaveTarget ZPWGWCNBLSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007CA")]
		private string WBFCLCLXGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007CB")]
		private RoomSaveRequestPayload EQZCXZLFUCL;

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x8E26280", Offset = "0x8E25080", VA = "0x188E26280")]
		internal UCZTNRMTMIH(ZVTYJEOYACF a, RoomOperationType b, [Optional] Guid? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x8E25F70", Offset = "0x8E24D70", VA = "0x188E25F70")]
		public UCZTNRMTMIH ETGCWXIOXYX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x8E25FD0", Offset = "0x8E24DD0", VA = "0x188E25FD0")]
		public UCZTNRMTMIH KPZAWEGQQKL(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x8E25F50", Offset = "0x8E24D50", VA = "0x188E25F50")]
		public UCZTNRMTMIH CODUWZUINVB(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x8E25FA0", Offset = "0x8E24DA0", VA = "0x188E25FA0")]
		public UCZTNRMTMIH HEWZSGKCYTF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x8E25FF0", Offset = "0x8E24DF0", VA = "0x188E25FF0", Slot = "4")]
		protected override void QKRRWBKJQMU(FJZTCZTAMBW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x8E26150", Offset = "0x8E24F50", VA = "0x188E26150", Slot = "5")]
		[AsyncStateMachine(typeof(<Submit>d__11))]
		public override Task<MMSSFGQGRLF> Submit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x8E26240", Offset = "0x8E25040", VA = "0x188E26240")]
		[CompilerGenerated]
		[DebuggerHidden]
		private Task<MMSSFGQGRLF> UJCCGQOSJGF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	internal static class OWRULDIQUWS
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x8E15EB0", Offset = "0x8E14CB0", VA = "0x188E15EB0")]
		public static void NYUUBSYYBBG(this PlayerPresence a, RoomInstance b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x8E15E30", Offset = "0x8E14C30", VA = "0x188E15E30")]
		public static void ERRAMURBTNP(this RoomInstance a, [Optional] string b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	public static class AUHIQLNYJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x8E10740", Offset = "0x8E0F540", VA = "0x188E10740")]
		public static FilenameWithHash WHLWSKEQNFZ(this IBJQXVKEWQG a)
		{
			return default(FilenameWithHash);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x8E10690", Offset = "0x8E0F490", VA = "0x188E10690")]
		public static IBJQXVKEWQG DGRNKTUFKXC(this FilenameWithHash a)
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
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E26C50", Offset = "0x8E25A50", VA = "0x188E26C50")]
		public bool TryGetConfig(ValidationReason validationReason, [Out] ResultConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x8E263F0", Offset = "0x8E251F0", VA = "0x188E263F0")]
		public ResultConfig GetConfigForResult(ValidationReason reason, [Optional] HashSet<ValidationReason> visited)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x8E26A80", Offset = "0x8E25880", VA = "0x188E26A80", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x8E26520", Offset = "0x8E25320", VA = "0x188E26520", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x180D53CD0")]
		public ValidationResultConfig()
		{
		}
	}
}
namespace RecRoom.RoomLoading.PreEmptyScene
{
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	public class RoomManagerPreEmptyScene : LONPPRYZMAK
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
			public StackTimer<string>.XDYOTKRANGY timerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007E9")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007EA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x8E21140", Offset = "0x8E1FF40", VA = "0x188E21140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x8E213D0", Offset = "0x8E201D0", VA = "0x188E213D0", Slot = "5")]
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
			public StackTimer<string>.XDYOTKRANGY timerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007EE")]
			public LONPPRYZMAK preEmptySceneHandler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007EF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007F0")]
			private StackTimer<string>.XDYOTKRANGY <ts>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007F1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x8E1E610", Offset = "0x8E1D410", VA = "0x188E1E610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x8E1EAC0", Offset = "0x8E1D8C0", VA = "0x188E1EAC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		private readonly VFPSFZFFLHW JUOUZGGWMIL;

		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public string FJBQIRIBLFF
		{
			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x8E177F0", Offset = "0x8E165F0", VA = "0x188E177F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x8E17820", Offset = "0x8E16620", VA = "0x188E17820")]
		[FDNTPBIGLET.Root.GameOnly]
		internal static void HRXPQQWMYFV(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		[RecRoom.NoEngine.Common.Preserve]
		public RoomManagerPreEmptyScene([Inject(null)] VFPSFZFFLHW assetBundlePreEmptySceneHandler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x8E179B0", Offset = "0x8E167B0", VA = "0x188E179B0", Slot = "5")]
		[AsyncStateMachine(typeof(<Run>d__6))]
		public Task Run(StackTimer<string>.XDYOTKRANGY timerScope, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x8E17890", Offset = "0x8E16690", VA = "0x188E17890")]
		[AsyncStateMachine(typeof(<RunHandlerWithCancellationForwarding>d__7))]
		private Task JQXUIDDKWMM(LONPPRYZMAK a, StackTimer<string>.XDYOTKRANGY b, CancellationToken c)
		{
			return null;
		}
	}
}
namespace RecRoom.RoomLoading.Interfaces.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20001BE")]
	public interface VFPSFZFFLHW : LONPPRYZMAK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	public interface LONPPRYZMAK
	{
		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		string FJBQIRIBLFF
		{
			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task Run(StackTimer<string>.XDYOTKRANGY timerScope, CancellationToken cancellationToken);
	}
}
namespace RecRoom.RoomLoading.AutoSaves
{
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	public static class FZUYHCYIGVT
	{
		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x8E12770", Offset = "0x8E11570", VA = "0x188E12770")]
		[FDNTPBIGLET.Root.GameOnly]
		internal static void NHOBNFBSGEC(FDTRVDFSBYT a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C1")]
	public interface JFLMODKHJZH : IEquatable<JFLMODKHJZH>
	{
		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		DateTime LHAIOJWNTAT
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
		bool INJSNXWRDEQ(long a, long b, [Out] RoomSerializedData c);
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	internal class FVZKCPDBZGB : NGHBVBJQDMO
	{
		[Cpp2IlInjected.Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class EIGBKFCSTWH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007F6")]
			public AutosaveType UOAQWJAFGSF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007F7")]
			public Exception DRNNHSFOJIW;

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EIGBKFCSTWH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x8E11B60", Offset = "0x8E10960", VA = "0x188E11B60")]
			internal object NICSIWIJYGN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private readonly WUPSZFNVXTG COYXSHESHPP;

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<JFLMODKHJZH> JZPUVDFLFQE
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x8E11BD0", Offset = "0x8E109D0", VA = "0x188E11BD0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0x8E12090", Offset = "0x8E10E90", VA = "0x188E12090", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		[UnityEngine.Scripting.Preserve]
		public FVZKCPDBZGB([Inject(null)] WUPSZFNVXTG autosaveStorageService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x8E122B0", Offset = "0x8E110B0", VA = "0x188E122B0", Slot = "6")]
		public bool KQWZASYFXFF(long a, long b, RoomSerializedData c, AutosaveType d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xF6BA10", Offset = "0xF6A810", VA = "0x180F6BA10")]
		private void NSIRRFWPWUI(JFLMODKHJZH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x8E12140", Offset = "0x8E10F40", VA = "0x188E12140", Slot = "7")]
		public bool KQQVUQOXWQJ(long a, long b, [Out] JFLMODKHJZH c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x8E126C0", Offset = "0x8E114C0", VA = "0x188E126C0", Slot = "8")]
		public bool OJHDGLNUOEO(long a, long b, AutosaveType c, [Out] JFLMODKHJZH d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x8E11C80", Offset = "0x8E10A80", VA = "0x188E11C80")]
		private void EFZFPJJYQQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x8E12590", Offset = "0x8E11390", VA = "0x188E12590", Slot = "9")]
		public void LIXZIOYATWR(long a, long b)
		{
		}
	}
}
namespace RecRoom.RoomLoading.AutoSaves.Versions
{
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	internal abstract class TEMIHFVRWLU : WUPSZFNVXTG
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
		private sealed class ROWRFPJNAWU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007FC")]
			public AutosaveType UOAQWJAFGSF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007FD")]
			public FileInfo UBKKGHGUXCD;

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ROWRFPJNAWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x8E171D0", Offset = "0x8E15FD0", VA = "0x188E171D0")]
			internal object OTBOLRYXKFS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001C8")]
		[CompilerGenerated]
		private sealed class WLRRSVOUONV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007FE")]
			public TEMIHFVRWLU WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007FF")]
			public FileInfo RVZIARIMTGJ;

			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WLRRSVOUONV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0x8E26EB0", Offset = "0x8E25CB0", VA = "0x188E26EB0")]
			internal void DXQULLZOKBK(PlayerReporting.HileType a, string b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001C9")]
		[CompilerGenerated]
		private sealed class OLZEAAVZERL : IEnumerable<JFLMODKHJZH>, IEnumerable, IEnumerator<JFLMODKHJZH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000800")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000801")]
			private JFLMODKHJZH QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000802")]
			private int DQRPPGNAYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000803")]
			public TEMIHFVRWLU WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000804")]
			private AutosaveType UOAQWJAFGSF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000805")]
			public AutosaveType VCVAVSCNFLY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000806")]
			private FileInfo[] ZQJSAWQBUYL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			private int ZQOYYDJZEJU;

			[Cpp2IlInjected.Token(Token = "0x170000F3")]
			private JFLMODKHJZH KKOTPPAIXYN
			{
				[Cpp2IlInjected.Token(Token = "0x600071A")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F4")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600071C")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
			[DebuggerHidden]
			public OLZEAAVZERL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0x8E157D0", Offset = "0x8E145D0", VA = "0x188E157D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x8E156B0", Offset = "0x8E144B0", VA = "0x188E156B0", Slot = "10")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x8E15D80", Offset = "0x8E14B80", VA = "0x188E15D80", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JFLMODKHJZH> VLEBXNKBTUW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0x8E15D80", Offset = "0x8E14B80", VA = "0x188E15D80", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		private readonly object TFFRHDMILAS;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		protected string VZZADWGGMMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x8E18F90", Offset = "0x8E17D90", VA = "0x188E18F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract AutosaveVersion JXCKEWUGMUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x8E19980", Offset = "0x8E18780", VA = "0x188E19980")]
		protected TEMIHFVRWLU([CanBeNull] string persistentDataDir)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x8E19790", Offset = "0x8E18590", VA = "0x188E19790", Slot = "5")]
		public bool XEABNMZUPBY(long a, long b, AutosaveType c, [Out] JFLMODKHJZH d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x8E19710", Offset = "0x8E18510", VA = "0x188E19710", Slot = "6")]
		[IteratorStateMachine(typeof(OLZEAAVZERL))]
		public IEnumerable<JFLMODKHJZH> TPGZIFIWUVM(AutosaveType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		internal abstract void XJVIRUGYIDV(Stream a, long b, long c, RoomSerializedData d);

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		internal abstract bool EREMQFBKAEO(Stream a, long b, long c, HileFunc d, [Out] RoomSerializedData e);

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x8E18FA0", Offset = "0x8E17DA0", VA = "0x188E18FA0", Slot = "7")]
		public JFLMODKHJZH QGNISEQBTGA(long a, long b, RoomSerializedData c, AutosaveType d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		[NotNull]
		protected abstract FileInfo XIERRJFIDZL(long a, long b, AutosaveType c, DirectoryAccessMode d);

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		[NotNull]
		protected abstract DirectoryInfo KOGBROYXGGR(AutosaveType a, DirectoryAccessMode b);

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x8E196A0", Offset = "0x8E184A0", VA = "0x188E196A0")]
		protected void SRZVLDXCFJL(PlayerReporting.HileType a, string b, FileInfo c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x8E19310", Offset = "0x8E18110", VA = "0x188E19310")]
		internal bool SMPTIKAUDIU(FileInfo a, long b, long c, [Out] RoomSerializedData d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		private void REPAVUKULBU(Exception a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	internal class GTZHIVMIANJ : TEMIHFVRWLU
	{
		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public override AutosaveVersion JXCKEWUGMUT
		{
			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x1532930", Offset = "0x1531730", VA = "0x181532930", Slot = "8")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x8E14B20", Offset = "0x8E13920", VA = "0x188E14B20")]
		public GTZHIVMIANJ([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x8E13F30", Offset = "0x8E12D30", VA = "0x188E13F30")]
		private void DOEATAXRGYR(AutosaveType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x8E14890", Offset = "0x8E13690", VA = "0x188E14890", Slot = "9")]
		internal override void XJVIRUGYIDV(Stream a, long b, long c, RoomSerializedData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x8E13FB0", Offset = "0x8E12DB0", VA = "0x188E13FB0", Slot = "10")]
		internal override bool EREMQFBKAEO(Stream a, long b, long c, HileFunc d, [Out] RoomSerializedData e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x8E147B0", Offset = "0x8E135B0", VA = "0x188E147B0", Slot = "11")]
		protected override FileInfo XIERRJFIDZL(long a, long b, AutosaveType c, DirectoryAccessMode d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x8E146B0", Offset = "0x8E134B0", VA = "0x188E146B0", Slot = "12")]
		protected override DirectoryInfo KOGBROYXGGR(AutosaveType a, DirectoryAccessMode b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	internal sealed class GTUALOSKRCA : TEMIHFVRWLU
	{
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		private static readonly byte[] NFCNRPBPDKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000809")]
		private readonly byte[] SVQXZWUDDDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400080A")]
		private readonly byte[] VXNHRBJTQLB;

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public override AutosaveVersion JXCKEWUGMUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x1ADA990", Offset = "0x1AD9790", VA = "0x181ADA990", Slot = "8")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x8E13E00", Offset = "0x8E12C00", VA = "0x188E13E00")]
		public GTUALOSKRCA([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x8E13970", Offset = "0x8E12770", VA = "0x188E13970", Slot = "9")]
		internal override void XJVIRUGYIDV(Stream a, long b, long c, RoomSerializedData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x8E12CD0", Offset = "0x8E11AD0", VA = "0x188E12CD0", Slot = "10")]
		internal override bool EREMQFBKAEO(Stream a, long b, long c, HileFunc d, [Out] RoomSerializedData e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x8E12C10", Offset = "0x8E11A10", VA = "0x188E12C10")]
		private void BMFKPJUUJQD(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x8E13850", Offset = "0x8E12650", VA = "0x188E13850", Slot = "11")]
		protected override FileInfo XIERRJFIDZL(long a, long b, AutosaveType c, DirectoryAccessMode d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x8E13740", Offset = "0x8E12540", VA = "0x188E13740", Slot = "12")]
		protected override DirectoryInfo KOGBROYXGGR(AutosaveType a, DirectoryAccessMode b)
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
	internal class MIPRWIYZRPP : WUPSZFNVXTG
	{
		[Cpp2IlInjected.Token(Token = "0x20001D0")]
		[CompilerGenerated]
		private sealed class OLZEAAVZERL : IEnumerable<JFLMODKHJZH>, IEnumerable, IEnumerator<JFLMODKHJZH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000817")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000818")]
			private JFLMODKHJZH QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000819")]
			private int DQRPPGNAYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400081A")]
			public MIPRWIYZRPP WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400081B")]
			private AutosaveType UOAQWJAFGSF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400081C")]
			public AutosaveType VCVAVSCNFLY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400081D")]
			private AutosaveVersion[] ZQJSAWQBUYL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400081E")]
			private int ZQOYYDJZEJU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400081F")]
			private IEnumerator<JFLMODKHJZH> ZQUFVKDWNVD;

			[Cpp2IlInjected.Token(Token = "0x170000F8")]
			private JFLMODKHJZH KKOTPPAIXYN
			{
				[Cpp2IlInjected.Token(Token = "0x6000740")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F9")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000742")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
			[DebuggerHidden]
			public OLZEAAVZERL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x8E156F0", Offset = "0x8E144F0", VA = "0x188E156F0", Slot = "7")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x8E159F0", Offset = "0x8E147F0", VA = "0x188E159F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x8E15780", Offset = "0x8E14580", VA = "0x188E15780")]
			private void LKISUJFCFYE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x8E15670", Offset = "0x8E14470", VA = "0x188E15670", Slot = "10")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(RVA = "0x8E15CD0", Offset = "0x8E14AD0", VA = "0x188E15CD0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JFLMODKHJZH> VLEBXNKBTUW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x8E15CD0", Offset = "0x8E14AD0", VA = "0x188E15CD0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000811")]
		private readonly AutosaveVersion[] UMMJFHYKCRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		private readonly Dictionary<AutosaveVersion, WUPSZFNVXTG> GAYSMPCLVWO;

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public AutosaveVersion JXCKEWUGMUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x8E152C0", Offset = "0x8E140C0", VA = "0x188E152C0", Slot = "4")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x8E152F0", Offset = "0x8E140F0", VA = "0x188E152F0")]
		[UnityEngine.Scripting.Preserve]
		public MIPRWIYZRPP(params WUPSZFNVXTG[] versionImpls)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x8E15170", Offset = "0x8E13F70", VA = "0x188E15170", Slot = "5")]
		public bool XEABNMZUPBY(long a, long b, AutosaveType c, [Out] JFLMODKHJZH d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x8E14F30", Offset = "0x8E13D30", VA = "0x188E14F30")]
		private void VXJYQJWRPTY(int a, long b, long c, AutosaveType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x8E14EB0", Offset = "0x8E13CB0", VA = "0x188E14EB0", Slot = "6")]
		[IteratorStateMachine(typeof(OLZEAAVZERL))]
		public IEnumerable<JFLMODKHJZH> TPGZIFIWUVM(AutosaveType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x8E14DC0", Offset = "0x8E13BC0", VA = "0x188E14DC0", Slot = "7")]
		public JFLMODKHJZH QGNISEQBTGA(long a, long b, RoomSerializedData c, AutosaveType d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	internal static class AIRYMSPJUZH
	{
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x8E10370", Offset = "0x8E0F170", VA = "0x188E10370")]
		internal static byte[] ComputeHash(byte[] bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x8E10430", Offset = "0x8E0F230", VA = "0x188E10430")]
		public static void MYMBGTRMKOA(Stream a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x8E104B0", Offset = "0x8E0F2B0", VA = "0x188E104B0")]
		public static bool TPPVVBZMEOL(Stream a, long b, HileFunc c, [Out] byte[] d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D2")]
	internal sealed class SXEHGWDSTLE : JFLMODKHJZH, IEquatable<JFLMODKHJZH>, IEquatable<SXEHGWDSTLE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		private readonly TEMIHFVRWLU IDJOPMBINNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		public readonly FileInfo APSTIUFQJXH;

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public AutosaveVersion JXCKEWUGMUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x86E0A30", Offset = "0x86DF830", VA = "0x1886E0A30", Slot = "9")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		public DateTime LHAIOJWNTAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x8E18E00", Offset = "0x8E17C00", VA = "0x188E18E00", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x8E18E90", Offset = "0x8E17C90", VA = "0x188E18E90")]
		public SXEHGWDSTLE(TEMIHFVRWLU a, FileInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x8E18D50", Offset = "0x8E17B50", VA = "0x188E18D50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x8E189B0", Offset = "0x8E177B0", VA = "0x188E189B0", Slot = "5")]
		public void Delete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x8E18D10", Offset = "0x8E17B10", VA = "0x188E18D10", Slot = "6")]
		public bool INJSNXWRDEQ(long a, long b, [Out] RoomSerializedData c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x8E18B30", Offset = "0x8E17930", VA = "0x188E18B30", Slot = "7")]
		public bool Equals(JFLMODKHJZH other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x8E18A70", Offset = "0x8E17870", VA = "0x188E18A70", Slot = "8")]
		public bool Equals(SXEHGWDSTLE other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x8E18BA0", Offset = "0x8E179A0", VA = "0x188E18BA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x8E18C80", Offset = "0x8E17A80", VA = "0x188E18C80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D3")]
	public delegate void HileFunc(PlayerReporting.HileType hileType, string message);
	[Cpp2IlInjected.Token(Token = "0x20001D4")]
	internal interface WUPSZFNVXTG
	{
		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		AutosaveVersion JXCKEWUGMUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XEABNMZUPBY(long a, long b, AutosaveType c, [Out] JFLMODKHJZH d);

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IEnumerable<JFLMODKHJZH> TPGZIFIWUVM(AutosaveType a);

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(Slot = "3")]
		JFLMODKHJZH QGNISEQBTGA(long a, long b, RoomSerializedData c, AutosaveType d);
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
