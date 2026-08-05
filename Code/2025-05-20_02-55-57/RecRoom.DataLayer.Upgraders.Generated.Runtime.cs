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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ANCAFBPHMLG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C49CF0", Offset = "0x7C48EF0", VA = "0x187C49CF0")]
	public static void PLFOGBAEJMA(ComponentSystemGroup DHOGCHOHKLD, EntityCommandBufferSystem NLAHBKJHOJD)
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
		[Cpp2IlInjected.Address(RVA = "0x7C49CF0", Offset = "0x7C48EF0", VA = "0x187C49CF0")]
		public static void BDNPMGFPPAG(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C50E40", Offset = "0x7C50040", VA = "0x187C50E40")]
		private void PLFOGBAEJMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C50DB0", Offset = "0x7C4FFB0", VA = "0x187C50DB0")]
		private void IEGIFHMAMAO(DLCFKFGCDJI system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : DLCFKFGCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public BCODEDNKMLC<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public ECAGBHMAEHO<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D140", Offset = "0x7C4C340", VA = "0x187C4D140")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D130", Offset = "0x7C4C330", VA = "0x187C4D130", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly FODGIOKBGBI log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override FODGIOKBGBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D480", Offset = "0x7C4C680", VA = "0x187C4D480", Slot = "14")]
			get
			{
				return default(FODGIOKBGBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D4D0", Offset = "0x7C4C6D0", VA = "0x187C4D4D0", Slot = "15")]
		protected override void NPLOINNMNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D000", Offset = "0x7C4C200", VA = "0x187C4D000")]
		private JobHandle APMDNOGELOF(BCODEDNKMLC<PersistentUserTagData_v1> component_1, ECAGBHMAEHO<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : DLCFKFGCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public BCODEDNKMLC<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public ECAGBHMAEHO<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7C4B120", Offset = "0x7C4A320", VA = "0x187C4B120")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7C4B110", Offset = "0x7C4A310", VA = "0x187C4B110", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly FODGIOKBGBI log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override FODGIOKBGBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7C4B400", Offset = "0x7C4A600", VA = "0x187C4B400", Slot = "14")]
			get
			{
				return default(FODGIOKBGBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B450", Offset = "0x7C4A650", VA = "0x187C4B450", Slot = "15")]
		protected override void NPLOINNMNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AFE0", Offset = "0x7C4A1E0", VA = "0x187C4AFE0")]
		private JobHandle IKLDMOBINGE(BCODEDNKMLC<LocalDeformableScaleData_v1> component_4, ECAGBHMAEHO<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : DLCFKFGCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public BCODEDNKMLC<SerializedDataLayerVersionData_v1> component_12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public ECAGBHMAEHO<SerializedDataLayerVersionData> component_13;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7C50140", Offset = "0x7C4F340", VA = "0x187C50140")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7C50130", Offset = "0x7C4F330", VA = "0x187C50130", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly FODGIOKBGBI log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override FODGIOKBGBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7C50400", Offset = "0x7C4F600", VA = "0x187C50400", Slot = "14")]
			get
			{
				return default(FODGIOKBGBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C50450", Offset = "0x7C4F650", VA = "0x187C50450", Slot = "15")]
		protected override void NPLOINNMNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C505C0", Offset = "0x7C4F7C0", VA = "0x187C505C0")]
		private JobHandle PHJPGABLGCG(BCODEDNKMLC<SerializedDataLayerVersionData_v1> component_12, ECAGBHMAEHO<SerializedDataLayerVersionData> component_13, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : DLCFKFGCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public BCODEDNKMLC<ReplicatorPreallocatedObjectCountData_v1> component_21;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public ECAGBHMAEHO<ReplicatorPreallocatedObjectCountData> component_22;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7C4FB30", Offset = "0x7C4ED30", VA = "0x187C4FB30")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7C4FB20", Offset = "0x7C4ED20", VA = "0x187C4FB20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly FODGIOKBGBI log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override FODGIOKBGBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7C4FDF0", Offset = "0x7C4EFF0", VA = "0x187C4FDF0", Slot = "14")]
			get
			{
				return default(FODGIOKBGBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FE40", Offset = "0x7C4F040", VA = "0x187C4FE40", Slot = "15")]
		protected override void NPLOINNMNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FFB0", Offset = "0x7C4F1B0", VA = "0x187C4FFB0")]
		private JobHandle PGEMLCLECJL(BCODEDNKMLC<ReplicatorPreallocatedObjectCountData_v1> component_21, ECAGBHMAEHO<ReplicatorPreallocatedObjectCountData> component_22, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : DLCFKFGCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public BCODEDNKMLC<ToolCleanupStatusData_v1> component_26;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public ECAGBHMAEHO<ToolCleanupStatusData> component_27;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7C50880", Offset = "0x7C4FA80", VA = "0x187C50880")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7C50870", Offset = "0x7C4FA70", VA = "0x187C50870", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly FODGIOKBGBI log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override FODGIOKBGBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7C50BA0", Offset = "0x7C4FDA0", VA = "0x187C50BA0", Slot = "14")]
			get
			{
				return default(FODGIOKBGBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C50BF0", Offset = "0x7C4FDF0", VA = "0x187C50BF0", Slot = "15")]
		protected override void NPLOINNMNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C50740", Offset = "0x7C4F940", VA = "0x187C50740")]
		private JobHandle FBCNKBBLJNF(BCODEDNKMLC<ToolCleanupStatusData_v1> component_26, ECAGBHMAEHO<ToolCleanupStatusData> component_27, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : DLCFKFGCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public BCODEDNKMLC<ReplicatorData_v1> component_34;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ECAGBHMAEHO<ReplicatorData> component_35;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7C4F610", Offset = "0x7C4E810", VA = "0x187C4F610")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7C4F600", Offset = "0x7C4E800", VA = "0x187C4F600", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly FODGIOKBGBI log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override FODGIOKBGBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7C4F910", Offset = "0x7C4EB10", VA = "0x187C4F910", Slot = "14")]
			get
			{
				return default(FODGIOKBGBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F960", Offset = "0x7C4EB60", VA = "0x187C4F960", Slot = "15")]
		protected override void NPLOINNMNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F4D0", Offset = "0x7C4E6D0", VA = "0x187C4F4D0")]
		private JobHandle LHGLDCLKAFP(BCODEDNKMLC<ReplicatorData_v1> component_34, ECAGBHMAEHO<ReplicatorData> component_35, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : DLCFKFGCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public BCODEDNKMLC<InventionInstanceIdData_v1> component_38;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ECAGBHMAEHO<InventionInstanceIdData> component_39;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7C4AB20", Offset = "0x7C49D20", VA = "0x187C4AB20")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7C4AB10", Offset = "0x7C49D10", VA = "0x187C4AB10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly FODGIOKBGBI log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override FODGIOKBGBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7C4ADD0", Offset = "0x7C49FD0", VA = "0x187C4ADD0", Slot = "14")]
			get
			{
				return default(FODGIOKBGBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AE20", Offset = "0x7C4A020", VA = "0x187C4AE20", Slot = "15")]
		protected override void NPLOINNMNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A9E0", Offset = "0x7C49BE0", VA = "0x187C4A9E0")]
		private JobHandle JEJLGBNHFDL(BCODEDNKMLC<InventionInstanceIdData_v1> component_38, ECAGBHMAEHO<InventionInstanceIdData> component_39, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : DLCFKFGCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public BCODEDNKMLC<OMShapeContainerData_v1> component_42;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public ECAGBHMAEHO<OMShapeContainerData> component_43;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7C4B750", Offset = "0x7C4A950", VA = "0x187C4B750")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7C4B740", Offset = "0x7C4A940", VA = "0x187C4B740", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly FODGIOKBGBI log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override FODGIOKBGBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7C4BA40", Offset = "0x7C4AC40", VA = "0x187C4BA40", Slot = "14")]
			get
			{
				return default(FODGIOKBGBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C4BA90", Offset = "0x7C4AC90", VA = "0x187C4BA90", Slot = "15")]
		protected override void NPLOINNMNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B610", Offset = "0x7C4A810", VA = "0x187C4B610")]
		private JobHandle IPFGBKFOEEA(BCODEDNKMLC<OMShapeContainerData_v1> component_42, ECAGBHMAEHO<OMShapeContainerData> component_43, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : DLCFKFGCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public BCODEDNKMLC<AuthoredAIIdData_v1> component_51;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public BCODEDNKMLC<AuthoredAIIdData_v2> component_52;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public BCODEDNKMLC<AuthoredAIIdData_v3> component_53;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public ECAGBHMAEHO<AuthoredAIIdData> component_54;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7C49FC0", Offset = "0x7C491C0", VA = "0x187C49FC0")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7C49FB0", Offset = "0x7C491B0", VA = "0x187C49FB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly FODGIOKBGBI log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override FODGIOKBGBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7C4A6E0", Offset = "0x7C498E0", VA = "0x187C4A6E0", Slot = "14")]
			get
			{
				return default(FODGIOKBGBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A730", Offset = "0x7C49930", VA = "0x187C4A730", Slot = "15")]
		protected override void NPLOINNMNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7C49E10", Offset = "0x7C49010", VA = "0x187C49E10")]
		private JobHandle LOGLIPABGIB(BCODEDNKMLC<AuthoredAIIdData_v1> component_51, BCODEDNKMLC<AuthoredAIIdData_v2> component_52, BCODEDNKMLC<AuthoredAIIdData_v3> component_53, ECAGBHMAEHO<AuthoredAIIdData> component_54, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : DLCFKFGCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public BCODEDNKMLC<ContainerCollisionLayerData_v1> component_63;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public ECAGBHMAEHO<PhysicsModelCollisionLayerData> component_64;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D7D0", Offset = "0x7C4C9D0", VA = "0x187C4D7D0")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D7C0", Offset = "0x7C4C9C0", VA = "0x187C4D7C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly FODGIOKBGBI log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override FODGIOKBGBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7C4DAC0", Offset = "0x7C4CCC0", VA = "0x187C4DAC0", Slot = "14")]
			get
			{
				return default(FODGIOKBGBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DB10", Offset = "0x7C4CD10", VA = "0x187C4DB10", Slot = "15")]
		protected override void NPLOINNMNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D690", Offset = "0x7C4C890", VA = "0x187C4D690")]
		private JobHandle KJCELCDMFBD(BCODEDNKMLC<ContainerCollisionLayerData_v1> component_63, ECAGBHMAEHO<PhysicsModelCollisionLayerData> component_64, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : DLCFKFGCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public BCODEDNKMLC<ContainerGrabbableModeData_v1> component_67;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public ECAGBHMAEHO<PhysicsModelGrabbableModeData> component_68;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7C4EFD0", Offset = "0x7C4E1D0", VA = "0x187C4EFD0")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7C4EFC0", Offset = "0x7C4E1C0", VA = "0x187C4EFC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly FODGIOKBGBI log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override FODGIOKBGBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7C4F2C0", Offset = "0x7C4E4C0", VA = "0x187C4F2C0", Slot = "14")]
			get
			{
				return default(FODGIOKBGBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F310", Offset = "0x7C4E510", VA = "0x187C4F310", Slot = "15")]
		protected override void NPLOINNMNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EE90", Offset = "0x7C4E090", VA = "0x187C4EE90")]
		private JobHandle LIHOCCOGDJH(BCODEDNKMLC<ContainerGrabbableModeData_v1> component_67, ECAGBHMAEHO<PhysicsModelGrabbableModeData> component_68, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : DLCFKFGCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public BCODEDNKMLC<ContainerFlagsData_v1> component_75;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public BCODEDNKMLC<ContainerFlagsData_v2> component_76;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public BCODEDNKMLC<PhysicsModelFlagsData_v3> component_77;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ECAGBHMAEHO<PhysicsModelFlagsData> component_78;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7C4E320", Offset = "0x7C4D520", VA = "0x187C4E320")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7C4E310", Offset = "0x7C4D510", VA = "0x187C4E310", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly FODGIOKBGBI log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override FODGIOKBGBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7C4E9F0", Offset = "0x7C4DBF0", VA = "0x187C4E9F0", Slot = "14")]
			get
			{
				return default(FODGIOKBGBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EA40", Offset = "0x7C4DC40", VA = "0x187C4EA40", Slot = "15")]
		protected override void NPLOINNMNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7C4ECA0", Offset = "0x7C4DEA0", VA = "0x187C4ECA0")]
		private JobHandle PMMHICKEIIG(BCODEDNKMLC<ContainerFlagsData_v1> component_75, BCODEDNKMLC<ContainerFlagsData_v2> component_76, BCODEDNKMLC<PhysicsModelFlagsData_v3> component_77, ECAGBHMAEHO<PhysicsModelFlagsData> component_78, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : DLCFKFGCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public BCODEDNKMLC<ContainerCollisionModeData_v1> component_79;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ECAGBHMAEHO<PhysicsModelCollisionModeData> component_80;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7C4DE10", Offset = "0x7C4D010", VA = "0x187C4DE10")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7C4DE00", Offset = "0x7C4D000", VA = "0x187C4DE00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly FODGIOKBGBI log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override FODGIOKBGBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7C4E100", Offset = "0x7C4D300", VA = "0x187C4E100", Slot = "14")]
			get
			{
				return default(FODGIOKBGBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7C4E150", Offset = "0x7C4D350", VA = "0x187C4E150", Slot = "15")]
		protected override void NPLOINNMNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7C4DCD0", Offset = "0x7C4CED0", VA = "0x187C4DCD0")]
		private JobHandle FFDKLKPLDMA(BCODEDNKMLC<ContainerCollisionModeData_v1> component_79, ECAGBHMAEHO<PhysicsModelCollisionModeData> component_80, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : DLCFKFGCDJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public BCODEDNKMLC<ObjectPolicyData_v1> component_83;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public BCODEDNKMLC<ObjectPolicyData_v2> component_84;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public BCODEDNKMLC<ObjectPolicyData_v3> component_85;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public BCODEDNKMLC<ObjectPolicyData_v4> component_86;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public BCODEDNKMLC<ObjectPolicyData_v5> component_87;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public ECAGBHMAEHO<ObjectPolicyData> component_88;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7C4BE60", Offset = "0x7C4B060", VA = "0x187C4BE60")]
			private void FGCAKPAPGGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7C4BE50", Offset = "0x7C4B050", VA = "0x187C4BE50", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly FODGIOKBGBI log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override FODGIOKBGBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7C4CC50", Offset = "0x7C4BE50", VA = "0x187C4CC50", Slot = "14")]
			get
			{
				return default(FODGIOKBGBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7C4CCA0", Offset = "0x7C4BEA0", VA = "0x187C4CCA0", Slot = "15")]
		protected override void NPLOINNMNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7C4BC50", Offset = "0x7C4AE50", VA = "0x187C4BC50")]
		private JobHandle HPJLEANOCEP(BCODEDNKMLC<ObjectPolicyData_v1> component_83, BCODEDNKMLC<ObjectPolicyData_v2> component_84, BCODEDNKMLC<ObjectPolicyData_v3> component_85, BCODEDNKMLC<ObjectPolicyData_v4> component_86, BCODEDNKMLC<ObjectPolicyData_v5> component_87, ECAGBHMAEHO<ObjectPolicyData> component_88, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class JJIAAKCCKGD
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x386ABA0", Offset = "0x3869DA0", VA = "0x18386ABA0")]
	public static void JCCDIMGKOBC<T, U>(T KAFBMBFLMAN, [Out] U IGOGNOGJADN) where T : struct where U : struct
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
