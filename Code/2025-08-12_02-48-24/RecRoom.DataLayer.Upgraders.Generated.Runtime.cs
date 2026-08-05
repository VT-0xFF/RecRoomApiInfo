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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OOPCPHJLOHF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x840E9B0", Offset = "0x840CFB0", VA = "0x18840E9B0")]
	public static void PCAJIONGDGC(ComponentSystemGroup IJNDEDMJCID, EntityCommandBufferSystem BCHBFJKPOIB)
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
		[Cpp2IlInjected.Address(RVA = "0x840E9B0", Offset = "0x840CFB0", VA = "0x18840E9B0")]
		public static void GELKFPELAHA(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8414430", Offset = "0x8412A30", VA = "0x188414430")]
		private void PCAJIONGDGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84143A0", Offset = "0x84129A0", VA = "0x1884143A0")]
		private void FINBHEEIEDO(JJGJGPDOCLP system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : JJGJGPDOCLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public HDMLBFJCEFD<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public NAJOABDPOKN<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8410170", Offset = "0x840E770", VA = "0x188410170")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x84104B0", Offset = "0x840EAB0", VA = "0x1884104B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override IDGHEFJHGEI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8410120", Offset = "0x840E720", VA = "0x188410120", Slot = "14")]
			get
			{
				return default(IDGHEFJHGEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x840FFB0", Offset = "0x840E5B0", VA = "0x18840FFB0", Slot = "15")]
		protected override void EHHIPFLBJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x840FE80", Offset = "0x840E480", VA = "0x18840FE80")]
		private JobHandle CBBMLHEIKLI(HDMLBFJCEFD<PersistentUserTagData_v1> component_1, NAJOABDPOKN<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : JJGJGPDOCLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public HDMLBFJCEFD<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public NAJOABDPOKN<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x840E030", Offset = "0x840C630", VA = "0x18840E030")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x840E310", Offset = "0x840C910", VA = "0x18840E310", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override IDGHEFJHGEI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x840DFE0", Offset = "0x840C5E0", VA = "0x18840DFE0", Slot = "14")]
			get
			{
				return default(IDGHEFJHGEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x840DD40", Offset = "0x840C340", VA = "0x18840DD40", Slot = "15")]
		protected override void EHHIPFLBJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x840DEB0", Offset = "0x840C4B0", VA = "0x18840DEB0")]
		private JobHandle JPLLMGMOGNK(HDMLBFJCEFD<LocalDeformableScaleData_v1> component_4, NAJOABDPOKN<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : JJGJGPDOCLP
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public HDMLBFJCEFD<SerializedDataLayerVersionData_v1> component_15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public NAJOABDPOKN<SerializedDataLayerVersionData> component_16;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x84132A0", Offset = "0x84118A0", VA = "0x1884132A0")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8413560", Offset = "0x8411B60", VA = "0x188413560", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override IDGHEFJHGEI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8413250", Offset = "0x8411850", VA = "0x188413250", Slot = "14")]
			get
			{
				return default(IDGHEFJHGEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8412FB0", Offset = "0x84115B0", VA = "0x188412FB0", Slot = "15")]
		protected override void EHHIPFLBJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8413120", Offset = "0x8411720", VA = "0x188413120")]
		private JobHandle EJOEHOGEAMH(HDMLBFJCEFD<SerializedDataLayerVersionData_v1> component_15, NAJOABDPOKN<SerializedDataLayerVersionData> component_16, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : JJGJGPDOCLP
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public HDMLBFJCEFD<ReplicatorPreallocatedObjectCountData_v1> component_23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public NAJOABDPOKN<ReplicatorPreallocatedObjectCountData> component_24;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8412C90", Offset = "0x8411290", VA = "0x188412C90")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8412F50", Offset = "0x8411550", VA = "0x188412F50", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override IDGHEFJHGEI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8412C40", Offset = "0x8411240", VA = "0x188412C40", Slot = "14")]
			get
			{
				return default(IDGHEFJHGEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84129A0", Offset = "0x8410FA0", VA = "0x1884129A0", Slot = "15")]
		protected override void EHHIPFLBJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8412B10", Offset = "0x8411110", VA = "0x188412B10")]
		private JobHandle KIDBGFLCNHO(HDMLBFJCEFD<ReplicatorPreallocatedObjectCountData_v1> component_23, NAJOABDPOKN<ReplicatorPreallocatedObjectCountData> component_24, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : JJGJGPDOCLP
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public HDMLBFJCEFD<ToolCleanupStatusData_v1> component_28;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public NAJOABDPOKN<ToolCleanupStatusData> component_29;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8413EF0", Offset = "0x84124F0", VA = "0x188413EF0")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8414210", Offset = "0x8412810", VA = "0x188414210", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override IDGHEFJHGEI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8413EA0", Offset = "0x84124A0", VA = "0x188413EA0", Slot = "14")]
			get
			{
				return default(IDGHEFJHGEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8413D30", Offset = "0x8412330", VA = "0x188413D30", Slot = "15")]
		protected override void EHHIPFLBJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8414220", Offset = "0x8412820", VA = "0x188414220")]
		private JobHandle MKDKDBIACJB(HDMLBFJCEFD<ToolCleanupStatusData_v1> component_28, NAJOABDPOKN<ToolCleanupStatusData> component_29, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class TerrainGenerationDataUpgradeSystem : JJGJGPDOCLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct TerrainGenerationDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public HDMLBFJCEFD<TerrainGenerationData_v1> component_31;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public NAJOABDPOKN<TerrainGenerationData> component_32;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x84138B0", Offset = "0x8411EB0", VA = "0x1884138B0")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8413CD0", Offset = "0x84122D0", VA = "0x188413CD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override IDGHEFJHGEI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8413860", Offset = "0x8411E60", VA = "0x188413860", Slot = "14")]
			get
			{
				return default(IDGHEFJHGEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x84135C0", Offset = "0x8411BC0", VA = "0x1884135C0", Slot = "15")]
		protected override void EHHIPFLBJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8413730", Offset = "0x8411D30", VA = "0x188413730")]
		private JobHandle HHCFNKMNAHA(HDMLBFJCEFD<TerrainGenerationData_v1> component_31, NAJOABDPOKN<TerrainGenerationData> component_32, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
		public TerrainGenerationDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : JJGJGPDOCLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public HDMLBFJCEFD<ReplicatorData_v1> component_39;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public NAJOABDPOKN<ReplicatorData> component_40;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8412640", Offset = "0x8410C40", VA = "0x188412640")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8412940", Offset = "0x8410F40", VA = "0x188412940", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override IDGHEFJHGEI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x84125F0", Offset = "0x8410BF0", VA = "0x1884125F0", Slot = "14")]
			get
			{
				return default(IDGHEFJHGEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8412350", Offset = "0x8410950", VA = "0x188412350", Slot = "15")]
		protected override void EHHIPFLBJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84124C0", Offset = "0x8410AC0", VA = "0x1884124C0")]
		private JobHandle FDKNJJOMDOA(HDMLBFJCEFD<ReplicatorData_v1> component_39, NAJOABDPOKN<ReplicatorData> component_40, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : JJGJGPDOCLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HDMLBFJCEFD<InventionInstanceIdData_v1> component_43;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public NAJOABDPOKN<InventionInstanceIdData> component_44;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x840DA30", Offset = "0x840C030", VA = "0x18840DA30")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x840DCE0", Offset = "0x840C2E0", VA = "0x18840DCE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override IDGHEFJHGEI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x840D9E0", Offset = "0x840BFE0", VA = "0x18840D9E0", Slot = "14")]
			get
			{
				return default(IDGHEFJHGEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x840D740", Offset = "0x840BD40", VA = "0x18840D740", Slot = "15")]
		protected override void EHHIPFLBJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x840D8B0", Offset = "0x840BEB0", VA = "0x18840D8B0")]
		private JobHandle FFEGADOCNCE(HDMLBFJCEFD<InventionInstanceIdData_v1> component_43, NAJOABDPOKN<InventionInstanceIdData> component_44, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : JJGJGPDOCLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public HDMLBFJCEFD<OMShapeContainerData_v1> component_49;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public NAJOABDPOKN<OMShapeContainerData> component_50;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x840E660", Offset = "0x840CC60", VA = "0x18840E660")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x840E950", Offset = "0x840CF50", VA = "0x18840E950", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override IDGHEFJHGEI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x840E610", Offset = "0x840CC10", VA = "0x18840E610", Slot = "14")]
			get
			{
				return default(IDGHEFJHGEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x840E370", Offset = "0x840C970", VA = "0x18840E370", Slot = "15")]
		protected override void EHHIPFLBJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x840E4E0", Offset = "0x840CAE0", VA = "0x18840E4E0")]
		private JobHandle ILCLOACCEPC(HDMLBFJCEFD<OMShapeContainerData_v1> component_49, NAJOABDPOKN<OMShapeContainerData> component_50, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : JJGJGPDOCLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public HDMLBFJCEFD<AuthoredAIIdData_v1> component_60;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public HDMLBFJCEFD<AuthoredAIIdData_v2> component_61;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public HDMLBFJCEFD<AuthoredAIIdData_v3> component_62;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public NAJOABDPOKN<AuthoredAIIdData> component_63;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x840CFC0", Offset = "0x840B5C0", VA = "0x18840CFC0")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x840D6E0", Offset = "0x840BCE0", VA = "0x18840D6E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override IDGHEFJHGEI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x840CF70", Offset = "0x840B570", VA = "0x18840CF70", Slot = "14")]
			get
			{
				return default(IDGHEFJHGEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x840CB70", Offset = "0x840B170", VA = "0x18840CB70", Slot = "15")]
		protected override void EHHIPFLBJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x840CDD0", Offset = "0x840B3D0", VA = "0x18840CDD0")]
		private JobHandle GAIDGALAOMJ(HDMLBFJCEFD<AuthoredAIIdData_v1> component_60, HDMLBFJCEFD<AuthoredAIIdData_v2> component_61, HDMLBFJCEFD<AuthoredAIIdData_v3> component_62, NAJOABDPOKN<AuthoredAIIdData> component_63, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : JJGJGPDOCLP
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public HDMLBFJCEFD<ContainerCollisionLayerData_v1> component_73;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public NAJOABDPOKN<PhysicsModelCollisionLayerData> component_74;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8410800", Offset = "0x840EE00", VA = "0x188410800")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8410AF0", Offset = "0x840F0F0", VA = "0x188410AF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override IDGHEFJHGEI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x84107B0", Offset = "0x840EDB0", VA = "0x1884107B0", Slot = "14")]
			get
			{
				return default(IDGHEFJHGEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8410510", Offset = "0x840EB10", VA = "0x188410510", Slot = "15")]
		protected override void EHHIPFLBJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8410680", Offset = "0x840EC80", VA = "0x188410680")]
		private JobHandle FALOHHFCHIO(HDMLBFJCEFD<ContainerCollisionLayerData_v1> component_73, NAJOABDPOKN<PhysicsModelCollisionLayerData> component_74, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : JJGJGPDOCLP
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public HDMLBFJCEFD<ContainerGrabbableModeData_v1> component_78;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public NAJOABDPOKN<PhysicsModelGrabbableModeData> component_79;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8412000", Offset = "0x8410600", VA = "0x188412000")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x84122F0", Offset = "0x84108F0", VA = "0x1884122F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override IDGHEFJHGEI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8411FB0", Offset = "0x84105B0", VA = "0x188411FB0", Slot = "14")]
			get
			{
				return default(IDGHEFJHGEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8411D10", Offset = "0x8410310", VA = "0x188411D10", Slot = "15")]
		protected override void EHHIPFLBJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8411E80", Offset = "0x8410480", VA = "0x188411E80")]
		private JobHandle KIOEHGKHBGE(HDMLBFJCEFD<ContainerGrabbableModeData_v1> component_78, NAJOABDPOKN<PhysicsModelGrabbableModeData> component_79, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : JJGJGPDOCLP
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public HDMLBFJCEFD<ContainerFlagsData_v1> component_85;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public HDMLBFJCEFD<ContainerFlagsData_v2> component_86;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public HDMLBFJCEFD<PhysicsModelFlagsData_v3> component_87;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public NAJOABDPOKN<PhysicsModelFlagsData> component_88;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x84115E0", Offset = "0x840FBE0", VA = "0x1884115E0")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8411CB0", Offset = "0x84102B0", VA = "0x188411CB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override IDGHEFJHGEI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8411590", Offset = "0x840FB90", VA = "0x188411590", Slot = "14")]
			get
			{
				return default(IDGHEFJHGEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8411330", Offset = "0x840F930", VA = "0x188411330", Slot = "15")]
		protected override void EHHIPFLBJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8411190", Offset = "0x840F790", VA = "0x188411190")]
		private JobHandle CAJIDJDANDM(HDMLBFJCEFD<ContainerFlagsData_v1> component_85, HDMLBFJCEFD<ContainerFlagsData_v2> component_86, HDMLBFJCEFD<PhysicsModelFlagsData_v3> component_87, NAJOABDPOKN<PhysicsModelFlagsData> component_88, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : JJGJGPDOCLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public HDMLBFJCEFD<ContainerCollisionModeData_v1> component_89;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public NAJOABDPOKN<PhysicsModelCollisionModeData> component_90;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8410D10", Offset = "0x840F310", VA = "0x188410D10")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8411000", Offset = "0x840F600", VA = "0x188411000", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override IDGHEFJHGEI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8410CC0", Offset = "0x840F2C0", VA = "0x188410CC0", Slot = "14")]
			get
			{
				return default(IDGHEFJHGEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8410B50", Offset = "0x840F150", VA = "0x188410B50", Slot = "15")]
		protected override void EHHIPFLBJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8411010", Offset = "0x840F610", VA = "0x188411010")]
		private JobHandle PMFFBFJECMM(HDMLBFJCEFD<ContainerCollisionModeData_v1> component_89, NAJOABDPOKN<PhysicsModelCollisionModeData> component_90, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : JJGJGPDOCLP
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public HDMLBFJCEFD<ObjectPolicyData_v1> component_93;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public HDMLBFJCEFD<ObjectPolicyData_v2> component_94;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public HDMLBFJCEFD<ObjectPolicyData_v3> component_95;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public HDMLBFJCEFD<ObjectPolicyData_v4> component_96;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public HDMLBFJCEFD<ObjectPolicyData_v5> component_97;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public NAJOABDPOKN<ObjectPolicyData> component_98;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x840F030", Offset = "0x840D630", VA = "0x18840F030")]
			private void AAGLOGBCLIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x840FE20", Offset = "0x840E420", VA = "0x18840FE20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly IDGHEFJHGEI log;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected override IDGHEFJHGEI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x840EFE0", Offset = "0x840D5E0", VA = "0x18840EFE0", Slot = "14")]
			get
			{
				return default(IDGHEFJHGEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x840EAD0", Offset = "0x840D0D0", VA = "0x18840EAD0", Slot = "15")]
		protected override void EHHIPFLBJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x840EDE0", Offset = "0x840D3E0", VA = "0x18840EDE0")]
		private JobHandle JPNCHEOEELJ(HDMLBFJCEFD<ObjectPolicyData_v1> component_93, HDMLBFJCEFD<ObjectPolicyData_v2> component_94, HDMLBFJCEFD<ObjectPolicyData_v3> component_95, HDMLBFJCEFD<ObjectPolicyData_v4> component_96, HDMLBFJCEFD<ObjectPolicyData_v5> component_97, NAJOABDPOKN<ObjectPolicyData> component_98, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class HCBPFKCPCIC
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3DB7090", Offset = "0x3DB5690", VA = "0x183DB7090")]
	public static void EPIACEEILHB<T, U>(T GFHDKHCEGAG, [Out] U NMDPPNGCJLE) where T : struct where U : struct
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
