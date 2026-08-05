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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HAOOILAPPAK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F053B0", Offset = "0x6F03BB0", VA = "0x186F053B0")]
	public static void KANPDLAAFAG(ComponentSystemGroup PMGFPJDBJBB, EntityCommandBufferSystem EFNKGCOBBLO)
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
		[Cpp2IlInjected.Address(RVA = "0x6F053B0", Offset = "0x6F03BB0", VA = "0x186F053B0")]
		public static void OHGLIPLIPNF(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F09720", Offset = "0x6F07F20", VA = "0x186F09720")]
		private void KANPDLAAFAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F09690", Offset = "0x6F07E90", VA = "0x186F09690")]
		private void DLDJIPPLDPO(EDFCFDIJLGN system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : EDFCFDIJLGN
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public LMLJKANCIDC<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public LINIHFPALHJ<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6F078E0", Offset = "0x6F060E0", VA = "0x186F078E0")]
			private void CILIOJBKPLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6F07C20", Offset = "0x6F06420", VA = "0x186F07C20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly FICDJCDJOAA log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override FICDJCDJOAA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6F07890", Offset = "0x6F06090", VA = "0x186F07890", Slot = "14")]
			get
			{
				return default(FICDJCDJOAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F07720", Offset = "0x6F05F20", VA = "0x186F07720", Slot = "15")]
		protected override void BBKHHLIBAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F07C30", Offset = "0x6F06430", VA = "0x186F07C30")]
		private JobHandle NDDGKJCCDMP(LMLJKANCIDC<PersistentUserTagData_v1> component_1, LINIHFPALHJ<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : EDFCFDIJLGN
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public LMLJKANCIDC<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public LINIHFPALHJ<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6F05BC0", Offset = "0x6F043C0", VA = "0x186F05BC0")]
			private void CILIOJBKPLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6F05EA0", Offset = "0x6F046A0", VA = "0x186F05EA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly FICDJCDJOAA log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override FICDJCDJOAA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6F05B70", Offset = "0x6F04370", VA = "0x186F05B70", Slot = "14")]
			get
			{
				return default(FICDJCDJOAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F05A00", Offset = "0x6F04200", VA = "0x186F05A00", Slot = "15")]
		protected override void BBKHHLIBAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F05EB0", Offset = "0x6F046B0", VA = "0x186F05EB0")]
		private JobHandle PCMNAAKAJKN(LMLJKANCIDC<LocalDeformableScaleData_v1> component_3, LINIHFPALHJ<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : EDFCFDIJLGN
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public LMLJKANCIDC<SerializedDataLayerVersionData_v1> component_11;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public LINIHFPALHJ<SerializedDataLayerVersionData> component_12;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F08BD0", Offset = "0x6F073D0", VA = "0x186F08BD0")]
			private void CILIOJBKPLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6F08E90", Offset = "0x6F07690", VA = "0x186F08E90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly FICDJCDJOAA log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override FICDJCDJOAA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F08B80", Offset = "0x6F07380", VA = "0x186F08B80", Slot = "14")]
			get
			{
				return default(FICDJCDJOAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F08A10", Offset = "0x6F07210", VA = "0x186F08A10", Slot = "15")]
		protected override void BBKHHLIBAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F08EA0", Offset = "0x6F076A0", VA = "0x186F08EA0")]
		private JobHandle MADAJDBGLKN(LMLJKANCIDC<SerializedDataLayerVersionData_v1> component_11, LINIHFPALHJ<SerializedDataLayerVersionData> component_12, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : EDFCFDIJLGN
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public LMLJKANCIDC<ReplicatorPreallocatedObjectCountData_v1> component_21;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public LINIHFPALHJ<ReplicatorPreallocatedObjectCountData> component_22;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F086F0", Offset = "0x6F06EF0", VA = "0x186F086F0")]
			private void CILIOJBKPLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6F089B0", Offset = "0x6F071B0", VA = "0x186F089B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly FICDJCDJOAA log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override FICDJCDJOAA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6F08570", Offset = "0x6F06D70", VA = "0x186F08570", Slot = "14")]
			get
			{
				return default(FICDJCDJOAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F08400", Offset = "0x6F06C00", VA = "0x186F08400", Slot = "15")]
		protected override void BBKHHLIBAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F085C0", Offset = "0x6F06DC0", VA = "0x186F085C0")]
		private JobHandle JPODPGMKNLF(LMLJKANCIDC<ReplicatorPreallocatedObjectCountData_v1> component_21, LINIHFPALHJ<ReplicatorPreallocatedObjectCountData> component_22, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : EDFCFDIJLGN
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public LMLJKANCIDC<ToolCleanupStatusData_v1> component_25;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public LINIHFPALHJ<ToolCleanupStatusData> component_26;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F09310", Offset = "0x6F07B10", VA = "0x186F09310")]
			private void CILIOJBKPLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F09630", Offset = "0x6F07E30", VA = "0x186F09630", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly FICDJCDJOAA log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override FICDJCDJOAA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F092C0", Offset = "0x6F07AC0", VA = "0x186F092C0", Slot = "14")]
			get
			{
				return default(FICDJCDJOAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F09150", Offset = "0x6F07950", VA = "0x186F09150", Slot = "15")]
		protected override void BBKHHLIBAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F09020", Offset = "0x6F07820", VA = "0x186F09020")]
		private JobHandle ANCFAHMJKMM(LMLJKANCIDC<ToolCleanupStatusData_v1> component_25, LINIHFPALHJ<ToolCleanupStatusData> component_26, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : EDFCFDIJLGN
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public LMLJKANCIDC<ReplicatorData_v1> component_31;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public LINIHFPALHJ<ReplicatorData> component_32;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F080A0", Offset = "0x6F068A0", VA = "0x186F080A0")]
			private void CILIOJBKPLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F083A0", Offset = "0x6F06BA0", VA = "0x186F083A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly FICDJCDJOAA log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override FICDJCDJOAA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F07F20", Offset = "0x6F06720", VA = "0x186F07F20", Slot = "14")]
			get
			{
				return default(FICDJCDJOAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F07DB0", Offset = "0x6F065B0", VA = "0x186F07DB0", Slot = "15")]
		protected override void BBKHHLIBAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F07F70", Offset = "0x6F06770", VA = "0x186F07F70")]
		private JobHandle HLMOMDFPCGD(LMLJKANCIDC<ReplicatorData_v1> component_31, LINIHFPALHJ<ReplicatorData> component_32, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : EDFCFDIJLGN
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public LMLJKANCIDC<InventionInstanceIdData_v1> component_34;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public LINIHFPALHJ<InventionInstanceIdData> component_35;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F055C0", Offset = "0x6F03DC0", VA = "0x186F055C0")]
			private void CILIOJBKPLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F05870", Offset = "0x6F04070", VA = "0x186F05870", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly FICDJCDJOAA log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override FICDJCDJOAA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F05570", Offset = "0x6F03D70", VA = "0x186F05570", Slot = "14")]
			get
			{
				return default(FICDJCDJOAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6F05400", Offset = "0x6F03C00", VA = "0x186F05400", Slot = "15")]
		protected override void BBKHHLIBAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6F05880", Offset = "0x6F04080", VA = "0x186F05880")]
		private JobHandle PMDENPOEDAA(LMLJKANCIDC<InventionInstanceIdData_v1> component_34, LINIHFPALHJ<InventionInstanceIdData> component_35, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : EDFCFDIJLGN
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LMLJKANCIDC<OMShapeContainerData_v1> component_38;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public LINIHFPALHJ<OMShapeContainerData> component_39;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F06320", Offset = "0x6F04B20", VA = "0x186F06320")]
			private void CILIOJBKPLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6F06610", Offset = "0x6F04E10", VA = "0x186F06610", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly FICDJCDJOAA log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override FICDJCDJOAA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6F061A0", Offset = "0x6F049A0", VA = "0x186F061A0", Slot = "14")]
			get
			{
				return default(FICDJCDJOAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6F06030", Offset = "0x6F04830", VA = "0x186F06030", Slot = "15")]
		protected override void BBKHHLIBAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F061F0", Offset = "0x6F049F0", VA = "0x186F061F0")]
		private JobHandle EKIAAMIEBDI(LMLJKANCIDC<OMShapeContainerData_v1> component_38, LINIHFPALHJ<OMShapeContainerData> component_39, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class ContainerFlagsDataUpgradeSystem : EDFCFDIJLGN
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ContainerFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public LMLJKANCIDC<ContainerFlagsData_v1> component_60;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public LINIHFPALHJ<ContainerFlagsData> component_61;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6F05060", Offset = "0x6F03860", VA = "0x186F05060")]
			private void CILIOJBKPLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6F05350", Offset = "0x6F03B50", VA = "0x186F05350", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly FICDJCDJOAA log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override FICDJCDJOAA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6F04EE0", Offset = "0x6F036E0", VA = "0x186F04EE0", Slot = "14")]
			get
			{
				return default(FICDJCDJOAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6F04D70", Offset = "0x6F03570", VA = "0x186F04D70", Slot = "15")]
		protected override void BBKHHLIBAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6F04F30", Offset = "0x6F03730", VA = "0x186F04F30")]
		private JobHandle FILNMOGMGFE(LMLJKANCIDC<ContainerFlagsData_v1> component_60, LINIHFPALHJ<ContainerFlagsData> component_61, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
		public ContainerFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : EDFCFDIJLGN
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public LMLJKANCIDC<ObjectPolicyData_v1> component_65;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public LMLJKANCIDC<ObjectPolicyData_v2> component_66;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public LMLJKANCIDC<ObjectPolicyData_v3> component_67;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public LMLJKANCIDC<ObjectPolicyData_v4> component_68;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public LINIHFPALHJ<ObjectPolicyData> component_69;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6F06B80", Offset = "0x6F05380", VA = "0x186F06B80")]
			private void CILIOJBKPLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6F076C0", Offset = "0x6F05EC0", VA = "0x186F076C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly FICDJCDJOAA log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override FICDJCDJOAA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6F06B30", Offset = "0x6F05330", VA = "0x186F06B30", Slot = "14")]
			get
			{
				return default(FICDJCDJOAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6F06670", Offset = "0x6F04E70", VA = "0x186F06670", Slot = "15")]
		protected override void BBKHHLIBAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6F06940", Offset = "0x6F05140", VA = "0x186F06940")]
		private JobHandle DEPBPJJGKKO(LMLJKANCIDC<ObjectPolicyData_v1> component_65, LMLJKANCIDC<ObjectPolicyData_v2> component_66, LMLJKANCIDC<ObjectPolicyData_v3> component_67, LMLJKANCIDC<ObjectPolicyData_v4> component_68, LINIHFPALHJ<ObjectPolicyData> component_69, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2548870", Offset = "0x2547070", VA = "0x182548870")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class NOBEBMAOJBC
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x31D50B0", Offset = "0x31D38B0", VA = "0x1831D50B0")]
	public static void NHMCGJPMGHJ<T, U>(T EHAFKKPIECD, [Out] U PPBHJEMIBIL) where T : struct where U : struct
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
