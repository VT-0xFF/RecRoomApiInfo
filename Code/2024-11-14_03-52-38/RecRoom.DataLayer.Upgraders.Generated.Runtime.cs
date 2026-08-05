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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OLMLKMNJFEI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D09040", Offset = "0x6D08440", VA = "0x186D09040")]
	public static void KIEJDFIJHFF(ComponentSystemGroup PIHOHCGEHHL, EntityCommandBufferSystem NADGJNIEIDL)
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
		[Cpp2IlInjected.Address(RVA = "0x6D09040", Offset = "0x6D08440", VA = "0x186D09040")]
		public static void NJBPMBIMODD(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C0B0", Offset = "0x6D0B4B0", VA = "0x186D0C0B0")]
		private void KIEJDFIJHFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D0C020", Offset = "0x6D0B420", VA = "0x186D0C020")]
		private void AFKKEHFOOAB(GBADDFDNGHF system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : GBADDFDNGHF
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public LJKJNGPCKPK<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public JMGKIAMCCLO<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6D0A9B0", Offset = "0x6D09DB0", VA = "0x186D0A9B0")]
			private void BNHBOKPENCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6D0ACF0", Offset = "0x6D0A0F0", VA = "0x186D0ACF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly LDGDBHIGNCI log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override LDGDBHIGNCI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6D0A6C0", Offset = "0x6D09AC0", VA = "0x186D0A6C0", Slot = "14")]
			get
			{
				return default(LDGDBHIGNCI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D0A840", Offset = "0x6D09C40", VA = "0x186D0A840", Slot = "15")]
		protected override void FHFDGGGBEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D0A710", Offset = "0x6D09B10", VA = "0x186D0A710")]
		private JobHandle EIKMMKFOGFM(LJKJNGPCKPK<PersistentUserTagData_v1> component_1, JMGKIAMCCLO<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x24738C0", Offset = "0x2472CC0", VA = "0x1824738C0")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : GBADDFDNGHF
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public LJKJNGPCKPK<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public JMGKIAMCCLO<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6D08D00", Offset = "0x6D08100", VA = "0x186D08D00")]
			private void BNHBOKPENCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6D08FE0", Offset = "0x6D083E0", VA = "0x186D08FE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly LDGDBHIGNCI log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override LDGDBHIGNCI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6D08A10", Offset = "0x6D07E10", VA = "0x186D08A10", Slot = "14")]
			get
			{
				return default(LDGDBHIGNCI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D08B90", Offset = "0x6D07F90", VA = "0x186D08B90", Slot = "15")]
		protected override void FHFDGGGBEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D08A60", Offset = "0x6D07E60", VA = "0x186D08A60")]
		private JobHandle DMKGBKMIPNH(LJKJNGPCKPK<LocalDeformableScaleData_v1> component_3, JMGKIAMCCLO<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x24738C0", Offset = "0x2472CC0", VA = "0x1824738C0")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : GBADDFDNGHF
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public LJKJNGPCKPK<ReplicatorPreallocatedObjectCountData_v1> component_20;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public JMGKIAMCCLO<ReplicatorPreallocatedObjectCountData> component_21;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B690", Offset = "0x6D0AA90", VA = "0x186D0B690")]
			private void BNHBOKPENCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B950", Offset = "0x6D0AD50", VA = "0x186D0B950", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly LDGDBHIGNCI log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override LDGDBHIGNCI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B4D0", Offset = "0x6D0A8D0", VA = "0x186D0B4D0", Slot = "14")]
			get
			{
				return default(LDGDBHIGNCI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B520", Offset = "0x6D0A920", VA = "0x186D0B520", Slot = "15")]
		protected override void FHFDGGGBEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D0B3A0", Offset = "0x6D0A7A0", VA = "0x186D0B3A0")]
		private JobHandle BILDPOLNABH(LJKJNGPCKPK<ReplicatorPreallocatedObjectCountData_v1> component_20, JMGKIAMCCLO<ReplicatorPreallocatedObjectCountData> component_21, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x24738C0", Offset = "0x2472CC0", VA = "0x1824738C0")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : GBADDFDNGHF
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public LJKJNGPCKPK<ToolCleanupStatusData_v1> component_24;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public JMGKIAMCCLO<ToolCleanupStatusData> component_25;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BB70", Offset = "0x6D0AF70", VA = "0x186D0BB70")]
			private void BNHBOKPENCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BE90", Offset = "0x6D0B290", VA = "0x186D0BE90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly LDGDBHIGNCI log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override LDGDBHIGNCI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B9B0", Offset = "0x6D0ADB0", VA = "0x186D0B9B0", Slot = "14")]
			get
			{
				return default(LDGDBHIGNCI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BA00", Offset = "0x6D0AE00", VA = "0x186D0BA00", Slot = "15")]
		protected override void FHFDGGGBEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D0BEA0", Offset = "0x6D0B2A0", VA = "0x186D0BEA0")]
		private JobHandle MEMMCOFKECJ(LJKJNGPCKPK<ToolCleanupStatusData_v1> component_24, JMGKIAMCCLO<ToolCleanupStatusData> component_25, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x24738C0", Offset = "0x2472CC0", VA = "0x1824738C0")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : GBADDFDNGHF
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public LJKJNGPCKPK<ReplicatorData_v1> component_30;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public JMGKIAMCCLO<ReplicatorData> component_31;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B040", Offset = "0x6D0A440", VA = "0x186D0B040")]
			private void BNHBOKPENCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6D0B340", Offset = "0x6D0A740", VA = "0x186D0B340", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly LDGDBHIGNCI log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override LDGDBHIGNCI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6D0AD50", Offset = "0x6D0A150", VA = "0x186D0AD50", Slot = "14")]
			get
			{
				return default(LDGDBHIGNCI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D0AED0", Offset = "0x6D0A2D0", VA = "0x186D0AED0", Slot = "15")]
		protected override void FHFDGGGBEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6D0ADA0", Offset = "0x6D0A1A0", VA = "0x186D0ADA0")]
		private JobHandle CPFFEGMBBMH(LJKJNGPCKPK<ReplicatorData_v1> component_30, JMGKIAMCCLO<ReplicatorData> component_31, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x24738C0", Offset = "0x2472CC0", VA = "0x1824738C0")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : GBADDFDNGHF
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public LJKJNGPCKPK<InventionInstanceIdData_v1> component_33;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public JMGKIAMCCLO<InventionInstanceIdData> component_34;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6D085D0", Offset = "0x6D079D0", VA = "0x186D085D0")]
			private void BNHBOKPENCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6D08880", Offset = "0x6D07C80", VA = "0x186D08880", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly LDGDBHIGNCI log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override LDGDBHIGNCI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6D08410", Offset = "0x6D07810", VA = "0x186D08410", Slot = "14")]
			get
			{
				return default(LDGDBHIGNCI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6D08460", Offset = "0x6D07860", VA = "0x186D08460", Slot = "15")]
		protected override void FHFDGGGBEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6D08890", Offset = "0x6D07C90", VA = "0x186D08890")]
		private JobHandle PPFFDLEDJHN(LJKJNGPCKPK<InventionInstanceIdData_v1> component_33, JMGKIAMCCLO<InventionInstanceIdData> component_34, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x24738C0", Offset = "0x2472CC0", VA = "0x1824738C0")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : GBADDFDNGHF
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public LJKJNGPCKPK<OMShapeContainerData_v1> component_37;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public JMGKIAMCCLO<OMShapeContainerData> component_38;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6D09380", Offset = "0x6D08780", VA = "0x186D09380")]
			private void BNHBOKPENCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6D09670", Offset = "0x6D08A70", VA = "0x186D09670", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly LDGDBHIGNCI log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override LDGDBHIGNCI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6D09090", Offset = "0x6D08490", VA = "0x186D09090", Slot = "14")]
			get
			{
				return default(LDGDBHIGNCI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D090E0", Offset = "0x6D084E0", VA = "0x186D090E0", Slot = "15")]
		protected override void FHFDGGGBEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6D09250", Offset = "0x6D08650", VA = "0x186D09250")]
		private JobHandle FJHMENOGOFB(LJKJNGPCKPK<OMShapeContainerData_v1> component_37, JMGKIAMCCLO<OMShapeContainerData> component_38, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x24738C0", Offset = "0x2472CC0", VA = "0x1824738C0")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class ContainerFlagsDataUpgradeSystem : GBADDFDNGHF
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ContainerFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LJKJNGPCKPK<ContainerFlagsData_v1> component_59;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JMGKIAMCCLO<ContainerFlagsData> component_60;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6D07FB0", Offset = "0x6D073B0", VA = "0x186D07FB0")]
			private void BNHBOKPENCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6D08280", Offset = "0x6D07680", VA = "0x186D08280", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly LDGDBHIGNCI log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override LDGDBHIGNCI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6D07DF0", Offset = "0x6D071F0", VA = "0x186D07DF0", Slot = "14")]
			get
			{
				return default(LDGDBHIGNCI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D07E40", Offset = "0x6D07240", VA = "0x186D07E40", Slot = "15")]
		protected override void FHFDGGGBEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6D08290", Offset = "0x6D07690", VA = "0x186D08290")]
		private JobHandle NKANHPMHGKM(LJKJNGPCKPK<ContainerFlagsData_v1> component_59, JMGKIAMCCLO<ContainerFlagsData> component_60, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x24738C0", Offset = "0x2472CC0", VA = "0x1824738C0")]
		public ContainerFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : GBADDFDNGHF
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public LJKJNGPCKPK<ObjectPolicyData_v1> component_64;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public LJKJNGPCKPK<ObjectPolicyData_v2> component_65;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public LJKJNGPCKPK<ObjectPolicyData_v3> component_66;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public LJKJNGPCKPK<ObjectPolicyData_v4> component_67;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public JMGKIAMCCLO<ObjectPolicyData> component_68;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6D09BE0", Offset = "0x6D08FE0", VA = "0x186D09BE0")]
			private void BNHBOKPENCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6D0A660", Offset = "0x6D09A60", VA = "0x186D0A660", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly LDGDBHIGNCI log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override LDGDBHIGNCI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6D096D0", Offset = "0x6D08AD0", VA = "0x186D096D0", Slot = "14")]
			get
			{
				return default(LDGDBHIGNCI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D09720", Offset = "0x6D08B20", VA = "0x186D09720", Slot = "15")]
		protected override void FHFDGGGBEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6D099F0", Offset = "0x6D08DF0", VA = "0x186D099F0")]
		private JobHandle IFNAHOPJPII(LJKJNGPCKPK<ObjectPolicyData_v1> component_64, LJKJNGPCKPK<ObjectPolicyData_v2> component_65, LJKJNGPCKPK<ObjectPolicyData_v3> component_66, LJKJNGPCKPK<ObjectPolicyData_v4> component_67, JMGKIAMCCLO<ObjectPolicyData> component_68, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x24738C0", Offset = "0x2472CC0", VA = "0x1824738C0")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal static class DGJEEEJHMBJ
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3080", Offset = "0x2CE2480", VA = "0x182CE3080")]
	public static void GNIGLBOGMKC<T>(T PBHFFGJDCDP, [Out] T EEPPBMFKKMG) where T : struct
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
