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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GOKOIDMCGNF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8334CE0", Offset = "0x8333AE0", VA = "0x188334CE0")]
	public static void ACNEPNAGFDG(ComponentSystemGroup EBICCMLJNEM, EntityCommandBufferSystem PMFHNPOBHPO)
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
		[Cpp2IlInjected.Address(RVA = "0x8334CE0", Offset = "0x8333AE0", VA = "0x188334CE0")]
		public static void DOFIKDABEJA(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x833B940", Offset = "0x833A740", VA = "0x18833B940")]
		private void ACNEPNAGFDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x833C2D0", Offset = "0x833B0D0", VA = "0x18833C2D0")]
		private void GELMOJFBCJN(AODBLGBGJEN system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : AODBLGBGJEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public LIJOPIKGEIJ<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public EPEHCAILABB<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8337560", Offset = "0x8336360", VA = "0x188337560")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8337550", Offset = "0x8336350", VA = "0x188337550", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override ALMLLDBPKBM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8337A10", Offset = "0x8336810", VA = "0x188337A10", Slot = "14")]
			get
			{
				return default(ALMLLDBPKBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83378A0", Offset = "0x83366A0", VA = "0x1883378A0", Slot = "15")]
		protected override void NNBJJGHJBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8337420", Offset = "0x8336220", VA = "0x188337420")]
		private JobHandle FMHHCOFFEGB(LIJOPIKGEIJ<PersistentUserTagData_v1> component_1, EPEHCAILABB<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : AODBLGBGJEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public LIJOPIKGEIJ<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public EPEHCAILABB<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8335540", Offset = "0x8334340", VA = "0x188335540")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8335530", Offset = "0x8334330", VA = "0x188335530", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override ALMLLDBPKBM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8335990", Offset = "0x8334790", VA = "0x188335990", Slot = "14")]
			get
			{
				return default(ALMLLDBPKBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8335820", Offset = "0x8334620", VA = "0x188335820", Slot = "15")]
		protected override void NNBJJGHJBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8335400", Offset = "0x8334200", VA = "0x188335400")]
		private JobHandle FHEBHCHAGHF(LIJOPIKGEIJ<LocalDeformableScaleData_v1> component_4, EPEHCAILABB<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : AODBLGBGJEN
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public LIJOPIKGEIJ<SerializedDataLayerVersionData_v1> component_15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public EPEHCAILABB<SerializedDataLayerVersionData> component_16;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x833A690", Offset = "0x8339490", VA = "0x18833A690")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x833A680", Offset = "0x8339480", VA = "0x18833A680", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override ALMLLDBPKBM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x833AAC0", Offset = "0x83398C0", VA = "0x18833AAC0", Slot = "14")]
			get
			{
				return default(ALMLLDBPKBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x833A950", Offset = "0x8339750", VA = "0x18833A950", Slot = "15")]
		protected override void NNBJJGHJBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x833A550", Offset = "0x8339350", VA = "0x18833A550")]
		private JobHandle HLIBGBIPAOB(LIJOPIKGEIJ<SerializedDataLayerVersionData_v1> component_15, EPEHCAILABB<SerializedDataLayerVersionData> component_16, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : AODBLGBGJEN
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public LIJOPIKGEIJ<ReplicatorPreallocatedObjectCountData_v1> component_23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public EPEHCAILABB<ReplicatorPreallocatedObjectCountData> component_24;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x833A080", Offset = "0x8338E80", VA = "0x18833A080")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x833A070", Offset = "0x8338E70", VA = "0x18833A070", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override ALMLLDBPKBM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x833A4B0", Offset = "0x83392B0", VA = "0x18833A4B0", Slot = "14")]
			get
			{
				return default(ALMLLDBPKBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x833A340", Offset = "0x8339140", VA = "0x18833A340", Slot = "15")]
		protected override void NNBJJGHJBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8339F40", Offset = "0x8338D40", VA = "0x188339F40")]
		private JobHandle HPEIEICEEEH(LIJOPIKGEIJ<ReplicatorPreallocatedObjectCountData_v1> component_23, EPEHCAILABB<ReplicatorPreallocatedObjectCountData> component_24, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : AODBLGBGJEN
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public LIJOPIKGEIJ<ToolCleanupStatusData_v1> component_28;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public EPEHCAILABB<ToolCleanupStatusData> component_29;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x833B410", Offset = "0x833A210", VA = "0x18833B410")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x833B400", Offset = "0x833A200", VA = "0x18833B400", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override ALMLLDBPKBM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x833B8A0", Offset = "0x833A6A0", VA = "0x18833B8A0", Slot = "14")]
			get
			{
				return default(ALMLLDBPKBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x833B730", Offset = "0x833A530", VA = "0x18833B730", Slot = "15")]
		protected override void NNBJJGHJBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x833B2D0", Offset = "0x833A0D0", VA = "0x18833B2D0")]
		private JobHandle GEOIKOLNFDN(LIJOPIKGEIJ<ToolCleanupStatusData_v1> component_28, EPEHCAILABB<ToolCleanupStatusData> component_29, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class TerrainGenerationDataUpgradeSystem : AODBLGBGJEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct TerrainGenerationDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public LIJOPIKGEIJ<TerrainGenerationData_v1> component_31;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public EPEHCAILABB<TerrainGenerationData> component_32;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x833AB70", Offset = "0x8339970", VA = "0x18833AB70")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x833AB60", Offset = "0x8339960", VA = "0x18833AB60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override ALMLLDBPKBM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x833B230", Offset = "0x833A030", VA = "0x18833B230", Slot = "14")]
			get
			{
				return default(ALMLLDBPKBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x833B0C0", Offset = "0x8339EC0", VA = "0x18833B0C0", Slot = "15")]
		protected override void NNBJJGHJBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x833AF90", Offset = "0x8339D90", VA = "0x18833AF90")]
		private JobHandle NJBAMMALKIK(LIJOPIKGEIJ<TerrainGenerationData_v1> component_31, EPEHCAILABB<TerrainGenerationData> component_32, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
		public TerrainGenerationDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : AODBLGBGJEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public LIJOPIKGEIJ<ReplicatorData_v1> component_39;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public EPEHCAILABB<ReplicatorData> component_40;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8339A30", Offset = "0x8338830", VA = "0x188339A30")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8339A20", Offset = "0x8338820", VA = "0x188339A20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override ALMLLDBPKBM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8339EA0", Offset = "0x8338CA0", VA = "0x188339EA0", Slot = "14")]
			get
			{
				return default(ALMLLDBPKBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8339D30", Offset = "0x8338B30", VA = "0x188339D30", Slot = "15")]
		protected override void NNBJJGHJBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83398F0", Offset = "0x83386F0", VA = "0x1883398F0")]
		private JobHandle HPCEKCIFHNM(LIJOPIKGEIJ<ReplicatorData_v1> component_39, EPEHCAILABB<ReplicatorData> component_40, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : AODBLGBGJEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LIJOPIKGEIJ<InventionInstanceIdData_v1> component_43;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public EPEHCAILABB<InventionInstanceIdData> component_44;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8334E10", Offset = "0x8333C10", VA = "0x188334E10")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8334E00", Offset = "0x8333C00", VA = "0x188334E00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override ALMLLDBPKBM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8335230", Offset = "0x8334030", VA = "0x188335230", Slot = "14")]
			get
			{
				return default(ALMLLDBPKBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83350C0", Offset = "0x8333EC0", VA = "0x1883350C0", Slot = "15")]
		protected override void NNBJJGHJBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8335280", Offset = "0x8334080", VA = "0x188335280")]
		private JobHandle PPNLALMJICB(LIJOPIKGEIJ<InventionInstanceIdData_v1> component_43, EPEHCAILABB<InventionInstanceIdData> component_44, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : AODBLGBGJEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public LIJOPIKGEIJ<OMShapeContainerData_v1> component_49;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public EPEHCAILABB<OMShapeContainerData> component_50;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8335A40", Offset = "0x8334840", VA = "0x188335A40")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8335A30", Offset = "0x8334830", VA = "0x188335A30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override ALMLLDBPKBM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8335FD0", Offset = "0x8334DD0", VA = "0x188335FD0", Slot = "14")]
			get
			{
				return default(ALMLLDBPKBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8335E60", Offset = "0x8334C60", VA = "0x188335E60", Slot = "15")]
		protected override void NNBJJGHJBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8335D30", Offset = "0x8334B30", VA = "0x188335D30")]
		private JobHandle NLOCAJBJHMK(LIJOPIKGEIJ<OMShapeContainerData_v1> component_49, EPEHCAILABB<OMShapeContainerData> component_50, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : AODBLGBGJEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public LIJOPIKGEIJ<AuthoredAIIdData_v1> component_60;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public LIJOPIKGEIJ<AuthoredAIIdData_v2> component_61;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public LIJOPIKGEIJ<AuthoredAIIdData_v3> component_62;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public EPEHCAILABB<AuthoredAIIdData> component_63;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x83342C0", Offset = "0x83330C0", VA = "0x1883342C0")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x83342B0", Offset = "0x83330B0", VA = "0x1883342B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override ALMLLDBPKBM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8334C40", Offset = "0x8333A40", VA = "0x188334C40", Slot = "14")]
			get
			{
				return default(ALMLLDBPKBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83349E0", Offset = "0x83337E0", VA = "0x1883349E0", Slot = "15")]
		protected override void NNBJJGHJBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8334110", Offset = "0x8332F10", VA = "0x188334110")]
		private JobHandle DFIMBOJKHOK(LIJOPIKGEIJ<AuthoredAIIdData_v1> component_60, LIJOPIKGEIJ<AuthoredAIIdData_v2> component_61, LIJOPIKGEIJ<AuthoredAIIdData_v3> component_62, EPEHCAILABB<AuthoredAIIdData> component_63, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : AODBLGBGJEN
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public LIJOPIKGEIJ<ContainerCollisionLayerData_v1> component_73;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public EPEHCAILABB<PhysicsModelCollisionLayerData> component_74;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8337BF0", Offset = "0x83369F0", VA = "0x188337BF0")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8337BE0", Offset = "0x83369E0", VA = "0x188337BE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override ALMLLDBPKBM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8338050", Offset = "0x8336E50", VA = "0x188338050", Slot = "14")]
			get
			{
				return default(ALMLLDBPKBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8337EE0", Offset = "0x8336CE0", VA = "0x188337EE0", Slot = "15")]
		protected override void NNBJJGHJBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8337AB0", Offset = "0x83368B0", VA = "0x188337AB0")]
		private JobHandle ILKEBPDJHCP(LIJOPIKGEIJ<ContainerCollisionLayerData_v1> component_73, EPEHCAILABB<PhysicsModelCollisionLayerData> component_74, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : AODBLGBGJEN
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public LIJOPIKGEIJ<ContainerGrabbableModeData_v1> component_78;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public EPEHCAILABB<PhysicsModelGrabbableModeData> component_79;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x83392C0", Offset = "0x83380C0", VA = "0x1883392C0")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x83392B0", Offset = "0x83380B0", VA = "0x1883392B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override ALMLLDBPKBM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8339720", Offset = "0x8338520", VA = "0x188339720", Slot = "14")]
			get
			{
				return default(ALMLLDBPKBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x83395B0", Offset = "0x83383B0", VA = "0x1883395B0", Slot = "15")]
		protected override void NNBJJGHJBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8339770", Offset = "0x8338570", VA = "0x188339770")]
		private JobHandle OMJCBMHJJOP(LIJOPIKGEIJ<ContainerGrabbableModeData_v1> component_78, EPEHCAILABB<PhysicsModelGrabbableModeData> component_79, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : AODBLGBGJEN
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public LIJOPIKGEIJ<ContainerFlagsData_v1> component_85;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public LIJOPIKGEIJ<ContainerFlagsData_v2> component_86;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public LIJOPIKGEIJ<PhysicsModelFlagsData_v3> component_87;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public EPEHCAILABB<PhysicsModelFlagsData> component_88;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x83388E0", Offset = "0x83376E0", VA = "0x1883388E0")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x83388D0", Offset = "0x83376D0", VA = "0x1883388D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override ALMLLDBPKBM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8339210", Offset = "0x8338010", VA = "0x188339210", Slot = "14")]
			get
			{
				return default(ALMLLDBPKBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8338FB0", Offset = "0x8337DB0", VA = "0x188338FB0", Slot = "15")]
		protected override void NNBJJGHJBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8338730", Offset = "0x8337530", VA = "0x188338730")]
		private JobHandle JELEFENPJIM(LIJOPIKGEIJ<ContainerFlagsData_v1> component_85, LIJOPIKGEIJ<ContainerFlagsData_v2> component_86, LIJOPIKGEIJ<PhysicsModelFlagsData_v3> component_87, EPEHCAILABB<PhysicsModelFlagsData> component_88, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : AODBLGBGJEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public LIJOPIKGEIJ<ContainerCollisionModeData_v1> component_89;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public EPEHCAILABB<PhysicsModelCollisionModeData> component_90;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8338230", Offset = "0x8337030", VA = "0x188338230")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8338220", Offset = "0x8337020", VA = "0x188338220", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override ALMLLDBPKBM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8338690", Offset = "0x8337490", VA = "0x188338690", Slot = "14")]
			get
			{
				return default(ALMLLDBPKBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8338520", Offset = "0x8337320", VA = "0x188338520", Slot = "15")]
		protected override void NNBJJGHJBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83380F0", Offset = "0x8336EF0", VA = "0x1883380F0")]
		private JobHandle DPNLJOPFDBG(LIJOPIKGEIJ<ContainerCollisionModeData_v1> component_89, EPEHCAILABB<PhysicsModelCollisionModeData> component_90, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : AODBLGBGJEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public LIJOPIKGEIJ<ObjectPolicyData_v1> component_93;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public LIJOPIKGEIJ<ObjectPolicyData_v2> component_94;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public LIJOPIKGEIJ<ObjectPolicyData_v3> component_95;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public LIJOPIKGEIJ<ObjectPolicyData_v4> component_96;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public LIJOPIKGEIJ<ObjectPolicyData_v5> component_97;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public EPEHCAILABB<ObjectPolicyData> component_98;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8336080", Offset = "0x8334E80", VA = "0x188336080")]
			private void NAIPPLMNFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8336070", Offset = "0x8334E70", VA = "0x188336070", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected override ALMLLDBPKBM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8337380", Offset = "0x8336180", VA = "0x188337380", Slot = "14")]
			get
			{
				return default(ALMLLDBPKBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8337070", Offset = "0x8335E70", VA = "0x188337070", Slot = "15")]
		protected override void NNBJJGHJBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8336E70", Offset = "0x8335C70", VA = "0x188336E70")]
		private JobHandle NJDIFAMHBKL(LIJOPIKGEIJ<ObjectPolicyData_v1> component_93, LIJOPIKGEIJ<ObjectPolicyData_v2> component_94, LIJOPIKGEIJ<ObjectPolicyData_v3> component_95, LIJOPIKGEIJ<ObjectPolicyData_v4> component_96, LIJOPIKGEIJ<ObjectPolicyData_v5> component_97, EPEHCAILABB<ObjectPolicyData> component_98, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class HMELJKAPDHN
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3D29FC0", Offset = "0x3D28DC0", VA = "0x183D29FC0")]
	public static void MEPHKFOAOGF<T, U>(T ADNIDBPMOJD, [Out] U JABMJNDCEIN) where T : struct where U : struct
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
