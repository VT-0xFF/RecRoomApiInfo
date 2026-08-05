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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LOKNCOCPMLE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B6D9E0", Offset = "0x6B6C3E0", VA = "0x186B6D9E0")]
	public static void JEODNLJOOHI(ComponentSystemGroup HLFPHDBLGNI, EntityCommandBufferSystem GCAFIHLAMKK)
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
		[Cpp2IlInjected.Address(RVA = "0x6B6D9E0", Offset = "0x6B6C3E0", VA = "0x186B6D9E0")]
		public static void EIJMOEPIHFJ(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6B70FF0", Offset = "0x6B6F9F0", VA = "0x186B70FF0")]
		private void JEODNLJOOHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6B715B0", Offset = "0x6B6FFB0", VA = "0x186B715B0")]
		private void MDHGFCLLNLJ(LOIJOOHGAGG system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : LOIJOOHGAGG
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public HBCKENLICJP<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public HCHNKPLNLCD<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6B6F980", Offset = "0x6B6E380", VA = "0x186B6F980")]
			private void AILNAHLKNME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6B6FCC0", Offset = "0x6B6E6C0", VA = "0x186B6FCC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ANDGIEDMMDP log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override ANDGIEDMMDP Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6B6F7C0", Offset = "0x6B6E1C0", VA = "0x186B6F7C0", Slot = "14")]
			get
			{
				return default(ANDGIEDMMDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6B6F810", Offset = "0x6B6E210", VA = "0x186B6F810", Slot = "15")]
		protected override void KGBJHJAONAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6B6F690", Offset = "0x6B6E090", VA = "0x186B6F690")]
		private JobHandle BFMKNMBABJH(HBCKENLICJP<PersistentUserTagData_v1> component_1, HCHNKPLNLCD<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x22947E0", Offset = "0x22931E0", VA = "0x1822947E0")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : LOIJOOHGAGG
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public HBCKENLICJP<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public HCHNKPLNLCD<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6B6DBF0", Offset = "0x6B6C5F0", VA = "0x186B6DBF0")]
			private void AILNAHLKNME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6B6DED0", Offset = "0x6B6C8D0", VA = "0x186B6DED0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ANDGIEDMMDP log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override ANDGIEDMMDP Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6B6DA30", Offset = "0x6B6C430", VA = "0x186B6DA30", Slot = "14")]
			get
			{
				return default(ANDGIEDMMDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DA80", Offset = "0x6B6C480", VA = "0x186B6DA80", Slot = "15")]
		protected override void KGBJHJAONAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DEE0", Offset = "0x6B6C8E0", VA = "0x186B6DEE0")]
		private JobHandle NMPFBHKCKEA(HBCKENLICJP<LocalDeformableScaleData_v1> component_3, HCHNKPLNLCD<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x22947E0", Offset = "0x22931E0", VA = "0x1822947E0")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : LOIJOOHGAGG
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public HBCKENLICJP<ReplicatorPreallocatedObjectCountData_v1> component_20;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public HCHNKPLNLCD<ReplicatorPreallocatedObjectCountData> component_21;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6B70660", Offset = "0x6B6F060", VA = "0x186B70660")]
			private void AILNAHLKNME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6B70920", Offset = "0x6B6F320", VA = "0x186B70920", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ANDGIEDMMDP log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override ANDGIEDMMDP Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6B704A0", Offset = "0x6B6EEA0", VA = "0x186B704A0", Slot = "14")]
			get
			{
				return default(ANDGIEDMMDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6B704F0", Offset = "0x6B6EEF0", VA = "0x186B704F0", Slot = "15")]
		protected override void KGBJHJAONAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6B70370", Offset = "0x6B6ED70", VA = "0x186B70370")]
		private JobHandle AKEKOJMFECL(HBCKENLICJP<ReplicatorPreallocatedObjectCountData_v1> component_20, HCHNKPLNLCD<ReplicatorPreallocatedObjectCountData> component_21, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x22947E0", Offset = "0x22931E0", VA = "0x1822947E0")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : LOIJOOHGAGG
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public HBCKENLICJP<ToolCleanupStatusData_v1> component_24;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public HCHNKPLNLCD<ToolCleanupStatusData> component_25;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6B70C70", Offset = "0x6B6F670", VA = "0x186B70C70")]
			private void AILNAHLKNME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6B70F90", Offset = "0x6B6F990", VA = "0x186B70F90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly ANDGIEDMMDP log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override ANDGIEDMMDP Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6B70980", Offset = "0x6B6F380", VA = "0x186B70980", Slot = "14")]
			get
			{
				return default(ANDGIEDMMDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6B70B00", Offset = "0x6B6F500", VA = "0x186B70B00", Slot = "15")]
		protected override void KGBJHJAONAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6B709D0", Offset = "0x6B6F3D0", VA = "0x186B709D0")]
		private JobHandle FOCPPFOCLAO(HBCKENLICJP<ToolCleanupStatusData_v1> component_24, HCHNKPLNLCD<ToolCleanupStatusData> component_25, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x22947E0", Offset = "0x22931E0", VA = "0x1822947E0")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : LOIJOOHGAGG
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public HBCKENLICJP<ReplicatorData_v1> component_30;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public HCHNKPLNLCD<ReplicatorData> component_31;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6B70010", Offset = "0x6B6EA10", VA = "0x186B70010")]
			private void AILNAHLKNME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6B70310", Offset = "0x6B6ED10", VA = "0x186B70310", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly ANDGIEDMMDP log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override ANDGIEDMMDP Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6B6FE50", Offset = "0x6B6E850", VA = "0x186B6FE50", Slot = "14")]
			get
			{
				return default(ANDGIEDMMDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6B6FEA0", Offset = "0x6B6E8A0", VA = "0x186B6FEA0", Slot = "15")]
		protected override void KGBJHJAONAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6B6FD20", Offset = "0x6B6E720", VA = "0x186B6FD20")]
		private JobHandle DFPKAPAHPBO(HBCKENLICJP<ReplicatorData_v1> component_30, HCHNKPLNLCD<ReplicatorData> component_31, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x22947E0", Offset = "0x22931E0", VA = "0x1822947E0")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : LOIJOOHGAGG
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public HBCKENLICJP<InventionInstanceIdData_v1> component_33;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public HCHNKPLNLCD<InventionInstanceIdData> component_34;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6B6D6D0", Offset = "0x6B6C0D0", VA = "0x186B6D6D0")]
			private void AILNAHLKNME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6B6D980", Offset = "0x6B6C380", VA = "0x186B6D980", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly ANDGIEDMMDP log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override ANDGIEDMMDP Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6B6D3E0", Offset = "0x6B6BDE0", VA = "0x186B6D3E0", Slot = "14")]
			get
			{
				return default(ANDGIEDMMDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6B6D560", Offset = "0x6B6BF60", VA = "0x186B6D560", Slot = "15")]
		protected override void KGBJHJAONAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6B6D430", Offset = "0x6B6BE30", VA = "0x186B6D430")]
		private JobHandle JGFIPEIGNJI(HBCKENLICJP<InventionInstanceIdData_v1> component_33, HCHNKPLNLCD<InventionInstanceIdData> component_34, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x22947E0", Offset = "0x22931E0", VA = "0x1822947E0")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : LOIJOOHGAGG
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public HBCKENLICJP<OMShapeContainerData_v1> component_37;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public HCHNKPLNLCD<OMShapeContainerData> component_38;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6B6E350", Offset = "0x6B6CD50", VA = "0x186B6E350")]
			private void AILNAHLKNME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6B6E640", Offset = "0x6B6D040", VA = "0x186B6E640", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly ANDGIEDMMDP log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override ANDGIEDMMDP Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6B6E190", Offset = "0x6B6CB90", VA = "0x186B6E190", Slot = "14")]
			get
			{
				return default(ANDGIEDMMDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E1E0", Offset = "0x6B6CBE0", VA = "0x186B6E1E0", Slot = "15")]
		protected override void KGBJHJAONAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E060", Offset = "0x6B6CA60", VA = "0x186B6E060")]
		private JobHandle EFPLCEADNGB(HBCKENLICJP<OMShapeContainerData_v1> component_37, HCHNKPLNLCD<OMShapeContainerData> component_38, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x22947E0", Offset = "0x22931E0", VA = "0x1822947E0")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class ContainerFlagsDataUpgradeSystem : LOIJOOHGAGG
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ContainerFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HBCKENLICJP<ContainerFlagsData_v1> component_59;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public HCHNKPLNLCD<ContainerFlagsData> component_60;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6B6D0B0", Offset = "0x6B6BAB0", VA = "0x186B6D0B0")]
			private void AILNAHLKNME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6B6D380", Offset = "0x6B6BD80", VA = "0x186B6D380", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly ANDGIEDMMDP log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override ANDGIEDMMDP Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6B6CEF0", Offset = "0x6B6B8F0", VA = "0x186B6CEF0", Slot = "14")]
			get
			{
				return default(ANDGIEDMMDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6B6CF40", Offset = "0x6B6B940", VA = "0x186B6CF40", Slot = "15")]
		protected override void KGBJHJAONAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6B6CDC0", Offset = "0x6B6B7C0", VA = "0x186B6CDC0")]
		private JobHandle DELCPGPCMOH(HBCKENLICJP<ContainerFlagsData_v1> component_59, HCHNKPLNLCD<ContainerFlagsData> component_60, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x22947E0", Offset = "0x22931E0", VA = "0x1822947E0")]
		public ContainerFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : LOIJOOHGAGG
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public HBCKENLICJP<ObjectPolicyData_v1> component_64;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public HBCKENLICJP<ObjectPolicyData_v2> component_65;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public HBCKENLICJP<ObjectPolicyData_v3> component_66;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public HBCKENLICJP<ObjectPolicyData_v4> component_67;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public HCHNKPLNLCD<ObjectPolicyData> component_68;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6B6E9C0", Offset = "0x6B6D3C0", VA = "0x186B6E9C0")]
			private void AILNAHLKNME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6B6F440", Offset = "0x6B6DE40", VA = "0x186B6F440", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly ANDGIEDMMDP log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override ANDGIEDMMDP Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6B6E6A0", Offset = "0x6B6D0A0", VA = "0x186B6E6A0", Slot = "14")]
			get
			{
				return default(ANDGIEDMMDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E6F0", Offset = "0x6B6D0F0", VA = "0x186B6E6F0", Slot = "15")]
		protected override void KGBJHJAONAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6B6F450", Offset = "0x6B6DE50", VA = "0x186B6F450")]
		private JobHandle PDBFNPODJKO(HBCKENLICJP<ObjectPolicyData_v1> component_64, HBCKENLICJP<ObjectPolicyData_v2> component_65, HBCKENLICJP<ObjectPolicyData_v3> component_66, HBCKENLICJP<ObjectPolicyData_v4> component_67, HCHNKPLNLCD<ObjectPolicyData> component_68, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x22947E0", Offset = "0x22931E0", VA = "0x1822947E0")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal static class JAAIACHGGIO
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF61A0", Offset = "0x2CF4BA0", VA = "0x182CF61A0")]
	public static void MNEPMFAGFJP<T>(T HGIEOODHPPK, [Out] T ECLFPLHHPOI) where T : struct
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
