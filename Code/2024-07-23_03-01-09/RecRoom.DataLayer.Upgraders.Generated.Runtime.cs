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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KOKGJABNJJF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68B42A0", Offset = "0x68B34A0", VA = "0x1868B42A0")]
	public static void MFDIILAMENO(ComponentSystemGroup MFNJKEIOLKE, EntityCommandBufferSystem HICMAKMOHPJ)
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
		[Cpp2IlInjected.Address(RVA = "0x68B42A0", Offset = "0x68B34A0", VA = "0x1868B42A0")]
		public static void FHKGADPKMLF(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68B7940", Offset = "0x68B6B40", VA = "0x1868B7940")]
		private void MFDIILAMENO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x68B78B0", Offset = "0x68B6AB0", VA = "0x1868B78B0")]
		private void JBHEEBHPKDI(DKEHGHAOFDP system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : DKEHGHAOFDP
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public BAGEEEJMBMD<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public EJGHFBLMIPN<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x68B6250", Offset = "0x68B5450", VA = "0x1868B6250")]
			private void MKCNADIAABD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x68B6240", Offset = "0x68B5440", VA = "0x1868B6240", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly CDLNJDLNIPA log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override CDLNJDLNIPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x68B61F0", Offset = "0x68B53F0", VA = "0x1868B61F0", Slot = "14")]
			get
			{
				return default(CDLNJDLNIPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x68B6080", Offset = "0x68B5280", VA = "0x1868B6080", Slot = "15")]
		protected override void IDGDGIFGHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x68B5F50", Offset = "0x68B5150", VA = "0x1868B5F50")]
		private JobHandle CNFIIHJMFBH(BAGEEEJMBMD<PersistentUserTagData_v1> component_1, EJGHFBLMIPN<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x21B6470", Offset = "0x21B5670", VA = "0x1821B6470")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : DKEHGHAOFDP
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public BAGEEEJMBMD<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public EJGHFBLMIPN<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x68B45F0", Offset = "0x68B37F0", VA = "0x1868B45F0")]
			private void MKCNADIAABD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x68B45E0", Offset = "0x68B37E0", VA = "0x1868B45E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly CDLNJDLNIPA log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override CDLNJDLNIPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x68B4590", Offset = "0x68B3790", VA = "0x1868B4590", Slot = "14")]
			get
			{
				return default(CDLNJDLNIPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68B4420", Offset = "0x68B3620", VA = "0x1868B4420", Slot = "15")]
		protected override void IDGDGIFGHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x68B42F0", Offset = "0x68B34F0", VA = "0x1868B42F0")]
		private JobHandle FMGGMFINJFB(BAGEEEJMBMD<LocalDeformableScaleData_v1> component_3, EJGHFBLMIPN<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x21B6470", Offset = "0x21B5670", VA = "0x1821B6470")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : DKEHGHAOFDP
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public BAGEEEJMBMD<ReplicatorPreallocatedObjectCountData_v1> component_19;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public EJGHFBLMIPN<ReplicatorPreallocatedObjectCountData> component_20;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x68B6F30", Offset = "0x68B6130", VA = "0x1868B6F30")]
			private void MKCNADIAABD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x68B6F20", Offset = "0x68B6120", VA = "0x1868B6F20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly CDLNJDLNIPA log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override CDLNJDLNIPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x68B6DA0", Offset = "0x68B5FA0", VA = "0x1868B6DA0", Slot = "14")]
			get
			{
				return default(CDLNJDLNIPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x68B6C30", Offset = "0x68B5E30", VA = "0x1868B6C30", Slot = "15")]
		protected override void IDGDGIFGHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x68B6DF0", Offset = "0x68B5FF0", VA = "0x1868B6DF0")]
		private JobHandle LBBKPELOOMH(BAGEEEJMBMD<ReplicatorPreallocatedObjectCountData_v1> component_19, EJGHFBLMIPN<ReplicatorPreallocatedObjectCountData> component_20, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x21B6470", Offset = "0x21B5670", VA = "0x1821B6470")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : DKEHGHAOFDP
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public BAGEEEJMBMD<ToolCleanupStatusData_v1> component_23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public EJGHFBLMIPN<ToolCleanupStatusData> component_24;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x68B7540", Offset = "0x68B6740", VA = "0x1868B7540")]
			private void MKCNADIAABD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x68B7530", Offset = "0x68B6730", VA = "0x1868B7530", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly CDLNJDLNIPA log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override CDLNJDLNIPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x68B73B0", Offset = "0x68B65B0", VA = "0x1868B73B0", Slot = "14")]
			get
			{
				return default(CDLNJDLNIPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68B7240", Offset = "0x68B6440", VA = "0x1868B7240", Slot = "15")]
		protected override void IDGDGIFGHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x68B7400", Offset = "0x68B6600", VA = "0x1868B7400")]
		private JobHandle LPADKIKIICP(BAGEEEJMBMD<ToolCleanupStatusData_v1> component_23, EJGHFBLMIPN<ToolCleanupStatusData> component_24, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x21B6470", Offset = "0x21B5670", VA = "0x1821B6470")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : DKEHGHAOFDP
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public BAGEEEJMBMD<ReplicatorData_v1> component_29;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public EJGHFBLMIPN<ReplicatorData> component_30;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x68B68E0", Offset = "0x68B5AE0", VA = "0x1868B68E0")]
			private void MKCNADIAABD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x68B68D0", Offset = "0x68B5AD0", VA = "0x1868B68D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly CDLNJDLNIPA log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override CDLNJDLNIPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x68B6880", Offset = "0x68B5A80", VA = "0x1868B6880", Slot = "14")]
			get
			{
				return default(CDLNJDLNIPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68B6710", Offset = "0x68B5910", VA = "0x1868B6710", Slot = "15")]
		protected override void IDGDGIFGHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68B65E0", Offset = "0x68B57E0", VA = "0x1868B65E0")]
		private JobHandle EFFEKPAHEDP(BAGEEEJMBMD<ReplicatorData_v1> component_29, EJGHFBLMIPN<ReplicatorData> component_30, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x21B6470", Offset = "0x21B5670", VA = "0x1821B6470")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : DKEHGHAOFDP
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public BAGEEEJMBMD<OMShapeContainerData_v1> component_34;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public EJGHFBLMIPN<OMShapeContainerData> component_35;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x68B4C20", Offset = "0x68B3E20", VA = "0x1868B4C20")]
			private void MKCNADIAABD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x68B4C10", Offset = "0x68B3E10", VA = "0x1868B4C10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly CDLNJDLNIPA log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override CDLNJDLNIPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x68B4BC0", Offset = "0x68B3DC0", VA = "0x1868B4BC0", Slot = "14")]
			get
			{
				return default(CDLNJDLNIPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68B4A50", Offset = "0x68B3C50", VA = "0x1868B4A50", Slot = "15")]
		protected override void IDGDGIFGHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68B4920", Offset = "0x68B3B20", VA = "0x1868B4920")]
		private JobHandle BNHFGOIIEHI(BAGEEEJMBMD<OMShapeContainerData_v1> component_34, EJGHFBLMIPN<OMShapeContainerData> component_35, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x21B6470", Offset = "0x21B5670", VA = "0x1821B6470")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class ContainerFlagsDataUpgradeSystem : DKEHGHAOFDP
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ContainerFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public BAGEEEJMBMD<ContainerFlagsData_v1> component_56;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public EJGHFBLMIPN<ContainerFlagsData> component_57;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x68B3F80", Offset = "0x68B3180", VA = "0x1868B3F80")]
			private void MKCNADIAABD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x68B3F70", Offset = "0x68B3170", VA = "0x1868B3F70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly CDLNJDLNIPA log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override CDLNJDLNIPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x68B3F20", Offset = "0x68B3120", VA = "0x1868B3F20", Slot = "14")]
			get
			{
				return default(CDLNJDLNIPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x68B3DB0", Offset = "0x68B2FB0", VA = "0x1868B3DB0", Slot = "15")]
		protected override void IDGDGIFGHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x68B3C80", Offset = "0x68B2E80", VA = "0x1868B3C80")]
		private JobHandle DNJFEPPMLPB(BAGEEEJMBMD<ContainerFlagsData_v1> component_56, EJGHFBLMIPN<ContainerFlagsData> component_57, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x21B6470", Offset = "0x21B5670", VA = "0x1821B6470")]
		public ContainerFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : DKEHGHAOFDP
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public BAGEEEJMBMD<ObjectPolicyData_v1> component_61;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public BAGEEEJMBMD<ObjectPolicyData_v2> component_62;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public BAGEEEJMBMD<ObjectPolicyData_v3> component_63;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public BAGEEEJMBMD<ObjectPolicyData_v4> component_64;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public EJGHFBLMIPN<ObjectPolicyData> component_65;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x68B5480", Offset = "0x68B4680", VA = "0x1868B5480")]
			private void MKCNADIAABD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x68B5470", Offset = "0x68B4670", VA = "0x1868B5470", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly CDLNJDLNIPA log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override CDLNJDLNIPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x68B5230", Offset = "0x68B4430", VA = "0x1868B5230", Slot = "14")]
			get
			{
				return default(CDLNJDLNIPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x68B4F60", Offset = "0x68B4160", VA = "0x1868B4F60", Slot = "15")]
		protected override void IDGDGIFGHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x68B5280", Offset = "0x68B4480", VA = "0x1868B5280")]
		private JobHandle JJHLMFDIKDN(BAGEEEJMBMD<ObjectPolicyData_v1> component_61, BAGEEEJMBMD<ObjectPolicyData_v2> component_62, BAGEEEJMBMD<ObjectPolicyData_v3> component_63, BAGEEEJMBMD<ObjectPolicyData_v4> component_64, EJGHFBLMIPN<ObjectPolicyData> component_65, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x21B6470", Offset = "0x21B5670", VA = "0x1821B6470")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal static class OCNHIMMCCAL
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2CBE7A0", Offset = "0x2CBD9A0", VA = "0x182CBE7A0")]
	public static void EGJPEHLECMC<T>(T FFBMBHFNJKJ, [Out] T DPHPOBDCMJK) where T : struct
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
