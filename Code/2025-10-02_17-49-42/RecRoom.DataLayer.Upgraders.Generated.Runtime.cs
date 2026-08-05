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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LEIJKDKIGGD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x849F300", Offset = "0x849DD00", VA = "0x18849F300")]
	public static void BBMBEBDHLAN(ComponentSystemGroup CAEHNKCPHDD, EntityCommandBufferSystem DNCODGAOKEJ)
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
		[Cpp2IlInjected.Address(RVA = "0x849F300", Offset = "0x849DD00", VA = "0x18849F300")]
		public static void PFIGJACJNHE(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84A6AD0", Offset = "0x84A54D0", VA = "0x1884A6AD0")]
		private void BBMBEBDHLAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84A75A0", Offset = "0x84A5FA0", VA = "0x1884A75A0")]
		private void HBOLGPKJBFD(MBOGFOIFGED system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public KHJHKAKPOMC<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public PBOJNJFKAGB<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x84A1C20", Offset = "0x84A0620", VA = "0x1884A1C20")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x84A1C10", Offset = "0x84A0610", VA = "0x1884A1C10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x84A1A90", Offset = "0x84A0490", VA = "0x1884A1A90", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84A1F60", Offset = "0x84A0960", VA = "0x1884A1F60", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84A1AE0", Offset = "0x84A04E0", VA = "0x1884A1AE0")]
		private JobHandle GJMFENAPJAH(KHJHKAKPOMC<PersistentUserTagData_v1> component_1, PBOJNJFKAGB<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public KHJHKAKPOMC<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public PBOJNJFKAGB<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x849F480", Offset = "0x849DE80", VA = "0x18849F480")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x849F470", Offset = "0x849DE70", VA = "0x18849F470", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x849F420", Offset = "0x849DE20", VA = "0x18849F420", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x849F890", Offset = "0x849E290", VA = "0x18849F890", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x849F760", Offset = "0x849E160", VA = "0x18849F760")]
		private JobHandle NJALKEBNEJN(KHJHKAKPOMC<LocalDeformableScaleData_v1> component_4, PBOJNJFKAGB<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public KHJHKAKPOMC<SerializedDataLayerVersionData_v1> component_15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public PBOJNJFKAGB<SerializedDataLayerVersionData> component_16;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x84A4D50", Offset = "0x84A3750", VA = "0x1884A4D50")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x84A4D40", Offset = "0x84A3740", VA = "0x1884A4D40", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x84A4BC0", Offset = "0x84A35C0", VA = "0x1884A4BC0", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84A5010", Offset = "0x84A3A10", VA = "0x1884A5010", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84A4C10", Offset = "0x84A3610", VA = "0x1884A4C10")]
		private JobHandle GEJGCBIHKAN(KHJHKAKPOMC<SerializedDataLayerVersionData_v1> component_15, PBOJNJFKAGB<SerializedDataLayerVersionData> component_16, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public KHJHKAKPOMC<ReplicatorPreallocatedObjectCountData_v1> component_23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public PBOJNJFKAGB<ReplicatorPreallocatedObjectCountData> component_24;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x84A4740", Offset = "0x84A3140", VA = "0x1884A4740")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x84A4730", Offset = "0x84A3130", VA = "0x1884A4730", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x84A45B0", Offset = "0x84A2FB0", VA = "0x1884A45B0", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84A4A00", Offset = "0x84A3400", VA = "0x1884A4A00", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84A4600", Offset = "0x84A3000", VA = "0x1884A4600")]
		private JobHandle BPHLNCJBCFC(KHJHKAKPOMC<ReplicatorPreallocatedObjectCountData_v1> component_23, PBOJNJFKAGB<ReplicatorPreallocatedObjectCountData> component_24, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public KHJHKAKPOMC<ToolCleanupStatusData_v1> component_28;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PBOJNJFKAGB<ToolCleanupStatusData> component_29;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x84A65F0", Offset = "0x84A4FF0", VA = "0x1884A65F0")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x84A65E0", Offset = "0x84A4FE0", VA = "0x1884A65E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x84A6460", Offset = "0x84A4E60", VA = "0x1884A6460", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84A6910", Offset = "0x84A5310", VA = "0x1884A6910", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84A64B0", Offset = "0x84A4EB0", VA = "0x1884A64B0")]
		private JobHandle GFNDADBDFJN(KHJHKAKPOMC<ToolCleanupStatusData_v1> component_28, PBOJNJFKAGB<ToolCleanupStatusData> component_29, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class TerrainGenerationDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct TerrainGenerationDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public KHJHKAKPOMC<TerrainGenerationData_v1> component_31;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PBOJNJFKAGB<TerrainGenerationData> component_32;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x84A5230", Offset = "0x84A3C30", VA = "0x1884A5230")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x84A5220", Offset = "0x84A3C20", VA = "0x1884A5220", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x84A51D0", Offset = "0x84A3BD0", VA = "0x1884A51D0", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x84A5650", Offset = "0x84A4050", VA = "0x1884A5650", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84A57C0", Offset = "0x84A41C0", VA = "0x1884A57C0")]
		private JobHandle OJCGIALGMKK(KHJHKAKPOMC<TerrainGenerationData_v1> component_31, PBOJNJFKAGB<TerrainGenerationData> component_32, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public TerrainGenerationDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public KHJHKAKPOMC<ReplicatorData_v1> component_39;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PBOJNJFKAGB<ReplicatorData> component_40;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x84A40F0", Offset = "0x84A2AF0", VA = "0x1884A40F0")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x84A40E0", Offset = "0x84A2AE0", VA = "0x1884A40E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x84A3F60", Offset = "0x84A2960", VA = "0x1884A3F60", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84A43F0", Offset = "0x84A2DF0", VA = "0x1884A43F0", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84A3FB0", Offset = "0x84A29B0", VA = "0x1884A3FB0")]
		private JobHandle BNOMCMFCDMC(KHJHKAKPOMC<ReplicatorData_v1> component_39, PBOJNJFKAGB<ReplicatorData> component_40, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public KHJHKAKPOMC<InventionInstanceIdData_v1> component_43;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public PBOJNJFKAGB<InventionInstanceIdData> component_44;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x849EE90", Offset = "0x849D890", VA = "0x18849EE90")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x849EE80", Offset = "0x849D880", VA = "0x18849EE80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x849ED00", Offset = "0x849D700", VA = "0x18849ED00", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x849F140", Offset = "0x849DB40", VA = "0x18849F140", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x849ED50", Offset = "0x849D750", VA = "0x18849ED50")]
		private JobHandle GMELILJIPJN(KHJHKAKPOMC<InventionInstanceIdData_v1> component_43, PBOJNJFKAGB<InventionInstanceIdData> component_44, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class TerrainWaterDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct TerrainWaterDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public KHJHKAKPOMC<TerrainWaterData_v1> component_47;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public KHJHKAKPOMC<TerrainWaterData_v2> component_48;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public PBOJNJFKAGB<TerrainWaterData> component_49;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x84A5B50", Offset = "0x84A4550", VA = "0x1884A5B50")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x84A5B40", Offset = "0x84A4540", VA = "0x1884A5B40", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x84A5940", Offset = "0x84A4340", VA = "0x1884A5940", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x84A61F0", Offset = "0x84A4BF0", VA = "0x1884A61F0", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x84A5990", Offset = "0x84A4390", VA = "0x1884A5990")]
		private JobHandle KLCBHBNOKCD(KHJHKAKPOMC<TerrainWaterData_v1> component_47, KHJHKAKPOMC<TerrainWaterData_v2> component_48, PBOJNJFKAGB<TerrainWaterData> component_49, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public TerrainWaterDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public KHJHKAKPOMC<OMShapeContainerData_v1> component_51;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public PBOJNJFKAGB<OMShapeContainerData> component_52;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x84A0230", Offset = "0x849EC30", VA = "0x1884A0230")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x84A0220", Offset = "0x849EC20", VA = "0x1884A0220", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x84A00A0", Offset = "0x849EAA0", VA = "0x1884A00A0", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84A0520", Offset = "0x849EF20", VA = "0x1884A0520", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84A00F0", Offset = "0x849EAF0", VA = "0x1884A00F0")]
		private JobHandle GAGEGKPJDFN(KHJHKAKPOMC<OMShapeContainerData_v1> component_51, PBOJNJFKAGB<OMShapeContainerData> component_52, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class MagneticAnchorDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct MagneticAnchorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public KHJHKAKPOMC<MagneticAnchorData_v1> component_61;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public PBOJNJFKAGB<MagneticAnchorData> component_62;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x849FBE0", Offset = "0x849E5E0", VA = "0x18849FBE0")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x849FBD0", Offset = "0x849E5D0", VA = "0x18849FBD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x849FA50", Offset = "0x849E450", VA = "0x18849FA50", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x849FEE0", Offset = "0x849E8E0", VA = "0x18849FEE0", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x849FAA0", Offset = "0x849E4A0", VA = "0x18849FAA0")]
		private JobHandle FGCMOEFDFKA(KHJHKAKPOMC<MagneticAnchorData_v1> component_61, PBOJNJFKAGB<MagneticAnchorData> component_62, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public MagneticAnchorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public KHJHKAKPOMC<AuthoredAIIdData_v1> component_63;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public KHJHKAKPOMC<AuthoredAIIdData_v2> component_64;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public KHJHKAKPOMC<AuthoredAIIdData_v3> component_65;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public PBOJNJFKAGB<AuthoredAIIdData> component_66;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x849E190", Offset = "0x849CB90", VA = "0x18849E190")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x849E180", Offset = "0x849CB80", VA = "0x18849E180", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x849E130", Offset = "0x849CB30", VA = "0x18849E130", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x849EA50", Offset = "0x849D450", VA = "0x18849EA50", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x849E8B0", Offset = "0x849D2B0", VA = "0x18849E8B0")]
		private JobHandle NOHKFOLOBPA(KHJHKAKPOMC<AuthoredAIIdData_v1> component_63, KHJHKAKPOMC<AuthoredAIIdData_v2> component_64, KHJHKAKPOMC<AuthoredAIIdData_v3> component_65, PBOJNJFKAGB<AuthoredAIIdData> component_66, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public KHJHKAKPOMC<ContainerCollisionLayerData_v1> component_76;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public PBOJNJFKAGB<PhysicsModelCollisionLayerData> component_77;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x84A22B0", Offset = "0x84A0CB0", VA = "0x1884A22B0")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x84A22A0", Offset = "0x84A0CA0", VA = "0x1884A22A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x84A2250", Offset = "0x84A0C50", VA = "0x1884A2250", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x84A25A0", Offset = "0x84A0FA0", VA = "0x1884A25A0", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84A2120", Offset = "0x84A0B20", VA = "0x1884A2120")]
		private JobHandle AACCCJIENBA(KHJHKAKPOMC<ContainerCollisionLayerData_v1> component_76, PBOJNJFKAGB<PhysicsModelCollisionLayerData> component_77, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public KHJHKAKPOMC<ContainerGrabbableModeData_v1> component_81;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public PBOJNJFKAGB<PhysicsModelGrabbableModeData> component_82;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x84A3AB0", Offset = "0x84A24B0", VA = "0x1884A3AB0")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x84A3AA0", Offset = "0x84A24A0", VA = "0x1884A3AA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x84A3920", Offset = "0x84A2320", VA = "0x1884A3920", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x84A3DA0", Offset = "0x84A27A0", VA = "0x1884A3DA0", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84A3970", Offset = "0x84A2370", VA = "0x1884A3970")]
		private JobHandle GGOAIMPEHKJ(KHJHKAKPOMC<ContainerGrabbableModeData_v1> component_81, PBOJNJFKAGB<PhysicsModelGrabbableModeData> component_82, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public KHJHKAKPOMC<ContainerFlagsData_v1> component_88;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public KHJHKAKPOMC<ContainerFlagsData_v2> component_89;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public KHJHKAKPOMC<PhysicsModelFlagsData_v3> component_90;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public PBOJNJFKAGB<PhysicsModelFlagsData> component_91;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x84A2FA0", Offset = "0x84A19A0", VA = "0x1884A2FA0")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x84A2F90", Offset = "0x84A1990", VA = "0x1884A2F90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x84A2DA0", Offset = "0x84A17A0", VA = "0x1884A2DA0", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x84A3670", Offset = "0x84A2070", VA = "0x1884A3670", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x84A2DF0", Offset = "0x84A17F0", VA = "0x1884A2DF0")]
		private JobHandle FJJECIHNDED(KHJHKAKPOMC<ContainerFlagsData_v1> component_88, KHJHKAKPOMC<ContainerFlagsData_v2> component_89, KHJHKAKPOMC<PhysicsModelFlagsData_v3> component_90, PBOJNJFKAGB<PhysicsModelFlagsData> component_91, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public KHJHKAKPOMC<ContainerCollisionModeData_v1> component_92;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public PBOJNJFKAGB<PhysicsModelCollisionModeData> component_93;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x84A28F0", Offset = "0x84A12F0", VA = "0x1884A28F0")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x84A28E0", Offset = "0x84A12E0", VA = "0x1884A28E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x84A2760", Offset = "0x84A1160", VA = "0x1884A2760", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84A2BE0", Offset = "0x84A15E0", VA = "0x1884A2BE0", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84A27B0", Offset = "0x84A11B0", VA = "0x1884A27B0")]
		private JobHandle HKDNMHHNHCN(KHJHKAKPOMC<ContainerCollisionModeData_v1> component_92, PBOJNJFKAGB<PhysicsModelCollisionModeData> component_93, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : MBOGFOIFGED
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public KHJHKAKPOMC<ObjectPolicyData_v1> component_96;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public KHJHKAKPOMC<ObjectPolicyData_v2> component_97;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public KHJHKAKPOMC<ObjectPolicyData_v3> component_98;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public KHJHKAKPOMC<ObjectPolicyData_v4> component_99;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public KHJHKAKPOMC<ObjectPolicyData_v5> component_100;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public PBOJNJFKAGB<ObjectPolicyData> component_101;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x84A0940", Offset = "0x849F340", VA = "0x1884A0940")]
			private void NLOALEBKNOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x84A0930", Offset = "0x849F330", VA = "0x1884A0930", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override OLFEOKKCIEG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x84A06E0", Offset = "0x849F0E0", VA = "0x1884A06E0", Slot = "14")]
			get
			{
				return default(OLFEOKKCIEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x84A1730", Offset = "0x84A0130", VA = "0x1884A1730", Slot = "15")]
		protected override void OFPPJINCNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x84A0730", Offset = "0x849F130", VA = "0x1884A0730")]
		private JobHandle BMLCDFMHELP(KHJHKAKPOMC<ObjectPolicyData_v1> component_96, KHJHKAKPOMC<ObjectPolicyData_v2> component_97, KHJHKAKPOMC<ObjectPolicyData_v3> component_98, KHJHKAKPOMC<ObjectPolicyData_v4> component_99, KHJHKAKPOMC<ObjectPolicyData_v5> component_100, PBOJNJFKAGB<ObjectPolicyData> component_101, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class IDJOGCCDPBA
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3DECDC0", Offset = "0x3DEB7C0", VA = "0x183DECDC0")]
	public static void HFHDIIHPMEM<T, U>(T IMGODHPFAEJ, [Out] U LGLNBNPEKLK) where T : struct where U : struct
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
