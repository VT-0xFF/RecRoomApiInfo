using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecNet.Rooms;
using RecRoom.Components;
using RecRoom.Core.Culling;
using RecRoom.DataLayer;
using RecRoom.ExportTools;
using RecRoom.Foundation;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.Mathematics;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.NoEngine.DataStructures.ProgressV2;
using RecRoom.ObjectModel;
using RecRoom.ObjectModel.ConfigUI;
using RecRoom.Protobuf;
using RecRoom.Rbex;
using RecRoom.RendererV1;
using RecRoom.RendererV1.DataProviders;
using RecRoom.ShapeRendering;
using RecRoom.Versioning;
using SharpGLTF.Materials;
using SharpGLTF.Schema2;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C35EE0", Offset = "0x8C348E0", VA = "0x188C35EE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum ExportItemTypes
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Invalid,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Room,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Invention,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	PlayerSaveData,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Avatar
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class NJCXGDZTOSF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum AssetType
		{
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			Invalid,
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			Image,
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			Holotar,
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			AudioSampler,
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			CV2Holotar,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			CV2Audio,
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			SuperRoomData,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			MeshGen
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private delegate Task BatchProcessTaskFactory(TZOLTYMUIVH client, ExecutionArgs executionArgs, AssetExport assetExport, WFAPAQCSIZF dataExportOptions, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class FFCQSWYMOJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly List<Task> QRTQZCFAAAU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly List<AssetExport> UKUXJVWBRST;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public int AGNSAISSRJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x8C32EF0", Offset = "0x8C318F0", VA = "0x188C32EF0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public IReadOnlyList<Task> BCMHTKJGIFG
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8C32D70", Offset = "0x8C31770", VA = "0x188C32D70")]
			public void Add(AssetExport taskKey, Task newTask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8C32F30", Offset = "0x8C31930", VA = "0x188C32F30")]
			public bool Remove(Task task, [Out] AssetExport key)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8C33060", Offset = "0x8C31A60", VA = "0x188C33060")]
			public FFCQSWYMOJP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private struct AssetExport : IEquatable<AssetExport>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly AssetType AssetType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly string AssetBlobName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly ExportPath ExportPath;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly bool GroupExportByAssetType;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8C31BD0", Offset = "0x8C305D0", VA = "0x188C31BD0")]
			public AssetExport(AssetType assetType, string assetBlobName, ExportPath exportPath, bool groupExportByAssetType = true)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8C319C0", Offset = "0x8C303C0", VA = "0x188C319C0", Slot = "4")]
			public bool Equals(AssetExport other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8C31A90", Offset = "0x8C30490", VA = "0x188C31A90", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8C31B40", Offset = "0x8C30540", VA = "0x188C31B40", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class DPSXTTGDTBT
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			private struct <<FetchAndWriteImage>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public DPSXTTGDTBT <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public CancellationToken ct;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x8C42980", Offset = "0x8C41380", VA = "0x188C42980", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x8C42B80", Offset = "0x8C41580", VA = "0x188C42B80", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public TZOLTYMUIVH PNDHLYVBPAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public AssetExport HJYAWAHWFVK;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public DPSXTTGDTBT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8C31EE0", Offset = "0x8C308E0", VA = "0x188C31EE0")]
			[AsyncStateMachine(typeof(<<FetchAndWriteImage>b__0>d))]
			internal Task<byte[]> YRBKBIPMPHN(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class QLDETKWUZQC
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private struct <<FetchAndWriteLegacyAudio>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public QLDETKWUZQC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public CancellationToken ct;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x8C42BF0", Offset = "0x8C415F0", VA = "0x188C42BF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x8C42DF0", Offset = "0x8C417F0", VA = "0x188C42DF0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public TZOLTYMUIVH PNDHLYVBPAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public AssetExport HJYAWAHWFVK;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public QLDETKWUZQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8C37EE0", Offset = "0x8C368E0", VA = "0x188C37EE0")]
			[AsyncStateMachine(typeof(<<FetchAndWriteLegacyAudio>b__0>d))]
			internal Task<byte[]> LRBGYSIOVAF(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class DMEPAFIWFSD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			private struct <<FetchAndWriteLegacyHolotar>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public DMEPAFIWFSD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public CancellationToken ct;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x8C42E60", Offset = "0x8C41860", VA = "0x188C42E60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x8C43060", Offset = "0x8C41A60", VA = "0x188C43060", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public TZOLTYMUIVH PNDHLYVBPAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public AssetExport HJYAWAHWFVK;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public DMEPAFIWFSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8C31DD0", Offset = "0x8C307D0", VA = "0x188C31DD0")]
			[AsyncStateMachine(typeof(<<FetchAndWriteLegacyHolotar>b__0>d))]
			internal Task<byte[]> SLITAQKRAKO(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class GYKQTNXGTKA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			private struct <<FetchAndWriteCV2Audio>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public GYKQTNXGTKA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				public CancellationToken ct;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x8C424A0", Offset = "0x8C40EA0", VA = "0x188C424A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x8C426A0", Offset = "0x8C410A0", VA = "0x188C426A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public TZOLTYMUIVH PNDHLYVBPAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AssetExport HJYAWAHWFVK;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public GYKQTNXGTKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8C339A0", Offset = "0x8C323A0", VA = "0x188C339A0")]
			[AsyncStateMachine(typeof(<<FetchAndWriteCV2Audio>b__0>d))]
			internal Task<byte[]> LWHQQURWPWT(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class LRWMZSOUZIR
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			private struct <<FetchAndWriteCV2Holotar>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				public LRWMZSOUZIR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public CancellationToken ct;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400003F")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x8C42710", Offset = "0x8C41110", VA = "0x188C42710", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x8C42910", Offset = "0x8C41310", VA = "0x188C42910", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public TZOLTYMUIVH PNDHLYVBPAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public AssetExport HJYAWAHWFVK;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public LRWMZSOUZIR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8C34460", Offset = "0x8C32E60", VA = "0x188C34460")]
			[AsyncStateMachine(typeof(<<FetchAndWriteCV2Holotar>b__0>d))]
			internal Task<byte[]> EUHIWVXVNZW(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class YSXXGNAWFKS
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			private struct <<FetchAndWriteMeshGen>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000042")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000043")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000044")]
				public YSXXGNAWFKS <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000045")]
				public CancellationToken ct;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000046")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x8C430D0", Offset = "0x8C41AD0", VA = "0x188C430D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x8C432D0", Offset = "0x8C41CD0", VA = "0x188C432D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public TZOLTYMUIVH PNDHLYVBPAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public AssetExport HJYAWAHWFVK;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public YSXXGNAWFKS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8C4B080", Offset = "0x8C49A80", VA = "0x188C4B080")]
			[AsyncStateMachine(typeof(<<FetchAndWriteMeshGen>b__0>d))]
			internal Task<byte[]> FTZXDILFXVZ(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class LOIEGERNLZB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			private struct <<FetchAndWriteSuperRoomData>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public LOIEGERNLZB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public CancellationToken ct;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x8C43340", Offset = "0x8C41D40", VA = "0x188C43340", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x8C43540", Offset = "0x8C41F40", VA = "0x188C43540", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public TZOLTYMUIVH PNDHLYVBPAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AssetExport HJYAWAHWFVK;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public LOIEGERNLZB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8C34350", Offset = "0x8C32D50", VA = "0x188C34350")]
			[AsyncStateMachine(typeof(<<FetchAndWriteSuperRoomData>b__0>d))]
			internal Task<byte[]> CHCOUOLGGZG(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class ZMZGDOYHPIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public HHJKAHBJTBC.WMBBZOXZHWM WLUWWTLSBQX;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public ZMZGDOYHPIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8C4B6B0", Offset = "0x8C4A0B0", VA = "0x188C4B6B0")]
			internal JHHKPCTWYYR OUSHMKZJRTL(IGrouping<AssetType, AssetExport> a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private struct <BatchProcessAssetExports>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public RWDDBETBFKO progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public IReadOnlyList<AssetExport> assetExportsToProcess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public BatchProcessTaskFactory taskFactory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public TZOLTYMUIVH client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public WFAPAQCSIZF dataExportOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public string progressLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private HHJKAHBJTBC.RAQCOSSALBQ<JHHKPCTWYYR> <simple>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int <totalCount>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private int <completedCount>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private FFCQSWYMOJP <inProgressTasks>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private List<AssetExport> <modifiableList>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private AssetExport <taskKey>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private TaskAwaiter<Task> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private object <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private int <>7__wrap8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8C385F0", Offset = "0x8C36FF0", VA = "0x188C385F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8C39CA0", Offset = "0x8C386A0", VA = "0x188C39CA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private struct <FetchAndWriteAllAssets>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public NJCXGDZTOSF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public RWDDBETBFKO progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public TZOLTYMUIVH client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public WFAPAQCSIZF dataExportOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private ZMZGDOYHPIH <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private List<IGrouping<AssetType, AssetExport>> <groups>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private JHHKPCTWYYR[] <stepProgressables>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private int <index>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private JHHKPCTWYYR <stepProgress>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private IGrouping<AssetType, AssetExport> <trackedAssetGroup>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8C3D040", Offset = "0x8C3BA40", VA = "0x188C3D040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8C3DFE0", Offset = "0x8C3C9E0", VA = "0x188C3DFE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private struct <FetchAndWriteCV2Audio>d__15 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public TZOLTYMUIVH client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AssetExport assetExport;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private GYKQTNXGTKA <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public WFAPAQCSIZF dataExportOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ReadOnlySequence<byte> <blobDataBytes>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8C3E040", Offset = "0x8C3CA40", VA = "0x188C3E040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8C3E7F0", Offset = "0x8C3D1F0", VA = "0x188C3E7F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private struct <FetchAndWriteCV2Holotar>d__16 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public TZOLTYMUIVH client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public AssetExport assetExport;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private LRWMZSOUZIR <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public WFAPAQCSIZF dataExportOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private ReadOnlySequence<byte> <blobDataBytes>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8C3E850", Offset = "0x8C3D250", VA = "0x188C3E850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8C3F000", Offset = "0x8C3DA00", VA = "0x188C3F000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private struct <FetchAndWriteImage>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public TZOLTYMUIVH client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public AssetExport assetExport;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private DPSXTTGDTBT <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8C3F060", Offset = "0x8C3DA60", VA = "0x188C3F060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8C3F670", Offset = "0x8C3E070", VA = "0x188C3F670", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <FetchAndWriteLegacyAudio>d__13 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public TZOLTYMUIVH client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public AssetExport assetExport;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private QLDETKWUZQC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public WFAPAQCSIZF dataExportOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private ReadOnlySequence<byte> <blobDataBytes>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8C3F6D0", Offset = "0x8C3E0D0", VA = "0x188C3F6D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8C3FE80", Offset = "0x8C3E880", VA = "0x188C3FE80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private struct <FetchAndWriteLegacyHolotar>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public TZOLTYMUIVH client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public AssetExport assetExport;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private DMEPAFIWFSD <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public WFAPAQCSIZF dataExportOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private ReadOnlySequence<byte> <blobDataBytes>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8C3FEE0", Offset = "0x8C3E8E0", VA = "0x188C3FEE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8C40690", Offset = "0x8C3F090", VA = "0x188C40690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <FetchAndWriteMeshGen>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public TZOLTYMUIVH client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public AssetExport assetExport;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private YSXXGNAWFKS <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8C406F0", Offset = "0x8C3F0F0", VA = "0x188C406F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8C40BF0", Offset = "0x8C3F5F0", VA = "0x188C40BF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private struct <FetchAndWriteSuperRoomData>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public TZOLTYMUIVH client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public AssetExport assetExport;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public WFAPAQCSIZF dataExportOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private LOIEGERNLZB <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public NJCXGDZTOSF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private ReadOnlySequence<byte> <rawBytes>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private SuperRoomData <superRoomData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8C40C50", Offset = "0x8C3F650", VA = "0x188C40C50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8C41780", Offset = "0x8C40180", VA = "0x188C41780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <WrapFetchTask>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public AsyncTaskMethodBuilder<ReadOnlySequence<byte>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public string assetName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public Func<CancellationToken, Task<byte[]>> taskFactory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private ReadOnlySequence<byte> <byteSequence>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private TaskAwaiter<byte[]> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8C43620", Offset = "0x8C42020", VA = "0x188C43620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8C43D00", Offset = "0x8C42700", VA = "0x188C43D00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly HashSet<AssetExport> CMBMYALFYXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Queue<AssetExport> PZUBTLEVXMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool BSHQWSIJRPZ;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C358E0", Offset = "0x8C342E0", VA = "0x188C358E0")]
		public void VBQMTTHIUXY(AssetType a, string b, ExportPath c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8C35220", Offset = "0x8C33C20", VA = "0x188C35220")]
		[AsyncStateMachine(typeof(<FetchAndWriteAllAssets>d__5))]
		public Task QCKDTADQSVG(TZOLTYMUIVH a, ExecutionArgs b, RWDDBETBFKO c, WFAPAQCSIZF d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8C35D00", Offset = "0x8C34700", VA = "0x188C35D00")]
		private void XQCLXHSNMFE(AssetExport a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8C35810", Offset = "0x8C34210", VA = "0x188C35810")]
		private int SSNMTGFSHNP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C34A50", Offset = "0x8C33450", VA = "0x188C34A50")]
		private int GBYETUSJHUY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8C34D70", Offset = "0x8C33770", VA = "0x188C34D70")]
		[AsyncStateMachine(typeof(<BatchProcessAssetExports>d__11))]
		private static Task LUVDGYIJEFK(TZOLTYMUIVH a, ExecutionArgs b, IReadOnlyList<AssetExport> c, BatchProcessTaskFactory d, WFAPAQCSIZF e, RWDDBETBFKO f, string g, CancellationToken h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8C34C00", Offset = "0x8C33600", VA = "0x188C34C00")]
		[AsyncStateMachine(typeof(<FetchAndWriteImage>d__12))]
		private Task LFFEZFKOQXN(TZOLTYMUIVH a, ExecutionArgs b, AssetExport c, WFAPAQCSIZF d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8C353A0", Offset = "0x8C33DA0", VA = "0x188C353A0")]
		[AsyncStateMachine(typeof(<FetchAndWriteLegacyAudio>d__13))]
		private Task RLBQBSCWYEJ(TZOLTYMUIVH a, ExecutionArgs b, AssetExport c, WFAPAQCSIZF d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C35A10", Offset = "0x8C34410", VA = "0x188C35A10")]
		[AsyncStateMachine(typeof(<FetchAndWriteLegacyHolotar>d__14))]
		private Task WUPOTXYJUHK(TZOLTYMUIVH a, ExecutionArgs b, AssetExport c, WFAPAQCSIZF d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8C350A0", Offset = "0x8C33AA0", VA = "0x188C350A0")]
		[AsyncStateMachine(typeof(<FetchAndWriteCV2Audio>d__15))]
		private Task OQFPEUWRNGX(TZOLTYMUIVH a, ExecutionArgs b, AssetExport c, WFAPAQCSIZF d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8C35690", Offset = "0x8C34090", VA = "0x188C35690")]
		[AsyncStateMachine(typeof(<FetchAndWriteCV2Holotar>d__16))]
		private Task SEWPIMCVFIC(TZOLTYMUIVH a, ExecutionArgs b, AssetExport c, WFAPAQCSIZF d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8C35B90", Offset = "0x8C34590", VA = "0x188C35B90")]
		[AsyncStateMachine(typeof(<FetchAndWriteMeshGen>d__17))]
		private Task WYQDASBYYRZ(TZOLTYMUIVH a, ExecutionArgs b, AssetExport c, WFAPAQCSIZF d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C34F10", Offset = "0x8C33910", VA = "0x188C34F10")]
		[AsyncStateMachine(typeof(<FetchAndWriteSuperRoomData>d__18))]
		private Task NFWCCHYPJCK(TZOLTYMUIVH a, ExecutionArgs b, AssetExport c, WFAPAQCSIZF d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8C35520", Offset = "0x8C33F20", VA = "0x188C35520")]
		[AsyncStateMachine(typeof(<WrapFetchTask>d__19))]
		private static Task<ReadOnlySequence<byte>> ROZYXSSGULN(ExecutionArgs a, Func<CancellationToken, Task<byte[]>> b, string c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8C35E20", Offset = "0x8C34820", VA = "0x188C35E20")]
		public NJCXGDZTOSF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Flags]
	public enum AvatarExportFormat : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Raw = 1,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		TwoDimensions = 2,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		ThreeDimensions = 4,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		All = 7
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class CTDHNZMKGLE<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public readonly int ZLDCSEVTDUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly string[] CADINCQDFYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly HashSet<a> OFOYCZQFWDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly List<string[]> VPZGNMZPOHF;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int AGNSAISSRJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5035C10", Offset = "0x5034610", VA = "0x185035C10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5036640", Offset = "0x5035040", VA = "0x185036640")]
		public CTDHNZMKGLE(params string[] columnHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5036330", Offset = "0x5034D30", VA = "0x185036330")]
		public void QSIOEDCXDPR(a a, params string[] row)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5035E00", Offset = "0x5034800", VA = "0x185035E00")]
		public string JHJZSNCKSTO(string a = ",")
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public abstract class KKHNNDAADSU<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class DPSXTTGDTBT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public object IYZKWFDLPDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public (float progress, string message)? VXWLOKXFCDK;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public DPSXTTGDTBT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x53C1780", Offset = "0x53C0180", VA = "0x1853C1780")]
			internal void KRJQXTACNZB(float a, string b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class QLDETKWUZQC
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private struct <<Execute>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public AsyncTaskMethodBuilder<bool> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				public QLDETKWUZQC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x41CDFC0", Offset = "0x41CC9C0", VA = "0x1841CDFC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x41CE250", Offset = "0x41CCC50", VA = "0x1841CE250", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			private struct <<Execute>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public AsyncTaskMethodBuilder<bool> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public QLDETKWUZQC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x41CE2C0", Offset = "0x41CCCC0", VA = "0x1841CE2C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x41CE7B0", Offset = "0x41CD1B0", VA = "0x1841CE7B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public KKHNNDAADSU<a> IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public CancellationToken PWKBEQSRYAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public JHHKPCTWYYR EZEIQEKGKPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public DirectoryInfo JSQOREWJSYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public FileInfo TKWUMWXKEFY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public DirectoryInfo HELJZLNZQLW;

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public QLDETKWUZQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x76FC7D0", Offset = "0x76FB1D0", VA = "0x1876FC7D0")]
			[AsyncStateMachine(typeof(KKHNNDAADSU<>.QLDETKWUZQC.<<Execute>b__0>d))]
			internal Task<bool> MHIEOPIAZGN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x76FC5D0", Offset = "0x76FAFD0", VA = "0x1876FC5D0")]
			[AsyncStateMachine(typeof(KKHNNDAADSU<>.QLDETKWUZQC.<<Execute>b__1>d))]
			internal Task<bool> MHCXRIODPVE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class QLILQRQSJBL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000030")]
			private struct <<Execute>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public AsyncTaskMethodBuilder<bool> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				public QLILQRQSJBL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x41CEB30", Offset = "0x41CD530", VA = "0x1841CEB30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x41CEDE0", Offset = "0x41CD7E0", VA = "0x1841CEDE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public NJCXGDZTOSF WBZGESTOQYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public ExecutionArgs PDRMJUBYVAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public QLDETKWUZQC IYWFXXOWUJJ;

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public QLILQRQSJBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x76FCDA0", Offset = "0x76FB7A0", VA = "0x1876FCDA0")]
			[AsyncStateMachine(typeof(KKHNNDAADSU<>.QLILQRQSJBL.<<Execute>b__2>d))]
			internal Task<bool> MGXQUBUGGJV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class JLGJIUGGAQO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000032")]
			private struct <<MigrateRoomDoorDeprecatedIdsAsync>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public AsyncTaskMethodBuilder<(long roomId, string name)> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public JLGJIUGGAQO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				public long roomId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private TaskAwaiter<RoomDetailsDTO> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				private TaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x41D7540", Offset = "0x41D5F40", VA = "0x1841D7540", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x41D7F40", Offset = "0x41D6940", VA = "0x1841D7F40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public KKHNNDAADSU<a> IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public CancellationToken PWKBEQSRYAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public ExecutionArgs PDRMJUBYVAN;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public JLGJIUGGAQO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x66C56B0", Offset = "0x66C40B0", VA = "0x1866C56B0")]
			[AsyncStateMachine(typeof(KKHNNDAADSU<>.JLGJIUGGAQO.<<MigrateRoomDoorDeprecatedIdsAsync>b__1>d))]
			internal Task<(long, string)> UQWLGKBOYXS(long a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class UEUIWOPVNUY
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000034")]
			private struct <<ProcessCv2RootGraphData>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public AsyncTaskMethodBuilder<bool> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public UEUIWOPVNUY <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x41E2160", Offset = "0x41E0B60", VA = "0x1841E2160", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x41E23D0", Offset = "0x41E0DD0", VA = "0x1841E23D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public KKHNNDAADSU<a> IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public ExecutionArgs PDRMJUBYVAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public NOJIAPKTUHF UHLFMBQCXLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public DirectoryInfo LNYSIPSYYVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public CancellationToken PWKBEQSRYAS;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public UEUIWOPVNUY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7DF82E0", Offset = "0x7DF6CE0", VA = "0x187DF82E0")]
			[AsyncStateMachine(typeof(KKHNNDAADSU<>.UEUIWOPVNUY.<<ProcessCv2RootGraphData>b__0>d))]
			internal Task<bool> PICUEUDZMCC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class QBHNKVVMFQX
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000036")]
			private struct <<ProcessPersistenceViews>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public AsyncTaskMethodBuilder<IEnumerable<long>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public QBHNKVVMFQX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				private TaskAwaiter<IEnumerable<long>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x41E7700", Offset = "0x41E6100", VA = "0x1841E7700", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x41E7A20", Offset = "0x41E6420", VA = "0x1841E7A20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public KKHNNDAADSU<a> IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public ExecutionArgs PDRMJUBYVAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public IReadOnlyList<TEAIRTFLUOM> EYGJNPXYCSN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public DirectoryInfo ZVSLRCAWWJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public RWDDBETBFKO QPMNPOBWFAV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public CancellationToken PWKBEQSRYAS;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public QBHNKVVMFQX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x76F5420", Offset = "0x76F3E20", VA = "0x1876F5420")]
			[AsyncStateMachine(typeof(KKHNNDAADSU<>.QBHNKVVMFQX.<<ProcessPersistenceViews>b__0>d))]
			internal Task<IEnumerable<long>> TNXHWSMWBFQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class LEHILDGQMIQ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000038")]
			private struct <<ProcessPersistenceViewsInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public LEHILDGQMIQ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public (TEAIRTFLUOM[] shapePvs, RWDDBETBFKO prog, CancellationToken ct) a;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				private LEMPIKANVTZ <>8__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				private ExportPath <exportPath>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				private QAKQIYTEUES <dependencies>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				private YIOJPLAXMNH.ProfileSession <_profile>5__4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				private TaskAwaiter<ModelRoot> <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012A")]
				private TaskAwaiter<FileInfo> <>u__3;

				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x41E5FD0", Offset = "0x41E49D0", VA = "0x1841E5FD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x41E6F80", Offset = "0x41E5980", VA = "0x1841E6F80", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public DirectoryInfo ZVSLRCAWWJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public ExecutionArgs PDRMJUBYVAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public CancellationToken PWKBEQSRYAS;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public LEHILDGQMIQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6920D40", Offset = "0x691F740", VA = "0x186920D40")]
			[AsyncStateMachine(typeof(KKHNNDAADSU<>.LEHILDGQMIQ.<<ProcessPersistenceViewsInternal>b__1>d))]
			internal Task<FileInfo> OTZYXOTJUYK((TEAIRTFLUOM[] shapePvs, RWDDBETBFKO prog, CancellationToken ct) a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class LEMPIKANVTZ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200003A")]
			private struct <<ProcessPersistenceViewsInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012E")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				public LEMPIKANVTZ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public Stream stream;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x41E71B0", Offset = "0x41E5BB0", VA = "0x1841E71B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x41E7340", Offset = "0x41E5D40", VA = "0x1841E7340", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public ModelRoot TVUEKFUNIOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public HHJKAHBJTBC.RAQCOSSALBQ<JHHKPCTWYYR> ZOJMZFIPYNU;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public LEMPIKANVTZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x6921F20", Offset = "0x6920920", VA = "0x186921F20")]
			[AsyncStateMachine(typeof(KKHNNDAADSU<>.LEMPIKANVTZ.<<ProcessPersistenceViewsInternal>b__2>d))]
			internal Task OTUSAHZMLNB(Stream a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class LHVRERDXZSG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200003C")]
			private struct <<ProcessOMData>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				public AsyncTaskMethodBuilder<IEnumerable<long>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013A")]
				public LHVRERDXZSG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013B")]
				private TaskAwaiter<IEnumerable<long>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x41E4950", Offset = "0x41E3350", VA = "0x1841E4950", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0x41E4F00", Offset = "0x41E3900", VA = "0x1841E4F00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public KKHNNDAADSU<a> IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public ExecutionArgs PDRMJUBYVAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public ByteString BRMSDMBMQHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public DirectoryInfo ZVSLRCAWWJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public RWDDBETBFKO QPMNPOBWFAV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public CancellationToken PWKBEQSRYAS;

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public LHVRERDXZSG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x69286D0", Offset = "0x69270D0", VA = "0x1869286D0")]
			[AsyncStateMachine(typeof(KKHNNDAADSU<>.LHVRERDXZSG.<<ProcessOMData>b__0>d))]
			internal Task<IEnumerable<long>> FDMOUOESIYH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class HZDYEWMUZJZ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200003E")]
			private struct <<ProcessOMDataInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				public HZDYEWMUZJZ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				private HYYRHPSXPYQ <>8__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				private ExportPath <exportPath>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				private QAKQIYTEUES <dependencies>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				private YIOJPLAXMNH.ProfileSession <_profile>5__4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400014D")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400014E")]
				private TaskAwaiter<ModelRoot> <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400014F")]
				private TaskAwaiter<FileInfo> <>u__3;

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x41E24B0", Offset = "0x41E0EB0", VA = "0x1841E24B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0x41E4460", Offset = "0x41E2E60", VA = "0x1841E4460", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public List<string> EXWKTBMMYUT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public HashSet<long> MBPVLVAUMBX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public DirectoryInfo ZVSLRCAWWJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public RWDDBETBFKO QPMNPOBWFAV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public ExecutionArgs PDRMJUBYVAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public List<ObjectLocalId> YADTSSZIYOV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Dictionary<ObjectLocalId, OMShape> NAQERDAHFRQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public CancellationToken PWKBEQSRYAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public TEAIRTFLUOM[] ZIXYEPYIDOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public HMDHSOJSCFJ[] LGBTLAQQTHZ;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public HZDYEWMUZJZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x64DF150", Offset = "0x64DDB50", VA = "0x1864DF150")]
			internal void OASTTGRBSQY(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x64DF200", Offset = "0x64DDC00", VA = "0x1864DF200")]
			internal void OAYAQNKZCCH(long a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x64DF3E0", Offset = "0x64DDDE0", VA = "0x1864DF3E0")]
			[AsyncStateMachine(typeof(KKHNNDAADSU<>.HZDYEWMUZJZ.<<ProcessOMDataInternal>b__5>d))]
			internal Task<FileInfo> OBTCFOMONVR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class HYYRHPSXPYQ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000040")]
			private struct <<ProcessOMDataInternal>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000152")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000153")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000154")]
				public HYYRHPSXPYQ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000155")]
				public Stream stream;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000156")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0x41E4540", Offset = "0x41E2F40", VA = "0x1841E4540", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0x41E4890", Offset = "0x41E3290", VA = "0x1841E4890", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public ModelRoot TVUEKFUNIOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public HHJKAHBJTBC.RAQCOSSALBQ<JHHKPCTWYYR> ZOJMZFIPYNU;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public HYYRHPSXPYQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x64DEEA0", Offset = "0x64DD8A0", VA = "0x1864DEEA0")]
			[AsyncStateMachine(typeof(KKHNNDAADSU<>.HYYRHPSXPYQ.<<ProcessOMDataInternal>b__6>d))]
			internal Task OBYJCVGLXHA(Stream a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private struct <Execute>d__13 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			public AsyncTaskMethodBuilder<ExportResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public KKHNNDAADSU<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public RWDDBETBFKO mainThreadProgressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private QLILQRQSJBL <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private QLDETKWUZQC <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			private ISMRVFIVZRA <resultBuilder>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			private CancellationTokenSource <progressDispatchCts>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			private HHJKAHBJTBC.WMBBZOXZHWM <myProgress>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			private JHHKPCTWYYR <internalProgress>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			private JHHKPCTWYYR <finalPrepProgress>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			private FileInfo <logFileInfo>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			private FileStream <logFileStream>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			private object <>7__wrap8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			private int <>7__wrap9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			private StreamWriter <logTextWriter>5__11;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			private object <>7__wrap11;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			private int <>7__wrap12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			private KDLVQAUWETD <logWriter>5__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private MSMECEABMOB <exportFileWriter>5__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			private object <>7__wrap15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			private int <>7__wrap16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			private TaskAwaiter<bool> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			private TaskAwaiter<string> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			private ValueTaskAwaiter <>u__5;

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x666E3A0", Offset = "0x666CDA0", VA = "0x18666E3A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x66767B0", Offset = "0x66751B0", VA = "0x1866767B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct <MigrateRoomDoorDeprecatedIdsAsync>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public KKHNNDAADSU<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public IReadOnlyList<TEAIRTFLUOM> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			private List<(TEAIRTFLUOM view, long roomId)> <deprecatedDoors>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			private Dictionary<long, string> <resolvedNames>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			private TaskAwaiter<(long roomId, string name)[]> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6B00DC0", Offset = "0x6AFF7C0", VA = "0x186B00DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6B01930", Offset = "0x6B00330", VA = "0x186B01930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct <ProcessCv2RootGraphData>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public KKHNNDAADSU<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public NOJIAPKTUHF circuitGraphData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public DirectoryInfo targetDir;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6B15160", Offset = "0x6B13B60", VA = "0x186B15160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6B158B0", Offset = "0x6B142B0", VA = "0x186B158B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct <ProcessCv2RootGraphDataInternal>d__29 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public NOJIAPKTUHF circuitGraphData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public DirectoryInfo targetDir;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public KKHNNDAADSU<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private CTDHNZMKGLE<Guid> <circuitNodeIdCollector>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private int <index>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6B14420", Offset = "0x6B12E20", VA = "0x186B14420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6B15100", Offset = "0x6B13B00", VA = "0x186B15100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct <ProcessOMData>d__35 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public AsyncTaskMethodBuilder<IEnumerable<long>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public KKHNNDAADSU<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public ByteString omData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public RWDDBETBFKO progressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			private TaskAwaiter<IEnumerable<long>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6B20E90", Offset = "0x6B1F890", VA = "0x186B20E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6B21220", Offset = "0x6B1FC20", VA = "0x186B21220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct <ProcessOMDataInternal>d__36 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public AsyncTaskMethodBuilder<IEnumerable<long>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public RWDDBETBFKO progressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public ByteString omData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			private HZDYEWMUZJZ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public KKHNNDAADSU<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			private JGQLCFRSMHH <services>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private RecRoom.ObjectModel.ObjectModel <objectModel>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private RRSceneLoadOperationSubgraph <op>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private NativeObjectLocalIdArray <allObjects>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private HashSet<ObjectLocalId> <neededObjects>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private Dictionary<ObjectLocalId, ObjectLocalId> <parentMap>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			private object <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			private int <index>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private ObjectLocalId <obj>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			private OMShape <omShape>5__11;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			private Dictionary<ObjectLocalId, OMShape>.KeyCollection.Enumerator <>7__wrap11;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6B15910", Offset = "0x6B14310", VA = "0x186B15910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6B209E0", Offset = "0x6B1F3E0", VA = "0x186B209E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct <ProcessPersistenceViews>d__32 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public AsyncTaskMethodBuilder<IEnumerable<long>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public KKHNNDAADSU<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public IReadOnlyList<TEAIRTFLUOM> persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public RWDDBETBFKO progressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			private TaskAwaiter<IEnumerable<long>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6BBD8C0", Offset = "0x6BBC2C0", VA = "0x186BBD8C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6BBE090", Offset = "0x6BBCA90", VA = "0x186BBE090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct <ProcessPersistenceViewsInternal>d__33 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public AsyncTaskMethodBuilder<IEnumerable<long>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public IReadOnlyList<TEAIRTFLUOM> persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public RWDDBETBFKO progressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			private LEHILDGQMIQ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public KKHNNDAADSU<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private HashSet<long> <inventionSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private HHJKAHBJTBC.WMBBZOXZHWM <myProgress>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private JHHKPCTWYYR <shapeProgress>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			private object <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			private int <>7__wrap5;

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6BBA070", Offset = "0x6BB8A70", VA = "0x186BBA070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6BBD7E0", Offset = "0x6BBC1E0", VA = "0x186BBD7E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct <RunProgressDispatchTask>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public RWDDBETBFKO mainThreadProgressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public JEZHIXZZMWO multiThreadProgressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private DPSXTTGDTBT <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6C65280", Offset = "0x6C63C80", VA = "0x186C65280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x6C65C70", Offset = "0x6C64670", VA = "0x186C65C70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct <WriteProtobufDefinitionsIfNecessary>d__15 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public DirectoryInfo exportDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			private ExportPath <zipExportPath>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			private FileInfo <zipTargetFile>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			private byte[] <sourceHash>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			private string <sourceString>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			private string <destString>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			private TextAsset <protobufDefinitionsAsset>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			private IDisposable <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x729AFD0", Offset = "0x72999D0", VA = "0x18729AFD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x729D5E0", Offset = "0x729BFE0", VA = "0x18729D5E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct <ZipOutput>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public FileInfo archiveFileInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public DirectoryInfo roomDirInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			private int <attempts>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			private ZipArchive <zipfile>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			private IEnumerator<string> <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			private Stream <entryStream>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			private FileStream <fileStream>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			private object <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			private int <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			private object <>7__wrap8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			private int <>7__wrap9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			private ValueTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x72B01B0", Offset = "0x72AEBB0", VA = "0x1872B01B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x72B2C50", Offset = "0x72B1650", VA = "0x1872B2C50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		protected readonly WFAPAQCSIZF IZJAMLFWFRU;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public static readonly Guid PZFZDUBQCIF;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public static readonly Guid YCFDAYZJJUH;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly Guid VBQLWHOMSHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		protected readonly TZOLTYMUIVH VCQXVYOFJOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		protected readonly YLTZGBWSOOM XHZQKTTNYND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		protected readonly HJBLJFFMFID.TVWXLXTXIIP UMDBEIMEMYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly a HFGDHAVXFYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		protected readonly WTSNVZGDFSC.FQBZXGVILAS FQBZXGVILAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		protected readonly WTSNVZGDFSC.FQBZXGVILAS XWJZRSJMQHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		protected readonly ExportItemTypes WITFGKLRKAL;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6802220", Offset = "0x6800C20", VA = "0x186802220")]
		protected KKHNNDAADSU(TZOLTYMUIVH a, YLTZGBWSOOM b, HJBLJFFMFID.TVWXLXTXIIP c, ExportItemTypes d, a e, WFAPAQCSIZF f, [Optional] WTSNVZGDFSC.FQBZXGVILAS g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x67FC2A0", Offset = "0x67FACA0", VA = "0x1867FC2A0")]
		[AsyncStateMachine(typeof(KKHNNDAADSU<>.<RunProgressDispatchTask>d__12))]
		private Task EQYDQIZQMZV(JEZHIXZZMWO a, RWDDBETBFKO b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x67FF620", Offset = "0x67FE020", VA = "0x1867FF620")]
		[AsyncStateMachine(typeof(KKHNNDAADSU<>.<Execute>d__13))]
		public Task<ExportResult> RYTZSVJESQN(RWDDBETBFKO a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x67FF1C0", Offset = "0x67FDBC0", VA = "0x1867FF1C0", Slot = "4")]
		protected virtual Task<string> QJGUASLROXP(ExecutionArgs a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x68009F0", Offset = "0x67FF3F0", VA = "0x1868009F0")]
		[AsyncStateMachine(typeof(KKHNNDAADSU<>.<WriteProtobufDefinitionsIfNecessary>d__15))]
		private Task XPEZIYEQRHE(DirectoryInfo a, ExecutionArgs b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x67FE8B0", Offset = "0x67FD2B0", VA = "0x1867FE8B0")]
		private static bool LOUBXIIFUTG(byte[] a, byte[] b, [Out] string c, [Out] string d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x67FF8A0", Offset = "0x67FE2A0", VA = "0x1867FF8A0")]
		private Task SFINBYQNGSN(DirectoryInfo a, DirectoryInfo b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x67FEF70", Offset = "0x67FD970", VA = "0x1867FEF70")]
		[AsyncStateMachine(typeof(KKHNNDAADSU<>.<ZipOutput>d__18))]
		private Task PWIVVOOOKPG(DirectoryInfo a, FileInfo b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract string SGBHDLFHLJD();

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract DirectoryInfo JSTSNJNBXDH(WTSNVZGDFSC.FQBZXGVILAS a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract Task FXQCSBQZMMQ(ExecutionArgs a, DirectoryInfo b, RWDDBETBFKO c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x67FEE20", Offset = "0x67FD820", VA = "0x1867FEE20")]
		[AsyncStateMachine(typeof(KKHNNDAADSU<>.<MigrateRoomDoorDeprecatedIdsAsync>d__22))]
		protected Task PREUPSWHDWP(ExecutionArgs a, IReadOnlyList<TEAIRTFLUOM> b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x67FC4E0", Offset = "0x67FAEE0", VA = "0x1867FC4E0")]
		private static bool GZZHVHOLEXX(DirectoryInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x67FC5B0", Offset = "0x67FAFB0", VA = "0x1867FC5B0")]
		private static bool GZZHVHOLEXX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6800C20", Offset = "0x67FF620", VA = "0x186800C20")]
		private DirectoryInfo YUTNVMVGUND(DirectoryInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x67FF480", Offset = "0x67FDE80", VA = "0x1867FF480")]
		private bool RDXUUAWQFCY([Out] DirectoryInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6800640", Offset = "0x67FF040", VA = "0x186800640")]
		public void WFGPNVXWWNB(DirectoryInfo a, string b, [Out] DirectoryInfo c, [Out] FileInfo d, [Out] DirectoryInfo e, [Optional] DateTime? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x67FFAC0", Offset = "0x67FE4C0", VA = "0x1867FFAC0")]
		[AsyncStateMachine(typeof(KKHNNDAADSU<>.<ProcessCv2RootGraphData>d__28))]
		protected Task TBSAZWPPFQQ(ExecutionArgs a, NOJIAPKTUHF? circuitGraphData, DirectoryInfo b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x67FEB60", Offset = "0x67FD560", VA = "0x1867FEB60")]
		[AsyncStateMachine(typeof(KKHNNDAADSU<>.<ProcessCv2RootGraphDataInternal>d__29))]
		private Task OFMEGLCJDDT(ExecutionArgs a, NOJIAPKTUHF? circuitGraphData, DirectoryInfo b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x67FD630", Offset = "0x67FC030", VA = "0x1867FD630")]
		private static void HJCABKIMPVY(NOJIAPKTUHF a, ExecutionArgs b, DirectoryInfo c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6800B20", Offset = "0x67FF520", VA = "0x186800B20")]
		private static string YCXBKOFEZLZ(GGDMHQWFZXD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x67FFD80", Offset = "0x67FE780", VA = "0x1867FFD80")]
		[AsyncStateMachine(typeof(KKHNNDAADSU<>.<ProcessPersistenceViews>d__32))]
		protected Task<IEnumerable<long>> TGSGMZCMTKE(ExecutionArgs a, IReadOnlyList<TEAIRTFLUOM> b, DirectoryInfo c, RWDDBETBFKO d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x67FBF40", Offset = "0x67FA940", VA = "0x1867FBF40")]
		[AsyncStateMachine(typeof(KKHNNDAADSU<>.<ProcessPersistenceViewsInternal>d__33))]
		private Task<IEnumerable<long>> EGYRRJEYULP(ExecutionArgs a, IReadOnlyList<TEAIRTFLUOM> b, DirectoryInfo c, RWDDBETBFKO d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6801270", Offset = "0x67FFC70", VA = "0x186801270")]
		private static Vector3 ZIQLYHAOOTH(IReadOnlyList<RRObjectSplinePoint> a, int b, bool c, bool d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x67FBC10", Offset = "0x67FA610", VA = "0x1867FBC10")]
		[AsyncStateMachine(typeof(KKHNNDAADSU<>.<ProcessOMData>d__35))]
		protected Task<IEnumerable<long>> BTHGTHWUNMP(ExecutionArgs a, ByteString b, DirectoryInfo c, RWDDBETBFKO d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x67FE410", Offset = "0x67FCE10", VA = "0x1867FE410")]
		[AsyncStateMachine(typeof(KKHNNDAADSU<>.<ProcessOMDataInternal>d__36))]
		private Task<IEnumerable<long>> KEWGWQBFGTM(ExecutionArgs a, ByteString b, DirectoryInfo c, RWDDBETBFKO d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x67FBAB0", Offset = "0x67FA4B0", VA = "0x1867FBAB0")]
		[CompilerGenerated]
		internal static bool AXSCKKGDQSN(string a, [Out] byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x68000B0", Offset = "0x67FEAB0", VA = "0x1868000B0")]
		[CompilerGenerated]
		internal static bool WECGRYYRTLQ(FileInfo a, [Out] byte[] b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class KDLVQAUWETD
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class FSNIBYIUCYG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			private bool ZIWJLCMIQDX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			private readonly KDLVQAUWETD TYJYJSBKFYX;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8C337E0", Offset = "0x8C321E0", VA = "0x188C337E0")]
			public FSNIBYIUCYG(KDLVQAUWETD a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8C337A0", Offset = "0x8C321A0", VA = "0x188C337A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct <WriteAsync>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public KDLVQAUWETD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public string text;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8C44940", Offset = "0x8C43340", VA = "0x188C44940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8C44D40", Offset = "0x8C43740", VA = "0x188C44D40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct <WriteErrorLineAsync>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public string line;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public KDLVQAUWETD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x8C47BA0", Offset = "0x8C465A0", VA = "0x188C47BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x8C47D60", Offset = "0x8C46760", VA = "0x188C47D60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct <WriteException>d__13 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public KDLVQAUWETD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			public Exception ex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			private string <header>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			private int <startingIndentAmt>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			private Queue<(int indent, Exception ex)> <exceptionQueue>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			private (int indent, Exception ex) <exceptionPair>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			private Exception <enqueuedEx>5__6;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8C47DC0", Offset = "0x8C467C0", VA = "0x188C47DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x8C48A10", Offset = "0x8C47410", VA = "0x188C48A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct <WriteLineAsync>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public KDLVQAUWETD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public string line;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x8C48F30", Offset = "0x8C47930", VA = "0x188C48F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x8C49330", Offset = "0x8C47D30", VA = "0x188C49330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private struct <WriteTextInternal>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			public KDLVQAUWETD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public bool appendNewLine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public string text;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x8C49390", Offset = "0x8C47D90", VA = "0x188C49390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x8C49770", Offset = "0x8C48170", VA = "0x188C49770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private readonly StreamWriter LDITDXKJNUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private int UXYSCPQSFSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private string TEMNVSOOCGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private bool DVUNDKXQMDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private readonly SemaphoreSlim CNBCGDMLCUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private readonly string[] WEEVPPSWGXY;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8C34210", Offset = "0x8C32C10", VA = "0x188C34210")]
		public KDLVQAUWETD(StreamWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8C33EB0", Offset = "0x8C328B0", VA = "0x188C33EB0")]
		[AsyncStateMachine(typeof(<WriteErrorLineAsync>d__9))]
		public Task UAUZFMVDLWJ(string a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8C33B50", Offset = "0x8C32550", VA = "0x188C33B50")]
		[AsyncStateMachine(typeof(<WriteLineAsync>d__10))]
		public Task IXVHUIZRKEV(string a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8C33FC0", Offset = "0x8C329C0", VA = "0x188C33FC0")]
		[AsyncStateMachine(typeof(<WriteAsync>d__11))]
		public Task VEAGXBGCUED(string a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8C33DA0", Offset = "0x8C327A0", VA = "0x188C33DA0")]
		[AsyncStateMachine(typeof(<WriteTextInternal>d__12))]
		private Task TDMBNLDBEXR(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8C340E0", Offset = "0x8C32AE0", VA = "0x188C340E0")]
		[AsyncStateMachine(typeof(<WriteException>d__13))]
		public Task VNHAXJSFULM(Exception a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8C33C70", Offset = "0x8C32670", VA = "0x188C33C70")]
		public IDisposable JDVHMKLLZUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8C33CF0", Offset = "0x8C326F0", VA = "0x188C33CF0")]
		public void PQLUQMLWWOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8C33D00", Offset = "0x8C32700", VA = "0x188C33D00")]
		public void RBDCWDDMIBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8C33D90", Offset = "0x8C32790", VA = "0x188C33D90")]
		private void ROIGZMZMHQT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8C33AB0", Offset = "0x8C324B0", VA = "0x188C33AB0")]
		private void DFUQYUUGDRK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8C33D10", Offset = "0x8C32710", VA = "0x188C33D10")]
		private string RIFKYNNSGZV(int a)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct DataExportOptions : WFAPAQCSIZF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[SerializeField]
		private ProtobufOutputFormat protobufOutputFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[SerializeField]
		private bool exportShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[SerializeField]
		private bool zipOutput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[SerializeField]
		private bool exportInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[SerializeField]
		private bool runLegacyMigrations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[SerializeField]
		private AvatarExportFormat avatarExportFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[SerializeField]
		private int avatarExportPoseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		[SerializeField]
		private bool pushFaceOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		[SerializeField]
		private bool isOwnedTrophyInvention;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static DataExportOptions AESEIRAUIMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8C32030", Offset = "0x8C30A30", VA = "0x188C32030")]
			get
			{
				return default(DataExportOptions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AvatarExportFormat VGOLHJFMUBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8BBA610", Offset = "0x8BB9010", VA = "0x188BBA610", Slot = "9")]
			get
			{
				return default(AvatarExportFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x8BBA630", Offset = "0x8BB9030", VA = "0x188BBA630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int UXMVZKYZXRS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xF55CA0", Offset = "0xF546A0", VA = "0x180F55CA0", Slot = "10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xF55CB0", Offset = "0xF546B0", VA = "0x180F55CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool HFZURXTFJYN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8C32060", Offset = "0x8C30A60", VA = "0x188C32060", Slot = "12")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8C32000", Offset = "0x8C30A00", VA = "0x188C32000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ProtobufOutputFormat VZLEZLSLXBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x10ADD60", Offset = "0x10AC760", VA = "0x1810ADD60", Slot = "4")]
			get
			{
				return default(ProtobufOutputFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x27239B0", Offset = "0x27223B0", VA = "0x1827239B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool QUBEDHLXZXE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1104020", Offset = "0x1102A20", VA = "0x181104020", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x1104050", Offset = "0x1102A50", VA = "0x181104050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PWIVVOOOKPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x1104030", Offset = "0x1102A30", VA = "0x181104030", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LHLBTFMOLEX
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x1104040", Offset = "0x1102A40", VA = "0x181104040", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x1104070", Offset = "0x1102A70", VA = "0x181104070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool TAJZFDLCBZP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x68FABB0", Offset = "0x68F95B0", VA = "0x1868FABB0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8BBA640", Offset = "0x8BB9040", VA = "0x188BBA640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool HKYYGRESCYF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8C32020", Offset = "0x8C30A20", VA = "0x188C32020")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8C32010", Offset = "0x8C30A10", VA = "0x188C32010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8C32070", Offset = "0x8C30A70", VA = "0x188C32070")]
		public DataExportOptions(ProtobufOutputFormat protobufOutputFormat, bool exportShapes = true, bool zipOutput = true, bool exportInventions = true, bool runLegacyMigrations = true, AvatarExportFormat avatarExportFormat = AvatarExportFormat.All, int avatarExportPoseIndex = -1, bool pushFaceOut = true, bool isOwnedTrophyInvention = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8C31FF0", Offset = "0x8C309F0", VA = "0x188C31FF0", Slot = "11")]
		public bool AHWVGPGBJOK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class WTSNVZGDFSC
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public class FQBZXGVILAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private readonly DirectoryInfo MBRIXMERFSD;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8C33300", Offset = "0x8C31D00", VA = "0x188C33300")]
			public static FQBZXGVILAS RBCCAMCKJQJ(DirectoryInfo a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8C331D0", Offset = "0x8C31BD0", VA = "0x188C331D0")]
			public static FQBZXGVILAS KPMVVBEMTCH(DirectoryInfo a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
			private FQBZXGVILAS(DirectoryInfo a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8C33740", Offset = "0x8C32140", VA = "0x188C33740")]
			public DirectoryInfo URCQBOFEWOI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8C33530", Offset = "0x8C31F30", VA = "0x188C33530")]
			public DirectoryInfo RQZCMIRVJXT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8C33690", Offset = "0x8C32090", VA = "0x188C33690")]
			public DirectoryInfo SSRGMGCYSGA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8C335E0", Offset = "0x8C31FE0", VA = "0x188C335E0")]
			public DirectoryInfo SGBBHACHWOO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8C33120", Offset = "0x8C31B20", VA = "0x188C33120")]
			public DirectoryInfo JEAHRQLRMRM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public static readonly FQBZXGVILAS CHFCIEZLBAU;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4AE10", Offset = "0x8C49810", VA = "0x188C4AE10")]
		public static DirectoryInfo QVMBZVVZSDR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8C4AD40", Offset = "0x8C49740", VA = "0x188C4AD40")]
		public static string ITHWQFTJPZS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A980", Offset = "0x8C49380", VA = "0x188C4A980")]
		public static DirectoryInfo FXCJFVNROLQ(DirectoryInfo a, string b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4AE90", Offset = "0x8C49890", VA = "0x188C4AE90")]
		public static DirectoryInfo VXXCAPDZQFU(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4ABE0", Offset = "0x8C495E0", VA = "0x188C4ABE0")]
		public static DirectoryInfo GIKNVECXPUO(DirectoryInfo a, string b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C4AB30", Offset = "0x8C49530", VA = "0x188C4AB30")]
		public static string GIKNVECXPUO(string a, bool b = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public readonly struct ExecutionArgs
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private struct <AddWarning>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			public ExecutionArgs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			public string warning;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000230")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8C383F0", Offset = "0x8C36DF0", VA = "0x188C383F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8C38590", Offset = "0x8C36F90", VA = "0x188C38590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private struct <AddWarningForException>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000231")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000232")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000233")]
			public ExecutionArgs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public string warning;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public Exception ex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8C37FF0", Offset = "0x8C369F0", VA = "0x188C37FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8C38390", Offset = "0x8C36D90", VA = "0x188C38390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public readonly NJCXGDZTOSF AssetCollector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public readonly MSMECEABMOB ExportFileWriter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public readonly KDLVQAUWETD LogWriter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public readonly ISMRVFIVZRA ResultBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public readonly HashSet<FileExportNote> FileExportNotes;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8C324C0", Offset = "0x8C30EC0", VA = "0x188C324C0")]
		public ExecutionArgs(NJCXGDZTOSF assetCollector, MSMECEABMOB exportFileWriter, KDLVQAUWETD logWriter, ISMRVFIVZRA resultBuilder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8C32200", Offset = "0x8C30C00", VA = "0x188C32200")]
		public void LGMQMUHJQFJ(FileInfo a, string b, [Optional] string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8C32370", Offset = "0x8C30D70", VA = "0x188C32370")]
		[AsyncStateMachine(typeof(<AddWarning>d__7))]
		public Task VHVLJUFZQNF(string a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8C320B0", Offset = "0x8C30AB0", VA = "0x188C320B0")]
		[AsyncStateMachine(typeof(<AddWarningForException>d__8))]
		public Task BCHLEVJXIED(string a, Exception b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class MSMECEABMOB
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public class OIGDXBHIJTX
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			[CompilerGenerated]
			private struct <MarkWroteToPath>d__6 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000241")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000242")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				public OIGDXBHIJTX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				public string filePath;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				public long elapsedMillis;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000247")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x8C417E0", Offset = "0x8C401E0", VA = "0x188C417E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x8C41BD0", Offset = "0x8C405D0", VA = "0x188C41BD0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private struct <WriteAllBytesInternal>d__13 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000248")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public OIGDXBHIJTX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				public FileInfo file;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public ReadOnlySequence<byte> bytes;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				private string <relativePath>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				private object <>7__wrap2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				private int <>7__wrap3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				private long <start>5__5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				private FileStream <stream>5__6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				private object <>7__wrap6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				private int <>7__wrap7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				private ReadOnlySequence<byte>.Enumerator <>7__wrap8;

				[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				private ValueTaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x8C43D70", Offset = "0x8C42770", VA = "0x188C43D70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x8C448D0", Offset = "0x8C432D0", VA = "0x188C448D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005D")]
			[CompilerGenerated]
			private struct <WriteAudio>d__16 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000258")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000259")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400025A")]
				public AudioStreamData audioStreamData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400025B")]
				public OIGDXBHIJTX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400025C")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400025D")]
				private float[] <samples>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400025E")]
				private string <filePath>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x400025F")]
				private string <relativePath>5__4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				private object <>7__wrap4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private int <>7__wrap5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				private long <start>5__7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				private FileStream <filestream>5__8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				private object <>7__wrap8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				private int <>7__wrap9;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				private ValueTaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0x8C467F0", Offset = "0x8C451F0", VA = "0x188C467F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x8C478A0", Offset = "0x8C462A0", VA = "0x188C478A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private struct <WriteAudioSamplesToStream>d__17 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000268")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000269")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400026A")]
				public float[] decodedSamples;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400026B")]
				public Stream filestream;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400026C")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				public int channels;

				[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
				[Cpp2IlInjected.Token(Token = "0x400026E")]
				public int sampleRate;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400026F")]
				private int <numSampleBytes>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000270")]
				private byte[] <sampleBytesRentedArray>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				private byte[] <riffBytes>5__4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				private byte[] <waveBytes>5__5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				private byte[] <fmtIdBytes>5__6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				private byte[] <dataIdBytes>5__7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000275")]
				private ValueTaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000276")]
				private TaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x8C44DA0", Offset = "0x8C437A0", VA = "0x188C44DA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000122")]
				[Cpp2IlInjected.Address(RVA = "0x8C46790", Offset = "0x8C45190", VA = "0x188C46790", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			[CompilerGenerated]
			private struct <WriteBytes>d__11 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000277")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000278")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000279")]
				public OIGDXBHIJTX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400027A")]
				public string extensionNoPeriod;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400027B")]
				public ReadOnlySequence<byte> bytes;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x400027C")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x400027D")]
				private TaskAwaiter<FileInfo> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x8C47900", Offset = "0x8C46300", VA = "0x188C47900", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0x8C47B30", Offset = "0x8C46530", VA = "0x188C47B30", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private struct <WriteImage>d__10 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400027E")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400027F")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000280")]
				public ReadOnlySequence<byte> imageBytes;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000281")]
				public OIGDXBHIJTX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000282")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000283")]
				private TaskAwaiter<FileInfo> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x8C48A70", Offset = "0x8C47470", VA = "0x188C48A70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x8C48EC0", Offset = "0x8C478C0", VA = "0x188C48EC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000061")]
			[CompilerGenerated]
			private struct <WriteProtobuf>d__14<T> : IAsyncStateMachine where T : IMessage<T>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000284")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000285")]
				public AsyncTaskMethodBuilder<IReadOnlyCollection<FileInfo>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000286")]
				public WFAPAQCSIZF dataExportOptions;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000287")]
				public OIGDXBHIJTX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000288")]
				public ReadOnlySequence<byte> protobufBytes;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000289")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public MessageParser<T> parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				private ProtobufOutputFormat <protobufOutputFormat>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028C")]
				private HashSet<FileInfo> <wroteToFiles>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028D")]
				private FileInfo <bytesFile>5__4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028E")]
				private TaskAwaiter<FileInfo> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028F")]
				private long <start>5__5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000290")]
				private TaskAwaiter <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000291")]
				private FileStream <filestream>5__6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000292")]
				private object <>7__wrap6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000293")]
				private int <>7__wrap7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000294")]
				private object <>7__wrap8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000295")]
				private int <>7__wrap9;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000296")]
				private ValueTaskAwaiter <>u__3;

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x729D6A0", Offset = "0x729C0A0", VA = "0x18729D6A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x729F450", Offset = "0x729DE50", VA = "0x18729F450", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private struct <WriteProtobuf>d__15<T> : IAsyncStateMachine where T : IMessage<T>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000297")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000298")]
				public AsyncTaskMethodBuilder<IReadOnlyCollection<FileInfo>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000299")]
				public WFAPAQCSIZF dataExportOptions;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400029A")]
				public OIGDXBHIJTX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400029B")]
				public ReadOnlySequence<byte> protobufBytes;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400029C")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400029D")]
				public T parsed;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400029E")]
				private ProtobufOutputFormat <protobufOutputFormat>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400029F")]
				private HashSet<FileInfo> <wroteToFiles>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A0")]
				private FileInfo <bytesFile>5__4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A1")]
				private TaskAwaiter<FileInfo> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A2")]
				private long <start>5__5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A3")]
				private TaskAwaiter <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A4")]
				private FileStream <filestream>5__6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A5")]
				private object <>7__wrap6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A6")]
				private int <>7__wrap7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A7")]
				private object <>7__wrap8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A8")]
				private int <>7__wrap9;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A9")]
				private ValueTaskAwaiter <>u__3;

				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x729F4C0", Offset = "0x729DEC0", VA = "0x18729F4C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x72A2230", Offset = "0x72A0C30", VA = "0x1872A2230", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private struct <WriteText>d__9 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002AA")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002AB")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002AC")]
				public OIGDXBHIJTX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40002AD")]
				public string extensionNoPeriod;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40002AE")]
				public string contents;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40002AF")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40002B0")]
				private FileInfo <outFile>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x40002B1")]
				private TaskAwaiter<FileInfo> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x8C497D0", Offset = "0x8C481D0", VA = "0x188C497D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x8C49AA0", Offset = "0x8C484A0", VA = "0x188C49AA0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private struct <WriteUtf8Json>d__8<TJson> : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002B2")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002B3")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002B4")]
				public OIGDXBHIJTX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002B5")]
				public TJson jsonObj;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002B6")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002B7")]
				private FileInfo <outFile>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002B8")]
				private TaskAwaiter<FileInfo> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x72A22A0", Offset = "0x72A0CA0", VA = "0x1872A22A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0x72A2EE0", Offset = "0x72A18E0", VA = "0x1872A2EE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private struct <WriteViaStreamAsync>d__12 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002B9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002BA")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002BB")]
				public OIGDXBHIJTX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40002BC")]
				public string extensionNoPeriod;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40002BD")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40002BE")]
				public Func<Stream, Task> writeAction;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40002BF")]
				private FileInfo <outFile>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x40002C0")]
				private string <relativePath>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x40002C1")]
				private object <>7__wrap3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x40002C2")]
				private int <>7__wrap4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x40002C3")]
				private long <start>5__6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x40002C4")]
				private FileStream <stream>5__7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x40002C5")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x40002C6")]
				private object <>7__wrap7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x40002C7")]
				private int <>7__wrap8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x40002C8")]
				private ValueTaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x8C49B10", Offset = "0x8C48510", VA = "0x188C49B10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0x8C4A550", Offset = "0x8C48F50", VA = "0x188C4A550", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			private readonly DirectoryInfo MKFALAUABIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			private readonly HashSet<string> FLSACVRPGRN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400023E")]
			private readonly ExportPath BSOJIYHQXTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400023F")]
			private readonly KDLVQAUWETD KSUZBUGNXDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000240")]
			private readonly Stopwatch EFOJWVHRAGJ;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8C36CF0", Offset = "0x8C356F0", VA = "0x188C36CF0")]
			public OIGDXBHIJTX(DirectoryInfo a, HashSet<string> b, ExportPath c, KDLVQAUWETD d, Stopwatch e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x8C35F60", Offset = "0x8C34960", VA = "0x188C35F60")]
			[AsyncStateMachine(typeof(<MarkWroteToPath>d__6))]
			private Task BKFVXODAVYW(string a, long b, CancellationToken c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8C368F0", Offset = "0x8C352F0", VA = "0x188C368F0")]
			private FileInfo XYYVQNOBQLY(ExportPath a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x4162180", Offset = "0x4160B80", VA = "0x184162180")]
			[AsyncStateMachine(typeof(<WriteUtf8Json>d__8<>))]
			public Task<FileInfo> GDWCGLNDBRK<a>(a a, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8C36530", Offset = "0x8C34F30", VA = "0x188C36530")]
			[AsyncStateMachine(typeof(<WriteText>d__9))]
			public Task<FileInfo> UFCWDJVDXIO(string a, CancellationToken b, string c = "txt")
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8C36A30", Offset = "0x8C35430", VA = "0x188C36A30")]
			[AsyncStateMachine(typeof(<WriteImage>d__10))]
			public Task<FileInfo> YDMBFRWCGXI(ReadOnlySequence<byte> a, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8C36690", Offset = "0x8C35090", VA = "0x188C36690")]
			[AsyncStateMachine(typeof(<WriteBytes>d__11))]
			public Task<FileInfo> UZOGKMGDDYU(ReadOnlySequence<byte> a, string b, CancellationToken c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8C36B90", Offset = "0x8C35590", VA = "0x188C36B90")]
			[AsyncStateMachine(typeof(<WriteViaStreamAsync>d__12))]
			public Task<FileInfo> YRMOLWVVZSB(string a, Func<Stream, Task> b, CancellationToken c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8C36090", Offset = "0x8C34A90", VA = "0x188C36090")]
			[AsyncStateMachine(typeof(<WriteAllBytesInternal>d__13))]
			private Task<FileInfo> EIWHMLCOCKG(FileInfo a, ReadOnlySequence<byte> b, CancellationToken c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4162970", Offset = "0x4161370", VA = "0x184162970")]
			[AsyncStateMachine(typeof(<WriteProtobuf>d__14<>))]
			public Task<IReadOnlyCollection<FileInfo>> OIEBRCRRPJM<b>(ReadOnlySequence<byte> a, MessageParser<b> b, WFAPAQCSIZF c, CancellationToken d) where b : IMessage<b>
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x41627D0", Offset = "0x41611D0", VA = "0x1841627D0")]
			[AsyncStateMachine(typeof(<WriteProtobuf>d__15<>))]
			public Task<IReadOnlyCollection<FileInfo>> OIEBRCRRPJM<c>(ReadOnlySequence<byte> a, c b, WFAPAQCSIZF c, CancellationToken d) where c : IMessage<c>
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8C362C0", Offset = "0x8C34CC0", VA = "0x188C362C0")]
			[AsyncStateMachine(typeof(<WriteAudio>d__16))]
			public Task KNKKMIPYHNX(AudioStreamData a, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8C363F0", Offset = "0x8C34DF0", VA = "0x188C363F0")]
			[AsyncStateMachine(typeof(<WriteAudioSamplesToStream>d__17))]
			private static Task NTKVMEYEGBT(Stream a, float[] b, int c, int d, CancellationToken e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x8C36830", Offset = "0x8C35230", VA = "0x188C36830")]
			[CompilerGenerated]
			internal static void WERHPLKTRJH(byte[] a, int b, int c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8C36200", Offset = "0x8C34C00", VA = "0x188C36200")]
			[CompilerGenerated]
			internal static void KCRCPNIVSXO(byte[] a, int b, short c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x8C367F0", Offset = "0x8C351F0", VA = "0x188C367F0")]
			[CompilerGenerated]
			internal static byte[] VDJSWXJSPQD(int a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private readonly DirectoryInfo MKFALAUABIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private readonly HashSet<string> FLSACVRPGRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private readonly KDLVQAUWETD TYJYJSBKFYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private readonly Stopwatch EFOJWVHRAGJ;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8C34690", Offset = "0x8C33090", VA = "0x188C34690")]
		public MSMECEABMOB(DirectoryInfo a, KDLVQAUWETD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8C34650", Offset = "0x8C33050", VA = "0x188C34650")]
		public OIGDXBHIJTX ZCIVQJAPNDE(DirectoryInfo a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8C34570", Offset = "0x8C32F70", VA = "0x188C34570")]
		public OIGDXBHIJTX ZCIVQJAPNDE(ExportPath a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public readonly struct ExportPath : IEquatable<ExportPath>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public readonly DirectoryInfo WriteDir;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public readonly string FilenameNoExtension;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8C32920", Offset = "0x8C31320", VA = "0x188C32920")]
		public ExportPath(DirectoryInfo writeDir, string filenameNoExtension)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8C327A0", Offset = "0x8C311A0", VA = "0x188C327A0")]
		public FileInfo QKOJMMRZWLF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8C32590", Offset = "0x8C30F90", VA = "0x188C32590", Slot = "4")]
		public bool Equals(ExportPath other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8C32630", Offset = "0x8C31030", VA = "0x188C32630", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8C32730", Offset = "0x8C31130", VA = "0x188C32730", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public enum ExportStatus
	{
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		Success
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public readonly struct ExportResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public readonly ExportStatus ExportStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public readonly ArchiveType ArchiveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public readonly FileInfo? ZipArchiveFileInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public readonly DirectoryInfo? DirectoryInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public readonly Exception? Exception;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public readonly string? ErrorString;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool ZGPFTQRLUFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x6A205D0", Offset = "0x6A1EFD0", VA = "0x186A205D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8C32CF0", Offset = "0x8C316F0", VA = "0x188C32CF0")]
		private ExportResult(DirectoryInfo? directoryInfo, FileInfo? zipArchiveFileInfo, ArchiveType archiveType, ExportStatus exportStatus, Exception? ex, [Optional] string? errorString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8C32A40", Offset = "0x8C31440", VA = "0x188C32A40")]
		public static ExportResult EACZRRGGJLA(ISMRVFIVZRA a, FileInfo b)
		{
			return default(ExportResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8C32C40", Offset = "0x8C31640", VA = "0x188C32C40")]
		public static ExportResult NRUGDPMBBZI(ISMRVFIVZRA a, DirectoryInfo b)
		{
			return default(ExportResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8C32BA0", Offset = "0x8C315A0", VA = "0x188C32BA0")]
		public void JNPBEPHBIIT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8C32B10", Offset = "0x8C31510", VA = "0x188C32B10")]
		public static ExportResult Error(string errorString, Exception ex)
		{
			return default(ExportResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public enum ArchiveType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		Directory,
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		ZipArchive
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal class QAKQIYTEUES : ZVMBXFNFHDW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private readonly ShapeRendererConfig QXNZINHPCRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private readonly Dictionary<int, ImageBuilder> ESQHCJLISGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private readonly Dictionary<string, ImageBuilder> BUJWNLZPBPG;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8C37E00", Offset = "0x8C36800", VA = "0x188C37E00")]
		public QAKQIYTEUES(ShapeRendererConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8C36F90", Offset = "0x8C35990", VA = "0x188C36F90", Slot = "5")]
		public BevelConfig CNTWWSUEDAA()
		{
			return default(BevelConfig);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8C37710", Offset = "0x8C36110", VA = "0x188C37710", Slot = "4")]
		public SIQLDCGEZQD HQAATRQPZGK(RecRoom.ExportTools.PrimitiveShapeMeshType a, int b = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8C37340", Offset = "0x8C35D40", VA = "0x188C37340", Slot = "6")]
		public ZZBUQWVONEV GetMaterialExportData(RecRoom.ExportTools.ShapeColor shapeColor, RecRoom.ExportTools.ShapeMaterial shapeMaterial)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8C36DF0", Offset = "0x8C357F0", VA = "0x188C36DF0", Slot = "7")]
		public bool AUYCTLZINWU(Guid a, [Out][MaybeNullWhen(false)] string prefabPrefix)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8C37940", Offset = "0x8C36340", VA = "0x188C37940")]
		private UMCDBUXBQDR QYEGJGHJYWG(UnityEngine.Material a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8C37000", Offset = "0x8C35A00", VA = "0x188C37000")]
		private UMCDBUXBQDR FAOKXXUGRHF(UnityEngine.Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8C37BD0", Offset = "0x8C365D0", VA = "0x188C37BD0")]
		private static byte[] RLFUWIVWJAA(Texture2D a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8C36DD0", Offset = "0x8C357D0", VA = "0x188C36DD0")]
		private static RecRoom.ExportTools.TextureWrapMode ATIGMXNJYKG(UnityEngine.TextureWrapMode a)
		{
			return default(RecRoom.ExportTools.TextureWrapMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8C36D90", Offset = "0x8C35790", VA = "0x188C36D90")]
		private static ColorRGB ARNEBGDWQJD(Color a)
		{
			return default(ColorRGB);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct FileExportNote : IEquatable<FileExportNote>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public readonly string fileName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public readonly string descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public readonly string footnoteSection;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8C33920", Offset = "0x8C32320", VA = "0x188C33920")]
		public FileExportNote(FileInfo file, string descriptionLines, [Optional] string footnoteSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x1F22AA0", Offset = "0x1F214A0", VA = "0x181F22AA0")]
		public FileExportNote(string fileName, string descriptionText, [Optional] string footnoteSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8C338C0", Offset = "0x8C322C0", VA = "0x188C338C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x32A70A0", Offset = "0x32A5AA0", VA = "0x1832A70A0", Slot = "4")]
		public bool Equals(FileExportNote other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8C33830", Offset = "0x8C32230", VA = "0x188C33830", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x66B6A70", Offset = "0x66B5470", VA = "0x1866B6A70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public interface XIYFWNZOHNM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool HZJKHRVTTXI
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		bool MKZIJJLGTKG
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<IReadOnlyCollection<Guid>> BVRDIPXHDUH(CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public interface YLTZGBWSOOM
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool APOSUTTQAOG(Guid a, [Out] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public interface WFAPAQCSIZF
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		ProtobufOutputFormat VZLEZLSLXBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		bool QUBEDHLXZXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		bool PWIVVOOOKPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool LHLBTFMOLEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool TAJZFDLCBZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		AvatarExportFormat VGOLHJFMUBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		int UXMVZKYZXRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool AHWVGPGBJOK();
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class ZFTSUGGVYBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		public enum ImageType : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			Unknown,
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			Jpg,
			[Cpp2IlInjected.Token(Token = "0x40002E6")]
			Png,
			[Cpp2IlInjected.Token(Token = "0x40002E7")]
			Gif89a,
			[Cpp2IlInjected.Token(Token = "0x40002E8")]
			Gif87a
		}

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private static readonly byte[] ARHZWLVJJPV;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private static readonly byte[] BZTKGZZWPSP;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private static readonly byte[] TGCBXVKTVBU;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private static readonly byte[] PDRQUOELZFS;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8C4B360", Offset = "0x8C49D60", VA = "0x188C4B360")]
		public static ImageType XAPSWUBEKZU(ReadOnlySequence<byte> a)
		{
			return default(ImageType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8C4B2E0", Offset = "0x8C49CE0", VA = "0x188C4B2E0")]
		public static string SEACPZRHTWE(ImageType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4B190", Offset = "0x8C49B90", VA = "0x188C4B190")]
		[CompilerGenerated]
		internal static bool HGQGUTRSNFX(ReadOnlySequence<byte> a, byte[] b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class WLORNEXALKN : KKHNNDAADSU<long>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class NCLLTQFRZHV
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000073")]
			private struct <<ExecuteInternal>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002EF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				public AsyncTaskMethodBuilder<InventionData> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				public NCLLTQFRZHV <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				private TaskAwaiter<InventionData> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000165")]
				[Cpp2IlInjected.Address(RVA = "0x8C41C30", Offset = "0x8C40630", VA = "0x188C41C30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000166")]
				[Cpp2IlInjected.Address(RVA = "0x8C41F00", Offset = "0x8C40900", VA = "0x188C41F00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000074")]
			private struct <<ExecuteInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F3")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F4")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002F5")]
				public NCLLTQFRZHV <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40002F6")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000167")]
				[Cpp2IlInjected.Address(RVA = "0x8C41F70", Offset = "0x8C40970", VA = "0x188C41F70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000168")]
				[Cpp2IlInjected.Address(RVA = "0x8C42250", Offset = "0x8C40C50", VA = "0x188C42250", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002EC")]
			public WLORNEXALKN IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public CancellationToken PWKBEQSRYAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public InventionData MTGDALBNPQA;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public NCLLTQFRZHV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8C34870", Offset = "0x8C33270", VA = "0x188C34870")]
			[AsyncStateMachine(typeof(<<ExecuteInternal>b__0>d))]
			internal Task<InventionData> ZXLAKEMKPBM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8C34960", Offset = "0x8C33360", VA = "0x188C34960")]
			[AsyncStateMachine(typeof(<<ExecuteInternal>b__1>d))]
			internal Task<byte[]> ZXQHHLGHYMV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class NCGEWJLUPWM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000076")]
			private struct <<ExecuteInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F9")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002FA")]
				public NCGEWJLUPWM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40002FB")]
				public Stream stream;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40002FC")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x8C422C0", Offset = "0x8C40CC0", VA = "0x188C422C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x8C42440", Offset = "0x8C40E40", VA = "0x188C42440", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			public ModelRoot TVUEKFUNIOP;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public NCGEWJLUPWM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x8C34780", Offset = "0x8C33180", VA = "0x188C34780")]
			[AsyncStateMachine(typeof(<<ExecuteInternal>b__2>d))]
			internal Task ZXAMPQYPWEU(Stream a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct <ExecuteInternal>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002FF")]
			public WLORNEXALKN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			public RWDDBETBFKO progressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000303")]
			private NCLLTQFRZHV <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			private HHJKAHBJTBC.WMBBZOXZHWM <myProgress>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			private JHHKPCTWYYR <downloadProgress>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			private JHHKPCTWYYR <persistenceViewProgress>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			private byte[] <inventionBytes>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			private SpawnableTemplateData <deserializedInventionData>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			private TaskAwaiter<InventionData> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			private TaskAwaiter<byte[]> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			private object <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			private int <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			private TaskAwaiter<IEnumerable<long>> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			private TaskAwaiter<IReadOnlyList<WWHDCNGHEQQ>?> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x8C39D00", Offset = "0x8C38700", VA = "0x188C39D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x8C3CFE0", Offset = "0x8C3B9E0", VA = "0x188C3CFE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private readonly string UZKQPZYYTPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private readonly NPAUVFPBVDQ EUZXIIIOAIX;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public long XRGMWUIYAAB
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool HKYYGRESCYF
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xDE9C70", Offset = "0xDE8670", VA = "0x180DE9C70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A880", Offset = "0x8C49280", VA = "0x188C4A880")]
		public WLORNEXALKN(TZOLTYMUIVH a, YLTZGBWSOOM b, HJBLJFFMFID.TVWXLXTXIIP c, long d, string e, WFAPAQCSIZF f, bool g = false, [Optional] NPAUVFPBVDQ h, [Optional] WTSNVZGDFSC.FQBZXGVILAS i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A7E0", Offset = "0x8C491E0", VA = "0x188C4A7E0", Slot = "5")]
		protected override string SGBHDLFHLJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A720", Offset = "0x8C49120", VA = "0x188C4A720", Slot = "6")]
		protected override DirectoryInfo JSTSNJNBXDH(WTSNVZGDFSC.FQBZXGVILAS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A5C0", Offset = "0x8C48FC0", VA = "0x188C4A5C0", Slot = "7")]
		[AsyncStateMachine(typeof(<ExecuteInternal>d__10))]
		public override Task FXQCSBQZMMQ(ExecutionArgs a, DirectoryInfo b, RWDDBETBFKO c, CancellationToken d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public interface SZEYKJOGJRA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public struct OMShape
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public ObjectLocalId ObjectLocalId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public PrimitiveShapeType PrimitiveShapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public Vector3 LocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public Quaternion LocalRotation;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public RRObjectSplinePoint[] SplinePoints
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public interface TZOLTYMUIVH
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<byte[]> OVUNCSZQKBF(string a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<byte[]> SIEAKNEESNC(string a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<byte[]> EWNZAASUBSH(string a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<byte[]> STTHTXHAFYC(string a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<byte[]> ZXSMMBRMGSH(FilenameWithHash a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<RoomDetailsDTO> YIAHHOFJLAR(long a, int? b, int? c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<InventionData> JXUECNHEGZW(long a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public readonly struct InventionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		[JetBrains.Annotations.NotNull]
		public readonly Invention Invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[JetBrains.Annotations.NotNull]
		public readonly InventionVersion InventionVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[JetBrains.Annotations.NotNull]
		public readonly InventionDetails InventionDetails;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D730", Offset = "0x8C4C130", VA = "0x188C4D730")]
		public InventionData([JetBrains.Annotations.NotNull] Invention invention, [JetBrains.Annotations.NotNull] InventionVersion inventionVersion, [JetBrains.Annotations.NotNull] InventionDetails inventionDetails)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D710", Offset = "0x8C4C110", VA = "0x188C4D710")]
		public bool ONFJERHUBQG([Out] string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class XGIMZXGPCVM : EVAKBSJADID
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool SYZUYZYRBFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xD2C460", Offset = "0xD2AE60", VA = "0x180D2C460", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
		public void WYXZOEZXIDA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "6")]
		public void BBVVXIKVZBH(RigidbodyEx a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "7")]
		public BXGMNKSANBR XQBJZDXWDSU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
		public void EGYLXBJLLPO(Vector3 a, float b, Color c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public XGIMZXGPCVM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	internal class TAHLECEZFIT : EASHJXZFNMQ, BRJXWIDECGJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public BRJXWIDECGJ KHLKFNYWTNM
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xDF8EF0", Offset = "0xDF78F0", VA = "0x180DF8EF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
		public void VOOCJPOLHSY(object a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "6")]
		public void ZBDLTDBERZS(object a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
		public void TUAEUFLAQYK(object a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public TAHLECEZFIT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class XMIGIZEJIIT : KKHNNDAADSU<long>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		private delegate string AssetFilenameFunc(string cloudVarName, Guid cloudVarGuid, string blobName);

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		private delegate string IndexedAssetFilenameFunc(string cloudVarName, int index, Guid cloudVarGuid, string blobName);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private struct <<ExecuteInternal>g__AddAssetsFromListType|7_5>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public RepeatedField<HBQDVLPKBTA> ledgerEntries;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public RepeatedField<VFVCDWYFOHW> persistedValues;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public GULGPXNWFWU playerCloudData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public NJCXGDZTOSF.AssetType assetType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public IndexedAssetFilenameFunc assetFilenameFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			private Dictionary<Guid, string> <guidToNameMap>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			private IEnumerator<VFVCDWYFOHW> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8C59A60", Offset = "0x8C58460", VA = "0x188C59A60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A270", Offset = "0x8C58C70", VA = "0x188C5A270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private struct <<ExecuteInternal>g__AddAssetsFromValueType|7_4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public RepeatedField<HBQDVLPKBTA> ledgerEntries;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public RepeatedField<VFVCDWYFOHW> persistedValues;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public NJCXGDZTOSF.AssetType assetType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public AssetFilenameFunc assetFilenameFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			private Dictionary<Guid, string> <guidToNameMap>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			private IEnumerator<VFVCDWYFOHW> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A2D0", Offset = "0x8C58CD0", VA = "0x188C5A2D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8C5A9A0", Offset = "0x8C593A0", VA = "0x188C5A9A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class RBAAAFPDLJX
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000085")]
			private struct <<ExecuteInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000341")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000342")]
				public AsyncTaskMethodBuilder<RoomDetailsDTO> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000343")]
				public RBAAAFPDLJX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000344")]
				private TaskAwaiter<RoomDetailsDTO> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x8C59530", Offset = "0x8C57F30", VA = "0x188C59530", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x8C59750", Offset = "0x8C58150", VA = "0x188C59750", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000086")]
			private struct <<ExecuteInternal>b__8>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000345")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000346")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000347")]
				public RBAAAFPDLJX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000348")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x8C597C0", Offset = "0x8C581C0", VA = "0x188C597C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x8C599F0", Offset = "0x8C583F0", VA = "0x188C599F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public XMIGIZEJIIT IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public CancellationToken PWKBEQSRYAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public RoomDetailsDTO QTUMYSXOAQN;

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public RBAAAFPDLJX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x8C4F770", Offset = "0x8C4E170", VA = "0x188C4F770")]
			[AsyncStateMachine(typeof(<<ExecuteInternal>b__7>d))]
			internal Task<RoomDetailsDTO> ZWKRXWQXTWT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x8C4F860", Offset = "0x8C4E260", VA = "0x188C4F860")]
			[AsyncStateMachine(typeof(<<ExecuteInternal>b__8>d))]
			internal Task<byte[]> ZZBDOGPPMOG()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private struct <ExecuteInternal>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			public XMIGIZEJIIT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public RWDDBETBFKO progressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private RBAAAFPDLJX <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private HHJKAHBJTBC.WMBBZOXZHWM <myProgress>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			private JHHKPCTWYYR <fetchDetailsProgress>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			private JHHKPCTWYYR <fetchCloudDataLedgerProgress>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			private JHHKPCTWYYR <exportCloudDataProgress>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			private SuperRoomData <superRoomData>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			private MGHTQQONCWO <cloudDataLedger>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			private GULGPXNWFWU <playerCloudData>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			private TaskAwaiter<RoomDetailsDTO> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			private TaskAwaiter<byte[]> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			private TaskAwaiter <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x8C52620", Offset = "0x8C51020", VA = "0x188C52620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x8C54B30", Offset = "0x8C53530", VA = "0x188C54B30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private readonly string EPDUVRSZEGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private readonly KWFNBZIYXRE UHHIEFEKVSX;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EEWTHBXTEDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8C5C030", Offset = "0x8C5AA30", VA = "0x188C5C030")]
		public XMIGIZEJIIT(TZOLTYMUIVH a, YLTZGBWSOOM b, HJBLJFFMFID.TVWXLXTXIIP c, long d, string e, KWFNBZIYXRE f, WFAPAQCSIZF g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8C5BC70", Offset = "0x8C5A670", VA = "0x188C5BC70", Slot = "5")]
		protected override string SGBHDLFHLJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8C5BA80", Offset = "0x8C5A480", VA = "0x188C5BA80", Slot = "6")]
		protected override DirectoryInfo JSTSNJNBXDH(WTSNVZGDFSC.FQBZXGVILAS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B920", Offset = "0x8C5A320", VA = "0x188C5B920", Slot = "7")]
		[AsyncStateMachine(typeof(<ExecuteInternal>d__7))]
		public override Task FXQCSBQZMMQ(ExecutionArgs a, DirectoryInfo b, RWDDBETBFKO c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8C5BD10", Offset = "0x8C5A710", VA = "0x188C5BD10")]
		[AsyncStateMachine(typeof(<<ExecuteInternal>g__AddAssetsFromValueType|7_4>d))]
		[CompilerGenerated]
		internal static Task YZHKEXWZXRO(ExecutionArgs a, DirectoryInfo b, NJCXGDZTOSF.AssetType c, AssetFilenameFunc d, RepeatedField<HBQDVLPKBTA> e, RepeatedField<VFVCDWYFOHW> f, CancellationToken g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5BE90", Offset = "0x8C5A890", VA = "0x188C5BE90")]
		[AsyncStateMachine(typeof(<<ExecuteInternal>g__AddAssetsFromListType|7_5>d))]
		[CompilerGenerated]
		internal static Task ZWLKTSGISQY(ExecutionArgs a, DirectoryInfo b, NJCXGDZTOSF.AssetType c, IndexedAssetFilenameFunc d, RepeatedField<HBQDVLPKBTA> e, RepeatedField<VFVCDWYFOHW> f, GULGPXNWFWU g, CancellationToken h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5BAA0", Offset = "0x8C5A4A0", VA = "0x188C5BAA0")]
		[CompilerGenerated]
		internal static Dictionary<Guid, string> LHFXTKALRIL(RepeatedField<HBQDVLPKBTA> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[Flags]
	public enum ProtobufOutputFormat : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		Bytes = 1,
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		Json = 2,
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		AllFormats = 3
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	internal static class ZSOATIYMVMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C5C370", Offset = "0x8C5AD70", VA = "0x188C5C370")]
		public static Guid MHITTWJTFKB(ByteString a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class ISMRVFIVZRA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private readonly List<string> ZKXNIOGNRMX;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ExportStatus MBXXEOXVFWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8C4D0C0", Offset = "0x8C4BAC0", VA = "0x188C4D0C0")]
			get
			{
				return default(ExportStatus);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IReadOnlyList<string> LYZSXZBKZEP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D010", Offset = "0x8C4BA10", VA = "0x188C4D010")]
		public void VHVLJUFZQNF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D110", Offset = "0x8C4BB10", VA = "0x188C4D110")]
		public ISMRVFIVZRA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class BHQRBNLUEJI : KKHNNDAADSU<long>
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class ECWTQFSOHXI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200008E")]
			private struct <<ExecuteInternal>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400036C")]
				public AsyncTaskMethodBuilder<RoomDetailsDTO> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400036D")]
				public ECWTQFSOHXI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400036E")]
				private TaskAwaiter<RoomDetailsDTO> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x8C58D70", Offset = "0x8C57770", VA = "0x188C58D70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0x8C58F90", Offset = "0x8C57990", VA = "0x188C58F90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public BHQRBNLUEJI IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public CancellationToken PWKBEQSRYAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public DirectoryInfo JSQOREWJSYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public ExecutionArgs PDRMJUBYVAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public HashSet<long> VPUVRRMVTLX;

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public ECWTQFSOHXI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x8C4C600", Offset = "0x8C4B000", VA = "0x188C4C600")]
			[AsyncStateMachine(typeof(<<ExecuteInternal>b__0>d))]
			internal Task<RoomDetailsDTO> ZXLAKEMKPBM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class EDCANMMLRIR
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			private struct <<ExecuteInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000372")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000373")]
				public AsyncTaskMethodBuilder<bool> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000374")]
				public EDCANMMLRIR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000375")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(RVA = "0x8C59000", Offset = "0x8C57A00", VA = "0x188C59000", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0x8C594C0", Offset = "0x8C57EC0", VA = "0x188C594C0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public SubRoomDTO YJITRPCGVHW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public JHHKPCTWYYR JBFRXBWWWTS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public ECWTQFSOHXI IYWFXXOWUJJ;

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public EDCANMMLRIR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8C4C6F0", Offset = "0x8C4B0F0", VA = "0x188C4C6F0")]
			[AsyncStateMachine(typeof(<<ExecuteInternal>b__1>d))]
			internal Task<bool> ZXQHHLGHYMV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private sealed class UQEFQITABRG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000092")]
			private struct <<FetchValidInventions>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000378")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				public AsyncTaskMethodBuilder<(bool success, InventionData invention)> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400037A")]
				public UQEFQITABRG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400037B")]
				public long id;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400037C")]
				private TaskAwaiter<InventionData> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x8C5AA00", Offset = "0x8C59400", VA = "0x188C5AA00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0x8C5AD60", Offset = "0x8C59760", VA = "0x188C5AD60", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public BHQRBNLUEJI IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public CancellationToken PWKBEQSRYAS;

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public UQEFQITABRG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x8C5B820", Offset = "0x8C5A220", VA = "0x188C5B820")]
			[AsyncStateMachine(typeof(<<FetchValidInventions>b__0>d))]
			internal Task<(bool, InventionData)> JBEMNOLEJFB(long a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private sealed class QXLRGRRVYAH
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000094")]
			private struct <<ProcessSubroom>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000380")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000381")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000382")]
				public QXLRGRRVYAH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000383")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001C4")]
				[Cpp2IlInjected.Address(RVA = "0x8C5ADD0", Offset = "0x8C597D0", VA = "0x188C5ADD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C5")]
				[Cpp2IlInjected.Address(RVA = "0x8C5B010", Offset = "0x8C59A10", VA = "0x188C5B010", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public BHQRBNLUEJI IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public SubRoomDTO YJITRPCGVHW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public CancellationToken PWKBEQSRYAS;

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public QXLRGRRVYAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x8C4F680", Offset = "0x8C4E080", VA = "0x188C4F680")]
			[AsyncStateMachine(typeof(<<ProcessSubroom>b__0>d))]
			internal Task<byte[]> GPSYSACIMBA()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private struct <ExecuteInternal>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public BHQRBNLUEJI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public DirectoryInfo roomDirInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public RWDDBETBFKO progressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			private ECWTQFSOHXI <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			private HHJKAHBJTBC.WMBBZOXZHWM <myProgress>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			private JHHKPCTWYYR <subroomsProgress>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			private JHHKPCTWYYR <inventionsProgress>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			private RoomDetailsDTO <roomDetailsDTO>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private JHHKPCTWYYR[] <subroomProgressArr>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			private List<Exception> <subroomExceptions>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			private int <subroomIndex>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			private TaskAwaiter<bool> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			private TaskAwaiter <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8C508A0", Offset = "0x8C4F2A0", VA = "0x188C508A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8C525C0", Offset = "0x8C50FC0", VA = "0x188C525C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private struct <FetchValidInventions>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public AsyncTaskMethodBuilder<IReadOnlyList<InventionData>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public BHQRBNLUEJI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public IEnumerable<long> idList;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			private TaskAwaiter<(bool success, InventionData invention)[]> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x8C54B90", Offset = "0x8C53590", VA = "0x188C54B90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x8C55040", Offset = "0x8C53A40", VA = "0x188C55040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private struct <ProcessInRoomInventions>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public IReadOnlyCollection<long> allInventionIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public BHQRBNLUEJI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public DirectoryInfo roomDirInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public RWDDBETBFKO inventionsProgress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			private IReadOnlyList<InventionData> <fetchedInventions>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			private DirectoryInfo <inventionsDir>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			private JHHKPCTWYYR[] <inventionProgressArray>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			private TaskAwaiter<IReadOnlyList<InventionData>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private int <index>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			private long <inventionId>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			private DirectoryInfo <inventionDir>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			private JHHKPCTWYYR <thisInvProg>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			private object <>7__wrap8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			private int <>7__wrap9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			private TaskAwaiter<InventionData> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			private Exception <ex>5__11;

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8C550B0", Offset = "0x8C53AB0", VA = "0x188C550B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8C56570", Offset = "0x8C54F70", VA = "0x188C56570", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private struct <ProcessSubroom>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public BHQRBNLUEJI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public SubRoomDTO subRoomDTO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public RWDDBETBFKO progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			private QXLRGRRVYAH <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public HashSet<long> allInventionIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			private HHJKAHBJTBC.WMBBZOXZHWM <myProgress>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			private JHHKPCTWYYR <downloadProgress>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private JHHKPCTWYYR <shapeExportProgress>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			private byte[] <subroomBytes>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			private PersistedRoomData <persistedRoomData>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private TaskAwaiter<FileInfo> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private TaskAwaiter<byte[]> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			private object <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			private int <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			private TaskAwaiter<IEnumerable<long>> <>u__5;

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8C565D0", Offset = "0x8C54FD0", VA = "0x188C565D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x8C58D00", Offset = "0x8C57700", VA = "0x188C58D00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private readonly string ZOZLENQBISC;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public long EEWTHBXTEDC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C230", Offset = "0x8C4AC30", VA = "0x188C4C230")]
		public BHQRBNLUEJI(TZOLTYMUIVH a, YLTZGBWSOOM b, HJBLJFFMFID.TVWXLXTXIIP c, long d, string e, WFAPAQCSIZF f, [Optional] WTSNVZGDFSC.FQBZXGVILAS g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C190", Offset = "0x8C4AB90", VA = "0x188C4C190", Slot = "5")]
		protected override string SGBHDLFHLJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C030", Offset = "0x8C4AA30", VA = "0x188C4C030", Slot = "6")]
		protected override DirectoryInfo JSTSNJNBXDH(WTSNVZGDFSC.FQBZXGVILAS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8C4BD20", Offset = "0x8C4A720", VA = "0x188C4BD20", Slot = "7")]
		[AsyncStateMachine(typeof(<ExecuteInternal>d__6))]
		public override Task FXQCSBQZMMQ(ExecutionArgs a, DirectoryInfo b, RWDDBETBFKO c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8C4BBA0", Offset = "0x8C4A5A0", VA = "0x188C4BBA0")]
		[AsyncStateMachine(typeof(<ProcessInRoomInventions>d__7))]
		private Task FSYEYUMIJBS(ExecutionArgs a, IReadOnlyCollection<long> b, DirectoryInfo c, RWDDBETBFKO d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C050", Offset = "0x8C4AA50", VA = "0x188C4C050")]
		[AsyncStateMachine(typeof(<FetchValidInventions>d__8))]
		private Task<IReadOnlyList<InventionData>> JTESHRAQICH(IEnumerable<long> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4BE80", Offset = "0x8C4A880", VA = "0x188C4BE80")]
		[AsyncStateMachine(typeof(<ProcessSubroom>d__9))]
		private Task<bool> HOSDLDGJEHK(ExecutionArgs a, DirectoryInfo b, SubRoomDTO c, HashSet<long> d, RWDDBETBFKO e, CancellationToken f)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	internal class ATRBTIGRLXF<a>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private struct <Execute>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public AsyncTaskMethodBuilder<a> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public ATRBTIGRLXF<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			private string <text>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			private object <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			private a <result>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			private IDisposable <_>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			private TaskAwaiter<a> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private Exception <ex>5__6;

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x6677D00", Offset = "0x6676700", VA = "0x186677D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x41EFEE0", Offset = "0x41EE8E0", VA = "0x1841EFEE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private readonly Func<Task<a>> IOTOCIDRWSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private readonly string NLTFZGJYPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private KDLVQAUWETD TYJYJSBKFYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private RWDDBETBFKO WMXBZLUQPJT;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xCDD200", Offset = "0xCDBC00", VA = "0x180CDD200")]
		private ATRBTIGRLXF(Func<Task<a>> a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7328920", Offset = "0x7327320", VA = "0x187328920")]
		public static ATRBTIGRLXF<a> New(Func<Task<a>> taskFactory, string sectionText)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7328FF0", Offset = "0x73279F0", VA = "0x187328FF0")]
		public ATRBTIGRLXF<a> YYQVBHBWVYQ(KDLVQAUWETD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x73289D0", Offset = "0x73273D0", VA = "0x1873289D0")]
		public ATRBTIGRLXF<a> PFHGXUFQQGF(RWDDBETBFKO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7328C60", Offset = "0x7327660", VA = "0x187328C60")]
		[AsyncStateMachine(typeof(ATRBTIGRLXF<>.<Execute>d__8))]
		public Task<a> RYTZSVJESQN(CancellationToken a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal class PMJVPSEPMKH<a, b>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private struct <Execute>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public AsyncTaskMethodBuilder<b> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public PMJVPSEPMKH<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public a args;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			private string <text>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			private object <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			private b <result>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			private IDisposable <_>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			private TaskAwaiter<b> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			private Exception <ex>5__6;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x667E6F0", Offset = "0x667D0F0", VA = "0x18667E6F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x667F7D0", Offset = "0x667E1D0", VA = "0x18667F7D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private readonly Func<a, Task<b>> IOTOCIDRWSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private readonly string NLTFZGJYPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private KDLVQAUWETD TYJYJSBKFYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private RWDDBETBFKO WMXBZLUQPJT;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xCDD200", Offset = "0xCDBC00", VA = "0x180CDD200")]
		private PMJVPSEPMKH(Func<a, Task<b>> a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7328920", Offset = "0x7327320", VA = "0x187328920")]
		public static PMJVPSEPMKH<a, b> New(Func<a, Task<b>> taskFactory, string sectionText)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7328FF0", Offset = "0x73279F0", VA = "0x187328FF0")]
		public PMJVPSEPMKH<a, b> YYQVBHBWVYQ(KDLVQAUWETD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x73289D0", Offset = "0x73273D0", VA = "0x1873289D0")]
		public PMJVPSEPMKH<a, b> PFHGXUFQQGF(RWDDBETBFKO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x74F59F0", Offset = "0x74F43F0", VA = "0x1874F59F0")]
		[AsyncStateMachine(typeof(PMJVPSEPMKH<, >.<Execute>d__8))]
		public Task<b> RYTZSVJESQN(a a, CancellationToken b)
		{
			return null;
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class SXRQWWMGNFS : XMRYKLGFYDB
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Guid IEETIIJCCON
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8C507E0", Offset = "0x8C4F1E0", VA = "0x188C507E0", Slot = "4")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8C506C0", Offset = "0x8C4F0C0", VA = "0x188C506C0", Slot = "5")]
		public Task BVFWIDLBQCH(Guid a, Guid b, Guid c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8C50750", Offset = "0x8C4F150", VA = "0x188C50750", Slot = "6")]
		public Task HXODDCMVMPC(Guid a, Guid[] b, Guid c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x10E6F20", Offset = "0x10E5920", VA = "0x1810E6F20", Slot = "7")]
		public Guid QFAGGVLWHGX(Guid a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8C50810", Offset = "0x8C4F210", VA = "0x188C50810", Slot = "8")]
		public Task WRYKSGAPSFV(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "9")]
		public bool FORJMVIOBYW(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "11")]
		public void KVYKTHGUPDZ(Guid a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "12")]
		public void HKJMOTGYTIO(Guid a, ObjectNetworkId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "13")]
		public void RXDTOOLKPQM(ObjectNetworkId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "14")]
		public void XUNLYYMMXSO(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "10")]
		public bool FTXHTQPXUOC(IGDJKBBETHK a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public SXRQWWMGNFS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public class JUONYUXUHLZ : EQTRCHGZGNG
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Guid IEETIIJCCON
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xEFDE50", Offset = "0xEFC850", VA = "0x180EFDE50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D970", Offset = "0x8C4C370", VA = "0x188C4D970", Slot = "5")]
		public void MADRNVVGKWS(NativeList<Guid> a, NativeList<Guid> b, NativeList<FixedString64Bytes> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public JUONYUXUHLZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public class PMWSUMAEGRX : FTGGXJYXXPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public void ORLMZSMEYLO(object a, object b, Action c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "6")]
		public void GOBOVDASVQF(string a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
		public void WIKPAQTJZRU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
		public void SEYOSXEFBQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F140", Offset = "0x8C4DB40", VA = "0x188C4F140", Slot = "9")]
		public BQLMPHORWRC<bool> OQVDNVPWRWK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F100", Offset = "0x8C4DB00", VA = "0x188C4F100", Slot = "10")]
		public BQLMPHORWRC<float> LBVJIGDGLWI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F080", Offset = "0x8C4DA80", VA = "0x188C4F080", Slot = "11")]
		public BQLMPHORWRC<int> FSSVWGDGHOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F0C0", Offset = "0x8C4DAC0", VA = "0x188C4F0C0", Slot = "12")]
		public BQLMPHORWRC<string> GNRDOVBEQPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F1C0", Offset = "0x8C4DBC0", VA = "0x188C4F1C0", Slot = "13")]
		public BQLMPHORWRC<int> TYPGJHWOVTT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F200", Offset = "0x8C4DC00", VA = "0x188C4F200", Slot = "14")]
		public BQLMPHORWRC<Enum> YINFAMQLKDV(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F180", Offset = "0x8C4DB80", VA = "0x188C4F180", Slot = "15")]
		public BQLMPHORWRC<Enum> OZDVQWARUMK(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F040", Offset = "0x8C4DA40", VA = "0x188C4F040", Slot = "16")]
		public BQLMPHORWRC<(int, int)> FCXPENWJZZP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public PMWSUMAEGRX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public class FMKGHZRSDKH : LJOJBYIDAVC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public FMKGHZRSDKH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class IZDXWORIKQL : VTSCJVWHWHC
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public object AVWBHNNYUOS
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public IZDXWORIKQL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class NPJGDVZQMID : UKZCNGGIIXS
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public NPJGDVZQMID()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public class IZQTTGGDZPQ : GNDNISUWERF
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string VCZLGRWRVGO
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x8C4D5D0", Offset = "0x8C4BFD0", VA = "0x188C4D5D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public IZQTTGGDZPQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal class QNETGYTDHRL : JVVMTIWBIRW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private bool GWOPYWFKHUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private Dictionary<string, bool> CDCKEECSAGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private Func<string, int, int> VZWQDGYGQGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private Func<string, bool> NOLCHMBFDAF;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F430", Offset = "0x8C4DE30", VA = "0x188C4F430")]
		public QNETGYTDHRL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F3B0", Offset = "0x8C4DDB0", VA = "0x188C4F3B0")]
		public bool UMZZCAGGXEP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2766E60", Offset = "0x2765860", VA = "0x182766E60")]
		public int MYYQFSNMMUR(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public void ZILVQMZYFEE(Action a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8C4CCE0", Offset = "0x8C4B6E0", VA = "0x188C4CCE0", Slot = "5")]
		public bool RUQWHEVPTZL(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F390", Offset = "0x8C4DD90", VA = "0x188C4F390", Slot = "6")]
		public int UDVENIWAVAX(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F240", Offset = "0x8C4DC40", VA = "0x188C4F240")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x89F19E0", Offset = "0x89F03E0", VA = "0x1889F19E0", Slot = "7")]
		private bool BHJVGJACQMS([Out] bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x89F19E0", Offset = "0x89F03E0", VA = "0x1889F19E0", Slot = "8")]
		private bool MYQKXLUPBMN([Out] bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xD812E0", Offset = "0xD7FCE0", VA = "0x180D812E0", Slot = "9")]
		private bool OGSUZFOHTTF([Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x89F19E0", Offset = "0x89F03E0", VA = "0x1889F19E0", Slot = "10")]
		private bool JREPRWWOMXO([Out] bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class HJESNAVDRRD : NSSWTVEFAJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public void EUTSXLADHBB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public HJESNAVDRRD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	internal class LDCLRAYZZOB : IYUBWGKKWTW, NYANHFVYJWD, CKGGJPDKIOP
	{
		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate void CalculateObjectPrefabTypesDelegate(List<Transform> transforms, NativeArray<ObjectPrefabType> prefabTypes, ObjectPrefabType rootPrefabType);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate void GetConnectableGraphDescendentArrayDelegate(SerializedDataWrapper serializedData, NativeParallelHashMap<Guid, LocalId> entityFromGuid, [Out] NativeArray<LocalId> entities, [Out] NativeArray<LocalId> parents, [Out] NativeArray<AuthoredLocalPoseData> poses, Allocator allocator);

		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public delegate bool IsValidConnectableGraphDelegate(SerializedDataWrapper serializedData, NativeParallelHashMap<Guid, LocalId> entityFromGuid, [Out] Exception exception);

		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		public delegate int GetPersistenceViewCountDelegate(SerializedDataWrapper serializedData);

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public delegate void GetViewDescriptorsDelegate(SerializedDataWrapper serializedData, NativeArray<ViewDescriptor> descriptors, NativeList<UniformTRS> descriptorTransforms);

		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		public delegate void ApplyAdditionalBakingDelegate(Transform transform, RRObjectPrefabData prefabData, QTUEFTEFCXF context);

		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		public delegate void RunPersistenceViewPrePostDeserializationDelegate(SerializedDataWrapper roomData, NativeArray<int> indices, TTRPJPMYOCH<GameObject> persistenceViewGameObjects, RentedArray<GameObject> allGameObjects, LoadType loadType);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private UMPPDVTIRUW XUXPHHQMESR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public CalculateObjectPrefabTypesDelegate ODFWSQAGDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public GetConnectableGraphDescendentArrayDelegate QSQUHZJAVAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public IsValidConnectableGraphDelegate FKABGNYONRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public GetPersistenceViewCountDelegate QHITTMTMCYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public GetViewDescriptorsDelegate VPMRCVSCANJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public ApplyAdditionalBakingDelegate TZJXBPBSVSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public RunPersistenceViewPrePostDeserializationDelegate VRIHKEYUGSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public Dictionary<Guid, string> PJQUPDYTANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public Dictionary<string, GameObject> OZDIZBVEGGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public GameObject ZCATFULIOVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public GameObject RTMBKSWYFOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public GameObject UBTSTUIDAPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public string[] OKOMDRDZOUY;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool HCYBNBVZAGC
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0xD42AB0", Offset = "0xD414B0", VA = "0x180D42AB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xDA8BA0", Offset = "0xDA75A0", VA = "0x180DA8BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool QWBAKMFUVOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x1676870", Offset = "0x1675270", VA = "0x181676870", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x16775A0", Offset = "0x1675FA0", VA = "0x1816775A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool XRNNOJLSYKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool CQRWGYFWIOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EBD0", Offset = "0x8C4D5D0", VA = "0x188C4EBD0")]
		public LDCLRAYZZOB(UMPPDVTIRUW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DFE0", Offset = "0x8C4C9E0", VA = "0x188C4DFE0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DCE0", Offset = "0x8C4C6E0", VA = "0x188C4DCE0", Slot = "31")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EB20", Offset = "0x8C4D520", VA = "0x188C4EB20", Slot = "32")]
		public void YXZKCJWJEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "13")]
		public int ORFQZKEWWVP(Guid a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DAC0", Offset = "0x8C4C4C0", VA = "0x188C4DAC0", Slot = "33")]
		public Guid GXUVVUXJODK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E910", Offset = "0x8C4D310", VA = "0x188C4E910", Slot = "10")]
		public Guid YOHPETKCJZR(Guid a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DE60", Offset = "0x8C4C860", VA = "0x188C4DE60", Slot = "14")]
		public bool QKMVIXKOXLI(string a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E880", Offset = "0x8C4D280", VA = "0x188C4E880", Slot = "15")]
		public string XUHDGIYMGUT(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x139F670", Offset = "0x139E070", VA = "0x18139F670", Slot = "16")]
		public bool WIYEZZFZKKA(RRObjectPrefabData a, [Out] LocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EB70", Offset = "0x8C4D570", VA = "0x188C4EB70", Slot = "17")]
		public RentedArray<byte[]> ZSUFMXKDJZL(NativeArray<ViewDescriptor> a)
		{
			return default(RentedArray<byte[]>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "18")]
		public void FOSWVWYPTLU(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DCF0", Offset = "0x8C4C6F0", VA = "0x188C4DCF0", Slot = "19")]
		public GameObject JFHNFUZBIFW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DC50", Offset = "0x8C4C650", VA = "0x188C4DC50", Slot = "20")]
		public void HFHAOFWASIZ(Transform a, RRObjectPrefabData b, QTUEFTEFCXF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E770", Offset = "0x8C4D170", VA = "0x188C4E770", Slot = "22")]
		public void WNUUGWCVFIQ(SerializedDataWrapper a, NativeParallelHashMap<Guid, LocalId> b, [Out] NativeArray<LocalId> c, [Out] NativeArray<LocalId> d, [Out] NativeArray<AuthoredLocalPoseData> e, Allocator f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E800", Offset = "0x8C4D200", VA = "0x188C4E800", Slot = "23")]
		public void WTKAVSQXUID(SerializedDataWrapper a, NativeArray<int> b, TTRPJPMYOCH<GameObject> c, RentedArray<GameObject> d, LoadType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DDC0", Offset = "0x8C4C7C0", VA = "0x188C4DDC0", Slot = "21")]
		public bool MBUNXLQRPXE(SerializedDataWrapper a, NativeParallelHashMap<Guid, LocalId> b, [Out] Exception c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D9F0", Offset = "0x8C4C3F0", VA = "0x188C4D9F0", Slot = "8")]
		public string[] GINWXDRCGDO(SerializedDataWrapper a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "9")]
		public void HMHEHXSJAHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DD70", Offset = "0x8C4C770", VA = "0x188C4DD70", Slot = "11")]
		public int JIRHUZSOGLN(SerializedDataWrapper a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DC90", Offset = "0x8C4C690", VA = "0x188C4DC90", Slot = "12")]
		public void IQLZNDRCYVJ(SerializedDataWrapper a, NativeArray<ViewDescriptor> b, NativeList<UniformTRS> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "24")]
		public void IJQOKGIFBAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "25")]
		public void YUBTLKBPVAG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	internal class BCVXNDACWYP : HXAVHJPFNDG, UMPPDVTIRUW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private System.Random ALKCAXELTXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private Lifetime CVQYZQPZJFG;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public long ZVFJYJBFTHW
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xE05990", Offset = "0xE04390", VA = "0x180E05990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public long VJBDXBTPUFV
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DB0", Offset = "0xCD57B0", VA = "0x180CD6DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8C4BB10", Offset = "0x8C4A510", VA = "0x188C4BB10")]
		public BCVXNDACWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8C4B9C0", Offset = "0x8C4A3C0", VA = "0x188C4B9C0")]
		private long FNRKXFJANIG()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8C4BA40", Offset = "0x8C4A440", VA = "0x188C4BA40", Slot = "4")]
		public void WWLZSUURJBA(GEZRGCKOUXX a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public class GVQKFMXTEIY : DNVGZPWWZFZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public GVQKFMXTEIY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public class MOSMUAXHGTQ : DINHUSHSMKF
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool SPDBCLOYTFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xD2C460", Offset = "0xD2AE60", VA = "0x180D2C460", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool OKWUTDXXGFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0xDE6AF0", Offset = "0xDE54F0", VA = "0x180DE6AF0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool IBGLJLZTYRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2B10860", Offset = "0x2B0F260", VA = "0x182B10860", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public MOSMUAXHGTQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public class UCGMQAUBVYH : NDLHZRTHZLO
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool ISZNRAMYENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool VHNJIAREFGW
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int DEFXUMZPRAG
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xD268A0", Offset = "0xD252A0", VA = "0x180D268A0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int FQZBROFXIRE
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xCD5110", Offset = "0xCD3B10", VA = "0x180CD5110", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int UOLXBGAQJPF
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool YKWIDTKZOJH
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x166B820", Offset = "0x166A220", VA = "0x18166B820", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int HAGQTDWDBJP
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "12")]
		public bool WOMTNXZWKQX(PlayerId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "28")]
		public void TQZNBSQBJPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "29")]
		public void IPYZCDVYBNA(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "30")]
		public void OXSDDWRMIMS(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "20")]
		public void BADJPSFBZWK(OutOfBandMessageType a, ReadOnlySpan<byte> b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "15")]
		public void XQWSSDZGZDH(Action<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "16")]
		public void HCCMBQJSIMG(Action<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public UCGMQAUBVYH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public class VDVQSBTMYLS : VCRCANDWLIT
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public VDVQSBTMYLS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	internal class MockNetworkTransform : MonoBehaviour, TJBESGYVVPB, BPOGCCOGSZL, RGDMHXKKORI
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ViewId UVUYELVZKWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(ViewId);
			}
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0xD29750", Offset = "0xD28150", VA = "0x180D29750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EC70", Offset = "0x8C4D670", VA = "0x188C4EC70", Slot = "11")]
		public void Bake(QTUEFTEFCXF context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public void Initialize(ObjectNetworkId parent, Vector3 localPosition, Quaternion localRotation, Vector3 worldScale, bool isSpawnLocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
		public void SetTransformData(Vector3 localPosition, Quaternion localRotation, Vector3 worldScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "6")]
		public void SetParent(ViewId parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
		public void SetWantsToBePhysicsDriven(bool wantsToBePhysicsDriven)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
		public void SetIsNearPositionBounds(bool isNearPositionBounds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		public MockNetworkTransform()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public class REMRHEQCEYL : DIEIHUXTWTA
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public REMRHEQCEYL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal class MockNetworkView : MonoBehaviour, RLCLHHZLKYQ, BPOGCCOGSZL, RRPJFMYHBXQ, RGDMHXKKORI
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ViewId UVUYELVZKWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(ViewId);
			}
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0xD29750", Offset = "0xD28150", VA = "0x180D29750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public ViewId KRPIJWVLIBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0xCFE110", Offset = "0xCFCB10", VA = "0x180CFE110")]
			[CompilerGenerated]
			get
			{
				return default(ViewId);
			}
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0xEE9BC0", Offset = "0xEE85C0", VA = "0x180EE9BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Dictionary<int, object> VIFCTJOJZEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xCD8620", Offset = "0xCD7020", VA = "0x180CD8620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8C4ED50", Offset = "0x8C4D750", VA = "0x188C4ED50", Slot = "4")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
		public void OnWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4ECE0", Offset = "0x8C4D6E0", VA = "0x188C4ECE0", Slot = "9")]
		public void Bake(QTUEFTEFCXF context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		public MockNetworkView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public class ILRSZZYNLXV : BBPHRQMGZIU
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public void XQTYCTEOWIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public ILRSZZYNLXV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal class LJRHSHOUCRI : RMDBQMTXUYT
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public void DGGLDVWOCTR(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
		public void NFNQOFMXKEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "6")]
		public void VOHXXMMFUMU(bool a, string b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public LJRHSHOUCRI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public class DZOVUSYMQJW : SKXZSLVQFMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public GameObject SYLHKQLEBTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public GameObject OTFFOMNHMEL;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C3C0", Offset = "0x8C4ADC0", VA = "0x188C4C3C0", Slot = "4")]
		public Transform GetTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C320", Offset = "0x8C4AD20", VA = "0x188C4C320", Slot = "5")]
		public Collider GetCollider()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C440", Offset = "0x8C4AE40", VA = "0x188C4C440", Slot = "6")]
		public void MoveToObject(ObjectLocalId newObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C480", Offset = "0x8C4AE80", VA = "0x188C4C480", Slot = "7")]
		public void NotifyIsUniform(bool isUniform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C310", Offset = "0x8C4AD10", VA = "0x188C4C310", Slot = "8")]
		public void DestroyCollider()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "9")]
		public void YMAZCVEKABO(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public DZOVUSYMQJW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	internal class FIWAQAIEUCU : KJQINAVMXUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private FJKHTKMOEYF VQHFZNOAINY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private Dictionary<GameObject, int> BSVHFJOMEWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private Dictionary<GameObject, Action<ObjectLocalId, int>> VAURKOVLGPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public Func<int, bool> INCLWKFYPAP;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4CD00", Offset = "0x8C4B700", VA = "0x188C4CD00")]
		public FIWAQAIEUCU(FJKHTKMOEYF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C7E0", Offset = "0x8C4B1E0", VA = "0x188C4C7E0", Slot = "4")]
		public int GCQUCCHLUCB(GameObject a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C9A0", Offset = "0x8C4B3A0", VA = "0x188C4C9A0", Slot = "5")]
		public void LDYEGCRATQK(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4CAF0", Offset = "0x8C4B4F0", VA = "0x188C4CAF0", Slot = "8")]
		public object QBTTHICLCDT(ObjectLocalId a, GameObject b, Action<ObjectLocalId, int> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4CA90", Offset = "0x8C4B490", VA = "0x188C4CA90", Slot = "9")]
		public void LGNWOLPPWFK(GameObject a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4CB60", Offset = "0x8C4B560", VA = "0x188C4CB60", Slot = "6")]
		public void TransferOwnership(GameObject gameObject, int newOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8C4CCE0", Offset = "0x8C4B6E0", VA = "0x188C4CCE0", Slot = "7")]
		public bool WWGAKYBSOWH(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C850", Offset = "0x8C4B250", VA = "0x188C4C850")]
		private void GKWNRKOURUN(GameObject a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class LWRUOGNFIYP : LVPZFDQEWCC, HWCJESQYILK
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public TSENLTSRTYN LEMRIHNEZIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EC10", Offset = "0x8C4D610", VA = "0x188C4EC10", Slot = "5")]
		public void InitReferences(GEZRGCKOUXX services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public LWRUOGNFIYP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public class YPARPGAMKST : BGRHIWCMJRQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "4")]
		public bool YGXULAHDPTH(NetworkCreatorId a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
		public void WUMRJVWHLAX(PlayerId a, AccountRoleTypeNetworked b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public YPARPGAMKST()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class RBHYMLYUFRJ : QNQIFEHYWYM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public Action<object, NativeList<byte>> XCXLHFAGGDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public Func<NativeArray<byte>, object> JCDBGAZZKGZ;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x13AA760", Offset = "0x13A9160", VA = "0x1813AA760", Slot = "4")]
		public void BGVSXQNQAUM(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FC00", Offset = "0x8C4E600", VA = "0x188C4FC00", Slot = "5")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FD50", Offset = "0x8C4E750", VA = "0x188C4FD50")]
		public static void KTLJASVAJML(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FC40", Offset = "0x8C4E640", VA = "0x188C4FC40")]
		public static object EODLECZMVGO(NativeArray<byte> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FF50", Offset = "0x8C4E950", VA = "0x188C4FF50")]
		private static void SISZBYWUTCR(NativeList<byte> a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F950", Offset = "0x8C4E350", VA = "0x188C4F950")]
		private static object DWMISJDBTWO(NativeArray<byte> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FD70", Offset = "0x8C4E770", VA = "0x188C4FD70")]
		private static void KTWHOBXWTKF(NativeList<byte> a, Dictionary<int, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FC50", Offset = "0x8C4E650", VA = "0x188C4FC50")]
		private static Dictionary<int, object> JUPPAYFUMRI(NativeArray<byte> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C6F0", Offset = "0x3E0B0F0", VA = "0x183E0C6F0")]
		private static void SISZBYWUTCR<T>(NativeList<byte> a, T b, byte c) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C070", Offset = "0x3E0AA70", VA = "0x183E0C070")]
		private static void DGCXIPMAXYS<T>(NativeList<byte> a, T b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8C50240", Offset = "0x8C4EC40", VA = "0x188C50240")]
		private static void SNQOLROAOYI(NativeList<byte> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C220", Offset = "0x3E0AC20", VA = "0x183E0C220")]
		private static T DWMISJDBTWO<T>(NativeArray<byte> a) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8C50290", Offset = "0x8C4EC90", VA = "0x188C50290")]
		public RBHYMLYUFRJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public class JEJYUNHGVRO : XQTGYQRUXKX
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool SYZUYZYRBFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "5")]
		public Delegate CCOTPKKIGII(RLCLHHZLKYQ a, Action<RLCLHHZLKYQ> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "6")]
		public void TBANROFZMOB(RLCLHHZLKYQ a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "7")]
		public Delegate QUBTAQWNGNL(RLCLHHZLKYQ a, Action<RLCLHHZLKYQ> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
		public void BHGPFJJDRGV(RLCLHHZLKYQ a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "9")]
		public bool QQGQFHDBUDE(RLCLHHZLKYQ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "10")]
		public RLCLHHZLKYQ UHORLSBNMWI(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public JEJYUNHGVRO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public class IVYAQKLYBJK : YPSABMUQYZJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public void GPNQZIJAGVX(ObjectLocalId a, CollisionLayerEnum b, bool c, PhysicsModelEnumFlags d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
		public void METRGSAUCHP(ObjectLocalId a, CollisionLayerEnum b, bool c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "6")]
		public URKKLPUAJNQ SDOSLICFETR(ObjectLocalId a, List<ObjectLocalId> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D4E0", Offset = "0x8C4BEE0", VA = "0x188C4D4E0", Slot = "7")]
		public SKXZSLVQFMH LKTHLMFBEWM(GameObject a, GameObject b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
		public void CPHOUYVHUAQ(GameObject a, List<GameObject> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "9")]
		public void RRKAYXTGKJQ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x3B35330", Offset = "0x3B33D30", VA = "0x183B35330", Slot = "10")]
		public a FQZBNOWZVLP<a>(GameObject a) where a : Collider
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D190", Offset = "0x8C4BB90", VA = "0x188C4D190", Slot = "11")]
		public void HBRSKFGJPGF(Collider a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3B35380", Offset = "0x3B33D80", VA = "0x183B35380", Slot = "12")]
		public GameObject ZWFVAQPKPQD<b>(string a) where b : Collider
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D580", Offset = "0x8C4BF80", VA = "0x188C4D580", Slot = "13")]
		public bool XAZQODMMSMC(Collider a, [Out] ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D570", Offset = "0x8C4BF70", VA = "0x188C4D570", Slot = "14")]
		public bool PXSOKGSGSWG(ObjectLocalId a, [Out] ObjectLocomotionSettings b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D400", Offset = "0x8C4BE00", VA = "0x188C4D400", Slot = "15")]
		public NativeArray<ColliderType> IFDWRIEURVC(Allocator a = Allocator.TempJob)
		{
			return default(NativeArray<ColliderType>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8C4D1A0", Offset = "0x8C4BBA0", VA = "0x188C4D1A0", Slot = "16")]
		public UnityEngine.Mesh[] HSJGQJHTUFU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public IVYAQKLYBJK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	internal class NEVAZRELDVK : FJKHTKMOEYF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public int GHLAKOBTLZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public int ONRGKMJSAXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public Vector3 RWVTTKDKAFI;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int OXQRBWYZXGF
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xCD5110", Offset = "0xCD3B10", VA = "0x180CD5110", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int QAHWPTMMLZA
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xDF2410", Offset = "0xDF0E10", VA = "0x180DF2410", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool ISZNRAMYENF
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8C4EE70", Offset = "0x8C4D870", VA = "0x188C4EE70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool SWAKGYHELPC
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xEC8BA0", Offset = "0xEC75A0", VA = "0x180EC8BA0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool HLZWHVGULVR
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x1662AD0", Offset = "0x16614D0", VA = "0x181662AD0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EE80", Offset = "0x8C4D880", VA = "0x188C4EE80")]
		public NEVAZRELDVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EEC0", Offset = "0x8C4D8C0", VA = "0x188C4EEC0")]
		public NEVAZRELDVK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "9")]
		public ObjectLocalId FDZGJFKHTGR(int a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "10")]
		public void WQQSUBKMRTD(GameObject a, JobHandle b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public class CAWCNXQCSAK : TSENLTSRTYN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "4")]
		public bool RCKLUPOGTOJ(AccountRoleTypeNetworked a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public CAWCNXQCSAK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public class FKUYNPHYRIY : MYERTIPPPDP
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool OWWGNOQLBRY
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public FKUYNPHYRIY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public class RPFNSWIYNBU : OQEOZHHCYYT, CKGGJPDKIOP
	{
		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		private class YGXWOFQXAWD : LRSEXBWVLEA, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public bool KQCMCJMYFHB
			{
				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "15")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "4")]
			public RootHandle NSULOYNGZTT(GHGKCTVYTDD a)
			{
				return default(RootHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "5")]
			public RootHandle NSULOYNGZTT(GHGKCTVYTDD a, bool b)
			{
				return default(RootHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "6")]
			public void LDASENKWELI(RootHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
			public void PHQXGYYBKOH(RootHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "8")]
			public ShapeHandle LXRSSFEHJOO(RootHandle a, VWWKICUWIHI b)
			{
				return default(ShapeHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "9")]
			public ShapeHandle FDLREKFNCOI(RootHandle a, GHRGTMSYLYY b)
			{
				return default(ShapeHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "10")]
			public void YVBKZOOVBWH(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "11")]
			public void XPALAJPDSII(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "12")]
			public SkinnedCostumeHandle FJDNWGCDSKE(VMZZSLWWNFJ a)
			{
				return default(SkinnedCostumeHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "13")]
			public void VXAOUWJCXWI(SkinnedCostumeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "14")]
			public void JBIWBTCJCND(SkinnedCostumeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C120", Offset = "0x8C5AB20", VA = "0x188C5C120", Slot = "16")]
			public Task BRNMRVHBTXF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C2E0", Offset = "0x8C5ACE0", VA = "0x188C5C2E0", Slot = "17")]
			public Task VTEQPVOMQBH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C250", Offset = "0x8C5AC50", VA = "0x188C5C250", Slot = "18")]
			public Task SIXZJIGSQAY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "19")]
			public void BJJZXPOCYSL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x8C5C1B0", Offset = "0x8C5ABB0", VA = "0x188C5C1B0", Slot = "20")]
			public IEnumerable<Renderer> EQKSRNTNULS(RootHandle a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "21")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public YGXWOFQXAWD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		private class LPXBYVDSZDH : CAGXUDPLLGC, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
			public void FLQEGJSRZUY(RootHandle a, OutlineEffectType b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			public void FLQEGJSRZUY(ShapeHandle a, OutlineEffectType b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "6")]
			public void GQHJFRLGNMI(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
			public void RLVBGVYKHPQ(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
			public void JYOPZFFSODY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "9")]
			public void WLURYLCKFGG(OutlineEffectType a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "10")]
			public void PQHOMSSYRSJ(RootHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "11")]
			public void PQHOMSSYRSJ(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "12")]
			public void HLCRDBYQJLS(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "13")]
			public void EVAUSVBJGBQ(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "14")]
			public void BGJQYOPTBGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "15")]
			public void CEMRIGHDWCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "16")]
			public void QVNBNOSBVIY(RootHandle a, SelectionEffectType b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "17")]
			public void LKGHXJUTXAY(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "18")]
			public void AMEZRLZOBMW(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "19")]
			public void AWLZQRLWFLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "20")]
			public void VSNUHLTKLYK(SelectionEffectType a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "21")]
			public void MSJAESIXDTU(RootHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f, IReadOnlyList<UnityEngine.Camera> g, IgnoreEffectType h)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "22")]
			public void MSJAESIXDTU(SkinnedCostumeHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "23")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public LPXBYVDSZDH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public LRSEXBWVLEA ABKELZNJRYH
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public CAGXUDPLLGC PKQNOMIFUGB
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C00", Offset = "0xCD5600", VA = "0x180CD6C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool LYOKYUPTGEX
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C504A0", Offset = "0x8C4EEA0", VA = "0x188C504A0")]
		public RPFNSWIYNBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
		public void KMTGJADTBBD(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
		public void PQNSLMSXBAN(Transform a, SelectionEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "9")]
		public void KAONMBWMEOF(Transform a, OutlineEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8C50440", Offset = "0x8C4EE40", VA = "0x188C50440", Slot = "10")]
		public void YXZKCJWJEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8C50360", Offset = "0x8C4ED60", VA = "0x188C50360")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	internal class MockRigidbodyEx : MonoBehaviour, BADBXNYBQWB, RGDMHXKKORI
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool JEIMMTHXRHO
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xCD7520", Offset = "0xCD5F20", VA = "0x180CD7520", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C40", Offset = "0xCD5640", VA = "0x180CD6C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public URSPHDVDGTJ YKGEBWWIRUA
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0xCD8620", Offset = "0xCD7020", VA = "0x180CD8620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Transform LDQSLDZRTBT
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xCFF030", Offset = "0xCFDA30", VA = "0x180CFF030", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Transform MRSJCBHJEAB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0xCFF030", Offset = "0xCFDA30", VA = "0x180CFF030", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xCD8620", Offset = "0xCD7020", VA = "0x180CD8620", Slot = "8")]
		public void SetImplementation(URSPHDVDGTJ impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B105B0", Offset = "0x2B0EFB0", VA = "0x182B105B0", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C4ED70", Offset = "0x8C4D770", VA = "0x188C4ED70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EE20", Offset = "0x8C4D820", VA = "0x188C4EE20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EDD0", Offset = "0x8C4D7D0", VA = "0x188C4EDD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EDC0", Offset = "0x8C4D7C0", VA = "0x188C4EDC0", Slot = "11")]
		private void FFHAUBOMLON(QTUEFTEFCXF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		public MockRigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x1504000", Offset = "0x1502A00", VA = "0x181504000", Slot = "4")]
		private GameObject CQOTFVBLUYM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xCFF030", Offset = "0xCFDA30", VA = "0x180CFF030", Slot = "5")]
		private Transform MEIYQSWXJWT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public class OLGDTGVIIYD : AZBOQHHXBLU
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action JOXJZLUOGZM
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8C4EFA0", Offset = "0x8C4D9A0", VA = "0x188C4EFA0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8C4EF00", Offset = "0x8C4D900", VA = "0x188C4EF00", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public OLGDTGVIIYD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class ZTGLMZEBCAB : HQQMSHQWTYS
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public void XBOWJWJZMHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public ZTGLMZEBCAB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public class OAENJCQGKUQ : NCBNOXVHZDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public void CVOPGPDGVEZ(GameObject a, ObjectPolicyUserConfigurableFlags b, CircuitsTransformBehavior c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "5")]
		public bool DGWJQOMRSMI(ObjectLocalId a, bool b, float3 c, quaternion d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "6")]
		public bool AIIEKBKGVAF(NativeObjectLocalIdArray a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "9")]
		public void RNQWIIHTRTG(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
		public void DIEPFBUXCEH(RRObject a, RRObject b, ReferenceGroupKind c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "8")]
		public void QHNUQDPDOCH(RRObject a, ReferenceGroupKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "10")]
		public void BTIGYRDPMRD(SerializedDataWrapper a, ReadOnlySpan<Guid> b, ReadOnlySpan<int> c, RentedArray<GameObject> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "11")]
		public void NFPDXFNJRRJ(EEKXAPFIXBA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "12")]
		public void DNOJYZXMVTW(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "13")]
		public void YZOTAEIUGGF(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "14")]
		public void YJZLXWYILJP(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public OAENJCQGKUQ()
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
