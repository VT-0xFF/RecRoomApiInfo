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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JNPLJLBJEFE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F5BEA0", Offset = "0x7F5A4A0", VA = "0x187F5BEA0")]
	public static void JPANBEFMGGL(ComponentSystemGroup HLMMJBEMNBB, EntityCommandBufferSystem MDKIABFNJOH)
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
		[Cpp2IlInjected.Address(RVA = "0x7F5BEA0", Offset = "0x7F5A4A0", VA = "0x187F5BEA0")]
		public static void KOKIDPGIHEJ(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F61E20", Offset = "0x7F60420", VA = "0x187F61E20")]
		private void JPANBEFMGGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F61D90", Offset = "0x7F60390", VA = "0x187F61D90")]
		private void EFPBAGGGNOD(JMEFIFNMAAM system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : JMEFIFNMAAM
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public OICPILLJALL<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public HIDPEOBBDKH<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7F5E2E0", Offset = "0x7F5C8E0", VA = "0x187F5E2E0")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7F5E2D0", Offset = "0x7F5C8D0", VA = "0x187F5E2D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override LHMKAIAPMBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DFE0", Offset = "0x7F5C5E0", VA = "0x187F5DFE0", Slot = "14")]
			get
			{
				return default(LHMKAIAPMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E160", Offset = "0x7F5C760", VA = "0x187F5E160", Slot = "15")]
		protected override void KNOANLOJGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E030", Offset = "0x7F5C630", VA = "0x187F5E030")]
		private JobHandle IPGGEBNNFED(OICPILLJALL<PersistentUserTagData_v1> component_1, HIDPEOBBDKH<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : JMEFIFNMAAM
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public OICPILLJALL<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public HIDPEOBBDKH<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7F5C2C0", Offset = "0x7F5A8C0", VA = "0x187F5C2C0")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7F5C2B0", Offset = "0x7F5A8B0", VA = "0x187F5C2B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override LHMKAIAPMBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7F5BFC0", Offset = "0x7F5A5C0", VA = "0x187F5BFC0", Slot = "14")]
			get
			{
				return default(LHMKAIAPMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C010", Offset = "0x7F5A610", VA = "0x187F5C010", Slot = "15")]
		protected override void KNOANLOJGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C180", Offset = "0x7F5A780", VA = "0x187F5C180")]
		private JobHandle LBEOEDGEDHO(OICPILLJALL<LocalDeformableScaleData_v1> component_4, HIDPEOBBDKH<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : JMEFIFNMAAM
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public OICPILLJALL<SerializedDataLayerVersionData_v1> component_13;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public HIDPEOBBDKH<SerializedDataLayerVersionData> component_14;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7F612E0", Offset = "0x7F5F8E0", VA = "0x187F612E0")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7F612D0", Offset = "0x7F5F8D0", VA = "0x187F612D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override LHMKAIAPMBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7F61110", Offset = "0x7F5F710", VA = "0x187F61110", Slot = "14")]
			get
			{
				return default(LHMKAIAPMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F61160", Offset = "0x7F5F760", VA = "0x187F61160", Slot = "15")]
		protected override void KNOANLOJGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F615A0", Offset = "0x7F5FBA0", VA = "0x187F615A0")]
		private JobHandle PNGIPCEPPCL(OICPILLJALL<SerializedDataLayerVersionData_v1> component_13, HIDPEOBBDKH<SerializedDataLayerVersionData> component_14, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : JMEFIFNMAAM
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public OICPILLJALL<ReplicatorPreallocatedObjectCountData_v1> component_21;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public HIDPEOBBDKH<ReplicatorPreallocatedObjectCountData> component_22;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7F60E00", Offset = "0x7F5F400", VA = "0x187F60E00")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7F60DF0", Offset = "0x7F5F3F0", VA = "0x187F60DF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override LHMKAIAPMBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7F60B00", Offset = "0x7F5F100", VA = "0x187F60B00", Slot = "14")]
			get
			{
				return default(LHMKAIAPMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7F60C80", Offset = "0x7F5F280", VA = "0x187F60C80", Slot = "15")]
		protected override void KNOANLOJGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F60B50", Offset = "0x7F5F150", VA = "0x187F60B50")]
		private JobHandle INMENELMAPF(OICPILLJALL<ReplicatorPreallocatedObjectCountData_v1> component_21, HIDPEOBBDKH<ReplicatorPreallocatedObjectCountData> component_22, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : JMEFIFNMAAM
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public OICPILLJALL<ToolCleanupStatusData_v1> component_26;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public HIDPEOBBDKH<ToolCleanupStatusData> component_27;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7F618F0", Offset = "0x7F5FEF0", VA = "0x187F618F0")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7F618E0", Offset = "0x7F5FEE0", VA = "0x187F618E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override LHMKAIAPMBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7F61720", Offset = "0x7F5FD20", VA = "0x187F61720", Slot = "14")]
			get
			{
				return default(LHMKAIAPMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7F61770", Offset = "0x7F5FD70", VA = "0x187F61770", Slot = "15")]
		protected override void KNOANLOJGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7F61C10", Offset = "0x7F60210", VA = "0x187F61C10")]
		private JobHandle MMBAKNHLHNM(OICPILLJALL<ToolCleanupStatusData_v1> component_26, HIDPEOBBDKH<ToolCleanupStatusData> component_27, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : JMEFIFNMAAM
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public OICPILLJALL<ReplicatorData_v1> component_34;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public HIDPEOBBDKH<ReplicatorData> component_35;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7F607B0", Offset = "0x7F5EDB0", VA = "0x187F607B0")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7F607A0", Offset = "0x7F5EDA0", VA = "0x187F607A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override LHMKAIAPMBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7F604B0", Offset = "0x7F5EAB0", VA = "0x187F604B0", Slot = "14")]
			get
			{
				return default(LHMKAIAPMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F60630", Offset = "0x7F5EC30", VA = "0x187F60630", Slot = "15")]
		protected override void KNOANLOJGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7F60500", Offset = "0x7F5EB00", VA = "0x187F60500")]
		private JobHandle KFIJIKGCKKJ(OICPILLJALL<ReplicatorData_v1> component_34, HIDPEOBBDKH<ReplicatorData> component_35, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : JMEFIFNMAAM
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public OICPILLJALL<InventionInstanceIdData_v1> component_38;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public HIDPEOBBDKH<InventionInstanceIdData> component_39;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7F5BBA0", Offset = "0x7F5A1A0", VA = "0x187F5BBA0")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7F5BB90", Offset = "0x7F5A190", VA = "0x187F5BB90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override LHMKAIAPMBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7F5B9D0", Offset = "0x7F59FD0", VA = "0x187F5B9D0", Slot = "14")]
			get
			{
				return default(LHMKAIAPMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F5BA20", Offset = "0x7F5A020", VA = "0x187F5BA20", Slot = "15")]
		protected override void KNOANLOJGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B8A0", Offset = "0x7F59EA0", VA = "0x187F5B8A0")]
		private JobHandle ACJLBLFMCNJ(OICPILLJALL<InventionInstanceIdData_v1> component_38, HIDPEOBBDKH<InventionInstanceIdData> component_39, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : JMEFIFNMAAM
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OICPILLJALL<OMShapeContainerData_v1> component_43;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public HIDPEOBBDKH<OMShapeContainerData> component_44;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7F5C7C0", Offset = "0x7F5ADC0", VA = "0x187F5C7C0")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7F5C7B0", Offset = "0x7F5ADB0", VA = "0x187F5C7B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override LHMKAIAPMBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7F5C5F0", Offset = "0x7F5ABF0", VA = "0x187F5C5F0", Slot = "14")]
			get
			{
				return default(LHMKAIAPMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C640", Offset = "0x7F5AC40", VA = "0x187F5C640", Slot = "15")]
		protected override void KNOANLOJGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CAB0", Offset = "0x7F5B0B0", VA = "0x187F5CAB0")]
		private JobHandle OCBMHKMNIIE(OICPILLJALL<OMShapeContainerData_v1> component_43, HIDPEOBBDKH<OMShapeContainerData> component_44, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : JMEFIFNMAAM
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public OICPILLJALL<AuthoredAIIdData_v1> component_53;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public OICPILLJALL<AuthoredAIIdData_v2> component_54;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public OICPILLJALL<AuthoredAIIdData_v3> component_55;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public HIDPEOBBDKH<AuthoredAIIdData> component_56;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7F5B130", Offset = "0x7F59730", VA = "0x187F5B130")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7F5B120", Offset = "0x7F59720", VA = "0x187F5B120", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override LHMKAIAPMBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7F5ACD0", Offset = "0x7F592D0", VA = "0x187F5ACD0", Slot = "14")]
			get
			{
				return default(LHMKAIAPMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7F5AEC0", Offset = "0x7F594C0", VA = "0x187F5AEC0", Slot = "15")]
		protected override void KNOANLOJGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F5AD20", Offset = "0x7F59320", VA = "0x187F5AD20")]
		private JobHandle KLNMCGHKFHI(OICPILLJALL<AuthoredAIIdData_v1> component_53, OICPILLJALL<AuthoredAIIdData_v2> component_54, OICPILLJALL<AuthoredAIIdData_v3> component_55, HIDPEOBBDKH<AuthoredAIIdData> component_56, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : JMEFIFNMAAM
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public OICPILLJALL<ContainerCollisionLayerData_v1> component_66;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public HIDPEOBBDKH<PhysicsModelCollisionLayerData> component_67;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7F5E840", Offset = "0x7F5CE40", VA = "0x187F5E840")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7F5E830", Offset = "0x7F5CE30", VA = "0x187F5E830", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override LHMKAIAPMBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7F5E670", Offset = "0x7F5CC70", VA = "0x187F5E670", Slot = "14")]
			get
			{
				return default(LHMKAIAPMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E6C0", Offset = "0x7F5CCC0", VA = "0x187F5E6C0", Slot = "15")]
		protected override void KNOANLOJGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7F5EB30", Offset = "0x7F5D130", VA = "0x187F5EB30")]
		private JobHandle OAGBFKPJAAC(OICPILLJALL<ContainerCollisionLayerData_v1> component_66, HIDPEOBBDKH<PhysicsModelCollisionLayerData> component_67, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : JMEFIFNMAAM
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public OICPILLJALL<ContainerGrabbableModeData_v1> component_71;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public HIDPEOBBDKH<PhysicsModelGrabbableModeData> component_72;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7F60170", Offset = "0x7F5E770", VA = "0x187F60170")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7F60160", Offset = "0x7F5E760", VA = "0x187F60160", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override LHMKAIAPMBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7F5FE70", Offset = "0x7F5E470", VA = "0x187F5FE70", Slot = "14")]
			get
			{
				return default(LHMKAIAPMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7F5FEC0", Offset = "0x7F5E4C0", VA = "0x187F5FEC0", Slot = "15")]
		protected override void KNOANLOJGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7F60030", Offset = "0x7F5E630", VA = "0x187F60030")]
		private JobHandle LENFDBENLKB(OICPILLJALL<ContainerGrabbableModeData_v1> component_71, HIDPEOBBDKH<PhysicsModelGrabbableModeData> component_72, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : JMEFIFNMAAM
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public OICPILLJALL<ContainerFlagsData_v1> component_78;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public OICPILLJALL<ContainerFlagsData_v2> component_79;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public OICPILLJALL<PhysicsModelFlagsData_v3> component_80;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public HIDPEOBBDKH<PhysicsModelFlagsData> component_81;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7F5F750", Offset = "0x7F5DD50", VA = "0x187F5F750")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7F5F740", Offset = "0x7F5DD40", VA = "0x187F5F740", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override LHMKAIAPMBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7F5F2F0", Offset = "0x7F5D8F0", VA = "0x187F5F2F0", Slot = "14")]
			get
			{
				return default(LHMKAIAPMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F4E0", Offset = "0x7F5DAE0", VA = "0x187F5F4E0", Slot = "15")]
		protected override void KNOANLOJGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F340", Offset = "0x7F5D940", VA = "0x187F5F340")]
		private JobHandle HMKEILMMOMA(OICPILLJALL<ContainerFlagsData_v1> component_78, OICPILLJALL<ContainerFlagsData_v2> component_79, OICPILLJALL<PhysicsModelFlagsData_v3> component_80, HIDPEOBBDKH<PhysicsModelFlagsData> component_81, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : JMEFIFNMAAM
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public OICPILLJALL<ContainerCollisionModeData_v1> component_82;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public HIDPEOBBDKH<PhysicsModelCollisionModeData> component_83;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7F5EFB0", Offset = "0x7F5D5B0", VA = "0x187F5EFB0")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7F5EFA0", Offset = "0x7F5D5A0", VA = "0x187F5EFA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override LHMKAIAPMBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7F5ECB0", Offset = "0x7F5D2B0", VA = "0x187F5ECB0", Slot = "14")]
			get
			{
				return default(LHMKAIAPMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7F5EE30", Offset = "0x7F5D430", VA = "0x187F5EE30", Slot = "15")]
		protected override void KNOANLOJGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7F5ED00", Offset = "0x7F5D300", VA = "0x187F5ED00")]
		private JobHandle KMJFLDJKNOL(OICPILLJALL<ContainerCollisionModeData_v1> component_82, HIDPEOBBDKH<PhysicsModelCollisionModeData> component_83, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : JMEFIFNMAAM
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public OICPILLJALL<ObjectPolicyData_v1> component_86;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public OICPILLJALL<ObjectPolicyData_v2> component_87;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public OICPILLJALL<ObjectPolicyData_v3> component_88;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public OICPILLJALL<ObjectPolicyData_v4> component_89;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public OICPILLJALL<ObjectPolicyData_v5> component_90;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public HIDPEOBBDKH<ObjectPolicyData> component_91;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7F5CFA0", Offset = "0x7F5B5A0", VA = "0x187F5CFA0")]
			private void NLCPDOEBKCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7F5CF90", Offset = "0x7F5B590", VA = "0x187F5CF90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly LHMKAIAPMBI log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override LHMKAIAPMBI Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7F5CC30", Offset = "0x7F5B230", VA = "0x187F5CC30", Slot = "14")]
			get
			{
				return default(LHMKAIAPMBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CC80", Offset = "0x7F5B280", VA = "0x187F5CC80", Slot = "15")]
		protected override void KNOANLOJGPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DD90", Offset = "0x7F5C390", VA = "0x187F5DD90")]
		private JobHandle OFNCEPGCEPF(OICPILLJALL<ObjectPolicyData_v1> component_86, OICPILLJALL<ObjectPolicyData_v2> component_87, OICPILLJALL<ObjectPolicyData_v3> component_88, OICPILLJALL<ObjectPolicyData_v4> component_89, OICPILLJALL<ObjectPolicyData_v5> component_90, HIDPEOBBDKH<ObjectPolicyData> component_91, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class BPNJIHNCDGA
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x38D2750", Offset = "0x38D0D50", VA = "0x1838D2750")]
	public static void EHBBHCLMDNG<T, U>(T DNGPJGHLFNP, [Out] U HBGAGONLKKF) where T : struct where U : struct
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
