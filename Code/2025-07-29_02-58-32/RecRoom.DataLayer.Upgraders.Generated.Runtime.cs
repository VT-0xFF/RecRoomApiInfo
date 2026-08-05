using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Entities;
using Unity.Jobs;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CCIMMLGFOKL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x82AF680", Offset = "0x82AE080", VA = "0x1882AF680")]
	public static void INEEDBKNABG(ComponentSystemGroup KIJPAPAKCDB, EntityCommandBufferSystem BIDNHEFEJKL)
	{
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	internal struct UpgradeSystemRegistration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private ComponentSystemGroup group;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private EntityCommandBufferSystem ecbs;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82AF680", Offset = "0x82AE080", VA = "0x1882AF680")]
		public static void FGDJAOAJAJP(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82B6370", Offset = "0x82B4D70", VA = "0x1882B6370")]
		private void INEEDBKNABG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82B62E0", Offset = "0x82B4CE0", VA = "0x1882B62E0")]
		private void FMJDPBOANJL(FBLLAJJJEEL system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : FBLLAJJJEEL
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public NPCJDJOOCGL<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public IEGMCILLGJI<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x82B20C0", Offset = "0x82B0AC0", VA = "0x1882B20C0")]
			private void IJLKODCECPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x82B20B0", Offset = "0x82B0AB0", VA = "0x1882B20B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override MEBJEIOEDLD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x82B2060", Offset = "0x82B0A60", VA = "0x1882B2060", Slot = "14")]
			get
			{
				return default(MEBJEIOEDLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82B1DC0", Offset = "0x82B07C0", VA = "0x1882B1DC0", Slot = "15")]
		protected override void CFEFFIOGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82B1F30", Offset = "0x82B0930", VA = "0x1882B1F30")]
		private JobHandle ELDJPBABCMH(NPCJDJOOCGL<PersistentUserTagData_v1> component_1, IEGMCILLGJI<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : FBLLAJJJEEL
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public NPCJDJOOCGL<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public IEGMCILLGJI<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x82B00A0", Offset = "0x82AEAA0", VA = "0x1882B00A0")]
			private void IJLKODCECPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x82B0090", Offset = "0x82AEA90", VA = "0x1882B0090", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override MEBJEIOEDLD Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x82B0040", Offset = "0x82AEA40", VA = "0x1882B0040", Slot = "14")]
			get
			{
				return default(MEBJEIOEDLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82AFDA0", Offset = "0x82AE7A0", VA = "0x1882AFDA0", Slot = "15")]
		protected override void CFEFFIOGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x82AFF10", Offset = "0x82AE910", VA = "0x1882AFF10")]
		private JobHandle DMFIFMDEGOE(NPCJDJOOCGL<LocalDeformableScaleData_v1> component_4, IEGMCILLGJI<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : FBLLAJJJEEL
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public NPCJDJOOCGL<SerializedDataLayerVersionData_v1> component_15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public IEGMCILLGJI<SerializedDataLayerVersionData> component_16;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x82B51F0", Offset = "0x82B3BF0", VA = "0x1882B51F0")]
			private void IJLKODCECPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x82B51E0", Offset = "0x82B3BE0", VA = "0x1882B51E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override MEBJEIOEDLD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x82B5060", Offset = "0x82B3A60", VA = "0x1882B5060", Slot = "14")]
			get
			{
				return default(MEBJEIOEDLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82B4EF0", Offset = "0x82B38F0", VA = "0x1882B4EF0", Slot = "15")]
		protected override void CFEFFIOGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82B50B0", Offset = "0x82B3AB0", VA = "0x1882B50B0")]
		private JobHandle KAKOAJALCJN(NPCJDJOOCGL<SerializedDataLayerVersionData_v1> component_15, IEGMCILLGJI<SerializedDataLayerVersionData> component_16, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : FBLLAJJJEEL
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public NPCJDJOOCGL<ReplicatorPreallocatedObjectCountData_v1> component_23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public IEGMCILLGJI<ReplicatorPreallocatedObjectCountData> component_24;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x82B4BE0", Offset = "0x82B35E0", VA = "0x1882B4BE0")]
			private void IJLKODCECPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x82B4BD0", Offset = "0x82B35D0", VA = "0x1882B4BD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override MEBJEIOEDLD Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x82B4A50", Offset = "0x82B3450", VA = "0x1882B4A50", Slot = "14")]
			get
			{
				return default(MEBJEIOEDLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82B48E0", Offset = "0x82B32E0", VA = "0x1882B48E0", Slot = "15")]
		protected override void CFEFFIOGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82B4AA0", Offset = "0x82B34A0", VA = "0x1882B4AA0")]
		private JobHandle INENCICJJCD(NPCJDJOOCGL<ReplicatorPreallocatedObjectCountData_v1> component_23, IEGMCILLGJI<ReplicatorPreallocatedObjectCountData> component_24, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : FBLLAJJJEEL
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public NPCJDJOOCGL<ToolCleanupStatusData_v1> component_28;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public IEGMCILLGJI<ToolCleanupStatusData> component_29;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x82B5F70", Offset = "0x82B4970", VA = "0x1882B5F70")]
			private void IJLKODCECPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x82B5F60", Offset = "0x82B4960", VA = "0x1882B5F60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override MEBJEIOEDLD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x82B5DE0", Offset = "0x82B47E0", VA = "0x1882B5DE0", Slot = "14")]
			get
			{
				return default(MEBJEIOEDLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x82B5C70", Offset = "0x82B4670", VA = "0x1882B5C70", Slot = "15")]
		protected override void CFEFFIOGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x82B5E30", Offset = "0x82B4830", VA = "0x1882B5E30")]
		private JobHandle IDHGKECDCJM(NPCJDJOOCGL<ToolCleanupStatusData_v1> component_28, IEGMCILLGJI<ToolCleanupStatusData> component_29, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class TerrainGenerationDataUpgradeSystem : FBLLAJJJEEL
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct TerrainGenerationDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public NPCJDJOOCGL<TerrainGenerationData_v1> component_31;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public IEGMCILLGJI<TerrainGenerationData> component_32;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x82B5800", Offset = "0x82B4200", VA = "0x1882B5800")]
			private void IJLKODCECPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x82B57F0", Offset = "0x82B41F0", VA = "0x1882B57F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override MEBJEIOEDLD Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x82B5670", Offset = "0x82B4070", VA = "0x1882B5670", Slot = "14")]
			get
			{
				return default(MEBJEIOEDLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82B5500", Offset = "0x82B3F00", VA = "0x1882B5500", Slot = "15")]
		protected override void CFEFFIOGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82B56C0", Offset = "0x82B40C0", VA = "0x1882B56C0")]
		private JobHandle KGPCICENBNJ(NPCJDJOOCGL<TerrainGenerationData_v1> component_31, IEGMCILLGJI<TerrainGenerationData> component_32, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
		public TerrainGenerationDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : FBLLAJJJEEL
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public NPCJDJOOCGL<ReplicatorData_v1> component_39;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public IEGMCILLGJI<ReplicatorData> component_40;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x82B4590", Offset = "0x82B2F90", VA = "0x1882B4590")]
			private void IJLKODCECPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x82B4580", Offset = "0x82B2F80", VA = "0x1882B4580", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override MEBJEIOEDLD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x82B4400", Offset = "0x82B2E00", VA = "0x1882B4400", Slot = "14")]
			get
			{
				return default(MEBJEIOEDLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82B4290", Offset = "0x82B2C90", VA = "0x1882B4290", Slot = "15")]
		protected override void CFEFFIOGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x82B4450", Offset = "0x82B2E50", VA = "0x1882B4450")]
		private JobHandle ICFLEHIADAE(NPCJDJOOCGL<ReplicatorData_v1> component_39, IEGMCILLGJI<ReplicatorData> component_40, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : FBLLAJJJEEL
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NPCJDJOOCGL<InventionInstanceIdData_v1> component_43;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public IEGMCILLGJI<InventionInstanceIdData> component_44;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x82AFAA0", Offset = "0x82AE4A0", VA = "0x1882AFAA0")]
			private void IJLKODCECPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x82AFA90", Offset = "0x82AE490", VA = "0x1882AFA90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override MEBJEIOEDLD Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x82AF910", Offset = "0x82AE310", VA = "0x1882AF910", Slot = "14")]
			get
			{
				return default(MEBJEIOEDLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82AF7A0", Offset = "0x82AE1A0", VA = "0x1882AF7A0", Slot = "15")]
		protected override void CFEFFIOGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x82AF960", Offset = "0x82AE360", VA = "0x1882AF960")]
		private JobHandle KJAJMFPPAHM(NPCJDJOOCGL<InventionInstanceIdData_v1> component_43, IEGMCILLGJI<InventionInstanceIdData> component_44, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : FBLLAJJJEEL
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public NPCJDJOOCGL<OMShapeContainerData_v1> component_48;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IEGMCILLGJI<OMShapeContainerData> component_49;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x82B06D0", Offset = "0x82AF0D0", VA = "0x1882B06D0")]
			private void IJLKODCECPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x82B06C0", Offset = "0x82AF0C0", VA = "0x1882B06C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override MEBJEIOEDLD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x82B0670", Offset = "0x82AF070", VA = "0x1882B0670", Slot = "14")]
			get
			{
				return default(MEBJEIOEDLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x82B03D0", Offset = "0x82AEDD0", VA = "0x1882B03D0", Slot = "15")]
		protected override void CFEFFIOGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x82B0540", Offset = "0x82AEF40", VA = "0x1882B0540")]
		private JobHandle COHLLCGKLGM(NPCJDJOOCGL<OMShapeContainerData_v1> component_48, IEGMCILLGJI<OMShapeContainerData> component_49, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : FBLLAJJJEEL
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public NPCJDJOOCGL<AuthoredAIIdData_v1> component_58;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public NPCJDJOOCGL<AuthoredAIIdData_v2> component_59;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public NPCJDJOOCGL<AuthoredAIIdData_v3> component_60;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public IEGMCILLGJI<AuthoredAIIdData> component_61;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x82AED70", Offset = "0x82AD770", VA = "0x1882AED70")]
			private void IJLKODCECPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x82AED60", Offset = "0x82AD760", VA = "0x1882AED60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override MEBJEIOEDLD Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x82AED10", Offset = "0x82AD710", VA = "0x1882AED10", Slot = "14")]
			get
			{
				return default(MEBJEIOEDLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x82AEAB0", Offset = "0x82AD4B0", VA = "0x1882AEAB0", Slot = "15")]
		protected override void CFEFFIOGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x82AF490", Offset = "0x82ADE90", VA = "0x1882AF490")]
		private JobHandle POLCHADNBMI(NPCJDJOOCGL<AuthoredAIIdData_v1> component_58, NPCJDJOOCGL<AuthoredAIIdData_v2> component_59, NPCJDJOOCGL<AuthoredAIIdData_v3> component_60, IEGMCILLGJI<AuthoredAIIdData> component_61, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : FBLLAJJJEEL
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public NPCJDJOOCGL<ContainerCollisionLayerData_v1> component_71;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public IEGMCILLGJI<PhysicsModelCollisionLayerData> component_72;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x82B2620", Offset = "0x82B1020", VA = "0x1882B2620")]
			private void IJLKODCECPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x82B2610", Offset = "0x82B1010", VA = "0x1882B2610", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override MEBJEIOEDLD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x82B25C0", Offset = "0x82B0FC0", VA = "0x1882B25C0", Slot = "14")]
			get
			{
				return default(MEBJEIOEDLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x82B2450", Offset = "0x82B0E50", VA = "0x1882B2450", Slot = "15")]
		protected override void CFEFFIOGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x82B2910", Offset = "0x82B1310", VA = "0x1882B2910")]
		private JobHandle MPAJJJGFBDI(NPCJDJOOCGL<ContainerCollisionLayerData_v1> component_71, IEGMCILLGJI<PhysicsModelCollisionLayerData> component_72, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : FBLLAJJJEEL
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public NPCJDJOOCGL<ContainerGrabbableModeData_v1> component_76;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IEGMCILLGJI<PhysicsModelGrabbableModeData> component_77;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x82B3F50", Offset = "0x82B2950", VA = "0x1882B3F50")]
			private void IJLKODCECPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x82B3F40", Offset = "0x82B2940", VA = "0x1882B3F40", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override MEBJEIOEDLD Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x82B3EF0", Offset = "0x82B28F0", VA = "0x1882B3EF0", Slot = "14")]
			get
			{
				return default(MEBJEIOEDLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x82B3C50", Offset = "0x82B2650", VA = "0x1882B3C50", Slot = "15")]
		protected override void CFEFFIOGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x82B3DC0", Offset = "0x82B27C0", VA = "0x1882B3DC0")]
		private JobHandle COEFILHEINA(NPCJDJOOCGL<ContainerGrabbableModeData_v1> component_76, IEGMCILLGJI<PhysicsModelGrabbableModeData> component_77, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : FBLLAJJJEEL
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public NPCJDJOOCGL<ContainerFlagsData_v1> component_83;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public NPCJDJOOCGL<ContainerFlagsData_v2> component_84;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public NPCJDJOOCGL<PhysicsModelFlagsData_v3> component_85;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public IEGMCILLGJI<PhysicsModelFlagsData> component_86;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x82B3530", Offset = "0x82B1F30", VA = "0x1882B3530")]
			private void IJLKODCECPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x82B3520", Offset = "0x82B1F20", VA = "0x1882B3520", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override MEBJEIOEDLD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x82B34D0", Offset = "0x82B1ED0", VA = "0x1882B34D0", Slot = "14")]
			get
			{
				return default(MEBJEIOEDLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x82B3270", Offset = "0x82B1C70", VA = "0x1882B3270", Slot = "15")]
		protected override void CFEFFIOGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x82B30D0", Offset = "0x82B1AD0", VA = "0x1882B30D0")]
		private JobHandle BECKDFGPDHJ(NPCJDJOOCGL<ContainerFlagsData_v1> component_83, NPCJDJOOCGL<ContainerFlagsData_v2> component_84, NPCJDJOOCGL<PhysicsModelFlagsData_v3> component_85, IEGMCILLGJI<PhysicsModelFlagsData> component_86, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : FBLLAJJJEEL
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public NPCJDJOOCGL<ContainerCollisionModeData_v1> component_87;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public IEGMCILLGJI<PhysicsModelCollisionModeData> component_88;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x82B2D90", Offset = "0x82B1790", VA = "0x1882B2D90")]
			private void IJLKODCECPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x82B2D80", Offset = "0x82B1780", VA = "0x1882B2D80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override MEBJEIOEDLD Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x82B2D30", Offset = "0x82B1730", VA = "0x1882B2D30", Slot = "14")]
			get
			{
				return default(MEBJEIOEDLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x82B2A90", Offset = "0x82B1490", VA = "0x1882B2A90", Slot = "15")]
		protected override void CFEFFIOGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x82B2C00", Offset = "0x82B1600", VA = "0x1882B2C00")]
		private JobHandle EOMIEDPKHFE(NPCJDJOOCGL<ContainerCollisionModeData_v1> component_87, IEGMCILLGJI<PhysicsModelCollisionModeData> component_88, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : FBLLAJJJEEL
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public NPCJDJOOCGL<ObjectPolicyData_v1> component_91;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public NPCJDJOOCGL<ObjectPolicyData_v2> component_92;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public NPCJDJOOCGL<ObjectPolicyData_v3> component_93;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public NPCJDJOOCGL<ObjectPolicyData_v4> component_94;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public NPCJDJOOCGL<ObjectPolicyData_v5> component_95;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public IEGMCILLGJI<ObjectPolicyData> component_96;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x82B0F80", Offset = "0x82AF980", VA = "0x1882B0F80")]
			private void IJLKODCECPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x82B0F70", Offset = "0x82AF970", VA = "0x1882B0F70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly MEBJEIOEDLD log;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected override MEBJEIOEDLD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x82B0F20", Offset = "0x82AF920", VA = "0x1882B0F20", Slot = "14")]
			get
			{
				return default(MEBJEIOEDLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x82B0A10", Offset = "0x82AF410", VA = "0x1882B0A10", Slot = "15")]
		protected override void CFEFFIOGGOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x82B0D20", Offset = "0x82AF720", VA = "0x1882B0D20")]
		private JobHandle EAJLIPHLANL(NPCJDJOOCGL<ObjectPolicyData_v1> component_91, NPCJDJOOCGL<ObjectPolicyData_v2> component_92, NPCJDJOOCGL<ObjectPolicyData_v3> component_93, NPCJDJOOCGL<ObjectPolicyData_v4> component_94, NPCJDJOOCGL<ObjectPolicyData_v5> component_95, IEGMCILLGJI<ObjectPolicyData> component_96, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class EFAAKOBFIMD
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF860", Offset = "0x3ADE260", VA = "0x183ADF860")]
	public static void MNOHEIKCKLD<T, U>(T PDLJHJDBNHG, [Out] U EJGIIDDOBIO) where T : struct where U : struct
	{
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
