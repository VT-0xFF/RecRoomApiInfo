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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PPEKDOMGAFH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B31150", Offset = "0x6B2F750", VA = "0x186B31150")]
	public static void HKAHCENIGNO(ComponentSystemGroup INICPKOBBNB, EntityCommandBufferSystem ANJMLGEPABJ)
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
		[Cpp2IlInjected.Address(RVA = "0x6B31150", Offset = "0x6B2F750", VA = "0x186B31150")]
		public static void PKENBFBNMCB(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6B32B00", Offset = "0x6B31100", VA = "0x186B32B00")]
		private void HKAHCENIGNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6B330C0", Offset = "0x6B316C0", VA = "0x186B330C0")]
		private void LNLMNLAJBJM(PKBPEJCHCMD system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : PKBPEJCHCMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public JPCKHJAAIKI<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public HINPCMMJNDA<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6B31330", Offset = "0x6B2F930", VA = "0x186B31330")]
			private void FILJBOEOLOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6B31320", Offset = "0x6B2F920", VA = "0x186B31320", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly CMICIECANPG log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override CMICIECANPG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6B312D0", Offset = "0x6B2F8D0", VA = "0x186B312D0", Slot = "14")]
			get
			{
				return default(CMICIECANPG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6B31670", Offset = "0x6B2FC70", VA = "0x186B31670", Slot = "15")]
		protected override void MOPADDCBPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6B311A0", Offset = "0x6B2F7A0", VA = "0x186B311A0")]
		private JobHandle DLAIJMGEEJP(JPCKHJAAIKI<PersistentUserTagData_v1> component_1, HINPCMMJNDA<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x22A61A0", Offset = "0x22A47A0", VA = "0x1822A61A0")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : PKBPEJCHCMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public JPCKHJAAIKI<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public HINPCMMJNDA<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6B2F680", Offset = "0x6B2DC80", VA = "0x186B2F680")]
			private void FILJBOEOLOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6B2F670", Offset = "0x6B2DC70", VA = "0x186B2F670", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly CMICIECANPG log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override CMICIECANPG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6B2F620", Offset = "0x6B2DC20", VA = "0x186B2F620", Slot = "14")]
			get
			{
				return default(CMICIECANPG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6B2F960", Offset = "0x6B2DF60", VA = "0x186B2F960", Slot = "15")]
		protected override void MOPADDCBPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6B2F4F0", Offset = "0x6B2DAF0", VA = "0x186B2F4F0")]
		private JobHandle HHEJGBAHJAP(JPCKHJAAIKI<LocalDeformableScaleData_v1> component_3, HINPCMMJNDA<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x22A61A0", Offset = "0x22A47A0", VA = "0x1822A61A0")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : PKBPEJCHCMD
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public JPCKHJAAIKI<ReplicatorPreallocatedObjectCountData_v1> component_20;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public HINPCMMJNDA<ReplicatorPreallocatedObjectCountData> component_21;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6B31EE0", Offset = "0x6B304E0", VA = "0x186B31EE0")]
			private void FILJBOEOLOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6B31ED0", Offset = "0x6B304D0", VA = "0x186B31ED0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly CMICIECANPG log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override CMICIECANPG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6B31E80", Offset = "0x6B30480", VA = "0x186B31E80", Slot = "14")]
			get
			{
				return default(CMICIECANPG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6B321A0", Offset = "0x6B307A0", VA = "0x186B321A0", Slot = "15")]
		protected override void MOPADDCBPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6B32310", Offset = "0x6B30910", VA = "0x186B32310")]
		private JobHandle ONOFHAONJHP(JPCKHJAAIKI<ReplicatorPreallocatedObjectCountData_v1> component_20, HINPCMMJNDA<ReplicatorPreallocatedObjectCountData> component_21, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x22A61A0", Offset = "0x22A47A0", VA = "0x1822A61A0")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : PKBPEJCHCMD
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public JPCKHJAAIKI<ToolCleanupStatusData_v1> component_24;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public HINPCMMJNDA<ToolCleanupStatusData> component_25;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6B324F0", Offset = "0x6B30AF0", VA = "0x186B324F0")]
			private void FILJBOEOLOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6B324E0", Offset = "0x6B30AE0", VA = "0x186B324E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly CMICIECANPG log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override CMICIECANPG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6B32490", Offset = "0x6B30A90", VA = "0x186B32490", Slot = "14")]
			get
			{
				return default(CMICIECANPG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6B32810", Offset = "0x6B30E10", VA = "0x186B32810", Slot = "15")]
		protected override void MOPADDCBPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6B32980", Offset = "0x6B30F80", VA = "0x186B32980")]
		private JobHandle PGEPMAFPFMH(JPCKHJAAIKI<ToolCleanupStatusData_v1> component_24, HINPCMMJNDA<ToolCleanupStatusData> component_25, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x22A61A0", Offset = "0x22A47A0", VA = "0x1822A61A0")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : PKBPEJCHCMD
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public JPCKHJAAIKI<ReplicatorData_v1> component_30;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public HINPCMMJNDA<ReplicatorData> component_31;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6B319C0", Offset = "0x6B2FFC0", VA = "0x186B319C0")]
			private void FILJBOEOLOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6B319B0", Offset = "0x6B2FFB0", VA = "0x186B319B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly CMICIECANPG log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override CMICIECANPG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6B31960", Offset = "0x6B2FF60", VA = "0x186B31960", Slot = "14")]
			get
			{
				return default(CMICIECANPG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6B31CC0", Offset = "0x6B302C0", VA = "0x186B31CC0", Slot = "15")]
		protected override void MOPADDCBPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6B31830", Offset = "0x6B2FE30", VA = "0x186B31830")]
		private JobHandle BPHKEIACKMK(JPCKHJAAIKI<ReplicatorData_v1> component_30, HINPCMMJNDA<ReplicatorData> component_31, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x22A61A0", Offset = "0x22A47A0", VA = "0x1822A61A0")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : PKBPEJCHCMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public JPCKHJAAIKI<InventionInstanceIdData_v1> component_33;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public HINPCMMJNDA<InventionInstanceIdData> component_34;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6B2F080", Offset = "0x6B2D680", VA = "0x186B2F080")]
			private void FILJBOEOLOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6B2F070", Offset = "0x6B2D670", VA = "0x186B2F070", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly CMICIECANPG log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override CMICIECANPG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6B2F020", Offset = "0x6B2D620", VA = "0x186B2F020", Slot = "14")]
			get
			{
				return default(CMICIECANPG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6B2F330", Offset = "0x6B2D930", VA = "0x186B2F330", Slot = "15")]
		protected override void MOPADDCBPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6B2EEF0", Offset = "0x6B2D4F0", VA = "0x186B2EEF0")]
		private JobHandle ALJFNEOOAJC(JPCKHJAAIKI<InventionInstanceIdData_v1> component_33, HINPCMMJNDA<InventionInstanceIdData> component_34, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x22A61A0", Offset = "0x22A47A0", VA = "0x1822A61A0")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : PKBPEJCHCMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public JPCKHJAAIKI<OMShapeContainerData_v1> component_37;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public HINPCMMJNDA<OMShapeContainerData> component_38;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6B2FCB0", Offset = "0x6B2E2B0", VA = "0x186B2FCB0")]
			private void FILJBOEOLOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6B2FCA0", Offset = "0x6B2E2A0", VA = "0x186B2FCA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly CMICIECANPG log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override CMICIECANPG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6B2FC50", Offset = "0x6B2E250", VA = "0x186B2FC50", Slot = "14")]
			get
			{
				return default(CMICIECANPG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6B2FFA0", Offset = "0x6B2E5A0", VA = "0x186B2FFA0", Slot = "15")]
		protected override void MOPADDCBPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6B2FB20", Offset = "0x6B2E120", VA = "0x186B2FB20")]
		private JobHandle AEKHMGDEOCC(JPCKHJAAIKI<OMShapeContainerData_v1> component_37, HINPCMMJNDA<OMShapeContainerData> component_38, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x22A61A0", Offset = "0x22A47A0", VA = "0x1822A61A0")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class ContainerFlagsDataUpgradeSystem : PKBPEJCHCMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ContainerFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public JPCKHJAAIKI<ContainerFlagsData_v1> component_59;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public HINPCMMJNDA<ContainerFlagsData> component_60;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6B2EA60", Offset = "0x6B2D060", VA = "0x186B2EA60")]
			private void FILJBOEOLOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6B2EA50", Offset = "0x6B2D050", VA = "0x186B2EA50", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly CMICIECANPG log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override CMICIECANPG Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6B2EA00", Offset = "0x6B2D000", VA = "0x186B2EA00", Slot = "14")]
			get
			{
				return default(CMICIECANPG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6B2ED30", Offset = "0x6B2D330", VA = "0x186B2ED30", Slot = "15")]
		protected override void MOPADDCBPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6B2E8D0", Offset = "0x6B2CED0", VA = "0x186B2E8D0")]
		private JobHandle EOOODCOAGIP(JPCKHJAAIKI<ContainerFlagsData_v1> component_59, HINPCMMJNDA<ContainerFlagsData> component_60, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x22A61A0", Offset = "0x22A47A0", VA = "0x1822A61A0")]
		public ContainerFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : PKBPEJCHCMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public JPCKHJAAIKI<ObjectPolicyData_v1> component_64;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public JPCKHJAAIKI<ObjectPolicyData_v2> component_65;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public JPCKHJAAIKI<ObjectPolicyData_v3> component_66;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public JPCKHJAAIKI<ObjectPolicyData_v4> component_67;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public HINPCMMJNDA<ObjectPolicyData> component_68;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6B303B0", Offset = "0x6B2E9B0", VA = "0x186B303B0")]
			private void FILJBOEOLOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6B303A0", Offset = "0x6B2E9A0", VA = "0x186B303A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly CMICIECANPG log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override CMICIECANPG Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6B30350", Offset = "0x6B2E950", VA = "0x186B30350", Slot = "14")]
			get
			{
				return default(CMICIECANPG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6B30E30", Offset = "0x6B2F430", VA = "0x186B30E30", Slot = "15")]
		protected override void MOPADDCBPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6B30160", Offset = "0x6B2E760", VA = "0x186B30160")]
		private JobHandle JFFLGBGBGDF(JPCKHJAAIKI<ObjectPolicyData_v1> component_64, JPCKHJAAIKI<ObjectPolicyData_v2> component_65, JPCKHJAAIKI<ObjectPolicyData_v3> component_66, JPCKHJAAIKI<ObjectPolicyData_v4> component_67, HINPCMMJNDA<ObjectPolicyData> component_68, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x22A61A0", Offset = "0x22A47A0", VA = "0x1822A61A0")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal static class KEAPMJOJLHH
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2D65800", Offset = "0x2D63E00", VA = "0x182D65800")]
	public static void BOPLKJAFHLK<T>(T IOKKIEOPFLI, [Out] T NDHCCLMPCNF) where T : struct
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
