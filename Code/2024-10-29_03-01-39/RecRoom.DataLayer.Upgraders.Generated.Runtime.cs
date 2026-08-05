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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LPHCLDPLLJB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E66750", Offset = "0x6E65750", VA = "0x186E66750")]
	public static void CGBJEKMGBCL(ComponentSystemGroup OANGBAAODID, EntityCommandBufferSystem GFJMJBDJGDF)
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
		[Cpp2IlInjected.Address(RVA = "0x6E66750", Offset = "0x6E65750", VA = "0x186E66750")]
		public static void LPMEAHBKJPM(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E69D60", Offset = "0x6E68D60", VA = "0x186E69D60")]
		private void CGBJEKMGBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6E6A320", Offset = "0x6E69320", VA = "0x186E6A320")]
		private void OGOLFLDBHBC(GJABIMIGKAI system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : GJABIMIGKAI
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public BMIJMDOMMDB<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public LFCABGLCIIC<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6E68700", Offset = "0x6E67700", VA = "0x186E68700")]
			private void IMFKDLPCDFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6E686F0", Offset = "0x6E676F0", VA = "0x186E686F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly CDBONJBDMGH log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override CDBONJBDMGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6E68400", Offset = "0x6E67400", VA = "0x186E68400", Slot = "14")]
			get
			{
				return default(CDBONJBDMGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6E68450", Offset = "0x6E67450", VA = "0x186E68450", Slot = "15")]
		protected override void FFLBEMPLCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6E685C0", Offset = "0x6E675C0", VA = "0x186E685C0")]
		private JobHandle LCMHILENHBP(BMIJMDOMMDB<PersistentUserTagData_v1> component_1, LFCABGLCIIC<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x24E6450", Offset = "0x24E5450", VA = "0x1824E6450")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : GJABIMIGKAI
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public BMIJMDOMMDB<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public LFCABGLCIIC<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6E66970", Offset = "0x6E65970", VA = "0x186E66970")]
			private void IMFKDLPCDFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6E66960", Offset = "0x6E65960", VA = "0x186E66960", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly CDBONJBDMGH log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override CDBONJBDMGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6E667A0", Offset = "0x6E657A0", VA = "0x186E667A0", Slot = "14")]
			get
			{
				return default(CDBONJBDMGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6E667F0", Offset = "0x6E657F0", VA = "0x186E667F0", Slot = "15")]
		protected override void FFLBEMPLCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E66C50", Offset = "0x6E65C50", VA = "0x186E66C50")]
		private JobHandle OFJHOKGGNDP(BMIJMDOMMDB<LocalDeformableScaleData_v1> component_3, LFCABGLCIIC<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x24E6450", Offset = "0x24E5450", VA = "0x1824E6450")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : GJABIMIGKAI
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public BMIJMDOMMDB<ReplicatorPreallocatedObjectCountData_v1> component_20;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public LFCABGLCIIC<ReplicatorPreallocatedObjectCountData> component_21;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6E693E0", Offset = "0x6E683E0", VA = "0x186E693E0")]
			private void IMFKDLPCDFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6E693D0", Offset = "0x6E683D0", VA = "0x186E693D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly CDBONJBDMGH log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override CDBONJBDMGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6E690E0", Offset = "0x6E680E0", VA = "0x186E690E0", Slot = "14")]
			get
			{
				return default(CDBONJBDMGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E69130", Offset = "0x6E68130", VA = "0x186E69130", Slot = "15")]
		protected override void FFLBEMPLCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E692A0", Offset = "0x6E682A0", VA = "0x186E692A0")]
		private JobHandle IENJEPDNGIF(BMIJMDOMMDB<ReplicatorPreallocatedObjectCountData_v1> component_20, LFCABGLCIIC<ReplicatorPreallocatedObjectCountData> component_21, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x24E6450", Offset = "0x24E5450", VA = "0x1824E6450")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : GJABIMIGKAI
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public BMIJMDOMMDB<ToolCleanupStatusData_v1> component_24;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public LFCABGLCIIC<ToolCleanupStatusData> component_25;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6E699F0", Offset = "0x6E689F0", VA = "0x186E699F0")]
			private void IMFKDLPCDFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6E699E0", Offset = "0x6E689E0", VA = "0x186E699E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly CDBONJBDMGH log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override CDBONJBDMGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6E696F0", Offset = "0x6E686F0", VA = "0x186E696F0", Slot = "14")]
			get
			{
				return default(CDBONJBDMGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6E69740", Offset = "0x6E68740", VA = "0x186E69740", Slot = "15")]
		protected override void FFLBEMPLCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6E698B0", Offset = "0x6E688B0", VA = "0x186E698B0")]
		private JobHandle HNBKOIOILJD(BMIJMDOMMDB<ToolCleanupStatusData_v1> component_24, LFCABGLCIIC<ToolCleanupStatusData> component_25, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x24E6450", Offset = "0x24E5450", VA = "0x1824E6450")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : GJABIMIGKAI
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public BMIJMDOMMDB<ReplicatorData_v1> component_30;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public LFCABGLCIIC<ReplicatorData> component_31;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6E68D90", Offset = "0x6E67D90", VA = "0x186E68D90")]
			private void IMFKDLPCDFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6E68D80", Offset = "0x6E67D80", VA = "0x186E68D80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly CDBONJBDMGH log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override CDBONJBDMGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6E68A90", Offset = "0x6E67A90", VA = "0x186E68A90", Slot = "14")]
			get
			{
				return default(CDBONJBDMGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E68AE0", Offset = "0x6E67AE0", VA = "0x186E68AE0", Slot = "15")]
		protected override void FFLBEMPLCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E68C50", Offset = "0x6E67C50", VA = "0x186E68C50")]
		private JobHandle ICDBGNMODNB(BMIJMDOMMDB<ReplicatorData_v1> component_30, LFCABGLCIIC<ReplicatorData> component_31, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x24E6450", Offset = "0x24E5450", VA = "0x1824E6450")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : GJABIMIGKAI
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public BMIJMDOMMDB<InventionInstanceIdData_v1> component_33;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public LFCABGLCIIC<InventionInstanceIdData> component_34;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6E66320", Offset = "0x6E65320", VA = "0x186E66320")]
			private void IMFKDLPCDFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6E66310", Offset = "0x6E65310", VA = "0x186E66310", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly CDBONJBDMGH log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override CDBONJBDMGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6E66150", Offset = "0x6E65150", VA = "0x186E66150", Slot = "14")]
			get
			{
				return default(CDBONJBDMGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6E661A0", Offset = "0x6E651A0", VA = "0x186E661A0", Slot = "15")]
		protected override void FFLBEMPLCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6E665D0", Offset = "0x6E655D0", VA = "0x186E665D0")]
		private JobHandle PMLPAHDGLLL(BMIJMDOMMDB<InventionInstanceIdData_v1> component_33, LFCABGLCIIC<InventionInstanceIdData> component_34, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x24E6450", Offset = "0x24E5450", VA = "0x1824E6450")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : GJABIMIGKAI
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public BMIJMDOMMDB<OMShapeContainerData_v1> component_37;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public LFCABGLCIIC<OMShapeContainerData> component_38;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6E670D0", Offset = "0x6E660D0", VA = "0x186E670D0")]
			private void IMFKDLPCDFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6E670C0", Offset = "0x6E660C0", VA = "0x186E670C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly CDBONJBDMGH log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override CDBONJBDMGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6E66F00", Offset = "0x6E65F00", VA = "0x186E66F00", Slot = "14")]
			get
			{
				return default(CDBONJBDMGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6E66F50", Offset = "0x6E65F50", VA = "0x186E66F50", Slot = "15")]
		protected override void FFLBEMPLCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6E66DD0", Offset = "0x6E65DD0", VA = "0x186E66DD0")]
		private JobHandle CIOGMNIPPDH(BMIJMDOMMDB<OMShapeContainerData_v1> component_37, LFCABGLCIIC<OMShapeContainerData> component_38, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x24E6450", Offset = "0x24E5450", VA = "0x1824E6450")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class ContainerFlagsDataUpgradeSystem : GJABIMIGKAI
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ContainerFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public BMIJMDOMMDB<ContainerFlagsData_v1> component_59;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public LFCABGLCIIC<ContainerFlagsData> component_60;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6E65E30", Offset = "0x6E64E30", VA = "0x186E65E30")]
			private void IMFKDLPCDFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6E65E20", Offset = "0x6E64E20", VA = "0x186E65E20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly CDBONJBDMGH log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override CDBONJBDMGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6E65B30", Offset = "0x6E64B30", VA = "0x186E65B30", Slot = "14")]
			get
			{
				return default(CDBONJBDMGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6E65B80", Offset = "0x6E64B80", VA = "0x186E65B80", Slot = "15")]
		protected override void FFLBEMPLCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6E65CF0", Offset = "0x6E64CF0", VA = "0x186E65CF0")]
		private JobHandle FOMBIGOCMHL(BMIJMDOMMDB<ContainerFlagsData_v1> component_59, LFCABGLCIIC<ContainerFlagsData> component_60, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x24E6450", Offset = "0x24E5450", VA = "0x1824E6450")]
		public ContainerFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : GJABIMIGKAI
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public BMIJMDOMMDB<ObjectPolicyData_v1> component_64;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public BMIJMDOMMDB<ObjectPolicyData_v2> component_65;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public BMIJMDOMMDB<ObjectPolicyData_v3> component_66;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public BMIJMDOMMDB<ObjectPolicyData_v4> component_67;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public LFCABGLCIIC<ObjectPolicyData> component_68;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6E67930", Offset = "0x6E66930", VA = "0x186E67930")]
			private void IMFKDLPCDFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6E67920", Offset = "0x6E66920", VA = "0x186E67920", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly CDBONJBDMGH log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override CDBONJBDMGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6E67600", Offset = "0x6E66600", VA = "0x186E67600", Slot = "14")]
			get
			{
				return default(CDBONJBDMGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6E67650", Offset = "0x6E66650", VA = "0x186E67650", Slot = "15")]
		protected override void FFLBEMPLCDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E67410", Offset = "0x6E66410", VA = "0x186E67410")]
		private JobHandle BOHGIDDDGEK(BMIJMDOMMDB<ObjectPolicyData_v1> component_64, BMIJMDOMMDB<ObjectPolicyData_v2> component_65, BMIJMDOMMDB<ObjectPolicyData_v3> component_66, BMIJMDOMMDB<ObjectPolicyData_v4> component_67, LFCABGLCIIC<ObjectPolicyData> component_68, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x24E6450", Offset = "0x24E5450", VA = "0x1824E6450")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal static class LJLCEOHDFPB
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x305F180", Offset = "0x305E180", VA = "0x18305F180")]
	public static void CBNHKNFMJPJ<T>(T FGKCFOGKEJL, [Out] T OKACLIDCEGJ) where T : struct
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
