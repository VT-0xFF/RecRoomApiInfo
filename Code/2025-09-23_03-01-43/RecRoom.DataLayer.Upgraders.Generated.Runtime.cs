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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NEBGHADNGLM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x84A9FD0", Offset = "0x84A85D0", VA = "0x1884A9FD0")]
	public static void JJCCKNINANL(ComponentSystemGroup DIHEIGLHFII, EntityCommandBufferSystem LPDGJCPFNGO)
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
		[Cpp2IlInjected.Address(RVA = "0x84A9FD0", Offset = "0x84A85D0", VA = "0x1884A9FD0")]
		public static void MJNDLICADCC(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84B0B20", Offset = "0x84AF120", VA = "0x1884B0B20")]
		private void JJCCKNINANL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84B15F0", Offset = "0x84AFBF0", VA = "0x1884B15F0")]
		private void NFBJBDEBDNK(GAEPCFMEMPO system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public KPBEPIDNAAM<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public EKBDALKOBJJ<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x84ABC50", Offset = "0x84AA250", VA = "0x1884ABC50")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x84ABF90", Offset = "0x84AA590", VA = "0x1884ABF90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x84AC0D0", Offset = "0x84AA6D0", VA = "0x1884AC0D0", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84ABAE0", Offset = "0x84AA0E0", VA = "0x1884ABAE0", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84ABFA0", Offset = "0x84AA5A0", VA = "0x1884ABFA0")]
		private JobHandle OGILMFJEABM(KPBEPIDNAAM<PersistentUserTagData_v1> component_1, EKBDALKOBJJ<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public KPBEPIDNAAM<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public EKBDALKOBJJ<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x84A95F0", Offset = "0x84A7BF0", VA = "0x1884A95F0")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x84A98D0", Offset = "0x84A7ED0", VA = "0x1884A98D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x84A98E0", Offset = "0x84A7EE0", VA = "0x1884A98E0", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84A9480", Offset = "0x84A7A80", VA = "0x1884A9480", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84A9350", Offset = "0x84A7950", VA = "0x1884A9350")]
		private JobHandle CFCMFNMKMOD(KPBEPIDNAAM<LocalDeformableScaleData_v1> component_4, EKBDALKOBJJ<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public KPBEPIDNAAM<SerializedDataLayerVersionData_v1> component_15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public EKBDALKOBJJ<SerializedDataLayerVersionData> component_16;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x84AEEB0", Offset = "0x84AD4B0", VA = "0x1884AEEB0")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x84AF170", Offset = "0x84AD770", VA = "0x1884AF170", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x84AF180", Offset = "0x84AD780", VA = "0x1884AF180", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84AED40", Offset = "0x84AD340", VA = "0x1884AED40", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84AEC10", Offset = "0x84AD210", VA = "0x1884AEC10")]
		private JobHandle IOGKEJCKBBB(KPBEPIDNAAM<SerializedDataLayerVersionData_v1> component_15, EKBDALKOBJJ<SerializedDataLayerVersionData> component_16, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public KPBEPIDNAAM<ReplicatorPreallocatedObjectCountData_v1> component_23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public EKBDALKOBJJ<ReplicatorPreallocatedObjectCountData> component_24;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x84AE8A0", Offset = "0x84ACEA0", VA = "0x1884AE8A0")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x84AEB60", Offset = "0x84AD160", VA = "0x1884AEB60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x84AEB70", Offset = "0x84AD170", VA = "0x1884AEB70", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84AE730", Offset = "0x84ACD30", VA = "0x1884AE730", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84AE600", Offset = "0x84ACC00", VA = "0x1884AE600")]
		private JobHandle EKDCNPPCOAN(KPBEPIDNAAM<ReplicatorPreallocatedObjectCountData_v1> component_23, EKBDALKOBJJ<ReplicatorPreallocatedObjectCountData> component_24, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public KPBEPIDNAAM<ToolCleanupStatusData_v1> component_28;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public EKBDALKOBJJ<ToolCleanupStatusData> component_29;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x84B0620", Offset = "0x84AEC20", VA = "0x1884B0620")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x84B0940", Offset = "0x84AEF40", VA = "0x1884B0940", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x84B0A80", Offset = "0x84AF080", VA = "0x1884B0A80", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84B04B0", Offset = "0x84AEAB0", VA = "0x1884B04B0", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84B0950", Offset = "0x84AEF50", VA = "0x1884B0950")]
		private JobHandle PBODIGBECFP(KPBEPIDNAAM<ToolCleanupStatusData_v1> component_28, EKBDALKOBJJ<ToolCleanupStatusData> component_29, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class TerrainGenerationDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct TerrainGenerationDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public KPBEPIDNAAM<TerrainGenerationData_v1> component_31;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public EKBDALKOBJJ<TerrainGenerationData> component_32;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x84AF4C0", Offset = "0x84ADAC0", VA = "0x1884AF4C0")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x84AF8E0", Offset = "0x84ADEE0", VA = "0x1884AF8E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x84AF8F0", Offset = "0x84ADEF0", VA = "0x1884AF8F0", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x84AF350", Offset = "0x84AD950", VA = "0x1884AF350", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84AF220", Offset = "0x84AD820", VA = "0x1884AF220")]
		private JobHandle APBFLJGOKNJ(KPBEPIDNAAM<TerrainGenerationData_v1> component_31, EKBDALKOBJJ<TerrainGenerationData> component_32, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public TerrainGenerationDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public KPBEPIDNAAM<ReplicatorData_v1> component_39;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public EKBDALKOBJJ<ReplicatorData> component_40;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x84AE250", Offset = "0x84AC850", VA = "0x1884AE250")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x84AE550", Offset = "0x84ACB50", VA = "0x1884AE550", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x84AE560", Offset = "0x84ACB60", VA = "0x1884AE560", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84AE0E0", Offset = "0x84AC6E0", VA = "0x1884AE0E0", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84ADFB0", Offset = "0x84AC5B0", VA = "0x1884ADFB0")]
		private JobHandle EDPDEKEGLOI(KPBEPIDNAAM<ReplicatorData_v1> component_39, EKBDALKOBJJ<ReplicatorData> component_40, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public KPBEPIDNAAM<InventionInstanceIdData_v1> component_43;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public EKBDALKOBJJ<InventionInstanceIdData> component_44;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x84A8FF0", Offset = "0x84A75F0", VA = "0x1884A8FF0")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x84A92A0", Offset = "0x84A78A0", VA = "0x1884A92A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x84A92B0", Offset = "0x84A78B0", VA = "0x1884A92B0", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x84A8E80", Offset = "0x84A7480", VA = "0x1884A8E80", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84A8D50", Offset = "0x84A7350", VA = "0x1884A8D50")]
		private JobHandle GGKLFNCCIDC(KPBEPIDNAAM<InventionInstanceIdData_v1> component_43, EKBDALKOBJJ<InventionInstanceIdData> component_44, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class TerrainWaterDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct TerrainWaterDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public KPBEPIDNAAM<TerrainWaterData_v1> component_47;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public KPBEPIDNAAM<TerrainWaterData_v2> component_48;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public EKBDALKOBJJ<TerrainWaterData> component_49;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x84AFD60", Offset = "0x84AE360", VA = "0x1884AFD60")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x84B0400", Offset = "0x84AEA00", VA = "0x1884B0400", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x84B0410", Offset = "0x84AEA10", VA = "0x1884B0410", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x84AFB40", Offset = "0x84AE140", VA = "0x1884AFB40", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x84AF990", Offset = "0x84ADF90", VA = "0x1884AF990")]
		private JobHandle DCEGOPKBMEF(KPBEPIDNAAM<TerrainWaterData_v1> component_47, KPBEPIDNAAM<TerrainWaterData_v2> component_48, EKBDALKOBJJ<TerrainWaterData> component_49, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public TerrainWaterDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public KPBEPIDNAAM<OMShapeContainerData_v1> component_51;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public EKBDALKOBJJ<OMShapeContainerData> component_52;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x84AA390", Offset = "0x84A8990", VA = "0x1884AA390")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x84AA680", Offset = "0x84A8C80", VA = "0x1884AA680", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x84AA690", Offset = "0x84A8C90", VA = "0x1884AA690", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84AA220", Offset = "0x84A8820", VA = "0x1884AA220", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84AA0F0", Offset = "0x84A86F0", VA = "0x1884AA0F0")]
		private JobHandle CKNHEOIONCA(KPBEPIDNAAM<OMShapeContainerData_v1> component_51, EKBDALKOBJJ<OMShapeContainerData> component_52, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class MagneticAnchorDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct MagneticAnchorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public KPBEPIDNAAM<MagneticAnchorData_v1> component_61;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public EKBDALKOBJJ<MagneticAnchorData> component_62;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x84A9C20", Offset = "0x84A8220", VA = "0x1884A9C20")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x84A9F20", Offset = "0x84A8520", VA = "0x1884A9F20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x84A9F30", Offset = "0x84A8530", VA = "0x1884A9F30", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x84A9AB0", Offset = "0x84A80B0", VA = "0x1884A9AB0", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x84A9980", Offset = "0x84A7F80", VA = "0x1884A9980")]
		private JobHandle LADDBIJBLIL(KPBEPIDNAAM<MagneticAnchorData_v1> component_61, EKBDALKOBJJ<MagneticAnchorData> component_62, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public MagneticAnchorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public KPBEPIDNAAM<AuthoredAIIdData_v1> component_63;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public KPBEPIDNAAM<AuthoredAIIdData_v2> component_64;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public KPBEPIDNAAM<AuthoredAIIdData_v3> component_65;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public EKBDALKOBJJ<AuthoredAIIdData> component_66;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x84A8580", Offset = "0x84A6B80", VA = "0x1884A8580")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x84A8CA0", Offset = "0x84A72A0", VA = "0x1884A8CA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x84A8CB0", Offset = "0x84A72B0", VA = "0x1884A8CB0", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x84A8320", Offset = "0x84A6920", VA = "0x1884A8320", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x84A8180", Offset = "0x84A6780", VA = "0x1884A8180")]
		private JobHandle KMPJEJCOMJI(KPBEPIDNAAM<AuthoredAIIdData_v1> component_63, KPBEPIDNAAM<AuthoredAIIdData_v2> component_64, KPBEPIDNAAM<AuthoredAIIdData_v3> component_65, EKBDALKOBJJ<AuthoredAIIdData> component_66, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public KPBEPIDNAAM<ContainerCollisionLayerData_v1> component_76;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public EKBDALKOBJJ<PhysicsModelCollisionLayerData> component_77;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x84AC410", Offset = "0x84AAA10", VA = "0x1884AC410")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x84AC700", Offset = "0x84AAD00", VA = "0x1884AC700", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x84AC710", Offset = "0x84AAD10", VA = "0x1884AC710", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x84AC2A0", Offset = "0x84AA8A0", VA = "0x1884AC2A0", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84AC170", Offset = "0x84AA770", VA = "0x1884AC170")]
		private JobHandle CMLBIABPPJJ(KPBEPIDNAAM<ContainerCollisionLayerData_v1> component_76, EKBDALKOBJJ<PhysicsModelCollisionLayerData> component_77, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public KPBEPIDNAAM<ContainerGrabbableModeData_v1> component_81;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public EKBDALKOBJJ<PhysicsModelGrabbableModeData> component_82;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x84ADAE0", Offset = "0x84AC0E0", VA = "0x1884ADAE0")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x84ADDD0", Offset = "0x84AC3D0", VA = "0x1884ADDD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x84ADF10", Offset = "0x84AC510", VA = "0x1884ADF10", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x84AD970", Offset = "0x84ABF70", VA = "0x1884AD970", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84ADDE0", Offset = "0x84AC3E0", VA = "0x1884ADDE0")]
		private JobHandle PBIKHHHLMGL(KPBEPIDNAAM<ContainerGrabbableModeData_v1> component_81, EKBDALKOBJJ<PhysicsModelGrabbableModeData> component_82, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public KPBEPIDNAAM<ContainerFlagsData_v1> component_88;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public KPBEPIDNAAM<ContainerFlagsData_v2> component_89;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public KPBEPIDNAAM<PhysicsModelFlagsData_v3> component_90;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public EKBDALKOBJJ<PhysicsModelFlagsData> component_91;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x84AD050", Offset = "0x84AB650", VA = "0x1884AD050")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x84AD720", Offset = "0x84ABD20", VA = "0x1884AD720", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x84AD730", Offset = "0x84ABD30", VA = "0x1884AD730", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x84ACDF0", Offset = "0x84AB3F0", VA = "0x1884ACDF0", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x84AD780", Offset = "0x84ABD80", VA = "0x1884AD780")]
		private JobHandle PIAJOCKBCAH(KPBEPIDNAAM<ContainerFlagsData_v1> component_88, KPBEPIDNAAM<ContainerFlagsData_v2> component_89, KPBEPIDNAAM<PhysicsModelFlagsData_v3> component_90, EKBDALKOBJJ<PhysicsModelFlagsData> component_91, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public KPBEPIDNAAM<ContainerCollisionModeData_v1> component_92;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public EKBDALKOBJJ<PhysicsModelCollisionModeData> component_93;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x84ACA50", Offset = "0x84AB050", VA = "0x1884ACA50")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x84ACD40", Offset = "0x84AB340", VA = "0x1884ACD40", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x84ACD50", Offset = "0x84AB350", VA = "0x1884ACD50", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84AC8E0", Offset = "0x84AAEE0", VA = "0x1884AC8E0", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84AC7B0", Offset = "0x84AADB0", VA = "0x1884AC7B0")]
		private JobHandle DJFGNCEPOIC(KPBEPIDNAAM<ContainerCollisionModeData_v1> component_92, EKBDALKOBJJ<PhysicsModelCollisionModeData> component_93, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : GAEPCFMEMPO
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public KPBEPIDNAAM<ObjectPolicyData_v1> component_96;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public KPBEPIDNAAM<ObjectPolicyData_v2> component_97;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public KPBEPIDNAAM<ObjectPolicyData_v3> component_98;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public KPBEPIDNAAM<ObjectPolicyData_v4> component_99;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public KPBEPIDNAAM<ObjectPolicyData_v5> component_100;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public EKBDALKOBJJ<ObjectPolicyData> component_101;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x84AAC40", Offset = "0x84A9240", VA = "0x1884AAC40")]
			private void ANCGLJOPGHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x84ABA30", Offset = "0x84AA030", VA = "0x1884ABA30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override IPHNFELODMJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x84ABA40", Offset = "0x84AA040", VA = "0x1884ABA40", Slot = "14")]
			get
			{
				return default(IPHNFELODMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x84AA930", Offset = "0x84A8F30", VA = "0x1884AA930", Slot = "15")]
		protected override void LMBOGBMNCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x84AA730", Offset = "0x84A8D30", VA = "0x1884AA730")]
		private JobHandle FBMCGMDGMFL(KPBEPIDNAAM<ObjectPolicyData_v1> component_96, KPBEPIDNAAM<ObjectPolicyData_v2> component_97, KPBEPIDNAAM<ObjectPolicyData_v3> component_98, KPBEPIDNAAM<ObjectPolicyData_v4> component_99, KPBEPIDNAAM<ObjectPolicyData_v5> component_100, EKBDALKOBJJ<ObjectPolicyData> component_101, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class FEOPAHPNKJB
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3DBBAD0", Offset = "0x3DBA0D0", VA = "0x183DBBAD0")]
	public static void DBOPMKOOMND<T, U>(T NANNGIHMHLM, [Out] U OIAKIODILPA) where T : struct where U : struct
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
