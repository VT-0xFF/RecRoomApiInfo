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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0x8DCDEB0", Offset = "0x8DCCEB0", VA = "0x188DCDEB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD34A60", Offset = "0xD33A60", VA = "0x180D34A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AA0", Offset = "0xD33AA0", VA = "0x180D34AA0")]
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
	PlayerSaveData
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class DDLSDILAQRF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum AssetType
		{
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			Invalid,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			Image,
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			Holotar,
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			AudioSampler,
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			CV2Holotar,
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			CV2Audio,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			SuperRoomData,
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			MeshGen
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private delegate Task BatchProcessTaskFactory(HVXLQSVPRNV client, ExecutionArgs executionArgs, AssetExport assetExport, MSTCLKGZNJL dataExportOptions, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class LJJKEYXUJUX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly List<Task> ZLAPGLANKRI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly List<AssetExport> FUMFHHHKNSV;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public int LHDUJAQMHJJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x8DCDAA0", Offset = "0x8DCCAA0", VA = "0x188DCDAA0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public IReadOnlyList<Task> CJKPGJGPEXU
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8DCD920", Offset = "0x8DCC920", VA = "0x188DCD920")]
			public void Add(AssetExport taskKey, Task newTask)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8DCDAE0", Offset = "0x8DCCAE0", VA = "0x188DCDAE0")]
			public bool Remove(Task task, [Out] AssetExport key)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8DCDC10", Offset = "0x8DCCC10", VA = "0x188DCDC10")]
			public LJJKEYXUJUX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private struct AssetExport : IEquatable<AssetExport>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public readonly AssetType AssetType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public readonly string AssetBlobName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public readonly ExportPath ExportPath;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly bool GroupExportByAssetType;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9040", Offset = "0x8DC8040", VA = "0x188DC9040")]
			public AssetExport(AssetType assetType, string assetBlobName, ExportPath exportPath, bool groupExportByAssetType = true)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8DC8EE0", Offset = "0x8DC7EE0", VA = "0x188DC8EE0", Slot = "4")]
			public bool Equals(AssetExport other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8DC8E30", Offset = "0x8DC7E30", VA = "0x188DC8E30", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8DC8FB0", Offset = "0x8DC7FB0", VA = "0x188DC8FB0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class FYMUBABGJPV
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			private struct <<FetchAndWriteImage>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public FYMUBABGJPV <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public CancellationToken ct;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x8DD9FB0", Offset = "0x8DD8FB0", VA = "0x188DD9FB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x8DDA1B0", Offset = "0x8DD91B0", VA = "0x188DDA1B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public HVXLQSVPRNV ZDHHUSPCQXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AssetExport XYPXYBLHWXA;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public FYMUBABGJPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8DCD500", Offset = "0x8DCC500", VA = "0x188DCD500")]
			[AsyncStateMachine(typeof(<<FetchAndWriteImage>b__0>d))]
			internal Task<byte[]> MNEYFGKLYHT(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JRFIKRCKNGU
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private struct <<FetchAndWriteLegacyAudio>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public JRFIKRCKNGU <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public CancellationToken ct;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x8DDA220", Offset = "0x8DD9220", VA = "0x188DDA220", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x8DDA420", Offset = "0x8DD9420", VA = "0x188DDA420", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public HVXLQSVPRNV ZDHHUSPCQXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public AssetExport XYPXYBLHWXA;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public JRFIKRCKNGU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8DCD810", Offset = "0x8DCC810", VA = "0x188DCD810")]
			[AsyncStateMachine(typeof(<<FetchAndWriteLegacyAudio>b__0>d))]
			internal Task<byte[]> TWMXLSIVWIL(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class EUKHXKXCZPT
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			private struct <<FetchAndWriteLegacyHolotar>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public EUKHXKXCZPT <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public CancellationToken ct;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x8DDA490", Offset = "0x8DD9490", VA = "0x188DDA490", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x8DDA690", Offset = "0x8DD9690", VA = "0x188DDA690", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public HVXLQSVPRNV ZDHHUSPCQXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AssetExport XYPXYBLHWXA;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public EUKHXKXCZPT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8DCC020", Offset = "0x8DCB020", VA = "0x188DCC020")]
			[AsyncStateMachine(typeof(<<FetchAndWriteLegacyHolotar>b__0>d))]
			internal Task<byte[]> UTTRZFPEFUQ(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class QPBHAOXKDWK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			private struct <<FetchAndWriteCV2Audio>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				public QPBHAOXKDWK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public CancellationToken ct;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x8DD9AD0", Offset = "0x8DD8AD0", VA = "0x188DD9AD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x8DD9CD0", Offset = "0x8DD8CD0", VA = "0x188DD9CD0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public HVXLQSVPRNV ZDHHUSPCQXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public AssetExport XYPXYBLHWXA;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QPBHAOXKDWK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8DCF860", Offset = "0x8DCE860", VA = "0x188DCF860")]
			[AsyncStateMachine(typeof(<<FetchAndWriteCV2Audio>b__0>d))]
			internal Task<byte[]> TIZZHVONRNH(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class VIHYUHFKEDV
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			private struct <<FetchAndWriteCV2Holotar>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public VIHYUHFKEDV <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				public CancellationToken ct;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400003E")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x8DD9D40", Offset = "0x8DD8D40", VA = "0x188DD9D40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x8DD9F40", Offset = "0x8DD8F40", VA = "0x188DD9F40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public HVXLQSVPRNV ZDHHUSPCQXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public AssetExport XYPXYBLHWXA;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VIHYUHFKEDV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8DE1BF0", Offset = "0x8DE0BF0", VA = "0x188DE1BF0")]
			[AsyncStateMachine(typeof(<<FetchAndWriteCV2Holotar>b__0>d))]
			internal Task<byte[]> FSZNHJRDUNU(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class BBRTNTVYVYU
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			private struct <<FetchAndWriteMeshGen>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000041")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000042")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000043")]
				public BBRTNTVYVYU <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000044")]
				public CancellationToken ct;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000045")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x8DDA700", Offset = "0x8DD9700", VA = "0x188DDA700", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x8DDA900", Offset = "0x8DD9900", VA = "0x188DDA900", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public HVXLQSVPRNV ZDHHUSPCQXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public AssetExport XYPXYBLHWXA;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public BBRTNTVYVYU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9090", Offset = "0x8DC8090", VA = "0x188DC9090")]
			[AsyncStateMachine(typeof(<<FetchAndWriteMeshGen>b__0>d))]
			internal Task<byte[]> UUWKQFRSMVH(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class DLHXWDANTXX
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			private struct <<FetchAndWriteSuperRoomData>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				public DLHXWDANTXX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public CancellationToken ct;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x8DDA970", Offset = "0x8DD9970", VA = "0x188DDA970", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x8DDAB70", Offset = "0x8DD9B70", VA = "0x188DDAB70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public HVXLQSVPRNV ZDHHUSPCQXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AssetExport XYPXYBLHWXA;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public DLHXWDANTXX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8DCBB30", Offset = "0x8DCAB30", VA = "0x188DCBB30")]
			[AsyncStateMachine(typeof(<<FetchAndWriteSuperRoomData>b__0>d))]
			internal Task<byte[]> AXYNCCPCYLE(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class YYTPHXDUXQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public KDPPVFHAXNU.IXMMFLJZFJQ TBIWUCZURQB;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public YYTPHXDUXQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8DE1D00", Offset = "0x8DE0D00", VA = "0x188DE1D00")]
			internal QVMHMSXVEGX KUNKJAHQFQD(IGrouping<AssetType, AssetExport> a)
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
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public XDSPFZNLMNK progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public IReadOnlyList<AssetExport> assetExportsToProcess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public BatchProcessTaskFactory taskFactory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public HVXLQSVPRNV client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public MSTCLKGZNJL dataExportOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public string progressLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private KDPPVFHAXNU.NEISSKDPEKU<QVMHMSXVEGX> <simple>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <totalCount>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int <completedCount>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private LJJKEYXUJUX <inProgressTasks>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private List<AssetExport> <modifiableList>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private AssetExport <taskKey>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private TaskAwaiter<Task> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private object <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int <>7__wrap8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8DD0810", Offset = "0x8DCF810", VA = "0x188DD0810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8DD1EC0", Offset = "0x8DD0EC0", VA = "0x188DD1EC0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public DDLSDILAQRF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public XDSPFZNLMNK progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public HVXLQSVPRNV client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public MSTCLKGZNJL dataExportOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private YYTPHXDUXQN <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private List<IGrouping<AssetType, AssetExport>> <groups>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private QVMHMSXVEGX[] <stepProgressables>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private int <index>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private QVMHMSXVEGX <stepProgress>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private IGrouping<AssetType, AssetExport> <trackedAssetGroup>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8DD4850", Offset = "0x8DD3850", VA = "0x188DD4850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8DD57F0", Offset = "0x8DD47F0", VA = "0x188DD57F0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public HVXLQSVPRNV client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AssetExport assetExport;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private QPBHAOXKDWK <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public MSTCLKGZNJL dataExportOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private ReadOnlySequence<byte> <blobDataBytes>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8DD5850", Offset = "0x8DD4850", VA = "0x188DD5850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8DD6000", Offset = "0x8DD5000", VA = "0x188DD6000", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public HVXLQSVPRNV client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AssetExport assetExport;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private VIHYUHFKEDV <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public MSTCLKGZNJL dataExportOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private ReadOnlySequence<byte> <blobDataBytes>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8DD6060", Offset = "0x8DD5060", VA = "0x188DD6060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8DD6810", Offset = "0x8DD5810", VA = "0x188DD6810", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public HVXLQSVPRNV client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public AssetExport assetExport;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private FYMUBABGJPV <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8DD6870", Offset = "0x8DD5870", VA = "0x188DD6870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8DD6E80", Offset = "0x8DD5E80", VA = "0x188DD6E80", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public HVXLQSVPRNV client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public AssetExport assetExport;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private JRFIKRCKNGU <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public MSTCLKGZNJL dataExportOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private ReadOnlySequence<byte> <blobDataBytes>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8DD6EE0", Offset = "0x8DD5EE0", VA = "0x188DD6EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8DD7690", Offset = "0x8DD6690", VA = "0x188DD7690", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public HVXLQSVPRNV client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AssetExport assetExport;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private EUKHXKXCZPT <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public MSTCLKGZNJL dataExportOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private ReadOnlySequence<byte> <blobDataBytes>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8DD76F0", Offset = "0x8DD66F0", VA = "0x188DD76F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8DD7EA0", Offset = "0x8DD6EA0", VA = "0x188DD7EA0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public HVXLQSVPRNV client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AssetExport assetExport;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private BBRTNTVYVYU <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8DD7F00", Offset = "0x8DD6F00", VA = "0x188DD7F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8DD8400", Offset = "0x8DD7400", VA = "0x188DD8400", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public HVXLQSVPRNV client;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AssetExport assetExport;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public MSTCLKGZNJL dataExportOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private DLHXWDANTXX <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public DDLSDILAQRF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private ReadOnlySequence<byte> <rawBytes>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private SuperRoomData <superRoomData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private TaskAwaiter<ReadOnlySequence<byte>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8DD8460", Offset = "0x8DD7460", VA = "0x188DD8460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8DD8F90", Offset = "0x8DD7F90", VA = "0x188DD8F90", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public AsyncTaskMethodBuilder<ReadOnlySequence<byte>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string assetName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public Func<CancellationToken, Task<byte[]>> taskFactory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private ReadOnlySequence<byte> <byteSequence>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private TaskAwaiter<byte[]> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8DDAC50", Offset = "0x8DD9C50", VA = "0x188DDAC50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8DDB330", Offset = "0x8DDA330", VA = "0x188DDB330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly HashSet<AssetExport> BCDKBZLVHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Queue<AssetExport> YIBOBFNQUUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool JXGMUQXHWQB;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8DCA820", Offset = "0x8DC9820", VA = "0x188DCA820")]
		public void GCBKSMEQQIQ(AssetType a, string b, ExportPath c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8DCB0F0", Offset = "0x8DCA0F0", VA = "0x188DCB0F0")]
		[AsyncStateMachine(typeof(<FetchAndWriteAllAssets>d__5))]
		public Task PJIRATDFTYG(HVXLQSVPRNV a, ExecutionArgs b, XDSPFZNLMNK c, MSTCLKGZNJL d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8DCB570", Offset = "0x8DCA570", VA = "0x188DCB570")]
		private void UYAVSVLLBDG(AssetExport a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8DCB690", Offset = "0x8DCA690", VA = "0x188DCB690")]
		private int VVMQWUUYTNV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8DCA950", Offset = "0x8DC9950", VA = "0x188DCA950")]
		private int HXAFFNBLFZA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8DCB760", Offset = "0x8DCA760", VA = "0x188DCB760")]
		[AsyncStateMachine(typeof(<BatchProcessAssetExports>d__11))]
		private static Task XGNFRPXPXJI(HVXLQSVPRNV a, ExecutionArgs b, IReadOnlyList<AssetExport> c, BatchProcessTaskFactory d, MSTCLKGZNJL e, XDSPFZNLMNK f, string g, CancellationToken h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8DCB270", Offset = "0x8DCA270", VA = "0x188DCB270")]
		[AsyncStateMachine(typeof(<FetchAndWriteImage>d__12))]
		private Task QJGLJMBUGKJ(HVXLQSVPRNV a, ExecutionArgs b, AssetExport c, MSTCLKGZNJL d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8DCAE00", Offset = "0x8DC9E00", VA = "0x188DCAE00")]
		[AsyncStateMachine(typeof(<FetchAndWriteLegacyAudio>d__13))]
		private Task KXXWKKVUSSX(HVXLQSVPRNV a, ExecutionArgs b, AssetExport c, MSTCLKGZNJL d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8DCA6A0", Offset = "0x8DC96A0", VA = "0x188DCA6A0")]
		[AsyncStateMachine(typeof(<FetchAndWriteLegacyHolotar>d__14))]
		private Task FUADTSCGSQS(HVXLQSVPRNV a, ExecutionArgs b, AssetExport c, MSTCLKGZNJL d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8DCAC80", Offset = "0x8DC9C80", VA = "0x188DCAC80")]
		[AsyncStateMachine(typeof(<FetchAndWriteCV2Audio>d__15))]
		private Task JODUZGITONH(HVXLQSVPRNV a, ExecutionArgs b, AssetExport c, MSTCLKGZNJL d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8DCAB00", Offset = "0x8DC9B00", VA = "0x188DCAB00")]
		[AsyncStateMachine(typeof(<FetchAndWriteCV2Holotar>d__16))]
		private Task JCYQFRXSAEY(HVXLQSVPRNV a, ExecutionArgs b, AssetExport c, MSTCLKGZNJL d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8DCB900", Offset = "0x8DCA900", VA = "0x188DCB900")]
		[AsyncStateMachine(typeof(<FetchAndWriteMeshGen>d__17))]
		private Task YIHSFOATCOB(HVXLQSVPRNV a, ExecutionArgs b, AssetExport c, MSTCLKGZNJL d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8DCB3E0", Offset = "0x8DCA3E0", VA = "0x188DCB3E0")]
		[AsyncStateMachine(typeof(<FetchAndWriteSuperRoomData>d__18))]
		private Task RSCNPPZJAJK(HVXLQSVPRNV a, ExecutionArgs b, AssetExport c, MSTCLKGZNJL d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8DCAF80", Offset = "0x8DC9F80", VA = "0x188DCAF80")]
		[AsyncStateMachine(typeof(<WrapFetchTask>d__19))]
		private static Task<ReadOnlySequence<byte>> LAJNYVQMOXL(ExecutionArgs a, Func<CancellationToken, Task<byte[]>> b, string c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8DCBA70", Offset = "0x8DCAA70", VA = "0x188DCBA70")]
		public DDLSDILAQRF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ASMKKOWSYWQ<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly int KCBZXODVYAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly string[] IOQDMQYNJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public readonly HashSet<a> FKCFIZZCBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public readonly List<string[]> MHTXRTKMPZP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int LHDUJAQMHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x72F1540", Offset = "0x72F0540", VA = "0x1872F1540")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x72F1F50", Offset = "0x72F0F50", VA = "0x1872F1F50")]
		public ASMKKOWSYWQ(params string[] columnHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x72F1560", Offset = "0x72F0560", VA = "0x1872F1560")]
		public void KBAPQGYRZMF(a a, params string[] row)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x72F1DC0", Offset = "0x72F0DC0", VA = "0x1872F1DC0")]
		public string OBKWFVOKICC(string a = ",")
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public abstract class SLYZSIFEEGC<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class FYMUBABGJPV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public object ZCFSTSSYJNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public (float progress, string message)? SQQZNHWGZYG;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public FYMUBABGJPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x63595C0", Offset = "0x63585C0", VA = "0x1863595C0")]
			internal void KFMJWZWAMCZ(float a, string b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class JRFIKRCKNGU
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			private struct <<Execute>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public AsyncTaskMethodBuilder<bool> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public JRFIKRCKNGU <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x41E0C50", Offset = "0x41DFC50", VA = "0x1841E0C50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x41E0EF0", Offset = "0x41DFEF0", VA = "0x1841E0EF0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private struct <<Execute>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public AsyncTaskMethodBuilder<bool> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public JRFIKRCKNGU <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x41E0F60", Offset = "0x41DFF60", VA = "0x1841E0F60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x41E1400", Offset = "0x41E0400", VA = "0x1841E1400", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public SLYZSIFEEGC<a> DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public QVMHMSXVEGX HQYUGCUUTXO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public DirectoryInfo XAYNSCNMEKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public FileInfo NKNVJHNFHGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public DirectoryInfo ELCZYQHVPEG;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public JRFIKRCKNGU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x676C1D0", Offset = "0x676B1D0", VA = "0x18676C1D0")]
			[AsyncStateMachine(typeof(SLYZSIFEEGC<>.JRFIKRCKNGU.<<Execute>b__0>d))]
			internal Task<bool> SZRHNSJCJAT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x676BFD0", Offset = "0x676AFD0", VA = "0x18676BFD0")]
			[AsyncStateMachine(typeof(SLYZSIFEEGC<>.JRFIKRCKNGU.<<Execute>b__1>d))]
			internal Task<bool> SZMAQLPEZPK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class JRKPHXWHWSD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			private struct <<Execute>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				public AsyncTaskMethodBuilder<bool> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public JRKPHXWHWSD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x41E14E0", Offset = "0x41E04E0", VA = "0x1841E14E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x41E1AA0", Offset = "0x41E0AA0", VA = "0x1841E1AA0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public DDLSDILAQRF VBDENORTKNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public ExecutionArgs DFPAJVWZIYX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public JRFIKRCKNGU FWYXBYDFGWV;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public JRKPHXWHWSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x676C6D0", Offset = "0x676B6D0", VA = "0x18676C6D0")]
			[AsyncStateMachine(typeof(SLYZSIFEEGC<>.JRKPHXWHWSD.<<Execute>b__2>d))]
			internal Task<bool> TABVIFWXBXL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class GRUZCNMEPCV
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private struct <<MigrateRoomDoorDeprecatedIdsAsync>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public AsyncTaskMethodBuilder<(long roomId, string name)> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public GRUZCNMEPCV <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public long roomId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private TaskAwaiter<RoomDetailsDTO> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				private TaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x41EAAB0", Offset = "0x41E9AB0", VA = "0x1841EAAB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x41EAF50", Offset = "0x41E9F50", VA = "0x1841EAF50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public SLYZSIFEEGC<a> DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public ExecutionArgs DFPAJVWZIYX;

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public GRUZCNMEPCV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x64A2900", Offset = "0x64A1900", VA = "0x1864A2900")]
			[AsyncStateMachine(typeof(SLYZSIFEEGC<>.GRUZCNMEPCV.<<MigrateRoomDoorDeprecatedIdsAsync>b__1>d))]
			internal Task<(long, string)> KSJYUSCIRPM(long a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class ICJXWLDBPBZ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000033")]
			private struct <<ProcessCv2RootGraphData>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				public AsyncTaskMethodBuilder<bool> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public ICJXWLDBPBZ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x41F5450", Offset = "0x41F4450", VA = "0x1841F5450", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x41F5730", Offset = "0x41F4730", VA = "0x1841F5730", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public SLYZSIFEEGC<a> DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public ExecutionArgs DFPAJVWZIYX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public NEAYWMKOJYN EEUTDWYYHTH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public DirectoryInfo NMJXWYNLVDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public ICJXWLDBPBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6660370", Offset = "0x665F370", VA = "0x186660370")]
			[AsyncStateMachine(typeof(SLYZSIFEEGC<>.ICJXWLDBPBZ.<<ProcessCv2RootGraphData>b__0>d))]
			internal Task<bool> DRBNSDFYYKE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class XKXJREZMWEQ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private struct <<ProcessPersistenceViews>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public AsyncTaskMethodBuilder<IEnumerable<long>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public XKXJREZMWEQ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000113")]
				private TaskAwaiter<IEnumerable<long>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x41FAA70", Offset = "0x41F9A70", VA = "0x1841FAA70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x41FAD90", Offset = "0x41F9D90", VA = "0x1841FAD90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public SLYZSIFEEGC<a> DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public ExecutionArgs DFPAJVWZIYX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public IReadOnlyList<YMQXVRQNJLQ> IGYXZAATLPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public DirectoryInfo ZMBKOIBNPDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public XDSPFZNLMNK ODEQIRCIHNR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public XKXJREZMWEQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x511FD80", Offset = "0x511ED80", VA = "0x18511FD80")]
			[AsyncStateMachine(typeof(SLYZSIFEEGC<>.XKXJREZMWEQ.<<ProcessPersistenceViews>b__0>d))]
			internal Task<IEnumerable<long>> UVXNRAZTNFS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class KLYTXZLOCGR
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			private struct <<ProcessPersistenceViewsInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000117")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public KLYTXZLOCGR <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public (YMQXVRQNJLQ[] shapePvs, XDSPFZNLMNK prog, CancellationToken ct) a;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				private KLTNASRQSVI <>8__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				private ExportPath <exportPath>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				private QLOGDLPKFWU <dependencies>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				private IBHOQKYRCJB.ProfileSession <_profile>5__4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				private TaskAwaiter<ModelRoot> <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				private TaskAwaiter<FileInfo> <>u__3;

				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x41F9320", Offset = "0x41F8320", VA = "0x1841F9320", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x41FA270", Offset = "0x41F9270", VA = "0x1841FA270", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public DirectoryInfo ZMBKOIBNPDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public ExecutionArgs DFPAJVWZIYX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public KLYTXZLOCGR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6882050", Offset = "0x6881050", VA = "0x186882050")]
			[AsyncStateMachine(typeof(SLYZSIFEEGC<>.KLYTXZLOCGR.<<ProcessPersistenceViewsInternal>b__1>d))]
			internal Task<FileInfo> EUAVCKZENAU((YMQXVRQNJLQ[] shapePvs, XDSPFZNLMNK prog, CancellationToken ct) a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class KLTNASRQSVI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private struct <<ProcessPersistenceViewsInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public KLTNASRQSVI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public Stream stream;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x41FA510", Offset = "0x41F9510", VA = "0x1841FA510", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x41FA6A0", Offset = "0x41F96A0", VA = "0x1841FA6A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public ModelRoot DIKINBMUUPX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public KDPPVFHAXNU.NEISSKDPEKU<QVMHMSXVEGX> DOQQJWDZROM;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public KLTNASRQSVI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6881E50", Offset = "0x6880E50", VA = "0x186881E50")]
			[AsyncStateMachine(typeof(SLYZSIFEEGC<>.KLTNASRQSVI.<<ProcessPersistenceViewsInternal>b__2>d))]
			internal Task EUQPUFGWPIV(Stream a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class OERIHQMSFXQ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200003B")]
			private struct <<ProcessOMData>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public AsyncTaskMethodBuilder<IEnumerable<long>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				public OERIHQMSFXQ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				private TaskAwaiter<IEnumerable<long>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x41F7F80", Offset = "0x41F6F80", VA = "0x1841F7F80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x41F8230", Offset = "0x41F7230", VA = "0x1841F8230", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public SLYZSIFEEGC<a> DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public ExecutionArgs DFPAJVWZIYX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public ByteString JNLPYKIDLEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public DirectoryInfo ZMBKOIBNPDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public XDSPFZNLMNK ODEQIRCIHNR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public OERIHQMSFXQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x73CEA40", Offset = "0x73CDA40", VA = "0x1873CEA40")]
			[AsyncStateMachine(typeof(SLYZSIFEEGC<>.OERIHQMSFXQ.<<ProcessOMData>b__0>d))]
			internal Task<IEnumerable<long>> BBNANEEKAYN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class ZREJSMQIMLJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private struct <<ProcessOMDataInternal>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public ZREJSMQIMLJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				private ZQZCVFWLDAA <>8__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				private ExportPath <exportPath>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				private QLOGDLPKFWU <dependencies>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				private IBHOQKYRCJB.ProfileSession <_profile>5__4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				private TaskAwaiter<ModelRoot> <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				private TaskAwaiter<FileInfo> <>u__3;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x41F57A0", Offset = "0x41F47A0", VA = "0x1841F57A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x41F77F0", Offset = "0x41F67F0", VA = "0x1841F77F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public List<string> LKBKEGHXRKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public HashSet<long> QZXZDRXVRZJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public DirectoryInfo ZMBKOIBNPDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public XDSPFZNLMNK ODEQIRCIHNR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public ExecutionArgs DFPAJVWZIYX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public List<ObjectLocalId> IBTFYPVDIUP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public Dictionary<ObjectLocalId, OMShape> QVUDMPXUZKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public YMQXVRQNJLQ[] VEVCLJIOGCX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public KDUQLYDWETD[] UMTTXDUMXJH;

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public ZREJSMQIMLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x519AFA0", Offset = "0x5199FA0", VA = "0x18519AFA0")]
			internal void BPFLFPGQEFA(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x519B160", Offset = "0x519A160", VA = "0x18519B160")]
			internal void BPKSCWANNQJ(long a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x519AD60", Offset = "0x5199D60", VA = "0x18519AD60")]
			[AsyncStateMachine(typeof(SLYZSIFEEGC<>.ZREJSMQIMLJ.<<ProcessOMDataInternal>b__3>d))]
			internal Task<FileInfo> BPAEIIMSUTR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class ZQZCVFWLDAA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200003F")]
			private struct <<ProcessOMDataInternal>b__4>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				public ZQZCVFWLDAA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				public Stream stream;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400014D")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x41F7860", Offset = "0x41F6860", VA = "0x1841F7860", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0x41F7C10", Offset = "0x41F6C10", VA = "0x1841F7C10", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public ModelRoot DIKINBMUUPX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public KDPPVFHAXNU.NEISSKDPEKU<QVMHMSXVEGX> DOQQJWDZROM;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public ZQZCVFWLDAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x519AB60", Offset = "0x5199B60", VA = "0x18519AB60")]
			[AsyncStateMachine(typeof(SLYZSIFEEGC<>.ZQZCVFWLDAA.<<ProcessOMDataInternal>b__4>d))]
			internal Task BOKJQOFASLQ(Stream a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private struct <Execute>d__13 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public AsyncTaskMethodBuilder<ExportResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public SLYZSIFEEGC<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public XDSPFZNLMNK mainThreadProgressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private JRKPHXWHWSD <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private JRFIKRCKNGU <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private ZUTBEBKCNUQ <resultBuilder>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private CancellationTokenSource <progressDispatchCts>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private KDPPVFHAXNU.IXMMFLJZFJQ <myProgress>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private QVMHMSXVEGX <internalProgress>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private QVMHMSXVEGX <finalPrepProgress>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private FileInfo <logFileInfo>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private FileStream <logFileStream>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private object <>7__wrap8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <>7__wrap9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			private StreamWriter <logTextWriter>5__11;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			private object <>7__wrap11;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			private int <>7__wrap12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			private RZVDJMZCWRB <logWriter>5__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			private OYITNBXAWTR <exportFileWriter>5__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			private object <>7__wrap15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			private int <>7__wrap16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			private TaskAwaiter<bool> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			private ValueTaskAwaiter <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x670F6B0", Offset = "0x670E6B0", VA = "0x18670F6B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6713690", Offset = "0x6712690", VA = "0x186713690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private struct <MigrateRoomDoorDeprecatedIdsAsync>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public SLYZSIFEEGC<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			public IReadOnlyList<YMQXVRQNJLQ> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			private List<(YMQXVRQNJLQ view, long roomId)> <deprecatedDoors>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			private Dictionary<long, string> <resolvedNames>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			private TaskAwaiter<(long roomId, string name)[]> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6A349F0", Offset = "0x6A339F0", VA = "0x186A349F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6A36120", Offset = "0x6A35120", VA = "0x186A36120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct <ProcessCv2RootGraphData>d__27 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public SLYZSIFEEGC<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public NEAYWMKOJYN circuitGraphData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public DirectoryInfo targetDir;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6AD03F0", Offset = "0x6ACF3F0", VA = "0x186AD03F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0B00", Offset = "0x6ACFB00", VA = "0x186AD0B00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct <ProcessCv2RootGraphDataInternal>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public NEAYWMKOJYN circuitGraphData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public DirectoryInfo targetDir;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public SLYZSIFEEGC<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			private ASMKKOWSYWQ<Guid> <circuitNodeIdCollector>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			private int <index>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6ACF6A0", Offset = "0x6ACE6A0", VA = "0x186ACF6A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0390", Offset = "0x6ACF390", VA = "0x186AD0390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct <ProcessOMData>d__33 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public AsyncTaskMethodBuilder<IEnumerable<long>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public SLYZSIFEEGC<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public ByteString omData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public XDSPFZNLMNK progressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private TaskAwaiter<IEnumerable<long>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB650", Offset = "0x6ADA650", VA = "0x186ADB650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6ADBA50", Offset = "0x6ADAA50", VA = "0x186ADBA50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct <ProcessOMDataInternal>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public AsyncTaskMethodBuilder<IEnumerable<long>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public XDSPFZNLMNK progressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public ByteString omData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			private ZREJSMQIMLJ <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public SLYZSIFEEGC<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			private LZCFIZACNTF <services>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private RecRoom.ObjectModel.ObjectModel <objectModel>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			private RRSceneLoadOperationSubgraph <op>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			private NativeObjectLocalIdArray <allObjects>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			private HashSet<ObjectLocalId> <neededObjects>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			private Dictionary<ObjectLocalId, ObjectLocalId> <parentMap>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			private object <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			private int <index>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private ObjectLocalId <obj>5__10;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			private OMShape <omShape>5__11;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private Dictionary<ObjectLocalId, OMShape>.KeyCollection.Enumerator <>7__wrap11;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6AD0BC0", Offset = "0x6ACFBC0", VA = "0x186AD0BC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB200", Offset = "0x6ADA200", VA = "0x186ADB200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct <ProcessPersistenceViews>d__31 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public AsyncTaskMethodBuilder<IEnumerable<long>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public SLYZSIFEEGC<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public IReadOnlyList<YMQXVRQNJLQ> persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public XDSPFZNLMNK progressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			private TaskAwaiter<IEnumerable<long>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6B77B50", Offset = "0x6B76B50", VA = "0x186B77B50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6B77EE0", Offset = "0x6B76EE0", VA = "0x186B77EE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct <ProcessPersistenceViewsInternal>d__32 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public AsyncTaskMethodBuilder<IEnumerable<long>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public IReadOnlyList<YMQXVRQNJLQ> persistenceViewDatas;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public XDSPFZNLMNK progressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private KLYTXZLOCGR <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public SLYZSIFEEGC<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			private HashSet<long> <inventionSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			private KDPPVFHAXNU.IXMMFLJZFJQ <myProgress>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			private QVMHMSXVEGX <shapeProgress>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			private object <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			private int <>7__wrap5;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6B73ED0", Offset = "0x6B72ED0", VA = "0x186B73ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6B77700", Offset = "0x6B76700", VA = "0x186B77700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct <RunProgressDispatchTask>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public XDSPFZNLMNK mainThreadProgressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public MDJBSNXRQCA multiThreadProgressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private FYMUBABGJPV <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6C1FA70", Offset = "0x6C1EA70", VA = "0x186C1FA70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6C20E20", Offset = "0x6C1FE20", VA = "0x186C20E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct <WriteProtobufDefinitionsIfNecessary>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public DirectoryInfo exportDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			private ExportPath <zipExportPath>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private FileInfo <zipTargetFile>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			private byte[] <sourceHash>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			private string <sourceString>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			private string <destString>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			private TextAsset <protobufDefinitionsAsset>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private IDisposable <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x72A4940", Offset = "0x72A3940", VA = "0x1872A4940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x72A7010", Offset = "0x72A6010", VA = "0x1872A7010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct <ZipOutput>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public FileInfo archiveFileInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public DirectoryInfo roomDirInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			private int <attempts>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private ZipArchive <zipfile>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			private IEnumerator<string> <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			private Stream <entryStream>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			private FileStream <fileStream>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			private object <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			private int <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			private object <>7__wrap8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			private int <>7__wrap9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			private ValueTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x72BB2D0", Offset = "0x72BA2D0", VA = "0x1872BB2D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x72BC800", Offset = "0x72BB800", VA = "0x1872BC800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		protected readonly MSTCLKGZNJL HGATOHHAYRW;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public static readonly Guid FQQXWJRJYNJ;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public static readonly Guid LIQRHMTDHGB;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly Guid RUVUFCWULWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		protected readonly HVXLQSVPRNV VNJTBGAKCWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		protected readonly SPUTVXOGPRU RKSCCLIATBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		protected readonly MPPGKLNQAWF.ODRSNXNZSZX GJQLUAGIPHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly a XWWEFKAWOLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		protected readonly FJLOIZSCTTC.PEPDFYRCEPC PEPDFYRCEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		protected readonly FJLOIZSCTTC.PEPDFYRCEPC XCVIUPGOHLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		protected readonly ExportItemTypes CRXVUKYOVXT;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7A6DB20", Offset = "0x7A6CB20", VA = "0x187A6DB20")]
		protected SLYZSIFEEGC(HVXLQSVPRNV a, SPUTVXOGPRU b, MPPGKLNQAWF.ODRSNXNZSZX c, ExportItemTypes d, a e, MSTCLKGZNJL f, [Optional] FJLOIZSCTTC.PEPDFYRCEPC g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7A6AC00", Offset = "0x7A69C00", VA = "0x187A6AC00")]
		[AsyncStateMachine(typeof(SLYZSIFEEGC<>.<RunProgressDispatchTask>d__12))]
		private Task IHRDOPYHMUF(MDJBSNXRQCA a, XDSPFZNLMNK b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7A6A780", Offset = "0x7A69780", VA = "0x187A6A780")]
		[AsyncStateMachine(typeof(SLYZSIFEEGC<>.<Execute>d__13))]
		public Task<ExportResult> GDEESIZEZKX(XDSPFZNLMNK a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7A69F10", Offset = "0x7A68F10", VA = "0x187A69F10")]
		[AsyncStateMachine(typeof(SLYZSIFEEGC<>.<WriteProtobufDefinitionsIfNecessary>d__14))]
		private Task DPQWDPFSYAM(DirectoryInfo a, ExecutionArgs b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B260", Offset = "0x7A6A260", VA = "0x187A6B260")]
		private static bool LPPZWGKUKNY(byte[] a, byte[] b, [Out] string c, [Out] string d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7A6A8C0", Offset = "0x7A698C0", VA = "0x187A6A8C0")]
		private Task ICEEHCEHVHZ(DirectoryInfo a, DirectoryInfo b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C180", Offset = "0x7A6B180", VA = "0x187A6C180")]
		[AsyncStateMachine(typeof(SLYZSIFEEGC<>.<ZipOutput>d__17))]
		private Task YECZRMZFQLM(DirectoryInfo a, FileInfo b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract string ALGBHHLEBPR();

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract DirectoryInfo BQRTIFHGLUL(FJLOIZSCTTC.PEPDFYRCEPC a);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract Task AYBFGCXNYLQ(ExecutionArgs a, DirectoryInfo b, XDSPFZNLMNK c, CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7A6AE80", Offset = "0x7A69E80", VA = "0x187A6AE80")]
		[AsyncStateMachine(typeof(SLYZSIFEEGC<>.<MigrateRoomDoorDeprecatedIdsAsync>d__21))]
		protected Task KWBMHYELEKR(ExecutionArgs a, IReadOnlyList<YMQXVRQNJLQ> b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B520", Offset = "0x7A6A520", VA = "0x187A6B520")]
		private static bool QKIDRJWBUFB(DirectoryInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B460", Offset = "0x7A6A460", VA = "0x187A6B460")]
		private static bool QKIDRJWBUFB(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7A69780", Offset = "0x7A68780", VA = "0x187A69780")]
		private DirectoryInfo CSNSVBQOXQX(DirectoryInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B710", Offset = "0x7A6A710", VA = "0x187A6B710")]
		private bool QWIZSJWCTXI([Out] DirectoryInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C670", Offset = "0x7A6B670", VA = "0x187A6C670")]
		public void YGJQDYBCLIB(DirectoryInfo a, string b, [Out] DirectoryInfo c, [Out] FileInfo d, [Out] DirectoryInfo e, [Optional] DateTime? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7A6A4E0", Offset = "0x7A694E0", VA = "0x187A6A4E0")]
		[AsyncStateMachine(typeof(SLYZSIFEEGC<>.<ProcessCv2RootGraphData>d__27))]
		protected Task FFOOYZIXPJA(ExecutionArgs a, NEAYWMKOJYN? circuitGraphData, DirectoryInfo b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BEA0", Offset = "0x7A6AEA0", VA = "0x187A6BEA0")]
		[AsyncStateMachine(typeof(SLYZSIFEEGC<>.<ProcessCv2RootGraphDataInternal>d__28))]
		private Task XZUXCOXIZYP(ExecutionArgs a, NEAYWMKOJYN? circuitGraphData, DirectoryInfo b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7A68970", Offset = "0x7A67970", VA = "0x187A68970")]
		private static void BWUUXPZMWDC(NEAYWMKOJYN a, ExecutionArgs b, DirectoryInfo c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BE20", Offset = "0x7A6AE20", VA = "0x187A6BE20")]
		private static string XSHKNYMUDDD(PLKGNJYKCSP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7A6A1E0", Offset = "0x7A691E0", VA = "0x187A6A1E0")]
		[AsyncStateMachine(typeof(SLYZSIFEEGC<>.<ProcessPersistenceViews>d__31))]
		protected Task<IEnumerable<long>> EKSZYJGBWSK(ExecutionArgs a, IReadOnlyList<YMQXVRQNJLQ> b, DirectoryInfo c, XDSPFZNLMNK d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CC50", Offset = "0x7A6BC50", VA = "0x187A6CC50")]
		[AsyncStateMachine(typeof(SLYZSIFEEGC<>.<ProcessPersistenceViewsInternal>d__32))]
		private Task<IEnumerable<long>> ZKLFQZYSVGT(ExecutionArgs a, IReadOnlyList<YMQXVRQNJLQ> b, DirectoryInfo c, XDSPFZNLMNK d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D150", Offset = "0x7A6C150", VA = "0x187A6D150")]
		[AsyncStateMachine(typeof(SLYZSIFEEGC<>.<ProcessOMData>d__33))]
		protected Task<IEnumerable<long>> ZYXMCDMWHCR(ExecutionArgs a, ByteString b, DirectoryInfo c, XDSPFZNLMNK d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CAA0", Offset = "0x7A6BAA0", VA = "0x187A6CAA0")]
		[AsyncStateMachine(typeof(SLYZSIFEEGC<>.<ProcessOMDataInternal>d__34))]
		private Task<IEnumerable<long>> YYRUFXMQJYA(ExecutionArgs a, ByteString b, DirectoryInfo c, XDSPFZNLMNK d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7A6AD20", Offset = "0x7A69D20", VA = "0x187A6AD20")]
		[CompilerGenerated]
		internal static bool JZMQPWRBQGQ(string a, [Out] byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BAA0", Offset = "0x7A6AAA0", VA = "0x187A6BAA0")]
		[CompilerGenerated]
		internal static bool RBYLUFYFIOD(FileInfo a, [Out] byte[] b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class RZVDJMZCWRB
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private class HUJQWYEWJSI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			private bool IXEHIPWMHET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			private readonly RZVDJMZCWRB FMEVCRBKTIR;

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x8DCD7C0", Offset = "0x8DCC7C0", VA = "0x188DCD7C0")]
			public HUJQWYEWJSI(RZVDJMZCWRB a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8DCD780", Offset = "0x8DCC780", VA = "0x188DCD780", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct <WriteAsync>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public RZVDJMZCWRB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public string text;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8DDBF70", Offset = "0x8DDAF70", VA = "0x188DDBF70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x8DDC370", Offset = "0x8DDB370", VA = "0x188DDC370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct <WriteErrorLineAsync>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			public string line;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public RZVDJMZCWRB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8DDF1D0", Offset = "0x8DDE1D0", VA = "0x188DDF1D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8DDF390", Offset = "0x8DDE390", VA = "0x188DDF390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct <WriteException>d__13 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public RZVDJMZCWRB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public Exception ex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			private string <header>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			private int <startingIndentAmt>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			private Queue<(int indent, Exception ex)> <exceptionQueue>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private (int indent, Exception ex) <exceptionPair>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private Exception <enqueuedEx>5__6;

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8DDF3F0", Offset = "0x8DDE3F0", VA = "0x188DDF3F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8DE0040", Offset = "0x8DDF040", VA = "0x188DE0040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct <WriteLineAsync>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			public RZVDJMZCWRB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public string line;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x8DE0560", Offset = "0x8DDF560", VA = "0x188DE0560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x8DE0960", Offset = "0x8DDF960", VA = "0x188DE0960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct <WriteTextInternal>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public RZVDJMZCWRB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public bool appendNewLine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public string text;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8DE09C0", Offset = "0x8DDF9C0", VA = "0x188DE09C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x8DE0DA0", Offset = "0x8DDFDA0", VA = "0x188DE0DA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private readonly StreamWriter XSPQAXAUXXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private int TZGVKCDWUFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private string FAEALUUVBVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private bool TSYEWPDTJZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private readonly SemaphoreSlim MBLFXVRHUQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private readonly string[] EEAPVTVBQPC;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8DD00D0", Offset = "0x8DCF0D0", VA = "0x188DD00D0")]
		public RZVDJMZCWRB(StreamWriter a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFCC0", Offset = "0x8DCECC0", VA = "0x188DCFCC0")]
		[AsyncStateMachine(typeof(<WriteErrorLineAsync>d__9))]
		public Task KEHPKKDXOYH(string a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFA90", Offset = "0x8DCEA90", VA = "0x188DCFA90")]
		[AsyncStateMachine(typeof(<WriteLineAsync>d__10))]
		public Task EBPTVMFZDVB(string a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF970", Offset = "0x8DCE970", VA = "0x188DCF970")]
		[AsyncStateMachine(typeof(<WriteAsync>d__11))]
		public Task DGCESUWDPZD(string a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFFB0", Offset = "0x8DCEFB0", VA = "0x188DCFFB0")]
		[AsyncStateMachine(typeof(<WriteTextInternal>d__12))]
		private Task TIQUHZVYCQB(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFE80", Offset = "0x8DCEE80", VA = "0x188DCFE80")]
		[AsyncStateMachine(typeof(<WriteException>d__13))]
		public Task PRQGRGVYWEI(Exception a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFBB0", Offset = "0x8DCEBB0", VA = "0x188DCFBB0")]
		public IDisposable EMTNLEVNBTI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFCB0", Offset = "0x8DCECB0", VA = "0x188DCFCB0")]
		public void HLHLEBUYRZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8DD00C0", Offset = "0x8DCF0C0", VA = "0x188DD00C0")]
		public void YDKJRZBSZZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFDD0", Offset = "0x8DCEDD0", VA = "0x188DCFDD0")]
		private void KYRQRGIWGUJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFDE0", Offset = "0x8DCEDE0", VA = "0x188DCFDE0")]
		private void MLBKEWKNTMO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFC30", Offset = "0x8DCEC30", VA = "0x188DCFC30")]
		private string FCJFWDUZNBH(int a)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct DataExportOptions : MSTCLKGZNJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private ProtobufOutputFormat protobufOutputFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private bool exportShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private bool zipOutput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private bool exportInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private bool runLegacyMigrations;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static DataExportOptions FYIBPTBKDJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x8DCBC40", Offset = "0x8DCAC40", VA = "0x188DCBC40")]
			get
			{
				return default(DataExportOptions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ProtobufOutputFormat KPDQHNJXOLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x10C8400", Offset = "0x10C7400", VA = "0x1810C8400", Slot = "4")]
			get
			{
				return default(ProtobufOutputFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x2737DF0", Offset = "0x2736DF0", VA = "0x182737DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ZSGXEZBVACE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1144440", Offset = "0x1143440", VA = "0x181144440", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x1144470", Offset = "0x1143470", VA = "0x181144470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool YECZRMZFQLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x1144450", Offset = "0x1143450", VA = "0x181144450", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool YEJPMYFCLZH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1144460", Offset = "0x1143460", VA = "0x181144460", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1144490", Offset = "0x1143490", VA = "0x181144490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool KLJLQBDGMIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6939960", Offset = "0x6938960", VA = "0x186939960", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8D51D50", Offset = "0x8D50D50", VA = "0x188D51D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8DCBC60", Offset = "0x8DCAC60", VA = "0x188DCBC60")]
		public DataExportOptions(ProtobufOutputFormat protobufOutputFormat, bool exportShapes = true, bool zipOutput = true, bool exportInventions = true, bool runLegacyMigrations = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8DCBC50", Offset = "0x8DCAC50", VA = "0x188DCBC50", Slot = "9")]
		public bool RRKODKPKZGE()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public static class FJLOIZSCTTC
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public class PEPDFYRCEPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			private readonly DirectoryInfo MLLZDPSXSCR;

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8DCE1F0", Offset = "0x8DCD1F0", VA = "0x188DCE1F0")]
			public static PEPDFYRCEPC KHLUNXUOQEH(DirectoryInfo a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8DCE4D0", Offset = "0x8DCD4D0", VA = "0x188DCE4D0")]
			public static PEPDFYRCEPC QAGNVXLPFGV(DirectoryInfo a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
			private PEPDFYRCEPC(DirectoryInfo a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8DCE600", Offset = "0x8DCD600", VA = "0x188DCE600")]
			public DirectoryInfo RPOELTJJEEG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8DCE140", Offset = "0x8DCD140", VA = "0x188DCE140")]
			public DirectoryInfo CIGQKJVCBRN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8DCE420", Offset = "0x8DCD420", VA = "0x188DCE420")]
			public DirectoryInfo NXKLYUKPIZU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8DCE660", Offset = "0x8DCD660", VA = "0x188DCE660")]
			public DirectoryInfo TAJPUVRZLZK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public static readonly PEPDFYRCEPC EHTPGPOICDI;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8DCD3B0", Offset = "0x8DCC3B0", VA = "0x188DCD3B0")]
		public static DirectoryInfo ZDQUEHVRUEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8DCD2E0", Offset = "0x8DCC2E0", VA = "0x188DCD2E0")]
		public static string UVZTYUNTOLY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8DCD010", Offset = "0x8DCC010", VA = "0x188DCD010")]
		public static DirectoryInfo LOPUMCBAXIA(DirectoryInfo a, string b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8DCD1C0", Offset = "0x8DCC1C0", VA = "0x188DCD1C0")]
		public static DirectoryInfo TFMDYNMRHIY(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8DCCEB0", Offset = "0x8DCBEB0", VA = "0x188DCCEB0")]
		public static DirectoryInfo DKXBHBAUHQU(DirectoryInfo a, string b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8DCCE00", Offset = "0x8DCBE00", VA = "0x188DCCE00")]
		public static string DKXBHBAUHQU(string a, bool b = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public readonly struct ExecutionArgs
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private struct <AddWarning>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			public ExecutionArgs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public string warning;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8DD0610", Offset = "0x8DCF610", VA = "0x188DD0610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8DD07B0", Offset = "0x8DCF7B0", VA = "0x188DD07B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private struct <AddWarningForException>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public ExecutionArgs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public string warning;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000228")]
			public Exception ex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8DD0210", Offset = "0x8DCF210", VA = "0x188DD0210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8DD05B0", Offset = "0x8DCF5B0", VA = "0x188DD05B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public readonly DDLSDILAQRF AssetCollector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public readonly OYITNBXAWTR ExportFileWriter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public readonly RZVDJMZCWRB LogWriter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public readonly ZUTBEBKCNUQ ResultBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public readonly HashSet<FileExportNote> FileExportNotes;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC540", Offset = "0x8DCB540", VA = "0x188DCC540")]
		public ExecutionArgs(DDLSDILAQRF assetCollector, OYITNBXAWTR exportFileWriter, RZVDJMZCWRB logWriter, ZUTBEBKCNUQ resultBuilder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC280", Offset = "0x8DCB280", VA = "0x188DCC280")]
		public void HFKAUVJDPDD(FileInfo a, string b, [Optional] string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC130", Offset = "0x8DCB130", VA = "0x188DCC130")]
		[AsyncStateMachine(typeof(<AddWarning>d__7))]
		public Task DUIIXPPIQJL(string a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC3F0", Offset = "0x8DCB3F0", VA = "0x188DCC3F0")]
		[AsyncStateMachine(typeof(<AddWarningForException>d__8))]
		public Task SETIQLEYHBL(string a, Exception b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class OYITNBXAWTR
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public class CBKIUDHTIGD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005A")]
			[CompilerGenerated]
			private struct <MarkWroteToPath>d__6 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				public CBKIUDHTIGD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				public string filePath;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public long elapsedMillis;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x8DD8FF0", Offset = "0x8DD7FF0", VA = "0x188DD8FF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x8DD93E0", Offset = "0x8DD83E0", VA = "0x188DD93E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			[CompilerGenerated]
			private struct <WriteAllBytesInternal>d__13 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400023C")]
				public CBKIUDHTIGD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400023D")]
				public FileInfo file;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400023E")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400023F")]
				public ReadOnlySequence<byte> bytes;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				private string <relativePath>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000241")]
				private object <>7__wrap2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000242")]
				private int <>7__wrap3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				private long <start>5__5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				private FileStream <stream>5__6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000246")]
				private object <>7__wrap6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x4000247")]
				private int <>7__wrap7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
				[Cpp2IlInjected.Token(Token = "0x4000248")]
				private ReadOnlySequence<byte>.Enumerator <>7__wrap8;

				[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				private ValueTaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x8DDB3A0", Offset = "0x8DDA3A0", VA = "0x188DDB3A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x8DDBF00", Offset = "0x8DDAF00", VA = "0x188DDBF00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			[CompilerGenerated]
			private struct <WriteAudio>d__16 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public AudioStreamData audioStreamData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public CBKIUDHTIGD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400024F")]
				private float[] <samples>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000250")]
				private string <filePath>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000251")]
				private string <relativePath>5__4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000252")]
				private object <>7__wrap4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000253")]
				private int <>7__wrap5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000254")]
				private long <start>5__7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000255")]
				private FileStream <filestream>5__8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000256")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000257")]
				private object <>7__wrap8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000258")]
				private int <>7__wrap9;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x4000259")]
				private ValueTaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x8DDDE20", Offset = "0x8DDCE20", VA = "0x188DDDE20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x8DDEED0", Offset = "0x8DDDED0", VA = "0x188DDEED0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005D")]
			[CompilerGenerated]
			private struct <WriteAudioSamplesToStream>d__17 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400025A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400025B")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400025C")]
				public float[] decodedSamples;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400025D")]
				public Stream filestream;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400025E")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400025F")]
				public int channels;

				[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				public int sampleRate;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				private int <numSampleBytes>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				private byte[] <sampleBytesRentedArray>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				private byte[] <riffBytes>5__4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000264")]
				private byte[] <waveBytes>5__5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000265")]
				private byte[] <fmtIdBytes>5__6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				private byte[] <dataIdBytes>5__7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				private ValueTaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000268")]
				private TaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x8DDC3D0", Offset = "0x8DDB3D0", VA = "0x188DDC3D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x8DDDDC0", Offset = "0x8DDCDC0", VA = "0x188DDDDC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private struct <WriteBytes>d__11 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000269")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400026A")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400026B")]
				public CBKIUDHTIGD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400026C")]
				public string extensionNoPeriod;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				public ReadOnlySequence<byte> bytes;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x400026E")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x400026F")]
				private TaskAwaiter<FileInfo> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000116")]
				[Cpp2IlInjected.Address(RVA = "0x8DDEF30", Offset = "0x8DDDF30", VA = "0x188DDEF30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000117")]
				[Cpp2IlInjected.Address(RVA = "0x8DDF160", Offset = "0x8DDE160", VA = "0x188DDF160", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			[CompilerGenerated]
			private struct <WriteImage>d__10 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000270")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public ReadOnlySequence<byte> imageBytes;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public CBKIUDHTIGD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000275")]
				private TaskAwaiter<FileInfo> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000118")]
				[Cpp2IlInjected.Address(RVA = "0x8DE00A0", Offset = "0x8DDF0A0", VA = "0x188DE00A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x8DE04F0", Offset = "0x8DDF4F0", VA = "0x188DE04F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			[CompilerGenerated]
			private struct <WriteProtobuf>d__14<T> : IAsyncStateMachine where T : IMessage<T>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000276")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000277")]
				public AsyncTaskMethodBuilder<IReadOnlyCollection<FileInfo>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000278")]
				public MSTCLKGZNJL dataExportOptions;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000279")]
				public CBKIUDHTIGD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400027A")]
				public ReadOnlySequence<byte> protobufBytes;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400027B")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400027C")]
				public MessageParser<T> parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400027D")]
				private ProtobufOutputFormat <protobufOutputFormat>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400027E")]
				private HashSet<FileInfo> <wroteToFiles>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400027F")]
				private FileInfo <bytesFile>5__4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000280")]
				private TaskAwaiter<FileInfo> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000281")]
				private long <start>5__5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000282")]
				private TaskAwaiter <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000283")]
				private FileStream <filestream>5__6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000284")]
				private object <>7__wrap6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000285")]
				private int <>7__wrap7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000286")]
				private object <>7__wrap8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000287")]
				private int <>7__wrap9;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000288")]
				private ValueTaskAwaiter <>u__3;

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x72A7FC0", Offset = "0x72A6FC0", VA = "0x1872A7FC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x72A8DE0", Offset = "0x72A7DE0", VA = "0x1872A8DE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000061")]
			[CompilerGenerated]
			private struct <WriteProtobuf>d__15<T> : IAsyncStateMachine where T : IMessage<T>
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000289")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				public AsyncTaskMethodBuilder<IReadOnlyCollection<FileInfo>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public MSTCLKGZNJL dataExportOptions;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028C")]
				public CBKIUDHTIGD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028D")]
				public ReadOnlySequence<byte> protobufBytes;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028E")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028F")]
				public T parsed;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000290")]
				private ProtobufOutputFormat <protobufOutputFormat>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000291")]
				private HashSet<FileInfo> <wroteToFiles>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000292")]
				private FileInfo <bytesFile>5__4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000293")]
				private TaskAwaiter<FileInfo> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000294")]
				private long <start>5__5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000295")]
				private TaskAwaiter <>u__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000296")]
				private FileStream <filestream>5__6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000297")]
				private object <>7__wrap6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000298")]
				private int <>7__wrap7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000299")]
				private object <>7__wrap8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400029A")]
				private int <>7__wrap9;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400029B")]
				private ValueTaskAwaiter <>u__3;

				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x72A8EC0", Offset = "0x72A7EC0", VA = "0x1872A8EC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x72ABC60", Offset = "0x72AAC60", VA = "0x1872ABC60", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000062")]
			[CompilerGenerated]
			private struct <WriteText>d__9 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400029C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400029D")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400029E")]
				public CBKIUDHTIGD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400029F")]
				public string extensionNoPeriod;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40002A0")]
				public string contents;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40002A1")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40002A2")]
				private FileInfo <outFile>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x40002A3")]
				private TaskAwaiter<FileInfo> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x8DE0E00", Offset = "0x8DDFE00", VA = "0x188DE0E00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0x8DE10D0", Offset = "0x8DE00D0", VA = "0x188DE10D0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private struct <WriteUtf8Json>d__8<TJson> : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A4")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A5")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A6")]
				public CBKIUDHTIGD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A7")]
				public TJson jsonObj;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A8")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A9")]
				private FileInfo <outFile>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002AA")]
				private TaskAwaiter<FileInfo> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0x72AC540", Offset = "0x72AB540", VA = "0x1872AC540", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000121")]
				[Cpp2IlInjected.Address(RVA = "0x72AC870", Offset = "0x72AB870", VA = "0x1872AC870", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000064")]
			[CompilerGenerated]
			private struct <WriteViaStreamAsync>d__12 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002AB")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002AC")]
				public AsyncTaskMethodBuilder<FileInfo> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002AD")]
				public CBKIUDHTIGD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40002AE")]
				public string extensionNoPeriod;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40002AF")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40002B0")]
				public Func<Stream, Task> writeAction;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40002B1")]
				private FileInfo <outFile>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x40002B2")]
				private string <relativePath>5__3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x40002B3")]
				private object <>7__wrap3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x40002B4")]
				private int <>7__wrap4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x40002B5")]
				private long <start>5__6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x40002B6")]
				private FileStream <stream>5__7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x40002B7")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x40002B8")]
				private object <>7__wrap7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x40002B9")]
				private int <>7__wrap8;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x40002BA")]
				private ValueTaskAwaiter <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000122")]
				[Cpp2IlInjected.Address(RVA = "0x8DE1140", Offset = "0x8DE0140", VA = "0x188DE1140", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x8DE1B80", Offset = "0x8DE0B80", VA = "0x188DE1B80", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			private readonly DirectoryInfo QQDZPUUAXEX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			private readonly HashSet<string> CADSIBUSZNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000230")]
			private readonly ExportPath MEGWDKSHWWB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000231")]
			private readonly RZVDJMZCWRB YJDYCCNBGPR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000232")]
			private readonly Stopwatch AULIOHMJHTR;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8DCA0E0", Offset = "0x8DC90E0", VA = "0x188DCA0E0")]
			public CBKIUDHTIGD(DirectoryInfo a, HashSet<string> b, ExportPath c, RZVDJMZCWRB d, Stopwatch e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9FB0", Offset = "0x8DC8FB0", VA = "0x188DC9FB0")]
			[AsyncStateMachine(typeof(<MarkWroteToPath>d__6))]
			private Task XKPIAKUGWMY(string a, long b, CancellationToken c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9C40", Offset = "0x8DC8C40", VA = "0x188DC9C40")]
			private FileInfo WAJRGCKWWBS(ExportPath a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x4171BE0", Offset = "0x4170BE0", VA = "0x184171BE0")]
			[AsyncStateMachine(typeof(<WriteUtf8Json>d__8<>))]
			public Task<FileInfo> GNYXAJNTQRQ<a>(a a, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9550", Offset = "0x8DC8550", VA = "0x188DC9550")]
			[AsyncStateMachine(typeof(<WriteText>d__9))]
			public Task<FileInfo> HCOSQELPFIM(string a, CancellationToken b, string c = "txt")
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9980", Offset = "0x8DC8980", VA = "0x188DC9980")]
			[AsyncStateMachine(typeof(<WriteImage>d__10))]
			public Task<FileInfo> MWNJAOCVIUE(ReadOnlySequence<byte> a, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9AE0", Offset = "0x8DC8AE0", VA = "0x188DC9AE0")]
			[AsyncStateMachine(typeof(<WriteBytes>d__11))]
			public Task<FileInfo> QYOITXSASKO(ReadOnlySequence<byte> a, string b, CancellationToken c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8DC97E0", Offset = "0x8DC87E0", VA = "0x188DC97E0")]
			[AsyncStateMachine(typeof(<WriteViaStreamAsync>d__12))]
			public Task<FileInfo> IWISLCHEUGD(string a, Func<Stream, Task> b, CancellationToken c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9D80", Offset = "0x8DC8D80", VA = "0x188DC9D80")]
			[AsyncStateMachine(typeof(<WriteAllBytesInternal>d__13))]
			private Task<FileInfo> WCGXERYJMHO(FileInfo a, ReadOnlySequence<byte> b, CancellationToken c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x4172210", Offset = "0x4171210", VA = "0x184172210")]
			[AsyncStateMachine(typeof(<WriteProtobuf>d__14<>))]
			public Task<IReadOnlyCollection<FileInfo>> PWIFBMOOSBS<b>(ReadOnlySequence<byte> a, MessageParser<b> b, MSTCLKGZNJL c, CancellationToken d) where b : IMessage<b>
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x41723B0", Offset = "0x41713B0", VA = "0x1841723B0")]
			[AsyncStateMachine(typeof(<WriteProtobuf>d__15<>))]
			public Task<IReadOnlyCollection<FileInfo>> PWIFBMOOSBS<c>(ReadOnlySequence<byte> a, c b, MSTCLKGZNJL c, CancellationToken d) where c : IMessage<c>
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8DC96B0", Offset = "0x8DC86B0", VA = "0x188DC96B0")]
			[AsyncStateMachine(typeof(<WriteAudio>d__16))]
			public Task IHVLFPGZXRN(AudioStreamData a, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9350", Offset = "0x8DC8350", VA = "0x188DC9350")]
			[AsyncStateMachine(typeof(<WriteAudioSamplesToStream>d__17))]
			private static Task CEWUMZYNKWX(Stream a, float[] b, int c, int d, CancellationToken e)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9EF0", Offset = "0x8DC8EF0", VA = "0x188DC9EF0")]
			[CompilerGenerated]
			internal static void WVGVZLIKXUL(byte[] a, int b, int c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9490", Offset = "0x8DC8490", VA = "0x188DC9490")]
			[CompilerGenerated]
			internal static void EJDJLEAJIHU(byte[] a, int b, short c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9940", Offset = "0x8DC8940", VA = "0x188DC9940")]
			[CompilerGenerated]
			internal static byte[] MWEQNSEUKXH(int a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private readonly DirectoryInfo QQDZPUUAXEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private readonly HashSet<string> CADSIBUSZNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private readonly RZVDJMZCWRB FMEVCRBKTIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private readonly Stopwatch AULIOHMJHTR;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE050", Offset = "0x8DCD050", VA = "0x188DCE050")]
		public OYITNBXAWTR(DirectoryInfo a, RZVDJMZCWRB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8DCDF30", Offset = "0x8DCCF30", VA = "0x188DCDF30")]
		public CBKIUDHTIGD CRKMYLFBHQI(DirectoryInfo a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8DCDF70", Offset = "0x8DCCF70", VA = "0x188DCDF70")]
		internal CBKIUDHTIGD CRKMYLFBHQI(ExportPath a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public readonly struct ExportPath : IEquatable<ExportPath>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public readonly DirectoryInfo WriteDir;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public readonly string FilenameNoExtension;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC9B0", Offset = "0x8DCB9B0", VA = "0x188DCC9B0")]
		public ExportPath(DirectoryInfo writeDir, string filenameNoExtension)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC610", Offset = "0x8DCB610", VA = "0x188DCC610")]
		public FileInfo BLTDHTSZMOF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC790", Offset = "0x8DCB790", VA = "0x188DCC790", Slot = "4")]
		public bool Equals(ExportPath other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC830", Offset = "0x8DCB830", VA = "0x188DCC830", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC940", Offset = "0x8DCB940", VA = "0x188DCC940", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public enum ExportStatus
	{
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		Success
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public readonly struct ExportResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public readonly ExportStatus ExportStatus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public readonly ArchiveType ArchiveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public readonly FileInfo? ZipArchiveFileInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public readonly DirectoryInfo? DirectoryInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public readonly Exception? Exception;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public readonly string? ErrorString;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FMEVRGSKIWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x69B22C0", Offset = "0x69B12C0", VA = "0x1869B22C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8DCCD80", Offset = "0x8DCBD80", VA = "0x188DCCD80")]
		private ExportResult(DirectoryInfo? directoryInfo, FileInfo? zipArchiveFileInfo, ArchiveType archiveType, ExportStatus exportStatus, Exception? ex, [Optional] string? errorString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8DCCC00", Offset = "0x8DCBC00", VA = "0x188DCCC00")]
		public static ExportResult MTPOUXUNILO(ZUTBEBKCNUQ a, FileInfo b)
		{
			return default(ExportResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8DCCCD0", Offset = "0x8DCBCD0", VA = "0x188DCCCD0")]
		public static ExportResult TYRLTNXMQSQ(ZUTBEBKCNUQ a, DirectoryInfo b)
		{
			return default(ExportResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8DCCB60", Offset = "0x8DCBB60", VA = "0x188DCCB60")]
		public void HISACAACWXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8DCCAD0", Offset = "0x8DCBAD0", VA = "0x188DCCAD0")]
		public static ExportResult Error(string errorString, Exception ex)
		{
			return default(ExportResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public enum ArchiveType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		Directory,
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		ZipArchive
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal class QLOGDLPKFWU : HAHYOVHKCDQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private readonly ShapeRendererConfig SVBBXAXWSOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private readonly Dictionary<int, ImageBuilder> GBGKGZQIDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private readonly Dictionary<string, ImageBuilder> TSEMSKZFNEK;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF780", Offset = "0x8DCE780", VA = "0x188DCF780")]
		public QLOGDLPKFWU(ShapeRendererConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8DCEAE0", Offset = "0x8DCDAE0", VA = "0x188DCEAE0", Slot = "5")]
		public BevelConfig HRXZAOUNJJY()
		{
			return default(BevelConfig);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8DCEB50", Offset = "0x8DCDB50", VA = "0x188DCEB50", Slot = "4")]
		public TIREOSLVZXD JEEFDDJPOEU(RecRoom.ExportTools.PrimitiveShapeMeshType a, int b = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE710", Offset = "0x8DCD710", VA = "0x188DCE710", Slot = "6")]
		public DYQUHGVLWJN GetMaterialExportData(RecRoom.ExportTools.ShapeColor shapeColor, RecRoom.ExportTools.ShapeMaterial shapeMaterial)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8DCED80", Offset = "0x8DCDD80", VA = "0x188DCED80", Slot = "7")]
		public bool KIRKQSEUHFI(Guid a, [Out][MaybeNullWhen(false)] string prefabPrefix)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF280", Offset = "0x8DCE280", VA = "0x188DCF280")]
		private NWLNRFVRZLH VDHMZEVOKMA(UnityEngine.Material a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8DCEF40", Offset = "0x8DCDF40", VA = "0x188DCEF40")]
		private NWLNRFVRZLH NDYZFVREOLH(UnityEngine.Material a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF550", Offset = "0x8DCE550", VA = "0x188DCF550")]
		private static byte[] YPSBFSSNZKS(Texture2D a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8DCEF20", Offset = "0x8DCDF20", VA = "0x188DCEF20")]
		private static RecRoom.ExportTools.TextureWrapMode MJTXBIVLPGQ(UnityEngine.TextureWrapMode a)
		{
			return default(RecRoom.ExportTools.TextureWrapMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8DCF510", Offset = "0x8DCE510", VA = "0x188DCF510")]
		private static ColorRGB WPUWDFTJJNR(Color a)
		{
			return default(ColorRGB);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public struct FileExportNote : IEquatable<FileExportNote>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public readonly string fileName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public readonly string descriptionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public readonly string footnoteSection;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8DCD700", Offset = "0x8DCC700", VA = "0x188DCD700")]
		public FileExportNote(FileInfo file, string descriptionLines, [Optional] string footnoteSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1F50EC0", Offset = "0x1F4FEC0", VA = "0x181F50EC0")]
		public FileExportNote(string fileName, string descriptionText, [Optional] string footnoteSection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8DCD6A0", Offset = "0x8DCC6A0", VA = "0x188DCD6A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x32BC0E0", Offset = "0x32BB0E0", VA = "0x1832BC0E0", Slot = "4")]
		public bool Equals(FileExportNote other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8DCD610", Offset = "0x8DCC610", VA = "0x188DCD610", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6764470", Offset = "0x6763470", VA = "0x186764470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public interface SPUTVXOGPRU
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LXBXZLWGANG(Guid a, [Out] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public interface MSTCLKGZNJL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		ProtobufOutputFormat KPDQHNJXOLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool ZSGXEZBVACE
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool YECZRMZFQLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool YEJPMYFCLZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool KLJLQBDGMIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool RRKODKPKZGE();
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	internal static class CESSUQBPIGS
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public enum ImageType : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			Unknown,
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			Jpg,
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			Png,
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			Gif89a,
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			Gif87a
		}

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private static readonly byte[] CZCAFSIAWEF;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private static readonly byte[] QNWVUTDZVMR;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private static readonly byte[] EAAOLRKWNIY;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private static readonly byte[] ELAPOYVDEVU;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8DCA180", Offset = "0x8DC9180", VA = "0x188DCA180")]
		public static ImageType JCTSTABEXYA(ReadOnlySequence<byte> a)
		{
			return default(ImageType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8DCA460", Offset = "0x8DC9460", VA = "0x188DCA460")]
		public static string XXNRVJOKQAO(ImageType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8DCA310", Offset = "0x8DC9310", VA = "0x188DCA310")]
		[CompilerGenerated]
		internal static bool PICXXZEZENR(ReadOnlySequence<byte> a, byte[] b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class ELCDTGYBBVJ : SLYZSIFEEGC<long>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class MDJIIFNDRCE
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000071")]
			private struct <<ExecuteInternal>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002DF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002E0")]
				public AsyncTaskMethodBuilder<InventionData> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002E1")]
				public MDJIIFNDRCE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40002E2")]
				private TaskAwaiter<InventionData> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000152")]
				[Cpp2IlInjected.Address(RVA = "0x8DD9440", Offset = "0x8DD8440", VA = "0x188DD9440", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0x8DD9710", Offset = "0x8DD8710", VA = "0x188DD9710", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000072")]
			private struct <<ExecuteInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002E3")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002E4")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002E5")]
				public MDJIIFNDRCE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40002E6")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000154")]
				[Cpp2IlInjected.Address(RVA = "0x8DD9780", Offset = "0x8DD8780", VA = "0x188DD9780", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000155")]
				[Cpp2IlInjected.Address(RVA = "0x8DD9A60", Offset = "0x8DD8A60", VA = "0x188DD9A60", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			public ELCDTGYBBVJ DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			public InventionData FLZIXMTPYNU;

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MDJIIFNDRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8DCDCD0", Offset = "0x8DCCCD0", VA = "0x188DCDCD0")]
			[AsyncStateMachine(typeof(<<ExecuteInternal>b__0>d))]
			internal Task<InventionData> YKEYVWKSFDW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x8DCDDC0", Offset = "0x8DCCDC0", VA = "0x188DCDDC0")]
			[AsyncStateMachine(typeof(<<ExecuteInternal>b__1>d))]
			internal Task<byte[]> YKKFTDEPOPF()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct <ExecuteInternal>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002E8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002E9")]
			public ELCDTGYBBVJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002EA")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002EB")]
			public XDSPFZNLMNK progressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002EC")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			private MDJIIFNDRCE <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			private KDPPVFHAXNU.IXMMFLJZFJQ <myProgress>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			private QVMHMSXVEGX <downloadProgress>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			private QVMHMSXVEGX <persistenceViewProgress>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			private byte[] <inventionBytes>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			private SpawnableTemplateData <deserializedInventionData>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40002F4")]
			private TaskAwaiter<InventionData> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40002F5")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			private TaskAwaiter<byte[]> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			private object <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			private int <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			private TaskAwaiter<IEnumerable<long>> <>u__6;

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x8DD1F20", Offset = "0x8DD0F20", VA = "0x188DD1F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x8DD47F0", Offset = "0x8DD37F0", VA = "0x188DD47F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private readonly string BAVUQZBDQRL;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public long VGFOKZYUDMP
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8DCBF40", Offset = "0x8DCAF40", VA = "0x188DCBF40")]
		public ELCDTGYBBVJ(HVXLQSVPRNV a, SPUTVXOGPRU b, MPPGKLNQAWF.ODRSNXNZSZX c, long d, string e, MSTCLKGZNJL f, [Optional] FJLOIZSCTTC.PEPDFYRCEPC g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8DCBC80", Offset = "0x8DCAC80", VA = "0x188DCBC80", Slot = "4")]
		protected override string ALGBHHLEBPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8DCBE80", Offset = "0x8DCAE80", VA = "0x188DCBE80", Slot = "5")]
		protected override DirectoryInfo BQRTIFHGLUL(FJLOIZSCTTC.PEPDFYRCEPC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8DCBD20", Offset = "0x8DCAD20", VA = "0x188DCBD20", Slot = "6")]
		[AsyncStateMachine(typeof(<ExecuteInternal>d__6))]
		public override Task AYBFGCXNYLQ(ExecutionArgs a, DirectoryInfo b, XDSPFZNLMNK c, CancellationToken d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public interface ZJSSCFZNSOY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public struct OMShape
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public ObjectLocalId ObjectLocalId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public PrimitiveShapeType PrimitiveShapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public Vector3 LocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public Quaternion LocalRotation;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public RRObjectSplinePoint[] SplinePoints
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public interface HVXLQSVPRNV
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<byte[]> VTZCNGNTOVX(string a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<byte[]> IRRQPGBTIGC(string a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<byte[]> GMXHMBVKBLP(string a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<byte[]> ZVFJPPJEDGA(string a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<byte[]> JNQAFYKBNYV(FilenameWithHash a, CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<RoomDetailsDTO> MJZPJIXTVAL(long a, int? b, int? c, [Optional] CancellationToken d);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<InventionData> AFZSEJBZVPY(long a, [Optional] CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public readonly struct InventionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[JetBrains.Annotations.NotNull]
		public readonly Invention Invention;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[JetBrains.Annotations.NotNull]
		public readonly InventionVersion InventionVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[JetBrains.Annotations.NotNull]
		public readonly InventionDetails InventionDetails;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3880", Offset = "0x8DE2880", VA = "0x188DE3880")]
		public InventionData([JetBrains.Annotations.NotNull] Invention invention, [JetBrains.Annotations.NotNull] InventionVersion inventionVersion, [JetBrains.Annotations.NotNull] InventionDetails inventionDetails)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3860", Offset = "0x8DE2860", VA = "0x188DE3860")]
		public bool ZAKYRKSSSYI([Out] string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class ZAWYBKDTWKU : UHCTUQBJOJP
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool EMOCWMLUNDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xD5F620", Offset = "0xD5E620", VA = "0x180D5F620", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
		public void PBIBRQCHPMY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "6")]
		public void KBFAYAUNTPZ(RigidbodyEx a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "7")]
		public ROTQQCMUGGZ CCYWKJBUZXE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		public void VHCSOJHHOYS(Vector3 a, float b, Color c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public ZAWYBKDTWKU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	internal class WKHIETWCXZT : GGOGHMXGSEC, TWXUSQEJIPV
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public TWXUSQEJIPV MPVCMIXWMGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xE14D80", Offset = "0xE13D80", VA = "0x180E14D80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
		public void EIITCSSNILU(object a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "6")]
		public void NVJNDWKHFAC(object a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
		public void GODHZEQXDWE(object a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public WKHIETWCXZT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class NDDQTMXJSUJ : SLYZSIFEEGC<long>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		private delegate string AssetFilenameFunc(string cloudVarName, Guid cloudVarGuid, string blobName);

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		private delegate string IndexedAssetFilenameFunc(string cloudVarName, int index, Guid cloudVarGuid, string blobName);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private struct <<ExecuteInternal>g__AddAssetsFromListType|7_5>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			public RepeatedField<WAAZVTVDGZS> ledgerEntries;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			public RepeatedField<EEZEBYQKXXM> persistedValues;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public JACVVTKMTIS playerCloudData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public DDLSDILAQRF.AssetType assetType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public IndexedAssetFilenameFunc assetFilenameFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			private Dictionary<Guid, string> <guidToNameMap>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			private IEnumerator<EEZEBYQKXXM> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8DEF890", Offset = "0x8DEE890", VA = "0x188DEF890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8DF00A0", Offset = "0x8DEF0A0", VA = "0x188DF00A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private struct <<ExecuteInternal>g__AddAssetsFromValueType|7_4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			public RepeatedField<WAAZVTVDGZS> ledgerEntries;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			public RepeatedField<EEZEBYQKXXM> persistedValues;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			public DDLSDILAQRF.AssetType assetType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			public AssetFilenameFunc assetFilenameFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			private Dictionary<Guid, string> <guidToNameMap>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			private IEnumerator<EEZEBYQKXXM> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8DF0100", Offset = "0x8DEF100", VA = "0x188DF0100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8DF07D0", Offset = "0x8DEF7D0", VA = "0x188DF07D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class ACFWOTACWWL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000081")]
			private struct <<ExecuteInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400032A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400032B")]
				public AsyncTaskMethodBuilder<RoomDetailsDTO> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400032C")]
				public ACFWOTACWWL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400032D")]
				private TaskAwaiter<RoomDetailsDTO> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x8DEF360", Offset = "0x8DEE360", VA = "0x188DEF360", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000189")]
				[Cpp2IlInjected.Address(RVA = "0x8DEF580", Offset = "0x8DEE580", VA = "0x188DEF580", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000082")]
			private struct <<ExecuteInternal>b__8>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400032E")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400032F")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000330")]
				public ACFWOTACWWL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000331")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0x8DEF5F0", Offset = "0x8DEE5F0", VA = "0x188DEF5F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018B")]
				[Cpp2IlInjected.Address(RVA = "0x8DEF820", Offset = "0x8DEE820", VA = "0x188DEF820", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public NDDQTMXJSUJ DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			public RoomDetailsDTO MKVJDQHEPST;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public ACFWOTACWWL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8DE1EF0", Offset = "0x8DE0EF0", VA = "0x188DE1EF0")]
			[AsyncStateMachine(typeof(<<ExecuteInternal>b__7>d))]
			internal Task<RoomDetailsDTO> YLPVCRTZTFH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8DE1E00", Offset = "0x8DE0E00", VA = "0x188DE1E00")]
			[AsyncStateMachine(typeof(<<ExecuteInternal>b__8>d))]
			internal Task<byte[]> YIOVRUHNHRC()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private struct <ExecuteInternal>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public NDDQTMXJSUJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			public XDSPFZNLMNK progressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			private ACFWOTACWWL <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			private KDPPVFHAXNU.IXMMFLJZFJQ <myProgress>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			private QVMHMSXVEGX <fetchDetailsProgress>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private QVMHMSXVEGX <fetchCloudDataLedgerProgress>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private QVMHMSXVEGX <exportCloudDataProgress>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			private SuperRoomData <superRoomData>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			private PEQSNSQIFAU <cloudDataLedger>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			private JACVVTKMTIS <playerCloudData>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private TaskAwaiter<RoomDetailsDTO> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<byte[]> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			private TaskAwaiter <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8DE8470", Offset = "0x8DE7470", VA = "0x188DE8470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA980", Offset = "0x8DE9980", VA = "0x188DEA980", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private readonly string LEPBBIXNFQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private readonly WTDQFLYTVGY FDZROKBBEEV;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public long MUIBDHWIGHA
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6010", Offset = "0x8DE5010", VA = "0x188DE6010")]
		public NDDQTMXJSUJ(HVXLQSVPRNV a, SPUTVXOGPRU b, MPPGKLNQAWF.ODRSNXNZSZX c, long d, string e, WTDQFLYTVGY f, MSTCLKGZNJL g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5900", Offset = "0x8DE4900", VA = "0x188DE5900", Slot = "4")]
		protected override string ALGBHHLEBPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5B00", Offset = "0x8DE4B00", VA = "0x188DE5B00", Slot = "5")]
		protected override DirectoryInfo BQRTIFHGLUL(FJLOIZSCTTC.PEPDFYRCEPC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8DE59A0", Offset = "0x8DE49A0", VA = "0x188DE59A0", Slot = "6")]
		[AsyncStateMachine(typeof(<ExecuteInternal>d__7))]
		public override Task AYBFGCXNYLQ(ExecutionArgs a, DirectoryInfo b, XDSPFZNLMNK c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5E90", Offset = "0x8DE4E90", VA = "0x188DE5E90")]
		[AsyncStateMachine(typeof(<<ExecuteInternal>g__AddAssetsFromValueType|7_4>d))]
		[CompilerGenerated]
		internal static Task ZHUTABTLEPM(ExecutionArgs a, DirectoryInfo b, DDLSDILAQRF.AssetType c, AssetFilenameFunc d, RepeatedField<WAAZVTVDGZS> e, RepeatedField<EEZEBYQKXXM> f, CancellationToken g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5CF0", Offset = "0x8DE4CF0", VA = "0x188DE5CF0")]
		[AsyncStateMachine(typeof(<<ExecuteInternal>g__AddAssetsFromListType|7_5>d))]
		[CompilerGenerated]
		internal static Task LEZPONGQIFA(ExecutionArgs a, DirectoryInfo b, DDLSDILAQRF.AssetType c, IndexedAssetFilenameFunc d, RepeatedField<WAAZVTVDGZS> e, RepeatedField<EEZEBYQKXXM> f, JACVVTKMTIS g, CancellationToken h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5B20", Offset = "0x8DE4B20", VA = "0x188DE5B20")]
		[CompilerGenerated]
		internal static Dictionary<Guid, string> HUUAERCHIEN(RepeatedField<WAAZVTVDGZS> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[Flags]
	public enum ProtobufOutputFormat : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		Bytes = 1,
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		Json = 2,
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		AllFormats = 3
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	internal static class VSSGYXXHBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1770", Offset = "0x8DF0770", VA = "0x188DF1770")]
		public static Guid TPCZVPEOOMH(ByteString a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class ZUTBEBKCNUQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private readonly List<string> TRSNMFOIDTT;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public ExportStatus UQGMNWWSLKC
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8DF2610", Offset = "0x8DF1610", VA = "0x188DF2610")]
			get
			{
				return default(ExportStatus);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<string> LZAOOPYQKMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2560", Offset = "0x8DF1560", VA = "0x188DF2560")]
		public void DUIIXPPIQJL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2660", Offset = "0x8DF1660", VA = "0x188DF2660")]
		public ZUTBEBKCNUQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class YXTXYHEMUNG : SLYZSIFEEGC<long>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class MDJIIFNDRCE
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200008A")]
			private struct <<ExecuteInternal>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000354")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000355")]
				public AsyncTaskMethodBuilder<RoomDetailsDTO> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000356")]
				public MDJIIFNDRCE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000357")]
				private TaskAwaiter<RoomDetailsDTO> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x8DEEBA0", Offset = "0x8DEDBA0", VA = "0x188DEEBA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x8DEEDC0", Offset = "0x8DEDDC0", VA = "0x188DEEDC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public YXTXYHEMUNG DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public DirectoryInfo XAYNSCNMEKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public ExecutionArgs DFPAJVWZIYX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public HashSet<long> VTCKUFCDMUP;

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MDJIIFNDRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x8DE52F0", Offset = "0x8DE42F0", VA = "0x188DE52F0")]
			[AsyncStateMachine(typeof(<<ExecuteInternal>b__0>d))]
			internal Task<RoomDetailsDTO> YKEYVWKSFDW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private sealed class MDOPFMHBANN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200008C")]
			private struct <<ExecuteInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400035B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400035C")]
				public AsyncTaskMethodBuilder<bool> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400035D")]
				public MDOPFMHBANN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400035E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0x8DEEE30", Offset = "0x8DEDE30", VA = "0x188DEEE30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x8DEF2F0", Offset = "0x8DEE2F0", VA = "0x188DEF2F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public SubRoomDTO HCQSLGFPIHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public QVMHMSXVEGX KMFTISIQYWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public MDJIIFNDRCE FWYXBYDFGWV;

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MDOPFMHBANN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x8DE53E0", Offset = "0x8DE43E0", VA = "0x188DE53E0")]
			[AsyncStateMachine(typeof(<<ExecuteInternal>b__1>d))]
			internal Task<bool> YKKFTDEPOPF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class VQBWICMRXIG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200008E")]
			private struct <<FetchValidInventions>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000361")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000362")]
				public AsyncTaskMethodBuilder<(bool success, InventionData invention)> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000363")]
				public VQBWICMRXIG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000364")]
				public long id;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000365")]
				private TaskAwaiter<InventionData> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x8DF0830", Offset = "0x8DEF830", VA = "0x188DF0830", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x8DF0B90", Offset = "0x8DEFB90", VA = "0x188DF0B90", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public YXTXYHEMUNG DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public VQBWICMRXIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x8DF1670", Offset = "0x8DF0670", VA = "0x188DF1670")]
			[AsyncStateMachine(typeof(<<FetchValidInventions>b__0>d))]
			internal Task<(bool, InventionData)> SHDSKJZHPDT(long a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class QWQABXVDRJP
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			private struct <<ProcessSubroom>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000369")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public AsyncTaskMethodBuilder<byte[]> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public QWQABXVDRJP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400036C")]
				private TaskAwaiter<byte[]> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x8DF0C00", Offset = "0x8DEFC00", VA = "0x188DF0C00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x8DF0E40", Offset = "0x8DEFE40", VA = "0x188DF0E40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public YXTXYHEMUNG DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public SubRoomDTO HCQSLGFPIHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QWQABXVDRJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x8DE6140", Offset = "0x8DE5140", VA = "0x188DE6140")]
			[AsyncStateMachine(typeof(<<ProcessSubroom>b__0>d))]
			internal Task<byte[]> JHPCPICFTXS()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private struct <ExecuteInternal>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public YXTXYHEMUNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public DirectoryInfo roomDirInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public XDSPFZNLMNK progressable;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			private MDJIIFNDRCE <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			private KDPPVFHAXNU.IXMMFLJZFJQ <myProgress>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			private QVMHMSXVEGX <subroomsProgress>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			private QVMHMSXVEGX <inventionsProgress>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			private RoomDetailsDTO <roomDetailsDTO>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			private QVMHMSXVEGX[] <subroomProgressArr>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			private List<Exception> <subroomExceptions>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			private TaskAwaiter<RoomDetailsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			private TaskAwaiter<FileInfo> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			private int <subroomIndex>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			private TaskAwaiter<bool> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private TaskAwaiter <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x8DE66F0", Offset = "0x8DE56F0", VA = "0x188DE66F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8DE8410", Offset = "0x8DE7410", VA = "0x188DE8410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct <FetchValidInventions>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			public AsyncTaskMethodBuilder<IReadOnlyList<InventionData>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public YXTXYHEMUNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public IEnumerable<long> idList;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private TaskAwaiter<(bool success, InventionData invention)[]> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA9E0", Offset = "0x8DE99E0", VA = "0x188DEA9E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8DEAE90", Offset = "0x8DE9E90", VA = "0x188DEAE90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private struct <ProcessInRoomInventions>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public IReadOnlyCollection<long> allInventionIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public YXTXYHEMUNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			public DirectoryInfo roomDirInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public XDSPFZNLMNK inventionsProgress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			private IReadOnlyList<InventionData> <fetchedInventions>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			private DirectoryInfo <inventionsDir>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			private QVMHMSXVEGX[] <inventionProgressArray>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			private TaskAwaiter<IReadOnlyList<InventionData>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			private int <index>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			private long <inventionId>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			private DirectoryInfo <inventionDir>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			private QVMHMSXVEGX <thisInvProg>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			private object <>7__wrap8;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			private int <>7__wrap9;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			private TaskAwaiter<InventionData> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			private Exception <ex>5__11;

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8DEAF00", Offset = "0x8DE9F00", VA = "0x188DEAF00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8DEC3A0", Offset = "0x8DEB3A0", VA = "0x188DEC3A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private struct <ProcessSubroom>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public YXTXYHEMUNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public SubRoomDTO subRoomDTO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public XDSPFZNLMNK progress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public ExecutionArgs executionArgs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public DirectoryInfo targetDirectory;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			private QWQABXVDRJP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public HashSet<long> allInventionIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			private KDPPVFHAXNU.IXMMFLJZFJQ <myProgress>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			private QVMHMSXVEGX <downloadProgress>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			private QVMHMSXVEGX <shapeExportProgress>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			private byte[] <subroomBytes>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			private PersistedRoomData <persistedRoomData>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			private TaskAwaiter<FileInfo> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			private TaskAwaiter<byte[]> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			private object <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			private int <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			private TaskAwaiter<IReadOnlyCollection<FileInfo>> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			private TaskAwaiter<IEnumerable<long>> <>u__5;

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8DEC400", Offset = "0x8DEB400", VA = "0x188DEC400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8DEEB30", Offset = "0x8DEDB30", VA = "0x188DEEB30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private readonly string CUQCISJMIPS;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public long MUIBDHWIGHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2040", Offset = "0x8DF1040", VA = "0x188DF2040")]
		public YXTXYHEMUNG(HVXLQSVPRNV a, SPUTVXOGPRU b, MPPGKLNQAWF.ODRSNXNZSZX c, long d, string e, MSTCLKGZNJL f, [Optional] FJLOIZSCTTC.PEPDFYRCEPC g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8DF19B0", Offset = "0x8DF09B0", VA = "0x188DF19B0", Slot = "4")]
		protected override string ALGBHHLEBPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1CF0", Offset = "0x8DF0CF0", VA = "0x188DF1CF0", Slot = "5")]
		protected override DirectoryInfo BQRTIFHGLUL(FJLOIZSCTTC.PEPDFYRCEPC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1A50", Offset = "0x8DF0A50", VA = "0x188DF1A50", Slot = "6")]
		[AsyncStateMachine(typeof(<ExecuteInternal>d__6))]
		public override Task AYBFGCXNYLQ(ExecutionArgs a, DirectoryInfo b, XDSPFZNLMNK c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1EC0", Offset = "0x8DF0EC0", VA = "0x188DF1EC0")]
		[AsyncStateMachine(typeof(<ProcessInRoomInventions>d__7))]
		private Task SMXMUXTMWJY(ExecutionArgs a, IReadOnlyCollection<long> b, DirectoryInfo c, XDSPFZNLMNK d, CancellationToken e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1BB0", Offset = "0x8DF0BB0", VA = "0x188DF1BB0")]
		[AsyncStateMachine(typeof(<FetchValidInventions>d__8))]
		private Task<IReadOnlyList<InventionData>> BELDHYEWGTT(IEnumerable<long> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1D10", Offset = "0x8DF0D10", VA = "0x188DF1D10")]
		[AsyncStateMachine(typeof(<ProcessSubroom>d__9))]
		private Task<bool> SHDDVYWRWSO(ExecutionArgs a, DirectoryInfo b, SubRoomDTO c, HashSet<long> d, XDSPFZNLMNK e, CancellationToken f)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	internal class UDSITNDKIGF<a>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private struct <Execute>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public AsyncTaskMethodBuilder<a> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public UDSITNDKIGF<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			private string <text>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			private object <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			private a <result>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			private IDisposable <_>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private TaskAwaiter<a> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			private Exception <ex>5__6;

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x6719A30", Offset = "0x6718A30", VA = "0x186719A30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x4203570", Offset = "0x4202570", VA = "0x184203570", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private readonly Func<Task<a>> ZVYLCXUNFMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private readonly string VRKHTHTKJEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private RZVDJMZCWRB FMEVCRBKTIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private XDSPFZNLMNK XKURRETLWYT;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xD0D9F0", Offset = "0xD0C9F0", VA = "0x180D0D9F0")]
		private UDSITNDKIGF(Func<Task<a>> a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x5BD7930", Offset = "0x5BD6930", VA = "0x185BD7930")]
		public static UDSITNDKIGF<a> New(Func<Task<a>> taskFactory, string sectionText)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x5BD73E0", Offset = "0x5BD63E0", VA = "0x185BD73E0")]
		public UDSITNDKIGF<a> DHHDGZPAHNQ(RZVDJMZCWRB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x5BD79E0", Offset = "0x5BD69E0", VA = "0x185BD79E0")]
		public UDSITNDKIGF<a> WYTXSPARZYL(XDSPFZNLMNK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7E97870", Offset = "0x7E96870", VA = "0x187E97870")]
		[AsyncStateMachine(typeof(UDSITNDKIGF<>.<Execute>d__8))]
		public Task<a> GDEESIZEZKX(CancellationToken a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	internal class ENVAETPVNKF<a, b>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private struct <Execute>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public AsyncTaskMethodBuilder<b> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public ENVAETPVNKF<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public a args;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			private string <text>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			private object <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			private b <result>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			private IDisposable <_>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private TaskAwaiter<b> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private Exception <ex>5__6;

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x6718B20", Offset = "0x6717B20", VA = "0x186718B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x671C8E0", Offset = "0x671B8E0", VA = "0x18671C8E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private readonly Func<a, Task<b>> ZVYLCXUNFMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private readonly string VRKHTHTKJEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private RZVDJMZCWRB FMEVCRBKTIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private XDSPFZNLMNK XKURRETLWYT;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xD0D9F0", Offset = "0xD0C9F0", VA = "0x180D0D9F0")]
		private ENVAETPVNKF(Func<a, Task<b>> a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5BD7930", Offset = "0x5BD6930", VA = "0x185BD7930")]
		public static ENVAETPVNKF<a, b> New(Func<a, Task<b>> taskFactory, string sectionText)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5BD73E0", Offset = "0x5BD63E0", VA = "0x185BD73E0")]
		public ENVAETPVNKF<a, b> DHHDGZPAHNQ(RZVDJMZCWRB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5BD79E0", Offset = "0x5BD69E0", VA = "0x185BD79E0")]
		public ENVAETPVNKF<a, b> WYTXSPARZYL(XDSPFZNLMNK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5BD7400", Offset = "0x5BD6400", VA = "0x185BD7400")]
		[AsyncStateMachine(typeof(ENVAETPVNKF<, >.<Execute>d__8))]
		public Task<b> GDEESIZEZKX(a a, CancellationToken b)
		{
			return null;
		}
	}
}
namespace RecRoom.ObjectModel.Mocks
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class FCMIGRYKQIO : YCXAWPXRFTT
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Guid OMIIPKCTMRB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x8DE2600", Offset = "0x8DE1600", VA = "0x188DE2600", Slot = "4")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2450", Offset = "0x8DE1450", VA = "0x188DE2450", Slot = "5")]
		public Task BLHOLQAYEIB(Guid a, Guid b, Guid c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2570", Offset = "0x8DE1570", VA = "0x188DE2570", Slot = "6")]
		public Task PKQQCLBJPBI(Guid a, Guid[] b, Guid c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x111A210", Offset = "0x1119210", VA = "0x18111A210", Slot = "7")]
		public Guid CJFCVULIKJT(Guid a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8DE24E0", Offset = "0x8DE14E0", VA = "0x188DE24E0", Slot = "8")]
		public Task OQRVZAJUNQF(ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "9")]
		public bool IJDGNSNDDNW(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "11")]
		public void SGFDMXKOSNL(Guid a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "12")]
		public void FICVERMUYOE(Guid a, ObjectNetworkId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "13")]
		public void VRATEJMGVSK(ObjectNetworkId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "14")]
		public void GNNSKXQFLEI(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "10")]
		public bool EZWXWJQNQNG(HOOYDJHYZLE a, Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public FCMIGRYKQIO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class WZTBOFMADQB : XLCJKMKESDE
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Guid OMIIPKCTMRB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xF1C290", Offset = "0xF1B290", VA = "0x180F1C290", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1930", Offset = "0x8DF0930", VA = "0x188DF1930", Slot = "5")]
		public void EIDJVZSSRPS(NativeList<Guid> a, NativeList<Guid> b, NativeList<FixedString64Bytes> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public WZTBOFMADQB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class DWCJNGGXLLR : UYLYJABWQJU
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
		public void WNCQWZWPKZY(object a, object b, Action c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "6")]
		public void ZJTJQHHPGTB(string a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
		public void RBNVATQWXYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		public void OINSZGFXMKZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2410", Offset = "0x8DE1410", VA = "0x188DE2410", Slot = "9")]
		public RPPGFKESHGW<bool> WLGMPEBZGSM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2290", Offset = "0x8DE1290", VA = "0x188DE2290", Slot = "10")]
		public RPPGFKESHGW<float> FPIQQVHIVEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8DE23D0", Offset = "0x8DE13D0", VA = "0x188DE23D0", Slot = "11")]
		public RPPGFKESHGW<int> SAAPPHALNKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2350", Offset = "0x8DE1350", VA = "0x188DE2350", Slot = "12")]
		public RPPGFKESHGW<string> MXHBVQXPKAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2310", Offset = "0x8DE1310", VA = "0x188DE2310", Slot = "13")]
		public RPPGFKESHGW<int> MUBNEJGARVF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8DE22D0", Offset = "0x8DE12D0", VA = "0x188DE22D0", Slot = "14")]
		public RPPGFKESHGW<Enum> HNAGAWSDANX(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2250", Offset = "0x8DE1250", VA = "0x188DE2250", Slot = "15")]
		public RPPGFKESHGW<Enum> ETSHYOHMAEA(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2390", Offset = "0x8DE1390", VA = "0x188DE2390", Slot = "16")]
		public RPPGFKESHGW<(int, int)> NTUIXWTLIQH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public DWCJNGGXLLR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class KNNVIUJZQSF : QCNGOEJVGHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public KNNVIUJZQSF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class XCULZXTHVIN : HLYXDPFKQHQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public object WZYXCWGWADS
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public XCULZXTHVIN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public class QJCBRHZOPDD : EAEQOBINGNQ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public QJCBRHZOPDD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public class NILRHWSMASA : SOJYREOXQXL
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string IJKEELTXUQU
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x8DE6100", Offset = "0x8DE5100", VA = "0x188DE6100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public NILRHWSMASA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	internal class ZLJKIVFZJAT : ULAYRELCYPQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private bool HZFOTIQXQQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private Dictionary<string, bool> OCYYWRJGGMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private Func<string, int, int> LLYARLTEGQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private Func<string, bool> YWLFWHKMVCD;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2310", Offset = "0x8DF1310", VA = "0x188DF2310")]
		public ZLJKIVFZJAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2120", Offset = "0x8DF1120", VA = "0x188DF2120")]
		public bool FQDURPIFFUR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x277B6C0", Offset = "0x277A6C0", VA = "0x18277B6C0")]
		public int FVECFPETJUD(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
		public void CVFYTFHYZVM(Action a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3C10", Offset = "0x8DE2C10", VA = "0x188DE3C10", Slot = "5")]
		public bool RQNHRCGFGNZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8DF22F0", Offset = "0x8DF12F0", VA = "0x188DF22F0", Slot = "6")]
		public int XFGLJJICOSJ(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8DF21A0", Offset = "0x8DF11A0", VA = "0x188DF21A0")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8B88430", Offset = "0x8B87430", VA = "0x188B88430", Slot = "7")]
		private bool KGIBETMZBLK([Out] bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B88430", Offset = "0x8B87430", VA = "0x188B88430", Slot = "8")]
		private bool LZPRLAALPHF([Out] bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xDB4300", Offset = "0xDB3300", VA = "0x180DB4300", Slot = "9")]
		private bool HDXGCWNTZMR([Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B88430", Offset = "0x8B87430", VA = "0x188B88430", Slot = "10")]
		private bool WLVKTEGUDXA([Out] bool a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class KHMSZPXDGMH : ZDYWEUKZHIU
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
		public void ULFGHPEMVDD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public KHMSZPXDGMH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	internal class JZBRSCWFJOT : YZPJLVEVJBA, QNFHPEUJUSR, EQFYRFRSSPD
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public delegate void CalculateObjectPrefabTypesDelegate(List<Transform> transforms, NativeArray<ObjectPrefabType> prefabTypes, ObjectPrefabType rootPrefabType);

		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public delegate void GetConnectableGraphDescendentArrayDelegate(SerializedDataWrapper serializedData, NativeParallelHashMap<Guid, LocalId> entityFromGuid, [Out] NativeArray<LocalId> entities, [Out] NativeArray<LocalId> parents, [Out] NativeArray<AuthoredLocalPoseData> poses, Allocator allocator);

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public delegate bool IsValidConnectableGraphDelegate(SerializedDataWrapper serializedData, NativeParallelHashMap<Guid, LocalId> entityFromGuid, [Out] Exception exception);

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public delegate int GetPersistenceViewCountDelegate(SerializedDataWrapper serializedData);

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public delegate void GetViewDescriptorsDelegate(SerializedDataWrapper serializedData, NativeArray<ViewDescriptor> descriptors, NativeList<UniformTRS> descriptorTransforms);

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public delegate void ApplyAdditionalBakingDelegate(Transform transform, RRObjectPrefabData prefabData, NSNTXJAOJGZ context);

		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public delegate void RunPersistenceViewPrePostDeserializationDelegate(SerializedDataWrapper roomData, NativeArray<int> indices, WRLHKUPPYHT<GameObject> persistenceViewGameObjects, RentedArray<GameObject> allGameObjects, LoadType loadType);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private YCVVYZQWGCU VMGSSZBCFZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public CalculateObjectPrefabTypesDelegate SQUYLWXYKUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public GetConnectableGraphDescendentArrayDelegate MEIWWQOYXLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public IsValidConnectableGraphDelegate VLJFEHICTQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public GetPersistenceViewCountDelegate OUIWEECIEJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public GetViewDescriptorsDelegate TFIKKAMPHZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public ApplyAdditionalBakingDelegate ZZBPBRLHNGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public RunPersistenceViewPrePostDeserializationDelegate BQROIHBNQHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public Dictionary<Guid, string> UUTROYHXKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public Dictionary<string, GameObject> PLBZXKSBJYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public GameObject SDMWUVVYUIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public GameObject QKLQEIGTGXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public GameObject ZVOFWDIGIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public string[] UUSQRBSWMWG;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool VGTGIXDYJJO
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xD768B0", Offset = "0xD758B0", VA = "0x180D768B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xDE82C0", Offset = "0xDE72C0", VA = "0x180DE82C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool BYJFJYYTFFH
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x1689740", Offset = "0x1688740", VA = "0x181689740", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x168A210", Offset = "0x1689210", VA = "0x18168A210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool BWMWUQLDAHC
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool PKCGTYAUATQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8DE52B0", Offset = "0x8DE42B0", VA = "0x188DE52B0")]
		public JZBRSCWFJOT(YCVVYZQWGCU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4640", Offset = "0x8DE3640", VA = "0x188DE4640")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8DE42C0", Offset = "0x8DE32C0", VA = "0x188DE42C0", Slot = "31")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8DE40C0", Offset = "0x8DE30C0", VA = "0x188DE40C0", Slot = "32")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "13")]
		public int JGVKFRFARDV(Guid a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8DE50C0", Offset = "0x8DE40C0", VA = "0x188DE50C0", Slot = "33")]
		public Guid XRDRQGAEFKO()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4430", Offset = "0x8DE3430", VA = "0x188DE4430", Slot = "10")]
		public Guid OWBGJJEGSJX(Guid a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4F40", Offset = "0x8DE3F40", VA = "0x188DE4F40", Slot = "14")]
		public bool WBWPSJGNGCY(string a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4DE0", Offset = "0x8DE3DE0", VA = "0x188DE4DE0", Slot = "15")]
		public string UPTHJRRFBAB(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x13BD050", Offset = "0x13BC050", VA = "0x1813BD050", Slot = "16")]
		public bool SSYFGMEOSIG(RRObjectPrefabData a, [Out] LocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5250", Offset = "0x8DE4250", VA = "0x188DE5250", Slot = "17")]
		public RentedArray<byte[]> ZSUQYOJHDYH(NativeArray<ViewDescriptor> a)
		{
			return default(RentedArray<byte[]>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "18")]
		public void OQZWVLIOWAY(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4110", Offset = "0x8DE3110", VA = "0x188DE4110", Slot = "19")]
		public GameObject BYUDUVPGCNE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8DE42D0", Offset = "0x8DE32D0", VA = "0x188DE42D0", Slot = "20")]
		public void LAVGIVGWHKX(Transform a, RRObjectPrefabData b, NSNTXJAOJGZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4230", Offset = "0x8DE3230", VA = "0x188DE4230", Slot = "22")]
		public void DPLMGMMNGPE(SerializedDataWrapper a, NativeParallelHashMap<Guid, LocalId> b, [Out] NativeArray<LocalId> c, [Out] NativeArray<LocalId> d, [Out] NativeArray<AuthoredLocalPoseData> e, Allocator f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4E70", Offset = "0x8DE3E70", VA = "0x188DE4E70", Slot = "23")]
		public void VBOCRKMEYDL(SerializedDataWrapper a, NativeArray<int> b, WRLHKUPPYHT<GameObject> c, RentedArray<GameObject> d, LoadType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4190", Offset = "0x8DE3190", VA = "0x188DE4190", Slot = "21")]
		public bool DELGGOZEXPC(SerializedDataWrapper a, NativeParallelHashMap<Guid, LocalId> b, [Out] Exception c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4360", Offset = "0x8DE3360", VA = "0x188DE4360", Slot = "8")]
		public string[] OLRTGMSXBZQ(SerializedDataWrapper a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "9")]
		public void PXHRKQXDMSA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4EF0", Offset = "0x8DE3EF0", VA = "0x188DE4EF0", Slot = "11")]
		public int VUJLSZUFNFP(SerializedDataWrapper a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4310", Offset = "0x8DE3310", VA = "0x188DE4310", Slot = "12")]
		public void MEUMEVBAHSJ(SerializedDataWrapper a, NativeArray<ViewDescriptor> b, NativeList<UniformTRS> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "24")]
		public void SDGQITDLXHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "25")]
		public void TDSLTLVHSQA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	internal class HBSCNHWNDSV : AVHHRMJPCWS, YCVVYZQWGCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private System.Random VFLBSXNIZRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private Lifetime CUFGCOTOCGK;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public long IVEIRHDFTDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xE459B0", Offset = "0xE449B0", VA = "0x180E459B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public long KAHAVEFCDLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCF0", Offset = "0xD0ECF0", VA = "0x180D0FCF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE33E0", Offset = "0x8DE23E0", VA = "0x188DE33E0")]
		public HBSCNHWNDSV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3360", Offset = "0x8DE2360", VA = "0x188DE3360")]
		private long OWIXDCDWZVC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3290", Offset = "0x8DE2290", VA = "0x188DE3290", Slot = "4")]
		public void BONGWVKMBRS(PPCVAYWFABF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class JKBNKYVWLJM : IZCTLAONCHD
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public JKBNKYVWLJM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public class XNMNLMEPPQA : MXQMWQVVOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ONPOFPZJCLU
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0xD5F620", Offset = "0xD5E620", VA = "0x180D5F620", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool OXVWODRHZNS
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xE270A0", Offset = "0xE260A0", VA = "0x180E270A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CDGZINCZIHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2B25940", Offset = "0x2B24940", VA = "0x182B25940", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public XNMNLMEPPQA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class QGTMFBWTGSF : SVVKGAIGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool WBHADULSMJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int KFQOBGMSJEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xD5A870", Offset = "0xD59870", VA = "0x180D5A870", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int VYQNGKBKFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD08110", VA = "0x180D09110", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int SZTBRXXLFHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool HOJHDHAHSLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x1693730", Offset = "0x1692730", VA = "0x181693730", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int BZLWRELHDXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "12")]
		public bool WJLVPHYTEYV(PlayerId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "28")]
		public void APSFOVCXDTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "29")]
		public void VPTHMRFDCWY(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "30")]
		public void DFLVUUDRUVS(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "20")]
		public void HLWTOEPYOFS(OutOfBandMessageType a, ReadOnlySpan<byte> b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "15")]
		public void IHIDDQVUBSP(Action<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "16")]
		public void ESVVXNSSDEI(Action<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public QGTMFBWTGSF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public class HWMBAYIUYTM : NVKJNZVENLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public HWMBAYIUYTM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	internal class MockNetworkTransform : MonoBehaviour, OCPHTOQDQGR, ZEZVGGJERXZ, SZLHTNPOQJO
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public ViewId HXNEEKIRAUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(ViewId);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xD60B30", Offset = "0xD5FB30", VA = "0x180D60B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5700", Offset = "0x8DE4700", VA = "0x188DE5700", Slot = "11")]
		public void Bake(NSNTXJAOJGZ context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
		public void Initialize(ObjectNetworkId parent, Vector3 localPosition, Quaternion localRotation, Vector3 worldScale, bool isSpawnLocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
		public void SetTransformData(Vector3 localPosition, Quaternion localRotation, Vector3 worldScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "6")]
		public void SetParent(ViewId parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
		public void SetWantsToBePhysicsDriven(bool wantsToBePhysicsDriven)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		public void SetIsNearPositionBounds(bool isNearPositionBounds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
		public MockNetworkTransform()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public class SAIUSDBDVVH : GVOBCMRDLAM
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public SAIUSDBDVVH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	internal class MockNetworkView : MonoBehaviour, CVWDRVYPYSK, ZEZVGGJERXZ, GIOUNSVYOHS, SZLHTNPOQJO
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ViewId HXNEEKIRAUU
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(ViewId);
			}
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0xD60B30", Offset = "0xD5FB30", VA = "0x180D60B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public ViewId CUHEADOLFBW
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xD322D0", Offset = "0xD312D0", VA = "0x180D322D0")]
			[CompilerGenerated]
			get
			{
				return default(ViewId);
			}
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xF219B0", Offset = "0xF209B0", VA = "0x180F219B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Dictionary<int, object> PIUOQFQEDDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xD0C800", Offset = "0xD0B800", VA = "0x180D0C800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8DE57E0", Offset = "0x8DE47E0", VA = "0x188DE57E0", Slot = "4")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
		public void OnWillDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5770", Offset = "0x8DE4770", VA = "0x188DE5770", Slot = "9")]
		public void Bake(NSNTXJAOJGZ context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
		public MockNetworkView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public class PVZBSNPNAJT : PJZRKIAGJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
		public void PLVZGBAGWIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public PVZBSNPNAJT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	internal class EZLYMWLDVTW : FVEXUFQWHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
		public void BFUFXYGLESF(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
		public void ZCZAGXYALWR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "6")]
		public void VWTUNNFUUHU(bool a, string b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public EZLYMWLDVTW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public class HZKBRLHQSQC : EJFBPJOFWSR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public GameObject PMPLOCZDTJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public GameObject FFDFHWZHUDT;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3520", Offset = "0x8DE2520", VA = "0x188DE3520", Slot = "4")]
		public Transform GetTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3480", Offset = "0x8DE2480", VA = "0x188DE3480", Slot = "5")]
		public Collider GetCollider()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE35A0", Offset = "0x8DE25A0", VA = "0x188DE35A0", Slot = "6")]
		public void MoveToObject(ObjectLocalId newObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8DE35E0", Offset = "0x8DE25E0", VA = "0x188DE35E0", Slot = "7")]
		public void NotifyIsUniform(bool isUniform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3470", Offset = "0x8DE2470", VA = "0x188DE3470", Slot = "8")]
		public void DestroyCollider()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "9")]
		public void OBYQVEOZSLQ(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public HZKBRLHQSQC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal class JPNCFGGGXPU : GJYCODXNIDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private ZCUTXEYWEKT YVPRRXXVKOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private Dictionary<GameObject, int> VUZZFIAGYVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private Dictionary<GameObject, Action<ObjectLocalId, int>> CIPYVMTTXNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public Func<int, bool> WCGWXFHRMZT;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3FE0", Offset = "0x8DE2FE0", VA = "0x188DE3FE0")]
		public JPNCFGGGXPU(ZCUTXEYWEKT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3D00", Offset = "0x8DE2D00", VA = "0x188DE3D00", Slot = "4")]
		public int QSJKGVRFNOT(GameObject a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3D70", Offset = "0x8DE2D70", VA = "0x188DE3D70", Slot = "5")]
		public void THOPXVXOXCM(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3C90", Offset = "0x8DE2C90", VA = "0x188DE3C90", Slot = "8")]
		public object LLZXSRFIWJR(ObjectLocalId a, GameObject b, Action<ObjectLocalId, int> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3C30", Offset = "0x8DE2C30", VA = "0x188DE3C30", Slot = "9")]
		public void KHAXVWLXOMS(GameObject a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3E60", Offset = "0x8DE2E60", VA = "0x188DE3E60", Slot = "6")]
		public void TransferOwnership(GameObject gameObject, int newOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3C10", Offset = "0x8DE2C10", VA = "0x188DE3C10", Slot = "7")]
		public bool DFYTURDNJYZ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3AC0", Offset = "0x8DE2AC0", VA = "0x188DE3AC0")]
		private void AYGPXJTLPIH(GameObject a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public class DVSFKLRGJPL : HJUTNMDKODO, DTRQAXWKVLM
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public YYGOMMBAADJ FZKTHDKINDA
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE21F0", Offset = "0x8DE11F0", VA = "0x188DE21F0", Slot = "5")]
		public void InitReferences(PPCVAYWFABF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public DVSFKLRGJPL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public class GJKFQMNCUJT : IAWSSEFWJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "4")]
		public bool PDXBLUWZQQH(NetworkCreatorId a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
		public void AMQRYZCQZRT(PlayerId a, AccountRoleTypeNetworked b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public GJKFQMNCUJT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public class GKHNDLWNVIV : EQAGBLRJVMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public Action<object, NativeList<byte>> ZGFPAUGXZEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public Func<NativeArray<byte>, object> JCBPUDMUJOX;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x13F6450", Offset = "0x13F5450", VA = "0x1813F6450", Slot = "4")]
		public void GHRXOLGFAHI(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2640", Offset = "0x8DE1640", VA = "0x188DE2640", Slot = "5")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2B10", Offset = "0x8DE1B10", VA = "0x188DE2B10")]
		public static void PJATDQPWTRD(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2630", Offset = "0x8DE1630", VA = "0x188DE2630")]
		public static object CNMYUFXHFJS(NativeArray<byte> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2B30", Offset = "0x8DE1B30", VA = "0x188DE2B30")]
		private static void SQIRBZBNMTZ(NativeList<byte> a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2860", Offset = "0x8DE1860", VA = "0x188DE2860")]
		private static object LYKZYHORDOU(NativeArray<byte> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2680", Offset = "0x8DE1680", VA = "0x188DE2680")]
		private static void IQCERWCHKDR(NativeList<byte> a, Dictionary<int, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2E90", Offset = "0x8DE1E90", VA = "0x188DE2E90")]
		private static Dictionary<int, object> VMFEBWOSNBW(NativeArray<byte> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF1A0", Offset = "0x3AEE1A0", VA = "0x183AEF1A0")]
		private static void SQIRBZBNMTZ<T>(NativeList<byte> a, T b, byte c) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3AEEB20", Offset = "0x3AEDB20", VA = "0x183AEEB20")]
		private static void KTHEWVKDUUU<T>(NativeList<byte> a, T b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2E40", Offset = "0x8DE1E40", VA = "0x188DE2E40")]
		private static void SXIDGSFMMDI(NativeList<byte> a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3AEECD0", Offset = "0x3AEDCD0", VA = "0x183AEECD0")]
		private static T LYKZYHORDOU<T>(NativeArray<byte> a) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2F90", Offset = "0x8DE1F90", VA = "0x188DE2F90")]
		public GKHNDLWNVIV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public class MNYJABSGCBQ : WHPVXJXTXMB
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool EMOCWMLUNDY
		{
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "5")]
		public Delegate BVSSXQXNXNU(CVWDRVYPYSK a, Action<CVWDRVYPYSK> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "6")]
		public void LFIRCTMAJIH(CVWDRVYPYSK a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "7")]
		public Delegate QIOXGIKUSNJ(CVWDRVYPYSK a, Action<CVWDRVYPYSK> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		public void RNGQYANEDVJ(CVWDRVYPYSK a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "9")]
		public bool XKPOTKSKOSY(CVWDRVYPYSK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "10")]
		public CVWDRVYPYSK XUAJPYEMLXY(GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public MNYJABSGCBQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class ZXYPKKVZNOC : XJVWBOPIDBX
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
		public void RYVDLUOQDOX(ObjectLocalId a, CollisionLayerEnum b, bool c, PhysicsModelEnumFlags d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
		public void MDFGLYXVDWT(ObjectLocalId a, CollisionLayerEnum b, bool c, bool d, bool e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "6")]
		public KKEEMLCGECQ XNDVPMXOZRD(ObjectLocalId a, List<ObjectLocalId> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF26E0", Offset = "0x8DF16E0", VA = "0x188DF26E0", Slot = "7")]
		public EJFBPJOFWSR CEKXLXYMNSW(GameObject a, GameObject b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		public void GYMQUAZGOGO(GameObject a, List<GameObject> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "9")]
		public void CFGHJQNIHEU(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x41560D0", Offset = "0x41550D0", VA = "0x1841560D0", Slot = "10")]
		public a VCXOOIRRTNV<a>(GameObject a) where a : Collider
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF29E0", Offset = "0x8DF19E0", VA = "0x188DF29E0", Slot = "11")]
		public void NDTYOOFPETJ(Collider a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x4155FC0", Offset = "0x4154FC0", VA = "0x184155FC0", Slot = "12")]
		public GameObject SNEIRTSIGLD<b>(string a) where b : Collider
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8DF29F0", Offset = "0x8DF19F0", VA = "0x188DF29F0", Slot = "13")]
		public bool WEQFMUZROCY(Collider a, [Out] ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2770", Offset = "0x8DF1770", VA = "0x188DF2770", Slot = "14")]
		public bool KMDWOXJBJCI(ObjectLocalId a, [Out] ObjectLocomotionSettings b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2A40", Offset = "0x8DF1A40", VA = "0x188DF2A40", Slot = "15")]
		public NativeArray<ColliderType> XIUBMUIWVXU(Allocator a = Allocator.TempJob)
		{
			return default(NativeArray<ColliderType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2780", Offset = "0x8DF1780", VA = "0x188DF2780", Slot = "16")]
		public UnityEngine.Mesh[] LZCRMWEOSAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public ZXYPKKVZNOC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	internal class VTLGPYNJUCW : ZCUTXEYWEKT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public int LRUSSWMMSCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public int BLALWMTEITS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public Vector3 BNJXKLIBGTS;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int RXEAPXYFSFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD08110", VA = "0x180D09110", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int JZCLYMDOOEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xDF8EE0", Offset = "0xDF7EE0", VA = "0x180DF8EE0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool ZALDBGGFNHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x8DF18A0", Offset = "0x8DF08A0", VA = "0x188DF18A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool XFQWYCMCUFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xED75D0", Offset = "0xED65D0", VA = "0x180ED75D0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool HKWEJUYCFRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x169EB80", Offset = "0x169DB80", VA = "0x18169EB80", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF18F0", Offset = "0x8DF08F0", VA = "0x188DF18F0")]
		public VTLGPYNJUCW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8DF18B0", Offset = "0x8DF08B0", VA = "0x188DF18B0")]
		public VTLGPYNJUCW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "9")]
		public ObjectLocalId ESDDJZRGYPR(int a)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "10")]
		public void VKWNSVTBGDR(GameObject a, JobHandle b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class MIRSSZFJXNC : YYGOMMBAADJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "4")]
		public bool SFSWCOQRXBZ(AccountRoleTypeNetworked a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public MIRSSZFJXNC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public class ZKYMHMOHBMS : NGJNZGENJRV
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool SQGPDUJKWEE
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public ZKYMHMOHBMS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public class MUXCAEKUOEQ : ACKGHZQMQUZ, EQFYRFRSSPD
	{
		[Cpp2IlInjected.Token(Token = "0x20000C1")]
		private class SWGIZRWSBYZ : ZINHPKXEDYG, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool NQMIADYIXRH
			{
				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "15")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "4")]
			public RootHandle KLYJKVRGHYT(WUDEGVQXEMP a)
			{
				return default(RootHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "5")]
			public RootHandle KLYJKVRGHYT(WUDEGVQXEMP a, bool b)
			{
				return default(RootHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "6")]
			public void CWZDPGRFEFW(RootHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
			public void JKIWDNRYGLD(RootHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "8")]
			public ShapeHandle FZFZNMMPCMY(RootHandle a, YCZVDCDHUII b)
			{
				return default(ShapeHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "9")]
			public ShapeHandle XRWCDVCRBAG(RootHandle a, TUWPYUQVNOS b)
			{
				return default(ShapeHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "10")]
			public void LHWILQFGPEZ(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "11")]
			public void LGDWADOGDPQ(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "12")]
			public SkinnedCostumeHandle FHJCYTNTQHU(HXRMYEJHMZX a)
			{
				return default(SkinnedCostumeHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "13")]
			public void PHNNGETPWRQ(SkinnedCostumeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "14")]
			public void TQTNZAWCJDB(SkinnedCostumeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x8DE6540", Offset = "0x8DE5540", VA = "0x188DE6540", Slot = "16")]
			public Task KHGJJGUBFDT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x8DE65D0", Offset = "0x8DE55D0", VA = "0x188DE65D0", Slot = "17")]
			public Task VJVVOMJBSHJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x8DE6660", Offset = "0x8DE5660", VA = "0x188DE6660", Slot = "18")]
			public Task VXVZCRLBIHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "19")]
			public void KTOABTNUOQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x8DE64A0", Offset = "0x8DE54A0", VA = "0x188DE64A0", Slot = "20")]
			public IEnumerable<Renderer> DZQJXSSNQQO(RootHandle a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "21")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public SWGIZRWSBYZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		private class LPKIHPXVWZB : CGMZJKGSGAM, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
			public void SBMMPYOUFUW(RootHandle a, OutlineEffectType b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			public void SBMMPYOUFUW(ShapeHandle a, OutlineEffectType b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "6")]
			public void GPQVUVKKHJU(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
			public void IWSVVCHYSAA(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
			public void AVMSRAHBEQI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "9")]
			public void SXWJJFNJMFW(OutlineEffectType a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "10")]
			public void FLCZPKMVMQT(RootHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "11")]
			public void FLCZPKMVMQT(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "12")]
			public void REXMUCTEHHA(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "13")]
			public void KGDTPYEJNMM(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "14")]
			public void KTVEJBJJKZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "15")]
			public void CVEOBCKESSM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "16")]
			public void OOTCRLQTXZE(RootHandle a, SelectionEffectType b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "17")]
			public void BDUENISLUPM(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "18")]
			public void SWAAZTRVNJK(ShapeHandle a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "19")]
			public void PPWOMASTPPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "20")]
			public void ZXJYEUPOKJW(SelectionEffectType a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "21")]
			public void YQZILCJSJME(RootHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f, IReadOnlyList<UnityEngine.Camera> g, IgnoreEffectType h)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "22")]
			public void YQZILCJSJME(SkinnedCostumeHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "23")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public LPKIHPXVWZB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public ZINHPKXEDYG TOMVFGMHDYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public CGMZJKGSGAM UCQALHFKJCD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xD0CA90", Offset = "0xD0BA90", VA = "0x180D0CA90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool NVJYVLFLHKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5610", Offset = "0x8DE4610", VA = "0x188DE5610")]
		public MUXCAEKUOEQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
		public void ZKNBMZQZXWL(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		public void RJJRBVGVEQT(Transform a, SelectionEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "9")]
		public void QACYMINENBN(Transform a, OutlineEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8DE54D0", Offset = "0x8DE44D0", VA = "0x188DE54D0", Slot = "10")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5530", Offset = "0x8DE4530", VA = "0x188DE5530")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	internal class MockRigidbodyEx : MonoBehaviour, OGYYXGOOHSH, SZLHTNPOQJO
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool KJMEBHGONHM
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCE0", Offset = "0xD0ECE0", VA = "0x180D0FCE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3F0", Offset = "0xD0E3F0", VA = "0x180D0F3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public LXUPYHZBZJT KAMWXBFNNPA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xD0C800", Offset = "0xD0B800", VA = "0x180D0C800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Transform ZHNBUFTLOVF
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0xD33310", Offset = "0xD32310", VA = "0x180D33310", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Transform YHXCWGCLCPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xD33310", Offset = "0xD32310", VA = "0x180D33310", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xD0C800", Offset = "0xD0B800", VA = "0x180D0C800", Slot = "8")]
		public void SetImplementation(LXUPYHZBZJT impl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B29B90", Offset = "0x2B28B90", VA = "0x182B29B90", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5800", Offset = "0x8DE4800", VA = "0x188DE5800")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x8DE58A0", Offset = "0x8DE48A0", VA = "0x188DE58A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5850", Offset = "0x8DE4850", VA = "0x188DE5850")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8DE58F0", Offset = "0x8DE48F0", VA = "0x188DE58F0", Slot = "11")]
		private void SEQRWQSPUKP(NSNTXJAOJGZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
		public MockRigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x15229C0", Offset = "0x15219C0", VA = "0x1815229C0", Slot = "4")]
		private GameObject LBTUSBOAYUC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xD33310", Offset = "0xD32310", VA = "0x180D33310", Slot = "5")]
		private Transform AOEMIPCEIUZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public class SFSKCWGOUGV : YFEVIRQYIWY
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action DJAJWOTXOZK
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x8DE6400", Offset = "0x8DE5400", VA = "0x188DE6400", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x8DE6360", Offset = "0x8DE5360", VA = "0x188DE6360", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public SFSKCWGOUGV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public class WESEYOSJCEP : MLZVBKWWDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
		public void MJQGDXVAIXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public WESEYOSJCEP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public class HXFIGMYIIFI : OUICVHSTPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
		public void UVKKTBSCUCX(GameObject a, ObjectPolicyUserConfigurableFlags b, CircuitsTransformBehavior c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "5")]
		public bool XJYLJUJGTES(ObjectLocalId a, bool b, float3 c, quaternion d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "6")]
		public bool RXFCZHBOJRR(NativeObjectLocalIdArray a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "9")]
		public void AJQILYLFYCK(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
		public void MYBNJJURGDH(RRObject a, RRObject b, ReferenceGroupKind c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		public void RYDJYDEIKOR(RRObject a, ReferenceGroupKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "10")]
		public void IPLOFGCQLFV(SerializedDataWrapper a, ReadOnlySpan<Guid> b, ReadOnlySpan<int> c, RentedArray<GameObject> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "11")]
		public void GOESHKDAYGJ(HZTYXVTZUZS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "12")]
		public void TPREANIAUZM(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "13")]
		public void ROFUJHZLTLZ(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "14")]
		public void BNUPIXXOHVR(ObjectLocalId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public HXFIGMYIIFI()
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
