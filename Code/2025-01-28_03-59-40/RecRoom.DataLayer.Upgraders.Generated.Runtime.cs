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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EGDEOIIGJNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x71D6D10", Offset = "0x71D5F10", VA = "0x1871D6D10")]
	public static void CGCDHJDEHHF(ComponentSystemGroup GEDEGGCFAKO, EntityCommandBufferSystem MLMLNFOKANM)
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
		[Cpp2IlInjected.Address(RVA = "0x71D6D10", Offset = "0x71D5F10", VA = "0x1871D6D10")]
		public static void DLNNJCPOALH(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71DCF10", Offset = "0x71DC110", VA = "0x1871DCF10")]
		private void CGCDHJDEHHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71DD760", Offset = "0x71DC960", VA = "0x1871DD760")]
		private void NGPKNFODBHK(JPAPMNEMGHI system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : JPAPMNEMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public NEAJNNAOFGC<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public NELBMGEDNKH<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x71D9680", Offset = "0x71D8880", VA = "0x1871D9680")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x71D9670", Offset = "0x71D8870", VA = "0x1871D9670", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly KJMCEDJMPPA log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override KJMCEDJMPPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x71D9620", Offset = "0x71D8820", VA = "0x1871D9620", Slot = "14")]
			get
			{
				return default(KJMCEDJMPPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71D94B0", Offset = "0x71D86B0", VA = "0x1871D94B0", Slot = "15")]
		protected override void IPJOENOACDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71D9380", Offset = "0x71D8580", VA = "0x1871D9380")]
		private JobHandle CGIPBPGNFLB(NEAJNNAOFGC<PersistentUserTagData_v1> component_1, NELBMGEDNKH<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : JPAPMNEMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public NEAJNNAOFGC<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public NELBMGEDNKH<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x71D7660", Offset = "0x71D6860", VA = "0x1871D7660")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x71D7650", Offset = "0x71D6850", VA = "0x1871D7650", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly KJMCEDJMPPA log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override KJMCEDJMPPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x71D7600", Offset = "0x71D6800", VA = "0x1871D7600", Slot = "14")]
			get
			{
				return default(KJMCEDJMPPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x71D7490", Offset = "0x71D6690", VA = "0x1871D7490", Slot = "15")]
		protected override void IPJOENOACDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71D7360", Offset = "0x71D6560", VA = "0x1871D7360")]
		private JobHandle ADCKEKCPOAM(NEAJNNAOFGC<LocalDeformableScaleData_v1> component_3, NELBMGEDNKH<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : JPAPMNEMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public NEAJNNAOFGC<SerializedDataLayerVersionData_v1> component_11;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public NELBMGEDNKH<SerializedDataLayerVersionData> component_12;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x71DC590", Offset = "0x71DB790", VA = "0x1871DC590")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x71DC580", Offset = "0x71DB780", VA = "0x1871DC580", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly KJMCEDJMPPA log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override KJMCEDJMPPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x71DC530", Offset = "0x71DB730", VA = "0x1871DC530", Slot = "14")]
			get
			{
				return default(KJMCEDJMPPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71DC3C0", Offset = "0x71DB5C0", VA = "0x1871DC3C0", Slot = "15")]
		protected override void IPJOENOACDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x71DC290", Offset = "0x71DB490", VA = "0x1871DC290")]
		private JobHandle BLCMDDADIJH(NEAJNNAOFGC<SerializedDataLayerVersionData_v1> component_11, NELBMGEDNKH<SerializedDataLayerVersionData> component_12, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : JPAPMNEMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public NEAJNNAOFGC<ReplicatorPreallocatedObjectCountData_v1> component_21;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public NELBMGEDNKH<ReplicatorPreallocatedObjectCountData> component_22;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x71DBF80", Offset = "0x71DB180", VA = "0x1871DBF80")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x71DBF70", Offset = "0x71DB170", VA = "0x1871DBF70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly KJMCEDJMPPA log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override KJMCEDJMPPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x71DBF20", Offset = "0x71DB120", VA = "0x1871DBF20", Slot = "14")]
			get
			{
				return default(KJMCEDJMPPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x71DBDB0", Offset = "0x71DAFB0", VA = "0x1871DBDB0", Slot = "15")]
		protected override void IPJOENOACDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71DBC80", Offset = "0x71DAE80", VA = "0x1871DBC80")]
		private JobHandle GCHNIDAGHPG(NEAJNNAOFGC<ReplicatorPreallocatedObjectCountData_v1> component_21, NELBMGEDNKH<ReplicatorPreallocatedObjectCountData> component_22, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : JPAPMNEMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public NEAJNNAOFGC<ToolCleanupStatusData_v1> component_25;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public NELBMGEDNKH<ToolCleanupStatusData> component_26;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x71DCBA0", Offset = "0x71DBDA0", VA = "0x1871DCBA0")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x71DCB90", Offset = "0x71DBD90", VA = "0x1871DCB90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly KJMCEDJMPPA log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override KJMCEDJMPPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x71DCB40", Offset = "0x71DBD40", VA = "0x1871DCB40", Slot = "14")]
			get
			{
				return default(KJMCEDJMPPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x71DC9D0", Offset = "0x71DBBD0", VA = "0x1871DC9D0", Slot = "15")]
		protected override void IPJOENOACDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71DC8A0", Offset = "0x71DBAA0", VA = "0x1871DC8A0")]
		private JobHandle DAOCHHGCGIE(NEAJNNAOFGC<ToolCleanupStatusData_v1> component_25, NELBMGEDNKH<ToolCleanupStatusData> component_26, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : JPAPMNEMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public NEAJNNAOFGC<ReplicatorData_v1> component_31;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public NELBMGEDNKH<ReplicatorData> component_32;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x71DB930", Offset = "0x71DAB30", VA = "0x1871DB930")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x71DB920", Offset = "0x71DAB20", VA = "0x1871DB920", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly KJMCEDJMPPA log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override KJMCEDJMPPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x71DB8D0", Offset = "0x71DAAD0", VA = "0x1871DB8D0", Slot = "14")]
			get
			{
				return default(KJMCEDJMPPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x71DB760", Offset = "0x71DA960", VA = "0x1871DB760", Slot = "15")]
		protected override void IPJOENOACDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x71DB630", Offset = "0x71DA830", VA = "0x1871DB630")]
		private JobHandle FFOHLHOMLID(NEAJNNAOFGC<ReplicatorData_v1> component_31, NELBMGEDNKH<ReplicatorData> component_32, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : JPAPMNEMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public NEAJNNAOFGC<InventionInstanceIdData_v1> component_34;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public NELBMGEDNKH<InventionInstanceIdData> component_35;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x71D7060", Offset = "0x71D6260", VA = "0x1871D7060")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x71D7050", Offset = "0x71D6250", VA = "0x1871D7050", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly KJMCEDJMPPA log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override KJMCEDJMPPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x71D7000", Offset = "0x71D6200", VA = "0x1871D7000", Slot = "14")]
			get
			{
				return default(KJMCEDJMPPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x71D6E90", Offset = "0x71D6090", VA = "0x1871D6E90", Slot = "15")]
		protected override void IPJOENOACDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x71D6D60", Offset = "0x71D5F60", VA = "0x1871D6D60")]
		private JobHandle GPBOFKHJKGO(NEAJNNAOFGC<InventionInstanceIdData_v1> component_34, NELBMGEDNKH<InventionInstanceIdData> component_35, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : JPAPMNEMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NEAJNNAOFGC<OMShapeContainerData_v1> component_38;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public NELBMGEDNKH<OMShapeContainerData> component_39;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x71D7B60", Offset = "0x71D6D60", VA = "0x1871D7B60")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x71D7B50", Offset = "0x71D6D50", VA = "0x1871D7B50", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly KJMCEDJMPPA log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override KJMCEDJMPPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x71D7B00", Offset = "0x71D6D00", VA = "0x1871D7B00", Slot = "14")]
			get
			{
				return default(KJMCEDJMPPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x71D7990", Offset = "0x71D6B90", VA = "0x1871D7990", Slot = "15")]
		protected override void IPJOENOACDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x71D7E50", Offset = "0x71D7050", VA = "0x1871D7E50")]
		private JobHandle NCFLKIKPNBG(NEAJNNAOFGC<OMShapeContainerData_v1> component_38, NELBMGEDNKH<OMShapeContainerData> component_39, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : JPAPMNEMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public NEAJNNAOFGC<ContainerCollisionLayerData_v1> component_52;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public NELBMGEDNKH<PhysicsModelCollisionLayerData> component_53;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x71D9D10", Offset = "0x71D8F10", VA = "0x1871D9D10")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x71D9D00", Offset = "0x71D8F00", VA = "0x1871D9D00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly KJMCEDJMPPA log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override KJMCEDJMPPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x71D9CB0", Offset = "0x71D8EB0", VA = "0x1871D9CB0", Slot = "14")]
			get
			{
				return default(KJMCEDJMPPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x71D9B40", Offset = "0x71D8D40", VA = "0x1871D9B40", Slot = "15")]
		protected override void IPJOENOACDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x71D9A10", Offset = "0x71D8C10", VA = "0x1871D9A10")]
		private JobHandle BBKIHKINCJP(NEAJNNAOFGC<ContainerCollisionLayerData_v1> component_52, NELBMGEDNKH<PhysicsModelCollisionLayerData> component_53, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : JPAPMNEMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public NEAJNNAOFGC<ContainerGrabbableModeData_v1> component_56;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public NELBMGEDNKH<PhysicsModelGrabbableModeData> component_57;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x71DB2F0", Offset = "0x71DA4F0", VA = "0x1871DB2F0")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x71DB2E0", Offset = "0x71DA4E0", VA = "0x1871DB2E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly KJMCEDJMPPA log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override KJMCEDJMPPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x71DB290", Offset = "0x71DA490", VA = "0x1871DB290", Slot = "14")]
			get
			{
				return default(KJMCEDJMPPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x71DB120", Offset = "0x71DA320", VA = "0x1871DB120", Slot = "15")]
		protected override void IPJOENOACDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x71DAFF0", Offset = "0x71DA1F0", VA = "0x1871DAFF0")]
		private JobHandle DHNHMHEBLDL(NEAJNNAOFGC<ContainerGrabbableModeData_v1> component_56, NELBMGEDNKH<PhysicsModelGrabbableModeData> component_57, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : JPAPMNEMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public NEAJNNAOFGC<ContainerFlagsData_v1> component_62;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public NEAJNNAOFGC<ContainerFlagsData_v2> component_63;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public NELBMGEDNKH<PhysicsModelFlagsData> component_64;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x71DAAC0", Offset = "0x71D9CC0", VA = "0x1871DAAC0")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x71DAAB0", Offset = "0x71D9CB0", VA = "0x1871DAAB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly KJMCEDJMPPA log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override KJMCEDJMPPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x71DAA60", Offset = "0x71D9C60", VA = "0x1871DAA60", Slot = "14")]
			get
			{
				return default(KJMCEDJMPPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x71DA840", Offset = "0x71D9A40", VA = "0x1871DA840", Slot = "15")]
		protected override void IPJOENOACDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x71DA690", Offset = "0x71D9890", VA = "0x1871DA690")]
		private JobHandle ENCDDGAGLOD(NEAJNNAOFGC<ContainerFlagsData_v1> component_62, NEAJNNAOFGC<ContainerFlagsData_v2> component_63, NELBMGEDNKH<PhysicsModelFlagsData> component_64, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : JPAPMNEMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public NEAJNNAOFGC<ContainerCollisionModeData_v1> component_65;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public NELBMGEDNKH<PhysicsModelCollisionModeData> component_66;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x71DA350", Offset = "0x71D9550", VA = "0x1871DA350")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x71DA340", Offset = "0x71D9540", VA = "0x1871DA340", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly KJMCEDJMPPA log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override KJMCEDJMPPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x71DA2F0", Offset = "0x71D94F0", VA = "0x1871DA2F0", Slot = "14")]
			get
			{
				return default(KJMCEDJMPPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x71DA180", Offset = "0x71D9380", VA = "0x1871DA180", Slot = "15")]
		protected override void IPJOENOACDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x71DA050", Offset = "0x71D9250", VA = "0x1871DA050")]
		private JobHandle CDGLGBOGPKM(NEAJNNAOFGC<ContainerCollisionModeData_v1> component_65, NELBMGEDNKH<PhysicsModelCollisionModeData> component_66, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : JPAPMNEMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public NEAJNNAOFGC<ObjectPolicyData_v1> component_69;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public NEAJNNAOFGC<ObjectPolicyData_v2> component_70;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public NEAJNNAOFGC<ObjectPolicyData_v3> component_71;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public NEAJNNAOFGC<ObjectPolicyData_v4> component_72;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public NEAJNNAOFGC<ObjectPolicyData_v5> component_73;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public NELBMGEDNKH<ObjectPolicyData> component_74;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x71D8540", Offset = "0x71D7740", VA = "0x1871D8540")]
			private void LOKOCOBDHAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x71D8530", Offset = "0x71D7730", VA = "0x1871D8530", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly KJMCEDJMPPA log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override KJMCEDJMPPA Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x71D84E0", Offset = "0x71D76E0", VA = "0x1871D84E0", Slot = "14")]
			get
			{
				return default(KJMCEDJMPPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x71D81D0", Offset = "0x71D73D0", VA = "0x1871D81D0", Slot = "15")]
		protected override void IPJOENOACDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x71D7FD0", Offset = "0x71D71D0", VA = "0x1871D7FD0")]
		private JobHandle GNEIJIGCMBC(NEAJNNAOFGC<ObjectPolicyData_v1> component_69, NEAJNNAOFGC<ObjectPolicyData_v2> component_70, NEAJNNAOFGC<ObjectPolicyData_v3> component_71, NEAJNNAOFGC<ObjectPolicyData_v4> component_72, NEAJNNAOFGC<ObjectPolicyData_v5> component_73, NELBMGEDNKH<ObjectPolicyData> component_74, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x273CC00", Offset = "0x273BE00", VA = "0x18273CC00")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal static class LDIMMCAEDEL
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3335FF0", Offset = "0x33351F0", VA = "0x183335FF0")]
	public static void MEHIEDBDKCD<T, U>(T KGKHOCAIHMN, [Out] U FCKHEFJCHLA) where T : struct where U : struct
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
