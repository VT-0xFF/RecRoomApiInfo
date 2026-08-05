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
using RecRoom.UGCLocalization;
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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x92566A0", Offset = "0x92552A0", VA = "0x1892566A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class LYPKNRFXAJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal Task<RoomLoadDetails> JKWHUWIYVXL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal Task DSGUOKEIXPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal EYSFXLFSQHI BFHGPLOLKZH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
	public LYPKNRFXAJP()
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
		[Cpp2IlInjected.Address(RVA = "0x9255D80", Offset = "0x9254980", VA = "0x189255D80", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x92728A0", Offset = "0x92714A0", VA = "0x1892728A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9257AE0", Offset = "0x92566E0", VA = "0x189257AE0")]
		public RecoverableRoomOperationException(string message, Exception innerException)
		{
		}
	}
}
namespace RoomOperation.OperationLogic.Restore
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal class THMTBRUQPBT : PDQGODWVUIQ
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
			[Cpp2IlInjected.Address(RVA = "0x9267A70", Offset = "0x9266670", VA = "0x189267A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9267C80", Offset = "0x9266880", VA = "0x189267C80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9268CC0", Offset = "0x92678C0", VA = "0x189268CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9268F00", Offset = "0x9267B00", VA = "0x189268F00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		[UnityEngine.Scripting.Preserve]
		public THMTBRUQPBT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x925EF10", Offset = "0x925DB10", VA = "0x18925EF10", Slot = "4")]
		[AsyncStateMachine(typeof(<GetSubRoomDataHistory>d__1))]
		public Task<IReadOnlyList<SubRoomDataSaveDTO>> KODDRDAMVMI(long a, long b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x925F030", Offset = "0x925DC30", VA = "0x18925F030", Slot = "5")]
		[AsyncStateMachine(typeof(<GetAccountsBulk>d__2))]
		public Task<IReadOnlyList<Account>> SDIWXLTLNLJ(IReadOnlyList<int> a, [Optional] CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface KQPRAAXJCWH : IEquatable<KQPRAAXJCWH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		int UEBNVDNBXCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[CanBeNull]
		Account BOJMMAPNEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		DateTime EVZYDYYEQEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		PlatformType? CGXGACZQAAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		DeviceClass? UZDJPWROFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		[CanBeNull]
		RestoreOptionTypes COREQRTUPPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<DRXWOXZYIVH> EBCKPILRXWR();
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
	public interface PDQGODWVUIQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IReadOnlyList<SubRoomDataSaveDTO>> KODDRDAMVMI(long a, long b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<IReadOnlyList<Account>> SDIWXLTLNLJ(IReadOnlyList<int> a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class UBGLTLMXSGU
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private sealed class ZPLDUVRXYAP : KQPRAAXJCWH, IEquatable<KQPRAAXJCWH>
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
				public AsyncTaskMethodBuilder<DRXWOXZYIVH> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public ZPLDUVRXYAP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				private GXVXXMOPOVU <roomManager>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				private TaskAwaiter<RoomDetailsDTO> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				private TaskAwaiter<DRXWOXZYIVH> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x92694F0", Offset = "0x92680F0", VA = "0x1892694F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x9269A70", Offset = "0x9268670", VA = "0x189269A70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly SubRoomDataSaveDTO XCBPRUWDUPP;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int UEBNVDNBXCV
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public Account BOJMMAPNEOM
			{
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private DateTime XJYSBQWXFUE
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x9272510", Offset = "0x9271110", VA = "0x189272510", Slot = "6")]
				get
				{
					return default(DateTime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public PlatformType? CGXGACZQAAK
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x3060170", Offset = "0x305ED70", VA = "0x183060170", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public DeviceClass? UZDJPWROFIJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x9272820", Offset = "0x9271420", VA = "0x189272820", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public RestoreOptionTypes COREQRTUPPG
			{
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "10")]
				get
				{
					return default(RestoreOptionTypes);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9272570", Offset = "0x9271170", VA = "0x189272570", Slot = "9")]
			[AsyncStateMachine(typeof(<Restore>d__13))]
			public Task<DRXWOXZYIVH> EBCKPILRXWR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9272840", Offset = "0x9271440", VA = "0x189272840")]
			public ZPLDUVRXYAP(int a, Account b, SubRoomDataSaveDTO c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9272670", Offset = "0x9271270", VA = "0x189272670", Slot = "11")]
			public bool Equals(KQPRAAXJCWH other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9272700", Offset = "0x9271300", VA = "0x189272700", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9272530", Offset = "0x9271130", VA = "0x189272530")]
			private bool CRTXNMFHIYV(ZPLDUVRXYAP a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x92727A0", Offset = "0x92713A0", VA = "0x1892727A0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private sealed class TORUQSWNDMC : KQPRAAXJCWH, IEquatable<KQPRAAXJCWH>
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
				public AsyncTaskMethodBuilder<DRXWOXZYIVH> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public TORUQSWNDMC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				private TaskAwaiter<DRXWOXZYIVH> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x9269AE0", Offset = "0x92686E0", VA = "0x189269AE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x9269F90", Offset = "0x9268B90", VA = "0x189269F90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly LYUZIEXLVDR JDBWCFQYPHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly PlatformType RGGYWPKGNAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly DeviceClass XRXEUDMVSNW;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int UEBNVDNBXCV
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x925F680", Offset = "0x925E280", VA = "0x18925F680", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Account BOJMMAPNEOM
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x925F930", Offset = "0x925E530", VA = "0x18925F930", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private DateTime XJYSBQWXFUE
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x925F4E0", Offset = "0x925E0E0", VA = "0x18925F4E0", Slot = "6")]
				get
				{
					return default(DateTime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public PlatformType? CGXGACZQAAK
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x925F810", Offset = "0x925E410", VA = "0x18925F810", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public DeviceClass? UZDJPWROFIJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x925F8E0", Offset = "0x925E4E0", VA = "0x18925F8E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public RestoreOptionTypes COREQRTUPPG
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0xDA5DB0", Offset = "0xDA49B0", VA = "0x180DA5DB0", Slot = "10")]
				get
				{
					return default(RestoreOptionTypes);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x24955C0", Offset = "0x24941C0", VA = "0x1824955C0")]
			public TORUQSWNDMC(LYUZIEXLVDR a, PlatformType b, DeviceClass c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x925F590", Offset = "0x925E190", VA = "0x18925F590", Slot = "9")]
			[AsyncStateMachine(typeof(<Restore>d__14))]
			public Task<DRXWOXZYIVH> EBCKPILRXWR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x925F6C0", Offset = "0x925E2C0", VA = "0x18925F6C0", Slot = "11")]
			public bool Equals(KQPRAAXJCWH other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x925F760", Offset = "0x925E360", VA = "0x18925F760", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x925F530", Offset = "0x925E130", VA = "0x18925F530")]
			private bool CRTXNMFHIYV(TORUQSWNDMC a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x925F860", Offset = "0x925E460", VA = "0x18925F860", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private sealed class LANGXTMEURB : KQPRAAXJCWH, IEquatable<KQPRAAXJCWH>
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
				public AsyncTaskMethodBuilder<DRXWOXZYIVH> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				private TaskAwaiter<DRXWOXZYIVH> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x9269D30", Offset = "0x9268930", VA = "0x189269D30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x926A000", Offset = "0x9268C00", VA = "0x18926A000", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly Account AUAATDRRFNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private readonly PlatformType RGGYWPKGNAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private readonly DeviceClass XRXEUDMVSNW;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public int UEBNVDNBXCV
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x9255B40", Offset = "0x9254740", VA = "0x189255B40", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			[NotNull]
			public Account BOJMMAPNEOM
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private DateTime XJYSBQWXFUE
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "6")]
				get
				{
					return default(DateTime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			public PlatformType? CGXGACZQAAK
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x9255C50", Offset = "0x9254850", VA = "0x189255C50", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public DeviceClass? UZDJPWROFIJ
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x9255D30", Offset = "0x9254930", VA = "0x189255D30", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public RestoreOptionTypes COREQRTUPPG
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "10")]
				get
				{
					return default(RestoreOptionTypes);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x24955C0", Offset = "0x24941C0", VA = "0x1824955C0")]
			public LANGXTMEURB(Account a, PlatformType b, DeviceClass c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9255A70", Offset = "0x9254670", VA = "0x189255A70", Slot = "9")]
			[AsyncStateMachine(typeof(<Restore>d__14))]
			public Task<DRXWOXZYIVH> EBCKPILRXWR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9255B60", Offset = "0x9254760", VA = "0x189255B60", Slot = "11")]
			public bool Equals(KQPRAAXJCWH other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9255BD0", Offset = "0x92547D0", VA = "0x189255BD0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9255CA0", Offset = "0x92548A0", VA = "0x189255CA0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x92559B0", Offset = "0x92545B0", VA = "0x1892559B0")]
			private bool CRTXNMFHIYV(LANGXTMEURB a)
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
			public UBGLTLMXSGU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private TaskAwaiter<IReadOnlyList<Account>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9260600", Offset = "0x925F200", VA = "0x189260600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9260FB0", Offset = "0x925FBB0", VA = "0x189260FB0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<IList<KQPRAAXJCWH>> <>t__builder;

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
			public UBGLTLMXSGU <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9267CF0", Offset = "0x92668F0", VA = "0x189267CF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9268C50", Offset = "0x9267850", VA = "0x189268C50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly UNOVSVGHVVG GCUMTNTJLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly PDQGODWVUIQ MWZKSVOWNTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly OWYEAKDBTGI JCBNFWQTOEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly UBZYVBBYOSS<(long, long), IReadOnlyList<SubRoomDataSaveDTO>> TNVCBOLTFGC;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9271A80", Offset = "0x9270680", VA = "0x189271A80")]
		[UnityEngine.Scripting.Preserve]
		public UBGLTLMXSGU([Inject(null)] PDQGODWVUIQ roomHistoryProvider, [Inject(null)] OWYEAKDBTGI roomAutosaveService, [Inject(null)] UNOVSVGHVVG platformAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9271790", Offset = "0x9270390", VA = "0x189271790")]
		[AsyncStateMachine(typeof(<GetOrderedRestoreOptions>d__5))]
		public Task<IList<KQPRAAXJCWH>> IZNGXXRRNOE(long a, long b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x92718E0", Offset = "0x92704E0", VA = "0x1892718E0")]
		private bool RPPFTPNMRGR(DateTime? a, long b, long c, [Out] LYUZIEXLVDR d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9271680", Offset = "0x9270280", VA = "0x189271680")]
		[AsyncStateMachine(typeof(<CombineHistoryWithAccounts>d__7))]
		private Task<IReadOnlyList<(int, Account, SubRoomDataSaveDTO)>> EVALSHQWIHI(IReadOnlyList<SubRoomDataSaveDTO> a)
		{
			return null;
		}
	}
}
namespace AutoSaves
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface OWYEAKDBTGI
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<LYUZIEXLVDR> WFHBXMFTDNA;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool DPTUSNTNQGJ(long a, long b, RoomSerializedData c, AutosaveType d);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ROUUTPENJPF(long a, long b, [Out] LYUZIEXLVDR c);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool GBEJNGIQRAQ(long a, long b, AutosaveType c, [Out] LYUZIEXLVDR d);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JPOWBEOUDZV(long a, long b);
	}
}
namespace RecRoom.RoomLoading
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal interface AEVYTOMCPYJ : CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool GXGBQZBNBOH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		Task VBWIHEMJBGH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LYXOUHPEQQC(Task a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	internal interface UDGICGGHRKN : CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<DRXWOXZYIVH> RequestRestoreAutosave(LYUZIEXLVDR autosaveRecordInfo);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task ZEXCXKPDZPR(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal interface ATUGFAVOUUQ : CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		IOXWNGHJERA IOXWNGHJERA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void VSEAXXDIZDX();

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SZNWDBEZETL();
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal interface CZQABOPRBUR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(FQSENOYUOAD roomManager);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal interface GBFVOIKQDIE
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		TimeSpan ZKKWGZPMRQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		TimeSpan YZAJQDWHJPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		TimeSpan QVTFHFVZZAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		TimeSpan NJJAXJLXXBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool NLWNOHWGGFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool NPLDSVGWTII
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool KCRCRXYGKDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		int RJTYDHFTADF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool SMLJAGUHQXY
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool SLGOPLKFEKL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool YZOAQBDGVPJ
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
		[Cpp2IlInjected.Address(RVA = "0x9258390", Offset = "0x9256F90", VA = "0x189258390")]
		public RoomEvent(long superRoomId, long subRoomId, RoomEventType type, [CanBeNull] Exception eventException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9258340", Offset = "0x9256F40", VA = "0x189258340")]
		public static RoomEvent From(RoomInstance room, RoomEventType type, [Optional] Exception eventException)
		{
			return default(RoomEvent);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void RoomEventHandler(RoomEvent roomEvent);
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal interface ZCMLIFFPINZ : CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event RoomEventHandler NGEZEYTZKQH;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event RoomEventHandler ZPNWNWURYQD;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event RoomEventHandler HBODOXTEQIH;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<RequestOperationType, bool> ORSJAMRJMLF;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void GERMIPWBRFB(RoomEvent a);

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void POEYUTBGTST(RoomEvent a);

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void HDRTDSCBUDZ(RoomEvent a);

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void BKBZFZKUMQT(RequestOperationType a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal interface SDSVAEOGYCZ : CZQABOPRBUR, IDisposable, XAYBYAVIJQY
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool KVJZMXNRQGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JQWHRDNOVJN();
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal interface BLLZWPKKVFX : CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		TaskStatus WRRYNRJKNRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task JoinRoomInstance(RoomInstance targetInstance, YKIRYHCVYIF customRoomLoadPayload, CancellationToken externalToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class MZZSNKKNTHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x92565C0", Offset = "0x92551C0", VA = "0x1892565C0")]
		public static bool KSHSDJKMEID(this BLLZWPKKVFX a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate Task InLoadedRoomTaskBuilder(CancellationToken token, int roomTotalVersion, AccountRoleType localPlayerAccountRoleType);
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal interface EHHFOATIKRW : CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool MJOIGBTHAMY(InLoadedRoomTaskBuilder a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal interface FQSENOYUOAD : GXVXXMOPOVU, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		CancellationToken YGIIXQBRKRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		DiContainer ZKAOXXLCNTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		ZUUCGYXVQOS UXELQQOUBIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		IQKUWZDMPPA LBXPIXUUTIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		QGGDGVMYJMC WYXWMMZBGZF
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		VRFENSRWBLP XZFYBEXXXFE
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		RTJBHHWUTVH GSVKWWIMCHS
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		PXRJMKVWQUR MVVNGVLUMBO
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		VNEBTMGFLNZ VNEBTMGFLNZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		AEVYTOMCPYJ HXZELTLKPXE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		UDGICGGHRKN UCUNMITUWNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		ZCMLIFFPINZ IYASBWMBMUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		SDSVAEOGYCZ MPJKPIWXMEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		BLLZWPKKVFX TFWZUHCGLHW
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		EHHFOATIKRW JWULXERQNCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		CQQMUBQBNJB AMBHKUCCVFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		WMUJUOJJJZK CTLHVRNNNXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		LWSFUGCVEAF IMCLIXOQRLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		MINKQEQNUMI UTGJFARZHRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		JOBTRQDNNUS SLUBFJDZDSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		BFALSPVIUPM EVHDZQFOMTN
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		EOTZPIOIQQD VXLTIGUKVCA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		DTMXXXKYTWN MNIUXBYBLSC
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		AVYQDCBEUCZ NLDNOCXWATQ
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		OUWABYBHYDP SCGBIGNGOBC
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		ATUGFAVOUUQ OMUZLPYMQHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		GBFVOIKQDIE JLJDOZDIUIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		PVUBCAYTCUW ZVQZCDSPZRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		OWYEAKDBTGI JQODMKCQHCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		IAYHKPDKXHL WQNVIXPCOZG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		QGKXFWXFKWC DSTGREOQWES
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		EJOQRXHTGDS PDIZCTALMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		ZYFLTPZZNZS RZGTBNMNYYH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		new bool IEBATEKSGFA
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
		void GHAEYURLNVT(YKIRYHCVYIF a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal interface CQQMUBQBNJB : CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PendingRequest Add(Guid operationId);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool Remove(Guid operationId);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool YTBDRCZVNLT(Guid a, Task b);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KPJWGNKCLIZ(Guid a, DRXWOXZYIVH b);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<(DRXWOXZYIVH, Task)> NRPPWKDHGNU(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal interface UNYNNFENUBZ : CZQABOPRBUR, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal interface WMUJUOJJJZK : CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GGKZIQIMBOO(BURCCBMBLWO a);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OIGXGGPCDDL(BURCCBMBLWO a);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<RoomOperationType> LLGUYHNIJLM(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal interface LWSFUGCVEAF : CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PendingRequest JOYMIHJDPUZ(BURCCBMBLWO a);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OOIAELZELOS(Guid a, Task b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal interface MINKQEQNUMI : CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<DRXWOXZYIVH> UTGJFARZHRZ(BURCCBMBLWO a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal interface JOBTRQDNNUS : CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<RoomLoadRequestPayload> ESPDQTPUQOZ(StackTimer<string>.YOQUQHZDBKW a, RoomInstance b, CancellationToken c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal interface EOTZPIOIQQD : CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		DRXWOXZYIVH BTQCCKQFIAF(WJBKOLNRRJE a);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task RequestSaveRoomToDisk(string path);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal interface BFALSPVIUPM : CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<BURCCBMBLWO> OQDYMYLWFXS(BURCCBMBLWO a, DGBVEOGIEQF b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<BURCCBMBLWO> TZCADQIDSFQ(CancellationToken a, DGBVEOGIEQF b);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		XMOUJWJJAGN PIJJFUOSCAR(UTQHQVVVWVQ a, StackTimer<string>.YOQUQHZDBKW b);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		XMOUJWJJAGN NNYZGCLOEKM(UTQHQVVVWVQ a, StackTimer<string>.YOQUQHZDBKW b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal interface DTMXXXKYTWN : CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		DRXWOXZYIVH DIAXXNSMZND(WJBKOLNRRJE a, RoomOperationType b);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DRXWOXZYIVH PZBNXEIFMSQ(WJBKOLNRRJE a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public interface STLQTWQCFJP
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		const int ZQCLLBWGMTJ = 1000;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		IReadOnlyDictionary<Guid, RoomAssetDTO> QFUAMABDIGT
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		Action EDKHKTQGGJE
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
		IReadOnlyList<Guid> CSODKXCCUHM();

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task UGAAULQQDXM([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task KOUXJFUMTLU([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface AVYQDCBEUCZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OQQYXLPZMIJ(KKASIZQFVPH a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void YXCNGVLHFWW(KKASIZQFVPH a);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HDQYISMGKTU(KKASIZQFVPH a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PECYVVWYLTU(KKASIZQFVPH a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class KKASIZQFVPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly RoomInstance HWKYBLULAPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Dictionary<string, string> CVYXRONGUXK;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public StackTimer<string> LPZPMSPOJAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public KKASIZQFVPH(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9255850", Offset = "0x9254450", VA = "0x189255850")]
		public KKASIZQFVPH DQUIKYADKRL(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9255920", Offset = "0x9254520", VA = "0x189255920")]
		public bool OAZBQELLUTX([Out] IEnumerable<KeyValuePair<string, string>> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8170160", Offset = "0x816ED60", VA = "0x188170160")]
		public KKASIZQFVPH VLOWMZYMNDE(StackTimer<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface PVUBCAYTCUW
	{
		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		bool DHDYRRSKCIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		string QPRORNXJDHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool RAJTZQWJSRX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void UCRKXUDNQVX();

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		QZLEUZSCQDU HTFOZFAQOEQ(long a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		RIYLHVUCOKK<FilenameWithHash, SuperRoomData> YRDPRGXHGXK(long a);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		RIYLHVUCOKK<FilenameWithHash, PersistedRoomData> WHZFCNTGOVY(long a);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		RIYLHVUCOKK<long, VMMHASWVFTD> QFLFWINYVUK();

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task<IReadOnlyCollection<BakedUnitySubAssetDTO>> XUWUJENQZWI(long a, IReadOnlyCollection<BakedUnitySubAssetDTO> b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool PAJEGUKAORN(long a, [Out] bool b);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<bool> IIAHWMIIPZT(byte[] a, byte[] b, IReadOnlyCollection<Guid> c, CancellationToken d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface YCKRWIQEMHS
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
	public interface GXVXXMOPOVU : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		bool KSHSDJKMEID
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool VAUJUSCOBJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool IEBATEKSGFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		YCKRWIQEMHS WOHDSYWOTHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		YKIRYHCVYIF IBFPDKLUQDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		bool WQITSHKSWJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event RoomEventHandler NGEZEYTZKQH;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event RoomEventHandler ZPNWNWURYQD;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RoomEventHandler HBODOXTEQIH;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<RequestOperationType, bool> ORSJAMRJMLF;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void JQWHRDNOVJN();

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		QLIAHHCFMBM CGCAKGTMNQM();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "13")]
		TQEYZQHZQJX BZVKPLSAIHW();

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "15")]
		Task CTSHMMZKPAG(int a, RoomSaveRequestPayload b, Func<RoomSerializedData, RoomSerializedData> c);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Task<DRXWOXZYIVH> RequestRestoreAutosave(LYUZIEXLVDR autosaveRecord);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Task ZEXCXKPDZPR(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface VRFENSRWBLP
	{
		[Cpp2IlInjected.Token(Token = "0x17000057")]
		bool BAJOIVRIWYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool JICXMXHNRUO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		Guid? TICLCDWLVEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QYKYBDUOILQ(Scene a);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task INDXKYWMYFY(HLVGJCQLOVH a, IReadOnlyList<HLVGJCQLOVH> b, IReadOnlyList<HLVGJCQLOVH> c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SUGAFTVMTRZ(Guid a, IReadOnlyList<Guid> b, UnitySubAssetKind c, [Optional] object d);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task UZRLNIQBARR(IReadOnlyList<Guid> a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		LJMQZKNEKLZ JNZBIKJXRMZ();

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Task CPYBALLPAOQ();

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void HIVBSLJWOMF(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task AZLIBKMNBNI();
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface QGGDGVMYJMC
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		HOAWKWPUPAK YDVANLETWMX
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		bool CXLPLKBFOWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		bool HNMYZEYJKEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		bool OOYHVNGNFQH
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(Slot = "15")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		bool OKWQZKKNAVG
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		int SIUYDGLHIUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		bool QDVEDJHOVLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(Slot = "52")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool AZIKXVIKLEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(Slot = "60")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		int ERXDNPGFESL
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(Slot = "61")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		int ESCKKWACODU
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "62")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		bool DJUYBMPWUCN
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "63")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		bool VFDFDPTFZKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "68")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		bool VFIMAWNDIVY
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "69")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		float ILTXWVEJENA
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "72")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action<float> SJVHIHPKQPI;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DiContainer MZXETQTKFHH(DiContainer a);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FTLHNLWHLGA(DiContainer a);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HHHXESIZSFG();

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task ShowLoadingScreen(StackTimer<string>.YOQUQHZDBKW loadingScreenScope, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void XUDEUCYBDSS(float a);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void MYZLVDKMDMV(string a);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IReadOnlyList<FDPRMABNSIO> SNXMYJUCNJD();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IDisposable ASDQKKPVUON(object a, FDPRMABNSIO b);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "10")]
		IReadOnlyList<EmptySceneHandler> QPRNBJYKBNB();

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "11")]
		IDisposable ZXFOHROHILQ(EmptySceneHandler a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SuperRoomData BBLESQEHESN(IEnumerable<ABLNPBVPOUZ> a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void KRGNPHPOAPN(int a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task GYVSILFOCOO();

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void CRJFZMRROUM();

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "20")]
		bool DECFFIAWZJH();

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "21")]
		Task XVQTRCJKSUK(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Task JANJDDZXACU(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "23")]
		Task<LoadRecoveryAutosaveResponse> MZQKIDRZMWM(DateTime a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Task<bool> NACWRHUTETV(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void OOYYWVAPMGO(string a = "", float b = 3f);

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "27")]
		RoomSerializedMetadata ICPZKHFKMHJ(RoomSaveOptions a, SerializeType b, PersistedRoomData c, IEnumerable<PersistenceView> d, ELUDPWHKJWU e);

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void DIIVBDPRDKZ(PersistedRoomData a);

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void WRGTZSLTQTA(ABLNPBVPOUZ a, [In] RoomSerializedMetadata metadata);

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Task RXNOLYUUPQS(PersistedRoomData a, bool b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Task ITFKOHUDFTD(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void VSLEAVVUJXE(long a, long b, RoomDetailsDTO c, SubRoomDataSaveDTO d, RoomSerializedData e, RoomSaveRequestPayload? roomSaveRequestPayload, RoomSaveAnalyticsInfo? f);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void YMQECICVKHZ(long a, long b, RoomSaveAnalyticsInfo? c);

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void WZBMCJDCETU(PersistenceView a);

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void POXTVBTCACH(string a, RoomInstance b, RoomDTO c, [Optional] string? fallbackReason, [Optional] string? fallbackFailureReason, [Optional] string? subReason);

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "36")]
		bool NLXMCYTJKOJ(PersistenceView a);

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "37")]
		bool KLLUDYGLAID(ABLNPBVPOUZ a, DEPRECATED_RoomPersistenceVersion b, [Out] PPKMOZLMJPM c);

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Task RUMWHLYLWWL(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "39")]
		void DSWTOTIULVR();

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "40")]
		IDisposable AQTBDVZSHUT();

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "41")]
		void TZQLXMMYJOL(PersistedRoomData a, DEPRECATED_RoomPersistenceVersion b);

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task<bool> RequestMasterSpawnNewLocalPlayer(ZUUCGYXVQOS networking, CancellationToken cancellationToken, StackTimer<string>.YOQUQHZDBKW stackTimer);

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "43")]
		void KFYBKLZFLJG(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<SaveSubRoomResponseDTO> CBPCTAQTPMN(SaveSubRoomRequest a);

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "45")]
		Task<RoomDetailsDTO> HIGGSCQBEOK(long a, bool b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task<SubRoomDataSaveWithUnityAssetsDTO> AXXVOPKHTSZ(long a, long b, long c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "47")]
		Task<SubRoomDataSaveDTO> SYFQWJLWCWK(long a, long b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "48")]
		Task<RoomLoadDTO> SQVXMSIWMPK(long a, Guid b, long? c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "49")]
		RIYLHVUCOKK<RoomLoadDTO, IEnumerable<RoomAssetData>> TUOYJXSKEUI();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "50")]
		Task<RemoteRunDTO> CHVSGQFONKX(string a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "51")]
		Task<RemoteRunDTO> TQSLGIMAMZY(string a, long b, long c, Guid? d, Storage.UploadFileResponseDTO e, Storage.UploadFileResponseDTO f, int g);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "53")]
		bool NSIPUDQETRM();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "54")]
		bool XNQQJIRHWJS();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "55")]
		bool WSVUPJUXDFY(IEnumerable<PPKMOZLMJPM> a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void BulkDestroy(List<GameObject> objectsToDestroy);

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "57")]
		float NULNMPVZHAX();

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "58")]
		Task<bool> GYMCWBWFAPH(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "59")]
		Task<Scene> DAOOPCSCDKJ(string a, LoadSceneMode b, bool c, StackTimer<string>.YOQUQHZDBKW d);

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void EnableDisableObjectModel(bool enabled);

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "65")]
		void BeginLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "66")]
		void EndLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "67")]
		void RWXXARPMBEF(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "73")]
		Task<Storage.UploadFileResponseDTO> UNMYDALJCKW(byte[] a, Storage.FileType b, MimeType c, [Optional] IReadOnlyCollection<string>? referencedFilenames, [Optional] string? filenameOverride);

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "74")]
		void BWCWINOVXCT(RoomInstance a);

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "75")]
		Task NHPGJTDIKRY(StackTimer<string>.YOQUQHZDBKW a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "76")]
		Task TriggerMClusterManager(StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "77")]
		Task TriggerScalabilityManager(StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "78")]
		Task TriggerClusterLodManager(StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "79")]
		IDisposable IBNKRYBHVPD();

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "80")]
		JCQFFOYMZSD QGDKZJLQGWI();

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "81")]
		Task HideLoadingScreen(CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface JCQFFOYMZSD
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task PNFHUANCLDJ(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
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
	public interface HOAWKWPUPAK
	{
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		RoomInstance PWHHKTQLYAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		RoomDetailsDTO NHSIIWPGQVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		SubRoomDTO YKDEBHGJVOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		bool YVOAWRIDQAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		bool LRRODQQBVAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		int OWHXFILEHNM
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action TEGHMRNQJFO;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<int> XMLSTICSWUT;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void HWOZDSDJZJM();

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Task<Matchmaking.ServerConnectionInfoDTO> GetServerConnectionInfo(long roomInstanceId, [Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Task<MatchmakingErrorCode> HHWGVBKEFJN(RoomInstance a, [Optional] YKIRYHCVYIF b);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		Task<MatchmakingErrorCode> VLKWIBBCRPX();

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Task PUPIENQJJOU();

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "15")]
		(RoomInstance, YKIRYHCVYIF) WXGMPBTIWGL();

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "16")]
		PlayerPresence JECVZLLGADQ();

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void RHTKSZRTGPT(long a);

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void HCZOITBWWAU(RoomInstance a, Matchmaking.GameJoinResult b, (int Major, int? Minor)? errorCode);
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface OUWABYBHYDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool YRQLYJIFGYS([Out] IEnumerable<int> a);

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KMQEZFKRMWE(Token a);

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WPOVESURCYV(Token a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface NZWGIJAAPSA
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string IZNCLSIPTTT(DRXWOXZYIVH a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface IKZJVKXHGKW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MKVCLHHBLSG(EXTZQLQPWJJ.ValidateOperation a);

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IPGNKZIEVJJ(EXTZQLQPWJJ.ValidateOperation a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface RTJBHHWUTVH : IKZJVKXHGKW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		DRXWOXZYIVH TVMUMNHUIYV(WJBKOLNRRJE a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public interface PXRJMKVWQUR : IKZJVKXHGKW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		DRXWOXZYIVH BTQCCKQFIAF(WJBKOLNRRJE a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public interface QZLEUZSCQDU
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<BZZBICGVUJE, UTITDXZLKVK>> BNULOHTFJPU(Guid? a, IReadOnlyCollection<BakedUnitySubAssetDTO> b, IReadOnlyCollection<BakedUnitySubAssetDTO> c, AssetBundleLoadSource d, long? e, long? f, RecNet.Core.OnDownloadProgressDelegate g, CancellationToken h, bool i = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class BZZBICGVUJE
	{
		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public HLVGJCQLOVH QRYXQJYWPNQ
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public IReadOnlyList<HLVGJCQLOVH> DZFMVHDRJBT
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public IReadOnlyList<HLVGJCQLOVH> QAATWJAQTRR
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xE3EF80", Offset = "0xE3DB80", VA = "0x180E3EF80")]
		public BZZBICGVUJE(HLVGJCQLOVH a, IReadOnlyList<HLVGJCQLOVH> b, IReadOnlyList<HLVGJCQLOVH> c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public interface RIYLHVUCOKK<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<Result<ParseResult<b>, UTITDXZLKVK>> TPFTLGKUVSN(a a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal sealed class RoomManager : FQSENOYUOAD, GXVXXMOPOVU, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class MIHRGVBGYOL : IEnumerable<CZQABOPRBUR>, IEnumerable, IEnumerator<CZQABOPRBUR>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private CZQABOPRBUR DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private int RPOQDRFWNXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public RoomManager VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			private CZQABOPRBUR PJBGOUTNRNM
			{
				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public MIHRGVBGYOL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x9256130", Offset = "0x9254D30", VA = "0x189256130", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x92564E0", Offset = "0x92550E0", VA = "0x1892564E0", Slot = "10")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x9256520", Offset = "0x9255120", VA = "0x189256520", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<CZQABOPRBUR> TCSOZPZSZXD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x9256520", Offset = "0x9255120", VA = "0x189256520", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct <RecRoom-RoomLoading-IRoomManager-RequestRestoreAutosave>d__169 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public AsyncTaskMethodBuilder<DRXWOXZYIVH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public RoomManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public LYUZIEXLVDR autosaveRecordInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private TaskAwaiter<DRXWOXZYIVH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x9268F70", Offset = "0x9267B70", VA = "0x189268F70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x92691F0", Offset = "0x9267DF0", VA = "0x1892691F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct <RecRoom-RoomLoading-IRoomManager-RunRecoveryAutosave>d__170 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public RoomManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x9269260", Offset = "0x9267E60", VA = "0x189269260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x9269490", Offset = "0x9268090", VA = "0x189269490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly CancellationTokenSource FPBBMGOHWAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly DiContainer container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool JDQGFFMCCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private LogFlagsToken VJQQCFDIUZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool VUGFMQPBKUH;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public ZUUCGYXVQOS UXELQQOUBIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xB13B40", Offset = "0xB12740", VA = "0x180B13B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public IQKUWZDMPPA LBXPIXUUTIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xB13180", Offset = "0xB11D80", VA = "0x180B13180", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xB131B0", Offset = "0xB11DB0", VA = "0x180B131B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public QGGDGVMYJMC WYXWMMZBGZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xB14930", Offset = "0xB13530", VA = "0x180B14930", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xB14940", Offset = "0xB13540", VA = "0x180B14940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public VRFENSRWBLP XZFYBEXXXFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xB13280", Offset = "0xB11E80", VA = "0x180B13280", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xB13B50", Offset = "0xB12750", VA = "0x180B13B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public RTJBHHWUTVH GSVKWWIMCHS
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xB13330", Offset = "0xB11F30", VA = "0x180B13330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public PXRJMKVWQUR MVVNGVLUMBO
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6C0", Offset = "0xB1C2C0", VA = "0x180B1D6C0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6A0", Offset = "0xB1C2A0", VA = "0x180B1D6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public YCKRWIQEMHS WOHDSYWOTHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0", Slot = "54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xB1D760", Offset = "0xB1C360", VA = "0x180B1D760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public VNEBTMGFLNZ VNEBTMGFLNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xB1D750", Offset = "0xB1C350", VA = "0x180B1D750", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xB1D7C0", Offset = "0xB1C3C0", VA = "0x180B1D7C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public AEVYTOMCPYJ HXZELTLKPXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xBD4170", Offset = "0xBD2D70", VA = "0x180BD4170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public UDGICGGHRKN UCUNMITUWNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6F0", Offset = "0xB1C2F0", VA = "0x180B1D6F0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xB1D720", Offset = "0xB1C320", VA = "0x180B1D720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public ZCMLIFFPINZ IYASBWMBMUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xB74D50", Offset = "0xB73950", VA = "0x180B74D50", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xB73950", Offset = "0xB72550", VA = "0x180B73950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public SDSVAEOGYCZ MPJKPIWXMEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xB1B710", Offset = "0xB1A310", VA = "0x180B1B710", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xB1B740", Offset = "0xB1A340", VA = "0x180B1B740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public BLLZWPKKVFX TFWZUHCGLHW
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xB74D40", Offset = "0xB73940", VA = "0x180B74D40", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xBD41C0", Offset = "0xBD2DC0", VA = "0x180BD41C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public EHHFOATIKRW JWULXERQNCV
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xF48A30", Offset = "0xF47630", VA = "0x180F48A30", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x15B4DF0", Offset = "0x15B39F0", VA = "0x1815B4DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public CQQMUBQBNJB AMBHKUCCVFM
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xBD41A0", Offset = "0xBD2DA0", VA = "0x180BD41A0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xC13AE0", Offset = "0xC126E0", VA = "0x180C13AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public UNYNNFENUBZ VFYBTPFYJIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xBD4160", Offset = "0xBD2D60", VA = "0x180BD4160", Slot = "62")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xBD4380", Offset = "0xBD2F80", VA = "0x180BD4380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public WMUJUOJJJZK CTLHVRNNNXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xBD4140", Offset = "0xBD2D40", VA = "0x180BD4140", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xC13B10", Offset = "0xC12710", VA = "0x180C13B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public LWSFUGCVEAF IMCLIXOQRLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xB1B7A0", Offset = "0xB1A3A0", VA = "0x180B1B7A0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xB1B720", Offset = "0xB1A320", VA = "0x180B1B720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public MINKQEQNUMI UTGJFARZHRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xBA7EA0", Offset = "0xBA6AA0", VA = "0x180BA7EA0", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xBA75B0", Offset = "0xBA61B0", VA = "0x180BA75B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public JOBTRQDNNUS SLUBFJDZDSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xBA7EC0", Offset = "0xBA6AC0", VA = "0x180BA7EC0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xBA7E00", Offset = "0xBA6A00", VA = "0x180BA7E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public BFALSPVIUPM EVHDZQFOMTN
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xBA7EB0", Offset = "0xBA6AB0", VA = "0x180BA7EB0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xBA74A0", Offset = "0xBA60A0", VA = "0x180BA74A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public EOTZPIOIQQD VXLTIGUKVCA
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xBA2840", Offset = "0xBA1440", VA = "0x180BA2840", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xBA29F0", Offset = "0xBA15F0", VA = "0x180BA29F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public DTMXXXKYTWN MNIUXBYBLSC
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xBB06C0", Offset = "0xBAF2C0", VA = "0x180BB06C0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xBA9D10", Offset = "0xBA8910", VA = "0x180BA9D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public AVYQDCBEUCZ NLDNOCXWATQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xBA4210", Offset = "0xBA2E10", VA = "0x180BA4210", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xBAF180", Offset = "0xBADD80", VA = "0x180BAF180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public OUWABYBHYDP SCGBIGNGOBC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xBA5E90", Offset = "0xBA4A90", VA = "0x180BA5E90", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xBA43A0", Offset = "0xBA2FA0", VA = "0x180BA43A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public ATUGFAVOUUQ OMUZLPYMQHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xB7E030", Offset = "0xB7CC30", VA = "0x180B7E030", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xBA4A40", Offset = "0xBA3640", VA = "0x180BA4A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public GBFVOIKQDIE JLJDOZDIUIH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xBA5F80", Offset = "0xBA4B80", VA = "0x180BA5F80", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xBA6190", Offset = "0xBA4D90", VA = "0x180BA6190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public PVUBCAYTCUW ZVQZCDSPZRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xC8F2C0", Offset = "0xC8DEC0", VA = "0x180C8F2C0", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xCCE3A0", Offset = "0xCCCFA0", VA = "0x180CCE3A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public OWYEAKDBTGI JQODMKCQHCL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xC088A0", Offset = "0xC074A0", VA = "0x180C088A0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public IAYHKPDKXHL WQNVIXPCOZG
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xC08550", Offset = "0xC07150", VA = "0x180C08550", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public QGKXFWXFKWC DSTGREOQWES
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xC8F330", Offset = "0xC8DF30", VA = "0x180C8F330", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public EJOQRXHTGDS PDIZCTALMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xC8F320", Offset = "0xC8DF20", VA = "0x180C8F320", Slot = "35")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public ZYFLTPZZNZS RZGTBNMNYYH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xC8EDD0", Offset = "0xC8D9D0", VA = "0x180C8EDD0", Slot = "36")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public YKIRYHCVYIF IBFPDKLUQDB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xC8E010", Offset = "0xC8CC10", VA = "0x180C8E010", Slot = "58")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xE01950", Offset = "0xE00550", VA = "0x180E01950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private bool DQTPCBUZHVN
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x1DF3B50", Offset = "0x1DF2750", VA = "0x181DF3B50", Slot = "59")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1F82E40", Offset = "0x1F81A40", VA = "0x181F82E40", Slot = "60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool SNSLHOMVQIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x925E370", Offset = "0x925CF70", VA = "0x18925E370", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool FKHWRNUHDEL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x925DCA0", Offset = "0x925C8A0", VA = "0x18925DCA0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private bool DQWEJCXJWBX
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x208E570", Offset = "0x208D170", VA = "0x18208E570", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private CancellationToken SJRSXVUJHCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x925D990", Offset = "0x925C590", VA = "0x18925D990", Slot = "4")]
			get
			{
				return default(CancellationToken);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private DiContainer TLDZQXZDKJE
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		private bool DQFGSHNBAQU
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x208E570", Offset = "0x208D170", VA = "0x18208E570", Slot = "37")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xF3B2B0", Offset = "0xF39EB0", VA = "0x180F3B2B0", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		private event RoomEventHandler JIQXYZKUSGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x925E3D0", Offset = "0x925CFD0", VA = "0x18925E3D0", Slot = "40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x925E4F0", Offset = "0x925D0F0", VA = "0x18925E4F0", Slot = "41")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event RoomEventHandler ZJWTXBYMEXU
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x925E490", Offset = "0x925D090", VA = "0x18925E490", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x925E0B0", Offset = "0x925CCB0", VA = "0x18925E0B0", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		private event RoomEventHandler FPLGIPIMOVS
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x925E720", Offset = "0x925D320", VA = "0x18925E720", Slot = "44")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x925E6C0", Offset = "0x925D2C0", VA = "0x18925E6C0", Slot = "45")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		private event Action<RequestOperationType, bool> RHKUXUJMYMC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x925E050", Offset = "0x925CC50", VA = "0x18925E050", Slot = "46")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x925E430", Offset = "0x925D030", VA = "0x18925E430", Slot = "47")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xE01950", Offset = "0xE00550", VA = "0x180E01950", Slot = "39")]
		public void GHAEYURLNVT(YKIRYHCVYIF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x925E7E0", Offset = "0x925D3E0", VA = "0x18925E7E0")]
		[UnityEngine.Scripting.Preserve]
		internal RoomManager([Inject(null)] DiContainer container, [Inject(null)] ZUUCGYXVQOS networking, [Inject(null)] IQKUWZDMPPA photonClient, [Inject(null)] QGGDGVMYJMC callbacks, [Inject(null)] VRFENSRWBLP assetBundleManager, [Inject(null)] RTJBHHWUTVH roomReloadValidation, [Inject(null)] PXRJMKVWQUR roomSaveValidation, [Inject(null)] VNEBTMGFLNZ debugRoomLoadInfo, [Inject(null)] AEVYTOMCPYJ activeTask, [Inject(null)] UDGICGGHRKN autosaves, [Inject(null)] ZCMLIFFPINZ events, [Inject(null)] SDSVAEOGYCZ fallbacks, [Inject(null)] BLLZWPKKVFX initialRoomLoad, [Inject(null)] EHHFOATIKRW inRoomTasks, [Inject(null)] CQQMUBQBNJB pendingRequests, [Inject(null)] UNYNNFENUBZ presenceUpdates, [Inject(null)] WMUJUOJJJZK receiveOperation, [Inject(null)] LWSFUGCVEAF requestHandler, [Inject(null)] MINKQEQNUMI requestOperation, [Inject(null)] JOBTRQDNNUS roomLoadRequest, [Inject(null)] EOTZPIOIQQD save, [Inject(null)] BFALSPVIUPM synchronization, [Inject(null)] DTMXXXKYTWN validation, [Inject(null)] AVYQDCBEUCZ roomJoinAnalytics, [Inject(null)] OUWABYBHYDP playerSynchronization, [Inject(null)] GBFVOIKQDIE config, [Inject(null)] PVUBCAYTCUW roomLoadDataProviderOverride, [Inject(null)] OWYEAKDBTGI autosaveService, [Inject(null)] IAYHKPDKXHL cameraFade, [Inject(null)] QGKXFWXFKWC errorRegistry, [Inject(null)] EJOQRXHTGDS onlineRestrictions, [Inject(null)] ZYFLTPZZNZS preEmptySceneHandler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x925E2D0", Offset = "0x925CED0", VA = "0x18925E2D0")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x925DD20", Offset = "0x925C920", VA = "0x18925DD20", Slot = "61")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x925E280", Offset = "0x925CE80", VA = "0x18925E280", Slot = "51")]
		private void ITOWLONDOUK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x925E110", Offset = "0x925CD10", VA = "0x18925E110", Slot = "52")]
		private QLIAHHCFMBM GRIMBISCWZV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x925DFD0", Offset = "0x925CBD0", VA = "0x18925DFD0", Slot = "53")]
		private TQEYZQHZQJX FUSGBOBQXZJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x925D9B0", Offset = "0x925C5B0", VA = "0x18925D9B0", Slot = "55")]
		public Task CTSHMMZKPAG(int a, RoomSaveRequestPayload b, Func<RoomSerializedData, RoomSerializedData> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x925E190", Offset = "0x925CD90", VA = "0x18925E190")]
		private FTXJDDMRWST IBBOVNBNIRU(int a, RoomSaveRequestPayload b, Func<RoomSerializedData, RoomSerializedData> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x925DEC0", Offset = "0x925CAC0", VA = "0x18925DEC0", Slot = "56")]
		[AsyncStateMachine(typeof(<RecRoom-RoomLoading-IRoomManager-RequestRestoreAutosave>d__169))]
		private Task<DRXWOXZYIVH> FCFRADNHGOD(LYUZIEXLVDR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x925E5D0", Offset = "0x925D1D0", VA = "0x18925E5D0", Slot = "57")]
		[AsyncStateMachine(typeof(<RecRoom-RoomLoading-IRoomManager-RunRecoveryAutosave>d__170))]
		private Task TMACQJUUHGY(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x925E550", Offset = "0x925D150", VA = "0x18925E550")]
		[IteratorStateMachine(typeof(MIHRGVBGYOL))]
		private IEnumerable<CZQABOPRBUR> SSIVXNATENJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x925E780", Offset = "0x925D380", VA = "0x18925E780")]
		[CompilerGenerated]
		private void ZJFRHNUXEHJ(CZQABOPRBUR a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class CameraFadeTimeoutException : TimeoutException
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F680", Offset = "0x1E0E280", VA = "0x181E0F680")]
		public CameraFadeTimeoutException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal class FallbackToBootScene : OISVPIVSSBN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct <RunFallback>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public AsyncTaskMethodBuilder<OISVPIVSSBN.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public HashSet<XAYBYAVIJQY.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public FallbackToBootScene <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x926D0D0", Offset = "0x926BCD0", VA = "0x18926D0D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x926D3E0", Offset = "0x926BFE0", VA = "0x18926D3E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly FQSENOYUOAD PXZRTZVOQOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly QGGDGVMYJMC CTKZLRUOMOT;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		private string DXHFACSLPJY
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x92540C0", Offset = "0x9252CC0", VA = "0x1892540C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		public FallbackToBootScene(FQSENOYUOAD roomManager, QGGDGVMYJMC callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x9253FB0", Offset = "0x9252BB0", VA = "0x189253FB0", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__6))]
		public Task<OISVPIVSSBN.Result> CZCLQCWZGIY(HashSet<XAYBYAVIJQY.Reason> a, CancellationToken b, XAYBYAVIJQY.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal class FallbackToOfflineDormRoom : JBACKNKNWLC, OISVPIVSSBN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct <RunFallback>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public AsyncTaskMethodBuilder<OISVPIVSSBN.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public FallbackToOfflineDormRoom <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public HashSet<XAYBYAVIJQY.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public XAYBYAVIJQY.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private RoomInstance <localRoomInstance>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private long <preFallbackInstance>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private bool <currentIsOffline>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<OISVPIVSSBN.Result> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x926B9A0", Offset = "0x926A5A0", VA = "0x18926B9A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x926CFF0", Offset = "0x926BBF0", VA = "0x18926CFF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly CNQMJDRALKE ADKFVQXQEVN;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		private string DXHFACSLPJY
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x92542C0", Offset = "0x9252EC0", VA = "0x1892542C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x9254370", Offset = "0x9252F70", VA = "0x189254370")]
		public FallbackToOfflineDormRoom([Inject(null)] FQSENOYUOAD roomManager, [Inject(null)] QGGDGVMYJMC callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9254170", Offset = "0x9252D70", VA = "0x189254170", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__5))]
		public Task<OISVPIVSSBN.Result> CZCLQCWZGIY(HashSet<XAYBYAVIJQY.Reason> a, CancellationToken b, XAYBYAVIJQY.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal class FallbackToOfflineMultiplayerOrientationSubRoom : JBACKNKNWLC, OISVPIVSSBN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct <RunFallback>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public AsyncTaskMethodBuilder<OISVPIVSSBN.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public FallbackToOfflineMultiplayerOrientationSubRoom <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public HashSet<XAYBYAVIJQY.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private TaskAwaiter<MatchmakingErrorCode> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private TaskAwaiter<OISVPIVSSBN.Result> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x926AF20", Offset = "0x9269B20", VA = "0x18926AF20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x926B930", Offset = "0x926A530", VA = "0x18926B930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		private string DXHFACSLPJY
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x9254590", Offset = "0x9253190", VA = "0x189254590", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		public FallbackToOfflineMultiplayerOrientationSubRoom(FQSENOYUOAD roomManager, QGGDGVMYJMC callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x9254440", Offset = "0x9253040", VA = "0x189254440", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__4))]
		public Task<OISVPIVSSBN.Result> CZCLQCWZGIY(HashSet<XAYBYAVIJQY.Reason> a, CancellationToken b, XAYBYAVIJQY.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal class FallbackToOnlineDormRoom : JBACKNKNWLC, OISVPIVSSBN
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public MatchmakingErrorCode AHGSEKQNDGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public RoomInstance PMAQTMSKJGT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public long BHLDHOVFAHJ;

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x9257170", Offset = "0x9255D70", VA = "0x189257170")]
			internal object QPPXFPTSNMU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x92571F0", Offset = "0x9255DF0", VA = "0x1892571F0")]
			internal object QPVECWNPWYD()
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
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder<OISVPIVSSBN.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public FallbackToOnlineDormRoom <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public HashSet<XAYBYAVIJQY.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private PYHWMDJZEDC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public XAYBYAVIJQY.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<MatchmakingErrorCode> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private TaskAwaiter<OISVPIVSSBN.Result> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x926C370", Offset = "0x926AF70", VA = "0x18926C370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x926D060", Offset = "0x926BC60", VA = "0x18926D060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly CNQMJDRALKE ADKFVQXQEVN;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private string DXHFACSLPJY
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x9254790", Offset = "0x9253390", VA = "0x189254790", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x9254840", Offset = "0x9253440", VA = "0x189254840")]
		public FallbackToOnlineDormRoom([Inject(null)] FQSENOYUOAD roomManager, [Inject(null)] QGGDGVMYJMC callbacks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x9254640", Offset = "0x9253240", VA = "0x189254640", Slot = "5")]
		[AsyncStateMachine(typeof(<RunFallback>d__5))]
		public Task<OISVPIVSSBN.Result> CZCLQCWZGIY(HashSet<XAYBYAVIJQY.Reason> a, CancellationToken b, XAYBYAVIJQY.Reason c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal abstract class JBACKNKNWLC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private struct <DisconnectFromRoomInstance>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public Log log;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public HashSet<XAYBYAVIJQY.Reason> fallbackTriggersToIgnore;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public JBACKNKNWLC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private List<XAYBYAVIJQY.Reason> <newDisconnectTriggers>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x92674F0", Offset = "0x92660F0", VA = "0x1892674F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x9267A10", Offset = "0x9266610", VA = "0x189267A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		protected readonly FQSENOYUOAD PXZRTZVOQOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		protected readonly QGGDGVMYJMC CTKZLRUOMOT;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		protected HOAWKWPUPAK YDVANLETWMX
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x9255800", Offset = "0x9254400", VA = "0x189255800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		public JBACKNKNWLC(FQSENOYUOAD a, QGGDGVMYJMC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x92556D0", Offset = "0x92542D0", VA = "0x1892556D0")]
		[AsyncStateMachine(typeof(<DisconnectFromRoomInstance>d__5))]
		protected Task DisconnectFromRoomInstance(Log log, HashSet<XAYBYAVIJQY.Reason> fallbackTriggersToIgnore, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class TOHLZSRVACB
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class QBWFFRHGRMS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public string TFNXWSASGRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public FQSENOYUOAD PXZRTZVOQOF;

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QBWFFRHGRMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x92578A0", Offset = "0x92564A0", VA = "0x1892578A0")]
			internal object REDJVUNXSXL()
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
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<OISVPIVSSBN.Result> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public QGGDGVMYJMC callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private float <timeoutTime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x9270F20", Offset = "0x926FB20", VA = "0x189270F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x92712A0", Offset = "0x926FEA0", VA = "0x1892712A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public static readonly float QHAGLUDQSBX;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		internal static readonly HashSet<XAYBYAVIJQY.Reason> CWSOURCNNDS;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x925F2B0", Offset = "0x925DEB0", VA = "0x18925F2B0")]
		[AsyncStateMachine(typeof(<WaitForPlayerToSpawn>d__2))]
		internal static Task<OISVPIVSSBN.Result> VJSACVAXBHU(QGGDGVMYJMC a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x925F140", Offset = "0x925DD40", VA = "0x18925F140")]
		internal static void GTWMDWUNLAT(FQSENOYUOAD a, Log b, string c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal interface OISVPIVSSBN
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public struct Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public bool success;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public XAYBYAVIJQY.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public Enum? subReason;

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x9258330", Offset = "0x9256F30", VA = "0x189258330")]
			public static Result Success()
			{
				return default(Result);
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x9258300", Offset = "0x9256F00", VA = "0x189258300")]
			public static Result Failure(XAYBYAVIJQY.Reason reason, [Optional] Enum? subReason)
			{
				return default(Result);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		string MDQRYHYYXLW
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<Result> CZCLQCWZGIY(HashSet<XAYBYAVIJQY.Reason> a, CancellationToken b, XAYBYAVIJQY.Reason c);
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal struct RestoreRecoveryAutosaveInRoomTask
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class QBWFFRHGRMS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public FQSENOYUOAD ZHYWUYYWQFK;

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QBWFFRHGRMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x92579A0", Offset = "0x92565A0", VA = "0x1892579A0")]
			internal Task RRCZDPZGCEA(CancellationToken a, int b, AccountRoleType c)
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
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public RestoreRecoveryAutosaveInRoomTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private long <roomId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private long <subroomId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private LYUZIEXLVDR <autosaveInfo>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private TaskAwaiter<LoadRecoveryAutosaveResponse> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private TaskAwaiter<DRXWOXZYIVH> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x926D450", Offset = "0x926C050", VA = "0x18926D450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x926D9E0", Offset = "0x926C5E0", VA = "0x18926D9E0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public RestoreRecoveryAutosaveInRoomTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x9271310", Offset = "0x926FF10", VA = "0x189271310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x9271620", Offset = "0x9270220", VA = "0x189271620", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly FQSENOYUOAD manager;

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		private ZUUCGYXVQOS UXELQQOUBIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x9257DB0", Offset = "0x92569B0", VA = "0x189257DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private QGGDGVMYJMC WYXWMMZBGZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x9257B50", Offset = "0x9256750", VA = "0x189257B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private HOAWKWPUPAK YDVANLETWMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x9257ED0", Offset = "0x9256AD0", VA = "0x189257ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		private UDGICGGHRKN UCUNMITUWNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x9257F50", Offset = "0x9256B50", VA = "0x189257F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA3A0", Offset = "0x2DD8FA0", VA = "0x182DDA3A0")]
		public RestoreRecoveryAutosaveInRoomTask(CancellationToken cancellationToken, FQSENOYUOAD manager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x92581E0", Offset = "0x9256DE0", VA = "0x1892581E0")]
		public static InLoadedRoomTaskBuilder ZKHZLYXEVCM(FQSENOYUOAD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x9257FA0", Offset = "0x9256BA0", VA = "0x189257FA0")]
		[AsyncStateMachine(typeof(<Run>d__4))]
		public Task<bool> Run()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x9257BA0", Offset = "0x92567A0", VA = "0x189257BA0")]
		private bool DQSMTSWUBRV([Out] LYUZIEXLVDR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x9257E00", Offset = "0x9256A00", VA = "0x189257E00")]
		[AsyncStateMachine(typeof(<WaitUntilWatchMenuIsReady>d__6))]
		private Task IZQTPMWZNRF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x92580B0", Offset = "0x9256CB0", VA = "0x1892580B0")]
		private Task<LoadRecoveryAutosaveResponse> YIFEHYZKHHA(LYUZIEXLVDR a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal struct PendingRequest : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly CQQMUBQBNJB pendingRequests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		private Task<(DRXWOXZYIVH, Task)> SZQSIFVECMM
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x9257780", Offset = "0x9256380", VA = "0x189257780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1AF2CF0", Offset = "0x1AF18F0", VA = "0x181AF2CF0")]
		public PendingRequest(CQQMUBQBNJB pendingRequests, Guid operationId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9257850", Offset = "0x9256450", VA = "0x189257850")]
		public TaskAwaiter<(DRXWOXZYIVH, Task)> JQSTEJIDXIY()
		{
			return default(TaskAwaiter<(DRXWOXZYIVH, Task)>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x92576B0", Offset = "0x92562B0", VA = "0x1892576B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal struct PendingRequestData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly TaskCompletionSource<(DRXWOXZYIVH, Task)> taskCompletion;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public Task<(DRXWOXZYIVH, Task)> SZQSIFVECMM
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x92573D0", Offset = "0x9255FD0", VA = "0x1892573D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x9257530", Offset = "0x9256130", VA = "0x189257530")]
		public PendingRequestData(TimeSpan timeout)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x9257330", Offset = "0x9255F30", VA = "0x189257330")]
		public void FUWIJSDQUIM(Task a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x92574A0", Offset = "0x92560A0", VA = "0x1892574A0")]
		public void XUJLFSEWYLA(DRXWOXZYIVH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x92572E0", Offset = "0x9255EE0", VA = "0x1892572E0")]
		public void AFHTYGHUFYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9257410", Offset = "0x9256010", VA = "0x189257410")]
		internal void NSJRQFNKSGI(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class OMOYQYFDTSZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x9256720", Offset = "0x9255320", VA = "0x189256720")]
		public static RoomLoadRequestPayload EDVYWUATISJ(this RoomLoadRequestPayload a, RoomDetailsDTO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x92568C0", Offset = "0x92554C0", VA = "0x1892568C0")]
		public static RoomLoadRequestPayload KOXKJSPDOIN(this RoomLoadRequestPayload a, SubRoomDataSaveDTO b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal sealed class WOHDSYWOTHZ : YCKRWIQEMHS
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public SubRoomDataSaveDTO KVNVYKRENML;

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x92572B0", Offset = "0x9255EB0", VA = "0x1892572B0")]
			internal bool UDRIVQSHOPJ(SubRoomDTO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly GBFVOIKQDIE ZOCWVPXXMPK;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public WOHDSYWOTHZ(GBFVOIKQDIE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x9272280", Offset = "0x9270E80", VA = "0x189272280", Slot = "4")]
		public RoomLoadRequestPayload Create(long superRoomId, long subRoomId, string studioSessionId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9272120", Offset = "0x9270D20", VA = "0x189272120", Slot = "5")]
		public RoomLoadRequestPayload Create(long superRoomId, long subRoomId, FilenameWithHash superRoomData, Guid? snapshotId, long subRoomDataSaveId, bool loadUsedCompatibility)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x9271F20", Offset = "0x9270B20", VA = "0x189271F20", Slot = "6")]
		public RoomLoadRequestPayload Create(SaveSubRoomResponseDTO saveSubRoomResponseDTO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x9271C50", Offset = "0x9270850", VA = "0x189271C50", Slot = "7")]
		public RoomLoadRequestPayload Create(RoomDetailsDTO superRoom, SubRoomDataSaveDTO subRoomSave)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9272310", Offset = "0x9270F10", VA = "0x189272310")]
		private Guid? SNILHHJCGHL(RoomDetailsDTO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerActiveTask : AEVYTOMCPYJ, CZQABOPRBUR, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private struct <RunAndSetCurrentTask>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public RoomManagerActiveTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public string debugInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Task innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x926A070", Offset = "0x9268C70", VA = "0x18926A070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x926A6E0", Offset = "0x92692E0", VA = "0x18926A6E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly Token CHJJMOIKUCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private string WGKCZLJDBRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private Task AXCFRXYDFTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private FQSENOYUOAD PXZRTZVOQOF;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool GXGBQZBNBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x92583B0", Offset = "0x9256FB0", VA = "0x1892583B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public Task VBWIHEMJBGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x9258660", Offset = "0x9257260", VA = "0x189258660", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0", Slot = "7")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x92583E0", Offset = "0x9256FE0", VA = "0x1892583E0", Slot = "6")]
		public void LYXOUHPEQQC(Task a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x9258540", Offset = "0x9257140", VA = "0x189258540")]
		[AsyncStateMachine(typeof(<RunAndSetCurrentTask>d__11))]
		private Task NCJNVBTWTXZ(Task a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x92586F0", Offset = "0x92572F0", VA = "0x1892586F0")]
		public RoomManagerActiveTask()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	internal class IOXYHVAHEQL : ATUGFAVOUUQ, CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private bool YMTUXQQXZQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private IOXWNGHJERA ILWWVMWXDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private ZUUCGYXVQOS BRMMXAVOEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private GBFVOIKQDIE DWCBTCENJZB;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public IOXWNGHJERA IOXWNGHJERA
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x9254CA0", Offset = "0x92538A0", VA = "0x189254CA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x9254D10", Offset = "0x9253910", VA = "0x189254D10", Slot = "7")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x9254E80", Offset = "0x9253A80", VA = "0x189254E80", Slot = "5")]
		public void VSEAXXDIZDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x9254BA0", Offset = "0x92537A0", VA = "0x189254BA0", Slot = "6")]
		public void SZNWDBEZETL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x9254BE0", Offset = "0x92537E0", VA = "0x189254BE0")]
		private Task EKRROOYXFTO(DisconnectCause a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x9254BA0", Offset = "0x92537A0", VA = "0x189254BA0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public IOXYHVAHEQL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal class PDTCANXXIAL : GBFVOIKQDIE
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		private class Config<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly EDFELDUZHLG RBMDHMRKJCX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly string NFHQLEPGVHS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private readonly T HBXMISVCODJ;

			[Cpp2IlInjected.Token(Token = "0x170000B6")]
			public T ZSNEVPBDVJU
			{
				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0xBF7030", Offset = "0xBF5C30", VA = "0x180BF7030")]
				[CompilerGenerated]
				get
				{
					return (T)null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0xBF7010", Offset = "0xBF5C10", VA = "0x180BF7010")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x462EE60", Offset = "0x462DA60", VA = "0x18462EE60")]
			public Config(EDFELDUZHLG gameConfigsProvider, string key, T defaultValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x462E8B0", Offset = "0x462D4B0", VA = "0x18462E8B0")]
			private void PZDVRUZKOVT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly EDFELDUZHLG RBMDHMRKJCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly Config<TimeSpan> GDFJEGHCTCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly Config<TimeSpan> SKZIXSQQICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly Config<TimeSpan> XCCAEJEGNJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly Config<TimeSpan> ZHAUYZVOLKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly Config<bool> KYHEOOIJIAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly Config<bool> SFCFEJOVGJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Config<bool> MSCWBWOGJLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private readonly Config<int> ODHNYVWMFWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly Config<bool> FVJUXCZVCCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly Config<bool> JZJRNTUYSBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly Config<PlatformMask> QDPZAXSSQBM;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public TimeSpan ZKKWGZPMRQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x9256B00", Offset = "0x9255700", VA = "0x189256B00", Slot = "4")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public TimeSpan YZAJQDWHJPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x9256B80", Offset = "0x9255780", VA = "0x189256B80", Slot = "5")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public TimeSpan QVTFHFVZZAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x9256C80", Offset = "0x9255880", VA = "0x189256C80", Slot = "6")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public TimeSpan NJJAXJLXXBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x9256BC0", Offset = "0x92557C0", VA = "0x189256BC0", Slot = "7")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool NLWNOHWGGFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x9256C40", Offset = "0x9255840", VA = "0x189256C40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool NPLDSVGWTII
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x9256CC0", Offset = "0x92558C0", VA = "0x189256CC0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool KCRCRXYGKDS
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x9256AC0", Offset = "0x92556C0", VA = "0x189256AC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public int RJTYDHFTADF
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x9256B40", Offset = "0x9255740", VA = "0x189256B40", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public bool SMLJAGUHQXY
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x9256A30", Offset = "0x9255630", VA = "0x189256A30", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public bool SLGOPLKFEKL
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x9256C00", Offset = "0x9255800", VA = "0x189256C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public bool YZOAQBDGVPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x9256A70", Offset = "0x9255670", VA = "0x189256A70", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x9256D00", Offset = "0x9255900", VA = "0x189256D00")]
		[UnityEngine.Scripting.Preserve]
		public PDTCANXXIAL([Inject(null)] EDFELDUZHLG gameConfigsProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomManagerEvents : ZCMLIFFPINZ, CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private sealed class IJBAKJDOGSK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public RoomEvent ZNBDDQXXHIS;

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public IJBAKJDOGSK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x9254AD0", Offset = "0x92536D0", VA = "0x189254AD0")]
			internal object CVEOUAODPRR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event RoomEventHandler NGEZEYTZKQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x9258910", Offset = "0x9257510", VA = "0x189258910", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x9258E90", Offset = "0x9257A90", VA = "0x189258E90", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event RoomEventHandler ZPNWNWURYQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x9258770", Offset = "0x9257370", VA = "0x189258770", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x9258C00", Offset = "0x9257800", VA = "0x189258C00", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event RoomEventHandler HBODOXTEQIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x9258AC0", Offset = "0x92576C0", VA = "0x189258AC0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x9258B60", Offset = "0x9257760", VA = "0x189258B60", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<RequestOperationType, bool> ORSJAMRJMLF
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x9258860", Offset = "0x9257460", VA = "0x189258860", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x92589B0", Offset = "0x92575B0", VA = "0x1892589B0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "16")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9258A60", Offset = "0x9257660", VA = "0x189258A60", Slot = "12")]
		public void GERMIPWBRFB(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9258E60", Offset = "0x9257A60", VA = "0x189258E60", Slot = "13")]
		public void POEYUTBGTST(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9258A90", Offset = "0x9257690", VA = "0x189258A90", Slot = "14")]
		public void HDRTDSCBUDZ(RoomEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9258810", Offset = "0x9257410", VA = "0x189258810", Slot = "15")]
		public void BKBZFZKUMQT(RequestOperationType a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9258CA0", Offset = "0x92578A0", VA = "0x189258CA0")]
		private void Invoke(RoomEventHandler handler, RoomEvent roomEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public RoomManagerEvents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomManagerFallbacks : SDSVAEOGYCZ, CZQABOPRBUR, IDisposable, XAYBYAVIJQY
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		private class ARVFOLEURPG : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000073")]
			[CompilerGenerated]
			private sealed class TCPIQNKCSSB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public XAYBYAVIJQY.FallbackReason EBMZXMKAZKB;

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public TCPIQNKCSSB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x925EC90", Offset = "0x925D890", VA = "0x18925EC90")]
				internal object XRXZZHAYPUT((XAYBYAVIJQY.Reason fallbackReason, RoomDTO roomDto, IRCOAQEDBUW state, string subReason) x)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000074")]
			[CompilerGenerated]
			private sealed class CLOJKKCVFXH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				public OISVPIVSSBN TQGYYMTLCFI;

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public CLOJKKCVFXH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x9253D40", Offset = "0x9252940", VA = "0x189253D40")]
				internal object DQEVCKKLPQE()
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
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				public ARVFOLEURPG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				public XAYBYAVIJQY.FallbackReason reason;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				private LogRangeScope <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				private OISVPIVSSBN[] <>7__wrap2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				private int <>7__wrap3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				private TaskAwaiter<OISVPIVSSBN.Result> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x926A740", Offset = "0x9269340", VA = "0x18926A740", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x926AEC0", Offset = "0x9269AC0", VA = "0x18926AEC0", Slot = "5")]
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
				[Cpp2IlInjected.Token(Token = "0x400013A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400013B")]
				public AsyncTaskMethodBuilder<OISVPIVSSBN.Result> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public OISVPIVSSBN fallbackProvider;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				public ARVFOLEURPG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public XAYBYAVIJQY.FallbackReason reason;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				private LogRangeScope <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				private IRCOAQEDBUW <individualFallbackTaskState>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				private TaskAwaiter<OISVPIVSSBN.Result> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x926F390", Offset = "0x926DF90", VA = "0x18926F390", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x9270020", Offset = "0x926EC20", VA = "0x189270020", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public Task JZSUPMYVZTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public CancellationTokenSource AEZSZODGANR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public IRCOAQEDBUW TXRVWABDFCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public QGGDGVMYJMC CTKZLRUOMOT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public RoomDTO TPYJEIDLOKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public RoomInstance AJZXCJUUYEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public OISVPIVSSBN[] JRTNOPSORJN;

			[Cpp2IlInjected.Token(Token = "0x170000BA")]
			public bool JZXUPAMYITE
			{
				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x9253330", Offset = "0x9251F30", VA = "0x189253330")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BB")]
			public bool OXJQMWOPXLA
			{
				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x9253C00", Offset = "0x9252800", VA = "0x189253C00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x9253C20", Offset = "0x9252820", VA = "0x189253C20")]
			public ARVFOLEURPG(QGGDGVMYJMC a, RoomDTO b, RoomInstance c, OISVPIVSSBN[] d, CancellationToken e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x9252230", Offset = "0x9250E30", VA = "0x189252230", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x92527E0", Offset = "0x92513E0", VA = "0x1892527E0")]
			public void GMJZIFKKRPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x92520C0", Offset = "0x9250CC0", VA = "0x1892520C0")]
			public void ACEFCJLMHER()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x9252C30", Offset = "0x9251830", VA = "0x189252C30")]
			public void KRZYHGVYVHY(XAYBYAVIJQY.Reason a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x9253720", Offset = "0x9252320", VA = "0x189253720")]
			[AsyncStateMachine(typeof(<RunFallbackSequence>d__16))]
			public Task UWYBBYCKMTH(XAYBYAVIJQY.FallbackReason a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x9252AE0", Offset = "0x92516E0", VA = "0x189252AE0")]
			[AsyncStateMachine(typeof(<TryRunFallback>d__17))]
			private Task<OISVPIVSSBN.Result> JBXTDEVJLSN(XAYBYAVIJQY.FallbackReason a, OISVPIVSSBN b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x92530B0", Offset = "0x9251CB0", VA = "0x1892530B0")]
			private void NPYUWTQSOOW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x9252EF0", Offset = "0x9251AF0", VA = "0x189252EF0")]
			public bool LPECTCQGOQD(XAYBYAVIJQY.Reason a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x9252850", Offset = "0x9251450", VA = "0x189252850")]
			private void GPHQTGMHFYJ(IRCOAQEDBUW a, XAYBYAVIJQY.FallbackReason b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x9252500", Offset = "0x9251100", VA = "0x189252500")]
			private void EDLEDBOEOYO(IRCOAQEDBUW a, OISVPIVSSBN.Result b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x9253580", Offset = "0x9252180", VA = "0x189253580")]
			private void UUVTJJVLBLI(IRCOAQEDBUW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x9253830", Offset = "0x9252430", VA = "0x189253830")]
			private void ZOHZNQGOCZV(IRCOAQEDBUW a, OISVPIVSSBN.Result b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x92531D0", Offset = "0x9251DD0", VA = "0x1892531D0")]
			private void PIOHTDBXJRS(IRCOAQEDBUW a, Exception b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x9252FA0", Offset = "0x9251BA0", VA = "0x189252FA0")]
			private void NJMLZJUAREV(OISVPIVSSBN a, XAYBYAVIJQY.FallbackReason b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x92526D0", Offset = "0x92512D0", VA = "0x1892526D0")]
			private void FJDLGVLQUHZ(OISVPIVSSBN a, XAYBYAVIJQY.Reason b, string c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x9253350", Offset = "0x9251F50", VA = "0x189253350", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public class IRCOAQEDBUW : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Task<OISVPIVSSBN.Result> JZSUPMYVZTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public CancellationTokenSource AEZSZODGANR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public OISVPIVSSBN TQGYYMTLCFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public XAYBYAVIJQY.Reason TVZRLKWTIFQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public HashSet<XAYBYAVIJQY.Reason> JNEKJADAZGN;

			[Cpp2IlInjected.Token(Token = "0x170000BC")]
			public bool JZXUPAMYITE
			{
				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x9253330", Offset = "0x9251F30", VA = "0x189253330")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BD")]
			public bool OXJQMWOPXLA
			{
				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x9253C00", Offset = "0x9252800", VA = "0x189253C00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x9255030", Offset = "0x9253C30", VA = "0x189255030")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x92551A0", Offset = "0x9253DA0", VA = "0x1892551A0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x9255310", Offset = "0x9253F10", VA = "0x189255310", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x9255530", Offset = "0x9254130", VA = "0x189255530")]
			public IRCOAQEDBUW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class XLYSDAWRGEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public XAYBYAVIJQY.Reason EBMZXMKAZKB;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XLYSDAWRGEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x92723C0", Offset = "0x9270FC0", VA = "0x1892723C0")]
			internal object JGHYBCTHTLK(IRCOAQEDBUW a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x92724A0", Offset = "0x92710A0", VA = "0x1892724A0")]
			internal object JGXSSXAZVTL(ARVFOLEURPG a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x9272430", Offset = "0x9271030", VA = "0x189272430")]
			internal object JGSLVQHCMIC()
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
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public RoomManagerFallbacks <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x925F9C0", Offset = "0x925E5C0", VA = "0x18925F9C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x925FDD0", Offset = "0x925E9D0", VA = "0x18925FDD0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public RoomManagerFallbacks <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public XAYBYAVIJQY.FallbackReason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private ARVFOLEURPG <localTaskState>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x926DA50", Offset = "0x926C650", VA = "0x18926DA50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x926E6E0", Offset = "0x926D2E0", VA = "0x18926E6E0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public XAYBYAVIJQY.Reason reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public RoomManagerFallbacks <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			private XLYSDAWRGEK <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			public Exception exception;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x926E740", Offset = "0x926D340", VA = "0x18926E740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x926F330", Offset = "0x926DF30", VA = "0x18926F330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		internal static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		internal static readonly Log GPNGKAEHBAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private FQSENOYUOAD PXZRTZVOQOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private QGGDGVMYJMC CTKZLRUOMOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private ARVFOLEURPG MYPXXEJQXYU;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		private HOAWKWPUPAK YDVANLETWMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x9259630", Offset = "0x9258230", VA = "0x189259630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool KVJZMXNRQGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x261A900", Offset = "0x2619500", VA = "0x18261A900", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		private bool FINDZGNYTST
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x9259880", Offset = "0x9258480", VA = "0x189259880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x92595B0", Offset = "0x92581B0", VA = "0x1892595B0", Slot = "6")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x92593B0", Offset = "0x9257FB0", VA = "0x1892593B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x9259230", Offset = "0x9257E30", VA = "0x189259230", Slot = "9")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9259680", Offset = "0x9258280", VA = "0x189259680")]
		private bool NLLRPAWPGXV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9259D70", Offset = "0x9258970", VA = "0x189259D70", Slot = "5")]
		private void XKCEGMXZEBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x9259490", Offset = "0x9258090", VA = "0x189259490", Slot = "8")]
		[AsyncStateMachine(typeof(<TriggerFallback>d__14))]
		public Task IJQWHJBHVZD(XAYBYAVIJQY.Reason a, [Optional] Exception b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x9258F30", Offset = "0x9257B30", VA = "0x189258F30")]
		private bool BKUAXBFKNQR(XAYBYAVIJQY.FallbackReason a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x92598F0", Offset = "0x92584F0", VA = "0x1892598F0")]
		private OISVPIVSSBN[] WQQWBZDNAQF(RoomInstance a, RoomDTO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x9259760", Offset = "0x9258360", VA = "0x189259760")]
		[AsyncStateMachine(typeof(<StartRunningFallbacks>d__19))]
		private Task StartRunningFallbacks(XAYBYAVIJQY.FallbackReason reason, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x92593C0", Offset = "0x9257FC0", VA = "0x1892593C0")]
		[AsyncStateMachine(typeof(<BlockWhilePreviousFallbackSequenceIsPendingCancellation>d__20))]
		private Task IGKCNBNJVXF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public RoomManagerFallbacks()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerInitialRoomLoad : BLLZWPKKVFX, CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class UOSTIWCRFXU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public Matchmaking.GameJoinResult OZQWNDVSENS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public ErrorCode JWOAELLANDW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public Exception GKPWMWJXCRO;

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UOSTIWCRFXU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x9271BA0", Offset = "0x92707A0", VA = "0x189271BA0")]
			internal object BQBTLGJADAO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private sealed class LCAFIZDCZRS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public Task<RoomLoadRequestPayload> EJWJLFHZGYW;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LCAFIZDCZRS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			internal Task<RoomLoadRequestPayload> ATYWPLRVCYL(StackTimer<string>.YOQUQHZDBKW a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class HPUDPQOSLZV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public Task<RoomLoadRequestPayload> EJWJLFHZGYW;

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HPUDPQOSLZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			internal Task<RoomLoadRequestPayload> ZRDPALQISVB(StackTimer<string>.YOQUQHZDBKW a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class ELZBGXNWURJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public Task DNSUSNWAAJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public RoomInstance PMAQTMSKJGT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public bool NKAMJIFCOLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public Task CUGCFUGSFYP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public Task YRSRTUJXLMX;

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public ELZBGXNWURJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x9253EB0", Offset = "0x9252AB0", VA = "0x189253EB0")]
			internal object USSOZBEJUFV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x9253DC0", Offset = "0x92529C0", VA = "0x189253DC0")]
			internal string USNIBUKMKUM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class HLJKPBECSVI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public RoomInstance PMAQTMSKJGT;

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HLJKPBECSVI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x9254910", Offset = "0x9253510", VA = "0x189254910")]
			internal object TXGMVKZEANZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class NIHOCBRYXZX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public long NQEGZNFMPDU;

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public NIHOCBRYXZX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x9256610", Offset = "0x9255210", VA = "0x189256610")]
			internal void PJIJLIYIWGS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class IVKBSAUOAZP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public RoomInstance PMAQTMSKJGT;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public IVKBSAUOAZP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x92555B0", Offset = "0x92541B0", VA = "0x1892555B0")]
			internal object GEOKNERPVKV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class QLWLAMNHUHQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public RoomInstance PMAQTMSKJGT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public Task YRSRTUJXLMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public Task DNSUSNWAAJF;

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QLWLAMNHUHQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x92579F0", Offset = "0x92565F0", VA = "0x1892579F0")]
			internal string WRHNWQXUUKD()
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
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public int roomTotalVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public AccountRoleType localPlayerAccountRoleType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private TaskAwaiter<DRXWOXZYIVH> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x925FE30", Offset = "0x925EA30", VA = "0x18925FE30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x92605A0", Offset = "0x925F1A0", VA = "0x1892605A0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public StackTimer<string>.YOQUQHZDBKW timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public Matchmaking.ServerConnectionInfoDTO serverConnectionInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public DGBVEOGIEQF joinRoomInstancePauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public CancellationToken roomCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private TaskAwaiter<VGFVEBUYIWY> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x9261020", Offset = "0x925FC20", VA = "0x189261020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x9261710", Offset = "0x9260310", VA = "0x189261710", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public StackTimer<string>.YOQUQHZDBKW timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public YKIRYHCVYIF customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public DGBVEOGIEQF joinRoomInstancePauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			private LCAFIZDCZRS <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			private BOIVAAXBRST <multiProgressTracker>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			private IDisposable <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			private StackTimer<string>.YOQUQHZDBKW <connectToRoomAndRunLoadLogicTimer>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private CancellationTokenSource <roomTokenSource>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private CancellationTokenRegistration <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private CancellationToken <roomCancellationToken>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private PYUICHTPVMY <preOperationProgressTracker>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private Task<Matchmaking.ServerConnectionInfoDTO> <serverConnectionInfoTask>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			private OIFFNCMBAPW <>7__wrap10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			private CancellationTokenSource <cameraFadeCts>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			private int <i>5__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			private TaskAwaiter<Matchmaking.ServerConnectionInfoDTO> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			private CancellationToken <photonJoinedToken>5__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			private Task <roomLoadTask>5__16;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			private TaskAwaiter<RoomLoadRequestPayload> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x9261770", Offset = "0x9260370", VA = "0x189261770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x9267490", Offset = "0x9266090", VA = "0x189267490", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private DiContainer <roomContainer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x927B960", Offset = "0x927A560", VA = "0x18927B960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x927BDF0", Offset = "0x927A9F0", VA = "0x18927BDF0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public StackTimer<string>.YOQUQHZDBKW timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public YKIRYHCVYIF customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public DGBVEOGIEQF joinRoomInstancePauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			private BOIVAAXBRST <multiProgressTracker>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			private IDisposable <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			private StackTimer<string>.YOQUQHZDBKW <connectToRoomAndRunLoadLogicTimer>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			private CancellationTokenSource <roomTokenSource>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private CancellationTokenRegistration <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			private CancellationToken <roomCancellationToken>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			private PYUICHTPVMY <preOperationProgressTracker>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			private Task<Matchmaking.ServerConnectionInfoDTO> <serverConnectionInfoTask>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			private RoomLoadRequestPayload <initialRoomLoadPayload>5__11;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			private LYPKNRFXAJP <preloadContext>5__12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			private TaskAwaiter<RoomLoadRequestPayload> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			private OIFFNCMBAPW <>7__wrap12;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private Task <loadEmptySceneTask>5__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			private GJPMDBUTLZM <sceneManagementService>5__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			private EYSFXLFSQHI <scenePreloadRequest>5__16;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			private CancellationTokenSource <cameraFadeCts>5__17;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap17;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			private TaskAwaiter<RoomLoadDetails> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			private int <i>5__19;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			private YieldAwaitable.YieldAwaiter <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			private TaskAwaiter<Matchmaking.ServerConnectionInfoDTO> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			private CancellationToken <photonJoinedToken>5__20;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			private Task <roomLoadTask>5__21;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x927BE50", Offset = "0x927AA50", VA = "0x18927BE50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x9281700", Offset = "0x9280300", VA = "0x189281700", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public AsyncTaskMethodBuilder<Matchmaking.ServerConnectionInfoDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public StackTimer<string>.YOQUQHZDBKW timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			private TaskAwaiter<Matchmaking.ServerConnectionInfoDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x92840D0", Offset = "0x9282CD0", VA = "0x1892840D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x92845B0", Offset = "0x92831B0", VA = "0x1892845B0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public YKIRYHCVYIF customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x9284620", Offset = "0x9283220", VA = "0x189284620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x9284BD0", Offset = "0x92837D0", VA = "0x189284BD0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public Task roomLoadTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			private ELZBGXNWURJ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			public CancellationTokenSource roomLoadTokenSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			private TaskAwaiter<Task> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			private object <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x9284C30", Offset = "0x9283830", VA = "0x189284C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x92857B0", Offset = "0x92843B0", VA = "0x1892857B0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public StackTimer<string>.YOQUQHZDBKW timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			public DGBVEOGIEQF joinRoomInstanceToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			public CancellationToken roomJoinCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public RoomLoadRequestPayload initialRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public RoomInstance targetRoomInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public LYPKNRFXAJP preloadContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public BOIVAAXBRST progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			private StackTimer<string>.YOQUQHZDBKW <roomLoadLogicTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x928BE90", Offset = "0x928AA90", VA = "0x18928BE90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x928C680", Offset = "0x928B280", VA = "0x18928C680", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public StackTimer<string>.YOQUQHZDBKW timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			private StackTimer<string>.YOQUQHZDBKW <spawnLocalPlayerTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			private LogRangeScope <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private int <i>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			private LogRangeScope <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private CancellationTokenSource <timeoutTcs>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private CancellationToken <timeoutToken>5__8;

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x928C6E0", Offset = "0x928B2E0", VA = "0x18928C6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x928DEC0", Offset = "0x928CAC0", VA = "0x18928DEC0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			public StackTimer<string>.YOQUQHZDBKW timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private StackTimer<string>.YOQUQHZDBKW <disconnectTimerScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private object <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private int <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000226")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap5;

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x928E7B0", Offset = "0x928D3B0", VA = "0x18928E7B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x928F220", Offset = "0x928DE20", VA = "0x18928F220", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			public RoomManagerInitialRoomLoad <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400022B")]
			public YKIRYHCVYIF customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			private StackTimer<string> <timer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			private LogRangeScope <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			private DGBVEOGIEQF <joinRoomInstancePauseToken>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000230")]
			private KKASIZQFVPH <analyticsData>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000231")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x9290240", Offset = "0x928EE40", VA = "0x189290240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x92910B0", Offset = "0x928FCB0", VA = "0x1892910B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly Log CETUOCXGRMI;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly Log RVZAAPOXUQE;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly Log XXJEGHNHIOY;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly string XOMVNGVYIYV;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly string DPBAQGHOENH;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private static readonly string FYUUTZCWWMW;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public static readonly Guid BATFUPZFNYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private VNEBTMGFLNZ KGZFCTRYIGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private IQKUWZDMPPA RVTMNXSVPWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private ZUUCGYXVQOS BRMMXAVOEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private FQSENOYUOAD PXZRTZVOQOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private QGGDGVMYJMC CTKZLRUOMOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private SDSVAEOGYCZ JWQNJOLHOUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private AEVYTOMCPYJ MOLYBXRHHVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private ZCMLIFFPINZ DITQFZNGCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private QGKXFWXFKWC RJJCUZXOQNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private IAYHKPDKXHL DAVMPNPSUDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private IDisposable RWPXGFVFSYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private ZYFLTPZZNZS MHDJOTWTQGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private readonly Token NGKLXNMIPQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private OIFFNCMBAPW CCWRIXABUGD;

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public TaskStatus WRRYNRJKNRR
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x1338B30", Offset = "0x1337730", VA = "0x181338B30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TaskStatus);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x18E6FC0", Offset = "0x18E5BC0", VA = "0x1818E6FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		private HOAWKWPUPAK YDVANLETWMX
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x925C0C0", Offset = "0x925ACC0", VA = "0x18925C0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x925B3D0", Offset = "0x9259FD0", VA = "0x18925B3D0", Slot = "6")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x925A6D0", Offset = "0x92592D0", VA = "0x18925A6D0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x925B7E0", Offset = "0x925A3E0", VA = "0x18925B7E0", Slot = "5")]
		[AsyncStateMachine(typeof(<JoinRoomInstance>d__30))]
		public Task JoinRoomInstance(RoomInstance targetInstance, YKIRYHCVYIF customRoomLoadPayload, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x925A580", Offset = "0x9259180", VA = "0x18925A580")]
		[AsyncStateMachine(typeof(<TryJoinRoomInstance>d__31))]
		private Task DZZXTMZKDZA(RoomInstance a, YKIRYHCVYIF b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x925ABB0", Offset = "0x92597B0", VA = "0x18925ABB0")]
		private void GJUBXFHJCOC(QGKXFWXFKWC a, RoomInstance b, Exception c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x925C360", Offset = "0x925AF60", VA = "0x18925C360")]
		private static void RUWRDCQUROM(KKASIZQFVPH a, Exception b, [Optional] List<int> c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x925A420", Offset = "0x9259020", VA = "0x18925A420")]
		[AsyncStateMachine(typeof(<ConnectToRoomAndRunLoadLogic>d__34))]
		private Task ConnectToRoomAndRunLoadLogic(StackTimer<string>.YOQUQHZDBKW timer, RoomInstance targetInstance, YKIRYHCVYIF customRoomLoadPayload, DGBVEOGIEQF joinRoomInstancePauseToken, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x925AA50", Offset = "0x9259650", VA = "0x18925AA50")]
		[AsyncStateMachine(typeof(<FastPath_ConnectToRoomAndRunLoadLogic>d__35))]
		private Task FastPath_ConnectToRoomAndRunLoadLogic(StackTimer<string>.YOQUQHZDBKW timer, RoomInstance targetInstance, YKIRYHCVYIF customRoomLoadPayload, DGBVEOGIEQF joinRoomInstancePauseToken, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x925D0C0", Offset = "0x925BCC0", VA = "0x18925D0C0")]
		private void UOUPHULQWLW([CallerMemberName] string caller = "<unknown>")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x9259F00", Offset = "0x9258B00", VA = "0x189259F00")]
		[AsyncStateMachine(typeof(<TryDisconnectFromCurrentRoomInstance>d__37))]
		private Task BAOPROFHAEF(StackTimer<string>.YOQUQHZDBKW a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x925BBF0", Offset = "0x925A7F0", VA = "0x18925BBF0")]
		private void MGDUKGIVOAR(RoomInstance a, CancellationToken b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x925B010", Offset = "0x9259C10", VA = "0x18925B010")]
		private void GMVYAYWFYHX(RoomInstance a, TaskStatus b, string c, DGBVEOGIEQF d, Exception e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x925C1A0", Offset = "0x925ADA0", VA = "0x18925C1A0")]
		private void PQJZCYYPWHE(RoomInstance a, DGBVEOGIEQF b, OperationCanceledException c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x925D040", Offset = "0x925BC40", VA = "0x18925D040")]
		private void TSDMOHIMLOG(RoomInstance a, DGBVEOGIEQF b, Exception c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x925B980", Offset = "0x925A580", VA = "0x18925B980")]
		private void LSGMEGUFOCK(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x925B920", Offset = "0x925A520", VA = "0x18925B920")]
		private static RoomEvent LQWPBBWMWAW(RoomInstance a)
		{
			return default(RoomEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x925D480", Offset = "0x925C080", VA = "0x18925D480")]
		[AsyncStateMachine(typeof(<CreateRoomDiContainer>d__44))]
		private Task WVOSLMNOCMU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x925B270", Offset = "0x9259E70", VA = "0x18925B270")]
		[AsyncStateMachine(typeof(<GetServerConnectionInfo>d__45))]
		private Task<Matchmaking.ServerConnectionInfoDTO> GetServerConnectionInfo(RoomInstance targetInstance, StackTimer<string>.YOQUQHZDBKW timer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x925D370", Offset = "0x925BF70", VA = "0x18925D370")]
		private static VGFVEBUYIWY VLCLFVQVPMK(Matchmaking.ServerConnectionInfoDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x925A720", Offset = "0x9259320", VA = "0x18925A720")]
		[AsyncStateMachine(typeof(<ConnectToPhoton>d__47))]
		private Task ETELZASANDU(Matchmaking.ServerConnectionInfoDTO a, DGBVEOGIEQF b, StackTimer<string>.YOQUQHZDBKW c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x925C220", Offset = "0x925AE20", VA = "0x18925C220")]
		[AsyncStateMachine(typeof(<JoinRoomLoadWithPhoton>d__48))]
		private Task PXPZXBLGSGY(RoomInstance a, CancellationTokenSource b, Task c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x925CB90", Offset = "0x925B790", VA = "0x18925CB90")]
		[AsyncStateMachine(typeof(<RunRoomLoadLogic>d__49))]
		private Task RunRoomLoadLogic(RoomLoadRequestPayload initialRoomLoadPayload, BOIVAAXBRST progressTracker, RoomInstance targetRoomInstance, DGBVEOGIEQF joinRoomInstanceToken, StackTimer<string>.YOQUQHZDBKW timer, CancellationToken roomJoinCancellationToken, [Optional] LYPKNRFXAJP preloadContext)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x925A870", Offset = "0x9259470", VA = "0x18925A870")]
		private DGBVEOGIEQF FBWFSZEIBVV(DGBVEOGIEQF a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x925CE00", Offset = "0x925BA00", VA = "0x18925CE00")]
		[AsyncStateMachine(typeof(<SpawnLocalPlayer>d__51))]
		private Task SpawnLocalPlayer(StackTimer<string>.YOQUQHZDBKW timer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x925D240", Offset = "0x925BE40", VA = "0x18925D240")]
		[AsyncStateMachine(typeof(<CheckForRoomDataOutOfDate>d__52))]
		private Task VHCCTZGLHQG(CancellationToken a, int b, AccountRoleType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x925A030", Offset = "0x9258C30", VA = "0x18925A030")]
		private static void BRQIZDRBKNJ(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x925A200", Offset = "0x9258E00", VA = "0x18925A200")]
		private void CRNLGSXRRJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x925B750", Offset = "0x925A350", VA = "0x18925B750")]
		private void JDCZPBBHUXT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x925C110", Offset = "0x925AD10", VA = "0x18925C110")]
		private void OTGYFHEDEJU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x925D650", Offset = "0x925C250", VA = "0x18925D650")]
		private void ZLZAJRWJZIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x925CD10", Offset = "0x925B910", VA = "0x18925CD10")]
		private static void SMYMFJJLWEB(RoomInstance a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x925D550", Offset = "0x925C150", VA = "0x18925D550")]
		private static CancellationTokenRegistration WWSMLAJKJYC(RoomInstance a, CancellationToken b)
		{
			return default(CancellationTokenRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x925CF40", Offset = "0x925BB40", VA = "0x18925CF40")]
		private static void TKFNDYFFIYX(RoomInstance a, Exception b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x925BF20", Offset = "0x925AB20", VA = "0x18925BF20")]
		private void MGWCSKDNLDH(RoomInstance a, Task b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x925BB90", Offset = "0x925A790", VA = "0x18925BB90")]
		private static void Log(Func<string> msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x925D900", Offset = "0x925C500", VA = "0x18925D900")]
		public RoomManagerInitialRoomLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x925A1A0", Offset = "0x9258DA0", VA = "0x18925A1A0")]
		[CompilerGenerated]
		internal static (int, int?) CGLYMFXTZFY(ErrorCode a)
		{
			return default((int, int?));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerInRoomTasks : EHHFOATIKRW, CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class XPNAWOTYTOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000238")]
			public RoomManagerInRoomTasks VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			public int WNIFBQUKEEQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400023A")]
			public AccountRoleType NTWNKRNAVPK;

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XPNAWOTYTOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x9291E90", Offset = "0x9290A90", VA = "0x189291E90")]
			internal List<Task> XWVGGTRWQTB(CancellationToken a)
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
			[Cpp2IlInjected.Token(Token = "0x400023B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			public RoomManagerInRoomTasks <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400023E")]
			public int roomTotalVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400023F")]
			public AccountRoleType localPlayerAccountRoleType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000240")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x9289E00", Offset = "0x9288A00", VA = "0x189289E00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x928A2D0", Offset = "0x9288ED0", VA = "0x18928A2D0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000242")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000243")]
			public InLoadedRoomTaskBuilder taskBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000244")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000245")]
			public int roomTotalVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000246")]
			public AccountRoleType localPlayerAccountRoleType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000247")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000248")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x9291550", Offset = "0x9290150", VA = "0x189291550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x92918F0", Offset = "0x92904F0", VA = "0x1892918F0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000249")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400024A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400024B")]
			public RoomManagerInRoomTasks <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400024C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x9291950", Offset = "0x9290550", VA = "0x189291950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x9291C30", Offset = "0x9290830", VA = "0x189291C30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private readonly HashSet<InLoadedRoomTaskBuilder> BTHDIAKUNYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private IQKUWZDMPPA RVTMNXSVPWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private FQSENOYUOAD PXZRTZVOQOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private FDPRMABNSIO GSTZPDFXRQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private TaskRunner MBUXQSDGNQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private IDisposable RWPXGFVFSYQ;

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x92740E0", Offset = "0x9272CE0", VA = "0x1892740E0", Slot = "5")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x9274080", Offset = "0x9272C80", VA = "0x189274080", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x92745C0", Offset = "0x92731C0", VA = "0x1892745C0", Slot = "4")]
		public bool MJOIGBTHAMY(InLoadedRoomTaskBuilder a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x92746F0", Offset = "0x92732F0", VA = "0x1892746F0")]
		private void OGGSQYPPLDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x92747C0", Offset = "0x92733C0", VA = "0x1892747C0")]
		private void OPMACVMBGAT(APQTHAEMUEW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x92743B0", Offset = "0x9272FB0", VA = "0x1892743B0")]
		[AsyncStateMachine(typeof(<RunInRoomTaskAsync>d__15))]
		private Task JMGUQFTQCNP(int a, AccountRoleType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x9274620", Offset = "0x9273220", VA = "0x189274620")]
		private Func<CancellationToken, List<Task>> OAHKFBWCJXX(int a, AccountRoleType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x9273AF0", Offset = "0x92726F0", VA = "0x189273AF0")]
		private List<Task> CPLGDRFXNAJ(int a, AccountRoleType b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x92744A0", Offset = "0x92730A0", VA = "0x1892744A0")]
		[AsyncStateMachine(typeof(<WaitAndLog>d__18))]
		private Task KUZWOHVTEKZ(InLoadedRoomTaskBuilder a, CancellationToken b, int c, AccountRoleType d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x92749E0", Offset = "0x92735E0", VA = "0x1892749E0")]
		[AsyncStateMachine(typeof(<WaitForPhotonAndCancel>d__19))]
		private Task RLULSWIOWZK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x9274000", Offset = "0x9272C00", VA = "0x189274000")]
		private void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x9274AB0", Offset = "0x92736B0", VA = "0x189274AB0")]
		public RoomManagerInRoomTasks()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerPendingRequests : CQQMUBQBNJB, CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			public Guid EUJKWVXHRZV;

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x9273140", Offset = "0x9271D40", VA = "0x189273140")]
			internal object ITIKISLSBPK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			public Guid EUJKWVXHRZV;

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9273A30", Offset = "0x9272630", VA = "0x189273A30")]
			internal object UAQPYSZWRYX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class GLPIMGKKXXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			public Guid EUJKWVXHRZV;

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GLPIMGKKXXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x9273330", Offset = "0x9271F30", VA = "0x189273330")]
			internal object ADIHNCQZGZZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000252")]
			public Guid EUJKWVXHRZV;

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x927B900", Offset = "0x927A500", VA = "0x18927B900")]
			internal object XWZIZNPOMCP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private readonly Dictionary<Guid, PendingRequestData> LEMABXCGADU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private readonly TimeSpan ASTSKDZWTYZ;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "9")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x9274D40", Offset = "0x9273940", VA = "0x189274D40", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x9274B30", Offset = "0x9273730", VA = "0x189274B30", Slot = "4")]
		public PendingRequest Add(Guid operationId)
		{
			return default(PendingRequest);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x92751C0", Offset = "0x9273DC0", VA = "0x1892751C0", Slot = "5")]
		public bool Remove(Guid operationId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x92753C0", Offset = "0x9273FC0", VA = "0x1892753C0", Slot = "6")]
		public bool YTBDRCZVNLT(Guid a, Task b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x9274F80", Offset = "0x9273B80", VA = "0x189274F80", Slot = "7")]
		public bool KPJWGNKCLIZ(Guid a, DRXWOXZYIVH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x9275150", Offset = "0x9273D50", VA = "0x189275150", Slot = "8")]
		public Task<(DRXWOXZYIVH, Task)> NRPPWKDHGNU(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x9274D50", Offset = "0x9273950", VA = "0x189274D50")]
		private void EUCGVENBHEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x92756F0", Offset = "0x92742F0", VA = "0x1892756F0")]
		public RoomManagerPendingRequests()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class RoomManagerPresenceUpdates : UNYNNFENUBZ, CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		private class NNCHLNZETNJ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			private readonly RoomInstance PAMYHPYEMYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			private readonly CancellationTokenSource CNSXWCHJSHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			public readonly CancellationToken FCWFZLEDINY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000263")]
			private bool NMPRMYDCVCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			private bool DDIOUOLRIDQ;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x9273990", Offset = "0x9272590", VA = "0x189273990")]
			public NNCHLNZETNJ(RoomInstance a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x9273820", Offset = "0x9272420", VA = "0x189273820")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x9273960", Offset = "0x9272560", VA = "0x189273960", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class TCPIQNKCSSB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			public DisconnectCause EQCFSIYIYUC;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TCPIQNKCSSB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x927B6E0", Offset = "0x927A2E0", VA = "0x18927B6E0")]
			internal object KPITGLPAKST()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class TFYMXOXWAKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026A")]
			public int WOBGIIJQGFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400026B")]
			public RoomManagerPresenceUpdates VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TFYMXOXWAKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x927B830", Offset = "0x927A430", VA = "0x18927B830")]
			internal object JPAONNVIVXP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class TFTGAIDYQZC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026C")]
			public RoomInstance PAMYHPYEMYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400026D")]
			public TFYMXOXWAKL JZUGHOQQQFE;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TFTGAIDYQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x927B770", Offset = "0x927A370", VA = "0x18927B770")]
			internal object JOKTVTNQTPO((RoomInstance lastLocalPlayerRoomInstance, RoomInstance newRoomInstance, SDSVAEOGYCZ fallbacks) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class VSFAPRYZFDS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400026E")]
			public RoomInstance PAMYHPYEMYJ;

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public VSFAPRYZFDS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x9291D10", Offset = "0x9290910", VA = "0x189291D10")]
			internal object OBKFYWDIGNU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x9291DB0", Offset = "0x92909B0", VA = "0x189291DB0")]
			internal void OBPMWCXFPZD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x9291C90", Offset = "0x9290890", VA = "0x189291C90")]
			internal object OAZSEIPNNRC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x9291CD0", Offset = "0x92908D0", VA = "0x189291CD0")]
			internal object OBEZBPJKXCL()
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
			[Cpp2IlInjected.Token(Token = "0x400026F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000270")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000271")]
			public DisconnectCause disconnectCause;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000272")]
			public RoomManagerPresenceUpdates <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000273")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000274")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x9286A90", Offset = "0x9285690", VA = "0x189286A90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x9286ED0", Offset = "0x9285AD0", VA = "0x189286ED0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000275")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000276")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000277")]
			public int playerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000278")]
			public RoomManagerPresenceUpdates <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000279")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400027A")]
			private IDisposable <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400027B")]
			private IDisposable <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400027C")]
			private LogRangeScope <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400027D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x9286F30", Offset = "0x9285B30", VA = "0x189286F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400027E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400027F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000280")]
			public RoomInstance newRoomInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000281")]
			public RoomManagerPresenceUpdates <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000282")]
			public YKIRYHCVYIF customRoomLoadPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000283")]
			private VSFAPRYZFDS <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000284")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000285")]
			private CancellationTokenRegistration <_>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000286")]
			private object <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000287")]
			private int <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000288")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x928F280", Offset = "0x928DE80", VA = "0x18928F280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x92901E0", Offset = "0x928EDE0", VA = "0x1892901E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private static readonly GQOOTZPVISD.TSSRORNCOJX UOSQJYPRWBU;

		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private static readonly LogFlags NKASLEFEPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private IQKUWZDMPPA RVTMNXSVPWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private FQSENOYUOAD PXZRTZVOQOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private SDSVAEOGYCZ JWQNJOLHOUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private QGGDGVMYJMC CTKZLRUOMOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private GBFVOIKQDIE DWCBTCENJZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private BLLZWPKKVFX TNXVWLQTBGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private RoomInstance PESQVMQQMUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private NNCHLNZETNJ THDNDNRFNCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private bool PGBMMRLPBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private Task YNPLSTJTMGU;

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		private HOAWKWPUPAK YDVANLETWMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x9275EE0", Offset = "0x9274AE0", VA = "0x189275EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool OIYPTHWIMHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0xBB3CE0", Offset = "0xBB28E0", VA = "0x180BB3CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x9275ED0", Offset = "0x9274AD0", VA = "0x189275ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x9275B30", Offset = "0x9274730", VA = "0x189275B30", Slot = "4")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x9275920", Offset = "0x9274520", VA = "0x189275920", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x9275DE0", Offset = "0x92749E0", VA = "0x189275DE0")]
		[AsyncStateMachine(typeof(<OnDisconnectedFromPhotonWhileConnected>d__20))]
		private Task LIAFCCFSXFX(DisconnectCause a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x9276440", Offset = "0x9275040", VA = "0x189276440")]
		private void TEGHMRNQJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x92766A0", Offset = "0x92752A0", VA = "0x1892766A0")]
		private void YOJRTYILHLQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x9275F30", Offset = "0x9274B30", VA = "0x189275F30")]
		private void PAXATNHUOBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x9275AB0", Offset = "0x92746B0", VA = "0x189275AB0")]
		private bool HRTPEAUXXGA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x92765D0", Offset = "0x92751D0", VA = "0x1892765D0")]
		[AsyncStateMachine(typeof(<OnPlayerPresenceUpdated>d__26))]
		private void XMLSTICSWUT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x92761A0", Offset = "0x9274DA0", VA = "0x1892761A0")]
		private void QXDPPEWYQTU([Out] IDisposable a, [Out] IDisposable b, [Out] IDisposable c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x92760A0", Offset = "0x9274CA0", VA = "0x1892760A0")]
		private bool PJXHRITDKUG(RoomInstance a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x92757A0", Offset = "0x92743A0", VA = "0x1892757A0")]
		private void CETOUDVIYMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x92757F0", Offset = "0x92743F0", VA = "0x1892757F0")]
		[AsyncStateMachine(typeof(<TryJoinRoomInstance>d__30))]
		private Task DZZXTMZKDZA(RoomInstance a, YKIRYHCVYIF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x9276BE0", Offset = "0x92757E0", VA = "0x189276BE0")]
		public RoomManagerPresenceUpdates()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerReceiveOperation : WMUJUOJJJZK, CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class HCFOWLTMZUC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400028F")]
			public BURCCBMBLWO NXKUTENLLLI;

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HCFOWLTMZUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x9273680", Offset = "0x9272280", VA = "0x189273680")]
			internal object RGUJARYOQZB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		[CompilerGenerated]
		private sealed class CITSQHBYTVL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000290")]
			public BURCCBMBLWO ZBJBQRAIHHQ;

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CITSQHBYTVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x92730E0", Offset = "0x9271CE0", VA = "0x1892730E0")]
			internal object KPUOCBPQUHC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class QOCTNDBRPOU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000291")]
			public BURCCBMBLWO GGJHNRJYFLT;

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QOCTNDBRPOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x9273A90", Offset = "0x9272690", VA = "0x189273A90")]
			internal object UHKOCYLGKLR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		[CompilerGenerated]
		private sealed class KRJUMOXJQBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000292")]
			public UTQHQVVVWVQ YQSELGWZDTU;

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public KRJUMOXJQBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x9273740", Offset = "0x9272340", VA = "0x189273740")]
			internal object HQLJAQTMULX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		[CompilerGenerated]
		private sealed class XPNAWOTYTOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			public BURCCBMBLWO ZBJBQRAIHHQ;

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XPNAWOTYTOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x9291E30", Offset = "0x9290A30", VA = "0x189291E30")]
			internal object PCELPSUFXSJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		[CompilerGenerated]
		private sealed class IJBAKJDOGSK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			public BURCCBMBLWO ZBJBQRAIHHQ;

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public IJBAKJDOGSK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x92736E0", Offset = "0x92722E0", VA = "0x1892736E0")]
			internal object EDXZALJPXDA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class XYJRREPQRHS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			public BURCCBMBLWO IBBTTYTYKIM;

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XYJRREPQRHS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x9291ED0", Offset = "0x9290AD0", VA = "0x189291ED0")]
			internal object ATHIKVKFGVE()
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
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000297")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000298")]
			public UTQHQVVVWVQ operation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000299")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			public RoomManagerReceiveOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400029C")]
			private StackTimer<string> <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400029D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x928B800", Offset = "0x928A400", VA = "0x18928B800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x928BE30", Offset = "0x928AA30", VA = "0x18928BE30", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400029E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400029F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002A0")]
			public BURCCBMBLWO operationStartMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A1")]
			public RoomManagerReceiveOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			private CancellationTokenSource <cancellationTokenSource>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002A4")]
			private DGBVEOGIEQF <pauseToken>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002A5")]
			private TaskAwaiter<BURCCBMBLWO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			private IDisposable <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x928A330", Offset = "0x9288F30", VA = "0x18928A330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x928AE80", Offset = "0x9289A80", VA = "0x18928AE80", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			public BURCCBMBLWO request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public RoomManagerReceiveOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			private CancellationTokenSource <cancellationTokenSource>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			private TaskAwaiter<UTQHQVVVWVQ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x928AEE0", Offset = "0x9289AE0", VA = "0x18928AEE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x928B7A0", Offset = "0x928A3A0", VA = "0x18928B7A0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			public AsyncTaskMethodBuilder<UTQHQVVVWVQ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public RoomManagerReceiveOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			public BURCCBMBLWO request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			private TEWGZJRXLEI.LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			private DGBVEOGIEQF <pauseToken>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			private TaskAwaiter<BURCCBMBLWO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x928DF20", Offset = "0x928CB20", VA = "0x18928DF20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x928E450", Offset = "0x928D050", VA = "0x18928E450", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			public AsyncTaskMethodBuilder<RoomOperationType> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			public RoomManagerReceiveOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			public CancellationToken throwOnRequestCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			private TaskAwaiter<RoomOperationType> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x928E4C0", Offset = "0x928D0C0", VA = "0x18928E4C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x928E740", Offset = "0x928D340", VA = "0x18928E740", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private FQSENOYUOAD PXZRTZVOQOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private AEVYTOMCPYJ MOLYBXRHHVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private LWSFUGCVEAF AHUPLHDNTXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private BFALSPVIUPM LRZZNGUBIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private ZUUCGYXVQOS BRMMXAVOEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskCompletionSource<RoomOperationType> BHRBBKVHSCP;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x9276FB0", Offset = "0x9275BB0", VA = "0x189276FB0", Slot = "7")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x92770A0", Offset = "0x9275CA0", VA = "0x1892770A0", Slot = "6")]
		[AsyncStateMachine(typeof(<ThrowOnRequestTask>d__8))]
		public Task<RoomOperationType> LLGUYHNIJLM(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x9276C50", Offset = "0x9275850", VA = "0x189276C50", Slot = "4")]
		public void GGKZIQIMBOO(BURCCBMBLWO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x92772C0", Offset = "0x9275EC0", VA = "0x1892772C0", Slot = "5")]
		public void OIGXGGPCDDL(BURCCBMBLWO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x9277C30", Offset = "0x9276830", VA = "0x189277C30")]
		[AsyncStateMachine(typeof(<RunOperationFromRequest>d__11))]
		private Task ZGLELNAOCGI(BURCCBMBLWO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x92771B0", Offset = "0x9275DB0", VA = "0x1892771B0")]
		[AsyncStateMachine(typeof(<RunOperationFromMaster>d__12))]
		private Task NBDSMGXKZOR(BURCCBMBLWO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x9277940", Offset = "0x9276540", VA = "0x189277940")]
		[AsyncStateMachine(typeof(<SyncAndCreateOperation>d__13))]
		private Task<UTQHQVVVWVQ> VUKQQBKNXQE(BURCCBMBLWO a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x9277BB0", Offset = "0x92767B0", VA = "0x189277BB0")]
		private DGBVEOGIEQF WNAGNOTOMCJ(BURCCBMBLWO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x9277A90", Offset = "0x9276690", VA = "0x189277A90")]
		[AsyncStateMachine(typeof(<RunOperation>d__15))]
		private Task WLRBONFGTJZ(UTQHQVVVWVQ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x9277D40", Offset = "0x9276940", VA = "0x189277D40")]
		private UTQHQVVVWVQ ZGVEZOFPIWL(BURCCBMBLWO a, DGBVEOGIEQF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x3FE2E00", Offset = "0x3FE1A00", VA = "0x183FE2E00")]
		private a XFAURXNFCUJ<a>(a a) where a : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x92775F0", Offset = "0x92761F0", VA = "0x1892775F0")]
		private UTQHQVVVWVQ PBJXEIPRQIW(BURCCBMBLWO a, DGBVEOGIEQF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public RoomManagerReceiveOperation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerRequestHandler : LWSFUGCVEAF, CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		[CompilerGenerated]
		private sealed class LOJPDCGXZIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			public byte BIBTESGVAJM;

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LOJPDCGXZIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x92737C0", Offset = "0x92723C0", VA = "0x1892737C0")]
			internal object WCXULSKWJOV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			public Guid EUJKWVXHRZV;

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x927B890", Offset = "0x927A490", VA = "0x18927B890")]
			internal object CDGDBGDUQFY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private ZUUCGYXVQOS BRMMXAVOEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private DTMXXXKYTWN SEHADCCHDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private WMUJUOJJJZK MXLFWUPENLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private CQQMUBQBNJB LEMABXCGADU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private OUWABYBHYDP XCWPPTNUXIY;

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x9278A10", Offset = "0x9277610", VA = "0x189278A10", Slot = "6")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x9278700", Offset = "0x9277300", VA = "0x189278700", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x9278B80", Offset = "0x9277780", VA = "0x189278B80", Slot = "4")]
		public PendingRequest JOYMIHJDPUZ(BURCCBMBLWO a)
		{
			return default(PendingRequest);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x92793D0", Offset = "0x9277FD0", VA = "0x1892793D0", Slot = "5")]
		public void OOIAELZELOS(Guid a, Task b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x9279BF0", Offset = "0x92787F0", VA = "0x189279BF0")]
		private void ZXCOKGBXDYC(RQAGMLJLYPY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x9278180", Offset = "0x9276D80", VA = "0x189278180")]
		private void CDGXEMZENFB(OperationEventData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x92787A0", Offset = "0x92773A0", VA = "0x1892787A0")]
		private void IPFTCHZPIOP(OperationEventData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x9277F40", Offset = "0x9276B40", VA = "0x189277F40")]
		private void BEILTSORLQC(OperationEventData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x92791A0", Offset = "0x9277DA0", VA = "0x1892791A0")]
		private DRXWOXZYIVH NBNAYMKQOBN(BURCCBMBLWO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x92795D0", Offset = "0x92781D0", VA = "0x1892795D0")]
		private void QRIVQLGBCKL(BURCCBMBLWO a, DRXWOXZYIVH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x9279A10", Offset = "0x9278610", VA = "0x189279A10")]
		private bool ROXZKQJYJIG(BURCCBMBLWO a, DRXWOXZYIVH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x9278F90", Offset = "0x9277B90", VA = "0x189278F90")]
		private bool MQZICPIJIJO(BURCCBMBLWO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x92797D0", Offset = "0x92783D0", VA = "0x1892797D0")]
		private bool RMSLQIITFXN(byte a, ExitGames.Client.Photon.Hashtable b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public RoomManagerRequestHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerRequestOperation : MINKQEQNUMI, CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			public RoomOperationType ZTWQHOEIUIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			public RoomManagerRequestOperation VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public BURCCBMBLWO AIZJFSIOBSW;

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x92731A0", Offset = "0x9271DA0", VA = "0x1892731A0")]
			internal object LRIFXDNMRXW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x9273210", Offset = "0x9271E10", VA = "0x189273210")]
			internal object LRNMUKHKBJF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			public RoomOperationType ZTWQHOEIUIG;

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x9273010", Offset = "0x9271C10", VA = "0x189273010")]
			internal object DAITAZKGGDL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private sealed class GLPIMGKKXXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			public BURCCBMBLWO ZBJBQRAIHHQ;

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GLPIMGKKXXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x9273400", Offset = "0x9272000", VA = "0x189273400")]
			internal object IOMKKEYHCGW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x9273470", Offset = "0x9272070", VA = "0x189273470")]
			internal object IORRHLSELSF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x9273390", Offset = "0x9271F90", VA = "0x189273390")]
			internal object IOBWPRKMJKE()
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
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			public AsyncTaskMethodBuilder<DRXWOXZYIVH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			public RoomManagerRequestOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			public BURCCBMBLWO roomOperationMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			private TaskAwaiter<DRXWOXZYIVH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x9288D00", Offset = "0x9287900", VA = "0x189288D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x9289380", Offset = "0x9287F80", VA = "0x189289380", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			public AsyncTaskMethodBuilder<DRXWOXZYIVH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			public BURCCBMBLWO request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			public RoomManagerRequestOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private GLPIMGKKXXA <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			private PendingRequest <pendingRequest>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			private DRXWOXZYIVH <result>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			private TaskAwaiter<(DRXWOXZYIVH validationResult, Task operation)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002E6")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x92893F0", Offset = "0x9287FF0", VA = "0x1892893F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x9289D90", Offset = "0x9288990", VA = "0x189289D90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private ZUUCGYXVQOS BRMMXAVOEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private DTMXXXKYTWN SEHADCCHDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private LWSFUGCVEAF AHUPLHDNTXQ;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x9279D00", Offset = "0x9278900", VA = "0x189279D00", Slot = "5")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x927A0D0", Offset = "0x9278CD0", VA = "0x18927A0D0", Slot = "4")]
		[AsyncStateMachine(typeof(<RecRoom-RoomLoading-IRoomManagerRequestOperation-RequestOperation>d__4))]
		private Task<DRXWOXZYIVH> NVSBGOBDDNS(BURCCBMBLWO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x9279DB0", Offset = "0x92789B0", VA = "0x189279DB0")]
		private bool KLGWFRWSIOD(RoomOperationType a, [Out] DRXWOXZYIVH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x9279F90", Offset = "0x9278B90", VA = "0x189279F90")]
		[AsyncStateMachine(typeof(<RequestOperationInternal>d__7))]
		private Task<DRXWOXZYIVH> NUKISDJVNEK(BURCCBMBLWO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public RoomManagerRequestOperation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal sealed class RoomManagerRoomLoadRequest : JOBTRQDNNUS, CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000C1")]
		private struct ResolvedLoadParameters
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002EB")]
			public FilenameWithHash SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002EC")]
			public long SubRoomDataSaveId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public Guid? RoomLoadSnapshotId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public bool LoadUsedCompatibility;
		}

		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		[CompilerGenerated]
		private sealed class HCFOWLTMZUC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public Stopwatch QPUMUUIYKCD;

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HCFOWLTMZUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x92735E0", Offset = "0x92721E0", VA = "0x1892735E0")]
			internal object OYJZMSULQFK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		[CompilerGenerated]
		private sealed class GLPIMGKKXXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			public Stopwatch QPUMUUIYKCD;

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GLPIMGKKXXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x92734E0", Offset = "0x92720E0", VA = "0x1892734E0")]
			internal object ZCJIKRKBKNQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C4")]
		[CompilerGenerated]
		private sealed class XYJRREPQRHS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			public long QNXITDVSSUH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			public RoomDetailsDTO UVUXVWRBCMF;

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XYJRREPQRHS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x1100FD0", Offset = "0x10FFBD0", VA = "0x181100FD0")]
			internal bool QKHXZSWYSGX(SubRoomDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x9292050", Offset = "0x9290C50", VA = "0x189292050")]
			internal object QLCZOTYOEAH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x9291F30", Offset = "0x9290B30", VA = "0x189291F30")]
			internal object QKCRCMDBIVO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x9291FC0", Offset = "0x9290BC0", VA = "0x189291FC0")]
			internal object QKSLUGKTLDP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		[CompilerGenerated]
		private sealed class XYOYOLJOATB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			public bool MUPMDQQRVUY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F4")]
			public XYJRREPQRHS JZUGHOQQQFE;

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XYOYOLJOATB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x9292110", Offset = "0x9290D10", VA = "0x189292110")]
			internal object QKNEWZQWBSG()
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
			[Cpp2IlInjected.Token(Token = "0x40002F5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			public AsyncTaskMethodBuilder<ResolvedLoadParameters> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			public SubRoomDTO subroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			public RoomManagerRoomLoadRequest <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			public RoomInstance dormInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			public long subroomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			private HCFOWLTMZUC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002FF")]
			private TaskAwaiter<SubRoomDataSaveDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x9281760", Offset = "0x9280360", VA = "0x189281760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x9281E20", Offset = "0x9280A20", VA = "0x189281E20", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			public AsyncTaskMethodBuilder<ResolvedLoadParameters> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			public long subroomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000303")]
			public RoomDetailsDTO roomDetailsDto;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			public RoomManagerRoomLoadRequest <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			private XYOYOLJOATB <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			private TaskAwaiter<ResolvedLoadParameters> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			private TaskAwaiter<RoomLoadDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x9281E90", Offset = "0x9280A90", VA = "0x189281E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x9282DF0", Offset = "0x92819F0", VA = "0x189282DF0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			public AsyncTaskMethodBuilder<RoomDetailsDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public RoomManagerRoomLoadRequest <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			private GLPIMGKKXXA <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x9282E60", Offset = "0x9281A60", VA = "0x189282E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x9283440", Offset = "0x9282040", VA = "0x189283440", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public AsyncTaskMethodBuilder<RoomLoadRequestPayload> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			public RoomManagerRoomLoadRequest <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			private long <subRoomId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			private TaskAwaiter<RoomLoadRequestPayload> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x9283A90", Offset = "0x9282690", VA = "0x189283A90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x9284060", Offset = "0x9282C60", VA = "0x189284060", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			public AsyncTaskMethodBuilder<RoomLoadRequestPayload> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public RoomManagerRoomLoadRequest <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public RoomInstance targetInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public RoomDetailsDTO roomDetailsDto;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public long subroomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			private TaskAwaiter<ResolvedLoadParameters> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x92834B0", Offset = "0x92820B0", VA = "0x1892834B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x9283A20", Offset = "0x9282620", VA = "0x189283A20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private QGGDGVMYJMC CTKZLRUOMOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private GBFVOIKQDIE DWCBTCENJZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private EJOQRXHTGDS EYIAQKNYCGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private YCKRWIQEMHS ZFZBEUSGTGF;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x927A630", Offset = "0x9279230", VA = "0x18927A630", Slot = "5")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x927A4D0", Offset = "0x92790D0", VA = "0x18927A4D0", Slot = "4")]
		[AsyncStateMachine(typeof(<GetRoomLoadRequestPayload>d__6))]
		public Task<RoomLoadRequestPayload> ESPDQTPUQOZ(StackTimer<string>.YOQUQHZDBKW a, RoomInstance b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x927A720", Offset = "0x9279320", VA = "0x18927A720")]
		[AsyncStateMachine(typeof(<GetRoomDetails>d__7))]
		private Task<RoomDetailsDTO> NIPSDWKWMSS(RoomInstance a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x927A1F0", Offset = "0x9278DF0", VA = "0x18927A1F0")]
		[AsyncStateMachine(typeof(<GetRoomLoadRequestPayloadFromDetailsAndSubroom>d__8))]
		private Task<RoomLoadRequestPayload> BFSCNIZICKD(RoomInstance a, RoomDetailsDTO b, long c, StackTimer<string>.YOQUQHZDBKW d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x927A360", Offset = "0x9278F60", VA = "0x18927A360")]
		[AsyncStateMachine(typeof(<GetRoomDataBlobWithHashForRoomDetails>d__9))]
		private Task<ResolvedLoadParameters> CUFGGIVLHRP(RoomInstance a, RoomDetailsDTO b, long c, StackTimer<string>.YOQUQHZDBKW d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x927A880", Offset = "0x9279480", VA = "0x18927A880")]
		[AsyncStateMachine(typeof(<GetDefaultRoomDataBlobWithHashForDorms>d__10))]
		private Task<ResolvedLoadParameters> ZFVUFYQGWDC(RoomInstance a, SubRoomDTO b, long c, StackTimer<string>.YOQUQHZDBKW d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public RoomManagerRoomLoadRequest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerSynchronization : BFALSPVIUPM, CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class HCFOWLTMZUC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public BURCCBMBLWO ZBJBQRAIHHQ;

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HCFOWLTMZUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x9273580", Offset = "0x9272180", VA = "0x189273580")]
			internal object EXYIYUCEWLH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public BURCCBMBLWO ZBJBQRAIHHQ;

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x9273080", Offset = "0x9271C80", VA = "0x189273080")]
			internal object ETWWYMCPNPC()
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
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public AsyncTaskMethodBuilder<BURCCBMBLWO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public BURCCBMBLWO request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public RoomManagerSynchronization <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public DGBVEOGIEQF pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			private Guid <requestGuid>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			private MessageKind <expectMessageKind>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			private MIJYCBDTSCQ <masterSwitchCancellationScope>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x9285810", Offset = "0x9284410", VA = "0x189285810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x92863B0", Offset = "0x9284FB0", VA = "0x1892863B0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public AsyncTaskMethodBuilder<BURCCBMBLWO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public BURCCBMBLWO request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public RoomManagerSynchronization <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public DGBVEOGIEQF pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			private TaskAwaiter<BURCCBMBLWO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x9286420", Offset = "0x9285020", VA = "0x189286420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x9286A20", Offset = "0x9285620", VA = "0x189286A20", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public AsyncTaskMethodBuilder<BURCCBMBLWO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public RoomManagerSynchronization <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public DGBVEOGIEQF pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			private TaskAwaiter<BufferedMessage> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x92886B0", Offset = "0x92872B0", VA = "0x1892886B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x9288C90", Offset = "0x9287890", VA = "0x189288C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private ZUUCGYXVQOS BRMMXAVOEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private ATUGFAVOUUQ ZVGGBZSEAKL;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private IOXWNGHJERA IOXWNGHJERA
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x927A9F0", Offset = "0x92795F0", VA = "0x18927A9F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x927AAB0", Offset = "0x92796B0", VA = "0x18927AAB0", Slot = "8")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x927AC60", Offset = "0x9279860", VA = "0x18927AC60", Slot = "4")]
		[AsyncStateMachine(typeof(<MasterSynchronizeRequest>d__6))]
		public Task<BURCCBMBLWO> OQDYMYLWFXS(BURCCBMBLWO a, DGBVEOGIEQF b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x927AFC0", Offset = "0x9279BC0", VA = "0x18927AFC0", Slot = "5")]
		[AsyncStateMachine(typeof(<PopNextBufferedEvent>d__7))]
		public Task<BURCCBMBLWO> TZCADQIDSFQ(CancellationToken a, DGBVEOGIEQF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x927ADC0", Offset = "0x92799C0", VA = "0x18927ADC0", Slot = "6")]
		public XMOUJWJJAGN PIJJFUOSCAR(UTQHQVVVWVQ a, StackTimer<string>.YOQUQHZDBKW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x927AB40", Offset = "0x9279740", VA = "0x18927AB40", Slot = "7")]
		public XMOUJWJJAGN NNYZGCLOEKM(UTQHQVVVWVQ a, StackTimer<string>.YOQUQHZDBKW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x927AE60", Offset = "0x9279A60", VA = "0x18927AE60")]
		[AsyncStateMachine(typeof(<MasterSyncRequestAndValidateResponse>d__10))]
		private Task<BURCCBMBLWO> TGUVAUEMGBN(BURCCBMBLWO a, DGBVEOGIEQF b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x41E0010", Offset = "0x41DEC10", VA = "0x1841E0010")]
		private static byte[] MPFEVTVNCLK(BURCCBMBLWO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public RoomManagerSynchronization()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerValidation : DTMXXXKYTWN, CZQABOPRBUR, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private RTJBHHWUTVH FSLPIMVUIYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private ZUUCGYXVQOS BRMMXAVOEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private AEVYTOMCPYJ MOLYBXRHHVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private EOTZPIOIQQD FPWGCGCQEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private QGGDGVMYJMC CTKZLRUOMOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private BLLZWPKKVFX TNXVWLQTBGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private EHHFOATIKRW LLAUQJADWPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private GBFVOIKQDIE DWCBTCENJZB;

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private HOAWKWPUPAK YDVANLETWMX
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x927B410", Offset = "0x927A010", VA = "0x18927B410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		private static DRXWOXZYIVH JTWZLIWMWLK
		{
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x927B280", Offset = "0x9279E80", VA = "0x18927B280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x927B2A0", Offset = "0x9279EA0", VA = "0x18927B2A0", Slot = "6")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x927B110", Offset = "0x9279D10", VA = "0x18927B110", Slot = "4")]
		public DRXWOXZYIVH DIAXXNSMZND(WJBKOLNRRJE a, RoomOperationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x927B460", Offset = "0x927A060", VA = "0x18927B460", Slot = "5")]
		public DRXWOXZYIVH PZBNXEIFMSQ(WJBKOLNRRJE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x927B290", Offset = "0x9279E90", VA = "0x18927B290")]
		private static DRXWOXZYIVH IXCYLINVJER(ValidationReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public RoomManagerValidation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class RoomOperationAlreadyInProgressException : InvalidOperationException
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x929CDC0", Offset = "0x929B9C0", VA = "0x18929CDC0")]
		public RoomOperationAlreadyInProgressException()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x83B1940", Offset = "0x83B0540", VA = "0x1883B1940")]
		public RoomOperationAlreadyInProgressException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[UnityEngine.Scripting.Preserve]
	internal sealed class RoomManagerAutosaves : UDGICGGHRKN, CZQABOPRBUR, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[CompilerGenerated]
		private struct <AwaitAutosaveInterval>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public CancellationToken nextAutosaveToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			private Task <delayTask>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			private TaskAwaiter<Task> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x929D9B0", Offset = "0x929C5B0", VA = "0x18929D9B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x929DE20", Offset = "0x929CA20", VA = "0x18929DE20", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public AsyncTaskMethodBuilder<DRXWOXZYIVH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public LYUZIEXLVDR autosaveRecordInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			private StackTimer<string> <timer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			private StackTimer<string>.YOQUQHZDBKW <timerScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			private YOVJFKTJHWR <operation>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			private TaskAwaiter<DRXWOXZYIVH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x92A09D0", Offset = "0x929F5D0", VA = "0x1892A09D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x92A13A0", Offset = "0x929FFA0", VA = "0x1892A13A0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public AutosaveType autosaveType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			private StackTimer<string> <timer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x92A7010", Offset = "0x92A5C10", VA = "0x1892A7010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x92A7580", Offset = "0x92A6180", VA = "0x1892A7580", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x92A6AC0", Offset = "0x92A56C0", VA = "0x1892A6AC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x92A6FB0", Offset = "0x92A5BB0", VA = "0x1892A6FB0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x92A62A0", Offset = "0x92A4EA0", VA = "0x1892A62A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x92A6A60", Offset = "0x92A5660", VA = "0x1892A6A60", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private CancellationTokenSource <combinedTokenSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x92A7BA0", Offset = "0x92A67A0", VA = "0x1892A7BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x92A82E0", Offset = "0x92A6EE0", VA = "0x1892A82E0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x92A79A0", Offset = "0x92A65A0", VA = "0x1892A79A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x92A7B40", Offset = "0x92A6740", VA = "0x1892A7B40", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public RoomManagerAutosaves <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private CancellationToken <nextAutosaveToken>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x92AAF40", Offset = "0x92A9B40", VA = "0x1892AAF40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x92AB650", Offset = "0x92AA250", VA = "0x1892AB650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private ZUUCGYXVQOS BRMMXAVOEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private FQSENOYUOAD PXZRTZVOQOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private QGGDGVMYJMC CTKZLRUOMOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private BFALSPVIUPM LRZZNGUBIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private AEVYTOMCPYJ MOLYBXRHHVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private EHHFOATIKRW LLAUQJADWPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private CancellationTokenSource XCDAMZHDHKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private Task RLCEAIVESMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private TaskCompletionSource<int> ZXIBPHNJASA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private int OZQVYBDYQEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private int ADISHVOQERK;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x929BBC0", Offset = "0x929A7C0", VA = "0x18929BBC0", Slot = "6")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x16709B0", Offset = "0x166F5B0", VA = "0x1816709B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x929BD70", Offset = "0x929A970", VA = "0x18929BD70")]
		private void MHKLKOYUFGZ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x929BE50", Offset = "0x929AA50", VA = "0x18929BE50", Slot = "4")]
		[AsyncStateMachine(typeof(<RequestRestoreAutosave>d__14))]
		public Task<DRXWOXZYIVH> RequestRestoreAutosave(LYUZIEXLVDR autosaveRecordInfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x929C730", Offset = "0x929B330", VA = "0x18929C730", Slot = "5")]
		[AsyncStateMachine(typeof(<RunRecoveryAutosave>d__15))]
		public Task ZEXCXKPDZPR([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x16709B0", Offset = "0x166F5B0", VA = "0x1816709B0")]
		public void XWEVBJXETZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x929C510", Offset = "0x929B110", VA = "0x18929C510")]
		private YOVJFKTJHWR YYVMRKSJKEE(LYUZIEXLVDR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x929C320", Offset = "0x929AF20", VA = "0x18929C320")]
		[AsyncStateMachine(typeof(<RunAutosaveRoutine>d__18))]
		private Task UQRVOWACDDO(CancellationToken a, int b, AccountRoleType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x929C220", Offset = "0x929AE20", VA = "0x18929C220")]
		[AsyncStateMachine(typeof(<RunAutosaveRoutineInternal>d__19))]
		private Task UKKXWEUARJL(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x929B9E0", Offset = "0x929A5E0", VA = "0x18929B9E0")]
		[AsyncStateMachine(typeof(<RunRecoveryAutosaveInternal>d__20))]
		private Task DPMMDDZKYEK([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x929BAD0", Offset = "0x929A6D0", VA = "0x18929BAD0")]
		[AsyncStateMachine(typeof(<ScheduleIncrementalAutosave>d__21))]
		private Task EFTCLMJOIDQ(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x929C410", Offset = "0x929B010", VA = "0x18929C410")]
		[AsyncStateMachine(typeof(<AwaitAutosaveInterval>d__22))]
		private Task YESOEWUMCAK(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x929C090", Offset = "0x929AC90", VA = "0x18929C090")]
		private Task UHRMJOADSEJ(AutosaveType a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x929BF80", Offset = "0x929AB80", VA = "0x18929BF80")]
		[AsyncStateMachine(typeof(<RunAutosave>d__24))]
		private Task RunAutosave(AutosaveType autosaveType, CancellationToken externalToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x929B770", Offset = "0x929A370", VA = "0x18929B770")]
		private bool BTQCCKQFIAF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public RoomManagerAutosaves()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomManagerSave : EOTZPIOIQQD, CZQABOPRBUR, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private struct <RequestSaveRoomToDisk>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public RoomManagerSave <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public string path;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			private StackTimer<string> <timer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x92A1410", Offset = "0x92A0010", VA = "0x1892A1410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x92A19A0", Offset = "0x92A05A0", VA = "0x1892A19A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private PXRJMKVWQUR LNNLSTADYEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private FQSENOYUOAD PXZRTZVOQOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private DTMXXXKYTWN SEHADCCHDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private BFALSPVIUPM LRZZNGUBIHN;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x929C8D0", Offset = "0x929B4D0", VA = "0x18929C8D0", Slot = "6")]
		public void Initialize(FQSENOYUOAD roomManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x929C880", Offset = "0x929B480", VA = "0x18929C880", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x929CBA0", Offset = "0x929B7A0", VA = "0x18929CBA0", Slot = "5")]
		[AsyncStateMachine(typeof(<RequestSaveRoomToDisk>d__6))]
		public Task RequestSaveRoomToDisk(string path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x929C820", Offset = "0x929B420", VA = "0x18929C820", Slot = "4")]
		public DRXWOXZYIVH BTQCCKQFIAF(WJBKOLNRRJE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x929CCA0", Offset = "0x929B8A0", VA = "0x18929CCA0")]
		private FYFHRUGSKNK ZZBLXQAQQRP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public RoomManagerSave()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public static class ATQIFLYQIEB
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x9292870", Offset = "0x9291470", VA = "0x189292870")]
		public static void QWUQUWBKDIT(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x9292630", Offset = "0x9291230", VA = "0x189292630")]
		internal static void BFWPMYEWLHC(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x9292790", Offset = "0x9291390", VA = "0x189292790")]
		internal static void MVBXYKJPDPD(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x9292AB0", Offset = "0x92916B0", VA = "0x189292AB0")]
		internal static void YFQLZEBTTSX(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x355D790", Offset = "0x355C390", VA = "0x18355D790")]
		private static void FMBLUBZOBJP<a, b, a>(DiContainer a) where b : a
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	internal class QSGJRACNCNK : BGDJXIYYMTU<BURCCBMBLWO>
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public BURCCBMBLWO IBBTTYTYKIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public string WJHHEWYXSOO;

			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x929A130", Offset = "0x9298D30", VA = "0x18929A130")]
			internal object KDWAJQBRMKT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public static readonly QSGJRACNCNK CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x929ABE0", Offset = "0x92997E0", VA = "0x18929ABE0")]
		public ExitGames.Client.Photon.Hashtable Serialize(BURCCBMBLWO message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x929AAB0", Offset = "0x92996B0", VA = "0x18929AAB0", Slot = "5")]
		protected override void QHSWALQLTMV(BURCCBMBLWO a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x929A770", Offset = "0x9299370", VA = "0x18929A770", Slot = "6")]
		public override BURCCBMBLWO Deserialize(IDictionary<object, object> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x929A9A0", Offset = "0x92995A0", VA = "0x18929A9A0")]
		private static void Log(string op, BURCCBMBLWO message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x929AF90", Offset = "0x9299B90", VA = "0x18929AF90")]
		public QSGJRACNCNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x929AC60", Offset = "0x9299860", VA = "0x18929AC60")]
		[CompilerGenerated]
		internal static string WVDAAEOHYPE(RoomLoadRequestPayload a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public static class XHOWJLNXSLC
	{
		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public static DRXWOXZYIVH JTWZLIWMWLK
		{
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0x92AEC30", Offset = "0x92AD830", VA = "0x1892AEC30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x92AECF0", Offset = "0x92AD8F0", VA = "0x1892AECF0")]
		public static bool IsSuccess(this DRXWOXZYIVH validationResult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x92AEC90", Offset = "0x92AD890", VA = "0x1892AEC90")]
		public static DRXWOXZYIVH IXCYLINVJER(ValidationReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x92AE7F0", Offset = "0x92AD3F0", VA = "0x1892AE7F0")]
		public static DRXWOXZYIVH BNBPXQGGOUW(IEnumerable<DRXWOXZYIVH> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x92AE9E0", Offset = "0x92AD5E0", VA = "0x1892AE9E0")]
		public static string EOWCJXTCGSX(this DRXWOXZYIVH a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public abstract class EXTZQLQPWJJ : IKZJVKXHGKW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		public delegate DRXWOXZYIVH ValidateOperation([NotNull] WJBKOLNRRJE networkPlayer);

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public WJBKOLNRRJE EEOXUZLRBFI;

			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x19464B0", Offset = "0x19450B0", VA = "0x1819464B0")]
			internal DRXWOXZYIVH RBGEELPGWHX(ValidateOperation a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private bool JDQGFFMCCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		protected readonly HashSet<ValidateOperation> AGNNPEMLOFE;

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x9293CC0", Offset = "0x92928C0", VA = "0x189293CC0", Slot = "4")]
		public void MKVCLHHBLSG(ValidateOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x9293C60", Offset = "0x9292860", VA = "0x189293C60", Slot = "5")]
		public void IPGNKZIEVJJ(ValidateOperation a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x9293C10", Offset = "0x9292810", VA = "0x189293C10", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x9293D20", Offset = "0x9292920", VA = "0x189293D20")]
		protected DRXWOXZYIVH XHUBSMRQBKD(WJBKOLNRRJE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x9293FB0", Offset = "0x9292BB0", VA = "0x189293FB0")]
		protected EXTZQLQPWJJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public class GSVKWWIMCHS : EXTZQLQPWJJ, RTJBHHWUTVH, IKZJVKXHGKW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class GWGISWCHLZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public DRXWOXZYIVH OZQWNDVSENS;

			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GWGISWCHLZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x9296680", Offset = "0x9295280", VA = "0x189296680")]
			internal object QGVILURPJJR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x9296610", Offset = "0x9295210", VA = "0x189296610")]
		[UnityEngine.Scripting.Preserve]
		public GSVKWWIMCHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x9296500", Offset = "0x9295100", VA = "0x189296500", Slot = "8")]
		public DRXWOXZYIVH TVMUMNHUIYV(WJBKOLNRRJE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public class MVVNGVLUMBO : EXTZQLQPWJJ, PXRJMKVWQUR, IKZJVKXHGKW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		[CompilerGenerated]
		private sealed class GWGISWCHLZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public DRXWOXZYIVH OZQWNDVSENS;

			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GWGISWCHLZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x9296620", Offset = "0x9295220", VA = "0x189296620")]
			internal object BJSJCOVTCWD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x9296610", Offset = "0x9295210", VA = "0x189296610")]
		[UnityEngine.Scripting.Preserve]
		public MVVNGVLUMBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x9298930", Offset = "0x9297530", VA = "0x189298930", Slot = "8")]
		public DRXWOXZYIVH BTQCCKQFIAF(WJBKOLNRRJE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	internal static class XVZHCRXETRE
	{
		[Cpp2IlInjected.Token(Token = "0x20000EE")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public StackTimer<string> BNXARLMEDQG;

			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x9293100", Offset = "0x9291D00", VA = "0x189293100")]
			internal object NWBBJAXUQPZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x92B0360", Offset = "0x92AEF60", VA = "0x1892B0360")]
		public static StackTimer<string> YOQUQHZDBKW(Log a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x92B01E0", Offset = "0x92AEDE0", VA = "0x1892B01E0")]
		public static void HUXSWHXBCIJ(StackTimer<string> a, Log b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x92B02A0", Offset = "0x92AEEA0", VA = "0x1892B02A0")]
		public static string SGJGYHWNAJU(BURCCBMBLWO a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	internal static class RJEKNEQFEAV
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x929B060", Offset = "0x9299C60", VA = "0x18929B060")]
		public static void UFDNYFPBEDW(this ZUUCGYXVQOS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x929B050", Offset = "0x9299C50", VA = "0x18929B050")]
		public static void BQCZJNFYPPH(this ZUUCGYXVQOS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x929B070", Offset = "0x9299C70", VA = "0x18929B070")]
		private static void XHWDMZPFCZJ(this ZUUCGYXVQOS a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public class NGKDTAERGDE : YGYNNKGMBTM, TQBBOSYCXSX, DEUAISEJQSQ, ZAMSNYKZUGX
	{
		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		private class OKABTHYBEYA : RQAGMLJLYPY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			private readonly byte HMZSUAOCTVG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			private readonly int HVXWXFEMJPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			private readonly object PWCWPPAXDCG;

			[Cpp2IlInjected.Token(Token = "0x170000CE")]
			public byte VUTIZLHWNDC
			{
				[Cpp2IlInjected.Token(Token = "0x6000472")]
				[Cpp2IlInjected.Address(RVA = "0xBF7030", Offset = "0xBF5C30", VA = "0x180BF7030", Slot = "4")]
				get
				{
					return default(byte);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			public int ZIHFNJEOTOM
			{
				[Cpp2IlInjected.Token(Token = "0x6000473")]
				[Cpp2IlInjected.Address(RVA = "0xB69740", Offset = "0xB68340", VA = "0x180B69740", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D0")]
			public object CVLYVVPBTUS
			{
				[Cpp2IlInjected.Token(Token = "0x6000474")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D1")]
			public object this[byte key]
			{
				[Cpp2IlInjected.Token(Token = "0x6000475")]
				[Cpp2IlInjected.Address(RVA = "0x9299510", Offset = "0x9298110", VA = "0x189299510", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x83B91F0", Offset = "0x83B7DF0", VA = "0x1883B91F0")]
			public OKABTHYBEYA(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x92994D0", Offset = "0x92980D0", VA = "0x1892994D0", Slot = "8")]
			public bool KCRQOJGIJUH(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly TQBBOSYCXSX EEIOFDHTMKX;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public WJBKOLNRRJE PJLHQEFHPQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x92992B0", Offset = "0x9297EB0", VA = "0x1892992B0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public int OJYHBYGGBKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x9298B90", Offset = "0x9297790", VA = "0x189298B90", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public int XGUNJTFPWQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x9299300", Offset = "0x9297F00", VA = "0x189299300", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public WJBKOLNRRJE EDOAEKBLKMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x9298CE0", Offset = "0x92978E0", VA = "0x189298CE0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public bool FXGVBLNCOGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public int WXFAOCQLSOT
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public string MVDTPWRFZDU
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x9298F70", Offset = "0x9297B70", VA = "0x189298F70", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Func<string, string> KHSBOZUXYFX
		{
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x9298EB0", Offset = "0x9297AB0", VA = "0x189298EB0", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<string, long> HNQJJDSIEUA
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<RQAGMLJLYPY> LTYUWEJPATT
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x9298C30", Offset = "0x9297830", VA = "0x189298C30", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x9298A40", Offset = "0x9297640", VA = "0x189298A40", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<bool> GUQAEBIOGME
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "26")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "27")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<WJBKOLNRRJE> GXYINHYWKGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "9")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action QWLHGMBBCAB
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x9298E10", Offset = "0x9297A10", VA = "0x189298E10", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x9298AF0", Offset = "0x92976F0", VA = "0x189298AF0", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x92991B0", Offset = "0x9297DB0", VA = "0x1892991B0", Slot = "19")]
		public void TEDPDIJZHPG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0xF09A40", Offset = "0xF08640", VA = "0x180F09A40")]
		public NGKDTAERGDE(TQBBOSYCXSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x9298FD0", Offset = "0x9297BD0", VA = "0x189298FD0", Slot = "8")]
		public bool RaiseEvent(byte eventCode, object eventContent, PZIMWREHPGJ raiseEventOptions, RRNetworkDelivery networkDelivery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x9299210", Offset = "0x9297E10", VA = "0x189299210", Slot = "20")]
		public WJBKOLNRRJE TRBSVSFBQLQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x9298D30", Offset = "0x9297930", VA = "0x189298D30", Slot = "21")]
		public WJBKOLNRRJE OUPJDKYGOPG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x92990D0", Offset = "0x9297CD0", VA = "0x1892990D0", Slot = "22")]
		public WJBKOLNRRJE SYFRPMTIPBU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x9299350", Offset = "0x9297F50", VA = "0x189299350", Slot = "23")]
		public IReadOnlyList<WJBKOLNRRJE> XXSWMMVJKIC(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x9299430", Offset = "0x9298030", VA = "0x189299430", Slot = "24")]
		public IReadOnlyList<WJBKOLNRRJE> YFINFNYJFCJ(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "25")]
		public bool DXTAWHMKVAW(WJBKOLNRRJE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "28")]
		public void PMRQIQBTZFH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "29")]
		public void RMYFRHSOQLY(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "30")]
		public void HGMBNHCNDSA(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x9298BE0", Offset = "0x92977E0", VA = "0x189298BE0", Slot = "31")]
		public IDisposable DAKDCLFGMZZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "32")]
		private bool MAKGVUVGNPY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "33")]
		public void AWJVDUGBGWC(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x11EA7B0", Offset = "0x11E93B0", VA = "0x1811EA7B0", Slot = "34")]
		public bool NYFDCYUFZAF(bool a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x118ABC0", Offset = "0x11897C0", VA = "0x18118ABC0", Slot = "37")]
		public void FCEYJEZERTK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	internal struct OperationEventData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private readonly IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		public OperationEventData(IDictionary<object, object> eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x929A080", Offset = "0x9298C80", VA = "0x18929A080")]
		public bool QEGPNYOCDIS([Out] BURCCBMBLWO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x9299FD0", Offset = "0x9298BD0", VA = "0x189299FD0")]
		public Guid OUVAKBRYGRX()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x9299E90", Offset = "0x9298A90", VA = "0x189299E90")]
		public DRXWOXZYIVH HHSGVFMYWEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x9299DA0", Offset = "0x92989A0", VA = "0x189299DA0")]
		public static ExitGames.Client.Photon.Hashtable Create(BURCCBMBLWO message, DRXWOXZYIVH validationResult)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	internal static class QZWPFERSCYD
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x929AFD0", Offset = "0x9299BD0", VA = "0x18929AFD0")]
		public static bool GPYGFAQZHEE(this RoomInstance a)
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
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public Func<CancellationToken, List<Task>> taskGenerator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public TaskRunner <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0x92A8340", Offset = "0x92A6F40", VA = "0x1892A8340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0x92A8520", Offset = "0x92A7120", VA = "0x1892A8520", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private readonly CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private bool isDisposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private Task task;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public bool SNDHVNFTAHT
		{
			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0x929D6F0", Offset = "0x929C2F0", VA = "0x18929D6F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x929D880", Offset = "0x929C480", VA = "0x18929D880")]
		public TaskRunner(CancellationToken cancellationToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x929D770", Offset = "0x929C370", VA = "0x18929D770")]
		[AsyncStateMachine(typeof(<RunTasks>d__8))]
		public Task LURDRKRQGOY(Func<CancellationToken, List<Task>> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x929D720", Offset = "0x929C320", VA = "0x18929D720", Slot = "4")]
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
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public AsyncTaskMethodBuilder<Result<ParseResult<TData>, UTITDXZLKVK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public StackTimer<string>.YOQUQHZDBKW timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public string timerName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public VersionedDataGetter<TGetDataArg, TData> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public TGetDataArg arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private TaskAwaiter<Result<ParseResult<TData>, UTITDXZLKVK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x53BDDA0", Offset = "0x53BC9A0", VA = "0x1853BDDA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x53BE460", Offset = "0x53BD060", VA = "0x1853BE460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly RIYLHVUCOKK<TGetDataArg, TData> _deps;

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		internal VersionedDataGetter(RIYLHVUCOKK<TGetDataArg, TData> deps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x6D102E0", Offset = "0x6D0EEE0", VA = "0x186D102E0")]
		[AsyncStateMachine(typeof(VersionedDataGetter<, >.<DownloadAndParse>d__2))]
		public Task<Result<ParseResult<TData>, UTITDXZLKVK>> SNKERZEVLOV(TGetDataArg a, string b, StackTimer<string>.YOQUQHZDBKW c, CancellationToken d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public static class DWCZAYQAMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x3A8DDD0", Offset = "0x3A8C9D0", VA = "0x183A8DDD0")]
		public static VersionedDataGetter<TGetDataArg, TData> New<TGetDataArg, TData>(RIYLHVUCOKK<TGetDataArg, TData> deps)
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
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		public readonly int Code;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public readonly int? SubCode;

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x596EA90", Offset = "0x596D690", VA = "0x18596EA90")]
		public ErrorCode(int code, [Optional] int? subCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x9296010", Offset = "0x9294C10", VA = "0x189296010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public interface GMEPXDWSTMG<a> where a : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YIJGXXQZOQF();

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GMEPXDWSTMG<a> TCQYPAAIJQY(string a);

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GMEPXDWSTMG<a> LNDNATLISKP(UserFriendlyErrorMessageBuilder<a> a);

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GMEPXDWSTMG<a> EGRTEJVNFAQ(int a);

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GMEPXDWSTMG<a> WAPLLYXARAX(int a, GetSubCode<a> b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public interface QGKXFWXFKWC
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GMEPXDWSTMG<a> UXKWKZQZPTP<a>() where a : Exception;

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "1")]
		UserFriendlyErrorInfo HYEJSFXLKLK(Exception a);

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ErrorCode ZMWCBNJDRQC(Exception a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public delegate string UserFriendlyErrorMessageBuilder<in T>(T ex) where T : Exception;
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public delegate int GetSubCode<in T>(T ex) where T : Exception;
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	internal class IHZAXBNSVYL : QGKXFWXFKWC
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		private delegate string UserFriendlyErrorMessageBuilder(Exception ex);

		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private delegate int GetSubCodeInternal(Exception ex);

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		private class Registration<T> : GMEPXDWSTMG<T> where T : notnull, Exception
		{
			[Cpp2IlInjected.Token(Token = "0x2000102")]
			[CompilerGenerated]
			private sealed class CWLCWDGOHPR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003CD")]
				public string DRNTHWSFOJO;

				[Cpp2IlInjected.Token(Token = "0x60004AF")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public CWLCWDGOHPR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B0")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				internal string OQRHYSJMUMQ(Exception a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000103")]
			[CompilerGenerated]
			private sealed class PYHWMDJZEDC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003CE")]
				public UserFriendlyErrorMessageBuilder<T> PYOPPOOISLZ;

				[Cpp2IlInjected.Token(Token = "0x60004B1")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public PYHWMDJZEDC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B2")]
				[Cpp2IlInjected.Address(RVA = "0x61973B0", Offset = "0x6195FB0", VA = "0x1861973B0")]
				internal string HTZYSBSTWOR(Exception a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[CompilerGenerated]
			private sealed class TMFRKOCFRTN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003CF")]
				public GetSubCode<T> YRHQWFRHSDU;

				[Cpp2IlInjected.Token(Token = "0x60004B3")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public TMFRKOCFRTN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004B4")]
				[Cpp2IlInjected.Address(RVA = "0x61973B0", Offset = "0x6195FB0", VA = "0x1861973B0")]
				internal int LUQSVGNTITX(Exception a)
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			private readonly IHZAXBNSVYL RJJCUZXOQNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private readonly Type UBJQLJZTKTY;

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x648DE60", Offset = "0x648CA60", VA = "0x18648DE60")]
			internal Registration(IHZAXBNSVYL errorRegistry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x648DE30", Offset = "0x648CA30", VA = "0x18648DE30", Slot = "4")]
			public void YIJGXXQZOQF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x648DC20", Offset = "0x648C820", VA = "0x18648DC20", Slot = "5")]
			public GMEPXDWSTMG<T> TCQYPAAIJQY(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x648DB20", Offset = "0x648C720", VA = "0x18648DB20", Slot = "6")]
			public GMEPXDWSTMG<T> LNDNATLISKP(UserFriendlyErrorMessageBuilder<T> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x648DAE0", Offset = "0x648C6E0", VA = "0x18648DAE0", Slot = "7")]
			public GMEPXDWSTMG<T> EGRTEJVNFAQ(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x648DD20", Offset = "0x648C920", VA = "0x18648DD20", Slot = "8")]
			public GMEPXDWSTMG<T> WAPLLYXARAX(int a, GetSubCode<T> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000105")]
		private class THZCUWNNPHM<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			private bool HTJAVVGEAKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			private readonly List<Type> SMDFERQASYE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			private readonly Dictionary<Type, a> EIFCTRNWTTP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			private readonly Dictionary<Type, int> LRHDPEGJQWS;

			[Cpp2IlInjected.Token(Token = "0x170000D3")]
			public IReadOnlyList<Type> FVSDFEYYLSK
			{
				[Cpp2IlInjected.Token(Token = "0x60004B7")]
				[Cpp2IlInjected.Address(RVA = "0x65E93F0", Offset = "0x65E7FF0", VA = "0x1865E93F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x65E99B0", Offset = "0x65E85B0", VA = "0x1865E99B0")]
			public THZCUWNNPHM(Dictionary<Type, int> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x65E91F0", Offset = "0x65E7DF0", VA = "0x1865E91F0")]
			public void Add(Type key, a val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x65E9750", Offset = "0x65E8350", VA = "0x1865E9750")]
			public bool WCGKIWFRLDF(Type a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x65E9720", Offset = "0x65E8320", VA = "0x1865E9720")]
			public bool RECRATNZGFH(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x65E9310", Offset = "0x65E7F10", VA = "0x1865E9310")]
			public a Get(Type type)
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x65E9910", Offset = "0x65E8510", VA = "0x1865E9910")]
			[CompilerGenerated]
			private int ZUIJFUXXJZX(Type a, Type b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000107")]
		[CompilerGenerated]
		private sealed class OOLNAPSVTRB : IEnumerable<ErrorCode>, IEnumerable, IEnumerator<ErrorCode>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private ErrorCode DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			private int RPOQDRFWNXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public IHZAXBNSVYL VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			private Exception GKPWMWJXCRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public Exception FPSLGOKGLSP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			private IEnumerator<Exception> OKMXNYRHUZP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private IEnumerator<ErrorCode> OJXCWEJPSRO;

			[Cpp2IlInjected.Token(Token = "0x170000D4")]
			private ErrorCode GBVHKZMMLGU
			{
				[Cpp2IlInjected.Token(Token = "0x60004C5")]
				[Cpp2IlInjected.Address(RVA = "0x4D1A790", Offset = "0x4D19390", VA = "0x184D1A790", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ErrorCode);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D5")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60004C7")]
				[Cpp2IlInjected.Address(RVA = "0x92995C0", Offset = "0x92981C0", VA = "0x1892995C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public OOLNAPSVTRB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x9299C50", Offset = "0x9298850", VA = "0x189299C50", Slot = "7")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x9299610", Offset = "0x9298210", VA = "0x189299610", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x9299BC0", Offset = "0x92987C0", VA = "0x189299BC0")]
			private void QCWGZBRZQOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x9299B70", Offset = "0x9298770", VA = "0x189299B70")]
			private void QCRABUYCHCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x9299C10", Offset = "0x9298810", VA = "0x189299C10", Slot = "10")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x9299AC0", Offset = "0x92986C0", VA = "0x189299AC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ErrorCode> OWGBBSUKJXZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x9299AC0", Offset = "0x92986C0", VA = "0x189299AC0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private static readonly ErrorCode MTHVTJBDVTB;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private static readonly Dictionary<Type, int> DAJATEXILTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private readonly HashSet<Type> PEIOOXOEGRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private readonly THZCUWNNPHM<int> EOFPIYXFHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private readonly THZCUWNNPHM<GetSubCodeInternal> MWEXSTAEQSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly THZCUWNNPHM<UserFriendlyErrorMessageBuilder> GITTTWJGVKC;

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x9296840", Offset = "0x9295440", VA = "0x189296840")]
		[IFIZWETSKCB.Root.GameOnly]
		internal static void IFIZWETSKCB(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x92979F0", Offset = "0x92965F0", VA = "0x1892979F0")]
		[RecRoom.NoEngine.Common.Preserve]
		public IHZAXBNSVYL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5280", Offset = "0x3BF3E80", VA = "0x183BF5280", Slot = "4")]
		public GMEPXDWSTMG<T> UXKWKZQZPTP<T>() where T : notnull, Exception
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x92967B0", Offset = "0x92953B0", VA = "0x1892967B0", Slot = "5")]
		public UserFriendlyErrorInfo HYEJSFXLKLK(Exception a)
		{
			return default(UserFriendlyErrorInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x9297730", Offset = "0x9296330", VA = "0x189297730", Slot = "6")]
		public ErrorCode ZMWCBNJDRQC(Exception? a)
		{
			return default(ErrorCode);
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x92968B0", Offset = "0x92954B0", VA = "0x1892968B0", Slot = "7")]
		[IteratorStateMachine(typeof(OOLNAPSVTRB))]
		public IEnumerable<ErrorCode> JAGGVLGAGHU(Exception a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x9296940", Offset = "0x9295540", VA = "0x189296940", Slot = "8")]
		public string MKNDPETQSTQ(Exception? ex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x9297430", Offset = "0x9296030", VA = "0x189297430")]
		private string VFSIMXKAECY(AggregateException a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x9296F50", Offset = "0x9295B50", VA = "0x189296F50")]
		private void PWIQUPGTSXA(Type a, int b, GetSubCodeInternal? getSubCodeInternal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x9296D30", Offset = "0x9295930", VA = "0x189296D30")]
		private void PDTRTNJYDYE(Type a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x9296A90", Offset = "0x9295690", VA = "0x189296A90")]
		private void NMTCLVWMMRL(Type a, UserFriendlyErrorMessageBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x92972C0", Offset = "0x9295EC0", VA = "0x1892972C0")]
		private static int REORZHTJHIJ(Type a, Dictionary<Type, int> b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5570", Offset = "0x3BF4170", VA = "0x183BF5570")]
		private static bool XWLUZQLBQXY<TVal>(THZCUWNNPHM<TVal> a, Type b, [Out] TVal c) where TVal : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x92966E0", Offset = "0x92952E0", VA = "0x1892966E0")]
		[CompilerGenerated]
		internal static int BUEOERJYCNW(Type a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public struct UserFriendlyErrorInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public readonly ErrorCode ErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public readonly string UserFriendlyMessage;

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x92AD790", Offset = "0x92AC390", VA = "0x1892AD790")]
		public UserFriendlyErrorInfo(string userFriendlyMessage, ErrorCode errorCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x92AD6F0", Offset = "0x92AC2F0", VA = "0x1892AD6F0")]
		public string ZVOVTEQTZNQ()
		{
			return null;
		}
	}
}
namespace RecRoom.RoomLoading.RoomOperation
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public class VNEBTMGFLNZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private readonly PPDHWZWSJQC CLSAFOEZCRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private string AHNMOOWSGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private long? FHPCLHMZGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private long? QZFTMLRVIEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private long? SQXSBXFSOUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private string NYZGJMRRDYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private RoomOperationState XUFYZMIGOEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private long? JSLMYJLNHXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private bool YOUPGMBJQWJ;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public string CBGYIEKXKQU
		{
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public long LHDJSIXDZJE
		{
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0x92AD7F0", Offset = "0x92AC3F0", VA = "0x1892AD7F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public long FJDMBSISXQE
		{
			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x92ADB00", Offset = "0x92AC700", VA = "0x1892ADB00")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public long YINTOKKSZCB
		{
			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x92ADAA0", Offset = "0x92AC6A0", VA = "0x1892ADAA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public string GKWPVTAIEKU
		{
			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x92AD7B0", Offset = "0x92AC3B0", VA = "0x1892AD7B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public RoomOperationState FXMCDPTWJYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0xE1C0C0", Offset = "0xE1ACC0", VA = "0x180E1C0C0")]
			get
			{
				return default(RoomOperationState);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x92AE040", Offset = "0x92ACC40", VA = "0x1892AE040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public long AFMVTMAPHHF
		{
			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x92ADC00", Offset = "0x92AC800", VA = "0x1892ADC00")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x92AE5C0", Offset = "0x92AD1C0", VA = "0x1892AE5C0")]
		[UnityEngine.Scripting.Preserve]
		public VNEBTMGFLNZ([Inject(null)] PPDHWZWSJQC playerPreferences)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x92AD850", Offset = "0x92AC450", VA = "0x1892AD850")]
		private void FPPUUSCUXGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x92AE130", Offset = "0x92ACD30", VA = "0x1892AE130")]
		public void XRFLKIJETDK(long a, long b, [Optional] long? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x92ADB60", Offset = "0x92AC760", VA = "0x1892ADB60")]
		public void IVOFZQZYGMS(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x92ADC60", Offset = "0x92AC860", VA = "0x1892ADC60")]
		public void NTRVWNZMUOT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x92ADCE0", Offset = "0x92AC8E0", VA = "0x1892ADCE0")]
		public void RNSMBHPYURU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	internal class XMOUJWJJAGN : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010E")]
		[CompilerGenerated]
		private struct <>c__DisplayClass13_0<T> where T : IMessage<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public byte[] message;
		}

		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[CompilerGenerated]
		private sealed class XLYSDAWRGEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public BURCCBMBLWO AIZJFSIOBSW;

			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XLYSDAWRGEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FD")]
			[Cpp2IlInjected.Address(RVA = "0x92AED10", Offset = "0x92AD910", VA = "0x1892AED10")]
			internal BURCCBMBLWO ENZELIIBFLJ(byte[] a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000110")]
		[CompilerGenerated]
		private sealed class TZPDHATRBYX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Func<Guid, bool> AZNDTQHUHYY;

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TZPDHATRBYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0x929D690", Offset = "0x929C290", VA = "0x18929D690")]
			internal object GDUTTBWFHIQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x929D5D0", Offset = "0x929C1D0", VA = "0x18929D5D0")]
			internal bool BJQEREZEVSO(Guid a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000111")]
		[CompilerGenerated]
		private sealed class OJDMKISOMTK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public Func<Guid, bool> OHFJEXEXDML;

			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public OJDMKISOMTK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0x9299470", Offset = "0x9298070", VA = "0x189299470")]
			internal object FHRUVPPHARE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[CompilerGenerated]
		private sealed class CLOJKKCVFXH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Guid BVVYBDQDIZS;

			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CLOJKKCVFXH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0x92932C0", Offset = "0x9291EC0", VA = "0x1892932C0")]
			internal object WBKDSXMDHZO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000113")]
		[CompilerGenerated]
		private sealed class OMRVDWPWADA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			public Guid BVVYBDQDIZS;

			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public OMRVDWPWADA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0x9299550", Offset = "0x9298150", VA = "0x189299550")]
			internal object AEJEJDWXJYP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000114")]
		[CompilerGenerated]
		private sealed class XZKJDTPKGJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			public XMOUJWJJAGN VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			public string INXXNEXDCRU;

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XZKJDTPKGJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0x92B0430", Offset = "0x92AF030", VA = "0x1892B0430")]
			internal object KDWAJQBRMKT()
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
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public XMOUJWJJAGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			public int maxAttempts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x54B6330", Offset = "0x54B4F30", VA = "0x1854B6330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0x53BE460", Offset = "0x53BD060", VA = "0x1853BE460", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public XMOUJWJJAGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			public Func<CancellationToken, Task> masterLockedCodeBlock;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			public int maxAttempts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600050B")]
			[Cpp2IlInjected.Address(RVA = "0x929FA80", Offset = "0x929E680", VA = "0x18929FA80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0x929FD60", Offset = "0x929E960", VA = "0x18929FD60", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public AsyncTaskMethodBuilder<BURCCBMBLWO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public BURCCBMBLWO roomOperationMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			public XMOUJWJJAGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000413")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000414")]
			private TaskAwaiter<IOXWNGHJERA.BufferedMessage<BURCCBMBLWO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600050D")]
			[Cpp2IlInjected.Address(RVA = "0x92A0420", Offset = "0x929F020", VA = "0x1892A0420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0x92A0960", Offset = "0x929F560", VA = "0x1892A0960", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public AsyncTaskMethodBuilder<IOXWNGHJERA.BufferedMessage<BURCCBMBLWO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public BURCCBMBLWO roomOperationMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public XMOUJWJJAGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private MessageKind <expectedMessageKind>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			private ByteString <expectedOperationId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			private TaskAwaiter<IOXWNGHJERA.BufferedMessage<BURCCBMBLWO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x929FDC0", Offset = "0x929E9C0", VA = "0x18929FDC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x92A03B0", Offset = "0x929EFB0", VA = "0x1892A03B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private static readonly Guid NSLBWSZLPBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public readonly UTQHQVVVWVQ CUQMBSKIYKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private readonly IOXWNGHJERA ZAKBFOKJGZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private readonly DEUAISEJQSQ BRMMXAVOEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private readonly ZAMSNYKZUGX UNLKVIBPGXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private bool JAYSLEXTALM;

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x92AFFD0", Offset = "0x92AEBD0", VA = "0x1892AFFD0")]
		public XMOUJWJJAGN(UTQHQVVVWVQ a, IOXWNGHJERA b, DEUAISEJQSQ c, ZAMSNYKZUGX d, StackTimer<string>.YOQUQHZDBKW e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x92AEDF0", Offset = "0x92AD9F0", VA = "0x1892AEDF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x92AEE00", Offset = "0x92ADA00", VA = "0x1892AEE00")]
		public void FLFATVABSCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x92AEF20", Offset = "0x92ADB20", VA = "0x1892AEF20")]
		public void JTKKZZPGGWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x92AF870", Offset = "0x92AE470", VA = "0x1892AF870")]
		public void SLPVECZXGHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x92AF120", Offset = "0x92ADD20", VA = "0x1892AF120")]
		[AsyncStateMachine(typeof(<MasterSendAllReceive>d__11))]
		internal Task<BURCCBMBLWO> LSWDKPEDAZH(StackTimer<string>.YOQUQHZDBKW a, BURCCBMBLWO b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x41E0010", Offset = "0x41DEC10", VA = "0x1841E0010")]
		private static byte[] YLZHFAITCNY<a>(a a) where a : IMessage<a>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x41DFCD0", Offset = "0x41DE8D0", VA = "0x1841DFCD0")]
		private static b NYEPXVKXCVF<b>(MessageParser<b> a, byte[] b, b c) where b : IMessage<b>
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x92AF6B0", Offset = "0x92AE2B0", VA = "0x1892AF6B0")]
		[AsyncStateMachine(typeof(<MasterSendAllReceiveBufferedMessage>d__14))]
		private Task<IOXWNGHJERA.BufferedMessage<BURCCBMBLWO>> QOQDEUYJUBL(BURCCBMBLWO a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x41DF710", Offset = "0x41DE310", VA = "0x1841DF710")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__15<>))]
		internal Task<c> MCXDQDAINVE<c>(CancellationToken a, Func<CancellationToken, Task<c>> b, int c = 3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x92AF390", Offset = "0x92ADF90", VA = "0x1892AF390")]
		[AsyncStateMachine(typeof(<MasterLockedBlock>d__16))]
		internal Task MCXDQDAINVE(CancellationToken a, Func<CancellationToken, Task> b, int c = 3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x92AF4C0", Offset = "0x92AE0C0", VA = "0x1892AF4C0")]
		public RoomUploadLogic MJADRQHUGGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x92AF7F0", Offset = "0x92AE3F0", VA = "0x1892AF7F0")]
		public EZWPWVHNECU RKQXMDIXUWU([Optional] LYPKNRFXAJP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x92AFB90", Offset = "0x92AE790", VA = "0x1892AFB90")]
		public MIQJZUVSHJV ULKKLACIGXV([Optional] Log? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x92AFA40", Offset = "0x92AE640", VA = "0x1892AFA40")]
		public void UATLXCLZKOQ(Func<Guid, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x92AFE50", Offset = "0x92AEA50", VA = "0x1892AFE50")]
		public void YUFVAFXHPRA(Func<Guid, bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x92AF530", Offset = "0x92AE130", VA = "0x1892AF530")]
		public Guid MKAWWNAOLWM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x92AF930", Offset = "0x92AE530", VA = "0x1892AF930")]
		public void TYFVICHFCJD(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x92AEFE0", Offset = "0x92ADBE0", VA = "0x1892AEFE0")]
		public void KUTTVAMRFYV(BURCCBMBLWO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x92AF280", Offset = "0x92ADE80", VA = "0x1892AF280")]
		public void Log(string stepMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x41DFE80", Offset = "0x41DEA80", VA = "0x1841DFE80")]
		private d XFAURXNFCUJ<d>(d a) where d : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x92AFE00", Offset = "0x92AEA00", VA = "0x1892AFE00")]
		public void XLAZLWYFYSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x41DF320", Offset = "0x41DDF20", VA = "0x1841DF320")]
		[CompilerGenerated]
		internal static string CLZFSDVBSFX<e>(byte[] a, int b = 15, <>c__DisplayClass13_0<e> c) where e : IMessage<e>
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	internal sealed class InitialRoomLoadOperation : UTQHQVVVWVQ
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		[CompilerGenerated]
		private sealed class CITSQHBYTVL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public PlayerPresence UJLYVJLXKDW;

			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CITSQHBYTVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x9293180", Offset = "0x9291D80", VA = "0x189293180")]
			internal object RHBKQTKQBMK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011C")]
		[CompilerGenerated]
		private sealed class GLPIMGKKXXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public Guid EUJKWVXHRZV;

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GLPIMGKKXXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x9296490", Offset = "0x9295090", VA = "0x189296490")]
			internal object IXHFKDJBLMB()
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
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public InitialRoomLoadOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			private bool <omIsEnabled>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private bool <omShouldBeEnabled>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			private RoomDetailsDTO <roomDetailsDTO>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			private TaskAwaiter<int> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x929E980", Offset = "0x929D580", VA = "0x18929E980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x929F560", Offset = "0x929E160", VA = "0x18929F560", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public InitialRoomLoadOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<SubRoomDataSaveWithUnityAssetsDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(RVA = "0x929F5C0", Offset = "0x929E1C0", VA = "0x18929F5C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0x929FA10", Offset = "0x929E610", VA = "0x18929FA10", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public InitialRoomLoadOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public XMOUJWJJAGN operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			private PlayerPresence <presence>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private EZWPWVHNECU <loadLogic>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			private TaskAwaiter<Scene> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			private TaskAwaiter<QOIZLNOTUDV> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000525")]
			[Cpp2IlInjected.Address(RVA = "0x92A4930", Offset = "0x92A3530", VA = "0x1892A4930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0x92A5830", Offset = "0x92A4430", VA = "0x1892A5830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private static readonly Log QGEGZYQIOAN;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private static readonly Log DKBRJXASAVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private readonly RoomLoadRequestPayload LIREINMTFBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private readonly RoomInstance BADSHGCJWPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private readonly LYPKNRFXAJP BXVMSXNGMKN;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x9298380", Offset = "0x9296F80", VA = "0x189298380")]
		public InitialRoomLoadOperation(RoomLoadRequestPayload initialRoomLoadPayload, RoomInstance originalTargetRoomInstance, Guid operationId, FQSENOYUOAD roomManager, DGBVEOGIEQF operationPauseToken, LYPKNRFXAJP preloadContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x9297D70", Offset = "0x9296970", VA = "0x189297D70", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__8))]
		protected override Task ELTEGZCMVCW(XMOUJWJJAGN a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x9297EC0", Offset = "0x9296AC0", VA = "0x189297EC0")]
		[AsyncStateMachine(typeof(<EnableDisableObjectModel>d__9))]
		private Task EnableDisableObjectModel(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x9298190", Offset = "0x9296D90", VA = "0x189298190")]
		[AsyncStateMachine(typeof(<GetSubroomSaveOMVersion>d__10))]
		private Task<int> QTZPJUIDOEH(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x9297FC0", Offset = "0x9296BC0", VA = "0x189297FC0")]
		private PlayerPresence JECVZLLGADQ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	internal class YOVJFKTJHWR : UTQHQVVVWVQ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		[CompilerGenerated]
		private struct <RunAsync>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public YOVJFKTJHWR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public XMOUJWJJAGN operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0x92A5890", Offset = "0x92A4490", VA = "0x1892A5890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0x92A6240", Offset = "0x92A4E40", VA = "0x1892A6240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private readonly int QFXDFPWWMTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private readonly LYUZIEXLVDR EMNPFRKRHQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public readonly long IKDXOFHMFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public readonly long TJEYODASRLF;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public SaveSubRoomResponseDTO YHFSNNZESGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0xB1D750", Offset = "0xB1C350", VA = "0x180B1D750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0xB1D7C0", Offset = "0xB1C3C0", VA = "0x180B1D7C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x92B0780", Offset = "0x92AF380", VA = "0x1892B0780")]
		public YOVJFKTJHWR(Guid a, FQSENOYUOAD b, DGBVEOGIEQF c, int d, LYUZIEXLVDR e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x92B0660", Offset = "0x92AF260", VA = "0x1892B0660", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__9))]
		protected override Task ELTEGZCMVCW(XMOUJWJJAGN a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal abstract class JPXEBEJVKFZ : UTQHQVVVWVQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public JPXEBEJVKFZ VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public IDisposable ZSHWYFCJEBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public JCQFFOYMZSD ZKQSUYOUOAG;

			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x9298860", Offset = "0x9297460", VA = "0x189298860")]
			internal Task FLPHWHPYPRU(StackTimer<string>.YOQUQHZDBKW a, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0x92988A0", Offset = "0x92974A0", VA = "0x1892988A0")]
			internal object FLUOTOJVZDD()
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
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public StackTimer<string>.YOQUQHZDBKW timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			public IDisposable freezePlayerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public JCQFFOYMZSD playerDespawn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public JPXEBEJVKFZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0x92A1A00", Offset = "0x92A0600", VA = "0x1892A1A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x92A1FC0", Offset = "0x92A0BC0", VA = "0x1892A1FC0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			public JPXEBEJVKFZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			public XMOUJWJJAGN operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			private LIKIZMPSLOB <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x92A24B0", Offset = "0x92A10B0", VA = "0x1892A24B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x92A2DA0", Offset = "0x92A19A0", VA = "0x1892A2DA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x9298810", Offset = "0x9297410", VA = "0x189298810")]
		public JPXEBEJVKFZ(Guid a, FQSENOYUOAD b, DGBVEOGIEQF c, string d, RequestOperationType e, bool f = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x9298520", Offset = "0x9297120", VA = "0x189298520", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__2))]
		protected override Task ELTEGZCMVCW(XMOUJWJJAGN a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract Task KXCPZYMWXLN(XMOUJWJJAGN a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x9298660", Offset = "0x9297260", VA = "0x189298660")]
		[AsyncStateMachine(typeof(<RespawnPlayer>d__4))]
		private Task NTEMAVCHEXQ(IDisposable a, JCQFFOYMZSD b, StackTimer<string>.YOQUQHZDBKW c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	internal class UXLZBWJDXFL : UTQHQVVVWVQ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		[CompilerGenerated]
		private struct <RunAsync>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public UXLZBWJDXFL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public XMOUJWJJAGN operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			private long <roomId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			private long <subroomId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private TaskAwaiter<RoomSerializedData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x92A2E60", Offset = "0x92A1A60", VA = "0x1892A2E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0x92A3450", Offset = "0x92A2050", VA = "0x1892A3450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private readonly AutosaveType PGFLFOSXLQX;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x92AD650", Offset = "0x92AC250", VA = "0x1892AD650")]
		public UXLZBWJDXFL(Guid a, FQSENOYUOAD b, DGBVEOGIEQF c, AutosaveType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x92AD570", Offset = "0x92AC170", VA = "0x1892AD570", Slot = "6")]
		protected override string HLVQGNQJFVR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x92AD450", Offset = "0x92AC050", VA = "0x1892AD450", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__3))]
		protected override Task ELTEGZCMVCW(XMOUJWJJAGN a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	internal abstract class UTQHQVVVWVQ : KJJEFQETRAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000129")]
		public delegate Task PostOperationTaskBuilder(StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x200012A")]
		[CompilerGenerated]
		private sealed class VSFAPRYZFDS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			public StackTimer<string>.YOQUQHZDBKW CCZFJEVWHXM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			public UTQHQVVVWVQ VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public VSFAPRYZFDS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0x92AE600", Offset = "0x92AD200", VA = "0x1892AE600")]
			internal Task HKEWMSUPXGJ(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class VSKHMYSWOPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			public Exception GKPWMWJXCRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			public VSFAPRYZFDS JZUGHOQQQFE;

			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public VSKHMYSWOPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x92AE730", Offset = "0x92AD330", VA = "0x1892AE730")]
			internal object HJPBUYMXUYI()
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
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			public Func<CancellationToken, Task> createDriverTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public Func<CancellationToken, Task> originalTaskBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			private CancellationTokenSource <driverCancellationTokenSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			private Task <driverTask>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private Task <originalTask>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			private TaskAwaiter<Task> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0x929DE80", Offset = "0x929CA80", VA = "0x18929DE80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x929E920", Offset = "0x929D520", VA = "0x18929E920", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public UTQHQVVVWVQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public Func<UTQHQVVVWVQ, StackTimer<string>.YOQUQHZDBKW, XMOUJWJJAGN> operationContextBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			private VSFAPRYZFDS <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			private bool <success>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			private XMOUJWJJAGN <operationContext>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			private TaskAwaiter<BURCCBMBLWO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0x92A8580", Offset = "0x92A7180", VA = "0x1892A8580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x92A97C0", Offset = "0x92A83C0", VA = "0x1892A97C0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public UTQHQVVVWVQ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x92A75E0", Offset = "0x92A61E0", VA = "0x1892A75E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x92A7940", Offset = "0x92A6540", VA = "0x1892A7940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public readonly Guid NTOLQNYWQVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public readonly ByteString ZOHKIKLHVWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public readonly DGBVEOGIEQF DGBVEOGIEQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		protected readonly string RKPPTONODSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private readonly FQSENOYUOAD PXZRTZVOQOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private readonly bool DOUEDDNRVGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private readonly Queue<PostOperationTaskBuilder> FWXFRUMNNMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private readonly PYUICHTPVMY GMMQADFIUHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private readonly RequestOperationType ZTWQHOEIUIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private bool QQPYRDTBCBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public RoomOperationState QDTXRNSWHRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public RoomOperationState NSWFQMSRDKY;

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public FQSENOYUOAD PLDCLQIFQLL
		{
			[Cpp2IlInjected.Token(Token = "0x600053E")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public QGGDGVMYJMC WYXWMMZBGZF
		{
			[Cpp2IlInjected.Token(Token = "0x600053F")]
			[Cpp2IlInjected.Address(RVA = "0x92AC820", Offset = "0x92AB420", VA = "0x1892AC820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public VRFENSRWBLP XZFYBEXXXFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0x92ACA40", Offset = "0x92AB640", VA = "0x1892ACA40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public HOAWKWPUPAK YDVANLETWMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000541")]
			[Cpp2IlInjected.Address(RVA = "0x92ACA90", Offset = "0x92AB690", VA = "0x1892ACA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event ProgressUpdate VNQXMTIGGGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000542")]
			[Cpp2IlInjected.Address(RVA = "0x92AC870", Offset = "0x92AB470", VA = "0x1892AC870", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0x92ACB10", Offset = "0x92AB710", VA = "0x1892ACB10", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x92AD310", Offset = "0x92ABF10", VA = "0x1892AD310")]
		protected UTQHQVVVWVQ(Guid a, FQSENOYUOAD b, DGBVEOGIEQF c, string d, RequestOperationType e, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x92AC890", Offset = "0x92AB490", VA = "0x1892AC890", Slot = "6")]
		protected virtual string HLVQGNQJFVR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x92AC7C0", Offset = "0x92AB3C0", VA = "0x1892AC7C0")]
		public void AULFMGMELJT(PostOperationTaskBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x92ACEB0", Offset = "0x92ABAB0", VA = "0x1892ACEB0")]
		protected void TCWRVGKJJLC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x92ACB30", Offset = "0x92AB730", VA = "0x1892ACB30")]
		[AsyncStateMachine(typeof(<Run>d__30))]
		public Task Run(CancellationToken cancellationToken, StackTimer<string>.YOQUQHZDBKW stackTimer, [Optional] Func<UTQHQVVVWVQ, StackTimer<string>.YOQUQHZDBKW, XMOUJWJJAGN> operationContextBuilder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x92ACED0", Offset = "0x92ABAD0", VA = "0x1892ACED0")]
		[AsyncStateMachine(typeof(<DriverCombinedTask>d__31))]
		private static Task UGORLMOWJHH(Func<CancellationToken, Task> a, Func<CancellationToken, Task> b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x92AD1A0", Offset = "0x92ABDA0", VA = "0x1892AD1A0")]
		private void ZTNNVQAROZI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x92ACC80", Offset = "0x92AB880", VA = "0x1892ACC80")]
		private void SNXPLJQRPTX(XMOUJWJJAGN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract Task ELTEGZCMVCW(XMOUJWJJAGN a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x92AD000", Offset = "0x92ABC00", VA = "0x1892AD000")]
		[AsyncStateMachine(typeof(<RunPostOperationTasks>d__35))]
		private Task VALIRWVEDJX(StackTimer<string>.YOQUQHZDBKW a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x92AD120", Offset = "0x92ABD20", VA = "0x1892AD120")]
		public BURCCBMBLWO ZIBDQCVISCA(MessageKind a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x92AC950", Offset = "0x92AB550", VA = "0x1892AC950")]
		[CompilerGenerated]
		private Task ILCAHHCWHNI(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x92AC8D0", Offset = "0x92AB4D0", VA = "0x1892AC8D0")]
		[CompilerGenerated]
		private object IKWTKAIYYBZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	internal sealed class BCIOGYFFWRC : JPXEBEJVKFZ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000130")]
		[CompilerGenerated]
		private struct <RunWhilePlayerDespawnedAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			public BCIOGYFFWRC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			public XMOUJWJJAGN operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			private RoomEvent <roomEvent>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			private EZWPWVHNECU <loadLogic>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x92A9820", Offset = "0x92A8420", VA = "0x1892A9820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0x92A9F80", Offset = "0x92A8B80", VA = "0x1892A9F80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private readonly RoomLoadRequestPayload PHZDIOALVPN;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x9293030", Offset = "0x9291C30", VA = "0x189293030")]
		public BCIOGYFFWRC(Guid a, FQSENOYUOAD b, RoomLoadRequestPayload c, DGBVEOGIEQF d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x9292EE0", Offset = "0x9291AE0", VA = "0x189292EE0", Slot = "8")]
		[AsyncStateMachine(typeof(<RunWhilePlayerDespawnedAsync>d__2))]
		protected override Task KXCPZYMWXLN(XMOUJWJJAGN a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	internal class FYFHRUGSKNK : UTQHQVVVWVQ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		[CompilerGenerated]
		private struct <RunAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public FYFHRUGSKNK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public XMOUJWJJAGN operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004AA")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004AB")]
			private TaskAwaiter<RoomSerializedData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0x92A2020", Offset = "0x92A0C20", VA = "0x1892A2020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(RVA = "0x92A2E00", Offset = "0x92A1A00", VA = "0x1892A2E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private readonly string FEHYTNUFPLS;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x92963E0", Offset = "0x9294FE0", VA = "0x1892963E0")]
		public FYFHRUGSKNK(Guid a, FQSENOYUOAD b, DGBVEOGIEQF c, string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x92962D0", Offset = "0x9294ED0", VA = "0x1892962D0", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__2))]
		protected override Task ELTEGZCMVCW(XMOUJWJJAGN a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	internal class RoomSaveToRecNetOperation : JPXEBEJVKFZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000134")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000135")]
			private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004BA")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40004BB")]
				public AsyncTaskMethodBuilder<BURCCBMBLWO> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40004BC")]
				public PYHWMDJZEDC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40004BD")]
				public CancellationToken masterLockedCodeBlockCancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40004BE")]
				private TaskAwaiter<RoomSerializedData> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40004BF")]
				private TaskAwaiter<BURCCBMBLWO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600056D")]
				[Cpp2IlInjected.Address(RVA = "0x92AB6B0", Offset = "0x92AA2B0", VA = "0x1892AB6B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600056E")]
				[Cpp2IlInjected.Address(RVA = "0x92ABCB0", Offset = "0x92AA8B0", VA = "0x1892ABCB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B0")]
			public long BHLXCKVDBRT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			public long LTLXORHSXQW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			public long SURVSYODJKX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			public RoomSaveToRecNetOperation VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			public MIQJZUVSHJV XLWDIYOJVRH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			public RoomSaveOptions ERTCYGAKIFR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			public RoomUploadLogic ZOYTIQNRMGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			public RoomSaveAnalyticsInfo HGRELRFGDVX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40004B8")]
			public StackTimer<string>.YOQUQHZDBKW NYNNYWQNYWA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004B9")]
			public Func<(long superRoomId, long subRoomId, long loadedSubroomSaveId), object> VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(RVA = "0x929A530", Offset = "0x9299130", VA = "0x18929A530")]
			[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
			internal Task<BURCCBMBLWO> NYGYZGYBGAV(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(RVA = "0x929A480", Offset = "0x9299080", VA = "0x18929A480")]
			internal object NYBSCAEDWPM((long superRoomId, long subRoomId, long loadedSubroomSaveId) x)
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
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			public RoomSaveToRecNetOperation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			public XMOUJWJJAGN operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private PYHWMDJZEDC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004C7")]
			private RoomEvent <roomEvent>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004C8")]
			private EZWPWVHNECU <loadLogic>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40004C9")]
			private BURCCBMBLWO <saveReloadMessage>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40004CA")]
			private TaskAwaiter<BURCCBMBLWO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x92A9FE0", Offset = "0x92A8BE0", VA = "0x1892A9FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0x92AAEE0", Offset = "0x92A9AE0", VA = "0x1892AAEE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private static readonly Log QGEGZYQIOAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private readonly int GZDDIVWDQHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		[CanBeNull]
		private readonly RoomSaveRequestPayload YHKIKKIVLNQ;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x929D2B0", Offset = "0x929BEB0", VA = "0x18929D2B0")]
		public RoomSaveToRecNetOperation(Guid operationId, FQSENOYUOAD roomManager, int savingPlayerAccountId, RoomSaveRequestPayload roomSaveRequestPayload, DGBVEOGIEQF operationPauseToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x929CE00", Offset = "0x929BA00", VA = "0x18929CE00", Slot = "8")]
		[AsyncStateMachine(typeof(<RunWhilePlayerDespawnedAsync>d__5))]
		protected override Task KXCPZYMWXLN(XMOUJWJJAGN a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x929D110", Offset = "0x929BD10", VA = "0x18929D110")]
		private void UYMBYNDTRNZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x929CF40", Offset = "0x929BB40", VA = "0x18929CF40")]
		private void TZOFJJSRMGH(StackTimer<string>.YOQUQHZDBKW a, RoomEvent b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	internal class FTXJDDMRWST : UTQHQVVVWVQ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000138")]
		[CompilerGenerated]
		private struct <RunAsync>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			public FTXJDDMRWST <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004D2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D3")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004D4")]
			private RoomEvent <roomEvent>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004D5")]
			private long <superRoomId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40004D6")]
			private long <subRoomId>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004D7")]
			private SubRoomDataSaveWithUnityAssetsDTO <currentRoomSave>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			private FPZMXFTLOMZ<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			private TaskAwaiter<SubRoomDataSaveWithUnityAssetsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			private TaskAwaiter <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x92A34B0", Offset = "0x92A20B0", VA = "0x1892A34B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x92A48D0", Offset = "0x92A34D0", VA = "0x1892A48D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private readonly int GZDDIVWDQHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private readonly RoomSaveRequestPayload YHKIKKIVLNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private Func<RoomSerializedData, RoomSerializedData> CUKIMVDEZJF;

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x9296210", Offset = "0x9294E10", VA = "0x189296210")]
		public FTXJDDMRWST(Guid a, FQSENOYUOAD b, int c, RoomSaveRequestPayload d, Func<RoomSerializedData, RoomSerializedData> e, DGBVEOGIEQF f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x92960E0", Offset = "0x9294CE0", VA = "0x1892960E0", Slot = "7")]
		[AsyncStateMachine(typeof(<RunAsync>d__4))]
		protected override Task ELTEGZCMVCW(XMOUJWJJAGN a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	internal abstract class TWZVPEXJKLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public readonly UTQHQVVVWVQ CUQMBSKIYKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public readonly XMOUJWJJAGN XMOUJWJJAGN;

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public QGGDGVMYJMC WYXWMMZBGZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x929D380", Offset = "0x929BF80", VA = "0x18929D380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public HOAWKWPUPAK YDVANLETWMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x929D4E0", Offset = "0x929C0E0", VA = "0x18929D4E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x929D570", Offset = "0x929C170", VA = "0x18929D570")]
		protected TWZVPEXJKLG(XMOUJWJJAGN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x929D3D0", Offset = "0x929BFD0", VA = "0x18929D3D0")]
		protected void Log(string stepMessage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[Obfuscation(Exclude = true, ApplyToMembers = true)]
	public class DebugTools
	{
		[Cpp2IlInjected.Token(Token = "0x200013B")]
		public enum LoadLocation
		{
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			AfterLoadEmptyScene = -99,
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			AfterConnectToPhoton = -98,
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			AfterJoinedRoomInstance = -97,
			[Cpp2IlInjected.Token(Token = "0x40004E6")]
			Never = 0,
			[Cpp2IlInjected.Token(Token = "0x40004E7")]
			PostDeserializeAllObjects = 1,
			[Cpp2IlInjected.Token(Token = "0x40004E8")]
			PreInstantiateObjects = 2,
			[Cpp2IlInjected.Token(Token = "0x40004E9")]
			PostInstantiateObjects = 3
		}

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public static int SimulatedHangBeforeDisconnectMilliseconds;

		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public static LoadLocation SimulateDisconnectDuringLoad;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public static LoadLocation ThrowExceptionDuringLoad;

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x9293370", Offset = "0x9291F70", VA = "0x189293370")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		internal static void MaybeSimulateLoadFailure(LoadLocation loadLocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x9293530", Offset = "0x9292130", VA = "0x189293530")]
		[DebugConsoleCommand("roomLoadThrowExceptionAt", "Causes room-loading code to throw an exception the next time it runs, at the location specified. 0 = never, 1 = PostDeserializeAllObjects, 2 = PreInstantiateObjects, 3 = PostInstantiateObjects", new KeyCode[] { })]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void RoomLoadThrowExceptionAt(int locationIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x92934D0", Offset = "0x92920D0", VA = "0x1892934D0")]
		[DebugConsoleCommand("roomLoadDisconnectAt", "Causes room-loading code to do a hard disconnect the next time it runs, at the location specified. 0 = never, 1 = PostDeserializeAllObjects, 2 = PreInstantiateObjects, 3 = PostInstantiateObjects", new KeyCode[] { })]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void RoomLoadDisconnectAt(int locationIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x9293330", Offset = "0x9291F30", VA = "0x189293330")]
		[DebugConsoleCommand("forceNetworkDisconnect", "Force disconnect from photon (intended to test fallback code)", new KeyCode[] { })]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public static void ForceNetworkDisconnect()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	internal struct DeserializationHandlerLists
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public Dictionary<Guid, List<DeserializationPhaseHandler>> AuthorityHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public Dictionary<Guid, List<DeserializationPhaseHandler>> AllHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public Dictionary<Guid, List<DeserializationPhaseHandler>> NonAuthorityHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public List<Guid> IDList;

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x92935F0", Offset = "0x92921F0", VA = "0x1892935F0")]
		public static DeserializationHandlerLists Get(QGGDGVMYJMC callbacks, RoomOperationState operationState, APQTHAEMUEW deserializationData)
		{
			return default(DeserializationHandlerLists);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	internal struct LogRoomLoadMetrics
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90")]
		public static LogRoomLoadMetrics Create()
		{
			return default(LogRoomLoadMetrics);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	internal struct RoomLoadDetails
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public readonly RoomDetailsDTO roomDetails;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public readonly SubRoomDTO subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public readonly Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public readonly IReadOnlyCollection<BakedUnitySubAssetDTO> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public readonly IReadOnlyCollection<BakedUnitySubAssetDTO> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public readonly FilenameWithHash superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public readonly FilenameWithHash subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public readonly RoomLoadDTO roomLoad;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public bool XXDUJPRHUNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x929B190", Offset = "0x9299D90", VA = "0x18929B190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x929B220", Offset = "0x9299E20", VA = "0x18929B220")]
		public RoomLoadDetails(RoomDetailsDTO roomDetails, SubRoomDTO subRoom, Guid? unityAssetId, IReadOnlyList<BakedUnitySubAssetDTO> unitySubAssets, IReadOnlyCollection<BakedUnitySubAssetDTO> referencedUnityAssets, FilenameWithHash superRoomData, FilenameWithHash subRoomData, RoomLoadDTO roomLoad)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	internal struct RoomLoadLifetime : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private readonly XMOUJWJJAGN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private readonly Guid sliceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private bool success;

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x929B2E0", Offset = "0x9299EE0", VA = "0x18929B2E0")]
		public static RoomLoadLifetime MKAWWNAOLWM(XMOUJWJJAGN a)
		{
			return default(RoomLoadLifetime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x14836B0", Offset = "0x14822B0", VA = "0x1814836B0")]
		public void FBLAYNMXNWF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x929B2D0", Offset = "0x9299ED0", VA = "0x18929B2D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x929B5E0", Offset = "0x929A1E0", VA = "0x18929B5E0")]
		private RoomLoadLifetime(XMOUJWJJAGN operationContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x929B3B0", Offset = "0x9299FB0", VA = "0x18929B3B0")]
		private void TYFVICHFCJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x929B310", Offset = "0x9299F10", VA = "0x18929B310")]
		private Func<Guid, bool> MONQTPMWHPQ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	internal class EZWPWVHNECU : TWZVPEXJKLG, KJJEFQETRAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000142")]
		public delegate Task<RoomOperationState> RoomLoadFunction(APQTHAEMUEW data, HSQOIPLQDEG yielder, PYUICHTPVMY progressTracker, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000144")]
		[CompilerGenerated]
		private sealed class TCPIQNKCSSB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000145")]
			private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000513")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000514")]
				public AsyncTaskMethodBuilder<RoomLoadDetails> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000515")]
				public TCPIQNKCSSB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000516")]
				public CancellationToken innerCancellation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000517")]
				private RoomLoadDetails <innerData>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
				[Cpp2IlInjected.Token(Token = "0x4000518")]
				private TaskAwaiter<RoomOperationState> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
				[Cpp2IlInjected.Token(Token = "0x4000519")]
				private TaskAwaiter<RoomLoadDetails> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60005C1")]
				[Cpp2IlInjected.Address(RVA = "0x92C5A60", Offset = "0x92C4660", VA = "0x1892C5A60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C2")]
				[Cpp2IlInjected.Address(RVA = "0x92C6320", Offset = "0x92C4F20", VA = "0x1892C6320", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000146")]
			private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400051A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400051B")]
				public AsyncTaskMethodBuilder<APQTHAEMUEW> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400051C")]
				public TCPIQNKCSSB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400051D")]
				public CancellationToken innerCancellation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400051E")]
				private APQTHAEMUEW <innerPhaseArgs>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400051F")]
				private TaskAwaiter<RoomOperationState> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000520")]
				private TaskAwaiter<APQTHAEMUEW> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60005C3")]
				[Cpp2IlInjected.Address(RVA = "0x92C6390", Offset = "0x92C4F90", VA = "0x1892C6390", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C4")]
				[Cpp2IlInjected.Address(RVA = "0x92C69D0", Offset = "0x92C55D0", VA = "0x1892C69D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			public EZWPWVHNECU VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400050B")]
			public RoomLoadRequestPayload ZBJBQRAIHHQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public PYUICHTPVMY KVSWYMQSVQN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public StackTimer<string>.YOQUQHZDBKW NYNNYWQNYWA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public PYUICHTPVMY XMSHNOBICBQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			public RoomLoadDetails DPRTRIXCCFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public PYUICHTPVMY EMBNLUCZVAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public APQTHAEMUEW YUPXLEGTZAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			public RecNet.Core.OnDownloadProgressDelegate VOPWFDUNFXV;

			[Cpp2IlInjected.Token(Token = "0x60005BB")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TCPIQNKCSSB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x92B46A0", Offset = "0x92B32A0", VA = "0x1892B46A0")]
			[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
			internal Task<RoomLoadDetails> WFYRNHWSEXC(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x92B47F0", Offset = "0x92B33F0", VA = "0x1892B47F0")]
			[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
			internal Task<APQTHAEMUEW> WGJFHVKMXTU(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x92B4910", Offset = "0x92B3510", VA = "0x1892B4910")]
			internal void WGTTCIYHQQM(long a, long b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x92B4990", Offset = "0x92B3590", VA = "0x1892B4990")]
			internal Task WHJNUDFZSYN(CancellationToken a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x92B4950", Offset = "0x92B3550", VA = "0x1892B4950")]
			internal Task WHEGWWMCJNE(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000147")]
		[CompilerGenerated]
		private sealed class QMMIOVTYAKR
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000148")]
			private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000528")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000529")]
				public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400052A")]
				public QMMIOVTYAKR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400052B")]
				public CancellationToken mlToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400052C")]
				private LogRangeScope <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400052D")]
				private TaskAwaiter<RoomOperationState> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60005C7")]
				[Cpp2IlInjected.Address(RVA = "0x92C6A40", Offset = "0x92C5640", VA = "0x1892C6A40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C8")]
				[Cpp2IlInjected.Address(RVA = "0x92C7060", Offset = "0x92C5C60", VA = "0x1892C7060", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			public EZWPWVHNECU VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			public APQTHAEMUEW DPRTRIXCCFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			public PYUICHTPVMY RQUBDEFTBAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000524")]
			public StackTimer<string>.YOQUQHZDBKW NYNNYWQNYWA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000525")]
			public RoomLoadFunction XUNDPRCGLMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public HSQOIPLQDEG BLNJHNCARQG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			public RoomOperationState BLCSKLANYMA;

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QMMIOVTYAKR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x92B4580", Offset = "0x92B3180", VA = "0x1892B4580")]
			[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
			internal Task<RoomOperationState> CLZGMDXLFKH(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000149")]
		[CompilerGenerated]
		private sealed class PLZNLAKFXUV
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200014A")]
			private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000530")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000531")]
				public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000532")]
				public PLZNLAKFXUV <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000533")]
				public APQTHAEMUEW data;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000534")]
				public PYUICHTPVMY progressTracker;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000535")]
				public StackTimer<string>.YOQUQHZDBKW stackTimer;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000536")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000537")]
				private TaskAwaiter<RoomOperationState> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000538")]
				private TaskAwaiter <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000539")]
				private TaskAwaiter<RRSceneLoadOperation> <>u__3;

				[Cpp2IlInjected.Token(Token = "0x60005CB")]
				[Cpp2IlInjected.Address(RVA = "0x92C70D0", Offset = "0x92C5CD0", VA = "0x1892C70D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005CC")]
				[Cpp2IlInjected.Address(RVA = "0x92C7BF0", Offset = "0x92C67F0", VA = "0x1892C7BF0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public EZWPWVHNECU VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			public LYWEJWAJEVS KUQDEACFTJJ;

			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PLZNLAKFXUV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x92B43D0", Offset = "0x92B2FD0", VA = "0x1892B43D0")]
			[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
			internal Task<RoomOperationState> GNLTHZOLOSA(APQTHAEMUEW a, HSQOIPLQDEG b, PYUICHTPVMY c, StackTimer<string>.YOQUQHZDBKW d, CancellationToken e)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014B")]
		[CompilerGenerated]
		private struct <CreateCV1Mappings>d__35 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400053C")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400053D")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x92B49D0", Offset = "0x92B35D0", VA = "0x1892B49D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x92B4C00", Offset = "0x92B3800", VA = "0x1892B4C00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014C")]
		[CompilerGenerated]
		private struct <DeserializeAllObjects>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400053F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			public PYUICHTPVMY progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			public HSQOIPLQDEG timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			private StackTimer<string>.YOQUQHZDBKW <deserializeAllObjectsTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000548")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000549")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x92B5320", Offset = "0x92B3F20", VA = "0x1892B5320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x92B6460", Offset = "0x92B5060", VA = "0x1892B6460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014D")]
		[CompilerGenerated]
		private struct <DeserializeAllObjectsR2>d__49 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054B")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			public PYUICHTPVMY progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			private StackTimer<string>.YOQUQHZDBKW <deserializeAllObjectsTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x92B4C60", Offset = "0x92B3860", VA = "0x1892B4C60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x92B52B0", Offset = "0x92B3EB0", VA = "0x1892B52B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014E")]
		[CompilerGenerated]
		private struct <DestroyOldObjects>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			public bool useCompletionMark;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x92B64D0", Offset = "0x92B50D0", VA = "0x1892B64D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x92B67C0", Offset = "0x92B53C0", VA = "0x1892B67C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014F")]
		[CompilerGenerated]
		private struct <DestroyR1Objects>d__47 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x92B6820", Offset = "0x92B5420", VA = "0x1892B6820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0x92B6C20", Offset = "0x92B5820", VA = "0x1892B6C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000150")]
		[CompilerGenerated]
		private struct <GetSyncedRoomLoadPayload>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			public AsyncTaskMethodBuilder<BURCCBMBLWO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			private StackTimer<string>.YOQUQHZDBKW <syncTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			private TaskAwaiter<BURCCBMBLWO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x92B8850", Offset = "0x92B7450", VA = "0x1892B8850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x92B8C80", Offset = "0x92B7880", VA = "0x1892B8C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		[CompilerGenerated]
		private struct <LegacyLoadRoomData>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400056B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400056C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			public PYUICHTPVMY progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			private StackTimer<string>.YOQUQHZDBKW <legacyLoadRoomDataTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x92B8CF0", Offset = "0x92B78F0", VA = "0x1892B8CF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x92B9530", Offset = "0x92B8130", VA = "0x1892B9530", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000152")]
		[CompilerGenerated]
		private struct <LoadRoomLocal>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000576")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000578")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000579")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400057A")]
			public CancellationToken externalCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			private TCPIQNKCSSB <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			private TaskAwaiter<RoomLoadDetails> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			private TaskAwaiter<APQTHAEMUEW> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0x92B9AB0", Offset = "0x92B86B0", VA = "0x1892B9AB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x92BA710", Offset = "0x92B9310", VA = "0x1892BA710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000153")]
		[CompilerGenerated]
		private struct <LoadRoomLocalTimed>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			private StackTimer<string>.YOQUQHZDBKW <loadRoomLocalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x92B9590", Offset = "0x92B8190", VA = "0x1892B9590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0x92B9A50", Offset = "0x92B8650", VA = "0x1892B9A50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[CompilerGenerated]
		private struct <MasterLockedPhaseChangeBlock>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400058A")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			public PYUICHTPVMY progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400058C")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400058D")]
			public RoomLoadFunction masterLockedCode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400058E")]
			public HSQOIPLQDEG timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400058F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000590")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0x92BA770", Offset = "0x92B9370", VA = "0x1892BA770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x92BAC80", Offset = "0x92B9880", VA = "0x1892BAC80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000155")]
		[CompilerGenerated]
		private struct <MoveThroughRemainingPhases>d__29 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public PYUICHTPVMY progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			private RoomOperationState <legacyEndPhase>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			private IEnumerator<RoomOperationState> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400059B")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0x92BACF0", Offset = "0x92B98F0", VA = "0x1892BACF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x92BB250", Offset = "0x92B9E50", VA = "0x1892BB250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000156")]
		[CompilerGenerated]
		private struct <MoveToPhase>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			public RoomOperationState operationState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			public PYUICHTPVMY progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005A1")]
			public APQTHAEMUEW deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005A3")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005A4")]
			public bool skipHandlers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005A5")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x92BB2B0", Offset = "0x92B9EB0", VA = "0x1892BB2B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x92BB510", Offset = "0x92BA110", VA = "0x1892BB510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000157")]
		[CompilerGenerated]
		private struct <RoomV1DestroyAndRebuildObjects>d__24 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005AB")]
			public PYUICHTPVMY progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005AC")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005AD")]
			private StackTimer<string>.YOQUQHZDBKW <destroyAndRebuildObjectsTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005AE")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005AF")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(RVA = "0x92BB580", Offset = "0x92BA180", VA = "0x1892BB580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0x92BC580", Offset = "0x92BB180", VA = "0x1892BC580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000158")]
		[CompilerGenerated]
		private struct <RoomV1LoadLogic>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005B2")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B3")]
			public APQTHAEMUEW phaseArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005B4")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			public PYUICHTPVMY postDownloadProgress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			private TaskAwaiter<RoomOperationState> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005B9")]
			private HSQOIPLQDEG <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x92BC5F0", Offset = "0x92BB1F0", VA = "0x1892BC5F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x92BD420", Offset = "0x92BC020", VA = "0x1892BD420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		[CompilerGenerated]
		private struct <RoomV2LoadLogic>d__46 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005BC")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005BD")]
			public APQTHAEMUEW phaseArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005BE")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005BF")]
			public PYUICHTPVMY postDownloadProgress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005C0")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005C1")]
			private PLZNLAKFXUV <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005C2")]
			private HSQOIPLQDEG <timedYielder>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005C3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005C4")]
			private TaskAwaiter<RoomOperationState> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x92BD480", Offset = "0x92BC080", VA = "0x1892BD480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x92BE290", Offset = "0x92BCE90", VA = "0x1892BE290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200015A")]
		[CompilerGenerated]
		private struct <SyncLoadRoom>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005C8")]
			public RoomLoadRequestPayload request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			private RoomLoadLifetime <lifetime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			private TaskAwaiter<BURCCBMBLWO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x92C4070", Offset = "0x92C2C70", VA = "0x1892C4070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(RVA = "0x92C47B0", Offset = "0x92C33B0", VA = "0x1892C47B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		[CompilerGenerated]
		private struct <TriggerBigDataNetworkManager>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D0")]
			public EZWPWVHNECU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D1")]
			public StackTimer<string>.YOQUQHZDBKW timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005D2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x92C4810", Offset = "0x92C3410", VA = "0x1892C4810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x92C4FF0", Offset = "0x92C3BF0", VA = "0x1892C4FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private readonly Token JIQSAPGRRTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private readonly Token BWMENSQMLYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private readonly VNEBTMGFLNZ KGZFCTRYIGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private readonly OPGCUUOBYPN XYOGUEPFELK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private readonly MoveToPhaseTask BVWKMXZSBPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private ProfilerCounterValue<int> EGEKKQEMIEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private readonly BOIVAAXBRST SMTCSDWTPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private readonly LYPKNRFXAJP BXVMSXNGMKN;

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		private FQSENOYUOAD PLDCLQIFQLL
		{
			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0x9295370", Offset = "0x9293F70", VA = "0x189295370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event ProgressUpdate VNQXMTIGGGO
		{
			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0x9294960", Offset = "0x9293560", VA = "0x189294960", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x9295420", Offset = "0x9294020", VA = "0x189295420", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x9295D50", Offset = "0x9294950", VA = "0x189295D50")]
		public EZWPWVHNECU(XMOUJWJJAGN a, LYPKNRFXAJP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x9294B00", Offset = "0x9293700", VA = "0x189294B00")]
		[AsyncStateMachine(typeof(<SyncLoadRoom>d__17))]
		public Task HSUWWWXXQLL(RoomLoadRequestPayload a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x9295440", Offset = "0x9294040", VA = "0x189295440")]
		[AsyncStateMachine(typeof(<GetSyncedRoomLoadPayload>d__18))]
		private Task<BURCCBMBLWO> SVTXXFECSTO(RoomLoadRequestPayload a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x9294CC0", Offset = "0x92938C0", VA = "0x189294CC0")]
		[AsyncStateMachine(typeof(<LoadRoomLocalTimed>d__19))]
		private Task JXLMQGQBUNO(RoomLoadRequestPayload a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x9294F50", Offset = "0x9293B50", VA = "0x189294F50")]
		[AsyncStateMachine(typeof(<LoadRoomLocal>d__20))]
		private Task LoadRoomLocal(RoomLoadRequestPayload request, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken externalCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x9294810", Offset = "0x9293410", VA = "0x189294810")]
		[AsyncStateMachine(typeof(<RoomV1LoadLogic>d__21))]
		private Task FOHXZXIHAHN(APQTHAEMUEW a, PYUICHTPVMY b, StackTimer<string>.YOQUQHZDBKW c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x9295220", Offset = "0x9293E20", VA = "0x189295220")]
		[AsyncStateMachine(typeof(<TriggerBigDataNetworkManager>d__22))]
		private Task NHPGJTDIKRY(StackTimer<string>.YOQUQHZDBKW a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x9294E00", Offset = "0x9293A00", VA = "0x189294E00")]
		[AsyncStateMachine(typeof(<LegacyLoadRoomData>d__23))]
		private Task LegacyLoadRoomData(APQTHAEMUEW data, PYUICHTPVMY progressTracker, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x9295A50", Offset = "0x9294650", VA = "0x189295A50")]
		[AsyncStateMachine(typeof(<RoomV1DestroyAndRebuildObjects>d__24))]
		private Task<RoomOperationState> VYZFJZAXTAZ(APQTHAEMUEW a, HSQOIPLQDEG b, PYUICHTPVMY c, StackTimer<string>.YOQUQHZDBKW d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x92944C0", Offset = "0x92930C0", VA = "0x1892944C0")]
		[AsyncStateMachine(typeof(<DeserializeAllObjects>d__25))]
		private Task<RoomOperationState> DeserializeAllObjects(APQTHAEMUEW data, HSQOIPLQDEG timedYielder, PYUICHTPVMY progressTracker, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x9294980", Offset = "0x9293580", VA = "0x189294980")]
		[AsyncStateMachine(typeof(<MoveToPhase>d__26))]
		private Task<RoomOperationState> HCFWWTUFJSA(RoomOperationState a, APQTHAEMUEW b, PYUICHTPVMY c, StackTimer<string>.YOQUQHZDBKW d, CancellationToken e, bool f = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x9294030", Offset = "0x9292C30", VA = "0x189294030")]
		private bool BGAWMNIAQXR(APQTHAEMUEW a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x9295090", Offset = "0x9293C90", VA = "0x189295090")]
		[AsyncStateMachine(typeof(<MasterLockedPhaseChangeBlock>d__28))]
		protected Task<RoomOperationState> MasterLockedPhaseChangeBlock(APQTHAEMUEW data, HSQOIPLQDEG timedYielder, PYUICHTPVMY progressTracker, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken, RoomLoadFunction masterLockedCode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x9294120", Offset = "0x9292D20", VA = "0x189294120")]
		[AsyncStateMachine(typeof(<MoveThroughRemainingPhases>d__29))]
		private Task CYPASVIXBCX(APQTHAEMUEW a, PYUICHTPVMY b, StackTimer<string>.YOQUQHZDBKW c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x9295D00", Offset = "0x9294900", VA = "0x189295D00")]
		private void XTNRUOEHJQO(RoomOperationState a, PYUICHTPVMY b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x9295330", Offset = "0x9293F30", VA = "0x189295330")]
		private void NLVQNZPHJUT(RoomOperationState a, [Out] RoomOperationState b, [Out] RoomOperationState c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x92953A0", Offset = "0x9293FA0", VA = "0x1892953A0")]
		private Task<RoomLoadDetails> PWYANRBDHNY(RoomLoadRequestPayload a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x92956C0", Offset = "0x92942C0", VA = "0x1892956C0")]
		private Task<APQTHAEMUEW> TOEKNOCQGXW(RoomLoadDetails a, RecNet.Core.OnDownloadProgressDelegate b, StackTimer<string>.YOQUQHZDBKW c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x92946C0", Offset = "0x92932C0", VA = "0x1892946C0")]
		[AsyncStateMachine(typeof(<DestroyOldObjects>d__34))]
		private Task DestroyOldObjects(APQTHAEMUEW data, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken, bool useCompletionMark = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x92943D0", Offset = "0x9292FD0", VA = "0x1892943D0")]
		[AsyncStateMachine(typeof(<CreateCV1Mappings>d__35))]
		private Task DDYZZRWYYGU(APQTHAEMUEW a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x9294690", Offset = "0x9293290", VA = "0x189294690")]
		private Task DeserializeSettings(APQTHAEMUEW data, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x9294CA0", Offset = "0x92938A0", VA = "0x189294CA0")]
		private Task InstantiateObjects(APQTHAEMUEW data, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x9295400", Offset = "0x9294000", VA = "0x189295400")]
		private Task PreDeserializeObjects(APQTHAEMUEW data, HSQOIPLQDEG timedYielder, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x9294670", Offset = "0x9293270", VA = "0x189294670")]
		private Task DeserializeObjects(APQTHAEMUEW data, HSQOIPLQDEG timedYielder, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x9294640", Offset = "0x9293240", VA = "0x189294640")]
		private static Task DeserializeConnectables(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x92953E0", Offset = "0x9293FE0", VA = "0x1892953E0")]
		private Task PostDeserializeObjects(APQTHAEMUEW data, HSQOIPLQDEG timedYielder, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x9294650", Offset = "0x9293250", VA = "0x189294650")]
		private Task DeserializeObjectsComplete(APQTHAEMUEW data, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x9294C50", Offset = "0x9293850", VA = "0x189294C50")]
		private void ICBNRROQVKX(RoomLoadRequestPayload a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x9295700", Offset = "0x9294300", VA = "0x189295700")]
		public void UHADBULDMMR(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x92957B0", Offset = "0x92943B0", VA = "0x1892957B0")]
		private static void VEBLIXSUDJO(RoomDetailsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x9295BB0", Offset = "0x92947B0", VA = "0x189295BB0")]
		[AsyncStateMachine(typeof(<RoomV2LoadLogic>d__46))]
		private Task XAKCMUCGFSA(APQTHAEMUEW a, PYUICHTPVMY b, StackTimer<string>.YOQUQHZDBKW c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x9295910", Offset = "0x9294510", VA = "0x189295910")]
		[AsyncStateMachine(typeof(<DestroyR1Objects>d__47))]
		private Task VRMSHTRIEGM(APQTHAEMUEW a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x92955A0", Offset = "0x92941A0", VA = "0x1892955A0")]
		private static SerializedDataWrapper TEYANTGKIWZ(APQTHAEMUEW a)
		{
			return default(SerializedDataWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x9294270", Offset = "0x9292E70", VA = "0x189294270")]
		[AsyncStateMachine(typeof(<DeserializeAllObjectsR2>d__49))]
		private Task<RoomOperationState> CYWDYFMYEGV(APQTHAEMUEW a, HSQOIPLQDEG b, PYUICHTPVMY c, StackTimer<string>.YOQUQHZDBKW d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		private void YIQEGDGQTJI(RoomOperationState a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	internal struct CreateCV1MappingsTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private FQSENOYUOAD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private APQTHAEMUEW data;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		private QGGDGVMYJMC WYXWMMZBGZF
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x92B0EF0", Offset = "0x92AFAF0", VA = "0x1892B0EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x92B0F40", Offset = "0x92AFB40", VA = "0x1892B0F40")]
		public static Task Run(FQSENOYUOAD roomManager, APQTHAEMUEW data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x92B1020", Offset = "0x92AFC20", VA = "0x1892B1020")]
		private void Run()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	internal struct DeserializeConnectablesTask
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x92B1240", Offset = "0x92AFE40", VA = "0x1892B1240")]
		public static Task Run(CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	internal struct DeserializeObjectsCompleteTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200015F")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D8")]
			public XMOUJWJJAGN operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D9")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005DA")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005DB")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005DC")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005DD")]
			private StackTimer<string>.YOQUQHZDBKW <outboundTrafficTimer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x92BEFC0", Offset = "0x92BDBC0", VA = "0x1892BEFC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x92C0430", Offset = "0x92BF030", VA = "0x1892C0430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x92B1320", Offset = "0x92AFF20", VA = "0x1892B1320")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(XMOUJWJJAGN operationContext, APQTHAEMUEW data, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	internal struct DeserializeObjectsTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000162")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005E1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005E2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005E3")]
			public XMOUJWJJAGN operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005E4")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005E5")]
			public HSQOIPLQDEG timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005E6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005E7")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005E8")]
			private FQSENOYUOAD <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005E9")]
			private QGGDGVMYJMC <callbacks>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005EA")]
			private RoomOperationState <operationState>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x40005EB")]
			private bool <isMaster>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005EC")]
			private LogRangeScope <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40005ED")]
			private IDisposable <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40005EE")]
			private List<(PersistenceView, ABLNPBVPOUZ)>.Enumerator <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40005EF")]
			private PersistenceView <view>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40005F0")]
			private ABLNPBVPOUZ <viewData>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40005F1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x92BE2F0", Offset = "0x92BCEF0", VA = "0x1892BE2F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x92C0310", Offset = "0x92BEF10", VA = "0x1892C0310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x92B1650", Offset = "0x92B0250", VA = "0x1892B1650")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(XMOUJWJJAGN operationContext, APQTHAEMUEW data, HSQOIPLQDEG timedYielder, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x92B1460", Offset = "0x92B0060", VA = "0x1892B1460")]
		private static void OITWTYWQDDX(PersistenceView a, ABLNPBVPOUZ b, APQTHAEMUEW c, RoomOperationState d, bool e)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	internal struct DeserializeSettingsTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005F2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005F3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F4")]
			public FQSENOYUOAD roomManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			private LogRangeScope <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005F8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x92BF4F0", Offset = "0x92BE0F0", VA = "0x1892BF4F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x92C0370", Offset = "0x92BEF70", VA = "0x1892C0370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x92B17A0", Offset = "0x92B03A0", VA = "0x1892B17A0")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(FQSENOYUOAD roomManager, APQTHAEMUEW data, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	internal struct DestroyOldObjectsTask
	{
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		[CompilerGenerated]
		private sealed class HCFOWLTMZUC
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000168")]
			private struct <<Run>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000601")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000602")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000603")]
				public StackTimer<string>.YOQUQHZDBKW timer;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000604")]
				public CancellationToken token;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000605")]
				public HCFOWLTMZUC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000606")]
				private StackTimer<string>.YOQUQHZDBKW <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000607")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600060C")]
				[Cpp2IlInjected.Address(RVA = "0x92C7C60", Offset = "0x92C6860", VA = "0x1892C7C60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600060D")]
				[Cpp2IlInjected.Address(RVA = "0x92C7FF0", Offset = "0x92C6BF0", VA = "0x1892C7FF0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000600")]
			public Task KEQPRBVOPTH;

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HCFOWLTMZUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x92B3A80", Offset = "0x92B2680", VA = "0x1892B3A80")]
			[AsyncStateMachine(typeof(<<Run>b__1>d))]
			internal Task HKEWMSUPXGJ(StackTimer<string>.YOQUQHZDBKW a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000169")]
		[CompilerGenerated]
		private sealed class CITSQHBYTVL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000608")]
			public DEPRECATED_RoomPersistenceVersion version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000609")]
			public bool MKEMOEKTBFW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400060A")]
			public List<PersistenceView> CBOADHWQFXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400060B")]
			public List<GameObject> DJEKQBLKOUI;

			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CITSQHBYTVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x92B0AA0", Offset = "0x92AF6A0", VA = "0x1892B0AA0")]
			internal object QVUSZAALTAQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x92B0B70", Offset = "0x92AF770", VA = "0x1892B0B70")]
			internal object QVZZWGUJCLZ()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016A")]
		[CompilerGenerated]
		private struct <Run>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400060C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400060D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400060E")]
			public DestroyOldObjectsTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400060F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000610")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000611")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000612")]
			private object <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000613")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000614")]
			private LogRangeScope <_>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000615")]
			private TaskAwaiter<BURCCBMBLWO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000616")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x92C0490", Offset = "0x92BF090", VA = "0x1892C0490", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x92C11E0", Offset = "0x92BFDE0", VA = "0x1892C11E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		[CompilerGenerated]
		private struct <Run>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			public FQSENOYUOAD roomManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061A")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400061B")]
			public XMOUJWJJAGN operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			public bool useCompletionMark;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400061E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400061F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x92C3260", Offset = "0x92C1E60", VA = "0x1892C3260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x92C3470", Offset = "0x92C2070", VA = "0x1892C3470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private FQSENOYUOAD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private APQTHAEMUEW data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private XMOUJWJJAGN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private bool useCompletionMark;

		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private static readonly ByteString destroyObjectsGuid;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		private QGGDGVMYJMC WYXWMMZBGZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x92B18C0", Offset = "0x92B04C0", VA = "0x1892B18C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		private HOAWKWPUPAK YDVANLETWMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x92B20C0", Offset = "0x92B0CC0", VA = "0x1892B20C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x92B2160", Offset = "0x92B0D60", VA = "0x1892B2160")]
		[AsyncStateMachine(typeof(<Run>d__5))]
		public static Task Run(FQSENOYUOAD roomManager, APQTHAEMUEW data, XMOUJWJJAGN operationContext, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken, bool useCompletionMark)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x92B22B0", Offset = "0x92B0EB0", VA = "0x1892B22B0")]
		[AsyncStateMachine(typeof(<Run>d__10))]
		private Task Run(StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x92B1910", Offset = "0x92B0510", VA = "0x1892B1910")]
		private void DestroyActivePersistenceViews([NotNull] PersistedRoomData downloadedRoomData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x92B23E0", Offset = "0x92B0FE0", VA = "0x1892B23E0")]
		private bool XVHEBACJVOZ(DEPRECATED_RoomPersistenceVersion a, PersistedRoomData b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	internal struct FetchDeserializationDataTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		[CompilerGenerated]
		private struct <DownloadAssetBundles>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400062F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000630")]
			public AsyncTaskMethodBuilder<Result<BZZBICGVUJE, UTITDXZLKVK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000631")]
			public StackTimer<string>.YOQUQHZDBKW downloadTimerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000632")]
			public FetchDeserializationDataTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000633")]
			public Guid? unityAssetId;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000634")]
			public IReadOnlyCollection<BakedUnitySubAssetDTO> unitySubAssets;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000635")]
			public IReadOnlyCollection<BakedUnitySubAssetDTO> referencedUnityAssets;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000636")]
			public long? roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000637")]
			public long? subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x4000638")]
			public RecNet.Core.OnDownloadProgressDelegate downloadProgressCallback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x400063A")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400063B")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400063C")]
			private TaskAwaiter<Result<BZZBICGVUJE, UTITDXZLKVK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x92B6C80", Offset = "0x92B5880", VA = "0x1892B6C80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x92B72E0", Offset = "0x92B5EE0", VA = "0x1892B72E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		[CompilerGenerated]
		private struct <Run>d__16 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400063E")]
			public AsyncTaskMethodBuilder<APQTHAEMUEW> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400063F")]
			public FetchDeserializationDataTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			public RecNet.Core.OnDownloadProgressDelegate downloadProgressCallback;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000643")]
			private StackTimer<string>.YOQUQHZDBKW <downloadTimerScope>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000644")]
			private TaskAwaiter<IReadOnlyCollection<BakedUnitySubAssetDTO>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			private TaskAwaiter<(Result<BZZBICGVUJE, UTITDXZLKVK>, Result<ParseResult<PersistedRoomData>, UTITDXZLKVK>, Result<ParseResult<SuperRoomData>, UTITDXZLKVK>, Result<ParseResult<IEnumerable<RoomAssetData>>, UTITDXZLKVK>, Result<ParseResult<VMMHASWVFTD>, UTITDXZLKVK>)> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x92C1700", Offset = "0x92C0300", VA = "0x1892C1700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x92C24D0", Offset = "0x92C10D0", VA = "0x1892C24D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private VersionedDataGetter<FilenameWithHash, SuperRoomData> superRoomGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private VersionedDataGetter<FilenameWithHash, PersistedRoomData> subRoomGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private VersionedDataGetter<RoomLoadDTO, IEnumerable<RoomAssetData>> roomAssetGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private VersionedDataGetter<long, VMMHASWVFTD> playerSaveGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private QZLEUZSCQDU subRoomAssetBundleProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private RoomDetailsDTO roomDetails;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private SubRoomDTO subRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private IReadOnlyCollection<BakedUnitySubAssetDTO> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private Task<IReadOnlyCollection<BakedUnitySubAssetDTO>> referencedUnityAssetsTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private FilenameWithHash superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private FilenameWithHash subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private FilenameWithHash? roomAssetData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private RoomLoadDTO roomLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private StackTimer<string>.YOQUQHZDBKW timer;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x92B2890", Offset = "0x92B1490", VA = "0x1892B2890")]
		public static Task<APQTHAEMUEW> ZDQPLOAPRLZ(FQSENOYUOAD a, [In] RoomLoadDetails data, RecNet.Core.OnDownloadProgressDelegate b, StackTimer<string>.YOQUQHZDBKW c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x92B26E0", Offset = "0x92B12E0", VA = "0x1892B26E0")]
		[AsyncStateMachine(typeof(<Run>d__16))]
		private Task<APQTHAEMUEW> Run(RecNet.Core.OnDownloadProgressDelegate downloadProgressCallback, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x92B24B0", Offset = "0x92B10B0", VA = "0x1892B24B0")]
		[AsyncStateMachine(typeof(<DownloadAssetBundles>d__17))]
		private Task<Result<BZZBICGVUJE, UTITDXZLKVK>> GTHQPKOUFAQ(Guid? a, IReadOnlyCollection<BakedUnitySubAssetDTO> b, IReadOnlyCollection<BakedUnitySubAssetDTO> c, long? d, long? e, RecNet.Core.OnDownloadProgressDelegate f, StackTimer<string>.YOQUQHZDBKW g, CancellationToken h)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	internal struct FetchRoomLoadDetailsTask
	{
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		[CompilerGenerated]
		private sealed class CMIBJUZGHFB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000171")]
			private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400065F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000660")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000661")]
				public CMIBJUZGHFB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000662")]
				private StackTimer<string>.YOQUQHZDBKW <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000663")]
				private TaskAwaiter<RemoteRunDTO> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000664")]
				private TaskAwaiter<SubRoomDataSaveWithUnityAssetsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000625")]
				[Cpp2IlInjected.Address(RVA = "0x92C5050", Offset = "0x92C3C50", VA = "0x1892C5050", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000626")]
				[Cpp2IlInjected.Address(RVA = "0x92C5A00", Offset = "0x92C4600", VA = "0x1892C5A00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			public long QNXITDVSSUH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			public string XYIGMJKUHXW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000652")]
			public PVUBCAYTCUW PANXNKOMLVR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000653")]
			public StackTimer<string>.YOQUQHZDBKW NYNNYWQNYWA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			public QGGDGVMYJMC CTKZLRUOMOT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			public CancellationToken AOXLOEXRQNR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000656")]
			public Guid? GEXCKAULUYL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000657")]
			public FilenameWithHash OBYGYECBUJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000658")]
			public FilenameWithHash PFFEPDWJYJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000659")]
			public long DOIRKITBFZE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400065A")]
			public long CUBMJCRHEFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400065B")]
			public IReadOnlyList<BakedUnitySubAssetDTO> RHWYPZPCREF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400065C")]
			public IReadOnlyList<BakedUnitySubAssetDTO> BEKJSPZPKCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400065D")]
			public Guid QWOZKZHCWPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400065E")]
			public RoomDetailsDTO TTQSVMUXVRS;

			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CMIBJUZGHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x1100FD0", Offset = "0x10FFBD0", VA = "0x181100FD0")]
			internal bool FQNYBBGMBQA(SubRoomDTO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x92B0E20", Offset = "0x92AFA20", VA = "0x1892B0E20")]
			[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
			internal Task KUJNNCGRBHH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x92B0C20", Offset = "0x92AF820", VA = "0x1892B0C20")]
			internal Task<RoomLoadDTO> CMUGCGGLPWF()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000172")]
		[CompilerGenerated]
		private struct <FetchRoomLoadDetails>d__12 : IAsyncStateMachine
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
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400066A")]
			private TaskAwaiter<RoomLoadDetails> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0x92B7350", Offset = "0x92B5F50", VA = "0x1892B7350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x92B77D0", Offset = "0x92B63D0", VA = "0x1892B77D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000173")]
		[CompilerGenerated]
		private struct <FetchRoomLoadDetails>d__13 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400066B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400066C")]
			public AsyncTaskMethodBuilder<RoomLoadDetails> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400066D")]
			public long subroomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400066E")]
			public string studioSessionId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400066F")]
			public PVUBCAYTCUW roomLoadDataProviderOverride;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000670")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000671")]
			public QGGDGVMYJMC callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000672")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000673")]
			public long subRoomDataSaveId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000674")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000675")]
			public Guid roomAssetsSnapshotId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000676")]
			public FilenameWithHash superRoomBlobName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000677")]
			private CMIBJUZGHFB <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000678")]
			private SubRoomDTO <subroom>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			private Task<RoomLoadDTO> <getRoomLoadDTOTask>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400067A")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400067B")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400067C")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400067D")]
			private TaskAwaiter<RoomLoadDTO> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x92B7840", Offset = "0x92B6440", VA = "0x1892B7840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x92B87E0", Offset = "0x92B73E0", VA = "0x1892B87E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000174")]
		[CompilerGenerated]
		private struct <Run>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400067E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400067F")]
			public AsyncTaskMethodBuilder<RoomLoadDetails> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000680")]
			public FetchRoomLoadDetailsTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000681")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000682")]
			private StackTimer<string>.YOQUQHZDBKW <subTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000683")]
			private TaskAwaiter<RoomLoadDetails> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x92C1240", Offset = "0x92BFE40", VA = "0x1892C1240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x92C1690", Offset = "0x92C0290", VA = "0x1892C1690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private QGGDGVMYJMC callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private VNEBTMGFLNZ debugRoomLoadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private PVUBCAYTCUW roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private StackTimer<string>.YOQUQHZDBKW timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private FilenameWithHash superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		private Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x92B31F0", Offset = "0x92B1DF0", VA = "0x1892B31F0")]
		public static Task<RoomLoadDetails> ZDQPLOAPRLZ(FQSENOYUOAD a, RoomLoadRequestPayload b, StackTimer<string>.YOQUQHZDBKW c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x92B30A0", Offset = "0x92B1CA0", VA = "0x1892B30A0")]
		[AsyncStateMachine(typeof(<Run>d__11))]
		private Task<RoomLoadDetails> Run(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x92B2F30", Offset = "0x92B1B30", VA = "0x1892B2F30")]
		[AsyncStateMachine(typeof(<FetchRoomLoadDetails>d__12))]
		private Task<RoomLoadDetails> PWYANRBDHNY(StackTimer<string>.YOQUQHZDBKW a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x92B2D60", Offset = "0x92B1960", VA = "0x1892B2D60")]
		[AsyncStateMachine(typeof(<FetchRoomLoadDetails>d__13))]
		private static Task<RoomLoadDetails> PWYANRBDHNY(QGGDGVMYJMC a, PVUBCAYTCUW b, long c, long d, long e, string f, FilenameWithHash g, Guid h, CancellationToken i, StackTimer<string>.YOQUQHZDBKW j)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x92B2D30", Offset = "0x92B1930", VA = "0x1892B2D30")]
		private void ECCCVDTDKDC(RoomDetailsDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	internal struct FlushCommandsSlowlyTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000177")]
		[CompilerGenerated]
		private struct <Run>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400068C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400068D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400068E")]
			public FlushCommandsSlowlyTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400068F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000690")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000691")]
			private float <nextResendTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000692")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x92C3530", Offset = "0x92C2130", VA = "0x1892C3530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0x92C3AC0", Offset = "0x92C26C0", VA = "0x1892C3AC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private QGGDGVMYJMC callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private APQTHAEMUEW data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private StackTimer<string>.YOQUQHZDBKW timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private float resendInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private float maxWaitEndTime;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x92B35A0", Offset = "0x92B21A0", VA = "0x1892B35A0")]
		public static Task HVSQMUYLXYJ(FQSENOYUOAD a, APQTHAEMUEW b, StackTimer<string>.YOQUQHZDBKW c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x92B3960", Offset = "0x92B2560", VA = "0x1892B3960")]
		[AsyncStateMachine(typeof(<Run>d__8))]
		public Task Run(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x92B3820", Offset = "0x92B2420", VA = "0x1892B3820")]
		private static void QQQHKTUXOIT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x92B3440", Offset = "0x92B2040", VA = "0x1892B3440")]
		private void BRDQSHEAPKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x92B3740", Offset = "0x92B2340", VA = "0x1892B3740")]
		private static float HXGQUFWUNAJ(QGGDGVMYJMC a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x92B3800", Offset = "0x92B2400", VA = "0x1892B3800")]
		private static float QFGPTDJBDTQ()
		{
			return default(float);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	internal struct InstantiateObjectsTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000179")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000693")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000694")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000695")]
			public XMOUJWJJAGN operationContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000696")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000697")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000698")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000699")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400069A")]
			private UTQHQVVVWVQ <operation>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400069B")]
			private FQSENOYUOAD <roomManager>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400069C")]
			private PreInstantiateObjectsTask.Results <instantiations>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400069D")]
			private TaskAwaiter<BURCCBMBLWO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400069E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x92BFB10", Offset = "0x92BE710", VA = "0x1892BFB10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x92C03D0", Offset = "0x92BEFD0", VA = "0x1892C03D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200017A")]
		[CompilerGenerated]
		private struct <WaitForInstantiatedObjectsToInitialize>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400069F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006A0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006A1")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006A2")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x92C85E0", Offset = "0x92C71E0", VA = "0x1892C85E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x92C8910", Offset = "0x92C7510", VA = "0x1892C8910", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x92B3C10", Offset = "0x92B2810", VA = "0x1892B3C10")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(XMOUJWJJAGN operationContext, APQTHAEMUEW data, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x92B3BA0", Offset = "0x92B27A0", VA = "0x1892B3BA0")]
		private static Task<BURCCBMBLWO> FBLSOZXRVKT(XMOUJWJJAGN a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x92B3D50", Offset = "0x92B2950", VA = "0x1892B3D50")]
		[AsyncStateMachine(typeof(<WaitForInstantiatedObjectsToInitialize>d__2))]
		private static Task WaitForInstantiatedObjectsToInitialize()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal struct LoadEmptySceneTask
	{
		[Cpp2IlInjected.Token(Token = "0x200017C")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006A7")]
			public string FEVSDUJHSFW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006A8")]
			public bool GHIQTEVOFLN;

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x92B0A30", Offset = "0x92AF630", VA = "0x1892B0A30")]
			internal object HXPZKGSFGLS()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200017D")]
		[CompilerGenerated]
		private struct <Run>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006A9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006AA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006AB")]
			public LoadEmptySceneTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006AC")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006AD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006AE")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x92C2A80", Offset = "0x92C1680", VA = "0x1892C2A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x92C34D0", Offset = "0x92C20D0", VA = "0x1892C34D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200017E")]
		[CompilerGenerated]
		private struct <SafeLoadSceneAsync>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006B0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006B1")]
			public string sceneName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006B2")]
			public bool stopOnEmptyScene;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006B3")]
			public LoadEmptySceneTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006B4")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40006B5")]
			private TaskAwaiter<Scene> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x92C3B20", Offset = "0x92C2720", VA = "0x1892C3B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x92C4010", Offset = "0x92C2C10", VA = "0x1892C4010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private bool isOffline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private StackTimer<string>.YOQUQHZDBKW timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private FQSENOYUOAD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x92B3FD0", Offset = "0x92B2BD0", VA = "0x1892B3FD0")]
		public static Task LoadEmptyScene(FQSENOYUOAD roomManager, bool isOffline, StackTimer<string>.YOQUQHZDBKW timer, CancellationToken roomCancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x92B4040", Offset = "0x92B2C40", VA = "0x1892B4040")]
		[AsyncStateMachine(typeof(<Run>d__5))]
		private Task Run()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x92B3EA0", Offset = "0x92B2AA0", VA = "0x1892B3EA0")]
		[AsyncStateMachine(typeof(<SafeLoadSceneAsync>d__6))]
		private Task GNMIELJXKAQ(bool a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x92B3E10", Offset = "0x92B2A10", VA = "0x1892B3E10")]
		private bool AGNYMEPNVZK(bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	internal struct LoadSceneTask
	{
		[Cpp2IlInjected.Token(Token = "0x2000180")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006B9")]
			public string FEVSDUJHSFW;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x92B4530", Offset = "0x92B3130", VA = "0x1892B4530")]
			internal object HXPZKGSFGLS()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000181")]
		[CompilerGenerated]
		private struct <Run>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006BB")]
			public AsyncTaskMethodBuilder<Scene> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006BC")]
			public LoadSceneTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006BD")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006BE")]
			private TaskAwaiter<Scene> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x92C2540", Offset = "0x92C1140", VA = "0x1892C2540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x92C2A10", Offset = "0x92C1610", VA = "0x1892C2A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000182")]
		[CompilerGenerated]
		private struct <SafeLoadSceneAsync>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C0")]
			public AsyncTaskMethodBuilder<Scene> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C1")]
			public string sceneName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006C2")]
			public LoadSceneTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006C3")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006C4")]
			private TaskAwaiter<Scene> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0x92DAAF0", Offset = "0x92D96F0", VA = "0x1892DAAF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0x92DAFF0", Offset = "0x92D9BF0", VA = "0x1892DAFF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private RoomSceneLocations roomLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private StackTimer<string>.YOQUQHZDBKW timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private FQSENOYUOAD roomManager;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x92B4270", Offset = "0x92B2E70", VA = "0x1892B4270")]
		public static Task<Scene> OCKCLLESXQR(FQSENOYUOAD a, RoomSceneLocations b, StackTimer<string>.YOQUQHZDBKW c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x92B42C0", Offset = "0x92B2EC0", VA = "0x1892B42C0")]
		[AsyncStateMachine(typeof(<Run>d__4))]
		private Task<Scene> Run()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x92B4130", Offset = "0x92B2D30", VA = "0x1892B4130")]
		[AsyncStateMachine(typeof(<SafeLoadSceneAsync>d__5))]
		private Task<Scene> GNMIELJXKAQ(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	internal struct MoveToPhaseTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000184")]
		[CompilerGenerated]
		private struct <MoveTo>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006C8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006C9")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006CA")]
			public MoveToPhaseTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006CB")]
			public RoomOperationState nextPhase;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006CC")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006CD")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006CE")]
			public bool skipHandlers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40006CF")]
			public APQTHAEMUEW deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40006D0")]
			private StackTimer<string>.YOQUQHZDBKW <moveToPhaseTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40006D1")]
			private Guid <handlersGuid>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40006D2")]
			private TaskAwaiter<RoomOperationState> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40006D3")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x92D4DD0", Offset = "0x92D39D0", VA = "0x1892D4DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0x92D58A0", Offset = "0x92D44A0", VA = "0x1892D58A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[CompilerGenerated]
		private struct <SendStateChangeMessage>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006D4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006D5")]
			public AsyncTaskMethodBuilder<RoomOperationState> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006D6")]
			public MoveToPhaseTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006D7")]
			public RoomOperationState state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006D8")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006D9")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40006DA")]
			private TaskAwaiter<BURCCBMBLWO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0x92DB060", Offset = "0x92D9C60", VA = "0x1892DB060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0x92DB340", Offset = "0x92D9F40", VA = "0x1892DB340", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private readonly XMOUJWJJAGN operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private readonly VNEBTMGFLNZ debugRoomLoadInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private readonly OPGCUUOBYPN handlers;

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		private UTQHQVVVWVQ CUQMBSKIYKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x44108D0", Offset = "0x440F4D0", VA = "0x1844108D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x92CC750", Offset = "0x92CB350", VA = "0x1892CC750")]
		public MoveToPhaseTask(XMOUJWJJAGN operationContext, VNEBTMGFLNZ debugRoomLoadInfo, OPGCUUOBYPN handlers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x92CC440", Offset = "0x92CB040", VA = "0x1892CC440")]
		[AsyncStateMachine(typeof(<MoveTo>d__6))]
		public Task<RoomOperationState> MoveTo(RoomOperationState nextPhase, APQTHAEMUEW deserializationData, StackTimer<string>.YOQUQHZDBKW stackTimer, CancellationToken cancellationToken, bool skipHandlers)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x92CC5F0", Offset = "0x92CB1F0", VA = "0x1892CC5F0")]
		[AsyncStateMachine(typeof(<SendStateChangeMessage>d__7))]
		private Task<RoomOperationState> XRKMEORUIOD(StackTimer<string>.YOQUQHZDBKW a, RoomOperationState b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x92CC5C0", Offset = "0x92CB1C0", VA = "0x1892CC5C0")]
		private bool PKOJAWYLDKG(RoomOperationState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x92CC420", Offset = "0x92CB020", VA = "0x1892CC420")]
		private void Log(string msg)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	internal struct PostDeserializeObjectsTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000187")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006DC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006DD")]
			public UTQHQVVVWVQ operation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006DE")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006DF")]
			public HSQOIPLQDEG timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006E0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006E1")]
			private bool <isMaster>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006E2")]
			private LogRangeScope <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40006E3")]
			private List<(PersistenceView, ABLNPBVPOUZ)>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40006E4")]
			private (PersistenceView, ABLNPBVPOUZ) <pair>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40006E5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x92D81F0", Offset = "0x92D6DF0", VA = "0x1892D81F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0x92D9200", Offset = "0x92D7E00", VA = "0x1892D9200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x92CFDA0", Offset = "0x92CE9A0", VA = "0x1892CFDA0")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(UTQHQVVVWVQ operation, APQTHAEMUEW data, HSQOIPLQDEG timedYielder, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	internal struct PreDeserializeObjectsTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[CompilerGenerated]
		private struct <Run>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006E6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006E7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006E8")]
			public UTQHQVVVWVQ operation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006E9")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006EA")]
			public HSQOIPLQDEG timedYielder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006EB")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40006EC")]
			private bool <isMaster>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40006ED")]
			private DEPRECATED_RoomPersistenceVersion <DEPRECATED_version>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40006EE")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40006EF")]
			private IDisposable <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40006F0")]
			private List<(PersistenceView, ABLNPBVPOUZ)>.Enumerator <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40006F1")]
			private PersistenceView <view>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40006F2")]
			private ABLNPBVPOUZ <viewData>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40006F3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x92D88C0", Offset = "0x92D74C0", VA = "0x1892D88C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x92D91A0", Offset = "0x92D7DA0", VA = "0x1892D91A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x92CFEE0", Offset = "0x92CEAE0", VA = "0x1892CFEE0")]
		[AsyncStateMachine(typeof(<Run>d__0))]
		public static Task Run(UTQHQVVVWVQ operation, APQTHAEMUEW data, HSQOIPLQDEG timedYielder, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	public struct PrefetchAssetBundlesTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200018B")]
		[CompilerGenerated]
		private struct <Run>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006FC")]
			public AsyncTaskMethodBuilder<Result<BZZBICGVUJE, UTITDXZLKVK>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006FD")]
			public PrefetchAssetBundlesTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40006FE")]
			public RecNet.Core.OnDownloadProgressDelegate preloadProgressCallback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000700")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000701")]
			private TaskAwaiter<Result<BZZBICGVUJE, UTITDXZLKVK>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000666")]
			[Cpp2IlInjected.Address(RVA = "0x92DA400", Offset = "0x92D9000", VA = "0x1892DA400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000667")]
			[Cpp2IlInjected.Address(RVA = "0x92DAA80", Offset = "0x92D9680", VA = "0x1892DAA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		private long _roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		private long _subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		private Guid? _unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		private IReadOnlyCollection<BakedUnitySubAssetDTO> _unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		private IReadOnlyCollection<BakedUnitySubAssetDTO> _referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private QZLEUZSCQDU _subRoomAssetBundleProvider;

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x92D0C00", Offset = "0x92CF800", VA = "0x1892D0C00")]
		public static Task<Result<BZZBICGVUJE, UTITDXZLKVK>> ZDQPLOAPRLZ(long a, long b, SubRoomDataSaveWithUnityAssetsDTO c, RecNet.Core.OnDownloadProgressDelegate d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x92D0AA0", Offset = "0x92CF6A0", VA = "0x1892D0AA0")]
		[AsyncStateMachine(typeof(<Run>d__8))]
		private Task<Result<BZZBICGVUJE, UTITDXZLKVK>> Run(RecNet.Core.OnDownloadProgressDelegate preloadProgressCallback, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	internal struct PreInstantiateObjectsTask
	{
		[Cpp2IlInjected.Token(Token = "0x200018D")]
		public struct Results
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000704")]
			public List<PPKMOZLMJPM> instantiationRequests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000705")]
			public List<ABLNPBVPOUZ> requestDatas;

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0xCC7910", Offset = "0xCC6510", VA = "0x180CC7910")]
			public Results(List<PPKMOZLMJPM> instantiationRequests, List<ABLNPBVPOUZ> requestDatas)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018E")]
		[CompilerGenerated]
		private sealed class TMFRKOCFRTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000706")]
			public IEnumerable<PPKMOZLMJPM> USAVTDMIAVK;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TMFRKOCFRTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x92D2D80", Offset = "0x92D1980", VA = "0x1892D2D80")]
			internal object UOVEAZKFDCG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private FQSENOYUOAD roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		private APQTHAEMUEW data;

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		private QGGDGVMYJMC WYXWMMZBGZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0x92D0020", Offset = "0x92CEC20", VA = "0x1892D0020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x92D0880", Offset = "0x92CF480", VA = "0x1892D0880")]
		public static Results Run(FQSENOYUOAD roomManager, APQTHAEMUEW data)
		{
			return default(Results);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x92D0620", Offset = "0x92CF220", VA = "0x1892D0620")]
		private Results Run()
		{
			return default(Results);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x92D0070", Offset = "0x92CEC70", VA = "0x1892D0070")]
		private Results KFXIGHJYNMQ(PersistedRoomData a, DEPRECATED_RoomPersistenceVersion b)
		{
			return default(Results);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x92D08E0", Offset = "0x92CF4E0", VA = "0x1892D08E0")]
		private bool VPILGKCTOCK(IEnumerable<PPKMOZLMJPM> a)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	internal struct RegisterInstantiatedObjectsTask
	{
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000707")]
			public PreInstantiateObjectsTask.Results IDFHCXNZHCD;

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0x92DF7D0", Offset = "0x92DE3D0", VA = "0x1892DF7D0")]
			internal object HJZPPMASNVA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000191")]
		[CompilerGenerated]
		private sealed class UUXQCCVJIIU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000708")]
			public PersistenceView RCSYKYQQLTG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000709")]
			public Guid ZEMVGGLCETH;

			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UUXQCCVJIIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x92DF740", Offset = "0x92DE340", VA = "0x1892DF740")]
			internal object HKEWMSUPXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x92D12F0", Offset = "0x92CFEF0", VA = "0x1892D12F0")]
		public static void Run(UTQHQVVVWVQ operation, APQTHAEMUEW data, PreInstantiateObjectsTask.Results instantiations)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	internal class OPGCUUOBYPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000194")]
		[CompilerGenerated]
		private sealed class CITSQHBYTVL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400070F")]
			public Guid SQHZEESNQFK;

			[Cpp2IlInjected.Token(Token = "0x6000687")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CITSQHBYTVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0x92C93E0", Offset = "0x92C7FE0", VA = "0x1892C93E0")]
			internal object GAPCWSCYVIH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[CompilerGenerated]
		private sealed class QOCTNDBRPOU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000710")]
			public Guid SQHZEESNQFK;

			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QOCTNDBRPOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0x92D1150", Offset = "0x92CFD50", VA = "0x1892D1150")]
			internal object KCKUGCLXZID()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000196")]
		[CompilerGenerated]
		private sealed class CMIBJUZGHFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000711")]
			public Guid SQHZEESNQFK;

			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CMIBJUZGHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0x92C9450", Offset = "0x92C8050", VA = "0x1892C9450")]
			internal object FBKRSVJPTOG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000197")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000198")]
			private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000716")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000717")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000718")]
				public BZLIFPWZYIV <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000719")]
				public CancellationToken mlbToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400071A")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600068F")]
				[Cpp2IlInjected.Address(RVA = "0x92DC390", Offset = "0x92DAF90", VA = "0x1892DC390", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000690")]
				[Cpp2IlInjected.Address(RVA = "0x92DC650", Offset = "0x92DB250", VA = "0x1892DC650", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000712")]
			public OPGCUUOBYPN VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000713")]
			public APQTHAEMUEW DPRTRIXCCFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000714")]
			public StackTimer<string>.YOQUQHZDBKW SGEQXJXYJGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000715")]
			public Func<CancellationToken, Task> VNPNSVZAKTC;

			[Cpp2IlInjected.Token(Token = "0x600068D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0x92C9280", Offset = "0x92C7E80", VA = "0x1892C9280")]
			[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
			internal Task FABKKPBKDNV(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000199")]
		[CompilerGenerated]
		private sealed class XYJRREPQRHS
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200019A")]
			private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000720")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000721")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000722")]
				public DeserializationPhaseHandler handler;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000723")]
				public XYJRREPQRHS <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000724")]
				private LogRangeScope <_>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000725")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000695")]
				[Cpp2IlInjected.Address(RVA = "0x92DBEC0", Offset = "0x92DAAC0", VA = "0x1892DBEC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000696")]
				[Cpp2IlInjected.Address(RVA = "0x92DC330", Offset = "0x92DAF30", VA = "0x1892DC330", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400071B")]
			public RunFor MMEKEFJCOYB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400071C")]
			public Guid GWCVDPTCYMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400071D")]
			public List<DeserializationPhaseHandler> BQHDPEQHXPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400071E")]
			public APQTHAEMUEW DPRTRIXCCFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400071F")]
			public CancellationToken KFRYZTAHFIG;

			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XYJRREPQRHS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x92E0BB0", Offset = "0x92DF7B0", VA = "0x1892E0BB0")]
			internal object YMDSBJBREZJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x92E0C90", Offset = "0x92DF890", VA = "0x1892E0C90")]
			[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
			internal Task YMOFVWPLXWB(DeserializationPhaseHandler a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x92E0AD0", Offset = "0x92DF6D0", VA = "0x1892E0AD0")]
			internal object YLYLECHTVOA()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019B")]
		[CompilerGenerated]
		private struct <InvokeMethodsInParallel>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000726")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000727")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000728")]
			public RunFor runFor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000729")]
			public Guid handlerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400072A")]
			public List<DeserializationPhaseHandler> methods;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400072B")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400072C")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400072D")]
			private XYJRREPQRHS <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400072E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000697")]
			[Cpp2IlInjected.Address(RVA = "0x92D3730", Offset = "0x92D2330", VA = "0x1892D3730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000698")]
			[Cpp2IlInjected.Address(RVA = "0x92D3BD0", Offset = "0x92D27D0", VA = "0x1892D3BD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019C")]
		[CompilerGenerated]
		private struct <MasterInvokeHandlerMethods>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400072F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000730")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000731")]
			public Guid handlerIdToRun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000732")]
			public OPGCUUOBYPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000733")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000734")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000735")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000736")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0x92D3C30", Offset = "0x92D2830", VA = "0x1892D3C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0x92D40E0", Offset = "0x92D2CE0", VA = "0x1892D40E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		[CompilerGenerated]
		private struct <MasterLockedHandler>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000737")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000738")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000739")]
			public OPGCUUOBYPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400073A")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400073B")]
			public StackTimer<string>.YOQUQHZDBKW timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400073C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400073D")]
			private Guid <handlerIdToRun>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400073E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x92D4140", Offset = "0x92D2D40", VA = "0x1892D4140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069C")]
			[Cpp2IlInjected.Address(RVA = "0x92D46F0", Offset = "0x92D32F0", VA = "0x1892D46F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019E")]
		[CompilerGenerated]
		private struct <MasterSyncSendCompletionMark>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400073F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000740")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000741")]
			public Guid handlerIdToRun;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000742")]
			public OPGCUUOBYPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000743")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000744")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000745")]
			private LogRangeScope <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000746")]
			private ByteString <completionMark>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000747")]
			private TaskAwaiter<BURCCBMBLWO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0x92D4750", Offset = "0x92D3350", VA = "0x1892D4750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069E")]
			[Cpp2IlInjected.Address(RVA = "0x92D4D70", Offset = "0x92D3970", VA = "0x1892D4D70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200019F")]
		[CompilerGenerated]
		private struct <Run>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000748")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000749")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400074A")]
			public OPGCUUOBYPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400074B")]
			public RoomOperationState operationState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400074C")]
			public APQTHAEMUEW deserializationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400074D")]
			public StackTimer<string>.YOQUQHZDBKW timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400074E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400074F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600069F")]
			[Cpp2IlInjected.Address(RVA = "0x92D9950", Offset = "0x92D8550", VA = "0x1892D9950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A0")]
			[Cpp2IlInjected.Address(RVA = "0x92DA0B0", Offset = "0x92D8CB0", VA = "0x1892DA0B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		[CompilerGenerated]
		private struct <RunAllHandlers>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000750")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000751")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000752")]
			public OPGCUUOBYPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000753")]
			public StackTimer<string>.YOQUQHZDBKW timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000754")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000755")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000756")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000757")]
			private Dictionary<Guid, List<DeserializationPhaseHandler>>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000758")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006A1")]
			[Cpp2IlInjected.Address(RVA = "0x92D6A10", Offset = "0x92D5610", VA = "0x1892D6A10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A2")]
			[Cpp2IlInjected.Address(RVA = "0x92D7020", Offset = "0x92D5C20", VA = "0x1892D7020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001A1")]
		[CompilerGenerated]
		private struct <RunAuthorityHandler>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000759")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400075A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400075B")]
			public OPGCUUOBYPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400075C")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400075D")]
			public StackTimer<string>.YOQUQHZDBKW timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400075E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400075F")]
			private BZLIFPWZYIV <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000760")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0x92D7080", Offset = "0x92D5C80", VA = "0x1892D7080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0x92D7590", Offset = "0x92D6190", VA = "0x1892D7590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001A2")]
		[CompilerGenerated]
		private struct <RunNonAuthorityHandlers>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000761")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000762")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000763")]
			public OPGCUUOBYPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000764")]
			public StackTimer<string>.YOQUQHZDBKW timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000765")]
			public APQTHAEMUEW data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000766")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000767")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000768")]
			private Dictionary<Guid, List<DeserializationPhaseHandler>>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000769")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0x92D7AF0", Offset = "0x92D66F0", VA = "0x1892D7AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006A6")]
			[Cpp2IlInjected.Address(RVA = "0x92D8190", Offset = "0x92D6D90", VA = "0x1892D8190", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		private readonly XMOUJWJJAGN GJKLNCNNTMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		private DeserializationHandlerLists XYOGUEPFELK;

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		private UTQHQVVVWVQ CUQMBSKIYKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(RVA = "0x139FFC0", Offset = "0x139EBC0", VA = "0x18139FFC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public OPGCUUOBYPN(XMOUJWJJAGN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x92CD2F0", Offset = "0x92CBEF0", VA = "0x1892CD2F0")]
		[AsyncStateMachine(typeof(<Run>d__5))]
		public Task Run(RoomOperationState operationState, APQTHAEMUEW deserializationData, StackTimer<string>.YOQUQHZDBKW timer, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x92CD1B0", Offset = "0x92CBDB0", VA = "0x1892CD1B0")]
		[AsyncStateMachine(typeof(<RunAuthorityHandler>d__6))]
		private Task PBFVYQKLCIF(APQTHAEMUEW a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x92CD6D0", Offset = "0x92CC2D0", VA = "0x1892CD6D0")]
		[AsyncStateMachine(typeof(<RunAllHandlers>d__7))]
		private Task ZXSXUZFEYXW(APQTHAEMUEW a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x92CD070", Offset = "0x92CBC70", VA = "0x1892CD070")]
		[AsyncStateMachine(typeof(<RunNonAuthorityHandlers>d__8))]
		private Task NPIFSWMOGUP(APQTHAEMUEW a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x92CD440", Offset = "0x92CC040", VA = "0x1892CD440")]
		[AsyncStateMachine(typeof(<InvokeMethodsInParallel>d__9))]
		private Task SIYBJUOUMAN(Guid a, List<DeserializationPhaseHandler> b, RunFor c, APQTHAEMUEW d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x92CCB70", Offset = "0x92CB770", VA = "0x1892CCB70")]
		[AsyncStateMachine(typeof(<MasterLockedHandler>d__10))]
		private Task FJTNXFLIUVJ(APQTHAEMUEW a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x92CCDC0", Offset = "0x92CB9C0", VA = "0x1892CCDC0")]
		[AsyncStateMachine(typeof(<MasterInvokeHandlerMethods>d__11))]
		private Task LJSVHMCYYDL(Guid a, APQTHAEMUEW b, StackTimer<string>.YOQUQHZDBKW c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x92CD590", Offset = "0x92CC190", VA = "0x1892CD590")]
		[AsyncStateMachine(typeof(<MasterSyncSendCompletionMark>d__12))]
		private Task WQMJIKZODPP(Guid a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x92CCCB0", Offset = "0x92CB8B0", VA = "0x1892CCCB0")]
		private void KETMCSGYZWC(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x92CCAC0", Offset = "0x92CB6C0", VA = "0x1892CCAC0")]
		private void DNFQKYNRUHR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x92CCF00", Offset = "0x92CBB00", VA = "0x1892CCF00")]
		public Guid MZEUYGXXCQO(RoomOperationState a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x92CC900", Offset = "0x92CB500", VA = "0x1892CC900")]
		[CompilerGenerated]
		private object ASJPPFVLWNP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	internal struct RunEmptySceneTasksTask
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001A4")]
		[CompilerGenerated]
		private struct <Run>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400076D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400076E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400076F")]
			public RunEmptySceneTasksTask <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000770")]
			private StackTimer<string>.YOQUQHZDBKW <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000771")]
			private IEnumerator<EmptySceneHandler> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000772")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0x92D9260", Offset = "0x92D7E60", VA = "0x1892D9260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0x92D98F0", Offset = "0x92D84F0", VA = "0x1892D98F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		private QGGDGVMYJMC callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private StackTimer<string>.YOQUQHZDBKW timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		private CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x92D2900", Offset = "0x92D1500", VA = "0x1892D2900")]
		public static Task LURDRKRQGOY(QGGDGVMYJMC a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x92D2970", Offset = "0x92D1570", VA = "0x1892D2970")]
		[AsyncStateMachine(typeof(<Run>d__4))]
		private Task Run()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	public readonly struct RoomSaveAnalyticsInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public readonly bool LastLoadedSaveWasPublished;

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x302C2F0", Offset = "0x302AEF0", VA = "0x18302C2F0")]
		public RoomSaveAnalyticsInfo(bool lastLoadedSaveWasPublished)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	public readonly struct RoomSerializedData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public readonly PersistedRoomData? RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public readonly PersistedRoomDataReferences RoomDataReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		public readonly Guid? UnityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		public readonly IReadOnlyList<Guid> RoomAssets;

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public IReadOnlyCollection<string> WIVPQLJXNBG
		{
			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0x92D1BE0", Offset = "0x92D07E0", VA = "0x1892D1BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public IReadOnlyDictionary<long, int> NWQHDXNVFYF
		{
			[Cpp2IlInjected.Token(Token = "0x60006AD")]
			[Cpp2IlInjected.Address(RVA = "0x92D1BC0", Offset = "0x92D07C0", VA = "0x1892D1BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x92D1C00", Offset = "0x92D0800", VA = "0x1892D1C00")]
		public RoomSerializedData(PersistedRoomData? roomData, PersistedRoomDataReferences roomDataReferences, Guid? unityAssetId, [Optional] IReadOnlyList<Guid>? roomAssets)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	internal class MIQJZUVSHJV : TWZVPEXJKLG
	{
		[Cpp2IlInjected.Token(Token = "0x20001A9")]
		[CompilerGenerated]
		private sealed class XYJRREPQRHS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400077F")]
			public float MMWNJYBIORS;

			[Cpp2IlInjected.Token(Token = "0x60006BB")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XYJRREPQRHS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BC")]
			[Cpp2IlInjected.Address(RVA = "0x92E0A70", Offset = "0x92DF670", VA = "0x1892E0A70")]
			internal object NJYPOTNHWBA()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AA")]
		[CompilerGenerated]
		private struct <PreserializeViews>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000780")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000781")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000782")]
			public MIQJZUVSHJV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000783")]
			public PersistenceView[] activePersistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000784")]
			public StringBuilder outputBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000785")]
			public SerializeType serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000786")]
			private XYJRREPQRHS <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000787")]
			private LogRangeScope <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000788")]
			private CancellationTokenSource <cts>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000789")]
			private ZOKMZDQINFS<Task> <tasks>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400078A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0x92D5910", Offset = "0x92D4510", VA = "0x1892D5910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0x92D6480", Offset = "0x92D5080", VA = "0x1892D6480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AB")]
		[CompilerGenerated]
		private struct <Serialize>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400078B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400078C")]
			public AsyncTaskMethodBuilder<RoomSerializedData> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400078D")]
			public MIQJZUVSHJV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400078E")]
			public long subroomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400078F")]
			public SerializeType serializeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000790")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000791")]
			public RoomSaveOptions roomSaveOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000792")]
			private PersistenceView[] <activePersistenceViews>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000793")]
			private StringBuilder <outputBuilder>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000794")]
			private LogRangeScope <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000795")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x92DB3B0", Offset = "0x92D9FB0", VA = "0x1892DB3B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0x92DBA30", Offset = "0x92DA630", VA = "0x1892DBA30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000779")]
		private static readonly TimeSpan BFJDMHHNEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		private readonly XXKKKYKOWUH NHLVQPYREHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400077B")]
		private readonly EOJOPKCMNAT FUTDUQLSTGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400077C")]
		private readonly STLQTWQCFJP ERSYMJZXJYC;

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x92CC3B0", Offset = "0x92CAFB0", VA = "0x1892CC3B0")]
		public MIQJZUVSHJV(XMOUJWJJAGN a, XXKKKYKOWUH b, EOJOPKCMNAT c, STLQTWQCFJP d, Log e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x92CBF00", Offset = "0x92CAB00", VA = "0x1892CBF00")]
		[AsyncStateMachine(typeof(<Serialize>d__7))]
		public Task<RoomSerializedData> Serialize(long subroomId, RoomSaveOptions roomSaveOptions, SerializeType serializeType, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x92CBE10", Offset = "0x92CAA10", VA = "0x1892CBE10")]
		private static bool PXIFSWEXSON(PersistenceView a, [Out] RRObjectPolicy b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x92CC200", Offset = "0x92CAE00", VA = "0x1892CC200")]
		[AsyncStateMachine(typeof(<PreserializeViews>d__9))]
		private Task ZNJSNZLXNJE(SerializeType a, PersistenceView[] b, StringBuilder c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x92CB5D0", Offset = "0x92CA1D0", VA = "0x1892CB5D0")]
		private RoomSerializedData KPQKJRGUKWJ(long a, RoomSaveOptions b, SerializeType c, IEnumerable<PersistenceView> d, StringBuilder e)
		{
			return default(RoomSerializedData);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x92CC050", Offset = "0x92CAC50", VA = "0x1892CC050")]
		private PersistedRoomData WUCFVQNWMMP(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x92CBBC0", Offset = "0x92CA7C0", VA = "0x1892CBBC0")]
		private void MRRWHSRWRNG(PersistedRoomData a, StringBuilder b, IEnumerable<PersistenceView> c, [In] RoomSerializedMetadata metadata, ELUDPWHKJWU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x92CB150", Offset = "0x92C9D50", VA = "0x1892CB150")]
		private void HMOTTUSGWKZ(PersistedRoomData a, StringBuilder b, PersistenceView c, ELUDPWHKJWU d, [In] RoomSerializedMetadata metadata)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	internal class RoomUploadLogic : TWZVPEXJKLG
	{
		[Cpp2IlInjected.Token(Token = "0x20001AD")]
		[CompilerGenerated]
		private sealed class QOCTNDBRPOU
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20001AE")]
			private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40007A1")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40007A2")]
				public AsyncTaskMethodBuilder<BURCCBMBLWO> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40007A3")]
				public QOCTNDBRPOU <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40007A4")]
				public CancellationToken masterLockedBlockCancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40007A5")]
				private BURCCBMBLWO <reloadMessage>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40007A6")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40007A7")]
				private TaskAwaiter<RemoteRunDTO> <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x40007A8")]
				private TaskAwaiter<SaveSubRoomResponseDTO> <>u__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x40007A9")]
				private TaskAwaiter<BURCCBMBLWO> <>u__4;

				[Cpp2IlInjected.Token(Token = "0x60006CC")]
				[Cpp2IlInjected.Address(RVA = "0x92DC6B0", Offset = "0x92DB2B0", VA = "0x1892DC6B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006CD")]
				[Cpp2IlInjected.Address(RVA = "0x92DD8D0", Offset = "0x92DC4D0", VA = "0x1892DD8D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000799")]
			public RoomUploadLogic VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400079A")]
			public RoomSerializedData OBTAHMBPJZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400079B")]
			public int GZDDIVWDQHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400079C")]
			public long CUBMJCRHEFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400079D")]
			public long SURVSYODJKX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400079E")]
			public RoomSaveRequestPayload YHKIKKIVLNQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400079F")]
			public RoomSaveAnalyticsInfo HGRELRFGDVX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007A0")]
			public StackTimer<string>.YOQUQHZDBKW NYNNYWQNYWA;

			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QOCTNDBRPOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CB")]
			[Cpp2IlInjected.Address(RVA = "0x92D11C0", Offset = "0x92CFDC0", VA = "0x1892D11C0")]
			[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
			internal Task<BURCCBMBLWO> MERTHTCDIRP(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		[CompilerGenerated]
		private sealed class GLPIMGKKXXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007AA")]
			public long CUBMJCRHEFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007AB")]
			public long SURVSYODJKX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007AC")]
			public Storage.UploadFileResponseDTO OBKTVOCLXVZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007AD")]
			public byte[] DPRTRIXCCFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007AE")]
			public Storage.UploadFileResponseDTO OAQQMOKZIJN;

			[Cpp2IlInjected.Token(Token = "0x60006CE")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GLPIMGKKXXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0x92C97D0", Offset = "0x92C83D0", VA = "0x1892C97D0")]
			internal object DQHXUUNKQJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(RVA = "0x92C9780", Offset = "0x92C8380", VA = "0x1892C9780")]
			internal object DQCQXNTNGXU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x92C9730", Offset = "0x92C8330", VA = "0x1892C9730")]
			internal object DPXKAGZPXML()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x92C96C0", Offset = "0x92C82C0", VA = "0x1892C96C0")]
			internal object DPSDDAFSOBC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x92C94C0", Offset = "0x92C80C0", VA = "0x1892C94C0")]
			internal object DPMWFTLVEPT()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001B0")]
		[CompilerGenerated]
		private struct <PushRoomDataBlobToStudio>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			public AsyncTaskMethodBuilder<RemoteRunDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			public RoomUploadLogic <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			public string studioSessionId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007B7")]
			private TaskAwaiter<(Storage.UploadFileResponseDTO roomDataUpload, Storage.UploadFileResponseDTO subRoomDataUpload)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007B8")]
			private TaskAwaiter<RemoteRunDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0x92D64E0", Offset = "0x92D50E0", VA = "0x1892D64E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D5")]
			[Cpp2IlInjected.Address(RVA = "0x92D69A0", Offset = "0x92D55A0", VA = "0x1892D69A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001B1")]
		[CompilerGenerated]
		private struct <UploadRoomDataBlob>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007B9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007BA")]
			public AsyncTaskMethodBuilder<SaveSubRoomResponseDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007BB")]
			public QGGDGVMYJMC callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007BC")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007BD")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007BE")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007BF")]
			public UgcVersionInfo ugcVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007C0")]
			public RoomSaveRequestPayload roomSaveRequestPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007C1")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007C2")]
			private TaskAwaiter<(Storage.UploadFileResponseDTO roomDataUpload, Storage.UploadFileResponseDTO subRoomDataUpload)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007C3")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0x92DE220", Offset = "0x92DCE20", VA = "0x1892DE220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(RVA = "0x92DE8F0", Offset = "0x92DD4F0", VA = "0x1892DE8F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		[CompilerGenerated]
		private struct <UploadRoomDataBlob>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007C4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007C5")]
			public AsyncTaskMethodBuilder<SaveSubRoomResponseDTO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007C6")]
			public RoomUploadLogic <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007C7")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007C8")]
			public RoomSaveRequestPayload roomSaveRequestPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007C9")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007CA")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007CB")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007CC")]
			private TaskAwaiter<SaveSubRoomResponseDTO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0x92DE960", Offset = "0x92DD560", VA = "0x1892DE960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0x92DEC00", Offset = "0x92DD800", VA = "0x1892DEC00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001B3")]
		[CompilerGenerated]
		private struct <UploadRoomDataBlobAndSyncReload>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007CE")]
			public AsyncTaskMethodBuilder<BURCCBMBLWO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007CF")]
			public RoomUploadLogic <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007D0")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40007D1")]
			public int savingPlayerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007D2")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007D3")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007D4")]
			public RoomSaveRequestPayload roomSaveRequestPayload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007D5")]
			public RoomSaveAnalyticsInfo roomSaveAnalyticsInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40007D6")]
			public StackTimer<string>.YOQUQHZDBKW stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40007D7")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40007D8")]
			private TaskAwaiter<BURCCBMBLWO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(RVA = "0x92DDE90", Offset = "0x92DCA90", VA = "0x1892DDE90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0x92DE1B0", Offset = "0x92DCDB0", VA = "0x1892DE1B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001B4")]
		[CompilerGenerated]
		private struct <UploadRoomDataToStorage>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public AsyncTaskMethodBuilder<(Storage.UploadFileResponseDTO roomDataUpload, Storage.UploadFileResponseDTO subRoomDataUpload)> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			public long subRoomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			public RoomSerializedData roomSerializedData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40007DE")]
			public QGGDGVMYJMC callbacks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40007DF")]
			private GLPIMGKKXXA <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40007E0")]
			private float <timer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40007E1")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40007E2")]
			private TaskAwaiter<Storage.UploadFileResponseDTO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006DC")]
			[Cpp2IlInjected.Address(RVA = "0x92DEC70", Offset = "0x92DD870", VA = "0x1892DEC70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006DD")]
			[Cpp2IlInjected.Address(RVA = "0x92DF6D0", Offset = "0x92DE2D0", VA = "0x1892DF6D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000796")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000797")]
		private static readonly Log QGEGZYQIOAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		private readonly JOBTRQDNNUS QGHPUFCOQEX;

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		private FQSENOYUOAD PLDCLQIFQLL
		{
			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x9295370", Offset = "0x9293F70", VA = "0x189295370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x92D2870", Offset = "0x92D1470", VA = "0x1892D2870")]
		public RoomUploadLogic(XMOUJWJJAGN operationContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x92D1CF0", Offset = "0x92D08F0", VA = "0x1892D1CF0")]
		[AsyncStateMachine(typeof(<UploadRoomDataToStorage>d__7))]
		private static Task<(Storage.UploadFileResponseDTO, Storage.UploadFileResponseDTO)> HHXSGKGMVVJ(QGGDGVMYJMC a, RoomSerializedData b, long c, long d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x92D2180", Offset = "0x92D0D80", VA = "0x1892D2180")]
		[AsyncStateMachine(typeof(<UploadRoomDataBlob>d__8))]
		public Task<SaveSubRoomResponseDTO> SPXXQWUEDYM(int a, [CanBeNull] RoomSaveRequestPayload roomSaveRequestPayload, RoomSerializedData b, long c, long d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x92D22F0", Offset = "0x92D0EF0", VA = "0x1892D22F0")]
		public static Task<SaveSubRoomResponseDTO> SPXXQWUEDYM(QGGDGVMYJMC a, int b, [CanBeNull] RoomSaveRequestPayload roomSaveRequestPayload, RoomSerializedData c, long d, long e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x92D2640", Offset = "0x92D1240", VA = "0x1892D2640")]
		[AsyncStateMachine(typeof(<UploadRoomDataBlob>d__10))]
		public static Task<SaveSubRoomResponseDTO> SPXXQWUEDYM(QGGDGVMYJMC a, int b, [CanBeNull] RoomSaveRequestPayload roomSaveRequestPayload, RoomSerializedData c, long d, long e, UgcVersionInfo f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x92D1E50", Offset = "0x92D0A50", VA = "0x1892D1E50")]
		[AsyncStateMachine(typeof(<PushRoomDataBlobToStudio>d__11))]
		private Task<RemoteRunDTO> KRYRZIDNYMO(string a, int b, RoomSerializedData c, long d, long e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x92D1FD0", Offset = "0x92D0BD0", VA = "0x1892D1FD0")]
		[AsyncStateMachine(typeof(<UploadRoomDataBlobAndSyncReload>d__12))]
		public Task<BURCCBMBLWO> LYDYBAOWZWD(int a, RoomSaveRequestPayload? roomSaveRequestPayload, RoomSerializedData b, long c, long d, RoomSaveAnalyticsInfo e, StackTimer<string>.YOQUQHZDBKW f, CancellationToken g)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	public abstract class LMEYXMVWHIR<a> where a : LMEYXMVWHIR<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		internal readonly FQSENOYUOAD GPHFZLARIPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		private int? BWXVYLNUDDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		protected readonly Guid NTOLQNYWQVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		protected readonly RoomOperationType GHXAFPGXIMX;

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		protected a TFBJZZJYTUD
		{
			[Cpp2IlInjected.Token(Token = "0x60006DE")]
			[Cpp2IlInjected.Address(RVA = "0x59D1BA0", Offset = "0x59D07A0", VA = "0x1859D1BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x59D1C00", Offset = "0x59D0800", VA = "0x1859D1C00")]
		internal LMEYXMVWHIR(FQSENOYUOAD a, RoomOperationType b, [Optional] Guid? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x59D1930", Offset = "0x59D0530", VA = "0x1859D1930")]
		private BURCCBMBLWO NHQQZORDVUP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
		protected virtual void FGMCOOMOQZE(BURCCBMBLWO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x59D1700", Offset = "0x59D0300", VA = "0x1859D1700")]
		public a GXFFFPZYJCD(WJBKOLNRRJE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x59D1880", Offset = "0x59D0480", VA = "0x1859D1880")]
		public a KSZKUPJIESP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x59D1A10", Offset = "0x59D0610", VA = "0x1859D1A10", Slot = "5")]
		public virtual Task<DRXWOXZYIVH> Submit()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	public class QLIAHHCFMBM : LMEYXMVWHIR<QLIAHHCFMBM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		private RoomLoadRequestPayload KSSBTTCLKAV;

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x92D1080", Offset = "0x92CFC80", VA = "0x1892D1080")]
		internal QLIAHHCFMBM(FQSENOYUOAD a, RoomOperationType b, [Optional] Guid? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x84694E0", Offset = "0x84680E0", VA = "0x1884694E0")]
		public QLIAHHCFMBM OPNMEHAZBWB(RoomLoadRequestPayload a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x92D0FB0", Offset = "0x92CFBB0", VA = "0x1892D0FB0", Slot = "4")]
		protected override void FGMCOOMOQZE(BURCCBMBLWO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	public class TQEYZQHZQJX : LMEYXMVWHIR<TQEYZQHZQJX>
	{
		[Cpp2IlInjected.Token(Token = "0x20001B8")]
		internal enum SaveTarget
		{
			[Cpp2IlInjected.Token(Token = "0x40007EC")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40007ED")]
			Disk,
			[Cpp2IlInjected.Token(Token = "0x40007EE")]
			RecNet
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001B9")]
		[CompilerGenerated]
		private struct <Submit>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007F0")]
			public AsyncTaskMethodBuilder<DRXWOXZYIVH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007F1")]
			public TQEYZQHZQJX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007F2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007F3")]
			private TaskAwaiter<DRXWOXZYIVH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x92DBAA0", Offset = "0x92DA6A0", VA = "0x1892DBAA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x92DBE50", Offset = "0x92DAA50", VA = "0x1892DBE50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		private SaveTarget ERTDUMJEEOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		private string MCZMODPZAWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		private RoomSaveRequestPayload KSSBTTCLKAV;

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x92D3120", Offset = "0x92D1D20", VA = "0x1892D3120")]
		internal TQEYZQHZQJX(FQSENOYUOAD a, RoomOperationType b, [Optional] Guid? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x92D2FB0", Offset = "0x92D1BB0", VA = "0x1892D2FB0")]
		public TQEYZQHZQJX KLVBCBJMWFD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x92D2DF0", Offset = "0x92D19F0", VA = "0x1892D2DF0")]
		public TQEYZQHZQJX EYOCNYAEHGR(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x92D2FE0", Offset = "0x92D1BE0", VA = "0x1892D2FE0")]
		public TQEYZQHZQJX RLAXELMUOSJ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x92D30F0", Offset = "0x92D1CF0", VA = "0x1892D30F0")]
		public TQEYZQHZQJX ZRMQQWLGMKV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x92D2E50", Offset = "0x92D1A50", VA = "0x1892D2E50", Slot = "4")]
		protected override void FGMCOOMOQZE(BURCCBMBLWO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x92D3000", Offset = "0x92D1C00", VA = "0x1892D3000", Slot = "5")]
		[AsyncStateMachine(typeof(<Submit>d__11))]
		public override Task<DRXWOXZYIVH> Submit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x92D2E10", Offset = "0x92D1A10", VA = "0x1892D2E10")]
		[CompilerGenerated]
		[DebuggerHidden]
		private Task<DRXWOXZYIVH> FFJGLFYMHDZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	internal static class QJMWAFLNMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x92D0DF0", Offset = "0x92CF9F0", VA = "0x1892D0DF0")]
		public static void BFFULFDHQDE(this PlayerPresence a, RoomInstance b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x92D0F30", Offset = "0x92CFB30", VA = "0x1892D0F30")]
		public static void BRQIZDRBKNJ(this RoomInstance a, [Optional] string b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	public static class OCVGIHWILWO
	{
		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x92CC7B0", Offset = "0x92CB3B0", VA = "0x1892CC7B0")]
		public static FilenameWithHash LSGNSQXSIFD(this ZHEHREDIYKI a)
		{
			return default(FilenameWithHash);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x92CC850", Offset = "0x92CB450", VA = "0x1892CC850")]
		public static ZHEHREDIYKI TAZCDAQOCTE(this FilenameWithHash a)
		{
			return null;
		}
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001BD")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007F7")]
			public ValidationReason ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007F8")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007F9")]
			public ValidationReason HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007FA")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007FB")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007FC")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		private static ValidationReason[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		private Dictionary<ValidationReason, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x92E0120", Offset = "0x92DED20", VA = "0x1892E0120")]
		public bool TryGetConfig(ValidationReason validationReason, [Out] ResultConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x92DF880", Offset = "0x92DE480", VA = "0x1892DF880")]
		public ResultConfig GetConfigForResult(ValidationReason reason, [Optional] HashSet<ValidationReason> visited)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x92DFF40", Offset = "0x92DEB40", VA = "0x1892DFF40", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x92DF9B0", Offset = "0x92DE5B0", VA = "0x1892DF9B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xDB83A0", Offset = "0xDB6FA0", VA = "0x180DB83A0")]
		public ValidationResultConfig()
		{
		}
	}
}
namespace RecRoom.RoomLoading.PreEmptyScene
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	public class RoomManagerPreEmptyScene : ZYFLTPZZNZS
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001C0")]
		[CompilerGenerated]
		private struct <Run>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000804")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000805")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000806")]
			public RoomManagerPreEmptyScene <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000807")]
			public StackTimer<string>.YOQUQHZDBKW timerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000808")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000809")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0x92DA110", Offset = "0x92D8D10", VA = "0x1892DA110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0x92DA3A0", Offset = "0x92D8FA0", VA = "0x1892DA3A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		[CompilerGenerated]
		private struct <RunHandlerWithCancellationForwarding>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400080A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400080B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400080C")]
			public StackTimer<string>.YOQUQHZDBKW timerScope;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400080D")]
			public ZYFLTPZZNZS preEmptySceneHandler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400080E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400080F")]
			private StackTimer<string>.YOQUQHZDBKW <ts>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000810")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0x92D75F0", Offset = "0x92D61F0", VA = "0x1892D75F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0x92D7A90", Offset = "0x92D6690", VA = "0x1892D7A90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		private readonly MNGGPZMAGCC KLVJKUVXYMF;

		[Cpp2IlInjected.Token(Token = "0x4000803")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public string VQRZYOUMYSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x92D1880", Offset = "0x92D0480", VA = "0x1892D1880", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x92D19D0", Offset = "0x92D05D0", VA = "0x1892D19D0")]
		[IFIZWETSKCB.Root.GameOnly]
		internal static void QPCYIHMTSNL(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		[RecRoom.NoEngine.Common.Preserve]
		public RoomManagerPreEmptyScene([Inject(null)] MNGGPZMAGCC assetBundlePreEmptySceneHandler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x92D1A40", Offset = "0x92D0640", VA = "0x1892D1A40", Slot = "5")]
		[AsyncStateMachine(typeof(<Run>d__6))]
		public Task Run(StackTimer<string>.YOQUQHZDBKW timerScope, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x92D18B0", Offset = "0x92D04B0", VA = "0x1892D18B0")]
		[AsyncStateMachine(typeof(<RunHandlerWithCancellationForwarding>d__7))]
		private Task IDXCHRCIOXY(ZYFLTPZZNZS a, StackTimer<string>.YOQUQHZDBKW b, CancellationToken c)
		{
			return null;
		}
	}
}
namespace RecRoom.RoomLoading.Interfaces.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	public interface MNGGPZMAGCC : ZYFLTPZZNZS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	public interface ZYFLTPZZNZS
	{
		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		string VQRZYOUMYSR
		{
			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task Run(StackTimer<string>.YOQUQHZDBKW timerScope, CancellationToken cancellationToken);
	}
}
namespace RecRoom.RoomLoading.AutoSaves
{
	[Cpp2IlInjected.Token(Token = "0x20001C4")]
	public static class TWMQEGPQTJZ
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x92D3290", Offset = "0x92D1E90", VA = "0x1892D3290")]
		[IFIZWETSKCB.Root.GameOnly]
		internal static void KQEBINAABYI(DiContainer a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	public interface LYUZIEXLVDR : IEquatable<LYUZIEXLVDR>
	{
		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		DateTime CLLPLOMQSYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Delete();

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool YWCLSLMIQLM(long a, long b, [Out] RoomSerializedData c);
	}
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	internal class JQODMKCQHCL : OWYEAKDBTGI
	{
		[Cpp2IlInjected.Token(Token = "0x20001C8")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000815")]
			public AutosaveType PGFLFOSXLQX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000816")]
			public Exception GKPWMWJXCRO;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x92C9370", Offset = "0x92C7F70", VA = "0x1892C9370")]
			internal object LNZGRCFLNRF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000811")]
		private readonly ZTVMRAFJRFA MXCIOEXGHST;

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<LYUZIEXLVDR> WFHBXMFTDNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x92CAF60", Offset = "0x92C9B60", VA = "0x1892CAF60", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x92CAD40", Offset = "0x92C9940", VA = "0x1892CAD40", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		[UnityEngine.Scripting.Preserve]
		public JQODMKCQHCL([Inject(null)] ZTVMRAFJRFA autosaveStorageService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x92CA890", Offset = "0x92C9490", VA = "0x1892CA890", Slot = "6")]
		public bool DPTUSNTNQGJ(long a, long b, RoomSerializedData c, AutosaveType d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xFDF570", Offset = "0xFDE170", VA = "0x180FDF570")]
		private void CSBFAPJCIUG(LYUZIEXLVDR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x92CADF0", Offset = "0x92C99F0", VA = "0x1892CADF0", Slot = "7")]
		public bool ROUUTPENJPF(long a, long b, [Out] LYUZIEXLVDR c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x92CAB70", Offset = "0x92C9770", VA = "0x1892CAB70", Slot = "8")]
		public bool GBEJNGIQRAQ(long a, long b, AutosaveType c, [Out] LYUZIEXLVDR d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x92CA470", Offset = "0x92C9070", VA = "0x1892CA470")]
		private void CKEKLGKGVWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x92CAC20", Offset = "0x92C9820", VA = "0x1892CAC20", Slot = "9")]
		public void JPOWBEOUDZV(long a, long b)
		{
		}
	}
}
namespace RecRoom.RoomLoading.AutoSaves.Versions
{
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	internal abstract class IRZCVHCFUAQ : ZTVMRAFJRFA
	{
		[Cpp2IlInjected.Token(Token = "0x20001CA")]
		protected enum DirectoryAccessMode : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000819")]
			Read,
			[Cpp2IlInjected.Token(Token = "0x400081A")]
			Write
		}

		[Cpp2IlInjected.Token(Token = "0x20001CB")]
		[CompilerGenerated]
		private sealed class HCFOWLTMZUC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400081B")]
			public AutosaveType PGFLFOSXLQX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400081C")]
			public FileInfo GTMPBKTLZHL;

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HCFOWLTMZUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x92C9850", Offset = "0x92C8450", VA = "0x1892C9850")]
			internal object SXFTXKHOBIS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001CC")]
		[CompilerGenerated]
		private sealed class KRJUMOXJQBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400081D")]
			public IRZCVHCFUAQ VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400081E")]
			public FileInfo ZONKPZTAAXB;

			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public KRJUMOXJQBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0x92CB010", Offset = "0x92C9C10", VA = "0x1892CB010")]
			internal void RJOTKPXENSG(PlayerReporting.HileType a, string b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001CD")]
		[CompilerGenerated]
		private sealed class XFIYVDIGDPB : IEnumerable<LYUZIEXLVDR>, IEnumerable, IEnumerator<LYUZIEXLVDR>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400081F")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000820")]
			private LYUZIEXLVDR DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000821")]
			private int RPOQDRFWNXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000822")]
			public IRZCVHCFUAQ VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000823")]
			private AutosaveType PGFLFOSXLQX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000824")]
			public AutosaveType XVPTDVLRHQM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000825")]
			private FileInfo[] OKMXNYRHUZP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000826")]
			private int OJXCWEJPSRO;

			[Cpp2IlInjected.Token(Token = "0x170000F5")]
			private LYUZIEXLVDR OBHPFLTQFNV
			{
				[Cpp2IlInjected.Token(Token = "0x6000735")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F6")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x6000737")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public XFIYVDIGDPB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x92E0590", Offset = "0x92DF190", VA = "0x1892E0590", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x92E09A0", Offset = "0x92DF5A0", VA = "0x1892E09A0", Slot = "10")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x92E07B0", Offset = "0x92DF3B0", VA = "0x1892E07B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<LYUZIEXLVDR> QAHZKKSYCAM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x92E07B0", Offset = "0x92DF3B0", VA = "0x1892E07B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		private readonly object ENNEVUYWJUQ;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		protected string DMABRPMGTUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x107D5D0", Offset = "0x107C1D0", VA = "0x18107D5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public abstract AutosaveVersion BYLNWQEGNCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x92CA400", Offset = "0x92C9000", VA = "0x1892CA400")]
		protected IRZCVHCFUAQ([CanBeNull] string persistentDataDir)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x92CA060", Offset = "0x92C8C60", VA = "0x1892CA060", Slot = "5")]
		public bool XCBYOTCALME(long a, long b, AutosaveType c, [Out] LYUZIEXLVDR d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x92CA380", Offset = "0x92C8F80", VA = "0x1892CA380", Slot = "6")]
		[IteratorStateMachine(typeof(XFIYVDIGDPB))]
		public IEnumerable<LYUZIEXLVDR> ZLBFXRPFXCU(AutosaveType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(Slot = "9")]
		internal abstract void ROGJJUMSMTP(Stream a, long b, long c, RoomSerializedData d);

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(Slot = "10")]
		internal abstract bool WDDMKPNIOEM(Stream a, long b, long c, HileFunc d, [Out] RoomSerializedData e);

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x92C9CF0", Offset = "0x92C88F0", VA = "0x1892C9CF0", Slot = "7")]
		public LYUZIEXLVDR QUIVUKSNTYW(long a, long b, RoomSerializedData c, AutosaveType d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(Slot = "11")]
		[NotNull]
		protected abstract FileInfo YZDFWEDYYTF(long a, long b, AutosaveType c, DirectoryAccessMode d);

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		[NotNull]
		protected abstract DirectoryInfo AILXXKUWYJB(AutosaveType a, DirectoryAccessMode b);

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x92CA250", Offset = "0x92C8E50", VA = "0x1892CA250")]
		protected void ZDFXQCWPKST(PlayerReporting.HileType a, string b, FileInfo c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x92C98F0", Offset = "0x92C84F0", VA = "0x1892C98F0")]
		internal bool KMRILRWQMYK(FileInfo a, long b, long c, [Out] RoomSerializedData d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x92C9CA0", Offset = "0x92C88A0", VA = "0x1892C9CA0")]
		private void NWUONRIONJO(Exception a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	internal class PWFCTDXUTCB : IRZCVHCFUAQ
	{
		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public override AutosaveVersion BYLNWQEGNCF
		{
			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x15E0BF0", Offset = "0x15DF7F0", VA = "0x1815E0BF0", Slot = "8")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x92CFD10", Offset = "0x92CE910", VA = "0x1892CFD10")]
		public PWFCTDXUTCB([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x92CF220", Offset = "0x92CDE20", VA = "0x1892CF220")]
		private void RMEKYPXBEXN(AutosaveType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x92CF2A0", Offset = "0x92CDEA0", VA = "0x1892CF2A0", Slot = "9")]
		internal override void ROGJJUMSMTP(Stream a, long b, long c, RoomSerializedData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x92CF530", Offset = "0x92CE130", VA = "0x1892CF530", Slot = "10")]
		internal override bool WDDMKPNIOEM(Stream a, long b, long c, HileFunc d, [Out] RoomSerializedData e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x92CFC30", Offset = "0x92CE830", VA = "0x1892CFC30", Slot = "11")]
		protected override FileInfo YZDFWEDYYTF(long a, long b, AutosaveType c, DirectoryAccessMode d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x92CF120", Offset = "0x92CDD20", VA = "0x1892CF120", Slot = "12")]
		protected override DirectoryInfo AILXXKUWYJB(AutosaveType a, DirectoryAccessMode b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CF")]
	internal sealed class PVZVVXDXJQS : IRZCVHCFUAQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000827")]
		private static readonly byte[] NFHQLEPGVHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000828")]
		private readonly byte[] YATXLOLHSED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000829")]
		private readonly byte[] EXDRBYSLCRH;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		public override AutosaveVersion BYLNWQEGNCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x1DF3B60", Offset = "0x1DF2760", VA = "0x181DF3B60", Slot = "8")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x92CEFF0", Offset = "0x92CDBF0", VA = "0x1892CEFF0")]
		public PVZVVXDXJQS([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x92CDFC0", Offset = "0x92CCBC0", VA = "0x1892CDFC0", Slot = "9")]
		internal override void ROGJJUMSMTP(Stream a, long b, long c, RoomSerializedData d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x92CE3D0", Offset = "0x92CCFD0", VA = "0x1892CE3D0", Slot = "10")]
		internal override bool WDDMKPNIOEM(Stream a, long b, long c, HileFunc d, [Out] RoomSerializedData e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x92CDF00", Offset = "0x92CCB00", VA = "0x1892CDF00")]
		private void JUUBBOFNNFD(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x92CEE40", Offset = "0x92CDA40", VA = "0x1892CEE40", Slot = "11")]
		protected override FileInfo YZDFWEDYYTF(long a, long b, AutosaveType c, DirectoryAccessMode d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x92CDDF0", Offset = "0x92CC9F0", VA = "0x1892CDDF0", Slot = "12")]
		protected override DirectoryInfo AILXXKUWYJB(AutosaveType a, DirectoryAccessMode b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	public enum AutosaveVersion : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400082D")]
		INVALID = 0,
		[Cpp2IlInjected.Token(Token = "0x400082E")]
		CHECKSUM = 2,
		[Cpp2IlInjected.Token(Token = "0x400082F")]
		BETTER_FILE_LAYOUT = 3
	}
}
namespace RecRoom.RoomLoading.AutoSaves.Storage
{
	[Cpp2IlInjected.Token(Token = "0x20001D2")]
	internal class AAEZDPHYSKH : ZTVMRAFJRFA
	{
		[Cpp2IlInjected.Token(Token = "0x20001D4")]
		[CompilerGenerated]
		private sealed class XFIYVDIGDPB : IEnumerable<LYUZIEXLVDR>, IEnumerable, IEnumerator<LYUZIEXLVDR>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000836")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000837")]
			private LYUZIEXLVDR DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000838")]
			private int RPOQDRFWNXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000839")]
			public AAEZDPHYSKH VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400083A")]
			private AutosaveType PGFLFOSXLQX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400083B")]
			public AutosaveType XVPTDVLRHQM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400083C")]
			private AutosaveVersion[] OKMXNYRHUZP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400083D")]
			private int OJXCWEJPSRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400083E")]
			private IEnumerator<LYUZIEXLVDR> OKCJTLDNCCX;

			[Cpp2IlInjected.Token(Token = "0x170000FA")]
			private LYUZIEXLVDR OBHPFLTQFNV
			{
				[Cpp2IlInjected.Token(Token = "0x600075B")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FB")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x600075D")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public XFIYVDIGDPB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x92E09E0", Offset = "0x92DF5E0", VA = "0x1892E09E0", Slot = "7")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0x92E02B0", Offset = "0x92DEEB0", VA = "0x1892E02B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0x92E0910", Offset = "0x92DF510", VA = "0x1892E0910")]
			private void QCWGZBRZQOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0x92E0960", Offset = "0x92DF560", VA = "0x1892E0960", Slot = "10")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0x92E0860", Offset = "0x92DF460", VA = "0x1892E0860", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<LYUZIEXLVDR> QAHZKKSYCAM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x92E0860", Offset = "0x92DF460", VA = "0x1892E0860", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000830")]
		private readonly AutosaveVersion[] GOPDYMQGRYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000831")]
		private readonly Dictionary<AutosaveVersion, ZTVMRAFJRFA> HJNWRYAOUXO;

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		public AutosaveVersion BYLNWQEGNCF
		{
			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x92C8EA0", Offset = "0x92C7AA0", VA = "0x1892C8EA0", Slot = "4")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x92C8F50", Offset = "0x92C7B50", VA = "0x1892C8F50")]
		[UnityEngine.Scripting.Preserve]
		public AAEZDPHYSKH(params ZTVMRAFJRFA[] versionImpls)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x92C8D50", Offset = "0x92C7950", VA = "0x1892C8D50", Slot = "5")]
		public bool XCBYOTCALME(long a, long b, AutosaveType c, [Out] LYUZIEXLVDR d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x92C8A30", Offset = "0x92C7630", VA = "0x1892C8A30")]
		private void OZHNSHJMLYY(int a, long b, long c, AutosaveType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x92C8ED0", Offset = "0x92C7AD0", VA = "0x1892C8ED0", Slot = "6")]
		[IteratorStateMachine(typeof(XFIYVDIGDPB))]
		public IEnumerable<LYUZIEXLVDR> ZLBFXRPFXCU(AutosaveType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x92C8C60", Offset = "0x92C7860", VA = "0x1892C8C60", Slot = "7")]
		public LYUZIEXLVDR QUIVUKSNTYW(long a, long b, RoomSerializedData c, AutosaveType d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D5")]
	internal static class SZOOHDGPCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x92D2A60", Offset = "0x92D1660", VA = "0x1892D2A60")]
		internal static byte[] ComputeHash(byte[] bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x92D2D00", Offset = "0x92D1900", VA = "0x1892D2D00")]
		public static void SKZLTVUPHSG(Stream a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x92D2B20", Offset = "0x92D1720", VA = "0x1892D2B20")]
		public static bool OONTKXWWWIF(Stream a, long b, HileFunc c, [Out] byte[] d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D6")]
	internal sealed class PTZVDWBPVKA : LYUZIEXLVDR, IEquatable<LYUZIEXLVDR>, IEquatable<PTZVDWBPVKA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400083F")]
		private readonly IRZCVHCFUAQ FCGFLRMWXBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000840")]
		public readonly FileInfo AGNQRZNJXYD;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public AutosaveVersion BYLNWQEGNCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0x165A340", Offset = "0x1658F40", VA = "0x18165A340", Slot = "9")]
			get
			{
				return default(AutosaveVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public DateTime CLLPLOMQSYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(RVA = "0x92CDB70", Offset = "0x92CC770", VA = "0x1892CDB70", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x92CDCF0", Offset = "0x92CC8F0", VA = "0x1892CDCF0")]
		public PTZVDWBPVKA(IRZCVHCFUAQ a, FileInfo b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x92CDC00", Offset = "0x92CC800", VA = "0x1892CDC00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x92CD810", Offset = "0x92CC410", VA = "0x1892CD810", Slot = "5")]
		public void Delete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x92CDCB0", Offset = "0x92CC8B0", VA = "0x1892CDCB0", Slot = "6")]
		public bool YWCLSLMIQLM(long a, long b, [Out] RoomSerializedData c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x92CDA70", Offset = "0x92CC670", VA = "0x1892CDA70", Slot = "7")]
		public bool Equals(LYUZIEXLVDR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x92CD9B0", Offset = "0x92CC5B0", VA = "0x1892CD9B0", Slot = "8")]
		public bool Equals(PTZVDWBPVKA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x92CD8D0", Offset = "0x92CC4D0", VA = "0x1892CD8D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x92CDAE0", Offset = "0x92CC6E0", VA = "0x1892CDAE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D7")]
	public delegate void HileFunc(PlayerReporting.HileType hileType, string message);
	[Cpp2IlInjected.Token(Token = "0x20001D8")]
	internal interface ZTVMRAFJRFA
	{
		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		AutosaveVersion BYLNWQEGNCF
		{
			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XCBYOTCALME(long a, long b, AutosaveType c, [Out] LYUZIEXLVDR d);

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IEnumerable<LYUZIEXLVDR> ZLBFXRPFXCU(AutosaveType a);

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(Slot = "3")]
		LYUZIEXLVDR QUIVUKSNTYW(long a, long b, RoomSerializedData c, AutosaveType d);
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
