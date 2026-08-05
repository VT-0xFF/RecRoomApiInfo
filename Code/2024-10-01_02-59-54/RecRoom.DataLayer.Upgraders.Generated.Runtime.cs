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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DJPLFEDAICI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F980", Offset = "0x6D9ED80", VA = "0x186D9F980")]
	public static void LFIBAFGJKOP(ComponentSystemGroup DBIFLCNMMHA, EntityCommandBufferSystem PHAOOIBCHBN)
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
		[Cpp2IlInjected.Address(RVA = "0x6D9F980", Offset = "0x6D9ED80", VA = "0x186D9F980")]
		public static void PNKOIMLEIBM(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3590", Offset = "0x6DA2990", VA = "0x186DA3590")]
		private void LFIBAFGJKOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3B50", Offset = "0x6DA2F50", VA = "0x186DA3B50")]
		private void MBEIFCJFKEE(HBHDALFFDEC system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : HBHDALFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public JDAMAANMEPJ<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public IDFLBNNOHOC<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6DA1F30", Offset = "0x6DA1330", VA = "0x186DA1F30")]
			private void MHBKFCHMAGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6DA1F20", Offset = "0x6DA1320", VA = "0x186DA1F20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly EGGMDNJPOBA log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override EGGMDNJPOBA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6DA1D60", Offset = "0x6DA1160", VA = "0x186DA1D60", Slot = "14")]
			get
			{
				return default(EGGMDNJPOBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6DA1DB0", Offset = "0x6DA11B0", VA = "0x186DA1DB0", Slot = "15")]
		protected override void LKNHBGIIBIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6DA1C30", Offset = "0x6DA1030", VA = "0x186DA1C30")]
		private JobHandle FOCHFDMKLIE(JDAMAANMEPJ<PersistentUserTagData_v1> component_1, IDFLBNNOHOC<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2424840", Offset = "0x2423C40", VA = "0x182424840")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : HBHDALFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public JDAMAANMEPJ<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public IDFLBNNOHOC<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6DA02D0", Offset = "0x6D9F6D0", VA = "0x186DA02D0")]
			private void MHBKFCHMAGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6DA02C0", Offset = "0x6D9F6C0", VA = "0x186DA02C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly EGGMDNJPOBA log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override EGGMDNJPOBA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6D9FFD0", Offset = "0x6D9F3D0", VA = "0x186D9FFD0", Slot = "14")]
			get
			{
				return default(EGGMDNJPOBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0150", Offset = "0x6D9F550", VA = "0x186DA0150", Slot = "15")]
		protected override void LKNHBGIIBIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0020", Offset = "0x6D9F420", VA = "0x186DA0020")]
		private JobHandle JPDEBKEEGMA(JDAMAANMEPJ<LocalDeformableScaleData_v1> component_3, IDFLBNNOHOC<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2424840", Offset = "0x2423C40", VA = "0x182424840")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : HBHDALFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public JDAMAANMEPJ<ReplicatorPreallocatedObjectCountData_v1> component_20;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public IDFLBNNOHOC<ReplicatorPreallocatedObjectCountData> component_21;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6DA2AE0", Offset = "0x6DA1EE0", VA = "0x186DA2AE0")]
			private void MHBKFCHMAGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6DA2AD0", Offset = "0x6DA1ED0", VA = "0x186DA2AD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly EGGMDNJPOBA log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override EGGMDNJPOBA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6DA2910", Offset = "0x6DA1D10", VA = "0x186DA2910", Slot = "14")]
			get
			{
				return default(EGGMDNJPOBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2960", Offset = "0x6DA1D60", VA = "0x186DA2960", Slot = "15")]
		protected override void LKNHBGIIBIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2DA0", Offset = "0x6DA21A0", VA = "0x186DA2DA0")]
		private JobHandle MHIMDGHBAAG(JDAMAANMEPJ<ReplicatorPreallocatedObjectCountData_v1> component_20, IDFLBNNOHOC<ReplicatorPreallocatedObjectCountData> component_21, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2424840", Offset = "0x2423C40", VA = "0x182424840")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : HBHDALFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public JDAMAANMEPJ<ToolCleanupStatusData_v1> component_24;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public IDFLBNNOHOC<ToolCleanupStatusData> component_25;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6DA3220", Offset = "0x6DA2620", VA = "0x186DA3220")]
			private void MHBKFCHMAGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6DA3210", Offset = "0x6DA2610", VA = "0x186DA3210", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly EGGMDNJPOBA log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override EGGMDNJPOBA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6DA2F20", Offset = "0x6DA2320", VA = "0x186DA2F20", Slot = "14")]
			get
			{
				return default(EGGMDNJPOBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6DA30A0", Offset = "0x6DA24A0", VA = "0x186DA30A0", Slot = "15")]
		protected override void LKNHBGIIBIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2F70", Offset = "0x6DA2370", VA = "0x186DA2F70")]
		private JobHandle KEDOLICMDHK(JDAMAANMEPJ<ToolCleanupStatusData_v1> component_24, IDFLBNNOHOC<ToolCleanupStatusData> component_25, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2424840", Offset = "0x2423C40", VA = "0x182424840")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : HBHDALFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public JDAMAANMEPJ<ReplicatorData_v1> component_30;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public IDFLBNNOHOC<ReplicatorData> component_31;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6DA25C0", Offset = "0x6DA19C0", VA = "0x186DA25C0")]
			private void MHBKFCHMAGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6DA25B0", Offset = "0x6DA19B0", VA = "0x186DA25B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly EGGMDNJPOBA log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override EGGMDNJPOBA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6DA22C0", Offset = "0x6DA16C0", VA = "0x186DA22C0", Slot = "14")]
			get
			{
				return default(EGGMDNJPOBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2440", Offset = "0x6DA1840", VA = "0x186DA2440", Slot = "15")]
		protected override void LKNHBGIIBIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2310", Offset = "0x6DA1710", VA = "0x186DA2310")]
		private JobHandle JNKJIOHEMIF(JDAMAANMEPJ<ReplicatorData_v1> component_30, IDFLBNNOHOC<ReplicatorData> component_31, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2424840", Offset = "0x2423C40", VA = "0x182424840")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : HBHDALFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public JDAMAANMEPJ<InventionInstanceIdData_v1> component_33;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public IDFLBNNOHOC<InventionInstanceIdData> component_34;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6D9FCD0", Offset = "0x6D9F0D0", VA = "0x186D9FCD0")]
			private void MHBKFCHMAGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6D9FCC0", Offset = "0x6D9F0C0", VA = "0x186D9FCC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly EGGMDNJPOBA log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override EGGMDNJPOBA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6D9FB00", Offset = "0x6D9EF00", VA = "0x186D9FB00", Slot = "14")]
			get
			{
				return default(EGGMDNJPOBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6D9FB50", Offset = "0x6D9EF50", VA = "0x186D9FB50", Slot = "15")]
		protected override void LKNHBGIIBIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6D9F9D0", Offset = "0x6D9EDD0", VA = "0x186D9F9D0")]
		private JobHandle GOLJKEOGDMK(JDAMAANMEPJ<InventionInstanceIdData_v1> component_33, IDFLBNNOHOC<InventionInstanceIdData> component_34, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2424840", Offset = "0x2423C40", VA = "0x182424840")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : HBHDALFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public JDAMAANMEPJ<OMShapeContainerData_v1> component_37;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public IDFLBNNOHOC<OMShapeContainerData> component_38;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6DA0900", Offset = "0x6D9FD00", VA = "0x186DA0900")]
			private void MHBKFCHMAGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6DA08F0", Offset = "0x6D9FCF0", VA = "0x186DA08F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly EGGMDNJPOBA log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override EGGMDNJPOBA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6DA0600", Offset = "0x6D9FA00", VA = "0x186DA0600", Slot = "14")]
			get
			{
				return default(EGGMDNJPOBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0780", Offset = "0x6D9FB80", VA = "0x186DA0780", Slot = "15")]
		protected override void LKNHBGIIBIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0650", Offset = "0x6D9FA50", VA = "0x186DA0650")]
		private JobHandle JABEGKJMPGI(JDAMAANMEPJ<OMShapeContainerData_v1> component_37, IDFLBNNOHOC<OMShapeContainerData> component_38, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2424840", Offset = "0x2423C40", VA = "0x182424840")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class ContainerFlagsDataUpgradeSystem : HBHDALFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ContainerFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public JDAMAANMEPJ<ContainerFlagsData_v1> component_59;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public IDFLBNNOHOC<ContainerFlagsData> component_60;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6D9F660", Offset = "0x6D9EA60", VA = "0x186D9F660")]
			private void MHBKFCHMAGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6D9F650", Offset = "0x6D9EA50", VA = "0x186D9F650", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly EGGMDNJPOBA log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override EGGMDNJPOBA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6D9F490", Offset = "0x6D9E890", VA = "0x186D9F490", Slot = "14")]
			get
			{
				return default(EGGMDNJPOBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D9F4E0", Offset = "0x6D9E8E0", VA = "0x186D9F4E0", Slot = "15")]
		protected override void LKNHBGIIBIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6D9F360", Offset = "0x6D9E760", VA = "0x186D9F360")]
		private JobHandle DCBKJMLHLCB(JDAMAANMEPJ<ContainerFlagsData_v1> component_59, IDFLBNNOHOC<ContainerFlagsData> component_60, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2424840", Offset = "0x2423C40", VA = "0x182424840")]
		public ContainerFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : HBHDALFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public JDAMAANMEPJ<ObjectPolicyData_v1> component_64;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public JDAMAANMEPJ<ObjectPolicyData_v2> component_65;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public JDAMAANMEPJ<ObjectPolicyData_v3> component_66;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public JDAMAANMEPJ<ObjectPolicyData_v4> component_67;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IDFLBNNOHOC<ObjectPolicyData> component_68;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6DA1160", Offset = "0x6DA0560", VA = "0x186DA1160")]
			private void MHBKFCHMAGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6DA1150", Offset = "0x6DA0550", VA = "0x186DA1150", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly EGGMDNJPOBA log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override EGGMDNJPOBA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6DA0E30", Offset = "0x6DA0230", VA = "0x186DA0E30", Slot = "14")]
			get
			{
				return default(EGGMDNJPOBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0E80", Offset = "0x6DA0280", VA = "0x186DA0E80", Slot = "15")]
		protected override void LKNHBGIIBIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0C40", Offset = "0x6DA0040", VA = "0x186DA0C40")]
		private JobHandle IJNFMAMLLGJ(JDAMAANMEPJ<ObjectPolicyData_v1> component_64, JDAMAANMEPJ<ObjectPolicyData_v2> component_65, JDAMAANMEPJ<ObjectPolicyData_v3> component_66, JDAMAANMEPJ<ObjectPolicyData_v4> component_67, IDFLBNNOHOC<ObjectPolicyData> component_68, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2424840", Offset = "0x2423C40", VA = "0x182424840")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal static class IBCPBOMLPIE
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2E95680", Offset = "0x2E94A80", VA = "0x182E95680")]
	public static void OPLEPIHACBC<T>(T OIBHCFNCCEF, [Out] T HENKDDALBFI) where T : struct
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
